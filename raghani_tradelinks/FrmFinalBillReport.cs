using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using RT.BL;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmFinalBillReport : Form
    {
        TPLDBEntities db = null;
        FinalBillReport report;
        public FrmFinalBillReport()
        {
            InitializeComponent();
            db = new TPLDBEntities();
            report = new FinalBillReport();
        }

        private void FrmFinalBillReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmFinalBillReport_Load(object sender, EventArgs e)
        {
            PopulateDropdown();
        }

        private void PopulateDropdown()
        {
            try
            {
                List<Supplier> supplierList = (from c in db.Suppliers
                                               where c.IsDeleted == false
                                               select c).ToList();

                supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });

                cmbSupplier.Properties.DataSource = supplierList;
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierId") { Visible = false });
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierName"));
                cmbSupplier.Properties.DisplayMember = "SupplierName";
                cmbSupplier.Properties.ValueMember = "SupplierId";
                cmbSupplier.EditValue = -1;
                cmbSupplier.Properties.ShowHeader = false;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    GenerateReport();
                    report.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    GenerateReport();
                    report.PrintDialog();
                }
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private bool ValidateInput()
        {
            int supplierId = (int)cmbSupplier.EditValue;

            if (supplierId == -1)
            {
                MessageBox.Show("Please select a Supplier");
                cmbSupplier.Focus();
                return false;
            }

            return true;
        }

        private void GenerateReport()
        {
            try
            {
                Supplier selectedSupplier = db.Suppliers.FirstOrDefault(c => c.SupplierId == (int)cmbSupplier.EditValue);
                SupplierContactInfo sInfo = db.SupplierContactInfoes.FirstOrDefault(ci => ci.fkSupplierId == (int)cmbSupplier.EditValue);

                FinalBill finalBill = (from fBill in db.FinalBills
                                       where fBill.fkSupplierId == (int)cmbSupplier.EditValue
                                             && fBill.BillDate >= CurrentFinancialYear.StartDate && fBill.BillDate <= CurrentFinancialYear.EndDate
                                       select fBill).FirstOrDefault();

                if (finalBill != null)
                {
                    report.Parameters["SupplierName"].Value = cmbSupplier.Text;
                    report.Parameters["Address"].Value = sInfo.Address;
                    report.Parameters["BillAmt"].Value = finalBill.Amout - finalBill.RaisedAmt;
                    report.Parameters["BillDate"].Value = finalBill.BillDate;
                    report.Parameters["BillNo"].Value = finalBill.BillMemoNo;
                    report.Parameters["City"].Value = sInfo.City;
                    report.Parameters["EducationCess"].Value = finalBill.ECAmt;
                    report.Parameters["LessBillRaised"].Value = finalBill.RaisedAmt;
                    report.Parameters["LessCreditNote"].Value = finalBill.CreditNoted;
                    report.Parameters["OtherTax"].Value = finalBill.OtherAmt;
                    report.Parameters["Pin"].Value = sInfo.Pin;
                    report.Parameters["ServiceTaxPercentage"].Value = finalBill.STAmt;
                    report.Parameters["SwachhTaxPercentage"].Value = finalBill.SBAmt;
                    report.Parameters["TotalBillValue"].Value = finalBill.TotalAmt;

                    FinalBillReportData reportData = new FinalBillReportData();
                    reportData.Particulars = new List<Particular>();
                    var collData = (from col in db.CollectionEntries
                                    where col.fkSupplierId.Value == (int)cmbSupplier.EditValue && col.IsFinalBillGenerated == false &&
                                    System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) >= CurrentFinancialYear.StartDate && System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) <= CurrentFinancialYear.EndDate
                                    select col).ToList();

                    decimal totalSupplierAmt = collData.Sum(q => q.DraftAmount.Value);
                    reportData.Particulars.Add(new Particular
                    {
                        SlNo = 1,
                        Details = string.Format(@"BY COMMISSION @ {0}% ON Collection IMPLEMENTED BY US DURING {1} TO {2}
                                                    OF TOTAL AMOUNT Rs {3} AS PER DETAILS ATTACHED", selectedSupplier.Commission, CurrentFinancialYear.StartDate.ToShortDateString(), CurrentFinancialYear.EndDate.ToShortDateString(), totalSupplierAmt.ToString()),
                        Amount = Convert.ToDecimal(finalBill.Amout)
                    });

                    reportData.BillRaisedDetails = (from fBill in db.FinalBillDetails
                                                    where fBill.BillNo.ToLower().Equals(finalBill.BillMemoNo)
                                                    select new BillsRaisedDetail
                                                    {
                                                        BillDate = fBill.BillDate,
                                                        CommissionAmount = fBill.Commission,
                                                        EducationCess = fBill.ECAmt,
                                                        Others = fBill.Others,
                                                        ServiceTax = fBill.STaxAmt,
                                                        Swachh = fBill.SwachhTax,
                                                        RoundedOff = fBill.RoundOff
                                                    }).ToList();

                    reportData.BillBreakup = new List<CurrentBillBreakup>();
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "Commission",
                        TotalBillBreakupValue = finalBill.Amout,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                            ? reportData.BillRaisedDetails.Sum(br => br.CommissionAmount) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "S.Tax %",
                        TotalBillBreakupValue = finalBill.STAmt,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                                ? reportData.BillRaisedDetails.Sum(br => br.ServiceTax) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "Swachh %",
                        TotalBillBreakupValue = finalBill.SBAmt,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                                ? reportData.BillRaisedDetails.Sum(br => br.Swachh) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "E.Cess %",
                        TotalBillBreakupValue = finalBill.ECAmt,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                                ? reportData.BillRaisedDetails.Sum(br => br.EducationCess) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "Others",
                        TotalBillBreakupValue = finalBill.OtherAmt,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                                ? reportData.BillRaisedDetails.Sum(br => br.Others) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "RoundedOff",
                        TotalBillBreakupValue = 0,
                        BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                                ? reportData.BillRaisedDetails.Sum(br => br.RoundedOff) : 0
                    });
                    reportData.BillBreakup.Add(new CurrentBillBreakup
                    {
                        Description = "LessCreditNote",
                        TotalBillBreakupValue = finalBill.CreditNoted,
                        BillRaisedValue = 0
                    });

                    foreach (Band band in report.Bands)
                    {
                        if (band is DetailReportBand)
                        {
                            if (band.Name.Equals("ParticularsDetailReport"))
                            {
                                var particularsReport = band as DetailReportBand;
                                particularsReport.DataSource = reportData;
                                particularsReport.DataMember = "Particulars";
                            }
                            else if (band.Name.Equals("BillRaisedDetailReport"))
                            {
                                if (reportData.BillRaisedDetails == null || reportData.BillRaisedDetails.Count == 0)
                                {
                                    band.Visible = false;
                                }
                                else
                                {
                                    band.Visible = true;
                                    var billRaisedDetailReport = band as DetailReportBand;
                                    billRaisedDetailReport.DataSource = reportData;
                                    billRaisedDetailReport.DataMember = "BillRaisedDetails";
                                }
                            }
                            else if (band.Name.Equals("BillBreakupDetailReport"))
                            {
                                var billBreakupDetailReport = band as DetailReportBand;
                                billBreakupDetailReport.DataSource = reportData;
                                billBreakupDetailReport.DataMember = "BillBreakup";
                            }
                        }
                    }

                    report.CreateDocument();
                }
                else
                {
                    MessageBox.Show("Final bill is not generated for the supplier for current financial year");
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }
}

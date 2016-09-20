using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.DL;
using RT.BL;
using DevExpress.XtraReports.UI;

namespace raghani_tradelinks
{
    public partial class FrmFinalBillEntry : Form
    {
        TPLDBEntities db = new TPLDBEntities();
        List<DealingType> lstKeys = new List<DealingType>();
        List<int> CollIds = new List<int>();
        FinalBillReport report;

        public FrmFinalBillEntry()
        {
            InitializeComponent();
            report = new FinalBillReport();
        }

        private void FrmFinalBillEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmFinalBillEntry_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                List<Supplier> supplierList = CommonMethods.GetSupplierData();
                supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
                cmbSupplier.DataSource = supplierList;
                cmbSupplier.ValueMember = "SupplierId";
                cmbSupplier.DisplayMember = "SupplierName";

                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/bill_type.json"));
                var _sourceList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbBillType.DataSource = _sourceList;
                cmbBillType.SelectedIndex = 0;

                dtpBillDate.Value = DateTime.Now;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/settings_keys.json"));
                lstKeys = JsonConvert.DeserializeObject<List<DealingType>>(result);
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FinalBill fb = new FinalBill();
                fb.Amout = Convert.ToDouble(txtAmt.Text);
                fb.BillDate = dtpBillDate.Value;
                fb.BillDetails = txtBillDetails.Text;
                fb.BillMemo = txtBillMemo.Text;
                fb.BillMemoNo = txtBillMemoNo.Text;
                fb.BillType = cmbBillType.SelectedValue.ToString();
                fb.CreatedBy = User.UserName;
                fb.CreatedDate = DateTime.Now.ToString();
                fb.CreditNoted = Convert.ToDouble(txtLessCreditNotes.Text);
                fb.ECAmt = Convert.ToDouble(txtECAmt.Text);
                fb.ECPer = Convert.ToDouble(txtECPer.Text);
                fb.EditedBy = User.UserName;
                fb.EditedDate = DateTime.Now.ToString();
                fb.fkSupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
                fb.OtherAmt = Convert.ToDouble(txtOthersAmt.Text);
                fb.OtherPer = Convert.ToDouble(txtOthersPer.Text);
                fb.RaisedAmt = Convert.ToDouble(txtBillLess.Text);
                fb.SBAmt = Convert.ToDouble(txtSBPerAmt.Text);
                fb.SBPer = Convert.ToDouble(txtSBPer.Text);
                fb.STAmt = Convert.ToDouble(txtStaxAmt.Text);
                fb.STaxPer = Convert.ToDouble(txtSTaxPer.Text);
                fb.TotalAmt = Convert.ToDouble(txtTotalAmt.Text);

                if (grdData.RowCount > 0)
                {
                    foreach (DataGridViewRow row in grdData.Rows)
                    {
                        FinalBillDetail fbd = new FinalBillDetail();
                        //fbd.BillDate = row
                    }
                }

                List<CollectionEntry> lstColls = db.CollectionEntries.Where(q => CollIds.Contains(q.CollectionEntryId)).ToList();
                foreach (CollectionEntry etry in lstColls)
                {
                    etry.IsFinalBillGenerated = true;
                }

                db.FinalBills.Add(fb);
                db.SaveChanges();

                MessageBox.Show("Data saved successfully");

                if (txtPrintBillFlag.Text.ToLower().Equals("y"))
                    PrintFinalBillReport();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void PrintFinalBillReport()
        {
            try
            {
                GenerateReport();
                report.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void GenerateReport()
        {
            try
            {
                Supplier selectedSupplier = db.Suppliers.FirstOrDefault(c => c.SupplierId == (int)cmbSupplier.SelectedValue);
                SupplierContactInfo sInfo = db.SupplierContactInfoes.FirstOrDefault(ci => ci.fkSupplierId == (int)cmbSupplier.SelectedValue);

                report.Parameters["SupplierName"].Value = cmbSupplier.Text;
                report.Parameters["Address"].Value = sInfo.Address;
                report.Parameters["BillAmt"].Value = Convert.ToDecimal(txtTotalAmt.Text) - Convert.ToDecimal(txtBillLess.Text);
                report.Parameters["BillDate"].Value = dtpBillDate.Value;
                report.Parameters["BillNo"].Value = txtBillMemoNo.Text;
                report.Parameters["City"].Value = sInfo.City;
                report.Parameters["EducationCess"].Value = txtECAmt.Text;
                report.Parameters["LessBillRaised"].Value = txtBillLess.Text;
                report.Parameters["LessCreditNote"].Value = txtLessCreditNotes.Text;
                report.Parameters["OtherTax"].Value = txtOthersAmt.Text;
                report.Parameters["Pin"].Value = sInfo.Pin;
                report.Parameters["ServiceTaxPercentage"].Value = txtStaxAmt.Text;
                report.Parameters["SwachhTaxPercentage"].Value = txtSBPerAmt.Text;
                report.Parameters["TotalBillValue"].Value = txtTotalAmt.Text;

                FinalBillReportData reportData = new FinalBillReportData();
                reportData.Particulars = new List<Particular>();
                var collData = (from col in db.CollectionEntries
                                where col.fkSupplierId.Value == (int)cmbSupplier.SelectedValue && col.IsFinalBillGenerated == false &&
                                System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) >= CurrentFinancialYear.StartDate && System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) <= CurrentFinancialYear.EndDate
                                select col).ToList();

                decimal totalSupplierAmt = collData.Sum(q => q.DraftAmount.Value);
                reportData.Particulars.Add(new Particular
                {
                    SlNo = 1,
                    Details = string.Format(@"BY COMMISSION @ {0}% ON Collection IMPLEMENTED BY US DURING {1} TO {2}
                                                    OF TOTAL AMOUNT Rs {3} AS PER DETAILS ATTACHED", selectedSupplier.Commission, CurrentFinancialYear.StartDate.ToShortDateString(), CurrentFinancialYear.EndDate.ToShortDateString(), totalSupplierAmt.ToString()),
                    Amount = Convert.ToDecimal(txtAmt.Text)
                });

                reportData.BillRaisedDetails = (from fBill in db.FinalBillDetails
                                                where fBill.BillNo.ToLower().Equals(txtBillMemoNo.Text.ToLower())
                                                select new BillsRaisedDetail
                                                {
                                                    BillDate = fBill.BillDate,
                                                    CommissionAmount = fBill.Commission,
                                                    EducationCess = fBill.ECAmt,
                                                    Others = Convert.ToDouble(fBill.Others),
                                                    ServiceTax = fBill.STaxAmt,
                                                    Swachh = fBill.SwachhTax,
                                                    RoundedOff = fBill.RoundOff
                                                }).ToList();

                reportData.BillBreakup = new List<CurrentBillBreakup>();
                reportData.BillBreakup.Add(new CurrentBillBreakup
                {
                    Description = "Commission",
                    TotalBillBreakupValue = Convert.ToDouble(txtAmt.Text),
                    BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                        ? reportData.BillRaisedDetails.Sum(br => br.CommissionAmount) : 0
                });
                reportData.BillBreakup.Add(new CurrentBillBreakup
                {
                    Description = "S.Tax %",
                    TotalBillBreakupValue = Convert.ToDouble(txtStaxAmt.Text),
                    BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                            ? reportData.BillRaisedDetails.Sum(br => br.ServiceTax) : 0
                });
                reportData.BillBreakup.Add(new CurrentBillBreakup
                {
                    Description = "Swachh %",
                    TotalBillBreakupValue = Convert.ToDouble(txtSBPerAmt.Text),
                    BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                            ? reportData.BillRaisedDetails.Sum(br => br.Swachh) : 0
                });
                reportData.BillBreakup.Add(new CurrentBillBreakup
                {
                    Description = "E.Cess %",
                    TotalBillBreakupValue = Convert.ToDouble(txtECAmt.Text),
                    BillRaisedValue = reportData.BillRaisedDetails != null && reportData.BillRaisedDetails.Count > 0
                                            ? reportData.BillRaisedDetails.Sum(br => br.EducationCess) : 0
                });
                reportData.BillBreakup.Add(new CurrentBillBreakup
                {
                    Description = "Others",
                    TotalBillBreakupValue = Convert.ToDouble(txtOthersAmt.Text),
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
                    TotalBillBreakupValue = Convert.ToDouble(txtLessCreditNotes.Text),
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
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSupplier.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedIndex != 0)
                {
                    DateTime frmDate;
                    DateTime toDate;
                    if (DateTime.Now.Month >= 4)
                    {
                        int year = DateTime.Now.Year;
                        frmDate = new DateTime(year, 4, 1);
                        toDate = new DateTime(year + 1, 3, 31);
                    }
                    else
                    {
                        int year = DateTime.Now.Year;
                        frmDate = new DateTime(year - 1, 4, 1);
                        toDate = new DateTime(year, 3, 31);
                    }

                    List<FinalBill> generatedData = (from fb in db.FinalBills
                                                     where System.Data.Entity.DbFunctions.TruncateTime(fb.BillDate) >= frmDate.Date && System.Data.Entity.DbFunctions.TruncateTime(fb.BillDate) <= toDate.Date
                                                     && fb.fkSupplierId == (int)cmbSupplier.SelectedValue
                                                     select fb).ToList();

                    double raisedAmt = 0d;
                    decimal Amt = decimal.Zero;
                    decimal sTax = decimal.Zero;
                    decimal sbTax = decimal.Zero;
                    decimal ecTax = decimal.Zero;
                    decimal others = decimal.Zero;
                    decimal totalBill = decimal.Zero;
                    decimal creditNote = decimal.Zero;

                    if (generatedData != null)
                    {
                        List<FinalBillDetail> lstFBDetails = (from gd in generatedData
                                                              select new FinalBillDetail 
                                                              { 
                                                                BillDate = gd.BillDate,
                                                                BillNo = gd.BillMemoNo,
                                                                Commission = gd.TotalAmt,
                                                                
                                                              }).ToList();
                        grdData.DataSource = lstFBDetails;
                        raisedAmt = lstFBDetails.Sum(q => q.DraftAmt.Value);
                    }

                    var collData = (from col in db.CollectionEntries
                                    where col.fkSupplierId.Value == (int)cmbSupplier.SelectedValue && col.IsFinalBillGenerated == false &&
                                    System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) >= frmDate.Date && System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) <= toDate.Date
                                    select col).ToList();

                    CollIds = collData.Select(q => q.CollectionEntryId).ToList();

                    Amt = collData.Sum(q => q.DraftAmount.Value);

                    txtAmt.Text = Amt.ToString();
                    txtSTaxPer.Text = CommonMethods.GetSettingsValue(lstKeys[0].Name);
                    sTax = (Amt * (Convert.ToDecimal(txtSTaxPer.Text) / (decimal)100.00));
                    txtStaxAmt.Text = sTax.ToString();
                    txtECPer.Text = "0";
                    txtECAmt.Text = "0.00";
                    txtSBPer.Text = CommonMethods.GetSettingsValue(lstKeys[1].Name);
                    sbTax = (Amt * (Convert.ToDecimal(txtSBPer.Text) / (decimal)100.00));
                    txtSBPerAmt.Text = sbTax.ToString();
                    totalBill = Amt + sTax + sbTax + ecTax;
                    others = (Math.Ceiling(totalBill) - totalBill);
                    txtOthersPer.Text = "0";
                    txtOthersAmt.Text = others.ToString();
                    txtLessCreditNotes.Text = creditNote.ToString();

                    txtBillLess.Text = raisedAmt.ToString();
                    txtTotalAmt.Text = (totalBill - (decimal)raisedAmt).ToString();

                    var newId = db.Database.SqlQuery<int>("select dbo.GetTableNewId('FinalBill') as Ident").ToList();
                    txtBillMemoNo.Text = "RTPL/" + frmDate.Year.ToString() + "-" + toDate.Year.ToString() + "/" + newId[0].ToString();
                }
                else
                {
                    grdData.DataSource = null;
                    txtBillLess.Text = "";
                    txtTotalAmt.Text = "";
                    txtAmt.Text = "";
                    txtSTaxPer.Text = "";
                    txtStaxAmt.Text = "";
                    txtECPer.Text = "";
                    txtECAmt.Text = "";
                    txtSBPer.Text = "";
                    txtSBPerAmt.Text = "";
                    txtOthersAmt.Text = "";
                    txtLessCreditNotes.Text = "";
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }

    public static class CurrentFinancialYear
    {
        private static DateTime currentDate;

        private static DateTime startDate;
        private static DateTime endDate;
        public static DateTime StartDate { get { return startDate; } }
        public static DateTime EndDate { get { return endDate; } }

        static CurrentFinancialYear()
        {
            currentDate = DateTime.Now;
            int startYear = currentDate.Month >= 4 && currentDate.Month <= 12 ? currentDate.Year : currentDate.AddYears(-1).Year;
            int endYear = startYear + 1;

            startDate = new DateTime(startYear, 4, 1);
            endDate = new DateTime(endYear, 3, 31);
        }
    }
}

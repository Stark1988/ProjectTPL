using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Parameters;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using RT.BL;
using DevExpress.XtraGrid.Columns;

namespace raghani_tradelinks
{
    public partial class FrmCustomerOutstanding : XtraForm
    {
        TPLDBEntities db = null;
        CustomerOutstandingReport report;

        public FrmCustomerOutstanding()
        {
            InitializeComponent();
            db = new TPLDBEntities();
            report = new CustomerOutstandingReport();
        }

        private void FrmCustomerOutstanding_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmCustomerOutstanding_Load(object sender, EventArgs e)
        {
            PopulateDropdown();
            dateAsOn.Value = DateTime.Now.Date;
        }

        private void PopulateDropdown()
        {
            try
            {
                List<Customer> customerList = (from c in db.Customers
                                               where c.IsDeleted == false
                                               select c).ToList();

                customerList.Insert(0, new Customer { CustomerId = -1, CustomerName = "Select Customer" });

                cmbCustomer.Properties.DataSource = customerList;
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerId") { Visible = false });
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerName"));
                cmbCustomer.Properties.DisplayMember = "CustomerName";
                cmbCustomer.Properties.ValueMember = "CustomerId";
                cmbCustomer.EditValue = -1;
                cmbCustomer.Properties.ShowHeader = false;

                List<Supplier> supplierList = (from s in db.Suppliers
                                               where s.IsDeleted == false
                                               select s).ToList();

                chkCmbSuppl.Properties.DataSource = supplierList;
                chkCmbSuppl.Properties.DisplayMember = "SupplierName";
                chkCmbSuppl.Properties.ValueMember = "SupplierId";
                chkCmbSuppl.Properties.NullText = "Select Suppliers";

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
                int customerId = (int)cmbCustomer.EditValue;

                if (customerId == -1)
                {
                    MessageBox.Show("Please select a customer");
                    cmbCustomer.Focus();
                    return;
                }
                int billsAgeingAbove = 0;
                if (!Int32.TryParse(txtBillsAgeingAbove.Text, out billsAgeingAbove))
                {
                    MessageBox.Show("Please enter valid value for bills ageing above");
                    txtBillsAgeingAbove.Focus();
                    return;
                }

                GenerateReport();

                report.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void GenerateReport()
        {
            try
            {
                int billsAgeingAbove = Convert.ToInt32(txtBillsAgeingAbove.Text);
                Customer selectedCustomer = db.Customers.FirstOrDefault(c => c.CustomerId == (int)cmbCustomer.EditValue);
                CustomerContactInfo cInfo = db.CustomerContactInfoes.FirstOrDefault(ci => ci.fkCustomerId == (int)cmbCustomer.EditValue);

                report.Parameters["CustomerName"].Value = cmbCustomer.Text;
                report.Parameters["Address"].Value = cInfo.Address;
                report.Parameters["City"].Value = cInfo.MstCity.CityName;
                report.Parameters["State"].Value = cInfo.MstState.StateName;
                report.Parameters["Mobile"].Value = cInfo.SMSCellNumber;
                report.Parameters["Pin"].Value = cInfo.Pincode;
                report.Parameters["OfficePh"].Value = cInfo.OfficePhone;
                report.Parameters["Proprietor"].Value = selectedCustomer.CustomerProprietors.FirstOrDefault(pr => pr.fkCustomerId == (int)cmbCustomer.EditValue).ProprietorName;
                report.Parameters["AsOnDate"].Value = dateAsOn.Text;
                report.Parameters["BillsAgeingAbove"].Value = txtBillsAgeingAbove.Text;

                var selectedSuppliers = chkCmbSuppl.Properties.GetItems().GetCheckedValues().Cast<int?>();

                CustomerOutstandingReportData ds = new CustomerOutstandingReportData();
                ds.SupplierData = (from lrEntry in db.SaleLREntries
                                   where lrEntry.fkCustomerId == (int)cmbCustomer.EditValue
                                   && (selectedSuppliers.Count() == 0 || (selectedSuppliers.Count() != 0 && selectedSuppliers.Contains(lrEntry.fkSupplierId)))
                                   && (billsAgeingAbove == 0
                                        || (DbFunctions.DiffDays((lrEntry.BillDate.HasValue ? lrEntry.BillDate.Value : DateTime.Now), DateTime.Now) > billsAgeingAbove))
                                   select new SupplierCOReport
                                   {
                                       BranchName = lrEntry.Customer.MstBranch.BranchName,
                                       SupplierName = lrEntry.Supplier.SupplierName,
                                       RefNo = lrEntry.BillNumber,
                                       BillAmt = lrEntry.BillAmount,
                                       Date = lrEntry.BillDate,
                                       ODD = DbFunctions.DiffDays((lrEntry.BillDate.HasValue ? lrEntry.BillDate.Value : DateTime.Now), DateTime.Now),
                                       //Collection = db.CollectionEntries
                                       //             .Where(cef => cef.fkCustomerId == (int)cmbCustomer.EditValue && cef.fkSupplierId == lrEntry.fkSupplierId)
                                       //             .Sum(ce => ce.DraftAmount),
                                       Collection = (from col in db.CollectionEntries
                                                     join cold in db.CollectionEntryDetails on col.CollectionEntryId equals cold.fkCollectionEntryId
                                                     where cold.RefNumber == lrEntry.BillNumber
                                                     select col.DraftAmount).Sum(),
                                       Discount = db.DiscountEntries
                                                    .Where(def => def.fkCustomerId == (int)cmbCustomer.EditValue && def.fkSupplierId == lrEntry.fkSupplierId && def.RefNumber == lrEntry.BillNumber)
                                                    .Sum(de => de.DiscountAmount),
                                       GR = db.GRNDebitNotes
                                                .Where(grf => grf.fkCustomerId == (int)cmbCustomer.EditValue && grf.fkSupplierId == lrEntry.fkSupplierId && grf.RefNumber == lrEntry.BillNumber)
                                                .Sum(gr => gr.Amount)
                                   }).ToList();


                ds.ReturnDraftData = (from rd in db.ReturnDraftCheques
                                      where rd.fkCustomerId == (int)cmbCustomer.EditValue
                                      select new ReturnDraftCOReport
                                      {
                                          CustomerName = rd.Customer.CustomerName,
                                          SupplierName = rd.Supplier.SupplierName,
                                          DraftDate = rd.DDChequeDate,
                                          ReturnDate = rd.ReturnDate,
                                          DrawnOn = rd.DrawnOn,
                                          DraftNumber = rd.DDChequeNumber,
                                          Amount = rd.Amount,
                                          BranchName = rd.Customer.MstBranch.BranchName
                                      }).ToList();

                foreach (Band band in report.Bands)
                {
                    if (band is DetailReportBand)
                    {
                        if (band.Name.Equals("SupplierDetailReport"))
                        {
                            var supplierDetailReport = band as DetailReportBand;
                            supplierDetailReport.DataSource = ds;
                            supplierDetailReport.DataMember = "SupplierData";
                        }
                        else if (band.Name.Equals("ReturnDraftDetailReport"))
                        {
                            if (ds.ReturnDraftData == null || ds.ReturnDraftData.Count == 0)
                            {
                                band.Visible = false;
                            }
                            else
                            {
                                var returnDraftDetailReport = band as DetailReportBand;
                                returnDraftDetailReport.DataSource = ds;
                                returnDraftDetailReport.DataMember = "ReturnDraftData";
                            }
                        }
                        else if (band.Name.Equals("GrandTotalDetailReport"))
                        {
                            var totalDetailReport = band as DetailReportBand;
                            totalDetailReport.DataSource = ds;
                            totalDetailReport.DataMember = "SupplierData";
                        }
                    }
                }

                report.CreateDocument();
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
                int customerId = (int)cmbCustomer.EditValue;

                if (customerId == -1)
                {
                    MessageBox.Show("Please select a customer");
                    cmbCustomer.Focus();
                    return;
                }
                int billsAgeingAbove = 0;
                if (!Int32.TryParse(txtBillsAgeingAbove.Text, out billsAgeingAbove))
                {
                    MessageBox.Show("Please enter valid value for bills ageing above");
                    txtBillsAgeingAbove.Focus();
                    return;
                }

                GenerateReport();
                report.PrintDialog();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void chkCmbSuppl_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (chkCmbSuppl.Properties.GetItems().GetCheckedValues().Count() == 0)
                chkCmbSuppl.Text = "Select Supplier Range";
        }
    }
}

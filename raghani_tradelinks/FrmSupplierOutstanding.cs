using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using RT.BL;
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

namespace raghani_tradelinks
{
    public partial class FrmSupplierOutstanding : Form
    {
        TPLDBEntities db = null;
        SupplierOutstandingReport report;

        public FrmSupplierOutstanding()
        {
            InitializeComponent();
            db = new TPLDBEntities();
            report = new SupplierOutstandingReport();
        }

        private void FrmSupplierOutstanding_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmSupplierOutstanding_Load(object sender, EventArgs e)
        {
            PopulateDropdown();
            dateAsOn.Value = DateTime.Now.Date;
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

                List<Customer> customerList = (from s in db.Customers
                                               where s.IsDeleted == false
                                               select s).ToList();

                chkCmbCustomer.Properties.DataSource = customerList;
                chkCmbCustomer.Properties.DisplayMember = "CustomerName";
                chkCmbCustomer.Properties.ValueMember = "CustomerId";
                chkCmbCustomer.Properties.NullText = "Select Customers";

            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void chkCmbCustomer_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (chkCmbCustomer.Properties.GetItems().GetCheckedValues().Count() == 0)
                chkCmbCustomer.Text = "Select Customer Range";
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
                if(ValidateInput())
                {
                    GenerateReport();
                    report.PrintDialog();
                }
            }
            catch (Exception ex)
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
            int billsAgeingAbove = 0;
            if (!Int32.TryParse(txtBillsAgeingAbove.Text, out billsAgeingAbove))
            {
                MessageBox.Show("Please enter valid value for bills ageing above");
                txtBillsAgeingAbove.Focus();
                return false;
            }
            return true;
        }

        private void GenerateReport()
        {
            try
            {
                int billsAgeingAbove = Convert.ToInt32(txtBillsAgeingAbove.Text);
                Supplier selectedSupplier = db.Suppliers.FirstOrDefault(c => c.SupplierId == (int)cmbSupplier.EditValue);
                SupplierContactInfo sInfo = db.SupplierContactInfoes.FirstOrDefault(ci => ci.fkSupplierId == (int)cmbSupplier.EditValue);
                var selectedCustomers = chkCmbCustomer.Properties.GetItems().GetCheckedValues().Cast<int?>();

                report.Parameters["SupplierName"].Value = cmbSupplier.Text;
                report.Parameters["Address"].Value = sInfo.Address;
                report.Parameters["City"].Value = sInfo.City;
                report.Parameters["State"].Value = sInfo.State;
                report.Parameters["Mobile"].Value = sInfo.SMSCellNumber;
                report.Parameters["Pin"].Value = sInfo.Pin;
                report.Parameters["OfficePh"].Value = sInfo.OfficePhone;
                report.Parameters["Proprietor"].Value = selectedSupplier.SupplierProprietors.FirstOrDefault(pr => pr.fkSupplierId == (int)cmbSupplier.EditValue).ProprietorName;
                report.Parameters["AsOnDate"].Value = dateAsOn.Text;
                report.Parameters["BillsAgeingAbove"].Value = txtBillsAgeingAbove.Text;

                SupplierOutstandingReportData ds = new SupplierOutstandingReportData();

                ds.CustomerData = (from lrEntry in db.SaleLREntries
                                   where lrEntry.fkSupplierId == (int)cmbSupplier.EditValue
                                   && (selectedCustomers.Count() == 0 || (selectedCustomers.Count() != 0 && selectedCustomers.Contains(lrEntry.fkCustomerId)))
                                   && lrEntry.BillDate <= dateAsOn.Value
                                   && (billsAgeingAbove == 0
                                        || (DbFunctions.DiffDays((lrEntry.BillDate.HasValue ? lrEntry.BillDate.Value : DateTime.Now), DateTime.Now) > billsAgeingAbove))
                                   select new CustomerSOReport
                                   {
                                       CustomerName = lrEntry.Customer.CustomerName,
                                       RefNo = lrEntry.BillNumber,
                                       BillAmt = lrEntry.BillAmount,
                                       Date = lrEntry.BillDate,
                                       ODD = DbFunctions.DiffDays((lrEntry.BillDate.HasValue ? lrEntry.BillDate.Value : DateTime.Now), DateTime.Now),
                                       Collection = (from col in db.CollectionEntries
                                                     join cold in db.CollectionEntryDetails on col.CollectionEntryId equals cold.fkCollectionEntryId
                                                     where cold.RefNumber == lrEntry.BillNumber
                                                     select col.DraftAmount).Sum(),
                                       Discount = db.DiscountEntries
                                                    .Where(def => def.fkSupplierId == (int)cmbSupplier.EditValue && def.fkCustomerId == lrEntry.fkCustomerId && def.RefNumber == lrEntry.BillNumber)
                                                    .Sum(de => de.DiscountAmount),
                                       GR = db.GRNDebitNotes
                                                .Where(grf => grf.fkCustomerId == (int)cmbSupplier.EditValue && grf.fkSupplierId == lrEntry.fkSupplierId && grf.RefNumber == lrEntry.BillNumber)
                                                .Sum(gr => gr.Amount)
                                   }).ToList();

                foreach (Band band in report.Bands)
                {
                    if (band is DetailReportBand)
                    {
                        if (band.Name.Equals("CustomerDetailReport"))
                        {
                            var customerDetailReport = band as DetailReportBand;
                            customerDetailReport.DataSource = ds;
                            customerDetailReport.DataMember = "CustomerData";
                        }
                        else if (band.Name.Equals("GrandTotalDetailReport"))
                        {
                            var totalDetailReport = band as DetailReportBand;
                            totalDetailReport.DataSource = ds;
                            totalDetailReport.DataMember = "CustomerData";
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
    }
}

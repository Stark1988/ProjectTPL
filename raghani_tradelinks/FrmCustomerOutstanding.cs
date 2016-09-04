using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.Parameters;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int customerId = (int)cmbCustomer.EditValue;

            if(customerId ==-1)
            {
                MessageBox.Show("Please select a customer");
                cmbCustomer.Focus();
                return;
            }
            int billsAgeingAbove = 0;
            if(!Int32.TryParse(txtBillsAgeingAbove.Text, out billsAgeingAbove))
            {
                MessageBox.Show("Please enter valid value for bills ageing above");
                txtBillsAgeingAbove.Focus();
                return;
            }

            Customer selectedCustomer = db.Customers.FirstOrDefault(c=> c.CustomerId == (int)cmbCustomer.EditValue);
            CustomerContactInfo cInfo = db.CustomerContactInfoes.FirstOrDefault(ci=> ci.fkCustomerId == (int)cmbCustomer.EditValue);

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

            CustomerOutstandingReportData ds = new CustomerOutstandingReportData();
            ds.SupplierData = new List<SupplierCOReport>();
            ds.SupplierData.Add(new SupplierCOReport
                {
                    SupplierName = "Supplier1",
                    BranchName = "Branch1",
                    Date = DateTime.Now,
                    RefNo = "JH092",
                    Collection = 15000,
                    BillAmt = 20000,
                    Discount = 1000,
                    GR = 2000,
                    Balance = 2000,
                    ODD = 5
                });
            ds.SupplierData.Add(new SupplierCOReport
            {
                SupplierName = "Supplier1",
                BranchName = "Branch1",
                Date = DateTime.Now,
                RefNo = "JH093",
                Collection = 15000,
                BillAmt = 20000,
                Discount = 1000,
                GR = 2000,
                Balance = 2000,
                ODD = 5
            });
            ds.SupplierData.Add(new SupplierCOReport
            {
                SupplierName = "Supplier2",
                BranchName = "Branch1",
                Date = DateTime.Now,
                RefNo = "JH094",
                Collection = 15000,
                BillAmt = 20000,
                Discount = 1000,
                GR = 2000,
                Balance = 2000,
                ODD = 5
            });

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

            foreach(Band band in report.Bands)
            {
                if(band is DetailReportBand)
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
            report.ShowPreviewDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            report.PrintDialog();
        }
    }    
}

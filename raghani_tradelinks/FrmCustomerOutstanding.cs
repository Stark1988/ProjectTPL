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
                return;
            }

            report.Parameters["CustomerName"].Value = "Param Customer";
            report.Parameters["Address"].Value = "Param Address";
            report.Parameters["City"].Value = "Pune";
            report.Parameters["Mobile"].Value = "54546516546";
            report.Parameters["Pin"].Value = "421306";

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

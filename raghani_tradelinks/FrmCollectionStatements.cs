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
    public partial class FrmCollectionStatements : Form
    {
        TPLDBEntities db = null;
        StatementOfCollectionReport report;

        public FrmCollectionStatements()
        {
            InitializeComponent();
            db = new TPLDBEntities();
            report = new StatementOfCollectionReport();
        }

        private void FrmCollectionStatements_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmCollectionStatements_Load(object sender, EventArgs e)
        {
            PopulateDropdown();
            dateFrom.Value = DateTime.Now.Date;
            dateTo.Value = DateTime.Now.Date;
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

            if(dateTo.Value < dateFrom.Value)
            {
                MessageBox.Show("To Date should be greater than From Date");
                dateTo.Focus();
                return false;
            }

            return true;
        }

        private void GenerateReport()
        {
            try
            {
                report.Parameters["SupplierName"].Value = cmbSupplier.Text;
                report.Parameters["FromDate"].Value = dateFrom.Text;
                report.Parameters["ToDate"].Value = dateTo.Text;

                //*************     Dummy Data      *************************

                StatementOfCollectionReportData ds = new StatementOfCollectionReportData();
                ds.StatementOfCollectionData = new List<RT.BL.StatementOfCollectionReport>();
                ds.StatementOfCollectionData.Add(new RT.BL.StatementOfCollectionReport
                    {
                        CustomerName = "Jay",
                        DraftReceiveDate = DateTime.Now.AddDays(-20),
                        DraftAmt = 10000
                    });

                //******************************************************************

                foreach (Band band in report.Bands)
                {
                    if (band is DetailReportBand)
                    {
                        if (band.Name.Equals("CustomerDetailReport"))
                        {
                            var customerDetailReport = band as DetailReportBand;
                            customerDetailReport.DataSource = ds;
                            customerDetailReport.DataMember = "StatementOfCollectionData";
                        }
                        else if (band.Name.Equals("GrandTotalDetailReport"))
                        {
                            var totalDetailReport = band as DetailReportBand;
                            totalDetailReport.DataSource = ds;
                            totalDetailReport.DataMember = "StatementOfCollectionData";
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
    }
}

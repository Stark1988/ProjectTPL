using DevExpress.XtraEditors.Controls;
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
    public partial class FrmCustomerOutstanding : Form
    {
        TPLDBEntities db = null;

        public FrmCustomerOutstanding()
        {
            InitializeComponent();
            db = new TPLDBEntities();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}

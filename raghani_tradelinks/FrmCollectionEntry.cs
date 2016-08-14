using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmCollectionEntry : Form
    {
        TPLDBEntities db = null;

        public FrmCollectionEntry()
        {
            InitializeComponent();
            db = new TPLDBEntities();
        }

        private void FrmCollectionEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        DataTable GetOrderDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ref Type", typeof(string));
            dt.Columns.Add("Ref No.", typeof(string));
            dt.Columns.Add("Ref Date", typeof(string));
            dt.Columns.Add("Ref Amt.", typeof(string));
            dt.Columns.Add("Discount", typeof(string));
            dt.Columns.Add("GR", typeof(string));
            dt.Columns.Add("Adjusted Amt.", typeof(string));
            return dt;
        }

        private void FrmCollectionEntry_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = GetOrderDataSource();

                List<Supplier> supplierList = (from s in db.Suppliers
                                               where s.IsDeleted == false
                                               select s).ToList();

                supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
                cmbSupplier.Properties.DataSource = supplierList;
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierId") { Visible = false });
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierName"));
                cmbSupplier.Properties.DisplayMember = "SupplierName";
                cmbSupplier.Properties.ValueMember = "SupplierId";
                cmbSupplier.EditValue = -1;
                cmbSupplier.Properties.ShowHeader = false;

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


                List<MstCourier> courierList = (from cour in db.MstCouriers
                                               where cour.IsDeleted == false
                                               select cour).ToList();

                courierList.Insert(0, new MstCourier { CourierMasterId = -1, CourierName = "Select Courier" });
                cmbCourier.Properties.DataSource = courierList;
                cmbCourier.Properties.Columns.Add(new LookUpColumnInfo("CourierMasterId") { Visible = false });
                cmbCourier.Properties.Columns.Add(new LookUpColumnInfo("CourierName"));
                cmbCourier.Properties.DisplayMember = "CourierName";
                cmbCourier.Properties.ValueMember = "CourierMasterId";
                cmbCourier.EditValue = -1;
                cmbCourier.Properties.ShowHeader = false;

                List<MstBank> bankList = (from bank in db.MstBanks
                                                where bank.IsDeleted == false
                                                select bank).ToList();

                bankList.Insert(0, new MstBank { BankId = -1, BankName = "Select Bank" });
                cmbBank.Properties.DataSource = bankList;
                cmbBank.Properties.Columns.Add(new LookUpColumnInfo("BankId") { Visible = false });
                cmbBank.Properties.Columns.Add(new LookUpColumnInfo("BankName"));
                cmbBank.Properties.DisplayMember = "BankName";
                cmbBank.Properties.ValueMember = "BankId";
                cmbBank.EditValue = -1;
                cmbBank.Properties.ShowHeader = false;

                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/collection_entry_source.json"));
                var _sourceList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbSource.Properties.Items.AddRange(_sourceList);
                cmbSource.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

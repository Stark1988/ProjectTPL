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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmReturnDraft : Form
    {
        TPLDBEntities db = null;

        public FrmReturnDraft()
        {
            InitializeComponent();
        }

        private void FrmReturnDraft_Load(object sender, EventArgs e)
        {
            db = new TPLDBEntities();
            PopulateDropdowns();

        }

        private void PopulateDropdowns()
        {
            List<Supplier> supplierList = (from s in db.Suppliers
                                           where s.IsDeleted == false
                                           select s).ToList();

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

            supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
            cmbSupplier.Properties.DataSource = supplierList;
            cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierId") { Visible = false });
            cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierName"));
            cmbSupplier.Properties.DisplayMember = "SupplierName";
            cmbSupplier.Properties.ValueMember = "SupplierId";
            cmbSupplier.EditValue = -1;
            cmbSupplier.Properties.ShowHeader = false;

            string resultDraftOrCheque = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_draftOrCheque.json"));
            var _draftOrChequeList = JsonConvert.DeserializeObject<List<DealingType>>(resultDraftOrCheque);
            cmbDraftOrCheque.Properties.Items.AddRange(_draftOrChequeList);
            cmbDraftOrCheque.SelectedIndex = 0;

            string resultDocuments = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_documents.json"));
            var _documentsList = JsonConvert.DeserializeObject<List<DealingType>>(resultDocuments);
            cmbDocuments.Properties.Items.AddRange(_documentsList);
            cmbDocuments.SelectedIndex = 0;

            string resultEnclosed = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_enclosed.json"));
            var _enclosedList = JsonConvert.DeserializeObject<List<DealingType>>(resultEnclosed);
            cmbEnclosed.Properties.Items.AddRange(_enclosedList);
            cmbEnclosed.SelectedIndex = 0;

            string resultType = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_type.json"));
            var _typeList = JsonConvert.DeserializeObject<List<DealingType>>(resultType);
            cmbType.Properties.Items.AddRange(_typeList);
            cmbType.SelectedIndex = 0;

            cmbDraftOrCheckNo.Properties.NullText = "Select Draft/Cheque No.";
        }

        private void cmbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbCustomer.EditValue != -1 && (int)cmbSupplier.EditValue != -1)
                {

                }
            }
            catch(Exception ex)
            {
                HandleException(ex);
            }
        }

        private void cmbSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbCustomer.EditValue != -1 && (int)cmbSupplier.EditValue != -1)
                {

                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}

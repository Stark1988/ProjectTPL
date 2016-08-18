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

        void BindGridView()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Ref Type", typeof(string));
            //dt.Columns.Add("Ref No.", typeof(string));
            //dt.Columns.Add("Ref Date", typeof(string));
            //dt.Columns.Add("Ref Amt.", typeof(string));
            //dt.Columns.Add("Discount", typeof(string));
            //dt.Columns.Add("GR", typeof(string));
            //dt.Columns.Add("Adjusted Amt.", typeof(string));
            //return dt;

            DataGridViewComboBoxColumn cmbRefType = new DataGridViewComboBoxColumn();
            cmbRefType.HeaderText = "Ref Type";
            cmbRefType.Name = "cmb";
            cmbRefType.MaxDropDownItems = 4;
            cmbRefType.Items.Add("Against Ref");
            cmbRefType.Items.Add("No Ref");
            grdEntry.Columns.Add(cmbRefType);

            DataGridViewComboBoxColumn cmbRefNo = new DataGridViewComboBoxColumn();
            cmbRefNo.HeaderText = "Ref No";
            cmbRefNo.Name = "cmbRefNo";
            grdEntry.Columns.Add(cmbRefNo);

            DataGridViewColumn clnRefDate = new DataGridViewColumn();
            clnRefDate.HeaderText = "Ref Date";
            clnRefDate.CellTemplate = new DataGridViewTextBoxCell();
            clnRefDate.ReadOnly = true;
            grdEntry.Columns.Add(clnRefDate);

            DataGridViewColumn clnRefAmt = new DataGridViewColumn();
            clnRefAmt.HeaderText = "Ref Amount";
            clnRefAmt.CellTemplate = new DataGridViewTextBoxCell();
            clnRefAmt.ReadOnly = true;
            grdEntry.Columns.Add(clnRefAmt);

            DataGridViewColumn clnDiscount = new DataGridViewColumn();
            clnDiscount.HeaderText = "Discount";
            clnDiscount.CellTemplate = new DataGridViewTextBoxCell();
            clnDiscount.ReadOnly = false;
            grdEntry.Columns.Add(clnDiscount);

            DataGridViewColumn clnGR = new DataGridViewColumn();
            clnGR.HeaderText = "GR";
            clnGR.CellTemplate = new DataGridViewTextBoxCell();
            clnGR.ReadOnly = false;
            grdEntry.Columns.Add(clnGR);

            DataGridViewColumn clnAdjAmt = new DataGridViewColumn();
            clnAdjAmt.HeaderText = "Adjusted Amount";
            clnAdjAmt.CellTemplate = new DataGridViewTextBoxCell();
            clnAdjAmt.ReadOnly = false;
            grdEntry.Columns.Add(clnAdjAmt);
        }

        void BindDropDownlists()
        {
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

            cmbCommRecd.SelectedIndex = 0;
            cmbPrint.SelectedIndex = 0;
            cmbPrintAdj.SelectedIndex = 0;
            cmbLocked.SelectedIndex = 0;

            dtpChequeDate.Value = DateTime.Now;
            dtpEntryDate.Value = DateTime.Now;
            dtpRecptDate.Value = DateTime.Now;
        }

        private void FrmCollectionEntry_Load(object sender, EventArgs e)
        {
            try
            {
                BindDropDownlists();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        int CurrentRow = -1;
        //add column in datagrid dropdown chnge

        private void cmbSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.EditValue.ToString() != "-1")
                {
                    BindGridView();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void cmbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.EditValue.ToString() != "-1")
                {
                    BindGridView();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void grdEntry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdEntry.CurrentCell.Value.ToString() == "Against Ref")
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)grdEntry.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                    var data = (from lr in db.SaleLREntries
                                where lr.fkSupplierId == (int)cmbSupplier.EditValue && lr.fkCustomerId == (int)cmbCustomer.EditValue
                                select new
                                {
                                    RefNo = lr.BillNumber,
                                    RefDate = lr.BillDate,
                                    RefAmt = lr.BillAmount,
                                }).ToList()
                                .Select(q => new GridCell
                                                {
                                                    RefNo = q.RefNo,
                                                    RefDateAmt = q.RefDate.Value.ToString("dd/MM/yyyy") + "##" + q.RefAmt.Value.ToString(),
                                                }).ToList();
                    cell.DisplayMember = "RefNo";
                    cell.ValueMember = "RefDateAmt";
                    cell.DataSource = data;
                }
                else if (grdEntry.CurrentCell.Value.ToString().Contains("##"))
                {
                    string[] ary = grdEntry.CurrentCell.Value.ToString().Split(new string[] { "##" }, StringSplitOptions.None);
                    grdEntry.CurrentRow.Cells[e.ColumnIndex + 1].Value = ary[0];
                    grdEntry.CurrentRow.Cells[e.ColumnIndex + 2].Value = ary[1];
                }
                else
                {
                    if (e.ColumnIndex == 0)
                    {
                        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)grdEntry.CurrentRow.Cells[1];
                        cell.Items.Add("No Ref No");
                    }
                }

                #region Old
                //if (cmbCustomer.EditValue.ToString() != "-1" && cmbSupplier.EditValue.ToString() != "-1")
                //{
                //    int curRow = grdEntry.CurrentRow.Index;
                //    int selRow = grdEntry.CurrentCell.RowIndex;
                //    if (grdEntry.CurrentCell.ColumnIndex == 0 && e. is ComboBox)
                //    {
                //        ComboBox comboBox = e.Control as ComboBox;

                //        CurrentRow = grdEntry.CurrentRow.Index;
                //        comboBox.SelectedIndexChanged += RefTypeColumnComboSelectionChanged;
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Supplier and Customer can not be blank.");
                //}
                #endregion
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void ClearControls()
        {
            BindDropDownlists();
            txtChequeNo.Text = "";
            txtCopies.Text = "";
            txtCoverNo.Text = "";
            txtDraftAmt.Text = "";
            txtRemarks.Text = "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }

    public class GridCell
    {
        public string RefNo { get; set; }
        public string RefDateAmt { get; set; }
    }
}

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
            comboBox1.SelectedIndex = 0;

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
                if (cmbCustomer.EditValue != null && cmbCustomer.EditValue.ToString() != "-1" && chkNoLRAddressPrinting.Checked == false)
                {
                    grdEntry.Rows.Clear();
                    grdEntry.Columns.Clear();
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
                if (cmbSupplier.EditValue != null && cmbSupplier.EditValue.ToString() != "-1" && chkNoLRAddressPrinting.Checked == false)
                {
                    grdEntry.Rows.Clear();
                    grdEntry.Columns.Clear();
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
                                where lr.fkSupplierId == (int)cmbSupplier.EditValue && lr.fkCustomerId == (int)cmbCustomer.EditValue && lr.IsOrderAdjusted == false
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
                    if (e.ColumnIndex == 6 && grdEntry.CurrentCell != null)
                    {
                        double Total = 0.00;
                        foreach (DataGridViewRow row in grdEntry.Rows)
                        {
                            if (row.Cells[e.ColumnIndex].Value != null)
                                Total += Convert.ToDouble(row.Cells[e.ColumnIndex].Value.ToString());
                        }
                        txtDraftAmt.Text = Total.ToString();
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
            txtDraftAmt.Text = "0.00";
            txtRemarks.Text = "";

            grdEntry.Rows.Clear();
            grdEntry.Columns.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void SaveData()
        {
            CollectionEntry colEntry = new CollectionEntry();
            colEntry.CreatedBy = User.UserName;
            colEntry.CreatedDate = DateTime.Now;
            colEntry.DDOrChequeDate = dtpChequeDate.Value;
            colEntry.DDOrChequeNumber = txtChequeNo.Text;
            colEntry.DDPrintedOnCoverNumber = txtCoverNo.Text;
            colEntry.DraftAmount = Convert.ToDecimal(txtDraftAmt.Text);
            colEntry.DraftOrCashOrCheque = comboBox1.SelectedText;
            colEntry.DraftReceiptDate = dtpRecptDate.Value;
            colEntry.EntryDate = dtpEntryDate.Value;
            if (cmbBank.EditValue.ToString() != "-1")
                colEntry.fkBankId = Convert.ToInt32(cmbBank.EditValue.ToString());
            if (cmbCourier.EditValue.ToString() != "-1")
                colEntry.fkCourierId = Convert.ToInt32(cmbCourier.EditValue.ToString());
            colEntry.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
            colEntry.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
            colEntry.IsCommissionReceived = cmbCommRecd.SelectedText;
            colEntry.IsDeleted = false;
            colEntry.IsDirect = chkNoLRAddressPrinting.Checked;
            colEntry.IsLocked = cmbLocked.SelectedText;
            colEntry.Remark = txtRemarks.Text;
            colEntry.Source = cmbSource.SelectedText;
            colEntry.UpdatedBy = User.UserName;
            colEntry.UpdatedDate = DateTime.Now;

            Ledger ledger = new Ledger();

            foreach (DataGridViewRow row in grdEntry.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    CollectionEntryDetail colEntryDetail = new CollectionEntryDetail();
                    colEntryDetail.AdjustedAmount = Convert.ToDecimal(row.Cells[6].Value);

                    ledger.ParticularDate = dtpRecptDate.Value;
                    ledger.BillNo = row.Cells[1].FormattedValue.ToString();
                    ledger.CreateDate = DateTime.Now;
                    ledger.CreatedBy = User.UserName;
                    ledger.Credit = Convert.ToDouble(row.Cells[6].Value);
                    ledger.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
                    ledger.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
                    ledger.Particulars = "By Collection A/C";
                    ledger.UpdatedBy = User.UserName;
                    ledger.UpdatedDate = DateTime.Now;
                    ledger.Debit = 0;
                    db.Ledgers.Add(ledger);

                    if (row.Cells[4].Value != null)
                    {
                        colEntryDetail.Discount = Convert.ToDecimal(row.Cells[4].Value);

                        DiscountEntry disc = new DiscountEntry();
                        disc.AdjustedAmount = Convert.ToDecimal(row.Cells[4].Value);
                        disc.CreatedBy = User.UserName;
                        disc.CreatedDate = DateTime.Now;
                        disc.DiscountAmount = Convert.ToDecimal(row.Cells[4].Value);
                        disc.DiscountDate = dtpRecptDate.Value;
                        disc.DiscountDocNo = "";
                        disc.EntryDate = dtpEntryDate.Value;
                        disc.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
                        disc.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
                        disc.IsDeleted = false;
                        disc.IsLocked = false;
                        disc.Narration = "";
                        disc.RefAmount = Convert.ToDecimal(row.Cells[3].Value);
                        disc.RefDate = Convert.ToDateTime(row.Cells[2].Value);
                        disc.RefNumber = row.Cells[1].FormattedValue.ToString();
                        disc.RefType = row.Cells[0].Value.ToString();
                        disc.Remarks = "";
                        disc.Source = "Ledger Copy";
                        disc.UpdatedBy = User.UserName;
                        disc.UpdatedDate = DateTime.Now;

                        ledger = new Ledger();
                        ledger.ParticularDate = dtpRecptDate.Value;
                        ledger.BillNo = disc.RefNumber;
                        ledger.CreateDate = DateTime.Now;
                        ledger.CreatedBy = User.UserName;
                        ledger.Credit = Convert.ToDouble(row.Cells[4].Value);
                        ledger.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
                        ledger.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
                        ledger.Particulars = "By Discount A/C";
                        ledger.UpdatedBy = User.UserName;
                        ledger.UpdatedDate = DateTime.Now;
                        ledger.Debit = 0;

                        db.Ledgers.Add(ledger);
                        db.DiscountEntries.Add(disc);
                    }
                    else
                        colEntryDetail.Discount = 0;

                    if (row.Cells[5].Value != null)
                    {
                        colEntryDetail.GR = Convert.ToDecimal(row.Cells[5].Value);

                        GRNDebitNote gr = new GRNDebitNote();
                        gr.AdjustedAmount = Convert.ToDecimal(row.Cells[5].Value);
                        gr.Amount = Convert.ToDecimal(row.Cells[5].Value);
                        gr.CreatedBy = User.UserName;
                        gr.CreatedDate = DateTime.Now;
                        gr.EntryDate = dtpEntryDate.Value;
                        gr.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
                        gr.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
                        gr.GRNDebitNoteDate = dtpRecptDate.Value;
                        gr.GRNNumber = "111";
                        gr.IsDeleted = false;
                        gr.IsLocked = false;
                        gr.Narration = txtRemarks.Text;
                        gr.RefAmount = Convert.ToDecimal(row.Cells[3].Value);
                        gr.RefDate = Convert.ToDateTime(row.Cells[2].Value);
                        gr.RefNumber = row.Cells[1].FormattedValue.ToString();
                        gr.RefType = row.Cells[0].Value.ToString();
                        gr.Remarks = txtRemarks.Text;
                        gr.Source = "Debit Note";
                        gr.UpdatedBy = User.UserName;
                        gr.UpdatedDate = DateTime.Now;

                        ledger = new Ledger();
                        ledger.ParticularDate = dtpRecptDate.Value;
                        ledger.BillNo = gr.RefNumber;
                        ledger.CreateDate = DateTime.Now;
                        ledger.CreatedBy = User.UserName;
                        ledger.Credit = Convert.ToDouble(row.Cells[5].Value);
                        ledger.fkCustomerId = Convert.ToInt32(cmbCustomer.EditValue.ToString());
                        ledger.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue.ToString());
                        ledger.Particulars = "By Goods Return A/C";
                        ledger.UpdatedBy = User.UserName;
                        ledger.UpdatedDate = DateTime.Now;
                        ledger.Debit = 0;

                        db.Ledgers.Add(ledger);
                        db.GRNDebitNotes.Add(gr);
                    }
                    else
                        colEntryDetail.GR = 0;

                    colEntryDetail.RefAmount = Convert.ToDecimal(row.Cells[3].Value);
                    colEntryDetail.RefDate = Convert.ToDateTime(row.Cells[2].Value);
                    colEntryDetail.RefNumber = row.Cells[1].FormattedValue.ToString();
                    colEntryDetail.RefType = row.Cells[0].Value.ToString();
                    colEntry.CollectionEntryDetails.Add(colEntryDetail);
                }
            }

            db.CollectionEntries.Add(colEntry);
            db.SaveChanges();
            MessageBox.Show("Data inserted successfully");
            ClearControls();
        }

        private void grdEntry_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    if (e.FormattedValue.ToString().Length > 0)
                    {
                        double value;
                        if (!double.TryParse(e.FormattedValue.ToString(), out value) || value < 0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Enter proper value in Cell.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void chkNoLRAddressPrinting_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoLRAddressPrinting.Checked)
            {
                grdEntry.DataSource = null;
            }
        }
    }

    public class GridCell
    {
        public string RefNo { get; set; }
        public string RefDateAmt { get; set; }
    }
}

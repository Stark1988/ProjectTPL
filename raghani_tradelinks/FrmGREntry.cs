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
    public partial class FrmGREntry : Form
    {
        TPLDBEntities db;
        public FrmGREntry()
        {
            InitializeComponent();
            db = new TPLDBEntities();
        }

        private void FrmGREntry_Load(object sender, EventArgs e)
        {
            try
            {
                BindDropDownlists();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        void BindDropDownlists()
        {
            List<Supplier> supplierList = CommonMethods.GetSupplierData();
            supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";
            cmbSupplier.DataSource = supplierList;


            List<Customer> customerList = CommonMethods.GetCustomerata();
            customerList.Insert(0, new Customer { CustomerId = -1, CustomerName = "Select Customer" });
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DataSource = customerList;

            string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/collection_entry_source.json"));
            var _sourceList = JsonConvert.DeserializeObject<List<DealingType>>(result);
            cmbPriority.Properties.Items.AddRange(_sourceList);
            cmbPriority.SelectedIndex = 0;

            cmbLocked.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            dtpEntryDate.Value = DateTime.Now;
        }

        private void FrmGREntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void grdEntry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdEntry.CurrentCell.Value.ToString() == "Against Ref")
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)grdEntry.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                    var data = (from lr in db.SaleLREntries
                                where lr.fkSupplierId == (int)cmbSupplier.SelectedValue && lr.fkCustomerId == (int)cmbCustomer.SelectedValue && lr.IsOrderAdjusted == false
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
                    if (e.ColumnIndex == 4 && grdEntry.CurrentCell != null)
                    {
                        double Total = 0.00;
                        foreach (DataGridViewRow row in grdEntry.Rows)
                        {
                            if (row.Cells[e.ColumnIndex].Value != null)
                                Total += Convert.ToDouble(row.Cells[e.ColumnIndex].Value.ToString());
                        }
                        txtAmt.Text = Total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void grdEntry_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
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
                CommonMethods.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        void SaveData()
        {
            foreach (DataGridViewRow row in grdEntry.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[0] != null)
                {
                    Ledger ledger = new Ledger();
                    GRNDebitNote gr = new GRNDebitNote();
                    gr.AdjustedAmount = Convert.ToDecimal(row.Cells[4].Value);
                    gr.Amount = Convert.ToDecimal(row.Cells[4].Value);
                    gr.CreatedBy = User.UserName;
                    gr.CreatedDate = DateTime.Now;
                    gr.EntryDate = dtpEntryDate.Value;
                    gr.fkCustomerId = Convert.ToInt32(cmbCustomer.SelectedValue.ToString());
                    gr.fkSupplierId = Convert.ToInt32(cmbSupplier.SelectedValue.ToString());
                    gr.GRNDebitNoteDate = dtpDate.Value;
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
                    ledger.ParticularDate = dtpDate.Value;
                    ledger.BillNo = gr.RefNumber;
                    ledger.CreateDate = DateTime.Now;
                    ledger.CreatedBy = User.UserName;
                    ledger.Credit = Convert.ToDouble(row.Cells[4].Value);
                    ledger.fkCustomerId = Convert.ToInt32(cmbCustomer.SelectedValue.ToString());
                    ledger.fkSupplierId = Convert.ToInt32(cmbSupplier.SelectedValue.ToString());
                    ledger.Particulars = "By Goods Return A/C";
                    ledger.UpdatedBy = User.UserName;
                    ledger.UpdatedDate = DateTime.Now;
                    ledger.Debit = 0;

                    db.Ledgers.Add(ledger);
                    db.GRNDebitNotes.Add(gr);
                }
            }
            db.SaveChanges();
            MessageBox.Show("Data saved successfully.");
            ClearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        void ClearControls()
        {
            BindDropDownlists();
            grdEntry.Rows.Clear();
            grdEntry.Columns.Clear();
            txtAmt.Text = "0.00";
            txtGrnNo.Text = "";
            txtRemarks.Text = "";
        }


        void BindGridView()
        {
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

            DataGridViewColumn clnAdjAmt = new DataGridViewColumn();
            clnAdjAmt.HeaderText = "Adjusted Amount";
            clnAdjAmt.CellTemplate = new DataGridViewTextBoxCell();
            clnAdjAmt.ReadOnly = false;
            grdEntry.Columns.Add(clnAdjAmt);
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedValue != null && cmbSupplier.SelectedValue.ToString() != "-1")
                {
                    grdEntry.Rows.Clear();
                    grdEntry.Columns.Clear();
                    BindGridView();
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedValue != null && cmbCustomer.SelectedValue.ToString() != "-1")
                {
                    grdEntry.Rows.Clear();
                    grdEntry.Columns.Clear();
                    BindGridView();
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }
}

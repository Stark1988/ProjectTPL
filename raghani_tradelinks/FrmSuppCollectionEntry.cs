using DevExpress.XtraEditors.Controls;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmSuppCollectionEntry : Form
    {
        TPLDBEntities db = null;
        public FrmSuppCollectionEntry()
        {
            InitializeComponent();
            db = new TPLDBEntities();
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

            DataGridViewColumn clnAdjAmt = new DataGridViewColumn();
            clnAdjAmt.HeaderText = "Adjusted Amount";
            clnAdjAmt.CellTemplate = new DataGridViewTextBoxCell();
            clnAdjAmt.ReadOnly = false;
            grdEntry.Columns.Add(clnAdjAmt);

            DataGridViewColumn clnNarra = new DataGridViewColumn();
            clnNarra.HeaderText = "Narration";
            clnNarra.CellTemplate = new DataGridViewTextBoxCell();
            clnNarra.ReadOnly = false;
            grdEntry.Columns.Add(clnNarra);
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

            dtpRecptDate.Value = DateTime.Now;
            dtpEntryDate.Value = DateTime.Now;
            dtpChequeDate.Value = DateTime.Now;
        }

        private void FrmSuppCollectionEntry_Load(object sender, EventArgs e)
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

        int CurrentRow = -1;

        private void cmbSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.EditValue != null && cmbSupplier.EditValue.ToString() != "-1")
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

        private void grdEntry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdEntry.CurrentCell.Value.ToString() == "Against Ref")
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)grdEntry.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                    var data = (from lr in db.FinalBills
                                where lr.fkSupplierId == (int)cmbSupplier.EditValue
                                select new
                                {
                                    RefNo = lr.BillMemoNo,
                                    RefDate = lr.BillDate,
                                    RefAmt = lr.TotalAmt,
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
            SuppCollectionEntry supCol = new SuppCollectionEntry();
            supCol.CollectionAmt = Convert.ToDouble(txtDraftAmt.Text);
            supCol.CollectionDate = dtpRecptDate.Value;
            supCol.DDCheque = comboBox1.SelectedItem.ToString();
            supCol.DDChequeDate = dtpChequeDate.Value;
            supCol.DDChequeNo = txtChequeNo.Text;
            supCol.DrawnOn = txtDrawnOn.Text;
            supCol.EntryDate = dtpEntryDate.Value;
            supCol.fkSupplierId = Convert.ToInt32(cmbSupplier.EditValue);
            supCol.Remarks = txtRemarks.Text;

            foreach (DataGridViewRow row in grdEntry.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    SuppCollectionEntryDetail supColDetail = new SuppCollectionEntryDetail();
                    supColDetail.AdjustedAmt = Convert.ToDouble(row.Cells[4].Value);
                    supColDetail.Narration = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";
                    supColDetail.RefAmt = Convert.ToDouble(row.Cells[3].Value);
                    supColDetail.RefDate = Convert.ToDateTime(row.Cells[2].Value);
                    supColDetail.RefNo = row.Cells[2].Value.ToString();
                    supColDetail.RefType = row.Cells[0].Value.ToString();

                    supCol.SuppCollectionEntryDetails.Add(supColDetail);
                }
            }

            db.SuppCollectionEntries.Add(supCol);
            db.SaveChanges();
            MessageBox.Show("Data inserted successfully");
            ClearControls();
        }

        void ClearControls()
        {
            BindDropDownlists();
            txtChequeNo.Text = "";
            txtDraftAmt.Text = "0.00";
            txtRemarks.Text = "";

            grdEntry.Rows.Clear();
            grdEntry.Columns.Clear();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}

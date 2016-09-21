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
    public partial class FrmSuppDiscount : Form
    {
        TPLDBEntities db;

        public FrmSuppDiscount()
        {
            InitializeComponent();

            db = new TPLDBEntities();
        }

        private void FrmSuppDiscount_Load(object sender, EventArgs e)
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

            dtpDate.Value = DateTime.Now;
            dtpEntryDate.Value = DateTime.Now;
        }

        private void grdEntry_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdEntry.CurrentCell.Value.ToString() == "Against Ref")
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)grdEntry.Rows[e.RowIndex].Cells[e.ColumnIndex + 1];
                    var data = (from lr in db.FinalBills
                                where lr.fkSupplierId == (int)cmbSupplier.SelectedValue
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
                    if (e.ColumnIndex == 4 && grdEntry.CurrentCell != null)
                    {
                        double Total = 0.00;
                        foreach (DataGridViewRow row in grdEntry.Rows)
                        {
                            if (row.Cells[e.ColumnIndex].Value != null)
                                Total += Convert.ToDouble(row.Cells[e.ColumnIndex].Value.ToString());
                        }
                        txtDiscAmt.Text = Total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
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

            DataGridViewColumn clnNar = new DataGridViewColumn();
            clnNar.HeaderText = "Narration";
            clnNar.CellTemplate = new DataGridViewTextBoxCell();
            clnNar.ReadOnly = false;
            grdEntry.Columns.Add(clnNar);
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
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
            SuppDiscount disc = new SuppDiscount();
            disc.DiscAmt = Convert.ToDouble(txtDiscAmt.Text);
            disc.DiscDate = dtpDate.Value;
            disc.EntryDate = dtpEntryDate.Value;
            disc.fkSupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
            disc.Remarks = txtRemarks.Text;

            foreach (DataGridViewRow row in grdEntry.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[0] != null)
                {
                    SuppDiscounDetail discDetail = new SuppDiscounDetail();
                    discDetail.AdjustedAmt = Convert.ToDouble(row.Cells[4].Value);
                    discDetail.Narration = row.Cells[5].Value != null ? row.Cells[5].Value.ToString() : "";
                    discDetail.RefAmt = Convert.ToDouble(row.Cells[3].Value);
                    discDetail.RefDate = Convert.ToDateTime(row.Cells[2].Value);
                    discDetail.RefNo = row.Cells[1].Value.ToString();
                    discDetail.RefType = row.Cells[0].Value.ToString();

                    disc.SuppDiscounDetails.Add(discDetail);
                }
            }

            db.SuppDiscounts.Add(disc);
            db.SaveChanges();
            MessageBox.Show("Data saved successfully.");
            ClearControls();
        }

        void ClearControls()
        {
            BindDropDownlists();
            grdEntry.Rows.Clear();
            grdEntry.Columns.Clear();
            txtDiscAmt.Text = "0.00";
            txtRemarks.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

    }
}

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
                    if (e.ColumnIndex == 6 && grdEntry.CurrentCell != null)
                    {
                        double Total = 0.00;
                        foreach (DataGridViewRow row in grdEntry.Rows)
                        {
                            if (row.Cells[e.ColumnIndex].Value != null)
                                Total += Convert.ToDouble(row.Cells[e.ColumnIndex].Value.ToString());
                        }
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
                CommonMethods.HandleException(ex);
            }
        }
    }
}

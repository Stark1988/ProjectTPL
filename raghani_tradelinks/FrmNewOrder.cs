using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Newtonsoft.Json;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmNewOrder : Form
    {
        TPLDBEntities db = null;
        List<MstUser> userList = null;
        string selectedAccompany = string.Empty;

        public FrmNewOrder()
        {
            InitializeComponent();
            db = new TPLDBEntities();
        }

        private void FrmNewOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
        DataTable GetOrderDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("RedQty", typeof(int));
            dt.Columns.Add("OrQty", typeof(int));
            dt.Columns.Add("TotalQty", typeof(int));
            dt.Columns.Add("Accompany", typeof(string));
            dt.Columns.Add("QNK", typeof(string));
            dt.Columns.Add("BalQty", typeof(int));
            return dt;
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<Supplier> supplierList = (from s in db.Suppliers
                                               where s.IsDeleted == false
                                               select s).ToList();

                List<Customer> customerList = (from c in db.Customers
                                               where c.IsDeleted == false
                                               select c).ToList();

                userList = (from u in db.MstUsers
                                               where u.IsDeleted == false
                                               select u).ToList();

                customerList.Insert(0, new Customer { CustomerId = -1, CustomerName = "Select Customer" });

                cmbCustomer.Properties.DataSource = customerList;
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerId") { Visible = false });
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerName"));
                cmbCustomer.Properties.DisplayMember = "CustomerName";
                cmbCustomer.Properties.ValueMember = "CustomerId";
                cmbCustomer.EditValue = -1;
                cmbCustomer.Properties.ShowHeader = false;

                gridControl1.DataSource = GetOrderDataSource();
                RepositoryItemLookUpEdit cmbSupplier = new RepositoryItemLookUpEdit();
                cmbSupplier.DataSource = supplierList;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierId";
                cmbSupplier.Columns.Add(new LookUpColumnInfo("SupplierId") { Visible = false });
                cmbSupplier.Columns.Add(new LookUpColumnInfo("SupplierName"));
                cmbSupplier.ShowHeader = false;
                cmbSupplier.ForceInitialize();
                cmbSupplier.NullText = "Select Supplier";

                gridControl1.RepositoryItems.Add(cmbSupplier);
                gridView1.Columns["Supplier"].ColumnEdit = cmbSupplier;
                               
                RepositoryItemLookUpEdit cmbAccompany = new RepositoryItemLookUpEdit();
                cmbAccompany.DataSource = userList;
                cmbAccompany.Columns.Clear();
                cmbAccompany.Columns.Add(new LookUpColumnInfo("FullName"));
                cmbAccompany.ShowHeader = false;
                cmbAccompany.NullText = "Select Accompany";
                cmbAccompany.ValueMember = "UserId";
                cmbAccompany.DisplayMember = "FullName";
                gridControl1.RepositoryItems.Add(cmbAccompany);
                gridView1.Columns["Accompany"].ColumnEdit = cmbAccompany;

                gridView1.CustomRowCellEdit += gridView1_CustomRowCellEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void cmbAccompany_GetNotInListValue(object sender, GetNotInListValueEventArgs e)
        {
            var cmbAccompany = sender as LookUpEdit;

            if (e.FieldName == "UserDisplayName")
            {
                var user = ((List<MstUser>)cmbAccompany.Properties.DataSource)[e.RecordIndex];
                if (user != null)
                    e.Value = selectedAccompany = string.Format("{0} {1}", user.FirstName, user.LastName);
            }
        }

        void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            try
            {
                int totalQty = 0;
                if (e.Column.FieldName == "TotalQty")
                {
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        if (gridView1.GetRowCellValue(i, gridView1.Columns["TotalQty"]) != DBNull.Value)
                        {
                            totalQty += Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["TotalQty"]));
                            txtTotalQty.Text = totalQty.ToString();
                        }
                    }
                }

                if (e.Column.FieldName == "Supplier")
                {
                    if (gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Supplier"]) != DBNull.Value
                        && gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Supplier"]) != null)
                    {
                        gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["Supplier"], gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["Supplier"]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime orderDate;
                CultureInfo ci = new CultureInfo("en-IE");

                if (!DateTime.TryParse(txtSpokenDt1.Text, ci, DateTimeStyles.None, out orderDate))
                {
                    MessageBox.Show("Please enter valid order date");
                    txtSpokenDt1.Focus();
                    return;
                }

                if ((int)cmbCustomer.EditValue == -1)
                {
                    MessageBox.Show("Please select a Customer");
                    cmbCustomer.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cmbOrderVisit.SelectedText))
                {
                    MessageBox.Show("Please select a Order/Visit");
                    cmbOrderVisit.Focus();
                    return;
                }

                if (gridView1.DataRowCount == 0)
                {
                    MessageBox.Show("Please add at least one Supplier");
                    return;
                }

                if (!dxValidationProvider1.Validate())
                    return;

                OrderEntry order = new OrderEntry
                {
                    OrderDate = orderDate,
                    fkCustomerId = (int)cmbCustomer.EditValue,
                    OrderOrVIsit = cmbOrderVisit.SelectedText,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    CreatedDate = DateTime.Now,
                    OrderValue = Convert.ToDecimal(txtOrderValue.Text)
                };

                List<OrderDetail> orderDetails = new List<OrderDetail>();

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.fkSupplierId = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["Supplier"]));
                    orderDetail.RedQty = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["RedQty"]));
                    orderDetail.OrQty = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["OrQty"]));
                    orderDetail.TotalQty = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["TotalQty"]));
                    orderDetail.Accompany = gridView1.GetRowCellDisplayText(i,gridView1.Columns[ "Accompany"]);
                    orderDetail.QNK = Convert.ToString(gridView1.GetRowCellValue(i, gridView1.Columns["QNK"]));
                    orderDetail.BalQty = Convert.ToInt32(gridView1.GetRowCellValue(i, gridView1.Columns["BalQty"]));
                    orderDetails.Add(orderDetail);
                }

                order.OrderDetails = orderDetails;

                db.OrderEntries.Add(order);
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Order added successfully");
                else
                    MessageBox.Show("Error occurred while adding order");
                
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearData()
        {
            txtSpokenDt1.Clear();
            cmbCustomer.EditValue = -1;
            cmbOrderVisit.SelectedText = string.Empty;
            txtOrderValue.Text = string.Empty;
            txtTotalQty.Text = string.Empty;
            gridControl1.DataSource = null;
            gridControl1.DataSource = GetOrderDataSource();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

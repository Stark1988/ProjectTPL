using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
    public partial class FrmNullifyOrder : Form
    {
        TPLDBEntities db = null;

        public FrmNullifyOrder()
        {
            InitializeComponent();
            db = new TPLDBEntities();
        }

        private void FrmNullifyOrder_Load(object sender, EventArgs e)
        {
            try
            {
                //gridControl1.DataSource = GetOrderDataSource();
                List<OrderForSupplier> ordersWithBalQty = db.OrderDetails
                                            .GroupBy(od => od.fkSupplierId)
                                            .Select(orderForSupplier => new OrderForSupplier
                                            {
                                                SupplierId = orderForSupplier.FirstOrDefault().fkSupplierId,
                                                SupplierName = orderForSupplier.FirstOrDefault().Supplier.SupplierName,
                                                BalanceQty = orderForSupplier.Sum(o => o.BalQty)
                                            }).ToList();

                grdCmbPendingOrders.Properties.DataSource = ordersWithBalQty;
                grdCmbPendingOrders.Properties.DisplayMember = "SupplierName";
                grdCmbPendingOrders.Properties.ValueMember = "SupplierId";
                grdCmbPendingOrders.Properties.View.OptionsBehavior.AutoPopulateColumns = false;

                GridColumn col1 = grdCmbPendingOrders.Properties.View.Columns.AddField("SupplierName");
                col1.VisibleIndex = 0;
                col1.Caption = "Supplier Name";
                // A column to display the values of the ProductName field.
                GridColumn col2 = grdCmbPendingOrders.Properties.View.Columns.AddField("BalanceQty");
                col2.VisibleIndex = 1;
                col2.Caption = "Balance Qty";
                
                grdCmbPendingOrders.Properties.NullText = "Select Supplier";
                // Set column widths according to their contents.
                grdCmbPendingOrders.Properties.View.BestFitColumns();
                // Specify the total dropdown width.
                grdCmbPendingOrders.Properties.PopupFormWidth = 300;

                grdCmbPendingOrders.EditValueChanged += grdCmbPendingOrders_EditValueChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void grdCmbPendingOrders_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataTable GetOrderDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Customer Name", typeof(string));
            dt.Columns.Add("Order Qty", typeof(int));
            dt.Columns.Add("Dspch Qty", typeof(int));
            dt.Columns.Add("Balance Qty", typeof(int));
            dt.Columns.Add("Order Date", typeof(string));
            dt.Columns.Add("Nullify Method / Qty", typeof(string));
            return dt;
        }

        private void FrmNullifyOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
    }

    public class OrderForSupplier
    {
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int? BalanceQty { get; set; }
    }
}

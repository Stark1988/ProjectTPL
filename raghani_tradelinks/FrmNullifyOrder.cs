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
                PopulateGridComboPendingOrders();

                grdCmbPendingOrders.EditValueChanged += grdCmbPendingOrders_EditValueChanged;

                gridOrderByCustomer.ShowingEditor += gridOrderByCustomer_ShowingEditor;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGridComboPendingOrders()
        {
            if (grdCmbPendingOrders.Properties.View.Columns != null)
                grdCmbPendingOrders.Properties.View.Columns.Clear();

            List<OrderForSupplier> ordersWithBalQty = db.OrderDetails
                                        .Where(od => od.OrderEntry.IsDeleted == false && od.IsNullify == false && od.IsFullyExecuted == false)
                                        .GroupBy(od => od.fkSupplierId)
                                        .Select(orderForSupplier => new OrderForSupplier
                                        {
                                            SupplierId = orderForSupplier.FirstOrDefault().fkSupplierId,
                                            SupplierName = orderForSupplier.FirstOrDefault().Supplier.SupplierName,
                                            BalanceQty = (orderForSupplier.Select(o=>o.OrQty).DefaultIfEmpty(0).Sum())
                                                            - orderForSupplier.Sum(od => od.OrderTransactions
                                                                            .Select(trans=> trans.DispatchQty)
                                                                            .DefaultIfEmpty(0)
                                                                            .Sum())
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
        }

        void grdCmbPendingOrders_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (grdCmbPendingOrders.EditValue != null)
                {
                    gridOrderByCustomer.Columns.Clear();
                    PopulateGridOrderByCustomer();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGridOrderByCustomer()
        {
            int selectedSupplierId = (int)grdCmbPendingOrders.EditValue;

            var cs = db.OrderDetails
                .Where(od => od.OrderEntry.IsDeleted == false && od.IsNullify == false && od.IsFullyExecuted == false && od.fkSupplierId == selectedSupplierId);

            List<OrderByCustomer> ordersByCustomer = db.OrderDetails
                .Where(od => od.OrderEntry.IsDeleted == false && od.IsNullify == false && od.IsFullyExecuted == false && od.fkSupplierId == selectedSupplierId)
                .Select(orderByCustomer => new OrderByCustomer
                {
                    OrderId = orderByCustomer.OrderEntry.OrderId,
                    OrderDetailId = orderByCustomer.OrderDetailId,
                    CustomerId = orderByCustomer.OrderEntry.fkCustomerId,
                    CustomerName = orderByCustomer.OrderEntry.Customer.CustomerName,
                    SupplierId = orderByCustomer.fkSupplierId,
                    OrderDate = orderByCustomer.OrderEntry.OrderDate,
                    OrderQty = orderByCustomer.OrQty,
                    DispatchQty = orderByCustomer.OrderTransactions
                                                    .Select(ot => ot.DispatchQty)
                                                    .DefaultIfEmpty(0)
                                                    .Sum(),
                    BalanceQty = orderByCustomer.OrQty
                                    - orderByCustomer.OrderTransactions
                                                        .Select(ot => ot.DispatchQty)
                                                        .DefaultIfEmpty(0)
                                                        .Sum(),
                    IsNullify = false,
                    IsFullyExecuted = false
                }).ToList();

            gridControl1.DataSource = ordersByCustomer;
            gridOrderByCustomer.Columns["OrderId"].Visible = false;
            gridOrderByCustomer.Columns["OrderDetailId"].Visible = false;
            gridOrderByCustomer.Columns["CustomerId"].Visible = false;
            gridOrderByCustomer.Columns["SupplierId"].Visible = false;
            gridOrderByCustomer.Columns["IsNullify"].Caption = "Nullify Method/Qty";
        }

        void gridOrderByCustomer_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridOrderByCustomer.FocusedColumn.FieldName == "OrderId"
                || gridOrderByCustomer.FocusedColumn.FieldName == "OrderDetailId"
                || gridOrderByCustomer.FocusedColumn.FieldName == "CustomerId"
                || gridOrderByCustomer.FocusedColumn.FieldName == "CustomerName"
                || gridOrderByCustomer.FocusedColumn.FieldName == "SupplierId"
                || gridOrderByCustomer.FocusedColumn.FieldName == "OrderDate"
                || gridOrderByCustomer.FocusedColumn.FieldName == "OrderQty"
                || gridOrderByCustomer.FocusedColumn.FieldName == "DispatchQty"
                || gridOrderByCustomer.FocusedColumn.FieldName == "BalanceQty")

                e.Cancel = true;
        }

        private void FrmNullifyOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridControl1.DataSource != null)
                {
                    List<OrderByCustomer> ordersByCustomer = (List<OrderByCustomer>)gridControl1.DataSource;

                    foreach (var orderByCust in ordersByCustomer)
                    {
                        db.OrderDetails.FirstOrDefault(od => od.OrderDetailId == orderByCust.OrderDetailId).IsNullify = orderByCust.IsNullify;
                    }

                    if (db.SaveChanges() > 0)
                        MessageBox.Show("Order Nullified successfully");
                    else
                        MessageBox.Show("Error occurred while Nullifying order");

                    gridOrderByCustomer.Columns.Clear();
                    PopulateGridOrderByCustomer();
                    PopulateGridComboPendingOrders();
                }
                else
                {
                    MessageBox.Show("Please select a Supplier");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class OrderForSupplier
    {
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int? BalanceQty { get; set; }
    }

    public class OrderByCustomer
    {
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int? SupplierId { get; set; }
        public int? OrderQty { get; set; }
        public int? DispatchQty { get; set; }        
        public int? BalanceQty { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsNullify { get; set; }
        public bool IsFullyExecuted { get; set; }
    }
}

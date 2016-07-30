using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
        public FrmNullifyOrder()
        {
            InitializeComponent();
        }

        private void FrmNullifyOrder_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = GetOrderDataSource();
            }
            catch (Exception ex)
            {
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
}

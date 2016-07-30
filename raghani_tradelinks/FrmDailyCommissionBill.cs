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
    public partial class FrmDailyCommissionBill : Form
    {
        public FrmDailyCommissionBill()
        {
            InitializeComponent();
        }

        private void FrmDailyCommissionBill_Load(object sender, EventArgs e)
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
            dt.Columns.Add("Select", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("SMS Cell", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Chq. No.", typeof(string));
            dt.Columns.Add("Chq. Dt.", typeof(string));
            dt.Columns.Add("Chq. Amt.", typeof(string));
            dt.Columns.Add("%", typeof(string));
            dt.Columns.Add("Com. Accrued", typeof(string));
            dt.Columns.Add("Bill Rais", typeof(string));
            return dt;
        }

        private void FrmDailyCommissionBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
    }
}

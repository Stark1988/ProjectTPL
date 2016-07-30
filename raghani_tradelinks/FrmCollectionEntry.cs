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
    public partial class FrmCollectionEntry : Form
    {
        public FrmCollectionEntry()
        {
            InitializeComponent();
        }

        private void FrmCollectionEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
        DataTable GetOrderDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ref Type", typeof(string));
            dt.Columns.Add("Ref No.", typeof(string));
            dt.Columns.Add("Ref Date", typeof(string));
            dt.Columns.Add("Ref Amt.", typeof(string));
            dt.Columns.Add("Discount", typeof(string));
            dt.Columns.Add("GR", typeof(string));
            dt.Columns.Add("Adjusted Amt.", typeof(string));
            return dt;
        }

        private void FrmCollectionEntry_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = GetOrderDataSource();
            }
            catch (Exception ex)
            {
            }
        }
    }
}

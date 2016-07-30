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
    public partial class FrmGREntry : Form
    {
        public FrmGREntry()
        {
            InitializeComponent();
        }

        private void FrmGREntry_Load(object sender, EventArgs e)
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
            dt.Columns.Add("Ref Type", typeof(string));
            dt.Columns.Add("Ref No.", typeof(string));
            dt.Columns.Add("Ref Date", typeof(string));
            dt.Columns.Add("Ref Amount", typeof(string));
            dt.Columns.Add("Adjusted", typeof(string));
            dt.Columns.Add("Narration", typeof(string));
            return dt;
        }

        private void FrmGREntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
    }
}

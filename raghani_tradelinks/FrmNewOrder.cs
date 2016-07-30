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
    public partial class FrmNewOrder : Form
    {
        public FrmNewOrder()
        {
            InitializeComponent();
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
                gridControl1.DataSource = GetOrderDataSource();
                RepositoryItemImageComboBox ritem = new RepositoryItemImageComboBox();
                gridControl1.RepositoryItems.Add(ritem);
                gridView1.Columns["Supplier"].ColumnEdit = ritem;
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Ajay Diwan",
                    Value = "10001"
                });
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Pyramid Sarees",
                    Value = "10002"
                }
                );
            }
            catch (Exception ex)
            {
            }
        }
    }
}

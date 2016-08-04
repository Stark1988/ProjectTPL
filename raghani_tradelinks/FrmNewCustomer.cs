using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmNewCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/branch_list.json"));
                List<Branch> _branchList = JsonConvert.DeserializeObject<List<Branch>>(result);
                cmbACCreatedByBranch.Properties.ValueMember = "Name";
                cmbACCreatedByBranch.Properties.DisplayMember = "Name";
                cmbACCreatedByBranch.Properties.DataSource = _branchList;

                //BindingList<string> list = new BindingList<string>();
                //list.AllowNew = true;
                //gridControl1.DataSource = list;
                //gridControl1.UseEmbeddedNavigator = true;
                //gridView1.PopulateColumns();
                //RepositoryItemImageComboBox ritem = new RepositoryItemImageComboBox();
                //gridControl1.RepositoryItems.Add(ritem);
                //gridView1.Columns["existingSisterConcernColumn"].ColumnEdit = ritem;
                //ritem.Items.Add(new ImageComboBoxItem
                //{
                //    Description = "Sun",
                //    Value = "Sun"
                //});
                //ritem.Items.Add(new ImageComboBoxItem
                //{
                //    Description = "Sat",
                //    Value = "Sat"
                //}
                //);
                gridControl1.DataSource = GetSisterConcernDataSource();
                RepositoryItemImageComboBox ritem = new RepositoryItemImageComboBox();
                gridControl1.RepositoryItems.Add(ritem);
                gridView1.Columns["ExistingSisterConcern"].ColumnEdit = ritem;
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Sun",
                    Value = "Sunday"
                });
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Sat",
                    Value = "Saturday"
                }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        DataTable GetSisterConcernDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ExistingSisterConcern", typeof(string));
            return dt;
        }
    }
}

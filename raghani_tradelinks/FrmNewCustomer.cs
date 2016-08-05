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
                BindDrpListData();

                #region Old
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
                #endregion

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
                HandleException(ex);
            }
        }

        void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        void BindDrpListData()
        {
            try
            {
                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/branch_list.json"));
                List<Branch> _branchList = JsonConvert.DeserializeObject<List<Branch>>(result);
                cmbACCreatedByBranch.Properties.ValueMember = "Name";
                cmbACCreatedByBranch.Properties.DisplayMember = "Name";
                cmbACCreatedByBranch.Properties.DataSource = _branchList;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_dealing_type.json"));
                var _dealingList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbDelingType.Properties.Items.AddRange(_dealingList);
                cmbDelingType.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_gr_habbit.json"));
                var _grHabbit = JsonConvert.DeserializeObject<List<GRHabbit>>(result);
                cmbGRHabbit.Properties.Items.AddRange(_grHabbit);
                cmbGRHabbit.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_visit_freq.json"));
                var _visitFreq = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbVisistFreq.Properties.Items.AddRange(_visitFreq);
                cmbVisistFreq.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_firm_type_list.json"));
                var _typeOfFirm = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbTypeOfFirm.Properties.Items.AddRange(_typeOfFirm);
                cmbTypeOfFirm.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_priority_list.json"));
                var _priority = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbPriority.Properties.Items.AddRange(_priority);
                cmbPriority.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_status.json"));
                var _status = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbStatus.Properties.Items.AddRange(_status);
                cmbStatus.SelectedIndex = 0;

                //result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_status.json"));
                //var _status = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                //cmbStatus.Properties.Items.AddRange(_status);
                //cmbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                HandleException(ex);
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

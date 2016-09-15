using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmFinalBillEntry : Form
    {
        public FrmFinalBillEntry()
        {
            InitializeComponent();
        }

        private void FrmFinalBillEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmFinalBillEntry_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/bill_type.json"));
                var _sourceList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbBillType.DataSource = _sourceList;
                cmbBillType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

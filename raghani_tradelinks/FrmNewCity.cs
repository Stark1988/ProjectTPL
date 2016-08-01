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
    public partial class FrmNewCity : Form
    {
        public FrmNewCity()
        {
            InitializeComponent();
        }

        private void FrmNewCity_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewCity_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}

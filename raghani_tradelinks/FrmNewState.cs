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
    public partial class FrmNewState : Form
    {
        public FrmNewState()
        {
            InitializeComponent();
        }

        private void FrmNewState_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStateName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter state name");
                    txtStateName.Focus();
                }
                else
                {
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
}

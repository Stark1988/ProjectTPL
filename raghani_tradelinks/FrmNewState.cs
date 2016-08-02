using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.BL;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                MstStateMgt state = new MstStateMgt();
                if (state.InsertState(txtStateName.Text) > 0)
                    MessageBox.Show("State added successfully.");
                else
                    MessageBox.Show("Error in adding State.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}

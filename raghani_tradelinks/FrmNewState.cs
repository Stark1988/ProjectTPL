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
        int ID = 0;

        private void FrmNewState_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
                
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider1.Validate())
                {
                    MstStateMgt state = new MstStateMgt();
                    if (state.InsertState(txtStateName.Text) > 0)
                        MessageBox.Show("State inserted successfully.");
                    else
                        MessageBox.Show("Error in adding State.");

                    DisplayData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider1.Validate())
                {
                    MstStateMgt state = new MstStateMgt();
                    if (state.UpdateState(ID, txtStateName.Text) > 0)
                        MessageBox.Show("State updated successfully.");
                    else
                        MessageBox.Show("Error in adding State.");

                    DisplayData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void DisplayData()
        {
            try
            {
                MstStateMgt state = new MstStateMgt();
                grdState.DataSource = state.SelectData();
                grdState.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void ClearData()
        {
            ID = 0;
            txtStateName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtStateName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    MstStateMgt state = new MstStateMgt();
                    if (state.DeleteState(ID) > 0)
                        MessageBox.Show("State deleted successfully.");
                    else
                        MessageBox.Show("Error in adding State.");

                    DisplayData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void FrmNewState_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void grdState_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(grdState.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtStateName.Text = grdState.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

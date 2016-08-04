using RT.BL;
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
    public partial class FrmNewBank : Form
    {
        public FrmNewBank()
        {
            InitializeComponent();
        }
        int ID = 0;

        private void FrmNewBank_FormClosing(object sender, FormClosingEventArgs e)
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
                    MstBankMgmt bank = new MstBankMgmt();
                    if (bank.InsertBank(txtBankName.Text) > 0)
                        MessageBox.Show("Bank inserted successfully.");
                    else
                        MessageBox.Show("Error in adding Bank.");

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
                    MstBankMgmt bank = new MstBankMgmt();
                    if (bank.UpdateBank(ID, txtBankName.Text) > 0)
                        MessageBox.Show("Bank updated successfully.");
                    else
                        MessageBox.Show("Error while updating Bank.");

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
                MstBankMgmt bank = new MstBankMgmt();
                grdBank.DataSource = bank.SelectData();
                grdBank.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClearData()
        {
            ID = 0;
            txtBankName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtBankName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    MstBankMgmt bank = new MstBankMgmt();
                    if (bank.DeleteBank(ID) > 0)
                        MessageBox.Show("Bank deleted successfully.");
                    else
                        MessageBox.Show("Error while deleting Bank.");

                    DisplayData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmNewBank_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void grdBank_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(grdBank.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtBankName.Text = grdBank.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

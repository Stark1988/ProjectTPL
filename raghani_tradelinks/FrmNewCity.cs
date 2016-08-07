using DevExpress.XtraEditors.Controls;
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
    public partial class FrmNewCity : Form
    {
        int ID = -1;
        List<StateData> states = null;

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

        private void ClearData()
        {
            ID = -1;
            txtCityName.Text = string.Empty;
            txtPinCode.Text = string.Empty;
            cmbState.EditValue = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (ID == -1)
                {
                    MessageBox.Show("Please select a City to edit");
                    return;
                }

                if ((int)cmbState.EditValue == -1)
                {
                    MessageBox.Show("Please select State");
                    cmbState.Focus();
                    return;
                }

                MstCityMgmt city = new MstCityMgmt();
                if (city.UpdateCity(ID, txtCityName.Text, (int)cmbState.EditValue, txtPinCode.Text) > 0)
                    MessageBox.Show("City updated successfully.");
                else
                    MessageBox.Show("Error while updating City.");

                DisplayData();
                ClearData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if ((int)cmbState.EditValue == -1)
                {
                    MessageBox.Show("Please select State");
                    cmbState.Focus();
                    return;
                }

                MstCityMgmt city = new MstCityMgmt();
                if (city.InsertCity(txtCityName.Text, (int)cmbState.EditValue, txtPinCode.Text) > 0)
                    MessageBox.Show("City inserted successfully.");
                else
                    MessageBox.Show("Error in adding City.");

                DisplayData();
                ClearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                MessageBox.Show("Please select a City to delete");
                return;
            }

            DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtCityName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                MstCityMgmt city = new MstCityMgmt();
                if (city.DeleteCity(ID) > 0)
                    MessageBox.Show("City deleted successfully.");
                else
                    MessageBox.Show("Error while deleting City.");
            }
        }

        private void DisplayData()
        {
            try
            {
                MstCityMgmt city = new MstCityMgmt();

                MstCityMgmtData citiesData = city.SelectData();
                grdCity.DataSource = citiesData.Cities;
                grdCity.Columns[0].Visible = false;
                grdCity.Columns[2].Visible = false;

                states = citiesData.States;

                states.Insert(0, new StateData { ID = -1, Name = "Select State" });
                cmbState.Properties.DataSource = states;
                cmbState.Properties.Columns.Add(new LookUpColumnInfo("ID") { Visible = false });
                cmbState.Properties.Columns.Add(new LookUpColumnInfo("Name"));
                cmbState.Properties.DisplayMember = "Name";
                cmbState.Properties.ValueMember = "ID";
                cmbState.EditValue = -1;
                cmbState.Properties.ShowHeader = false;
                
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmNewCity_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void grdCity_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = grdCity.Rows[e.RowIndex].Cells[0].Value != null ? Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[0].Value.ToString()) : -1;
                txtCityName.Text = grdCity.Rows[e.RowIndex].Cells[1].Value != null ? grdCity.Rows[e.RowIndex].Cells[1].Value.ToString() : string.Empty;
                txtPinCode.Text = grdCity.Rows[e.RowIndex].Cells[4].Value != null ? grdCity.Rows[e.RowIndex].Cells[4].Value.ToString() : string.Empty;
                cmbState.EditValue = grdCity.Rows[e.RowIndex].Cells[2].Value != null ? Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[2].Value.ToString()) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

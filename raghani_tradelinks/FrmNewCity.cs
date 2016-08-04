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
        int ID = 0;
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
            ID = 0;
            txtCityName.Text = string.Empty;
            txtPinCode.Text = string.Empty;
            cmbState.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() && dxValidationProvider2.Validate())
            {
                if (cmbState.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select State");
                    return;
                }

                MstCityMgmt city = new MstCityMgmt();
                if (city.UpdateCity(ID, txtCityName.Text, ((StateData)cmbState.SelectedItem).ID, txtPinCode.Text) > 0)
                    MessageBox.Show("City updated successfully.");
                else
                    MessageBox.Show("Error while updating City.");

                DisplayData();
                ClearData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate() && dxValidationProvider2.Validate())
            {
                if (cmbState.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select State");
                    return;
                }

                MstCityMgmt city = new MstCityMgmt();
                if (city.InsertCity(txtCityName.Text, ((StateData)cmbState.SelectedItem).ID, txtPinCode.Text) > 0)
                    MessageBox.Show("City inserted successfully.");
                else
                    MessageBox.Show("Error in adding City.");

                DisplayData();
                ClearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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

                states = citiesData.States;

                cmbState.Properties.Items.Clear();
                cmbState.Properties.NullText = "Select State";
                cmbState.SelectedIndex = -1;

                foreach (StateData sd in states)
                {
                    cmbState.Properties.Items.Add(sd);
                }
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
                ID = Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCityName.Text = grdCity.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPinCode.Text = grdCity.Rows[e.RowIndex].Cells[4].Value.ToString();

                cmbState.SelectedIndex = cmbState.Properties.Items.IndexOf(states.FirstOrDefault(s => s.ID == Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[2].Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}

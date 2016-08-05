using DevExpress.XtraEditors.Controls;
using RT.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmNewSubAgent : Form
    {
        int ID = -1;
        List<CityData> cities = null;
        List<StateData> states = null;

        public FrmNewSubAgent()
        {
            InitializeComponent();
        }

        private void FrmNewSubAgent_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void FrmNewSubAgent_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(dxValidationProvider1.Validate())
                {
                    if ((int)cmbCity.EditValue == -1)
                    {
                        MessageBox.Show("Please select City");
                        return;
                    }

                    SubAgentData subAgentToAdd = new SubAgentData
                    {
                        SubAgentName = txtSubAgentName.Text,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        ResPhone = txtResPhone.Text,
                        MobileNumber = txtMobile.Text,
                        Remarks = txtRemarks.Text
                    };

                    MstSubAgentMgmt subAgentMgmt = new MstSubAgentMgmt();
                    if (subAgentMgmt.InsertSubAgent(subAgentToAdd) > 0)
                        MessageBox.Show("Sub Agent added successfully.");
                    else
                        MessageBox.Show("Error while adding Sub Agent.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider1.Validate())
                {
                    if (ID == -1)
                    {
                        MessageBox.Show("Please select a Sub Agent to update");
                        return;
                    }

                    if ((int)cmbCity.EditValue == -1)
                    {
                        MessageBox.Show("Please select City");
                        return;
                    }

                    SubAgentData subAgentToUpdate = new SubAgentData
                    {
                        SubAgentName = txtSubAgentName.Text,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        ResPhone = txtResPhone.Text,
                        MobileNumber = txtMobile.Text,
                        Remarks = txtRemarks.Text
                    };

                    MstSubAgentMgmt subAgentMgmt = new MstSubAgentMgmt();
                    if (subAgentMgmt.UpdateSubAgent(ID, subAgentToUpdate) > 0)
                        MessageBox.Show("Sub Agent updated successfully.");
                    else
                        MessageBox.Show("Error while updating Sub Agent.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == -1)
                {
                    MessageBox.Show("Please select a Sub Agent to delete");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtSubAgentName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    MstSubAgentMgmt subAgent = new MstSubAgentMgmt();
                    if (subAgent.DeleteSubAgent(ID) > 0)
                        MessageBox.Show("Sub Agent deleted successfully.");
                    else
                        MessageBox.Show("Error while deleting Sub Agent.");

                    DisplayData();
                    ClearData();
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

        private void DisplayData()
        {
            try
            {
                MstSubAgentMgmt subAgentMgmtMgmt = new MstSubAgentMgmt();
                MstSubAgentMgmtData displayData = subAgentMgmtMgmt.SelectData();

                cities = displayData.Cities;
                cities.Insert(0, new CityData { ID = -1, Name = "Select City" });
                cmbCity.Properties.DataSource = cities;
                cmbCity.Properties.Columns.Add(new LookUpColumnInfo("ID") { Visible = false });
                cmbCity.Properties.Columns.Add(new LookUpColumnInfo("Name"));
                cmbCity.Properties.DisplayMember = "Name";
                cmbCity.Properties.ValueMember = "ID";
                cmbCity.EditValue = -1;
                cmbCity.Properties.ShowHeader = false;

                MstStateMgt stateMgmt = new MstStateMgt();
                states = stateMgmt.SelectData();
                states.Insert(0, new StateData { ID = -1, Name = string.Empty });
                cmbState.Properties.DataSource = states;
                cmbState.Properties.Columns.Add(new LookUpColumnInfo("ID") { Visible = false });
                cmbState.Properties.Columns.Add(new LookUpColumnInfo("Name"));
                cmbState.Properties.DisplayMember = "Name";
                cmbState.Properties.ValueMember = "ID";
                cmbState.EditValue = -1;
                cmbState.Properties.ShowHeader = false;

                grdSubAgent.DataSource = displayData.SubAgents;
                grdSubAgent.Columns[0].Visible = false;
                grdSubAgent.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearData()
        {
            try
            {
                ID = -1;
                txtSubAgentName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                cmbCity.EditValue = -1;
                cmbState.EditValue = -1;
                txtPin.Text = string.Empty;
                txtOfficePhone.Text = string.Empty;
                txtResPhone.Text = string.Empty;
                txtMobile.Text = string.Empty;
                txtFax.Text = string.Empty;
                txtRemarks.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCity_EditValueChanged(object sender, EventArgs e)
        {
            if ((int)cmbCity.EditValue != -1)
            {
                cmbState.EditValue = cities.FirstOrDefault(c => c.ID == (int)cmbCity.EditValue).StateId;
            }
            else
            {
                cmbState.EditValue = -1;
            }
        }
    }
}

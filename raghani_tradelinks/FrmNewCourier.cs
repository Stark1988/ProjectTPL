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
    public partial class FrmNewCourier : Form
    {
        int ID = -1;
        List<BranchData> branches = null;
        List<CityData> cities = null;
        List<StateData> states = null;

        public FrmNewCourier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(dxValidationProvider1.Validate())
                {
                    if((int)cmbBranch.EditValue == -1)
                    {
                        MessageBox.Show("Please select Branch");
                        cmbBranch.Focus();
                        return;
                    }

                    if ((int)cmbCity.EditValue == -1)
                    {
                        MessageBox.Show("Please select City");
                        cmbCity.Focus();
                        return;
                    }

                    decimal rate;
                    if(!Decimal.TryParse(txtRate.Text, out rate))
                    {
                        MessageBox.Show("Please enter valid value for rate");
                        txtRate.Focus();
                        return;
                    }

                    CourierData courierToAdd = new CourierData
                    {
                        Name = txtCourierName.Text,
                        ShortName = txtShortName.Text,
                        Rate = rate,
                        BranchId = (int)cmbBranch.EditValue,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        Remarks = txtRemarks.Text,
                        Pin = txtPin.Text,
                        ContactPerson = txtContactPerson.Text
                    };

                    MstCourierMgmt courierMgmt = new MstCourierMgmt();
                    if (courierMgmt.InsertCourier(courierToAdd) > 0)
                        MessageBox.Show("Courier added successfully.");
                    else
                        MessageBox.Show("Error while adding Courier.");

                    DisplayData();
                    ClearData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearData()
        {
            ID = -1;
            txtCourierName.Text = string.Empty;
            txtShortName.Text = string.Empty;
            txtRate.Text = string.Empty;
            cmbBranch.EditValue = -1;
            txtAddress.Text = string.Empty;
            cmbCity.EditValue = -1;
            cmbState.EditValue = -1;
            txtOfficePhone.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtPin.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dxValidationProvider1.Validate())
                {
                    if (ID == -1)
                    {
                        MessageBox.Show("Please select a Courier to update");
                        return;
                    }

                    if ((int)cmbBranch.EditValue == -1)
                    {
                        MessageBox.Show("Please select Branch");
                        cmbBranch.Focus();
                        return;
                    }

                    if ((int)cmbCity.EditValue == -1)
                    {
                        MessageBox.Show("Please select City");
                        cmbCity.Focus();
                        return;
                    }

                    decimal rate;
                    if (!Decimal.TryParse(txtRate.Text, out rate))
                    {
                        MessageBox.Show("Please enter valid value for rate");
                        txtRate.Focus();
                        return;
                    }

                    CourierData courierToUpdate = new CourierData
                    {
                        Name = txtCourierName.Text,
                        ShortName = txtShortName.Text,
                        Rate = rate,
                        BranchId = (int)cmbBranch.EditValue,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        Remarks = txtRemarks.Text,
                        Pin = txtPin.Text,
                        ContactPerson = txtContactPerson.Text
                    };

                    MstCourierMgmt courierMgmt = new MstCourierMgmt();
                    if(courierMgmt.UpdateCourier(ID, courierToUpdate) > 0)
                        MessageBox.Show("Courier updated successfully.");
                    else
                        MessageBox.Show("Error while updating Courier.");

                    DisplayData();
                    ClearData();
                }
            }
            catch(Exception ex)
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
                    MessageBox.Show("Please select a courier to delete");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtCourierName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    MstCourierMgmt courier = new MstCourierMgmt();
                    if (courier.DeleteCourier(ID) > 0)
                        MessageBox.Show("Courier deleted successfully.");
                    else
                        MessageBox.Show("Error while deleting Courier.");

                    DisplayData();
                    ClearData();
                }
            }
            catch(Exception ex)
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
                MstCourierMgmt courierMgmt = new MstCourierMgmt();
                MstCourierMgmtData displayData = courierMgmt.SelectData();

                branches = displayData.Branches;
                branches.Insert(0, new BranchData { BranchId = -1, BranchName = "Select Branch" });
                cmbBranch.Properties.DataSource = branches;
                cmbBranch.Properties.Columns.Add(new LookUpColumnInfo("BranchId") { Visible = false });
                cmbBranch.Properties.Columns.Add(new LookUpColumnInfo("BranchName"));
                cmbBranch.Properties.DisplayMember = "BranchName";
                cmbBranch.Properties.ValueMember = "BranchId";
                cmbBranch.EditValue = -1;
                cmbBranch.Properties.ShowHeader = false;

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

                grdCity.DataSource = displayData.Couriers;
                grdCity.Columns[0].Visible = false;
                grdCity.Columns[4].Visible = false;
                grdCity.Columns[7].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNewCourier_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void grdCity_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = grdCity.Rows[e.RowIndex].Cells[0].Value != null ? Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[0].Value.ToString()) : -1;
                txtCourierName.Text = grdCity.Rows[e.RowIndex].Cells[1].Value != null ? grdCity.Rows[e.RowIndex].Cells[1].Value.ToString() : string.Empty;
                txtShortName.Text = grdCity.Rows[e.RowIndex].Cells[2].Value != null ? grdCity.Rows[e.RowIndex].Cells[2].Value.ToString() : string.Empty;
                txtRate.Text = grdCity.Rows[e.RowIndex].Cells[3].Value != null ? grdCity.Rows[e.RowIndex].Cells[3].Value.ToString() : string.Empty;
                cmbBranch.EditValue = grdCity.Rows[e.RowIndex].Cells[4].Value != null ? Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[4].Value.ToString()) : -1;
                txtAddress.Text = grdCity.Rows[e.RowIndex].Cells[6].Value != null ? grdCity.Rows[e.RowIndex].Cells[6].Value.ToString() : string.Empty;
                cmbCity.EditValue = grdCity.Rows[e.RowIndex].Cells[7].Value != null ? Convert.ToInt32(grdCity.Rows[e.RowIndex].Cells[7].Value.ToString()) : -1;
                cmbState.EditValue = cities.FirstOrDefault(c => c.ID == (int)cmbCity.EditValue) != null ? cities.FirstOrDefault(c => c.ID == (int)cmbCity.EditValue).StateId : -1;
                txtOfficePhone.Text = grdCity.Rows[e.RowIndex].Cells[9].Value != null ? grdCity.Rows[e.RowIndex].Cells[9].Value.ToString() : string.Empty;
                txtFax.Text = grdCity.Rows[e.RowIndex].Cells[10].Value != null ? grdCity.Rows[e.RowIndex].Cells[10].Value.ToString() : string.Empty;
                txtRemarks.Text = grdCity.Rows[e.RowIndex].Cells[11].Value != null ? grdCity.Rows[e.RowIndex].Cells[11].Value.ToString() : string.Empty;
                txtPin.Text = grdCity.Rows[e.RowIndex].Cells[12].Value != null ? grdCity.Rows[e.RowIndex].Cells[12].Value.ToString() : string.Empty;
                txtContactPerson.Text = grdCity.Rows[e.RowIndex].Cells[13].Value != null ? grdCity.Rows[e.RowIndex].Cells[13].Value.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void FrmNewCourier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
    }
}

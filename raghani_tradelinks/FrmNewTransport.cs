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
    public partial class FrmNewTransport : Form
    {
        int ID = -1;

        public FrmNewTransport()
        {
            InitializeComponent();
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

                    TransportData transportToAdd = new TransportData
                    {
                        TransportName = txtTransportName.Text,
                        ContactPerson = txtContactPerson.Text,
                        MobileNumber = txtMobile.Text,
                        ResPhone = txtResPhone.Text,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        Remarks = txtRemarks.Text,
                    };

                    MstTransportMgmt transportMgmt = new MstTransportMgmt();
                    if (transportMgmt.InsertTransport(transportToAdd) > 0)
                        MessageBox.Show("Transport added successfully.");
                    else
                        MessageBox.Show("Error while adding Transport.");

                    DisplayData();
                    ClearData();
                }
                
            }
            catch (Exception ex)
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
                    if ((int)cmbCity.EditValue == -1)
                    {
                        MessageBox.Show("Please select City");
                        return;
                    }

                    TransportData transportToUpdate = new TransportData
                    {
                        TransportName = txtTransportName.Text,
                        ContactPerson = txtContactPerson.Text,
                        MobileNumber = txtMobile.Text,
                        ResPhone = txtResPhone.Text,
                        Address = txtAddress.Text,
                        CityId = (int)cmbCity.EditValue,
                        OfficePhone = txtOfficePhone.Text,
                        Fax = txtFax.Text,
                        Remarks = txtRemarks.Text,
                    };

                    MstTransportMgmt transportMgmt = new MstTransportMgmt();
                    if (transportMgmt.UpdateTransport(ID, transportToUpdate) > 0)
                        MessageBox.Show("Transport updated successfully.");
                    else
                        MessageBox.Show("Error while updated Transport.");

                    DisplayData();
                    ClearData();
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
                    MessageBox.Show("Please select a Transport to delete");
                    return;
                }

                DialogResult confirm = MessageBox.Show("Confirm Delete: " + txtTransportName.Text + "?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    MstTransportMgmt transport = new MstTransportMgmt();
                    if (transport.DeleteTransport(ID) > 0)
                        MessageBox.Show("Transport deleted successfully.");
                    else
                        MessageBox.Show("Error while deleting Transport.");

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

        private void grdTransport_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(grdTransport.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTransportName.Text = grdTransport.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContactPerson.Text = grdTransport.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = grdTransport.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbCity.EditValue = Convert.ToInt32(grdTransport.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtOfficePhone.Text = grdTransport.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtFax.Text = grdTransport.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtResPhone.Text = grdTransport.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtMobile.Text = grdTransport.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtRemarks.Text = grdTransport.Rows[e.RowIndex].Cells[10].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmNewTransport_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                MstTransportMgmt transport = new MstTransportMgmt();
                MstTransportMgmtData transportMgmtData = transport.SelectData();

                transportMgmtData.Cities.Insert(0, new CityData { ID = -1, Name = "Select City" });
                cmbCity.Properties.DataSource = transportMgmtData.Cities;
                cmbCity.Properties.Columns.Add(new LookUpColumnInfo("ID") { Visible = false });
                cmbCity.Properties.Columns.Add(new LookUpColumnInfo("Name"));
                cmbCity.Properties.DisplayMember = "Name";
                cmbCity.Properties.ValueMember = "ID";
                cmbCity.EditValue = -1;
                cmbCity.Properties.ShowHeader = false;
                
                grdTransport.DataSource = transportMgmtData.Transports;
                grdTransport.Columns[0].Visible = false;
                grdTransport.Columns[4].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearData()
        {
            ID = -1;
            txtTransportName.Text = string.Empty;
            cmbCity.EditValue = -1;
            txtAddress.Text = string.Empty;
            txtPin.Text = string.Empty;
            txtOfficePhone.Text = string.Empty;
            txtResPhone.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private void FrmNewTransport_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }
    }
}

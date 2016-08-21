using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.DL;
using RT.BL;

namespace raghani_tradelinks
{
    public partial class FrmNewSupplier : Form
    {
        public FrmNewSupplier()
        {
            InitializeComponent();
        }

        private void FrmNewSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmNewSupplier_Load(object sender, EventArgs e)
        {
            BindDrpListData();

            SetupSisterConcernGrid();
        }        

        void BindDrpListData()
        {
            try
            {
                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/suppl_comp_list.json"));
                var _dealingList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbSuppCompany.Properties.Items.AddRange(_dealingList);
                cmbSuppCompany.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_zone_list.json"));
                var _zoneList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbZone.Properties.Items.AddRange(_zoneList);
                cmbZone.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/suppl_srv_tax_on_list.json"));
                var _serviceTaxList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbSTaxOn.Properties.Items.AddRange(_serviceTaxList);
                cmbSTaxOn.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/suppl_piority_member.json"));
                var _priorityMList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbPriorityMember.Properties.Items.AddRange(_priorityMList);
                cmbPriorityMember.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_priority_list.json"));
                var _priorityList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbPriority.Properties.Items.AddRange(_priorityList);
                cmbPriority.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/suppl_variety_list.json"));
                var _varietyList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbVariety.Properties.Items.AddRange(_varietyList);
                cmbVariety.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_group_list.json"));
                var _grpList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbGroup.Properties.Items.AddRange(_grpList);
                cmbGroup.SelectedIndex = 0;

                MstSupplierMgmt supplier = new MstSupplierMgmt();
                cmbSupplierEditList.DisplayMember = "SupplierName";
                cmbSupplierEditList.ValueMember = "SupplierId";
                List<Supplier> lstSuppl = supplier.SelectSupplier();
                lstSuppl.Insert(0, new Supplier() { SupplierName = "Select", SupplierId = 0 });
                cmbSupplierEditList.DataSource = lstSuppl;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validator1.Validate() == true)
                {
                    MstSupplierMgmt suppl = new MstSupplierMgmt();

                    List<SupplierBillingDetail> lstBill = new List<SupplierBillingDetail>();
                    SupplierBillingDetail bill = new SupplierBillingDetail();
                    bill.BillFrequency = Convert.ToInt32(textBox5.Text);
                    bill.IsStopMonthlyBilling = chkStopMonthlyBill.Checked;
                    bill.ITPanNumber = txtPanNo.Text;
                    bill.SupplierCompany = cmbSuppCompany.EditValue.ToString();
                    lstBill.Add(bill);

                    List<SupplierContactInfo> lstCInfo = new List<SupplierContactInfo>();
                    SupplierContactInfo contact = new SupplierContactInfo();
                    contact.Address = txtAddress1.Text;
                    contact.City = txtCity.Text;
                    contact.State = txtState.Text;
                    contact.Email = txtEmail.Text;
                    contact.Fax = txtFaxNo.Text;
                    contact.OfficePhone = txtPhoneOffice.Text;
                    contact.Pin = txtPin.Text;
                    contact.Residence = txtResidenceAddress1.Text;
                    contact.ResidenceCity = txtResidenceCity.Text;
                    contact.ResidenceState = txtResidenceState.Text;
                    contact.ResidencePin = txtResidencePin.Text;
                    contact.ResPhone = txtResidencePhone.Text;
                    contact.SMSCellNumber = txtSMSCell.Text;
                    contact.SMSName = txtSMSName.Text;
                    lstCInfo.Add(contact);

                    List<SupplierProprietor> lstPropr = new List<SupplierProprietor>();
                    SupplierProprietor propr = new SupplierProprietor();
                    propr.ContactNumber = txtProprietor1MobileNo.Text;
                    propr.ProprietorName = txtProprietor1.Text;
                    lstPropr.Add(propr);

                    propr = new SupplierProprietor();
                    propr.ContactNumber = txtProprietor2MobileNo.Text;
                    propr.ProprietorName = txtProprietor2.Text;
                    lstPropr.Add(propr);

                    propr = new SupplierProprietor();
                    propr.ContactNumber = txtProprietor3MobileNo.Text;
                    propr.ProprietorName = txtProprietor3.Text;
                    lstPropr.Add(propr);

                    List<SuppSisterConcern> lstSisConcrn = new List<SuppSisterConcern>();

                    DataTable dt = gridControl1.DataSource as DataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int scId = 0;
                        bool isIntVal = Int32.TryParse(Convert.ToString(dt.Rows[i]["SisterConcernName"]), out scId);
                        if (!isIntVal)
                            Int32.TryParse(Convert.ToString(dt.Rows[i]["SisterConcernId"]), out scId);

                        lstSisConcrn.Add(new SuppSisterConcern
                        {
                            SisterConcernId = scId
                        });
                    }

                    if (btnSave.Text == "Save")
                    {
                        int retValue = suppl.InsertCustomer(txtName.Text, txtSupplierACNo.Text, txtAlias.Text, cmbGroup.EditValue.ToString(), cmbZone.EditValue.ToString(),
                                                    Convert.ToInt32(txtODDays.Text), txtBillTerms.Text, cmbPriority.EditValue.ToString(), cmbVariety.EditValue.ToString(),
                                                    Convert.ToInt32(textBox5.Text), txtTanName.Text, txtTanNo.Text, txtRemarks.Text, txtGlobalCode.Text, "", textBox12.Text,
                                                    cmbSTaxOn.EditValue.ToString(), Convert.ToDecimal(txtCommission.Text), cmbPriorityMember.EditValue.ToString(), chkDailyBill.Checked,
                                                    chkBK.Checked, User.UserName, lstBill, lstCInfo, lstPropr, lstSisConcrn);
                        if (retValue > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");                            
                        }
                        else
                        {
                            MessageBox.Show("Error in inserting Data.");
                        }
                    }
                    else
                    {
                        int retValue = suppl.InsertCustomer(txtName.Text, txtSupplierACNo.Text, txtAlias.Text, cmbGroup.EditValue.ToString(), cmbZone.EditValue.ToString(),
                                                        Convert.ToInt32(txtODDays.Text), txtBillTerms.Text, cmbPriority.EditValue.ToString(), cmbVariety.EditValue.ToString(),
                                                        Convert.ToInt32(textBox5.Text), txtTanName.Text, txtTanNo.Text, txtRemarks.Text, txtGlobalCode.Text, "", textBox12.Text,
                                                        cmbSTaxOn.EditValue.ToString(), Convert.ToDecimal(txtCommission.Text), cmbPriorityMember.EditValue.ToString(), chkDailyBill.Checked,
                                                        chkBK.Checked, User.UserName, lstBill, lstCInfo, lstPropr, lstSisConcrn, Convert.ToInt32(cmbSupplierEditList.SelectedValue));
                        if (retValue > 0)
                        {
                            MessageBox.Show("Data updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Error in updating Data.");
                        }
                    }

                    ClearControls();
                    BindDrpListData();
                }
                else
                {
                    MessageBox.Show("Please fill up the required fields.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void txtODDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Check if the pressed character was a backspace or numeric.
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplierEditList.SelectedValue.ToString() != "0")
                {
                    btnSave.Text = "Update";
                    Supplier supplier = (new MstSupplierMgmt()).FindSupplier(Convert.ToInt32(cmbSupplierEditList.SelectedValue));

                    txtName.Text = supplier.SupplierName;
                    txtName.Enabled = false;
                    txtSupplierACNo.Text = supplier.SupplierACNumber;
                    txtAlias.Text = supplier.Alias;
                    cmbGroup.EditValue = supplier.SupplierGroup;
                    cmbZone.EditValue = supplier.SupplierZone;
                    txtODDays.Text = supplier.ODDays.HasValue ? supplier.ODDays.Value.ToString() : "";
                    txtBillTerms.Text = supplier.BillTerms;
                    cmbPriority.EditValue = supplier.Priority;
                    cmbVariety.EditValue = supplier.Variety;
                    textBox5.Text = supplier.FrequencyPerMonth.HasValue ? supplier.FrequencyPerMonth.Value.ToString() : "";
                    txtTanName.Text = supplier.TanName;
                    txtTanNo.Text = supplier.TanNumber;
                    txtRemarks.Text = supplier.Remarks;
                    txtGlobalCode.Text = supplier.GlobalCode;
                    textBox12.Text = supplier.Pin;
                    cmbSTaxOn.EditValue = supplier.ServiceTaxOn;
                    txtCommission.Text = supplier.Commission.HasValue ? supplier.Commission.Value.ToString() : "";
                    cmbPriorityMember.EditValue = supplier.PriorityMember;
                    chkDailyBill.Checked = Convert.ToBoolean(supplier.IsStartDailyBilling);
                    chkBK.Checked = Convert.ToBoolean(supplier.IsBK);

                    int selectedSupplier = Convert.ToInt32(cmbSupplierEditList.SelectedValue);

                    List<SuppSisterConcern> lstSisConcrn = new List<SuppSisterConcern>();
                    foreach(var sisC in supplier.SupplierSisterConcerns
                                                .Where(sc => sc.IsDeleted == false
                                                    && sc.fkSupplierId == selectedSupplier))
                    {
                        lstSisConcrn.Add(new SuppSisterConcern
                            {
                                SisterConcernId = Convert.ToInt32(sisC.fkSupplierSisterConcernId),
                                SisterConcernName = sisC.Supplier1.SupplierName,
                                OldSisterConcernId = Convert.ToInt32(sisC.fkSupplierSisterConcernId)
                            });
                    }

                    gridControl1.DataSource = GetSisterConcernDataSource(lstSisConcrn);

                    MstSupplierMgmt supplierMgmt = new MstSupplierMgmt();
                    List<SuppSisterConcern> sisConcerns = supplierMgmt.SelectSupplier()
                                                            .Where(s=> s.SupplierId!=selectedSupplier)
                                                            .Select(supp => new SuppSisterConcern
                                                            {
                                                                SisterConcernId = supp.SupplierId,
                                                                SisterConcernName = supp.SupplierName,
                                                                OldSisterConcernId = supp.SupplierId
                                                            }).ToList();
                    repositoryCmbSisterConcern.DataSource = sisConcerns;

                    textBox5.Text = supplier.SupplierBillingDetails.ToList()[0].BillFrequency.HasValue ? supplier.SupplierBillingDetails.ToList()[0].BillFrequency.Value.ToString() : "";
                    chkStopMonthlyBill.Checked = supplier.SupplierBillingDetails.ToList()[0].IsStopMonthlyBilling.HasValue ? supplier.SupplierBillingDetails.ToList()[0].IsStopMonthlyBilling.Value : false;
                    txtPanNo.Text = supplier.SupplierBillingDetails.ToList()[0].ITPanNumber;
                    cmbSuppCompany.EditValue = supplier.SupplierBillingDetails.ToList()[0].SupplierCompany;

                    List<SupplierContactInfo> lstCInfo = supplier.SupplierContactInfoes.ToList();
                    txtAddress1.Text = lstCInfo[0].Address;
                    txtCity.Text = lstCInfo[0].City;
                    txtState.Text = lstCInfo[0].State;
                    txtEmail.Text = lstCInfo[0].Email;
                    txtFaxNo.Text = lstCInfo[0].Fax;
                    txtPhoneOffice.Text = lstCInfo[0].OfficePhone;
                    txtPin.Text = lstCInfo[0].Pin;
                    txtResidenceAddress1.Text = lstCInfo[0].Residence;
                    txtResidenceCity.Text = lstCInfo[0].ResidenceCity;
                    txtResidenceState.Text = lstCInfo[0].ResidenceState;
                    txtResidencePin.Text = lstCInfo[0].ResidencePin;
                    txtResidencePhone.Text = lstCInfo[0].ResPhone;
                    txtSMSCell.Text = lstCInfo[0].SMSCellNumber;
                    txtSMSName.Text = lstCInfo[0].SMSName;

                    List<SupplierProprietor> lstPropr = supplier.SupplierProprietors.ToList();
                    txtProprietor1MobileNo.Text = lstPropr[0].ContactNumber;
                    txtProprietor1.Text = lstPropr[0].ProprietorName;

                    txtProprietor2MobileNo.Text = lstPropr[1].ContactNumber;
                    txtProprietor2.Text = lstPropr[1].ProprietorName;

                    txtProprietor3MobileNo.Text = lstPropr[2].ContactNumber;
                    txtProprietor3.Text = lstPropr[2].ProprietorName;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void ClearControls()
        {
            txtName.Text = "";
            txtSupplierACNo.Text = "";
            txtAlias.Text = "";
            cmbGroup.SelectedIndex = 0;
            cmbZone.SelectedIndex = 0;
            txtODDays.Text = "";
            txtBillTerms.Text = "";
            cmbPriority.EditValue = "";
            cmbVariety.SelectedIndex = 0;
            textBox5.Text = "";
            txtTanName.Text = "";
            txtTanNo.Text = "";
            txtRemarks.Text = "";
            txtGlobalCode.Text = "";
            textBox12.Text = "";
            cmbSTaxOn.SelectedIndex = 0;
            txtCommission.Text = "";
            cmbPriorityMember.SelectedIndex = 0;
            chkDailyBill.Checked = false;
            chkBK.Checked = false;

            textBox5.Text = "";
            chkStopMonthlyBill.Checked = false;
            txtPanNo.Text = "";
            cmbSuppCompany.SelectedIndex = 0;

            txtAddress1.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtEmail.Text = "";
            txtFaxNo.Text = "";
            txtPhoneOffice.Text = "";
            txtPin.Text = "";
            txtResidenceAddress1.Text = "";
            txtResidenceCity.Text = "";
            txtResidenceState.Text = "";
            txtResidencePin.Text = "";
            txtResidencePhone.Text = "";
            txtSMSCell.Text = "";
            txtSMSName.Text = "";

            txtProprietor1MobileNo.Text = "";
            txtProprietor1.Text = "";

            txtProprietor2MobileNo.Text = "";
            txtProprietor2.Text = "";

            txtProprietor3MobileNo.Text = "";
            txtProprietor3.Text = "";

            cmbSupplierEditList.SelectedIndex = 0;
            gridControl1.DataSource = GetSisterConcernDataSource();
            btnSave.Text = "Save";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        DataTable GetSisterConcernDataSource(List<SuppSisterConcern> sisConcerns = null)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SisterConcernName", typeof(string));
            dt.Columns.Add("SisterConcernId", typeof(int));
            dt.Columns.Add("OldSisterConcernId", typeof(int));

            if (sisConcerns != null)
            {
                foreach (var sc in sisConcerns)
                {
                    DataRow r = dt.NewRow();
                    r["SisterConcernName"] = sc.SisterConcernName;
                    r["SisterConcernId"] = sc.SisterConcernId;
                    r["OldSisterConcernId"] = sc.OldSisterConcernId;
                    dt.Rows.Add(r);
                }
            }

            return dt;
        }

        private void SetupSisterConcernGrid()
        {
            gridControl1.DataSource = GetSisterConcernDataSource(null);
            MstSupplierMgmt supplierMgmt = new MstSupplierMgmt();
            List<SuppSisterConcern> sisConcerns = supplierMgmt.SelectSupplier().Select(supp => new SuppSisterConcern
            {
                SisterConcernId = supp.SupplierId,
                SisterConcernName = supp.SupplierName,
                OldSisterConcernId = -1
            }).ToList();
            repositoryCmbSisterConcern.CustomDisplayText += repositoryCmbSisterConcern_CustomDisplayText;
            repositoryCmbSisterConcern.DataSource = sisConcerns;
        }

        void repositoryCmbSisterConcern_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && !e.Value.ToString().ToLower().Contains("system.object"))
                e.DisplayText = !string.IsNullOrEmpty(e.DisplayText) ? e.DisplayText.ToLower().Contains("system.object") ? string.Empty : e.DisplayText : e.Value.ToString();
        }
    }
}

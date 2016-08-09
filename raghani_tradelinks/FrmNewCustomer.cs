using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using RT.BL;
using RT.DL;

namespace raghani_tradelinks
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void FrmNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmNewCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.Enter))
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                BindDrpListData();

                #region Old
                //BindingList<string> list = new BindingList<string>();
                //list.AllowNew = true;
                //gridControl1.DataSource = list;
                //gridControl1.UseEmbeddedNavigator = true;
                //gridView1.PopulateColumns();
                //RepositoryItemImageComboBox ritem = new RepositoryItemImageComboBox();
                //gridControl1.RepositoryItems.Add(ritem);
                //gridView1.Columns["existingSisterConcernColumn"].ColumnEdit = ritem;
                //ritem.Items.Add(new ImageComboBoxItem
                //{
                //    Description = "Sun",
                //    Value = "Sun"
                //});
                //ritem.Items.Add(new ImageComboBoxItem
                //{
                //    Description = "Sat",
                //    Value = "Sat"
                //}
                //);
                #endregion

                gridControl1.DataSource = GetSisterConcernDataSource();
                RepositoryItemImageComboBox ritem = new RepositoryItemImageComboBox();
                gridControl1.RepositoryItems.Add(ritem);
                gridView1.Columns["ExistingSisterConcern"].ColumnEdit = ritem;

                MstCustomerMgt cust = new MstCustomerMgt();
                var data = cust.SelectSisterCompany();
                foreach (var d in data)
                {
                    ritem.Items.Add(new ImageComboBoxItem
                    {
                        Description = d.CustomerName,
                        Value = d.CustomerId
                    });
                }
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

        void BindDrpListData()
        {
            try
            {
                MstCustomerMgt cust = new MstCustomerMgt();
                cmbACCreatedByBranch.ValueMember = "BranchId";
                cmbACCreatedByBranch.DisplayMember = "BranchName";
                cmbACCreatedByBranch.DataSource = cust.SelectBranch();

                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_dealing_type.json"));
                var _dealingList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbDelingType.Properties.Items.AddRange(_dealingList);
                cmbDelingType.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_firm_type_list.json"));
                var _typeOfFirm = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbTypeOfFirm.Properties.Items.AddRange(_typeOfFirm);
                cmbTypeOfFirm.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_gr_habbit.json"));
                var _grHabbit = JsonConvert.DeserializeObject<List<GRHabbit>>(result);
                cmbGRHabbit.Properties.Items.AddRange(_grHabbit);
                cmbGRHabbit.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_group_list.json"));
                var _grpList = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbGroup.Properties.Items.AddRange(_grpList);
                cmbGroup.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_priority_list.json"));
                var _priority = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbPriority.Properties.Items.AddRange(_priority);
                cmbPriority.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_ref_type.json"));
                var _refType = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbRefType.Properties.Items.AddRange(_refType);
                cmbRefType.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_status.json"));
                var _status = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbStatus.Properties.Items.AddRange(_status);
                cmbStatus.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_visit_freq.json"));
                var _visitFreq = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbVisistFreq.Properties.Items.AddRange(_visitFreq);
                cmbVisistFreq.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/cust_zone_list.json"));
                var _zone = JsonConvert.DeserializeObject<List<VisistFrequency>>(result);
                cmbZone.Properties.Items.AddRange(_zone);
                cmbZone.SelectedIndex = 0;

                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "ID";
                cmbCity.DataSource = (new MstCityMgmt()).SelectData().Cities;

                cmbState.DisplayMember = "Name";
                cmbState.ValueMember = "ID";
                cmbState.DataSource = (new MstStateMgt()).SelectData();

                cmbSubAgent.DisplayMember = "SubAgentName";
                cmbSubAgent.ValueMember = "SubAgentId";
                cmbSubAgent.DataSource = (new MstSubAgentMgmt()).SelectData().SubAgents;

                cmbCustomerToEdit.Items.Insert(0, "Select");
                cmbCustomerToEdit.DisplayMember = "CustomerName";
                cmbCustomerToEdit.ValueMember = "CustomerId";
                cmbCustomerToEdit.DataSource = (new MstCustomerMgt()).SelectCustomer();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        DataTable GetSisterConcernDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ExistingSisterConcern", typeof(string));
            return dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validator1.Validate() == true && dxValidationProvider1.Validate() == true)
                {
                    List<clsCustomerSisterConcern> lstSisConcern = new List<clsCustomerSisterConcern>();
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        var data = gridView1.GetRowCellValue(i, "ExistingSisterConcern");
                    }

                    List<clsAuthorization> lstAuthor = new List<clsAuthorization>() {
                                                        new clsAuthorization 
                                                        {
                                                            Director1Name = cmbDirector1.EditValue.ToString(), 
                                                            Director2Name = cmbDirector2.EditValue.ToString(),
                                                            Director3Name = cmbDirector3.EditValue.ToString(), 
                                                            BranchHead = cmbBranchHead.EditValue.ToString()
                                                        }};

                    List<clsCustomerContactInfo> lstCustCInfo = new List<clsCustomerContactInfo>() {
                                                                new clsCustomerContactInfo 
                                                                {
                                                                    Address = txtAddress1.Text, Email = txtEmail.Text, Fax = txtFaxNo.Text,
                                                                    OfficePhone = txtPhoneOffice.Text,
                                                                    RemContactPerson = txtRemContactPerson.Text,
                                                                    RemContactPhone = txtRemContactPhone.Text,
                                                                    RemSMSCell1 = txtRemSMSCell1.Text,
                                                                    RemSMSCell2 = txtRemSMSCell2.Text,
                                                                    SMSCellNumber = txtSMSCellNo.Text,
                                                                    SMSName = txtSMSName.Text,
                                                                    STDCode = txtSTDCode.Text,
                                                                    Pincode = txtPin.Text,
                                                                    fkCityId = Convert.ToInt32(cmbCity.SelectedValue),
                                                                    fkStateId = Convert.ToInt32(cmbState.SelectedValue)
                                                                }
                                                            };

                    List<clsCustomerInfo> lstCustInfo = new List<clsCustomerInfo>() {
                                                        new clsCustomerInfo()
                                                        {
                                                                Abuse = txtAbuse.Text,
                                                                CreditLimit = Convert.ToDecimal(mskCreaditLimit.Text),
                                                                DealingType = cmbDelingType.EditValue.ToString(),
                                                                DirectDealing = txtDirectDealing.Text,
                                                                GRHabbit = cmbGRHabbit.EditValue.ToString(),
                                                                Hotel = txtHotel.Text,
                                                                OtherAgent = txtOtherAgent.Text,
                                                                PaymentHabbit = txtPaymentHabbit.Text,
                                                                RapportType = cmbRefType.EditValue.ToString(),
                                                                Remarks = txtRemarks.Text,
                                                                TransportReference = txtTransPref.Text,
                                                                VisitFrequency = cmbVisistFreq.EditValue.ToString()                                                                
                                                        }};

                    List<clsCustomerProprietor> lstCustPropr = new List<clsCustomerProprietor>() { 
                                                                new clsCustomerProprietor()
                                                                {
                                                                    ContactNumber = txtProprietor1MobileNo.Text,
                                                                    ProprietorName = txtProprietor1.Text,
                                                                },
                                                                new clsCustomerProprietor()
                                                                {
                                                                    ContactNumber = txtProprietor2MobileNo.Text,
                                                                    ProprietorName = txtProprietor2.Text,
                                                                },
                                                                new clsCustomerProprietor()
                                                                {
                                                                    ContactNumber = txtProprietor3MobileNo.Text,
                                                                    ProprietorName = txtProprietor3.Text,
                                                                }};

                    List<clsCustomerSalesman> lstSalesman = new List<clsCustomerSalesman>() { 
                                                            new clsCustomerSalesman()
                                                            {
                                                                ContactNumber = txtSalesman1MobileNo.Text,
                                                                SalesmanName = txtSalesman1.Text
                                                            },
                                                            new clsCustomerSalesman()
                                                            {
                                                                ContactNumber = txtSalesman2MobileNo.Text,
                                                                SalesmanName = txtSalesman2.Text
                                                            },
                                                            new clsCustomerSalesman()
                                                            {
                                                                ContactNumber = txtSalesman3MobileNo.Text,
                                                                SalesmanName = txtSalesman3.Text
                                                            }};

                    List<clsCustomerAccountant> lstCustAcct = new List<clsCustomerAccountant>() { 
                                                                new clsCustomerAccountant()
                                                                {
                                                                    AccountantName =textBox9.Text,
                                                                    ContactNumber=maskedTextBox4.Text
                                                                },
                                                                new clsCustomerAccountant()
                                                                {
                                                                    AccountantName =textBox8.Text,
                                                                    ContactNumber=maskedTextBox3.Text
                                                                },
                                                                new clsCustomerAccountant()
                                                                {
                                                                    AccountantName =textBox7.Text,
                                                                    ContactNumber=maskedTextBox2.Text
                                                                }};

                    List<clsParty> lstParty = new List<clsParty>() { 
                                                new clsParty()
                                                {
                                                    PartyName = txtParty1.Text,
                                                    Remarks = txtRemarks1.Text,
                                                    SpokenBy = txtSpokenBy1.Text,
                                                    SpokenDate = Convert.ToDateTime(txtSpokenDt1.MaskFull == true ? txtSpokenDt1.Text : null),
                                                    SpokenTo = txtSpokenTo1.Text
                                                },
                                                new clsParty()
                                                {
                                                    PartyName = txtParty2.Text,
                                                    Remarks = txtRemarks2.Text,
                                                    SpokenBy = txtSpokenBy2.Text,
                                                    SpokenDate = Convert.ToDateTime(txtSpokenDt2.MaskFull == true ? txtSpokenDt2.Text : null),
                                                    SpokenTo = txtSpokenTo2.Text
                                                },
                                                new clsParty()
                                                {
                                                    PartyName = txtParty3.Text,
                                                    Remarks = txtRemarks3.Text,
                                                    SpokenBy = txtSpokenBy3.Text,
                                                    SpokenDate = Convert.ToDateTime(txtSpokenDt3.MaskFull == true ? txtSpokenDt3.Text : null),
                                                    SpokenTo = txtSpokenTo3.Text
                                                },
                                                new clsParty()
                                                {
                                                    PartyName = txtParty4.Text,
                                                    Remarks = txtRemarks4.Text,
                                                    SpokenBy = txtSpokenBy4.Text,
                                                    SpokenDate = Convert.ToDateTime(txtSpokenDt4.MaskFull == true ? txtSpokenDt4.Text : null),
                                                    SpokenTo = txtSpokenTo4.Text
                                                },
                                                new clsParty()
                                                {
                                                    PartyName = txtParty5.Text,
                                                    Remarks = txtRemarks5.Text,
                                                    SpokenBy = txtSpokenBy5.Text,
                                                    SpokenDate = Convert.ToDateTime(txtSpokenDt5.MaskFull == true ? txtSpokenDt5.Text : null),
                                                    SpokenTo = txtSpokenTo5.Text
                                                }};

                    List<clsReference> lstRef = new List<clsReference>() { 
                                                new clsReference()
                                                {
                                                    ReferenceType = cmbRefType.EditValue.ToString(),
                                                    TourBy = txtTourBy.Text,
                                                    TourDate = Convert.ToDateTime(txtTourDt.Text)
                                                }};

                    MstCustomerMgt cust = new MstCustomerMgt();

                    if (btnSave.Text == "Save")
                    {
                        int id = cust.InsertCustomer(txtCustomerACNo.Text, Convert.ToInt32(cmbACCreatedByBranch.SelectedValue), cmbCashCredit.EditValue.ToString(), txtName.Text,
                                            txtAlias.Text, cmbTypeOfFirm.EditValue.ToString(), cmbPriority.EditValue.ToString(), cmbStatus.Text, txtTIN.Text, txtCSTNo.Text, txtGSTNo.Text,
                                            txtLastOAC.Text, Convert.ToInt32(chkNoLRAddressPrinting.Checked), Convert.ToInt32(cmbSubAgent.SelectedValue), cmbZone.EditValue.ToString(),
                                            cmbGroup.EditValue.ToString(), User.UserName, lstAuthor, lstCustCInfo, lstCustInfo, lstCustPropr, lstSalesman, lstSisConcern, lstCustAcct,
                                            lstParty, lstRef, 0);
                        if (id > 0)
                        {
                            MessageBox.Show("Data inserted successfully");
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Error in inserting data.");
                        }
                    }
                    else
                    {
                        int id = cust.InsertCustomer(txtCustomerACNo.Text, Convert.ToInt32(cmbACCreatedByBranch.SelectedValue), cmbCashCredit.EditValue.ToString(), txtName.Text,
                                            txtAlias.Text, cmbTypeOfFirm.EditValue.ToString(), cmbPriority.EditValue.ToString(), cmbStatus.Text, txtTIN.Text, txtCSTNo.Text, txtGSTNo.Text,
                                            txtLastOAC.Text, Convert.ToInt32(chkNoLRAddressPrinting.Checked), Convert.ToInt32(cmbSubAgent.SelectedValue), cmbZone.EditValue.ToString(),
                                            cmbGroup.EditValue.ToString(), User.UserName, lstAuthor, lstCustCInfo, lstCustInfo, lstCustPropr, lstSalesman, lstSisConcern, lstCustAcct,
                                            lstParty, lstRef, Convert.ToInt32(cmbCustomerToEdit.SelectedValue));
                        if (id > 0)
                        {
                            MessageBox.Show("Data updated successfully");
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Error in updating data.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the required fileds in all the Tabs.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomerToEdit.SelectedValue != "Select")
                {
                    MstCustomerMgt cust = new MstCustomerMgt();
                    Customer customer = cust.FindCustomer(Convert.ToInt32(cmbCustomerToEdit.SelectedValue));
                    btnSave.Text = "Update";

                    List<Authorization> lstAuthor = customer.Authorizations.ToList();
                    List<CustomerContactInfo> lstCustCInfo = customer.CustomerContactInfoes.ToList();
                    List<CustomerInfo> lstCustInfo = customer.CustomerInfoes.ToList();
                    List<CustomerProprietor> lstCustPropr = customer.CustomerProprietors.ToList();
                    List<CustomerSalesman> lstSalesman = customer.CustomerSalesmen.ToList();
                    List<CustomerAccountant> lstCustAcct = customer.CustomerAccountants.ToList();
                    List<Party> lstParty = customer.Parties.ToList();
                    List<Reference> lstRef = customer.References.ToList();

                    txtCustomerACNo.Text = customer.CustomerACNumber;
                    cmbACCreatedByBranch.SelectedValue = customer.fkCreatedByBranchId;
                    cmbCashCredit.EditValue = customer.CashOrCredit;
                    txtName.Text = customer.CustomerName;
                    txtName.ReadOnly = true;
                    txtAlias.Text = customer.Alias;
                    cmbTypeOfFirm.EditValue = customer.TypeOfFirm;
                    cmbPriority.EditValue = customer.Priority;
                    cmbStatus.EditValue = customer.Status;
                    txtTIN.Text = customer.TIN;
                    txtCSTNo.Text = customer.CSTNumber;
                    txtGSTNo.Text = customer.GSTNumber;
                    txtLastOAC.Text = customer.LastOAC;
                    chkNoLRAddressPrinting.Checked = customer.NoLRAddressPrinting.Value == 0 ? false : true;
                    cmbSubAgent.SelectedValue = customer.fkSubAgentId;
                    cmbZone.EditValue = customer.Zone;
                    cmbGroup.EditValue = customer.Group;

                    cmbDirector1.EditValue = lstAuthor[0].Director1Name;
                    cmbDirector2.EditValue = lstAuthor[0].Director2Name;
                    cmbDirector3.EditValue = lstAuthor[0].Director3Name;
                    cmbBranchHead.EditValue = lstAuthor[0].BranchHead;

                    txtAddress1.Text = lstCustCInfo[0].Address;
                    txtEmail.Text = lstCustCInfo[0].Email;
                    txtFaxNo.Text = lstCustCInfo[0].Fax;
                    txtPhoneOffice.Text = lstCustCInfo[0].OfficePhone;
                    txtRemContactPerson.Text = lstCustCInfo[0].RemContactPerson;
                    txtRemContactPhone.Text = lstCustCInfo[0].RemContactPhone;
                    txtRemSMSCell1.Text = lstCustCInfo[0].RemSMSCell1;
                    txtRemSMSCell2.Text = lstCustCInfo[0].RemSMSCell2;
                    txtSMSCellNo.Text = lstCustCInfo[0].SMSCellNumber;
                    txtSMSName.Text = lstCustCInfo[0].SMSName;
                    txtSTDCode.Text = lstCustCInfo[0].STDCode;
                    cmbCity.SelectedValue = lstCustCInfo[0].fkCityId;
                    cmbState.SelectedValue = lstCustCInfo[0].fkStateId;
                    txtPin.Text = lstCustCInfo[0].Pincode;

                    txtAbuse.Text = lstCustInfo[0].Abuse;
                    mskCreaditLimit.Text = lstCustInfo[0].CreditLimit.Value.ToString();
                    cmbDelingType.EditValue = lstCustInfo[0].DealingType;
                    txtDirectDealing.Text = lstCustInfo[0].DirectDealing;
                    cmbGRHabbit.EditValue = lstCustInfo[0].GRHabbit;
                    txtHotel.Text = lstCustInfo[0].Hotel;
                    txtOtherAgent.Text = lstCustInfo[0].OtherAgent;
                    txtPaymentHabbit.Text = lstCustInfo[0].PaymentHabbit;
                    cmbRefType.EditValue = lstCustInfo[0].RapportType;
                    txtRemarks.Text = lstCustInfo[0].Remarks;
                    txtTransPref.Text = lstCustInfo[0].TransportReference;
                    cmbVisistFreq.EditValue = lstCustInfo[0].VisitFrequency;

                    txtProprietor1MobileNo.Text = lstCustPropr[0].ContactNumber;
                    txtProprietor1.Text = lstCustPropr[0].ProprietorName;
                    txtProprietor2MobileNo.Text = lstCustPropr[1].ContactNumber;
                    txtProprietor2.Text = lstCustPropr[1].ProprietorName;
                    txtProprietor3MobileNo.Text = lstCustPropr[2].ContactNumber;
                    txtProprietor3.Text = lstCustPropr[2].ProprietorName;

                    txtSalesman1MobileNo.Text = lstSalesman[0].ContactNumber;
                    txtSalesman1.Text = lstSalesman[0].SalesmanName;
                    txtSalesman2MobileNo.Text = lstSalesman[1].ContactNumber;
                    txtSalesman2.Text = lstSalesman[1].SalesmanName;
                    txtSalesman3MobileNo.Text = lstSalesman[2].ContactNumber;
                    txtSalesman3.Text = lstSalesman[2].SalesmanName;

                    textBox9.Text = lstCustAcct[0].AccountantName;
                    maskedTextBox4.Text = lstCustAcct[0].ContactNumber;
                    textBox8.Text = lstCustAcct[1].AccountantName;
                    maskedTextBox3.Text = lstCustAcct[1].ContactNumber;
                    textBox7.Text = lstCustAcct[2].AccountantName;
                    maskedTextBox2.Text = lstCustAcct[2].ContactNumber;

                    txtParty1.Text = lstParty[0].PartyName;
                    txtRemarks1.Text = lstParty[0].Remarks;
                    txtSpokenBy1.Text = lstParty[0].SpokenBy;
                    txtSpokenDt1.Text = lstParty[0].SpokenDate.HasValue ? lstParty[0].SpokenDate.Value.ToString("dd-MM-yyyy") : "";
                    txtSpokenTo1.Text = lstParty[0].SpokenTo;
                    txtParty2.Text = lstParty[1].PartyName;
                    txtRemarks2.Text = lstParty[1].Remarks;
                    txtSpokenBy2.Text = lstParty[1].SpokenBy;
                    txtSpokenDt2.Text = lstParty[1].SpokenDate.HasValue ? lstParty[1].SpokenDate.Value.ToString("dd-MM-yyyy") : "";
                    txtSpokenTo2.Text = lstParty[1].SpokenTo;
                    txtParty3.Text = lstParty[2].PartyName;
                    txtRemarks3.Text = lstParty[2].Remarks;
                    txtSpokenBy3.Text = lstParty[2].SpokenBy;
                    txtSpokenDt3.Text = lstParty[2].SpokenDate.HasValue ? lstParty[2].SpokenDate.Value.ToString("dd-MM-yyyy") : "";
                    txtSpokenTo3.Text = lstParty[2].SpokenTo;
                    txtParty4.Text = lstParty[3].PartyName;
                    txtRemarks4.Text = lstParty[3].Remarks;
                    txtSpokenBy4.Text = lstParty[3].SpokenBy;
                    txtSpokenDt4.Text = lstParty[3].SpokenDate.HasValue ? lstParty[3].SpokenDate.Value.ToString("dd-MM-yyyy") : "";
                    txtSpokenTo4.Text = lstParty[3].SpokenTo;
                    txtParty5.Text = lstParty[4].PartyName;
                    txtRemarks5.Text = lstParty[4].Remarks;
                    txtSpokenBy5.Text = lstParty[4].SpokenBy;
                    txtSpokenDt5.Text = lstParty[4].SpokenDate.HasValue ? lstParty[4].SpokenDate.Value.ToString("dd-MM-yyyy") : "";
                    txtSpokenTo5.Text = lstParty[4].SpokenTo;

                    cmbRefType.EditValue = lstRef[0].ReferenceType;
                    txtTourBy.Text = lstRef[0].TourBy;
                    txtTourDt.Text = lstRef[0].TourDate.HasValue ? lstRef[0].TourDate.Value.ToString("dd-MM-yyyy") : "";

                }
                else
                    MessageBox.Show("Please select Customer to edit.");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void ClearControls()
        {
            txtCustomerACNo.Text = "";
            cmbACCreatedByBranch.SelectedIndex = 0;
            cmbCashCredit.SelectedIndex = 0;
            txtName.Text = "";
            txtAlias.Text = "";
            cmbTypeOfFirm.SelectedIndex = 0;
            cmbPriority.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            txtTIN.Text = "";
            txtCSTNo.Text = "";
            txtGSTNo.Text = "";
            txtLastOAC.Text = "";
            chkNoLRAddressPrinting.Checked = false;
            cmbSubAgent.SelectedIndex = 0;
            cmbZone.SelectedIndex = 0;
            cmbGroup.SelectedIndex = 0;

            cmbDirector1.SelectedIndex = 0;
            cmbDirector2.SelectedIndex = 0;
            cmbDirector3.SelectedIndex = 0;
            cmbBranchHead.SelectedIndex = 0;

            txtAddress1.Text = "";
            txtEmail.Text = "";
            txtFaxNo.Text = "";
            txtPhoneOffice.Text = "";
            txtRemContactPerson.Text = "";
            txtRemContactPhone.Text = "";
            txtRemSMSCell1.Text = "";
            txtRemSMSCell2.Text = "";
            txtSMSCellNo.Text = "";
            txtSMSName.Text = "";
            txtSTDCode.Text = "";
            cmbCity.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            txtPin.Text = "";

            txtAbuse.Text = "";
            mskCreaditLimit.Text = "";
            cmbDelingType.SelectedIndex = 0;
            txtDirectDealing.Text = "";
            cmbGRHabbit.EditValue = "";
            txtHotel.Text = "";
            txtOtherAgent.Text = "";
            txtPaymentHabbit.Text = "";
            cmbRefType.EditValue = "";
            txtRemarks.Text = "";
            txtTransPref.Text = "";
            cmbVisistFreq.EditValue = "";

            txtProprietor1MobileNo.Text = "";
            txtProprietor1.Text = "";
            txtProprietor2MobileNo.Text = "";
            txtProprietor2.Text = "";
            txtProprietor3MobileNo.Text = "";
            txtProprietor3.Text = "";

            txtSalesman1MobileNo.Text = "";
            txtSalesman1.Text = "";
            txtSalesman2MobileNo.Text = "";
            txtSalesman2.Text = "";
            txtSalesman3MobileNo.Text = "";
            txtSalesman3.Text = "";

            textBox9.Text = "";
            maskedTextBox4.Text = "";
            textBox8.Text = "";
            maskedTextBox3.Text = "";
            textBox7.Text = "";
            maskedTextBox2.Text = "";

            txtParty1.Text = "";
            txtRemarks1.Text = "";
            txtSpokenBy1.Text = "";
            txtSpokenDt1.Text = "";
            txtSpokenTo1.Text = "";
            txtParty2.Text = "";
            txtRemarks2.Text = "";
            txtSpokenBy2.Text = "";
            txtSpokenDt2.Text = "";
            txtSpokenTo2.Text = "";
            txtParty3.Text = "";
            txtRemarks3.Text = "";
            txtSpokenBy3.Text = "";
            txtSpokenDt3.Text = "";
            txtSpokenTo3.Text = "";
            txtParty4.Text = "";
            txtRemarks4.Text = "";
            txtSpokenBy4.Text = "";
            txtSpokenDt4.Text = "";
            txtSpokenTo4.Text = "";
            txtParty5.Text = "";
            txtRemarks5.Text = "";
            txtSpokenBy5.Text = "";
            txtSpokenDt5.Text = "";
            txtSpokenTo5.Text = "";

            cmbRefType.SelectedIndex = 0;
            txtTourBy.Text = "";
            txtTourDt.Text = "";
            btnSave.Text = "Save";
        }
    }
}

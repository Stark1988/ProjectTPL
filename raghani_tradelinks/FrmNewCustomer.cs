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
            this.Close();
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
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Sun",
                    Value = "Sunday"
                });
                ritem.Items.Add(new ImageComboBoxItem
                {
                    Description = "Sat",
                    Value = "Saturday"
                }
                );
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

                cmbCity
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
                     

                    }

                    MstCustomerMgt cust = new MstCustomerMgt();

                    int id = cust.InsertCustomer(txtCustomerACNo.Text, Convert.ToInt32(cmbACCreatedByBranch.SelectedValue), cmbCashCredit.SelectedText, txtName.Text, txtAlias.Text,
                                        cmbTypeOfFirm.SelectedText, cmbPriority.SelectedText, cmbStatus.Text, txtTIN.Text, txtCSTNo.Text, txtGSTNo.Text, txtLastOAC.Text,
                                        Convert.ToInt32(chkNoLRAddressPrinting.Checked), Convert.ToInt32(cmbSubAgent.SelectedValue), cmbZone.SelectedText, cmbGroup.SelectedText,
                                        User.UserName, new List<clsAuthorization>(){
                                        new clsAuthorization 
                                        {
                                         Director1Name = cmbDirector1.SelectedText,
                                         Director2Name = cmbDirector2.SelectedText,
                                         Director3Name = cmbDirector3.SelectedText,
                                         BranchHead = cmbBranchHead.SelectedText
                                        }
                                    }, new List<clsCustomerContactInfo>(){
                                        new clsCustomerContactInfo 
                                        {
                                            Address = txtAddress1.Text,
                                            Email = txtEmail.Text,
                                            Fax = txtFaxNo.Text,
                                            OfficePhone = txtPhoneOffice.Text,
                                            RemContactPerson = txtRemContactPerson.Text,
                                            RemContactPhone = txtRemContactPhone.Text,
                                            RemSMSCell1 = txtRemSMSCell1.Text,
                                            RemSMSCell2 = txtRemSMSCell2.Text,
                                            SMSCellNumber = txtSMSCellNo.Text,
                                            SMSName = txtSMSName.Text,
                                            STDCode = txtSTDCode.Text
                                        }
                                    }, new List<clsCustomerInfo>(){
                                        new clsCustomerInfo()
                                        {
                                             Abuse = txtAbuse.Text,
                                             CreditLimit = Convert.ToDecimal( mskCreaditLimit.Text),
                                             DealingType = cmbDelingType.SelectedText,
                                             DirectDealing = txtDirectDealing.Text,
                                             GRHabbit = cmbGRHabbit.SelectedText,
                                             Hotel = txtHotel.Text,
                                             OtherAgent = txtOtherAgent.Text,
                                             PaymentHabbit = txtPaymentHabbit.Text,
                                             RapportType = cmbRefType.SelectedText,
                                             Remarks = txtRemarks.Text,
                                             TransportReference = txtTransPref.Text,
                                             VisitFrequency = cmbVisistFreq.SelectedText
                                        }
                                    }, new List<clsCustomerProprietor>() { 
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
                                        }
                                    }, new List<clsCustomerSalesman>() { 
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
                                        }
                                    }, lstSisConcern, new List<clsCustomerAccountant>() 
                                    { 
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
                                        }
                                    }, new List<clsParty>() { 
                                        new clsParty()
                                        {
                                            Nature = cmbNature1.SelectedText,
                                            PartyName = txtParty1.Text,
                                            Remarks = txtRemarks1.Text,
                                            SpokenBy = txtSpokenBy1.Text,
                                            SpokenDate = Convert.ToDateTime(txtSpokenDt1.Text),
                                            SpokenTo = txtSpokenTo1.Text
                                        },
                                        new clsParty()
                                        {
                                            Nature = cmbNature2.SelectedText,
                                            PartyName = txtParty2.Text,
                                            Remarks = txtRemarks2.Text,
                                            SpokenBy = txtSpokenBy2.Text,
                                            SpokenDate = Convert.ToDateTime(txtSpokenDt2.Text),
                                            SpokenTo = txtSpokenTo2.Text
                                        },
                                        new clsParty()
                                        {
                                            Nature = cmbNature3.SelectedText,
                                            PartyName = txtParty3.Text,
                                            Remarks = txtRemarks3.Text,
                                            SpokenBy = txtSpokenBy3.Text,
                                            SpokenDate = Convert.ToDateTime(txtSpokenDt3.Text),
                                            SpokenTo = txtSpokenTo3.Text
                                        },
                                        new clsParty()
                                        {
                                            Nature = cmbNature4.SelectedText,
                                            PartyName = txtParty4.Text,
                                            Remarks = txtRemarks4.Text,
                                            SpokenBy = txtSpokenBy4.Text,
                                            SpokenDate = Convert.ToDateTime(txtSpokenDt4.Text),
                                            SpokenTo = txtSpokenTo4.Text
                                        },
                                        new clsParty()
                                        {
                                            Nature = cmbNature5.SelectedText,
                                            PartyName = txtParty5.Text,
                                            Remarks = txtRemarks5.Text,
                                            SpokenBy = txtSpokenBy5.Text,
                                            SpokenDate = Convert.ToDateTime(txtSpokenDt5.Text),
                                            SpokenTo = txtSpokenTo5.Text
                                        }
                                    }, new List<clsReference>() { 
                                        new clsReference()
                                        {
                                            ReferenceType = cmbRefType.SelectedText,
                                            TourBy = txtTourBy.Text,
                                            TourDate = Convert.ToDateTime(txtTourDt.Text)
                                        }
                                    });
                    if (id > 0)
                    {
                        MessageBox.Show("Data inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error in inserting data.");
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}

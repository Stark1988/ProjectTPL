using DevExpress.XtraEditors.Controls;
using Newtonsoft.Json;
using RT.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raghani_tradelinks
{
    public partial class FrmReturnDraft : Form
    {
        TPLDBEntities db = null;
        List<DraftChequeDetail> draftChequeList = null;
        List<BillDetail> bills = null;

        public FrmReturnDraft()
        {
            InitializeComponent();
        }

        private void FrmReturnDraft_Load(object sender, EventArgs e)
        {
            db = new TPLDBEntities();
            PopulateDropdowns();

            txtDrawnOn.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtAmountDue.ReadOnly = true;
        }

        private void PopulateDropdowns()
        {
            try
            {
                List<Supplier> supplierList = (from s in db.Suppliers
                                               where s.IsDeleted == false
                                               select s).ToList();

                List<Customer> customerList = (from c in db.Customers
                                               where c.IsDeleted == false
                                               select c).ToList();

                customerList.Insert(0, new Customer { CustomerId = -1, CustomerName = "Select Customer" });
                cmbCustomer.Properties.DataSource = customerList;
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerId") { Visible = false });
                cmbCustomer.Properties.Columns.Add(new LookUpColumnInfo("CustomerName"));
                cmbCustomer.Properties.DisplayMember = "CustomerName";
                cmbCustomer.Properties.ValueMember = "CustomerId";
                cmbCustomer.EditValue = -1;
                cmbCustomer.Properties.ShowHeader = false;

                supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
                cmbSupplier.Properties.DataSource = supplierList;
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierId") { Visible = false });
                cmbSupplier.Properties.Columns.Add(new LookUpColumnInfo("SupplierName"));
                cmbSupplier.Properties.DisplayMember = "SupplierName";
                cmbSupplier.Properties.ValueMember = "SupplierId";
                cmbSupplier.EditValue = -1;
                cmbSupplier.Properties.ShowHeader = false;

                string resultDraftOrCheque = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_draftOrCheque.json"));
                var _draftOrChequeList = JsonConvert.DeserializeObject<List<DealingType>>(resultDraftOrCheque);
                cmbDraftOrCheque.Properties.Items.AddRange(_draftOrChequeList);
                cmbDraftOrCheque.SelectedIndex = 0;

                string resultDocuments = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_documents.json"));
                var _documentsList = JsonConvert.DeserializeObject<List<DealingType>>(resultDocuments);
                cmbDocuments.Properties.Items.AddRange(_documentsList);
                cmbDocuments.SelectedIndex = 0;

                string resultEnclosed = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_enclosed.json"));
                var _enclosedList = JsonConvert.DeserializeObject<List<DealingType>>(resultEnclosed);
                cmbEnclosed.Properties.Items.AddRange(_enclosedList);
                cmbEnclosed.SelectedIndex = 0;

                string resultType = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/returnDraft_type.json"));
                var _typeList = JsonConvert.DeserializeObject<List<DealingType>>(resultType);
                cmbType.Properties.Items.AddRange(_typeList);
                cmbType.SelectedIndex = 0;

                cmbDraftOrCheckNo.Properties.NullText = "Select Draft/Cheque No.";
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void cmbCustomer_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbCustomer.EditValue != -1 && (int)cmbSupplier.EditValue != -1)
                {
                    PopulateDraftDetails();
                    PopulateBillDetails();
                    CalculateTotalDueAmount();
                }
                else
                {
                    ClearDependentData();
                }
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void cmbSupplier_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cmbCustomer.EditValue != -1 && (int)cmbSupplier.EditValue != -1)
                {
                    PopulateDraftDetails();
                    PopulateBillDetails();
                    CalculateTotalDueAmount();
                }
                else
                {
                    ClearDependentData();
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void PopulateBillDetails()
        {
            try
            {
                bills = (from saleLREntry in db.SaleLREntries
                         where saleLREntry.IsDeleted == false
                                && saleLREntry.fkCustomerId == (int)cmbCustomer.EditValue
                                && saleLREntry.fkSupplierId == (int)cmbSupplier.EditValue
                         select new BillDetail
                         {
                             BillNo = saleLREntry.BillNumber,
                             BillDate = saleLREntry.BillDate,
                             BillAmount = saleLREntry.BillAmount
                         }).ToList();

                if (bills != null && bills.Count > 0)
                {
                    gridBillDetails.DataSource = bills;
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void PopulateDraftDetails()
        {
            try
            {
                draftChequeList = (from coll in db.CollectionEntries
                                   where coll.IsDeleted == false
                                           && coll.IsReturnedDraft == false
                                           && coll.fkCustomerId == (int)cmbCustomer.EditValue
                                           && coll.fkSupplierId == (int)cmbSupplier.EditValue
                                   select new DraftChequeDetail
                                   {
                                       DraftChequeNumber = coll.DDOrChequeNumber,
                                       DraftChequeDate = coll.DDOrChequeDate,
                                       DrawnOn = coll.MstBank.BankName,
                                       Amount = coll.DraftAmount
                                   }).ToList();

                if (draftChequeList.Count() > 0)
                {
                    draftChequeList.Insert(0, new DraftChequeDetail { DraftChequeNumber = "Select Draft/Cheque No." });
                    cmbDraftOrCheckNo.Properties.DataSource = draftChequeList;
                    cmbDraftOrCheckNo.Properties.Columns.Clear();
                    cmbDraftOrCheckNo.Properties.Columns.Add(new LookUpColumnInfo("DraftChequeNumber"));
                    cmbDraftOrCheckNo.Properties.DisplayMember = "DraftChequeNumber";
                    cmbDraftOrCheckNo.Properties.ValueMember = "DraftChequeNumber";
                    cmbDraftOrCheckNo.EditValue = "Select Draft/Cheque No.";
                    cmbDraftOrCheckNo.Properties.ShowHeader = false;
                    cmbDraftOrCheckNo.Enabled = true;
                }
                else
                {
                    cmbDraftOrCheckNo.Properties.DataSource = null;
                    cmbDraftOrCheckNo.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
        
        private void CalculateTotalDueAmount()
        {
            try
            {
                if(bills!=null && bills.Count()>0)
                {
                    decimal? totalBillValue = Convert.ToDecimal(bills.Sum(b => b.BillAmount));
                    decimal? totalDraftValue = 0;

                    if(draftChequeList!=null && draftChequeList.Count()>0)
                    {
                        totalDraftValue = draftChequeList.Sum(d => d.Amount); 
                    }

                    txtAmountDue.Text = Convert.ToString(totalBillValue - totalDraftValue);
                }
                else
                {
                    txtAmountDue.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void ClearDependentData()
        {
            cmbDraftOrCheckNo.Properties.DataSource = null;
            cmbDraftOrCheckNo.Enabled = false;
            txtAmountDue.Text = string.Empty;
            gridBillDetails.DataSource = null;
            gridBillDetails.DataSource = new List<BillDetail>();
            txtDDChequeDate.Text = string.Empty;
            txtDrawnOn.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtReason.Text = string.Empty;
        }

        private void ClearData()
        {
            txtDraftReturnDate.Text = txtPrintLetter.Text = txtNoOfCopies.Text = string.Empty;
            cmbCustomer.EditValue = -1;
            cmbSupplier.EditValue = -1;
            cmbDraftOrCheque.SelectedIndex = cmbDocuments.SelectedIndex = cmbEnclosed.SelectedIndex = cmbType.SelectedIndex = 0;
            ClearDependentData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        private void cmbDraftOrCheckNo_EditValueChanged(object sender, EventArgs e)
        {
            try 
            {
                if(cmbDraftOrCheckNo.EditValue!=null && draftChequeList != null && !cmbDraftOrCheckNo.EditValue.ToString().Equals("Select Draft/Cheque No."))
                {
                    string selectedDraftCheque = cmbDraftOrCheckNo.EditValue.ToString();
                    DraftChequeDetail dc = draftChequeList.FirstOrDefault(d => d.DraftChequeNumber.Equals(selectedDraftCheque));
                    if(dc !=null)
                    {
                        txtDDChequeDate.Text = Convert.ToString(dc.DraftChequeDate);
                        txtDrawnOn.Text = dc.DrawnOn;
                        txtAmount.Text = Convert.ToString(dc.Amount);
                    }
                }
                else
                {
                    txtDDChequeDate.Text = string.Empty;
                    txtAmount.Text = string.Empty;
                    txtDrawnOn.Text = string.Empty;
                    txtReason.Text = string.Empty;                    
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtDraftReturnDate.Text))
                {
                    MessageBox.Show("Please enter draft return date.");
                    txtDraftReturnDate.Focus();
                    return;
                }
                if(cmbCustomer.EditValue==null || (int)cmbCustomer.EditValue==-1)
                {
                    MessageBox.Show("Please select Customer.");
                    cmbCustomer.Focus();
                    return;
                }
                if (cmbSupplier.EditValue == null || (int)cmbSupplier.EditValue == -1)
                {
                    MessageBox.Show("Please select Supplier.");
                    cmbSupplier.Focus();
                    return;
                }
                if (cmbDraftOrCheckNo.EditValue == null || cmbDraftOrCheckNo.EditValue.ToString() == "Select Draft/Cheque No.")
                {
                    MessageBox.Show("Please select DD/Cheque no.");
                    cmbDraftOrCheckNo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtReason.Text))
                {
                    MessageBox.Show("Please enter reason for return.");
                    txtReason.Focus();
                    return;
                }                

                ReturnDraftCheque returnDraft = new ReturnDraftCheque
                {
                    ReturnDate = Convert.ToDateTime(txtDDChequeDate.Text),
                    DraftOrCheque = cmbDraftOrCheque.SelectedText,
                    Documents = cmbDocuments.SelectedText,
                    Enclosed = cmbEnclosed.SelectedText,
                    fkCustomerId = (int)cmbCustomer.EditValue,
                    fkSupplierId = (int)cmbSupplier.EditValue,
                    Type = cmbType.SelectedText,
                    DDChequeNumber = cmbDraftOrCheckNo.EditValue.ToString(),
                    DDChequeDate = Convert.ToDateTime(txtDDChequeDate.Text),
                    DrawnOn = txtDrawnOn.Text,
                    Amount= Convert.ToDecimal(txtAmount.Text),
                    Reason=txtReason.Text,
                    PrintLetter=txtPrintLetter.Text,
                    NoOfCopies= Convert.ToInt32(txtNoOfCopies.Text),
                    CreatedDate = DateTime.Now,
                    CreatedBy = "admin",
                    IsDeleted=false
                };
                                
                List<ReturnDraftChequeBillDetail> billDetails = new List<ReturnDraftChequeBillDetail>();
                var collectionEntryDetails = db.CollectionEntries.FirstOrDefault(collEntry => collEntry.DDOrChequeNumber.Equals(cmbDraftOrCheckNo.EditValue.ToString())).CollectionEntryDetails;
                foreach (var bill in collectionEntryDetails)
                {
                    Ledger ledger = new Ledger
                    {
                        BillNo= bill.RefNumber,
                        Credit = 0,
                        Debit = Convert.ToDouble(txtAmount.Text),
                        DraftNo = cmbDraftOrCheckNo.EditValue.ToString(),
                        fkCustomerId = (int)cmbCustomer.EditValue,
                        fkSupplierId = (int)cmbSupplier.EditValue,
                        CreateDate = DateTime.Now,
                        CreatedBy = "admin",
                        Particulars = "By Return Draft A/C"
                    };

                    db.Ledgers.Add(ledger);

                    billDetails.Add(new ReturnDraftChequeBillDetail
                    {
                        BillNo = bill.RefNumber,
                        BillDate = bill.RefDate,
                        BillAmount = bill.RefAmount
                    });
                }

                returnDraft.ReturnDraftChequeBillDetails = billDetails;

                db.CollectionEntries.FirstOrDefault(coll => coll.DDOrChequeNumber.Equals(cmbDraftOrCheckNo.EditValue.ToString())).IsReturnedDraft = true;

                if (db.SaveChanges() > 0)
                    MessageBox.Show("Return draft/cheque successfull");
                else
                    MessageBox.Show("Error occurred while returning draft/cheque");

                ClearData();
            }
            catch(Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }

    public class DraftChequeDetail
    {
        public string DraftChequeNumber { get; set; }
        public DateTime? DraftChequeDate { get; set; }
        public string DrawnOn { get; set; }
        public decimal? Amount { get; set; }
        public string CancelReason { get; set; }
    }

    public class BillDetail
    {
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public double? BillAmount { get; set; }
        public bool? IsLocked { get; set; }
    }
}

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

namespace raghani_tradelinks
{
    public partial class FrmFinalBillEntry : Form
    {
        TPLDBEntities db = new TPLDBEntities();
        List<DealingType> lstKeys = new List<DealingType>();
        List<int> CollIds = new List<int>();
        public FrmFinalBillEntry()
        {
            InitializeComponent();
        }

        private void FrmFinalBillEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmFinalBillEntry_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                List<Supplier> supplierList = CommonMethods.GetSupplierData();
                supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
                cmbSupplier.DataSource = supplierList;
                cmbSupplier.ValueMember = "SupplierId";
                cmbSupplier.DisplayMember = "SupplierName";

                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/bill_type.json"));
                var _sourceList = JsonConvert.DeserializeObject<List<DealingType>>(result);
                cmbBillType.DataSource = _sourceList;
                cmbBillType.SelectedIndex = 0;

                dtpBillDate.Value = DateTime.Now;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/settings_keys.json"));
                lstKeys = JsonConvert.DeserializeObject<List<DealingType>>(result);
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
                FinalBill fb = new FinalBill();
                fb.Amout = Convert.ToDouble(txtAmt.Text);
                fb.BillDate = dtpBillDate.Value;
                fb.BillDetails = txtBillDetails.Text;
                fb.BillMemo = txtBillMemo.Text;
                fb.BillMemoNo = txtBillMemoNo.Text;
                fb.BillType = cmbBillType.SelectedValue.ToString();
                fb.CreatedBy = User.UserName;
                fb.CreatedDate = DateTime.Now.ToString();
                fb.CreditNoted = Convert.ToDouble(txtLessCreditNotes.Text);
                fb.ECAmt = Convert.ToDouble(txtECAmt.Text);
                fb.ECPer = Convert.ToDouble(txtECPer.Text);
                fb.EditedBy = User.UserName;
                fb.EditedDate = DateTime.Now.ToString();
                fb.fkSupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);
                fb.OtherAmt = Convert.ToDouble(txtOthersAmt.Text);
                fb.OtherPer = Convert.ToDouble(txtOthersPer.Text);
                fb.RaisedAmt = Convert.ToDouble(txtBillLess.Text);
                fb.SBAmt = Convert.ToDouble(txtSBPerAmt.Text);
                fb.SBPer = Convert.ToDouble(txtSBPer.Text);
                fb.STAmt = Convert.ToDouble(txtStaxAmt.Text);
                fb.STaxPer = Convert.ToDouble(txtSTaxPer.Text);
                fb.TotalAmt = Convert.ToDouble(txtTotalAmt.Text);

                if (grdData.RowCount > 0)
                {
                    foreach (DataGridViewRow row in grdData.Rows)
                    {
                        FinalBillDetail fbd = new FinalBillDetail();
                        //fbd.BillDate = row
                    }
                }

                List<CollectionEntry> lstColls = db.CollectionEntries.Where(q => CollIds.Contains(q.CollectionEntryId)).ToList();
                foreach (CollectionEntry etry in lstColls)
                {
                    etry.IsFinalBillGenerated = true;
                }

                db.FinalBills.Add(fb);
                db.SaveChanges();

                MessageBox.Show("Data saved successfully");
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                cmbSupplier.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedIndex != 0)
                {
                    DateTime frmDate;
                    DateTime toDate;
                    if (DateTime.Now.Month >= 4)
                    {
                        int year = DateTime.Now.Year;
                        frmDate = new DateTime(year, 4, 1);
                        toDate = new DateTime(year + 1, 3, 31);
                    }
                    else
                    {
                        int year = DateTime.Now.Year;
                        frmDate = new DateTime(year - 1, 4, 1);
                        toDate = new DateTime(year, 3, 31);
                    }

                    FinalBill generatedData = (from fb in db.FinalBills
                                               where System.Data.Entity.DbFunctions.TruncateTime(fb.BillDate) >= frmDate.Date && System.Data.Entity.DbFunctions.TruncateTime(fb.BillDate) <= toDate.Date
                                               && fb.fkSupplierId == (int)cmbSupplier.SelectedValue
                                               select fb).FirstOrDefault();

                    double raisedAmt = 0d;
                    decimal Amt = decimal.Zero;
                    decimal sTax = decimal.Zero;
                    decimal sbTax = decimal.Zero;
                    decimal ecTax = decimal.Zero;
                    decimal others = decimal.Zero;
                    decimal totalBill = decimal.Zero;
                    decimal creditNote = decimal.Zero;

                    if (generatedData != null)
                    {
                        List<FinalBillDetail> lstFBDetails = generatedData.FinalBillDetails.ToList();
                        grdData.DataSource = lstFBDetails;
                        raisedAmt = lstFBDetails.Sum(q => q.DraftAmt.Value);
                    }

                    var collData = (from col in db.CollectionEntries
                                    where col.fkSupplierId.Value == (int)cmbSupplier.SelectedValue && col.IsFinalBillGenerated == false &&
                                    System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) >= frmDate.Date && System.Data.Entity.DbFunctions.TruncateTime(col.EntryDate) <= toDate.Date
                                    select col).ToList();

                    CollIds = collData.Select(q => q.CollectionEntryId).ToList();

                    Amt = collData.Sum(q => q.DraftAmount.Value);

                    txtAmt.Text = Amt.ToString();
                    txtSTaxPer.Text = CommonMethods.GetSettingsValue(lstKeys[0].Name);
                    sTax = (Amt * (Convert.ToDecimal(txtSTaxPer.Text) / (decimal)100.00));
                    txtStaxAmt.Text = sTax.ToString();
                    txtECPer.Text = "0";
                    txtECAmt.Text = "0.00";
                    txtSBPer.Text = CommonMethods.GetSettingsValue(lstKeys[1].Name);
                    sbTax = (Amt * (Convert.ToDecimal(txtSBPer.Text) / (decimal)100.00));
                    txtSBPerAmt.Text = sbTax.ToString();
                    totalBill = Amt + sTax + sbTax + ecTax;
                    others = (Math.Ceiling(totalBill) - totalBill);
                    txtOthersPer.Text = "0";
                    txtOthersAmt.Text = others.ToString();
                    txtLessCreditNotes.Text = creditNote.ToString();

                    txtBillLess.Text = raisedAmt.ToString();
                    txtTotalAmt.Text = (totalBill - (decimal)raisedAmt).ToString();

                    var newId = db.Database.SqlQuery<int>("select dbo.GetTableNewId('FinalBill') as Ident").ToList();
                    txtBillMemoNo.Text = "RTPL/" + frmDate.Year.ToString() + "-" + toDate.Year.ToString() + "/" + newId[0].ToString();
                }
                else
                {
                    grdData.DataSource = null;
                    txtBillLess.Text = "";
                    txtTotalAmt.Text = "";
                    txtAmt.Text = "";
                    txtSTaxPer.Text = "";
                    txtStaxAmt.Text = "";
                    txtECPer.Text = "";
                    txtECAmt.Text = "";
                    txtSBPer.Text = "";
                    txtSBPerAmt.Text = "";
                    txtOthersAmt.Text = "";
                    txtLessCreditNotes.Text = "";
                }
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }
}

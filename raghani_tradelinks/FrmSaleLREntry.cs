using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.DL;
using System.IO;
using Newtonsoft.Json;

namespace raghani_tradelinks
{
    public partial class FrmSaleLREntry : Form
    {
        TPLDBEntities db = new TPLDBEntities();

        public FrmSaleLREntry()
        {
            InitializeComponent();
        }

        private void FrmSaleLREntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        void BindDropDownLists()
        {
            try
            {
                cmbCustomer.ValueMember = "CustomerId";
                cmbCustomer.DisplayMember = "CustomerName";
                var custData = (from c in db.Customers
                                select new
                                {
                                    CustomerId = c.CustomerId,
                                    CustomerName = c.CustomerName
                                }).ToList();
                custData.Insert(0, new { CustomerId = 0, CustomerName = "Select" });
                cmbCustomer.DataSource = custData;

                cmbSupplier.ValueMember = "SupplierId";
                cmbSupplier.DisplayMember = "SupplierName";
                var suppData = db.Suppliers
                                .Select(q => new { SupplierId = q.SupplierId, SupplierName = q.SupplierName }).ToList();
                suppData.Insert(0, new { SupplierId = 0, SupplierName = "Select" });
                cmbSupplier.DataSource = suppData;

                var transData = db.MstTransports.Select(q => new { TransId = q.TransportId, TransName = q.TransportName }).ToList();
                transData.Insert(0, new { TransId = 0, TransName = "Select" });
                cmbTransport.ValueMember = "TransId";
                cmbTransport.DisplayMember = "TransName";
                cmbTransport.DataSource = transData;

                string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/document_list.json"));
                var _docList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbDocuments.Properties.Items.AddRange(_docList);
                cmbDocuments.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/source_list.json"));
                var _sourceList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbSource.Properties.Items.AddRange(_sourceList);
                cmbSource.SelectedIndex = 0;

                result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonFiles/terms_list.json"));
                var _termList = JsonConvert.DeserializeObject<List<SupplierJsonParse>>(result);
                cmbTerm.Properties.Items.AddRange(_termList);
                cmbTerm.SelectedIndex = 0;

                dtpBillDate.Value = DateTime.Now;
                dtpEntryDate.Value = DateTime.Now;
                dtpLRDate.Value = DateTime.Now;
                dtpLRRecdDate.Value = DateTime.Now;
                cmbLocked.SelectedIndex = 0;
                txtCreditLimitAmt.Enabled = false;

                var last = db.SaleLREntries.OrderByDescending(q => q.SaleId).FirstOrDefault();
                if (last != null)
                {
                    txtBillNo.Text = (last.SaleId + 1).ToString() + "/" + DateTime.Now.ToString("yy") + "-" + DateTime.Now.AddYears(1).ToString("yy");
                }
                else
                {
                    txtBillNo.Text = 1.ToString() + "/" + DateTime.Now.ToString("yy") + "-" + DateTime.Now.AddYears(1).ToString("yy");
                }
                txtBillNo.Enabled = false;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkDirectSalte.Checked == false)
            {
                if (validator1.Validate())
                {
                    if ((int)cmbSupplier.SelectedValue > 0)
                    {
                        if ((int)cmbCustomer.SelectedValue > 0)
                        {
                            if ((int)cmbTransport.SelectedValue > 0)
                            {
                                SaveLREntry();
                                ClearControls();
                            }
                            else
                                MessageBox.Show("Select value in Transport.");
                        }
                        else
                            MessageBox.Show("Select value in Customer.");
                    }
                    else
                        MessageBox.Show("Select value in Supplier.");
                }
            }
            else
            {
                SaveLREntry();
            }
        }

        void SaveLREntry()
        {
            try
            {
                SaleLREntry sale = new SaleLREntry();
                sale.BillAmount = Convert.ToDouble(txtBillAmt.Text);
                sale.BillDate = dtpBillDate.Value;
                sale.BillNumber = txtBillNo.Text;
                if (chkDirectSalte.Checked == false)
                    sale.BookingUp = txtBookingUp.Text;
                sale.CreatedBy = User.UserName;
                sale.CreatedDate = DateTime.Now;
                sale.Documents = cmbDocuments.EditValue.ToString();
                sale.DueDays = Convert.ToInt32(txtDueDate.Text);
                sale.fkCustomerId = (int)cmbCustomer.SelectedValue;
                sale.fkSupplierId = (int)cmbSupplier.SelectedValue;
                sale.IsCreditLimitSet = txtCreditLimit.Text.ToLower() == "y" ? true : false;
                sale.IsDeleted = false;
                sale.IsDirectSale = chkDirectSalte.Checked;
                sale.IsLocked = cmbLocked.SelectedItem.ToString() == "Yes" ? true : false;
                if (chkDirectSalte.Checked == false)
                    sale.LRDate = dtpLRDate.Value;
                if (chkDirectSalte.Checked == false)
                    sale.LRNumber = txtLRNo.Text;
                sale.LRReceiveDate = dtpLRRecdDate.Value;
                sale.Narration = txtNarration.Text;
                if (chkDirectSalte.Checked == false)
                    sale.NoOfBales = Convert.ToInt32(txtNoOfBales.Text);
                sale.Quantity = Convert.ToInt32(txtQty.Text);
                sale.Source = cmbSource.EditValue.ToString();
                sale.SpecialDiscount = Convert.ToDouble(txtDiscPer.Text);
                sale.SpecialDiscountDays = Convert.ToInt32(txtDays.Text);
                sale.Transport = Convert.ToInt32(cmbTransport.SelectedValue);
                if (chkDirectSalte.Checked == false)
                    sale.Terms = cmbTerm.EditValue.ToString();
                if (chkDirectSalte.Checked == false)
                    sale.VideNumber = txtVideNo.Text;
                db.SaleLREntries.Add(sale);

                int oDetailsId = (int)grdOrderList.Rows[rowIndex].Cells[1].Value;
                OrderTransaction ot = db.OrderTransactions.FirstOrDefault(q => q.fkOrderDetailId.Value == oDetailsId);
                ot.DispatchQty = ot.DispatchQty.HasValue ? (ot.DispatchQty.Value + Convert.ToInt32(txtQty.Text)) : Convert.ToInt32(txtQty.Text);
                ot.UpdatedBy = User.UserName;
                ot.UpdatedDate = DateTime.Now;

                Ledger ledger = new Ledger();
                ledger.CreatedBy = User.UserName;
                ledger.CreateDate = DateTime.Now;
                ledger.Credit = 0.00;
                ledger.Debit = Convert.ToDouble(txtBillAmt.Text);
                ledger.fkCustomerId = (int)cmbCustomer.SelectedValue;
                ledger.fkSupplierId = (int)cmbSupplier.SelectedValue;
                ledger.UpdatedBy = User.UserName;
                ledger.UpdatedDate = DateTime.Now;
                ledger.BillNo = txtBillNo.Text;
                ledger.Particulars = "To Sales A/c";
                db.Ledgers.Add(ledger);

                db.SaveChanges();

            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        void ClearControls()
        {
            txtBillAmt.Text = "";
            txtBillNo.Text = "";
            txtBookingUp.Text = "";
            txtCreditLimit.Text = "";
            txtCreditLimitAmt.Text = "";
            txtDays.Text = "0";
            txtDiscPer.Text = "0";
            txtDueDate.Text = "90";
            txtLRNo.Text = "";
            txtNarration.Text = "";
            txtNoOfBales.Text = "";
            txtQty.Text = "";
            txtVideNo.Text = "0";

            BindDropDownLists();
            grdOrderList.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void FrmSaleLREntry_Load(object sender, EventArgs e)
        {
            BindDropDownLists();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSupplier.SelectedValue.ToString() != "0" && chkDirectSalte.Checked == false)
                {
                    var data = (from oe in db.OrderEntries
                                join od in db.OrderDetails on oe.OrderId equals od.fkOrderId
                                join sup in db.Suppliers on od.fkSupplierId equals sup.SupplierId
                                join cust in db.Customers on oe.fkCustomerId equals cust.CustomerId
                                join ci in db.CustomerInfoes on cust.CustomerId equals ci.fkCustomerId
                                where sup.SupplierId == (int)cmbSupplier.SelectedValue
                                select new
                                {
                                    CustomerId = cust.CustomerId,
                                    OrderId = od.OrderDetailId,
                                    CustomerName = cust.CustomerName,
                                    OrderQty = od.OrQty,
                                    OrderDate = oe.OrderDate,
                                    CreditLimit = ci.CreditLimit,
                                }).ToList();
                    grdOrderList.DataSource = data;
                    grdOrderList.Columns[0].Visible = false;
                    //grdOrderList.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        int rowIndex = 0;
        private void grdOrderList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                rowIndex = e.RowIndex;
                int ID = grdOrderList.Rows[e.RowIndex].Cells[0].Value != null ? Convert.ToInt32(grdOrderList.Rows[e.RowIndex].Cells[0].Value.ToString()) : -1;
                cmbCustomer.SelectedValue = ID;
                txtQty.Text = grdOrderList.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCreditLimitAmt.Text = grdOrderList.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}

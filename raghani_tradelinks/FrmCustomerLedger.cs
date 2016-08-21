using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.DL;
using DevExpress.XtraEditors.Controls;
using System.Data.Entity.Core.Objects;

namespace raghani_tradelinks
{
    public partial class FrmCustomerLedger : Form
    {
        TPLDBEntities db = new TPLDBEntities();

        public FrmCustomerLedger()
        {
            InitializeComponent();
        }

        private void FrmCustomerLedger_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmCustomerLedger_Load(object sender, EventArgs e)
        {
            try
            {
                BindDropDownLists();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        void BindDropDownLists()
        {
            List<Supplier> supplierList = CommonMethods.GetSupplierData();
            supplierList.Insert(0, new Supplier { SupplierId = -1, SupplierName = "Select Supplier" });
            cmbSupplier.DataSource = supplierList;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierId";

            List<Customer> customerList = CommonMethods.GetCustomerata();
            customerList.Insert(0, new Customer { CustomerId = -1, CustomerName = "Select Customer" });
            cmbCustomer.DataSource = customerList;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerId";

            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedValue.ToString() != "-1")
                {
                    if (cmbSupplier.SelectedValue.ToString() != "-1")
                    {
                        BindGridView(false);
                    }
                    else
                        MessageBox.Show("Select proper value in supplier.");
                }
                else
                    MessageBox.Show("Select proper value in cusotmer.");
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }

        void BindGridView(bool odrAdj)
        {
            var ledgerData = (from l in db.Ledgers
                              join sale in db.SaleLREntries on l.BillNo equals sale.BillNumber
                              join gr in db.GRNDebitNotes on sale.BillNumber equals gr.RefNumber
                              join disc in db.DiscountEntries on sale.BillNumber equals disc.RefNumber
                              where sale.IsOrderAdjusted == odrAdj && (System.Data.Entity.DbFunctions.TruncateTime(l.ParticularDate.Value) >= dtpFrom.Value.Date && System.Data.Entity.DbFunctions.TruncateTime(l.ParticularDate.Value) <= dtpTo.Value.Date)
                              select new
                              {
                                  LedgerId = l.LedgerId,
                                  Date = l.ParticularDate,
                                  Particulars = l.Particulars,
                                  Debit = l.Debit,
                                  Credit = l.Credit,
                                  DraftNo = l.DraftNo,
                              }).ToList();
            grdDetails.DataSource = ledgerData.ToList();
            grdDetails.Columns[0].Visible = false;

            double DebitTotal = ledgerData.Sum(q => q.Debit.Value);
            txtDebit.Text = DebitTotal.ToString();
            double CreditTotal = ledgerData.Sum(q => q.Credit.Value);
            txtCredit.Text = CreditTotal.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.SelectedValue.ToString() != "-1")
                {
                    if (cmbSupplier.SelectedValue.ToString() != "-1")
                    {
                        BindGridView(true);
                    }
                    else
                        MessageBox.Show("Select proper value in supplier.");
                }
                else
                    MessageBox.Show("Select proper value in cusotmer.");
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }
}

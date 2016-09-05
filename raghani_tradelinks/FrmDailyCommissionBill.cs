using RT.DL;
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
    public partial class FrmDailyCommissionBill : Form
    {
        public FrmDailyCommissionBill()
        {
            InitializeComponent();
        }

        private void FrmDailyCommissionBill_Load(object sender, EventArgs e)
        {
            try
            {
                grdData.DataSource = GetOrderDataSource();
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
        DataTable GetOrderDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Select", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("SMS Cell", typeof(string));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("City", typeof(string));
            dt.Columns.Add("Chq. No.", typeof(string));
            dt.Columns.Add("Chq. Dt.", typeof(string));
            dt.Columns.Add("Chq. Amt.", typeof(string));
            dt.Columns.Add("%", typeof(string));
            dt.Columns.Add("Com. Accrued", typeof(string));
            dt.Columns.Add("Bill Rais", typeof(string));
            return dt;
        }

        private void FrmDailyCommissionBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                TPLDBEntities db = new TPLDBEntities();
                var data = (from lr in db.SaleLREntries
                            join colDtl in db.CollectionEntryDetails on lr.BillNumber equals colDtl.RefNumber
                            join com in db.CollectionEntries on colDtl.fkCollectionEntryId equals com.CollectionEntryId
                            join sp in db.Suppliers on lr.fkSupplierId equals sp.SupplierId
                            join spInfo in db.SupplierContactInfoes on sp.SupplierId equals spInfo.fkSupplierId
                            join cust in db.Customers on lr.fkCustomerId equals cust.CustomerId
                            //where lr.IsOrderAdjusted == true
                            select new
                            {
                                Date = lr.BillDate,
                                Supplier = sp.SupplierName,
                                SMSCell = spInfo.SMSCellNumber,
                                Customer = cust.CustomerName,
                                City = spInfo.City,
                                ChqNo = com.DDOrChequeNumber,
                                ChqDt = com.DDOrChequeDate,
                                ChqAmt = com.DraftAmount,
                                Per = sp.Commission,
                                ComAccured = (com.DraftAmount * sp.Commission) / 100,
                                BillRaised = false,
                            }).ToList();

                grdData.DataSource = data;
            }
            catch (Exception ex)
            {
                CommonMethods.HandleException(ex);
            }
        }
    }
}

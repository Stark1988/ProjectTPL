using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace raghani_tradelinks
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            try
            {
                InitializeComponent();
                InitSkinGallery();
                InitDateTime();
                //InitGrid();
            }
            catch (Exception ex) { HandleException(ex); }
        }
        void InitSkinGallery()
        {
            try
            {
                SkinHelper.InitSkinGallery(rgbiSkins, true);
            }
            catch (Exception ex) { HandleException(ex); }
        }
        void InitDateTime()
        {
            try
            {
                lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                Timer t = new Timer();
                t.Interval = 1000;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
            catch (Exception ex) { HandleException(ex); }
        }
        void t_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
            catch (Exception ex) { HandleException(ex); }
        }
        //BindingList<Person> gridDataList = new BindingList<Person>();
        //void InitGrid()
        //{
        //    gridDataList.Add(new Person("John", "Smith"));
        //    gridDataList.Add(new Person("Gabriel", "Smith"));
        //    gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
        //    gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
        //    gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
        //    //gridControl.DataSource = gridDataList;
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void BringContainerFront()
        {
            try
            {
                ParentFormSplitContainer.BringToFront();
            }
            catch (Exception ex) { HandleException(ex); }
        }
        private void iNewCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewCustomer"))
                {
                    FrmNewCustomer _frmNewCustomer = new FrmNewCustomer();
                    _frmNewCustomer.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNewCustomer.Show();
                }
            }
            catch (Exception ex) { HandleException(ex); }
        }

        private void footerNavigationBar_QueryPeekFormContent(object sender, DevExpress.XtraBars.Navigation.QueryPeekFormContentEventArgs e)
        {

        }

        private bool IsOpen(string formName)
        {

            bool IsOpen = false;
            try
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == formName)
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }
            }
            catch (Exception ex) { HandleException(ex); }
            return IsOpen;
        }

        private void iCity_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewCity"))
                {
                    FrmNewCity _frmNewCity = new FrmNewCity();
                    _frmNewCity.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNewCity.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        private void iNewSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void iNewOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewCity"))
                {
                    FrmNewOrder _frmNewOrder = new FrmNewOrder();
                    _frmNewOrder.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNewOrder.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iNullifyOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNullifyOrder"))
                {
                    FrmNullifyOrder _frmNullifyOrder = new FrmNullifyOrder();
                    _frmNullifyOrder.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNullifyOrder.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iNullReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNullifyOrdersReport"))
                {
                    FrmNullifyOrdersReport _frmNullifyOrdersReport = new FrmNullifyOrdersReport();
                    _frmNullifyOrdersReport.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNullifyOrdersReport.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iSaleLREntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmSaleLREntry"))
                {
                    FrmSaleLREntry _frmSaleLREntry = new FrmSaleLREntry();
                    _frmSaleLREntry.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmSaleLREntry.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCollectionEntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmSaleLREntry"))
                {
                    FrmCollectionEntry _frmCollectionEntry = new FrmCollectionEntry();
                    _frmCollectionEntry.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmCollectionEntry.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCommissionReceived_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmCommissionReceived"))
                {
                    FrmCommissionReceived _frmCommissionReceived = new FrmCommissionReceived();
                    _frmCommissionReceived.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmCommissionReceived.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iGREntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmGREntry"))
                {
                    FrmGREntry _frmGREntry = new FrmGREntry();
                    _frmGREntry.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmGREntry.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iDailyCommissionBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmDailyCommissionBill"))
                {
                    FrmDailyCommissionBill _frmDailyCommissionBill = new FrmDailyCommissionBill();
                    _frmDailyCommissionBill.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmDailyCommissionBill.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iFinalBillEntry_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmFinalBillEntry"))
                {
                    FrmFinalBillEntry _frmFinalBillEntry = new FrmFinalBillEntry();
                    _frmFinalBillEntry.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFinalBillEntry.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iFinalBillReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmFinalBillReport"))
                {
                    FrmFinalBillReport _frmFinalBillReport = new FrmFinalBillReport();
                    _frmFinalBillReport.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFinalBillReport.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iSaleStatements_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmSaleStatements"))
                {
                    FrmSaleStatements _frmSaleStatements = new FrmSaleStatements();
                    _frmSaleStatements.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmSaleStatements.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCollectionStatements_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmCollectionStatements"))
                {
                    FrmCollectionStatements _frmCollectionStatements = new FrmCollectionStatements();
                    _frmCollectionStatements.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmCollectionStatements.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCustomerOutstanding_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmCustomerOutstanding"))
                {
                    FrmCustomerOutstanding _frmCustomerOutstanding = new FrmCustomerOutstanding();
                    _frmCustomerOutstanding.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmCustomerOutstanding.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iSupplierOutstanding_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmSupplierOutstanding"))
                {
                    FrmSupplierOutstanding _frmSupplierOutstanding = new FrmSupplierOutstanding();
                    _frmSupplierOutstanding.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmSupplierOutstanding.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCommissionOutstanding_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmCommissionOutstanding"))
                {
                    FrmCommissionOutstanding _frmCommissionOutstanding = new FrmCommissionOutstanding();
                    _frmCommissionOutstanding.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmCommissionOutstanding.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iCustomerLedger_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void iState_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewState"))
                {
                    FrmNewState _frmNewState = new FrmNewState();
                    _frmNewState.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmNewState.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CreateUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmCreateUser"))
                {
                    FrmCreateUser _frmFrmCreateUser = new FrmCreateUser();
                    _frmFrmCreateUser.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFrmCreateUser.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        
        private void MngUserType_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmUserTypeMgt"))
                {
                    FrmUserTypeMgt _frmFrmUserTypeMgt = new FrmUserTypeMgt();
                    _frmFrmUserTypeMgt.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFrmUserTypeMgt.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iNewBank_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewBank"))
                {
                    FrmNewBank _frmFrmNewBank = new FrmNewBank();
                    _frmFrmNewBank.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFrmNewBank.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void iNewCourier_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!IsOpen("FrmNewCourier"))
                {
                    FrmNewCourier _frmFrmNewCourier = new FrmNewCourier();
                    _frmFrmNewCourier.MdiParent = this;
                    ParentFormSplitContainer.SendToBack();
                    _frmFrmNewCourier.Show();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
    }
}
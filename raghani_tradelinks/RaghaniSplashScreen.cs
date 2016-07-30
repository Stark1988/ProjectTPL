using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace raghani_tradelinks
{
    public partial class RaghaniSplashScreen : SplashScreen
    {
        public RaghaniSplashScreen()
        {
            InitializeComponent();
            InitCopyright();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
        private void InitCopyright()
        {
            if(DateTime.Now.Year != 2016) {
                lblCopyright.Text = "Copyright &copy; 2016-" + DateTime.Now.Year;
            }

        }
        private void RaghaniSplashScreen_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(25);
            }

            MainForm _parentForm = new MainForm();
            _parentForm.Show();
            this.Hide();
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.BL;

namespace raghani_tradelinks
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dxValidationUsername.Validate())
            {
                LoginMgmt login = new LoginMgmt();
                UserData userData = login.FetchUserData(txtUsername.Text, txtPassword.Text);
                if (userData != null)
                {
                    User.UserId = userData.UserId;
                    User.UserName = userData.UserName;
                    User.UserType = userData.UserType;

                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                }
                else
                    MessageBox.Show("Username or Password is incorrect.");
            }

        }
    }
}

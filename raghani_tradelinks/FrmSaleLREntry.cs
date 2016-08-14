﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RT.DL;

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
            txtVideNo.Visible = false;
            validator1.Validate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void FrmSaleLREntry_Load(object sender, EventArgs e)
        {
            BindDropDownLists();
        }
    }
}

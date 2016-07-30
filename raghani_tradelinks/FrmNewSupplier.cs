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
    public partial class FrmNewSupplier : Form
    {
        public FrmNewSupplier()
        {
            InitializeComponent();
        }

        private void FrmNewSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm _parentForm = this.ParentForm as MainForm;
            _parentForm.BringContainerFront();
        }

        private void FrmNewSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}

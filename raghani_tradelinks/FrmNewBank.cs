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
    public partial class FrmNewBank : Form
    {
        public FrmNewBank()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}

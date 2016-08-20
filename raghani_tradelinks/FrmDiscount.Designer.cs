namespace raghani_tradelinks
{
    partial class FrmDiscount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdEntry = new System.Windows.Forms.DataGridView();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbLocked = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscAmt = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscNo = new System.Windows.Forms.TextBox();
            this.cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPriority = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblCustomerACNo = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.MainPageScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.MainPageScrollableControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEntry
            // 
            this.grdEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntry.Location = new System.Drawing.Point(137, 136);
            this.grdEntry.Name = "grdEntry";
            this.grdEntry.Size = new System.Drawing.Size(682, 364);
            this.grdEntry.TabIndex = 349;
            this.grdEntry.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntry_CellEndEdit);
            this.grdEntry.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdEntry_CellValidating);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbCustomer.Location = new System.Drawing.Point(233, 80);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(323, 21);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(423, 51);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(133, 20);
            this.dtpEntryDate.TabIndex = 347;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(203, 51);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 20);
            this.dtpDate.TabIndex = 346;
            // 
            // cmbLocked
            // 
            this.cmbLocked.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocked.FormattingEnabled = true;
            this.cmbLocked.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbLocked.Location = new System.Drawing.Point(137, 9);
            this.cmbLocked.Name = "cmbLocked";
            this.cmbLocked.Size = new System.Drawing.Size(61, 21);
            this.cmbLocked.TabIndex = 1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbSupplier.Location = new System.Drawing.Point(233, 109);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(323, 21);
            this.cmbSupplier.TabIndex = 348;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(189, 506);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(630, 20);
            this.txtRemarks.TabIndex = 345;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Location = new System.Drawing.Point(137, 509);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(46, 13);
            this.labelControl17.TabIndex = 344;
            this.labelControl17.Text = "Remark";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(607, 112);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 343;
            this.labelControl6.Text = "DiscAmt";
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.Location = new System.Drawing.Point(676, 109);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.Size = new System.Drawing.Size(141, 20);
            this.txtDiscAmt.TabIndex = 342;
            this.txtDiscAmt.Text = "0.00";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(607, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 341;
            this.labelControl4.Text = "Disc Doc No.";
            // 
            // txtDiscNo
            // 
            this.txtDiscNo.Location = new System.Drawing.Point(676, 81);
            this.txtDiscNo.Name = "txtDiscNo";
            this.txtDiscNo.Size = new System.Drawing.Size(141, 20);
            this.txtDiscNo.TabIndex = 340;
            // 
            // cmbPriority
            // 
            this.cmbPriority.Location = new System.Drawing.Point(676, 51);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriority.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPriority.Size = new System.Drawing.Size(142, 20);
            this.cmbPriority.TabIndex = 339;
            // 
            // lblPriority
            // 
            this.lblPriority.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPriority.Location = new System.Drawing.Point(607, 54);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(39, 13);
            this.lblPriority.TabIndex = 338;
            this.lblPriority.Text = "Source";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(348, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 337;
            this.labelControl1.Text = "Entry Date";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(137, 54);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(53, 13);
            this.lblPhoneOffice.TabIndex = 330;
            this.lblPhoneOffice.Text = "Disc Date";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(137, 112);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 329;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(137, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 333;
            this.labelControl5.Text = "Customer Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbLocked);
            this.panelControl1.Controls.Add(this.lblCustomerACNo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1162, 39);
            this.panelControl1.TabIndex = 330;
            // 
            // lblCustomerACNo
            // 
            this.lblCustomerACNo.Location = new System.Drawing.Point(66, 12);
            this.lblCustomerACNo.Name = "lblCustomerACNo";
            this.lblCustomerACNo.Size = new System.Drawing.Size(61, 13);
            this.lblCustomerACNo.TabIndex = 0;
            this.lblCustomerACNo.Text = "Locked (Y/N)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(123, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 544);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1162, 39);
            this.panelControl3.TabIndex = 331;
            // 
            // MainPageScrollableControl
            // 
            this.MainPageScrollableControl.AutoScrollMinSize = new System.Drawing.Size(0, 400);
            this.MainPageScrollableControl.Controls.Add(this.grdEntry);
            this.MainPageScrollableControl.Controls.Add(this.cmbSupplier);
            this.MainPageScrollableControl.Controls.Add(this.cmbCustomer);
            this.MainPageScrollableControl.Controls.Add(this.dtpEntryDate);
            this.MainPageScrollableControl.Controls.Add(this.dtpDate);
            this.MainPageScrollableControl.Controls.Add(this.txtRemarks);
            this.MainPageScrollableControl.Controls.Add(this.labelControl17);
            this.MainPageScrollableControl.Controls.Add(this.labelControl6);
            this.MainPageScrollableControl.Controls.Add(this.txtDiscAmt);
            this.MainPageScrollableControl.Controls.Add(this.labelControl4);
            this.MainPageScrollableControl.Controls.Add(this.txtDiscNo);
            this.MainPageScrollableControl.Controls.Add(this.cmbPriority);
            this.MainPageScrollableControl.Controls.Add(this.lblPriority);
            this.MainPageScrollableControl.Controls.Add(this.labelControl1);
            this.MainPageScrollableControl.Controls.Add(this.lblPhoneOffice);
            this.MainPageScrollableControl.Controls.Add(this.lblCashCredit);
            this.MainPageScrollableControl.Controls.Add(this.labelControl5);
            this.MainPageScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageScrollableControl.Location = new System.Drawing.Point(0, 0);
            this.MainPageScrollableControl.Name = "MainPageScrollableControl";
            this.MainPageScrollableControl.Size = new System.Drawing.Size(1162, 583);
            this.MainPageScrollableControl.TabIndex = 332;
            // 
            // FrmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 583);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.MainPageScrollableControl);
            this.Name = "FrmDiscount";
            this.Text = "FrmDiscount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDiscount_FormClosing);
            this.Load += new System.EventHandler(this.FrmDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.MainPageScrollableControl.ResumeLayout(false);
            this.MainPageScrollableControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEntry;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbLocked;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtRemarks;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtDiscAmt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtDiscNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
        private DevExpress.XtraEditors.LabelControl lblPriority;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblCustomerACNo;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.XtraScrollableControl MainPageScrollableControl;
    }
}
namespace raghani_tradelinks
{
    partial class FrmSuppDiscount
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.MainPageScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.grdEntry = new System.Windows.Forms.DataGridView();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscAmt = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.MainPageScrollableControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1082, 39);
            this.panelControl1.TabIndex = 331;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 680);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1082, 39);
            this.panelControl3.TabIndex = 332;
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
            // MainPageScrollableControl
            // 
            this.MainPageScrollableControl.AutoScrollMinSize = new System.Drawing.Size(0, 400);
            this.MainPageScrollableControl.Controls.Add(this.grdEntry);
            this.MainPageScrollableControl.Controls.Add(this.cmbSupplier);
            this.MainPageScrollableControl.Controls.Add(this.dtpEntryDate);
            this.MainPageScrollableControl.Controls.Add(this.dtpDate);
            this.MainPageScrollableControl.Controls.Add(this.txtRemarks);
            this.MainPageScrollableControl.Controls.Add(this.labelControl17);
            this.MainPageScrollableControl.Controls.Add(this.labelControl6);
            this.MainPageScrollableControl.Controls.Add(this.txtDiscAmt);
            this.MainPageScrollableControl.Controls.Add(this.labelControl1);
            this.MainPageScrollableControl.Controls.Add(this.lblPhoneOffice);
            this.MainPageScrollableControl.Controls.Add(this.lblCashCredit);
            this.MainPageScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageScrollableControl.Location = new System.Drawing.Point(0, 39);
            this.MainPageScrollableControl.Name = "MainPageScrollableControl";
            this.MainPageScrollableControl.Size = new System.Drawing.Size(1082, 641);
            this.MainPageScrollableControl.TabIndex = 333;
            // 
            // grdEntry
            // 
            this.grdEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntry.Location = new System.Drawing.Point(66, 78);
            this.grdEntry.Name = "grdEntry";
            this.grdEntry.Size = new System.Drawing.Size(682, 364);
            this.grdEntry.TabIndex = 349;
            this.grdEntry.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntry_CellEndEdit);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbSupplier.Location = new System.Drawing.Point(162, 51);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(323, 21);
            this.cmbSupplier.TabIndex = 348;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(352, 19);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(133, 20);
            this.dtpEntryDate.TabIndex = 347;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(132, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 20);
            this.dtpDate.TabIndex = 346;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(118, 448);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(630, 20);
            this.txtRemarks.TabIndex = 345;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Location = new System.Drawing.Point(66, 451);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(46, 13);
            this.labelControl17.TabIndex = 344;
            this.labelControl17.Text = "Remark";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(536, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 343;
            this.labelControl6.Text = "DiscAmt";
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.Location = new System.Drawing.Point(605, 51);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.Size = new System.Drawing.Size(141, 20);
            this.txtDiscAmt.TabIndex = 342;
            this.txtDiscAmt.Text = "0.00";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(277, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 337;
            this.labelControl1.Text = "Entry Date";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(66, 22);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(53, 13);
            this.lblPhoneOffice.TabIndex = 330;
            this.lblPhoneOffice.Text = "Disc Date";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(66, 54);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 329;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // FrmSuppDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 719);
            this.Controls.Add(this.MainPageScrollableControl);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSuppDiscount";
            this.Text = "FrmSuppDiscount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSuppDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.MainPageScrollableControl.ResumeLayout(false);
            this.MainPageScrollableControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.XtraScrollableControl MainPageScrollableControl;
        private System.Windows.Forms.DataGridView grdEntry;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtDiscAmt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
    }
}
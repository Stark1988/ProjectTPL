namespace raghani_tradelinks
{
    partial class FrmSuppCollectionEntry
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
            this.MainPageScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.txtDrawnOn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grdEntry = new System.Windows.Forms.DataGridView();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRecptDate = new System.Windows.Forms.DateTimePicker();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDraftAmt = new System.Windows.Forms.TextBox();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblProprietor1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.MainPageScrollableControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPageScrollableControl
            // 
            this.MainPageScrollableControl.AutoScrollMinSize = new System.Drawing.Size(0, 600);
            this.MainPageScrollableControl.Controls.Add(this.txtDrawnOn);
            this.MainPageScrollableControl.Controls.Add(this.comboBox1);
            this.MainPageScrollableControl.Controls.Add(this.grdEntry);
            this.MainPageScrollableControl.Controls.Add(this.dtpEntryDate);
            this.MainPageScrollableControl.Controls.Add(this.dtpRecptDate);
            this.MainPageScrollableControl.Controls.Add(this.dtpChequeDate);
            this.MainPageScrollableControl.Controls.Add(this.cmbSupplier);
            this.MainPageScrollableControl.Controls.Add(this.txtRemarks);
            this.MainPageScrollableControl.Controls.Add(this.labelControl1);
            this.MainPageScrollableControl.Controls.Add(this.labelControl6);
            this.MainPageScrollableControl.Controls.Add(this.txtDraftAmt);
            this.MainPageScrollableControl.Controls.Add(this.labelControl21);
            this.MainPageScrollableControl.Controls.Add(this.labelControl20);
            this.MainPageScrollableControl.Controls.Add(this.labelControl19);
            this.MainPageScrollableControl.Controls.Add(this.labelControl17);
            this.MainPageScrollableControl.Controls.Add(this.lblPhoneOffice);
            this.MainPageScrollableControl.Controls.Add(this.lblCashCredit);
            this.MainPageScrollableControl.Controls.Add(this.txtChequeNo);
            this.MainPageScrollableControl.Controls.Add(this.lblProprietor1);
            this.MainPageScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageScrollableControl.Location = new System.Drawing.Point(0, 0);
            this.MainPageScrollableControl.Name = "MainPageScrollableControl";
            this.MainPageScrollableControl.Size = new System.Drawing.Size(1089, 698);
            this.MainPageScrollableControl.TabIndex = 15;
            // 
            // txtDrawnOn
            // 
            this.txtDrawnOn.Location = new System.Drawing.Point(174, 154);
            this.txtDrawnOn.Name = "txtDrawnOn";
            this.txtDrawnOn.Size = new System.Drawing.Size(256, 20);
            this.txtDrawnOn.TabIndex = 346;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Draft",
            "Cheque"});
            this.comboBox1.Location = new System.Drawing.Point(252, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 21);
            this.comboBox1.TabIndex = 332;
            // 
            // grdEntry
            // 
            this.grdEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntry.Location = new System.Drawing.Point(93, 180);
            this.grdEntry.Name = "grdEntry";
            this.grdEntry.Size = new System.Drawing.Size(682, 213);
            this.grdEntry.TabIndex = 331;
            this.grdEntry.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntry_CellEndEdit);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(401, 66);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(142, 20);
            this.dtpEntryDate.TabIndex = 330;
            // 
            // dtpRecptDate
            // 
            this.dtpRecptDate.Location = new System.Drawing.Point(187, 66);
            this.dtpRecptDate.Name = "dtpRecptDate";
            this.dtpRecptDate.Size = new System.Drawing.Size(142, 20);
            this.dtpRecptDate.TabIndex = 329;
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.Location = new System.Drawing.Point(633, 122);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(142, 20);
            this.dtpChequeDate.TabIndex = 328;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Location = new System.Drawing.Point(187, 93);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Size = new System.Drawing.Size(325, 20);
            this.cmbSupplier.TabIndex = 323;
            this.cmbSupplier.EditValueChanged += new System.EventHandler(this.cmbSupplier_EditValueChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(145, 399);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(630, 20);
            this.txtRemarks.TabIndex = 311;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(547, 157);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 309;
            this.labelControl1.Text = "Collection Amt";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(93, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 307;
            this.labelControl6.Text = "Drawn On";
            // 
            // txtDraftAmt
            // 
            this.txtDraftAmt.Location = new System.Drawing.Point(633, 152);
            this.txtDraftAmt.Name = "txtDraftAmt";
            this.txtDraftAmt.Size = new System.Drawing.Size(141, 20);
            this.txtDraftAmt.TabIndex = 306;
            this.txtDraftAmt.Text = "0.00";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl21.Location = new System.Drawing.Point(547, 125);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(79, 13);
            this.labelControl21.TabIndex = 304;
            this.labelControl21.Text = "DD / Chq Date";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl20.Location = new System.Drawing.Point(323, 125);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(69, 13);
            this.labelControl20.TabIndex = 303;
            this.labelControl20.Text = "DD / Chq No.";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl19.Location = new System.Drawing.Point(335, 68);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(60, 13);
            this.labelControl19.TabIndex = 298;
            this.labelControl19.Text = "Entry Date";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Location = new System.Drawing.Point(93, 402);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(46, 13);
            this.labelControl17.TabIndex = 294;
            this.labelControl17.Text = "Remark";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(93, 68);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(85, 13);
            this.lblPhoneOffice.TabIndex = 200;
            this.lblPhoneOffice.Text = "Collection Date";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(93, 96);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 188;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(398, 122);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(114, 20);
            this.txtChequeNo.TabIndex = 192;
            // 
            // lblProprietor1
            // 
            this.lblProprietor1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProprietor1.Location = new System.Drawing.Point(93, 125);
            this.lblProprietor1.Name = "lblProprietor1";
            this.lblProprietor1.Size = new System.Drawing.Size(153, 13);
            this.lblProprietor1.TabIndex = 191;
            this.lblProprietor1.Text = "[D]raft / [C]ash / Che[Q]ue";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1089, 39);
            this.panelControl1.TabIndex = 16;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 659);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1089, 39);
            this.panelControl3.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSuppCollectionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 698);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.MainPageScrollableControl);
            this.Name = "FrmSuppCollectionEntry";
            this.Text = "FrmSuppCollectionEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSuppCollectionEntry_Load);
            this.MainPageScrollableControl.ResumeLayout(false);
            this.MainPageScrollableControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl MainPageScrollableControl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView grdEntry;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpRecptDate;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
        private DevExpress.XtraEditors.LookUpEdit cmbSupplier;
        private System.Windows.Forms.TextBox txtRemarks;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtDraftAmt;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private System.Windows.Forms.TextBox txtChequeNo;
        private DevExpress.XtraEditors.LabelControl lblProprietor1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtDrawnOn;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

    }
}
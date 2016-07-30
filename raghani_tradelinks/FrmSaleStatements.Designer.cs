namespace raghani_tradelinks
{
    partial class FrmSaleStatements
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtPhoneOffice = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cmbCashCredit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.chkNoLRAddressPrinting = new System.Windows.Forms.CheckBox();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(530, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 324;
            this.labelControl1.Text = "To:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(562, 97);
            this.maskedTextBox1.Mask = "00-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox1.TabIndex = 323;
            // 
            // txtPhoneOffice
            // 
            this.txtPhoneOffice.HidePromptOnLeave = true;
            this.txtPhoneOffice.Location = new System.Drawing.Point(404, 97);
            this.txtPhoneOffice.Mask = "00-00-0000";
            this.txtPhoneOffice.Name = "txtPhoneOffice";
            this.txtPhoneOffice.Size = new System.Drawing.Size(84, 20);
            this.txtPhoneOffice.TabIndex = 322;
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(351, 100);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(30, 13);
            this.lblPhoneOffice.TabIndex = 321;
            this.lblPhoneOffice.Text = "Date:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Controls.Add(this.cmbCashCredit);
            this.panel1.Controls.Add(this.lblCashCredit);
            this.panel1.Location = new System.Drawing.Point(323, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 152);
            this.panel1.TabIndex = 325;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(18, 21);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SS", "Single Supplier"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("SA", "Sub Agent")});
            this.radioGroup1.Size = new System.Drawing.Size(325, 57);
            this.radioGroup1.TabIndex = 318;
            // 
            // cmbCashCredit
            // 
            this.cmbCashCredit.Location = new System.Drawing.Point(18, 119);
            this.cmbCashCredit.Name = "cmbCashCredit";
            this.cmbCashCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCashCredit.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbCashCredit.Size = new System.Drawing.Size(325, 20);
            this.cmbCashCredit.TabIndex = 317;
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(18, 100);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 316;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // chkNoLRAddressPrinting
            // 
            this.chkNoLRAddressPrinting.AutoSize = true;
            this.chkNoLRAddressPrinting.Location = new System.Drawing.Point(438, 324);
            this.chkNoLRAddressPrinting.Name = "chkNoLRAddressPrinting";
            this.chkNoLRAddressPrinting.Size = new System.Drawing.Size(15, 14);
            this.chkNoLRAddressPrinting.TabIndex = 327;
            this.chkNoLRAddressPrinting.UseVisualStyleBackColor = true;
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(342, 324);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(83, 13);
            this.lblNoLRAddressPrinting.TabIndex = 326;
            this.lblNoLRAddressPrinting.Text = "Summary Only";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(360, 380);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 329;
            this.btnView.Text = "View";
            // 
            // btnPrint
            // 
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Location = new System.Drawing.Point(471, 380);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 328;
            this.btnPrint.Text = "Print";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(581, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 330;
            this.btnCancel.Text = "Cancel";
            // 
            // FrmSaleStatements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1238, 741);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkNoLRAddressPrinting);
            this.Controls.Add(this.lblNoLRAddressPrinting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtPhoneOffice);
            this.Controls.Add(this.lblPhoneOffice);
            this.Name = "FrmSaleStatements";
            this.Text = "Statement Of Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSaleStatements_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox txtPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCashCredit;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private System.Windows.Forms.CheckBox chkNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
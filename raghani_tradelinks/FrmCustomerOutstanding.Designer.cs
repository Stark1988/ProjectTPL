namespace raghani_tradelinks
{
    partial class FrmCustomerOutstanding
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
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.txtBillsAgeingAbove = new System.Windows.Forms.TextBox();
            this.chkBoxDisputeReport = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkBoxSisterConcerns = new System.Windows.Forms.CheckBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.dateAsOn = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkBoxViewPhoneNumber = new System.Windows.Forms.CheckBox();
            this.chkCmbSuppl = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCmbSuppl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(409, 375);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(167, 36);
            this.btnPreview.TabIndex = 345;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(591, 375);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 36);
            this.btnPrint.TabIndex = 344;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(378, 190);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(103, 13);
            this.lblNoLRAddressPrinting.TabIndex = 342;
            this.lblNoLRAddressPrinting.Text = "Bills Ageing Above";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(378, 124);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(90, 13);
            this.lblCashCredit.TabIndex = 316;
            this.lblCashCredit.Text = "Customer Name";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(378, 223);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(32, 13);
            this.lblPhoneOffice.TabIndex = 339;
            this.lblPhoneOffice.Text = "As On";
            // 
            // txtBillsAgeingAbove
            // 
            this.txtBillsAgeingAbove.Location = new System.Drawing.Point(530, 187);
            this.txtBillsAgeingAbove.Name = "txtBillsAgeingAbove";
            this.txtBillsAgeingAbove.Size = new System.Drawing.Size(51, 21);
            this.txtBillsAgeingAbove.TabIndex = 346;
            this.txtBillsAgeingAbove.Text = "0";
            // 
            // chkBoxDisputeReport
            // 
            this.chkBoxDisputeReport.AutoSize = true;
            this.chkBoxDisputeReport.Location = new System.Drawing.Point(530, 291);
            this.chkBoxDisputeReport.Name = "chkBoxDisputeReport";
            this.chkBoxDisputeReport.Size = new System.Drawing.Size(15, 14);
            this.chkBoxDisputeReport.TabIndex = 348;
            this.chkBoxDisputeReport.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(378, 289);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 13);
            this.labelControl2.TabIndex = 347;
            this.labelControl2.Text = "Include Dispute Report";
            // 
            // chkBoxSisterConcerns
            // 
            this.chkBoxSisterConcerns.AutoSize = true;
            this.chkBoxSisterConcerns.Location = new System.Drawing.Point(530, 259);
            this.chkBoxSisterConcerns.Name = "chkBoxSisterConcerns";
            this.chkBoxSisterConcerns.Size = new System.Drawing.Size(15, 14);
            this.chkBoxSisterConcerns.TabIndex = 350;
            this.chkBoxSisterConcerns.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(378, 256);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 13);
            this.labelControl3.TabIndex = 349;
            this.labelControl3.Text = "Include Sister Concerns";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(530, 121);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Size = new System.Drawing.Size(305, 20);
            this.cmbCustomer.TabIndex = 351;
            // 
            // dateAsOn
            // 
            this.dateAsOn.Location = new System.Drawing.Point(530, 221);
            this.dateAsOn.Name = "dateAsOn";
            this.dateAsOn.Size = new System.Drawing.Size(169, 21);
            this.dateAsOn.TabIndex = 352;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(378, 322);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 13);
            this.labelControl1.TabIndex = 353;
            this.labelControl1.Text = "View Phone Number?";
            // 
            // chkBoxViewPhoneNumber
            // 
            this.chkBoxViewPhoneNumber.AutoSize = true;
            this.chkBoxViewPhoneNumber.Location = new System.Drawing.Point(530, 323);
            this.chkBoxViewPhoneNumber.Name = "chkBoxViewPhoneNumber";
            this.chkBoxViewPhoneNumber.Size = new System.Drawing.Size(15, 14);
            this.chkBoxViewPhoneNumber.TabIndex = 354;
            this.chkBoxViewPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // chkCmbSuppl
            // 
            this.chkCmbSuppl.EditValue = "Select Supplier Range";
            this.chkCmbSuppl.Location = new System.Drawing.Point(530, 154);
            this.chkCmbSuppl.Name = "chkCmbSuppl";
            this.chkCmbSuppl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chkCmbSuppl.Size = new System.Drawing.Size(305, 20);
            this.chkCmbSuppl.TabIndex = 356;
            this.chkCmbSuppl.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.chkCmbSuppl_CustomDisplayText);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(378, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 357;
            this.labelControl4.Text = "Supplier Range";
            // 
            // FrmCustomerOutstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 612);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chkCmbSuppl);
            this.Controls.Add(this.chkBoxViewPhoneNumber);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateAsOn);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.chkBoxSisterConcerns);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkBoxDisputeReport);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtBillsAgeingAbove);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCashCredit);
            this.Controls.Add(this.lblNoLRAddressPrinting);
            this.Controls.Add(this.lblPhoneOffice);
            this.Name = "FrmCustomerOutstanding";
            this.Text = "Customer Outstanding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerOutstanding_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomerOutstanding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCmbSuppl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private System.Windows.Forms.TextBox txtBillsAgeingAbove;
        private System.Windows.Forms.CheckBox chkBoxDisputeReport;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox chkBoxSisterConcerns;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomer;
        private System.Windows.Forms.DateTimePicker dateAsOn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox chkBoxViewPhoneNumber;
        private DevExpress.XtraEditors.CheckedComboBoxEdit chkCmbSuppl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
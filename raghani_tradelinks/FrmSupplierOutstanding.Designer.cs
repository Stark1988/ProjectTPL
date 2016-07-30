namespace raghani_tradelinks
{
    partial class FrmSupplierOutstanding
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerACNo = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCashCredit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.txtPhoneOffice = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(526, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 363;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(374, 375);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 362;
            this.labelControl3.Text = "Summary";
            // 
            // txtCustomerACNo
            // 
            this.txtCustomerACNo.Location = new System.Drawing.Point(526, 311);
            this.txtCustomerACNo.Name = "txtCustomerACNo";
            this.txtCustomerACNo.Size = new System.Drawing.Size(51, 20);
            this.txtCustomerACNo.TabIndex = 359;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(445, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 358;
            this.btnSave.Text = "Preview";
            // 
            // cmbCashCredit
            // 
            this.cmbCashCredit.Location = new System.Drawing.Point(470, 91);
            this.cmbCashCredit.Name = "cmbCashCredit";
            this.cmbCashCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCashCredit.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbCashCredit.Size = new System.Drawing.Size(305, 20);
            this.cmbCashCredit.TabIndex = 352;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(556, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 357;
            this.btnCancel.Text = "Print";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(374, 94);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 351;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(374, 314);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(103, 13);
            this.lblNoLRAddressPrinting.TabIndex = 356;
            this.lblNoLRAddressPrinting.Text = "Bills Ageing Above";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Location = new System.Drawing.Point(355, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 152);
            this.panel1.TabIndex = 355;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(18, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 346;
            this.labelControl1.Text = "Customer Range";
            // 
            // radioGroup1
            // 
            this.radioGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioGroup1.Location = new System.Drawing.Point(18, 56);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.Appearance.Options.UseTextOptions = true;
            this.radioGroup1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("All", "All"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Single", "Single")});
            this.radioGroup1.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.radioGroup1.Size = new System.Drawing.Size(401, 30);
            this.radioGroup1.TabIndex = 318;
            // 
            // txtPhoneOffice
            // 
            this.txtPhoneOffice.HidePromptOnLeave = true;
            this.txtPhoneOffice.Location = new System.Drawing.Point(526, 344);
            this.txtPhoneOffice.Mask = "00-00-0000";
            this.txtPhoneOffice.Name = "txtPhoneOffice";
            this.txtPhoneOffice.Size = new System.Drawing.Size(84, 20);
            this.txtPhoneOffice.TabIndex = 354;
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(374, 347);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(32, 13);
            this.lblPhoneOffice.TabIndex = 353;
            this.lblPhoneOffice.Text = "As On";
            // 
            // FrmSupplierOutstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 741);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCustomerACNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCashCredit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCashCredit);
            this.Controls.Add(this.lblNoLRAddressPrinting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPhoneOffice);
            this.Controls.Add(this.lblPhoneOffice);
            this.Name = "FrmSupplierOutstanding";
            this.Text = "Supplier Outstanding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSupplierOutstanding_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtCustomerACNo;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCashCredit;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.MaskedTextBox txtPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
    }
}
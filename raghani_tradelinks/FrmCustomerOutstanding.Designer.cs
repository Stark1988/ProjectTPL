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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerACNo = new System.Windows.Forms.TextBox();
            this.chkNoLRAddressPrinting = new System.Windows.Forms.CheckBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 345;
            this.btnSave.Text = "Preview";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(577, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 344;
            this.btnCancel.Text = "Print";
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(395, 313);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(103, 13);
            this.lblNoLRAddressPrinting.TabIndex = 342;
            this.lblNoLRAddressPrinting.Text = "Bills Ageing Above";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.radioGroup1);
            this.panel1.Location = new System.Drawing.Point(376, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 152);
            this.panel1.TabIndex = 341;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(18, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 346;
            this.labelControl1.Text = "Branch Range";
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
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(395, 93);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(90, 13);
            this.lblCashCredit.TabIndex = 316;
            this.lblCashCredit.Text = "Customer Name";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(395, 346);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(32, 13);
            this.lblPhoneOffice.TabIndex = 339;
            this.lblPhoneOffice.Text = "As On";
            // 
            // txtCustomerACNo
            // 
            this.txtCustomerACNo.Location = new System.Drawing.Point(547, 310);
            this.txtCustomerACNo.Name = "txtCustomerACNo";
            this.txtCustomerACNo.Size = new System.Drawing.Size(51, 20);
            this.txtCustomerACNo.TabIndex = 346;
            // 
            // chkNoLRAddressPrinting
            // 
            this.chkNoLRAddressPrinting.AutoSize = true;
            this.chkNoLRAddressPrinting.Location = new System.Drawing.Point(547, 405);
            this.chkNoLRAddressPrinting.Name = "chkNoLRAddressPrinting";
            this.chkNoLRAddressPrinting.Size = new System.Drawing.Size(15, 14);
            this.chkNoLRAddressPrinting.TabIndex = 348;
            this.chkNoLRAddressPrinting.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(395, 405);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 13);
            this.labelControl2.TabIndex = 347;
            this.labelControl2.Text = "Include Dispute Report";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(547, 374);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 350;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(395, 374);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 13);
            this.labelControl3.TabIndex = 349;
            this.labelControl3.Text = "Include Sister Concerns";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(518, 90);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Size = new System.Drawing.Size(309, 20);
            this.cmbCustomer.TabIndex = 351;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(547, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 352;
            // 
            // FrmCustomerOutstanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 741);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.chkNoLRAddressPrinting);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCustomerACNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCashCredit);
            this.Controls.Add(this.lblNoLRAddressPrinting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPhoneOffice);
            this.Name = "FrmCustomerOutstanding";
            this.Text = "Customer Outstanding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerOutstanding_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomerOutstanding_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtCustomerACNo;
        private System.Windows.Forms.CheckBox chkNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
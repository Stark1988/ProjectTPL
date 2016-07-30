namespace raghani_tradelinks
{
    partial class FrmCommissionReceived
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
            this.chkNoLRAddressPrinting = new System.Windows.Forms.CheckBox();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.cmbCashCredit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPhoneOffice = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkNoLRAddressPrinting
            // 
            this.chkNoLRAddressPrinting.AutoSize = true;
            this.chkNoLRAddressPrinting.Location = new System.Drawing.Point(641, 22);
            this.chkNoLRAddressPrinting.Name = "chkNoLRAddressPrinting";
            this.chkNoLRAddressPrinting.Size = new System.Drawing.Size(15, 14);
            this.chkNoLRAddressPrinting.TabIndex = 254;
            this.chkNoLRAddressPrinting.UseVisualStyleBackColor = true;
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(555, 22);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(52, 13);
            this.lblNoLRAddressPrinting.TabIndex = 253;
            this.lblNoLRAddressPrinting.Text = "Select All";
            // 
            // cmbCashCredit
            // 
            this.cmbCashCredit.Location = new System.Drawing.Point(183, 46);
            this.cmbCashCredit.Name = "cmbCashCredit";
            this.cmbCashCredit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCashCredit.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbCashCredit.Size = new System.Drawing.Size(325, 20);
            this.cmbCashCredit.TabIndex = 250;
            // 
            // txtPhoneOffice
            // 
            this.txtPhoneOffice.HidePromptOnLeave = true;
            this.txtPhoneOffice.Location = new System.Drawing.Point(183, 77);
            this.txtPhoneOffice.Mask = "00-00-0000";
            this.txtPhoneOffice.Name = "txtPhoneOffice";
            this.txtPhoneOffice.Size = new System.Drawing.Size(84, 20);
            this.txtPhoneOffice.TabIndex = 249;
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(89, 80);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(36, 13);
            this.lblPhoneOffice.TabIndex = 248;
            this.lblPhoneOffice.Text = "Period";
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(89, 49);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 247;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(89, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 251;
            this.labelControl5.Text = "Customer Name";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(183, 19);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(325, 20);
            this.comboBoxEdit1.TabIndex = 252;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(283, 77);
            this.maskedTextBox1.Mask = "00-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox1.TabIndex = 255;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(89, 121);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(681, 341);
            this.gridControl1.TabIndex = 311;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 585);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1222, 39);
            this.panelControl3.TabIndex = 312;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(478, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.Location = new System.Drawing.Point(192, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Search";
            // 
            // FrmCommissionReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 624);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chkNoLRAddressPrinting);
            this.Controls.Add(this.lblNoLRAddressPrinting);
            this.Controls.Add(this.cmbCashCredit);
            this.Controls.Add(this.txtPhoneOffice);
            this.Controls.Add(this.lblPhoneOffice);
            this.Controls.Add(this.lblCashCredit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.comboBoxEdit1);
            this.Name = "FrmCommissionReceived";
            this.Text = "Commission Received";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCommissionReceived_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCashCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCashCredit;
        private System.Windows.Forms.MaskedTextBox txtPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
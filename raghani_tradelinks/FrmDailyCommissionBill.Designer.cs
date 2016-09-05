namespace raghani_tradelinks
{
    partial class FrmDailyCommissionBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPageScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.comboBoxEdit5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkNoLRAddressPrinting = new System.Windows.Forms.CheckBox();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPriority = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MainPageScrollableControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 741);
            this.panel1.TabIndex = 17;
            // 
            // MainPageScrollableControl
            // 
            this.MainPageScrollableControl.AutoScrollMinSize = new System.Drawing.Size(0, 400);
            this.MainPageScrollableControl.Controls.Add(this.grdData);
            this.MainPageScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageScrollableControl.Location = new System.Drawing.Point(0, 73);
            this.MainPageScrollableControl.Name = "MainPageScrollableControl";
            this.MainPageScrollableControl.Size = new System.Drawing.Size(1238, 629);
            this.MainPageScrollableControl.TabIndex = 18;
            // 
            // comboBoxEdit5
            // 
            this.comboBoxEdit5.Location = new System.Drawing.Point(448, 42);
            this.comboBoxEdit5.Name = "comboBoxEdit5";
            this.comboBoxEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit5.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.comboBoxEdit5.Size = new System.Drawing.Size(142, 20);
            this.comboBoxEdit5.TabIndex = 301;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(400, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 300;
            this.labelControl4.Text = "M. Boy";
            // 
            // chkNoLRAddressPrinting
            // 
            this.chkNoLRAddressPrinting.AutoSize = true;
            this.chkNoLRAddressPrinting.Location = new System.Drawing.Point(164, 44);
            this.chkNoLRAddressPrinting.Name = "chkNoLRAddressPrinting";
            this.chkNoLRAddressPrinting.Size = new System.Drawing.Size(15, 14);
            this.chkNoLRAddressPrinting.TabIndex = 246;
            this.chkNoLRAddressPrinting.UseVisualStyleBackColor = true;
            // 
            // lblNoLRAddressPrinting
            // 
            this.lblNoLRAddressPrinting.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNoLRAddressPrinting.Location = new System.Drawing.Point(95, 44);
            this.lblNoLRAddressPrinting.Name = "lblNoLRAddressPrinting";
            this.lblNoLRAddressPrinting.Size = new System.Drawing.Size(52, 13);
            this.lblNoLRAddressPrinting.TabIndex = 245;
            this.lblNoLRAddressPrinting.Text = "Select All";
            // 
            // cmbPriority
            // 
            this.cmbPriority.EditValue = "All";
            this.cmbPriority.Location = new System.Drawing.Point(448, 10);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriority.Properties.Items.AddRange(new object[] {
            "All",
            "Pending Amt",
            "Recd Amt",
            "Market Boy Billing"});
            this.cmbPriority.Size = new System.Drawing.Size(142, 20);
            this.cmbPriority.TabIndex = 218;
            // 
            // lblPriority
            // 
            this.lblPriority.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPriority.Location = new System.Drawing.Point(400, 12);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(42, 13);
            this.lblPriority.TabIndex = 217;
            this.lblPriority.Text = "Criteria";
            // 
            // lblPhoneOffice
            // 
            this.lblPhoneOffice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneOffice.Location = new System.Drawing.Point(95, 12);
            this.lblPhoneOffice.Name = "lblPhoneOffice";
            this.lblPhoneOffice.Size = new System.Drawing.Size(36, 13);
            this.lblPhoneOffice.TabIndex = 200;
            this.lblPhoneOffice.Text = "Period";
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 702);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1238, 39);
            this.panelControl3.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(897, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Send SMS";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtpTo);
            this.panelControl1.Controls.Add(this.dtpFrom);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.lblPhoneOffice);
            this.panelControl1.Controls.Add(this.lblPriority);
            this.panelControl1.Controls.Add(this.cmbPriority);
            this.panelControl1.Controls.Add(this.lblNoLRAddressPrinting);
            this.panelControl1.Controls.Add(this.chkNoLRAddressPrinting);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.comboBoxEdit5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1238, 73);
            this.panelControl1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(644, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 301;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(755, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 300;
            this.simpleButton2.Text = "Preview";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(141, 9);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(116, 21);
            this.dtpFrom.TabIndex = 302;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(270, 9);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(116, 21);
            this.dtpTo.TabIndex = 303;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(1238, 629);
            this.grdData.TabIndex = 0;
            // 
            // FrmDailyCommissionBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 741);
            this.Controls.Add(this.MainPageScrollableControl);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDailyCommissionBill";
            this.Text = "Daily Commission Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDailyCommissionBill_FormClosing);
            this.Load += new System.EventHandler(this.FrmDailyCommissionBill_Load);
            this.MainPageScrollableControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.XtraScrollableControl MainPageScrollableControl;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.CheckBox chkNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
        private DevExpress.XtraEditors.LabelControl lblPriority;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}
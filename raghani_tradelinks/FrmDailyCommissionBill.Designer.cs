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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.MainPageScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.comboBoxEdit5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.chkNoLRAddressPrinting = new System.Windows.Forms.CheckBox();
            this.lblNoLRAddressPrinting = new DevExpress.XtraEditors.LabelControl();
            this.cmbPriority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPriority = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneOffice = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneOffice = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.MainPageScrollableControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1238, 629);
            this.gridControl1.TabIndex = 310;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // MainPageScrollableControl
            // 
            this.MainPageScrollableControl.AutoScrollMinSize = new System.Drawing.Size(0, 400);
            this.MainPageScrollableControl.Controls.Add(this.gridControl1);
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
            // maskedTextBox4
            // 
            this.maskedTextBox4.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.maskedTextBox4.Location = new System.Drawing.Point(263, 9);
            this.maskedTextBox4.Mask = "00-00-0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(81, 21);
            this.maskedTextBox4.TabIndex = 299;
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
            this.cmbPriority.Location = new System.Drawing.Point(448, 10);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriority.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
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
            // txtPhoneOffice
            // 
            this.txtPhoneOffice.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtPhoneOffice.Location = new System.Drawing.Point(164, 9);
            this.txtPhoneOffice.Mask = "00-00-0000";
            this.txtPhoneOffice.Name = "txtPhoneOffice";
            this.txtPhoneOffice.Size = new System.Drawing.Size(84, 21);
            this.txtPhoneOffice.TabIndex = 201;
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
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.lblPhoneOffice);
            this.panelControl1.Controls.Add(this.txtPhoneOffice);
            this.panelControl1.Controls.Add(this.maskedTextBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.MainPageScrollableControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.XtraScrollableControl MainPageScrollableControl;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.CheckBox chkNoLRAddressPrinting;
        private DevExpress.XtraEditors.LabelControl lblNoLRAddressPrinting;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriority;
        private DevExpress.XtraEditors.LabelControl lblPriority;
        private System.Windows.Forms.MaskedTextBox txtPhoneOffice;
        private DevExpress.XtraEditors.LabelControl lblPhoneOffice;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
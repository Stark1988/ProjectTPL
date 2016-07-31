namespace raghani_tradelinks
{
    partial class FrmNewCity
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
            this.lblCityName = new DevExpress.XtraEditors.LabelControl();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtSTDCode = new System.Windows.Forms.TextBox();
            this.lblSTDCode = new DevExpress.XtraEditors.LabelControl();
            this.lblState = new DevExpress.XtraEditors.LabelControl();
            this.cmbState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.Location = new System.Drawing.Point(5, 45);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(49, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(78, 42);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(178, 21);
            this.txtCityName.TabIndex = 1;
            // 
            // txtSTDCode
            // 
            this.txtSTDCode.Location = new System.Drawing.Point(78, 75);
            this.txtSTDCode.Name = "txtSTDCode";
            this.txtSTDCode.Size = new System.Drawing.Size(85, 21);
            this.txtSTDCode.TabIndex = 3;
            // 
            // lblSTDCode
            // 
            this.lblSTDCode.Location = new System.Drawing.Point(7, 78);
            this.lblSTDCode.Name = "lblSTDCode";
            this.lblSTDCode.Size = new System.Drawing.Size(47, 13);
            this.lblSTDCode.TabIndex = 2;
            this.lblSTDCode.Text = "STD Code";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(5, 15);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(26, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.Location = new System.Drawing.Point(78, 12);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Size = new System.Drawing.Size(178, 20);
            this.cmbState.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(126, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblState);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.cmbState);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.lblCityName);
            this.panelControl1.Controls.Add(this.lblSTDCode);
            this.panelControl1.Controls.Add(this.txtCityName);
            this.panelControl1.Controls.Add(this.txtSTDCode);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 164);
            this.panelControl1.TabIndex = 12;
            // 
            // FrmNewCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(776, 492);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FrmNewCity";
            this.Text = "New City";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewCity_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNewCity_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCityName;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtSTDCode;
        private DevExpress.XtraEditors.LabelControl lblSTDCode;
        private DevExpress.XtraEditors.LabelControl lblState;
        private DevExpress.XtraEditors.ComboBoxEdit cmbState;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
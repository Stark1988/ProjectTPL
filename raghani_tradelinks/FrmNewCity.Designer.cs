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
            this.txtEnteredBy = new System.Windows.Forms.TextBox();
            this.lblEnteredBy = new DevExpress.XtraEditors.LabelControl();
            this.txtEditedBy = new System.Windows.Forms.TextBox();
            this.lblEditedBy = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.Location = new System.Drawing.Point(43, 37);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(49, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(110, 33);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(233, 20);
            this.txtCityName.TabIndex = 1;
            // 
            // txtSTDCode
            // 
            this.txtSTDCode.Location = new System.Drawing.Point(429, 34);
            this.txtSTDCode.Name = "txtSTDCode";
            this.txtSTDCode.Size = new System.Drawing.Size(85, 20);
            this.txtSTDCode.TabIndex = 3;
            // 
            // lblSTDCode
            // 
            this.lblSTDCode.Location = new System.Drawing.Point(376, 37);
            this.lblSTDCode.Name = "lblSTDCode";
            this.lblSTDCode.Size = new System.Drawing.Size(47, 13);
            this.lblSTDCode.TabIndex = 2;
            this.lblSTDCode.Text = "STD Code";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(43, 72);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(26, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.Location = new System.Drawing.Point(110, 69);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Size = new System.Drawing.Size(233, 20);
            this.cmbState.TabIndex = 5;
            // 
            // txtEnteredBy
            // 
            this.txtEnteredBy.Location = new System.Drawing.Point(110, 148);
            this.txtEnteredBy.Name = "txtEnteredBy";
            this.txtEnteredBy.Size = new System.Drawing.Size(233, 20);
            this.txtEnteredBy.TabIndex = 7;
            // 
            // lblEnteredBy
            // 
            this.lblEnteredBy.Location = new System.Drawing.Point(43, 152);
            this.lblEnteredBy.Name = "lblEnteredBy";
            this.lblEnteredBy.Size = new System.Drawing.Size(53, 13);
            this.lblEnteredBy.TabIndex = 6;
            this.lblEnteredBy.Text = "Entered By";
            // 
            // txtEditedBy
            // 
            this.txtEditedBy.Location = new System.Drawing.Point(110, 179);
            this.txtEditedBy.Name = "txtEditedBy";
            this.txtEditedBy.Size = new System.Drawing.Size(233, 20);
            this.txtEditedBy.TabIndex = 9;
            // 
            // lblEditedBy
            // 
            this.lblEditedBy.Location = new System.Drawing.Point(43, 183);
            this.lblEditedBy.Name = "lblEditedBy";
            this.lblEditedBy.Size = new System.Drawing.Size(45, 13);
            this.lblEditedBy.TabIndex = 8;
            this.lblEditedBy.Text = "Edited By";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(229, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmNewCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(776, 492);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEditedBy);
            this.Controls.Add(this.lblEditedBy);
            this.Controls.Add(this.txtEnteredBy);
            this.Controls.Add(this.lblEnteredBy);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtSTDCode);
            this.Controls.Add(this.lblSTDCode);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.lblCityName);
            this.KeyPreview = true;
            this.Name = "FrmNewCity";
            this.Text = "New City";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewCity_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNewCity_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCityName;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtSTDCode;
        private DevExpress.XtraEditors.LabelControl lblSTDCode;
        private DevExpress.XtraEditors.LabelControl lblState;
        private DevExpress.XtraEditors.ComboBoxEdit cmbState;
        private System.Windows.Forms.TextBox txtEnteredBy;
        private DevExpress.XtraEditors.LabelControl lblEnteredBy;
        private System.Windows.Forms.TextBox txtEditedBy;
        private DevExpress.XtraEditors.LabelControl lblEditedBy;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lblCityName = new DevExpress.XtraEditors.LabelControl();
            this.lblSTDCode = new DevExpress.XtraEditors.LabelControl();
            this.lblState = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbState = new DevExpress.XtraEditors.LookUpEdit();
            this.grdCity = new System.Windows.Forms.DataGridView();
            this.txtPinCode = new DevExpress.XtraEditors.TextEdit();
            this.txtCityName = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.Location = new System.Drawing.Point(7, 45);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(49, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name";
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
            this.lblState.Location = new System.Drawing.Point(7, 15);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(26, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbState);
            this.panelControl1.Controls.Add(this.grdCity);
            this.panelControl1.Controls.Add(this.txtPinCode);
            this.panelControl1.Controls.Add(this.txtCityName);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.lblState);
            this.panelControl1.Controls.Add(this.lblCityName);
            this.panelControl1.Controls.Add(this.lblSTDCode);
            this.panelControl1.Location = new System.Drawing.Point(12, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(752, 395);
            this.panelControl1.TabIndex = 12;
            // 
            // cmbState
            // 
            this.cmbState.Location = new System.Drawing.Point(78, 12);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Size = new System.Drawing.Size(178, 20);
            this.cmbState.TabIndex = 35;
            // 
            // grdCity
            // 
            this.grdCity.AllowUserToAddRows = false;
            this.grdCity.AllowUserToDeleteRows = false;
            this.grdCity.AllowUserToOrderColumns = true;
            this.grdCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCity.Location = new System.Drawing.Point(7, 141);
            this.grdCity.Name = "grdCity";
            this.grdCity.ReadOnly = true;
            this.grdCity.Size = new System.Drawing.Size(724, 245);
            this.grdCity.TabIndex = 34;
            this.grdCity.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdCity_RowHeaderMouseClick);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(78, 75);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Properties.MaxLength = 8;
            this.txtPinCode.Size = new System.Drawing.Size(178, 20);
            this.txtPinCode.TabIndex = 33;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pincode can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtPinCode, conditionValidationRule1);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(78, 42);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.MaxLength = 25;
            this.txtCityName.Size = new System.Drawing.Size(178, 20);
            this.txtCityName.TabIndex = 32;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "City Name can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtCityName, conditionValidationRule2);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 112);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 112);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Insert";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(250, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 112);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 35);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "City Maintainance";
            // 
            // FrmNewCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 492);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FrmNewCity";
            this.Text = "New City";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewCity_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewCity_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNewCity_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPinCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCityName;
        private DevExpress.XtraEditors.LabelControl lblSTDCode;
        private DevExpress.XtraEditors.LabelControl lblState;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit txtPinCode;
        private DevExpress.XtraEditors.TextEdit txtCityName;
        private System.Windows.Forms.DataGridView grdCity;
        private DevExpress.XtraEditors.LookUpEdit cmbState;
    }
}
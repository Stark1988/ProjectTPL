namespace raghani_tradelinks
{
    partial class FrmNewSubAgent
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
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.txtPin = new DevExpress.XtraEditors.TextEdit();
            this.txtSubAgentName = new DevExpress.XtraEditors.TextEdit();
            this.cmbState = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbCity = new DevExpress.XtraEditors.LookUpEdit();
            this.grdSubAgent = new System.Windows.Forms.DataGridView();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtResPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtOfficePhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblStateName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAgentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOfficePhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1199, 35);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Sub Agent Maintainance";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(595, 36);
            this.txtPin.Name = "txtPin";
            this.txtPin.Properties.MaxLength = 100;
            this.txtPin.Size = new System.Drawing.Size(187, 20);
            this.txtPin.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pin can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtPin, conditionValidationRule1);
            // 
            // txtSubAgentName
            // 
            this.txtSubAgentName.Location = new System.Drawing.Point(113, 12);
            this.txtSubAgentName.Name = "txtSubAgentName";
            this.txtSubAgentName.Properties.MaxLength = 100;
            this.txtSubAgentName.Size = new System.Drawing.Size(356, 20);
            this.txtSubAgentName.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Courier Name can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtSubAgentName, conditionValidationRule2);
            // 
            // cmbState
            // 
            this.cmbState.Enabled = false;
            this.cmbState.Location = new System.Drawing.Point(595, 62);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Size = new System.Drawing.Size(187, 20);
            this.cmbState.TabIndex = 4;
            // 
            // cmbCity
            // 
            this.cmbCity.Location = new System.Drawing.Point(595, 12);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCity.Size = new System.Drawing.Size(187, 20);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.EditValueChanged += new System.EventHandler(this.cmbCity_EditValueChanged);
            // 
            // grdSubAgent
            // 
            this.grdSubAgent.AllowUserToAddRows = false;
            this.grdSubAgent.AllowUserToDeleteRows = false;
            this.grdSubAgent.AllowUserToOrderColumns = true;
            this.grdSubAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubAgent.Location = new System.Drawing.Point(19, 274);
            this.grdSubAgent.Name = "grdSubAgent";
            this.grdSubAgent.ReadOnly = true;
            this.grdSubAgent.Size = new System.Drawing.Size(1104, 256);
            this.grdSubAgent.TabIndex = 209;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(113, 151);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(356, 57);
            this.txtRemarks.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 153);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 62;
            this.labelControl7.Text = "Remarks";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(274, 128);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "Phone [Res]";
            // 
            // txtResPhone
            // 
            this.txtResPhone.Location = new System.Drawing.Point(339, 125);
            this.txtResPhone.Name = "txtResPhone";
            this.txtResPhone.Properties.MaxLength = 100;
            this.txtResPhone.Size = new System.Drawing.Size(130, 20);
            this.txtResPhone.TabIndex = 8;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(339, 99);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.MaxLength = 100;
            this.txtFax.Size = new System.Drawing.Size(130, 20);
            this.txtFax.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(274, 102);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Fax";
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Location = new System.Drawing.Point(113, 99);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Properties.MaxLength = 100;
            this.txtOfficePhone.Size = new System.Drawing.Size(130, 20);
            this.txtOfficePhone.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 102);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 59;
            this.labelControl4.Text = "Phone [Off]";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(507, 66);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "State";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(507, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Pin";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(507, 15);
            this.lblCity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(19, 13);
            this.lblCity.TabIndex = 55;
            this.lblCity.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 37);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(356, 57);
            this.txtAddress.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(23, 39);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 233);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 233);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Insert";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 233);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblStateName
            // 
            this.lblStateName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblStateName.Location = new System.Drawing.Point(23, 15);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(29, 15);
            this.lblStateName.TabIndex = 18;
            this.lblStateName.Text = "Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtMobile);
            this.panelControl1.Controls.Add(this.cmbState);
            this.panelControl1.Controls.Add(this.cmbCity);
            this.panelControl1.Controls.Add(this.grdSubAgent);
            this.panelControl1.Controls.Add(this.txtRemarks);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.txtResPhone);
            this.panelControl1.Controls.Add(this.txtFax);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtOfficePhone);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtPin);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblCity);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.lblAddress);
            this.panelControl1.Controls.Add(this.txtSubAgentName);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.lblStateName);
            this.panelControl1.Location = new System.Drawing.Point(12, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1162, 556);
            this.panelControl1.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 128);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 212;
            this.labelControl3.Text = "Mobile";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(113, 125);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Properties.MaxLength = 100;
            this.txtMobile.Size = new System.Drawing.Size(130, 20);
            this.txtMobile.TabIndex = 7;
            // 
            // FrmNewSubAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 704);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewSubAgent";
            this.Text = "FrmNewSubAgent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewSubAgent_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewSubAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubAgentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOfficePhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit txtPin;
        private DevExpress.XtraEditors.TextEdit txtSubAgentName;
        private DevExpress.XtraEditors.LookUpEdit cmbState;
        private DevExpress.XtraEditors.LookUpEdit cmbCity;
        private System.Windows.Forms.DataGridView grdSubAgent;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtResPhone;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtOfficePhone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl lblStateName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMobile;
    }
}
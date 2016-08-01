namespace raghani_tradelinks
{
    partial class FrmNewCourier
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtTransportName = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblStateName = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblCity);
            this.panelControl1.Controls.Add(this.txtCity);
            this.panelControl1.Controls.Add(this.memoEdit1);
            this.panelControl1.Controls.Add(this.lblAddress);
            this.panelControl1.Controls.Add(this.txtTransportName);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Controls.Add(this.lblStateName);
            this.panelControl1.Location = new System.Drawing.Point(12, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(911, 298);
            this.panelControl1.TabIndex = 29;
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(8, 106);
            this.lblCity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(19, 13);
            this.lblCity.TabIndex = 32;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 103);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.MaxLength = 100;
            this.txtCity.Size = new System.Drawing.Size(172, 20);
            this.txtCity.TabIndex = 31;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "State Name can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtCity, conditionValidationRule1);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(109, 38);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(270, 57);
            this.memoEdit1.TabIndex = 30;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(8, 39);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address";
            // 
            // txtTransportName
            // 
            this.txtTransportName.Location = new System.Drawing.Point(109, 12);
            this.txtTransportName.Name = "txtTransportName";
            this.txtTransportName.Properties.MaxLength = 100;
            this.txtTransportName.Size = new System.Drawing.Size(172, 20);
            this.txtTransportName.TabIndex = 28;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "State Name can not be blank.";
            this.dxValidationProvider1.SetValidationRule(this.txtTransportName, conditionValidationRule2);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(251, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(89, 261);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            // 
            // lblStateName
            // 
            this.lblStateName.Location = new System.Drawing.Point(8, 15);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(27, 13);
            this.lblStateName.TabIndex = 18;
            this.lblStateName.Text = "Name";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1013, 35);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Courier Maintainance";
            // 
            // FrmNewCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 574);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewCourier";
            this.Text = "FrmNewCourier";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtTransportName;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl lblStateName;
        private DevExpress.XtraEditors.LabelControl lblTitle;
    }
}
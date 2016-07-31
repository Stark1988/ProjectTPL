namespace raghani_tradelinks
{
    partial class FrmNewState
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.lblStateName = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtStateName);
            this.panelControl1.Controls.Add(this.lblStateName);
            this.panelControl1.Location = new System.Drawing.Point(12, 41);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(311, 120);
            this.panelControl1.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(101, 61);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(8, 61);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(79, 12);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtStateName.MaxLength = 20;
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(182, 21);
            this.txtStateName.TabIndex = 19;
            // 
            // lblStateName
            // 
            this.lblStateName.Location = new System.Drawing.Point(8, 15);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(56, 13);
            this.lblStateName.TabIndex = 18;
            this.lblStateName.Text = "State Name";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1234, 35);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "State Maintainance";
            // 
            // FrmNewState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FrmNewState";
            this.Text = "New State";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewState_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtStateName;
        private DevExpress.XtraEditors.LabelControl lblStateName;
        private DevExpress.XtraEditors.LabelControl lblTitle;

    }
}
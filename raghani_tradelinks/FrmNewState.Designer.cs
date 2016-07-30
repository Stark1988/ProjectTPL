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
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.lblStateName = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtEditedBy = new System.Windows.Forms.TextBox();
            this.lblEditedBy = new DevExpress.XtraEditors.LabelControl();
            this.txtEnteredBy = new System.Windows.Forms.TextBox();
            this.lblEnteredBy = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(514, 145);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(235, 20);
            this.txtStateName.TabIndex = 3;
            // 
            // lblStateName
            // 
            this.lblStateName.Location = new System.Drawing.Point(448, 150);
            this.lblStateName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblStateName.Name = "lblStateName";
            this.lblStateName.Size = new System.Drawing.Size(56, 13);
            this.lblStateName.TabIndex = 2;
            this.lblStateName.Text = "State Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(634, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(514, 317);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEditedBy
            // 
            this.txtEditedBy.Location = new System.Drawing.Point(514, 239);
            this.txtEditedBy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEditedBy.Name = "txtEditedBy";
            this.txtEditedBy.Size = new System.Drawing.Size(235, 20);
            this.txtEditedBy.TabIndex = 15;
            // 
            // lblEditedBy
            // 
            this.lblEditedBy.Location = new System.Drawing.Point(448, 243);
            this.lblEditedBy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblEditedBy.Name = "lblEditedBy";
            this.lblEditedBy.Size = new System.Drawing.Size(45, 13);
            this.lblEditedBy.TabIndex = 14;
            this.lblEditedBy.Text = "Edited By";
            // 
            // txtEnteredBy
            // 
            this.txtEnteredBy.Location = new System.Drawing.Point(514, 207);
            this.txtEnteredBy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtEnteredBy.Name = "txtEnteredBy";
            this.txtEnteredBy.Size = new System.Drawing.Size(235, 20);
            this.txtEnteredBy.TabIndex = 13;
            // 
            // lblEnteredBy
            // 
            this.lblEnteredBy.Location = new System.Drawing.Point(448, 213);
            this.lblEnteredBy.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lblEnteredBy.Name = "lblEnteredBy";
            this.lblEnteredBy.Size = new System.Drawing.Size(53, 13);
            this.lblEnteredBy.TabIndex = 12;
            this.lblEnteredBy.Text = "Entered By";
            // 
            // FrmNewState
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEditedBy);
            this.Controls.Add(this.lblEditedBy);
            this.Controls.Add(this.txtEnteredBy);
            this.Controls.Add(this.lblEnteredBy);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.lblStateName);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FrmNewState";
            this.Text = "New State";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewState_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStateName;
        private DevExpress.XtraEditors.LabelControl lblStateName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtEditedBy;
        private DevExpress.XtraEditors.LabelControl lblEditedBy;
        private System.Windows.Forms.TextBox txtEnteredBy;
        private DevExpress.XtraEditors.LabelControl lblEnteredBy;
    }
}
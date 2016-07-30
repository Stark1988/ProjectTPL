namespace raghani_tradelinks
{
    partial class RaghaniSplashScreen
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
            this.lblCopyright = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.lblDeveloperName = new DevExpress.XtraEditors.LabelControl();
            this.lblDeveloperContactNumber = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblCopyright.Location = new System.Drawing.Point(23, 280);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(87, 13);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "Copyright © 2016";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Location = new System.Drawing.Point(151, 116);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(246, 66);
            this.progressPanel1.TabIndex = 10;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCompanyName.Location = new System.Drawing.Point(17, 29);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(417, 33);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "RAGHANI TRADELINK (P) LTD.";
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeveloperName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblDeveloperName.Location = new System.Drawing.Point(338, 268);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(83, 13);
            this.lblDeveloperName.TabIndex = 12;
            this.lblDeveloperName.Text = "Sanjay Rathod";
            // 
            // lblDeveloperContactNumber
            // 
            this.lblDeveloperContactNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDeveloperContactNumber.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblDeveloperContactNumber.Location = new System.Drawing.Point(342, 287);
            this.lblDeveloperContactNumber.Name = "lblDeveloperContactNumber";
            this.lblDeveloperContactNumber.Size = new System.Drawing.Size(70, 13);
            this.lblDeveloperContactNumber.TabIndex = 13;
            this.lblDeveloperContactNumber.Text = "9327659638";
            // 
            // RaghaniSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.lblDeveloperContactNumber);
            this.Controls.Add(this.lblDeveloperName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.lblCopyright);
            this.Name = "RaghaniSplashScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RaghaniSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCopyright;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.LabelControl lblDeveloperName;
        private DevExpress.XtraEditors.LabelControl lblDeveloperContactNumber;
    }
}

namespace raghani_tradelinks
{
    partial class FrmFinalBillReport
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
            this.cmbSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCashCredit = new DevExpress.XtraEditors.LabelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Location = new System.Drawing.Point(326, 110);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Size = new System.Drawing.Size(371, 20);
            this.cmbSupplier.TabIndex = 372;
            // 
            // lblCashCredit
            // 
            this.lblCashCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCashCredit.Location = new System.Drawing.Point(326, 91);
            this.lblCashCredit.Name = "lblCashCredit";
            this.lblCashCredit.Size = new System.Drawing.Size(81, 13);
            this.lblCashCredit.TabIndex = 371;
            this.lblCashCredit.Text = "Supplier Name";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(342, 151);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(167, 36);
            this.btnPreview.TabIndex = 376;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(524, 151);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 36);
            this.btnPrint.TabIndex = 375;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmFinalBillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 519);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblCashCredit);
            this.Name = "FrmFinalBillReport";
            this.Text = "Final Bill Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFinalBillReport_FormClosing);
            this.Load += new System.EventHandler(this.FrmFinalBillReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cmbSupplier;
        private DevExpress.XtraEditors.LabelControl lblCashCredit;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
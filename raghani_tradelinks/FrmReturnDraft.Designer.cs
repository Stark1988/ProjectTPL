namespace raghani_tradelinks
{
    partial class FrmReturnDraft
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
            this.txtDraftReturnDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDrawnOn = new DevExpress.XtraEditors.TextEdit();
            this.txtDDChequeDate = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrintLetter = new DevExpress.XtraEditors.TextEdit();
            this.txtNoOfCopies = new DevExpress.XtraEditors.TextEdit();
            this.cmbDraftOrCheckNo = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbDraftOrCheque = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDocuments = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbEnclosed = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrawnOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrintLetter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfCopies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraftOrCheckNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraftOrCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocuments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnclosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDraftReturnDate
            // 
            this.txtDraftReturnDate.HidePromptOnLeave = true;
            this.txtDraftReturnDate.Location = new System.Drawing.Point(141, 12);
            this.txtDraftReturnDate.Mask = "00-00-0000";
            this.txtDraftReturnDate.Name = "txtDraftReturnDate";
            this.txtDraftReturnDate.Size = new System.Drawing.Size(70, 20);
            this.txtDraftReturnDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Draft Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Draft (D)/Chq (Q)";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Location = new System.Drawing.Point(401, 38);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplier.Size = new System.Drawing.Size(374, 20);
            this.cmbSupplier.TabIndex = 327;
            this.cmbSupplier.EditValueChanged += new System.EventHandler(this.cmbSupplier_EditValueChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(401, 12);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Size = new System.Drawing.Size(374, 20);
            this.cmbCustomer.TabIndex = 326;
            this.cmbCustomer.EditValueChanged += new System.EventHandler(this.cmbCustomer_EditValueChanged);
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl32.Location = new System.Drawing.Point(290, 40);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(81, 13);
            this.labelControl32.TabIndex = 324;
            this.labelControl32.Text = "Supplier Name";
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl33.Location = new System.Drawing.Point(290, 15);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(90, 13);
            this.labelControl33.TabIndex = 325;
            this.labelControl33.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 331;
            this.label4.Text = "Enclosed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 329;
            this.label3.Text = "Documents";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(290, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 334;
            this.labelControl1.Text = "Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbDraftOrCheckNo);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.txtDDChequeDate);
            this.panel1.Controls.Add(this.txtDrawnOn);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Location = new System.Drawing.Point(414, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 230);
            this.panel1.TabIndex = 337;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(22, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 338;
            this.labelControl2.Text = "DD/Cheque No.";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(22, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 13);
            this.labelControl3.TabIndex = 339;
            this.labelControl3.Text = "DD/Cheque Date";
            // 
            // txtDrawnOn
            // 
            this.txtDrawnOn.Location = new System.Drawing.Point(129, 64);
            this.txtDrawnOn.Name = "txtDrawnOn";
            this.txtDrawnOn.Size = new System.Drawing.Size(217, 20);
            this.txtDrawnOn.TabIndex = 341;
            // 
            // txtDDChequeDate
            // 
            this.txtDDChequeDate.HidePromptOnLeave = true;
            this.txtDDChequeDate.Location = new System.Drawing.Point(129, 39);
            this.txtDDChequeDate.Mask = "00-00-0000";
            this.txtDDChequeDate.Name = "txtDDChequeDate";
            this.txtDDChequeDate.Size = new System.Drawing.Size(70, 20);
            this.txtDDChequeDate.TabIndex = 338;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(22, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 342;
            this.labelControl4.Text = "Drawn on";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(129, 90);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 20);
            this.txtAmount.TabIndex = 340;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(22, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 343;
            this.labelControl5.Text = "Amount";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(22, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 344;
            this.labelControl6.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(22, 141);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(324, 73);
            this.txtReason.TabIndex = 338;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.btnCancel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 430);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(787, 39);
            this.panelControl3.TabIndex = 338;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(141, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(26, 372);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(104, 13);
            this.labelControl7.TabIndex = 345;
            this.labelControl7.Text = "Print Letter (Y/N)?";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(27, 400);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 346;
            this.labelControl8.Text = "No. of Copies";
            // 
            // txtPrintLetter
            // 
            this.txtPrintLetter.Location = new System.Drawing.Point(141, 371);
            this.txtPrintLetter.Name = "txtPrintLetter";
            this.txtPrintLetter.Size = new System.Drawing.Size(45, 20);
            this.txtPrintLetter.TabIndex = 345;
            // 
            // txtNoOfCopies
            // 
            this.txtNoOfCopies.Location = new System.Drawing.Point(141, 397);
            this.txtNoOfCopies.Name = "txtNoOfCopies";
            this.txtNoOfCopies.Size = new System.Drawing.Size(45, 20);
            this.txtNoOfCopies.TabIndex = 347;
            // 
            // cmbDraftOrCheckNo
            // 
            this.cmbDraftOrCheckNo.Location = new System.Drawing.Point(129, 14);
            this.cmbDraftOrCheckNo.Name = "cmbDraftOrCheckNo";
            this.cmbDraftOrCheckNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDraftOrCheckNo.Size = new System.Drawing.Size(217, 20);
            this.cmbDraftOrCheckNo.TabIndex = 348;
            // 
            // cmbDraftOrCheque
            // 
            this.cmbDraftOrCheque.Location = new System.Drawing.Point(141, 37);
            this.cmbDraftOrCheque.Name = "cmbDraftOrCheque";
            this.cmbDraftOrCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDraftOrCheque.Size = new System.Drawing.Size(105, 20);
            this.cmbDraftOrCheque.TabIndex = 348;
            // 
            // cmbDocuments
            // 
            this.cmbDocuments.Location = new System.Drawing.Point(141, 63);
            this.cmbDocuments.Name = "cmbDocuments";
            this.cmbDocuments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDocuments.Size = new System.Drawing.Size(105, 20);
            this.cmbDocuments.TabIndex = 349;
            // 
            // cmbEnclosed
            // 
            this.cmbEnclosed.Location = new System.Drawing.Point(141, 89);
            this.cmbEnclosed.Name = "cmbEnclosed";
            this.cmbEnclosed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEnclosed.Size = new System.Drawing.Size(105, 20);
            this.cmbEnclosed.TabIndex = 350;
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(401, 63);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Size = new System.Drawing.Size(374, 20);
            this.cmbType.TabIndex = 351;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 202);
            this.dataGridView1.TabIndex = 352;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(141, 341);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(117, 13);
            this.labelControl9.TabIndex = 353;
            this.labelControl9.Text = "Total Amount Due = ";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(260, 338);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(148, 20);
            this.textEdit1.TabIndex = 354;
            // 
            // FrmReturnDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 469);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbEnclosed);
            this.Controls.Add(this.cmbDocuments);
            this.Controls.Add(this.cmbDraftOrCheque);
            this.Controls.Add(this.txtNoOfCopies);
            this.Controls.Add(this.txtPrintLetter);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.labelControl32);
            this.Controls.Add(this.labelControl33);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDraftReturnDate);
            this.Name = "FrmReturnDraft";
            this.Text = "Return (Draft/Cheque)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReturnDraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrawnOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrintLetter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoOfCopies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraftOrCheckNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraftOrCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDocuments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnclosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDraftReturnDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit cmbSupplier;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox txtDDChequeDate;
        private DevExpress.XtraEditors.TextEdit txtDrawnOn;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtReason;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPrintLetter;
        private DevExpress.XtraEditors.TextEdit txtNoOfCopies;
        private DevExpress.XtraEditors.LookUpEdit cmbDraftOrCheckNo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDraftOrCheque;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDocuments;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEnclosed;
        private DevExpress.XtraEditors.ComboBoxEdit cmbType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
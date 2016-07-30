namespace raghani_tradelinks
{
    partial class FrmNewOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblSupplierACNo = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtEnteredBy = new System.Windows.Forms.TextBox();
            this.lblEnteredBy = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbRefType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRefType = new DevExpress.XtraEditors.LabelControl();
            this.txtSpokenDt1 = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRefType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 37);
            this.panel2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 248;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(384, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 247;
            this.labelControl2.Text = "Order Value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 246;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(180, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 245;
            this.labelControl3.Text = "Total Qty";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(670, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(781, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1238, 657);
            this.panel3.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1238, 657);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // lblSupplierACNo
            // 
            this.lblSupplierACNo.Location = new System.Drawing.Point(28, 16);
            this.lblSupplierACNo.Name = "lblSupplierACNo";
            this.lblSupplierACNo.Size = new System.Drawing.Size(54, 13);
            this.lblSupplierACNo.TabIndex = 5;
            this.lblSupplierACNo.Text = "Order Date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.labelControl15);
            this.panel1.Controls.Add(this.txtEnteredBy);
            this.panel1.Controls.Add(this.lblEnteredBy);
            this.panel1.Controls.Add(this.comboBoxEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.cmbRefType);
            this.panel1.Controls.Add(this.lblRefType);
            this.panel1.Controls.Add(this.txtSpokenDt1);
            this.panel1.Controls.Add(this.lblSupplierACNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 47);
            this.panel1.TabIndex = 4;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(1073, 14);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(107, 20);
            this.textBox13.TabIndex = 244;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(1007, 17);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(45, 13);
            this.labelControl15.TabIndex = 243;
            this.labelControl15.Text = "Edited By";
            // 
            // txtEnteredBy
            // 
            this.txtEnteredBy.Location = new System.Drawing.Point(873, 14);
            this.txtEnteredBy.Name = "txtEnteredBy";
            this.txtEnteredBy.Size = new System.Drawing.Size(119, 20);
            this.txtEnteredBy.TabIndex = 242;
            // 
            // lblEnteredBy
            // 
            this.lblEnteredBy.Location = new System.Drawing.Point(803, 17);
            this.lblEnteredBy.Name = "lblEnteredBy";
            this.lblEnteredBy.Size = new System.Drawing.Size(53, 13);
            this.lblEnteredBy.TabIndex = 241;
            this.lblEnteredBy.Text = "Entered By";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(634, 13);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(144, 20);
            this.comboBoxEdit1.TabIndex = 240;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(566, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 239;
            this.labelControl1.Text = "Order / Visit";
            // 
            // cmbRefType
            // 
            this.cmbRefType.Location = new System.Drawing.Point(261, 13);
            this.cmbRefType.Name = "cmbRefType";
            this.cmbRefType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRefType.Properties.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbRefType.Size = new System.Drawing.Size(278, 20);
            this.cmbRefType.TabIndex = 238;
            // 
            // lblRefType
            // 
            this.lblRefType.Location = new System.Drawing.Point(207, 16);
            this.lblRefType.Name = "lblRefType";
            this.lblRefType.Size = new System.Drawing.Size(46, 13);
            this.lblRefType.TabIndex = 237;
            this.lblRefType.Text = "Customer";
            // 
            // txtSpokenDt1
            // 
            this.txtSpokenDt1.HidePromptOnLeave = true;
            this.txtSpokenDt1.Location = new System.Drawing.Point(88, 12);
            this.txtSpokenDt1.Mask = "00-00-0000";
            this.txtSpokenDt1.Name = "txtSpokenDt1";
            this.txtSpokenDt1.Size = new System.Drawing.Size(86, 20);
            this.txtSpokenDt1.TabIndex = 236;
            // 
            // FrmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmNewOrder";
            this.Text = "NewOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNewOrder_FormClosing);
            this.Load += new System.EventHandler(this.FrmNewOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRefType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lblSupplierACNo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MaskedTextBox txtSpokenDt1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRefType;
        private DevExpress.XtraEditors.LabelControl lblRefType;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox textBox13;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.TextBox txtEnteredBy;
        private DevExpress.XtraEditors.LabelControl lblEnteredBy;
    }
}
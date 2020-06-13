namespace PKDK.KhamBenh
{
    partial class FrmChonSoCLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonSoCLS));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSoCLS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bindingGiaDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.chkAll = new DevExpress.XtraEditors.CheckEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bindingLoaiDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.cboLoaiDV = new System.Windows.Forms.ComboBox();
            this.chklstGiaDichVu = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSoCLS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGiaDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLoaiDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklstGiaDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên sổ cận lâm sàng:";
            // 
            // txtTenSoCLS
            // 
            this.txtTenSoCLS.EnterMoveNextControl = true;
            this.txtTenSoCLS.Location = new System.Drawing.Point(119, 9);
            this.txtTenSoCLS.Name = "txtTenSoCLS";
            this.txtTenSoCLS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenSoCLS.Size = new System.Drawing.Size(275, 20);
            this.txtTenSoCLS.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(69, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(237, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Đến ngày:";
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.EditValue = null;
            this.txtTuNgay.EnterMoveNextControl = true;
            this.txtTuNgay.Location = new System.Drawing.Point(119, 33);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtTuNgay.Size = new System.Drawing.Size(100, 20);
            this.txtTuNgay.TabIndex = 3;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.EditValue = null;
            this.txtDenNgay.EnterMoveNextControl = true;
            this.txtDenNgay.Location = new System.Drawing.Point(294, 33);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDenNgay.Size = new System.Drawing.Size(100, 20);
            this.txtDenNgay.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 62);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Loại cận lâm sàng:";
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(12, 368);
            this.chkAll.Name = "chkAll";
            this.chkAll.Properties.Caption = "Chọn tất cả";
            this.chkAll.Size = new System.Drawing.Size(75, 19);
            this.chkAll.TabIndex = 11;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(400, 310);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "In sổ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(400, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bindingLoaiDichVu
            // 
            this.bindingLoaiDichVu.CurrentChanged += new System.EventHandler(this.bindingLoaiDichVu_CurrentChanged);
            // 
            // cboLoaiDV
            // 
            this.cboLoaiDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDV.FormattingEnabled = true;
            this.cboLoaiDV.Location = new System.Drawing.Point(119, 59);
            this.cboLoaiDV.Name = "cboLoaiDV";
            this.cboLoaiDV.Size = new System.Drawing.Size(275, 21);
            this.cboLoaiDV.TabIndex = 7;
            // 
            // chklstGiaDichVu
            // 
            this.chklstGiaDichVu.CheckOnClick = true;
            this.chklstGiaDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.chklstGiaDichVu.DataSource = this.bindingGiaDichVu;
            this.chklstGiaDichVu.DisplayMember = "TENDV";
            this.chklstGiaDichVu.Location = new System.Drawing.Point(12, 86);
            this.chklstGiaDichVu.Name = "chklstGiaDichVu";
            this.chklstGiaDichVu.Size = new System.Drawing.Size(382, 276);
            this.chklstGiaDichVu.TabIndex = 8;
            this.chklstGiaDichVu.ValueMember = "GIADVID";
            // 
            // FrmChonSoCLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 394);
            this.Controls.Add(this.chklstGiaDichVu);
            this.Controls.Add(this.cboLoaiDV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.txtTenSoCLS);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChonSoCLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In sổ Cận lâm sàng";
            this.Load += new System.EventHandler(this.FrmChonSoCLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSoCLS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGiaDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLoaiDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklstGiaDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenSoCLS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtTuNgay;
        private DevExpress.XtraEditors.DateEdit txtDenNgay;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkAll;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.BindingSource bindingLoaiDichVu;
        private System.Windows.Forms.BindingSource bindingGiaDichVu;
        private System.Windows.Forms.ComboBox cboLoaiDV;
        private DevExpress.XtraEditors.CheckedListBoxControl chklstGiaDichVu;
    }
}
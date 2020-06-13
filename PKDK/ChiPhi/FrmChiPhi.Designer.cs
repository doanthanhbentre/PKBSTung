namespace PKDK.ChiPhi
{
    partial class FrmChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiPhi));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.txtLyDoGiam = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.ucChiPhi1 = new PKDK.ChiPhi.UcChiPhi();
            this.txtSoTienGiam = new DevExpress.XtraEditors.SpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuHuyPhieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridMaPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDoGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienGiam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblHoTen);
            this.panelControl1.Controls.Add(this.txtLyDoGiam);
            this.panelControl1.Controls.Add(this.txtNgay);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnPrintPreview);
            this.panelControl1.Controls.Add(this.btnThanhToan);
            this.panelControl1.Controls.Add(this.ucChiPhi1);
            this.panelControl1.Controls.Add(this.txtSoTienGiam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 283);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(678, 105);
            this.panelControl1.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblHoTen.Appearance.Options.UseFont = true;
            this.lblHoTen.Appearance.Options.UseForeColor = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 69);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 13);
            this.lblHoTen.TabIndex = 8;
            this.lblHoTen.Text = "labelControl4";
            // 
            // txtLyDoGiam
            // 
            this.txtLyDoGiam.Location = new System.Drawing.Point(506, 27);
            this.txtLyDoGiam.Name = "txtLyDoGiam";
            this.txtLyDoGiam.Size = new System.Drawing.Size(172, 20);
            this.txtLyDoGiam.TabIndex = 7;
            // 
            // txtNgay
            // 
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(309, 27);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtNgay.Size = new System.Drawing.Size(100, 20);
            this.txtNgay.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(506, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Lý do giảm:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(415, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Số tiền giảm:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(309, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Ngày thu:";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(591, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Appearance.Options.UseFont = true;
            this.btnPrintPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrintPreview.Location = new System.Drawing.Point(474, 64);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(111, 23);
            this.btnPrintPreview.TabIndex = 0;
            this.btnPrintPreview.Text = "Xem phiếu thu";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(272, 64);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(93, 23);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // ucChiPhi1
            // 
            this.ucChiPhi1.ChuaThu = 0D;
            this.ucChiPhi1.DaThu = 0D;
            this.ucChiPhi1.Location = new System.Drawing.Point(5, 5);
            this.ucChiPhi1.Name = "ucChiPhi1";
            this.ucChiPhi1.Size = new System.Drawing.Size(290, 47);
            this.ucChiPhi1.TabIndex = 3;
            this.ucChiPhi1.TongSoTien = 0D;
            // 
            // txtSoTienGiam
            // 
            this.txtSoTienGiam.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoTienGiam.Location = new System.Drawing.Point(415, 27);
            this.txtSoTienGiam.Name = "txtSoTienGiam";
            this.txtSoTienGiam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTienGiam.Properties.DisplayFormat.FormatString = "#,###,###";
            this.txtSoTienGiam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienGiam.Properties.EditFormat.FormatString = "#,###,###";
            this.txtSoTienGiam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTienGiam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtSoTienGiam.Properties.Mask.EditMask = "#,###,###";
            this.txtSoTienGiam.Properties.MaxValue = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtSoTienGiam.Size = new System.Drawing.Size(85, 20);
            this.txtSoTienGiam.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 283);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dịch vụ";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.bindingDichVu;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(674, 260);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuyPhieuThu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // mnuHuyPhieuThu
            // 
            this.mnuHuyPhieuThu.Name = "mnuHuyPhieuThu";
            this.mnuHuyPhieuThu.Size = new System.Drawing.Size(150, 22);
            this.mnuHuyPhieuThu.Text = "Hủy phiếu thu";
            this.mnuHuyPhieuThu.Click += new System.EventHandler(this.mnuHuyPhieuThu_Click);
            // 
            // bindingDichVu
            // 
            this.bindingDichVu.CurrentChanged += new System.EventHandler(this.bindingDichVu_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDV,
            this.colTenDonVi,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien,
            this.gridMaPT});
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Expression = "IsNullOrEmpty([MAPT])";
            formatConditionRuleExpression2.PredefinedName = "Red Text";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDV
            // 
            this.colTenDV.Caption = "Tên dịch vu";
            this.colTenDV.FieldName = "TENDV";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.Visible = true;
            this.colTenDV.VisibleIndex = 0;
            this.colTenDV.Width = 148;
            // 
            // colTenDonVi
            // 
            this.colTenDonVi.Caption = "Đơn vị";
            this.colTenDonVi.FieldName = "DONVI";
            this.colTenDonVi.Name = "colTenDonVi";
            this.colTenDonVi.Visible = true;
            this.colTenDonVi.VisibleIndex = 1;
            this.colTenDonVi.Width = 43;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "SL";
            this.colSoLuong.DisplayFormat.FormatString = "#,###";
            this.colSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoLuong.FieldName = "SOLUONG";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 30;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "ĐG";
            this.colDonGia.DisplayFormat.FormatString = "#,###";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DONGIA";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 53;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Số tiền";
            this.colThanhTien.DisplayFormat.FormatString = "#,###";
            this.colThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colThanhTien.FieldName = "THANHTIEN";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 4;
            this.colThanhTien.Width = 73;
            // 
            // gridMaPT
            // 
            this.gridMaPT.Caption = "Mã PT";
            this.gridMaPT.FieldName = "MAPT";
            this.gridMaPT.Name = "gridMaPT";
            this.gridMaPT.Visible = true;
            this.gridMaPT.VisibleIndex = 5;
            this.gridMaPT.Width = 74;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(371, 64);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "In phiếu thu";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // FrmChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 388);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi phí";
            this.Load += new System.EventHandler(this.FrmChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDoGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienGiam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource bindingDichVu;
        private UcChiPhi ucChiPhi1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridMaPT;
        private DevExpress.XtraEditors.TextEdit txtLyDoGiam;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txtSoTienGiam;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHuyPhieuThu;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
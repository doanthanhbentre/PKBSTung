namespace PKDK.ThietLap
{
    partial class FrmChiTietGoiDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietGoiDV));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lstXetNghiem = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstGoiXetNghiem = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboGoiDichVu = new DevExpress.XtraEditors.LookUpEdit();
            this.bindingGoiDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.btnGoiDichVu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.lblTongSo = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstXetNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstGoiXetNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboGoiDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGoiDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lstXetNghiem);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 380);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách xét nghiệm";
            // 
            // lstXetNghiem
            // 
            this.lstXetNghiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstXetNghiem.DataSource = this.bindingSource1;
            this.lstXetNghiem.DisplayMember = "TENDV";
            this.lstXetNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstXetNghiem.Location = new System.Drawing.Point(2, 21);
            this.lstXetNghiem.Name = "lstXetNghiem";
            this.lstXetNghiem.Size = new System.Drawing.Size(310, 357);
            this.lstXetNghiem.TabIndex = 2;
            this.lstXetNghiem.ValueMember = "GIADVID";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lstGoiXetNghiem);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(416, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(314, 380);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách gói xét nghiệm";
            // 
            // lstGoiXetNghiem
            // 
            this.lstGoiXetNghiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstGoiXetNghiem.DataSource = this.bindingSource2;
            this.lstGoiXetNghiem.DisplayMember = "TENDV";
            this.lstGoiXetNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGoiXetNghiem.Location = new System.Drawing.Point(2, 53);
            this.lstGoiXetNghiem.Name = "lstGoiXetNghiem";
            this.lstGoiXetNghiem.Size = new System.Drawing.Size(310, 325);
            this.lstGoiXetNghiem.TabIndex = 1;
            this.lstGoiXetNghiem.ValueMember = "GIADVID";
            // 
            // bindingSource2
            // 
            this.bindingSource2.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSource2_ListChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboGoiDichVu);
            this.panelControl1.Controls.Add(this.btnGoiDichVu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(310, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // cboGoiDichVu
            // 
            this.cboGoiDichVu.Location = new System.Drawing.Point(6, 6);
            this.cboGoiDichVu.Name = "cboGoiDichVu";
            this.cboGoiDichVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGoiDichVu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENGOIDV", "TENGOIDV", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GOIDVID", "GOIDVID", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Center)});
            this.cboGoiDichVu.Properties.DataSource = this.bindingGoiDichVu;
            this.cboGoiDichVu.Properties.DisplayMember = "TENGOIDV";
            this.cboGoiDichVu.Properties.ShowHeader = false;
            this.cboGoiDichVu.Properties.ValueMember = "GOIDVID";
            this.cboGoiDichVu.Size = new System.Drawing.Size(264, 20);
            this.cboGoiDichVu.TabIndex = 2;
            this.cboGoiDichVu.EditValueChanged += new System.EventHandler(this.cboGoiDichVu_EditValueChanged);
            // 
            // bindingGoiDichVu
            // 
            this.bindingGoiDichVu.CurrentChanged += new System.EventHandler(this.bindingGoiDichVu_CurrentChanged);
            // 
            // btnGoiDichVu
            // 
            this.btnGoiDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiDichVu.ImageOptions.Image")));
            this.btnGoiDichVu.Location = new System.Drawing.Point(276, 5);
            this.btnGoiDichVu.Name = "btnGoiDichVu";
            this.btnGoiDichVu.Size = new System.Drawing.Size(24, 23);
            this.btnGoiDichVu.TabIndex = 1;
            this.btnGoiDichVu.ToolTip = "Thêm gói dịch vụ";
            this.btnGoiDichVu.Click += new System.EventHandler(this.btnGoiDichVu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(320, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm XN";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(318, 116);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy XN";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTongSo
            // 
            this.lblTongSo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTongSo.Appearance.Options.UseFont = true;
            this.lblTongSo.Appearance.Options.UseForeColor = true;
            this.lblTongSo.Appearance.Options.UseTextOptions = true;
            this.lblTongSo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTongSo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTongSo.Location = new System.Drawing.Point(320, 355);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(88, 23);
            this.lblTongSo.TabIndex = 3;
            this.lblTongSo.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(318, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmChiTietGoiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 380);
            this.Controls.Add(this.lblTongSo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiTietGoiDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gói xét nghiệm";
            this.Load += new System.EventHandler(this.FrmChiTietGoiDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstXetNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstGoiXetNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboGoiDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGoiDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGoiDichVu;
        private DevExpress.XtraEditors.ListBoxControl lstXetNghiem;
        private DevExpress.XtraEditors.ListBoxControl lstGoiXetNghiem;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraEditors.LabelControl lblTongSo;
        private System.Windows.Forms.BindingSource bindingGoiDichVu;
        private DevExpress.XtraEditors.LookUpEdit cboGoiDichVu;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}
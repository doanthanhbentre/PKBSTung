namespace PKDK.HeThong
{
    partial class FrmThoiGian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThoiGian));
            this.radTuNgay = new System.Windows.Forms.RadioButton();
            this.radTuThang = new System.Windows.Forms.RadioButton();
            this.txtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuThang = new DevExpress.XtraEditors.SpinEdit();
            this.txtTuNam = new DevExpress.XtraEditors.SpinEdit();
            this.txtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtDenThang = new DevExpress.XtraEditors.SpinEdit();
            this.txtDenNam = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radTuNgay
            // 
            this.radTuNgay.AutoSize = true;
            this.radTuNgay.Checked = true;
            this.radTuNgay.Location = new System.Drawing.Point(12, 23);
            this.radTuNgay.Name = "radTuNgay";
            this.radTuNgay.Size = new System.Drawing.Size(65, 17);
            this.radTuNgay.TabIndex = 0;
            this.radTuNgay.TabStop = true;
            this.radTuNgay.Text = "Từ ngày";
            this.radTuNgay.UseVisualStyleBackColor = true;
            this.radTuNgay.CheckedChanged += new System.EventHandler(this.radTuNgay_CheckedChanged);
            // 
            // radTuThang
            // 
            this.radTuThang.AutoSize = true;
            this.radTuThang.Location = new System.Drawing.Point(12, 46);
            this.radTuThang.Name = "radTuThang";
            this.radTuThang.Size = new System.Drawing.Size(69, 17);
            this.radTuThang.TabIndex = 3;
            this.radTuThang.Text = "Từ tháng";
            this.radTuThang.UseVisualStyleBackColor = true;
            this.radTuThang.CheckedChanged += new System.EventHandler(this.radTuThang_CheckedChanged);
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.EditValue = null;
            this.txtTuNgay.Location = new System.Drawing.Point(92, 22);
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
            this.txtTuNgay.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(92, 87);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "Đồng ý";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(173, 87);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTuThang
            // 
            this.txtTuThang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTuThang.Location = new System.Drawing.Point(92, 46);
            this.txtTuThang.Name = "txtTuThang";
            this.txtTuThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuThang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTuThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTuThang.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtTuThang.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTuThang.Size = new System.Drawing.Size(41, 20);
            this.txtTuThang.TabIndex = 8;
            this.txtTuThang.EditValueChanged += new System.EventHandler(this.txtTuThang_EditValueChanged);
            // 
            // txtTuNam
            // 
            this.txtTuNam.EditValue = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.txtTuNam.Location = new System.Drawing.Point(139, 46);
            this.txtTuNam.Name = "txtTuNam";
            this.txtTuNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTuNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTuNam.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtTuNam.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTuNam.Size = new System.Drawing.Size(53, 20);
            this.txtTuNam.TabIndex = 8;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.EditValue = null;
            this.txtDenNgay.Location = new System.Drawing.Point(198, 22);
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
            this.txtDenNgay.TabIndex = 1;
            // 
            // txtDenThang
            // 
            this.txtDenThang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDenThang.Location = new System.Drawing.Point(198, 46);
            this.txtDenThang.Name = "txtDenThang";
            this.txtDenThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenThang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDenThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDenThang.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtDenThang.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDenThang.Size = new System.Drawing.Size(41, 20);
            this.txtDenThang.TabIndex = 8;
            // 
            // txtDenNam
            // 
            this.txtDenNam.EditValue = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.txtDenNam.Location = new System.Drawing.Point(245, 45);
            this.txtDenNam.Name = "txtDenNam";
            this.txtDenNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDenNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDenNam.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtDenNam.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDenNam.Size = new System.Drawing.Size(53, 20);
            this.txtDenNam.TabIndex = 8;
            // 
            // FrmThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 131);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.radTuThang);
            this.Controls.Add(this.radTuNgay);
            this.Controls.Add(this.txtDenNam);
            this.Controls.Add(this.txtTuNam);
            this.Controls.Add(this.txtDenThang);
            this.Controls.Add(this.txtTuThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời gian";
            this.Load += new System.EventHandler(this.FrmThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTuNgay;
        private System.Windows.Forms.RadioButton radTuThang;
        private DevExpress.XtraEditors.DateEdit txtTuNgay;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SpinEdit txtTuThang;
        private DevExpress.XtraEditors.SpinEdit txtTuNam;
        private DevExpress.XtraEditors.DateEdit txtDenNgay;
        private DevExpress.XtraEditors.SpinEdit txtDenThang;
        private DevExpress.XtraEditors.SpinEdit txtDenNam;
    }
}
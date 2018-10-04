namespace PKDK.ChiPhi
{
    partial class UcChiPhi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienDaThu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTienChuaThu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienChuaThu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tổng số tiền:";
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Location = new System.Drawing.Point(6, 22);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongSoTien.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTongSoTien.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTongSoTien.Properties.DisplayFormat.FormatString = "#,###";
            this.txtTongSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTongSoTien.Properties.ReadOnly = true;
            this.txtTongSoTien.Size = new System.Drawing.Size(89, 20);
            this.txtTongSoTien.TabIndex = 1;
            // 
            // txtSoTienDaThu
            // 
            this.txtSoTienDaThu.Location = new System.Drawing.Point(101, 22);
            this.txtSoTienDaThu.Name = "txtSoTienDaThu";
            this.txtSoTienDaThu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienDaThu.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtSoTienDaThu.Properties.Appearance.Options.UseFont = true;
            this.txtSoTienDaThu.Properties.Appearance.Options.UseForeColor = true;
            this.txtSoTienDaThu.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoTienDaThu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSoTienDaThu.Properties.ReadOnly = true;
            this.txtSoTienDaThu.Size = new System.Drawing.Size(89, 20);
            this.txtSoTienDaThu.TabIndex = 1;
            // 
            // txtSoTienChuaThu
            // 
            this.txtSoTienChuaThu.Location = new System.Drawing.Point(196, 22);
            this.txtSoTienChuaThu.Name = "txtSoTienChuaThu";
            this.txtSoTienChuaThu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienChuaThu.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtSoTienChuaThu.Properties.Appearance.Options.UseFont = true;
            this.txtSoTienChuaThu.Properties.Appearance.Options.UseForeColor = true;
            this.txtSoTienChuaThu.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSoTienChuaThu.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSoTienChuaThu.Properties.ReadOnly = true;
            this.txtSoTienChuaThu.Size = new System.Drawing.Size(89, 20);
            this.txtSoTienChuaThu.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(101, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số tiền đã thu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(196, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số tiền chưa thu:";
            // 
            // UcChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSoTienChuaThu);
            this.Controls.Add(this.txtSoTienDaThu);
            this.Controls.Add(this.txtTongSoTien);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "UcChiPhi";
            this.Size = new System.Drawing.Size(290, 47);
            ((System.ComponentModel.ISupportInitialize)(this.txtTongSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienDaThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienChuaThu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTongSoTien;
        private DevExpress.XtraEditors.TextEdit txtSoTienDaThu;
        private DevExpress.XtraEditors.TextEdit txtSoTienChuaThu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

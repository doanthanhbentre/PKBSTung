namespace PKDK.KhamBenh
{
    partial class FrmChonGoiXN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonGoiXN));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lstListGoi = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingGoiDV = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstXetNghiem = new DevExpress.XtraEditors.ListBoxControl();
            this.bindingXetNghiem = new System.Windows.Forms.BindingSource(this.components);
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstListGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGoiDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstXetNghiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingXetNghiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lstListGoi);
            this.groupControl1.Location = new System.Drawing.Point(12, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(279, 291);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách gói xét nghiệm";
            // 
            // lstListGoi
            // 
            this.lstListGoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListGoi.Appearance.Options.UseFont = true;
            this.lstListGoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstListGoi.DataSource = this.bindingGoiDV;
            this.lstListGoi.DisplayMember = "TENGOIDV";
            this.lstListGoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListGoi.Location = new System.Drawing.Point(2, 21);
            this.lstListGoi.Name = "lstListGoi";
            this.lstListGoi.Size = new System.Drawing.Size(275, 268);
            this.lstListGoi.TabIndex = 1;
            this.lstListGoi.ValueMember = "GOIDVID";
            // 
            // bindingGoiDV
            // 
            this.bindingGoiDV.CurrentChanged += new System.EventHandler(this.bindingGoiDV_CurrentChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lstXetNghiem);
            this.groupControl2.Location = new System.Drawing.Point(297, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(279, 291);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách các xét nghiệm";
            // 
            // lstXetNghiem
            // 
            this.lstXetNghiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstXetNghiem.DataSource = this.bindingXetNghiem;
            this.lstXetNghiem.DisplayMember = "TENDV";
            this.lstXetNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstXetNghiem.Location = new System.Drawing.Point(2, 21);
            this.lstXetNghiem.Name = "lstXetNghiem";
            this.lstXetNghiem.Size = new System.Drawing.Size(275, 268);
            this.lstXetNghiem.TabIndex = 0;
            this.lstXetNghiem.ValueMember = "GIADVID";
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(216, 317);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(297, 317);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmChonGoiXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 355);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChonGoiXN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn gói xét nghiệm";
            this.Load += new System.EventHandler(this.FrmChonGoiXN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstListGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingGoiDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstXetNghiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingXetNghiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.ListBoxControl lstListGoi;
        private DevExpress.XtraEditors.ListBoxControl lstXetNghiem;
        private System.Windows.Forms.BindingSource bindingGoiDV;
        private System.Windows.Forms.BindingSource bindingXetNghiem;
    }
}
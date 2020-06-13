namespace PKDK.ThietLap
{
    partial class FrmXaPhuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXaPhuong));
            this.txtMaXP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenXP = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboQuanHuyen = new System.Windows.Forms.ComboBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bindingQuanHuyen = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuanHuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaXP
            // 
            this.txtMaXP.EnterMoveNextControl = true;
            this.txtMaXP.Location = new System.Drawing.Point(99, 20);
            this.txtMaXP.Name = "txtMaXP";
            this.txtMaXP.Size = new System.Drawing.Size(100, 20);
            this.txtMaXP.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã ĐVHC:";
            // 
            // txtTenXP
            // 
            this.txtTenXP.EnterMoveNextControl = true;
            this.txtTenXP.Location = new System.Drawing.Point(99, 73);
            this.txtTenXP.Name = "txtTenXP";
            this.txtTenXP.Size = new System.Drawing.Size(288, 20);
            this.txtTenXP.TabIndex = 5;
            // 
            // txtTenTat
            // 
            this.txtTenTat.EnterMoveNextControl = true;
            this.txtTenTat.Location = new System.Drawing.Point(99, 99);
            this.txtTenTat.Name = "txtTenTat";
            this.txtTenTat.Size = new System.Drawing.Size(100, 20);
            this.txtTenTat.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Quận, huyện:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên phường, xã:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(54, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Tên tắt:";
            // 
            // cboQuanHuyen
            // 
            this.cboQuanHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanHuyen.FormattingEnabled = true;
            this.cboQuanHuyen.Location = new System.Drawing.Point(99, 46);
            this.cboQuanHuyen.Name = "cboQuanHuyen";
            this.cboQuanHuyen.Size = new System.Drawing.Size(288, 21);
            this.cboQuanHuyen.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(87, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(168, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(249, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Quay ra";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmXaPhuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 188);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboQuanHuyen);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTenTat);
            this.Controls.Add(this.txtTenXP);
            this.Controls.Add(this.txtMaXP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmXaPhuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phường xã";
            this.Load += new System.EventHandler(this.FrmXaPhuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingQuanHuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaXP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenXP;
        private DevExpress.XtraEditors.TextEdit txtTenTat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboQuanHuyen;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource bindingQuanHuyen;
    }
}
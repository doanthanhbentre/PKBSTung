using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PKDK.KhamBenh
{
    public partial class FrmListTaiKham : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DotKham dotKham = new QLPK.DataAccess.DotKham();
        public FrmListTaiKham()
        {
            InitializeComponent();
        }

        private void FrmListTaiKham_Load(object sender, EventArgs e)
        {
            txtNgay.EditValue = DateTime.Today;
            btnRefresh_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = dotKham.getListTaiKham(DateTime.Parse(txtNgay.EditValue.ToString()));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangKyKham_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                FrmPhieuKham frm = new FrmPhieuKham();
                frm.MaBN = drv["MaBN"].ToString();
                frm.ShowDialog();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnDangKyKham_Click(null, null);
        }
    }
}
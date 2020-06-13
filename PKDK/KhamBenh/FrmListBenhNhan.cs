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
    public partial class FrmListBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
        public FrmListBenhNhan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListBenhNhan_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = benhNhan.getDataTable();
        }

        private void btnDangKyKham_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                FrmPhieuKham frm = new FrmPhieuKham();
                frm.MaBN = drv["MaBN"].ToString();
                this.DestroyHandle();
                frm.ShowDialog();
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnDangKyKham_Click(null, null);
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTongSo.Text = bindingSource1.Count.ToString();
        }
    }
}
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

namespace PKDK.ChiPhi
{
    public partial class FrmListDaThu : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiPhi chiPhi = new QLPK.DataAccess.ChiPhi();
        public FrmListDaThu()
        {
            InitializeComponent();
        }

        private void FrmListChuaThu_Load(object sender, EventArgs e)
        {
            txtTuNgay.EditValue = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.EditValue = DateTime.Today;
            btnRefresh_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = chiPhi.listDaThu(DateTime.Parse(txtTuNgay.EditValue.ToString()), DateTime.Parse(txtDenNgay.EditValue.ToString()));
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnThanhToan.Enabled = bindingSource1.Count > 0;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            FrmChiPhi frm = new FrmChiPhi();
            frm.DotKhamID = drv["DotKhamID"].ToString();
            frm.HoTen = drv["HoTen"].ToString();
            frm.ShowDialog();
            btnRefresh_Click(null, null);
        }
    }
}
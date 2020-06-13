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
using DevExpress.XtraReports.UI;
namespace PKDK.ChiPhi
{
    public partial class FrmChiPhi : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        QLPK.DataAccess.PhieuThu phieuThu = new QLPK.DataAccess.PhieuThu();
        String m_DotKhamID, m_MaPT;

        public FrmChiPhi()
        {
            InitializeComponent();
        }

        public string DotKhamID
        {
            get
            {
                return m_DotKhamID;
            }

            set
            {
                m_DotKhamID = value;
            }
        }
        public string HoTen
        {
            get
            {
                return lblHoTen.Text;
            }
            set
            {
                lblHoTen.Text = value;
            }
        }
        private void FrmChiPhi_Load(object sender, EventArgs e)
        {
            bindingDichVu.DataSource = chiDinh.getDataTable(DotKhamID, "");
            ucChiPhi1.loadData(DotKhamID);
            btnThanhToan.Enabled = ucChiPhi1.ChuaThu > 0;
            txtNgay.EditValue = DateTime.Today;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            m_MaPT = phieuThu.saveData("", DotKhamID, DateTime.Parse(txtNgay.EditValue.ToString()), QLPK.DataAccess.NguoiDung.TenDangNhap, ucChiPhi1.ChuaThu, Double.Parse(txtSoTienGiam.EditValue.ToString()), txtLyDoGiam.Text);
            FrmChiPhi_Load(null, null);
            btnPrint_Click(null, null);
        }

         private void mnuHuyPhieuThu_Click(object sender, EventArgs e)
        {
            DataRowView drv1 = (DataRowView)bindingDichVu.Current;
            if (drv1["MaPT"] != DBNull.Value)
            {
                chiDinh.updateMaPT(DotKhamID, drv1["MaPT"].ToString());
                phieuThu.deleteData(drv1["MaPT"].ToString());
                FrmChiPhi_Load(null, null);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDichVu.Current;
            if (drv != null && drv["MaPT"] != DBNull.Value) m_MaPT = drv["MaPT"].ToString();
        }

        private void bindingDichVu_CurrentChanged(object sender, EventArgs e)
        {
            gridControl1_Click(null, null);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            PhieuThu report = new PhieuThu();
            report.DataSource = phieuThu.getPhieuThu(m_MaPT).DefaultView;
            report.Parameters["pThuNgan"].Value = QLPK.DataAccess.NguoiDung.HoTen;
            report.Parameters["pMaPT"].Value = m_MaPT;
            report.Print();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmInPhieuThu frm = new FrmInPhieuThu();
            frm.loadData(m_MaPT);
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
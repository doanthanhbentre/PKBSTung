using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace PKDK
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        QLPK.DataAccess.SoKhamBenh soKhamBenh = new QLPK.DataAccess.SoKhamBenh();
        public FrmMain()
        {
            InitializeComponent();
        }
        private string getThu()
        {
            String m_Thu = "";
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    m_Thu = "thứ Sáu";
                    break;
                case DayOfWeek.Monday:
                    m_Thu = "thứ Hai";
                    break;
                case DayOfWeek.Saturday:
                    m_Thu = "thứ Bảy";
                    break;
                case DayOfWeek.Sunday:
                    m_Thu = "Chủ nhật";
                    break;
                case DayOfWeek.Thursday:
                    m_Thu = "thứ Năm";
                    break;
                case DayOfWeek.Tuesday:
                    m_Thu = "thứ Ba";
                    break;
                case DayOfWeek.Wednesday:
                    m_Thu = "thứ Tư";
                    break;
            }
            return m_Thu;
        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmLogin frm = new HeThong.FrmLogin();
            if (frm.ShowDialog() != DialogResult.OK) Close();
            stsTenDangNhap.Caption = QLPK.DataAccess.NguoiDung.HoTen;
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmChangePassword frm = new HeThong.FrmChangePassword();
            if (frm.ShowDialog() == DialogResult.OK) btnDangXuat_ItemClick(null, null);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Background.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        // Attempt to cast the control to type MdiClient.
            //        ctlMDI = (MdiClient)ctl;

            //        // Set the BackColor of the MdiClient control.
            //        ctlMDI.BackColor = this.BackColor;
            //    }
            //    catch (InvalidCastException exc)
            //    {
            //        // Catch and ignore the error if casting failed.
            //    }
            //}
            ribbonControl1.SelectedPage = ribbonKhamBenh;
            stsHomNay.Caption = String.Format("Hôm nay, {0} ngày {1} tháng {2} năm {3}", getThu(), DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            btnDangXuat_ItemClick(null, null);
        }

        private void btnKhaiBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmCreateUsers frm = new HeThong.FrmCreateUsers();
            frm.ShowDialog();
        }

        private void btnBacSi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmBacSi frm = new ThietLap.FrmBacSi();
            frm.ShowDialog();
        }

        private void btnPhongKham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmPhongKham frm = new ThietLap.FrmPhongKham();
            frm.ShowDialog();
        }

        private void btnBenhTat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmBenh frm = new ThietLap.FrmBenh();
            frm.ShowDialog();
        }

        private void btnDVHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmDVHC frm = new ThietLap.FrmDVHC();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmGiaDichVu frm = new ThietLap.FrmGiaDichVu();
            frm.LoaiDVID = "04";
            frm.TenLoaiDV = "Dịch vụ KCB";
            frm.ShowDialog();
        }

        private void btnCDHA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmGiaDichVu frm = new ThietLap.FrmGiaDichVu();
            frm.LoaiDVID = "02";
            frm.TenLoaiDV = "Chẩn đoán hình ảnh";
            frm.ShowDialog();
        }

        private void btnXetNghiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmGiaDichVu frm = new ThietLap.FrmGiaDichVu();
            frm.LoaiDVID = "03";
            frm.TenLoaiDV = "Xét nghiệm";
            frm.ShowDialog();
        }

        private void btnGoiXN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmChiTietGoiDV frm = new ThietLap.FrmChiTietGoiDV();
            frm.LoaiDVID = "03";
            frm.ShowDialog();
        }

        private void btnThongTinKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhamBenh.FrmListKhamBenh frm = new KhamBenh.FrmListKhamBenh();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDnhSachBN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhamBenh.FrmListBenhNhan frm = new KhamBenh.FrmListBenhNhan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDanhSachTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhamBenh.FrmListTaiKham frm = new KhamBenh.FrmListTaiKham();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnSoKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmThoiGian frm = new HeThong.FrmThoiGian();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhamBenh.FrmInSoKhamBenh_A1 frmA1 = new KhamBenh.FrmInSoKhamBenh_A1();
                frmA1.WindowState = FormWindowState.Maximized;
                frmA1.TuNgay = frm.TuNgay;
                frmA1.DenNgay = frm.DenNgay;
                frmA1.ShowDialog();
            }
        }

        private void btnThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmThuoc frm = new ThietLap.FrmThuoc();
            frm.LoaiDVID = "01";
            frm.TenLoaiDV = "Thuốc, hóa chất";
            frm.ShowDialog();
        }

        private void btnMauDonThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmDonThuocMau frm = new ThietLap.FrmDonThuocMau();
            frm.ShowDialog();
        }

        private void btnDnhSachChoThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChiPhi.FrmListChuaThu frm = new ChiPhi.FrmListChuaThu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDanhSachDaThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChiPhi.FrmListDaThu frm = new ChiPhi.FrmListDaThu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnThuDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChiPhi.FrmMatKhau frmMT = new ChiPhi.FrmMatKhau();
            if (frmMT.ShowDialog() == DialogResult.OK)
            {
                HeThong.FrmThoiGian tg = new HeThong.FrmThoiGian();
                if (tg.ShowDialog() == DialogResult.OK)
                {
                    ChiPhi.FrmInTKDichVu frm = new ChiPhi.FrmInTKDichVu();
                    frm.loadData(tg.TuNgay, tg.DenNgay, tg.ThoiGian);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                }
            }
        }

        private void btnThuNguoiBenh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChiPhi.FrmMatKhau frmMT = new ChiPhi.FrmMatKhau();
            if (frmMT.ShowDialog() == DialogResult.OK)
            {
                HeThong.FrmThoiGian tg = new HeThong.FrmThoiGian();
                if (tg.ShowDialog() == DialogResult.OK)
                {
                    ChiPhi.FrmInTKBenhNhan frm = new ChiPhi.FrmInTKBenhNhan();
                    frm.loadData(tg.TuNgay, tg.DenNgay, tg.ThoiGian);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                }
            }
        }

        private void btnThuThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmThoiGian tg = new HeThong.FrmThoiGian();
            if (tg.ShowDialog() == DialogResult.OK)
            {
                ChiPhi.FrmInTKThuoc frm = new ChiPhi.FrmInTKThuoc();
                frm.loadData(tg.TuNgay, tg.DenNgay, tg.ThoiGian);
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
        }

        private void btnSoCLS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhamBenh.FrmChonSoCLS frm = new KhamBenh.FrmChonSoCLS();
            frm.ShowDialog();
        }

        private void btnSoKSK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmThoiGian frm = new HeThong.FrmThoiGian();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                KhamBenh.SoKhamBenh_A1 report = new KhamBenh.SoKhamBenh_A1();
                report.DataSource = soKhamBenh.soKSK(frm.TuNgay, frm.DenNgay).DefaultView;
                report.Parameters["pTieuDe"].Value = "SỔ KHÁM BẢO HIỂM NHÂN THỌ";
                report.ShowPreviewDialog();
            }
        }

        private void btnGoiKSK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThietLap.FrmGoiKSK frm = new ThietLap.FrmGoiKSK();
            frm.ShowDialog();
        }

        private void btnBienBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.FrmThoiGian frm = new HeThong.FrmThoiGian();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataView dv = soKhamBenh.bienBanDoiChieu(frm.TuNgay, frm.DenNgay).DefaultView;
                long tongSoTien = 0, soTien = 0;
                foreach (DataRowView drv in dv)
                {
                    soTien = long.Parse(drv["SoTien"].ToString()) + long.Parse(drv["SoTienPS"].ToString());
                    tongSoTien += long.Parse(soTien.ToString());
                }
                LibNumRead.NumRead doc = new LibNumRead.NumRead();
                KhamBenh.SoKSK report = new KhamBenh.SoKSK();
                report.DataSource = dv;
                report.Parameters["pThoiGian"].Value = frm.ThoiGian;
                report.Parameters["pBangChu"].Value = doc.VNDRead(tongSoTien) + " đồng";
                report.ShowPreviewDialog();
            }
        }
    }
}

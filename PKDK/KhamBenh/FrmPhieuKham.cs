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
    public partial class FrmPhieuKham : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
        QLPK.DataAccess.DotKham dotKham = new QLPK.DataAccess.DotKham();
        QLPK.DataAccess.PhongKham phongKham = new QLPK.DataAccess.PhongKham();
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        QLPK.DataAccess.DonThuoc donThuoc = new QLPK.DataAccess.DonThuoc();
        QLPK.DataAccess.BacSi bacSi = new QLPK.DataAccess.BacSi();
        QLPK.DataAccess.DonThuocMau chiTietMau = new QLPK.DataAccess.DonThuocMau();
        QLPK.DataAccess.ChiTietGoiDV ctGoiDV = new QLPK.DataAccess.ChiTietGoiDV();
        QLPK.DataAccess.DVHC dvhc = new QLPK.DataAccess.DVHC();
        QLPK.DataAccess.PhieuDichVu phieuDichVu = new QLPK.DataAccess.PhieuDichVu();
        DataAccess.SanPham sanPham = new DataAccess.SanPham();
        String m_DotKhamID = String.Empty;
        DateTime m_NgayKham = DateTime.Today;
        QLPK.DataAccess.ThongTinPK m_ThongTinPK;
        String m_TenDangNhap = String.Empty;
        Boolean m_DangKyKham = false;
        public Boolean DangKyKham
        {
            get { return m_DangKyKham; }
            set { m_DangKyKham = value; }
        }

        public QLPK.DataAccess.ThongTinPK TTPK
        {
            get { return m_ThongTinPK; }
            set { m_ThongTinPK = value; }
        }
        public DateTime NgayKham
        {
            get { return m_NgayKham; }
            set { m_NgayKham = value; }
        }
        public String DotKhamID
        {
            get { return m_DotKhamID; }
            set { m_DotKhamID = value; }
        }
        public FrmPhieuKham()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            loadDotKham();
            loadChiTietDon();
            ucChiPhi1.loadData(DotKhamID);
            bindingSanPham.DataSource = sanPham.getDataTable();
        }
        private void loadChiTietDon()
        {
            bindingDonThuoc.DataSource = donThuoc.getDataTable(DotKhamID);
        }
        private Boolean kiemTra()
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập họ tên bệnh nhân!", "Khám bệnh");
                txtHoTen.Focus();
                return false;
            }
            if (cboPhongKham.ItemIndex == -1)
            {
                MessageBox.Show("Chưa chọn phòng khám!", "Khám bệnh");
                cboPhongKham.Focus();
                return false;
            }
            if (cboBacSi.ItemIndex == -1)
            {
                MessageBox.Show("Chưa chọn Bác sĩ!", "Khám bệnh");
                cboBacSi.Focus();
                return false;
            }
            return true;
        }
        private void showSTT()
        {
            DataRow dr = dotKham.getDataRow(DotKhamID);
            if (dr != null)
                txtSoTT.Text = dr["STT"].ToString();
            else
                txtSoTT.Text = "";
        }
        private void newData()
        {
            txtMaBN.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            m_DotKhamID = "";
            txtSoTT.Text = "";
            txtChanDoan.Text = "";
            txtMach.Text = "";
            txtNhietDo.Text = "";
            txtHuyetAp.Text = "";
            txtDienThoai.Text = "";
            NgayKham = DateTime.Today;
            txtTaiKhamSau.EditValue = 0;
            lblNgayTK.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void FrmPhieuKham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadCacLanKham()
        {
            treeView1.Nodes.Clear();
            bindingCacLanKham.DataSource = dotKham.getDataTable(txtMaBN.Text).DefaultView;
            treeView1.Nodes.Add("", "Các lần đến khám", 0);
            Int32 i = -1;
            String value = String.Empty;
            foreach (DataRowView drv in bindingCacLanKham)
            {
                if (value != drv["DotKhamID"].ToString())
                {
                    value = drv["DotKhamID"].ToString();
                    DateTime ngay = DateTime.Parse(drv["Ngay"].ToString());
                    treeView1.Nodes[0].Nodes.Add(drv["DotKhamID"].ToString(), ngay.ToString("dd/MM/yyyy"), 1);
                    treeView1.Nodes[0].Tag = drv["DotKhamID"].ToString();
                    i++;
                }

                treeView1.Nodes[0].Nodes[i].Nodes.Add(drv["DotKhamID"].ToString(), drv["TenPhongKham"].ToString(), 2);
                if (drv["ChanDoan"].ToString() != "")
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(drv["DotKhamID"].ToString(), drv["ChanDoan"].ToString(), 3);

                treeView1.Nodes[0].Nodes[i].Tag = drv["DotKhamID"].ToString();
            }
            //treeView1.ExpandAll();
            treeView1.Nodes[0].Expand();
        }
        private void FrmPhieuKham_Load(object sender, EventArgs e)
        {
            lblNgayTK.Text = DateTime.Today.ToString("dd/MM/yyyy");
            loadBacSi();
            loadPhongKham();
            loadData();
            loadCacLanKham();
        }

        private void btnCachDung_Click(object sender, EventArgs e)
        {
            FrmLieuDung frm = new FrmLieuDung();
            frm.DonVi = txtDonVi.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCachDung.Text = frm.LieuDung;
                SendKeys.Send("{Tab}");
            }
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            ThietLap.FrmBacSi frm = new ThietLap.FrmBacSi();
            frm.ShowDialog();
            loadBacSi();
        }

        private void btnGetBenhTat_Click(object sender, EventArgs e)
        {
            KhamBenh.FrmChonBenh frm = new FrmChonBenh();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtChanDoan.Text = frm.TenBenh;
                SendKeys.Send("{Tab}");
            }

        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            if (txtMaBN.Text.Trim().Length == 0)
            {
                QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
                DataView dv = benhNhan.getDataTable(txtHoTen.Text.Trim()).DefaultView;
                if (dv.Count > 0)
                {
                    if (txtHoTen.Text.Trim().Length > 0)
                    {
                        FrmChonBenhNhan frm = new FrmChonBenhNhan();
                        frm.TenBenhNhan = txtHoTen.Text.Trim();
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtMaBN.Text = frm.MaBN;
                            txtMaBN_Validated(null, null);
                            txtChanDoan.Focus();
                        }
                    }
                }
            }
        }
        private void loadBenhNhan()
        {
            DataRow dr = benhNhan.getDataRow(txtMaBN.Text);
            if (dr != null)
            {

                txtHoTen.Text = dr["HoTen"].ToString();
                txtNamSinh.Value = Decimal.Parse(dr["NamSinh"].ToString());
                cboGioiTinh.SelectedIndex = Int32.Parse(dr["GioiTinh"].ToString());
                txtDiaChi.Text = dr["DiaChi"].ToString();
                txtDienThoai.Text = dr["DienThoai"].ToString();
            }
            else
            {
                txtMaBN.Text = "";
                txtHoTen.Text = "";
                cboGioiTinh.SelectedIndex = 0;
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
            }
        }

        private void txtMaBN_Validated(object sender, EventArgs e)
        {
            Int32 value = txtMaBN.Text.Trim().Length;
            if (value > 0 && value < 7)
                txtMaBN.Text = DateTime.Today.ToString("yy") + txtMaBN.Text.Trim().PadLeft(6, '0');
            if (txtMaBN.Text.Trim().Length == 0) newData();
            loadBenhNhan();
            loadCacLanKham();
            loadData();
        }

        private void loadPhongKham()
        {
            bindingPhongKham.DataSource = phongKham.getDataTable().DefaultView;
            if (bindingPhongKham.Count > 0)
                cboPhongKham.ItemIndex = 0;
        }
        private void loadBacSi()
        {
            bindingBacSi.DataSource = bacSi.getDataTable().DefaultView;
            if (bindingBacSi.Count > 0)
                cboBacSi.ItemIndex = 0;
        }
        private void saveDotKham()
        {
            if (!kiemTra()) return;
            String m_MaBN = txtMaBN.Text;
            txtMaBN.Text = benhNhan.saveData(m_MaBN, txtHoTen.Text, txtNamSinh.Value, cboGioiTinh.SelectedIndex, txtDiaChi.Text, txtDienThoai.Text);
            DotKhamID = dotKham.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), NgayKham, cboBacSi.EditValue.ToString(), txtMaBN.Text, txtChanDoan.Text, txtMach.Text, txtHuyetAp.Text, txtNhietDo.Text);
            if (Int16.Parse(txtTaiKhamSau.EditValue.ToString()) > 0)
                dotKham.updateNgayTaiKham(DotKhamID, DateTime.Today.AddDays(Int16.Parse(txtTaiKhamSau.EditValue.ToString())));
            showSTT();
            loadData();
            loadCacLanKham();
        }

        private void btnSaveThuoc_Click(object sender, EventArgs e)
        {
            saveDotKham();
            donThuoc.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), txtTenSP.EditValue.ToString(), float.Parse(txtSoLuong.EditValue.ToString()), float.Parse(txtDonGia.Text.ToString()), txtCachDung.Text);
            loadChiTietDon();
            ucChiPhi1.loadData(DotKhamID);
            btnNewThuoc.Focus();
        }
        private void loadDotKham()
        {
            DataRow dr = dotKham.getDataRow(DotKhamID);
            if (dr != null)
            {
                txtMaBN.Text = dr["MaBN"].ToString();
                cboPhongKham.EditValue = dr["PhongKhamID"];
                cboBacSi.EditValue = dr["MaBS"];
                txtChanDoan.Text = dr["ChanDoan"].ToString();
                NgayKham = DateTime.Parse(dr["Ngay"].ToString());
                txtMach.Text = dr["Mach"].ToString();
                txtHuyetAp.Text = dr["HuyetAp"].ToString();
                txtNhietDo.Text = dr["NhietDo"].ToString();
                txtSoTT.Text = dr["STT"].ToString();
                if (dr["NgayTK"] != DBNull.Value)
                    lblNgayTK.Text = DateTime.Parse(dr["NgayTK"].ToString()).ToString("dd/MM/yyyy");
            }
            else
            {
                txtChanDoan.Text = "";
                NgayKham = DateTime.Today;
                txtMach.Text = "";
                txtHuyetAp.Text = "";
                txtNhietDo.Text = "";
                txtSoTT.Text = "";
            }
            loadBenhNhan();
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            DataView dv = dvhc.getDVHC(txtDiaChi.Text.Trim()).DefaultView;
            Int32 index = dv.Count;
            if (index == 1)
            {
                DataRowView drv = (DataRowView)dv[0];
                txtDiaChi.Text = drv["TenDVHC"].ToString();
            }
            if (index > 1)
            {
                FrmChonDVHC frm = new FrmChonDVHC();
                frm.setData(dv);
                if (frm.ShowDialog() == DialogResult.OK)
                    txtDiaChi.Text = frm.TenDVHC;
            }
        }

        private void txtTaiKhamSau_EditValueChanged(object sender, EventArgs e)
        {
            lblNgayTK.Text = DateTime.Today.AddDays(Int16.Parse(txtTaiKhamSau.EditValue.ToString())).ToString("dd/MM/yyyy");
        }

        private void btnBenhNhanMoi_Click(object sender, EventArgs e)
        {
            newData();
            loadCacLanKham();
            txtMaBN.Focus();
        }

        private void btnNewThuoc_Click(object sender, EventArgs e)
        {
            txtTenSP.ShowPopup();
        }

        private void btnChiDinh_Click(object sender, EventArgs e)
        {
            if (DotKhamID.Length > 0)
            {
                FrmChiDinh frm = new FrmChiDinh();
                frm.showBenhNhan(txtMaBN.Text, txtHoTen.Text, txtNamSinh.EditValue.ToString(), cboGioiTinh.Text, txtChanDoan.Text);
                frm.DotKhamID = DotKhamID;
                frm.PhongKhamID = cboPhongKham.EditValue.ToString();
                frm.ShowDialog();
                ucChiPhi1.loadData(DotKhamID);
            }
        }

        private void btnDonMau_Click(object sender, EventArgs e)
        {
            FrmChonDonMau frm = new FrmChonDonMau();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                saveDotKham();
                DataView dv = chiTietMau.getDataTable(frm.BenhID).DefaultView;
                foreach (DataRowView drv in dv)
                {
                    donThuoc.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["MaSP"].ToString(), float.Parse(drv["SoLuong"].ToString()), float.Parse(drv["GiaXuat"].ToString()), drv["CachDung"].ToString());
                }
                loadChiTietDon();
            }
        }

        private void txtTenSP_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenSP.EditValue != null)
            {
                DataRowView drv = (DataRowView)bindingSanPham[bindingSanPham.Find("MASP", txtTenSP.EditValue.ToString())];
                if (drv != null)
                {
                    txtDonGia.Text = drv["GiaXuat"].ToString();
                    txtDonVi.Text = drv["TenDonVi"].ToString();
                }
                else
                {
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
            }
        }

        private void btnDeleteThuoc_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDonThuoc.Current;
            if (drv != null)
            {
                donThuoc.deleteData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["MaSP"].ToString());
                loadChiTietDon();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ChiPhi.FrmChiPhi frm = new ChiPhi.FrmChiPhi();
            frm.DotKhamID = DotKhamID;
            frm.HoTen = txtHoTen.Text;
            frm.ShowDialog();
            ucChiPhi1.loadData(DotKhamID);
        }

        private void btnPrintThuoc_Click(object sender, EventArgs e)
        {
            FrmInDonThuoc frm = new FrmInDonThuoc();
            frm.loadData(DotKhamID);
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void bindingDonThuoc_ListChanged(object sender, ListChangedEventArgs e)
        {
            ucChiPhi1.loadData(DotKhamID);
        }

        private void btnCopyDon_Click(object sender, EventArgs e)
        {
            FrmDonTruoc frm = new FrmDonTruoc();
            frm.MaBN = txtMaBN.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                saveDotKham();
                DataView dv = donThuoc.getDataTable(frm.DotKhamID).DefaultView;
                foreach (DataRowView drv in dv)
                {
                    donThuoc.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["MaSP"].ToString(), float.Parse(drv["SoLuong"].ToString()), float.Parse(drv["DonGia"].ToString()), drv["CachDung"].ToString());
                }
                loadChiTietDon();
                ucChiPhi1.loadData(DotKhamID);
            }

        }

        private void btnListBN_Click(object sender, EventArgs e)
        {
            FrmChonBenhNhan frm = new FrmChonBenhNhan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMaBN.Text = frm.MaBN;
                txtMaBN_Validated(null, null);
                txtChanDoan.Focus();
            }
        }
    }
}
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

namespace PKDK.KhamBenh
{
    public partial class FrmPhieuKham : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
        QLPK.DataAccess.DotKham dotKham = new QLPK.DataAccess.DotKham();
        QLPK.DataAccess.PhongKham phongKham = new QLPK.DataAccess.PhongKham();
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        QLPK.DataAccess.BacSi bacSi = new QLPK.DataAccess.BacSi();
        QLPK.DataAccess.DonThuocMau chiTietMau = new QLPK.DataAccess.DonThuocMau();
        QLPK.DataAccess.ChiTietGoiDV ctGoiDV = new QLPK.DataAccess.ChiTietGoiDV();
        QLPK.DataAccess.DVHC dvhc = new QLPK.DataAccess.DVHC();
        QLPK.DataAccess.PhieuDichVu phieuDichVu = new QLPK.DataAccess.PhieuDichVu();
        QLPK.DataAccess.GiaDichVu giaDichVu = new QLPK.DataAccess.GiaDichVu();
        QLPK.DataAccess.GoiKSK goiKSK = new QLPK.DataAccess.GoiKSK();
        String m_DotKhamID = String.Empty;
        DateTime m_NgayKham = DateTime.Today;
        QLPK.DataAccess.ThongTinPK m_ThongTinPK;
        String m_TenDangNhap = String.Empty;
        Boolean m_DangKyKham = false;
        String m_MaBN = String.Empty;

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

        public string MaBN
        {
            get
            {
                return m_MaBN;
            }

            set
            {
                m_MaBN = value;
            }
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
            bindingGiaDichVu.DataSource = giaDichVu.getDataTable("01");
            if (DotKhamID == "")
            {
                txtChanDoan.Text = dotKham.getChanDoanCuoi(txtMaBN.Text);
            }
            bindingGoiKSK.DataSource = goiKSK.getDataTable().DefaultView;
        }
        private void loadChiTietDon()
        {
            bindingDonThuoc.DataSource = chiDinh.getDataTable(DotKhamID, "01");
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
            chkBaoHiem.Checked = false;
            NgayKham = DateTime.Today;
            txtTaiKhamSau.EditValue = 0;
            lblNgayTK.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }
        private void FrmPhieuKham_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
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
                if (drv["GhiChu"].ToString() != "")
                    treeView1.Nodes[0].Nodes[i].Nodes.Add(drv["DotKhamID"].ToString(), "Ghi chú: " + drv["GhiChu"].ToString(), 4);

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
            if (MaBN.Length > 0)
            {
                txtMaBN.Text = MaBN;
                txtMaBN_Validated(null, null);
            }
            else
            {
                loadData();
                loadCacLanKham();
            }
        }

        private void btnCachDung_Click(object sender, EventArgs e)
        {
            FrmLieuDung frm = new FrmLieuDung();
            frm.DonVi = txtDonVi.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCachDung.Text = frm.LieuDung;
                if (txtCachDung.Text.Trim().Length > 0)
                    giaDichVu.updateCachDung(txtTenSP.EditValue.ToString(), txtCachDung.Text);
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
            dotKham.updateNgayTaiKham(DotKhamID, Int32.Parse(txtTaiKhamSau.EditValue.ToString()));
            dotKham.updateGhiChu(DotKhamID, txtGhiChu.Text);
            dotKham.updateLoiDan(DotKhamID, txtLoiDan.Text);
            if (chkBaoHiem.Checked)
            {
                if (cboGoiKSK.EditValue == null || cboGoiKSK.EditValue.ToString().Length == 0)
                {
                    MessageBox.Show("Chưa chọn gói khám sức khỏe!");
                    cboGoiKSK.Focus();
                }
                else
                {
                    DataRowView drv = (DataRowView)bindingGoiKSK[bindingGoiKSK.Find("GoiKSKID", cboGoiKSK.EditValue)];
                    if (drv != null)
                        dotKham.updateBaoHiem(DotKhamID, 1, Int64.Parse(cboGoiKSK.EditValue.ToString()), double.Parse(drv["SoTien"].ToString()));
                }
            }
            else
                dotKham.updateBaoHiem(DotKhamID, 0, 0, 0);
            showSTT();
            loadData();
            loadCacLanKham();
        }

        private void btnSaveThuoc_Click(object sender, EventArgs e)
        {
            //if (DateTime.Compare(DateTime.Today, NgayKham.Date) != 0)
            //{
            //    MessageBox.Show("Không thể cập nhật đơn thuốc cũ!", "Khám bệnh");
            //    return;
            //}
            saveDotKham();
            if (txtTenSP.EditValue != null && txtSoLuong.Value > 0 && txtDonGia.Text.Length > 0)
                chiDinh.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), txtTenSP.EditValue.ToString(), float.Parse(txtSoLuong.EditValue.ToString()), float.Parse(txtDonGia.Text.ToString()), txtCachDung.Text);
            loadChiTietDon();
            ucChiPhi1.loadData(DotKhamID);
            btnNewThuoc_Click(null, null);
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
                txtGhiChu.Text = dr["GhiChu"].ToString();
                txtLoiDan.Text = dr["LoiDan"].ToString();
                chkBaoHiem.Checked = dr["BaoHiem"].ToString() == "1" ? true : false;
                cboGoiKSK.EditValue = dr["GoiKSKID"];
                if (dr["NgayTK"] != DBNull.Value)
                {

                    lblNgayTK.Text = DateTime.Parse(dr["NgayTK"].ToString()).ToString("dd/MM/yyyy");
                }
            }
            else
            {
                txtChanDoan.Text = "";
                NgayKham = DateTime.Today;
                txtMach.Text = "";
                txtHuyetAp.Text = "";
                txtNhietDo.Text = "";
                txtSoTT.Text = "";
                txtGhiChu.Text = "";
                txtLoiDan.Text = "";
                chkBaoHiem.Checked = false;
            }
            loadBenhNhan();
        }

        private void txtDiaChi_Validated(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Trim().Length == 0) return;
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
            btnNewThuoc_Click(null, null);
            newData();
            loadCacLanKham();
            loadChiTietDon();
            txtMaBN.Focus();
        }

        private void btnNewThuoc_Click(object sender, EventArgs e)
        {
            txtCachDung.Text = "";
            txtTenSP.EditValue = "";
            txtSoLuong.Value = 0;
            txtDonGia.Text = "";
            txtDonVi.Text = "";
            txtTenSP.Focus();
            //txtTenSP.ShowPopup();
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
                    chiDinh.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["GIADVID"].ToString(), float.Parse(drv["SoLuong"].ToString()), float.Parse(drv["DONGIA"].ToString()), drv["CachDung"].ToString());
                }
                loadChiTietDon();
            }
        }

        private void txtTenSP_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenSP.EditValue != null)
            {
                Int32 index = bindingGiaDichVu.Find("GIADVID", txtTenSP.EditValue.ToString());
                if (index >= 0)
                {
                    DataRowView drv = (DataRowView)bindingGiaDichVu[index];
                    if (drv != null)
                    {
                        txtDonGia.Text = drv["DonGia"].ToString();
                        txtDonVi.Text = drv["DonVi"].ToString();
                        txtCachDung.Text = drv["CachDung"].ToString();
                    }
                    else
                    {
                        txtDonVi.Text = "";
                        txtDonGia.Text = "";
                        txtCachDung.Text = "";
                    }
                }
            }
        }

        private void btnDeleteThuoc_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDonThuoc.Current;
            if (drv != null)
            {
                chiDinh.deleteData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["GIADVID"].ToString());
                loadChiTietDon();
                btnNewThuoc_Click(null, null);
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
            DonThuocUngBuou report = new DonThuocUngBuou();
            report.DataSource = chiDinh.getDonThuoc(DotKhamID).DefaultView;
            report.Parameters["pSoTien"].Value = Math.Round(ucChiPhi1.TongSoTien / 1000, 0).ToString();
            report.ShowPreviewDialog();
        }

        private void bindingDonThuoc_ListChanged(object sender, ListChangedEventArgs e)
        {
            ucChiPhi1.loadData(DotKhamID);
            lblTongSoThuoc.Text = bindingDonThuoc.Count.ToString();
        }

        private void btnCopyDon_Click(object sender, EventArgs e)
        {
            FrmDonTruoc frm = new FrmDonTruoc();
            frm.MaBN = txtMaBN.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                saveDotKham();
                DataView dv = chiDinh.getDataTable(frm.DotKhamID, "01").DefaultView;
                foreach (DataRowView drv in dv)
                {
                    chiDinh.saveData(DotKhamID, cboPhongKham.EditValue.ToString(), drv["GIADVID"].ToString(), float.Parse(drv["SoLuong"].ToString()), float.Parse(drv["DonGia"].ToString()), drv["CachDung"].ToString());
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

        private void txtTaiKhamSau_Validated(object sender, EventArgs e)
        {
            btnSaveThuoc.Focus();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DotKhamID = e.Node.Tag.ToString();
            loadData();
        }

        private void btnBenhNhanLabel_Click(object sender, EventArgs e)
        {
            BenhNhanLabel report = new BenhNhanLabel();
            report.DataSource = benhNhan.getDataRow(txtMaBN.Text).Table;
            if (chkPrint.Checked)
                report.ShowPreviewDialog();
            else
                report.Print();
        }

        private void btnKetQuaCD_Click(object sender, EventArgs e)
        {
            FrmKetQuaCD frm = new FrmKetQuaCD();
            frm.MaBN = txtMaBN.Text;
            frm.ShowDialog();
        }

        private void lnkGiayGioiThieu_Click(object sender, EventArgs e)
        {
            FrmGiayGioiThieu frm = new FrmGiayGioiThieu();
            frm.MaBN = txtMaBN.Text;
            frm.DotKhamID = DotKhamID;
            frm.PhongKhamID = cboPhongKham.EditValue.ToString();
            frm.ShowDialog();
        }

        private void txtCachDung_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridThuoc_DoubleClick(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDonThuoc.Current;
            if (drv != null)
            {
                FrmUpdateCachDung frm = new FrmUpdateCachDung();
                frm.DotKhamID = DotKhamID;
                frm.PhongKhamID = cboPhongKham.EditValue.ToString();
                frm.GiaDVID = drv["GiaDVID"].ToString();
                frm.SoLuong = Decimal.Parse(drv["SoLuong"].ToString());
                frm.CachDung = drv["CachDung"].ToString();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadChiTietDon();
                }
            }
        }

        private void btnGetKetQua_Click(object sender, EventArgs e)
        {
            String m_KetQua = chiDinh.getKetQuaDotKham(DotKhamID);
            if (m_KetQua.Length > 0)
                txtChanDoan.Text += "/ " + m_KetQua;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            KhamBenh.FrmListBenhNhan frm = new KhamBenh.FrmListBenhNhan();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            this.DestroyHandle();
            frm.ShowDialog();
        }
    }
}
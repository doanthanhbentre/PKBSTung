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
    public partial class FrmChiDinh : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.LoaiDichVu loaiDV = new QLPK.DataAccess.LoaiDichVu();
        QLPK.DataAccess.GiaDichVu giaDichVu = new QLPK.DataAccess.GiaDichVu();
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        QLPK.DataAccess.ChiTietGoiDV chiTietGoi = new QLPK.DataAccess.ChiTietGoiDV();
        String m_DotKhamID, m_PhongKhamID;

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

        public string PhongKhamID
        {
            get
            {
                return m_PhongKhamID;
            }

            set
            {
                m_PhongKhamID = value;
            }
        }

        public FrmChiDinh()
        {
            InitializeComponent();
        }
        public void showBenhNhan(String maBN, String hoTen, String namSinh, String gioiTinh, String chanDoan)
        {
            lblMaBN.Text = maBN;
            lblHoTen.Text = hoTen;
            lblNamSinh.Text = namSinh;
            lblGioiTinh.Text = gioiTinh;
            lblChanDoan.Text = chanDoan;
        }
        private void loadLoaiDichVu()
        {
            bindingLoaiDichVu.DataSource = loaiDV.getDataTable().DefaultView;
        }
        private void loadGiaDichVu()
        {
            if (lstLoaiDichVu.SelectedValue != null)
                bindingGiaDichVu.DataSource = giaDichVu.getDataTable(lstLoaiDichVu.SelectedValue.ToString());
            else
                bindingGiaDichVu.DataSource = giaDichVu.getDataTable("");
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingLoaiDichVu_CurrentChanged(object sender, EventArgs e)
        {
            loadGiaDichVu();
            loadChiDinh();
            if (lstLoaiDichVu.SelectedValue != null && lstLoaiDichVu.SelectedValue.ToString() == "03")
                btnChonGoiXN.Visible = true;
            else
                btnChonGoiXN.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTenDV.ShowPopup();
        }

        private void FrmChiDinh_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenDV.EditValue != null)
            {
                DataRowView drv = (DataRowView)bindingGiaDichVu[bindingGiaDichVu.Find("GIADVID", txtTenDV.EditValue.ToString())];
                if (drv != null)
                {
                    chiDinh.saveData(DotKhamID, PhongKhamID, txtTenDV.EditValue.ToString(), Double.Parse(txtSoLuong.Value.ToString()), Double.Parse(drv["DonGia"].ToString()), "");
                    loadChiDinh();
                    btnNew.Focus();
                }
            }
        }
        private void loadChiDinh()
        {
            if (lstLoaiDichVu.SelectedValue != null)
                bindingChiDinh.DataSource = chiDinh.getDataTable(DotKhamID, lstLoaiDichVu.SelectedValue.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingChiDinh.Current;
            if (drv != null)
            {
                chiDinh.deleteData(DotKhamID, drv["GiaDVID"].ToString());
                loadChiDinh();
            }
        }

        private void txtTenDV_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTenDV.EditValue != null)
            {
                DataRowView drv = (DataRowView)bindingGiaDichVu[bindingGiaDichVu.Find("GIADVID", txtTenDV.EditValue.ToString())];
                if (drv != null)
                {
                    txtDonGia.Text = drv["DonGia"].ToString();
                    txtDonVi.Text = drv["DonVi"].ToString();
                }
                else
                {
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
            }
        }

        private void bindingChiDinh_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bindingChiDinh.Count > 0)
            {
                btnDelete.Enabled = true;
                btnPrintChiDinh.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnPrintChiDinh.Enabled = false;
            }
            Int32 m_SoTien = 0;
            foreach (DataRowView drv in bindingChiDinh)
            {
                m_SoTien += Int32.Parse(drv["ThanhTien"].ToString());
            }
            lblTongTien.Text = m_SoTien.ToString("#,###");
        }

        private void btnChonGoiXN_Click(object sender, EventArgs e)
        {
            FrmChonGoiXN frm = new FrmChonGoiXN();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DataView dv = chiTietGoi.getDataTable(frm.GoiDVID).DefaultView;
                foreach (DataRowView drv in dv)
                {
                    chiDinh.saveData(DotKhamID, PhongKhamID, drv["GiaDVID"].ToString(), 1, Double.Parse(drv["DonGia"].ToString()), "");
                    loadChiDinh();
                }
            }
        }

        private void btnPrintChiDinh_Click(object sender, EventArgs e)
        {
            PhieuChiDinh report = new PhieuChiDinh();
            report.DataSource = chiDinh.getPhieuChiDinh(DotKhamID, lstLoaiDichVu.SelectedValue.ToString()).DefaultView;
            report.Parameters["pTieuDe"].Value = "PHIẾU " + lstLoaiDichVu.Text.ToUpper();
            report.ShowPreviewDialog();
        }

        private void btnKetQuaCD_Click(object sender, EventArgs e)
        {
            FrmKetQuaCD frm = new FrmKetQuaCD();
            frm.MaBN = lblMaBN.Text;
            frm.ShowDialog();
        }

        private void FrmChiDinh_Load(object sender, EventArgs e)
        {
            loadLoaiDichVu();
            loadGiaDichVu();
        }
    }
}
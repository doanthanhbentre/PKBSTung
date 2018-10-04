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

namespace PKDK.ThietLap
{
    public partial class FrmDonThuocMau : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.SanPham sanPham = new DataAccess.SanPham();
        QLPK.DataAccess.Benh benh = new QLPK.DataAccess.Benh();
        QLPK.DataAccess.DonThuocMau donMau = new QLPK.DataAccess.DonThuocMau();
        public FrmDonThuocMau()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCachDung_Click(object sender, EventArgs e)
        {
            KhamBenh.FrmLieuDung frm = new KhamBenh.FrmLieuDung();
            frm.DonVi = txtDonVi.Text;
            if (frm.ShowDialog() == DialogResult.OK)
                txtCachDung.Text = frm.LieuDung;
            btnSave.Focus();

        }
        private void loadData()
        {
            bindingBenh.DataSource = benh.getDataTable();
            bindingSanPham.DataSource = sanPham.getDataTable();
        }
        private void loadDonThuoc()
        {
            DataRowView drv = (DataRowView)bindingBenh.Current;
            if (drv != null)
                bindingDonThuoc.DataSource = donMau.getDataTable(drv["BenhID"].ToString());
            else
                bindingDonThuoc.DataSource = donMau.getDataTable("");
        }
        private void FrmDonThuocMau_Load(object sender, EventArgs e)
        {
            loadData();
            loadDonThuoc();
        }

        private void FrmDonThuocMau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtSoLuong.EditValue = 0;
            txtTenSP.ShowPopup();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingBenh.Current;
            if (drv != null && txtTenSP.EditValue != null)
            {
                donMau.saveData(drv["BenhID"].ToString(), txtTenSP.EditValue.ToString(), txtCachDung.Text, Int16.Parse(txtSoLuong.EditValue.ToString()));
                loadDonThuoc();
            }
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDonThuoc.Current;
            if (drv != null)
            {
                donMau.deleteData(drv["BenhID"].ToString(), drv["MaSP"].ToString());
                loadDonThuoc();
            }
        }

        private void bindingBenh_CurrentChanged(object sender, EventArgs e)
        {
            loadDonThuoc();
        }

        private void bindingDonThuoc_ListChanged(object sender, ListChangedEventArgs e)
        {
            Int32 value = bindingDonThuoc.Count;
            btnDelete.Enabled = value > 0;
        }
    }
}
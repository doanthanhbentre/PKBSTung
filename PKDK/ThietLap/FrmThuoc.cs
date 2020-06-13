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
    public partial class FrmThuoc : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GiaDichVu giaDichVu = new QLPK.DataAccess.GiaDichVu();
        String m_LoaiDVID, m_TenLoaiDV;

        public FrmThuoc()
        {
            InitializeComponent();
        }

        public string LoaiDVID
        {
            get
            {
                return m_LoaiDVID;
            }

            set
            {
                m_LoaiDVID = value;
            }
        }

        private void FrmGiaDichVu_Load(object sender, EventArgs e)
        {
            this.Text = TenLoaiDV;
            lblTen.Text = "Tên " + TenLoaiDV.ToLower();
            loadData();
        }
        private void loadData()
        {
            bindingSource1.DataSource = giaDichVu.getDataTable(LoaiDVID);
            gridControl1.DataSource = bindingSource1;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            giaDichVu.deleteData(txtMaSo.Text);
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            giaDichVu.saveData(txtMaSo.Text, LoaiDVID, txtTen.Text, txtDonViTinh.Text, txtDonGia.Value, "", txtCachDung.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaSo.Text = "";
            txtTen.Text = "";
            //txtDonViTinh.Text = "";
            txtDonGia.Value = 0;
            txtTen.Focus();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                txtMaSo.Text = drv["GiaDVID"].ToString();
                txtTen.Text = drv["TenDV"].ToString();
                txtDonViTinh.Text = drv["DonVi"].ToString();
                txtDonGia.Value = Decimal.Parse(drv["DonGia"].ToString());
                txtCachDung.Text = drv["CachDung"].ToString();
            }
            else
            {
                txtMaSo.Text = "";
                txtTen.Text = "";
                //txtDonViTinh.Text = "";
                txtDonGia.Value = 0;
                txtCachDung.Text = "";
            }
        }

        private void FrmGiaDichVu_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnCachDung_Click(object sender, EventArgs e)
        {
            KhamBenh.FrmLieuDung frm = new KhamBenh.FrmLieuDung();
            frm.DonVi = txtDonViTinh.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCachDung.Text = frm.LieuDung;
                SendKeys.Send("{Tab}");
            }
        }

        public string TenLoaiDV
        {
            get
            {
                return m_TenLoaiDV;
            }

            set
            {
                m_TenLoaiDV = value;
            }
        }
    }
}
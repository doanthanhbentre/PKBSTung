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
    public partial class FrmGiaDichVu : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GiaDichVu giaDichVu = new QLPK.DataAccess.GiaDichVu();
        String m_LoaiDVID, m_TenLoaiDV;

        public FrmGiaDichVu()
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
            giaDichVu.saveData(txtMaSo.Text, LoaiDVID, txtTen.Text, txtDonViTinh.Text, txtDonGia.Value, "", "");
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
            }
            else
            {
                txtMaSo.Text = "";
                txtTen.Text = "";
                //txtDonViTinh.Text = "";
                txtDonGia.Value = 0;
            }
        }

        private void FrmGiaDichVu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
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
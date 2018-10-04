using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PKDK.ThietLap
{
    public partial class FrmGoiDichVu : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GoiDichVu goiDichVu = new QLPK.DataAccess.GoiDichVu();
        String m_LoaiDVID;

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

        public FrmGoiDichVu()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = goiDichVu.getDataTable(LoaiDVID).DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtGoiDVID.Text = "";
            txtTenGoi.Text = "";
            txtTenGoi.Focus();
        }

        private void FrmCreateUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                txtGoiDVID.Text = drv["GoiDVID"].ToString();
                txtTenGoi.Text = drv["TenGoiDV"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtTenGoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên gói dịch vụ!", "Gói dịch vụ");
                txtTenGoi.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            goiDichVu.saveData(txtGoiDVID.Text, LoaiDVID, txtTenGoi.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            goiDichVu.deleteData(txtGoiDVID.Text);
            loadData();
            btnNew.Focus();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
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
    public partial class FrmSanPham : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.SanPham sanPham = new DataAccess.SanPham();
        DataAccess.DonVi donVi = new DataAccess.DonVi();
        public FrmSanPham()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            bindingDonVi.DataSource = donVi.selectData();
            bindingSanPham.DataSource = sanPham.getDataTable();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaXuat.EditValue = 0;
            txtTenSP.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sanPham.saveData(txtMaSP.Text, "01", cboDonVi.EditValue.ToString(), "", txtTenSP.Text, "", "", 0, double.Parse(txtGiaXuat.Value.ToString()), 0);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sanPham.deleteData(txtMaSP.Text);
            loadData();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void FrmSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        private void cboDonVi_Enter(object sender, EventArgs e)
        {
            //cboDonVi.ShowPopup();
        }

        private void bindingSanPham_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSanPham.Current;
            if (drv != null)
            {
                txtMaSP.Text = drv["MaSP"].ToString();
                txtTenSP.Text = drv["TenSP"].ToString();
                txtGiaXuat.Text = drv["GiaXuat"].ToString();
                cboDonVi.EditValue = drv["DonViID"];
            }
            else btnNew_Click(null, null);
        }
    }
}
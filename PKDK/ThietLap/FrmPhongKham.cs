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
    public partial class FrmPhongKham : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.PhongKham phongKham = new QLPK.DataAccess.PhongKham();
        public FrmPhongKham()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = phongKham.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtPhongKhamID.Text = "";
            txtTenPhongKham.Text = "";
            txtTenPhongKham.Focus();
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
                txtPhongKhamID.Text = drv["PhongKhamID"].ToString();
                txtTenPhongKham.Text = drv["TenPhongKham"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtTenPhongKham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên phòng khám!", "Phòng khám");
                txtTenPhongKham.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            phongKham.saveData(txtPhongKhamID.Text, txtTenPhongKham.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            phongKham.deleteData(txtPhongKhamID.Text);
            loadData();
            btnNew.Focus();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
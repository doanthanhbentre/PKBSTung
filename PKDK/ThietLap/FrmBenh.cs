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
    public partial class FrmBenh : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.Benh benh = new QLPK.DataAccess.Benh();
        public FrmBenh()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = benh.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBenhID.Text = "";
            txtTenBenh.Text = "";
            txtTenBenh.Focus();
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
                txtBenhID.Text = drv["BenhID"].ToString();
                txtTenBenh.Text = drv["TenBenh"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtTenBenh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên bệnh!", "Bệnh tật");
                txtTenBenh.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            benh.saveData(txtBenhID.Text, txtTenBenh.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            benh.deleteData(txtBenhID.Text);
            loadData();
            btnNew.Focus();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
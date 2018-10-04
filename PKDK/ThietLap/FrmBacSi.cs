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
    public partial class FrmBacSi : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BacSi bacSi = new QLPK.DataAccess.BacSi();
        public FrmBacSi()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = bacSi.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaBS.Text = "";
            txtHoTen.Text = "";
            txtHoTen.Focus();
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
                txtMaBS.Text = drv["MaBS"].ToString();
                txtHoTen.Text = drv["HoTen"].ToString();
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập họ tên!", "Bác sĩ");
                txtHoTen.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            bacSi.saveData(txtMaBS.Text, txtHoTen.Text);
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bacSi.deleteData(txtMaBS.Text);
            loadData();
            btnNew.Focus();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
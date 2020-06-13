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
    public partial class FrmGoiKSK : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GoiKSK goiKSK = new QLPK.DataAccess.GoiKSK();
        Int64 m_GoiKSKID = 0;
        public FrmGoiKSK()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingSource1.DataSource = goiKSK.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTenGoi.Text = "";
            txtSoTien.Value = 0;
            m_GoiKSKID = 0;
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
                txtTenGoi.Text = drv["TenGoi"].ToString();
                txtSoTien.Value = Decimal.Parse(drv["SoTien"].ToString());
                m_GoiKSKID = Int64.Parse(drv["GoiKSKID"].ToString());
            }
            else btnNew_Click(null, null);
        }
        private Boolean kiemTra()
        {
            if (txtTenGoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên gói KSK!", "Gói KSK");
                txtTenGoi.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            goiKSK.saveData(m_GoiKSKID, txtTenGoi.Text, double.Parse(txtSoTien.Value.ToString()));
            loadData();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            goiKSK.deleteData(m_GoiKSKID);
            loadData();
            btnNew.Focus();
        }

        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
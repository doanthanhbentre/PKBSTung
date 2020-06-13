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
    public partial class FrmXaPhuong : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DVHC dvhc = new QLPK.DataAccess.DVHC();
        String m_MaTT = String.Empty;
        Boolean m_Sua = false;
        String m_MaXP, m_MaQH, m_TenXP, m_TenTat;

        public string MaTT
        {
            get
            {
                return m_MaTT;
            }

            set
            {
                m_MaTT = value;
            }
        }

        public bool Sua
        {
            get
            {
                return m_Sua;
            }

            set
            {
                m_Sua = value;
            }
        }

        public string MaXP
        {
            get
            {
                return m_MaXP;
            }

            set
            {
                m_MaXP = value;
            }
        }

        public string MaQH
        {
            get
            {
                return m_MaQH;
            }

            set
            {
                m_MaQH = value;
            }
        }

        public string TenXP
        {
            get
            {
                return m_TenXP;
            }

            set
            {
                m_TenXP = value;
            }
        }

        public string TenTat
        {
            get
            {
                return m_TenTat;
            }

            set
            {
                m_TenTat = value;
            }
        }

        

        public FrmXaPhuong()
        {
            InitializeComponent();
        }

        private void loadQH()
        {
            bindingQuanHuyen.DataSource = dvhc.getQuanHuyen(MaTT);
            cboQuanHuyen.DataSource = bindingQuanHuyen;
            cboQuanHuyen.DisplayMember = "TenQH";
            cboQuanHuyen.ValueMember = "MaQH";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaXP.Text = "";
            txtTenXP.Text = "";
            txtTenTat.Text = "";
            txtMaXP.Enabled = true;
            txtMaXP.Focus();
        }
        private void showXaPhuong()
        {
            txtMaXP.Text = MaXP;
            cboQuanHuyen.SelectedValue = MaQH;
            txtTenXP.Text = TenXP;
            txtTenTat.Text = TenTat;
        }
        private void FrmXaPhuong_Load(object sender, EventArgs e)
        {
            loadQH();
            if (Sua)
            {
                txtMaXP.Enabled = false;
                showXaPhuong();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaXP.Text.Trim().Length == 0 || txtTenXP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mã hoặc tên phường xã!", "Đơn vị hành chính");
                return;
            }
            if (Sua)
                dvhc.suaXaPhuong(txtMaXP.Text, cboQuanHuyen.SelectedValue.ToString(), txtTenXP.Text, txtTenTat.Text);
            else
                dvhc.themXaPhuong(txtMaXP.Text, cboQuanHuyen.SelectedValue.ToString(), txtTenXP.Text, txtTenTat.Text);
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaXP.Text.Trim().Length > 0)
                dvhc.xoaXaPhuong(txtMaXP.Text.Trim());
            Close();
        }
    }
}
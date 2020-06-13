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

namespace PKDK.KhamBenh
{
    public partial class FrmUpdateCachDung : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        String m_DotKhamID, m_PhongKhamID, m_GiaDVID;
        public string CachDung
        {
            get
            {
                return txtCachDung.Text;
            }

            set
            {
                txtCachDung.Text = value;
            }
        }
        public string DonVi
        {
            get
            {
                return lblDonVi.Text;
            }

            set
            {
                lblDonVi.Text = value;
            }
        }

        public string DotKhamID
        {
            get
            {
                return m_DotKhamID;
            }

            set
            {
                m_DotKhamID = value;
            }
        }

        public string PhongKhamID
        {
            get
            {
                return m_PhongKhamID;
            }

            set
            {
                m_PhongKhamID = value;
            }
        }

        public string GiaDVID
        {
            get
            {
                return m_GiaDVID;
            }

            set
            {
                m_GiaDVID = value;
            }
        }

        public decimal SoLuong
        {
            get
            {
                return txtSoLuong.Value;
            }

            set
            {
                txtSoLuong.Value = value;
            }
        }

        public FrmUpdateCachDung()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            chiDinh.updateSoLuongCachDung(DotKhamID, PhongKhamID  , GiaDVID, txtSoLuong.Value, txtCachDung.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCachDung_Click(object sender, EventArgs e)
        {
            FrmLieuDung frm = new FrmLieuDung();
            frm.DonVi = DonVi;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCachDung.Text = frm.LieuDung;
            }
            btnSave.Focus();
        }
    }
}
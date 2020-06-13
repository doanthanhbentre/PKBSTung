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
    public partial class FrmKetQuaCD : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        String m_MaBN = String.Empty;
        public FrmKetQuaCD()
        {
            InitializeComponent();
        }

        public string MaBN
        {
            get
            {
                return m_MaBN;
            }

            set
            {
                m_MaBN = value;
            }
        }

        private void loadChiDinh()
        {
            bindingSource1.DataSource = chiDinh.getKetQua(MaBN);
            gridControl1.DataSource = bindingSource1;
        }
        private void FrmKetQuaCD_Load(object sender, EventArgs e)
        {
            loadChiDinh();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {            
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
                txtKetQua.Text = drv["KetQua"].ToString();
            else
                txtKetQua.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                chiDinh.updateKetQua(drv["DotKhamID"].ToString(), drv["PhongKhamID"].ToString(), drv["GiaDVID"].ToString(), txtKetQua.Text);
                loadChiDinh();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
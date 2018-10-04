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
    public partial class FrmChonDVHC : DevExpress.XtraEditors.XtraForm
    {
        String m_MaXP, m_TenDVHC;

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

        public string TenDVHC
        {
            get
            {
                return m_TenDVHC;
            }

            set
            {
                m_TenDVHC = value;
            }
        }

        public FrmChonDVHC()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            m_MaXP = lstData.SelectedValue.ToString();
            m_TenDVHC = lstData.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        public void setData(System.Data.DataView dataView)
        {
            lstData.DataSource = dataView;
            lstData.DisplayMember = "TENDVHC";
            lstData.ValueMember = "MAXP";
        }

    }
}
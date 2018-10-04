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
    public partial class FrmChonBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
        String m_TenBenhNhan;
        String m_MaBN;
        public FrmChonBenhNhan()
        {
            InitializeComponent();
        }

        public string TenBenhNhan
        {
            get
            {
                return m_TenBenhNhan;
            }

            set
            {
                m_TenBenhNhan = value;
            }
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

        private void FrmChonBenhNhan_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = benhNhan.getDataTable(TenBenhNhan).DefaultView;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnChon.Enabled = bindingSource1.Count > 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            MaBN = drv["MaBN"].ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
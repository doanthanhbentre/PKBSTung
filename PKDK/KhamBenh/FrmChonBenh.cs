using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PKDK.KhamBenh
{
    public partial class FrmChonBenh : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.Benh benh = new QLPK.DataAccess.Benh();
        String m_TenBenh;

        public string TenBenh
        {
            get
            {
                return m_TenBenh;
            }

            set
            {
                m_TenBenh = value;
            }
        }

        public FrmChonBenh()
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
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                TenBenh = drv["TenBenh"].ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FrmCreateUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
        }

        
        private void FrmBacSi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnChon.Enabled = bindingSource1.Count > 0;
        }
    }
}
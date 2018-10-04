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
    public partial class FrmDVHC : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DVHC dvhc = new QLPK.DataAccess.DVHC();
        public FrmDVHC()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadTinhThanh()
        {
            bindingSource1.DataSource = dvhc.getTinhThanh();
            gridTinhThanh.DataSource = bindingSource1;
        }
        private void loadQuanHuyen()
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
                bindingSource2.DataSource = dvhc.getQuanHuyen(drv["MaTT"].ToString());
            else
                bindingSource2.DataSource = dvhc.getQuanHuyen("");
            gridQuanHuyen.DataSource = bindingSource2;
        }
        private void loadXaPhuong()
        {
            DataRowView drv = (DataRowView)bindingSource2.Current;
            if (drv != null)
                bindingSource3.DataSource = dvhc.getXaPhuong(drv["MaQH"].ToString());
            else
                bindingSource3.DataSource = dvhc.getXaPhuong("");
            gridXaPhuong.DataSource = bindingSource3;
        }
        private void FrmDVHC_Load(object sender, EventArgs e)
        {
            loadTinhThanh();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            loadQuanHuyen();
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            loadXaPhuong();
        }
    }
}
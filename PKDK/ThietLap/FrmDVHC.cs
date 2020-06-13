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
            bindingTT.DataSource = dvhc.getTinhThanh();
            gridTinhThanh.DataSource = bindingTT;
        }
        private void loadQuanHuyen()
        {
            DataRowView drv = (DataRowView)bindingTT.Current;
            if (drv != null)
                bindingQH.DataSource = dvhc.getQuanHuyen(drv["MaTT"].ToString());
            else
                bindingQH.DataSource = dvhc.getQuanHuyen("");
            gridQuanHuyen.DataSource = bindingQH;
        }
        private void loadXaPhuong()
        {
            DataRowView drv = (DataRowView)bindingQH.Current;
            if (drv != null)
                bindingXP.DataSource = dvhc.getXaPhuong(drv["MaQH"].ToString());
            else
                bindingXP.DataSource = dvhc.getXaPhuong("");
            gridXaPhuong.DataSource = bindingXP;
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

        private void mnuNewXP_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingTT.Current;
            if (drv == null) return;
            FrmXaPhuong frm = new FrmXaPhuong();
            frm.MaTT = drv["MaTT"].ToString();
            frm.Sua = false;
            frm.ShowDialog();
            loadXaPhuong();
        }

        private void mnuEditXP_Click(object sender, EventArgs e)
        {
            DataRowView drvTT = (DataRowView)bindingTT.Current;
            if (drvTT == null) return;

            DataRowView drvXP = (DataRowView)bindingXP.Current;
            if (drvXP == null) return;
            FrmXaPhuong frm = new FrmXaPhuong();
            frm.MaTT = drvTT["MaTT"].ToString();
            frm.MaXP = drvXP["MaXP"].ToString();
            frm.MaQH = drvXP["MaQH"].ToString();
            frm.TenXP = drvXP["TenXP"].ToString();
            frm.TenTat = drvXP["TenTat"].ToString();
            frm.Sua = true;
            frm.ShowDialog();
            loadXaPhuong();
        }

        private void bindingXP_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTongXP.Text = bindingXP.Count.ToString();
        }
    }
}
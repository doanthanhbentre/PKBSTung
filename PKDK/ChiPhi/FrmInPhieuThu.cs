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

namespace PKDK.ChiPhi
{
    public partial class FrmInPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.PhieuThu phieuThu = new QLPK.DataAccess.PhieuThu();
        public FrmInPhieuThu()
        {
            InitializeComponent();
        }
        public void loadData(String maPT)
        {
            DevExpress.XtraReports.UI.XtraReport report = new PhieuThu();
            report.DataSource = phieuThu.getPhieuThu(maPT).DefaultView;
            report.Parameters["pThuNgan"].Value =  QLPK.DataAccess.NguoiDung.HoTen;
            report.Parameters["pMaPT"].Value = maPT;
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }

        private void FrmInPhieuThu_Load(object sender, EventArgs e)
        {

        }
    }
}
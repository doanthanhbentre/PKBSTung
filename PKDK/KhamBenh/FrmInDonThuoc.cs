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
    public partial class FrmInDonThuoc : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DonThuoc donThuoc = new QLPK.DataAccess.DonThuoc();
        public FrmInDonThuoc()
        {
            InitializeComponent();
        }
        public void loadData(String dotKhamID)
        {
            DevExpress.XtraReports.UI.XtraReport report = new DonThuoc();
            report.DataSource = donThuoc.getDonThuoc(dotKhamID).DefaultView;
            //report.Parameters["pTieuDe"].Value = "PHIẾU " + tieuDe.ToUpper();
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }
    }
}
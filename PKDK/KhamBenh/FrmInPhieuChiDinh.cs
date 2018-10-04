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
    public partial class FrmInPhieuChiDinh : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        public FrmInPhieuChiDinh()
        {
            InitializeComponent();
        }
        public void loadData(String dotKhamID, String tieuDe, String loaiDVID)
        {
            DevExpress.XtraReports.UI.XtraReport report = new PhieuChiDinh();
            report.DataSource = chiDinh.getPhieuChiDinh(dotKhamID, loaiDVID).DefaultView;
            report.Parameters["pTieuDe"].Value = "PHIẾU " + tieuDe.ToUpper();
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }
    }
}
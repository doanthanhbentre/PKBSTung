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
    public partial class FrmInTKThuoc : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.ChiPhi chiPhi = new QLPK.DataAccess.ChiPhi();
        public FrmInTKThuoc()
        {
            InitializeComponent();
        }
        public void loadData(DateTime tuNgay, DateTime denNgay, String thoiGian)
        {
            DevExpress.XtraReports.UI.XtraReport report = new TKDichVu();
            report.DataSource = chiPhi.getTKThuoc(tuNgay, denNgay).DefaultView;
            report.Parameters["pThoiGian"].Value = thoiGian;
            report.Parameters["pTieuDe"].Value = "THỐNG KÊ THUỐC";
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }
        private void FrmTKDichVu_Load(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class FrmInSoKhamBenh_A1 : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.SoKhamBenh soKhamBenh = new QLPK.DataAccess.SoKhamBenh();
        DateTime m_TuNgay, m_DenNgay;

        public DateTime TuNgay
        {
            get
            {
                return m_TuNgay;
            }

            set
            {
                m_TuNgay = value;
            }
        }

        public DateTime DenNgay
        {
            get
            {
                return m_DenNgay;
            }

            set
            {
                m_DenNgay = value;
            }
        }

        public FrmInSoKhamBenh_A1()
        {
            InitializeComponent();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FrmInSoKhamBenh_A1_Load(object sender, EventArgs e)
        {
            DevExpress.XtraReports.UI.XtraReport report = new KhamBenh.SoKhamBenh_A1();
            report.DataSource = soKhamBenh.soKhamBenhA1(TuNgay, DenNgay).DefaultView;
            //report.DataSource = soKhamBenh.soCLS(TuNgay, DenNgay, "").DefaultView;
            report.Parameters["pTieuDe"].Value = "SỔ KHÁM BỆNH CHUNG";
            report.CreateDocument();
            documentViewer1.DocumentSource = report;
        }
    }
}
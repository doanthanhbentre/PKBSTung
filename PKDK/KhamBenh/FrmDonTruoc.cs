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
    public partial class FrmDonTruoc : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DotKham dotKham = new QLPK.DataAccess.DotKham();
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        String m_MaBN;
        String m_DotKhamID;
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

        public string DotKhamID
        {
            get
            {
                return m_DotKhamID;
            }

            set
            {
                m_DotKhamID = value;
            }
        }

        public FrmDonTruoc()
        {
            InitializeComponent();
        }
        private void loadDonThuoc()
        {
            DataRowView drv = (DataRowView)bindingDotKham.Current;
            if (drv != null)
                bindingDonThuoc.DataSource = chiDinh.getDataTable(drv["DotKhamID"].ToString(), "01");
            else
                bindingDonThuoc.DataSource = chiDinh.getDataTable("");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingDotKham.Current;
            DotKhamID = drv["DotKhamID"].ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void bindingDotKham_CurrentChanged(object sender, EventArgs e)
        {
            loadDonThuoc();
        }

        private void FrmDonTruoc_Load(object sender, EventArgs e)
        {
            bindingDotKham.DataSource = dotKham.getCacLanKham(MaBN);
        }

        private void bindingDonThuoc_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnChapNhan.Enabled = bindingDonThuoc.Count > 0;
        }
    }
}
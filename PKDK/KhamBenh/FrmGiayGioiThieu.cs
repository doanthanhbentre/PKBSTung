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
using DevExpress.XtraReports.UI;

namespace PKDK.KhamBenh
{
    public partial class FrmGiayGioiThieu : DevExpress.XtraEditors.XtraForm
    {
        String m_MaBN = String.Empty;
        DataAccess.GiayGioiThieu giayGT = new DataAccess.GiayGioiThieu();
        String m_DotKhamID = String.Empty;
        String m_PhongKhamID = String.Empty;
        String m_GiayGTID = String.Empty;
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

        public string PhongKhamID
        {
            get
            {
                return m_PhongKhamID;
            }

            set
            {
                m_PhongKhamID = value;
            }
        }

        public FrmGiayGioiThieu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadData()
        {
            bindingSource1.DataSource = giayGT.getListData(MaBN);
            lstNgay.DataSource = bindingSource1;
        }
        private void FrmGiayGioiThieu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (m_GiayGTID.Length == 0)
                m_GiayGTID = giayGT.saveData(m_GiayGTID, DotKhamID, PhongKhamID, DateTime.Today, txtGioiThieuDen.Text, txtNoiDung.Text);
            else
            {
                DataRowView drv = (DataRowView)bindingSource1.Current;
                if (drv != null)
                {
                    m_GiayGTID = giayGT.saveData(drv["GiayGTID"].ToString(), drv["DotKhamID"].ToString(), drv["PhongKhamID"].ToString(), DateTime.Parse(drv["Ngay"].ToString()), txtGioiThieuDen.Text, txtNoiDung.Text);
                }
            }
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            m_GiayGTID = String.Empty;
            txtGioiThieuDen.Text = "";
            txtNoiDung.Text = "";
            txtGioiThieuDen.Focus();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                m_GiayGTID = drv["GiayGTID"].ToString();
                txtGioiThieuDen.Text = drv["GioiThieuDen"].ToString();
                txtNoiDung.Text = drv["NoiDung"].ToString();
            }
            else btnNew_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                giayGT.deleteData(drv["GiayGTID"].ToString());
                loadData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
            GiayGioiThieu report = new GiayGioiThieu();
            report.DataSource = giayGT.getDataRow(m_GiayGTID).Table;
            report.ShowPreviewDialog();
        }

    }
}
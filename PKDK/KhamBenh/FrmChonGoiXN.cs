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
    public partial class FrmChonGoiXN : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GoiDichVu goiDV = new QLPK.DataAccess.GoiDichVu();
        QLPK.DataAccess.ChiTietGoiDV chiTietGoiDV = new QLPK.DataAccess.ChiTietGoiDV();
        String m_GoiDVID;

        public string GoiDVID
        {
            get
            {
                return m_GoiDVID;
            }

            set
            {
                m_GoiDVID = value;
            }
        }

        public FrmChonGoiXN()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            GoiDVID = lstListGoi.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void loadGoiDV()
        {
            bindingGoiDV.DataSource = goiDV.getDataTable("03").DefaultView;
        }
        private void loadChiTietGoi()
        {
            if (lstListGoi.SelectedValue != null)
                bindingXetNghiem.DataSource = chiTietGoiDV.getDataTable(lstListGoi.SelectedValue.ToString());
            else
                bindingXetNghiem.DataSource = chiTietGoiDV.getDataTable("");
        }
        private void FrmChonGoiXN_Load(object sender, EventArgs e)
        {
            loadGoiDV();
        }

        private void bindingGoiDV_CurrentChanged(object sender, EventArgs e)
        {
            loadChiTietGoi();
        }
    }
}
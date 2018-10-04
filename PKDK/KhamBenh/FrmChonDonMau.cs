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
    public partial class FrmChonDonMau : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.Benh benh = new QLPK.DataAccess.Benh();
        QLPK.DataAccess.DonThuocMau donMau = new QLPK.DataAccess.DonThuocMau();
        String m_BenhID;

        public string BenhID
        {
            get
            {
                return m_BenhID;
            }

            set
            {
                m_BenhID = value;
            }
        }

        public FrmChonDonMau()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingBenh.Current;
            if (drv != null)
                BenhID = drv["BenhID"].ToString();
            else
                BenhID = "";
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingDonThuoc_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnSelect.Enabled = bindingDonThuoc.Count > 0;
        }

        private void FrmChonDonMau_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            bindingBenh.DataSource = benh.getDataTable();
        }
        private void loadDonThuoc()
        {
            DataRowView drv = (DataRowView)bindingBenh.Current;
            if (drv != null)
                bindingDonThuoc.DataSource = donMau.getDataTable(drv["BenhID"].ToString());
            else
                bindingDonThuoc.DataSource = donMau.getDataTable("");
        }

        private void bindingBenh_CurrentChanged(object sender, EventArgs e)
        {
            loadDonThuoc();
        }
    }
}
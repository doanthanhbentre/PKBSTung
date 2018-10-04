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
    public partial class FrmListKhamBenh : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.DotKham dotKham = new QLPK.DataAccess.DotKham();
        public FrmListKhamBenh()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            bindingSource1.DataSource = dotKham.getDataTable(DateTime.Parse(txtTuNgay.EditValue.ToString()), DateTime.Parse(txtDenNgay.EditValue.ToString()));
        }
        private void FrmListKhamBenh_Load(object sender, EventArgs e)
        {
            txtTuNgay.EditValue = DateTime.Today;
            txtDenNgay.EditValue = DateTime.Today;
            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                dotKham.deleteData(drv["DotKhamID"].ToString());
                loadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPhieuKham frm = new FrmPhieuKham();
            frm.ShowDialog();
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            if (drv != null)
            {
                FrmPhieuKham frm = new FrmPhieuKham();
                frm.DotKhamID = drv["DotKhamID"].ToString();
                frm.ShowDialog();
                loadData();
            }
        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {
            Int32 m_Total = bindingSource1.Count;
            lblTongSo.Text = m_Total.ToString();
            btnDelete.Enabled = m_Total > 0;
            btnEdit.Enabled = m_Total > 0;
        }
    }
}
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
    public partial class FrmListBenhNhan : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.BenhNhan benhNhan = new QLPK.DataAccess.BenhNhan();
        public FrmListBenhNhan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListBenhNhan_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = benhNhan.getDataTable();
        }
    }
}
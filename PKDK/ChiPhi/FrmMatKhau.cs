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
    public partial class FrmMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmMatKhau()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == QLPK.DataAccess.NguoiDung.MatKhau)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PKDK.ChiPhi
{
    public partial class UcChiPhi : DevExpress.XtraEditors.XtraUserControl
    {
        Double m_TongSoTien, m_DaThu, m_ChuaThu;
        QLPK.DataAccess.ChiDinh chiDinh = new QLPK.DataAccess.ChiDinh();
        //QLPK.DataAccess.DonThuoc donThuoc = new QLPK.DataAccess.DonThuoc();
        public Double TongSoTien
        {
            get { return m_TongSoTien; }
            set { m_TongSoTien = value; }
        }

        public Double DaThu
        {
            get { return m_DaThu; }
            set { m_DaThu = value; }
        }

        public Double ChuaThu
        {
            get { return m_ChuaThu; }
            set { m_ChuaThu = value; }
        }
        public UcChiPhi()
        {
            InitializeComponent();
        }
        private void showData()
        {
            txtTongSoTien.Text = TongSoTien.ToString("#,###");
            txtSoTienDaThu.Text = DaThu.ToString("#,###");
            txtSoTienChuaThu.Text = ChuaThu.ToString("#,###");
        }
        public void loadData(String dotKhamID)
        {
            TongSoTien = 0;
            DaThu = 0;
            ChuaThu = 0;
            DataRow dr = chiDinh.getSoTien(dotKhamID);
            if (dr["SoTien"] != DBNull.Value)
            {
                TongSoTien = Double.Parse(dr["SoTien"].ToString());
                DaThu = Double.Parse(dr["DaThu"].ToString());
                ChuaThu = Double.Parse(dr["ChuaThu"].ToString());
            }
            showData();
        }
    }
}

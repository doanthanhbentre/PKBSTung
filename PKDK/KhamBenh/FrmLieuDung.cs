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
    public partial class FrmLieuDung : DevExpress.XtraEditors.XtraForm
    {
        String m_DonVi = String.Empty;
        String m_LieuDung = String.Empty;
        public String LieuDung
        {
            get { return m_LieuDung; }
            set { m_LieuDung = value; }
        }
        public String DonVi
        {
            get { return m_DonVi; }
            set { m_DonVi = value; }
        }
        public String Sang
        {
            get { return txtSang.Text; }
            set { txtSang.Text = value; }
        }
        public String Trua
        {
            get { return txtTrua.Text; }
            set { txtTrua.Text = value; }
        }
        public String Chieu
        {
            get { return txtChieu.Text; }
            set { txtChieu.Text = value; }
        }
        public String Toi
        {
            get { return txtToi.Text; }
            set { txtToi.Text = value; }
        }
        public FrmLieuDung()
        {
            InitializeComponent();
        }

        private void txtSang_Enter(object sender, EventArgs e)
        {
            //(sender as NumericUpDown).Select(0, 10);
        }

        private void FrmLieuDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{Tab}");
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private String getTruocSauAn(Int16 buoi)
        {
            if (buoi == 1)
            {
                if (radSangTruoc.Checked) return " trước ăn";
                if (radSangSau.Checked) return " sau ăn";
                if (radSangKhong.Checked) return "";
            }
            if (buoi == 2)
            {
                if (radTruaTruoc.Checked) return " trước ăn";
                if (radTruaSau.Checked) return " sau ăn";
                if (radTruaKhong.Checked) return "";
            }
            if (buoi == 3)
            {
                if (radChieuTruoc.Checked) return " trước ăn";
                if (radChieuSau.Checked) return " sau ăn";
                if (radChieuKhong.Checked) return "";
            }
            if (buoi == 4)
            {
                if (radToiTruoc.Checked) return " trước ăn";
                if (radToiSau.Checked) return " sau ăn";
                if (radToiKhong.Checked) return "";
            }
            return "";
        }
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            m_LieuDung = "";
            Int16 m_Lan = 0;
            if (Sang.Trim().Length > 0)
            {
                m_Lan++;
                m_LieuDung = "Sáng: " + Sang.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(1);
            }
            if (Trua.Trim().Length > 0)
            {
                m_Lan++;
                if (m_LieuDung.Length == 0)
                    m_LieuDung = "Trưa: " + Trua.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(2);
                else
                    m_LieuDung += ", Trưa: " + Trua.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(2);
            }
            if (Chieu.Trim().Length > 0)
            {
                m_Lan++;
                if (m_LieuDung.Length == 0)
                    m_LieuDung = "Chiều: " + Chieu.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(3);
                else
                    m_LieuDung += ", Chiều: " + Chieu.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(3);
            }
            if (Toi.Trim().Length > 0)
            {
                m_Lan++;
                if (m_LieuDung.Length == 0)
                    m_LieuDung = "Tối: " + Toi.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(4);
                else
                    m_LieuDung += ", Tối: " + Toi.PadLeft(2, '0') + " " + DonVi.ToLower() + getTruocSauAn(4);
            }
            if (m_LieuDung.Length > 0)
                m_LieuDung = "Ngày uống " + m_Lan.ToString() + " lần; " + m_LieuDung;
            else
                m_LieuDung = "";
            this.DialogResult = DialogResult.OK;
        }
    }
}
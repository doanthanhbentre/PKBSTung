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

namespace PKDK.HeThong
{
    public partial class FrmThoiGian : DevExpress.XtraEditors.XtraForm
    {
        System.Globalization.CultureInfo vn = new System.Globalization.CultureInfo("vi-VN");
        DateTime m_TuNgay, m_DenNgay;
        String m_ThoiGian;

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

        public string ThoiGian
        {
            get
            {
                return m_ThoiGian;
            }

            set
            {
                m_ThoiGian = value;
            }
        }

        public FrmThoiGian()
        {
            InitializeComponent();
        }
        private void chonNgay()
        {
            TuNgay = DateTime.Parse(txtTuNgay.EditValue.ToString());
            DenNgay = DateTime.Parse(txtDenNgay.EditValue.ToString());
            if (TuNgay.Equals(DenNgay))
                ThoiGian = "Ngày " + TuNgay.ToString("dd/MM/yyyy");
            else
                ThoiGian = "Từ ngày " + TuNgay.ToString("dd/MM/yyyy") + " đến ngày " + DenNgay.ToString("dd/MM/yyyy"); 
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void setHieuLuc()
        {
            txtTuNgay.Enabled = radTuNgay.Checked;
            txtDenNgay.Enabled = radTuNgay.Checked;
            txtTuThang.Enabled = radTuThang.Checked;
            txtDenThang.Enabled = radTuThang.Checked;
            txtTuNam.Enabled = radTuThang.Checked;
            txtDenNam.Enabled = radTuThang.Checked;
        }
        private void setValues()
        {
            txtTuNgay.EditValue = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.EditValue = DateTime.Today;

            txtTuThang.EditValue = 1;
            txtTuNam.EditValue = DateTime.Today.Year;
            txtDenThang.EditValue = DateTime.Today.Month;
            txtDenNam.EditValue = DateTime.Today.Year;
        }

        private void radTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            setHieuLuc();
        }

        private void radTuThang_CheckedChanged(object sender, EventArgs e)
        {
            setHieuLuc();
        }
        private Boolean kiemTra()
        {
            if (radTuNgay.Checked)
            {
                if (DateTime.Parse(txtTuNgay.EditValue.ToString()) > DateTime.Parse(txtDenNgay.EditValue.ToString()))
                {
                    MessageBox.Show("Chọn thời gian sai!\nTừ ngày không thể lớn hơn đến ngày!", "Thời gian");
                    return false;
                }
            }
            else
            {
                if (Int32.Parse(txtTuNam.EditValue.ToString()) == Int32.Parse(txtDenNam.EditValue.ToString()))
                {
                    if (Int32.Parse(txtTuThang.EditValue.ToString()) > Int32.Parse(txtDenThang.EditValue.ToString()))
                    {
                        MessageBox.Show("Chọn thời gian sai!\nTừ tháng không thể lớn hơn đến tháng!", "Thời gian");
                        return false;
                    }
                }
                if (Int32.Parse(txtTuNam.EditValue.ToString()) > Int32.Parse(txtDenNam.EditValue.ToString()))
                {
                    if (Int32.Parse(txtTuThang.EditValue.ToString()) > Int32.Parse(txtDenThang.EditValue.ToString()))
                    {
                        MessageBox.Show("Chọn thời gian sai!\nTừ năm không thể lớn hơn đến năm!", "Thời gian");
                        return false;
                    }
                }
            }
            return true;
        }
        private void chonThang()
        {
            Int32 DaysInMonth = DateTime.DaysInMonth(Convert.ToInt32(txtDenNam.Value), Convert.ToInt32(txtDenThang.Value));
            TuNgay = Convert.ToDateTime("01/" + txtTuThang.Value.ToString() + "/" + txtTuNam.Value.ToString(), vn);
            DenNgay = Convert.ToDateTime(DaysInMonth.ToString() + "/" + txtDenThang.Value.ToString() + "/" + txtDenNam.Value.ToString(), vn);
            if (txtTuNam.Value.Equals(txtDenNam.Value))
            {
                if (txtTuThang.Value.Equals(txtDenThang.Value))
                    ThoiGian = "Tháng " + txtTuThang.Value.ToString() + " năm " + txtTuNam.Value.ToString();
                else
                    ThoiGian = "Từ tháng " + txtTuThang.Value.ToString() + " đến tháng " + txtDenThang.Value.ToString() + " năm " + txtTuNam.Value.ToString();
            }
            else
                ThoiGian = "Từ tháng " + txtTuThang.Value.ToString() + " năm " + txtTuNam.Value.ToString() + " đến tháng " + txtDenThang.Value.ToString() + " năm " + txtDenNam.Value.ToString();
        }
        private void txtTuThang_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            if (radTuNgay.Checked)
                chonNgay();
            else
                chonThang();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmThoiGian_Load(object sender, EventArgs e)
        {
            setValues();
            setHieuLuc();
        }
    }
}
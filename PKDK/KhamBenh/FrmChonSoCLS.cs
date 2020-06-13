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
    public partial class FrmChonSoCLS : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.LoaiDichVu loaiDV = new QLPK.DataAccess.LoaiDichVu();
        QLPK.DataAccess.GiaDichVu giaDV = new QLPK.DataAccess.GiaDichVu();
        QLPK.DataAccess.SoKhamBenh soKhamBenh = new QLPK.DataAccess.SoKhamBenh();
        public FrmChonSoCLS()
        {
            InitializeComponent();
        }
        private void loadGiaDV()
        {
            chklstGiaDichVu.Items.Clear();
            DataRowView drv = (DataRowView)bindingLoaiDichVu.Current;
            if (drv != null)
                bindingGiaDichVu.DataSource = giaDV.getDataTable(drv["LoaiDVID"].ToString());
            else
                bindingGiaDichVu.DataSource = giaDV.getDataTable("");
        }
        private void loadLoaiDichVu()
        {
            bindingLoaiDichVu.DataSource = loaiDV.getCLS();
            cboLoaiDV.DataSource = bindingLoaiDichVu;
            cboLoaiDV.DisplayMember = "TENLOAIDV";
            cboLoaiDV.ValueMember = "LOAIDVID";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private String getDieuKien()
        {
            String m_values = "";
            for (Int32 i = 0; i < chklstGiaDichVu.ItemCount; i++)
            {
                if (chklstGiaDichVu.GetItemChecked(i) == true)
                {
                    if (m_values.Length == 0)
                        m_values += "('" + chklstGiaDichVu.GetItemValue(i) + "'";
                    else
                        m_values += ", '" + chklstGiaDichVu.GetItemValue(i) + "'";
                }
            }
            if (m_values.Length > 0) m_values += ")";
                return m_values;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //DonThuocUngBuou report = new DonThuocUngBuou();
            //report.DataSource = chiDinh.getDonThuoc(DotKhamID).DefaultView;
            //report.Parameters["pSoTien"].Value = Math.Round(ucChiPhi1.TongSoTien / 1000, 0).ToString();
            //report.ShowPreviewDialog();
            //MessageBox.Show(getDieuKien());

            KhamBenh.SoKhamBenh_A1 report = new KhamBenh.SoKhamBenh_A1();
            report.DataSource = soKhamBenh.soCLS(txtTuNgay.DateTime, txtDenNgay.DateTime, getDieuKien()).DefaultView;
            //report.DataSource = soKhamBenh.soCLS(TuNgay, DenNgay, "").DefaultView;
            report.Parameters["pTieuDe"].Value = txtTenSoCLS.Text;
            report.ShowPreviewDialog();
        }

        private void bindingLoaiDichVu_CurrentChanged(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            loadGiaDV();
        }

        private void FrmChonSoCLS_Load(object sender, EventArgs e)
        {
            txtTuNgay.DateTime = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.DateTime = DateTime.Today;
            loadLoaiDichVu();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < bindingGiaDichVu.Count; i++)
            {
                chklstGiaDichVu.SetItemChecked(i, chkAll.Checked);
            }
        }
    }
}
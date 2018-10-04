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

namespace PKDK.ThietLap
{
    public partial class FrmChiTietGoiDV : DevExpress.XtraEditors.XtraForm
    {
        QLPK.DataAccess.GoiDichVu goiDichVu = new QLPK.DataAccess.GoiDichVu();
        QLPK.DataAccess.ChiTietGoiDV chiTietDV = new QLPK.DataAccess.ChiTietGoiDV();
        QLPK.DataAccess.GiaDichVu giaDichVu = new QLPK.DataAccess.GiaDichVu();
        String m_LoaiDVID;

        public string LoaiDVID
        {
            get
            {
                return m_LoaiDVID;
            }

            set
            {
                m_LoaiDVID = value;
            }
        }

        public FrmChiTietGoiDV()
        {
            InitializeComponent();
        }

        private void bindingSource2_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTongSo.Text = bindingSource2.Count.ToString();
        }
        private void loadXetNghiem()
        {
            bindingSource1.DataSource = giaDichVu.getDataTable(LoaiDVID);
        }
        private void loadGoiDichVu()
        {
            bindingGoiDichVu.DataSource = goiDichVu.getDataTable(LoaiDVID);
            if (bindingGoiDichVu.Count > 0)
                cboGoiDichVu.ItemIndex = 0;
        }
        private void loadChiTietGoi()
        {
            if (cboGoiDichVu.EditValue != null)
                bindingSource2.DataSource = chiTietDV.getDataTable(cboGoiDichVu.EditValue.ToString());
            else
                bindingSource2.DataSource = chiTietDV.getDataTable("");
        }

        private void FrmChiTietGoiDV_Load(object sender, EventArgs e)
        {
            loadGoiDichVu();
            loadXetNghiem();
        }

        private void btnGoiDichVu_Click(object sender, EventArgs e)
        {
            FrmGoiDichVu frm = new FrmGoiDichVu();
            frm.LoaiDVID = LoaiDVID;
            frm.ShowDialog();
            loadGoiDichVu();
        }

        private void bindingGoiDichVu_CurrentChanged(object sender, EventArgs e)
        {
            loadChiTietGoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lstXetNghiem.SelectedIndex >= 0)
            {
                DataRowView drvXN = (DataRowView)bindingSource1.Current;
                if (cboGoiDichVu.EditValue != null && drvXN != null)
                {
                    chiTietDV.saveData(cboGoiDichVu.EditValue.ToString(), drvXN["GiaDVID"].ToString());
                    loadChiTietGoi();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lstGoiXetNghiem.SelectedIndex >= 0)
            {
                DataRowView drvXN = (DataRowView)bindingSource2.Current;
                if (cboGoiDichVu.EditValue != null && drvXN != null)
                {
                    chiTietDV.deleteData(cboGoiDichVu.EditValue.ToString(), drvXN["GiaDVID"].ToString());
                    loadChiTietGoi();
                }
            }
        }

        private void cboGoiDichVu_EditValueChanged(object sender, EventArgs e)
        {
            loadChiTietGoi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
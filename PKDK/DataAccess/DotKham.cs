using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class DotKham
    {
        public String saveData(String DOTKHAMID, String PHONGKHAMID, DateTime NGAY, String MABS, String MABN, String CHANDOAN, String MACH, String HUYETAP, String NHIETDO)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEDOTKHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "NGAY", "MABS", "MABN", "CHANDOAN", "MACH", "HUYETAP", "NHIETDO" };
            Object[] ThamTri = { DOTKHAMID, PHONGKHAMID, NGAY, MABS, MABN, CHANDOAN, MACH, HUYETAP, NHIETDO };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "DOTKHAMID", 10);
        }
        public void updateBaoHiem(String dotKhamID, Int32 baoHiem, Int64 goiKSKID, double soTien)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            if (goiKSKID > 0)
                data.CommandText = "UPDATE PKDK.DOTKHAM SET BAOHIEM = " + baoHiem.ToString() + ", GOIKSKID = " + goiKSKID.ToString() + ", SOTIEN = " + soTien.ToString() + " WHERE DOTKHAMID = '" + dotKhamID + "'";
            else
                data.CommandText = "UPDATE PKDK.DOTKHAM SET BAOHIEM = " + baoHiem.ToString() + ", GOIKSKID = NULL, SOTIEN = " + soTien.ToString() + " WHERE DOTKHAMID = '" + dotKhamID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void updateNgayTaiKham(String dotKhamID, Int32 soNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            if (soNgay > 0)
            {
                DateTime ngayTK = DateTime.Today.AddDays(soNgay);
                data.CommandText = "UPDATE PKDK.DOTKHAM SET NGAYTK = '" + ngayTK.ToString("yyyy-MM-dd") + "' WHERE DOTKHAMID = '" + dotKhamID + "'";
            }
            else
                data.CommandText = "UPDATE PKDK.DOTKHAM SET NGAYTK = NULL WHERE DOTKHAMID = '" + dotKhamID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteData(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.DotKham Where DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteData(String DotKhamID, String PhongKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.DotKham Where DotKhamID = '" + DotKhamID + "' And PhongKhamID = '" + PhongKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteAll(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.Text;
            String m_SQL = "Delete From PKDK.ChiDinh Where DotKhamID In (Select DotKhamID From PKDK.DotKham Where MaBN = '" + maBN + "')";
            data.CommandText = m_SQL;
            data.ExecuteNonQuery();
            m_SQL = "Delete From PKDK.DotKham Where MaBN = '" + maBN + "'";
            data.CommandText = m_SQL;
            data.ExecuteNonQuery();
        }
        public void updateGhiChu(String DotKhamID, String ghiChu)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Update PKDK.DotKham set GhiChu = '" + ghiChu + "' Where DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void updateLoiDan(String DotKhamID, String loiDan)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Update PKDK.DotKham set LoiDan = '" + loiDan + "' Where DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getListTaiKham(DateTime ngayTK)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.LISTTAIKHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NGAYTK" };
            Object[] ThamTri = { ngayTK };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.DotKham";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DK.*, PK.TenPhongKham From PKDK.DotKham DK Join PKDK.PhongKham PK On DK.PhongKhamID = PK.PhongKhamID Where MaBN = '" + maBN + "' Order By DK.Ngay Desc, DK.DotKhamID Desc";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataTable getCacLanKham(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DotKhamID, Ngay, ChanDoan, GhiChu From PKDK.DotKham Where MaBN = '" + maBN + "' Order By Ngay Desc";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime ngay, String phongKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DT.DotKhamID, DT.STT, BN.MaBN, BN.HoTen, BN.NamSinh, BN.DiaChi, DT.ChanDoan From PKDK.DotKham DT Inner Join PKDK.BenhNhan BN ON DT.MaBN = BN.MaBN Where DT.Ngay = '" + ngay.ToString("yyyy-MM-dd") + "' And PhongKhamID = '" + phongKhamID + "' Order By DT.STT Desc";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DT.DotKhamID, DT.Ngay, BN.MaBN, BN.HoTen, BN.NamSinh, BN.DiaChi, DT.ChanDoan, DT.PhongKhamID, PK.TenPhongKham, DT.STT From PKDK.DotKham DT Inner Join PKDK.BenhNhan BN ON DT.MaBN = BN.MaBN Inner Join PKDK.PhongKham PK ON DT.PhongKhamID = PK.PhongKhamID Where DT.Ngay Between '" + tuNgay.ToString("yyyy-MM-dd") + "' And '" + denNgay.ToString("yyyy-MM-dd") + "' ORDER BY DT.Ngay DESC ";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable2(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DT.DotKhamID, DT.Ngay, BN.MaBN, BN.HoTen, BN.NamSinh, BN.DiaChi, DT.ChanDoan From PKDK.DotKham DT Inner Join PKDK.BenhNhan BN ON DT.MaBN = BN.MaBN Where DT.Ngay Between '" + tuNgay.ToString("yyyy-MM-dd") + "' And '" + denNgay.ToString("yyyy-MM-dd") + "' ";
            m_SQL += "And DT.InSoKB is Null Or DotKhamID = 0 ";
            m_SQL += "ORDER BY DT.Ngay DESC ";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.DotKham Where DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataRow getDataRow2(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT * FROM PKDK.DOTKHAM DK JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN Where DK.DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable getChiDinh(String DotKhamID, String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.LISTCHIDINH";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "LOAISPID" };
            Object[] ThamTri = { DotKhamID, LoaiSPID };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getPhongKham(String dotKhamID, String maBN)
        {
            String m_SQL = "SELECT PK.PHONGKHAMID, PK.TENPHONGKHAM, DK.STT, PK.MASP ";
            m_SQL += "FROM PKDK.PHONGKHAM PK LEFT JOIN (SELECT PHONGKHAMID, STT FROM PKDK.DOTKHAM WHERE DOTKHAMID = '" + dotKhamID + "' AND MABN = '" + maBN + "') DK ON PK.PHONGKHAMID = DK.PHONGKHAMID ";
            m_SQL += "ORDER BY PK.PHONGKHAMID ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = CommandType.Text;
            return data.GetDataTable();
        }
        public String getChanDoanCuoi(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.DotKham Where DotKhamID = (SELECT MAX(DOTKHAMID) FROM PKDK.DOTKHAM WHERE MABN = '" + maBN + "')";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            DataRow dr = data.GetDataRow();
            if (dr != null)
                return dr["ChanDoan"].ToString();
            else
                return "";
        }
    }
}

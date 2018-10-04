using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class DonThuoc
    {
        public void saveData(String DOTKHAMID, String PHONGKHAMID, String MASP, float SOLUONG, float DONGIA, String CACHDUNG)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEDONTHUOC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "MASP", "SOLUONG", "DONGIA", "CACHDUNG" };
            Object[] ThamTri = { DOTKHAMID, PHONGKHAMID, MASP, SOLUONG, DONGIA, CACHDUNG };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String DOTKHAMID, String PHONGKHAMID, String MASP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.DONTHUOC Where DOTKHAMID = ? AND PHONGKHAMID = ? AND MASP = ?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "MASP" };
            Object[] ThamTri = { DOTKHAMID, PHONGKHAMID, MASP };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }

        public DataTable getDataTable(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT DT.MASP, SP.TENSP, DV.TENDONVI, DT.SOLUONG, DT.DONGIA, DT.SOLUONG * DT.DONGIA AS THANHTIEN, DT.CACHDUNG, DT.MAPT ";
            m_SQL += "FROM PKDK.DONTHUOC DT JOIN DUOC.SANPHAM SP ON DT.MASP = SP.MASP ";
            m_SQL += "JOIN DUOC.DONVI DV ON SP.DONVIID = DV.DONVIID ";
            m_SQL += "WHERE DT.DOTKHAMID = '" + dotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getSoTien(String DotKhamID)
        {
            String m_SQL = "SELECT SUM(SOLUONG * DONGIA) AS SOTIEN, ";
            m_SQL += "SUM(CASE WHEN MAPT IS NOT NULL THEN SOLUONG * DONGIA ELSE 0 END) AS DATHU, ";
            m_SQL += "SUM(CASE WHEN MAPT IS NULL THEN SOLUONG * DONGIA ELSE 0 END) AS CHUATHU ";
            m_SQL += "FROM PKDK.DONTHUOC WHERE DOTKHAMID = '" + DotKhamID + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable getDonThuoc(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.DONTHUOC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("DOTKHAMID", dotKhamID);
        }
        public void updateMaPT(String DotKhamID, String maPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Update PKDK.DonThuoc set MaPT = null Where DotKhamID = ? And MaPT = ?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "DOTKHAMID", "MAPT" };
            Object[] ThamTri = { DotKhamID, maPT };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
    }
}

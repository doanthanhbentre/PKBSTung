using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class DonThuocMau
    {
        public void saveData(String benhID, String maSP, String cachDung, Int16 soLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEDONTHUOCMAU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "BENHID", "MASP", "CACHDUNG", "SOLUONG" };
            Object[] ThamTri = { benhID, maSP, cachDung, soLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
 
        public void deleteData(String benhID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.DonThuocMau Where benhID = '" + benhID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteData(String benhID, String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.DonThuocMau Where benhID = '" + benhID + "' And GIADVID = '" + giaDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.DonThuocMau";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String benhID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select DM.BenhID, DV.GIADVID, DV.TENDV, DV.DonVi, DM.SoLuong, DM.CachDung, DV.DONGIA From PKDK.DonThuocMau DM Inner Join PKDK.GIADICHVU DV On DM.GIADVID = DV.GIADVID ";
            m_SQL += "Where benhID = '" + benhID.ToString() + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String benhID, String maSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.DonThuocMau Where benhID = '" + benhID.ToString() + "' And MaSP = '" + maSP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public Int32 getTotal(String benhID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select Count(*) As TongSo From PKDK.DonThuocMau Where benhID = '" + benhID.ToString() + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            Int32 value = Int32.Parse(data.ExecuteScalar().ToString());
            return value;
        }
    }
}

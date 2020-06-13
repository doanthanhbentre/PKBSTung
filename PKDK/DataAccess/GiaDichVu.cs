using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class GiaDichVu
    {
        public String saveData(String giaDVID, String loaiDVID, String tenDV, String donVi, Decimal donGia, String ketQuaBT, String cachDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEGIADICHVU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "giaDVID", "loaiDVID", "tenDV", "DONVI", "DONGIA", "KETQUABT", "CACHDUNG" };
            Object[] ThamTri = { giaDVID, loaiDVID, tenDV, donVi, donGia, ketQuaBT, cachDung };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "GIADVID", 8);
        }
        public void deleteData(String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.GIADICHVU Where giaDVID = '" + giaDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GIADICHVU Order By tenDV";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String loaiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GIADICHVU Where loaiDVID = '" + loaiDVID + "' Order By tenDV";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GIADICHVU Where giaDVID = '" + giaDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public void updateCachDung(String giaDVID, String cachDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "UPDATE PKDK.GIADICHVU SET CACHDUNG = '" + cachDung + "' Where giaDVID = '" + giaDVID + "' AND (CACHDUNG IS NULL OR CACHDUNG = '')";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}

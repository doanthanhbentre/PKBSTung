using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class GoiDichVu
    {
        public String saveData(String goiDVID, String loaiDVID, String tenGoiDV)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEGOIDICHVU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "GOIDVID", "LOAIDVID", "TENGOIDV" };
            Object[] ThamTri = { goiDVID, loaiDVID, tenGoiDV };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "GOIDVID", 5);
        }
        public void deleteData(String goiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.GOIDICHVU Where goiDVID = '" + goiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GOIDICHVU Order By GoiDVID";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String loaiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GOIDICHVU Where loaiDVID = '" + loaiDVID + "' Order By GoiDVID";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String goiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GOIDICHVU Where goiDVID = '" + goiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

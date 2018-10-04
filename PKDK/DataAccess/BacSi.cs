using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class BacSi
    {
        public String saveData(String maBS, String hoTen)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEBACSI";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MABS", "TENBS" };
            Object[] ThamTri = { maBS, hoTen };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "MABS", 3);
        }
        public void deleteData(String MABS)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.BACSI Where MABS = '" + MABS + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.BACSI Order By hoTen";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String MABS)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.BACSI Where MABS = '" + MABS + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

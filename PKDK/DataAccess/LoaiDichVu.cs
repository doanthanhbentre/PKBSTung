using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class LoaiDichVu
    {
        public String saveData(String loaiDVID, String tenLoaiDV)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVELOAIDICHVU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "loaiDVID", "tenLoaiDV" };
            Object[] ThamTri = { loaiDVID, tenLoaiDV };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "LOAIDVID", 2);
        }
        public void deleteData(String loaiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.LOAIDICHVU Where loaiDVID = '" + loaiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.LOAIDICHVU Order By loaiDVID";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataTable getCLS()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.LOAIDICHVU Where LoaiDVID <> '01' Order By loaiDVID";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String loaiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT * FROM PKDK.LOAIDICHVU WHERE LOAIDVID = '" + loaiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class ChiTietGoiDV
    {
        public void saveData(String goiDVID, String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "INSERT INTO PKDK.CHITIETGOIDV (GOIDVID, GIADVID) VALUES (?, ?)";
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "GOIDVID", "GIADVID" };
            Object[] ThamTri = { goiDVID, giaDVID };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String goiDVID, String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.CHITIETGOIDV Where goiDVID = '" + goiDVID + "' AND giaDVID = '" + giaDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable(String goiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select CT.giaDVID, DV.TENDV, DV.DONGIA From PKDK.CHITIETGOIDV CT JOIN PKDK.GIADICHVU DV ON CT.giaDVID = DV.giaDVID WHERE CT.GOIDVID = '" + goiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String goiDVID, String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.CHITIETGOIDV Where goiDVID = '" + goiDVID + "' AND giaDVID = '" + giaDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

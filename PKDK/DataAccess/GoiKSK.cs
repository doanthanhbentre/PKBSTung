using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class GoiKSK
    {

        public void saveData(Int64 goiKSKID, String tenGoi, double soTien)
        {
            if (goiKSKID > 0)
                updateData(goiKSKID, tenGoi, soTien);
            else
                insertData(tenGoi, soTien);
        }

        private void insertData(String tenGoi, double soTien)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "INSERT INTO PKDK.GOIKSK (TENGOI, SOTIEN) VALUES (?, ?)";
            String[] ThamBien = { "TENGOI", "SOTIEN" };
            Object[] ThamTri = { tenGoi, soTien };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }

        private void updateData(Int64 goiKSKID, String tenGoi, double soTien)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE PKDK.GOIKSK SET TENGOI = ?, SOTIEN = ? WHERE GOIKSKID = ?";
            String[] ThamBien = { "TENGOI", "SOTIEN", "GOIKSKID" };
            Object[] ThamTri = { tenGoi, soTien, goiKSKID };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(Int64 goiKSKID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.GOIKSK Where GOIKSKID = " + goiKSKID.ToString();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GOIKSK Order By TENGOI";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String goiKSKID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.GOIKSK Where GOIKSKID = " + goiKSKID.ToString();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

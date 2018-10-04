using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class PhongKham
    {
        public String saveData(String PHONGKHAMID, String TENPHONGKHAM)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEPHONGKHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "PHONGKHAMID", "TENPHONGKHAM" };
            Object[] ThamTri = { PHONGKHAMID, TENPHONGKHAM };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "PHONGKHAMID", 2);
        }
        public void deleteData(String PHONGKHAMID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.PHONGKHAM Where PHONGKHAMID = '" + PHONGKHAMID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.PHONGKHAM Order By PHONGKHAMID";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String PHONGKHAMID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.PHONGKHAM Where MABS = '" + PHONGKHAMID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

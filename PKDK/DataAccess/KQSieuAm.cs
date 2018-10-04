using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class KQSieuAm
    {
        public void saveData(String DOTKHAMID, String PHONGKHAMID, String MASP, String MABS, String GAN, String MAT, String TUY, String LACH, String THAN, String BANGQUANG, String TUCUNG, String PHANPHU, String TUICUNG, String DMCHUBUNG, String CQKHAC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEKQSIEUAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "MASP", "MABS", "GAN", "MAT", "TUY", "LACH", "THAN", "BANGQUANG", "TUCUNG", "PHANPHU", "TUICUNG", "DMCHUBUNG", "CQKHAC" };
            Object[] ThamTri = { DOTKHAMID, PHONGKHAMID, MASP, MABS, GAN, MAT, TUY, LACH, THAN, BANGQUANG, TUCUNG, PHANPHU, TUICUNG, DMCHUBUNG, CQKHAC };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String DOTKHAMID, String PHONGKHAMID, String MASP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.KQSIEUAM Where DOTKHAMID = '" + DOTKHAMID + "' AND PHONGKHAMID = '" + PHONGKHAMID + "' AND MASP = '" + MASP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.KQSIEUAM";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String DOTKHAMID, String PHONGKHAMID, String MASP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.KQSIEUAM Where DOTKHAMID = '" + DOTKHAMID + "' AND PHONGKHAMID = '" + PHONGKHAMID + "' AND MASP = '" + MASP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

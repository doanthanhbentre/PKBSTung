using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class SoKhamBenh
    {
        public void downOne(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.Text;
            data.CommandText = "UPDATE PKDK.DOTKHAM SET INSOKB = 1 WHERE DOTKHAMID = '" + dotKhamID + "'";
            data.ExecuteNonQuery();
        }
        public void upOne(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.Text;
            data.CommandText = "UPDATE PKDK.DOTKHAM SET INSOKB = 0 WHERE DOTKHAMID = '" + dotKhamID + "'";
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable(DateTime tuNgay, DateTime denNgay, Int16 inSoKB)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.CommandText = "PKDK.SOKHAMBENH";
            String[] ThamBien = { "TUNGAY", "DENNGAY", "INSOKB" };
            Object[] ThamTri = { tuNgay, denNgay, inSoKB };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable soKhamBenhA1(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.CommandText = "PKDK.SOKHAMBENH_A1";
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
    }
}

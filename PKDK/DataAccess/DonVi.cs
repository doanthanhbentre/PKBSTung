using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PKDK.DataAccess
{
    public class DonVi
    {
        public String saveData(String donViID, String tenDonVi)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEDONVI";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DONVIID", "TENDONVI" };
            Object[] ThamTri = { donViID, tenDonVi };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "donViID", 3);
        }
        public void deleteData(String donViID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE DUOC.DONVI WHERE DONVIID = '" + donViID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable selectData()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.DONVI ORDER BY DONVIID";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class PhieuThu
    {
        public String saveData(String maPT, String dotKhamID, DateTime ngay, String tenDangNhap, Double soTien, Double soTienGiam, String lyDoGiam)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEPHIEUTHU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPT", "DOTKHAMID", "NGAY", "TENDANGNHAP", "SOTIEN", "SOTIENGIAM", "LYDOGIAM" };
            Object[] ThamTri = { maPT, dotKhamID, ngay, tenDangNhap, soTien, soTienGiam, lyDoGiam };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "MAPT", 10);
        }
        public void deleteData(String maPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.PHIEUTHU Where MaPT = '" + maPT + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.PHIEUTHU WHERE NGAY BETWEEN '" + tuNgay.ToShortDateString() + "' AND '" + denNgay.ToShortDateString() + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String MaPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.PHIEUTHU Where MaPT = '" + MaPT + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable getBienLai(String MaPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.GETNOIDUNGTHU";
            data.CommandType = CommandType.StoredProcedure;
            return data.GetDataTable("MAPT", MaPT);
        }
        public DataTable getPhieuThu(String MaPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.GETCHITIETTHU";
            data.CommandType = CommandType.StoredProcedure;
            return data.GetDataTable("MAPT", MaPT);
        }
    }
}

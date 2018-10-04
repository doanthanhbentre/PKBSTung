using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class BenhNhan
    {
        public String saveData(String maBN, String hoTen, Decimal namSinh, Int32 gioiTinh, String diaChi, String dienthoai)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEBENHNHAN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MABN", "HOTEN", "NAMSINH", "GIOITINH", "DIACHI", "DIENTHOAI" };
            Object[] ThamTri = { maBN, hoTen, namSinh, gioiTinh, diaChi, dienthoai };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "MABN", 8);
        }
        public void deleteData(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.BenhNhan Where MaBN = '" + maBN + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.BenhNhan";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String tenBenhNhan)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.BenhNhan Where HoTen Like '%" + tenBenhNhan + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataRow getDataRow(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.BenhNhan Where MaBN = '" + maBN + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

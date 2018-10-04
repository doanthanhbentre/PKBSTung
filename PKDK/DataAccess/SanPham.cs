using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PKDK.DataAccess
{
    public class SanPham
    {
        public String saveData(String MASP, String LOAISPID, String DONVIID, String HOATCHATID, String TENSP, String HAMLUONG, String SODANGKY, double GIANHAP, double GIAXUAT, Int16 HIDE)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVESANPHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MASP", "LOAISPID", "DONVIID", "HOATCHATID", "TENSP", "HAMLUONG", "SODANGKY", "GIANHAP", "GIAXUAT", "HIDE" };
            Object[] ThamTri = { MASP, LOAISPID, DONVIID, HOATCHATID, TENSP, HAMLUONG, SODANGKY, GIANHAP, GIAXUAT, HIDE };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "MASP", 10);
        }
        public void deleteData(String MASP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From DUOC.SANPHAM Where MASP = '" + MASP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT SP.MASP, SP.TENSP, DV.TENDONVI, DV.DONVIID, SP.GIAXUAT FROM DUOC.SANPHAM SP JOIN DUOC.DONVI DV ON SP.DONVIID = DV.DONVIID ORDER BY MASP";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}

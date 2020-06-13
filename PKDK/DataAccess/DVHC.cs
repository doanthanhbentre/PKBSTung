using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class DVHC
    {
        public DataTable getDVHC(String value)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.VIEWDVHC WHERE TENTAT LIKE '" + value.ToUpper() + "%' OR UCASE(TENDVHC) LIKE '%" + value.ToUpper() + "%'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getTinhThanh()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.TINHTHANH ORDER BY MATT";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getQuanHuyen(String maTT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.QUANHUYEN WHERE MATT = '" + maTT + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getXaPhuong(String maQH)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.XAPHUONG WHERE MAQH = '" + maQH + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public void themXaPhuong(String maXP, String maQH, String tenXP, String tenTat)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "INSERT INTO PKDK.XAPHUONG (MAXP, MAQH, TENXP, TENTAT) VALUES (?, ?, ?, ?)";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "MAXP", "MAQH", "TENXP", "TENTAT" };
            Object[] ThamTri = { maXP, maQH, tenXP, tenTat };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void suaXaPhuong(String maXP, String maQH, String tenXP, String tenTat)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "UPDATE PKDK.XAPHUONG SET MAQH=?, TENXP=?, TENTAT=? WHERE MAXP=?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "MAQH", "TENXP", "TENTAT", "MAXP" };
            Object[] ThamTri = { maQH, tenXP, tenTat, maXP };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void xoaXaPhuong(String maXP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "DELETE PKDK.XAPHUONG WHERE MAXP = '" + maXP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}

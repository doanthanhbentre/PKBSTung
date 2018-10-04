using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DataAccess
{
    public class PhieuThuChiTiet
    {
        public void saveData(String chiTietID, String dotKhamID, String noiDung, Double soTien)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEPHIEUTHUCHITIET";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "CHITIETID", "DOTKHAMID", "NOIDUNG", "SOTIEN" };
            Object[] ThamTri = { chiTietID, dotKhamID, noiDung, soTien };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT * FROM PKDK.PHIEUTHUCHITIET WHERE DOTKHAMID = '" + dotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable2(String dotKhamID)
        {
            String m_SQL = "SELECT DK.DOTKHAMID, BN.MABN, BN.HOTEN, BN.NAMSINH, CASE WHEN BN.GIOITINH = 0 THEN 'Nam' ELSE 'Nữ' END AS GIOITINH, BN.DIACHI, DK.CHANDOAN, PT.NOIDUNG, PT.SOTIEN ";
            m_SQL += "FROM PKDK.PHIEUTHUCHITIET PT JOIN PKDK.DOTKHAM DK ON PT.DOTKHAMID = DK.DOTKHAMID JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN ";
            m_SQL += "WHERE DK.DOTKHAMID = '" + dotKhamID + "' AND PT.SOTIEN > 0";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}

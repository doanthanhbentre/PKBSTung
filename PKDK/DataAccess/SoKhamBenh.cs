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
        public DataTable soCLS(DateTime tuNgay, DateTime denNgay, String dieuKien)
        {
            String m_SQL = "SELECT DK.DOTKHAMID, DK.NGAY, BN.HOTEN, CASE WHEN BN.GIOITINH = 0 THEN YEAR(NGAY) - BN.NAMSINH ELSE 0 END AS TUOINAM, CASE WHEN BN.GIOITINH != 0 THEN YEAR(NGAY) - BN.NAMSINH ELSE 0 END AS TUOINU, ";
            m_SQL += " '' AS SOTHEBHYT, BN.DIACHI, '' AS NGHENGHIEP, '' AS DANTOC, '' AS TRIEUCHUNG, DK.CHANDOAN, (SELECT LISTAGG(KETQUA, '; ') FROM PKDK.CHIDINH WHERE (KETQUA IS NOT NULL OR KETQUA != '') AND DOTKHAMID = DK.DOTKHAMID) AS PHUONGPHAP, BS.HOTEN AS BACSI ";
            m_SQL += "FROM PKDK.DOTKHAM DK JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN JOIN PKDK.BACSI BS ON DK.MABS = BS.MABS ";
            m_SQL += "WHERE DK.NGAY BETWEEN '" + tuNgay.ToShortDateString() + "' AND '" + denNgay.ToShortDateString() + "' ";
            m_SQL += "AND DK.DOTKHAMID IN (SELECT DOTKHAMID FROM PKDK.CHIDINH WHERE GIADVID IN " + dieuKien + ") ";
            m_SQL += "ORDER BY DK.NGAY ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.Text;
            data.CommandText = m_SQL;
            return data.GetDataTable();
        }
        public DataTable soKSK(DateTime tuNgay, DateTime denNgay)
        {
            String m_SQL = "SELECT DK.DOTKHAMID, DK.NGAY, BN.HOTEN, CASE WHEN BN.GIOITINH = 0 THEN YEAR(NGAY) - BN.NAMSINH ELSE 0 END AS TUOINAM, CASE WHEN BN.GIOITINH != 0 THEN YEAR(NGAY) - BN.NAMSINH ELSE 0 END AS TUOINU, ";
            m_SQL += " '' AS SOTHEBHYT, BN.DIACHI, '' AS NGHENGHIEP, '' AS DANTOC, '' AS TRIEUCHUNG, DK.CHANDOAN, (SELECT LISTAGG(KETQUA, '; ') FROM PKDK.CHIDINH WHERE (KETQUA IS NOT NULL OR KETQUA != '') AND DOTKHAMID = DK.DOTKHAMID) AS PHUONGPHAP, BS.HOTEN AS BACSI ";
            m_SQL += "FROM PKDK.DOTKHAM DK JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN JOIN PKDK.BACSI BS ON DK.MABS = BS.MABS ";
            m_SQL += "WHERE DK.NGAY BETWEEN '" + tuNgay.ToShortDateString() + "' AND '" + denNgay.ToShortDateString() + "' ";
            m_SQL += "AND DK.BAOHIEM = 1 ";
            m_SQL += "ORDER BY DK.NGAY ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.Text;
            data.CommandText = m_SQL;
            return data.GetDataTable();
        }
        public DataTable bienBanDoiChieu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.CommandText = "PKDK.SOKSK";
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
    }
}

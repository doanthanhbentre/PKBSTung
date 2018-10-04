using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class KetQuaCD
    {
        public void saveData(String dotKhamID, String phongKhamID, String maSP, String maBS, String ketQua)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEKETQUACD";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "MASP", "MABS", "KETQUA" };
            Object[] ThamTri = { dotKhamID, phongKhamID, maSP, maBS, ketQua };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String dotKhamID, String phongKhamID, String maSP, String maBS)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.KETQUACD Where DOTKHAMID = '" + dotKhamID + "' AND PHONGKHAMID = '" + phongKhamID + "' AND MASP = '" + maSP + "' AND MABS = '" + maBS + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void insertData(String dotKhamID)
        {
            String m_SQL = "MERGE INTO PKDK.KETQUACD KQ USING (SELECT DOTKHAMID, PHONGKHAMID, MASP, MABS, '' AS KETQUA FROM PKDK.CHIDINH WHERE LEFT(MASP, 2)='02' AND DOTKHAMID = '" + dotKhamID + "') CD ";
            m_SQL += "ON (KQ.DOTKHAMID = CD.DOTKHAMID AND KQ.PHONGKHAMID = CD.PHONGKHAMID AND KQ.MASP = CD.MASP) WHEN NOT MATCHED THEN INSERT (DOTKHAMID, PHONGKHAMID, MASP, MABS, KETQUA) VALUES (CD.DOTKHAMID, CD.PHONGKHAMID, CD.MASP, CD.MABS, CD.KETQUA)";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT KQ.DOTKHAMID, KQ.PHONGKHAMID, KQ.MASP, KQ.MABS, DK.NGAY, PK.TENPHONGKHAM, BS.TENBS, SP.TENSP, KQ.KETQUA, SP.KETQUABT ";
            m_SQL += "FROM PKDK.KETQUACD KQ ";
            m_SQL += "JOIN PKDK.DOTKHAM DK ON KQ.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "JOIN PKDK.PHONGKHAM PK ON KQ.PHONGKHAMID = PK.PHONGKHAMID ";
            m_SQL += "JOIN PKDK.BACSI BS ON KQ.MABS = BS.MABS ";
            m_SQL += "JOIN PKDK.SANPHAM SP ON KQ.MASP = SP.MASP ";
            m_SQL += "WHERE DK.MABN = '" + maBN + "' ";
            m_SQL += "ORDER BY KQ.DOTKHAMID DESC";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

        public DataTable getDataTable(String dotKhamID, DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT KQ.DOTKHAMID, KQ.PHONGKHAMID, KQ.MASP, KQ.MABS, DK.NGAY, PK.TENPHONGKHAM, BS.TENBS, SP.TENSP, KQ.KETQUA, SP.KETQUABT ";
            m_SQL += "FROM PKDK.KETQUACD KQ ";
            m_SQL += "JOIN PKDK.DOTKHAM DK ON KQ.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "JOIN PKDK.PHONGKHAM PK ON KQ.PHONGKHAMID = PK.PHONGKHAMID ";
            m_SQL += "JOIN PKDK.BACSI BS ON KQ.MABS = BS.MABS ";
            m_SQL += "JOIN PKDK.SANPHAM SP ON KQ.MASP = SP.MASP ";
            m_SQL += "WHERE DK.DOTKHAMID = '" + dotKhamID + "' AND DK.NGAY = ? ";
            m_SQL += "ORDER BY KQ.DOTKHAMID DESC";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable("NGAY", ngay);
        }

        public DataRow getDataRow(String dotKhamID, String phongKhamID, String maSP, String maBS)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.KETQUACD Where DOTKHAMID = '" + dotKhamID + "' AND PHONGKHAMID = '" + phongKhamID + "' AND MASP = '" + maSP + "' AND MABS = '" + maBS + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable ketQuaXQ(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT DK.DOTKHAMID, DK.MABN, BN.HOTEN, BN.NAMSINH, CASE WHEN BN.GIOITINH = 0 THEN 'Nam' ELSE 'Nữ' END AS GIOITINH, BN.DIACHI, DK.CHANDOAN, CURRENT DATE AS NGAYIN, BS.TENBS AS BACSI, KQ.KETQUA ";
            m_SQL += "FROM PKDK.KETQUACD KQ ";
            m_SQL += "JOIN PKDK.DOTKHAM DK ON KQ.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN ";
            m_SQL += "JOIN PKDK.BACSI BS ON KQ.MABS = BS.MABS ";
            m_SQL += "WHERE DK.DOTKHAMID = '" + dotKhamID + "' AND KQ.MASP = '02000009' ";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}

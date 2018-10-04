using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QLPK.DataAccess
{
    public class PhieuDichVu
    {
        public void saveData(String dotKhamID, String phongKhamID, String goiDVID, DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Insert Into PKDK.PhieuDichVu (DotKhamID, PhongKhamID, GoiDVID, Ngay) Values (?, ?, ?, ?)";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "DotKhamID", "BuongKhamID", "GoiDVID", "Ngay" };
            Object[] ThamTri = { dotKhamID, phongKhamID, goiDVID, ngay };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String dotKhamID, String buongKhamID, String goiDVID, DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete PKDK.PhieuDichVu Where Where DotKhamID = ? And BuongKhamID = ? And GoiDVID = ? And Ngay = ?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "DotKhamID", "BuongKhamID", "GoiDVID", "Ngay" };
            Object[] ThamTri = { dotKhamID, buongKhamID, goiDVID, ngay };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable seleteData(String goiDVID, DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT PDV.DOTKHAMID, PDV.PHONGKHAMID, PDV.GOIDVID, PDV.NGAY, BN.MABN, BN.HOTEN, BN.NAMSINH, PK.TENPHONGKHAM, BN.DIACHI, BN.GIOITINH, BS.TENBS, DK.CHANDOAN ";
            m_SQL += "FROM PKDK.PHIEUDICHVU PDV ";
            m_SQL += "JOIN PKDK.DOTKHAM DK ON PDV.DOTKHAMID = DK.DOTKHAMID AND PDV.PHONGKHAMID = DK.PHONGKHAMID ";
            m_SQL += "JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN ";
            m_SQL += "JOIN PKDK.PHONGKHAM PK ON PDV.PHONGKHAMID = PK.PHONGKHAMID ";
            m_SQL += "JOIN PKDK.BACSI BS ON DK.MABS = BS.MABS ";
            m_SQL += "WHERE PDV.GOIDVID = ? AND PDV.NGAY = ?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "GoiDVID", "Ngay" };
            Object[] ThamTri = { goiDVID, ngay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
    }
}

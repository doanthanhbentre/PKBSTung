using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PKDK.DataAccess
{
    public class GiayGioiThieu
    {
        public String saveData(String giayGTID, String DOTKHAMID, String PHONGKHAMID, DateTime ngay, String gioiThieuDen, String noiDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVEGIAYGIOITHIEU";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "GIAYGTID", "DOTKHAMID", "PHONGKHAMID", "NGAY", "GIOITHIEUDEN", "NOIDUNG" };
            Object[] ThamTri = { giayGTID, DOTKHAMID, PHONGKHAMID, ngay, gioiThieuDen, noiDung };
            return data.sExecuteNonQuery(ThamBien, ThamTri, "GIAYGTID", 10);
        }

        public void deleteData(String giayGTID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.GiayGioiThieu Where GiayGTID = '" + giayGTID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteDotKham(String dotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.GiayGioiThieu Where DotKhamID = '" + dotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getListData(String maBN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT GT.GIAYGTID, GT.DOTKHAMID, GT.PHONGKHAMID, TO_CHAR(GT.NGAY, 'DD/MM/YYYY') AS NGAY1, GT.NGAY, DK.CHANDOAN, GT.GIOITHIEUDEN, GT.NOIDUNG ";
            m_SQL += "FROM PKDK.GIAYGIOITHIEU GT JOIN PKDK.DOTKHAM DK ON GT.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "WHERE DK.MABN = '" + maBN + "' ";
            m_SQL += "ORDER BY GT.NGAY DESC ";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String giayGTID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT GT.GIAYGTID, GT.DOTKHAMID, GT.PHONGKHAMID, GT.NGAY, DK.CHANDOAN, GT.GIOITHIEUDEN, GT.NOIDUNG, ";
            m_SQL += "BN.MABN, BN.HOTEN, BN.NAMSINH, BN.DIACHI, BS.HOTEN AS BACSI ";
            m_SQL += "FROM PKDK.GIAYGIOITHIEU GT JOIN PKDK.DOTKHAM DK ON GT.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN ";
            m_SQL += "JOIN PKDK.BACSI BS ON DK.MABS = BS.MABS ";
            m_SQL += "WHERE GT.GIAYGTID = '" + giayGTID + "' ";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}

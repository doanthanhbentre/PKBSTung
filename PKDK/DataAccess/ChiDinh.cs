using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class ChiDinh
    {
        public void saveData(String DOTKHAMID, String PHONGKHAMID, String GIADVID, Double SOLUONG, Double DONGIA)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.SAVECHIDINH";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DOTKHAMID", "PHONGKHAMID", "GIADVID", "SOLUONG", "DONGIA" };
            Object[] ThamTri = { DOTKHAMID, PHONGKHAMID, GIADVID, SOLUONG, DONGIA };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }

        public void updateMaPT(String DotKhamID, String maPT)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Update PKDK.ChiDinh set MaPT = null Where DotKhamID = ? And MaPT = ?";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "DOTKHAMID", "MAPT" };
            Object[] ThamTri = { DotKhamID, maPT };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.ChiDinh Where DotKhamID = '" + DotKhamID + "' AND MAPT IS NULL AND LEFT(MASP, 2) != '01'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteDotKham(String DotKhamID, String PhongKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.ChiDinh Where DotKhamID = '" + DotKhamID + "' AND MAPT IS NULL And PhongKhamID = '" + PhongKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void deleteData(String DotKhamID, String giaDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Delete From PKDK.ChiDinh Where DotKhamID = '" + DotKhamID + "' And GIADVID = '" + giaDVID + "' AND MAPT IS NULL";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }

        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From ChiTietDon";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select SP.MaSP, SP.TenSP, SP.DonVi, CT.SoLuong, CT.DonGia, CT.SoLuong * CT.DonGia As ThanhTien, CT.CachDung From PKDK.ChiDinh CT Inner Join PKDK.SanPham SP On CT.MaSP = SP.MaSP ";
            m_SQL += "Where DotKhamID = '" + DotKhamID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String DotKhamID, String LoaiDVID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "SELECT CD.GIADVID, GIA.TENDV, GIA.DONVI, CD.SOLUONG, CD.DONGIA, CD.SOLUONG * CD.DONGIA AS THANHTIEN, CD.MAPT ";
            m_SQL += "FROM PKDK.CHIDINH CD JOIN PKDK.GIADICHVU GIA ON CD.GIADVID = GIA.GIADVID ";
            if (LoaiDVID == "")
                m_SQL += "Where CD.DOTKHAMID = '" + DotKhamID + "'";
            else
                m_SQL += "Where CD.DOTKHAMID = '" + DotKhamID + "' AND GIA.LOAIDVID = '" + LoaiDVID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        //Lay chi dinh thuoc
        public DataTable getDataTable1(String DotKhamID, String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select SP.MaSP, SP.TenSP, SP.DonVi, CT.SoLuong, CT.DonGia, CT.SoLuong * CT.DonGia As ThanhTien, CT.CachDung From PKDK.ChiDinh CT Inner Join PKDK.SanPham SP On CT.MaSP = SP.MaSP ";
            m_SQL += "Where DotKhamID = '" + DotKhamID + "' ";
            m_SQL += "And SP.LoaiSPID = '" + LoaiSPID + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getCDHA_DV(String DotKhamID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select SP.MaSP, SP.TenSP, SP.DonGia As SoTien From PKDK.ChiDinh CT Inner Join PKDK.SanPham SP On CT.MaSP = SP.MaSP ";
            m_SQL += "Where DotKhamID = '" + DotKhamID + "' AND SP.MASP NOT IN (SELECT CHITIETID FROM PKDK.PHIEUTHUCHITIET WHERE DOTKHAMID = '" + DotKhamID + "')";
            m_SQL += "And SP.LoaiSPID IN ('02', '04')";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String DotKhamID, String maSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.ChiDinh Where DotKhamID = '" + DotKhamID + "' And MaSP = '" + maSP + "'";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        
        public DataRow getSoTien(String DotKhamID)
        {
            String m_SQL = "SELECT SUM(SOLUONG * DONGIA) AS SOTIEN, ";
            m_SQL += "SUM(CASE WHEN MAPT IS NOT NULL THEN SOLUONG * DONGIA ELSE 0 END) AS DATHU, ";
            m_SQL += "SUM(CASE WHEN MAPT IS NULL THEN SOLUONG * DONGIA ELSE 0 END) AS CHUATHU ";
            m_SQL += "FROM PKDK.CHIDINH WHERE DOTKHAMID = '" + DotKhamID + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable getChiPhi(String DotKhamID)
        {
            String m_SQL = "SELECT CASE WHEN CD.MAPT IS NULL THEN 0 ELSE 1 END AS DATHU, CD.MAPT, ";
            m_SQL += "SP.MASP, SP.TENSP, SP.DONVI, CD.SOLUONG, CD.DONGIA, CD.SOLUONG * CD.DONGIA AS THANHTIEN ";
            m_SQL += "FROM PKDK.CHIDINH CD JOIN PKDK.SANPHAM SP ON CD.MASP = SP.MASP ";
            m_SQL += "WHERE CD.DOTKHAMID = '" + DotKhamID + "' ORDER BY CD.MAPT";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getPhieuChiDinh(String dotKhamID, String loadDVID)
        {
            String m_SQL = "SELECT CD.DOTKHAMID, BN.MABN, BN.HOTEN, BN.NAMSINH, ";
            m_SQL += "CASE WHEN BN.GIOITINH = 0 THEN 'Nam' ELSE 'Nữ' END GIOITINH, GIA.TENDV, ";
            m_SQL += "BS.HOTEN AS BACSI, BN.DIACHI, DK.CHANDOAN ";
            m_SQL += "FROM PKDK.CHIDINH CD JOIN PKDK.GIADICHVU GIA ON CD.GIADVID = GIA.GIADVID ";
            m_SQL += "JOIN PKDK.DOTKHAM DK ON CD.DOTKHAMID = DK.DOTKHAMID ";
            m_SQL += "JOIN PKDK.BENHNHAN BN ON DK.MABN = BN.MABN ";
            m_SQL += "JOIN PKDK.BACSI BS ON DK.MABS = BS.MABS ";
            m_SQL += "WHERE CD.DOTKHAMID = '" + dotKhamID + "' AND GIA.LOAIDVID = '" + loadDVID + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}

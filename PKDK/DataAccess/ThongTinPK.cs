using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class ThongTinPK
    {
        String m_TenPK, m_DiaChi, m_SoDangKy, m_DienThoai, m_GioSang, m_GioTrua, m_GioChieu;
        public String TenPK
        {
            get { return m_TenPK; }
            set { m_TenPK = value; }
        }

        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        public String SoDangKy
        {
            get { return m_SoDangKy; }
            set { m_SoDangKy = value; }
        }

        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

        public String GioSang
        {
            get { return m_GioSang; }
            set { m_GioSang = value; }
        }

        public String GioTrua
        {
            get { return m_GioTrua; }
            set { m_GioTrua = value; }
        }

        public String GioChieu
        {
            get { return m_GioChieu; }
            set { m_GioChieu = value; }
        }
        public void loadData()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            String m_SQL = "Select * From PKDK.THONGTINPK";
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            DataRow dr = data.GetDataRow();
            if (dr != null)
            {
                m_TenPK = dr["TenPK"].ToString();
                m_DiaChi = dr["DiaChi"].ToString();
                m_SoDangKy = dr["SoDangKy"].ToString();
                m_DienThoai = dr["DienThoai"].ToString();
                m_GioSang = dr["GioSang"].ToString();
                m_GioTrua = dr["GioTrua"].ToString();
                m_GioChieu = dr["GioChieu"].ToString();
            }
            else
            {
                m_TenPK = "";
                m_DiaChi = "";
                m_SoDangKy = "";
                m_DienThoai = "";
                m_GioSang = "";
                m_GioTrua = "";
                m_GioChieu = "";
            }
        }
    }
}

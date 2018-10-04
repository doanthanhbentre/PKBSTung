using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class ThongKe
    {
        public DataTable thongKeDichVu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable thongKeDichVuBS(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVUBS";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable thongKeDichVuBSThu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVUBSTHU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable thongKeDichVuThu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVUTHU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable thongKeDichVuThuNgan(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVUTHUNGAN";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable thongKeDichVuThuBN(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVUTHUBN";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable baoCaoThue(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.BAOCAOTHUE";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
    }
}

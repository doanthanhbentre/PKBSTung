using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLPK.DataAccess
{
    public class ChiPhi
    {
        public DataTable listChuaThu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.LISTCHUATHU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable listDaThu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.LISTDATHU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getTKDichVu(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKDICHVU";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getTKBenhNhan(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKBENHNHAN";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getTKThuoc(DateTime tuNgay, DateTime denNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "PKDK.TKTHUOC";
            data.CommandType = CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { tuNgay, denNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
    }
}

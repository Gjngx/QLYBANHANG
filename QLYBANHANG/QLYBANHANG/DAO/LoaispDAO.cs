using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    public class loaispDAO
    {
        private static loaispDAO instance;
        public static loaispDAO Instance
        {
            get { if (instance == null) instance = new loaispDAO(); return instance; }
            private set { loaispDAO.instance = value; }
        }

        private loaispDAO() { }

        public List<loaisp> xuatdsloai()
        {
            List<loaisp> ds = new List<loaisp>();

            string query = "SELECT * FROM dbo.LOAISP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                loaisp loai = new loaisp(item);
                ds.Add(loai);
            }
            return ds;
        }

        public loaisp xuatloaisp(string maloaisp)
        {
            loaisp l = null;
            string query = "SELECT * FROM dbo.LOAISP WHERE MALOAISP = '" + maloaisp + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                l = new loaisp(item);
                return l;
            }
            return l;
        }

        public bool themloaisp(string maloaisp, string tenloaisp)
        {
            string q = string.Format("INSERT dbo.LOAISP( MALOAISP , TENLOAISP) VALUES( '{0}' , N'{1}' )", maloaisp, tenloaisp);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool sualoaisp(string tenloaisp, string maloaisp)
        {
            string q = string.Format("UPDATE dbo.LOAISP SET TENLOAISP = N'{0}' WHERE MALOAISP = '{1}' ", tenloaisp, maloaisp);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool xoadanhmuc(string masanpham)
        {
            string q = string.Format("EXEC XOASANPHAM @MASANPHAM = " + masanpham);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public int timloaisp(string masanpham)
        {
            string q = string.Format("SELECT COUNT (*) FROM DBO.LOAISP WHERE MALOAISP = '{0}'", masanpham);

            return (int)DataProvider.Instance.ExecuteScalar(q) ;
        }
    }
}

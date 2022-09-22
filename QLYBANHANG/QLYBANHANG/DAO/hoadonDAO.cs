using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    internal class hoadonDAO
    {
        private static hoadonDAO instance;
        public static hoadonDAO Instance
        {
            get { if (instance == null) instance = new hoadonDAO(); return instance; }
            private set { hoadonDAO.instance = value; }
        }

        private hoadonDAO() { }
        public List<sanphamhd> dssanpham()
        {
            List<sanphamhd> ds = new List<sanphamhd>();

            string query = "EXEC TAIDSSANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanphamhd m = new sanphamhd(item);
                ds.Add(m);
            }

            return ds;
        }
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

        public List<sanphamhd> timsanpham(string masanpham)
        {
            List<sanphamhd> ds = new List<sanphamhd>();

            string query = string.Format("SELECT TENLOAISP, MASP, TENSP, GIA  FROM dbo.SANPHAM, dbo.LOAISP WHERE SANPHAM.MAlOAISP = LOAISP.MALOAISP AND MASP LIKE N'%{0}%'", masanpham);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanphamhd m = new sanphamhd(item);
                ds.Add(m);
            }
            return ds;
        }
    }
}

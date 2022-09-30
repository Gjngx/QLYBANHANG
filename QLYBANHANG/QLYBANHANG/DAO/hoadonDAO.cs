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

        public void taohd()
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC THEMHD");
        }

        public void themcthd(int sohd, string masp, int soluong)
        {
            DataProvider.Instance.ExecuteNonQuery("THEMCTHD @sohd , @masp , @soluong ", new object[] { sohd, masp, soluong });
        }
        public int xuatmahoadon()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX (SOHD) FROM dbo.HOADON");
            }

            catch
            {
                return 1;
            }
        }

        public int ktrahoadon()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HOADON WHERE TRANGTHAI = 0");

            if (data.Rows.Count > 0)

            {
                hoadon hd = new hoadon(data.Rows[0]);
                return hd.Sohd;
            }
            return -1;
        }
        public List<taohoadon> xuatdshoadon()
        {
            List<taohoadon> dshd = new List<taohoadon>();

            string query = "SELECT SP.TENSP, C.SOLUONG, SP.GIA, SP.GIA * C.SOLUONG AS TONGTIEN FROM dbo.HOADON AS HD, dbo.CTHD AS C, dbo.SANPHAM AS SP WHERE C.SOHD = HD.SOHD AND C.MASP = SP.MASP AND HD.TRANGTHAI = 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                taohoadon m = new taohoadon(item);
                dshd.Add(m);
            }

            return dshd;
        }
        public void thanhtoan(int sohd, float tongtien)
        {
            string query = "UPDATE dbo.HOADON SET NGAYTHANHTOAN = GETDATE() , tongtien = " + tongtien + " , TRANGTHAI = 1 WHERE SOHD = " + sohd;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}

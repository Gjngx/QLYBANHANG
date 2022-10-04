using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    public class sanphamDAO
    {
        private static sanphamDAO instance;

        public static sanphamDAO Instance
        {
            get { if (instance == null) instance = new sanphamDAO(); return instance; }
            private set { sanphamDAO.instance = value; }
        }

        private sanphamDAO() { }

        public List<sanpham> xuatdssanpham(string maloaisp)
        {
            List<sanpham> ds = new List<sanpham>();

            string query = "SELECT * FROM dbo.SANPHAM WHERE MALOAISP = '" + maloaisp + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanpham sp = new sanpham(item);
                ds.Add(sp);
            }

            return ds;

        }

        public List<sanpham> dssanpham()
        {
            List<sanpham> ds = new List<sanpham>();

            string query = "EXEC TAIDSSP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanpham sp = new sanpham(item);
                ds.Add(sp);
            }

            return ds;
        }

        public bool themsanpham(string masp, string tensp, string maloaisp, float gia)
        {
            string q = string.Format("INSERT dbo.SANPHAM(MASP , TENSP , MALOAISP , GIA ) VALUES(   '{0}' , '{1}' , N'{2}', '{3}' )", masp, tensp, maloaisp, gia);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool suasanpham(string masp,string tensp, string maloaisp, float gia)
        {
            string q = string.Format("UPDATE dbo.SANPHAM SET TENSP = '{0}' , MALOAISP = N'{1}', GIA =N'{2}' WHERE MASP = '{3}' ", tensp, maloaisp, gia, masp);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool xoasanpham(string masp)
        {
            string q = string.Format("DELETE dbo.SANPHAM WHERE MASP = '" + masp + "'");
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public List<sanpham> timsanphamtheoma(string tensp)
        {
            List<sanpham> ds = new List<sanpham>();

            string query = string.Format("SELECT MASP, TENSP, TENLOAISP, GIA  FROM dbo.SANPHAM,dbo.LOAISP WHERE SANPHAM.MAlOAISP = LOAISP.MALOAISP and MASP like N'%{0}%'", tensp);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanpham sp = new sanpham(item);
                ds.Add(sp);
            }

            return ds;
        }

        public int timmasp(string masanpham)
        {
            string q = string.Format("SELECT COUNT (*) FROM DBO.SANPHAM WHERE MASP = '{0}'", masanpham);

            return (int)DataProvider.Instance.ExecuteScalar(q);
        }


        public int kttenloai(string tenloaisp)
        {
            string q = string.Format("select count (*) from dbo.LOAISP where TENLOAISP = N'{0}'",tenloaisp);
            return (int)DataProvider.Instance.ExecuteScalar(q);
        }

    }
}

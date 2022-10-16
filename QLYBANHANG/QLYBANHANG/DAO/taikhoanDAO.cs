using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    internal class taikhoanDAO
    {
        private static taikhoanDAO instance;
        public static taikhoanDAO Instance
        {
            get { if (instance == null) instance = new taikhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private taikhoanDAO() { }

        public bool dangnhap(string tendn, string matkhau)
        {
            string query = "DANGNHAP @TENDANGNHAP , @MATKHAU";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tendn, matkhau });
            return result.Rows.Count > 0;
        }

        public taikhoan xuattktheotendn(string tendn)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TAIKHOAN WHERE TAIKHOAN = '" + tendn + "'");
            foreach (DataRow item in data.Rows)
            {
                return new taikhoan(item);
            }
            return null;
        }
        public bool capnhattaikhoan(string tendn, string hoten, string matkhau)
        {
            int r = DataProvider.Instance.ExecuteNonQuery("EXEC CAPNHATTAIKHOAN @TENDANGNHAP , @HOTEN , @MATKHAU", new object[] { tendn, hoten, matkhau });
            return r > 0;
        }

        public bool capnhatmatkhau(string tendn, string matkhau, string matkhaumoi)
        {
            int r = DataProvider.Instance.ExecuteNonQuery("EXEC CAPNHATMATKHAU @TENDANGNHAP , @MATKHAU , @MATKHAUMOI", new object[] { tendn, matkhau, matkhaumoi });
            return r > 0;
        }

        public List<taikhoan> xuatdstaikhoan()
        {
            List<taikhoan> ds = new List<taikhoan>();

            string query = "SELECT * FROM dbo.TAIKHOAN";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                taikhoan tk = new taikhoan(item);
                ds.Add(tk);
            }
            return ds;
        }

        public DataTable xuatdstk()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TENDANGNHAP , TENNHANVIEN , QUYEN FROM dbo.TAIKHOAN");
        }

        public bool themtaikhoan(string tendn, string tennv, int quyen)
        {
            string q = string.Format("INSERT dbo.TAIKHOAN( TENDANGNHAP , TENNHANVIEN , QUYEN, PASS  ) VALUES(   '{0}' , N'{1}' , {2}, '20720532132149213101239102231223249249135100218' )", tendn, tennv, quyen);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool suataikhoai(string tendn, string tennv, int quyen)
        {
            string q = string.Format("UPDATE dbo.TAIKHOAN SET TENNHANVIEN = N'{0}' , QUYEN = {1} WHERE TENDANGNHAP = '{2}' ", tennv, quyen, tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public bool xoataikhoan(string tendn)
        {
            string q = string.Format("DELETE dbo.TAIKHOAN WHERE TENDANGNHAP = '{0}'", tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public bool datlaimatkhau(string tendn, string mk)
        {
            string q = string.Format("UPDATE dbo.TAIKHOAN SET PASS = '{0}' WHERE TENDANGNHAP = '{1}'", mk, tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }

        public List<taikhoan> timtaikhoan(string tennv)
        {
            List<taikhoan> ds = new List<taikhoan>();

            string query = string.Format("SELECT * FROM dbo.TAIKHOAN WHERE TENNHANVIEN LIKE N'%{0}%'", tennv);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                taikhoan tk = new taikhoan(item);
                ds.Add(tk);
            }

            return ds;
        }

    }
}
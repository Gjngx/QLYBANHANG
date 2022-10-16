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
            return DataProvider.Instance.ExecuteQuery("SELECT TAIKHOAN , HOTEN , PHANQUYEN FROM dbo.TAIKHOAN");
        }
        public bool datlaimatkhau(string tendn, string mk)
        {
            string q = string.Format("UPDATE dbo.TAIKHOAN SET MATKHAU = '{0}' WHERE TAIKHOAN = '{1}'", mk, tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public int timtaikhoan(string taikhoan)
        {
            string q = string.Format("SELECT COUNT (*) FROM DBO.TAIKHOAN WHERE TAIKHOAN = '{0}'", taikhoan);

            return (int)DataProvider.Instance.ExecuteScalar(q);
        }
        public List<taikhoan> timtaikhoanbanghoten(string hoten)
        {
            List<taikhoan> ds = new List<taikhoan>();

            string query = string.Format("SELECT * FROM dbo.TAIKHOAN WHERE HOTEN LIKE N'%{0}%'", hoten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                taikhoan sp = new taikhoan(item);
                ds.Add(sp);
            }

            return ds;
        }
        public bool themtaikhoan(string tendn, string tennv, int quyen)
        {
            string q = string.Format("INSERT dbo.TAIKHOAN( TAIKHOAN , HOTEN , PHANQUYEN, MATKHAU  ) VALUES(   '{0}' , N'{1}' , {2}, '0' )", tendn, tennv, quyen);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public bool suataikhoai(string tendn, string tennv, int quyen)
        {
            string q = string.Format("UPDATE dbo.TAIKHOAN SET HOTEN = N'{0}' , PHANQUYEN = {1} WHERE TAIKHOAN = '{2}' ", tennv, quyen, tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
        public bool xoataikhoan(string tendn)
        {
            string q = string.Format("DELETE dbo.TAIKHOAN WHERE TAIKHOAN = '{0}'", tendn);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
    }
}
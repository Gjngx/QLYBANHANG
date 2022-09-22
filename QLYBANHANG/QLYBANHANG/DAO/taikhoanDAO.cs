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
    }
}

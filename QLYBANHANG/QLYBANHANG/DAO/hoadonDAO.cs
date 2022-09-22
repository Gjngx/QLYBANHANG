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
        public List<sanpham> dssanpham()
        {
            List<sanpham> ds = new List<sanpham>();

            string query = "EXEC TAIDSSANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanpham m = new sanpham(item);
                ds.Add(m);
            }

            return ds;
        }
    }
}

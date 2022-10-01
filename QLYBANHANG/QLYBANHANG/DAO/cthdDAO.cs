using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    public class cthdDAO
    {
        private static cthdDAO instance;
        public static cthdDAO Instance
        {
            get { if (instance == null) instance = new cthdDAO(); return instance; }
            private set { cthdDAO.instance = value; }
        }
        private cthdDAO() { }


        public List<xuatcthd> xuatdscthd()
        {
            List<xuatcthd> ds = new List<xuatcthd>();

            string query = "EXEC XUATCTHD";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                xuatcthd m = new xuatcthd(item);
                ds.Add(m);
            }

            return ds;
        }
        public List<xuatcthd> timsohd(string sohd)
        {
            List<xuatcthd> ds = new List<xuatcthd>();

            DataTable data = DataProvider.Instance.ExecuteQuery("TIMSOHD @SOHD", new object[] {sohd});

            foreach (DataRow item in data.Rows)
            {
                xuatcthd m = new xuatcthd(item);
                ds.Add(m);
            }
            return ds;
        }
    }
}

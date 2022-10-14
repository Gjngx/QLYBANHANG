using QLYBANHANG.DTO;
using QLYBANHANG.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DAO
{
    public class doanhthuDAO
    {
        private static doanhthuDAO instance;

        public static doanhthuDAO Instance
        {
            get { if (instance == null) instance = new doanhthuDAO(); return instance; }
            private set { doanhthuDAO.instance = value; }
        }
        private doanhthuDAO() { }
        public List<doanhthu> xuattongtientheongay(DateTime ngaylap, DateTime ngaytt)
        {
            List<doanhthu> dstk = new List<doanhthu>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC XUATTONGTIENTHEONGAY @NGAYLAP , @NGAYTT ", new object[] { ngaylap, ngaytt });

            foreach (DataRow item in data.Rows)
            {
                doanhthu m = new doanhthu(item);
                dstk.Add(m);
            }
            return dstk;
        }
        public DataTable xuathdtheongay(DateTime ngaylap, DateTime ngaytt)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC XUATHDTHEONGAY @NGAYLAP , @NGAYTT ", new object[] { ngaylap, ngaytt });
        }

        public bool xoahoadon(int sohoadon)
        {
            string q = string.Format("EXEC XOAHOADON @SOHOADON = " + sohoadon);
            int r = DataProvider.Instance.ExecuteNonQuery(q);
            return r > 0;
        }
    }
}

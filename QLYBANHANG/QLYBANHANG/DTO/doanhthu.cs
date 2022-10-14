using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class doanhthu
    {
        public doanhthu(float tongtien)
        {
            this.Tongtien = tongtien;
        }

        public doanhthu(DataRow row)
        {
            this.Tongtien = (float)Convert.ToDouble(row["TONGTIEN"].ToString());
        }

        private float tongtien;
        public float Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
    }
}

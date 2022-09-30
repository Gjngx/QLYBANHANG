using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class taohoadon
    {
        public taohoadon(string tensanpham, int soluong, float gia, float thanhtien = 0)
        {
            this.Tensanpham = tensanpham;
            this.Soluong = soluong;
            this.Gia = gia;
            this.thanhtien = thanhtien;
        }

        public taohoadon(DataRow row)
        {
            this.Tensanpham = row["TENSP"].ToString();
            this.Soluong = (int)row["SOLUONG"];
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.thanhtien = (float)Convert.ToDouble(row["TONGTIEN"].ToString());
        }

        private string tensanpham;

        public string Tensanpham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private float thanhtien;

        public float Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}

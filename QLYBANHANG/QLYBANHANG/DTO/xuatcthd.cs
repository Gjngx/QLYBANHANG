using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class xuatcthd
    {
        public xuatcthd(int sohd, string masanpham, string tensp, int soluong, float gia, float thanhtien)
        {
            this.Sohd = sohd;
            this.Masanpham = masanpham;
            this.Tensanpham = tensp;
            this.Soluong = soluong;
            this.Gia = gia;
            this.Thanhtien = thanhtien;
        }

        public xuatcthd(DataRow row)
        {
            this.Sohd = (int)row["SOHD"];
            this.Masanpham = (string)row["MASP"];
            this.Tensanpham = (string)row["TENSP"];
            this.Soluong = (int)row["SOLUONG"];
            this.Gia = (float)Convert.ToDouble(row["GIA"].ToString());
            this.Thanhtien = (float)Convert.ToDouble(row["THANHTIEN"].ToString());
        }

        private int sohd;

        public int Sohd
        {
            get { return sohd; }
            set { sohd = value; }
        }

        private string masanpham;
        public string Masanpham
        {
            get { return masanpham; }
            set { masanpham = value; }
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

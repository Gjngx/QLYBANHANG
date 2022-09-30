using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class hoadon
    {
        public hoadon(int sohd,  DateTime ngaylap, DateTime ngaythanhtoan,float tongtien, int trangthai)
        {
            this.Sohd = sohd;
            this.Ngaylap = ngaylap;
            this.Ngaythanhtoan = ngaythanhtoan;
            this.Tongtien = tongtien;
            this.Trangthai = trangthai;
        }

        public hoadon(DataRow row)
        {
            this.Sohd = (int)row["SOHD"];
            this.Ngaylap = (DateTime)row["NGAYLAP"];
            this.Ngaythanhtoan = (DateTime)row["NGAYTHANHTOAN"];
            //this.Tongtien = (int)row["TONGTIEN"];
            this.Trangthai = (int)row["TRANGTHAI"];
        }

        private int sohd;
        public int Sohd
        {
            get { return sohd; }
            set { sohd = value; }
        }

        private DateTime ngaylap;
        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        private DateTime ngaythanhtoan;

        public DateTime Ngaythanhtoan
        {
            get { return Ngaythanhtoan; }
            set { ngaythanhtoan = value; }
        }

        private float tongtien;
        public float Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private int trangthai;
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}

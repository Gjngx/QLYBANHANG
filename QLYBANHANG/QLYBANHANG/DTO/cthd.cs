using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class cthd
    {
        public cthd(int socthd, int sohd, string masanpham, int soluong)
        {
            this.Socthd = socthd;
            this.Sohd = sohd;
            this.Masanpham = masanpham;
            this.Soluong = soluong;
        }

        public cthd(DataRow row)
        {
            this.Socthd = (int)row["SOCTHD"];
            this.Sohd = (int)row["SOHD"];
            this.Masanpham = (string)row["MASP"];
            this.Soluong = (int)row["SOLUONG"];
        }

        private int socthd;

        public int Socthd
        {
            get { return socthd; }
            set { socthd = value; }
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

        private int soluong;
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
    }
}

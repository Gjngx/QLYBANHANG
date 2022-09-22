using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class loaisp
    {
        public loaisp(string maloai, string tenloai)
        {
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }

        public loaisp(DataRow row)
        {
            this.Maloai = row["MALOAISP"].ToString();
            this.tenloai = row["TENLOAISP"].ToString();
        }

        private string maloai;

        public string Maloai
        {
            get { return maloai; }
            private set { maloai = value; }
        }

        private string tenloai;

        public string Tenloai
        {
            get { return tenloai; }
            private set { tenloai = value; }
        }
    }
}

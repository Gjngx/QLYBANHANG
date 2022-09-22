using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class sanphamhd
    {
        public sanphamhd(string masanpham, string tensanpham, string tenloai, float gia)
        {
            this.MaSanPham = masanpham;
            this.Tenloai = tenloai;
            this.TenSanPham = tensanpham;
            this.Gia = gia;
        }

        public sanphamhd(DataRow row)
        {
            this.MaSanPham = row["MASP"].ToString();
            this.tenloai = row["TENLOAISP"].ToString();
            this.TenSanPham = row["TENSP"].ToString();
            this.Gia = (float)Convert.ToDouble(row["GIA"].ToString());
        }

        private string masanpham;

        public string MaSanPham
        {
            get { return masanpham; }
            set { masanpham = value; }
        }

        private string tensanpham;

        public string TenSanPham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }

        private string tenloai;

        public string Tenloai
        {
            get { return tenloai; }
            private set { tenloai = value; }
        }

        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}

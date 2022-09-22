using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class sanpham
    {
        public sanpham(string masanpham, string tensanpham, string maloai, float gia)
        {
            this.MaSanPham = masanpham;
            this.MaLoai = maloai;
            this.TenSanPham = tensanpham;
            this.Gia = gia;
        }

        public sanpham(DataRow row)
        {
            this.MaSanPham = row["MASP"].ToString();
            this.MaLoai = row["MAlOAISP"].ToString();
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

        private string maloai;

        public string MaLoai
        {
            get { return maloai; }
            set { maloai = value; }
        }

        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYBANHANG.DTO
{
    public class taikhoan
    {
        public taikhoan(string tendangnhap, string tennhanvien, int quyen, string matkhau = null)
        {
            this.Tendangnhap = tendangnhap;
            this.Tennhanvien = tennhanvien;
            this.Quyen = quyen;
            this.Matkhau = matkhau;
        }

        public taikhoan(DataRow row)
        {
            this.Tendangnhap = row["taikhoan"].ToString();
            this.Tennhanvien = row["hoten"].ToString();
            this.Quyen = (int)row["phanquyen"];
            this.Matkhau = row["matkhau"].ToString();
        }

        private string tendangnhap;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }

        private string tennhanvien;

        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        private int quyen;

        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
    }
}

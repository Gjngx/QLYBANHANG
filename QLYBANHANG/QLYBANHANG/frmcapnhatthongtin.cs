using DevExpress.XtraEditors;
using QLYBANHANG.DAO;
using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYBANHANG
{
    public partial class frmcapnhatthongtin : DevExpress.XtraEditors.XtraForm
    {
        private taikhoan taikhoan;

        public taikhoan TaiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; xuatthongtin(TaiKhoan); }
        }
        public frmcapnhatthongtin(taikhoan tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
        }

        public void capnhattaikhoan()
        {
            string tendn = txbtaikhoan.Text;
            string hoten = txbtennhanvien.Text;
            string matkhau = txbmatkhau.Text;
            if (taikhoanDAO.Instance.capnhattaikhoan(tendn, hoten, matkhau))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                capnhatttk(this, new taikhoanevent(taikhoanDAO.Instance.xuattktheotendn(tendn)));
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }

        }

        void xuatthongtin(taikhoan tk)
        {
            txbtaikhoan.Text = TaiKhoan.Tendangnhap;
            txbtennhanvien.Text = TaiKhoan.Tennhanvien;

        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            capnhattaikhoan();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private event EventHandler<taikhoanevent> capnhatttk;

        public event EventHandler<taikhoanevent> Capnhatttk
        {
            add { capnhatttk += value; }
            remove { capnhatttk -= value; }
        }

        public class taikhoanevent : EventArgs
        {
            private taikhoan tk;

            public taikhoan Tk
            {
                get { return tk; }
                set { tk = value; }
            }
            public taikhoanevent(taikhoan tk)
            {
                this.Tk = tk;
            }

        }
    }
}
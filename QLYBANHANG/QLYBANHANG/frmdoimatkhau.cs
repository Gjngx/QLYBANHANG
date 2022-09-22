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
    public partial class frmdoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        private taikhoan taikhoan;

        public taikhoan TaiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; xuatthongtinmk(TaiKhoan); }
        }
        public frmdoimatkhau(taikhoan tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
        }

        public void xuatthongtinmk(taikhoan tk)
        {
            txbtaikhoan.Text = tk.Tendangnhap;
        }

        public void capnhapmatkhau()
        {
            try
            {
                string tendangnhap = txbtaikhoan.Text;
                string matkhaumoi = txbmaukhaumoi.Text;
                string matkhau = txbmatkhaucu.Text;
                if (taikhoanDAO.Instance.capnhatmatkhau(tendangnhap, matkhau, matkhaumoi))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            capnhapmatkhau();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
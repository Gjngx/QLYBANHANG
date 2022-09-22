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
    public partial class frmdangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        public bool ktradangnhap(string tendn, string matkhau)
        {
            return taikhoanDAO.Instance.dangnhap(tendn, matkhau);
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string tendn = txbtaikhoan.Text;
            string matkhau = txbmatkhau.Text;
            if(ktradangnhap(tendn, matkhau))
            {
                taikhoan tk = taikhoanDAO.Instance.xuattktheotendn(tendn);
                frmmain f = new frmmain(tk);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi phần mềm?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
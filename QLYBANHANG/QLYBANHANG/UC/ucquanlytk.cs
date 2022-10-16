using DevExpress.XtraEditors;
using QLYBANHANG.DAO;
using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYBANHANG.UC
{
    public partial class ucquanlytk : Form
    {
        BindingSource dstaikhoan = new BindingSource();

        public taikhoan dangnhap;

        public static Control Instance { get; internal set; }

        public ucquanlytk()
        {
            InitializeComponent();
            dgvtaikhoan.DataSource = dstaikhoan;
            taidstaikhoan();
            taikhoanbinding();
        }

        #region methods
        void taidstaikhoan()
        {
            dstaikhoan.DataSource = taikhoanDAO.Instance.xuatdstk();
        }

        void taikhoanbinding()
        {
            txbtendangnhap.DataBindings.Add(new Binding("Text", dgvtaikhoan.DataSource, "tendangnhap"));
            txbtennhanvien.DataBindings.Add(new Binding("Text", dgvtaikhoan.DataSource, "tennhanvien"));
            nudquyen.DataBindings.Add(new Binding("Value", dgvtaikhoan.DataSource, "quyen"));
        }

        void themtk(string tendn, string tennv, int quyen)
        {
            if (taikhoanDAO.Instance.themtaikhoan(tendn, tennv, quyen))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
                MessageBox.Show("Thêm tài khoản thất bại!");
            taidstaikhoan();
        }

        void suatk(string tendn, string tennv, int quyen)
        {
            if (taikhoanDAO.Instance.suataikhoai(tendn, tennv, quyen))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
                MessageBox.Show("Cập nhật tài khoản thất bại!");
            taidstaikhoan();
        }

        void xoatk(string tendn)
        {
            if (dangnhap.Tendangnhap.Equals(tendn))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản của bạn!");
                return;
            }
            if (taikhoanDAO.Instance.xoataikhoan(tendn))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else 
                MessageBox.Show("Xóa tài khoản thất bại!");
            taidstaikhoan();
        }
        List<taikhoan> timtaikhoantheoten(string tennv)
        {
            List<taikhoan> list = taikhoanDAO.Instance.timtaikhoan(tennv);
            return list;
        }

        void datlaimk(string tendn, string mk)
        {
            if (txbmatkhau.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu cần đủ 8 ký tự!");
                return;
            }
            if (taikhoanDAO.Instance.datlaimatkhau(tendn, mk))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            taidstaikhoan();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string tennv = txbtennhanvien.Text;
            int quyen = (int)nudquyen.Value;
            themtk(tendn, tennv, quyen);
            taidstaikhoan();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string tennv = txbtennhanvien.Text;
            int quyen = (int)nudquyen.Value;
            suatk(tendn, tennv, quyen);
            taidstaikhoan();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            xoatk(tendn);
            taidstaikhoan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string mk = txbmatkhau.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mk);
            byte[] data = new MD5CryptoServiceProvider().ComputeHash(temp);

            string datamk = "";

            foreach (byte b in data)
            {
                datamk += b;
            }
            datlaimk(tendn, datamk);
            taidstaikhoan();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dstaikhoan.DataSource = timtaikhoantheoten(txbtim.Text);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
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
    public partial class ucquanlytk : DevExpress.XtraEditors.XtraUserControl
    {
        BindingSource dstaikhoan = new BindingSource();

        private static ucquanlytk instance;
        public static ucquanlytk Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucquanlytk();
                return instance;
            }
        }

        public ucquanlytk()
        {
            InitializeComponent();
            dgvtaikhoan.DataSource = dstaikhoan;
            txbtendangnhap.Enabled = false;
            txbtennhanvien.Enabled = false;
            txbmatkhau.Enabled = false;
            nudquyen.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
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
            txbtendangnhap.DataBindings.Add(new Binding("Text", dgvtaikhoan.DataSource, "taikhoan"));
            txbtennhanvien.DataBindings.Add(new Binding("Text", dgvtaikhoan.DataSource, "hoten"));
            nudquyen.DataBindings.Add(new Binding("Value", dgvtaikhoan.DataSource, "phanquyen"));
        }
        private bool ktradulieu()
        {
            if (txbtendangnhap.Text == "" || txbtennhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        void xoatk(string tendn)
        {
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
            List<taikhoan> list = taikhoanDAO.Instance.timtaikhoanbanghoten(tennv);
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
            txbtendangnhap.Text = "";
            txbtennhanvien.Text = "";
            txbtim.Text = "";
            nudquyen.Value = 0;
            nudquyen.Enabled = true;
            txbtendangnhap.Enabled = true;
            txbtennhanvien.Enabled = true;
            txbmatkhau.Enabled = false;
            txbtim.Enabled = false;
            btndatlaimk.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btntim.Enabled = false;
            txbtim.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            dgvtaikhoan.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txbtim.Text = "";
            txbtendangnhap.Text = "";
            txbtennhanvien.Text = "";
            nudquyen.Value = 0;
            txbtendangnhap.Enabled = false;
            txbtennhanvien.Enabled = true;
            txbtim.Enabled = true;
            txbmatkhau.Text = "";
            txbmatkhau.Enabled = true;
            btndatlaimk.Enabled = true;
            nudquyen.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            taidstaikhoan();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            xoatk(tendn);
            taidstaikhoan();
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            dstaikhoan.DataSource = timtaikhoantheoten(txbtim.Text);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txbtendangnhap.Text = "";
            txbtennhanvien.Text = "";
            txbtim.Text = "";
            txbmatkhau.Text = "";
            txbmatkhau.Enabled = false;
            btndatlaimk.Enabled = false;
            txbtendangnhap.Enabled = false;
            txbtennhanvien.Enabled = false;
            txbtim.Enabled = true;
            nudquyen.Enabled = false;
            btntim.Enabled = true;
            btnxem.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            dgvtaikhoan.Enabled = true;
            taidstaikhoan();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string tennv = txbtennhanvien.Text;
            int quyen = (int)nudquyen.Value; ;
            if (ktradulieu())
            {
                if (txbtendangnhap.Enabled == true)
                {
                    if (taikhoanDAO.Instance.timtaikhoan(tendn) == 0)
                    {
                        if (taikhoanDAO.Instance.themtaikhoan(tendn, tennv, quyen))
                        {
                            MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                            taidstaikhoan();
                            txbtendangnhap.Enabled = false;
                            txbtennhanvien.Enabled = false;
                            nudquyen.Enabled = false;
                            txbtim.Enabled = true;
                            txbmatkhau.Enabled = false;
                            btndatlaimk.Enabled = false;
                            btnxem.Enabled = true;
                            btnthem.Enabled = true;
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            btnluu.Enabled = false;
                            btnhuy.Enabled = false;
                            btntim.Enabled = true;
                            dgvtaikhoan.Enabled = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                        txbtendangnhap.Enabled = false;
                        txbtennhanvien.Enabled = false;
                        nudquyen.Enabled = false;
                        txbtim.Enabled = true;
                        txbmatkhau.Enabled = false;
                        btndatlaimk.Enabled = false;
                        btnxem.Enabled = true;
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        btntim.Enabled = true;
                        dgvtaikhoan.Enabled = true;
                    }
                }
                else if (txbtendangnhap.Enabled == false)
                {
                    if (taikhoanDAO.Instance.suataikhoai(tendn, tennv, quyen))
                    {
                        MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK);
                        txbtendangnhap.Enabled = false;
                        txbtennhanvien.Enabled = false;
                        nudquyen.Enabled = false;
                        txbmatkhau.Enabled = false;
                        btndatlaimk.Enabled = false;
                        txbtim.Enabled = true;
                        btnxem.Enabled = true;
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        btntim.Enabled = true;
                        taidstaikhoan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                        txbtendangnhap.Enabled = false;
                        txbtennhanvien.Enabled = false;
                        nudquyen.Enabled = false;
                        txbtim.Enabled = true;
                        txbmatkhau.Enabled = false;
                        btndatlaimk.Enabled = false;
                        btnxem.Enabled = true;
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        btntim.Enabled = true;
                    }
                }
            }
        }

        private void btndatlaimk_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string mk = txbmatkhau.Text;
            datlaimk(tendn, mk);
            taidstaikhoan();
            txbtendangnhap.Text = "";
            txbtennhanvien.Text = "";
            txbtim.Text = "";
            txbmatkhau.Text = "";
            txbmatkhau.Enabled = false;
            btndatlaimk.Enabled = false;
            txbtendangnhap.Enabled = false;
            txbtennhanvien.Enabled = false;
            txbtim.Enabled = true;
            nudquyen.Enabled = false;
            btntim.Enabled = true;
            btnxem.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            dgvtaikhoan.Enabled = true;
        }
    }
    #endregion
}
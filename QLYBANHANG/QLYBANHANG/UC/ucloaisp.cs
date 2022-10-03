using DevExpress.XtraEditors;
using QLYBANHANG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYBANHANG.UC
{
    public partial class ucloaisp : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucloaisp instance;

        BindingSource dssanpham = new BindingSource();

        public static ucloaisp Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucloaisp();
                return instance;
            }
        }
        public ucloaisp()
        {
            InitializeComponent();
            dgvdanhmuc.DataSource = dssanpham;
            taidssanpham();
            spbinding();
            txbmadanhmuc.Enabled = false;
            txbtendanhmuc.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        void taidssanpham()
        {
            dssanpham.DataSource = loaispDAO.Instance.xuatdsloai();
        }

        void spbinding()
        {
            txbmadanhmuc.DataBindings.Add(new Binding("Text", dgvdanhmuc.DataSource, "maloai", true, DataSourceUpdateMode.Never));
            txbtendanhmuc.DataBindings.Add(new Binding("Text", dgvdanhmuc.DataSource, "tenloai", true, DataSourceUpdateMode.Never));
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            taidssanpham();
            txbmadanhmuc.Text = "";
            txbtendanhmuc.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txbmadanhmuc.Enabled = true;
            txbtendanhmuc.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            dgvdanhmuc.Enabled = false;
            btnxem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txbmadanhmuc.Text = "";
            txbtendanhmuc.Text = "";
        }
        private bool ktradulieu()
        {
            if (txbmadanhmuc.Text == "" || txbtendanhmuc.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string maloai = txbmadanhmuc.Text;
            string tenloai = txbtendanhmuc.Text;
            if (ktradulieu())
            {
                if(txbmadanhmuc.Enabled == true)
                {
                    if (loaispDAO.Instance.timloaisp(maloai) == 0)
                    {
                        if (loaispDAO.Instance.themloaisp(maloai, tenloai))
                        {
                            MessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                            taidssanpham();
                            txbmadanhmuc.Enabled = false;
                            txbtendanhmuc.Enabled = false;
                            btnthem.Enabled = true;
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            btnxem.Enabled = true;
                            btnluu.Enabled = false;
                            btnhuy.Enabled = false;
                            dgvdanhmuc.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                            btnthem.Enabled = true;
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            txbmadanhmuc.Enabled = false;
                            txbtendanhmuc.Enabled = false;
                            btnxem.Enabled = true;
                            dgvdanhmuc.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else if (txbmadanhmuc.Enabled == false)
                {
                    if(loaispDAO.Instance.sualoaisp(tenloai, maloai))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        txbmadanhmuc.Enabled = false;
                        txbtendanhmuc.Enabled = false;
                        btnxem.Enabled = true;
                        dgvdanhmuc.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        taidssanpham();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        txbmadanhmuc.Enabled = false;
                        txbtendanhmuc.Enabled = false;
                        btnxem.Enabled = true;
                        dgvdanhmuc.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        taidssanpham();
                    }
                        
                }
               
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maloaisp = txbmadanhmuc.Text;
           DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                loaispDAO.Instance.xoadanhmuc(maloaisp);
                MessageBox.Show("Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                taidssanpham();
            }
            else
                MessageBox.Show("Xóa loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txbmadanhmuc.Text = "";
            txbtendanhmuc.Text = "";
            txbmadanhmuc.Enabled = false;
            txbtendanhmuc.Enabled = false;
            dgvdanhmuc.Enabled = true;
            btnxem.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txbmadanhmuc.Enabled = false;
            txbtendanhmuc.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnxem.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
        }
    }
}

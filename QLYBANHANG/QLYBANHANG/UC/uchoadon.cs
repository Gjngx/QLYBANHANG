using DevExpress.XtraEditors;
using QLYBANHANG.DAO;
using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QLYBANHANG.UC
{
    public partial class uchoadon : DevExpress.XtraEditors.XtraUserControl
    {
        private static uchoadon instance;

        BindingSource dssanpham = new BindingSource(); 
        public static uchoadon Instance
        {
            get
            {
                if (instance == null)
                    instance = new uchoadon();
                return instance;
            }
        }
        public uchoadon()
        {
            InitializeComponent();
            dgvtimsanpham.DataSource = dssanpham;
            taidssanpham();
            sanphamBinding();
        }
        public void sanphamBinding()
        {
            txbtimmasp.DataBindings.Add(new Binding("Text", dgvtimsanpham.DataSource, "Masanpham", true, DataSourceUpdateMode.Never));
            txbtenloai.DataBindings.Add(new Binding("Text", dgvtimsanpham.DataSource, "Tenloai", true, DataSourceUpdateMode.Never));
            txbtensanpham.DataBindings.Add(new Binding("Text", dgvtimsanpham.DataSource, "Tensanpham", true, DataSourceUpdateMode.Never));
        }
        void taidssanpham()
        {
            dssanpham.DataSource = hoadonDAO.Instance.dssanpham();
        }
        List<sanphamhd> timsanpham(string masanpham)
        {
            List<sanphamhd> list = hoadonDAO.Instance.timsanpham(masanpham);
            return list;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            dssanpham.DataSource = timsanpham(txbtimmasp.Text);
        }
        void showhoadon()
        {
            lsvhoadon.Items.Clear();
            List<taohoadon> dscthd = hoadonDAO.Instance.xuatdshoadon();
            float tongtien = 0;
            foreach (taohoadon item in dscthd)
            {
                ListViewItem lsitem = new ListViewItem(item.Tensanpham);
                lsitem.SubItems.Add(item.Soluong.ToString());
                lsitem.SubItems.Add(item.Gia.ToString());
                lsitem.SubItems.Add(item.Thanhtien.ToString());
                tongtien += item.Thanhtien;
                lsvhoadon.Items.Add(lsitem);
            }
            CultureInfo vn = new CultureInfo("vi-VN");
            txbtongtien.Text = tongtien.ToString("c", vn);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int sohd = hoadonDAO.Instance.ktrahoadon();

            string masp = txbtimmasp.Text;

            int soluong = (int)nudsoluong.Value;

            if (sohd == -1)
            {
                hoadonDAO.Instance.taohd();
                hoadonDAO.Instance.themcthd(hoadonDAO.Instance.xuatmahoadon(), masp, soluong);
            }

            else
            {
                hoadonDAO.Instance.themcthd(sohd, masp, soluong);
            }
            showhoadon();
            taidssanpham();

        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            int sohd = hoadonDAO.Instance.xuatmahoadon();
            double tongtien = Convert.ToDouble(txbtongtien.Text.Split(',')[0]);
            double giamgia = Convert.ToDouble(nudgiamgia.Value);
            tongtien = tongtien - giamgia;
            CultureInfo vn = new CultureInfo("vi-VN");
            if (sohd != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn tổng tiền: " + tongtien.ToString("c",vn) , "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    hoadonDAO.Instance.thanhtoan(sohd, (float)tongtien);
                    showhoadon();
                }
            }
        }
    }
}

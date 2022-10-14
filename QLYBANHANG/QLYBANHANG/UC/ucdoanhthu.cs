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

namespace QLYBANHANG.UC
{
    public partial class ucdoanhthu : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucdoanhthu instance;

        public static ucdoanhthu Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucdoanhthu();
                return instance;
            }
        }
        BindingSource doanhthuch = new BindingSource();
        public ucdoanhthu()
        {
            InitializeComponent();
            dgvthongke.DataSource = doanhthuch;
            taidtpdoanhthu();
            taidsdoanhthu(dtptungay.Value, dtpdenngay.Value);
            tkbinding();
        }
        void taidsdoanhthu(DateTime ngaylap, DateTime ngaytt)
        {
            doanhthuch.DataSource = doanhthuDAO.Instance.xuathdtheongay(ngaylap, ngaytt);
            tongtientheongay();

        }

        void taidtpdoanhthu()
        {
            DateTime date = DateTime.Now;
            dtptungay.Value = new DateTime(date.Year, date.Month, 1);
        }

        void tongtientheongay()
        {
            List<doanhthu> dstongtien = doanhthuDAO.Instance.xuattongtientheongay(dtptungay.Value, dtpdenngay.Value);
            float ttien = 0;

            foreach (doanhthu tk in dstongtien)
            {
                ListViewItem lsitem = new ListViewItem();
                lsitem.SubItems.Add(tk.Tongtien.ToString());
                ttien += tk.Tongtien;
            }
            CultureInfo vn = new CultureInfo("vi-VN");
            txbtongtien.Text = ttien.ToString("c", vn);

        }

        void tkbinding()
        {
            txbhoadon.DataBindings.Add(new Binding("Text", dgvthongke.DataSource, "Số hóa đơn", true, DataSourceUpdateMode.Never));
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            taidsdoanhthu(dtptungay.Value, dtpdenngay.Value);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            int sohoadon = Convert.ToInt32(txbhoadon.Text);
            if (doanhthuDAO.Instance.xoahoadon(sohoadon))
            {
                MessageBox.Show("Hủy hóa đơn thành công");
                taidtpdoanhthu();
                taidsdoanhthu(dtptungay.Value, dtpdenngay.Value);
            }
            else
                MessageBox.Show("Xóa hóa đơn thất bại!");
        }
    }
}

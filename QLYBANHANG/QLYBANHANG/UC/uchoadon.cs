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

        public void sanphamBinding()
        {
            txbtimmasp.DataBindings.Add(new Binding("Text", dgvtimsanpham.DataSource, "Masanpham", true, DataSourceUpdateMode.Never));
            txbtensanpham.DataBindings.Add(new Binding("Text", dgvtimsanpham.DataSource, "Tensanpham", true, DataSourceUpdateMode.Never));
        }

        void taidssanpham()
        {
            dssanpham.DataSource = hoadonDAO.Instance.dssanpham();
        }

        public void taidsloaicbb( ComboBox cb)
        {
            cb.DataSource = hoadonDAO.Instance.xuatdsloai();
            cb.DisplayMember = "TENLOAI";

        }
        List<sanphamhd> timsanpham(string masanpham)
        {
            List<sanphamhd> list = hoadonDAO.Instance.timsanpham(masanpham);
            return list;
        }
        public uchoadon()
        {
            InitializeComponent();
            dgvtimsanpham.DataSource = dssanpham;
            taidssanpham();
            sanphamBinding();
            taidsloaicbb(cbtenloai);
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dssanpham.DataSource = timsanpham(txbtimmasp.Text);
        }
    }
}

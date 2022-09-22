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

        void taidsmon()
        {
            dssanpham.DataSource = hoadonDAO.Instance.dssanpham();
        }
        public uchoadon()
        {
            InitializeComponent();
            dgvtimsanpham.DataSource = dssanpham;
            taidsmon();
            sanphamBinding();
        }

        private void uchoadon_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

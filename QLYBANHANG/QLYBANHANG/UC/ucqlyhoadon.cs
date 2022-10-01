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

namespace QLYBANHANG.UC
{
    public partial class ucqlyhoadon : DevExpress.XtraEditors.XtraUserControl
    {
        BindingSource dscthd = new BindingSource();

        private static ucqlyhoadon instance;

        public static ucqlyhoadon Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucqlyhoadon();
                return instance;
            }
        }
        public ucqlyhoadon()
        {
            InitializeComponent();
            dgvcthd.DataSource = dscthd;
            taidscthd();
            cthdBinding();
        }
        public void cthdBinding()
        {
            txbtimsohd.DataBindings.Add(new Binding("Text", dgvcthd.DataSource, "sohd", true, DataSourceUpdateMode.Never));
        }
        public void taidscthd()
        {
            dscthd.DataSource = cthdDAO.Instance.xuatdscthd();
        }

        List<xuatcthd> tim(string sohd)
        {
            List<xuatcthd> list = cthdDAO.Instance.timsohd(sohd);
            return list;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dscthd.DataSource = tim(txbtimsohd.Text);
        }

        private void btntailai_Click(object sender, EventArgs e)
        {
            taidscthd();
        }
    }
}

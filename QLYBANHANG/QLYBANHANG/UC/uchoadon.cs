using DevExpress.XtraEditors;
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
        }

        private void uchoadon_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ucsanpham : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucsanpham instance;

        public static ucsanpham Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucsanpham();
                return instance;
            }
        }
        public ucsanpham()
        {
            InitializeComponent();
        }
    }
}

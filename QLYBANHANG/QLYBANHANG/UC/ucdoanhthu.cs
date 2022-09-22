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
        public ucdoanhthu()
        {
            InitializeComponent();
        }
    }
}

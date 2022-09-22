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
    public partial class ucloaisp : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucloaisp instance;

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
        }
    }
}

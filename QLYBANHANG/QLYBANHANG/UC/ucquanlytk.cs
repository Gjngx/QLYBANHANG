﻿using DevExpress.XtraEditors;
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
    public partial class ucquanlytk : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucquanlytk instance;

        public static ucquanlytk Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucquanlytk();
                return instance;
            }
        }
        public ucquanlytk()
        {
            InitializeComponent();
        }
    }
}
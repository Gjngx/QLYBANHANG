using DevExpress.XtraBars;
using QLYBANHANG.DTO;
using QLYBANHANG.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static QLYBANHANG.frmcapnhatthongtin;

namespace QLYBANHANG
{
    public partial class frmmain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private taikhoan taikhoan;

        public taikhoan TaiKhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; phanquyen(taikhoan.Quyen); }
        }
        public frmmain(taikhoan tk)
        {
            InitializeComponent();
            this.TaiKhoan = tk;
        }

        private void acedangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acehoadon_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(uchoadon.Instance))
            {
                fdfcontainer.Controls.Add(uchoadon.Instance);
                uchoadon.Instance.Dock = DockStyle.Fill;
                uchoadon.Instance.BringToFront();
            }
            uchoadon.Instance.BringToFront();
        }

        public void load_uchoadon()
        {
            if (!fdfcontainer.Controls.Contains(uchoadon.Instance))
            {
                fdfcontainer.Controls.Add(uchoadon.Instance);
                uchoadon.Instance.Dock = DockStyle.Fill;
                uchoadon.Instance.BringToFront();
            }
            uchoadon.Instance.BringToFront();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            load_uchoadon();
        }
        private void f_Capnhatttk(object sender, taikhoanevent e)
        {
            bsitaikhoan.Caption = "Xin chào " + e.Tk.Tennhanvien;
        }

        private void btncapnhatthongtin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmcapnhatthongtin f = new frmcapnhatthongtin(TaiKhoan);
            f.Capnhatttk += f_Capnhatttk;
            f.ShowDialog();
        }

        private void btndoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmdoimatkhau f = new frmdoimatkhau(TaiKhoan);
            f.ShowDialog();
        }

        private void acedoanhthu_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(ucdoanhthu.Instance))
            {
                fdfcontainer.Controls.Add(ucdoanhthu.Instance);
                ucdoanhthu.Instance.Dock = DockStyle.Fill;
                ucdoanhthu.Instance.BringToFront();
            }
            ucdoanhthu.Instance.BringToFront();
        }

        private void aceloaisp_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(ucloaisp.Instance))
            {
                fdfcontainer.Controls.Add(ucloaisp.Instance);
                ucloaisp.Instance.Dock = DockStyle.Fill;
                ucloaisp.Instance.BringToFront();
            }
            ucloaisp.Instance.BringToFront();
        }

        private void acesanpham_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(ucsanpham.Instance))
            {
                fdfcontainer.Controls.Add(ucsanpham.Instance);
                ucsanpham.Instance.Dock = DockStyle.Fill;
                ucsanpham.Instance.BringToFront();
            }
            ucsanpham.Instance.BringToFront();
        }

        private void acequanlytaikhoan_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(ucquanlytk.Instance))
            {
                fdfcontainer.Controls.Add(ucquanlytk.Instance);
                ucquanlytk.Instance.Dock = DockStyle.Fill;
                ucquanlytk.Instance.BringToFront();
            }
            ucquanlytk.Instance.BringToFront();
        }

        void phanquyen(int quyen)
        {
            acequanly.Enabled = quyen == 1;
            acedoanhthu.Enabled = quyen == 1;
            aceloaisp.Enabled = quyen == 1;
            acesanpham.Enabled = quyen == 1;
            acequanlytaikhoan.Enabled = quyen == 1;
            bsitaikhoan.Caption = "Xin chào " + taikhoan.Tennhanvien;

        }

        private void acecthd_Click(object sender, EventArgs e)
        {
            if (!fdfcontainer.Controls.Contains(ucqlyhoadon.Instance))
            {
                fdfcontainer.Controls.Add(ucqlyhoadon.Instance);
                ucqlyhoadon.Instance.Dock = DockStyle.Fill;
                ucqlyhoadon.Instance.BringToFront();
            }
            ucqlyhoadon.Instance.BringToFront();
        }
    }
}

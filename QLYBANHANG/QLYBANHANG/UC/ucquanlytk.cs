using DevExpress.XtraEditors;
using QLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYBANHANG.UC
{
    public partial class ucquanlytk : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucquanlytk instance;
        private object dstaikhoan;

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

        private void btnxem_Click(object sender, EventArgs e)
        {
            taidstaikhoan();
        }

        private void taidstaikhoan()
        {
            throw new NotImplementedException();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string tennv = txbtennhanvien.Text;
            int quyen = (int)nudquyen.Value;
            themtk(tendn, tennv, quyen);
            taidstaikhoan();
        }

        private void themtk(string tendn, string tennv, int quyen)
        {
            throw new NotImplementedException();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string tennv = txbtennhanvien.Text;
            int quyen = (int)nudquyen.Value;
            suatk(tendn, tennv, quyen);
            taidstaikhoan();
        }

        private void suatk(string tendn, string tennv, int quyen)
        {
            throw new NotImplementedException();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            xoatk(tendn);
            taidstaikhoan();
        }

        private void xoatk(string tendn)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendn = txbtendangnhap.Text;
            string mk = txbmatkhau.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mk);
            byte[] data = new MD5CryptoServiceProvider().ComputeHash(temp);

            string datamk = "";

            foreach (byte b in data)
            {
                datamk += b;
            }
            datlaimk(tendn, datamk);
            taidstaikhoan();
        }

        private void datlaimk(string tendn, string datamk)
        {
            throw new NotImplementedException();
        }

        private void Btntim_Click(object sender, EventArgs e)
        {
            dstaikhoan = timtaikhoantheoten(txbtim.Text);
        }

        private object timtaikhoantheoten(string text)
        {
            throw new NotImplementedException();
        }
    }
}

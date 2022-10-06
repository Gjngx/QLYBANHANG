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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


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

        BindingSource dssp = new BindingSource();
        public ucsanpham()
        {
            InitializeComponent();
            dgvsanpham.DataSource = dssp;
            taidsloaicbb(cbbloai);
            taidssp();
            spbinding();
            txbmasp.Enabled = false;
            txbtensp.Enabled = false;
            cbbloai.Enabled = false;
            nudgiasp.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        void spbinding()
        {
            cbbloai.DataBindings.Add(new Binding("Text", dgvsanpham.DataSource, "TenLoai", true, DataSourceUpdateMode.Never));
            txbmasp.DataBindings.Add(new Binding("Text", dgvsanpham.DataSource, "MaSanPham", true, DataSourceUpdateMode.Never));
            txbtensp.DataBindings.Add(new Binding("Text", dgvsanpham.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never));
            nudgiasp.DataBindings.Add(new Binding("Value", dgvsanpham.DataSource, "Gia", true, DataSourceUpdateMode.Never));
        }

        void taidsloaicbb(ComboBox cb)
        {
            cb.DataSource = loaispDAO.Instance.xuatdsloai();
            cb.DisplayMember = "Tenloai";

        }

        void taidssp()
        {
            dssp.DataSource = sanphamDAO.Instance.dssanpham();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            taidssp();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txbmasp.Text = "";
            txbtensp.Text = "";
            txbtim.Text = "";
            nudgiasp.Value = 0;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btntim.Enabled = false;
            txbtim.Enabled = false;
            txbmasp.Enabled = true;
            txbtensp.Enabled = true;
            cbbloai.Enabled = true;
            nudgiasp.Enabled = true;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            dgvsanpham.Enabled = false;
            btnexport.Enabled = false;
            btnimport.Enabled = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string masp = txbmasp.Text;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                sanphamDAO.Instance.xoasanpham(masp);
                MessageBox.Show("Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                taidssp();
            }
            else
                MessageBox.Show("Xóa loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txbmasp.Text = "";
            txbtensp.Text = "";
            txbtim.Text = "";
            cbbloai.Text = "";
            txbmasp.Enabled = false;
            txbtensp.Enabled = false;
            txbtim.Enabled = true;
            cbbloai.Enabled = false;
            nudgiasp.Enabled = false;
            btntim.Enabled = true;
            btnxem.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            dgvsanpham.Enabled = true;
            btnexport.Enabled = true;
            btnimport.Enabled = true;
            taidssp();
        }
        List<sanpham> timsanpham(string tensanpham)
        {
            List<sanpham> list = sanphamDAO.Instance.timsanphamtheoma(tensanpham);
            return list;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            dssp.DataSource = timsanpham(txbtim.Text);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txbtim.Text = "";
            txbmasp.Text = "";
            txbtensp.Text = "";
            cbbloai.Text = "";
            nudgiasp.Value = 0;
            txbmasp.Enabled = false;
            cbbloai.Enabled = true;
            nudgiasp.Enabled = true;
            txbtensp.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnexport.Enabled = false;
            btnimport.Enabled = false;
            taidssp();
        }

        private bool ktradulieu()
        {
            if (txbmasp.Text == "" || txbtensp.Text == "" || cbbloai.Text == "" || nudgiasp.Value == 0)
            {
                MessageBox.Show("Vui lòng không để trống thông tin!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string masp = txbmasp.Text;
            string tensp = txbtensp.Text;
            string tenloai = (cbbloai.SelectedItem as loaisp).Maloai;
            float gia = (float)nudgiasp.Value;
            if (ktradulieu())
            {
                if (txbmasp.Enabled == true)
                {
                    if (sanphamDAO.Instance.timmasp(masp) == 0)
                    {
                        if (sanphamDAO.Instance.themsanpham(masp, tensp, tenloai, gia))
                        {
                            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                            taidssp();
                            cbbloai.Enabled = false;
                            txbmasp.Enabled = false;
                            txbtensp.Enabled = false;
                            nudgiasp.Enabled = false;
                            txbtim.Enabled = true;
                            btnxem.Enabled = true;
                            btnthem.Enabled = true;
                            btnsua.Enabled = true;
                            btnxoa.Enabled = true;
                            btnluu.Enabled = false;
                            btnhuy.Enabled = false;
                            btntim.Enabled = true;
                            dgvsanpham.Enabled = true;
                            btnexport.Enabled = true;
                            btnimport.Enabled = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                        cbbloai.Enabled = false;
                        txbmasp.Enabled = false;
                        txbtensp.Enabled = false;
                        nudgiasp.Enabled = false;
                        txbtim.Enabled = true;
                        btnxem.Enabled = true;
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        btntim.Enabled = true;
                        dgvsanpham.Enabled = true;
                        btnexport.Enabled = true;
                        btnimport.Enabled = true;
                    }
                }
                else if (txbmasp.Enabled == false)
                {
                    if (sanphamDAO.Instance.suasanpham(masp, tensp, tenloai, gia))
                    {
                        MessageBox.Show("Sửa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                        cbbloai.Enabled = false;
                        txbmasp.Enabled = false;
                        txbtensp.Enabled = false;
                        nudgiasp.Enabled = false;
                        txbtim.Enabled = true;
                        btnxem.Enabled = true;
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        btnhuy.Enabled = false;
                        btntim.Enabled = true;
                        btnexport.Enabled = true;
                        btnimport.Enabled = true;
                        taidssp();
                    }
                    else
                        MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK);
                    cbbloai.Enabled = false;
                    txbmasp.Enabled = false;
                    txbtensp.Enabled = false;
                    nudgiasp.Enabled = false;
                    txbtim.Enabled = true;
                    btnxem.Enabled = true;
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    btnhuy.Enabled = false;
                    btntim.Enabled = true;
                    btnexport.Enabled = true;
                    btnimport.Enabled = true;
                }
            }          
        }

        public void import(string path)
        {
            using (ExcelPackage ep = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet ews = ep.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = ews.Dimension.Start.Column; i <= ews.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(ews.Cells[1, i].Value.ToString());
                }
                for (int i = ews.Dimension.Start.Row + 1; i <= ews.Dimension.End.Row; i++)
                {
                    List<String> listRows = new List<string>();
                    for (int j = ews.Dimension.Start.Column; j <= ews.Dimension.End.Column; j++)
                    {
                        listRows.Add(ews.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dgvsanpham.DataSource = dataTable;
            }

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "flie chi tiết hóa đơn";
            openFileDialog.Filter = "Excel (*.xlsx) | *.xlsx | Excel 2003 (*.xls) | *.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    import(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!" + ex.Message);
                }
            }
        }

        private void Export(string p)
        {
            Excel.Application a = new Excel.Application();
            a.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvsanpham.Columns.Count; i++)
            {
                a.Cells[1, i + 1] = dgvsanpham.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvsanpham.Rows.Count; i++)
            {
                for (int j = 0; j < dgvsanpham.Rows[i].Cells.Count; j++)
                {
                    a.Cells[i + 2, j + 1] = dgvsanpham.Rows[i].Cells[j].Value;

                }
            }
            a.Columns.AutoFit();
            a.ActiveWorkbook.SaveCopyAs(p);
            a.ActiveWorkbook.Saved = true;
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "flie chi tiết hóa đơn";
            saveFileDialog.Filter = "Excel (*.xlsx) | *.xlsx | Excel 2003 (*.xls) | *.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Export(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!" + ex.Message);
                }
            }
        }
    }
}

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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

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


        private void btnimport_Click(object sender, EventArgs e)
        {

        }

        private void Export (string p)
        {
            Excel.Application a = new Excel.Application();
            a.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvcthd.Columns.Count; i++)
            {
                a.Cells[1, i + 1] = dgvcthd.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvcthd.Rows.Count; i++)
            {
                for (int j = 0; j < dgvcthd.Rows[i].Cells.Count; j++)
                {
                    a.Cells[i + 2, j + 1] = dgvcthd.Rows[i].Cells[j].Value;

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
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Export(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!" + ex.Message);
                }
            }
        }
    }
}

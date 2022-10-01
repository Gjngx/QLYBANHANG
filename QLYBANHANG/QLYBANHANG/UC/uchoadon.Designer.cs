namespace QLYBANHANG.UC
{
    partial class uchoadon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbtenloai = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvtimsanpham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudsoluong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtensanpham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.txbtimmasp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudgiamgia = new System.Windows.Forms.NumericUpDown();
            this.lsvhoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txbtongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbtenloai);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.dgvtimsanpham);
            this.panel1.Controls.Add(this.nudsoluong);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbtensanpham);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.txbtimmasp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 733);
            this.panel1.TabIndex = 1;
            // 
            // txbtenloai
            // 
            this.txbtenloai.Enabled = false;
            this.txbtenloai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtenloai.Location = new System.Drawing.Point(136, 51);
            this.txbtenloai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtenloai.Name = "txbtenloai";
            this.txbtenloai.Size = new System.Drawing.Size(267, 27);
            this.txbtenloai.TabIndex = 11;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(413, 47);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 109);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvtimsanpham
            // 
            this.dgvtimsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtimsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.TenLoaiSanPham,
            this.Gia});
            this.dgvtimsanpham.Location = new System.Drawing.Point(2, 172);
            this.dgvtimsanpham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtimsanpham.Name = "dgvtimsanpham";
            this.dgvtimsanpham.RowHeadersWidth = 62;
            this.dgvtimsanpham.RowTemplate.Height = 28;
            this.dgvtimsanpham.Size = new System.Drawing.Size(498, 559);
            this.dgvtimsanpham.TabIndex = 9;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "MaSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 8;
            this.MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 8;
            this.TenSanPham.Name = "TenSanPham";
            // 
            // TenLoaiSanPham
            // 
            this.TenLoaiSanPham.DataPropertyName = "TenLoai";
            this.TenLoaiSanPham.HeaderText = "Tên loại";
            this.TenLoaiSanPham.MinimumWidth = 8;
            this.TenLoaiSanPham.Name = "TenLoaiSanPham";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 8;
            this.Gia.Name = "Gia";
            // 
            // nudsoluong
            // 
            this.nudsoluong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudsoluong.Location = new System.Drawing.Point(136, 131);
            this.nudsoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudsoluong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudsoluong.Name = "nudsoluong";
            this.nudsoluong.Size = new System.Drawing.Size(266, 27);
            this.nudsoluong.TabIndex = 8;
            this.nudsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên loại:";
            // 
            // txbtensanpham
            // 
            this.txbtensanpham.Enabled = false;
            this.txbtensanpham.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtensanpham.Location = new System.Drawing.Point(136, 90);
            this.txbtensanpham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtensanpham.Name = "txbtensanpham";
            this.txbtensanpham.Size = new System.Drawing.Size(267, 27);
            this.txbtensanpham.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(413, 8);
            this.btntim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(81, 27);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txbtimmasp
            // 
            this.txbtimmasp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimmasp.Location = new System.Drawing.Point(136, 8);
            this.txbtimmasp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtimmasp.Name = "txbtimmasp";
            this.txbtimmasp.Size = new System.Drawing.Size(267, 27);
            this.txbtimmasp.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudgiamgia);
            this.panel2.Controls.Add(this.lsvhoadon);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnthanhtoan);
            this.panel2.Controls.Add(this.dtpngaylap);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbtongtien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(508, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 735);
            this.panel2.TabIndex = 2;
            // 
            // nudgiamgia
            // 
            this.nudgiamgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgiamgia.Location = new System.Drawing.Point(123, 94);
            this.nudgiamgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudgiamgia.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudgiamgia.Name = "nudgiamgia";
            this.nudgiamgia.Size = new System.Drawing.Size(199, 27);
            this.nudgiamgia.TabIndex = 13;
            this.nudgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lsvhoadon
            // 
            this.lsvhoadon.AutoArrange = false;
            this.lsvhoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvhoadon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvhoadon.HideSelection = false;
            this.lsvhoadon.Location = new System.Drawing.Point(2, 173);
            this.lsvhoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvhoadon.Name = "lsvhoadon";
            this.lsvhoadon.Size = new System.Drawing.Size(597, 560);
            this.lsvhoadon.TabIndex = 12;
            this.lsvhoadon.UseCompatibleStateImageBehavior = false;
            this.lsvhoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 168;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLYBANHANG.Properties.Resources.shopping_icon;
            this.pictureBox1.Location = new System.Drawing.Point(441, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giảm giá:";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.Location = new System.Drawing.Point(326, 5);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(98, 114);
            this.btnthanhtoan.TabIndex = 7;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaylap.Enabled = false;
            this.dtpngaylap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaylap.Location = new System.Drawing.Point(123, 7);
            this.dtpngaylap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(199, 27);
            this.dtpngaylap.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày lập:";
            // 
            // txbtongtien
            // 
            this.txbtongtien.BackColor = System.Drawing.SystemColors.Info;
            this.txbtongtien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtongtien.Location = new System.Drawing.Point(125, 51);
            this.txbtongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbtongtien.Name = "txbtongtien";
            this.txbtongtien.ReadOnly = true;
            this.txbtongtien.Size = new System.Drawing.Size(199, 27);
            this.txbtongtien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // uchoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uchoadon";
            this.Size = new System.Drawing.Size(1110, 737);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbtensanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txbtimmasp;
        private System.Windows.Forms.DataGridView dgvtimsanpham;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbtongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.ListView lsvhoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown nudgiamgia;
        private System.Windows.Forms.TextBox txbtenloai;
    }
}

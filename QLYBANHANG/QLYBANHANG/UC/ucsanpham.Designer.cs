namespace QLYBANHANG.UC
{
    partial class ucsanpham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudgiasp = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtim = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.txbtensp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmasp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiasp)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Location = new System.Drawing.Point(16, 235);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 94);
            this.panel1.TabIndex = 13;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(931, 17);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(137, 61);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(749, 17);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(137, 61);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(567, 17);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(137, 61);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(383, 17);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(137, 61);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(196, 17);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(137, 61);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(11, 17);
            this.btnxem.Margin = new System.Windows.Forms.Padding(2);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(137, 61);
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnimport);
            this.panel5.Controls.Add(this.btnexport);
            this.panel5.Controls.Add(this.nudgiasp);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btntim);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txbtim);
            this.panel5.Location = new System.Drawing.Point(578, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 173);
            this.panel5.TabIndex = 27;
            // 
            // nudgiasp
            // 
            this.nudgiasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgiasp.Location = new System.Drawing.Point(135, 20);
            this.nudgiasp.Margin = new System.Windows.Forms.Padding(2);
            this.nudgiasp.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudgiasp.Name = "nudgiasp";
            this.nudgiasp.Size = new System.Drawing.Size(371, 38);
            this.nudgiasp.TabIndex = 0;
            this.nudgiasp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Từ khóa:";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(394, 69);
            this.btntim.Margin = new System.Windows.Forms.Padding(2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(112, 38);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá:";
            // 
            // txbtim
            // 
            this.txbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtim.Location = new System.Drawing.Point(135, 69);
            this.txbtim.Margin = new System.Windows.Forms.Padding(2);
            this.txbtim.Name = "txbtim";
            this.txbtim.Size = new System.Drawing.Size(255, 38);
            this.txbtim.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbloai);
            this.panel3.Controls.Add(this.txbtensp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbmasp);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(16, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 173);
            this.panel3.TabIndex = 26;
            // 
            // cbbloai
            // 
            this.cbbloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(219, 20);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(322, 39);
            this.cbbloai.TabIndex = 0;
            // 
            // txbtensp
            // 
            this.txbtensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtensp.Location = new System.Drawing.Point(219, 119);
            this.txbtensp.Margin = new System.Windows.Forms.Padding(2);
            this.txbtensp.Name = "txbtensp";
            this.txbtensp.Size = new System.Drawing.Size(322, 38);
            this.txbtensp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txbmasp
            // 
            this.txbmasp.BackColor = System.Drawing.SystemColors.Window;
            this.txbmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmasp.Location = new System.Drawing.Point(219, 70);
            this.txbmasp.Margin = new System.Windows.Forms.Padding(2);
            this.txbmasp.Name = "txbmasp";
            this.txbmasp.Size = new System.Drawing.Size(322, 38);
            this.txbmasp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên loại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(382, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 42);
            this.label7.TabIndex = 28;
            this.label7.Text = "Danh sách sản phẩm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvsanpham);
            this.panel4.Location = new System.Drawing.Point(16, 333);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1079, 390);
            this.panel4.TabIndex = 29;
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenloai,
            this.Masp,
            this.Tensp,
            this.Gia});
            this.dgvsanpham.Location = new System.Drawing.Point(2, 4);
            this.dgvsanpham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.RowHeadersWidth = 82;
            this.dgvsanpham.RowTemplate.Height = 33;
            this.dgvsanpham.Size = new System.Drawing.Size(1075, 384);
            this.dgvsanpham.TabIndex = 4;
            // 
            // Tenloai
            // 
            this.Tenloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenloai.DataPropertyName = "TenLoai";
            this.Tenloai.HeaderText = "Tên loại";
            this.Tenloai.MinimumWidth = 6;
            this.Tenloai.Name = "Tenloai";
            // 
            // Masp
            // 
            this.Masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Masp.DataPropertyName = "MaSanPham";
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.MinimumWidth = 6;
            this.Masp.Name = "Masp";
            // 
            // Tensp
            // 
            this.Tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tensp.DataPropertyName = "TenSanPham";
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.MinimumWidth = 6;
            this.Tensp.Name = "Tensp";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Đơn giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(328, 117);
            this.btnexport.Margin = new System.Windows.Forms.Padding(2);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(178, 38);
            this.btnexport.TabIndex = 6;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnimport
            // 
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.Location = new System.Drawing.Point(133, 117);
            this.btnimport.Margin = new System.Windows.Forms.Padding(2);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(178, 38);
            this.btnimport.TabIndex = 7;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Excel";
            // 
            // ucsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "ucsanpham";
            this.Size = new System.Drawing.Size(1110, 737);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudgiasp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nudgiasp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbtim;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.TextBox txbtensp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmasp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnexport;
    }
}

namespace QLYBANHANG.UC
{
    partial class ucquanlytk
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btndatlaimk = new System.Windows.Forms.Button();
            this.txbmatkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.txbtim = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudquyen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbtendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquyen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btndatlaimk);
            this.panel5.Controls.Add(this.txbmatkhau);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btntim);
            this.panel5.Controls.Add(this.txbtim);
            this.panel5.Location = new System.Drawing.Point(575, 53);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 173);
            this.panel5.TabIndex = 34;
            // 
            // btndatlaimk
            // 
            this.btndatlaimk.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatlaimk.Location = new System.Drawing.Point(388, 71);
            this.btndatlaimk.Margin = new System.Windows.Forms.Padding(2);
            this.btndatlaimk.Name = "btndatlaimk";
            this.btndatlaimk.Size = new System.Drawing.Size(118, 38);
            this.btndatlaimk.TabIndex = 4;
            this.btndatlaimk.Text = "Đặt lại";
            this.btndatlaimk.UseVisualStyleBackColor = true;
            this.btndatlaimk.Click += new System.EventHandler(this.btndatlaimk_Click);
            // 
            // txbmatkhau
            // 
            this.txbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmatkhau.Location = new System.Drawing.Point(148, 71);
            this.txbmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.txbmatkhau.Name = "txbmatkhau";
            this.txbmatkhau.PasswordChar = '*';
            this.txbmatkhau.Size = new System.Drawing.Size(225, 38);
            this.txbmatkhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Từ khóa:";
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(388, 21);
            this.btntim.Margin = new System.Windows.Forms.Padding(2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(118, 39);
            this.btntim.TabIndex = 2;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txbtim
            // 
            this.txbtim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtim.Location = new System.Drawing.Point(148, 22);
            this.txbtim.Margin = new System.Windows.Forms.Padding(2);
            this.txbtim.Name = "txbtim";
            this.txbtim.Size = new System.Drawing.Size(225, 38);
            this.txbtim.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(364, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 42);
            this.label11.TabIndex = 36;
            this.label11.Text = "Danh sách tài khoản";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvtaikhoan);
            this.panel4.Location = new System.Drawing.Point(13, 328);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1079, 390);
            this.panel4.TabIndex = 37;
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtaikhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tennhanvien,
            this.Tendangnhap,
            this.Quyen});
            this.dgvtaikhoan.Location = new System.Drawing.Point(2, 4);
            this.dgvtaikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.RowHeadersWidth = 82;
            this.dgvtaikhoan.RowTemplate.Height = 33;
            this.dgvtaikhoan.Size = new System.Drawing.Size(1075, 384);
            this.dgvtaikhoan.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudquyen);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txbtennhanvien);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbtendangnhap);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 173);
            this.panel3.TabIndex = 33;
            // 
            // nudquyen
            // 
            this.nudquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudquyen.Location = new System.Drawing.Point(230, 123);
            this.nudquyen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudquyen.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudquyen.Name = "nudquyen";
            this.nudquyen.Size = new System.Drawing.Size(311, 38);
            this.nudquyen.TabIndex = 3;
            this.nudquyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quyền:";
            // 
            // txbtennhanvien
            // 
            this.txbtennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtennhanvien.Location = new System.Drawing.Point(230, 71);
            this.txbtennhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.txbtennhanvien.Name = "txbtennhanvien";
            this.txbtennhanvien.Size = new System.Drawing.Size(311, 38);
            this.txbtennhanvien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên nhân viên:";
            // 
            // txbtendangnhap
            // 
            this.txbtendangnhap.BackColor = System.Drawing.SystemColors.Window;
            this.txbtendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtendangnhap.Location = new System.Drawing.Point(230, 18);
            this.txbtendangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.txbtendangnhap.Name = "txbtendangnhap";
            this.txbtendangnhap.Size = new System.Drawing.Size(311, 38);
            this.txbtendangnhap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng nhập:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Location = new System.Drawing.Point(13, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 94);
            this.panel1.TabIndex = 38;
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
            this.btnxoa.Location = new System.Drawing.Point(568, 17);
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
            // Tennhanvien
            // 
            this.Tennhanvien.DataPropertyName = "TAIKHOAN";
            this.Tennhanvien.HeaderText = "Tên nhân viên";
            this.Tennhanvien.MinimumWidth = 6;
            this.Tennhanvien.Name = "Tennhanvien";
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.DataPropertyName = "HOTEN";
            this.Tendangnhap.HeaderText = "Tên đăng nhập";
            this.Tendangnhap.MinimumWidth = 6;
            this.Tendangnhap.Name = "Tendangnhap";
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "PHANQUYEN";
            this.Quyen.HeaderText = "Phân quyền";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            // 
            // ucquanlytk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ucquanlytk";
            this.Size = new System.Drawing.Size(1094, 699);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudquyen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btndatlaimk;
        private System.Windows.Forms.TextBox txbmatkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txbtim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvtaikhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudquyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}

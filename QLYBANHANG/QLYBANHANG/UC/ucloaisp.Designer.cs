namespace QLYBANHANG.UC
{
    partial class ucloaisp
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvdanhmuc = new System.Windows.Forms.DataGridView();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbtendanhmuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbmadanhmuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1200, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(986, 269);
            this.panel5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(171, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(670, 108);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại sản phẩm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvdanhmuc);
            this.panel4.Location = new System.Drawing.Point(24, 491);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2167, 900);
            this.panel4.TabIndex = 13;
            // 
            // dgvdanhmuc
            // 
            this.dgvdanhmuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdanhmuc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvdanhmuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhmuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.Tenloai});
            this.dgvdanhmuc.Location = new System.Drawing.Point(3, 3);
            this.dgvdanhmuc.Name = "dgvdanhmuc";
            this.dgvdanhmuc.RowHeadersWidth = 82;
            this.dgvdanhmuc.RowTemplate.Height = 33;
            this.dgvdanhmuc.Size = new System.Drawing.Size(2158, 892);
            this.dgvdanhmuc.TabIndex = 3;
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "Maloai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            // 
            // Tenloai
            // 
            this.Tenloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenloai.DataPropertyName = "Tenloai";
            this.Tenloai.HeaderText = "Tên loại";
            this.Tenloai.MinimumWidth = 6;
            this.Tenloai.Name = "Tenloai";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbtendanhmuc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbmadanhmuc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(27, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1162, 269);
            this.panel3.TabIndex = 11;
            // 
            // txbtendanhmuc
            // 
            this.txbtendanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtendanhmuc.Location = new System.Drawing.Point(430, 159);
            this.txbtendanhmuc.Name = "txbtendanhmuc";
            this.txbtendanhmuc.Size = new System.Drawing.Size(707, 69);
            this.txbtendanhmuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại:";
            // 
            // txbmadanhmuc
            // 
            this.txbmadanhmuc.BackColor = System.Drawing.SystemColors.Window;
            this.txbmadanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmadanhmuc.Location = new System.Drawing.Point(430, 42);
            this.txbmadanhmuc.Name = "txbmadanhmuc";
            this.txbmadanhmuc.Size = new System.Drawing.Size(707, 69);
            this.txbmadanhmuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnhuy);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btnxem);
            this.panel1.Location = new System.Drawing.Point(27, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2158, 181);
            this.panel1.TabIndex = 12;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(1862, 33);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(274, 117);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(1498, 33);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(274, 117);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1135, 33);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(274, 117);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(766, 33);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(274, 117);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(393, 33);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(274, 117);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(22, 33);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(274, 117);
            this.btnxem.TabIndex = 0;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // ucloaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ucloaisp";
            this.Size = new System.Drawing.Size(2220, 1417);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvdanhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbtendanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmadanhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
    }
}

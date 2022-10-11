namespace QLYBANHANG.UC
{
    partial class ucqlyhoadon
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
            this.txbtimsohd = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.dgvcthd = new System.Windows.Forms.DataGridView();
            this.sohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.btntailai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbtimsohd
            // 
            this.txbtimsohd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimsohd.Location = new System.Drawing.Point(170, 11);
            this.txbtimsohd.Name = "txbtimsohd";
            this.txbtimsohd.Size = new System.Drawing.Size(123, 36);
            this.txbtimsohd.TabIndex = 0;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(299, 11);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(120, 36);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // dgvcthd
            // 
            this.dgvcthd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sohd,
            this.masp,
            this.tensp,
            this.soluong,
            this.gia,
            this.thanhtien});
            this.dgvcthd.Location = new System.Drawing.Point(0, 85);
            this.dgvcthd.Name = "dgvcthd";
            this.dgvcthd.RowHeadersWidth = 82;
            this.dgvcthd.Size = new System.Drawing.Size(1107, 649);
            this.dgvcthd.TabIndex = 2;
            // 
            // sohd
            // 
            this.sohd.DataPropertyName = "sohd";
            this.sohd.HeaderText = "Số hóa đơn";
            this.sohd.MinimumWidth = 10;
            this.sohd.Name = "sohd";
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masanpham";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.MinimumWidth = 10;
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensanpham";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 10;
            this.tensp.Name = "tensp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 10;
            this.soluong.Name = "soluong";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 10;
            this.gia.Name = "gia";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 10;
            this.thanhtien.Name = "thanhtien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnexport);
            this.panel1.Controls.Add(this.btntailai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbtimsohd);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 66);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Export excel:";
            // 
            // btnexport
            // 
            this.btnexport.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(710, 11);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(138, 36);
            this.btnexport.TabIndex = 5;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btntailai
            // 
            this.btntailai.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntailai.Location = new System.Drawing.Point(425, 11);
            this.btntailai.Name = "btntailai";
            this.btntailai.Size = new System.Drawing.Size(120, 36);
            this.btntailai.TabIndex = 4;
            this.btntailai.Text = "Tải ds";
            this.btntailai.UseVisualStyleBackColor = true;
            this.btntailai.Click += new System.EventHandler(this.btntailai_Click);
            // 
            // ucqlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvcthd);
            this.Name = "ucqlyhoadon";
            this.Size = new System.Drawing.Size(1110, 737);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbtimsohd;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridView dgvcthd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Button btntailai;
        private System.Windows.Forms.Label label2;
    }
}

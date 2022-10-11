namespace QLYBANHANG
{
    partial class frmmain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.fdfcontainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acenhanvien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acetaohoadon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acequanly = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acedoanhthu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceloaisp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acesanpham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acecthd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acequanlytaikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acedangxuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.bsitaikhoan = new DevExpress.XtraBars.BarSubItem();
            this.btncapnhatthongtin = new DevExpress.XtraBars.BarButtonItem();
            this.btndoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdfcontainer
            // 
            this.fdfcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdfcontainer.Location = new System.Drawing.Point(217, 31);
            this.fdfcontainer.Margin = new System.Windows.Forms.Padding(2);
            this.fdfcontainer.Name = "fdfcontainer";
            this.fdfcontainer.Size = new System.Drawing.Size(1112, 739);
            this.fdfcontainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acenhanvien,
            this.acequanly,
            this.acedangxuat});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(217, 739);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acenhanvien
            // 
            this.acenhanvien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acetaohoadon});
            this.acenhanvien.Expanded = true;
            this.acenhanvien.Name = "acenhanvien";
            this.acenhanvien.Text = "Nhân viên";
            // 
            // acetaohoadon
            // 
            this.acetaohoadon.Expanded = true;
            this.acetaohoadon.Name = "acetaohoadon";
            this.acetaohoadon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acetaohoadon.Text = "Tạo hóa đơn";
            this.acetaohoadon.Click += new System.EventHandler(this.acehoadon_Click);
            // 
            // acequanly
            // 
            this.acequanly.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acedoanhthu,
            this.aceloaisp,
            this.acesanpham,
            this.acecthd,
            this.acequanlytaikhoan});
            this.acequanly.Expanded = true;
            this.acequanly.Name = "acequanly";
            this.acequanly.Text = "Quản lý";
            // 
            // acedoanhthu
            // 
            this.acedoanhthu.Name = "acedoanhthu";
            this.acedoanhthu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acedoanhthu.Text = "Doanh thu";
            this.acedoanhthu.Click += new System.EventHandler(this.acedoanhthu_Click);
            // 
            // aceloaisp
            // 
            this.aceloaisp.Name = "aceloaisp";
            this.aceloaisp.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceloaisp.Text = "Loai sản phẩm";
            this.aceloaisp.Click += new System.EventHandler(this.aceloaisp_Click);
            // 
            // acesanpham
            // 
            this.acesanpham.Name = "acesanpham";
            this.acesanpham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acesanpham.Text = "Sản phẩm";
            this.acesanpham.Click += new System.EventHandler(this.acesanpham_Click);
            // 
            // acecthd
            // 
            this.acecthd.Name = "acecthd";
            this.acecthd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acecthd.Text = "Chi tiết hoá đơn";
            this.acecthd.Click += new System.EventHandler(this.acecthd_Click);
            // 
            // acequanlytaikhoan
            // 
            this.acequanlytaikhoan.Name = "acequanlytaikhoan";
            this.acequanlytaikhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acequanlytaikhoan.Text = "Quản lý tài khoản";
            this.acequanlytaikhoan.Click += new System.EventHandler(this.acequanlytaikhoan_Click);
            // 
            // acedangxuat
            // 
            this.acedangxuat.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acedangxuat.Appearance.Default.Options.UseFont = true;
            this.acedangxuat.Name = "acedangxuat";
            this.acedangxuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acedangxuat.Text = "Đăng xuất";
            this.acedangxuat.Click += new System.EventHandler(this.acedangxuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barListItem1,
            this.barToolbarsListItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.bsitaikhoan,
            this.btncapnhatthongtin,
            this.btndoimatkhau});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1329, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.bsitaikhoan, true);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 1;
            this.barListItem1.Name = "barListItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 2;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 3;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "barSubItem3";
            this.barSubItem3.Id = 4;
            this.barSubItem3.Name = "barSubItem3";
            toolTipItem1.Text = "Cập nhật  thông tin";
            superToolTip1.Items.Add(toolTipItem1);
            this.barSubItem3.SuperTip = superToolTip1;
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Tài khoản";
            this.barSubItem4.Id = 5;
            this.barSubItem4.Name = "barSubItem4";
            this.barSubItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "barSubItem5";
            this.barSubItem5.Id = 6;
            this.barSubItem5.Name = "barSubItem5";
            this.barSubItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // bsitaikhoan
            // 
            this.bsitaikhoan.Caption = "Tài khoản";
            this.bsitaikhoan.Id = 7;
            this.bsitaikhoan.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btncapnhatthongtin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btndoimatkhau)});
            this.bsitaikhoan.Name = "bsitaikhoan";
            // 
            // btncapnhatthongtin
            // 
            this.btncapnhatthongtin.Caption = "Cập nhật thông tin";
            this.btncapnhatthongtin.Id = 8;
            this.btncapnhatthongtin.Name = "btncapnhatthongtin";
            this.btncapnhatthongtin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btncapnhatthongtin_ItemClick);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Caption = "Đổi mật khẩu";
            this.btndoimatkhau.Id = 9;
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndoimatkhau_ItemClick);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barListItem1,
            this.barToolbarsListItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.bsitaikhoan,
            this.btncapnhatthongtin,
            this.btndoimatkhau});
            this.fluentFormDefaultManager1.MaxItemId = 10;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 770);
            this.ControlContainer = this.fdfcontainer;
            this.Controls.Add(this.fdfcontainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::QLYBANHANG.Properties.Resources.icons8_shopping_cart_100;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmmain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fdfcontainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acenhanvien;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acetaohoadon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acequanly;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acedoanhthu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceloaisp;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acesanpham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acequanlytaikhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acedangxuat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarSubItem bsitaikhoan;
        private DevExpress.XtraBars.BarButtonItem btncapnhatthongtin;
        private DevExpress.XtraBars.BarButtonItem btndoimatkhau;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acecthd;
    }
}
namespace PKDK
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhaiBao = new DevExpress.XtraBars.BarButtonItem();
            this.stsTacGia = new DevExpress.XtraBars.BarStaticItem();
            this.stsHomNay = new DevExpress.XtraBars.BarStaticItem();
            this.stsTenDangNhap = new DevExpress.XtraBars.BarStaticItem();
            this.btnThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnCDHA = new DevExpress.XtraBars.BarButtonItem();
            this.btnXetNghiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoiXN = new DevExpress.XtraBars.BarButtonItem();
            this.btnMauDonThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnBenhTat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDVHC = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongKham = new DevExpress.XtraBars.BarButtonItem();
            this.btnBacSi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTinKB = new DevExpress.XtraBars.BarButtonItem();
            this.btnDnhSachBN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnSoKB = new DevExpress.XtraBars.BarButtonItem();
            this.btnDnhSachChoThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachDaThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuBacSi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuNguoiBenh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSoCLS = new DevExpress.XtraBars.BarButtonItem();
            this.btnSoKSK = new DevExpress.XtraBars.BarButtonItem();
            this.btnGoiKSK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonThietLap = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonKhamBenh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnBienBan = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangXuat,
            this.btnDoiMatKhau,
            this.btnKhaiBao,
            this.stsTacGia,
            this.stsHomNay,
            this.stsTenDangNhap,
            this.btnThuoc,
            this.btnDichVu,
            this.btnCDHA,
            this.btnXetNghiem,
            this.btnGoiXN,
            this.btnMauDonThuoc,
            this.btnBenhTat,
            this.btnDVHC,
            this.btnPhongKham,
            this.btnBacSi,
            this.btnThongTinKB,
            this.btnDnhSachBN,
            this.btnDanhSachTK,
            this.btnSoKB,
            this.btnDnhSachChoThu,
            this.btnDanhSachDaThu,
            this.btnThuDichVu,
            this.btnThuBacSi,
            this.btnThuNguoiBenh,
            this.btnSoCLS,
            this.btnSoKSK,
            this.btnGoiKSK,
            this.btnBienBan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHeThong,
            this.ribbonThietLap,
            this.ribbonKhamBenh,
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(834, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.LargeImage = global::PKDK.Properties.Resources.Keys_icon;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 2;
            this.btnDoiMatKhau.ImageOptions.LargeImage = global::PKDK.Properties.Resources._1416573065_Password_protection;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnKhaiBao
            // 
            this.btnKhaiBao.Caption = "Khai báo";
            this.btnKhaiBao.Id = 3;
            this.btnKhaiBao.ImageOptions.LargeImage = global::PKDK.Properties.Resources._1416573149_User;
            this.btnKhaiBao.Name = "btnKhaiBao";
            this.btnKhaiBao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhaiBao_ItemClick);
            // 
            // stsTacGia
            // 
            this.stsTacGia.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.stsTacGia.Caption = "Copyright ©  2020 by Doan Van Thanh - Tel. 0946 459 989";
            this.stsTacGia.Id = 4;
            this.stsTacGia.Name = "stsTacGia";
            // 
            // stsHomNay
            // 
            this.stsHomNay.Id = 5;
            this.stsHomNay.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.stsHomNay.ItemAppearance.Normal.Options.UseForeColor = true;
            this.stsHomNay.Name = "stsHomNay";
            // 
            // stsTenDangNhap
            // 
            this.stsTenDangNhap.Caption = " ";
            this.stsTenDangNhap.Id = 6;
            this.stsTenDangNhap.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.stsTenDangNhap.ItemAppearance.Normal.Options.UseForeColor = true;
            this.stsTenDangNhap.Name = "stsTenDangNhap";
            // 
            // btnThuoc
            // 
            this.btnThuoc.Caption = "Thuốc";
            this.btnThuoc.Id = 7;
            this.btnThuoc.ImageOptions.LargeImage = global::PKDK.Properties.Resources._120px_Medicine_Drugs_svg;
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuoc_ItemClick);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Caption = "Dịch vụ";
            this.btnDichVu.Id = 8;
            this.btnDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.ImageOptions.Image")));
            this.btnDichVu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDichVu.ImageOptions.LargeImage")));
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDichVu_ItemClick);
            // 
            // btnCDHA
            // 
            this.btnCDHA.Caption = "Chẩn đoán hình ảnh";
            this.btnCDHA.Id = 9;
            this.btnCDHA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCDHA.ImageOptions.Image")));
            this.btnCDHA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCDHA.ImageOptions.LargeImage")));
            this.btnCDHA.Name = "btnCDHA";
            this.btnCDHA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCDHA_ItemClick);
            // 
            // btnXetNghiem
            // 
            this.btnXetNghiem.Caption = "Xét nghiệm";
            this.btnXetNghiem.Id = 10;
            this.btnXetNghiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXetNghiem.ImageOptions.Image")));
            this.btnXetNghiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXetNghiem.ImageOptions.LargeImage")));
            this.btnXetNghiem.Name = "btnXetNghiem";
            this.btnXetNghiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXetNghiem_ItemClick);
            // 
            // btnGoiXN
            // 
            this.btnGoiXN.Caption = "Gói xét nghiệm";
            this.btnGoiXN.Id = 11;
            this.btnGoiXN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiXN.ImageOptions.Image")));
            this.btnGoiXN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGoiXN.ImageOptions.LargeImage")));
            this.btnGoiXN.Name = "btnGoiXN";
            this.btnGoiXN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGoiXN_ItemClick);
            // 
            // btnMauDonThuoc
            // 
            this.btnMauDonThuoc.Caption = "Đơn thuốc mẫu";
            this.btnMauDonThuoc.Id = 12;
            this.btnMauDonThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMauDonThuoc.ImageOptions.Image")));
            this.btnMauDonThuoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMauDonThuoc.ImageOptions.LargeImage")));
            this.btnMauDonThuoc.Name = "btnMauDonThuoc";
            this.btnMauDonThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMauDonThuoc_ItemClick);
            // 
            // btnBenhTat
            // 
            this.btnBenhTat.Caption = "Bệnh tật";
            this.btnBenhTat.Id = 13;
            this.btnBenhTat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBenhTat.ImageOptions.Image")));
            this.btnBenhTat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBenhTat.ImageOptions.LargeImage")));
            this.btnBenhTat.Name = "btnBenhTat";
            this.btnBenhTat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBenhTat_ItemClick);
            // 
            // btnDVHC
            // 
            this.btnDVHC.Caption = "Đơn vị hành chính";
            this.btnDVHC.Id = 14;
            this.btnDVHC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDVHC.ImageOptions.Image")));
            this.btnDVHC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDVHC.ImageOptions.LargeImage")));
            this.btnDVHC.Name = "btnDVHC";
            this.btnDVHC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDVHC_ItemClick);
            // 
            // btnPhongKham
            // 
            this.btnPhongKham.Caption = "Phòng khám";
            this.btnPhongKham.Id = 15;
            this.btnPhongKham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongKham.ImageOptions.Image")));
            this.btnPhongKham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhongKham.ImageOptions.LargeImage")));
            this.btnPhongKham.Name = "btnPhongKham";
            this.btnPhongKham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongKham_ItemClick);
            // 
            // btnBacSi
            // 
            this.btnBacSi.Caption = "Bác sĩ";
            this.btnBacSi.Id = 16;
            this.btnBacSi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBacSi.ImageOptions.Image")));
            this.btnBacSi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBacSi.ImageOptions.LargeImage")));
            this.btnBacSi.Name = "btnBacSi";
            this.btnBacSi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBacSi_ItemClick);
            // 
            // btnThongTinKB
            // 
            this.btnThongTinKB.Caption = "Thông tin khám";
            this.btnThongTinKB.Id = 17;
            this.btnThongTinKB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinKB.ImageOptions.Image")));
            this.btnThongTinKB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongTinKB.ImageOptions.LargeImage")));
            this.btnThongTinKB.Name = "btnThongTinKB";
            this.btnThongTinKB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongTinKB_ItemClick);
            // 
            // btnDnhSachBN
            // 
            this.btnDnhSachBN.Caption = "Danh sách bệnh nhân";
            this.btnDnhSachBN.Id = 18;
            this.btnDnhSachBN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDnhSachBN.ImageOptions.Image")));
            this.btnDnhSachBN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDnhSachBN.ImageOptions.LargeImage")));
            this.btnDnhSachBN.Name = "btnDnhSachBN";
            this.btnDnhSachBN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDnhSachBN_ItemClick);
            // 
            // btnDanhSachTK
            // 
            this.btnDanhSachTK.Caption = "Danh sách tái khám";
            this.btnDanhSachTK.Id = 19;
            this.btnDanhSachTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachTK.ImageOptions.Image")));
            this.btnDanhSachTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachTK.ImageOptions.LargeImage")));
            this.btnDanhSachTK.Name = "btnDanhSachTK";
            this.btnDanhSachTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachTK_ItemClick);
            // 
            // btnSoKB
            // 
            this.btnSoKB.Caption = "Sổ khám bệnh chung";
            this.btnSoKB.Id = 20;
            this.btnSoKB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoKB.ImageOptions.Image")));
            this.btnSoKB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoKB.ImageOptions.LargeImage")));
            this.btnSoKB.Name = "btnSoKB";
            this.btnSoKB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoKB_ItemClick);
            // 
            // btnDnhSachChoThu
            // 
            this.btnDnhSachChoThu.Caption = "Danh sách chờ thu";
            this.btnDnhSachChoThu.Id = 21;
            this.btnDnhSachChoThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDnhSachChoThu.ImageOptions.Image")));
            this.btnDnhSachChoThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDnhSachChoThu.ImageOptions.LargeImage")));
            this.btnDnhSachChoThu.Name = "btnDnhSachChoThu";
            this.btnDnhSachChoThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDnhSachChoThu_ItemClick);
            // 
            // btnDanhSachDaThu
            // 
            this.btnDanhSachDaThu.Caption = "Danh sách đã thu";
            this.btnDanhSachDaThu.Id = 22;
            this.btnDanhSachDaThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSachDaThu.ImageOptions.Image")));
            this.btnDanhSachDaThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachDaThu.ImageOptions.LargeImage")));
            this.btnDanhSachDaThu.Name = "btnDanhSachDaThu";
            this.btnDanhSachDaThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachDaThu_ItemClick);
            // 
            // btnThuDichVu
            // 
            this.btnThuDichVu.Caption = "Dịch vụ";
            this.btnThuDichVu.Id = 23;
            this.btnThuDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThuDichVu.ImageOptions.Image")));
            this.btnThuDichVu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThuDichVu.ImageOptions.LargeImage")));
            this.btnThuDichVu.Name = "btnThuDichVu";
            this.btnThuDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuDichVu_ItemClick);
            // 
            // btnThuBacSi
            // 
            this.btnThuBacSi.Caption = "Theo Bác sĩ";
            this.btnThuBacSi.Id = 25;
            this.btnThuBacSi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThuBacSi.ImageOptions.Image")));
            this.btnThuBacSi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThuBacSi.ImageOptions.LargeImage")));
            this.btnThuBacSi.Name = "btnThuBacSi";
            // 
            // btnThuNguoiBenh
            // 
            this.btnThuNguoiBenh.Caption = "Người bệnh";
            this.btnThuNguoiBenh.Id = 26;
            this.btnThuNguoiBenh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThuNguoiBenh.ImageOptions.Image")));
            this.btnThuNguoiBenh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThuNguoiBenh.ImageOptions.LargeImage")));
            this.btnThuNguoiBenh.Name = "btnThuNguoiBenh";
            this.btnThuNguoiBenh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuNguoiBenh_ItemClick);
            // 
            // btnSoCLS
            // 
            this.btnSoCLS.Caption = "Sổ cận lâm sàng";
            this.btnSoCLS.Id = 27;
            this.btnSoCLS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoCLS.ImageOptions.Image")));
            this.btnSoCLS.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoCLS.ImageOptions.LargeImage")));
            this.btnSoCLS.Name = "btnSoCLS";
            this.btnSoCLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoCLS_ItemClick);
            // 
            // btnSoKSK
            // 
            this.btnSoKSK.Caption = "Sổ khám BH nhân thọ";
            this.btnSoKSK.Id = 28;
            this.btnSoKSK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoKSK.ImageOptions.Image")));
            this.btnSoKSK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoKSK.ImageOptions.LargeImage")));
            this.btnSoKSK.Name = "btnSoKSK";
            this.btnSoKSK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoKSK_ItemClick);
            // 
            // btnGoiKSK
            // 
            this.btnGoiKSK.Caption = "Gói KSK";
            this.btnGoiKSK.Id = 29;
            this.btnGoiKSK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiKSK.ImageOptions.Image")));
            this.btnGoiKSK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGoiKSK.ImageOptions.LargeImage")));
            this.btnGoiKSK.Name = "btnGoiKSK";
            this.btnGoiKSK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGoiKSK_ItemClick);
            // 
            // ribbonHeThong
            // 
            this.ribbonHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonHeThong.Name = "ribbonHeThong";
            this.ribbonHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhaiBao);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonThietLap
            // 
            this.ribbonThietLap.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonThietLap.Name = "ribbonThietLap";
            this.ribbonThietLap.Text = "Thiết lập";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThuoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMauDonThuoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDichVu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCDHA);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnXetNghiem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGoiXN);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGoiKSK);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thuốc dịch vụ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBenhTat);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDVHC);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhongKham);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBacSi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tổng hợp";
            // 
            // ribbonKhamBenh
            // 
            this.ribbonKhamBenh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonKhamBenh.Name = "ribbonKhamBenh";
            this.ribbonKhamBenh.Text = "Khám bệnh";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThongTinKB);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDnhSachBN);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhSachTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSoKB);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSoCLS);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSoKSK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBienBan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông tin khám bệnh";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chi phí";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDnhSachChoThu);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDanhSachDaThu);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thanh toán";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnThuDichVu);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnThuNguoiBenh);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kê thu";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.stsTacGia);
            this.ribbonStatusBar1.ItemLinks.Add(this.stsHomNay);
            this.ribbonStatusBar1.ItemLinks.Add(this.stsTenDangNhap, true);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 429);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(834, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // btnBienBan
            // 
            this.btnBienBan.Caption = "Biên bản đối chiều";
            this.btnBienBan.Id = 30;
            this.btnBienBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnBienBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnBienBan.Name = "btnBienBan";
            this.btnBienBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBienBan_ItemClick);
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý phòng khám";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonThietLap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonKhamBenh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnKhaiBao;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem stsTacGia;
        private DevExpress.XtraBars.BarStaticItem stsHomNay;
        private DevExpress.XtraBars.BarStaticItem stsTenDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnThuoc;
        private DevExpress.XtraBars.BarButtonItem btnDichVu;
        private DevExpress.XtraBars.BarButtonItem btnCDHA;
        private DevExpress.XtraBars.BarButtonItem btnXetNghiem;
        private DevExpress.XtraBars.BarButtonItem btnGoiXN;
        private DevExpress.XtraBars.BarButtonItem btnMauDonThuoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnBenhTat;
        private DevExpress.XtraBars.BarButtonItem btnDVHC;
        private DevExpress.XtraBars.BarButtonItem btnPhongKham;
        private DevExpress.XtraBars.BarButtonItem btnBacSi;
        private DevExpress.XtraBars.BarButtonItem btnThongTinKB;
        private DevExpress.XtraBars.BarButtonItem btnDnhSachBN;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachTK;
        private DevExpress.XtraBars.BarButtonItem btnSoKB;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDnhSachChoThu;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachDaThu;
        private DevExpress.XtraBars.BarButtonItem btnThuDichVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnThuBacSi;
        private DevExpress.XtraBars.BarButtonItem btnThuNguoiBenh;
        private DevExpress.XtraBars.BarButtonItem btnSoCLS;
        private DevExpress.XtraBars.BarButtonItem btnSoKSK;
        private DevExpress.XtraBars.BarButtonItem btnGoiKSK;
        private DevExpress.XtraBars.BarButtonItem btnBienBan;
    }
}


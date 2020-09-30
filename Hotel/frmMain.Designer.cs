namespace Hotel
{
	// Token: 0x02000013 RID: 19
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000184 RID: 388 RVA: 0x0002237C File Offset: 0x0002057C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000223B4 File Offset: 0x000205B4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hotel.frmMain));
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnChangPassword = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnLogout = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hoạtĐộngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListMenu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListItems = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListTypeRoom = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mbListTableArea = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnNoticeRepair = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnUsedService = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnModifyTicket = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnManagementSales = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnSaveActive = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnRevenueStatistics = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnItemsSaleStatistics = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnSummaryResultSale = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnDetailDaily = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListDestroyTicket = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnCustomer = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListCustomer = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnSendMsgToCustomer = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnCustomerVip = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnStock = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListVendor = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnImportStock = new global::System.Windows.Forms.ToolStripMenuItem();
			this.côngNợToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListReasonImportExport = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lýDoThuChiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListAccountBank = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnCreatTicketImport = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnCreateTicketExport = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListTicketImport = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListTicketExport = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnExist = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhânSựToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListEmployes = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnListShiftWorking = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tạmỨngLươngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thưởngPhạtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chấmCôngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tínhLươngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.quảnTrịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoQuỹToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchPhiếuThuTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchPhiếuChiTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchPhiếuChiTheoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpThuChiTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpThuChiTheoLýDoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoTồnQuỹToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoDanhMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchKháchHàngTheoNhómToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchKháchHàngTheoNhânViênToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchNhàCungCấpTheoNhómToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchĐợtKhuyếnMãiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchMặtHàngTheoNhómToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kháchHàngĐếnNgàySinhNhậtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.côngThứcĐịnhLươnhjToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánHàngTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpDoanhThuChưaThanhToánToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánHàngTheoNgàyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.theoNhânViênPhụcVụToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánTheoNhânViênToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánHàngTheoNhânViênToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.theoKhuVựcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánHàngTheoKhuVựcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánHàngTheoBànPhòngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchHóaĐơnTheoBànToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoBànToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.theoThuNgânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánTheoThuNgânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánHàngTheoThuNgânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.theoKháchHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpBánTheoKháchHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánTheoKháchHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBánHàngKhácToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tổngHợpHoaHồngTheoNVKDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoĐặtHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoKhoHàngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoCôngNợToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoQuảnTrịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoBiểuĐồToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trợGiúpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2 = new global::System.Windows.Forms.MenuStrip();
			this.mnUsedServiceOder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnQuanLyBanHang = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnThongKeDoanhThu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnThongKeMatHangBan = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnChiTietHoatDong = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnTongHopKetQuaKinhDoanh = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnTonKho = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnGhiChu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnBaoCao = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnThoat = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabSuDungDichVu = new global::System.Windows.Forms.TabPage();
			this.cbBangGia = new global::System.Windows.Forms.ComboBox();
			this.label35 = new global::System.Windows.Forms.Label();
			this.txtHoChieu = new global::System.Windows.Forms.TextBox();
			this.label31 = new global::System.Windows.Forms.Label();
			this.cbNhanVien = new global::System.Windows.Forms.ComboBox();
			this.txtGPLX = new global::System.Windows.Forms.TextBox();
			this.label30 = new global::System.Windows.Forms.Label();
			this.btnFinish = new global::System.Windows.Forms.Button();
			this.dtEnd = new global::System.Windows.Forms.DateTimePicker();
			this.dtNgay = new global::System.Windows.Forms.DateTimePicker();
			this.dtBegin = new global::System.Windows.Forms.DateTimePicker();
			this.dgvViewMenu = new global::System.Windows.Forms.DataGridView();
			this.lstViewMenu = new global::System.Windows.Forms.ListView();
			this.txtTimKiem = new global::System.Windows.Forms.TextBox();
			this.lblTim = new global::System.Windows.Forms.Label();
			this.tabControl3 = new global::System.Windows.Forms.TabControl();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.txtTong = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtThanhTienGio = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtGiamGiaGio = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtThanhTienHang = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtGiamGiaHang = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtTienGio = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtTienHang = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.btnThongKe = new global::System.Windows.Forms.Button();
			this.btnThanhToan = new global::System.Windows.Forms.Button();
			this.btnInCheBien = new global::System.Windows.Forms.Button();
			this.btnGiamGia = new global::System.Windows.Forms.Button();
			this.dgvMenu = new global::System.Windows.Forms.DataGridView();
			this.btnChietKhau = new global::System.Windows.Forms.Button();
			this.btnGhiChu = new global::System.Windows.Forms.Button();
			this.btnDoiGia = new global::System.Windows.Forms.Button();
			this.btnDatSL = new global::System.Windows.Forms.Button();
			this.btnGiam = new global::System.Windows.Forms.Button();
			this.btnTang = new global::System.Windows.Forms.Button();
			this.btnXoa = new global::System.Windows.Forms.Button();
			this.btnGiamHang = new global::System.Windows.Forms.Button();
			this.btnThemHang = new global::System.Windows.Forms.Button();
			this.cbSoLuong = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.btnGopPhong = new global::System.Windows.Forms.Button();
			this.btnChuyenPhong = new global::System.Windows.Forms.Button();
			this.txtSoKhachSDDV = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtSoPhieuSDDV = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtCMND = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtDiaChi = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtDienThoai = new global::System.Windows.Forms.TextBox();
			this.lblDienThoai = new global::System.Windows.Forms.Label();
			this.lblTenKhach = new global::System.Windows.Forms.Label();
			this.cbKhachHang = new global::System.Windows.Forms.ComboBox();
			this.lblKhachHang = new global::System.Windows.Forms.Label();
			this.lblSoPhong = new global::System.Windows.Forms.Label();
			this.lblSoPhut = new global::System.Windows.Forms.Label();
			this.btnBegin = new global::System.Windows.Forms.Button();
			this.tabControlSuDungDichVu = new global::System.Windows.Forms.TabControl();
			this.menuStripSuDungDichVu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmPhongBan = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmBaoDon = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmDonXong = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmMoPhong = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmMoPhongTuDatTruoc = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmThanhToan = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmRefreshService = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmChuyenPhong = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmGopPhong = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmHuyHoaDon = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabQuanLyBanHang = new global::System.Windows.Forms.TabPage();
			this.dateTimePicker1 = new global::System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new global::System.Windows.Forms.DateTimePicker();
			this.dateTimePicker3 = new global::System.Windows.Forms.DateTimePicker();
			this.label32 = new global::System.Windows.Forms.Label();
			this.label33 = new global::System.Windows.Forms.Label();
			this.label34 = new global::System.Windows.Forms.Label();
			this.btnHuyPhieu = new global::System.Windows.Forms.Button();
			this.dtgViewMenuQLBH = new global::System.Windows.Forms.DataGridView();
			this.lstViewQLBH = new global::System.Windows.Forms.ListView();
			this.txtTimKiemQLBH = new global::System.Windows.Forms.TextBox();
			this.label23 = new global::System.Windows.Forms.Label();
			this.tabControl4 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.txtTongQLBH = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.txtThanhTienGioQLBH = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.txtGiamGiaGioQLBH = new global::System.Windows.Forms.TextBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.txtThanhTienQLBH = new global::System.Windows.Forms.TextBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.txtGiamGia = new global::System.Windows.Forms.TextBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.txtTienGioQLBH = new global::System.Windows.Forms.TextBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.txtTienHangQLBH = new global::System.Windows.Forms.TextBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.txtGhiChuQLBH = new global::System.Windows.Forms.TextBox();
			this.btnThanhToanQLBH = new global::System.Windows.Forms.Button();
			this.btnInLaiBill = new global::System.Windows.Forms.Button();
			this.btnCKQLBH = new global::System.Windows.Forms.Button();
			this.dataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.btnChietKhauQLBH = new global::System.Windows.Forms.Button();
			this.btnGhiChuQLBH = new global::System.Windows.Forms.Button();
			this.btnDoiGiaQLBH = new global::System.Windows.Forms.Button();
			this.btnDatSLQLBH = new global::System.Windows.Forms.Button();
			this.btnGiamQLBH = new global::System.Windows.Forms.Button();
			this.btnTangQLBH = new global::System.Windows.Forms.Button();
			this.btnBangGiaQLBH = new global::System.Windows.Forms.Button();
			this.btnXoaQLBH = new global::System.Windows.Forms.Button();
			this.btnGiamHangQLBH = new global::System.Windows.Forms.Button();
			this.btnThemQLBH = new global::System.Windows.Forms.Button();
			this.cbSLQLBH = new global::System.Windows.Forms.ComboBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.txtSoKhach = new global::System.Windows.Forms.TextBox();
			this.txtSoPhieu = new global::System.Windows.Forms.TextBox();
			this.txtCMNDQLBH = new global::System.Windows.Forms.TextBox();
			this.label25 = new global::System.Windows.Forms.Label();
			this.txtDiaChiQLBH = new global::System.Windows.Forms.TextBox();
			this.label26 = new global::System.Windows.Forms.Label();
			this.txtDienThoaiQLBH = new global::System.Windows.Forms.TextBox();
			this.label27 = new global::System.Windows.Forms.Label();
			this.txtTenKhachQLBH = new global::System.Windows.Forms.TextBox();
			this.label28 = new global::System.Windows.Forms.Label();
			this.cbKhachHangQLBH = new global::System.Windows.Forms.ComboBox();
			this.label29 = new global::System.Windows.Forms.Label();
			this.lblSoPhongQLBH = new global::System.Windows.Forms.Label();
			this.lblKhachHangQLBH = new global::System.Windows.Forms.Label();
			this.btnBeginQLBH = new global::System.Windows.Forms.Button();
			this.btnTaiDuLieu = new global::System.Windows.Forms.Button();
			this.cbChonNgay = new global::System.Windows.Forms.ComboBox();
			this.cbNgayThang2 = new global::System.Windows.Forms.ComboBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.cbNgayThang1 = new global::System.Windows.Forms.ComboBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.dgvQuanLyBanHang = new global::System.Windows.Forms.DataGridView();
			this.tabDanhMucMatHang = new global::System.Windows.Forms.TabPage();
			this.tabControl6 = new global::System.Windows.Forms.TabControl();
			this.tabPage7 = new global::System.Windows.Forms.TabPage();
			this.dgvMenuDMMH = new global::System.Windows.Forms.DataGridView();
			this.btnInMaVachDMMH = new global::System.Windows.Forms.Button();
			this.btnInDMMH = new global::System.Windows.Forms.Button();
			this.btnNhapDLDMMH = new global::System.Windows.Forms.Button();
			this.btnXuatExcelDMMH = new global::System.Windows.Forms.Button();
			this.btnThemExcelDMMH = new global::System.Windows.Forms.Button();
			this.btnXoaDMMH = new global::System.Windows.Forms.Button();
			this.btnChinhSuaDMMH = new global::System.Windows.Forms.Button();
			this.btnThemMoiDMMH = new global::System.Windows.Forms.Button();
			this.txtFilter = new global::System.Windows.Forms.TextBox();
			this.btnLocDMMH = new global::System.Windows.Forms.Button();
			this.tabControl5 = new global::System.Windows.Forms.TabControl();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.btnDelDMMH = new global::System.Windows.Forms.Button();
			this.lstViewDMMH = new global::System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmEditItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmDel = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmRefresh = new global::System.Windows.Forms.ToolStripMenuItem();
			this.btnCaiDat = new global::System.Windows.Forms.Button();
			this.btnLoadDMMH = new global::System.Windows.Forms.Button();
			this.btnEditDMMH = new global::System.Windows.Forms.Button();
			this.btnAddDMMH = new global::System.Windows.Forms.Button();
			this.tabDanhMucBanKhuVuc = new global::System.Windows.Forms.TabPage();
			this.tabControl9 = new global::System.Windows.Forms.TabControl();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.dgvBanKhuVuc = new global::System.Windows.Forms.DataGridView();
			this.btnTableSum = new global::System.Windows.Forms.Button();
			this.btnTableIn = new global::System.Windows.Forms.Button();
			this.btnXuatExcel = new global::System.Windows.Forms.Button();
			this.btnTableThemExcel = new global::System.Windows.Forms.Button();
			this.btnTableXoa = new global::System.Windows.Forms.Button();
			this.btnTableChinhSua = new global::System.Windows.Forms.Button();
			this.btnTableThemMoi = new global::System.Windows.Forms.Button();
			this.txtTableLoc = new global::System.Windows.Forms.TextBox();
			this.btnTableLoc = new global::System.Windows.Forms.Button();
			this.tabControl8 = new global::System.Windows.Forms.TabControl();
			this.tabPage10 = new global::System.Windows.Forms.TabPage();
			this.btnAreaXoa = new global::System.Windows.Forms.Button();
			this.lstViewBanKhuVuc = new global::System.Windows.Forms.ListView();
			this.btnAreaCaiDat = new global::System.Windows.Forms.Button();
			this.btnAreaTaiDuLieu = new global::System.Windows.Forms.Button();
			this.btnAreaChinhSua = new global::System.Windows.Forms.Button();
			this.btnAreaThemMoi = new global::System.Windows.Forms.Button();
			this.tabDanhMucKhachHang = new global::System.Windows.Forms.TabPage();
			this.tabControlKhachHang = new global::System.Windows.Forms.TabControl();
			this.tabPage13 = new global::System.Windows.Forms.TabPage();
			this.dgvKhachHang = new global::System.Windows.Forms.DataGridView();
			this.btnKhachHangPrint = new global::System.Windows.Forms.Button();
			this.btnKhachHangExportExcel = new global::System.Windows.Forms.Button();
			this.btnKhachHangImportExcel = new global::System.Windows.Forms.Button();
			this.btnKhachHangDel = new global::System.Windows.Forms.Button();
			this.btnKhachHangEdit = new global::System.Windows.Forms.Button();
			this.btnKhachHangAdd = new global::System.Windows.Forms.Button();
			this.txtKhachHangFilter = new global::System.Windows.Forms.TextBox();
			this.btnKhachHangFilter = new global::System.Windows.Forms.Button();
			this.tabControlNhomKhachHang = new global::System.Windows.Forms.TabControl();
			this.tabPageNhomKhachHang = new global::System.Windows.Forms.TabPage();
			this.btnNhomKhachHangDel = new global::System.Windows.Forms.Button();
			this.lstViewNhomKhachHang = new global::System.Windows.Forms.ListView();
			this.btnNhomKhachHangSetting = new global::System.Windows.Forms.Button();
			this.btnNhomKhachHangLoad = new global::System.Windows.Forms.Button();
			this.btnNhomKhachHangEdit = new global::System.Windows.Forms.Button();
			this.btnNhomKhachHangAdd = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.imgLstDMMH = new global::System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmCloseTab = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imgListIcon = new global::System.Windows.Forms.ImageList(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabSuDungDichVu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvViewMenu).BeginInit();
			this.tabControl3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvMenu).BeginInit();
			this.menuStripSuDungDichVu.SuspendLayout();
			this.tabQuanLyBanHang.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgViewMenuQLBH).BeginInit();
			this.tabControl4.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvQuanLyBanHang).BeginInit();
			this.tabDanhMucMatHang.SuspendLayout();
			this.tabControl6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvMenuDMMH).BeginInit();
			this.tabControl5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabDanhMucBanKhuVuc.SuspendLayout();
			this.tabControl9.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBanKhuVuc).BeginInit();
			this.tabControl8.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabDanhMucKhachHang.SuspendLayout();
			this.tabControlKhachHang.SuspendLayout();
			this.tabPage13.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvKhachHang).BeginInit();
			this.tabControlNhomKhachHang.SuspendLayout();
			this.tabPageNhomKhachHang.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.menuStrip1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.hệThốngToolStripMenuItem,
				this.hoạtĐộngToolStripMenuItem,
				this.mnCustomer,
				this.mnStock,
				this.côngNợToolStripMenuItem,
				this.mnListReasonImportExport,
				this.nhânSựToolStripMenuItem,
				this.quảnTrịToolStripMenuItem,
				this.báoCáoToolStripMenuItem,
				this.trợGiúpToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuStrip1.Size = new global::System.Drawing.Size(1167, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnChangPassword,
				this.mnLogout,
				this.mnExit
			});
			this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			this.hệThốngToolStripMenuItem.Size = new global::System.Drawing.Size(85, 27);
			this.hệThốngToolStripMenuItem.Text = "HỆ THỐNG";
			this.mnChangPassword.Name = "mnChangPassword";
			this.mnChangPassword.Size = new global::System.Drawing.Size(220, 22);
			this.mnChangPassword.Text = "Đổi mật khẩu đăng nhập";
			this.mnChangPassword.Click += new global::System.EventHandler(this.mnChangPassword_Click);
			this.mnLogout.Name = "mnLogout";
			this.mnLogout.Size = new global::System.Drawing.Size(220, 22);
			this.mnLogout.Text = "Đăng xuất khỏi hệ thống";
			this.mnLogout.Click += new global::System.EventHandler(this.mnLogout_Click);
			this.mnExit.Name = "mnExit";
			this.mnExit.Size = new global::System.Drawing.Size(220, 22);
			this.mnExit.Text = "Thoát khỏi hệ thống";
			this.mnExit.Click += new global::System.EventHandler(this.mnExit_Click);
			this.hoạtĐộngToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnListMenu,
				this.mnListItems,
				this.mnListTypeRoom,
				this.mbListTableArea,
				this.mnNoticeRepair,
				this.mnUsedService,
				this.mnModifyTicket,
				this.mnManagementSales,
				this.mnSaveActive,
				this.mnRevenueStatistics,
				this.mnItemsSaleStatistics,
				this.mnSummaryResultSale,
				this.mnDetailDaily,
				this.mnListDestroyTicket
			});
			this.hoạtĐộngToolStripMenuItem.Name = "hoạtĐộngToolStripMenuItem";
			this.hoạtĐộngToolStripMenuItem.Size = new global::System.Drawing.Size(96, 27);
			this.hoạtĐộngToolStripMenuItem.Text = "HOẠT ĐỘNG";
			this.mnListMenu.Name = "mnListMenu";
			this.mnListMenu.Size = new global::System.Drawing.Size(248, 22);
			this.mnListMenu.Text = "Danh mục bảng giá";
			this.mnListMenu.Click += new global::System.EventHandler(this.mnListMenu_Click);
			this.mnListItems.Name = "mnListItems";
			this.mnListItems.Size = new global::System.Drawing.Size(248, 22);
			this.mnListItems.Text = "Danh mục mặt hàng";
			this.mnListItems.Click += new global::System.EventHandler(this.mnListItems_Click);
			this.mnListTypeRoom.Name = "mnListTypeRoom";
			this.mnListTypeRoom.Size = new global::System.Drawing.Size(248, 22);
			this.mnListTypeRoom.Text = "Danh mục loại phòng";
			this.mnListTypeRoom.Click += new global::System.EventHandler(this.mnListTypeRoom_Click);
			this.mbListTableArea.Name = "mbListTableArea";
			this.mbListTableArea.Size = new global::System.Drawing.Size(248, 22);
			this.mbListTableArea.Text = "Danh mục bàn khu vực";
			this.mbListTableArea.Click += new global::System.EventHandler(this.mbListTableArea_Click);
			this.mnNoticeRepair.Name = "mnNoticeRepair";
			this.mnNoticeRepair.Size = new global::System.Drawing.Size(248, 22);
			this.mnNoticeRepair.Text = "Thông báo sửa chữa";
			this.mnUsedService.Name = "mnUsedService";
			this.mnUsedService.Size = new global::System.Drawing.Size(248, 22);
			this.mnUsedService.Text = "Sử dụng dịch vụ";
			this.mnUsedService.Click += new global::System.EventHandler(this.mnUsedService_Click);
			this.mnModifyTicket.Name = "mnModifyTicket";
			this.mnModifyTicket.Size = new global::System.Drawing.Size(248, 22);
			this.mnModifyTicket.Text = "Điều chỉnh hóa đơn";
			this.mnManagementSales.Name = "mnManagementSales";
			this.mnManagementSales.Size = new global::System.Drawing.Size(248, 22);
			this.mnManagementSales.Text = "Quản lý bán hàng";
			this.mnManagementSales.Click += new global::System.EventHandler(this.mnManagementSales_Click);
			this.mnSaveActive.Name = "mnSaveActive";
			this.mnSaveActive.Size = new global::System.Drawing.Size(248, 22);
			this.mnSaveActive.Text = "Lưu vết hoạt động";
			this.mnRevenueStatistics.Name = "mnRevenueStatistics";
			this.mnRevenueStatistics.Size = new global::System.Drawing.Size(248, 22);
			this.mnRevenueStatistics.Text = "Thống kê doanh thu";
			this.mnItemsSaleStatistics.Name = "mnItemsSaleStatistics";
			this.mnItemsSaleStatistics.Size = new global::System.Drawing.Size(248, 22);
			this.mnItemsSaleStatistics.Text = "Thống kê mặt hàng bán";
			this.mnSummaryResultSale.Name = "mnSummaryResultSale";
			this.mnSummaryResultSale.Size = new global::System.Drawing.Size(248, 22);
			this.mnSummaryResultSale.Text = "Tổng hợp kết quả kinh doanh";
			this.mnDetailDaily.Name = "mnDetailDaily";
			this.mnDetailDaily.Size = new global::System.Drawing.Size(248, 22);
			this.mnDetailDaily.Text = "Chi tiết hoạt động ngày";
			this.mnListDestroyTicket.Name = "mnListDestroyTicket";
			this.mnListDestroyTicket.Size = new global::System.Drawing.Size(248, 22);
			this.mnListDestroyTicket.Text = "Doanh mục hóa đơn hủy";
			this.mnCustomer.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnListCustomer,
				this.mnSendMsgToCustomer,
				this.mnCustomerVip
			});
			this.mnCustomer.Name = "mnCustomer";
			this.mnCustomer.Size = new global::System.Drawing.Size(102, 27);
			this.mnCustomer.Text = "KHÁCH HÀNG";
			this.mnListCustomer.Name = "mnListCustomer";
			this.mnListCustomer.Size = new global::System.Drawing.Size(235, 22);
			this.mnListCustomer.Text = "Danh mục khách hàng";
			this.mnListCustomer.Click += new global::System.EventHandler(this.mnListCustomer_Click);
			this.mnSendMsgToCustomer.Name = "mnSendMsgToCustomer";
			this.mnSendMsgToCustomer.Size = new global::System.Drawing.Size(235, 22);
			this.mnSendMsgToCustomer.Text = "Gửi tin nhắn tới khách hàng";
			this.mnCustomerVip.Name = "mnCustomerVip";
			this.mnCustomerVip.Size = new global::System.Drawing.Size(235, 22);
			this.mnCustomerVip.Text = "Khách hàng thân thiết";
			this.mnStock.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnListVendor,
				this.mnImportStock
			});
			this.mnStock.Name = "mnStock";
			this.mnStock.Size = new global::System.Drawing.Size(87, 27);
			this.mnStock.Text = "KHO HÀNG";
			this.mnListVendor.Name = "mnListVendor";
			this.mnListVendor.Size = new global::System.Drawing.Size(216, 22);
			this.mnListVendor.Text = "Danh mục nhà cung cấp";
			this.mnImportStock.Name = "mnImportStock";
			this.mnImportStock.Size = new global::System.Drawing.Size(216, 22);
			this.mnImportStock.Text = "Nhập hàng vào kho";
			this.côngNợToolStripMenuItem.Name = "côngNợToolStripMenuItem";
			this.côngNợToolStripMenuItem.Size = new global::System.Drawing.Size(81, 27);
			this.côngNợToolStripMenuItem.Text = "CÔNG NỢ";
			this.mnListReasonImportExport.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.lýDoThuChiToolStripMenuItem,
				this.mnListAccountBank,
				this.mnCreatTicketImport,
				this.mnCreateTicketExport,
				this.mnListTicketImport,
				this.mnListTicketExport,
				this.mnExist
			});
			this.mnListReasonImportExport.Name = "mnListReasonImportExport";
			this.mnListReasonImportExport.Size = new global::System.Drawing.Size(46, 27);
			this.mnListReasonImportExport.Text = "QUỸ";
			this.lýDoThuChiToolStripMenuItem.Name = "lýDoThuChiToolStripMenuItem";
			this.lýDoThuChiToolStripMenuItem.Size = new global::System.Drawing.Size(257, 22);
			this.lýDoThuChiToolStripMenuItem.Text = "Danh mục lý do thu chi";
			this.mnListAccountBank.Name = "mnListAccountBank";
			this.mnListAccountBank.Size = new global::System.Drawing.Size(257, 22);
			this.mnListAccountBank.Text = "Danh mục tài khoản ngân hàng";
			this.mnCreatTicketImport.Name = "mnCreatTicketImport";
			this.mnCreatTicketImport.Size = new global::System.Drawing.Size(257, 22);
			this.mnCreatTicketImport.Text = "Tạo phiếu thu";
			this.mnCreateTicketExport.Name = "mnCreateTicketExport";
			this.mnCreateTicketExport.Size = new global::System.Drawing.Size(257, 22);
			this.mnCreateTicketExport.Text = "Tạo phiếu chi";
			this.mnListTicketImport.Name = "mnListTicketImport";
			this.mnListTicketImport.Size = new global::System.Drawing.Size(257, 22);
			this.mnListTicketImport.Text = "Danh mục phiếu thu";
			this.mnListTicketExport.Name = "mnListTicketExport";
			this.mnListTicketExport.Size = new global::System.Drawing.Size(257, 22);
			this.mnListTicketExport.Text = "Danh mục phiếu chi";
			this.mnExist.Name = "mnExist";
			this.mnExist.Size = new global::System.Drawing.Size(257, 22);
			this.mnExist.Text = "Tồn quỹ";
			this.nhânSựToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnListEmployes,
				this.mnListShiftWorking,
				this.tạmỨngLươngToolStripMenuItem,
				this.thưởngPhạtToolStripMenuItem,
				this.chấmCôngToolStripMenuItem,
				this.tínhLươngToolStripMenuItem
			});
			this.nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
			this.nhânSựToolStripMenuItem.Size = new global::System.Drawing.Size(77, 27);
			this.nhânSựToolStripMenuItem.Text = "NHÂN SỰ";
			this.mnListEmployes.Name = "mnListEmployes";
			this.mnListEmployes.Size = new global::System.Drawing.Size(202, 22);
			this.mnListEmployes.Text = "Danh mục nhân viên";
			this.mnListShiftWorking.Name = "mnListShiftWorking";
			this.mnListShiftWorking.Size = new global::System.Drawing.Size(202, 22);
			this.mnListShiftWorking.Text = "Danh mục ca làm việc";
			this.tạmỨngLươngToolStripMenuItem.Name = "tạmỨngLươngToolStripMenuItem";
			this.tạmỨngLươngToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.tạmỨngLươngToolStripMenuItem.Text = "Tạm ứng lương";
			this.thưởngPhạtToolStripMenuItem.Name = "thưởngPhạtToolStripMenuItem";
			this.thưởngPhạtToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.thưởngPhạtToolStripMenuItem.Text = "Thưởng phạt";
			this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
			this.chấmCôngToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.chấmCôngToolStripMenuItem.Text = "Chấm công";
			this.tínhLươngToolStripMenuItem.Name = "tínhLươngToolStripMenuItem";
			this.tínhLươngToolStripMenuItem.Size = new global::System.Drawing.Size(202, 22);
			this.tínhLươngToolStripMenuItem.Text = "Tính lương";
			this.quảnTrịToolStripMenuItem.Name = "quảnTrịToolStripMenuItem";
			this.quảnTrịToolStripMenuItem.Size = new global::System.Drawing.Size(79, 27);
			this.quảnTrịToolStripMenuItem.Text = "QUẢN TRỊ";
			this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.báoCáoQuỹToolStripMenuItem,
				this.báoCáoDanhMụcToolStripMenuItem,
				this.báoCáoBánHàngToolStripMenuItem,
				this.báoCáoĐặtHàngToolStripMenuItem,
				this.báoCáoKhoHàngToolStripMenuItem,
				this.báoCáoCôngNợToolStripMenuItem,
				this.báoCáoQuảnTrịToolStripMenuItem,
				this.báoCáoBiểuĐồToolStripMenuItem
			});
			this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
			this.báoCáoToolStripMenuItem.Size = new global::System.Drawing.Size(75, 27);
			this.báoCáoToolStripMenuItem.Text = "BÁO CÁO";
			this.báoCáoQuỹToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.danhSáchPhiếuThuTheoNgàyToolStripMenuItem,
				this.danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem,
				this.danhSáchPhiếuChiTheoNgàyToolStripMenuItem,
				this.danhSáchPhiếuChiTheoToolStripMenuItem,
				this.tổngHợpThuChiTheoNgàyToolStripMenuItem,
				this.tổngHợpThuChiTheoLýDoToolStripMenuItem,
				this.báoCáoTồnQuỹToolStripMenuItem
			});
			this.báoCáoQuỹToolStripMenuItem.Name = "báoCáoQuỹToolStripMenuItem";
			this.báoCáoQuỹToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoQuỹToolStripMenuItem.Text = "Báo cáo quỹ";
			this.danhSáchPhiếuThuTheoNgàyToolStripMenuItem.Name = "danhSáchPhiếuThuTheoNgàyToolStripMenuItem";
			this.danhSáchPhiếuThuTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.danhSáchPhiếuThuTheoNgàyToolStripMenuItem.Text = "Danh sách phiếu thu theo ngày";
			this.danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem.Name = "danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem";
			this.danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem.Text = "Danh sách phiếu thu theo lý do thu chi";
			this.danhSáchPhiếuChiTheoNgàyToolStripMenuItem.Name = "danhSáchPhiếuChiTheoNgàyToolStripMenuItem";
			this.danhSáchPhiếuChiTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.danhSáchPhiếuChiTheoNgàyToolStripMenuItem.Text = "Danh sách phiếu chi theo ngày";
			this.danhSáchPhiếuChiTheoToolStripMenuItem.Name = "danhSáchPhiếuChiTheoToolStripMenuItem";
			this.danhSáchPhiếuChiTheoToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.danhSáchPhiếuChiTheoToolStripMenuItem.Text = "Danh sách phiếu chi theo lý do thu chi ";
			this.tổngHợpThuChiTheoNgàyToolStripMenuItem.Name = "tổngHợpThuChiTheoNgàyToolStripMenuItem";
			this.tổngHợpThuChiTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.tổngHợpThuChiTheoNgàyToolStripMenuItem.Text = "Tổng hợp thu chi theo ngày";
			this.tổngHợpThuChiTheoLýDoToolStripMenuItem.Name = "tổngHợpThuChiTheoLýDoToolStripMenuItem";
			this.tổngHợpThuChiTheoLýDoToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.tổngHợpThuChiTheoLýDoToolStripMenuItem.Text = "Tổng hợp thu chi theo lý do";
			this.báoCáoTồnQuỹToolStripMenuItem.Name = "báoCáoTồnQuỹToolStripMenuItem";
			this.báoCáoTồnQuỹToolStripMenuItem.Size = new global::System.Drawing.Size(301, 22);
			this.báoCáoTồnQuỹToolStripMenuItem.Text = "Báo cáo tồn quỹ";
			this.báoCáoDanhMụcToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.danhSáchKháchHàngTheoNhómToolStripMenuItem,
				this.danhSáchKháchHàngTheoNhânViênToolStripMenuItem,
				this.danhSáchNhàCungCấpTheoNhómToolStripMenuItem,
				this.danhSáchĐợtKhuyếnMãiToolStripMenuItem,
				this.danhSáchMặtHàngTheoNhómToolStripMenuItem,
				this.danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem,
				this.kháchHàngĐếnNgàySinhNhậtToolStripMenuItem,
				this.báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem,
				this.côngThứcĐịnhLươnhjToolStripMenuItem,
				this.báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem
			});
			this.báoCáoDanhMụcToolStripMenuItem.Name = "báoCáoDanhMụcToolStripMenuItem";
			this.báoCáoDanhMụcToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoDanhMụcToolStripMenuItem.Text = "Báo cáo danh mục";
			this.danhSáchKháchHàngTheoNhómToolStripMenuItem.Name = "danhSáchKháchHàngTheoNhómToolStripMenuItem";
			this.danhSáchKháchHàngTheoNhómToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchKháchHàngTheoNhómToolStripMenuItem.Text = "Danh sách khách hàng theo nhóm";
			this.danhSáchKháchHàngTheoNhânViênToolStripMenuItem.Name = "danhSáchKháchHàngTheoNhânViênToolStripMenuItem";
			this.danhSáchKháchHàngTheoNhânViênToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchKháchHàngTheoNhânViênToolStripMenuItem.Text = "Danh sách khách hàng theo nhân viên";
			this.danhSáchNhàCungCấpTheoNhómToolStripMenuItem.Name = "danhSáchNhàCungCấpTheoNhómToolStripMenuItem";
			this.danhSáchNhàCungCấpTheoNhómToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchNhàCungCấpTheoNhómToolStripMenuItem.Text = "Danh sách nhà cung cấp theo nhóm";
			this.danhSáchĐợtKhuyếnMãiToolStripMenuItem.Name = "danhSáchĐợtKhuyếnMãiToolStripMenuItem";
			this.danhSáchĐợtKhuyếnMãiToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchĐợtKhuyếnMãiToolStripMenuItem.Text = "Danh sách đợt khuyến mại";
			this.danhSáchMặtHàngTheoNhómToolStripMenuItem.Name = "danhSáchMặtHàngTheoNhómToolStripMenuItem";
			this.danhSáchMặtHàngTheoNhómToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchMặtHàngTheoNhómToolStripMenuItem.Text = "Danh sách mặt hàng theo nhóm";
			this.danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem.Name = "danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem";
			this.danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem.Text = "Danh sách mặt hàng theo hãng sản xuất";
			this.kháchHàngĐếnNgàySinhNhậtToolStripMenuItem.Name = "kháchHàngĐếnNgàySinhNhậtToolStripMenuItem";
			this.kháchHàngĐếnNgàySinhNhậtToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.kháchHàngĐếnNgàySinhNhậtToolStripMenuItem.Text = "Khách hàng đến ngày sinh nhật";
			this.báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem.Name = "báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem";
			this.báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem.Text = "Báo cáo khách hàng theo bàn khu vực";
			this.côngThứcĐịnhLươnhjToolStripMenuItem.Name = "côngThứcĐịnhLươnhjToolStripMenuItem";
			this.côngThứcĐịnhLươnhjToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.côngThứcĐịnhLươnhjToolStripMenuItem.Text = "Công thức định lượng";
			this.báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem.Name = "báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem";
			this.báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem.Size = new global::System.Drawing.Size(310, 22);
			this.báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem.Text = "Báo cáo chi tiết phân quyền hệ thống";
			this.báoCáoBánHàngToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpBánHàngTheoNgàyToolStripMenuItem,
				this.tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem,
				this.báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem,
				this.tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem,
				this.tổngHợpDoanhThuChưaThanhToánToolStripMenuItem,
				this.báoCáoBánHàngTheoNgàyToolStripMenuItem,
				this.theoNhânViênPhụcVụToolStripMenuItem,
				this.theoKhuVựcToolStripMenuItem,
				this.theoThuNgânToolStripMenuItem,
				this.theoKháchHàngToolStripMenuItem,
				this.báoCáoBánHàngKhácToolStripMenuItem
			});
			this.báoCáoBánHàngToolStripMenuItem.Name = "báoCáoBánHàngToolStripMenuItem";
			this.báoCáoBánHàngToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoBánHàngToolStripMenuItem.Text = "Báo cáo bán hàng";
			this.tổngHợpBánHàngTheoNgàyToolStripMenuItem.Name = "tổngHợpBánHàngTheoNgàyToolStripMenuItem";
			this.tổngHợpBánHàngTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.tổngHợpBánHàngTheoNgàyToolStripMenuItem.Text = "Tổng hợp bán hàng theo ngày";
			this.tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo ngày";
			this.báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem.Name = "báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem";
			this.báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem.Text = "Báo cáo chi tiết bán hàng theo ngày";
			this.tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem.Name = "tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem";
			this.tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem.Text = "Tổng hợp doanh thu theo loại đồ";
			this.tổngHợpDoanhThuChưaThanhToánToolStripMenuItem.Name = "tổngHợpDoanhThuChưaThanhToánToolStripMenuItem";
			this.tổngHợpDoanhThuChưaThanhToánToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.tổngHợpDoanhThuChưaThanhToánToolStripMenuItem.Text = "Tổng hợp doanh thu chưa thanh toán";
			this.báoCáoBánHàngTheoNgàyToolStripMenuItem.Name = "báoCáoBánHàngTheoNgàyToolStripMenuItem";
			this.báoCáoBánHàngTheoNgàyToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.báoCáoBánHàngTheoNgàyToolStripMenuItem.Text = "Báo cáo bán hàng theo ngày";
			this.theoNhânViênPhụcVụToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpBánTheoNhânViênToolStripMenuItem,
				this.tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem,
				this.báoCáoBánHàngTheoNhânViênToolStripMenuItem
			});
			this.theoNhânViênPhụcVụToolStripMenuItem.Name = "theoNhânViênPhụcVụToolStripMenuItem";
			this.theoNhânViênPhụcVụToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.theoNhânViênPhụcVụToolStripMenuItem.Text = "Theo nhân viên phục vụ";
			this.tổngHợpBánTheoNhânViênToolStripMenuItem.Name = "tổngHợpBánTheoNhânViênToolStripMenuItem";
			this.tổngHợpBánTheoNhânViênToolStripMenuItem.Size = new global::System.Drawing.Size(307, 22);
			this.tổngHợpBánTheoNhânViênToolStripMenuItem.Text = "Tổng hợp bán theo nhân viên";
			this.tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem.Size = new global::System.Drawing.Size(307, 22);
			this.tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo nhân viên";
			this.báoCáoBánHàngTheoNhânViênToolStripMenuItem.Name = "báoCáoBánHàngTheoNhânViênToolStripMenuItem";
			this.báoCáoBánHàngTheoNhânViênToolStripMenuItem.Size = new global::System.Drawing.Size(307, 22);
			this.báoCáoBánHàngTheoNhânViênToolStripMenuItem.Text = "Báo cáo bán hàng theo nhân viên";
			this.theoKhuVựcToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpBánHàngTheoKhuVựcToolStripMenuItem,
				this.tổngHợpBánHàngTheoBànPhòngToolStripMenuItem,
				this.danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem,
				this.danhSáchHóaĐơnTheoBànToolStripMenuItem,
				this.tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem,
				this.tổngHợpMặtHàngBánTheoBànToolStripMenuItem,
				this.tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem,
				this.danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem,
				this.tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem
			});
			this.theoKhuVựcToolStripMenuItem.Name = "theoKhuVựcToolStripMenuItem";
			this.theoKhuVựcToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.theoKhuVựcToolStripMenuItem.Text = "Theo khu vực";
			this.tổngHợpBánHàngTheoKhuVựcToolStripMenuItem.Name = "tổngHợpBánHàngTheoKhuVựcToolStripMenuItem";
			this.tổngHợpBánHàngTheoKhuVựcToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpBánHàngTheoKhuVựcToolStripMenuItem.Text = "Tổng hợp bán hàng theo khu vực";
			this.tổngHợpBánHàngTheoBànPhòngToolStripMenuItem.Name = "tổngHợpBánHàngTheoBànPhòngToolStripMenuItem";
			this.tổngHợpBánHàngTheoBànPhòngToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpBánHàngTheoBànPhòngToolStripMenuItem.Text = "Tổng hợp bán hàng theo bàn phòng";
			this.danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem.Name = "danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem";
			this.danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem.Text = "Danh sách hóa đơn theo khu vực";
			this.danhSáchHóaĐơnTheoBànToolStripMenuItem.Name = "danhSáchHóaĐơnTheoBànToolStripMenuItem";
			this.danhSáchHóaĐơnTheoBànToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.danhSáchHóaĐơnTheoBànToolStripMenuItem.Text = "Danh sách hóa đơn theo bàn";
			this.tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo khu vực";
			this.tổngHợpMặtHàngBánTheoBànToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoBànToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoBànToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpMặtHàngBánTheoBànToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo bàn";
			this.tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem.Name = "tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem";
			this.tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem.Text = "Tổng hợp bán hàng theo nhóm hiển thị";
			this.danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem.Name = "danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem";
			this.danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem.Text = "Danh sách hóa đơn theo nhóm hiển thị";
			this.tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem.Name = "tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem";
			this.tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem.Size = new global::System.Drawing.Size(305, 22);
			this.tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem.Text = "Tổng hợp mặt hàng theo nhóm hiển thị";
			this.theoThuNgânToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpBánTheoThuNgânToolStripMenuItem,
				this.báoCáoBánHàngTheoThuNgânToolStripMenuItem,
				this.tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem
			});
			this.theoThuNgânToolStripMenuItem.Name = "theoThuNgânToolStripMenuItem";
			this.theoThuNgânToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.theoThuNgânToolStripMenuItem.Text = "Theo thu ngân";
			this.tổngHợpBánTheoThuNgânToolStripMenuItem.Name = "tổngHợpBánTheoThuNgânToolStripMenuItem";
			this.tổngHợpBánTheoThuNgânToolStripMenuItem.Size = new global::System.Drawing.Size(303, 22);
			this.tổngHợpBánTheoThuNgânToolStripMenuItem.Text = "Tổng hợp bán theo thu ngân";
			this.báoCáoBánHàngTheoThuNgânToolStripMenuItem.Name = "báoCáoBánHàngTheoThuNgânToolStripMenuItem";
			this.báoCáoBánHàngTheoThuNgânToolStripMenuItem.Size = new global::System.Drawing.Size(303, 22);
			this.báoCáoBánHàngTheoThuNgânToolStripMenuItem.Text = "Báo cáo bán hàng theo thu ngân";
			this.tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem.Size = new global::System.Drawing.Size(303, 22);
			this.tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo thu ngân";
			this.theoKháchHàngToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem,
				this.tổngHợpBánTheoKháchHàngToolStripMenuItem,
				this.báoCáoBánTheoKháchHàngToolStripMenuItem
			});
			this.theoKháchHàngToolStripMenuItem.Name = "theoKháchHàngToolStripMenuItem";
			this.theoKháchHàngToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.theoKháchHàngToolStripMenuItem.Text = "Theo khách hàng";
			this.tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem.Name = "tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem";
			this.tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem.Size = new global::System.Drawing.Size(318, 22);
			this.tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem.Text = "Tổng hợp mặt hàng bán theo khách hàng";
			this.tổngHợpBánTheoKháchHàngToolStripMenuItem.Name = "tổngHợpBánTheoKháchHàngToolStripMenuItem";
			this.tổngHợpBánTheoKháchHàngToolStripMenuItem.Size = new global::System.Drawing.Size(318, 22);
			this.tổngHợpBánTheoKháchHàngToolStripMenuItem.Text = "Tổng hợp bán theo khách hàng";
			this.báoCáoBánTheoKháchHàngToolStripMenuItem.Name = "báoCáoBánTheoKháchHàngToolStripMenuItem";
			this.báoCáoBánTheoKháchHàngToolStripMenuItem.Size = new global::System.Drawing.Size(318, 22);
			this.báoCáoBánTheoKháchHàngToolStripMenuItem.Text = "Báo cáo bán hàng theo khách hàng";
			this.báoCáoBánHàngKhácToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tổngHợpHoaHồngTheoNVKDToolStripMenuItem,
				this.chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem,
				this.báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem,
				this.báoToolStripMenuItem,
				this.báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem
			});
			this.báoCáoBánHàngKhácToolStripMenuItem.Name = "báoCáoBánHàngKhácToolStripMenuItem";
			this.báoCáoBánHàngKhácToolStripMenuItem.Size = new global::System.Drawing.Size(294, 22);
			this.báoCáoBánHàngKhácToolStripMenuItem.Text = "Báo cáo bán hàng khác";
			this.tổngHợpHoaHồngTheoNVKDToolStripMenuItem.Name = "tổngHợpHoaHồngTheoNVKDToolStripMenuItem";
			this.tổngHợpHoaHồngTheoNVKDToolStripMenuItem.Size = new global::System.Drawing.Size(330, 22);
			this.tổngHợpHoaHồngTheoNVKDToolStripMenuItem.Text = "Tổng hợp hoa hồng theo NVKD";
			this.chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem.Name = "chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem";
			this.chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem.Size = new global::System.Drawing.Size(330, 22);
			this.chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem.Text = "Chi tiết bán hàng theo hóa đơn";
			this.báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem.Name = "báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem";
			this.báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem.Size = new global::System.Drawing.Size(330, 22);
			this.báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem.Text = "Báo cáo chi tiết hàng khuyến mãi";
			this.báoToolStripMenuItem.Name = "báoToolStripMenuItem";
			this.báoToolStripMenuItem.Size = new global::System.Drawing.Size(330, 22);
			this.báoToolStripMenuItem.Text = "Báo cáo tổng hợp giá trị bán theo tháng";
			this.báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem.Name = "báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem";
			this.báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem.Size = new global::System.Drawing.Size(330, 22);
			this.báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem.Text = "Báo cáo tổng hợp số lượng bán theo tháng";
			this.báoCáoĐặtHàngToolStripMenuItem.Name = "báoCáoĐặtHàngToolStripMenuItem";
			this.báoCáoĐặtHàngToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoĐặtHàngToolStripMenuItem.Text = "Báo cáo đặt hàng";
			this.báoCáoKhoHàngToolStripMenuItem.Name = "báoCáoKhoHàngToolStripMenuItem";
			this.báoCáoKhoHàngToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoKhoHàngToolStripMenuItem.Text = "Báo cáo kho hàng";
			this.báoCáoCôngNợToolStripMenuItem.Name = "báoCáoCôngNợToolStripMenuItem";
			this.báoCáoCôngNợToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoCôngNợToolStripMenuItem.Text = "Báo cáo công nợ";
			this.báoCáoQuảnTrịToolStripMenuItem.Name = "báoCáoQuảnTrịToolStripMenuItem";
			this.báoCáoQuảnTrịToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoQuảnTrịToolStripMenuItem.Text = "Báo cáo quản trị";
			this.báoCáoBiểuĐồToolStripMenuItem.Name = "báoCáoBiểuĐồToolStripMenuItem";
			this.báoCáoBiểuĐồToolStripMenuItem.Size = new global::System.Drawing.Size(184, 22);
			this.báoCáoBiểuĐồToolStripMenuItem.Text = "Báo cáo biểu đồ";
			this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
			this.trợGiúpToolStripMenuItem.Size = new global::System.Drawing.Size(77, 27);
			this.trợGiúpToolStripMenuItem.Text = "TRỢ GIÚP";
			this.menuStrip2.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.menuStrip2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.menuStrip2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnUsedServiceOder,
				this.mnQuanLyBanHang,
				this.mnThongKeDoanhThu,
				this.mnThongKeMatHangBan,
				this.mnChiTietHoatDong,
				this.mnTongHopKetQuaKinhDoanh,
				this.mnTonKho,
				this.mnGhiChu,
				this.mnBaoCao,
				this.mnThoat
			});
			this.menuStrip2.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip2.Location = new global::System.Drawing.Point(0, 27);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Padding = new global::System.Windows.Forms.Padding(0);
			this.menuStrip2.Size = new global::System.Drawing.Size(1167, 29);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			this.mnUsedServiceOder.Name = "mnUsedServiceOder";
			this.mnUsedServiceOder.Size = new global::System.Drawing.Size(114, 29);
			this.mnUsedServiceOder.Text = "Sử dụng dịch vụ";
			this.mnUsedServiceOder.Click += new global::System.EventHandler(this.mnUsedServiceOder_Click);
			this.mnQuanLyBanHang.Name = "mnQuanLyBanHang";
			this.mnQuanLyBanHang.Size = new global::System.Drawing.Size(123, 29);
			this.mnQuanLyBanHang.Text = "Quản lý bán hàng";
			this.mnQuanLyBanHang.Click += new global::System.EventHandler(this.mnQuanLyBanHang_Click);
			this.mnThongKeDoanhThu.Name = "mnThongKeDoanhThu";
			this.mnThongKeDoanhThu.Size = new global::System.Drawing.Size(137, 29);
			this.mnThongKeDoanhThu.Text = "Thống kê doanh thu";
			this.mnThongKeDoanhThu.Click += new global::System.EventHandler(this.mnThongKeDoanhThu_Click);
			this.mnThongKeMatHangBan.Name = "mnThongKeMatHangBan";
			this.mnThongKeMatHangBan.Size = new global::System.Drawing.Size(159, 29);
			this.mnThongKeMatHangBan.Text = "Thống kê mặt hàng bán";
			this.mnThongKeMatHangBan.Click += new global::System.EventHandler(this.mnThongKeMatHangBan_Click);
			this.mnChiTietHoatDong.Name = "mnChiTietHoatDong";
			this.mnChiTietHoatDong.Size = new global::System.Drawing.Size(125, 29);
			this.mnChiTietHoatDong.Text = "Chi tiết hoạt động";
			this.mnChiTietHoatDong.Click += new global::System.EventHandler(this.mnChiTietHoatDong_Click);
			this.mnTongHopKetQuaKinhDoanh.Name = "mnTongHopKetQuaKinhDoanh";
			this.mnTongHopKetQuaKinhDoanh.Size = new global::System.Drawing.Size(116, 29);
			this.mnTongHopKetQuaKinhDoanh.Text = "Tổng hợp KQKD";
			this.mnTongHopKetQuaKinhDoanh.Click += new global::System.EventHandler(this.mnTongHopKetQuaKinhDoanh_Click);
			this.mnTonKho.Name = "mnTonKho";
			this.mnTonKho.Size = new global::System.Drawing.Size(67, 29);
			this.mnTonKho.Text = "Tồn kho";
			this.mnTonKho.Click += new global::System.EventHandler(this.mnTonKho_Click);
			this.mnGhiChu.Name = "mnGhiChu";
			this.mnGhiChu.Size = new global::System.Drawing.Size(63, 29);
			this.mnGhiChu.Text = "Ghi chú";
			this.mnGhiChu.Click += new global::System.EventHandler(this.mnGhiChu_Click);
			this.mnBaoCao.Name = "mnBaoCao";
			this.mnBaoCao.Size = new global::System.Drawing.Size(67, 29);
			this.mnBaoCao.Text = "Báo cáo";
			this.mnBaoCao.Click += new global::System.EventHandler(this.mnBaoCao_Click);
			this.mnThoat.Name = "mnThoat";
			this.mnThoat.Size = new global::System.Drawing.Size(53, 29);
			this.mnThoat.Text = "Thoát";
			this.mnThoat.Click += new global::System.EventHandler(this.mnThoat_Click);
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 8.656716f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 91.34328f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 520f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(1173, 723);
			this.tableLayoutPanel1.TabIndex = 2;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Controls.Add(this.menuStrip2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 49.01961f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50.98039f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(1167, 56);
			this.tableLayoutPanel2.TabIndex = 2;
			this.tabControl1.Controls.Add(this.tabSuDungDichVu);
			this.tabControl1.Controls.Add(this.tabQuanLyBanHang);
			this.tabControl1.Controls.Add(this.tabDanhMucMatHang);
			this.tabControl1.Controls.Add(this.tabDanhMucBanKhuVuc);
			this.tabControl1.Controls.Add(this.tabDanhMucKhachHang);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tabControl1.Location = new global::System.Drawing.Point(3, 65);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(1167, 655);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.SelectedIndexChanged += new global::System.EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabSuDungDichVu.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			this.tabSuDungDichVu.Controls.Add(this.cbBangGia);
			this.tabSuDungDichVu.Controls.Add(this.label35);
			this.tabSuDungDichVu.Controls.Add(this.txtHoChieu);
			this.tabSuDungDichVu.Controls.Add(this.label31);
			this.tabSuDungDichVu.Controls.Add(this.cbNhanVien);
			this.tabSuDungDichVu.Controls.Add(this.txtGPLX);
			this.tabSuDungDichVu.Controls.Add(this.label30);
			this.tabSuDungDichVu.Controls.Add(this.btnFinish);
			this.tabSuDungDichVu.Controls.Add(this.dtEnd);
			this.tabSuDungDichVu.Controls.Add(this.dtNgay);
			this.tabSuDungDichVu.Controls.Add(this.dtBegin);
			this.tabSuDungDichVu.Controls.Add(this.dgvViewMenu);
			this.tabSuDungDichVu.Controls.Add(this.lstViewMenu);
			this.tabSuDungDichVu.Controls.Add(this.txtTimKiem);
			this.tabSuDungDichVu.Controls.Add(this.lblTim);
			this.tabSuDungDichVu.Controls.Add(this.tabControl3);
			this.tabSuDungDichVu.Controls.Add(this.btnThongKe);
			this.tabSuDungDichVu.Controls.Add(this.btnThanhToan);
			this.tabSuDungDichVu.Controls.Add(this.btnInCheBien);
			this.tabSuDungDichVu.Controls.Add(this.btnGiamGia);
			this.tabSuDungDichVu.Controls.Add(this.dgvMenu);
			this.tabSuDungDichVu.Controls.Add(this.btnChietKhau);
			this.tabSuDungDichVu.Controls.Add(this.btnGhiChu);
			this.tabSuDungDichVu.Controls.Add(this.btnDoiGia);
			this.tabSuDungDichVu.Controls.Add(this.btnDatSL);
			this.tabSuDungDichVu.Controls.Add(this.btnGiam);
			this.tabSuDungDichVu.Controls.Add(this.btnTang);
			this.tabSuDungDichVu.Controls.Add(this.btnXoa);
			this.tabSuDungDichVu.Controls.Add(this.btnGiamHang);
			this.tabSuDungDichVu.Controls.Add(this.btnThemHang);
			this.tabSuDungDichVu.Controls.Add(this.cbSoLuong);
			this.tabSuDungDichVu.Controls.Add(this.label6);
			this.tabSuDungDichVu.Controls.Add(this.btnGopPhong);
			this.tabSuDungDichVu.Controls.Add(this.btnChuyenPhong);
			this.tabSuDungDichVu.Controls.Add(this.txtSoKhachSDDV);
			this.tabSuDungDichVu.Controls.Add(this.label4);
			this.tabSuDungDichVu.Controls.Add(this.txtSoPhieuSDDV);
			this.tabSuDungDichVu.Controls.Add(this.label5);
			this.tabSuDungDichVu.Controls.Add(this.label3);
			this.tabSuDungDichVu.Controls.Add(this.txtCMND);
			this.tabSuDungDichVu.Controls.Add(this.label2);
			this.tabSuDungDichVu.Controls.Add(this.txtDiaChi);
			this.tabSuDungDichVu.Controls.Add(this.label1);
			this.tabSuDungDichVu.Controls.Add(this.txtDienThoai);
			this.tabSuDungDichVu.Controls.Add(this.lblDienThoai);
			this.tabSuDungDichVu.Controls.Add(this.lblTenKhach);
			this.tabSuDungDichVu.Controls.Add(this.cbKhachHang);
			this.tabSuDungDichVu.Controls.Add(this.lblKhachHang);
			this.tabSuDungDichVu.Controls.Add(this.lblSoPhong);
			this.tabSuDungDichVu.Controls.Add(this.lblSoPhut);
			this.tabSuDungDichVu.Controls.Add(this.btnBegin);
			this.tabSuDungDichVu.Controls.Add(this.tabControlSuDungDichVu);
			this.tabSuDungDichVu.Location = new global::System.Drawing.Point(4, 24);
			this.tabSuDungDichVu.Name = "tabSuDungDichVu";
			this.tabSuDungDichVu.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabSuDungDichVu.Size = new global::System.Drawing.Size(1159, 627);
			this.tabSuDungDichVu.TabIndex = 0;
			this.tabSuDungDichVu.Text = "Sử dụng dịch vụ";
			this.cbBangGia.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBangGia.FormattingEnabled = true;
			this.cbBangGia.Location = new global::System.Drawing.Point(625, 184);
			this.cbBangGia.Name = "cbBangGia";
			this.cbBangGia.Size = new global::System.Drawing.Size(159, 23);
			this.cbBangGia.TabIndex = 56;
			this.label35.AutoSize = true;
			this.label35.Location = new global::System.Drawing.Point(557, 187);
			this.label35.Name = "label35";
			this.label35.Size = new global::System.Drawing.Size(56, 15);
			this.label35.TabIndex = 55;
			this.label35.Text = "Bảng giá";
			this.txtHoChieu.Location = new global::System.Drawing.Point(352, 184);
			this.txtHoChieu.Name = "txtHoChieu";
			this.txtHoChieu.Size = new global::System.Drawing.Size(159, 21);
			this.txtHoChieu.TabIndex = 54;
			this.label31.AutoSize = true;
			this.label31.Location = new global::System.Drawing.Point(276, 187);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(56, 15);
			this.label31.TabIndex = 53;
			this.label31.Text = "Hộ chiếu";
			this.cbNhanVien.FormattingEnabled = true;
			this.cbNhanVien.Location = new global::System.Drawing.Point(625, 101);
			this.cbNhanVien.Name = "cbNhanVien";
			this.cbNhanVien.Size = new global::System.Drawing.Size(159, 23);
			this.cbNhanVien.TabIndex = 52;
			this.txtGPLX.Location = new global::System.Drawing.Point(625, 157);
			this.txtGPLX.Name = "txtGPLX";
			this.txtGPLX.Size = new global::System.Drawing.Size(159, 21);
			this.txtGPLX.TabIndex = 51;
			this.label30.AutoSize = true;
			this.label30.Location = new global::System.Drawing.Point(557, 160);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(39, 15);
			this.label30.TabIndex = 50;
			this.label30.Text = "GPLX";
			this.btnFinish.Location = new global::System.Drawing.Point(436, 37);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new global::System.Drawing.Size(75, 23);
			this.btnFinish.TabIndex = 49;
			this.btnFinish.Text = "Kết thúc";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new global::System.EventHandler(this.btnFinish_Click);
			this.dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtEnd.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtEnd.Location = new global::System.Drawing.Point(279, 39);
			this.dtEnd.Name = "dtEnd";
			this.dtEnd.Size = new global::System.Drawing.Size(151, 21);
			this.dtEnd.TabIndex = 48;
			this.dtNgay.CustomFormat = "dd/MM/yyyy";
			this.dtNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNgay.Location = new global::System.Drawing.Point(663, 7);
			this.dtNgay.Name = "dtNgay";
			this.dtNgay.Size = new global::System.Drawing.Size(121, 21);
			this.dtNgay.TabIndex = 47;
			this.dtBegin.CustomFormat = "dd/MM/yyyy HH:mm";
			this.dtBegin.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtBegin.Location = new global::System.Drawing.Point(279, 6);
			this.dtBegin.Name = "dtBegin";
			this.dtBegin.Size = new global::System.Drawing.Size(151, 21);
			this.dtBegin.TabIndex = 46;
			this.dgvViewMenu.AllowUserToAddRows = false;
			this.dgvViewMenu.AllowUserToDeleteRows = false;
			this.dgvViewMenu.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvViewMenu.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvViewMenu.Location = new global::System.Drawing.Point(888, 194);
			this.dgvViewMenu.MultiSelect = false;
			this.dgvViewMenu.Name = "dgvViewMenu";
			this.dgvViewMenu.ReadOnly = true;
			this.dgvViewMenu.RowHeadersVisible = false;
			this.dgvViewMenu.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvViewMenu.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvViewMenu.Size = new global::System.Drawing.Size(268, 423);
			this.dgvViewMenu.TabIndex = 45;
			this.dgvViewMenu.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewMenu_CellMouseClick);
			this.lstViewMenu.Location = new global::System.Drawing.Point(888, 40);
			this.lstViewMenu.Name = "lstViewMenu";
			this.lstViewMenu.Size = new global::System.Drawing.Size(268, 146);
			this.lstViewMenu.TabIndex = 44;
			this.lstViewMenu.UseCompatibleStateImageBehavior = false;
			this.lstViewMenu.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lstViewMenu_MouseClick);
			this.txtTimKiem.Location = new global::System.Drawing.Point(958, 9);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new global::System.Drawing.Size(198, 21);
			this.txtTimKiem.TabIndex = 43;
			this.txtTimKiem.TextChanged += new global::System.EventHandler(this.txtTimKiem_TextChanged);
			this.lblTim.AutoSize = true;
			this.lblTim.Location = new global::System.Drawing.Point(885, 12);
			this.lblTim.Name = "lblTim";
			this.lblTim.Size = new global::System.Drawing.Size(61, 15);
			this.lblTim.TabIndex = 42;
			this.lblTim.Text = " Tìm kiếm";
			this.tabControl3.Controls.Add(this.tabPage2);
			this.tabControl3.Controls.Add(this.tabPage3);
			this.tabControl3.Location = new global::System.Drawing.Point(279, 472);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new global::System.Drawing.Size(505, 149);
			this.tabControl3.TabIndex = 41;
			this.tabPage2.Controls.Add(this.txtTong);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.txtThanhTienGio);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.txtGiamGiaGio);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.txtThanhTienHang);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.txtGiamGiaHang);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.txtTienGio);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.txtTienHang);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(497, 121);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "Tổng";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.txtTong.Location = new global::System.Drawing.Point(80, 81);
			this.txtTong.Name = "txtTong";
			this.txtTong.Size = new global::System.Drawing.Size(411, 21);
			this.txtTong.TabIndex = 25;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(12, 84);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(65, 15);
			this.label13.TabIndex = 24;
			this.label13.Text = "Tổng cộng";
			this.txtThanhTienGio.Location = new global::System.Drawing.Point(397, 48);
			this.txtThanhTienGio.Name = "txtThanhTienGio";
			this.txtThanhTienGio.Size = new global::System.Drawing.Size(94, 21);
			this.txtThanhTienGio.TabIndex = 23;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(373, 51);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(18, 15);
			this.label11.TabIndex = 22;
			this.label11.Text = "%";
			this.txtGiamGiaGio.Location = new global::System.Drawing.Point(317, 48);
			this.txtGiamGiaGio.Name = "txtGiamGiaGio";
			this.txtGiamGiaGio.Size = new global::System.Drawing.Size(50, 21);
			this.txtGiamGiaGio.TabIndex = 21;
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(234, 51);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(77, 15);
			this.label12.TabIndex = 20;
			this.label12.Text = "Giảm giá giờ";
			this.txtThanhTienHang.Location = new global::System.Drawing.Point(397, 17);
			this.txtThanhTienHang.Name = "txtThanhTienHang";
			this.txtThanhTienHang.Size = new global::System.Drawing.Size(94, 21);
			this.txtThanhTienHang.TabIndex = 19;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(373, 20);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(18, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "%";
			this.txtGiamGiaHang.Location = new global::System.Drawing.Point(317, 17);
			this.txtGiamGiaHang.Name = "txtGiamGiaHang";
			this.txtGiamGiaHang.Size = new global::System.Drawing.Size(50, 21);
			this.txtGiamGiaHang.TabIndex = 17;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(254, 20);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(57, 15);
			this.label9.TabIndex = 16;
			this.label9.Text = "Giảm giá";
			this.txtTienGio.Location = new global::System.Drawing.Point(80, 48);
			this.txtTienGio.Name = "txtTienGio";
			this.txtTienGio.Size = new global::System.Drawing.Size(123, 21);
			this.txtTienGio.TabIndex = 15;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(12, 51);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(51, 15);
			this.label7.TabIndex = 14;
			this.label7.Text = "Tiền giờ";
			this.txtTienHang.Location = new global::System.Drawing.Point(80, 17);
			this.txtTienHang.Name = "txtTienHang";
			this.txtTienHang.Size = new global::System.Drawing.Size(123, 21);
			this.txtTienHang.TabIndex = 13;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(12, 20);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(62, 15);
			this.label8.TabIndex = 12;
			this.label8.Text = "Tiền hàng";
			this.tabPage3.Controls.Add(this.txtGhiChu);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(497, 121);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "Ghi chú";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.txtGhiChu.Location = new global::System.Drawing.Point(0, 0);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(497, 121);
			this.txtGhiChu.TabIndex = 1;
			this.btnThongKe.Location = new global::System.Drawing.Point(799, 563);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new global::System.Drawing.Size(75, 54);
			this.btnThongKe.TabIndex = 40;
			this.btnThongKe.Text = "Thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThanhToan.Location = new global::System.Drawing.Point(799, 496);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new global::System.Drawing.Size(75, 54);
			this.btnThanhToan.TabIndex = 39;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnInCheBien.Location = new global::System.Drawing.Point(799, 412);
			this.btnInCheBien.Name = "btnInCheBien";
			this.btnInCheBien.Size = new global::System.Drawing.Size(75, 54);
			this.btnInCheBien.TabIndex = 38;
			this.btnInCheBien.Text = "In Chế Biến";
			this.btnInCheBien.UseVisualStyleBackColor = true;
			this.btnGiamGia.Location = new global::System.Drawing.Point(799, 340);
			this.btnGiamGia.Name = "btnGiamGia";
			this.btnGiamGia.Size = new global::System.Drawing.Size(75, 54);
			this.btnGiamGia.TabIndex = 37;
			this.btnGiamGia.Text = "% Theo nhóm";
			this.btnGiamGia.UseVisualStyleBackColor = true;
			this.dgvMenu.AllowUserToAddRows = false;
			this.dgvMenu.AllowUserToDeleteRows = false;
			this.dgvMenu.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvMenu.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMenu.Location = new global::System.Drawing.Point(279, 252);
			this.dgvMenu.MultiSelect = false;
			this.dgvMenu.Name = "dgvMenu";
			this.dgvMenu.ReadOnly = true;
			this.dgvMenu.RowHeadersVisible = false;
			this.dgvMenu.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvMenu.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMenu.Size = new global::System.Drawing.Size(505, 214);
			this.dgvMenu.TabIndex = 36;
			this.dgvMenu.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellDoubleClick);
			this.dgvMenu.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMenu_CellMouseClick);
			this.btnChietKhau.Location = new global::System.Drawing.Point(641, 223);
			this.btnChietKhau.Name = "btnChietKhau";
			this.btnChietKhau.Size = new global::System.Drawing.Size(75, 23);
			this.btnChietKhau.TabIndex = 35;
			this.btnChietKhau.Text = "CK %";
			this.btnChietKhau.UseVisualStyleBackColor = true;
			this.btnChietKhau.Click += new global::System.EventHandler(this.btnChietKhau_Click);
			this.btnGhiChu.Location = new global::System.Drawing.Point(569, 223);
			this.btnGhiChu.Name = "btnGhiChu";
			this.btnGhiChu.Size = new global::System.Drawing.Size(75, 23);
			this.btnGhiChu.TabIndex = 34;
			this.btnGhiChu.Text = "Ghi chú";
			this.btnGhiChu.UseVisualStyleBackColor = true;
			this.btnGhiChu.Click += new global::System.EventHandler(this.btnGhiChu_Click);
			this.btnDoiGia.Location = new global::System.Drawing.Point(497, 223);
			this.btnDoiGia.Name = "btnDoiGia";
			this.btnDoiGia.Size = new global::System.Drawing.Size(75, 23);
			this.btnDoiGia.TabIndex = 33;
			this.btnDoiGia.Text = "Đổi giá";
			this.btnDoiGia.UseVisualStyleBackColor = true;
			this.btnDoiGia.Click += new global::System.EventHandler(this.btnDoiGia_Click);
			this.btnDatSL.Location = new global::System.Drawing.Point(425, 223);
			this.btnDatSL.Name = "btnDatSL";
			this.btnDatSL.Size = new global::System.Drawing.Size(75, 23);
			this.btnDatSL.TabIndex = 32;
			this.btnDatSL.Text = "Đặt SL";
			this.btnDatSL.UseVisualStyleBackColor = true;
			this.btnDatSL.Click += new global::System.EventHandler(this.btnDatSL_Click);
			this.btnGiam.Location = new global::System.Drawing.Point(352, 223);
			this.btnGiam.Name = "btnGiam";
			this.btnGiam.Size = new global::System.Drawing.Size(75, 23);
			this.btnGiam.TabIndex = 31;
			this.btnGiam.Text = "Giảm";
			this.btnGiam.UseVisualStyleBackColor = true;
			this.btnGiam.Click += new global::System.EventHandler(this.btnGiam_Click);
			this.btnTang.Location = new global::System.Drawing.Point(279, 223);
			this.btnTang.Name = "btnTang";
			this.btnTang.Size = new global::System.Drawing.Size(75, 23);
			this.btnTang.TabIndex = 30;
			this.btnTang.Text = "Tăng";
			this.btnTang.UseVisualStyleBackColor = true;
			this.btnTang.Click += new global::System.EventHandler(this.btnTang_Click);
			this.btnXoa.Location = new global::System.Drawing.Point(799, 252);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new global::System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 28;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new global::System.EventHandler(this.btnXoa_Click);
			this.btnGiamHang.Location = new global::System.Drawing.Point(799, 223);
			this.btnGiamHang.Name = "btnGiamHang";
			this.btnGiamHang.Size = new global::System.Drawing.Size(75, 23);
			this.btnGiamHang.TabIndex = 27;
			this.btnGiamHang.Text = ">> Giảm";
			this.btnGiamHang.UseVisualStyleBackColor = true;
			this.btnGiamHang.Click += new global::System.EventHandler(this.btnGiamHang_Click);
			this.btnThemHang.Location = new global::System.Drawing.Point(799, 194);
			this.btnThemHang.Name = "btnThemHang";
			this.btnThemHang.Size = new global::System.Drawing.Size(75, 23);
			this.btnThemHang.TabIndex = 26;
			this.btnThemHang.Text = "<< Thêm";
			this.btnThemHang.UseVisualStyleBackColor = true;
			this.btnThemHang.Click += new global::System.EventHandler(this.btnThemHang_Click);
			this.cbSoLuong.FormattingEnabled = true;
			this.cbSoLuong.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20"
			});
			this.cbSoLuong.Location = new global::System.Drawing.Point(799, 165);
			this.cbSoLuong.Name = "cbSoLuong";
			this.cbSoLuong.Size = new global::System.Drawing.Size(75, 23);
			this.cbSoLuong.TabIndex = 25;
			this.cbSoLuong.Text = "1";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(796, 147);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(56, 15);
			this.label6.TabIndex = 24;
			this.label6.Text = "Số lượng";
			this.btnGopPhong.Location = new global::System.Drawing.Point(799, 70);
			this.btnGopPhong.Name = "btnGopPhong";
			this.btnGopPhong.Size = new global::System.Drawing.Size(75, 54);
			this.btnGopPhong.TabIndex = 23;
			this.btnGopPhong.Text = "Gộp phòng";
			this.btnGopPhong.UseVisualStyleBackColor = true;
			this.btnChuyenPhong.Location = new global::System.Drawing.Point(799, 6);
			this.btnChuyenPhong.Name = "btnChuyenPhong";
			this.btnChuyenPhong.Size = new global::System.Drawing.Size(75, 54);
			this.btnChuyenPhong.TabIndex = 22;
			this.btnChuyenPhong.Text = "Chuyển phòng";
			this.btnChuyenPhong.UseVisualStyleBackColor = true;
			this.txtSoKhachSDDV.Location = new global::System.Drawing.Point(663, 70);
			this.txtSoKhachSDDV.Name = "txtSoKhachSDDV";
			this.txtSoKhachSDDV.Size = new global::System.Drawing.Size(121, 21);
			this.txtSoKhachSDDV.TabIndex = 21;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(599, 70);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(58, 15);
			this.label4.TabIndex = 20;
			this.label4.Text = "Số khách";
			this.txtSoPhieuSDDV.Location = new global::System.Drawing.Point(663, 39);
			this.txtSoPhieuSDDV.Name = "txtSoPhieuSDDV";
			this.txtSoPhieuSDDV.Size = new global::System.Drawing.Size(121, 21);
			this.txtSoPhieuSDDV.TabIndex = 19;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(601, 40);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(56, 15);
			this.label5.TabIndex = 18;
			this.label5.Text = "Số phiếu";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(622, 9);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(35, 15);
			this.label3.TabIndex = 16;
			this.label3.Text = "Ngày";
			this.txtCMND.Location = new global::System.Drawing.Point(352, 157);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new global::System.Drawing.Size(159, 21);
			this.txtCMND.TabIndex = 15;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(276, 160);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(44, 15);
			this.label2.TabIndex = 14;
			this.label2.Text = "CMND";
			this.txtDiaChi.Location = new global::System.Drawing.Point(352, 130);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new global::System.Drawing.Size(159, 21);
			this.txtDiaChi.TabIndex = 13;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(276, 133);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(45, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "Địa chỉ";
			this.txtDienThoai.Location = new global::System.Drawing.Point(625, 130);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new global::System.Drawing.Size(159, 21);
			this.txtDienThoai.TabIndex = 11;
			this.lblDienThoai.AutoSize = true;
			this.lblDienThoai.Location = new global::System.Drawing.Point(557, 133);
			this.lblDienThoai.Name = "lblDienThoai";
			this.lblDienThoai.Size = new global::System.Drawing.Size(63, 15);
			this.lblDienThoai.TabIndex = 10;
			this.lblDienThoai.Text = "Điện thoại";
			this.lblTenKhach.AutoSize = true;
			this.lblTenKhach.Location = new global::System.Drawing.Point(557, 104);
			this.lblTenKhach.Name = "lblTenKhach";
			this.lblTenKhach.Size = new global::System.Drawing.Size(62, 15);
			this.lblTenKhach.TabIndex = 8;
			this.lblTenKhach.Text = "Nhân viên";
			this.cbKhachHang.FormattingEnabled = true;
			this.cbKhachHang.Location = new global::System.Drawing.Point(352, 101);
			this.cbKhachHang.Name = "cbKhachHang";
			this.cbKhachHang.Size = new global::System.Drawing.Size(159, 23);
			this.cbKhachHang.TabIndex = 7;
			this.cbKhachHang.SelectedIndexChanged += new global::System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
			this.lblKhachHang.AutoSize = true;
			this.lblKhachHang.Location = new global::System.Drawing.Point(276, 104);
			this.lblKhachHang.Name = "lblKhachHang";
			this.lblKhachHang.Size = new global::System.Drawing.Size(73, 15);
			this.lblKhachHang.TabIndex = 6;
			this.lblKhachHang.Text = "Khách hàng";
			this.lblSoPhong.AutoSize = true;
			this.lblSoPhong.Location = new global::System.Drawing.Point(280, 70);
			this.lblSoPhong.Name = "lblSoPhong";
			this.lblSoPhong.Size = new global::System.Drawing.Size(41, 15);
			this.lblSoPhong.TabIndex = 5;
			this.lblSoPhong.Text = "label2";
			this.lblSoPhut.AutoSize = true;
			this.lblSoPhut.Location = new global::System.Drawing.Point(349, 70);
			this.lblSoPhut.Name = "lblSoPhut";
			this.lblSoPhut.Size = new global::System.Drawing.Size(41, 15);
			this.lblSoPhut.TabIndex = 4;
			this.lblSoPhut.Text = "label1";
			this.btnBegin.Location = new global::System.Drawing.Point(436, 4);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new global::System.Drawing.Size(75, 23);
			this.btnBegin.TabIndex = 3;
			this.btnBegin.Text = "Bắt đầu";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new global::System.EventHandler(this.btnBegin_Click);
			this.tabControlSuDungDichVu.ContextMenuStrip = this.menuStripSuDungDichVu;
			this.tabControlSuDungDichVu.Location = new global::System.Drawing.Point(0, 0);
			this.tabControlSuDungDichVu.Name = "tabControlSuDungDichVu";
			this.tabControlSuDungDichVu.SelectedIndex = 0;
			this.tabControlSuDungDichVu.Size = new global::System.Drawing.Size(270, 621);
			this.tabControlSuDungDichVu.TabIndex = 0;
			this.menuStripSuDungDichVu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmPhongBan,
				this.cmBaoDon,
				this.cmDonXong,
				this.cmMoPhong,
				this.cmMoPhongTuDatTruoc,
				this.cmThanhToan,
				this.cmRefreshService,
				this.cmChuyenPhong,
				this.cmGopPhong,
				this.cmHuyHoaDon
			});
			this.menuStripSuDungDichVu.Name = "menuStripSuDungDichVu";
			this.menuStripSuDungDichVu.Size = new global::System.Drawing.Size(196, 224);
			this.menuStripSuDungDichVu.Opened += new global::System.EventHandler(this.menuStripSuDungDichVu_Opened);
			this.cmPhongBan.Name = "cmPhongBan";
			this.cmPhongBan.Size = new global::System.Drawing.Size(195, 22);
			this.cmPhongBan.Text = "Phòng bẩn";
			this.cmPhongBan.Click += new global::System.EventHandler(this.cmPhongBan_Click);
			this.cmBaoDon.Name = "cmBaoDon";
			this.cmBaoDon.Size = new global::System.Drawing.Size(195, 22);
			this.cmBaoDon.Text = "Báo dọn";
			this.cmBaoDon.Click += new global::System.EventHandler(this.cmBaoDon_Click);
			this.cmDonXong.Name = "cmDonXong";
			this.cmDonXong.Size = new global::System.Drawing.Size(195, 22);
			this.cmDonXong.Text = "Dọn xong";
			this.cmDonXong.Click += new global::System.EventHandler(this.cmDonXong_Click);
			this.cmMoPhong.Name = "cmMoPhong";
			this.cmMoPhong.Size = new global::System.Drawing.Size(195, 22);
			this.cmMoPhong.Text = "Mở phòng";
			this.cmMoPhong.Click += new global::System.EventHandler(this.cmMoPhong_Click);
			this.cmMoPhongTuDatTruoc.Name = "cmMoPhongTuDatTruoc";
			this.cmMoPhongTuDatTruoc.Size = new global::System.Drawing.Size(195, 22);
			this.cmMoPhongTuDatTruoc.Text = "Mở phòng từ đặt trước";
			this.cmThanhToan.Name = "cmThanhToan";
			this.cmThanhToan.Size = new global::System.Drawing.Size(195, 22);
			this.cmThanhToan.Text = "Thanh toán";
			this.cmThanhToan.Click += new global::System.EventHandler(this.cmThanhToan_Click);
			this.cmRefreshService.Name = "cmRefreshService";
			this.cmRefreshService.Size = new global::System.Drawing.Size(195, 22);
			this.cmRefreshService.Text = "Refresh";
			this.cmRefreshService.Click += new global::System.EventHandler(this.cmRefreshService_Click);
			this.cmChuyenPhong.Name = "cmChuyenPhong";
			this.cmChuyenPhong.Size = new global::System.Drawing.Size(195, 22);
			this.cmChuyenPhong.Text = "Chuyển phòng";
			this.cmGopPhong.Name = "cmGopPhong";
			this.cmGopPhong.Size = new global::System.Drawing.Size(195, 22);
			this.cmGopPhong.Text = "Gộp phòng";
			this.cmHuyHoaDon.Name = "cmHuyHoaDon";
			this.cmHuyHoaDon.Size = new global::System.Drawing.Size(195, 22);
			this.cmHuyHoaDon.Text = "Hủy hóa đơn";
			this.tabQuanLyBanHang.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			this.tabQuanLyBanHang.Controls.Add(this.dateTimePicker1);
			this.tabQuanLyBanHang.Controls.Add(this.dateTimePicker2);
			this.tabQuanLyBanHang.Controls.Add(this.dateTimePicker3);
			this.tabQuanLyBanHang.Controls.Add(this.label32);
			this.tabQuanLyBanHang.Controls.Add(this.label33);
			this.tabQuanLyBanHang.Controls.Add(this.label34);
			this.tabQuanLyBanHang.Controls.Add(this.btnHuyPhieu);
			this.tabQuanLyBanHang.Controls.Add(this.dtgViewMenuQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.lstViewQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.txtTimKiemQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label23);
			this.tabQuanLyBanHang.Controls.Add(this.tabControl4);
			this.tabQuanLyBanHang.Controls.Add(this.btnThanhToanQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnInLaiBill);
			this.tabQuanLyBanHang.Controls.Add(this.btnCKQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.dataGridView2);
			this.tabQuanLyBanHang.Controls.Add(this.btnChietKhauQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnGhiChuQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnDoiGiaQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnDatSLQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnGiamQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnTangQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnBangGiaQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnXoaQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnGiamHangQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnThemQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.cbSLQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label24);
			this.tabQuanLyBanHang.Controls.Add(this.txtSoKhach);
			this.tabQuanLyBanHang.Controls.Add(this.txtSoPhieu);
			this.tabQuanLyBanHang.Controls.Add(this.txtCMNDQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label25);
			this.tabQuanLyBanHang.Controls.Add(this.txtDiaChiQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label26);
			this.tabQuanLyBanHang.Controls.Add(this.txtDienThoaiQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label27);
			this.tabQuanLyBanHang.Controls.Add(this.txtTenKhachQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label28);
			this.tabQuanLyBanHang.Controls.Add(this.cbKhachHangQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.label29);
			this.tabQuanLyBanHang.Controls.Add(this.lblSoPhongQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.lblKhachHangQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnBeginQLBH);
			this.tabQuanLyBanHang.Controls.Add(this.btnTaiDuLieu);
			this.tabQuanLyBanHang.Controls.Add(this.cbChonNgay);
			this.tabQuanLyBanHang.Controls.Add(this.cbNgayThang2);
			this.tabQuanLyBanHang.Controls.Add(this.label15);
			this.tabQuanLyBanHang.Controls.Add(this.cbNgayThang1);
			this.tabQuanLyBanHang.Controls.Add(this.label14);
			this.tabQuanLyBanHang.Controls.Add(this.dgvQuanLyBanHang);
			this.tabQuanLyBanHang.Location = new global::System.Drawing.Point(4, 24);
			this.tabQuanLyBanHang.Name = "tabQuanLyBanHang";
			this.tabQuanLyBanHang.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuanLyBanHang.Size = new global::System.Drawing.Size(1159, 627);
			this.tabQuanLyBanHang.TabIndex = 1;
			this.tabQuanLyBanHang.Text = "Quản lý bán hàng";
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:MM";
			this.dateTimePicker1.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new global::System.Drawing.Point(396, 39);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new global::System.Drawing.Size(151, 21);
			this.dateTimePicker1.TabIndex = 94;
			this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker2.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new global::System.Drawing.Point(724, 10);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new global::System.Drawing.Size(121, 21);
			this.dateTimePicker2.TabIndex = 93;
			this.dateTimePicker3.CustomFormat = "dd/MM/yyyy HH:MM";
			this.dateTimePicker3.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker3.Location = new global::System.Drawing.Point(396, 8);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new global::System.Drawing.Size(151, 21);
			this.dateTimePicker3.TabIndex = 92;
			this.label32.AutoSize = true;
			this.label32.Location = new global::System.Drawing.Point(660, 72);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(58, 15);
			this.label32.TabIndex = 91;
			this.label32.Text = "Số khách";
			this.label33.AutoSize = true;
			this.label33.Location = new global::System.Drawing.Point(662, 42);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(56, 15);
			this.label33.TabIndex = 90;
			this.label33.Text = "Số phiếu";
			this.label34.AutoSize = true;
			this.label34.Location = new global::System.Drawing.Point(683, 11);
			this.label34.Name = "label34";
			this.label34.Size = new global::System.Drawing.Size(35, 15);
			this.label34.TabIndex = 89;
			this.label34.Text = "Ngày";
			this.btnHuyPhieu.Location = new global::System.Drawing.Point(1045, 8);
			this.btnHuyPhieu.Name = "btnHuyPhieu";
			this.btnHuyPhieu.Size = new global::System.Drawing.Size(108, 23);
			this.btnHuyPhieu.TabIndex = 88;
			this.btnHuyPhieu.Text = "Hủy phiếu";
			this.btnHuyPhieu.UseVisualStyleBackColor = true;
			this.dtgViewMenuQLBH.BackgroundColor = global::System.Drawing.Color.White;
			this.dtgViewMenuQLBH.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgViewMenuQLBH.Location = new global::System.Drawing.Point(934, 224);
			this.dtgViewMenuQLBH.Name = "dtgViewMenuQLBH";
			this.dtgViewMenuQLBH.Size = new global::System.Drawing.Size(219, 397);
			this.dtgViewMenuQLBH.TabIndex = 87;
			this.lstViewQLBH.Location = new global::System.Drawing.Point(934, 72);
			this.lstViewQLBH.Name = "lstViewQLBH";
			this.lstViewQLBH.Size = new global::System.Drawing.Size(219, 146);
			this.lstViewQLBH.TabIndex = 86;
			this.lstViewQLBH.UseCompatibleStateImageBehavior = false;
			this.txtTimKiemQLBH.Location = new global::System.Drawing.Point(996, 41);
			this.txtTimKiemQLBH.Name = "txtTimKiemQLBH";
			this.txtTimKiemQLBH.Size = new global::System.Drawing.Size(157, 21);
			this.txtTimKiemQLBH.TabIndex = 85;
			this.label23.AutoSize = true;
			this.label23.Location = new global::System.Drawing.Point(931, 43);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(61, 15);
			this.label23.TabIndex = 84;
			this.label23.Text = " Tìm kiếm";
			this.tabControl4.Controls.Add(this.tabPage1);
			this.tabControl4.Controls.Add(this.tabPage4);
			this.tabControl4.Location = new global::System.Drawing.Point(340, 472);
			this.tabControl4.Name = "tabControl4";
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new global::System.Drawing.Size(505, 149);
			this.tabControl4.TabIndex = 83;
			this.tabPage1.Controls.Add(this.txtTongQLBH);
			this.tabPage1.Controls.Add(this.label16);
			this.tabPage1.Controls.Add(this.txtThanhTienGioQLBH);
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.txtGiamGiaGioQLBH);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.txtThanhTienQLBH);
			this.tabPage1.Controls.Add(this.label19);
			this.tabPage1.Controls.Add(this.txtGiamGia);
			this.tabPage1.Controls.Add(this.label20);
			this.tabPage1.Controls.Add(this.txtTienGioQLBH);
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Controls.Add(this.txtTienHangQLBH);
			this.tabPage1.Controls.Add(this.label22);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(497, 121);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tổng";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.txtTongQLBH.Location = new global::System.Drawing.Point(80, 81);
			this.txtTongQLBH.Name = "txtTongQLBH";
			this.txtTongQLBH.Size = new global::System.Drawing.Size(411, 21);
			this.txtTongQLBH.TabIndex = 25;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(12, 84);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(65, 15);
			this.label16.TabIndex = 24;
			this.label16.Text = "Tổng cộng";
			this.txtThanhTienGioQLBH.Location = new global::System.Drawing.Point(397, 48);
			this.txtThanhTienGioQLBH.Name = "txtThanhTienGioQLBH";
			this.txtThanhTienGioQLBH.Size = new global::System.Drawing.Size(94, 21);
			this.txtThanhTienGioQLBH.TabIndex = 23;
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(373, 51);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(18, 15);
			this.label17.TabIndex = 22;
			this.label17.Text = "%";
			this.txtGiamGiaGioQLBH.Location = new global::System.Drawing.Point(317, 48);
			this.txtGiamGiaGioQLBH.Name = "txtGiamGiaGioQLBH";
			this.txtGiamGiaGioQLBH.Size = new global::System.Drawing.Size(50, 21);
			this.txtGiamGiaGioQLBH.TabIndex = 21;
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(234, 51);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(77, 15);
			this.label18.TabIndex = 20;
			this.label18.Text = "Giảm giá giờ";
			this.txtThanhTienQLBH.Location = new global::System.Drawing.Point(397, 17);
			this.txtThanhTienQLBH.Name = "txtThanhTienQLBH";
			this.txtThanhTienQLBH.Size = new global::System.Drawing.Size(94, 21);
			this.txtThanhTienQLBH.TabIndex = 19;
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(373, 20);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(18, 15);
			this.label19.TabIndex = 18;
			this.label19.Text = "%";
			this.txtGiamGia.Location = new global::System.Drawing.Point(317, 17);
			this.txtGiamGia.Name = "txtGiamGia";
			this.txtGiamGia.Size = new global::System.Drawing.Size(50, 21);
			this.txtGiamGia.TabIndex = 17;
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(254, 20);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(57, 15);
			this.label20.TabIndex = 16;
			this.label20.Text = "Giảm giá";
			this.txtTienGioQLBH.Location = new global::System.Drawing.Point(80, 48);
			this.txtTienGioQLBH.Name = "txtTienGioQLBH";
			this.txtTienGioQLBH.Size = new global::System.Drawing.Size(123, 21);
			this.txtTienGioQLBH.TabIndex = 15;
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(12, 51);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(51, 15);
			this.label21.TabIndex = 14;
			this.label21.Text = "Tiền giờ";
			this.txtTienHangQLBH.Location = new global::System.Drawing.Point(80, 17);
			this.txtTienHangQLBH.Name = "txtTienHangQLBH";
			this.txtTienHangQLBH.Size = new global::System.Drawing.Size(123, 21);
			this.txtTienHangQLBH.TabIndex = 13;
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(12, 20);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(62, 15);
			this.label22.TabIndex = 12;
			this.label22.Text = "Tiền hàng";
			this.tabPage4.Controls.Add(this.txtGhiChuQLBH);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(497, 121);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Ghi chú";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.txtGhiChuQLBH.Location = new global::System.Drawing.Point(0, 0);
			this.txtGhiChuQLBH.Multiline = true;
			this.txtGhiChuQLBH.Name = "txtGhiChuQLBH";
			this.txtGhiChuQLBH.Size = new global::System.Drawing.Size(497, 121);
			this.txtGhiChuQLBH.TabIndex = 0;
			this.btnThanhToanQLBH.Location = new global::System.Drawing.Point(853, 563);
			this.btnThanhToanQLBH.Name = "btnThanhToanQLBH";
			this.btnThanhToanQLBH.Size = new global::System.Drawing.Size(75, 54);
			this.btnThanhToanQLBH.TabIndex = 81;
			this.btnThanhToanQLBH.Text = "Thanh toán";
			this.btnThanhToanQLBH.UseVisualStyleBackColor = true;
			this.btnInLaiBill.Location = new global::System.Drawing.Point(853, 413);
			this.btnInLaiBill.Name = "btnInLaiBill";
			this.btnInLaiBill.Size = new global::System.Drawing.Size(75, 54);
			this.btnInLaiBill.TabIndex = 80;
			this.btnInLaiBill.Text = "In Lại Bill";
			this.btnInLaiBill.UseVisualStyleBackColor = true;
			this.btnCKQLBH.Location = new global::System.Drawing.Point(853, 353);
			this.btnCKQLBH.Name = "btnCKQLBH";
			this.btnCKQLBH.Size = new global::System.Drawing.Size(75, 54);
			this.btnCKQLBH.TabIndex = 79;
			this.btnCKQLBH.Text = "% Theo nhóm";
			this.btnCKQLBH.UseVisualStyleBackColor = true;
			this.dataGridView2.BackgroundColor = global::System.Drawing.Color.White;
			this.dataGridView2.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new global::System.Drawing.Point(340, 253);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new global::System.Drawing.Size(505, 214);
			this.dataGridView2.TabIndex = 78;
			this.btnChietKhauQLBH.Location = new global::System.Drawing.Point(702, 224);
			this.btnChietKhauQLBH.Name = "btnChietKhauQLBH";
			this.btnChietKhauQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnChietKhauQLBH.TabIndex = 77;
			this.btnChietKhauQLBH.Text = "CK %";
			this.btnChietKhauQLBH.UseVisualStyleBackColor = true;
			this.btnGhiChuQLBH.Location = new global::System.Drawing.Point(630, 224);
			this.btnGhiChuQLBH.Name = "btnGhiChuQLBH";
			this.btnGhiChuQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnGhiChuQLBH.TabIndex = 76;
			this.btnGhiChuQLBH.Text = "Ghi chú";
			this.btnGhiChuQLBH.UseVisualStyleBackColor = true;
			this.btnDoiGiaQLBH.Location = new global::System.Drawing.Point(558, 224);
			this.btnDoiGiaQLBH.Name = "btnDoiGiaQLBH";
			this.btnDoiGiaQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnDoiGiaQLBH.TabIndex = 75;
			this.btnDoiGiaQLBH.Text = "Đổi giá";
			this.btnDoiGiaQLBH.UseVisualStyleBackColor = true;
			this.btnDatSLQLBH.Location = new global::System.Drawing.Point(486, 224);
			this.btnDatSLQLBH.Name = "btnDatSLQLBH";
			this.btnDatSLQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnDatSLQLBH.TabIndex = 74;
			this.btnDatSLQLBH.Text = "Đặt SL";
			this.btnDatSLQLBH.UseVisualStyleBackColor = true;
			this.btnGiamQLBH.Location = new global::System.Drawing.Point(413, 224);
			this.btnGiamQLBH.Name = "btnGiamQLBH";
			this.btnGiamQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnGiamQLBH.TabIndex = 73;
			this.btnGiamQLBH.Text = "Giảm";
			this.btnGiamQLBH.UseVisualStyleBackColor = true;
			this.btnTangQLBH.Location = new global::System.Drawing.Point(340, 224);
			this.btnTangQLBH.Name = "btnTangQLBH";
			this.btnTangQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnTangQLBH.TabIndex = 72;
			this.btnTangQLBH.Text = "Tăng";
			this.btnTangQLBH.UseVisualStyleBackColor = true;
			this.btnBangGiaQLBH.Location = new global::System.Drawing.Point(686, 195);
			this.btnBangGiaQLBH.Name = "btnBangGiaQLBH";
			this.btnBangGiaQLBH.Size = new global::System.Drawing.Size(159, 23);
			this.btnBangGiaQLBH.TabIndex = 71;
			this.btnBangGiaQLBH.Text = "Bảng giá chuẩn";
			this.btnBangGiaQLBH.UseVisualStyleBackColor = true;
			this.btnXoaQLBH.Location = new global::System.Drawing.Point(853, 253);
			this.btnXoaQLBH.Name = "btnXoaQLBH";
			this.btnXoaQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnXoaQLBH.TabIndex = 70;
			this.btnXoaQLBH.Text = "Xóa";
			this.btnXoaQLBH.UseVisualStyleBackColor = true;
			this.btnGiamHangQLBH.Location = new global::System.Drawing.Point(853, 224);
			this.btnGiamHangQLBH.Name = "btnGiamHangQLBH";
			this.btnGiamHangQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnGiamHangQLBH.TabIndex = 69;
			this.btnGiamHangQLBH.Text = ">> Giảm";
			this.btnGiamHangQLBH.UseVisualStyleBackColor = true;
			this.btnThemQLBH.Location = new global::System.Drawing.Point(853, 195);
			this.btnThemQLBH.Name = "btnThemQLBH";
			this.btnThemQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnThemQLBH.TabIndex = 68;
			this.btnThemQLBH.Text = "<< Thêm";
			this.btnThemQLBH.UseVisualStyleBackColor = true;
			this.cbSLQLBH.FormattingEnabled = true;
			this.cbSLQLBH.Location = new global::System.Drawing.Point(853, 166);
			this.cbSLQLBH.Name = "cbSLQLBH";
			this.cbSLQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.cbSLQLBH.TabIndex = 67;
			this.label24.AutoSize = true;
			this.label24.Location = new global::System.Drawing.Point(850, 148);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(56, 15);
			this.label24.TabIndex = 66;
			this.label24.Text = "Số lượng";
			this.txtSoKhach.Location = new global::System.Drawing.Point(724, 70);
			this.txtSoKhach.Name = "txtSoKhach";
			this.txtSoKhach.Size = new global::System.Drawing.Size(121, 21);
			this.txtSoKhach.TabIndex = 63;
			this.txtSoPhieu.Location = new global::System.Drawing.Point(724, 40);
			this.txtSoPhieu.Name = "txtSoPhieu";
			this.txtSoPhieu.Size = new global::System.Drawing.Size(121, 21);
			this.txtSoPhieu.TabIndex = 62;
			this.txtCMNDQLBH.Location = new global::System.Drawing.Point(686, 162);
			this.txtCMNDQLBH.Name = "txtCMNDQLBH";
			this.txtCMNDQLBH.Size = new global::System.Drawing.Size(159, 21);
			this.txtCMNDQLBH.TabIndex = 60;
			this.label25.AutoSize = true;
			this.label25.Location = new global::System.Drawing.Point(636, 165);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(44, 15);
			this.label25.TabIndex = 59;
			this.label25.Text = "CMND";
			this.txtDiaChiQLBH.Location = new global::System.Drawing.Point(686, 132);
			this.txtDiaChiQLBH.Name = "txtDiaChiQLBH";
			this.txtDiaChiQLBH.Size = new global::System.Drawing.Size(159, 21);
			this.txtDiaChiQLBH.TabIndex = 58;
			this.label26.AutoSize = true;
			this.label26.Location = new global::System.Drawing.Point(636, 135);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(45, 15);
			this.label26.TabIndex = 57;
			this.label26.Text = "Địa chỉ";
			this.txtDienThoaiQLBH.Location = new global::System.Drawing.Point(413, 162);
			this.txtDienThoaiQLBH.Name = "txtDienThoaiQLBH";
			this.txtDienThoaiQLBH.Size = new global::System.Drawing.Size(159, 21);
			this.txtDienThoaiQLBH.TabIndex = 56;
			this.label27.AutoSize = true;
			this.label27.Location = new global::System.Drawing.Point(337, 165);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(63, 15);
			this.label27.TabIndex = 55;
			this.label27.Text = "Điện thoại";
			this.txtTenKhachQLBH.Location = new global::System.Drawing.Point(413, 132);
			this.txtTenKhachQLBH.Name = "txtTenKhachQLBH";
			this.txtTenKhachQLBH.Size = new global::System.Drawing.Size(159, 21);
			this.txtTenKhachQLBH.TabIndex = 54;
			this.label28.AutoSize = true;
			this.label28.Location = new global::System.Drawing.Point(337, 135);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(64, 15);
			this.label28.TabIndex = 53;
			this.label28.Text = "Tên khách";
			this.cbKhachHangQLBH.FormattingEnabled = true;
			this.cbKhachHangQLBH.Location = new global::System.Drawing.Point(413, 100);
			this.cbKhachHangQLBH.Name = "cbKhachHangQLBH";
			this.cbKhachHangQLBH.Size = new global::System.Drawing.Size(432, 23);
			this.cbKhachHangQLBH.TabIndex = 52;
			this.label29.AutoSize = true;
			this.label29.Location = new global::System.Drawing.Point(337, 103);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(73, 15);
			this.label29.TabIndex = 51;
			this.label29.Text = "Khách hàng";
			this.lblSoPhongQLBH.AutoSize = true;
			this.lblSoPhongQLBH.Location = new global::System.Drawing.Point(506, 75);
			this.lblSoPhongQLBH.Name = "lblSoPhongQLBH";
			this.lblSoPhongQLBH.Size = new global::System.Drawing.Size(41, 15);
			this.lblSoPhongQLBH.TabIndex = 50;
			this.lblSoPhongQLBH.Text = "label2";
			this.lblKhachHangQLBH.AutoSize = true;
			this.lblKhachHangQLBH.Location = new global::System.Drawing.Point(393, 75);
			this.lblKhachHangQLBH.Name = "lblKhachHangQLBH";
			this.lblKhachHangQLBH.Size = new global::System.Drawing.Size(41, 15);
			this.lblKhachHangQLBH.TabIndex = 49;
			this.lblKhachHangQLBH.Text = "label1";
			this.btnBeginQLBH.Location = new global::System.Drawing.Point(558, 8);
			this.btnBeginQLBH.Name = "btnBeginQLBH";
			this.btnBeginQLBH.Size = new global::System.Drawing.Size(75, 23);
			this.btnBeginQLBH.TabIndex = 48;
			this.btnBeginQLBH.Text = "Bắt đầu";
			this.btnBeginQLBH.UseVisualStyleBackColor = true;
			this.btnTaiDuLieu.Location = new global::System.Drawing.Point(297, 8);
			this.btnTaiDuLieu.Name = "btnTaiDuLieu";
			this.btnTaiDuLieu.Size = new global::System.Drawing.Size(75, 23);
			this.btnTaiDuLieu.TabIndex = 6;
			this.btnTaiDuLieu.Text = "Tải dữ liệu";
			this.btnTaiDuLieu.UseVisualStyleBackColor = true;
			this.cbChonNgay.FormattingEnabled = true;
			this.cbChonNgay.Location = new global::System.Drawing.Point(273, 8);
			this.cbChonNgay.Name = "cbChonNgay";
			this.cbChonNgay.Size = new global::System.Drawing.Size(18, 23);
			this.cbChonNgay.TabIndex = 5;
			this.cbNgayThang2.FormattingEnabled = true;
			this.cbNgayThang2.Location = new global::System.Drawing.Point(176, 8);
			this.cbNgayThang2.Name = "cbNgayThang2";
			this.cbNgayThang2.Size = new global::System.Drawing.Size(91, 23);
			this.cbNgayThang2.TabIndex = 4;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(137, 11);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(33, 15);
			this.label15.TabIndex = 3;
			this.label15.Text = "Đến:";
			this.cbNgayThang1.FormattingEnabled = true;
			this.cbNgayThang1.Location = new global::System.Drawing.Point(36, 8);
			this.cbNgayThang1.Name = "cbNgayThang1";
			this.cbNgayThang1.Size = new global::System.Drawing.Size(91, 23);
			this.cbNgayThang1.TabIndex = 2;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(6, 11);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(24, 15);
			this.label14.TabIndex = 1;
			this.label14.Text = "Từ:";
			this.dgvQuanLyBanHang.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvQuanLyBanHang.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuanLyBanHang.Location = new global::System.Drawing.Point(3, 41);
			this.dgvQuanLyBanHang.Name = "dgvQuanLyBanHang";
			this.dgvQuanLyBanHang.Size = new global::System.Drawing.Size(328, 580);
			this.dgvQuanLyBanHang.TabIndex = 0;
			this.tabDanhMucMatHang.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			this.tabDanhMucMatHang.Controls.Add(this.tabControl6);
			this.tabDanhMucMatHang.Controls.Add(this.tabControl5);
			this.tabDanhMucMatHang.Location = new global::System.Drawing.Point(4, 24);
			this.tabDanhMucMatHang.Name = "tabDanhMucMatHang";
			this.tabDanhMucMatHang.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabDanhMucMatHang.Size = new global::System.Drawing.Size(1159, 627);
			this.tabDanhMucMatHang.TabIndex = 2;
			this.tabDanhMucMatHang.Text = "Danh mục mặt hàng";
			this.tabControl6.Controls.Add(this.tabPage7);
			this.tabControl6.Location = new global::System.Drawing.Point(283, 3);
			this.tabControl6.Name = "tabControl6";
			this.tabControl6.SelectedIndex = 0;
			this.tabControl6.Size = new global::System.Drawing.Size(870, 618);
			this.tabControl6.TabIndex = 1;
			this.tabPage7.Controls.Add(this.dgvMenuDMMH);
			this.tabPage7.Controls.Add(this.btnInMaVachDMMH);
			this.tabPage7.Controls.Add(this.btnInDMMH);
			this.tabPage7.Controls.Add(this.btnNhapDLDMMH);
			this.tabPage7.Controls.Add(this.btnXuatExcelDMMH);
			this.tabPage7.Controls.Add(this.btnThemExcelDMMH);
			this.tabPage7.Controls.Add(this.btnXoaDMMH);
			this.tabPage7.Controls.Add(this.btnChinhSuaDMMH);
			this.tabPage7.Controls.Add(this.btnThemMoiDMMH);
			this.tabPage7.Controls.Add(this.txtFilter);
			this.tabPage7.Controls.Add(this.btnLocDMMH);
			this.tabPage7.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new global::System.Drawing.Size(862, 590);
			this.tabPage7.TabIndex = 0;
			this.tabPage7.Text = "Mặt hàng";
			this.tabPage7.UseVisualStyleBackColor = true;
			this.dgvMenuDMMH.AllowUserToAddRows = false;
			this.dgvMenuDMMH.AllowUserToDeleteRows = false;
			this.dgvMenuDMMH.AllowUserToResizeRows = false;
			this.dgvMenuDMMH.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvMenuDMMH.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvMenuDMMH.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMenuDMMH.Location = new global::System.Drawing.Point(6, 32);
			this.dgvMenuDMMH.MultiSelect = false;
			this.dgvMenuDMMH.Name = "dgvMenuDMMH";
			this.dgvMenuDMMH.ReadOnly = true;
			this.dgvMenuDMMH.RowHeadersVisible = false;
			this.dgvMenuDMMH.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvMenuDMMH.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMenuDMMH.Size = new global::System.Drawing.Size(856, 555);
			this.dgvMenuDMMH.TabIndex = 13;
			this.dgvMenuDMMH.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenuDMMH_CellDoubleClick);
			this.dgvMenuDMMH.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMenuDMMH_CellMouseClick);
			this.btnInMaVachDMMH.Location = new global::System.Drawing.Point(703, 3);
			this.btnInMaVachDMMH.Name = "btnInMaVachDMMH";
			this.btnInMaVachDMMH.Size = new global::System.Drawing.Size(75, 23);
			this.btnInMaVachDMMH.TabIndex = 12;
			this.btnInMaVachDMMH.Text = "In mã vạch";
			this.btnInMaVachDMMH.UseVisualStyleBackColor = true;
			this.btnInDMMH.Location = new global::System.Drawing.Point(662, 3);
			this.btnInDMMH.Name = "btnInDMMH";
			this.btnInDMMH.Size = new global::System.Drawing.Size(42, 23);
			this.btnInDMMH.TabIndex = 11;
			this.btnInDMMH.Text = "In";
			this.btnInDMMH.UseVisualStyleBackColor = true;
			this.btnNhapDLDMMH.Location = new global::System.Drawing.Point(553, 3);
			this.btnNhapDLDMMH.Name = "btnNhapDLDMMH";
			this.btnNhapDLDMMH.Size = new global::System.Drawing.Size(110, 23);
			this.btnNhapDLDMMH.TabIndex = 10;
			this.btnNhapDLDMMH.Text = "Nhập định lượng";
			this.btnNhapDLDMMH.UseVisualStyleBackColor = true;
			this.btnXuatExcelDMMH.Location = new global::System.Drawing.Point(475, 3);
			this.btnXuatExcelDMMH.Name = "btnXuatExcelDMMH";
			this.btnXuatExcelDMMH.Size = new global::System.Drawing.Size(79, 23);
			this.btnXuatExcelDMMH.TabIndex = 9;
			this.btnXuatExcelDMMH.Text = "Xuất Excel";
			this.btnXuatExcelDMMH.UseVisualStyleBackColor = true;
			this.btnThemExcelDMMH.Location = new global::System.Drawing.Point(396, 3);
			this.btnThemExcelDMMH.Name = "btnThemExcelDMMH";
			this.btnThemExcelDMMH.Size = new global::System.Drawing.Size(80, 23);
			this.btnThemExcelDMMH.TabIndex = 8;
			this.btnThemExcelDMMH.Text = "Thêm Excel";
			this.btnThemExcelDMMH.UseVisualStyleBackColor = true;
			this.btnXoaDMMH.Location = new global::System.Drawing.Point(322, 3);
			this.btnXoaDMMH.Name = "btnXoaDMMH";
			this.btnXoaDMMH.Size = new global::System.Drawing.Size(75, 23);
			this.btnXoaDMMH.TabIndex = 7;
			this.btnXoaDMMH.Text = "Xóa";
			this.btnXoaDMMH.UseVisualStyleBackColor = true;
			this.btnXoaDMMH.Click += new global::System.EventHandler(this.btnXoaDMMH_Click);
			this.btnChinhSuaDMMH.Location = new global::System.Drawing.Point(248, 3);
			this.btnChinhSuaDMMH.Name = "btnChinhSuaDMMH";
			this.btnChinhSuaDMMH.Size = new global::System.Drawing.Size(75, 23);
			this.btnChinhSuaDMMH.TabIndex = 6;
			this.btnChinhSuaDMMH.Text = "Chỉnh sửa";
			this.btnChinhSuaDMMH.UseVisualStyleBackColor = true;
			this.btnChinhSuaDMMH.Click += new global::System.EventHandler(this.btnChinhSuaDMMH_Click);
			this.btnThemMoiDMMH.Location = new global::System.Drawing.Point(174, 3);
			this.btnThemMoiDMMH.Name = "btnThemMoiDMMH";
			this.btnThemMoiDMMH.Size = new global::System.Drawing.Size(75, 23);
			this.btnThemMoiDMMH.TabIndex = 5;
			this.btnThemMoiDMMH.Text = "Thêm mới";
			this.btnThemMoiDMMH.UseVisualStyleBackColor = true;
			this.btnThemMoiDMMH.Click += new global::System.EventHandler(this.btnThemMoiDMMH_Click);
			this.txtFilter.Location = new global::System.Drawing.Point(68, 4);
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new global::System.Drawing.Size(100, 21);
			this.txtFilter.TabIndex = 4;
			this.txtFilter.TextChanged += new global::System.EventHandler(this.txtFilter_TextChanged);
			this.btnLocDMMH.Location = new global::System.Drawing.Point(6, 3);
			this.btnLocDMMH.Name = "btnLocDMMH";
			this.btnLocDMMH.Size = new global::System.Drawing.Size(56, 23);
			this.btnLocDMMH.TabIndex = 3;
			this.btnLocDMMH.Text = "Lọc";
			this.btnLocDMMH.UseVisualStyleBackColor = true;
			this.btnLocDMMH.Click += new global::System.EventHandler(this.btnLocDMMH_Click);
			this.tabControl5.Controls.Add(this.tabPage6);
			this.tabControl5.Location = new global::System.Drawing.Point(3, 3);
			this.tabControl5.Name = "tabControl5";
			this.tabControl5.SelectedIndex = 0;
			this.tabControl5.Size = new global::System.Drawing.Size(274, 618);
			this.tabControl5.TabIndex = 0;
			this.tabPage6.Controls.Add(this.btnDelDMMH);
			this.tabPage6.Controls.Add(this.lstViewDMMH);
			this.tabPage6.Controls.Add(this.btnCaiDat);
			this.tabPage6.Controls.Add(this.btnLoadDMMH);
			this.tabPage6.Controls.Add(this.btnEditDMMH);
			this.tabPage6.Controls.Add(this.btnAddDMMH);
			this.tabPage6.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new global::System.Drawing.Size(266, 590);
			this.tabPage6.TabIndex = 0;
			this.tabPage6.Text = "Nhóm mặt hàng";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.btnDelDMMH.Location = new global::System.Drawing.Point(70, 3);
			this.btnDelDMMH.Name = "btnDelDMMH";
			this.btnDelDMMH.Size = new global::System.Drawing.Size(41, 23);
			this.btnDelDMMH.TabIndex = 16;
			this.btnDelDMMH.Text = "Xóa";
			this.btnDelDMMH.UseVisualStyleBackColor = true;
			this.btnDelDMMH.Click += new global::System.EventHandler(this.btnDelDMMH_Click);
			this.lstViewDMMH.ContextMenuStrip = this.contextMenuStrip1;
			this.lstViewDMMH.Location = new global::System.Drawing.Point(3, 32);
			this.lstViewDMMH.Name = "lstViewDMMH";
			this.lstViewDMMH.Size = new global::System.Drawing.Size(260, 555);
			this.lstViewDMMH.TabIndex = 15;
			this.lstViewDMMH.UseCompatibleStateImageBehavior = false;
			this.lstViewDMMH.ItemActivate += new global::System.EventHandler(this.lstViewDMMH_ItemActivate);
			this.lstViewDMMH.SelectedIndexChanged += new global::System.EventHandler(this.lstViewDMMH_SelectedIndexChanged);
			this.lstViewDMMH.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lstViewDMMH_MouseClick);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmEditItem,
				this.cmDel,
				this.cmRefresh
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(128, 70);
			this.cmEditItem.Name = "cmEditItem";
			this.cmEditItem.Size = new global::System.Drawing.Size(127, 22);
			this.cmEditItem.Text = "Chỉnh sửa";
			this.cmEditItem.Click += new global::System.EventHandler(this.cmEditItem_Click);
			this.cmDel.Name = "cmDel";
			this.cmDel.Size = new global::System.Drawing.Size(127, 22);
			this.cmDel.Text = "Xóa";
			this.cmDel.Click += new global::System.EventHandler(this.cmDel_Click);
			this.cmRefresh.Name = "cmRefresh";
			this.cmRefresh.Size = new global::System.Drawing.Size(127, 22);
			this.cmRefresh.Text = "Refresh";
			this.cmRefresh.Click += new global::System.EventHandler(this.cmRefresh_Click);
			this.btnCaiDat.Location = new global::System.Drawing.Point(185, 3);
			this.btnCaiDat.Name = "btnCaiDat";
			this.btnCaiDat.Size = new global::System.Drawing.Size(75, 23);
			this.btnCaiDat.TabIndex = 1;
			this.btnCaiDat.Text = "Cài đặt";
			this.btnCaiDat.UseVisualStyleBackColor = true;
			this.btnCaiDat.Click += new global::System.EventHandler(this.btnCaiDat_Click);
			this.btnLoadDMMH.Location = new global::System.Drawing.Point(110, 3);
			this.btnLoadDMMH.Name = "btnLoadDMMH";
			this.btnLoadDMMH.Size = new global::System.Drawing.Size(76, 23);
			this.btnLoadDMMH.TabIndex = 4;
			this.btnLoadDMMH.Text = "Tải dữ liệu";
			this.btnLoadDMMH.UseVisualStyleBackColor = true;
			this.btnLoadDMMH.Click += new global::System.EventHandler(this.btnLoadDMMH_Click);
			this.btnEditDMMH.Location = new global::System.Drawing.Point(30, 3);
			this.btnEditDMMH.Name = "btnEditDMMH";
			this.btnEditDMMH.Size = new global::System.Drawing.Size(41, 23);
			this.btnEditDMMH.TabIndex = 3;
			this.btnEditDMMH.Text = "Sửa";
			this.btnEditDMMH.UseVisualStyleBackColor = true;
			this.btnEditDMMH.Click += new global::System.EventHandler(this.btnEditDMMH_Click);
			this.btnAddDMMH.Location = new global::System.Drawing.Point(3, 3);
			this.btnAddDMMH.Name = "btnAddDMMH";
			this.btnAddDMMH.Size = new global::System.Drawing.Size(28, 23);
			this.btnAddDMMH.TabIndex = 2;
			this.btnAddDMMH.Text = "+";
			this.btnAddDMMH.UseVisualStyleBackColor = true;
			this.btnAddDMMH.Click += new global::System.EventHandler(this.btnAddDMMH_Click);
			this.tabDanhMucBanKhuVuc.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			this.tabDanhMucBanKhuVuc.Controls.Add(this.tabControl9);
			this.tabDanhMucBanKhuVuc.Controls.Add(this.tabControl8);
			this.tabDanhMucBanKhuVuc.Location = new global::System.Drawing.Point(4, 24);
			this.tabDanhMucBanKhuVuc.Name = "tabDanhMucBanKhuVuc";
			this.tabDanhMucBanKhuVuc.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabDanhMucBanKhuVuc.Size = new global::System.Drawing.Size(1159, 627);
			this.tabDanhMucBanKhuVuc.TabIndex = 3;
			this.tabDanhMucBanKhuVuc.Text = "Danh mục bàn khu vực";
			this.tabControl9.Controls.Add(this.tabPage5);
			this.tabControl9.Location = new global::System.Drawing.Point(283, 3);
			this.tabControl9.Name = "tabControl9";
			this.tabControl9.SelectedIndex = 0;
			this.tabControl9.Size = new global::System.Drawing.Size(870, 618);
			this.tabControl9.TabIndex = 2;
			this.tabPage5.Controls.Add(this.dgvBanKhuVuc);
			this.tabPage5.Controls.Add(this.btnTableSum);
			this.tabPage5.Controls.Add(this.btnTableIn);
			this.tabPage5.Controls.Add(this.btnXuatExcel);
			this.tabPage5.Controls.Add(this.btnTableThemExcel);
			this.tabPage5.Controls.Add(this.btnTableXoa);
			this.tabPage5.Controls.Add(this.btnTableChinhSua);
			this.tabPage5.Controls.Add(this.btnTableThemMoi);
			this.tabPage5.Controls.Add(this.txtTableLoc);
			this.tabPage5.Controls.Add(this.btnTableLoc);
			this.tabPage5.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new global::System.Drawing.Size(862, 590);
			this.tabPage5.TabIndex = 0;
			this.tabPage5.Text = "Bàn";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.dgvBanKhuVuc.AllowUserToAddRows = false;
			this.dgvBanKhuVuc.AllowUserToDeleteRows = false;
			this.dgvBanKhuVuc.AllowUserToResizeRows = false;
			this.dgvBanKhuVuc.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBanKhuVuc.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBanKhuVuc.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBanKhuVuc.Location = new global::System.Drawing.Point(6, 32);
			this.dgvBanKhuVuc.MultiSelect = false;
			this.dgvBanKhuVuc.Name = "dgvBanKhuVuc";
			this.dgvBanKhuVuc.ReadOnly = true;
			this.dgvBanKhuVuc.RowHeadersVisible = false;
			this.dgvBanKhuVuc.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvBanKhuVuc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBanKhuVuc.Size = new global::System.Drawing.Size(856, 555);
			this.dgvBanKhuVuc.TabIndex = 13;
			this.dgvBanKhuVuc.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanKhuVuc_CellDoubleClick);
			this.dgvBanKhuVuc.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBanKhuVuc_CellMouseClick);
			this.btnTableSum.Location = new global::System.Drawing.Point(594, 3);
			this.btnTableSum.Name = "btnTableSum";
			this.btnTableSum.Size = new global::System.Drawing.Size(75, 23);
			this.btnTableSum.TabIndex = 12;
			this.btnTableSum.Text = "Tổng";
			this.btnTableSum.UseVisualStyleBackColor = true;
			this.btnTableIn.Location = new global::System.Drawing.Point(553, 3);
			this.btnTableIn.Name = "btnTableIn";
			this.btnTableIn.Size = new global::System.Drawing.Size(42, 23);
			this.btnTableIn.TabIndex = 11;
			this.btnTableIn.Text = "In";
			this.btnTableIn.UseVisualStyleBackColor = true;
			this.btnXuatExcel.Location = new global::System.Drawing.Point(475, 3);
			this.btnXuatExcel.Name = "btnXuatExcel";
			this.btnXuatExcel.Size = new global::System.Drawing.Size(79, 23);
			this.btnXuatExcel.TabIndex = 9;
			this.btnXuatExcel.Text = "Xuất Excel";
			this.btnXuatExcel.UseVisualStyleBackColor = true;
			this.btnTableThemExcel.Location = new global::System.Drawing.Point(396, 3);
			this.btnTableThemExcel.Name = "btnTableThemExcel";
			this.btnTableThemExcel.Size = new global::System.Drawing.Size(80, 23);
			this.btnTableThemExcel.TabIndex = 8;
			this.btnTableThemExcel.Text = "Thêm Excel";
			this.btnTableThemExcel.UseVisualStyleBackColor = true;
			this.btnTableXoa.Location = new global::System.Drawing.Point(322, 3);
			this.btnTableXoa.Name = "btnTableXoa";
			this.btnTableXoa.Size = new global::System.Drawing.Size(75, 23);
			this.btnTableXoa.TabIndex = 7;
			this.btnTableXoa.Text = "Xóa";
			this.btnTableXoa.UseVisualStyleBackColor = true;
			this.btnTableXoa.Click += new global::System.EventHandler(this.btnTableXoa_Click);
			this.btnTableChinhSua.Location = new global::System.Drawing.Point(248, 3);
			this.btnTableChinhSua.Name = "btnTableChinhSua";
			this.btnTableChinhSua.Size = new global::System.Drawing.Size(75, 23);
			this.btnTableChinhSua.TabIndex = 6;
			this.btnTableChinhSua.Text = "Chỉnh sửa";
			this.btnTableChinhSua.UseVisualStyleBackColor = true;
			this.btnTableChinhSua.Click += new global::System.EventHandler(this.btnTableChinhSua_Click);
			this.btnTableThemMoi.Location = new global::System.Drawing.Point(174, 3);
			this.btnTableThemMoi.Name = "btnTableThemMoi";
			this.btnTableThemMoi.Size = new global::System.Drawing.Size(75, 23);
			this.btnTableThemMoi.TabIndex = 5;
			this.btnTableThemMoi.Text = "Thêm mới";
			this.btnTableThemMoi.UseVisualStyleBackColor = true;
			this.btnTableThemMoi.Click += new global::System.EventHandler(this.btnTableThemMoi_Click);
			this.txtTableLoc.Location = new global::System.Drawing.Point(68, 4);
			this.txtTableLoc.Name = "txtTableLoc";
			this.txtTableLoc.Size = new global::System.Drawing.Size(100, 21);
			this.txtTableLoc.TabIndex = 4;
			this.txtTableLoc.TextChanged += new global::System.EventHandler(this.txtTableLoc_TextChanged);
			this.btnTableLoc.Location = new global::System.Drawing.Point(6, 3);
			this.btnTableLoc.Name = "btnTableLoc";
			this.btnTableLoc.Size = new global::System.Drawing.Size(56, 23);
			this.btnTableLoc.TabIndex = 3;
			this.btnTableLoc.Text = "Lọc";
			this.btnTableLoc.UseVisualStyleBackColor = true;
			this.btnTableLoc.Click += new global::System.EventHandler(this.btnTableLoc_Click);
			this.tabControl8.Controls.Add(this.tabPage10);
			this.tabControl8.Location = new global::System.Drawing.Point(3, 3);
			this.tabControl8.Name = "tabControl8";
			this.tabControl8.SelectedIndex = 0;
			this.tabControl8.Size = new global::System.Drawing.Size(274, 618);
			this.tabControl8.TabIndex = 1;
			this.tabPage10.Controls.Add(this.btnAreaXoa);
			this.tabPage10.Controls.Add(this.lstViewBanKhuVuc);
			this.tabPage10.Controls.Add(this.btnAreaCaiDat);
			this.tabPage10.Controls.Add(this.btnAreaTaiDuLieu);
			this.tabPage10.Controls.Add(this.btnAreaChinhSua);
			this.tabPage10.Controls.Add(this.btnAreaThemMoi);
			this.tabPage10.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage10.Size = new global::System.Drawing.Size(266, 590);
			this.tabPage10.TabIndex = 0;
			this.tabPage10.Text = "Khu vực";
			this.tabPage10.UseVisualStyleBackColor = true;
			this.btnAreaXoa.Location = new global::System.Drawing.Point(70, 3);
			this.btnAreaXoa.Name = "btnAreaXoa";
			this.btnAreaXoa.Size = new global::System.Drawing.Size(41, 23);
			this.btnAreaXoa.TabIndex = 16;
			this.btnAreaXoa.Text = "Xóa";
			this.btnAreaXoa.UseVisualStyleBackColor = true;
			this.btnAreaXoa.Click += new global::System.EventHandler(this.btnAreaXoa_Click);
			this.lstViewBanKhuVuc.ContextMenuStrip = this.contextMenuStrip1;
			this.lstViewBanKhuVuc.Location = new global::System.Drawing.Point(3, 32);
			this.lstViewBanKhuVuc.Name = "lstViewBanKhuVuc";
			this.lstViewBanKhuVuc.Size = new global::System.Drawing.Size(260, 555);
			this.lstViewBanKhuVuc.TabIndex = 15;
			this.lstViewBanKhuVuc.UseCompatibleStateImageBehavior = false;
			this.lstViewBanKhuVuc.ItemActivate += new global::System.EventHandler(this.lstViewBanKhuVuc_ItemActivate);
			this.lstViewBanKhuVuc.SelectedIndexChanged += new global::System.EventHandler(this.lstViewBanKhuVuc_SelectedIndexChanged);
			this.lstViewBanKhuVuc.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lstViewBanKhuVuc_MouseClick);
			this.btnAreaCaiDat.Location = new global::System.Drawing.Point(185, 3);
			this.btnAreaCaiDat.Name = "btnAreaCaiDat";
			this.btnAreaCaiDat.Size = new global::System.Drawing.Size(75, 23);
			this.btnAreaCaiDat.TabIndex = 1;
			this.btnAreaCaiDat.Text = "Cài đặt";
			this.btnAreaCaiDat.UseVisualStyleBackColor = true;
			this.btnAreaTaiDuLieu.Location = new global::System.Drawing.Point(110, 3);
			this.btnAreaTaiDuLieu.Name = "btnAreaTaiDuLieu";
			this.btnAreaTaiDuLieu.Size = new global::System.Drawing.Size(76, 23);
			this.btnAreaTaiDuLieu.TabIndex = 4;
			this.btnAreaTaiDuLieu.Text = "Tải dữ liệu";
			this.btnAreaTaiDuLieu.UseVisualStyleBackColor = true;
			this.btnAreaTaiDuLieu.Click += new global::System.EventHandler(this.btnAreaTaiDuLieu_Click);
			this.btnAreaChinhSua.Location = new global::System.Drawing.Point(30, 3);
			this.btnAreaChinhSua.Name = "btnAreaChinhSua";
			this.btnAreaChinhSua.Size = new global::System.Drawing.Size(41, 23);
			this.btnAreaChinhSua.TabIndex = 3;
			this.btnAreaChinhSua.Text = "Sửa";
			this.btnAreaChinhSua.UseVisualStyleBackColor = true;
			this.btnAreaChinhSua.Click += new global::System.EventHandler(this.btnAreaChinhSua_Click);
			this.btnAreaThemMoi.Location = new global::System.Drawing.Point(3, 3);
			this.btnAreaThemMoi.Name = "btnAreaThemMoi";
			this.btnAreaThemMoi.Size = new global::System.Drawing.Size(28, 23);
			this.btnAreaThemMoi.TabIndex = 2;
			this.btnAreaThemMoi.Text = "+";
			this.btnAreaThemMoi.UseVisualStyleBackColor = true;
			this.btnAreaThemMoi.Click += new global::System.EventHandler(this.btnAreaThemMoi_Click);
			this.tabDanhMucKhachHang.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			this.tabDanhMucKhachHang.Controls.Add(this.tabControlKhachHang);
			this.tabDanhMucKhachHang.Controls.Add(this.tabControlNhomKhachHang);
			this.tabDanhMucKhachHang.Location = new global::System.Drawing.Point(4, 24);
			this.tabDanhMucKhachHang.Name = "tabDanhMucKhachHang";
			this.tabDanhMucKhachHang.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabDanhMucKhachHang.Size = new global::System.Drawing.Size(1159, 627);
			this.tabDanhMucKhachHang.TabIndex = 4;
			this.tabDanhMucKhachHang.Text = "Danh mục khách hàng";
			this.tabControlKhachHang.Controls.Add(this.tabPage13);
			this.tabControlKhachHang.Location = new global::System.Drawing.Point(284, 4);
			this.tabControlKhachHang.Name = "tabControlKhachHang";
			this.tabControlKhachHang.SelectedIndex = 0;
			this.tabControlKhachHang.Size = new global::System.Drawing.Size(870, 618);
			this.tabControlKhachHang.TabIndex = 4;
			this.tabPage13.Controls.Add(this.dgvKhachHang);
			this.tabPage13.Controls.Add(this.btnKhachHangPrint);
			this.tabPage13.Controls.Add(this.btnKhachHangExportExcel);
			this.tabPage13.Controls.Add(this.btnKhachHangImportExcel);
			this.tabPage13.Controls.Add(this.btnKhachHangDel);
			this.tabPage13.Controls.Add(this.btnKhachHangEdit);
			this.tabPage13.Controls.Add(this.btnKhachHangAdd);
			this.tabPage13.Controls.Add(this.txtKhachHangFilter);
			this.tabPage13.Controls.Add(this.btnKhachHangFilter);
			this.tabPage13.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new global::System.Drawing.Size(862, 590);
			this.tabPage13.TabIndex = 0;
			this.tabPage13.Text = "Khách hàng";
			this.tabPage13.UseVisualStyleBackColor = true;
			this.dgvKhachHang.AllowUserToAddRows = false;
			this.dgvKhachHang.AllowUserToDeleteRows = false;
			this.dgvKhachHang.AllowUserToResizeRows = false;
			this.dgvKhachHang.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvKhachHang.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvKhachHang.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhachHang.Location = new global::System.Drawing.Point(6, 32);
			this.dgvKhachHang.MultiSelect = false;
			this.dgvKhachHang.Name = "dgvKhachHang";
			this.dgvKhachHang.ReadOnly = true;
			this.dgvKhachHang.RowHeadersVisible = false;
			this.dgvKhachHang.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvKhachHang.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvKhachHang.Size = new global::System.Drawing.Size(856, 555);
			this.dgvKhachHang.TabIndex = 13;
			this.dgvKhachHang.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
			this.dgvKhachHang.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhachHang_CellMouseClick);
			this.btnKhachHangPrint.Location = new global::System.Drawing.Point(553, 3);
			this.btnKhachHangPrint.Name = "btnKhachHangPrint";
			this.btnKhachHangPrint.Size = new global::System.Drawing.Size(42, 23);
			this.btnKhachHangPrint.TabIndex = 11;
			this.btnKhachHangPrint.Text = "In";
			this.btnKhachHangPrint.UseVisualStyleBackColor = true;
			this.btnKhachHangExportExcel.Location = new global::System.Drawing.Point(475, 3);
			this.btnKhachHangExportExcel.Name = "btnKhachHangExportExcel";
			this.btnKhachHangExportExcel.Size = new global::System.Drawing.Size(79, 23);
			this.btnKhachHangExportExcel.TabIndex = 9;
			this.btnKhachHangExportExcel.Text = "Xuất Excel";
			this.btnKhachHangExportExcel.UseVisualStyleBackColor = true;
			this.btnKhachHangImportExcel.Location = new global::System.Drawing.Point(396, 3);
			this.btnKhachHangImportExcel.Name = "btnKhachHangImportExcel";
			this.btnKhachHangImportExcel.Size = new global::System.Drawing.Size(80, 23);
			this.btnKhachHangImportExcel.TabIndex = 8;
			this.btnKhachHangImportExcel.Text = "Thêm Excel";
			this.btnKhachHangImportExcel.UseVisualStyleBackColor = true;
			this.btnKhachHangDel.Location = new global::System.Drawing.Point(322, 3);
			this.btnKhachHangDel.Name = "btnKhachHangDel";
			this.btnKhachHangDel.Size = new global::System.Drawing.Size(75, 23);
			this.btnKhachHangDel.TabIndex = 7;
			this.btnKhachHangDel.Text = "Xóa";
			this.btnKhachHangDel.UseVisualStyleBackColor = true;
			this.btnKhachHangDel.Click += new global::System.EventHandler(this.btnKhachHangDel_Click);
			this.btnKhachHangEdit.Location = new global::System.Drawing.Point(248, 3);
			this.btnKhachHangEdit.Name = "btnKhachHangEdit";
			this.btnKhachHangEdit.Size = new global::System.Drawing.Size(75, 23);
			this.btnKhachHangEdit.TabIndex = 6;
			this.btnKhachHangEdit.Text = "Chỉnh sửa";
			this.btnKhachHangEdit.UseVisualStyleBackColor = true;
			this.btnKhachHangEdit.Click += new global::System.EventHandler(this.btnKhachHangEdit_Click);
			this.btnKhachHangAdd.Location = new global::System.Drawing.Point(174, 3);
			this.btnKhachHangAdd.Name = "btnKhachHangAdd";
			this.btnKhachHangAdd.Size = new global::System.Drawing.Size(75, 23);
			this.btnKhachHangAdd.TabIndex = 5;
			this.btnKhachHangAdd.Text = "Thêm mới";
			this.btnKhachHangAdd.UseVisualStyleBackColor = true;
			this.btnKhachHangAdd.Click += new global::System.EventHandler(this.btnKhachHangAdd_Click);
			this.txtKhachHangFilter.Location = new global::System.Drawing.Point(68, 4);
			this.txtKhachHangFilter.Name = "txtKhachHangFilter";
			this.txtKhachHangFilter.Size = new global::System.Drawing.Size(100, 21);
			this.txtKhachHangFilter.TabIndex = 4;
			this.txtKhachHangFilter.TextChanged += new global::System.EventHandler(this.txtKhachHangFilter_TextChanged);
			this.btnKhachHangFilter.Location = new global::System.Drawing.Point(6, 3);
			this.btnKhachHangFilter.Name = "btnKhachHangFilter";
			this.btnKhachHangFilter.Size = new global::System.Drawing.Size(56, 23);
			this.btnKhachHangFilter.TabIndex = 3;
			this.btnKhachHangFilter.Text = "Lọc";
			this.btnKhachHangFilter.UseVisualStyleBackColor = true;
			this.btnKhachHangFilter.Click += new global::System.EventHandler(this.btnKhachHangFilter_Click);
			this.tabControlNhomKhachHang.Controls.Add(this.tabPageNhomKhachHang);
			this.tabControlNhomKhachHang.Location = new global::System.Drawing.Point(4, 4);
			this.tabControlNhomKhachHang.Name = "tabControlNhomKhachHang";
			this.tabControlNhomKhachHang.SelectedIndex = 0;
			this.tabControlNhomKhachHang.Size = new global::System.Drawing.Size(274, 618);
			this.tabControlNhomKhachHang.TabIndex = 3;
			this.tabPageNhomKhachHang.Controls.Add(this.btnNhomKhachHangDel);
			this.tabPageNhomKhachHang.Controls.Add(this.lstViewNhomKhachHang);
			this.tabPageNhomKhachHang.Controls.Add(this.btnNhomKhachHangSetting);
			this.tabPageNhomKhachHang.Controls.Add(this.btnNhomKhachHangLoad);
			this.tabPageNhomKhachHang.Controls.Add(this.btnNhomKhachHangEdit);
			this.tabPageNhomKhachHang.Controls.Add(this.btnNhomKhachHangAdd);
			this.tabPageNhomKhachHang.Location = new global::System.Drawing.Point(4, 24);
			this.tabPageNhomKhachHang.Name = "tabPageNhomKhachHang";
			this.tabPageNhomKhachHang.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageNhomKhachHang.Size = new global::System.Drawing.Size(266, 590);
			this.tabPageNhomKhachHang.TabIndex = 0;
			this.tabPageNhomKhachHang.Text = "Nhóm khách hàng";
			this.tabPageNhomKhachHang.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangDel.Location = new global::System.Drawing.Point(70, 3);
			this.btnNhomKhachHangDel.Name = "btnNhomKhachHangDel";
			this.btnNhomKhachHangDel.Size = new global::System.Drawing.Size(41, 23);
			this.btnNhomKhachHangDel.TabIndex = 16;
			this.btnNhomKhachHangDel.Text = "Xóa";
			this.btnNhomKhachHangDel.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangDel.Click += new global::System.EventHandler(this.btnNhomKhachHangDel_Click);
			this.lstViewNhomKhachHang.ContextMenuStrip = this.contextMenuStrip1;
			this.lstViewNhomKhachHang.Location = new global::System.Drawing.Point(3, 32);
			this.lstViewNhomKhachHang.Name = "lstViewNhomKhachHang";
			this.lstViewNhomKhachHang.Size = new global::System.Drawing.Size(260, 555);
			this.lstViewNhomKhachHang.TabIndex = 15;
			this.lstViewNhomKhachHang.UseCompatibleStateImageBehavior = false;
			this.lstViewNhomKhachHang.ItemActivate += new global::System.EventHandler(this.lstViewNhomKhachHang_ItemActivate);
			this.lstViewNhomKhachHang.SelectedIndexChanged += new global::System.EventHandler(this.lstViewNhomKhachHang_SelectedIndexChanged);
			this.lstViewNhomKhachHang.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lstViewNhomKhachHang_MouseClick);
			this.btnNhomKhachHangSetting.Location = new global::System.Drawing.Point(185, 3);
			this.btnNhomKhachHangSetting.Name = "btnNhomKhachHangSetting";
			this.btnNhomKhachHangSetting.Size = new global::System.Drawing.Size(75, 23);
			this.btnNhomKhachHangSetting.TabIndex = 1;
			this.btnNhomKhachHangSetting.Text = "Cài đặt";
			this.btnNhomKhachHangSetting.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangSetting.Click += new global::System.EventHandler(this.btnNhomKhachHangSetting_Click);
			this.btnNhomKhachHangLoad.Location = new global::System.Drawing.Point(110, 3);
			this.btnNhomKhachHangLoad.Name = "btnNhomKhachHangLoad";
			this.btnNhomKhachHangLoad.Size = new global::System.Drawing.Size(76, 23);
			this.btnNhomKhachHangLoad.TabIndex = 4;
			this.btnNhomKhachHangLoad.Text = "Tải dữ liệu";
			this.btnNhomKhachHangLoad.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangLoad.Click += new global::System.EventHandler(this.btnNhomKhachHangLoad_Click);
			this.btnNhomKhachHangEdit.Location = new global::System.Drawing.Point(30, 3);
			this.btnNhomKhachHangEdit.Name = "btnNhomKhachHangEdit";
			this.btnNhomKhachHangEdit.Size = new global::System.Drawing.Size(41, 23);
			this.btnNhomKhachHangEdit.TabIndex = 3;
			this.btnNhomKhachHangEdit.Text = "Sửa";
			this.btnNhomKhachHangEdit.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangEdit.Click += new global::System.EventHandler(this.btnNhomKhachHangEdit_Click);
			this.btnNhomKhachHangAdd.Location = new global::System.Drawing.Point(3, 3);
			this.btnNhomKhachHangAdd.Name = "btnNhomKhachHangAdd";
			this.btnNhomKhachHangAdd.Size = new global::System.Drawing.Size(28, 23);
			this.btnNhomKhachHangAdd.TabIndex = 2;
			this.btnNhomKhachHangAdd.Text = "+";
			this.btnNhomKhachHangAdd.UseVisualStyleBackColor = true;
			this.btnNhomKhachHangAdd.Click += new global::System.EventHandler(this.btnNhomKhachHangAdd_Click);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(209, 158);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			this.imgLstDMMH.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgLstDMMH.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgLstDMMH.TransparentColor = global::System.Drawing.Color.Transparent;
			this.contextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmCloseTab
			});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new global::System.Drawing.Size(124, 26);
			this.cmCloseTab.Name = "cmCloseTab";
			this.cmCloseTab.Size = new global::System.Drawing.Size(123, 22);
			this.cmCloseTab.Text = "Đóng tab";
			this.cmCloseTab.Click += new global::System.EventHandler(this.cmCloseTab_Click);
			this.imgListIcon.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListIcon.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgListIcon.TransparentColor = global::System.Drawing.Color.Transparent;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.timer2.Enabled = true;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1173, 723);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip2;
			this.MinimumSize = new global::System.Drawing.Size(1189, 726);
			base.Name = "frmMain";
			this.Text = "Quản lý khách sạn";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabSuDungDichVu.ResumeLayout(false);
			this.tabSuDungDichVu.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvViewMenu).EndInit();
			this.tabControl3.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvMenu).EndInit();
			this.menuStripSuDungDichVu.ResumeLayout(false);
			this.tabQuanLyBanHang.ResumeLayout(false);
			this.tabQuanLyBanHang.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgViewMenuQLBH).EndInit();
			this.tabControl4.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvQuanLyBanHang).EndInit();
			this.tabDanhMucMatHang.ResumeLayout(false);
			this.tabControl6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvMenuDMMH).EndInit();
			this.tabControl5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabDanhMucBanKhuVuc.ResumeLayout(false);
			this.tabControl9.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBanKhuVuc).EndInit();
			this.tabControl8.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabDanhMucKhachHang.ResumeLayout(false);
			this.tabControlKhachHang.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvKhachHang).EndInit();
			this.tabControlNhomKhachHang.ResumeLayout(false);
			this.tabPageNhomKhachHang.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001AD RID: 429
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.ToolStripMenuItem hoạtĐộngToolStripMenuItem;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.ToolStripMenuItem mnCustomer;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.ToolStripMenuItem mnStock;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.ToolStripMenuItem côngNợToolStripMenuItem;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.ToolStripMenuItem mnListReasonImportExport;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.ToolStripMenuItem quảnTrịToolStripMenuItem;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.ToolStripMenuItem mnChangPassword;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.ToolStripMenuItem mnLogout;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.ToolStripMenuItem mnExit;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.ToolStripMenuItem mnListMenu;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.ToolStripMenuItem mnListItems;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.ToolStripMenuItem mnListTypeRoom;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.ToolStripMenuItem mbListTableArea;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.ToolStripMenuItem mnNoticeRepair;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.ToolStripMenuItem mnUsedService;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.ToolStripMenuItem mnModifyTicket;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.ToolStripMenuItem mnManagementSales;

		// Token: 0x040001C4 RID: 452
		private global::System.Windows.Forms.ToolStripMenuItem mnSaveActive;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.ToolStripMenuItem mnRevenueStatistics;

		// Token: 0x040001C6 RID: 454
		private global::System.Windows.Forms.ToolStripMenuItem mnItemsSaleStatistics;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Forms.ToolStripMenuItem mnSummaryResultSale;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.ToolStripMenuItem mnDetailDaily;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.ToolStripMenuItem mnListDestroyTicket;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.ToolStripMenuItem mnListCustomer;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Forms.ToolStripMenuItem mnSendMsgToCustomer;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Forms.ToolStripMenuItem mnCustomerVip;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.ToolStripMenuItem mnListVendor;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.ToolStripMenuItem mnImportStock;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.ToolStripMenuItem lýDoThuChiToolStripMenuItem;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.ToolStripMenuItem mnListAccountBank;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.ToolStripMenuItem mnCreatTicketImport;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.ToolStripMenuItem mnCreateTicketExport;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.ToolStripMenuItem mnListTicketImport;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.ToolStripMenuItem mnListTicketExport;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.ToolStripMenuItem mnExist;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Forms.ToolStripMenuItem mnListEmployes;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.ToolStripMenuItem mnListShiftWorking;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.ToolStripMenuItem tạmỨngLươngToolStripMenuItem;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.ToolStripMenuItem thưởngPhạtToolStripMenuItem;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.ToolStripMenuItem tínhLươngToolStripMenuItem;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoQuỹToolStripMenuItem;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuThuTheoNgàyToolStripMenuItem;

		// Token: 0x040001DE RID: 478
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuThuTheoDanhSáchThuChiToolStripMenuItem;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuChiTheoNgàyToolStripMenuItem;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuChiTheoToolStripMenuItem;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpThuChiTheoNgàyToolStripMenuItem;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpThuChiTheoLýDoToolStripMenuItem;

		// Token: 0x040001E3 RID: 483
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoTồnQuỹToolStripMenuItem;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoDanhMụcToolStripMenuItem;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchKháchHàngTheoNhómToolStripMenuItem;

		// Token: 0x040001E6 RID: 486
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchKháchHàngTheoNhânViênToolStripMenuItem;

		// Token: 0x040001E7 RID: 487
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchNhàCungCấpTheoNhómToolStripMenuItem;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchĐợtKhuyếnMãiToolStripMenuItem;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchMặtHàngTheoNhómToolStripMenuItem;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchMặtHàngTheoHãngSảnXuấtToolStripMenuItem;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.ToolStripMenuItem kháchHàngĐếnNgàySinhNhậtToolStripMenuItem;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoKháchHàngTheoBànKhuVựcToolStripMenuItem;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.ToolStripMenuItem côngThứcĐịnhLươnhjToolStripMenuItem;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoChiTiếtPhânQuyềnHệThốngToolStripMenuItem;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngToolStripMenuItem;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánHàngTheoNgàyToolStripMenuItem;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoNgàyToolStripMenuItem;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoChiTiếtBánHàngTheoNgàyToolStripMenuItem;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpDoanhThuTheoLoạiĐồToolStripMenuItem;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpDoanhThuChưaThanhToánToolStripMenuItem;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngTheoNgàyToolStripMenuItem;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.ToolStripMenuItem theoNhânViênPhụcVụToolStripMenuItem;

		// Token: 0x040001F7 RID: 503
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánTheoNhânViênToolStripMenuItem;

		// Token: 0x040001F8 RID: 504
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoNhânViênToolStripMenuItem;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngTheoNhânViênToolStripMenuItem;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.ToolStripMenuItem theoKhuVựcToolStripMenuItem;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.ToolStripMenuItem theoThuNgânToolStripMenuItem;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.ToolStripMenuItem theoKháchHàngToolStripMenuItem;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngKhácToolStripMenuItem;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoĐặtHàngToolStripMenuItem;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoKhoHàngToolStripMenuItem;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoCôngNợToolStripMenuItem;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoQuảnTrịToolStripMenuItem;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBiểuĐồToolStripMenuItem;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.MenuStrip menuStrip2;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánHàngTheoKhuVựcToolStripMenuItem;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánHàngTheoBànPhòngToolStripMenuItem;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnTheoKhuVựcToolStripMenuItem;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnTheoBànToolStripMenuItem;

		// Token: 0x04000208 RID: 520
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoKhuVựcToolStripMenuItem;

		// Token: 0x04000209 RID: 521
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoBànToolStripMenuItem;

		// Token: 0x0400020A RID: 522
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánHàngTheoNhómHiểnThịToolStripMenuItem;

		// Token: 0x0400020B RID: 523
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnTheoNhómHiểnThịToolStripMenuItem;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngTheoNhómHiểnThịToolStripMenuItem;

		// Token: 0x0400020D RID: 525
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánTheoThuNgânToolStripMenuItem;

		// Token: 0x0400020E RID: 526
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngTheoThuNgânToolStripMenuItem;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoThuNgânToolStripMenuItem;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpMặtHàngBánTheoKháchHàngToolStripMenuItem;

		// Token: 0x04000211 RID: 529
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpBánTheoKháchHàngToolStripMenuItem;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoBánTheoKháchHàngToolStripMenuItem;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.ToolStripMenuItem tổngHợpHoaHồngTheoNVKDToolStripMenuItem;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.ToolStripMenuItem chiTiếtBánHàngTheoHóaĐơnToolStripMenuItem;

		// Token: 0x04000215 RID: 533
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoChiTiếtHàngKhuyếnMãiToolStripMenuItem;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.ToolStripMenuItem báoToolStripMenuItem;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.ToolStripMenuItem báoCáoTổngHợpSốLượngBánTheoThángToolStripMenuItem;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.ToolStripMenuItem mnUsedServiceOder;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.ToolStripMenuItem mnQuanLyBanHang;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.ToolStripMenuItem mnThongKeDoanhThu;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.ToolStripMenuItem mnThongKeMatHangBan;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.ToolStripMenuItem mnChiTietHoatDong;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.ToolStripMenuItem mnTongHopKetQuaKinhDoanh;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.ToolStripMenuItem mnTonKho;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.ToolStripMenuItem mnGhiChu;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.ToolStripMenuItem mnBaoCao;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.ToolStripMenuItem mnThoat;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.TabPage tabSuDungDichVu;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.TextBox txtSoKhachSDDV;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000229 RID: 553
		private global::System.Windows.Forms.TextBox txtSoPhieuSDDV;

		// Token: 0x0400022A RID: 554
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400022C RID: 556
		private global::System.Windows.Forms.TextBox txtCMND;

		// Token: 0x0400022D RID: 557
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Forms.TextBox txtDiaChi;

		// Token: 0x0400022F RID: 559
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.TextBox txtDienThoai;

		// Token: 0x04000231 RID: 561
		private global::System.Windows.Forms.Label lblDienThoai;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.Label lblTenKhach;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.ComboBox cbKhachHang;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Forms.Label lblKhachHang;

		// Token: 0x04000235 RID: 565
		private global::System.Windows.Forms.Label lblSoPhong;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.Label lblSoPhut;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Button btnBegin;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.TabControl tabControl3;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.TextBox txtTong;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.TextBox txtThanhTienGio;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400023E RID: 574
		private global::System.Windows.Forms.TextBox txtGiamGiaGio;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.TextBox txtThanhTienHang;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000242 RID: 578
		private global::System.Windows.Forms.TextBox txtGiamGiaHang;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.TextBox txtTienGio;

		// Token: 0x04000245 RID: 581
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000246 RID: 582
		private global::System.Windows.Forms.TextBox txtTienHang;

		// Token: 0x04000247 RID: 583
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.Button btnThongKe;

		// Token: 0x0400024A RID: 586
		private global::System.Windows.Forms.Button btnThanhToan;

		// Token: 0x0400024B RID: 587
		private global::System.Windows.Forms.Button btnInCheBien;

		// Token: 0x0400024C RID: 588
		private global::System.Windows.Forms.Button btnGiamGia;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.DataGridView dgvMenu;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.Button btnChietKhau;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.Button btnGhiChu;

		// Token: 0x04000250 RID: 592
		private global::System.Windows.Forms.Button btnDoiGia;

		// Token: 0x04000251 RID: 593
		private global::System.Windows.Forms.Button btnDatSL;

		// Token: 0x04000252 RID: 594
		private global::System.Windows.Forms.Button btnGiam;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.Button btnTang;

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Forms.Button btnXoa;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.Button btnGiamHang;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.Button btnThemHang;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.ComboBox cbSoLuong;

		// Token: 0x04000258 RID: 600
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.Button btnGopPhong;

		// Token: 0x0400025A RID: 602
		private global::System.Windows.Forms.Button btnChuyenPhong;

		// Token: 0x0400025B RID: 603
		private global::System.Windows.Forms.TabPage tabQuanLyBanHang;

		// Token: 0x0400025C RID: 604
		private global::System.Windows.Forms.TextBox txtTimKiem;

		// Token: 0x0400025D RID: 605
		private global::System.Windows.Forms.Label lblTim;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Forms.DataGridView dgvViewMenu;

		// Token: 0x0400025F RID: 607
		private global::System.Windows.Forms.ListView lstViewMenu;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04000261 RID: 609
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04000262 RID: 610
		private global::System.Windows.Forms.Label label34;

		// Token: 0x04000263 RID: 611
		private global::System.Windows.Forms.Button btnHuyPhieu;

		// Token: 0x04000264 RID: 612
		private global::System.Windows.Forms.DataGridView dtgViewMenuQLBH;

		// Token: 0x04000265 RID: 613
		private global::System.Windows.Forms.ListView lstViewQLBH;

		// Token: 0x04000266 RID: 614
		private global::System.Windows.Forms.TextBox txtTimKiemQLBH;

		// Token: 0x04000267 RID: 615
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000268 RID: 616
		private global::System.Windows.Forms.TabControl tabControl4;

		// Token: 0x04000269 RID: 617
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400026A RID: 618
		private global::System.Windows.Forms.TextBox txtTongQLBH;

		// Token: 0x0400026B RID: 619
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.TextBox txtThanhTienGioQLBH;

		// Token: 0x0400026D RID: 621
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.TextBox txtGiamGiaGioQLBH;

		// Token: 0x0400026F RID: 623
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.TextBox txtThanhTienQLBH;

		// Token: 0x04000271 RID: 625
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.Forms.TextBox txtGiamGia;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000274 RID: 628
		private global::System.Windows.Forms.TextBox txtTienGioQLBH;

		// Token: 0x04000275 RID: 629
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000276 RID: 630
		private global::System.Windows.Forms.TextBox txtTienHangQLBH;

		// Token: 0x04000277 RID: 631
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000278 RID: 632
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x04000279 RID: 633
		private global::System.Windows.Forms.Button btnThanhToanQLBH;

		// Token: 0x0400027A RID: 634
		private global::System.Windows.Forms.Button btnInLaiBill;

		// Token: 0x0400027B RID: 635
		private global::System.Windows.Forms.Button btnCKQLBH;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.Forms.DataGridView dataGridView2;

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Forms.Button btnChietKhauQLBH;

		// Token: 0x0400027E RID: 638
		private global::System.Windows.Forms.Button btnGhiChuQLBH;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Forms.Button btnDoiGiaQLBH;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Forms.Button btnDatSLQLBH;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.Forms.Button btnGiamQLBH;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.Forms.Button btnTangQLBH;

		// Token: 0x04000283 RID: 643
		private global::System.Windows.Forms.Button btnBangGiaQLBH;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.Button btnXoaQLBH;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.Button btnGiamHangQLBH;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Button btnThemQLBH;

		// Token: 0x04000287 RID: 647
		private global::System.Windows.Forms.ComboBox cbSLQLBH;

		// Token: 0x04000288 RID: 648
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.TextBox txtSoKhach;

		// Token: 0x0400028A RID: 650
		private global::System.Windows.Forms.TextBox txtSoPhieu;

		// Token: 0x0400028B RID: 651
		private global::System.Windows.Forms.TextBox txtCMNDQLBH;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.TextBox txtDiaChiQLBH;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.TextBox txtDienThoaiQLBH;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.Label label27;

		// Token: 0x04000291 RID: 657
		private global::System.Windows.Forms.TextBox txtTenKhachQLBH;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.ComboBox cbKhachHangQLBH;

		// Token: 0x04000294 RID: 660
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000295 RID: 661
		private global::System.Windows.Forms.Label lblSoPhongQLBH;

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.Label lblKhachHangQLBH;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.Button btnBeginQLBH;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Button btnTaiDuLieu;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.ComboBox cbChonNgay;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.ComboBox cbNgayThang2;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.ComboBox cbNgayThang1;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.DataGridView dgvQuanLyBanHang;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.TextBox txtGhiChu;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.TextBox txtGhiChuQLBH;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.DateTimePicker dtNgay;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.DateTimePicker dateTimePicker1;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.DateTimePicker dateTimePicker2;

		// Token: 0x040002A4 RID: 676
		private global::System.Windows.Forms.DateTimePicker dateTimePicker3;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.TabPage tabDanhMucMatHang;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Forms.Button btnCaiDat;

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Forms.TabControl tabControl5;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Forms.Button btnLoadDMMH;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.Button btnEditDMMH;

		// Token: 0x040002AB RID: 683
		private global::System.Windows.Forms.Button btnAddDMMH;

		// Token: 0x040002AC RID: 684
		private global::System.Windows.Forms.TabControl tabControl6;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Forms.TabPage tabPage7;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.Button btnInMaVachDMMH;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.Button btnInDMMH;

		// Token: 0x040002B0 RID: 688
		private global::System.Windows.Forms.Button btnNhapDLDMMH;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Forms.Button btnXuatExcelDMMH;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.Button btnThemExcelDMMH;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.Button btnXoaDMMH;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.Button btnChinhSuaDMMH;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.Button btnThemMoiDMMH;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.TextBox txtFilter;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.Button btnLocDMMH;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.ListView lstViewDMMH;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.ImageList imgLstDMMH;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.ToolStripMenuItem cmDel;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.ToolStripMenuItem cmRefresh;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.ToolStripMenuItem cmEditItem;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.Button btnDelDMMH;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.DataGridView dgvMenuDMMH;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.ToolStripMenuItem cmCloseTab;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.TabPage tabDanhMucBanKhuVuc;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.TabControl tabControl9;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.DataGridView dgvBanKhuVuc;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.Button btnTableSum;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.Button btnTableIn;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.Button btnXuatExcel;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.Button btnTableThemExcel;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.Button btnTableXoa;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.Button btnTableChinhSua;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.Button btnTableThemMoi;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.TextBox txtTableLoc;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.Button btnTableLoc;

		// Token: 0x040002CF RID: 719
		private global::System.Windows.Forms.TabControl tabControl8;

		// Token: 0x040002D0 RID: 720
		private global::System.Windows.Forms.TabPage tabPage10;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.Button btnAreaXoa;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.ListView lstViewBanKhuVuc;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.Button btnAreaCaiDat;

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Forms.Button btnAreaTaiDuLieu;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.Button btnAreaChinhSua;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.Button btnAreaThemMoi;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.ImageList imgListIcon;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.TabControl tabControlSuDungDichVu;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.ContextMenuStrip menuStripSuDungDichVu;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.ToolStripMenuItem cmPhongBan;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.ToolStripMenuItem cmBaoDon;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.ToolStripMenuItem cmDonXong;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.ToolStripMenuItem cmMoPhong;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.ToolStripMenuItem cmMoPhongTuDatTruoc;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.ToolStripMenuItem cmThanhToan;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.ToolStripMenuItem cmRefreshService;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.ToolStripMenuItem cmChuyenPhong;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.ToolStripMenuItem cmGopPhong;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.ToolStripMenuItem cmHuyHoaDon;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.TabPage tabDanhMucKhachHang;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.TabControl tabControlKhachHang;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.TabPage tabPage13;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.DataGridView dgvKhachHang;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.Button btnKhachHangPrint;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.Button btnKhachHangExportExcel;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.Button btnKhachHangImportExcel;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.Button btnKhachHangDel;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Forms.Button btnKhachHangEdit;

		// Token: 0x040002ED RID: 749
		private global::System.Windows.Forms.Button btnKhachHangAdd;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Forms.TextBox txtKhachHangFilter;

		// Token: 0x040002EF RID: 751
		private global::System.Windows.Forms.Button btnKhachHangFilter;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.Forms.TabControl tabControlNhomKhachHang;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Forms.TabPage tabPageNhomKhachHang;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Forms.Button btnNhomKhachHangDel;

		// Token: 0x040002F3 RID: 755
		private global::System.Windows.Forms.ListView lstViewNhomKhachHang;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Forms.Button btnNhomKhachHangSetting;

		// Token: 0x040002F5 RID: 757
		private global::System.Windows.Forms.Button btnNhomKhachHangLoad;

		// Token: 0x040002F6 RID: 758
		private global::System.Windows.Forms.Button btnNhomKhachHangEdit;

		// Token: 0x040002F7 RID: 759
		private global::System.Windows.Forms.Button btnNhomKhachHangAdd;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Button btnFinish;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.TextBox txtHoChieu;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.Label label31;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.ComboBox cbNhanVien;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.TextBox txtGPLX;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.Label label30;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.ComboBox cbBangGia;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.Label label35;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.DateTimePicker dtBegin;

		// Token: 0x04000301 RID: 769
		private global::System.Windows.Forms.DateTimePicker dtEnd;

		// Token: 0x04000302 RID: 770
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Forms.Timer timer2;
	}
}

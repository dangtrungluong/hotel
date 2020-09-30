namespace Hotel
{
	// Token: 0x02000003 RID: 3
	public partial class frmAddNew : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00004664 File Offset: 0x00002864
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000469C File Offset: 0x0000289C
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtTenBangGia = new global::System.Windows.Forms.TextBox();
			this.btnKiemTraBangGia = new global::System.Windows.Forms.Button();
			this.rdPhuThuGio = new global::System.Windows.Forms.RadioButton();
			this.rdPhuThuBangGia = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtNguoiLonThem = new global::System.Windows.Forms.TextBox();
			this.txtTreEmTinhThem = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtGiuongTinhThem = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.chkDonGiaCuoiTuan = new global::System.Windows.Forms.CheckBox();
			this.chkDonGiaNgayLe = new global::System.Windows.Forms.CheckBox();
			this.chkBangGiaDem = new global::System.Windows.Forms.CheckBox();
			this.chkBangGiaGio = new global::System.Windows.Forms.CheckBox();
			this.chkBangGiaNgayDem = new global::System.Windows.Forms.CheckBox();
			this.tabBangGiaDichVu = new global::System.Windows.Forms.TabControl();
			this.tabPageBangGiaGio = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaGio = new global::System.Windows.Forms.DataGridView();
			this.rdGiaNgayLe = new global::System.Windows.Forms.RadioButton();
			this.rdGiaCuoiTuan = new global::System.Windows.Forms.RadioButton();
			this.rdGiaNgayThuong = new global::System.Windows.Forms.RadioButton();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtBGGTreToiDa = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.tabPageBangGiaQuaDem = new global::System.Windows.Forms.TabPage();
			this.tabControlBangGiaQuaDem = new global::System.Windows.Forms.TabControl();
			this.tabPageDKAD = new global::System.Windows.Forms.TabPage();
			this.label20 = new global::System.Windows.Forms.Label();
			this.txtTruocGio = new global::System.Windows.Forms.TextBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.txtGioVaoSau2 = new global::System.Windows.Forms.TextBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.txtQuaGioQuaDem = new global::System.Windows.Forms.TextBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.txtGioVaoSau1 = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.tabQuaDemBangGia = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaQuaDem = new global::System.Windows.Forms.DataGridView();
			this.tabQuaDemPhuThuVaoSom = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaQuaDemPhuThuVaoSom = new global::System.Windows.Forms.DataGridView();
			this.tabQuaDemGiamTruVaoMuon = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaQuaDemGiamTruVaoMuon = new global::System.Windows.Forms.DataGridView();
			this.tabQuaDemPhuThuRaTre = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaQuaDemPhuThuRaTre = new global::System.Windows.Forms.DataGridView();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtTraPhongTruocQuaDem = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.dataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtTreToiDaQuaDem = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.tabPageBangGiaNgayDem = new global::System.Windows.Forms.TabPage();
			this.tabControlBangGiaNgayDem = new global::System.Windows.Forms.TabControl();
			this.tabNgayDemDKAD = new global::System.Windows.Forms.TabPage();
			this.chkRaSauGioTraPhong = new global::System.Windows.Forms.CheckBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.txtQuaGioNgayDem = new global::System.Windows.Forms.TextBox();
			this.label23 = new global::System.Windows.Forms.Label();
			this.chkTinhLa1Ngay = new global::System.Windows.Forms.CheckBox();
			this.tabBangGiaNgayDem = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaNgayDem = new global::System.Windows.Forms.DataGridView();
			this.tabNgayDemPhuThuVaoSom = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaNgayDemPhuThuVaoSom = new global::System.Windows.Forms.DataGridView();
			this.tabNgayDemPhuThuRaTre = new global::System.Windows.Forms.TabPage();
			this.dgvBangGiaNgayDemPhuThuRaTre = new global::System.Windows.Forms.DataGridView();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtTraPhongTruocNgayDem = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.txtTreToiDaNgayDem = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tabBangGiaDichVu.SuspendLayout();
			this.tabPageBangGiaGio.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaGio).BeginInit();
			this.tabPageBangGiaQuaDem.SuspendLayout();
			this.tabControlBangGiaQuaDem.SuspendLayout();
			this.tabPageDKAD.SuspendLayout();
			this.tabQuaDemBangGia.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDem).BeginInit();
			this.tabQuaDemPhuThuVaoSom.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemPhuThuVaoSom).BeginInit();
			this.tabQuaDemGiamTruVaoMuon.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemGiamTruVaoMuon).BeginInit();
			this.tabQuaDemPhuThuRaTre.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemPhuThuRaTre).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
			this.tabPageBangGiaNgayDem.SuspendLayout();
			this.tabControlBangGiaNgayDem.SuspendLayout();
			this.tabNgayDemDKAD.SuspendLayout();
			this.tabBangGiaNgayDem.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDem).BeginInit();
			this.tabNgayDemPhuThuVaoSom.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDemPhuThuVaoSom).BeginInit();
			this.tabNgayDemPhuThuRaTre.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDemPhuThuRaTre).BeginInit();
			base.SuspendLayout();
			this.groupBox1.BackColor = global::System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new global::System.Drawing.Point(0, -7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(1093, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new global::System.EventHandler(this.groupBox1_Enter);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(131, 39);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(172, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bảng giá dịch vụ";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pictureBox1.Image = global::Hotel.Properties.Resources.banggiadichvu;
			this.pictureBox1.Location = new global::System.Drawing.Point(8, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(117, 76);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(3, 102);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(79, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên bảng giá";
			this.txtTenBangGia.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTenBangGia.Location = new global::System.Drawing.Point(106, 99);
			this.txtTenBangGia.Name = "txtTenBangGia";
			this.txtTenBangGia.Size = new global::System.Drawing.Size(608, 21);
			this.txtTenBangGia.TabIndex = 2;
			this.btnKiemTraBangGia.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnKiemTraBangGia.Location = new global::System.Drawing.Point(925, 99);
			this.btnKiemTraBangGia.Name = "btnKiemTraBangGia";
			this.btnKiemTraBangGia.Size = new global::System.Drawing.Size(155, 36);
			this.btnKiemTraBangGia.TabIndex = 3;
			this.btnKiemTraBangGia.Text = "Kiểm tra bảng giá";
			this.btnKiemTraBangGia.UseVisualStyleBackColor = true;
			this.rdPhuThuGio.AutoSize = true;
			this.rdPhuThuGio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdPhuThuGio.Location = new global::System.Drawing.Point(106, 128);
			this.rdPhuThuGio.Name = "rdPhuThuGio";
			this.rdPhuThuGio.Size = new global::System.Drawing.Size(271, 19);
			this.rdPhuThuGio.TabIndex = 4;
			this.rdPhuThuGio.TabStop = true;
			this.rdPhuThuGio.Text = "Tính phụ thu vào sớm ra trễ theo bảng giá giờ";
			this.rdPhuThuGio.UseVisualStyleBackColor = true;
			this.rdPhuThuBangGia.AutoSize = true;
			this.rdPhuThuBangGia.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdPhuThuBangGia.Location = new global::System.Drawing.Point(419, 128);
			this.rdPhuThuBangGia.Name = "rdPhuThuBangGia";
			this.rdPhuThuBangGia.Size = new global::System.Drawing.Size(295, 19);
			this.rdPhuThuBangGia.TabIndex = 5;
			this.rdPhuThuBangGia.TabStop = true;
			this.rdPhuThuBangGia.Text = "Tính phụ thu vào sớm ra trễ theo bảng giá phụ thu";
			this.rdPhuThuBangGia.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(106, 160);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(139, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "(+1) Người lớn tính thêm";
			this.txtNguoiLonThem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNguoiLonThem.Location = new global::System.Drawing.Point(248, 157);
			this.txtNguoiLonThem.Name = "txtNguoiLonThem";
			this.txtNguoiLonThem.Size = new global::System.Drawing.Size(62, 21);
			this.txtNguoiLonThem.TabIndex = 7;
			this.txtNguoiLonThem.Text = "0";
			this.txtNguoiLonThem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtNguoiLonThem_KeyDown);
			this.txtNguoiLonThem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtNguoiLonThem_KeyPress);
			this.txtTreEmTinhThem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTreEmTinhThem.Location = new global::System.Drawing.Point(473, 157);
			this.txtTreEmTinhThem.Name = "txtTreEmTinhThem";
			this.txtTreEmTinhThem.Size = new global::System.Drawing.Size(62, 21);
			this.txtTreEmTinhThem.TabIndex = 9;
			this.txtTreEmTinhThem.Text = "0";
			this.txtTreEmTinhThem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTreEmTinhThem_KeyDown);
			this.txtTreEmTinhThem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTreEmTinhThem_KeyPress);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(342, 160);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(125, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "(+1) Trẻ em tính thêm";
			this.txtGiuongTinhThem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiuongTinhThem.Location = new global::System.Drawing.Point(720, 157);
			this.txtGiuongTinhThem.Name = "txtGiuongTinhThem";
			this.txtGiuongTinhThem.Size = new global::System.Drawing.Size(62, 21);
			this.txtGiuongTinhThem.TabIndex = 11;
			this.txtGiuongTinhThem.Text = "0";
			this.txtGiuongTinhThem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiuongTinhThem_KeyDown);
			this.txtGiuongTinhThem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiuongTinhThem_KeyPress);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(589, 160);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(126, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "(+1) Giường tính thêm";
			this.chkDonGiaCuoiTuan.AutoSize = true;
			this.chkDonGiaCuoiTuan.Location = new global::System.Drawing.Point(106, 192);
			this.chkDonGiaCuoiTuan.Name = "chkDonGiaCuoiTuan";
			this.chkDonGiaCuoiTuan.Size = new global::System.Drawing.Size(138, 19);
			this.chkDonGiaCuoiTuan.TabIndex = 12;
			this.chkDonGiaCuoiTuan.Text = "Có đơn giá cuối tuần";
			this.chkDonGiaCuoiTuan.UseVisualStyleBackColor = true;
			this.chkDonGiaCuoiTuan.CheckedChanged += new global::System.EventHandler(this.chkDonGiaCuoiTuan_CheckedChanged);
			this.chkDonGiaNgayLe.AutoSize = true;
			this.chkDonGiaNgayLe.Location = new global::System.Drawing.Point(345, 192);
			this.chkDonGiaNgayLe.Name = "chkDonGiaNgayLe";
			this.chkDonGiaNgayLe.Size = new global::System.Drawing.Size(127, 19);
			this.chkDonGiaNgayLe.TabIndex = 13;
			this.chkDonGiaNgayLe.Text = "Có đơn giá ngày lễ";
			this.chkDonGiaNgayLe.UseVisualStyleBackColor = true;
			this.chkDonGiaNgayLe.CheckedChanged += new global::System.EventHandler(this.chkDonGiaNgayLe_CheckedChanged);
			this.chkBangGiaDem.AutoSize = true;
			this.chkBangGiaDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkBangGiaDem.Location = new global::System.Drawing.Point(345, 219);
			this.chkBangGiaDem.Name = "chkBangGiaDem";
			this.chkBangGiaDem.Size = new global::System.Drawing.Size(135, 19);
			this.chkBangGiaDem.TabIndex = 15;
			this.chkBangGiaDem.Text = "Có bảng giá đêm";
			this.chkBangGiaDem.UseVisualStyleBackColor = true;
			this.chkBangGiaDem.CheckedChanged += new global::System.EventHandler(this.chkBangGiaDem_CheckedChanged);
			this.chkBangGiaGio.AutoSize = true;
			this.chkBangGiaGio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkBangGiaGio.Location = new global::System.Drawing.Point(106, 219);
			this.chkBangGiaGio.Name = "chkBangGiaGio";
			this.chkBangGiaGio.Size = new global::System.Drawing.Size(127, 19);
			this.chkBangGiaGio.TabIndex = 14;
			this.chkBangGiaGio.Text = "Có bảng giá giờ";
			this.chkBangGiaGio.UseVisualStyleBackColor = true;
			this.chkBangGiaGio.CheckedChanged += new global::System.EventHandler(this.chkBangGiaGio_CheckedChanged);
			this.chkBangGiaNgayDem.AutoSize = true;
			this.chkBangGiaNgayDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkBangGiaNgayDem.Location = new global::System.Drawing.Point(537, 219);
			this.chkBangGiaNgayDem.Name = "chkBangGiaNgayDem";
			this.chkBangGiaNgayDem.Size = new global::System.Drawing.Size(169, 19);
			this.chkBangGiaNgayDem.TabIndex = 16;
			this.chkBangGiaNgayDem.Text = "Có bảng giá ngày đêm";
			this.chkBangGiaNgayDem.UseVisualStyleBackColor = true;
			this.chkBangGiaNgayDem.CheckedChanged += new global::System.EventHandler(this.chkBangGiaNgayDem_CheckedChanged);
			this.tabBangGiaDichVu.Controls.Add(this.tabPageBangGiaGio);
			this.tabBangGiaDichVu.Controls.Add(this.tabPageBangGiaQuaDem);
			this.tabBangGiaDichVu.Controls.Add(this.tabPageBangGiaNgayDem);
			this.tabBangGiaDichVu.Location = new global::System.Drawing.Point(106, 249);
			this.tabBangGiaDichVu.Name = "tabBangGiaDichVu";
			this.tabBangGiaDichVu.SelectedIndex = 0;
			this.tabBangGiaDichVu.Size = new global::System.Drawing.Size(978, 362);
			this.tabBangGiaDichVu.TabIndex = 17;
			this.tabPageBangGiaGio.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPageBangGiaGio.Controls.Add(this.dgvBangGiaGio);
			this.tabPageBangGiaGio.Controls.Add(this.rdGiaNgayLe);
			this.tabPageBangGiaGio.Controls.Add(this.rdGiaCuoiTuan);
			this.tabPageBangGiaGio.Controls.Add(this.rdGiaNgayThuong);
			this.tabPageBangGiaGio.Controls.Add(this.label7);
			this.tabPageBangGiaGio.Controls.Add(this.txtBGGTreToiDa);
			this.tabPageBangGiaGio.Controls.Add(this.label6);
			this.tabPageBangGiaGio.Location = new global::System.Drawing.Point(4, 24);
			this.tabPageBangGiaGio.Name = "tabPageBangGiaGio";
			this.tabPageBangGiaGio.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageBangGiaGio.Size = new global::System.Drawing.Size(970, 334);
			this.tabPageBangGiaGio.TabIndex = 0;
			this.tabPageBangGiaGio.Text = "Bảng giá giờ";
			this.dgvBangGiaGio.AllowUserToAddRows = false;
			this.dgvBangGiaGio.AllowUserToDeleteRows = false;
			this.dgvBangGiaGio.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaGio.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaGio.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaGio.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaGio.Location = new global::System.Drawing.Point(0, 47);
			this.dgvBangGiaGio.Name = "dgvBangGiaGio";
			this.dgvBangGiaGio.RowHeadersVisible = false;
			this.dgvBangGiaGio.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaGio.TabIndex = 6;
			this.dgvBangGiaGio.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBangGiaGio_CellClick);
			this.dgvBangGiaGio.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBangGiaGio_CellValueChanged);
			this.dgvBangGiaGio.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.dgvBangGiaGio_KeyDown);
			this.dgvBangGiaGio.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.dgvBangGiaGio_KeyPress);
			this.rdGiaNgayLe.AutoSize = true;
			this.rdGiaNgayLe.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdGiaNgayLe.Location = new global::System.Drawing.Point(856, 14);
			this.rdGiaNgayLe.Name = "rdGiaNgayLe";
			this.rdGiaNgayLe.Size = new global::System.Drawing.Size(86, 19);
			this.rdGiaNgayLe.TabIndex = 5;
			this.rdGiaNgayLe.TabStop = true;
			this.rdGiaNgayLe.Text = "Giá ngày lễ";
			this.rdGiaNgayLe.UseVisualStyleBackColor = true;
			this.rdGiaNgayLe.CheckedChanged += new global::System.EventHandler(this.rdGiaNgayLe_CheckedChanged);
			this.rdGiaCuoiTuan.AutoSize = true;
			this.rdGiaCuoiTuan.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdGiaCuoiTuan.Location = new global::System.Drawing.Point(731, 14);
			this.rdGiaCuoiTuan.Name = "rdGiaCuoiTuan";
			this.rdGiaCuoiTuan.Size = new global::System.Drawing.Size(97, 19);
			this.rdGiaCuoiTuan.TabIndex = 4;
			this.rdGiaCuoiTuan.TabStop = true;
			this.rdGiaCuoiTuan.Text = "Giá cuối tuần";
			this.rdGiaCuoiTuan.UseVisualStyleBackColor = true;
			this.rdGiaCuoiTuan.CheckedChanged += new global::System.EventHandler(this.rdGiaCuoiTuan_CheckedChanged);
			this.rdGiaNgayThuong.AutoSize = true;
			this.rdGiaNgayThuong.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdGiaNgayThuong.Location = new global::System.Drawing.Point(593, 14);
			this.rdGiaNgayThuong.Name = "rdGiaNgayThuong";
			this.rdGiaNgayThuong.Size = new global::System.Drawing.Size(114, 19);
			this.rdGiaNgayThuong.TabIndex = 3;
			this.rdGiaNgayThuong.TabStop = true;
			this.rdGiaNgayThuong.Text = "Giá ngày thường";
			this.rdGiaNgayThuong.UseVisualStyleBackColor = true;
			this.rdGiaNgayThuong.CheckedChanged += new global::System.EventHandler(this.rdGiaNgayThuong_CheckedChanged);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(225, 16);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(42, 15);
			this.label7.TabIndex = 2;
			this.label7.Text = "( phút)";
			this.txtBGGTreToiDa.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBGGTreToiDa.Location = new global::System.Drawing.Point(157, 13);
			this.txtBGGTreToiDa.Name = "txtBGGTreToiDa";
			this.txtBGGTreToiDa.Size = new global::System.Drawing.Size(62, 21);
			this.txtBGGTreToiDa.TabIndex = 1;
			this.txtBGGTreToiDa.Text = "0";
			this.txtBGGTreToiDa.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTreToiDa_KeyDown);
			this.txtBGGTreToiDa.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTreToiDa_KeyPress);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(3, 16);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(148, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Cho phép phòng trễ tối đa";
			this.tabPageBangGiaQuaDem.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPageBangGiaQuaDem.Controls.Add(this.tabControlBangGiaQuaDem);
			this.tabPageBangGiaQuaDem.Controls.Add(this.label10);
			this.tabPageBangGiaQuaDem.Controls.Add(this.txtTraPhongTruocQuaDem);
			this.tabPageBangGiaQuaDem.Controls.Add(this.label11);
			this.tabPageBangGiaQuaDem.Controls.Add(this.dataGridView2);
			this.tabPageBangGiaQuaDem.Controls.Add(this.label8);
			this.tabPageBangGiaQuaDem.Controls.Add(this.txtTreToiDaQuaDem);
			this.tabPageBangGiaQuaDem.Controls.Add(this.label9);
			this.tabPageBangGiaQuaDem.Location = new global::System.Drawing.Point(4, 24);
			this.tabPageBangGiaQuaDem.Name = "tabPageBangGiaQuaDem";
			this.tabPageBangGiaQuaDem.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageBangGiaQuaDem.Size = new global::System.Drawing.Size(970, 334);
			this.tabPageBangGiaQuaDem.TabIndex = 1;
			this.tabPageBangGiaQuaDem.Text = "Bảng giá qua đêm";
			this.tabControlBangGiaQuaDem.Controls.Add(this.tabPageDKAD);
			this.tabControlBangGiaQuaDem.Controls.Add(this.tabQuaDemBangGia);
			this.tabControlBangGiaQuaDem.Controls.Add(this.tabQuaDemPhuThuVaoSom);
			this.tabControlBangGiaQuaDem.Controls.Add(this.tabQuaDemGiamTruVaoMuon);
			this.tabControlBangGiaQuaDem.Controls.Add(this.tabQuaDemPhuThuRaTre);
			this.tabControlBangGiaQuaDem.Location = new global::System.Drawing.Point(0, 41);
			this.tabControlBangGiaQuaDem.Name = "tabControlBangGiaQuaDem";
			this.tabControlBangGiaQuaDem.SelectedIndex = 0;
			this.tabControlBangGiaQuaDem.Size = new global::System.Drawing.Size(970, 293);
			this.tabControlBangGiaQuaDem.TabIndex = 6;
			this.tabPageDKAD.Controls.Add(this.label20);
			this.tabPageDKAD.Controls.Add(this.txtTruocGio);
			this.tabPageDKAD.Controls.Add(this.label21);
			this.tabPageDKAD.Controls.Add(this.txtGioVaoSau2);
			this.tabPageDKAD.Controls.Add(this.label22);
			this.tabPageDKAD.Controls.Add(this.label19);
			this.tabPageDKAD.Controls.Add(this.txtQuaGioQuaDem);
			this.tabPageDKAD.Controls.Add(this.label18);
			this.tabPageDKAD.Controls.Add(this.txtGioVaoSau1);
			this.tabPageDKAD.Controls.Add(this.label17);
			this.tabPageDKAD.Controls.Add(this.label16);
			this.tabPageDKAD.Location = new global::System.Drawing.Point(4, 24);
			this.tabPageDKAD.Name = "tabPageDKAD";
			this.tabPageDKAD.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageDKAD.Size = new global::System.Drawing.Size(962, 265);
			this.tabPageDKAD.TabIndex = 0;
			this.tabPageDKAD.Text = "Điều kiện áp dụng";
			this.tabPageDKAD.UseVisualStyleBackColor = true;
			this.label20.AutoSize = true;
			this.label20.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label20.Location = new global::System.Drawing.Point(329, 81);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(35, 15);
			this.label20.TabIndex = 10;
			this.label20.Text = "( giờ)";
			this.txtTruocGio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTruocGio.Location = new global::System.Drawing.Point(261, 78);
			this.txtTruocGio.Name = "txtTruocGio";
			this.txtTruocGio.Size = new global::System.Drawing.Size(62, 21);
			this.txtTruocGio.TabIndex = 9;
			this.txtTruocGio.Text = "0";
			this.txtTruocGio.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTruocGio_KeyDown);
			this.txtTruocGio.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTruocGio_KeyPress);
			this.label21.AutoSize = true;
			this.label21.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label21.Location = new global::System.Drawing.Point(171, 81);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(80, 15);
			this.label21.TabIndex = 8;
			this.label21.Text = "( giờ) và trước";
			this.txtGioVaoSau2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGioVaoSau2.Location = new global::System.Drawing.Point(103, 78);
			this.txtGioVaoSau2.Name = "txtGioVaoSau2";
			this.txtGioVaoSau2.Size = new global::System.Drawing.Size(62, 21);
			this.txtGioVaoSau2.TabIndex = 7;
			this.txtGioVaoSau2.Text = "0";
			this.txtGioVaoSau2.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGioVaoSau2_KeyDown);
			this.txtGioVaoSau2.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGioVaoSau2_KeyPress);
			this.label22.AutoSize = true;
			this.label22.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label22.Location = new global::System.Drawing.Point(8, 81);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(89, 15);
			this.label22.TabIndex = 6;
			this.label22.Text = "(2) Giờ vào sau";
			this.label19.AutoSize = true;
			this.label19.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.Location = new global::System.Drawing.Point(329, 44);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(45, 15);
			this.label19.TabIndex = 5;
			this.label19.Text = "( tiếng)";
			this.txtQuaGioQuaDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtQuaGioQuaDem.Location = new global::System.Drawing.Point(261, 41);
			this.txtQuaGioQuaDem.Name = "txtQuaGioQuaDem";
			this.txtQuaGioQuaDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtQuaGioQuaDem.TabIndex = 4;
			this.txtQuaGioQuaDem.Text = "0";
			this.txtQuaGioQuaDem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtQuaGio_KeyDown);
			this.txtQuaGioQuaDem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtQuaGio_KeyPress);
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.Location = new global::System.Drawing.Point(171, 44);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(84, 15);
			this.label18.TabIndex = 3;
			this.label18.Text = "( giờ) và ở quá";
			this.txtGioVaoSau1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGioVaoSau1.Location = new global::System.Drawing.Point(103, 41);
			this.txtGioVaoSau1.Name = "txtGioVaoSau1";
			this.txtGioVaoSau1.Size = new global::System.Drawing.Size(62, 21);
			this.txtGioVaoSau1.TabIndex = 2;
			this.txtGioVaoSau1.Text = "0";
			this.txtGioVaoSau1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGioVaoSau1_KeyDown);
			this.txtGioVaoSau1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGioVaoSau1_KeyPress);
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.Location = new global::System.Drawing.Point(8, 44);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(89, 15);
			this.label17.TabIndex = 1;
			this.label17.Text = "(1) Giờ vào sau";
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.Location = new global::System.Drawing.Point(8, 14);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(223, 15);
			this.label16.TabIndex = 0;
			this.label16.Text = "Các trường hợp đặc biết tính thêm";
			this.tabQuaDemBangGia.Controls.Add(this.dgvBangGiaQuaDem);
			this.tabQuaDemBangGia.Location = new global::System.Drawing.Point(4, 24);
			this.tabQuaDemBangGia.Name = "tabQuaDemBangGia";
			this.tabQuaDemBangGia.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuaDemBangGia.Size = new global::System.Drawing.Size(962, 265);
			this.tabQuaDemBangGia.TabIndex = 1;
			this.tabQuaDemBangGia.Text = "Bảng giá";
			this.tabQuaDemBangGia.UseVisualStyleBackColor = true;
			this.dgvBangGiaQuaDem.AllowUserToAddRows = false;
			this.dgvBangGiaQuaDem.AllowUserToDeleteRows = false;
			this.dgvBangGiaQuaDem.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaQuaDem.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaQuaDem.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaQuaDem.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaQuaDem.Location = new global::System.Drawing.Point(1, 0);
			this.dgvBangGiaQuaDem.Name = "dgvBangGiaQuaDem";
			this.dgvBangGiaQuaDem.RowHeadersVisible = false;
			this.dgvBangGiaQuaDem.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaQuaDem.TabIndex = 0;
			this.dgvBangGiaQuaDem.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDem_CellClick);
			this.dgvBangGiaQuaDem.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDem_CellValueChanged);
			this.tabQuaDemPhuThuVaoSom.Controls.Add(this.dgvBangGiaQuaDemPhuThuVaoSom);
			this.tabQuaDemPhuThuVaoSom.Location = new global::System.Drawing.Point(4, 24);
			this.tabQuaDemPhuThuVaoSom.Name = "tabQuaDemPhuThuVaoSom";
			this.tabQuaDemPhuThuVaoSom.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuaDemPhuThuVaoSom.Size = new global::System.Drawing.Size(962, 265);
			this.tabQuaDemPhuThuVaoSom.TabIndex = 2;
			this.tabQuaDemPhuThuVaoSom.Text = "Phụ thu vào sớm( Trước 18h)";
			this.tabQuaDemPhuThuVaoSom.UseVisualStyleBackColor = true;
			this.dgvBangGiaQuaDemPhuThuVaoSom.AllowUserToAddRows = false;
			this.dgvBangGiaQuaDemPhuThuVaoSom.AllowUserToDeleteRows = false;
			this.dgvBangGiaQuaDemPhuThuVaoSom.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaQuaDemPhuThuVaoSom.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaQuaDemPhuThuVaoSom.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaQuaDemPhuThuVaoSom.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaQuaDemPhuThuVaoSom.Location = new global::System.Drawing.Point(0, 0);
			this.dgvBangGiaQuaDemPhuThuVaoSom.Name = "dgvBangGiaQuaDemPhuThuVaoSom";
			this.dgvBangGiaQuaDemPhuThuVaoSom.RowHeadersVisible = false;
			this.dgvBangGiaQuaDemPhuThuVaoSom.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaQuaDemPhuThuVaoSom.TabIndex = 1;
			this.dgvBangGiaQuaDemPhuThuVaoSom.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemPhuThuVaoSom_CellClick);
			this.dgvBangGiaQuaDemPhuThuVaoSom.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemPhuThuVaoSom_CellValueChanged);
			this.tabQuaDemGiamTruVaoMuon.Controls.Add(this.dgvBangGiaQuaDemGiamTruVaoMuon);
			this.tabQuaDemGiamTruVaoMuon.Location = new global::System.Drawing.Point(4, 24);
			this.tabQuaDemGiamTruVaoMuon.Name = "tabQuaDemGiamTruVaoMuon";
			this.tabQuaDemGiamTruVaoMuon.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuaDemGiamTruVaoMuon.Size = new global::System.Drawing.Size(962, 265);
			this.tabQuaDemGiamTruVaoMuon.TabIndex = 3;
			this.tabQuaDemGiamTruVaoMuon.Text = "Giảm trừ vào muộn( Sau 18h)";
			this.tabQuaDemGiamTruVaoMuon.UseVisualStyleBackColor = true;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.AllowUserToAddRows = false;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.AllowUserToDeleteRows = false;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.Location = new global::System.Drawing.Point(0, 0);
			this.dgvBangGiaQuaDemGiamTruVaoMuon.Name = "dgvBangGiaQuaDemGiamTruVaoMuon";
			this.dgvBangGiaQuaDemGiamTruVaoMuon.RowHeadersVisible = false;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaQuaDemGiamTruVaoMuon.TabIndex = 2;
			this.dgvBangGiaQuaDemGiamTruVaoMuon.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemGiamTruVaoMuon_CellClick);
			this.dgvBangGiaQuaDemGiamTruVaoMuon.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemGiamTruVaoMuon_CellValueChanged);
			this.tabQuaDemPhuThuRaTre.Controls.Add(this.dgvBangGiaQuaDemPhuThuRaTre);
			this.tabQuaDemPhuThuRaTre.Location = new global::System.Drawing.Point(4, 24);
			this.tabQuaDemPhuThuRaTre.Name = "tabQuaDemPhuThuRaTre";
			this.tabQuaDemPhuThuRaTre.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabQuaDemPhuThuRaTre.Size = new global::System.Drawing.Size(962, 265);
			this.tabQuaDemPhuThuRaTre.TabIndex = 4;
			this.tabQuaDemPhuThuRaTre.Text = "Phụ thu ra trễ( Sau 12h)";
			this.tabQuaDemPhuThuRaTre.UseVisualStyleBackColor = true;
			this.dgvBangGiaQuaDemPhuThuRaTre.AllowUserToAddRows = false;
			this.dgvBangGiaQuaDemPhuThuRaTre.AllowUserToDeleteRows = false;
			this.dgvBangGiaQuaDemPhuThuRaTre.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaQuaDemPhuThuRaTre.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaQuaDemPhuThuRaTre.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaQuaDemPhuThuRaTre.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaQuaDemPhuThuRaTre.Location = new global::System.Drawing.Point(0, 0);
			this.dgvBangGiaQuaDemPhuThuRaTre.Name = "dgvBangGiaQuaDemPhuThuRaTre";
			this.dgvBangGiaQuaDemPhuThuRaTre.RowHeadersVisible = false;
			this.dgvBangGiaQuaDemPhuThuRaTre.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaQuaDemPhuThuRaTre.TabIndex = 3;
			this.dgvBangGiaQuaDemPhuThuRaTre.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemPhuThuRaTre_CellClick);
			this.dgvBangGiaQuaDemPhuThuRaTre.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaQuaDemPhuThuRaTre_CellValueChanged);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(763, 16);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(25, 15);
			this.label10.TabIndex = 5;
			this.label10.Text = "( h)";
			this.txtTraPhongTruocQuaDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTraPhongTruocQuaDem.Location = new global::System.Drawing.Point(695, 13);
			this.txtTraPhongTruocQuaDem.Name = "txtTraPhongTruocQuaDem";
			this.txtTraPhongTruocQuaDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtTraPhongTruocQuaDem.TabIndex = 4;
			this.txtTraPhongTruocQuaDem.Text = "0";
			this.txtTraPhongTruocQuaDem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTraPhongTruocQuaDem_KeyDown);
			this.txtTraPhongTruocQuaDem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTraPhongTruocQuaDem_KeyPress);
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(596, 16);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(93, 15);
			this.label11.TabIndex = 3;
			this.label11.Text = "Trả phòng trước";
			this.dataGridView2.BackgroundColor = global::System.Drawing.Color.White;
			this.dataGridView2.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new global::System.Drawing.Point(0, 41);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new global::System.Drawing.Size(970, 293);
			this.dataGridView2.TabIndex = 20;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(225, 16);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(42, 15);
			this.label8.TabIndex = 2;
			this.label8.Text = "( phút)";
			this.txtTreToiDaQuaDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTreToiDaQuaDem.Location = new global::System.Drawing.Point(157, 13);
			this.txtTreToiDaQuaDem.Name = "txtTreToiDaQuaDem";
			this.txtTreToiDaQuaDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtTreToiDaQuaDem.TabIndex = 1;
			this.txtTreToiDaQuaDem.Text = "0";
			this.txtTreToiDaQuaDem.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTreToiDaQuaDem_KeyDown);
			this.txtTreToiDaQuaDem.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTreToiDaQuaDem_KeyPress);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(3, 16);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(148, 15);
			this.label9.TabIndex = 0;
			this.label9.Text = "Cho phép phòng trễ tối đa";
			this.tabPageBangGiaNgayDem.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPageBangGiaNgayDem.Controls.Add(this.tabControlBangGiaNgayDem);
			this.tabPageBangGiaNgayDem.Controls.Add(this.label12);
			this.tabPageBangGiaNgayDem.Controls.Add(this.txtTraPhongTruocNgayDem);
			this.tabPageBangGiaNgayDem.Controls.Add(this.label13);
			this.tabPageBangGiaNgayDem.Controls.Add(this.label14);
			this.tabPageBangGiaNgayDem.Controls.Add(this.txtTreToiDaNgayDem);
			this.tabPageBangGiaNgayDem.Controls.Add(this.label15);
			this.tabPageBangGiaNgayDem.Location = new global::System.Drawing.Point(4, 24);
			this.tabPageBangGiaNgayDem.Name = "tabPageBangGiaNgayDem";
			this.tabPageBangGiaNgayDem.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageBangGiaNgayDem.Size = new global::System.Drawing.Size(970, 334);
			this.tabPageBangGiaNgayDem.TabIndex = 2;
			this.tabPageBangGiaNgayDem.Text = "Bảng giá ngày đêm";
			this.tabControlBangGiaNgayDem.Controls.Add(this.tabNgayDemDKAD);
			this.tabControlBangGiaNgayDem.Controls.Add(this.tabBangGiaNgayDem);
			this.tabControlBangGiaNgayDem.Controls.Add(this.tabNgayDemPhuThuVaoSom);
			this.tabControlBangGiaNgayDem.Controls.Add(this.tabNgayDemPhuThuRaTre);
			this.tabControlBangGiaNgayDem.Location = new global::System.Drawing.Point(0, 38);
			this.tabControlBangGiaNgayDem.Name = "tabControlBangGiaNgayDem";
			this.tabControlBangGiaNgayDem.SelectedIndex = 0;
			this.tabControlBangGiaNgayDem.Size = new global::System.Drawing.Size(970, 293);
			this.tabControlBangGiaNgayDem.TabIndex = 6;
			this.tabNgayDemDKAD.Controls.Add(this.chkRaSauGioTraPhong);
			this.tabNgayDemDKAD.Controls.Add(this.label24);
			this.tabNgayDemDKAD.Controls.Add(this.txtQuaGioNgayDem);
			this.tabNgayDemDKAD.Controls.Add(this.label23);
			this.tabNgayDemDKAD.Controls.Add(this.chkTinhLa1Ngay);
			this.tabNgayDemDKAD.Location = new global::System.Drawing.Point(4, 24);
			this.tabNgayDemDKAD.Name = "tabNgayDemDKAD";
			this.tabNgayDemDKAD.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabNgayDemDKAD.Size = new global::System.Drawing.Size(962, 265);
			this.tabNgayDemDKAD.TabIndex = 0;
			this.tabNgayDemDKAD.Text = "Điều kiện áp dụng";
			this.tabNgayDemDKAD.UseVisualStyleBackColor = true;
			this.chkRaSauGioTraPhong.AutoSize = true;
			this.chkRaSauGioTraPhong.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkRaSauGioTraPhong.Location = new global::System.Drawing.Point(433, 18);
			this.chkRaSauGioTraPhong.Name = "chkRaSauGioTraPhong";
			this.chkRaSauGioTraPhong.Size = new global::System.Drawing.Size(150, 19);
			this.chkRaSauGioTraPhong.TabIndex = 4;
			this.chkRaSauGioTraPhong.Text = "và ra sau giờ trả phòng";
			this.chkRaSauGioTraPhong.UseVisualStyleBackColor = true;
			this.label24.AutoSize = true;
			this.label24.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label24.Location = new global::System.Drawing.Point(324, 19);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(45, 15);
			this.label24.TabIndex = 3;
			this.label24.Text = "( tiếng)";
			this.txtQuaGioNgayDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtQuaGioNgayDem.Location = new global::System.Drawing.Point(256, 16);
			this.txtQuaGioNgayDem.Name = "txtQuaGioNgayDem";
			this.txtQuaGioNgayDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtQuaGioNgayDem.TabIndex = 2;
			this.txtQuaGioNgayDem.Text = "0";
			this.label23.AutoSize = true;
			this.label23.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label23.Location = new global::System.Drawing.Point(188, 19);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(62, 15);
			this.label23.TabIndex = 1;
			this.label23.Text = "nếu ở quá";
			this.chkTinhLa1Ngay.AutoSize = true;
			this.chkTinhLa1Ngay.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkTinhLa1Ngay.Location = new global::System.Drawing.Point(20, 18);
			this.chkTinhLa1Ngay.Name = "chkTinhLa1Ngay";
			this.chkTinhLa1Ngay.Size = new global::System.Drawing.Size(132, 19);
			this.chkTinhLa1Ngay.TabIndex = 0;
			this.chkTinhLa1Ngay.Text = "Tính là một ngày";
			this.chkTinhLa1Ngay.UseVisualStyleBackColor = true;
			this.tabBangGiaNgayDem.Controls.Add(this.dgvBangGiaNgayDem);
			this.tabBangGiaNgayDem.Location = new global::System.Drawing.Point(4, 24);
			this.tabBangGiaNgayDem.Name = "tabBangGiaNgayDem";
			this.tabBangGiaNgayDem.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabBangGiaNgayDem.Size = new global::System.Drawing.Size(962, 265);
			this.tabBangGiaNgayDem.TabIndex = 1;
			this.tabBangGiaNgayDem.Text = "Bảng giá";
			this.tabBangGiaNgayDem.UseVisualStyleBackColor = true;
			this.dgvBangGiaNgayDem.AllowUserToAddRows = false;
			this.dgvBangGiaNgayDem.AllowUserToDeleteRows = false;
			this.dgvBangGiaNgayDem.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaNgayDem.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaNgayDem.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaNgayDem.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaNgayDem.Location = new global::System.Drawing.Point(2, 0);
			this.dgvBangGiaNgayDem.Name = "dgvBangGiaNgayDem";
			this.dgvBangGiaNgayDem.RowHeadersVisible = false;
			this.dgvBangGiaNgayDem.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaNgayDem.TabIndex = 0;
			this.dgvBangGiaNgayDem.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDem_CellClick);
			this.dgvBangGiaNgayDem.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDem_CellValueChanged);
			this.tabNgayDemPhuThuVaoSom.Controls.Add(this.dgvBangGiaNgayDemPhuThuVaoSom);
			this.tabNgayDemPhuThuVaoSom.Location = new global::System.Drawing.Point(4, 24);
			this.tabNgayDemPhuThuVaoSom.Name = "tabNgayDemPhuThuVaoSom";
			this.tabNgayDemPhuThuVaoSom.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabNgayDemPhuThuVaoSom.Size = new global::System.Drawing.Size(962, 265);
			this.tabNgayDemPhuThuVaoSom.TabIndex = 2;
			this.tabNgayDemPhuThuVaoSom.Text = "Phụ thu vào sớm( Trước 12h)";
			this.tabNgayDemPhuThuVaoSom.UseVisualStyleBackColor = true;
			this.dgvBangGiaNgayDemPhuThuVaoSom.AllowUserToAddRows = false;
			this.dgvBangGiaNgayDemPhuThuVaoSom.AllowUserToDeleteRows = false;
			this.dgvBangGiaNgayDemPhuThuVaoSom.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaNgayDemPhuThuVaoSom.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaNgayDemPhuThuVaoSom.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaNgayDemPhuThuVaoSom.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaNgayDemPhuThuVaoSom.Location = new global::System.Drawing.Point(0, 0);
			this.dgvBangGiaNgayDemPhuThuVaoSom.Name = "dgvBangGiaNgayDemPhuThuVaoSom";
			this.dgvBangGiaNgayDemPhuThuVaoSom.RowHeadersVisible = false;
			this.dgvBangGiaNgayDemPhuThuVaoSom.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaNgayDemPhuThuVaoSom.TabIndex = 1;
			this.dgvBangGiaNgayDemPhuThuVaoSom.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDemPhuThuVaoSom_CellClick);
			this.dgvBangGiaNgayDemPhuThuVaoSom.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDemPhuThuVaoSom_CellValueChanged);
			this.tabNgayDemPhuThuRaTre.Controls.Add(this.dgvBangGiaNgayDemPhuThuRaTre);
			this.tabNgayDemPhuThuRaTre.Location = new global::System.Drawing.Point(4, 24);
			this.tabNgayDemPhuThuRaTre.Name = "tabNgayDemPhuThuRaTre";
			this.tabNgayDemPhuThuRaTre.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabNgayDemPhuThuRaTre.Size = new global::System.Drawing.Size(962, 265);
			this.tabNgayDemPhuThuRaTre.TabIndex = 4;
			this.tabNgayDemPhuThuRaTre.Text = "Phụ thu ra trễ( Sau 12h)";
			this.tabNgayDemPhuThuRaTre.UseVisualStyleBackColor = true;
			this.dgvBangGiaNgayDemPhuThuRaTre.AllowUserToAddRows = false;
			this.dgvBangGiaNgayDemPhuThuRaTre.AllowUserToDeleteRows = false;
			this.dgvBangGiaNgayDemPhuThuRaTre.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvBangGiaNgayDemPhuThuRaTre.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvBangGiaNgayDemPhuThuRaTre.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvBangGiaNgayDemPhuThuRaTre.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBangGiaNgayDemPhuThuRaTre.Location = new global::System.Drawing.Point(0, 0);
			this.dgvBangGiaNgayDemPhuThuRaTre.Name = "dgvBangGiaNgayDemPhuThuRaTre";
			this.dgvBangGiaNgayDemPhuThuRaTre.RowHeadersVisible = false;
			this.dgvBangGiaNgayDemPhuThuRaTre.Size = new global::System.Drawing.Size(960, 263);
			this.dgvBangGiaNgayDemPhuThuRaTre.TabIndex = 3;
			this.dgvBangGiaNgayDemPhuThuRaTre.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDemPhuThuRaTre_CellClick);
			this.dgvBangGiaNgayDemPhuThuRaTre.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaNgayDemPhuThuRaTre_CellValueChanged);
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(763, 16);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(25, 15);
			this.label12.TabIndex = 5;
			this.label12.Text = "( h)";
			this.txtTraPhongTruocNgayDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTraPhongTruocNgayDem.Location = new global::System.Drawing.Point(695, 13);
			this.txtTraPhongTruocNgayDem.Name = "txtTraPhongTruocNgayDem";
			this.txtTraPhongTruocNgayDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtTraPhongTruocNgayDem.TabIndex = 4;
			this.txtTraPhongTruocNgayDem.Text = "0";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(596, 16);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(93, 15);
			this.label13.TabIndex = 3;
			this.label13.Text = "Trả phòng trước";
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(225, 16);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(42, 15);
			this.label14.TabIndex = 2;
			this.label14.Text = "( phút)";
			this.txtTreToiDaNgayDem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTreToiDaNgayDem.Location = new global::System.Drawing.Point(157, 13);
			this.txtTreToiDaNgayDem.Name = "txtTreToiDaNgayDem";
			this.txtTreToiDaNgayDem.Size = new global::System.Drawing.Size(62, 21);
			this.txtTreToiDaNgayDem.TabIndex = 1;
			this.txtTreToiDaNgayDem.Text = "0";
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.Location = new global::System.Drawing.Point(3, 16);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(148, 15);
			this.label15.TabIndex = 0;
			this.label15.Text = "Cho phép phòng trễ tối đa";
			this.btnSave.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.Location = new global::System.Drawing.Point(687, 619);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(65, 36);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnSaveNew.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSaveNew.Location = new global::System.Drawing.Point(780, 619);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(85, 36);
			this.btnSaveNew.TabIndex = 19;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSaveExit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSaveExit.Location = new global::System.Drawing.Point(887, 619);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(85, 36);
			this.btnSaveExit.TabIndex = 20;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnExit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExit.Location = new global::System.Drawing.Point(995, 619);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(85, 36);
			this.btnExit.TabIndex = 21;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1091, 668);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.tabBangGiaDichVu);
			base.Controls.Add(this.chkBangGiaNgayDem);
			base.Controls.Add(this.chkBangGiaDem);
			base.Controls.Add(this.chkBangGiaGio);
			base.Controls.Add(this.chkDonGiaNgayLe);
			base.Controls.Add(this.chkDonGiaCuoiTuan);
			base.Controls.Add(this.txtGiuongTinhThem);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.txtTreEmTinhThem);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtNguoiLonThem);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.rdPhuThuBangGia);
			base.Controls.Add(this.rdPhuThuGio);
			base.Controls.Add(this.btnKiemTraBangGia);
			base.Controls.Add(this.txtTenBangGia);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.groupBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(1107, 707);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(1107, 707);
			base.Name = "frmAddNew";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng giá ";
			base.Load += new global::System.EventHandler(this.frmAddNew_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tabBangGiaDichVu.ResumeLayout(false);
			this.tabPageBangGiaGio.ResumeLayout(false);
			this.tabPageBangGiaGio.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaGio).EndInit();
			this.tabPageBangGiaQuaDem.ResumeLayout(false);
			this.tabPageBangGiaQuaDem.PerformLayout();
			this.tabControlBangGiaQuaDem.ResumeLayout(false);
			this.tabPageDKAD.ResumeLayout(false);
			this.tabPageDKAD.PerformLayout();
			this.tabQuaDemBangGia.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDem).EndInit();
			this.tabQuaDemPhuThuVaoSom.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemPhuThuVaoSom).EndInit();
			this.tabQuaDemGiamTruVaoMuon.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemGiamTruVaoMuon).EndInit();
			this.tabQuaDemPhuThuRaTre.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaQuaDemPhuThuRaTre).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
			this.tabPageBangGiaNgayDem.ResumeLayout(false);
			this.tabPageBangGiaNgayDem.PerformLayout();
			this.tabControlBangGiaNgayDem.ResumeLayout(false);
			this.tabNgayDemDKAD.ResumeLayout(false);
			this.tabNgayDemDKAD.PerformLayout();
			this.tabBangGiaNgayDem.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDem).EndInit();
			this.tabNgayDemPhuThuVaoSom.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDemPhuThuVaoSom).EndInit();
			this.tabNgayDemPhuThuRaTre.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBangGiaNgayDemPhuThuRaTre).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000011 RID: 17
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TextBox txtTenBangGia;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button btnKiemTraBangGia;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.RadioButton rdPhuThuGio;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.RadioButton rdPhuThuBangGia;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.TextBox txtNguoiLonThem;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.TextBox txtTreEmTinhThem;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.TextBox txtGiuongTinhThem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.CheckBox chkDonGiaCuoiTuan;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.CheckBox chkDonGiaNgayLe;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.CheckBox chkBangGiaDem;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.CheckBox chkBangGiaGio;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.CheckBox chkBangGiaNgayDem;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TabControl tabBangGiaDichVu;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.TabPage tabPageBangGiaGio;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.DataGridView dgvBangGiaGio;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.RadioButton rdGiaNgayLe;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.RadioButton rdGiaCuoiTuan;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.RadioButton rdGiaNgayThuong;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.TextBox txtBGGTreToiDa;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TabPage tabPageBangGiaQuaDem;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.TabPage tabPageBangGiaNgayDem;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.TextBox txtTraPhongTruocQuaDem;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.DataGridView dataGridView2;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.TextBox txtTreToiDaQuaDem;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TabControl tabControlBangGiaQuaDem;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.TabPage tabPageDKAD;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.TabPage tabQuaDemBangGia;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TabPage tabQuaDemPhuThuVaoSom;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.TabPage tabQuaDemGiamTruVaoMuon;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.TabPage tabQuaDemPhuThuRaTre;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.TextBox txtTraPhongTruocNgayDem;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TextBox txtTreToiDaNgayDem;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.TextBox txtTruocGio;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.TextBox txtGioVaoSau2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.TextBox txtQuaGioQuaDem;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.TextBox txtGioVaoSau1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.DataGridView dgvBangGiaQuaDem;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.DataGridView dgvBangGiaQuaDemPhuThuVaoSom;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.DataGridView dgvBangGiaQuaDemGiamTruVaoMuon;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.DataGridView dgvBangGiaQuaDemPhuThuRaTre;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.TabControl tabControlBangGiaNgayDem;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.TabPage tabNgayDemDKAD;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.CheckBox chkRaSauGioTraPhong;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox txtQuaGioNgayDem;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.CheckBox chkTinhLa1Ngay;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.TabPage tabBangGiaNgayDem;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.DataGridView dgvBangGiaNgayDem;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TabPage tabNgayDemPhuThuVaoSom;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.DataGridView dgvBangGiaNgayDemPhuThuVaoSom;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.TabPage tabNgayDemPhuThuRaTre;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.DataGridView dgvBangGiaNgayDemPhuThuRaTre;
	}
}

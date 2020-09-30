namespace Hotel
{
	// Token: 0x02000014 RID: 20
	public partial class frmMatHang : global::System.Windows.Forms.Form
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0002DC34 File Offset: 0x0002BE34
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002DC6C File Offset: 0x0002BE6C
		private void InitializeComponent()
		{
			this.lblLine = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.lblDVTNhap = new global::System.Windows.Forms.Label();
			this.lblQuyDoi = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtQuyDoi = new global::System.Windows.Forms.TextBox();
			this.cbLoaiSanPham = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.cbNhomSanPham = new global::System.Windows.Forms.ComboBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtGiaMua = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.cbDVTMua = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cbDVTBan = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtGiaBan = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtTenSanPham = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtMaSanPham = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			base.SuspendLayout();
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(4, 59);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(28, 15);
			this.lblLine.TabIndex = 11;
			this.lblLine.Text = "___";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(69, 19);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(353, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Cho phép bạn quản lý và chỉnh sửa danh mục loại đồ";
			this.pictureBox1.Image = global::Hotel.Properties.Resources.beer;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 54);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(3, 86);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(573, 271);
			this.tabControl1.TabIndex = 12;
			this.tabPage1.Controls.Add(this.lblDVTNhap);
			this.tabPage1.Controls.Add(this.lblQuyDoi);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.txtQuyDoi);
			this.tabPage1.Controls.Add(this.cbLoaiSanPham);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.cbNhomSanPham);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.txtGiaMua);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.cbDVTMua);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.cbDVTBan);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.txtGiaBan);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.txtTenSanPham);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtMaSanPham);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(565, 243);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Thông tin mặt hàng";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.lblDVTNhap.AutoSize = true;
			this.lblDVTNhap.Location = new global::System.Drawing.Point(293, 66);
			this.lblDVTNhap.Name = "lblDVTNhap";
			this.lblDVTNhap.Size = new global::System.Drawing.Size(48, 15);
			this.lblDVTNhap.TabIndex = 21;
			this.lblDVTNhap.Text = "Quy đổi";
			this.lblQuyDoi.AutoSize = true;
			this.lblQuyDoi.Location = new global::System.Drawing.Point(447, 122);
			this.lblQuyDoi.Name = "lblQuyDoi";
			this.lblQuyDoi.Size = new global::System.Drawing.Size(48, 15);
			this.lblQuyDoi.TabIndex = 20;
			this.lblQuyDoi.Text = "Quy đổi";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(328, 122);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(48, 15);
			this.label11.TabIndex = 19;
			this.label11.Text = "Quy đổi";
			this.txtQuyDoi.Location = new global::System.Drawing.Point(382, 119);
			this.txtQuyDoi.Name = "txtQuyDoi";
			this.txtQuyDoi.Size = new global::System.Drawing.Size(59, 21);
			this.txtQuyDoi.TabIndex = 18;
			this.txtQuyDoi.Text = "0";
			this.txtQuyDoi.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtQuyDoi_KeyDown);
			this.txtQuyDoi.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtQuyDoi_KeyPress);
			this.cbLoaiSanPham.FormattingEnabled = true;
			this.cbLoaiSanPham.Items.AddRange(new object[]
			{
				"Mặt hàng pha chế",
				"Mặt hàng kiêm vật tư",
				"Vật tư nguyên liệu",
				"Mặt hàng mở",
				"Khác"
			});
			this.cbLoaiSanPham.Location = new global::System.Drawing.Point(130, 204);
			this.cbLoaiSanPham.Name = "cbLoaiSanPham";
			this.cbLoaiSanPham.Size = new global::System.Drawing.Size(150, 23);
			this.cbLoaiSanPham.TabIndex = 17;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(6, 207);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(86, 15);
			this.label10.TabIndex = 16;
			this.label10.Text = "Loại mặt hàng";
			this.cbNhomSanPham.FormattingEnabled = true;
			this.cbNhomSanPham.Location = new global::System.Drawing.Point(130, 175);
			this.cbNhomSanPham.Name = "cbNhomSanPham";
			this.cbNhomSanPham.Size = new global::System.Drawing.Size(391, 23);
			this.cbNhomSanPham.TabIndex = 15;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(6, 178);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(96, 15);
			this.label9.TabIndex = 14;
			this.label9.Text = "Nhóm mặt hàng";
			this.txtGiaMua.Location = new global::System.Drawing.Point(130, 63);
			this.txtGiaMua.Name = "txtGiaMua";
			this.txtGiaMua.Size = new global::System.Drawing.Size(150, 21);
			this.txtGiaMua.TabIndex = 13;
			this.txtGiaMua.Text = "0";
			this.txtGiaMua.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiaMua_KeyDown);
			this.txtGiaMua.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 66);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(85, 15);
			this.label8.TabIndex = 12;
			this.label8.Text = "Giá nhập mua";
			this.cbDVTMua.FormattingEnabled = true;
			this.cbDVTMua.Items.AddRange(new object[]
			{
				"",
				"Ấm",
				"Bao",
				"Bộ",
				"Cái",
				"Chai",
				"Chiếc",
				"Đĩa",
				"Đôi",
				"Gram",
				"Giờ",
				"Gói",
				"Hộp",
				"Kg",
				"Lon",
				"Ly",
				"ml",
				"Quả",
				"Suất",
				"Khác"
			});
			this.cbDVTMua.Location = new global::System.Drawing.Point(130, 90);
			this.cbDVTMua.Name = "cbDVTMua";
			this.cbDVTMua.Size = new global::System.Drawing.Size(150, 23);
			this.cbDVTMua.TabIndex = 11;
			this.cbDVTMua.SelectedIndexChanged += new global::System.EventHandler(this.cbDVTMua_SelectedIndexChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 93);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(89, 15);
			this.label7.TabIndex = 10;
			this.label7.Text = "ĐVT nhập mua";
			this.cbDVTBan.FormattingEnabled = true;
			this.cbDVTBan.Items.AddRange(new object[]
			{
				"",
				"Ấm",
				"Bao",
				"Bộ",
				"Cái",
				"Chai",
				"Chiếc",
				"Đĩa",
				"Đôi",
				"Gram",
				"Giờ",
				"Gói",
				"Hộp",
				"Kg",
				"Lon",
				"Ly",
				"ml",
				"Quả",
				"Suất",
				"Khác"
			});
			this.cbDVTBan.Location = new global::System.Drawing.Point(130, 146);
			this.cbDVTBan.Name = "cbDVTBan";
			this.cbDVTBan.Size = new global::System.Drawing.Size(150, 23);
			this.cbDVTBan.TabIndex = 9;
			this.cbDVTBan.SelectedIndexChanged += new global::System.EventHandler(this.cbDVTBan_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(6, 149);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(118, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "ĐVT bán, định lượng";
			this.txtGiaBan.Location = new global::System.Drawing.Point(130, 119);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.Size = new global::System.Drawing.Size(150, 21);
			this.txtGiaBan.TabIndex = 7;
			this.txtGiaBan.Text = "0";
			this.txtGiaBan.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiaBan_KeyDown);
			this.txtGiaBan.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 122);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(50, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Giá bán";
			this.txtTenSanPham.Location = new global::System.Drawing.Point(130, 36);
			this.txtTenSanPham.Name = "txtTenSanPham";
			this.txtTenSanPham.Size = new global::System.Drawing.Size(391, 21);
			this.txtTenSanPham.TabIndex = 3;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 39);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(59, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên hàng";
			this.txtMaSanPham.Location = new global::System.Drawing.Point(130, 9);
			this.txtMaSanPham.Name = "txtMaSanPham";
			this.txtMaSanPham.Size = new global::System.Drawing.Size(150, 21);
			this.txtMaSanPham.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 12);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(80, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã mặt hàng";
			this.btnRefresh.Location = new global::System.Drawing.Point(141, 366);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 13;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.btnSave.Location = new global::System.Drawing.Point(222, 366);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(303, 366);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 15;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(384, 366);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(90, 23);
			this.btnSaveExit.TabIndex = 16;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnExit.Location = new global::System.Drawing.Point(479, 366);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 17;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(572, 397);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.lblLine);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(588, 436);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(588, 436);
			base.Name = "frmMatHang";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mặt hàng";
			base.Load += new global::System.EventHandler(this.frmMatHang_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400030F RID: 783
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.ComboBox cbLoaiSanPham;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.ComboBox cbNhomSanPham;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.TextBox txtGiaMua;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.ComboBox cbDVTMua;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.ComboBox cbDVTBan;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.TextBox txtGiaBan;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.TextBox txtTenSanPham;

		// Token: 0x04000322 RID: 802
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.TextBox txtMaSanPham;

		// Token: 0x04000324 RID: 804
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000325 RID: 805
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x04000326 RID: 806
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000327 RID: 807
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x04000328 RID: 808
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x04000329 RID: 809
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x0400032A RID: 810
		private global::System.Windows.Forms.Label lblQuyDoi;

		// Token: 0x0400032B RID: 811
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.TextBox txtQuyDoi;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.Label lblDVTNhap;
	}
}

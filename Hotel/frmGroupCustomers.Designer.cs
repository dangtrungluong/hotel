namespace Hotel
{
	// Token: 0x0200000C RID: 12
	public partial class frmGroupCustomers : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00010814 File Offset: 0x0000EA14
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001084C File Offset: 0x0000EA4C
		private void InitializeComponent()
		{
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.txtGiamTienHang = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtGiamTienGio = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.txtGiamDichVu = new global::System.Windows.Forms.TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.txtGiamDoKhac = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtGiamDoAn = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtGiamDoUong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.txtDiemTichLuy = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTenNhomKhachHang = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblLine = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.btnExit.Location = new global::System.Drawing.Point(395, 448);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(300, 448);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(90, 23);
			this.btnSaveExit.TabIndex = 5;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(219, 448);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 4;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSave.Location = new global::System.Drawing.Point(138, 448);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 93);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(474, 349);
			this.tabControl1.TabIndex = 2;
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.txtDiemTichLuy);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtTenNhomKhachHang);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(466, 321);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Nhóm khách hàng";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.txtGiamTienHang);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtGiamTienGio);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox2.Location = new global::System.Drawing.Point(11, 65);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(437, 97);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Giảm giá tổng hóa đơn";
			this.txtGiamTienHang.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamTienHang.Location = new global::System.Drawing.Point(161, 26);
			this.txtGiamTienHang.Name = "txtGiamTienHang";
			this.txtGiamTienHang.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamTienHang.TabIndex = 1;
			this.txtGiamTienHang.Text = "0";
			this.txtGiamTienHang.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamTienHang_KeyDown);
			this.txtGiamTienHang.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamTienHang_KeyPress);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(19, 29);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(135, 15);
			this.label9.TabIndex = 0;
			this.label9.Text = "Tỉ lệ giảm giá tiền hàng";
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(233, 56);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(18, 15);
			this.label12.TabIndex = 5;
			this.label12.Text = "%";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(233, 29);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(18, 15);
			this.label11.TabIndex = 2;
			this.label11.Text = "%";
			this.txtGiamTienGio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamTienGio.Location = new global::System.Drawing.Point(161, 53);
			this.txtGiamTienGio.Name = "txtGiamTienGio";
			this.txtGiamTienGio.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamTienGio.TabIndex = 4;
			this.txtGiamTienGio.Text = "0";
			this.txtGiamTienGio.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamTienGio_KeyDown);
			this.txtGiamTienGio.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamTienGio_KeyPress);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(19, 56);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(124, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "Tỉ lệ giảm giá tiền giờ";
			this.groupBox1.Controls.Add(this.txtGiamDichVu);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtGiamDoKhac);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtGiamDoAn);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtGiamDoUong);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(10, 168);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(437, 147);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Giảm giá trên từng mặt hàng";
			this.txtGiamDichVu.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamDichVu.Location = new global::System.Drawing.Point(162, 80);
			this.txtGiamDichVu.Name = "txtGiamDichVu";
			this.txtGiamDichVu.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamDichVu.TabIndex = 7;
			this.txtGiamDichVu.Text = "0";
			this.txtGiamDichVu.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamDichVu_KeyDown);
			this.txtGiamDichVu.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamDichVu_KeyPress);
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(20, 83);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(102, 15);
			this.label8.TabIndex = 6;
			this.label8.Text = "Tỉ lệ giảm dịch vụ";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(234, 110);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(18, 15);
			this.label13.TabIndex = 11;
			this.label13.Text = "%";
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(234, 83);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(18, 15);
			this.label14.TabIndex = 8;
			this.label14.Text = "%";
			this.txtGiamDoKhac.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamDoKhac.Location = new global::System.Drawing.Point(162, 107);
			this.txtGiamDoKhac.Name = "txtGiamDoKhac";
			this.txtGiamDoKhac.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamDoKhac.TabIndex = 10;
			this.txtGiamDoKhac.Text = "0";
			this.txtGiamDoKhac.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamDoKhac_KeyDown);
			this.txtGiamDoKhac.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamDoKhac_KeyPress);
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.Location = new global::System.Drawing.Point(20, 110);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(107, 15);
			this.label15.TabIndex = 9;
			this.label15.Text = "Tỉ lệ giảm đồ khác";
			this.txtGiamDoAn.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamDoAn.Location = new global::System.Drawing.Point(162, 26);
			this.txtGiamDoAn.Name = "txtGiamDoAn";
			this.txtGiamDoAn.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamDoAn.TabIndex = 1;
			this.txtGiamDoAn.Text = "0";
			this.txtGiamDoAn.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamDoAn_KeyDown);
			this.txtGiamDoAn.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamDoAn_KeyPress);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(20, 29);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(95, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tỉ lệ giảm đồ ăn";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(234, 56);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(18, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "%";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(234, 29);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(18, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "%";
			this.txtGiamDoUong.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamDoUong.Location = new global::System.Drawing.Point(162, 53);
			this.txtGiamDoUong.Name = "txtGiamDoUong";
			this.txtGiamDoUong.Size = new global::System.Drawing.Size(66, 21);
			this.txtGiamDoUong.TabIndex = 4;
			this.txtGiamDoUong.Text = "0";
			this.txtGiamDoUong.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGiamDoUong_KeyDown);
			this.txtGiamDoUong.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamDoUong_KeyPress);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(20, 56);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(109, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "Tỉ lệ giảm đồ uống";
			this.txtDiemTichLuy.Location = new global::System.Drawing.Point(143, 38);
			this.txtDiemTichLuy.Name = "txtDiemTichLuy";
			this.txtDiemTichLuy.Size = new global::System.Drawing.Size(66, 21);
			this.txtDiemTichLuy.TabIndex = 3;
			this.txtDiemTichLuy.Text = "0";
			this.txtDiemTichLuy.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtDiemTichLuy_KeyDown);
			this.txtDiemTichLuy.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtDiemTichLuy_KeyPress);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 42);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(77, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Điểm tích lũy";
			this.txtTenNhomKhachHang.Location = new global::System.Drawing.Point(143, 12);
			this.txtTenNhomKhachHang.Name = "txtTenNhomKhachHang";
			this.txtTenNhomKhachHang.Size = new global::System.Drawing.Size(304, 21);
			this.txtTenNhomKhachHang.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(7, 14);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(130, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên nhóm khách hàng";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(72, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(129, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhóm khách hàng";
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-3, 66);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(28, 15);
			this.lblLine.TabIndex = 1;
			this.lblLine.Text = "___";
			this.pictureBox1.Image = global::Hotel.Properties.Resources.wizard;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(70, 62);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(477, 479);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.lblLine);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(493, 518);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(493, 518);
			base.Name = "frmGroupCustomers";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NHÓM KHÁCH HÀNG";
			base.Load += new global::System.EventHandler(this.frmCustomers_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000F6 RID: 246
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TextBox txtDiemTichLuy;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.TextBox txtTenNhomKhachHang;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.TextBox txtGiamTienHang;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.TextBox txtGiamTienGio;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.TextBox txtGiamDichVu;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.TextBox txtGiamDoKhac;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.TextBox txtGiamDoAn;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.TextBox txtGiamDoUong;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Label label7;
	}
}

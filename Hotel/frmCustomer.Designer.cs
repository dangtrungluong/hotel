namespace Hotel
{
	// Token: 0x02000009 RID: 9
	public partial class frmCustomer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000DC94 File Offset: 0x0000BE94
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000DCCC File Offset: 0x0000BECC
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblLine = new global::System.Windows.Forms.Label();
			this.txtMaKH = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtTenKH = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtDiaChi = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtDienThoai = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtCMND = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.dtNgay = new global::System.Windows.Forms.DateTimePicker();
			this.label8 = new global::System.Windows.Forms.Label();
			this.cbNoiCap = new global::System.Windows.Forms.ComboBox();
			this.txtMST = new global::System.Windows.Forms.TextBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.cbThanhVien = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtFax = new global::System.Windows.Forms.TextBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtEmail = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.txtHoChieu = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtGPLX = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.txtMaTheTu = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(72, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(86, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "Khách hàng";
			this.pictureBox1.Image = global::Hotel.Properties.Resources.wizard;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(70, 62);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-3, 66);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(28, 15);
			this.lblLine.TabIndex = 25;
			this.lblLine.Text = "___";
			this.txtMaKH.Location = new global::System.Drawing.Point(80, 92);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new global::System.Drawing.Size(116, 21);
			this.txtMaKH.TabIndex = 28;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 95);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(45, 15);
			this.label2.TabIndex = 27;
			this.label2.Text = "Mã KH";
			this.txtTenKH.Location = new global::System.Drawing.Point(278, 92);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new global::System.Drawing.Size(306, 21);
			this.txtTenKH.TabIndex = 30;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(221, 95);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(48, 15);
			this.label3.TabIndex = 29;
			this.label3.Text = "Tên KH";
			this.txtDiaChi.Location = new global::System.Drawing.Point(80, 119);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new global::System.Drawing.Size(504, 21);
			this.txtDiaChi.TabIndex = 32;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(11, 122);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(45, 15);
			this.label4.TabIndex = 31;
			this.label4.Text = "Địa chỉ";
			this.txtDienThoai.Location = new global::System.Drawing.Point(80, 146);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new global::System.Drawing.Size(116, 21);
			this.txtDienThoai.TabIndex = 34;
			this.txtDienThoai.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtDienThoai_KeyDown);
			this.txtDienThoai.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(11, 149);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(63, 15);
			this.label5.TabIndex = 33;
			this.label5.Text = "Điện thoại";
			this.txtCMND.Location = new global::System.Drawing.Point(80, 173);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new global::System.Drawing.Size(116, 21);
			this.txtCMND.TabIndex = 36;
			this.txtCMND.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtCMND_KeyDown);
			this.txtCMND.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(11, 176);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(62, 15);
			this.label6.TabIndex = 35;
			this.label6.Text = "Số CMND";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(211, 176);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(58, 15);
			this.label7.TabIndex = 37;
			this.label7.Text = "Ngày cấp";
			this.dtNgay.CustomFormat = "dd/MM/yyyy";
			this.dtNgay.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNgay.Location = new global::System.Drawing.Point(280, 173);
			this.dtNgay.Name = "dtNgay";
			this.dtNgay.Size = new global::System.Drawing.Size(100, 21);
			this.dtNgay.TabIndex = 48;
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(402, 176);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(49, 15);
			this.label8.TabIndex = 49;
			this.label8.Text = "Nơi cấp";
			this.cbNoiCap.FormattingEnabled = true;
			this.cbNoiCap.Location = new global::System.Drawing.Point(457, 173);
			this.cbNoiCap.Name = "cbNoiCap";
			this.cbNoiCap.Size = new global::System.Drawing.Size(127, 23);
			this.cbNoiCap.TabIndex = 50;
			this.txtMST.Location = new global::System.Drawing.Point(80, 227);
			this.txtMST.Name = "txtMST";
			this.txtMST.Size = new global::System.Drawing.Size(189, 21);
			this.txtMST.TabIndex = 52;
			this.txtMST.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtMST_KeyDown);
			this.txtMST.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtMST_KeyPress);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(11, 230);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(33, 15);
			this.label9.TabIndex = 51;
			this.label9.Text = "MST";
			this.cbThanhVien.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbThanhVien.FormattingEnabled = true;
			this.cbThanhVien.Location = new global::System.Drawing.Point(395, 254);
			this.cbThanhVien.Name = "cbThanhVien";
			this.cbThanhVien.Size = new global::System.Drawing.Size(189, 23);
			this.cbThanhVien.TabIndex = 54;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(312, 260);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(67, 15);
			this.label10.TabIndex = 53;
			this.label10.Text = "Thành viên";
			this.txtFax.Location = new global::System.Drawing.Point(457, 146);
			this.txtFax.Name = "txtFax";
			this.txtFax.Size = new global::System.Drawing.Size(127, 21);
			this.txtFax.TabIndex = 56;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(424, 149);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(27, 15);
			this.label11.TabIndex = 55;
			this.label11.Text = "Fax";
			this.txtEmail.Location = new global::System.Drawing.Point(395, 227);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new global::System.Drawing.Size(189, 21);
			this.txtEmail.TabIndex = 58;
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(312, 233);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(39, 15);
			this.label12.TabIndex = 57;
			this.label12.Text = "Email";
			this.txtHoChieu.Location = new global::System.Drawing.Point(80, 200);
			this.txtHoChieu.Name = "txtHoChieu";
			this.txtHoChieu.Size = new global::System.Drawing.Size(189, 21);
			this.txtHoChieu.TabIndex = 60;
			this.txtHoChieu.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtHoChieu_KeyDown);
			this.txtHoChieu.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtHoChieu_KeyPress);
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(11, 203);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(56, 15);
			this.label13.TabIndex = 59;
			this.label13.Text = "Hộ chiếu";
			this.txtGPLX.Location = new global::System.Drawing.Point(395, 200);
			this.txtGPLX.Name = "txtGPLX";
			this.txtGPLX.Size = new global::System.Drawing.Size(189, 21);
			this.txtGPLX.TabIndex = 62;
			this.txtGPLX.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtGPLX_KeyDown);
			this.txtGPLX.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGPLX_KeyPress);
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(312, 203);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(39, 15);
			this.label14.TabIndex = 61;
			this.label14.Text = "GPLX";
			this.txtMaTheTu.Location = new global::System.Drawing.Point(80, 254);
			this.txtMaTheTu.Name = "txtMaTheTu";
			this.txtMaTheTu.Size = new global::System.Drawing.Size(189, 21);
			this.txtMaTheTu.TabIndex = 64;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(11, 257);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(58, 15);
			this.label15.TabIndex = 63;
			this.label15.Text = "Mã thẻ từ";
			this.txtGhiChu.Location = new global::System.Drawing.Point(80, 284);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(504, 74);
			this.txtGhiChu.TabIndex = 66;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(11, 284);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(49, 15);
			this.label16.TabIndex = 65;
			this.label16.Text = "Ghi chú";
			this.btnExit.Location = new global::System.Drawing.Point(509, 375);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 70;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(413, 375);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(90, 23);
			this.btnSaveExit.TabIndex = 69;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(332, 375);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 68;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSave.Location = new global::System.Drawing.Point(251, 375);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 67;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(605, 412);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.txtGhiChu);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.txtMaTheTu);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.txtGPLX);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.txtHoChieu);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.txtEmail);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.txtFax);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.cbThanhVien);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.txtMST);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.cbNoiCap);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.dtNgay);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.txtCMND);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.txtDienThoai);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.txtDiaChi);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtTenKH);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.txtMaKH);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.lblLine);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(621, 451);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(621, 451);
			base.Name = "frmCustomer";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KHÁCH HÀNG";
			base.Load += new global::System.EventHandler(this.frmCustomer_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000BB RID: 187
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.TextBox txtMaKH;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.TextBox txtTenKH;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.TextBox txtDiaChi;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.TextBox txtDienThoai;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.TextBox txtCMND;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.DateTimePicker dtNgay;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.ComboBox cbNoiCap;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.TextBox txtMST;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ComboBox cbThanhVien;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TextBox txtFax;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.TextBox txtEmail;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.TextBox txtHoChieu;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TextBox txtGPLX;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.TextBox txtMaTheTu;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.TextBox txtGhiChu;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Button btnSave;
	}
}

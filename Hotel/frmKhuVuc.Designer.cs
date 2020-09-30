namespace Hotel
{
	// Token: 0x0200000F RID: 15
	public partial class frmKhuVuc : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000148DC File Offset: 0x00012ADC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00014914 File Offset: 0x00012B14
		private void InitializeComponent()
		{
			this.lblLine = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.cbGiaMatHang = new global::System.Windows.Forms.ComboBox();
			this.cbMauHoaDon = new global::System.Windows.Forms.ComboBox();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.cbKhoHang = new global::System.Windows.Forms.ComboBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTenKhuVuc = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(0, 58);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(28, 15);
			this.lblLine.TabIndex = 1;
			this.lblLine.Text = "___";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(65, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(61, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Khu vực";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(3, 85);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(508, 222);
			this.tabControl1.TabIndex = 2;
			this.tabPage1.Controls.Add(this.cbGiaMatHang);
			this.tabPage1.Controls.Add(this.cbMauHoaDon);
			this.tabPage1.Controls.Add(this.txtGhiChu);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.cbKhoHang);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtTenKhuVuc);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(500, 194);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Khu vực";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.cbGiaMatHang.FormattingEnabled = true;
			this.cbGiaMatHang.Items.AddRange(new object[]
			{
				"",
				"Giá chung",
				"Giá hiển thị để lựa chọn"
			});
			this.cbGiaMatHang.Location = new global::System.Drawing.Point(99, 33);
			this.cbGiaMatHang.Name = "cbGiaMatHang";
			this.cbGiaMatHang.Size = new global::System.Drawing.Size(334, 23);
			this.cbGiaMatHang.TabIndex = 3;
			this.cbGiaMatHang.SelectedValueChanged += new global::System.EventHandler(this.cbGiaMatHang_SelectedValueChanged);
			this.cbMauHoaDon.FormattingEnabled = true;
			this.cbMauHoaDon.Items.AddRange(new object[]
			{
				"",
				"Mẫu 54mm x 2 dòng",
				"Mẫu 80mm 2 ngôn ngữ",
				"Mẫu in bill 54mm",
				"Mẫu in bill 80( có chiết khấu)",
				"Mẫu in bill 80mm",
				"Mẫu in bill A4",
				"Mẫu in bill A5"
			});
			this.cbMauHoaDon.Location = new global::System.Drawing.Point(99, 92);
			this.cbMauHoaDon.Name = "cbMauHoaDon";
			this.cbMauHoaDon.Size = new global::System.Drawing.Size(334, 23);
			this.cbMauHoaDon.TabIndex = 7;
			this.cbMauHoaDon.SelectedValueChanged += new global::System.EventHandler(this.cbMauHoaDon_SelectedValueChanged);
			this.txtGhiChu.Location = new global::System.Drawing.Point(99, 121);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(334, 65);
			this.txtGhiChu.TabIndex = 9;
			this.txtGhiChu.TextChanged += new global::System.EventHandler(this.txtGhiChu_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(8, 124);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(49, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ghi chú";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(8, 95);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(80, 15);
			this.label8.TabIndex = 6;
			this.label8.Text = "Mẫu hóa đơn";
			this.cbKhoHang.FormattingEnabled = true;
			this.cbKhoHang.Items.AddRange(new object[]
			{
				"",
				"Kho bán hàng"
			});
			this.cbKhoHang.Location = new global::System.Drawing.Point(99, 63);
			this.cbKhoHang.Name = "cbKhoHang";
			this.cbKhoHang.Size = new global::System.Drawing.Size(334, 23);
			this.cbKhoHang.TabIndex = 5;
			this.cbKhoHang.SelectedValueChanged += new global::System.EventHandler(this.cbKhoHang_SelectedValueChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(8, 66);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(60, 15);
			this.label7.TabIndex = 4;
			this.label7.Text = "Kho hàng";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(8, 36);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(81, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giá mặt hàng";
			this.txtTenKhuVuc.Location = new global::System.Drawing.Point(99, 6);
			this.txtTenKhuVuc.Name = "txtTenKhuVuc";
			this.txtTenKhuVuc.Size = new global::System.Drawing.Size(334, 21);
			this.txtTenKhuVuc.TabIndex = 1;
			this.txtTenKhuVuc.TextChanged += new global::System.EventHandler(this.txtTenKhuVuc_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(8, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(72, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên khu vực";
			this.btnExit.Location = new global::System.Drawing.Point(432, 313);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(337, 313);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(90, 23);
			this.btnSaveExit.TabIndex = 6;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(256, 313);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 5;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSave.Location = new global::System.Drawing.Point(175, 313);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnRefresh.Location = new global::System.Drawing.Point(94, 313);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 3;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.pictureBox1.Image = global::Hotel.Properties.Resources.Edit;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 54);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(515, 345);
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
			base.MinimizeBox = false;
			base.Name = "frmKhuVuc";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khu Vực ";
			base.Load += new global::System.EventHandler(this.frmKhuVuc_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000143 RID: 323
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.ComboBox cbKhoHang;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.TextBox txtTenKhuVuc;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.ComboBox cbMauHoaDon;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.TextBox txtGhiChu;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.ComboBox cbGiaMatHang;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.Button btnRefresh;
	}
}

namespace Hotel
{
	// Token: 0x02000005 RID: 5
	public partial class frmAddNewGroupItems : global::System.Windows.Forms.Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00009A38 File Offset: 0x00007C38
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00009A70 File Offset: 0x00007C70
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblLine = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTenNhomMatHang = new global::System.Windows.Forms.TextBox();
			this.txtDanhMaSanPham = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.cbLoaiSanPham = new global::System.Windows.Forms.ComboBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnSave_New = new global::System.Windows.Forms.Button();
			this.btnSave_Exit = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnDanhMuc = new global::System.Windows.Forms.Button();
			this.btnTai = new global::System.Windows.Forms.Button();
			this.btnThem = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(72, 23);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(163, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhóm mặt hàng";
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-1, 67);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(0, 15);
			this.lblLine.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(13, 111);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(118, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tên nhóm mặt hàng";
			this.txtTenNhomMatHang.Location = new global::System.Drawing.Point(137, 108);
			this.txtTenNhomMatHang.Name = "txtTenNhomMatHang";
			this.txtTenNhomMatHang.Size = new global::System.Drawing.Size(257, 21);
			this.txtTenNhomMatHang.TabIndex = 4;
			this.txtTenNhomMatHang.Click += new global::System.EventHandler(this.txtTenNhomMatHang_Click);
			this.txtTenNhomMatHang.TextChanged += new global::System.EventHandler(this.txtTenNhomMatHang_TextChanged);
			this.txtDanhMaSanPham.Location = new global::System.Drawing.Point(137, 144);
			this.txtDanhMaSanPham.Name = "txtDanhMaSanPham";
			this.txtDanhMaSanPham.Size = new global::System.Drawing.Size(257, 21);
			this.txtDanhMaSanPham.TabIndex = 6;
			this.txtDanhMaSanPham.TextChanged += new global::System.EventHandler(this.txtDanhMaSanPham_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(13, 147);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(116, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Đánh mã sản phẩm";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(24, 23);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(89, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Loại sản phẩm";
			this.cbLoaiSanPham.FormattingEnabled = true;
			this.cbLoaiSanPham.Location = new global::System.Drawing.Point(121, 20);
			this.cbLoaiSanPham.Name = "cbLoaiSanPham";
			this.cbLoaiSanPham.Size = new global::System.Drawing.Size(165, 23);
			this.cbLoaiSanPham.TabIndex = 1;
			this.cbLoaiSanPham.DropDown += new global::System.EventHandler(this.cbLoaiDo_DropDown);
			this.cbLoaiSanPham.SelectedValueChanged += new global::System.EventHandler(this.cbLoaiSanPham_SelectedValueChanged);
			this.btnSave.Location = new global::System.Drawing.Point(129, 291);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnSave_New.Location = new global::System.Drawing.Point(210, 291);
			this.btnSave_New.Name = "btnSave_New";
			this.btnSave_New.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave_New.TabIndex = 9;
			this.btnSave_New.Text = "Lưu & Mới";
			this.btnSave_New.UseMnemonic = false;
			this.btnSave_New.UseVisualStyleBackColor = true;
			this.btnSave_New.Click += new global::System.EventHandler(this.btnSave_New_Click);
			this.btnSave_Exit.Location = new global::System.Drawing.Point(291, 291);
			this.btnSave_Exit.Name = "btnSave_Exit";
			this.btnSave_Exit.Size = new global::System.Drawing.Size(84, 23);
			this.btnSave_Exit.TabIndex = 10;
			this.btnSave_Exit.Text = "Lưu & Thoát";
			this.btnSave_Exit.UseMnemonic = false;
			this.btnSave_Exit.UseVisualStyleBackColor = true;
			this.btnSave_Exit.Click += new global::System.EventHandler(this.btnSave_Exit_Click);
			this.btnExit.Location = new global::System.Drawing.Point(381, 291);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.groupBox1.BackColor = global::System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.btnDanhMuc);
			this.groupBox1.Controls.Add(this.btnTai);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.cbLoaiSanPham);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new global::System.Drawing.Point(16, 171);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(378, 96);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Loại sản phẩm";
			this.btnDanhMuc.Location = new global::System.Drawing.Point(292, 59);
			this.btnDanhMuc.Name = "btnDanhMuc";
			this.btnDanhMuc.Size = new global::System.Drawing.Size(75, 23);
			this.btnDanhMuc.TabIndex = 4;
			this.btnDanhMuc.Text = "Danh mục";
			this.btnDanhMuc.UseMnemonic = false;
			this.btnDanhMuc.UseVisualStyleBackColor = true;
			this.btnDanhMuc.Click += new global::System.EventHandler(this.btnDanhMuc_Click);
			this.btnTai.Location = new global::System.Drawing.Point(211, 59);
			this.btnTai.Name = "btnTai";
			this.btnTai.Size = new global::System.Drawing.Size(75, 23);
			this.btnTai.TabIndex = 3;
			this.btnTai.Text = "Tải lại";
			this.btnTai.UseMnemonic = false;
			this.btnTai.UseVisualStyleBackColor = true;
			this.btnTai.Click += new global::System.EventHandler(this.btnTai_Click);
			this.btnThem.Location = new global::System.Drawing.Point(130, 59);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new global::System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new global::System.EventHandler(this.btnThem_Click);
			this.pictureBox1.Image = global::Hotel.Properties.Resources.beer;
			this.pictureBox1.Location = new global::System.Drawing.Point(2, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(466, 326);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSave_Exit);
			base.Controls.Add(this.btnSave_New);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.txtDanhMaSanPham);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtTenNhomMatHang);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lblLine);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(482, 365);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(482, 365);
			base.Name = "frmAddNewGroupItems";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nhóm mặt hàng ";
			base.Load += new global::System.EventHandler(this.frmAddNewGroupItems_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007B RID: 123
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.TextBox txtTenNhomMatHang;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.TextBox txtDanhMaSanPham;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.ComboBox cbLoaiSanPham;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button btnSave_New;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button btnSave_Exit;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Button btnDanhMuc;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Button btnTai;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Button btnThem;
	}
}

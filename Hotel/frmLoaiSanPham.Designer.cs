namespace Hotel
{
	// Token: 0x02000011 RID: 17
	public partial class frmLoaiSanPham : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00017AF0 File Offset: 0x00015CF0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00017B28 File Offset: 0x00015D28
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hotel.frmLoaiSanPham));
			this.lblLine = new global::System.Windows.Forms.Label();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.txtLoaiSanPham = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.btnLuu = new global::System.Windows.Forms.Button();
			this.btnThoat = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-2, 78);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(0, 15);
			this.lblLine.TabIndex = 5;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.Location = new global::System.Drawing.Point(83, 28);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(122, 18);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Chỉnh sửa loại đồ";
			this.txtLoaiSanPham.Location = new global::System.Drawing.Point(102, 116);
			this.txtLoaiSanPham.Name = "txtLoaiSanPham";
			this.txtLoaiSanPham.Size = new global::System.Drawing.Size(288, 21);
			this.txtLoaiSanPham.TabIndex = 7;
			this.txtLoaiSanPham.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtLoaiSanPham_KeyPress);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(10, 119);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(89, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Loại sản phẩm";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(10, 163);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(49, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ghi chú";
			this.txtGhiChu.Location = new global::System.Drawing.Point(102, 163);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(288, 119);
			this.txtGhiChu.TabIndex = 9;
			this.btnLuu.Location = new global::System.Drawing.Point(234, 297);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new global::System.Drawing.Size(75, 23);
			this.btnLuu.TabIndex = 10;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new global::System.EventHandler(this.btnLuu_Click);
			this.btnThoat.Location = new global::System.Drawing.Point(315, 297);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new global::System.Drawing.Size(75, 23);
			this.btnThoat.TabIndex = 11;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new global::System.EventHandler(this.btnThoat_Click);
			this.pictureBox1.Image = global::Hotel.Properties.Resources.beer;
			this.pictureBox1.Location = new global::System.Drawing.Point(1, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(75, 74);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(396, 332);
			base.Controls.Add(this.btnThoat);
			base.Controls.Add(this.btnLuu);
			base.Controls.Add(this.txtGhiChu);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtLoaiSanPham);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.lblLine);
			base.Controls.Add(this.lblTitle);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(412, 371);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(412, 371);
			base.Name = "frmLoaiSanPham";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại sản phẩm";
			base.Load += new global::System.EventHandler(this.frmSanPham_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000178 RID: 376
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.TextBox txtLoaiSanPham;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.TextBox txtGhiChu;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Button btnLuu;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Button btnThoat;
	}
}

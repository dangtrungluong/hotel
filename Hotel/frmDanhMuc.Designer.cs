namespace Hotel
{
	// Token: 0x0200000D RID: 13
	public partial class frmDanhMuc : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x000128EC File Offset: 0x00010AEC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00012924 File Offset: 0x00010B24
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.lblLine = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnThemMoi = new global::System.Windows.Forms.Button();
			this.btnSua = new global::System.Windows.Forms.Button();
			this.btnXoa = new global::System.Windows.Forms.Button();
			this.btnThoat = new global::System.Windows.Forms.Button();
			this.imgListIcon = new global::System.Windows.Forms.ImageList(this.components);
			this.lstViewDanhMuc = new global::System.Windows.Forms.ListView();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-2, 90);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(0, 15);
			this.lblLine.TabIndex = 8;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(97, 32);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(353, 18);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cho phép bạn quản lý và chỉnh sửa danh mục loại đồ";
			this.btnThemMoi.Location = new global::System.Drawing.Point(94, 446);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new global::System.Drawing.Size(87, 27);
			this.btnThemMoi.TabIndex = 10;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new global::System.EventHandler(this.btnThemMoi_Click);
			this.btnSua.Location = new global::System.Drawing.Point(187, 446);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new global::System.Drawing.Size(87, 27);
			this.btnSua.TabIndex = 11;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new global::System.EventHandler(this.btnSua_Click);
			this.btnXoa.Location = new global::System.Drawing.Point(280, 446);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new global::System.Drawing.Size(87, 27);
			this.btnXoa.TabIndex = 12;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new global::System.EventHandler(this.btnXoa_Click);
			this.btnThoat.Location = new global::System.Drawing.Point(373, 446);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new global::System.Drawing.Size(87, 27);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new global::System.EventHandler(this.btnThoat_Click);
			this.imgListIcon.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListIcon.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgListIcon.TransparentColor = global::System.Drawing.Color.Transparent;
			this.lstViewDanhMuc.Location = new global::System.Drawing.Point(1, 108);
			this.lstViewDanhMuc.MultiSelect = false;
			this.lstViewDanhMuc.Name = "lstViewDanhMuc";
			this.lstViewDanhMuc.Size = new global::System.Drawing.Size(471, 332);
			this.lstViewDanhMuc.TabIndex = 14;
			this.lstViewDanhMuc.UseCompatibleStateImageBehavior = false;
			this.lstViewDanhMuc.ItemActivate += new global::System.EventHandler(this.lstViewDanhMuc_ItemActivate);
			this.lstViewDanhMuc.SelectedIndexChanged += new global::System.EventHandler(this.lstViewDanhMuc_SelectedIndexChanged);
			this.pictureBox1.Image = global::Hotel.Properties.Resources.beer;
			this.pictureBox1.Location = new global::System.Drawing.Point(1, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(87, 85);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(472, 485);
			base.Controls.Add(this.lstViewDanhMuc);
			base.Controls.Add(this.btnThoat);
			base.Controls.Add(this.btnXoa);
			base.Controls.Add(this.btnSua);
			base.Controls.Add(this.btnThemMoi);
			base.Controls.Add(this.lblLine);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(488, 524);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(488, 524);
			base.Name = "frmDanhMuc";
			this.Text = "Danh mục loại đồ";
			base.Load += new global::System.EventHandler(this.frmDanhMuc_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400011B RID: 283
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.Button btnThemMoi;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.Button btnSua;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.Button btnXoa;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.Button btnThoat;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ImageList imgListIcon;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ListView lstViewDanhMuc;
	}
}

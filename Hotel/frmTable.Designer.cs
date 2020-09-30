namespace Hotel
{
	// Token: 0x02000018 RID: 24
	public partial class frmTable : global::System.Windows.Forms.Form
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000312F8 File Offset: 0x0002F4F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00031330 File Offset: 0x0002F530
		private void InitializeComponent()
		{
			this.lblLine = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cbLoaiPhong = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.cbNhomHienThi = new global::System.Windows.Forms.ComboBox();
			this.cbKhuVuc = new global::System.Windows.Forms.ComboBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtTienMoBan = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTenBan = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			base.SuspendLayout();
			this.lblLine.AutoSize = true;
			this.lblLine.Location = new global::System.Drawing.Point(-2, 68);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new global::System.Drawing.Size(28, 15);
			this.lblLine.TabIndex = 14;
			this.lblLine.Text = "___";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(73, 22);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(34, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "Bàn";
			this.pictureBox1.Image = global::Hotel.Properties.Resources.table3;
			this.pictureBox1.Location = new global::System.Drawing.Point(1, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(70, 62);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(1, 96);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(471, 270);
			this.tabControl1.TabIndex = 16;
			this.tabPage1.Controls.Add(this.txtGhiChu);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.cbLoaiPhong);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.cbNhomHienThi);
			this.tabPage1.Controls.Add(this.cbKhuVuc);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.txtTienMoBan);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txtTenBan);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(463, 242);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Thông tin bàn";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.txtGhiChu.Location = new global::System.Drawing.Point(97, 151);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(349, 74);
			this.txtGhiChu.TabIndex = 13;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(7, 154);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(49, 15);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ghi chú";
			this.cbLoaiPhong.FormattingEnabled = true;
			this.cbLoaiPhong.Location = new global::System.Drawing.Point(97, 122);
			this.cbLoaiPhong.Name = "cbLoaiPhong";
			this.cbLoaiPhong.Size = new global::System.Drawing.Size(349, 23);
			this.cbLoaiPhong.TabIndex = 11;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(7, 125);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(69, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Loại phòng";
			this.cbNhomHienThi.FormattingEnabled = true;
			this.cbNhomHienThi.Location = new global::System.Drawing.Point(97, 93);
			this.cbNhomHienThi.Name = "cbNhomHienThi";
			this.cbNhomHienThi.Size = new global::System.Drawing.Size(349, 23);
			this.cbNhomHienThi.TabIndex = 9;
			this.cbKhuVuc.FormattingEnabled = true;
			this.cbKhuVuc.Location = new global::System.Drawing.Point(97, 64);
			this.cbKhuVuc.Name = "cbKhuVuc";
			this.cbKhuVuc.Size = new global::System.Drawing.Size(349, 23);
			this.cbKhuVuc.TabIndex = 8;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(7, 96);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(84, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "Nhóm hiển thị";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 67);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(50, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Khu vực";
			this.txtTienMoBan.Location = new global::System.Drawing.Point(97, 37);
			this.txtTienMoBan.Name = "txtTienMoBan";
			this.txtTienMoBan.Size = new global::System.Drawing.Size(349, 21);
			this.txtTienMoBan.TabIndex = 3;
			this.txtTienMoBan.Text = "0";
			this.txtTienMoBan.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtTienMoBan_KeyDown);
			this.txtTienMoBan.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtTienMoBan_KeyPress);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(7, 40);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(76, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tiền mở bàn";
			this.txtTenBan.Location = new global::System.Drawing.Point(97, 10);
			this.txtTenBan.Name = "txtTenBan";
			this.txtTenBan.Size = new global::System.Drawing.Size(349, 21);
			this.txtTenBan.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(7, 13);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên bàn";
			this.btnExit.Location = new global::System.Drawing.Point(393, 373);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 20;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(297, 373);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(90, 23);
			this.btnSaveExit.TabIndex = 19;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(216, 373);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 18;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSave.Location = new global::System.Drawing.Point(135, 373);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(476, 408);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.lblLine);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(492, 447);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(492, 447);
			base.Name = "frmTable";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bàn ";
			base.Load += new global::System.EventHandler(this.Table_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000353 RID: 851
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.Label lblLine;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000356 RID: 854
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000357 RID: 855
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000358 RID: 856
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000359 RID: 857
		private global::System.Windows.Forms.TextBox txtGhiChu;

		// Token: 0x0400035A RID: 858
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400035B RID: 859
		private global::System.Windows.Forms.ComboBox cbLoaiPhong;

		// Token: 0x0400035C RID: 860
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400035D RID: 861
		private global::System.Windows.Forms.ComboBox cbNhomHienThi;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.ComboBox cbKhuVuc;

		// Token: 0x0400035F RID: 863
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.TextBox txtTienMoBan;

		// Token: 0x04000362 RID: 866
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000363 RID: 867
		private global::System.Windows.Forms.TextBox txtTenBan;

		// Token: 0x04000364 RID: 868
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000365 RID: 869
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.Button btnSave;
	}
}

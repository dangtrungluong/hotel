namespace Hotel
{
	// Token: 0x02000015 RID: 21
	public partial class frmRoomType : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0002F9DC File Offset: 0x0002DBDC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002FA14 File Offset: 0x0002DC14
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtLoaiPhong = new global::System.Windows.Forms.TextBox();
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.txtForeColor = new global::System.Windows.Forms.TextBox();
			this.txtBackColor = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtDisplay = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtNote = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnSaveNew = new global::System.Windows.Forms.Button();
			this.btnSaveExit = new global::System.Windows.Forms.Button();
			this.btnExit = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(89, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên loại phòng";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(55, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Màu chữ";
			this.txtLoaiPhong.Location = new global::System.Drawing.Point(107, 22);
			this.txtLoaiPhong.Name = "txtLoaiPhong";
			this.txtLoaiPhong.Size = new global::System.Drawing.Size(315, 21);
			this.txtLoaiPhong.TabIndex = 2;
			this.txtLoaiPhong.TextChanged += new global::System.EventHandler(this.txtLoaiPhong_TextChanged);
			this.txtLoaiPhong.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtLoaiPhong_KeyPress);
			this.txtForeColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtForeColor.Location = new global::System.Drawing.Point(107, 49);
			this.txtForeColor.Name = "txtForeColor";
			this.txtForeColor.ReadOnly = true;
			this.txtForeColor.Size = new global::System.Drawing.Size(315, 21);
			this.txtForeColor.TabIndex = 3;
			this.txtForeColor.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.txtForeColor_MouseClick);
			this.txtForeColor.BackColorChanged += new global::System.EventHandler(this.txtForeColor_BackColorChanged);
			this.txtBackColor.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtBackColor.Location = new global::System.Drawing.Point(107, 76);
			this.txtBackColor.Name = "txtBackColor";
			this.txtBackColor.ReadOnly = true;
			this.txtBackColor.Size = new global::System.Drawing.Size(315, 21);
			this.txtBackColor.TabIndex = 5;
			this.txtBackColor.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.txtBackColor_MouseClick);
			this.txtBackColor.BackColorChanged += new global::System.EventHandler(this.txtBackColor_BackColorChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(56, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Màu nền";
			this.txtDisplay.Location = new global::System.Drawing.Point(107, 103);
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ReadOnly = true;
			this.txtDisplay.Size = new global::System.Drawing.Size(315, 21);
			this.txtDisplay.TabIndex = 7;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 106);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(49, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Hiển thị";
			this.txtNote.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtNote.Location = new global::System.Drawing.Point(107, 130);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new global::System.Drawing.Size(315, 118);
			this.txtNote.TabIndex = 9;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(12, 133);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(49, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Ghi chú";
			this.btnSave.Location = new global::System.Drawing.Point(93, 265);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnSaveNew.Location = new global::System.Drawing.Point(174, 265);
			this.btnSaveNew.Name = "btnSaveNew";
			this.btnSaveNew.Size = new global::System.Drawing.Size(75, 23);
			this.btnSaveNew.TabIndex = 11;
			this.btnSaveNew.Text = "Lưu & Mới";
			this.btnSaveNew.UseMnemonic = false;
			this.btnSaveNew.UseVisualStyleBackColor = true;
			this.btnSaveNew.Click += new global::System.EventHandler(this.btnSaveNew_Click);
			this.btnSaveExit.Location = new global::System.Drawing.Point(255, 265);
			this.btnSaveExit.Name = "btnSaveExit";
			this.btnSaveExit.Size = new global::System.Drawing.Size(86, 23);
			this.btnSaveExit.TabIndex = 12;
			this.btnSaveExit.Text = "Lưu & Thoát";
			this.btnSaveExit.UseMnemonic = false;
			this.btnSaveExit.UseVisualStyleBackColor = true;
			this.btnSaveExit.Click += new global::System.EventHandler(this.btnSaveExit_Click);
			this.btnExit.Location = new global::System.Drawing.Point(347, 265);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(437, 301);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnSaveExit);
			base.Controls.Add(this.btnSaveNew);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.txtNote);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.txtDisplay);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtBackColor);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.txtForeColor);
			base.Controls.Add(this.txtLoaiPhong);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(453, 340);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(453, 340);
			base.Name = "frmRoomType";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại phòng";
			base.Load += new global::System.EventHandler(this.frmRoomType_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000337 RID: 823
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.TextBox txtLoaiPhong;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.TextBox txtForeColor;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.TextBox txtBackColor;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400033F RID: 831
		private global::System.Windows.Forms.TextBox txtDisplay;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.TextBox txtNote;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Button btnSaveNew;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Button btnSaveExit;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.Button btnExit;
	}
}

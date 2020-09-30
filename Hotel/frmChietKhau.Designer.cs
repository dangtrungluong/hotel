namespace Hotel
{
	// Token: 0x02000007 RID: 7
	public partial class frmChietKhau : global::System.Windows.Forms.Form
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000B900 File Offset: 0x00009B00
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B938 File Offset: 0x00009B38
		private void InitializeComponent()
		{
			this.btnHuy = new global::System.Windows.Forms.Button();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.txtDonGia = new global::System.Windows.Forms.TextBox();
			this.lblCommon = new global::System.Windows.Forms.Label();
			this.rdGiamPhanTram = new global::System.Windows.Forms.RadioButton();
			this.rdGiamTien = new global::System.Windows.Forms.RadioButton();
			this.txtGiamPhanTram = new global::System.Windows.Forms.TextBox();
			this.txtGiamTien = new global::System.Windows.Forms.TextBox();
			this.lblNote = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lblLabel = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.btnHuy.Location = new global::System.Drawing.Point(258, 220);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new global::System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 10;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			this.btnOK.Location = new global::System.Drawing.Point(177, 220);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.txtDonGia.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 128);
			this.txtDonGia.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDonGia.ForeColor = global::System.Drawing.Color.Black;
			this.txtDonGia.Location = new global::System.Drawing.Point(128, 65);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.ReadOnly = true;
			this.txtDonGia.Size = new global::System.Drawing.Size(141, 24);
			this.txtDonGia.TabIndex = 8;
			this.txtDonGia.Text = "0";
			this.lblCommon.AutoSize = true;
			this.lblCommon.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCommon.Location = new global::System.Drawing.Point(12, 68);
			this.lblCommon.Name = "lblCommon";
			this.lblCommon.Size = new global::System.Drawing.Size(88, 18);
			this.lblCommon.TabIndex = 7;
			this.lblCommon.Text = "Đơn giá gốc";
			this.lblCommon.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.rdGiamPhanTram.AutoSize = true;
			this.rdGiamPhanTram.Location = new global::System.Drawing.Point(15, 98);
			this.rdGiamPhanTram.Name = "rdGiamPhanTram";
			this.rdGiamPhanTram.Size = new global::System.Drawing.Size(96, 19);
			this.rdGiamPhanTram.TabIndex = 11;
			this.rdGiamPhanTram.TabStop = true;
			this.rdGiamPhanTram.Text = "Giảm theo %";
			this.rdGiamPhanTram.UseVisualStyleBackColor = true;
			this.rdGiamPhanTram.CheckedChanged += new global::System.EventHandler(this.rdGiamPhanTram_CheckedChanged);
			this.rdGiamTien.AutoSize = true;
			this.rdGiamTien.Location = new global::System.Drawing.Point(15, 128);
			this.rdGiamTien.Name = "rdGiamTien";
			this.rdGiamTien.Size = new global::System.Drawing.Size(105, 19);
			this.rdGiamTien.TabIndex = 12;
			this.rdGiamTien.TabStop = true;
			this.rdGiamTien.Text = "Giảm theo tiền";
			this.rdGiamTien.UseVisualStyleBackColor = true;
			this.rdGiamTien.CheckedChanged += new global::System.EventHandler(this.rdGiamTien_CheckedChanged);
			this.txtGiamPhanTram.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamPhanTram.Location = new global::System.Drawing.Point(128, 95);
			this.txtGiamPhanTram.MaxLength = 6;
			this.txtGiamPhanTram.Name = "txtGiamPhanTram";
			this.txtGiamPhanTram.Size = new global::System.Drawing.Size(141, 24);
			this.txtGiamPhanTram.TabIndex = 13;
			this.txtGiamPhanTram.Text = "0";
			this.txtGiamPhanTram.TextChanged += new global::System.EventHandler(this.txtGiamPhanTram_TextChanged);
			this.txtGiamPhanTram.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamPhanTram_KeyPress);
			this.txtGiamTien.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGiamTien.Location = new global::System.Drawing.Point(128, 125);
			this.txtGiamTien.MaxLength = 7;
			this.txtGiamTien.Name = "txtGiamTien";
			this.txtGiamTien.Size = new global::System.Drawing.Size(141, 24);
			this.txtGiamTien.TabIndex = 14;
			this.txtGiamTien.Text = "0";
			this.txtGiamTien.TextChanged += new global::System.EventHandler(this.txtGiamTien_TextChanged);
			this.txtGiamTien.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtGiamTien_KeyPress);
			this.lblNote.AutoSize = true;
			this.lblNote.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNote.ForeColor = global::System.Drawing.Color.Blue;
			this.lblNote.Location = new global::System.Drawing.Point(12, 169);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new global::System.Drawing.Size(0, 15);
			this.lblNote.TabIndex = 15;
			this.lblNote.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lblLabel);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(346, 59);
			this.panel1.TabIndex = 16;
			this.lblLabel.AutoSize = true;
			this.lblLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblLabel.Location = new global::System.Drawing.Point(68, 20);
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new global::System.Drawing.Size(184, 18);
			this.lblLabel.TabIndex = 0;
			this.lblLabel.Text = "Đặt giảm giá cho mặt hàng";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(345, 255);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.lblNote);
			base.Controls.Add(this.txtGiamTien);
			base.Controls.Add(this.txtGiamPhanTram);
			base.Controls.Add(this.rdGiamTien);
			base.Controls.Add(this.rdGiamPhanTram);
			base.Controls.Add(this.btnHuy);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtDonGia);
			base.Controls.Add(this.lblCommon);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(361, 294);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(361, 294);
			base.Name = "frmChietKhau";
			this.Text = "ĐẶT GIẢM GIÁ";
			base.Load += new global::System.EventHandler(this.frmChietKhau_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400009D RID: 157
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label lblCommon;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.RadioButton rdGiamPhanTram;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.RadioButton rdGiamTien;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label lblNote;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Label lblLabel;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.TextBox txtGiamPhanTram;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.TextBox txtGiamTien;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.TextBox txtDonGia;
	}
}

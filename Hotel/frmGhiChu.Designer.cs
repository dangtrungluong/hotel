namespace Hotel
{
	// Token: 0x0200000B RID: 11
	public partial class frmGhiChu : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000F808 File Offset: 0x0000DA08
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtGhiChu = new global::System.Windows.Forms.TextBox();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnHuy = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(80, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập ghi chú";
			this.txtGhiChu.Location = new global::System.Drawing.Point(15, 37);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(441, 135);
			this.txtGhiChu.TabIndex = 1;
			this.btnOK.Location = new global::System.Drawing.Point(300, 178);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.btnHuy.Location = new global::System.Drawing.Point(381, 178);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new global::System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 3;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(468, 208);
			base.Controls.Add(this.btnHuy);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtGhiChu);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(484, 247);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(484, 247);
			base.Name = "frmGhiChu";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GHI CHÚ";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000EA RID: 234
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x040000EE RID: 238
		public global::System.Windows.Forms.TextBox txtGhiChu;
	}
}

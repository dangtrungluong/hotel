namespace Hotel
{
	// Token: 0x0200000A RID: 10
	public partial class frmCommon : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000F280 File Offset: 0x0000D480
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private void InitializeComponent()
		{
			this.lblLabel = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lblCommon = new global::System.Windows.Forms.Label();
			this.txtCommon = new global::System.Windows.Forms.TextBox();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.btnHuy = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.lblLabel.AutoSize = true;
			this.lblLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblLabel.Location = new global::System.Drawing.Point(55, 17);
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new global::System.Drawing.Size(157, 18);
			this.lblLabel.TabIndex = 0;
			this.lblLabel.Text = "Đặt số lượng mặt hàng";
			this.lblLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lblLabel);
			this.panel1.Location = new global::System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(273, 52);
			this.panel1.TabIndex = 1;
			this.lblCommon.AutoSize = true;
			this.lblCommon.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCommon.Location = new global::System.Drawing.Point(12, 73);
			this.lblCommon.Name = "lblCommon";
			this.lblCommon.Size = new global::System.Drawing.Size(67, 18);
			this.lblCommon.TabIndex = 2;
			this.lblCommon.Text = "Số lượng";
			this.lblCommon.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.txtCommon.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtCommon.Location = new global::System.Drawing.Point(85, 70);
			this.txtCommon.Name = "txtCommon";
			this.txtCommon.Size = new global::System.Drawing.Size(177, 24);
			this.txtCommon.TabIndex = 3;
			this.txtCommon.Text = "1";
			this.txtCommon.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtCommon_KeyDown);
			this.txtCommon.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtCommon_KeyPress);
			this.btnOK.Location = new global::System.Drawing.Point(106, 108);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.btnHuy.Location = new global::System.Drawing.Point(187, 108);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new global::System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 5;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new global::System.EventHandler(this.btnHuy_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(274, 143);
			base.Controls.Add(this.btnHuy);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.txtCommon);
			base.Controls.Add(this.lblCommon);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(290, 182);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(290, 182);
			base.Name = "frmCommon";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ĐẶT SỐ LƯỢNG";
			base.Load += new global::System.EventHandler(this.frmCommon_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000E3 RID: 227
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Label lblLabel;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Label lblCommon;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Button btnHuy;

		// Token: 0x040000E9 RID: 233
		public global::System.Windows.Forms.TextBox txtCommon;
	}
}

namespace Hotel
{
	// Token: 0x02000006 RID: 6
	public partial class frmChangePassword : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000AB9C File Offset: 0x00008D9C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		private void InitializeComponent()
		{
			this.btnExit = new global::System.Windows.Forms.Button();
			this.btnChangePassword = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtPassword2 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtPassword1 = new global::System.Windows.Forms.TextBox();
			this.txtUser = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btnExit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnExit.Location = new global::System.Drawing.Point(285, 153);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new global::System.Drawing.Size(80, 33);
			this.btnExit.TabIndex = 23;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new global::System.EventHandler(this.btnExit_Click);
			this.btnChangePassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnChangePassword.Location = new global::System.Drawing.Point(192, 153);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new global::System.Drawing.Size(80, 33);
			this.btnChangePassword.TabIndex = 22;
			this.btnChangePassword.Text = "Đồng ý";
			this.btnChangePassword.UseVisualStyleBackColor = true;
			this.btnChangePassword.Click += new global::System.EventHandler(this.btnChangePassword_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Red;
			this.label4.Location = new global::System.Drawing.Point(13, 112);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(259, 32);
			this.label4.TabIndex = 21;
			this.label4.Text = "Ghi chú: Quý khách nhớ mật khẩu của mình\r\nđể đăng nhập lần sau";
			this.txtPassword2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword2.Location = new global::System.Drawing.Point(137, 72);
			this.txtPassword2.Name = "txtPassword2";
			this.txtPassword2.PasswordChar = '*';
			this.txtPassword2.Size = new global::System.Drawing.Size(228, 22);
			this.txtPassword2.TabIndex = 20;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(13, 75);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(118, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "Nhập lại mật khẩu:";
			this.txtPassword1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword1.Location = new global::System.Drawing.Point(137, 42);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.PasswordChar = '*';
			this.txtPassword1.Size = new global::System.Drawing.Size(228, 22);
			this.txtPassword1.TabIndex = 18;
			this.txtUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUser.Location = new global::System.Drawing.Point(137, 12);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new global::System.Drawing.Size(228, 22);
			this.txtUser.TabIndex = 17;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(41, 45);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(90, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Mật khẩu mới:";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(51, 15);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(80, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Người dùng:";
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.Location = new global::System.Drawing.Point(13, 161);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(0, 16);
			this.lblStatus.TabIndex = 24;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(378, 198);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.btnExit);
			base.Controls.Add(this.btnChangePassword);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtPassword2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.txtPassword1);
			base.Controls.Add(this.txtUser);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmChangePassword";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đổi mật khẩu";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmChangePassword_FormClosed);
			base.Load += new global::System.EventHandler(this.frmChangePassword_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000090 RID: 144
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Button btnExit;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Button btnChangePassword;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.TextBox txtPassword2;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.TextBox txtPassword1;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.TextBox txtUser;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Label lblStatus;
	}
}

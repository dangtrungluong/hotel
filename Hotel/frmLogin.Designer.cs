namespace Hotel
{
	// Token: 0x02000012 RID: 18
	public partial class frmLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000107 RID: 263 RVA: 0x000186B4 File Offset: 0x000168B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000186EC File Offset: 0x000168EC
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtUser = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.chkRemember = new global::System.Windows.Forms.CheckBox();
			this.chkAutoLogin = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnLogin = new global::System.Windows.Forms.Button();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.mnMenu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnAddNewAccount = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnChangePassword = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(-4, 23);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(418, 75);
			this.tableLayoutPanel1.TabIndex = 0;
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::Hotel.Properties.Resources.Banner;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(412, 69);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(111, 116);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(91, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Người dùng:";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(123, 152);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(74, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật khẩu:";
			this.txtUser.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUser.Location = new global::System.Drawing.Point(202, 115);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new global::System.Drawing.Size(198, 22);
			this.txtUser.TabIndex = 4;
			this.txtPassword.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Location = new global::System.Drawing.Point(202, 149);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(198, 22);
			this.txtPassword.TabIndex = 5;
			this.chkRemember.AutoSize = true;
			this.chkRemember.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkRemember.Location = new global::System.Drawing.Point(247, 185);
			this.chkRemember.Name = "chkRemember";
			this.chkRemember.Size = new global::System.Drawing.Size(123, 19);
			this.chkRemember.TabIndex = 6;
			this.chkRemember.Text = "Ghi nhớ mật khẩu";
			this.chkRemember.UseVisualStyleBackColor = true;
			this.chkAutoLogin.AutoSize = true;
			this.chkAutoLogin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkAutoLogin.Location = new global::System.Drawing.Point(247, 208);
			this.chkAutoLogin.Name = "chkAutoLogin";
			this.chkAutoLogin.Size = new global::System.Drawing.Size(133, 19);
			this.chkAutoLogin.TabIndex = 7;
			this.chkAutoLogin.Text = "Tự động đăng nhập";
			this.chkAutoLogin.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.groupBox1.Location = new global::System.Drawing.Point(-4, 229);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(418, 65);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.btnCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(314, 19);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(90, 32);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.mnExit_Click);
			this.btnLogin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLogin.Location = new global::System.Drawing.Point(206, 19);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(90, 32);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new global::System.EventHandler(this.btnLogin_Click);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnMenu
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(412, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			this.mnMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnAddNewAccount,
				this.mnChangePassword,
				this.mnExit
			});
			this.mnMenu.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.mnMenu.Name = "mnMenu";
			this.mnMenu.Size = new global::System.Drawing.Size(53, 20);
			this.mnMenu.Text = "Menu";
			this.mnAddNewAccount.Name = "mnAddNewAccount";
			this.mnAddNewAccount.Size = new global::System.Drawing.Size(168, 22);
			this.mnAddNewAccount.Text = "Thêm tài khoản";
			this.mnAddNewAccount.Click += new global::System.EventHandler(this.mnAddNewAccount_Click);
			this.mnChangePassword.Name = "mnChangePassword";
			this.mnChangePassword.Size = new global::System.Drawing.Size(168, 22);
			this.mnChangePassword.Text = "Đổi mật khẩu";
			this.mnChangePassword.Click += new global::System.EventHandler(this.mnChangePassword_Click);
			this.mnExit.Name = "mnExit";
			this.mnExit.Size = new global::System.Drawing.Size(168, 22);
			this.mnExit.Text = "Thoát";
			this.mnExit.Click += new global::System.EventHandler(this.mnExit_Click);
			this.pictureBox2.Image = global::Hotel.Properties.Resources.Logo;
			this.pictureBox2.Location = new global::System.Drawing.Point(12, 116);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(64, 64);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.ClientSize = new global::System.Drawing.Size(412, 293);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.chkAutoLogin);
			base.Controls.Add(this.chkRemember);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.txtUser);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Controls.Add(this.menuStrip1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(428, 332);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(428, 332);
			base.Name = "frmLogin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			base.Load += new global::System.EventHandler(this.frmLogin_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000185 RID: 389
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.TextBox txtUser;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.CheckBox chkRemember;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.CheckBox chkAutoLogin;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.Button btnLogin;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.ToolStripMenuItem mnMenu;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.ToolStripMenuItem mnAddNewAccount;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.ToolStripMenuItem mnChangePassword;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Forms.ToolStripMenuItem mnExit;
	}
}

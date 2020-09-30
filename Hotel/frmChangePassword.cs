using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Json;

namespace Hotel
{
	// Token: 0x02000006 RID: 6
	public partial class frmChangePassword : Form
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000A5D4 File Offset: 0x000087D4
		public frmChangePassword(int idForm)
		{
			this.InitializeComponent();
			this.IDForm = idForm;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000A610 File Offset: 0x00008810
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.InitText();
			base.Hide();
			bool flag = this.IDForm == 1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmLogin;
					if (flag2)
					{
						frmLogin frmLogin = new frmLogin();
						frmLogin.Show();
						return;
					}
				}
				frmLogin frmLogin2 = new frmLogin();
				frmLogin2.Show();
			}
			else
			{
				bool flag3 = this.IDForm == 2;
				if (flag3)
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmMain;
						if (flag4)
						{
							frmMain frmMain = new frmMain();
							frmMain.Show();
							return;
						}
					}
					frmMain frmMain2 = new frmMain();
					frmMain2.Show();
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A74C File Offset: 0x0000894C
		private void frmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.InitText();
			base.Hide();
			bool flag = this.IDForm == 1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmLogin;
					if (flag2)
					{
						frmLogin frmLogin = new frmLogin();
						frmLogin.Show();
						return;
					}
				}
				frmLogin frmLogin2 = new frmLogin();
				frmLogin2.Show();
			}
			else
			{
				bool flag3 = this.IDForm == 2;
				if (flag3)
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmMain;
						if (flag4)
						{
							frmMain frmMain = new frmMain();
							frmMain.Show();
							return;
						}
					}
					frmMain frmMain2 = new frmMain();
					frmMain2.Show();
				}
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000A888 File Offset: 0x00008A88
		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			string text = this.txtUser.Text;
			string text2 = this.txtPassword1.Text;
			string text3 = this.txtPassword2.Text;
			bool flag = string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text2);
			if (flag)
			{
				this.funcCommon.Msg("Kiểm lại tên người dùng hoặc mật khẩu đang trống.", "Lỗi");
			}
			else
			{
				string text4 = Path.Combine(CMConstant.strFolderPath, "Data\\Account.bin");
				bool flag2 = !string.IsNullOrEmpty(CMConstant.strFolderPath);
				if (flag2)
				{
					bool flag3 = File.Exists(text4);
					if (flag3)
					{
						this.lstAccount = this.funcCommon.ReadFromBinaryFile<List<AddNewAccount>>(text4);
						foreach (AddNewAccount addNewAccount in this.lstAccount)
						{
							bool flag4 = text.Equals(this.funcCommon.Base64Decode(addNewAccount.strUserName));
							if (flag4)
							{
								int index = this.lstAccount.IndexOf(addNewAccount);
								bool flag5 = text2.Equals(text3);
								if (flag5)
								{
									this.lblStatus.Text = "Đổi mật khẩu thành công.";
									this.lblStatus.ForeColor = Color.Blue;
									this.lstAccount.RemoveAt(index);
									this.lstAccount.Add(new AddNewAccount
									{
										strUserName = this.funcCommon.Base64Encode(text),
										strPassWord = this.funcCommon.Base64Encode(text2)
									});
									File.Delete(text4);
									this.funcCommon.WriteToBinaryFile<List<AddNewAccount>>(text4, this.lstAccount, true);
									break;
								}
								this.lblStatus.Text = "Đổi mật khẩu thất bại.";
								this.lblStatus.ForeColor = Color.Red;
								break;
							}
							else
							{
								this.lblStatus.Text = "Không tìm thấy người dùng.";
								this.lblStatus.ForeColor = Color.Red;
							}
						}
					}
					else
					{
						this.lblStatus.Text = string.Empty;
						this.lblStatus.ForeColor = Color.Black;
						this.funcCommon.Msg("Không tìm thấy tập tin ", "Lỗi");
					}
				}
				else
				{
					this.lblStatus.Text = string.Empty;
					this.lblStatus.ForeColor = Color.Black;
					this.funcCommon.Msg("Thư mục rỗng.", "Lỗi");
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AB20 File Offset: 0x00008D20
		private void frmChangePassword_Load(object sender, EventArgs e)
		{
			this.InitText();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000AB2C File Offset: 0x00008D2C
		private void InitText()
		{
			this.lblStatus.Text = string.Empty;
			this.lblStatus.ForeColor = Color.Black;
			this.txtUser.Focus();
			this.txtUser.Text = string.Empty;
			this.txtPassword1.Text = string.Empty;
			this.txtPassword2.Text = string.Empty;
		}

		// Token: 0x0400008D RID: 141
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400008E RID: 142
		private List<AddNewAccount> lstAccount = new List<AddNewAccount>();

		// Token: 0x0400008F RID: 143
		private int IDForm = 0;
	}
}

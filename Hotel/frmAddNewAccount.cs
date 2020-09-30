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
	// Token: 0x02000004 RID: 4
	public partial class frmAddNewAccount : Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00008447 File Offset: 0x00006647
		public frmAddNewAccount()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008478 File Offset: 0x00006678
		private void InitText()
		{
			this.lblStatus.Text = string.Empty;
			this.lblStatus.ForeColor = Color.Black;
			this.txtUser.Focus();
			this.txtUser.Text = string.Empty;
			this.txtPassword1.Text = string.Empty;
			this.txtPassword2.Text = string.Empty;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000084E8 File Offset: 0x000066E8
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.InitText();
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLogin;
				if (flag)
				{
					form.Show();
					break;
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008564 File Offset: 0x00006764
		private void frmAddNewAccount_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.InitText();
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLogin;
				if (flag)
				{
					form.Show();
					break;
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000085E0 File Offset: 0x000067E0
		private void btnRegister_Click(object sender, EventArgs e)
		{
			string text = this.txtUser.Text;
			string text2 = this.txtPassword1.Text;
			string text3 = this.txtPassword2.Text;
			bool flag = string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text2);
			if (flag)
			{
				this.funcCommon.Msg("Kiểm lại tên người dùng hoặc mật khẩu đang trống.", "Lỗi");
			}
			else
			{
				string text4 = Path.Combine(CMConstant.strFolderPath, "Data\\Account.bin");
				bool flag2 = text2.Equals(text3);
				if (flag2)
				{
					bool flag3 = !string.IsNullOrEmpty(CMConstant.strFolderPath);
					if (flag3)
					{
						bool flag4 = File.Exists(text4);
						if (flag4)
						{
							this.lstAccount = this.funcCommon.ReadFromBinaryFile<List<AddNewAccount>>(text4);
							foreach (AddNewAccount addNewAccount in this.lstAccount)
							{
								bool flag5 = text.Equals(this.funcCommon.Base64Decode(addNewAccount.strUserName));
								if (flag5)
								{
									this.lblStatus.Text = "Tên người dùng đã tồn tại.";
									this.lblStatus.ForeColor = Color.Red;
									return;
								}
							}
							this.lstAccount.Add(new AddNewAccount
							{
								strUserName = this.funcCommon.Base64Encode(text),
								strPassWord = this.funcCommon.Base64Encode(text2)
							});
							File.Delete(text4);
							this.funcCommon.WriteToBinaryFile<List<AddNewAccount>>(text4, this.lstAccount, true);
						}
						else
						{
							this.lstAccount.Add(new AddNewAccount
							{
								strUserName = this.funcCommon.Base64Encode(text),
								strPassWord = this.funcCommon.Base64Encode(text2)
							});
							this.funcCommon.WriteToBinaryFile<List<AddNewAccount>>(text4, this.lstAccount, true);
						}
						this.lblStatus.Text = "Đăng ký thành công.";
						this.lblStatus.ForeColor = Color.Blue;
					}
					else
					{
						this.lblStatus.Text = string.Empty;
						this.lblStatus.ForeColor = Color.Black;
						this.funcCommon.Msg("Thư mục rỗng.", "Lỗi");
					}
				}
				else
				{
					this.lblStatus.Text = string.Empty;
					this.lblStatus.ForeColor = Color.Black;
					this.funcCommon.Msg("Mật khẩu mới và mật khẩu xác nhận không khớp nhau.", "Lỗi");
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00008874 File Offset: 0x00006A74
		private void frmAddNewAccount_Load(object sender, EventArgs e)
		{
			this.InitText();
		}

		// Token: 0x04000063 RID: 99
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x04000064 RID: 100
		private List<AddNewAccount> lstAccount = new List<AddNewAccount>();
	}
}

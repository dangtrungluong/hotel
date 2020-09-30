using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Json;
using Hotel.Properties;
using Newtonsoft.Json;

namespace Hotel
{
	// Token: 0x02000012 RID: 18
	public partial class frmLogin : Form
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00018139 File Offset: 0x00016339
		public frmLogin()
		{
			this.InitializeComponent();
			this.InitText();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00018179 File Offset: 0x00016379
		private void InitText()
		{
			this.txtUser.Focus();
			this.txtUser.Text = string.Empty;
			this.txtPassword.Text = string.Empty;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000181AC File Offset: 0x000163AC
		private void mnAddNewAccount_Click(object sender, EventArgs e)
		{
			this.InitText();
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmAddNewAccount;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmAddNewAccount frmAddNewAccount = new frmAddNewAccount();
			frmAddNewAccount.Show();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00018238 File Offset: 0x00016438
		private void mnChangePassword_Click(object sender, EventArgs e)
		{
			this.InitText();
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmChangePassword;
				if (flag)
				{
					frmChangePassword frmChangePassword = new frmChangePassword(1);
					frmChangePassword.Show();
					return;
				}
			}
			frmChangePassword frmChangePassword2 = new frmChangePassword(1);
			frmChangePassword2.Show();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000182D0 File Offset: 0x000164D0
		private void mnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000182DC File Offset: 0x000164DC
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string text = this.txtUser.Text;
			string text2 = this.txtPassword.Text;
			string text3 = Path.Combine(CMConstant.strFolderPath, "Data\\Account.bin");
			string path = Path.Combine(CMConstant.strFolderPath, "ConfigFile\\ConfigLogin.json");
			string text4 = Path.Combine(CMConstant.strFolderPath, "Data\\RememberAccount.bin");
			bool flag = !string.IsNullOrEmpty(CMConstant.strFolderPath);
			if (flag)
			{
				bool flag2 = File.Exists(text3);
				if (flag2)
				{
					this.lstAccount = this.funcCommon.ReadFromBinaryFile<List<AddNewAccount>>(text3);
					foreach (AddNewAccount addNewAccount in this.lstAccount)
					{
						bool flag3 = text.Equals(this.funcCommon.Base64Decode(addNewAccount.strUserName)) && text2.Equals(this.funcCommon.Base64Decode(addNewAccount.strPassWord));
						if (flag3)
						{
							this.saveConfigLogin.bRemember = this.chkRemember.Checked;
							this.saveConfigLogin.bAutoLog = this.chkAutoLogin.Checked;
							string contents = JsonConvert.SerializeObject(this.saveConfigLogin, Formatting.Indented);
							File.WriteAllText(path, contents);
							bool flag4 = this.chkRemember.Checked || this.chkAutoLogin.Checked;
							if (flag4)
							{
								bool flag5 = File.Exists(text4);
								if (flag5)
								{
									File.Delete(text4);
								}
								List<AddNewAccount> list = new List<AddNewAccount>();
								list.Add(new AddNewAccount
								{
									strUserName = this.funcCommon.Base64Encode(text),
									strPassWord = this.funcCommon.Base64Encode(text2)
								});
								this.funcCommon.WriteToBinaryFile<List<AddNewAccount>>(text4, list, true);
							}
							this.InitText();
							base.Hide();
							foreach (object obj in Application.OpenForms)
							{
								Form form = (Form)obj;
								bool flag6 = form is frmMain;
								if (flag6)
								{
									form.Show();
									return;
								}
							}
							frmMain frmMain = new frmMain();
							frmMain.Show();
							return;
						}
					}
					this.funcCommon.Msg("Đăng nhập thất bại.", "Lỗi");
				}
				else
				{
					this.funcCommon.Msg("Không tìm thấy tập tin ", "Lỗi");
				}
			}
			else
			{
				this.funcCommon.Msg("Thư mục rỗng.", "Lỗi");
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000185B0 File Offset: 0x000167B0
		private void frmLogin_Load(object sender, EventArgs e)
		{
			string path = Path.Combine(CMConstant.strFolderPath, "ConfigFile\\ConfigLogin.json");
			bool flag = File.Exists(path);
			if (flag)
			{
				string value = File.ReadAllText(path);
				SaveConfigLogin saveConfigLogin = JsonConvert.DeserializeObject<SaveConfigLogin>(value) ?? new SaveConfigLogin();
				this.chkRemember.Checked = saveConfigLogin.bRemember;
				this.chkAutoLogin.Checked = saveConfigLogin.bAutoLog;
			}
			bool @checked = this.chkRemember.Checked;
			if (@checked)
			{
				string text = Path.Combine(CMConstant.strFolderPath, "Data\\RememberAccount.bin");
				bool flag2 = File.Exists(text);
				if (flag2)
				{
					List<AddNewAccount> list = this.funcCommon.ReadFromBinaryFile<List<AddNewAccount>>(text);
					bool flag3 = list.Count > 0;
					if (flag3)
					{
						this.txtUser.Text = this.funcCommon.Base64Decode(list[0].strUserName);
						this.txtPassword.Text = this.funcCommon.Base64Decode(list[0].strPassWord);
					}
				}
			}
		}

		// Token: 0x04000182 RID: 386
		private List<AddNewAccount> lstAccount = new List<AddNewAccount>();

		// Token: 0x04000183 RID: 387
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x04000184 RID: 388
		private SaveConfigLogin saveConfigLogin = new SaveConfigLogin();
	}
}

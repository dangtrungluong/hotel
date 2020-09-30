using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Hotel.Common;

namespace Hotel
{
	// Token: 0x0200000A RID: 10
	public partial class frmCommon : Form
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
		public frmCommon(string strTitle, string strLabel, string strCommon, string strSL)
		{
			this.InitializeComponent();
			this.Text = strTitle;
			this.lblLabel.Text = strLabel;
			this.lblCommon.Text = strCommon;
			this.strSoLuong = strSL;
			this.txtCommon.Text = strSL;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000F211 File Offset: 0x0000D411
		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.txtCommon.Text = this.strSoLuong;
			base.Close();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000214C File Offset: 0x0000034C
		private void frmCommon_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000F22D File Offset: 0x0000D42D
		private void txtCommon_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000F240 File Offset: 0x0000D440
		private void txtCommon_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x040000E1 RID: 225
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x040000E2 RID: 226
		private string strSoLuong = string.Empty;
	}
}

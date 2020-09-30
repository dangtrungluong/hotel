using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	// Token: 0x0200000B RID: 11
	public partial class frmGhiChu : Form
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000F79A File Offset: 0x0000D99A
		public frmGhiChu()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000F7B2 File Offset: 0x0000D9B2
		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.txtGhiChu.Text = string.Empty;
			base.Close();
		}
	}
}

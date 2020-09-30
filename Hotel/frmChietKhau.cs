using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	// Token: 0x02000007 RID: 7
	public partial class frmChietKhau : Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000B2EB File Offset: 0x000094EB
		public frmChietKhau(string strdongia)
		{
			this.InitializeComponent();
			this.txtDonGia.Text = strdongia;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B31C File Offset: 0x0000951C
		private void frmChietKhau_Load(object sender, EventArgs e)
		{
			this.rdGiamPhanTram.Checked = true;
			this.rdGiamTien.Checked = false;
			this.lblNote.Text = string.Empty;
			this.txtGiamPhanTram.Enabled = true;
			this.txtGiamTien.Enabled = false;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B370 File Offset: 0x00009570
		private void btnOK_Click(object sender, EventArgs e)
		{
			bool flag = (string.IsNullOrEmpty(this.txtGiamPhanTram.Text) && this.rdGiamPhanTram.Checked) || (string.IsNullOrEmpty(this.txtGiamTien.Text) && this.rdGiamTien.Checked);
			if (flag)
			{
				frmChietKhau.fPhanTram = 0f;
			}
			base.Close();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B3D7 File Offset: 0x000095D7
		private void btnHuy_Click(object sender, EventArgs e)
		{
			frmChietKhau.fPhanTram = 0f;
			base.Close();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B3EC File Offset: 0x000095EC
		private void rdGiamPhanTram_CheckedChanged(object sender, EventArgs e)
		{
			this.txtGiamPhanTram.Enabled = this.rdGiamPhanTram.Checked;
			this.txtGiamTien.Enabled = !this.rdGiamPhanTram.Checked;
			bool flag = !string.IsNullOrEmpty(this.txtGiamPhanTram.Text);
			if (flag)
			{
				this.txtGiamPhanTram.MaxLength = 6;
				frmChietKhau.fPhanTram = (float)Convert.ToDouble(this.txtGiamPhanTram.Text);
				bool flag2 = frmChietKhau.fPhanTram >= 100f;
				if (flag2)
				{
					this.txtGiamPhanTram.MaxLength = 3;
				}
				else
				{
					this.fGiaSauKhiGiam = Convert.ToUInt64(this.txtDonGia.Text) - Convert.ToUInt64(this.txtDonGia.Text) * frmChietKhau.fPhanTram / 100f;
					this.lblNote.Text = "Giảm giá " + this.txtGiamPhanTram.Text + "%, đơn giá sau khi giảm là: " + this.fGiaSauKhiGiam.ToString();
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000B4F8 File Offset: 0x000096F8
		private void rdGiamTien_CheckedChanged(object sender, EventArgs e)
		{
			this.txtGiamPhanTram.Enabled = !this.rdGiamTien.Checked;
			this.txtGiamTien.Enabled = this.rdGiamTien.Checked;
			bool flag = !string.IsNullOrEmpty(this.txtGiamTien.Text);
			if (flag)
			{
				this.txtGiamTien.MaxLength = this.txtDonGia.Text.Length;
				bool flag2 = Convert.ToUInt64(this.txtGiamTien.Text) >= Convert.ToUInt64(this.txtDonGia.Text);
				if (flag2)
				{
					this.txtGiamTien.MaxLength = this.txtDonGia.Text.Length;
				}
				else
				{
					frmChietKhau.fPhanTram = (float)(Convert.ToDouble(this.txtGiamTien.Text) / Convert.ToDouble(this.txtDonGia.Text)) * 100f;
					this.fGiaSauKhiGiam = Convert.ToUInt64(this.txtDonGia.Text) - Convert.ToUInt64(this.txtDonGia.Text) * frmChietKhau.fPhanTram / 100f;
					this.lblNote.Text = "Tương đương tỉ lệ giảm " + frmChietKhau.fPhanTram.ToString() + "%, giá sau khi giảm: " + this.fGiaSauKhiGiam.ToString();
				}
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000B650 File Offset: 0x00009850
		private void txtGiamPhanTram_TextChanged(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.txtGiamPhanTram.Text);
			if (flag)
			{
				this.txtGiamPhanTram.MaxLength = 6;
				frmChietKhau.fPhanTram = (float)Convert.ToDouble(this.txtGiamPhanTram.Text);
				bool flag2 = frmChietKhau.fPhanTram >= 100f;
				if (flag2)
				{
					this.txtGiamPhanTram.MaxLength = 3;
				}
				else
				{
					this.fGiaSauKhiGiam = Convert.ToUInt64(this.txtDonGia.Text) - Convert.ToUInt64(this.txtDonGia.Text) * frmChietKhau.fPhanTram / 100f;
					this.lblNote.Text = "Giảm giá " + this.txtGiamPhanTram.Text + "%, đơn giá sau khi giảm là: " + this.fGiaSauKhiGiam.ToString();
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B72C File Offset: 0x0000992C
		private void txtGiamPhanTram_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\b' || e.KeyChar == '.' || (e.KeyChar >= '0' && e.KeyChar <= '9');
			if (flag)
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000B784 File Offset: 0x00009984
		private void txtGiamTien_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\b' || e.KeyChar == '.' || (e.KeyChar >= '0' && e.KeyChar <= '9');
			if (flag)
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000B7DC File Offset: 0x000099DC
		private void txtGiamTien_TextChanged(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.txtGiamTien.Text);
			if (flag)
			{
				this.txtGiamTien.MaxLength = this.txtDonGia.Text.Length;
				bool flag2 = Convert.ToUInt64(this.txtGiamTien.Text) > Convert.ToUInt64(this.txtDonGia.Text);
				if (flag2)
				{
					this.txtGiamTien.MaxLength = this.txtDonGia.Text.Length;
				}
				else
				{
					frmChietKhau.fPhanTram = (float)(Convert.ToDouble(this.txtGiamTien.Text) / Convert.ToDouble(this.txtDonGia.Text)) * 100f;
					this.fGiaSauKhiGiam = Convert.ToUInt64(this.txtDonGia.Text) - Convert.ToUInt64(this.txtDonGia.Text) * frmChietKhau.fPhanTram / 100f;
					this.lblNote.Text = "Tương đương tỉ lệ giảm " + frmChietKhau.fPhanTram.ToString() + "%, giá sau khi giảm: " + this.fGiaSauKhiGiam.ToString();
				}
			}
		}

		// Token: 0x0400009B RID: 155
		private float fGiaSauKhiGiam = 0f;

		// Token: 0x0400009C RID: 156
		public static float fPhanTram = 0f;
	}
}

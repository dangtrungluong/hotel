using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Properties;

namespace Hotel
{
	// Token: 0x02000005 RID: 5
	public partial class frmAddNewGroupItems : Form
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00008FF8 File Offset: 0x000071F8
		public frmAddNewGroupItems(NhomMatHang nhomMH, int index, int ItemIndex)
		{
			this.InitializeComponent();
			this.nhomMatHang = nhomMH;
			bool flag = index == 1;
			if (flag)
			{
				this.Text += "- Thêm mới";
			}
			else
			{
				bool flag2 = index == 2;
				if (flag2)
				{
					this.Text += "- Chỉnh sửa";
				}
			}
			this.iTypes = index;
			this.iRowIndex = ItemIndex - 1;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000090E8 File Offset: 0x000072E8
		private void frmAddNewGroupItems_Load(object sender, EventArgs e)
		{
			this.txtTenNhomMatHang.Text = string.Empty;
			this.txtDanhMaSanPham.Text = string.Empty;
			this.btnSave.Enabled = true;
			this.btnSave_New.Enabled = true;
			this.btnSave_Exit.Enabled = true;
			this.btnExit.Enabled = true;
			this.txtTenNhomMatHang.Select();
			this.lstLoaiSanPham = frmMain.lstpLoaiSanPham;
			this.ReloadCbBox(this.lstLoaiSanPham);
			bool flag = this.nhomMatHang != null && this.iRowIndex > -1;
			if (flag)
			{
				this.txtTenNhomMatHang.Text = this.nhomMatHang.strTenNhomMatHang;
				this.txtDanhMaSanPham.Text = this.nhomMatHang.strMaSanPham;
				this.cbLoaiSanPham.Text = this.nhomMatHang.strLoaiSanPham;
				this.strNhomMatHang_Before = this.nhomMatHang.strTenNhomMatHang;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000091E0 File Offset: 0x000073E0
		private void btnThem_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLoaiSanPham;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmLoaiSanPham frmLoaiSanPham = new frmLoaiSanPham(string.Empty, string.Empty, 1, 0);
			frmLoaiSanPham.Show();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000926C File Offset: 0x0000746C
		private void btnTai_Click(object sender, EventArgs e)
		{
			this.lstLoaiSanPham = new List<LoaiSanPham>();
			bool flag = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
			if (flag)
			{
				this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
			}
			this.ReloadCbBox(this.lstLoaiSanPham);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000092CC File Offset: 0x000074CC
		private void ReloadCbBox(List<LoaiSanPham> lstStrLoaiSanPham)
		{
			bool flag = lstStrLoaiSanPham.Count > 0;
			if (flag)
			{
				bool flag2 = this.cbLoaiSanPham.Items.Count > 0;
				if (flag2)
				{
					this.cbLoaiSanPham.Items.Clear();
				}
				this.cbLoaiSanPham.Items.Add(string.Empty);
				foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
				{
					this.cbLoaiSanPham.Items.Add(loaiSanPham.strTenLoaiSanPham);
				}
				bool flag3 = this.cbLoaiSanPham.Items.Count > 1;
				if (flag3)
				{
					this.cbLoaiSanPham.SelectedIndex = 1;
				}
				else
				{
					this.cbLoaiSanPham.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000093C0 File Offset: 0x000075C0
		private void btnDanhMuc_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmDanhMuc;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmDanhMuc frmDanhMuc = new frmDanhMuc();
			frmDanhMuc.Show();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00009440 File Offset: 0x00007640
		private void cbLoaiDo_DropDown(object sender, EventArgs e)
		{
			this.lstLoaiSanPham = new List<LoaiSanPham>();
			bool flag = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
			if (flag)
			{
				this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
			}
			this.ReloadCbBox(this.lstLoaiSanPham);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000094A0 File Offset: 0x000076A0
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtTenNhomMatHang.Text);
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
			}
			else
			{
				bool flag2 = !this.LuuNhomMatHang();
				if (!flag2)
				{
					this.btnSave.Enabled = false;
					this.btnSave_New.Enabled = false;
					this.btnSave_Exit.Enabled = false;
					this.btnExit.Enabled = true;
					this.btnExit.Focus();
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000952C File Offset: 0x0000772C
		private bool LuuNhomMatHang()
		{
			this.strNhomMatHang = this.txtTenNhomMatHang.Text;
			this.strMaSanPham = this.txtDanhMaSanPham.Text;
			this.strLoaiSanPham = this.cbLoaiSanPham.Text;
			this.nhomMatHang = new NhomMatHang();
			this.nhomMatHang.strTenNhomMatHang = this.strNhomMatHang;
			this.nhomMatHang.strMaSanPham = this.strMaSanPham;
			this.nhomMatHang.strLoaiSanPham = this.strLoaiSanPham;
			bool flag = this.iTypes == 1;
			if (flag)
			{
				bool flag2 = File.Exists(CMConstant.strFilePathNhomMatHang) && !string.IsNullOrEmpty(CMConstant.strFilePathNhomMatHang);
				if (flag2)
				{
					this.lstNhomMatHang = this.readwriteData2CSV.ReadNhomMatHangFromCSV(CMConstant.strFilePathNhomMatHang);
					foreach (NhomMatHang nhomMatHang in this.lstNhomMatHang)
					{
						bool flag3 = this.strNhomMatHang.Equals(nhomMatHang.strTenNhomMatHang);
						if (flag3)
						{
							this.funcCommon.Msg("Nhóm mặt hàng [" + this.strNhomMatHang + "] đã có trong danh sách mặt hàng.", "Cảnh báo");
							return false;
						}
					}
				}
				this.readwriteData2CSV.WriteNhomMatHang2CSV(CMConstant.strFilePathNhomMatHang, this.nhomMatHang);
			}
			else
			{
				bool flag4 = this.iTypes == 2;
				if (flag4)
				{
					bool flag5 = File.Exists(CMConstant.strFilePathNhomMatHang) && !string.IsNullOrEmpty(CMConstant.strFilePathNhomMatHang);
					if (flag5)
					{
						this.lstNhomMatHang = this.readwriteData2CSV.ReadNhomMatHangFromCSV(CMConstant.strFilePathNhomMatHang);
						bool flag6 = !this.strNhomMatHang_Before.Equals(this.strNhomMatHang);
						if (flag6)
						{
							foreach (NhomMatHang nhomMatHang2 in this.lstNhomMatHang)
							{
								bool flag7 = this.strNhomMatHang.Equals(nhomMatHang2.strTenNhomMatHang);
								if (flag7)
								{
									this.funcCommon.Msg("Nhóm mặt hàng [" + this.strNhomMatHang + "] đã có trong danh sách mặt hàng.", "Cảnh báo");
									return false;
								}
							}
						}
						bool flag8 = this.lstNhomMatHang != null;
						if (flag8)
						{
							bool flag9 = this.lstNhomMatHang.Count > 0;
							if (flag9)
							{
								this.lstNhomMatHang.RemoveAt(this.iRowIndex);
								this.lstNhomMatHang.Insert(this.iRowIndex, this.nhomMatHang);
								File.Delete(CMConstant.strFilePathNhomMatHang);
								foreach (NhomMatHang nhommathang in this.lstNhomMatHang)
								{
									this.readwriteData2CSV.WriteNhomMatHang2CSV(CMConstant.strFilePathNhomMatHang, nhommathang);
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00009850 File Offset: 0x00007A50
		private void txtTenNhomMatHang_TextChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSave_New.Enabled = true;
			this.btnSave_Exit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00009888 File Offset: 0x00007A88
		private void btnSave_New_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtTenNhomMatHang.Text);
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
			}
			else
			{
				bool flag2 = !this.LuuNhomMatHang();
				if (!flag2)
				{
					this.txtTenNhomMatHang.Text = string.Empty;
					this.txtDanhMaSanPham.Text = string.Empty;
					this.btnSave.Enabled = true;
					this.btnSave_New.Enabled = true;
					this.btnSave_Exit.Enabled = true;
					this.btnExit.Enabled = true;
					this.btnSave_New.Focus();
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00009938 File Offset: 0x00007B38
		private void btnSave_Exit_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtTenNhomMatHang.Text);
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
			}
			else
			{
				bool flag2 = !this.LuuNhomMatHang();
				if (flag2)
				{
					this.funcCommon.Msg("Nhóm mặt hàng [" + this.txtTenNhomMatHang.Text + "] đã có trong danh sách mặt hàng.", "Cảnh báo");
				}
				else
				{
					base.Close();
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000099B8 File Offset: 0x00007BB8
		private void txtTenNhomMatHang_Click(object sender, EventArgs e)
		{
			foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
			{
				bool flag = this.cbLoaiSanPham.Text.Equals(loaiSanPham.strTenLoaiSanPham);
				if (flag)
				{
					return;
				}
			}
			this.cbLoaiSanPham.Text = string.Empty;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00009850 File Offset: 0x00007A50
		private void txtDanhMaSanPham_TextChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSave_New.Enabled = true;
			this.btnSave_Exit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009850 File Offset: 0x00007A50
		private void cbLoaiSanPham_SelectedValueChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSave_New.Enabled = true;
			this.btnSave_Exit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x04000070 RID: 112
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x04000071 RID: 113
		private List<LoaiSanPham> lstLoaiSanPham = new List<LoaiSanPham>();

		// Token: 0x04000072 RID: 114
		private List<NhomMatHang> lstNhomMatHang = new List<NhomMatHang>();

		// Token: 0x04000073 RID: 115
		private NhomMatHang nhomMatHang = new NhomMatHang();

		// Token: 0x04000074 RID: 116
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x04000075 RID: 117
		private string strNhomMatHang_Before = string.Empty;

		// Token: 0x04000076 RID: 118
		private string strNhomMatHang = string.Empty;

		// Token: 0x04000077 RID: 119
		private string strMaSanPham = string.Empty;

		// Token: 0x04000078 RID: 120
		private string strLoaiSanPham = string.Empty;

		// Token: 0x04000079 RID: 121
		private int iRowIndex = 0;

		// Token: 0x0400007A RID: 122
		private int iTypes = 0;
	}
}

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
	// Token: 0x02000011 RID: 17
	public partial class frmLoaiSanPham : Form
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00017668 File Offset: 0x00015868
		public frmLoaiSanPham(string strloaisanpham, string strghichu, int Type, int index)
		{
			this.InitializeComponent();
			this.strLoaiSanPham = strloaisanpham;
			this.strGhiChu = strghichu;
			this.TypeForm = Type;
			this.iRowIndex = index;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00017710 File Offset: 0x00015910
		private void btnLuu_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtLoaiSanPham.Text);
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
			}
			else
			{
				bool flag2 = !this.LuuLoaiSanPham();
				if (flag2)
				{
					this.funcCommon.Msg("Loại sản phẩm [" + this.txtloaisanpham + "] đã có trong danh mục.", "Cảnh báo");
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00017784 File Offset: 0x00015984
		private void frmSanPham_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			this.txtLoaiSanPham.Text = this.strLoaiSanPham;
			this.txtGhiChu.Text = this.strGhiChu;
			int typeForm = this.TypeForm;
			if (typeForm != 1)
			{
				if (typeForm == 2)
				{
					this.lblTitle.Text = "Chỉnh sửa";
				}
			}
			else
			{
				this.lblTitle.Text = "Thêm mới loại sản phẩm";
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00017824 File Offset: 0x00015A24
		private bool LuuLoaiSanPham()
		{
			List<LoaiSanPham> list = new List<LoaiSanPham>();
			this.txtloaisanpham = this.txtLoaiSanPham.Text;
			this.txtghichu = this.txtGhiChu.Text;
			this.loaiSanPham.strTenLoaiSanPham = this.txtloaisanpham;
			this.loaiSanPham.strGhiChu = this.txtghichu;
			bool flag = this.TypeForm == 1;
			if (flag)
			{
				bool flag2 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
				if (flag2)
				{
					this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
					foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
					{
						bool flag3 = this.txtloaisanpham.Equals(loaiSanPham.strTenLoaiSanPham);
						if (flag3)
						{
							return false;
						}
					}
				}
				this.readwriteData2CSV.WriteLoaiSanPham2CSV(CMConstant.strFilePathLoaiSanPham, this.loaiSanPham);
			}
			else
			{
				bool flag4 = this.TypeForm == 2;
				if (flag4)
				{
					bool flag5 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
					if (flag5)
					{
						this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
						foreach (LoaiSanPham loaiSanPham2 in this.lstLoaiSanPham)
						{
							bool flag6 = this.txtloaisanpham.Equals(loaiSanPham2.strTenLoaiSanPham);
							if (flag6)
							{
								return false;
							}
						}
						list = this.lstLoaiSanPham;
						bool flag7 = this.lstLoaiSanPham.Count > 0;
						if (flag7)
						{
							list.RemoveAt(this.iRowIndex);
							list.Insert(this.iRowIndex, this.loaiSanPham);
							File.Delete(CMConstant.strFilePathLoaiSanPham);
							foreach (LoaiSanPham sanpham in list)
							{
								this.readwriteData2CSV.WriteLoaiSanPham2CSV(CMConstant.strFilePathLoaiSanPham, sanpham);
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00017A9C File Offset: 0x00015C9C
		private void txtLoaiSanPham_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				bool flag2 = !this.LuuLoaiSanPham();
				if (flag2)
				{
					this.funcCommon.Msg("Loại sản phẩm [" + this.txtloaisanpham + "] đã có trong danh mục.", "Cảnh báo");
				}
			}
		}

		// Token: 0x0400016E RID: 366
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400016F RID: 367
		private List<LoaiSanPham> lstLoaiSanPham = new List<LoaiSanPham>();

		// Token: 0x04000170 RID: 368
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x04000171 RID: 369
		private LoaiSanPham loaiSanPham = new LoaiSanPham();

		// Token: 0x04000172 RID: 370
		private string strLoaiSanPham = string.Empty;

		// Token: 0x04000173 RID: 371
		private string strGhiChu = string.Empty;

		// Token: 0x04000174 RID: 372
		private int TypeForm = 0;

		// Token: 0x04000175 RID: 373
		private int iRowIndex = 0;

		// Token: 0x04000176 RID: 374
		private string txtloaisanpham = string.Empty;

		// Token: 0x04000177 RID: 375
		private string txtghichu = string.Empty;
	}
}

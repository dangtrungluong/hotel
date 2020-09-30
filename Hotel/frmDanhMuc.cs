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
	// Token: 0x0200000D RID: 13
	public partial class frmDanhMuc : Form
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00011F68 File Offset: 0x00010168
		public frmDanhMuc()
		{
			this.InitializeComponent();
			this.btnSua.Enabled = false;
			this.btnXoa.Enabled = false;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00011FC8 File Offset: 0x000101C8
		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLoaiSanPham;
				if (flag)
				{
					form.ShowDialog();
					bool flag2 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
					if (flag2)
					{
						this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
					}
					bool flag3 = this.lstViewDanhMuc.Items.Count > 0;
					if (flag3)
					{
						this.lstViewDanhMuc.Items.Clear();
					}
					foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
					{
						this.lstViewDanhMuc.Items.Add(loaiSanPham.strTenLoaiSanPham, 0);
					}
					return;
				}
			}
			frmLoaiSanPham frmLoaiSanPham = new frmLoaiSanPham(string.Empty, string.Empty, 1, 0);
			frmLoaiSanPham.ShowDialog();
			bool flag4 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
			if (flag4)
			{
				this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
			}
			bool flag5 = this.lstViewDanhMuc.Items.Count > 0;
			if (flag5)
			{
				this.lstViewDanhMuc.Items.Clear();
			}
			foreach (LoaiSanPham loaiSanPham2 in this.lstLoaiSanPham)
			{
				this.lstViewDanhMuc.Items.Add(loaiSanPham2.strTenLoaiSanPham, 0);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000121E0 File Offset: 0x000103E0
		private void btnSua_Click(object sender, EventArgs e)
		{
			this.SuaLoaiSanPham();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000121EC File Offset: 0x000103EC
		private void frmDanhMuc_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(CMConstant.strFilePathIcon);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				try
				{
					this.imgListIcon.Images.Add(Image.FromFile(fileInfo.FullName));
				}
				catch
				{
					this.funCommon.Msg("Không tìm thấy icon", "Lỗi");
				}
			}
			this.lstViewDanhMuc.View = View.LargeIcon;
			this.imgListIcon.ImageSize = new Size(32, 32);
			this.lstViewDanhMuc.LargeImageList = this.imgListIcon;
			bool flag = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
			if (flag)
			{
				this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
			}
			foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
			{
				this.lstViewDanhMuc.Items.Add(loaiSanPham.strTenLoaiSanPham, 0);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00012370 File Offset: 0x00010570
		private void lstViewDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.lstViewDanhMuc.SelectedItems.Count > 0;
			if (flag)
			{
				this.btnSua.Enabled = true;
				this.btnXoa.Enabled = true;
			}
			else
			{
				this.btnSua.Enabled = false;
				this.btnXoa.Enabled = false;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000121E0 File Offset: 0x000103E0
		private void lstViewDanhMuc_ItemActivate(object sender, EventArgs e)
		{
			this.SuaLoaiSanPham();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000123D0 File Offset: 0x000105D0
		private bool SuaLoaiSanPham()
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLoaiSanPham;
				if (flag)
				{
					form.ShowDialog();
					bool flag2 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
					if (flag2)
					{
						this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
					}
					bool flag3 = this.lstViewDanhMuc.Items.Count > 0;
					if (flag3)
					{
						this.lstViewDanhMuc.Items.Clear();
					}
					foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
					{
						this.lstViewDanhMuc.Items.Add(loaiSanPham.strTenLoaiSanPham, 0);
					}
					return false;
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			bool flag4 = this.lstViewDanhMuc.SelectedItems.Count > 0;
			bool result;
			if (flag4)
			{
				listViewItem = this.lstViewDanhMuc.SelectedItems[0];
				bool flag5 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
				if (flag5)
				{
					this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
				}
				string strloaisanpham = string.Empty;
				string strghichu = string.Empty;
				foreach (LoaiSanPham loaiSanPham2 in this.lstLoaiSanPham)
				{
					bool flag6 = listViewItem.Text.Equals(loaiSanPham2.strTenLoaiSanPham);
					if (flag6)
					{
						strloaisanpham = loaiSanPham2.strTenLoaiSanPham;
						strghichu = loaiSanPham2.strGhiChu;
						break;
					}
				}
				frmLoaiSanPham frmLoaiSanPham = new frmLoaiSanPham(strloaisanpham, strghichu, 2, listViewItem.Index);
				frmLoaiSanPham.ShowDialog();
				bool flag7 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
				if (flag7)
				{
					this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
				}
				bool flag8 = this.lstViewDanhMuc.Items.Count > 0;
				if (flag8)
				{
					this.lstViewDanhMuc.Items.Clear();
				}
				foreach (LoaiSanPham loaiSanPham3 in this.lstLoaiSanPham)
				{
					this.lstViewDanhMuc.Items.Add(loaiSanPham3.strTenLoaiSanPham, 0);
				}
				bool flag9 = this.lstViewDanhMuc.SelectedItems.Count == 0;
				if (flag9)
				{
					this.btnSua.Enabled = false;
					this.btnXoa.Enabled = false;
				}
				result = true;
			}
			else
			{
				this.funCommon.Msg("Vui lòng chọn loại sản phẩm để chỉnh sửa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00012730 File Offset: 0x00010930
		private void btnXoa_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewDanhMuc.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewDanhMuc.SelectedItems[0];
				DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa danh mục " + listViewItem.Text + " ?", "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag2 = dialogResult == DialogResult.No;
				if (!flag2)
				{
					bool flag3 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
					if (flag3)
					{
						this.lstLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
						this.lstLoaiSanPham.RemoveAt(listViewItem.Index);
						bool flag4 = this.lstViewDanhMuc.Items.Count > 0;
						if (flag4)
						{
							this.lstViewDanhMuc.Items.Clear();
						}
						File.Delete(CMConstant.strFilePathLoaiSanPham);
						foreach (LoaiSanPham loaiSanPham in this.lstLoaiSanPham)
						{
							this.readwriteData2CSV.WriteLoaiSanPham2CSV(CMConstant.strFilePathLoaiSanPham, loaiSanPham);
							this.lstViewDanhMuc.Items.Add(loaiSanPham.strTenLoaiSanPham, 0);
						}
						bool flag5 = this.lstViewDanhMuc.SelectedItems.Count == 0;
						if (flag5)
						{
							this.btnSua.Enabled = false;
							this.btnXoa.Enabled = false;
						}
					}
				}
			}
			else
			{
				this.funCommon.Msg("Vui lòng chọn loại sản phẩm để xóa.", "Lỗi");
			}
		}

		// Token: 0x04000118 RID: 280
		private List<LoaiSanPham> lstLoaiSanPham = new List<LoaiSanPham>();

		// Token: 0x04000119 RID: 281
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400011A RID: 282
		private FunctionCommon funCommon = new FunctionCommon();
	}
}

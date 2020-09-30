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
	// Token: 0x0200000F RID: 15
	public partial class frmKhuVuc : Form
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x000140CC File Offset: 0x000122CC
		public frmKhuVuc(KhuVuc khuvuc, string strtitle, int ItemIndex)
		{
			this.InitializeComponent();
			this.khuVuc = khuvuc;
			this.strTitle = strtitle;
			this.iRowIndex = ItemIndex - 1;
			this.Text += this.strTitle;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001417C File Offset: 0x0001237C
		private void frmKhuVuc_Load(object sender, EventArgs e)
		{
			bool flag = File.Exists(CMConstant.strFilePathKhuVuc);
			if (flag)
			{
				this.lstKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(CMConstant.strFilePathKhuVuc);
				bool flag2 = this.lstKhuVuc == null;
				if (flag2)
				{
					this.funcCommon.Msg("Lỗi đọc tập tin KhuVuc.csv", "Lỗi");
					return;
				}
				this.iNo = this.lstKhuVuc.Count;
			}
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
			this.txtTenKhuVuc.Select();
			bool flag3 = this.khuVuc != null && this.iRowIndex > -1;
			if (flag3)
			{
				this.iNo = this.khuVuc.iNo;
				this.strTenKhuVuc_Before = this.khuVuc.strTenKhuVuc;
				this.txtTenKhuVuc.Text = this.khuVuc.strTenKhuVuc;
				this.cbGiaMatHang.Text = this.khuVuc.strGiaMatHang;
				this.cbKhoHang.Text = this.khuVuc.strKhoHang;
				this.cbMauHoaDon.Text = this.khuVuc.strMauHoaDon;
				this.txtGhiChu.Text = this.khuVuc.strGhiChu;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00014314 File Offset: 0x00012514
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhuVuc);
			if (!flag)
			{
				this.btnSave.Enabled = false;
				this.btnSaveNew.Enabled = false;
				this.btnSaveExit.Enabled = false;
				this.btnExit.Enabled = true;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001436C File Offset: 0x0001256C
		private bool SaveData2CSV(string strFilePath)
		{
			bool flag = string.IsNullOrEmpty(this.txtTenKhuVuc.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				this.strTenKhuVuc = this.txtTenKhuVuc.Text;
				this.khuVuc = new KhuVuc();
				this.khuVuc.strTenKhuVuc = this.txtTenKhuVuc.Text;
				this.khuVuc.strGiaMatHang = this.cbGiaMatHang.Text;
				this.khuVuc.strKhoHang = this.cbKhoHang.Text;
				this.khuVuc.strMauHoaDon = this.cbMauHoaDon.Text;
				this.khuVuc.strGhiChu = this.txtGhiChu.Text;
				bool flag2 = this.strTitle.Equals(" - THÊM MỚI");
				if (flag2)
				{
					KhuVuc khuVuc = this.khuVuc;
					int num = this.iNo + 1;
					this.iNo = num;
					khuVuc.iNo = num;
					bool flag3 = File.Exists(strFilePath);
					if (flag3)
					{
						this.lstKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(strFilePath);
						bool flag4 = this.lstKhuVuc == null;
						if (flag4)
						{
							this.funcCommon.Msg("Lỗi đọc tập tin KhuVuc.csv", "Lỗi");
							return false;
						}
						foreach (KhuVuc khuVuc2 in this.lstKhuVuc)
						{
							bool flag5 = this.strTenKhuVuc.Equals(khuVuc2.strTenKhuVuc);
							if (flag5)
							{
								this.funcCommon.Msg("Tên khu vực [" + this.strTenKhuVuc + "] đã có trong danh sách khu vực.", "Cảnh báo");
								return false;
							}
						}
					}
					this.readwriteData2CSV.WriteKhuVuc2CSV(strFilePath, this.khuVuc);
				}
				else
				{
					bool flag6 = this.strTitle.Equals(" - CHỈNH SỬA");
					if (flag6)
					{
						this.khuVuc.iNo = this.iNo;
						bool flag7 = File.Exists(strFilePath);
						if (flag7)
						{
							this.lstKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(strFilePath);
							bool flag8 = this.lstKhuVuc == null;
							if (flag8)
							{
								this.funcCommon.Msg("Lỗi đọc tập tin KhuVuc.csv", "Lỗi");
								return false;
							}
							bool flag9 = !this.strTenKhuVuc_Before.Equals(this.strTenKhuVuc);
							if (flag9)
							{
								foreach (KhuVuc khuVuc3 in this.lstKhuVuc)
								{
									bool flag10 = this.strTenKhuVuc.Equals(khuVuc3.strTenKhuVuc);
									if (flag10)
									{
										this.funcCommon.Msg("Tên khu vực [" + this.strTenKhuVuc + "] đã có trong danh sách khu vực.", "Cảnh báo");
										return false;
									}
								}
							}
							bool flag11 = this.lstKhuVuc != null;
							if (flag11)
							{
								bool flag12 = this.lstKhuVuc.Count > 0;
								if (flag12)
								{
									this.lstKhuVuc.RemoveAt(this.iRowIndex);
									this.lstKhuVuc.Insert(this.iRowIndex, this.khuVuc);
									try
									{
										File.Delete(strFilePath);
									}
									catch
									{
										this.funcCommon.Msg("Không thể xóa KhuVuc.csv", "Lỗi");
										return false;
									}
									foreach (KhuVuc khuVuc4 in this.lstKhuVuc)
									{
										this.readwriteData2CSV.WriteKhuVuc2CSV(strFilePath, khuVuc4);
									}
								}
							}
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00014764 File Offset: 0x00012964
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.txtTenKhuVuc.Text = string.Empty;
			this.cbGiaMatHang.Text = string.Empty;
			this.cbKhoHang.Text = string.Empty;
			this.cbMauHoaDon.Text = string.Empty;
			this.txtGhiChu.Text = string.Empty;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000147C8 File Offset: 0x000129C8
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhuVuc);
			if (!flag)
			{
				this.txtTenKhuVuc.Text = string.Empty;
				this.cbGiaMatHang.Text = string.Empty;
				this.cbKhoHang.Text = string.Empty;
				this.cbMauHoaDon.Text = string.Empty;
				this.txtGhiChu.Text = string.Empty;
				this.btnSave.Enabled = true;
				this.btnSaveNew.Enabled = true;
				this.btnSaveExit.Enabled = true;
				this.btnExit.Enabled = true;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00014878 File Offset: 0x00012A78
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhuVuc);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000148A2 File Offset: 0x00012AA2
		private void txtTenKhuVuc_TextChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000148A2 File Offset: 0x00012AA2
		private void cbMauHoaDon_SelectedValueChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000148A2 File Offset: 0x00012AA2
		private void cbGiaMatHang_SelectedValueChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000148A2 File Offset: 0x00012AA2
		private void cbKhoHang_SelectedValueChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000148A2 File Offset: 0x00012AA2
		private void txtGhiChu_TextChanged(object sender, EventArgs e)
		{
			this.btnSave.Enabled = true;
			this.btnSaveNew.Enabled = true;
			this.btnSaveExit.Enabled = true;
			this.btnExit.Enabled = true;
		}

		// Token: 0x0400013A RID: 314
		private KhuVuc khuVuc = new KhuVuc();

		// Token: 0x0400013B RID: 315
		private List<KhuVuc> lstKhuVuc = new List<KhuVuc>();

		// Token: 0x0400013C RID: 316
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400013D RID: 317
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400013E RID: 318
		private string strTitle = string.Empty;

		// Token: 0x0400013F RID: 319
		private int iRowIndex = 0;

		// Token: 0x04000140 RID: 320
		private string strTenKhuVuc = string.Empty;

		// Token: 0x04000141 RID: 321
		private string strTenKhuVuc_Before = string.Empty;

		// Token: 0x04000142 RID: 322
		private int iNo = 0;
	}
}

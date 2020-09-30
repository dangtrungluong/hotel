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
	// Token: 0x02000014 RID: 20
	public partial class frmMatHang : Form
	{
		// Token: 0x06000187 RID: 391 RVA: 0x0002CE84 File Offset: 0x0002B084
		public frmMatHang(string strtitle, string strmatHang, List<NhomMatHang> lstnhomMatHang)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.strMatHang = strmatHang;
			this.Text += this.strTitle;
			this.lstNhomMatHang = lstnhomMatHang;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0002CF30 File Offset: 0x0002B130
		public frmMatHang(string strtitle, string strtenSP, MatHang matHang)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.Text += this.strTitle;
			this.strTenSP = strtenSP;
			this.MatHangSelected = matHang;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0002CFDC File Offset: 0x0002B1DC
		private void cbDVTBan_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtQuyDoi.Enabled = true;
			this.lblQuyDoi.Visible = true;
			bool flag = string.IsNullOrEmpty(this.cbDVTMua.Text) || string.IsNullOrEmpty(this.cbDVTBan.Text);
			if (flag)
			{
				this.txtQuyDoi.Enabled = false;
				this.lblQuyDoi.Visible = false;
			}
			this.lblQuyDoi.Text = string.Concat(new string[]
			{
				"(1 ",
				this.cbDVTMua.Text,
				" = ",
				this.txtQuyDoi.Text,
				" ",
				this.cbDVTBan.Text,
				")"
			});
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0002D0AC File Offset: 0x0002B2AC
		private void cbDVTMua_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtQuyDoi.Enabled = true;
			this.lblQuyDoi.Visible = true;
			bool flag = string.IsNullOrEmpty(this.cbDVTMua.Text) || string.IsNullOrEmpty(this.cbDVTBan.Text);
			if (flag)
			{
				this.txtQuyDoi.Enabled = false;
				this.lblQuyDoi.Visible = false;
			}
			this.lblQuyDoi.Text = string.Concat(new string[]
			{
				"(1 ",
				this.cbDVTMua.Text,
				" = ",
				this.txtQuyDoi.Text,
				" ",
				this.cbDVTBan.Text,
				")"
			});
			this.lblDVTNhap.Text = "/1 " + this.cbDVTMua.Text;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002D19C File Offset: 0x0002B39C
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV();
			if (flag)
			{
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0002D1BC File Offset: 0x0002B3BC
		private bool SaveData2CSV()
		{
			bool flag = string.IsNullOrEmpty(this.txtTenSanPham.Text) || string.IsNullOrEmpty(this.txtMaSanPham.Text) || string.IsNullOrEmpty(this.cbDVTBan.Text) || string.IsNullOrEmpty(this.cbDVTMua.Text) || string.IsNullOrEmpty(this.cbLoaiSanPham.Text) || string.IsNullOrEmpty(this.cbNhomSanPham.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = !this.funcCommon.IsValidDigital(this.txtGiaBan.Text) || !this.funcCommon.IsValidDigital(this.txtGiaMua.Text) || !this.funcCommon.IsValidDigital(this.txtQuyDoi.Text);
				if (flag2)
				{
					this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
					result = false;
				}
				else
				{
					bool flag3 = this.strTitle.Equals(" - THÊM MỚI");
					if (flag3)
					{
						bool flag4 = File.Exists(CMConstant.strFilePathMatHang);
						if (flag4)
						{
							this.lstMatHang = this.readwriteData2CSV.ReadMatHangFromCSV(CMConstant.strFilePathMatHang);
							foreach (MatHang matHang in this.lstMatHang)
							{
								bool flag5 = this.txtTenSanPham.Text.Equals(matHang.strTenSanPham);
								if (flag5)
								{
									this.funcCommon.Msg("Tên mặt hàng [" + this.txtTenSanPham.Text + "] đã có trong danh sách mặt hàng.", "Cảnh báo");
									return false;
								}
							}
						}
					}
					MatHang matHang2 = new MatHang();
					matHang2.strTenSanPham = this.txtTenSanPham.Text;
					matHang2.strMaSanPham = this.txtMaSanPham.Text;
					try
					{
						matHang2.iGiaMua = Convert.ToUInt64(this.txtGiaMua.Text);
						matHang2.iGiaBan = Convert.ToUInt64(this.txtGiaBan.Text);
						matHang2.iQuyDoi = (int)Convert.ToInt16(this.txtQuyDoi.Text);
					}
					catch
					{
						matHang2.iGiaMua = 0UL;
						matHang2.iGiaBan = 0UL;
						matHang2.iQuyDoi = 0;
						this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
					}
					matHang2.strDVTBan = this.cbDVTBan.Text;
					matHang2.strDVTMua = this.cbDVTMua.Text;
					matHang2.strNhomMatHang = this.cbNhomSanPham.Text;
					matHang2.strLoaiSanPham = this.cbLoaiSanPham.Text;
					bool flag6 = this.strTitle.Equals(" - THÊM MỚI");
					if (flag6)
					{
						MatHang matHang3 = matHang2;
						int num = this.iNo + 1;
						this.iNo = num;
						matHang3.iNo = num;
						this.readwriteData2CSV.WriteMatHang2CSV(CMConstant.strFilePathMatHang, matHang2);
					}
					else
					{
						bool flag7 = this.strTitle.Equals(" - CHỈNH SỬA");
						if (flag7)
						{
							matHang2.iNo = this.MatHangSelected.iNo;
							List<MatHang> list = new List<MatHang>();
							bool flag8 = File.Exists(CMConstant.strFilePathMatHang) && !string.IsNullOrEmpty(CMConstant.strFilePathMatHang);
							if (flag8)
							{
								this.lstMatHang = this.readwriteData2CSV.ReadMatHangFromCSV(CMConstant.strFilePathMatHang);
								bool flag9 = !this.strMatHang_Before.Equals(this.txtTenSanPham.Text);
								if (flag9)
								{
									foreach (MatHang matHang4 in this.lstMatHang)
									{
										bool flag10 = this.txtTenSanPham.Text.Equals(matHang4.strTenSanPham);
										if (flag10)
										{
											this.funcCommon.Msg("Tên mặt hàng [" + this.txtTenSanPham.Text + "] đã có trong danh sách mặt hàng.", "Cảnh báo");
											return false;
										}
									}
								}
								list = this.lstMatHang;
								bool flag11 = this.lstMatHang.Count > 0;
								if (flag11)
								{
									for (int i = 0; i < this.lstMatHang.Count; i++)
									{
										bool flag12 = this.lstMatHang[i].strTenSanPham.Equals(this.strTenSP);
										if (flag12)
										{
											this.iIndexSelectedRow = i;
											break;
										}
									}
									list.RemoveAt(this.iIndexSelectedRow);
									list.Insert(this.iIndexSelectedRow, matHang2);
									File.Delete(CMConstant.strFilePathMatHang);
									foreach (MatHang matHang5 in list)
									{
										this.readwriteData2CSV.WriteMatHang2CSV(CMConstant.strFilePathMatHang, matHang5);
									}
								}
							}
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV();
			if (!flag)
			{
				this.txtMaSanPham.Text = string.Empty;
				this.txtTenSanPham.Text = string.Empty;
				this.txtGiaMua.Text = 0.ToString();
				this.cbDVTMua.Text = string.Empty;
				this.cbDVTBan.Text = string.Empty;
				this.txtGiaBan.Text = 0.ToString();
				this.cbNhomSanPham.Text = string.Empty;
				this.cbLoaiSanPham.Text = string.Empty;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV();
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.txtMaSanPham.Text = string.Empty;
			this.txtTenSanPham.Text = string.Empty;
			this.txtGiaMua.Text = 0.ToString();
			this.cbDVTMua.Text = string.Empty;
			this.cbDVTBan.Text = string.Empty;
			this.txtGiaBan.Text = 0.ToString();
			this.cbNhomSanPham.Text = string.Empty;
			this.cbLoaiSanPham.Text = string.Empty;
			this.txtQuyDoi.Text = 0.ToString();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0002D88B File Offset: 0x0002BA8B
		private void txtGiaMua_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002D89C File Offset: 0x0002BA9C
		private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0002D88B File Offset: 0x0002BA8B
		private void txtGiaBan_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002D8C4 File Offset: 0x0002BAC4
		private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002D88B File Offset: 0x0002BA8B
		private void txtQuyDoi_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		private void txtQuyDoi_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002D914 File Offset: 0x0002BB14
		private void frmMatHang_Load(object sender, EventArgs e)
		{
			bool flag = File.Exists(CMConstant.strFilePathMatHang);
			if (flag)
			{
				this.lstMatHang = this.readwriteData2CSV.ReadMatHangFromCSV(CMConstant.strFilePathMatHang);
				this.iNo = this.lstMatHang.Count;
			}
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			foreach (NhomMatHang nhomMatHang in this.lstNhomMatHang)
			{
				this.cbNhomSanPham.Items.Add(nhomMatHang.strTenNhomMatHang);
			}
			this.cbNhomSanPham.SelectedItem = this.strMatHang;
			this.cbDVTBan.SelectedIndex = 0;
			this.cbDVTMua.SelectedIndex = 0;
			this.lblQuyDoi.Text = string.Concat(new string[]
			{
				"(1 ",
				this.cbDVTMua.Text,
				" = ",
				this.txtQuyDoi.Text,
				" ",
				this.cbDVTBan.Text,
				")"
			});
			this.lblDVTNhap.Text = "/1 " + this.cbDVTMua.Text;
			this.lblQuyDoi.Visible = true;
			this.txtQuyDoi.Enabled = true;
			this.cbNhomSanPham.Enabled = true;
			this.cbLoaiSanPham.Enabled = true;
			bool flag2 = string.IsNullOrEmpty(this.cbDVTMua.Text) || string.IsNullOrEmpty(this.cbDVTBan.Text);
			if (flag2)
			{
				this.lblQuyDoi.Visible = false;
				this.txtQuyDoi.Enabled = false;
			}
			bool flag3 = this.strTitle.Equals(" - CHỈNH SỬA");
			if (flag3)
			{
				this.txtMaSanPham.Text = this.MatHangSelected.strMaSanPham;
				this.txtTenSanPham.Text = this.MatHangSelected.strTenSanPham;
				this.txtGiaMua.Text = this.MatHangSelected.iGiaMua.ToString();
				this.cbDVTMua.Text = this.MatHangSelected.strDVTMua;
				this.txtGiaBan.Text = this.MatHangSelected.iGiaBan.ToString();
				this.cbDVTBan.Text = this.MatHangSelected.strDVTBan;
				this.txtQuyDoi.Text = this.MatHangSelected.iQuyDoi.ToString();
				this.cbNhomSanPham.Text = this.MatHangSelected.strNhomMatHang;
				this.cbLoaiSanPham.Text = this.MatHangSelected.strLoaiSanPham;
				this.strMatHang_Before = this.MatHangSelected.strTenSanPham;
			}
			this.txtTenSanPham.Focus();
		}

		// Token: 0x04000304 RID: 772
		private string strTitle;

		// Token: 0x04000305 RID: 773
		private string strMatHang;

		// Token: 0x04000306 RID: 774
		private List<NhomMatHang> lstNhomMatHang = new List<NhomMatHang>();

		// Token: 0x04000307 RID: 775
		private List<MatHang> lstMatHang = new List<MatHang>();

		// Token: 0x04000308 RID: 776
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x04000309 RID: 777
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400030A RID: 778
		private MatHang MatHangSelected = new MatHang();

		// Token: 0x0400030B RID: 779
		private int iNo = 0;

		// Token: 0x0400030C RID: 780
		private int iIndexSelectedRow = 0;

		// Token: 0x0400030D RID: 781
		private string strTenSP = string.Empty;

		// Token: 0x0400030E RID: 782
		private string strMatHang_Before = string.Empty;
	}
}

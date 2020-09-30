using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;

namespace Hotel
{
	// Token: 0x02000015 RID: 21
	public partial class frmRoomType : Form
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0002F088 File Offset: 0x0002D288
		public frmRoomType(string strtitle, string strtenLP)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.strTenLoaiPhong = strtenLP;
			this.Text += this.strTitle;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0002F134 File Offset: 0x0002D334
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathLoaiPhong);
			if (flag)
			{
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0002F158 File Offset: 0x0002D358
		private void frmRoomType_Load(object sender, EventArgs e)
		{
			this.txtForeColor.BackColor = Color.Black;
			this.txtBackColor.BackColor = Color.White;
			this.colorFore = Color.Black;
			this.colorBack = Color.White;
			bool flag = this.strTitle.Equals(" - THÊM MỚI");
			if (!flag)
			{
				bool flag2 = this.strTitle.Equals(" - CHỈNH SỬA");
				if (flag2)
				{
					bool flag3 = File.Exists(CMConstant.strFilePathLoaiPhong) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiPhong);
					if (flag3)
					{
						this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(CMConstant.strFilePathLoaiPhong);
						bool flag4 = this.lstLoaiPhong == null;
						if (flag4)
						{
							this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
						}
						else
						{
							bool flag5 = this.lstLoaiPhong.Count > 0;
							if (flag5)
							{
								for (int i = 0; i < this.lstLoaiPhong.Count; i++)
								{
									bool flag6 = this.lstLoaiPhong[i].strTenLoaiPhong.Equals(this.strTenLoaiPhong);
									if (flag6)
									{
										this.iIndexSelectedRow = i;
										break;
									}
								}
							}
							this.txtLoaiPhong.Text = this.lstLoaiPhong[this.iIndexSelectedRow].strTenLoaiPhong;
							this.txtForeColor.BackColor = Color.FromArgb(this.lstLoaiPhong[this.iIndexSelectedRow].iMauChu);
							this.txtBackColor.BackColor = Color.FromArgb(this.lstLoaiPhong[this.iIndexSelectedRow].iMauNen);
							this.txtDisplay.Text = this.lstLoaiPhong[this.iIndexSelectedRow].strTenHienThi;
							this.txtNote.Text = this.lstLoaiPhong[this.iIndexSelectedRow].strGhiChu;
							this.strTypeRoom_Before = this.lstLoaiPhong[this.iIndexSelectedRow].strTenLoaiPhong;
						}
					}
				}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0002F36C File Offset: 0x0002D56C
		private void txtForeColor_MouseClick(object sender, MouseEventArgs e)
		{
			DialogResult dialogResult = this.colorDialog1.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				this.txtForeColor.BackColor = this.colorDialog1.Color;
				this.colorFore = this.colorDialog1.Color;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		private void txtBackColor_MouseClick(object sender, MouseEventArgs e)
		{
			DialogResult dialogResult = this.colorDialog1.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				this.txtBackColor.BackColor = this.colorDialog1.Color;
				this.colorBack = this.colorDialog1.Color;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0002F404 File Offset: 0x0002D604
		private void txtLoaiPhong_TextChanged(object sender, EventArgs e)
		{
			this.txtDisplay.ForeColor = this.colorFore;
			this.txtDisplay.BackColor = this.colorBack;
			this.txtDisplay.Text = this.txtLoaiPhong.Text;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0002F444 File Offset: 0x0002D644
		private void txtBackColor_BackColorChanged(object sender, EventArgs e)
		{
			this.txtDisplay.ForeColor = this.txtForeColor.BackColor;
			this.txtDisplay.BackColor = this.txtBackColor.BackColor;
			this.txtDisplay.Text = this.txtLoaiPhong.Text;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002F498 File Offset: 0x0002D698
		private void txtForeColor_BackColorChanged(object sender, EventArgs e)
		{
			this.txtDisplay.ForeColor = this.txtForeColor.BackColor;
			this.txtDisplay.BackColor = this.txtBackColor.BackColor;
			this.txtDisplay.Text = this.txtLoaiPhong.Text;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002F4EC File Offset: 0x0002D6EC
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathLoaiPhong);
			if (!flag)
			{
				this.txtLoaiPhong.Text = string.Empty;
				this.txtDisplay.Text = string.Empty;
				this.txtNote.Text = string.Empty;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002F544 File Offset: 0x0002D744
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathLoaiPhong);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002F570 File Offset: 0x0002D770
		private bool SaveData2CSV(string strPathFileName)
		{
			LoaiPhong loaiPhong = new LoaiPhong();
			bool flag = string.IsNullOrEmpty(this.txtLoaiPhong.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = this.strTitle.Equals(" - THÊM MỚI");
				if (flag2)
				{
					bool flag3 = File.Exists(strPathFileName) && !string.IsNullOrEmpty(strPathFileName);
					if (flag3)
					{
						this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(strPathFileName);
						bool flag4 = this.lstLoaiPhong == null;
						if (flag4)
						{
							this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
							return false;
						}
						foreach (LoaiPhong loaiPhong2 in this.lstLoaiPhong)
						{
							bool flag5 = this.txtLoaiPhong.Text.Equals(loaiPhong2.strTenLoaiPhong);
							if (flag5)
							{
								this.funcCommon.Msg("Tên loại phòng [" + this.txtLoaiPhong.Text + "] đã có trong danh sách loại phòng.", "Cảnh báo");
								return false;
							}
						}
					}
				}
				loaiPhong.strTenLoaiPhong = this.txtLoaiPhong.Text;
				loaiPhong.iMauChu = this.txtForeColor.BackColor.ToArgb();
				loaiPhong.iMauNen = this.txtBackColor.BackColor.ToArgb();
				loaiPhong.strTenHienThi = this.txtDisplay.Text;
				loaiPhong.strGhiChu = this.txtNote.Text;
				bool flag6 = this.strTitle.Equals(" - THÊM MỚI");
				if (flag6)
				{
					this.readwriteData2CSV.WriteLoaiPhong2CSV(strPathFileName, loaiPhong);
				}
				else
				{
					bool flag7 = this.strTitle.Equals(" - CHỈNH SỬA");
					if (flag7)
					{
						List<LoaiPhong> list = new List<LoaiPhong>();
						bool flag8 = File.Exists(strPathFileName) && !string.IsNullOrEmpty(strPathFileName);
						if (flag8)
						{
							this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(strPathFileName);
							bool flag9 = this.lstLoaiPhong == null;
							if (flag9)
							{
								this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
								return false;
							}
							bool flag10 = !this.strTypeRoom_Before.Equals(this.txtLoaiPhong.Text);
							if (flag10)
							{
								foreach (LoaiPhong loaiPhong3 in this.lstLoaiPhong)
								{
									bool flag11 = this.txtLoaiPhong.Text.Equals(loaiPhong3.strTenLoaiPhong);
									if (flag11)
									{
										this.funcCommon.Msg("Tên loại phòng [" + this.txtLoaiPhong.Text + "] đã có trong danh sách loại phòng.", "Cảnh báo");
										return false;
									}
								}
							}
							list = this.lstLoaiPhong;
							bool flag12 = this.lstLoaiPhong.Count > 0;
							if (flag12)
							{
								for (int i = 0; i < this.lstLoaiPhong.Count; i++)
								{
									bool flag13 = this.lstLoaiPhong[i].strTenLoaiPhong.Equals(this.strTenLoaiPhong);
									if (flag13)
									{
										this.iIndexSelectedRow = i;
										break;
									}
								}
								list.RemoveAt(this.iIndexSelectedRow);
								list.Insert(this.iIndexSelectedRow, loaiPhong);
								File.Delete(strPathFileName);
								foreach (LoaiPhong loaiPhong4 in list)
								{
									this.readwriteData2CSV.WriteLoaiPhong2CSV(strPathFileName, loaiPhong4);
								}
							}
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0002F974 File Offset: 0x0002DB74
		private void txtLoaiPhong_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = e.KeyChar == '\r';
			if (flag)
			{
				bool flag2 = !this.SaveData2CSV(CMConstant.strFilePathLoaiPhong);
				if (!flag2)
				{
					this.txtLoaiPhong.Text = string.Empty;
					this.txtDisplay.Text = string.Empty;
					this.txtNote.Text = string.Empty;
				}
			}
		}

		// Token: 0x0400032E RID: 814
		private List<LoaiPhong> lstLoaiPhong = new List<LoaiPhong>();

		// Token: 0x0400032F RID: 815
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x04000330 RID: 816
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x04000331 RID: 817
		private string strTitle = string.Empty;

		// Token: 0x04000332 RID: 818
		private Color colorFore = default(Color);

		// Token: 0x04000333 RID: 819
		private Color colorBack = default(Color);

		// Token: 0x04000334 RID: 820
		private string strTenLoaiPhong = string.Empty;

		// Token: 0x04000335 RID: 821
		private int iIndexSelectedRow = 0;

		// Token: 0x04000336 RID: 822
		private string strTypeRoom_Before = string.Empty;
	}
}

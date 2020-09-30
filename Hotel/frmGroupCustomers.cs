using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Properties;

namespace Hotel
{
	// Token: 0x0200000C RID: 12
	public partial class frmGroupCustomers : Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public frmGroupCustomers(string strtitle)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.Text += this.strTitle;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000FB98 File Offset: 0x0000DD98
		public frmGroupCustomers(DataRow dr, string strtitle, int ItemIndex)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.Text += this.strTitle;
			this.dataRow = dr;
			this.iRowIndex = ItemIndex - 1;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathNhomKhachHang);
			if (flag)
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000FC50 File Offset: 0x0000DE50
		private bool SaveData2CSV(string strFilePath)
		{
			DataTable dataTable = new DataTable();
			bool flag = string.IsNullOrEmpty(this.txtTenNhomKhachHang.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = !this.funcCommon.IsValidDigital(this.txtDiemTichLuy.Text) || !this.funcCommon.IsValidDigital(this.txtGiamTienHang.Text) || !this.funcCommon.IsValidDigital(this.txtGiamTienGio.Text) || !this.funcCommon.IsValidDigital(this.txtGiamDoUong.Text) || !this.funcCommon.IsValidDigital(this.txtGiamDoAn.Text) || !this.funcCommon.IsValidDigital(this.txtGiamDichVu.Text) || !this.funcCommon.IsValidDigital(this.txtGiamDoKhac.Text);
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
						bool flag4 = File.Exists(strFilePath);
						if (flag4)
						{
							int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
							bool flag5 = !this.funcCommon.ShowMsg(iErrorCode, "NhomKhachHang.csv");
							if (flag5)
							{
								return false;
							}
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								bool flag6 = this.txtTenNhomKhachHang.Text.Equals(dataRow["Tên nhóm khách hàng"].ToString());
								if (flag6)
								{
									this.funcCommon.Msg("Tên nhóm khách hàng [" + this.txtTenNhomKhachHang.Text + "] đã có trong danh sách tên nhóm khách hàng.", "Cảnh báo");
									return false;
								}
							}
						}
					}
					NhomKhachHang nhomKhachHang = new NhomKhachHang();
					nhomKhachHang.strTenNhomKhachHang = this.txtTenNhomKhachHang.Text;
					try
					{
						nhomKhachHang.iDiemTichLuy = (int)Convert.ToUInt16(this.txtDiemTichLuy.Text);
						nhomKhachHang.iGiamTienHang = (int)Convert.ToUInt16(this.txtGiamTienHang.Text);
						nhomKhachHang.iGiamTienGio = (int)Convert.ToUInt16(this.txtGiamTienGio.Text);
						nhomKhachHang.iGiamDoAn = (int)Convert.ToUInt16(this.txtGiamDoAn.Text);
						nhomKhachHang.iGiamDoUong = (int)Convert.ToUInt16(this.txtGiamDoUong.Text);
						nhomKhachHang.iGiamDichVu = (int)Convert.ToUInt16(this.txtGiamDichVu.Text);
						nhomKhachHang.iGiamDoKhac = (int)Convert.ToUInt16(this.txtGiamDoKhac.Text);
					}
					catch
					{
						nhomKhachHang.iDiemTichLuy = 0;
						nhomKhachHang.iGiamTienHang = 0;
						nhomKhachHang.iGiamTienGio = 0;
						nhomKhachHang.iGiamDoAn = 0;
						nhomKhachHang.iGiamDoUong = 0;
						nhomKhachHang.iGiamDichVu = 0;
						nhomKhachHang.iGiamDoKhac = 0;
						this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
					}
					bool flag7 = this.strTitle.Equals(" - THÊM MỚI");
					if (flag7)
					{
						NhomKhachHang nhomKhachHang2 = nhomKhachHang;
						int num = this.iNo + 1;
						this.iNo = num;
						nhomKhachHang2.iNo = num;
						DataTable dataTable2 = new DataTable();
						string[] strHeaderNhomKhachHang = CMConstant.strHeaderNhomKhachHang;
						for (int i = 0; i < strHeaderNhomKhachHang.Length; i++)
						{
							dataTable2.Columns.Add(strHeaderNhomKhachHang[i].ToString(), typeof(string));
						}
						DataRow dataRow2 = dataTable2.NewRow();
						dataRow2[0] = nhomKhachHang.iNo;
						dataRow2[1] = nhomKhachHang.strTenNhomKhachHang;
						dataRow2[2] = nhomKhachHang.iDiemTichLuy;
						dataRow2[3] = nhomKhachHang.iGiamTienHang;
						dataRow2[4] = nhomKhachHang.iGiamTienGio;
						dataRow2[5] = nhomKhachHang.iGiamDoAn;
						dataRow2[6] = nhomKhachHang.iGiamDoUong;
						dataRow2[7] = nhomKhachHang.iGiamDichVu;
						dataRow2[8] = nhomKhachHang.iGiamDoKhac;
						dataTable2.Rows.Add(dataRow2);
						this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable2, 1);
					}
					else
					{
						bool flag8 = this.strTitle.Equals(" - CHỈNH SỬA");
						if (flag8)
						{
							int num2 = -1;
							DataTable dataTable3 = new DataTable();
							bool flag9 = File.Exists(strFilePath);
							if (flag9)
							{
								int iErrorCode2 = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable3);
								bool flag10 = !this.funcCommon.ShowMsg(iErrorCode2, "NhomKhachHang.csv");
								if (flag10)
								{
									return false;
								}
								bool flag11 = !this.strTenNhomKH_Before.Equals(this.txtTenNhomKhachHang.Text);
								if (flag11)
								{
									foreach (object obj2 in dataTable3.Rows)
									{
										DataRow dataRow3 = (DataRow)obj2;
										bool flag12 = this.txtTenNhomKhachHang.Text.Equals(dataRow3["Tên nhóm khách hàng"].ToString());
										if (flag12)
										{
											this.funcCommon.Msg("Tên nhóm khách hàng [" + this.txtTenNhomKhachHang.Text + "] đã có trong danh sách tên nhóm khách hàng.", "Cảnh báo");
											return false;
										}
									}
								}
								bool flag13 = dataTable3.Rows.Count > 0;
								if (flag13)
								{
									for (int j = 0; j < dataTable3.Rows.Count; j++)
									{
										bool flag14 = dataTable3.Rows[j][1].Equals(this.strTenNhomKH_Before);
										if (flag14)
										{
											num2 = j;
											break;
										}
									}
								}
								dataTable3.Rows.RemoveAt(num2);
								DataRow dataRow4 = dataTable3.NewRow();
								dataRow4[0] = this.iNo;
								dataRow4[1] = this.txtTenNhomKhachHang.Text;
								dataRow4[2] = this.txtDiemTichLuy.Text;
								dataRow4[3] = this.txtGiamTienHang.Text;
								dataRow4[4] = this.txtGiamTienGio.Text;
								dataRow4[5] = this.txtGiamDoAn.Text;
								dataRow4[6] = this.txtGiamDoUong.Text;
								dataRow4[7] = this.txtGiamDichVu.Text;
								dataRow4[8] = this.txtGiamDoKhac.Text;
								dataTable3.Rows.InsertAt(dataRow4, num2);
								this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable3, 2);
							}
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00010378 File Offset: 0x0000E578
		private void frmCustomers_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			this.txtTenNhomKhachHang.Select();
			bool flag = this.strTitle.Equals(" - THÊM MỚI");
			if (flag)
			{
				bool flag2 = File.Exists(CMConstant.strFilePathNhomKhachHang);
				if (flag2)
				{
					DataTable dataTable = new DataTable();
					int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathNhomKhachHang, ref dataTable);
					bool flag3 = !this.funcCommon.ShowMsg(iErrorCode, "NhomKhachHang.csv");
					if (!flag3)
					{
						this.iNo = dataTable.Rows.Count;
					}
				}
			}
			else
			{
				bool flag4 = this.strTitle.Equals(" - CHỈNH SỬA");
				if (flag4)
				{
					try
					{
						bool flag5 = this.dataRow != null;
						if (flag5)
						{
							this.iNo = (int)Convert.ToInt16(this.dataRow["ID"].ToString());
							this.txtTenNhomKhachHang.Text = this.dataRow["Tên nhóm khách hàng"].ToString();
							this.txtDiemTichLuy.Text = this.dataRow["Điểm tích lũy"].ToString();
							this.txtGiamTienHang.Text = this.dataRow["Tỉ lệ giảm tiền hàng(%)"].ToString();
							this.txtGiamTienGio.Text = this.dataRow["Tỉ lệ giảm tiền giờ(%)"].ToString();
							this.txtGiamDoAn.Text = this.dataRow["Tỉ lệ giảm tiền đồ ăn(%)"].ToString();
							this.txtGiamDoUong.Text = this.dataRow["Tỉ lệ giảm tiền đồ uống(%)"].ToString();
							this.txtGiamDichVu.Text = this.dataRow["Tỉ lệ giảm tiền dịch vụ(%)"].ToString();
							this.txtGiamDoKhac.Text = this.dataRow["Tỉ lệ giảm tiền đồ khác(%)"].ToString();
							this.strTenNhomKH_Before = this.dataRow["Tên nhóm khách hàng"].ToString();
						}
					}
					catch (Exception ex)
					{
						this.funcCommon.Msg(ex.Message, "Lỗi");
					}
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtDiemTichLuy_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00010604 File Offset: 0x0000E804
		private void txtDiemTichLuy_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamTienHang_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001062C File Offset: 0x0000E82C
		private void txtGiamTienHang_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamTienGio_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00010654 File Offset: 0x0000E854
		private void txtGiamTienGio_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamDoAn_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0001067C File Offset: 0x0000E87C
		private void txtGiamDoAn_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamDoUong_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000106A4 File Offset: 0x0000E8A4
		private void txtGiamDoUong_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamDichVu_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000106CC File Offset: 0x0000E8CC
		private void txtGiamDichVu_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000105F4 File Offset: 0x0000E7F4
		private void txtGiamDoKhac_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000106F4 File Offset: 0x0000E8F4
		private void txtGiamDoKhac_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001071C File Offset: 0x0000E91C
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathNhomKhachHang);
			if (!flag)
			{
				this.txtTenNhomKhachHang.Text = string.Empty;
				this.txtDiemTichLuy.Text = 0.ToString();
				this.txtGiamTienHang.Text = 0.ToString();
				this.txtGiamTienGio.Text = 0.ToString();
				this.txtGiamDoAn.Text = 0.ToString();
				this.txtGiamDoUong.Text = 0.ToString();
				this.txtGiamDoKhac.Text = 0.ToString();
				this.txtGiamDichVu.Text = 0.ToString();
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000107E8 File Offset: 0x0000E9E8
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathNhomKhachHang);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000EF RID: 239
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x040000F0 RID: 240
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x040000F1 RID: 241
		private DataRow dataRow = null;

		// Token: 0x040000F2 RID: 242
		private string strTitle = string.Empty;

		// Token: 0x040000F3 RID: 243
		private int iNo = 0;

		// Token: 0x040000F4 RID: 244
		private int iRowIndex = -1;

		// Token: 0x040000F5 RID: 245
		private string strTenNhomKH_Before = string.Empty;
	}
}

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
	// Token: 0x02000009 RID: 9
	public partial class frmCustomer : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000CF4C File Offset: 0x0000B14C
		public frmCustomer(string strtitle, string strnhomkh)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.strNhomKhachHang = strnhomkh;
			this.Text += this.strTitle;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public frmCustomer(string strtitle, DataRow dr)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.dtRow = dr;
			this.Text += this.strTitle;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000D06C File Offset: 0x0000B26C
		private void frmCustomer_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			this.txtMaKH.Select();
			bool flag = this.strTitle.Equals(" - THÊM MỚI");
			if (flag)
			{
				this.cbThanhVien.Items.Add(this.strNhomKhachHang);
				this.cbThanhVien.Text = this.strNhomKhachHang;
				DataTable dataTable = new DataTable();
				bool flag2 = File.Exists(CMConstant.strFilePathKhachHang);
				if (flag2)
				{
					int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachHang, ref dataTable);
					bool flag3 = !this.funcCommon.ShowMsg(iErrorCode, "KhachHang.csv");
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
						bool flag5 = this.dtRow != null;
						if (flag5)
						{
							this.iNo = (int)Convert.ToInt16(this.dtRow["ID"].ToString());
							this.txtMaKH.Text = this.dtRow["Mã khách hàng"].ToString();
							this.txtTenKH.Text = this.dtRow["Tên khách hàng"].ToString();
							this.txtDiaChi.Text = this.dtRow["Địa chỉ"].ToString();
							this.txtDienThoai.Text = this.dtRow["Điện thoại"].ToString();
							this.txtFax.Text = this.dtRow["Fax"].ToString();
							this.txtCMND.Text = this.dtRow["Số CMND"].ToString();
							string[] array = this.dtRow["Ngày cấp"].ToString().Split(new char[]
							{
								'/'
							});
							DateTime value = new DateTime((int)Convert.ToInt16(array[2]), (int)Convert.ToInt16(array[1]), (int)Convert.ToInt16(array[0]));
							this.dtNgay.Value = value;
							this.cbNoiCap.Text = this.dtRow["Nơi cấp"].ToString();
							this.txtHoChieu.Text = this.dtRow["Hộ chiếu"].ToString();
							this.txtGPLX.Text = this.dtRow["GPLX"].ToString();
							this.txtMST.Text = this.dtRow["Mã số thuế"].ToString();
							this.txtEmail.Text = this.dtRow["Email"].ToString();
							this.txtMaTheTu.Text = this.dtRow["Mã thẻ từ"].ToString();
							this.cbThanhVien.Text = this.dtRow["Thành viên"].ToString();
							this.txtGhiChu.Text = this.dtRow["Ghi chú"].ToString();
							this.strMaKH_Before = this.dtRow["Mã khách hàng"].ToString();
						}
					}
					catch (Exception ex)
					{
						this.funcCommon.Msg(ex.Message, "Lỗi");
					}
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000D430 File Offset: 0x0000B630
		private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D440 File Offset: 0x0000B640
		private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D430 File Offset: 0x0000B630
		private void txtCMND_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D468 File Offset: 0x0000B668
		private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000D430 File Offset: 0x0000B630
		private void txtHoChieu_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000D490 File Offset: 0x0000B690
		private void txtHoChieu_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000D430 File Offset: 0x0000B630
		private void txtMST_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		private void txtMST_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000D430 File Offset: 0x0000B630
		private void txtGPLX_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		private void txtGPLX_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000D508 File Offset: 0x0000B708
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhachHang);
			if (flag)
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000D52C File Offset: 0x0000B72C
		private bool SaveData2CSV(string strFilePath)
		{
			DataTable dataTable = new DataTable();
			bool flag = string.IsNullOrEmpty(this.txtMaKH.Text) || string.IsNullOrEmpty(this.txtTenKH.Text);
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
					bool flag3 = File.Exists(strFilePath);
					if (flag3)
					{
						int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
						bool flag4 = !this.funcCommon.ShowMsg(iErrorCode, "KhachHang.csv");
						if (flag4)
						{
							return false;
						}
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							bool flag5 = this.txtMaKH.Text.Equals(dataRow["Mã khách hàng"].ToString());
							if (flag5)
							{
								this.funcCommon.Msg("Mã khách hàng [" + this.txtMaKH.Text + "] đã có trong danh sách mã khách hàng.", "Cảnh báo");
								return false;
							}
						}
					}
				}
				bool flag6 = this.strTitle.Equals(" - THÊM MỚI");
				if (flag6)
				{
					DataTable dataTable2 = new DataTable();
					string[] strHeaderKhachHang = CMConstant.strHeaderKhachHang;
					for (int i = 0; i < strHeaderKhachHang.Length; i++)
					{
						dataTable2.Columns.Add(strHeaderKhachHang[i].ToString(), typeof(string));
					}
					DataRow dataRow2 = dataTable2.NewRow();
					string[] array = new string[16];
					int num = 0;
					int num2 = this.iNo + 1;
					this.iNo = num2;
					array[num] = num2.ToString();
					array[1] = this.txtMaKH.Text;
					array[2] = this.txtTenKH.Text;
					array[3] = this.txtDiaChi.Text;
					array[4] = this.txtDienThoai.Text;
					array[5] = this.txtFax.Text;
					array[6] = this.txtCMND.Text;
					array[7] = this.dtNgay.Text;
					array[8] = this.cbNoiCap.Text;
					array[9] = this.txtHoChieu.Text;
					array[10] = this.txtGPLX.Text;
					array[11] = this.txtMST.Text;
					array[12] = this.txtEmail.Text;
					array[13] = this.txtMaTheTu.Text;
					array[14] = this.cbThanhVien.Text;
					array[15] = this.txtGhiChu.Text;
					string[] array2 = array;
					for (int j = 0; j < array2.Length; j++)
					{
						dataRow2[j] = array2[j].ToString();
					}
					dataTable2.Rows.Add(dataRow2);
					this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable2, 1);
				}
				else
				{
					bool flag7 = this.strTitle.Equals(" - CHỈNH SỬA");
					if (flag7)
					{
						int num3 = -1;
						DataTable dataTable3 = new DataTable();
						bool flag8 = File.Exists(strFilePath);
						if (flag8)
						{
							int iErrorCode2 = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable3);
							bool flag9 = !this.funcCommon.ShowMsg(iErrorCode2, "KhachHang.csv");
							if (flag9)
							{
								return false;
							}
							bool flag10 = !this.strMaKH_Before.Equals(this.txtMaKH.Text);
							if (flag10)
							{
								foreach (object obj2 in dataTable3.Rows)
								{
									DataRow dataRow3 = (DataRow)obj2;
									bool flag11 = this.txtMaKH.Text.Equals(dataRow3["Mã khách hàng"].ToString());
									if (flag11)
									{
										this.funcCommon.Msg("Mã khách hàng [" + this.txtMaKH.Text + "] đã có trong danh sách mã khách hàng.", "Cảnh báo");
										return false;
									}
								}
							}
							bool flag12 = dataTable3.Rows.Count > 0;
							if (flag12)
							{
								for (int k = 0; k < dataTable3.Rows.Count; k++)
								{
									bool flag13 = dataTable3.Rows[k][1].Equals(this.strMaKH_Before);
									if (flag13)
									{
										num3 = k;
										break;
									}
								}
							}
							bool flag14 = num3 > -1;
							if (flag14)
							{
								dataTable3.Rows.RemoveAt(num3);
							}
							DataRow dataRow4 = dataTable3.NewRow();
							string[] array3 = new string[16];
							int num4 = 0;
							int num2 = this.iNo + 1;
							this.iNo = num2;
							array3[num4] = num2.ToString();
							array3[1] = this.txtMaKH.Text;
							array3[2] = this.txtTenKH.Text;
							array3[3] = this.txtDiaChi.Text;
							array3[4] = this.txtDienThoai.Text;
							array3[5] = this.txtFax.Text;
							array3[6] = this.txtCMND.Text;
							array3[7] = this.dtNgay.Text;
							array3[8] = this.cbNoiCap.Text;
							array3[9] = this.txtHoChieu.Text;
							array3[10] = this.txtGPLX.Text;
							array3[11] = this.txtMST.Text;
							array3[12] = this.txtEmail.Text;
							array3[13] = this.txtMaTheTu.Text;
							array3[14] = this.cbThanhVien.Text;
							array3[15] = this.txtGhiChu.Text;
							string[] array4 = array3;
							for (int l = 0; l < array4.Length; l++)
							{
								dataRow4[l] = array4[l].ToString();
							}
							dataTable3.Rows.InsertAt(dataRow4, num3);
							this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable3, 2);
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000DB64 File Offset: 0x0000BD64
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhachHang);
			if (!flag)
			{
				this.txtMaKH.Text = string.Empty;
				this.txtTenKH.Text = string.Empty;
				this.txtDiaChi.Text = string.Empty;
				this.txtDienThoai.Text = string.Empty;
				this.txtFax.Text = string.Empty;
				this.txtCMND.Text = string.Empty;
				this.cbNoiCap.Text = string.Empty;
				this.txtHoChieu.Text = string.Empty;
				this.txtGPLX.Text = string.Empty;
				this.txtMaTheTu.Text = string.Empty;
				this.txtMST.Text = string.Empty;
				this.txtEmail.Text = string.Empty;
				this.txtGhiChu.Text = string.Empty;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000DC68 File Offset: 0x0000BE68
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathKhachHang);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000B4 RID: 180
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x040000B5 RID: 181
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x040000B6 RID: 182
		private string strTitle = string.Empty;

		// Token: 0x040000B7 RID: 183
		private string strNhomKhachHang = string.Empty;

		// Token: 0x040000B8 RID: 184
		private int iNo = 0;

		// Token: 0x040000B9 RID: 185
		private string strMaKH_Before = string.Empty;

		// Token: 0x040000BA RID: 186
		private DataRow dtRow = null;
	}
}

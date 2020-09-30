using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Properties;

namespace Hotel
{
	// Token: 0x02000018 RID: 24
	public partial class frmTable : Form
	{
		// Token: 0x060001AD RID: 429 RVA: 0x000306F8 File Offset: 0x0002E8F8
		public frmTable(string strtitle, string strkhuvuc)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.strKhuVuc = strkhuvuc;
			this.Text += this.strTitle;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000307AC File Offset: 0x0002E9AC
		public frmTable(string strtitle, Table table)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.tbTable = table;
			this.strTenBan = this.tbTable.strTenBan;
			this.Text += this.strTitle;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00030870 File Offset: 0x0002EA70
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBan);
			if (flag)
			{
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00030894 File Offset: 0x0002EA94
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBan);
			if (!flag)
			{
				this.txtTenBan.Text = string.Empty;
				this.txtTienMoBan.Text = 0.ToString();
				this.cbKhuVuc.Text = string.Empty;
				this.cbLoaiPhong.Text = string.Empty;
				this.cbNhomHienThi.Text = string.Empty;
				this.txtGhiChu.Text = string.Empty;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00030924 File Offset: 0x0002EB24
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBan);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00030950 File Offset: 0x0002EB50
		private bool SaveData2CSV(string strFilePath)
		{
			DataTable dataTable = new DataTable();
			bool flag = string.IsNullOrEmpty(this.txtTenBan.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = !this.funcCommon.IsValidDigital(this.txtTienMoBan.Text);
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
							bool flag5 = !this.funcCommon.ShowMsg(iErrorCode, "Ban.csv");
							if (flag5)
							{
								return false;
							}
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								bool flag6 = this.txtTenBan.Text.Equals(dataRow["Tên bàn"].ToString());
								if (flag6)
								{
									this.funcCommon.Msg("Tên bàn [" + this.txtTenBan.Text + "] đã có trong danh sách tên bàn.", "Cảnh báo");
									return false;
								}
							}
						}
					}
					Table table = new Table();
					table.strTenBan = this.txtTenBan.Text;
					try
					{
						table.iTienMoBan = Convert.ToUInt64(this.txtTienMoBan.Text);
					}
					catch
					{
						table.iTienMoBan = 0UL;
						this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
					}
					table.strKhuVuc = this.cbKhuVuc.Text;
					table.strNhomHienThi = this.cbNhomHienThi.Text;
					table.strLoaiPhong = this.cbLoaiPhong.Text;
					table.strGhiChu = this.txtGhiChu.Text;
					bool flag7 = this.strTitle.Equals(" - THÊM MỚI");
					if (flag7)
					{
						Table table2 = table;
						int num = this.iNo + 1;
						this.iNo = num;
						table2.iNo = num;
						DataTable dataTable2 = new DataTable();
						string[] strHeaderTable = CMConstant.strHeaderTable;
						for (int i = 0; i < strHeaderTable.Length; i++)
						{
							dataTable2.Columns.Add(strHeaderTable[i].ToString(), typeof(string));
						}
						DataRow dataRow2 = dataTable2.NewRow();
						dataRow2[0] = table.iNo;
						dataRow2[1] = table.strTenBan;
						dataRow2[2] = table.iTienMoBan;
						dataRow2[3] = table.strKhuVuc;
						dataRow2[4] = table.strNhomHienThi;
						dataRow2[5] = table.strLoaiPhong;
						dataRow2[6] = table.strGhiChu;
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
								bool flag10 = !this.funcCommon.ShowMsg(iErrorCode2, "Ban.csv");
								if (flag10)
								{
									return false;
								}
								bool flag11 = !this.strTable_Before.Equals(this.txtTenBan.Text);
								if (flag11)
								{
									foreach (object obj2 in dataTable3.Rows)
									{
										DataRow dataRow3 = (DataRow)obj2;
										bool flag12 = this.txtTenBan.Text.Equals(dataRow3["Tên bàn"].ToString());
										if (flag12)
										{
											this.funcCommon.Msg("Tên bàn [" + this.txtTenBan.Text + "] đã có trong danh sách tên bàn.", "Cảnh báo");
											return false;
										}
									}
								}
								bool flag13 = dataTable3.Rows.Count > 0;
								if (flag13)
								{
									for (int j = 0; j < dataTable3.Rows.Count; j++)
									{
										bool flag14 = dataTable3.Rows[j][1].Equals(this.strTenBan);
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
								dataRow4[1] = this.txtTenBan.Text;
								dataRow4[2] = this.txtTienMoBan.Text;
								dataRow4[3] = this.cbKhuVuc.Text;
								dataRow4[4] = this.cbNhomHienThi.Text;
								dataRow4[5] = this.cbLoaiPhong.Text;
								dataRow4[6] = this.txtGhiChu.Text;
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

		// Token: 0x060001B4 RID: 436 RVA: 0x00030F10 File Offset: 0x0002F110
		private void Table_Load(object sender, EventArgs e)
		{
			this.txtTenBan.Enabled = true;
			for (int i = 0; i < base.Width; i++)
			{
				Label label = this.lblLine;
				label.Text += "_";
			}
			this.txtTenBan.Select();
			bool flag = this.strTitle.Equals(" - THÊM MỚI");
			if (flag)
			{
				bool flag2 = File.Exists(CMConstant.strFilePathKhuVuc);
				if (flag2)
				{
					this.lstKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(CMConstant.strFilePathKhuVuc);
					bool flag3 = this.lstKhuVuc == null;
					if (flag3)
					{
						this.funcCommon.Msg("Lỗi đọc tập tin KhuVuc.csv", "Lỗi");
						return;
					}
				}
				bool flag4 = File.Exists(CMConstant.strFilePathLoaiPhong);
				if (flag4)
				{
					this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(CMConstant.strFilePathLoaiPhong);
					bool flag5 = this.lstLoaiPhong == null;
					if (flag5)
					{
						this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
						return;
					}
				}
				bool flag6 = File.Exists(CMConstant.strFilePathBan);
				if (flag6)
				{
					DataTable dataTable = new DataTable();
					int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathBan, ref dataTable);
					bool flag7 = !this.funcCommon.ShowMsg(iErrorCode, "Ban.csv");
					if (flag7)
					{
						return;
					}
					this.iNo = dataTable.Rows.Count;
				}
				this.cbKhuVuc.Items.Add(string.Empty);
				foreach (KhuVuc khuVuc in this.lstKhuVuc)
				{
					this.cbKhuVuc.Items.Add(khuVuc.strTenKhuVuc);
				}
				this.cbKhuVuc.SelectedIndex = 0;
				bool flag8 = this.cbKhuVuc.Items.Count > 1;
				if (flag8)
				{
					this.cbKhuVuc.Text = this.strKhuVuc;
				}
				this.cbNhomHienThi.Items.Add(string.Empty);
				this.cbLoaiPhong.Items.Add(string.Empty);
				foreach (LoaiPhong loaiPhong in this.lstLoaiPhong)
				{
					this.cbNhomHienThi.Items.Add(loaiPhong.strTenLoaiPhong);
					this.cbLoaiPhong.Items.Add(loaiPhong.strTenLoaiPhong);
				}
				this.cbNhomHienThi.SelectedIndex = 0;
				this.cbLoaiPhong.SelectedIndex = 0;
			}
			else
			{
				bool flag9 = this.strTitle.Equals(" - CHỈNH SỬA");
				if (flag9)
				{
					this.iNo = this.tbTable.iNo;
					this.txtTenBan.Text = this.tbTable.strTenBan;
					this.txtTienMoBan.Text = this.tbTable.iTienMoBan.ToString();
					this.cbKhuVuc.Text = this.tbTable.strKhuVuc;
					this.cbNhomHienThi.Text = this.tbTable.strNhomHienThi;
					this.cbLoaiPhong.Text = this.tbTable.strLoaiPhong;
					this.txtGhiChu.Text = this.tbTable.strGhiChu;
					this.strTable_Before = this.tbTable.strTenBan;
				}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000312C0 File Offset: 0x0002F4C0
		private void txtTienMoBan_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000312D0 File Offset: 0x0002F4D0
		private void txtTienMoBan_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000349 RID: 841
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400034A RID: 842
		private List<KhuVuc> lstKhuVuc = new List<KhuVuc>();

		// Token: 0x0400034B RID: 843
		private List<LoaiPhong> lstLoaiPhong = new List<LoaiPhong>();

		// Token: 0x0400034C RID: 844
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400034D RID: 845
		private string strTitle = string.Empty;

		// Token: 0x0400034E RID: 846
		private string strKhuVuc = string.Empty;

		// Token: 0x0400034F RID: 847
		private int iNo = 0;

		// Token: 0x04000350 RID: 848
		private Table tbTable = new Table();

		// Token: 0x04000351 RID: 849
		private string strTenBan = string.Empty;

		// Token: 0x04000352 RID: 850
		private string strTable_Before = string.Empty;
	}
}

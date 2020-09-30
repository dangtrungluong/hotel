using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Hotel.Common;

namespace Hotel
{
	// Token: 0x02000013 RID: 19
	public partial class frmMain : Form
	{
		// Token: 0x06000109 RID: 265 RVA: 0x000192BC File Offset: 0x000174BC
		public frmMain()
		{
			this.InitializeComponent();
			this.btnEditDMMH.Enabled = false;
			this.btnDelDMMH.Enabled = false;
			this.btnChinhSuaDMMH.Enabled = false;
			this.btnXoaDMMH.Enabled = false;
			this.btnAreaChinhSua.Enabled = false;
			this.btnAreaXoa.Enabled = false;
			this.btnTableChinhSua.Enabled = false;
			this.btnTableXoa.Enabled = false;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000182D0 File Offset: 0x000164D0
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000193CC File Offset: 0x000175CC
		private void mnChangPassword_Click(object sender, EventArgs e)
		{
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmChangePassword;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmChangePassword frmChangePassword = new frmChangePassword(2);
			frmChangePassword.Show();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000182D0 File Offset: 0x000164D0
		private void mnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00019454 File Offset: 0x00017654
		private void mnLogout_Click(object sender, EventArgs e)
		{
			base.Hide();
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmLogin;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmLogin frmLogin = new frmLogin();
			frmLogin.Show();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000194D8 File Offset: 0x000176D8
		private void Reload_SuDungDichVu()
		{
			bool flag = this.tabControl1.SelectedTab == this.tabSuDungDichVu;
			if (flag)
			{
				frmMain.lstpAddUserService = new List<AddUserService>();
				bool flag2 = this.tabControlSuDungDichVu.TabCount > 0;
				if (flag2)
				{
					this.tabControlSuDungDichVu.Controls.Clear();
				}
				DataTable dataTable = new DataTable();
				DataTable dataTable2 = new DataTable();
				bool flag3 = File.Exists(CMConstant.strFilePathKhuVuc);
				if (flag3)
				{
					int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhuVuc, ref dataTable);
					bool flag4 = !this.funcCommon.ShowMsg(iErrorCode, "KhuVuc.csv");
					if (flag4)
					{
						return;
					}
					bool flag5 = dataTable.Rows.Count == 0;
					if (flag5)
					{
						return;
					}
				}
				bool flag6 = File.Exists(CMConstant.strFilePathBan);
				if (flag6)
				{
					int iErrorCode2 = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathBan, ref dataTable2);
					bool flag7 = !this.funcCommon.ShowMsg(iErrorCode2, "KhuVuc.csv");
					if (flag7)
					{
						return;
					}
					bool flag8 = dataTable2.Rows.Count == 0;
					if (flag8)
					{
						return;
					}
				}
				List<DisplayArea> list = new List<DisplayArea>();
				DisplayArea displayArea = new DisplayArea();
				displayArea.lstLoaiPhongArea = new List<LoaiPhongArea>();
				LoaiPhongArea loaiPhongArea = new LoaiPhongArea();
				loaiPhongArea.lstRoomArea = new List<RoomArea>();
				RoomArea roomArea = new RoomArea();
				roomArea.lstRoom = new List<List<string>>();
				List<string> list2 = new List<string>();
				string text = string.Empty;
				text = dataTable2.Rows[0]["Khu vực"].ToString();
				list2.Add(text);
				for (int i = 1; i < dataTable2.Rows.Count; i++)
				{
					bool flag9 = !text.Equals(dataTable2.Rows[i]["Khu vực"].ToString());
					if (flag9)
					{
						text = dataTable2.Rows[i]["Khu vực"].ToString();
						bool flag10 = !list2.Contains(text);
						if (flag10)
						{
							list2.Add(text);
						}
					}
				}
				List<string> list3 = new List<string>();
				string text2 = string.Empty;
				text2 = dataTable2.Rows[0]["Nhóm hiển thị"].ToString();
				list3.Add(text2);
				for (int j = 1; j < dataTable2.Rows.Count; j++)
				{
					bool flag11 = !text2.Equals(dataTable2.Rows[j]["Nhóm hiển thị"].ToString());
					if (flag11)
					{
						text2 = dataTable2.Rows[j]["Nhóm hiển thị"].ToString();
						bool flag12 = !list3.Contains(text2);
						if (flag12)
						{
							list3.Add(text2);
						}
					}
				}
				List<List<string>> list4 = new List<List<string>>();
				List<string> list5 = new List<string>();
				for (int k = 0; k < list3.Count; k++)
				{
					list5 = new List<string>();
					for (int l = 0; l < dataTable2.Rows.Count; l++)
					{
						bool flag13 = list3[k].Equals(dataTable2.Rows[l]["Nhóm hiển thị"].ToString());
						if (flag13)
						{
							list5.Add(dataTable2.Rows[l]["Tên bàn"].ToString());
						}
					}
					bool flag14 = list5.Count > 0;
					if (flag14)
					{
						list4.Add(list5);
					}
				}
				list5 = new List<string>();
				foreach (string text3 in list2)
				{
					displayArea = new DisplayArea();
					displayArea.lstLoaiPhongArea = new List<LoaiPhongArea>();
					foreach (string text4 in list3)
					{
						loaiPhongArea = new LoaiPhongArea();
						loaiPhongArea.lstRoomArea = new List<RoomArea>();
						roomArea = new RoomArea();
						roomArea.lstRoom = new List<List<string>>();
						list5 = new List<string>();
						for (int m = 0; m < dataTable2.Rows.Count; m++)
						{
							bool flag15 = text3.Equals(dataTable2.Rows[m]["Khu vực"].ToString());
							if (flag15)
							{
								bool flag16 = text4.Equals(dataTable2.Rows[m]["Nhóm hiển thị"].ToString()) && text3.Equals(dataTable2.Rows[m]["Khu vực"].ToString());
								if (flag16)
								{
									list5.Add(dataTable2.Rows[m]["Tên bàn"].ToString());
									loaiPhongArea.strTypeRoom = text4;
								}
							}
						}
						bool flag17 = list5.Count > 0;
						if (flag17)
						{
							roomArea.lstRoom.Add(list5);
							loaiPhongArea.lstRoomArea.Add(roomArea);
							displayArea.lstLoaiPhongArea.Add(loaiPhongArea);
						}
					}
					displayArea.strKhuVuc = text3;
					list.Add(displayArea);
				}
				for (int n = 0; n < list.Count; n++)
				{
					string text5 = list[n].strKhuVuc.ToString();
					TabPage tabPage = new TabPage();
					tabPage.ResumeLayout(false);
					tabPage.PerformLayout();
					tabPage.UseVisualStyleBackColor = true;
					tabPage.Name = text5;
					tabPage.Text = text5;
					tabPage.BackColor = Color.White;
					tabPage.ForeColor = Color.Black;
					tabPage.Font = new Font("Microsoft Sans Serif", 9f);
					AddUserService addUserService = new AddUserService();
					GroupRoom groupRoom = new GroupRoom();
					List<GroupRoom> list6 = new List<GroupRoom>();
					List<LoaiPhongArea> list7 = new List<LoaiPhongArea>();
					list7 = list[n].lstLoaiPhongArea;
					for (int num = 0; num < list7.Count; num++)
					{
						string strTypeRoom = list7[num].strTypeRoom;
						for (int num2 = 0; num2 < list7[num].lstRoomArea.Count; num2++)
						{
							list4 = list7[num].lstRoomArea[num2].lstRoom;
							groupRoom = new GroupRoom();
							groupRoom.grUserService.Name = "gr" + num2.ToString();
							groupRoom.grUserService.Text = strTypeRoom.ToString();
							int[] array = new int[]
							{
								1,
								8,
								16,
								24,
								32,
								40,
								48,
								56,
								64,
								72,
								80,
								88,
								96,
								104,
								112,
								120
							};
							int count = list4[num2].Count;
							for (int num3 = 0; num3 < count; num3++)
							{
								addUserService = new AddUserService();
								addUserService.pnRoom.Name = "pn" + list4[num2][num3].ToString();
								addUserService.lblNumberRoom.Text = list4[num2][num3].ToString();
								addUserService.lblStatusRoom.Text = string.Empty;
								int num4 = 15;
								int num5 = num3 / 3;
								bool flag18 = num5 < array.Length;
								if (!flag18)
								{
									return;
								}
								addUserService.Location = new Point(num3 % 3 * addUserService.Width + 1, num4 * array[num5]);
								bool flag19 = count % 3 != 0;
								if (flag19)
								{
									groupRoom.grUserService.Height = (count / 3 + 1) * addUserService.pnRoom.Height + 110;
									groupRoom.Height = (count / 3 + 1) * addUserService.pnRoom.Height + 110;
								}
								else
								{
									groupRoom.grUserService.Height = count / 3 * addUserService.pnRoom.Height + 110;
									groupRoom.Height = count / 3 * addUserService.pnRoom.Height + 110;
								}
								groupRoom.grUserService.Controls.Add(addUserService);
								frmMain.lstpAddUserService.Add(addUserService);
							}
							int num6 = 0;
							bool flag20 = num > 0;
							if (flag20)
							{
								for (int num7 = 0; num7 < list6.Count; num7++)
								{
									num6 += list6[num7].Height;
								}
								groupRoom.Location = new Point(0, num6);
							}
							else
							{
								groupRoom.Location = new Point(0, 0);
							}
							list6.Add(groupRoom);
						}
						frmMain.lstpGroupRoom.Add(list6);
						foreach (GroupRoom value in list6)
						{
							tabPage.Controls.Add(value);
						}
					}
					tabPage.AutoScroll = true;
					this.tabControlSuDungDichVu.TabPages.Add(tabPage);
				}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00019EC4 File Offset: 0x000180C4
		private void frmMain_Load(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(CMConstant.strFolderData);
			if (flag)
			{
				try
				{
					Directory.CreateDirectory(CMConstant.strFolderData);
				}
				catch (Exception ex)
				{
					this.funcCommon.Msg(ex.Message, "Lỗi");
					return;
				}
			}
			this.lblSoPhut.Text = string.Empty;
			this.lblSoPhong.Text = string.Empty;
			bool flag2 = File.Exists(CMConstant.strFilePathLoaiSanPham) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiSanPham);
			if (flag2)
			{
				frmMain.lstpLoaiSanPham = this.readwriteData2CSV.ReadLoaiSanPhamFromCSV(CMConstant.strFilePathLoaiSanPham);
			}
			this.Reload_Data();
			this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
			this.tabControl1.TabPages.Remove(this.tabQuanLyBanHang);
			this.tabControl1.TabPages.Remove(this.tabDanhMucMatHang);
			this.tabControl1.TabPages.Remove(this.tabDanhMucBanKhuVuc);
			this.tabControl1.TabPages.Remove(this.tabDanhMucKhachHang);
			this.Reload_SuDungDichVu();
			this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
			this.Reload_DataTable(CMConstant.strFilePathNhomMatHang, "NhomMatHang.csv", this.lstViewMenu, "Tên nhóm mặt hàng");
			this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvViewMenu);
			this.btnThemHang.Enabled = false;
			this.btnGiamHang.Enabled = false;
			bool flag3 = File.Exists(CMConstant.strFilePathKhachHang);
			if (flag3)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachHang, ref this.dtCustomer);
				bool flag4 = !this.funcCommon.ShowMsg(iErrorCode, "KhachHang.csv");
				if (flag4)
				{
					return;
				}
				foreach (object obj in this.dtCustomer.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					this.cbKhachHang.Items.Add(dataRow["Tên khách hàng"].ToString());
				}
			}
			bool flag5 = File.Exists(CMConstant.strFilePathBangGiaDichVu);
			if (flag5)
			{
				int iErrorCode2 = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathBangGiaDichVu, ref this.dtBangGia);
				bool flag6 = !this.funcCommon.ShowMsg(iErrorCode2, "BangGiaDichVu.csv");
				if (flag6)
				{
					return;
				}
				foreach (object obj2 in this.dtBangGia.Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					this.cbBangGia.Items.Add(dataRow2["Tên bảng giá"].ToString());
				}
				bool flag7 = this.cbBangGia.Items.Count > 0;
				if (flag7)
				{
					this.cbBangGia.SelectedIndex = 0;
				}
			}
			bool flag8 = File.Exists(CMConstant.strFilePathKhachMoPhong);
			if (flag8)
			{
				DataTable dataTable = new DataTable();
				int iErrorCode3 = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachMoPhong, ref dataTable);
				bool flag9 = !this.funcCommon.ShowMsg(iErrorCode3, "KhachMoPhong.csv");
				if (flag9)
				{
					return;
				}
				foreach (object obj3 in dataTable.Rows)
				{
					DataRow dataRow3 = (DataRow)obj3;
					int i = 0;
					while (i < frmMain.lstpAddUserService.Count)
					{
						bool flag10 = dataRow3["Phòng"].ToString().Equals(frmMain.lstpAddUserService[i].lblNumberRoom.Text);
						if (flag10)
						{
							frmMain.lstpAddUserService[i].lblStatusRoom.Text = dataRow3["Trạng thái phòng"].ToString();
							bool flag11 = !this.CheckImage(frmMain.lstpAddUserService[i].picRoom, CMConstant.strPathOpenRoom);
							if (flag11)
							{
								return;
							}
							frmMain.lstpAddUserService[i].lblStatusRoom.BackColor = Color.White;
							frmMain.lstpAddUserService[i].lblStatusRoom.ForeColor = Color.Green;
							break;
						}
						else
						{
							i++;
						}
					}
				}
			}
			this.btnTang.Enabled = false;
			this.btnGiam.Enabled = false;
			this.btnDatSL.Enabled = false;
			this.btnDoiGia.Enabled = false;
			this.btnGhiChu.Enabled = false;
			this.btnChietKhau.Enabled = false;
			this.btnGiamHang.Enabled = false;
			this.btnXoa.Enabled = false;
			this.timer1.Enabled = false;
			this.timer2.Enabled = true;
			bool flag12 = AddUserService.iIndexSelected == -1;
			if (flag12)
			{
				this.btnBegin.Enabled = false;
				this.btnFinish.Enabled = false;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001A478 File Offset: 0x00018678
		private void mnUsedServiceOder_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabSuDungDichVu);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001A488 File Offset: 0x00018688
		private void checkExistTabPag(TabPage tabPage)
		{
			bool flag = this.tabControl1.SelectedTab == tabPage;
			if (flag)
			{
				this.funcCommon.Msg("Đang mở tab " + tabPage.Text, "Thông tin");
			}
			else
			{
				foreach (object obj in this.tabControl1.TabPages)
				{
					TabPage tabPage2 = (TabPage)obj;
					bool flag2 = tabPage2.Text.Equals(tabPage.Text);
					if (flag2)
					{
						this.tabControl1.SelectedTab = tabPage;
						return;
					}
				}
				this.funcCommon.addTabPage(this.tabControl1, tabPage);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0001A558 File Offset: 0x00018758
		private void mnQuanLyBanHang_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabQuanLyBanHang);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnThongKeDoanhThu_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnThongKeMatHangBan_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnChiTietHoatDong_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnTongHopKetQuaKinhDoanh_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnTonKho_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnGhiChu_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000214C File Offset: 0x0000034C
		private void mnBaoCao_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000182D0 File Offset: 0x000164D0
		private void mnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001A568 File Offset: 0x00018768
		private void mnListMenu_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmListMenu;
				if (flag)
				{
					form.ShowDialog();
					return;
				}
			}
			frmListMenu frmListMenu = new frmListMenu("Bảng giá");
			frmListMenu.ShowDialog();
			bool flag2 = File.Exists(CMConstant.strFilePathBangGiaDichVu);
			if (flag2)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathBangGiaDichVu, ref this.dtBangGia);
				bool flag3 = !this.funcCommon.ShowMsg(iErrorCode, "BangGiaDichVu.csv");
				if (!flag3)
				{
					bool flag4 = this.cbBangGia.Items.Count > 0;
					if (flag4)
					{
						this.cbBangGia.Items.Clear();
					}
					foreach (object obj2 in this.dtBangGia.Rows)
					{
						DataRow dataRow = (DataRow)obj2;
						this.cbBangGia.Items.Add(dataRow["Tên bảng giá"].ToString());
					}
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001A6DC File Offset: 0x000188DC
		private void mnListItems_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabDanhMucMatHang);
			this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001A6FE File Offset: 0x000188FE
		private void mbListTableArea_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabDanhMucBanKhuVuc);
			this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001A558 File Offset: 0x00018758
		private void mnManagementSales_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabQuanLyBanHang);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001A478 File Offset: 0x00018678
		private void mnUsedService_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabSuDungDichVu);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001A720 File Offset: 0x00018920
		private void btnThemMoiDMMH_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewDMMH.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewDMMH.SelectedItems[0];
				bool flag2 = listViewItem.Text.Equals("Tất cả");
				if (flag2)
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmChooseData;
						if (flag3)
						{
							form.Show();
							this.Reload_Data();
							return;
						}
					}
					frmChooseData frmChooseData = new frmChooseData(frmMain.lstpNhomMatHang, 100);
					frmChooseData.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
					this.Reload_Data();
				}
				else
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmMatHang;
						if (flag4)
						{
							form2.Show();
							return;
						}
					}
					frmMatHang frmMatHang = new frmMatHang(" - THÊM MỚI", listViewItem.Text, frmMain.lstpNhomMatHang);
					frmMatHang.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn 1 loại mặt hàng.", "Lỗi");
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		private void Reload_DataGridView(string strFilePath, DataGridView dataGridView)
		{
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				DataTable dataTable = this.funcCommon.readCSV(strFilePath);
				bool flag2 = dataTable == null;
				if (flag2)
				{
					return;
				}
				bool flag3 = this.tabControl1.SelectedTab == this.tabSuDungDichVu && strFilePath.Equals(CMConstant.strFilePathMatHang);
				if (flag3)
				{
					dataTable.Columns.Remove("ID");
					dataTable.Columns.Remove("Mã sản phẩm");
					dataTable.Columns.Remove("Giá mua");
					dataTable.Columns.Remove("Đơn vị tính mua");
					dataTable.Columns.Remove("Tên nhóm mặt hàng");
					dataTable.Columns.Remove("Loại sản phẩm");
					dataTable.Columns.Remove("Quy đổi");
				}
				dataGridView.DataSource = dataTable;
				bool flag4 = this.tabControl1.SelectedTab != this.tabSuDungDichVu || !strFilePath.Equals(CMConstant.strFilePathMenu);
				if (flag4)
				{
					frmMain.pDataTable = dataTable.Copy();
				}
				bool flag5 = dataGridView != null && dataGridView.Rows.Count > 0;
				if (flag5)
				{
					this.funcCommon.dgvRefresh(ref dataGridView);
				}
			}
			bool flag6 = this.tabControl1.SelectedTab == this.tabDanhMucMatHang;
			if (flag6)
			{
				this.btnChinhSuaDMMH.Enabled = false;
				this.btnXoaDMMH.Enabled = false;
			}
			else
			{
				bool flag7 = this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
				if (flag7)
				{
					this.btnTableChinhSua.Enabled = false;
					this.btnTableXoa.Enabled = false;
				}
				else
				{
					bool flag8 = this.tabControl1.SelectedTab == this.tabDanhMucKhachHang;
					if (flag8)
					{
						this.btnKhachHangEdit.Enabled = false;
						this.btnKhachHangDel.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0001AABC File Offset: 0x00018CBC
		private void btnAddDMMH_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmAddNewGroupItems;
				if (flag)
				{
					form.ShowDialog();
					this.Reload_Data();
					return;
				}
			}
			frmAddNewGroupItems frmAddNewGroupItems = new frmAddNewGroupItems(null, 1, 0);
			frmAddNewGroupItems.ShowDialog();
			this.Reload_Data();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001AB4C File Offset: 0x00018D4C
		private void Reload_DataTable(string strPath, string strFileName, ListView listView, Button btnEdit, Button btnDel)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(CMConstant.strFilePathIcon);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				try
				{
					this.imgLstDMMH.Images.Add(Image.FromFile(fileInfo.FullName));
				}
				catch
				{
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
					return;
				}
			}
			this.imgLstDMMH.ImageSize = new Size(32, 32);
			listView.View = View.SmallIcon;
			listView.SmallImageList = this.imgLstDMMH;
			bool flag = File.Exists(strPath);
			if (flag)
			{
				DataTable dataTable = new DataTable();
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strPath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return;
				}
				bool flag3 = dataTable.Rows.Count > 0;
				if (flag3)
				{
					bool flag4 = listView.Items.Count > 0;
					if (flag4)
					{
						listView.Items.Clear();
					}
					listView.Items.Add("Tất cả", 0);
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						listView.Items.Add(dataRow["Tên nhóm khách hàng"].ToString(), 0);
					}
				}
			}
			btnEdit.Enabled = true;
			btnDel.Enabled = true;
			listView.ContextMenuStrip = this.contextMenuStrip1;
			bool flag5 = listView.SelectedItems.Count == 0;
			if (flag5)
			{
				btnEdit.Enabled = false;
				btnDel.Enabled = false;
				return;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001AD40 File Offset: 0x00018F40
		private void Reload_DataTable(string strPath, string strFileName, ListView listView, string strColumnName)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(CMConstant.strFilePathIcon);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				try
				{
					this.imgLstDMMH.Images.Add(Image.FromFile(fileInfo.FullName));
				}
				catch
				{
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
					return;
				}
			}
			this.imgLstDMMH.ImageSize = new Size(32, 32);
			listView.View = View.SmallIcon;
			listView.SmallImageList = this.imgLstDMMH;
			bool flag = File.Exists(strPath);
			if (!flag)
			{
				return;
			}
			DataTable dataTable = new DataTable();
			int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strPath, ref dataTable);
			bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
			if (flag2)
			{
				return;
			}
			bool flag3 = dataTable.Rows.Count > 0;
			if (flag3)
			{
				bool flag4 = listView.Items.Count > 0;
				if (flag4)
				{
					listView.Items.Clear();
				}
				listView.Items.Add("Tất cả", 0);
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					listView.Items.Add(dataRow[strColumnName].ToString(), 0);
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001AEE8 File Offset: 0x000190E8
		private void Reload_Data()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(CMConstant.strFilePathIcon);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				try
				{
					this.imgLstDMMH.Images.Add(Image.FromFile(fileInfo.FullName));
				}
				catch
				{
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
					return;
				}
			}
			this.imgLstDMMH.ImageSize = new Size(32, 32);
			bool flag = this.tabControl1.SelectedTab == this.tabDanhMucMatHang;
			if (flag)
			{
				this.lstViewDMMH.View = View.SmallIcon;
				this.lstViewDMMH.SmallImageList = this.imgLstDMMH;
				bool flag2 = File.Exists(CMConstant.strFilePathNhomMatHang) && !string.IsNullOrEmpty(CMConstant.strFilePathNhomMatHang);
				if (flag2)
				{
					frmMain.lstpNhomMatHang = this.readwriteData2CSV.ReadNhomMatHangFromCSV(CMConstant.strFilePathNhomMatHang);
					bool flag3 = frmMain.lstpNhomMatHang.Count > 0;
					if (flag3)
					{
						bool flag4 = this.lstViewDMMH.Items.Count > 0;
						if (flag4)
						{
							this.lstViewDMMH.Items.Clear();
						}
						this.lstViewDMMH.Items.Add("Tất cả", 0);
						foreach (NhomMatHang nhomMatHang in frmMain.lstpNhomMatHang)
						{
							this.lstViewDMMH.Items.Add(nhomMatHang.strTenNhomMatHang, 0);
						}
					}
				}
				this.btnEditDMMH.Enabled = true;
				this.btnDelDMMH.Enabled = true;
				this.lstViewDMMH.ContextMenuStrip = this.contextMenuStrip1;
				bool flag5 = this.lstViewDMMH.SelectedItems.Count == 0;
				if (flag5)
				{
					this.btnEditDMMH.Enabled = false;
					this.btnDelDMMH.Enabled = false;
					this.lstViewDMMH.ContextMenuStrip = null;
				}
				return;
			}
			bool flag6 = this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
			if (flag6)
			{
				this.lstViewBanKhuVuc.View = View.SmallIcon;
				this.lstViewBanKhuVuc.SmallImageList = this.imgLstDMMH;
				bool flag7 = File.Exists(CMConstant.strFilePathKhuVuc);
				if (flag7)
				{
					frmMain.lstpKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(CMConstant.strFilePathKhuVuc);
					bool flag8 = frmMain.lstpKhuVuc == null;
					if (flag8)
					{
						this.funcCommon.Msg("Lỗi đọc tập tin KhuVuc.csv", "Lỗi");
						return;
					}
					bool flag9 = frmMain.lstpKhuVuc.Count > 0;
					if (flag9)
					{
						bool flag10 = this.lstViewBanKhuVuc.Items.Count > 0;
						if (flag10)
						{
							this.lstViewBanKhuVuc.Items.Clear();
						}
						this.lstViewBanKhuVuc.Items.Add("Tất cả", 0);
						foreach (KhuVuc khuVuc in frmMain.lstpKhuVuc)
						{
							this.lstViewBanKhuVuc.Items.Add(khuVuc.strTenKhuVuc, 0);
						}
					}
				}
				this.btnAreaChinhSua.Enabled = true;
				this.btnAreaXoa.Enabled = true;
				this.lstViewBanKhuVuc.ContextMenuStrip = this.contextMenuStrip1;
				bool flag11 = this.lstViewBanKhuVuc.SelectedItems.Count == 0;
				if (flag11)
				{
					this.btnAreaChinhSua.Enabled = false;
					this.btnAreaXoa.Enabled = false;
				}
				return;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001B2C8 File Offset: 0x000194C8
		private bool EditItems(ListView listView)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				bool flag2 = this.tabControl1.SelectedTab == this.tabDanhMucMatHang;
				if (flag2)
				{
					bool flag3 = File.Exists(CMConstant.strFilePathNhomMatHang) && !string.IsNullOrEmpty(CMConstant.strFilePathNhomMatHang);
					if (flag3)
					{
						frmMain.lstpNhomMatHang = this.readwriteData2CSV.ReadNhomMatHangFromCSV(CMConstant.strFilePathNhomMatHang);
					}
					NhomMatHang nhomMH = new NhomMatHang();
					foreach (NhomMatHang nhomMatHang in frmMain.lstpNhomMatHang)
					{
						bool flag4 = listViewItem.Text.Equals(nhomMatHang.strTenNhomMatHang);
						if (flag4)
						{
							nhomMH = nhomMatHang;
							break;
						}
					}
					frmAddNewGroupItems frmAddNewGroupItems = new frmAddNewGroupItems(nhomMH, 2, listViewItem.Index);
					frmAddNewGroupItems.ShowDialog();
				}
				else
				{
					bool flag5 = this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
					if (flag5)
					{
						bool flag6 = File.Exists(CMConstant.strFilePathKhuVuc);
						if (flag6)
						{
							frmMain.lstpKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(CMConstant.strFilePathKhuVuc);
						}
						KhuVuc khuvuc = new KhuVuc();
						foreach (KhuVuc khuVuc in frmMain.lstpKhuVuc)
						{
							bool flag7 = listViewItem.Text.Equals(khuVuc.strTenKhuVuc);
							if (flag7)
							{
								khuvuc = khuVuc;
								break;
							}
						}
						frmKhuVuc frmKhuVuc = new frmKhuVuc(khuvuc, " - CHỈNH SỬA", listViewItem.Index);
						frmKhuVuc.ShowDialog();
					}
				}
				this.Reload_Data();
				result = true;
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn loại sản phẩm để chỉnh sửa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001B4CC File Offset: 0x000196CC
		private bool EditItems(string strPath, string strFileName, ListView listView, ref DataRow dataRow, ref int Index)
		{
			Index = -1;
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				DataTable dataTable = new DataTable();
				dataRow = null;
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strPath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					result = false;
				}
				else
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						bool flag3 = listViewItem.Text.Equals(dataRow2["Tên nhóm khách hàng"].ToString());
						if (flag3)
						{
							dataRow = dataRow2;
							break;
						}
					}
					Index = listViewItem.Index;
					result = true;
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn loại sản phẩm để chỉnh sửa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001B5E8 File Offset: 0x000197E8
		private void btnEditDMMH_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmAddNewGroupItems;
				if (flag)
				{
					form.ShowDialog();
					return;
				}
			}
			this.EditItems(this.lstViewDMMH);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0001B664 File Offset: 0x00019864
		private void btnLoadDMMH_Click(object sender, EventArgs e)
		{
			this.Reload_Data();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0001B66E File Offset: 0x0001986E
		private void btnLocDMMH_Click(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderMatHang, this.dgvMenuDMMH, 2, this.txtFilter.Text);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001B690 File Offset: 0x00019890
		private void btnBegin_Click(object sender, EventArgs e)
		{
			bool flag = !this.MoPhong();
			if (!flag)
			{
				this.btnBegin.Enabled = false;
				this.btnFinish.Enabled = true;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001B6C8 File Offset: 0x000198C8
		private void cmEditItem_Click(object sender, EventArgs e)
		{
			bool flag = this.tabControl1.SelectedTab == this.tabDanhMucMatHang;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmAddNewGroupItems;
					if (flag2)
					{
						form.ShowDialog();
						return;
					}
				}
				this.EditItems(this.lstViewDMMH);
			}
			else
			{
				bool flag3 = this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
				if (flag3)
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmKhuVuc;
						if (flag4)
						{
							form2.ShowDialog();
							return;
						}
					}
					this.EditItems(this.lstViewBanKhuVuc);
				}
				else
				{
					bool flag5 = this.tabControl1.SelectedTab == this.tabDanhMucKhachHang;
					if (flag5)
					{
						DataRow dr = null;
						int itemIndex = -1;
						bool flag6 = !this.EditItems(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, ref dr, ref itemIndex);
						if (!flag6)
						{
							frmGroupCustomers frmGroupCustomers = new frmGroupCustomers(dr, " - CHỈNH SỬA", itemIndex);
							frmGroupCustomers.ShowDialog();
							this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
						}
					}
				}
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001B880 File Offset: 0x00019A80
		private void lstViewDMMH_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewDMMH.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewDMMH.SelectedItems[0];
				this.btnEditDMMH.Enabled = false;
				this.btnDelDMMH.Enabled = false;
				this.lstViewDMMH.ContextMenuStrip = null;
				bool flag2 = this.lstViewDMMH.SelectedItems.Count > 0 && listViewItem.Index > 0;
				if (flag2)
				{
					this.btnEditDMMH.Enabled = true;
					this.btnDelDMMH.Enabled = true;
					this.lstViewDMMH.ContextMenuStrip = this.contextMenuStrip1;
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001B93C File Offset: 0x00019B3C
		private void btnDelDMMH_Click(object sender, EventArgs e)
		{
			this.DeletedDataDMMH(CMConstant.strFilePathNhomMatHang, this.lstViewDMMH);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001B954 File Offset: 0x00019B54
		private bool DeletedDataDMMH(string strFilePath, ListView listView)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				string str = "Bạn có muốn xóa tên nhóm mặt hàng [";
				bool flag2 = listViewItem.Index - 1 < 0;
				DialogResult dialogResult;
				if (flag2)
				{
					dialogResult = MessageBox.Show("Bạn có muốn xóa [Tất cả] tên nhóm mặt hàng?", "Xóa tất cả tên nhóm mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					dialogResult = MessageBox.Show(str + listViewItem.Text + "] ?", "Xóa tên nhóm mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				bool flag3 = dialogResult == DialogResult.No;
				if (flag3)
				{
					result = false;
				}
				else
				{
					bool flag4 = File.Exists(strFilePath) && !string.IsNullOrEmpty(strFilePath);
					if (flag4)
					{
						frmMain.lstpNhomMatHang = this.readwriteData2CSV.ReadNhomMatHangFromCSV(strFilePath);
						bool flag5 = listViewItem.Index - 1 < 0;
						if (flag5)
						{
							listView.Items.Clear();
							try
							{
								File.Delete(strFilePath);
							}
							catch
							{
								this.funcCommon.Msg("Không thể xóa ", "Lỗi");
								return false;
							}
							this.btnEditDMMH.Enabled = false;
							this.btnDelDMMH.Enabled = false;
							listView.ContextMenuStrip = null;
							return true;
						}
						frmMain.lstpNhomMatHang.RemoveAt(listViewItem.Index - 1);
						bool flag6 = listView.Items.Count > 0;
						if (flag6)
						{
							listView.Items.Clear();
						}
						try
						{
							File.Delete(strFilePath);
						}
						catch
						{
							this.funcCommon.Msg("Không thể xóa ", "Lỗi");
							return false;
						}
						listView.Items.Add("Tất cả", 0);
						foreach (NhomMatHang nhomMatHang in frmMain.lstpNhomMatHang)
						{
							this.readwriteData2CSV.WriteNhomMatHang2CSV(strFilePath, nhomMatHang);
							listView.Items.Add(nhomMatHang.strTenNhomMatHang, 0);
						}
						this.btnEditDMMH.Enabled = true;
						this.btnDelDMMH.Enabled = true;
						listView.ContextMenuStrip = this.contextMenuStrip1;
						bool flag7 = listView.SelectedItems.Count == 0 || listViewItem.Index - 1 < 0;
						if (flag7)
						{
							this.btnEditDMMH.Enabled = false;
							this.btnDelDMMH.Enabled = false;
							listView.ContextMenuStrip = null;
						}
					}
					result = true;
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn loại sản phẩm để xóa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001BC14 File Offset: 0x00019E14
		private bool DeletedDataBanKV(string strFilePath, ListView listView)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				string str = "Bạn có muốn xóa tên bàn khu vực [";
				bool flag2 = listViewItem.Index - 1 < 0;
				DialogResult dialogResult;
				if (flag2)
				{
					dialogResult = MessageBox.Show("Bạn có muốn xóa [Tất cả] tên bàn khu vực?", "Xóa tất cả tên bàn khu vực", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					dialogResult = MessageBox.Show(str + listViewItem.Text + "] ?", "Xóa tên bàn khu vực", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				bool flag3 = dialogResult == DialogResult.No;
				if (flag3)
				{
					result = false;
				}
				else
				{
					bool flag4 = File.Exists(strFilePath);
					if (flag4)
					{
						frmMain.lstpKhuVuc = this.readwriteData2CSV.ReadKhuVucFromCSV(strFilePath);
						bool flag5 = listViewItem.Index - 1 < 0;
						if (flag5)
						{
							listView.Items.Clear();
							try
							{
								File.Delete(strFilePath);
							}
							catch
							{
								this.funcCommon.Msg("Không thể xóa KhuVuc.csv", "Lỗi");
								return false;
							}
							this.btnAreaChinhSua.Enabled = false;
							this.btnAreaXoa.Enabled = false;
							listView.ContextMenuStrip = null;
							return true;
						}
						frmMain.lstpKhuVuc.RemoveAt(listViewItem.Index - 1);
						bool flag6 = listView.Items.Count > 0;
						if (flag6)
						{
							listView.Items.Clear();
						}
						File.Delete(strFilePath);
						listView.Items.Add("Tất cả", 0);
						foreach (KhuVuc khuVuc in frmMain.lstpKhuVuc)
						{
							this.readwriteData2CSV.WriteKhuVuc2CSV(strFilePath, khuVuc);
							listView.Items.Add(khuVuc.strTenKhuVuc, 0);
						}
						this.btnAreaChinhSua.Enabled = true;
						this.btnAreaXoa.Enabled = true;
						listView.ContextMenuStrip = this.contextMenuStrip1;
						bool flag7 = listView.SelectedItems.Count == 0 || listViewItem.Index - 1 < 0;
						if (flag7)
						{
							this.btnAreaChinhSua.Enabled = false;
							this.btnAreaXoa.Enabled = false;
							listView.ContextMenuStrip = null;
						}
					}
					result = true;
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn bàn khu vực để xóa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001BE98 File Offset: 0x0001A098
		private bool DeletedNhomKhachHang(string strFilePath, string strFileName, ListView listView)
		{
			int num = -1;
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				string str = "Bạn có muốn xóa tên nhóm khách hàng [";
				bool flag2 = listViewItem.Index - 1 < 0;
				DialogResult dialogResult;
				if (flag2)
				{
					dialogResult = MessageBox.Show("Bạn có muốn xóa [Tất cả] tên nhóm khách hàng?", "Xóa tất cả tên nhóm khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					dialogResult = MessageBox.Show(str + listViewItem.Text + "] ?", "Xóa tên nhóm khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				bool flag3 = dialogResult == DialogResult.No;
				if (flag3)
				{
					result = false;
				}
				else
				{
					bool flag4 = File.Exists(strFilePath);
					if (flag4)
					{
						DataTable dataTable = new DataTable();
						int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
						bool flag5 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
						if (flag5)
						{
							return false;
						}
						bool flag6 = dataTable.Rows.Count > 0;
						if (flag6)
						{
							for (int i = 0; i < dataTable.Rows.Count; i++)
							{
								bool flag7 = dataTable.Rows[i][1].Equals(listViewItem.Text);
								if (flag7)
								{
									num = i;
									break;
								}
							}
						}
						bool flag8 = listViewItem.Index - 1 < 0;
						if (flag8)
						{
							listView.Items.Clear();
							try
							{
								File.Delete(strFilePath);
							}
							catch
							{
								this.funcCommon.Msg("Không thể xóa " + strFileName, "Lỗi");
								return false;
							}
							this.btnNhomKhachHangEdit.Enabled = false;
							this.btnNhomKhachHangDel.Enabled = false;
							listView.ContextMenuStrip = null;
							return true;
						}
						bool flag9 = listView.Items.Count > 0;
						if (flag9)
						{
							listView.Items.Clear();
						}
						try
						{
							File.Delete(strFilePath);
						}
						catch
						{
							this.funcCommon.Msg("Không thể xóa " + strFileName, "Lỗi");
							return false;
						}
						listView.Items.Add("Tất cả", 0);
						bool flag10 = num > -1;
						if (flag10)
						{
							dataTable.Rows.RemoveAt(num);
						}
						this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable, 1);
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							listView.Items.Add(dataRow["Tên nhóm khách hàng"].ToString(), 0);
						}
						this.btnNhomKhachHangEdit.Enabled = true;
						this.btnNhomKhachHangDel.Enabled = true;
						listView.ContextMenuStrip = this.contextMenuStrip1;
						bool flag11 = listView.SelectedItems.Count == 0 || listViewItem.Index - 1 < 0;
						if (flag11)
						{
							this.btnNhomKhachHangEdit.Enabled = false;
							this.btnNhomKhachHangDel.Enabled = false;
							listView.ContextMenuStrip = null;
						}
					}
					result = true;
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn nhóm khách hàng để xóa.", "Lỗi");
				result = false;
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0001C208 File Offset: 0x0001A408
		private void cmDel_Click(object sender, EventArgs e)
		{
			bool flag = this.tabControl1.SelectedTab == this.tabDanhMucMatHang;
			if (flag)
			{
				this.DeletedDataDMMH(CMConstant.strFilePathNhomMatHang, this.lstViewDMMH);
			}
			else
			{
				bool flag2 = this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
				if (flag2)
				{
					this.DeletedDataBanKV(CMConstant.strFilePathKhuVuc, this.lstViewBanKhuVuc);
				}
				else
				{
					bool flag3 = this.tabControl1.SelectedTab == this.tabDanhMucKhachHang;
					if (flag3)
					{
						bool flag4 = !this.DeletedNhomKhachHang(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang);
						if (flag4)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		private void cmRefresh_Click(object sender, EventArgs e)
		{
			bool flag = this.tabControl1.SelectedTab == this.tabDanhMucMatHang || this.tabControl1.SelectedTab == this.tabDanhMucBanKhuVuc;
			if (flag)
			{
				this.Reload_Data();
			}
			else
			{
				bool flag2 = this.tabControl1.SelectedTab == this.tabDanhMucKhachHang;
				if (flag2)
				{
					this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0001C330 File Offset: 0x0001A530
		private void btnChinhSuaDMMH_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmMatHang;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmMatHang frmMatHang = new frmMatHang(" - CHỈNH SỬA", this.strTenSP, frmMain.MatHangSelected);
			frmMatHang.ShowDialog();
			this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		private void lstViewDMMH_MouseClick(object sender, MouseEventArgs e)
		{
			this.btnChinhSuaDMMH.Enabled = false;
			this.btnXoaDMMH.Enabled = false;
			bool flag = !this.SelectItem_LoadToDgv(this.lstViewDMMH, CMConstant.strFilePathMatHang, this.dgvMenuDMMH, CMConstant.strHeaderMatHang, 7);
			if (flag)
			{
				this.funcCommon.Msg("Vui lòng chọn loại sản phẩm để chỉnh sửa.", "Lỗi");
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001B66E File Offset: 0x0001986E
		private void txtFilter_TextChanged(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderMatHang, this.dgvMenuDMMH, 2, this.txtFilter.Text);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001C438 File Offset: 0x0001A638
		private void Search(DataTable dtMenu, string[] strHeader, DataGridView dataGridView, int indexItemsNeedtoSearch, string strFilter)
		{
			bool flag = dtMenu.Rows.Count > 0 && dtMenu != null;
			if (flag)
			{
				DataTable dataTable = new DataTable();
				for (int i = 0; i < strHeader.Length; i++)
				{
					dataTable.Columns.Add(strHeader[i].ToString(), typeof(string));
				}
				for (int j = 0; j < dtMenu.Rows.Count; j++)
				{
					DataRow dataRow = dtMenu.Rows[j];
					bool flag2 = dataRow.ItemArray[indexItemsNeedtoSearch].ToString().Equals(strFilter);
					bool flag3 = flag2;
					if (flag3)
					{
						dataTable.Rows.Add(dataRow.ItemArray);
					}
				}
				dataGridView.DataSource = dataTable;
				bool flag4 = dataGridView != null && dataGridView.Rows.Count > 0;
				if (flag4)
				{
					this.funcCommon.dgvRefresh(ref dataGridView);
				}
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001C534 File Offset: 0x0001A734
		private void Filter(string[] strHeader, DataGridView dataGridView, int indexItemsNeedtoSearch, string strFilter)
		{
			bool flag = frmMain.pDataTable.Rows.Count > 0 && frmMain.pDataTable != null;
			if (flag)
			{
				DataTable dataTable = new DataTable();
				for (int i = 0; i < strHeader.Length; i++)
				{
					dataTable.Columns.Add(strHeader[i].ToString(), typeof(string));
				}
				bool flag2 = this.tabControl1.SelectedTab == this.tabSuDungDichVu && strHeader.Equals(CMConstant.strHeaderMatHang);
				if (flag2)
				{
					dataTable.Columns.Remove("ID");
					dataTable.Columns.Remove("Mã sản phẩm");
					dataTable.Columns.Remove("Giá mua");
					dataTable.Columns.Remove("Đơn vị tính mua");
					dataTable.Columns.Remove("Tên nhóm mặt hàng");
					dataTable.Columns.Remove("Loại sản phẩm");
					dataTable.Columns.Remove("Quy đổi");
				}
				for (int j = 0; j < frmMain.pDataTable.Rows.Count; j++)
				{
					DataRow dataRow = frmMain.pDataTable.Rows[j];
					bool flag3 = dataRow.ItemArray[indexItemsNeedtoSearch].ToString().Contains(strFilter);
					bool flag4 = flag3;
					if (flag4)
					{
						dataTable.Rows.Add(dataRow.ItemArray);
					}
				}
				dataGridView.DataSource = dataTable;
				bool flag5 = dataGridView != null && dataGridView.Rows.Count > 0;
				if (flag5)
				{
					this.funcCommon.dgvRefresh(ref dataGridView);
				}
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
		private void dtgMenuDMMH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = this.dgvMenuDMMH.Rows.Count > 0 && this.dgvMenuDMMH != null && e.RowIndex != -1;
			if (flag)
			{
				int index = this.dgvMenuDMMH.CurrentRow.Index;
				this.iIndexSelectedRow = index;
				frmMain.MatHangSelected.iNo = (int)Convert.ToInt16(this.dgvMenuDMMH.Rows[index].Cells[0].Value.ToString());
				frmMain.MatHangSelected.strMaSanPham = this.dgvMenuDMMH.Rows[index].Cells[1].Value.ToString();
				frmMain.MatHangSelected.strTenSanPham = this.dgvMenuDMMH.Rows[index].Cells[2].Value.ToString();
				frmMain.MatHangSelected.iGiaMua = Convert.ToUInt64(this.dgvMenuDMMH.Rows[index].Cells[3].Value.ToString());
				frmMain.MatHangSelected.strDVTMua = this.dgvMenuDMMH.Rows[index].Cells[4].Value.ToString();
				frmMain.MatHangSelected.iGiaBan = Convert.ToUInt64(this.dgvMenuDMMH.Rows[index].Cells[5].Value.ToString());
				frmMain.MatHangSelected.strDVTBan = this.dgvMenuDMMH.Rows[index].Cells[6].Value.ToString();
				frmMain.MatHangSelected.strNhomMatHang = this.dgvMenuDMMH.Rows[index].Cells[7].Value.ToString();
				frmMain.MatHangSelected.strLoaiSanPham = this.dgvMenuDMMH.Rows[index].Cells[8].Value.ToString();
				frmMain.MatHangSelected.iQuyDoi = (int)Convert.ToInt16(this.dgvMenuDMMH.Rows[index].Cells[9].Value.ToString());
				this.strTenSP = frmMain.MatHangSelected.strTenSanPham;
				this.btnChinhSuaDMMH.Enabled = true;
				this.btnXoaDMMH.Enabled = true;
			}
			else
			{
				this.dgvMenuDMMH.ClearSelection();
				this.btnChinhSuaDMMH.Enabled = false;
				this.btnXoaDMMH.Enabled = false;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001C990 File Offset: 0x0001AB90
		private void btnXoaDMMH_Click(object sender, EventArgs e)
		{
			bool flag = !this.DeletedRow(CMConstant.strFilePathMatHang, "MatHang.csv", CMConstant.strHeaderMatHang, this.iIndexSelectedRow);
			if (!flag)
			{
				this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		private void cmCloseTab_Click(object sender, EventArgs e)
		{
			bool flag = this.tabControl1.TabCount > 1;
			if (flag)
			{
				this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001CA18 File Offset: 0x0001AC18
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.tabControl1.ContextMenuStrip = null;
			bool flag = this.tabControl1.TabCount > 1;
			if (flag)
			{
				this.tabControl1.ContextMenuStrip = this.contextMenuStrip2;
			}
			this.Reload_Data();
			this.Reload_SuDungDichVu();
			this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
			bool flag2 = this.tabControl1.SelectedTab == this.tabSuDungDichVu;
			if (flag2)
			{
				bool flag3 = File.Exists(CMConstant.strFilePathKhachHang);
				if (flag3)
				{
					int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachHang, ref this.dtCustomer);
					bool flag4 = !this.funcCommon.ShowMsg(iErrorCode, "KhachHang.csv");
					if (flag4)
					{
						return;
					}
					bool flag5 = this.cbKhachHang.Items.Count > 0;
					if (flag5)
					{
						this.cbKhachHang.Items.Clear();
					}
					foreach (object obj in this.dtCustomer.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						this.cbKhachHang.Items.Add(dataRow["Tên khách hàng"].ToString());
					}
				}
				this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvViewMenu);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		private void mnListTypeRoom_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmListMenu;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmListMenu frmListMenu = new frmListMenu("Loại phòng");
			frmListMenu.Show();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		private void btnAreaThemMoi_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmKhuVuc;
				if (flag)
				{
					form.ShowDialog();
					this.Reload_Data();
					return;
				}
			}
			frmKhuVuc frmKhuVuc = new frmKhuVuc(null, " - THÊM MỚI", 0);
			frmKhuVuc.ShowDialog();
			this.Reload_Data();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001CCC0 File Offset: 0x0001AEC0
		private void lstViewBanKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewBanKhuVuc.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewBanKhuVuc.SelectedItems[0];
				this.btnAreaChinhSua.Enabled = false;
				this.btnAreaXoa.Enabled = false;
				this.lstViewBanKhuVuc.ContextMenuStrip = null;
				this.cmEditItem.Enabled = true;
				bool flag2 = this.lstViewBanKhuVuc.SelectedItems.Count > 0 && listViewItem.Index > 0;
				if (flag2)
				{
					this.btnAreaChinhSua.Enabled = true;
					this.btnAreaXoa.Enabled = true;
					this.lstViewBanKhuVuc.ContextMenuStrip = this.contextMenuStrip1;
				}
				else
				{
					bool flag3 = this.lstViewBanKhuVuc.SelectedItems.Count > 0 && listViewItem.Index == 0;
					if (flag3)
					{
						this.btnAreaXoa.Enabled = true;
						this.lstViewBanKhuVuc.ContextMenuStrip = this.contextMenuStrip1;
						this.cmEditItem.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		private void btnAreaXoa_Click(object sender, EventArgs e)
		{
			bool flag = !this.DeletedDataBanKV(CMConstant.strFilePathKhuVuc, this.lstViewBanKhuVuc);
			if (flag)
			{
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000214C File Offset: 0x0000034C
		private void btnCaiDat_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0001B664 File Offset: 0x00019864
		private void btnAreaTaiDuLieu_Click(object sender, EventArgs e)
		{
			this.Reload_Data();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001CE0C File Offset: 0x0001B00C
		private void btnAreaChinhSua_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmKhuVuc;
				if (flag)
				{
					form.ShowDialog();
					return;
				}
			}
			this.EditItems(this.lstViewBanKhuVuc);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001CE88 File Offset: 0x0001B088
		private void lstViewBanKhuVuc_MouseClick(object sender, MouseEventArgs e)
		{
			this.btnTableChinhSua.Enabled = false;
			this.btnTableXoa.Enabled = false;
			bool flag = !this.SelectItem_LoadToDgv(this.lstViewBanKhuVuc, CMConstant.strFilePathBan, this.dgvBanKhuVuc, CMConstant.strHeaderTable, 3);
			if (flag)
			{
				this.funcCommon.Msg("Vui lòng chọn bàn khu vực để xóa.", "Lỗi");
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		private void dgvBanKhuVuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			frmMain.TableSelected = new Table();
			bool flag = this.dgvBanKhuVuc.Rows.Count > 0 && this.dgvBanKhuVuc != null && e.RowIndex != -1;
			if (flag)
			{
				int index = this.dgvBanKhuVuc.CurrentRow.Index;
				frmMain.TableSelected.iNo = (int)Convert.ToInt16(this.dgvBanKhuVuc.Rows[index].Cells[0].Value.ToString());
				frmMain.TableSelected.strTenBan = this.dgvBanKhuVuc.Rows[index].Cells[1].Value.ToString();
				frmMain.TableSelected.iTienMoBan = Convert.ToUInt64(this.dgvBanKhuVuc.Rows[index].Cells[2].Value.ToString());
				frmMain.TableSelected.strKhuVuc = this.dgvBanKhuVuc.Rows[index].Cells[3].Value.ToString();
				frmMain.TableSelected.strNhomHienThi = this.dgvBanKhuVuc.Rows[index].Cells[4].Value.ToString();
				frmMain.TableSelected.strLoaiPhong = this.dgvBanKhuVuc.Rows[index].Cells[5].Value.ToString();
				frmMain.TableSelected.strGhiChu = this.dgvBanKhuVuc.Rows[index].Cells[6].Value.ToString();
				this.btnTableChinhSua.Enabled = true;
				this.btnTableXoa.Enabled = true;
			}
			else
			{
				this.dgvBanKhuVuc.ClearSelection();
				this.btnTableChinhSua.Enabled = false;
				this.btnTableXoa.Enabled = false;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		private void btnTableThemMoi_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewBanKhuVuc.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewBanKhuVuc.SelectedItems[0];
				bool flag2 = listViewItem.Text.Equals("Tất cả");
				if (flag2)
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmChooseData;
						if (flag3)
						{
							form.Show();
							this.Reload_Data();
							return;
						}
					}
					frmChooseData frmChooseData = new frmChooseData(frmMain.lstpKhuVuc, 101);
					frmChooseData.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
					this.Reload_Data();
				}
				else
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmTable;
						if (flag4)
						{
							form2.Show();
							return;
						}
					}
					frmTable frmTable = new frmTable(" - THÊM MỚI", listViewItem.Text);
					frmTable.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn 1 bàn khu vực.", "Lỗi");
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void btnTableLoc_Click(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderTable, this.dgvBanKhuVuc, 1, this.txtTableLoc.Text);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		private void txtTableLoc_TextChanged(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderTable, this.dgvBanKhuVuc, 1, this.txtTableLoc.Text);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001D2CC File Offset: 0x0001B4CC
		private void btnTableChinhSua_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmTable;
				if (flag)
				{
					form.Show();
					return;
				}
			}
			frmTable frmTable = new frmTable(" - CHỈNH SỬA", frmMain.TableSelected);
			frmTable.ShowDialog();
			this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001D368 File Offset: 0x0001B568
		private void btnTableXoa_Click(object sender, EventArgs e)
		{
			bool flag = !this.DeletedRow(CMConstant.strFilePathBan, "Ban.csv", CMConstant.strHeaderTable, this.iIndexSelectedRow);
			if (!flag)
			{
				this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
		private bool DeletedRow(string strFilePath, string strFileName, string[] strHeader, int index)
		{
			DataTable dataTable = new DataTable();
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return false;
				}
				dataTable.Rows.RemoveAt(index);
				DataTable dataTable2 = new DataTable();
				for (int i = 0; i < strHeader.Length; i++)
				{
					dataTable2.Columns.Add(strHeader[i].ToString(), typeof(string));
				}
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					DataRow dataRow = dataTable.Rows[j];
					dataRow["ID"] = (j + 1).ToString();
					dataTable2.Rows.Add(dataRow.ItemArray);
				}
				this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable2, 2);
			}
			return true;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001D4C4 File Offset: 0x0001B6C4
		private void dgvMenuDMMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvMenuDMMH.Rows.Count > 0 && this.dgvMenuDMMH != null && e.RowIndex != -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmMatHang;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmMatHang frmMatHang = new frmMatHang(" - CHỈNH SỬA", this.strTenSP, frmMain.MatHangSelected);
				frmMatHang.ShowDialog();
				this.Reload_DataGridView(CMConstant.strFilePathMatHang, this.dgvMenuDMMH);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001D598 File Offset: 0x0001B798
		private void dgvBanKhuVuc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvBanKhuVuc.Rows.Count > 0 && this.dgvBanKhuVuc != null && e.RowIndex != -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmTable;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmTable frmTable = new frmTable(" - CHỈNH SỬA", frmMain.TableSelected);
				frmTable.ShowDialog();
				this.Reload_DataGridView(CMConstant.strFilePathBan, this.dgvBanKhuVuc);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001D664 File Offset: 0x0001B864
		private void cmPhongBan_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text = "Phòng bẩn";
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.BackColor = Color.Red;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.ForeColor = Color.Yellow;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		private void cmBaoDon_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text = " Báo dọn ";
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.BackColor = Color.Yellow;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001D75C File Offset: 0x0001B95C
		private void cmDonXong_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text = string.Empty;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.BackColor = Color.White;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		private bool MoPhong()
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				bool flag2 = !this.CheckImage(frmMain.lstpAddUserService[AddUserService.iIndexSelected].picRoom, CMConstant.strPathOpenRoom);
				if (flag2)
				{
					return false;
				}
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text = " Mở phòng";
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.BackColor = Color.White;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.ForeColor = Color.Green;
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag3 = form is frmCommon;
					if (flag3)
					{
						form.Show();
						return false;
					}
				}
				frmCommon frmCommon = new frmCommon("SỐ LƯỢNG KHÁCH", "Nhập số khách", "Số lượng", "1");
				frmCommon.ShowDialog();
				this.txtSoKhachSDDV.Text = frmCommon.txtCommon.Text;
				this.lblSoPhong.Text = frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblNumberRoom.Text;
				DataTable dataTable = new DataTable();
				string[] strHeaderKhachMoPhong = CMConstant.strHeaderKhachMoPhong;
				for (int i = 0; i < strHeaderKhachMoPhong.Length; i++)
				{
					dataTable.Columns.Add(strHeaderKhachMoPhong[i].ToString(), typeof(string));
				}
				DataRow dataRow = dataTable.NewRow();
				string[] array = new string[]
				{
					AddUserService.iIndexSelected.ToString(),
					this.cbKhachHang.Text,
					this.txtDiaChi.Text,
					this.txtDienThoai.Text,
					this.txtCMND.Text,
					this.txtGPLX.Text,
					this.txtHoChieu.Text,
					this.cbBangGia.Text,
					this.dtNgay.Text,
					this.txtSoPhieuSDDV.Text,
					this.txtSoKhachSDDV.Text,
					this.cbNhanVien.Text,
					this.dtBegin.Text,
					this.dtEnd.Text,
					this.lblSoPhong.Text,
					frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text
				};
				for (int j = 0; j < array.Length; j++)
				{
					dataRow[j] = array[j].ToString();
				}
				dataTable.Rows.Add(dataRow);
				this.readwriteData2CSV.WriteDataTable2CSV(CMConstant.strFilePathKhachMoPhong, dataTable, 1);
				this.timer1.Enabled = AddUserService.bEnableTimer;
			}
			return true;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001DB08 File Offset: 0x0001BD08
		private void cmMoPhong_Click(object sender, EventArgs e)
		{
			bool flag = !this.MoPhong();
			if (flag)
			{
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0001DB28 File Offset: 0x0001BD28
		private bool CheckImage(PictureBox pictureBox, string strPath)
		{
			try
			{
				pictureBox.Image = Image.FromFile(strPath);
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0001DB64 File Offset: 0x0001BD64
		private void cmRefreshService_Click(object sender, EventArgs e)
		{
			this.Reload_SuDungDichVu();
			bool flag = File.Exists(CMConstant.strFilePathKhachMoPhong);
			if (flag)
			{
				DataTable dataTable = new DataTable();
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachMoPhong, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, "KhachMoPhong.csv");
				if (flag2)
				{
					return;
				}
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					int i = 0;
					while (i < frmMain.lstpAddUserService.Count)
					{
						bool flag3 = dataRow["Phòng"].ToString().Equals(frmMain.lstpAddUserService[i].lblNumberRoom.Text);
						if (flag3)
						{
							frmMain.lstpAddUserService[i].lblStatusRoom.Text = dataRow["Trạng thái phòng"].ToString();
							bool flag4 = !this.CheckImage(frmMain.lstpAddUserService[i].picRoom, CMConstant.strPathOpenRoom);
							if (flag4)
							{
								return;
							}
							frmMain.lstpAddUserService[i].lblStatusRoom.BackColor = Color.White;
							frmMain.lstpAddUserService[i].lblStatusRoom.ForeColor = Color.Green;
							break;
						}
						else
						{
							i++;
						}
					}
				}
			}
			this.timer1.Enabled = true;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0001DD20 File Offset: 0x0001BF20
		private bool BillRoom(string strFilePath, string strFileName, string[] strHeader, int index)
		{
			DataTable dataTable = new DataTable();
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return false;
				}
				int num = -1;
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					bool flag3 = (int)Convert.ToInt16(dataRow["ID"].ToString()) == index;
					if (flag3)
					{
						num = dataTable.Rows.IndexOf(dataRow);
						break;
					}
				}
				bool flag4 = num > -1;
				if (flag4)
				{
					dataTable.Rows.RemoveAt(num);
				}
				this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable, 2);
			}
			return true;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0001DE24 File Offset: 0x0001C024
		private bool ThanhToan()
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				bool flag2 = string.IsNullOrEmpty(this.cbNhanVien.Text);
				if (flag2)
				{
					this.funcCommon.Msg("Mời nhập nhân viên thanh toán", "Cảnh báo");
					return false;
				}
				this.BillRoom(CMConstant.strFilePathKhachMoPhong, "KhachMoPhong.csv", CMConstant.strHeaderKhachMoPhong, AddUserService.iIndexSelected);
				bool flag3 = !this.CheckImage(frmMain.lstpAddUserService[AddUserService.iIndexSelected].picRoom, CMConstant.strPathCloseRoom);
				if (flag3)
				{
					return false;
				}
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text = string.Empty;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.BackColor = Color.White;
				frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.ForeColor = Color.Black;
				bool flag4 = frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(" Dọn xong") || frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(" Mở phòng") || frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(string.Empty);
				if (flag4)
				{
					bool enabled = true;
					this.lblSoPhut.Enabled = enabled;
					this.cbKhachHang.Enabled = enabled;
					this.txtDiaChi.Enabled = enabled;
					this.txtDienThoai.Enabled = enabled;
					this.txtCMND.Enabled = enabled;
					this.txtGPLX.Enabled = enabled;
					this.txtHoChieu.Enabled = enabled;
					this.dtNgay.CustomFormat = "dd/MM/yyyy";
					this.txtSoPhieuSDDV.Enabled = enabled;
					this.txtSoKhachSDDV.Enabled = enabled;
					this.cbNhanVien.Enabled = enabled;
					this.lblSoPhong.Enabled = enabled;
					this.dtBegin.CustomFormat = "dd/MM/yyyy HH:mm";
					this.dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
					this.lblSoPhut.Text = string.Empty;
					this.cbKhachHang.Text = string.Empty;
					this.txtDiaChi.Text = string.Empty;
					this.txtDienThoai.Text = string.Empty;
					this.txtCMND.Text = string.Empty;
					this.txtGPLX.Text = string.Empty;
					this.txtHoChieu.Text = string.Empty;
					this.txtSoPhieuSDDV.Text = string.Empty;
					this.txtSoKhachSDDV.Text = string.Empty;
					this.cbNhanVien.Text = string.Empty;
					this.lblSoPhong.Text = string.Empty;
				}
				else
				{
					bool enabled2 = false;
					this.lblSoPhut.Enabled = enabled2;
					this.cbKhachHang.Enabled = enabled2;
					this.txtDiaChi.Enabled = enabled2;
					this.txtDienThoai.Enabled = enabled2;
					this.txtCMND.Enabled = enabled2;
					this.txtGPLX.Enabled = enabled2;
					this.txtHoChieu.Enabled = enabled2;
					this.dtNgay.CustomFormat = "__/__/____";
					this.txtSoPhieuSDDV.Enabled = enabled2;
					this.txtSoKhachSDDV.Enabled = enabled2;
					this.cbNhanVien.Enabled = enabled2;
					this.lblSoPhong.Enabled = enabled2;
					this.dtBegin.CustomFormat = "__/__/____ __:__";
					this.dtEnd.CustomFormat = "__/__/____ __:__";
					this.lblSoPhut.Text = string.Empty;
					this.cbKhachHang.Text = string.Empty;
					this.txtDiaChi.Text = string.Empty;
					this.txtDienThoai.Text = string.Empty;
					this.txtCMND.Text = string.Empty;
					this.txtGPLX.Text = string.Empty;
					this.txtHoChieu.Text = string.Empty;
					this.txtSoPhieuSDDV.Text = string.Empty;
					this.txtSoKhachSDDV.Text = string.Empty;
					this.cbNhanVien.Text = string.Empty;
					this.lblSoPhong.Text = string.Empty;
				}
			}
			return true;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		private void cmThanhToan_Click(object sender, EventArgs e)
		{
			bool flag = !this.ThanhToan();
			if (flag)
			{
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
		private void menuStripSuDungDichVu_Opened(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				this.cmMoPhong.Enabled = true;
				this.cmPhongBan.Enabled = true;
				this.cmBaoDon.Enabled = true;
				this.cmDonXong.Enabled = true;
				this.cmThanhToan.Enabled = false;
				this.cmHuyHoaDon.Enabled = false;
				this.cmChuyenPhong.Enabled = false;
				this.cmGopPhong.Enabled = false;
				this.btnBegin.Enabled = true;
				this.btnFinish.Enabled = false;
				bool flag2 = frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(" Mở phòng");
				if (flag2)
				{
					this.cmMoPhong.Enabled = false;
					this.cmPhongBan.Enabled = false;
					this.cmBaoDon.Enabled = false;
					this.cmDonXong.Enabled = false;
					this.cmThanhToan.Enabled = true;
					this.cmHuyHoaDon.Enabled = true;
					this.cmChuyenPhong.Enabled = true;
					this.cmGopPhong.Enabled = true;
					this.btnBegin.Enabled = false;
					this.btnFinish.Enabled = true;
				}
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0001E427 File Offset: 0x0001C627
		private void mnListCustomer_Click(object sender, EventArgs e)
		{
			this.checkExistTabPag(this.tabDanhMucKhachHang);
			this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0001E44C File Offset: 0x0001C64C
		private void btnNhomKhachHangAdd_Click(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmGroupCustomers;
				if (flag)
				{
					form.ShowDialog();
					this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
					return;
				}
			}
			frmGroupCustomers frmGroupCustomers = new frmGroupCustomers(" - THÊM MỚI");
			frmGroupCustomers.ShowDialog();
			this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0001E514 File Offset: 0x0001C714
		private void lstViewNhomKhachHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewNhomKhachHang.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewNhomKhachHang.SelectedItems[0];
				this.btnNhomKhachHangEdit.Enabled = false;
				this.btnNhomKhachHangDel.Enabled = false;
				this.lstViewNhomKhachHang.ContextMenuStrip = null;
				this.cmEditItem.Enabled = true;
				bool flag2 = this.lstViewNhomKhachHang.SelectedItems.Count > 0 && listViewItem.Index > 0;
				if (flag2)
				{
					this.btnNhomKhachHangEdit.Enabled = true;
					this.btnNhomKhachHangDel.Enabled = true;
					this.lstViewNhomKhachHang.ContextMenuStrip = this.contextMenuStrip1;
				}
				else
				{
					bool flag3 = this.lstViewNhomKhachHang.SelectedItems.Count > 0 && listViewItem.Index == 0;
					if (flag3)
					{
						this.btnNhomKhachHangDel.Enabled = true;
						this.lstViewNhomKhachHang.ContextMenuStrip = this.contextMenuStrip1;
						this.cmEditItem.Enabled = false;
					}
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0001E634 File Offset: 0x0001C834
		private void lstViewNhomKhachHang_MouseClick(object sender, MouseEventArgs e)
		{
			this.btnKhachHangEdit.Enabled = false;
			this.btnKhachHangDel.Enabled = false;
			bool flag = !this.SelectItem_LoadToDgv(this.lstViewNhomKhachHang, CMConstant.strFilePathKhachHang, this.dgvKhachHang, CMConstant.strHeaderKhachHang, 14);
			if (flag)
			{
				this.funcCommon.Msg("Vui lòng chọn nhóm khách hàng để xóa.", "Lỗi");
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0001E69C File Offset: 0x0001C89C
		private bool SelectItem_LoadToDgv(ListView listView, string strPath, DataGridView dataGridView, string[] strHeader, int index)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			bool result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				bool flag2 = File.Exists(strPath);
				if (flag2)
				{
					DataTable dataTable = this.funcCommon.readCSV(strPath);
					bool flag3 = dataTable == null;
					if (flag3)
					{
						return false;
					}
					bool flag4 = listViewItem.Text.Equals("Tất cả");
					if (flag4)
					{
						bool flag5 = this.tabControl1.SelectedTab == this.tabSuDungDichVu && strHeader.Equals(CMConstant.strHeaderMatHang);
						if (flag5)
						{
							dataTable.Columns.Remove("ID");
							dataTable.Columns.Remove("Mã sản phẩm");
							dataTable.Columns.Remove("Giá mua");
							dataTable.Columns.Remove("Đơn vị tính mua");
							dataTable.Columns.Remove("Tên nhóm mặt hàng");
							dataTable.Columns.Remove("Loại sản phẩm");
							dataTable.Columns.Remove("Quy đổi");
						}
						dataGridView.DataSource = dataTable;
						bool flag6 = this.tabControl1.SelectedTab != this.tabSuDungDichVu || !strHeader.Equals(CMConstant.strHeaderMenu);
						if (flag6)
						{
							frmMain.pDataTable = dataTable.Copy();
						}
						bool flag7 = dataGridView != null && dataGridView.Rows.Count > 0;
						if (flag7)
						{
							this.funcCommon.dgvRefresh(ref dataGridView);
						}
					}
					else
					{
						try
						{
							bool flag8 = dataGridView.Rows.Count > 0;
							if (flag8)
							{
								dataGridView.Rows.Clear();
								dataGridView.DataSource = null;
								dataGridView.Columns.Clear();
							}
						}
						catch
						{
						}
						DataTable dataTable2 = new DataTable();
						for (int i = 0; i < strHeader.Length; i++)
						{
							dataTable2.Columns.Add(strHeader[i].ToString(), typeof(string));
						}
						for (int j = 0; j < dataTable.Rows.Count; j++)
						{
							DataRow dataRow = dataTable.Rows[j];
							bool flag9 = dataRow.ItemArray[index].ToString().Equals(listViewItem.Text);
							if (flag9)
							{
								dataTable2.Rows.Add(dataRow.ItemArray);
							}
						}
						bool flag10 = this.tabControl1.SelectedTab == this.tabSuDungDichVu && strHeader.Equals(CMConstant.strHeaderMatHang);
						if (flag10)
						{
							dataTable2.Columns.Remove("ID");
							dataTable2.Columns.Remove("Mã sản phẩm");
							dataTable2.Columns.Remove("Giá mua");
							dataTable2.Columns.Remove("Đơn vị tính mua");
							dataTable2.Columns.Remove("Tên nhóm mặt hàng");
							dataTable2.Columns.Remove("Loại sản phẩm");
							dataTable2.Columns.Remove("Quy đổi");
						}
						dataGridView.DataSource = dataTable2;
						bool flag11 = this.tabControl1.SelectedTab != this.tabSuDungDichVu || !strHeader.Equals(CMConstant.strHeaderMenu);
						if (flag11)
						{
							frmMain.pDataTable = dataTable.Copy();
						}
						bool flag12 = dataGridView != null && dataGridView.Rows.Count > 0;
						if (flag12)
						{
							this.funcCommon.dgvRefresh(ref dataGridView);
						}
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001EA5C File Offset: 0x0001CC5C
		private void btnNhomKhachHangEdit_Click(object sender, EventArgs e)
		{
			DataRow dr = null;
			int itemIndex = -1;
			bool flag = !this.EditItems(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, ref dr, ref itemIndex);
			if (!flag)
			{
				frmGroupCustomers frmGroupCustomers = new frmGroupCustomers(dr, " - CHỈNH SỬA", itemIndex);
				frmGroupCustomers.ShowDialog();
				this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001EACC File Offset: 0x0001CCCC
		private void btnNhomKhachHangDel_Click(object sender, EventArgs e)
		{
			bool flag = !this.DeletedNhomKhachHang(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang);
			if (flag)
			{
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001EAFA File Offset: 0x0001CCFA
		private void btnNhomKhachHangLoad_Click(object sender, EventArgs e)
		{
			this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000214C File Offset: 0x0000034C
		private void btnNhomKhachHangSetting_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001EB20 File Offset: 0x0001CD20
		private void btnKhachHangAdd_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewNhomKhachHang.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewNhomKhachHang.SelectedItems[0];
				bool flag2 = listViewItem.Text.Equals("Tất cả");
				if (flag2)
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmChooseData;
						if (flag3)
						{
							form.Show();
							this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
							return;
						}
					}
					DataTable dt = new DataTable();
					bool flag4 = File.Exists(CMConstant.strFilePathNhomKhachHang);
					if (flag4)
					{
						int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathNhomKhachHang, ref dt);
						bool flag5 = !this.funcCommon.ShowMsg(iErrorCode, "NhomKhachHang.csv");
						if (flag5)
						{
							return;
						}
					}
					frmChooseData frmChooseData = new frmChooseData(dt, 102);
					frmChooseData.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
					this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
				}
				else
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag6 = form2 is frmCustomer;
						if (flag6)
						{
							form2.Show();
							return;
						}
					}
					frmCustomer frmCustomer = new frmCustomer(" - THÊM MỚI", listViewItem.Text);
					frmCustomer.ShowDialog();
					this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn 1 nhóm khách hàng.", "Lỗi");
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001ED58 File Offset: 0x0001CF58
		private void lstViewDMMH_ItemActivate(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmAddNewGroupItems;
				if (flag)
				{
					form.ShowDialog();
					return;
				}
			}
			this.EditItems(this.lstViewDMMH);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
		private void lstViewBanKhuVuc_ItemActivate(object sender, EventArgs e)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				bool flag = form is frmKhuVuc;
				if (flag)
				{
					form.ShowDialog();
					return;
				}
			}
			this.EditItems(this.lstViewBanKhuVuc);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001EE50 File Offset: 0x0001D050
		private void lstViewNhomKhachHang_ItemActivate(object sender, EventArgs e)
		{
			DataRow dr = null;
			int itemIndex = -1;
			bool flag = !this.EditItems(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, ref dr, ref itemIndex);
			if (!flag)
			{
				frmGroupCustomers frmGroupCustomers = new frmGroupCustomers(dr, " - CHỈNH SỬA", itemIndex);
				frmGroupCustomers.ShowDialog();
				this.Reload_DataTable(CMConstant.strFilePathNhomKhachHang, "NhomKhachHang.csv", this.lstViewNhomKhachHang, this.btnNhomKhachHangEdit, this.btnNhomKhachHangDel);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
		private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				bool flag = this.dgvKhachHang.Rows.Count > 0 && this.dgvKhachHang != null && e.RowIndex != -1;
				if (flag)
				{
					int index = this.dgvKhachHang.CurrentRow.Index;
					this.iIndexSelectedRow = index;
					string[] strHeaderKhachHang = CMConstant.strHeaderKhachHang;
					for (int i = 0; i < strHeaderKhachHang.Length; i++)
					{
						dataTable.Columns.Add(strHeaderKhachHang[i].ToString(), typeof(string));
					}
					this.dtRow = dataTable.NewRow();
					string[] array = new string[]
					{
						this.dgvKhachHang.Rows[index].Cells[0].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[1].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[2].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[3].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[4].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[5].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[6].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[7].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[8].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[9].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[10].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[11].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[12].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[13].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[14].Value.ToString(),
						this.dgvKhachHang.Rows[index].Cells[15].Value.ToString()
					};
					for (int j = 0; j < array.Length; j++)
					{
						this.dtRow[j] = array[j].ToString();
					}
					this.btnKhachHangEdit.Enabled = true;
					this.btnKhachHangDel.Enabled = true;
				}
				else
				{
					this.dgvKhachHang.ClearSelection();
					this.btnKhachHangEdit.Enabled = false;
					this.btnKhachHangDel.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				this.funcCommon.Msg(ex.Message, "Lỗi");
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001F2C8 File Offset: 0x0001D4C8
		private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgvKhachHang.Rows.Count > 0 && this.dgvKhachHang != null && e.RowIndex != -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmCustomer;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmCustomer frmCustomer = new frmCustomer(" - CHỈNH SỬA", this.dtRow);
				frmCustomer.ShowDialog();
				this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001F398 File Offset: 0x0001D598
		private void btnKhachHangEdit_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvKhachHang.Rows.Count > 0 && this.dgvKhachHang != null;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmCustomer;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmCustomer frmCustomer = new frmCustomer(" - CHỈNH SỬA", this.dtRow);
				frmCustomer.ShowDialog();
				this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001F45C File Offset: 0x0001D65C
		private void btnKhachHangDel_Click(object sender, EventArgs e)
		{
			bool flag = !this.DeletedRow(CMConstant.strFilePathKhachHang, "KhachHang.csv", CMConstant.strHeaderKhachHang, this.iIndexSelectedRow);
			if (!flag)
			{
				this.Reload_DataGridView(CMConstant.strFilePathKhachHang, this.dgvKhachHang);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001F4A1 File Offset: 0x0001D6A1
		private void txtKhachHangFilter_TextChanged(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderKhachHang, this.dgvKhachHang, 2, this.txtKhachHangFilter.Text);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001F4A1 File Offset: 0x0001D6A1
		private void btnKhachHangFilter_Click(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderKhachHang, this.dgvKhachHang, 2, this.txtKhachHangFilter.Text);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (object obj in this.dtCustomer.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				bool flag = this.cbKhachHang.Text.Equals(dataRow["Tên khách hàng"].ToString());
				if (flag)
				{
					this.txtCMND.Text = dataRow["Số CMND"].ToString();
					this.txtHoChieu.Text = dataRow["Hộ chiếu"].ToString();
					this.txtGPLX.Text = dataRow["GPLX"].ToString();
					this.txtDiaChi.Text = dataRow["Địa chỉ"].ToString();
					this.txtDienThoai.Text = dataRow["Điện thoại"].ToString();
					this.txtSoPhieuSDDV.Text = dataRow["Mã thẻ từ"].ToString();
					break;
				}
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
		private void btnFinish_Click(object sender, EventArgs e)
		{
			bool flag = !this.ThanhToan();
			if (!flag)
			{
				this.btnBegin.Enabled = true;
				this.btnFinish.Enabled = false;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001F630 File Offset: 0x0001D830
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				this.dtNgay.CustomFormat = "dd/MM/yyyy";
				this.dtBegin.CustomFormat = "dd/MM/yyyy HH:mm";
				this.dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
				this.timer1.Enabled = true;
				DataTable dataTable = new DataTable();
				bool flag2 = File.Exists(CMConstant.strFilePathKhachMoPhong);
				if (flag2)
				{
					int num = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathKhachMoPhong, ref dataTable);
					bool flag3 = num != 1;
					if (flag3)
					{
						this.timer1.Enabled = false;
					}
					bool flag4 = !this.funcCommon.ShowMsg(num, "KhachMoPhong.csv");
					if (flag4)
					{
						return;
					}
				}
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					bool flag5 = (int)Convert.ToInt16(dataRow["ID"].ToString()) == AddUserService.iIndexSelected;
					if (flag5)
					{
						bool flag6 = !string.IsNullOrEmpty(dataRow["Tên khách hàng"].ToString());
						if (flag6)
						{
							this.cbKhachHang.Text = dataRow["Tên khách hàng"].ToString();
						}
						bool flag7 = !string.IsNullOrEmpty(dataRow["Địa chỉ"].ToString());
						if (flag7)
						{
							this.txtDiaChi.Text = dataRow["Địa chỉ"].ToString();
						}
						bool flag8 = !string.IsNullOrEmpty(dataRow["Điện thoại"].ToString());
						if (flag8)
						{
							this.txtDienThoai.Text = dataRow["Điện thoại"].ToString();
						}
						bool flag9 = !string.IsNullOrEmpty(dataRow["Số CMND"].ToString());
						if (flag9)
						{
							this.txtCMND.Text = dataRow["Số CMND"].ToString();
						}
						bool flag10 = !string.IsNullOrEmpty(dataRow["GPLX"].ToString());
						if (flag10)
						{
							this.txtGPLX.Text = dataRow["GPLX"].ToString();
						}
						bool flag11 = !string.IsNullOrEmpty(dataRow["Hộ chiếu"].ToString());
						if (flag11)
						{
							this.txtHoChieu.Text = dataRow["Hộ chiếu"].ToString();
						}
						try
						{
							string[] array = dataRow["Ngày"].ToString().Split(new char[]
							{
								'/'
							});
							DateTime value = new DateTime((int)Convert.ToInt16(array[2]), (int)Convert.ToInt16(array[1]), (int)Convert.ToInt16(array[0]));
							this.dtNgay.Value = value;
						}
						catch
						{
							this.dtNgay.CustomFormat = "__/__/____";
						}
						bool flag12 = !string.IsNullOrEmpty(dataRow["Mã thẻ từ"].ToString());
						if (flag12)
						{
							this.txtSoPhieuSDDV.Text = dataRow["Mã thẻ từ"].ToString();
						}
						bool flag13 = !string.IsNullOrEmpty(dataRow["Số khách"].ToString());
						if (flag13)
						{
							this.txtSoKhachSDDV.Text = dataRow["Số khách"].ToString();
						}
						bool flag14 = !string.IsNullOrEmpty(dataRow["Nhân viên"].ToString());
						if (flag14)
						{
							this.cbNhanVien.Text = dataRow["Nhân viên"].ToString();
						}
						this.lblSoPhong.Text = dataRow["Phòng"].ToString();
						int year = DateTime.Now.Year;
						int month = DateTime.Now.Month;
						int day = DateTime.Now.Day;
						int hour = DateTime.Now.Hour;
						int minute = DateTime.Now.Minute;
						int year2 = 0;
						int month2 = 0;
						int day2 = 0;
						int hour2 = 0;
						int minute2 = 0;
						int year3 = 0;
						int month3 = 0;
						int day3 = 0;
						int hour3 = 0;
						int minute3 = 0;
						string strdateTime = dataRow["Ngày bắt đầu"].ToString();
						string strdateTime2 = dataRow["Ngày kết thúc"].ToString();
						bool flag15 = !this.ParseTime(strdateTime, ref year2, ref month2, ref day2, ref hour2, ref minute2);
						if (flag15)
						{
							this.lblSoPhut.Text = string.Empty;
							return;
						}
						DateTime dateTime = new DateTime(year, month, day, hour, minute, 0);
						DateTime value2 = new DateTime(year2, month2, day2, hour2, minute2, 0);
						bool flag16 = !this.ParseTime(strdateTime2, ref year3, ref month3, ref day3, ref hour3, ref minute3);
						if (flag16)
						{
							this.dtEnd.CustomFormat = "__/__/____ __:__";
							return;
						}
						DateTime value3 = new DateTime(year3, month3, day3, hour3, minute3, 0);
						this.dtBegin.Value = value2;
						this.dtEnd.Value = value3;
						TimeSpan timeSpan = dateTime.Subtract(value2);
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						bool flag17 = !this.ParseDateTime(timeSpan.ToString(), ref num2, ref num3, ref num4);
						if (flag17)
						{
							return;
						}
						string text = string.Empty;
						bool flag18 = num2 == 0;
						if (flag18)
						{
							bool flag19 = num3 == 0;
							if (flag19)
							{
								text = num4.ToString() + " Phút";
							}
							else
							{
								text = num3.ToString() + " Giờ " + num4.ToString() + " Phút";
							}
						}
						else
						{
							text = num2.ToString() + " Ngày ";
							bool flag20 = num3 == 0;
							if (flag20)
							{
								text = text + num4.ToString() + " Phút";
							}
							else
							{
								text = string.Concat(new string[]
								{
									text,
									num3.ToString(),
									" Giờ ",
									num4.ToString(),
									" Phút"
								});
							}
						}
						this.lblSoPhut.Text = text;
						this.lblSoPhut.ForeColor = Color.Blue;
						DataTable dataTable2 = new DataTable();
						bool flag21 = File.Exists(CMConstant.strFilePathMenu);
						if (flag21)
						{
							int num5 = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathMenu, ref dataTable2);
							bool flag22 = num5 != 1;
							if (flag22)
							{
								this.timer1.Enabled = false;
							}
							bool flag23 = !this.funcCommon.ShowMsg(num5, "Menu.csv");
							if (flag23)
							{
								return;
							}
							foreach (object obj2 in dataTable2.Rows)
							{
								DataRow dataRow2 = (DataRow)obj2;
								this.Search(dataTable2, CMConstant.strHeaderMenu, this.dgvMenu, 8, dataRow["Phòng"].ToString());
								this.funcCommon.dgvRefresh(ref this.dgvMenu);
								bool flag24 = dataRow["Phòng"].ToString().Equals(dataRow2["Phòng"].ToString());
								if (flag24)
								{
									break;
								}
							}
						}
						this.btnBegin.Enabled = false;
						this.btnFinish.Enabled = true;
						break;
					}
					else
					{
						bool flag25 = frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(" Dọn xong") || frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(" Mở phòng") || frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblStatusRoom.Text.Equals(string.Empty);
						if (flag25)
						{
							bool enabled = true;
							this.lblSoPhut.Enabled = enabled;
							this.cbKhachHang.Enabled = enabled;
							this.txtDiaChi.Enabled = enabled;
							this.txtDienThoai.Enabled = enabled;
							this.txtCMND.Enabled = enabled;
							this.txtGPLX.Enabled = enabled;
							this.txtHoChieu.Enabled = enabled;
							this.dtNgay.CustomFormat = "dd/MM/yyyy";
							this.txtSoPhieuSDDV.Enabled = enabled;
							this.txtSoKhachSDDV.Enabled = enabled;
							this.cbNhanVien.Enabled = enabled;
							this.lblSoPhong.Enabled = enabled;
							this.dtBegin.CustomFormat = "dd/MM/yyyy HH:mm";
							this.dtEnd.CustomFormat = "dd/MM/yyyy HH:mm";
							this.lblSoPhut.Text = string.Empty;
							this.lblSoPhong.Text = string.Empty;
							this.btnBegin.Enabled = true;
							this.btnFinish.Enabled = false;
							DataTable dataSource = new DataTable();
							this.dgvMenu.DataSource = dataSource;
							this.funcCommon.dgvRefresh(ref this.dgvMenu);
						}
						else
						{
							bool enabled2 = false;
							this.lblSoPhut.Enabled = enabled2;
							this.cbKhachHang.Enabled = enabled2;
							this.txtDiaChi.Enabled = enabled2;
							this.txtDienThoai.Enabled = enabled2;
							this.txtCMND.Enabled = enabled2;
							this.txtGPLX.Enabled = enabled2;
							this.txtHoChieu.Enabled = enabled2;
							this.dtNgay.CustomFormat = "__/__/____";
							this.txtSoPhieuSDDV.Enabled = enabled2;
							this.txtSoKhachSDDV.Enabled = enabled2;
							this.cbNhanVien.Enabled = enabled2;
							this.lblSoPhong.Enabled = enabled2;
							this.dtBegin.CustomFormat = "__/__/____ __:__";
							this.dtEnd.CustomFormat = "__/__/____ __:__";
							this.lblSoPhut.Text = string.Empty;
							this.cbKhachHang.Text = string.Empty;
							this.txtDiaChi.Text = string.Empty;
							this.txtDienThoai.Text = string.Empty;
							this.txtCMND.Text = string.Empty;
							this.txtGPLX.Text = string.Empty;
							this.txtHoChieu.Text = string.Empty;
							this.txtSoPhieuSDDV.Text = string.Empty;
							this.txtSoKhachSDDV.Text = string.Empty;
							this.cbNhanVien.Text = string.Empty;
							this.lblSoPhong.Text = string.Empty;
							this.btnBegin.Enabled = true;
							this.btnFinish.Enabled = false;
							DataTable dataSource2 = new DataTable();
							this.dgvMenu.DataSource = dataSource2;
							this.funcCommon.dgvRefresh(ref this.dgvMenu);
						}
					}
				}
				AddUserService.bEnableTimer = false;
			}
			else
			{
				this.btnBegin.Enabled = true;
				this.btnFinish.Enabled = false;
				DataTable dataSource3 = new DataTable();
				this.dgvMenu.DataSource = dataSource3;
				this.funcCommon.dgvRefresh(ref this.dgvMenu);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000201E0 File Offset: 0x0001E3E0
		private bool ParseTime(string strdateTime, ref int iyear, ref int imonth, ref int iday, ref int ihour, ref int imin)
		{
			try
			{
				string[] array = strdateTime.Split(new char[]
				{
					'/'
				});
				string[] array2 = array[2].ToString().Split(new char[]
				{
					' '
				});
				string[] array3 = array2[1].ToString().Split(new char[]
				{
					':'
				});
				iyear = (int)Convert.ToInt16(array2[0]);
				imonth = (int)Convert.ToInt16(array[1]);
				iday = (int)Convert.ToInt16(array[0]);
				ihour = (int)Convert.ToInt16(array3[0]);
				imin = (int)Convert.ToInt16(array3[1]);
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00020288 File Offset: 0x0001E488
		private bool ParseDateTime(string strdateTime, ref int iday, ref int ihour, ref int imin)
		{
			try
			{
				bool flag = strdateTime.Contains('.');
				if (flag)
				{
					string[] array = strdateTime.Split(new char[]
					{
						'.'
					});
					string[] array2 = array[1].ToString().Split(new char[]
					{
						':'
					});
					iday = (int)Convert.ToInt16(array[0]);
					ihour = (int)Convert.ToInt16(array2[0]);
					imin = (int)Convert.ToInt16(array2[1]);
				}
				else
				{
					string[] array3 = strdateTime.ToString().Split(new char[]
					{
						':'
					});
					ihour = (int)Convert.ToInt16(array3[0]);
					imin = (int)Convert.ToInt16(array3[1]);
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00020340 File Offset: 0x0001E540
		private void lstViewMenu_MouseClick(object sender, MouseEventArgs e)
		{
			bool flag = !this.SelectItem_LoadToDgv(this.lstViewMenu, CMConstant.strFilePathMatHang, this.dgvViewMenu, CMConstant.strHeaderMatHang, 7);
			if (flag)
			{
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00020375 File Offset: 0x0001E575
		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			this.Filter(CMConstant.strHeaderMatHang, this.dgvViewMenu, 0, this.txtTimKiem.Text);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00020398 File Offset: 0x0001E598
		private int GetValueQty(string strFilePath, string strFileName, string strName, string strPhong)
		{
			int result = -1;
			bool flag = File.Exists(CMConstant.strFilePathMenu);
			if (flag)
			{
				DataTable dataTable = new DataTable();
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return -1;
				}
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					bool flag3 = dataRow["Mặt hàng"].ToString().Equals(strName) && strPhong.Equals(dataRow["Phòng"].ToString());
					if (flag3)
					{
						result = Convert.ToInt32(dataRow["Số lượng"].ToString());
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0002049C File Offset: 0x0001E69C
		private int CheckName(string strFilePath, string strFileName, string strName, string strPhong, ref int iIndex)
		{
			bool flag = File.Exists(CMConstant.strFilePathMenu);
			if (flag)
			{
				DataTable dataTable = new DataTable();
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return -1;
				}
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					bool flag3 = dataRow["Mặt hàng"].ToString().Equals(strName) && dataRow["Phòng"].ToString().Equals(strPhong);
					if (flag3)
					{
						iIndex = dataTable.Rows.IndexOf(dataRow);
						return 200;
					}
				}
			}
			return 201;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000205A0 File Offset: 0x0001E7A0
		private void btnThemHang_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				DataTable dataTable = new DataTable();
				string[] strHeaderMenu = CMConstant.strHeaderMenu;
				for (int i = 0; i < strHeaderMenu.Length; i++)
				{
					dataTable.Columns.Add(strHeaderMenu[i].ToString(), typeof(string));
				}
				DataRow dataRow = dataTable.NewRow();
				string text = frmMain.lstpAddUserService[AddUserService.iIndexSelected].lblNumberRoom.Text;
				this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu[0].ToString(), text);
				bool flag2 = this.iSoluong > -1;
				if (flag2)
				{
					this.iSoluong += (int)Convert.ToInt16(this.cbSoLuong.Text);
				}
				else
				{
					this.iSoluong = (int)Convert.ToInt16(this.cbSoLuong.Text);
				}
				this.iThanhTien = Convert.ToUInt64(this.strDataMenu[1].ToString()) * (ulong)((ushort)this.iSoluong);
				int iIndex = -1;
				int num = this.CheckName(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu[0].ToString(), text, ref iIndex);
				bool flag3 = num == 200;
				if (flag3)
				{
					string[] strData = new string[]
					{
						this.strDataMenu[0].ToString(),
						this.strDataMenu[2].ToString(),
						DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
						this.iSoluong.ToString(),
						this.strDataMenu[1].ToString(),
						this.iThanhTien.ToString(),
						this.strChietKhau,
						this.strGhiChu,
						text
					};
					bool flag4 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, iIndex);
					if (flag4)
					{
						return;
					}
				}
				else
				{
					string[] array = new string[]
					{
						this.strDataMenu[0].ToString(),
						this.strDataMenu[2].ToString(),
						DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
						this.iSoluong.ToString(),
						this.strDataMenu[1].ToString(),
						this.iThanhTien.ToString(),
						this.strChietKhau,
						this.strGhiChu,
						text
					};
					for (int j = 0; j < array.Length; j++)
					{
						dataRow[j] = array[j].ToString();
					}
					dataTable.Rows.Add(dataRow);
					this.readwriteData2CSV.WriteDataTable2CSV(CMConstant.strFilePathMenu, dataTable, 1);
				}
				this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
				AddUserService.bEnableTimer = true;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00020884 File Offset: 0x0001EA84
		private void dgvViewMenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				try
				{
					bool flag2 = this.dgvViewMenu.Rows.Count > 0 && this.dgvViewMenu != null && e.RowIndex != -1;
					if (flag2)
					{
						int index = this.dgvViewMenu.CurrentRow.Index;
						this.strDataMenu = new string[]
						{
							this.dgvViewMenu.Rows[index].Cells[0].Value.ToString(),
							this.dgvViewMenu.Rows[index].Cells[1].Value.ToString(),
							this.dgvViewMenu.Rows[index].Cells[2].Value.ToString()
						};
						this.btnThemHang.Enabled = true;
					}
					else
					{
						this.dgvViewMenu.ClearSelection();
						this.btnThemHang.Enabled = false;
					}
				}
				catch (Exception ex)
				{
					this.funcCommon.Msg(ex.Message, "Lỗi");
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000209CC File Offset: 0x0001EBCC
		private bool EditMenu(string strFilePath, string strFileName, string[] strData, int iIndex)
		{
			DataTable dataTable = new DataTable();
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return false;
				}
				bool flag3 = iIndex > -1;
				if (flag3)
				{
					dataTable.Rows.RemoveAt(iIndex);
				}
				DataRow dataRow = dataTable.NewRow();
				for (int i = 0; i < strData.Length; i++)
				{
					dataRow[i] = strData[i].ToString();
				}
				dataTable.Rows.InsertAt(dataRow, iIndex);
				this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable, 2);
			}
			return true;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00020A90 File Offset: 0x0001EC90
		private bool DeleteMenu(string strFilePath, string strFileName, string[] strData, int iIndex)
		{
			DataTable dataTable = new DataTable();
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(strFilePath, ref dataTable);
				bool flag2 = !this.funcCommon.ShowMsg(iErrorCode, strFileName);
				if (flag2)
				{
					return false;
				}
				bool flag3 = iIndex > -1;
				if (flag3)
				{
					dataTable.Rows.RemoveAt(iIndex);
				}
				this.readwriteData2CSV.WriteDataTable2CSV(strFilePath, dataTable, 2);
			}
			return true;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00020B0C File Offset: 0x0001ED0C
		private void btnGhiChu_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmGhiChu;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmGhiChu frmGhiChu = new frmGhiChu();
				frmGhiChu.ShowDialog();
				this.strGhiChu = frmGhiChu.txtGhiChu.Text;
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.strDataMenu2[3].ToString(),
					this.strDataMenu2[4].ToString(),
					this.strDataMenu2[5].ToString(),
					this.strDataMenu2[6].ToString(),
					this.strGhiChu,
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00020C80 File Offset: 0x0001EE80
		private void dgvMenu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				try
				{
					bool flag2 = this.dgvMenu.Rows.Count > 0 && this.dgvMenu != null && e.RowIndex != -1;
					if (flag2)
					{
						int index = this.dgvMenu.CurrentRow.Index;
						this.iIndexSelectedRow = index;
						this.strDataMenu2 = new string[]
						{
							this.dgvMenu.Rows[index].Cells[0].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[1].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[2].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[3].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[4].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[5].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[6].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[7].Value.ToString(),
							this.dgvMenu.Rows[index].Cells[8].Value.ToString()
						};
						this.btnTang.Enabled = true;
						this.btnGiam.Enabled = true;
						this.btnDatSL.Enabled = true;
						this.btnDoiGia.Enabled = true;
						this.btnGhiChu.Enabled = true;
						this.btnChietKhau.Enabled = true;
						this.btnGiamHang.Enabled = true;
						this.btnXoa.Enabled = true;
					}
					else
					{
						this.dgvMenu.ClearSelection();
						this.btnTang.Enabled = false;
						this.btnGiam.Enabled = false;
						this.btnDatSL.Enabled = false;
						this.btnDoiGia.Enabled = false;
						this.btnGhiChu.Enabled = false;
						this.btnChietKhau.Enabled = false;
						this.btnGiamHang.Enabled = false;
						this.btnXoa.Enabled = false;
					}
				}
				catch (Exception ex)
				{
					this.funcCommon.Msg(ex.Message, "Lỗi");
				}
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00020F88 File Offset: 0x0001F188
		private void btnTang_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu2[0].ToString(), this.strDataMenu2[8].ToString());
				bool flag2 = this.iSoluong > -1;
				if (flag2)
				{
					this.iSoluong++;
				}
				else
				{
					this.iSoluong = (int)Convert.ToInt16(this.cbSoLuong.Text);
				}
				this.iThanhTien = Convert.ToUInt64(this.strDataMenu2[4].ToString()) * (ulong)((ushort)this.iSoluong);
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.iSoluong.ToString(),
					this.strDataMenu2[4].ToString(),
					this.iThanhTien.ToString(),
					this.strDataMenu2[6].ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000210FC File Offset: 0x0001F2FC
		private void btnGiam_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu2[0].ToString(), this.strDataMenu2[8].ToString());
				bool flag2 = this.iSoluong > -1;
				if (flag2)
				{
					this.iSoluong--;
				}
				else
				{
					this.iSoluong = (int)Convert.ToInt16(this.cbSoLuong.Text);
				}
				this.iThanhTien = Convert.ToUInt64(this.strDataMenu2[4].ToString()) * (ulong)((ushort)this.iSoluong);
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.iSoluong.ToString(),
					this.strDataMenu2[4].ToString(),
					this.iThanhTien.ToString(),
					this.strDataMenu2[6].ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00021270 File Offset: 0x0001F470
		private void btnGiamHang_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				DataTable dataTable = new DataTable();
				string[] strHeaderMenu = CMConstant.strHeaderMenu;
				for (int i = 0; i < strHeaderMenu.Length; i++)
				{
					dataTable.Columns.Add(strHeaderMenu[i].ToString(), typeof(string));
				}
				DataRow dataRow = dataTable.NewRow();
				this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu2[0].ToString(), this.strDataMenu2[8].ToString());
				bool flag2 = this.iSoluong == 1 || this.iSoluong < (int)Convert.ToInt16(this.cbSoLuong.Text);
				if (flag2)
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"Không thể giảm [",
						this.cbSoLuong.Text,
						"] vì số lượng hiện tại chỉ còn có [",
						this.iSoluong.ToString(),
						"]"
					}), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					bool flag3 = this.iSoluong > -1;
					if (flag3)
					{
						this.iSoluong -= (int)Convert.ToInt16(this.cbSoLuong.Text);
					}
					else
					{
						this.iSoluong = (int)Convert.ToInt16(this.cbSoLuong.Text);
					}
					this.iThanhTien = Convert.ToUInt64(this.strDataMenu2[4].ToString()) * (ulong)((ushort)this.iSoluong);
					string[] strData = new string[]
					{
						this.strDataMenu2[0].ToString(),
						this.strDataMenu2[1].ToString(),
						this.strDataMenu2[2].ToString(),
						this.iSoluong.ToString(),
						this.strDataMenu2[4].ToString(),
						this.iThanhTien.ToString(),
						this.strDataMenu2[6].ToString(),
						this.strDataMenu2[7].ToString(),
						this.strDataMenu2[8].ToString()
					};
					bool flag4 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
					if (!flag4)
					{
						bool flag5 = File.Exists(CMConstant.strFilePathMenu);
						if (flag5)
						{
							DataTable dataSource = new DataTable();
							int iErrorCode = this.readwriteData2CSV.LoadDataTableFromCSV(CMConstant.strFilePathMenu, ref dataSource);
							bool flag6 = !this.funcCommon.ShowMsg(iErrorCode, "Menu.csv");
							if (!flag6)
							{
								this.dgvMenu.DataSource = dataSource;
								this.funcCommon.dgvRefresh(ref this.dgvMenu);
								AddUserService.bEnableTimer = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002151C File Offset: 0x0001F71C
		private void btnXoa_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.strDataMenu2[3].ToString(),
					this.strDataMenu2[4].ToString(),
					this.strDataMenu2[5].ToString(),
					this.strDataMenu2[6].ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag2 = !this.DeleteMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag2)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
					bool flag3 = this.dgvMenu != null;
					if (flag3)
					{
						bool flag4 = this.dgvMenu.Rows.Count == 0;
						if (flag4)
						{
							this.btnTang.Enabled = false;
							this.btnGiam.Enabled = false;
							this.btnDatSL.Enabled = false;
							this.btnDoiGia.Enabled = false;
							this.btnGhiChu.Enabled = false;
							this.btnChietKhau.Enabled = false;
							this.btnGiamHang.Enabled = false;
							this.btnXoa.Enabled = false;
						}
					}
				}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000216A4 File Offset: 0x0001F8A4
		private void btnDatSL_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmCommon;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmCommon frmCommon = new frmCommon("ĐẶT SỐ LƯỢNG", "Đặt số lượng cho mặt hàng", "Số lượng", this.strDataMenu2[3].ToString());
				frmCommon.ShowDialog();
				string text = frmCommon.txtCommon.Text;
				this.iSoluong = (int)Convert.ToInt16(text);
				this.iThanhTien = Convert.ToUInt64(this.strDataMenu2[4].ToString()) * (ulong)((ushort)this.iSoluong);
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.iSoluong.ToString(),
					this.strDataMenu2[4].ToString(),
					this.iThanhTien.ToString(),
					this.strDataMenu2[6].ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00021864 File Offset: 0x0001FA64
		private void btnDoiGia_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmCommon;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmCommon frmCommon = new frmCommon("ĐỔI GIÁ BÁN MẶT HÀNG", "Đặt số lượng cho mặt hàng", "Đơn giá", this.strDataMenu2[4].ToString());
				frmCommon.ShowDialog();
				string text = frmCommon.txtCommon.Text;
				this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu2[0].ToString(), this.strDataMenu2[8].ToString());
				this.iThanhTien = Convert.ToUInt64(text) * (ulong)((ushort)this.iSoluong);
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.iSoluong.ToString(),
					text,
					this.iThanhTien.ToString(),
					this.strDataMenu2[6].ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00021A30 File Offset: 0x0001FC30
		private void btnChietKhau_Click(object sender, EventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmChietKhau;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmChietKhau frmChietKhau = new frmChietKhau(this.strDataMenu2[4].ToString());
				frmChietKhau.ShowDialog();
				float fPhanTram = frmChietKhau.fPhanTram;
				float num = Convert.ToUInt64(this.strDataMenu2[4].ToString()) - Convert.ToUInt64(this.strDataMenu2[4].ToString()) * fPhanTram / 100f;
				float num2 = num * (float)Convert.ToInt16(this.strDataMenu2[3].ToString());
				string[] strData = new string[]
				{
					this.strDataMenu2[0].ToString(),
					this.strDataMenu2[1].ToString(),
					this.strDataMenu2[2].ToString(),
					this.strDataMenu2[3].ToString(),
					this.strDataMenu2[4].ToString(),
					num2.ToString(),
					fPhanTram.ToString(),
					this.strDataMenu2[7].ToString(),
					this.strDataMenu2[8].ToString()
				};
				bool flag3 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
				if (!flag3)
				{
					this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
					AddUserService.bEnableTimer = true;
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		private void dgvMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = AddUserService.iIndexSelected > -1;
			if (flag)
			{
				try
				{
					bool flag2 = this.dgvMenu.Rows.Count > 0 && this.dgvMenu != null && e.RowIndex != -1;
					if (flag2)
					{
						int columnIndex = this.dgvMenu.CurrentCell.ColumnIndex;
						bool flag3 = columnIndex == 6;
						if (flag3)
						{
							foreach (object obj in Application.OpenForms)
							{
								Form form = (Form)obj;
								bool flag4 = form is frmChietKhau;
								if (flag4)
								{
									form.Show();
									return;
								}
							}
							frmChietKhau frmChietKhau = new frmChietKhau(this.strDataMenu2[4].ToString());
							frmChietKhau.ShowDialog();
							float fPhanTram = frmChietKhau.fPhanTram;
							float num = Convert.ToUInt64(this.strDataMenu2[4].ToString()) - Convert.ToUInt64(this.strDataMenu2[4].ToString()) * fPhanTram / 100f;
							float num2 = num * (float)Convert.ToInt16(this.strDataMenu2[3].ToString());
							string[] strData = new string[]
							{
								this.strDataMenu2[0].ToString(),
								this.strDataMenu2[1].ToString(),
								this.strDataMenu2[2].ToString(),
								this.strDataMenu2[3].ToString(),
								this.strDataMenu2[4].ToString(),
								num2.ToString(),
								fPhanTram.ToString(),
								this.strDataMenu2[7].ToString(),
								this.strDataMenu2[8].ToString()
							};
							bool flag5 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData, this.iIndexSelectedRow);
							if (!flag5)
							{
								this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
								AddUserService.bEnableTimer = true;
							}
						}
						else
						{
							bool flag6 = columnIndex == 3;
							if (flag6)
							{
								foreach (object obj2 in Application.OpenForms)
								{
									Form form2 = (Form)obj2;
									bool flag7 = form2 is frmCommon;
									if (flag7)
									{
										form2.Show();
										return;
									}
								}
								frmCommon frmCommon = new frmCommon("ĐẶT SỐ LƯỢNG", "Đặt số lượng cho mặt hàng", "Số lượng", this.strDataMenu2[3].ToString());
								frmCommon.ShowDialog();
								string text = frmCommon.txtCommon.Text;
								this.iSoluong = (int)Convert.ToInt16(text);
								this.iThanhTien = Convert.ToUInt64(this.strDataMenu2[4].ToString()) * (ulong)((ushort)this.iSoluong);
								string[] strData2 = new string[]
								{
									this.strDataMenu2[0].ToString(),
									this.strDataMenu2[1].ToString(),
									this.strDataMenu2[2].ToString(),
									this.iSoluong.ToString(),
									this.strDataMenu2[4].ToString(),
									this.iThanhTien.ToString(),
									this.strDataMenu2[6].ToString(),
									this.strDataMenu2[7].ToString(),
									this.strDataMenu2[8].ToString()
								};
								bool flag8 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData2, this.iIndexSelectedRow);
								if (!flag8)
								{
									this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
									AddUserService.bEnableTimer = true;
								}
							}
							else
							{
								bool flag9 = columnIndex == 4;
								if (flag9)
								{
									foreach (object obj3 in Application.OpenForms)
									{
										Form form3 = (Form)obj3;
										bool flag10 = form3 is frmCommon;
										if (flag10)
										{
											form3.Show();
											return;
										}
									}
									frmCommon frmCommon2 = new frmCommon("ĐỔI GIÁ BÁN MẶT HÀNG", "Đặt số lượng cho mặt hàng", "Đơn giá", this.strDataMenu2[4].ToString());
									frmCommon2.ShowDialog();
									string text2 = frmCommon2.txtCommon.Text;
									this.iSoluong = this.GetValueQty(CMConstant.strFilePathMenu, "Menu.csv", this.strDataMenu2[0].ToString(), this.strDataMenu2[8].ToString());
									this.iThanhTien = Convert.ToUInt64(text2) * (ulong)((ushort)this.iSoluong);
									string[] strData3 = new string[]
									{
										this.strDataMenu2[0].ToString(),
										this.strDataMenu2[1].ToString(),
										this.strDataMenu2[2].ToString(),
										this.iSoluong.ToString(),
										text2,
										this.iThanhTien.ToString(),
										this.strDataMenu2[6].ToString(),
										this.strDataMenu2[7].ToString(),
										this.strDataMenu2[8].ToString()
									};
									bool flag11 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData3, this.iIndexSelectedRow);
									if (!flag11)
									{
										this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
										AddUserService.bEnableTimer = true;
									}
								}
								else
								{
									bool flag12 = columnIndex == 7;
									if (flag12)
									{
										foreach (object obj4 in Application.OpenForms)
										{
											Form form4 = (Form)obj4;
											bool flag13 = form4 is frmGhiChu;
											if (flag13)
											{
												form4.Show();
												return;
											}
										}
										frmGhiChu frmGhiChu = new frmGhiChu();
										frmGhiChu.ShowDialog();
										this.strGhiChu = frmGhiChu.txtGhiChu.Text;
										string[] strData4 = new string[]
										{
											this.strDataMenu2[0].ToString(),
											this.strDataMenu2[1].ToString(),
											this.strDataMenu2[2].ToString(),
											this.strDataMenu2[3].ToString(),
											this.strDataMenu2[4].ToString(),
											this.strDataMenu2[5].ToString(),
											this.strDataMenu2[6].ToString(),
											this.strGhiChu,
											this.strDataMenu2[8].ToString()
										};
										bool flag14 = !this.EditMenu(CMConstant.strFilePathMenu, "Menu.csv", strData4, this.iIndexSelectedRow);
										if (!flag14)
										{
											this.Reload_DataGridView(CMConstant.strFilePathMenu, this.dgvMenu);
											AddUserService.bEnableTimer = true;
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.funcCommon.Msg(ex.Message, "Lỗi");
				}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00022368 File Offset: 0x00020568
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = AddUserService.bEnableTimer;
		}

		// Token: 0x04000197 RID: 407
		public static List<LoaiSanPham> lstpLoaiSanPham = new List<LoaiSanPham>();

		// Token: 0x04000198 RID: 408
		public static List<NhomMatHang> lstpNhomMatHang = new List<NhomMatHang>();

		// Token: 0x04000199 RID: 409
		public static List<KhuVuc> lstpKhuVuc = new List<KhuVuc>();

		// Token: 0x0400019A RID: 410
		public static List<NhomKhachHang> lstpNhomKhachHang = new List<NhomKhachHang>();

		// Token: 0x0400019B RID: 411
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400019C RID: 412
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400019D RID: 413
		public static DataTable pDataTable = new DataTable();

		// Token: 0x0400019E RID: 414
		private DataTable dtCustomer = new DataTable();

		// Token: 0x0400019F RID: 415
		private DataTable dtBangGia = new DataTable();

		// Token: 0x040001A0 RID: 416
		public static MatHang MatHangSelected = new MatHang();

		// Token: 0x040001A1 RID: 417
		public static Table TableSelected = new Table();

		// Token: 0x040001A2 RID: 418
		private DataRow dtRow = null;

		// Token: 0x040001A3 RID: 419
		private string strTenSP = string.Empty;

		// Token: 0x040001A4 RID: 420
		private int iIndexSelectedRow = -1;

		// Token: 0x040001A5 RID: 421
		public static List<List<GroupRoom>> lstpGroupRoom = new List<List<GroupRoom>>();

		// Token: 0x040001A6 RID: 422
		public static List<AddUserService> lstpAddUserService = new List<AddUserService>();

		// Token: 0x040001A7 RID: 423
		private string[] strDataMenu = new string[0];

		// Token: 0x040001A8 RID: 424
		private string[] strDataMenu2 = new string[0];

		// Token: 0x040001A9 RID: 425
		private int iSoluong = -1;

		// Token: 0x040001AA RID: 426
		private string strChietKhau = string.Empty;

		// Token: 0x040001AB RID: 427
		private string strGhiChu = string.Empty;

		// Token: 0x040001AC RID: 428
		private ulong iThanhTien = 0UL;
	}
}

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
	// Token: 0x02000003 RID: 3
	public partial class frmAddNew : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002508 File Offset: 0x00000708
		public frmAddNew(string strtitle, string strtenBangGia)
		{
			this.InitializeComponent();
			this.strTitle = strtitle;
			this.strTenBangGia = strtenBangGia;
			this.Text += this.strTitle;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002594 File Offset: 0x00000794
		private void frmAddNew_Load(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals(" - THÊM MỚI");
			if (flag)
			{
				this.rdGiaNgayThuong.Checked = true;
				this.chkBangGiaGio.Checked = true;
				this.chkBangGiaDem.Checked = true;
				this.chkBangGiaNgayDem.Checked = true;
				this.DisableRadio();
				bool @checked = this.chkDonGiaCuoiTuan.Checked;
				if (@checked)
				{
					this.EnableRadio();
				}
				this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaGio;
				this.rdPhuThuGio.Checked = true;
				this.txtTenBangGia.Select();
				bool flag2 = File.Exists(CMConstant.strFilePathLoaiPhong);
				if (flag2)
				{
					this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(CMConstant.strFilePathLoaiPhong);
					bool flag3 = this.lstLoaiPhong == null;
					if (flag3)
					{
						this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
						return;
					}
				}
				this.AddRowDgvBangGiaGio(this.dgvBangGiaGio);
				this.AddRowDgvBangGiaGio(this.dgvBangGiaQuaDemPhuThuVaoSom);
				this.AddRowDgvBangGiaGio(this.dgvBangGiaQuaDemGiamTruVaoMuon);
				this.AddRowDgvBangGiaGio(this.dgvBangGiaQuaDemPhuThuRaTre);
				this.AddRowDgvBangGiaGio(this.dgvBangGiaNgayDemPhuThuVaoSom);
				this.AddRowDgvBangGiaGio(this.dgvBangGiaNgayDemPhuThuRaTre);
				this.AddRowDgvBangGia(this.dgvBangGiaQuaDem);
				this.AddRowDgvBangGia(this.dgvBangGiaNgayDem);
			}
			else
			{
				bool flag4 = this.strTitle.Equals(" - CHỈNH SỬA");
				if (flag4)
				{
					bool flag5 = File.Exists(CMConstant.strFilePathBangGiaDichVu);
					if (flag5)
					{
						this.lstBangGiaDichVu = this.readwriteData2CSV.ReadBangGiaDichVuFromCSV(CMConstant.strFilePathBangGiaDichVu);
						bool flag6 = this.lstBangGiaDichVu == null;
						if (flag6)
						{
							this.funcCommon.Msg("Lỗi đọc tập tin BangGiaDichVu.csv", "Lỗi");
							return;
						}
					}
					int index = 0;
					for (int i = 0; i < this.lstBangGiaDichVu.Count; i++)
					{
						bool flag7 = this.strTenBangGia.Equals(this.lstBangGiaDichVu[i].strTenBangGia);
						if (flag7)
						{
							index = i;
							break;
						}
					}
					BangGiaDichVu bangGiaDichVu = new BangGiaDichVu();
					bangGiaDichVu.bangGiaGio = new BangGiaGio();
					bangGiaDichVu.bangGiaQuaDem = new BangGiaQuaDem();
					bangGiaDichVu.bangGiaNgayDem = new BangGiaNgayDem();
					bangGiaDichVu = this.lstBangGiaDichVu[index];
					this.txtTenBangGia.Text = bangGiaDichVu.strTenBangGia;
					this.rdPhuThuGio.Checked = Convert.ToBoolean(bangGiaDichVu.bPhuThuGio);
					this.rdPhuThuBangGia.Checked = Convert.ToBoolean(bangGiaDichVu.bPhuThuBangGia);
					this.txtNguoiLonThem.Text = bangGiaDichVu.iThemNguoiLon.ToString();
					this.txtTreEmTinhThem.Text = bangGiaDichVu.iThemTreEm.ToString();
					this.txtGiuongTinhThem.Text = bangGiaDichVu.iThemGiuong.ToString();
					this.chkDonGiaCuoiTuan.Checked = Convert.ToBoolean(bangGiaDichVu.bDonGiaCuoiTuan);
					this.chkDonGiaNgayLe.Checked = Convert.ToBoolean(bangGiaDichVu.bDonGiaNgayLe);
					this.chkBangGiaGio.Checked = Convert.ToBoolean(bangGiaDichVu.bBangGiaGio);
					this.chkBangGiaDem.Checked = Convert.ToBoolean(bangGiaDichVu.bBangGiaDem);
					this.chkBangGiaNgayDem.Checked = Convert.ToBoolean(bangGiaDichVu.bBangGiaNgayDem);
					this.txtBGGTreToiDa.Text = bangGiaDichVu.bangGiaGio.iTreToiDa.ToString();
					this.rdGiaNgayThuong.Checked = Convert.ToBoolean(bangGiaDichVu.bangGiaGio.bGiaNgayThuong);
					this.rdGiaCuoiTuan.Checked = Convert.ToBoolean(bangGiaDichVu.bangGiaGio.bGiaCuoiTuan);
					this.rdGiaNgayLe.Checked = Convert.ToBoolean(bangGiaDichVu.bangGiaGio.bGiaNgayLe);
					this.txtTreToiDaQuaDem.Text = bangGiaDichVu.bangGiaQuaDem.iTreToiDa.ToString();
					this.txtTraPhongTruocQuaDem.Text = bangGiaDichVu.bangGiaQuaDem.iTraPhongTruoc.ToString();
					this.txtGioVaoSau1.Text = bangGiaDichVu.bangGiaQuaDem.iGioVaoSau1.ToString();
					this.txtQuaGioQuaDem.Text = bangGiaDichVu.bangGiaQuaDem.iQuaGio.ToString();
					this.txtGioVaoSau2.Text = bangGiaDichVu.bangGiaQuaDem.iGioVaoSau2.ToString();
					this.txtTruocGio.Text = bangGiaDichVu.bangGiaQuaDem.iTruocGio.ToString();
					this.txtTreToiDaNgayDem.Text = bangGiaDichVu.bangGiaNgayDem.iTreToiDa.ToString();
					this.txtTraPhongTruocNgayDem.Text = bangGiaDichVu.bangGiaNgayDem.iTraPhongTruoc.ToString();
					this.chkTinhLa1Ngay.Checked = bangGiaDichVu.bangGiaNgayDem.bTinhLa1Ngay;
					this.txtQuaGioNgayDem.Text = bangGiaDichVu.bangGiaQuaDem.iQuaGio.ToString();
					this.chkRaSauGioTraPhong.Checked = Convert.ToBoolean(bangGiaDichVu.bangGiaNgayDem.bRaSauGioTraPhong);
					string path = Path.Combine(CMConstant.strFolderData, this.txtTenBangGia.Text);
					string strFilePath = Path.Combine(path, "BangGiaGio.csv");
					string strFilePath2 = Path.Combine(path, "BangGiaQuaDem.csv");
					string strFilePath3 = Path.Combine(path, "BangGiaQuaDemPhuThuVaoSom.csv");
					string strFilePath4 = Path.Combine(path, "BangGiaQuaDemGiamTruVaoMuon.csv");
					string strFilePath5 = Path.Combine(path, "BangGiaQuaDemPhuThuRaTre.csv");
					string strFilePath6 = Path.Combine(path, "BangGiaNgayDem.csv");
					string strFilePath7 = Path.Combine(path, "BangGiaQuaDemPhuThuVaoSom.csv");
					string strFilePath8 = Path.Combine(path, "BangGiaNgayDemPhuThuRaTre.csv");
					this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaGio;
					int iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath, ref this.dgvBangGiaGio);
					bool flag8 = !this.ShowMsg(iErrorCode, "BangGiaGio.csv");
					if (!flag8)
					{
						this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaQuaDem;
						this.tabControlBangGiaQuaDem.SelectedTab = this.tabQuaDemBangGia;
						iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath2, ref this.dgvBangGiaQuaDem);
						bool flag9 = !this.ShowMsg(iErrorCode, "BangGiaQuaDem.csv");
						if (!flag9)
						{
							this.tabControlBangGiaQuaDem.SelectedTab = this.tabQuaDemPhuThuVaoSom;
							iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath3, ref this.dgvBangGiaQuaDemPhuThuVaoSom);
							bool flag10 = !this.ShowMsg(iErrorCode, "BangGiaQuaDemPhuThuVaoSom.csv");
							if (!flag10)
							{
								this.tabControlBangGiaQuaDem.SelectedTab = this.tabQuaDemGiamTruVaoMuon;
								iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath4, ref this.dgvBangGiaQuaDemGiamTruVaoMuon);
								bool flag11 = !this.ShowMsg(iErrorCode, "BangGiaQuaDemGiamTruVaoMuon.csv");
								if (!flag11)
								{
									this.tabControlBangGiaQuaDem.SelectedTab = this.tabQuaDemPhuThuRaTre;
									iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath5, ref this.dgvBangGiaQuaDemPhuThuRaTre);
									bool flag12 = !this.ShowMsg(iErrorCode, "BangGiaQuaDemPhuThuRaTre.csv");
									if (!flag12)
									{
										this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaNgayDem;
										this.tabControlBangGiaNgayDem.SelectedTab = this.tabBangGiaNgayDem;
										iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath6, ref this.dgvBangGiaNgayDem);
										bool flag13 = !this.ShowMsg(iErrorCode, "BangGiaNgayDem.csv");
										if (!flag13)
										{
											this.tabControlBangGiaNgayDem.SelectedTab = this.tabNgayDemPhuThuVaoSom;
											iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath7, ref this.dgvBangGiaNgayDemPhuThuVaoSom);
											bool flag14 = !this.ShowMsg(iErrorCode, "BangGiaQuaDemPhuThuVaoSom.csv");
											if (!flag14)
											{
												this.tabControlBangGiaNgayDem.SelectedTab = this.tabNgayDemPhuThuRaTre;
												iErrorCode = this.readwriteData2CSV.LoadDgvFromCSV(strFilePath8, ref this.dgvBangGiaNgayDemPhuThuRaTre);
												bool flag15 = !this.ShowMsg(iErrorCode, "BangGiaNgayDemPhuThuRaTre.csv");
												if (!flag15)
												{
													this.DisableRadio();
													bool checked2 = this.chkDonGiaCuoiTuan.Checked;
													if (checked2)
													{
														this.EnableRadio();
													}
													this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaGio;
													this.tabControlBangGiaQuaDem.SelectedTab = this.tabQuaDemBangGia;
													this.tabControlBangGiaNgayDem.SelectedTab = this.tabNgayDemDKAD;
													this.txtTenBangGia.Select();
													bool flag16 = File.Exists(CMConstant.strFilePathLoaiPhong);
													if (flag16)
													{
														this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(CMConstant.strFilePathLoaiPhong);
														bool flag17 = this.lstLoaiPhong == null;
														if (flag17)
														{
															this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002E4C File Offset: 0x0000104C
		private bool ShowMsg(int iErrorCode, string FileName)
		{
			bool flag = iErrorCode == 2;
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Không tìm thấy tập tin ", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = iErrorCode == -1;
				if (flag2)
				{
					this.funcCommon.Msg("Lỗi đọc tập tin " + FileName, "Lỗi");
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002EAC File Offset: 0x000010AC
		private void AddRowDgvBangGia(DataGridView dataGridView)
		{
			bool flag = this.lstLoaiPhong.Count > 0;
			if (flag)
			{
				bool flag2 = dataGridView.Rows.Count > 0;
				if (flag2)
				{
					dataGridView.DataSource = null;
					dataGridView.Columns.Clear();
					dataGridView.Rows.Clear();
					dataGridView.Refresh();
				}
				dataGridView.ColumnCount = 5;
				dataGridView.Columns[0].Name = "ID";
				dataGridView.Columns[1].Name = "Loại phòng";
				dataGridView.Columns[2].Name = "Đơn giá";
				dataGridView.Columns[3].Name = "Cuối tuần";
				dataGridView.Columns[4].Name = "Ngày lễ";
				bool flag3 = this.chkDonGiaCuoiTuan.Checked && !this.chkDonGiaNgayLe.Checked;
				if (flag3)
				{
					dataGridView.Columns.Remove("Ngày lễ");
				}
				else
				{
					bool flag4 = !this.chkDonGiaCuoiTuan.Checked && this.chkDonGiaNgayLe.Checked;
					if (flag4)
					{
						dataGridView.Columns.Remove("Cuối tuần");
					}
					else
					{
						bool flag5 = !this.chkDonGiaCuoiTuan.Checked && !this.chkDonGiaNgayLe.Checked;
						if (flag5)
						{
							dataGridView.Columns.Remove("Cuối tuần");
							dataGridView.Columns.Remove("Ngày lễ");
						}
					}
				}
				string[] array = new string[dataGridView.ColumnCount];
				for (int i = 0; i < this.lstLoaiPhong.Count; i++)
				{
					array[0] = (i + 1).ToString();
					array[1] = this.lstLoaiPhong[i].strTenLoaiPhong;
					for (int j = 0; j < dataGridView.Columns.Count - 2; j++)
					{
						array[j + 2] = string.Empty;
					}
					DataGridViewRowCollection rows = dataGridView.Rows;
					object[] values = array;
					rows.Add(values);
				}
				this.funcCommon.dgvRefresh(ref dataGridView);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000030E0 File Offset: 0x000012E0
		private void AddRowDgvBangGiaGio(DataGridView dataGridView)
		{
			bool flag = dataGridView.Rows.Count > 0;
			if (flag)
			{
				dataGridView.DataSource = null;
				dataGridView.Columns.Clear();
				dataGridView.Rows.Clear();
				dataGridView.Refresh();
			}
			dataGridView.ColumnCount = this.lstLoaiPhong.Count + 2;
			dataGridView.Columns[0].Name = "ID";
			dataGridView.Columns[1].Name = "Diễn giải";
			for (int i = 0; i < this.lstLoaiPhong.Count; i++)
			{
				dataGridView.Columns[i + 2].Name = this.lstLoaiPhong[i].strTenLoaiPhong;
			}
			string[] array = new string[dataGridView.ColumnCount];
			for (int j = 0; j < 48; j++)
			{
				array[0] = (j + 1).ToString();
				array[1] = (j + 1).ToString() + " h";
				for (int k = 0; k < this.lstLoaiPhong.Count; k++)
				{
					array[k + 2] = string.Empty;
				}
				DataGridViewRowCollection rows = dataGridView.Rows;
				object[] values = array;
				rows.Add(values);
			}
			this.funcCommon.dgvRefresh(ref dataGridView);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003248 File Offset: 0x00001448
		private void RemoveAddTabAll()
		{
			this.tabBangGiaDichVu.TabPages.Remove(this.tabPageBangGiaGio);
			this.tabBangGiaDichVu.TabPages.Remove(this.tabPageBangGiaQuaDem);
			this.tabBangGiaDichVu.TabPages.Remove(this.tabPageBangGiaNgayDem);
			bool @checked = this.chkBangGiaGio.Checked;
			if (@checked)
			{
				this.tabBangGiaDichVu.TabPages.Add(this.tabPageBangGiaGio);
			}
			bool checked2 = this.chkBangGiaDem.Checked;
			if (checked2)
			{
				this.tabBangGiaDichVu.TabPages.Add(this.tabPageBangGiaQuaDem);
			}
			bool checked3 = this.chkBangGiaNgayDem.Checked;
			if (checked3)
			{
				this.tabBangGiaDichVu.TabPages.Add(this.tabPageBangGiaNgayDem);
			}
			bool flag = this.strTitle.Equals(" - CHỈNH SỬA");
			if (flag)
			{
				this.funcCommon.dgvRefreshAll(ref this.dgvBangGiaQuaDem, ref this.dgvBangGiaNgayDem, ref this.dgvBangGiaGio, ref this.dgvBangGiaQuaDemPhuThuRaTre, ref this.dgvBangGiaQuaDemPhuThuVaoSom, ref this.dgvBangGiaQuaDemGiamTruVaoMuon, ref this.dgvBangGiaNgayDemPhuThuRaTre, ref this.dgvBangGiaNgayDemPhuThuVaoSom);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003368 File Offset: 0x00001568
		private void chkBangGiaGio_CheckedChanged(object sender, EventArgs e)
		{
			this.RemoveAddTabAll();
			bool @checked = this.chkBangGiaGio.Checked;
			if (@checked)
			{
				this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaGio;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000033A0 File Offset: 0x000015A0
		private void chkBangGiaDem_CheckedChanged(object sender, EventArgs e)
		{
			this.RemoveAddTabAll();
			bool @checked = this.chkBangGiaDem.Checked;
			if (@checked)
			{
				this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaQuaDem;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000033D8 File Offset: 0x000015D8
		private void chkBangGiaNgayDem_CheckedChanged(object sender, EventArgs e)
		{
			this.RemoveAddTabAll();
			bool @checked = this.chkBangGiaNgayDem.Checked;
			if (@checked)
			{
				this.tabBangGiaDichVu.SelectedTab = this.tabPageBangGiaNgayDem;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003410 File Offset: 0x00001610
		private void DisableRadio()
		{
			this.rdGiaNgayThuong.Visible = false;
			this.rdGiaCuoiTuan.Visible = false;
			this.rdGiaNgayLe.Visible = false;
			this.rdGiaCuoiTuan.Enabled = this.chkDonGiaCuoiTuan.Checked;
			this.rdGiaNgayLe.Enabled = this.chkDonGiaNgayLe.Checked;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003474 File Offset: 0x00001674
		private void EnableRadio()
		{
			this.rdGiaNgayThuong.Visible = true;
			this.rdGiaCuoiTuan.Visible = true;
			this.rdGiaNgayLe.Visible = true;
			this.rdGiaCuoiTuan.Enabled = this.chkDonGiaCuoiTuan.Checked;
			this.rdGiaNgayLe.Enabled = this.chkDonGiaNgayLe.Checked;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000034D8 File Offset: 0x000016D8
		private void chkDonGiaCuoiTuan_CheckedChanged(object sender, EventArgs e)
		{
			this.DisableRadio();
			bool flag = this.chkDonGiaNgayLe.Checked || this.chkDonGiaCuoiTuan.Checked;
			if (flag)
			{
				this.EnableRadio();
			}
			this.AddRowDgvBangGia(this.dgvBangGiaQuaDem);
			this.AddRowDgvBangGia(this.dgvBangGiaNgayDem);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003530 File Offset: 0x00001730
		private void chkDonGiaNgayLe_CheckedChanged(object sender, EventArgs e)
		{
			this.DisableRadio();
			bool flag = this.chkDonGiaNgayLe.Checked || this.chkDonGiaCuoiTuan.Checked;
			if (flag)
			{
				this.EnableRadio();
			}
			this.AddRowDgvBangGia(this.dgvBangGiaQuaDem);
			this.AddRowDgvBangGia(this.dgvBangGiaNgayDem);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003588 File Offset: 0x00001788
		private void btnSave_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBangGiaDichVu);
			if (flag)
			{
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000035AC File Offset: 0x000017AC
		private bool SaveData2CSV(string strFilePath)
		{
			bool flag = string.IsNullOrEmpty(this.txtTenBangGia.Text) || string.IsNullOrEmpty(this.txtNguoiLonThem.Text) || string.IsNullOrEmpty(this.txtTreEmTinhThem.Text) || string.IsNullOrEmpty(this.txtGiuongTinhThem.Text) || string.IsNullOrEmpty(this.txtBGGTreToiDa.Text);
			bool result;
			if (flag)
			{
				this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống", "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = !this.funcCommon.IsValidDigital(this.txtNguoiLonThem.Text) || !this.funcCommon.IsValidDigital(this.txtTreEmTinhThem.Text) || !this.funcCommon.IsValidDigital(this.txtGiuongTinhThem.Text) || !this.funcCommon.IsValidDigital(this.txtBGGTreToiDa.Text) || !this.funcCommon.IsValidDigital(this.txtTreToiDaQuaDem.Text) || !this.funcCommon.IsValidDigital(this.txtTraPhongTruocQuaDem.Text) || !this.funcCommon.IsValidDigital(this.txtGioVaoSau1.Text) || !this.funcCommon.IsValidDigital(this.txtQuaGioQuaDem.Text) || !this.funcCommon.IsValidDigital(this.txtGioVaoSau2.Text) || !this.funcCommon.IsValidDigital(this.txtTruocGio.Text) || !this.funcCommon.IsValidDigital(this.txtTreToiDaNgayDem.Text) || !this.funcCommon.IsValidDigital(this.txtTraPhongTruocNgayDem.Text) || !this.funcCommon.IsValidDigital(this.txtQuaGioNgayDem.Text);
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
						bool flag4 = File.Exists(strFilePath) && !string.IsNullOrEmpty(strFilePath);
						if (flag4)
						{
							this.lstBangGiaDichVu = this.readwriteData2CSV.ReadBangGiaDichVuFromCSV(strFilePath);
							bool flag5 = this.lstBangGiaDichVu == null;
							if (flag5)
							{
								this.funcCommon.Msg("Lỗi đọc tập tin BangGiaDichVu.csv", "Lỗi");
								return false;
							}
							foreach (BangGiaDichVu bangGiaDichVu in this.lstBangGiaDichVu)
							{
								bool flag6 = this.txtTenBangGia.Text.Equals(bangGiaDichVu.strTenBangGia);
								if (flag6)
								{
									this.funcCommon.Msg("Tên bản giá [" + this.txtTenBangGia.Text + "] đã có trong danh sách bảng giá.", "Cảnh báo");
									return false;
								}
							}
						}
					}
					BangGiaDichVu bangGiaDichVu2 = new BangGiaDichVu();
					bangGiaDichVu2.bangGiaGio = new BangGiaGio();
					bangGiaDichVu2.bangGiaQuaDem = new BangGiaQuaDem();
					bangGiaDichVu2.bangGiaNgayDem = new BangGiaNgayDem();
					bangGiaDichVu2.strTenBangGia = this.txtTenBangGia.Text;
					bangGiaDichVu2.bPhuThuGio = Convert.ToBoolean(this.rdPhuThuGio.Checked);
					bangGiaDichVu2.bPhuThuBangGia = Convert.ToBoolean(this.rdPhuThuBangGia.Checked);
					try
					{
						bangGiaDichVu2.iThemNguoiLon = (int)Convert.ToInt16(this.txtNguoiLonThem.Text);
						bangGiaDichVu2.iThemTreEm = (int)Convert.ToInt16(this.txtTreEmTinhThem.Text);
						bangGiaDichVu2.iThemGiuong = (int)Convert.ToInt16(this.txtGiuongTinhThem.Text);
						bangGiaDichVu2.bangGiaGio.iTreToiDa = (int)Convert.ToInt16(this.txtBGGTreToiDa.Text);
						bangGiaDichVu2.bangGiaQuaDem.iTreToiDa = (int)Convert.ToInt16(this.txtTreToiDaQuaDem.Text);
						bangGiaDichVu2.bangGiaQuaDem.iTraPhongTruoc = (int)Convert.ToInt16(this.txtTraPhongTruocQuaDem.Text);
						bangGiaDichVu2.bangGiaQuaDem.iGioVaoSau1 = (int)Convert.ToInt16(this.txtGioVaoSau1.Text);
						bangGiaDichVu2.bangGiaQuaDem.iQuaGio = (int)Convert.ToInt16(this.txtQuaGioQuaDem.Text);
						bangGiaDichVu2.bangGiaQuaDem.iGioVaoSau2 = (int)Convert.ToInt16(this.txtGioVaoSau2.Text);
						bangGiaDichVu2.bangGiaQuaDem.iTruocGio = (int)Convert.ToInt16(this.txtTruocGio.Text);
						bangGiaDichVu2.bangGiaQuaDem.iTreToiDa = (int)Convert.ToInt16(this.txtTreToiDaNgayDem.Text);
						bangGiaDichVu2.bangGiaQuaDem.iTraPhongTruoc = (int)Convert.ToInt16(this.txtTraPhongTruocNgayDem.Text);
						bangGiaDichVu2.bangGiaNgayDem.bTinhLa1Ngay = Convert.ToBoolean(this.chkTinhLa1Ngay.Checked);
						bangGiaDichVu2.bangGiaNgayDem.iQuaGio = (int)Convert.ToInt16(this.txtQuaGioNgayDem.Text);
						bangGiaDichVu2.bangGiaNgayDem.bRaSauGioTraPhong = Convert.ToBoolean(this.chkRaSauGioTraPhong.Checked);
					}
					catch
					{
						bangGiaDichVu2.iThemNguoiLon = 0;
						bangGiaDichVu2.iThemTreEm = 0;
						bangGiaDichVu2.iThemGiuong = 0;
						bangGiaDichVu2.bangGiaGio.iTreToiDa = 0;
						bangGiaDichVu2.bangGiaQuaDem.iTreToiDa = 0;
						bangGiaDichVu2.bangGiaQuaDem.iTraPhongTruoc = 0;
						bangGiaDichVu2.bangGiaQuaDem.iGioVaoSau1 = 0;
						bangGiaDichVu2.bangGiaQuaDem.iQuaGio = 0;
						bangGiaDichVu2.bangGiaQuaDem.iGioVaoSau2 = 0;
						bangGiaDichVu2.bangGiaQuaDem.iTruocGio = 0;
						bangGiaDichVu2.bangGiaQuaDem.iTreToiDa = 0;
						bangGiaDichVu2.bangGiaQuaDem.iTraPhongTruoc = 0;
						bangGiaDichVu2.bangGiaNgayDem.iQuaGio = 0;
						this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
						return false;
					}
					bangGiaDichVu2.bDonGiaCuoiTuan = Convert.ToBoolean(this.chkDonGiaCuoiTuan.Checked);
					bangGiaDichVu2.bDonGiaNgayLe = Convert.ToBoolean(this.chkDonGiaNgayLe.Checked);
					bangGiaDichVu2.bBangGiaGio = Convert.ToBoolean(this.chkBangGiaGio.Checked);
					bangGiaDichVu2.bBangGiaDem = Convert.ToBoolean(this.chkBangGiaDem.Checked);
					bangGiaDichVu2.bBangGiaNgayDem = Convert.ToBoolean(this.chkBangGiaNgayDem.Checked);
					bangGiaDichVu2.bangGiaGio.bGiaNgayThuong = Convert.ToBoolean(this.rdGiaNgayThuong.Checked);
					bangGiaDichVu2.bangGiaGio.bGiaCuoiTuan = Convert.ToBoolean(this.rdGiaCuoiTuan.Checked);
					bangGiaDichVu2.bangGiaGio.bGiaNgayLe = Convert.ToBoolean(this.rdGiaNgayLe.Checked);
					bool flag7 = this.strTitle.Equals(" - THÊM MỚI");
					if (flag7)
					{
						this.readwriteData2CSV.WriteBangGiaDichVu2CSV(strFilePath, bangGiaDichVu2);
					}
					else
					{
						bool flag8 = this.strTitle.Equals(" - CHỈNH SỬA");
						if (flag8)
						{
							List<BangGiaDichVu> list = new List<BangGiaDichVu>();
							bool flag9 = File.Exists(strFilePath);
							if (flag9)
							{
								this.lstBangGiaDichVu = this.readwriteData2CSV.ReadBangGiaDichVuFromCSV(strFilePath);
								bool flag10 = this.lstBangGiaDichVu == null;
								if (flag10)
								{
									this.funcCommon.Msg("Lỗi đọc tập tin BangGiaDichVu.csv", "Lỗi");
									return false;
								}
								int num = -1;
								list = this.lstBangGiaDichVu;
								bool flag11 = this.lstBangGiaDichVu.Count > 0;
								if (flag11)
								{
									for (int i = 0; i < this.lstBangGiaDichVu.Count; i++)
									{
										bool flag12 = this.lstBangGiaDichVu[i].strTenBangGia.Equals(this.strTenBangGia);
										if (flag12)
										{
											num = i;
											break;
										}
									}
									bool flag13 = num == -1;
									if (flag13)
									{
										this.funcCommon.Msg("Không thể lưu tập tin ", "Lỗi");
										return false;
									}
									list.RemoveAt(num);
									list.Insert(num, bangGiaDichVu2);
									try
									{
										File.Delete(strFilePath);
									}
									catch
									{
										this.funcCommon.Msg("Không thể xóa ", "Lỗi");
										return false;
									}
									foreach (BangGiaDichVu bangGiaDichVu3 in this.lstBangGiaDichVu)
									{
										this.readwriteData2CSV.WriteBangGiaDichVu2CSV(strFilePath, bangGiaDichVu3);
									}
								}
							}
						}
					}
					string text = Path.Combine(CMConstant.strFolderData, this.txtTenBangGia.Text);
					string strFilePath2 = Path.Combine(text, "BangGiaGio.csv");
					string strFilePath3 = Path.Combine(text, "BangGiaQuaDem.csv");
					string strFilePath4 = Path.Combine(text, "BangGiaQuaDemPhuThuVaoSom.csv");
					string strFilePath5 = Path.Combine(text, "BangGiaQuaDemGiamTruVaoMuon.csv");
					string strFilePath6 = Path.Combine(text, "BangGiaQuaDemPhuThuRaTre.csv");
					string strFilePath7 = Path.Combine(text, "BangGiaNgayDem.csv");
					string strFilePath8 = Path.Combine(text, "BangGiaQuaDemPhuThuVaoSom.csv");
					string strFilePath9 = Path.Combine(text, "BangGiaNgayDemPhuThuRaTre.csv");
					bool flag14 = !this.funcCommon.CreatedFolder(text);
					if (flag14)
					{
						this.funcCommon.Msg("Không thể tạo thư mục " + this.txtTenBangGia.Text, "Lỗi");
						result = false;
					}
					else
					{
						bool flag15 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath2, this.dgvBangGiaGio);
						if (flag15)
						{
							this.funcCommon.Msg("Không thể lưu tập tin BangGiaGio.csv", "Lỗi");
							result = false;
						}
						else
						{
							bool flag16 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath3, this.dgvBangGiaQuaDem);
							if (flag16)
							{
								this.funcCommon.Msg("Không thể lưu tập tin BangGiaQuaDem.csv", "Lỗi");
								result = false;
							}
							else
							{
								bool flag17 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath4, this.dgvBangGiaQuaDemPhuThuVaoSom);
								if (flag17)
								{
									this.funcCommon.Msg("Không thể lưu tập tin BangGiaQuaDemPhuThuVaoSom.csv", "Lỗi");
									result = false;
								}
								else
								{
									bool flag18 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath5, this.dgvBangGiaQuaDemGiamTruVaoMuon);
									if (flag18)
									{
										this.funcCommon.Msg("Không thể lưu tập tin BangGiaQuaDemGiamTruVaoMuon.csv", "Lỗi");
										result = false;
									}
									else
									{
										bool flag19 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath6, this.dgvBangGiaQuaDemPhuThuRaTre);
										if (flag19)
										{
											this.funcCommon.Msg("Không thể lưu tập tin BangGiaQuaDemPhuThuRaTre.csv", "Lỗi");
											result = false;
										}
										else
										{
											bool flag20 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath7, this.dgvBangGiaNgayDem);
											if (flag20)
											{
												this.funcCommon.Msg("Không thể lưu tập tin BangGiaNgayDem.csv", "Lỗi");
												result = false;
											}
											else
											{
												bool flag21 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath8, this.dgvBangGiaNgayDemPhuThuVaoSom);
												if (flag21)
												{
													this.funcCommon.Msg("Không thể lưu tập tin BangGiaQuaDemPhuThuVaoSom.csv", "Lỗi");
													result = false;
												}
												else
												{
													bool flag22 = !this.readwriteData2CSV.SaveDgvToCSV(strFilePath9, this.dgvBangGiaNgayDemPhuThuRaTre);
													if (flag22)
													{
														this.funcCommon.Msg("Không thể lưu tập tin BangGiaNgayDemPhuThuRaTre.csv", "Lỗi");
														result = false;
													}
													else
													{
														result = true;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000040EC File Offset: 0x000022EC
		private void btnSaveNew_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBangGiaDichVu);
			if (!flag)
			{
				this.txtTenBangGia.Text = string.Empty;
				this.txtNguoiLonThem.Text = 0.ToString();
				this.txtTreEmTinhThem.Text = 0.ToString();
				this.txtGiuongTinhThem.Text = 0.ToString();
				bool flag2 = this.tabBangGiaDichVu.SelectedTab == this.tabPageBangGiaGio;
				if (flag2)
				{
					this.txtBGGTreToiDa.Text = 0.ToString();
				}
				this.rdPhuThuGio.Checked = true;
				this.rdPhuThuBangGia.Checked = false;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000041B4 File Offset: 0x000023B4
		private void btnSaveExit_Click(object sender, EventArgs e)
		{
			bool flag = !this.SaveData2CSV(CMConstant.strFilePathBangGiaDichVu);
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000041DE File Offset: 0x000023DE
		private void dtgBangGiaGio_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaGio, e);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000041F0 File Offset: 0x000023F0
		private void dtgBangGiaGio_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = !this.checkValidInputCell(ref this.dgvBangGiaGio, e);
			if (flag)
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004215 File Offset: 0x00002415
		private void txtNguoiLonThem_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004228 File Offset: 0x00002428
		private void txtNguoiLonThem_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004215 File Offset: 0x00002415
		private void txtTreEmTinhThem_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004250 File Offset: 0x00002450
		private void txtTreEmTinhThem_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004215 File Offset: 0x00002415
		private void txtGiuongTinhThem_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004278 File Offset: 0x00002478
		private void txtGiuongTinhThem_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004215 File Offset: 0x00002415
		private void txtTreToiDa_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000042A0 File Offset: 0x000024A0
		private void txtTreToiDa_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000214C File Offset: 0x0000034C
		private void rdGiaNgayThuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000214C File Offset: 0x0000034C
		private void rdGiaCuoiTuan_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000214C File Offset: 0x0000034C
		private void rdGiaNgayLe_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004215 File Offset: 0x00002415
		private void dgvBangGiaGio_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000042C8 File Offset: 0x000024C8
		private void dgvBangGiaGio_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004215 File Offset: 0x00002415
		private void txtTreToiDaQuaDem_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000042F0 File Offset: 0x000024F0
		private void txtTreToiDaQuaDem_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004215 File Offset: 0x00002415
		private void txtTraPhongTruocQuaDem_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004318 File Offset: 0x00002518
		private void txtTraPhongTruocQuaDem_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004215 File Offset: 0x00002415
		private void txtGioVaoSau1_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004340 File Offset: 0x00002540
		private void txtGioVaoSau1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004215 File Offset: 0x00002415
		private void txtQuaGio_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004368 File Offset: 0x00002568
		private void txtQuaGio_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004215 File Offset: 0x00002415
		private void txtGioVaoSau2_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004390 File Offset: 0x00002590
		private void txtGioVaoSau2_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004215 File Offset: 0x00002415
		private void txtTruocGio_KeyDown(object sender, KeyEventArgs e)
		{
			this.funcCommon.KeyStatus(e);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000043B8 File Offset: 0x000025B8
		private void txtTruocGio_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool nonNumberEntered = this.funcCommon.nonNumberEntered;
			if (nonNumberEntered)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000043E0 File Offset: 0x000025E0
		private void dgvBangGiaQuaDem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = !this.checkValidInputCell(ref this.dgvBangGiaQuaDem, e);
			if (flag)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004408 File Offset: 0x00002608
		private bool checkValidInputCell(ref DataGridView dataGridView, DataGridViewCellEventArgs e)
		{
			bool flag = dataGridView.Rows.Count > 0 && dataGridView != null && e.RowIndex != -1;
			if (flag)
			{
				int index = dataGridView.CurrentRow.Index;
				int columnIndex = dataGridView.CurrentCell.ColumnIndex;
				bool flag2 = !this.funcCommon.IsValidDigital(dataGridView.Rows[index].Cells[columnIndex].Value.ToString());
				if (flag2)
				{
					this.funcCommon.Msg("Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9", "Lỗi");
					dataGridView.Rows[index].Cells[columnIndex].Value = 0;
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000044DC File Offset: 0x000026DC
		private void CellClickInsertZero(ref DataGridView dataGridView, DataGridViewCellEventArgs e)
		{
			bool flag = dataGridView.Rows.Count > 0 && dataGridView != null && e.RowIndex != -1;
			if (flag)
			{
				int index = dataGridView.CurrentRow.Index;
				int columnIndex = dataGridView.CurrentCell.ColumnIndex;
				bool flag2 = dataGridView.Rows[index].Cells[columnIndex].Value.ToString() == string.Empty;
				if (flag2)
				{
					dataGridView.Rows[index].Cells[columnIndex].Value = 0;
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004586 File Offset: 0x00002786
		private void dgvBangGiaQuaDem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaQuaDem, e);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004597 File Offset: 0x00002797
		private void dgvBangGiaQuaDemPhuThuVaoSom_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaQuaDemPhuThuVaoSom, e);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000045A8 File Offset: 0x000027A8
		private void dgvBangGiaQuaDemPhuThuVaoSom_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaQuaDemPhuThuVaoSom, e);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000214C File Offset: 0x0000034C
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000045B9 File Offset: 0x000027B9
		private void dgvBangGiaQuaDemGiamTruVaoMuon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaQuaDemGiamTruVaoMuon, e);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000045CA File Offset: 0x000027CA
		private void dgvBangGiaQuaDemGiamTruVaoMuon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaQuaDemGiamTruVaoMuon, e);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000045DB File Offset: 0x000027DB
		private void dgvBangGiaQuaDemPhuThuRaTre_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaQuaDemPhuThuRaTre, e);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000045EC File Offset: 0x000027EC
		private void dgvBangGiaQuaDemPhuThuRaTre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaQuaDemPhuThuRaTre, e);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000045FD File Offset: 0x000027FD
		private void dgvBangGiaNgayDem_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaNgayDem, e);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000460E File Offset: 0x0000280E
		private void dgvBangGiaNgayDem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaNgayDem, e);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000461F File Offset: 0x0000281F
		private void dgvBangGiaNgayDemPhuThuVaoSom_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaNgayDemPhuThuVaoSom, e);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004630 File Offset: 0x00002830
		private void dgvBangGiaNgayDemPhuThuVaoSom_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaNgayDemPhuThuVaoSom, e);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004641 File Offset: 0x00002841
		private void dgvBangGiaNgayDemPhuThuRaTre_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.CellClickInsertZero(ref this.dgvBangGiaNgayDemPhuThuRaTre, e);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004652 File Offset: 0x00002852
		private void dgvBangGiaNgayDemPhuThuRaTre_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.checkValidInputCell(ref this.dgvBangGiaNgayDemPhuThuRaTre, e);
		}

		// Token: 0x0400000B RID: 11
		private List<LoaiPhong> lstLoaiPhong = new List<LoaiPhong>();

		// Token: 0x0400000C RID: 12
		private List<BangGiaDichVu> lstBangGiaDichVu = new List<BangGiaDichVu>();

		// Token: 0x0400000D RID: 13
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400000E RID: 14
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x0400000F RID: 15
		private string strTitle = string.Empty;

		// Token: 0x04000010 RID: 16
		private string strTenBangGia = string.Empty;
	}
}

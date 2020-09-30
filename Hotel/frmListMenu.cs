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
	// Token: 0x02000010 RID: 16
	public partial class frmListMenu : Form
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00015640 File Offset: 0x00013840
		public frmListMenu(string strtitle)
		{
			this.InitializeComponent();
			this.ContextMenuStrip = null;
			this.strTitle = strtitle;
			this.Text = this.strTitle;
			Label label = this.lblTitle;
			label.Text += this.strTitle.ToLower();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000156D8 File Offset: 0x000138D8
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmAddNew;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmAddNew frmAddNew = new frmAddNew(" - THÊM MỚI", string.Empty);
				frmAddNew.ShowDialog();
				this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
			}
			else
			{
				bool flag3 = this.strTitle.Equals("Loại phòng");
				if (flag3)
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmRoomType;
						if (flag4)
						{
							form2.Show();
							return;
						}
					}
					frmRoomType frmRoomType = new frmRoomType(" - THÊM MỚI", string.Empty);
					frmRoomType.ShowDialog();
					this.LoadRoomType();
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00015830 File Offset: 0x00013A30
		private void btnEdit_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				this.ContextMenuStrip = this.contextMenuStrip1;
				ListViewItem listViewItem = new ListViewItem();
				listViewItem = this.funcCommon.GetItemListView(this.lstViewMenu);
				bool flag2 = listViewItem == null;
				if (flag2)
				{
					this.ContextMenuStrip = null;
					this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
				}
				else
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmAddNew;
						if (flag3)
						{
							form.Show();
							return;
						}
					}
					frmAddNew frmAddNew = new frmAddNew(" - CHỈNH SỬA", listViewItem.Text);
					frmAddNew.ShowDialog();
					this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
				}
			}
			else
			{
				bool flag4 = this.strTitle.Equals("Loại phòng");
				if (flag4)
				{
					this.ContextMenuStrip = this.contextMenuStrip1;
					ListViewItem listViewItem2 = new ListViewItem();
					listViewItem2 = this.funcCommon.GetItemListView(this.lstViewMenu);
					bool flag5 = listViewItem2 == null;
					if (flag5)
					{
						this.ContextMenuStrip = null;
						this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
					}
					else
					{
						foreach (object obj2 in Application.OpenForms)
						{
							Form form2 = (Form)obj2;
							bool flag6 = form2 is frmRoomType;
							if (flag6)
							{
								form2.ShowDialog();
								this.LoadRoomType();
								return;
							}
						}
						frmRoomType frmRoomType = new frmRoomType(" - CHỈNH SỬA", listViewItem2.Text);
						frmRoomType.ShowDialog();
						this.LoadRoomType();
					}
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00015A40 File Offset: 0x00013C40
		private void LoadBangGiaDichVu(string strFilePath)
		{
			bool flag = File.Exists(strFilePath) && !string.IsNullOrEmpty(strFilePath);
			if (flag)
			{
				this.lstBangGiaDichVu = this.readwriteData2CSV.ReadBangGiaDichVuFromCSV(strFilePath);
				bool flag2 = this.lstBangGiaDichVu == null;
				if (flag2)
				{
					this.funcCommon.Msg("Lỗi đọc tập tin BangGiaDichVu.csv", "Lỗi");
					return;
				}
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
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
					return;
				}
			}
			this.lstViewMenu.View = View.LargeIcon;
			this.imgListIcon.ImageSize = new Size(32, 32);
			this.lstViewMenu.LargeImageList = this.imgListIcon;
			bool flag3 = this.lstViewMenu.Items.Count > 0;
			if (flag3)
			{
				this.lstViewMenu.Items.Clear();
			}
			bool flag4 = this.lstBangGiaDichVu.Count > 0;
			if (flag4)
			{
				foreach (BangGiaDichVu bangGiaDichVu in this.lstBangGiaDichVu)
				{
					this.lstViewMenu.Items.Add(bangGiaDichVu.strTenBangGia, 0);
				}
			}
			this.Disable_Button();
			this.ContextMenuStrip = null;
			bool flag5 = this.lstViewMenu.SelectedItems.Count > 0;
			if (flag5)
			{
				this.Enable_Button();
				this.ContextMenuStrip = this.contextMenuStrip1;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00015C2C File Offset: 0x00013E2C
		private void LoadRoomType()
		{
			bool flag = File.Exists(CMConstant.strFilePathLoaiPhong) && !string.IsNullOrEmpty(CMConstant.strFilePathLoaiPhong);
			if (flag)
			{
				this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(CMConstant.strFilePathLoaiPhong);
				bool flag2 = this.lstLoaiPhong == null;
				if (flag2)
				{
					this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
					return;
				}
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
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
				}
			}
			this.lstViewMenu.View = View.LargeIcon;
			this.imgListIcon.ImageSize = new Size(32, 32);
			this.lstViewMenu.LargeImageList = this.imgListIcon;
			bool flag3 = this.lstViewMenu.Items.Count > 0;
			if (flag3)
			{
				this.lstViewMenu.Items.Clear();
			}
			bool flag4 = this.lstLoaiPhong.Count > 0;
			if (flag4)
			{
				foreach (LoaiPhong loaiPhong in this.lstLoaiPhong)
				{
					this.lstViewMenu.Items.Add(loaiPhong.strTenLoaiPhong, 0);
				}
			}
			this.Disable_Button();
			this.ContextMenuStrip = null;
			bool flag5 = this.lstViewMenu.SelectedItems.Count > 0;
			if (flag5)
			{
				this.Enable_Button();
				this.ContextMenuStrip = this.contextMenuStrip1;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00015E24 File Offset: 0x00014024
		private void Enable_Button()
		{
			this.btnDel.Enabled = true;
			this.btnEdit.Enabled = true;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00015E41 File Offset: 0x00014041
		private void Disable_Button()
		{
			this.btnDel.Enabled = false;
			this.btnEdit.Enabled = false;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00015E60 File Offset: 0x00014060
		private void frmListMenu_Load(object sender, EventArgs e)
		{
			this.Disable_Button();
			bool flag = this.lstViewMenu.SelectedItems.Count > 0;
			if (flag)
			{
				this.Enable_Button();
			}
			bool flag2 = this.strTitle.Equals("Bảng giá");
			if (flag2)
			{
				this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
			}
			else
			{
				bool flag3 = this.strTitle.Equals("Loại phòng");
				if (flag3)
				{
					this.LoadRoomType();
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00015ED8 File Offset: 0x000140D8
		private void btnDel_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				this.DeletedBangGia(CMConstant.strFilePathBangGiaDichVu);
				this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
			}
			else
			{
				bool flag2 = this.strTitle.Equals("Loại phòng");
				if (flag2)
				{
					this.DeletedRoomType(CMConstant.strFilePathLoaiPhong);
					this.LoadRoomType();
				}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00015F40 File Offset: 0x00014140
		private void DeletedBangGia(string strPathFileName)
		{
			int index = 0;
			this.ContextMenuStrip = this.contextMenuStrip1;
			ListViewItem listViewItem = new ListViewItem();
			listViewItem = this.funcCommon.GetItemListView(this.lstViewMenu);
			bool flag = listViewItem == null;
			if (flag)
			{
				this.ContextMenuStrip = null;
				this.funcCommon.Msg("Vui lòng chọn 1 bảng giá.", "Lỗi");
			}
			else
			{
				List<BangGiaDichVu> list = new List<BangGiaDichVu>();
				string path = Path.Combine(CMConstant.strFolderData, listViewItem.Text);
				bool flag2 = Directory.Exists(path);
				if (flag2)
				{
					try
					{
						Directory.Delete(path, true);
					}
					catch (Exception ex)
					{
						this.funcCommon.Msg("Không thể xóa " + listViewItem.Text + "\r\n " + ex.Message, "Lỗi");
						return;
					}
					bool flag3 = File.Exists(strPathFileName) && !string.IsNullOrEmpty(strPathFileName);
					if (flag3)
					{
						this.lstBangGiaDichVu = this.readwriteData2CSV.ReadBangGiaDichVuFromCSV(strPathFileName);
						bool flag4 = this.lstBangGiaDichVu == null;
						if (flag4)
						{
							this.funcCommon.Msg("Lỗi đọc tập tin BangGiaDichVu.csv", "Lỗi");
						}
						else
						{
							list = this.lstBangGiaDichVu;
							bool flag5 = this.lstBangGiaDichVu.Count > 0;
							if (flag5)
							{
								for (int i = 0; i < this.lstBangGiaDichVu.Count; i++)
								{
									bool flag6 = this.lstBangGiaDichVu[i].strTenBangGia.Equals(listViewItem.Text);
									if (flag6)
									{
										index = i;
										break;
									}
								}
								list.RemoveAt(index);
								File.Delete(strPathFileName);
								foreach (BangGiaDichVu bangGiaDichVu in list)
								{
									this.readwriteData2CSV.WriteBangGiaDichVu2CSV(strPathFileName, bangGiaDichVu);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00016140 File Offset: 0x00014340
		private void DeletedRoomType(string strPathFileName)
		{
			int index = 0;
			this.ContextMenuStrip = this.contextMenuStrip1;
			ListViewItem listViewItem = new ListViewItem();
			listViewItem = this.funcCommon.GetItemListView(this.lstViewMenu);
			bool flag = listViewItem == null;
			if (flag)
			{
				this.ContextMenuStrip = null;
				this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
			}
			else
			{
				List<LoaiPhong> list = new List<LoaiPhong>();
				bool flag2 = File.Exists(strPathFileName) && !string.IsNullOrEmpty(strPathFileName);
				if (flag2)
				{
					this.lstLoaiPhong = this.readwriteData2CSV.ReadLoaiPhongFromCSV(strPathFileName);
					bool flag3 = this.lstLoaiPhong == null;
					if (flag3)
					{
						this.funcCommon.Msg("Lỗi đọc tập tin LoaiPhong.csv", "Lỗi");
					}
					else
					{
						list = this.lstLoaiPhong;
						bool flag4 = this.lstLoaiPhong.Count > 0;
						if (flag4)
						{
							for (int i = 0; i < this.lstLoaiPhong.Count; i++)
							{
								bool flag5 = this.lstLoaiPhong[i].strTenLoaiPhong.Equals(listViewItem.Text);
								if (flag5)
								{
									index = i;
									break;
								}
							}
							list.RemoveAt(index);
							File.Delete(strPathFileName);
							foreach (LoaiPhong loaiPhong in list)
							{
								this.readwriteData2CSV.WriteLoaiPhong2CSV(strPathFileName, loaiPhong);
							}
						}
					}
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000162CC File Offset: 0x000144CC
		private void cmThemMoi_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					bool flag2 = form is frmAddNew;
					if (flag2)
					{
						form.Show();
						return;
					}
				}
				frmAddNew frmAddNew = new frmAddNew(" - THÊM MỚI", string.Empty);
				frmAddNew.Show();
			}
			else
			{
				bool flag3 = this.strTitle.Equals("Loại phòng");
				if (flag3)
				{
					foreach (object obj2 in Application.OpenForms)
					{
						Form form2 = (Form)obj2;
						bool flag4 = form2 is frmRoomType;
						if (flag4)
						{
							form2.Show();
							return;
						}
					}
					frmRoomType frmRoomType = new frmRoomType(" - THÊM MỚI", string.Empty);
					frmRoomType.ShowDialog();
					this.LoadRoomType();
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00016414 File Offset: 0x00014614
		private void cmChinhSua_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				this.ContextMenuStrip = this.contextMenuStrip1;
				ListViewItem listViewItem = new ListViewItem();
				listViewItem = this.funcCommon.GetItemListView(this.lstViewMenu);
				bool flag2 = listViewItem == null;
				if (flag2)
				{
					this.ContextMenuStrip = null;
					this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
				}
				else
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmAddNew;
						if (flag3)
						{
							form.Show();
							return;
						}
					}
					frmAddNew frmAddNew = new frmAddNew(" - CHỈNH SỬA", listViewItem.Text);
					frmAddNew.Show();
				}
			}
			else
			{
				bool flag4 = this.strTitle.Equals("Loại phòng");
				if (flag4)
				{
					this.ContextMenuStrip = this.contextMenuStrip1;
					ListViewItem listViewItem2 = new ListViewItem();
					listViewItem2 = this.funcCommon.GetItemListView(this.lstViewMenu);
					bool flag5 = listViewItem2 == null;
					if (flag5)
					{
						this.ContextMenuStrip = null;
						this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
					}
					else
					{
						foreach (object obj2 in Application.OpenForms)
						{
							Form form2 = (Form)obj2;
							bool flag6 = form2 is frmRoomType;
							if (flag6)
							{
								form2.ShowDialog();
								this.LoadRoomType();
								return;
							}
						}
						frmRoomType frmRoomType = new frmRoomType(" - CHỈNH SỬA", listViewItem2.Text);
						frmRoomType.ShowDialog();
						this.LoadRoomType();
					}
				}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00016618 File Offset: 0x00014818
		private void lstViewMenu_ItemActivate(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				this.ContextMenuStrip = this.contextMenuStrip1;
				ListViewItem listViewItem = new ListViewItem();
				listViewItem = this.funcCommon.GetItemListView(this.lstViewMenu);
				bool flag2 = listViewItem == null;
				if (flag2)
				{
					this.ContextMenuStrip = null;
					this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
				}
				else
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmAddNew;
						if (flag3)
						{
							form.Show();
							return;
						}
					}
					frmAddNew frmAddNew = new frmAddNew(" - CHỈNH SỬA", listViewItem.Text);
					frmAddNew.ShowDialog();
					this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
				}
			}
			else
			{
				bool flag4 = this.strTitle.Equals("Loại phòng");
				if (flag4)
				{
					this.ContextMenuStrip = this.contextMenuStrip1;
					ListViewItem listViewItem2 = new ListViewItem();
					listViewItem2 = this.funcCommon.GetItemListView(this.lstViewMenu);
					bool flag5 = listViewItem2 == null;
					if (flag5)
					{
						this.ContextMenuStrip = null;
						this.funcCommon.Msg("Vui lòng chọn 1 loại phòng.", "Lỗi");
					}
					else
					{
						foreach (object obj2 in Application.OpenForms)
						{
							Form form2 = (Form)obj2;
							bool flag6 = form2 is frmRoomType;
							if (flag6)
							{
								form2.ShowDialog();
								this.LoadRoomType();
								return;
							}
						}
						frmRoomType frmRoomType = new frmRoomType(" - CHỈNH SỬA", listViewItem2.Text);
						frmRoomType.ShowDialog();
						this.LoadRoomType();
					}
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00016828 File Offset: 0x00014A28
		private void cmXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.strTitle.Equals("Bảng giá");
			if (flag)
			{
				this.DeletedBangGia(CMConstant.strFilePathBangGiaDichVu);
				this.LoadBangGiaDichVu(CMConstant.strFilePathBangGiaDichVu);
			}
			else
			{
				bool flag2 = this.strTitle.Equals("Loại phòng");
				if (flag2)
				{
					this.DeletedRoomType(CMConstant.strFilePathLoaiPhong);
					this.LoadRoomType();
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00016890 File Offset: 0x00014A90
		private void lstViewMenu_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Disable_Button();
			this.ContextMenuStrip = null;
			bool flag = this.lstViewMenu.SelectedItems.Count > 0;
			if (flag)
			{
				this.Enable_Button();
				this.ContextMenuStrip = this.contextMenuStrip1;
			}
		}

		// Token: 0x04000158 RID: 344
		private string strTitle = string.Empty;

		// Token: 0x04000159 RID: 345
		private List<LoaiPhong> lstLoaiPhong = new List<LoaiPhong>();

		// Token: 0x0400015A RID: 346
		private List<BangGiaDichVu> lstBangGiaDichVu = new List<BangGiaDichVu>();

		// Token: 0x0400015B RID: 347
		private ReadWriteData2CSV readwriteData2CSV = new ReadWriteData2CSV();

		// Token: 0x0400015C RID: 348
		private FunctionCommon funcCommon = new FunctionCommon();
	}
}

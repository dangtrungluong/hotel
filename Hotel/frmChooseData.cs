using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;

namespace Hotel
{
	// Token: 0x02000008 RID: 8
	public partial class frmChooseData : Form
	{
		// Token: 0x0600007A RID: 122 RVA: 0x0000C200 File Offset: 0x0000A400
		public frmChooseData(List<NhomMatHang> lstnhomMatHang, int itype)
		{
			this.InitializeComponent();
			this.lstNhomMatHang = lstnhomMatHang;
			this.iTypes = itype;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000C264 File Offset: 0x0000A464
		public frmChooseData(List<KhuVuc> lstkhuvuc, int itype)
		{
			this.InitializeComponent();
			this.lstKhuVuc = lstkhuvuc;
			this.iTypes = itype;
			this.lblTitle.Text = "Mời bạn chọn bàn khu vực";
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000C2DC File Offset: 0x0000A4DC
		public frmChooseData(DataTable dt, int itype)
		{
			this.InitializeComponent();
			this.dataTable = dt.Copy();
			this.iTypes = itype;
			this.lblTitle.Text = "Mời bạn chọn nhóm khách hàng";
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C358 File Offset: 0x0000A558
		private void frmChooseData_Load(object sender, EventArgs e)
		{
			this.Reload_Data();
			this.btnChapNhan.Focus();
			this.btnChapNhan.Enabled = true;
			bool flag = this.lstViewChoose.SelectedItems.Count == 0;
			if (flag)
			{
				this.btnChapNhan.Enabled = false;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		private void Reload_Data()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(CMConstant.strFilePathIcon);
			foreach (FileInfo fileInfo in directoryInfo.GetFiles())
			{
				try
				{
					this.imgLstChoose.Images.Add(Image.FromFile(fileInfo.FullName));
				}
				catch
				{
					this.funcCommon.Msg("Không tìm thấy icon", "Lỗi");
				}
			}
			this.lstViewChoose.View = View.SmallIcon;
			this.imgLstChoose.ImageSize = new Size(32, 32);
			this.lstViewChoose.SmallImageList = this.imgLstChoose;
			bool flag = this.iTypes == 100;
			if (flag)
			{
				bool flag2 = this.lstNhomMatHang.Count > 0;
				if (flag2)
				{
					bool flag3 = this.lstViewChoose.Items.Count > 0;
					if (flag3)
					{
						this.lstViewChoose.Items.Clear();
					}
					foreach (NhomMatHang nhomMatHang in this.lstNhomMatHang)
					{
						this.lstViewChoose.Items.Add(nhomMatHang.strTenNhomMatHang, 0);
					}
				}
			}
			else
			{
				bool flag4 = this.iTypes == 101;
				if (flag4)
				{
					bool flag5 = this.lstKhuVuc.Count > 0;
					if (flag5)
					{
						bool flag6 = this.lstViewChoose.Items.Count > 0;
						if (flag6)
						{
							this.lstViewChoose.Items.Clear();
						}
						foreach (KhuVuc khuVuc in this.lstKhuVuc)
						{
							this.lstViewChoose.Items.Add(khuVuc.strTenKhuVuc, 1);
						}
					}
				}
				else
				{
					bool flag7 = this.iTypes == 102;
					if (flag7)
					{
						bool flag8 = this.dataTable.Rows.Count > 0;
						if (flag8)
						{
							bool flag9 = this.lstViewChoose.Items.Count > 0;
							if (flag9)
							{
								this.lstViewChoose.Items.Clear();
							}
							foreach (object obj in this.dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								this.lstViewChoose.Items.Add(dataRow["Tên nhóm khách hàng"].ToString(), 2);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000041AA File Offset: 0x000023AA
		private void btnHuyBo_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		private void lstViewNhomMatHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.lstViewChoose.SelectedItems.Count > 0;
			if (flag)
			{
				this.btnChapNhan.Enabled = true;
			}
			else
			{
				this.btnChapNhan.Enabled = false;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		private void btnChapNhan_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewChoose.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewChoose.SelectedItems[0];
				bool flag2 = this.iTypes == 100;
				if (flag2)
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmMatHang;
						if (flag3)
						{
							form.Show();
							return;
						}
					}
					base.Hide();
					frmMatHang frmMatHang = new frmMatHang(" - THÊM MỚI", listViewItem.Text, this.lstNhomMatHang);
					frmMatHang.ShowDialog();
				}
				else
				{
					bool flag4 = this.iTypes == 101;
					if (flag4)
					{
						foreach (object obj2 in Application.OpenForms)
						{
							Form form2 = (Form)obj2;
							bool flag5 = form2 is frmTable;
							if (flag5)
							{
								form2.Show();
								return;
							}
						}
						base.Hide();
						frmTable frmTable = new frmTable(" - THÊM MỚI", listViewItem.Text);
						frmTable.ShowDialog();
					}
					else
					{
						bool flag6 = this.iTypes == 102;
						if (flag6)
						{
							foreach (object obj3 in Application.OpenForms)
							{
								Form form3 = (Form)obj3;
								bool flag7 = form3 is frmCustomer;
								if (flag7)
								{
									form3.Show();
									return;
								}
							}
							base.Hide();
							frmCustomer frmCustomer = new frmCustomer(" - THÊM MỚI", listViewItem.Text);
							frmCustomer.ShowDialog();
						}
					}
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn 1 loại mặt hàng.", "Lỗi");
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000C930 File Offset: 0x0000AB30
		private void lstViewNhomMatHang_ItemActivate(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = this.lstViewChoose.SelectedItems.Count > 0;
			if (flag)
			{
				listViewItem = this.lstViewChoose.SelectedItems[0];
				bool flag2 = this.iTypes == 100;
				if (flag2)
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						bool flag3 = form is frmMatHang;
						if (flag3)
						{
							form.Show();
							return;
						}
					}
					base.Hide();
					frmMatHang frmMatHang = new frmMatHang(" - THÊM MỚI", listViewItem.Text, this.lstNhomMatHang);
					frmMatHang.ShowDialog();
				}
				else
				{
					bool flag4 = this.iTypes == 101;
					if (flag4)
					{
						foreach (object obj2 in Application.OpenForms)
						{
							Form form2 = (Form)obj2;
							bool flag5 = form2 is frmTable;
							if (flag5)
							{
								form2.Show();
								return;
							}
						}
						base.Hide();
						frmTable frmTable = new frmTable(" - THÊM MỚI", listViewItem.Text);
						frmTable.ShowDialog();
					}
					else
					{
						bool flag6 = this.iTypes == 102;
						if (flag6)
						{
							foreach (object obj3 in Application.OpenForms)
							{
								Form form3 = (Form)obj3;
								bool flag7 = form3 is frmCustomer;
								if (flag7)
								{
									form3.Show();
									return;
								}
							}
							base.Hide();
							frmCustomer frmCustomer = new frmCustomer(" - THÊM MỚI", listViewItem.Text);
							frmCustomer.ShowDialog();
						}
					}
				}
			}
			else
			{
				this.funcCommon.Msg("Vui lòng chọn 1 loại mặt hàng.", "Lỗi");
			}
		}

		// Token: 0x040000A9 RID: 169
		private FunctionCommon funcCommon = new FunctionCommon();

		// Token: 0x040000AA RID: 170
		private List<NhomMatHang> lstNhomMatHang = new List<NhomMatHang>();

		// Token: 0x040000AB RID: 171
		private List<KhuVuc> lstKhuVuc = new List<KhuVuc>();

		// Token: 0x040000AC RID: 172
		private DataTable dataTable = new DataTable();

		// Token: 0x040000AD RID: 173
		private int iTypes = 0;
	}
}

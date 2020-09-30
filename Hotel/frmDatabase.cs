using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hotel.Common;

namespace Hotel
{
	// Token: 0x0200000E RID: 14
	public partial class frmDatabase : Form
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00012F4C File Offset: 0x0001114C
		public frmDatabase()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00012F6F File Offset: 0x0001116F
		private void frmMain_Load(object sender, EventArgs e)
		{
			this.rdReOpenData.Checked = true;
			this.chkDonotShow.Checked = false;
			this.btnSellect.Enabled = false;
			this.btnCancel.Enabled = true;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00012FA8 File Offset: 0x000111A8
		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.DefaultExt = "FDB";
			this.openFileDialog1.Filter = "FDB files (*.FDB)|*.FDB";
			this.folderBrowserDialog1.ShowNewFolderButton = true;
			this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
			DialogResult dialogResult = this.openFileDialog1.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				string fileName = this.openFileDialog1.FileName;
				this.strFileName = Path.GetFileName(fileName);
				this.strFolderName = fileName.Substring(0, fileName.Length - this.strFileName.Length - 1);
				try
				{
					bool flag2 = string.IsNullOrEmpty(this.strFileName) || string.IsNullOrEmpty(this.strFolderName);
					if (flag2)
					{
						this.func.Msg("Không thể mở được tập tin.", "Lỗi");
					}
					else
					{
						bool flag3 = this.dtgData.Rows.Count > 0;
						if (flag3)
						{
							int count = this.dtgData.Rows.Count;
							this.dtgData.Rows.Add();
							this.dtgData.Rows[count].Cells[0].Value = this.strFileName;
							this.dtgData.Rows[count].Cells[1].Value = this.strFolderName;
						}
						else
						{
							this.dtgData.Rows.Add();
							this.dtgData.Rows[0].Cells[0].Value = this.strFileName;
							this.dtgData.Rows[0].Cells[1].Value = this.strFolderName;
						}
						int rowIndex = this.dtgData.CurrentCell.RowIndex;
						this.btnSellect.Enabled = true;
						this.dtgData.Rows[rowIndex].Selected = true;
					}
				}
				catch
				{
					this.func.Msg("Không thể mở được tập tin.", "Lỗi");
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000131EC File Offset: 0x000113EC
		private void dtgData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = this.dtgData.Rows.Count > 0;
			if (flag)
			{
				int rowIndex = this.dtgData.CurrentCell.RowIndex;
				this.dtgData.Rows[rowIndex].Selected = true;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0001323C File Offset: 0x0001143C
		private void btnOpenFile_MouseMove(object sender, MouseEventArgs e)
		{
			this.btnOpenFile.ForeColor = Color.Blue;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00013250 File Offset: 0x00011450
		private void btnOpenFile_MouseLeave(object sender, EventArgs e)
		{
			this.btnOpenFile.ForeColor = Color.Black;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00013264 File Offset: 0x00011464
		private void btnEditFile_MouseLeave(object sender, EventArgs e)
		{
			this.btnEditFile.ForeColor = Color.Black;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00013278 File Offset: 0x00011478
		private void btnEditFile_MouseMove(object sender, MouseEventArgs e)
		{
			this.btnEditFile.ForeColor = Color.Blue;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001328C File Offset: 0x0001148C
		private void btnDeletedFile_MouseLeave(object sender, EventArgs e)
		{
			this.btnDeletedFile.ForeColor = Color.Black;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000132A0 File Offset: 0x000114A0
		private void btnDeletedFile_MouseMove(object sender, MouseEventArgs e)
		{
			this.btnDeletedFile.ForeColor = Color.Blue;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000214C File Offset: 0x0000034C
		private void btnSellect_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000125 RID: 293
		private FunctionCommon func = new FunctionCommon();

		// Token: 0x04000126 RID: 294
		private string strFileName;

		// Token: 0x04000127 RID: 295
		private string strFolderName;
	}
}

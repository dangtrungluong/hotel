using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hotel.Common
{
	// Token: 0x0200001F RID: 31
	public class FunctionCommon
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x000326F0 File Offset: 0x000308F0
		public void dgvRefresh(ref DataGridView dataGridView)
		{
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.ClearSelection();
			bool flag = dataGridView.Columns.Count > 1;
			if (flag)
			{
				bool flag2 = dataGridView.Columns[1].HeaderText.Equals("Diễn giải");
				if (flag2)
				{
					dataGridView.Columns[1].Width = 80;
				}
				bool flag3 = dataGridView.Columns[0].HeaderText.Equals("Tên sản phẩm") || dataGridView.Columns[0].HeaderText.Equals("Mặt hàng");
				if (flag3)
				{
					dataGridView.Columns[0].Width = 120;
				}
				else
				{
					bool flag4 = dataGridView.Columns[0].HeaderText.Equals("ID");
					if (flag4)
					{
						dataGridView.Columns[0].Width = 40;
					}
				}
			}
			for (int i = 0; i < dataGridView.ColumnCount; i++)
			{
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
			for (int j = 0; j < dataGridView.Rows.Count; j++)
			{
				DataGridViewRow dataGridViewRow = dataGridView.Rows[j];
				bool flag5 = j % 2 == 0;
				if (flag5)
				{
					dataGridViewRow.DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0003288C File Offset: 0x00030A8C
		public void dgvRefreshAll(ref DataGridView dataGridView1, ref DataGridView dataGridView2, ref DataGridView dataGridView3, ref DataGridView dataGridView4, ref DataGridView dataGridView5, ref DataGridView dataGridView6, ref DataGridView dataGridView7, ref DataGridView dataGridView8)
		{
			DataGridView[] array = new DataGridView[]
			{
				dataGridView1,
				dataGridView2,
				dataGridView3,
				dataGridView4,
				dataGridView5,
				dataGridView6,
				dataGridView7,
				dataGridView8
			};
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ClearSelection();
				array[i].AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
				array[i].AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
				array[i].ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				array[i].Columns[0].Width = 40;
				bool flag = array[i].Columns.Count > 1;
				if (flag)
				{
					bool flag2 = array[i].Columns[1].HeaderText.Equals("Diễn giải");
					if (flag2)
					{
						array[i].Columns[1].Width = 80;
					}
				}
			}
			for (int j = 0; j < dataGridView1.ColumnCount; j++)
			{
				dataGridView1.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
			for (int k = 2; k < array.Length; k++)
			{
				for (int l = 0; l < array[2].ColumnCount; l++)
				{
					array[k].Columns[l].SortMode = DataGridViewColumnSortMode.NotSortable;
				}
			}
			for (int m = 0; m < dataGridView1.Rows.Count; m++)
			{
				DataGridViewRow[] array2 = new DataGridViewRow[]
				{
					dataGridView1.Rows[m],
					dataGridView2.Rows[m]
				};
				bool flag3 = m % 2 == 0;
				if (flag3)
				{
					for (int n = 0; n < array2.Length; n++)
					{
						array2[n].DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
					}
				}
			}
			for (int num = 0; num < dataGridView3.Rows.Count; num++)
			{
				DataGridViewRow[] array3 = new DataGridViewRow[]
				{
					dataGridView3.Rows[num],
					dataGridView4.Rows[num],
					dataGridView5.Rows[num],
					dataGridView6.Rows[num],
					dataGridView7.Rows[num],
					dataGridView8.Rows[num]
				};
				bool flag4 = num % 2 == 0;
				if (flag4)
				{
					for (int num2 = 0; num2 < array3.Length; num2++)
					{
						array3[num2].DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
					}
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00032B7C File Offset: 0x00030D7C
		public bool CreatedFolder(string strPath)
		{
			bool flag = !Directory.Exists(strPath);
			if (flag)
			{
				try
				{
					Directory.CreateDirectory(strPath);
				}
				catch
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00032BC0 File Offset: 0x00030DC0
		public void KeyStatus(KeyEventArgs e)
		{
			this.nonNumberEntered = false;
			bool flag = e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9;
			if (flag)
			{
				bool flag2 = e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9;
				if (flag2)
				{
					bool flag3 = e.KeyCode != Keys.Back;
					if (flag3)
					{
						this.nonNumberEntered = true;
					}
				}
			}
			bool flag4 = Control.ModifierKeys == Keys.Shift;
			if (flag4)
			{
				this.nonNumberEntered = true;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00032C41 File Offset: 0x00030E41
		public void addTabPage(TabControl tabControl1, TabPage tabPage)
		{
			tabControl1.TabPages.Add(tabPage);
			tabControl1.SelectedTab = tabPage;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00032C5C File Offset: 0x00030E5C
		public void Msg(string strMsg, string strType)
		{
			if (!(strType == "Thông tin"))
			{
				if (!(strType == "Lỗi"))
				{
					if (strType == "Cảnh báo")
					{
						MessageBox.Show(strMsg, strType, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					MessageBox.Show(strMsg, strType, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show(strMsg, strType, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00032CC0 File Offset: 0x00030EC0
		public ListViewItem GetItemListView(ListView listView)
		{
			ListViewItem listViewItem = new ListViewItem();
			bool flag = listView.SelectedItems.Count > 0;
			ListViewItem result;
			if (flag)
			{
				listViewItem = listView.SelectedItems[0];
				result = listViewItem;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00032D04 File Offset: 0x00030F04
		public string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00032D28 File Offset: 0x00030F28
		public string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00032D4C File Offset: 0x00030F4C
		public void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = true)
		{
			using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(stream, objectToWrite);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00032D9C File Offset: 0x00030F9C
		public T ReadFromBinaryFile<T>(string filePath)
		{
			T result;
			using (Stream stream = File.Open(filePath, FileMode.Open))
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				result = (T)((object)binaryFormatter.Deserialize(stream));
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00032DE4 File Offset: 0x00030FE4
		public bool IsValidDigital(string value)
		{
			return Regex.IsMatch(value, "^[0-9]+$");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00032E04 File Offset: 0x00031004
		public DataTable readCSV(string filePath)
		{
			DataTable result;
			try
			{
				DataTable dataTable = new DataTable();
				using (StreamReader streamReader = new StreamReader(filePath))
				{
					string text = streamReader.ReadLine();
					string[] array = text.Split(new char[]
					{
						','
					});
					foreach (string text2 in array)
					{
						dataTable.Columns.Add(text2.Trim());
					}
					DataRow dataRow = dataTable.NewRow();
					while (streamReader.Peek() >= 0)
					{
						text = streamReader.ReadLine();
						array = text.Split(new char[]
						{
							','
						});
						DataRowCollection rows = dataTable.Rows;
						object[] values = array;
						rows.Add(values);
					}
				}
				result = dataTable;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00032EF0 File Offset: 0x000310F0
		public bool ShowMsg(int iErrorCode, string FileName)
		{
			bool flag = iErrorCode == 2;
			bool result;
			if (flag)
			{
				this.Msg("Không tìm thấy tập tin " + FileName, "Lỗi");
				result = false;
			}
			else
			{
				bool flag2 = iErrorCode == -1;
				if (flag2)
				{
					this.Msg("Lỗi đọc tập tin " + FileName, "Lỗi");
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0400047A RID: 1146
		public bool nonNumberEntered = false;
	}
}

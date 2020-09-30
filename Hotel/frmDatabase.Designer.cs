namespace Hotel
{
	// Token: 0x0200000E RID: 14
	public partial class frmDatabase : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x000132B4 File Offset: 0x000114B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000132EC File Offset: 0x000114EC
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.rdCreateNewData = new global::System.Windows.Forms.RadioButton();
			this.rdReOpenData = new global::System.Windows.Forms.RadioButton();
			this.dtgData = new global::System.Windows.Forms.DataGridView();
			this.DBName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FilePath = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chkDonotShow = new global::System.Windows.Forms.CheckBox();
			this.tableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSellect = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.btnOpenFile = new global::System.Windows.Forms.Button();
			this.btnEditFile = new global::System.Windows.Forms.Button();
			this.btnDeletedFile = new global::System.Windows.Forms.Button();
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgData).BeginInit();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.BackColor = global::System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(-1, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(776, 56);
			this.tableLayoutPanel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.White;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(770, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tạo dữ liệu mới hoặc mở dữ liệu đã có";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.rdCreateNewData.AutoSize = true;
			this.rdCreateNewData.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdCreateNewData.Location = new global::System.Drawing.Point(7, 63);
			this.rdCreateNewData.Name = "rdCreateNewData";
			this.rdCreateNewData.Size = new global::System.Drawing.Size(478, 22);
			this.rdCreateNewData.TabIndex = 1;
			this.rdCreateNewData.Text = "Tạo dữ liệu trắng( khi bạn muốn tạo dữ liệu để sử dụng cho riêng bạn)";
			this.rdCreateNewData.UseVisualStyleBackColor = true;
			this.rdReOpenData.AutoSize = true;
			this.rdReOpenData.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rdReOpenData.Location = new global::System.Drawing.Point(7, 97);
			this.rdReOpenData.Name = "rdReOpenData";
			this.rdReOpenData.Size = new global::System.Drawing.Size(413, 22);
			this.rdReOpenData.TabIndex = 2;
			this.rdReOpenData.Text = "Mở lại dữ liệu demo hoặc dữ liệu đã mở( nháy đúp để chọn)";
			this.rdReOpenData.UseVisualStyleBackColor = true;
			this.dtgData.AllowUserToAddRows = false;
			this.dtgData.AllowUserToDeleteRows = false;
			this.dtgData.AllowUserToResizeColumns = false;
			this.dtgData.AllowUserToResizeRows = false;
			this.dtgData.BackgroundColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgData.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.DBName,
				this.FilePath
			});
			this.dtgData.Location = new global::System.Drawing.Point(7, 127);
			this.dtgData.MultiSelect = false;
			this.dtgData.Name = "dtgData";
			this.dtgData.ReadOnly = true;
			this.dtgData.RowHeadersVisible = false;
			this.dtgData.RowTemplate.DefaultCellStyle.SelectionForeColor = global::System.Drawing.Color.Blue;
			this.dtgData.RowTemplate.Height = 25;
			this.dtgData.Size = new global::System.Drawing.Size(759, 233);
			this.dtgData.TabIndex = 3;
			this.dtgData.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgData_CellMouseClick);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DBName.DefaultCellStyle = dataGridViewCellStyle2;
			this.DBName.HeaderText = "Tên CSDL";
			this.DBName.Name = "DBName";
			this.DBName.ReadOnly = true;
			this.DBName.Width = 200;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FilePath.DefaultCellStyle = dataGridViewCellStyle3;
			this.FilePath.HeaderText = "Đường dẫn";
			this.FilePath.Name = "FilePath";
			this.FilePath.ReadOnly = true;
			this.FilePath.Width = 549;
			this.chkDonotShow.AutoSize = true;
			this.chkDonotShow.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chkDonotShow.Location = new global::System.Drawing.Point(7, 387);
			this.chkDonotShow.Name = "chkDonotShow";
			this.chkDonotShow.Size = new global::System.Drawing.Size(155, 20);
			this.chkDonotShow.TabIndex = 4;
			this.chkDonotShow.Text = "Không hiển thị lần sau";
			this.chkDonotShow.UseVisualStyleBackColor = true;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnSellect, 0, 0);
			this.tableLayoutPanel3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel3.Location = new global::System.Drawing.Point(559, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.Size = new global::System.Drawing.Size(211, 39);
			this.tableLayoutPanel3.TabIndex = 0;
			this.btnCancel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(108, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(100, 33);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Hủy bỏ";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnSellect.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnSellect.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSellect.Location = new global::System.Drawing.Point(3, 3);
			this.btnSellect.Name = "btnSellect";
			this.btnSellect.Size = new global::System.Drawing.Size(99, 33);
			this.btnSellect.TabIndex = 0;
			this.btnSellect.Text = "Chọn";
			this.btnSellect.UseVisualStyleBackColor = true;
			this.btnSellect.Click += new global::System.EventHandler(this.btnSellect_Click);
			this.tableLayoutPanel2.BackColor = global::System.Drawing.Color.White;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(-1, 421);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(773, 45);
			this.tableLayoutPanel2.TabIndex = 5;
			this.btnOpenFile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFile.Location = new global::System.Drawing.Point(493, 96);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new global::System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 6;
			this.btnOpenFile.Text = "Mở file";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new global::System.EventHandler(this.btnOpenFile_Click);
			this.btnOpenFile.MouseLeave += new global::System.EventHandler(this.btnOpenFile_MouseLeave);
			this.btnOpenFile.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.btnOpenFile_MouseMove);
			this.btnEditFile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnEditFile.Location = new global::System.Drawing.Point(585, 96);
			this.btnEditFile.Name = "btnEditFile";
			this.btnEditFile.Size = new global::System.Drawing.Size(75, 23);
			this.btnEditFile.TabIndex = 7;
			this.btnEditFile.Text = "Sửa";
			this.btnEditFile.UseVisualStyleBackColor = true;
			this.btnEditFile.MouseLeave += new global::System.EventHandler(this.btnEditFile_MouseLeave);
			this.btnEditFile.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.btnEditFile_MouseMove);
			this.btnDeletedFile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletedFile.Location = new global::System.Drawing.Point(681, 96);
			this.btnDeletedFile.Name = "btnDeletedFile";
			this.btnDeletedFile.Size = new global::System.Drawing.Size(75, 23);
			this.btnDeletedFile.TabIndex = 8;
			this.btnDeletedFile.Text = "Xóa";
			this.btnDeletedFile.UseVisualStyleBackColor = true;
			this.btnDeletedFile.MouseLeave += new global::System.EventHandler(this.btnDeletedFile_MouseLeave);
			this.btnDeletedFile.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.btnDeletedFile_MouseMove);
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(768, 468);
			base.Controls.Add(this.btnDeletedFile);
			base.Controls.Add(this.btnEditFile);
			base.Controls.Add(this.btnOpenFile);
			base.Controls.Add(this.tableLayoutPanel2);
			base.Controls.Add(this.chkDonotShow);
			base.Controls.Add(this.dtgData);
			base.Controls.Add(this.rdReOpenData);
			base.Controls.Add(this.rdCreateNewData);
			base.Controls.Add(this.tableLayoutPanel1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(784, 529);
			base.MinimizeBox = false;
			base.Name = "frmDatabase";
			this.Text = "Dữ liệu chương trình";
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgData).EndInit();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000128 RID: 296
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.RadioButton rdCreateNewData;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.RadioButton rdReOpenData;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.DataGridView dtgData;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.CheckBox chkDonotShow;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Button btnSellect;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.Button btnOpenFile;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Button btnEditFile;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Button btnDeletedFile;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.DataGridViewTextBoxColumn DBName;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
	}
}

namespace Hotel
{
	// Token: 0x02000010 RID: 16
	public partial class frmListMenu : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x000168DC File Offset: 0x00014ADC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00016914 File Offset: 0x00014B14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hotel.frmListMenu));
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.btnEdit = new global::System.Windows.Forms.Button();
			this.btnDel = new global::System.Windows.Forms.Button();
			this.btnAddNew = new global::System.Windows.Forms.Button();
			this.lstViewMenu = new global::System.Windows.Forms.ListView();
			this.tableLayoutPanel4 = new global::System.Windows.Forms.TableLayoutPanel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.imgListIcon = new global::System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmThemMoi = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmXoa = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmChinhSua = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lstViewMenu, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 61.97183f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 38.02817f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 460f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 43f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 51f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(915, 634);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel2.BackColor = global::System.Drawing.Color.White;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 10.36662f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 89.63338f));
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblTitle, 1, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(909, 75);
			this.tableLayoutPanel2.TabIndex = 1;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.Location = new global::System.Drawing.Point(97, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(809, 75);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Cho phép bạn quản lý và chỉnh sửa ";
			this.lblTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 126f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 424f));
			this.tableLayoutPanel3.Controls.Add(this.btnEdit, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnDel, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnAddNew, 0, 0);
			this.tableLayoutPanel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.tableLayoutPanel3.Location = new global::System.Drawing.Point(3, 84);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel3.Size = new global::System.Drawing.Size(734, 43);
			this.tableLayoutPanel3.TabIndex = 2;
			this.btnEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnEdit.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnEdit.Location = new global::System.Drawing.Point(187, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new global::System.Drawing.Size(120, 37);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Chỉnh sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new global::System.EventHandler(this.btnEdit_Click);
			this.btnDel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnDel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDel.Location = new global::System.Drawing.Point(95, 3);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new global::System.Drawing.Size(86, 37);
			this.btnDel.TabIndex = 1;
			this.btnDel.Text = "Xóa";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new global::System.EventHandler(this.btnDel_Click);
			this.btnAddNew.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnAddNew.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAddNew.Location = new global::System.Drawing.Point(3, 3);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new global::System.Drawing.Size(86, 37);
			this.btnAddNew.TabIndex = 0;
			this.btnAddNew.Text = "Thêm mới";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new global::System.EventHandler(this.btnAddNew_Click);
			this.lstViewMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lstViewMenu.Location = new global::System.Drawing.Point(3, 133);
			this.lstViewMenu.Name = "lstViewMenu";
			this.lstViewMenu.Size = new global::System.Drawing.Size(909, 454);
			this.lstViewMenu.TabIndex = 3;
			this.lstViewMenu.UseCompatibleStateImageBehavior = false;
			this.lstViewMenu.ItemActivate += new global::System.EventHandler(this.lstViewMenu_ItemActivate);
			this.lstViewMenu.SelectedIndexChanged += new global::System.EventHandler(this.lstViewMenu_SelectedIndexChanged);
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 88.10741f));
			this.tableLayoutPanel4.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 11.89258f));
			this.tableLayoutPanel4.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel4.Location = new global::System.Drawing.Point(3, 593);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel4.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel4.Size = new global::System.Drawing.Size(909, 38);
			this.tableLayoutPanel4.TabIndex = 4;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(803, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(103, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Thoát";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.btnExit_Click);
			this.imgListIcon.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgListIcon.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgListIcon.TransparentColor = global::System.Drawing.Color.Transparent;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmThemMoi,
				this.cmXoa,
				this.cmChinhSua
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(130, 70);
			this.cmThemMoi.Name = "cmThemMoi";
			this.cmThemMoi.Size = new global::System.Drawing.Size(129, 22);
			this.cmThemMoi.Text = "Thêm mới";
			this.cmThemMoi.Click += new global::System.EventHandler(this.cmThemMoi_Click);
			this.cmXoa.Name = "cmXoa";
			this.cmXoa.Size = new global::System.Drawing.Size(129, 22);
			this.cmXoa.Text = "Xóa";
			this.cmXoa.Click += new global::System.EventHandler(this.cmXoa_Click);
			this.cmChinhSua.Name = "cmChinhSua";
			this.cmChinhSua.Size = new global::System.Drawing.Size(129, 22);
			this.cmChinhSua.Text = "Chỉnh sửa";
			this.cmChinhSua.Click += new global::System.EventHandler(this.cmChinhSua_Click);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::Hotel.Properties.Resources.Edit;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(88, 69);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(915, 646);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(931, 685);
			this.MinimumSize = new global::System.Drawing.Size(931, 685);
			base.Name = "frmListMenu";
			this.Text = "Bảng giá";
			base.Load += new global::System.EventHandler(this.frmListMenu_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400015D RID: 349
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.Button btnEdit;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.Button btnDel;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.Button btnAddNew;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.ListView lstViewMenu;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.ImageList imgListIcon;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.ToolStripMenuItem cmThemMoi;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.ToolStripMenuItem cmXoa;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.ToolStripMenuItem cmChinhSua;
	}
}

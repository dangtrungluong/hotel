using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Hotel.Common;
using Hotel.Properties;

namespace Hotel
{
	// Token: 0x02000002 RID: 2
	public class AddUserService : UserControl
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AddUserService()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002089 File Offset: 0x00000289
		private void pnRoom_MouseClick(object sender, MouseEventArgs e)
		{
			this.SelectedItem();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		private void SelectedItem()
		{
			this.strRoom = this.lblNumberRoom.Text;
			this.lstAddUserService = frmMain.lstpAddUserService;
			for (int i = 0; i < this.lstAddUserService.Count; i++)
			{
				bool flag = this.strRoom.Equals(this.lstAddUserService[i].lblNumberRoom.Text);
				if (flag)
				{
					this.lstAddUserService[i].pnRoom.BackColor = Color.LightSkyBlue;
					AddUserService.iIndexSelected = i;
					AddUserService.bEnableTimer = true;
				}
				else
				{
					this.lstAddUserService[i].pnRoom.BackColor = Color.White;
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
		private void pnRoom_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002089 File Offset: 0x00000289
		private void picRoom_MouseClick(object sender, MouseEventArgs e)
		{
			this.SelectedItem();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002089 File Offset: 0x00000289
		private void lblNumberRoom_MouseClick(object sender, MouseEventArgs e)
		{
			this.SelectedItem();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002089 File Offset: 0x00000289
		private void lblStatusRoom_MouseClick(object sender, MouseEventArgs e)
		{
			this.SelectedItem();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002150 File Offset: 0x00000350
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002188 File Offset: 0x00000388
		private void InitializeComponent()
		{
			this.pnRoom = new Panel();
			this.lblStatusRoom = new Label();
			this.picRoom = new PictureBox();
			this.lblNumberRoom = new Label();
			this.pnRoom.SuspendLayout();
			((ISupportInitialize)this.picRoom).BeginInit();
			base.SuspendLayout();
			this.pnRoom.BackColor = Color.White;
			this.pnRoom.Controls.Add(this.lblStatusRoom);
			this.pnRoom.Controls.Add(this.picRoom);
			this.pnRoom.Controls.Add(this.lblNumberRoom);
			this.pnRoom.Cursor = Cursors.Hand;
			this.pnRoom.Location = new Point(3, 3);
			this.pnRoom.Name = "pnRoom";
			this.pnRoom.Size = new Size(76, 101);
			this.pnRoom.TabIndex = 3;
			this.pnRoom.MouseClick += this.pnRoom_MouseClick;
			this.lblStatusRoom.AutoSize = true;
			this.lblStatusRoom.Location = new Point(5, 59);
			this.lblStatusRoom.Name = "lblStatusRoom";
			this.lblStatusRoom.Size = new Size(41, 15);
			this.lblStatusRoom.TabIndex = 3;
			this.lblStatusRoom.Text = "label2";
			this.lblStatusRoom.TextAlign = ContentAlignment.MiddleCenter;
			this.lblStatusRoom.MouseClick += this.lblStatusRoom_MouseClick;
			this.picRoom.Cursor = Cursors.Hand;
			this.picRoom.Image = Resources.coffee_off1;
			this.picRoom.Location = new Point(0, 0);
			this.picRoom.Name = "picRoom";
			this.picRoom.Size = new Size(75, 74);
			this.picRoom.SizeMode = PictureBoxSizeMode.CenterImage;
			this.picRoom.TabIndex = 0;
			this.picRoom.TabStop = false;
			this.picRoom.MouseClick += this.picRoom_MouseClick;
			this.lblNumberRoom.AutoSize = true;
			this.lblNumberRoom.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblNumberRoom.Location = new Point(17, 77);
			this.lblNumberRoom.Name = "lblNumberRoom";
			this.lblNumberRoom.Size = new Size(36, 20);
			this.lblNumberRoom.TabIndex = 1;
			this.lblNumberRoom.Text = "201";
			this.lblNumberRoom.MouseClick += this.lblNumberRoom_MouseClick;
			base.AutoScaleDimensions = new SizeF(7f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.pnRoom);
			this.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Name = "AddUserService";
			base.Size = new Size(81, 106);
			this.pnRoom.ResumeLayout(false);
			this.pnRoom.PerformLayout();
			((ISupportInitialize)this.picRoom).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		public static bool bEnableTimer = false;

		// Token: 0x04000002 RID: 2
		private string strRoom = string.Empty;

		// Token: 0x04000003 RID: 3
		public static int iIndexSelected = -1;

		// Token: 0x04000004 RID: 4
		private FunctionCommon functionCommon = new FunctionCommon();

		// Token: 0x04000005 RID: 5
		private List<AddUserService> lstAddUserService = new List<AddUserService>();

		// Token: 0x04000006 RID: 6
		private IContainer components = null;

		// Token: 0x04000007 RID: 7
		public Panel pnRoom;

		// Token: 0x04000008 RID: 8
		public Label lblStatusRoom;

		// Token: 0x04000009 RID: 9
		public PictureBox picRoom;

		// Token: 0x0400000A RID: 10
		public Label lblNumberRoom;
	}
}

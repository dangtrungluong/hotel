using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	// Token: 0x02000016 RID: 22
	public class GroupRoom : UserControl
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00030333 File Offset: 0x0002E533
		public GroupRoom()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0003034C File Offset: 0x0002E54C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00030384 File Offset: 0x0002E584
		private void InitializeComponent()
		{
			this.grUserService = new GroupBox();
			base.SuspendLayout();
			this.grUserService.Location = new Point(0, 3);
			this.grUserService.Name = "grUserService";
			this.grUserService.Size = new Size(260, 262);
			this.grUserService.TabIndex = 0;
			this.grUserService.TabStop = false;
			this.grUserService.Text = "groupBox1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.grUserService);
			base.Name = "GroupRoom";
			base.Size = new Size(260, 268);
			base.ResumeLayout(false);
		}

		// Token: 0x04000347 RID: 839
		private IContainer components = null;

		// Token: 0x04000348 RID: 840
		public GroupBox grUserService;
	}
}

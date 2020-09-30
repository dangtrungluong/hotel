namespace Hotel
{
	// Token: 0x02000008 RID: 8
	public partial class frmChooseData : global::System.Windows.Forms.Form
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000CB78 File Offset: 0x0000AD78
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.lstViewChoose = new global::System.Windows.Forms.ListView();
			this.btnChapNhan = new global::System.Windows.Forms.Button();
			this.btnHuyBo = new global::System.Windows.Forms.Button();
			this.imgLstChoose = new global::System.Windows.Forms.ImageList(this.components);
			base.SuspendLayout();
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.Location = new global::System.Drawing.Point(14, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(205, 18);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Mời bạn chọn nhóm mặt hàng";
			this.lstViewChoose.Location = new global::System.Drawing.Point(0, 37);
			this.lstViewChoose.Name = "lstViewChoose";
			this.lstViewChoose.Size = new global::System.Drawing.Size(396, 217);
			this.lstViewChoose.TabIndex = 1;
			this.lstViewChoose.UseCompatibleStateImageBehavior = false;
			this.lstViewChoose.ItemActivate += new global::System.EventHandler(this.lstViewNhomMatHang_ItemActivate);
			this.lstViewChoose.SelectedIndexChanged += new global::System.EventHandler(this.lstViewNhomMatHang_SelectedIndexChanged);
			this.btnChapNhan.Location = new global::System.Drawing.Point(220, 260);
			this.btnChapNhan.Name = "btnChapNhan";
			this.btnChapNhan.Size = new global::System.Drawing.Size(75, 23);
			this.btnChapNhan.TabIndex = 2;
			this.btnChapNhan.Text = "Chấp nhận";
			this.btnChapNhan.UseVisualStyleBackColor = true;
			this.btnChapNhan.Click += new global::System.EventHandler(this.btnChapNhan_Click);
			this.btnHuyBo.Location = new global::System.Drawing.Point(313, 260);
			this.btnHuyBo.Name = "btnHuyBo";
			this.btnHuyBo.Size = new global::System.Drawing.Size(75, 23);
			this.btnHuyBo.TabIndex = 3;
			this.btnHuyBo.Text = "Hủy bỏ";
			this.btnHuyBo.UseVisualStyleBackColor = true;
			this.btnHuyBo.Click += new global::System.EventHandler(this.btnHuyBo_Click);
			this.imgLstChoose.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgLstChoose.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgLstChoose.TransparentColor = global::System.Drawing.Color.Transparent;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(395, 286);
			base.Controls.Add(this.btnHuyBo);
			base.Controls.Add(this.btnChapNhan);
			base.Controls.Add(this.lstViewChoose);
			base.Controls.Add(this.lblTitle);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmChooseData";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CHỌN DỮ LIỆU";
			base.Load += new global::System.EventHandler(this.frmChooseData_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000AE RID: 174
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ListView lstViewChoose;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Button btnChapNhan;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Button btnHuyBo;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ImageList imgLstChoose;
	}
}

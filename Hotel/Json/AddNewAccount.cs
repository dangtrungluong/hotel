using System;

namespace Hotel.Json
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class AddNewAccount
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000322CF File Offset: 0x000304CF
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000322D7 File Offset: 0x000304D7
		public string strUserName { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000322E0 File Offset: 0x000304E0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x000322E8 File Offset: 0x000304E8
		public string strPassWord { get; set; }
	}
}

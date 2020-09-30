using System;
using System.Collections.Generic;

namespace Hotel.Common
{
	// Token: 0x0200002C RID: 44
	public class DisplayArea
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00034A65 File Offset: 0x00032C65
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00034A6D File Offset: 0x00032C6D
		public string strKhuVuc { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00034A76 File Offset: 0x00032C76
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00034A7E File Offset: 0x00032C7E
		public List<LoaiPhongArea> lstLoaiPhongArea { get; set; }
	}
}

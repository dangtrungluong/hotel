using System;
using System.Collections.Generic;

namespace Hotel.Common
{
	// Token: 0x0200002D RID: 45
	public class LoaiPhongArea
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00034A87 File Offset: 0x00032C87
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00034A8F File Offset: 0x00032C8F
		public string strTypeRoom { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00034A98 File Offset: 0x00032C98
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00034AA0 File Offset: 0x00032CA0
		public List<RoomArea> lstRoomArea { get; set; }
	}
}

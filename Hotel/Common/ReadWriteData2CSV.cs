using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Hotel.Common
{
	// Token: 0x02000020 RID: 32
	public class ReadWriteData2CSV
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00032F5C File Offset: 0x0003115C
		private void WriteHeaderFile(string strFilePath, string[] strHeader)
		{
			string[] array = new string[1];
			bool flag = !string.IsNullOrEmpty(strFilePath);
			if (flag)
			{
				this.sbOutput = new StringBuilder();
				this.sbOutput.AppendLine(string.Join(",", strHeader));
				string text = string.Empty;
				for (int i = 0; i < strHeader.Length; i++)
				{
					text = text + strHeader[i] + ",";
				}
				string[] array2 = array;
				int num = 0;
				array2[num] += text.Substring(0, text.Length - 1);
				File.WriteAllLines(strFilePath, array, Encoding.UTF8);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00032FF8 File Offset: 0x000311F8
		public bool SaveDgvToCSV(string strFilePath, DataGridView DGV)
		{
			bool flag = File.Exists(strFilePath);
			if (flag)
			{
				try
				{
					File.Delete(strFilePath);
				}
				catch
				{
					return false;
				}
			}
			int columnCount = DGV.ColumnCount;
			string text = string.Empty;
			string[] array = new string[DGV.RowCount + 1];
			for (int i = 0; i < columnCount; i++)
			{
				text = text + DGV.Columns[i].Name.ToString() + ",";
			}
			string[] array2 = array;
			int num = 0;
			array2[num] += text.Substring(0, text.Length - 1);
			int num2 = 1;
			while (num2 - 1 < DGV.RowCount)
			{
				for (int j = 0; j < columnCount; j++)
				{
					string[] array3 = array;
					int num3 = num2;
					array3[num3] = array3[num3] + DGV.Rows[num2 - 1].Cells[j].Value.ToString() + ",";
				}
				array[num2] = array[num2].Substring(0, array[num2].Length - 1);
				num2++;
			}
			try
			{
				File.WriteAllLines(strFilePath, array, Encoding.UTF8);
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00033164 File Offset: 0x00031364
		public int LoadDgvFromCSV(string strFilePath, ref DataGridView dataGridView)
		{
			int result;
			try
			{
				dataGridView.DataSource = null;
				DataTable dataTable = new DataTable();
				bool flag = !File.Exists(strFilePath);
				if (flag)
				{
					result = 2;
				}
				else
				{
					using (StreamReader streamReader = new StreamReader(strFilePath))
					{
						string text = streamReader.ReadLine();
						string[] array = text.Split(new char[]
						{
							','
						});
						for (int i = 0; i < array.Length - 1; i++)
						{
							dataTable.Columns.Add(array[i].ToString(), typeof(string));
						}
						while (!streamReader.EndOfStream)
						{
							text = streamReader.ReadLine();
							string[] array2 = text.Split(new char[]
							{
								','
							});
							DataRow dataRow = dataTable.NewRow();
							for (int j = 0; j < array.Length - 1; j++)
							{
								dataRow[array[j].ToString()] = array2[j].ToString();
							}
							dataTable.Rows.Add(dataRow);
						}
					}
					dataGridView.DataSource = dataTable;
					this.funcCommon.dgvRefresh(ref dataGridView);
					result = 1;
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000332DC File Offset: 0x000314DC
		public int LoadDataTableFromCSV(string strFilePath, ref DataTable dataTable)
		{
			int result;
			try
			{
				dataTable = new DataTable();
				bool flag = !File.Exists(strFilePath);
				if (flag)
				{
					result = 2;
				}
				else
				{
					using (StreamReader streamReader = new StreamReader(strFilePath))
					{
						string text = streamReader.ReadLine();
						string[] array = text.Split(new char[]
						{
							','
						});
						for (int i = 0; i < array.Length; i++)
						{
							dataTable.Columns.Add(array[i].ToString(), typeof(string));
						}
						while (!streamReader.EndOfStream)
						{
							text = streamReader.ReadLine();
							string[] array2 = text.Split(new char[]
							{
								','
							});
							DataRow dataRow = dataTable.NewRow();
							for (int j = 0; j < array.Length; j++)
							{
								dataRow[array[j].ToString()] = array2[j].ToString();
							}
							dataTable.Rows.Add(dataRow);
						}
					}
					result = 1;
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00033430 File Offset: 0x00031630
		public void WriteLoaiSanPham2CSV(string strFilePath, LoaiSanPham sanpham)
		{
			bool flag = !string.IsNullOrEmpty(strFilePath);
			if (flag)
			{
				bool flag2 = !File.Exists(strFilePath);
				if (flag2)
				{
					string[] strHeader = new string[]
					{
						"Tên sản phẩm",
						"Ghi chú"
					};
					this.WriteHeaderFile(strFilePath, strHeader);
				}
				string strTenLoaiSanPham = sanpham.strTenLoaiSanPham;
				string strGhiChu = sanpham.strGhiChu;
				this.sbOutput = new StringBuilder();
				this.sbOutput.AppendLine(string.Join(",", new string[]
				{
					strTenLoaiSanPham,
					strGhiChu
				}));
				File.AppendAllText(strFilePath, this.sbOutput.ToString());
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000334D0 File Offset: 0x000316D0
		public void WriteNhomMatHang2CSV(string strFilePath, NhomMatHang nhommathang)
		{
			bool flag = !string.IsNullOrEmpty(strFilePath);
			if (flag)
			{
				bool flag2 = !File.Exists(strFilePath);
				if (flag2)
				{
					string[] strHeader = new string[]
					{
						"Tên nhóm mặt hàng",
						"Mã sản phẩm",
						"Loại sản phẩm"
					};
					this.WriteHeaderFile(strFilePath, strHeader);
				}
				string[] value = new string[]
				{
					nhommathang.strTenNhomMatHang,
					nhommathang.strMaSanPham,
					nhommathang.strLoaiSanPham
				};
				this.sbOutput = new StringBuilder();
				this.sbOutput.AppendLine(string.Join(",", value));
				File.AppendAllText(strFilePath, this.sbOutput.ToString());
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00033580 File Offset: 0x00031780
		public void WriteMatHang2CSV(string strFilePath, MatHang matHang)
		{
			bool flag = !File.Exists(strFilePath);
			if (flag)
			{
				string[] strHeader = new string[]
				{
					"ID",
					"Mã sản phẩm",
					"Tên sản phẩm",
					"Giá mua",
					"Đơn vị tính mua",
					"Giá bán",
					"Đơn vị tính bán",
					"Tên nhóm mặt hàng",
					"Loại sản phẩm",
					"Quy đổi"
				};
				this.WriteHeaderFile(strFilePath, strHeader);
			}
			string[] value = new string[]
			{
				matHang.iNo.ToString(),
				matHang.strMaSanPham,
				matHang.strTenSanPham,
				matHang.iGiaMua.ToString(),
				matHang.strDVTMua,
				matHang.iGiaBan.ToString(),
				matHang.strDVTBan,
				matHang.strNhomMatHang,
				matHang.strLoaiSanPham,
				matHang.iQuyDoi.ToString()
			};
			this.sbOutput = new StringBuilder();
			this.sbOutput.AppendLine(string.Join(",", value));
			File.AppendAllText(strFilePath, this.sbOutput.ToString(), Encoding.UTF8);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000336C0 File Offset: 0x000318C0
		public void WriteLoaiPhong2CSV(string strFilePath, LoaiPhong loaiPhong)
		{
			bool flag = !File.Exists(strFilePath);
			if (flag)
			{
				string[] strHeader = new string[]
				{
					"Tên loại phòng",
					"Màu chữ",
					"Màu nền",
					"Hiển thị",
					"Ghi chú"
				};
				this.WriteHeaderFile(strFilePath, strHeader);
			}
			string[] value = new string[]
			{
				loaiPhong.strTenLoaiPhong,
				loaiPhong.iMauChu.ToString(),
				loaiPhong.iMauNen.ToString(),
				loaiPhong.strTenHienThi,
				loaiPhong.strGhiChu
			};
			this.sbOutput = new StringBuilder();
			this.sbOutput.AppendLine(string.Join(",", value));
			File.AppendAllText(strFilePath, this.sbOutput.ToString(), Encoding.UTF8);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00033794 File Offset: 0x00031994
		public void WriteBangGiaDichVu2CSV(string strFilePath, BangGiaDichVu bangGiaDichVu)
		{
			bool flag = !File.Exists(strFilePath);
			if (flag)
			{
				string[] strHeader = new string[]
				{
					"Tên bảng giá",
					"Phụ thu theo giờ",
					"Phụ thu theo bảng giá",
					"Thêm người lớn",
					"Thêm trẻ em",
					"Thêm giường",
					"Đơn giá cuối tuần",
					"Đơn giá ngày lễ",
					"Bảng giá giờ",
					"Bảng giá đêm",
					"Bảng giá ngày đêm",
					"Trễ tối đa theo giờ",
					"Giá ngày thường",
					"Giá cuối tuần",
					"Giá ngày lễ",
					"Trễ tối đa qua đêm",
					"Trả phòng trước qua đêm",
					"Giờ vào sau 1",
					"Quá giờ qua đêm",
					"Giờ vào sau 2",
					"Trước giờ",
					"Trễ tối đa ngày đêm",
					"Trả phòng trước ngày đêm",
					"Tính là 1 ngày",
					"Quá giờ ngày đêm",
					"Ra sau giờ trả phòng"
				};
				this.WriteHeaderFile(strFilePath, strHeader);
			}
			string[] value = new string[]
			{
				bangGiaDichVu.strTenBangGia,
				Convert.ToString(bangGiaDichVu.bPhuThuGio),
				Convert.ToString(bangGiaDichVu.bPhuThuBangGia),
				Convert.ToString(bangGiaDichVu.iThemNguoiLon),
				Convert.ToString(bangGiaDichVu.iThemTreEm),
				Convert.ToString(bangGiaDichVu.iThemGiuong),
				Convert.ToString(bangGiaDichVu.bDonGiaCuoiTuan),
				Convert.ToString(bangGiaDichVu.bDonGiaNgayLe),
				Convert.ToString(bangGiaDichVu.bBangGiaGio),
				Convert.ToString(bangGiaDichVu.bBangGiaDem),
				Convert.ToString(bangGiaDichVu.bBangGiaNgayDem),
				Convert.ToString(bangGiaDichVu.bangGiaGio.iTreToiDa),
				Convert.ToString(bangGiaDichVu.bangGiaGio.bGiaNgayThuong),
				Convert.ToString(bangGiaDichVu.bangGiaGio.bGiaCuoiTuan),
				Convert.ToString(bangGiaDichVu.bangGiaGio.bGiaNgayLe),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iTreToiDa),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iTraPhongTruoc),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iGioVaoSau1),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iQuaGio),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iGioVaoSau2),
				Convert.ToString(bangGiaDichVu.bangGiaQuaDem.iTruocGio),
				Convert.ToString(bangGiaDichVu.bangGiaNgayDem.iTreToiDa),
				Convert.ToString(bangGiaDichVu.bangGiaNgayDem.iTraPhongTruoc),
				Convert.ToString(bangGiaDichVu.bangGiaNgayDem.bTinhLa1Ngay),
				Convert.ToString(bangGiaDichVu.bangGiaNgayDem.iQuaGio),
				Convert.ToString(bangGiaDichVu.bangGiaNgayDem.bRaSauGioTraPhong)
			};
			this.sbOutput = new StringBuilder();
			this.sbOutput.AppendLine(string.Join(",", value));
			File.AppendAllText(strFilePath, this.sbOutput.ToString(), Encoding.UTF8);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00033AB0 File Offset: 0x00031CB0
		public List<BangGiaDichVu> ReadBangGiaDichVuFromCSV(string strFilePath)
		{
			List<BangGiaDichVu> result;
			try
			{
				List<BangGiaDichVu> list = new List<BangGiaDichVu>();
				BangGiaDichVu bangGiaDichVu = new BangGiaDichVu();
				using (StreamReader streamReader = new StreamReader(strFilePath))
				{
					string text = streamReader.ReadLine();
					while (!streamReader.EndOfStream)
					{
						text = streamReader.ReadLine();
						string[] array = text.Split(new char[]
						{
							','
						});
						bangGiaDichVu = new BangGiaDichVu();
						bangGiaDichVu.bangGiaGio = new BangGiaGio();
						bangGiaDichVu.bangGiaQuaDem = new BangGiaQuaDem();
						bangGiaDichVu.bangGiaNgayDem = new BangGiaNgayDem();
						int num = 0;
						bangGiaDichVu.strTenBangGia = array[num];
						bangGiaDichVu.bPhuThuGio = Convert.ToBoolean(array[num + 1]);
						bangGiaDichVu.bPhuThuBangGia = Convert.ToBoolean(array[num + 2]);
						bangGiaDichVu.iThemNguoiLon = (int)Convert.ToInt16(array[num + 3]);
						bangGiaDichVu.iThemTreEm = (int)Convert.ToInt16(array[num + 4]);
						bangGiaDichVu.iThemGiuong = (int)Convert.ToInt16(array[num + 5]);
						bangGiaDichVu.bDonGiaCuoiTuan = Convert.ToBoolean(array[num + 6]);
						bangGiaDichVu.bDonGiaNgayLe = Convert.ToBoolean(array[num + 7]);
						bangGiaDichVu.bBangGiaGio = Convert.ToBoolean(array[num + 8]);
						bangGiaDichVu.bBangGiaDem = Convert.ToBoolean(array[num + 9]);
						bangGiaDichVu.bBangGiaNgayDem = Convert.ToBoolean(array[num + 10]);
						bangGiaDichVu.bangGiaGio.iTreToiDa = (int)Convert.ToInt16(array[num + 11]);
						bangGiaDichVu.bangGiaGio.bGiaNgayThuong = Convert.ToBoolean(array[num + 12]);
						bangGiaDichVu.bangGiaGio.bGiaCuoiTuan = Convert.ToBoolean(array[num + 13]);
						bangGiaDichVu.bangGiaGio.bGiaNgayLe = Convert.ToBoolean(array[num + 14]);
						bangGiaDichVu.bangGiaQuaDem.iTreToiDa = (int)Convert.ToInt16(array[num + 15]);
						bangGiaDichVu.bangGiaQuaDem.iTraPhongTruoc = (int)Convert.ToInt16(array[num + 16]);
						bangGiaDichVu.bangGiaQuaDem.iGioVaoSau1 = (int)Convert.ToInt16(array[num + 17]);
						bangGiaDichVu.bangGiaQuaDem.iQuaGio = (int)Convert.ToInt16(array[num + 18]);
						bangGiaDichVu.bangGiaQuaDem.iGioVaoSau2 = (int)Convert.ToInt16(array[num + 19]);
						bangGiaDichVu.bangGiaQuaDem.iTruocGio = (int)Convert.ToInt16(array[num + 20]);
						bangGiaDichVu.bangGiaNgayDem.iTreToiDa = (int)Convert.ToInt16(array[num + 21]);
						bangGiaDichVu.bangGiaNgayDem.iTraPhongTruoc = (int)Convert.ToInt16(array[num + 22]);
						bangGiaDichVu.bangGiaNgayDem.bTinhLa1Ngay = Convert.ToBoolean(array[num + 23]);
						bangGiaDichVu.bangGiaQuaDem.iQuaGio = (int)Convert.ToInt16(array[num + 24]);
						bangGiaDichVu.bangGiaNgayDem.bRaSauGioTraPhong = Convert.ToBoolean(array[num + 25]);
						bool flag = bangGiaDichVu != null;
						if (flag)
						{
							list.Add(bangGiaDichVu);
						}
					}
				}
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00033DE4 File Offset: 0x00031FE4
		public List<LoaiPhong> ReadLoaiPhongFromCSV(string strFilePath)
		{
			List<LoaiPhong> result;
			try
			{
				List<LoaiPhong> list = new List<LoaiPhong>();
				LoaiPhong loaiPhong = new LoaiPhong();
				using (StreamReader streamReader = new StreamReader(strFilePath))
				{
					string text = streamReader.ReadLine();
					while (!streamReader.EndOfStream)
					{
						text = streamReader.ReadLine();
						string[] array = text.Split(new char[]
						{
							','
						});
						loaiPhong = new LoaiPhong();
						int num = 0;
						loaiPhong.strTenLoaiPhong = array[num];
						loaiPhong.iMauChu = Convert.ToInt32(array[num + 1]);
						loaiPhong.iMauNen = Convert.ToInt32(array[num + 2]);
						loaiPhong.strTenHienThi = array[num + 3];
						loaiPhong.strGhiChu = array[num + 4];
						bool flag = loaiPhong != null;
						if (flag)
						{
							list.Add(loaiPhong);
						}
					}
				}
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00033EE4 File Offset: 0x000320E4
		public List<MatHang> ReadMatHangFromCSV(string strFilePath)
		{
			List<MatHang> list = new List<MatHang>();
			MatHang matHang = new MatHang();
			using (StreamReader streamReader = new StreamReader(strFilePath))
			{
				string text = streamReader.ReadLine();
				while (!streamReader.EndOfStream)
				{
					text = streamReader.ReadLine();
					string[] array = text.Split(new char[]
					{
						','
					});
					matHang = new MatHang();
					int num = 0;
					matHang.iNo = (int)Convert.ToInt16(array[num]);
					matHang.strMaSanPham = array[num + 1];
					matHang.strTenSanPham = array[num + 2];
					matHang.iGiaMua = Convert.ToUInt64(array[num + 3]);
					matHang.strDVTMua = array[num + 4];
					matHang.iGiaBan = Convert.ToUInt64(array[num + 5]);
					matHang.strDVTBan = array[num + 6];
					matHang.strNhomMatHang = array[num + 7];
					matHang.strLoaiSanPham = array[num + 8];
					matHang.iQuyDoi = (int)Convert.ToUInt16(array[num + 9]);
					bool flag = matHang != null;
					if (flag)
					{
						list.Add(matHang);
					}
				}
			}
			return list;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00034024 File Offset: 0x00032224
		public List<LoaiSanPham> ReadLoaiSanPhamFromCSV(string strFilePath)
		{
			List<LoaiSanPham> list = new List<LoaiSanPham>();
			LoaiSanPham loaiSanPham = new LoaiSanPham();
			using (StreamReader streamReader = new StreamReader(strFilePath))
			{
				string text = streamReader.ReadLine();
				while (!streamReader.EndOfStream)
				{
					text = streamReader.ReadLine();
					string[] array = text.Split(new char[]
					{
						','
					});
					loaiSanPham = new LoaiSanPham();
					loaiSanPham.strTenLoaiSanPham = array[0];
					loaiSanPham.strGhiChu = array[1];
					bool flag = loaiSanPham != null;
					if (flag)
					{
						list.Add(loaiSanPham);
					}
				}
			}
			return list;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000340D0 File Offset: 0x000322D0
		public List<NhomMatHang> ReadNhomMatHangFromCSV(string strFilePath)
		{
			List<NhomMatHang> list = new List<NhomMatHang>();
			NhomMatHang nhomMatHang = new NhomMatHang();
			using (StreamReader streamReader = new StreamReader(strFilePath))
			{
				string text = streamReader.ReadLine();
				while (!streamReader.EndOfStream)
				{
					text = streamReader.ReadLine();
					string[] array = text.Split(new char[]
					{
						','
					});
					nhomMatHang = new NhomMatHang();
					nhomMatHang.strTenNhomMatHang = array[0];
					nhomMatHang.strMaSanPham = array[1];
					nhomMatHang.strLoaiSanPham = array[2];
					bool flag = nhomMatHang != null;
					if (flag)
					{
						list.Add(nhomMatHang);
					}
				}
			}
			return list;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00034188 File Offset: 0x00032388
		public void WriteKhuVuc2CSV(string strFilePath, KhuVuc khuVuc)
		{
			bool flag = !File.Exists(strFilePath);
			if (flag)
			{
				string[] strHeader = new string[]
				{
					"ID",
					"Tên khu vực",
					"Giá mặt hàng",
					"Kho hàng",
					"Mẫu hóa đơn",
					"Ghi chú"
				};
				this.WriteHeaderFile(strFilePath, strHeader);
			}
			string[] value = new string[]
			{
				khuVuc.iNo.ToString(),
				khuVuc.strTenKhuVuc,
				khuVuc.strGiaMatHang,
				khuVuc.strKhoHang,
				khuVuc.strMauHoaDon,
				khuVuc.strGhiChu
			};
			this.sbOutput = new StringBuilder();
			this.sbOutput.AppendLine(string.Join(",", value));
			File.AppendAllText(strFilePath, this.sbOutput.ToString(), Encoding.UTF8);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00034268 File Offset: 0x00032468
		public void WriteDataTable2CSV(string strFilePath, DataTable dataTable, int iTypes)
		{
			string[] array = null;
			bool flag = iTypes == 1;
			if (flag)
			{
				array = new string[dataTable.Rows.Count];
				bool flag2 = !File.Exists(strFilePath);
				if (flag2)
				{
					string[] array2 = new string[dataTable.Columns.Count];
					for (int i = 0; i < dataTable.Columns.Count; i++)
					{
						array2[i] = dataTable.Columns[i].ToString();
					}
					this.WriteHeaderFile(strFilePath, array2);
				}
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					string text = string.Empty;
					DataRow dataRow = dataTable.Rows[j];
					for (int k = 0; k < dataRow.ItemArray.Length; k++)
					{
						text = text + dataRow.ItemArray[k].ToString() + ",";
					}
					array[j] = text.Substring(0, text.Length - 1);
				}
				this.sbOutput = new StringBuilder();
				this.sbOutput.AppendLine(string.Join(",", array));
				File.AppendAllText(strFilePath, this.sbOutput.ToString(), Encoding.UTF8);
			}
			else
			{
				bool flag3 = iTypes == 2;
				if (flag3)
				{
					array = new string[dataTable.Rows.Count + 1];
					bool flag4 = File.Exists(strFilePath);
					if (flag4)
					{
						try
						{
							File.Delete(strFilePath);
						}
						catch
						{
							return;
						}
					}
					int count = dataTable.Columns.Count;
					string text2 = string.Empty;
					for (int l = 0; l < count; l++)
					{
						text2 = text2 + dataTable.Columns[l].ToString() + ",";
					}
					string[] array3 = array;
					int num = 0;
					array3[num] += text2.Substring(0, text2.Length - 1);
					for (int m = 0; m < dataTable.Rows.Count; m++)
					{
						string text3 = string.Empty;
						DataRow dataRow2 = dataTable.Rows[m];
						for (int n = 0; n < dataRow2.ItemArray.Length; n++)
						{
							text3 = text3 + dataRow2.ItemArray[n].ToString() + ",";
						}
						array[m + 1] = text3.Substring(0, text3.Length - 1);
					}
					try
					{
						File.WriteAllLines(strFilePath, array, Encoding.UTF8);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00034534 File Offset: 0x00032734
		public List<KhuVuc> ReadKhuVucFromCSV(string strFilePath)
		{
			List<KhuVuc> result;
			try
			{
				List<KhuVuc> list = new List<KhuVuc>();
				KhuVuc khuVuc = new KhuVuc();
				using (StreamReader streamReader = new StreamReader(strFilePath))
				{
					string text = streamReader.ReadLine();
					while (!streamReader.EndOfStream)
					{
						text = streamReader.ReadLine();
						string[] array = text.Split(new char[]
						{
							','
						});
						khuVuc = new KhuVuc();
						khuVuc.iNo = (int)Convert.ToInt16(array[0]);
						khuVuc.strTenKhuVuc = array[1];
						khuVuc.strGiaMatHang = array[2];
						khuVuc.strKhoHang = array[3];
						khuVuc.strMauHoaDon = array[4];
						khuVuc.strGhiChu = array[5];
						bool flag = khuVuc != null;
						if (flag)
						{
							list.Add(khuVuc);
						}
					}
				}
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400047B RID: 1147
		private StringBuilder sbOutput = new StringBuilder();

		// Token: 0x0400047C RID: 1148
		private FunctionCommon funcCommon = new FunctionCommon();
	}
}

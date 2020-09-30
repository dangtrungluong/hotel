using System;
using System.IO;
using System.Reflection;

namespace Hotel.Common
{
	// Token: 0x0200001E RID: 30
	public class CMConstant
	{
		// Token: 0x04000370 RID: 880
		public static string strFolderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		// Token: 0x04000371 RID: 881
		public const string STR_FILE_NAME_CONFIG_LOGIN_JSON = "ConfigLogin.json";

		// Token: 0x04000372 RID: 882
		public const string STR_FILE_NAME_ACCOUNT_BIN = "Account.bin";

		// Token: 0x04000373 RID: 883
		public const string STR_FILE_NAME_CSV_LOAI_SAN_PHAM = "LoaiSanPham.csv";

		// Token: 0x04000374 RID: 884
		public const string STR_FILE_NAME_CSV_NHOM_MAT_HANG = "NhomMatHang.csv";

		// Token: 0x04000375 RID: 885
		public const string STR_FILE_NAME_CSV_MAT_HANG = "MatHang.csv";

		// Token: 0x04000376 RID: 886
		public const string STR_FILE_NAME_CSV_LOAI_PHONG = "LoaiPhong.csv";

		// Token: 0x04000377 RID: 887
		public const string STR_FILE_NAME_CSV_BANG_GIA_DICH_VU = "BangGiaDichVu.csv";

		// Token: 0x04000378 RID: 888
		public const string STR_FILE_NAME_CSV_KHU_VUC = "KhuVuc.csv";

		// Token: 0x04000379 RID: 889
		public const string STR_FILE_NAME_CSV_BAN = "Ban.csv";

		// Token: 0x0400037A RID: 890
		public const string STR_FILE_NAME_CSV_NHOM_KHACH_HANG = "NhomKhachHang.csv";

		// Token: 0x0400037B RID: 891
		public const string STR_FILE_NAME_CSV_KHACH_HANG = "KhachHang.csv";

		// Token: 0x0400037C RID: 892
		public const string STR_FILE_NAME_CSV_KHACH_MO_PHONG = "KhachMoPhong.csv";

		// Token: 0x0400037D RID: 893
		public const string STR_FILE_NAME_CSV_MENU = "Menu.csv";

		// Token: 0x0400037E RID: 894
		public const string STR_PATH_CONFIG_LOGIN_JSON = "ConfigFile\\ConfigLogin.json";

		// Token: 0x0400037F RID: 895
		public const string STR_PATH_ACCOUNT_BIN = "Data\\Account.bin";

		// Token: 0x04000380 RID: 896
		public const string STR_PATH_CSV_LOAI_SAN_PHAM = "Data\\LoaiSanPham.csv";

		// Token: 0x04000381 RID: 897
		public const string STR_PATH_CSV_NHOM_MAT_HANG = "Data\\NhomMatHang.csv";

		// Token: 0x04000382 RID: 898
		public const string STR_PATH_CSV_MAT_HANG = "Data\\MatHang.csv";

		// Token: 0x04000383 RID: 899
		public const string STR_PATH_CSV_LOAI_PHONG = "Data\\LoaiPhong.csv";

		// Token: 0x04000384 RID: 900
		public const string STR_PATH_CSV_KHU_VUC = "Data\\KhuVuc.csv";

		// Token: 0x04000385 RID: 901
		public const string STR_PATH_CSV_BAN = "Data\\Ban.csv";

		// Token: 0x04000386 RID: 902
		public const string STR_PATH_CSV_NHOM_KHACH_HANG = "Data\\NhomKhachHang.csv";

		// Token: 0x04000387 RID: 903
		public const string STR_PATH_CSV_KHACH_HANG = "Data\\KhachHang.csv";

		// Token: 0x04000388 RID: 904
		public const string STR_PATH_CSV_KHACH_MO_PHONG = "Data\\KhachMoPhong.csv";

		// Token: 0x04000389 RID: 905
		public const string STR_PATH_CSV_MENU = "Data\\Menu.csv";

		// Token: 0x0400038A RID: 906
		public const string STR_PATH_CSV_BANG_GIA_DICH_VU = "Data\\BangGiaDichVu.csv";

		// Token: 0x0400038B RID: 907
		public const string STR_PATH_DATA = "Data";

		// Token: 0x0400038C RID: 908
		public const string STR_PATH_CONFIGURE = "ConfigFile";

		// Token: 0x0400038D RID: 909
		public const string STR_FILE_NAME_CSV_BANG_GIA_GIO = "BangGiaGio.csv";

		// Token: 0x0400038E RID: 910
		public const string STR_FILE_NAME_CSV_BANG_GIA_QUA_DEM = "BangGiaQuaDem.csv";

		// Token: 0x0400038F RID: 911
		public const string STR_FILE_NAME_CSV_BANG_GIA_NGAY_DEM_PHU_THU_VAO_SOM = "BangGiaQuaDemPhuThuVaoSom.csv";

		// Token: 0x04000390 RID: 912
		public const string STR_FILE_NAME_CSV_BANG_GIA_QUA_DEM_GIAM_TRU_VAO_MUON = "BangGiaQuaDemGiamTruVaoMuon.csv";

		// Token: 0x04000391 RID: 913
		public const string STR_FILE_NAME_CSV_BANG_GIA_QUA_DEM_PHU_THU_RA_TRE = "BangGiaQuaDemPhuThuRaTre.csv";

		// Token: 0x04000392 RID: 914
		public const string STR_FILE_NAME_CSV_BANG_GIA_NGAY_DEM = "BangGiaNgayDem.csv";

		// Token: 0x04000393 RID: 915
		public const string STR_PATH_CSV_BANG_GIA_NGAY_DEM_PHU_THU_VAO_SOM = "BangGiaNgayDemPhuThuVaoSom.csv";

		// Token: 0x04000394 RID: 916
		public const string STR_FILE_NAME_CSV_BANG_GIA_NGAY_DEM_PHU_THU_RA_TRE = "BangGiaNgayDemPhuThuRaTre.csv";

		// Token: 0x04000395 RID: 917
		public const string STR_PATH_ICON = "Data\\Icon";

		// Token: 0x04000396 RID: 918
		public const string STR_CSV_EXTENSION = ".csv";

		// Token: 0x04000397 RID: 919
		public static string strFilePathLoaiSanPham = Path.Combine(CMConstant.strFolderPath, "Data\\LoaiSanPham.csv");

		// Token: 0x04000398 RID: 920
		public static string strFilePathNhomMatHang = Path.Combine(CMConstant.strFolderPath, "Data\\NhomMatHang.csv");

		// Token: 0x04000399 RID: 921
		public static string strFilePathMatHang = Path.Combine(CMConstant.strFolderPath, "Data\\MatHang.csv");

		// Token: 0x0400039A RID: 922
		public static string strFilePathLoaiPhong = Path.Combine(CMConstant.strFolderPath, "Data\\LoaiPhong.csv");

		// Token: 0x0400039B RID: 923
		public static string strFilePathBangGiaDichVu = Path.Combine(CMConstant.strFolderPath, "Data\\BangGiaDichVu.csv");

		// Token: 0x0400039C RID: 924
		public static string strFilePathKhuVuc = Path.Combine(CMConstant.strFolderPath, "Data\\KhuVuc.csv");

		// Token: 0x0400039D RID: 925
		public static string strFilePathBan = Path.Combine(CMConstant.strFolderPath, "Data\\Ban.csv");

		// Token: 0x0400039E RID: 926
		public static string strFolderData = Path.Combine(CMConstant.strFolderPath, "Data");

		// Token: 0x0400039F RID: 927
		public static string strFolderConfigure = Path.Combine(CMConstant.strFolderPath, "ConfigFile");

		// Token: 0x040003A0 RID: 928
		public static string strFilePathNhomKhachHang = Path.Combine(CMConstant.strFolderPath, "Data\\NhomKhachHang.csv");

		// Token: 0x040003A1 RID: 929
		public static string strFilePathKhachHang = Path.Combine(CMConstant.strFolderPath, "Data\\KhachHang.csv");

		// Token: 0x040003A2 RID: 930
		public static string strFilePathKhachMoPhong = Path.Combine(CMConstant.strFolderPath, "Data\\KhachMoPhong.csv");

		// Token: 0x040003A3 RID: 931
		public static string strFilePathMenu = Path.Combine(CMConstant.strFolderPath, "Data\\Menu.csv");

		// Token: 0x040003A4 RID: 932
		public static string strPathOpenRoom = Path.Combine(CMConstant.strFolderPath, "Resource", "roomlock.png");

		// Token: 0x040003A5 RID: 933
		public static string strPathCloseRoom = Path.Combine(CMConstant.strFolderPath, "Resource", "coffee_off.png");

		// Token: 0x040003A6 RID: 934
		public static string strFilePathIcon = Path.Combine(CMConstant.strFolderPath, "Data\\Icon");

		// Token: 0x040003A7 RID: 935
		public const string STR_REGEX = "^[a-zA-Z0-9]";

		// Token: 0x040003A8 RID: 936
		public const string DIGITAL_REGEX = "^[0-9]+$";

		// Token: 0x040003A9 RID: 937
		public const string STR_DETERMINED = ",";

		// Token: 0x040003AA RID: 938
		public const char CHR_DETERMINED = ',';

		// Token: 0x040003AB RID: 939
		public const string STR_TEN_SAN_PHAM = "Tên sản phẩm";

		// Token: 0x040003AC RID: 940
		public const string STR_GHI_CHU = "Ghi chú";

		// Token: 0x040003AD RID: 941
		public const string STR_ID = "ID";

		// Token: 0x040003AE RID: 942
		public const string STR_DIEN_GIAI = "Diễn giải";

		// Token: 0x040003AF RID: 943
		public const string STR_TEN_NHOM_MAT_HANG = "Tên nhóm mặt hàng";

		// Token: 0x040003B0 RID: 944
		public const string STR_MA_SAN_PHAM = "Mã sản phẩm";

		// Token: 0x040003B1 RID: 945
		public const string STR_LOAI_SAN_PHAM = "Loại sản phẩm";

		// Token: 0x040003B2 RID: 946
		public const string STR_PATH_REMEMBER_ACCOUNT_BIN = "Data\\RememberAccount.bin";

		// Token: 0x040003B3 RID: 947
		public const string COL_DB = "DBName";

		// Token: 0x040003B4 RID: 948
		public const string COL_FILE_PATH = "FilePath";

		// Token: 0x040003B5 RID: 949
		public const string MSG_CANNOT_OPEN_FILE = "Không thể mở được tập tin.";

		// Token: 0x040003B6 RID: 950
		public const string MSG_MISMATCH_PASSWORD = "Mật khẩu mới và mật khẩu xác nhận không khớp nhau.";

		// Token: 0x040003B7 RID: 951
		public const string MSG_SUCCESS_PASSWORD = "Đăng ký thành công.";

		// Token: 0x040003B8 RID: 952
		public const string MSG_EXIST_USER = "Tên người dùng đã tồn tại.";

		// Token: 0x040003B9 RID: 953
		public const string MSG_CHANGE_PWD_ERROR = "Đổi mật khẩu thất bại.";

		// Token: 0x040003BA RID: 954
		public const string MSG_CHANGE_PWD_SUCCESS = "Đổi mật khẩu thành công.";

		// Token: 0x040003BB RID: 955
		public const string MSG_CANNOT_FOUND_FILE = "Không tìm thấy tập tin ";

		// Token: 0x040003BC RID: 956
		public const string MSG_CANNOT_FOUND_USER = "Không tìm thấy người dùng.";

		// Token: 0x040003BD RID: 957
		public const string MSG_LOGIN_ERROR = "Đăng nhập thất bại.";

		// Token: 0x040003BE RID: 958
		public const string MSG_EMPTY_FOLDER = "Thư mục rỗng.";

		// Token: 0x040003BF RID: 959
		public const string MSG_EMPTY_ACCOUNT = "Kiểm lại tên người dùng hoặc mật khẩu đang trống.";

		// Token: 0x040003C0 RID: 960
		public const string MSG_CANNOT_FOUND_ICON = "Không tìm thấy icon";

		// Token: 0x040003C1 RID: 961
		public const string ERROR = "Lỗi";

		// Token: 0x040003C2 RID: 962
		public const string WARNING = "Cảnh báo";

		// Token: 0x040003C3 RID: 963
		public const string INFORMATION = "Thông tin";

		// Token: 0x040003C4 RID: 964
		public const int ID_FRM_LOGIN = 1;

		// Token: 0x040003C5 RID: 965
		public const int ID_FRM_MAIN = 2;

		// Token: 0x040003C6 RID: 966
		public const string STR_TAB_OPEN = "Đang mở tab ";

		// Token: 0x040003C7 RID: 967
		public const string STR_ALL = "Tất cả";

		// Token: 0x040003C8 RID: 968
		public const int FILE_NOT_EXIST = 2;

		// Token: 0x040003C9 RID: 969
		public const int SUCCESS = 1;

		// Token: 0x040003CA RID: 970
		public const int FAILED = -1;

		// Token: 0x040003CB RID: 971
		public const int NG_DIGITAL_VALID = 2;

		// Token: 0x040003CC RID: 972
		public const int NG_VALID = 3;

		// Token: 0x040003CD RID: 973
		public const int EXIST = 200;

		// Token: 0x040003CE RID: 974
		public const int NO_EXIST = 201;

		// Token: 0x040003CF RID: 975
		public const int ADD_NEW = 1;

		// Token: 0x040003D0 RID: 976
		public const int EDIT = 2;

		// Token: 0x040003D1 RID: 977
		public const int ZERO = 0;

		// Token: 0x040003D2 RID: 978
		public const string STR_ADD_NEW = "Thêm mới loại sản phẩm";

		// Token: 0x040003D3 RID: 979
		public const string STR_EDIT_ITEM = "Chỉnh sửa loại sản phẩm";

		// Token: 0x040003D4 RID: 980
		public const string MSG_EXIST_ITEM_1 = "Loại sản phẩm [";

		// Token: 0x040003D5 RID: 981
		public const string MSG_EXIST_ITEM_2 = "] đã có trong danh mục.";

		// Token: 0x040003D6 RID: 982
		public const string MSG_SELECTED_ITEM_EDIT = "Vui lòng chọn loại sản phẩm để chỉnh sửa.";

		// Token: 0x040003D7 RID: 983
		public const string MSG_SELECTED_ITEM_DEL = "Vui lòng chọn loại sản phẩm để xóa.";

		// Token: 0x040003D8 RID: 984
		public const string MSG_SELECTED_AREA_DEL = "Vui lòng chọn bàn khu vực để xóa.";

		// Token: 0x040003D9 RID: 985
		public const string MSG_SELECTED_NHOM_KH_DEL = "Vui lòng chọn nhóm khách hàng để xóa.";

		// Token: 0x040003DA RID: 986
		public const string MSG_CANNOT_DELETED = "Không thể xóa ";

		// Token: 0x040003DB RID: 987
		public const string MSG_CANNOT_SAVE = "Không thể lưu tập tin ";

		// Token: 0x040003DC RID: 988
		public const string MSG_LOAD_FILE_FAIL = "Lỗi đọc tập tin ";

		// Token: 0x040003DD RID: 989
		public const string MSG_CANNOT_CREATED_FOLDER = "Không thể tạo thư mục ";

		// Token: 0x040003DE RID: 990
		public const string MSG_INPUT_IVALID = "Giá trị nhập vào không hợp lệ.\n Có ô còn đang trống";

		// Token: 0x040003DF RID: 991
		public const string MSG_INPUT_DIGITAL_IVALID = "Giá trị nhập vào không hợp lệ.\nKí tự hợp lệ từ 0 - 9";

		// Token: 0x040003E0 RID: 992
		public const string MSG_EXIST_ITEM_1_NHOM_MAT_HANG = "Nhóm mặt hàng [";

		// Token: 0x040003E1 RID: 993
		public const string MSG_EXIST_ITEM_2_NHOM_MAT_HANG = "] đã có trong danh sách mặt hàng.";

		// Token: 0x040003E2 RID: 994
		public const string MSG_EXIST_ITEM_1_TEN_KHU_VUC = "Tên khu vực [";

		// Token: 0x040003E3 RID: 995
		public const string MSG_EXIST_ITEM_2_TEN_KHU_VUC = "] đã có trong danh sách khu vực.";

		// Token: 0x040003E4 RID: 996
		public const string MSG_SELECTED_ITEM = "Vui lòng chọn 1 loại mặt hàng.";

		// Token: 0x040003E5 RID: 997
		public const string MSG_SELECTED_TYPE_ROOM = "Vui lòng chọn 1 loại phòng.";

		// Token: 0x040003E6 RID: 998
		public const string MSG_SELECTED_BANG_GIA = "Vui lòng chọn 1 bảng giá.";

		// Token: 0x040003E7 RID: 999
		public const string MSG_SELECTED_BAN_KHU_VUC = "Vui lòng chọn 1 bàn khu vực.";

		// Token: 0x040003E8 RID: 1000
		public const string MSG_SELECTED_NHOM_KH = "Vui lòng chọn 1 nhóm khách hàng.";

		// Token: 0x040003E9 RID: 1001
		public const string STR_TITLE_ADD_NEW = " - THÊM MỚI";

		// Token: 0x040003EA RID: 1002
		public const string STR_TITLE_EDIT = " - CHỈNH SỬA";

		// Token: 0x040003EB RID: 1003
		public const string STR_GIA_MUA = "Giá mua";

		// Token: 0x040003EC RID: 1004
		public const string STR_DVT_MUA = "Đơn vị tính mua";

		// Token: 0x040003ED RID: 1005
		public const string STR_GIA_BAN = "Giá bán";

		// Token: 0x040003EE RID: 1006
		public const string STR_DVT_BAN = "Đơn vị tính bán";

		// Token: 0x040003EF RID: 1007
		public const string STR_QUY_DOI = "Quy đổi";

		// Token: 0x040003F0 RID: 1008
		public const int INDEX_NHOM_MAT_HANG = 7;

		// Token: 0x040003F1 RID: 1009
		public const string STR_TEN_KHU_VUC = "Tên khu vực";

		// Token: 0x040003F2 RID: 1010
		public const string STR_GIA_MAT_HANG = "Giá mặt hàng";

		// Token: 0x040003F3 RID: 1011
		public const string STR_KHO_HANG = "Kho hàng";

		// Token: 0x040003F4 RID: 1012
		public const string STR_MAU_HOA_DON = "Mẫu hóa đơn";

		// Token: 0x040003F5 RID: 1013
		public const string STR_SELECTED_TABLE_AREA = "Mời bạn chọn bàn khu vực";

		// Token: 0x040003F6 RID: 1014
		public const string STR_SELECTED_NHOM_KH = "Mời bạn chọn nhóm khách hàng";

		// Token: 0x040003F7 RID: 1015
		public const int INDEX_AREA = 3;

		// Token: 0x040003F8 RID: 1016
		public const string STR_TEN_BAN = "Tên bàn";

		// Token: 0x040003F9 RID: 1017
		public const string STR_TIEN_MO_BAN = "Tiền mở bàn";

		// Token: 0x040003FA RID: 1018
		public const string STR_KHU_VUC = "Khu vực";

		// Token: 0x040003FB RID: 1019
		public const string STR_NHOM_HIEN_THI = "Nhóm hiển thị";

		// Token: 0x040003FC RID: 1020
		public const int TYPE_NHOM_MAT_HANG = 100;

		// Token: 0x040003FD RID: 1021
		public const int TYPE_BAN_KHU_VUC = 101;

		// Token: 0x040003FE RID: 1022
		public const int TYPE_NHOM_KH = 102;

		// Token: 0x040003FF RID: 1023
		public const string STR_EDIT = "Chỉnh sửa";

		// Token: 0x04000400 RID: 1024
		public const string STR_DEL = "Xóa";

		// Token: 0x04000401 RID: 1025
		public const string STR_REFRESH = "Refresh";

		// Token: 0x04000402 RID: 1026
		public const string STR_RENAME = "Đổi tên";

		// Token: 0x04000403 RID: 1027
		public const string MSG_EXIST_ITEM_1_TEN_MAT_HANG = "Tên mặt hàng [";

		// Token: 0x04000404 RID: 1028
		public const string MSG_EXIST_ITEM_2_TEN_MAT_HANG = "] đã có trong danh sách mặt hàng.";

		// Token: 0x04000405 RID: 1029
		public const string MSG_EXIST_ITEM_1_TEN_BAN = "Tên bàn [";

		// Token: 0x04000406 RID: 1030
		public const string MSG_EXIST_ITEM_2_TEN_BAN = "] đã có trong danh sách tên bàn.";

		// Token: 0x04000407 RID: 1031
		public const string MSG_EXIST_ITEM_1_TEN_LOAI_PHONG = "Tên loại phòng [";

		// Token: 0x04000408 RID: 1032
		public const string MSG_EXIST_ITEM_2_TEN_LOAI_PHONG = "] đã có trong danh sách loại phòng.";

		// Token: 0x04000409 RID: 1033
		public const string MSG_EXIST_ITEM_1_TEN_BANG_GIA = "Tên bản giá [";

		// Token: 0x0400040A RID: 1034
		public const string MSG_EXIST_ITEM_2_TEN_BANG_GIA = "] đã có trong danh sách bảng giá.";

		// Token: 0x0400040B RID: 1035
		public const string MSG_EXIST_ITEM_1_TEN_NHOM_KH = "Tên nhóm khách hàng [";

		// Token: 0x0400040C RID: 1036
		public const string MSG_EXIST_ITEM_2_TEN_NHOM_KH = "] đã có trong danh sách tên nhóm khách hàng.";

		// Token: 0x0400040D RID: 1037
		public const string MSG_EXIST_ITEM_1_MA_KH = "Mã khách hàng [";

		// Token: 0x0400040E RID: 1038
		public const string MSG_EXIST_ITEM_2_MA_KH = "] đã có trong danh sách mã khách hàng.";

		// Token: 0x0400040F RID: 1039
		public const int CHAR_ZERO = 48;

		// Token: 0x04000410 RID: 1040
		public const int CHAR_NINE = 57;

		// Token: 0x04000411 RID: 1041
		public const int INDEX_TENSP = 2;

		// Token: 0x04000412 RID: 1042
		public const int INDEX_TEN_BAN = 1;

		// Token: 0x04000413 RID: 1043
		public const int INDEX_ROOM = 8;

		// Token: 0x04000414 RID: 1044
		public const string STR_LOAI_PHONG = "Loại phòng";

		// Token: 0x04000415 RID: 1045
		public const string STR_BANG_GIA = "Bảng giá";

		// Token: 0x04000416 RID: 1046
		public const string STR_DON_GIA = "Đơn giá";

		// Token: 0x04000417 RID: 1047
		public const string STR_CUOI_TUAN = "Cuối tuần";

		// Token: 0x04000418 RID: 1048
		public const string STR_NGAY_LE = "Ngày lễ";

		// Token: 0x04000419 RID: 1049
		public const string STR_TEN_LOAI_PHONG = "Tên loại phòng";

		// Token: 0x0400041A RID: 1050
		public const string STR_MAU_CHU = "Màu chữ";

		// Token: 0x0400041B RID: 1051
		public const string STR_MAU_NEN = "Màu nền";

		// Token: 0x0400041C RID: 1052
		public const string STR_HIEN_THI = "Hiển thị";

		// Token: 0x0400041D RID: 1053
		public const string STR_TEN_BANG_GIA = "Tên bảng giá";

		// Token: 0x0400041E RID: 1054
		public const string STR_PHU_THU_GIO = "Phụ thu theo giờ";

		// Token: 0x0400041F RID: 1055
		public const string STR_PHU_THU_BANG_GIA = "Phụ thu theo bảng giá";

		// Token: 0x04000420 RID: 1056
		public const string STR_THEM_NGUOI_LON = "Thêm người lớn";

		// Token: 0x04000421 RID: 1057
		public const string STR_THEM_TRE_EM = "Thêm trẻ em";

		// Token: 0x04000422 RID: 1058
		public const string STR_THEM_GIUONG = "Thêm giường";

		// Token: 0x04000423 RID: 1059
		public const string STR_DON_GIA_CUOI_TUAN = "Đơn giá cuối tuần";

		// Token: 0x04000424 RID: 1060
		public const string STR_DON_GIA_NGAY_LE = "Đơn giá ngày lễ";

		// Token: 0x04000425 RID: 1061
		public const string STR_BANG_GIA_GIO = "Bảng giá giờ";

		// Token: 0x04000426 RID: 1062
		public const string STR_BANG_GIA_DEM = "Bảng giá đêm";

		// Token: 0x04000427 RID: 1063
		public const string STR_BANG_GIA_NGAY_DEM = "Bảng giá ngày đêm";

		// Token: 0x04000428 RID: 1064
		public const string STR_TRE_TOI_DA_GIO = "Trễ tối đa theo giờ";

		// Token: 0x04000429 RID: 1065
		public const string STR_TRE_TOI_DA_QUA_DEM = "Trễ tối đa qua đêm";

		// Token: 0x0400042A RID: 1066
		public const string STR_TRE_TOI_DA_NGAY_DEM = "Trễ tối đa ngày đêm";

		// Token: 0x0400042B RID: 1067
		public const string STR_GIA_NGAY_THUONG = "Giá ngày thường";

		// Token: 0x0400042C RID: 1068
		public const string STR_GIA_CUOI_TUAN = "Giá cuối tuần";

		// Token: 0x0400042D RID: 1069
		public const string STR_GIA_NGAY_LE = "Giá ngày lễ";

		// Token: 0x0400042E RID: 1070
		public const string STR_TRA_PHONG_TRUOC_QUA_DEM = "Trả phòng trước qua đêm";

		// Token: 0x0400042F RID: 1071
		public const string STR_TRA_PHONG_TRUOC_NGAY_DEM = "Trả phòng trước ngày đêm";

		// Token: 0x04000430 RID: 1072
		public const string STR_GIO_VAO_SAU_1 = "Giờ vào sau 1";

		// Token: 0x04000431 RID: 1073
		public const string STR_QUA_GIO_QUA_DEM = "Quá giờ qua đêm";

		// Token: 0x04000432 RID: 1074
		public const string STR_QUA_GIO_NGAY_DEM = "Quá giờ ngày đêm";

		// Token: 0x04000433 RID: 1075
		public const string STR_GIO_VAO_SAU_2 = "Giờ vào sau 2";

		// Token: 0x04000434 RID: 1076
		public const string STR_TRUOC_GIO = "Trước giờ";

		// Token: 0x04000435 RID: 1077
		public const string STR_TINH_LA_1_NGAY = "Tính là 1 ngày";

		// Token: 0x04000436 RID: 1078
		public const string STR_RA_SAU_GIO_TRA_PHONG = "Ra sau giờ trả phòng";

		// Token: 0x04000437 RID: 1079
		public const int BANG_GIA_GIO = 1;

		// Token: 0x04000438 RID: 1080
		public const int BANG_GIA_QUA_DEM = 2;

		// Token: 0x04000439 RID: 1081
		public const int BANG_GIA_NGAY_DEM = 3;

		// Token: 0x0400043A RID: 1082
		public static string[] strHeaderTable = new string[]
		{
			"ID",
			"Tên bàn",
			"Tiền mở bàn",
			"Khu vực",
			"Nhóm hiển thị",
			"Loại phòng",
			"Ghi chú"
		};

		// Token: 0x0400043B RID: 1083
		public static string[] strHeaderMatHang = new string[]
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

		// Token: 0x0400043C RID: 1084
		public const string STR_PHONG_BAN = "Phòng bẩn";

		// Token: 0x0400043D RID: 1085
		public const string STR_BAO_DON = " Báo dọn ";

		// Token: 0x0400043E RID: 1086
		public const string STR_DON_XONG = " Dọn xong";

		// Token: 0x0400043F RID: 1087
		public const string STR_MO_PHONG = " Mở phòng";

		// Token: 0x04000440 RID: 1088
		public const string STR_MA_KH = "Mã khách hàng";

		// Token: 0x04000441 RID: 1089
		public const string STR_TEN_KH = "Tên khách hàng";

		// Token: 0x04000442 RID: 1090
		public const string STR_DIA_CHI = "Địa chỉ";

		// Token: 0x04000443 RID: 1091
		public const string STR_DIEN_THOAI = "Điện thoại";

		// Token: 0x04000444 RID: 1092
		public const string STR_FAX = "Fax";

		// Token: 0x04000445 RID: 1093
		public const string STR_CMND = "Số CMND";

		// Token: 0x04000446 RID: 1094
		public const string STR_NGAY_CAP = "Ngày cấp";

		// Token: 0x04000447 RID: 1095
		public const string STR_NOI_CAP = "Nơi cấp";

		// Token: 0x04000448 RID: 1096
		public const string STR_HO_CHIEU = "Hộ chiếu";

		// Token: 0x04000449 RID: 1097
		public const string STR_GPLX = "GPLX";

		// Token: 0x0400044A RID: 1098
		public const string STR_MST = "Mã số thuế";

		// Token: 0x0400044B RID: 1099
		public const string STR_EMAIL = "Email";

		// Token: 0x0400044C RID: 1100
		public const string STR_MA_THE_TU = "Mã thẻ từ";

		// Token: 0x0400044D RID: 1101
		public const string STR_NHOM_KH = "Thành viên";

		// Token: 0x0400044E RID: 1102
		public const string STR_NGAY = "Ngày";

		// Token: 0x0400044F RID: 1103
		public const string STR_SO_KHACH = "Số khách";

		// Token: 0x04000450 RID: 1104
		public const string STR_NHAN_VIEN = "Nhân viên";

		// Token: 0x04000451 RID: 1105
		public const string STR_BAT_DAU = "Ngày bắt đầu";

		// Token: 0x04000452 RID: 1106
		public const string STR_KET_THUC = "Ngày kết thúc";

		// Token: 0x04000453 RID: 1107
		public const string STR_PHONG = "Phòng";

		// Token: 0x04000454 RID: 1108
		public const string STR_STATUS = "Trạng thái phòng";

		// Token: 0x04000455 RID: 1109
		public const int INDEX_MA_KH = 1;

		// Token: 0x04000456 RID: 1110
		public const int INDEX_TEN_KH = 2;

		// Token: 0x04000457 RID: 1111
		public const int INDEX_MEMBER = 14;

		// Token: 0x04000458 RID: 1112
		public const int INDEX_DAT_SL = 3;

		// Token: 0x04000459 RID: 1113
		public const int INDEX_DOI_GIA = 4;

		// Token: 0x0400045A RID: 1114
		public const int INDEX_CHIET_KHAU = 6;

		// Token: 0x0400045B RID: 1115
		public const int INDEX_GHI_CHU = 7;

		// Token: 0x0400045C RID: 1116
		public static string[] strHeaderKhachHang = new string[]
		{
			"ID",
			"Mã khách hàng",
			"Tên khách hàng",
			"Địa chỉ",
			"Điện thoại",
			"Fax",
			"Số CMND",
			"Ngày cấp",
			"Nơi cấp",
			"Hộ chiếu",
			"GPLX",
			"Mã số thuế",
			"Email",
			"Mã thẻ từ",
			"Thành viên",
			"Ghi chú"
		};

		// Token: 0x0400045D RID: 1117
		public const string STR_TEN_NHOM_KH = "Tên nhóm khách hàng";

		// Token: 0x0400045E RID: 1118
		public const string STR_DIEM_TICH_LUY = "Điểm tích lũy";

		// Token: 0x0400045F RID: 1119
		public const string STR_GIAM_TIEN_HANG = "Tỉ lệ giảm tiền hàng(%)";

		// Token: 0x04000460 RID: 1120
		public const string STR_GIAM_TIEN_GIO = "Tỉ lệ giảm tiền giờ(%)";

		// Token: 0x04000461 RID: 1121
		public const string STR_GIAM_DO_AN = "Tỉ lệ giảm tiền đồ ăn(%)";

		// Token: 0x04000462 RID: 1122
		public const string STR_GIAM_DO_UONG = "Tỉ lệ giảm tiền đồ uống(%)";

		// Token: 0x04000463 RID: 1123
		public const string STR_GIAM_DICH_VU = "Tỉ lệ giảm tiền dịch vụ(%)";

		// Token: 0x04000464 RID: 1124
		public const string STR_GIAM_DO_KHAC = "Tỉ lệ giảm tiền đồ khác(%)";

		// Token: 0x04000465 RID: 1125
		public static string[] strHeaderNhomKhachHang = new string[]
		{
			"ID",
			"Tên nhóm khách hàng",
			"Điểm tích lũy",
			"Tỉ lệ giảm tiền hàng(%)",
			"Tỉ lệ giảm tiền giờ(%)",
			"Tỉ lệ giảm tiền đồ ăn(%)",
			"Tỉ lệ giảm tiền đồ uống(%)",
			"Tỉ lệ giảm tiền dịch vụ(%)",
			"Tỉ lệ giảm tiền đồ khác(%)"
		};

		// Token: 0x04000466 RID: 1126
		public static string[] strHeaderKhachMoPhong = new string[]
		{
			"ID",
			"Tên khách hàng",
			"Địa chỉ",
			"Điện thoại",
			"Số CMND",
			"GPLX",
			"Hộ chiếu",
			"Tên bảng giá",
			"Ngày",
			"Mã thẻ từ",
			"Số khách",
			"Nhân viên",
			"Ngày bắt đầu",
			"Ngày kết thúc",
			"Phòng",
			"Trạng thái phòng"
		};

		// Token: 0x04000467 RID: 1127
		public const string STR_FORMAT_DATETIME_NULL = "__/__/____ __:__";

		// Token: 0x04000468 RID: 1128
		public const string STR_FORMAT_DATETIME = "dd/MM/yyyy HH:mm";

		// Token: 0x04000469 RID: 1129
		public const string STR_FORMAT_DATE = "dd/MM/yyyy";

		// Token: 0x0400046A RID: 1130
		public const string STR_FORMAT_DATE_NULL = "__/__/____";

		// Token: 0x0400046B RID: 1131
		public const string MSG_NHAN_VIEN = "Mời nhập nhân viên thanh toán";

		// Token: 0x0400046C RID: 1132
		public const string STR_MAT_HANG = "Mặt hàng";

		// Token: 0x0400046D RID: 1133
		public const string STR_DVT = "Đơn vị tính";

		// Token: 0x0400046E RID: 1134
		public const string STR_GIO = "Giờ";

		// Token: 0x0400046F RID: 1135
		public const string STR_SO_LUONG = "Số lượng";

		// Token: 0x04000470 RID: 1136
		public const string STR_GIA = "Giá";

		// Token: 0x04000471 RID: 1137
		public const string STR_THANH_TIEN = "Thành tiền";

		// Token: 0x04000472 RID: 1138
		public const string STR_CHIET_KHAU = "Chiết khấu";

		// Token: 0x04000473 RID: 1139
		public static string[] strHeaderMenu = new string[]
		{
			"Mặt hàng",
			"Đơn vị tính",
			"Giờ",
			"Số lượng",
			"Giá",
			"Thành tiền",
			"Chiết khấu",
			"Ghi chú",
			"Phòng"
		};

		// Token: 0x04000474 RID: 1140
		public const string STR_SL_KHACH = "SỐ LƯỢNG KHÁCH";

		// Token: 0x04000475 RID: 1141
		public const string STR_NHAP_SO_KHACH = "Nhập số khách";

		// Token: 0x04000476 RID: 1142
		public const string STR_DAT_TRUOC = "ĐẶT SỐ LƯỢNG";

		// Token: 0x04000477 RID: 1143
		public const string STR_DAT_SL = "Đặt số lượng cho mặt hàng";

		// Token: 0x04000478 RID: 1144
		public const string STR_DOI_GIA = "ĐỔI GIÁ BÁN MẶT HÀNG";

		// Token: 0x04000479 RID: 1145
		public const string STR_DOI_GIA_MAT_HANG = "Đặt số lượng cho mặt hàng";
	}
}

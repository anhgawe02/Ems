Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "E1_Den_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_Den_Chi_Tiet
    ' tương ứng với mộ trường của bảng E1_Den trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_Den_Chi_Tiet
        Public Id_E1 As String ' SSSSSSRRRRRRDDDDBBBYYYYMMDDHHMMEEXXXXXXXXXVNQQQQ
        Public Id_Duong_Thu As String ' Đường thư đóng đến
        Public Id_Chuyen_Thu As String ' Id chuyến thư đóng đến
        Public Id_E2 As String
        Public Id_Ca As String ' Id ca sản xuất
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác bưu phẩm đến
        Public Ma_Quay As Integer ' Mã quầy của giao dịch
        Public Ma_E1 As String ' EEXXXXXXXXXVN: Số hiệu E1
        Public Ngay_Phat_Hanh As Integer ' Ngày chấp nhận bưu phẩm (Tính cước)
        Public Gio_Phat_Hanh As Integer ' Giờ chấp nhận bưu phẩm
        Public Ngay_Dong As Integer ' Ngày đóng BP
        Public Gio_Dong As Integer ' Giờ đóng BP
        Public Ngay_Nhan As Integer ' Ngày nhận BP (được gửi đến từ bưu cục gốc)
        Public Gio_Nhan As Integer ' Giờ nhận BP (được gửi đến từ bưu cục gốc)
        Public Ma_Don_Vi As String ' Mã đơn vị
        Public Ma_Bc_Goc As Integer ' Mã bưu cục chấp nhận bưu phẩm (có thể là mã đầu tỉnh)
        Public Ma_Bc_Tra As Integer ' Mã bưu cục phát trả bưu phẩm (Có thể là mã đầu tỉnh)
        Public Nuoc_Nhan As String ' Nước chấp nhận bưu phẩm
        Public Nuoc_Tra As String ' Nước phát trả BP
        Public Khoi_Luong As Integer ' Khối lượng thực tế BP
        Public Phan_Loai As String ' Phân loại bưu phẩm (D,M)
        Public Loai_Hang_Hoa As Integer ' 0:Hàng bình thường,1: hàng nhẹ,2: hàng cồng kềnh
        Public Khoi_Luong_QD As Integer ' Khối lượng quy đổi của BP: sử dụng trong trường hợp là hàng nhẹ
        Public Loai As Integer ' 0: BP bình thường; 1: Sự vụ
        Public Dv_Cong_Them As String ' Liệt kê các dịch vụ cộng thêm được sử dung, ngăn cách bởi dấu ','
        Public Dv_Gia_Tang As String ' Liệt kê các dịch vụ gia tăng được sử dung, ngăn cách bởi dấu ','
        Public PPXD As Double ' Phụ phí xăng dầu (%)
        Public Cuoc_PPXD As Integer ' Cước phụ phí xăng dầu
        Public PostCode As String ' Mã vùng của nơi phát trả BP đối với BP đi quốc tế (Tính cước Vùng xa)
        Public Cuoc_PPVX As Integer ' Cước phụ phí vùng xa
        Public VAT As Double ' Thuế VAT
        Public COD As Boolean ' Dịch vụ COD
        Public Gia_Tri_Hang As Integer ' Giá trị hàng hóa (Tính cước COD, cước khai giá)
        Public Cuoc_COD As Integer ' Cước dịch vụ COD
        Public Cuoc_DV As Integer ' Cước dịch vụ= Cước dịch vụ cộng thêm + Cước dịch vụ gia tăng
        Public Cuoc_Chinh As Integer ' Cước chính= Cước cơ sở + cước phụ phí xăng dầu + Cước phụ phí vùng xa
        Public Cuoc_Giam As Integer ' Cước được giảm do các chính sách giảm giá, khuyến mại, khách hàng
        Public Cuoc_E1 As Integer ' Cước ghi trên E1
        Public Kien_So As Integer ' Kiện Số (Sử dụng cho hàng 1 vận đơn)
        Public STT As Integer ' Số thứ tự trong bản kê E2
        Public Ma_KH As String ' Mã khách hàng
        Public Nguoi_Gui As String ' Họ tên người gửi
        Public Nguoi_Nhan As String ' Họ tên người nhận
        Public Dia_Chi_Gui As String ' Địa chỉ người gửi
        Public Dia_Chi_Nhan As String ' Địa chỉ người nhận
        Public Dien_Thoai_Gui As String ' Số điện thoại người gửi
        Public Dien_Thoai_Nhan As String ' Số điện thoại người nhận
        Public HH_Phat_Hanh As Integer ' Hoa hồng đại lý phần công chấp nhận BP
        Public HH_Phat_Tra As Integer ' Hoa hồng đại lý phần công phát trả BP
        Public Ma_Bc_CH As Integer ' Mã bưu cục, nơi chuyển hoàn về bưu cục gốc
        Public Id_Nguoi_Dung As Integer ' Nhân viên khai thác
        Public Id_Trang_Thai As Integer ' Trạng thái bưu gửi: đã được xác nhận đến, đã được đóng đi chưa
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean ' Truyền nhận dữ liệu khai thác
        Public Truyen_Doi_Soat As Boolean ' Truyền nhận dữ liệu đối soát
        Public Ngay_He_Thong As Integer ' Ngayf
        Public Chot_SL As Boolean ' Chốt số liệu đối soát sau khi đã được cân đối ca
    End Class

#End Region
#Region "E1_Den"
    Public Class E1_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Den
        ' Input: Id_E1
        ' Output: E1_Den_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myE1_Den_Chi_Tiet As E1_Den_Chi_Tiet = New E1_Den_Chi_Tiet
                myE1_Den_Chi_Tiet.Id_E1 = Id_E1
                myE1_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Den_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Den_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Den_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Den_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Den_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Den_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Den_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Den_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Den_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Den_Chi_Tiet.Loai = pLoai.Value
                myE1_Den_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Den_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Den_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Den_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Den_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Den_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Den_Chi_Tiet.VAT = pVAT.Value
                myE1_Den_Chi_Tiet.COD = pCOD.Value
                myE1_Den_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Den_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Den_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Den_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Den_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Den_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Den_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Den_Chi_Tiet.STT = pSTT.Value
                myE1_Den_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Den_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Den_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Den_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Den_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Den_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Den_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Theo_Ma_E1_Id_Ca_Ma_Bc_Khai_Thac_Trong_E_Shipping"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Den
        ' Input: Id_E1
        ' Output: E1_Den_Chi_Tiet
        Public Function Lay_Theo_Ma_E1_Id_Ca_Ma_Bc_Khai_Thac_Trong_E_Shipping(ByVal Ma_E1 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Theo_Ma_E1_Id_Ca_Ma_Bc_Khai_Thac_Trong_E_Shipping", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                'Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                'pId_Ca.Direction = ParameterDirection.Output
                'myCommand.Parameters.Add(pId_Ca)

                'Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                'pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                'myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quay)

                'Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                'pMa_E1.Direction = ParameterDirection.Output
                'myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Den_Chi_Tiet As E1_Den_Chi_Tiet = New E1_Den_Chi_Tiet
                myE1_Den_Chi_Tiet.Ma_E1 = Ma_E1
                myE1_Den_Chi_Tiet.Id_Ca = Id_Ca
                myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myE1_Den_Chi_Tiet.Id_E1 = pId_E1.Value
                myE1_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Den_Chi_Tiet.Id_E2 = pId_E2.Value
                'myE1_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                'myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                'myE1_Den_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Den_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Den_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Den_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Den_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Den_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Den_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Den_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Den_Chi_Tiet.Loai = pLoai.Value
                myE1_Den_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Den_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Den_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Den_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Den_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Den_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Den_Chi_Tiet.VAT = pVAT.Value
                myE1_Den_Chi_Tiet.COD = pCOD.Value
                myE1_Den_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Den_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Den_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Den_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Den_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Den_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Den_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Den_Chi_Tiet.STT = pSTT.Value
                myE1_Den_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Den_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Den_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Den_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Den_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Den_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Den_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Theo_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Den
        ' Input: Id_E1
        ' Output: E1_Den_Chi_Tiet
        Public Function Lay_Theo_Ma_E1(ByVal Ma_E1 As String, ByVal Ngay_Gioi_Han As Integer) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Theo_Ma_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục         
                Dim pNgay_Gioi_Han As SqlParameter = New SqlParameter("@Ngay_Gioi_Han", SqlDbType.Int)
                pNgay_Gioi_Han.Value = Ngay_Gioi_Han
                myCommand.Parameters.Add(pNgay_Gioi_Han)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Den_Chi_Tiet As E1_Den_Chi_Tiet = New E1_Den_Chi_Tiet
                myE1_Den_Chi_Tiet.Id_E1 = pId_E1.Value
                myE1_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Den_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Den_Chi_Tiet.Ma_E1 = Ma_E1
                myE1_Den_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Den_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Den_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Den_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Den_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Den_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Den_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Den_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Den_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Den_Chi_Tiet.Loai = pLoai.Value
                myE1_Den_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Den_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Den_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Den_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Den_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Den_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Den_Chi_Tiet.VAT = pVAT.Value
                myE1_Den_Chi_Tiet.COD = pCOD.Value
                myE1_Den_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Den_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Den_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Den_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Den_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Den_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Den_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Den_Chi_Tiet.STT = pSTT.Value
                myE1_Den_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Den_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Den_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Den_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Den_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Den_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Den_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Den_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Den_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Id_Nguoi_Dung"
        '' Nguyễn Đức Trung.
        ' Lấy id của người lập bản kê
        ' Input: Id_E2
        Public Function Lay_Id_Nguoi_Dung(ByVal Id_E2 As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select Id_Nguoi_Dung from E1_Den where Id_E2= '" & Id_E2 & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng E1_Den
        ' Input:  Id_Duong_Thu, Id_Chuyen_Thu, Id_E2, Id_Ca, Ma_Bc_Khai_Thac, Ma_Quay, Ma_E1, Ngay_Phat_Hanh, Gio_Phat_Hanh, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Ma_Don_Vi, Ma_Bc_Goc, Ma_Bc_Tra, Nuoc_Nhan, Nuoc_Tra, Khoi_Luong, Phan_Loai, Loai_Hang_Hoa, Khoi_Luong_QD, Loai, Dv_Cong_Them, Dv_Gia_Tang, PPXD, Cuoc_PPXD, PostCode, Cuoc_PPVX, VAT, COD, Gia_Tri_Hang, Cuoc_COD, Cuoc_DV, Cuoc_Chinh, Cuoc_Giam, Cuoc_E1, Kien_So, STT, Ma_KH, Nguoi_Gui, Nguoi_Nhan, Dia_Chi_Gui, Dia_Chi_Nhan, Dien_Thoai_Gui, Dien_Thoai_Nhan, HH_Phat_Hanh, HH_Phat_Tra, Ma_Bc_CH, Id_Nguoi_Dung, Id_Trang_Thai, Ghi_Chu, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_SL,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                pNguoi_Gui.Value = Nguoi_Gui
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Den
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                If Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                If Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                If Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                If Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Den
        ' Input: đối tượng thuộc lớp E1_Den_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myE1_Den_Chi_Tiet As E1_Den_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = myE1_Den_Chi_Tiet.Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myE1_Den_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myE1_Den_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = myE1_Den_Chi_Tiet.Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myE1_Den_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = myE1_Den_Chi_Tiet.Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myE1_Den_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = myE1_Den_Chi_Tiet.Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = myE1_Den_Chi_Tiet.Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myE1_Den_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myE1_Den_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myE1_Den_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myE1_Den_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = myE1_Den_Chi_Tiet.Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = myE1_Den_Chi_Tiet.Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = myE1_Den_Chi_Tiet.Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = myE1_Den_Chi_Tiet.Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = myE1_Den_Chi_Tiet.Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myE1_Den_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = myE1_Den_Chi_Tiet.Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = myE1_Den_Chi_Tiet.Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = myE1_Den_Chi_Tiet.Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = myE1_Den_Chi_Tiet.Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = myE1_Den_Chi_Tiet.Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = myE1_Den_Chi_Tiet.Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = myE1_Den_Chi_Tiet.PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = myE1_Den_Chi_Tiet.Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = myE1_Den_Chi_Tiet.PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = myE1_Den_Chi_Tiet.Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = myE1_Den_Chi_Tiet.VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = myE1_Den_Chi_Tiet.COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = myE1_Den_Chi_Tiet.Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = myE1_Den_Chi_Tiet.Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = myE1_Den_Chi_Tiet.Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = myE1_Den_Chi_Tiet.Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = myE1_Den_Chi_Tiet.Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = myE1_Den_Chi_Tiet.Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = myE1_Den_Chi_Tiet.Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = myE1_Den_Chi_Tiet.STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = myE1_Den_Chi_Tiet.Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                If myE1_Den_Chi_Tiet.Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = myE1_Den_Chi_Tiet.Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                If myE1_Den_Chi_Tiet.Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = myE1_Den_Chi_Tiet.Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                If myE1_Den_Chi_Tiet.Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = myE1_Den_Chi_Tiet.Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                If myE1_Den_Chi_Tiet.Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = myE1_Den_Chi_Tiet.Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If myE1_Den_Chi_Tiet.Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = myE1_Den_Chi_Tiet.Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If myE1_Den_Chi_Tiet.Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = myE1_Den_Chi_Tiet.Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myE1_Den_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myE1_Den_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = myE1_Den_Chi_Tiet.Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myE1_Den_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = myE1_Den_Chi_Tiet.Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = myE1_Den_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myE1_Den_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myE1_Den_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myE1_Den_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = myE1_Den_Chi_Tiet.Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Den
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                If Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                If Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                If Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                If Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E1_Den
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Xoa Tui"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E1_Di
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa_Tui(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Xoa_Tui", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E1_Den
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1"
        Public Function Danh_Sach_E1(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_E1_Lay_Boi_Id_E2", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_E1_Lay_Boi_Id_E2")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_USPS"
        Public Function Danh_Sach_E1_USPS(ByVal Id_E2 As String, ByVal Dau_Ma As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_E1_USPS_Lay_Boi_Id_E2", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                myCommand.CommandTimeout = 20000
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pDau_Ma As SqlParameter = New SqlParameter("@Dau_Ma", SqlDbType.VarChar, 1)
                pDau_Ma.Value = Dau_Ma
                myCommand.Parameters.Add(pDau_Ma)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_E1_USPS_Lay_Boi_Id_E2")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Cap_Nhat_Id_E1"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Di
        ' Input: pId_E2, pId_E2_Moi 
        ' Output: 
        Public Sub Cap_Nhat_Id_E1(ByVal Id_E2 As String, ByVal Id_E2_Sua As String, ByVal Id_Duong_Thu As String, ByVal Id_Duong_Thu_Sua As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Chuyen_Thu_Sua As String, ByVal Id_Ca As String, ByVal Id_Ca_Sua As String, ByVal Ngay_Khai_Thac As Integer, ByVal Ngay_Khai_Thac_Sua As Integer, ByVal Gio As Integer, ByVal Gio_Sua As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat_Id_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_E2_Sua As SqlParameter = New SqlParameter("@Id_E2_Sua", SqlDbType.VarChar, 31)
                pId_E2_Sua.Value = Id_E2_Sua
                myCommand.Parameters.Add(pId_E2_Sua)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Duong_Thu_Sua As SqlParameter = New SqlParameter("@Id_Duong_Thu_Sua", SqlDbType.VarChar, 14)
                pId_Duong_Thu_Sua.Value = Id_Duong_Thu_Sua
                myCommand.Parameters.Add(pId_Duong_Thu_Sua)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Chuyen_Thu_Sua As SqlParameter = New SqlParameter("@Id_Chuyen_Thu_Sua", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu_Sua.Value = Id_Chuyen_Thu_Sua
                myCommand.Parameters.Add(pId_Chuyen_Thu_Sua)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Ca_Sua As SqlParameter = New SqlParameter("@Id_Ca_Sua", SqlDbType.VarChar, 15)
                pId_Ca_Sua.Value = Id_Ca_Sua
                myCommand.Parameters.Add(pId_Ca_Sua)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pNgay_Khai_Thac_Sua As SqlParameter = New SqlParameter("@Ngay_Khai_Thac_Sua", SqlDbType.Int, 4)
                pNgay_Khai_Thac_Sua.Value = Ngay_Khai_Thac_Sua
                myCommand.Parameters.Add(pNgay_Khai_Thac_Sua)

                Dim pGio As SqlParameter = New SqlParameter("@Gio", SqlDbType.Int, 4)
                pGio.Value = Gio
                myCommand.Parameters.Add(pGio)

                Dim pGio_Sua As SqlParameter = New SqlParameter("@Gio_Sua", SqlDbType.Int, 4)
                pGio_Sua.Value = Gio_Sua
                myCommand.Parameters.Add(pGio_Sua)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Lay_Boi_Duong_Thu_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Duong_Thu_Den thông qua khóa chính 
        ' Input: Id_Duong_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Duong_Thu_Den(ByVal Id_Duong_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Duong_Thu_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Duong_Thu_Den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_E2_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng E2_Den thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_E2_Den(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_E2_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_E2_Den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Bc_Khai_Thac thông qua khóa chính 
        ' Input: Ma_Bc_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Báo cáo E1 đến chưa đi và đi chưa đến - DoTQ"
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL") Is Nothing Then
                    myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL")

                Return myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay - Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Call_Store_E1_Chenh_Lech_KL - Update Id_Trang_Thai Dotq"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ca_San_Xuat thông qua khóa chính 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Call_Store_E1_Chenh_Lech_KL(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Lay_Boi_Ca_San_Xuat_E1_Chenh_Lech_KL", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_E1_Chenh_Lech_KL") Is Nothing Then
                    myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_E1_Chenh_Lech_KL").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Lay_Boi_Ca_San_Xuat_E1_Chenh_Lech_KL")

                Return myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_E1_Chenh_Lech_KL")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_Den"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_Den(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            myCommand = New SqlCommand("Select count(*) as Tong_So_Den from E1_Den where Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_Di"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_Di(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            myCommand = New SqlCommand("Select count(*) as Tong_So_Di from E1_Di where Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_KL_Di"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_KL_Di(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            'myCommand = New SqlCommand("Select SUM(Khoi_Luong_BP) as Tong_KL_Di from E2_Di where Id_Ca= '" & Id_Ca & "'", myConnection)
            myCommand = New SqlCommand("Select SUM(Khoi_Luong) as Tong_KL_Di from E1_Di where Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_KL_Den"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_KL_Den(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            'myCommand = New SqlCommand("Select SUM(Khoi_Luong_BP) as Tong_KL_Den from E2_Den where Id_Ca= '" & Id_Ca & "'", myConnection)
            myCommand = New SqlCommand("Select SUM(Khoi_Luong) as Tong_KL_Den from E1_Den where Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_E1_Chenh_Lech_KL - DoTQ"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_E1_Chenh_Lech_KL(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim strSQL As String
            Dim ReturnValue As Long

            'myCommand = New SqlCommand("SELECT COUNT(Ma_E1) as E1_Chenh_Lech_KL FROM E1_DEN WHERE Id_Trang_Thai=1 AND Id_Ca='" & Id_Ca & "'", myConnection)
            strSQL = "SELECT COUNT(A.Ma_E1) as E1_Chenh_Lech_KL FROM E1_DEN A, E1_DI B " & _
                     "WHERE A.Ma_E1 = B.Ma_E1 AND A.Id_Ca = B.Id_Ca AND A.Khoi_Luong <> B.Khoi_Luong AND A.Id_Ca='" & Id_Ca & "'"
            myCommand = New SqlCommand(strSQL, myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_E1_Den_Chua_Di"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_E1_Den_Chua_Di(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long
            Dim strSQL As String

            strSQL = "SELECT COUNT(A.MA_E1) AS E1_Den_Chua_Di " & _
                     "FROM E1_Den A " & _
                     "LEFT JOIN E1_DI B " & _
                     "ON A.MA_E1 = B.MA_E1 AND A.ID_CA = B.ID_CA " & _
                     "WHERE A.ID_CA = '" & Id_Ca & "' AND B.ID_DUONG_THU IS NULL"

            myCommand = New SqlCommand(strSQL, myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_E1_Di_Chua_Den"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_E1_Di_Chua_Den(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long
            Dim strSQL As String

            strSQL = "SELECT COUNT(A.MA_E1) AS E1_Di_Chua_Den " & _
                     "FROM E1_DI A " & _
                     "LEFT JOIN E1_DEN B " & _
                     "ON A.MA_E1 = B.MA_E1 AND A.ID_CA = B.ID_CA " & _
                     "WHERE A.ID_CA = '" & Id_Ca & "' AND B.ID_DUONG_THU IS NULL"

            myCommand = New SqlCommand(strSQL, myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_E1_Den_Nhieu"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_E1_Den_Nhieu(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            myCommand = New SqlCommand("SELECT count(*) From E1_Den Where (Id_Ca='" & Id_Ca & "') And (Ma_E1 in (SELECT distinct(Ma_E1) FROM e1_den WHERE Id_ca='" & Id_Ca & "' GROUP BY ma_e1, id_ca HAVING count(*) > 1))", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Tong_So_E1_Di_Nhieu"
        Public Function Lay_Boi_Ca_San_Xuat_Tong_So_E1_Di_Nhieu(ByVal Id_Ca As String) As Long
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Long

            myCommand = New SqlCommand("SELECT count(*) From E1_Di Where (Id_ca='" & Id_Ca & "') And Ma_E1 in (SELECT Distinct Ma_E1 FROM E1_Di WHERE Id_ca='" & Id_Ca & "' GROUP BY Ma_E1 HAVING count(*) > 1)", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region

#Region "E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac"
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myCommand.CommandTimeout = 20000

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac") Is Nothing Then
                    myDataSet.Tables("E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac")

                Return myDataSet.Tables("E1_Den_Chi_Tiet_Ton_Kho_Lay_Boi_Ma_Bc_Khai_Thac")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region
#Region "Báo cáo E1 đến chưa đi và đi chưa đến_QT - Tach QT Di va QT Den"
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT - TachQT di va QT Den"
        Public Function E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT - Tach QT Di va QT Den"

        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Chua_Di_Tu_Ngay_Den_Ngay_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT - Tach QT Di va QT Den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT - Tach QT di va QT den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Chua_Den_Tu_Ngay_Den_Ngay_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL - Tach QT di va QT den"
        Public Function Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT") Is Nothing Then
                    myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT")

                Return myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT - Tach QT di va QT den"
        Public Function Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT") Is Nothing Then
                    myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT")

                Return myDataSet.Tables("E1_Lay_Boi_Ca_San_Xuat_Danh_Sach_E1_Chenh_Lech_KL_Tu_Ngay_Den_Ngay_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT - Tach QT Di va QT Den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT - tach QT di va Qt den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Den_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT - Tach QT Di va QT Den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT - tach QT di va Qt den"
        Public Function Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca_Tu_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int)
                pId_Ca_Tu_Ngay.Value = Id_Ca_Tu_Ngay
                myCommand.Parameters.Add(pId_Ca_Tu_Ngay)

                Dim pId_Ca_Den_Ngay As SqlParameter = New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int)
                pId_Ca_Den_Ngay.Value = Id_Ca_Den_Ngay
                myCommand.Parameters.Add(pId_Ca_Den_Ngay)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT") Is Nothing Then
                    myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT")

                Return myDataSet.Tables("E1_Den_Lay_Boi_Ca_San_Xuat_E1_Di_Nhieu_Lan_Tu_Ngay_Den_Ngay_QT")

            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region
#Region "E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma"
        Public Function E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma(ByVal Id_E2 As String, ByVal Tu_Dau_Ma As String, ByVal Den_Dau_Ma As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pTu_Dau_Ma As SqlParameter = New SqlParameter("@Tu_Dau_Ma", SqlDbType.VarChar, 1)
                pTu_Dau_Ma.Value = Tu_Dau_Ma
                myCommand.Parameters.Add(pTu_Dau_Ma)

                Dim pDen_Dau_Ma As SqlParameter = New SqlParameter("@Den_Dau_Ma", SqlDbType.VarChar, 1)
                pDen_Dau_Ma.Value = Den_Dau_Ma
                myCommand.Parameters.Add(pDen_Dau_Ma)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Danh_Sach_E1_Den_Da_Chuyen_Ma"
        ' Ngày tạo: 03/11/14
        ' Người tạo: Nguyễn Cương
        ' Nội dung: Lấy dữ liệu từ bảng E1_Den với những E1 được chuyển mã khi xác nhận đến 
        ' Input: Ma_Bc_Khai_Thac, Tu_Ngay, Den_Ngay
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Danh_Sach_E1_Den_Da_Chuyen_Ma(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Danh_Sach_Chuyen_Ma", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Danh_Sach_Chuyen_Ma")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Chuyen_Thu_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Chuyen_Thu_Den(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Chuyen_Thu_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Chuyen_Thu_Den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Sử dụng trong Form sửa chữa E1"
#Region "Lay_Boi_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy 1 E1 từ bảng E1_Di theo mã E1
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_E1(ByVal Ma_E1 As String, ByVal Ma_BC_Khai_Thac As Integer, ByVal Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ma_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pngay As SqlParameter = New SqlParameter("@ngay", SqlDbType.Int)
                pngay.Value = Ngay
                myCommand.Parameters.Add(pngay)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ma_E1")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1"
        Public Function E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1(ByVal Ma_E1 As String, ByVal Ma_BC_Khai_Thac As Integer, ByVal Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pngay As SqlParameter = New SqlParameter("@ngay", SqlDbType.Int)
                pngay.Value = Ngay
                myCommand.Parameters.Add(pngay)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Cap_Nhat_Sua_Chua_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Di
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat_Sua_Chua_E1(ByVal Id_E1 As String, ByVal Id_E1_Moi As String, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Ma_Bc_Goc As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Dv As Integer, ByVal Cuoc_COD As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Cuoc_E1 As Integer, ByVal Ghi_Chu As String, ByVal Loai As Integer, ByVal ppxd As Double, ByVal vat As Double, ByVal Cuoc_PPXD As Integer, ByVal Cuoc_PPVX As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal Id_Trang_Thai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat_Sua_Chua_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_E1_Moi As SqlParameter = New SqlParameter("@Id_E1_Moi", SqlDbType.VarChar, 48)
                pId_E1_Moi.Value = Id_E1_Moi
                myCommand.Parameters.Add(pId_E1_Moi)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Dv As SqlParameter = New SqlParameter("@Cuoc_Dv", SqlDbType.Int, 4)
                pCuoc_Dv.Value = Cuoc_Dv
                myCommand.Parameters.Add(pCuoc_Dv)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)


                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = ppxd
                myCommand.Parameters.Add(pPPXD)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Value = vat
                myCommand.Parameters.Add(pVat)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int)
                pCuoc_PPXD.Value = Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int)
                pCuoc_PPVX.Value = Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#End Region
#Region "Sử dụng trong phần Chốt số liệu"
#Region "Chot_SL_E1_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Chot_SL_E1_Den(ByVal Id_Ca As String, ByVal chot_SL As Boolean) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Chot_SL", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = chot_SL
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Chot_SL")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Chot_SL_E1_Di"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Chot_SL_E1_Di(ByVal Id_Ca As String, ByVal chot_SL As Boolean) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Chot_SL", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = chot_SL
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Chot_SL")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Kiem_Tra_E1_Den_Da_Chot_SL_Chua"
        Public Function Kiem_Tra_E1_Den_Da_Chot_SL_Chua(ByVal Id_Ca As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select Count(*) as Tong_So_Da_Chot from E1_Den where Chot_SL=1 AND Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            myCommand.CommandTimeout = 20000
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Kiem_Tra_E1_Di_Da_Chot_SL_Chua"
        Public Function Kiem_Tra_E1_Di_Da_Chot_SL_Chua(ByVal Id_Ca As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select Count(*) as Tong_So_Da_Chot from E1_Di where Chot_SL=1 AND Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            myCommand.CommandTimeout = 20000
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Kiem_Tra_E1_Den_Co_Du_Lieu_Chua"
        Public Function Kiem_Tra_E1_Den_Co_Du_Lieu_Chua(ByVal Id_Ca As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select Count(*) as Tong_So_E1 from E1_Den where Id_Ca= '" & Id_Ca & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#End Region

#Region "Lay_Boi_Quay_Giao_Dich"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Quay_Giao_Dich thông qua khóa chính 
        ' Input: Ma_Quay
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Quay_Giao_Dich(ByVal Ma_Quay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Quay_Giao_Dich", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Quay_Giao_Dich")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Khach_Hang"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Khach_Hang thông qua khóa chính 
        ' Input: Ma_KH
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Khach_Hang(ByVal Ma_KH As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Khach_Hang", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Khach_Hang")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Khai Thác"

#Region "E1_Den_Lay_Boi_E2_Den_KT"
        ' Ngày tạo: 25/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Den thông qua Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu, Tui_So
        ' Input: Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu, Tui_So
        ' Output: DataSet chứa toàn bộ dữ liệu về
        Public Function E1_Den_Lay_Boi_E2_Den_KT(ByVal Id_Duong_Thu As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer) As DataSet
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_E2_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 12)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)
                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 12)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_E2_Den_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Tong_So_E1"
        Public Function Lay_Tong_So_E1(ByVal Id_E2 As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select count(*) from E1_Den where Id_E2= '" & Id_E2 & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "E1_Den_Lay_Boi_E2_Den_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Den thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E1_Den_Lay_Boi_E2_Den_KT(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_E2_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_E2_Den_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Den_Insert_To_Tmp_E1_Den_KT"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Insert dữ liệu từ bảng chính (E1_Di) sang bảng tạm (Tmp_E1_Di)
        ' Input: Id_E2
        Public Sub E1_Den_Insert_To_Tmp_E1_Den_KT(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Insert_To_Tmp_E1_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Insert_To_Tmp_E1_Den_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "E1_Den_Xoa_Theo_Id_E2_KT"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Xóa dữ liệu từ bảng E1_Di theo Id_E2
        ' Input: Id_E2
        ' Output: 
        Public Sub E1_Den_Xoa_Theo_Id_E2_KT(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Xoa_Theo_Id_E2_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 48)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Ngay(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .Ghi_Chu = myDataSet.Tables(0).Rows(0)("Ghi_Chu")
                        .Dia_Chi_Gui = myDataSet.Tables(0).Rows(0)("Dia_Chi_Gui")
                        .Dia_Chi_Nhan = myDataSet.Tables(0).Rows(0)("Dia_Chi_Nhan")
                        .Nguoi_Gui = myDataSet.Tables(0).Rows(0)("Nguoi_Gui")
                        .Nguoi_Nhan = myDataSet.Tables(0).Rows(0)("Nguoi_Nhan")

                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Dung_Trong_Kiem_Hoa"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Dung_Trong_Kiem_Hoa(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_E2 = myDataSet.Tables(0).Rows(0)("Id_E2")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .Ma_E1 = myDataSet.Tables(0).Rows(0)("Ma_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("PostCode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_DV")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Ma_KH = myDataSet.Tables(0).Rows(0)("Ma_KH")
                        .Nguoi_Gui = myDataSet.Tables(0).Rows(0)("Nguoi_Gui")
                        .Nguoi_Nhan = myDataSet.Tables(0).Rows(0)("Nguoi_Nhan")
                        .Dia_Chi_Gui = myDataSet.Tables(0).Rows(0)("Dia_Chi_Gui")
                        .Dia_Chi_Nhan = myDataSet.Tables(0).Rows(0)("Dia_Chi_Nhan")
                        .Dien_Thoai_Gui = myDataSet.Tables(0).Rows(0)("Dien_Thoai_Gui")
                        .Dien_Thoai_Nhan = myDataSet.Tables(0).Rows(0)("Dien_Thoai_Nhan")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_CH")
                        .Id_Nguoi_Dung = myDataSet.Tables(0).Rows(0)("Id_Nguoi_Dung")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ghi_Chu = myDataSet.Tables(0).Rows(0)("Ghi_Chu")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_SL = myDataSet.Tables(0).Rows(0)("Chot_SL")
                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                    myE1_Den_Chi_Tiet.Id_Duong_Thu = ""
                    myE1_Den_Chi_Tiet.Id_Chuyen_Thu = ""
                    myE1_Den_Chi_Tiet.Id_E2 = ""
                    myE1_Den_Chi_Tiet.Id_Ca = ""
                    myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac = 0
                    myE1_Den_Chi_Tiet.Ma_Quay = 0
                    myE1_Den_Chi_Tiet.Ma_E1 = MA_E1
                    myE1_Den_Chi_Tiet.Ngay_Phat_Hanh = 0
                    myE1_Den_Chi_Tiet.Gio_Phat_Hanh = 0
                    myE1_Den_Chi_Tiet.Ngay_Dong = 0
                    myE1_Den_Chi_Tiet.Gio_Dong = 0
                    myE1_Den_Chi_Tiet.Ngay_Nhan = 0
                    myE1_Den_Chi_Tiet.Gio_Nhan = 0
                    myE1_Den_Chi_Tiet.Ma_Don_Vi = ""
                    myE1_Den_Chi_Tiet.Ma_Bc_Goc = 0
                    myE1_Den_Chi_Tiet.Ma_Bc_Tra = 0
                    myE1_Den_Chi_Tiet.Nuoc_Nhan = ""
                    myE1_Den_Chi_Tiet.Nuoc_Tra = ""
                    myE1_Den_Chi_Tiet.Khoi_Luong = 0
                    myE1_Den_Chi_Tiet.Phan_Loai = ""
                    myE1_Den_Chi_Tiet.Loai_Hang_Hoa = 0
                    myE1_Den_Chi_Tiet.Khoi_Luong_QD = 0
                    myE1_Den_Chi_Tiet.Loai = 0
                    myE1_Den_Chi_Tiet.Dv_Cong_Them = ""
                    myE1_Den_Chi_Tiet.Dv_Gia_Tang = ""
                    myE1_Den_Chi_Tiet.PPXD = 0.0
                    myE1_Den_Chi_Tiet.Cuoc_PPXD = 0
                    myE1_Den_Chi_Tiet.PostCode = ""
                    myE1_Den_Chi_Tiet.Cuoc_PPVX = 0
                    myE1_Den_Chi_Tiet.VAT = 0.0
                    myE1_Den_Chi_Tiet.COD = 0
                    myE1_Den_Chi_Tiet.Gia_Tri_Hang = 0
                    myE1_Den_Chi_Tiet.Cuoc_COD = 0
                    myE1_Den_Chi_Tiet.Cuoc_DV = 0
                    myE1_Den_Chi_Tiet.Cuoc_Chinh = 0
                    myE1_Den_Chi_Tiet.Cuoc_Giam = 0
                    myE1_Den_Chi_Tiet.Cuoc_E1 = 0
                    myE1_Den_Chi_Tiet.Kien_So = 0
                    myE1_Den_Chi_Tiet.STT = 0
                    myE1_Den_Chi_Tiet.Ma_KH = ""
                    myE1_Den_Chi_Tiet.Nguoi_Gui = ""
                    myE1_Den_Chi_Tiet.Nguoi_Nhan = ""
                    myE1_Den_Chi_Tiet.Dia_Chi_Gui = ""
                    myE1_Den_Chi_Tiet.Dia_Chi_Nhan = ""
                    myE1_Den_Chi_Tiet.Dien_Thoai_Gui = ""
                    myE1_Den_Chi_Tiet.Dien_Thoai_Nhan = ""
                    myE1_Den_Chi_Tiet.HH_Phat_Hanh = 0
                    myE1_Den_Chi_Tiet.HH_Phat_Tra = 0
                    myE1_Den_Chi_Tiet.Ma_Bc_CH = 0
                    myE1_Den_Chi_Tiet.Id_Nguoi_Dung = 0
                    myE1_Den_Chi_Tiet.Id_Trang_Thai = 0
                    myE1_Den_Chi_Tiet.Ghi_Chu = ""
                    myE1_Den_Chi_Tiet.Truyen_Khai_Thac = 0
                    myE1_Den_Chi_Tiet.Truyen_Doi_Soat = 0
                    myE1_Den_Chi_Tiet.Ngay_He_Thong = 0
                    myE1_Den_Chi_Tiet.Chot_SL = 0
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .Ghi_Chu = myDataSet.Tables(0).Rows(0)("Ghi_Chu")
                        .Dia_Chi_Gui = myDataSet.Tables(0).Rows(0)("Dia_Chi_Gui")
                        .Dia_Chi_Nhan = myDataSet.Tables(0).Rows(0)("Dia_Chi_Nhan")
                        .Nguoi_Gui = myDataSet.Tables(0).Rows(0)("Nguoi_Gui")
                        .Nguoi_Nhan = myDataSet.Tables(0).Rows(0)("Nguoi_Nhan")

                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT"
        ' Ngày tạo: 18/02/09
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra dữ liệu xác nhận đến trong ca
        ' Input: MA_E1, Id_Ca
        ' Output: E1_Den_Chi_Tiet
        Public Function E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT(ByVal MA_E1 As String, ByVal Id_Ca As String) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet


                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .Ghi_Chu = myDataSet.Tables(0).Rows(0)("Ghi_Chu")
                        .Dia_Chi_Gui = myDataSet.Tables(0).Rows(0)("Dia_Chi_Gui")
                        .Dia_Chi_Nhan = myDataSet.Tables(0).Rows(0)("Dia_Chi_Nhan")
                        .Nguoi_Gui = myDataSet.Tables(0).Rows(0)("Nguoi_Gui")
                        .Nguoi_Nhan = myDataSet.Tables(0).Rows(0)("Nguoi_Nhan")
                        .Dien_Thoai_Gui = myDataSet.Tables(0).Rows(0)("Dien_Thoai_Gui")
                        .Dien_Thoai_Nhan = myDataSet.Tables(0).Rows(0)("Dien_Thoai_Nhan")
                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: kiểm tra trùng dữ liệu trong cùng chuyến thư đóng đến
        ' Input: MA_E1, Id_Chuyen_Thu
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(ByVal MA_E1 As String, ByVal Id_Chuyen_Thu As String) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: kiểm tra trùng dữ liệu trong cùng ca khai thac
        ' Input: MA_E1, Id_Chuyen_Thu
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(ByVal MA_E1 As String, ByVal Id_Ca As String) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Lay_Boi_Id_E2_KT"
        ' Ngày tạo: 26/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Den thông qua Id_E2
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu về
        Public Function E1_Den_Lay_Boi_Id_E2_KT(ByVal Id_E2 As String) As DataSet
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Id_E2_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Id_E2_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Chuyen_Doi_Dau_Ma"
        Public Sub E1_Den_Chuyen_Doi_Dau_Ma(ByVal Id_E2 As String, ByVal Tu_Dau As String, ByVal Thanh_Dau As String)
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Chuyen_Doi_Dau_Ma", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                myCommand.CommandTimeout = 20000

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pTu_Dau As SqlParameter = New SqlParameter("@Tu_Dau", SqlDbType.VarChar, 2)
                pTu_Dau.Value = Tu_Dau
                myCommand.Parameters.Add(pTu_Dau)

                Dim pThanh_Dau As SqlParameter = New SqlParameter("@Thanh_Dau", SqlDbType.VarChar, 2)
                pThanh_Dau.Value = Thanh_Dau
                myCommand.Parameters.Add(pThanh_Dau)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "E1_Den_Lay_Boi_Id_E2_Le_Phi_HQ_KT"
        ' Ngày tạo: 26/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Den thông qua Id_E2
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu về
        Public Function E1_Den_Lay_Boi_Id_E2_Le_Phi_HQ_KT(ByVal Id_E2 As String) As DataSet
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Lay_Boi_Id_E2_Le_Phi_HQ_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Den_Lay_Boi_Id_E2_Le_Phi_HQ_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Den_Cap_Nhat_Them_KT"
        ' Ngày tạo: 26/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật thêm dữ liệu vào bảng E1_Den
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        ' Output: 
        Public Sub E1_Den_Cap_Nhat_Them_KT(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat_Them_KT", myConnection)

                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                If Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                If Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                If Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                If Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT"
        ' Ngày tạo: 25/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Den thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT(ByVal MA_E1 As String, ByVal Id_E2 As String) As E1_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMA_E1 As SqlParameter = New SqlParameter("@MA_E1", SqlDbType.VarChar, 13)
                pMA_E1.Value = MA_E1
                myCommand.Parameters.Add(pMA_E1)
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Chi_Tiet
                        .Id_E1 = myDataSet.Tables(0).Rows(0)("Id_E1")
                        .Ngay_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Ngay_Phat_Hanh")
                        .Gio_Phat_Hanh = myDataSet.Tables(0).Rows(0)("Gio_Phat_Hanh")
                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(0)("Ma_Bc_Goc")
                        .Ma_Don_Vi = myDataSet.Tables(0).Rows(0)("Ma_Don_Vi")
                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(0)("Ma_Bc_Tra")
                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(0)("Nuoc_Nhan")
                        .Nuoc_Tra = myDataSet.Tables(0).Rows(0)("Nuoc_Tra")
                        .Khoi_Luong = myDataSet.Tables(0).Rows(0)("Khoi_Luong")
                        .Phan_Loai = myDataSet.Tables(0).Rows(0)("Phan_Loai")
                        .Loai_Hang_Hoa = myDataSet.Tables(0).Rows(0)("Loai_Hang_Hoa")
                        .Khoi_Luong_QD = myDataSet.Tables(0).Rows(0)("Khoi_Luong_QD")
                        .Loai = myDataSet.Tables(0).Rows(0)("Loai")
                        .PPXD = myDataSet.Tables(0).Rows(0)("PPXD")
                        .Cuoc_PPXD = myDataSet.Tables(0).Rows(0)("Cuoc_PPXD")
                        .PostCode = myDataSet.Tables(0).Rows(0)("Postcode")
                        .Cuoc_PPVX = myDataSet.Tables(0).Rows(0)("Cuoc_PPVX")
                        .VAT = myDataSet.Tables(0).Rows(0)("VAT")
                        .COD = myDataSet.Tables(0).Rows(0)("COD")
                        .Gia_Tri_Hang = myDataSet.Tables(0).Rows(0)("Gia_Tri_Hang")
                        .Cuoc_Giam = myDataSet.Tables(0).Rows(0)("Cuoc_Giam")
                        .Cuoc_E1 = myDataSet.Tables(0).Rows(0)("Cuoc_E1")
                        .Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Cuoc_Chinh")
                        .Cuoc_COD = myDataSet.Tables(0).Rows(0)("Cuoc_COD")
                        .Dv_Cong_Them = myDataSet.Tables(0).Rows(0)("Dv_Cong_Them")
                        .Dv_Gia_Tang = myDataSet.Tables(0).Rows(0)("Dv_Gia_Tang")
                        .Cuoc_DV = myDataSet.Tables(0).Rows(0)("Cuoc_Dv")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .Id_Trang_Thai = myDataSet.Tables(0).Rows(0)("Id_Trang_Thai")
                        .Ma_Bc_CH = myDataSet.Tables(0).Rows(0)("Ma_Bc_Ch")
                    End With
                Else
                    myE1_Den_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Den_Kiem_Tra_Loi_KT"
        ' Ngày tạo: 05/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra xem bản kê này có bị lỗi không: (bị lỗi khi không có Số hiệu E1 tương ứng với Id_E2)
        ' Input: Id_E2
        ' Output: Tổng số Bưu phẩm
        Public Function E1_Den_Kiem_Tra_Loi_KT(ByVal Id_E2 As String) As Integer
            Try

                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Kiem_Tra_Loi_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim Tong_So_BP As Integer

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 27)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 12)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pTong_So_BP.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region

#Region "Danh_Sach_E1_Truyen"
        ' Ngày tạo: 04/09/2008
        ' Người tạo: Đỗ QUốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet 
        Public Function Danh_Sach_E1_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function

#End Region
#Region "Cap_Nhat_Truyen_Khai_Thac"
        ' Ngày tạo: 04/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật dữ liệu truyền khai thác
        ' Input: Id_Chuyen_Thu
        ' Output: 
        Public Sub Cap_Nhat_Truyen_Khai_Thac(ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Cap_Nhat_Truyen_Khai_Thac", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "Sử dụng trong chức năng báo cáo hải quan"
#Region "E1_Den_Danh_Sach_Chuyen_Hoan_Theo_Ngay_Ma_Bc_Khai_Thac"

        Public Function E1_Den_Danh_Sach_Chuyen_Hoan_Theo_Ngay_Ma_Bc_Khai_Thac(ByVal Loai As Boolean, ByVal Ngay_Khai_Thac As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Duong_Thu As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Ngay_Dong
            ' Ma_Duong_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Ma_Tinh
            ' Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_Danh_Sach_Chuyen_Hoan_Theo_Ngay_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Bit, 0)
                pLoai.Value = Loai
                MyCommand.Parameters.Add(pLoai)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 0)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                MyCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                MyCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                MyCommand.Parameters.Add(pId_Duong_Thu)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region
#End Region

#Region "Su dung trong chuc nang khoa so lieu - dung de insert vao bang HUONG_DI_BUU_PHAM_QUOC_TE_DEN"
#Region "E1_Den_Danh_Sach_Quoc_Te_Den_Lay_Boi_Id_Ca"

        Public Function E1_Den_Danh_Sach_Quoc_Te_Den_Lay_Boi_Id_Ca(ByVal Id_Ca As String) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nuoc_Nhan
            ' Phan_Loai
            ' Khoi_Luong
            ' Ngay_Dong
            ' Id_E1
            ' Ngay_Den
            ' Gio_Den


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_Danh_Sach_Quoc_Te_Den_Lay_Boi_Id_Ca"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                MyCommand.Parameters.Add(pId_Ca)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region
#End Region

#Region "Sử dụng trong chức năng Bưu phẩm bưu kiện"
#Region "E1_Den_Bao_Cao_Buu_Pham_Buu_Kien_Tu_Ngay_Den_Ngay"

        Public Function E1_Den_Bao_Cao_Buu_Pham_Buu_Kien_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Tong_SL_Den
            ' Tong_KL_Den
            ' Tong_SL_Chuyen_Tiep
            ' Tong_KL_Chuyen_Tiep
            ' Tong_SL_CPCPN
            ' Tong_KL_CPCPN


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_Bao_Cao_Buu_Pham_Buu_Kien_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                MyCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                Adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                Adapter.Dispose()
            End Try
        End Function
#End Region
#End Region

#Region "E1_Den_Danh_Sach_Lay_Boi_Id_Ca"
        ' Ngày tạo: 22/04/2011
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Den
        ' Input: 
        ' Output: DataSet 
        Public Function E1_Den_Danh_Sach_Lay_Boi_Id_Ca(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_Lay_Boi_Id_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_Lay_Boi_Id_Ca")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "E1_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping"
        Public Function E1_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping(ByVal Id_E1 As String, ByVal Ma_E1_Moi As String, ByVal Id_E1_Moi As String) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Den_Cap_Nhat_Id_E1_Ma_E1_E_Shipping"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_E1_Moi As SqlParameter = New SqlParameter("@Ma_E1_Moi", SqlDbType.VarChar, 13)
                pMa_E1_Moi.Value = Ma_E1_Moi
                MyCommand.Parameters.Add(pMa_E1_Moi)

                Dim pId_E1_Moi As SqlParameter = New SqlParameter("@Id_E1_Moi", SqlDbType.VarChar, 48)
                pId_E1_Moi.Value = Id_E1_Moi
                MyCommand.Parameters.Add(pId_E1_Moi)


                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()

                Return numRows
                'Return numRows

            Catch ex As Exception

                ' Call the exception handler
                Console.Write(ex.ToString)

            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()

            End Try
        End Function

#End Region

#Region "E1_Den_Danh_Sach_Nuoc_Nhan_Lay_Boi_Id_Chuyen_Thu"
        Public Function E1_Den_Danh_Sach_Nuoc_Nhan_Lay_Boi_Id_Chuyen_Thu(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_Nuoc_Nhan_Lay_Boi_Id_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_Nuoc_Nhan_Lay_Boi_Id_Chuyen_Thu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "E1_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Nuoc_Nhan"
        Public Function E1_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Nuoc_Nhan(ByVal Id_Chuyen_Thu As String, ByVal Nuoc_Nhan As String, ByVal Ma_Nuoc_Duong_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Nuoc_Nhan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Nuoc_Duong_Thu As SqlParameter = New SqlParameter("@Ma_Nuoc_Duong_Thu", SqlDbType.VarChar, 2)
                pMa_Nuoc_Duong_Thu.Value = Ma_Nuoc_Duong_Thu
                myCommand.Parameters.Add(pMa_Nuoc_Duong_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Nuoc_Nhan")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "E1_Den_Danh_Sach_Hang_Den_Gui_Email_Theo_Id_Ca"
        ' Ngày tạo: 22/04/2011
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Den
        ' Input: 
        ' Output: DataSet 
        Public Function E1_Den_Danh_Sach_Hang_Den_Gui_Email_Theo_Id_Ca(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Danh_Sach_Hang_Den_Gui_Email_Theo_Id_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Danh_Sach_Hang_Den_Gui_Email_Theo_Id_Ca")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Kiem_Tra_E1_Den_Da_Chuyen_Dau_Ma_OK"
        Public Function Kiem_Tra_E1_Den_Da_Chuyen_Dau_Ma_OK(ByVal Id_E2 As String, ByVal Dau_Ma As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("select count(*) from E1_Den where Id_E2 = '" & Id_E2 & "' And substring(Ma_E1,1,1) = '" & Dau_Ma & "' AND Nuoc_Tra='VN'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            myCommand.CommandTimeout = 20000
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region

    End Class
#End Region
End Namespace

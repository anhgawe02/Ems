
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "E1_Den_Tam_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_Den_Tam_Chi_Tiet
    ' tương ứng với mộ trường của bảng E1_Den_Tam trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_Den_Tam_Chi_Tiet
        Public Id_E1 As String
        Public Id_Duong_Thu As String ' Đường thư đóng đến
        Public Id_Chuyen_Thu As String ' Id chuyến thư đóng đến
        Public Id_E2 As String
        Public Id_Ca As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Quay As Integer ' Mã quầy giao dịch
        Public Ma_E1 As String
        Public Ngay_Phat_Hanh As Integer
        Public Gio_Phat_Hanh As Integer
        Public Ngay_Dong As Integer
        Public Gio_Dong As Integer
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Don_Vi As String
        Public Ma_Bc_Goc As Integer ' Bưu cục chấp nhận BP (Có thể chỉ là mã tỉnh)
        Public Ma_Bc_Tra As Integer ' Bưu cục phát trả BP (Có thể chỉ là mã tỉnh)
        Public Nuoc_Nhan As String ' Nước chấp nhận BP
        Public Nuoc_Tra As String ' Nước phát trả BP
        Public Khoi_Luong As Integer ' Khối lượng thực tế của BP
        Public Phan_Loai As String ' Phân loại hàng hóa (D,M)
        Public Loai_Hang_Hoa As Integer ' 0: Hàng bình thường; 1: Hàng nhẹ; 2: Hàng cồng kềnh
        Public Khoi_Luong_QD As Integer ' Khối lượng quy đổi (Hàng nhẹ), sử dụng để tính cước
        Public Loai As Integer ' 0: Hàng bỉnh thường; 1: Sự vụ
        Public Dv_Cong_Them As String ' Liệt kê các dịch vụ cộng thêm được sử dụng, phân cách bằng dấu ','
        Public Dv_Gia_Tang As String ' Liệt kê các dịch vụ gia tăng được sử dụng, phân cách bằng dấu ','
        Public PPXD As Double
        Public Cuoc_PPXD As Integer
        Public PostCode As String
        Public Cuoc_PPVX As Integer
        Public VAT As Double
        Public COD As Boolean ' Dịch vụ COD
        Public Gia_Tri_Hang As Integer ' Giá trị hàng hóa được khai (Tính cước COD, cước khai giá)
        Public Cuoc_COD As Integer ' Cước dịch vụ COD
        Public Cuoc_DV As Integer ' Cước dịch vụ= Cước dịch vụ cộng thêm + Cước dịch vụ gia tăng
        Public Cuoc_Chinh As Integer ' Cước chính= Cước cơ sở + cước phụ phí xăng dầu + Cước phụ phí vùng xa
        Public Cuoc_Giam As Integer ' Cước giảm do các chính sách giảm giá, khuyến mại
        Public Cuoc_E1 As Integer ' Cước ghi trên E1
        Public Kien_So As Integer ' Kiện Số (Sử dụng cho hàng 1 vận đơn)
        Public STT As Integer ' Số thứ tự trong bản kê E2
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public HH_Phat_Hanh As Integer
        Public HH_Phat_Tra As Integer
        Public Ma_Bc_CH As Integer ' Mã bưu cục chuyển hoàn
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer ' Trạng thái bưu gửi: đã được xác nhận đến, đã được đóng đi chưa
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean ' Trạng thái truyền dữ liệu khai thác
        Public Truyen_Doi_Soat As Boolean ' Trạng thái truyền dữ liệu đối soát sau khi đã được cân đối ca
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean ' Xác định số liệu đã được chốt sau khi cân đối ca chưa
    End Class
#End Region
#Region "E1_Den_Tam"
    Public Class E1_Den_Tam
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Den_Tam
        ' Input: Id_E1
        ' Output: E1_Den_Tam_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As E1_Den_Tam_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay", myConnection)

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
                Dim myE1_Den_Tam_Chi_Tiet As E1_Den_Tam_Chi_Tiet = New E1_Den_Tam_Chi_Tiet
                myE1_Den_Tam_Chi_Tiet.Id_E1 = Id_E1
                myE1_Den_Tam_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Den_Tam_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Den_Tam_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Den_Tam_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Den_Tam_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Den_Tam_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Den_Tam_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Den_Tam_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Den_Tam_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Den_Tam_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Den_Tam_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Den_Tam_Chi_Tiet.Loai = pLoai.Value
                myE1_Den_Tam_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Den_Tam_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Den_Tam_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Den_Tam_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Den_Tam_Chi_Tiet.VAT = pVAT.Value
                myE1_Den_Tam_Chi_Tiet.COD = pCOD.Value
                myE1_Den_Tam_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Den_Tam_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Den_Tam_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Den_Tam_Chi_Tiet.STT = pSTT.Value
                myE1_Den_Tam_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Den_Tam_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Den_Tam_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Den_Tam_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Den_Tam_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Den_Tam_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Den_Tam_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Den_Tam_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Den_Tam_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Den_Tam_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Den_Tam_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Den_Tam_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Den_Tam_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Den_Tam_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng E1_Den_Tam
        ' Input:  Id_Duong_Thu, Id_Chuyen_Thu, Id_E2, Id_Ca, Ma_Bc_Khai_Thac, Ma_Quay, Ma_E1, Ngay_Phat_Hanh, Gio_Phat_Hanh, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Ma_Don_Vi, Ma_Bc_Goc, Ma_Bc_Tra, Nuoc_Nhan, Nuoc_Tra, Khoi_Luong, Phan_Loai, Loai_Hang_Hoa, Khoi_Luong_QD, Loai, Dv_Cong_Them, Dv_Gia_Tang, PPXD, Cuoc_PPXD, PostCode, Cuoc_PPVX, VAT, COD, Gia_Tri_Hang, Cuoc_COD, Cuoc_DV, Cuoc_Chinh, Cuoc_Giam, Cuoc_E1, Kien_So, STT, Ma_KH, Nguoi_Gui, Nguoi_Nhan, Dia_Chi_Gui, Dia_Chi_Nhan, Dien_Thoai_Gui, Dien_Thoai_Nhan, HH_Phat_Hanh, HH_Phat_Tra, Ma_Bc_CH, Id_Nguoi_Dung, Id_Trang_Thai, Ghi_Chu, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_SL,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Them", myConnection)

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

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 35)
                pNguoi_Gui.Value = Nguoi_Gui
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 35)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 105)
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 105)
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
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Den_Tam
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Cap_Nhat", myConnection)

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

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 35)
                If Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 35)
                If Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 105)
                If Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 105)
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
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Den_Tam
        ' Input: đối tượng thuộc lớp E1_Den_Tam_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myE1_Den_Tam_Chi_Tiet As E1_Den_Tam_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = myE1_Den_Tam_Chi_Tiet.Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myE1_Den_Tam_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myE1_Den_Tam_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = myE1_Den_Tam_Chi_Tiet.Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myE1_Den_Tam_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = myE1_Den_Tam_Chi_Tiet.Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myE1_Den_Tam_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = myE1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = myE1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myE1_Den_Tam_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myE1_Den_Tam_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = myE1_Den_Tam_Chi_Tiet.Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = myE1_Den_Tam_Chi_Tiet.Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myE1_Den_Tam_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = myE1_Den_Tam_Chi_Tiet.Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = myE1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = myE1_Den_Tam_Chi_Tiet.Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = myE1_Den_Tam_Chi_Tiet.Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = myE1_Den_Tam_Chi_Tiet.Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = myE1_Den_Tam_Chi_Tiet.Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = myE1_Den_Tam_Chi_Tiet.PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = myE1_Den_Tam_Chi_Tiet.PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = myE1_Den_Tam_Chi_Tiet.VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = myE1_Den_Tam_Chi_Tiet.COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = myE1_Den_Tam_Chi_Tiet.Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = myE1_Den_Tam_Chi_Tiet.Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = myE1_Den_Tam_Chi_Tiet.Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = myE1_Den_Tam_Chi_Tiet.STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = myE1_Den_Tam_Chi_Tiet.Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 35)
                If myE1_Den_Tam_Chi_Tiet.Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = myE1_Den_Tam_Chi_Tiet.Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 35)
                If myE1_Den_Tam_Chi_Tiet.Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 105)
                If myE1_Den_Tam_Chi_Tiet.Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = myE1_Den_Tam_Chi_Tiet.Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 105)
                If myE1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = myE1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myE1_Den_Tam_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myE1_Den_Tam_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = myE1_Den_Tam_Chi_Tiet.Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myE1_Den_Tam_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = myE1_Den_Tam_Chi_Tiet.Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = myE1_Den_Tam_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myE1_Den_Tam_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myE1_Den_Tam_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myE1_Den_Tam_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = myE1_Den_Tam_Chi_Tiet.Chot_SL
                myCommand.Parameters.Add(pChot_SL)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Den_Tam
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Cap_Nhat_Them", myConnection)

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

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 35) 'Chỉnh từ 100 -> 35 đáp ứng IPS 
                pNguoi_Gui.Value = Nguoi_Gui
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 35) 'Chỉnh từ 100 -> 35 đáp ứng IPS
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 105) 'Chỉnh từ 200 -> 105 đáp ứng IPS
                pDia_Chi_Gui.Value = Dia_Chi_Gui
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 105) 'Chỉnh từ 200 -> 105 đáp ứng IPS
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
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E1_Den_Tam
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Xoa", myConnection)

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
                Console.Write(ex.toString)


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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Xoa_Tui", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E1_Den_Tam
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
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

            myCommand = New SqlCommand("Select Id_Nguoi_Dung from E1_Di where Id_E2= '" & Id_E2 & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Boi_Duong_Thu_Den", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Boi_Duong_Thu_Den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_E2_Den_Tam"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng E2_Den_Tam thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_E2_Den_Tam(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Boi_E2_Den_Tam", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Boi_E2_Den_Tam")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Chuyen_Thu_Den_Tam"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den_Tam thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Chuyen_Thu_Den_Tam(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Boi_Chuyen_Thu_Den_Tam", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Boi_Chuyen_Thu_Den_Tam")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Boi_Quay_Giao_Dich", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Boi_Quay_Giao_Dich")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Boi_Khach_Hang", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Boi_Khach_Hang")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Khai Thác"
#Region "E1_Den_Tam_Insert_To_E1_Den_KT"
        ' Ngày tạo: 15/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu truyền về: Insert dữ liệu từ bảng tạm (E1_Den_Tam) sang bảng chính (Tmp_E1_Den)
        ' Input: Id_Chuyen_Thu,Id_E2, Id_Ca, Ma_Bc_Khai_Thac,Id_Nguoi_Dung,Id_E2_Truyen
        Public Sub E1_Den_Tam_Insert_To_E1_Den_KT(ByVal Id_E2 As String, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Insert_To_E1_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Insert_To_E1_Den_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT"
        ' Ngày tạo: 15/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu truyền về: Insert dữ liệu từ bảng tạm (E1_Den_Tam) sang bảng chính (Tmp_E1_Den),bang le phi
        ' Input: Id_E2, Id_Ca, Ma_Bc_Khai_Thac
        Public Sub E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT(ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_E2_Truyen As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 12)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_E2_Truyen As SqlParameter = New SqlParameter("@Id_E2_Truyen", SqlDbType.VarChar, 31)
                pId_E2_Truyen.Value = Id_E2_Truyen
                myCommand.Parameters.Add(pId_E2_Truyen)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_New"
        ' Ngày tạo: 09/06/09
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu truyền về: Insert dữ liệu từ bảng tạm (E1_Den_Tam) sang bảng chính (Tmp_E1_Den),bang le phi
        ' Input: Id_E2, Id_Ca, Ma_Bc_Khai_Thac
        Public Sub E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_New(ByVal Id_E2 As String, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Nguoi_Dung As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_New", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 12)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT_New")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "E1_Den_Tam_E1_Den_Tam_Lay_Du_Lieu_Truyen_KT"
        ' Ngày tạo: 16/12/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu truyền về: Insert dữ liệu từ bảng tạm (E1_Den_Tam) sang bảng chính (Tmp_E1_Den)
        ' Input: Id_Duong_Thu,Ngay_Dong,So_Chuyen_Thu,Loai_Chuyen_Thu,Tui_So,Ngay_Nhan,Gio_Nhan,Id_Ca, Ma_Bc_Khai_Thac
        Public Sub E1_Den_Tam_Lay_Du_Lieu_Truyen_KT(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Tui_So As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Id_ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Nguoi_Dung As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Lay_Du_Lieu_Truyen_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 12)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 12)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                myCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 12)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 12)
                pNgay_Nhan.Value = Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 12)
                pGio_Nhan.Value = Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 12)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Lay_Du_Lieu_Truyen_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As E1_Den_Tam_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Den_Tam_Chi_Tiet As New E1_Den_Tam_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Den_Tam_Chi_Tiet
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
                        '.Kien_So = myDataSet.Tables(0).Rows(0)("Kien_So")


                    End With
                Else
                    myE1_Den_Tam_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Den_Tam_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Den_Tam_Cap_Nhat_Them_KT"
        ' Ngày tạo: 17/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật thêm dữ liệu vào bảng E1_Den_Tam
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        ' Output: 
        Public Sub E1_Den_Tam_Cap_Nhat_Them_KT(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Den_Tam_Cap_Nhat_Them_KT", myConnection)

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
#End Region

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
#End Region
End Namespace

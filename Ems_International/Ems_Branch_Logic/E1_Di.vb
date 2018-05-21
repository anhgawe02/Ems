
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Namespace EMS
#Region "E1_Di_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E1_Di_Chi_Tiet
    ' tương ứng với mộ trường của bảng E1_Di trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E1_Di_Chi_Tiet
        Public Id_E1 As String ' SSSSSSRRRRRRDDDDBBBYYYYMMDDHHMMEEXXXXXXXXXVNQQQQ
        Public Id_Duong_Thu As String ' Đường thư đóng đi
        Public Id_Chuyen_Thu As String ' Id chuyến thư đóng đi
        Public Id_E2 As String ' Id E2 đóng đi
        Public Id_Ca As String ' Ca sản xuất
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác BP
        Public Ma_Quay As Integer ' Mã quầy giao dịch
        Public Ma_E1 As String
        Public Ngay_Phat_Hanh As Integer ' Ngày chấp nhận BP
        Public Gio_Phat_Hanh As Integer ' Giờ chấp nhập BP
        Public Ngay_Dong As Integer ' Ngày đóng BP
        Public Gio_Dong As Integer ' Giờ đóng BP
        Public Ngay_Nhan As Integer
        Public Gio_Nhan As Integer
        Public Ma_Don_Vi As String ' Mã dịch vụ
        Public Ma_Bc_Goc As Integer ' Mã bưu cục chấp nhận bưu phẩm (có thể là mã đầu tỉnh)
        Public Ma_Bc_Tra As Integer ' Mã bưu cục phát trả bưu phẩm (Có thể là mã đầu tỉnh)
        Public Nuoc_Nhan As String ' Nước chấp nhận bưu phẩm
        Public Nuoc_Tra As String ' Nước phát trả BP
        Public Khoi_Luong As Integer
        Public Phan_Loai As String ' Phân loại bưu phẩm (D,M)
        Public Loai_Hang_Hoa As Integer ' 0:Hàng bình thường,1: hàng nhẹ,2: hàng cồng kềnh
        Public Khoi_Luong_QD As Integer ' Khối lượng quy đổi của BP: sử dụng trong trường hợp là hàng nhẹ
        Public Loai As Integer
        Public Dv_Cong_Them As String ' Liệt kê các dịch vụ cộng thêm được sử dung, ngăn cách bởi dấu ','
        Public Dv_Gia_Tang As String ' Liệt kê các dịch vụ gia tăng được sử dung, ngăn cách bởi dấu ','
        Public PPXD As Double ' Phụ phí xăng dầu (%)
        Public Cuoc_PPXD As Integer ' Cước phụ phí xăng dầu
        Public PostCode As String ' Mã vùng của nơi phát trả BP đối với BP đi quốc tế (Tính cước Vùng xa)
        Public Cuoc_PPVX As Integer ' Cước phụ phí vùng xa
        Public VAT As Double ' Thuế VAT
        Public COD As Boolean ' Dịch vụ COD
        Public Gia_Tri_Hang As Integer ' Giá trị hàng hóa được khai (Tính cước COD, cước khai giá)
        Public Cuoc_COD As Integer ' Cước dịch vụ COD
        Public Cuoc_DV As Integer ' Cước dịch vụ= Cước dịch vụ cộng thêm + Cước dịch vụ gia tăng
        Public Cuoc_Chinh As Integer ' Cước chính= Cước cơ sở + cước phụ phí xăng dầu + Cước phụ phí vùng xa
        Public Cuoc_Giam As Integer ' Giá trị cước được giảm do các chính sách giảm giá, khuyến mại
        Public Cuoc_E1 As Integer ' Cước ghi trên E1
        Public Kien_So As Integer ' Kiện số (Sử dụng cho Hàng 1 Vận đơn)
        Public STT As Integer ' Số thứ tự trong bản kê E2
        Public Ma_KH As String
        Public Nguoi_Gui As String
        Public Nguoi_Nhan As String
        Public Dia_Chi_Gui As String
        Public Dia_Chi_Nhan As String
        Public Dien_Thoai_Gui As String
        Public Dien_Thoai_Nhan As String
        Public HH_Phat_Hanh As Integer ' Hoa hồng đại lý phần công chấp nhận BP
        Public HH_Phat_Tra As Integer ' Hoa hồng đại lý phần công phát trả BP
        Public Ma_Bc_CH As Integer ' Mã bưu cục, nơi chuyển hoàn về bưu cục gốc
        Public Id_Nguoi_Dung As Integer
        Public Id_Trang_Thai As Integer
        Public Ghi_Chu As String
        Public Truyen_Khai_Thac As Boolean ' Truyền dữ liệu khai thác
        Public Truyen_Doi_Soat As Boolean ' Truyền dữ liệu đối soát sau khi đã cân đối ca
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean ' Chốt số liệu sau khi đã cân đối ca
        Public So_Luong_D As Integer 'Số lượng bưu phẩm tài liệu
        Public So_Luong_M As Integer 'Số lượng bưu phẩm hàng hóa
    End Class

    Public Class Doanh_Thu_HHDL_Chi_Tiet
        Public Ma_Bc_Khai_Thac As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
        'Khai báo phần Công chấp nhận
        Public HH_PH_NT As Double
        Public HH_PH_LT As Double
        Public HH_PH_QT As Double

        Public San_Luong_NT As Integer
        Public Trong_Luong_NT As Double
        Public Doanh_Thu_NT As Integer

        Public San_Luong_NT_TT As Integer
        Public Trong_Luong_NT_TT As Double
        Public Doanh_Thu_NT_TT As Integer

        Public San_Luong_LTLK As Integer
        Public Trong_Luong_LTLK As Double
        Public Doanh_Thu_LTLK As Integer

        Public San_Luong_LT As Integer
        Public Trong_Luong_LT As Integer
        Public Doanh_Thu_LT As Integer

        Public San_Luong_TTLTLK As Integer
        Public Trong_Luong_TTLTLK As Double
        Public Doanh_Thu_TTLTLK As Integer

        Public San_Luong_TTLT As Integer
        Public Trong_Luong_TTLT As Integer
        Public Doanh_Thu_TTLT As Integer

        Public San_Luong_QT As Integer
        Public Trong_Luong_QT As Double
        Public Doanh_Thu_QT As Integer

        Public San_Luong_CH As Integer
        Public Trong_Luong_CH As Integer
        Public Doanh_Thu_CH As Integer

        'Khai báo phần Công phát
        Public San_Luong_LTLK_TN_Duoi_2Kg As Integer
        Public Trong_Luong_LTLK_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_LTLK_TN_Duoi_2Kg As Integer

        Public San_Luong_LTLK_TN_Tren_2Kg As Integer
        Public Trong_Luong_LTLK_TN_Tren_2Kg As Double
        Public Trong_Luong_LTLK_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_LTLK_TN_Tren_2Kg As Integer

        Public San_Luong_LT_TN_Duoi_2Kg As Integer
        Public Trong_Luong_LT_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_LT_TN_Duoi_2Kg As Integer

        Public San_Luong_LT_TN_Tren_2Kg As Integer
        Public Trong_Luong_LT_TN_Tren_2Kg As Double
        Public Trong_Luong_LT_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_LT_TN_Tren_2Kg As Integer

        Public San_Luong_TTLTLK_TN_Duoi_2Kg As Integer
        Public Trong_Luong_TTLTLK_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg As Integer

        Public San_Luong_TTLTLK_TN_Tren_2Kg As Integer
        Public Trong_Luong_TTLTLK_TN_Tren_2Kg As Double
        Public Trong_Luong_TTLTLK_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_TTLTLK_TN_Tren_2Kg As Integer

        Public San_Luong_TTLT_TN_Duoi_2Kg As Integer
        Public Trong_Luong_TTLT_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_TTLT_TN_Duoi_2Kg As Integer

        Public San_Luong_TTLT_TN_Tren_2Kg As Integer
        Public Trong_Luong_TTLT_TN_Tren_2Kg As Double
        Public Trong_Luong_TTLT_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_TTLT_TN_Tren_2Kg As Integer

        Public San_Luong_QT_Duoi_5Kg As Integer
        Public Trong_Luong_QT_Duoi_5Kg As Double
        Public HH_Phat_Tra_QT_Duoi_5Kg As Integer

        Public San_Luong_QT_Tren_5Kg As Integer
        Public Trong_Luong_QT_Tren_5Kg As Double
        Public Trong_Luong_QT_Tren_5Kg_QD As Double
        Public HH_Phat_Tra_QT_Tren_5Kg As Integer
    End Class
    Public Class HHDL_CP_Tu_Ngay_Den_Ngay
        Public Ma_Bc_Khai_Thac As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer


        'Khai báo phần Công phát
        Public San_Luong_LTLK_TN_Duoi_2Kg As Integer
        Public Trong_Luong_LTLK_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_LTLK_TN_Duoi_2Kg As Integer

        Public San_Luong_LTLK_TN_Tren_2Kg As Integer
        Public Trong_Luong_LTLK_TN_Tren_2Kg As Double
        Public Trong_Luong_LTLK_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_LTLK_TN_Tren_2Kg As Integer

        Public San_Luong_LT_TN_Duoi_2Kg As Integer
        Public Trong_Luong_LT_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_LT_TN_Duoi_2Kg As Integer

        Public San_Luong_LT_TN_Tren_2Kg As Integer
        Public Trong_Luong_LT_TN_Tren_2Kg As Double
        Public Trong_Luong_LT_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_LT_TN_Tren_2Kg As Integer

        Public San_Luong_TTLTLK_TN_Duoi_2Kg As Integer
        Public Trong_Luong_TTLTLK_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg As Integer

        Public San_Luong_TTLTLK_TN_Tren_2Kg As Integer
        Public Trong_Luong_TTLTLK_TN_Tren_2Kg As Double
        Public Trong_Luong_TTLTLK_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_TTLTLK_TN_Tren_2Kg As Integer

        Public San_Luong_TTLT_TN_Duoi_2Kg As Integer
        Public Trong_Luong_TTLT_TN_Duoi_2Kg As Double
        Public HH_Phat_Tra_TTLT_TN_Duoi_2Kg As Integer

        Public San_Luong_TTLT_TN_Tren_2Kg As Integer
        Public Trong_Luong_TTLT_TN_Tren_2Kg As Double
        Public Trong_Luong_TTLT_TN_Tren_2Kg_QD As Double
        Public HH_Phat_Tra_TTLT_TN_Tren_2Kg As Integer

        Public San_Luong_QT_Duoi_5Kg As Integer
        Public Trong_Luong_QT_Duoi_5Kg As Double
        Public HH_Phat_Tra_QT_Duoi_5Kg As Integer

        Public San_Luong_QT_Tren_5Kg As Integer
        Public Trong_Luong_QT_Tren_5Kg As Double
        Public Trong_Luong_QT_Tren_5Kg_QD As Double
        Public HH_Phat_Tra_QT_Tren_5Kg As Integer
    End Class
    Public Class Doanh_Thu_Phat_Sinh_Chi_Tiet
        Public Ma_Bc_Khai_Thac As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
        'Khai báo phần Công chấp nhận
        Public HH_PH_NT As Double
        Public HH_PH_LT As Double
        Public HH_PH_QT As Double

        Public San_Luong_NT As Integer
        Public Trong_Luong_NT As Double
        Public Doanh_Thu_NT As Integer

        Public San_Luong_NT_TT As Integer
        Public Trong_Luong_NT_TT As Double
        Public Doanh_Thu_NT_TT As Integer

        Public San_Luong_LTLK As Integer
        Public Trong_Luong_LTLK As Double
        Public Doanh_Thu_LTLK As Integer

        Public San_Luong_LT As Integer
        Public Trong_Luong_LT As Integer
        Public Doanh_Thu_LT As Integer

        Public San_Luong_TTLTLK As Integer
        Public Trong_Luong_TTLTLK As Double
        Public Doanh_Thu_TTLTLK As Integer

        Public San_Luong_TTLT As Integer
        Public Trong_Luong_TTLT As Integer
        Public Doanh_Thu_TTLT As Integer

        Public San_Luong_QT As Integer
        Public Trong_Luong_QT As Double
        Public Doanh_Thu_QT As Integer

        Public San_Luong_CH As Integer
        Public Trong_Luong_CH As Integer
        Public Doanh_Thu_CH As Integer
    End Class
#End Region
#Region "E1_Di"
    Public Class E1_Di
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Di
        ' Input: Id_E1
        ' Output: E1_Di_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay", myConnection)

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
                Dim myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                myE1_Di_Chi_Tiet.Id_E1 = Id_E1
                myE1_Di_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Di_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Di_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Di_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Di_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Di_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Di_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Di_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Di_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Di_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Di_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Di_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Di_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Di_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Di_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Di_Chi_Tiet.Loai = pLoai.Value
                myE1_Di_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Di_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Di_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Di_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Di_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Di_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Di_Chi_Tiet.VAT = pVAT.Value
                myE1_Di_Chi_Tiet.COD = pCOD.Value
                myE1_Di_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Di_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Di_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Di_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Di_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Di_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Di_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Di_Chi_Tiet.STT = pSTT.Value
                myE1_Di_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Di_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Di_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Di_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Di_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Di_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Di_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Di_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Di_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Id_E2"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Di
        ' Input: Id_E1
        ' Output: E1_Di_Chi_Tiet
        Public Function Lay_Boi_Id_E2(ByVal Id_E2 As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Id_E2", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

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
                Dim myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                myE1_Di_Chi_Tiet.Id_E2 = Id_E2
                myE1_Di_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Di_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Di_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Di_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myE1_Di_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Di_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Di_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Di_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Di_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Di_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Di_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Di_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Di_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Di_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Di_Chi_Tiet.Loai = pLoai.Value
                myE1_Di_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Di_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Di_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Di_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Di_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Di_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Di_Chi_Tiet.VAT = pVAT.Value
                myE1_Di_Chi_Tiet.COD = pCOD.Value
                myE1_Di_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Di_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Di_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Di_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Di_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Di_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Di_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Di_Chi_Tiet.STT = pSTT.Value
                myE1_Di_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Di_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Di_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Di_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Di_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Di_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Di_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Di_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Di_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Theo_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E1_Di
        ' Input: Id_E1
        ' Output: E1_Di_Chi_Tiet
        Public Function Lay_Theo_Ma_E1(ByVal Ma_E1 As String, ByVal Ngay_Gioi_Han As Integer) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Theo_Ma_E1", myConnection)

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
                Dim myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                myE1_Di_Chi_Tiet.Id_E1 = pId_E1.Value
                myE1_Di_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE1_Di_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE1_Di_Chi_Tiet.Id_E2 = pId_E2.Value
                myE1_Di_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Ma_Quay = pMa_Quay.Value
                myE1_Di_Chi_Tiet.Ma_E1 = Ma_E1
                myE1_Di_Chi_Tiet.Ngay_Phat_Hanh = pNgay_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Gio_Phat_Hanh = pGio_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE1_Di_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE1_Di_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE1_Di_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE1_Di_Chi_Tiet.Ma_Don_Vi = pMa_Don_Vi.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Goc = pMa_Bc_Goc.Value
                myE1_Di_Chi_Tiet.Ma_Bc_Tra = pMa_Bc_Tra.Value
                myE1_Di_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myE1_Di_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myE1_Di_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myE1_Di_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                myE1_Di_Chi_Tiet.Loai_Hang_Hoa = pLoai_Hang_Hoa.Value
                myE1_Di_Chi_Tiet.Khoi_Luong_QD = pKhoi_Luong_QD.Value
                myE1_Di_Chi_Tiet.Loai = pLoai.Value
                myE1_Di_Chi_Tiet.Dv_Cong_Them = pDv_Cong_Them.Value
                myE1_Di_Chi_Tiet.Dv_Gia_Tang = pDv_Gia_Tang.Value
                myE1_Di_Chi_Tiet.PPXD = pPPXD.Value
                myE1_Di_Chi_Tiet.Cuoc_PPXD = pCuoc_PPXD.Value
                myE1_Di_Chi_Tiet.PostCode = pPostCode.Value
                myE1_Di_Chi_Tiet.Cuoc_PPVX = pCuoc_PPVX.Value
                myE1_Di_Chi_Tiet.VAT = pVAT.Value
                myE1_Di_Chi_Tiet.COD = pCOD.Value
                myE1_Di_Chi_Tiet.Gia_Tri_Hang = pGia_Tri_Hang.Value
                myE1_Di_Chi_Tiet.Cuoc_COD = pCuoc_COD.Value
                myE1_Di_Chi_Tiet.Cuoc_DV = pCuoc_DV.Value
                myE1_Di_Chi_Tiet.Cuoc_Chinh = pCuoc_Chinh.Value
                myE1_Di_Chi_Tiet.Cuoc_Giam = pCuoc_Giam.Value
                myE1_Di_Chi_Tiet.Cuoc_E1 = pCuoc_E1.Value
                myE1_Di_Chi_Tiet.Kien_So = pKien_So.Value
                myE1_Di_Chi_Tiet.STT = pSTT.Value
                myE1_Di_Chi_Tiet.Ma_KH = pMa_KH.Value
                myE1_Di_Chi_Tiet.Nguoi_Gui = pNguoi_Gui.Value
                myE1_Di_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Gui = pDia_Chi_Gui.Value
                myE1_Di_Chi_Tiet.Dia_Chi_Nhan = pDia_Chi_Nhan.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Gui = pDien_Thoai_Gui.Value
                myE1_Di_Chi_Tiet.Dien_Thoai_Nhan = pDien_Thoai_Nhan.Value
                myE1_Di_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE1_Di_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE1_Di_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myE1_Di_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myE1_Di_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myE1_Di_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                myE1_Di_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE1_Di_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE1_Di_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE1_Di_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay"
        ' Ngày tạo: 11/07/2008
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy Id_E1 từ bảng E1_Di
        ' Input: Id_E2 và Ma_E1
        ' Output: E1_Di_Chi_Tiet
        Public Function Lay_Id_E1(ByVal Id_E2 As String, ByVal Ma_e1 As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Id_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục                

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_e1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                myE1_Di_Chi_Tiet.Id_E1 = pId_E1.Value
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Id_Nguoi_Dung"
        '' Nguyễn Đức Trung.
        ' Lấy Id của người lập bản kê
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
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng E1_Di
        ' Input:  Id_Duong_Thu, Id_Chuyen_Thu, Id_E2, Id_Ca, Ma_Bc_Khai_Thac, Ma_Quay, Ma_E1, Ngay_Phat_Hanh, Gio_Phat_Hanh, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Ma_Don_Vi, Ma_Bc_Goc, Ma_Bc_Tra, Nuoc_Nhan, Nuoc_Tra, Khoi_Luong, Phan_Loai, Loai_Hang_Hoa, Khoi_Luong_QD, Loai, Dv_Cong_Them, Dv_Gia_Tang, PPXD, Cuoc_PPXD, PostCode, Cuoc_PPVX, VAT, COD, Gia_Tri_Hang, Cuoc_COD, Cuoc_DV, Cuoc_Chinh, Cuoc_Giam, Cuoc_E1, Kien_So, STT, Ma_KH, Nguoi_Gui, Nguoi_Nhan, Dia_Chi_Gui, Dia_Chi_Nhan, Dien_Thoai_Gui, Dien_Thoai_Nhan, HH_Phat_Hanh, HH_Phat_Tra, Ma_Bc_CH, Id_Nguoi_Dung, Id_Trang_Thai, Ghi_Chu, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_SL,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Them", myConnection)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Di
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat", myConnection)

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
#Region "Các Function sử dụng trong phần Form Sửa chữa E1-do"
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat_Sua_Chua_E1", myConnection)

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
#Region "Hieu_Chinh"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Hiệu chỉnh lại toàn bộ thông tin của các bảng Chuyen_Thu_Di, E2_Di, E1_Di khi có sự thay đổi của bảng E2_Di
        ' Input: Id_E2
        ' Output: 
        Public Sub Hieu_Chinh(ByVal Id_E2 As String, ByVal Chieu_Di As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Di_Hieu_Chinh_Trong_Sua_Chua_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pChieu_Di As SqlParameter = New SqlParameter("@Chieu_Di", SqlDbType.Bit, 1)
                pChieu_Di.Value = Chieu_Di
                myCommand.Parameters.Add(pChieu_Di)

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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat_Id_E1", myConnection)

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
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Di
        ' Input: đối tượng thuộc lớp E1_Di_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myE1_Di_Chi_Tiet As E1_Di_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = myE1_Di_Chi_Tiet.Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myE1_Di_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myE1_Di_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = myE1_Di_Chi_Tiet.Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myE1_Di_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = myE1_Di_Chi_Tiet.Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myE1_Di_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Phat_Hanh As SqlParameter = New SqlParameter("@Ngay_Phat_Hanh", SqlDbType.Int, 4)
                pNgay_Phat_Hanh.Value = myE1_Di_Chi_Tiet.Ngay_Phat_Hanh
                myCommand.Parameters.Add(pNgay_Phat_Hanh)

                Dim pGio_Phat_Hanh As SqlParameter = New SqlParameter("@Gio_Phat_Hanh", SqlDbType.Int, 4)
                pGio_Phat_Hanh.Value = myE1_Di_Chi_Tiet.Gio_Phat_Hanh
                myCommand.Parameters.Add(pGio_Phat_Hanh)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myE1_Di_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myE1_Di_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myE1_Di_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myE1_Di_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = myE1_Di_Chi_Tiet.Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                pMa_Bc_Goc.Value = myE1_Di_Chi_Tiet.Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                Dim pMa_Bc_Tra As SqlParameter = New SqlParameter("@Ma_Bc_Tra", SqlDbType.Int, 4)
                pMa_Bc_Tra.Value = myE1_Di_Chi_Tiet.Ma_Bc_Tra
                myCommand.Parameters.Add(pMa_Bc_Tra)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = myE1_Di_Chi_Tiet.Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.VarChar, 2)
                pNuoc_Tra.Value = myE1_Di_Chi_Tiet.Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myE1_Di_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.VarChar, 1)
                pPhan_Loai.Value = myE1_Di_Chi_Tiet.Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)

                Dim pLoai_Hang_Hoa As SqlParameter = New SqlParameter("@Loai_Hang_Hoa", SqlDbType.Int, 4)
                pLoai_Hang_Hoa.Value = myE1_Di_Chi_Tiet.Loai_Hang_Hoa
                myCommand.Parameters.Add(pLoai_Hang_Hoa)

                Dim pKhoi_Luong_QD As SqlParameter = New SqlParameter("@Khoi_Luong_QD", SqlDbType.Int, 4)
                pKhoi_Luong_QD.Value = myE1_Di_Chi_Tiet.Khoi_Luong_QD
                myCommand.Parameters.Add(pKhoi_Luong_QD)

                Dim pLoai As SqlParameter = New SqlParameter("@Loai", SqlDbType.Int, 4)
                pLoai.Value = myE1_Di_Chi_Tiet.Loai
                myCommand.Parameters.Add(pLoai)

                Dim pDv_Cong_Them As SqlParameter = New SqlParameter("@Dv_Cong_Them", SqlDbType.VarChar, 50)
                pDv_Cong_Them.Value = myE1_Di_Chi_Tiet.Dv_Cong_Them
                myCommand.Parameters.Add(pDv_Cong_Them)

                Dim pDv_Gia_Tang As SqlParameter = New SqlParameter("@Dv_Gia_Tang", SqlDbType.VarChar, 50)
                pDv_Gia_Tang.Value = myE1_Di_Chi_Tiet.Dv_Gia_Tang
                myCommand.Parameters.Add(pDv_Gia_Tang)

                Dim pPPXD As SqlParameter = New SqlParameter("@PPXD", SqlDbType.Float)
                pPPXD.Value = myE1_Di_Chi_Tiet.PPXD
                myCommand.Parameters.Add(pPPXD)

                Dim pCuoc_PPXD As SqlParameter = New SqlParameter("@Cuoc_PPXD", SqlDbType.Int, 4)
                pCuoc_PPXD.Value = myE1_Di_Chi_Tiet.Cuoc_PPXD
                myCommand.Parameters.Add(pCuoc_PPXD)

                Dim pPostCode As SqlParameter = New SqlParameter("@PostCode", SqlDbType.VarChar, 50)
                pPostCode.Value = myE1_Di_Chi_Tiet.PostCode
                myCommand.Parameters.Add(pPostCode)

                Dim pCuoc_PPVX As SqlParameter = New SqlParameter("@Cuoc_PPVX", SqlDbType.Int, 4)
                pCuoc_PPVX.Value = myE1_Di_Chi_Tiet.Cuoc_PPVX
                myCommand.Parameters.Add(pCuoc_PPVX)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = myE1_Di_Chi_Tiet.VAT
                myCommand.Parameters.Add(pVAT)

                Dim pCOD As SqlParameter = New SqlParameter("@COD", SqlDbType.Bit, 1)
                pCOD.Value = myE1_Di_Chi_Tiet.COD
                myCommand.Parameters.Add(pCOD)

                Dim pGia_Tri_Hang As SqlParameter = New SqlParameter("@Gia_Tri_Hang", SqlDbType.Int, 4)
                pGia_Tri_Hang.Value = myE1_Di_Chi_Tiet.Gia_Tri_Hang
                myCommand.Parameters.Add(pGia_Tri_Hang)

                Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int, 4)
                pCuoc_COD.Value = myE1_Di_Chi_Tiet.Cuoc_COD
                myCommand.Parameters.Add(pCuoc_COD)

                Dim pCuoc_DV As SqlParameter = New SqlParameter("@Cuoc_DV", SqlDbType.Int, 4)
                pCuoc_DV.Value = myE1_Di_Chi_Tiet.Cuoc_DV
                myCommand.Parameters.Add(pCuoc_DV)

                Dim pCuoc_Chinh As SqlParameter = New SqlParameter("@Cuoc_Chinh", SqlDbType.Int, 4)
                pCuoc_Chinh.Value = myE1_Di_Chi_Tiet.Cuoc_Chinh
                myCommand.Parameters.Add(pCuoc_Chinh)

                Dim pCuoc_Giam As SqlParameter = New SqlParameter("@Cuoc_Giam", SqlDbType.Int, 4)
                pCuoc_Giam.Value = myE1_Di_Chi_Tiet.Cuoc_Giam
                myCommand.Parameters.Add(pCuoc_Giam)

                Dim pCuoc_E1 As SqlParameter = New SqlParameter("@Cuoc_E1", SqlDbType.Int, 4)
                pCuoc_E1.Value = myE1_Di_Chi_Tiet.Cuoc_E1
                myCommand.Parameters.Add(pCuoc_E1)

                Dim pKien_So As SqlParameter = New SqlParameter("@Kien_So", SqlDbType.Int, 4)
                pKien_So.Value = myE1_Di_Chi_Tiet.Kien_So
                myCommand.Parameters.Add(pKien_So)

                Dim pSTT As SqlParameter = New SqlParameter("@STT", SqlDbType.Int, 4)
                pSTT.Value = myE1_Di_Chi_Tiet.STT
                myCommand.Parameters.Add(pSTT)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = myE1_Di_Chi_Tiet.Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNguoi_Gui As SqlParameter = New SqlParameter("@Nguoi_Gui", SqlDbType.VarChar, 100)
                If myE1_Di_Chi_Tiet.Nguoi_Gui Is Nothing Then
                    pNguoi_Gui.Value = ""
                Else
                    pNguoi_Gui.Value = myE1_Di_Chi_Tiet.Nguoi_Gui
                End If
                myCommand.Parameters.Add(pNguoi_Gui)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                If myE1_Di_Chi_Tiet.Nguoi_Nhan Is Nothing Then
                    pNguoi_Nhan.Value = ""
                Else
                    pNguoi_Nhan.Value = myE1_Di_Chi_Tiet.Nguoi_Nhan
                End If
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pDia_Chi_Gui As SqlParameter = New SqlParameter("@Dia_Chi_Gui", SqlDbType.VarChar, 200)
                If myE1_Di_Chi_Tiet.Dia_Chi_Gui Is Nothing Then
                    pDia_Chi_Gui.Value = ""
                Else
                    pDia_Chi_Gui.Value = myE1_Di_Chi_Tiet.Dia_Chi_Gui
                End If
                myCommand.Parameters.Add(pDia_Chi_Gui)

                Dim pDia_Chi_Nhan As SqlParameter = New SqlParameter("@Dia_Chi_Nhan", SqlDbType.VarChar, 200)
                If myE1_Di_Chi_Tiet.Dia_Chi_Nhan Is Nothing Then
                    pDia_Chi_Nhan.Value = ""
                Else
                    pDia_Chi_Nhan.Value = myE1_Di_Chi_Tiet.Dia_Chi_Nhan
                End If
                myCommand.Parameters.Add(pDia_Chi_Nhan)

                Dim pDien_Thoai_Gui As SqlParameter = New SqlParameter("@Dien_Thoai_Gui", SqlDbType.VarChar, 50)
                If myE1_Di_Chi_Tiet.Dien_Thoai_Gui Is Nothing Then
                    pDien_Thoai_Gui.Value = ""
                Else
                    pDien_Thoai_Gui.Value = myE1_Di_Chi_Tiet.Dien_Thoai_Gui
                End If
                myCommand.Parameters.Add(pDien_Thoai_Gui)

                Dim pDien_Thoai_Nhan As SqlParameter = New SqlParameter("@Dien_Thoai_Nhan", SqlDbType.VarChar, 50)
                If myE1_Di_Chi_Tiet.Dien_Thoai_Nhan Is Nothing Then
                    pDien_Thoai_Nhan.Value = ""
                Else
                    pDien_Thoai_Nhan.Value = myE1_Di_Chi_Tiet.Dien_Thoai_Nhan
                End If
                myCommand.Parameters.Add(pDien_Thoai_Nhan)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myE1_Di_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myE1_Di_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = myE1_Di_Chi_Tiet.Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myE1_Di_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.Int, 4)
                pId_Trang_Thai.Value = myE1_Di_Chi_Tiet.Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.VarChar, 200)
                pGhi_Chu.Value = myE1_Di_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myE1_Di_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myE1_Di_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myE1_Di_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = myE1_Di_Chi_Tiet.Chot_SL
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
#Region "KT_Cap_Nhat_Them"
        ' Ngày tạo: 28/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E1_Di
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        ' Output: 
        Public Sub KT_Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("KT_E1_Di_Cap_Nhat_Them", myConnection)

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


#Region "Doanh_Thu_Lien_Tinh_Lien_Ke"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Trungnd
        ' Nội dung:
        ' Output: 
        Public Function Doanh_Thu_Lien_Tinh_Lien_Ke(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_San_Luong_EMS_Lien_Tinh_Lien_Ke", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_San_Luong_EMS_Lien_Tinh_Lien_Ke")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E1_Di
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Xoa", myConnection)

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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Xoa_Tui", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E1_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy Ma_Bc_Tra và Nuoc_Tra
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_Rut_Gon", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_Rut_Gon")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Id_E2", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_E1_Lay_Boi_Id_E2")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "E1_Di_Lay_Boi_Chuyen_Thu_Di_DesManifest"
        ' Ngày tạo: 20/11/2008
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Di theo Id_Chuyen_Thu
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet 
        Public Function E1_Di_Lay_Boi_Chuyen_Thu_Di_DesManifest(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Chuyen_Thu_Di_DesPastManifest", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Chuyen_Thu_Di_DesPastManifest")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_Loai_D_M"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1_Loai_D_M(ByVal Id_E2 As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Id_E2_Loai_D_M", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 12)
                pSo_Luong_M.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Luong_M)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 12)
                pSo_Luong_D.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Luong_D)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Dim MyE1_Di_Chi_Tiet_DM As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                MyE1_Di_Chi_Tiet_DM.So_Luong_M = pSo_Luong_M.Value
                MyE1_Di_Chi_Tiet_DM.So_Luong_D = pSo_Luong_D.Value
                Return MyE1_Di_Chi_Tiet_DM
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_Loai_D_M_Lay_Boi_Id_Chuyen_Thu"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Loai_D_M(ByVal Id_chuyen_thu As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Id_E2_Loai_D_M", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_chuyen_thu", SqlDbType.VarChar, 31)
                pId_Chuyen_Thu.Value = Id_chuyen_thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pSo_Luong_M As SqlParameter = New SqlParameter("@So_Luong_M", SqlDbType.Int, 12)
                pSo_Luong_M.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Luong_M)

                Dim pSo_Luong_D As SqlParameter = New SqlParameter("@So_Luong_D", SqlDbType.Int, 12)
                pSo_Luong_D.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Luong_D)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Dim MyE1_Di_Chi_Tiet_DM As E1_Di_Chi_Tiet = New E1_Di_Chi_Tiet
                MyE1_Di_Chi_Tiet_DM.So_Luong_M = pSo_Luong_M.Value
                MyE1_Di_Chi_Tiet_DM.So_Luong_D = pSo_Luong_D.Value
                Return MyE1_Di_Chi_Tiet_DM
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "E1_Di_Bao_Cao_Hai_Quan"
        ' Ngày tạo: 16/01/2009
        ' Người tạo: tuyennv
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function E1_Di_Bao_Cao_Hai_Quan(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Bao_Cao_Hai_Quan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Bao_Cao_Hai_Quan")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_ManiFets_Chan"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1_ManiFets_Chan(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Mani_Fest_Chan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Mani_Fest_Chan")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_E1_ManiFets_Le"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1_ManiFets_Le(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Mani_Fest_Le", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Mani_Fest_Le")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_Ma_Bc"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Ma_Bc(ByVal Id_E1 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_Ma_Bc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_Ma_Bc")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Ma_E1"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Ma_E1(ByVal Ma_Bc_Goc As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Ma_Bc_Goc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Goc As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.VarChar, 4)
                pMa_Bc_Goc.Value = Ma_Bc_Goc
                myCommand.Parameters.Add(pMa_Bc_Goc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_E1_Lay_Boi_Ma_Bc_Goc")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Ma_E1"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Lay_Boi_Ma_E1(ByVal Ma_E1 As String, ByVal Ngay_Before As Integer, ByVal Ngay_After As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_Lay_Boi_Ma_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Before As SqlParameter = New SqlParameter("@Ngay_Before", SqlDbType.Int, 4)
                pNgay_Before.Value = Ngay_Before
                myCommand.Parameters.Add(pNgay_Before)

                Dim pNgay_After As SqlParameter = New SqlParameter("@Ngay_After", SqlDbType.Int, 4)
                pNgay_After.Value = Ngay_After
                myCommand.Parameters.Add(pNgay_After)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_Lay_Boi_Ma_E1")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy 1 E1 từ bảng E1_Di theo mã E1
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_E1(ByVal Ma_E1 As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ma_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.VarChar, 13)
                pMa_BC_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.VarChar, 13)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ma_E1")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Lay_Boi_Ma_E1_Sua_Chua_E1"
        Public Function E1_Di_Lay_Boi_Ma_E1_Sua_Chua_E1(ByVal Ma_E1 As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ma_E1_Sua_Chua_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 13)
                pMa_BC_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 13)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ma_E1_Sua_Chua_E1")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Chuyen_Thu_Di"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Di thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Chuyen_Thu_Di(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Chuyen_Thu_Di", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Chuyen_Thu_Di")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ca_San_Xuat", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ca_San_Xuat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Duong_Thu_Di"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Duong_Thu_Di thông qua khóa chính 
        ' Input: Id_Duong_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Duong_Thu_Di(ByVal Id_Duong_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Duong_Thu_Di", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Duong_Thu_Di")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Di_Lay_Boi_E2_Di"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E1_Di_Lay_Boi_E2_Di(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_E2_Di", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_E2_Di")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Hoa_Don"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Trungnd
        ' Nội dung: Tạo bản kê E2
        ' Input: Id_E2
        ' Output: 
        Public Function E1_Di_Hoa_Don(ByVal Ma_E1 As String) As DataSet

            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Hoa_Don", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Hoa_Don")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "Khai Thác"

#Region "E1_Di_Lay_Boi_E2_Di_KT"
        '' Ngày tạo: 25/08/08
        '' Người tạo: Đỗ Quốc Khánh
        '' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu, Tui_So
        '' Input: Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu, Tui_So
        '' Output: DataSet chứa toàn bộ dữ liệu về
        'Public Function E1_Di_Lay_Boi_E2_Di_KT(ByVal Id_Duong_Thu As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer) As DataSet
        '    Try
        '        ' T?o d?i tu?ng connection và command
        '        Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
        '        Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_E2_Di_KT", myConnection)
        '        Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        '        Dim myDataSet As DataSet = New DataSet

        '        ' S? d?ng Store Procedure
        '        myCommand.CommandType = CommandType.StoredProcedure
        '        ' Thêm các Parameters vào thủ tục
        '        Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
        '        pId_Duong_Thu.Value = Id_Duong_Thu
        '        myCommand.Parameters.Add(pId_Duong_Thu)
        '        Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 12)
        '        pTu_Ngay.Value = Tu_Ngay
        '        myCommand.Parameters.Add(pTu_Ngay)
        '        Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 12)
        '        pDen_Ngay.Value = Den_Ngay
        '        myCommand.Parameters.Add(pDen_Ngay)
        '        Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 12)
        '        pSo_Chuyen_Thu.Value = So_Chuyen_Thu
        '        myCommand.Parameters.Add(pSo_Chuyen_Thu)
        '        Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 12)
        '        pTui_So.Value = Tui_So
        '        myCommand.Parameters.Add(pTui_So)

        '        myConnection.Open()
        '        myAdapter.SelectCommand = myCommand
        '        myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_E2_Di_KT")
        '        myConnection.Close()
        'myConnection.Dispose()
        '        Return myDataSet
        '    Catch ex As Exception
        '        Console.Write(ex.ToString)
        '    End Try
        'End Function
#End Region

#Region "KT_Tong_Hop_E2_Di"
        ' Ngày tạo: 02/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu tổng hợp các E1 có trong bản kê E2
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function KT_Tong_Hop_E2_Di(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("KT_Tong_Hop_E2_Di", myConnection)
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
                myAdapter.Fill(myDataSet, "KT_Tong_Hop_E2_Di")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Quay_Giao_Dich", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Quay_Giao_Dich")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_Khach_Hang", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_Khach_Hang")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Tong_So_E1"
        Public Function Lay_Tong_So_E1(ByVal myId_E2 As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select count(*) from E1_Di where Id_E2= '" & myId_E2 & "'", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "E1_Di_Lay_Boi_E2_Di_KT"
        ' Ngày tạo: 26/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E1_Di_Lay_Boi_E2_Di_KT(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_E2_Di_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_E2_Di_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT"
        ' Ngày tạo: 26/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua khóa chính 
        ' Input: Id_E2
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT", myConnection)
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
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Kiem_Tra_Loi_KT"
        ' Ngày tạo: 05/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra xem bản kê này có bị lỗi không: (bị lỗi khi không có Số hiệu E1 tương ứng với Id_E2)
        ' Input: Id_E2
        ' Output: Tổng số Bưu phẩm
        Public Function E1_Di_Kiem_Tra_Loi_KT(ByVal Id_E2 As String) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Loi_KT", myConnection)
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
#Region "E1_Di_Insert_To_Tmp_E1_Di_KT"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Insert dữ liệu từ bảng chính (E1_Di) sang bảng tạm (Tmp_E1_Di)
        ' Input: Id_E2
        Public Sub E1_Di_Insert_To_Tmp_E1_Di_KT(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Insert_To_Tmp_E1_Di_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Insert_To_Tmp_E1_Di_KT")
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "E1_Di_Xoa_Theo_Id_E2_KT"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Xóa dữ liệu từ bảng E1_Di theo Id_E2
        ' Input: Id_E2
        ' Output: 
        Public Sub E1_Di_Xoa_Theo_Id_E2_KT(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Xoa_Theo_Id_E2_KT", myConnection)

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
#Region "E1_Di_Kiem_Tra_Trung_MA_E1_Ngay"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Di_Kiem_Tra_Trung_MA_E1_Ngay(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Trung_MA_E1_Ngay", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Kiem_Tra_Trung_MA_E1_Ngay")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Di_Chi_Tiet
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
                    myE1_Di_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E1_Di thông qua Ma_E1(Kiểm tra trùng dữ liệu),từ ngày đến ngày
        ' Input: MA_E1, Tu_Ngay, Den_Ngay
        ' Output: myDataTable
        Public Function E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(ByVal MA_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Di_Chi_Tiet
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
                    myE1_Di_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Cap_Nhat_Them_KT"
        ' Ngày tạo: 25/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật thêm dữ liệu vào bảng E1_Di
        ' Input: Id_E1,  Id_Duong_Thu , Id_Chuyen_Thu , Id_E2 , Id_Ca , Ma_Bc_Khai_Thac , Ma_Quay , Ma_E1 , Ngay_Phat_Hanh , Gio_Phat_Hanh , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Ma_Don_Vi , Ma_Bc_Goc , Ma_Bc_Tra , Nuoc_Nhan , Nuoc_Tra , Khoi_Luong , Phan_Loai , Loai_Hang_Hoa , Khoi_Luong_QD , Loai , Dv_Cong_Them , Dv_Gia_Tang , PPXD , Cuoc_PPXD , PostCode , Cuoc_PPVX , VAT , COD , Gia_Tri_Hang , Cuoc_COD , Cuoc_DV , Cuoc_Chinh , Cuoc_Giam , Cuoc_E1 , Kien_So , STT , Ma_KH , Nguoi_Gui , Nguoi_Nhan , Dia_Chi_Gui , Dia_Chi_Nhan , Dien_Thoai_Gui , Dien_Thoai_Nhan , HH_Phat_Hanh , HH_Phat_Tra , Ma_Bc_CH , Id_Nguoi_Dung , Id_Trang_Thai , Ghi_Chu , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        ' Output: 
        Public Sub E1_Di_Cap_Nhat_Them_KT(ByVal Id_E1 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_E2 As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Quay As Integer, ByVal Ma_E1 As String, ByVal Ngay_Phat_Hanh As Integer, ByVal Gio_Phat_Hanh As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Ma_Don_Vi As String, ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Nuoc_Tra As String, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Loai_Hang_Hoa As Integer, ByVal Khoi_Luong_QD As Integer, ByVal Loai As Integer, ByVal Dv_Cong_Them As String, ByVal Dv_Gia_Tang As String, ByVal PPXD As Double, ByVal Cuoc_PPXD As Integer, ByVal PostCode As String, ByVal Cuoc_PPVX As Integer, ByVal VAT As Double, ByVal COD As Boolean, ByVal Gia_Tri_Hang As Integer, ByVal Cuoc_COD As Integer, ByVal Cuoc_DV As Integer, ByVal Cuoc_Chinh As Integer, ByVal Cuoc_Giam As Integer, ByVal Cuoc_E1 As Integer, ByVal Kien_So As Integer, ByVal STT As Integer, ByVal Ma_KH As String, ByVal Nguoi_Gui As String, ByVal Nguoi_Nhan As String, ByVal Dia_Chi_Gui As String, ByVal Dia_Chi_Nhan As String, ByVal Dien_Thoai_Gui As String, ByVal Dien_Thoai_Nhan As String, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Ma_Bc_CH As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Trang_Thai As Integer, ByVal Ghi_Chu As String, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat_Them_KT", myConnection)

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
#Region "E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: kiểm tra trùng dữ liệu trong cùng chuyến thư đóng đi
        ' Input: MA_E1, Id_Chuyen_Thu
        ' Output: myDataTable
        Public Function E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(ByVal MA_E1 As String, ByVal Id_Chuyen_Thu As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Di_Chi_Tiet
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
                    myE1_Di_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: kiểm tra trùng dữ liệu trong cùng chuyến thư đóng đi
        ' Input: MA_E1, Id_Chuyen_Thu
        ' Output: myDataTable
        Public Function E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(ByVal MA_E1 As String, ByVal Id_Ca As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Di_Chi_Tiet
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
                    myE1_Di_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT"
        ' Ngày tạo: 05/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra trùng dữ liệu trong cùng 1 túi
        ' Input: MA_E1, Id_E2
        ' Output: myDataTable
        Public Function E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT(ByVal MA_E1 As String, ByVal Id_E2 As String) As E1_Di_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE1_Di_Chi_Tiet
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
                    myE1_Di_Chi_Tiet.Id_E1 = ""
                End If
                Return myE1_Di_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu"
        ' Ngày tạo: 04/09/2008
        ' Người tạo: Đỗ QUốc Khánh
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet 
        Public Function E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu")
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
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Cap_Nhat_Truyen_Khai_Thac", myConnection)

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
#End Region

#Region "Su dung De tinh Doanh Thu - Hoa hong Dai ly"

#Region "Lay_Doanh_Thu_HHDL_Tu_Ngay_Den_Ngay"
        Public Function Lay_Doanh_Thu_HHDL_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As Doanh_Thu_HHDL_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Doanh_Thu_HHDL", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 4)
                pMa_BC_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                '---------Doanh Thu phần Chấp nhận bưu gửi---------------
                'HH Phát hành
                Dim pHH_PH_NT As SqlParameter = New SqlParameter("@HH_PH_NT", SqlDbType.Float, 8)
                pHH_PH_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_NT)

                Dim pHH_PH_LT As SqlParameter = New SqlParameter("@HH_PH_LT", SqlDbType.Float, 8)
                pHH_PH_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_LT)

                Dim pHH_PH_QT As SqlParameter = New SqlParameter("@HH_PH_QT", SqlDbType.Float, 8)
                pHH_PH_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_QT)

                'Doanh Thu nội tỉnh
                Dim pSan_Luong_NT As SqlParameter = New SqlParameter("@San_Luong_NT", SqlDbType.Int, 4)
                pSan_Luong_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_NT)

                Dim pTrong_Luong_NT As SqlParameter = New SqlParameter("@Trong_Luong_NT", SqlDbType.Float)
                pTrong_Luong_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_NT)

                Dim pDoanh_Thu_NT As SqlParameter = New SqlParameter("@Doanh_Thu_NT", SqlDbType.Int, 4)
                pDoanh_Thu_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_NT)

                'Doanh thu nội tỉnh thoả thuận
                Dim pSan_Luong_NT_TT As SqlParameter = New SqlParameter("@San_Luong_NT_TT", SqlDbType.Int, 4)
                pSan_Luong_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_NT_TT)

                Dim pTrong_Luong_NT_TT As SqlParameter = New SqlParameter("@Trong_Luong_NT_TT", SqlDbType.Float)
                pTrong_Luong_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_NT_TT)

                Dim pDoanh_Thu_NT_TT As SqlParameter = New SqlParameter("@Doanh_Thu_NT_TT", SqlDbType.Int, 4)
                pDoanh_Thu_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_NT_TT)

                'Doanh thu Liên tỉnh Liền kề
                Dim pSan_Luong_LTLK As SqlParameter = New SqlParameter("@San_Luong_LTLK", SqlDbType.Int, 4)
                pSan_Luong_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK)

                Dim pTrong_Luong_LTLK As SqlParameter = New SqlParameter("@Trong_Luong_LTLK", SqlDbType.Float)
                pTrong_Luong_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK)

                Dim pDoanh_Thu_LTLK As SqlParameter = New SqlParameter("@Doanh_Thu_LTLK", SqlDbType.Int, 4)
                pDoanh_Thu_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_LTLK)

                'Doanh thu Liên Tỉnh
                Dim pSan_Luong_LT As SqlParameter = New SqlParameter("@San_Luong_LT", SqlDbType.Int, 4)
                pSan_Luong_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT)

                Dim pTrong_Luong_LT As SqlParameter = New SqlParameter("@Trong_Luong_LT", SqlDbType.Float)
                pTrong_Luong_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT)

                Dim pDoanh_Thu_LT As SqlParameter = New SqlParameter("@Doanh_Thu_LT", SqlDbType.Int, 4)
                pDoanh_Thu_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_LT)

                'Doanh thu Liên tỉnh Liền kề Thoả Thuận
                Dim pSan_Luong_TTLTLK As SqlParameter = New SqlParameter("@San_Luong_TTLTLK", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK)

                Dim pTrong_Luong_TTLTLK As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK", SqlDbType.Float)
                pTrong_Luong_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK)

                Dim pDoanh_Thu_TTLTLK As SqlParameter = New SqlParameter("@Doanh_Thu_TTLTLK", SqlDbType.Int, 4)
                pDoanh_Thu_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_TTLTLK)

                'Doanh Thu Liên tỉnh thoả thuận
                Dim pSan_Luong_TTLT As SqlParameter = New SqlParameter("@San_Luong_TTLT", SqlDbType.Int, 4)
                pSan_Luong_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT)

                Dim pTrong_Luong_TTLT As SqlParameter = New SqlParameter("@Trong_Luong_TTLT", SqlDbType.Float)
                pTrong_Luong_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT)

                Dim pDoanh_Thu_TTLT As SqlParameter = New SqlParameter("@Doanh_Thu_TTLT", SqlDbType.Int, 4)
                pDoanh_Thu_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_TTLT)

                'Doanh thu Quốc Tế
                Dim pSan_Luong_QT As SqlParameter = New SqlParameter("@San_Luong_QT", SqlDbType.Int, 4)
                pSan_Luong_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT)

                Dim pTrong_Luong_QT As SqlParameter = New SqlParameter("@Trong_Luong_QT", SqlDbType.Float)
                pTrong_Luong_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT)

                Dim pDoanh_Thu_QT As SqlParameter = New SqlParameter("@Doanh_Thu_QT", SqlDbType.Int, 4)
                pDoanh_Thu_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_QT)

                'Bưu gửi chuyển hoàn
                Dim pSan_Luong_CH As SqlParameter = New SqlParameter("@San_Luong_CH", SqlDbType.Int, 4)
                pSan_Luong_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_CH)

                Dim pTrong_Luong_CH As SqlParameter = New SqlParameter("@Trong_Luong_CH", SqlDbType.Float)
                pTrong_Luong_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_CH)

                Dim pDoanh_Thu_CH As SqlParameter = New SqlParameter("@Doanh_Thu_CH", SqlDbType.Int, 4)
                pDoanh_Thu_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_CH)

                '---------Doanh Thu phần công phát---------------

                Dim pSan_Luong_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_LTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK_TN_Duoi_2Kg)

                Dim pTrong_Luong_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LTLK_TN_Duoi_2Kg)

                Dim pSan_Luong_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_LTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_LTLK_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LTLK_TN_Tren_2Kg)


                Dim pSan_Luong_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_LT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT_TN_Duoi_2Kg)

                Dim pTrong_Luong_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LT_TN_Duoi_2Kg", SqlDbType.Decimal, 4)
                pHH_Phat_Tra_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LT_TN_Duoi_2Kg)

                Dim pSan_Luong_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_LT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT_TN_Tren_2Kg)

                Dim pTrong_Luong_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Tren_2Kg)

                Dim pTrong_Luong_LT_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_LT_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LT_TN_Tren_2Kg)

                Dim pSan_Luong_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK_TN_Duoi_2Kg)

                Dim pTrong_Luong_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg)

                Dim pSan_Luong_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Tren_2Kg_QD", SqlDbType.Int, 4)
                pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD)

                Dim pTrong_Luong_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Tren_2Kg)

                Dim pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg)

                Dim pSan_Luong_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT_TN_Duoi_2Kg)

                Dim pTrong_Luong_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLT_TN_Duoi_2Kg)

                Dim pSan_Luong_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLT_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLT_TN_Tren_2Kg)

                Dim pSan_Luong_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@San_Luong_QT_Duoi_5Kg", SqlDbType.Int, 4)
                pSan_Luong_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT_Duoi_5Kg)

                Dim pTrong_Luong_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@Trong_Luong_QT_Duoi_5Kg", SqlDbType.Float)
                pTrong_Luong_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Duoi_5Kg)

                Dim pHH_Phat_Tra_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_QT_Duoi_5Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_QT_Duoi_5Kg)

                Dim pSan_Luong_QT_Tren_5Kg As SqlParameter = New SqlParameter("@San_Luong_QT_Tren_5Kg", SqlDbType.Int, 4)
                pSan_Luong_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT_Tren_5Kg)

                Dim pTrong_Luong_QT_Tren_5Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_QT_Tren_5Kg_QD", SqlDbType.Float)
                pTrong_Luong_QT_Tren_5Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Tren_5Kg_QD)

                Dim pTrong_Luong_QT_Tren_5Kg As SqlParameter = New SqlParameter("@Trong_Luong_QT_Tren_5Kg", SqlDbType.Float)
                pTrong_Luong_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Tren_5Kg)

                Dim pHH_Phat_Tra_QT_Tren_5Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_QT_Tren_5Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_QT_Tren_5Kg)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDoanh_Thu_HHDL_Chi_Tiet As Doanh_Thu_HHDL_Chi_Tiet = New Doanh_Thu_HHDL_Chi_Tiet
                myDoanh_Thu_HHDL_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myDoanh_Thu_HHDL_Chi_Tiet.Tu_Ngay = Tu_Ngay
                myDoanh_Thu_HHDL_Chi_Tiet.Den_Ngay = Den_Ngay
                'Phần Chấp nhận bưu gửi
                myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_NT = IIf(pHH_PH_NT.Value Is System.DBNull.Value, 0, pHH_PH_NT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_LT = IIf(pHH_PH_LT.Value Is System.DBNull.Value, 0, pHH_PH_LT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_PH_QT = IIf(pHH_PH_QT.Value Is System.DBNull.Value, 0, pHH_PH_QT.Value)


                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_NT = IIf(pSan_Luong_NT.Value Is System.DBNull.Value, 0, pSan_Luong_NT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_NT = IIf(pTrong_Luong_NT.Value Is System.DBNull.Value, 0, pTrong_Luong_NT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_NT = IIf(pDoanh_Thu_NT.Value Is System.DBNull.Value, 0, pDoanh_Thu_NT.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_NT_TT = IIf(pSan_Luong_NT_TT.Value Is System.DBNull.Value, 0, pSan_Luong_NT_TT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_NT_TT = IIf(pTrong_Luong_NT_TT.Value Is System.DBNull.Value, 0, pTrong_Luong_NT_TT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_NT_TT = IIf(pDoanh_Thu_NT_TT.Value Is System.DBNull.Value, 0, pDoanh_Thu_NT_TT.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK = IIf(pSan_Luong_LTLK.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK = IIf(pTrong_Luong_LTLK.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_LTLK = IIf(pDoanh_Thu_LTLK.Value Is System.DBNull.Value, 0, pDoanh_Thu_LTLK.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT = IIf(pSan_Luong_LT.Value Is System.DBNull.Value, 0, pSan_Luong_LT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT = IIf(pTrong_Luong_LT.Value Is System.DBNull.Value, 0, pTrong_Luong_LT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_LT = IIf(pDoanh_Thu_LT.Value Is System.DBNull.Value, 0, pDoanh_Thu_LT.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK = IIf(pSan_Luong_TTLTLK.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK = IIf(pTrong_Luong_TTLTLK.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_TTLTLK = IIf(pDoanh_Thu_TTLTLK.Value Is System.DBNull.Value, 0, pDoanh_Thu_TTLTLK.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT = IIf(pSan_Luong_TTLT.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT = IIf(pTrong_Luong_TTLT.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_TTLT = IIf(pDoanh_Thu_TTLT.Value Is System.DBNull.Value, 0, pDoanh_Thu_TTLT.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT = IIf(pSan_Luong_QT.Value Is System.DBNull.Value, 0, pSan_Luong_QT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT = IIf(pTrong_Luong_QT.Value Is System.DBNull.Value, 0, pTrong_Luong_QT.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_QT = IIf(pDoanh_Thu_QT.Value Is System.DBNull.Value, 0, pDoanh_Thu_QT.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_CH = IIf(pSan_Luong_CH.Value Is System.DBNull.Value, 0, pSan_Luong_CH.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_CH = IIf(pTrong_Luong_CH.Value Is System.DBNull.Value, 0, pTrong_Luong_CH.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Doanh_Thu_CH = IIf(pDoanh_Thu_CH.Value Is System.DBNull.Value, 0, pDoanh_Thu_CH.Value)

                'Phần công phát
                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK_TN_Duoi_2Kg = IIf(pSan_Luong_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Duoi_2Kg = IIf(pTrong_Luong_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LTLK_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LTLK_TN_Tren_2Kg = IIf(pSan_Luong_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Tren_2Kg = IIf(pTrong_Luong_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LTLK_TN_Tren_2Kg_QD = IIf(pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0.0, pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LTLK_TN_Tren_2Kg = IIf(pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT_TN_Duoi_2Kg = IIf(pSan_Luong_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LT_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Duoi_2Kg = IIf(pTrong_Luong_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LT_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LT_TN_Duoi_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_LT_TN_Tren_2Kg = IIf(pSan_Luong_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LT_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Tren_2Kg = IIf(pTrong_Luong_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_LT_TN_Tren_2Kg_QD = IIf(pTrong_Luong_LT_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Tren_2Kg_QD.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_LT_TN_Tren_2Kg = IIf(pHH_Phat_Tra_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LT_TN_Tren_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK_TN_Duoi_2Kg = IIf(pSan_Luong_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Duoi_2Kg = IIf(pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLTLK_TN_Tren_2Kg = IIf(pSan_Luong_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Tren_2Kg = IIf(pTrong_Luong_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLTLK_TN_Tren_2Kg_QD = IIf(pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLTLK_TN_Tren_2Kg = IIf(pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT_TN_Duoi_2Kg = IIf(pSan_Luong_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Duoi_2Kg = IIf(pTrong_Luong_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Duoi_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLT_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_TTLT_TN_Tren_2Kg = IIf(pSan_Luong_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Tren_2Kg = IIf(pTrong_Luong_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Tren_2Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_TTLT_TN_Tren_2Kg_QD = IIf(pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_TTLT_TN_Tren_2Kg = IIf(pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT_Duoi_5Kg = IIf(pSan_Luong_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pSan_Luong_QT_Duoi_5Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Duoi_5Kg = IIf(pTrong_Luong_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Duoi_5Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_QT_Duoi_5Kg = IIf(pHH_Phat_Tra_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_QT_Duoi_5Kg.Value)

                myDoanh_Thu_HHDL_Chi_Tiet.San_Luong_QT_Tren_5Kg = IIf(pSan_Luong_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pSan_Luong_QT_Tren_5Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Tren_5Kg = IIf(pTrong_Luong_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Tren_5Kg.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.Trong_Luong_QT_Tren_5Kg_QD = IIf(pTrong_Luong_QT_Tren_5Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Tren_5Kg_QD.Value)
                myDoanh_Thu_HHDL_Chi_Tiet.HH_Phat_Tra_QT_Tren_5Kg = IIf(pHH_Phat_Tra_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_QT_Tren_5Kg.Value)
                Return myDoanh_Thu_HHDL_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_HHDL_CP_Tu_Ngay_Den_Ngay"
        Public Function Lay_HHDL_CP_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As HHDL_CP_Tu_Ngay_Den_Ngay
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Doanh_Thu_HHDL_CP", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 4)
                pMa_BC_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                '---------Doanh Thu phần công phát---------------

                Dim pSan_Luong_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_LTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK_TN_Duoi_2Kg)

                Dim pTrong_Luong_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_LTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LTLK_TN_Duoi_2Kg)

                Dim pSan_Luong_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_LTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_LTLK_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_LTLK_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_LTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LTLK_TN_Tren_2Kg)


                Dim pSan_Luong_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_LT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT_TN_Duoi_2Kg)

                Dim pTrong_Luong_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_LT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LT_TN_Duoi_2Kg", SqlDbType.Decimal, 4)
                pHH_Phat_Tra_LT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LT_TN_Duoi_2Kg)

                Dim pSan_Luong_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_LT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT_TN_Tren_2Kg)

                Dim pTrong_Luong_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Tren_2Kg)

                Dim pTrong_Luong_LT_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_LT_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_LT_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_LT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_LT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_LT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_LT_TN_Tren_2Kg)

                Dim pSan_Luong_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK_TN_Duoi_2Kg)

                Dim pTrong_Luong_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg)

                Dim pSan_Luong_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Tren_2Kg_QD", SqlDbType.Int, 4)
                pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD)

                Dim pTrong_Luong_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK_TN_Tren_2Kg)

                Dim pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLTLK_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg)

                Dim pSan_Luong_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT_TN_Duoi_2Kg)

                Dim pTrong_Luong_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Duoi_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Duoi_2Kg)

                Dim pHH_Phat_Tra_TTLT_TN_Duoi_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLT_TN_Duoi_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLT_TN_Duoi_2Kg)

                Dim pSan_Luong_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@San_Luong_TTLT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pSan_Luong_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Tren_2Kg", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Tren_2Kg)

                Dim pTrong_Luong_TTLT_TN_Tren_2Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_TTLT_TN_Tren_2Kg_QD", SqlDbType.Float)
                pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT_TN_Tren_2Kg_QD)

                Dim pHH_Phat_Tra_TTLT_TN_Tren_2Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_TTLT_TN_Tren_2Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_TTLT_TN_Tren_2Kg)

                Dim pSan_Luong_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@San_Luong_QT_Duoi_5Kg", SqlDbType.Int, 4)
                pSan_Luong_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT_Duoi_5Kg)

                Dim pTrong_Luong_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@Trong_Luong_QT_Duoi_5Kg", SqlDbType.Float)
                pTrong_Luong_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Duoi_5Kg)

                Dim pHH_Phat_Tra_QT_Duoi_5Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_QT_Duoi_5Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_QT_Duoi_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_QT_Duoi_5Kg)

                Dim pSan_Luong_QT_Tren_5Kg As SqlParameter = New SqlParameter("@San_Luong_QT_Tren_5Kg", SqlDbType.Int, 4)
                pSan_Luong_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT_Tren_5Kg)

                Dim pTrong_Luong_QT_Tren_5Kg_QD As SqlParameter = New SqlParameter("@Trong_Luong_QT_Tren_5Kg_QD", SqlDbType.Float)
                pTrong_Luong_QT_Tren_5Kg_QD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Tren_5Kg_QD)

                Dim pTrong_Luong_QT_Tren_5Kg As SqlParameter = New SqlParameter("@Trong_Luong_QT_Tren_5Kg", SqlDbType.Float)
                pTrong_Luong_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT_Tren_5Kg)

                Dim pHH_Phat_Tra_QT_Tren_5Kg As SqlParameter = New SqlParameter("@HH_Phat_Tra_QT_Tren_5Kg", SqlDbType.Int, 4)
                pHH_Phat_Tra_QT_Tren_5Kg.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra_QT_Tren_5Kg)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Dim myHHDL_CP_Tu_Ngay_Den_Ngay As HHDL_CP_Tu_Ngay_Den_Ngay = New HHDL_CP_Tu_Ngay_Den_Ngay
                myHHDL_CP_Tu_Ngay_Den_Ngay.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myHHDL_CP_Tu_Ngay_Den_Ngay.Tu_Ngay = Tu_Ngay
                myHHDL_CP_Tu_Ngay_Den_Ngay.Den_Ngay = Den_Ngay
                'Phần công phát
                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LTLK_TN_Duoi_2Kg = IIf(pSan_Luong_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Duoi_2Kg = IIf(pTrong_Luong_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LTLK_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LTLK_TN_Duoi_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LTLK_TN_Tren_2Kg = IIf(pSan_Luong_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Tren_2Kg = IIf(pTrong_Luong_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LTLK_TN_Tren_2Kg_QD = IIf(pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0.0, pTrong_Luong_LTLK_TN_Tren_2Kg_QD.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LTLK_TN_Tren_2Kg = IIf(pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LTLK_TN_Tren_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LT_TN_Duoi_2Kg = IIf(pSan_Luong_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LT_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Duoi_2Kg = IIf(pTrong_Luong_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LT_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_LT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LT_TN_Duoi_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_LT_TN_Tren_2Kg = IIf(pSan_Luong_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_LT_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Tren_2Kg = IIf(pTrong_Luong_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_LT_TN_Tren_2Kg_QD = IIf(pTrong_Luong_LT_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_LT_TN_Tren_2Kg_QD.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_LT_TN_Tren_2Kg = IIf(pHH_Phat_Tra_LT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_LT_TN_Tren_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLTLK_TN_Duoi_2Kg = IIf(pSan_Luong_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Duoi_2Kg = IIf(pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLTLK_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLTLK_TN_Duoi_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLTLK_TN_Tren_2Kg = IIf(pSan_Luong_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Tren_2Kg = IIf(pTrong_Luong_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLTLK_TN_Tren_2Kg_QD = IIf(pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK_TN_Tren_2Kg_QD.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLTLK_TN_Tren_2Kg = IIf(pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLTLK_TN_Tren_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLT_TN_Duoi_2Kg = IIf(pSan_Luong_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Duoi_2Kg = IIf(pTrong_Luong_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Duoi_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLT_TN_Duoi_2Kg = IIf(pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLT_TN_Duoi_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_TTLT_TN_Tren_2Kg = IIf(pSan_Luong_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Tren_2Kg = IIf(pTrong_Luong_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Tren_2Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_TTLT_TN_Tren_2Kg_QD = IIf(pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT_TN_Tren_2Kg_QD.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_TTLT_TN_Tren_2Kg = IIf(pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_TTLT_TN_Tren_2Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_QT_Duoi_5Kg = IIf(pSan_Luong_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pSan_Luong_QT_Duoi_5Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Duoi_5Kg = IIf(pTrong_Luong_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Duoi_5Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_QT_Duoi_5Kg = IIf(pHH_Phat_Tra_QT_Duoi_5Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_QT_Duoi_5Kg.Value)

                myHHDL_CP_Tu_Ngay_Den_Ngay.San_Luong_QT_Tren_5Kg = IIf(pSan_Luong_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pSan_Luong_QT_Tren_5Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Tren_5Kg = IIf(pTrong_Luong_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Tren_5Kg.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.Trong_Luong_QT_Tren_5Kg_QD = IIf(pTrong_Luong_QT_Tren_5Kg_QD.Value Is System.DBNull.Value, 0, pTrong_Luong_QT_Tren_5Kg_QD.Value)
                myHHDL_CP_Tu_Ngay_Den_Ngay.HH_Phat_Tra_QT_Tren_5Kg = IIf(pHH_Phat_Tra_QT_Tren_5Kg.Value Is System.DBNull.Value, 0, pHH_Phat_Tra_QT_Tren_5Kg.Value)
                Return myHHDL_CP_Tu_Ngay_Den_Ngay
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Doanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay"
        Public Function Lay_Doanh_Thu_Phat_Sinh_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As Doanh_Thu_Phat_Sinh_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Doanh_Thu_Phat_Sinh", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 4)
                pMa_BC_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                '---------Doanh Thu phần Chấp nhận bưu gửi---------------
                'HH Phát hành
                Dim pHH_PH_NT As SqlParameter = New SqlParameter("@HH_PH_NT", SqlDbType.Float, 8)
                pHH_PH_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_NT)

                Dim pHH_PH_LT As SqlParameter = New SqlParameter("@HH_PH_LT", SqlDbType.Float, 8)
                pHH_PH_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_LT)

                Dim pHH_PH_QT As SqlParameter = New SqlParameter("@HH_PH_QT", SqlDbType.Float, 8)
                pHH_PH_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_PH_QT)

                'Doanh Thu nội tỉnh
                Dim pSan_Luong_NT As SqlParameter = New SqlParameter("@San_Luong_NT", SqlDbType.Int, 4)
                pSan_Luong_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_NT)

                Dim pTrong_Luong_NT As SqlParameter = New SqlParameter("@Trong_Luong_NT", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_NT)

                Dim pDoanh_Thu_NT As SqlParameter = New SqlParameter("@Doanh_Thu_NT", SqlDbType.Int, 4)
                pDoanh_Thu_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_NT)

                'Doanh thu nội tỉnh thoả thuận
                Dim pSan_Luong_NT_TT As SqlParameter = New SqlParameter("@San_Luong_NT_TT", SqlDbType.Int, 4)
                pSan_Luong_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_NT_TT)

                Dim pTrong_Luong_NT_TT As SqlParameter = New SqlParameter("@Trong_Luong_NT_TT", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_NT_TT)

                Dim pDoanh_Thu_NT_TT As SqlParameter = New SqlParameter("@Doanh_Thu_NT_TT", SqlDbType.Int, 4)
                pDoanh_Thu_NT_TT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_NT_TT)

                'Doanh thu Liên tỉnh Liền kề
                Dim pSan_Luong_LTLK As SqlParameter = New SqlParameter("@San_Luong_LTLK", SqlDbType.Int, 4)
                pSan_Luong_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LTLK)

                Dim pTrong_Luong_LTLK As SqlParameter = New SqlParameter("@Trong_Luong_LTLK", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LTLK)

                Dim pDoanh_Thu_LTLK As SqlParameter = New SqlParameter("@Doanh_Thu_LTLK", SqlDbType.Int, 4)
                pDoanh_Thu_LTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_LTLK)

                'Doanh thu Liên Tỉnh
                Dim pSan_Luong_LT As SqlParameter = New SqlParameter("@San_Luong_LT", SqlDbType.Int, 4)
                pSan_Luong_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_LT)

                Dim pTrong_Luong_LT As SqlParameter = New SqlParameter("@Trong_Luong_LT", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_LT)

                Dim pDoanh_Thu_LT As SqlParameter = New SqlParameter("@Doanh_Thu_LT", SqlDbType.Int, 4)
                pDoanh_Thu_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_LT)

                'Doanh thu Liên tỉnh Liền kề Thoả Thuận
                Dim pSan_Luong_TTLTLK As SqlParameter = New SqlParameter("@San_Luong_TTLTLK", SqlDbType.Int, 4)
                pSan_Luong_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLTLK)

                Dim pTrong_Luong_TTLTLK As SqlParameter = New SqlParameter("@Trong_Luong_TTLTLK", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLTLK)

                Dim pDoanh_Thu_TTLTLK As SqlParameter = New SqlParameter("@Doanh_Thu_TTLTLK", SqlDbType.Int, 4)
                pDoanh_Thu_TTLTLK.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_TTLTLK)

                'Doanh Thu Liên tỉnh thoả thuận
                Dim pSan_Luong_TTLT As SqlParameter = New SqlParameter("@San_Luong_TTLT", SqlDbType.Int, 4)
                pSan_Luong_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_TTLT)

                Dim pTrong_Luong_TTLT As SqlParameter = New SqlParameter("@Trong_Luong_TTLT", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_TTLT)

                Dim pDoanh_Thu_TTLT As SqlParameter = New SqlParameter("@Doanh_Thu_TTLT", SqlDbType.Int, 4)
                pDoanh_Thu_TTLT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_TTLT)

                'Doanh thu Quốc Tế
                Dim pSan_Luong_QT As SqlParameter = New SqlParameter("@San_Luong_QT", SqlDbType.Int, 4)
                pSan_Luong_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_QT)

                Dim pTrong_Luong_QT As SqlParameter = New SqlParameter("@Trong_Luong_QT", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_QT)

                Dim pDoanh_Thu_QT As SqlParameter = New SqlParameter("@Doanh_Thu_QT", SqlDbType.Int, 4)
                pDoanh_Thu_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_QT)

                'Bưu gửi chuyển hoàn
                Dim pSan_Luong_CH As SqlParameter = New SqlParameter("@San_Luong_CH", SqlDbType.Int, 4)
                pSan_Luong_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSan_Luong_CH)

                Dim pTrong_Luong_CH As SqlParameter = New SqlParameter("@Trong_Luong_CH", SqlDbType.Decimal, 18, 3)
                pTrong_Luong_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTrong_Luong_CH)

                Dim pDoanh_Thu_CH As SqlParameter = New SqlParameter("@Doanh_Thu_CH", SqlDbType.Int, 4)
                pDoanh_Thu_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDoanh_Thu_CH)

                '----------Thuc thi----------------
                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDoanh_Thu_Phat_Sinh_Chi_Tiet As Doanh_Thu_Phat_Sinh_Chi_Tiet = New Doanh_Thu_Phat_Sinh_Chi_Tiet
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Tu_Ngay = Tu_Ngay
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Den_Ngay = Den_Ngay
                'Phần Chấp nhận bưu gửi
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.HH_PH_NT = IIf(pHH_PH_NT.Value Is System.DBNull.Value, 0, pHH_PH_NT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.HH_PH_LT = IIf(pHH_PH_LT.Value Is System.DBNull.Value, 0, pHH_PH_LT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.HH_PH_QT = IIf(pHH_PH_QT.Value Is System.DBNull.Value, 0, pHH_PH_QT.Value)


                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_NT = IIf(pSan_Luong_NT.Value Is System.DBNull.Value, 0, pSan_Luong_NT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_NT = IIf(pTrong_Luong_NT.Value Is System.DBNull.Value, 0, pTrong_Luong_NT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_NT = IIf(pDoanh_Thu_NT.Value Is System.DBNull.Value, 0, pDoanh_Thu_NT.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_NT_TT = IIf(pSan_Luong_NT_TT.Value Is System.DBNull.Value, 0, pSan_Luong_NT_TT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_NT_TT = IIf(pTrong_Luong_NT_TT.Value Is System.DBNull.Value, 0, pTrong_Luong_NT_TT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_NT_TT = IIf(pDoanh_Thu_NT_TT.Value Is System.DBNull.Value, 0, pDoanh_Thu_NT_TT.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_LTLK = IIf(pSan_Luong_LTLK.Value Is System.DBNull.Value, 0, pSan_Luong_LTLK.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_LTLK = IIf(pTrong_Luong_LTLK.Value Is System.DBNull.Value, 0, pTrong_Luong_LTLK.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_LTLK = IIf(pDoanh_Thu_LTLK.Value Is System.DBNull.Value, 0, pDoanh_Thu_LTLK.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_LT = IIf(pSan_Luong_LT.Value Is System.DBNull.Value, 0, pSan_Luong_LT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_LT = IIf(pTrong_Luong_LT.Value Is System.DBNull.Value, 0, pTrong_Luong_LT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_LT = IIf(pDoanh_Thu_LT.Value Is System.DBNull.Value, 0, pDoanh_Thu_LT.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_TTLTLK = IIf(pSan_Luong_TTLTLK.Value Is System.DBNull.Value, 0, pSan_Luong_TTLTLK.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_TTLTLK = IIf(pTrong_Luong_TTLTLK.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLTLK.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_TTLTLK = IIf(pDoanh_Thu_TTLTLK.Value Is System.DBNull.Value, 0, pDoanh_Thu_TTLTLK.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_TTLT = IIf(pSan_Luong_TTLT.Value Is System.DBNull.Value, 0, pSan_Luong_TTLT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_TTLT = IIf(pTrong_Luong_TTLT.Value Is System.DBNull.Value, 0, pTrong_Luong_TTLT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_TTLT = IIf(pDoanh_Thu_TTLT.Value Is System.DBNull.Value, 0, pDoanh_Thu_TTLT.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_QT = IIf(pSan_Luong_QT.Value Is System.DBNull.Value, 0, pSan_Luong_QT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_QT = IIf(pTrong_Luong_QT.Value Is System.DBNull.Value, 0, pTrong_Luong_QT.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_QT = IIf(pDoanh_Thu_QT.Value Is System.DBNull.Value, 0, pDoanh_Thu_QT.Value)

                myDoanh_Thu_Phat_Sinh_Chi_Tiet.San_Luong_CH = IIf(pSan_Luong_CH.Value Is System.DBNull.Value, 0, pSan_Luong_CH.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Trong_Luong_CH = IIf(pTrong_Luong_CH.Value Is System.DBNull.Value, 0, pTrong_Luong_CH.Value)
                myDoanh_Thu_Phat_Sinh_Chi_Tiet.Doanh_Thu_CH = IIf(pDoanh_Thu_CH.Value Is System.DBNull.Value, 0, pDoanh_Thu_CH.Value)

                Return myDoanh_Thu_Phat_Sinh_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#End Region

#Region "Danh_Sach_E1_Chua_Co_Chi_Tiet_Phat"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: tuyennv
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1_Chua_Co_Chi_Tiet_Phat(ByVal Ma_Bc_KT As Integer, ByVal NgayBD As Integer, ByVal NgayKT As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Danh_Sach_E1_Chua_Co_Chi_Tiet_Phat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim PMa_Bc_KT As SqlParameter = New SqlParameter("@Ma_Bc_Goc", SqlDbType.Int, 4)
                PMa_Bc_KT.Value = Ma_Bc_KT
                myCommand.Parameters.Add(PMa_Bc_KT)

                Dim PNgayBD As SqlParameter = New SqlParameter("@NgayBD", SqlDbType.Int, 4)
                PNgayBD.Value = NgayBD
                myCommand.Parameters.Add(PNgayBD)

                Dim PNgayKT As SqlParameter = New SqlParameter("@NgayKT", SqlDbType.Int, 4)
                PNgayKT.Value = NgayKT
                myCommand.Parameters.Add(PNgayKT)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Danh_Sach_E1_Chua_Co_Chi_Tiet_Phat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Su dung trong Form Ban ke Thue va Le phi Hai quan"

#Region "Hai_Quan_Danh_Sach_E1_Di"

        Public Function Hai_Quan_Danh_Sach_E1_Di(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Cac_Tinh_Xuat_Ra_Excel"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Cac_Tinh_Xuat_Ra_Excel(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ma_Tinh
            ' Ten_Tinh
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Cac_Tinh_Xuat_Ra_Excel"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Theo_Tinh_Xuat_Ra_Excel"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Theo_Tinh_Xuat_Ra_Excel(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ma_Tinh
            ' Ten_Tinh
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Theo_Tinh_Xuat_Ra_Excel"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Theo_Buu_Ta_Noi_Bo_Xuat_Ra_Excel"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Theo_Buu_Ta_Noi_Bo_Xuat_Ra_Excel(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ma_Tinh
            ' Ten_Tinh
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK
            ' Thue_VAT
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Theo_Buu_Ta_Noi_Bo_Xuat_Ra_Excel"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong
            ' Thue_NK
            ' Thue_VAT
            ' Ngay_CH
            ' So_CT
            ' Tui_So
            ' Ma_Tinh_CH
            ' Ten_Tinh_CH
            ' Duong_Thu_CH


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan"
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

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                MyCommand.Parameters.Add(pMa_BC_Khai_Thac)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan_Xuat_Ra_Excel"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan_Xuat_Ra_Excel(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong
            ' Thue_NK
            ' Thue_VAT
            ' Ngay_CH
            ' So_CT
            ' Tui_So
            ' Ma_Tinh_CH
            ' Ten_Tinh_CH
            ' Duong_Thu_CH


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan_Xuat_Ra_Excel"
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

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                MyCommand.Parameters.Add(pMa_BC_Khai_Thac)


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

#Region "Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer, ByVal Ma_Bc_Noi_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Noi_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Bc_Noi_Tinh))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Phan_Loai_Duong_Thu"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer, ByVal Phan_Loai_Duong_Thu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Phan_Loai_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Danh_Sach_E1_Di_Noi_Ngoai_Thanh"

        Public Function Hai_Quan_Danh_Sach_E1_Di_Noi_Ngoai_Thanh(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer, ByVal Phan_Loai_Duong_Thu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Ngay_Dong
            ' So_TKHQ
            ' So_Bien_Lai
            ' Le_Phi_HQ
            ' Thue_NK_VAT
            ' Cong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Danh_Sach_E1_Di_Noi_Ngoai_Thanh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Tong_Tien_Theo_Ma_Tinh"

        Public Function Hai_Quan_Tong_Tien_Theo_Ma_Tinh(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Tong_Tien


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Tong_Tien_Theo_Ma_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                MyCommand.CommandTimeout = 20000
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Phan_Loai_Duong_Thu"

        Public Function Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer, ByVal Phan_Loai_Duong_Thu As Integer) As DataSet

            ' The procedure returns these columns:
            ' Tong_Tien


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Phan_Loai_Duong_Thu"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Phan_Loai_Duong_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Phan_Loai_Duong_Thu))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region


#Region "Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh"

        Public Function Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal ma_Tinh As Integer, ByVal Ma_Bc_Noi_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Tong_Tien


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Tinh))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Noi_Tinh", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Ma_Bc_Noi_Tinh))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Danh sách Ma_E1 đóng đi nội tỉnh theo đường thư, được đóng từ ngày đến ngày"
#Region "Hai_Quan_Danh_Sach_E1_Di"

        Public Function Danh_Sach_E1_Di_Theo_Duong_Thu_Di_Noi_Tinh(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Id_Duong_Thu As String) As DataSet

            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Danh_Sach_E1_Di_Theo_Duong_Thu_Di_Noi_Tinh"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, Id_Duong_Thu))

                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region
#End Region

#Region "E1_Di_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay"

        Public Function E1_Di_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Don_Vi As Integer) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Ma_Tinh
            ' Ten_Tinh
            ' Don_Vi
            ' Tong_So_BP
            ' Tong_KL
            ' Tong_Thue
            ' Tong_Le_Phi
            ' Tong_Tien_No


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Value = Don_Vi
                MyCommand.Parameters.Add(pDon_Vi)


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

#Region "E1_Di_Danh_Sach_Ket_Xuat_Ke_Toan_Tu_Ngay_Den_Ngay"

        Public Function E1_Di_Danh_Sach_Ket_Xuat_Ke_Toan_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Don_Vi As Integer, ByVal Ma_Tinh As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Id_E2
            ' Id_Chuyen_Thu
            ' Id_Duong_Thu
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' Ma_Tinh
            ' Don_Vi
            ' STT
            ' Nuoc_Nhan
            ' Ma_Bc_Nhan
            ' Ma_E1
            ' Nuoc_Tra
            ' Ma_Bc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Gia_Tri_Hang
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' Ghi_Chu
            ' Ngay_Den_VN
            ' Id_Nguoi_Dung
            ' So_TKHQ
            ' So_Bien_Lai
            ' Thue_NK
            ' Thue_VAT
            ' Thue_Dac_Biet
            ' Thue_Tieu_Thu
            ' Thue_Qua_Tang
            ' Thue_Han_Ngach
            ' Thue_Uu_Dai
            ' Tong_Thue
            ' Le_Phi_HQ
            ' Le_Phi_VH
            ' Le_Phi_YT
            ' Le_Phi_DV
            ' Le_Phi_TV
            ' Le_Phi_Khac
            ' Tong_Le_Phi
            ' Tong_Thue_Le_Phi
            ' Chot_SL
            ' Da_Truyen
            ' 
            ' 


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Danh_Sach_Ket_Xuat_Ke_Toan_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pDon_Vi As SqlParameter = New SqlParameter("@Don_Vi", SqlDbType.Int, 0)
                pDon_Vi.Value = Don_Vi
                MyCommand.Parameters.Add(pDon_Vi)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 0)
                pMa_Tinh.Value = Ma_Tinh
                MyCommand.Parameters.Add(pMa_Tinh)


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

#Region "E1_Di_Danh_Sach_Theo_Ma_E1_Den_Chuyen_Hoan_Tu_Ngay_Den_Ngay"

        Public Function E1_Di_Danh_Sach_Theo_Ma_E1_Den_Chuyen_Hoan_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_E1 As String) As DataSet

            ' The procedure returns these columns:
            ' Id_E1
            ' Chon
            ' Ma_E1
            ' Ngay_Dong
            ' Ma_Duong_Thu
            ' So_Chuyen_Thu
            ' Tui_So
            ' Ma_Tinh
            ' Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Danh_Sach_Theo_Ma_E1_Den_Chuyen_Hoan_Tu_Ngay_Den_Ngay"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                MyCommand.Parameters.Add(pMa_E1)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#End Region

#Region "Bản kê A1"
#Region "E1_Di_Ban_Ke_A1_Quoc_Te_Den"
        Public Function E1_Di_Ban_Ke_A1_Quoc_Te_Den(ByVal Buu_Cuc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Tu_Gio As Integer, ByVal Den_Gio As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Ban_Ke_A1_Quoc_Te_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Buu_Cuc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Ban_Ke_A1_Quoc_Te_Den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Di_Ban_Ke_A1_Quoc_Te_Di"
        Public Function E1_Di_Ban_Ke_A1_Quoc_Te_Di(ByVal Buu_Cuc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Tu_Gio As Integer, ByVal Den_Gio As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Ban_Ke_A1_Quoc_Te_Di", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Buu_Cuc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Ban_Ke_A1_Quoc_Te_Di")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E1_Di_Ban_Ke_A1_3_Cot"
        Public Function E1_Di_Ban_Ke_A1_3_Cot(ByVal Buu_Cuc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Kieu As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E1_Di_Ban_Ke_A1_3_Cot", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Buu_Cuc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pKieu As SqlParameter = New SqlParameter("@Kieu", SqlDbType.Int, 4)
                pKieu.Value = Kieu
                myCommand.Parameters.Add(pKieu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E1_Di_Ban_Ke_A1_3_Cot")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region

#Region "E1_Di_Danh_Sach_Lay_Boi_Id_E2_Duong_Thu_Buu_Ta_Noi_Bo"

        Public Function E1_Di_Danh_Sach_Lay_Boi_Id_E2_Duong_Thu_Buu_Ta_Noi_Bo(ByVal Id_E2 As String) As DataSet

            ' The procedure returns these columns:
            ' Chon
            ' Id_E1
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ma_Quay
            ' Ma_E1
            ' Ngay_Phat_Hanh
            ' Gio_Phat_Hanh
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan
            ' Ma_Don_Vi
            ' Ma_Bc_Goc
            ' Ma_Bc_Tra
            ' Nuoc_Nhan
            ' Nuoc_Tra
            ' Khoi_Luong
            ' Phan_Loai
            ' Loai_Hang_Hoa
            ' Khoi_Luong_QD
            ' Loai
            ' Dv_Cong_Them
            ' Dv_Gia_Tang
            ' PPXD
            ' Cuoc_PPXD
            ' PostCode
            ' Cuoc_PPVX
            ' VAT
            ' COD
            ' Gia_Tri_Hang
            ' Cuoc_COD
            ' Cuoc_DV
            ' Cuoc_Chinh
            ' Cuoc_Giam
            ' Cuoc_E1
            ' Kien_So
            ' STT
            ' Ma_KH
            ' Nguoi_Gui
            ' Nguoi_Nhan
            ' Dia_Chi_Gui
            ' Dia_Chi_Nhan
            ' Dien_Thoai_Gui
            ' Dien_Thoai_Nhan
            ' HH_Phat_Hanh
            ' HH_Phat_Tra
            ' Ma_Bc_CH
            ' Id_Nguoi_Dung
            ' Id_Trang_Thai
            ' Ghi_Chu
            ' Truyen_Khai_Thac
            ' Truyen_Doi_Soat
            ' Ngay_He_Thong
            ' Chot_SL


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Danh_Sach_Lay_Boi_Id_E2_Duong_Thu_Buu_Ta_Noi_Bo"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)


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

#Region "E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E2_Tu_Ngay_Den_Ngay"

        Public Function E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E2_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Id_E2 As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' So_TKHQ
            ' So_Bien_Lai
            ' So_Kho
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Khoi_Luong
            ' Tong_Tien
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Id_Chuyen_Thu
            ' So_Chuyen_Thu
            ' Id_E2
            ' Tui_So
            ' Ma_Bc_Khai_Thac


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E2_Tu_Ngay_Den_Ngay"
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

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                MyCommand.Parameters.Add(pId_E2)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E1_Tu_Ngay_Den_Ngay"

        Public Function E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E1_Tu_Ngay_Den_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Id_E1 As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_E1
            ' So_TKHQ
            ' So_Bien_Lai
            ' So_Kho
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan
            ' Khoi_Luong
            ' Tong_Tien
            ' Id_Duong_Thu
            ' Ten_Duong_Thu
            ' Id_Chuyen_Thu
            ' So_Chuyen_Thu
            ' Id_E2
            ' Tui_So
            ' Ma_Bc_Khai_Thac


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E1_Tu_Ngay_Den_Ngay"
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

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Value = Id_E1
                MyCommand.Parameters.Add(pId_E1)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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

#Region "E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center"

        Public Function E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Tuy_Chon As Integer) As DataSet

            ' The procedure returns these columns:
            ' Duong_Thu
            ' So_Chuyen_Thu
            ' Loai_Chuyen_Thu
            ' Tui_So
            ' Ngay_Dong
            ' Ma_E1
            ' Ma_C1
            ' Khoi_Luong
            ' Phan_Loai
            ' Nguoi_Nhan
            ' Dia_Chi_Nhan


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E1_Di_Lay_Danh_Sach_Dong_Di_Tinh_Gui_Call_Center"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0)
                pTu_Ngay.Value = Tu_Ngay
                MyCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 0)
                pDen_Ngay.Value = Den_Ngay
                MyCommand.Parameters.Add(pDen_Ngay)

                Dim pTuy_Chon As SqlParameter = New SqlParameter("@Tuy_Chon", SqlDbType.Int, 0)
                pTuy_Chon.Value = Tuy_Chon
                MyCommand.Parameters.Add(pTuy_Chon)


                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#Region "Danh Sach E1 Thue Le Phi HQ"
        ' Ngày tạo: 17/07/2012
        ' Người tạo: khanh
        ' Nội dung: Lấy E1 từ bảng E1_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_E1_Thue_Le_Phi_HQ(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim sql As String
                sql = "Select A.Ma_E1," & _
                                            "A.Nuoc_Nhan," & _
                                            "A.Nuoc_Tra," & _
                                            "A.Ma_Bc_Goc as Ma_Bc_Nhan," & _
                                            "A.Ma_Bc_Tra," & _
                                            "A.Khoi_Luong," & _
                                            "A.Ngay_Dong," & _
                                            "B.Ngay_Khai_Thac," & _
                                            "A.So_TKHQ as So_DV_Lien_Quan," & _
                                            "A.So_Bien_Lai as So_Bien_Lai_Lien_Quan," & _
                                            "A.Le_Phi_HQ as Tien1," & _
                                            "A.Thue_NK_VAT as Tien2," & _
                                            "A.Le_Phi_VH as Tien3," & _
                                            "A.Le_Phi_YT as Tien4," & _
                                            "A.Le_Phi_DV as Tien5," & _
                                            "A.Le_Phi_TV as Tien6, " & _
                                            "A.Le_Phi_Khac as Tien7 " & _
                                        "From E1_Le_Phi_Di A " & _
                                        "Left Join Ca_San_Xuat B " & _
                                        "On A.Id_Ca = B.Id_Ca " & _
                                        "Where (A.Id_Ca='" & Id_Ca & "') " & _
                                        "And (A.Le_Phi_HQ+ A.Thue_NK_VAT + A.Le_Phi_VH + A.Le_Phi_YT + A.Le_Phi_DV + A.Le_Phi_TV + A.Le_Phi_Khac <> 0)"
                Dim myCommand As SqlCommand = New SqlCommand(sql, myConnection)

                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = sql

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet)
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
    End Class
#End Region


End Namespace

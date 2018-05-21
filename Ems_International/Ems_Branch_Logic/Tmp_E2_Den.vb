
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_E2_Den_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_E2_Den_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_E2_Den trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_E2_Den_Chi_Tiet
        Public Id_E2 As String ' SSSSSSRRRRRRDDDDBBBYYYYMMDDHHMM
        Public Id_Duong_Thu As String ' Đường thư đóng đến
        Public Id_Chuyen_Thu As String
        Public Id_Ca As String ' Ca sản xuất
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác bưu phẩm
        Public Ngay_Dong As Integer ' Ngày đóng E2
        Public Gio_Dong As Integer ' Giờ đóng E2
        Public Ngay_Nhan As Integer ' Ngày nhận túi thư (E2)
        Public Gio_Nhan As Integer ' Giờ nhận túi thư (E2)
        Public Tui_So As Integer ' Số hiệu túi thư
        Public Tui_F As Boolean ' Xác định túi F
        Public Tong_So_BP As Integer ' Tổng số bưu gửi trong túi  thư
        Public Khoi_Luong_Vo_Tui As Integer ' Khối lượng vỏ túi
        Public Khoi_Luong_BP As Integer ' Tổng khối lượng bưu phẩm
        Public Tong_Cuoc_COD As Integer ' Tổng giá trị cước COD trên E2
        Public Tong_Cuoc_DV As Integer ' Tổng cước dịch vụ
        Public Tong_Cuoc_Chinh As Integer ' Tổng cước chính
        Public HH_Phat_Hanh As Integer ' Hoa hồng đại lý phần công chấp nhận BP
        Public HH_Phat_Tra As Integer ' Hoa hồng đại lý phần công phát trả BP
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Ngay_He_Thong As Integer
        Public Chot_SL As Boolean
        Public Id_Duong_Bay As String 'Id_Duong_Thu + Chuyen bay
        Public Result As Boolean
    End Class
#End Region
#Region "Tmp_E2_Den"
    Public Class Tmp_E2_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub

#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_E2_Den
        ' Input: Id_E2
        ' Output: 
        Public Sub Xoa(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Xoa", myConnection)

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
#Region "Xoa Chuyen Thu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E2_Di
        ' Input: Id_E2
        ' Output: 
        Public Sub Xoa_Chuyen_Thu(ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Xoa_Chuyen_Thu", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục

                'Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                'pId_E1.Value = Id_E1
                'myCommand.Parameters.Add(pId_E1)

                'Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                'pId_E2.Value = Id_E2
                'myCommand.Parameters.Add(pId_E2)

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
#Region "Hieu_Chinh_Cap_Nhat_Them_CT"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Tuyennv
        ' Nội dung: Hiệu chỉnh lại toàn bộ thông tin của các bảng Chuyen_Thu_Di, E2_Di, E1_Di khi có sự thay đổi của bảng E2_Di
        ' Input: Id_E2
        ' Output: 
        Public Sub Hieu_Chinh_Cap_Nhat_Them_CT(ByVal Id_E2 As String, ByVal Chieu_Di As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Di_Hieu_Chinh_Cap_Nhat_Them_CT", myConnection)

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
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_E2_Den
        ' Input: Id_E2
        ' Output: Tmp_E2_Den_Chi_Tiet
        Public Function Lay(ByVal Id_E2 As String) As Tmp_E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
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

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

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

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Bay)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myTmp_E2_Den_Chi_Tiet As Tmp_E2_Den_Chi_Tiet = New Tmp_E2_Den_Chi_Tiet
                myTmp_E2_Den_Chi_Tiet.Id_E2 = Id_E2
                myTmp_E2_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myTmp_E2_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myTmp_E2_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myTmp_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myTmp_E2_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myTmp_E2_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myTmp_E2_Den_Chi_Tiet.Tui_So = pTui_So.Value
                myTmp_E2_Den_Chi_Tiet.Tui_F = pTui_F.Value
                myTmp_E2_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP = pKhoi_Luong_BP.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_COD = pTong_Cuoc_COD.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_DV = pTong_Cuoc_DV.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh = pTong_Cuoc_Chinh.Value
                myTmp_E2_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myTmp_E2_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myTmp_E2_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myTmp_E2_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myTmp_E2_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay = pId_Duong_Bay.Value
                Return myTmp_E2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Cap_Nhat_Id_E2"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Cập nhật dữ liệu vào bảng E1_Di
        ' Input: Id_E2
        ' Output: 
        Public Sub Cap_Nhat_Id_E2(ByVal Id_E2 As String, ByVal Id_E2_Sua As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Cap_Nhat_Id_E2", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_E2_Sua As SqlParameter = New SqlParameter("@Id_E2_Sua", SqlDbType.VarChar, 31)
                pId_E2_Sua.Value = Id_E2_Sua
                myCommand.Parameters.Add(pId_E2_Sua)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_E2_Den
        ' Input: đối tượng thuộc lớp Tmp_E2_Den_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_E2_Den_Chi_Tiet As Tmp_E2_Den_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = myTmp_E2_Den_Chi_Tiet.Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myTmp_E2_Den_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myTmp_E2_Den_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myTmp_E2_Den_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myTmp_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myTmp_E2_Den_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myTmp_E2_Den_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myTmp_E2_Den_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myTmp_E2_Den_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = myTmp_E2_Den_Chi_Tiet.Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Value = myTmp_E2_Den_Chi_Tiet.Tui_F
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = myTmp_E2_Den_Chi_Tiet.Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Value = myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Value = myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myTmp_E2_Den_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myTmp_E2_Den_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myTmp_E2_Den_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myTmp_E2_Den_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myTmp_E2_Den_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = myTmp_E2_Den_Chi_Tiet.Chot_SL
                myCommand.Parameters.Add(pChot_SL)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = myTmp_E2_Den_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Duong_Bay)

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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_E2_Den
        ' Input: Id_E2,  Id_Duong_Thu , Id_Chuyen_Thu , Id_Ca , Ma_Bc_Khai_Thac , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tui_So , Tui_F , Tong_So_BP , Khoi_Luong_Vo_Tui , Khoi_Luong_BP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc_Chinh , HH_Phat_Hanh , HH_Phat_Tra , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL, Id_Duong_Bay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean, ByVal Id_Duong_Bay As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Value = Tui_F
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Value = Khoi_Luong_BP
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Value = Tong_Cuoc_Chinh
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

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

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Tmp_E2_Den_Cap_Nhat_Them_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_E2_Den
        ' Input: Id_E2,  Id_Duong_Thu , Id_Chuyen_Thu , Id_Ca , Ma_Bc_Khai_Thac , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tui_So , Tui_F , Tong_So_BP , Khoi_Luong_Vo_Tui , Khoi_Luong_BP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc_Chinh , HH_Phat_Hanh , HH_Phat_Tra , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL , Id_Duong_Bay
        ' Output: 
        Public Sub Tmp_E2_Den_Cap_Nhat_Them_KT(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean, ByVal Id_Duong_Bay As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Cap_Nhat_Them_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Value = Tui_F
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Value = Khoi_Luong_BP
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Value = Tong_Cuoc_Chinh
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = Chot_SL
                myCommand.Parameters.Add(pChot_SL)

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Value = Id_Duong_Bay
                myCommand.Parameters.Add(pId_Duong_Bay)



                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "Tmp_E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT"
        ' Ngày tạo: 19/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua Id_Chuyen_Thu, Tui_So
        ' Input: Id_Chuyen_Thu, Tui_So
        ' Output: Tmp_E2_Den_Chi_Tiet
        Public Function Tmp_E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As Tmp_E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myTmp_E2_Den_Chi_Tiet As New Tmp_E2_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)
                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 12)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myTmp_E2_Den_Chi_Tiet
                        .Id_E2 = myDataSet.Tables(0).Rows(0)("Id_E2")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Tui_So = myDataSet.Tables(0).Rows(0)("Tui_So")
                        .Tui_F = myDataSet.Tables(0).Rows(0)("Tui_F")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Khoi_Luong_Vo_Tui = myDataSet.Tables(0).Rows(0)("Khoi_Luong_Vo_Tui")
                        .Khoi_Luong_BP = myDataSet.Tables(0).Rows(0)("Khoi_Luong_BP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_Chinh")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_SL = myDataSet.Tables(0).Rows(0)("Chot_SL")
                        .Id_Duong_Bay = myDataSet.Tables(0).Rows(0)("Id_Duong_Bay")
                    End With

                Else
                    myTmp_E2_Den_Chi_Tiet.Id_E2 = ""
                End If
                Return myTmp_E2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Tmp_E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Tmp_E2_Den thông qua Id_Chuyen_Thu, Tui_So
        ' Input: Id_Chuyen_Thu, Tui_So
        ' Output: Tmp_E2_Den_Chi_Tiet
        Public Function Tmp_E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT(ByVal Id_E2 As String) As Tmp_E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myTmp_E2_Den_Chi_Tiet As New Tmp_E2_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "Tmp_E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myTmp_E2_Den_Chi_Tiet
                        .Id_E2 = myDataSet.Tables(0).Rows(0)("Id_E2")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Tui_So = myDataSet.Tables(0).Rows(0)("Tui_So")
                        .Tui_F = myDataSet.Tables(0).Rows(0)("Tui_F")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Khoi_Luong_Vo_Tui = myDataSet.Tables(0).Rows(0)("Khoi_Luong_Vo_Tui")
                        .Khoi_Luong_BP = myDataSet.Tables(0).Rows(0)("Khoi_Luong_BP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_Chinh")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_SL = myDataSet.Tables(0).Rows(0)("Chot_SL")
                        .Id_Duong_Bay = myDataSet.Tables(0).Rows(0)("Id_Duong_Bay")
                    End With

                Else
                    myTmp_E2_Den_Chi_Tiet.Id_E2 = ""
                End If
                Return myTmp_E2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Tmp_E2_Den_Lay_Id_Duong_Bay_Theo_Id_E2"
        Public Function Tmp_E2_Den_Lay_Id_Duong_Bay_Theo_Id_E2(ByVal Id_E2 As String) As Tmp_E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_E2_Den_Lay_Id_Duong_Bay_Theo_Id_E2", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                ' Thêm các Parameters vào thủ tục  
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
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

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

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

                Dim pId_Duong_Bay As SqlParameter = New SqlParameter("@Id_Duong_Bay", SqlDbType.VarChar, 50)
                pId_Duong_Bay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Bay)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myTmp_E2_Den_Chi_Tiet As Tmp_E2_Den_Chi_Tiet = New Tmp_E2_Den_Chi_Tiet
                myTmp_E2_Den_Chi_Tiet.Id_E2 = Id_E2
                myTmp_E2_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myTmp_E2_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myTmp_E2_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myTmp_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myTmp_E2_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myTmp_E2_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myTmp_E2_Den_Chi_Tiet.Tui_So = pTui_So.Value
                myTmp_E2_Den_Chi_Tiet.Tui_F = pTui_F.Value
                myTmp_E2_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP = pKhoi_Luong_BP.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_COD = pTong_Cuoc_COD.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_DV = pTong_Cuoc_DV.Value
                myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh = pTong_Cuoc_Chinh.Value
                myTmp_E2_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myTmp_E2_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myTmp_E2_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myTmp_E2_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myTmp_E2_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myTmp_E2_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay = pId_Duong_Bay.Value
                Return myTmp_E2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
    End Class
#End Region


End Namespace


Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "E2_Den_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp E2_Den_Chi_Tiet
    ' tương ứng với mộ trường của bảng E2_Den trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class E2_Den_Chi_Tiet
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
        Public Result As Boolean
    End Class
#End Region
#Region "E2_Den"
    Public Class E2_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay_Check"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E2_Den
        ' Input: Id_E2
        ' Output: E2_Den_Chi_Tiet
        Public Function Lay_Check(ByVal Id_E2 As String) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Chk", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)


                Dim pResult As SqlParameter = New SqlParameter("@Result", SqlDbType.Bit, 1)
                pResult.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pResult)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE2_Den_Chi_Tiet As E2_Den_Chi_Tiet = New E2_Den_Chi_Tiet
                myE2_Den_Chi_Tiet.Id_E2 = Id_E2
                myE2_Den_Chi_Tiet.Chot_SL = pResult.Value
                Return myE2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng E2_Den
        ' Input: Id_E2
        ' Output: E2_Den_Chi_Tiet
        Public Function Lay(ByVal Id_E2 As String) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay", myConnection)

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

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE2_Den_Chi_Tiet As E2_Den_Chi_Tiet = New E2_Den_Chi_Tiet
                myE2_Den_Chi_Tiet.Id_E2 = Id_E2
                myE2_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myE2_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value
                myE2_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE2_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myE2_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myE2_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE2_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myE2_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myE2_Den_Chi_Tiet.Tui_So = pTui_So.Value
                myE2_Den_Chi_Tiet.Tui_F = pTui_F.Value
                myE2_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myE2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myE2_Den_Chi_Tiet.Khoi_Luong_BP = pKhoi_Luong_BP.Value
                myE2_Den_Chi_Tiet.Tong_Cuoc_COD = pTong_Cuoc_COD.Value
                myE2_Den_Chi_Tiet.Tong_Cuoc_DV = pTong_Cuoc_DV.Value
                myE2_Den_Chi_Tiet.Tong_Cuoc_Chinh = pTong_Cuoc_Chinh.Value
                myE2_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myE2_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myE2_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myE2_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myE2_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myE2_Den_Chi_Tiet.Chot_SL = pChot_SL.Value
                Return myE2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng E2_Den
        ' Input:  Id_Duong_Thu, Id_Chuyen_Thu, Id_Ca, Ma_Bc_Khai_Thac, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Tui_So, Tui_F, Tong_So_BP, Khoi_Luong_Vo_Tui, Khoi_Luong_BP, Tong_Cuoc_COD, Tong_Cuoc_DV, Tong_Cuoc_Chinh, HH_Phat_Hanh, HH_Phat_Tra, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_SL,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
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
        ' Nội dung: Cập nhật dữ liệu vào bảng E2_Den
        ' Input: Id_E2,  Id_Duong_Thu , Id_Chuyen_Thu , Id_Ca , Ma_Bc_Khai_Thac , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tui_So , Tui_F , Tong_So_BP , Khoi_Luong_Vo_Tui , Khoi_Luong_BP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc_Chinh , HH_Phat_Hanh , HH_Phat_Tra , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat", myConnection)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng E2_Den
        ' Input: đối tượng thuộc lớp E2_Den_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myE2_Den_Chi_Tiet As E2_Den_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = myE2_Den_Chi_Tiet.Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myE2_Den_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myE2_Den_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myE2_Den_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myE2_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myE2_Den_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myE2_Den_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myE2_Den_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myE2_Den_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = myE2_Den_Chi_Tiet.Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pTui_F As SqlParameter = New SqlParameter("@Tui_F", SqlDbType.Bit, 1)
                pTui_F.Value = myE2_Den_Chi_Tiet.Tui_F
                myCommand.Parameters.Add(pTui_F)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = myE2_Den_Chi_Tiet.Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = myE2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Value = myE2_Den_Chi_Tiet.Khoi_Luong_BP
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = myE2_Den_Chi_Tiet.Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = myE2_Den_Chi_Tiet.Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc_Chinh As SqlParameter = New SqlParameter("@Tong_Cuoc_Chinh", SqlDbType.Int, 4)
                pTong_Cuoc_Chinh.Value = myE2_Den_Chi_Tiet.Tong_Cuoc_Chinh
                myCommand.Parameters.Add(pTong_Cuoc_Chinh)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myE2_Den_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myE2_Den_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myE2_Den_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myE2_Den_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myE2_Den_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Value = myE2_Den_Chi_Tiet.Chot_SL
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E2_Den
        ' Input: Id_E2,  Id_Duong_Thu , Id_Chuyen_Thu , Id_Ca , Ma_Bc_Khai_Thac , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tui_So , Tui_F , Tong_So_BP , Khoi_Luong_Vo_Tui , Khoi_Luong_BP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc_Chinh , HH_Phat_Hanh , HH_Phat_Tra , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_SL ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat_Them", myConnection)

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


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat_Id_E2", myConnection)

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
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E2_Den
        ' Input: Id_E2
        ' Output: 
        Public Sub Xoa(ByVal Id_E2 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Xoa", myConnection)

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
#Region "Xoa E2 Loi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng E2_Di
        ' Input: Id_E2
        ' Output: 
        Public Function Xoa_E2_Loi(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Xoa_E2_Loi", myConnection)
                Dim myReturn As Boolean
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pXoa_Duoc As SqlParameter = New SqlParameter("@Xoa_Duoc", SqlDbType.Bit, 1)
                pXoa_Duoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pXoa_Duoc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myReturn = pXoa_Duoc.Value
                Return myReturn
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
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
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng E2_Den
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Tui_So"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn ĐỨc Trung
        ' Nội dung: Lấy Tui_So từ bảng E2_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Tui_So(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Danh_Sach_Tui_So", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter           

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_Danh_Sach_Tui_So")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Tong_Ket_Chuyen_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy Tui_So từ bảng E2_Den
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Tong_Ket_Chuyen_Thu(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Danh_Sach_Tong_Ket_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter           

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_Danh_Sach_Tong_Ket_Chuyen_Thu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Duong_Thu_Den", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Duong_Thu_Den")
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E2_Den_Kiem_Tra"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại của Túi
        ' Input: Id_Chuyen_Thu, So_Tui
        ' Output: count(*)
        Public Function E2_Den_Kiem_Tra(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from E2_Den where (Id_Chuyen_Thu= '" & Id_Chuyen_Thu & "') and (Tui_So=" & Tui_So & ")and (Tong_So_BP= " & 0 & ") and (Khoi_Luong_BP= " & 0 & ") ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lấy dữ liệu Báo cáo trong bảng E2_Den trong Form Cân đối dữ liệu - Quang Đô"
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC(ByVal Id_Ca As String, ByVal Ma_BC As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC(ByVal Id_Ca As String, ByVal Ma_BC As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC(ByVal Id_Ca As String, ByVal Ma_BC As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.VarChar, 15)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_EMS"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_EMS(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_EMS", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Buu_Kien"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Buu_Kien(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Buu_Kien", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC", myConnection)
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

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_EMS"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_EMS(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_EMS", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Buu_Kien"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Buu_Kien(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Buu_Kien", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC", myConnection)
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

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_EMS"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_EMS(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_EMS", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Buu_Kien"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Buu_Kien(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Buu_Kien", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_Bc As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC", myConnection)
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

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Nuoc"
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Nuoc(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay", myConnection)
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
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM"
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Theo_DM")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM", myConnection)
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
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Nuoc_Tu_Ngay_Den_Ngay_Theo_DM")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region

#Region "Lay du lieu bao cao trong bang E2_den trong Form Can Doi Du Lieu - Quang Trung - Tach QT di va QT den"
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT(ByVal id_Ca As String, ByVal ma_BC As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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

#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT(ByVal id_Ca As String, ByVal ma_BC As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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

#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT(ByVal id_Ca As String, ByVal ma_BC As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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


#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT_Den_Tu_Noi_Dia"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT_Den_Tu_Noi_Dia(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_QT_Den_Tu_Noi_Dia"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT_Den_Tu_Noi_Dia"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT_Den_Tu_Noi_Dia(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Tong_Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_QT_Den_Tu_Noi_Dia"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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

#Region "Tổng hợp sản lượng"
#Region "Huyện"
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo túi số của các bưu cục cấp dưới
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo chuyến thư của các đường thư huyện
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo Chuyến thư
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo chuyến thư của các đường thư huyện
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo Chuyến thư
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_Huyen")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region
#Region "Phân Loại Đường Thư"
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo túi số của các bưu cục cấp dưới
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_PL_Duong_Thu")

                Return myDataSet.Tables(0)
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_PL_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo chuyến thư của các đường thư huyện
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_PL_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo Chuyến thư
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu"
        ' Ngày tạo: 10/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo chuyến thư của các đường thư huyện
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu(ByVal Id_Ca As String, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_PL_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu"
        ' Ngày tạo: 11/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: lấy báo cáo tổng hợp theo Chuyến thư
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Duong_Thu_Tu_Ngay_Den_Ngay_PL_Duong_Thu")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region
#End Region

#Region "E2_Den_Lay_TT_E1"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy tổng E1
        ' Input: Id_E2
        ' Output: E2_Di_Chi_Tiet
        Public Function Lay_TT_E1(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_TT_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pTui_So As SqlParameter = New SqlParameter("@Tui_So", SqlDbType.Int, 4)
                pTui_So.Value = Tui_So
                myCommand.Parameters.Add(pTui_So)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pKhoi_Luong_BP As SqlParameter = New SqlParameter("@Khoi_Luong_BP", SqlDbType.Int, 4)
                pKhoi_Luong_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_BP)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Dong)


                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myE2_Den_Chi_Tiet As E2_Den_Chi_Tiet = New E2_Den_Chi_Tiet
                myE2_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myE2_Den_Chi_Tiet.Khoi_Luong_BP = pKhoi_Luong_BP.Value
                myE2_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myE2_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myE2_Den_Chi_Tiet.Id_E2 = pId_E2.Value
                myE2_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                Return myE2_Den_Chi_Tiet
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Chuyen_Thu_Den", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Chuyen_Thu_Den")
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
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
                Dim myCommand As SqlCommand = New SqlCommand("E2_Di_Hieu_Chinh", myConnection)

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
#Region "Khai Thác"
#Region "IsExist_E2_Den"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra sự tồn tại của Túi
        ' Input: Id_Chuyen_Thu, So_Tui
        ' Output: count(*)
        Public Function IsExist_E2_Den(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from E2_Den where (Id_Chuyen_Thu= '" & Id_Chuyen_Thu & "') and (Tui_So=" & Tui_So & ")", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Tim_So_Tui_Den_Lon_Nhat"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Tìm túi số lớn nhất của chuyến thư
        ' Input: Id_Chuyen_Thu
        ' Output: max(So_Tui)
        Public Function Tim_So_Tui_Den_Lon_Nhat(ByVal myId_Chuyen_Thu As String) As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Integer

            myCommand = New SqlCommand("Select max(Tui_So) from E2_Den where (Id_Chuyen_Thu= '" & myId_Chuyen_Thu & "')", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region

#Region "E2_Den_Lay_Boi_Chuyen_Thu_Den_KT"
        ' Ngày tạo: 25/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Di thông qua khóa chính 
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Chuyen_Thu_Den_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Chuyen_Thu_Den_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Xac_dinh_Tui_Den_F"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Xác định túi có phải là túi F không
        ' Input: Id_Chuyen_Thu, Tui_So
        ' Output: Tui_F
        Public Function Xac_dinh_Tui_Den_F(ByVal myId_Chuyen_Thu As String, ByVal myTui_So As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean

            myCommand = New SqlCommand("Select Tui_F from E2_Den where (Id_Chuyen_Thu= '" & myId_Chuyen_Thu & "') and (Tui_So=" & myTui_So & ")", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "E2_Den_Cap_Nhat_Them_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng E2_Den
        ' Input: Id_E2,  Id_Duong_Thu , Id_Chuyen_Thu , Id_Ca , Ma_Bc_Khai_Thac , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tui_So , Tui_F , Tong_So_BP , Khoi_Luong_Vo_Tui , Khoi_Luong_BP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc_Chinh , HH_Phat_Hanh , HH_Phat_Tra , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_SL ,
        ' Output: 
        Public Sub E2_Den_Cap_Nhat_Them_KT(ByVal Id_E2 As String, ByVal Id_Duong_Thu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Tong_So_BP As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Khoi_Luong_BP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc_Chinh As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_SL As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat_Them_KT", myConnection)

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


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT"
        ' Ngày tạo: 19/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Di thông qua Id_Chuyen_Thu, Tui_So
        ' Input: Id_Chuyen_Thu, Tui_So
        ' Output: E2_Den_Chi_Tiet
        Public Function E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE2_Den_Chi_Tiet
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
                    End With

                Else
                    myE2_Den_Chi_Tiet.Id_E2 = ""
                End If
                Return myE2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng E2_Den thông qua Id_Chuyen_Thu, Tui_So
        ' Input: Id_Chuyen_Thu, Tui_So
        ' Output: E2_Den_Chi_Tiet
        Public Function E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT(ByVal Id_E2 As String) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE2_Den_Chi_Tiet
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
                    End With

                Else
                    myE2_Den_Chi_Tiet.Id_E2 = ""
                End If
                Return myE2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E2_Den_Tong_Hop_Tu_E1_Den_KT"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Tổng hợp dữ liệu của bản kê E2_di từ E1_di
        ' Input:  Id_E2
        ' Output: E2_Den_Chi_Tiet
        Public Function E2_Den_Tong_Hop_Tu_E1_Den_KT(ByVal Id_E2 As String) As E2_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myE2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                'Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT", myConnection)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Tong_Hop_Tu_E1_Den_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Tong_Hop_Tu_E1_Den_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myE2_Den_Chi_Tiet
                        .Id_E2 = myDataSet.Tables(0).Rows(0)("Id_E2")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Khoi_Luong_BP = myDataSet.Tables(0).Rows(0)("Khoi_Luong_BP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc_Chinh = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_Chinh")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                    End With

                Else
                    myE2_Den_Chi_Tiet.Id_E2 = ""
                End If
                Return myE2_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#End Region
#Region "Kiem tra Chot SL"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra xem đã chốt số liệu chưa?
        ' Input: Id_E2
        ' Output: count(*)
        Public Function Chot_So_Lieu(ByVal Id_E2 As String) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Chot_SL", myConnection)
                Dim myReturn As Boolean
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pChot_SL As SqlParameter = New SqlParameter("@Chot_SL", SqlDbType.Bit, 1)
                pChot_SL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_SL)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myReturn = pChot_SL.Value
                Return myReturn
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "E2_Den_Ban_Ke"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Trungnd
        ' Nội dung: Tạo bản kê E2
        ' Input: Id_E2
        ' Output: 
        Public Function E2_Den_Ban_Ke(ByVal Id_E2 As String) As DataSet

            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Ban_Ke", myConnection)
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
                myAdapter.Fill(myDataSet, "E2_Den_Ban_Ke")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "E2_Den_BC37"
        ' Ngày t?o: 23/07/2008
        ' Ngu?i t?o: Anh Viet
        ' N?i dung: T?o b?n kê BC37
        ' Input: Id_Chuyen_Thu
        ' Output: 
        Public Function E2_Den_BC37(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' T?o d?i tu?ng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_BC37", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' S? d?ng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào th? t?c
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_BC37")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "E2_Den_Ban_Ke_KhaiThac_TongKet_F"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Tuyennv
        ' Nội dung: Tạo bản kê E2
        ' Input: Id_E2
        ' Output: 
        Public Function E2_Den_Ban_Ke_KhaiThac_TongKet_F(ByVal Id_Chuyen_thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Ban_Ke_KhaiThac_TongKet_F", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục                
                Dim pId_Chuyen_thu As SqlParameter = New SqlParameter("@Id_Chuyen_thu", SqlDbType.VarChar, 28)
                pId_Chuyen_thu.Value = Id_Chuyen_thu
                myCommand.Parameters.Add(pId_Chuyen_thu)
                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_Ban_Ke_KhaiThac_TongKet_F")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "E2_Den_Ban_Ke_KhaiThac_header"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Tuyennv
        ' Nội dung: Tạo bản kê E2
        ' Input: Id_E2
        ' Output: 
        Public Function E2_Den_Ban_Ke_KhaiThac_header(ByVal Id_E2 As String, ByVal Id_Chuyen_thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Ban_Ke_KhaiThac_header", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                Dim pId_Chuyen_thu As SqlParameter = New SqlParameter("@Id_Chuyen_thu", SqlDbType.VarChar, 28)
                pId_Chuyen_thu.Value = Id_Chuyen_thu
                myCommand.Parameters.Add(pId_Chuyen_thu)
                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_Ban_Ke_KhaiThac_header")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region


#Region "Danh_Sach_E2_Truyen"
        ' Ngày tạo: 04/09/2008
        ' Người tạo: Đỗ QUốc Khánh
        ' Nội dung: Lấy E2 từ bảng E2_Di
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet 
        Public Function Danh_Sach_E2_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Danh_Sach_E2_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
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
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "E2_Den_Danh_Sach_E2_Lay_Boi_Id_Chuyen_Thu_Truyen")
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
        ' Nội dung: Cập nhật dữ liệu truyền
        ' Input: Id_Chuyen_Thu
        ' Output: 
        Public Sub Cap_Nhat_Truyen_Khai_Thac(ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Cap_Nhat_Truyen_Khai_Thac", myConnection)

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


#Region "Danh_Sach_E2_Truyen_tuyennvDanh_Sach_E2_Truyen_tuyennvDanh_Sach_E2_Truyen_tuyennv"
        ' Ngày tạo: 04/09/2008
        ' Người tạo: tuyennv
        ' Nội dung: Lấy E2 từ bảng E2_Di
        ' Output: DataSet 
        Public Function Danh_Sach_E2_Truyen_tuyennv() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim str As String
                str = "select a.id_chuyen_thu,b.ma_bc from chuyen_thu_den a ,duong_thu_den b "
                str += "where a.ma_bc_khai_thac=100914 and a.id_duong_thu=b.id_duong_thu and b.id_phan_loai =4"
                Dim myCommand As SqlCommand = New SqlCommand(str, myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                myConnection.Open()
                myCommand.CommandType = CommandType.Text
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Sach_E2_Truyen_tuyennv")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Dung trong form sua chua E2 Den"

#Region "E2_Den_Cap_Nhat_Id_E2_Sua"
        Public Function E2_Den_Cap_Nhat_Id_E2_Sua(ByVal id_E2 As String, ByVal id_E2_Sua As String, ByVal id_Duong_Thu As String, ByVal id_Duong_Thu_Sua As String, ByVal id_Chuyen_Thu As String, ByVal id_Chuyen_Thu_Sua As String, ByVal id_Ca_Sua As String, ByVal ngay_Dong_Sua As Integer, ByVal gio_Dong_Sua As Integer, ByVal Tui_So_Sua As Integer) As Integer
            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Cap_Nhat_Id_E2_Sua"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Dim numRows As Integer = -1

            Try

                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_E2", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2))
                MyCommand.Parameters.Add(New SqlParameter("@Id_E2_Sua", SqlDbType.VarChar, 31, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_E2_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Duong_Thu_Sua", SqlDbType.VarChar, 14, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Duong_Thu_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Chuyen_Thu_Sua", SqlDbType.VarChar, 28, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Chuyen_Thu_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Sua", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Ngay_Dong_Sua", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ngay_Dong_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Gio_Dong_Sua", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, gio_Dong_Sua))
                MyCommand.Parameters.Add(New SqlParameter("@Tui_So_Sua", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Tui_So_Sua))

                'Execute the command using the connection string from the db base class 
                'and get the number of rows affected by the operation
                MyConnection.Open()

                numRows = MyCommand.ExecuteNonQuery()
                Return numRows
                'return the number of rows affected
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



#End Region

#Region "Dung trong Form Bao Cao - Them loai chuyen thu"
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu"
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT(ByVal Id_Ca As String, ByVal Ma_BC As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_Bc As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT", myConnection)
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

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT(ByVal Id_Ca As String) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT(ByVal Id_Ca As String, ByVal Ma_BC As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT", myConnection)
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

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Quang Do
        ' Nội dung: lấy báo cáo tổng hợp theo túi số 
        ' Input: Id_Ca
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT(ByVal Id_Ca_Tu_Ngay As Integer, ByVal Id_Ca_Den_Ngay As Integer, ByVal Ma_BC As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT", myConnection)
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

                Dim pMa_BC As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int)
                pMa_BC.Value = Ma_BC
                myCommand.Parameters.Add(pMa_BC)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT") Is Nothing Then
                    myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT").Clear()
                End If
                myAdapter.Fill(myDataSet, "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT")

                Return myDataSet.Tables("E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_Loai_CT")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Quoc Te Di - Tach Di Trong nuoc va Di Quoc te"
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT_Loai_CT(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT_Loai_CT(ByVal id_Ca As String, ByVal ma_BC As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Ma_BC_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT_Loai_CT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tui_So
            ' Tong_So_BP
            ' Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Tui_So_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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

#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT_Loai_CT(ByVal id_Ca As String, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT_Loai_CT(ByVal id_Ca As String, ByVal ma_BC As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Ma_BC_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15, ParameterDirection.Input, True, 0, 0, "", DataRowVersion.Current, id_Ca))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT_Loai_CT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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
#Region "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT"

        Public Function E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT(ByVal id_Ca_Tu_Ngay As Integer, ByVal id_Ca_Den_Ngay As Integer, ByVal ma_BC As Integer, ByVal ma_BC_Khai_Thac As Integer, ByVal Quoc_Te As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ngay_Nhan
            ' Ma_Duong_Thu
            ' Chuyen_Thu
            ' Tong_So_Tui
            ' Tong_So_BP
            ' Tong_Khoi_Luong
            ' Tong_Cuoc


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Lay_Boi_Ca_San_Xuat_Theo_Chuyen_Thu_Tu_Ngay_Den_Ngay_Ma_BC_QT_Loai_CT"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Id_Ca_Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, id_Ca_Den_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC))
                MyCommand.Parameters.Add(New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_BC_Khai_Thac))
                MyCommand.Parameters.Add(New SqlParameter("@Quoc_Te", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, Quoc_Te))

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

#End Region

#Region "Tổng hợp lại E2 từ E1 trong trường hợp bị mất E2"
#Region "E2_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E1_Den"

        Public Function E2_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E1_Den(ByVal tu_Ngay As Integer, ByVal den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_E2
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' Ngay_Dong
            ' Gio_Dong
            ' So_Chuyen_Thu
            ' Loai_CT
            ' Tui_So


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "E2_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E1_Den"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))

                'Fill the dataset using the connection string from the db base class
                MyCommand.CommandTimeout = 20000
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

#Region "E2_Den_In_Nhan_E4"
        Public Function E2_Den_In_Nhan_E4(ByVal Id_E2 As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("E2_Den_In_Nhan_E4", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter           

                Dim pId_E2 As SqlParameter = New SqlParameter("@Id_E2", SqlDbType.VarChar, 31)
                pId_E2.Value = Id_E2
                myCommand.Parameters.Add(pId_E2)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "E2_Den_In_Nhan_E4")
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

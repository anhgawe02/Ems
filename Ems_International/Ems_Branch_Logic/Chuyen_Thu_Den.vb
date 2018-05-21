
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Chuyen_Thu_Den_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Chuyen_Thu_Den_Chi_Tiet
    ' tương ứng với mộ trường của bảng Chuyen_Thu_Den trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Chuyen_Thu_Den_Chi_Tiet
        Public Id_Chuyen_Thu As String ' SSSSSSRRRRRRDDDDYYYYMMDDHHMM
        Public Id_Duong_Thu As String ' Mã đường thư
        Public Id_Ca As String ' YYYYMMDDW: Ca sản xuất
        Public Ma_Bc_Khai_Thac As Integer ' Bưu cục khai thác bưu phẩm đến
        Public So_Chuyen_Thu As Integer ' Số hiệu chuyến thư
        Public Ngay_Dong As Integer ' Ngày đóng chuyến thư
        Public Gio_Dong As Integer ' Giờ đóng chuyến thư
        Public Ngay_Nhan As Integer ' Ngày nhận chuyến thư
        Public Gio_Nhan As Integer ' Giờ nhận chuyến thư
        Public Tong_So_Tui As Integer
        Public Tong_So_BP As Integer
        Public Tong_KL As Integer ' Tổng khối lượng:= Tổng khối lượng BP + Tổng khối lượng vỏ túi
        Public Tong_KLBP As Integer ' Tổng khối lượng bưu phẩm trong chuyến thư
        Public Tong_Cuoc_COD As Integer
        Public Tong_Cuoc_DV As Integer ' Tổng cước dịch vụ của từng BP trong chuyến thư
        Public Tong_Cuoc As Integer ' Tổng Cước chính của tất cả BP trong chuyến thư
        Public HH_Phat_Hanh As Integer ' Hoa hồng đại lý phần công chấp nhận
        Public HH_Phat_Tra As Integer ' Hoa hồng đại lý phần công phát trả BP
        Public Dong_F As Boolean ' Đã đóng F chưa
        Public Truyen_Khai_Thac As Boolean
        Public Truyen_Doi_Soat As Boolean
        Public Ngay_He_Thong As Integer
        Public Chot_Sl As Boolean
    End Class
#End Region
#Region "Chuyen_Thu_Den"
    Public Class Chuyen_Thu_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Chuyen_Thu_Den
        ' Input: Id_Chuyen_Thu
        ' Output: Chuyen_Thu_Den_Chi_Tiet
        Public Function Lay(ByVal Id_Chuyen_Thu As String) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

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

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Int, 4)
                pDong_F.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChot_Sl)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = Id_Chuyen_Thu
                myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myChuyen_Thu_Den_Chi_Tiet.Id_Ca = pId_Ca.Value
                myChuyen_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu = pSo_Chuyen_Thu.Value
                myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong = pNgay_Dong.Value
                myChuyen_Thu_Den_Chi_Tiet.Gio_Dong = pGio_Dong.Value
                myChuyen_Thu_Den_Chi_Tiet.Ngay_Nhan = pNgay_Nhan.Value
                myChuyen_Thu_Den_Chi_Tiet.Gio_Nhan = pGio_Nhan.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_KL = pTong_KL.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP = pTong_KLBP.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD = pTong_Cuoc_COD.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV = pTong_Cuoc_DV.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc = pTong_Cuoc.Value
                myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh = pHH_Phat_Hanh.Value
                myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra = pHH_Phat_Tra.Value
                myChuyen_Thu_Den_Chi_Tiet.Dong_F = pDong_F.Value
                myChuyen_Thu_Den_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                myChuyen_Thu_Den_Chi_Tiet.Truyen_Doi_Soat = pTruyen_Doi_Soat.Value
                myChuyen_Thu_Den_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myChuyen_Thu_Den_Chi_Tiet.Chot_Sl = pChot_Sl.Value
                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Chuyen_Thu_Den
        ' Input:  Id_Duong_Thu, Id_Ca, Ma_Bc_Khai_Thac, So_Chuyen_Thu, Ngay_Dong, Gio_Dong, Ngay_Nhan, Gio_Nhan, Tong_So_Tui, Tong_So_BP, Tong_KL, Tong_KLBP, Tong_Cuoc_COD, Tong_Cuoc_DV, Tong_Cuoc, HH_Phat_Hanh, HH_Phat_Tra, Dong_F, Truyen_Khai_Thac, Truyen_Doi_Soat, Ngay_He_Thong, Chot_Sl,
        ' Output: 
        Public Sub Them(ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tong_So_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_KL As Integer, ByVal Tong_KLBP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Dong_F As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

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

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Value = Tong_So_Tui
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Value = Tong_KL
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Value = Tong_KLBP
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Value = Tong_Cuoc
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit)
                pDong_F.Value = Dong_F
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuyen_Thu_Den
        ' Input: Id_Chuyen_Thu,  Id_Duong_Thu , Id_Ca , Ma_Bc_Khai_Thac , So_Chuyen_Thu , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tong_So_Tui , Tong_So_BP , Tong_KL , Tong_KLBP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc , HH_Phat_Hanh , HH_Phat_Tra , Dong_F , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_Sl ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tong_So_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_KL As Integer, ByVal Tong_KLBP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Dong_F As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

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

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Value = Tong_So_Tui
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Value = Tong_KL
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Value = Tong_KLBP
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Value = Tong_Cuoc
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit)
                pDong_F.Value = Dong_F
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuyen_Thu_Den
        ' Input: đối tượng thuộc lớp Chuyen_Thu_Den_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myChuyen_Thu_Den_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myChuyen_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pGio_Dong As SqlParameter = New SqlParameter("@Gio_Dong", SqlDbType.Int, 4)
                pGio_Dong.Value = myChuyen_Thu_Den_Chi_Tiet.Gio_Dong
                myCommand.Parameters.Add(pGio_Dong)

                Dim pNgay_Nhan As SqlParameter = New SqlParameter("@Ngay_Nhan", SqlDbType.Int, 4)
                pNgay_Nhan.Value = myChuyen_Thu_Den_Chi_Tiet.Ngay_Nhan
                myCommand.Parameters.Add(pNgay_Nhan)

                Dim pGio_Nhan As SqlParameter = New SqlParameter("@Gio_Nhan", SqlDbType.Int, 4)
                pGio_Nhan.Value = myChuyen_Thu_Den_Chi_Tiet.Gio_Nhan
                myCommand.Parameters.Add(pGio_Nhan)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_KL
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Value = myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit)
                pDong_F.Value = myChuyen_Thu_Den_Chi_Tiet.Dong_F
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myChuyen_Thu_Den_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = myChuyen_Thu_Den_Chi_Tiet.Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myChuyen_Thu_Den_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = myChuyen_Thu_Den_Chi_Tiet.Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Chuyen_Thu_Den
        ' Input: Id_Chuyen_Thu,  Id_Duong_Thu , Id_Ca , Ma_Bc_Khai_Thac , So_Chuyen_Thu , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tong_So_Tui , Tong_So_BP , Tong_KL , Tong_KLBP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc , HH_Phat_Hanh , HH_Phat_Tra , Dong_F , Truyen_Khai_Thac , Truyen_Doi_Soat , Ngay_He_Thong , Chot_Sl ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tong_So_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_KL As Integer, ByVal Tong_KLBP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Dong_F As Integer, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Ngay_He_Thong As Integer, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

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

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Value = Tong_So_Tui
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Value = Tong_KL
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Value = Tong_KLBP
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Value = Tong_Cuoc
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit)
                pDong_F.Value = Dong_F
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Id_Chuyen_Thu"
        ' Ngày tạo: 10/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Cập nhật dữ liệu vào bảng chuyenthuden
        ' Input: id_chuyen_thu
        ' Output: 
        Public Sub Cap_Nhat_Id_Chuyen_Thu(ByVal Id_chuyen_Thu As String, ByVal Id_chuyen_Thu_Sua As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat_Id_Chuyen_Thu", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_chuyen_Thu As SqlParameter = New SqlParameter("@Id_chuyen_Thu", SqlDbType.VarChar, 31)
                pId_chuyen_Thu.Value = Id_chuyen_Thu
                myCommand.Parameters.Add(pId_chuyen_Thu)

                Dim pId_chuyen_Thu_Sua As SqlParameter = New SqlParameter("@Id_chuyen_Thu_Sua", SqlDbType.VarChar, 31)
                pId_chuyen_Thu_Sua.Value = Id_chuyen_Thu_Sua
                myCommand.Parameters.Add(pId_chuyen_Thu_Sua)

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
        ' Nội dung: Xóa dữ liệu từ bảng Chuyen_Thu_Den
        ' Input: Id_Chuyen_Thu
        ' Output: 
        Public Sub Xoa(ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Xoa", myConnection)

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
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Chuyen_Thu_Den
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Chuyen_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy số chuyến thư
        ' Input: 
        ' Output: DataSet
        Public Function Danh_Sach_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu_den"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy số chuyến thư
        ' Input: 
        ' Output: DataSet
        Public Function Danh_Sach_Chuyen_Thu_den(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal Phan_Loai_CHuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu_den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pPhan_Loai_Chuyen_Thu As SqlParameter = New SqlParameter("@Phan_Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pPhan_Loai_Chuyen_Thu.Value = Phan_Loai_CHuyen_Thu
                myCommand.Parameters.Add(pPhan_Loai_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu_den")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy Tui_So từ bảng E2_Di
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Chuyen_Thu_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter           

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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach_Tu_Ngay_Den_Ngay")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lấy tổng số E2, E1 theo chuyến thư"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy tổng số E2, E1
        ' Input: 
        ' Output: DataSet
        Public Function Lay_Tong_E2_E1_Theo_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Tong_E2_E1_Theo_Chuyen_Thu", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KLBP)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP = pTong_KLBP.Value
                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lấy tổng số E2, E1 theo Id_Duong_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy tổng số E2, E1
        ' Input: 
        ' Output: DataSet
        Public Function Lay_Tong_E2_E1_Theo_Id_Duong_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Tong_E2_E1_Theo_Id_Duong_Thu", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTong_KLBP)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = pTong_So_Tui.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP = pTong_So_BP.Value
                myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP = pTong_KLBP.Value
                Return myChuyen_Thu_Den_Chi_Tiet
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
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den", myConnection)
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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den")
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
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac")
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
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Boi_Ca_San_Xuat", myConnection)
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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Lay_Boi_Ca_San_Xuat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Id_Chuyen_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy số Id_Chuyen_Thu
        ' Input: 
        ' Output: DataSet
        Public Function Lay_Id_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Id_Chuyen_Thu", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Chuyen_Thu_Den_Lay_Id_Chuyen_Thu_Theo_Phan_Loai_Chuyen_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Tuyennv
        ' Nội dung: Lấy số Id_Chuyen_Thu
        ' Input: 
        ' Output: DataSet
        Public Function Chuyen_Thu_Den_Lay_Id_Chuyen_Thu_Theo_Phan_Loai_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Phan_Loai_Chuyen_Thu As String) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Id_Chuyen_Thu_Theo_Phan_Loai_Chuyen_Thu", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pPhan_Loai_Chuyen_Thu As SqlParameter = New SqlParameter("@Phan_Loai_Chuyen_Thu", SqlDbType.VarChar, 5)
                pPhan_Loai_Chuyen_Thu.Value = Phan_Loai_Chuyen_Thu
                myCommand.Parameters.Add(pPhan_Loai_Chuyen_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiểm tra sự tồn tại của đường thư trong bảng Chuyen Thu Di "
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại Id_Duong_Thu
        ' Input: Id_Duong_Thu
        ' Output: count(*)
        Public Function Chuyen_Thu_Den_Kiem_Tra(ByVal Id_Duong_Thu As String) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean

            myCommand = New SqlCommand("Select count(*) from Chuyen_Thu_Den where (Id_Duong_Thu= '" & Id_Duong_Thu & "') ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Hieu_Chinh"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Hiệu chỉnh lại toàn bộ thông tin của các bảng Chuyen_Thu_Di, E2_Di, E1_Di khi có sự thay đổi của bảng E2_Di
        ' Input: Id_E2
        ' Output: 
        Public Sub Hieu_Chinh(ByVal Id_Chuyen_Thu As String, ByVal Chieu_Di As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Di_Hieu_Chinh", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

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
#Region "Tim_So_Chuyen_Thu_Den_Lon_Nhat"
        Public Function Tim_So_Chuyen_Thu_Den_Lon_Nhat(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal Loai_Chuyen_Thu As String) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Tim_So_Chuyen_Thu_Den_Lon_Nhat_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                myCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu_Max", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pSo_Chuyen_Thu.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Dong_F"
        Public Function Chuyen_Thu_Den_Dong_F(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Loai_Chuyen_Thu As String) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Dong_F", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                myCommand.Parameters.Add(pLoai_Chuyen_Thu)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit, 1)
                pDong_F.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDong_F)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pDong_F.Value
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Ngay_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den (Chuyến thư) thông qua Id_Duong_Thu và Ngày, Sử dụng trong quá trình khai thác
        ' Input: Id_Duong_Thu, Ngay_Dong
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về: Số hiệu chuyến thư 
        Public Function Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Ngay_KT(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Ngay_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 12)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Ngay_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den (Chuyến thư) thông qua Id_Duong_Thu và Ngày, Sử dụng trong quá trình khai thác
        ' Input: Id_Duong_Thu, Ngay_Dong
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về: Số hiệu chuyến thư 
        Public Function Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal Loai_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 12)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pLoai_Chuyen_Thu As SqlParameter = New SqlParameter("@Loai_Chuyen_Thu", SqlDbType.VarChar, 2)
                pLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
                myCommand.Parameters.Add(pLoai_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Kiểm tra sự tồn tại của chuyến thư đen, Xác định tính duy nhất của Id chuyến thư "
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Kiểm tra sự tồn tại của Chuyến thư
        ' Input: Id_Chuyen_Thu
        ' Output: count(*)
        Public Function IsExist_Chuyen_Thu_Den(ByVal Id_Duong_Thu As String, ByVal SoChuyenThu As Integer, ByVal E2_Date As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean

            myCommand = New SqlCommand("Select count(*) from Chuyen_Thu_Den where (Id_Duong_Thu= '" & Id_Duong_Thu & "') and (So_Chuyen_Thu=" & SoChuyenThu & ") and (Ngay_Dong = " & E2_Date & ")", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region

#Region "KT_Tim_Id_Chuyen_Thu_Den"
        Public Function Tim_Id_Chuyen_Thu_Den(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Loai_Chuyen_Thu As String) As String
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Tim_Id_Chuyen_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

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

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Tim_Id_Chuyen_Thu")
                myConnection.Close()
                myConnection.Dispose()


                Return pId_Chuyen_Thu.Value
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Cap_Nhat_Them_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Chuyen_Thu_Den
        ' Input: Id_Chuyen_Thu,  Id_Duong_Thu , Id_Ca , Ma_Bc_Khai_Thac , So_Chuyen_Thu , Ngay_Dong , Gio_Dong , Ngay_Nhan , Gio_Nhan , Tong_So_Tui , Tong_So_BP , Tong_KL , Tong_KLBP , Tong_Cuoc_COD , Tong_Cuoc_DV , Tong_Cuoc , HH_Phat_Hanh , HH_Phat_Tra , Dong_F , Truyen_Khai_Thac , Truyen_Doi_Soat , Chot_Sl ,
        ' Output: 
        Public Sub Chuyen_Thu_Den_Cap_Nhat_Them_KT(ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Ngay_Dong As Integer, ByVal Gio_Dong As Integer, ByVal Ngay_Nhan As Integer, ByVal Gio_Nhan As Integer, ByVal Tong_So_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_KL As Integer, ByVal Tong_KLBP As Integer, ByVal Tong_Cuoc_COD As Integer, ByVal Tong_Cuoc_DV As Integer, ByVal Tong_Cuoc As Integer, ByVal HH_Phat_Hanh As Integer, ByVal HH_Phat_Tra As Integer, ByVal Dong_F As Boolean, ByVal Truyen_Khai_Thac As Boolean, ByVal Truyen_Doi_Soat As Boolean, ByVal Chot_Sl As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat_Them_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

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

                Dim pTong_So_Tui As SqlParameter = New SqlParameter("@Tong_So_Tui", SqlDbType.Int, 4)
                pTong_So_Tui.Value = Tong_So_Tui
                myCommand.Parameters.Add(pTong_So_Tui)

                Dim pTong_So_BP As SqlParameter = New SqlParameter("@Tong_So_BP", SqlDbType.Int, 4)
                pTong_So_BP.Value = Tong_So_BP
                myCommand.Parameters.Add(pTong_So_BP)

                Dim pTong_KL As SqlParameter = New SqlParameter("@Tong_KL", SqlDbType.Int, 4)
                pTong_KL.Value = Tong_KL
                myCommand.Parameters.Add(pTong_KL)

                Dim pTong_KLBP As SqlParameter = New SqlParameter("@Tong_KLBP", SqlDbType.Int, 4)
                pTong_KLBP.Value = Tong_KLBP
                myCommand.Parameters.Add(pTong_KLBP)

                Dim pTong_Cuoc_COD As SqlParameter = New SqlParameter("@Tong_Cuoc_COD", SqlDbType.Int, 4)
                pTong_Cuoc_COD.Value = Tong_Cuoc_COD
                myCommand.Parameters.Add(pTong_Cuoc_COD)

                Dim pTong_Cuoc_DV As SqlParameter = New SqlParameter("@Tong_Cuoc_DV", SqlDbType.Int, 4)
                pTong_Cuoc_DV.Value = Tong_Cuoc_DV
                myCommand.Parameters.Add(pTong_Cuoc_DV)

                Dim pTong_Cuoc As SqlParameter = New SqlParameter("@Tong_Cuoc", SqlDbType.Int, 4)
                pTong_Cuoc.Value = Tong_Cuoc
                myCommand.Parameters.Add(pTong_Cuoc)

                Dim pHH_Phat_Hanh As SqlParameter = New SqlParameter("@HH_Phat_Hanh", SqlDbType.Int, 4)
                pHH_Phat_Hanh.Value = HH_Phat_Hanh
                myCommand.Parameters.Add(pHH_Phat_Hanh)

                Dim pHH_Phat_Tra As SqlParameter = New SqlParameter("@HH_Phat_Tra", SqlDbType.Int, 4)
                pHH_Phat_Tra.Value = HH_Phat_Tra
                myCommand.Parameters.Add(pHH_Phat_Tra)

                Dim pDong_F As SqlParameter = New SqlParameter("@Dong_F", SqlDbType.Bit, 1)
                pDong_F.Value = Dong_F
                myCommand.Parameters.Add(pDong_F)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                Dim pTruyen_Doi_Soat As SqlParameter = New SqlParameter("@Truyen_Doi_Soat", SqlDbType.Bit, 1)
                pTruyen_Doi_Soat.Value = Truyen_Doi_Soat
                myCommand.Parameters.Add(pTruyen_Doi_Soat)

                Dim pChot_Sl As SqlParameter = New SqlParameter("@Chot_Sl", SqlDbType.Bit, 1)
                pChot_Sl.Value = Chot_Sl
                myCommand.Parameters.Add(pChot_Sl)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_KT"
        ' Ngày tạo: 19/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den (Chuyến thư) thông qua Id_Duong_Thu, Ngày, So_Chuyen_Thu, Sử dụng trong quá trình khai thác
        ' Input: Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về
        Public Function Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_KT(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)
                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 12)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)
                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 12)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_KT")
                myConnection.Close()
                myConnection.Dispose()
                If myDataSet.Tables(0).Rows.Count > 0 Then 'Nếu có dữ liệu
                    With myChuyen_Thu_Den_Chi_Tiet
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .So_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("So_Chuyen_Thu")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Tong_So_Tui = myDataSet.Tables(0).Rows(0)("Tong_So_Tui")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Tong_KL = myDataSet.Tables(0).Rows(0)("Tong_KL")
                        .Tong_KLBP = myDataSet.Tables(0).Rows(0)("Tong_KLBP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc = myDataSet.Tables(0).Rows(0)("Tong_Cuoc")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Dong_F = myDataSet.Tables(0).Rows(0)("Dong_F")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_Sl = myDataSet.Tables(0).Rows(0)("Chot_SL")
                    End With
                Else
                    myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = ""
                End If

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT"
        ' Ngày tạo: 19/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Den (Chuyến thư) thông qua Id_Duong_Thu, Ngày, So_Chuyen_Thu, Sử dụng trong quá trình khai thác
        ' Input: Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về
        Public Function Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer, ByVal Loai_Chuyen_Thu As String) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

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

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT")
                myConnection.Close()
                myConnection.Dispose()
                If myDataSet.Tables(0).Rows.Count > 0 Then 'Nếu có dữ liệu
                    With myChuyen_Thu_Den_Chi_Tiet
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .So_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("So_Chuyen_Thu")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Tong_So_Tui = myDataSet.Tables(0).Rows(0)("Tong_So_Tui")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Tong_KL = myDataSet.Tables(0).Rows(0)("Tong_KL")
                        .Tong_KLBP = myDataSet.Tables(0).Rows(0)("Tong_KLBP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc = myDataSet.Tables(0).Rows(0)("Tong_Cuoc")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Dong_F = myDataSet.Tables(0).Rows(0)("Dong_F")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_Sl = myDataSet.Tables(0).Rows(0)("Chot_SL")
                    End With
                Else
                    myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = ""
                End If

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Chuyen_Thu_Di (Chuyến thư) thông qua Id_Duong_Thu, Ngày, So_Chuyen_Thu, Sử dụng trong quá trình khai thác
        ' Input: Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu
        ' Output: Chuyen_Thu_Den_Chi_Tiet
        Public Function Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(ByVal Id_Chuyen_Thu As String) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT")
                myConnection.Close()
                myConnection.Dispose()
                If myDataSet.Tables(0).Rows.Count > 0 Then 'Nếu có dữ liệu
                    With myChuyen_Thu_Den_Chi_Tiet
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Id_Duong_Thu = myDataSet.Tables(0).Rows(0)("Id_Duong_Thu")
                        .Id_Ca = myDataSet.Tables(0).Rows(0)("Id_Ca")
                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(0)("Ma_Bc_Khai_Thac")
                        .So_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("So_Chuyen_Thu")
                        .Ngay_Dong = myDataSet.Tables(0).Rows(0)("Ngay_Dong")
                        .Gio_Dong = myDataSet.Tables(0).Rows(0)("Gio_Dong")
                        .Ngay_Nhan = myDataSet.Tables(0).Rows(0)("Ngay_Nhan")
                        .Gio_Nhan = myDataSet.Tables(0).Rows(0)("Gio_Nhan")
                        .Tong_So_Tui = myDataSet.Tables(0).Rows(0)("Tong_So_Tui")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Tong_KL = myDataSet.Tables(0).Rows(0)("Tong_KL")
                        .Tong_KLBP = myDataSet.Tables(0).Rows(0)("Tong_KLBP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc = myDataSet.Tables(0).Rows(0)("Tong_Cuoc")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Dong_F = myDataSet.Tables(0).Rows(0)("Dong_F")
                        .Truyen_Khai_Thac = myDataSet.Tables(0).Rows(0)("Truyen_Khai_Thac")
                        .Truyen_Doi_Soat = myDataSet.Tables(0).Rows(0)("Truyen_Doi_Soat")
                        .Chot_Sl = myDataSet.Tables(0).Rows(0)("Chot_SL")
                    End With
                Else
                    myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = ""
                End If

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT"
        ' Ngày tạo: 21/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Tổng hợp dữ liệu của bản kê Chuyen_Thu_Den từ E2_Di
        ' Input:  Id_Chuyen_Thu
        ' Output:  Chuyen_Thu_Den_Chi_Tiet
        Public Function Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT(ByVal Id_Chuyen_Thu As String) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT")
                myConnection.Close()
                myConnection.Dispose()

                If myDataSet.Tables(0).Rows.Count > 0 Then
                    With myChuyen_Thu_Den_Chi_Tiet
                        .Id_Chuyen_Thu = myDataSet.Tables(0).Rows(0)("Id_Chuyen_Thu")
                        .Tong_So_Tui = myDataSet.Tables(0).Rows(0)("Tong_So_Tui")
                        .Tong_So_BP = myDataSet.Tables(0).Rows(0)("Tong_So_BP")
                        .Tong_KL = myDataSet.Tables(0).Rows(0)("Tong_KL")
                        .Tong_KLBP = myDataSet.Tables(0).Rows(0)("Tong_KLBP")
                        .Tong_Cuoc_COD = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_COD")
                        .Tong_Cuoc_DV = myDataSet.Tables(0).Rows(0)("Tong_Cuoc_DV")
                        .Tong_Cuoc = myDataSet.Tables(0).Rows(0)("Tong_Cuoc")
                        .HH_Phat_Hanh = myDataSet.Tables(0).Rows(0)("HH_Phat_Hanh")
                        .HH_Phat_Tra = myDataSet.Tables(0).Rows(0)("HH_Phat_Tra")
                        .Dong_F = myDataSet.Tables(0).Rows(0)("Dong_F")
                    End With
                Else
                    myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = 0
                End If
                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region


#End Region

#Region "Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen"
        ' Ngày tạo: 04/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Chuyen_Thu_Di
        ' Input: Id_Chuyen_Thu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
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
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen")
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
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Cap_Nhat_Truyen_Khai_Thac", myConnection)

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

#Region "Danh sách các chuyến thư đến trong ca"
        Public Function Danh_Sach_Chuyen_Thu_Den_Theo_Ca(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu_Theo_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Den_Danh_Sach_Chuyen_Thu_Theo_Ca")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Tổng hợp lại chuyến thư từ E2 trong trường hợp bị mất chuyến thư"

#Region "Chuyen_Thu_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E2_Den"

        Public Function Chuyen_Thu_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E2_Den(ByVal tu_Ngay As Integer, ByVal tu_Ngay_Chuyen_Thu As Integer, ByVal den_Ngay As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Id_Chuyen_Thu
            ' Id_Ca
            ' Ma_Bc_Khai_Thac
            ' So_Chuyen_Thu
            ' Loai_CT
            ' Ngay_Dong
            ' Gio_Dong
            ' Ngay_Nhan
            ' Gio_Nhan


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Chuyen_Thu_Den_Danh_Sach_Bi_Mat_Id_Lay_Tu_E2_Den"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay))
                MyCommand.Parameters.Add(New SqlParameter("@Tu_Ngay_Chuyen_Thu", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, tu_Ngay_Chuyen_Thu))
                MyCommand.Parameters.Add(New SqlParameter("@Den_Ngay", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, den_Ngay))

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
    End Class
#End Region
End Namespace

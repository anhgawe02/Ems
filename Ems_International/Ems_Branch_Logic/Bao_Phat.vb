
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Bao_Phat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Bao_Phat_Chi_Tiet
    ' tương ứng với mộ trường của bảng Bao_Phat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Bao_Phat_Chi_Tiet
        Public Id_Bao_Phat As String
        Public Ma_E1 As String
        Public Nuoc_Nhan As String ' Nước chấp nhận E1 (nước phát hành)
        Public Ma_Bc_Phat As Integer ' Mã bưu cục phát BP
        Public Ngay_Phat As Integer ' Ngày phát BP
        Public Gio_Phat As Integer ' Giờ phát BP
        Public Ngay_Nhap As Integer
        Public Gio_Nhap As Integer
        Public Nguoi_Phat As String
        Public Nguoi_Nhan As String ' Tên người nhận BP
        Public Khoi_Luong As Integer ' Khối lượng E1
        Public Ma_Ly_Do As Integer ' Lý do không phát được
        Public Ma_Xu_Ly As String ' Không phát được-> Xử lý
        Public Phat_Duoc As Boolean ' 0: không phát được; 1: phát được
        Public Id_Nguoi_Dung As String
        Public Ngay_He_Thong As Integer
        Public Truyen_Khai_Thac As Boolean ' Trạng thái truyền báo phát
    End Class
#End Region
#Region "Bao_Phat"
    Public Class Bao_Phat
        Private ConnectionString As String
        Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
        Dim myDataSet As DataSet = New DataSet
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Bao_Phat
        ' Input: Id_Bao_Phat
        ' Output: Bao_Phat_Chi_Tiet
        Public Function Lay(ByVal Id_Bao_Phat As String) As Bao_Phat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myBao_Phat_Chi_Tiet As Bao_Phat_Chi_Tiet = New Bao_Phat_Chi_Tiet
                myBao_Phat_Chi_Tiet.Id_Bao_Phat = Id_Bao_Phat
                myBao_Phat_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myBao_Phat_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myBao_Phat_Chi_Tiet.Ma_Bc_Phat = pMa_Bc_Phat.Value
                myBao_Phat_Chi_Tiet.Ngay_Phat = pNgay_Phat.Value
                myBao_Phat_Chi_Tiet.Gio_Phat = pGio_Phat.Value
                myBao_Phat_Chi_Tiet.Ngay_Nhap = pNgay_Nhap.Value
                myBao_Phat_Chi_Tiet.Gio_Nhap = pGio_Nhap.Value
                myBao_Phat_Chi_Tiet.Nguoi_Phat = pNguoi_Phat.Value
                myBao_Phat_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myBao_Phat_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myBao_Phat_Chi_Tiet.Ma_Ly_Do = pMa_Ly_Do.Value
                myBao_Phat_Chi_Tiet.Ma_Xu_Ly = pMa_Xu_Ly.Value
                myBao_Phat_Chi_Tiet.Phat_Duoc = pPhat_Duoc.Value
                myBao_Phat_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myBao_Phat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myBao_Phat_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                Return myBao_Phat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Id_Bao_Phat_Theo_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Bao_Phat
        ' Input: Id_Bao_Phat
        ' Output: 
        Public Function Lay_Id_Bao_Phat_Theo_Ma_E1(ByVal Ma_E1 As String, ByVal Ma_Bc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As String
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Lay_Id_Bao_Phat_Theo_Ma_E1", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 48)
                pId_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_E1)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Return pId_E1.Value
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "Bao_Phat_Lay_Thanh_Cong"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Bao_Phat
        ' Input: Id_Bao_Phat
        ' Output: Bao_Phat_Chi_Tiet
        Public Function Bao_Phat_Lay_Thanh_Cong(ByVal Id_Bao_Phat As String) As Bao_Phat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Lay_Thanh_Cong", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myBao_Phat_Chi_Tiet As Bao_Phat_Chi_Tiet = New Bao_Phat_Chi_Tiet
                myBao_Phat_Chi_Tiet.Id_Bao_Phat = Id_Bao_Phat
                myBao_Phat_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myBao_Phat_Chi_Tiet.Nuoc_Nhan = pNuoc_Nhan.Value
                myBao_Phat_Chi_Tiet.Ma_Bc_Phat = pMa_Bc_Phat.Value
                myBao_Phat_Chi_Tiet.Ngay_Phat = pNgay_Phat.Value
                myBao_Phat_Chi_Tiet.Gio_Phat = pGio_Phat.Value
                myBao_Phat_Chi_Tiet.Ngay_Nhap = pNgay_Nhap.Value
                myBao_Phat_Chi_Tiet.Gio_Nhap = pGio_Nhap.Value
                myBao_Phat_Chi_Tiet.Nguoi_Phat = pNguoi_Phat.Value
                myBao_Phat_Chi_Tiet.Nguoi_Nhan = pNguoi_Nhan.Value
                myBao_Phat_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myBao_Phat_Chi_Tiet.Ma_Ly_Do = pMa_Ly_Do.Value
                myBao_Phat_Chi_Tiet.Ma_Xu_Ly = pMa_Xu_Ly.Value
                myBao_Phat_Chi_Tiet.Phat_Duoc = pPhat_Duoc.Value
                myBao_Phat_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myBao_Phat_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myBao_Phat_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                Return myBao_Phat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Bao_Phat
        ' Input:  Ma_E1, Nuoc_Nhan, Ma_Bc_Phat, Ngay_Phat, Gio_Phat, Ngay_Nhap, Gio_Nhap, Nguoi_Phat, Nguoi_Nhan, Khoi_Luong, Ma_Ly_Do, Ma_Xu_Ly, Phat_Duoc, Id_Nguoi_Dung, Ngay_He_Thong, Truyen_Khai_Thac,
        ' Output: 
        Public Sub Them(ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Phat As Integer, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ngay_Nhap As Integer, ByVal Gio_Nhap As Integer, ByVal Nguoi_Phat As String, ByVal Nguoi_Nhan As String, ByVal Khoi_Luong As Integer, ByVal Ma_Ly_Do As Integer, ByVal Ma_Xu_Ly As String, ByVal Phat_Duoc As Boolean, ByVal Id_Nguoi_Dung As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Value = Ngay_Nhap
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Value = Gio_Nhap
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat moi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Bao_Phat
        ' Input: Id_Bao_Phat,  Ma_E1 , Nuoc_Nhan , Ma_Bc_Phat , Ngay_Phat , Gio_Phat , Ngay_Nhap , Gio_Nhap , Nguoi_Phat , Nguoi_Nhan , Khoi_Luong , Ma_Ly_Do , Ma_Xu_Ly , Phat_Duoc , Id_Nguoi_Dung , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Bao_Phat As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Phat As Integer, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ngay_Nhap As Integer, ByVal Gio_Nhap As Integer, ByVal Nguoi_Phat As String, ByVal Nguoi_Nhan As String, ByVal Khoi_Luong As Integer, ByVal Ma_Ly_Do As Integer, ByVal Ma_Xu_Ly As String, ByVal Phat_Duoc As Boolean, ByVal Id_Nguoi_Dung As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Value = Ngay_Nhap
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Value = Gio_Nhap
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Bao_Phat
        ' Input: đối tượng thuộc lớp Bao_Phat_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myBao_Phat_Chi_Tiet As Bao_Phat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = myBao_Phat_Chi_Tiet.Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myBao_Phat_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = myBao_Phat_Chi_Tiet.Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = myBao_Phat_Chi_Tiet.Ma_Bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = myBao_Phat_Chi_Tiet.Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = myBao_Phat_Chi_Tiet.Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Value = myBao_Phat_Chi_Tiet.Ngay_Nhap
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Value = myBao_Phat_Chi_Tiet.Gio_Nhap
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = myBao_Phat_Chi_Tiet.Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = myBao_Phat_Chi_Tiet.Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myBao_Phat_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = myBao_Phat_Chi_Tiet.Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = myBao_Phat_Chi_Tiet.Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = myBao_Phat_Chi_Tiet.Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Value = myBao_Phat_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myBao_Phat_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myBao_Phat_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Bao_Phat
        ' Input: Id_Bao_Phat,  Ma_E1 , Nuoc_Nhan , Ma_Bc_Phat , Ngay_Phat , Gio_Phat , Ngay_Nhap , Gio_Nhap , Nguoi_Phat , Nguoi_Nhan , Khoi_Luong , Ma_Ly_Do , Ma_Xu_Ly , Phat_Duoc , Id_Nguoi_Dung , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Bao_Phat As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Phat As Integer, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ngay_Nhap As Integer, ByVal Gio_Nhap As Integer, ByVal Nguoi_Phat As String, ByVal Nguoi_Nhan As String, ByVal Khoi_Luong As Integer, ByVal Ma_Ly_Do As Integer, ByVal Ma_Xu_Ly As String, ByVal Phat_Duoc As Boolean, ByVal Id_Nguoi_Dung As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Value = Ngay_Nhap
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Value = Gio_Nhap
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

#Region "Bao_Phat_Cap_Nhat_Them_Tu_E1_Di"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Bao_Phat
        ' Input: Id_Bao_Phat,  Ma_E1 , Nuoc_Nhan , Ma_Bc_Phat , Ngay_Phat , Gio_Phat , Ngay_Nhap , Gio_Nhap , Nguoi_Phat , Nguoi_Nhan , Khoi_Luong , Ma_Ly_Do , Ma_Xu_Ly , Phat_Duoc , Id_Nguoi_Dung , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Bao_Phat_Cap_Nhat_Them_Tu_E1_Di(ByVal Id_Bao_Phat As String, ByVal Ma_E1 As String, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Phat As Integer, ByVal Ngay_Phat As Integer, ByVal Gio_Phat As Integer, ByVal Ngay_Nhap As Integer, ByVal Gio_Nhap As Integer, ByVal Nguoi_Phat As String, ByVal Nguoi_Nhan As String, ByVal Khoi_Luong As Integer, ByVal Ma_Ly_Do As Integer, ByVal Ma_Xu_Ly As String, ByVal Phat_Duoc As Boolean, ByVal Id_Nguoi_Dung As String, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat_Them_Tu_E1_Di", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNuoc_Nhan As SqlParameter = New SqlParameter("@Nuoc_Nhan", SqlDbType.VarChar, 2)
                pNuoc_Nhan.Value = Nuoc_Nhan
                myCommand.Parameters.Add(pNuoc_Nhan)

                Dim pMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                pMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(pMa_Bc_Phat)

                Dim pNgay_Phat As SqlParameter = New SqlParameter("@Ngay_Phat", SqlDbType.Int, 4)
                pNgay_Phat.Value = Ngay_Phat
                myCommand.Parameters.Add(pNgay_Phat)

                Dim pGio_Phat As SqlParameter = New SqlParameter("@Gio_Phat", SqlDbType.Int, 4)
                pGio_Phat.Value = Gio_Phat
                myCommand.Parameters.Add(pGio_Phat)

                Dim pNgay_Nhap As SqlParameter = New SqlParameter("@Ngay_Nhap", SqlDbType.Int, 4)
                pNgay_Nhap.Value = Ngay_Nhap
                myCommand.Parameters.Add(pNgay_Nhap)

                Dim pGio_Nhap As SqlParameter = New SqlParameter("@Gio_Nhap", SqlDbType.Int, 4)
                pGio_Nhap.Value = Gio_Nhap
                myCommand.Parameters.Add(pGio_Nhap)

                Dim pNguoi_Phat As SqlParameter = New SqlParameter("@Nguoi_Phat", SqlDbType.VarChar, 100)
                pNguoi_Phat.Value = Nguoi_Phat
                myCommand.Parameters.Add(pNguoi_Phat)

                Dim pNguoi_Nhan As SqlParameter = New SqlParameter("@Nguoi_Nhan", SqlDbType.VarChar, 100)
                pNguoi_Nhan.Value = Nguoi_Nhan
                myCommand.Parameters.Add(pNguoi_Nhan)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pPhat_Duoc As SqlParameter = New SqlParameter("@Phat_Duoc", SqlDbType.Bit, 1)
                pPhat_Duoc.Value = Phat_Duoc
                myCommand.Parameters.Add(pPhat_Duoc)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.VarChar, 50)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Xóa dữ liệu từ bảng Bao_Phat
        ' Input: Id_Bao_Phat
        ' Output: 
        Public Sub Xoa(ByVal Id_Bao_Phat As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Convert"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Bao_Phat
        ' Input: Id_Bao_Phat
        ' Output: 
        Public Sub Convert(ByVal Id_Bao_Phat As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("ConvertBaoPhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Bao_Phat As SqlParameter = New SqlParameter("@Id_Bao_Phat", SqlDbType.VarChar, 48)
                pId_Bao_Phat.Value = Id_Bao_Phat
                myCommand.Parameters.Add(pId_Bao_Phat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach_Tungay_Denngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Tungay_Denngay(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Tungay_Denngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Tungay_Denngay")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Buu_Ta"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Buu_Ta(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Buu_Ta", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Buu_Ta")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach_Chua_Phat_Duoc_Tu_Ngay_Den_Ngay_Theo_Buu_Ta"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Phat_Duoc_Tu_Ngay_Den_Ngay_Theo_Buu_Ta(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal Ma_Bc As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Chua_Phat_Duoc_Tu_Ngay_Den_Ngay_Theo_Buu_Ta", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)
                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Chua_Phat_Duoc_Tu_Ngay_Den_Ngay_Theo_Buu_Ta")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Sach_Tungay_Denngay_Chua_Phat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Tungay_Denngay_Chua_Phat(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Tungay_Denngay_Chuaphat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Tungay_Denngay_Chuaphat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Bao_Phat_Thong_Tin_Ma_E1_Lay_Trong_E1_Di"
        ' Ngày tạo: 15/6/08
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Thong_Tin_Ma_E1_Lay_Trong_E1_Di(ByVal Ma_E1 As String, ByVal Tungay As Integer, ByVal Denngay As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Thong_Tin_Ma_E1_Lay_Trong_E1_Di", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataTable As New DataTable

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PMa_e1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                PMa_e1.Value = Ma_E1
                myCommand.Parameters.Add(PMa_e1)
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataTable)
                myConnection.Close()
                myConnection.Dispose()
                Return myDataTable
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Thong_Ke_Khong_Nhap_Bao_Phat"
        ' Ngày tạo: 21/09/08
        ' Nội dung: Thong kê các Mã E1 khong có trong Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Thong_Ke_EMS_Khong_Nhap_Bao_Phat(ByVal Ma_Bc As Integer, ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Thong_Ke_EMS_Khong_Nhap", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataset As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int)
                PMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(PMa_Bc)

                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)

                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataset, "Bao_Phat_Thong_Ke_EMS_Khong_Nhap")
                myConnection.Close()
                'myConnection.Dispose()
                Return myDataset
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach_Chua_Truyen"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Chua_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Chua_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Chua_Truyen_Theo_Ma_Bc_phat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen_Theo_Ma_Bc_phat(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Ma_Bc As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Chua_Truyen_Theo_Ma_Bc_Phat", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Chua_Truyen_Theo_Ma_Bc_Phat")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Bao_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chua_Truyen_Ngay_Nghi(ByVal Ngay_Nghi As Integer, ByVal Ma_Bc_Phat As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục                
                Dim PNgay_Nghi As SqlParameter = New SqlParameter("@Ngay_Nghi", SqlDbType.Int, 4)
                PNgay_Nghi.Value = Ngay_Nghi
                myCommand.Parameters.Add(PNgay_Nghi)

                Dim PMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                PMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(PMa_Bc_Phat)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Danh_Sach_Chua_Truyen_Ngay_Nghi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen(ByVal Tungay As Integer, ByVal Denngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi(ByVal Ngay_Nghi As Integer, ByVal Ma_Bc_Phat As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PNgay_Nghi As SqlParameter = New SqlParameter("@Ngay_Nghi", SqlDbType.Int, 4)
                PNgay_Nghi.Value = Ngay_Nghi
                myCommand.Parameters.Add(PNgay_Nghi)

                Dim PMa_Bc_Phat As SqlParameter = New SqlParameter("@Ma_Bc_Phat", SqlDbType.Int, 4)
                PMa_Bc_Phat.Value = Ma_Bc_Phat
                myCommand.Parameters.Add(PMa_Bc_Phat)


                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiem_Tra_Theo_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Kiem_Tra_Theo_Ma_E1(ByVal Ma_E1 As String, ByVal Tu_Ngay As String, ByVal Den_Ngay As String) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Kiem_Tra_Theo_Ma_E1", myConnection)


                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pTon_Tai As SqlParameter = New SqlParameter("@Ton_Tai", SqlDbType.Int)
                pTon_Tai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTon_Tai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Return pTon_Tai.Value
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ly_Do"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ly_Do thông qua khóa chính 
        ' Input: Ma_Ly_Do
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ly_Do(ByVal Ma_Ly_Do As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Lay_Boi_Ly_Do", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Ly_Do As SqlParameter = New SqlParameter("@Ma_Ly_Do", SqlDbType.Int, 4)
                pMa_Ly_Do.Value = Ma_Ly_Do
                myCommand.Parameters.Add(pMa_Ly_Do)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Lay_Boi_Ly_Do")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Xu_Ly"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Xu_Ly thông qua khóa chính 
        ' Input: Ma_Xu_Ly
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Xu_Ly(ByVal Ma_Xu_Ly As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Lay_Boi_Xu_Ly", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Bao_Phat_Lay_Boi_Xu_Ly")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Kiểm tra sự tồn tại của bưu phẩm báo phát"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Function check_e1_baophat(ByVal Ma_e1 As String, ByVal Ngay_Nhap As Integer, ByVal Ngay_KT As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            myCommand = New SqlCommand("Select Id_Bao_Phat from Bao_Phat where Ma_E1= '" & Ma_e1 & "' and Phat_Duoc=1 and Ngay_Nhap between " & Ngay_KT & " and " & Ngay_Nhap & "", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, "", myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
        Public Function check_e1_baophat_CoChiTiet(ByVal Ma_e1 As String, ByVal Ngay_Nhap As Integer, ByVal Ngay_KT As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            myCommand = New SqlCommand("Select Id_Bao_Phat from Bao_Phat where Ma_E1= '" & Ma_e1 & "' and Phat_Duoc=0 and Ngay_Nhap between " & Ngay_KT & " and " & Ngay_Nhap & "", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, "", myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
        Public Function check_e1_baophat_quangay(ByVal Ma_e1 As String, ByVal Ngay_Nhap As Integer, ByVal Ngay_KT As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean
            myCommand = New SqlCommand("Select count(*) from Bao_Phat where Ma_E1= '" & Ma_e1 & "' and Ngay_Nhap between " & Ngay_KT & " and " & Ngay_Nhap & "", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf((myCommand.ExecuteScalar = 0), False, True)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
        Public Function Kiem_Tra_Ma_E1(ByVal Ma_e1 As String) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean
            myCommand = New SqlCommand("Select count(*) from Bao_Phat where Ma_E1= '" & Ma_e1 & "' ", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf((myCommand.ExecuteScalar = 0), False, True)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region

#Region "Kiểm tra sự tồn tại của bưu phẩm trong bảng Báo Phát"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Function Get_Id_Bao_Phat(ByVal Ma_e1 As String, ByVal Ngay_Nhap As Integer, ByVal Ngay_KT As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            Dim Id_bao_Phat As String
            myCommand = New SqlCommand("Select  max(Id_bao_Phat) from Bao_Phat where Ma_E1= '" & Ma_e1 & "' and Ngay_Nhap between " & Ngay_Nhap & " and " & Ngay_KT & "", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region

#Region "Kiểm tra sự mã E1 trong bảng E1_Di co chi tiet nhung qua ngay"
        ' Ngày tạo: 27/6/08
        ' Input: mae1
        ' Output: true or false
        Public Function check_e1_di(ByVal Ma_e1 As String, ByVal Ngay_Nhap As Integer, ByVal Ngay_KT As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            myCommand = New SqlCommand("Select top 1 id_duong_thu from e1_den where Ma_E1= '" & Ma_e1 & "'  and  Ngay_Dong between " & Ngay_KT & " and " & Ngay_Nhap & "  order by ngay_dong ,gio_dong desc", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is Nothing, "", myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region

#Region "Phần Tra cứu bưu phẩm trong bảng Bao_Phat - Coded by Quang Đô"
#Region "Bao_Phat_Tim_Kiem_E1_Duoi - tìm kiếm E1 trong Table Bao_Phat"
        ' Ngày tạo: 26/06/2008
        ' Người tạo: Quang Đô
        ' Nội dung: Tìm kiếm E1 theo điều kiện từ ngày đến ngày trong bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Tim_Kiem_E1_Duoi(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Ma_e1 As String, ByVal Chk_Dau_Ma As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Tim_Kiem_E1_Duoi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_e1
                myCommand.Parameters.Add(pMa_E1)

                Dim pChk_Dau_Ma As SqlParameter = New SqlParameter("@Chk_Dau_Ma", SqlDbType.Int, 1)
                pChk_Dau_Ma.Value = Chk_Dau_Ma
                myCommand.Parameters.Add(pChk_Dau_Ma)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "Bao_Phat_Tim_Kiem_E1_Duoi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Bao_Phat_Tim_Kiem_E1_Report - tìm kiếm E1 trong Table Bao_Phat_Report"
        ' Ngày tạo: 26/06/2008
        ' Người tạo: Quang Đô
        ' Nội dung: Tìm kiếm E1 theo điều kiện từ ngày đến ngày trong bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Tim_Kiem_E1_Report(ByVal Tungay As Long, ByVal Denngay As Long, ByVal Ma_e1 As String, ByVal Chk_Dau_Ma As Integer) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Tim_Kiem_E1_Report", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_e1
                myCommand.Parameters.Add(pMa_E1)

                Dim pChk_Dau_Ma As SqlParameter = New SqlParameter("@Chk_Dau_Ma", SqlDbType.Int, 1)
                pChk_Dau_Ma.Value = Chk_Dau_Ma
                myCommand.Parameters.Add(pChk_Dau_Ma)

                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000

                If Not myDataSet.Tables("Bao_Phat_Tim_Kiem_E1_Report") Is Nothing Then
                    myDataSet.Tables("Bao_Phat_Tim_Kiem_E1_Report").Clear()
                End If
                myAdapter.Fill(myDataSet, "Bao_Phat_Tim_Kiem_E1_Report")

                Return myDataSet.Tables("Bao_Phat_Tim_Kiem_E1_Report")
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Bao_Phat_Tim_Kiem_E1_Trai - tìm kiếm E1 hiển thị danh sách E1 bên trái"
        ' Ngày tạo: 26/06/2008
        ' Người tạo: Quang Đô
        ' Nội dung: Tìm kiếm E1 theo điều kiện từ ngày đến ngày trong bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Tim_Kiem_E1_Trai(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Ma_e1 As String, ByVal Chk_Dau_Ma As Integer) As DataSet
            ' Try
            ' Tạo đối tượng connection và command
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Tim_Kiem_E1_Trai", myConnection)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myDataSet As DataSet = New DataSet

            ' Sử dụng Store Procedure
            myCommand.CommandType = CommandType.StoredProcedure
            ' Thêm các Parameters vào thủ tục
            Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
            PTungay.Value = Tungay
            myCommand.Parameters.Add(PTungay)
            Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
            PDenngay.Value = Denngay
            myCommand.Parameters.Add(PDenngay)

            Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
            pMa_E1.Value = Ma_e1
            myCommand.Parameters.Add(pMa_E1)

            Dim pChk_Dau_Ma As SqlParameter = New SqlParameter("@Chk_Dau_Ma", SqlDbType.Int, 1)
            pChk_Dau_Ma.Value = Chk_Dau_Ma
            myCommand.Parameters.Add(pChk_Dau_Ma)

            myConnection.Open()
            myAdapter.SelectCommand = myCommand
            myCommand.CommandTimeout = 20000
            myAdapter.Fill(myDataSet, "Bao_Phat_Tim_Kiem_E1_Trai")
            myConnection.Close()
            myConnection.Dispose()
            Return myDataSet
            'Catch ex As Exception
            'Console.Write(ex.ToString)
            ' End Try
        End Function
#End Region

#Region "Bao_Phat_Tim_Kiem_E1_Trai_Theo_Dia_Chi - tìm kiếm E1 (theo địa chỉ) hiển thị danh sách E1 bên trái"
        ' Ngày tạo: 26/06/2008
        ' Người tạo: Quang Đô
        ' Nội dung: Tìm kiếm E1 theo điều kiện từ ngày đến ngày trong bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Tim_Kiem_E1_Trai_Theo_Dia_Chi(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Dia_Chi As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Tim_Kiem_E1_Trai_Theo_Dia_Chi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.VarChar, 100)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "Bao_Phat_Tim_Kiem_E1_Trai_Theo_Dia_Chi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Bao_Phat_Tim_Kiem_E1_Tren - tìm kiếm E1 trong Table E1 đi đến"
        ' Ngày tạo: 26/06/2008
        ' Người tạo: Quang Đô
        ' Nội dung: Tìm kiếm E1 theo điều kiện từ ngày đến ngày trong bảng Bao_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Bao_Phat_Tim_Kiem_E1_Tren(ByVal Tungay As Integer, ByVal Denngay As Integer, ByVal Ma_e1 As String, ByVal Chk_Dau_Ma As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Bao_Phat_Tim_Kiem_E1_Tren", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim PTungay As SqlParameter = New SqlParameter("@Tungay", SqlDbType.Int, 4)
                PTungay.Value = Tungay
                myCommand.Parameters.Add(PTungay)
                Dim PDenngay As SqlParameter = New SqlParameter("@Denngay", SqlDbType.Int, 4)
                PDenngay.Value = Denngay
                myCommand.Parameters.Add(PDenngay)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_e1
                myCommand.Parameters.Add(pMa_E1)

                Dim pChk_Dau_Ma As SqlParameter = New SqlParameter("@Chk_Dau_Ma", SqlDbType.Int, 1)
                pChk_Dau_Ma.Value = Chk_Dau_Ma
                myCommand.Parameters.Add(pChk_Dau_Ma)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myCommand.CommandTimeout = 20000
                myAdapter.Fill(myDataSet, "Bao_Phat_Tim_Kiem_E1_Tren")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#End Region

    End Class
#End Region
End Namespace

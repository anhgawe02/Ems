
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Chuyen_Hoan_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Chuyen_Hoan_Chi_Tiet
    ' tương ứng với mộ trường của bảng Chuyen_Hoan trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Chuyen_Hoan_Chi_Tiet
        Public Id_Chuyen_Hoan As String ' Tương tự Id_E1
        Public Ma_E1 As String ' Số hiệu E1: EEXXXXXXXXXVN
        Public Khoi_Luong As Integer ' Khối lượng bưu phẩm chuyển hoàn
        Public Ma_Tinh_CH As Integer ' Mã tỉnh chuyển hoàn lại
        Public Ma_Bc_CH As Integer ' Bưu cục sẽ được chuyển hoàn lại
        Public Ngay_CH As Integer ' Ngày chuyển hoàn
        Public Gio_CH As Integer ' Giờ chuyển hoàn
        Public Tien_CH As Integer ' Số tiền chuyển hoàn
        Public Truyen_So_Lieu As Boolean ' Đã truyền số liệu chưa
    End Class
#End Region
#Region "Chuyen_Hoan"
    Public Class Chuyen_Hoan
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Chuyen_Hoan
        ' Input: Id_Chuyen_Hoan
        ' Output: Chuyen_Hoan_Chi_Tiet
        Public Function Lay(ByVal Id_Chuyen_Hoan As String) As Chuyen_Hoan_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_Hoan As SqlParameter = New SqlParameter("@Id_Chuyen_Hoan", SqlDbType.VarChar, 48)
                pId_Chuyen_Hoan.Value = Id_Chuyen_Hoan
                myCommand.Parameters.Add(pId_Chuyen_Hoan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Tinh_CH As SqlParameter = New SqlParameter("@Ma_Tinh_CH", SqlDbType.Int, 4)
                pMa_Tinh_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh_CH)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pNgay_CH As SqlParameter = New SqlParameter("@Ngay_CH", SqlDbType.Int, 4)
                pNgay_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_CH)

                Dim pGio_CH As SqlParameter = New SqlParameter("@Gio_CH", SqlDbType.Int, 4)
                pGio_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_CH)

                Dim pTien_CH As SqlParameter = New SqlParameter("@Tien_CH", SqlDbType.Int, 4)
                pTien_CH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTien_CH)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 1)
                pTruyen_So_Lieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_So_Lieu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myChuyen_Hoan_Chi_Tiet As Chuyen_Hoan_Chi_Tiet = New Chuyen_Hoan_Chi_Tiet
                myChuyen_Hoan_Chi_Tiet.Id_Chuyen_Hoan = Id_Chuyen_Hoan
                myChuyen_Hoan_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myChuyen_Hoan_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myChuyen_Hoan_Chi_Tiet.Ma_Tinh_CH = pMa_Tinh_CH.Value
                myChuyen_Hoan_Chi_Tiet.Ma_Bc_CH = pMa_Bc_CH.Value
                myChuyen_Hoan_Chi_Tiet.Ngay_CH = pNgay_CH.Value
                myChuyen_Hoan_Chi_Tiet.Gio_CH = pGio_CH.Value
                myChuyen_Hoan_Chi_Tiet.Tien_CH = pTien_CH.Value
                myChuyen_Hoan_Chi_Tiet.Truyen_So_Lieu = pTruyen_So_Lieu.Value
                Return myChuyen_Hoan_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Chuyen_Hoan
        ' Input:  Ma_E1, Khoi_Luong, Ma_Tinh_CH, Ma_Bc_CH, Ngay_CH, Gio_CH, Tien_CH, Truyen_So_Lieu,
        ' Output: 
        Public Sub Them(ByVal Ma_E1 As String, ByVal Khoi_Luong As Integer, ByVal Ma_Tinh_CH As Integer, ByVal Ma_Bc_CH As Integer, ByVal Ngay_CH As Integer, ByVal Gio_CH As Integer, ByVal Tien_CH As Integer, ByVal Truyen_So_Lieu As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Tinh_CH As SqlParameter = New SqlParameter("@Ma_Tinh_CH", SqlDbType.Int, 4)
                pMa_Tinh_CH.Value = Ma_Tinh_CH
                myCommand.Parameters.Add(pMa_Tinh_CH)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pNgay_CH As SqlParameter = New SqlParameter("@Ngay_CH", SqlDbType.Int, 4)
                pNgay_CH.Value = Ngay_CH
                myCommand.Parameters.Add(pNgay_CH)

                Dim pGio_CH As SqlParameter = New SqlParameter("@Gio_CH", SqlDbType.Int, 4)
                pGio_CH.Value = Gio_CH
                myCommand.Parameters.Add(pGio_CH)

                Dim pTien_CH As SqlParameter = New SqlParameter("@Tien_CH", SqlDbType.Int, 4)
                pTien_CH.Value = Tien_CH
                myCommand.Parameters.Add(pTien_CH)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 1)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                myCommand.Parameters.Add(pTruyen_So_Lieu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuyen_Hoan
        ' Input: Id_Chuyen_Hoan,  Ma_E1 , Khoi_Luong , Ma_Tinh_CH , Ma_Bc_CH , Ngay_CH , Gio_CH , Tien_CH , Truyen_So_Lieu ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Chuyen_Hoan As String, ByVal Ma_E1 As String, ByVal Khoi_Luong As Integer, ByVal Ma_Tinh_CH As Integer, ByVal Ma_Bc_CH As Integer, ByVal Ngay_CH As Integer, ByVal Gio_CH As Integer, ByVal Tien_CH As Integer, ByVal Truyen_So_Lieu As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Hoan As SqlParameter = New SqlParameter("@Id_Chuyen_Hoan", SqlDbType.VarChar, 48)
                pId_Chuyen_Hoan.Value = Id_Chuyen_Hoan
                myCommand.Parameters.Add(pId_Chuyen_Hoan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Tinh_CH As SqlParameter = New SqlParameter("@Ma_Tinh_CH", SqlDbType.Int, 4)
                pMa_Tinh_CH.Value = Ma_Tinh_CH
                myCommand.Parameters.Add(pMa_Tinh_CH)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pNgay_CH As SqlParameter = New SqlParameter("@Ngay_CH", SqlDbType.Int, 4)
                pNgay_CH.Value = Ngay_CH
                myCommand.Parameters.Add(pNgay_CH)

                Dim pGio_CH As SqlParameter = New SqlParameter("@Gio_CH", SqlDbType.Int, 4)
                pGio_CH.Value = Gio_CH
                myCommand.Parameters.Add(pGio_CH)

                Dim pTien_CH As SqlParameter = New SqlParameter("@Tien_CH", SqlDbType.Int, 4)
                pTien_CH.Value = Tien_CH
                myCommand.Parameters.Add(pTien_CH)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 1)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                myCommand.Parameters.Add(pTruyen_So_Lieu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuyen_Hoan
        ' Input: đối tượng thuộc lớp Chuyen_Hoan_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myChuyen_Hoan_Chi_Tiet As Chuyen_Hoan_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Chuyen_Hoan As SqlParameter = New SqlParameter("@Id_Chuyen_Hoan", SqlDbType.VarChar, 48)
                pId_Chuyen_Hoan.Value = myChuyen_Hoan_Chi_Tiet.Id_Chuyen_Hoan
                myCommand.Parameters.Add(pId_Chuyen_Hoan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myChuyen_Hoan_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myChuyen_Hoan_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Tinh_CH As SqlParameter = New SqlParameter("@Ma_Tinh_CH", SqlDbType.Int, 4)
                pMa_Tinh_CH.Value = myChuyen_Hoan_Chi_Tiet.Ma_Tinh_CH
                myCommand.Parameters.Add(pMa_Tinh_CH)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = myChuyen_Hoan_Chi_Tiet.Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pNgay_CH As SqlParameter = New SqlParameter("@Ngay_CH", SqlDbType.Int, 4)
                pNgay_CH.Value = myChuyen_Hoan_Chi_Tiet.Ngay_CH
                myCommand.Parameters.Add(pNgay_CH)

                Dim pGio_CH As SqlParameter = New SqlParameter("@Gio_CH", SqlDbType.Int, 4)
                pGio_CH.Value = myChuyen_Hoan_Chi_Tiet.Gio_CH
                myCommand.Parameters.Add(pGio_CH)

                Dim pTien_CH As SqlParameter = New SqlParameter("@Tien_CH", SqlDbType.Int, 4)
                pTien_CH.Value = myChuyen_Hoan_Chi_Tiet.Tien_CH
                myCommand.Parameters.Add(pTien_CH)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 1)
                pTruyen_So_Lieu.Value = myChuyen_Hoan_Chi_Tiet.Truyen_So_Lieu
                myCommand.Parameters.Add(pTruyen_So_Lieu)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Chuyen_Hoan
        ' Input: Id_Chuyen_Hoan,  Ma_E1 , Khoi_Luong , Ma_Tinh_CH , Ma_Bc_CH , Ngay_CH , Gio_CH , Tien_CH , Truyen_So_Lieu ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Chuyen_Hoan As String, ByVal Ma_E1 As String, ByVal Khoi_Luong As Integer, ByVal Ma_Tinh_CH As Integer, ByVal Ma_Bc_CH As Integer, ByVal Ngay_CH As Integer, ByVal Gio_CH As Integer, ByVal Tien_CH As Integer, ByVal Truyen_So_Lieu As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Hoan As SqlParameter = New SqlParameter("@Id_Chuyen_Hoan", SqlDbType.VarChar, 48)
                pId_Chuyen_Hoan.Value = Id_Chuyen_Hoan
                myCommand.Parameters.Add(pId_Chuyen_Hoan)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pMa_Tinh_CH As SqlParameter = New SqlParameter("@Ma_Tinh_CH", SqlDbType.Int, 4)
                pMa_Tinh_CH.Value = Ma_Tinh_CH
                myCommand.Parameters.Add(pMa_Tinh_CH)

                Dim pMa_Bc_CH As SqlParameter = New SqlParameter("@Ma_Bc_CH", SqlDbType.Int, 4)
                pMa_Bc_CH.Value = Ma_Bc_CH
                myCommand.Parameters.Add(pMa_Bc_CH)

                Dim pNgay_CH As SqlParameter = New SqlParameter("@Ngay_CH", SqlDbType.Int, 4)
                pNgay_CH.Value = Ngay_CH
                myCommand.Parameters.Add(pNgay_CH)

                Dim pGio_CH As SqlParameter = New SqlParameter("@Gio_CH", SqlDbType.Int, 4)
                pGio_CH.Value = Gio_CH
                myCommand.Parameters.Add(pGio_CH)

                Dim pTien_CH As SqlParameter = New SqlParameter("@Tien_CH", SqlDbType.Int, 4)
                pTien_CH.Value = Tien_CH
                myCommand.Parameters.Add(pTien_CH)

                Dim pTruyen_So_Lieu As SqlParameter = New SqlParameter("@Truyen_So_Lieu", SqlDbType.Bit, 1)
                pTruyen_So_Lieu.Value = Truyen_So_Lieu
                myCommand.Parameters.Add(pTruyen_So_Lieu)


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
        ' Nội dung: Xóa dữ liệu từ bảng Chuyen_Hoan
        ' Input: Id_Chuyen_Hoan
        ' Output: 
        Public Sub Xoa(ByVal Id_Chuyen_Hoan As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Hoan As SqlParameter = New SqlParameter("@Id_Chuyen_Hoan", SqlDbType.VarChar, 48)
                pId_Chuyen_Hoan.Value = Id_Chuyen_Hoan
                myCommand.Parameters.Add(pId_Chuyen_Hoan)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Chuyen_Hoan
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Hoan_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuyen_Hoan_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region


    End Class
#End Region
End Namespace

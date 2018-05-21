
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Khu_Vuc_TN_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Khu_Vuc_TN_Chi_Tiet
    ' tương ứng với mộ trường của bảng Khu_Vuc_TN trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Khu_Vuc_TN_Chi_Tiet
        Public Id_Khu_Vuc As Integer
        Public Tinh_Chap_Nhan As Integer ' Mã tỉnh chấp nhận
        Public Tinh_Phat_Tra As Integer ' Mã tỉnh phát trả
        Public Khoang_Cach As Integer ' Khoảng cách giữa 2 tỉnh
        Public Khu_Vuc As Integer
    End Class
#End Region
#Region "Khu_Vuc_TN"
    Public Class Khu_Vuc_TN
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc
        ' Output: Khu_Vuc_TN_Chi_Tiet
        Public Function Lay(ByVal Id_Khu_Vuc As Integer) As Khu_Vuc_TN_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Khu_Vuc As SqlParameter = New SqlParameter("@Id_Khu_Vuc", SqlDbType.Int, 4)
                pId_Khu_Vuc.Value = Id_Khu_Vuc
                myCommand.Parameters.Add(pId_Khu_Vuc)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pKhoang_Cach As SqlParameter = New SqlParameter("@Khoang_Cach", SqlDbType.Int, 4)
                pKhoang_Cach.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoang_Cach)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhu_Vuc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myKhu_Vuc_TN_Chi_Tiet As Khu_Vuc_TN_Chi_Tiet = New Khu_Vuc_TN_Chi_Tiet
                myKhu_Vuc_TN_Chi_Tiet.Id_Khu_Vuc = Id_Khu_Vuc
                myKhu_Vuc_TN_Chi_Tiet.Tinh_Chap_Nhan = pTinh_Chap_Nhan.Value
                myKhu_Vuc_TN_Chi_Tiet.Tinh_Phat_Tra = pTinh_Phat_Tra.Value
                myKhu_Vuc_TN_Chi_Tiet.Khoang_Cach = pKhoang_Cach.Value
                myKhu_Vuc_TN_Chi_Tiet.Khu_Vuc = pKhu_Vuc.Value
                Return myKhu_Vuc_TN_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Khu_Vuc_TN
        ' Input:  Tinh_Chap_Nhan, Tinh_Phat_Tra, Khoang_Cach, Khu_Vuc,
        ' Output: 
        Public Sub Them(ByVal Tinh_Chap_Nhan As Integer, ByVal Tinh_Phat_Tra As Integer, ByVal Khoang_Cach As Integer, ByVal Khu_Vuc As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pKhoang_Cach As SqlParameter = New SqlParameter("@Khoang_Cach", SqlDbType.Int, 4)
                pKhoang_Cach.Value = Khoang_Cach
                myCommand.Parameters.Add(pKhoang_Cach)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc,  Tinh_Chap_Nhan , Tinh_Phat_Tra , Khoang_Cach , Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Khu_Vuc As Integer, ByVal Tinh_Chap_Nhan As Integer, ByVal Tinh_Phat_Tra As Integer, ByVal Khoang_Cach As Integer, ByVal Khu_Vuc As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khu_Vuc As SqlParameter = New SqlParameter("@Id_Khu_Vuc", SqlDbType.Int, 4)
                pId_Khu_Vuc.Value = Id_Khu_Vuc
                myCommand.Parameters.Add(pId_Khu_Vuc)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pKhoang_Cach As SqlParameter = New SqlParameter("@Khoang_Cach", SqlDbType.Int, 4)
                pKhoang_Cach.Value = Khoang_Cach
                myCommand.Parameters.Add(pKhoang_Cach)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khu_Vuc_TN
        ' Input: đối tượng thuộc lớp Khu_Vuc_TN_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myKhu_Vuc_TN_Chi_Tiet As Khu_Vuc_TN_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Khu_Vuc As SqlParameter = New SqlParameter("@Id_Khu_Vuc", SqlDbType.Int, 4)
                pId_Khu_Vuc.Value = myKhu_Vuc_TN_Chi_Tiet.Id_Khu_Vuc
                myCommand.Parameters.Add(pId_Khu_Vuc)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = myKhu_Vuc_TN_Chi_Tiet.Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = myKhu_Vuc_TN_Chi_Tiet.Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pKhoang_Cach As SqlParameter = New SqlParameter("@Khoang_Cach", SqlDbType.Int, 4)
                pKhoang_Cach.Value = myKhu_Vuc_TN_Chi_Tiet.Khoang_Cach
                myCommand.Parameters.Add(pKhoang_Cach)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = myKhu_Vuc_TN_Chi_Tiet.Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc,  Tinh_Chap_Nhan , Tinh_Phat_Tra , Khoang_Cach , Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Tinh_Chap_Nhan As Integer, ByVal Tinh_Phat_Tra As Integer, ByVal Khoang_Cach As Integer, ByVal Khu_Vuc As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pKhoang_Cach As SqlParameter = New SqlParameter("@Khoang_Cach", SqlDbType.Int, 4)
                pKhoang_Cach.Value = Khoang_Cach
                myCommand.Parameters.Add(pKhoang_Cach)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)


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
        ' Nội dung: Xóa dữ liệu từ bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc
        ' Output: 
        Public Sub Xoa(ByVal Id_Khu_Vuc As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khu_Vuc As SqlParameter = New SqlParameter("@Id_Khu_Vuc", SqlDbType.Int, 4)
                pId_Khu_Vuc.Value = Id_Khu_Vuc
                myCommand.Parameters.Add(pId_Khu_Vuc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Xoa_Tat_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Xoa_Tat_Ca", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Lay_Tat_Ca_Tu_Tmp"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Khu_Vuc_TN
        ' Input: Id_Khu_Vuc
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Lay_Tat_Ca_Tu_Tmp", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khu_Vuc_TN
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_TN_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khu_Vuc_TN
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_TN_Danh_Sach_Hien_Thi")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Tinh"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Tinh thông qua khóa chính 
        ' Input: Tinh_Phat_Tra
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Tinh(ByVal Tinh_Chap_Nhan As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_TN_Lay_Boi_Ma_Tinh", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_TN_Lay_Boi_Ma_Tinh")
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

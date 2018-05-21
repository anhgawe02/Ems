
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ty_Gia_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ty_Gia_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ty_Gia trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ty_Gia_Chi_Tiet
        Public Ngay As Integer
        Public Ty_Gia As Integer
    End Class
#End Region
#Region "Ty_Gia"
    Public Class Ty_Gia
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ty_Gia
        ' Input: Ngay
        ' Output: Ty_Gia_Chi_Tiet
        Public Function Lay(ByVal Ngay As Integer) As Ty_Gia_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTy_Gia)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTy_Gia_Chi_Tiet As Ty_Gia_Chi_Tiet = New Ty_Gia_Chi_Tiet
                myTy_Gia_Chi_Tiet.Ngay = Ngay
                myTy_Gia_Chi_Tiet.Ty_Gia = pTy_Gia.Value
                Return myTy_Gia_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ty_Gia
        ' Input:  Ty_Gia,
        ' Output: 
        Public Sub Them(ByVal Ty_Gia As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Value = Ty_Gia
                myCommand.Parameters.Add(pTy_Gia)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ty_Gia
        ' Input: Ngay,  Ty_Gia ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ngay As Integer, ByVal Ty_Gia As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Value = Ty_Gia
                myCommand.Parameters.Add(pTy_Gia)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ty_Gia
        ' Input: đối tượng thuộc lớp Ty_Gia_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTy_Gia_Chi_Tiet As Ty_Gia_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = myTy_Gia_Chi_Tiet.Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Value = myTy_Gia_Chi_Tiet.Ty_Gia
                myCommand.Parameters.Add(pTy_Gia)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ty_Gia
        ' Input: Ngay,  Ty_Gia ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ngay As Integer, ByVal Ty_Gia As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Value = Ty_Gia
                myCommand.Parameters.Add(pTy_Gia)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ty_Gia
        ' Input: Ngay
        ' Output: 
        Public Sub Xoa(ByVal Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Kiem tra Trung ngay"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra xem co ton tai ngay hay khong
        ' Input: Ngay
        ' Output: count(*)
        Public Function Kiem_Tra_Trung_Ngay(ByVal Ngay As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Kiem_Tra_Trung_Ngay", myConnection)
                Dim myReturn As Boolean
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pIsValid As SqlParameter = New SqlParameter("@IsValid", SqlDbType.Bit, 1)
                pIsValid.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIsValid)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myReturn = pIsValid.Value
                Return myReturn
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ty_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ty_Gia_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ty_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ty_Gia_Danh_Sach_Hien_Thi")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Theo_Ngay_Gan_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ty_Gia
        ' Input: Ngay
        ' Output: 
        Public Sub Lay_Theo_Ngay_Gan_Nhat(ByVal Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Lay_Theo_Ngay_Gan_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region

#Region "Lay_Ty_Gia_Theo_Ngay_Gan_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: lấy tỷ giá theo ngày gần nhất
        ' Input: Ngay
        ' Output: 
        Public Function Lay_Ty_Gia_Theo_Ngay_Gan_Nhat(ByVal Ngay As Integer) As Integer
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ty_Gia_Lay_Ty_Gia_Theo_Ngay_Gan_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pNgay As SqlParameter = New SqlParameter("@Ngay", SqlDbType.Int, 4)
                pNgay.Value = Ngay
                myCommand.Parameters.Add(pNgay)

                Dim pTy_Gia As SqlParameter = New SqlParameter("@Ty_Gia", SqlDbType.Int, 4)
                pTy_Gia.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTy_Gia)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                If pTy_Gia.Value Is System.DBNull.Value Then
                    Return 0
                Else
                    Return pTy_Gia.Value
                End If
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
    End Class
#End Region
End Namespace
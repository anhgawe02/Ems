
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Xu_Ly_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Xu_Ly_Chi_Tiet
    ' tương ứng với mộ trường của bảng Xu_Ly trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Xu_Ly_Chi_Tiet
        Public Ma_Xu_Ly As String ' Mã xử lý BP không phát được
        Public Ten_Xu_Ly As String
        Public Ten_Xu_Ly_EN As String
    End Class
#End Region
#Region "Xu_Ly"
    Public Class Xu_Ly
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Xu_Ly
        ' Input: Ma_Xu_Ly
        ' Output: Xu_Ly_Chi_Tiet
        Public Function Lay(ByVal Ma_Xu_Ly As String) As Xu_Ly_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myXu_Ly_Chi_Tiet As Xu_Ly_Chi_Tiet = New Xu_Ly_Chi_Tiet
                myXu_Ly_Chi_Tiet.Ma_Xu_Ly = Ma_Xu_Ly
                myXu_Ly_Chi_Tiet.Ten_Xu_Ly = pTen_Xu_Ly.Value
                myXu_Ly_Chi_Tiet.Ten_Xu_Ly_EN = pTen_Xu_Ly_EN.Value
                Return myXu_Ly_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Xu_Ly
        ' Input:  Ten_Xu_Ly, Ten_Xu_Ly_EN,
        ' Output: 
        Public Sub Them(ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Value = Ten_Xu_Ly
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Value = Ten_Xu_Ly_EN
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Xu_Ly
        ' Input: Ma_Xu_Ly,  Ten_Xu_Ly , Ten_Xu_Ly_EN ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Xu_Ly As String, ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Value = Ten_Xu_Ly
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Value = Ten_Xu_Ly_EN
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Xu_Ly
        ' Input: đối tượng thuộc lớp Xu_Ly_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myXu_Ly_Chi_Tiet As Xu_Ly_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = myXu_Ly_Chi_Tiet.Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Value = myXu_Ly_Chi_Tiet.Ten_Xu_Ly
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Value = myXu_Ly_Chi_Tiet.Ten_Xu_Ly_EN
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Xu_Ly
        ' Input: Ma_Xu_Ly,  Ten_Xu_Ly , Ten_Xu_Ly_EN ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Xu_Ly As String, ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Value = Ten_Xu_Ly
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Value = Ten_Xu_Ly_EN
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)


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
        ' Nội dung: Xóa dữ liệu từ bảng Xu_Ly
        ' Input: Ma_Xu_Ly
        ' Output: 
        Public Sub Xoa(ByVal Ma_Xu_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Kiem tra Ma_Xu_Ly"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_Xu_Ly(ByVal Ma_Xu_Ly As String) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from Xu_Ly where (Ma_Xu_Ly= '" & Ma_Xu_Ly & "') ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Xu_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Xu_Ly_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Chi_Tiet"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Xu_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Chi_Tiet_Xu_Ly(ByVal Ma_Xu_Ly As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Danh_Sach_Chi_Tiet", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Xu_Ly_Danh_Sach_Chi_Tiet")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Ly_Do_Chi_Tiet_Xu_Ly"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Xu_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Ly_Do_Chi_Tiet_Xu_Ly(ByVal Ma_Ly_Do As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ly_Do_Chi_Tiet_Xu_Ly", myConnection)
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
                myAdapter.Fill(myDataSet, "Ly_Do_Chi_Tiet_Xu_Ly")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ten_Ly_Do"
        ' Ngày tạo: 15/6/08
        ' Người tạo: tuyennv
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Xu_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ten_Ly_Do(ByVal Ten_Ly_Do As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Xu_Ly_Lay_Boi_Ten_Ly_Do", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Ly_Do As SqlParameter = New SqlParameter("@Ten_Ly_Do", SqlDbType.NVarChar, 200)
                pTen_Ly_Do.Value = Ten_Ly_Do
                myCommand.Parameters.Add(pTen_Ly_Do)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Xu_Ly_Lay_Boi_Ten_Ly_Do")
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

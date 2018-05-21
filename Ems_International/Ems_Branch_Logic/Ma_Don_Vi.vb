
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Don_Vi_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Don_Vi_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Don_Vi trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Don_Vi_Chi_Tiet
        Public Ma_Don_Vi As String
        Public Ma_Tinh As Integer
        Public Ten_Don_Vi As String
    End Class
#End Region
#Region "Ma_Don_Vi"
    Public Class Ma_Don_Vi
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Don_Vi
        ' Input: Ma_Don_Vi
        ' Output: Ma_Don_Vi_Chi_Tiet
        Public Function Lay(ByVal Ma_Don_Vi As String) As Ma_Don_Vi_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Don_Vi As SqlParameter = New SqlParameter("@Ten_Don_Vi", SqlDbType.VarChar, 50)
                pTen_Don_Vi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Don_Vi)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myMa_Don_Vi_Chi_Tiet As Ma_Don_Vi_Chi_Tiet = New Ma_Don_Vi_Chi_Tiet
                myMa_Don_Vi_Chi_Tiet.Ma_Don_Vi = Ma_Don_Vi
                myMa_Don_Vi_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myMa_Don_Vi_Chi_Tiet.Ten_Don_Vi = pTen_Don_Vi.Value
                Return myMa_Don_Vi_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Don_Vi
        ' Input:  Ma_Tinh, Ten_Don_Vi,
        ' Output: 
        Public Sub Them(ByVal Ma_Tinh As Integer, ByVal Ten_Don_Vi As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Don_Vi As SqlParameter = New SqlParameter("@Ten_Don_Vi", SqlDbType.VarChar, 50)
                pTen_Don_Vi.Value = Ten_Don_Vi
                myCommand.Parameters.Add(pTen_Don_Vi)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Don_Vi
        ' Input: Ma_Don_Vi,  Ma_Tinh , Ten_Don_Vi ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Don_Vi As String, ByVal Ma_Tinh As Integer, ByVal Ten_Don_Vi As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Don_Vi As SqlParameter = New SqlParameter("@Ten_Don_Vi", SqlDbType.VarChar, 50)
                pTen_Don_Vi.Value = Ten_Don_Vi
                myCommand.Parameters.Add(pTen_Don_Vi)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Don_Vi
        ' Input: đối tượng thuộc lớp Ma_Don_Vi_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Don_Vi_Chi_Tiet As Ma_Don_Vi_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = myMa_Don_Vi_Chi_Tiet.Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myMa_Don_Vi_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Don_Vi As SqlParameter = New SqlParameter("@Ten_Don_Vi", SqlDbType.VarChar, 50)
                pTen_Don_Vi.Value = myMa_Don_Vi_Chi_Tiet.Ten_Don_Vi
                myCommand.Parameters.Add(pTen_Don_Vi)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Don_Vi
        ' Input: Ma_Don_Vi,  Ma_Tinh , Ten_Don_Vi ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Don_Vi As String, ByVal Ma_Tinh As Integer, ByVal Ten_Don_Vi As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Don_Vi As SqlParameter = New SqlParameter("@Ten_Don_Vi", SqlDbType.VarChar, 50)
                pTen_Don_Vi.Value = Ten_Don_Vi
                myCommand.Parameters.Add(pTen_Don_Vi)


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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Don_Vi
        ' Input: Ma_Don_Vi
        ' Output: 
        Public Sub Xoa(ByVal Ma_Don_Vi As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Don_Vi As SqlParameter = New SqlParameter("@Ma_Don_Vi", SqlDbType.VarChar, 3)
                pMa_Don_Vi.Value = Ma_Don_Vi
                myCommand.Parameters.Add(pMa_Don_Vi)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Don_Vi
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Don_Vi_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_Tinh"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Tinh thông qua khóa chính 
        ' Input: Ma_Tinh
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Tinh(ByVal Ma_Tinh As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Don_Vi_Lay_Boi_Ma_Tinh", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Don_Vi_Lay_Boi_Ma_Tinh")
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

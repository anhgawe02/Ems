
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Danh_Muc_Quan_Ly_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Danh_Muc_Quan_Ly_Chi_Tiet
    ' tương ứng với mộ trường của bảng Danh_Muc_Quan_Ly trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Danh_Muc_Quan_Ly_Chi_Tiet
        Public Ma_Quan_Ly As String ' Mã đơn vị quản lý (04-CPN, 46-Nghệ An,...)
        Public Ten_Quan_Ly As String ' Tên đơn vị quản lý
    End Class
#End Region
#Region "Danh_Muc_Quan_Ly"
    Public Class Danh_Muc_Quan_Ly
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Danh_Muc_Quan_Ly
        ' Input: Ma_Quan_Ly
        ' Output: Danh_Muc_Quan_Ly_Chi_Tiet
        Public Function Lay(ByVal Ma_Quan_Ly As String) As Danh_Muc_Quan_Ly_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pTen_Quan_Ly As SqlParameter = New SqlParameter("@Ten_Quan_Ly", SqlDbType.NVarChar, 200)
                pTen_Quan_Ly.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Quan_Ly)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myDanh_Muc_Quan_Ly_Chi_Tiet As Danh_Muc_Quan_Ly_Chi_Tiet = New Danh_Muc_Quan_Ly_Chi_Tiet
                myDanh_Muc_Quan_Ly_Chi_Tiet.Ma_Quan_Ly = Ma_Quan_Ly
                myDanh_Muc_Quan_Ly_Chi_Tiet.Ten_Quan_Ly = pTen_Quan_Ly.Value
                Return myDanh_Muc_Quan_Ly_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Danh_Muc_Quan_Ly
        ' Input:  Ten_Quan_Ly,
        ' Output: 
        Public Sub Them(ByVal Ten_Quan_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Quan_Ly As SqlParameter = New SqlParameter("@Ten_Quan_Ly", SqlDbType.NVarChar, 200)
                pTen_Quan_Ly.Value = Ten_Quan_Ly
                myCommand.Parameters.Add(pTen_Quan_Ly)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_Quan_Ly
        ' Input: Ma_Quan_Ly,  Ten_Quan_Ly ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Quan_Ly As String, ByVal Ten_Quan_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pTen_Quan_Ly As SqlParameter = New SqlParameter("@Ten_Quan_Ly", SqlDbType.NVarChar, 200)
                pTen_Quan_Ly.Value = Ten_Quan_Ly
                myCommand.Parameters.Add(pTen_Quan_Ly)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Danh_Muc_Quan_Ly
        ' Input: đối tượng thuộc lớp Danh_Muc_Quan_Ly_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myDanh_Muc_Quan_Ly_Chi_Tiet As Danh_Muc_Quan_Ly_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = myDanh_Muc_Quan_Ly_Chi_Tiet.Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pTen_Quan_Ly As SqlParameter = New SqlParameter("@Ten_Quan_Ly", SqlDbType.NVarChar, 200)
                pTen_Quan_Ly.Value = myDanh_Muc_Quan_Ly_Chi_Tiet.Ten_Quan_Ly
                myCommand.Parameters.Add(pTen_Quan_Ly)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Danh_Muc_Quan_Ly
        ' Input: Ma_Quan_Ly,  Ten_Quan_Ly ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Quan_Ly As String, ByVal Ten_Quan_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

                Dim pTen_Quan_Ly As SqlParameter = New SqlParameter("@Ten_Quan_Ly", SqlDbType.NVarChar, 200)
                pTen_Quan_Ly.Value = Ten_Quan_Ly
                myCommand.Parameters.Add(pTen_Quan_Ly)


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
        ' Nội dung: Xóa dữ liệu từ bảng Danh_Muc_Quan_Ly
        ' Input: Ma_Quan_Ly
        ' Output: 
        Public Sub Xoa(ByVal Ma_Quan_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quan_Ly As SqlParameter = New SqlParameter("@Ma_Quan_Ly", SqlDbType.VarChar, 2)
                pMa_Quan_Ly.Value = Ma_Quan_Ly
                myCommand.Parameters.Add(pMa_Quan_Ly)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Muc_Quan_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Danh_Muc_Quan_Ly_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Danh_Muc_Quan_Ly_Danh_Sach")
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

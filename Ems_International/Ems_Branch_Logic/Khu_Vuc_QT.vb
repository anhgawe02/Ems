
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Khu_Vuc_QT_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Khu_Vuc_QT_Chi_Tiet
    ' tương ứng với mộ trường của bảng Khu_Vuc_QT trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Khu_Vuc_QT_Chi_Tiet
        Public Ma_Khu_Vuc As String
        Public Ten_Khu_Vuc As String
    End Class
#End Region
#Region "Khu_Vuc_QT"
    Public Class Khu_Vuc_QT
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Khu_Vuc_QT
        ' Input: Ma_Khu_Vuc
        ' Output: Khu_Vuc_QT_Chi_Tiet
        Public Function Lay(ByVal Ma_Khu_Vuc As String) As Khu_Vuc_QT_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                Dim pTen_Khu_Vuc As SqlParameter = New SqlParameter("@Ten_Khu_Vuc", SqlDbType.NVarChar, 50)
                pTen_Khu_Vuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Khu_Vuc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myKhu_Vuc_QT_Chi_Tiet As Khu_Vuc_QT_Chi_Tiet = New Khu_Vuc_QT_Chi_Tiet
                myKhu_Vuc_QT_Chi_Tiet.Ma_Khu_Vuc = Ma_Khu_Vuc
                myKhu_Vuc_QT_Chi_Tiet.Ten_Khu_Vuc = pTen_Khu_Vuc.Value
                Return myKhu_Vuc_QT_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Khu_Vuc_QT
        ' Input:  Ten_Khu_Vuc,
        ' Output: 
        Public Sub Them(ByVal Ten_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Khu_Vuc As SqlParameter = New SqlParameter("@Ten_Khu_Vuc", SqlDbType.NVarChar, 50)
                pTen_Khu_Vuc.Value = Ten_Khu_Vuc
                myCommand.Parameters.Add(pTen_Khu_Vuc)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khu_Vuc_QT
        ' Input: Ma_Khu_Vuc,  Ten_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Khu_Vuc As String, ByVal Ten_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                Dim pTen_Khu_Vuc As SqlParameter = New SqlParameter("@Ten_Khu_Vuc", SqlDbType.NVarChar, 50)
                pTen_Khu_Vuc.Value = Ten_Khu_Vuc
                myCommand.Parameters.Add(pTen_Khu_Vuc)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khu_Vuc_QT
        ' Input: đối tượng thuộc lớp Khu_Vuc_QT_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myKhu_Vuc_QT_Chi_Tiet As Khu_Vuc_QT_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = myKhu_Vuc_QT_Chi_Tiet.Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                Dim pTen_Khu_Vuc As SqlParameter = New SqlParameter("@Ten_Khu_Vuc", SqlDbType.NVarChar, 50)
                pTen_Khu_Vuc.Value = myKhu_Vuc_QT_Chi_Tiet.Ten_Khu_Vuc
                myCommand.Parameters.Add(pTen_Khu_Vuc)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Khu_Vuc_QT
        ' Input: Ma_Khu_Vuc,  Ten_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Khu_Vuc As String, ByVal Ten_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                Dim pTen_Khu_Vuc As SqlParameter = New SqlParameter("@Ten_Khu_Vuc", SqlDbType.NVarChar, 50)
                pTen_Khu_Vuc.Value = Ten_Khu_Vuc
                myCommand.Parameters.Add(pTen_Khu_Vuc)


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
        ' Nội dung: Xóa dữ liệu từ bảng Khu_Vuc_QT
        ' Input: Ma_Khu_Vuc
        ' Output: 
        Public Sub Xoa(ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khu_Vuc_QT
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_QT_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khu_Vuc_QT
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_QT_Danh_Sach_Hien_Thi")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiem tra xem co Row hay ko"
        ' Ngày tạo: 25/6/08
        ' Người tạo: Quang Do
        ' Nội dung: Kiem tra xem ma khu vuc nay co' ton tai trong bang Khu_vuc_QT ko?
        ' Input: Khu_Vuc_QT
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Kiem_Tra_Row(ByVal Ma_Khu_Vuc As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khu_Vuc_QT_Kiem_Tra_Row", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khu_Vuc_QT_Kiem_Tra_Row")
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

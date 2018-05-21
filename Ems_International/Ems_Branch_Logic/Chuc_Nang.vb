
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Chuc_Nang_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Chuc_Nang_Chi_Tiet
    ' tương ứng với mộ trường của bảng Chuc_Nang trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Chuc_Nang_Chi_Tiet
        Public Id_Chuc_Nang As String
        Public Ten_Chuc_Nang As String
        Public Nhom_Chuc_Nang As String
    End Class
#End Region
#Region "Chuc_Nang"
    Public Class Chuc_Nang
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Chuc_Nang
        ' Input: Id_Chuc_Nang
        ' Output: Chuc_Nang_Chi_Tiet
        Public Function Lay(ByVal Id_Chuc_Nang As String) As Chuc_Nang_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pTen_Chuc_Nang As SqlParameter = New SqlParameter("@Ten_Chuc_Nang", SqlDbType.NVarChar, 200)
                pTen_Chuc_Nang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Chuc_Nang)

                Dim pNhom_Chuc_Nang As SqlParameter = New SqlParameter("@Nhom_Chuc_Nang", SqlDbType.NVarChar, 200)
                pNhom_Chuc_Nang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNhom_Chuc_Nang)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myChuc_Nang_Chi_Tiet As Chuc_Nang_Chi_Tiet = New Chuc_Nang_Chi_Tiet
                myChuc_Nang_Chi_Tiet.Id_Chuc_Nang = Id_Chuc_Nang
                myChuc_Nang_Chi_Tiet.Ten_Chuc_Nang = pTen_Chuc_Nang.Value
                myChuc_Nang_Chi_Tiet.Nhom_Chuc_Nang = pNhom_Chuc_Nang.Value
                Return myChuc_Nang_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Chuc_Nang
        ' Input:  Ten_Chuc_Nang, Nhom_Chuc_Nang,
        ' Output: 
        Public Sub Them(ByVal Ten_Chuc_Nang As String, ByVal Nhom_Chuc_Nang As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Chuc_Nang As SqlParameter = New SqlParameter("@Ten_Chuc_Nang", SqlDbType.NVarChar, 200)
                pTen_Chuc_Nang.Value = Ten_Chuc_Nang
                myCommand.Parameters.Add(pTen_Chuc_Nang)

                Dim pNhom_Chuc_Nang As SqlParameter = New SqlParameter("@Nhom_Chuc_Nang", SqlDbType.NVarChar, 200)
                pNhom_Chuc_Nang.Value = Nhom_Chuc_Nang
                myCommand.Parameters.Add(pNhom_Chuc_Nang)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuc_Nang
        ' Input: Id_Chuc_Nang,  Ten_Chuc_Nang , Nhom_Chuc_Nang ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Chuc_Nang As String, ByVal Ten_Chuc_Nang As String, ByVal Nhom_Chuc_Nang As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pTen_Chuc_Nang As SqlParameter = New SqlParameter("@Ten_Chuc_Nang", SqlDbType.NVarChar, 200)
                pTen_Chuc_Nang.Value = Ten_Chuc_Nang
                myCommand.Parameters.Add(pTen_Chuc_Nang)

                Dim pNhom_Chuc_Nang As SqlParameter = New SqlParameter("@Nhom_Chuc_Nang", SqlDbType.NVarChar, 200)
                pNhom_Chuc_Nang.Value = Nhom_Chuc_Nang
                myCommand.Parameters.Add(pNhom_Chuc_Nang)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Chuc_Nang
        ' Input: đối tượng thuộc lớp Chuc_Nang_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myChuc_Nang_Chi_Tiet As Chuc_Nang_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = myChuc_Nang_Chi_Tiet.Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pTen_Chuc_Nang As SqlParameter = New SqlParameter("@Ten_Chuc_Nang", SqlDbType.NVarChar, 200)
                pTen_Chuc_Nang.Value = myChuc_Nang_Chi_Tiet.Ten_Chuc_Nang
                myCommand.Parameters.Add(pTen_Chuc_Nang)

                Dim pNhom_Chuc_Nang As SqlParameter = New SqlParameter("@Nhom_Chuc_Nang", SqlDbType.NVarChar, 200)
                pNhom_Chuc_Nang.Value = myChuc_Nang_Chi_Tiet.Nhom_Chuc_Nang
                myCommand.Parameters.Add(pNhom_Chuc_Nang)


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
        ' Nội dung: Xóa dữ liệu từ bảng Chuc_Nang
        ' Input: Id_Chuc_Nang
        ' Output: 
        Public Sub Xoa(ByVal Id_Chuc_Nang As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Chuc_Nang
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuc_Nang_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Chuc_Nang_Danh_Sach")
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

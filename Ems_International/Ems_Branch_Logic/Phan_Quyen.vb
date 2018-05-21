
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Phan_Quyen_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Phan_Quyen_Chi_Tiet
    ' tương ứng với mộ trường của bảng Phan_Quyen trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Phan_Quyen_Chi_Tiet
        Public Id_Phan_Quyen As Integer
        Public Id_Nguoi_Dung As Integer
        Public Id_Chuc_Nang As String
        Public Su_Dung As Boolean ' 0: không được sử dụng; 1: được sử dụng
    End Class
#End Region
#Region "Phan_Quyen"
    Public Class Phan_Quyen
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Phan_Quyen
        ' Input: Id_Phan_Quyen
        ' Output: Phan_Quyen_Chi_Tiet
        Public Function Lay(ByVal Id_Phan_Quyen As Integer) As Phan_Quyen_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Phan_Quyen As SqlParameter = New SqlParameter("@Id_Phan_Quyen", SqlDbType.Int, 4)
                pId_Phan_Quyen.Value = Id_Phan_Quyen
                myCommand.Parameters.Add(pId_Phan_Quyen)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myPhan_Quyen_Chi_Tiet As Phan_Quyen_Chi_Tiet = New Phan_Quyen_Chi_Tiet
                myPhan_Quyen_Chi_Tiet.Id_Phan_Quyen = Id_Phan_Quyen
                myPhan_Quyen_Chi_Tiet.Id_Nguoi_Dung = pId_Nguoi_Dung.Value
                myPhan_Quyen_Chi_Tiet.Id_Chuc_Nang = pId_Chuc_Nang.Value
                myPhan_Quyen_Chi_Tiet.Su_Dung = pSu_Dung.Value
                Return myPhan_Quyen_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Phan_Quyen
        ' Input:  Id_Nguoi_Dung, Id_Chuc_Nang, Su_Dung,
        ' Output: 
        Public Sub Them(ByVal Id_Nguoi_Dung As Integer, ByVal Id_Chuc_Nang As String, ByVal Su_Dung As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Phan_Quyen
        ' Input: Id_Phan_Quyen,  Id_Nguoi_Dung , Id_Chuc_Nang , Su_Dung ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Phan_Quyen As Integer, ByVal Id_Nguoi_Dung As Integer, ByVal Id_Chuc_Nang As String, ByVal Su_Dung As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Quyen As SqlParameter = New SqlParameter("@Id_Phan_Quyen", SqlDbType.Int, 4)
                pId_Phan_Quyen.Value = Id_Phan_Quyen
                myCommand.Parameters.Add(pId_Phan_Quyen)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Phan_Quyen
        ' Input: đối tượng thuộc lớp Phan_Quyen_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myPhan_Quyen_Chi_Tiet As Phan_Quyen_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Phan_Quyen As SqlParameter = New SqlParameter("@Id_Phan_Quyen", SqlDbType.Int, 4)
                pId_Phan_Quyen.Value = myPhan_Quyen_Chi_Tiet.Id_Phan_Quyen
                myCommand.Parameters.Add(pId_Phan_Quyen)

                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = myPhan_Quyen_Chi_Tiet.Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = myPhan_Quyen_Chi_Tiet.Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = myPhan_Quyen_Chi_Tiet.Su_Dung
                myCommand.Parameters.Add(pSu_Dung)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Boi_Nguoi_Dung_Va_Chuc_Nang"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Phan_Quyen
        ' Input: Id_Phan_Quyen,  Id_Nguoi_Dung , Id_Chuc_Nang , Su_Dung ,
        ' Output: 
        Public Sub Cap_Nhat_Boi_Nguoi_Dung_Va_Chuc_Nang(ByVal Ten_Dang_Nhap As String, ByVal Id_Chuc_Nang As String, ByVal Su_Dung As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Cap_Nhat_Boi_Nguoi_Dung_Va_Chuc_Nang", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục               

                Dim pTen_Dang_Nhap As SqlParameter = New SqlParameter("@Ten_Dang_Nhap", SqlDbType.VarChar, 50)
                pTen_Dang_Nhap.Value = Ten_Dang_Nhap
                myCommand.Parameters.Add(pTen_Dang_Nhap)

                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)


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
        ' Nội dung: Xóa dữ liệu từ bảng Phan_Quyen
        ' Input: Id_Phan_Quyen
        ' Output: 
        Public Sub Xoa(ByVal Id_Phan_Quyen As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Quyen As SqlParameter = New SqlParameter("@Id_Phan_Quyen", SqlDbType.Int, 4)
                pId_Phan_Quyen.Value = Id_Phan_Quyen
                myCommand.Parameters.Add(pId_Phan_Quyen)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Phan_Quyen
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Phan_Quyen_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Nguoi_Dung"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Nguoi_Dung thông qua khóa chính 
        ' Input: Id_Nguoi_Dung
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Nguoi_Dung(ByVal Id_Nguoi_Dung As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Lay_Boi_Nguoi_Dung", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Phan_Quyen_Lay_Boi_Nguoi_Dung")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Chuc_Nang"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Chuc_Nang thông qua khóa chính 
        ' Input: Id_Chuc_Nang
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Chuc_Nang(ByVal Id_Chuc_Nang As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Lay_Boi_Chuc_Nang", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuc_Nang As SqlParameter = New SqlParameter("@Id_Chuc_Nang", SqlDbType.VarChar, 6)
                pId_Chuc_Nang.Value = Id_Chuc_Nang
                myCommand.Parameters.Add(pId_Chuc_Nang)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Phan_Quyen_Lay_Boi_Chuc_Nang")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Cap_Nhat_Tat_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Phan_Quyen
        ' Input: Id_Phan_Quyen,  Id_Nguoi_Dung , Id_Chuc_Nang , Su_Dung ,
        ' Output: 
        Public Sub Cap_Nhat_Tat_Ca(ByVal Id_Nguoi_Dung As Integer, ByVal Su_Dung As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Phan_Quyen_Cap_Nhat_Tat_Ca", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Nguoi_Dung As SqlParameter = New SqlParameter("@Id_Nguoi_Dung", SqlDbType.Int, 4)
                pId_Nguoi_Dung.Value = Id_Nguoi_Dung
                myCommand.Parameters.Add(pId_Nguoi_Dung)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region

    End Class
#End Region
End Namespace

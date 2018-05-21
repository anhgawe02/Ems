
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Nuoc_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Nuoc_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Nuoc trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Nuoc_Chi_Tiet
        Public Ma_Nuoc As String
        Public Ten_Nuoc As String ' Tên nước
        Public Ma_Khu_Vuc As String
    End Class
#End Region
#Region "Ma_Nuoc"
    Public Class Ma_Nuoc
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: Ma_Nuoc_Chi_Tiet
        Public Function Lay(ByVal Ma_Nuoc As String) As Ma_Nuoc_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Khu_Vuc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myMa_Nuoc_Chi_Tiet As Ma_Nuoc_Chi_Tiet = New Ma_Nuoc_Chi_Tiet
                myMa_Nuoc_Chi_Tiet.Ma_Nuoc = Ma_Nuoc
                myMa_Nuoc_Chi_Tiet.Ten_Nuoc = pTen_Nuoc.Value
                myMa_Nuoc_Chi_Tiet.Ma_Khu_Vuc = pMa_Khu_Vuc.Value
                Return myMa_Nuoc_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Nuoc
        ' Input:  Ten_Nuoc, Ma_Khu_Vuc,
        ' Output: 
        Public Sub Them(ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                myCommand.Parameters.Add(pTen_Nuoc)

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
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Nuoc
        ' Input: Ma_Nuoc,  Ten_Nuoc , Ma_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                myCommand.Parameters.Add(pTen_Nuoc)

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
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Nuoc
        ' Input: đối tượng thuộc lớp Ma_Nuoc_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Nuoc_Chi_Tiet As Ma_Nuoc_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = myMa_Nuoc_Chi_Tiet.Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = myMa_Nuoc_Chi_Tiet.Ten_Nuoc
                myCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = myMa_Nuoc_Chi_Tiet.Ma_Khu_Vuc
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
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Nuoc
        ' Input: Ma_Nuoc,  Ten_Nuoc , Ma_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = Ten_Nuoc
                myCommand.Parameters.Add(pTen_Nuoc)

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
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: 
        Public Sub Xoa(ByVal Ma_Nuoc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Xoa_Tat_Ca", myConnection)

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
#Region "Kiem tra Ma_Nuoc"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_Nuoc(ByVal Ma_Nuoc As String) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Kiem_Tra_Ton_Tai", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pSo_Dong As SqlParameter = New SqlParameter("@So_Dong", SqlDbType.Int, 10)
                pSo_Dong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Dong)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return IIf(pSo_Dong.Value = 0, False, True)
            Catch ex As Exception
                Console.Write(ex.ToString)
                Return False
            End Try
        End Function
#End Region
#Region "Lay_Tat_Ca_Tu_Tmp"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Nuoc
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Nuoc_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Nuoc
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Rut_Gon() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Danh_Sach_Rut_Gon", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Nuoc_Danh_Sach_Rut_Gon")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon_KT"
        Public Function Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_KT(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Nuoc_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon_Den_KT"
        Public Function Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_Den_KT(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Nuoc_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_Den_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Nuoc_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_Den_KT")
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


Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Ma_Nuoc_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Ma_Nuoc_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Ma_Nuoc trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Ma_Nuoc_Chi_Tiet
        Public Ma_Nuoc As String
        Public Ten_Nuoc As String
        Public Ma_Khu_Vuc As String
    End Class
#End Region
#Region "Tmp_Ma_Nuoc"
    Public Class Tmp_Ma_Nuoc
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: Tmp_Ma_Nuoc_Chi_Tiet
        Public Function Lay(ByVal Ma_Nuoc As String) As Tmp_Ma_Nuoc_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Lay", myConnection)

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
                Dim myTmp_Ma_Nuoc_Chi_Tiet As Tmp_Ma_Nuoc_Chi_Tiet = New Tmp_Ma_Nuoc_Chi_Tiet
                myTmp_Ma_Nuoc_Chi_Tiet.Ma_Nuoc = Ma_Nuoc
                myTmp_Ma_Nuoc_Chi_Tiet.Ten_Nuoc = pTen_Nuoc.Value
                myTmp_Ma_Nuoc_Chi_Tiet.Ma_Khu_Vuc = pMa_Khu_Vuc.Value
                Return myTmp_Ma_Nuoc_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Ma_Nuoc
        ' Input:  Ten_Nuoc, Ma_Khu_Vuc,
        ' Output: 
        Public Sub Them(ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ma_Nuoc
        ' Input: Ma_Nuoc,  Ten_Nuoc , Ma_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Cap_Nhat", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ma_Nuoc
        ' Input: đối tượng thuộc lớp Tmp_Ma_Nuoc_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Ma_Nuoc_Chi_Tiet As Tmp_Ma_Nuoc_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = myTmp_Ma_Nuoc_Chi_Tiet.Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pTen_Nuoc As SqlParameter = New SqlParameter("@Ten_Nuoc", SqlDbType.NVarChar, 100)
                pTen_Nuoc.Value = myTmp_Ma_Nuoc_Chi_Tiet.Ten_Nuoc
                myCommand.Parameters.Add(pTen_Nuoc)

                Dim pMa_Khu_Vuc As SqlParameter = New SqlParameter("@Ma_Khu_Vuc", SqlDbType.VarChar, 10)
                pMa_Khu_Vuc.Value = myTmp_Ma_Nuoc_Chi_Tiet.Ma_Khu_Vuc
                myCommand.Parameters.Add(pMa_Khu_Vuc)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Ma_Nuoc
        ' Input: Ma_Nuoc,  Ten_Nuoc , Ma_Khu_Vuc ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Nuoc As String, ByVal Ten_Nuoc As String, ByVal Ma_Khu_Vuc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Cap_Nhat_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Ma_Nuoc
        ' Input: Ma_Nuoc
        ' Output: 
        Public Sub Xoa(ByVal Ma_Nuoc As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Ma_Nuoc
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Nuoc_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Ma_Nuoc_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region


    End Class
#End Region
End Namespace
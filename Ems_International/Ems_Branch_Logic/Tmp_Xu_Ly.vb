
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Xu_Ly_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Xu_Ly_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Xu_Ly trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Xu_Ly_Chi_Tiet
        Public Ma_Xu_Ly As String
        Public Ten_Xu_Ly As String
        Public Ten_Xu_Ly_EN As String
    End Class
#End Region
#Region "Tmp_Xu_Ly"
    Public Class Tmp_Xu_Ly
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Xu_Ly
        ' Input: Ma_Xu_Ly
        ' Output: Tmp_Xu_Ly_Chi_Tiet
        Public Function Lay(ByVal Ma_Xu_Ly As String) As Tmp_Xu_Ly_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Lay", myConnection)

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
                Dim myTmp_Xu_Ly_Chi_Tiet As Tmp_Xu_Ly_Chi_Tiet = New Tmp_Xu_Ly_Chi_Tiet
                myTmp_Xu_Ly_Chi_Tiet.Ma_Xu_Ly = Ma_Xu_Ly
                myTmp_Xu_Ly_Chi_Tiet.Ten_Xu_Ly = pTen_Xu_Ly.Value
                myTmp_Xu_Ly_Chi_Tiet.Ten_Xu_Ly_EN = pTen_Xu_Ly_EN.Value
                Return myTmp_Xu_Ly_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Xu_Ly
        ' Input:  Ten_Xu_Ly, Ten_Xu_Ly_EN,
        ' Output: 
        Public Sub Them(ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Xu_Ly
        ' Input: Ma_Xu_Ly,  Ten_Xu_Ly , Ten_Xu_Ly_EN ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Xu_Ly As String, ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Cap_Nhat", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Xu_Ly
        ' Input: đối tượng thuộc lớp Tmp_Xu_Ly_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Xu_Ly_Chi_Tiet As Tmp_Xu_Ly_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = myTmp_Xu_Ly_Chi_Tiet.Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

                Dim pTen_Xu_Ly As SqlParameter = New SqlParameter("@Ten_Xu_Ly", SqlDbType.NVarChar, 200)
                pTen_Xu_Ly.Value = myTmp_Xu_Ly_Chi_Tiet.Ten_Xu_Ly
                myCommand.Parameters.Add(pTen_Xu_Ly)

                Dim pTen_Xu_Ly_EN As SqlParameter = New SqlParameter("@Ten_Xu_Ly_EN", SqlDbType.VarChar, 200)
                pTen_Xu_Ly_EN.Value = myTmp_Xu_Ly_Chi_Tiet.Ten_Xu_Ly_EN
                myCommand.Parameters.Add(pTen_Xu_Ly_EN)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Xu_Ly
        ' Input: Ma_Xu_Ly,  Ten_Xu_Ly , Ten_Xu_Ly_EN ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Xu_Ly As String, ByVal Ten_Xu_Ly As String, ByVal Ten_Xu_Ly_EN As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Cap_Nhat_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Xu_Ly
        ' Input: Ma_Xu_Ly
        ' Output: 
        Public Sub Xoa(ByVal Ma_Xu_Ly As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Xu_Ly As SqlParameter = New SqlParameter("@Ma_Xu_Ly", SqlDbType.VarChar, 1)
                pMa_Xu_Ly.Value = Ma_Xu_Ly
                myCommand.Parameters.Add(pMa_Xu_Ly)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Xu_Ly
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Xu_Ly_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Xu_Ly_Danh_Sach")
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
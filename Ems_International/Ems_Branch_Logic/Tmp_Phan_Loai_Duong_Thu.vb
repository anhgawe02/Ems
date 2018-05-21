
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Phan_Loai_Duong_Thu_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Phan_Loai_Duong_Thu trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
        Public Id_Phan_Loai As Integer
        Public Ten_Phan_Loai As String
        Public Phan_loai As Integer
    End Class
#End Region
#Region "Tmp_Phan_Loai_Duong_Thu"
    Public Class Tmp_Phan_Loai_Duong_Thu
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: Id_Phan_Loai
        ' Output: Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
        Public Function Lay(ByVal Id_Phan_Loai As Integer) As Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTen_Phan_Loai As SqlParameter = New SqlParameter("@Ten_Phan_Loai", SqlDbType.NVarChar, 50)
                pTen_Phan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Phan_Loai)

                Dim pPhan_loai As SqlParameter = New SqlParameter("@Phan_loai", SqlDbType.Int, 4)
                pPhan_loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_loai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTmp_Phan_Loai_Duong_Thu_Chi_Tiet As Tmp_Phan_Loai_Duong_Thu_Chi_Tiet = New Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
                myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Id_Phan_Loai = Id_Phan_Loai
                myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Ten_Phan_Loai = pTen_Phan_Loai.Value
                myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Phan_loai = pPhan_loai.Value
                Return myTmp_Phan_Loai_Duong_Thu_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Phan_Loai_Duong_Thu
        ' Input:  Ten_Phan_Loai, Phan_loai,
        ' Output: 
        Public Sub Them(ByVal Ten_Phan_Loai As String, ByVal Phan_loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Phan_Loai As SqlParameter = New SqlParameter("@Ten_Phan_Loai", SqlDbType.NVarChar, 50)
                pTen_Phan_Loai.Value = Ten_Phan_Loai
                myCommand.Parameters.Add(pTen_Phan_Loai)

                Dim pPhan_loai As SqlParameter = New SqlParameter("@Phan_loai", SqlDbType.Int, 4)
                pPhan_loai.Value = Phan_loai
                myCommand.Parameters.Add(pPhan_loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: Id_Phan_Loai,  Ten_Phan_Loai , Phan_loai ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Phan_Loai As Integer, ByVal Ten_Phan_Loai As String, ByVal Phan_loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTen_Phan_Loai As SqlParameter = New SqlParameter("@Ten_Phan_Loai", SqlDbType.NVarChar, 50)
                pTen_Phan_Loai.Value = Ten_Phan_Loai
                myCommand.Parameters.Add(pTen_Phan_Loai)

                Dim pPhan_loai As SqlParameter = New SqlParameter("@Phan_loai", SqlDbType.Int, 4)
                pPhan_loai.Value = Phan_loai
                myCommand.Parameters.Add(pPhan_loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: đối tượng thuộc lớp Tmp_Phan_Loai_Duong_Thu_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Phan_Loai_Duong_Thu_Chi_Tiet As Tmp_Phan_Loai_Duong_Thu_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTen_Phan_Loai As SqlParameter = New SqlParameter("@Ten_Phan_Loai", SqlDbType.NVarChar, 50)
                pTen_Phan_Loai.Value = myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Ten_Phan_Loai
                myCommand.Parameters.Add(pTen_Phan_Loai)

                Dim pPhan_loai As SqlParameter = New SqlParameter("@Phan_loai", SqlDbType.Int, 4)
                pPhan_loai.Value = myTmp_Phan_Loai_Duong_Thu_Chi_Tiet.Phan_loai
                myCommand.Parameters.Add(pPhan_loai)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: Id_Phan_Loai,  Ten_Phan_Loai , Phan_loai ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Phan_Loai As Integer, ByVal Ten_Phan_Loai As String, ByVal Phan_loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTen_Phan_Loai As SqlParameter = New SqlParameter("@Ten_Phan_Loai", SqlDbType.NVarChar, 50)
                pTen_Phan_Loai.Value = Ten_Phan_Loai
                myCommand.Parameters.Add(pTen_Phan_Loai)

                Dim pPhan_loai As SqlParameter = New SqlParameter("@Phan_loai", SqlDbType.Int, 4)
                pPhan_loai.Value = Phan_loai
                myCommand.Parameters.Add(pPhan_loai)


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
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: Id_Phan_Loai
        ' Output: 
        Public Sub Xoa(ByVal Id_Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Phan_Loai_Duong_Thu
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Phan_Loai_Duong_Thu_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Phan_Loai_Duong_Thu_Danh_Sach")
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
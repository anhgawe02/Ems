
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Dich_Vu_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Dich_Vu_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Dich_Vu trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Dich_Vu_Chi_Tiet
        Public Ma_Dich_Vu As String
        Public Ten_Dich_Vu As String
        Public Phan_Loai As Integer
    End Class
#End Region
#Region "Tmp_Dich_Vu"
    Public Class Tmp_Dich_Vu
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Dich_Vu
        ' Input: Ma_Dich_Vu
        ' Output: Tmp_Dich_Vu_Chi_Tiet
        Public Function Lay(ByVal Ma_Dich_Vu As String) As Tmp_Dich_Vu_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTmp_Dich_Vu_Chi_Tiet As Tmp_Dich_Vu_Chi_Tiet = New Tmp_Dich_Vu_Chi_Tiet
                myTmp_Dich_Vu_Chi_Tiet.Ma_Dich_Vu = Ma_Dich_Vu
                myTmp_Dich_Vu_Chi_Tiet.Ten_Dich_Vu = pTen_Dich_Vu.Value
                myTmp_Dich_Vu_Chi_Tiet.Phan_Loai = pPhan_Loai.Value
                Return myTmp_Dich_Vu_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Dich_Vu
        ' Input:  Ten_Dich_Vu, Phan_Loai,
        ' Output: 
        Public Sub Them(ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Dich_Vu
        ' Input: Ma_Dich_Vu,  Ten_Dich_Vu , Phan_Loai ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Dich_Vu As String, ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Dich_Vu
        ' Input: đối tượng thuộc lớp Tmp_Dich_Vu_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Dich_Vu_Chi_Tiet As Tmp_Dich_Vu_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = myTmp_Dich_Vu_Chi_Tiet.Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = myTmp_Dich_Vu_Chi_Tiet.Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = myTmp_Dich_Vu_Chi_Tiet.Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Dich_Vu
        ' Input: Ma_Dich_Vu,  Ten_Dich_Vu , Phan_Loai ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Dich_Vu As String, ByVal Ten_Dich_Vu As String, ByVal Phan_Loai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pTen_Dich_Vu As SqlParameter = New SqlParameter("@Ten_Dich_Vu", SqlDbType.NVarChar, 100)
                pTen_Dich_Vu.Value = Ten_Dich_Vu
                myCommand.Parameters.Add(pTen_Dich_Vu)

                Dim pPhan_Loai As SqlParameter = New SqlParameter("@Phan_Loai", SqlDbType.Int, 4)
                pPhan_Loai.Value = Phan_Loai
                myCommand.Parameters.Add(pPhan_Loai)


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
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Dich_Vu
        ' Input: Ma_Dich_Vu
        ' Output: 
        Public Sub Xoa(ByVal Ma_Dich_Vu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Dich_Vu
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Dich_Vu_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Dich_Vu_Danh_Sach")
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
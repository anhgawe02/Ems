
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Quay_Giao_Dich_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Quay_Giao_Dich_Chi_Tiet
    ' tương ứng với mộ trường của bảng Quay_Giao_Dich trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Quay_Giao_Dich_Chi_Tiet
        Public Ma_Quay As Integer ' Mã quầy giao dịch
        Public Ten_Quay As String ' Tên quầy giao dịch
        Public Dien_Thoai As String
    End Class
#End Region
#Region "Quay_Giao_Dich"
    Public Class Quay_Giao_Dich
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Quay_Giao_Dich
        ' Input: Ma_Quay
        ' Output: Quay_Giao_Dich_Chi_Tiet
        Public Function Lay(ByVal Ma_Quay As Integer) As Quay_Giao_Dich_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pTen_Quay As SqlParameter = New SqlParameter("@Ten_Quay", SqlDbType.NVarChar, 150)
                pTen_Quay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Quay)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myQuay_Giao_Dich_Chi_Tiet As Quay_Giao_Dich_Chi_Tiet = New Quay_Giao_Dich_Chi_Tiet
                myQuay_Giao_Dich_Chi_Tiet.Ma_Quay = Ma_Quay
                myQuay_Giao_Dich_Chi_Tiet.Ten_Quay = pTen_Quay.Value
                myQuay_Giao_Dich_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                Return myQuay_Giao_Dich_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Quay_Giao_Dich
        ' Input:  Ten_Quay, Dien_Thoai,
        ' Output: 
        Public Sub Them(ByVal Ten_Quay As String, ByVal Dien_Thoai As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Quay As SqlParameter = New SqlParameter("@Ten_Quay", SqlDbType.NVarChar, 150)
                pTen_Quay.Value = Ten_Quay
                myCommand.Parameters.Add(pTen_Quay)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Quay_Giao_Dich
        ' Input: Ma_Quay,  Ten_Quay , Dien_Thoai ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Quay As Integer, ByVal Ten_Quay As String, ByVal Dien_Thoai As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pTen_Quay As SqlParameter = New SqlParameter("@Ten_Quay", SqlDbType.NVarChar, 150)
                pTen_Quay.Value = Ten_Quay
                myCommand.Parameters.Add(pTen_Quay)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Quay_Giao_Dich
        ' Input: đối tượng thuộc lớp Quay_Giao_Dich_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myQuay_Giao_Dich_Chi_Tiet As Quay_Giao_Dich_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = myQuay_Giao_Dich_Chi_Tiet.Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pTen_Quay As SqlParameter = New SqlParameter("@Ten_Quay", SqlDbType.NVarChar, 150)
                pTen_Quay.Value = myQuay_Giao_Dich_Chi_Tiet.Ten_Quay
                myCommand.Parameters.Add(pTen_Quay)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = myQuay_Giao_Dich_Chi_Tiet.Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Quay_Giao_Dich
        ' Input: Ma_Quay,  Ten_Quay , Dien_Thoai ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Quay As Integer, ByVal Ten_Quay As String, ByVal Dien_Thoai As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

                Dim pTen_Quay As SqlParameter = New SqlParameter("@Ten_Quay", SqlDbType.NVarChar, 150)
                pTen_Quay.Value = Ten_Quay
                myCommand.Parameters.Add(pTen_Quay)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Kiem tra Ma_Quay"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_Quay(ByVal Ma_Quay As Integer) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from Quay_Giao_Dich where (Ma_Quay= " & Ma_Quay & ") ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Quay_Giao_Dich
        ' Input: Ma_Quay
        ' Output: 
        Public Sub Xoa(ByVal Ma_Quay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Quay As SqlParameter = New SqlParameter("@Ma_Quay", SqlDbType.Int, 4)
                pMa_Quay.Value = Ma_Quay
                myCommand.Parameters.Add(pMa_Quay)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Quay_Giao_Dich
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Quay_Giao_Dich_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Quay_Giao_Dich_Danh_Sach")
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

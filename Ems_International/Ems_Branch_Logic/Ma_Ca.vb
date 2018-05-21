
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Ca_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Ca_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Ca trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Ca_Chi_Tiet
        Public Ca_Khai_Thac As Integer ' Mã ca khai thác
        Public Ma_Bc_Khai_Thac As Integer ' Mã bưu cục khai thác
        Public Ca As String
        Public Thu_Tu As Integer ' Thứ tự ca
    End Class
#End Region
#Region "Ma_Ca"
    Public Class Ma_Ca
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Ca
        ' Input: Ca_Khai_Thac
        ' Output: Ma_Ca_Chi_Tiet
        Public Function Lay(ByVal Ca_Khai_Thac As Integer) As Ma_Ca_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pCa As SqlParameter = New SqlParameter("@Ca", SqlDbType.VarChar, 50)
                pCa.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThu_Tu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myMa_Ca_Chi_Tiet As Ma_Ca_Chi_Tiet = New Ma_Ca_Chi_Tiet
                myMa_Ca_Chi_Tiet.Ca_Khai_Thac = Ca_Khai_Thac
                myMa_Ca_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myMa_Ca_Chi_Tiet.Ca = pCa.Value
                myMa_Ca_Chi_Tiet.Thu_Tu = pThu_Tu.Value
                Return myMa_Ca_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Ca
        ' Input:  Ma_Bc_Khai_Thac, Ca, Thu_Tu,
        ' Output: 
        Public Sub Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ca As String, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pCa As SqlParameter = New SqlParameter("@Ca", SqlDbType.VarChar, 50)
                pCa.Value = Ca
                myCommand.Parameters.Add(pCa)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Ca
        ' Input: Ca_Khai_Thac,  Ma_Bc_Khai_Thac , Ca , Thu_Tu ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ca_Khai_Thac As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ca As String, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pCa As SqlParameter = New SqlParameter("@Ca", SqlDbType.VarChar, 50)
                pCa.Value = Ca
                myCommand.Parameters.Add(pCa)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Ca
        ' Input: đối tượng thuộc lớp Ma_Ca_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Ca_Chi_Tiet As Ma_Ca_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = myMa_Ca_Chi_Tiet.Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myMa_Ca_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pCa As SqlParameter = New SqlParameter("@Ca", SqlDbType.VarChar, 50)
                pCa.Value = myMa_Ca_Chi_Tiet.Ca
                myCommand.Parameters.Add(pCa)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = myMa_Ca_Chi_Tiet.Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Ca
        ' Input: Ca_Khai_Thac,  Ma_Bc_Khai_Thac , Ca , Thu_Tu ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ca As String, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                'Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                'pCa_Khai_Thac.Value = Ca_Khai_Thac
                'myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pCa As SqlParameter = New SqlParameter("@Ca", SqlDbType.VarChar, 50)
                pCa.Value = Ca
                myCommand.Parameters.Add(pCa)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)


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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Ca
        ' Input: Ca_Khai_Thac
        ' Output: 
        Public Sub Xoa(ByVal Ca_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Ca
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Parameter
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Ca_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Ca
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Ca_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Bc_Khai_Thac thông qua khóa chính 
        ' Input: Ma_Bc_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Ca_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Ca_Lay_Boi_Ma_Bc_Khai_Thac")
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

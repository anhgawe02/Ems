
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Bc_Khai_Thac_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Bc_Khai_Thac_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Bc_Khai_Thac trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Bc_Khai_Thac_Chi_Tiet
        Public Ma_Bc_Khai_Thac As Integer
        Public Ten_Bc_Khai_Thac As String
        Public OutBout As Integer
    End Class
#End Region
#Region "Ma_Bc_Khai_Thac"
    Public Class Ma_Bc_Khai_Thac
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Bc_Khai_Thac
        ' Input: Ma_Bc_Khai_Thac
        ' Output: Ma_Bc_Khai_Thac_Chi_Tiet
        Public Function Lay(ByVal Ma_Bc_Khai_Thac As Integer) As Ma_Bc_Khai_Thac_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ten_Bc_Khai_Thac", SqlDbType.NVarChar, 100)
                pTen_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Bc_Khai_Thac)

                Dim pOutBout As SqlParameter = New SqlParameter("@OutBout", SqlDbType.Int, 4)
                pOutBout.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pOutBout)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Dim myMa_Bc_Khai_Thac_Chi_Tiet As Ma_Bc_Khai_Thac_Chi_Tiet = New Ma_Bc_Khai_Thac_Chi_Tiet
                myMa_Bc_Khai_Thac_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myMa_Bc_Khai_Thac_Chi_Tiet.Ten_Bc_Khai_Thac = pTen_Bc_Khai_Thac.Value
                myMa_Bc_Khai_Thac_Chi_Tiet.OutBout = pOutBout.Value
                Return myMa_Bc_Khai_Thac_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Bc_Khai_Thac
        ' Input:  Ten_Bc_Khai_Thac,
        ' Output: 
        Public Sub Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Bc_Khai_Thac As String, ByVal OutBout As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ten_Bc_Khai_Thac", SqlDbType.NVarChar, 100)
                pTen_Bc_Khai_Thac.Value = Ten_Bc_Khai_Thac
                myCommand.Parameters.Add(pTen_Bc_Khai_Thac)

                Dim pOutBout As SqlParameter = New SqlParameter("@OutBout", SqlDbType.Int, 4)
                pOutBout.Value = OutBout
                myCommand.Parameters.Add(pOutBout)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Bc_Khai_Thac
        ' Input: Ma_Bc_Khai_Thac,  Ten_Bc_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Bc_Khai_Thac As String, ByVal OutBout As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ten_Bc_Khai_Thac", SqlDbType.NVarChar, 100)
                pTen_Bc_Khai_Thac.Value = Ten_Bc_Khai_Thac
                myCommand.Parameters.Add(pTen_Bc_Khai_Thac)

                Dim pOutBout As SqlParameter = New SqlParameter("@OutBout", SqlDbType.Int, 4)
                pOutBout.Value = OutBout
                myCommand.Parameters.Add(pOutBout)



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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Bc_Khai_Thac
        ' Input: đối tượng thuộc lớp Ma_Bc_Khai_Thac_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Bc_Khai_Thac_Chi_Tiet As Ma_Bc_Khai_Thac_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myMa_Bc_Khai_Thac_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ten_Bc_Khai_Thac", SqlDbType.NVarChar, 100)
                pTen_Bc_Khai_Thac.Value = myMa_Bc_Khai_Thac_Chi_Tiet.Ten_Bc_Khai_Thac
                myCommand.Parameters.Add(pTen_Bc_Khai_Thac)

                Dim pOutBout As SqlParameter = New SqlParameter("@OutBout", SqlDbType.Int, 4)
                pOutBout.Value = myMa_Bc_Khai_Thac_Chi_Tiet.OutBout
                myCommand.Parameters.Add(pOutBout)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Bc_Khai_Thac
        ' Input: Ma_Bc_Khai_Thac,  Ten_Bc_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ten_Bc_Khai_Thac As String, ByVal OutBout As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTen_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ten_Bc_Khai_Thac", SqlDbType.NVarChar, 100)
                pTen_Bc_Khai_Thac.Value = Ten_Bc_Khai_Thac
                myCommand.Parameters.Add(pTen_Bc_Khai_Thac)

                Dim pOutBout As SqlParameter = New SqlParameter("@OutBout", SqlDbType.Int, 4)
                pOutBout.Value = OutBout
                myCommand.Parameters.Add(pOutBout)

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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Bc_Khai_Thac
        ' Input: Ma_Bc_Khai_Thac
        ' Output: 
        Public Sub Xoa(ByVal Ma_Bc_Khai_Thac As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Kiem tra Ma_Bc_Khai_Thac"
        Public Function Chk_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Kiem_Tra_Ton_Tai", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

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
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Bc_Khai_Thac
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Bc_Khai_Thac_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function

        ' Ngày tạo: 11/6/2012
        ' Người tạo: Do Quoc Khanh
        ' Nội dung: Lay danh sach buu cuc khai thac can kiem tra lac huong
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Kiem_Tra_Huong_Chuyen(ByVal _Ma_Bc_Khai_Thac As Integer) As Boolean
            Try
                Dim ReturnValue As Boolean
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myCommand As SqlCommand

                myCommand = New SqlCommand("Select Count(*) from Kiem_Tra_Huong_Chuyen WHERE (Ma_Bc_Khai_Thac= " & _Ma_Bc_Khai_Thac & ") And (Kiem_Tra_Huong_Chuyen = 1)", myConnection)

                myConnection.Open()
                myCommand.CommandType = CommandType.Text
                myAdapter.SelectCommand = myCommand
                ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
                myConnection.Close()
                myConnection.Dispose()

                Return ReturnValue


                ' Tạo đối tượng connection và command
                'Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                'Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Danh_Sach", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                '' Sử dụng Store Procedure
                'myCommand.CommandType = CommandType.StoredProcedure

                'myConnection.Open()
                'myAdapter.SelectCommand = myCommand
                'myAdapter.Fill(myDataSet, "Ma_Bc_Khai_Thac_Danh_Sach")
                'myConnection.Close()
                'myConnection.Dispose()
                'Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Danh_Sach_Login"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Bc_Khai_Thac
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Login() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Danh_Sach_LogIn", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Bc_Khai_Thac_Danh_Sach_LogIn")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Ma_Bc_Khai_Thac_Danh_Sach_QT_Den"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Bc_Khai_Thac
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Ma_Bc_Khai_Thac_Danh_Sach_QT_Den() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Bc_Khai_Thac_Danh_Sach_QT_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Bc_Khai_Thac_Danh_Sach_QT_Den")
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

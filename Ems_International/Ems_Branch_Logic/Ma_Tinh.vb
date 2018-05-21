
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ma_Tinh_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ma_Tinh_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ma_Tinh trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ma_Tinh_Chi_Tiet
        Public Ma_Tinh As Integer
        Public Ten_Tinh As String
        Public Khu_Vuc As Integer
        Public Thoa_Thuan As Boolean ' 0: EMS; 1: EMS Thỏa thuận
    End Class
#End Region
#Region "Ma_Tinh"
    Public Class Ma_Tinh
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: Ma_Tinh_Chi_Tiet
        Public Function Lay(ByVal Ma_Tinh As Integer) As Ma_Tinh_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThoa_Thuan)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myMa_Tinh_Chi_Tiet As Ma_Tinh_Chi_Tiet = New Ma_Tinh_Chi_Tiet
                myMa_Tinh_Chi_Tiet.Ma_Tinh = Ma_Tinh
                myMa_Tinh_Chi_Tiet.Ten_Tinh = pTen_Tinh.Value
                myMa_Tinh_Chi_Tiet.Khu_Vuc = pKhu_Vuc.Value
                myMa_Tinh_Chi_Tiet.Thoa_Thuan = pThoa_Thuan.Value
                Return myMa_Tinh_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ma_Tinh
        ' Input:  Ten_Tinh, Khu_Vuc, Thoa_Thuan,
        ' Output: 
        Public Sub Them(ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Tinh
        ' Input: Ma_Tinh,  Ten_Tinh , Khu_Vuc , Thoa_Thuan ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Tinh As Integer, ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ma_Tinh
        ' Input: đối tượng thuộc lớp Ma_Tinh_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myMa_Tinh_Chi_Tiet As Ma_Tinh_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myMa_Tinh_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = myMa_Tinh_Chi_Tiet.Ten_Tinh
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = myMa_Tinh_Chi_Tiet.Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = myMa_Tinh_Chi_Tiet.Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ma_Tinh
        ' Input: Ma_Tinh,  Ten_Tinh , Khu_Vuc , Thoa_Thuan ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Tinh As Integer, ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = Ten_Tinh
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)


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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: 
        Public Sub Xoa(ByVal Ma_Tinh As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

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
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Xoa_Tat_Ca", myConnection)

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
#Region "Kiem tra Ma_Tinh"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_Tinh(ByVal Ma_Tinh As Integer) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from Ma_Tinh where (Ma_Tinh= " & Ma_Tinh & ") ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
#Region "Lay_Tat_Ca_Tu_Tmp"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Tinh_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Rut_Gon"
        Public Function Danh_Sach_Rut_Gon() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Danh_Sach_Rut_Gon", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ma_Tinh_Danh_Sach_Rut_Gon")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Ma_Tinh_Khu_Vuc_Tn"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Ma_Tinh_Khu_Vuc_Tn(ByVal Ma_BC_Khai_Thac As Long) As DataTable
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.VarChar, 15)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myAdapter.SelectCommand = myCommand

                If Not myDataSet.Tables("Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN") Is Nothing Then
                    myDataSet.Tables("Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN").Clear()
                End If
                myAdapter.Fill(myDataSet, "Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN")

                Return myDataSet.Tables("Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN")
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Store su dung trong Form Ban ke Thue va le phi Hai Quan"
#Region "Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac"

        Public Function Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac(ByVal ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Ma_Tinh
            ' Ten_Tinh
            ' Khu_Vuc
            ' Thoa_Thuan


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet


            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                MyCommand.Parameters.Add(New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0, ParameterDirection.Input, True, 10, 0, "", DataRowVersion.Current, ma_Bc_Khai_Thac))

                'Fill the dataset using the connection string from the db base class
                MyConnection.Open()
                adapter.Fill(MyDataSet)

                Return MyDataSet

            Catch ex As Exception
                Console.Write(ex.ToString)
            Finally
                'Close the connection and Dispose.
                MyConnection.Close()
                MyCommand.Dispose()
                adapter.Dispose()
            End Try
        End Function
#End Region

#End Region



    End Class
#End Region
End Namespace

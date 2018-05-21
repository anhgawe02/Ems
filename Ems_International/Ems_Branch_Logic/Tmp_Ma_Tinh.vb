
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Ma_Tinh_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Ma_Tinh_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Ma_Tinh trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Ma_Tinh_Chi_Tiet
        Public Ma_Tinh As Integer
        Public Ten_Tinh As String
        Public Khu_Vuc As Integer
        Public Thoa_Thuan As Boolean
    End Class
#End Region
#Region "Tmp_Ma_Tinh"
    Public Class Tmp_Ma_Tinh
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: Tmp_Ma_Tinh_Chi_Tiet
        Public Function Lay(ByVal Ma_Tinh As Integer) As Tmp_Ma_Tinh_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Lay", myConnection)

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
                Dim myTmp_Ma_Tinh_Chi_Tiet As Tmp_Ma_Tinh_Chi_Tiet = New Tmp_Ma_Tinh_Chi_Tiet
                myTmp_Ma_Tinh_Chi_Tiet.Ma_Tinh = Ma_Tinh
                myTmp_Ma_Tinh_Chi_Tiet.Ten_Tinh = pTen_Tinh.Value
                myTmp_Ma_Tinh_Chi_Tiet.Khu_Vuc = pKhu_Vuc.Value
                myTmp_Ma_Tinh_Chi_Tiet.Thoa_Thuan = pThoa_Thuan.Value
                Return myTmp_Ma_Tinh_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Ma_Tinh
        ' Input:  Ten_Tinh, Khu_Vuc, Thoa_Thuan,
        ' Output: 
        Public Sub Them(ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ma_Tinh
        ' Input: Ma_Tinh,  Ten_Tinh , Khu_Vuc , Thoa_Thuan ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_Tinh As Integer, ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Cap_Nhat", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Ma_Tinh
        ' Input: đối tượng thuộc lớp Tmp_Ma_Tinh_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Ma_Tinh_Chi_Tiet As Tmp_Ma_Tinh_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myTmp_Ma_Tinh_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pTen_Tinh As SqlParameter = New SqlParameter("@Ten_Tinh", SqlDbType.NVarChar, 100)
                pTen_Tinh.Value = myTmp_Ma_Tinh_Chi_Tiet.Ten_Tinh
                myCommand.Parameters.Add(pTen_Tinh)

                Dim pKhu_Vuc As SqlParameter = New SqlParameter("@Khu_Vuc", SqlDbType.Int, 4)
                pKhu_Vuc.Value = myTmp_Ma_Tinh_Chi_Tiet.Khu_Vuc
                myCommand.Parameters.Add(pKhu_Vuc)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = myTmp_Ma_Tinh_Chi_Tiet.Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Ma_Tinh
        ' Input: Ma_Tinh,  Ten_Tinh , Khu_Vuc , Thoa_Thuan ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_Tinh As Integer, ByVal Ten_Tinh As String, ByVal Khu_Vuc As Integer, ByVal Thoa_Thuan As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Cap_Nhat_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Ma_Tinh
        ' Input: Ma_Tinh
        ' Output: 
        Public Sub Xoa(ByVal Ma_Tinh As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Ma_Tinh_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Ma_Tinh_Khu_Vuc_TN"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Ma_Tinh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Ma_Tinh_Khu_Vuc_TN(ByVal Ma_BC_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.VarChar, 15)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Ma_Tinh_Danh_Sach_Ma_Tinh_Khu_Vuc_TN")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region


    End Class
#End Region
End Namespace
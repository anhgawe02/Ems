
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Trang_Thai_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Trang_Thai_Chi_Tiet
    ' tương ứng với mộ trường của bảng Trang_Thai trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Trang_Thai_Chi_Tiet
        Public Id_E1 As String
        Public Ma_E1 As String
        Public Id_Trang_Thai As String
        Public Ngay_Trang_Thai As Integer ' Ngày phát sinh trạng thái
        Public Gio_Trang_Thai As Integer ' Giờ phát sinh trạng thái
        Public Ma_Bc As Integer ' Mã bưu cục phát sinh trạng thái
        Public Ngay_He_Thong As Integer ' Ngày giờ hệ thống
        Public Truyen_Khai_Thac As Boolean
    End Class
#End Region
#Region "Trang_Thai"
    Public Class Trang_Thai
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Trang_Thai
        ' Input: Id_E1
        ' Output: Trang_Thai_Chi_Tiet
        Public Function Lay(ByVal Id_E1 As String) As Trang_Thai_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTrang_Thai_Chi_Tiet As Trang_Thai_Chi_Tiet = New Trang_Thai_Chi_Tiet
                myTrang_Thai_Chi_Tiet.Id_E1 = Id_E1
                myTrang_Thai_Chi_Tiet.Ma_E1 = pMa_E1.Value
                myTrang_Thai_Chi_Tiet.Id_Trang_Thai = pId_Trang_Thai.Value
                myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai = pNgay_Trang_Thai.Value
                myTrang_Thai_Chi_Tiet.Gio_Trang_Thai = pGio_Trang_Thai.Value
                myTrang_Thai_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myTrang_Thai_Chi_Tiet.Ngay_He_Thong = pNgay_He_Thong.Value
                myTrang_Thai_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                Return myTrang_Thai_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Trang_Thai
        ' Input:  Ma_E1, Id_Trang_Thai, Ngay_Trang_Thai, Gio_Trang_Thai, Ma_Bc, Ngay_He_Thong, Truyen_Khai_Thac,
        ' Output: 
        Public Sub Them(ByVal Ma_E1 As String, ByVal Id_Trang_Thai As String, ByVal Ngay_Trang_Thai As Integer, ByVal Gio_Trang_Thai As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Value = Ngay_Trang_Thai
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Value = Gio_Trang_Thai
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Trang_Thai
        ' Input: Id_E1,  Ma_E1 , Id_Trang_Thai , Ngay_Trang_Thai , Gio_Trang_Thai , Ma_Bc , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_E1 As String, ByVal Ma_E1 As String, ByVal Id_Trang_Thai As String, ByVal Ngay_Trang_Thai As Integer, ByVal Gio_Trang_Thai As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Value = Ngay_Trang_Thai
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Value = Gio_Trang_Thai
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Trang_Thai
        ' Input: đối tượng thuộc lớp Trang_Thai_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTrang_Thai_Chi_Tiet As Trang_Thai_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = myTrang_Thai_Chi_Tiet.Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = myTrang_Thai_Chi_Tiet.Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = myTrang_Thai_Chi_Tiet.Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Value = myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Value = myTrang_Thai_Chi_Tiet.Gio_Trang_Thai
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = myTrang_Thai_Chi_Tiet.Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = myTrang_Thai_Chi_Tiet.Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myTrang_Thai_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Trang_Thai
        ' Input: Id_E1,  Ma_E1 , Id_Trang_Thai , Ngay_Trang_Thai , Gio_Trang_Thai , Ma_Bc , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_E1 As String, ByVal Ma_E1 As String, ByVal Id_Trang_Thai As String, ByVal Ngay_Trang_Thai As Integer, ByVal Gio_Trang_Thai As Integer, ByVal Ma_Bc As Integer, ByVal Ngay_He_Thong As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Value = Ngay_Trang_Thai
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Value = Gio_Trang_Thai
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                pNgay_He_Thong.Value = Ngay_He_Thong
                myCommand.Parameters.Add(pNgay_He_Thong)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Trang_Thai
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                    pId_E1.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_E1"))
                    myCommand.Parameters.Add(pId_E1)

                    Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                    pMa_E1.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_E1"))
                    myCommand.Parameters.Add(pMa_E1)

                    Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                    pId_Trang_Thai.Value = Convert.ToString(myDataTable.Rows(i).Item("Id_Trang_Thai"))
                    myCommand.Parameters.Add(pId_Trang_Thai)

                    Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                    pNgay_Trang_Thai.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ngay_Trang_Thai"))
                    myCommand.Parameters.Add(pNgay_Trang_Thai)

                    Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                    pGio_Trang_Thai.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Gio_Trang_Thai"))
                    myCommand.Parameters.Add(pGio_Trang_Thai)

                    Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                    pMa_Bc.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Bc"))
                    myCommand.Parameters.Add(pMa_Bc)

                    Dim pNgay_He_Thong As SqlParameter = New SqlParameter("@Ngay_He_Thong", SqlDbType.Int, 4)
                    pNgay_He_Thong.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ngay_He_Thong"))
                    myCommand.Parameters.Add(pNgay_He_Thong)

                    Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                    pTruyen_Khai_Thac.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Truyen_Khai_Thac"))
                    myCommand.Parameters.Add(pTruyen_Khai_Thac)



                    myCommand.ExecuteNonQuery()
                Next
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Trang_Thai
        ' Input: Id_E1
        ' Output: 
        Public Sub Xoa(ByVal Id_E1 As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Trang_Thai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Trang_Thai_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Ma_E1"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Trang_Thai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Ma_E1(ByVal Ma_E1 As String, ByVal Ngay_Before As Integer, ByVal Ngay_After As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Danh_Sach_Lay_Boi_Ma_E1", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pNgay_Before As SqlParameter = New SqlParameter("@Ngay_Before", SqlDbType.Int, 4)
                pNgay_Before.Value = Ngay_Before
                myCommand.Parameters.Add(pNgay_Before)

                Dim pNgay_After As SqlParameter = New SqlParameter("@Ngay_After", SqlDbType.VarChar, 13)
                pNgay_After.Value = Ngay_After
                myCommand.Parameters.Add(pNgay_After)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Trang_Thai_Danh_Sach_Lay_Boi_Ma_E1")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_Trang_Thai"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Trang_Thai thông qua khóa chính 
        ' Input: Id_Trang_Thai
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Trang_Thai(ByVal Id_Trang_Thai As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Lay_Boi_Ma_Trang_Thai", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Trang_Thai_Lay_Boi_Ma_Trang_Thai")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Khai Thác"
#Region "Cap_Nhat_Them_KT"
        ' Ngày tạo: 03/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Trang_Thai
        ' Input: Id_E1,  Ma_E1 , Id_Trang_Thai , Ngay_Trang_Thai , Gio_Trang_Thai , Ma_Bc , Ngay_He_Thong , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them_KT(ByVal Id_E1 As String, ByVal Ma_E1 As String, ByVal Id_Trang_Thai As String, ByVal Ngay_Trang_Thai As Integer, ByVal Gio_Trang_Thai As Integer, ByVal Ma_Bc As Integer, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat_Them_KT", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_E1 As SqlParameter = New SqlParameter("@Id_E1", SqlDbType.VarChar, 50)
                pId_E1.Value = Id_E1
                myCommand.Parameters.Add(pId_E1)

                Dim pMa_E1 As SqlParameter = New SqlParameter("@Ma_E1", SqlDbType.VarChar, 13)
                pMa_E1.Value = Ma_E1
                myCommand.Parameters.Add(pMa_E1)

                Dim pId_Trang_Thai As SqlParameter = New SqlParameter("@Id_Trang_Thai", SqlDbType.VarChar, 5)
                pId_Trang_Thai.Value = Id_Trang_Thai
                myCommand.Parameters.Add(pId_Trang_Thai)

                Dim pNgay_Trang_Thai As SqlParameter = New SqlParameter("@Ngay_Trang_Thai", SqlDbType.Int, 4)
                pNgay_Trang_Thai.Value = Ngay_Trang_Thai
                myCommand.Parameters.Add(pNgay_Trang_Thai)

                Dim pGio_Trang_Thai As SqlParameter = New SqlParameter("@Gio_Trang_Thai", SqlDbType.Int, 4)
                pGio_Trang_Thai.Value = Gio_Trang_Thai
                myCommand.Parameters.Add(pGio_Trang_Thai)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)


                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen"
        Public Function Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Trang_Thai_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den"
        Public Function Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den(ByVal Id_Chuyen_Thu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Trang_Thai_Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Cap_Nhat_Truyen"
        ' Ngày tạo: 04/09/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Cập nhật dữ liệu truyền
        ' Input: Id_Chuyen_Thu
        ' Output: 
        Public Sub Cap_Nhat_Truyen(ByVal Id_Chuyen_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Trang_Thai_Cap_Nhat_Truyen", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = Id_Chuyen_Thu
                myCommand.Parameters.Add(pId_Chuyen_Thu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#End Region
    End Class
#End Region
End Namespace
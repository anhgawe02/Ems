
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Ca_San_Xuat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Ca_San_Xuat_Chi_Tiet
    ' tương ứng với mộ trường của bảng Ca_San_Xuat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Ca_San_Xuat_Chi_Tiet
        Public Id_Ca As String ' DDDDDDYYYYMMDDW
        Public Ma_Bc_Khai_Thac As Integer ' Bưu cục khai thác: DDDDDD
        Public Ngay_Khai_Thac As Integer ' Ngày khai thác: YYYYMMDD
        Public Ca_Khai_Thac As Integer ' Ca khai thác: W
        Public Tu_Ngay As Integer ' Từ ngày
        Public Tu_Gio As Integer ' Từ giờ
        Public Den_Ngay As Integer ' Đến Ngày
        Public Den_Gio As Integer ' Đến giờ
        Public Su_Dung As Boolean
        Public Thu_Tu As Integer
    End Class
#End Region
#Region "Ca_San_Xuat"
    Public Class Ca_San_Xuat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ca_San_Xuat
        ' Input: Id_Ca
        ' Output: Ca_San_Xuat_Chi_Tiet
        Public Function Lay(ByVal Id_Ca As String) As Ca_San_Xuat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThu_Tu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCa_San_Xuat_Chi_Tiet As Ca_San_Xuat_Chi_Tiet = New Ca_San_Xuat_Chi_Tiet
                myCa_San_Xuat_Chi_Tiet.Id_Ca = Id_Ca
                myCa_San_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Gio = pTu_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Den_Gio = pDen_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myCa_San_Xuat_Chi_Tiet.Thu_Tu = pThu_Tu.Value
                Return myCa_San_Xuat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Ca_San_Xuat
        ' Input:  Ma_Bc_Khai_Thac, Ngay_Khai_Thac, Ca_Khai_Thac, Tu_Ngay, Tu_Gio, Den_Ngay, Den_Gio, Su_Dung, Thu_Tu,
        ' Output: 
        Public Sub Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Tu_Gio As Integer, ByVal Den_Ngay As Integer, ByVal Den_Gio As Integer, ByVal Su_Dung As Boolean, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ca_San_Xuat
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tu_Ngay , Tu_Gio , Den_Ngay , Den_Gio , Su_Dung , Thu_Tu ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Tu_Gio As Integer, ByVal Den_Ngay As Integer, ByVal Den_Gio As Integer, ByVal Su_Dung As Boolean, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Ca_San_Xuat
        ' Input: đối tượng thuộc lớp Ca_San_Xuat_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCa_San_Xuat_Chi_Tiet As Ca_San_Xuat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = myCa_San_Xuat_Chi_Tiet.Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myCa_San_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = myCa_San_Xuat_Chi_Tiet.Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCa_San_Xuat_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = myCa_San_Xuat_Chi_Tiet.Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCa_San_Xuat_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = myCa_San_Xuat_Chi_Tiet.Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = myCa_San_Xuat_Chi_Tiet.Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = myCa_San_Xuat_Chi_Tiet.Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Ca_San_Xuat
        ' Input: Id_Ca,  Ma_Bc_Khai_Thac , Ngay_Khai_Thac , Ca_Khai_Thac , Tu_Ngay , Tu_Gio , Den_Ngay , Den_Gio , Su_Dung , Thu_Tu ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Ca As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Tu_Gio As Integer, ByVal Den_Ngay As Integer, ByVal Den_Gio As Integer, ByVal Su_Dung As Boolean, ByVal Thu_Tu As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Value = Tu_Gio
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Value = Den_Gio
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

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
        ' Nội dung: Xóa dữ liệu từ bảng Ca_San_Xuat
        ' Input: Id_Ca
        ' Output: 
        Public Sub Xoa(ByVal Id_Ca As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ca_San_Xuat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Id_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Ca_San_Xuat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Id_Ca(ByVal Id_Ca As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Danh_Sach_Lay_Boi_Id_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Value = Id_Ca
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Danh_Sach_Lay_Boi_Id_Ca")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach ca kt"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy ca kế toán
        ' Input: 
        ' Output: DataSet 
        Public Function Danh_Sach_Kt(ByVal Ngay_Khai_Thac As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Danh_Sach_Kt", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Danh_Sach_Kt")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Ca thông qua khóa chính 
        ' Input: Ca_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Ca(ByVal Ca_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay_Boi_Ma_Ca", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Value = Ca_Khai_Thac
                myCommand.Parameters.Add(pCa_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Lay_Boi_Ma_Ca")
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
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ca_San_Xuat dang su dung
        ' Input: Id_Ca
        ' Output: Ca_San_Xuat_Chi_Tiet
        Public Function Lay_Id_Ca(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Thu_Tu As Integer) As Ca_San_Xuat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay_Id_Ca", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Value = Ngay_Khai_Thac
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Value = Thu_Tu
                myCommand.Parameters.Add(pThu_Tu)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCa_San_Xuat_Chi_Tiet As Ca_San_Xuat_Chi_Tiet = New Ca_San_Xuat_Chi_Tiet
                myCa_San_Xuat_Chi_Tiet.Id_Ca = pId_Ca.Value
                myCa_San_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac = Ngay_Khai_Thac
                myCa_San_Xuat_Chi_Tiet.Thu_Tu = Thu_Tu
                Return myCa_San_Xuat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiểm tra sự tồn tại của Id_Ca"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại Id_Ca
        ' Input: 
        ' Output: count(*)
        Public Function Ca_San_Xuat_Kiem_Tra(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Thu_Tu As Integer) As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As Boolean
            myCommand = New SqlCommand("Select count(*) from Ca_San_Xuat where (Ma_Bc_Khai_Thac= " & Ma_Bc_Khai_Thac & ") and(Ngay_Khai_Thac= " & Ngay_Khai_Thac & ") and (Thu_Tu= " & Thu_Tu & ")   ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
        'Them moi
#Region "Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Ca_San_Xuat dang su dung
        ' Input: Id_Ca
        ' Output: Ca_San_Xuat_Chi_Tiet
        Public Function Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung(ByVal Ma_Bc_Khai_Thac As Integer) As Ca_San_Xuat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThu_Tu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCa_San_Xuat_Chi_Tiet As Ca_San_Xuat_Chi_Tiet = New Ca_San_Xuat_Chi_Tiet
                myCa_San_Xuat_Chi_Tiet.Id_Ca = pId_Ca.Value
                myCa_San_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Gio = pTu_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Den_Gio = pDen_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myCa_San_Xuat_Chi_Tiet.Thu_Tu = pThu_Tu.Value
                Return myCa_San_Xuat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Ca Kế Toán"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: 
        ' Input: 
        ' Output: DataSet 
        Public Function Ca_Ke_Toan() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_Ke_Toan", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_Ke_Toan")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Khai Thác"
#Region "Lay_Ca_Hien_Tai"
        ' Ngày tạo: 22/08/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy thông tin về ca sản xuất hiện tại
        ' Input: Id_Ca
        ' Output: Ca_San_Xuat_Chi_Tiet
        Public Function Lay_Ca_Hien_Tai(ByVal Ma_Bc_Khai_Thac As Integer) As Ca_San_Xuat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Lay_Ca_Hien_Tai", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 12)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Ca As SqlParameter = New SqlParameter("@Id_Ca", SqlDbType.VarChar, 15)
                pId_Ca.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Ca)

                Dim pNgay_Khai_Thac As SqlParameter = New SqlParameter("@Ngay_Khai_Thac", SqlDbType.Int, 4)
                pNgay_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khai_Thac)

                Dim pCa_Khai_Thac As SqlParameter = New SqlParameter("@Ca_Khai_Thac", SqlDbType.Int, 4)
                pCa_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCa_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pTu_Gio As SqlParameter = New SqlParameter("@Tu_Gio", SqlDbType.Int, 4)
                pTu_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Gio)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pDen_Gio As SqlParameter = New SqlParameter("@Den_Gio", SqlDbType.Int, 4)
                pDen_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Gio)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Bit, 1)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                Dim pThu_Tu As SqlParameter = New SqlParameter("@Thu_Tu", SqlDbType.Int, 4)
                pThu_Tu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThu_Tu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCa_San_Xuat_Chi_Tiet As Ca_San_Xuat_Chi_Tiet = New Ca_San_Xuat_Chi_Tiet
                myCa_San_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myCa_San_Xuat_Chi_Tiet.Id_Ca = pId_Ca.Value
                myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac = pNgay_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Ca_Khai_Thac = pCa_Khai_Thac.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Tu_Gio = pTu_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                myCa_San_Xuat_Chi_Tiet.Den_Gio = pDen_Gio.Value
                myCa_San_Xuat_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myCa_San_Xuat_Chi_Tiet.Thu_Tu = pThu_Tu.Value
                Return myCa_San_Xuat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#End Region

#Region "Ca_San_Xuat_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Ca_San_Xuat_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Ca_San_Xuat_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Ca_San_Xuat_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Tu_Ngay_Den_Ngay")
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

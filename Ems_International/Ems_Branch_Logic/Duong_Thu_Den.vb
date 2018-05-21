Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Duong_Thu_Den_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Duong_Thu_Den_Chi_Tiet
    ' tương ứng với mộ trường của bảng Duong_Thu_Den trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Duong_Thu_Den_Chi_Tiet
        Public Id_Duong_Thu As String ' SSSSSSRRRRRR
        Public Ten_Duong_Thu As String
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Bc As Integer
        Public Id_Phan_Loai As Integer ' 0:Nội tỉnh;1:Liền kề,2: Liên tỉnh,3:Quốc tế,4: Bưu tá
        Public Tinh_Doanh_Thu As Boolean ' Đường thư tính doanh thu
        Public Tinh_Cong_Phat As Boolean ' Đường thư tính công phát
        Public Duoc_Truyen As Boolean ' Có được phép truyền hay không
        Public Su_Dung As Integer 'Hiện tại có được sử dụng không
        Public Chuyen_Tiep As Boolean 'Có phải là đường thư chuyển tiếp không: Kiểm tra lạc hướng
    End Class
#End Region
#Region "Duong_Thu_Den"
    Public Class Duong_Thu_Den
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Duong_Thu_Den
        ' Input: Id_Duong_Thu
        ' Output: Duong_Thu_Den_Chi_Tiet
        Public Function Lay(ByVal Id_Duong_Thu As String) As Duong_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChuyen_Tiep)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDuong_Thu_Den_Chi_Tiet As Duong_Thu_Den_Chi_Tiet = New Duong_Thu_Den_Chi_Tiet
                myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu = Id_Duong_Thu
                myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu = pTen_Duong_Thu.Value
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai = pId_Phan_Loai.Value
                myDuong_Thu_Den_Chi_Tiet.Tinh_Doanh_Thu = pTinh_Doanh_Thu.Value
                myDuong_Thu_Den_Chi_Tiet.Tinh_Cong_Phat = pTinh_Cong_Phat.Value
                myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = pDuoc_Truyen.Value
                myDuong_Thu_Den_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep = pChuyen_Tiep.Value
                Return myDuong_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Duong_Thu_Den
        ' Input:  Ten_Duong_Thu, Ma_Bc_Khai_Thac, Ma_Bc, Id_Phan_Loai, Ip_Truyen, Tinh_Doanh_Thu, Tinh_Cong_Phat,
        ' Output: 
        Public Sub Them(ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Id_Phan_Loai As Integer, ByVal Tinh_Doanh_Thu As Boolean, ByVal Tinh_Cong_Phat As Boolean, ByVal Duoc_Truyen As Boolean, ByVal Su_Dung As Integer, ByVal Chuyen_Tiep As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Value = Tinh_Doanh_Thu
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Value = Tinh_Cong_Phat
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Duong_Thu_Den
        ' Input: Id_Duong_Thu,  Ten_Duong_Thu , Ma_Bc_Khai_Thac , Ma_Bc , Id_Phan_Loai , Ip_Truyen , Tinh_Doanh_Thu , Tinh_Cong_Phat ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Duong_Thu As String, ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Id_Phan_Loai As Integer, ByVal Tinh_Doanh_Thu As Boolean, ByVal Tinh_Cong_Phat As Boolean, ByVal Duoc_Truyen As Boolean, ByVal Su_Dung As Integer, ByVal Chuyen_Tiep As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Value = Tinh_Doanh_Thu
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Value = Tinh_Cong_Phat
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Duong_Thu_Den
        ' Input: đối tượng thuộc lớp Duong_Thu_Den_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myDuong_Thu_Den_Chi_Tiet As Duong_Thu_Den_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Value = myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = myDuong_Thu_Den_Chi_Tiet.Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Value = myDuong_Thu_Den_Chi_Tiet.Tinh_Doanh_Thu
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Value = myDuong_Thu_Den_Chi_Tiet.Tinh_Cong_Phat
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Value = myDuong_Thu_Den_Chi_Tiet.Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Duong_Thu_Den
        ' Input: Id_Duong_Thu,  Ten_Duong_Thu , Ma_Bc_Khai_Thac , Ma_Bc , Id_Phan_Loai , Ip_Truyen , Tinh_Doanh_Thu , Tinh_Cong_Phat ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Duong_Thu As String, ByVal Ten_Duong_Thu As String, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer, ByVal Id_Phan_Loai As Integer, ByVal Tinh_Doanh_Thu As Boolean, ByVal Tinh_Cong_Phat As Boolean, ByVal Duoc_Truyen As Boolean, ByVal Su_Dung As Integer, ByVal Chuyen_Tiep As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Value = Ten_Duong_Thu
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Value = Tinh_Doanh_Thu
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Value = Tinh_Cong_Phat
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Value = Duoc_Truyen
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Value = Su_Dung
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Value = Chuyen_Tiep
                myCommand.Parameters.Add(pChuyen_Tiep)

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
        ' Nội dung: Xóa dữ liệu từ bảng Duong_Thu_Den
        ' Input: Id_Duong_Thu
        ' Output: 
        Public Sub Xoa(ByVal Id_Duong_Thu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Duong_Thu_Den
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Duong_Thu_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Duong_Thu_Den
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Hien_Thi")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Select Id_Duong_Thu"
        ' Ngày tạo: 26/6/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy thông tin về Id_Duong_Thu_Di từ Ma_Bc và Ma_Bc_Khai_Thac
        ' Input: Ma_Bc,Ma_Bc_Khai_Thac
        ' Output: Id_Duong_Thu_Di
        Public Function Select_Id_Duong_Thu_Den(ByVal myMa_Bc_Khai_Thac As Integer, ByVal myMa_Bc As Integer) As String
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String

            myCommand = New SqlCommand("Select Id_Duong_Thu from Duong_Thu_Den where (Ma_bc= " & myMa_Bc & ") and (Ma_Bc_Khai_Thac=" & myMa_Bc_Khai_Thac & ")", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
            myConnection.Dispose()

            Return ReturnValue
        End Function
#End Region
#Region "Lay_Boi_Phan_Loai_Duong_Thu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Phan_Loai_Duong_Thu thông qua khóa chính 
        ' Input: Id_Phan_Loai
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Phan_Loai_Duong_Thu(ByVal Id_Phan_Loai As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Phan_Loai_Duong_Thu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Phan_Loai_Duong_Thu")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Danh_Muc_BC"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Danh_Muc_BC thông qua khóa chính 
        ' Input: Ma_Bc
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Danh_Muc_BC(ByVal Ma_Bc As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Danh_Muc_BC", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Danh_Muc_BC")
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
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac", myConnection)
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
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Lay_Boi_Ma_Bc_Khai_Thac_Id_Phan_Loai"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Bc_Khai_Thac thông qua khóa chính 
        ' Input: Ma_Bc_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Bc_Khai_Thac_Id_Phan_Loai(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Id_Phan_Loai As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Id_Phan_Loai", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Value = Id_Phan_Loai
                myCommand.Parameters.Add(pId_Phan_Loai)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Id_Phan_Loai")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Id_Chuyen_Thu"
        ' Ngày tạo: 09/07/2008
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Lấy số Id_Chuyen_Thu
        ' Input: 
        ' Output: DataSet
        Public Function Lay_Id_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Ngay_Dong As Integer, ByVal So_Chuyen_Thu As Integer) As Chuyen_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Chuyen_Thu_Den_Lay_Id_Chuyen_Thu", myConnection)
                'Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                'Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Parameter
                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Value = Id_Duong_Thu
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pNgay_Dong As SqlParameter = New SqlParameter("@Ngay_Dong", SqlDbType.Int, 4)
                pNgay_Dong.Value = Ngay_Dong
                myCommand.Parameters.Add(pNgay_Dong)

                Dim pSo_Chuyen_Thu As SqlParameter = New SqlParameter("@So_Chuyen_Thu", SqlDbType.Int, 4)
                pSo_Chuyen_Thu.Value = So_Chuyen_Thu
                myCommand.Parameters.Add(pSo_Chuyen_Thu)

                Dim pId_Chuyen_Thu As SqlParameter = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Chuyen_Thu)
                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myChuyen_Thu_Den_Chi_Tiet As Chuyen_Thu_Den_Chi_Tiet = New Chuyen_Thu_Den_Chi_Tiet
                myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = pId_Chuyen_Thu.Value

                Return myChuyen_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_Chu"
        ' Ngày tạo: 12/2/09
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy thông tin từ bảng Duong_Thu_Den
        ' Input: Ma_Bc_Khai_Thac, Ma_Bc_Chu
        ' Output: Duong_Thu_Den_Chi_Tiet
        Public Function Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_Chu(ByVal Ma_Bc_Chu As String, ByVal Ma_Bc_Khai_Thac As Integer) As Duong_Thu_Den_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_Chu", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Chu As SqlParameter = New SqlParameter("@Ma_Bc_Chu", SqlDbType.VarChar, 6)
                pMa_Bc_Chu.Value = Ma_Bc_Chu
                myCommand.Parameters.Add(pMa_Bc_Chu)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pId_Duong_Thu As SqlParameter = New SqlParameter("@Id_Duong_Thu", SqlDbType.VarChar, 14)
                pId_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Duong_Thu)

                Dim pTen_Duong_Thu As SqlParameter = New SqlParameter("@Ten_Duong_Thu", SqlDbType.NVarChar, 150)
                pTen_Duong_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Duong_Thu)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                Dim pId_Phan_Loai As SqlParameter = New SqlParameter("@Id_Phan_Loai", SqlDbType.Int, 4)
                pId_Phan_Loai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pId_Phan_Loai)

                Dim pTinh_Doanh_Thu As SqlParameter = New SqlParameter("@Tinh_Doanh_Thu", SqlDbType.Bit, 1)
                pTinh_Doanh_Thu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Doanh_Thu)

                Dim pTinh_Cong_Phat As SqlParameter = New SqlParameter("@Tinh_Cong_Phat", SqlDbType.Bit, 1)
                pTinh_Cong_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Cong_Phat)

                Dim pDuoc_Truyen As SqlParameter = New SqlParameter("@Duoc_Truyen", SqlDbType.Bit, 1)
                pDuoc_Truyen.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDuoc_Truyen)

                Dim pSu_Dung As SqlParameter = New SqlParameter("@Su_Dung", SqlDbType.Int, 4)
                pSu_Dung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSu_Dung)

                Dim pChuyen_Tiep As SqlParameter = New SqlParameter("@Chuyen_Tiep", SqlDbType.Bit, 1)
                pChuyen_Tiep.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pChuyen_Tiep)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                Dim myDuong_Thu_Den_Chi_Tiet As Duong_Thu_Den_Chi_Tiet = New Duong_Thu_Den_Chi_Tiet
                myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu = pId_Duong_Thu.Value
                myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu = pTen_Duong_Thu.Value
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = Ma_Bc_Khai_Thac
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai = pId_Phan_Loai.Value
                myDuong_Thu_Den_Chi_Tiet.Tinh_Doanh_Thu = pTinh_Doanh_Thu.Value
                myDuong_Thu_Den_Chi_Tiet.Tinh_Cong_Phat = pTinh_Cong_Phat.Value
                myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = pDuoc_Truyen.Value
                myDuong_Thu_Den_Chi_Tiet.Su_Dung = pSu_Dung.Value
                myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep = pChuyen_Tiep.Value
                Return myDuong_Thu_Den_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiem tra MaBc"
        ' Ngày tạo: 01/07/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra xem co ton tai MABC hay khong
        ' Input: Id_E2
        ' Output: count(*)
        Public Function Kiem_Tra_MaBc(ByVal Ma_Bc As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As Boolean
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Kiem_Tra_MaBc", myConnection)
                Dim myReturn As Boolean
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_BC", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pIsValid As SqlParameter = New SqlParameter("@IsValid", SqlDbType.Bit, 1)
                pIsValid.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIsValid)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myReturn = pIsValid.Value
                Return myReturn
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Khai Thác"
#Region "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu về phân loại đường thư thông qua Ma_Bc_Khai_Thac và Ma_Bc, sử dụng trong chức năng khai thác
        ' Input: Ma_Bc_Khai_Thac,Ma_Bc
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer) As DataTable
            Dim myCommand As New SqlCommand
            Dim myAdapter As New SqlDataAdapter
            Dim myDataTable As New DataTable
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            myCommand.Connection = myConnection
            myCommand.CommandText = "SELECT	Id_Duong_Thu,Ten_Duong_Thu,Ma_Bc_Khai_Thac,Ma_Bc,Id_Phan_Loai,Duoc_Truyen,Su_Dung,Chuyen_Tiep FROM Duong_Thu_Den WHERE (Ma_Bc_Khai_Thac=" & Ma_Bc_Khai_Thac & ") and (Ma_Bc=" & Ma_Bc & ")"
            Try
                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataTable)
                Return myDataTable
                myConnection.Close()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try

        End Function
#End Region
#Region "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_KT"
        ' Ngày tạo: 08/07/08
        ' Người tạo: Đỗ Quốc Khánh
        ' Nội dung: Lấy dữ liệu từ bảng Duong_Thu_Den thông qua Ma_Bc_Khai_Thac, sử dụng trong chức năng khai thác
        ' Input: Ma_Bc_Khai_Thac
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_KT(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_KT", myConnection)
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
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT"
        Public Function Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Nuoc As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region


#End Region

#Region "Duong_Thu_Den_Danh_Sach_Duong_Thu_Chuyen_Hoan_Lay_Boi_Ma_Bc_Khai_Thac"

        Public Function Duong_Thu_Den_Danh_Sach_Duong_Thu_Chuyen_Hoan_Lay_Boi_Ma_Bc_Khai_Thac(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet

            ' The procedure returns these columns:
            ' Id_Duong_Thu
            ' Ma_Bc
            ' Ten_Duong_Thu


            Dim MyCommand As SqlCommand = New SqlCommand
            MyCommand.CommandText = "Duong_Thu_Den_Danh_Sach_Duong_Thu_Chuyen_Hoan_Lay_Boi_Ma_Bc_Khai_Thac"
            MyCommand.CommandType = CommandType.StoredProcedure
            Dim Adapter As SqlDataAdapter = New SqlDataAdapter(MyCommand)
            Dim MyDataSet As New DataSet

            Dim MyConnection As New SqlConnection(ConnectionString)
            MyCommand.Connection = MyConnection

            Try


                'Define the parameters

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 0)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                MyCommand.Parameters.Add(pMa_Bc_Khai_Thac)


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

#Region "Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Trong_E_Shipping"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Duong_Thu_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Trong_E_Shipping(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Trong_E_Shipping", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Trong_E_Shipping")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac"
        ' Ngày tạo: 29/05/2012
        ' Người tạo: Do quoc Khanh
        ' Nội dung: Lấy toàn bộ dữ lieu duong thu trong nuoc theo buu cuc khai thac
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Duong_Thu_Trong_Nuoc(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Duong_Thu_Trong_Nuoc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Duong_Thu_Trong_Nuoc")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function

        ' Ngày tạo: 29/05/2012
        ' Người tạo: Do quoc Khanh
        ' Nội dung: Lấy toàn bộ dữ lieu duong thu trong nuoc theo buu cuc khai thac
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Duong_Thu_Quoc_Te(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Duong_Thu_Quoc_Te", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Duong_Thu_Quoc_Te")
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac có thêm mã bưu cục chữ"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Duong_Thu_Di
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu(ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu")
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

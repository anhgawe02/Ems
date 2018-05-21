
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Cuoc_Dv_Khai_Gia_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_Dv_Khai_Gia_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_Dv_Khai_Gia trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_Dv_Khai_Gia_Chi_Tiet
        Public Id_Cuoc_Khai_Gia As Integer
        Public Ma_Dich_Vu As String
        Public Cuoc As Integer ' Cước dịch vụ  (% giá trị hàng)
        Public Cuoc_Toi_Thieu As Integer ' Cước tối thiểu phải thu
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Cuoc_Dv_Khai_Gia"
    Public Class Cuoc_Dv_Khai_Gia
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: Cuoc_Dv_Khai_Gia_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Khai_Gia As Integer) As Cuoc_Dv_Khai_Gia_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.Int, 4)
                pId_Cuoc_Khai_Gia.Value = Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCuoc_Dv_Khai_Gia_Chi_Tiet As Cuoc_Dv_Khai_Gia_Chi_Tiet = New Cuoc_Dv_Khai_Gia_Chi_Tiet
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Id_Cuoc_Khai_Gia = Id_Cuoc_Khai_Gia
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Ma_Dich_Vu = pMa_Dich_Vu.Value
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc = pCuoc.Value
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc_Toi_Thieu = pCuoc_Toi_Thieu.Value
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_Dv_Khai_Gia_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myCuoc_Dv_Khai_Gia_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_Dv_Khai_Gia
        ' Input:  Ma_Dich_Vu, Cuoc, Cuoc_Toi_Thieu, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia,  Ma_Dich_Vu , Cuoc , Cuoc_Toi_Thieu , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Khai_Gia As Integer, ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.Int, 4)
                pId_Cuoc_Khai_Gia.Value = Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Dv_Khai_Gia
        ' Input: đối tượng thuộc lớp Cuoc_Dv_Khai_Gia_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_Dv_Khai_Gia_Chi_Tiet As Cuoc_Dv_Khai_Gia_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.Int, 4)
                pId_Cuoc_Khai_Gia.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_Dv_Khai_Gia_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia,  Ma_Dich_Vu , Cuoc , Cuoc_Toi_Thieu , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Khai_Gia As Integer, ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.Int, 4)
                pId_Cuoc_Khai_Gia.Value = Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Khai_Gia As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.Int, 4)
                pId_Cuoc_Khai_Gia.Value = Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Xoa_Tat_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Xoa_Tat_Ca", myConnection)

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
#Region "Lay_Tat_Ca_Tu_Tmp"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Dv_Khai_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Khai_Gia_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Dv_Khai_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Khai_Gia_Danh_Sach_Hien_Thi")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Boi_Dich_Vu"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Dich_Vu thông qua khóa chính 
        ' Input: Ma_Dich_Vu
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Dich_Vu(ByVal Ma_Dich_Vu As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Khai_Gia_Lay_Boi_Dich_Vu", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Khai_Gia_Lay_Boi_Dich_Vu")
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

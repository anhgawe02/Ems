
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace Ems_International
#Region "Cuoc_Dv_Gia_Tang_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_Dv_Gia_Tang_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_Dv_Gia_Tang trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_Dv_Gia_Tang_Chi_Tiet
        Public Id_Cuoc_Dv As Integer
        Public Ma_Dich_Vu As String
        Public Ma_Tinh_Nhan As Integer
        Public Ma_Tinh_Tra As Integer
        Public Cach_Tinh As Boolean ' 0:Được tính đến; 1: Tiếp theo
        Public Khoi_Luong As Integer
        Public Cuoc As Integer ' Cước dịch vụ
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Cuoc_Dv_Gia_Tang"
    Public Class Cuoc_Dv_Gia_Tang
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv
        ' Output: Cuoc_Dv_Gia_Tang_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Dv As Integer) As Cuoc_Dv_Gia_Tang_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                pId_Cuoc_Dv.Value = Id_Cuoc_Dv
                myCommand.Parameters.Add(pId_Cuoc_Dv)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                pMa_Tinh_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh_Nhan)

                Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                pMa_Tinh_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh_Tra)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc)

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
                myConnection.Dispose()
                Dim myCuoc_Dv_Gia_Tang_Chi_Tiet As Cuoc_Dv_Gia_Tang_Chi_Tiet = New Cuoc_Dv_Gia_Tang_Chi_Tiet
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Id_Cuoc_Dv = Id_Cuoc_Dv
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Dich_Vu = pMa_Dich_Vu.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Tinh_Nhan = pMa_Tinh_Nhan.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Tinh_Tra = pMa_Tinh_Tra.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Cach_Tinh = pCach_Tinh.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Cuoc = pCuoc.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_Dv_Gia_Tang_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myCuoc_Dv_Gia_Tang_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_Dv_Gia_Tang
        ' Input:  Ma_Dich_Vu, Ma_Tinh_Nhan, Ma_Tinh_Tra, Cach_Tinh, Khoi_Luong, Cuoc, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Dich_Vu As String, ByVal Ma_Tinh_Nhan As Integer, ByVal Ma_Tinh_Tra As Integer, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                pMa_Tinh_Nhan.Value = Ma_Tinh_Nhan
                myCommand.Parameters.Add(pMa_Tinh_Nhan)

                Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                pMa_Tinh_Tra.Value = Ma_Tinh_Tra
                myCommand.Parameters.Add(pMa_Tinh_Tra)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

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
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv,  Ma_Dich_Vu , Ma_Tinh_Nhan , Ma_Tinh_Tra , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Dv As Integer, ByVal Ma_Dich_Vu As String, ByVal Ma_Tinh_Nhan As Integer, ByVal Ma_Tinh_Tra As Integer, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                pId_Cuoc_Dv.Value = Id_Cuoc_Dv
                myCommand.Parameters.Add(pId_Cuoc_Dv)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                pMa_Tinh_Nhan.Value = Ma_Tinh_Nhan
                myCommand.Parameters.Add(pMa_Tinh_Nhan)

                Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                pMa_Tinh_Tra.Value = Ma_Tinh_Tra
                myCommand.Parameters.Add(pMa_Tinh_Tra)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

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
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Dv_Gia_Tang
        ' Input: đối tượng thuộc lớp Cuoc_Dv_Gia_Tang_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_Dv_Gia_Tang_Chi_Tiet As Cuoc_Dv_Gia_Tang_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                pId_Cuoc_Dv.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Id_Cuoc_Dv
                myCommand.Parameters.Add(pId_Cuoc_Dv)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                pMa_Tinh_Nhan.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Tinh_Nhan
                myCommand.Parameters.Add(pMa_Tinh_Nhan)

                Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                pMa_Tinh_Tra.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Ma_Tinh_Tra
                myCommand.Parameters.Add(pMa_Tinh_Tra)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_Dv_Gia_Tang_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv,  Ma_Dich_Vu , Ma_Tinh_Nhan , Ma_Tinh_Tra , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Dv As Integer, ByVal Ma_Dich_Vu As String, ByVal Ma_Tinh_Nhan As Integer, ByVal Ma_Tinh_Tra As Integer, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                pId_Cuoc_Dv.Value = Id_Cuoc_Dv
                myCommand.Parameters.Add(pId_Cuoc_Dv)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                pMa_Tinh_Nhan.Value = Ma_Tinh_Nhan
                myCommand.Parameters.Add(pMa_Tinh_Nhan)

                Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                pMa_Tinh_Tra.Value = Ma_Tinh_Tra
                myCommand.Parameters.Add(pMa_Tinh_Tra)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = Cuoc
                myCommand.Parameters.Add(pCuoc)

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
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_Dv_Gia_Tang
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                    pId_Cuoc_Dv.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Id_Cuoc_Dv"))
                    myCommand.Parameters.Add(pId_Cuoc_Dv)

                    Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                    pMa_Dich_Vu.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_Dich_Vu"))
                    myCommand.Parameters.Add(pMa_Dich_Vu)

                    Dim pMa_Tinh_Nhan As SqlParameter = New SqlParameter("@Ma_Tinh_Nhan", SqlDbType.Int, 4)
                    pMa_Tinh_Nhan.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Tinh_Nhan"))
                    myCommand.Parameters.Add(pMa_Tinh_Nhan)

                    Dim pMa_Tinh_Tra As SqlParameter = New SqlParameter("@Ma_Tinh_Tra", SqlDbType.Int, 4)
                    pMa_Tinh_Tra.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Ma_Tinh_Tra"))
                    myCommand.Parameters.Add(pMa_Tinh_Tra)

                    Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                    pCach_Tinh.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Cach_Tinh"))
                    myCommand.Parameters.Add(pCach_Tinh)

                    Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                    pKhoi_Luong.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Khoi_Luong"))
                    myCommand.Parameters.Add(pKhoi_Luong)

                    Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                    pCuoc.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Cuoc"))
                    myCommand.Parameters.Add(pCuoc)

                    Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                    pTu_Ngay.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Tu_Ngay"))
                    myCommand.Parameters.Add(pTu_Ngay)

                    Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                    pDen_Ngay.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Den_Ngay"))
                    myCommand.Parameters.Add(pDen_Ngay)



                    myCommand.ExecuteNonQuery()
                Next
                myConnection.Close()
                myConnection.Dispose()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Dv As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Dv As SqlParameter = New SqlParameter("@Id_Cuoc_Dv", SqlDbType.Int, 4)
                pId_Cuoc_Dv.Value = Id_Cuoc_Dv
                myCommand.Parameters.Add(pId_Cuoc_Dv)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()
                myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Xoa_Tat_Ca"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Xoa_Tat_CA", myConnection)

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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Dv_Gia_Tang
        ' Input: Id_Cuoc_Dv
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Dv_Gia_Tang
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Gia_Tang_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Dv_Gia_Tang
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Gia_Tang_Danh_Sach_Hien_Thi")
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
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Dv_Gia_Tang_Lay_Boi_Dich_Vu", myConnection)
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
                myAdapter.Fill(myDataSet, "Cuoc_Dv_Gia_Tang_Lay_Boi_Dich_Vu")
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

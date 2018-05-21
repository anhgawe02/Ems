
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Cuoc_Phat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Cuoc_Phat_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Cuoc_Phat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Cuoc_Phat_Chi_Tiet
        Public Id_Cuoc_Phat As Integer
        Public Phan_Loai_BP As String
        Public Quoc_Te As Boolean
        Public Thoa_Thuan As Boolean
        Public Cach_Tinh As Boolean
        Public Khoi_Luong As Integer
        Public Cuoc As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Tmp_Cuoc_Phat"
    Public Class Tmp_Cuoc_Phat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Cuoc_Phat
        ' Input: Id_Cuoc_Phat
        ' Output: Tmp_Cuoc_Phat_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Phat As Integer) As Tmp_Cuoc_Phat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pQuoc_Te As SqlParameter = New SqlParameter("@Quoc_Te", SqlDbType.Bit, 1)
                pQuoc_Te.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pQuoc_Te)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pThoa_Thuan)

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
                Dim myTmp_Cuoc_Phat_Chi_Tiet As Tmp_Cuoc_Phat_Chi_Tiet = New Tmp_Cuoc_Phat_Chi_Tiet
                myTmp_Cuoc_Phat_Chi_Tiet.Id_Cuoc_Phat = Id_Cuoc_Phat
                myTmp_Cuoc_Phat_Chi_Tiet.Phan_Loai_BP = pPhan_Loai_BP.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Quoc_Te = pQuoc_Te.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Thoa_Thuan = pThoa_Thuan.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Cach_Tinh = pCach_Tinh.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Cuoc = pCuoc.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myTmp_Cuoc_Phat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myTmp_Cuoc_Phat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Cuoc_Phat
        ' Input:  Phan_Loai_BP, Quoc_Te, Thoa_Thuan, Cach_Tinh, Khoi_Luong, Cuoc, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Phan_Loai_BP As String, ByVal Quoc_Te As Boolean, ByVal Thoa_Thuan As Boolean, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pQuoc_Te As SqlParameter = New SqlParameter("@Quoc_Te", SqlDbType.Bit, 1)
                pQuoc_Te.Value = Quoc_Te
                myCommand.Parameters.Add(pQuoc_Te)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)

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
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Phat
        ' Input: Id_Cuoc_Phat,  Phan_Loai_BP , Quoc_Te , Thoa_Thuan , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Phat As Integer, ByVal Phan_Loai_BP As String, ByVal Quoc_Te As Boolean, ByVal Thoa_Thuan As Boolean, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pQuoc_Te As SqlParameter = New SqlParameter("@Quoc_Te", SqlDbType.Bit, 1)
                pQuoc_Te.Value = Quoc_Te
                myCommand.Parameters.Add(pQuoc_Te)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Phat
        ' Input: đối tượng thuộc lớp Tmp_Cuoc_Phat_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Cuoc_Phat_Chi_Tiet As Tmp_Cuoc_Phat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = myTmp_Cuoc_Phat_Chi_Tiet.Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = myTmp_Cuoc_Phat_Chi_Tiet.Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pQuoc_Te As SqlParameter = New SqlParameter("@Quoc_Te", SqlDbType.Bit, 1)
                pQuoc_Te.Value = myTmp_Cuoc_Phat_Chi_Tiet.Quoc_Te
                myCommand.Parameters.Add(pQuoc_Te)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = myTmp_Cuoc_Phat_Chi_Tiet.Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = myTmp_Cuoc_Phat_Chi_Tiet.Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myTmp_Cuoc_Phat_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = myTmp_Cuoc_Phat_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myTmp_Cuoc_Phat_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myTmp_Cuoc_Phat_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Cuoc_Phat
        ' Input: Id_Cuoc_Phat,  Phan_Loai_BP , Quoc_Te , Thoa_Thuan , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Phat As Integer, ByVal Phan_Loai_BP As String, ByVal Quoc_Te As Boolean, ByVal Thoa_Thuan As Boolean, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pQuoc_Te As SqlParameter = New SqlParameter("@Quoc_Te", SqlDbType.Bit, 1)
                pQuoc_Te.Value = Quoc_Te
                myCommand.Parameters.Add(pQuoc_Te)

                Dim pThoa_Thuan As SqlParameter = New SqlParameter("@Thoa_Thuan", SqlDbType.Bit, 1)
                pThoa_Thuan.Value = Thoa_Thuan
                myCommand.Parameters.Add(pThoa_Thuan)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Cuoc_Phat
        ' Input: Id_Cuoc_Phat
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Phat As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Phat_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Phat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Phat_Danh_Sach_Hien_Thi")
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
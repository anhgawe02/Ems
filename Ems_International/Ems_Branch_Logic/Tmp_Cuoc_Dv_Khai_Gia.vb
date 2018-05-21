
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Cuoc_Dv_Khai_Gia trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
        Public Id_Cuoc_Khai_Gia As String
        Public Ma_Dich_Vu As String
        Public Cuoc As Integer
        Public Cuoc_Toi_Thieu As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Tmp_Cuoc_Dv_Khai_Gia"
    Public Class Tmp_Cuoc_Dv_Khai_Gia
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Khai_Gia As String) As Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.VarChar, 10)
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
                Dim myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet As Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet = New Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Id_Cuoc_Khai_Gia = Id_Cuoc_Khai_Gia
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Ma_Dich_Vu = pMa_Dich_Vu.Value
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc = pCuoc.Value
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc_Toi_Thieu = pCuoc_Toi_Thieu.Value
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input:  Ma_Dich_Vu, Ten_DV, Cuoc, Cuoc_Toi_Thieu, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia,  Ma_Dich_Vu , Ten_DV , Cuoc , Cuoc_Toi_Thieu , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Khai_Gia As String, ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.VarChar, 10)
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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: đối tượng thuộc lớp Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet As Tmp_Cuoc_Dv_Khai_Gia_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.VarChar, 10)
                pId_Cuoc_Khai_Gia.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

                Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
                pMa_Dich_Vu.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Ma_Dich_Vu
                myCommand.Parameters.Add(pMa_Dich_Vu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myTmp_Cuoc_Dv_Khai_Gia_Chi_Tiet.Den_Ngay
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia,  Ma_Dich_Vu , Ten_DV , Cuoc , Cuoc_Toi_Thieu , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Khai_Gia As String, ByVal Ma_Dich_Vu As String, ByVal Cuoc As Integer, ByVal Cuoc_Toi_Thieu As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.VarChar, 10)
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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: Id_Cuoc_Khai_Gia
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Khai_Gia As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Khai_Gia As SqlParameter = New SqlParameter("@Id_Cuoc_Khai_Gia", SqlDbType.VarChar, 10)
                pId_Cuoc_Khai_Gia.Value = Id_Cuoc_Khai_Gia
                myCommand.Parameters.Add(pId_Cuoc_Khai_Gia)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Dv_Khai_Gia_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Dv_Khai_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Dv_Khai_Gia_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Dv_Khai_Gia_Danh_Sach_Hien_Thi")
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
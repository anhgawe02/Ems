
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Giam_Gia_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Giam_Gia_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Giam_Gia trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Giam_Gia_Chi_Tiet
        Public Id_Giam_Gia As Integer
        Public Tinh_Chap_Nhan As Integer
        Public Nuoc_Tra As String
        Public Tinh_Phat_Tra As Integer
        Public Phan_Loai_BP As String
        Public He_So_Giam_Gia As Double
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Tmp_Giam_Gia"
    Public Class Tmp_Giam_Gia
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Giam_Gia
        ' Input: Id_Giam_Gia
        ' Output: Tmp_Giam_Gia_Chi_Tiet
        Public Function Lay(ByVal Id_Giam_Gia As Integer) As Tmp_Giam_Gia_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Giam_Gia As SqlParameter = New SqlParameter("@Id_Giam_Gia", SqlDbType.Int, 4)
                pId_Giam_Gia.Value = Id_Giam_Gia
                myCommand.Parameters.Add(pId_Giam_Gia)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.Char, 2)
                pNuoc_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Giam_Gia As SqlParameter = New SqlParameter("@He_So_Giam_Gia", SqlDbType.Float)
                pHe_So_Giam_Gia.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHe_So_Giam_Gia)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTmp_Giam_Gia_Chi_Tiet As Tmp_Giam_Gia_Chi_Tiet = New Tmp_Giam_Gia_Chi_Tiet
                myTmp_Giam_Gia_Chi_Tiet.Id_Giam_Gia = Id_Giam_Gia
                myTmp_Giam_Gia_Chi_Tiet.Tinh_Chap_Nhan = pTinh_Chap_Nhan.Value
                myTmp_Giam_Gia_Chi_Tiet.Nuoc_Tra = pNuoc_Tra.Value
                myTmp_Giam_Gia_Chi_Tiet.Tinh_Phat_Tra = pTinh_Phat_Tra.Value
                myTmp_Giam_Gia_Chi_Tiet.Phan_Loai_BP = pPhan_Loai_BP.Value
                myTmp_Giam_Gia_Chi_Tiet.He_So_Giam_Gia = pHe_So_Giam_Gia.Value
                myTmp_Giam_Gia_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myTmp_Giam_Gia_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myTmp_Giam_Gia_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Giam_Gia
        ' Input:  Tinh_Chap_Nhan, Nuoc_Tra, Tinh_Phat_Tra, Phan_Loai_BP, He_So_Giam_Gia, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Tinh_Chap_Nhan As Integer, ByVal Nuoc_Tra As String, ByVal Tinh_Phat_Tra As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Giam_Gia As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.Char, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Giam_Gia As SqlParameter = New SqlParameter("@He_So_Giam_Gia", SqlDbType.Float)
                pHe_So_Giam_Gia.Value = He_So_Giam_Gia
                myCommand.Parameters.Add(pHe_So_Giam_Gia)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Giam_Gia
        ' Input: Id_Giam_Gia,  Tinh_Chap_Nhan , Nuoc_Tra , Tinh_Phat_Tra , Phan_Loai_BP , He_So_Giam_Gia , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Giam_Gia As Integer, ByVal Tinh_Chap_Nhan As Integer, ByVal Nuoc_Tra As String, ByVal Tinh_Phat_Tra As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Giam_Gia As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Giam_Gia As SqlParameter = New SqlParameter("@Id_Giam_Gia", SqlDbType.Int, 4)
                pId_Giam_Gia.Value = Id_Giam_Gia
                myCommand.Parameters.Add(pId_Giam_Gia)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.Char, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Giam_Gia As SqlParameter = New SqlParameter("@He_So_Giam_Gia", SqlDbType.Float)
                pHe_So_Giam_Gia.Value = He_So_Giam_Gia
                myCommand.Parameters.Add(pHe_So_Giam_Gia)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Giam_Gia
        ' Input: đối tượng thuộc lớp Tmp_Giam_Gia_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Giam_Gia_Chi_Tiet As Tmp_Giam_Gia_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Giam_Gia As SqlParameter = New SqlParameter("@Id_Giam_Gia", SqlDbType.Int, 4)
                pId_Giam_Gia.Value = myTmp_Giam_Gia_Chi_Tiet.Id_Giam_Gia
                myCommand.Parameters.Add(pId_Giam_Gia)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = myTmp_Giam_Gia_Chi_Tiet.Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.Char, 2)
                pNuoc_Tra.Value = myTmp_Giam_Gia_Chi_Tiet.Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = myTmp_Giam_Gia_Chi_Tiet.Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = myTmp_Giam_Gia_Chi_Tiet.Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Giam_Gia As SqlParameter = New SqlParameter("@He_So_Giam_Gia", SqlDbType.Float)
                pHe_So_Giam_Gia.Value = myTmp_Giam_Gia_Chi_Tiet.He_So_Giam_Gia
                myCommand.Parameters.Add(pHe_So_Giam_Gia)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myTmp_Giam_Gia_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myTmp_Giam_Gia_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Giam_Gia
        ' Input: Id_Giam_Gia,  Tinh_Chap_Nhan , Nuoc_Tra , Tinh_Phat_Tra , Phan_Loai_BP , He_So_Giam_Gia , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Giam_Gia As Integer, ByVal Tinh_Chap_Nhan As Integer, ByVal Nuoc_Tra As String, ByVal Tinh_Phat_Tra As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Giam_Gia As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Giam_Gia As SqlParameter = New SqlParameter("@Id_Giam_Gia", SqlDbType.Int, 4)
                pId_Giam_Gia.Value = Id_Giam_Gia
                myCommand.Parameters.Add(pId_Giam_Gia)

                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pNuoc_Tra As SqlParameter = New SqlParameter("@Nuoc_Tra", SqlDbType.Char, 2)
                pNuoc_Tra.Value = Nuoc_Tra
                myCommand.Parameters.Add(pNuoc_Tra)

                Dim pTinh_Phat_Tra As SqlParameter = New SqlParameter("@Tinh_Phat_Tra", SqlDbType.Int, 4)
                pTinh_Phat_Tra.Value = Tinh_Phat_Tra
                myCommand.Parameters.Add(pTinh_Phat_Tra)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Giam_Gia As SqlParameter = New SqlParameter("@He_So_Giam_Gia", SqlDbType.Float)
                pHe_So_Giam_Gia.Value = He_So_Giam_Gia
                myCommand.Parameters.Add(pHe_So_Giam_Gia)

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
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Giam_Gia
        ' Input: Id_Giam_Gia
        ' Output: 
        Public Sub Xoa(ByVal Id_Giam_Gia As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Giam_Gia As SqlParameter = New SqlParameter("@Id_Giam_Gia", SqlDbType.Int, 4)
                pId_Giam_Gia.Value = Id_Giam_Gia
                myCommand.Parameters.Add(pId_Giam_Gia)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Giam_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Giam_Gia_Danh_Sach")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Hien_Thi"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Giam_Gia
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Giam_Gia_Danh_Sach_Hien_Thi")
                myConnection.Close()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Tinh"
        ' Ngày tạo: 20/6/08
        ' Người tạo: quang do
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Tinh thông qua khóa chính 
        ' Input: Tinh_Phat_Tra
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Tinh(ByVal Tinh_Chap_Nhan As Integer, ByVal Ma_BC_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Giam_Gia_Lay_Boi_Ma_Tinh", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTinh_Chap_Nhan As SqlParameter = New SqlParameter("@Tinh_Chap_Nhan", SqlDbType.Int, 4)
                pTinh_Chap_Nhan.Value = Tinh_Chap_Nhan
                myCommand.Parameters.Add(pTinh_Chap_Nhan)

                Dim pMa_BC_Khai_Thac As SqlParameter = New SqlParameter("@Ma_BC_Khai_Thac", SqlDbType.Int, 4)
                pMa_BC_Khai_Thac.Value = Ma_BC_Khai_Thac
                myCommand.Parameters.Add(pMa_BC_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Giam_Gia_Lay_Boi_Ma_Tinh")
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
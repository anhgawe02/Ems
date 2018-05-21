
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Khuyen_Mai_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Khuyen_Mai_Chi_Tiet
    ' tương ứng với mộ trường của bảng Khuyen_Mai trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Khuyen_Mai_Chi_Tiet
        Public Id_Khuyen_Mai As Integer ' Id tự tăng
        Public Ma_Bc_Khai_Thac As Integer
        Public Ma_Nuoc As String
        Public Ma_Bc As Integer
        Public Phan_Loai_BP As String ' D: Tài liệu, M: Hàng hóa
        Public He_So_Khuyen_Mai As Double ' Cuoc = Cuoc* heso_khuyenmai
        Public Tu_Ngay As Integer ' Chính sách khuyến mại được tính từ ngày
        Public Den_Ngay As Integer ' Chính sách khuyến mại được tính đến ngày
    End Class
#End Region
#Region "Khuyen_Mai"
    Public Class Khuyen_Mai
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai
        ' Output: Khuyen_Mai_Chi_Tiet
        Public Function Lay(ByVal Id_Khuyen_Mai As Integer) As Khuyen_Mai_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Khuyen_Mai As SqlParameter = New SqlParameter("@Id_Khuyen_Mai", SqlDbType.Int, 4)
                pId_Khuyen_Mai.Value = Id_Khuyen_Mai
                myCommand.Parameters.Add(pId_Khuyen_Mai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Bc)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Khuyen_Mai As SqlParameter = New SqlParameter("@He_So_Khuyen_Mai", SqlDbType.Float)
                pHe_So_Khuyen_Mai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pHe_So_Khuyen_Mai)

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
                Dim myKhuyen_Mai_Chi_Tiet As Khuyen_Mai_Chi_Tiet = New Khuyen_Mai_Chi_Tiet
                myKhuyen_Mai_Chi_Tiet.Id_Khuyen_Mai = Id_Khuyen_Mai
                myKhuyen_Mai_Chi_Tiet.Ma_Bc_Khai_Thac = pMa_Bc_Khai_Thac.Value
                myKhuyen_Mai_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myKhuyen_Mai_Chi_Tiet.Ma_Bc = pMa_Bc.Value
                myKhuyen_Mai_Chi_Tiet.Phan_Loai_BP = pPhan_Loai_BP.Value
                myKhuyen_Mai_Chi_Tiet.He_So_Khuyen_Mai = pHe_So_Khuyen_Mai.Value
                myKhuyen_Mai_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myKhuyen_Mai_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myKhuyen_Mai_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Khuyen_Mai
        ' Input:  Ma_Bc_Khai_Thac, Ma_Nuoc, Ma_Bc, Phan_Loai_BP, He_So_Khuyen_Mai, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Bc As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Khuyen_Mai As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Khuyen_Mai As SqlParameter = New SqlParameter("@He_So_Khuyen_Mai", SqlDbType.Float)
                pHe_So_Khuyen_Mai.Value = He_So_Khuyen_Mai
                myCommand.Parameters.Add(pHe_So_Khuyen_Mai)

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
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai,  Ma_Bc_Khai_Thac , Ma_Nuoc , Ma_Bc , Phan_Loai_BP , He_So_Khuyen_Mai , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Khuyen_Mai As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Bc As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Khuyen_Mai As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khuyen_Mai As SqlParameter = New SqlParameter("@Id_Khuyen_Mai", SqlDbType.Int, 4)
                pId_Khuyen_Mai.Value = Id_Khuyen_Mai
                myCommand.Parameters.Add(pId_Khuyen_Mai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Khuyen_Mai As SqlParameter = New SqlParameter("@He_So_Khuyen_Mai", SqlDbType.Float)
                pHe_So_Khuyen_Mai.Value = He_So_Khuyen_Mai
                myCommand.Parameters.Add(pHe_So_Khuyen_Mai)

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
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Khuyen_Mai
        ' Input: đối tượng thuộc lớp Khuyen_Mai_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myKhuyen_Mai_Chi_Tiet As Khuyen_Mai_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Khuyen_Mai As SqlParameter = New SqlParameter("@Id_Khuyen_Mai", SqlDbType.Int, 4)
                pId_Khuyen_Mai.Value = myKhuyen_Mai_Chi_Tiet.Id_Khuyen_Mai
                myCommand.Parameters.Add(pId_Khuyen_Mai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = myKhuyen_Mai_Chi_Tiet.Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = myKhuyen_Mai_Chi_Tiet.Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = myKhuyen_Mai_Chi_Tiet.Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = myKhuyen_Mai_Chi_Tiet.Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Khuyen_Mai As SqlParameter = New SqlParameter("@He_So_Khuyen_Mai", SqlDbType.Float)
                pHe_So_Khuyen_Mai.Value = myKhuyen_Mai_Chi_Tiet.He_So_Khuyen_Mai
                myCommand.Parameters.Add(pHe_So_Khuyen_Mai)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myKhuyen_Mai_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myKhuyen_Mai_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai,  Ma_Bc_Khai_Thac , Ma_Nuoc , Ma_Bc , Phan_Loai_BP , He_So_Khuyen_Mai , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Khuyen_Mai As Integer, ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Nuoc As String, ByVal Ma_Bc As Integer, ByVal Phan_Loai_BP As String, ByVal He_So_Khuyen_Mai As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khuyen_Mai As SqlParameter = New SqlParameter("@Id_Khuyen_Mai", SqlDbType.Int, 4)
                pId_Khuyen_Mai.Value = Id_Khuyen_Mai
                myCommand.Parameters.Add(pId_Khuyen_Mai)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int, 4)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc As SqlParameter = New SqlParameter("@Ma_Bc", SqlDbType.Int, 4)
                pMa_Bc.Value = Ma_Bc
                myCommand.Parameters.Add(pMa_Bc)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pHe_So_Khuyen_Mai As SqlParameter = New SqlParameter("@He_So_Khuyen_Mai", SqlDbType.Float)
                pHe_So_Khuyen_Mai.Value = He_So_Khuyen_Mai
                myCommand.Parameters.Add(pHe_So_Khuyen_Mai)

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
        ' Nội dung: Xóa dữ liệu từ bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai
        ' Output: 
        Public Sub Xoa(ByVal Id_Khuyen_Mai As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Khuyen_Mai As SqlParameter = New SqlParameter("@Id_Khuyen_Mai", SqlDbType.Int, 4)
                pId_Khuyen_Mai.Value = Id_Khuyen_Mai
                myCommand.Parameters.Add(pId_Khuyen_Mai)

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
        ' Nội dung: Xóa dữ liệu từ bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Xoa_Tat_Ca", myConnection)

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
        ' Nội dung: Xóa dữ liệu từ bảng Khuyen_Mai
        ' Input: Id_Khuyen_Mai
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khuyen_Mai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khuyen_Mai_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khuyen_Mai
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khuyen_Mai_Danh_Sach_Hien_Thi")
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
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Lay_Boi_Danh_Muc_BC", myConnection)
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
                myAdapter.Fill(myDataSet, "Khuyen_Mai_Lay_Boi_Danh_Muc_BC")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region
#Region "Lay_Boi_Ma_Nuoc"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Ma_Nuoc thông qua khóa chính 
        ' Input: Ma_Nuoc
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Ma_Nuoc(ByVal Ma_Nuoc As String, ByVal Ma_Bc_Khai_Thac As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khuyen_Mai_Lay_Boi_Ma_Nuoc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pMa_Bc_Khai_Thac As SqlParameter = New SqlParameter("@Ma_Bc_Khai_Thac", SqlDbType.Int)
                pMa_Bc_Khai_Thac.Value = Ma_Bc_Khai_Thac
                myCommand.Parameters.Add(pMa_Bc_Khai_Thac)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khuyen_Mai_Lay_Boi_Ma_Nuoc")
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

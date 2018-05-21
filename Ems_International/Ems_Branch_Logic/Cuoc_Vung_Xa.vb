
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Cuoc_Vung_Xa_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_Vung_Xa_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_Vung_Xa trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_Vung_Xa_Chi_Tiet
        Public Id_Cuoc_Vung_Xa As Integer
        Public Ma_Nuoc As String ' Mã Nước
        Public Vung_Duoi As String
        Public Vung_Tren As String
        Public Cuoc As Double
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Cuoc_Vung_Xa"
    Public Class Cuoc_Vung_Xa
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa
        ' Output: Cuoc_Vung_Xa_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Vung_Xa As Integer) As Cuoc_Vung_Xa_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Vung_Xa As SqlParameter = New SqlParameter("@Id_Cuoc_Vung_Xa", SqlDbType.Int, 4)
                pId_Cuoc_Vung_Xa.Value = Id_Cuoc_Vung_Xa
                myCommand.Parameters.Add(pId_Cuoc_Vung_Xa)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVung_Tren)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float)
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
                Dim myCuoc_Vung_Xa_Chi_Tiet As Cuoc_Vung_Xa_Chi_Tiet = New Cuoc_Vung_Xa_Chi_Tiet
                myCuoc_Vung_Xa_Chi_Tiet.Id_Cuoc_Vung_Xa = Id_Cuoc_Vung_Xa
                myCuoc_Vung_Xa_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myCuoc_Vung_Xa_Chi_Tiet.Vung_Duoi = pVung_Duoi.Value
                myCuoc_Vung_Xa_Chi_Tiet.Vung_Tren = pVung_Tren.Value
                myCuoc_Vung_Xa_Chi_Tiet.Cuoc = pCuoc.Value
                myCuoc_Vung_Xa_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_Vung_Xa_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myCuoc_Vung_Xa_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_Vung_Xa
        ' Input:  Ma_Nuoc, Vung_Duoi, Vung_Tren, Cuoc, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Cuoc As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float)
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
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa,  Ma_Nuoc , Vung_Duoi , Vung_Tren , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Vung_Xa As Integer, ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Cuoc As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Vung_Xa As SqlParameter = New SqlParameter("@Id_Cuoc_Vung_Xa", SqlDbType.Int, 4)
                pId_Cuoc_Vung_Xa.Value = Id_Cuoc_Vung_Xa
                myCommand.Parameters.Add(pId_Cuoc_Vung_Xa)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float)
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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_Vung_Xa
        ' Input: đối tượng thuộc lớp Cuoc_Vung_Xa_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_Vung_Xa_Chi_Tiet As Cuoc_Vung_Xa_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Vung_Xa As SqlParameter = New SqlParameter("@Id_Cuoc_Vung_Xa", SqlDbType.Int, 4)
                pId_Cuoc_Vung_Xa.Value = myCuoc_Vung_Xa_Chi_Tiet.Id_Cuoc_Vung_Xa
                myCommand.Parameters.Add(pId_Cuoc_Vung_Xa)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = myCuoc_Vung_Xa_Chi_Tiet.Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = myCuoc_Vung_Xa_Chi_Tiet.Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = myCuoc_Vung_Xa_Chi_Tiet.Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float)
                pCuoc.Value = myCuoc_Vung_Xa_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_Vung_Xa_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_Vung_Xa_Chi_Tiet.Den_Ngay
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa,  Ma_Nuoc , Vung_Duoi , Vung_Tren , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Vung_Xa As Integer, ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Cuoc As Decimal, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Vung_Xa As SqlParameter = New SqlParameter("@Id_Cuoc_Vung_Xa", SqlDbType.Int, 4)
                pId_Cuoc_Vung_Xa.Value = Id_Cuoc_Vung_Xa
                myCommand.Parameters.Add(pId_Cuoc_Vung_Xa)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Float)
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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Vung_Xa As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Vung_Xa As SqlParameter = New SqlParameter("@Id_Cuoc_Vung_Xa", SqlDbType.Int, 4)
                pId_Cuoc_Vung_Xa.Value = Id_Cuoc_Vung_Xa
                myCommand.Parameters.Add(pId_Cuoc_Vung_Xa)

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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Xoa_Tat_Ca", myConnection)

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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_Vung_Xa
        ' Input: Id_Cuoc_Vung_Xa
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Vung_Xa
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Vung_Xa_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_Vung_Xa
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Vung_Xa_Danh_Sach_Hien_Thi")
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
        Public Function Lay_Boi_Ma_Nuoc(ByVal Ma_Nuoc As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_Vung_Xa_Lay_Boi_Ma_Nuoc", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_Vung_Xa_Lay_Boi_Ma_Nuoc")
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

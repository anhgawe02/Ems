
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Cuoc_TCT_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_TCT_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_TCT trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_TCT_Chi_Tiet
        Public Id_Cuoc_TCT As Integer
        Public Cach_Tinh As Boolean ' 0: từ 1:tiếp
        Public Nac_Gui As Integer ' Nấc số tiền gửi
        Public Phan_Tram_Cuoc As Double ' Phần trăm theo số tiền gửi
        Public Cuoc_Toi_Thieu As Integer ' Cước tối thiểu phải thu
        Public Cuoc As Integer ' Cước
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Cuoc_TCT"
    Public Class Cuoc_TCT
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_TCT
        ' Input: Id_Cuoc_TCT
        ' Output: Cuoc_TCT_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_TCT As Integer) As Cuoc_TCT_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_TCT As SqlParameter = New SqlParameter("@Id_Cuoc_TCT", SqlDbType.Int, 4)
                pId_Cuoc_TCT.Value = Id_Cuoc_TCT
                myCommand.Parameters.Add(pId_Cuoc_TCT)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pNac_Gui As SqlParameter = New SqlParameter("@Nac_Gui", SqlDbType.Int, 4)
                pNac_Gui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNac_Gui)

                Dim pPhan_Tram_Cuoc As SqlParameter = New SqlParameter("@Phan_Tram_Cuoc", SqlDbType.Float)
                pPhan_Tram_Cuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Tram_Cuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

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
                Dim myCuoc_TCT_Chi_Tiet As Cuoc_TCT_Chi_Tiet = New Cuoc_TCT_Chi_Tiet
                myCuoc_TCT_Chi_Tiet.Id_Cuoc_TCT = Id_Cuoc_TCT
                myCuoc_TCT_Chi_Tiet.Cach_Tinh = pCach_Tinh.Value
                myCuoc_TCT_Chi_Tiet.Nac_Gui = pNac_Gui.Value
                myCuoc_TCT_Chi_Tiet.Phan_Tram_Cuoc = pPhan_Tram_Cuoc.Value
                myCuoc_TCT_Chi_Tiet.Cuoc_Toi_Thieu = pCuoc_Toi_Thieu.Value
                myCuoc_TCT_Chi_Tiet.Cuoc = pCuoc.Value
                myCuoc_TCT_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_TCT_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myCuoc_TCT_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_TCT
        ' Input:  Cach_Tinh, Nac_Gui, Phan_Tram_Cuoc, Cuoc_Toi_Thieu, Cuoc, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Cach_Tinh As Boolean, ByVal Nac_Gui As Integer, ByVal Phan_Tram_Cuoc As Double, ByVal Cuoc_Toi_Thieu As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pNac_Gui As SqlParameter = New SqlParameter("@Nac_Gui", SqlDbType.Int, 4)
                pNac_Gui.Value = Nac_Gui
                myCommand.Parameters.Add(pNac_Gui)

                Dim pPhan_Tram_Cuoc As SqlParameter = New SqlParameter("@Phan_Tram_Cuoc", SqlDbType.Float)
                pPhan_Tram_Cuoc.Value = Phan_Tram_Cuoc
                myCommand.Parameters.Add(pPhan_Tram_Cuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

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
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_TCT
        ' Input: Id_Cuoc_TCT,  Cach_Tinh , Nac_Gui , Phan_Tram_Cuoc , Cuoc_Toi_Thieu , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_TCT As Integer, ByVal Cach_Tinh As Boolean, ByVal Nac_Gui As Integer, ByVal Phan_Tram_Cuoc As Double, ByVal Cuoc_Toi_Thieu As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_TCT As SqlParameter = New SqlParameter("@Id_Cuoc_TCT", SqlDbType.Int, 4)
                pId_Cuoc_TCT.Value = Id_Cuoc_TCT
                myCommand.Parameters.Add(pId_Cuoc_TCT)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pNac_Gui As SqlParameter = New SqlParameter("@Nac_Gui", SqlDbType.Int, 4)
                pNac_Gui.Value = Nac_Gui
                myCommand.Parameters.Add(pNac_Gui)

                Dim pPhan_Tram_Cuoc As SqlParameter = New SqlParameter("@Phan_Tram_Cuoc", SqlDbType.Float)
                pPhan_Tram_Cuoc.Value = Phan_Tram_Cuoc
                myCommand.Parameters.Add(pPhan_Tram_Cuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_TCT
        ' Input: đối tượng thuộc lớp Cuoc_TCT_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_TCT_Chi_Tiet As Cuoc_TCT_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_TCT As SqlParameter = New SqlParameter("@Id_Cuoc_TCT", SqlDbType.Int, 4)
                pId_Cuoc_TCT.Value = myCuoc_TCT_Chi_Tiet.Id_Cuoc_TCT
                myCommand.Parameters.Add(pId_Cuoc_TCT)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = myCuoc_TCT_Chi_Tiet.Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pNac_Gui As SqlParameter = New SqlParameter("@Nac_Gui", SqlDbType.Int, 4)
                pNac_Gui.Value = myCuoc_TCT_Chi_Tiet.Nac_Gui
                myCommand.Parameters.Add(pNac_Gui)

                Dim pPhan_Tram_Cuoc As SqlParameter = New SqlParameter("@Phan_Tram_Cuoc", SqlDbType.Float)
                pPhan_Tram_Cuoc.Value = myCuoc_TCT_Chi_Tiet.Phan_Tram_Cuoc
                myCommand.Parameters.Add(pPhan_Tram_Cuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = myCuoc_TCT_Chi_Tiet.Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Int, 4)
                pCuoc.Value = myCuoc_TCT_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_TCT_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_TCT_Chi_Tiet.Den_Ngay
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_TCT
        ' Input: Id_Cuoc_TCT,  Cach_Tinh , Nac_Gui , Phan_Tram_Cuoc , Cuoc_Toi_Thieu , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_TCT As Integer, ByVal Cach_Tinh As Boolean, ByVal Nac_Gui As Integer, ByVal Phan_Tram_Cuoc As Double, ByVal Cuoc_Toi_Thieu As Integer, ByVal Cuoc As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_TCT As SqlParameter = New SqlParameter("@Id_Cuoc_TCT", SqlDbType.Int, 4)
                pId_Cuoc_TCT.Value = Id_Cuoc_TCT
                myCommand.Parameters.Add(pId_Cuoc_TCT)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pNac_Gui As SqlParameter = New SqlParameter("@Nac_Gui", SqlDbType.Int, 4)
                pNac_Gui.Value = Nac_Gui
                myCommand.Parameters.Add(pNac_Gui)

                Dim pPhan_Tram_Cuoc As SqlParameter = New SqlParameter("@Phan_Tram_Cuoc", SqlDbType.Float)
                pPhan_Tram_Cuoc.Value = Phan_Tram_Cuoc
                myCommand.Parameters.Add(pPhan_Tram_Cuoc)

                Dim pCuoc_Toi_Thieu As SqlParameter = New SqlParameter("@Cuoc_Toi_Thieu", SqlDbType.Int, 4)
                pCuoc_Toi_Thieu.Value = Cuoc_Toi_Thieu
                myCommand.Parameters.Add(pCuoc_Toi_Thieu)

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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_TCT
        ' Input: Id_Cuoc_TCT
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_TCT As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_TCT As SqlParameter = New SqlParameter("@Id_Cuoc_TCT", SqlDbType.Int, 4)
                pId_Cuoc_TCT.Value = Id_Cuoc_TCT
                myCommand.Parameters.Add(pId_Cuoc_TCT)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_TCT
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_TCT_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_TCT
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_TCT_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_TCT_Danh_Sach_Hien_Thi")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Kiem_Tra_Cach_Tinh"
        Public Function Kiem_Tra_Cach_Tinh() As Integer
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand
            Dim ReturnValue As String
            myCommand = New SqlCommand("Select count(*) from  Cuoc_TCT where Cach_Tinh=1", myConnection)
            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, "", myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
    End Class
#End Region
End Namespace

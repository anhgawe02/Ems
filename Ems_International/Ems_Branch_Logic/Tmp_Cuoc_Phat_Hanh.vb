
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Cuoc_Phat_Hanh_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Cuoc_Phat_Hanh_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Cuoc_Phat_Hanh trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Cuoc_Phat_Hanh_Chi_Tiet
        Public Id_Cuoc_Phat As Integer
        Public Ma_Tinh As Integer
        Public Cuoc_NT As Double
        Public Cuoc_LT As Double
        Public Cuoc_QT As Double
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Tmp_Cuoc_Phat_Hanh"
    Public Class Tmp_Cuoc_Phat_Hanh
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Cuoc_Phat_Hanh
        ' Input: Id_Cuoc_Phat
        ' Output: Tmp_Cuoc_Phat_Hanh_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_Phat As Integer) As Tmp_Cuoc_Phat_Hanh_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pCuoc_NT As SqlParameter = New SqlParameter("@Cuoc_NT", SqlDbType.Float)
                pCuoc_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_NT)

                Dim pCuoc_LT As SqlParameter = New SqlParameter("@Cuoc_LT", SqlDbType.Float)
                pCuoc_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_LT)

                Dim pCuoc_QT As SqlParameter = New SqlParameter("@Cuoc_QT", SqlDbType.Float)
                pCuoc_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCuoc_QT)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                Dim myTmp_Cuoc_Phat_Hanh_Chi_Tiet As Tmp_Cuoc_Phat_Hanh_Chi_Tiet = New Tmp_Cuoc_Phat_Hanh_Chi_Tiet
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Id_Cuoc_Phat = Id_Cuoc_Phat
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_NT = pCuoc_NT.Value
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_LT = pCuoc_LT.Value
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_QT = pCuoc_QT.Value
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myTmp_Cuoc_Phat_Hanh_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Cuoc_Phat_Hanh
        ' Input:  Ma_Tinh, Cuoc_NT, Cuoc_LT, Cuoc_QT, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Tinh As Integer, ByVal Cuoc_NT As Double, ByVal Cuoc_LT As Double, ByVal Cuoc_QT As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pCuoc_NT As SqlParameter = New SqlParameter("@Cuoc_NT", SqlDbType.Float)
                pCuoc_NT.Value = Cuoc_NT
                myCommand.Parameters.Add(pCuoc_NT)

                Dim pCuoc_LT As SqlParameter = New SqlParameter("@Cuoc_LT", SqlDbType.Float)
                pCuoc_LT.Value = Cuoc_LT
                myCommand.Parameters.Add(pCuoc_LT)

                Dim pCuoc_QT As SqlParameter = New SqlParameter("@Cuoc_QT", SqlDbType.Float)
                pCuoc_QT.Value = Cuoc_QT
                myCommand.Parameters.Add(pCuoc_QT)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Phat_Hanh
        ' Input: Id_Cuoc_Phat,  Ma_Tinh , Cuoc_NT , Cuoc_LT , Cuoc_QT , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_Phat As Integer, ByVal Ma_Tinh As Integer, ByVal Cuoc_NT As Double, ByVal Cuoc_LT As Double, ByVal Cuoc_QT As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pCuoc_NT As SqlParameter = New SqlParameter("@Cuoc_NT", SqlDbType.Float)
                pCuoc_NT.Value = Cuoc_NT
                myCommand.Parameters.Add(pCuoc_NT)

                Dim pCuoc_LT As SqlParameter = New SqlParameter("@Cuoc_LT", SqlDbType.Float)
                pCuoc_LT.Value = Cuoc_LT
                myCommand.Parameters.Add(pCuoc_LT)

                Dim pCuoc_QT As SqlParameter = New SqlParameter("@Cuoc_QT", SqlDbType.Float)
                pCuoc_QT.Value = Cuoc_QT
                myCommand.Parameters.Add(pCuoc_QT)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_Phat_Hanh
        ' Input: đối tượng thuộc lớp Tmp_Cuoc_Phat_Hanh_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Cuoc_Phat_Hanh_Chi_Tiet As Tmp_Cuoc_Phat_Hanh_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pCuoc_NT As SqlParameter = New SqlParameter("@Cuoc_NT", SqlDbType.Float)
                pCuoc_NT.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_NT
                myCommand.Parameters.Add(pCuoc_NT)

                Dim pCuoc_LT As SqlParameter = New SqlParameter("@Cuoc_LT", SqlDbType.Float)
                pCuoc_LT.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_LT
                myCommand.Parameters.Add(pCuoc_LT)

                Dim pCuoc_QT As SqlParameter = New SqlParameter("@Cuoc_QT", SqlDbType.Float)
                pCuoc_QT.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Cuoc_QT
                myCommand.Parameters.Add(pCuoc_QT)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myTmp_Cuoc_Phat_Hanh_Chi_Tiet.Den_Ngay
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Cuoc_Phat_Hanh
        ' Input: Id_Cuoc_Phat,  Ma_Tinh , Cuoc_NT , Cuoc_LT , Cuoc_QT , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_Phat As Integer, ByVal Ma_Tinh As Integer, ByVal Cuoc_NT As Double, ByVal Cuoc_LT As Double, ByVal Cuoc_QT As Double, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_Phat As SqlParameter = New SqlParameter("@Id_Cuoc_Phat", SqlDbType.Int, 4)
                pId_Cuoc_Phat.Value = Id_Cuoc_Phat
                myCommand.Parameters.Add(pId_Cuoc_Phat)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pCuoc_NT As SqlParameter = New SqlParameter("@Cuoc_NT", SqlDbType.Float)
                pCuoc_NT.Value = Cuoc_NT
                myCommand.Parameters.Add(pCuoc_NT)

                Dim pCuoc_LT As SqlParameter = New SqlParameter("@Cuoc_LT", SqlDbType.Float)
                pCuoc_LT.Value = Cuoc_LT
                myCommand.Parameters.Add(pCuoc_LT)

                Dim pCuoc_QT As SqlParameter = New SqlParameter("@Cuoc_QT", SqlDbType.Float)
                pCuoc_QT.Value = Cuoc_QT
                myCommand.Parameters.Add(pCuoc_QT)

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
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Cuoc_Phat_Hanh
        ' Input: Id_Cuoc_Phat
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_Phat As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Xoa", myConnection)

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
                Console.Write(ex.ToString)


            End Try
        End Sub
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Phat_Hanh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Phat_Hanh_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_Phat_Hanh
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_Phat_Hanh_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_Phat_Hanh_Danh_Sach_Hien_Thi")
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
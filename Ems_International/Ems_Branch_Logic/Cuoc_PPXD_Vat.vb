
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Cuoc_PPXD_Vat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_PPXD_Vat_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_PPXD_Vat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_PPXD_Vat_Chi_Tiet
        Public Id_Cuoc_PPXD_Vat As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
        Public VAT As Double ' Phần trăm thuế VAT
        Public PPXD_QT As Double ' Phần trăm phụ phí xăng dầu với BP quốc tế
        Public PPXD_TN_LT As Double ' Phần trăm phụ phí xăng dầu với BP liên tỉnh
        Public PPXD_TN_NT As Double ' Phần trăm phụ phí xăng dầu với BP nội tỉnh
    End Class
#End Region
#Region "Cuoc_PPXD_Vat"
    Public Class Cuoc_PPXD_Vat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: Cuoc_PPXD_Vat_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_PPXD_Vat As Integer) As Cuoc_PPXD_Vat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPPXD_TN_NT)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myCuoc_PPXD_Vat_Chi_Tiet As Cuoc_PPXD_Vat_Chi_Tiet = New Cuoc_PPXD_Vat_Chi_Tiet
                myCuoc_PPXD_Vat_Chi_Tiet.Id_Cuoc_PPXD_Vat = Id_Cuoc_PPXD_Vat
                myCuoc_PPXD_Vat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_PPXD_Vat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                myCuoc_PPXD_Vat_Chi_Tiet.VAT = pVAT.Value
                myCuoc_PPXD_Vat_Chi_Tiet.PPXD_QT = pPPXD_QT.Value
                myCuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_LT = pPPXD_TN_LT.Value
                myCuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_NT = pPPXD_TN_NT.Value
                Return myCuoc_PPXD_Vat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_PPXD_Vat
        ' Input:  Tu_Ngay, Den_Ngay, VAT, PPXD_QT, PPXD_TN_LT, PPXD_TN_NT,
        ' Output: 
        Public Sub Them(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Value = PPXD_QT
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Value = PPXD_TN_LT
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Value = PPXD_TN_NT
                myCommand.Parameters.Add(pPPXD_TN_NT)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat,  Tu_Ngay , Den_Ngay , VAT , PPXD_QT , PPXD_TN_LT , PPXD_TN_NT ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_PPXD_Vat As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Value = PPXD_QT
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Value = PPXD_TN_LT
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Value = PPXD_TN_NT
                myCommand.Parameters.Add(pPPXD_TN_NT)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_PPXD_Vat
        ' Input: đối tượng thuộc lớp Cuoc_PPXD_Vat_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_PPXD_Vat_Chi_Tiet As Cuoc_PPXD_Vat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = myCuoc_PPXD_Vat_Chi_Tiet.Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_PPXD_Vat_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_PPXD_Vat_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = myCuoc_PPXD_Vat_Chi_Tiet.VAT
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Value = myCuoc_PPXD_Vat_Chi_Tiet.PPXD_QT
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Value = myCuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_LT
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Value = myCuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_NT
                myCommand.Parameters.Add(pPPXD_TN_NT)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat,  Tu_Ngay , Den_Ngay , VAT , PPXD_QT , PPXD_TN_LT , PPXD_TN_NT ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_PPXD_Vat As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = VAT
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Value = PPXD_QT
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Value = PPXD_TN_LT
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Value = PPXD_TN_NT
                myCommand.Parameters.Add(pPPXD_TN_NT)


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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_PPXD_Vat As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: 
        Public Sub Xoa_Tat_Ca()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Xoa_Tat_Ca", myConnection)

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
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: 
        Public Sub Lay_Tat_Ca_Tu_Tmp()
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Lay_Tat_Ca_Tu_Tmp", myConnection)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_PPXD_Vat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_PPXD_Vat_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_PPXD_Vat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_PPXD_Vat_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_PPXD_Vat_Danh_Sach_Hien_Thi")
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

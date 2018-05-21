
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Tmp_Cuoc_PPXD_Vat_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Tmp_Cuoc_PPXD_Vat_Chi_Tiet
    ' tương ứng với mộ trường của bảng Tmp_Cuoc_PPXD_Vat trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Tmp_Cuoc_PPXD_Vat_Chi_Tiet
        Public Id_Cuoc_PPXD_Vat As Integer
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
        Public VAT As Double
        Public PPXD_QT As Double
        Public PPXD_TN_LT As Double
        Public PPXD_TN_NT As Double
    End Class
#End Region
#Region "Tmp_Cuoc_PPXD_Vat"
    Public Class Tmp_Cuoc_PPXD_Vat
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Tmp_Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: Tmp_Cuoc_PPXD_Vat_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_PPXD_Vat As Integer) As Tmp_Cuoc_PPXD_Vat_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Lay", myConnection)

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
                Dim myTmp_Cuoc_PPXD_Vat_Chi_Tiet As Tmp_Cuoc_PPXD_Vat_Chi_Tiet = New Tmp_Cuoc_PPXD_Vat_Chi_Tiet
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Id_Cuoc_PPXD_Vat = Id_Cuoc_PPXD_Vat
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.VAT = pVAT.Value
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_QT = pPPXD_QT.Value
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_LT = pPPXD_TN_LT.Value
                myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_NT = pPPXD_TN_NT.Value
                Return myTmp_Cuoc_PPXD_Vat_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Tmp_Cuoc_PPXD_Vat
        ' Input:  Tu_Ngay, Den_Ngay, VAT, PPXD_QT, PPXD_TN_LT, PPXD_TN_NT,
        ' Output: 
        Public Sub Them(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat,  Tu_Ngay , Den_Ngay , VAT , PPXD_QT , PPXD_TN_LT , PPXD_TN_NT ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_PPXD_Vat As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Cap_Nhat", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Cap_Nhat"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật dữ liệu vào bảng Tmp_Cuoc_PPXD_Vat
        ' Input: đối tượng thuộc lớp Tmp_Cuoc_PPXD_Vat_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myTmp_Cuoc_PPXD_Vat_Chi_Tiet As Tmp_Cuoc_PPXD_Vat_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                Dim pVAT As SqlParameter = New SqlParameter("@VAT", SqlDbType.Float)
                pVAT.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.VAT
                myCommand.Parameters.Add(pVAT)

                Dim pPPXD_QT As SqlParameter = New SqlParameter("@PPXD_QT", SqlDbType.Float)
                pPPXD_QT.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_QT
                myCommand.Parameters.Add(pPPXD_QT)

                Dim pPPXD_TN_LT As SqlParameter = New SqlParameter("@PPXD_TN_LT", SqlDbType.Float)
                pPPXD_TN_LT.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_LT
                myCommand.Parameters.Add(pPPXD_TN_LT)

                Dim pPPXD_TN_NT As SqlParameter = New SqlParameter("@PPXD_TN_NT", SqlDbType.Float)
                pPPXD_TN_NT.Value = myTmp_Cuoc_PPXD_Vat_Chi_Tiet.PPXD_TN_NT
                myCommand.Parameters.Add(pPPXD_TN_NT)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Tmp_Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat,  Tu_Ngay , Den_Ngay , VAT , PPXD_QT , PPXD_TN_LT , PPXD_TN_NT ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_PPXD_Vat As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal VAT As Double, ByVal PPXD_QT As Double, ByVal PPXD_TN_LT As Double, ByVal PPXD_TN_NT As Double)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Cap_Nhat_Them", myConnection)

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
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Tmp_Cuoc_PPXD_Vat
        ' Input: Id_Cuoc_PPXD_Vat
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_PPXD_Vat As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_PPXD_Vat As SqlParameter = New SqlParameter("@Id_Cuoc_PPXD_Vat", SqlDbType.Int, 4)
                pId_Cuoc_PPXD_Vat.Value = Id_Cuoc_PPXD_Vat
                myCommand.Parameters.Add(pId_Cuoc_PPXD_Vat)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_PPXD_Vat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_PPXD_Vat_Danh_Sach")
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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Tmp_Cuoc_PPXD_Vat
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Tmp_Cuoc_PPXD_Vat_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Tmp_Cuoc_PPXD_Vat_Danh_Sach_Hien_Thi")
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
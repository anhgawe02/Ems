
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Cuoc_QT_Dac_Biet_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Cuoc_QT_Dac_Biet_Chi_Tiet
    ' tương ứng với mộ trường của bảng Cuoc_QT_Dac_Biet trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Cuoc_QT_Dac_Biet_Chi_Tiet
        Public Id_Cuoc_QT As Integer
        Public Ma_Nuoc As String
        Public Vung_Duoi As String
        Public Vung_Tren As String
        Public Phan_Loai_BP As String
        Public Cach_Tinh As Boolean
        Public Khoi_Luong As Integer
        Public Cuoc As Decimal
        Public Tu_Ngay As Integer
        Public Den_Ngay As Integer
    End Class
#End Region
#Region "Cuoc_QT_Dac_Biet"
    Public Class Cuoc_QT_Dac_Biet
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Cuoc_QT_Dac_Biet
        ' Input: Id_Cuoc_QT
        ' Output: Cuoc_QT_Dac_Biet_Chi_Tiet
        Public Function Lay(ByVal Id_Cuoc_QT As Integer) As Cuoc_QT_Dac_Biet_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                pId_Cuoc_QT.Value = Id_Cuoc_QT
                myCommand.Parameters.Add(pId_Cuoc_QT)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVung_Tren)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
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
                Dim myCuoc_QT_Dac_Biet_Chi_Tiet As Cuoc_QT_Dac_Biet_Chi_Tiet = New Cuoc_QT_Dac_Biet_Chi_Tiet
                myCuoc_QT_Dac_Biet_Chi_Tiet.Id_Cuoc_QT = Id_Cuoc_QT
                myCuoc_QT_Dac_Biet_Chi_Tiet.Ma_Nuoc = pMa_Nuoc.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Vung_Duoi = pVung_Duoi.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Vung_Tren = pVung_Tren.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Phan_Loai_BP = pPhan_Loai_BP.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Cach_Tinh = pCach_Tinh.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Khoi_Luong = pKhoi_Luong.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Cuoc = pCuoc.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Tu_Ngay = pTu_Ngay.Value
                myCuoc_QT_Dac_Biet_Chi_Tiet.Den_Ngay = pDen_Ngay.Value
                Return myCuoc_QT_Dac_Biet_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Cuoc_QT_Dac_Biet
        ' Input:  Ma_Nuoc, Vung_Duoi, Vung_Tren, Phan_Loai_BP, Cach_Tinh, Khoi_Luong, Cuoc, Tu_Ngay, Den_Ngay,
        ' Output: 
        Public Sub Them(ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Phan_Loai_BP As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Decimal, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Them", myConnection)

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

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_QT_Dac_Biet
        ' Input: Id_Cuoc_QT,  Ma_Nuoc , Vung_Duoi , Vung_Tren , Phan_Loai_BP , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Cuoc_QT As Integer, ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Phan_Loai_BP As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Decimal, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                pId_Cuoc_QT.Value = Id_Cuoc_QT
                myCommand.Parameters.Add(pId_Cuoc_QT)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
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
        ' Nội dung: Cập nhật dữ liệu vào bảng Cuoc_QT_Dac_Biet
        ' Input: đối tượng thuộc lớp Cuoc_QT_Dac_Biet_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myCuoc_QT_Dac_Biet_Chi_Tiet As Cuoc_QT_Dac_Biet_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                pId_Cuoc_QT.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Id_Cuoc_QT
                myCommand.Parameters.Add(pId_Cuoc_QT)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
                pCuoc.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Cuoc
                myCommand.Parameters.Add(pCuoc)

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int, 4)
                pTu_Ngay.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int, 4)
                pDen_Ngay.Value = myCuoc_QT_Dac_Biet_Chi_Tiet.Den_Ngay
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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_QT_Dac_Biet
        ' Input: Id_Cuoc_QT,  Ma_Nuoc , Vung_Duoi , Vung_Tren , Phan_Loai_BP , Cach_Tinh , Khoi_Luong , Cuoc , Tu_Ngay , Den_Ngay ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Cuoc_QT As Integer, ByVal Ma_Nuoc As String, ByVal Vung_Duoi As String, ByVal Vung_Tren As String, ByVal Phan_Loai_BP As String, ByVal Cach_Tinh As Boolean, ByVal Khoi_Luong As Integer, ByVal Cuoc As Decimal, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                pId_Cuoc_QT.Value = Id_Cuoc_QT
                myCommand.Parameters.Add(pId_Cuoc_QT)

                Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                pMa_Nuoc.Value = Ma_Nuoc
                myCommand.Parameters.Add(pMa_Nuoc)

                Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                pVung_Duoi.Value = Vung_Duoi
                myCommand.Parameters.Add(pVung_Duoi)

                Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                pVung_Tren.Value = Vung_Tren
                myCommand.Parameters.Add(pVung_Tren)

                Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                pPhan_Loai_BP.Value = Phan_Loai_BP
                myCommand.Parameters.Add(pPhan_Loai_BP)

                Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                pCach_Tinh.Value = Cach_Tinh
                myCommand.Parameters.Add(pCach_Tinh)

                Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                pKhoi_Luong.Value = Khoi_Luong
                myCommand.Parameters.Add(pKhoi_Luong)

                Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
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
#Region "Cap_Nhat_Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Cuoc_QT_Dac_Biet
        ' Input: đối tượng datatable
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal myDataTable As DataTable)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                myConnection.Open()
                Dim i As Integer
                For i = 0 To myDataTable.Rows.Count - 1
                    Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Cap_Nhat_Them", myConnection)

                    ' Sử dụng Store Procedure
                    myCommand.CommandType = CommandType.StoredProcedure
                    ' Thêm các Parameters vào thủ tục				

                    Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                    pId_Cuoc_QT.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Id_Cuoc_QT"))
                    myCommand.Parameters.Add(pId_Cuoc_QT)

                    Dim pMa_Nuoc As SqlParameter = New SqlParameter("@Ma_Nuoc", SqlDbType.VarChar, 2)
                    pMa_Nuoc.Value = Convert.ToString(myDataTable.Rows(i).Item("Ma_Nuoc"))
                    myCommand.Parameters.Add(pMa_Nuoc)

                    Dim pVung_Duoi As SqlParameter = New SqlParameter("@Vung_Duoi", SqlDbType.VarChar, 50)
                    pVung_Duoi.Value = Convert.ToString(myDataTable.Rows(i).Item("Vung_Duoi"))
                    myCommand.Parameters.Add(pVung_Duoi)

                    Dim pVung_Tren As SqlParameter = New SqlParameter("@Vung_Tren", SqlDbType.VarChar, 50)
                    pVung_Tren.Value = Convert.ToString(myDataTable.Rows(i).Item("Vung_Tren"))
                    myCommand.Parameters.Add(pVung_Tren)

                    Dim pPhan_Loai_BP As SqlParameter = New SqlParameter("@Phan_Loai_BP", SqlDbType.VarChar, 1)
                    pPhan_Loai_BP.Value = Convert.ToString(myDataTable.Rows(i).Item("Phan_Loai_BP"))
                    myCommand.Parameters.Add(pPhan_Loai_BP)

                    Dim pCach_Tinh As SqlParameter = New SqlParameter("@Cach_Tinh", SqlDbType.Bit, 1)
                    pCach_Tinh.Value = Convert.ToBoolean(myDataTable.Rows(i).Item("Cach_Tinh"))
                    myCommand.Parameters.Add(pCach_Tinh)

                    Dim pKhoi_Luong As SqlParameter = New SqlParameter("@Khoi_Luong", SqlDbType.Int, 4)
                    pKhoi_Luong.Value = Convert.ToInt32(myDataTable.Rows(i).Item("Khoi_Luong"))
                    myCommand.Parameters.Add(pKhoi_Luong)

                    Dim pCuoc As SqlParameter = New SqlParameter("@Cuoc", SqlDbType.Decimal, 18, 2)
                    pCuoc.Value = Convert.ToDecimal(myDataTable.Rows(i).Item("Cuoc"))
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
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Cuoc_QT_Dac_Biet
        ' Input: Id_Cuoc_QT
        ' Output: 
        Public Sub Xoa(ByVal Id_Cuoc_QT As Integer)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Cuoc_QT As SqlParameter = New SqlParameter("@Id_Cuoc_QT", SqlDbType.Int, 4)
                pId_Cuoc_QT.Value = Id_Cuoc_QT
                myCommand.Parameters.Add(pId_Cuoc_QT)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Cuoc_QT_Dac_Biet
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Cuoc_QT_Dac_Biet_Danh_Sach")
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
                Dim myCommand As SqlCommand = New SqlCommand("Cuoc_QT_Dac_Biet_Lay_Boi_Ma_Nuoc", myConnection)
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
                myAdapter.Fill(myDataSet, "Cuoc_QT_Dac_Biet_Lay_Boi_Ma_Nuoc")
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
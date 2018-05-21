
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Khach_Hang_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Khach_Hang_Chi_Tiet
    ' tương ứng với mộ trường của bảng Khach_Hang trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Khach_Hang_Chi_Tiet
        Public Ma_KH As String
        Public Ten_Khach_Hang As String ' Tên khách hàng
        Public Ngay_Khoi_Tao As Integer ' Ngày khởi tạo
        Public Ngay_Ket_Thuc As Integer ' Ngày kết thúc
        Public Dien_Thoai As String ' Điện thoại khách hàng
        Public Fax As String ' Số Fax
        Public Email As String
        Public Dia_Chi As String ' Địa chỉ khách hàng
        Public Ma_So_Thue As String ' Mã số thuế
        Public Vat As Double ' % Vat khách hàng phải chịu
        Public Khach_Hang_Toan_Quoc As Boolean ' Là khách hàng toàn quốc
        Public Truyen_Khai_Thac As Boolean ' Truyền số liệu khách hàng lên công ty
    End Class
#End Region
#Region "Khach_Hang"
    Public Class Khach_Hang
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Khach_Hang
        ' Input: Ma_KH
        ' Output: Khach_Hang_Chi_Tiet
        Public Function Lay(ByVal Ma_KH As String) As Khach_Hang_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 4)
                pNgay_Khoi_Tao.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 4)
                pNgay_Ket_Thuc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 1)
                pKhach_Hang_Toan_Quoc.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTruyen_Khai_Thac)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myKhach_Hang_Chi_Tiet As Khach_Hang_Chi_Tiet = New Khach_Hang_Chi_Tiet
                myKhach_Hang_Chi_Tiet.Ma_KH = Ma_KH
                myKhach_Hang_Chi_Tiet.Ten_Khach_Hang = pTen_Khach_Hang.Value
                myKhach_Hang_Chi_Tiet.Ngay_Khoi_Tao = pNgay_Khoi_Tao.Value
                myKhach_Hang_Chi_Tiet.Ngay_Ket_Thuc = pNgay_Ket_Thuc.Value
                myKhach_Hang_Chi_Tiet.Dien_Thoai = pDien_Thoai.Value
                myKhach_Hang_Chi_Tiet.Fax = pFax.Value
                myKhach_Hang_Chi_Tiet.Email = pEmail.Value
                myKhach_Hang_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                myKhach_Hang_Chi_Tiet.Ma_So_Thue = pMa_So_Thue.Value
                myKhach_Hang_Chi_Tiet.Vat = pVat.Value
                myKhach_Hang_Chi_Tiet.Khach_Hang_Toan_Quoc = pKhach_Hang_Toan_Quoc.Value
                myKhach_Hang_Chi_Tiet.Truyen_Khai_Thac = pTruyen_Khai_Thac.Value
                Return myKhach_Hang_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Khach_Hang
        ' Input:  Ten_Khach_Hang, Ngay_Khoi_Tao, Ngay_Ket_Thuc, Dien_Thoai, Fax, Email, Dia_Chi, Ma_So_Thue, Vat, Khach_Hang_Toan_Quoc, Truyen_Khai_Thac,
        ' Output: 
        Public Sub Them(ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 4)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                myCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 4)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                myCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 1)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                myCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khach_Hang
        ' Input: Ma_KH,  Ten_Khach_Hang , Ngay_Khoi_Tao , Ngay_Ket_Thuc , Dien_Thoai , Fax , Email , Dia_Chi , Ma_So_Thue , Vat , Khach_Hang_Toan_Quoc , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Ma_KH As String, ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 4)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                myCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 4)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                myCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 1)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                myCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Khach_Hang
        ' Input: đối tượng thuộc lớp Khach_Hang_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myKhach_Hang_Chi_Tiet As Khach_Hang_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = myKhach_Hang_Chi_Tiet.Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = myKhach_Hang_Chi_Tiet.Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 4)
                pNgay_Khoi_Tao.Value = myKhach_Hang_Chi_Tiet.Ngay_Khoi_Tao
                myCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 4)
                pNgay_Ket_Thuc.Value = myKhach_Hang_Chi_Tiet.Ngay_Ket_Thuc
                myCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = myKhach_Hang_Chi_Tiet.Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = myKhach_Hang_Chi_Tiet.Fax
                myCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = myKhach_Hang_Chi_Tiet.Email
                myCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = myKhach_Hang_Chi_Tiet.Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = myKhach_Hang_Chi_Tiet.Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Value = myKhach_Hang_Chi_Tiet.Vat
                myCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 1)
                pKhach_Hang_Toan_Quoc.Value = myKhach_Hang_Chi_Tiet.Khach_Hang_Toan_Quoc
                myCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = myKhach_Hang_Chi_Tiet.Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Khach_Hang
        ' Input: Ma_KH,  Ten_Khach_Hang , Ngay_Khoi_Tao , Ngay_Ket_Thuc , Dien_Thoai , Fax , Email , Dia_Chi , Ma_So_Thue , Vat , Khach_Hang_Toan_Quoc , Truyen_Khai_Thac ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Ma_KH As String, ByVal Ten_Khach_Hang As String, ByVal Ngay_Khoi_Tao As Integer, ByVal Ngay_Ket_Thuc As Integer, ByVal Dien_Thoai As String, ByVal Fax As String, ByVal Email As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Vat As Double, ByVal Khach_Hang_Toan_Quoc As Boolean, ByVal Truyen_Khai_Thac As Boolean)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 200)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pNgay_Khoi_Tao As SqlParameter = New SqlParameter("@Ngay_Khoi_Tao", SqlDbType.Int, 4)
                pNgay_Khoi_Tao.Value = Ngay_Khoi_Tao
                myCommand.Parameters.Add(pNgay_Khoi_Tao)

                Dim pNgay_Ket_Thuc As SqlParameter = New SqlParameter("@Ngay_Ket_Thuc", SqlDbType.Int, 4)
                pNgay_Ket_Thuc.Value = Ngay_Ket_Thuc
                myCommand.Parameters.Add(pNgay_Ket_Thuc)

                Dim pDien_Thoai As SqlParameter = New SqlParameter("@Dien_Thoai", SqlDbType.VarChar, 50)
                pDien_Thoai.Value = Dien_Thoai
                myCommand.Parameters.Add(pDien_Thoai)

                Dim pFax As SqlParameter = New SqlParameter("@Fax", SqlDbType.VarChar, 50)
                pFax.Value = Fax
                myCommand.Parameters.Add(pFax)

                Dim pEmail As SqlParameter = New SqlParameter("@Email", SqlDbType.VarChar, 50)
                pEmail.Value = Email
                myCommand.Parameters.Add(pEmail)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 200)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Float)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKhach_Hang_Toan_Quoc As SqlParameter = New SqlParameter("@Khach_Hang_Toan_Quoc", SqlDbType.Bit, 1)
                pKhach_Hang_Toan_Quoc.Value = Khach_Hang_Toan_Quoc
                myCommand.Parameters.Add(pKhach_Hang_Toan_Quoc)

                Dim pTruyen_Khai_Thac As SqlParameter = New SqlParameter("@Truyen_Khai_Thac", SqlDbType.Bit, 1)
                pTruyen_Khai_Thac.Value = Truyen_Khai_Thac
                myCommand.Parameters.Add(pTruyen_Khai_Thac)


                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)
            End Try
        End Sub
#End Region
#Region "Xoa"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Xóa dữ liệu từ bảng Khach_Hang
        ' Input: Ma_KH
        ' Output: 
        Public Sub Xoa(ByVal Ma_KH As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Kiem tra Ma_Khach_Hang"
        ' Ngày tạo: 27/6/08
        ' Người tạo: Nguyễn Đức Trung
        ' Nội dung: Kiểm tra sự tồn tại
        ' Output: count(*)
        Public Function Chk_Ma_KH(ByVal Ma_KH As String) As Boolean

            Dim ReturnValue As Boolean
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
            Dim myCommand As SqlCommand

            myCommand = New SqlCommand("Select count(*) from Khach_Hang where (Ma_KH= '" & Ma_KH & "') ", myConnection)

            myConnection.Open()
            myCommand.CommandType = CommandType.Text
            myAdapter.SelectCommand = myCommand
            ReturnValue = IIf(myCommand.ExecuteScalar Is System.DBNull.Value, 0, myCommand.ExecuteScalar)
            myConnection.Close()
myConnection.Dispose()
            Return ReturnValue
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khach_Hang
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khach_Hang_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Khach_Hang
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Hien_Thi() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Khach_Hang_Danh_Sach_Hien_Thi", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Khach_Hang_Danh_Sach")
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

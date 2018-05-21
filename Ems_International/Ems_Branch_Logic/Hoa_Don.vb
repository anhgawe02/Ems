
Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Hoa_Don_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Hoa_Don_Chi_Tiet
    ' tương ứng với mộ trường của bảng Hoa_Don trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Hoa_Don_Chi_Tiet
        Public Id_Hoa_Don As String
        Public So_Seri As String ' Số seri của hóa đơn
        Public So_Hoa_Don As String ' Số hóa đơn
        Public Ten_Khach_Hang As String ' tên khách hàng
        Public Dia_Chi As String ' Địa chỉ khách hàng
        Public Ma_So_Thue As String ' Mã số thuế của khách hàng
        Public Ma_KH As String ' Mã khách hàng
        Public Ngay_Xuat As Integer ' Ngày xuất hóa đơn
        Public Ngay_Nop As Integer ' Ngày nộp tiền
        Public Gia_Tri As Integer ' Giá trị của hóa đơn (sau thuế)
        Public Vat As Integer ' % Vat của hóa đơn (0,5,10)
        Public Kieu_Thanh_Toan As String ' Kiểu thanh toán (TM:tiền mặt, CK:chuyển khoản)
        Public Da_Tra As Boolean ' Khách hàng đã trả hay chưa?
        Public Ghi_Chu As String ' Ghi chú
    End Class
#End Region
#Region "Hoa_Don"
    Public Class Hoa_Don
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Hoa_Don
        ' Input: Id_Hoa_Don
        ' Output: Hoa_Don_Chi_Tiet
        Public Function Lay(ByVal Id_Hoa_Don As String) As Hoa_Don_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Seri)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.VarChar, 6)
                pSo_Hoa_Don.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 150)
                pTen_Khach_Hang.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 300)
                pDia_Chi.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH)

                Dim pNgay_Xuat As SqlParameter = New SqlParameter("@Ngay_Xuat", SqlDbType.Int, 4)
                pNgay_Xuat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Xuat)

                Dim pNgay_Nop As SqlParameter = New SqlParameter("@Ngay_Nop", SqlDbType.Int, 4)
                pNgay_Nop.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Nop)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGia_Tri)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Int, 4)
                pVat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pVat)

                Dim pKieu_Thanh_Toan As SqlParameter = New SqlParameter("@Kieu_Thanh_Toan", SqlDbType.VarChar, 2)
                pKieu_Thanh_Toan.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKieu_Thanh_Toan)

                Dim pDa_Tra As SqlParameter = New SqlParameter("@Da_Tra", SqlDbType.Bit, 1)
                pDa_Tra.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDa_Tra)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pGhi_Chu)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
                Dim myHoa_Don_Chi_Tiet As Hoa_Don_Chi_Tiet = New Hoa_Don_Chi_Tiet
                myHoa_Don_Chi_Tiet.Id_Hoa_Don = Id_Hoa_Don
                myHoa_Don_Chi_Tiet.So_Seri = pSo_Seri.Value
                myHoa_Don_Chi_Tiet.So_Hoa_Don = pSo_Hoa_Don.Value
                myHoa_Don_Chi_Tiet.Ten_Khach_Hang = pTen_Khach_Hang.Value
                myHoa_Don_Chi_Tiet.Dia_Chi = pDia_Chi.Value
                myHoa_Don_Chi_Tiet.Ma_So_Thue = pMa_So_Thue.Value
                myHoa_Don_Chi_Tiet.Ma_KH = pMa_KH.Value
                myHoa_Don_Chi_Tiet.Ngay_Xuat = pNgay_Xuat.Value
                myHoa_Don_Chi_Tiet.Ngay_Nop = pNgay_Nop.Value
                myHoa_Don_Chi_Tiet.Gia_Tri = pGia_Tri.Value
                myHoa_Don_Chi_Tiet.Vat = pVat.Value
                myHoa_Don_Chi_Tiet.Kieu_Thanh_Toan = pKieu_Thanh_Toan.Value
                myHoa_Don_Chi_Tiet.Da_Tra = pDa_Tra.Value
                myHoa_Don_Chi_Tiet.Ghi_Chu = pGhi_Chu.Value
                Return myHoa_Don_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Hoa_Don
        ' Input:  So_Seri, So_Hoa_Don, Ten_Khach_Hang, Dia_Chi, Ma_So_Thue, Ma_KH, Ngay_Xuat, Ngay_Nop, Gia_Tri, Vat, Kieu_Thanh_Toan, Da_Tra, Ghi_Chu,
        ' Output: 
        Public Sub Them(ByVal So_Seri As String, ByVal So_Hoa_Don As String, ByVal Ten_Khach_Hang As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Ma_KH As String, ByVal Ngay_Xuat As Integer, ByVal Ngay_Nop As Integer, ByVal Gia_Tri As Integer, ByVal Vat As Integer, ByVal Kieu_Thanh_Toan As String, ByVal Da_Tra As Boolean, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Value = So_Seri
                myCommand.Parameters.Add(pSo_Seri)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.VarChar, 6)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 150)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 300)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNgay_Xuat As SqlParameter = New SqlParameter("@Ngay_Xuat", SqlDbType.Int, 4)
                pNgay_Xuat.Value = Ngay_Xuat
                myCommand.Parameters.Add(pNgay_Xuat)

                Dim pNgay_Nop As SqlParameter = New SqlParameter("@Ngay_Nop", SqlDbType.Int, 4)
                pNgay_Nop.Value = Ngay_Nop
                myCommand.Parameters.Add(pNgay_Nop)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Int, 4)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKieu_Thanh_Toan As SqlParameter = New SqlParameter("@Kieu_Thanh_Toan", SqlDbType.VarChar, 2)
                pKieu_Thanh_Toan.Value = Kieu_Thanh_Toan
                myCommand.Parameters.Add(pKieu_Thanh_Toan)

                Dim pDa_Tra As SqlParameter = New SqlParameter("@Da_Tra", SqlDbType.Bit, 1)
                pDa_Tra.Value = Da_Tra
                myCommand.Parameters.Add(pDa_Tra)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Hoa_Don
        ' Input: Id_Hoa_Don,  So_Seri , So_Hoa_Don , Ten_Khach_Hang , Dia_Chi , Ma_So_Thue , Ma_KH , Ngay_Xuat , Ngay_Nop , Gia_Tri , Vat , Kieu_Thanh_Toan , Da_Tra , Ghi_Chu ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Hoa_Don As String, ByVal So_Seri As String, ByVal So_Hoa_Don As String, ByVal Ten_Khach_Hang As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Ma_KH As String, ByVal Ngay_Xuat As Integer, ByVal Ngay_Nop As Integer, ByVal Gia_Tri As Integer, ByVal Vat As Integer, ByVal Kieu_Thanh_Toan As String, ByVal Da_Tra As Boolean, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Value = So_Seri
                myCommand.Parameters.Add(pSo_Seri)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.VarChar, 6)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 150)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 300)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNgay_Xuat As SqlParameter = New SqlParameter("@Ngay_Xuat", SqlDbType.Int, 4)
                pNgay_Xuat.Value = Ngay_Xuat
                myCommand.Parameters.Add(pNgay_Xuat)

                Dim pNgay_Nop As SqlParameter = New SqlParameter("@Ngay_Nop", SqlDbType.Int, 4)
                pNgay_Nop.Value = Ngay_Nop
                myCommand.Parameters.Add(pNgay_Nop)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Int, 4)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKieu_Thanh_Toan As SqlParameter = New SqlParameter("@Kieu_Thanh_Toan", SqlDbType.VarChar, 2)
                pKieu_Thanh_Toan.Value = Kieu_Thanh_Toan
                myCommand.Parameters.Add(pKieu_Thanh_Toan)

                Dim pDa_Tra As SqlParameter = New SqlParameter("@Da_Tra", SqlDbType.Bit, 1)
                pDa_Tra.Value = Da_Tra
                myCommand.Parameters.Add(pDa_Tra)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật dữ liệu vào bảng Hoa_Don
        ' Input: đối tượng thuộc lớp Hoa_Don_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myHoa_Don_Chi_Tiet As Hoa_Don_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = myHoa_Don_Chi_Tiet.Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Value = myHoa_Don_Chi_Tiet.So_Seri
                myCommand.Parameters.Add(pSo_Seri)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.VarChar, 6)
                pSo_Hoa_Don.Value = myHoa_Don_Chi_Tiet.So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 150)
                pTen_Khach_Hang.Value = myHoa_Don_Chi_Tiet.Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 300)
                pDia_Chi.Value = myHoa_Don_Chi_Tiet.Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = myHoa_Don_Chi_Tiet.Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = myHoa_Don_Chi_Tiet.Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNgay_Xuat As SqlParameter = New SqlParameter("@Ngay_Xuat", SqlDbType.Int, 4)
                pNgay_Xuat.Value = myHoa_Don_Chi_Tiet.Ngay_Xuat
                myCommand.Parameters.Add(pNgay_Xuat)

                Dim pNgay_Nop As SqlParameter = New SqlParameter("@Ngay_Nop", SqlDbType.Int, 4)
                pNgay_Nop.Value = myHoa_Don_Chi_Tiet.Ngay_Nop
                myCommand.Parameters.Add(pNgay_Nop)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = myHoa_Don_Chi_Tiet.Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Int, 4)
                pVat.Value = myHoa_Don_Chi_Tiet.Vat
                myCommand.Parameters.Add(pVat)

                Dim pKieu_Thanh_Toan As SqlParameter = New SqlParameter("@Kieu_Thanh_Toan", SqlDbType.VarChar, 2)
                pKieu_Thanh_Toan.Value = myHoa_Don_Chi_Tiet.Kieu_Thanh_Toan
                myCommand.Parameters.Add(pKieu_Thanh_Toan)

                Dim pDa_Tra As SqlParameter = New SqlParameter("@Da_Tra", SqlDbType.Bit, 1)
                pDa_Tra.Value = myHoa_Don_Chi_Tiet.Da_Tra
                myCommand.Parameters.Add(pDa_Tra)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = myHoa_Don_Chi_Tiet.Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Hoa_Don
        ' Input: Id_Hoa_Don,  So_Seri , So_Hoa_Don , Ten_Khach_Hang , Dia_Chi , Ma_So_Thue , Ma_KH , Ngay_Xuat , Ngay_Nop , Gia_Tri , Vat , Kieu_Thanh_Toan , Da_Tra , Ghi_Chu ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Hoa_Don As String, ByVal So_Seri As String, ByVal So_Hoa_Don As String, ByVal Ten_Khach_Hang As String, ByVal Dia_Chi As String, ByVal Ma_So_Thue As String, ByVal Ma_KH As String, ByVal Ngay_Xuat As Integer, ByVal Ngay_Nop As Integer, ByVal Gia_Tri As Integer, ByVal Vat As Integer, ByVal Kieu_Thanh_Toan As String, ByVal Da_Tra As Boolean, ByVal Ghi_Chu As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Value = So_Seri
                myCommand.Parameters.Add(pSo_Seri)

                Dim pSo_Hoa_Don As SqlParameter = New SqlParameter("@So_Hoa_Don", SqlDbType.VarChar, 6)
                pSo_Hoa_Don.Value = So_Hoa_Don
                myCommand.Parameters.Add(pSo_Hoa_Don)

                Dim pTen_Khach_Hang As SqlParameter = New SqlParameter("@Ten_Khach_Hang", SqlDbType.NVarChar, 150)
                pTen_Khach_Hang.Value = Ten_Khach_Hang
                myCommand.Parameters.Add(pTen_Khach_Hang)

                Dim pDia_Chi As SqlParameter = New SqlParameter("@Dia_Chi", SqlDbType.NVarChar, 300)
                pDia_Chi.Value = Dia_Chi
                myCommand.Parameters.Add(pDia_Chi)

                Dim pMa_So_Thue As SqlParameter = New SqlParameter("@Ma_So_Thue", SqlDbType.VarChar, 50)
                pMa_So_Thue.Value = Ma_So_Thue
                myCommand.Parameters.Add(pMa_So_Thue)

                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                Dim pNgay_Xuat As SqlParameter = New SqlParameter("@Ngay_Xuat", SqlDbType.Int, 4)
                pNgay_Xuat.Value = Ngay_Xuat
                myCommand.Parameters.Add(pNgay_Xuat)

                Dim pNgay_Nop As SqlParameter = New SqlParameter("@Ngay_Nop", SqlDbType.Int, 4)
                pNgay_Nop.Value = Ngay_Nop
                myCommand.Parameters.Add(pNgay_Nop)

                Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int, 4)
                pGia_Tri.Value = Gia_Tri
                myCommand.Parameters.Add(pGia_Tri)

                Dim pVat As SqlParameter = New SqlParameter("@Vat", SqlDbType.Int, 4)
                pVat.Value = Vat
                myCommand.Parameters.Add(pVat)

                Dim pKieu_Thanh_Toan As SqlParameter = New SqlParameter("@Kieu_Thanh_Toan", SqlDbType.VarChar, 2)
                pKieu_Thanh_Toan.Value = Kieu_Thanh_Toan
                myCommand.Parameters.Add(pKieu_Thanh_Toan)

                Dim pDa_Tra As SqlParameter = New SqlParameter("@Da_Tra", SqlDbType.Bit, 1)
                pDa_Tra.Value = Da_Tra
                myCommand.Parameters.Add(pDa_Tra)

                Dim pGhi_Chu As SqlParameter = New SqlParameter("@Ghi_Chu", SqlDbType.NVarChar, 200)
                pGhi_Chu.Value = Ghi_Chu
                myCommand.Parameters.Add(pGhi_Chu)


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
        ' Nội dung: Xóa dữ liệu từ bảng Hoa_Don
        ' Input: Id_Hoa_Don
        ' Output: 
        Public Sub Xoa(ByVal Id_Hoa_Don As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()
            Catch ex As Exception
                Console.Write(ex.toString)


            End Try
        End Sub
#End Region
#Region "Xoa boi So_Seri"
        Public Sub Xoa_boi_So_Seri(ByVal So_Seri As String)
            Try
                'Tạo đối tượng connection and command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Xoa_Boi_So_Seri", myConnection)
                'Su dung store procedure
                myCommand.CommandType = CommandType.StoredProcedure
                'Them parameter vao thu tuc
                Dim pSo_Seri As SqlParameter = New SqlParameter("@So_Seri", SqlDbType.VarChar, 10)
                pSo_Seri.Value = So_Seri
                myCommand.Parameters.Add(pSo_Seri)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Hoa_Don
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Hoa_Don_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "Danh_Sach_Lay_Theo_Ngay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Hoa_Don
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach_Lay_Theo_Ngay(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Danh_Sach_Lay_Theo_Ngay", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                Dim pTu_Ngay As SqlParameter = New SqlParameter("@Tu_Ngay", SqlDbType.Int)
                pTu_Ngay.Value = Tu_Ngay
                myCommand.Parameters.Add(pTu_Ngay)

                Dim pDen_Ngay As SqlParameter = New SqlParameter("@Den_Ngay", SqlDbType.Int)
                pDen_Ngay.Value = Den_Ngay
                myCommand.Parameters.Add(pDen_Ngay)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Hoa_Don_Danh_Sach_Lay_Theo_Ngay")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region
#Region "In_Hoa_Don"
        ' Ngày tạo: 07/07/2008
        ' Người tạo: Trungnd
        ' Nội dung: Tạo bản kê E2
        ' Input: Id_E2
        ' Output: 
        Public Function In_Hoa_Don(ByVal Id_Hoa_Don As String) As DataSet

            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_BC01", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Hoa_Don As SqlParameter = New SqlParameter("@Id_Hoa_Don", SqlDbType.VarChar, 50)
                pId_Hoa_Don.Value = Id_Hoa_Don
                myCommand.Parameters.Add(pId_Hoa_Don)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Hoa_Don_BC01")
                myConnection.Close()
myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)


            End Try
        End Function
#End Region
#Region "Lay_Boi_Khach_Hang"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy dữ liệu từ bảng Khach_Hang thông qua khóa chính 
        ' Input: Ma_KH
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Lay_Boi_Khach_Hang(ByVal Ma_KH As String) As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Hoa_Don_Lay_Boi_Khach_Hang", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pMa_KH As SqlParameter = New SqlParameter("@Ma_KH", SqlDbType.VarChar, 50)
                pMa_KH.Value = Ma_KH
                myCommand.Parameters.Add(pMa_KH)

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Hoa_Don_Lay_Boi_Khach_Hang")
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


Imports System
Imports System.Data
Imports System.Data.SqlClient
Namespace EMS
#Region "Thong_Tin_Noi_Bo_Chi_Tiet"
    '*******************************************************
    ' Mỗi thuộc tính của lớp Thong_Tin_Noi_Bo_Chi_Tiet
    ' tương ứng với mộ trường của bảng Thong_Tin_Noi_Bo trong cơ sở dữ liệu
    '
    '*******************************************************
    Public Class Thong_Tin_Noi_Bo_Chi_Tiet
        Public Id_Noi_Bo As String ' Giá trị luôn luôn là EMS, dùng để làm khóa chính
        Public Khoi_Luong_E1_Max As Integer ' Khối lượng E1 tối đa
        Public So_Ngay_E1_Duoc_Trung As Integer ' Số ngày số hiệu E1 được phép trùng
        Public So_Ngay_Cho_Phep_Nhap_Bao_Phat As Integer ' Số ngày cho phép nhập báo phát
        Public So_Ngay_Cho_Phep_Sua_E1 As Integer
        Public Khoi_Luong_Vo_Tui As Integer ' Khối lượng vỏ túi mặc định
        Public Nhap_Bao_Phat_Khong_E1 As Boolean ' Cho phép nhập báo phát E1 khi không có số hiệu E1 đóng cho bưu tá
        Public Kenh_Truyen As Integer ' 0:ACCS, 1: Truyền File, 2:Webservice
        Public Ma_Tinh As Integer ' Mã tỉnh hiện tại
        Public So_Tien_E1_Max As Integer ' Số tiền mà E1 không thể vượt quá (phòng khi nhập lung tung)
        Public Ip_May_Center As String ' Ip Máy chủ dùng để truyền nhận dữ liệu
        Public URL_Tra_Cuu As String
        Public Phien_Ban As Double ' Phiên bản hiện tại của chương trình
        Public Nguoi_Gui_Paypost As String
        Public Dia_Chi_Gui_Paypost As String
        Public Dien_Thoai_Gui_Paypost As String
        Public Ma_KH_Gui_Paypost As String
    End Class
#End Region
#Region "Thong_Tin_Noi_Bo"
    Public Class Thong_Tin_Noi_Bo
        Private ConnectionString As String
        Public Sub New(ByVal _ConnectionString As String)
            ConnectionString = _ConnectionString
        End Sub
#Region "Lay"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Thong_Tin_Noi_Bo
        ' Input: Id_Noi_Bo
        ' Output: Thong_Tin_Noi_Bo_Chi_Tiet
        Public Function Lay(ByVal Id_Noi_Bo As String) As Thong_Tin_Noi_Bo_Chi_Tiet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Lay", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pId_Noi_Bo As SqlParameter = New SqlParameter("@Id_Noi_Bo", SqlDbType.Char, 3)
                pId_Noi_Bo.Value = Id_Noi_Bo
                myCommand.Parameters.Add(pId_Noi_Bo)

                Dim pKhoi_Luong_E1_Max As SqlParameter = New SqlParameter("@Khoi_Luong_E1_Max", SqlDbType.Int, 4)
                pKhoi_Luong_E1_Max.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_E1_Max)

                Dim pSo_Ngay_E1_Duoc_Trung As SqlParameter = New SqlParameter("@So_Ngay_E1_Duoc_Trung", SqlDbType.Int, 4)
                pSo_Ngay_E1_Duoc_Trung.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Ngay_E1_Duoc_Trung)

                Dim pSo_Ngay_Cho_Phep_Nhap_Bao_Phat As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Nhap_Bao_Phat", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Nhap_Bao_Phat)

                Dim pSo_Ngay_Cho_Phep_Sua_E1 As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Sua_E1", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Sua_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Sua_E1)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pNhap_Bao_Phat_Khong_E1 As SqlParameter = New SqlParameter("@Nhap_Bao_Phat_Khong_E1", SqlDbType.Bit, 1)
                pNhap_Bao_Phat_Khong_E1.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNhap_Bao_Phat_Khong_E1)

                Dim pKenh_Truyen As SqlParameter = New SqlParameter("@Kenh_Truyen", SqlDbType.Int, 4)
                pKenh_Truyen.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pKenh_Truyen)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pSo_Tien_E1_Max As SqlParameter = New SqlParameter("@So_Tien_E1_Max", SqlDbType.Int, 4)
                pSo_Tien_E1_Max.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pSo_Tien_E1_Max)

                Dim pIp_May_Center As SqlParameter = New SqlParameter("@Ip_May_Center", SqlDbType.VarChar, 50)
                pIp_May_Center.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pIp_May_Center)

                Dim pURL_Tra_Cuu As SqlParameter = New SqlParameter("@URL_Tra_Cuu", SqlDbType.NVarChar, 200)
                pURL_Tra_Cuu.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pURL_Tra_Cuu)

                Dim pPhien_Ban As SqlParameter = New SqlParameter("@Phien_Ban", SqlDbType.Float)
                pPhien_Ban.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pPhien_Ban)

                Dim pNguoi_Gui_Paypost As SqlParameter = New SqlParameter("@Nguoi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pNguoi_Gui_Paypost.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNguoi_Gui_Paypost)

                Dim pDia_Chi_Gui_Paypost As SqlParameter = New SqlParameter("@Dia_Chi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui_Paypost.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDia_Chi_Gui_Paypost)

                Dim pDien_Thoai_Gui_Paypost As SqlParameter = New SqlParameter("@Dien_Thoai_Gui_Paypost", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui_Paypost.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pDien_Thoai_Gui_Paypost)

                Dim pMa_KH_Gui_Paypost As SqlParameter = New SqlParameter("@Ma_KH_Gui_Paypost", SqlDbType.VarChar, 50)
                pMa_KH_Gui_Paypost.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pMa_KH_Gui_Paypost)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
myConnection.Dispose()

                Dim myThong_Tin_Noi_Bo_Chi_Tiet As Thong_Tin_Noi_Bo_Chi_Tiet = New Thong_Tin_Noi_Bo_Chi_Tiet
                myThong_Tin_Noi_Bo_Chi_Tiet.Id_Noi_Bo = Id_Noi_Bo
                myThong_Tin_Noi_Bo_Chi_Tiet.Khoi_Luong_E1_Max = pKhoi_Luong_E1_Max.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_E1_Duoc_Trung = pSo_Ngay_E1_Duoc_Trung.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_Cho_Phep_Nhap_Bao_Phat = pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_Cho_Phep_Sua_E1 = pSo_Ngay_Cho_Phep_Sua_E1.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Khoi_Luong_Vo_Tui = pKhoi_Luong_Vo_Tui.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Nhap_Bao_Phat_Khong_E1 = pNhap_Bao_Phat_Khong_E1.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Kenh_Truyen = pKenh_Truyen.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Ma_Tinh = pMa_Tinh.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.So_Tien_E1_Max = pSo_Tien_E1_Max.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Ip_May_Center = pIp_May_Center.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.URL_Tra_Cuu = pURL_Tra_Cuu.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Phien_Ban = pPhien_Ban.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Nguoi_Gui_Paypost = pNguoi_Gui_Paypost.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Dia_Chi_Gui_Paypost = pDia_Chi_Gui_Paypost.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Dien_Thoai_Gui_Paypost = pDien_Thoai_Gui_Paypost.Value
                myThong_Tin_Noi_Bo_Chi_Tiet.Ma_KH_Gui_Paypost = pMa_KH_Gui_Paypost.Value
                Return myThong_Tin_Noi_Bo_Chi_Tiet
            Catch ex As Exception
                Console.Write(ex.toString)

            End Try
        End Function
#End Region
#Region "Them"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Thêm dữ liệu vào bảng Thong_Tin_Noi_Bo
        ' Input:  Khoi_Luong_E1_Max, So_Ngay_E1_Duoc_Trung, So_Ngay_Cho_Phep_Nhap_Bao_Phat, Khoi_Luong_Vo_Tui, Nhap_Bao_Phat_Khong_E1, Kenh_Truyen, Ma_Tinh, So_Tien_E1_Max, Ip_May_Center, Phien_Ban,
        ' Output: 
        Public Sub Them(ByVal Khoi_Luong_E1_Max As Integer, ByVal So_Ngay_E1_Duoc_Trung As Integer, ByVal So_Ngay_Cho_Phep_Nhap_Bao_Phat As Integer, ByVal So_Ngay_Cho_Phep_Sua_E1 As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Nhap_Bao_Phat_Khong_E1 As Boolean, ByVal Kenh_Truyen As Integer, ByVal Ma_Tinh As Integer, ByVal So_Tien_E1_Max As Integer, ByVal Ip_May_Center As String, ByVal URL_Tra_Cuu As String, ByVal Phien_Ban As Double, ByVal Nguoi_Gui_Paypost As String, ByVal Dia_Chi_Gui_Paypost As String, ByVal Dien_Thoai_Gui_Paypost As String, ByVal Ma_KH_Gui_Paypost As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pKhoi_Luong_E1_Max As SqlParameter = New SqlParameter("@Khoi_Luong_E1_Max", SqlDbType.Int, 4)
                pKhoi_Luong_E1_Max.Value = Khoi_Luong_E1_Max
                myCommand.Parameters.Add(pKhoi_Luong_E1_Max)

                Dim pSo_Ngay_E1_Duoc_Trung As SqlParameter = New SqlParameter("@So_Ngay_E1_Duoc_Trung", SqlDbType.Int, 4)
                pSo_Ngay_E1_Duoc_Trung.Value = So_Ngay_E1_Duoc_Trung
                myCommand.Parameters.Add(pSo_Ngay_E1_Duoc_Trung)

                Dim pSo_Ngay_Cho_Phep_Nhap_Bao_Phat As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Nhap_Bao_Phat", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Value = So_Ngay_Cho_Phep_Nhap_Bao_Phat
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Nhap_Bao_Phat)

                Dim pSo_Ngay_Cho_Phep_Sua_E1 As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Sua_E1", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Sua_E1.Value = So_Ngay_Cho_Phep_Sua_E1
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Sua_E1)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pNhap_Bao_Phat_Khong_E1 As SqlParameter = New SqlParameter("@Nhap_Bao_Phat_Khong_E1", SqlDbType.Bit, 1)
                pNhap_Bao_Phat_Khong_E1.Value = Nhap_Bao_Phat_Khong_E1
                myCommand.Parameters.Add(pNhap_Bao_Phat_Khong_E1)

                Dim pKenh_Truyen As SqlParameter = New SqlParameter("@Kenh_Truyen", SqlDbType.Int, 4)
                pKenh_Truyen.Value = Kenh_Truyen
                myCommand.Parameters.Add(pKenh_Truyen)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pSo_Tien_E1_Max As SqlParameter = New SqlParameter("@So_Tien_E1_Max", SqlDbType.Int, 4)
                pSo_Tien_E1_Max.Value = So_Tien_E1_Max
                myCommand.Parameters.Add(pSo_Tien_E1_Max)

                Dim pIp_May_Center As SqlParameter = New SqlParameter("@Ip_May_Center", SqlDbType.VarChar, 50)
                pIp_May_Center.Value = Ip_May_Center
                myCommand.Parameters.Add(pIp_May_Center)

                Dim pURL_Tra_Cuu As SqlParameter = New SqlParameter("@URL_Tra_Cuu", SqlDbType.NVarChar, 200)
                pURL_Tra_Cuu.Value = URL_Tra_Cuu
                myCommand.Parameters.Add(pURL_Tra_Cuu)

                Dim pPhien_Ban As SqlParameter = New SqlParameter("@Phien_Ban", SqlDbType.Float)
                pPhien_Ban.Value = Phien_Ban
                myCommand.Parameters.Add(pPhien_Ban)

                Dim pNguoi_Gui_Paypost As SqlParameter = New SqlParameter("@Nguoi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pNguoi_Gui_Paypost.Value = Nguoi_Gui_Paypost
                myCommand.Parameters.Add(pNguoi_Gui_Paypost)

                Dim pDia_Chi_Gui_Paypost As SqlParameter = New SqlParameter("@Dia_Chi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui_Paypost.Value = Dia_Chi_Gui_Paypost
                myCommand.Parameters.Add(pDia_Chi_Gui_Paypost)

                Dim pDien_Thoai_Gui_Paypost As SqlParameter = New SqlParameter("@Dien_Thoai_Gui_Paypost", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui_Paypost.Value = Dien_Thoai_Gui_Paypost
                myCommand.Parameters.Add(pDien_Thoai_Gui_Paypost)

                Dim pMa_KH_Gui_Paypost As SqlParameter = New SqlParameter("@Ma_KH_Gui_Paypost", SqlDbType.VarChar, 50)
                pMa_KH_Gui_Paypost.Value = Ma_KH_Gui_Paypost
                myCommand.Parameters.Add(pMa_KH_Gui_Paypost)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Thong_Tin_Noi_Bo
        ' Input: Id_Noi_Bo,  Khoi_Luong_E1_Max , So_Ngay_E1_Duoc_Trung , So_Ngay_Cho_Phep_Nhap_Bao_Phat , Khoi_Luong_Vo_Tui , Nhap_Bao_Phat_Khong_E1 , Kenh_Truyen , Ma_Tinh , So_Tien_E1_Max , Ip_May_Center , Phien_Ban ,
        ' Output: 
        Public Sub Cap_Nhat(ByVal Id_Noi_Bo As String, ByVal Khoi_Luong_E1_Max As Integer, ByVal So_Ngay_E1_Duoc_Trung As Integer, ByVal So_Ngay_Cho_Phep_Nhap_Bao_Phat As Integer, ByVal So_Ngay_Cho_Phep_Sua_E1 As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Nhap_Bao_Phat_Khong_E1 As Boolean, ByVal Kenh_Truyen As Integer, ByVal Ma_Tinh As Integer, ByVal So_Tien_E1_Max As Integer, ByVal Ip_May_Center As String, ByVal URL_Tra_Cuu As String, ByVal Phien_Ban As Double, ByVal Nguoi_Gui_Paypost As String, ByVal Dia_Chi_Gui_Paypost As String, ByVal Dien_Thoai_Gui_Paypost As String, ByVal Ma_KH_Gui_Paypost As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Noi_Bo As SqlParameter = New SqlParameter("@Id_Noi_Bo", SqlDbType.Char, 3)
                pId_Noi_Bo.Value = Id_Noi_Bo
                myCommand.Parameters.Add(pId_Noi_Bo)

                Dim pKhoi_Luong_E1_Max As SqlParameter = New SqlParameter("@Khoi_Luong_E1_Max", SqlDbType.Int, 4)
                pKhoi_Luong_E1_Max.Value = Khoi_Luong_E1_Max
                myCommand.Parameters.Add(pKhoi_Luong_E1_Max)

                Dim pSo_Ngay_E1_Duoc_Trung As SqlParameter = New SqlParameter("@So_Ngay_E1_Duoc_Trung", SqlDbType.Int, 4)
                pSo_Ngay_E1_Duoc_Trung.Value = So_Ngay_E1_Duoc_Trung
                myCommand.Parameters.Add(pSo_Ngay_E1_Duoc_Trung)

                Dim pSo_Ngay_Cho_Phep_Nhap_Bao_Phat As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Nhap_Bao_Phat", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Value = So_Ngay_Cho_Phep_Nhap_Bao_Phat
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Nhap_Bao_Phat)

                Dim pSo_Ngay_Cho_Phep_Sua_E1 As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Sua_E1", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Sua_E1.Value = So_Ngay_Cho_Phep_Sua_E1
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Sua_E1)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pNhap_Bao_Phat_Khong_E1 As SqlParameter = New SqlParameter("@Nhap_Bao_Phat_Khong_E1", SqlDbType.Bit, 1)
                pNhap_Bao_Phat_Khong_E1.Value = Nhap_Bao_Phat_Khong_E1
                myCommand.Parameters.Add(pNhap_Bao_Phat_Khong_E1)

                Dim pKenh_Truyen As SqlParameter = New SqlParameter("@Kenh_Truyen", SqlDbType.Int, 4)
                pKenh_Truyen.Value = Kenh_Truyen
                myCommand.Parameters.Add(pKenh_Truyen)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pSo_Tien_E1_Max As SqlParameter = New SqlParameter("@So_Tien_E1_Max", SqlDbType.Int, 4)
                pSo_Tien_E1_Max.Value = So_Tien_E1_Max
                myCommand.Parameters.Add(pSo_Tien_E1_Max)

                Dim pIp_May_Center As SqlParameter = New SqlParameter("@Ip_May_Center", SqlDbType.VarChar, 50)
                pIp_May_Center.Value = Ip_May_Center
                myCommand.Parameters.Add(pIp_May_Center)

                Dim pURL_Tra_Cuu As SqlParameter = New SqlParameter("@URL_Tra_Cuu", SqlDbType.NVarChar, 200)
                pURL_Tra_Cuu.Value = URL_Tra_Cuu
                myCommand.Parameters.Add(pURL_Tra_Cuu)

                Dim pPhien_Ban As SqlParameter = New SqlParameter("@Phien_Ban", SqlDbType.Float)
                pPhien_Ban.Value = Phien_Ban
                myCommand.Parameters.Add(pPhien_Ban)

                Dim pNguoi_Gui_Paypost As SqlParameter = New SqlParameter("@Nguoi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pNguoi_Gui_Paypost.Value = Nguoi_Gui_Paypost
                myCommand.Parameters.Add(pNguoi_Gui_Paypost)

                Dim pDia_Chi_Gui_Paypost As SqlParameter = New SqlParameter("@Dia_Chi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui_Paypost.Value = Dia_Chi_Gui_Paypost
                myCommand.Parameters.Add(pDia_Chi_Gui_Paypost)

                Dim pDien_Thoai_Gui_Paypost As SqlParameter = New SqlParameter("@Dien_Thoai_Gui_Paypost", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui_Paypost.Value = Dien_Thoai_Gui_Paypost
                myCommand.Parameters.Add(pDien_Thoai_Gui_Paypost)

                Dim pMa_KH_Gui_Paypost As SqlParameter = New SqlParameter("@Ma_KH_Gui_Paypost", SqlDbType.VarChar, 50)
                pMa_KH_Gui_Paypost.Value = Ma_KH_Gui_Paypost
                myCommand.Parameters.Add(pMa_KH_Gui_Paypost)

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
        ' Nội dung: Cập nhật dữ liệu vào bảng Thong_Tin_Noi_Bo
        ' Input: đối tượng thuộc lớp Thong_Tin_Noi_Bo_Chi_Tiet
        ' Output: 
        Public Sub Cap_Nhat(ByVal myThong_Tin_Noi_Bo_Chi_Tiet As Thong_Tin_Noi_Bo_Chi_Tiet)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Cap_Nhat", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục						
                Dim pId_Noi_Bo As SqlParameter = New SqlParameter("@Id_Noi_Bo", SqlDbType.Char, 3)
                pId_Noi_Bo.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Id_Noi_Bo
                myCommand.Parameters.Add(pId_Noi_Bo)

                Dim pKhoi_Luong_E1_Max As SqlParameter = New SqlParameter("@Khoi_Luong_E1_Max", SqlDbType.Int, 4)
                pKhoi_Luong_E1_Max.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Khoi_Luong_E1_Max
                myCommand.Parameters.Add(pKhoi_Luong_E1_Max)

                Dim pSo_Ngay_E1_Duoc_Trung As SqlParameter = New SqlParameter("@So_Ngay_E1_Duoc_Trung", SqlDbType.Int, 4)
                pSo_Ngay_E1_Duoc_Trung.Value = myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_E1_Duoc_Trung
                myCommand.Parameters.Add(pSo_Ngay_E1_Duoc_Trung)

                Dim pSo_Ngay_Cho_Phep_Nhap_Bao_Phat As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Nhap_Bao_Phat", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Value = myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_Cho_Phep_Nhap_Bao_Phat
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Nhap_Bao_Phat)

                Dim pSo_Ngay_Cho_Phep_Sua_E1 As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Sua_E1", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Sua_E1.Value = myThong_Tin_Noi_Bo_Chi_Tiet.So_Ngay_Cho_Phep_Sua_E1
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Sua_E1)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pNhap_Bao_Phat_Khong_E1 As SqlParameter = New SqlParameter("@Nhap_Bao_Phat_Khong_E1", SqlDbType.Bit, 1)
                pNhap_Bao_Phat_Khong_E1.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Nhap_Bao_Phat_Khong_E1
                myCommand.Parameters.Add(pNhap_Bao_Phat_Khong_E1)

                Dim pKenh_Truyen As SqlParameter = New SqlParameter("@Kenh_Truyen", SqlDbType.Int, 4)
                pKenh_Truyen.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Kenh_Truyen
                myCommand.Parameters.Add(pKenh_Truyen)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pSo_Tien_E1_Max As SqlParameter = New SqlParameter("@So_Tien_E1_Max", SqlDbType.Int, 4)
                pSo_Tien_E1_Max.Value = myThong_Tin_Noi_Bo_Chi_Tiet.So_Tien_E1_Max
                myCommand.Parameters.Add(pSo_Tien_E1_Max)

                Dim pIp_May_Center As SqlParameter = New SqlParameter("@Ip_May_Center", SqlDbType.VarChar, 50)
                pIp_May_Center.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Ip_May_Center
                myCommand.Parameters.Add(pIp_May_Center)

                Dim pURL_Tra_Cuu As SqlParameter = New SqlParameter("@URL_Tra_Cuu", SqlDbType.NVarChar, 200)
                pURL_Tra_Cuu.Value = myThong_Tin_Noi_Bo_Chi_Tiet.URL_Tra_Cuu
                myCommand.Parameters.Add(pURL_Tra_Cuu)

                Dim pPhien_Ban As SqlParameter = New SqlParameter("@Phien_Ban", SqlDbType.Float)
                pPhien_Ban.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Phien_Ban
                myCommand.Parameters.Add(pPhien_Ban)

                Dim pNguoi_Gui_Paypost As SqlParameter = New SqlParameter("@Nguoi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pNguoi_Gui_Paypost.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Nguoi_Gui_Paypost
                myCommand.Parameters.Add(pNguoi_Gui_Paypost)

                Dim pDia_Chi_Gui_Paypost As SqlParameter = New SqlParameter("@Dia_Chi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui_Paypost.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Dia_Chi_Gui_Paypost
                myCommand.Parameters.Add(pDia_Chi_Gui_Paypost)

                Dim pDien_Thoai_Gui_Paypost As SqlParameter = New SqlParameter("@Dien_Thoai_Gui_Paypost", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui_Paypost.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Dien_Thoai_Gui_Paypost
                myCommand.Parameters.Add(pDien_Thoai_Gui_Paypost)

                Dim pMa_KH_Gui_Paypost As SqlParameter = New SqlParameter("@Ma_KH_Gui_Paypost", SqlDbType.VarChar, 50)
                pMa_KH_Gui_Paypost.Value = myThong_Tin_Noi_Bo_Chi_Tiet.Ma_KH_Gui_Paypost
                myCommand.Parameters.Add(pMa_KH_Gui_Paypost)


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
        ' Nội dung: Cập nhật hoặc Thêm mới dữ liệu vào bảng Thong_Tin_Noi_Bo
        ' Input: Id_Noi_Bo,  Khoi_Luong_E1_Max , So_Ngay_E1_Duoc_Trung , So_Ngay_Cho_Phep_Nhap_Bao_Phat , Khoi_Luong_Vo_Tui , Nhap_Bao_Phat_Khong_E1 , Kenh_Truyen , Ma_Tinh , So_Tien_E1_Max , Ip_May_Center , Phien_Ban ,
        ' Output: 
        Public Sub Cap_Nhat_Them(ByVal Id_Noi_Bo As String, ByVal Khoi_Luong_E1_Max As Integer, ByVal So_Ngay_E1_Duoc_Trung As Integer, ByVal So_Ngay_Cho_Phep_Nhap_Bao_Phat As Integer, ByVal So_Ngay_Cho_Phep_Sua_E1 As Integer, ByVal Khoi_Luong_Vo_Tui As Integer, ByVal Nhap_Bao_Phat_Khong_E1 As Boolean, ByVal Kenh_Truyen As Integer, ByVal Ma_Tinh As Integer, ByVal So_Tien_E1_Max As Integer, ByVal Ip_May_Center As String, ByVal URL_Tra_Cuu As String, ByVal Phien_Ban As Double, ByVal Nguoi_Gui_Paypost As String, ByVal Dia_Chi_Gui_Paypost As String, ByVal Dien_Thoai_Gui_Paypost As String, ByVal Ma_KH_Gui_Paypost As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Cap_Nhat_Them", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Noi_Bo As SqlParameter = New SqlParameter("@Id_Noi_Bo", SqlDbType.Char, 3)
                pId_Noi_Bo.Value = Id_Noi_Bo
                myCommand.Parameters.Add(pId_Noi_Bo)

                Dim pKhoi_Luong_E1_Max As SqlParameter = New SqlParameter("@Khoi_Luong_E1_Max", SqlDbType.Int, 4)
                pKhoi_Luong_E1_Max.Value = Khoi_Luong_E1_Max
                myCommand.Parameters.Add(pKhoi_Luong_E1_Max)

                Dim pSo_Ngay_E1_Duoc_Trung As SqlParameter = New SqlParameter("@So_Ngay_E1_Duoc_Trung", SqlDbType.Int, 4)
                pSo_Ngay_E1_Duoc_Trung.Value = So_Ngay_E1_Duoc_Trung
                myCommand.Parameters.Add(pSo_Ngay_E1_Duoc_Trung)

                Dim pSo_Ngay_Cho_Phep_Nhap_Bao_Phat As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Nhap_Bao_Phat", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Nhap_Bao_Phat.Value = So_Ngay_Cho_Phep_Nhap_Bao_Phat
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Nhap_Bao_Phat)

                Dim pSo_Ngay_Cho_Phep_Sua_E1 As SqlParameter = New SqlParameter("@So_Ngay_Cho_Phep_Sua_E1", SqlDbType.Int, 4)
                pSo_Ngay_Cho_Phep_Sua_E1.Value = So_Ngay_Cho_Phep_Sua_E1
                myCommand.Parameters.Add(pSo_Ngay_Cho_Phep_Sua_E1)

                Dim pKhoi_Luong_Vo_Tui As SqlParameter = New SqlParameter("@Khoi_Luong_Vo_Tui", SqlDbType.Int, 4)
                pKhoi_Luong_Vo_Tui.Value = Khoi_Luong_Vo_Tui
                myCommand.Parameters.Add(pKhoi_Luong_Vo_Tui)

                Dim pNhap_Bao_Phat_Khong_E1 As SqlParameter = New SqlParameter("@Nhap_Bao_Phat_Khong_E1", SqlDbType.Bit, 1)
                pNhap_Bao_Phat_Khong_E1.Value = Nhap_Bao_Phat_Khong_E1
                myCommand.Parameters.Add(pNhap_Bao_Phat_Khong_E1)

                Dim pKenh_Truyen As SqlParameter = New SqlParameter("@Kenh_Truyen", SqlDbType.Int, 4)
                pKenh_Truyen.Value = Kenh_Truyen
                myCommand.Parameters.Add(pKenh_Truyen)

                Dim pMa_Tinh As SqlParameter = New SqlParameter("@Ma_Tinh", SqlDbType.Int, 4)
                pMa_Tinh.Value = Ma_Tinh
                myCommand.Parameters.Add(pMa_Tinh)

                Dim pSo_Tien_E1_Max As SqlParameter = New SqlParameter("@So_Tien_E1_Max", SqlDbType.Int, 4)
                pSo_Tien_E1_Max.Value = So_Tien_E1_Max
                myCommand.Parameters.Add(pSo_Tien_E1_Max)

                Dim pIp_May_Center As SqlParameter = New SqlParameter("@Ip_May_Center", SqlDbType.VarChar, 50)
                pIp_May_Center.Value = Ip_May_Center
                myCommand.Parameters.Add(pIp_May_Center)

                Dim pURL_Tra_Cuu As SqlParameter = New SqlParameter("@URL_Tra_Cuu", SqlDbType.NVarChar, 200)
                pURL_Tra_Cuu.Value = URL_Tra_Cuu
                myCommand.Parameters.Add(pURL_Tra_Cuu)

                Dim pPhien_Ban As SqlParameter = New SqlParameter("@Phien_Ban", SqlDbType.Float)
                pPhien_Ban.Value = Phien_Ban
                myCommand.Parameters.Add(pPhien_Ban)

                Dim pNguoi_Gui_Paypost As SqlParameter = New SqlParameter("@Nguoi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pNguoi_Gui_Paypost.Value = Nguoi_Gui_Paypost
                myCommand.Parameters.Add(pNguoi_Gui_Paypost)

                Dim pDia_Chi_Gui_Paypost As SqlParameter = New SqlParameter("@Dia_Chi_Gui_Paypost", SqlDbType.NVarChar, 200)
                pDia_Chi_Gui_Paypost.Value = Dia_Chi_Gui_Paypost
                myCommand.Parameters.Add(pDia_Chi_Gui_Paypost)

                Dim pDien_Thoai_Gui_Paypost As SqlParameter = New SqlParameter("@Dien_Thoai_Gui_Paypost", SqlDbType.VarChar, 50)
                pDien_Thoai_Gui_Paypost.Value = Dien_Thoai_Gui_Paypost
                myCommand.Parameters.Add(pDien_Thoai_Gui_Paypost)

                Dim pMa_KH_Gui_Paypost As SqlParameter = New SqlParameter("@Ma_KH_Gui_Paypost", SqlDbType.VarChar, 50)
                pMa_KH_Gui_Paypost.Value = Ma_KH_Gui_Paypost
                myCommand.Parameters.Add(pMa_KH_Gui_Paypost)

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
        ' Nội dung: Xóa dữ liệu từ bảng Thong_Tin_Noi_Bo
        ' Input: Id_Noi_Bo
        ' Output: 
        Public Sub Xoa(ByVal Id_Noi_Bo As String)
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Xoa", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục
                Dim pId_Noi_Bo As SqlParameter = New SqlParameter("@Id_Noi_Bo", SqlDbType.Char, 3)
                pId_Noi_Bo.Value = Id_Noi_Bo
                myCommand.Parameters.Add(pId_Noi_Bo)

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
        ' Nội dung: Lấy toàn bộ dữ liệu từ bảng Thong_Tin_Noi_Bo
        ' Input: 
        ' Output: DataSet chứa toàn bộ dữ liệu lấy về 
        Public Function Danh_Sach() As DataSet
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Danh_Sach", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure

                myConnection.Open()
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDataSet, "Thong_Tin_Noi_Bo_Danh_Sach")
                myConnection.Close()
myConnection.Dispose()

                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

#Region "Lay_Ngay_Gio_Server"
        ' Ngày tạo: 15/6/08
        ' Người tạo: Nguyễn Bằng
        ' Nội dung: Lấy thông tin từ bảng Thong_Tin_Noi_Bo
        ' Input: Id_Noi_Bo
        ' Output: Thong_Tin_Noi_Bo_Chi_Tiet
        Public Function Lay_Ngay_Gio_Server() As Date
            Try
                ' Tạo đối tượng connection và command
                Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
                Dim myCommand As SqlCommand = New SqlCommand("Thong_Tin_Noi_Bo_Lay_Ngay_Gio_Server", myConnection)

                ' Sử dụng Store Procedure
                myCommand.CommandType = CommandType.StoredProcedure
                ' Thêm các Parameters vào thủ tục            
                Dim pNgay_Gio As SqlParameter = New SqlParameter("@Ngay_Gio", SqlDbType.DateTime)
                pNgay_Gio.Direction = ParameterDirection.Output
                myCommand.Parameters.Add(pNgay_Gio)

                myConnection.Open()
                myCommand.ExecuteNonQuery()
                myConnection.Close()
                myConnection.Dispose()

                Return pNgay_Gio.Value
            Catch ex As Exception
                Console.Write(ex.ToString)

            End Try
        End Function
#End Region

    End Class
#End Region
End Namespace

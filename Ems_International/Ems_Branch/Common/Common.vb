Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared.PaperSize
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office
Imports System.Net.Dns



Module Common
#Region "----------Khai báo biến toàn cục----------"
    Public GConnectionString As String ' Chuoi ket noi
    Public GConnectionString_E_Shiping As String ' Chuoi ket noi E_Shiping
    Public GConnectionString_International_From_Logitic As String ' Chuoi ket noi Ems_Internation của Khai Thác Quốc tế (Dùng cho Logitic)
    Public GOracleConnectionString As String ' Chuoi ket noi Oracle

    ' Chuoi ket noi Oracle Quan Ly Tui Goi
    'Public Const GOracleConnectionString_E_Receptacle As String = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=" & "orcl" & "))(ADDRESS=(PROTOCOL=TCP)(HOST=" & "203.162.235.50" & ")(PORT=1521)));user id=" & "ESHIPPING" & "; password=" & "abc123@"

    'Public Const GOracleConnectionString_E_Receptacle As String = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=203.162.235.50)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=ESHIPPING;Password=abc123@;"


    Public Const GOracleConnectionString_E_Receptacle As String = "Data Source=orcl;User Id=ESHIPPING;Password=abc123@;"

    'Public Const GOracleConnectionString_E_Receptacle = "Server = " & "203.162.235.50" & ";" & "database=" & "receptacle" & ";" & "uid=" & "ESHIPPING" & ";" & "pwd=" & "abc123@"

    Public Gid_Nguoi_Dung As Integer 'ID của người dùng hiện tại
    Public GUserAdmin As Boolean 'Người dùng hiện tại có phải là admin không: Sửa dữ liệu
    Public GTen_Dang_Nhap As String 'Tên đăng nhập của người dùng hiện tại
    Public GHo_Ten As String 'Tên của người dùng hiện tại
    Public GDien_Thoai As String  'Dien thoai cua nguoi dung hien tai
    Public GOutBout As Integer 'Form lập bản kê quốc tế đi hay quốc tế đến, Hay Lưu Kho hải quan
    Public GBuu_Cuc_Khai_Thac As Integer 'Mã bưu cụ khai thác hiện tại
    Public GMa_Don_Vi As String 'Mã bưu cụ khai thác hiện tại
    Public GTen_Buu_Cuc_Khai_Thac As String 'Ten bưu cụ khai thác hiện tại (Do them)
    Public GLan_Dau_Tien As Boolean 'Lần đầu tiên hả cưng
    Public GId_Ca As String = "" 'Ca khai thác đang sử dụng
    Public GNhap_Bao_Phat_Khong_E1 As Boolean 'Cho phép nhập báo phát khi không có số hiệu E1
    Public GSo_Ngay_Cho_Phep_Nhap_Bao_Phat As Integer = 200 'Số ngày mà báo phát có thể được nhập (nếu quá, không cho nhập nữa)
    Public GSo_Ngay_Cho_Phep_Sua_E1 As Integer = 100 'Số ngày được phép sửa chữa E1 hoặc xoá (nếu quá, không cho sửa chữa hoặc xoá)
    Public GMayInE1 As String ' Máy in E1
    Public GInE1ThaChu As Boolean  ' 
    Public GMayInE2 As String ' Máy in E2
    Public GInE2ThaChu As Boolean '
    Public GMayInBC37 As String ' Máy in BC37
    Public GInBC37ThaChu As Boolean '
    Public GInBC01ThaChu As String ' Máy in BC01
    Public GLeftMenu As String 'Noi dung cua menu trai
    Public GSo_Ngay_Hien_Thi_CH As Integer = 60 'Số ngày để hiển thị dữ liệu chuyển hoàn

    Public GKhoi_Luong_Vo_Tui As Integer 'Khối lượng vỏ túi
    Public GKhoi_Luong_E1_Max As Integer 'Khối lượng E1 max
    Public Grpt_Don_Vi_Khai_Thac As String 'hien thi don vi khai thac trong rpt
    Public GrptNgay_Thang_Nam As String 'hien thi ngay hien tai theo dinh dang VD : ngay 31 thang 02 nam 1963
    Public GMa_Tinh As Integer 'Mã tỉnh hiện tại
    Public GKenh_Truyen As Integer '0:ACCS, 1: Truyền File, 2:Webservice
    Public GSo_Tien_E1_Max As Integer 'Số tiền mà E1 không thể vượt quá (phòng khi nhập lung tung)
    Public GMa_Dau_So As String '2 số hiệu đầu mặc định

    'Update lên phiên bản 1.2 ngày: 25/05/2009: Đỗ Quốc Khánh
    'Update lên phiên bản 1.3 ngày 31/07/2009: Cập nhật dịch vụ EMS NDD (Đỗ Quốc Khánh)
    'Update lên phiên bản 1.4 ngày 25/08/2009: Cập nhật phần tạo Predes, Resdes sau khi khóa dữ liệu
    'Cho phép chạy khác phiên bản nhưng chỉ cho phép tra cứu bưu phẩm
    'Update lên phiên bản 1.5 ngày 
    'Update lên phiên bản 1.6 ngày 30/06/2010: Cập nhật bản kê theo kiểu mới
    'Update lên phiên bản 1.7 ngày 06/07/2010: Cập nhật tổng thuế và lệ phí trên Form nhập dữ liệu
    'Update lên phiên bản 2.0 ngày 20/07/2010: cập nhật in bản kê BV10 bằng máy in laser, quản lý thuế và lệ phí hải quan
    'Update lên phiên bản 2.1 ngày 11/01/2011: Cập nhật việc chấp nhận đầu mã C thay cho chỉ chấp nhận đầu mã E
    'Update lên phiên bản 2.3 ngày 12/06/2012: Cập nhật tính năng kiểm tra lạc hướng mới.
    'Update lên phiên bản 2.4 ngày 14/08/2012: Cập nhật thông tin chuyến bay khi xác nhận chuyến thư đến .
    'Update lên phiên bản 2.5 ngày 30/08/2012: Cập nhật thông tin chuyến bay khi xác nhận chuyến thư đến lấy chuyến bay trong bảng Tmp_E2_Den
    'Update lên phiên bản 3.3 ngày 01/11/2014: Cập nhật Chuyển đổi đầu mã USPS
    Public GPhien_Ban As Double = 3.3 'Phiên bản chương trình đang sử dụng
    Public GPhien_Ban_DataBase As Double 'Phiên bản trong Database

    ' Có cho phép bưu cục khai thác này kiểm tra lac hướng không
    Public GKiem_Tra_Lac_Huong As Boolean = False

    Public GVat As Double = 0.1 '% Vat hiện tại của ngày hôm đó 

    'Thiết lập tham số cho đóng đi quốc tế

    ' Thiết lập các tham số quốc tế đến
    Public GThu_Muc_In_BC37_QT_Den As String 'thư mục in BC37
    Public GThu_Muc_In_BV10_QT_Den As String 'thư mục in BV10
    Public GThu_Muc_In_E2_QT_Den As String 'thư mục in E2
    Public GThu_Muc_In_E4_QT_Den As String 'thư mục in E4

    Public GThu_Muc_In_CN35_QT_Di As String 'thư mục in CN35

    Public GIn_Kim_QT_Den As Boolean  'trạng thái in ra máy in kim
    Public GIn_Laser_QT_Den As Boolean  'trạng thái in ra máy in Laser
    Public GSo_Ngay_E1_Duoc_Trung As Integer 'Số ngày mà E1 có thể quay vòng
    Public GTrong_Luong_E1_Max As Integer 'Trong luong toi da cua E1

    Public GTen_May_Tinh_CN35 As String    'Ten hoac IP cua may tinh noi voi may in nhan CN35
    Public GTen_May_In_CN35 As String      'Ten may in nhan CN35 share tren mang

    Public GTen_May_Tinh_BC37 As String    'Ten hoac IP cua may tinh noi voi may in BC37
    Public GTen_May_In_BC37 As String      'Ten may in BC37 share tren mang

    Public GTen_May_Tinh_BV10 As String    'Ten hoac IP cua may tinh noi voi may in BV10
    Public GTen_May_In_BV10 As String      'Ten may in BV10 share tren mang

    Public GTen_May_Tinh_E2 As String    'Ten hoac IP cua may tinh noi voi may in E2
    Public GTen_May_In_E2 As String      'Ten may in E2 share tren mang

    Public GTen_May_Tinh_E4 As String    'Ten hoac IP cua may tinh noi voi may in nhan E4
    Public GTen_May_In_E4 As String      'Ten may in nhan E4 share tren mang

    Public GKieu_In_Map As Boolean    'Kieu in Map qua o F cua may chu

    'Them phan in CN38
    Public GIn_Kim_QT_Di_CN38 As Boolean
    Public GIn_Laser_QT_Di_CN38 As Boolean
    Public GKieu_In_Map_CN38 As Boolean    'Kieu in Map qua o F cua may chu
    Public GThu_Muc_In_CN38_QT_Di As String     'thư mục in CN38
    Public GTen_May_Tinh_CN38 As String
    Public GTen_May_In_CN38 As String

    Public GPost_Office As Integer

    'In bản kê Hải quan bưu điện
    Public GIn_Ban_Ke_HQ_Buu_Dien As Boolean
    'In bản kê BV10 theo ngày đóng
    Public GIn_Ban_Ke_BV10_Theo_Ngay_Dong As Boolean
    
    'In bản kê E2 theo mẫu mới
    Public GIn_Ban_Ke_E2_To_Text_Second As Boolean
    'In bản kê BC37 theo mẫu mới
    Public GIn_Ban_Ke_BC37_To_Text_Second As Boolean
    'In bản kê BV10 theo mẫu mới
    Public GIn_Ban_Ke_BV10_To_Text_Second As Boolean

    '--------------------------------------------------------------------------
    'Thiết lập in trong bản kê E2 in kim
    'Số ký tự trên một dòng E2
    Public GSo_Ky_Tu_Tren_Mot_Dong_E2 As Integer = 50
    'Cho phép in hoa hồng phát trả trên bản kê E2
    Public GIn_HH_Phat_Tra_Tren_E2 As Boolean = False
    'Cho phép in Lệ phí HQ trên bản kê E2
    Public GIn_Thue_Le_Phi_Tren_E2 As Boolean = False

    'Thiết lập in bản kê BV10 Quốc tế đi    '
    Public GIn_Kim_BV10_QT_Di As Boolean
    Public GIn_Tren_Server_BV10_QT_Di As Boolean
    Public GThu_Muc_In_BV10_QT_Di As String
    Public GMay_Tinh_In_BV10_QT_Di As String
    Public GMay_In_BV10_QT_Di As String

    'Thiết lập in bản kê BV10 trong nước
    Public GIn_Kim_BV10_Trong_Nuoc As Boolean
    Public GIn_Tren_Server_BV10_Trong_Nuoc As Boolean
    Public GThu_Muc_In_BV10_Trong_Nuoc As String
    Public GMay_Tinh_In_BV10_Trong_Nuoc As String
    Public GMay_In_BV10_Trong_Nuoc As String

    Public GKieu_In_E4_New As Boolean
    Public GTen_May_In_E4_New As String

    '--------------------------------------------------------------------------
    'Số dòng trong một trang in E2
    Public GSo_Dong_Trong_Trang_In_Ban_Ke_E2 As Integer
    'Số dòng trong một trang in BC37
    Public GSo_Dong_Trong_Trang_In_Ban_Ke_BC37 As Integer
    'Số dòng trong một trang in BV10
    Public GSo_Dong_Trong_Trang_In_Ban_Ke_BV10 As Integer

    '--------------------------------------------------------------------------

    'Thiết lập tham số cho phép sửa cước trong khi nhập dữ liệu
    Public gSua_Cuoc_Chinh As Boolean 'Cho phép sửa cước chính
    Public gSua_Cuoc_DV As Boolean 'Cho phép sửa cước Dịch Vụ
    Public gSua_Cuoc_E1 As Boolean 'Cho phép sửa cước E1

    'Biến sử dụng trong thiết lập hệ thống: các thông số thường sử dụng trong khai thác
    Public GSo_Ban_E2_Di As Integer 'Số bản in E2 đi
    Public GSo_Ban_E2_Den As Integer 'Số bản in E2 đến
    Public GSo_Ban_BC37_Di As Integer 'Số bản in BC37 đi
    Public GSo_Ban_BC37_Den As Integer 'Số bản in BC37 đến
    Public GIn_Khi_Dong_E2_Di As Boolean 'Thiết lập In khi đóng E2 đi trong khai thác
    Public GIn_Khi_Dong_E2_Den As Boolean  'Thiết lập In khi đóng E2 đến trong khai thác
    Public GIn_E4 As Boolean = False 'Thiết lập In E4 trong khai thác
    Public GIn_BC37_Di As Boolean 'Thiết lập In BC37 khi đóng túi F trong khai thác đi

    'cac ky tu dieu khien in
    Public Const mB = "E"
    Public Const mSH = "w1"
    Public Const mEH = "w0"
    Public Const mSW = "W1"
    Public Const mEW = "W0"
    Public Const mN = "F"
    Public Const mNP = ""  'Sang trang moi

    '-------Lay Ip_May_Tinh va Ban_So
    Public GIp_May_Tinh As String
    Public GBan_So As Integer

    '-------Ma dich vu thu ho Paypost
    Public Const GDich_Vu_Thu_Ho As String = "COD"
    Public GNguoi_Gui_Paypost As String
    Public GDia_Chi_Gui_Paypost As String
    Public GDien_Thoai_Gui_Paypost As String
    Public GMa_KH_Gui_Paypost As String
#End Region

#Region "----------Connect Data: MSSQL - Oracle----------"
    Public Function TestOracle(ByVal strConn As String) As Boolean
        Dim myConnection As OracleConnection = New OracleConnection(strConn)
        Dim MyCommand As New OracleCommand
        Dim myDataSet As New DataSet
        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "TEST_CONNECT"
            MyCommand.CommandType = CommandType.StoredProcedure

            Dim pMabc_Test_Curr As OracleParameter = New OracleParameter("v_Mabc_Test_Curr", OracleType.Cursor)
            pMabc_Test_Curr.Direction = ParameterDirection.Output
            MyCommand.Parameters.Add(pMabc_Test_Curr)

            myConnection.Open()
            Dim myAdapter As OracleDataAdapter = New OracleDataAdapter(MyCommand)
            myAdapter.Fill(myDataSet, "TEST_CONNECT")
            If (myDataSet.Tables(0).Rows.Count > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            'Close the connection and Dispose.
            myConnection.Close()
            MyCommand.Dispose()
        End Try
    End Function
    Public Function TestConnection(ByVal strInput As String) As Boolean
        Try
            Dim myCuoc As New Cuoc_TN(strInput)
            If myCuoc.Danh_Sach.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function TestConnection_E_Shiping(ByVal strInput As String) As Boolean
        Try
            Dim myCuoc As New Ems_Shipping_Cuoc_TN(strInput)
            If myCuoc.Danh_Sach.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Cau_Hinh_Database() As Boolean
        Dim myKeys As New ModifyRegistry
        If myKeys.Doc("IpDataBase") Is Nothing Then
            Dim frm As New FrmCauHinhCoSoDuLieu
            frm.ShowDialog()
        End If
        Dim str As String
        If Not myKeys.Doc("IpDataBase") Is Nothing Then
            str = myKeys.Doc("IpDataBase")
            GConnectionString = "Server = " & str & ";"

            str = myKeys.Doc("NameDataBase")
            GConnectionString = GConnectionString & "database=" & str & ";"

            str = myKeys.Doc("UserDataBase")
            GConnectionString = GConnectionString & "uid=" & str & ";"
            'uid = str

            str = Decrypt(myKeys.Doc("PassDataBase"), "cpcpnems")
            GConnectionString = GConnectionString & "pwd=" & str
            If TestConnection(GConnectionString) Then
                Return True
            Else
                Return False
            End If
        Else
            MessageBox.Show("Không tồn tại kết nối tới cơ sở dữ liệu !!! Liên hệ với người quản trị hệ thống để nhận lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        Return True
    End Function
    Public Function Cau_Hinh_Database_E_Shiping() As Boolean
        Dim myKeys As New ModifyRegistry
        'If myKeys.Doc("IpDataBase_E_Shiping") Is Nothing Then
        '    Dim frm As New FrmCauHinhCoSoDuLieu
        '    frm.ShowDialog()
        'End If
        Dim str As String
        If Not myKeys.Doc("IpDataBase_E_Shiping") Is Nothing Then
            str = myKeys.Doc("IpDataBase_E_Shiping")
            GConnectionString_E_Shiping = "Server = " & str & ";"

            str = myKeys.Doc("NameDataBase_E_Shiping")
            GConnectionString_E_Shiping = GConnectionString_E_Shiping & "database=" & str & ";"

            str = myKeys.Doc("UserDataBase_E_Shiping")
            GConnectionString_E_Shiping = GConnectionString_E_Shiping & "uid=" & str & ";"
            'uid = str

            str = Decrypt(myKeys.Doc("PassDataBase_E_Shiping"), "cpcpnems")
            GConnectionString_E_Shiping = GConnectionString_E_Shiping & "pwd=" & str
            If TestConnection_E_Shiping(GConnectionString_E_Shiping) Then
                Return True
            Else
                Return False
            End If
        Else
            MessageBox.Show("Không tồn tại kết nối tới cơ sở dữ liệu E Shiping !!! Liên hệ với người quản trị hệ thống để nhận lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        Return True
    End Function

    Public Function Cau_Hinh_Database_Oracle() As Boolean
        Dim myKeys As New ModifyRegistry
        'If myKeys.Doc("Ip_Ora") Is Nothing Then
        '    Dim frm As New FrmCauHinhCoSoDuLieu
        '    frm.ShowDialog()
        'End If
        Dim str As String
        'If Not myKeys.Doc("Ip_Ora") Is Nothing Then

        str = myKeys.Doc("servicename")
        GOracleConnectionString = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=" & str & "))(ADDRESS=(PROTOCOL=TCP)"

        str = myKeys.Doc("Ip_Ora")
        GOracleConnectionString = GOracleConnectionString & "(HOST=" & str & ")(PORT=1521)));"

        str = myKeys.Doc("Ten_Ora")
        GOracleConnectionString = GOracleConnectionString & "user id=" & str & ";"
        'uid = str

        str = Decrypt(myKeys.Doc("Pass_Ora"), "cpcpnems")
        GOracleConnectionString = GOracleConnectionString & "password=" & str & ""
        Return True
    End Function
    Public Function ConfigDatabase() As Boolean
        If File.Exists("config.ini") = False Then
            Dim frm As New FrmCauHinhCoSoDuLieu
            frm.ShowDialog()
        End If

        Dim str As String
        Dim objFileStream As StreamReader
        If File.Exists("config.ini") Then
            objFileStream = File.OpenText("config.ini")
            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            GConnectionString = "Server = " & str & ";"

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            GConnectionString = GConnectionString & "database=" & str & ";"

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            GConnectionString = GConnectionString & "uid=" & str & ";"
            'uid = str

            str = Decrypt(objFileStream.ReadLine, "cpcpnems")
            GConnectionString = GConnectionString & "pwd=" & str
            'pwd = str

            objFileStream.Close()
            objFileStream = Nothing
        Else
            MessageBox.Show("Không tồn tại kết nối tới cơ sở dữ liệu !!! Liên hệ với người quản trị hệ thống để nhận lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        Return True
    End Function
#End Region

#Region "----------Security: Encrypt - Decrypt----------"
    'The function used to encrypt the text
    Public Function Encrypt(ByVal strText As String, ByVal strEncrKey _
             As String) As String
        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H11, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey)

            Dim des As New DESCryptoServiceProvider
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(strText)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
            'Return ms.ToArray()
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'The function used to decrypt the text
    Public Function Decrypt(ByVal strText As String, ByVal sDecrKey _
               As String) As String
        Dim byKey() As Byte = {}
        'Co the thay doi phan IV() nay, tuong tu cho Encrypt.
        Dim IV() As Byte = {&H11, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey)
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(strText)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ex.Message
        End Try

    End Function
#End Region

#Region "----------Init----------"
    Public Sub Init()
        'GetKey
        Dim myKeys As New ModifyRegistry
        GMa_Dau_So = IIf(myKeys.Doc("DauMa") Is Nothing Or myKeys.Doc("DauMa") = "", "EE", myKeys.Doc("DauMa"))
        GIn_Ban_Ke_BV10_Theo_Ngay_Dong = CBool(IIf(myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong") = "", "False", myKeys.Doc("GIn_Ban_Ke_BV10_Theo_Ngay_Dong")))

        GIn_Ban_Ke_E2_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_E2_To_Text_Second")))
        GIn_Ban_Ke_BV10_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_BV10_To_Text_Second")))
        GIn_Ban_Ke_BC37_To_Text_Second = IIf(myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second") Is Nothing Or myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second") = "", "False", CStr(myKeys.Doc("GIn_Ban_Ke_BC37_To_Text_Second")))

        GSo_Dong_Trong_Trang_In_Ban_Ke_E2 = CInt(IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2") = "", "40", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_E2")))
        GSo_Dong_Trong_Trang_In_Ban_Ke_BC37 = CInt(IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37") = "", "40", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BC37")))
        GSo_Dong_Trong_Trang_In_Ban_Ke_BV10 = CInt(IIf(myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10") Is Nothing Or myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10") = "", "40", myKeys.Doc("GSo_Dong_Trong_Trang_In_Ban_Ke_BV10")))

        'Thiết lập in bản kê BV10 quốc tế đi
        GIn_Kim_BV10_QT_Di = IIf(myKeys.Doc("GIn_Kim_BV10_QT_Di") Is Nothing Or myKeys.Doc("GIn_Kim_BV10_QT_Di") = "", "False", myKeys.Doc("GIn_Kim_BV10_QT_Di"))
        GIn_Tren_Server_BV10_QT_Di = IIf(myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") Is Nothing Or myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") = "", "False", myKeys.Doc("GIn_Tren_Server_BV10_QT_Di"))
        GThu_Muc_In_BV10_QT_Di = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Di") = "", "", myKeys.Doc("GThu_Muc_In_BV10_QT_Di"))
        GMay_Tinh_In_BV10_QT_Di = IIf(myKeys.Doc("GMay_Tinh_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GMay_Tinh_In_BV10_QT_Di") = "", "", myKeys.Doc("GMay_Tinh_In_BV10_QT_Di"))
        GMay_In_BV10_QT_Di = IIf(myKeys.Doc("GMay_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GMay_In_BV10_QT_Di") = "", "", myKeys.Doc("GMay_In_BV10_QT_Di"))
        '------------------------------------------------------------------
        'Thiết lập in bản kê BV10 trong nước
        GIn_Kim_BV10_Trong_Nuoc = IIf(myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc") = "", "False", myKeys.Doc("GIn_Kim_BV10_Trong_Nuoc"))
        GIn_Tren_Server_BV10_Trong_Nuoc = IIf(myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc") = "", "False", myKeys.Doc("GIn_Tren_Server_BV10_Trong_Nuoc"))
        GThu_Muc_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GThu_Muc_In_BV10_Trong_Nuoc"))
        GMay_Tinh_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GMay_Tinh_In_BV10_Trong_Nuoc"))
        GMay_In_BV10_Trong_Nuoc = IIf(myKeys.Doc("GMay_In_BV10_Trong_Nuoc") Is Nothing Or myKeys.Doc("GMay_In_BV10_Trong_Nuoc") = "", "", myKeys.Doc("GMay_In_BV10_Trong_Nuoc"))
    End Sub
#End Region

#Region "----------Kiểm tra lạc hướng----------"
    Public Function Lac_Huong(ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Goc As Integer, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Id_Duong_Thu As String) As Boolean
        Try
            'Tìm Loại chuyển tiếp của Id_Duong_Thu
            Dim isChuyen_Tiep As Boolean
            Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
            myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(Id_Duong_Thu)
            isChuyen_Tiep = myDuong_Thu_Di_Chi_Tiet.Tinh_Doanh_Thu

            If isChuyen_Tiep = True Then
                'Không kiểm tra lạc hướng
                Return False
            Else
                'Tìm 
                If Nuoc_Nhan = "" Then

                Else

                End If
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function
#End Region

#Region "----------Kiểm tra , thao tác với Mã Bc - Mã E1----------"
    'Them vao truoc ma_bc ky tu "0" de dam bao do dai = ipDo_Dai
    Public Function Chuan_Hoa_Ma_Bc(ByVal ipMa_Bc As Integer, ByVal ipDo_Dai As Integer) As String
        Dim idx As Integer
        Dim stdMa_BC As String
        If Len(ipMa_Bc.ToString) >= ipDo_Dai Then
            Return ipMa_Bc.ToString
        Else
            stdMa_BC = ipMa_Bc.ToString
            For idx = 1 To ipDo_Dai - Len(ipMa_Bc.ToString)
                stdMa_BC = "0" & stdMa_BC
            Next
            Return stdMa_BC
        End If

    End Function

    Public Function FormatMaBc(ByVal MaBc As String) As String
        'Ngày tạo: 25/06/2008
        'Người tạo: Nguyễn Bằng
        'Nội dung: Định dạng mã bưu cục luôn luôn là 6 số
        Return Convert.ToString(MaBc & "000000").Substring(0, 6)
    End Function

    Public Function AutoE1(ByVal MaE1 As String) As String
        'Ngày tạo: 25/06/2008
        'Người tạo: Nguyễn Bằng
        'Đầu vào: số E1 (nhập nhanh)
        'Nội dung: Định dạng mã E1 với đầy đủ 13 ký tự
        Return GMa_Dau_So & Convert.ToString(MaE1 & "000000000").Substring(0, 9) & "VN"
    End Function

#Region "----------GetCorrectMAE1----------"
    Public Function GetCorrectMAE1(ByVal MA_E1 As String, ByVal Ma_Nuoc_Nhan As String, ByVal Ma_Bc_Goc As Integer, Optional ByVal MAE1_ERROR As String = "EE000000000VN") As String
        Dim ss As String : ss = Trim(MA_E1).ToUpper : GetCorrectMAE1 = MAE1_ERROR
        Dim i As Long
        Dim Ma_Don_Vi As String
        If MA_E1.Length > 13 Then 'Nếu nhiều hơn 13 ký tự là sai
            GetCorrectMAE1 = MAE1_ERROR
            Exit Function
        End If
        If IsNumeric(MA_E1) Then
            i = CLng(Val(MA_E1))
        Else
            i = 0
        End If
        Dim s1 As String
        Dim P As Integer, j As Integer, t As Integer
        If i = 0 Then
            If ss.Length = 13 Then
                If (LSet(UCase(ss), 1) <> "E") And ((LSet(UCase(ss), 1) <> "C")) Then
                    GetCorrectMAE1 = MAE1_ERROR
                Else
                    Dim k As Long
                    For k = 3 To 11
                        If IsNumeric(Val(Mid(MA_E1, k, 1))) = 0 Then
                            GetCorrectMAE1 = MAE1_ERROR
                            Exit Function
                        End If
                    Next k
                    GetCorrectMAE1 = ss.ToUpper 'ss.Substring(0, 11).ToUpper & Ma_Nuoc_Nhan.ToUpper
                End If
            ElseIf ss.Length = 12 Then 'Trường hợp nhập thiếu nước nhận
                GetCorrectMAE1 = "E" & UCase(ss)
            ElseIf ss.Length = 11 Then 'Trường hợp nhập thiếu nước nhận
                GetCorrectMAE1 = UCase(ss) & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
            ElseIf ss.Length = 10 Then 'Trường hợp nhập thiếu nước nhận và đầu mã "E"
                GetCorrectMAE1 = "E" & UCase(ss) & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
            Else
                If (Ma_Nuoc_Nhan <> "VN" And Val(Mid(ss, 3)) <> 0) Then
                    GetCorrectMAE1 = Mid(ss, 1, 2).ToUpper & CInt(Val(Mid(ss, 3))).ToString("000000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
                End If
            End If
        Else 'Nếu nhập toàn số
            'Tìm mã đơn vị từ Ma_Bc_Goc
            Ma_Don_Vi = Tim_Danh_Muc_BC_Tu_Ma_Bc(Ma_Bc_Goc).Ma_Don_Vi
            If i.ToString.Length > 9 Or i < 0 Then 'Nếu nhập nhiều hơn 9 chữ số hoặc giá trị âm
                GetCorrectMAE1 = MAE1_ERROR
                Exit Function
            ElseIf i.ToString.Length = 9 Then 'Nhập đầy đủ số
                GetCorrectMAE1 = GMa_Dau_So & CLng(i).ToString("000000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
            ElseIf i.ToString.Length = 8 Then
                GetCorrectMAE1 = GMa_Dau_So & CLng(i.ToString).ToString("000000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
            ElseIf i.ToString.Length = 7 Then
                'Chỉ lấy mã đơn vị là 2 số
                If Ma_Don_Vi.Length = 2 Then
                    GetCorrectMAE1 = GMa_Dau_So & Ma_Don_Vi & i.ToString("0000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
                Else
                    GetCorrectMAE1 = MAE1_ERROR
                    Exit Function
                End If
            Else
                If Ma_Don_Vi.Length = 2 Then
                    GetCorrectMAE1 = GMa_Dau_So & Ma_Don_Vi & i.ToString("0000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
                Else
                    GetCorrectMAE1 = GMa_Dau_So & Ma_Don_Vi & i.ToString("000000") & IIf(Ma_Nuoc_Nhan = "", "VN", Ma_Nuoc_Nhan.ToUpper)
                End If
            End If
        End If
    End Function
#End Region

#Region "----------Tìm Mã nước nhận từ MAE1----------"
    Public Function TimNuocNhanTuE1(ByVal MAE1 As String) As String
        If MAE1.Length = 13 Then
            Return Mid(MAE1, 12, 2)
        Else
            Return "VN"
        End If
    End Function
#End Region

#Region "----------Tim_MAE1_Tu_Nuoc_Nhan----------"
    Public Function Tim_MAE1_Tu_Nuoc_Nhan(ByVal MAE1 As String, ByVal Nuoc_Nhan As String) As String
        If Nuoc_Nhan.Length = 2 And MAE1.Length = 13 Then
            Return MAE1 'Left(MAE1, 11) & Nuoc_Nhan
        Else
            Return MAE1
        End If
    End Function
#End Region

#Region "----------E1_AfterUpdate----------"
    Public Function E1_AfterUpdate(ByVal Nuoc_Nhan As Control, ByVal Ma_Bc_Goc As Control, ByVal MAE1 As Control, Optional ByVal MAE1_ERROR As String = "EE000000000VN") As Boolean
        Dim S As String
        Dim i As Long
        Dim bbc As Long
        Dim bdv As Long

        MAE1.Text = GetCorrectMAE1(MAE1.Text, IIf(Nuoc_Nhan.Text = "", "VN", Nuoc_Nhan.Text), Tim_Danh_Muc_BC_Tu_Ma_Bc(Ma_Bc_Goc.Text).Ma_Don_Vi)
        S = MAE1.Text
        i = S.Length

        If i = 13 Then
            S = UCase$(S)
            MAE1.Text = "E" & Right(S, 12)
            Nuoc_Nhan.Text = Mid$(S, i - 1, 2)
            If Nuoc_Nhan.Text = "VN" Then
                bbc = Ma_Bc_Goc.Text
                bdv = GMa_Don_Vi
                'Lấy mã tỉnh làm mã bưu cục gốc
                Ma_Bc_Goc.Text = Tim_Danh_Muc_BC_TuE1(MAE1.Text).Ma_Tinh
                If Ma_Bc_Goc.Text = 0 Then
                    MsgBox("Không tồn tại Mã đơn vị này, bạn hãy kiểm tra lại ", MsgBoxStyle.OKOnly, "Thông báo")
                End If
            Else
                Ma_Bc_Goc.Text = 0
            End If

            E1_AfterUpdate = True
            NCBC_Current(Nuoc_Nhan, Ma_Bc_Goc)
        Else
            MAE1.Text = GetCorrectMAE1(MAE1.Text, IIf(Nuoc_Nhan.Text = "", "VN", Nuoc_Nhan.Text), GMa_Don_Vi)
        End If
    End Function
#End Region

#Region "----------Tìm Danh mục bưu cục từ MAE1----------"
    Public Function Tim_Danh_Muc_BC_TuE1(ByVal MAE1 As String) As Danh_Muc_BC_Chi_Tiet
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        'If Mid(MAE1, 12, 2) <> "VN" Then
        'Return myDanh_Muc_BC.Danh_Muc_BC_Nhan_Lay_Boi_MA_E1_KT(0)
        'Else
        Return myDanh_Muc_BC.Danh_Muc_BC_Nhan_Lay_Boi_MA_E1_KT(MAE1)
        'End If
    End Function
#End Region

#Region "----------Tìm Danh mục bưu cục từ Ma_Bc----------"
    Public Function Tim_Danh_Muc_BC_Tu_Ma_Bc(ByVal Ma_Bc As Integer) As Danh_Muc_BC_Chi_Tiet
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Return myDanh_Muc_BC.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(Ma_Bc)
    End Function
#End Region

#Region "----------NCBC_Current----------"
    Public Sub NCBC_Current(ByVal Nuoc_Nhan As Control, ByVal Ma_Bc_Goc As Control)
        If Nuoc_Nhan.Text = "VN" Then
            C_Current(Ma_Bc_Goc, Nuoc_Nhan)
        Else
            C_Current(Nuoc_Nhan, Ma_Bc_Goc)
        End If
    End Sub
#End Region

#Region "----------C_Current----------"
    Sub C_Current(ByVal C1 As Control, ByVal C2 As Control)
        If C1.Visible = False Then C1.Visible = True
        If Not C1.Enabled Then C1.Enabled = True
        On Error GoTo CError
        If C2.Enabled Then C2.Enabled = False
        Exit Sub
CError:
        C1.Focus()
        If C2.Enabled Then C2.Enabled = False
    End Sub
#End Region
#End Region

#Region "------------Tạo Id------------"
#Region "Tạo Id_Duong_Thu"
    Public Function CreateId_Duong_Thu(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Bc As Integer) As String
        Return Ma_Bc_Khai_Thac.ToString("0000000") & Ma_Bc.ToString("0000000")
    End Function
#End Region

#Region "Tao ID_Chuyen_Thu"
    Public Function CreateId_Chuyen_Thu(ByVal Id_Duong_Thu As String, ByVal Chuyen_Thu As Integer, ByVal Date_Create As Integer, ByVal Loai_Chuyen_Thu As String) As String
        Return Id_Duong_Thu & CStr(Date_Create) & Chuyen_Thu.ToString & Loai_Chuyen_Thu.Substring(0, 2)
    End Function
#End Region

#Region "Tao Id_E2"
    Public Function CreateId_E2(ByVal Id_Chuyen_Thu As String, ByVal Tui_So As Integer) As String
        'Return Id_Duong_Thu & CStr(Date_Create) & Chuyen_Thu.ToString & Loai_Chuyen_Thu.Substring(0, 2) & Tui_So.ToString
        Return Id_Chuyen_Thu & Tui_So
    End Function
#End Region

#Region "Tao Id_E2_Convert"
    Public Function CreateId_E2_Convert(ByVal Id_Duong_Thu As String, ByVal Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer) As String
        Return Id_Duong_Thu & Date_Create.ToString.Substring(6, 2) & Date_Create.ToString.Substring(4, 2) & Date_Create.ToString.Substring(0, 4) & Chuyen_Thu.ToString & Tui_So.ToString
    End Function
#End Region

#Region "Tao ID_E1"
    Public Function CreateId_E1(ByVal MaE1 As String, ByVal Id_E2 As String, ByVal Kien_So As Integer) As String
        Return Id_E2 & MaE1.ToUpper & Kien_So.ToString("0000")
    End Function
#End Region

#Region "Tao ID_Hoa_Don"
    Public Function CreateId_Hoa_Don(ByVal So_Seri As String, ByVal So_Hoa_Don As String) As String
        Return So_Seri & So_Hoa_Don
    End Function
#End Region

#Region "Tao Id_Ca"
    Public Function CreateId_Ca(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ngay_Khai_Thac As Integer, ByVal Ca_Khai_Thac As Integer) As String
        Return CStr(Ma_Bc_Khai_Thac) & CStr(Ngay_Khai_Thac) & CStr(Ca_Khai_Thac)
    End Function
#End Region

#Region "Đường Bay: Tao ID_So_Hieu"
    Public Function CreateId_So_Hieu(ByVal So_Hieu As String, ByVal Thu_2 As Boolean, ByVal Thu_3 As Boolean, ByVal Thu_4 As Boolean, ByVal Thu_5 As Boolean, ByVal Thu_6 As Boolean, ByVal Thu_7 As Boolean, ByVal Chu_Nhat As Boolean) As String
        Dim mId_So_Hieu As String = ""
        mId_So_Hieu = IIf(Thu_2 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Thu_3 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Thu_4 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Thu_5 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Thu_6 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Thu_7 = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & IIf(Chu_Nhat = True, "1", "0")
        mId_So_Hieu = mId_So_Hieu & So_Hieu
        Return mId_So_Hieu
    End Function
#End Region

#Region "--------------------Tạo Mã tờ khai------------------"
    'Cau truc: Ma_Loai & Ngay (YYYY0000) & So_TK
    'Ma_Loai: Hang xuat   -   Hang nhap   -    Hang vien tro
    Public Function Create_Ma_To_Khai(ByVal Ma_Loai As Integer, ByVal Ngay As Integer, ByVal So_TK As Integer) As String
        Dim fNgay As String
        Dim fLoai As String
        fNgay = Mid(Ngay.ToString, 1, 4) & "0000"
        Select Case Ma_Loai
            Case 5  'Hang vien tro
                fLoai = "V"
            Case 9  'Hang xuat
                fLoai = "X"
            Case 10  'Hang chuyen hoan di quoc te
                fLoai = "X"
            Case Else   'Hang nhap
                fLoai = "N"
        End Select
        Return fLoai & fNgay & So_TK.ToString("000000")
    End Function
#End Region

#Region "------------------Format_So_TKHQ--------------"
    Public Function Format_So_TKHQ(ByVal So_TKHQ As Integer) As String
        Return So_TKHQ.ToString("000000")
    End Function
#End Region

#Region "---------------CreateId_Chi_Tiet_E1_Hang_Kiem_Hoa_Xuat--------------------"
    Public Function CreateId_Chi_Tiet_E1_Hang_Kiem_Hoa_Xuat(ByVal Id_E1 As String, ByVal STT As Integer) As String
        Return Id_E1 & STT.ToString("0000")
    End Function
#End Region

#Region "Create ID Huong chuyen"
    ''' Create id huong chuyen den
    Public Function CreateIdHuongChuyen(ByVal _ID_Duong_Thu As String, ByVal _Ma_Nuoc As String, ByVal _Ma_Tinh As Integer) As String
        Return _ID_Duong_Thu & _Ma_Nuoc & _Ma_Tinh.ToString("000000")
    End Function
#End Region
#End Region

#Region "----------Tính Cước----------"
#Region "Tính Công Phát"
    Public Function Tinh_Cong_Phat(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai As Integer) As Integer
        Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
        Return myTinh_Cuoc.Tinh_Cong_Phat(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, Ngay_Chap_Nhan)
    End Function
#End Region

#Region "Tính Cước chính"
    Public Function Tinh_Cuoc_Chinh(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal PostCode As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai As Integer, ByVal Loai_Hang_Hoa As Integer) As Tinh_Cuoc_Chi_Tiet
        Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
        Dim myTinh_Cuoc_Chi_Tiet As New Tinh_Cuoc_Chi_Tiet
        If Loai = 1 Then 'Sự vụ
            myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh = 0
            myTinh_Cuoc_Chi_Tiet.Cong_Chap_Nhan = 0
            myTinh_Cuoc_Chi_Tiet.Cuoc_PPVX = 0
            myTinh_Cuoc_Chi_Tiet.PPXD = 0
            myTinh_Cuoc_Chi_Tiet.Cuoc_PPXD = 0
            myTinh_Cuoc_Chi_Tiet.Ty_Gia = 0
            myTinh_Cuoc_Chi_Tiet.VAT = 0
        Else 'Loại bình thường
            If Mid(MAE1, 12, 2) = "VN" Then 'Tính cước trong nước
                myTinh_Cuoc_Chi_Tiet = myTinh_Cuoc.Tinh_Cuoc_TN(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, Ngay_Chap_Nhan, Loai_Hang_Hoa)
            Else 'Tính cước quốc tế
                myTinh_Cuoc_Chi_Tiet = myTinh_Cuoc.Tinh_Cuoc_QT(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, PostCode, Ngay_Chap_Nhan, Loai_Hang_Hoa)
            End If
            If Loai_Hang_Hoa = 1 Then 'Hàng cồng kềnh cước bằng 1.5 lần cước chính
                With myTinh_Cuoc_Chi_Tiet
                    .Cuoc_CS = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_CS
                    .VAT = myTinh_Cuoc_Chi_Tiet.VAT
                    .PPXD = myTinh_Cuoc_Chi_Tiet.PPXD
                    .Cuoc_PPXD = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_PPXD
                    .Cuoc_PPVX = myTinh_Cuoc_Chi_Tiet.Cuoc_PPVX
                    .Ty_Gia = myTinh_Cuoc_Chi_Tiet.Ty_Gia
                    .Cuoc_Dich_Vu = myTinh_Cuoc_Chi_Tiet.Cuoc_Dich_Vu
                    .Cuoc_Chinh = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh
                    .Cong_Chap_Nhan = 1.5 * myTinh_Cuoc_Chi_Tiet.Cong_Chap_Nhan
                    .Cuoc_Chinh = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh
                End With
            End If
        End If
        Return myTinh_Cuoc_Chi_Tiet
    End Function
#End Region
#End Region

#Region "----------Function Khác----------"
#Region "----------Hàm căn giữa----------"
    Public Function padC(ByVal strPad As String, ByVal intLen As Integer) As String
        Dim intCenter As Integer
        intCenter = (intLen - Len(strPad)) / 2
        padC = LSet(strPad, Len(strPad) + intCenter)
        padC = RSet(padC, intLen)
    End Function
#End Region

#Region "----------Chèn thêm số dòng = số dòng truyền vào----------"
    Public Sub InsertRow(ByVal sFileTXT As StreamWriter, ByVal intRow As Integer)
        Dim iRow As Integer
        For iRow = 1 To intRow
            sFileTXT.WriteLine()
        Next
    End Sub
#End Region

#Region "----------Hiển thị SaveDialog----------"
    Public Function ShowSaveDlg(ByVal inFileName As String) As String
        Dim inSaveDlg As New SaveFileDialog
        With inSaveDlg
            .FileName = inFileName
            .Title = "Chon ten File"
            .DefaultExt = "*.ink"
            .Filter = "Ink (*.ink)|*.ink"
            .ShowDialog()
            If .FileName <> "" Then
                inFileName = .InitialDirectory & "\" & .FileName
                inFileName = Mid(inFileName, 2, Len(inFileName) - 1)
            End If
        End With
        Return inFileName
    End Function
#End Region

#Region "----------Chuyển sang tiếng Việt không dấu----------"
    Public Function ConvetToABC(ByVal strVN As String) As String
        Dim abc() As Char = {"a", "A", "e", "E", "o", "O", "u", "U", "i", "I", "d", "D", "y", "Y", ""}
        Dim UniVN0() As Char = {"á", "à", "ạ", "ả", "ã", "â", "ấ", "ầ", "ậ", "ẩ", "ẫ", "ă", "ắ", "ằ", "ặ", "ẳ"}
        Dim UniVN1() As Char = {"Á", "À", "Ạ", "Ả", "Ã", "Â", "Ấ", "Ầ", "Ậ", "Ẩ", "Ẫ", "Ă", "Ắ", "Ằ", "Ặ", "Ẳ"}
        Dim UniVN2() As Char = {"é", "è", "ẹ", "ẻ", "ẽ", "ê", "ế", "ề", "ệ", "ể", "ễ"}
        Dim UniVN3() As Char = {"É", "È", "Ẹ", "Ẻ", "Ẽ", "Ê", "Ế", "Ề", "Ệ", "Ể", "Ễ"}
        Dim UniVN4() As Char = {"ó", "ò", "ọ", "ỏ", "õ", "ô", "ố", "ồ", "ộ", "ổ", "ỗ", "ơ", "ớ", "ờ", "ợ", "ở"}
        Dim UniVN5() As Char = {"Ó", "Ò", "Ọ", "Ỏ", "Õ", "Ô", "Ố", "Ồ", "Ộ", "Ổ", "Ỗ", "Ơ", "Ớ", "Ờ", "Ợ", "Ở"}
        Dim UniVN6() As Char = {"ú", "ù", "ụ", "ủ", "ũ", "ư", "ứ", "ừ", "ự", "ử", "ữ"}
        Dim UniVN7() As Char = {"Ú", "Ù", "Ụ", "Ủ", "Ũ", "Ư", "Ứ", "Ừ", "Ự", "Ử", "Ữ"}
        Dim UniVN8() As Char = {"í", "ì", "ị", "ỉ", "ĩ"}
        Dim UniVN9() As Char = {"Í", "Ì", "Ị", "Ỉ", "Ĩ"}
        Dim UniVN10() As Char = {"đ"}
        Dim UniVN11() As Char = {"Đ"}
        Dim UniVN12() As Char = {"ý", "ỳ", "ỵ", "ỷ", "ỹ"}
        Dim UniVN13() As Char = {"Ý", "Ỳ", "Ỵ", "Ỷ", "Ỹ"}
        Dim UniVN14() As Char = {"́", "̀", "̣", "̉", "̃"}

        Dim i As Integer
        'a - A
        For i = 0 To 15
            strVN = Replace(strVN, UniVN0(i), abc(0))
            strVN = Replace(strVN, UniVN1(i), abc(1))
        Next
        'e - E
        For i = 0 To 10
            strVN = Replace(strVN, UniVN2(i), abc(2))
            strVN = Replace(strVN, UniVN3(i), abc(3))
        Next
        'o - O
        For i = 0 To 15
            strVN = Replace(strVN, UniVN4(i), abc(4))
            strVN = Replace(strVN, UniVN5(i), abc(5))
        Next
        'u - U
        For i = 0 To 10
            strVN = Replace(strVN, UniVN6(i), abc(6))
            strVN = Replace(strVN, UniVN7(i), abc(7))
        Next
        'i - I
        For i = 0 To 4
            strVN = Replace(strVN, UniVN8(i), abc(8))
            strVN = Replace(strVN, UniVN9(i), abc(9))
        Next
        'd
        strVN = Replace(strVN, UniVN10(0), abc(10))
        'D
        strVN = Replace(strVN, UniVN11(0), abc(11))
        'y - Y
        For i = 0 To 4
            strVN = Replace(strVN, UniVN12(i), abc(12))
            strVN = Replace(strVN, UniVN13(i), abc(13))
        Next
        'cach thanh dau
        For i = 0 To 4
            strVN = Replace(strVN, Trim(UniVN14(i)), Trim(abc(14)))
        Next
        Return UCase(strVN)

    End Function
#End Region

#Region "----------Kiem tra ngay nghi - Thu 6,7,CN----------"
    Public Function Kiem_Tra_Ngay_Nghi(ByVal DateNow As Date) As Boolean
        Dim Thu_Hien_Tai As String
        Thu_Hien_Tai = DateNow.DayOfWeek.ToString
        Select Case Thu_Hien_Tai
            Case "Friday"
                Return True
            Case "Saturday"
                Return True
            Case "Sunday"
                Return True
            Case Else
                Return False
        End Select
    End Function
#End Region

#Region "----------SetNullValue----------"
    Public Function SetNullValue(ByVal String_In As String, ByVal DefaultString As String) As String
        If String_In Is Nothing Then
            Return DefaultString
        ElseIf String_In = "" Then
            Return DefaultString
        Else
            Return String_In
        End If
    End Function
#End Region

#Region "----------GetField----------"
    Public Function GetField(ByVal obj As Object, ByVal fieldName As String) As Object
        Dim fi As System.Reflection.FieldInfo
        fi = obj.GetType().GetField(fieldName, Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.NonPublic)
        Return fi.GetValue(obj)
    End Function
#End Region

#Region "--------------Lấy Ip máy tính hiện tại-------------"
    Public Function Get_Ip_MyComputer() As String
        Try
            Dim Ip_Address_Local As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
            Return Ip_Address_Local.AddressList.GetValue(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region
#End Region

#Region "------------Bản kê chi tiết - Dùng cho kế toán, nghiệp vụ------------"
#Region "Bản Kê Chi tiết số liệu chuuyến thư EMS chiều đến - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Den(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKeToanEMS_Den
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuThangKeToan As String
        Dim mnuNgayThang As String
        Dim mnuTen_Don_Vi As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Accounting"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThangKeToan = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThangKeToan
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)

        mnuNgayThang = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgayThang
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)

        mnuTen_Don_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuTen_Don_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub

    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Ngay_KT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        'Dim rptVIEW As New rptKeToanEMS_Den_Theo_Ngay_KT
        Dim myKeToanEMS_Den_Theo_Ngay_KT As New rptKeToanEMS_Den_Theo_Ngay_KT
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        'Dim mnuThangKeToan As String
        'Dim mnuNgayThang As String
        'Dim mnuTen_Don_Vi As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu(Tu_Ngay, Den_Ngay).Tables(0)
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("  Không có dữ liệu cho tháng này !!!")
            Exit Sub
        End If

        _pThamSo.Value = "Từ Ngày " & Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay) & " Đến Ngày " & Ham_Dung_Chung.ConvertIntToDate(Den_Ngay)
        pvCollection.Add(_pThamSo)
        myKeToanEMS_Den_Theo_Ngay_KT.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        _pThamSo.Value = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Add(_pThamSo)
        myKeToanEMS_Den_Theo_Ngay_KT.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        _pThamSo.Value = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Add(_pThamSo)
        myKeToanEMS_Den_Theo_Ngay_KT.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        myTable.TableName = "Chuyen_Thu_Den_EMS_Theo_Ngay_KT_Phan_Loai_Chuyen_Thu"
        myDataSet.Tables.Add(myTable.Copy)
        myKeToanEMS_Den_Theo_Ngay_KT.SetDataSource(myDataSet)
        FrmView.CrystalReportViewer1.ReportSource = myKeToanEMS_Den_Theo_Ngay_KT
        Cursor.Current = Cursors.Default
        FrmView.ShowDialog()

        'rptVIEW.SetDataSource(myDataSet)
        'FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        'Cursor.Current = Cursors.Default

        'If preview = True Then
        '    'Xem tren man hinh
        '    FrmView.ShowDialog()
        'Else
        '    'Dua ra may in
        '    rptVIEW.PrintToPrinter(soban, True, 0, 0)
        'End If
    End Sub

#Region "Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong"
    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Try
            Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
            Dim FrmView As New FrmViewReports
            Dim myBanKeKeToanEmsChieuDenTheoNgayDong As New rptBanKeKeToanEmsChieuDenTheoChuyenBayNgayKT
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

            'Lay du lieu
            myTable = myKe_Toan_Ca_QT.Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Chuyen_Bay_Ngay_Dong(Tu_Ngay, Den_Ngay).Tables(0)
            If myTable.Rows.Count = 0 Then
                CMessageBox.Show("  Không có dữ liệu cho báo cáo này !!!")
                Exit Sub
            End If


            _pThamSo.Value = "Từ Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Tu_Ngay) & " Đến Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Den_Ngay)
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNgayDong.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNgayDong.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNgayDong.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            myTable.TableName = "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT"
            myDataSet.Tables.Add(myTable.Copy)
            myBanKeKeToanEmsChieuDenTheoNgayDong.SetDataSource(myDataSet)
            FrmView.CrystalReportViewer1.ReportSource = myBanKeKeToanEmsChieuDenTheoNgayDong
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region
#Region " Bảng kê kế toán chiều đến theo nước và ngày khai thác"
    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Nuoc_Ngay_KT(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Try
            Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
            Dim FrmView As New FrmViewReports
            Dim myBanKeKeToanEmsChieuDenTheoNuocNgayKT As New rptBanKeKeToanEmsChieuDenTheoNuocNgayKT
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

            'Lay du lieu
            myTable = myKe_Toan_Ca_QT.Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Nuoc_Ngay_KT(Tu_Ngay, Den_Ngay).Tables(0)
            If myTable.Rows.Count = 0 Then
                CMessageBox.Show("  Không có dữ liệu cho báo cáo này !!!")
                Exit Sub
            End If


            _pThamSo.Value = "BẢN KÊ CHI TIẾT SỐ LIỆU CHUYẾN THƯ EMS CHIỀU ĐẾN THEO CHUYẾN BAY VÀ NGÀY KT"
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuTieuDe").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Từ Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Tu_Ngay) & " Đến Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Den_Ngay)
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            myTable.TableName = "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT"
            myDataSet.Tables.Add(myTable.Copy)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.SetDataSource(myDataSet)
            FrmView.CrystalReportViewer1.ReportSource = myBanKeKeToanEmsChieuDenTheoNuocNgayKT
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub

#End Region
#Region " Bảng kê kế toán chiều đến theo nước và ngày bay"
    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Den_Theo_Nuoc_Ngay_Dong(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Try
            Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
            Dim FrmView As New FrmViewReports
            Dim myBanKeKeToanEmsChieuDenTheoNuocNgayKT As New rptBanKeKeToanEmsChieuDenTheoNuocNgayKT
            Dim myDataSet As New DataSet
            Dim myTable As New DataTable

            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

            'Lay du lieu
            myTable = myKe_Toan_Ca_QT.Ban_Ke_Ke_Toan_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_Dong(Tu_Ngay, Den_Ngay).Tables(0)
            If myTable.Rows.Count = 0 Then
                CMessageBox.Show("  Không có dữ liệu cho báo cáo này !!!")
                Exit Sub
            End If

            _pThamSo.Value = "BẢN KÊ CHI TIẾT SỐ LIỆU CHUYẾN THƯ EMS CHIỀU ĐẾN THEO CHUYẾN BAY VÀ NGÀY ĐÓNG"
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuTieuDe").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
         

            _pThamSo.Value = "Từ Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Tu_Ngay) & " Đến Ngày " & Ham_Dung_Chung.ConvertIntToVNDateType(Den_Ngay)
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()


            _pThamSo.Value = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
            pvCollection.Add(_pThamSo)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            myTable.TableName = "Tong_Hop_So_Lieu_Ems_Chieu_Den_Theo_Ten_Nuoc_Ngay_KT"
            myDataSet.Tables.Add(myTable.Copy)
            myBanKeKeToanEmsChieuDenTheoNuocNgayKT.SetDataSource(myDataSet)
            FrmView.CrystalReportViewer1.ReportSource = myBanKeKeToanEmsChieuDenTheoNuocNgayKT
            Cursor.Current = Cursors.Default
            FrmView.ShowDialog()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub

#End Region
#End Region

#Region "Bản Kê Chi tiết số liệu chuuyến thư USPS chiều đến - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_USPS_Chieu_Den(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKeToanUSPS_Den
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuThangKeToan As String
        Dim mnuNgayThang As String
        Dim mnuTen_Don_Vi As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_USPS_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Accounting"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThangKeToan = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThangKeToan
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)

        mnuNgayThang = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgayThang
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)

        mnuTen_Don_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuTen_Don_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Chi tiết số liệu chuuyến thư EMS chiều đi - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_EMS_Chieu_Di(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKeToanEMS_Di
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuThangKeToan As String
        Dim mnuNgayThang As String
        Dim mnuTen_Don_Vi As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 1).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Accounting"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThangKeToan = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThangKeToan
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)

        mnuNgayThang = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgayThang
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)

        mnuTen_Don_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuTen_Don_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Chi tiết số liệu chuuyến thư EMS quá giang - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_EMS_Qua_Giang(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKeToanEMS_QG
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuThangKeToan As String
        Dim mnuNgayThang As String
        Dim mnuTen_Don_Vi As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_Transit_Danh_Sach_Tu_Ngay_Den_Ngay(Tu_Ngay, Den_Ngay).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Accounting_Transit"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThangKeToan = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThangKeToan
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuThangKeToan").ApplyCurrentValues(pvCollection)

        mnuNgayThang = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgayThang
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuNgayThang").ApplyCurrentValues(pvCollection)

        mnuTen_Don_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuTen_Don_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTen_Don_Vi").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Tổng hợp số liệu chuuyến thư EMS chiều đến - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_TH_EMS_Chieu_Den(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKe_Toan_QT_TH
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuTieu_De As String
        Dim mnuThang_Bao_Cao As String
        Dim mnuDon_Vi As String
        Dim mnuNgay_Thang_Nam As String
        Dim mnuMau As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Ke_Toan_QT_TH"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThang_Bao_Cao = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThang_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Thang_Bao_Cao").ApplyCurrentValues(pvCollection)

        mnuNgay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

        mnuDon_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuDon_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Don_Vi").ApplyCurrentValues(pvCollection)

        mnuTieu_De = "BÁO CÁO TỔNG HỢP SỐ LIỆU EMS CHIỀU ĐẾN"
        pvCollection.Clear()
        _pThamSo.Value = mnuTieu_De
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvCollection)

        mnuMau = "TH EMS 02"
        pvCollection.Clear()
        _pThamSo.Value = mnuMau
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Mau").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Tổng hợp số liệu chuuyến thư USPS chiều đến - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_TH_USPS_Chieu_Den(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKe_Toan_QT_TH
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuTieu_De As String
        Dim mnuThang_Bao_Cao As String
        Dim mnuDon_Vi As String
        Dim mnuNgay_Thang_Nam As String
        Dim mnuMau As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.Accounting_USPS_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 0).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "Ke_Toan_QT_TH"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThang_Bao_Cao = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " Năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThang_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Thang_Bao_Cao").ApplyCurrentValues(pvCollection)

        mnuNgay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

        mnuDon_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuDon_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Don_Vi").ApplyCurrentValues(pvCollection)

        mnuTieu_De = "BÁO CÁO TỔNG HỢP SỐ LIỆU USPS CHIỀU ĐẾN"
        pvCollection.Clear()
        _pThamSo.Value = mnuTieu_De
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvCollection)

        mnuMau = "TH USPS 02"
        pvCollection.Clear()
        _pThamSo.Value = mnuMau
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Mau").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Tổng hợp số liệu chuuyến thư EMS chiều đi - Dùng cho kế toán"
    Public Sub Ban_Ke_Ke_Toan_TH_EMS_Chieu_Di(ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptKe_Toan_QT_TH
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable
        Dim myTableQG As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuTieu_De As String
        Dim mnuThang_Bao_Cao As String
        Dim mnuDon_Vi As String
        Dim mnuNgay_Thang_Nam As String
        Dim mnuMau As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu dong di
        myTable = myKe_Toan_Ca_QT.Accounting_Tong_Hop_Tu_Ngay_Den_Ngay_Theo_Chieu_Dong(Tu_Ngay, Den_Ngay, 1).Tables(0)
        'Lay du lieu qua giang
        myTableQG = myKe_Toan_Ca_QT.Accounting_Transit_Tong_Hop_Tu_Ngay_Den_Ngay(Tu_Ngay, Den_Ngay).Tables(0)

        'Them dong tieu de + Ket noi 2 bang vao 1 + Hieu chinh lai so thu tu 
        Dim idx As Integer
        Dim Total_ED As Integer = 0
        Dim Total_EM As Integer = 0
        Dim Total_ER As Integer = 0
        Dim Total_KL As Decimal = 0
        'Duyet de lay tong so cho dong tieu de
        For idx = 0 To myTableQG.Rows.Count - 1
            Total_ED += myTableQG.Rows(idx).Item("ED")
            Total_EM += myTableQG.Rows(idx).Item("EM")
            Total_ER += myTableQG.Rows(idx).Item("ER")
            Total_KL += myTableQG.Rows(idx).Item("KL_EMS")
        Next
        'Them dong tieu de
        Dim oRow As DataRow
        oRow = myTable.NewRow()
        oRow("STT") = 2
        oRow("Ten_Dich_Vu") = "EMS Qu¸ Giang"
        oRow("ED") = Total_ED
        oRow("EM") = Total_EM
        oRow("ER") = Total_ER
        oRow("KL_EMS") = Total_KL
        myTable.Rows.Add(oRow)
        'Duyet vao noi mytableQG vao mytable
        For idx = 0 To myTableQG.Rows.Count - 1
            oRow = myTable.NewRow()
            oRow("STT") = ""
            oRow("Ten_Dich_Vu") = myTableQG.Rows(idx).Item("Ten_Dich_Vu")
            oRow("ED") = myTableQG.Rows(idx).Item("ED")
            oRow("EM") = myTableQG.Rows(idx).Item("EM")
            oRow("ER") = myTableQG.Rows(idx).Item("ER")
            oRow("KL_EMS") = myTableQG.Rows(idx).Item("KL_EMS")
            myTable.Rows.Add(oRow)
        Next

        'Dat ten table cho phu hop
        myTable.TableName = "Ke_Toan_QT_TH"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        mnuThang_Bao_Cao = "Tháng " & Month(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay)) & " năm " & Year(Ham_Dung_Chung.ConvertIntToDate(Tu_Ngay))
        pvCollection.Clear()
        _pThamSo.Value = mnuThang_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Thang_Bao_Cao").ApplyCurrentValues(pvCollection)

        mnuNgay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " tháng " & Now.Month().ToString("00") & " năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)

        mnuDon_Vi = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuDon_Vi
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Don_Vi").ApplyCurrentValues(pvCollection)

        mnuTieu_De = "BÁO CÁO TỔNG HỢP SỐ LIỆU EMS CHIỀU ĐI"
        pvCollection.Clear()
        _pThamSo.Value = mnuTieu_De
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvCollection)

        mnuMau = "TH EMS 01"
        pvCollection.Clear()
        _pThamSo.Value = mnuMau
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Mau").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "Bản Kê Tổng hợp Sản lượng EMS Quốc tế - Dùng cho nghiệp vụ - TCHC"
    Public Sub Bao_Cao_Tong_Hop_San_Luong_EMS_QT(ByVal Chieu_Dong As Boolean, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal preview As Boolean, ByVal soban As Integer)
        'Chieu Dong = True - Quoc te Den
        'Chieu Dong = False - Quoc te Di
        Dim myKe_Toan_Ca_QT As New Ke_Toan_Ca_QT(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptBao_Cao_San_Luong_Quoc_Te
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mnuTieu_De_Bao_Cao As String
        Dim mnuTu_Ngay_Den_Ngay As String
        Dim mnuBuu_Cuc_Khai_Thac As String
        Dim mnuNgay_Thang_Nam As String

        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)

        'Lay du lieu
        myTable = myKe_Toan_Ca_QT.E1_San_Luong_QT(Tu_Ngay, Den_Ngay, Chieu_Dong).Tables(0)
        'Dat ten table cho phu hop
        myTable.TableName = "E1_San_Luong_QT"
        'Dua vao Dataset
        myDataSet.Tables.Add(myTable.Copy)

        'Tu ngay den ngay
        mnuTu_Ngay_Den_Ngay = "Từ " & Ham_Dung_Chung.ConvertIntToDate_VN(Tu_Ngay) & " Đến " & Ham_Dung_Chung.ConvertIntToDate_VN(Den_Ngay)
        pvCollection.Clear()
        _pThamSo.Value = mnuTu_Ngay_Den_Ngay
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTu_Ngay_Den_Ngay").ApplyCurrentValues(pvCollection)

        'Ngay tao bao cao
        mnuNgay_Thang_Nam = "Ngày " & Now.Day().ToString("00") & " Tháng " & Now.Month().ToString("00") & " Năm " & Now.Year().ToString("0000")
        pvCollection.Clear()
        _pThamSo.Value = mnuNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuNgay_Thang_Nam").ApplyCurrentValues(pvCollection)

        'Ten don vi in bao cao (HCM, HA NOI)
        mnuBuu_Cuc_Khai_Thac = myDanh_Muc_BC.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Clear()
        _pThamSo.Value = mnuBuu_Cuc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuBuu_Cuc_Khai_Thac").ApplyCurrentValues(pvCollection)

        'Tieu de bao cao
        If Chieu_Dong = True Then  'Quoc te Den
            mnuTieu_De_Bao_Cao = "TỔNG HỢP SẢN LƯỢNG BƯU PHẨM EMS QUỐC TẾ CHIỀU ĐẾN"
        Else                       'Quoc te Di
            mnuTieu_De_Bao_Cao = "TỔNG HỢP SẢN LƯỢNG BƯU PHẨM EMS QUỐC TẾ CHIỀU ĐI"
        End If
        pvCollection.Clear()
        _pThamSo.Value = mnuTieu_De_Bao_Cao
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("mnuTieu_De_Bao_Cao").ApplyCurrentValues(pvCollection)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(soban, True, 0, 0)
        End If
    End Sub
#End Region
#End Region

#Region "-----------Export To Excel From Dataset-----------"
    Public Sub Export_To_Excel_From_DataSet(ByVal mDataSet As DataSet, ByVal mFilePath As String)
        'Extracting from database
        Dim col, row As Integer

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If

        'Export to Excel process
        Try
            Cursor.Current = Cursors.WaitCursor
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    .cells(1, i).value = mDataSet.Tables(0).Columns(col).ColumnName
                    .cells(1, i).EntireRow.Font.Bold = True
                    i += 1
                Next
                i = 2
                Dim k As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    i = 2
                    For row = 0 To mDataSet.Tables(0).Rows.Count - 1
                        .Cells(i, k).Value = mDataSet.Tables(0).Rows(row).ItemArray(col)
                        i += 1
                    Next
                    k += 1
                Next
                .ActiveCell.Worksheet.SaveAs(mFilePath)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
            Cursor.Current = Cursors.Default
        End Try

        ' The excel is created and opened for insert value. We most close this excel using this system
        Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each i As Process In pro
            i.Kill()
        Next
        Cursor.Current = Cursors.Default
        MsgBox("Dữ liệu đã được xuất ra thành công trong file:  '" & mFilePath & "'", MsgBoxStyle.Information)

    End Sub
#End Region

#Region "------------Round_Int: Lam tron so nguyen-----------"
    Public Function Round_Int(ByVal myNumber As Integer, ByVal myDigit As Integer) As Integer
        Select Case myDigit
            Case -1
                myNumber = myNumber + 5
                myNumber = myNumber \ 10
                myNumber = myNumber * 10
            Case -2
                myNumber = myNumber + 50
                myNumber = myNumber \ 100
                myNumber = myNumber * 100
            Case -3
                myNumber = myNumber + 500
                myNumber = myNumber \ 1000
                myNumber = myNumber * 1000
        End Select
        Return myNumber
    End Function
#End Region

#Region "------------In Bản kê, lá nhãn trong thiết lập đi------------"
#Region "------------Bản Kê E2 Đi------------"
    Public Sub Ban_Ke_E2_Di(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal quocte As Integer)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptE2_Ban_ke As New RptE2_Di_Ban_Ke
        Dim rptE2_Receptacle As New RptE2_Di_Receptacle
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim myData_SHCT As DataSet
        Dim myDataTK As DataSet
        Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myNumber As New ConvertNumberToString
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
        Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
        Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
        Dim Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim Ma_Bc_Khai_Thac As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc_Khai_Thac
        Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
        Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).Tong_So_BP
        Dim Tui_So As Integer = myE2_Di.Lay(Id_E2).Tui_So
        Dim Tui_So_Rec As String = CStr(myE2_Di.Lay(Id_E2).Tui_So) & IIf(myE2_Di.Lay(Id_E2).Tui_F = 1, "F", "")

        Dim Ma_Bc As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim myCN38 As New CN38(GConnectionString)
        Dim Ngay_Thang As Integer = myCN38.Lay((myE2_Di.Lay(Id_E2).Id_Chuyen_Thu)).Ngay_Bay
        Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ho_Ten
        Dim Tren2kgNT, Duoi2kgNT, KLTren2kgNT, KLDuoi2kgNT, HHPTTren2kgNT, HHPTDuoi2kgNT As Integer
        Dim Tren2kgLT, Duoi2kgLT, KLTren2kgLT, KLDuoi2kgLT, HHPTTren2kgLT, HHPTDuoi2kgLT As Integer
        Dim Tren5kgQT, Duoi5kgQT, KLTren5kgQT, KLDuoi5kgQT, HHPTTren5kgQT, HHPTDuoi5kgQT As Integer
        Dim i, j, k, T, BP, Tong_HH As Integer
        Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)
        Dim F As Boolean = myE2_Di.Lay(Id_E2).Tui_F
        Dim HH_Phat_Hanh As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Hanh
        Dim HH_Phat_Tra As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Tra
        Dim Tong_So_BP As Integer = myE2_Di.Lay(Id_E2).Tong_So_BP
        Dim Nuoc_Nhan As String
        Dim Despatch_ID, Chuyen_bay, Ten_Duong_Thu As String
        Dim my_Ma_Bc_Duong_Thu_Di As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim IPMC As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).IPMC
        Dim Ma_Nuoc As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).Ma_Nc
        Dim Ten_Nuoc As String = myMa_Nuoc.Lay(Ma_Nuoc).Ten_Nuoc
        Dim Ma_Bc_Goc As Integer
        Dim Ma_Mc_Tra As Integer
        Dim So_Luong_M, So_Luong_D As Integer
        Dim Khoi_Luong_BP As String = "(" & Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP) / 1000) + "  Kg)"
        Dim Khoi_Luong_VoTui As Integer = myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui
        Dim Tong_Khoi_LuongBanKe As String = Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP + myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui) / 1000)
        Dim Loai_D_M As String = ""
        So_Luong_D = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_D
        So_Luong_M = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_M
        If (So_Luong_D > 0) And (So_Luong_M > 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D : " + Convert.ToString(So_Luong_M) + "M"
        ElseIf (So_Luong_D = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_M) + "M"

        ElseIf (So_Luong_M = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D"
        End If


        myNumber.Number = Tong_So_BP
        Dim myData1 As New dataTable
        Dim myData2 As New dataTable
        myData1 = myE1_Di.Danh_Sach_E1(Id_E2).Tables(0)
        'Dim myData_manifest_Le As New dataTable
        'Dim myData_manifest_Chan As New dataTable
        'myData_manifest_Le = myE1_Di.Danh_Sach_E1_ManiFets_Le(Id_E2).Tables(0)
        'myData_manifest_Le.TableName = "E1_Le"
        'myData_manifest_Chan = myE1_Di.Danh_Sach_E1_ManiFets_Chan(Id_E2).Tables(0)
        'myData_manifest_Chan.TableName = "E1_Chan"
        myData2 = myE2_Di.Danh_Sach_Tong_Ket_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)
        Tren2kgNT = 0
        Duoi2kgNT = 0
        KLDuoi2kgNT = 0
        KLTren2kgNT = 0
        HHPTTren2kgNT = 0
        HHPTDuoi2kgNT = 0
        Tren2kgLT = 0
        Duoi2kgLT = 0
        KLDuoi2kgLT = 0
        KLTren2kgLT = 0
        HHPTTren2kgLT = 0
        HHPTDuoi2kgLT = 0
        T = 0
        BP = 0
        Tong_HH = 0
        For i = 0 To myData1.Rows.Count - 1
            If myData1.Rows(i).Item("Nuoc_Nhan") <> "VN" Then
                If myData1.Rows(i).Item("Khoi_Luong") > 5000 Then
                    Tren5kgQT += 1
                    KLTren5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi5kgQT += 1
                    KLDuoi5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            ElseIf myDanh_Muc_BC.Lay(myData1.Rows(i).Item("Ma_Bc_Goc")).Ma_Tinh = myDanh_Muc_BC.Lay(myData1.Rows(i).Item("Ma_Bc_Tra")).Ma_Tinh And myData1.Rows(i).Item("Ma_Bc_Goc") <> 0 Then
                If myData1.Rows(i).Item("Khoi_Luong") > 2000 Then
                    Tren2kgNT += 1
                    KLTren2kgNT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren2kgNT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi2kgNT += 1
                    KLDuoi2kgNT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi2kgNT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            Else
                If myData1.Rows(i).Item("Khoi_Luong") > 2000 Then
                    Tren2kgLT += 1
                    KLTren2kgLT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren2kgLT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi2kgLT += 1
                    KLDuoi2kgLT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi2kgLT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            End If
            Tong_HH = HHPTDuoi2kgNT + HHPTTren2kgNT + HHPTDuoi2kgLT + HHPTTren2kgLT + HHPTDuoi5kgQT + HHPTTren5kgQT

        Next

        ''Tên bưu cục khai thác

        _pThamSo.Value = myMa_Bc_Khai_Thac.Lay(Ma_Bc_Khai_Thac).Ten_Bc_Khai_Thac
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''đến/To Ma_Bc

        _pThamSo.Value = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ten_Duong_Thu
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Ten_Duong_Thu").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Duong_Thu").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        ''Chuyến thư
        _pThamSo.Value = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        ''Túi số
        If quocte = 0 Then
            _pThamSo.Value = Tui_So
        Else
            _pThamSo.Value = Tui_So_Rec
        End If
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tui_So").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Tui_So").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Túi số
        _pThamSo.Value = Tui_So.ToString("####0000")
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("SoTui").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("SoTui").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        ''Gửi đến

        _pThamSo.Value = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        ''Giờ
        Dim Str As String = ""
        Select Case Phan_Loai
            Case 0
                Str = "Bưu tá "
            Case 1
                Str = "Giao dịch "
            Case 2
                Str = "Khai thác "
            Case 3
                Str = "Khai thác "
            Case 4
                Str = "Khai thác "
        End Select
        _pThamSo.Value = Gio
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Gio").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Gio").ApplyCurrentValues(pvCollection)
        End If

        pvCollection.Clear()
        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Họ tên
        _pThamSo.Value = Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        If quocte = 0 Then
            rptE2_Ban_ke.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvCollection)
        Else
            rptE2_Receptacle.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Tổng Số BP        
        Dim Tong_So_BP_chu As String = CStr(Tong_So_BP) & " : " & Loai_D_M & " " & Khoi_Luong_BP
        If quocte = 0 Then
            _pThamSo.Value = myNumber.StringNumber + "bưu gửi"
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)
        Else
            _pThamSo.Value = Tong_So_BP_chu
            pvCollection.Add(_pThamSo)
            rptE2_Receptacle.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        Dim StrHHPH As String = Ma_Bc_Khai_Thac.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc_Khai_Thac).Ten_Buu_Cuc + " được hưởng: " + HH_Phat_Hanh.ToString + vbNewLine
        Dim StrHHPT As String = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc + " được hưởng:  " + Tong_HH.ToString + vbNewLine
        Dim StrNT As String = "Nội tỉnh: " + "Trên 2Kg: " + Tren2kgNT.ToString + "/" + KLTren2kgNT.ToString + "/" + HHPTTren2kgNT.ToString + "  " + "Dưới 2Kg: " + Duoi2kgNT.ToString + "/" + KLDuoi2kgNT.ToString + "/" + HHPTDuoi2kgNT.ToString + vbNewLine
        Dim StrLT As String = "Liên tỉnh: " + "Trên 2Kg: " + Tren2kgLT.ToString + "/" + KLTren2kgLT.ToString + "/" + HHPTTren2kgLT.ToString + "  " + "Dưới 2Kg: " + Duoi2kgLT.ToString + "/" + KLDuoi2kgLT.ToString + "/" + HHPTDuoi2kgLT.ToString + vbNewLine
        Dim StrQT As String = "Quốc tế: " + "Trên 5Kg: " + Tren5kgQT.ToString + "/" + KLTren5kgQT.ToString + "/" + HHPTTren5kgQT.ToString + "  " + "Dưới 5Kg: " + Duoi5kgQT.ToString + "/" + KLDuoi5kgQT.ToString + "/" + HHPTDuoi5kgQT.ToString
        If Tren2kgNT = 0 And Duoi2kgNT = 0 Then
            StrNT = ""
        End If
        If Tren2kgLT = 0 And Duoi2kgLT = 0 Then
            StrLT = ""
        End If
        If Tren5kgQT = 0 And Duoi5kgQT = 0 Then
            StrQT = ""
        End If
        If Phan_Loai = 0 Or Phan_Loai = 1 Or Phan_Loai = 5 Then
            StrHHPH = ""
        End If
        '' Tạo bảng
        Dim dataTable As New dataTable("Tong_Ket")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("TK", GetType(String))
        dataTable.Columns.Add(colWork)
        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("TK") = StrHHPH + StrHHPT + StrNT + StrLT + StrQT
        dataTable.Rows.Add(row)
        ''Tổng kết chuyến thư.
        ''BANG 2: Tổng kết chuyến thư.
        Dim Tuiso As String = ""
        '' Tạo bảng tổng kết ''
        Dim dataTableTKCT As New dataTable("Tong_Ket_Chuyen_Thu")
        'Tao ra cac cot cua bang nay
        Dim colTKC As DataColumn = New DataColumn("TKCT", GetType(String))
        dataTableTKCT.Columns.Add(colTKC)
        'Them du lieu vao

        If F = True Then
            For k = 0 To myData2.Rows.Count - 1
                T = myData2.Rows(k).Item("Tui_So")
                BP = myData2.Rows(k).Item("Tong_So_BP")
                Tuiso += "Tờ số "
                Select Case T.ToString.Trim.Length
                    Case 1
                        Tuiso += T.ToString.Trim + "      :  " + BP.ToString + "  EMS;" + vbNewLine
                    Case 2
                        Tuiso += T.ToString.Trim + "    :  " + BP.ToString + "  EMS;" + vbNewLine
                    Case 3
                        Tuiso += T.ToString.Trim + "    :  " + BP.ToString + "  EMS;" + vbNewLine
                End Select
                '+ T.ToString.PadLeft(3) + "      :  " + BP.ToString.PadRight(3) + "  EMS;" + vbNewLine
            Next

            Dim rowTKCT As DataRow = dataTableTKCT.NewRow()
            rowTKCT("TKCT") = Tuiso + "Tổng cộng  :  " + Tong_So_BP_CT.ToString + "  EMS."
            dataTableTKCT.Rows.Add(rowTKCT)

            _pThamSo.Value = "BẢNG TỔNG KẾT CHUYẾN THƯ"
            pvCollection.Add(_pThamSo)
            If quocte = 0 Then
                rptE2_Ban_ke.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            Else
                rptE2_Receptacle.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            End If
            pvCollection.Clear()
        Else
            Dim rowTKCT As DataRow = dataTableTKCT.NewRow()
            rowTKCT("TKCT") = ""
            dataTableTKCT.Rows.Add(rowTKCT)

            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            If quocte = 0 Then
                rptE2_Ban_ke.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            Else
                rptE2_Receptacle.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            End If
            pvCollection.Clear()
        End If
        myData = myE2_Di.E2_Di_Ban_Ke(Id_E2)
        myData.Tables(0).TableName = "E2_Di_Ban_ke"
        dataTable.TableName = "Tong_Ket"
        dataTableTKCT.TableName = "Tong_Ket_Chuyen_Thu"
        myData.Tables.Add(dataTable.Copy)
        myData.Tables.Add(dataTableTKCT.Copy)
        'myData.Tables.Add(myData_manifest_Chan.Copy)
        'myData.Tables.Add(myData_manifest_Le.Copy)

        Dim myTable As New dataTable
        If quocte = 1 Then
            myData_SHCT = myE2_Di.So_hieu_chuyen_thu(Id_E2)
            myData_SHCT.Tables(0).TableName = "So_hieu_chuyen_thu"
            myData.Tables.Add(myData_SHCT.Tables(0).Copy)
            myTable = myData_SHCT.Tables(0)

        End If


        ''Despatch_ID
        Despatch_ID = Convert.ToString(myTable.Rows(0).Item(0)) + Convert.ToString(myTable.Rows(0).Item(1)) + _
                      "A" + Convert.ToString(myTable.Rows(0).Item(4)) + Convert.ToString(myTable.Rows(0).Item(2)) + _
                       Convert.ToString(Convert.ToInt32(myTable.Rows(0).Item(3)).ToString("0000"))
        _pThamSo.Value = Despatch_ID
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Despatch_ID").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        'Chuyen_bay
        Chuyen_bay = Convert.ToString(myTable.Rows(0).Item(6))
        _pThamSo.Value = Chuyen_bay
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_bay").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        'Mabc_Chu
        _pThamSo.Value = IPMC
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Mabc_Chu").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Ten_Nuoc
        _pThamSo.Value = Ten_Nuoc
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Nuoc").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        'Khoi_Luong_BP 
        _pThamSo.Value = Khoi_Luong_BP
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Khoi_Luong_BP").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        'Tong_Khoi_LuongBanKe()
        _pThamSo.Value = Tong_Khoi_LuongBanKe
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Tong_Khoi_LuongBanKe").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Loai_D_M
        _pThamSo.Value = Loai_D_M
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Loai_D_M").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()





        If quocte = 0 Then
            rptE2_Ban_ke.SetDataSource(myData)
            FrmView.CrystalReportViewer1.ReportSource = rptE2_Ban_ke
        Else
            rptE2_Receptacle.SetDataSource(myData)
            FrmView.CrystalReportViewer1.ReportSource = rptE2_Receptacle
        End If
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            If quocte = 0 Then
                rptE2_Ban_ke.PrintToPrinter(Soban, True, 0, 0)
            Else
                rptE2_Receptacle.PrintToPrinter(Soban, True, 0, 0)
            End If
        End If
    End Sub
#End Region

#Region "------------Ban_Ke_E2_Di_Receptacle------------"
    Public Sub Ban_Ke_E2_Di_Receptacle_tmp(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal quocte As Integer)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptE2_Receptacle As New RptE2_Di_Receptacle
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim myData_SHCT As DataSet
        Dim myDataTK As DataSet
        Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myNumber As New ConvertNumberToString
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
        Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
        Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
        Dim Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim Ma_Bc_Khai_Thac As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc_Khai_Thac
        Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
        Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).Tong_So_BP
        'Dim Tui_So As Integer = myE2_Di.Lay(Id_E2).Tui_So
        'Dim Tui_So_Rec As String = CStr(myE2_Di.Lay(Id_E2).Tui_So) & IIf(myE2_Di.Lay(Id_E2).Tui_F = 1, "F", "")

        Dim Ma_Bc As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim myCN38 As New CN38(GConnectionString)
        Dim Ngay_Thang As Integer = myCN38.Lay((myE2_Di.Lay(Id_E2).Id_Chuyen_Thu)).Ngay_Bay
        Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ho_Ten
        Dim i, j, k, T, BP, Tong_HH As Integer
        Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)
        Dim F As Boolean = myE2_Di.Lay(Id_E2).Tui_F
        Dim Tong_So_BP As Integer = myE2_Di.Lay(Id_E2).Tong_So_BP
        Dim Nuoc_Nhan As String
        Dim Despatch_ID, Chuyen_bay, Ten_Duong_Thu As String
        Dim my_Ma_Bc_Duong_Thu_Di As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
        Dim IPMC As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).IPMC
        Dim Ma_Nuoc As String = myDanh_Muc_BC.Lay(my_Ma_Bc_Duong_Thu_Di).Ma_Nc
        Dim Ten_Nuoc As String = myMa_Nuoc.Lay(Ma_Nuoc).Ten_Nuoc
        Dim Ma_Bc_Goc As Integer
        Dim Ma_Mc_Tra As Integer
        Dim So_Luong_M, So_Luong_D As Integer
        Dim Khoi_Luong_BP As String = "(" & Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP) / 1000) + "  Kg)"
        Dim Khoi_Luong_VoTui As Integer = myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui
        Dim Tong_Khoi_LuongBanKe As String = Convert.ToString(Convert.ToInt32(myE2_Di.Lay(Id_E2).Khoi_Luong_BP + myE2_Di.Lay(Id_E2).Khoi_Luong_Vo_Tui) / 1000)
        Dim Loai_D_M As String = ""
        So_Luong_D = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_D
        So_Luong_M = myE1_Di.Danh_Sach_E1_Loai_D_M(Id_E2).So_Luong_M
        If (So_Luong_D > 0) And (So_Luong_M > 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D : " + Convert.ToString(So_Luong_M) + "M"
        ElseIf (So_Luong_D = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_M) + "M"

        ElseIf (So_Luong_M = 0) Then
            Loai_D_M = Convert.ToString(So_Luong_D) + "D"
        End If


        myNumber.Number = Tong_So_BP
        Dim myData1 As New DataTable
        Dim myData2 As New DataTable
        myData1 = myE1_Di.Danh_Sach_E1(Id_E2).Tables(0)
        myData2 = myE2_Di.Danh_Sach_Tong_Ket_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)
        T = 0
        BP = 0
        Tong_HH = 0
        ''Tên bưu cục khai thác

        _pThamSo.Value = myMa_Bc_Khai_Thac.Lay(Ma_Bc_Khai_Thac).Ten_Bc_Khai_Thac
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''đến/To Ma_Bc
        _pThamSo.Value = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ten_Duong_Thu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Duong_Thu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Chuyến thư
        _pThamSo.Value = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()


        _pThamSo.Value = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Giờ
        Dim Str As String = ""
        _pThamSo.Value = Gio
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Họ tên
        _pThamSo.Value = Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        ''Tổng Số BP        
        Dim Tong_So_BP_chu As String = CStr(Tong_So_BP) & " : " & Loai_D_M & " " & Khoi_Luong_BP
        _pThamSo.Value = Tong_So_BP_chu
        pvCollection.Add(_pThamSo)
        rptE2_Receptacle.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        myData = myE2_Di.E2_Di_Ban_Ke_Receptacle(Id_E2)
        myData.Tables(0).TableName = "E2_Di_Ban_Ke_Receptacle"

        Dim myTable As New DataTable
        If quocte = 1 Then
            myData_SHCT = myE2_Di.So_hieu_chuyen_thu(Id_E2)
            myData_SHCT.Tables(0).TableName = "So_hieu_chuyen_thu"
            myData.Tables.Add(myData_SHCT.Tables(0).Copy)
            myTable = myData_SHCT.Tables(0)
        End If


        ''Despatch_ID
        Despatch_ID = Convert.ToString(myTable.Rows(0).Item(0)) + Convert.ToString(myTable.Rows(0).Item(1)) + _
                      "A" + Convert.ToString(myTable.Rows(0).Item(4)) + Convert.ToString(myTable.Rows(0).Item(2)) + _
                       Convert.ToString(Convert.ToInt32(myTable.Rows(0).Item(3)).ToString("0000"))
        _pThamSo.Value = Despatch_ID
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Despatch_ID").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        'Chuyen_bay
        Chuyen_bay = Convert.ToString(myTable.Rows(0).Item(6))
        _pThamSo.Value = Chuyen_bay
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Chuyen_bay").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        'Mabc_Chu
        _pThamSo.Value = IPMC
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Mabc_Chu").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Ten_Nuoc
        _pThamSo.Value = Ten_Nuoc
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Ten_Nuoc").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()
        'Khoi_Luong_BP 
        _pThamSo.Value = Khoi_Luong_BP
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Khoi_Luong_BP").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        'Tong_Khoi_LuongBanKe()
        _pThamSo.Value = Tong_Khoi_LuongBanKe
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Tong_Khoi_LuongBanKe").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()

        ''Loai_D_M
        _pThamSo.Value = Loai_D_M
        pvCollection.Add(_pThamSo)
        If quocte = 1 Then
            rptE2_Receptacle.DataDefinition.ParameterFields("Loai_D_M").ApplyCurrentValues(pvCollection)
        End If
        pvCollection.Clear()



        rptE2_Receptacle.SetDataSource(myData)
        FrmView.CrystalReportViewer1.ReportSource = rptE2_Receptacle
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptE2_Receptacle.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Bản Kê E2 Despatch------------"
    Public Sub Ban_Ke_E2_Di_Despatch(ByVal Id_Chuyen_Thu As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal IsNDD_EMS As Boolean)
        Dim myChuyenThuDi As New Chuyen_Thu_Di(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptE2_Di_Manifest
        Dim myDataSet As New DataSet
        Dim myTable1 As New DataTable
        Dim myTable2 As New DataTable

        Dim idx As Integer
        Dim So_Luong_D As Integer = 0
        Dim So_Luong_M As Integer = 0
        Dim Loai_D_M As String = ""
        Dim Tong_KLBP As Double
        Dim Tong_So_BP As String

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable1 = myChuyenThuDi.Chuyen_thu_di_despatch_manifest(Id_Chuyen_Thu).Tables(0)
        myTable2 = myChuyenThuDi.Chuyen_Thu_Di_Ban_Ke_DesManifest(Id_Chuyen_Thu).Tables(0)
        'Dat ten table cho phu hop
        myTable1.TableName = "Chuyen_thu_di_despatch"
        myTable2.TableName = "Chuyen_Thu_Di_Ban_Ke_DesPatch"
        Tong_KLBP = myTable1.Rows(0).Item("Tong_KLBP") / 1000

        For idx = 0 To myTable2.Rows.Count - 1
            If myTable2.Rows(idx).Item("Phan_Loai") = "D" Then
                So_Luong_D += 1
            Else
                So_Luong_M += 1
            End If
        Next idx
        If So_Luong_D > 0 And So_Luong_M > 0 Then
            Loai_D_M = So_Luong_D & "D:" & So_Luong_M & "M"
        Else
            If So_Luong_D > 0 Then
                Loai_D_M = So_Luong_D & "D"
            Else
                Loai_D_M = So_Luong_M & "M"
            End If
        End If
        Tong_So_BP = (So_Luong_D + So_Luong_M) & " : " & Loai_D_M & " (" & Tong_KLBP.ToString("##0.##0") & " kg)"

        pvCollection.Clear()
        _pThamSo.Value = Tong_So_BP
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)

        ''NDD  
        Dim NDD_EMS As String = "" 'CStr(Tong_So_BP)
        NDD_EMS = IIf(IsNDD_EMS, "NDD", "")
        _pThamSo.Value = NDD_EMS
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("NDD_EMS").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Dua vao Dataset
        myDataSet.Tables.Add(myTable1.Copy)
        myDataSet.Tables.Add(myTable2.Copy)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Bản Kê E2 Despatch 3 Column------------"
    Public Sub Ban_Ke_E2_Di_Despatch_3Cot(ByVal Id_Chuyen_Thu As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myChuyenThuDi As New Chuyen_Thu_Di(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptE2_Di_Manifest_3cot
        Dim myDataSet As New DataSet
        Dim myTable1 As New DataTable
        Dim myTable2 As New DataTable
        Dim myTableCot1 As New DataTable
        Dim myTableCot2 As New DataTable
        Dim myTableCot3 As New DataTable
        Dim myTableAll As New DataTable("E2_Di_Despatch_3Col")

        Dim idx As Integer
        Dim So_Luong_D As Integer = 0
        Dim So_Luong_M As Integer = 0
        Dim Loai_D_M As String = ""
        Dim Tong_KLBP As Double
        Dim Tong_So_BP As String

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Lay du lieu
        myTable1 = myChuyenThuDi.Chuyen_thu_di_despatch_manifest(Id_Chuyen_Thu).Tables(0)
        myTable2 = myChuyenThuDi.Chuyen_Thu_Di_Ban_Ke_DesManifest(Id_Chuyen_Thu).Tables(0)
        'Kiem tra xem co du lieu khong
        If myTable1.Rows.Count = 0 Then
            MsgBox("Không có dữ liệu cho bản kê này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If
        If myTable2.Rows.Count = 0 Then
            MsgBox("Không có dữ liệu cho bản kê này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If
        '------------------------
        'Dat ten table cho phu hop
        myTable1.TableName = "Chuyen_thu_di_despatch"

        'Them cac field cho cac bang du lieu tuong ung voi tung cot tren trang in
        'Column 1 - 2 - 3 (Field: STT)
        Dim colSTT As DataColumn
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot1.Columns.Add(colSTT)
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot2.Columns.Add(colSTT)
        colSTT = New DataColumn("STT", GetType(String))
        myTableCot3.Columns.Add(colSTT)

        'Column 1 - 2 - 3 (Field: Ma_E1)
        Dim colMa_E1 As DataColumn
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot1.Columns.Add(colMa_E1)
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot2.Columns.Add(colMa_E1)
        colMa_E1 = New DataColumn("Ma_E1", GetType(String))
        myTableCot3.Columns.Add(colMa_E1)

        'Column 1 - 2 - 3 (Field: Tui_So)
        Dim colTui_So As DataColumn
        colTui_So = New DataColumn("Tui_So", GetType(String))
        myTableCot1.Columns.Add(colTui_So)
        colTui_So = New DataColumn("Tui_So", GetType(String))
        myTableCot2.Columns.Add(colTui_So)
        colTui_So = New DataColumn("Tui_So", GetType(String))
        myTableCot3.Columns.Add(colTui_So)

        'All
        Dim colALL As DataColumn
        colALL = New DataColumn("STT_1", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_1", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Tui_So_1", GetType(String))
        myTableAll.Columns.Add(colALL)

        colALL = New DataColumn("STT_2", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_2", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Tui_So_2", GetType(String))
        myTableAll.Columns.Add(colALL)

        colALL = New DataColumn("STT_3", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Ma_E1_3", GetType(String))
        myTableAll.Columns.Add(colALL)
        colALL = New DataColumn("Tui_So_3", GetType(String))
        myTableAll.Columns.Add(colALL)

        'Bat dau phan xu ly dang trang in
        Dim i, j, k As Integer
        Dim myRowCol As DataRow
        Dim myRowCol1 As DataRow
        Dim myRowCol2 As DataRow
        Dim myRowCol3 As DataRow
        Dim myRowColALL As DataRow
        Const MaxRow As Integer = 15   'So dong toi da tren 1 trang in        
        'Step0: Tinh toan so lieu thuc truoc khi them cac dong blank
        For idx = 0 To myTable2.Rows.Count - 1
            If myTable2.Rows(idx).Item("Phan_Loai") = "D" Then
                So_Luong_D += 1
            Else
                So_Luong_M += 1
            End If
        Next idx

        'Step1: Them du lieu vao cho day trang
        Dim so_du As Integer = myTable2.Rows.Count Mod MaxRow * 3
        Do While so_du < MaxRow * 3  'in 3 cot
            myRowCol = myTable2.NewRow()
            myRowCol("Id_E2") = "  "
            myRowCol("Ma_E1") = "  "
            myRowCol("Tui_So") = "  "
            myTable2.Rows.Add(myRowCol)
            so_du = so_du + 1
        Loop
        'Step 2: Put data into Column (1,2,3)
        i = 0  'index of root table
        j = 0  'index of column of print page
        For i = 0 To myTable2.Rows.Count - 1
            'Kiem tra neu da ghi day du lieu tren trang in thi chuyen sang trang tiep theo
            'Quay lai ghi vao du lieu vao table column 1
            If j = MaxRow * 3 Then j = 0
            'Kiem tra xem se ghi vao Colunm nao
            If j < MaxRow * 1 Then 'Col 1
                k = 1
            ElseIf j < MaxRow * 2 Then 'Col 2
                k = 2
            Else  'Col 3
                k = 3
            End If
            Select Case k
                Case 1
                    myRowCol1 = myTableCot1.NewRow()
                    If ((Trim(myTable2.Rows(i).Item("Ma_E1")) = "") Or (Trim(myTable2.Rows(i).Item("Tui_So")) = "")) Then
                        myRowCol1("STT") = "   "
                    Else
                        myRowCol1("STT") = (i + 1).ToString("000")
                    End If
                    myRowCol1("Ma_E1") = myTable2.Rows(i).Item("Ma_E1")
                    myRowCol1("Tui_So") = myTable2.Rows(i).Item("Tui_So")
                    myTableCot1.Rows.Add(myRowCol1)
                Case 2
                    myRowCol2 = myTableCot2.NewRow()
                    If ((Trim(myTable2.Rows(i).Item("Ma_E1")) = "") Or (Trim(myTable2.Rows(i).Item("Tui_So")) = "")) Then
                        myRowCol2("STT") = "   "
                    Else
                        myRowCol2("STT") = (i + 1).ToString("000")
                    End If
                    myRowCol2("Ma_E1") = myTable2.Rows(i).Item("Ma_E1")
                    myRowCol2("Tui_So") = myTable2.Rows(i).Item("Tui_So")
                    myTableCot2.Rows.Add(myRowCol2)
                Case 3
                    myRowCol3 = myTableCot3.NewRow()
                    If ((Trim(myTable2.Rows(i).Item("Ma_E1")) = "") Or (Trim(myTable2.Rows(i).Item("Tui_So")) = "")) Then
                        myRowCol3("STT") = "   "
                    Else
                        myRowCol3("STT") = (i + 1).ToString("000")
                    End If
                    myRowCol3("Ma_E1") = myTable2.Rows(i).Item("Ma_E1")
                    myRowCol3("Tui_So") = myTable2.Rows(i).Item("Tui_So")
                    myTableCot3.Rows.Add(myRowCol3)
            End Select
            j = j + 1
        Next i
        'Doc du lieu tu 3 bang va ghi vao bang ALL
        For i = 0 To myTableCot1.Rows.Count - 1
            myRowColALL = myTableAll.NewRow()
            myRowColALL("STT_1") = myTableCot1.Rows(i).Item("STT")
            myRowColALL("Ma_E1_1") = myTableCot1.Rows(i).Item("Ma_E1")
            myRowColALL("Tui_So_1") = myTableCot1.Rows(i).Item("Tui_So")

            myRowColALL("STT_2") = myTableCot2.Rows(i).Item("STT")
            myRowColALL("Ma_E1_2") = myTableCot2.Rows(i).Item("Ma_E1")
            myRowColALL("Tui_So_2") = myTableCot2.Rows(i).Item("Tui_So")

            myRowColALL("STT_3") = myTableCot3.Rows(i).Item("STT")
            myRowColALL("Ma_E1_3") = myTableCot3.Rows(i).Item("Ma_E1")
            myRowColALL("Tui_So_3") = myTableCot3.Rows(i).Item("Tui_So")

            myTableAll.Rows.Add(myRowColALL)
        Next i

        Tong_KLBP = myTable1.Rows(0).Item("Tong_KLBP") / 1000

        'For idx = 0 To myTable2.Rows.Count - 1
        '    If myTable2.Rows(idx).Item("Phan_Loai") = "D" Then
        '        So_Luong_D += 1
        '    Else
        '        So_Luong_M += 1
        '    End If
        'Next idx
        If So_Luong_D > 0 And So_Luong_M > 0 Then
            Loai_D_M = So_Luong_D & "D:" & So_Luong_M & "M"
        Else
            If So_Luong_D > 0 Then
                Loai_D_M = So_Luong_D & "D"
            Else
                Loai_D_M = So_Luong_M & "M"
            End If
        End If
        Tong_So_BP = (So_Luong_D + So_Luong_M) & " : " & Loai_D_M & " (" & Tong_KLBP.ToString("##0.##0") & " kg)"

        pvCollection.Clear()
        _pThamSo.Value = Tong_So_BP
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)


        'Dua vao Dataset
        myDataSet.Tables.Add(myTable1.Copy)
        myDataSet.Tables.Add(myTableAll.Copy)

        'Gan DataSource cho report
        rptVIEW.SetDataSource(myDataSet)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Bản Kê E2 Đến------------"
    Public Sub Ban_Ke_E2_Den(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myE2_Den As New E2_Den(GConnectionString)
        Dim myE2_Den_ChiTiet As New E2_Den_Chi_Tiet
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim rptE2_Ban_ke As New RptE2_Den_Ban_Ke
        Dim myHamdungchung As New Ham_Dung_Chung
        Dim myData As DataSet
        Dim myNumber As New ConvertNumberToString
        Dim myE1_Den As New E1_Den(GConnectionString)
        Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
        Dim myMa_Bc_Khai_Thac As New Ma_BC_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
        Dim Id_Duong_Thu As String = myE2_Den.Lay(Id_E2).Id_Duong_Thu
        Dim Phan_Loai As Integer = myDuong_Thu_Den.Lay(Id_Duong_Thu).Id_Phan_Loai
        Dim Ma_BC_Khai_Thac As Integer = myDuong_Thu_Den.Lay(Id_Duong_Thu).Ma_Bc
        Dim Id_Chuyen_Thu As String = myE2_Den.Lay(Id_E2).Id_Chuyen_Thu
        Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Den.Lay(Id_Chuyen_Thu).Tong_So_BP
        Dim Tui_So As Integer = myE2_Den.Lay(Id_E2).Tui_So
        Dim Ma_Bc As Integer = Convert.ToInt32(Id_E2.Substring(6, 6))
        Dim Ngay_Thang As Integer = myE2_Den.Lay(Id_E2).Ngay_Dong
        Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Den.Lay(Id_E2).Gio_Dong)
        Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Den.Lay_Id_Nguoi_Dung(Id_E2)).Ho_Ten
        Dim Tren2kgNT, Duoi2kgNT, KLTren2kgNT, KLDuoi2kgNT, HHPTTren2kgNT, HHPTDuoi2kgNT As Integer
        Dim Tren2kgLT, Duoi2kgLT, KLTren2kgLT, KLDuoi2kgLT, HHPTTren2kgLT, HHPTDuoi2kgLT As Integer
        Dim Tren5kgQT, Duoi5kgQT, KLTren5kgQT, KLDuoi5kgQT, HHPTTren5kgQT, HHPTDuoi5kgQT As Integer
        Dim i, j, k, T, BP, Tong_HH As Integer
        Dim F As Boolean = myE2_Den.Lay(Id_E2).Tui_F
        Dim HH_Phat_Hanh As Integer = myE2_Den.Lay(Id_E2).HH_Phat_Hanh
        Dim HH_Phat_Tra As Integer = myE2_Den.Lay(Id_E2).HH_Phat_Tra
        Dim Tong_So_BP As Integer = myE2_Den.Lay(Id_E2).Tong_So_BP
        myNumber.Number = Tong_So_BP
        Dim myData1 As New dataTable
        Dim myData2 As New dataTable
        myData1 = myE1_Den.Danh_Sach_E1(Id_E2).Tables(0)
        myData2 = myE2_Den.Danh_Sach_Tong_Ket_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)
        Tren2kgNT = 0
        Duoi2kgNT = 0
        KLDuoi2kgNT = 0
        KLTren2kgNT = 0
        HHPTTren2kgNT = 0
        HHPTDuoi2kgNT = 0
        Tren2kgLT = 0
        Duoi2kgLT = 0
        KLDuoi2kgLT = 0
        KLTren2kgLT = 0
        HHPTTren2kgLT = 0
        HHPTDuoi2kgLT = 0
        T = 0
        BP = 0
        Tong_HH = 0
        For i = 0 To myData1.Rows.Count - 1
            If myData1.Rows(i).Item("Nuoc_Nhan") <> "VN" Then
                If myData1.Rows(i).Item("Khoi_Luong") > 5000 Then
                    Tren5kgQT += 1
                    KLTren5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi5kgQT += 1
                    KLDuoi5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            ElseIf myDanh_Muc_BC.Lay(myData1.Rows(i).Item("Ma_Bc_Goc")).Ma_Tinh = myDanh_Muc_BC.Lay(myData1.Rows(i).Item("Ma_Bc_Tra")).Ma_Tinh And myData1.Rows(i).Item("Ma_Bc_Goc") <> 0 Then
                If myData1.Rows(i).Item("Khoi_Luong") > 2000 Then
                    Tren2kgNT += 1
                    KLTren2kgNT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren2kgNT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi2kgNT += 1
                    KLDuoi2kgNT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi2kgNT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            Else
                If myData1.Rows(i).Item("Khoi_Luong") > 2000 Then
                    Tren2kgLT += 1
                    KLTren2kgLT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren2kgLT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi2kgLT += 1
                    KLDuoi2kgLT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi2kgLT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
            End If
            Tong_HH = HHPTDuoi2kgNT + HHPTTren2kgNT + HHPTDuoi2kgLT + HHPTTren2kgLT + HHPTDuoi5kgQT + HHPTTren5kgQT
        Next

        ''Từ/From
        _pThamSo.Value = Ma_BC_Khai_Thac.ToString + "-" + myDanh_Muc_BC.Lay(Ma_BC_Khai_Thac).Ten_Buu_Cuc
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ma_Bc_Khai_Thac").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Chuyến thư
        _pThamSo.Value = myChuyen_Thu_Den.Lay(Id_Chuyen_Thu).So_Chuyen_Thu
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Chuyen_Thu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Túi số
        _pThamSo.Value = Tui_So
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Tui_So").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Gửi đến
        _pThamSo.Value = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ma_Bc").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Giờ
        _pThamSo.Value = Gio
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Gio").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Ngày Tháng
        _pThamSo.Value = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ngay_Thang").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Họ tên
        _pThamSo.Value = Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        ''Tổng Số BP
        _pThamSo.Value = myNumber.StringNumber + "bưu gửi"
        pvCollection.Add(_pThamSo)
        rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_So_BP").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()
        Dim StrHHPH As String = Ma_BC_Khai_Thac.ToString + "-" + myDanh_Muc_BC.Lay(Ma_BC_Khai_Thac).Ten_Buu_Cuc + " được hưởng: " + HH_Phat_Hanh.ToString + vbNewLine
        Dim StrHHPT As String = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc + " được hưởng:  " + Tong_HH.ToString + vbNewLine
        Dim StrNT As String = "Nội tỉnh: " + "Trên 2Kg: " + Tren2kgNT.ToString + "/" + KLTren2kgNT.ToString + "/" + HHPTTren2kgNT.ToString + "  " + "Dưới 2Kg: " + Duoi2kgNT.ToString + "/" + KLDuoi2kgNT.ToString + "/" + HHPTDuoi2kgNT.ToString + vbNewLine
        Dim StrLT As String = "Liên tỉnh: " + "Trên 2Kg: " + Tren2kgLT.ToString + "/" + KLTren2kgLT.ToString + "/" + HHPTTren2kgLT.ToString + "  " + "Dưới 2Kg: " + Duoi2kgLT.ToString + "/" + KLDuoi2kgLT.ToString + "/" + HHPTDuoi2kgLT.ToString + vbNewLine
        Dim StrQT As String = "Quốc tế: " + "Trên 5Kg: " + Tren5kgQT.ToString + "/" + KLTren5kgQT.ToString + "/" + HHPTTren5kgQT.ToString + "  " + "Dưới 5Kg: " + Duoi5kgQT.ToString + "/" + KLDuoi5kgQT.ToString + "/" + HHPTDuoi5kgQT.ToString
        If Tren2kgNT = 0 And Duoi2kgNT = 0 Then
            StrNT = ""
        End If
        If Tren2kgLT = 0 And Duoi2kgLT = 0 Then
            StrLT = ""
        End If
        If Tren5kgQT = 0 And Duoi5kgQT = 0 Then
            StrQT = ""
        End If
        If Phan_Loai = 0 Or Phan_Loai = 1 Or Phan_Loai = 5 Then
            StrHHPH = ""
        End If
        '' Tạo bảng
        Dim dataTable As New dataTable("Tong_Ket")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("TK", GetType(String))
        dataTable.Columns.Add(colWork)
        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("TK") = StrHHPH + StrHHPT + StrNT + StrLT + StrQT
        dataTable.Rows.Add(row)

        ''Tổng kết chuyến thư.
        Dim Tuiso As String = ""
        If F = True Then
            For k = 0 To myData2.Rows.Count - 1
                T = myData2.Rows(k).Item("Tui_So")
                BP = myData2.Rows(k).Item("Tong_So_BP")
                Tuiso += "Tờ số " + T.ToString + "      :  " + BP.ToString + "  EMS;" + vbNewLine
            Next
            _pThamSo.Value = Tuiso + "Tổng cộng  :  " + Tong_So_BP_CT.ToString + "  EMS."
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "BẢNG TỔNG KẾT CHUYẾN THƯ"
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
        Else
            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("Tong_Ket_Chuyen_Thu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = ""
            pvCollection.Add(_pThamSo)
            rptE2_Ban_ke.DataDefinition.ParameterFields("CHAN").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
        End If
        myData = myE2_Den.E2_Den_Ban_Ke(Id_E2)
        myData.Tables.Add(dataTable.Copy)
        rptE2_Ban_ke.SetDataSource(myData)
        FrmView.CrystalReportViewer1.ReportSource = rptE2_Ban_ke
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptE2_Ban_ke.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------BC_37report------------"
    Public Sub BC_37report(ByVal ID_Chuyen_Thu As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim mytable As New DataTable
        Dim myE2_Di As New E2_Di(GConnectionString)
        mytable = myE2_Di.E2_Di_BC37(ID_Chuyen_Thu).Tables(0)
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)


        Dim FrmView As New FrmViewReports
        Dim rptbc37 As New RptBC37report


        ''Họ tên
        p_thamso.Value = GHo_Ten
        pvcollection.Add(p_thamso)
        rptbc37.DataDefinition.ParameterFields("Ho_Ten").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()


        rptbc37.SetDataSource(mytable)
        FrmView.CrystalReportViewer1.ReportSource = rptbc37
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptbc37.PrintToPrinter(Soban, True, 0, 0)
        End If

    End Sub
#End Region

#Region "------------Ban_Ke_BV10_QT_Di------------"
    Public Sub Ban_Ke_BV10_QT_Di(ByVal Ngay_Bay As Integer, ByVal Ngay_Dong As Integer, ByVal So_Hieu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim m_Data As New DataSet
        'Dim myTable As New DataTable
        Dim myE2_Di As New E2_Di(GConnectionString)

        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)


        Dim FrmView As New FrmViewReports
        Dim rpt_Ban_Ke_BV10_QT_Di As New rpt_Ban_Ke_BV10_QT_Di

        Dim mSo_Hieu As String = Lay_So_Hieu_Chuyen_Bay_In_BV10(So_Hieu)
        Dim mLength As Integer = mSo_Hieu.Length

        If GIn_Ban_Ke_BV10_Theo_Ngay_Dong = True Then
            'm_Data = myE2_Di.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong(Ngay_Bay, Ngay_Dong, Mid(So_Hieu, 1, 5))
            m_Data = myE2_Di.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong_QT(Ngay_Bay, Ngay_Dong, mSo_Hieu, mLength)
        Else
            'm_Data = myE2_Di.E2_Di_Ban_Ke_BV10(Ngay_Bay, Mid(So_Hieu, 1, 5))
            m_Data = myE2_Di.E2_Di_Ban_Ke_BV10_QT(Ngay_Bay, mSo_Hieu, mLength)
        End If

        ''Tiêu đề
        p_thamso.Value = "PHIẾU GIAO TÚI GÓI THƯ TẠI SÂN BAY"
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Bưu cục gửi
        p_thamso.Value = GTen_Buu_Cuc_Khai_Thac
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Gui").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Bưu cục nhận
        If ((Id_Duong_Thu = "01009155300000") Or (Id_Duong_Thu = "07009155300000")) Then
            p_thamso.Value = "LẠNG SƠN (CHUYỂN TIẾP NANNING)"
            pvcollection.Add(p_thamso)
            rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Nhan").ApplyCurrentValues(pvcollection)
            pvcollection.Clear()
        Else
            p_thamso.Value = "Kho hàng sân bay"
            pvcollection.Add(p_thamso)
            rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Nhan").ApplyCurrentValues(pvcollection)
            pvcollection.Clear()
        End If

        ''Ngày đóng
        p_thamso.Value = Today.ToString("dd/MM/yyyy")
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Ngay_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Giờ đóng
        p_thamso.Value = Now.ToString("hh:mm")
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Gio_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Số hiệu chuyến bay
        'p_thamso.Value = Mid(So_Hieu, 1, 5)
        p_thamso.Value = mSo_Hieu
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("So_Hieu_Chuyen_Bay").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()


        ''Bưu cục khai thác
        p_thamso.Value = GTen_Buu_Cuc_Khai_Thac
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Khai_Thac").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Người dùng
        p_thamso.Value = GHo_Ten
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Nguoi_Dung").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()


        'Đặt Tên Table cho phù hợp
        m_Data.Tables(0).TableName = "Ban_Ke_BV10_QT_Di"
        'Gán DataSource cho report
        rpt_Ban_Ke_BV10_QT_Di.SetDataSource(m_Data)
        FrmView.CrystalReportViewer1.ReportSource = rpt_Ban_Ke_BV10_QT_Di
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem trên màn hình
            FrmView.ShowDialog()
        Else
            'Đưa ra máy in
            rpt_Ban_Ke_BV10_QT_Di.PrintToPrinter(Soban, True, 0, 0)
        End If

    End Sub
#End Region

#Region "------------Ban_Ke_BV10_Trong_Nuoc------------"
    Public Sub Ban_Ke_BV10_Trong_Nuoc(ByVal Ngay_Bay As Integer, ByVal Ngay_Dong As Integer, ByVal So_Hieu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim m_Data As New DataSet
        'Dim myTable As New DataTable
        Dim myE2_Di As New E2_Di(GConnectionString)

        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)


        Dim FrmView As New FrmViewReports
        Dim rpt_Ban_Ke_BV10_QT_Di As New rpt_Ban_Ke_BV10_QT_Di

        Dim mSo_Hieu As String = Lay_So_Hieu_Chuyen_Bay_In_BV10(So_Hieu)
        Dim mLength As Integer = mSo_Hieu.Length

        'm_Data = myE2_Di.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong(Ngay_Bay, Ngay_Dong, Mid(So_Hieu, 1, 5))
        m_Data = myE2_Di.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong_QT(Ngay_Bay, Ngay_Dong, mSo_Hieu, mLength)

        'Tiêu đề
        'Bưu cục gửi
        'Bưu cục nhận
        'Ngày đóng
        'giờ đóng
        'Số hiệu chuyến bay
        'bưu cục khai thác
        'người dùng
        ''Tiêu đề
        p_thamso.Value = "PHIẾU GIAO TÚI GÓI THƯ"
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Tieu_De").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Bưu cục gửi
        p_thamso.Value = GTen_Buu_Cuc_Khai_Thac
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Gui").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Bưu cục nhận
        p_thamso.Value = "Kho hàng sân bay"
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Ngày đóng
        p_thamso.Value = Today.ToString("dd/MM/yyyy")
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Ngay_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Giờ đóng
        p_thamso.Value = Now.ToString("hh:mm")
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Gio_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Số hiệu chuyến bay
        'p_thamso.Value = Mid(So_Hieu, 1, 5)
        p_thamso.Value = mSo_Hieu
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("So_Hieu_Chuyen_Bay").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()


        ''Bưu cục khai thác
        p_thamso.Value = GTen_Buu_Cuc_Khai_Thac
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Buu_Cuc_Khai_Thac").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        ''Người dùng
        p_thamso.Value = GHo_Ten
        pvcollection.Add(p_thamso)
        rpt_Ban_Ke_BV10_QT_Di.DataDefinition.ParameterFields("Nguoi_Dung").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()


        'Đặt Tên Table cho phù hợp
        m_Data.Tables(0).TableName = "Ban_Ke_BV10_QT_Di"
        'Gán DataSource cho report
        rpt_Ban_Ke_BV10_QT_Di.SetDataSource(m_Data)
        FrmView.CrystalReportViewer1.ReportSource = rpt_Ban_Ke_BV10_QT_Di
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem trên màn hình
            FrmView.ShowDialog()
        Else
            'Đưa ra máy in
            rpt_Ban_Ke_BV10_QT_Di.PrintToPrinter(Soban, True, 0, 0)
        End If

    End Sub
#End Region

#Region "------------Copy File vao Server with Dos------------"
    Public Sub CopyFileToServer(ByVal SourceFile As String, ByVal DesDir As String)
        'Copy file len server
        Shell("CMD /C copy " & SourceFile & " " & DesDir, vbHide)
        'Xoa file tai may Local sau khi da copy
        'Shell("CMD /C del " & SourceFile, vbHide)
    End Sub
#End Region

    '#Region "------------In_Nhan_E4_New------------"
    '    Public Sub In_Nhan_E4_New(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal May_In_Nhan_E4 As String)
    '        Dim mytable As New DataTable
    '        Dim myE2_Di As New E2_Di(GConnectionString)
    '        Dim pvcollection As New ParameterValues
    '        Dim p_thamso As New ParameterDiscreteValue

    '        Dim FrmView As New FrmViewReports
    '        Dim rptNhan_E4_New As New rptNhan_E4_New

    '        mytable = myE2_Di.E2_Di_In_Nhan_E4(Id_E2).Tables(0)
    '        If mytable.Rows.Count = 0 Then
    '            MessageBox.Show("Không có dữ liệu in nhãn E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub
    '        End If
    '        '*** -----Tui_F
    '        Dim F As String = IIf(mytable.Rows(0).Item("Tui_F") = "10", "F", "")
    '        'Dim F = "F"
    '        '*** -----FROM (TEN BC GUI)
    '        Dim Ten_Bc_Gui As String = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Gui"))
    '        'Dim Ten_Bc_Gui = "HN EMS QT"
    '        '*** -----MAIL No
    '        Dim So_Chuyen_Thu As String = CStr(mytable.Rows(0).Item("So_Chuyen_Thu"))
    '        'Dim So_Chuyen_Thu = "122"
    '        '*** -----DATE OF DISPATCH
    '        Dim ngay_dong As Date = CDate(mytable.Rows(0).Item("Ngay_Dong"))
    '        'Dim ngay_dong = "12/09/2008"
    '        '*** -----REC No
    '        Dim RecNo As String = CStr(mytable.Rows(0).Item("RecNo"))
    '        'Dim RecNo = "001/ED"
    '        '*** -----NUMBER OF ITEMS
    '        Dim Tong_So_BP As String = Right("000" & CStr(mytable.Rows(0).Item("Tong_So_BP")), 3)
    '        'Dim Tui_So = "001"
    '        '*** -----Kg
    '        Dim Khoi_Luong As Double = Round(mytable.Rows(0).Item("Khoi_Luong") / 1000 + 0.001, 2)
    '        'Dim Khoi_Luong As Double = 0.3
    '        '*** -----To (TEN BUU CUC NHAN)
    '        Dim Ten_Bc_Nhan As String = CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Nhan"))
    '        '*** -----Bat dau xu ly BarCode
    '        'Khai bao bien tam        
    '        Dim MyBarCode As String
    '        Dim Khoi_Luong_1 As Integer = Round(mytable.Rows(0).Item("Khoi_Luong") / 100, 0)
    '        MyBarCode = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " " & CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " " & mytable.Rows(0).Item("Loai_Chuyen_Thu") & " " & mytable.Rows(0).Item("Loai_Dich_Vu") & " " & Mid(CStr(Year(mytable.Rows(0).Item("Ngay_Dong"))), 4, 1) & " " & Right("0000" + CStr(mytable.Rows(0).Item("So_Chuyen_Thu")), 4) & " " & Right("000" + CStr(mytable.Rows(0).Item("Tui_So")), 3) & " " & mytable.Rows(0).Item("Tui_F") & " " & Right("0000" & CStr(Khoi_Luong_1), 4)

    '        p_thamso.Value = Ten_Bc_Gui
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Gui").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = Ten_Bc_Nhan
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Nhan").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = So_Chuyen_Thu
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pSo_Chuyen_Thu").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = ngay_dong
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pNgay_Dong").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = Convert.ToInt32(RecNo)
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_So").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = Convert.ToInt32(Tong_So_BP)
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pTong_So_BP").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = Khoi_Luong
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pKhoi_Luong").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = F
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_F").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = MyBarCode
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach_Chu").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        p_thamso.Value = MyBarCode.Replace(" ", "")
    '        pvcollection.Add(p_thamso)
    '        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach").ApplyCurrentValues(pvcollection)
    '        pvcollection.Clear()

    '        'Dim mTemp As New myBarcode128


    '        'Dim mBarcode128Data As String = MyBarCode.Replace(" ", "")
    '        'Dim myBarcodeFactory As New Lesnikowski.Barcode.BarcodeFactory
    '        'Dim myBarcode128EAN As Lesnikowski.Barcode.IBaseBarcode
    '        'myBarcode128EAN = myBarcodeFactory.CreateBarcode(Symbology.Code128)
    '        'myBarcode128EAN.Number = mBarcode128Data
    '        'myBarcode128EAN.Save(Application.StartupPath & "\code128temp.prg", ImageType.Png)

    '        Dim myDataSet As New DataSet
    '        myDataSet.Tables.Add(AddImageToCrystal(Application.StartupPath & "\code128temp.prg").Copy)

    '        rptNhan_E4_New.SetDataSource(myDataSet)
    '        FrmView.CrystalReportViewer1.ReportSource = rptNhan_E4_New
    '        Cursor.Current = Cursors.Default
    '        If Preview = True Then
    '            FrmView.ShowDialog()
    '        Else
    '            rptNhan_E4_New.PrintToPrinter(1, True, 0, 0)
    '        End If

    '    End Sub
    '#End Region

#Region "In_Nhan_E4_Label_8Label_KhoA4"
    Public Function In_Nhan_E4_Label_8Label_KhoA4(ByVal mData As DataTable, ByVal Preview As Boolean, ByVal mMay_In As String) As Boolean
        Dim FrmView As New FrmViewReports
        Dim rptinE4 As New rptNhan_E4_Label

        Try
            rptinE4.SetDataSource(mData)
            FrmView.CrystalReportViewer1.ReportSource = rptinE4
            rptinE4.PrintOptions.PaperOrientation = PaperOrientation.Portrait
            rptinE4.PrintOptions.PaperSize = PaperA4
            If Preview = True Then
                FrmView.ShowDialog()
                Cursor.Current = Cursors.Default
            Else
                If mMay_In <> "" Then
                    Dim oPS As New System.Drawing.Printing.PrinterSettings
                    rptinE4.PrintOptions.PrinterName = mMay_In
                End If
                rptinE4.PrintToPrinter(1, True, 0, 0)
                Cursor.Current = Cursors.Default
                MessageBox.Show("Đã in thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
#End Region

#Region "------------Bản kê CN38 - Quốc tế - By TrungDQ - 15/10/08------------"
    Public Sub Ban_Ke_CN38(ByVal Id_chuyen_thu As String, ByVal Preview As Boolean, ByVal Soban As Integer, ByVal IsNDD_EMS As Boolean)
        Dim myDataCN38 As New Ban_Ke_CN38(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptCN38
        Dim myData As New DataSet

        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue

        'Parameter

        ''NDD  
        pvCollection.Clear()
        Dim NDD_EMS As String = "" 'CStr(Tong_So_BP)
        NDD_EMS = IIf(IsNDD_EMS, "NDD", "")
        _pThamSo.Value = NDD_EMS
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("NDD_EMS").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Lay du lieu 
        myData = myDataCN38.Get_Data_CN38(Id_chuyen_thu)
        'Dat ten table cho phu hop
        myData.Tables(1).TableName = "Chuyen_thu_di"
        myData.Tables(0).TableName = "CT_E2_di"
        'Gan DataSource cho report
        rptVIEW.SetDataSource(myData)
        'Truyen rptCN38 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Bản kê CN37 - Quốc tế - By TrungDQ - 24/11/08------------"
    Public Sub Ban_Ke_CN37(ByVal Id_chuyen_thu As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myDataCN37 As New Ban_Ke_CN38(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New rptCN37
        Dim myData As New DataSet

        'Lay du lieu 
        myData = myDataCN37.Get_Data_CN38(Id_chuyen_thu)
        'Dat ten table cho phu hop
        myData.Tables(1).TableName = "Chuyen_thu_di"
        myData.Tables(0).TableName = "CT_E2_di"
        'Gan DataSource cho report
        rptVIEW.SetDataSource(myData)
        'Truyen rptCN37 vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Nhãn CN35 - Quốc tế - By TrungDQ - 29/10/08------------"
    Public Sub In_Nhan_CN35(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Soban As Integer)
        Dim myDataCN35 As New E2_Di(GConnectionString)
        Dim FrmView As New FrmViewReports
        Dim rptVIEW As New RptCN35innhan
        Dim myData As New DataSet
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        'Ma vach = |Ma_BC_KT_CHU|MA_BC_CHU|Loai_Van_Chuyen|Loai_chuyen_Thu|Prefix_YEAR|So_Chuyen_Thu|So_Tui|Tui_F(00,10)|Trong_Luong|
        Dim BarCode As String

        'Lay du lieu 
        myData = myDataCN35.E2_Di_CN35_QT(Id_E2)
        'Dat ten table cho phu hop
        myData.Tables(0).TableName = "NhanCN35"
        'Gan DataSource cho report
        rptVIEW.SetDataSource(myData)
        If myData.Tables(0).Rows.Count > 0 Then
            Dim khoi_luong_1 As Integer
            Dim khoi_luong_2 As Integer
            With myData.Tables(0).Rows(0)
                khoi_luong_1 = .Item("Khoi_Luong") \ 1000
                khoi_luong_2 = Round((.Item("Khoi_Luong") / 1000 - khoi_luong_1), 0)
                BarCode = "*" & .Item("Ma_Bc_Goc_Chu") & .Item("Ma_Bc_Tra_Chu") & .Item("Loai_Van_Chuyen") & Mid(CStr(Year(.Item("Ngay_Dong"))), 4, 1) & Right("0000" + CStr(.Item("So_Chuyen_Thu")), 4) & Right("000" + CStr(.Item("Tui_So")), 3) & .Item("Tui_F") & Right("000" & CStr(khoi_luong_1), 3) & CStr(khoi_luong_2) & "*"
            End With
        Else
            BarCode = "*AAAAAAAAAAAAAAAAAAAAAAAAAAAAA*"
        End If

        'Truyen tham so
        _pThamSo.Value = BarCode
        pvCollection.Add(_pThamSo)
        rptVIEW.DataDefinition.ParameterFields("BarCode").ApplyCurrentValues(pvCollection)

        'Truyen rptCN35innhan vao rptView cua form viewReport
        FrmView.CrystalReportViewer1.ReportSource = rptVIEW
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem tren man hinh
            FrmView.ShowDialog()
        Else
            'Dua ra may in
            rptVIEW.PrintToPrinter(Soban, True, 0, 0)
        End If
    End Sub
#End Region

#Region "------------Nhan CN35 To Text - by TrungDQ - 10/11/08------------"
    Public Sub WriteCN35TEXT(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal soban As Integer, ByVal IsNDD_EMS As Boolean)
        Dim strFileName As String    'File Ink (Full Path)
        Dim strDirPath As String = "C:\EMS_INTERNATIONAL\CN35\"     'Thu muc Local: CN35 file.ink
        Dim strDestination As String  'Thu muc tren server: CN35 file.ink        
        Dim MyTable As New DataTable   'Table luu thong tin CN35
        Dim MyDataSet As New E2_Di(GConnectionString)   'Lay Dataset CN35
        Dim fileTXT As StreamWriter    'TXT
        Dim iSoBan As Integer     'Duyet vong For So ban in
        Dim myKeys As New ModifyRegistry
        Dim strTenMayCN35 As String
        Dim strTenMayInCN35 As String
        Dim Kieu_In_Map As Boolean

        'Lay thong tin may in CN35 trong regitry
        GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
        strTenMayCN35 = IIf(myKeys.Doc("GTen_May_Tinh_CN35") Is Nothing Or myKeys.Doc("GTen_May_Tinh_CN35") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_CN35")))
        strTenMayInCN35 = IIf(myKeys.Doc("GTen_May_In_CN35") Is Nothing Or myKeys.Doc("GTen_May_In_CN35") = "", "", CStr(myKeys.Doc("GTen_May_In_CN35")))
        strDestination = IIf(myKeys.Doc("GThu_Muc_In_CN35_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_CN35_QT_Di") = "", "", CStr(myKeys.Doc("GThu_Muc_In_CN35_QT_Di")))

        If GKieu_In_Map = True Then
            If strDestination = "" Then
                MsgBox("Bạn chưa khai báo thư mục in CN35!!!", MsgBoxStyle.Information, "Thông báo")
                Dim frmHETHONG As New FrmThietLapThamSoHeThong
                If Not Preview Then
                    frmHETHONG.ShowDialog()
                    Exit Sub
                End If
            End If
        Else
            'Kiem tra neu chua khai bao may CN35 thi yeu cau khai bao va show Form ThietLapThamSo 
            If strTenMayCN35 = "" Or strTenMayInCN35 = "" Then
                MsgBox("Bạn chưa khai báo thông tin máy in nhãn CN35!!!" & Chr(13) & "Chọn Ok để tiếp tục thực hiện khai báo", MsgBoxStyle.Information, "Thông báo")
                Dim frmHETHONG As New FrmThietLapThamSoHeThong
                frmHETHONG.ShowDialog()
                Exit Sub
            End If
        End If
        'Lay thong tin CN35 va truyen vao Table
        MyTable = MyDataSet.E2_Di_CN35_QT(Id_E2).Tables(0)
        'Neu khong co ban ghi nao
        If MyTable.Rows.Count = 0 Then
            MsgBox("Không có thông tin cho E2 này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If

        '*** -----Tui_F
        Dim F As String = IIf(MyTable.Rows(0).Item("Tui_F") = "10", "F", "")
        'Dim F = "F"
        '*** -----FROM (TEN BC GUI)
        Dim Ten_Bc_Gui As String = CStr(MyTable.Rows(0).Item("Ten_Bc_Gui"))
        'Dim Ten_Bc_Gui = "HN EMS QT"
        '*** -----MAIL No
        Dim So_Chuyen_Thu As String = CStr(MyTable.Rows(0).Item("So_Chuyen_Thu"))
        'Dim So_Chuyen_Thu = "122"
        '*** -----DATE OF DISPATCH
        Dim ngay_dong As Date = CDate(MyTable.Rows(0).Item("Ngay_Dong"))
        'Dim ngay_dong = "12/09/2008"
        '*** -----REC No
        Dim RecNo As String = CStr(MyTable.Rows(0).Item("RecNo"))
        'Dim RecNo = "001/ED"
        '*** -----NUMBER OF ITEMS
        Dim Tong_So_BP As String = Right("000" & CStr(MyTable.Rows(0).Item("Tong_So_BP")), 3) & IIf(IsNDD_EMS, "(NDD)", "")
        'Dim Tui_So = "001"
        '*** -----Kg
        Dim Khoi_Luong As Double = Round(MyTable.Rows(0).Item("Khoi_Luong") / 1000 + 0.001, 1)
        'Dim Khoi_Luong As Double = 0.3
        '*** -----FLIGHT No
        Dim Flight_No As String = CStr(MyTable.Rows(0).Item("Flight_No"))
        'Dim Flight_No = "176/800"
        '*** -----AIRPORT OF TRANSHIPMENT
        Dim Airport_Transhipment As String = CStr(MyTable.Rows(0).Item("Airport_Transhipment"))
        'Dim Airport_Transhipment = "SIN"
        '*** -----OFFLOADING AIRPORT
        Dim Off_Airport As String = CStr(MyTable.Rows(0).Item("Off_Airport"))
        'Dim Off_Airport = "NNG"
        '*** -----To (TEN BUU CUC NHAN)
        Dim Ten_Bc_Nhan As String = CStr(MyTable.Rows(0).Item("Ten_Bc_Nhan"))
        'Dim Ten_Bc_Nhan = "NANNING EMS"
        '*** -----To (TEN NUOC NHAN)
        Dim Ten_Nuoc As String = CStr(MyTable.Rows(0).Item("Ten_Nuoc"))
        'Dim Ten_Nuoc = "CHINA"
        '*** -----Bat dau xu ly BarCode
        'Khai bao bien tam        
        Dim MyBarCode As String
        Dim Khoi_Luong_1 As Integer = Round(MyTable.Rows(0).Item("Khoi_Luong") / 100, 0)
        MyBarCode = MyTable.Rows(0).Item("Ma_Bc_Goc_Chu") & " " & MyTable.Rows(0).Item("Ma_Bc_Tra_Chu") & " " & MyTable.Rows(0).Item("Loai_Van_Chuyen") & " " & MyTable.Rows(0).Item("Loai_Chuyen_Thu") & " " & Mid(CStr(Year(MyTable.Rows(0).Item("Ngay_Dong"))), 4, 1) & " " & Right("0000" + CStr(MyTable.Rows(0).Item("So_Chuyen_Thu")), 4) & " " & Right("000" + CStr(MyTable.Rows(0).Item("Tui_So")), 3) & " " & MyTable.Rows(0).Item("Tui_F") & " " & Right("0000" & CStr(Khoi_Luong_1), 4)
        'Dim MyBarCode = "VNHANB TPEVNP A ED 8 0122 002 10 00005"

        'Duong dan file.ink TEMP
        strFileName = strDirPath & Id_E2 & ".ink"
        'Tao file 
        If Trim(Dir(strFileName)) = "" Then
            fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
        Else
            fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
        End If
        'Kiem tra neu so ban = 0 hoac null thi gan = 1
        If soban = 0 Or soban.ToString = "" Then
            soban = 1
        End If
        For iSoBan = 1 To soban
            'Bat dau ghi cac dong TEXT
            fileTXT.Write("^FX Stored Format AV8" & vbNewLine)
            fileTXT.Write("^FX -----------------" & vbNewLine)
            fileTXT.Write("^XA^DFCN35^FS" & vbNewLine)
            fileTXT.Write("^LH20,50" & vbNewLine)
            fileTXT.Write("^PR%S" & vbNewLine)
            fileTXT.Write("^FWR" & vbNewLine)

            fileTXT.Write("^FX Lines" & vbNewLine)
            fileTXT.Write("^FX -----" & vbNewLine)
            fileTXT.Write("^FX Verticales" & vbNewLine)
            fileTXT.Write("^FX ----------" & vbNewLine)
            fileTXT.Write("^FO00,10^GB455,0,2^FS^FX1" & vbNewLine)
            fileTXT.Write("^FO110,244^GB547,0,2^FS^FX2" & vbNewLine)
            fileTXT.Write("^FO 113,629^GB114,0,2^FS^FX3" & vbNewLine)

            fileTXT.Write("^FX Horizontales" & vbNewLine)
            fileTXT.Write("^FX ------------" & vbNewLine)
            fileTXT.Write("^FO113,10^GB0,917,2^FS^FX4" & vbNewLine)
            fileTXT.Write("^FO170,10^GB0,234,2^FS^FX5" & vbNewLine)
            fileTXT.Write("^FO227,10^GB0,854,2^FS^FX6" & vbNewLine)
            fileTXT.Write("^FO284,10^GB0,854,2^FS^FX7" & vbNewLine)
            fileTXT.Write("^FO341,10^GB0,234,2^FS^FX8" & vbNewLine)
            fileTXT.Write("^FO398,10^GB0,234,2^FS^FX9" & vbNewLine)
            fileTXT.Write("^FO455,10^GB0,234,2^FS^FX10" & vbNewLine)

            fileTXT.Write("^FX Square" & vbNewLine)
            fileTXT.Write("^FX ------" & vbNewLine)
            fileTXT.Write("^FO113,162^GB30,0,2^FS^FX11" & vbNewLine)
            fileTXT.Write("^FO113,192^GB30,0,2^FS^FX12" & vbNewLine)
            fileTXT.Write("^FO143,162^GB0,32,2^FS^FX13" & vbNewLine)

            fileTXT.Write("^FX Text/Constantes" & vbNewLine)
            fileTXT.Write("^FX ---------------" & vbNewLine)

            fileTXT.Write("^CFA,20,10^FS" & vbNewLine)
            fileTXT.Write("^FO93,20^FDKg^FS" & vbNewLine)
            fileTXT.Write("^FO118,20^FDEXEMPT^FS" & vbNewLine)
            fileTXT.Write("^FO207,20^FDNUMBER OF ITEMS^FS" & vbNewLine)
            fileTXT.Write("^FO264,20^FDREC No^FS" & vbNewLine)
            fileTXT.Write("^FO316,20^FDPRIORITY -^FS" & vbNewLine)
            fileTXT.Write("^FO294,20^FDBULK MAIL^FS" & vbNewLine)
            fileTXT.Write("^FO378,20^FDDATE OF DISPATCH^FS" & vbNewLine)
            fileTXT.Write("^FO435,20^FDMAIL No^FS" & vbNewLine)
            fileTXT.Write("^FO527,20^FDFROM^FS" & vbNewLine)

            fileTXT.Write("^FO207,254^FDAIRPORT OF TRANSHIPMENT^FS" & vbNewLine)
            fileTXT.Write("^FO207,645^FDOFFLOADING AIRPORT^FS" & vbNewLine)
            fileTXT.Write("^FO264,254^FDFLIGHT No^FS" & vbNewLine)
            fileTXT.Write("^FO435,254^FDTO^FS" & vbNewLine)

            fileTXT.Write("^CF0,35,25^FS" & vbNewLine)
            fileTXT.Write("^FO517,254^FDBY AIRMAIL^FS" & vbNewLine)
            fileTXT.Write("^FO517,843^FDCN 35^FS" & vbNewLine)

            fileTXT.Write("^CFA,20,10^FS" & vbNewLine)
            fileTXT.Write("^FO498,824^FD(old AV 8)^FS" & vbNewLine)

            fileTXT.Write("^FX Text/Variables" & vbNewLine)
            fileTXT.Write("^FX --------------" & vbNewLine)

            fileTXT.Write("^CF0,150,150^FS" & vbNewLine)
            fileTXT.Write("^FO300,843^FN1^FS" & vbNewLine)

            fileTXT.Write("^CF0,35,25^FS" & vbNewLine)
            fileTXT.Write("^FO491,10^FN2^FS" & vbNewLine)
            fileTXT.Write("^CF0,35,40^FS" & vbNewLine)
            fileTXT.Write("^FO314,354^FN16^FS" & vbNewLine)
            fileTXT.Write("^CF0,30,50^FS" & vbNewLine)
            fileTXT.Write("^FO112,164^FN3^FS" & vbNewLine)
            fileTXT.Write("^FO400,100^FN4^FS" & vbNewLine)
            fileTXT.Write("^FO343,45^FN5^FS" & vbNewLine)
            fileTXT.Write("^FO229,45^FN6^FS" & vbNewLine)
            fileTXT.Write("^FO172,100^FN7^FS" & vbNewLine)

            fileTXT.Write("^CF0,65,60^FS" & vbNewLine)
            fileTXT.Write("^FO20,80^FN8^FS" & vbNewLine)
            fileTXT.Write("^CF0,45,30^FS" & vbNewLine)
            fileTXT.Write("^FO229,366 ^FN9^FS" & vbNewLine)
            fileTXT.Write("^CF0,45,35^FS" & vbNewLine)
            fileTXT.Write("^FO145,254^FN10^FS" & vbNewLine)

            fileTXT.Write("^CF0,60,25^FS" & vbNewLine)
            fileTXT.Write("^FO364,254^FN14^FS" & vbNewLine)
            fileTXT.Write("^CF0,60,50^FS" & vbNewLine)
            fileTXT.Write("^FO334,254^FN15^FS" & vbNewLine)
            fileTXT.Write("^CF0,75,85^FS" & vbNewLine)
            fileTXT.Write("^FO120,670^FN11^FS" & vbNewLine)

            fileTXT.Write("^CF0,20,25^FS" & vbNewLine)
            fileTXT.Write("^FO00,350^FN12^FS" & vbNewLine)

            fileTXT.Write("^FO25,230^BCR,70,N,N,N,^FN13^FS" & vbNewLine)

            fileTXT.Write("^CFA,10,10^FS" & vbNewLine)
            fileTXT.Write("^FWN^FS" & vbNewLine)
            fileTXT.Write("^FO0,0^FDCPN/EMSQT'2008^FS" & vbNewLine)
            fileTXT.Write("^XZ" & vbNewLine)

            fileTXT.Write("^XA^XFCN35^FS" & vbNewLine)
            fileTXT.Write("^PQ1" & vbNewLine)

            '*** -----Tui_F
            fileTXT.Write("^FN1^FD" + F + "^FS" & vbNewLine)
            '*** -----FROM (TEN BC GUI)
            fileTXT.Write("^FN2^FD" + Ten_Bc_Gui + "^FS" & vbNewLine)
            '*** -----MAIL No
            fileTXT.Write("^FN4^FD" + So_Chuyen_Thu + "^FS" & vbNewLine)
            '*** -----DATE OF DISPATCH
            fileTXT.Write("^FN5^FD" + Right("00" & ngay_dong.Day, 2) + "/" + Right("00" & ngay_dong.Month, 2) & "/" & Right(ngay_dong.Year.ToString, 2) + "^FS" & vbNewLine)
            '*** -----REC No
            fileTXT.Write("^FN6^FD" + RecNo + "^FS" & vbNewLine)
            '*** -----NUMBER OF ITEMS
            fileTXT.Write("^FN7^FD" + Tong_So_BP + "^FS" & vbNewLine)
            '*** -----Kg
            fileTXT.Write("^FN8^FD" + Khoi_Luong.ToString("##0.0") + "^FS" & vbNewLine)
            '*** -----FLIGHT No
            fileTXT.Write("^FN9^FD" + Flight_No + "^FS" & vbNewLine)
            '*** -----AIRPORT OF TRANSHIPMENT
            fileTXT.Write("^FN10^FD" + Airport_Transhipment + "^FS" & vbNewLine)
            '*** -----OFFLOADING AIRPORT
            fileTXT.Write("^FN11^FD" + Off_Airport + "^FS" & vbNewLine)
            '*** -----BARCODE
            fileTXT.Write("^FN12^FD" + MyBarCode + "^FS" & vbNewLine)
            fileTXT.Write("^FN13^FD" + Replace(MyBarCode, " ", "") + "^FS" & vbNewLine)
            '*** -----To (TEN BUU CUC NHAN)
            fileTXT.Write("^FN14^FD" + Ten_Bc_Nhan + "^FS" & vbNewLine)
            '*** -----To (TEN NUOC NHAN)
            fileTXT.Write("^FN15^FD^FS" & vbNewLine)
            fileTXT.Write("^FN16^FD" + Ten_Nuoc + "^FS" & vbNewLine)
            fileTXT.Write("^XZ" & vbNewLine)
            fileTXT.Write(Chr(12))
        Next
        'Close FILE.INK
        fileTXT.Close()
        'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
        'Neu la kieu in Map qua may chu thi copy file vao o Map
        If GKieu_In_Map = True Then
            'Copy file.ink vao may chu
            FileCopy(strFileName, strDestination & Id_E2 & ".ink")
        Else
            'LocalPrintDOS(strFileName)
            NetPrintDOS(strFileName, strTenMayCN35, strTenMayInCN35)
        End If
    End Sub
#End Region

#Region "------------Nhan CN35 Trong Nuoc To Text - by TrungDQ - 08/05/2013------------"
    Public Sub WriteCN35_Trong_Nuoc_TEXT(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal soban As Integer, ByVal IsNDD_EMS As Boolean, ByVal strDirPath As String, ByVal strTenMayE4 As String, ByVal strTenMayInE4 As String)
        Dim strFileName As String    'File Ink (Full Path)        
        Dim MyTable As New DataTable   'Table luu thong tin CN35
        Dim MyDataSet As New E2_Di(GConnectionString)   'Lay Dataset CN35
        Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
        Dim fileTXT As StreamWriter    'TXT
        Dim iSoBan As Integer     'Duyet vong For So ban in
        Dim myKeys As New ModifyRegistry

        'Kiem tra neu chua khai bao may CN35 thi yeu cau khai bao va show Form ThietLapThamSo 
        If strTenMayE4 = "" Or strTenMayInE4 = "" Then
            MsgBox("Bạn chưa khai báo thông tin máy in nhãn E4!!!" & Chr(13) & "Chọn Ok để tiếp tục thực hiện khai báo", MsgBoxStyle.Information, "Thông báo")
            Dim frmHETHONG As New FrmThietLapThamSoHeThong
            frmHETHONG.ShowDialog()
            Exit Sub
        End If

        'Lay thong tin CN35 va truyen vao Table
        MyTable = MyDataSet.E2_Di_In_Nhan_E4(Id_E2).Tables(0)
        'Neu khong co ban ghi nao
        If MyTable.Rows.Count = 0 Then
            MsgBox("Không có thông tin cho E2 này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If

        '*** -----Tui_F
        Dim F As String = IIf(MyTable.Rows(0).Item("Tui_F") = "10", "F", "")
        'Dim F = "F"
        '*** -----FROM (TEN BC GUI)
        Dim Ten_Bc_Gui As String = CStr(MyTable.Rows(0).Item("Ma_Bc_Gui")) & " - " & CStr(MyTable.Rows(0).Item("Ten_Bc_Gui"))
        Ten_Bc_Gui = ConvetToABC(Ten_Bc_Gui)
        'Dim Ten_Bc_Gui = "HN EMS QT"
        '*** -----MAIL No
        Dim So_Chuyen_Thu As String = CStr(MyTable.Rows(0).Item("So_Chuyen_Thu"))
        'Dim So_Chuyen_Thu = "122"
        '*** -----DATE OF DISPATCH
        Dim ngay_dong As Date = CDate(MyTable.Rows(0).Item("Ngay_Dong"))
        'Dim ngay_dong = "12/09/2008"
        '*** -----REC No
        Dim RecNo As String = CStr(MyTable.Rows(0).Item("RecNo"))
        'Dim RecNo = "001/ED"
        '*** -----NUMBER OF ITEMS
        Dim Tong_So_BP As String = Right("000" & CStr(MyTable.Rows(0).Item("Tong_So_BP")), 3)
        'Dim Tui_So = "001"
        '*** -----Kg
        Dim Khoi_Luong As Double = Round(MyTable.Rows(0).Item("Khoi_Luong") / 1000 + 0.001, 1)
        'Dim Khoi_Luong As Double = 0.3
        '*** -----To (TEN BUU CUC NHAN)
        Dim Ten_Bc_Nhan As String = CStr(MyTable.Rows(0).Item("Ma_Bc_Nhan")) & " - " & CStr(MyTable.Rows(0).Item("Ten_Bc_Nhan"))
        Ten_Bc_Nhan = ConvetToABC(Ten_Bc_Nhan)
        '*** -----Bat dau xu ly BarCode
        'Khai bao bien tam        
        Dim MyBarCode, MyBarCode_With_Space As String
        Dim Khoi_Luong_1 As Integer = Round(MyTable.Rows(0).Item("Khoi_Luong") / 100, 0)

        Cap_Nhat_E2_Da_In_Nhan_E4_Ma_Vach(Id_E2, MyBarCode, MyBarCode_With_Space)

        'MyBarCode = CStr(MyTable.Rows(0).Item("Ma_Bc_Gui")) & " " & CStr(MyTable.Rows(0).Item("Ma_Bc_Nhan")) & " " & MyTable.Rows(0).Item("Loai_Chuyen_Thu") & " " & MyTable.Rows(0).Item("Loai_Dich_Vu") & " " & Mid(CStr(Year(MyTable.Rows(0).Item("Ngay_Dong"))), 4, 1) & " " & Right("0000" + CStr(MyTable.Rows(0).Item("So_Chuyen_Thu")), 4) & " " & Right("000" + CStr(MyTable.Rows(0).Item("Tui_So")), 3) & " " & MyTable.Rows(0).Item("Tui_F") & " " & Right("0000" & CStr(Khoi_Luong_1), 4)
        'Dim MyBarCode = "100916 440100 A EA 8 0122 002 10 00005"

        'Duong dan file.ink TEMP
        strFileName = strDirPath & Id_E2 & ".ink"
        'Tao file 
        If Trim(Dir(strFileName)) = "" Then
            fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
        Else
            fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
        End If
        'Kiem tra neu so ban = 0 hoac null thi gan = 1
        If soban = 0 Or soban.ToString = "" Then
            soban = 1
        End If
        For iSoBan = 1 To soban
            'Bat dau ghi cac dong TEXT
            fileTXT.Write("^FX Stored Format AV10" & vbNewLine)
            fileTXT.Write("^FX -----------------" & vbNewLine)
            fileTXT.Write("^XA^DFE4^FS" & vbNewLine)
            fileTXT.Write("^LH20,50" & vbNewLine)
            fileTXT.Write("^PR%S" & vbNewLine)
            fileTXT.Write("^FWR" & vbNewLine)

            fileTXT.Write("^FX Lines" & vbNewLine)
            fileTXT.Write("^FX -----" & vbNewLine)
            fileTXT.Write("^FX Verticales" & vbNewLine)
            fileTXT.Write("^FX ----------" & vbNewLine)
            fileTXT.Write("^FO00,10^GB455,0,2^FS^FX1" & vbNewLine)
            fileTXT.Write("^FO110,244^GB547,0,2^FS^FX2" & vbNewLine)
            fileTXT.Write("^FO 113,629^GB114,0,2^FS^FX3" & vbNewLine)

            fileTXT.Write("^FX Horizontales" & vbNewLine)
            fileTXT.Write("^FX ------------" & vbNewLine)
            fileTXT.Write("^FO113,10^GB0,917,2^FS^FX4" & vbNewLine)
            fileTXT.Write("^FO170,10^GB0,234,2^FS^FX5" & vbNewLine)
            fileTXT.Write("^FO227,10^GB0,854,2^FS^FX6" & vbNewLine)
            fileTXT.Write("^FO284,10^GB0,854,2^FS^FX7" & vbNewLine)
            fileTXT.Write("^FO341,10^GB0,234,2^FS^FX8" & vbNewLine)
            fileTXT.Write("^FO398,10^GB0,234,2^FS^FX9" & vbNewLine)
            fileTXT.Write("^FO455,10^GB0,234,2^FS^FX10" & vbNewLine)

            fileTXT.Write("^FX Square" & vbNewLine)
            fileTXT.Write("^FX ------" & vbNewLine)
            fileTXT.Write("^FO113,162^GB30,0,2^FS^FX11" & vbNewLine)
            fileTXT.Write("^FO113,192^GB30,0,2^FS^FX12" & vbNewLine)
            fileTXT.Write("^FO143,162^GB0,32,2^FS^FX13" & vbNewLine)

            fileTXT.Write("^FX Text/Constantes" & vbNewLine)
            fileTXT.Write("^FX ---------------" & vbNewLine)

            fileTXT.Write("^CFA,20,10^FS" & vbNewLine)
            fileTXT.Write("^FO93,20^FDTRONG LUONG (Kg)^FS" & vbNewLine)
            'fileTXT.Write("^FO118,20^FDEXEMPT^FS" & vbNewLine)
            fileTXT.Write("^FO207,20^FDTONG SO BP^FS" & vbNewLine)
            fileTXT.Write("^FO264,20^FDTUI SO^FS" & vbNewLine)
            'fileTXT.Write("^FO316,20^FDPRIORITY -^FS" & vbNewLine)
            'fileTXT.Write("^FO294,20^FDBULK MAIL^FS" & vbNewLine)
            fileTXT.Write("^FO378,20^FDNGAY DONG^FS" & vbNewLine)
            fileTXT.Write("^FO435,20^FDSO CHUYEN THU^FS" & vbNewLine)
            fileTXT.Write("^FO527,20^FDBUU CUC GUI^FS" & vbNewLine)

            'fileTXT.Write("^FO207,254^FDAIRPORT OF TRANSHIPMENT^FS" & vbNewLine)
            'fileTXT.Write("^FO207,645^FDOFFLOADING AIRPORT^FS" & vbNewLine)
            'fileTXT.Write("^FO264,254^FDFLIGHT No^FS" & vbNewLine)
            fileTXT.Write("^FO435,254^FDBUU CUC NHAN^FS" & vbNewLine)

            fileTXT.Write("^CF0,35,25^FS" & vbNewLine)
            'fileTXT.Write("^FO517,254^FDBY AIRMAIL^FS" & vbNewLine)
            fileTXT.Write("^FO517,843^FDE4^FS" & vbNewLine)

            fileTXT.Write("^CFA,20,10^FS" & vbNewLine)
            'fileTXT.Write("^FO498,824^FD(old AV 8)^FS" & vbNewLine)

            fileTXT.Write("^FX Text/Variables" & vbNewLine)
            fileTXT.Write("^FX --------------" & vbNewLine)

            fileTXT.Write("^CF0,150,150^FS" & vbNewLine)
            fileTXT.Write("^FO300,843^FN1^FS" & vbNewLine)

            fileTXT.Write("^CF0,35,25^FS" & vbNewLine)
            fileTXT.Write("^FO491,10^FN2^FS" & vbNewLine)
            fileTXT.Write("^CF0,35,40^FS" & vbNewLine)
            fileTXT.Write("^FO314,354^FN16^FS" & vbNewLine)
            fileTXT.Write("^CF0,30,50^FS" & vbNewLine)
            fileTXT.Write("^FO112,164^FN3^FS" & vbNewLine)
            fileTXT.Write("^FO400,100^FN4^FS" & vbNewLine)
            fileTXT.Write("^FO343,45^FN5^FS" & vbNewLine)
            fileTXT.Write("^FO229,45^FN6^FS" & vbNewLine)
            fileTXT.Write("^FO172,100^FN7^FS" & vbNewLine)

            fileTXT.Write("^CF0,65,60^FS" & vbNewLine)
            fileTXT.Write("^FO20,80^FN8^FS" & vbNewLine)
            fileTXT.Write("^CF0,45,30^FS" & vbNewLine)
            fileTXT.Write("^FO229,366 ^FN9^FS" & vbNewLine)
            fileTXT.Write("^CF0,45,35^FS" & vbNewLine)
            fileTXT.Write("^FO145,254^FN10^FS" & vbNewLine)

            fileTXT.Write("^CF0,55,45^FS" & vbNewLine)
            fileTXT.Write("^FO364,254^FN14^FS" & vbNewLine)
            fileTXT.Write("^CF0,60,50^FS" & vbNewLine)
            fileTXT.Write("^FO334,254^FN15^FS" & vbNewLine)
            fileTXT.Write("^CF0,75,85^FS" & vbNewLine)
            fileTXT.Write("^FO120,670^FN11^FS" & vbNewLine)

            fileTXT.Write("^CF0,20,25^FS" & vbNewLine)
            fileTXT.Write("^FO00,350^FN12^FS" & vbNewLine)

            fileTXT.Write("^FO25,230^BCR,70,N,N,N,^FN13^FS" & vbNewLine)

            fileTXT.Write("^CFA,10,10^FS" & vbNewLine)
            fileTXT.Write("^FWN^FS" & vbNewLine)
            'fileTXT.Write("^FO0,0^FDCPN/EMSQT'2008^FS" & vbNewLine)
            fileTXT.Write("^XZ" & vbNewLine)

            fileTXT.Write("^XA^XFE4^FS" & vbNewLine)
            fileTXT.Write("^PQ1" & vbNewLine)

            '*** -----Tui_F
            fileTXT.Write("^FN1^FD" + F + "^FS" & vbNewLine)
            '*** -----FROM (TEN BC GUI)
            fileTXT.Write("^FN2^FD" + Ten_Bc_Gui + "^FS" & vbNewLine)
            '*** -----MAIL No
            fileTXT.Write("^FN4^FD" + So_Chuyen_Thu + "^FS" & vbNewLine)
            '*** -----DATE OF DISPATCH
            fileTXT.Write("^FN5^FD" + Right("00" & ngay_dong.Day, 2) + "/" + Right("00" & ngay_dong.Month, 2) & "/" & Right(ngay_dong.Year.ToString, 2) + "^FS" & vbNewLine)
            '*** -----REC No
            fileTXT.Write("^FN6^FD" + RecNo + "^FS" & vbNewLine)
            '*** -----NUMBER OF ITEMS
            fileTXT.Write("^FN7^FD" + Tong_So_BP + "^FS" & vbNewLine)
            '*** -----Kg
            fileTXT.Write("^FN8^FD" + Khoi_Luong.ToString("##0.0") + "^FS" & vbNewLine)
            '*** -----FLIGHT No
            'fileTXT.Write("^FN9^FD" + Flight_No + "^FS" & vbNewLine)
            '*** -----AIRPORT OF TRANSHIPMENT
            'fileTXT.Write("^FN10^FD" + Airport_Transhipment + "^FS" & vbNewLine)
            '*** -----OFFLOADING AIRPORT
            'fileTXT.Write("^FN11^FD" + Off_Airport + "^FS" & vbNewLine)
            '*** -----BARCODE
            fileTXT.Write("^FN12^FD" + MyBarCode_With_Space + "^FS" & vbNewLine)
            fileTXT.Write("^FN13^FD" + MyBarCode + "^FS" & vbNewLine)
            '*** -----To (TEN BUU CUC NHAN)
            fileTXT.Write("^FN14^FD" + Ten_Bc_Nhan + "^FS" & vbNewLine)
            '*** -----To (TEN NUOC NHAN)
            fileTXT.Write("^FN15^FD^FS" & vbNewLine)
            'fileTXT.Write("^FN16^FD" + Ten_Nuoc + "^FS" & vbNewLine)
            fileTXT.Write("^XZ" & vbNewLine)
            fileTXT.Write(Chr(12))
        Next
        'Close FILE.INK
        fileTXT.Close()

        'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
        NetPrintDOS(strFileName, strTenMayE4, strTenMayInE4)

        'Cap nhat trang thai da in
        myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Trang_Thai_Da_In_Nhan_E4_Vao_Truyen_Doi_Soat(Id_E2)
    End Sub
#End Region

#Region "------------Nhan E4 To Text - by TrungDQ - 17/11/08------------"
    Public Sub WriteE4TEXT(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal soban As Integer)
        Dim strFileName As String    'File Ink (Full Path)
        Dim strDirPath As String = "C:\EMS_INTERNATIONAL\E4\"     'Thu muc Local: E4 file.ink
        Dim strDestination As String   'Thu muc tren server: E4 file.ink        
        Dim MyTable As New DataTable   'Table luu thong tin E4
        Dim MyDataSet As New E2_Di(GConnectionString)   'Lay Dataset E4
        Dim fileTXT As StreamWriter    'TXT
        Dim iSoBan As Integer     'Duyet vong For So ban in
        Dim myKeys As New ModifyRegistry
        Dim strTenMayE4 As String
        Dim strTenMayInE4 As String
        Dim Kieu_In_Map As Boolean
        Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)

        'Lay thong tin may in E4 trong regitry
        'GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
        strTenMayE4 = IIf(myKeys.Doc("GTen_May_Tinh_E4") Is Nothing Or myKeys.Doc("GTen_May_Tinh_E4") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_E4")))
        strTenMayInE4 = IIf(myKeys.Doc("GTen_May_In_E4") Is Nothing Or myKeys.Doc("GTen_May_In_E4") = "", "", CStr(myKeys.Doc("GTen_May_In_E4")))
        strDestination = IIf(myKeys.Doc("GThu_Muc_In_E4_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E4_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E4_QT_Den")))

        GKieu_In_Map = IIf(strDestination.Trim = "", False, True)

        If GKieu_In_Map = False Then
            'Kiem tra neu chua khai bao may CN35 thi yeu cau khai bao va show Form ThietLapThamSo 
            If strTenMayE4 = "" Or strTenMayInE4 = "" Then
                MsgBox("Bạn chưa khai báo thông tin máy in nhãn E4!!!", MsgBoxStyle.Information, "Thông báo")
                Dim frmHETHONG As New FrmThietLapThamSoHeThong
                If Not Preview Then
                    frmHETHONG.ShowDialog()
                    Exit Sub
                End If
            End If
            'Dim mId_Tui_Thu As String
            WriteCN35_Trong_Nuoc_TEXT(Id_E2, False, 1, False, strDirPath, strTenMayE4, strTenMayInE4)
            Exit Sub
        End If

        'Lay thong tin E4 va truyen vao Table
        MyTable = MyDataSet.E4(Id_E2).Tables(0)
        'Neu khong co ban ghi nao
        If MyTable.Rows.Count = 0 Then
            MsgBox("Không có thông tin cho E2 này", MsgBoxStyle.Information, "Thông báo")
            Exit Sub
        End If

        '*** -----Chuyen_Thu
        Dim Chuyen_Thu As String = CStr(MyTable.Rows(0).Item("Chuyen_Thu"))
        '*** -----Ma_Bc_Khai_Thac
        Dim Ma_Bc_Khai_Thac As String = ConvetToABC(CStr(MyTable.Rows(0).Item("Ma_Bc_Khai_Thac")))
        '*** -----Duongthu
        Dim Duongthu As String = ConvetToABC(CStr(MyTable.Rows(0).Item("Duongthu")))
        '*** -----Tui_So
        Dim Tui_So As String = CStr(MyTable.Rows(0).Item("Tui_So"))
        '*** -----Tong_So_BP
        Dim Tong_So_BP As String = CStr(MyTable.Rows(0).Item("Tong_So_BP"))
        '*** -----KhoiLuong
        Dim KhoiLuong As Double = MyTable.Rows(0).Item("KhoiLuong") / 1000
        '*** -----Tui_F
        Dim Tui_F As String = MyTable.Rows(0).Item("Tui_F")
        '*** -----Ngay_Dong
        Dim Ngay_Dong As String = Ham_Dung_Chung.ConvertIntToVNDateType(MyTable.Rows(0).Item("Ngay_Dong"))

        'Duong dan file.ink TEMP
        strFileName = strDirPath & Id_E2 & ".ink"
        'Tao file 
        If Trim(Dir(strFileName)) = "" Then
            fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
        Else
            fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
        End If
        'Kiem tra neu so ban = 0 hoac null thi gan = 1
        If soban = 0 Or soban.ToString = "" Then
            soban = 1
        End If
        For iSoBan = 1 To soban
            'Bat dau ghi cac dong TEXT
            fileTXT.Write(vbNewLine & "+--------------------------------------------+" & vbNewLine & _
                     "|Chuyen thu  |" & LSet(" BUU CUC GUI             ", 31) & "|" & vbNewLine & _
                     "|            |                               |" & vbNewLine & _
                     "|" & mB & LSet(Chuyen_Thu, 12) & mN & "|" & mB & mSH & LSet(Ma_Bc_Khai_Thac, 31) & mEH & mN & "|" & "|" & vbNewLine & _
                     "|------------|                               |" & vbNewLine & _
                     "|Ngay        |" & LSet(" TUI SO    : " & mB & mSH & RSet(Tui_So, 3) & mSW & Tui_F & mEW & "=" & RSet(Tong_So_BP, 3) & mEH & mN & " EMS", 46) & "|" & vbNewLine & _
                     "|" & mB & LSet(Ngay_Dong, 12) & mN & "|                               |" & vbNewLine & _
                     "|            |" & LSet(" BUU CUC NHAN            :", 31) & "|" & "|" & vbNewLine & _
                     "|------------|                               |" & vbNewLine & _
                     "|Khoi luong  |" & mB & mSH & mSW & LSet(Duongthu, 20) & mEW & mEH & mN & "|" & vbNewLine & _
                     "|            |                               |" & vbNewLine & _
                     "|" & mSW & padC(KhoiLuong.ToString("#,0.0##"), 10) & mEW & "|      " & mB & mSH & mSW & "  " & mEW & mEH & "          |" & vbNewLine & _
                     "+--------------------------------------------+" & vbNewLine & _
                     vbNewLine)
            'Het Trang
            'fileTXT.Write(Chr(12))
        Next
        'Close FILE.INK
        fileTXT.Close()

        CopyFileToServer(strFileName, strDestination)
        myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Trang_Thai_Da_In_Nhan_E4_Vao_Truyen_Doi_Soat(Id_E2)
        ''Lua chon kieu in (Truc tiep or ghi vao DoiIn)
        'If GKieu_In_Map = True Then
        '    CopyFileToServer(strFileName, strDestination)
        'Else
        '    'LocalPrintDOS(strFileName)
        '    'CopyFileToServer(strFileName, strDestination)
        '    'NetPrintDOS(strFileName, strTenMayE4, strTenMayInE4)
        '    WriteCN35_Trong_Nuoc_TEXT(Id_E2, False, 1, False, strDirPath, strTenMayE4, strTenMayInE4)
        'End If
        ''ViewNotePad(strFileName)

    End Sub

    Public Sub Cap_Nhat_E2_Da_In_Nhan_E4(ByVal mId_E2 As String)
        Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
        Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myHam_Dung_Chung As New Ham_Dung_Chung
        'Truyen vao bien
        mQLTGND_E2_Di_Chi_Tiet.Id_E2 = mId_E2
        mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan = ""
        mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2(mId_E2)
        'mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = mId_Tui_Thu
        mQLTGND_E2_Di_Chi_Tiet.STT = 0
        mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac = 0
        mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat = 0
        mQLTGND_E2_Di_Chi_Tiet.Chot_SL = 0
        mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
        mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong = myHam_Dung_Chung.ConvertTimeToInt(Now.Date())
        'Cap nhat vao bang QLTGND_E2_Di
        myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Them(mQLTGND_E2_Di_Chi_Tiet.Id_E2, mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan, mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu, mQLTGND_E2_Di_Chi_Tiet.STT, mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac, mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat, mQLTGND_E2_Di_Chi_Tiet.Chot_SL, mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong, mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong)
    End Sub

    'Public Sub Cap_Nhat_E2_Da_In_Nhan_E4_Ma_Vach(ByVal mId_E2 As String, ByVal mId_Tui_Thu As String)
    '    Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
    '    Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
    '    Dim myE2_Di As New E2_Di(GConnectionString)
    '    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    '    'Truyen vao bien
    '    mQLTGND_E2_Di_Chi_Tiet.Id_E2 = mId_E2
    '    mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan = ""
    '    'mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2(mId_E2)
    '    mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = mId_Tui_Thu
    '    mQLTGND_E2_Di_Chi_Tiet.STT = 0
    '    mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac = 0
    '    mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat = 0
    '    mQLTGND_E2_Di_Chi_Tiet.Chot_SL = 0
    '    mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
    '    mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong = myHam_Dung_Chung.ConvertTimeToInt(Now.Date())
    '    'Cap nhat vao bang QLTGND_E2_Di
    '    myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Them(mQLTGND_E2_Di_Chi_Tiet.Id_E2, mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan, mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu, mQLTGND_E2_Di_Chi_Tiet.STT, mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac, mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat, mQLTGND_E2_Di_Chi_Tiet.Chot_SL, mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong, mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong)
    'End Sub

#End Region

#Region "------------Print From MS DOS to Local Printer or Net Printer------------"
    'Local Printer
    Public Sub LocalPrintDOS(ByVal inFileName As String)
        Shell("CMD /C print " & inFileName, vbHide)
    End Sub

    'Net Printer
    Public Sub NetPrintDOS(ByVal inFileName As String, ByVal PrintSeverName As String, ByVal PrinterShareName As String)
        'Shell("CMD /C net use lpt2 \\" & PrintSeverName & "\" & PrinterShareName & " /persistent:yes")
        Shell("CMD /C print /d:\\" & PrintSeverName & "\" & PrinterShareName & " " & inFileName)
    End Sub

#End Region

#Region "------------Mở NotePad từ VB.NET------------"

    Public Sub ViewNotePad(ByVal inFileName As String)
        'Dim ps As New ProcessStartInfo
        'With ps
        '    .FileName = System.IO.Path.Combine(Application.StartupPath, inFileName)
        '    .UseShellExecute = True
        'End With

        'Dim p As New Process
        'p.StartInfo = ps
        'p.Start()
        Shell("NOTEPAD " & inFileName, vbMaximizedFocus)
    End Sub
#End Region
#End Region

#Region "====================Class: Bản kê BV10 To Text - by TrungDQ - 20/10/08===================="
    Public Class In_BV10_To_Text
        Private strBUU_CUC_KT As String
        Private strBUU_CUC As String
        Private strNGAY_LAP As String
        Private strGIO_LAP As String
        Private strTO_SO As String
        Private strDuong_Thu As String
        Private strFileName As String
        Private strTEN_DANG_NHAP As String   'Ten dang nhap he thong
        Private strTONG_SO_TUI As Integer    'Tong so tui
        Private strTONG_SO_EMS As Integer    'Tong so EMS
        Private strTONG_KG As Double         'Tong trong luong tui goi
        Private strHang_Van_Chuyen As String   'Hang Van Chuyen (AF, SQ, KA,...)
        Private Const strDirPath As String = "C:\EMS_INTERNATIONAL\BV10\"   'Thu muc temp chua BV10 file.ink
        Private strDestination As String  'Thu muc tren server
        Private Const nLeftMar As String = "   "   'Dieu chinh toa do trang in
        Private SoTrang As Integer = 1              'So thu tu trang in
        Private Const E2PerPage = 30                'So luong max E2 tren BV10
        Private Dong_hien_tai As Integer = 0
        Private MyE2_Di_BV10 As New E2_Di(GConnectionString)
        Private MyTable1 As New DataTable   'Luu thong tin tong hop
        Private MyTable2 As New DataTable   'Luu thong tin chi tiet
        Private MyDataSet1 As New DataSet
        Private MyDataSet2 As New DataSet

        Private myKeys As New ModifyRegistry
        Private strTenMayBV10 As String
        Private strTenMayInBV10 As String
        Private Kieu_In_Map As Boolean

#Region "-------------In_BV10_To_Text First-------------"
#Region "In ra file TEXT"
        Public Sub WriteBV10TEXT(ByVal Ngay_Bay As Integer, ByVal Ngay_Dong As Integer, ByVal So_Hieu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Preview As Boolean, ByVal soban As Integer)
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer

            'Lay thong tin may in BV10 trong regitry
            'GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            'strTenMayBV10 = IIf(myKeys.Doc("GTen_May_Tinh_BV10") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BV10") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BV10")))
            'strTenMayInBV10 = IIf(myKeys.Doc("GTen_May_In_BV10") Is Nothing Or myKeys.Doc("GTen_May_In_BV10") = "", "", CStr(myKeys.Doc("GTen_May_In_BV10")))
            'strDestination = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BV10_QT_Den")))

            'In bản kê BV10 quốc tế đi
            GKieu_In_Map = Not CBool(IIf(myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") Is Nothing Or myKeys.Doc("GIn_Tren_Server_BV10_QT_Di") = "", False, myKeys.Doc("GIn_Tren_Server_BV10_QT_Di")))
            strTenMayBV10 = IIf(myKeys.Doc("GTen_May_Tinh_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GTen_May_Tinh_In_BV10_QT_Di") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_In_BV10_QT_Di")))
            strTenMayInBV10 = IIf(myKeys.Doc("GTen_May_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GTen_May_In_BV10_QT_Di") = "", "", CStr(myKeys.Doc("GTen_May_In_BV10_QT_Di")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Di") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BV10_QT_Di")))

            If GKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in BV10!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may BV10 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayBV10 = "" Or strTenMayInBV10 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in BV10!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            Dim mSo_Hieu As String = Lay_So_Hieu_Chuyen_Bay_In_BV10(So_Hieu)
            Dim mLength As Integer = mSo_Hieu.Length
            'Truyen dataset vao de xu ly
            If GIn_Ban_Ke_BV10_Theo_Ngay_Dong = True Then
                'MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong(Ngay_Bay, Ngay_Dong, Mid(So_Hieu, 1, 5))
                MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong_QT(Ngay_Bay, Ngay_Dong, mSo_Hieu, mLength)
                MyDataSet2 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Header_Ngay_Dong(Id_Chuyen_Thu, So_Hieu, Id_Duong_Thu, Ngay_Dong)
            Else
                'MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10(Ngay_Bay, Mid(So_Hieu, 1, 5))
                MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_QT(Ngay_Bay, mSo_Hieu, mLength)
                MyDataSet2 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Header(Id_Chuyen_Thu, So_Hieu, Id_Duong_Thu)
            End If
            'Lay thong tin vao cac bang de xu ly
            MyTable1 = MyDataSet1.Tables(0)
            MyTable2 = MyDataSet2.Tables(0)
            'Truyen gia tri cho cac bien dung chung
            If MyTable2.Rows.Count <> 0 Then
                'Buu cuc khai thac
                strBUU_CUC_KT = MyTable2.Rows(0).Item("ten_bc_khai_thac")
                'Buu cuc nhan
                strBUU_CUC = "Kho hàng sân bay"
                'Ngay lap
                strNGAY_LAP = Ham_Dung_Chung.ConvertIntToVNDateType(MyTable2.Rows(0).Item("ngay_bay"))
                'Gio 
                strGIO_LAP = ""
                'Duong Thu
                strDuong_Thu = strBUU_CUC_KT & " - " & strBUU_CUC
                'Hang Van Chuyen
                'strHang_Van_Chuyen = Mid(So_Hieu, 1, 5)
                strHang_Van_Chuyen = mSo_Hieu
            End If
            'Duong dan file.ink TEMP
            'strFileName = strDirPath & Id_Chuyen_Thu & Replace(Mid(So_Hieu, 1, 5), "/", "") & ".ink"
            strFileName = strDirPath & Id_Chuyen_Thu & Replace(mSo_Hieu, "/", "") & ".ink"
            'Tao file 
            If Trim(Dir(strFileName)) = "" Then
                fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If soban = 0 Or soban.ToString = "" Then
                soban = 1
            End If
            For iSoBan = 1 To soban
                'Bat dau ghi cac dong TEXT
                'Phan Header
                WriteHeader_Second(fileTXT, SoTrang)
                'Phan Detail - tra ve so dong da in
                Dong_hien_tai = WriteDETAIL_Second(fileTXT)
                'Them so dong trong = so dong max - dong hien tai
                InsertRow(fileTXT, E2PerPage - Dong_hien_tai)
                'Phan Footer
                If GKieu_In_Map = True Then
                    WriteFooter_Second(fileTXT, True, True)
                Else
                    If iSoBan < soban Then   'chua phai trang cuoi cung
                        WriteFooter_Second(fileTXT, True, True)
                    Else    'La trang cuoi cung
                        WriteFooter_Second(fileTXT, True, False)
                    End If
                End If
            Next
            'Close FILE.INK
            fileTXT.Close()
            'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
            If Not Preview Then       'Ghi vao temp & In truc tiep ra may in
                'Neu la kieu in Map qua may chu thi copy file vao o Map
                If GKieu_In_Map = True Then
                    'Copy file.ink vao may chu
                    CopyFileToServer(strFileName, strDestination)
                Else
                    'LocalPrintDOS(strFileName)
                    NetPrintDOS(strFileName, strTenMayBV10, strTenMayInBV10)
                End If
            Else        'Only Preview & ghi vao DoiIn tren Server
                ViewNotePad(strFileName)
            End If
        End Sub
#End Region

#Region "Các hàm ghi ra file TEXT"
        Private Sub WriteHeader(ByVal inStreamFile As StreamWriter, ByVal inSoTrang As Integer)
            With inStreamFile
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(nLeftMar & Space(28) & mB & ConvetToABC(strBUU_CUC_KT) & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strBUU_CUC) & vbNewLine & _
                           nLeftMar & Space(28) & strNGAY_LAP & Space(4) & "Gio :   " & strGIO_LAP & vbNewLine & _
                           nLeftMar & Space(28) & inSoTrang.ToString & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strHang_Van_Chuyen))
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(mN)
            End With
        End Sub

        Private Sub WriteFooter(ByVal inStreamFile As StreamWriter, ByVal isKetThuc As Boolean, ByVal NextPage As Boolean)
            inStreamFile.WriteLine()
            inStreamFile.WriteLine()
            If isKetThuc Then    ' Neu la to ket thuc
                'In phan tong cong
                inStreamFile.WriteLine(nLeftMar & RSet(strTONG_SO_TUI, 33) & _
                                                  RSet(strTONG_SO_EMS, 6) & _
                                                  RSet(strTONG_KG.ToString("##0.0"), 22))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            Else
                inStreamFile.WriteLine()
                'In dong thong bao xem tiep trang sau
                inStreamFile.WriteLine(padC("Xem tiep trang sau", 70))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            End If
            'Footer
            If NextPage = False Then    'la to ket thuc
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                           padC(strNGAY_LAP, 39) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 39) & mN)
                End With
            Else   'La to tiep theo
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                           padC(strNGAY_LAP, 42) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 39) & mN & mNP)
                End With
            End If
        End Sub

        Private Function WriteDETAIL(ByVal inStreamFile As StreamWriter) As Integer
            Dim ct_SCT As Integer     'So chuyen thu
            Dim ct_BCG As String    'Buu cuc gui
            Dim ct_BCN As String   'Buu cuc nhan
            Dim ct_TUISO As Integer       'Tui so
            Dim ct_SOLUONG As String     'So luong E1
            Dim ct_TUIRONG As Integer     'So luong Tui rong
            Dim ct_TRONGLUONG As Double   'Trong luong tui goi
            Dim ct_TUIF As String         'Tui F


            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            strTONG_SO_TUI = 0
            strTONG_SO_EMS = 0
            strTONG_KG = 0
            If MyTable1.Rows.Count <> 0 Then
                For i = 0 To MyTable1.Rows.Count - 1
                    With MyTable1.Rows(i)
                        'Kiem tra (het trang - sang trang moi)
                        If i = E2PerPage Then
                            iSTT = 0
                            NewPage(inStreamFile)
                        End If
                        iSTT += 1
                        ct_SCT = .Item("sochuyenthu")
                        ct_BCG = ConvetToABC(.Item("TenBCgui"))
                        ct_BCN = ConvetToABC(.Item("TenBCnhan"))
                        ct_TUISO = .Item("Tui_So")
                        'ct_SOLUONG = .Item("Tong_So_BP")
                        ct_SOLUONG = "X"
                        ct_TUIRONG = 0
                        'ct_TRONGLUONG = Round(.Item("KhoiLuong") / 1000, 1)
                        ct_TRONGLUONG = Round_Int(.Item("KhoiLuong"), -2) / 1000

                        ct_TUIF = .Item("Tui_F")
                        'Tinh toan phan tong hop
                        strTONG_SO_TUI += 1
                        strTONG_SO_EMS += 1
                        strTONG_KG += ct_TRONGLUONG
                        'Ghi ra file TXT phan chi tiet
                        inStreamFile.WriteLine(nLeftMar & LSet(CStr(ct_SCT), 4) & _
                                                          LSet(ct_BCG, 12) & _
                                                          Space(2) & _
                                                          LSet(ct_BCN, 11) & _
                                                          RSet(ct_TUISO, 4) & _
                                                          RSet(ct_SOLUONG, 6) & _
                                                          RSet(ct_TUIRONG, 12) & _
                                                          RSet(ct_TRONGLUONG.ToString("##0.0"), 10) & _
                                                          RSet(ct_TUIF, 5))


                    End With
                Next i
            End If
            Return iSTT
        End Function

        Private Sub NewPage(ByVal inStreamFile As StreamWriter)
            SoTrang += 1
            'Phan footer cua trang hien tai
            WriteFooter(inStreamFile, False, True)
            'Phan header cua trang tiep theo
            WriteHeader(inStreamFile, SoTrang)
        End Sub
#End Region
#End Region

#Region "-------------In_BV10_To_Text Second-------------"
#Region "In ra file TEXT Second"
        Public Sub WriteBV10TEXT_Second(ByVal Ngay_Bay As Integer, ByVal Ngay_Dong As Integer, ByVal So_Hieu As String, ByVal Id_Chuyen_Thu As String, ByVal Id_Duong_Thu As String, ByVal Preview As Boolean, ByVal soban As Integer)
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer

            'Lay thong tin may in BV10 trong regitry
            GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            strTenMayBV10 = IIf(myKeys.Doc("GTen_May_Tinh_BV10") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BV10") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BV10")))
            strTenMayInBV10 = IIf(myKeys.Doc("GTen_May_In_BV10") Is Nothing Or myKeys.Doc("GTen_May_In_BV10") = "", "", CStr(myKeys.Doc("GTen_May_In_BV10")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_BV10_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BV10_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BV10_QT_Den")))

            If GKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in BV10!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may BV10 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayBV10 = "" Or strTenMayInBV10 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in BV10!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            Dim mSo_Hieu As String = Lay_So_Hieu_Chuyen_Bay_In_BV10(So_Hieu)
            Dim mLength As Integer = mSo_Hieu.Length
            'Truyen dataset vao de xu ly
            If GIn_Ban_Ke_BV10_Theo_Ngay_Dong = True Then
                'MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong(Ngay_Bay, Ngay_Dong, Mid(So_Hieu, 1, 5))
                MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Ngay_Bay_Ngay_Dong(Ngay_Bay, Ngay_Dong, mSo_Hieu, mLength)
                MyDataSet2 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Header_Ngay_Dong(Id_Chuyen_Thu, So_Hieu, Id_Duong_Thu, Ngay_Dong)
            Else
                'MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10(Ngay_Bay, Mid(So_Hieu, 1, 5))
                MyDataSet1 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10(Ngay_Bay, mSo_Hieu, mLength)
                MyDataSet2 = MyE2_Di_BV10.E2_Di_Ban_Ke_BV10_Header(Id_Chuyen_Thu, So_Hieu, Id_Duong_Thu)
            End If
            'Lay thong tin vao cac bang de xu ly
            MyTable1 = MyDataSet1.Tables(0)
            MyTable2 = MyDataSet2.Tables(0)
            'Truyen gia tri cho cac bien dung chung
            If MyTable2.Rows.Count <> 0 Then
                'Buu cuc khai thac
                strBUU_CUC_KT = MyTable2.Rows(0).Item("ten_bc_khai_thac")
                'Buu cuc nhan
                strBUU_CUC = "Kho hàng sân bay"
                'Ngay lap
                strNGAY_LAP = Ham_Dung_Chung.ConvertIntToVNDateType(MyTable2.Rows(0).Item("ngay_bay"))
                'Gio 
                strGIO_LAP = ""
                'Duong Thu
                strDuong_Thu = strBUU_CUC_KT & " - " & strBUU_CUC
                'Hang Van Chuyen
                'strHang_Van_Chuyen = Mid(So_Hieu, 1, 5)
                strHang_Van_Chuyen = mSo_Hieu
            End If
            'Duong dan file.ink TEMP
            'strFileName = strDirPath & Id_Chuyen_Thu & Replace(Mid(So_Hieu, 1, 5), "/", "") & ".ink"
            strFileName = strDirPath & Id_Chuyen_Thu & Replace(mSo_Hieu, "/", "") & ".ink"
            'Tao file 
            If Trim(Dir(strFileName)) = "" Then
                fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If soban = 0 Or soban.ToString = "" Then
                soban = 1
            End If
            For iSoBan = 1 To soban
                'Bat dau ghi cac dong TEXT
                'Phan Header
                WriteHeader_Second(fileTXT, SoTrang)
                'Phan Detail - tra ve so dong da in
                Dong_hien_tai = WriteDETAIL_Second(fileTXT)
                'Them so dong trong = so dong max - dong hien tai
                InsertRow(fileTXT, E2PerPage - Dong_hien_tai)
                'Phan Footer
                If GKieu_In_Map = True Then
                    WriteFooter_Second(fileTXT, True, True)
                Else
                    If iSoBan < soban Then   'chua phai trang cuoi cung
                        WriteFooter_Second(fileTXT, True, True)
                    Else    'La trang cuoi cung
                        WriteFooter_Second(fileTXT, True, False)
                    End If
                End If
            Next
            'Close FILE.INK
            fileTXT.Close()
            'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
            If Not Preview Then       'Ghi vao temp & In truc tiep ra may in
                'Neu la kieu in Map qua may chu thi copy file vao o Map
                If GKieu_In_Map = True Then
                    'Copy file.ink vao may chu
                    CopyFileToServer(strFileName, strDestination)
                Else
                    'LocalPrintDOS(strFileName)
                    NetPrintDOS(strFileName, strTenMayBV10, strTenMayInBV10)
                End If
            Else        'Only Preview & ghi vao DoiIn tren Server
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Các hàm ghi ra file TEXT Second"
        Private Sub WriteHeader_Second(ByVal inStreamFile As StreamWriter, ByVal inSoTrang As Integer)
            With inStreamFile
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(nLeftMar & Space(28) & mB & ConvetToABC(strBUU_CUC_KT) & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strBUU_CUC) & vbNewLine & _
                           nLeftMar & Space(28) & strNGAY_LAP & Space(4) & "Gio :   " & strGIO_LAP & vbNewLine & _
                           nLeftMar & Space(28) & inSoTrang.ToString & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strHang_Van_Chuyen))
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(mN)
            End With
        End Sub

        Private Sub WriteFooter_Second(ByVal inStreamFile As StreamWriter, ByVal isKetThuc As Boolean, ByVal NextPage As Boolean)
            inStreamFile.WriteLine()
            inStreamFile.WriteLine()
            If isKetThuc Then    ' Neu la to ket thuc
                'In phan tong cong
                inStreamFile.WriteLine(nLeftMar & RSet(strTONG_SO_TUI, 33) & _
                                                  RSet(strTONG_SO_EMS, 6) & _
                                                  RSet(strTONG_KG.ToString("##0.0"), 22))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            Else
                inStreamFile.WriteLine()
                'In dong thong bao xem tiep trang sau
                inStreamFile.WriteLine(padC("Xem tiep trang sau", 70))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            End If
            'Footer
            If NextPage = False Then    'la to ket thuc
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                           padC(strNGAY_LAP, 39) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 39) & mN)
                End With
            Else   'La to tiep theo
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                           padC(strNGAY_LAP, 42) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 39) & mN & mNP)
                End With
            End If
        End Sub

        Private Function WriteDETAIL_Second(ByVal inStreamFile As StreamWriter) As Integer
            Dim ct_SCT As Integer     'So chuyen thu
            Dim ct_BCG As String    'Buu cuc gui
            Dim ct_BCN As String   'Buu cuc nhan
            Dim ct_TUISO As Integer       'Tui so
            Dim ct_SOLUONG As String     'So luong E1
            Dim ct_TUIRONG As Integer     'So luong Tui rong
            Dim ct_TRONGLUONG As Double   'Trong luong tui goi
            Dim ct_TUIF As String         'Tui F


            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            strTONG_SO_TUI = 0
            strTONG_SO_EMS = 0
            strTONG_KG = 0
            If MyTable1.Rows.Count <> 0 Then
                For i = 0 To MyTable1.Rows.Count - 1
                    With MyTable1.Rows(i)
                        'Kiem tra (het trang - sang trang moi)
                        If i = E2PerPage Then
                            iSTT = 0
                            NewPage_Second(inStreamFile)
                        End If
                        iSTT += 1
                        ct_SCT = .Item("sochuyenthu")
                        ct_BCG = ConvetToABC(.Item("TenBCgui"))
                        ct_BCN = ConvetToABC(.Item("TenBCnhan"))
                        ct_TUISO = .Item("Tui_So")
                        'ct_SOLUONG = .Item("Tong_So_BP")
                        ct_SOLUONG = "X"
                        ct_TUIRONG = 0
                        'ct_TRONGLUONG = Round(.Item("KhoiLuong") / 1000, 1)
                        ct_TRONGLUONG = Round_Int(.Item("KhoiLuong"), -2) / 1000

                        ct_TUIF = .Item("Tui_F")
                        'Tinh toan phan tong hop
                        strTONG_SO_TUI += 1
                        strTONG_SO_EMS += 1
                        strTONG_KG += ct_TRONGLUONG
                        'Ghi ra file TXT phan chi tiet
                        inStreamFile.WriteLine(nLeftMar & LSet(CStr(ct_SCT), 4) & _
                                                          LSet(ct_BCG, 12) & _
                                                          Space(2) & _
                                                          LSet(ct_BCN, 11) & _
                                                          RSet(ct_TUISO, 4) & _
                                                          RSet(ct_SOLUONG, 6) & _
                                                          RSet(ct_TUIRONG, 12) & _
                                                          RSet(ct_TRONGLUONG.ToString("##0.0"), 10) & _
                                                          RSet(ct_TUIF, 5))


                    End With
                Next i
            End If
            Return iSTT
        End Function

        Private Sub NewPage_Second(ByVal inStreamFile As StreamWriter)
            SoTrang += 1
            'Phan footer cua trang hien tai
            WriteFooter_Second(inStreamFile, False, True)
            'Phan header cua trang tiep theo
            WriteHeader_Second(inStreamFile, SoTrang)
        End Sub
#End Region
#End Region
        Public Sub New()

        End Sub
    End Class
#End Region

#Region "====================Class: Bản Kê CN38 To TEXT - By TrungDQ - 16/01/09 - Ho Chi Minh===================="
    Public Class In_CN38_TEXT
        Private strFileName As String
        Private h_Ten_Bc_Nhan As String        'luu thong tin Buu cuc dich
        Private h_So_Chuyen_Bay As String   'so chuyen bay
        Private h_Priorit As String         'So luong di duong bo
        Private h_Avion As String           'So luong di duong bay
        Private h_Off_AirPort As String     'Noi Nhan
        Private h_Dir_AirPort As String     'Qua Giang
        Private h_Ngay_Dong As String       'Ngay_Dong
        Private h_Ngay_Bay As String        'Ngay_Bay

        Private f_Tong_So_Tui As Integer          'Tong So Tui 
        Private f_Tong_Khoi_Luong As Double       'Tong Khoi Luong
        Private f_Tong_So_E As Integer            'Tong So E

        Private f_Ten_Bc_Gui As String
        Private f_Ngay_Gui As String
        Private f_Ma_Bc_Gui As String

        '---------------------------------------------------------
        Private myCN38_Chi_Tiet As New DataTable    'Chi tiet E2         
        '---------------------------------------------------------
        Private Const strDirPath As String = "C:\EMS_INTERNATIONAL\CN38\"   'Thu muc temp chua CN38 file.ink
        Private strDestination As String  'Thu muc tren server
        Private Const nLeftMar As String = "       "   'Dieu chinh toa do trang in
        Private SoTrang As Integer = 1              'So thu tu trang in
        Private Dong_hien_tai As Integer = 0
        Private Const E1PerPage As Integer = 11     'So dong toi da tren CN38

        Private myKeys As New ModifyRegistry
        Private strTenMayCN38 As String
        Private strTenMayInCN38 As String
        Private gKieu_In_Map As Boolean


#Region "Chuẩn bị dữ liệu In_E2"
        Public Sub Ban_Ke_CN38_To_Text(ByVal Id_Chuyen_Thu As String, ByVal bolPreview As Boolean, ByVal soban As Integer)
            'Khai bao bien 
            Dim myCN38 As New Ban_Ke_CN38(GConnectionString)
            Dim myDataSet As New DataSet
            Dim myCN38_Header As New DataTable

            'Lay thong tin trong SQL
            myDataSet = myCN38.Get_Data_CN38(Id_Chuyen_Thu)
            'CN38 Chi Tiet
            myCN38_Chi_Tiet = myDataSet.Tables(0)
            'CN38 Header
            myCN38_Header = myDataSet.Tables(1)

            'Gan thong tin cho cac bien
            '1. Header
            '----Ngay Dong
            Dim Ngay_Dong_Tmp As Date = myCN38_Header.Rows(0).Item("Ngay_Dong")
            h_Ngay_Dong = Ngay_Dong_Tmp.ToString("dd/MM/yyyy")
            '----Ten_Bc_Nhan
            h_Ten_Bc_Nhan = myCN38_Header.Rows(0).Item("Ten_Bc")
            '----So Chuyen Bay
            h_So_Chuyen_Bay = myCN38_Header.Rows(0).Item("Chuyen_Bay")
            '----Ngay Bay
            Dim Ngay_Bay_Tmp As Date = myCN38_Header.Rows(0).Item("DateOfDeparture")
            h_Ngay_Bay = Ngay_Bay_Tmp.ToString("dd/MM/yyyy")
            '----San bay qua giang
            h_Dir_AirPort = myCN38_Header.Rows(0).Item("AirportOfDirect")
            '----San bay nhan
            h_Off_AirPort = myCN38_Header.Rows(0).Item("AirportOfLoading")

            '2. Footer
            '----Ten Buu Cuc Gui (Bc_Khai_Thac)
            f_Ten_Bc_Gui = myCN38_Header.Rows(0).Item("ten_bc_khai_thac")
            '----Ma Buu Cuc Gui (Ma_Bc_Khai_Thac)
            f_Ma_Bc_Gui = myCN38_Header.Rows(0).Item("ma_bc_khai_thac")
            '----Ngay Gui
            f_Ngay_Gui = h_Ngay_Dong

            'Lay thong tin may in E2 trong regitry
            GKieu_In_Map_CN38 = IIf(myKeys.Doc("GKieu_In_Map_CN38") Is Nothing Or myKeys.Doc("GKieu_In_Map_CN38") = "", False, myKeys.Doc("GKieu_In_Map_CN38"))
            strTenMayCN38 = IIf(myKeys.Doc("GTen_May_Tinh_CN38") Is Nothing Or myKeys.Doc("GTen_May_Tinh_CN38") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_CN38")))
            strTenMayInCN38 = IIf(myKeys.Doc("GTen_May_In_CN38") Is Nothing Or myKeys.Doc("GTen_May_In_CN38") = "", "", CStr(myKeys.Doc("GTen_May_In_CN38")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_CN38_QT_Di") Is Nothing Or myKeys.Doc("GThu_Muc_In_CN38_QT_Di") = "", "", CStr(myKeys.Doc("GThu_Muc_In_CN38_QT_Di")))

            If GKieu_In_Map_CN38 = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in CN38!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may CN38 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayCN38 = "" Or strTenMayInCN38 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in CN38!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            '---------------------------------------            
            '            strFileName = ShowSaveDlg(Id_E2)
            strFileName = strDirPath & Id_Chuyen_Thu & ".ink"

            If WriteTXT(strFileName, soban) And Not bolPreview Then
                'print file to local printer
                'LocalPrintDOS(strFileName)
                If GKieu_In_Map_CN38 = True Then
                    CopyFileToServer(strFileName, strDestination)
                Else
                    NetPrintDOS(strFileName, strTenMayCN38, strTenMayInCN38)
                End If
            Else
                'Copy file.ink vao may chu
                'Rem di de dung cach in qua may in mang tren DOS
                'FileCopy(strFileName, strDestination & Id_E2 & ".ink")
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Các sub và function Write TEXT"
        Private Function WriteTXT(ByVal sFileName As String, ByVal inSoBan As Integer) As Boolean
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer
            If Trim(Dir(sFileName)) = "" Then
                fileTXT = New StreamWriter(sFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(sFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If inSoBan = 0 Or inSoBan.ToString = "" Then
                inSoBan = 1
            End If
            For iSoBan = 1 To inSoBan
                Dong_hien_tai = 0
                'Phan header
                WriteHEADER(fileTXT, SoTrang)
                'Phan chi tiet - Tra ve so dong hien tai da in
                Dong_hien_tai = WriteCHITIET(fileTXT)
                'Tinh toan so dong da in + so dong tong ket de sang trang moi
                If (Dong_hien_tai > E1PerPage) Then
                    NewPage(fileTXT, False)
                    Dong_hien_tai = 0
                End If
                'Tinh toan so dong can them vao cho day trang
                Do While Dong_hien_tai < E1PerPage
                    InsertRow(fileTXT, 2)
                    Dong_hien_tai += 1
                Loop
                'Phan Footer
                If gKieu_In_Map = True Then
                    WriteFOOTER(fileTXT, True, False)
                Else
                    If iSoBan < inSoBan Then  'neu chua ket thuc file thi in ky tu sang trang
                        WriteFOOTER(fileTXT, True, False)
                    Else    'neu ket thuc file thi khong in ky tu sang trang
                        WriteFOOTER(fileTXT, True, True)
                    End If
                End If
            Next iSoBan
            fileTXT.Close()
            Return True
        End Function

        Private Sub WriteHEADER(ByVal sFileTXT As StreamWriter, ByVal iSOTRANG As Integer)
            sFileTXT.WriteLine(mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & Space(44) & h_Ngay_Dong & Space(10) & iSOTRANG & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & Space(4) & LSet(h_Ten_Bc_Nhan, 36) & "X" & Space(18) & "X" & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & Space(10) & LSet(h_So_Chuyen_Bay, 38) & h_Ngay_Bay & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & Space(22) & LSet(h_Dir_AirPort, 36) & h_Off_AirPort & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
        End Sub

        Private Sub WriteFOOTER(ByVal sFileTXT As StreamWriter, ByVal LastPage As Boolean, ByVal EndOfFile As Boolean)
            'sFileTXT.WriteLine()
            If LastPage = True Then
                sFileTXT.WriteLine(nLeftMar & mB & Space(43) & RSet(f_Tong_So_Tui, 5) & Space(4) & LSet(f_Tong_Khoi_Luong.ToString("##0.0"), 8) & RSet(f_Tong_So_E, 3) & mN)
            Else
                sFileTXT.WriteLine(nLeftMar & mN & "                           " & Trim("Xem tiep trang sau") & mN)
            End If
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            'sFileTXT.WriteLine()
            sFileTXT.WriteLine(mB)
            If EndOfFile = True Then
                sFileTXT.Write(nLeftMar & padC(f_Ten_Bc_Gui, 20) & vbNewLine & vbNewLine & _
                                   nLeftMar & padC(f_Ngay_Gui, 20) & vbNewLine & vbNewLine & _
                                   nLeftMar & padC(f_Ma_Bc_Gui, 20) & mN)
            Else
                sFileTXT.Write(nLeftMar & padC(f_Ten_Bc_Gui, 20) & vbNewLine & vbNewLine & _
                                                   nLeftMar & padC(f_Ngay_Gui, 20) & vbNewLine & vbNewLine & _
                                                   nLeftMar & padC(f_Ma_Bc_Gui, 20) & mN & mNP)
            End If
        End Sub

        Private Function WriteCHITIET(ByVal sFileTXT As StreamWriter) As Integer
            Dim c_So_Chuyen_Thu As String
            Dim c_Loai_Chuyen_Thu As String
            Dim c_Ma_BC_KT_Chu As String
            Dim c_Ma_BC_Chu As String
            Dim c_Tui_So As Integer
            Dim c_Khoi_Luong_BP As Double
            Dim c_Tong_So_BP As Integer
            Dim c_Tui_F As String


            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2

            f_Tong_So_Tui = 0
            f_Tong_Khoi_Luong = 0
            f_Tong_So_E = 0

            For i = 0 To myCN38_Chi_Tiet.Rows.Count - 1
                With myCN38_Chi_Tiet.Rows(i)
                    'Kiem tra (het trang - sang trang moi)
                    If iSTT = E1PerPage Then
                        iSTT = 0
                        NewPage(sFileTXT, True)
                    End If
                    iSTT += 1
                    c_So_Chuyen_Thu = Mid(.Item("soCT_TS"), 1, 5)
                    c_Loai_Chuyen_Thu = .Item("Loai_Chuyen_Thu")
                    c_Ma_BC_KT_Chu = .Item("Ma_BC_Khai_Thac_Chu")
                    c_Ma_BC_Chu = .Item("Ma_BC_Chu")
                    c_Tui_So = .Item("Tui_So")
                    c_Khoi_Luong_BP = Round(.Item("Khoi_Luong_BP") / 1000, 1)
                    c_Tong_So_BP = .Item("Tong_So_BP")
                    c_Tui_F = IIf(.Item("Tui_F") = True, "F", "")

                    'Cong don cho phan header
                    f_Tong_So_Tui += 1
                    f_Tong_Khoi_Luong += c_Khoi_Luong_BP
                    f_Tong_So_E += c_Tong_So_BP

                    'Ghi ra file TXT phan chi tiet
                    sFileTXT.WriteLine(nLeftMar & Space(2) & c_So_Chuyen_Thu & "/" & c_Loai_Chuyen_Thu & Space(3) & c_Ma_BC_KT_Chu & Space(10) & c_Ma_BC_Chu & Space(8) & RSet(c_Tui_So, 5) & Space(4) & LSet(c_Khoi_Luong_BP.ToString("##0.0"), 8) & RSet(c_Tong_So_BP, 3) & Space(7) & c_Tui_F)
                    sFileTXT.WriteLine()
                End With
            Next i
            Return iSTT
        End Function

        Private Sub NewPage(ByVal sFileTXT As StreamWriter, ByVal isFullPage As Boolean)
            'Tang so Trang in
            SoTrang += 1
            If isFullPage = False Then
                'Tinh toan so dong can them vao de sang trang
                Do While Dong_hien_tai < E1PerPage
                    InsertRow(sFileTXT, 1)
                    Dong_hien_tai += 1
                Loop
            End If
            'Phan footer cua trang hien tai
            WriteFOOTER(sFileTXT, False, False)
            'Phan header cua trang tiep theo
            WriteHEADER(sFileTXT, SoTrang)
        End Sub
#End Region

    End Class
#End Region

#Region "====================Class: Bản kê BC 37 To Text - by TrungDQ - 20/10/08===================="
    Public Class In_BC37_To_Text
        Private strBUU_CUC_KT As String
        Private strBUU_CUC As String
        Private strNGAY_LAP As String
        Private strGIO_LAP As String
        Private strTO_SO As String
        Private strFileName As String
        Private strTEN_DANG_NHAP As String   'Ten dang nhap he thong
        Private strTONG_SO_TUI As Integer    'Tong so tui
        Private strTONG_SO_EMS As Integer    'Tong so EMS
        Private strTONG_KG As Double         'Tong trong luong tui goi
        Private Const strDirPath As String = "C:\EMS_INTERNATIONAL\BC37\"   'Thu muc temp chua BC37 file.ink
        Private strDestination As String  'Thu muc tren server
        Private Const nLeftMar As String = "   "   'Dieu chinh toa do trang in
        Private SoTrang As Integer = 1              'So thu tu trang in
        Private Const E2PerPage = 30                'So luong max E2 tren BC37
        Private Dong_hien_tai As Integer = 0
        Private MyTable1 As New DataTable   'Luu thong tin tong hop
        Private MyTable2 As New DataTable   'Luu thong tin chi tiet
        Private MyDataSet As New DataSet

        Private myKeys As New ModifyRegistry
        Private strTenMayBC37 As String
        Private strTenMayInBC37 As String
        Private Kieu_In_Map As Boolean

#Region "------------In bản kê BC37 To Text First------------"
#Region "In ra file TEXT"
        Public Sub WriteBC37TEXT(ByVal id_chuyen_thu As String, ByVal Preview As Boolean, ByVal soban As Integer)
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer

            'Lay thong tin may in BC37 trong regitry
            GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            strTenMayBC37 = IIf(myKeys.Doc("GTen_May_Tinh_BC37") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BC37") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BC37")))
            strTenMayInBC37 = IIf(myKeys.Doc("GTen_May_In_BC37") Is Nothing Or myKeys.Doc("GTen_May_In_BC37") = "", "", CStr(myKeys.Doc("GTen_May_In_BC37")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_BC37_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BC37_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BC37_QT_Den")))

            If GKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in BC37!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may BC37 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayBC37 = "" Or strTenMayInBC37 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in BC37!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            'Truyen dataset vao de xu ly
            MyDataSet = GetDATA_BC37(id_chuyen_thu)
            'Lay thong tin vao cac bang de xu ly
            MyTable1 = MyDataSet.Tables(0)
            MyTable2 = MyDataSet.Tables(1)
            'Truyen gia tri cho cac bien dung chung
            If MyTable2.Rows.Count <> 0 Then
                'Buu cuc khai thac
                strBUU_CUC_KT = CStr(MyTable2.Rows(0).Item("ma_bc_khai_thac")) & " - " & MyTable2.Rows(0).Item("ten_bc_khai_thac")
                'Buu cuc nhan
                strBUU_CUC = CStr(MyTable2.Rows(0).Item("ma_bc")) & " - " & MyTable2.Rows(0).Item("ten_bc_nhan")
                'Ngay lap
                strNGAY_LAP = Ham_Dung_Chung.ConvertIntToVNDateType(MyTable2.Rows(0).Item("ngay_dong"))
                'Gio 
                strGIO_LAP = Ham_Dung_Chung.ConvertIntToTime(MyTable2.Rows(0).Item("gio_dong"))
            End If
            'Duong dan file.ink TEMP
            strFileName = strDirPath & id_chuyen_thu & ".ink"
            'Tao file 
            If Trim(Dir(strFileName)) = "" Then
                fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If soban = 0 Or soban.ToString = "" Then
                soban = 1
            End If
            For iSoBan = 1 To soban
                'Bat dau ghi cac dong TEXT
                'Phan Header
                WriteHeader(fileTXT, SoTrang)
                'Phan Detail - tra ve so dong da in
                Dong_hien_tai = WriteDETAIL(fileTXT)
                'Them so dong trong = so dong max - dong hien tai
                InsertRow(fileTXT, E2PerPage - Dong_hien_tai)
                'Phan Footer
                If iSoBan < soban Then   'chua phai trang cuoi cung
                    WriteFooter(fileTXT, True, False)
                Else    'La trang cuoi cung
                    WriteFooter(fileTXT, True, True)
                End If
            Next
            'Close FILE.INK
            fileTXT.Close()
            'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
            If Not Preview Then       'Ghi vao temp & In truc tiep ra may in
                'Neu la kieu in Map qua may chu thi copy file vao o Map
                If GKieu_In_Map = True Then
                    'Copy file.ink vao may chu
                    CopyFileToServer(strFileName, strDestination)
                Else
                    'LocalPrintDOS(strFileName)
                    NetPrintDOS(strFileName, strTenMayBC37, strTenMayInBC37)
                End If
            Else        'Only Preview & ghi vao DoiIn tren Server
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Chuẩn bị dữ liệu cho BC37"
        Private Function GetDATA_BC37(ByVal id_chuyen_thu As String) As DataSet
            Try
                'Tao connection và command
                Dim myConnection As SqlConnection = New SqlConnection(GConnectionString)
                Dim myCommand1 As SqlCommand = New SqlCommand("E2_Di_BC37", myConnection)
                Dim myCommand2 As SqlCommand = New SqlCommand("Chuyen_Thu_Di_QT_BC37", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Su dung Store Procedure
                myCommand1.CommandType = CommandType.StoredProcedure
                myCommand2.CommandType = CommandType.StoredProcedure
                ' Parameters
                Dim pId_Chuyen_Thu As SqlParameter
                ' Open connection
                myConnection.Open()
                ' Process - chi tiet
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = id_chuyen_thu
                myCommand1.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand1
                myAdapter.Fill(myDataSet, "E2_Di_BC37")
                ' Process - header
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = id_chuyen_thu
                myCommand2.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand2
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Di_QT_BC37")
                ' Close connection
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Các hàm ghi ra file TEXT"
        Private Sub WriteHeader(ByVal inStreamFile As StreamWriter, ByVal inSoTrang As Integer)
            With inStreamFile
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                ' .WriteLine()
                .WriteLine(nLeftMar & Space(28) & mB & ConvetToABC(strBUU_CUC_KT) & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strBUU_CUC) & vbNewLine & _
                           nLeftMar & Space(28) & strNGAY_LAP & Space(4) & "Gio :   " & strGIO_LAP & vbNewLine & _
                           nLeftMar & Space(28) & inSoTrang.ToString & vbNewLine & _
                           nLeftMar & Space(28) & ConvetToABC(strBUU_CUC))
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(mN)
            End With
        End Sub

        Private Sub WriteFooter(ByVal inStreamFile As StreamWriter, ByVal lastPage As Boolean, ByVal EndOfFile As Boolean)
            inStreamFile.WriteLine()
            inStreamFile.WriteLine()
            If lastPage Then   ' Neu la to ket thuc
                'In phan tong cong
                inStreamFile.WriteLine(nLeftMar & RSet(strTONG_SO_TUI, 33) & _
                                                  RSet(" ", 6) & _
                                                  RSet(strTONG_KG.ToString("##0.##0"), 22))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            Else
                inStreamFile.WriteLine()
                'In dong thong bao xem tiep trang sau
                inStreamFile.WriteLine(padC("Xem tiep trang sau", 70))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            End If
            'Footer
            If EndOfFile Then
                If GKieu_In_Map Then
                    With inStreamFile
                        .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                               padC(strNGAY_LAP, 42) & vbNewLine & _
                               vbNewLine & _
                               vbNewLine & _
                               mB & padC(ConvetToABC(GHo_Ten), 39) & mN & mNP)
                    End With
                Else
                    With inStreamFile
                        .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                               padC(strNGAY_LAP, 39) & vbNewLine & _
                               vbNewLine & _
                               vbNewLine & _
                               mB & padC(ConvetToABC(GHo_Ten), 39) & mN)
                    End With
                End If
            Else
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 39) & vbNewLine & _
                           padC(strNGAY_LAP, 42) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 39) & mN & mNP)
                End With
            End If
        End Sub

        Private Function WriteDETAIL(ByVal inStreamFile As StreamWriter) As Integer
            Dim ct_SCT As Integer     'So chuyen thu
            Dim ct_BCG As String    'Buu cuc gui
            Dim ct_BCN As String   'Buu cuc nhan
            Dim ct_TUISO As Integer       'Tui so
            Dim ct_SOLUONG As Integer     'So luong E1
            Dim ct_TUIRONG As Integer     'So luong Tui rong
            Dim ct_TRONGLUONG As Double   'Trong luong tui goi
            Dim ct_TUIF As String         'Tui F


            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            strTONG_SO_TUI = 0
            strTONG_SO_EMS = 0
            strTONG_KG = 0
            If MyTable1.Rows.Count <> 0 Then
                For i = 0 To MyTable1.Rows.Count - 1
                    With MyTable1.Rows(i)
                        'Kiem tra (het trang - sang trang moi)
                        If i = E2PerPage Then
                            iSTT = 0
                            NewPage(inStreamFile)
                        End If
                        iSTT += 1
                        ct_SCT = .Item("sochuyenthu")
                        ct_BCG = ConvetToABC(.Item("TenBCgui"))
                        ct_BCN = ConvetToABC(.Item("TenBCnhan"))
                        ct_TUISO = .Item("Tui_So")
                        ct_SOLUONG = .Item("Tong_So_BP")
                        ct_TUIRONG = 0
                        ct_TRONGLUONG = .Item("KhoiLuong")
                        ct_TUIF = .Item("Tui_F")
                        'Tinh toan phan tong hop
                        strTONG_SO_TUI += 1
                        strTONG_SO_EMS += ct_SOLUONG
                        strTONG_KG += ct_TRONGLUONG
                        'Ghi ra file TXT phan chi tiet
                        inStreamFile.WriteLine(nLeftMar & LSet(CStr(ct_SCT), 4) & _
                                                          LSet(ct_BCG, 12) & _
                                                          Space(2) & _
                                                          LSet(ct_BCN, 11) & _
                                                          RSet(ct_TUISO, 4) & _
                                                          RSet(" ", 6) & _
                                                          RSet(ct_TUIRONG, 12) & _
                                                          RSet(ct_TRONGLUONG.ToString("##0.##0"), 10) & _
                                                          RSet(ct_TUIF, 5))


                    End With
                Next i
            End If
            Return iSTT
        End Function

        Private Sub NewPage(ByVal inStreamFile As StreamWriter)
            SoTrang += 1
            'Phan footer cua trang hien tai
            WriteFooter(inStreamFile, False, False)
            'Phan header cua trang tiep theo
            WriteHeader(inStreamFile, SoTrang)
        End Sub
#End Region
#End Region

#Region "------------In bản kê BC37 To Text Second------------"
#Region "In ra file TEXT Second"
        Public Sub WriteBC37TEXT_Second(ByVal id_chuyen_thu As String, ByVal Preview As Boolean, ByVal soban As Integer)
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer

            'Lay thong tin may in BC37 trong regitry
            GKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            strTenMayBC37 = IIf(myKeys.Doc("GTen_May_Tinh_BC37") Is Nothing Or myKeys.Doc("GTen_May_Tinh_BC37") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_BC37")))
            strTenMayInBC37 = IIf(myKeys.Doc("GTen_May_In_BC37") Is Nothing Or myKeys.Doc("GTen_May_In_BC37") = "", "", CStr(myKeys.Doc("GTen_May_In_BC37")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_BC37_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_BC37_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_BC37_QT_Den")))

            If GKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in BC37!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may BC37 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayBC37 = "" Or strTenMayInBC37 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in BC37!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not Preview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            'Truyen dataset vao de xu ly
            MyDataSet = GetDATA_BC37_Second(id_chuyen_thu)
            'Lay thong tin vao cac bang de xu ly
            MyTable1 = MyDataSet.Tables(0)
            MyTable2 = MyDataSet.Tables(1)
            'Truyen gia tri cho cac bien dung chung
            If MyTable2.Rows.Count <> 0 Then
                'Buu cuc khai thac
                strBUU_CUC_KT = CStr(MyTable2.Rows(0).Item("ma_bc_khai_thac")) & " - " & MyTable2.Rows(0).Item("ten_bc_khai_thac")
                'Buu cuc nhan
                strBUU_CUC = CStr(MyTable2.Rows(0).Item("ma_bc")) & " - " & MyTable2.Rows(0).Item("ten_bc_nhan")
                'Ngay lap
                strNGAY_LAP = Ham_Dung_Chung.ConvertIntToVNDateType(MyTable2.Rows(0).Item("ngay_dong"))
                'Gio 
                strGIO_LAP = Ham_Dung_Chung.ConvertIntToTime(MyTable2.Rows(0).Item("gio_dong"))
            End If
            'Duong dan file.ink TEMP
            strFileName = strDirPath & id_chuyen_thu & ".ink"
            'Tao file 
            If Trim(Dir(strFileName)) = "" Then
                fileTXT = New StreamWriter(strFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(strFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If soban = 0 Or soban.ToString = "" Then
                soban = 1
            End If
            For iSoBan = 1 To soban
                'Bat dau ghi cac dong TEXT
                'Phan Header
                WriteHeader_Second(fileTXT, SoTrang)
                'Phan Detail - tra ve so dong da in
                Dong_hien_tai = WriteDETAIL_Second(fileTXT)
                'Them so dong trong = so dong max - dong hien tai
                InsertRow(fileTXT, GSo_Dong_Trong_Trang_In_Ban_Ke_BC37 - Dong_hien_tai)
                'Phan Footer
                If iSoBan < soban Then   'chua phai trang cuoi cung
                    WriteFooter_Second(fileTXT, True, False)
                Else    'La trang cuoi cung
                    WriteFooter_Second(fileTXT, True, True)
                End If
            Next
            'Close FILE.INK
            fileTXT.Close()
            'Lua chon kieu in (Truc tiep or ghi vao DoiIn)
            If Not Preview Then       'Ghi vao temp & In truc tiep ra may in
                'Neu la kieu in Map qua may chu thi copy file vao o Map
                If GKieu_In_Map = True Then
                    'Copy file.ink vao may chu
                    CopyFileToServer(strFileName, strDestination)
                Else
                    'LocalPrintDOS(strFileName)
                    NetPrintDOS(strFileName, strTenMayBC37, strTenMayInBC37)
                End If
            Else        'Only Preview & ghi vao DoiIn tren Server
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Chuẩn bị dữ liệu cho BC37 Second"
        Private Function GetDATA_BC37_Second(ByVal id_chuyen_thu As String) As DataSet
            Try
                'Tao connection và command
                Dim myConnection As SqlConnection = New SqlConnection(GConnectionString)
                Dim myCommand1 As SqlCommand = New SqlCommand("E2_Di_BC37", myConnection)
                Dim myCommand2 As SqlCommand = New SqlCommand("Chuyen_Thu_Di_QT_BC37", myConnection)
                Dim myAdapter As SqlDataAdapter = New SqlDataAdapter
                Dim myDataSet As DataSet = New DataSet
                ' Su dung Store Procedure
                myCommand1.CommandType = CommandType.StoredProcedure
                myCommand2.CommandType = CommandType.StoredProcedure
                ' Parameters
                Dim pId_Chuyen_Thu As SqlParameter
                ' Open connection
                myConnection.Open()
                ' Process - chi tiet
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = id_chuyen_thu
                myCommand1.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand1
                myAdapter.Fill(myDataSet, "E2_Di_BC37")
                ' Process - header
                pId_Chuyen_Thu = New SqlParameter("@Id_Chuyen_Thu", SqlDbType.VarChar, 28)
                pId_Chuyen_Thu.Value = id_chuyen_thu
                myCommand2.Parameters.Add(pId_Chuyen_Thu)
                myAdapter.SelectCommand = myCommand2
                myAdapter.Fill(myDataSet, "Chuyen_Thu_Di_QT_BC37")
                ' Close connection
                myConnection.Close()
                myConnection.Dispose()
                Return myDataSet
            Catch ex As Exception
                Console.Write(ex.ToString)
            End Try
        End Function
#End Region

#Region "Các hàm ghi ra file TEXT Second"
        Private Sub WriteHeader_Second(ByVal inStreamFile As StreamWriter, ByVal inSoTrang As Integer)
            With inStreamFile
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(nLeftMar & Space(10) & mB & ConvetToABC(strBUU_CUC_KT) & vbNewLine & _
                           nLeftMar & Space(10) & ConvetToABC(strBUU_CUC) & vbNewLine & vbNewLine & _
                           nLeftMar & Space(8) & strNGAY_LAP & Space(4) & "Gio :   " & strGIO_LAP & vbNewLine & _
                           nLeftMar & Space(8) & inSoTrang.ToString) '& vbNewLine '& _
                'nLeftMar & Space(28) & ConvetToABC(strBUU_CUC))
                .WriteLine()
                .WriteLine()
                .WriteLine()
                .WriteLine(mN)
            End With
        End Sub

        Private Sub WriteFooter_Second(ByVal inStreamFile As StreamWriter, ByVal lastPage As Boolean, ByVal EndOfFile As Boolean)
            inStreamFile.WriteLine()
            inStreamFile.WriteLine()
            If lastPage Then    ' Neu la to ket thuc
                'In phan tong cong
                inStreamFile.WriteLine(nLeftMar & RSet(strTONG_SO_TUI, 10) & _
                                                  RSet(strTONG_KG.ToString("##0.##0"), 12))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            Else
                inStreamFile.WriteLine()
                'In dong thong bao xem tiep trang sau
                inStreamFile.WriteLine(padC("Xem tiep trang sau", 15))
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
                inStreamFile.WriteLine()
            End If
            'Footer
            If EndOfFile Then    'la to ket thuc
                If GKieu_In_Map Then
                    With inStreamFile
                        .Write(padC(ConvetToABC(strBUU_CUC_KT), 22) & vbNewLine & _
                               padC(strNGAY_LAP, 24) & vbNewLine & _
                               vbNewLine & _
                               vbNewLine & _
                               mB & padC(ConvetToABC(GHo_Ten), 22) & mN & mNP)
                    End With
                Else
                    With inStreamFile
                        .Write(padC(ConvetToABC(strBUU_CUC_KT), 22) & vbNewLine & _
                               padC(strNGAY_LAP, 24) & vbNewLine & _
                               vbNewLine & _
                               vbNewLine & _
                               mB & padC(ConvetToABC(GHo_Ten), 22) & mN)
                    End With
                End If

            Else   'La to tiep theo
                With inStreamFile
                    .Write(padC(ConvetToABC(strBUU_CUC_KT), 22) & vbNewLine & _
                           padC(strNGAY_LAP, 24) & vbNewLine & _
                           vbNewLine & _
                           vbNewLine & _
                           mB & padC(ConvetToABC(GHo_Ten), 22) & mN & mNP)
                End With
            End If
        End Sub

        Private Function WriteDETAIL_Second(ByVal inStreamFile As StreamWriter) As Integer
            Dim ct_SCT As Integer     'So chuyen thu
            Dim ct_BCG As String    'Buu cuc gui
            Dim ct_BCN As String   'Buu cuc nhan
            Dim ct_TUISO As Integer       'Tui so
            Dim ct_SOLUONG As Integer     'So luong E1
            Dim ct_TUIRONG As Integer     'So luong Tui rong
            Dim ct_TRONGLUONG As Double   'Trong luong tui goi
            Dim ct_TUIF As String         'Tui F


            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            strTONG_SO_TUI = 0
            strTONG_SO_EMS = 0
            strTONG_KG = 0
            If MyTable1.Rows.Count <> 0 Then
                For i = 0 To MyTable1.Rows.Count - 1
                    With MyTable1.Rows(i)
                        'Kiem tra (het trang - sang trang moi)
                        If i = GSo_Dong_Trong_Trang_In_Ban_Ke_BC37 Then
                            iSTT = 0
                            NewPage_Second(inStreamFile)
                        End If
                        iSTT += 1
                        ct_SCT = .Item("sochuyenthu")
                        ct_BCG = ConvetToABC(.Item("TenBCgui"))
                        ct_BCN = ConvetToABC(.Item("TenBCnhan"))
                        ct_TUISO = .Item("Tui_So")
                        ct_SOLUONG = .Item("Tong_So_BP")
                        ct_TUIRONG = 0
                        ct_TRONGLUONG = .Item("KhoiLuong")
                        ct_TUIF = .Item("Tui_F")
                        'Tinh toan phan tong hop
                        strTONG_SO_TUI += 1
                        strTONG_SO_EMS += ct_SOLUONG
                        strTONG_KG += ct_TRONGLUONG
                        'Ghi ra file TXT phan chi tiet
                        'inStreamFile.WriteLine(nLeftMar & LSet(CStr(ct_SCT), 4) & _
                        '                                  LSet(ct_BCG, 12) & _
                        '                                  Space(2) & _
                        '                                  LSet(ct_BCN, 11) & _
                        '                                  RSet(ct_TUISO, 4) & _
                        '                                  RSet(" ", 6) & _
                        '                                  RSet(ct_TUIRONG, 12) & _
                        '                                  RSet(ct_TRONGLUONG.ToString("##0.##0"), 10) & _
                        '                                  RSet(ct_TUIF, 5))
                        inStreamFile.WriteLine(nLeftMar & LSet(CStr(ct_SCT), 7) & _
                                                          RSet(ct_TUISO, 4) & _
                                                          RSet(ct_TRONGLUONG.ToString("##0.##0"), 10) & _
                                                          RSet(ct_TUIF, 4) & _
                                                          LSet("    " & ct_TUIRONG, 12))
                    End With
                Next i
            End If
            Return iSTT
        End Function

        Private Sub NewPage_Second(ByVal inStreamFile As StreamWriter)
            SoTrang += 1
            'Phan footer cua trang hien tai
            WriteFooter_Second(inStreamFile, False, False)
            'Phan header cua trang tiep theo
            WriteHeader_Second(inStreamFile, SoTrang)
        End Sub
#End Region
#End Region

        Public Sub New()

        End Sub
    End Class
#End Region

#Region "====================CLass: Bản Kê E2 Đi To TEXT = By TrungDQ = 5/10/08=========================="
    Public Class In_E2_TEXT
        Private strFileName As String
        Private strFrom As String      'luu thong tin Buu cuc goc
        Private strTO As String        'luu thong tin Buu cuc dich
        Private strChuyenThu As String 'chuyen thu
        Private strNGAY As String      'Ngay gui
        Private strGIO As String       'Gio gui
        Private strTuiSo As String     'So tui

        Private TotalKg As Double      'Tong khoi luong 
        Private strTongBPchu As String      'Tong khoi luong bang chu
        Private strTEN_DANG_NHAP As String   'Ten dang nhap he thong
        '---------------------------------------------------------
        Private myDataE1_CT As New DataTable    'Luu danh sach E1 chi tiet
        Private myTKCT_E2_Di As New DataTable   'Tong ket chuyen thu

        Private strTONGKET As String
        'Xu ly doi voi Tui F
        Private isTUIF As Boolean
        Private strCHANTRANG As String
        Private strTKCT As String
        '---------------------------------------------------------
        Private Const strDirPath As String = "C:\EMS_INTERNATIONAL\E2\"   'Thu muc temp chua E2 file.ink
        Private strDestination As String  'Thu muc tren server
        Private Const nLeftMar As String = " "   'Dieu chinh toa do trang in
        Private SoTrang As Integer = 1              'So thu tu trang in
        Private Dong_hien_tai As Integer = 0
        Private So_dong_tong_ket As Integer = 0
        'Private So_dong_tong_ket_TuiF As Integer = 0
        Private Const E1PerPage As Integer = 40     'So dong E1 toi da tren E2
        'Private E1PerPage As Integer = GSo_Dong_Trong_Trang_In_Ban_Ke_E2 'So dong E1 toi da tren E2

        Private myKeys As New ModifyRegistry
        Private strTenMayE2 As String
        Private strTenMayInE2 As String
        Private gKieu_In_Map As Boolean

#Region "-------------------------Bản Kê E2 Đi First--------------------------"
#Region "Chuẩn bị dữ liệu In_E2"
        Public Sub Ban_Ke_E2_Di_To_Text(ByVal Id_E2 As String, ByVal bolPreview As Boolean, ByVal soban As Integer)
            Dim myE2_Di As New E2_Di(GConnectionString)
            Dim myE1_Di As New E1_Di(GConnectionString)
            Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
            'Dim pvCollection As New ParameterValues
            'Dim _pThamSo As New ParameterDiscreteValue
            Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim myHamdungchung As New Ham_Dung_Chung
            Dim myData As DataSet
            Dim myDataTK As DataSet
            Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
            Dim myNumber As New ConvertNumberToString
            Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
            Dim Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim Ma_Bc_Khai_Thac As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc_Khai_Thac
            Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
            'Tong ket chuyen thu
            Dim myTKCT As New E2_Di(GConnectionString)
            '-----------
            Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).Tong_So_BP
            Dim Tui_So As Integer = myE2_Di.Lay(Id_E2).Tui_So
            Dim Ma_Bc As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
            Dim Ngay_Thang As Integer = myE2_Di.Lay(Id_E2).Ngay_Dong
            Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ho_Ten
            Dim Tren5kgQT, Duoi5kgQT, KLTren5kgQT, KLDuoi5kgQT, HHPTTren5kgQT, HHPTDuoi5kgQT As Double
            Dim i, j, k, T, BP, Tong_HH As Integer
            Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)
            Dim F As Boolean = myE2_Di.Lay(Id_E2).Tui_F
            '    Dim HH_Phat_Hanh As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Hanh
            '   Dim HH_Phat_Tra As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Tra
            Dim Tong_So_BP As Integer = myE2_Di.Lay(Id_E2).Tong_So_BP
            Dim Nuoc_Nhan As String
            Dim Ma_Bc_Goc As Integer
            Dim Ma_Mc_Tra As Integer
            myNumber.Number = Tong_So_BP
            Dim myData1 As New DataTable
            Dim myData2 As New DataTable

            'Lay thong tin may in E2 trong regitry
            gKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            strTenMayE2 = IIf(myKeys.Doc("GTen_May_Tinh_E2") Is Nothing Or myKeys.Doc("GTen_May_Tinh_E2") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_E2")))
            strTenMayInE2 = IIf(myKeys.Doc("GTen_May_In_E2") Is Nothing Or myKeys.Doc("GTen_May_In_E2") = "", "", CStr(myKeys.Doc("GTen_May_In_E2")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_E2_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E2_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E2_QT_Den")))

            If gKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in E2!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may E2 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayE2 = "" Or strTenMayInE2 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in E2!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            myData1 = myE1_Di.Danh_Sach_E1(Id_E2).Tables(0)
            myData2 = myE2_Di.Danh_Sach_Tong_Ket_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)

            TotalKg = 0
            Tren5kgQT = 0
            Duoi5kgQT = 0
            KLTren5kgQT = 0
            KLDuoi5kgQT = 0
            HHPTTren5kgQT = 0
            HHPTDuoi5kgQT = 0
            T = 0
            BP = 0
            Tong_HH = 0

            'Duyet myData1 lay thong tin
            For i = 0 To myData1.Rows.Count - 1
                If myData1.Rows(i).Item("Khoi_Luong") > 5000 Then
                    Tren5kgQT += 1
                    KLTren5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi5kgQT += 1
                    KLDuoi5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
                'Tinh Tong Hoa Hong Phat Tra
                Tong_HH += HHPTDuoi5kgQT + HHPTTren5kgQT
                'Tinh tong khoi luong                
                TotalKg += myData1.Rows(i).Item("Khoi_Luong")
            Next

            strFrom = Ma_Bc_Khai_Thac.ToString + " - " + myDanh_Muc_BC.Lay(Ma_Bc_Khai_Thac).Ten_Buu_Cuc

            strChuyenThu = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu

            strTuiSo = Tui_So

            strTO = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc

            Dim Str As String = ""
            Select Case Phan_Loai
                Case 0
                    Str = "Bưu tá "
                Case 1
                    Str = "Giao dịch "
                Case 2
                    Str = "Khai thác "
                Case 3
                    Str = "Khai thác "
                Case 4
                    Str = "Khai thác "
            End Select

            strGIO = Gio

            strNGAY = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)

            strTEN_DANG_NHAP = Ten_Dang_Nhap

            strTongBPchu = myNumber.StringNumber + "bưu gửi"

            'Dim StrHHPH As String = nLeftMar & Ma_Bc_Khai_Thac.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc_Khai_Thac).Ten_Buu_Cuc + " được hưởng: " + HH_Phat_Hanh.ToString + vbNewLine
            'Dim StrHHPT As String = nLeftMar & Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc + " được hưởng:  " + HH_Phat_Tra.ToString + vbNewLine
            Dim StrQT As String = nLeftMar & "So EMS: " & (Tren5kgQT + Duoi5kgQT)
            'KLTren5kgQT = KLTren5kgQT / 1000
            'Dim StrTren5kg As String = IIf(Tren5kgQT > 0, "> 5kg : " & Tren5kgQT & "/" & KLTren5kgQT.ToString("##0.##0") & "/" & HHPTTren5kgQT, "> 5kg : 0")
            'KLDuoi5kgQT = KLDuoi5kgQT / 1000
            'Dim StrDuoi5kg As String = IIf(Duoi5kgQT > 0, "< 5kg : " & Duoi5kgQT & "/" & KLDuoi5kgQT.ToString("##0.##0") & "/" & HHPTDuoi5kgQT, "< 5kg : 0")
            'StrQT = StrQT & ", " & StrTren5kg & ", " & StrDuoi5kg
            'If Tren5kgQT = 0 And Duoi5kgQT = 0 Then
            '    StrQT = ""
            'End If
            'If Phan_Loai = 0 Or Phan_Loai = 1 Or Phan_Loai = 5 Then
            '    StrHHPH = ""
            'End If
            'Tong ket (theo tung chung loai - chi in o to E2 cuoi cung)--------------
            So_dong_tong_ket = 0
            strTONGKET = StrQT
            'If Trim(StrHHPH) <> "" Then So_dong_tong_ket += 1
            'If Trim(StrHHPT) <> "" Then So_dong_tong_ket += 1
            If Trim(StrQT) <> "" Then So_dong_tong_ket += 1
            '------------------------------------------------------------------------

            ''Tổng kết chuyến thư.
            ''BANG 2: Tổng kết chuyến thư.
            Dim Tuiso As String = ""
            'Xu ly doi voi tui F
            If F = True Then
                isTUIF = True
                myTKCT_E2_Di = myTKCT.Tong_Ket_Chuyen_Thu_E2_Di(Id_Chuyen_Thu).Tables(0)
                So_dong_tong_ket += 10 + myTKCT_E2_Di.Rows.Count
            Else
                isTUIF = False
            End If

            myData = myE2_Di.E2_Di_Ban_Ke(Id_E2)
            myData.Tables(0).TableName = "E2_Di_Ban_ke"
            'Them bien nay de dung trong WriteTXT
            myDataE1_CT = myData.Tables(0)
            '---------------------------------------            
            '            strFileName = ShowSaveDlg(Id_E2)
            strFileName = strDirPath & Id_E2 & ".ink"

            If WriteTXT(strFileName, soban) And Not bolPreview Then
                'print file to local printer
                'LocalPrintDOS(strFileName)
                If gKieu_In_Map = True Then
                    CopyFileToServer(strFileName, strDestination)
                Else
                    NetPrintDOS(strFileName, strTenMayE2, strTenMayInE2)
                End If
            Else
                'Copy file.ink vao may chu
                'Rem di de dung cach in qua may in mang tren DOS
                'FileCopy(strFileName, strDestination & Id_E2 & ".ink")
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Các sub và function Write TEXT"
        Private Function WriteTXT(ByVal sFileName As String, ByVal inSoBan As Integer) As Boolean
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer
            If Trim(Dir(sFileName)) = "" Then
                fileTXT = New StreamWriter(sFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(sFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If inSoBan = 0 Or inSoBan.ToString = "" Then
                inSoBan = 1
            End If
            For iSoBan = 1 To inSoBan
                Dong_hien_tai = 0
                'Phan header
                WriteHEADER(fileTXT, SoTrang)
                'Phan chi tiet - Tra ve so dong hien tai da in
                Dong_hien_tai = WriteCHITIET(fileTXT)
                'Tinh toan so dong da in + so dong tong ket de sang trang moi
                If ((Dong_hien_tai + So_dong_tong_ket) > E1PerPage) Then
                    NewPage(fileTXT, False)
                    Dong_hien_tai = 0
                End If
                'Tinh toan so dong can them vao cho day trang
                Do While Dong_hien_tai < (E1PerPage - So_dong_tong_ket)
                    InsertRow(fileTXT, 1)
                    Dong_hien_tai += 1
                Loop
                'Phan tong ket
                WriteTONGKET(fileTXT)
                'Phan Footer
                If iSoBan < inSoBan Then
                    WriteFOOTER(fileTXT, True, False)
                Else
                    WriteFOOTER(fileTXT, True, True)
                End If

                'If gKieu_In_Map = True Then
                '    WriteFOOTER(fileTXT, False)
                'Else
                '    If iSoBan < inSoBan Then
                '        WriteFOOTER(fileTXT, False)
                '    Else
                '        WriteFOOTER(fileTXT, True)
                '    End If
                'End If
            Next iSoBan
            fileTXT.Close()
            Return True
        End Function

        Private Sub WriteHEADER(ByVal sFileTXT As StreamWriter, ByVal iSOTRANG As Integer)
            sFileTXT.WriteLine(mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & LSet("       " & ConvetToABC(strFrom), 34) & "         " & LSet(ConvetToABC(strTO), 26) & mN)
            sFileTXT.WriteLine(nLeftMar & mB & LSet("                  " & strChuyenThu, 47) & LSet(strNGAY, 16) & strGIO & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & LSet("             " & strTuiSo, 52) & TotalKg / 1000 & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & RSet("Trang :  " & iSOTRANG.ToString, 65) & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            'sFileTXT.WriteLine()
            'sFileTXT.WriteLine()
        End Sub

        Private Sub WriteFOOTER(ByVal sFileTXT As StreamWriter, ByVal lastPage As Boolean, ByVal EndOfFile As Boolean)
            'sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            If lastPage = True Then
                sFileTXT.WriteLine(nLeftMar & mB & "                           " & Trim(ConvetToABC(strTongBPchu)) & mN)
            Else
                sFileTXT.WriteLine(nLeftMar & mN & "                           " & Trim("Xem tiep trang sau") & mN)
            End If
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(mB)
            If EndOfFile = True Then
                If gKieu_In_Map = True Then
                    sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 30) & vbNewLine & _
                                                       nLeftMar & padC(strNGAY, 30) & vbNewLine & _
                                                       nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 30) & mN & mNP)
                Else
                    sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 30) & vbNewLine & _
                                                       nLeftMar & padC(strNGAY, 30) & vbNewLine & vbNewLine & _
                                                       nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 30) & mN)
                End If
            Else
                sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 30) & vbNewLine & _
                                nLeftMar & padC(strNGAY, 30) & vbNewLine & _
                                nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 30) & mN & mNP)
            End If
            'Ky tu sang trang
            'sFileTXT.Write(mNP)
            'sFileTXT.WriteLine()
        End Sub

        Private Sub WriteTONGKET(ByVal sFileTXT As StreamWriter)
            Dim idx As Integer

            Dim TuiSo As Integer
            Dim TongBp As Integer
            Dim TongKg As Double

            Dim SoLuongTren5 As Integer
            Dim KhoiLuongTren5 As Double
            Dim CongPhatTren5 As Integer

            Dim SoLuongDuoi5 As Integer
            Dim KhoiLuongDuoi5 As Double
            Dim CongPhatDuoi5 As Integer

            Dim LePhi As Double
            Dim TuiF As String

            'Tong hop
            Dim Tong_So_Tui As Integer

            Dim Tong_So_Bp As Integer
            Dim Tong_So_Bp_Tren5 As Integer
            Dim Tong_So_Bp_Duoi5 As Integer

            Dim Tong_Khoi_Luong As Double
            Dim Tong_Khoi_Luong_Tren5 As Double
            Dim Tong_Khoi_Luong_Duoi5 As Double

            Dim Tong_Cong_Phat As Integer
            Dim Tong_Cong_Phat_Tren5 As Integer
            Dim Tong_Cong_Phat_Duoi5 As Integer

            Dim Tong_Le_Phi As Double

            'In phan tong ket theo mot E2
            sFileTXT.WriteLine(mB & ConvetToABC(strTONGKET))
            'In phan tong ket theo chuyen thu neu la Tui F
            If isTUIF = True Then
                sFileTXT.WriteLine()
                'sFileTXT.WriteLine(nLeftMar & mB & padC("BAN TONG KET CHUYEN THU", 60) & mN & vbNewLine & _
                '                   nLeftMar & "BUU CUC GUI:   " & ConvetToABC(strFrom) & vbNewLine & _
                '                   nLeftMar & "BUU CUC NHAN:   " & ConvetToABC(strTO) & vbNewLine & _
                '                   nLeftMar & "CHUYEN THU:   " & strChuyenThu & vbNewLine & vbNewLine & _
                '                   nLeftMar & LSet("TUISO", 6) & LSet("TONGSO", 7) & LSet("KHOILUONG", 9) & padC("BUU PHAM > 5KG", 21) & Space(1) & padC("BUU PHAM < 5KG", 21) & vbNewLine & _
                '                   nLeftMar & Space(24) & LSet("SL", 7) & LSet("KL", 7) & LSet("CP", 7) & Space(1) & LSet("SL", 7) & LSet("KL", 7) & LSet("CP", 7))
                sFileTXT.WriteLine(nLeftMar & mB & padC("BAN TONG KET CHUYEN THU", 60) & mN & vbNewLine & _
                                   nLeftMar & "BUU CUC GUI:   " & ConvetToABC(strFrom) & vbNewLine & _
                                   nLeftMar & "BUU CUC NHAN:   " & ConvetToABC(strTO) & vbNewLine & _
                                   nLeftMar & "CHUYEN THU:   " & strChuyenThu & vbNewLine & vbNewLine & _
                                   nLeftMar & LSet("TUISO", 6) & LSet("TONGSO", 7) & LSet("KHOILUONG", 9) & RSet("LE PHI HQ", 15))

                For idx = 0 To myTKCT_E2_Di.Rows.Count - 1
                    With myTKCT_E2_Di.Rows(idx)
                        'Khoi Tao
                        TuiSo = .Item("Tui_So")
                        TongBp = .Item("Tong_BP")
                        TongKg = .Item("Tong_Kg") / 1000

                        SoLuongTren5 = .Item("So_Luong_Tren5")
                        KhoiLuongTren5 = .Item("Khoi_Luong_Tren5") / 1000
                        CongPhatTren5 = .Item("Cong_Phat_Tren5")

                        SoLuongDuoi5 = .Item("So_Luong_Duoi5")
                        KhoiLuongDuoi5 = .Item("Khoi_Luong_Duoi5") / 1000
                        CongPhatDuoi5 = .Item("Cong_Phat_Duoi5")

                        LePhi = IIf(.Item("Le_Phi_HQ") Is System.DBNull.Value, 0, .Item("Le_Phi_HQ"))
                        TuiF = .Item("Tui_F")
                        'Tong hop
                        Tong_So_Tui += 1
                        Tong_So_Bp += TongBp
                        Tong_Khoi_Luong += TongKg
                        Tong_Cong_Phat += CongPhatTren5 + CongPhatDuoi5

                        Tong_So_Bp_Tren5 += SoLuongTren5
                        Tong_Khoi_Luong_Tren5 += KhoiLuongTren5
                        Tong_Cong_Phat_Tren5 += CongPhatTren5

                        Tong_So_Bp_Duoi5 += SoLuongDuoi5
                        Tong_Khoi_Luong_Duoi5 += KhoiLuongDuoi5
                        Tong_Cong_Phat_Duoi5 += CongPhatDuoi5

                        Tong_Le_Phi += LePhi

                        'Write TEXT
                        'sFileTXT.WriteLine(nLeftMar & LSet(TuiSo, 6) & LSet(TongBp, 7) & LSet(TongKg.ToString("##0.000"), 11) & _
                        'LSet(SoLuongTren5, 7) & LSet(KhoiLuongTren5.ToString("##0.000"), 7) & LSet(CongPhatTren5, 7) & Space(1) & _
                        'LSet(SoLuongDuoi5, 7) & LSet(KhoiLuongDuoi5.ToString("##0.000"), 7) & LSet(CongPhatDuoi5, 7) & RSet(TuiF, 2))
                        sFileTXT.WriteLine(nLeftMar & LSet(TuiSo, 6) & LSet(TongBp, 7) & LSet(TongKg.ToString("##0.000"), 11) & RSet(LePhi.ToString("##,###,##0"), 13) & RSet(TuiF, 5))
                    End With
                Next
                'sFileTXT.WriteLine(nLeftMar & mB & LSet("Tong so Tui", 20) & " = " & Tong_So_Tui.ToString & vbNewLine & _
                '                   nLeftMar & LSet("Tong so Buu Pham", 20) & " = " & _
                '                   LSet(Tong_So_Bp.ToString, 6) & ";    " & LSet("BP>5kg = " & Tong_So_Bp_Tren5, 15) & ";    " & _
                '                   "BP<5kg = " & Tong_So_Bp_Duoi5 & vbNewLine & _
                '                   nLeftMar & LSet("Tong Khoi luong", 20) & " =   " & RSet(Tong_Khoi_Luong.ToString("##0.000"), 12) & Space(4) & "KG" & vbNewLine & _
                '                   nLeftMar & LSet("      BP>5kg", 20) & " =   " & RSet(Tong_Khoi_Luong_Tren5.ToString("##0.000"), 12) & Space(4) & "KG" & vbNewLine & _
                '                   nLeftMar & LSet("      BP<5kg", 20) & " =   " & RSet(Tong_Khoi_Luong_Duoi5.ToString("##0.000"), 12) & Space(4) & "KG" & vbNewLine & _
                '                   nLeftMar & LSet("Tong Cong phat", 20) & " =   " & RSet(Tong_Cong_Phat, 12) & Space(4) & "VND" & vbNewLine & _
                '                   nLeftMar & LSet("      BP>5kg", 20) & " =   " & RSet(Tong_Cong_Phat_Tren5, 12) & Space(4) & "VND" & vbNewLine & _
                '                   nLeftMar & LSet("      BP<5kg", 20) & " =   " & RSet(Tong_Cong_Phat_Duoi5, 12) & Space(4) & "VND" & mN)
                sFileTXT.WriteLine(nLeftMar & mB & LSet("Tong so Tui", 17) & " = " & Tong_So_Tui.ToString & vbNewLine & _
                                   nLeftMar & LSet("Tong so Buu Pham", 17) & " = " & _
                                   LSet(Tong_So_Bp.ToString, 6) & vbNewLine & _
                                   nLeftMar & LSet("Tong Khoi luong", 17) & " =" & RSet(Tong_Khoi_Luong.ToString("##0.000"), 10) & "   Tong Le Phi = " & Tong_Le_Phi.ToString("##,###,##0") & mN)
            End If
            'If strCHANTRANG <> "" Then sFileTXT.WriteLine(nLeftMar & ConvetToABC(strCHANTRANG))
            'If strTKCT <> "" Then sFileTXT.WriteLine(ConvetToABC(strTKCT))
        End Sub

        Private Function WriteCHITIET(ByVal sFileTXT As StreamWriter) As Integer
            Dim ct_Id_E1 As String    'Id_E1
            Dim ct_phan_loai As String    'Phan loai
            'Dim gt_hang As Object
            Dim ct_khoi_luong As Integer  'khoi luong
            Dim ct_bc_gui As String       'Buu cuc goc
            Dim ct_bc_nhan As String      'Buu cuc tra
            Dim ct_cuoc_phi As Integer    'cuoc phi
            Dim ct_ghi_chu As String      'ghi chu
            'Dim ct_Cuoc_PPXD As Long

            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            Dim iSTT_in As Integer = 0

            For i = 0 To myDataE1_CT.Rows.Count - 1
                With myDataE1_CT.Rows(i)
                    'Kiem tra (het trang - sang trang moi)
                    If iSTT = E1PerPage Then
                        iSTT = 0
                        NewPage(sFileTXT, True)
                    End If
                    iSTT += 1
                    iSTT_in += 1
                    ct_Id_E1 = .Item("Ma_E1")
                    ct_phan_loai = .Item("Phan_loai")
                    ct_khoi_luong = .Item("Khoi_luong")
                    ct_bc_gui = .Item("Ma_Bc_goc")
                    ct_bc_nhan = .Item("Ma_Bc_tra")
                    ct_cuoc_phi = .Item("HH_phat_tra")
                    'If (.Item("Cuoc_PPXD") Is System.DBNull.Value) Or (.Item("Cuoc_PPXD") = 0) Or (Trim(CStr(.Item("Cuoc_PPXD")))) = "" Then
                    '    ct_ghi_chu = .Item("Ghi_chu")
                    'Else
                    '    If Trim(.Item("Ghi_chu")) = "" Then
                    '        ct_ghi_chu = "Thu " & CStr(.Item("Cuoc_PPXD"))
                    '    Else
                    '        ct_ghi_chu = "Thu " & CStr(.Item("Cuoc_PPXD")) & "-" & .Item("Ghi_Chu")
                    '    End If
                    'End If
                    ct_ghi_chu = .Item("Ghi_chu")
                    'Ghi ra file TXT phan chi tiet
                    sFileTXT.WriteLine(nLeftMar & LSet(CStr(iSTT_in), 4) & LSet(ct_Id_E1, 16) & LSet(ct_phan_loai, 1) & RSet(ct_khoi_luong, 9) & _
                                       RSet(ct_bc_gui, 10) & RSet(ct_bc_nhan, 11) & RSet(ct_cuoc_phi, 6) & "   " & LSet(ct_ghi_chu, 14))
                End With
            Next i
            Return iSTT
        End Function

        Private Sub NewPage(ByVal sFileTXT As StreamWriter, ByVal isFullPage As Boolean)
            'Tang so Trang in
            SoTrang += 1
            If isFullPage = False Then
                'Tinh toan so dong can them vao de sang trang
                Do While Dong_hien_tai < E1PerPage
                    InsertRow(sFileTXT, 1)
                    Dong_hien_tai += 1
                Loop
            End If
            'Phan footer cua trang hien tai
            WriteFOOTER(sFileTXT, False, False)
            ''Them 2 dong de sang trang moi in dung toa do
            'InsertRow(sFileTXT, 2)
            'Phan header cua trang tiep theo
            WriteHEADER(sFileTXT, SoTrang)
        End Sub
#End Region
#End Region

#Region "-------------------------Bản Kê E2 Second-------------------------"
#Region "Chuẩn bị dữ liệu In_E2 bản kê mới"
        Public Sub Ban_Ke_E2_Di_To_Text_Second(ByVal Id_E2 As String, ByVal bolPreview As Boolean, ByVal soban As Integer)
            Dim myE2_Di As New E2_Di(GConnectionString)
            Dim myE1_Di As New E1_Di(GConnectionString)
            Dim myE2_Di_ChiTiet As New E2_Di_Chi_Tiet
            'Dim pvCollection As New ParameterValues
            'Dim _pThamSo As New ParameterDiscreteValue
            Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
            Dim myHamdungchung As New Ham_Dung_Chung
            Dim myData As DataSet
            Dim myDataTK As DataSet
            Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
            Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
            Dim myNumber As New ConvertNumberToString
            Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim Id_Duong_Thu As String = myE2_Di.Lay(Id_E2).Id_Duong_Thu
            Dim Phan_Loai As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Id_Phan_Loai
            Dim Ma_Bc_Khai_Thac As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc_Khai_Thac
            Dim Id_Chuyen_Thu As String = myE2_Di.Lay(Id_E2).Id_Chuyen_Thu
            'Tong ket chuyen thu
            Dim myTKCT As New E2_Di(GConnectionString)
            '-----------
            Dim Tong_So_BP_CT As Integer = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).Tong_So_BP
            Dim Tui_So As Integer = myE2_Di.Lay(Id_E2).Tui_So
            Dim Ma_Bc As Integer = myDuong_Thu_Di.Lay(Id_Duong_Thu).Ma_Bc
            Dim Ngay_Thang As Integer = myE2_Di.Lay(Id_E2).Ngay_Dong
            Dim Ten_Dang_Nhap As String = myNguoi_Dung.Lay(myE1_Di.Lay_Id_Nguoi_Dung(Id_E2)).Ho_Ten
            Dim Tren5kgQT, Duoi5kgQT, KLTren5kgQT, KLDuoi5kgQT, HHPTTren5kgQT, HHPTDuoi5kgQT As Double
            Dim i, j, k, T, BP, Tong_HH As Integer
            Dim Gio As String = myHamdungchung.ConvertIntToTime(myE2_Di.Lay(Id_E2).Gio_Dong)
            Dim F As Boolean = myE2_Di.Lay(Id_E2).Tui_F
            '    Dim HH_Phat_Hanh As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Hanh
            '   Dim HH_Phat_Tra As Integer = myE2_Di.Lay(Id_E2).HH_Phat_Tra
            Dim Tong_So_BP As Integer = myE2_Di.Lay(Id_E2).Tong_So_BP
            Dim Nuoc_Nhan As String
            Dim Ma_Bc_Goc As Integer
            Dim Ma_Mc_Tra As Integer
            myNumber.Number = Tong_So_BP
            Dim myData1 As New DataTable
            Dim myData2 As New DataTable

            'Lay thong tin may in E2 trong regitry
            gKieu_In_Map = IIf(myKeys.Doc("GKieu_In_Map") Is Nothing Or myKeys.Doc("GKieu_In_Map") = "", False, myKeys.Doc("GKieu_In_Map"))
            strTenMayE2 = IIf(myKeys.Doc("GTen_May_Tinh_E2") Is Nothing Or myKeys.Doc("GTen_May_Tinh_E2") = "", "", CStr(myKeys.Doc("GTen_May_Tinh_E2")))
            strTenMayInE2 = IIf(myKeys.Doc("GTen_May_In_E2") Is Nothing Or myKeys.Doc("GTen_May_In_E2") = "", "", CStr(myKeys.Doc("GTen_May_In_E2")))
            strDestination = IIf(myKeys.Doc("GThu_Muc_In_E2_QT_Den") Is Nothing Or myKeys.Doc("GThu_Muc_In_E2_QT_Den") = "", "", CStr(myKeys.Doc("GThu_Muc_In_E2_QT_Den")))

            If gKieu_In_Map = True Then
                If strDestination = "" Then
                    MsgBox("Bạn chưa khai báo thư mục in E2!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            Else
                'Kiem tra neu chua khai bao may E2 thi yeu cau khai bao va show Form ThietLapThamSo 
                If strTenMayE2 = "" Or strTenMayInE2 = "" Then
                    MsgBox("Bạn chưa khai báo thông tin máy in E2!!!", MsgBoxStyle.Information, "Thông báo")
                    Dim frmHETHONG As New FrmThietLapThamSoHeThong
                    If Not bolPreview Then
                        frmHETHONG.ShowDialog()
                        Exit Sub
                    End If
                End If
            End If

            myData1 = myE1_Di.Danh_Sach_E1(Id_E2).Tables(0)
            myData2 = myE2_Di.Danh_Sach_Tong_Ket_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)

            TotalKg = 0
            Tren5kgQT = 0
            Duoi5kgQT = 0
            KLTren5kgQT = 0
            KLDuoi5kgQT = 0
            HHPTTren5kgQT = 0
            HHPTDuoi5kgQT = 0
            T = 0
            BP = 0
            Tong_HH = 0

            'Duyet myData1 lay thong tin
            For i = 0 To myData1.Rows.Count - 1
                If myData1.Rows(i).Item("Khoi_Luong") > 5000 Then
                    Tren5kgQT += 1
                    KLTren5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTTren5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                Else
                    Duoi5kgQT += 1
                    KLDuoi5kgQT += myData1.Rows(i).Item("Khoi_Luong")
                    HHPTDuoi5kgQT += myData1.Rows(i).Item("HH_Phat_Tra")
                End If
                'Tinh Tong Hoa Hong Phat Tra
                Tong_HH += HHPTDuoi5kgQT + HHPTTren5kgQT
                'Tinh tong khoi luong                
                TotalKg += myData1.Rows(i).Item("Khoi_Luong")
            Next

            strFrom = Ma_Bc_Khai_Thac.ToString + " - " + myDanh_Muc_BC.Lay(Ma_Bc_Khai_Thac).Ten_Buu_Cuc

            strChuyenThu = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu).So_Chuyen_Thu

            strTuiSo = Tui_So

            strTO = Ma_Bc.ToString + "-" + myDanh_Muc_BC.Lay(Ma_Bc).Ten_Buu_Cuc

            Dim Str As String = ""
            Select Case Phan_Loai
                Case 0
                    Str = "Bưu tá "
                Case 1
                    Str = "Giao dịch "
                Case 2
                    Str = "Khai thác "
                Case 3
                    Str = "Khai thác "
                Case 4
                    Str = "Khai thác "
            End Select

            strGIO = Gio

            strNGAY = myHamdungchung.ConvertIntToVNDateType(Ngay_Thang)

            strTEN_DANG_NHAP = Ten_Dang_Nhap

            strTongBPchu = myNumber.StringNumber + "bưu gửi"

            Dim StrQT As String = nLeftMar & "So EMS: " & (Tren5kgQT + Duoi5kgQT)
            'Tong ket (theo tung chung loai - chi in o to E2 cuoi cung)--------------
            strTONGKET = StrQT
            If Trim(StrQT) <> "" Then So_dong_tong_ket += 1
            '------------------------------------------------------------------------

            ''Tổng kết chuyến thư.
            ''BANG 2: Tổng kết chuyến thư.
            Dim Tuiso As String = ""
            'Xu ly doi voi tui F
            If F = True Then
                isTUIF = True
                myTKCT_E2_Di = myTKCT.Tong_Ket_Chuyen_Thu_E2_Di(Id_Chuyen_Thu).Tables(0)
                So_dong_tong_ket += 11 + myTKCT_E2_Di.Rows.Count
            Else
                isTUIF = False
            End If

            myData = myE2_Di.E2_Di_Ban_Ke(Id_E2)
            myData.Tables(0).TableName = "E2_Di_Ban_ke"
            'Them bien nay de dung trong WriteTXT
            myDataE1_CT = myData.Tables(0)
            '---------------------------------------            
            '            strFileName = ShowSaveDlg(Id_E2)
            strFileName = strDirPath & Id_E2 & ".ink"

            If WriteTXT_Second(strFileName, soban) And Not bolPreview Then
                'print file to local printer
                'LocalPrintDOS(strFileName)
                If gKieu_In_Map = True Then
                    CopyFileToServer(strFileName, strDestination)
                Else
                    NetPrintDOS(strFileName, strTenMayE2, strTenMayInE2)
                End If
            Else
                'Copy file.ink vao may chu
                'Rem di de dung cach in qua may in mang tren DOS
                'FileCopy(strFileName, strDestination & Id_E2 & ".ink")
                ViewNotePad(strFileName)
            End If

        End Sub
#End Region

#Region "Các sub và function Write TEXT Second"
        Private Function WriteTXT_Second(ByVal sFileName As String, ByVal inSoBan As Integer) As Boolean
            Dim fileTXT As StreamWriter
            Dim iSoBan As Integer
            If Trim(Dir(sFileName)) = "" Then
                fileTXT = New StreamWriter(sFileName, True, System.Text.Encoding.ASCII)
            Else
                fileTXT = New StreamWriter(sFileName, False, System.Text.Encoding.ASCII)
            End If
            'Kiem tra neu so ban = 0 hoac null thi gan = 1
            If inSoBan = 0 Or inSoBan.ToString = "" Then
                inSoBan = 1
            End If
            For iSoBan = 1 To inSoBan
                Dong_hien_tai = 0
                'Phan header
                WriteHEADER_Second(fileTXT, SoTrang)
                'Phan chi tiet - Tra ve so dong hien tai da in
                Dong_hien_tai = WriteCHITIET_Second(fileTXT)
                'Tinh toan so dong da in + so dong tong ket de sang trang moi
                If ((Dong_hien_tai + So_dong_tong_ket) > GSo_Dong_Trong_Trang_In_Ban_Ke_E2) Then
                    NewPage_Second(fileTXT, False)
                    Dong_hien_tai = 0
                End If
                'Tinh toan so dong can them vao cho day trang
                Do While Dong_hien_tai < (GSo_Dong_Trong_Trang_In_Ban_Ke_E2 - So_dong_tong_ket)
                    InsertRow(fileTXT, 1)
                    Dong_hien_tai += 1
                Loop
                'Phan tong ket
                WriteTONGKET_Second(fileTXT)
                'Phan Footer
                If iSoBan < inSoBan Then
                    WriteFOOTER_Second(fileTXT, True, False)
                Else
                    WriteFOOTER_Second(fileTXT, True, True)
                End If
                ''Phan Footer
                'If gKieu_In_Map = True Then
                '    WriteFOOTER_Second(fileTXT, False)
                'Else
                '    If iSoBan < inSoBan Then
                '        WriteFOOTER_Second(fileTXT, False)
                '    Else
                '        WriteFOOTER_Second(fileTXT, True)
                '    End If
                'End If
            Next iSoBan
            fileTXT.Close()
            Return True
        End Function

#Region "----------WriteHEADER_Second----------"
        Private Sub WriteHEADER_Second(ByVal sFileTXT As StreamWriter, ByVal iSOTRANG As Integer)
            Dim str_Line_1 As String 'From
            Dim str_Line_2 As String 'To
            Dim str_Line_3 As String 'Despatch No
            Dim str_Line_4 As String 'Bag no
            'Từ
            str_Line_1 = LSet("       " & ConvetToABC(strFrom), 50)
            'Đến
            str_Line_2 = LSet("       " & ConvetToABC(strTO), 50)
            'Chuyến Thư, Ngày tháng, giờ
            str_Line_3 = LSet(LSet("        " & strChuyenThu & "        ", 25) & LSet(strNGAY, 15) & strGIO, 50)
            'Túi số, Khối lượng, trang
            str_Line_4 = LSet(LSet("        " & strTuiSo & "        ", 25) & LSet(TotalKg / 1000, 15) & "Trang: " & iSOTRANG.ToString, 50)

            sFileTXT.WriteLine(mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & str_Line_1 & mN)
            sFileTXT.WriteLine(nLeftMar & mB & str_Line_2 & mN)
            sFileTXT.WriteLine(nLeftMar & mB & str_Line_3 & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(nLeftMar & mB & str_Line_4 & mN)
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
        End Sub
#End Region

#Region "----------WriteFOOTER_Second----------"
        Private Sub WriteFOOTER_Second(ByVal sFileTXT As StreamWriter, ByVal lastPage As Boolean, ByVal EndOfFile As Boolean)
            'sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            If lastPage = True Then
                sFileTXT.WriteLine(nLeftMar & mB & "                 " & Trim(ConvetToABC(strTongBPchu)) & mN)
            Else
                sFileTXT.WriteLine(nLeftMar & mN & "                 " & Trim("Xem tiep trang sau") & mN)
            End If
            sFileTXT.WriteLine()
            sFileTXT.WriteLine()
            sFileTXT.WriteLine(mB)
            If EndOfFile = True Then
                If gKieu_In_Map = True Then
                    sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 20) & vbNewLine & _
                                                       nLeftMar & padC(strNGAY, 20) & vbNewLine & vbNewLine & _
                                                       nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 20) & mN & mNP)
                Else
                    sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 20) & vbNewLine & _
                                                       nLeftMar & padC(strNGAY, 20) & vbNewLine & vbNewLine & vbNewLine & _
                                                       nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 20) & mN)
                End If
            Else
                sFileTXT.Write(nLeftMar & padC(ConvetToABC(strFrom), 20) & vbNewLine & _
                                nLeftMar & padC(strNGAY, 20) & vbNewLine & vbNewLine & _
                                nLeftMar & padC(ConvetToABC(strTEN_DANG_NHAP), 20) & mN & mNP)
            End If
        End Sub
#End Region

#Region "----------WriteTONGKET_Second----------"
        Private Sub WriteTONGKET_Second(ByVal sFileTXT As StreamWriter)
            Dim idx As Integer

            Dim TuiSo As Integer
            Dim TongBp As Integer
            Dim TongKg As Double

            Dim SoLuongTren5 As Integer
            Dim KhoiLuongTren5 As Double
            Dim CongPhatTren5 As Integer

            Dim SoLuongDuoi5 As Integer
            Dim KhoiLuongDuoi5 As Double
            Dim CongPhatDuoi5 As Integer

            Dim LePhi As Double
            Dim TuiF As String

            'Tong hop
            Dim Tong_So_Tui As Integer

            Dim Tong_So_Bp As Integer
            Dim Tong_So_Bp_Tren5 As Integer
            Dim Tong_So_Bp_Duoi5 As Integer

            Dim Tong_Khoi_Luong As Double
            Dim Tong_Khoi_Luong_Tren5 As Double
            Dim Tong_Khoi_Luong_Duoi5 As Double

            Dim Tong_Cong_Phat As Integer
            Dim Tong_Cong_Phat_Tren5 As Integer
            Dim Tong_Cong_Phat_Duoi5 As Integer

            Dim Tong_Le_Phi As Double

            'In phan tong ket theo mot E2
            sFileTXT.WriteLine(mB & ConvetToABC(strTONGKET))
            'In phan tong ket theo chuyen thu neu la Tui F
            If isTUIF = True Then
                sFileTXT.WriteLine()
                sFileTXT.WriteLine(nLeftMar & mB & padC("BAN TONG KET CHUYEN THU", 60) & mN & vbNewLine & _
                                   nLeftMar & "BUU CUC GUI:   " & ConvetToABC(strFrom) & vbNewLine & _
                                   nLeftMar & "BUU CUC NHAN:   " & ConvetToABC(strTO) & vbNewLine & _
                                   nLeftMar & "CHUYEN THU:   " & strChuyenThu & vbNewLine & vbNewLine & _
                                   nLeftMar & LSet("TUISO", 6) & LSet("TONGSO", 7) & LSet("KHOILUONG", 9) & RSet("LE PHI HQ", 15))

                For idx = 0 To myTKCT_E2_Di.Rows.Count - 1
                    With myTKCT_E2_Di.Rows(idx)
                        'Khoi Tao
                        TuiSo = .Item("Tui_So")
                        TongBp = .Item("Tong_BP")
                        TongKg = .Item("Tong_Kg") / 1000

                        SoLuongTren5 = .Item("So_Luong_Tren5")
                        KhoiLuongTren5 = .Item("Khoi_Luong_Tren5") / 1000
                        CongPhatTren5 = .Item("Cong_Phat_Tren5")

                        SoLuongDuoi5 = .Item("So_Luong_Duoi5")
                        KhoiLuongDuoi5 = .Item("Khoi_Luong_Duoi5") / 1000
                        CongPhatDuoi5 = .Item("Cong_Phat_Duoi5")

                        LePhi = IIf(.Item("Le_Phi_HQ") Is System.DBNull.Value, 0, .Item("Le_Phi_HQ"))
                        TuiF = .Item("Tui_F")
                        'Tong hop
                        Tong_So_Tui += 1
                        Tong_So_Bp += TongBp
                        Tong_Khoi_Luong += TongKg
                        Tong_Cong_Phat += CongPhatTren5 + CongPhatDuoi5

                        Tong_So_Bp_Tren5 += SoLuongTren5
                        Tong_Khoi_Luong_Tren5 += KhoiLuongTren5
                        Tong_Cong_Phat_Tren5 += CongPhatTren5

                        Tong_So_Bp_Duoi5 += SoLuongDuoi5
                        Tong_Khoi_Luong_Duoi5 += KhoiLuongDuoi5
                        Tong_Cong_Phat_Duoi5 += CongPhatDuoi5

                        Tong_Le_Phi += LePhi

                        sFileTXT.WriteLine(nLeftMar & LSet(TuiSo, 6) & LSet(TongBp, 7) & LSet(TongKg.ToString("##0.000"), 11) & RSet(LePhi.ToString("##,###,##0"), 13) & RSet(TuiF, 5))
                    End With
                Next
                sFileTXT.WriteLine(nLeftMar & mB & LSet("Tong so Tui", 17) & " = " & Tong_So_Tui.ToString & vbNewLine & _
                                   nLeftMar & LSet("Tong so Buu Pham", 17) & " = " & LSet(Tong_So_Bp.ToString, 6) & vbNewLine & _
                                   nLeftMar & LSet("Tong Khoi luong", 17) & " = " & LSet(Tong_Khoi_Luong.ToString("##0.000"), 15) & vbNewLine & _
                                   nLeftMar & LSet("Tong Le Phi", 17) & " = " & LSet(Tong_Le_Phi.ToString("##,###,##0"), 15) & mN)
            End If
        End Sub
#End Region

#Region "----------WriteCHITIET_Second----------"
        Private Function WriteCHITIET_Second(ByVal sFileTXT As StreamWriter) As Integer
            Dim ct_Id_E1 As String    'Id_E1
            Dim ct_phan_loai As String    'Phan loai
            'Dim gt_hang As Object
            Dim ct_khoi_luong As Integer  'khoi luong
            Dim ct_bc_gui As String       'Buu cuc goc
            Dim ct_bc_nhan As String      'Buu cuc tra
            Dim ct_cuoc_phi As Integer    'cuoc phi
            Dim ct_ghi_chu As String      'ghi chu
            'Dim ct_Cuoc_PPXD As Long

            Dim i As Integer    'index duyet file chi tiet E1
            Dim iSTT As Integer = 0 'So thu tu tren E2
            Dim iSTT_in As Integer = 0

            For i = 0 To myDataE1_CT.Rows.Count - 1
                With myDataE1_CT.Rows(i)
                    'Kiem tra (het trang - sang trang moi)
                    If iSTT = E1PerPage Then
                        iSTT = 0
                        NewPage_Second(sFileTXT, True)
                    End If
                    iSTT += 1
                    iSTT_in += 1
                    ct_Id_E1 = .Item("Ma_E1")
                    ct_phan_loai = .Item("Phan_loai")
                    ct_khoi_luong = .Item("Khoi_luong")
                    ct_cuoc_phi = .Item("HH_phat_tra")
                    ct_ghi_chu = .Item("Ghi_chu")
                    'Ghi ra file TXT phan chi tiet
                    If GIn_HH_Phat_Tra_Tren_E2 = True Then 'In hoa hồng phát trả
                        sFileTXT.WriteLine(nLeftMar & LSet(CStr(iSTT_in), 4) & LSet(ct_Id_E1, 15) & LSet(ct_phan_loai, 1) & " " & RSet(ct_khoi_luong, 6) & _
                                                               RSet(ct_cuoc_phi, 6) & "  " & LSet(ct_ghi_chu, 14))
                    Else 'Không in hoa hồng phát trả
                        sFileTXT.WriteLine(nLeftMar & LSet(CStr(iSTT_in), 4) & LSet(ct_Id_E1, 15) & LSet(ct_phan_loai, 1) & " " & RSet(ct_khoi_luong, 6) & _
                                       "   " & LSet(ct_ghi_chu, 18))
                    End If
                End With
            Next i
            Return iSTT
        End Function
#End Region

#Region "----------NewPage_Second----------"
        Private Sub NewPage_Second(ByVal sFileTXT As StreamWriter, ByVal isFullPage As Boolean)
            'Tang so Trang in
            SoTrang += 1
            If isFullPage = False Then
                'Tinh toan so dong can them vao de sang trang
                Do While Dong_hien_tai < GSo_Dong_Trong_Trang_In_Ban_Ke_E2
                    InsertRow(sFileTXT, 1)
                    Dong_hien_tai += 1
                Loop
            End If
            'Phan footer cua trang hien tai
            WriteFOOTER_Second(sFileTXT, False, False)
            ''Them 2 dong de sang trang moi in dung toa do
            'InsertRow(sFileTXT, 2)
            'Phan header cua trang tiep theo
            WriteHEADER_Second(sFileTXT, SoTrang)
        End Sub
#End Region

#End Region
#End Region

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

        Public Sub New()

        End Sub
    End Class
#End Region

#Region "AddImageToCrystal"
    Public Function AddImageToCrystal(ByVal strPath As String) As DataTable
        Dim myFileName As String = ""
        Try
            ' here i have define a simple datatable inwhich image will recide
            Dim dt As New DataTable("barcode128")
            ' object of data row
            Dim drow As DataRow
            ' add the column in table to store the image of Byte array type
            dt.Columns.Add("img128", System.Type.GetType("System.Byte[]"))
            drow = dt.NewRow
            ' define the filestream object to read the image
            Dim fs As FileStream
            ' define te binary reader to read the bytes of image
            Dim br As BinaryReader
            If File.Exists(strPath) Then
                ' open image in file stream
                fs = New FileStream(strPath, FileMode.Open)
            End If
            ' initialise the binary reader from file streamobject
            br = New BinaryReader(fs)
            ' define the byte array of filelength
            Dim imgbyte(fs.Length) As Byte
            ' read the bytes from the binary reader
            imgbyte = br.ReadBytes(Convert.ToInt32((fs.Length)))
            drow(0) = imgbyte       ' add the image in bytearray
            dt.Rows.Add(drow)       ' add row into the datatable
            br.Close()              ' close the binary reader
            fs.Close()              ' close the file stream
            Return dt
        Catch ex As Exception
            CMessageBox.Show("Không tồn tại file ảnh nhật ấn: " & vbNewLine & AppDomain.CurrentDomain.BaseDirectory & myFileName)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Lay_So_Hieu_Chuyen_Bay_In_BV10"
    Public Function Lay_So_Hieu_Chuyen_Bay_In_BV10(ByVal mSo_Hieu As String) As String
        Dim strReturn As String
        Dim mViTri As Integer
        Try
            mViTri = mSo_Hieu.IndexOf("/")
            If mViTri < 0 Then
                strReturn = mSo_Hieu
            Else
                strReturn = mSo_Hieu.Substring(0, mViTri)
            End If
            Return strReturn
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
#End Region

#Region "Kiem_Tra_So_Tien_Phai_Thu_Qua_Paypost"
    Public Function Kiem_Tra_So_Tien_Phai_Thu_Qua_Paypost(ByVal Thue_NK_VAT As Integer, ByVal Le_Phi_HQ As Integer, ByVal Le_Phi_VH As Integer, ByVal Le_Phi_YT As Integer, ByVal Le_Phi_DV As Integer, ByVal Le_Phi_TV As Integer, ByVal Le_Phi_Khac As Integer) As Integer
        Try
            Dim mTotal As Integer = 0
            mTotal = Thue_NK_VAT + Le_Phi_HQ + Le_Phi_DV + Le_Phi_TV + Le_Phi_VH + Le_Phi_YT + Le_Phi_Khac
            Return mTotal
        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "Tinh_Cuoc_COD_PayPost"
#Region "Call_Store_Tinh_Cuoc_COD_New"
    Public Function Call_Store_Tinh_Cuoc_COD_New(ByVal ConnectionString As String, ByVal Ma_Dich_Vu As String, ByVal Ngay_Gui As Integer, ByVal Gia_Tri As Integer) As Integer

        Try
            ' Tạo đối tượng connection và command
            Dim myConnection As SqlConnection = New SqlConnection(ConnectionString)
            Dim myCommand As SqlCommand = New SqlCommand("Tinh_Cuoc_Dich_Vu_COD_New", myConnection)

            ' Sử dụng Store Procedure
            myCommand.CommandType = CommandType.StoredProcedure
            ' Thêm các Parameters vào thủ tục
            Dim pMa_Dich_Vu As SqlParameter = New SqlParameter("@Ma_Dich_Vu", SqlDbType.VarChar, 5)
            pMa_Dich_Vu.Value = Ma_Dich_Vu
            myCommand.Parameters.Add(pMa_Dich_Vu)

            Dim pNgay_Gui As SqlParameter = New SqlParameter("@Ngay_Gui", SqlDbType.Int)
            pNgay_Gui.Value = Ngay_Gui
            myCommand.Parameters.Add(pNgay_Gui)

            Dim pGia_Tri As SqlParameter = New SqlParameter("@Gia_Tri", SqlDbType.Int)
            pGia_Tri.Value = Gia_Tri
            myCommand.Parameters.Add(pGia_Tri)

            Dim pCuoc_COD As SqlParameter = New SqlParameter("@Cuoc_COD", SqlDbType.Int)
            pCuoc_COD.Direction = ParameterDirection.Output
            myCommand.Parameters.Add(pCuoc_COD)

            myConnection.Open()
            myCommand.ExecuteNonQuery()
            myConnection.Close()
            Return Convert.ToInt32(pCuoc_COD.Value)

        Catch ex As Exception
            Return 0
            Console.Write(ex.ToString)
        End Try

    End Function
#End Region

#Region "Tinh_Cuoc_COD_Di"
    Public Function Tinh_Cuoc_COD_Di(ByVal So_Tien_Thu_Ho As Integer, ByVal Ngay_Dong As Integer) As Integer
        Dim mResult As Integer
        Try
            If So_Tien_Thu_Ho = 0 Then
                Return 0
                Exit Function
            End If
            mResult = Call_Store_Tinh_Cuoc_COD_New(GConnectionString, "COD", Ngay_Dong, Convert.ToDecimal(So_Tien_Thu_Ho))
            Return mResult
        Catch ex As Exception
            MessageBox.Show("Lỗi tính cước qua dịch vụ PayPost!!! Hãy thông báo lỗi này cho người quản trị hệ thống ngay.", "Lỗi tính cước PayPost", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region

#Region "Chuan_Hoa_Thong_Tin_PayPost"
    Public Function Chuan_Hoa_Thong_Tin_PayPost(ByVal strThongTin As String) As String
        If strThongTin.Trim = "" Then
            Return "NOT INFO"
        Else
            Return strThongTin
        End If
    End Function
#End Region

#End Region

End Module

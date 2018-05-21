Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Imports Ems_International_Logic.EMS
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared.PaperSize
Imports System.Net.Dns
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports ICSharpCode.SharpZipLib.Zip
Module QLTGND_Common

    Public GLoai_Chuyen_Thu_Trong_Nuoc As String = "EN"
#Region "Trang_Thai_BC37 - Đồng nhất với phần tạo bảng trạng thái BC37 bên dưới"
    Public Const Trang_Thai_Chua_Xac_Nhan As Integer = 0
    Public Const Trang_Thai_Dang_Xac_Nhan As Integer = 1
    Public Const Trang_Thai_Da_Hoan_Tat As Integer = 2
#End Region

#Region "Status BC37 - Trạng thái, thể hiện trạng thái BC37, Đồng nhất với bên paynet"
    Public Const gStatus_BC37_0 As Integer = 0 ' 0: khởi tạo
    Public Const gStatus_BC37_1 As Integer = 1 ' 1: đã đi khỏi BC gửi
    Public Const gStatus_BC37_2 As Integer = 2 ' 2: đã đến BC đích
    Public Const gIS_PRINTER_0 As Integer = 0 ' Không cho phép in
    Public Const gIS_PRINTER_1 As Integer = 1 ' Cho phép in
    Public Const gWAY_TYPE_0 As Integer = 0 ' Chiều vận chuyển : Chiều đi
    Public Const gWAY_TYPE_1 As Integer = 1 ' Chiều vận chuyển : Chiều về
    Public Const gIS_DISCRETE_0 As Integer = 0 ' Có đóng rời hay không : Có
    Public Const gIS_DISCRETE_1 As Integer = 1 ' Có đóng rời hay không : Không
    Public Const gIS_DELIVERY_ROUTE_0 As Integer = 0 ' Có tuyến phát hay không
    Public Const gIS_DELIVERY_ROUTE_1 As Integer = 1 ' Có tuyến phát hay không
    Public Const gTruyen_Du_Lieu_0 As Integer = 0 ' 0 : Chưa truyền
    Public Const gTruyen_Du_Lieu_1 As Integer = 1 ' 1 : Đã truyền

    Public Const gTrang_Thai_0 As Integer = 0 ' 0 : Chưa xác nhận
    Public Const gTrang_Thai_1 As Integer = 1 ' 1 : Đã xác nhận
    Public Const gTrang_Thai_2 As Integer = 2 ' 2 : Đã truyền

#End Region

#Region "Status Postbag - Trạng thái, thể hiện trạng thái Postbag, Đồng nhất với bên paynet"
    Public Const gStatus_Postbag_0 As Integer = 0 ' 0: khởi tạo
    Public Const gStatus_Postbag_1 As Integer = 1 ' 1: đã đóng chuyến xe
    Public Const gStatus_Postbag_2 As Integer = 2 ' 2: 2- Đã đi
    Public Const gStatus_Postbag_3 As Integer = 3 ' 3: 3- Đã đến
#End Region

#Region "Biến dùng trong Generate Mã vạch túi"
    Public GLoai_Chuyen_Thu As String = "A"
    Public GLoai_Dich_Vu As String = "EA"
    Public GLoai_Tui As Integer = 0
#End Region

    'Public Const GSo_Ngay_Kiem_Tra_BC37 As Integer = 2
    Dim _strInput As String = ""
    Dim _strOutput As String = ""
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)

#Region "WebServives"
#Region "IP"
    Public Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = GetHostName()


        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next

    End Function


#End Region
#Region "MAC"
    Public Function GetMacAddress() As String
        Dim qstring As String = "SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled = true"
        For Each mo As System.Management.ManagementObject In New System.Management.ManagementObjectSearcher(qstring).Get()
            Dim macaddress As String = mo("MacAddress")
            If Not macaddress Is Nothing Then
                Return macaddress
            End If
        Next
        Return ""
    End Function

#End Region
#Region "RSAPrivateKey--RSAPublicKey"
    Public Const RSAPrivateKey As String = "<RSAKeyValue><Modulus>u9gTDzINo0zUsc+hubvt4GYKil8nE8ZUppCLOfa+fTBsvUiTPIAZXTutXYCalP30C6I1x54MOck/hFhco/khwgSOC/oS9tytOPsQAk1rN1cZjV20W8ZtyzKQu1GiE9WQv2Re39uhoPQqtyvXYOnYJfmRqCqkkXeRiV8uU5eHC+s=</Modulus><Exponent>AQAB</Exponent><P>7a4kJmbs031hM8CeNLBGkMllMYS8ltLxFldoBy/GzyxUSFEWWnEFfR8SvaP1HkkT9TYN3oWUfEPOambFKHXKDQ==</P><Q>ylKTS71PQ59Um8iQCC/v6OFbyQDiQCeMFTRMuedUFeCJxN9uQhckMC8ChMw3rfNqngXINPeRATqhLQBHk2QH1w==</Q><DP>JOA3y518cPOq+RSRdytCR4R3ps8pU102+nhlM3g+KDaAfRfXmAChEWCYz8N4bFJ6Pjk8vaGMABulEu0O+dAMoQ==</DP><DQ>NJiE3CKpkW3BJAJelxJHLuYu4zEMoBrnyrde3tEpRcqqZfijhCDZ8oC2CenA68Kky9G6+zIEiyo/riAtez583w==</DQ><InverseQ>z2Qj1XZIvGKuyB+NwSPSieXP+rjKilkRUJGQOenKYLafgVcDCwlYWYphiaqo5UUpV1fKvSDLu58x09TnPZuptw==</InverseQ><D>iHeGATgf6E9dBoENwV3ih3AaoERYo2km/otsWoQEB/cySKF9NirqQm2kmZVguHV24yzJXWhZAXJPjtqTEx1fg9EZrBvFODNntaPdpBsQoWQ9poc34VMktb8ry4UfMZOqe/9WUjwZSCpXB9oFfDs2ZftWxfbEURGw5r3Y7IWT5+E=</D></RSAKeyValue>"

    Public Const RSAPublicKey As String = "<RSAKeyValue><Modulus>u9gTDzINo0zUsc+hubvt4GYKil8nE8ZUppCLOfa+fTBsvUiTPIAZXTutXYCalP30C6I1x54MOck/hFhco/khwgSOC/oS9tytOPsQAk1rN1cZjV20W8ZtyzKQu1GiE9WQv2Re39uhoPQqtyvXYOnYJfmRqCqkkXeRiV8uU5eHC+s=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
#End Region
#Region "API - ExecuteMessage"

#Region "BC200 - Them_Thong_Tin_BC37"
    Public Function Them_Thong_Tin_BC37(ByVal Bc37_Index As Integer, ByVal From_Po_Code As String, ByVal To_Po_Code As String, ByVal Transport_Type_Code As String, ByVal Status As String, ByVal Bc37_Date As String, ByVal Confirm_User As Integer, ByVal Comfirm_Po_Code As String, ByVal Create_User As Integer, ByVal Create_Po_Code As String, ByVal Bc37_Code As String, ByVal Confirm_Date As String, ByVal Total_Weight As Integer, ByVal Total_Quantity As Integer, ByVal Denivery As String, ByVal Mail_Route_Id As Integer, ByVal NUMBER_OF_BAGS_1 As Integer, ByVal NUMBER_OF_BAGS_2 As Integer) As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), Gid_Nguoi_Dung, myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, Bc37_Index, From_Po_Code, To_Po_Code, Transport_Type_Code, Status, Bc37_Date, Confirm_User, Comfirm_Po_Code, Create_User, Create_Po_Code, Bc37_Code, Confirm_Date, Total_Weight, Total_Quantity, Denivery, Mail_Route_Id, NUMBER_OF_BAGS_1, NUMBER_OF_BAGS_2}


            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC200", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            myReString = Nothing
            Return myReString
        Finally
            Dim ObjBC37 As New QLTGND_BC37(GConnectionString)
            Dim ObjPostbag As New QLTGND_POSTBAG(GConnectionString)
            'Close the connection and Dispose.
            If myReString Is Nothing Then
                MessageBox.Show("Lỗi truyền dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ObjBC37.QLTGND_BC37_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_0)
                ObjPostbag.QLTGND_POSTBAG_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_0)
            Else
                If myReString.IndexOf("00") < 0 Then
                    MessageBox.Show("Lỗi truyền dữ liệu!!!" & vbNewLine & myReString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ObjBC37.QLTGND_BC37_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_0)
                    ObjPostbag.QLTGND_POSTBAG_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_0)
                Else
                    ObjBC37.QLTGND_BC37_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_1)
                    ObjPostbag.QLTGND_POSTBAG_Cap_Nhat_Lai_Trang_Thai_Truyen(Bc37_Code, gTruyen_Du_Lieu_1)
                End If
            End If

        End Try
    End Function

#End Region

#Region "BC300 - Them_Thong_Tin_Tui_Goi"
    Public Function Them_Thong_Tin_Tui_Goi(ByVal Post_Bag_Index As Integer, ByVal Post_Bag_Type As Integer, ByVal Post_Bag_Number As String, ByVal From_Po_Code As String, ByVal To_Po_Code As String, ByVal Year As String, ByVal Mail_Trip_Number As Integer, ByVal Mail_Trip_Type As String, ByVal Service_Code As String, ByVal F As String, ByVal Weight As Integer, ByVal Status As String, ByVal Quantity As Integer, ByVal Is_Printer As Integer, ByVal Bc37_Date As String, ByVal Packaging_Time As String, ByVal Packaging_User As String, ByVal Packaging_Machine As String, ByVal Open_Time As String, ByVal Open_User As String, ByVal Open_Machine As String, ByVal Incoming_Date As String, ByVal Case_Weight As Integer, ByVal In_Discrete As Integer, ByVal Is_Delivery_Route As Integer, ByVal Bc37_Code As String) As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), Gid_Nguoi_Dung, myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, Post_Bag_Index, Post_Bag_Type, Post_Bag_Number, From_Po_Code, To_Po_Code, Year, Mail_Trip_Number, Mail_Trip_Type, Service_Code, F, Weight, Status, Quantity, Is_Printer, Bc37_Date, Packaging_Time, Packaging_User, Packaging_Machine, Open_Time, Open_User, Open_Machine, Incoming_Date, Case_Weight, In_Discrete, Is_Delivery_Route, Bc37_Code}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC300", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            myReString = Nothing
            Return myReString
        Finally
            'Close the connection and Dispose.
            'Close the connection and Dispose.
            If myReString Is Nothing Then
                MessageBox.Show("Lỗi truyền dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If myReString.IndexOf("00") < 0 Then
                    MessageBox.Show("Lỗi truyền dữ liệu!!!" & vbNewLine & myReString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Try
    End Function

#End Region

#Region "BC2900 - Liệt kê chặng vận chuyển"
    Public Function Liet_Ke_Chang_Van_Chuyen(ByVal PO_CODE_ROOT As String, ByVal PO_WAY As String) As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, PO_CODE_ROOT, PO_WAY}

            ' Dim myArray() As String = {PO_CODE_ROOT, PO_WAY}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC2900", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.

        End Try
    End Function

#End Region

#Region "BC3000 - Liet_Ke_Tuyen_Duong_Thu_Theo_Ma_BC"
    Public Function Liet_Ke_Tuyen_Duong_Thu_Theo_Ma_BC(ByVal PO_CODE_ROOT As String) As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, PO_CODE_ROOT}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC3000", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString
        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.

        End Try
    End Function

#End Region

#Region "BC1711 - Liet_Ke_Loai_Phuong_Tien_Van_Chuyen"
    Public Function Liet_Ke_Loai_Phuong_Tien_Van_Chuyen() As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC1711", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.

        End Try
    End Function

#End Region

#Region "BC1188 - Liet_Ke_Doi_Tac_Van_Chuyen"
    Public Function Liet_Ke_Doi_Tac_Van_Chuyen() As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC1188", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.
        End Try
    End Function

#End Region

#Region "BC2800 - Thêm thông tin Mail_Trip_Transport_BC37"
    Public Function Them_Thong_Tin_Mail_Trip_Transport_BC37(ByVal BC37_DATE As String, ByVal BC37_FROM_PO_CODE As String, ByVal BC37_TO_PO_CODE As String, ByVal TRANSPORT_TYPE_ID As String, ByVal BC37_ORDER As Integer, ByVal MAIL_TRIP_TP_FROM_PO_CODE As String, ByVal TRANSPORT_DATE As String, ByVal CONFIRM_USER As String, ByVal CONFIRM_POS_CODE As String, ByVal CREATE_USER As String, ByVal CREATE_PO_CODE As String, ByVal CONFIRM_DATE As String, ByVal TRANSPORT_NUMBER As String, ByVal BC37_NUMBER As String, ByVal WAY_TYPE As Integer, ByVal PARTNER_ID As Integer, ByVal MAIL_ROUTE_ID As Integer, ByVal ID_CA As Integer, ByVal DATE_CA As String) As String
        Dim myReString As String = ""
        DATE_CA = DATE_CA.Replace("AM", "").Replace("PM", "").Trim
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), Gid_Nguoi_Dung, myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, BC37_DATE, BC37_FROM_PO_CODE, BC37_TO_PO_CODE, TRANSPORT_TYPE_ID, BC37_ORDER, MAIL_TRIP_TP_FROM_PO_CODE, TRANSPORT_DATE, CONFIRM_USER, CONFIRM_POS_CODE, CREATE_USER, CREATE_PO_CODE, CONFIRM_DATE, TRANSPORT_NUMBER, BC37_NUMBER, WAY_TYPE, PARTNER_ID, MAIL_ROUTE_ID, ID_CA, DATE_CA}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC2800", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            myReString = Nothing
            Return myReString
        Finally
            'Close the connection and Dispose.
            Dim ObjBC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
            Dim ObjPostbag_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
            Dim ObjBC37_DI As New QLTGND_BC37_DI(GConnectionString)
            Dim ObjPostbag_DI As New QLTGND_POSTBAG_DI(GConnectionString)
            If myReString Is Nothing Then
                MessageBox.Show("Lỗi truyền dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If WAY_TYPE = gWAY_TYPE_0 Then   'chieu di
                    ObjBC37_DI.QLTGND_BC37_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_1)
                    ObjPostbag_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_1)
                Else    'chieu den
                    ObjBC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_1)
                    ObjPostbag_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_1)
                End If
            Else
                If myReString.IndexOf("00") < 0 Then
                    MessageBox.Show("Lỗi truyền dữ liệu!!!" & vbNewLine & myReString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If WAY_TYPE = gWAY_TYPE_0 Then   'chieu di
                        ObjBC37_DI.QLTGND_BC37_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_1)
                        ObjPostbag_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_1)
                    Else    'chieu den
                        ObjBC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_1)
                        ObjPostbag_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_1)
                    End If
                Else
                    If WAY_TYPE = gWAY_TYPE_0 Then   'chieu di
                        ObjBC37_DI.QLTGND_BC37_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_2)
                        ObjPostbag_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CREATE_PO_CODE, gTrang_Thai_2)
                    Else    'chieu den
                        ObjBC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_2)
                        ObjPostbag_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Lai_Trang_Thai_Truyen(BC37_NUMBER, CONFIRM_POS_CODE, gTrang_Thai_2)
                    End If
                End If
            End If
        End Try
    End Function

#End Region

#Region "BCM1200 - Thêm thông tin Mail_Trip_Transport_PostBag"
    Public Function Them_Thong_Tin_Mail_Trip_Transport_PostBag(ByVal POST_BAG_INDEX As Integer, ByVal FROM_PO_CODE As String, ByVal TO_PO_CODE As String, ByVal MAIL_TRIP_TYPE As String, ByVal SERVICE_CODE As String, ByVal YEAR As String, ByVal MAIL_TRIP_NUMBER As String, ByVal STATUS As String, ByVal BC37_INDEX As String, ByVal BC37_FROM_PO_CODE As String, ByVal BC37_DATE As String, ByVal BC37_TO_PO_CODE As String, ByVal TRANSPORT_TYPE_ID As String, ByVal BC37_ORDER As String, ByVal CONFIRM_USER As String, ByVal CONFIRM_PO_CODE As String, ByVal CREATE_USER As String, ByVal CREATE_PO_CODE As String, ByVal CONFIRM_DATE As String, ByVal POST_BAG_NUMBER As String, ByVal BC37_NUMBER As String, ByVal TRANSPORT_NUMBER As String, ByVal WAY_TYPE As Integer, ByVal PARTNER_ID As Integer, ByVal MAIL_ROUTE_ID As Integer, ByVal ID_CA As Integer, ByVal DATE_CA As String) As String
        Dim myReString As String = ""
        DATE_CA = DATE_CA.Replace("AM", "").Replace("PM", "").Trim
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), Gid_Nguoi_Dung, myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, POST_BAG_INDEX, FROM_PO_CODE, TO_PO_CODE, MAIL_TRIP_TYPE, SERVICE_CODE, YEAR, MAIL_TRIP_NUMBER, STATUS, BC37_INDEX, BC37_FROM_PO_CODE, BC37_DATE, BC37_TO_PO_CODE, TRANSPORT_TYPE_ID, BC37_ORDER, CONFIRM_USER, CONFIRM_PO_CODE, CREATE_USER, CREATE_PO_CODE, CONFIRM_DATE, POST_BAG_NUMBER, BC37_NUMBER, TRANSPORT_NUMBER, WAY_TYPE, PARTNER_ID, MAIL_ROUTE_ID, ID_CA, DATE_CA}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BCM1200", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            myReString = Nothing
            Return myReString
        Finally
            'Close the connection and Dispose.
            If myReString Is Nothing Then
                MessageBox.Show("Lỗi truyền dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If myReString.IndexOf("00") < 0 Then
                    MessageBox.Show("Lỗi truyền dữ liệu!!!" & vbNewLine & myReString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Try
    End Function

#End Region

#Region "BCM800 - Liệt Kê thông tin BC37 theo số hiệu BC37"
    Public Function Liet_Ke_Thong_Tin_BC37_Theo_So_Hieu_BC37(ByVal BC37_ID As String, ByVal MAIL_ROUTE_ID As Integer, ByVal NUMBER_OF_BAGS_1 As Integer, ByVal NUMBER_OF_BAGS_2 As Integer) As DataTable
        'Lay BC37 theo tung BC37 ID thì truyefn vào
        'BC37_ID , MAIL_ROUTE_ID = 0, NUMBER_OF_BAGS_1 = 0 , NUMBER_OF_BAGS_2 = 0
        'Lay danh sach BC37 theo MailRoute thì truyefn vào
        'BC37_ID = "", MAIL_ROUTE_ID, NUMBER_OF_BAGS_1 = 0 , NUMBER_OF_BAGS_2 = 0
        Dim myReString As String = ""
        Dim dataTable As New dataTable("BC37_Theo_So_Hieu_BC37")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("FROM_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TO_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_TYPE_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("STATUS", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_ROUTE_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TOTAL_WEIGHT", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TOTAL_QUANTITY", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("DENIVERY", GetType(String))
        dataTable.Columns.Add(colWork)

        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, BC37_ID, MAIL_ROUTE_ID, NUMBER_OF_BAGS_1, NUMBER_OF_BAGS_2}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BCM800", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Dim strArr() As String
            Dim n As Integer = 0
            strArr = myReString.Split("|")
            If myReString.Split("|")(0) = "00" Then
                n = strArr.Length - 3
                If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For i As Integer = 3 To strArr.Length - 1
                        Try
                            'Them du lieu vao
                            Dim row As DataRow = dataTable.NewRow()
                            row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                            row("BC37_NUMBER") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                            row("FROM_PO_CODE") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                            row("TO_PO_CODE") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                            row("TRANSPORT_TYPE_CODE") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                            row("BC37_DATE") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                            row("CREATE_USER") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                            row("CREATE_PO_CODE") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                            row("STATUS") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                            row("CONFIRM_USER") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                            row("CONFIRM_DATE") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                            row("CONFIRM_PO_CODE") = IIf(strArr(i).Split("^")(12) = "", 0, strArr(i).Split("^")(12))
                            row("MAIL_ROUTE_ID") = IIf(strArr(i).Split("^")(13) = "", 0, strArr(i).Split("^")(13))
                            row("TOTAL_WEIGHT") = IIf(strArr(i).Split("^")(14) = "", 0, strArr(i).Split("^")(14))
                            row("TOTAL_QUANTITY") = IIf(strArr(i).Split("^")(15) = "", 0, strArr(i).Split("^")(15))
                            row("DENIVERY") = IIf(strArr(i).Split("^")(16) = "", 0, strArr(i).Split("^")(16))

                            dataTable.Rows.Add(row)
                        Catch ex As Exception
                            Console.Write("Record " + i.ToString + " error.")
                        End Try
                    Next
                    'MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Dim mDataResult As New dataTable
            Return mDataResult
        Finally
            'Close the connection and Dispose.
        End Try

        Return dataTable

    End Function

#End Region

#Region "BC2700 - Liệt Kê thông tin túi gói theo số hiệu BC37"
    Public Function Liet_Ke_Thong_Tin_Tui_Goi_Theo_So_Hieu_BC37(ByVal BC37_CODE As String) As DataTable
        Dim myReString As String = ""
        Dim dataTable As New dataTable("Tui_Goi_Theo_BC37")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("POST_BAG_INDEX", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("POST_BAG_TYPE", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("POST_BAG_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("FROM_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TO_PO_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_TRIP_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_TRIP_TYPE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("SERVICE_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("F", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("WEIGHT", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("STATUS", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("QUANTITY", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PACKAGING_TIME", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PACKAGING_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PACKAGING_MACHINE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("OPENING_MACHINE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("INCOMING_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CASE_WEIGHT", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_CODE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("OPENING_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("IS_DISCRETE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("IS_DELIVERY_ROUTE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("YEAR", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("OPENING_TIME", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("IS_PRINTER", GetType(String))
        dataTable.Columns.Add(colWork)

        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, BC37_CODE}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC2700", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Dim strArr() As String
            Dim n As Integer = 0
            strArr = myReString.Split("|")
            If myReString.Split("|")(0) = "00" Then
                n = strArr.Length - 3
                'If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                For i As Integer = 3 To strArr.Length - 1
                    Try
                        'Them du lieu vao
                        Dim row As DataRow = dataTable.NewRow()
                        row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                        row("POST_BAG_INDEX") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                        row("POST_BAG_TYPE") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                        row("POST_BAG_NUMBER") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                        row("FROM_PO_CODE") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                        row("TO_PO_CODE") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                        row("MAIL_TRIP_NUMBER") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                        row("MAIL_TRIP_TYPE") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                        row("SERVICE_CODE") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                        row("F") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                        row("WEIGHT") = IIf(strArr(i).Split("^")(10) = "", 0, strArr(i).Split("^")(10))
                        row("STATUS") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                        row("QUANTITY") = IIf(strArr(i).Split("^")(12) = "", 0, strArr(i).Split("^")(12))
                        row("PACKAGING_TIME") = IIf(strArr(i).Split("^")(13) = "", 0, strArr(i).Split("^")(13))
                        row("PACKAGING_USER") = IIf(strArr(i).Split("^")(14) = "", 0, strArr(i).Split("^")(14))
                        row("PACKAGING_MACHINE") = IIf(strArr(i).Split("^")(15) = "", 0, strArr(i).Split("^")(15))
                        row("OPENING_MACHINE") = IIf(strArr(i).Split("^")(16) = "", 0, strArr(i).Split("^")(16))
                        row("INCOMING_DATE") = IIf(strArr(i).Split("^")(17) = "", 0, strArr(i).Split("^")(17))
                        row("CASE_WEIGHT") = IIf(strArr(i).Split("^")(18) = "", 0, strArr(i).Split("^")(18))
                        row("BC37_CODE") = IIf(strArr(i).Split("^")(19) = "", 0, strArr(i).Split("^")(19))
                        row("BC37_DATE") = IIf(strArr(i).Split("^")(20) = "", 0, strArr(i).Split("^")(20))
                        row("OPENING_USER") = IIf(strArr(i).Split("^")(21) = "", 0, strArr(i).Split("^")(21))
                        row("IS_DISCRETE") = IIf(strArr(i).Split("^")(22) = "", 0, strArr(i).Split("^")(22))
                        row("IS_DELIVERY_ROUTE") = IIf(strArr(i).Split("^")(23) = "", 0, strArr(i).Split("^")(23))
                        row("YEAR") = IIf(strArr(i).Split("^")(24) = "", 0, strArr(i).Split("^")(24))
                        row("OPENING_TIME") = IIf(strArr(i).Split("^")(25) = "", 0, strArr(i).Split("^")(25))
                        row("IS_PRINTER") = IIf(strArr(i).Split("^")(26) = "", 0, strArr(i).Split("^")(26))
                        dataTable.Rows.Add(row)
                    Catch ex As Exception
                        Console.Write("Record " + i.ToString + " error.")
                    End Try
                Next
                'MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
            Else
                MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Dim mDataResult As New dataTable
            Return mDataResult
        Finally
            'Close the connection and Dispose.
        End Try

        Return dataTable


    End Function

#End Region

#Region "BCM1300 - Liệt Kê thông tin Mail_Trip_Transport_BC37 theo số hiệu BC37"
    Public Function Liet_Ke_Thong_Tin_Mail_Trip_Transport_BC37_Theo_So_Hieu_BC37(ByVal BC37_CODE As String, ByVal WAY_TYPE As Integer) As DataTable
        Dim myReString As String = ""
        Dim dataTable As New dataTable("Mail_Trip_Transport_BC37")
        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_FROM_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_TO_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_TYPE_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_ORDER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_TRIP_TP_FROM_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_POS_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID_CA", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("DATE_CA", GetType(String))
        dataTable.Columns.Add(colWork)

        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, BC37_CODE, WAY_TYPE}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BCM1300", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Dim strArr() As String
            Dim n As Integer = 0
            strArr = myReString.Split("|")
            If myReString.Split("|")(0) = "00" Then
                n = strArr.Length - 3
                If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For i As Integer = 3 To strArr.Length - 1
                        Try
                            'Them du lieu vao
                            Dim row As DataRow = dataTable.NewRow()
                            row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                            row("BC37_DATE") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                            row("BC37_FROM_PO_ID") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                            row("BC37_TO_PO_ID") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                            row("TRANSPORT_TYPE_ID") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                            row("BC37_ORDER") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                            row("MAIL_TRIP_TP_FROM_PO_ID") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                            row("TRANSPORT_DATE") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                            row("CONFIRM_USER") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                            row("CONFIRM_POS_ID") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                            row("CREATE_USER") = IIf(strArr(i).Split("^")(10) = "", 0, strArr(i).Split("^")(10))
                            row("CREATE_PO_ID") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                            row("CONFIRM_DATE") = IIf(strArr(i).Split("^")(12) = "", 0, strArr(i).Split("^")(12))
                            row("TRANSPORT_NUMBER") = IIf(strArr(i).Split("^")(13) = "", 0, strArr(i).Split("^")(13))
                            row("BC37_NUMBER") = IIf(strArr(i).Split("^")(14) = "", 0, strArr(i).Split("^")(14))
                            row("ID_CA") = IIf(strArr(i).Split("^")(15) = "", 0, strArr(i).Split("^")(15))
                            row("DATE_CA") = IIf(strArr(i).Split("^")(16) = "", 0, strArr(i).Split("^")(17))

                            dataTable.Rows.Add(row)

                        Catch ex As Exception
                            Console.Write("Record " + i.ToString + " error.")
                        End Try
                    Next
                    'MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.
        End Try

        Return dataTable
    End Function

#End Region

#Region "BCM1400 - Liệt Kê thông tin Mail_Trip_Transport_PostBag"
    Public Function Liet_Ke_Thong_Tin_Mail_Trip_Transport_PostBag(ByVal BC37_NUMBER As String, ByVal WAY_TYPE As Integer) As DataTable
        Dim myReString As String = ""
        Dim dataTable As New dataTable("Mail_Trip_Transport_PostBag")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("ID", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("POST_BAG_INDEX", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("FROM_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TO_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_TRIP_TYPE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("SERVICE_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("YEAR", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_TRIP_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("STATUS", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_INDEX", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_FROM_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_TO_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_TYPE_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_ORDER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_USER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CREATE_PO_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("CONFIRM_DATE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("TRANSPORT_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("BC37_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("POSTBAG_NUMBER", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("WAY_TYPE", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("PARTNER_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("MAIL_ROUTE_ID", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ID_CA", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("DATE_CA", GetType(String))
        dataTable.Columns.Add(colWork)
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password, BC37_NUMBER, WAY_TYPE}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BCM1400", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Dim strArr() As String
            Dim n As Integer = 0
            strArr = myReString.Split("|")
            If myReString.Split("|")(0) = "00" Then
                n = strArr.Length - 3
                If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For i As Integer = 3 To strArr.Length - 1
                        Try
                            'Them du lieu vao
                            Dim row As DataRow = dataTable.NewRow()
                            row("ID") = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                            row("POST_BAG_INDEX") = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                            row("FROM_PO_ID") = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                            row("TO_PO_ID") = IIf(strArr(i).Split("^")(3) = "", 0, strArr(i).Split("^")(3))
                            row("MAIL_TRIP_TYPE") = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                            row("SERVICE_ID") = IIf(strArr(i).Split("^")(5) = "", 0, strArr(i).Split("^")(5))
                            row("YEAR") = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))
                            row("MAIL_TRIP_NUMBER") = IIf(strArr(i).Split("^")(7) = "", 0, strArr(i).Split("^")(7))
                            row("STATUS") = IIf(strArr(i).Split("^")(8) = "", 0, strArr(i).Split("^")(8))
                            row("BC37_INDEX") = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))
                            row("BC37_FROM_PO_ID") = IIf(strArr(i).Split("^")(10) = "", 0, strArr(i).Split("^")(10))
                            row("BC37_DATE") = IIf(strArr(i).Split("^")(11) = "", 0, strArr(i).Split("^")(11))
                            row("BC37_TO_PO_ID") = IIf(strArr(i).Split("^")(12) = "", 0, strArr(i).Split("^")(12))
                            row("TRANSPORT_TYPE_ID") = IIf(strArr(i).Split("^")(13) = "", 0, strArr(i).Split("^")(13))
                            row("BC37_ORDER") = IIf(strArr(i).Split("^")(14) = "", 0, strArr(i).Split("^")(14))
                            row("CONFIRM_USER") = IIf(strArr(i).Split("^")(15) = "", 0, strArr(i).Split("^")(15))
                            row("CONFIRM_PO_ID") = IIf(strArr(i).Split("^")(16) = "", 0, strArr(i).Split("^")(16))
                            row("CREATE_USER") = IIf(strArr(i).Split("^")(17) = "", 0, strArr(i).Split("^")(17))
                            row("CREATE_PO_ID") = IIf(strArr(i).Split("^")(18) = "", 0, strArr(i).Split("^")(18))
                            row("CONFIRM_DATE") = IIf(strArr(i).Split("^")(19) = "", 0, strArr(i).Split("^")(19))
                            row("TRANSPORT_NUMBER") = IIf(strArr(i).Split("^")(20) = "", 0, strArr(i).Split("^")(20))
                            row("BC37_NUMBER") = IIf(strArr(i).Split("^")(21) = "", 0, strArr(i).Split("^")(21))
                            row("POSTBAG_NUMBER") = IIf(strArr(i).Split("^")(22) = "", 0, strArr(i).Split("^")(22))
                            row("WAY_TYPE") = IIf(strArr(i).Split("^")(23) = "", 0, strArr(i).Split("^")(23))
                            row("PARTNER_ID") = IIf(strArr(i).Split("^")(24) = "", 0, strArr(i).Split("^")(24))
                            row("MAIL_ROUTE_ID") = IIf(strArr(i).Split("^")(25) = "", 0, strArr(i).Split("^")(25))
                            row("ID_CA") = IIf(strArr(i).Split("^")(26) = "", 0, strArr(i).Split("^")(26))
                            row("DATE_CA") = IIf(strArr(i).Split("^")(27) = "", 0, strArr(i).Split("^")(27))

                            dataTable.Rows.Add(row)

                        Catch ex As Exception
                            Console.Write("Record " + i.ToString + " error.")
                        End Try
                    Next
                    'MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.
        End Try

        Return dataTable
    End Function

#End Region

#Region "BC4000 - Liệt kê đường thư"
    Public Function Liet_Ke_Duong_Thu() As String
        Dim myReString As String = ""
        Try
            Dim myString As String = ""
            Dim myAPI As New Api_QLTG.Service
            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), myQLTGND_APILink.QLTGND_APILink_Lay.UserName, myQLTGND_APILink.QLTGND_APILink_Lay.Password}

            ' Dim myArray() As String = {PO_CODE_ROOT, PO_WAY}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)


            myAPI.Url = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC4000", _strInput)
            myReString = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            Return myReString

        Catch ex As Exception
            ' Call the exception handler
            Console.Write(ex.ToString)
            Return Nothing
        Finally
            'Close the connection and Dispose.

        End Try
    End Function

#End Region

    Public Sub Cap_Nhat_E2_Da_In_Nhan_E4_Ma_Vach(ByVal mId_E2 As String, Optional ByRef MyBarCode As String = "", Optional ByRef MyBarCode_With_Space As String = "")
        Try
            Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
            Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
            Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
            Dim mQLTGND_E2_Di_Chi_Tiet As New QLTGND_E2_Di_Chi_Tiet
            Dim myE2_Di As New E2_Di(GConnectionString)
            Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
            Dim myHam_Dung_Chung As New Ham_Dung_Chung

            'Truyen vao bien
            myE2_Di_Chi_Tiet = myE2_Di.Lay(mId_E2)
            If myE2_Di_Chi_Tiet.Tong_So_BP > 0 Then
                Dim Loai_Tui As Boolean = False
                'If myE2_Di_Chi_Tiet.Tui_F = True Then
                '    Tui_F = True
                'Else
                '    Tui_F = False
                'End If
                'If myE2_Di_Chi_Tiet.Tui_F = True Then
                '    Loai_Tui = True
                'Else
                '    Loai_Tui = False
                'End If
                'Dim MyBarCode, MyBarCode_With_Space As String
                myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu)
                myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Chuyen_Thu)
                'Dim mye4code As New DycryptBarCode.e4code(myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                '    myDuong_Thu_Di_Chi_Tiet.Ma_Bc.ToString, _
                '    GLoai_Chuyen_Thu, _
                '    GLoai_Dich_Vu, _
                '    myE2_Di_Chi_Tiet.Ngay_Dong.ToString("00000000").Substring(3, 1), _
                '    Right("0000" + myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu.ToString, 4), _
                '    Right("000" + myE2_Di_Chi_Tiet.Tui_So.ToString, 3), _
                '    myE2_Di_Chi_Tiet.Tui_F, _
                '    Loai_Tui, _
                '    myE2_Di_Chi_Tiet.Khoi_Luong_BP + myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui)
                'MyBarCode = mye4code.GeneralE4Code()
                'MyBarCode_With_Space = mye4code.GeneralE4Code_With_Space()

                MyBarCode = myE2_Di.GeneralE4Code(myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                    myDuong_Thu_Di_Chi_Tiet.Ma_Bc, _
                    GLoai_Chuyen_Thu, _
                    GLoai_Dich_Vu, _
                    myE2_Di_Chi_Tiet.Ngay_Dong, _
                    myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                    myE2_Di_Chi_Tiet.Tui_So, _
                    IIf(myE2_Di_Chi_Tiet.Tui_F = True, 1, 0), _
                    myE2_Di_Chi_Tiet.Khoi_Luong_BP + myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui)

                MyBarCode_With_Space = MyBarCode

                mQLTGND_E2_Di_Chi_Tiet.Id_E2 = mId_E2
                mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan = ""
                'mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2(mId_E2)
                mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu = MyBarCode
                mQLTGND_E2_Di_Chi_Tiet.STT = 0
                mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac = 0
                mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat = 0    'cập nhật trạng thái đã in nhãn
                mQLTGND_E2_Di_Chi_Tiet.Chot_SL = 0
                mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong = myHam_Dung_Chung.ConvertTimeToInt(Now.Date())
                myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu)
                myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Chuyen_Thu)

                'Cap nhat vao bang QLTGND_E2_Di
                myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Them(mQLTGND_E2_Di_Chi_Tiet.Id_E2, mQLTGND_E2_Di_Chi_Tiet.Id_Giao_Nhan, mQLTGND_E2_Di_Chi_Tiet.Id_Tui_Thu, mQLTGND_E2_Di_Chi_Tiet.STT, mQLTGND_E2_Di_Chi_Tiet.Truyen_Khai_Thac, mQLTGND_E2_Di_Chi_Tiet.Truyen_Doi_Soat, mQLTGND_E2_Di_Chi_Tiet.Chot_SL, mQLTGND_E2_Di_Chi_Tiet.Ngay_He_Thong, mQLTGND_E2_Di_Chi_Tiet.Gio_He_Thong)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


#End Region
#Region "------------Tạo BC37 Id------------"
    Public Function Create_BC37_ID(ByVal Ma_Bc_Goc As Integer, ByVal Ma_Bc_Dich As Integer, ByVal Ngay_Dong As Integer, ByVal Dot_Giao As Integer)
        Return Ma_Bc_Goc.ToString & Ma_Bc_Dich.ToString & Ham_Dung_Chung.ConvertDateIntToInt_VNPOST(Ngay_Dong).ToString & CStr(Dot_Giao)
    End Function
#End Region

#Region "Tao_Bang_Trang_Thai_BC37_Den_Tai_Client"
    Public Function Tao_Bang_Trang_Thai_BC37_Den_Tai_Client() As DataTable
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Trang_Thai")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Id_Trang_Thai", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Trang_Thai", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Id_Trang_Thai") = 0
            row("Ten_Trang_Thai") = "Chưa XN đến"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Id_Trang_Thai") = 1
            row("Ten_Trang_Thai") = "Đang XN đến"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Id_Trang_Thai") = 2
            row("Ten_Trang_Thai") = "Đã hoàn tất"
            dataTable.Rows.Add(row)

            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Tao_Bang_Trang_Thai_BC37_Di_Tai_Client"
    Public Function Tao_Bang_Trang_Thai_BC37_Di_Tai_Client() As DataTable
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Trang_Thai")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Id_Trang_Thai", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Trang_Thai", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Id_Trang_Thai") = 0
            row("Ten_Trang_Thai") = "Chưa XN đi"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Id_Trang_Thai") = 1
            row("Ten_Trang_Thai") = "Đang XN đi"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Id_Trang_Thai") = 2
            row("Ten_Trang_Thai") = "Đã hoàn tất"
            dataTable.Rows.Add(row)

            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#Region "------------In_Nhan_E4_New------------"
    Public Sub In_Nhan_E4_New(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Kho_Giay As String)
        Dim May_In_Nhan_E4 As String = ""
        Dim mytable As New DataTable
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptNhan_E4_New As New rptNhan_E4_New

        'Kiem tra may in va kho giay
        Dim myKey As New ModifyRegistry
        Dim i As Integer
        Dim rawKind As Integer = 0
        May_In_Nhan_E4 = GTen_May_In_E4_New
        If May_In_Nhan_E4.Trim = "" Then
            MessageBox.Show("Lỗi không thiết lập máy in E4", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Kho_Giay.Trim = "" Then
            MessageBox.Show("Lỗi không thiết lập khổ giấy!!!", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim printDoc As New System.Drawing.Printing.PrintDocument
        printDoc.PrinterSettings.PrinterName = May_In_Nhan_E4
        For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
            If printDoc.PrinterSettings.PaperSizes(i).PaperName = Kho_Giay Then
                rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
            End If
        Next
        If rawKind = 0 Then
            MessageBox.Show("Lỗi không có khổ giấy E4 (Name:Ems_E4-Width:7.70cm(3.03inch)-Height:12.70cm (5inch))" & vbNewLine & "Bạn vào Start/Setting/Printer and Fax. Chọn máy in nhãn, click chuột phải, chọn Properties. Click nút Printing Preferences và New khổ giấy mới theo thông tin như trên", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '-----------------------------

        mytable = myE2_Di.E2_Di_In_Nhan_E4(Id_E2).Tables(0)
        If mytable.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu in nhãn E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '*** -----Tui_F
        Dim F As String = IIf(mytable.Rows(0).Item("Tui_F") = "10", "F", "")
        'Dim F = "F"
        '*** -----FROM (TEN BC GUI)
        Dim Ten_Bc_Gui As String = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Gui"))
        'Dim Ten_Bc_Gui = "HN EMS QT"
        '*** -----MAIL No
        Dim So_Chuyen_Thu As String = CStr(mytable.Rows(0).Item("So_Chuyen_Thu"))
        'Dim So_Chuyen_Thu = "122"
        '*** -----DATE OF DISPATCH
        Dim ngay_dong As Date = CDate(mytable.Rows(0).Item("Ngay_Dong"))
        'Dim ngay_dong = "12/09/2008"
        '*** -----REC No
        Dim RecNo As String = CStr(mytable.Rows(0).Item("RecNo"))
        'Dim RecNo = "001/ED"
        '*** -----NUMBER OF ITEMS
        Dim Tong_So_BP As String = Right("000" & CStr(mytable.Rows(0).Item("Tong_So_BP")), 3)
        'Dim Tui_So = "001"
        '*** -----Kg
        Dim Khoi_Luong As Double = Round(mytable.Rows(0).Item("Khoi_Luong") / 1000 + 0.001, 2)
        'Dim Khoi_Luong As Double = 0.3
        '*** -----To (TEN BUU CUC NHAN)
        Dim Ten_Bc_Nhan As String = CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Nhan"))
        '*** -----Bat dau xu ly BarCode
        'Khai bao bien tam        
        Dim MyBarCode, MyBarCode_With_Space As String
        Dim Khoi_Luong_1 As Integer = Round(mytable.Rows(0).Item("Khoi_Luong") / 100, 0)
        'MyBarCode = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " " & CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " " & mytable.Rows(0).Item("Loai_Chuyen_Thu") & " " & mytable.Rows(0).Item("Loai_Dich_Vu") & " " & Mid(CStr(Year(mytable.Rows(0).Item("Ngay_Dong"))), 4, 1) & " " & Right("0000" + CStr(mytable.Rows(0).Item("So_Chuyen_Thu")), 4) & " " & Right("000" + CStr(mytable.Rows(0).Item("Tui_So")), 3) & " " & mytable.Rows(0).Item("Tui_F") & " " & Right("0000" & CStr(Khoi_Luong_1), 4)

        Dim Tui_F, Loai_Tui As Boolean
        If Convert.ToString(mytable.Rows(0).Item("Tui_F")).Substring(0, 1) = "1" Then
            Tui_F = True
        Else
            Tui_F = False
        End If
        If Convert.ToString(mytable.Rows(0).Item("Tui_F")).Substring(1, 1) = "1" Then
            Loai_Tui = True
        Else
            Loai_Tui = False
        End If

        'Bỏ
        'Dim mye4code As New DycryptBarCode.e4code(CStr(mytable.Rows(0).Item("Ma_Bc_Gui")), CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")), GLoai_Chuyen_Thu, GLoai_Dich_Vu, Mid(CStr(Year(mytable.Rows(0).Item("Ngay_Dong"))), 4, 1), Right("0000" + CStr(mytable.Rows(0).Item("So_Chuyen_Thu")), 4), Right("000" + CStr(mytable.Rows(0).Item("Tui_So")), 3), Tui_F, Loai_Tui, mytable.Rows(0).Item("Khoi_Luong"))

        'MyBarCode = mye4code.GeneralE4Code()
        'MyBarCode_With_Space = mye4code.GeneralE4Code_With_Space()      

        Cap_Nhat_E2_Da_In_Nhan_E4_Ma_Vach(Id_E2, MyBarCode, MyBarCode_With_Space)

        p_thamso.Value = Ten_Bc_Gui
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Gui").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Ten_Bc_Nhan
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = So_Chuyen_Thu
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pSo_Chuyen_Thu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = ngay_dong
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pNgay_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Convert.ToInt32(RecNo)
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_So").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Convert.ToInt32(Tong_So_BP)
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTong_So_BP").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Khoi_Luong
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pKhoi_Luong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = F
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_F").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = MyBarCode_With_Space
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach_Chu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = MyBarCode
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        'Dim mTemp As New myBarcode128


        'Dim mBarcode128Data As String = MyBarCode.Replace(" ", "")
        'Dim myBarcodeFactory As New Lesnikowski.Barcode.BarcodeFactory
        'Dim myBarcode128EAN As Lesnikowski.Barcode.IBaseBarcode
        'myBarcode128EAN = myBarcodeFactory.CreateBarcode(Symbology.Code128)
        'myBarcode128EAN.Number = mBarcode128Data
        'myBarcode128EAN.Save(Application.StartupPath & "\code128temp.prg", ImageType.Png)

        rptNhan_E4_New.PrintOptions.PrinterName = May_In_Nhan_E4
        rptNhan_E4_New.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
        'rptNhan_E4_New.PrintToPrinter(0, True, 0, 0)

        FrmView.CrystalReportViewer1.ReportSource = rptNhan_E4_New
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptNhan_E4_New.PrintToPrinter(1, True, 0, 0)
        End If

        'Cap nhat da in
        Dim myQLTGND_E2_Di As New QLTGND_E2_Di(GConnectionString)
        myQLTGND_E2_Di.QLTGND_E2_Di_Cap_Nhat_Trang_Thai_Da_In_Nhan_E4_Vao_Truyen_Doi_Soat(Id_E2)

    End Sub

    Public Sub In_Nhan_E4_Den_New(ByVal Id_E2 As String, ByVal Preview As Boolean, ByVal Kho_Giay As String)
        Dim May_In_Nhan_E4 As String = ""
        Dim mytable As New DataTable
        Dim myE2_Den As New E2_Den(GConnectionString)
        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptNhan_E4_New As New rptNhan_E4_New

        'Kiem tra may in va kho giay
        Dim myKey As New ModifyRegistry
        Dim i As Integer
        Dim rawKind As Integer = 0
        May_In_Nhan_E4 = IIf(myKey.Doc("mayine4") Is Nothing Or myKey.Doc("mayine4") = "", "", myKey.Doc("mayine4"))
        If May_In_Nhan_E4.Trim = "" Then
            MessageBox.Show("Lỗi không thiết lập máy in E4", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Kho_Giay.Trim = "" Then
            MessageBox.Show("Lỗi không thiết lập khổ giấy!!!", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim printDoc As New System.Drawing.Printing.PrintDocument
        printDoc.PrinterSettings.PrinterName = May_In_Nhan_E4
        For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
            If printDoc.PrinterSettings.PaperSizes(i).PaperName = Kho_Giay Then
                rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
            End If
        Next
        If rawKind = 0 Then
            MessageBox.Show("Lỗi không có khổ giấy E4 (Name:Ems_E4-Width:7.70cm(3.03inch)-Height:12.70cm (5inch))" & vbNewLine & "Bạn vào Start/Setting/Printer and Fax. Chọn máy in nhãn, click chuột phải, chọn Properties. Click nút Printing Preferences và New khổ giấy mới theo thông tin như trên", "Lỗi thiết lập in E4", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '-----------------------------

        mytable = myE2_Den.E2_Den_In_Nhan_E4(Id_E2).Tables(0)
        If mytable.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu in nhãn E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        '*** -----Tui_F
        Dim F As String = IIf(mytable.Rows(0).Item("Tui_F") = "10", "F", "")
        'Dim F = "F"
        '*** -----FROM (TEN BC GUI)
        Dim Ten_Bc_Gui As String = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Gui"))
        'Dim Ten_Bc_Gui = "HN EMS QT"
        '*** -----MAIL No
        Dim So_Chuyen_Thu As String = CStr(mytable.Rows(0).Item("So_Chuyen_Thu"))
        'Dim So_Chuyen_Thu = "122"
        '*** -----DATE OF DISPATCH
        Dim ngay_dong As Date = CDate(mytable.Rows(0).Item("Ngay_Dong"))
        'Dim ngay_dong = "12/09/2008"
        '*** -----REC No
        Dim RecNo As String = CStr(mytable.Rows(0).Item("RecNo"))
        'Dim RecNo = "001/ED"
        '*** -----NUMBER OF ITEMS
        Dim Tong_So_BP As String = Right("000" & CStr(mytable.Rows(0).Item("Tong_So_BP")), 3)
        'Dim Tui_So = "001"
        '*** -----Kg
        Dim Khoi_Luong As Double = Round(mytable.Rows(0).Item("Khoi_Luong") / 1000 + 0.001, 2)
        'Dim Khoi_Luong As Double = 0.3
        '*** -----To (TEN BUU CUC NHAN)
        Dim Ten_Bc_Nhan As String = CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " - " & CStr(mytable.Rows(0).Item("Ten_Bc_Nhan"))
        '*** -----Bat dau xu ly BarCode
        'Khai bao bien tam        
        Dim MyBarCode, MyBarCode_With_Space As String
        Dim Khoi_Luong_1 As Integer = Round(mytable.Rows(0).Item("Khoi_Luong") / 100, 0)
        'MyBarCode = CStr(mytable.Rows(0).Item("Ma_Bc_Gui")) & " " & CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")) & " " & mytable.Rows(0).Item("Loai_Chuyen_Thu") & " " & mytable.Rows(0).Item("Loai_Dich_Vu") & " " & Mid(CStr(Year(mytable.Rows(0).Item("Ngay_Dong"))), 4, 1) & " " & Right("0000" + CStr(mytable.Rows(0).Item("So_Chuyen_Thu")), 4) & " " & Right("000" + CStr(mytable.Rows(0).Item("Tui_So")), 3) & " " & mytable.Rows(0).Item("Tui_F") & " " & Right("0000" & CStr(Khoi_Luong_1), 4)

        Dim Tui_F, Loai_Tui As Boolean
        If Convert.ToString(mytable.Rows(0).Item("Tui_F")).Substring(0, 1) = "1" Then
            Tui_F = True
        Else
            Tui_F = False
        End If
        If Convert.ToString(mytable.Rows(0).Item("Tui_F")).Substring(1, 1) = "1" Then
            Loai_Tui = True
        Else
            Loai_Tui = False
        End If

        'Dim mye4code As New DycryptBarCode.e4code(CStr(mytable.Rows(0).Item("Ma_Bc_Gui")), CStr(mytable.Rows(0).Item("Ma_Bc_Nhan")), GLoai_Chuyen_Thu, GLoai_Dich_Vu, Mid(CStr(Year(mytable.Rows(0).Item("Ngay_Dong"))), 4, 1), Right("0000" + CStr(mytable.Rows(0).Item("So_Chuyen_Thu")), 4), Right("000" + CStr(mytable.Rows(0).Item("Tui_So")), 3), Tui_F, Loai_Tui, mytable.Rows(0).Item("Khoi_Luong"))

        'MyBarCode = mye4code.GeneralE4Code()
        'MyBarCode_With_Space = mye4code.GeneralE4Code_With_Space()


        MyBarCode = myE2_Di.GeneralE4Code(CInt(mytable.Rows(0).Item("Ma_Bc_Gui")), _
                    CInt(mytable.Rows(0).Item("Ma_Bc_Nhan")), _
                    GLoai_Chuyen_Thu, _
                    GLoai_Dich_Vu, _
                    CInt(mytable.Rows(0).Item("Ngay_Dong")), _
                    CInt(mytable.Rows(0).Item("So_Chuyen_Thu")), _
                    CInt(mytable.Rows(0).Item("Tui_So")), _
                    IIf(Tui_F = True, 1, 0), _
                    CInt(mytable.Rows(0).Item("Khoi_Luong")))

        MyBarCode_With_Space = MyBarCode

        p_thamso.Value = Ten_Bc_Gui
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Gui").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Ten_Bc_Nhan
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTen_Bc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = So_Chuyen_Thu
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pSo_Chuyen_Thu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = ngay_dong
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pNgay_Dong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Convert.ToInt32(RecNo)
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_So").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Convert.ToInt32(Tong_So_BP)
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTong_So_BP").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = Khoi_Luong
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pKhoi_Luong").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = F
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pTui_F").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = MyBarCode_With_Space
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach_Chu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = MyBarCode
        pvcollection.Add(p_thamso)
        rptNhan_E4_New.DataDefinition.ParameterFields("pMa_Vach").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        'Dim mTemp As New myBarcode128


        'Dim mBarcode128Data As String = MyBarCode.Replace(" ", "")
        'Dim myBarcodeFactory As New Lesnikowski.Barcode.BarcodeFactory
        'Dim myBarcode128EAN As Lesnikowski.Barcode.IBaseBarcode
        'myBarcode128EAN = myBarcodeFactory.CreateBarcode(Symbology.Code128)
        'myBarcode128EAN.Number = mBarcode128Data
        'myBarcode128EAN.Save(Application.StartupPath & "\code128temp.prg", ImageType.Png)
        FrmView.CrystalReportViewer1.ReportSource = rptNhan_E4_New
        Cursor.Current = Cursors.Default
        If Preview = True Then
            FrmView.ShowDialog()
        Else
            rptNhan_E4_New.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region
    '''CuongNV'''
#Region "Ẩn hiện các cột không cần thiết trong danh mục khi load ra combo"
    Public Sub ValidCombo(ByRef myUltraCombo As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal dtSource As DataTable, ByVal sNameColumn As String(), ByVal sCaptionColumn As String(), ByVal sDisplaymem As String, ByVal sValumem As String)
        myUltraCombo.DataSource = dtSource
        myUltraCombo.DisplayMember = sDisplaymem
        myUltraCombo.ValueMember = sValumem
        'ẩn hiện các cột không cần thiết
        For i As Integer = 0 To myUltraCombo.DisplayLayout.Bands(0).Columns.Count - 1
            For j As Integer = 0 To sNameColumn.Length - 1
                If (myUltraCombo.DisplayLayout.Bands(0).Columns(i).Key = sNameColumn(j)) Then
                    myUltraCombo.DisplayLayout.Bands(0).Columns(i).Hidden = False
                    myUltraCombo.DisplayLayout.Bands(0).Columns(i).Header.Caption = sCaptionColumn(j)
                    Exit For
                Else
                    myUltraCombo.DisplayLayout.Bands(0).Columns(i).Hidden = True
                End If
            Next
        Next
    End Sub
#End Region

#Region "Kiem_Tra_Qua_Giang"
    Public Function Kiem_Tra_Qua_Giang(ByVal Ma_Bc_Dich As Integer, ByVal Ma_Bc_Khai_Thac As Integer) As Boolean
        If Ma_Bc_Dich <> Ma_Bc_Khai_Thac Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Tao_Bang_Chua_BC37_Da_Chon"
    Public Function Tao_Bang_Chua_BC37_Da_Chon() As DataTable
        Try
            Dim dataTable As New dataTable("BC37")
            Dim colWork As DataColumn = New DataColumn("BC37_ID", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("TRANSPORT_TYPE", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("MAIL_ROUTE_ID", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("PARTNER_ID", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Dot_Giao", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("TRANSPORT_NUMBER", GetType(String))
            dataTable.Columns.Add(colWork)
            Return dataTable
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim mdatatable As New dataTable
            Return mdatatable
        End Try
    End Function
#End Region

#Region "------------Ban_Ke_BC37_Di_Tong_Hop------------"
    Public Sub Ban_Ke_BC37_Di_Tong_Hop(ByVal BC37_ID As String, ByVal Preview As Boolean, ByVal So_Ban As Integer)
        Dim myQLTGND_POSTBAG_DI As New QLTGND_POSTBAG_DI(GConnectionString)
        Dim myQLTGND_POSTBAG_DI_Chi_Tiet As New QLTGND_POSTBAG_DI_Chi_Tiet
        Dim myQLTGND_BC37_DI As New QLTGND_BC37_DI(GConnectionString)
        Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myDanh_Muc_BC_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
        Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
        Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
        Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
        Dim myQLTGND_TRANSPORT_TYPE As New QLTGND_TRANSPORT_TYPE(GConnectionString)
        Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

        If BC37_ID.Length = 0 Then
            Exit Sub
        End If
        Dim myHam_Dung_Chung As New Ham_Dung_Chung
        Dim m_Data As New DataSet
        Dim myTable As New DataTable
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptBC37TongHop As New rptBC37_QLTG_NoGroup
        Dim mStatus As Integer
        myTable = myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Ban_Ke_BC37(BC37_ID, 0, GBuu_Cuc_Khai_Thac).Tables(0)
        If myTable.Rows.Count = 0 Then
            Exit Sub
        End If
        myQLTGND_BC37_DI_Chi_Tiet = myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac)
        myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(myQLTGND_BC37_DI_Chi_Tiet.MAIL_ROUTE_ID)

        'Paramete
        p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac).Ten_Buu_Cuc & "/" & myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pBuu_Cuc_Giao").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc).Ten_Buu_Cuc & "/" & myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pBuu_Cuc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        'p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac).Ten_Buu_Cuc & " - " & myDanh_Muc_BC.Lay(myDuong_Thu_Di.Lay(myQLTGND_BC37_DI_Chi_Tiet.Id_Duong_Thu).Ma_Bc).Ten_Buu_Cuc
        p_thamso.Value = myQLTGND_TUYEN_VC_Chi_Tiet.Ten_Tuyen
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pDuong_Thu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myHam_Dung_Chung.ConvertIntToVNDateType(myQLTGND_BC37_DI_Chi_Tiet.Ngay_Lap)
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Lap").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myQLTGND_BC37_DI_Chi_Tiet.Dot_Giao
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pChuyen").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()
        If myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID = "" Then
            p_thamso.Value = ""
        Else
            p_thamso.Value = myQLTGND_TRANSPORT_TYPE.QLTGND_TRANSPORT_TYPE_Lay(myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID).NAME.ToString & " / " & myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID.ToString  'Loai_Phuong_Tien
        End If
        'p_thamso.Value = myQLTGND_TRANSPORT_TYPE.QLTGND_TRANSPORT_TYPE_Lay(myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID).NAME.ToString & " / " & myQLTGND_BC37_DI_Chi_Tiet.TRANSPORT_TYPE_ID.ToString  'Loai_Phuong_Tien
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pPTVC").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myHam_Dung_Chung.ConvertIntToDate_VN(myQLTGND_BC37_DI_Chi_Tiet.Ngay_Giao)
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Gio_Giao").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = "Ngày giờ thực nhận: ................."
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Gio_Thuc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myQLTGND_BC37_DI_Chi_Tiet.BC37_ID.ToString 'Id_Giao_Nhan.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pMa_Vach").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        'Đặt Tên Table cho phù hợp
        'm_Data.Tables(0).TableName = "BC37_Tong_Hop"
        'Gán DataSource cho report
        rptBC37TongHop.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptBC37TongHop
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem trên màn hình
            FrmView.ShowDialog()
        Else
            'Đưa ra máy in
            rptBC37TongHop.PrintToPrinter(So_Ban, True, 0, 0)
        End If

    End Sub
#End Region

#Region "------------Ban_Ke_BC37_Den_Tong_Hop------------"
    Public Sub Ban_Ke_BC37_Den_Tong_Hop(ByVal BC37_ID As String, ByVal Preview As Boolean, ByVal So_Ban As Integer)
        Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
        Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
        Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
        Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myDanh_Muc_BC_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
        Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
        Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
        Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
        Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
        Dim myQLTGND_TRANSPORT_TYPE As New QLTGND_TRANSPORT_TYPE(GConnectionString)
        Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet
        If BC37_ID.Length = 0 Then
            Exit Sub
        End If
        Dim myHam_Dung_Chung As New Ham_Dung_Chung
        Dim m_Data As New DataSet
        Dim myTable As New DataTable
        Dim pvcollection As New ParameterValues
        Dim p_thamso As New ParameterDiscreteValue

        Dim FrmView As New FrmViewReports
        Dim rptBC37TongHop As New rptBC37_QLTG_NoGroup
        Dim mStatus As Integer
        myTable = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Ban_Ke_BC37(BC37_ID, 0, GBuu_Cuc_Khai_Thac).Tables(0)
        If myTable.Rows.Count = 0 Then
            Exit Sub
        End If
        myQLTGND_BC37_DEN_Chi_Tiet = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Lay(BC37_ID, GBuu_Cuc_Khai_Thac)
        myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID)

        'Paramete
        p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc).Ten_Buu_Cuc & "/" & myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pBuu_Cuc_Giao").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac).Ten_Buu_Cuc & "/" & myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pBuu_Cuc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myDanh_Muc_BC.Lay(myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc).Ten_Buu_Cuc & " - " & myDanh_Muc_BC.Lay(myDuong_Thu_Den.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu).Ma_Bc_Khai_Thac).Ten_Buu_Cuc
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pDuong_Thu").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myHam_Dung_Chung.ConvertIntToVNDateType(myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap)
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Lap").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pChuyen").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myQLTGND_TRANSPORT_TYPE.QLTGND_TRANSPORT_TYPE_Lay(myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID).NAME.ToString & " / " & myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID.ToString 'Loai_Phuong_Tien
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pPTVC").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myHam_Dung_Chung.ConvertIntToDate_VN(myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao)
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Gio_Giao").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = "Ngày giờ thực nhận: ................."
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pNgay_Gio_Thuc_Nhan").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        p_thamso.Value = myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID.ToString 'Id_Giao_Nhan.ToString
        pvcollection.Add(p_thamso)
        rptBC37TongHop.DataDefinition.ParameterFields("pMa_Vach").ApplyCurrentValues(pvcollection)
        pvcollection.Clear()

        'Đặt Tên Table cho phù hợp
        'm_Data.Tables(0).TableName = "BC37_Tong_Hop"
        'Gán DataSource cho report
        rptBC37TongHop.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = rptBC37TongHop
        Cursor.Current = Cursors.Default
        If Preview = True Then
            'Xem trên màn hình
            FrmView.ShowDialog()
        Else
            'Đưa ra máy in
            rptBC37TongHop.PrintToPrinter(So_Ban, True, 0, 0)
        End If

    End Sub
#End Region
#Region "Kiem tra tui goi hop le voi BC37 "
    Public Function CheckBC37PostBag(ByVal str As String(), ByVal ma_bc_nhan As String) As String
        Dim strResult As String = ""
        For i As Integer = 0 To str.Length - 1
            If (str(i).Substring(6, 6) = ma_bc_nhan) Then
                strResult = str(i)
                Exit For
            End If
        Next
        Return strResult
    End Function
#End Region
    Public Sub Tao_BC37_Thiet_Lap_E2_Di(ByVal Id_Chuyen_Thu)
        Dim myQLTGND_BC37_DI As New QLTGND_BC37_DI(GConnectionString)
        Dim mQLTGND_BC37_Di_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet

        Dim myQLTGND_POSTBAG_DI As New QLTGND_POSTBAG_DI(GConnectionString)

        Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
        Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)

        Dim myE2_Di As New E2_Di(GConnectionString)
        Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet

        Dim BC37_ID As String
        Dim myDot_Giao As Integer
        Dim Ma_Bc_Khai_Thac As Integer
        Dim Ma_Bc As Integer
        Dim Ngay As Integer
        Try

            myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Lay(Id_Chuyen_Thu)
            If (myDuong_Thu_Di.Lay(myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu).Id_Phan_Loai <> 2) Then
                Exit Sub
            End If
            Ma_Bc_Khai_Thac = myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac
            Ma_Bc = myDuong_Thu_Di.Lay(myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu).Ma_Bc
            Ngay = myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong
            myDot_Giao = myQLTGND_BC37_DI.Lay_Dot_Giao_Tu_Dong(myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, Ngay)
            BC37_ID = QLTGND_Common.Create_BC37_ID(Ma_Bc_Khai_Thac, Ma_Bc, Ngay, myDot_Giao)
            mQLTGND_BC37_Di_Chi_Tiet = myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac)

            'Kiểm tra chuyến thư đã lập BC37
            Dim myBC37_ID_Old As String
            myBC37_ID_Old = myQLTGND_BC37_DI.Kiem_Tra_Chuyen_Thu_Da_Lap_BC37(Ngay, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu)
            If myBC37_ID_Old.Length <> 0 Then
                BC37_ID = myBC37_ID_Old
            End If

            myQLTGND_BC37_DI.QLTGND_BC37_DI_Cap_Nhat_Them(BC37_ID, _
                myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, _
                myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                Ma_Bc_Khai_Thac, _
                Ma_Bc, _
                Ngay, _
                Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                myDot_Giao, _
                Ngay, _
                Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                Gid_Nguoi_Dung, _
                Ham_Dung_Chung.ConvertDateToInt(Date.Now), _
                Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                False, _
                False, _
                0, _
                0, _
                "", _
                "", _
                "", _
                0, _
                False)


            If myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, Ma_Bc_Khai_Thac).Trang_Thai = 2 Then
                CMessageBox.Show("Số hiệu BC37 đã được tạo trước đó và đã truyền lên HOST, bạn không được phép ghép túi nữa...", "Thông báo")
                Exit Sub
            End If
            Dim myData_E2 As New DataTable
            myData_E2 = myE2_Di.QLTGND_Danh_Sach_Lay_Boi_Id_Chuyen_Thu(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu).Tables(0)
            Dim i As Integer
            For i = 0 To myData_E2.Rows.Count - 1
                With myE2_Di_Chi_Tiet
                    .Chot_SL = CBool(myData_E2.Rows(i).Item("Chot_SL"))
                    .Gio_Dong = CInt(myData_E2.Rows(i).Item("Gio_Dong"))
                    .Gio_Nhan = CInt(myData_E2.Rows(i).Item("Gio_Nhan"))
                    .HH_Phat_Hanh = CInt(myData_E2.Rows(i).Item("HH_Phat_Hanh"))
                    .HH_Phat_Tra = CInt(myData_E2.Rows(i).Item("HH_Phat_Tra"))
                    .Id_Ca = CStr(myData_E2.Rows(i).Item("Id_Ca"))
                    .Id_Chuyen_Thu = CStr(myData_E2.Rows(i).Item("Id_Chuyen_Thu"))
                    .Id_Duong_Thu = CStr(myData_E2.Rows(i).Item("Id_Duong_Thu"))
                    .Id_E2 = CStr(myData_E2.Rows(i).Item("Id_E2"))
                    .Khoi_Luong_BP = CInt(myData_E2.Rows(i).Item("Khoi_Luong_BP"))
                    .Khoi_Luong_Vo_Tui = CInt(myData_E2.Rows(i).Item("Khoi_Luong_Vo_Tui"))
                    .Ma_Bc_Khai_Thac = CInt(myData_E2.Rows(i).Item("Ma_Bc_Khai_Thac"))
                    .Ngay_Dong = CInt(myData_E2.Rows(i).Item("Ngay_Dong"))
                    .Ngay_He_Thong = CInt(myData_E2.Rows(i).Item("Ngay_He_Thong"))
                    .Ngay_Nhan = CInt(myData_E2.Rows(i).Item("Ngay_Nhan"))
                    .Tong_Cuoc_Chinh = CInt(myData_E2.Rows(i).Item("Tong_Cuoc_Chinh"))
                    .Tong_Cuoc_COD = CInt(myData_E2.Rows(i).Item("Tong_Cuoc_COD"))
                    .Tong_Cuoc_DV = CInt(myData_E2.Rows(i).Item("Tong_Cuoc_DV"))
                    .Tong_So_BP = CInt(myData_E2.Rows(i).Item("Tong_So_BP"))
                    .Truyen_Doi_Soat = CBool(myData_E2.Rows(i).Item("Truyen_Doi_Soat"))
                    .Truyen_Khai_Thac = CBool(myData_E2.Rows(i).Item("Truyen_Khai_Thac"))
                    .Tui_F = CBool(myData_E2.Rows(i).Item("Tui_F"))
                    .Tui_So = CInt(myData_E2.Rows(i).Item("Tui_So"))
                End With
                'cẬP NHẬT THÊM
                Dim myId_Tui_Thu As String

                'myId_Tui_Thu = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2_New(myE2_Di_Chi_Tiet.Id_E2, _
                '    myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu).Ma_Bc, _
                '    myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                '    myE2_Di_Chi_Tiet.Ngay_Dong, _
                '    mySo_Chuyen_Thu, _
                '    myE2_Di_Chi_Tiet.Tui_So, _
                '    myE2_Di_Chi_Tiet.Tui_So, _
                '    myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                '    myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui)
                Dim myqltgnd_E2_Di As New QLTGND_E2_Di(GConnectionString)
                myId_Tui_Thu = myqltgnd_E2_Di.QLTGND_E2_Di_Lay(myE2_Di_Chi_Tiet.Id_E2).Id_Tui_Thu
                If myE2_Di_Chi_Tiet.Tong_So_BP <> 0 Then
                    Dim myMa_Bc As Integer = myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu).Ma_Bc
                    myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Them(myE2_Di_Chi_Tiet.Id_E2, _
                        myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                        myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                        myE2_Di_Chi_Tiet.Id_Ca, _
                        myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                        myMa_Bc, _
                        myE2_Di_Chi_Tiet.Ngay_Dong, _
                        myE2_Di_Chi_Tiet.Gio_Dong, _
                        myE2_Di_Chi_Tiet.Ngay_Nhan, _
                        myE2_Di_Chi_Tiet.Gio_Nhan, _
                        myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                        myE2_Di_Chi_Tiet.Tui_So, _
                        myE2_Di_Chi_Tiet.Tui_F, _
                        myE2_Di_Chi_Tiet.Tong_So_BP, _
                        myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                        myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                        myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                        myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                        myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                        myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                        myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                        myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                        myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                        myE2_Di_Chi_Tiet.Ngay_He_Thong, _
                        myE2_Di_Chi_Tiet.Chot_SL, _
                        myId_Tui_Thu, _
                        BC37_ID, _
                        0, _
                        False)
                Else
                    CMessageBox.Show("Túi số : " & myE2_Di_Chi_Tiet.Tui_So.ToString & _
                                    " có người khác đang mở, hoặc túi này đang bị lỗi, vì tổng số bưu phẩm = 0" & vbNewLine & _
                                    "Cách khắc phục : Mở túi đó ra xem, nếu túi lỗi, vào chức năng sửa chữa E2 đi để sửa bản kê E2 lỗi nhé." & vbNewLine & _
                                    "xin hãy kiểm tra lại", "Thông báo")
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub
End Module

Imports System.Net.Dns
Imports System.Collections
Imports Ems_International_Logic.EMS

Public Class FrmHuongDanSuDung
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtE As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnTest = New System.Windows.Forms.Button
        Me.txtE = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton3 = New Infragistics.Win.Misc.UltraButton
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(160, 32)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        '
        'txtE
        '
        Me.txtE.Location = New System.Drawing.Point(136, 80)
        Me.txtE.Name = "txtE"
        Me.txtE.TabIndex = 2
        Me.txtE.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(8, 240)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.TabIndex = 4
        Me.UltraButton1.Text = "UltraButton1"
        '
        'UltraButton2
        '
        Me.UltraButton2.Location = New System.Drawing.Point(104, 240)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.TabIndex = 5
        Me.UltraButton2.Text = "37"
        '
        'UltraButton3
        '
        Me.UltraButton3.Location = New System.Drawing.Point(192, 240)
        Me.UltraButton3.Name = "UltraButton3"
        Me.UltraButton3.TabIndex = 5
        Me.UltraButton3.Text = "Tui Goi"
        '
        'UltraButton4
        '
        Me.UltraButton4.Location = New System.Drawing.Point(96, 200)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.TabIndex = 6
        Me.UltraButton4.Text = "Frm"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(64, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Báo cáo BC37"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(24, 168)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "test nothing"
        '
        'FrmHuongDanSuDung
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.UltraButton4)
        Me.Controls.Add(Me.UltraButton2)
        Me.Controls.Add(Me.UltraButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UltraButton3)
        Me.Name = "FrmHuongDanSuDung"
        Me.Text = "FrmHuongDanSuDung"
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " khai bao bien"
    Dim myABC As New API_ESHIPPING.Service
    Dim _strInput As String
    Dim _strOutput As String

    Dim myTenDangNhap As String
    Dim myBuuCucKhaiThac As Integer
    Dim myMAC As String
    Dim myIP As String
    Dim myMatKhau As String

    Dim myNuocNhan As String
    Dim myNuocTra As String
    Dim myMaBcGoc As Integer
    Dim myMaBcTra As Integer
    Dim myPostCode As String
    Dim myKhoiLuong As Integer
    Dim myPhanLoaiBP As String
    Dim myLoaiHangHoa As Integer
    Dim myLoai As Integer
    Dim myDVCongThem As String
    Dim myDVGiaTang As String
    Dim myNgayPhatHanh As Integer
    Dim myDuongThu As String
    Dim myChuyenThu As Integer
    Dim myTuiSo As Integer
    Dim myMaKH As String
    Dim myNguoiGui As String
    Dim myNguoiNhan As String
    Dim myDiaChiGui As String
    Dim myDiaChiNhan As String
    Dim myDTGui As String
    Dim myDTNhan As String
    Dim myGhiChu As String
    Dim myVERIFIED As Integer
    Dim myTienThuHo As Integer
    Dim myCOD As Integer
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)
    Dim myTuyen_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myTuyen_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
    Dim myChang_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myChang_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet


    'Public myTienThuHo As Integer = 0

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim frm As New FrmIn_Nhan_E4_Label
        'frm.ShowDialog()
        Dim frm As New FrmIn_BC37_Tap_Trung
        frm.ShowDialog()
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        myTenDangNhap = "nvth"
        myBuuCucKhaiThac = 101003
        myMAC = "90 - E6 - BA - C1 - E3 - DF"
        myIP = "192.168.68.55"
        myMatKhau = "nvth"

        '=====================E100 ĐĂNG NHậP===========================================
        If txtE.Text = "E100" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E100", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '==================E200  PHÁT HÀNH BƯU GửI==============================================
        ElseIf txtE.Text = "E200" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "VN", "VN", 101003, 180100, 180000, 150, "M", 1, 1, "COD", "", 20130601, 100009, 15, 6, "TEST", " EMS", "TRAN VAN DON", "SO 1 TAN XUAN", "HAI PHONG", "0437575577", "09888888888", "COD", 1, 360000, 1}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E200", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=================E300  TRUY VẤN THÔNG TIN BƯU GỬI================================================
        ElseIf txtE.Text = "E300" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, 101003, 20130601}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E300", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=================E400  – CậP NHậT THÔNG TIN BƯU PHẩM=================================================
        ElseIf txtE.Text = "E400" Then

            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "EB205694415VN", "200100100916201210125712EB205694415VN0", "VN", "VN", 101003, 180100, 180000, 150, "M", 1, 1, "COD", "", 20130601, 100009, 15, 6, "TEST", " EMS", "TRAN VAN DON", "SO 1 TAN XUAN", "HAI PHONG", "0437575577", "09888888888", "COD", 1, 360000, 1}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E400", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '================E500  XÁC THỰC VIỆC PHÁT HÀNH VẬN ĐƠN==================================================
        ElseIf txtE.Text = "E500" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "EA040004310VN", 20130601, 1}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E500", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '================E700 – PHÁT HÀNH VậN ĐƠN BƯU GửI CủA LÔ HÀNG  DANG LOI===========================================
        ElseIf txtE.Text = "E700" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "TEST1", "VN", "VN", 101003, 170100, "170000", 5, 150, "M", 1, 1, "COD", "", 20130601, 100009, 15, 6, "TEST2", " EMS", "TRAN VAN DON", "SO 1 TAN XUAN", "HAI DUONG", "0437575577", "09888888888", "COD", 1}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E700", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '================E800  E1 AUTOGENERATION==================================================================
        ElseIf txtE.Text = "E800" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "VN"}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E800", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '================E900  XÓA E1==================================================================
        ElseIf txtE.Text = "E900" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "EA040004310VN", 20130601}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E900", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=====================E1000 ĐĂNG NHậP DANG LOI===========================================
        ElseIf txtE.Text = "E1000" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1000", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=====================	E1100 – TạO THÔNG TIN GIAO NHậN===========================================
        ElseIf txtE.Text = "E1100" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060121", 2, 0, 20130601, 1503, 100916}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1100", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================	E1200 – XÓA THÔNG TIN GIAO NHậN===========================================
        ElseIf txtE.Text = "E1200" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122"}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1200", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================	E1300 – CậP NHậT THÔNG TIN KHốI LƯợNG===========================================
        ElseIf txtE.Text = "E1300" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122", 350, 620}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1300", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=====================	E1400 – HOÀN TấT QUÁ TRÌNH GIAO HÀNG===========================================
        ElseIf txtE.Text = "E1400" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122"}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1400", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================	E1500 – LấY THÔNG TIN NHậN HÀNG===========================================
        ElseIf txtE.Text = "E1500" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122", 100916}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1500", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================	E1600 – CậP NHậT THÔNG TIN NHậN HÀNG===========================================
        ElseIf txtE.Text = "E1600" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122", 100916, 20130602, 1400}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1600", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================		E1700 – HOÀN TấT NHậN HÀNG ===========================================
        ElseIf txtE.Text = "E1700" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, "1010031009162013060122"}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1700", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            '=====================		E1800 – THÊM THÔNG TIN TÚI===========================================
        ElseIf txtE.Text = "E1800" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, 1, "1010031009162013060111", 101003100916, "101003100916201306011", "1010031009162013060122", 101003, 100916, 1, 1, 350, 390, 5, 20130601, 1400, 20130601, 1330, 0, 2, 0}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1800", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            '=====================		E1900 – THÊM THÔNG TIN TÚI===========================================
        ElseIf txtE.Text = "E1900" Then
            Dim myArray() As String = {Guid.NewGuid().ToString(), myTenDangNhap, myBuuCucKhaiThac, myMAC, myIP, myMatKhau, 1, "1010031009162013060111", "1010031009162013060122"}
            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            myABC.Url = "http://118.70.170.83:86/Service.asmx "
            _strOutput = myABC.ExecuteMessage("E1900", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            MessageBox.Show(_strOutput, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim frm As New FrmNhanTuiGoiDen
        'frm.ShowDialog()
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim myString As String = ""
        Try
            myString = Liet_Ke_Chang_Van_Chuyen(100916, "D")
            Dim strArr() As String
            Dim n As Integer = 0
            strArr = myString.Split("|")
            If myString.Split("|")(0) = "00" Then
                n = strArr.Length - 3
                If MessageBox.Show("Có " + n.ToString + " bản ghi bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For i As Integer = 45 To strArr.Length - 1
                        myChang_VC_Chi_Tiet.Id_Chang = IIf(strArr(i).Split("^")(0) = "", 0, strArr(i).Split("^")(0))
                        myChang_VC_Chi_Tiet.Id_Tuyen = IIf(strArr(i).Split("^")(1) = "", 0, strArr(i).Split("^")(1))
                        myChang_VC_Chi_Tiet.Ma_Bc_Goc = IIf(strArr(i).Split("^")(2) = "", 0, strArr(i).Split("^")(2))
                        myChang_VC_Chi_Tiet.Ten_Bc_Goc = strArr(i).Split("^")(3)
                        myChang_VC_Chi_Tiet.Ma_Bc_Dich = IIf(strArr(i).Split("^")(4) = "", 0, strArr(i).Split("^")(4))
                        myChang_VC_Chi_Tiet.Ten_Bc_Dich = strArr(i).Split("^")(5)

                        myChang_VC_Chi_Tiet.Cap_Bc_Dich = IIf(strArr(i).Split("^")(6) = "", 0, strArr(i).Split("^")(6))


                        'myChang_VC_Chi_Tiet.Gio_Di = IIf(strArr(i).Split("^")(7) = "", 0, Ham_Dung_Chung.ConvertTimeToInt(strArr(i).Split("^")(7)))

                        'myChang_VC_Chi_Tiet.Gio_Den = IIf(strArr(i).Split("^")(8) = "", 0, Ham_Dung_Chung.ConvertTimeToInt(strArr(i).Split("^")(8)))

                        If strArr(i).Split("^")(7) = "" Then
                            myChang_VC_Chi_Tiet.Gio_Di = 0
                        Else
                            myChang_VC_Chi_Tiet.Gio_Di = Ham_Dung_Chung.ConvertTimeToInt(strArr(i).Split("^")(7))
                        End If

                        If strArr(i).Split("^")(8) = "" Then
                            myChang_VC_Chi_Tiet.Gio_Den = 0
                        Else
                            myChang_VC_Chi_Tiet.Gio_Den = Ham_Dung_Chung.ConvertTimeToInt(strArr(i).Split("^")(8))
                        End If



                        myChang_VC_Chi_Tiet.STT = IIf(strArr(i).Split("^")(9) = "", 0, strArr(i).Split("^")(9))

                        myChang_VC.QLTGND_CHANG_VC_Cap_Nhat_Them(myChang_VC_Chi_Tiet.Id_Chang, myChang_VC_Chi_Tiet.Id_Tuyen, myChang_VC_Chi_Tiet.Ma_Bc_Goc, myChang_VC_Chi_Tiet.Ten_Bc_Goc, myChang_VC_Chi_Tiet.Ma_Bc_Dich, myChang_VC_Chi_Tiet.Ten_Bc_Dich, myChang_VC_Chi_Tiet.Cap_Bc_Dich, myChang_VC_Chi_Tiet.Gio_Di, myChang_VC_Chi_Tiet.Gio_Den, myChang_VC_Chi_Tiet.STT)
                    Next
                    MessageBox.Show("Cập nhật thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
    Private Sub UltraButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton2.Click
        Dim myString As String = ""
        Try

            myString = Them_Thong_Tin_BC37(123, "dfdfd", "tttt", "ghthtt", "1", "02/01/2013", 8384, "ddddururu", 234, "ccc", "www", "02/09/2013", 45, 654, "3", 43, 0, 0)

            MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton3.Click
        Dim myString As String = ""
        Try

            myString = Them_Thong_Tin_Tui_Goi(5, 1, "435", "100000", "700000", "2013", 1, "4567", "455", "N", 344, "0", 44, 1, "02/05/2013", "02/11/2013 4:05", "65", "44", "02/11/2013 4:05", "98", "4", "05/05/2013", 1, 1, 0, 1)

            MessageBox.Show(myString.Split("|")(1), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        Dim frm As New FrmDuLieu
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New frmBaoCaoBC37
        frm.ShowDialog()
    End Sub

    Private Sub FrmHuongDanSuDung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myReString As String
        myReString = Nothing
        If myReString Is Nothing Then
            MessageBox.Show("Lỗi truyền dữ liệu!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myReString = "ABC"
        Else
            If myReString.IndexOf("00") < 0 Then
                MessageBox.Show("Lỗi truyền dữ liệu!!!" & vbNewLine & myReString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class
























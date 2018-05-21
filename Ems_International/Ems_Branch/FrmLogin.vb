Imports Ems_International_Logic.EMS
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.IO
Imports System.Math

Public Class FrmLogin
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDongY As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMatKhau As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDangNhap As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbBuuCuc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblGio As System.Windows.Forms.Label
    Friend WithEvents lblNgay As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents lblUpdate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLogin))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnDongY = New Infragistics.Win.Misc.UltraButton
        Me.txtMatKhau = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtDangNhap = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbBuuCuc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblGio = New System.Windows.Forms.Label
        Me.lblNgay = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.lblUpdate = New System.Windows.Forms.Label
        CType(Me.txtMatKhau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDangNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Location = New System.Drawing.Point(304, 232)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(88, 32)
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát"
        '
        'btnDongY
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnDongY.Appearance = Appearance2
        Me.btnDongY.Location = New System.Drawing.Point(208, 232)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(88, 32)
        Me.btnDongY.TabIndex = 6
        Me.btnDongY.Text = "Đồng ý"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(280, 120)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(112, 21)
        Me.txtMatKhau.TabIndex = 5
        '
        'txtDangNhap
        '
        Me.txtDangNhap.Location = New System.Drawing.Point(280, 96)
        Me.txtDangNhap.Name = "txtDangNhap"
        Me.txtDangNhap.Size = New System.Drawing.Size(112, 21)
        Me.txtDangNhap.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 26)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Đăng nhập vào ca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "&Mật khẩu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Mã &nhân viên"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "&Bưu cục khai thác"
        '
        'cbBuuCuc
        '
        Me.cbBuuCuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã bưu cục"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên bưu cục"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.cbBuuCuc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbBuuCuc.DisplayMember = ""
        Me.cbBuuCuc.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbBuuCuc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuuCuc.Location = New System.Drawing.Point(280, 72)
        Me.cbBuuCuc.Name = "cbBuuCuc"
        Me.cbBuuCuc.Size = New System.Drawing.Size(112, 21)
        Me.cbBuuCuc.TabIndex = 1
        Me.cbBuuCuc.ValueMember = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(24, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 96)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Hãy kiểm tra ngày giờ hệ thống, nếu thấy không đúng phải sửa ngay !!!"
        '
        'lblGio
        '
        Me.lblGio.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblGio.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGio.Location = New System.Drawing.Point(216, 160)
        Me.lblGio.Name = "lblGio"
        Me.lblGio.Size = New System.Drawing.Size(144, 24)
        Me.lblGio.TabIndex = 50
        Me.lblGio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNgay
        '
        Me.lblNgay.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblNgay.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNgay.Location = New System.Drawing.Point(216, 200)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(144, 24)
        Me.lblNgay.TabIndex = 51
        Me.lblNgay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.ForeColor = System.Drawing.Color.Blue
        Me.lblUpdate.Location = New System.Drawing.Point(184, 0)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(147, 19)
        Me.lblUpdate.TabIndex = 52
        Me.lblUpdate.Text = "Cập nhật phiên bản mới"
        '
        'FrmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(399, 275)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNgay)
        Me.Controls.Add(Me.lblGio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbBuuCuc)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtDangNhap)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vào ca"
        CType(Me.txtMatKhau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDangNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim myDungChung As New Ham_Dung_Chung

#Region "Form Load"
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim aModuleName As String = Diagnostics.Process.GetCurrentProcess.MainModule.ModuleName
        Dim aProcName As String = System.IO.Path.GetFileNameWithoutExtension(aModuleName)
        'Neu da chay mot ban roi
        If Process.GetProcessesByName(aProcName).Length > 1 Then
            MessageBox.Show("Đã có một bản Ems_International đang chạy trên máy bạn !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Exit Sub
        End If
        Text = "Chương Trình EMS International Phiên Bản " & GPhien_Ban
        If IsDate("31/12/2006") Then
            MessageBox.Show("Ngày giờ hệ thống của bạn có vấn đề !!!" & vbNewLine & _
                            "Gợi ý: Hãy vào Start/Settings/Control Panel/Regional and Language để chỉnh sửa định dạng ngày tháng theo dạng MM/dd/yyyy" & vbNewLine & _
                            "Cảnh báo: Trong trường hợp bạn không sửa thì rất có thể có những lỗi phát sinh sau này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
        End If
CauHinh:
        If Not Cau_Hinh_Database() Then
            If MessageBox.Show("      Không thể kết nối tới DataBase !!!" & vbNewLine & _
                                "Bạn có muốn thiết lập lại thông số không???", "Thông báo", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
                Close()
                Exit Sub
            End If
            Dim Frm As New FrmCauHinhCoSoDuLieu
            Frm.ShowDialog()
            SetKey_FirstRun() 'Tạo các Keys mặc định ban đầu
            GoTo CauHinh
        End If

        If Not Cau_Hinh_Database_E_Shiping() Then
            MessageBox.Show("   Không thể kết nối tới hệ thống E_Shiping !!!" & vbNewLine & _
                            "Bạn có thể không sử dụng được một số chức năng!!!" & vbNewLine & _
                            "    Bạn hãy liên hệ với người quản trị.", "Thông báo", _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Cau_Hinh_Database_Oracle()

        'Kiem tra ngay gio client va gio cua server
        Dim myNgayServer As DateTime
        Dim myNoiBo As New Thong_Tin_Noi_Bo(GConnectionString)
        myNgayServer = myNoiBo.Lay_Ngay_Gio_Server()
        'If Math.Abs(myNgayServer.Minute() - Now.Minute()) > 30 Then
        If Math.Abs(DateDiff(DateInterval.Minute, myNgayServer, Now)) > 30 Then
            If CMessageBox.Show("Ngày giờ máy tính hiện tại và ngày giờ trên máy chủ lệch nhau hơn 30 phút !!!" & vbNewLine & "Nếu tiếp tục thì chương trình sẽ cập nhật ngày giờ hệ thống của bạn bằng ngày giờ của máy chủ." & vbNewLine & "Nếu ngày giờ máy chủ không đúng với ngày giờ thực tế , yêu cầu gọi ngay cho người quản trị hệ thống để thay đổi lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                Shell("CMD /C Date " & myNgayServer, vbHide)
                Shell("CMD /C Time " & myNgayServer.Hour & ":" & myNgayServer.Minute, vbHide)
            Else
                Close()
                Exit Sub
            End If
        End If

        'Dim myE2Di As New E2_Di(GConnectionString)
        'myE2Di.ConvertE2Di("44000044313020080925252")
        txtDangNhap.Text = Get_UserName_From_Reg()
        DataGridBinding()
        cbBuuCuc.Value = Get_BCKT_From_Reg()
        lblGio.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
        lblNgay.Text = IIf(Now.Day.ToString.Length = 1, "0" & Now.Day.ToString, Now.Day.ToString) & "/" & IIf(Now.Month.ToString.Length = 1, "0" & Now.Month.ToString, Now.Month.ToString) & "/" & Now.Year
        txtDangNhap.Focus()

        Dim mThongTinNoiBo As DataTable = myNoiBo.Danh_Sach().Tables(0)
        GPhien_Ban_DataBase = Convert.ToString(mThongTinNoiBo.Rows(0).Item("Phien_Ban"))  'Phiên bản được ghi trong Database
        GDia_Chi_Gui_Paypost = Convert.ToString(mThongTinNoiBo.Rows(0).Item("Dia_Chi_Gui_Paypost"))
        GNguoi_Gui_Paypost = Convert.ToString(mThongTinNoiBo.Rows(0).Item("Nguoi_Gui_Paypost"))
        GDien_Thoai_Gui_Paypost = Convert.ToString(mThongTinNoiBo.Rows(0).Item("Dien_Thoai_Gui_Paypost"))
        GMa_KH_Gui_Paypost = Convert.ToString(mThongTinNoiBo.Rows(0).Item("Ma_KH_Gui_Paypost"))

        If GPhien_Ban_DataBase <> GPhien_Ban Then
            lblUpdate.Visible = True
        Else
            lblUpdate.Visible = False
        End If
    End Sub
#End Region

#Region "DataGridBinding"
    Private Sub DataGridBinding()
        Dim myBuu_Cuc As New Ma_Bc_Khai_Thac(GConnectionString)
        cbBuuCuc.DataSource = myBuu_Cuc.Danh_Sach_Login().Tables(0)
        cbBuuCuc.DataBind()
        If cbBuuCuc.Rows.Count > 0 Then
            cbBuuCuc.Value = cbBuuCuc.Rows(0).Cells(0).Value
        End If
    End Sub
#End Region

#Region "Thoát"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub
#End Region

#Region "Đồng Ý"
    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        GLan_Dau_Tien = False
        Dim myNoiBo As New Thong_Tin_Noi_Bo(GConnectionString)
        Dim myNguoi_Dung As New Nguoi_Dung(GConnectionString)
        Dim myNguoi_Dung_Chi_Tiet As New Nguoi_Dung_Chi_Tiet
        Dim myBuu_Cuc As New Ma_Bc_Khai_Thac(GConnectionString)
        Dim myBuu_Cuc_Chi_Tiet As New Ma_Bc_Khai_Thac_Chi_Tiet
        Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
        Dim myTy_Gia As New Ty_Gia(GConnectionString)
        Dim myTy_Gia_Chi_Tiet As New Ty_Gia_Chi_Tiet

        'Kiểm tra phiên bản

        GPhien_Ban_DataBase = myNoiBo.Danh_Sach().Tables(0).Rows(0).Item("Phien_Ban") 'Phiên bản được ghi trong Database
        If GPhien_Ban_DataBase <> GPhien_Ban Then
            If MessageBox.Show("        Phiên bản đang được sử dụng là: " & GPhien_Ban_DataBase & vbNewLine & _
                            "      Chương trình bạn đang sử dụng là phiên bản: " & GPhien_Ban & vbNewLine & _
                            "    Bạn chỉ có thể sử dụng chức năng tra cứu bưu phẩm!!!" & vbNewLine & _
                            "Bạn hãy liên hệ với người quản trị để cập nhật chương trình!!!" & vbNewLine & _
                            "               Bạn có muốn tiếp tục không??", _
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If

        'Kiểm tra thông tin người dùng: User, Pass
        myNguoi_Dung_Chi_Tiet = myNguoi_Dung.Lay_Boi_Ten_Dang_Nhap(txtDangNhap.Text.Trim, txtMatKhau.Text.Trim)
        If myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung = 0 Then
            CMessageBox.Show("Không tồn tại người dùng này hoặc mật khẩu không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDangNhap.Focus()
            Exit Sub
            'Tiếp tục kiểm tra mật khẩu của người dùng nếu đã được mã hóa
            'myNguoi_Dung_Chi_Tiet = Nothing
            'myNguoi_Dung_Chi_Tiet = myNguoi_Dung.Lay_Boi_Ten_Dang_Nhap(txtDangNhap.Text.Trim, Encrypt(txtMatKhau.Text.Trim, "cpcpnems"))
            'If myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung = 0 Then
            '    CMessageBox.Show("Không tồn tại người dùng này hoặc mật khẩu không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    txtDangNhap.Focus()
            '    Exit Sub
            'End If
        End If
        Gid_Nguoi_Dung = myNguoi_Dung_Chi_Tiet.Id_Nguoi_Dung

        'Thêm quyền mới của người dùng vào (nếu có)
        myNguoi_Dung.Xet_Lai_Quyen_Han(Gid_Nguoi_Dung)

        GTen_Dang_Nhap = myNguoi_Dung_Chi_Tiet.Ten_Dang_Nhap
        GHo_Ten = myNguoi_Dung_Chi_Tiet.Ho_Ten
        GDien_Thoai = myNguoi_Dung_Chi_Tiet.Dien_Thoai
        GUserAdmin = myNguoi_Dung_Chi_Tiet.Admin
        'Kiểm tra dữ liệu về ca khai thác
        If cbBuuCuc.Text.Length <> 0 Then
            GBuu_Cuc_Khai_Thac = Convert.ToInt32(cbBuuCuc.Text)
            If GBuu_Cuc_Khai_Thac.ToString().Substring(0, 2) = "70" Then
                GPost_Office = 2
            End If
        Else
            CMessageBox.Show("Không tồn tại mã bưu cục khai thác nào cả, bạn phải nhập mã bưu cục khai thác vào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim FrmDanhMuc As New FrmMaBCKhaiThac
            FrmDanhMuc.ShowDialog()
            DataGridBinding()
            Exit Sub
        End If

        'Kiểm tra dữ liệu về ca khai thác

        'kiểm tra ngày khai thác 
        Dim ngaykt_chk As Integer = myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac
        Dim ngaybatdau_chk As Integer = myCa_San_Xuat_Chi_Tiet.Tu_Ngay
        Dim ngayketthuc_chk As Integer = myCa_San_Xuat_Chi_Tiet.Den_Ngay
        If (ngaykt_chk < ngaybatdau_chk Or ngaybatdau_chk > ngayketthuc_chk Or ngaykt_chk > ngaykt_chk) Then
            CMessageBox.Show("Thông tin xác nhận ca có vấn đề. Bạn cần kiểm tra lại", "Có lỗi trong thông tin ngày khai thác")
            Dim frmxacnhanca As New frmxacnhanca
            frmxacnhanca.ShowDialog()
        End If

        myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Boi_Ma_Bc_Khai_Thac_Dang_Su_Dung(Convert.ToInt32(IIf(cbBuuCuc.Text.Length = 0, "0", cbBuuCuc.Text)))
        If myCa_San_Xuat_Chi_Tiet.Id_Ca = "" Then
            If myCa_San_Xuat.Lay_Boi_Ma_Bc_Khai_Thac(Convert.ToInt32(IIf(cbBuuCuc.Text.Length = 0, "0", cbBuuCuc.Text))).Tables(0).Rows.Count = 0 Then
                CMessageBox.Show("Đây là lần chạy đầu tiên, đề nghị bạn tạo mới ca để làm việc !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GLan_Dau_Tien = True
                Dim FrmCa As New frmxacnhanca
                FrmCa.GId_Ca_Lien_Truoc = myCa_San_Xuat_Chi_Tiet.Id_Ca
                FrmCa.ShowDialog()
                Exit Sub
            Else
                CMessageBox.Show("Ca khai thác đã hết thời gian làm việc, Bạn phải hiệu chỉnh ca làm việc hoặc tạo ca làm việc mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Dim FrmCa As New frmxacnhanca
                FrmCa.GId_Ca_Lien_Truoc = myCa_San_Xuat_Chi_Tiet.Id_Ca
                FrmCa.ShowDialog()
                Exit Sub
            End If
        Else
            GId_Ca = myCa_San_Xuat_Chi_Tiet.Id_Ca
            If Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat_Chi_Tiet.Tu_Ngay, myCa_San_Xuat_Chi_Tiet.Tu_Gio) > Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now)) Or Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat_Chi_Tiet.Den_Ngay, myCa_San_Xuat_Chi_Tiet.Den_Gio) < Ham_Dung_Chung.ConvertIntToDate(Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now)) Then
                'If GUserAdmin = False Then
                CMessageBox.Show("Ca khai thác đã hết thời gian làm việc, Bạn phải hiệu chỉnh ca làm việc hoặc tạo ca làm việc mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Dim FrmCa As New frmxacnhanca
                FrmCa.GId_Ca_Lien_Truoc = GId_Ca
                FrmCa.ShowDialog()
                'Close()
                Exit Sub
                'End If
            End If
        End If

        'Kiểm tra tỷ giá
        myTy_Gia_Chi_Tiet = myTy_Gia.Lay(Ham_Dung_Chung.ConvertDateToInt(Now))
        If myTy_Gia_Chi_Tiet.Ty_Gia = 0 Then
            MessageBox.Show("Không tồn tại tỷ giá ngoại tệ của ngày hôm nay." & vbNewLine & _
                                "Bạn phải nhập tỷ giá cho ngày hôm nay!!!", _
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
NhapTyGia:
            Dim FrmNhapTyGia As New FrmNhapTyGia
            FrmNhapTyGia.ShowDialog()
            'Kiểm tra xem tỷ giá đã được nhập chưa, nếu vẫn chưa nhập thì quay lại yêu cầu nhập tiếp
            myTy_Gia_Chi_Tiet = myTy_Gia.Lay(Ham_Dung_Chung.ConvertDateToInt(Now))
            If myTy_Gia_Chi_Tiet.Ty_Gia = 0 Then
                If MessageBox.Show("Bạn chưa cập nhật tỷ giá của ngày hôm nay!!!" & vbNewLine & _
                                    "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    GoTo NhapTyGia
                Else
                    Close()
                    Exit Sub
                End If
            End If
        End If

        'Admin thì sửa chữa được những ca trước đó
        If GUserAdmin = True Then
            Dim frmCaKT As New FrmCaKeToan
            frmCaKT.ShowDialog()
        End If

        'Kiem tra kết nối với Database của khai thác Quốc tế - Logitic
        Dim mIp_Duong_Thu_Logitic As New Ip_Duong_Thu_Logitic(GConnectionString)
        Dim mIp_Duong_Thu_Logitic_Chi_Tiet As New Ip_Duong_Thu_Logitic_Chi_Tiet
        mIp_Duong_Thu_Logitic_Chi_Tiet = mIp_Duong_Thu_Logitic.Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc(GBuu_Cuc_Khai_Thac)
        If mIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich.Trim <> "" Then
            Dim str As String
            str = mIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich
            GConnectionString_International_From_Logitic = "Server = " & str & ";"

            str = mIp_Duong_Thu_Logitic_Chi_Tiet.Ten_CSDL_Dich
            GConnectionString_International_From_Logitic = GConnectionString_International_From_Logitic & "database=" & str & ";"

            str = mIp_Duong_Thu_Logitic_Chi_Tiet.User_CSDL_Dich
            GConnectionString_International_From_Logitic = GConnectionString_International_From_Logitic & "uid=" & str & ";"

            str = mIp_Duong_Thu_Logitic_Chi_Tiet.Pass_CSDL_Dich
            GConnectionString_International_From_Logitic = GConnectionString_International_From_Logitic & "pwd=" & str

            If Not TestConnection(GConnectionString_International_From_Logitic) Then
                MessageBox.Show("Không tồn tại kết nối tới cơ sở dữ liệu Ems International của Trung tâm Khai thác Quốc tế !!! Liên hệ với người quản trị hệ thống để nhận lại !!! Nếu không , dữ liệu đóng từ Trung tâm Logitic sang Trung tâm KTQT sẽ không được truyền!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        '---------------------------------- --------------------------

        'Vào phần chính của chương trình
        Dim Frm As New FrmMain
        Frm.lblNguoiDung.Text = myNguoi_Dung_Chi_Tiet.Ho_Ten
        myBuu_Cuc_Chi_Tiet = myBuu_Cuc.Lay(Convert.ToInt32(IIf(cbBuuCuc.Text.Length = 0, "0", cbBuuCuc.Text)))
        GTen_Buu_Cuc_Khai_Thac = myBuu_Cuc_Chi_Tiet.Ten_Bc_Khai_Thac

        GOutBout = myBuu_Cuc_Chi_Tiet.OutBout
        Select Case GOutBout
            Case 0 'Quốc tế đến
                Frm.Text = ":: QUỐC TẾ CHIỀU ĐẾN - " + GTen_Buu_Cuc_Khai_Thac.ToUpper + " ::"
                Frm.ExplorerBarMenu.Groups.Item("QT_DI").Visible = False
                Frm.ExplorerBarMenu.Groups.Item("QT_DEN").Visible = True
                Frm.ExplorerBarMenu.Groups.Item("HQ").Visible = False
                Frm.ExplorerBarMenu.Groups.Item("KH").Visible = False
            Case 1 'Quốc tế đi
                Frm.Text = ":: QUỐC TẾ CHIỀU ĐI - " + GTen_Buu_Cuc_Khai_Thac.ToUpper + " ::"
                Frm.ExplorerBarMenu.Groups.Item("QT_DI").Visible = True
                Frm.ExplorerBarMenu.Groups.Item("QT_DEN").Visible = False
                Frm.ExplorerBarMenu.Groups.Item("HQ").Visible = True
                Frm.ExplorerBarMenu.Groups.Item("KH").Visible = True
            Case 2 'Kho hải quan
                Frm.Text = ":: HẢI QUAN - " + GTen_Buu_Cuc_Khai_Thac.ToUpper + " ::"
                Frm.ExplorerBarMenu.Groups.Item("QT_DI").Visible = False
                Frm.ExplorerBarMenu.Groups.Item("QT_DEN").Visible = True
                Frm.ExplorerBarMenu.Groups.Item("HQ").Visible = False
                Frm.ExplorerBarMenu.Groups.Item("KH").Visible = False
            Case Else 'Chưa xác định
                If MessageBox.Show("Không tồn tại phân loại này!!!" & vbNewLine & "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    cbBuuCuc.Focus()
                    Exit Sub
                Else
                    Close()
                End If
        End Select

        Frm.lblPhongBan.Text = myBuu_Cuc_Chi_Tiet.Ma_Bc_Khai_Thac & " - " & myBuu_Cuc_Chi_Tiet.Ten_Bc_Khai_Thac

        'Luu lai ten dang nhap vao Reg de cho lan sau dang nhap
        Write_LogInFo_To_Reg()
        'Tao thu muc chua du lieu temp tren may client
        CreatePrintFolder()
        '-----------------------
        'Đẩy dữ liệu lên máy chủ Predes
        'Tạo thư mục Predes
        'Tạo bản tin Predes ra file txt
        'Sử dụng FTP đẩy dữ liệu của ngày hôm trước lên máy chủ FTP 192.168.68.9
        'Tạo Folder ngày hôm trước YYYYMMDD trong thư mục Predes
        'Move các file đã đẩy dữ liệu lên máy chut FTP



        Close()
        Dispose()
        Init() 'Load các thông số cài đặt
        GetKeys() 'Lay cac thong so he thong trong regitry
        Frm.ShowDialog()
    End Sub
#End Region

#Region "Tạo các key mặc định của chương trình khi chạy lần đầu tiên"
    Private Sub SetKey_FirstRun()
        Try
            Dim myKeys As New ModifyRegistry

            If (myKeys.Doc("ban_ke_a1_start_time") Is Nothing Or myKeys.Doc("ban_ke_a1_start_time") = "") Then
                myKeys.Ghi("ban_ke_a1_start_time", "07:00")
            End If

            If (myKeys.Doc("ban_ke_a1_end_time") Is Nothing Or myKeys.Doc("ban_ke_a1_end_time") = "") Then
                myKeys.Ghi("ban_ke_a1_end_time", "12:00")
            End If

            If (myKeys.Doc("dauma") Is Nothing Or myKeys.Doc("dauma") = "") Then
                myKeys.Ghi("dauma", "EE")
            End If

            If (myKeys.Doc("gbuu_cuc_khai_thac") Is Nothing Or myKeys.Doc("gbuu_cuc_khai_thac") = "") Then
                myKeys.Ghi("gbuu_cuc_khai_thac", "")
            End If

            If (myKeys.Doc("gin_ban_ke_hq_buu_dien") Is Nothing Or myKeys.Doc("gin_ban_ke_hq_buu_dien") = "") Then
                myKeys.Ghi("gin_ban_ke_hq_buu_dien", "False")
            End If

            If (myKeys.Doc("gin_kim_qt_den") Is Nothing Or myKeys.Doc("gin_kim_qt_den") = "") Then
                myKeys.Ghi("gin_kim_qt_den", "False")
            End If

            If (myKeys.Doc("gin_kim_qt_di_cn38") Is Nothing Or myKeys.Doc("gin_kim_qt_di_cn38") = "") Then
                myKeys.Ghi("gin_kim_qt_di_cn38", "False")
            End If

            If (myKeys.Doc("gin_laser_qt_den") Is Nothing Or myKeys.Doc("gin_laser_qt_den") = "") Then
                myKeys.Ghi("gin_laser_qt_den", "False")
            End If

            If (myKeys.Doc("gin_laser_qt_di_cn38") Is Nothing Or myKeys.Doc("gin_laser_qt_di_cn38") = "") Then
                myKeys.Ghi("gin_laser_qt_di_cn38", "False")
            End If

            If (myKeys.Doc("gkieu_in_map") Is Nothing Or myKeys.Doc("gkieu_in_map") = "") Then
                myKeys.Ghi("gkieu_in_map", "False")
            End If

            If (myKeys.Doc("gkieu_in_map_cn38") Is Nothing Or myKeys.Doc("gkieu_in_map_cn38") = "") Then
                myKeys.Ghi("gkieu_in_map_cn38", "False")
            End If

            If (myKeys.Doc("gso_ngay_e1_duoc_trung") Is Nothing Or myKeys.Doc("gso_ngay_e1_duoc_trung") = "") Then
                myKeys.Ghi("gso_ngay_e1_duoc_trung", "150")
            End If

            If (myKeys.Doc("gsua_cuoc_chinh") Is Nothing Or myKeys.Doc("gsua_cuoc_chinh") = "") Then
                myKeys.Ghi("gsua_cuoc_chinh", "False")
            End If

            If (myKeys.Doc("gsua_cuoc_dv") Is Nothing Or myKeys.Doc("gsua_cuoc_dv") = "") Then
                myKeys.Ghi("gsua_cuoc_dv", "False")
            End If

            If (myKeys.Doc("gsua_cuoc_e1") Is Nothing Or myKeys.Doc("gsua_cuoc_e1") = "") Then
                myKeys.Ghi("gsua_cuoc_e1", "False")
            End If

            If (myKeys.Doc("gten_dang_nhap") Is Nothing Or myKeys.Doc("gten_dang_nhap") = "") Then
                myKeys.Ghi("gten_dang_nhap", "Admin")
            End If

            If (myKeys.Doc("gten_may_in_bc37") Is Nothing Or myKeys.Doc("gten_may_in_bc37") = "") Then
                myKeys.Ghi("gten_may_in_bc37", "")
            End If

            If (myKeys.Doc("gten_may_in_bv10") Is Nothing Or myKeys.Doc("gten_may_in_bv10") = "") Then
                myKeys.Ghi("gten_may_in_bv10", "")
            End If

            If (myKeys.Doc("gten_may_in_cn35") Is Nothing Or myKeys.Doc("gten_may_in_cn35") = "") Then
                myKeys.Ghi("gten_may_in_cn35", "")
            End If

            If (myKeys.Doc("gten_may_in_cn38") Is Nothing Or myKeys.Doc("gten_may_in_cn38") = "") Then
                myKeys.Ghi("gten_may_in_cn38", "")
            End If

            If (myKeys.Doc("gten_may_in_e2") Is Nothing Or myKeys.Doc("gten_may_in_e2") = "") Then
                myKeys.Ghi("gten_may_in_e2", "")
            End If

            If (myKeys.Doc("gten_may_in_e4") Is Nothing Or myKeys.Doc("gten_may_in_e4") = "") Then
                myKeys.Ghi("gten_may_in_e4", "")
            End If

            If (myKeys.Doc("gten_may_tinh_bc37") Is Nothing Or myKeys.Doc("gten_may_tinh_bc37") = "") Then
                myKeys.Ghi("gten_may_tinh_bc37", "")
            End If

            If (myKeys.Doc("gten_may_tinh_bv10") Is Nothing Or myKeys.Doc("gten_may_tinh_bv10") = "") Then
                myKeys.Ghi("gten_may_tinh_bv10", "")
            End If

            If (myKeys.Doc("gten_may_tinh_cn35") Is Nothing Or myKeys.Doc("gten_may_tinh_cn35") = "") Then
                myKeys.Ghi("gten_may_tinh_cn35", "")
            End If

            If (myKeys.Doc("gten_may_tinh_cn38") Is Nothing Or myKeys.Doc("gten_may_tinh_cn38") = "") Then
                myKeys.Ghi("gten_may_tinh_cn38", "")
            End If

            If (myKeys.Doc("gten_may_tinh_e2") Is Nothing Or myKeys.Doc("gten_may_tinh_e2") = "") Then
                myKeys.Ghi("gten_may_tinh_e2", "")
            End If

            If (myKeys.Doc("gten_may_tinh_e4") Is Nothing Or myKeys.Doc("gten_may_tinh_e4") = "") Then
                myKeys.Ghi("gten_may_tinh_e4", "")
            End If

            If (myKeys.Doc("gthu_muc_in_bc37_qt_den") Is Nothing Or myKeys.Doc("gthu_muc_in_bc37_qt_den") = "") Then
                myKeys.Ghi("gthu_muc_in_bc37_qt_den", "100915")
            End If

            If (myKeys.Doc("gthu_muc_in_bv10_qt_den") Is Nothing Or myKeys.Doc("gthu_muc_in_bv10_qt_den") = "") Then
                myKeys.Ghi("gthu_muc_in_bv10_qt_den", "100915")
            End If

            If (myKeys.Doc("gthu_muc_in_cn35_qt_di") Is Nothing Or myKeys.Doc("gthu_muc_in_cn35_qt_di") = "") Then
                myKeys.Ghi("gthu_muc_in_cn35_qt_di", "100915")
            End If

            If (myKeys.Doc("gthu_muc_in_cn38_qt_di") Is Nothing Or myKeys.Doc("gthu_muc_in_cn38_qt_di") = "") Then
                myKeys.Ghi("gthu_muc_in_cn38_qt_di", "100915")
            End If

            If (myKeys.Doc("gthu_muc_in_e2_qt_den") Is Nothing Or myKeys.Doc("gthu_muc_in_e2_qt_den") = "") Then
                myKeys.Ghi("gthu_muc_in_e2_qt_den", "100915")
            End If

            If (myKeys.Doc("gthu_muc_in_e4_qt_den") Is Nothing Or myKeys.Doc("gthu_muc_in_e4_qt_den") = "") Then
                myKeys.Ghi("gthu_muc_in_e4_qt_den", "100915")
            End If

            If (myKeys.Doc("gtrong_luong_e1_max") Is Nothing Or myKeys.Doc("gtrong_luong_e1_max") = "") Then
                myKeys.Ghi("gtrong_luong_e1_max", "350000")
            End If

            If (myKeys.Doc("ib_grid_den_bc_ch_di") Is Nothing Or myKeys.Doc("ib_grid_den_bc_ch_di") = "") Then
                myKeys.Ghi("ib_grid_den_bc_ch_di", "False")
            End If

            If (myKeys.Doc("ib_grid_den_cuoc_dv") Is Nothing Or myKeys.Doc("ib_grid_den_cuoc_dv") = "") Then
                myKeys.Ghi("ib_grid_den_cuoc_dv", "False")
            End If

            If (myKeys.Doc("ib_grid_den_cuoc_e1") Is Nothing Or myKeys.Doc("ib_grid_den_cuoc_e1") = "") Then
                myKeys.Ghi("ib_grid_den_cuoc_e1", "False")
            End If

            If (myKeys.Doc("ib_grid_den_dia_chi_gui") Is Nothing Or myKeys.Doc("ib_grid_den_dia_chi_gui") = "") Then
                myKeys.Ghi("ib_grid_den_dia_chi_gui", "False")
            End If

            If (myKeys.Doc("ib_grid_den_dia_chi_nhan") Is Nothing Or myKeys.Doc("ib_grid_den_dia_chi_nhan") = "") Then
                myKeys.Ghi("ib_grid_den_dia_chi_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_den_dien_thoai_nhan") Is Nothing Or myKeys.Doc("ib_grid_den_dien_thoai_nhan") = "") Then
                myKeys.Ghi("ib_grid_den_dien_thoai_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_den_dv_cong_them") Is Nothing Or myKeys.Doc("ib_grid_den_dv_cong_them") = "") Then
                myKeys.Ghi("ib_grid_den_dv_cong_them", "False")
            End If

            If (myKeys.Doc("ib_grid_den_dv_gia_tang") Is Nothing Or myKeys.Doc("ib_grid_den_dv_gia_tang") = "") Then
                myKeys.Ghi("ib_grid_den_dv_gia_tang", "False")
            End If

            If (myKeys.Doc("ib_grid_den_ghi_chu") Is Nothing Or myKeys.Doc("ib_grid_den_ghi_chu") = "") Then
                myKeys.Ghi("ib_grid_den_ghi_chu", "False")
            End If

            If (myKeys.Doc("ib_grid_den_kien_so") Is Nothing Or myKeys.Doc("ib_grid_den_kien_so") = "") Then
                myKeys.Ghi("ib_grid_den_kien_so", "False")
            End If

            If (myKeys.Doc("ib_grid_den_le_phi_hq") Is Nothing Or myKeys.Doc("ib_grid_den_le_phi_hq") = "") Then
                myKeys.Ghi("ib_grid_den_le_phi_hq", "False")
            End If
            If (myKeys.Doc("ib_grid_den_loai_hang_hoa") Is Nothing Or myKeys.Doc("ib_grid_den_loai_hang_hoa") = "") Then
                myKeys.Ghi("ib_grid_den_loai_hang_hoa", "False")
            End If

            If (myKeys.Doc("ib_grid_den_nguoi_gui") Is Nothing Or myKeys.Doc("ib_grid_den_nguoi_gui") = "") Then
                myKeys.Ghi("ib_grid_den_nguoi_gui", "False")
            End If

            If (myKeys.Doc("ib_grid_den_nguoi_nhan") Is Nothing Or myKeys.Doc("ib_grid_den_nguoi_nhan") = "") Then
                myKeys.Ghi("ib_grid_den_nguoi_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_den_so_bien_lai") Is Nothing Or myKeys.Doc("ib_grid_den_so_bien_lai") = "") Then
                myKeys.Ghi("ib_grid_den_so_bien_lai", "False")
            End If

            If (myKeys.Doc("ib_grid_den_so_tkhq") Is Nothing Or myKeys.Doc("ib_grid_den_so_tkhq") = "") Then
                myKeys.Ghi("ib_grid_den_so_tkhq", "False")
            End If

            If (myKeys.Doc("ib_grid_den_thue_nk") Is Nothing Or myKeys.Doc("ib_grid_den_thue_nk") = "") Then
                myKeys.Ghi("ib_grid_den_thue_nk", "False")
            End If

            If (myKeys.Doc("ib_grid_den_thue_nk_vat") Is Nothing Or myKeys.Doc("ib_grid_den_thue_nk_vat") = "") Then
                myKeys.Ghi("ib_grid_den_thue_nk_vat", "False")
            End If

            If (myKeys.Doc("ib_grid_den_thue_vat") Is Nothing Or myKeys.Doc("ib_grid_den_thue_vat") = "") Then
                myKeys.Ghi("ib_grid_den_thue_vat", "False")
            End If

            If (myKeys.Doc("ib_grid_di_bc_ch") Is Nothing Or myKeys.Doc("ib_grid_di_bc_ch") = "") Then
                myKeys.Ghi("ib_grid_di_bc_ch", "False")
            End If

            If (myKeys.Doc("ib_grid_di_cuoc_dv") Is Nothing Or myKeys.Doc("ib_grid_di_cuoc_dv") = "") Then
                myKeys.Ghi("ib_grid_di_cuoc_dv", "False")
            End If

            If (myKeys.Doc("ib_grid_di_cuoc_e1") Is Nothing Or myKeys.Doc("ib_grid_di_cuoc_e1") = "") Then
                myKeys.Ghi("ib_grid_di_cuoc_e1", "False")
            End If

            If (myKeys.Doc("ib_grid_di_dia_chi_gui") Is Nothing Or myKeys.Doc("ib_grid_di_dia_chi_gui") = "") Then
                myKeys.Ghi("ib_grid_di_dia_chi_gui", "False")
            End If

            If (myKeys.Doc("ib_grid_di_dia_chi_nhan") Is Nothing Or myKeys.Doc("ib_grid_di_dia_chi_nhan") = "") Then
                myKeys.Ghi("ib_grid_di_dia_chi_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_di_dien_thoai_nhan") Is Nothing Or myKeys.Doc("ib_grid_di_dien_thoai_nhan") = "") Then
                myKeys.Ghi("ib_grid_di_dien_thoai_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_di_dv_cong_them") Is Nothing Or myKeys.Doc("ib_grid_di_dv_cong_them") = "") Then
                myKeys.Ghi("ib_grid_di_dv_cong_them", "False")
            End If

            If (myKeys.Doc("ib_grid_di_dv_gia_tang") Is Nothing Or myKeys.Doc("ib_grid_di_dv_gia_tang") = "") Then
                myKeys.Ghi("ib_grid_di_dv_gia_tang", "False")
            End If

            If (myKeys.Doc("ib_grid_di_ghi_chu") Is Nothing Or myKeys.Doc("ib_grid_di_ghi_chu") = "") Then
                myKeys.Ghi("ib_grid_di_ghi_chu", "False")
            End If

            If (myKeys.Doc("ib_grid_di_kien_so") Is Nothing Or myKeys.Doc("ib_grid_di_kien_so") = "") Then
                myKeys.Ghi("ib_grid_di_kien_so", "False")
            End If

            If (myKeys.Doc("ib_grid_di_le_phi_hq") Is Nothing Or myKeys.Doc("ib_grid_di_le_phi_hq") = "") Then
                myKeys.Ghi("ib_grid_di_le_phi_hq", "False")
            End If

            If (myKeys.Doc("ib_grid_di_loai_hang_hoa") Is Nothing Or myKeys.Doc("ib_grid_di_loai_hang_hoa") = "") Then
                myKeys.Ghi("ib_grid_di_loai_hang_hoa", "False")
            End If

            If (myKeys.Doc("ib_grid_di_ly_do_vao_hq") Is Nothing Or myKeys.Doc("ib_grid_di_ly_do_vao_hq") = "") Then
                myKeys.Ghi("ib_grid_di_ly_do_vao_hq", "False")
            End If

            If (myKeys.Doc("ib_grid_di_nguoi_gui") Is Nothing Or myKeys.Doc("ib_grid_di_nguoi_gui") = "") Then
                myKeys.Ghi("ib_grid_di_nguoi_gui", "False")
            End If

            If (myKeys.Doc("ib_grid_di_nguoi_nhan") Is Nothing Or myKeys.Doc("ib_grid_di_nguoi_nhan") = "") Then
                myKeys.Ghi("ib_grid_di_nguoi_nhan", "False")
            End If

            If (myKeys.Doc("ib_grid_di_so_bien_lai") Is Nothing Or myKeys.Doc("ib_grid_di_so_bien_lai") = "") Then
                myKeys.Ghi("ib_grid_di_so_bien_lai", "False")
            End If

            If (myKeys.Doc("ib_grid_di_so_tkhq") Is Nothing Or myKeys.Doc("ib_grid_di_so_tkhq") = "") Then
                myKeys.Ghi("ib_grid_di_so_tkhq", "False")
            End If

            If (myKeys.Doc("ib_grid_di_thue_nk") Is Nothing Or myKeys.Doc("ib_grid_di_thue_nk") = "") Then
                myKeys.Ghi("ib_grid_di_thue_nk", "False")
            End If

            If (myKeys.Doc("ib_grid_di_thue_nk_vat") Is Nothing Or myKeys.Doc("ib_grid_di_thue_nk_vat") = "") Then
                myKeys.Ghi("ib_grid_di_thue_nk_vat", "False")
            End If

            If (myKeys.Doc("ib_grid_di_thue_vat") Is Nothing Or myKeys.Doc("ib_grid_di_thue_vat") = "") Then
                myKeys.Ghi("ib_grid_di_thue_vat", "False")
            End If

            If (myKeys.Doc("inbc37denkhidongf") Is Nothing Or myKeys.Doc("inbc37denkhidongf") = "") Then
                myKeys.Ghi("inbc37denkhidongf", "False")
            End If

            If (myKeys.Doc("inbc37dikhidongf") Is Nothing Or myKeys.Doc("inbc37dikhidongf") = "") Then
                myKeys.Ghi("inbc37dikhidongf", "False")
            End If

            If (myKeys.Doc("ine4") Is Nothing Or myKeys.Doc("ine4") = "") Then
                myKeys.Ghi("ine4", "False")
            End If

            If (myKeys.Doc("inkhidonge2den") Is Nothing Or myKeys.Doc("inkhidonge2den") = "") Then
                myKeys.Ghi("inkhidonge2den", "False")
            End If

            If (myKeys.Doc("inkhidonge2di") Is Nothing Or myKeys.Doc("inkhidonge2di") = "") Then
                myKeys.Ghi("inkhidonge2di", "False")
            End If

            If (myKeys.Doc("iob_grid_di_dia_chi_nhan") Is Nothing Or myKeys.Doc("iob_grid_di_dia_chi_nhan") = "") Then
                myKeys.Ghi("iob_grid_di_dia_chi_nhan", "False")
            End If

            If (myKeys.Doc("iob_grid_di_dia_chi_nhan") Is Nothing Or myKeys.Doc("iob_grid_di_dia_chi_nhan") = "") Then
                myKeys.Ghi("iob_grid_di_dia_chi_nhan", "False")
            End If

            If (myKeys.Doc("ip_ora") Is Nothing Or myKeys.Doc("ip_ora") = "") Then
                myKeys.Ghi("ip_ora", "10.10.59.4")
            End If

            If (myKeys.Doc("ipdatabase") Is Nothing Or myKeys.Doc("ipdatabase") = "") Then
                myKeys.Ghi("ipdatabase", "192.168.68.18")
            End If

            If (myKeys.Doc("namedatabase") Is Nothing Or myKeys.Doc("namedatabase") = "") Then
                myKeys.Ghi("namedatabase", "IDE_International")
            End If

            If (myKeys.Doc("ob_grid_den_bc_ch_di") Is Nothing Or myKeys.Doc("ob_grid_den_bc_ch_di") = "") Then
                myKeys.Ghi("ob_grid_den_bc_ch_di", "False")
            End If

            If (myKeys.Doc("ob_grid_den_cuoc_dv") Is Nothing Or myKeys.Doc("ob_grid_den_cuoc_dv") = "") Then
                myKeys.Ghi("ob_grid_den_cuoc_dv", "False")
            End If

            If (myKeys.Doc("ob_grid_den_cuoc_e1") Is Nothing Or myKeys.Doc("ob_grid_den_cuoc_e1") = "") Then
                myKeys.Ghi("ob_grid_den_cuoc_e1", "False")
            End If

            If (myKeys.Doc("ob_grid_den_dia_chi_gui") Is Nothing Or myKeys.Doc("ob_grid_den_dia_chi_gui") = "") Then
                myKeys.Ghi("ob_grid_den_dia_chi_gui", "False")
            End If

            If (myKeys.Doc("ob_grid_den_dia_chi_nhan") Is Nothing Or myKeys.Doc("ob_grid_den_dia_chi_nhan") = "") Then
                myKeys.Ghi("ob_grid_den_dia_chi_nhan", "False")
            End If

            If (myKeys.Doc("ob_grid_den_dien_thoai_nhan") Is Nothing Or myKeys.Doc("ob_grid_den_dien_thoai_nhan") = "") Then
                myKeys.Ghi("ob_grid_den_dien_thoai_nhan", "False")
            End If

            If (myKeys.Doc("ob_grid_den_dv_cong_them") Is Nothing Or myKeys.Doc("ob_grid_den_dv_cong_them") = "") Then
                myKeys.Ghi("ob_grid_den_dv_cong_them", "False")
            End If

            If (myKeys.Doc("ob_grid_den_dv_gia_tang") Is Nothing Or myKeys.Doc("ob_grid_den_dv_gia_tang") = "") Then
                myKeys.Ghi("ob_grid_den_dv_gia_tang", "False")
            End If

            If (myKeys.Doc("ob_grid_den_ghi_chu") Is Nothing Or myKeys.Doc("ob_grid_den_ghi_chu") = "") Then
                myKeys.Ghi("ob_grid_den_ghi_chu", "False")
            End If

            If (myKeys.Doc("ob_grid_den_kien_so") Is Nothing Or myKeys.Doc("ob_grid_den_kien_so") = "") Then
                myKeys.Ghi("ob_grid_den_kien_so", "False")
            End If

            If (myKeys.Doc("ob_grid_den_le_phi_hq") Is Nothing Or myKeys.Doc("ob_grid_den_le_phi_hq") = "") Then
                myKeys.Ghi("ob_grid_den_le_phi_hq", "False")
            End If

            If (myKeys.Doc("ob_grid_den_loai_hang_hoa") Is Nothing Or myKeys.Doc("ob_grid_den_loai_hang_hoa") = "") Then
                myKeys.Ghi("ob_grid_den_loai_hang_hoa", "False")
            End If

            If (myKeys.Doc("ob_grid_den_nguoi_gui") Is Nothing Or myKeys.Doc("ob_grid_den_nguoi_gui") = "") Then
                myKeys.Ghi("ob_grid_den_nguoi_gui", "False")
            End If

            If (myKeys.Doc("ob_grid_den_nguoi_nhan") Is Nothing Or myKeys.Doc("ob_grid_den_nguoi_nhan") = "") Then
                myKeys.Ghi("ob_grid_den_nguoi_nhan", "False")
            End If

            If (myKeys.Doc("ob_grid_den_so_bien_lai") Is Nothing Or myKeys.Doc("ob_grid_den_so_bien_lai") = "") Then
                myKeys.Ghi("ob_grid_den_so_bien_lai", "False")
            End If

            If (myKeys.Doc("ob_grid_den_so_tkhq") Is Nothing Or myKeys.Doc("ob_grid_den_so_tkhq") = "") Then
                myKeys.Ghi("ob_grid_den_so_tkhq", "False")
            End If

            If (myKeys.Doc("ob_grid_den_thue_nk") Is Nothing Or myKeys.Doc("ob_grid_den_thue_nk") = "") Then
                myKeys.Ghi("ob_grid_den_thue_nk", "False")
            End If

            If (myKeys.Doc("ob_grid_den_thue_nk_vat") Is Nothing Or myKeys.Doc("ob_grid_den_thue_nk_vat") = "") Then
                myKeys.Ghi("ob_grid_den_thue_nk_vat", "False")
            End If

            If (myKeys.Doc("ob_grid_den_thue_vat") Is Nothing Or myKeys.Doc("ob_grid_den_thue_vat") = "") Then
                myKeys.Ghi("ob_grid_den_thue_vat", "False")
            End If

            If (myKeys.Doc("ob_in_bv10") Is Nothing Or myKeys.Doc("ob_in_bv10") = "") Then
                myKeys.Ghi("ob_in_bv10", "False")
            End If

            If (myKeys.Doc("ob_in_cn35") Is Nothing Or myKeys.Doc("ob_in_cn35") = "") Then
                myKeys.Ghi("ob_in_cn35", "False")
            End If

            If (myKeys.Doc("ob_in_cn37") Is Nothing Or myKeys.Doc("ob_in_cn37") = "") Then
                myKeys.Ghi("ob_in_cn37", "False")
            End If

            If (myKeys.Doc("ob_in_cn38") Is Nothing Or myKeys.Doc("ob_in_cn38") = "") Then
                myKeys.Ghi("ob_in_cn38", "False")
            End If

            If (myKeys.Doc("ob_in_despatch_manifest") Is Nothing Or myKeys.Doc("ob_in_despatch_manifest") = "") Then
                myKeys.Ghi("ob_in_despatch_manifest", "False")
            End If

            If (myKeys.Doc("ob_in_receptacle_manifest") Is Nothing Or myKeys.Doc("ob_in_receptacle_manifest") = "") Then
                myKeys.Ghi("ob_in_receptacle_manifest", "False")
            End If

            If (myKeys.Doc("ob_in_recmanifest") Is Nothing Or myKeys.Doc("ob_in_recmanifest") = "") Then
                myKeys.Ghi("ob_in_recmanifest", "False")
            End If

            If (myKeys.Doc("ob_so_ban_bv10") Is Nothing Or myKeys.Doc("ob_so_ban_bv10") = "") Then
                myKeys.Ghi("ob_so_ban_bv10", "1")
            End If

            If (myKeys.Doc("ob_so_ban_cn37") Is Nothing Or myKeys.Doc("ob_so_ban_cn37") = "") Then
                myKeys.Ghi("ob_so_ban_cn37", "1")
            End If

            If (myKeys.Doc("ob_so_ban_cn38") Is Nothing Or myKeys.Doc("ob_so_ban_cn38") = "") Then
                myKeys.Ghi("ob_so_ban_cn38", "1")
            End If

            If (myKeys.Doc("ob_so_ban_desmanifest") Is Nothing Or myKeys.Doc("ob_so_ban_desmanifest") = "") Then
                myKeys.Ghi("ob_so_ban_desmanifest", "1")
            End If

            If (myKeys.Doc("ob_so_ban_recmanifest") Is Nothing Or myKeys.Doc("ob_so_ban_recmanifest") = "") Then
                myKeys.Ghi("ob_so_ban_recmanifest", "1")
            End If

            If (myKeys.Doc("ob_trongluong_votui_di") Is Nothing Or myKeys.Doc("ob_trongluong_votui_di") = "") Then
                myKeys.Ghi("ob_trongluong_votui_di", "300")
            End If

            If (myKeys.Doc("pass_ora") Is Nothing Or myKeys.Doc("pass_ora") = "") Then
                myKeys.Ghi("pass_ora", "")
            End If

            If (myKeys.Doc("passdatabase") Is Nothing Or myKeys.Doc("passdatabase") = "") Then
                myKeys.Ghi("passdatabase", "")
            End If

            If (myKeys.Doc("servicename") Is Nothing Or myKeys.Doc("servicename") = "") Then
                myKeys.Ghi("servicename", "")
            End If

            If (myKeys.Doc("sobanbc37den") Is Nothing Or myKeys.Doc("sobanbc37den") = "") Then
                myKeys.Ghi("sobanbc37den", "1")
            End If

            If (myKeys.Doc("sobanbc37di") Is Nothing Or myKeys.Doc("sobanbc37di") = "") Then
                myKeys.Ghi("sobanbc37di", "1")
            End If

            If (myKeys.Doc("sobane2den") Is Nothing Or myKeys.Doc("sobane2den") = "") Then
                myKeys.Ghi("sobane2den", "1")
            End If

            If (myKeys.Doc("sobane2di") Is Nothing Or myKeys.Doc("sobane2di") = "") Then
                myKeys.Ghi("sobane2di", "1")
            End If

            If (myKeys.Doc("ten_ora") Is Nothing Or myKeys.Doc("ten_ora") = "") Then
                myKeys.Ghi("ten_ora", "")
            End If

            If (myKeys.Doc("trongluongtuiden") Is Nothing Or myKeys.Doc("trongluongtuiden") = "") Then
                myKeys.Ghi("trongluongtuiden", "300")
            End If

            If (myKeys.Doc("trongluongtuidi") Is Nothing Or myKeys.Doc("trongluongtuidi") = "") Then
                myKeys.Ghi("trongluongtuidi", "300")
            End If

            If (myKeys.Doc("userdatabase") Is Nothing Or myKeys.Doc("userdatabase") = "") Then
                myKeys.Ghi("userdatabase", "")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Write_LogInFo_To_Reg"
    Private Sub Write_LogInFo_To_Reg()
        Dim mykeys As New ModifyRegistry
        mykeys.Ghi("GTen_Dang_Nhap", IIf(txtDangNhap.Text <> "", txtDangNhap.Text, ""))
        mykeys.Ghi("GBuu_Cuc_Khai_Thac", IIf(cbBuuCuc.Text <> "", cbBuuCuc.Text, ""))

    End Sub
#End Region

#Region "Get_UserName_From_Reg"
    Private Function Get_UserName_From_Reg() As String
        Dim mykeys As New ModifyRegistry
        Return IIf(mykeys.Doc("GTen_Dang_Nhap") Is Nothing Or mykeys.Doc("GTen_Dang_Nhap") = "", "", mykeys.Doc("GTen_Dang_Nhap"))
    End Function
#End Region

#Region "Get_BCKT_From_Reg"
    Private Function Get_BCKT_From_Reg() As String
        Dim mykeys As New ModifyRegistry
        Return IIf(mykeys.Doc("GBuu_Cuc_Khai_Thac") Is Nothing Or mykeys.Doc("GBuu_Cuc_Khai_Thac") = "", "", mykeys.Doc("GBuu_Cuc_Khai_Thac"))
    End Function
#End Region

#Region "GetField"
    Private Function GetField(ByVal obj As Object, ByVal fieldName As String) As Object
        Dim fi As System.Reflection.FieldInfo
        fi = obj.GetType().GetField(fieldName, Reflection.BindingFlags.Instance Or Reflection.BindingFlags.Public Or Reflection.BindingFlags.NonPublic)
        Return fi.GetValue(obj)
    End Function
#End Region

#Region "GetKeys"
    Private Sub GetKeys()
        Dim mykeys As New ModifyRegistry
        GSo_Ngay_E1_Duoc_Trung = IIf(mykeys.Doc("GSo_Ngay_E1_Duoc_Trung") Is Nothing Or mykeys.Doc("GSo_Ngay_E1_Duoc_Trung") = "", "0", mykeys.Doc("GSo_Ngay_E1_Duoc_Trung"))
        GTrong_Luong_E1_Max = IIf(mykeys.Doc("GTrong_Luong_E1_Max") Is Nothing Or mykeys.Doc("GTrong_Luong_E1_Max") = "", "30000", mykeys.Doc("GTrong_Luong_E1_Max"))
        GThu_Muc_In_BC37_QT_Den = IIf(mykeys.Doc("GThu_Muc_In_BC37_QT_Den") Is Nothing Or mykeys.Doc("GThu_Muc_In_BC37_QT_Den") = "", "", CStr(mykeys.Doc("GThu_Muc_In_BC37_QT_Den")))
        GThu_Muc_In_BV10_QT_Den = IIf(mykeys.Doc("GThu_Muc_In_BV10_QT_Den") Is Nothing Or mykeys.Doc("GThu_Muc_In_BV10_QT_Den") = "", "", CStr(mykeys.Doc("GThu_Muc_In_BV10_QT_Den")))
        GThu_Muc_In_E4_QT_Den = IIf(mykeys.Doc("GThu_Muc_In_E4_QT_Den") Is Nothing Or mykeys.Doc("GThu_Muc_In_E4_QT_Den") = "", "", CStr(mykeys.Doc("GThu_Muc_In_E4_QT_Den")))
        GThu_Muc_In_E2_QT_Den = IIf(mykeys.Doc("GThu_Muc_In_E2_QT_Den") Is Nothing Or mykeys.Doc("GThu_Muc_In_E2_QT_Den") = "", "", CStr(mykeys.Doc("GThu_Muc_In_E2_QT_Den")))

        GIn_Kim_QT_Den = IIf(mykeys.Doc("GIn_Kim_QT_Den") Is Nothing Or mykeys.Doc("GIn_Kim_QT_Den") = "", "False", mykeys.Doc("GIn_Kim_QT_Den"))
        GIn_Laser_QT_Den = IIf(mykeys.Doc("GIn_Laser_QT_Den") Is Nothing Or mykeys.Doc("GIn_Laser_QT_Den") = "", "False", mykeys.Doc("GIn_Laser_QT_Den"))

        GKieu_In_Map = IIf(mykeys.Doc("GKieu_In_Map") Is Nothing Or mykeys.Doc("GKieu_In_Map") = "", "False", mykeys.Doc("GKieu_In_Map"))


        GThu_Muc_In_CN35_QT_Di = IIf(mykeys.Doc("GThu_Muc_In_CN35_QT_Di") Is Nothing Or mykeys.Doc("GThu_Muc_In_CN35_QT_Di") = "", "", CStr(mykeys.Doc("GThu_Muc_In_CN35_QT_Di")))
        GTen_May_Tinh_CN35 = IIf(mykeys.Doc("GTen_May_Tinh_CN35") Is Nothing Or mykeys.Doc("GTen_May_Tinh_CN35") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_CN35")))
        GTen_May_In_CN35 = IIf(mykeys.Doc("GTen_May_In_CN35") Is Nothing Or mykeys.Doc("GTen_May_In_CN35") = "", "", CStr(mykeys.Doc("GTen_May_In_CN35")))

        GTen_May_Tinh_BC37 = IIf(mykeys.Doc("GTen_May_Tinh_BC37") Is Nothing Or mykeys.Doc("GTen_May_Tinh_BC37") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_BC37")))
        GTen_May_In_BC37 = IIf(mykeys.Doc("GTen_May_In_BC37") Is Nothing Or mykeys.Doc("GTen_May_In_BC37") = "", "", CStr(mykeys.Doc("GTen_May_In_BC37")))

        GTen_May_Tinh_BV10 = IIf(mykeys.Doc("GTen_May_Tinh_BV10") Is Nothing Or mykeys.Doc("GTen_May_Tinh_BV10") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_BV10")))
        GTen_May_In_BV10 = IIf(mykeys.Doc("GTen_May_In_BV10") Is Nothing Or mykeys.Doc("GTen_May_In_BV10") = "", "", CStr(mykeys.Doc("GTen_May_In_BV10")))

        GTen_May_Tinh_E2 = IIf(mykeys.Doc("GTen_May_Tinh_E2") Is Nothing Or mykeys.Doc("GTen_May_Tinh_E2") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_E2")))
        GTen_May_In_E2 = IIf(mykeys.Doc("GTen_May_In_E2") Is Nothing Or mykeys.Doc("GTen_May_In_E2") = "", "", CStr(mykeys.Doc("GTen_May_In_E2")))

        GTen_May_Tinh_E4 = IIf(mykeys.Doc("GTen_May_Tinh_E4") Is Nothing Or mykeys.Doc("GTen_May_Tinh_E4") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_E4")))
        GTen_May_In_E4 = IIf(mykeys.Doc("GTen_May_In_E4") Is Nothing Or mykeys.Doc("GTen_May_In_E4") = "", "", CStr(mykeys.Doc("GTen_May_In_E4")))

        'Them phan in CN38
        GIn_Kim_QT_Di_CN38 = IIf(mykeys.Doc("GIn_Kim_QT_Di_CN38") Is Nothing Or mykeys.Doc("GIn_Kim_QT_Di_CN38") = "", "False", mykeys.Doc("GIn_Kim_QT_Di_CN38"))
        GIn_Laser_QT_Di_CN38 = IIf(mykeys.Doc("GIn_Laser_QT_Di_CN38") Is Nothing Or mykeys.Doc("GIn_Laser_QT_Di_CN38") = "", "False", mykeys.Doc("GIn_Laser_QT_Di_CN38"))
        GKieu_In_Map_CN38 = IIf(mykeys.Doc("GKieu_In_Map_CN38") Is Nothing Or mykeys.Doc("GKieu_In_Map_CN38") = "", "False", mykeys.Doc("GKieu_In_Map_CN38"))

        GThu_Muc_In_CN38_QT_Di = IIf(mykeys.Doc("GThu_Muc_In_CN38_QT_Di") Is Nothing Or mykeys.Doc("GThu_Muc_In_CN38_QT_Di") = "", "", CStr(mykeys.Doc("GThu_Muc_In_CN38_QT_Di")))
        GTen_May_Tinh_CN38 = IIf(mykeys.Doc("GTen_May_Tinh_CN38") Is Nothing Or mykeys.Doc("GTen_May_Tinh_CN38") = "", "", CStr(mykeys.Doc("GTen_May_Tinh_CN38")))
        GTen_May_In_CN38 = IIf(mykeys.Doc("GTen_May_In_CN38") Is Nothing Or mykeys.Doc("GTen_May_In_CN38") = "", "", CStr(mykeys.Doc("GTen_May_In_CN38")))

        'Cho phép sửa cước
        gSua_Cuoc_Chinh = IIf(mykeys.Doc("GSua_Cuoc_Chinh") Is Nothing Or mykeys.Doc("GSua_Cuoc_Chinh") = "", "False", CStr(mykeys.Doc("GSua_Cuoc_Chinh")))
        gSua_Cuoc_DV = IIf(mykeys.Doc("GSua_Cuoc_DV") Is Nothing Or mykeys.Doc("GSua_Cuoc_DV") = "", "False", CStr(mykeys.Doc("GSua_Cuoc_DV")))
        gSua_Cuoc_E1 = IIf(mykeys.Doc("GSua_Cuoc_E1") Is Nothing Or mykeys.Doc("GSua_Cuoc_E1") = "", "False", CStr(mykeys.Doc("GSua_Cuoc_E1")))
    End Sub
#End Region

#Region "txtDangNhap_KeyDown"
    Private Sub txtDangNhap_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDangNhap.KeyDown, txtMatKhau.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "cbBuuCuc_KeyDown"
    Private Sub cbBuuCuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbBuuCuc.KeyDown
        Select Case e.KeyValue
            Case Keys.Enter 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "CreatePrintFolder"
    Private Sub CreatePrintFolder()
        Const BC37_PATH_TMP As String = "C:\EMS_INTERNATIONAL\BC37\"
        Const E2_PATH_TMP As String = "C:\EMS_INTERNATIONAL\E2\"
        Const E4_PATH_TMP As String = "C:\EMS_INTERNATIONAL\E4\"
        Const CN35_PATH_TMP As String = "C:\EMS_INTERNATIONAL\CN35\"
        Const BV10_PATH_TMP As String = "C:\EMS_INTERNATIONAL\BV10\"
        Const KETOAN_PATH_TMP As String = "C:\EMS_INTERNATIONAL\KeToanQT\"
        Const CN38_PATH_TMP As String = "C:\EMS_INTERNATIONAL\CN38\"

        'Thu muc BC37
        If Directory.Exists(BC37_PATH_TMP) = False Then
            Directory.CreateDirectory(BC37_PATH_TMP)
        End If
        'Thu muc E2
        If Directory.Exists(E2_PATH_TMP) = False Then
            Directory.CreateDirectory(E2_PATH_TMP)
        End If
        'Thu muc E4
        If Directory.Exists(E4_PATH_TMP) = False Then
            Directory.CreateDirectory(E4_PATH_TMP)
        End If
        'Thu muc CN35
        If Directory.Exists(CN35_PATH_TMP) = False Then
            Directory.CreateDirectory(CN35_PATH_TMP)
        End If
        'Thu muc CN38
        If Directory.Exists(CN38_PATH_TMP) = False Then
            Directory.CreateDirectory(CN38_PATH_TMP)
        End If
        'Thu muc BV10
        If Directory.Exists(BV10_PATH_TMP) = False Then
            Directory.CreateDirectory(BV10_PATH_TMP)
        End If
        'Thu muc chua du lieu Ke toan quoc te
        If Directory.Exists(KETOAN_PATH_TMP) = False Then
            Directory.CreateDirectory(KETOAN_PATH_TMP)
        End If
    End Sub
#End Region

#Region "Create_Predes_Folder"
    Private Sub Create_Predes_Folder()
        Dim Predes_PATH_TMP As String
        Predes_PATH_TMP = Application.StartupPath & "\Predes\"
        'Thu muc Predes
        If Directory.Exists(Predes_PATH_TMP) = False Then
            Directory.CreateDirectory(Predes_PATH_TMP)
        End If
    End Sub
#End Region

#Region "Khác"
#Region "btnProcess_Click"
    'Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim myData As DataTable
    '    Dim myReport As New rptE1
    '    Dim myE1_Di As New E1_Di(GConnectionString)
    '    Dim i, rawKind As Integer

    '    Dim FrmView As New FrmViewReports
    '    'myData = myE1_Di.E1_Di_Hoa_Don(txtB.Text).Tables(0)
    '    myReport.SetDataSource(myData)
    '    'myReport.PrintOptions.PrinterName = "\\192.168.75.85\MAYINKIM"
    '    'myReport.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Manual
    '    Dim printDoc As New System.Drawing.Printing.PrintDocument
    '    For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
    '        If printDoc.PrinterSettings.PaperSizes(i).PaperName.ToString.ToUpper = "E1" Then
    '            rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
    '            PageSetupDialog1.PageSettings.PaperSize = printDoc.PrinterSettings.PaperSizes(i)
    '            Exit For
    '        End If
    '    Next
    '    Dim rpInvoice As ReportClass
    '    rpInvoice = myReport
    '    rpInvoice.PrintOptions.PrinterName = "\\192.168.75.85\MAYINKIM"
    '    rpInvoice.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Manual
    '    rpInvoice.PrintOptions.PaperOrientation = PaperOrientation.Portrait
    '    rpInvoice.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)

    '    rpInvoice.Refresh()

    '    'myReport.PrintToPrinter(1, False, 1, 1)
    '    'myReport.PrintOptions.PaperSize = rawKind
    '    'rptmyE1.PrintOptions.PrinterName = "\\192.168.75.95\mayinkim"
    '    'rptmyE1.PrintOptions.PaperSize = PaperSize.DefaultPaperSize

    '    FrmView.CrystalReportViewer1.ReportSource = rpInvoice
    '    Cursor.Current = Cursors.Default
    '    FrmView.ShowDialog()
    'End Sub
#End Region
#End Region

#Region "lblUpdate_Click"
    Private Sub lblUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUpdate.Click
        'Close()
        'Dispose()
        'Dim Frm As New Frm_Update
        'Frm.ShowDialog()
        'Exit Sub
        If FileExists(Application.StartupPath, "EMS_Update.exe") Then
            Directory.SetCurrentDirectory(Application.StartupPath)
            Dim myProcess As Process = New Process
            myProcess.StartInfo.FileName = "Ems_Update.exe"
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.Start()
            myProcess.Close()
            Application.Exit()
        Else
            MessageBox.Show("Không tồn tại file cập nhật chương trình!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "FileExists"
    Private Function FileExists(ByVal Path As String, ByVal FileName As String) As Boolean
        Try
            Dim MyFile As New FileInfo(Path & "\" & FileName)
            If MyFile.Exists Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim aa As New FrmGioiThieuChuongTrinh
        aa.ShowDialog()
    End Sub
End Class


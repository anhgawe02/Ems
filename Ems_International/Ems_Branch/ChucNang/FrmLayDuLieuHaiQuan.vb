Imports System.Data.OracleClient
Imports Ems_International_Logic.EMS
Public Class FrmLayDuLieuHaiQuan
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
    Friend WithEvents BtnLayDuLieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents OptTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents OptTheo_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnLayDuLieuTrenOracle As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLayDuLieuHaiQuan))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Tinh")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khu_Vuc")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Thoa_Thuan")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Tinh")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khu_Vuc")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Thoa_Thuan")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh_Theo_Duong_Thu", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Tinh")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khu_Vuc")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Thoa_Thuan")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.BtnLayDuLieu = New Infragistics.Win.Misc.UltraButton
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.OptTat_Ca = New System.Windows.Forms.RadioButton
        Me.OptTheo_Tinh = New System.Windows.Forms.RadioButton
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.btnLayDuLieuTrenOracle = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLayDuLieu
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.BtnLayDuLieu.Appearance = Appearance1
        Me.BtnLayDuLieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLayDuLieu.Location = New System.Drawing.Point(272, 200)
        Me.BtnLayDuLieu.Name = "BtnLayDuLieu"
        Me.BtnLayDuLieu.Size = New System.Drawing.Size(120, 32)
        Me.BtnLayDuLieu.TabIndex = 58
        Me.BtnLayDuLieu.Text = "Lấy dữ liệu"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        Me.UltraDataSource1.Band.Key = "Duong_Thu_Di_Den"
        '
        'UltraDataSource4
        '
        UltraDataColumn5.DataType = GetType(System.Int16)
        UltraDataColumn7.DataType = GetType(System.Int16)
        UltraDataColumn8.DataType = GetType(System.Boolean)
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        Me.UltraDataSource4.Band.Key = "Ma_Tinh_Theo_Duong_Thu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMa_Tinh)
        Me.GroupBox1.Controls.Add(Me.UltraLabel3)
        Me.GroupBox1.Controls.Add(Me.CbDen_Ngay)
        Me.GroupBox1.Controls.Add(Me.UltraLabel4)
        Me.GroupBox1.Controls.Add(Me.CbTu_Ngay)
        Me.GroupBox1.Controls.Add(Me.OptTat_Ca)
        Me.GroupBox1.Controls.Add(Me.OptTheo_Tinh)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(96, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 128)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin tỉnh cần kế toán"
        '
        'cbMa_Tinh
        '
        Me.cbMa_Tinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Tinh.DataSource = Me.UltraDataSource4
        UltraGridColumn1.Header.Caption = "Mã tỉnh"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên tỉnh"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Khu vực"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Thoả thuận"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.cbMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbMa_Tinh.DisplayMember = "Ten_Tinh"
        Me.cbMa_Tinh.Location = New System.Drawing.Point(208, 80)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(176, 24)
        Me.cbMa_Tinh.TabIndex = 4
        Me.cbMa_Tinh.ValueMember = "Ma_Tinh"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(208, 36)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel3.TabIndex = 66
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(288, 32)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbDen_Ngay.TabIndex = 1
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(16, 36)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel4.TabIndex = 65
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(88, 32)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbTu_Ngay.TabIndex = 0
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'OptTat_Ca
        '
        Me.OptTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTat_Ca.Location = New System.Drawing.Point(16, 80)
        Me.OptTat_Ca.Name = "OptTat_Ca"
        Me.OptTat_Ca.Size = New System.Drawing.Size(88, 24)
        Me.OptTat_Ca.TabIndex = 2
        Me.OptTat_Ca.Text = "Tất cả"
        '
        'OptTheo_Tinh
        '
        Me.OptTheo_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTheo_Tinh.Location = New System.Drawing.Point(128, 80)
        Me.OptTheo_Tinh.Name = "OptTheo_Tinh"
        Me.OptTheo_Tinh.Size = New System.Drawing.Size(80, 24)
        Me.OptTheo_Tinh.TabIndex = 3
        Me.OptTheo_Tinh.Text = "Theo tỉnh"
        '
        'BtnExit
        '
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.BtnExit.Appearance = Appearance3
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(456, 192)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 60
        Me.BtnExit.Text = "Exit"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        Me.UltraDataSource2.Band.Key = "Ma_Tinh_Theo_Duong_Thu"
        '
        'btnLayDuLieuTrenOracle
        '
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnLayDuLieuTrenOracle.Appearance = Appearance4
        Me.btnLayDuLieuTrenOracle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLayDuLieuTrenOracle.Location = New System.Drawing.Point(16, 192)
        Me.btnLayDuLieuTrenOracle.Name = "btnLayDuLieuTrenOracle"
        Me.btnLayDuLieuTrenOracle.Size = New System.Drawing.Size(168, 32)
        Me.btnLayDuLieuTrenOracle.TabIndex = 62
        Me.btnLayDuLieuTrenOracle.Text = "Lấy dữ liệu trên Oracle"
        '
        'FrmLayDuLieuHaiQuan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 273)
        Me.Controls.Add(Me.btnLayDuLieuTrenOracle)
        Me.Controls.Add(Me.BtnLayDuLieu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "FrmLayDuLieuHaiQuan"
        Me.Text = "FrmLayDuLieuHaiQuan"
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim Str_Connect_Oracle As String
    'Dim Connect_Oracle_EMSKHAITHAC As ADODB.Connection

    'Connect Oracle DataBase
    'Call Store Oracle lấy dữ liệu về EMS quốc tế trong bảng E1I1
    'Insert dữ liệu từ bảng E1I1_Oracle vào bảng E1I1 (trong SQL)
    'Khai báo biến
    '    Dim myE1_Le_Phi_Di As New E1_Le_Phi_Di(GConnectionString)
    '    Dim myE1_Le_Phi_Di_Chi_Tiet As New E1_Le_Phi_Di_Chi_Tiet

    '    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    '    Dim myTu_Ngay As Integer
    '    Dim myDen_Ngay As Integer

    '    Dim myMa_Tinh As Integer

    '#Region "Connect Oracle DataBase"
    '    Private Function ConnectOracleDataBase() As Boolean
    '        Dim myKeys As New ModifyRegistry
    '        'Kiểm tra việc đã cấu hình DataBase Oracle chưa
    '        'If myKeys.Doc("IpDataBaseOracle") Is Nothing Then
    '        '    Dim frm As New FrmCauHinhCoSoDuLieu
    '        '    frm.ShowDialog()
    '        'End If
    '        Dim Str As String
    '        Dim Str_Connect_Oracle As String

    '        If Not myKeys.Doc("IpDataBaseOracle") Is Nothing Then
    '            Str_Connect_Oracle = "Provider=OraOLEDB.Oracle;"

    '            Str = myKeys.Doc("IpDataBaseOracle")
    '            Str_Connect_Oracle = Str_Connect_Oracle & "Data Source = " & Str & ";"

    '            Str = myKeys.Doc("UserDataBaseOracle")
    '            Str_Connect_Oracle = Str_Connect_Oracle & "User ID=" & Str & ";"

    '            Str = Decrypt(myKeys.Doc("PassDataBaseOracle"), "ems")
    '            Str_Connect_Oracle = Str_Connect_Oracle & "Password=" & Str
    '            If TestConnection_Oracle(GConnectionString) Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Else 'Nếu không có thì sử dụng chuỗi mặc định
    '            Str_Connect_Oracle = "Provider=OraOLEDB.Oracle;Password=ems;Persist Security Info=True;User ID=ems;Data Source=192.168.68.4"
    '        End If
    '        TestConnection_Oracle(Str_Connect_Oracle)
    '        'Connect_Oracle_EMSKHAITHAC.Open(Str_Connect_Oracle)
    '        'Str_Connect_Oracle = "Provider=OraOLEDB.Oracle;Password=ems;Persist Security Info=True;User ID=ems;Data Source=192.168.68.4"
    '        Return True
    '    End Function

    '    Public Function TestConnection_Oracle(ByVal strInput As String) As Boolean
    '        'Try
    '        '    Dim myCuoc As New Cuoc_TN(strInput)
    '        '    If myCuoc.Danh_Sach.Tables(0).Rows.Count > 0 Then
    '        '        Return True
    '        '    Else
    '        '        Return False
    '        '    End If
    '        'Catch ex As Exception
    '        '    Return False
    '        'End Try
    '    End Function
    '#End Region

    '#Region "FrmLayDuLieuHaiQuan_Load"
    '    Private Sub FrmLayDuLieuHaiQuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        ConnectOracleDataBase()
    '        'Tách dữ liệu ngoại thành
    '        Me.Text = Me.Text & " ( " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac & " )"
    '        'Khoi tao trang thai ban dau khi load Form
    '        OptTat_Ca.Checked = True
    '        OptTheo_Tinh.Checked = False
    '        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
    '        'Tu ngay = Ngay dau tien cua thang hien tai
    '        CbTu_Ngay.Value = myHam_Dung_Chung.dBeginMonth(Date.Now)
    '        'Den ngay = ngay hien tai
    '        CbDen_Ngay.Value = Now().Date
    '        'Load du lieu cho cbMa_Tinh
    '        GetMaTinh()
    '        'Dat focus vao Tu_Ngay
    '        CbTu_Ngay.Select()
    '    End Sub
    '#End Region

    '    Private Sub OptTheo_Tinh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTheo_Tinh.Validated
    '        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
    '    End Sub

    '    Private Sub OptTheo_Tinh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTheo_Tinh.CheckedChanged
    '        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
    '        If OptTheo_Tinh.Checked = True Then
    '            cbMa_Tinh.Select()
    '        End If
    '    End Sub
    '    Private Sub GetMaTinh()
    '        Dim myMa_Tinh As New Ma_Tinh(GConnectionString)
    '        Dim TblDanh_Sach_Tinh As New DataTable
    '        TblDanh_Sach_Tinh = myMa_Tinh.Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
    '        cbMa_Tinh.DataSource = TblDanh_Sach_Tinh
    '        cbMa_Tinh.DataBind()
    '        cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
    '        cbMa_Tinh.LimitToList = True
    '    End Sub

    '#Region "Cập nhật dữ liệu ngoại thành"

    '#Region "Lấy dữ liệu trên máy SQL"
    '    Public Function E1_Le_Phi_Di_Du_Lieu_Can_Tim(ByVal Ma_Tinh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

    '    End Function
    '#End Region

    '#Region "Kiểm tra dữ liệu trong Oracle có phải là ngoại thành không"
    '    Public Function E1_Le_Phi_Di_Kiem_Tra_Du_Lieu_Ngoai_Thanh(ByVal Ma_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As Boolean
    '        Try
    '            If Ma_E1 = "" Then
    '                Return False
    '            Else
    '                Return True
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        Finally

    '        End Try

    '    End Function
    '#End Region

    '#Region "Cập nhật dữ liệu trong SQL của ngoại thành và nội thành riêng"
    '    Public Sub E1_Le_Phi_Di_Cap_Nhat_Du_Lieu_Ngoai_Thanh(ByVal Ma_E1 As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer, ByVal IsNgoai_Thanh As Boolean)
    '        Try

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '#End Region
    '#End Region

    '#Region "CallStore"
    '    Private Function CallStore() As Boolean
    '        'Dim myOracleConnection As New OracleConnection("User Id=ems;Password=ems;Data Source=TUYENNV")
    '        'myOracleConnection.Open()
    '        'Dim myOracleTransaction As OracleTransaction = myOracleConnection.BeginTransaction()

    '        'Dim myOracleCommand As OracleCommand = myOracleConnection.CreateCommand()

    '        'myOracleCommand.CommandText = "INSERT INTO TABLE_TEST (NGAY,THANG,NAM) VALUES (0, 1,2)"
    '        'myOracleCommand.ExecuteNonQuery()
    '        'myOracleTransaction.Commit()
    '        'myOracleConnection.Close()


    '        'Dim Comm As ADODB.Command
    '        'Dim Prm As ADODB.Parameter
    '        'Dim cuoc As Long
    '        'Comm = New ADODB.Command
    '        'Connect_Oracle_EMSKHAITHAC = New ADODB.Connection
    '        'Connect_Oracle_EMSKHAITHAC = New OracleConnection
    '        'Connect_Oracle_EMSKHAITHAC.Open(Str_Connect_Oracle)
    '        'Comm.ActiveConnection = Connect_Oracle_EMSKHAITHAC
    '        'Comm.CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
    '        'Comm.CommandText = "Insert_Table_Test"
    '        'Prm = Comm.CreateParameter("v_ngay", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 10)
    '        'Comm.Parameters.Append(Prm)
    '        'Prm = Comm.CreateParameter("v_thang", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 20)
    '        'Comm.Parameters.Append(Prm)
    '        'Prm = Comm.CreateParameter("v_nam", ADODB.DataTypeEnum.adNumeric, ADODB.ParameterDirectionEnum.adParamInput, 10, 30)
    '        'Comm.Parameters.Append(Prm)
    '        'Comm.Execute()

    '        'Comm = Nothing
    '        'Prm = Nothing
    '        'Connect_Oracle_EMSKHAITHAC.Close()
    '    End Function
    '#End Region

    '#Region "BtnLayDuLieu_Click"
    '    Private Sub BtnLayDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLayDuLieu.Click
    '        Dim myConnectionString As String
    '        myConnectionString = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=khaithac))(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.68.4)(PORT=1521)));user id=ems;password=ems"
    '        Try
    '            'Lấy dữ liệu về ngày tháng
    '            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
    '            myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
    '            'Lấy dữ liệu về tỉnh cần so sánh số liệu
    '            myMa_Tinh = cbMa_Tinh.Value

    '            'Dim myLoai_Duong_Thu As Integer
    '            'Dim myE1I1_Oracle As New E1I1_Oracle(myConnectionString)
    '            'myLoai_Duong_Thu = myE1I1_Oracle.E1I1_Oracle_EMS_QT_Noi_Ngoai_Thanh(20081201, 20081231, "EA882046737VN")
    '            ''Kiểm tra dữ liệu của tỉnh đó có được phép lấy theo phân loại đường thư bưu tá không
    '            'Lấy dữ liệu về từng Ma_E1 theo từng myMa_Tinh trong SQL
    '            Dim myDataSet As New DataSet
    '            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
    '            Dim mye1_di As New E1_Di(GConnectionString)
    '            Dim myTable As New DataTable
    '            myTable = mye1_di.Hai_Quan_Danh_Sach_E1_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, myMa_Tinh).Tables(0)
    '            'myDataSet = myE1_Le_Phi_Di.E1_Le_Phi_Di_Tong_Hop_Le_Phi_Theo_Ma_Tinh(GBuu_Cuc_Khai_Thac, myMa_Tinh, myTu_Ngay, myDen_Ngay)
    '            Dim myTong_So_Dong As Integer
    '            myTong_So_Dong = SetNullValue(myTable.Rows.Count, 0)
    '            If myTong_So_Dong > 0 Then
    '                Dim i As Integer
    '                For i = 0 To myTong_So_Dong - 1
    '                    Dim myStartDate As Integer
    '                    Dim myEndDate As Integer
    '                    Dim myMa_E1 As String
    '                    myMa_E1 = myTable.Rows(i).Item("Ma_E1")
    '                    myStartDate = 20090101 'myTable.Rows(i).Item("Ngay_Dong")
    '                    myEndDate = myHam_Dung_Chung.AddIntDate(myStartDate, 10)
    '                    'Kiểm tra dữ liệu về Ma_E1 thuộc loại đường thư nào
    '                    Dim myLoai_Duong_Thu As Integer
    '                    Dim myE1I1_Oracle As New E1I1_Oracle(myConnectionString)
    '                    'myLoai_Duong_Thu = myE1I1_Oracle.E1I1_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(myStartDate, myEndDate, myMa_E1)
    '                    'Update dữ liệu về loại đường thư vào dữ liệu SQL

    '                Next
    '                MessageBox.Show("Đã cập nhật xong dữ liệu theo đường thư", "Thông báo", _
    '                                                MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Else
    '                MessageBox.Show("Không có dữ liệu cần cập nhật", "Thông báo", _
    '                                                                MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If

    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString)
    '            'MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật dữ liệu", "Thông báo", _
    '            '                    MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try


    '        'CallStore()
    '        'Try
    '        '    If TestConnection_Oracle(Str_Connect_Oracle) = False Then
    '        '        MessageBox.Show("Không kết nối được với cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '        Exit Sub
    '        '    End If
    '        '    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    '        '    Dim myDataSet As New DataSet
    '        '    'Lấy dữ liệu cần kiểm tra
    '        '    Dim myTu_Ngay As Integer
    '        '    Dim myDen_Ngay As Integer

    '        '    myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Text)
    '        '    myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Text)

    '        '    myDataSet = E1_Le_Phi_Di_Du_Lieu_Can_Tim(100000, myTu_Ngay, myDen_Ngay)
    '        '    If myDataSet.Tables(0).Rows.Count > 0 Then 'Nếu có dữ liệu
    '        '        Dim myMa_E1 As String
    '        '        Dim myIsNgoaiThanh As Boolean
    '        '        Dim i As Integer
    '        '        For i = 0 To myDataSet.Tables(0).Rows.Count
    '        '            myMa_E1 = myDataSet.Tables(0).Rows(i).Item("Ma_E1")
    '        '            If E1_Le_Phi_Di_Kiem_Tra_Du_Lieu_Ngoai_Thanh(myMa_E1, myTu_Ngay, myDen_Ngay) = True Then
    '        '                E1_Le_Phi_Di_Cap_Nhat_Du_Lieu_Ngoai_Thanh(myMa_E1, myTu_Ngay, myDen_Ngay, True)
    '        '            Else
    '        '                E1_Le_Phi_Di_Cap_Nhat_Du_Lieu_Ngoai_Thanh(myMa_E1, myTu_Ngay, myDen_Ngay, False)
    '        '            End If
    '        '        Next
    '        '        MessageBox.Show("Đã lấy xong dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '    Else 'nếu không có
    '        '        MessageBox.Show("Không tìm thấy dữ liệu cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        '    End If
    '        'Catch ex As Exception
    '        '    MessageBox.Show("Có lỗi xảy ra trong quá trình lấy dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        'End Try
    '    End Sub
    '#End Region

    '    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
    '        Close()
    '    End Sub


    '    Private Sub Lay_Du_Lieu_Tu_Oracle()
    '        Dim myConnectionString As String
    '        myConnectionString = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=khaithac))(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.68.4)(PORT=1521)));user id=ems;password=ems"

    '        Try
    '            'Lấy dữ liệu về ngày tháng
    '            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
    '            myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
    '            'Lấy dữ liệu về tỉnh cần so sánh số liệu
    '            Dim myDataSet As New DataSet
    '            Dim myE1I1_Oracle As New E1I1_Oracle(myConnectionString)

    '            myDataSet = myE1I1_Oracle.E1I1_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
    '            Dim myTong_So_Dong As Integer
    '            myTong_So_Dong = CInt(SetNullValue(myDataSet.Tables(0).Rows.Count, 0))
    '            If myTong_So_Dong > 0 Then
    '                Dim i As Integer
    '                For i = 0 To myTong_So_Dong - 1
    '                    'Lấy dữ liệu chi tiết
    '                    Dim myE1I1_Chi_Tiet As New E1I1_Chi_Tiet
    '                    Dim myE1I1 As New E1I1(GConnectionString)
    '                    With myE1I1_Chi_Tiet
    '                        .Ma_E1 = myDataSet.Tables(0).Rows(i).Item("Ma_E1")
    '                        .Ngay_Dong = myDataSet.Tables(0).Rows(i).Item("Ngay_Dong")
    '                        .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Khai_Thac")
    '                        .Ma_Bc = myDataSet.Tables(0).Rows(i).Item("Ma_Bc")
    '                        .Phan_Loai_Duong_Thu = myDataSet.Tables(0).Rows(i).Item("Phan_Loai_Duong_Thu")
    '                        .So_Chuyen_Thu = myDataSet.Tables(0).Rows(i).Item("So_Chuyen_Thu")
    '                        .Loai_Chuyen_Thu = myDataSet.Tables(0).Rows(i).Item("Loai_Chuyen_Thu")
    '                        .Tui_So = myDataSet.Tables(0).Rows(i).Item("Tui_So")
    '                        .Nuoc_Nhan = myDataSet.Tables(0).Rows(i).Item("Nuoc_Nhan")
    '                        .Nuoc_Tra = myDataSet.Tables(0).Rows(i).Item("Nuoc_Tra")
    '                        .Ma_Bc_Goc = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Goc")
    '                        .Ma_Bc_Tra = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Tra")
    '                        .Khoi_Luong = myDataSet.Tables(0).Rows(i).Item("Khoi_Luong")
    '                        .Phan_Loai = myDataSet.Tables(0).Rows(i).Item("Phan_Loai")
    '                        .Id_E1 = .Ma_Bc_Khai_Thac.ToString("0000000") + _
    '                                    .Ma_Bc.ToString("0000000") + _
    '                                    .Ngay_Dong.ToString + _
    '                                    .So_Chuyen_Thu.ToString + _
    '                                    .Loai_Chuyen_Thu.ToString + _
    '                                    .Tui_So.ToString + _
    '                                    .Ma_E1.ToString + _
    '                                    "0000" 'Kiện số
    '                    End With
    '                    'Insert dữ liệu vào bảng tạm trong SQL
    '                    If myE1I1_Chi_Tiet.Id_E1 <> "" Then
    '                        myE1I1.Cap_Nhat_Them_E1I1(myE1I1_Chi_Tiet.Id_E1, myE1I1_Chi_Tiet.Ma_E1, myE1I1_Chi_Tiet.Ngay_Dong, myE1I1_Chi_Tiet.Ma_Bc_Khai_Thac, myE1I1_Chi_Tiet.Ma_Bc, myE1I1_Chi_Tiet.Phan_Loai_Duong_Thu, myE1I1_Chi_Tiet.So_Chuyen_Thu, myE1I1_Chi_Tiet.Loai_Chuyen_Thu, myE1I1_Chi_Tiet.Tui_So, myE1I1_Chi_Tiet.Nuoc_Nhan, myE1I1_Chi_Tiet.Nuoc_Tra, myE1I1_Chi_Tiet.Ma_Bc_Goc, myE1I1_Chi_Tiet.Ma_Bc_Tra, myE1I1_Chi_Tiet.Khoi_Luong, myE1I1_Chi_Tiet.Phan_Loai)
    '                    End If
    '                Next
    '            Else
    '                MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '            'MessageBox.Show("dữ liệu test" & myDataSet.Tables(0).Rows(0).Item(1), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        Catch ex As Exception
    '            MessageBox.Show(ex.ToString)
    '        End Try
    '    End Sub

    '    Private Sub btnLayDuLieuTrenOracle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLayDuLieuTrenOracle.Click
    '        Lay_Du_Lieu_Tu_Oracle()
    '    End Sub


    '    Private Sub LayDuLieuDuongThuNoiTinh()
    '        Dim myConnectionString As String
    '        'myConnectionString = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=khaithac))(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.68.4)(PORT=1521)));user id=ems;password=ems"
    '        'Lấy dữ liệu về đường thư nội tỉnh trên Oracle vào bảng đường thư đi nội tỉnh
    '        'Kiểm tra xem có kết nối với Oracle không
    '        'Nếu không thì thông báo
    '        Dim myNtinh_Oracle As New Ntinh_Oracle(GOracleConnectionString)
    '        Dim myNtinh_Oracle_Chi_Tiet As New Ntinh_Oracle_Chi_Tiet

    '        Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    '        'Lấy dữ liệu từ Oracle
    '        Dim myDataSet As New DataSet
    '        Dim mySoDuongThu As Integer
    '        myDataSet = myNtinh_Oracle.Ntinh_Danh_Sach
    '        mySoDuongThu = myDataSet.Tables(0).Rows.Count
    '        If mySoDuongThu > 0 Then
    '            Dim myDuong_Thu_Di_Noi_Tinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
    '            Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet
    '            Dim i As Integer
    '            For i = 0 To mySoDuongThu
    '                With myDuong_Thu_Di_Noi_Tinh_Chi_Tiet
    '                    .Ma_Bc = SetNullValue(myDataSet.Tables(0).Rows(i).Item("Mabc"), 0)
    '                    .Ma_Bc_Khai_Thac = SetNullValue(myDataSet.Tables(0).Rows(i).Item("Mabc"), 0)
    '                    'Tìm mã tỉnh từ Ma_bc
    '                    .Ma_Tinh = myDanh_Muc_Bc.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(.Ma_Bc).Ma_Tinh 'SetNullValue(myDataSet.Tables(0).Rows(i).Item("Mabc"), 0)
    '                    .Phan_Loai_Duong_Thu = SetNullValue(myDataSet.Tables(0).Rows(i).Item("Bta"), 0)
    '                    .Ten_Duong_Thu = SetNullValue(myDataSet.Tables(0).Rows(i).Item("Tenbc"), "")
    '                    .Id_Duong_Thu = .Ma_Bc_Khai_Thac.ToString("000000") + .Ma_Bc.ToString("0000000")
    '                End With
    '                'Đẩy dữ liệu vào bảng Duong_Thu_Di_Noi_Tinh
    '                myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them(myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Id_Duong_Thu, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ten_Duong_Thu, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc_Khai_Thac, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Tinh, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Phan_Loai_Duong_Thu)
    '            Next
    '        End If
    '    End Sub
End Class

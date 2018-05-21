Imports System.Text
Imports System.Data
Imports System.IO
Imports System.Net.Dns
Imports System.Collections
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmCauHinhCoSoDuLieu
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
    Friend WithEvents txtPass As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgHeThong As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtIp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents grid_E_Shiping As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCapNhat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMatKhau As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTenDangNhap As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtAPI_Link As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDangNhap As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thong_Tin_He_Thong", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Co_So_Du_Lieu")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Co_So_Du_Lieu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dang_Nhap")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mat_Khau")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Ora")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ServiceName")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ora")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pass_Ora")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thong_Tin_He_Thong", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Co_So_Du_Lieu")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Co_So_Du_Lieu")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dang_Nhap")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mat_Khau")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtPass = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.dgHeThong = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtIp = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.grid_E_Shiping = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnCapNhat = New Infragistics.Win.Misc.UltraButton
        Me.txtMatKhau = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtTenDangNhap = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtAPI_Link = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl1 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl2 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl3 = New Infragistics.Win.Misc.UltraLabel
        Me.lblDangNhap = New Infragistics.Win.Misc.UltraLabel
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHeThong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_E_Shiping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txtMatKhau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenDangNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAPI_Link, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(216, 88)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(176, 21)
        Me.txtPass.TabIndex = 21
        Me.txtPass.Visible = False
        '
        'dgHeThong
        '
        Me.dgHeThong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgHeThong.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgHeThong.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "IP máy chủ cơ sở dữ liệu"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaskInput = ""
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Tên cơ sở dữ liệu"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(135, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Tên đăng nhập"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(105, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.EditorControl = Me.txtPass
        UltraGridColumn4.Header.Caption = "Mật khẩu"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "IP Máy Oracle"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Tên đăng nhập"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.EditorControl = Me.txtPass
        UltraGridColumn8.Header.Caption = "Mật khẩu"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgHeThong.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgHeThong.DisplayLayout.InterBandSpacing = 10
        Me.dgHeThong.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgHeThong.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgHeThong.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgHeThong.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgHeThong.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHeThong.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgHeThong.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgHeThong.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgHeThong.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgHeThong.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgHeThong.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgHeThong.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgHeThong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgHeThong.Location = New System.Drawing.Point(8, 8)
        Me.dgHeThong.Name = "dgHeThong"
        Me.dgHeThong.Size = New System.Drawing.Size(496, 120)
        Me.dgHeThong.TabIndex = 5
        Me.dgHeThong.Text = "Cấu hình kết nối DataBase"
        '
        'txtIp
        '
        Me.txtIp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtIp.InputMask = "###.###.###.###"
        Me.txtIp.Location = New System.Drawing.Point(64, 88)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.TabIndex = 22
        Me.txtIp.Text = "..."
        Me.txtIp.Visible = False
        '
        'grid_E_Shiping
        '
        Me.grid_E_Shiping.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid_E_Shiping.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.grid_E_Shiping.DisplayLayout.Appearance = Appearance7
        UltraGridColumn9.Header.Caption = "IP máy chủ cơ sở dữ liệu"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.MaskInput = ""
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Tên cơ sở dữ liệu"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(135, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Tên đăng nhập"
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(105, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.EditorControl = Me.txtPass
        UltraGridColumn12.Header.Caption = "Mật khẩu"
        UltraGridColumn12.Header.VisiblePosition = 3
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.grid_E_Shiping.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_E_Shiping.DisplayLayout.InterBandSpacing = 10
        Me.grid_E_Shiping.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.grid_E_Shiping.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.grid_E_Shiping.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.grid_E_Shiping.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.grid_E_Shiping.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance10.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.grid_E_Shiping.DisplayLayout.Override.RowAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.grid_E_Shiping.DisplayLayout.Override.RowSelectorAppearance = Appearance11
        Me.grid_E_Shiping.DisplayLayout.Override.RowSelectorWidth = 12
        Me.grid_E_Shiping.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.grid_E_Shiping.DisplayLayout.Override.SelectedRowAppearance = Appearance12
        Me.grid_E_Shiping.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.grid_E_Shiping.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.grid_E_Shiping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_E_Shiping.Location = New System.Drawing.Point(8, 144)
        Me.grid_E_Shiping.Name = "grid_E_Shiping"
        Me.grid_E_Shiping.Size = New System.Drawing.Size(496, 120)
        Me.grid_E_Shiping.TabIndex = 23
        Me.grid_E_Shiping.Text = "Cấu hình kết nối E Shiping"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.lblDangNhap)
        Me.UltraGroupBox1.Controls.Add(Me.lbl3)
        Me.UltraGroupBox1.Controls.Add(Me.lbl2)
        Me.UltraGroupBox1.Controls.Add(Me.lbl1)
        Me.UltraGroupBox1.Controls.Add(Me.btnCapNhat)
        Me.UltraGroupBox1.Controls.Add(Me.txtMatKhau)
        Me.UltraGroupBox1.Controls.Add(Me.txtTenDangNhap)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txtAPI_Link)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 272)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(496, 120)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 24
        Me.UltraGroupBox1.Text = "Cấu hình kết nối Webservice"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(272, 88)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(80, 24)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(104, 88)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(120, 21)
        Me.txtMatKhau.TabIndex = 5
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Location = New System.Drawing.Point(104, 56)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(120, 21)
        Me.txtTenDangNhap.TabIndex = 4
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(16, 88)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(56, 23)
        Me.UltraLabel3.TabIndex = 3
        Me.UltraLabel3.Text = "Mật khẩu:"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 56)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(88, 23)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Tên đăng nhập:"
        '
        'txtAPI_Link
        '
        Me.txtAPI_Link.Location = New System.Drawing.Point(104, 24)
        Me.txtAPI_Link.Name = "txtAPI_Link"
        Me.txtAPI_Link.Size = New System.Drawing.Size(336, 21)
        Me.txtAPI_Link.TabIndex = 1
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "URL"
        '
        'lbl1
        '
        Appearance13.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Appearance = Appearance13
        Me.lbl1.Location = New System.Drawing.Point(440, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(16, 23)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "*"
        Me.lbl1.Visible = False
        '
        'lbl2
        '
        Appearance14.ForeColor = System.Drawing.Color.Red
        Me.lbl2.Appearance = Appearance14
        Me.lbl2.Location = New System.Drawing.Point(224, 64)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(16, 23)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "*"
        Me.lbl2.Visible = False
        '
        'lbl3
        '
        Appearance15.ForeColor = System.Drawing.Color.Red
        Me.lbl3.Appearance = Appearance15
        Me.lbl3.Location = New System.Drawing.Point(224, 96)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(16, 23)
        Me.lbl3.TabIndex = 9
        Me.lbl3.Text = "*"
        Me.lbl3.Visible = False
        '
        'lblDangNhap
        '
        Appearance16.ForeColor = System.Drawing.Color.Red
        Me.lblDangNhap.Appearance = Appearance16
        Me.lblDangNhap.Location = New System.Drawing.Point(248, 56)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.Size = New System.Drawing.Size(176, 24)
        Me.lblDangNhap.TabIndex = 10
        '
        'FrmCauHinhCoSoDuLieu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 397)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.grid_E_Shiping)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.dgHeThong)
        Me.MaximizeBox = False
        Me.Name = "FrmCauHinhCoSoDuLieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin hệ thống"
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHeThong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_E_Shiping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txtMatKhau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenDangNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAPI_Link, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myKeys As New ModifyRegistry
    Dim myId As Integer

#Region "-----------------------Tao_Bang-----------------------"
    Private Sub Tao_Bang()
        Dim str As String
        Dim dataTable As New dataTable("Thong_Tin_He_Thong")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ip_Co_So_Du_Lieu", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Co_So_Du_Lieu", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Dang_Nhap", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Mat_Khau", GetType(String))
        dataTable.Columns.Add(colWork)


        colWork = New DataColumn("Ip_Ora", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("ServiceName", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Ora", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Pass_Ora", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        Try
            If Not myKeys.Doc("IpDataBase") Is Nothing Then
                str = myKeys.Doc("IpDataBase")
                row("Ip_Co_So_Du_Lieu") = str
                str = myKeys.Doc("NameDataBase")
                row("Ten_Co_So_Du_Lieu") = str
                str = myKeys.Doc("UserDataBase")
                row("Ten_Dang_Nhap") = str
                str = Decrypt(myKeys.Doc("PassDataBase"), "cpcpnems")
                row("Mat_Khau") = str
            Else
                row("Ip_Co_So_Du_Lieu") = ""
                row("Ten_Co_So_Du_Lieu") = ""
                row("Ten_Dang_Nhap") = ""
                row("Mat_Khau") = ""
            End If
            If Not myKeys.Doc("Ip_Ora") Is Nothing Then
                str = myKeys.Doc("Ip_Ora")
                row("Ip_Ora") = str
                str = myKeys.Doc("ServiceName")
                row("ServiceName") = str
                str = myKeys.Doc("Ten_Ora")
                row("Ten_Ora") = str
                str = Decrypt(myKeys.Doc("Pass_Ora"), "cpcpnems")
                row("Pass_Ora") = str
            Else
                row("Ip_Ora") = ""
                row("ServiceName") = ""
                row("Ten_Ora") = ""
                row("Pass_Ora") = ""
            End If
            dataTable.Rows.Add(row)
            dgHeThong.DataSource = dataTable
            dgHeThong.DataBind()
        Catch ex As Exception
            row("Ip_Co_So_Du_Lieu") = ""
            row("Ten_Co_So_Du_Lieu") = ""
            row("Ten_Dang_Nhap") = ""
            row("Mat_Khau") = ""
            row("Ip_Ora") = ""
            row("ServiceName") = ""
            row("Ten_Ora") = ""
            row("Pass_Ora") = ""

            dataTable.Rows.Add(row)
            dgHeThong.DataSource = dataTable
            dgHeThong.DataBind()
        End Try

    End Sub
#End Region

#Region "-----------------------Tao_Bang_E_Shiping-----------------------"
    Private Sub Tao_Bang_E_Shiping()
        Dim str As String
        Dim dataTable As New dataTable("Thong_Tin_He_Thong")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ip_Co_So_Du_Lieu", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Co_So_Du_Lieu", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Dang_Nhap", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Mat_Khau", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        Try
            If Not myKeys.Doc("IpDataBase_E_Shiping") Is Nothing Then
                str = myKeys.Doc("IpDataBase_E_Shiping")
                row("Ip_Co_So_Du_Lieu") = str
                str = myKeys.Doc("NameDataBase_E_Shiping")
                row("Ten_Co_So_Du_Lieu") = str
                str = myKeys.Doc("UserDataBase_E_Shiping")
                row("Ten_Dang_Nhap") = str
                str = Decrypt(myKeys.Doc("PassDataBase_E_Shiping"), "cpcpnems")
                row("Mat_Khau") = str
            Else
                row("Ip_Co_So_Du_Lieu") = ""
                row("Ten_Co_So_Du_Lieu") = ""
                row("Ten_Dang_Nhap") = ""
                row("Mat_Khau") = ""
            End If
            dataTable.Rows.Add(row)
            grid_E_Shiping.DataSource = dataTable
            grid_E_Shiping.DataBind()
        Catch ex As Exception
            row("Ip_Co_So_Du_Lieu") = ""
            row("Ten_Co_So_Du_Lieu") = ""
            row("Ten_Dang_Nhap") = ""
            row("Mat_Khau") = ""

            dataTable.Rows.Add(row)
            grid_E_Shiping.DataSource = dataTable
            grid_E_Shiping.DataBind()
        End Try

    End Sub
#End Region
    Private Sub FrmCauHinhCoSoDuLieu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tao_Bang()
        Tao_Bang_E_Shiping()
        GetWS()
    End Sub
    Private Sub GetWS()
        Try
            Dim myTable As New DataTable
            myTable = myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0)
            If myTable.Rows.Count <> 0 Then
                myId = Convert.ToInt32(myTable.Rows(0)(0))
                txtAPI_Link.Text = myTable.Rows(0)(1)
                txtTenDangNhap.Text = myTable.Rows(0)(2)
                txtMatKhau.Text = myTable.Rows(0)(3)
            End If
        Catch ex As Exception
            Console.Write(ex.ToString())
        End Try
    End Sub
#Region "dgHeThong"
    Private Sub dgHeThong_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgHeThong.InitializeLayout
        dgHeThong.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgHeThong.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub

    Private Sub dgHeThong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgHeThong.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub

    Private Sub dgHeThong_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgHeThong.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub

    Private Sub dgHeThong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgHeThong.AfterExitEditMode
        Select Case dgHeThong.ActiveCell.Column.Key
            Case "Ten_Dang_Nhap"
                If dgHeThong.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Tên đăng nhập không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = dgHeThong.ActiveCell
                End If
            Case "Mat_Khau"
                If dgHeThong.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Mật khẩu không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = dgHeThong.ActiveCell
                End If
            Case "Ten_Co_So_Du_Lieu"
                If dgHeThong.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Phải điền tên cơ sở dữ liệu vào !!!", "Thông báo")
                    Exit Sub
                    myCell = dgHeThong.ActiveCell
                End If
        End Select
    End Sub

    Private Sub dgHeThong_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgHeThong.AfterCellUpdate

    End Sub
#End Region

#Region "grid_E_Shiping"
    Private Sub grid_E_Shiping_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_E_Shiping.InitializeLayout
        grid_E_Shiping.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        grid_E_Shiping.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub

    Private Sub grid_E_Shiping_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_E_Shiping.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub

    Private Sub grid_E_Shiping_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grid_E_Shiping.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub

    Private Sub grid_E_Shiping_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_E_Shiping.AfterExitEditMode
        Select Case grid_E_Shiping.ActiveCell.Column.Key
            Case "Ten_Dang_Nhap"
                If grid_E_Shiping.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Tên đăng nhập không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = grid_E_Shiping.ActiveCell
                End If
            Case "Mat_Khau"
                If grid_E_Shiping.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Mật khẩu không được để trống !!!", "Thông báo")
                    Exit Sub
                    myCell = grid_E_Shiping.ActiveCell
                End If
            Case "Ten_Co_So_Du_Lieu"
                If grid_E_Shiping.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Phải điền tên cơ sở dữ liệu vào !!!", "Thông báo")
                    Exit Sub
                    myCell = grid_E_Shiping.ActiveCell
                End If
        End Select
    End Sub

    Private Sub grid_E_Shiping_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid_E_Shiping.AfterCellUpdate

    End Sub
#End Region
    Private Sub FrmCauHinhCoSoDuLieu_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Not TestConnection("Server = " & dgHeThong.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text & ";" & "database=" & dgHeThong.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text & ";" & "uid=" & dgHeThong.Rows(0).Cells("Ten_Dang_Nhap").Text & ";" & "pwd=" & dgHeThong.Rows(0).Cells("Mat_Khau").Text) Then
            MessageBox.Show("Không thể kết nối tới database, bạn phải nhập lại chính xác các tham số !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not TestConnection_E_Shiping("Server = " & grid_E_Shiping.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text & ";" & "database=" & grid_E_Shiping.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text & ";" & "uid=" & grid_E_Shiping.Rows(0).Cells("Ten_Dang_Nhap").Text & ";" & "pwd=" & grid_E_Shiping.Rows(0).Cells("Mat_Khau").Text) Then
            MessageBox.Show("Không thể kết nối tới database E Shiping, bạn phải nhập lại chính xác các tham số !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'If TestOracle("Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=" & dgHeThong.Rows(0).Cells("ServiceName").Text & "))(ADDRESS=(PROTOCOL=TCP)(HOST=" & dgHeThong.Rows(0).Cells("Ip_Ora").Text & ")(PORT=1521)));user id=" & dgHeThong.Rows(0).Cells("Ten_Ora").Text & "; password=" & dgHeThong.Rows(0).Cells("Pass_Ora").Text & "") = False Then
        '    MessageBox.Show("Không Kết nối được tới Oracle", "Connect To Oracle")
        'End If

        myKeys.Ghi("IpDataBase", dgHeThong.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text)
        myKeys.Ghi("NameDataBase", dgHeThong.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text)
        myKeys.Ghi("UserDataBase", dgHeThong.Rows(0).Cells("Ten_Dang_Nhap").Text)
        myKeys.Ghi("PassDataBase", Encrypt(dgHeThong.Rows(0).Cells("Mat_Khau").Text, "cpcpnems"))

        myKeys.Ghi("IpDataBase_E_Shiping", grid_E_Shiping.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text)
        myKeys.Ghi("NameDataBase_E_Shiping", grid_E_Shiping.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text)
        myKeys.Ghi("UserDataBase_E_Shiping", grid_E_Shiping.Rows(0).Cells("Ten_Dang_Nhap").Text)
        myKeys.Ghi("PassDataBase_E_Shiping", Encrypt(grid_E_Shiping.Rows(0).Cells("Mat_Khau").Text, "cpcpnems"))

        myKeys.Ghi("Ip_Ora", dgHeThong.Rows(0).Cells("Ip_Ora").Text)
        myKeys.Ghi("ServiceName", dgHeThong.Rows(0).Cells("ServiceName").Text)
        myKeys.Ghi("Ten_Ora", dgHeThong.Rows(0).Cells("Ten_Ora").Text)
        myKeys.Ghi("Pass_Ora", Encrypt(dgHeThong.Rows(0).Cells("Pass_Ora").Text, "cpcpnems"))


        GOracleConnectionString = "Data Source=(DESCRIPTION=(CONNECT_DATA=(SID=*)(SERVICE_NAME=" & dgHeThong.Rows(0).Cells("ServiceName").Text & "))(ADDRESS=(PROTOCOL=TCP)(HOST=" & dgHeThong.Rows(0).Cells("Ip_Ora").Text & ")(PORT=1521)));user id=" & dgHeThong.Rows(0).Cells("Ten_Ora").Text & "; password=" & dgHeThong.Rows(0).Cells("Pass_Ora").Text & ""
        GConnectionString = "Server = " & dgHeThong.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text & ";" & "database=" & dgHeThong.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text & ";" & "uid=" & dgHeThong.Rows(0).Cells("Ten_Dang_Nhap").Text & ";" & "pwd=" & dgHeThong.Rows(0).Cells("Mat_Khau").Text
        GConnectionString_E_Shiping = "Server = " & grid_E_Shiping.Rows(0).Cells("Ip_Co_So_Du_Lieu").Text & ";" & "database=" & grid_E_Shiping.Rows(0).Cells("Ten_Co_So_Du_Lieu").Text & ";" & "uid=" & grid_E_Shiping.Rows(0).Cells("Ten_Dang_Nhap").Text & ";" & "pwd=" & grid_E_Shiping.Rows(0).Cells("Mat_Khau").Text
    End Sub
    Private Sub btnCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhat.Click

        Try
            If txtAPI_Link.Text.Trim = "" Then
                lbl1.Visible = True
                Exit Sub
            Else
                lbl1.Visible = False
            End If
            If txtTenDangNhap.Text.Trim = "" Then
                lbl2.Visible = True
                Exit Sub
            Else
                lbl2.Visible = False
            End If
            If txtMatKhau.Text.Trim = "" Then
                lbl3.Visible = True
                Exit Sub
            Else
                lbl3.Visible = False
            End If


            '' Kiểm tra đăng nhập 
            Dim _strInput As String = ""
            Dim _strOutput As String = ""
            Dim myString As String = ""
            Dim myMAC As String = ""
            Dim mysss As String

            Dim myAPI As New Api_QLTG.Service

            Dim myArray() As String = {GBuu_Cuc_Khai_Thac, Guid.NewGuid().ToString(), GetIPv4Address(), GetMacAddress(), txtTenDangNhap.Text.Trim, txtMatKhau.Text.Trim}

            _strInput = String.Join("^", myArray)
            _strInput = SecurityLib.RSA.EncryptString(_strInput, RSAPublicKey)

            '' Goi API 
            myAPI.Url = txtAPI_Link.Text.Trim
            ' _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC100", _strInput)
            _strOutput = myAPI.ExecuteMessage("EMS_CENTER", "BC100", _strInput)
            _strOutput = SecurityLib.RSA.DecryptString(_strOutput, RSAPrivateKey)

            myString = _strOutput.Split("|")(0)

            Dim strArr() As String
            strArr = _strOutput.Split("|")
            For i As Integer = 3 To strArr.Length - 1
                mysss = strArr(i).Split("^")(0)
            Next
            Select Case myString
                Case "00"
                    lblDangNhap.Text = _strOutput.Split("|")(1)
                    myQLTGND_APILink.QLTGND_APILink_Cap_Nhat_Them(myId, txtAPI_Link.Text.Trim, txtTenDangNhap.Text.Trim, txtMatKhau.Text.Trim)
                Case Else
                    lblDangNhap.Text = _strOutput.Split("|")(1)
            End Select


        Catch ex As Exception
            Console.Write(ex.ToString())
        End Try
    End Sub
End Class

Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
Public Class FrmBaoPhat
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
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents tabBaoPhat As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDanhSachChuaCoPOD As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents ddBuuCucPhat As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddXuLy As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLyDoPhat As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dgDaPhat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgChuaPhat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnThongTin As System.Windows.Forms.Button
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Xu_ly", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly_EN")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_Do", -1)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do_EN")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Xu_Ly")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bao_Phat", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Bao_Phat")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Phat")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhap")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhap")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Phat")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phat_Duoc")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bao_Phat", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Bao_Phat")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Phat")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhap")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhap")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Phat")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phat_Duoc")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bao_Phat_Chua_Phat", -1)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_Tra")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddBuuCucPhat = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddXuLy = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLyDoPhat = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDaPhat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgChuaPhat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgDanhSachChuaCoPOD = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.tabBaoPhat = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.btnCapnhat = New System.Windows.Forms.Button
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnThongTin = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDuongThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ddBuuCucPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddXuLy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLyDoPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDaPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgChuaPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgDanhSachChuaCoPOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBaoPhat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBaoPhat.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(680, -8)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 25)
        Me.dtpNgayDinhDang.TabIndex = 65
        Me.dtpNgayDinhDang.Visible = False
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ddBuuCucPhat)
        Me.UltraTabPageControl1.Controls.Add(Me.ddXuLy)
        Me.UltraTabPageControl1.Controls.Add(Me.ddLyDoPhat)
        Me.UltraTabPageControl1.Controls.Add(Me.dgDaPhat)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(780, 324)
        '
        'ddBuuCucPhat
        '
        Me.ddBuuCucPhat.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddBuuCucPhat.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã bưu cục"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên bưu cục"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        UltraGridBand1.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None
        UltraGridBand1.UseRowLayout = True
        Me.ddBuuCucPhat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddBuuCucPhat.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.ddBuuCucPhat.DisplayMember = ""
        Me.ddBuuCucPhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddBuuCucPhat.Location = New System.Drawing.Point(480, 8)
        Me.ddBuuCucPhat.Name = "ddBuuCucPhat"
        Me.ddBuuCucPhat.Size = New System.Drawing.Size(208, 128)
        Me.ddBuuCucPhat.TabIndex = 59
        Me.ddBuuCucPhat.ValueMember = ""
        Me.ddBuuCucPhat.Visible = False
        '
        'ddXuLy
        '
        Me.ddXuLy.Cursor = System.Windows.Forms.Cursors.Default
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddXuLy.DisplayLayout.Appearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 200
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        UltraGridBand2.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None
        UltraGridBand2.UseRowLayout = True
        Me.ddXuLy.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddXuLy.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.ddXuLy.DisplayMember = ""
        Me.ddXuLy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddXuLy.Location = New System.Drawing.Point(64, 64)
        Me.ddXuLy.Name = "ddXuLy"
        Me.ddXuLy.Size = New System.Drawing.Size(208, 88)
        Me.ddXuLy.TabIndex = 58
        Me.ddXuLy.ValueMember = ""
        Me.ddXuLy.Visible = False
        '
        'ddLyDoPhat
        '
        Me.ddLyDoPhat.Cursor = System.Windows.Forms.Cursors.Default
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLyDoPhat.DisplayLayout.Appearance = Appearance5
        UltraGridColumn6.Header.VisiblePosition = 0
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Width = 200
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand3.RowLayoutLabelPosition = Infragistics.Win.UltraWinGrid.LabelPosition.None
        UltraGridBand3.UseRowLayout = True
        Me.ddLyDoPhat.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLyDoPhat.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.ddLyDoPhat.DisplayMember = ""
        Me.ddLyDoPhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLyDoPhat.Location = New System.Drawing.Point(304, 88)
        Me.ddLyDoPhat.Name = "ddLyDoPhat"
        Me.ddLyDoPhat.Size = New System.Drawing.Size(208, 128)
        Me.ddLyDoPhat.TabIndex = 57
        Me.ddLyDoPhat.ValueMember = ""
        Me.ddLyDoPhat.Visible = False
        '
        'dgDaPhat
        '
        Me.dgDaPhat.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDaPhat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDaPhat.DisplayLayout.Appearance = Appearance7
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn11.DefaultCellValue = ""
        UltraGridColumn11.FormulaErrorValue = ""
        UltraGridColumn11.Header.Caption = "Mã bưu phẩm"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.MaskInput = ""
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(131, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Bưu Cục Phát"
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn14.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn14.Format = ""
        UltraGridColumn14.Header.Caption = "Ngày Phát"
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Format = ""
        UltraGridColumn15.Header.Caption = "Giờ Phát"
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn15.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn15.MaskInput = "hh:mm"
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Format = "dd/MM/yyyy"
        UltraGridColumn16.Header.Caption = "Ngày nhập"
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Format = ""
        UltraGridColumn17.Header.Caption = "Giờ Nhập"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.MaskInput = "##:##"
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn18.Header.Caption = "Người Phát"
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Người Nhận"
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Khối Lượng"
        UltraGridColumn20.Header.VisiblePosition = 7
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.VisiblePosition = 15
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 16
        UltraGridColumn22.Hidden = True
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColorAlpha = Infragistics.Win.Alpha.UseAlphaLevel
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.None
        UltraGridColumn23.CellAppearance = Appearance8
        UltraGridColumn23.Header.Caption = "Phát Được"
        UltraGridColumn23.Header.VisiblePosition = 10
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 11
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 12
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 13
        UltraGridColumn26.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand4.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgDaPhat.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgDaPhat.DisplayLayout.InterBandSpacing = 10
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.dgDaPhat.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Me.dgDaPhat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDaPhat.DisplayLayout.Override.HeaderAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDaPhat.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDaPhat.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Me.dgDaPhat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDaPhat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.dgDaPhat.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.dgDaPhat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDaPhat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDaPhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDaPhat.Location = New System.Drawing.Point(0, 0)
        Me.dgDaPhat.Name = "dgDaPhat"
        Me.dgDaPhat.Size = New System.Drawing.Size(776, 320)
        Me.dgDaPhat.TabIndex = 56
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.dgChuaPhat)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(780, 324)
        '
        'dgChuaPhat
        '
        Me.dgChuaPhat.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgChuaPhat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChuaPhat.DisplayLayout.Appearance = Appearance14
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn28.DefaultCellValue = ""
        UltraGridColumn28.FormulaErrorValue = ""
        UltraGridColumn28.Header.Caption = "Mã bưu phẩm"
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.MaskInput = ""
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(131, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.VisiblePosition = 14
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Bưu Cục Phát"
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn31.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn31.Format = ""
        UltraGridColumn31.Header.Caption = "Ngày Phát"
        UltraGridColumn31.Header.VisiblePosition = 3
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Format = ""
        UltraGridColumn32.Header.Caption = "Giờ Phát"
        UltraGridColumn32.Header.VisiblePosition = 4
        UltraGridColumn32.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn32.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn32.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn32.MaskInput = "hh:mm"
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Format = "dd/MM/yyyy"
        UltraGridColumn33.Header.Caption = "Ngày nhập"
        UltraGridColumn33.Header.VisiblePosition = 8
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Format = ""
        UltraGridColumn34.Header.Caption = "Giờ Nhập"
        UltraGridColumn34.Header.VisiblePosition = 9
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.MaskInput = "##:##"
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn35.Header.Caption = "Người Phát"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.Caption = "Người Nhận"
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.Caption = "Khối Lượng"
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = "Lý do không phát được"
        UltraGridColumn38.Header.VisiblePosition = 15
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(172, 0)
        UltraGridColumn39.Header.Caption = "Xử lý tiếp theo"
        UltraGridColumn39.Header.VisiblePosition = 16
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(195, 0)
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColorAlpha = Infragistics.Win.Alpha.UseAlphaLevel
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.None
        UltraGridColumn40.CellAppearance = Appearance15
        UltraGridColumn40.Header.Caption = "Phát Được"
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43})
        UltraGridBand5.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand5.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgChuaPhat.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgChuaPhat.DisplayLayout.InterBandSpacing = 10
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Me.dgChuaPhat.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Me.dgChuaPhat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance17.ForeColor = System.Drawing.Color.Black
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance17.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChuaPhat.DisplayLayout.Override.HeaderAppearance = Appearance17
        Appearance18.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChuaPhat.DisplayLayout.Override.RowAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChuaPhat.DisplayLayout.Override.RowSelectorAppearance = Appearance19
        Me.dgChuaPhat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChuaPhat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.dgChuaPhat.DisplayLayout.Override.SelectedRowAppearance = Appearance20
        Me.dgChuaPhat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChuaPhat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChuaPhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChuaPhat.Location = New System.Drawing.Point(0, 0)
        Me.dgChuaPhat.Name = "dgChuaPhat"
        Me.dgChuaPhat.Size = New System.Drawing.Size(776, 320)
        Me.dgChuaPhat.TabIndex = 57
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgDanhSachChuaCoPOD)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(2, 26)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(780, 324)
        '
        'dgDanhSachChuaCoPOD
        '
        Me.dgDanhSachChuaCoPOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgDanhSachChuaCoPOD.DisplayLayout.AddNewBox.Prompt = " "
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Appearance = Appearance21
        UltraGridColumn44.Header.Caption = "Ngày phát hành"
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(91, 0)
        UltraGridColumn45.Header.Caption = "Mã E1"
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridColumn46.Header.Caption = "Nước phát hành"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn47.Header.Caption = "Mã bưu cục gốc"
        UltraGridColumn47.Header.VisiblePosition = 3
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(91, 0)
        UltraGridColumn48.Header.Caption = "Mã bưu cục trả"
        UltraGridColumn48.Header.VisiblePosition = 4
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn49.Header.Caption = "Khối lượng"
        UltraGridColumn49.Header.VisiblePosition = 5
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn50.Header.Caption = "Cước E1"
        UltraGridColumn50.Header.VisiblePosition = 6
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50})
        UltraGridBand6.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand6.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand6.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand6.UseRowLayout = True
        Me.dgDanhSachChuaCoPOD.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.dgDanhSachChuaCoPOD.DisplayLayout.InterBandSpacing = 10
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.CardAreaAppearance = Appearance22
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance23.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance24.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.RowAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance25.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.RowSelectorAppearance = Appearance25
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.dgDanhSachChuaCoPOD.DisplayLayout.Override.SelectedRowAppearance = Appearance26
        Me.dgDanhSachChuaCoPOD.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhSachChuaCoPOD.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanhSachChuaCoPOD.ExitEditModeOnLeave = False
        Me.dgDanhSachChuaCoPOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanhSachChuaCoPOD.Location = New System.Drawing.Point(0, 0)
        Me.dgDanhSachChuaCoPOD.Name = "dgDanhSachChuaCoPOD"
        Me.dgDanhSachChuaCoPOD.Size = New System.Drawing.Size(776, 320)
        Me.dgDanhSachChuaCoPOD.TabIndex = 52
        '
        'tabBaoPhat
        '
        Me.tabBaoPhat.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabBaoPhat.Controls.Add(Me.UltraTabPageControl1)
        Me.tabBaoPhat.Controls.Add(Me.UltraTabPageControl2)
        Me.tabBaoPhat.Controls.Add(Me.UltraTabPageControl3)
        Me.tabBaoPhat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBaoPhat.Location = New System.Drawing.Point(0, 88)
        Me.tabBaoPhat.Name = "tabBaoPhat"
        Me.tabBaoPhat.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabBaoPhat.Size = New System.Drawing.Size(784, 352)
        Me.tabBaoPhat.TabIndex = 63
        Me.tabBaoPhat.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Nhập Bưu Phẩm đã phát"
        UltraTab2.Key = "1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Nhập Bưu phẩm chưa phát được"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Bưu phẩm chưa có chi tiết phát"
        Me.tabBaoPhat.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(780, 324)
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(640, 24)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(112, 23)
        Me.btnCapnhat.TabIndex = 62
        Me.btnCapnhat.Text = "Truyền &Dữ Liệu "
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.chkAll)
        Me.UltraGroupBox1.Controls.Add(Me.btnThongTin)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.cbDuongThuDi)
        Me.UltraGroupBox1.Controls.Add(Me.btnCapnhat)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayDinhDang)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(784, 80)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 67
        Me.UltraGroupBox1.Text = "Thông tin báo phát"
        '
        'btnThongTin
        '
        Me.btnThongTin.Location = New System.Drawing.Point(520, 24)
        Me.btnThongTin.Name = "btnThongTin"
        Me.btnThongTin.Size = New System.Drawing.Size(104, 23)
        Me.btnThongTin.TabIndex = 67
        Me.btnThongTin.Text = "Lấy thông tin"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Đến "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(56, 24)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(88, 25)
        Me.dtpTuNgay.TabIndex = 49
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(200, 24)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(88, 25)
        Me.dtpDenNgay.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 23)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Từ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(296, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel3.TabIndex = 24
        Me.UltraLabel3.Text = "Bưu tá"
        '
        'cbDuongThuDi
        '
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDuongThuDi.DisplayLayout.Appearance = Appearance27
        UltraGridColumn51.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn51.Header.VisiblePosition = 0
        UltraGridColumn52.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn52.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn51, UltraGridColumn52})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuongThuDi.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.cbDuongThuDi.DisplayMember = ""
        Me.cbDuongThuDi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi.Location = New System.Drawing.Point(384, 24)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(120, 21)
        Me.cbDuongThuDi.TabIndex = 2
        Me.cbDuongThuDi.ValueMember = ""
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(520, 48)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(240, 24)
        Me.chkAll.TabIndex = 68
        Me.chkAll.Text = "Chọn để truyền tất"
        '
        'FrmBaoPhat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 437)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.tabBaoPhat)
        Me.Name = "FrmBaoPhat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập thông tin báo phát"
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ddBuuCucPhat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddXuLy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLyDoPhat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDaPhat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgChuaPhat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgDanhSachChuaCoPOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBaoPhat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBaoPhat.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myLyDo As New Ly_Do(GConnectionString)
    Dim myXuLy As New Xu_Ly(GConnectionString)
    Dim myDuongThuDi As New Duong_Thu_Di(GConnectionString)
    Dim myBaoPhat As New Bao_Phat(GConnectionString)
    Dim myBaoPhatChiTiet As New Bao_Phat_Chi_Tiet
    Dim myNoiDung As New Noi_Dung_Phat(GConnectionString)
    Dim myNoiDungChiTiet As New Noi_Dung_Phat_Chi_Tiet
    Dim myData As DataTable
    Dim myDataChuaPhat As DataTable
    Dim strNguoiNhan As String = ""
    Dim strLyDo As Integer = "11"
    Dim strXuLy As String = "A"
    Dim strNgay As Date = Now
    Dim strGio As String = Ham_Dung_Chung.ConvertIntToTime(Ham_Dung_Chung.ConvertTimeToInt(Now))
    Dim strIdBaoPhat As String
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
    Dim id_Bao_Phat As String
    Private Sub InitData()
        ddLyDoPhat.DataSource = myLyDo.Danh_Sach
        ddLyDoPhat.DisplayMember = "Ten_Ly_Do"
        ddLyDoPhat.ValueMember = "Ma_Ly_Do"
        ddLyDoPhat.DataBind()

        ddXuLy.DataSource = myXuLy.Danh_Sach
        ddXuLy.DisplayMember = "Ten_Xu_Ly"
        ddXuLy.ValueMember = "Ma_Xu_Ly"
        ddXuLy.DataBind()

        cbDuongThuDi.DataSource = myDuongThuDi.Danh_Sach_Buu_Ta(GBuu_Cuc_Khai_Thac)
        cbDuongThuDi.DisplayMember = "Ma_Bc"
        cbDuongThuDi.ValueMember = "Ma_Bc"
        cbDuongThuDi.DataBind()
    End Sub
    Private Sub FrmBaoPhat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Now.AddDays(-30)
        dtpDenNgay.Value = Now
        InitData()
        strNguoiNhan = ""
        myGridKeyDown = dgDaPhat
    End Sub

    Private Sub dgDaPhat_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDaPhat.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        'With myGridKeyDown.DisplayLayout
        '    .Bands(0).Columns("Ma_Ly_Do").Style = ColumnStyle.DropDownValidate
        '    .Bands(0).Columns("Ma_Ly_Do").ValueList = ddLyDoPhat
        '    .Bands(0).Columns("Ma_Xu_Ly").Style = ColumnStyle.DropDownValidate
        '    .Bands(0).Columns("Ma_Xu_Ly").ValueList = ddXuLy
        'End With
        'AddNewRow(dgDaPhat)
    End Sub

    Private Sub dgDaPhat_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDaPhat.InitializeTemplateAddRow
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Ngay_Phat").DefaultCellValue = strNgay
            .Columns("Gio_Phat").DefaultCellValue = strGio
            .Columns("Nguoi_Nhan").DefaultCellValue = strNguoiNhan
        End With
    End Sub

    Private Sub btnThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThongTin.Click
        If cbDuongThuDi.Text.Trim = "" Then
            CMessageBox.Show("Phải chọn đường thư bưu tá !!!", "Thông báo")
            Exit Sub
        End If
        myData = myBaoPhat.Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Buu_Ta(Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), cbDuongThuDi.Text).Tables(0)
        dgDaPhat.DataSource = myData
        dgDaPhat.DataBind()

        myDataChuaPhat = myBaoPhat.Danh_Sach_Chua_Phat_Duoc_Tu_Ngay_Den_Ngay_Theo_Buu_Ta(Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), cbDuongThuDi.Text).Tables(0)
        dgChuaPhat.DataSource = myDataChuaPhat
        dgChuaPhat.DataBind()

        myData = myBaoPhat.Thong_Ke_EMS_Khong_Nhap_Bao_Phat(cbDuongThuDi.Value, Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)).Tables(0)
        dgDanhSachChuaCoPOD.DataSource = myData
        dgDanhSachChuaCoPOD.DataBind()
        

    End Sub
    Private Sub DeleteDaPhat()
        If CMessageBox.Show("Bạn có thực sự muốn xóa báo phát này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text <> "" Then
                myBaoPhat.Xoa(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text)
            End If
            myGridKeyDown.ActiveRow.Delete(False)
        End If
    End Sub
    Private Sub DeleteChuaPhat()
        If CMessageBox.Show("Bạn có thực sự muốn xóa báo phát chưa phát được này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text <> "" Then
                myBaoPhat.Xoa(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text)
            End If
            myGridKeyDown.ActiveRow.Delete(False)
        End If
    End Sub
#Region "Thêm dòng mới"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
#End Region
    Private Sub Keys_Enter_DaPhat(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        myGridKeyDown = sender
        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ngay_Phat"
                strNgay = myGridKeyDown.ActiveCell.Value
            Case "Gio"
                strGio = myGridKeyDown.ActiveCell.Value
            Case "Ma_E1"
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                If myGridKeyDown.ActiveCell.Text.Trim.Length <> 13 Then
                    CMessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text = "" Then
                    id_Bao_Phat = myBaoPhat.Lay_Id_Bao_Phat_Theo_Ma_E1(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text, cbDuongThuDi.Value, Ham_Dung_Chung.ConvertDateToInt(DateAdd(DateInterval.Day, -GSo_Ngay_Cho_Phep_Nhap_Bao_Phat, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value)), Ham_Dung_Chung.ConvertDateToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value))
                    If id_Bao_Phat = "" Then
                        CMessageBox.Show("Mã E1 không có trong dữ liệu nhận về hoặc đã quá " & GSo_Ngay_Cho_Phep_Nhap_Bao_Phat.ToString & " kể từ ngày nhận về !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Value = id_Bao_Phat
                    End If
                End If

            Case "Nguoi_Nhan"
                If myGridKeyDown.ActiveCell.Text = "" Then
                    MessageBox.Show("Người nhận không được để trống !!!", "Thông báo", MessageBoxButtons.OK)
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                strNguoiNhan = myGridKeyDown.ActiveCell.Text
                If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                    AddNewRow(sender)
                End If
        End Select
        'Sang cột tiếp theo
        e.Handled = False
        myGridKeyDown.PerformAction(EnterEditMode, False, False)
        myGridKeyDown.PerformAction(NextCellByTab, False, True)
    End Sub
    Private Sub dgDaPhat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDaPhat.KeyDown
        myGridKeyDown = sender
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape Then Exit Sub

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
                Keys_Enter_DaPhat(sender, e)
            Case Keys.F8
                DeleteDaPhat()
                e.Handled = True
            Case Keys.Escape
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                If myGridKeyDown.ActiveRow.Activated = True Then
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
                        DeleteDaPhat()
                    End If
                End If
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub

    Private Sub dgDaPhat_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDaPhat.AfterExitEditMode
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell.Text Is Nothing Then
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Value Is System.DBNull.Value Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Value = strNguoiNhan
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value = strNgay
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat").Value = strGio
                    End If
            End Select
        End If
    End Sub

    Private Sub dgDaPhat_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDaPhat.AfterRowUpdate
        myGridKeyDown = sender
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text = "" Then
            CMessageBox.Show("Không có thông tin mã E1 này !!!", "Thông báo")
            Exit Sub
        End If
        If dgDaPhat.Rows(dgDaPhat.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then  'Nếu dòng có dữ liệu, và đã nhập nguoi nhan
            If (dgDaPhat.Rows(dgDaPhat.ActiveRow.Index).Cells("Nguoi_Nhan").Text.Length) > 0 Then
                With myBaoPhatChiTiet
                    .Ma_E1 = Trim(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text).ToUpper
                    .Nuoc_Nhan = Trim(.Ma_E1.Substring(11, 2)).ToUpper
                    .Ma_Bc_Phat = cbDuongThuDi.Text
                    .Ngay_Phat = Ham_Dung_Chung.ConvertDateToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value)
                    .Id_Bao_Phat = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text
                    .Gio_Phat = Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat").Value)
                    .Ngay_Nhap = Ham_Dung_Chung.ConvertDateToInt(Now)
                    .Gio_Nhap = Ham_Dung_Chung.ConvertTimeToInt(Now)
                    .Nguoi_Phat = GHo_Ten
                    .Nguoi_Nhan = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Text
                    .Khoi_Luong = 0
                    .Ma_Ly_Do = 30
                    .Ma_Xu_Ly = "O"
                    .Phat_Duoc = True
                    .Id_Nguoi_Dung = Gid_Nguoi_Dung
                    .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Now)
                    .Truyen_Khai_Thac = False
                End With
                myBaoPhat.Cap_Nhat(myBaoPhatChiTiet)
                myBaoPhat.Convert(myBaoPhatChiTiet.Id_Bao_Phat)
            End If
        End If
    End Sub

    Private Sub dgChuaPhat_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgChuaPhat.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With myGridKeyDown.DisplayLayout
            .Bands(0).Columns("Ma_Ly_Do").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Ly_Do").ValueList = ddLyDoPhat
            .Bands(0).Columns("Ma_Xu_Ly").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Xu_Ly").ValueList = ddXuLy
        End With
    End Sub

    Private Sub tabBaoPhat_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles tabBaoPhat.SelectedTabChanged
        Select Case e.Tab.Index
            Case 0
                myGridKeyDown = dgDaPhat
            Case 1
                myGridKeyDown = dgChuaPhat
            Case 2
                myGridKeyDown = dgDanhSachChuaCoPOD
        End Select
        'show_baophat(myGridKeyDown)
    End Sub

    Private Sub dgChuaPhat_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgChuaPhat.InitializeTemplateAddRow
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Ngay_Phat").DefaultCellValue = strNgay
            .Columns("Gio_Phat").DefaultCellValue = strGio
            .Columns("Nguoi_Nhan").DefaultCellValue = ""
            .Columns("Ma_Ly_Do").DefaultCellValue = strLyDo
            .Columns("Ma_Xu_Ly").DefaultCellValue = strXuLy
        End With
    End Sub
    Private Sub Keys_Enter_Chua_Phat(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        myGridKeyDown = sender

        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ngay_Phat"
                strNgay = myGridKeyDown.ActiveCell.Value
            Case "Gio"
                strGio = myGridKeyDown.ActiveCell.Value
            Case "Ma_E1"
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                If myGridKeyDown.ActiveCell.Text.Trim.Length <> 13 Then
                    CMessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text = "" Then
                    id_Bao_Phat = myBaoPhat.Lay_Id_Bao_Phat_Theo_Ma_E1(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text, cbDuongThuDi.Value, Ham_Dung_Chung.ConvertDateToInt(DateAdd(DateInterval.Day, -GSo_Ngay_Cho_Phep_Nhap_Bao_Phat, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value)), Ham_Dung_Chung.ConvertDateToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value))
                    If id_Bao_Phat = "" Then
                        CMessageBox.Show("Mã E1 không có trong dữ liệu nhận về hoặc đã quá " & GSo_Ngay_Cho_Phep_Nhap_Bao_Phat.ToString & " kể từ ngày nhận về !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Value = id_Bao_Phat
                    End If
                End If
            Case "Ma_Ly_Do"
                If myGridKeyDown.ActiveCell.Text = "" Then
                    MessageBox.Show("Lý do không phát được không được để trống !!!", "Thông báo", MessageBoxButtons.OK)
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                strLyDo = myLyDo.Lay_Boi_Ten_Ly_Do(myGridKeyDown.ActiveCell.Text)
                ddXuLy.DataSource = myXuLy.Ly_Do_Chi_Tiet_Xu_Ly(strLyDo)
                ddXuLy.DisplayMember = "Ten_Xu_Ly"
                ddXuLy.ValueMember = "Ma_Xu_Ly"
                ddXuLy.DataBind()
                If ddXuLy.Rows.Count > 0 Then
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Xu_Ly").Value = ddXuLy.Rows(0).Cells("Ma_Xu_Ly").Value
                End If
            Case "Ma_Xu_Ly"
                If myGridKeyDown.ActiveCell.Text = "" Then
                    MessageBox.Show("Xử lý tiếp theo không được để trống !!!", "Thông báo", MessageBoxButtons.OK)
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                strXuLy = myGridKeyDown.ActiveCell.Value
                If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                    AddNewRow(sender)
                End If
        End Select
        'Sang cột tiếp theo
        e.Handled = False
        myGridKeyDown.PerformAction(EnterEditMode, False, False)
        myGridKeyDown.PerformAction(NextCellByTab, False, True)
    End Sub
    Private Sub dgChuaPhat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgChuaPhat.KeyDown
        myGridKeyDown = sender
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape Then Exit Sub

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
                Keys_Enter_Chua_Phat(sender, e)
            Case Keys.F8
                DeleteChuaPhat()
                e.Handled = True
            Case Keys.Escape
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                If myGridKeyDown.ActiveRow.Activated = True Then
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text = "" Then
                        DeleteChuaPhat()
                    End If
                End If
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub


    Private Sub ddLyDoPhat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddLyDoPhat.LostFocus
        MessageBox.Show("")
    End Sub

    Private Sub dgChuaPhat_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgChuaPhat.AfterRowUpdate
        myGridKeyDown = sender

        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text = "" Then
            CMessageBox.Show("Không có thông tin mã E1 này !!!", "Thông báo")
            Exit Sub
        End If

        If dgChuaPhat.Rows(dgChuaPhat.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then  'Nếu dòng có dữ liệu, và đã nhập nguoi nhan
            With myBaoPhatChiTiet
                .Ma_E1 = Trim(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text).ToUpper
                .Nuoc_Nhan = Trim(.Ma_E1.Substring(11, 2)).ToUpper
                .Ma_Bc_Phat = cbDuongThuDi.Text
                .Ngay_Phat = Ham_Dung_Chung.ConvertDateToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value)
                .Id_Bao_Phat = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Text
                strIdBaoPhat = .Id_Bao_Phat
                .Gio_Phat = Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat").Value)
                .Ngay_Nhap = Ham_Dung_Chung.ConvertDateToInt(Now)
                .Gio_Nhap = Ham_Dung_Chung.ConvertTimeToInt(Now)
                .Nguoi_Phat = GHo_Ten
                .Nguoi_Nhan = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Text
                .Khoi_Luong = 0
                .Ma_Ly_Do = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Ly_Do").Value
                .Ma_Xu_Ly = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Xu_Ly").Value
                .Phat_Duoc = False
                .Id_Nguoi_Dung = Gid_Nguoi_Dung
                .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Now)
                .Truyen_Khai_Thac = False
            End With
            myBaoPhat.Cap_Nhat(myBaoPhatChiTiet)
            With myNoiDungChiTiet
                .Id_Noi_Dung = 0
                .Id_Bao_Phat = strIdBaoPhat
                .Nguoi_Phat = GHo_Ten
                .Ngay_Phat = Ham_Dung_Chung.ConvertDateToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat").Value)
                .Gio_Phat = Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat").Value)
                .Ma_Xu_Ly = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Xu_Ly").Value
                .Ma_Ly_Do = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Ly_Do").Value
                .Phat_Duoc = False
                .Ghi_Chu = ""
                .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Now)
                .Truyen_Bao_Phat = False
            End With
            myNoiDung.Them(myNoiDungChiTiet)
            myBaoPhat.Convert(myBaoPhatChiTiet.Id_Bao_Phat)
        End If
    End Sub

    Private Sub dgChuaPhat_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgChuaPhat.AfterExitEditMode
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell.Text Is Nothing Then
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Bao_Phat").Value Is System.DBNull.Value Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Ly_Do").Value = strLyDo
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Xu_Ly").Value = strXuLy
                    End If
            End Select
        End If
    End Sub
#Region "Truyen_Bao_Phat"
    Private Sub Truyen_Bao_Phat()
        Try
            Dim myDataSet As New DataSet
            Dim myDatatable As New DataTable
            Dim Ma_bc_phat As Integer

            Dim Ngaybd As Integer, NgayKT As Integer
            Ngaybd = Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value)
            NgayKT = Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            Ma_bc_phat = Convert.ToInt32(cbDuongThuDi.Value)
            Dim Num_Bao_Phat As Integer
            Dim Num_Noi_Dung_Phat As Integer
            'Neu chon thi moi cho truyen
            myDatatable = myBaoPhat.Danh_Sach_Chua_Truyen_Theo_Ma_Bc_phat(Ngaybd, NgayKT, Ma_bc_phat).Tables(0)
            'myDatatable = myBaoPhat.Danh_Sach.Tables(0)
            myDatatable.TableName = "Bao_Phat"
            Num_Bao_Phat = myDatatable.Rows.Count
            myDataSet.Tables.Add(myDatatable.Copy)

            myDatatable = myNoiDung.Danh_Sach_Chua_Truyen_Theo_Bc_Phat(Ngaybd, NgayKT, GBuu_Cuc_Khai_Thac, Ma_bc_phat).Tables(0)
            myDatatable.TableName = "Noi_Dung_Phat"
            Num_Noi_Dung_Phat = myDatatable.Rows.Count
            myDataSet.Tables.Add(myDatatable.Copy)
            If myUtility.Dang_Ky_Truyen("Ems_Bao_Phat", "Branch", "Center", GBuu_Cuc_Khai_Thac, 0, _
             Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", myDataSet) = 1 Then
                MessageBox.Show("Đã có lỗi trong quá trình đăng ký truyền !!!", "Thông báo")
            Else
                CMessageBox.Show(Convert.ToString(Num_Bao_Phat) + " bưu phẩm đã truyền thành công ")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub Truyen_Bao_Phat_Tat_Ca()
        Try
            Dim myDataSet As New DataSet
            Dim myDatatable As New DataTable
            Dim Ma_bc_phat As Integer

            Dim Ngaybd As Integer, NgayKT As Integer
            Ngaybd = Ham_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value)
            NgayKT = Ham_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            Ma_bc_phat = Convert.ToInt32(cbDuongThuDi.Value)
            Dim Num_Bao_Phat As Integer
            Dim Num_Noi_Dung_Phat As Integer
            'Neu chon thi moi cho truyen
            myDatatable = myBaoPhat.Danh_Sach_Chua_Truyen(Ngaybd, NgayKT).Tables(0)
            'myDatatable = myBaoPhat.Danh_Sach.Tables(0)
            myDatatable.TableName = "Bao_Phat"
            Num_Bao_Phat = myDatatable.Rows.Count
            myDataSet.Tables.Add(myDatatable.Copy)

            myDatatable = myNoiDung.Danh_Sach_Chua_Truyen(Ngaybd, NgayKT).Tables(0)
            myDatatable.TableName = "Noi_Dung_Phat"
            Num_Noi_Dung_Phat = myDatatable.Rows.Count
            myDataSet.Tables.Add(myDatatable.Copy)
            If myUtility.Dang_Ky_Truyen("Ems_Bao_Phat", "Branch", "Center", GBuu_Cuc_Khai_Thac, 0, _
             Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", myDataSet) = 1 Then
                MessageBox.Show("Đã có lỗi trong quá trình đăng ký truyền !!!", "Thông báo")
            Else
                CMessageBox.Show(Convert.ToString(Num_Bao_Phat) + " bưu phẩm đã truyền thành công ")
                chkAll.Checked = False
                cbDuongThuDi.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
    Private Sub btnCapnhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapnhat.Click
        If (chkAll.Checked = True) Then
            If (MessageBox.Show("Bạn có chắc sẽ truyền tất cả  ???", "Truyền báo phát", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                Truyen_Bao_Phat()
            Else
                chkAll.Checked = False
                cbDuongThuDi.Enabled = True
                Exit Sub
            End If
        Else
            Truyen_Bao_Phat()
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If (chkAll.Checked = True) Then
            cbDuongThuDi.Enabled = False
        Else
            cbDuongThuDi.Enabled = True
        End If

    End Sub
End Class

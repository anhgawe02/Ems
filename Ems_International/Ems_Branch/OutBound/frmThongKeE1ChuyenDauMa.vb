Imports Ems_International_Logic.EMS
Public Class frmThongKeE1ChuyenDauMa
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
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnThongTin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbMa_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnTruyen As System.Windows.Forms.Button
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents PrbTienTrinhTruyen As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents chkAll As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dgE1_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Dv")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_CH")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaUSPS")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnThongTin = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbMa_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnTruyen = New System.Windows.Forms.Button
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.PrbTienTrinhTruyen = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.chkAll = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgE1_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.btnThongTin)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.cbMa_Bc_Khai_Thac)
        Me.UltraGroupBox1.Controls.Add(Me.btnTruyen)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgayDinhDang)
        Me.UltraGroupBox1.Controls.Add(Me.chkAll)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(776, 64)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.Text = "Thông tin tìm kiếm"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "BC Khai Thác"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThongTin
        '
        Me.btnThongTin.Location = New System.Drawing.Point(448, 24)
        Me.btnThongTin.Name = "btnThongTin"
        Me.btnThongTin.Size = New System.Drawing.Size(104, 23)
        Me.btnThongTin.TabIndex = 3
        Me.btnThongTin.Text = "Lấy thông tin"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(112, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Đến"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(8, 24)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpTuNgay.TabIndex = 0
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(152, 24)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpDenNgay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Từ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMa_Bc_Khai_Thac
        '
        Me.cbMa_Bc_Khai_Thac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Tên BC Khai Thác"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Header.Caption = "Mã Ðu?ng Thu"
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbMa_Bc_Khai_Thac.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Khai_Thac.Location = New System.Drawing.Point(336, 24)
        Me.cbMa_Bc_Khai_Thac.Name = "cbMa_Bc_Khai_Thac"
        Me.cbMa_Bc_Khai_Thac.Size = New System.Drawing.Size(96, 21)
        Me.cbMa_Bc_Khai_Thac.TabIndex = 2
        Me.cbMa_Bc_Khai_Thac.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'btnTruyen
        '
        Me.btnTruyen.Location = New System.Drawing.Point(560, 24)
        Me.btnTruyen.Name = "btnTruyen"
        Me.btnTruyen.Size = New System.Drawing.Size(104, 23)
        Me.btnTruyen.TabIndex = 4
        Me.btnTruyen.Text = "Truyền dữ liệu"
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(496, -8)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 23)
        Me.dtpNgayDinhDang.TabIndex = 8
        Me.dtpNgayDinhDang.Visible = False
        '
        'PrbTienTrinhTruyen
        '
        Me.PrbTienTrinhTruyen.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTienTrinhTruyen.Location = New System.Drawing.Point(8, 504)
        Me.PrbTienTrinhTruyen.Maximum = 10000
        Me.PrbTienTrinhTruyen.Name = "PrbTienTrinhTruyen"
        Me.PrbTienTrinhTruyen.Size = New System.Drawing.Size(760, 32)
        Me.PrbTienTrinhTruyen.Step = 1
        Me.PrbTienTrinhTruyen.TabIndex = 74
        Me.PrbTienTrinhTruyen.Text = "[Formatted]"
        '
        'chkAll
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.chkAll.Appearance = Appearance3
        Me.chkAll.Location = New System.Drawing.Point(672, 24)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(96, 16)
        Me.chkAll.TabIndex = 73
        Me.chkAll.Text = "Chọn tất cả"
        '
        'dgE1_Den
        '
        Me.dgE1_Den.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgE1_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Den.DisplayLayout.Appearance = Appearance4
        UltraGridBand2.CardSettings.ShowCaption = False
        UltraGridColumn4.Header.Caption = "Id E1"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "ID Đường Thư"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "ID_E2"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "ID Ca"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.Caption = "Quầy"
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Mã E1"
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Ngày Đóng"
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Giờ Đóng"
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Ngày Nhận"
        UltraGridColumn16.Header.VisiblePosition = 13
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Giờ Nhận"
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn18.Header.VisiblePosition = 15
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 81
        UltraGridColumn20.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Width = 79
        UltraGridColumn21.Header.Caption = "Nước Nhận"
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 63
        UltraGridColumn22.Header.Caption = "Nước Trả"
        UltraGridColumn22.Header.VisiblePosition = 19
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Width = 59
        UltraGridColumn23.Header.Caption = "Khối Lượng"
        UltraGridColumn23.Header.VisiblePosition = 20
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Width = 68
        UltraGridColumn24.Header.Caption = "Phân Loại"
        UltraGridColumn24.Header.VisiblePosition = 21
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 66
        UltraGridColumn25.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Width = 85
        UltraGridColumn26.Header.Caption = "Khối Lượng QD"
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "Loại"
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(57, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Width = 51
        UltraGridColumn28.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Thuế VAT"
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Dv COD"
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.Caption = "Cước COD"
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.Header.Caption = "Cước DV"
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.Header.Caption = "Cước Chính"
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Cước Giảm"
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.Caption = "Cước E1"
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.DefaultCellValue = "0"
        UltraGridColumn42.Header.Caption = "Kiện Số"
        UltraGridColumn42.Header.VisiblePosition = 22
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Width = 68
        UltraGridColumn43.Header.VisiblePosition = 41
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.Caption = "Mã KH"
        UltraGridColumn44.Header.VisiblePosition = 42
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.DefaultCellValue = ""
        UltraGridColumn45.Header.Caption = "Người Gửi"
        UltraGridColumn45.Header.VisiblePosition = 43
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.DefaultCellValue = ""
        UltraGridColumn46.Header.Caption = "Người Nhận"
        UltraGridColumn46.Header.VisiblePosition = 44
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.DefaultCellValue = ""
        UltraGridColumn47.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn47.Header.VisiblePosition = 45
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(360, 0)
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.DefaultCellValue = ""
        UltraGridColumn48.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn48.Header.VisiblePosition = 46
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(374, 0)
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.DefaultCellValue = ""
        UltraGridColumn49.Header.Caption = "ĐT Gửi"
        UltraGridColumn49.Header.VisiblePosition = 47
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.DefaultCellValue = ""
        UltraGridColumn50.Header.Caption = "ĐT Nhận"
        UltraGridColumn50.Header.VisiblePosition = 48
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.Caption = "HH Phát Hành"
        UltraGridColumn51.Header.VisiblePosition = 49
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "HH Phát Trả"
        UltraGridColumn52.Header.VisiblePosition = 50
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn53.Header.VisiblePosition = 51
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.Caption = "ID Người Dùng"
        UltraGridColumn54.Header.VisiblePosition = 52
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.Caption = "ID Trạng Thái"
        UltraGridColumn55.Header.VisiblePosition = 53
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.DefaultCellValue = ""
        UltraGridColumn56.Header.Caption = "Ghi Chú"
        UltraGridColumn56.Header.VisiblePosition = 54
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(138, 0)
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.DefaultCellValue = "0"
        UltraGridColumn57.Header.VisiblePosition = 55
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 56
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 57
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.Caption = "Lệ Phí HQ"
        UltraGridColumn60.Header.VisiblePosition = 58
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Thuế Nhập khẩu"
        UltraGridColumn61.Header.VisiblePosition = 59
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.Caption = "Thuế VAT"
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.Caption = "Thuế NK+VAT"
        UltraGridColumn63.Header.VisiblePosition = 60
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.Caption = "Số TKHQ"
        UltraGridColumn64.Header.VisiblePosition = 62
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.Caption = "Số Biên Lai"
        UltraGridColumn65.Header.VisiblePosition = 63
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.Caption = "Lệ Phí Văn Hóa"
        UltraGridColumn66.Header.VisiblePosition = 64
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.Caption = "Lệ Phí Y Tế"
        UltraGridColumn67.Header.VisiblePosition = 65
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.Caption = "Lệ Phí Dịch Vụ"
        UltraGridColumn68.Header.VisiblePosition = 66
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.Header.Caption = "Lệ Phí Thực Vật"
        UltraGridColumn69.Header.VisiblePosition = 67
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn70.Header.Caption = "Lệ Phí Khác"
        UltraGridColumn70.Header.VisiblePosition = 68
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn71.Header.Caption = "Tổng Thuế Lệ Phí"
        UltraGridColumn71.Header.VisiblePosition = 69
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn72.Header.Caption = "Chọn"
        UltraGridColumn72.Header.VisiblePosition = 23
        UltraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn72.Width = 40
        UltraGridColumn73.Header.Caption = "Mã E1 Gốc"
        UltraGridColumn73.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgE1_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgE1_Den.DisplayLayout.InterBandSpacing = 20
        Me.dgE1_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Den.DisplayLayout.Override.CardAreaAppearance = Appearance5
        Me.dgE1_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Den.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.dgE1_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance7.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.Override.RowAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance8
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance9
        Me.dgE1_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Den.Location = New System.Drawing.Point(0, 72)
        Me.dgE1_Den.Name = "dgE1_Den"
        Me.dgE1_Den.Size = New System.Drawing.Size(776, 424)
        Me.dgE1_Den.TabIndex = 75
        Me.dgE1_Den.Text = "Danh sách E1 đã chuyển mã"
        '
        'frmThongKeE1ChuyenDauMa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 538)
        Me.Controls.Add(Me.dgE1_Den)
        Me.Controls.Add(Me.PrbTienTrinhTruyen)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frmThongKeE1ChuyenDauMa"
        Me.Text = "Quản lý E1 chuyển  mã"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myCODDi As New COD_Di(GConnectionString)
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myTrang_Thai As New Trang_Thai(GConnectionString)
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
    Dim myTab As Boolean
    Dim myHamDungChung As Ham_Dung_Chung
    Private Sub frmThongKeE1ChuyenDauMa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTuNgay.Value = Now
        dtpDenNgay.Value = Now
        dtpTuNgay.Select()
        cbMa_Bc_Khai_Thac.DataSource = myMa_Bc_Khai_Thac.Danh_Sach
        cbMa_Bc_Khai_Thac.DataBind()
    End Sub

    Private Sub btnThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThongTin.Click
        chkAll.Checked = False
        Dim TuNgay As Integer = myHamDungChung.ConvertDateToInt(dtpTuNgay.Value)
        Dim DenNgay As Integer = myHamDungChung.ConvertDateToInt(dtpDenNgay.Value)
        If cbMa_Bc_Khai_Thac.Text <> "" Then
            dgE1_Den.DataSource = myE1_Den.Lay_Danh_Sach_E1_Den_Da_Chuyen_Ma(GBuu_Cuc_Khai_Thac, TuNgay, DenNgay)
            dgE1_Den.DataBind()
        Else
            CMessageBox.Show("Bạn chưa chọn bưu cục khai thác")
            Exit Sub
        End If
    End Sub
    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim i As Integer
        For i = 0 To dgE1_Den.Rows.Count - 1
            dgE1_Den.Rows(i).Cells("Truyen").Value = chkAll.Checked
        Next
    End Sub

    Private Sub btnTruyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen.Click
        Try
            Dim myE1_USPS As New E1_USPS.E1_MAP
            'Process Bar
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            PrbTienTrinhTruyen.Maximum = dgE1_Den.Rows.Count
            PrbTienTrinhTruyen.Step = 1
            PrbTienTrinhTruyen.Value = 0
            'Truyền lên center
            Dim i As Integer
            For i = 0 To CInt(dgE1_Den.Rows.Count - 1)
                If (dgE1_Den.Rows(i).Cells("Truyen").Value = 1) Then
                    myE1_USPS.E1_USPS_Cap_Nhat_Them(dgE1_Den.Rows(i).Cells("Ma_E1").Value, dgE1_Den.Rows(i).Cells("MAUSPS").Value, 0)
                End If
                PrbTienTrinhTruyen.PerformStep()
                PrbTienTrinhTruyen.Text = "( " & PrbTienTrinhTruyen.Value & "  /  " & PrbTienTrinhTruyen.Maximum & " )"
                Application.DoEvents()
            Next
            Me.ActiveForm.Cursor.Current = Cursors.Default
            CMessageBox.Show("Truyền dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            CMessageBox.Show("Lỗi truyền dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class

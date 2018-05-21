Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports System.Web.Services
Public Class frmChuyenMaE1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Public Sub New(ByVal Id_E2 As String, ByVal Tu_Dau_Ma As String, ByVal Den_Dau_Ma As String)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        _Id_E2 = Id_E2
        _Tu_Dau_Ma = Tu_Dau_Ma
        _Den_Dau_Ma = Den_Dau_Ma
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
    Friend WithEvents dgE1_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnTruyenService As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtThongTin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents PrbTienTrinhTruyen As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents btnRefresh As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTruyenLai As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Dv")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_CH")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MaUSPS")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dgE1_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnTruyenService = New Infragistics.Win.Misc.UltraButton
        Me.txtThongTin = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.PrbTienTrinhTruyen = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnRefresh = New Infragistics.Win.Misc.UltraButton
        Me.btnTruyenLai = New Infragistics.Win.Misc.UltraButton
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgE1_Den
        '
        Me.dgE1_Den.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgE1_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Den.DisplayLayout.Appearance = Appearance1
        UltraGridBand1.CardSettings.ShowCaption = False
        UltraGridColumn1.Header.Caption = "Id E1"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "ID Đường Thư"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "ID_E2"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "ID Ca"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Quầy"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Mã E1 Mới"
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Ngày Đóng"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Caption = "Giờ Đóng"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Ngày Nhận"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Giờ Nhận"
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Width = 81
        UltraGridColumn17.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Width = 79
        UltraGridColumn18.Header.Caption = "Nước Nhận"
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Width = 63
        UltraGridColumn19.Header.Caption = "Nước Trả"
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Width = 53
        UltraGridColumn20.Header.Caption = "Khối Lượng"
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Width = 68
        UltraGridColumn21.Header.Caption = "Phân Loại"
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 55
        UltraGridColumn22.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn22.Header.VisiblePosition = 24
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Width = 85
        UltraGridColumn23.Header.Caption = "Khối Lượng QD"
        UltraGridColumn23.Header.VisiblePosition = 25
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.Caption = "Loại"
        UltraGridColumn24.Header.VisiblePosition = 26
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(57, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Width = 51
        UltraGridColumn25.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn25.Header.VisiblePosition = 27
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn26.Header.VisiblePosition = 28
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn27.Header.VisiblePosition = 29
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn28.Header.VisiblePosition = 30
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 31
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn30.Header.VisiblePosition = 32
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.Caption = "Thuế VAT"
        UltraGridColumn31.Header.VisiblePosition = 33
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Dv COD"
        UltraGridColumn32.Header.VisiblePosition = 34
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn33.Header.VisiblePosition = 35
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Cước COD"
        UltraGridColumn34.Header.VisiblePosition = 36
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.Header.Caption = "Cước DV"
        UltraGridColumn35.Header.VisiblePosition = 37
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.Caption = "Cước Chính"
        UltraGridColumn36.Header.VisiblePosition = 38
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.Caption = "Cước Giảm"
        UltraGridColumn37.Header.VisiblePosition = 39
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "Cước E1"
        UltraGridColumn38.Header.VisiblePosition = 40
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.DefaultCellValue = "0"
        UltraGridColumn39.Header.Caption = "Kiện Số"
        UltraGridColumn39.Header.VisiblePosition = 22
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Width = 48
        UltraGridColumn40.Header.VisiblePosition = 41
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.Caption = "Mã KH"
        UltraGridColumn41.Header.VisiblePosition = 42
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.DefaultCellValue = ""
        UltraGridColumn42.Header.Caption = "Người Gửi"
        UltraGridColumn42.Header.VisiblePosition = 43
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.DefaultCellValue = ""
        UltraGridColumn43.Header.Caption = "Người Nhận"
        UltraGridColumn43.Header.VisiblePosition = 44
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.DefaultCellValue = ""
        UltraGridColumn44.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn44.Header.VisiblePosition = 45
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(360, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.DefaultCellValue = ""
        UltraGridColumn45.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn45.Header.VisiblePosition = 46
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(374, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.DefaultCellValue = ""
        UltraGridColumn46.Header.Caption = "ĐT Gửi"
        UltraGridColumn46.Header.VisiblePosition = 47
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.DefaultCellValue = ""
        UltraGridColumn47.Header.Caption = "ĐT Nhận"
        UltraGridColumn47.Header.VisiblePosition = 48
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.Caption = "HH Phát Hành"
        UltraGridColumn48.Header.VisiblePosition = 49
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "HH Phát Trả"
        UltraGridColumn49.Header.VisiblePosition = 50
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn50.Header.VisiblePosition = 51
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "ID Người Dùng"
        UltraGridColumn51.Header.VisiblePosition = 52
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "ID Trạng Thái"
        UltraGridColumn52.Header.VisiblePosition = 53
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.DefaultCellValue = ""
        UltraGridColumn53.Header.Caption = "Ghi Chú"
        UltraGridColumn53.Header.VisiblePosition = 54
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(138, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.DefaultCellValue = "0"
        UltraGridColumn54.Header.VisiblePosition = 55
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 56
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 57
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.Caption = "Lệ Phí HQ"
        UltraGridColumn57.Header.VisiblePosition = 58
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Header.Caption = "Thuế Nhập khẩu"
        UltraGridColumn58.Header.VisiblePosition = 59
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.Caption = "Thuế VAT"
        UltraGridColumn59.Header.VisiblePosition = 61
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Header.Caption = "Thuế NK+VAT"
        UltraGridColumn60.Header.VisiblePosition = 60
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Số TKHQ"
        UltraGridColumn61.Header.VisiblePosition = 62
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.Caption = "Số Biên Lai"
        UltraGridColumn62.Header.VisiblePosition = 63
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.Caption = "Lệ Phí Văn Hóa"
        UltraGridColumn63.Header.VisiblePosition = 64
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.Caption = "Lệ Phí Y Tế"
        UltraGridColumn64.Header.VisiblePosition = 65
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.Caption = "Lệ Phí Dịch Vụ"
        UltraGridColumn65.Header.VisiblePosition = 66
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.Caption = "Lệ Phí Thực Vật"
        UltraGridColumn66.Header.VisiblePosition = 67
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.Caption = "Lệ Phí Khác"
        UltraGridColumn67.Header.VisiblePosition = 68
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.Caption = "Tổng Thuế Lệ Phí"
        UltraGridColumn68.Header.VisiblePosition = 69
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.Header.Caption = "Mã E1 Gốc"
        UltraGridColumn69.Header.VisiblePosition = 7
        UltraGridColumn70.Header.Caption = "Chọn"
        UltraGridColumn70.Header.VisiblePosition = 23
        UltraGridColumn70.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn70.Width = 33
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgE1_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1_Den.DisplayLayout.InterBandSpacing = 20
        Me.dgE1_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Den.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE1_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Den.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgE1_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE1_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Den.Location = New System.Drawing.Point(0, 136)
        Me.dgE1_Den.Name = "dgE1_Den"
        Me.dgE1_Den.Size = New System.Drawing.Size(608, 296)
        Me.dgE1_Den.TabIndex = 76
        Me.dgE1_Den.Text = "Danh sách E1 phải chuyển mã"
        '
        'btnTruyenService
        '
        Me.btnTruyenService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyenService.Location = New System.Drawing.Point(496, 7)
        Me.btnTruyenService.Name = "btnTruyenService"
        Me.btnTruyenService.Size = New System.Drawing.Size(104, 29)
        Me.btnTruyenService.TabIndex = 77
        Me.btnTruyenService.Text = "Chuyển đổi"
        '
        'txtThongTin
        '
        Me.txtThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThongTin.Location = New System.Drawing.Point(6, 8)
        Me.txtThongTin.Multiline = True
        Me.txtThongTin.Name = "txtThongTin"
        Me.txtThongTin.Size = New System.Drawing.Size(485, 91)
        Me.txtThongTin.TabIndex = 79
        '
        'PrbTienTrinhTruyen
        '
        Me.PrbTienTrinhTruyen.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTienTrinhTruyen.Location = New System.Drawing.Point(6, 102)
        Me.PrbTienTrinhTruyen.Maximum = 10000
        Me.PrbTienTrinhTruyen.Name = "PrbTienTrinhTruyen"
        Me.PrbTienTrinhTruyen.Size = New System.Drawing.Size(594, 32)
        Me.PrbTienTrinhTruyen.Step = 1
        Me.PrbTienTrinhTruyen.TabIndex = 80
        Me.PrbTienTrinhTruyen.Text = "[Formatted]"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(496, 39)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 29)
        Me.btnRefresh.TabIndex = 81
        Me.btnRefresh.Text = "In lại"
        '
        'btnTruyenLai
        '
        Me.btnTruyenLai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyenLai.Location = New System.Drawing.Point(496, 72)
        Me.btnTruyenLai.Name = "btnTruyenLai"
        Me.btnTruyenLai.Size = New System.Drawing.Size(104, 29)
        Me.btnTruyenLai.TabIndex = 82
        Me.btnTruyenLai.Text = "Truyền lại"
        '
        'frmChuyenMaE1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 431)
        Me.Controls.Add(Me.btnTruyenLai)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.PrbTienTrinhTruyen)
        Me.Controls.Add(Me.txtThongTin)
        Me.Controls.Add(Me.btnTruyenService)
        Me.Controls.Add(Me.dgE1_Den)
        Me.Name = "frmChuyenMaE1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chuyển đầu mã E1"
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim _Id_E2, _Tu_Dau_Ma, _Den_Dau_Ma As String
    Dim myE1_Den As New E1_Den(GConnectionString)
    Private Sub frmChuyenMaE1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgE1_Den.DataSource = myE1_Den.E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma(_Id_E2, _Tu_Dau_Ma, "").Tables(0)
        txtThongTin.Text = "Xác nhận đến E2 - chuyển đổi mã E1 từ đầu mã " & _Tu_Dau_Ma & " sang đầu mã " & _Den_Dau_Ma
    End Sub

    Private Sub btnTruyenService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyenService.Click
        If MessageBox.Show("Bạn có thực sự muốn CHUYỂN ĐỔI ĐẦU MÃ E1 từ :  " & _Tu_Dau_Ma & "  =====>  " & _Den_Dau_Ma & "  Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            'Chuyen dau ma
            myE1_Den.E1_Den_Chuyen_Doi_Dau_Ma(_Id_E2, _Tu_Dau_Ma, _Den_Dau_Ma)
            'Truyen len center
            Dim myE1_USPS As New E1_USPS.E1_MAP
            Dim mydata As New DataTable
            'Process Bar
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            PrbTienTrinhTruyen.Maximum = dgE1_Den.Rows.Count
            PrbTienTrinhTruyen.Step = 1
            PrbTienTrinhTruyen.Value = 0
            'Thuc hien truyen
            mydata = myE1_Den.Danh_Sach_E1_USPS(_Id_E2, _Tu_Dau_Ma).Tables(0)
            Dim i As Integer
            For i = 0 To CInt(mydata.Rows.Count - 1)
                myE1_USPS.E1_USPS_Cap_Nhat_Them(mydata.Rows(i).Item("Ma_E1"), mydata.Rows(i).Item("MAUSPS"), 0)
                'Ve lai tien trinh truyen
                PrbTienTrinhTruyen.PerformStep()
                PrbTienTrinhTruyen.Text = "( " & PrbTienTrinhTruyen.Value & "  /  " & PrbTienTrinhTruyen.Maximum & " )"
                Application.DoEvents()
            Next
            'Ket thuc truyen
            Me.ActiveForm.Cursor.Current = Cursors.Default
            CMessageBox.Show("Truyền dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'In bang ke E1 ma vach moi
            If MessageBox.Show("Bạn có muốn in lại mã E1 mới?" & vbNewLine & "Chọn YES để in hoặc NO để xem trước khi in", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Thuc hien in
                InBarcode(False)
            Else
                'Thuc hien view
                InBarcode(True)
            End If
            'Load lại dữ liệu grid
            dgE1_Den.DataSource = myE1_Den.E1_Den_Danh_Sach_Phai_Chuyen_Doi_Lay_Boi_Id_E2_Dau_Ma(_Id_E2, _Tu_Dau_Ma, _Den_Dau_Ma).Tables(0)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub InBarcode(ByVal preview As Boolean)
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mydata As DataTable
        Dim rptAutoE1 As New RptAuto_E1
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Dim dataTable As New DataTable("Bang_Ma_E1")
        Dim i, j As Integer
        Dim myMa_E1 As String
        Try
            'tao bang
            Dim colWork As DataColumn = New DataColumn("E1_1", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("E1_2", GetType(String))
            dataTable.Columns.Add(colWork)

            colWork = New DataColumn("E1_3", GetType(String))
            dataTable.Columns.Add(colWork)

            colWork = New DataColumn("E1_4", GetType(String))
            dataTable.Columns.Add(colWork)

            colWork = New DataColumn("E1_5", GetType(String))
            dataTable.Columns.Add(colWork)

            mydata = myE1_Den.Danh_Sach_E1(_Id_E2).Tables(0)
            Dim row As DataRow
            For i = 0 To CInt(mydata.Rows.Count)
                row = dataTable.NewRow()
                If i = mydata.Rows.Count Then
                    Exit For
                End If
                row("E1_1") = "*" & mydata.Rows(i).Item("Ma_E1") & "*"
                i = i + 1
                If i = mydata.Rows.Count Then
                    dataTable.Rows.Add(row)
                    Exit For
                End If
                row("E1_2") = "*" & mydata.Rows(i).Item("Ma_E1") & "*"
                i = i + 1
                If i = mydata.Rows.Count Then
                    dataTable.Rows.Add(row)
                    Exit For
                End If
                row("E1_3") = "*" & mydata.Rows(i).Item("Ma_E1") & "*"
                i = i + 1
                If i = mydata.Rows.Count Then
                    dataTable.Rows.Add(row)
                    Exit For
                End If
                row("E1_4") = "*" & mydata.Rows(i).Item("Ma_E1") & "*"
                i = i + 1
                If i = mydata.Rows.Count Then
                    dataTable.Rows.Add(row)
                    Exit For
                End If
                row("E1_5") = "*" & mydata.Rows(i).Item("Ma_E1") & "*"
                dataTable.Rows.Add(row)
            Next
            mydata = dataTable
            If mydata.Rows.Count > 0 Then
                rptAutoE1.SetDataSource(mydata)
                FrmView.CrystalReportViewer1.ReportSource = rptAutoE1
                Cursor.Current = Cursors.Default
                If preview = True Then
                    FrmView.ShowDialog()
                Else
                    rptAutoE1.PrintToPrinter(1, True, 0, 0)
                End If

            Else
                CMessageBox.Show("Không có thông tin dữ liệu về mã bưu phẩm này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        InBarcode(False)
    End Sub

    Private Sub dgE1_Den_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles dgE1_Den.InitializeRow
        If (CBool(e.Row.Cells("Truyen").Value) = True) Then
            e.Row.Appearance.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnTruyenLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyenLai.Click
        'Truyen len center
        Dim myE1_USPS As New E1_USPS.E1_MAP
        Dim mydata As New DataTable
        'Process Bar
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
        PrbTienTrinhTruyen.Maximum = dgE1_Den.Rows.Count
        PrbTienTrinhTruyen.Step = 1
        PrbTienTrinhTruyen.Value = 0
        'Thuc hien truyen
        Try
            mydata = myE1_Den.Danh_Sach_E1_USPS(_Id_E2, _Tu_Dau_Ma).Tables(0)
            Dim i As Integer
            For i = 0 To CInt(mydata.Rows.Count - 1)
                myE1_USPS.E1_USPS_Cap_Nhat_Them(mydata.Rows(i).Item("Ma_E1"), mydata.Rows(i).Item("MAUSPS"), 0)
                'Ve lai tien trinh truyen
                PrbTienTrinhTruyen.PerformStep()
                PrbTienTrinhTruyen.Text = "( " & PrbTienTrinhTruyen.Value & "  /  " & PrbTienTrinhTruyen.Maximum & " )"
                Application.DoEvents()
            Next
        Catch ex As Exception

        End Try
        'Ket thuc truyen
        Me.ActiveForm.Cursor.Current = Cursors.Default
        CMessageBox.Show("Truyền dữ liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

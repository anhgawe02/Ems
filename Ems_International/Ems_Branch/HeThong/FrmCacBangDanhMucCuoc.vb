Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS
#Region "Các bảng danh mục Cước trong phần hệ thống"
Public Class FrmCacBangDanhMucCuoc
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
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddPhan_Loai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgKhuyen_Mai As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgCuoc_Vung_Xa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgCuoc_QT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddKhuVucQT As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgNuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddkhu_Vuc_TN As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgGiam_Gia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgCuoc_TN_TT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgCuoc_TN As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTinh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_Phat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_Dv_Cong_Them As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_Dv_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_DV_Khai_Gia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_PPXD_VAT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents Gb_Cau_Hinh As System.Windows.Forms.GroupBox
    Friend WithEvents Rd_Pc As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_May_Chu As System.Windows.Forms.RadioButton
    Friend WithEvents dgTmp_Nuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_QT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Vung_Xa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Khuyen_Mai As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Tinh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_TN As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_TN_TT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Phat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Giam_Gia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Dv_Cong_Them As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Dv_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Dv_Khai_Gia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_PPXD_VAT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents BtnLay_Danh_Muc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgdich_Vu As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_BC_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddDanh_Muc_BC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Tinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btntest As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgCuoc_TCT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgCuoc_Phat_Hanh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTmp_Cuoc_Phat_Hanh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddCach_Tinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtDinhDangTien As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cach_Tinh", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Cach_Tinh")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Cach_Tinh")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Bc", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Cha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cap_Buu_Cuc")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khuyen_Mai", -1)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Khuyen_Mai")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("He_So_Khuyen_Mai")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Vung_Xa", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Vung_Xa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Duoi")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Tren")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_QT", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_QT")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nuoc", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc", -1, "ddKhuVucQT")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai_BP", -1)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai_BP")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai_BP")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khuyen_Mai", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Khuyen_Mai")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("He_So_Khuyen_Mai")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Vung_Xa", -1)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Vung_Xa")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Duoi")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vung_Tren")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_QT", -1)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_QT")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khu_Vuc", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nuoc", -1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc", -1, "ddKhuVucQT")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_tinh", -1)
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Giam_Gia", -1)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Giam_Gia")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Chap_Nhan")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Phat_Tra")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("He_So_Giam_Gia")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_TN_TT", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_TN_TT")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_TN", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_TN")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoang_Cach")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Phat_Tra", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khu_Vuc_TN", -1)
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khu_Vuc")
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand20 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Giam_Gia", -1)
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Giam_Gia")
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Chap_Nhan")
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Phat_Tra")
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("He_So_Giam_Gia")
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand21 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_TN_TT", -1)
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_TN_TT")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand22 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_TN", -1)
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_TN")
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand23 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance250 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance251 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance252 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoang_Cach")
        Dim Appearance253 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Phat_Tra")
        Dim Appearance254 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance255 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance256 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance257 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance258 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance259 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance260 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand24 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Phat_hanh", -1)
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Phat")
        Dim Appearance261 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance262 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_NT")
        Dim Appearance263 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_LT")
        Dim Appearance264 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_QT")
        Dim Appearance265 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance266 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance267 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance268 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance269 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance270 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance271 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance272 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance273 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand25 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Phat_hanh", -1)
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Phat")
        Dim Appearance274 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance275 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_NT")
        Dim Appearance276 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_LT")
        Dim Appearance277 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_QT")
        Dim Appearance278 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance279 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance280 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance281 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance282 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance283 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance284 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance285 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance286 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand26 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Phat", -1)
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Phat")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance287 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance288 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quoc_Te")
        Dim Appearance289 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance290 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance291 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance292 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance293 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance294 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance295 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance296 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance297 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance298 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance299 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance300 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance301 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance302 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance303 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance304 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand27 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Phat", -1)
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Phat")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim Appearance305 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance306 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quoc_Te")
        Dim Appearance307 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance308 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance309 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance310 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance311 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance312 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance313 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance314 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance315 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance316 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance317 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance318 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance319 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance320 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance321 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance322 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand28 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dich_Vu", -1)
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance323 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu")
        Dim Appearance324 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance325 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance326 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance327 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand29 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Cong_Them", -1)
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dv_Cong_Them")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance328 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance329 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance330 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance331 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance332 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance333 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance334 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance335 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance336 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance337 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand30 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Cong_Them", -1)
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dv_Cong_Them")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance338 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance339 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance340 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance341 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance342 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance343 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance344 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance345 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance346 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance347 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand31 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Gia_Tang", -1)
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Dv")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance348 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance349 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance350 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance351 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance352 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance353 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance354 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance355 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance356 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance357 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance358 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance359 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance360 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand32 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Gia_Tang", -1)
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Dv")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance361 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance362 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance363 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance364 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance365 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance366 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance367 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance368 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance369 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance370 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance371 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance372 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance373 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand33 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Khai_Gia", -1)
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Khai_Gia")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance374 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance375 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Toi_Thieu")
        Dim Appearance376 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance377 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance378 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance379 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance380 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance381 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance382 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance383 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance384 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand34 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_Dv_Khai_Gia", -1)
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_Khai_Gia")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim Appearance385 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance386 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Toi_Thieu")
        Dim Appearance387 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance388 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance389 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance390 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance391 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance392 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance393 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance394 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance395 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand35 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_PPXD_VAT", -1)
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_PPXD_Vat")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance396 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance397 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim Appearance398 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_QT")
        Dim Appearance399 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_TN_LT")
        Dim Appearance400 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_TN_NT")
        Dim Appearance401 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance402 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance403 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance404 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance405 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance406 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance407 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand36 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_PPXD_VAT", -1)
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_PPXD_Vat")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance408 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance409 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim Appearance410 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_QT")
        Dim Appearance411 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_TN_LT")
        Dim Appearance412 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD_TN_NT")
        Dim Appearance413 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance414 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance415 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance416 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance417 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance418 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance419 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand37 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Cuoc_TCT", -1)
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Cuoc_TCT")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cach_Tinh")
        Dim Appearance420 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nac_Gui")
        Dim Appearance421 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Tram_Cuoc")
        Dim Appearance422 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tu_Ngay")
        Dim Appearance423 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Den_Ngay")
        Dim Appearance424 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Toi_Thieu")
        Dim Appearance425 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc")
        Dim Appearance426 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance427 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance428 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance429 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance430 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance431 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance432 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCacBangDanhMucCuoc))
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txtDinhDangTien = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddCach_Tinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddDanh_Muc_BC = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_BC_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgTmp_Khuyen_Mai = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Cuoc_Vung_Xa = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Cuoc_QT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Nuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ddPhan_Loai_BP = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgKhuyen_Mai = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_Vung_Xa = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_QT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ddKhuVucQT = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgNuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgTmp_Giam_Gia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Cuoc_TN_TT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Cuoc_TN = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTmp_Tinh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.ddkhu_Vuc_TN = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgGiam_Gia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_TN_TT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_TN = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgTinh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTmp_Cuoc_Phat_Hanh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_Phat_Hanh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTmp_Cuoc_Phat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_Phat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgdich_Vu = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgTmp_Cuoc_Dv_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_Dv_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTmp_Cuoc_Dv_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_Dv_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTmp_Cuoc_Dv_Khai_Gia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_DV_Khai_Gia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTmp_Cuoc_PPXD_VAT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgCuoc_PPXD_VAT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgCuoc_TCT = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.BtnLay_Danh_Muc = New Infragistics.Win.Misc.UltraButton
        Me.Gb_Cau_Hinh = New System.Windows.Forms.GroupBox
        Me.Rd_May_Chu = New System.Windows.Forms.RadioButton
        Me.Rd_Pc = New System.Windows.Forms.RadioButton
        Me.btntest = New Infragistics.Win.Misc.UltraButton
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDinhDangTien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ddCach_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDanh_Muc_BC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Khuyen_Mai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Cuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Cuoc_QT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgKhuyen_Mai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_QT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddKhuVucQT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ddMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Giam_Gia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Cuoc_TN_TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Cuoc_TN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddkhu_Vuc_TN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGiam_Gia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_TN_TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_TN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.dgTmp_Cuoc_Phat_Hanh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_Phat_Hanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgTmp_Cuoc_Phat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_Phat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dgdich_Vu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTmp_Cuoc_Dv_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_Dv_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.dgTmp_Cuoc_Dv_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_Dv_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.dgTmp_Cuoc_Dv_Khai_Gia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_DV_Khai_Gia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.dgTmp_Cuoc_PPXD_VAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuoc_PPXD_VAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.dgCuoc_TCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Gb_Cau_Hinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(112, 8)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDinhDang.TabIndex = 55
        Me.dtpNgayDinhDang.Value = New Date(2008, 8, 3, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'txtDinhDangTien
        '
        Me.txtDinhDangTien.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.txtDinhDangTien.Location = New System.Drawing.Point(350, 279)
        Me.txtDinhDangTien.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtDinhDangTien.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtDinhDangTien.MaskInput = "n,nnn,nnn,nnn"
        Me.txtDinhDangTien.Name = "txtDinhDangTien"
        Me.txtDinhDangTien.Size = New System.Drawing.Size(83, 21)
        Me.txtDinhDangTien.TabIndex = 88
        Me.txtDinhDangTien.Visible = False
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ddCach_Tinh)
        Me.UltraTabPageControl1.Controls.Add(Me.ddDanh_Muc_BC)
        Me.UltraTabPageControl1.Controls.Add(Me.ddMa_BC_Khai_Thac)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTmp_Khuyen_Mai)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTmp_Cuoc_Vung_Xa)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTmp_Cuoc_QT)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTmp_Nuoc)
        Me.UltraTabPageControl1.Controls.Add(Me.ddPhan_Loai_BP)
        Me.UltraTabPageControl1.Controls.Add(Me.dgKhuyen_Mai)
        Me.UltraTabPageControl1.Controls.Add(Me.dgCuoc_Vung_Xa)
        Me.UltraTabPageControl1.Controls.Add(Me.dgCuoc_QT)
        Me.UltraTabPageControl1.Controls.Add(Me.ddKhuVucQT)
        Me.UltraTabPageControl1.Controls.Add(Me.dgNuoc)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(780, 513)
        '
        'ddCach_Tinh
        '
        Me.ddCach_Tinh.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddCach_Tinh.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance2
        UltraGridColumn2.Header.Caption = "Cách tính"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ddCach_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddCach_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.ddCach_Tinh.DisplayMember = "Ten_Cach_Tinh"
        Me.ddCach_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddCach_Tinh.Location = New System.Drawing.Point(286, 203)
        Me.ddCach_Tinh.Name = "ddCach_Tinh"
        Me.ddCach_Tinh.Size = New System.Drawing.Size(106, 120)
        Me.ddCach_Tinh.TabIndex = 49
        Me.ddCach_Tinh.Text = "Danh Mục Bưu cục"
        Me.ddCach_Tinh.ValueMember = "Ma_Cach_Tinh"
        Me.ddCach_Tinh.Visible = False
        '
        'ddDanh_Muc_BC
        '
        Me.ddDanh_Muc_BC.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDanh_Muc_BC.DisplayLayout.Appearance = Appearance4
        UltraGridColumn3.Header.Caption = "Mã Bưu cục"
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Tên Bưu cục"
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.ddDanh_Muc_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDanh_Muc_BC.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.ddDanh_Muc_BC.DisplayMember = ""
        Me.ddDanh_Muc_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDanh_Muc_BC.Location = New System.Drawing.Point(24, 160)
        Me.ddDanh_Muc_BC.Name = "ddDanh_Muc_BC"
        Me.ddDanh_Muc_BC.Size = New System.Drawing.Size(208, 120)
        Me.ddDanh_Muc_BC.TabIndex = 48
        Me.ddDanh_Muc_BC.Text = "Danh Mục Bưu cục"
        Me.ddDanh_Muc_BC.ValueMember = ""
        Me.ddDanh_Muc_BC.Visible = False
        '
        'ddMa_BC_Khai_Thac
        '
        Me.ddMa_BC_Khai_Thac.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_BC_Khai_Thac.DisplayLayout.Appearance = Appearance6
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance7
        UltraGridColumn12.Header.Caption = "Mã bưu cục"
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn13.Header.Caption = "Tên Bưu cục"
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13})
        Me.ddMa_BC_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_BC_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.ddMa_BC_Khai_Thac.DisplayMember = ""
        Me.ddMa_BC_Khai_Thac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC_Khai_Thac.Location = New System.Drawing.Point(32, 272)
        Me.ddMa_BC_Khai_Thac.Name = "ddMa_BC_Khai_Thac"
        Me.ddMa_BC_Khai_Thac.Size = New System.Drawing.Size(208, 120)
        Me.ddMa_BC_Khai_Thac.TabIndex = 47
        Me.ddMa_BC_Khai_Thac.Text = "Mã Bưu cục khai thác"
        Me.ddMa_BC_Khai_Thac.ValueMember = ""
        Me.ddMa_BC_Khai_Thac.Visible = False
        '
        'dgTmp_Khuyen_Mai
        '
        Me.dgTmp_Khuyen_Mai.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Khuyen_Mai.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Appearance = Appearance9
        UltraGridBand4.AddButtonCaption = "Khuyến mại"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.Hidden = True
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance10
        UltraGridColumn15.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.MaskInput = "999999"
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.CellAppearance = Appearance11
        UltraGridColumn16.DefaultCellValue = ""
        UltraGridColumn16.Format = ""
        UltraGridColumn16.FormulaErrorValue = ""
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance12
        UltraGridColumn16.Header.Caption = "Mã nước"
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.MaskInput = ""
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance13
        UltraGridColumn17.Header.Caption = "Mã bưu cục"
        UltraGridColumn17.Header.VisiblePosition = 3
        UltraGridColumn17.MaskInput = "999999"
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.CellAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance15
        UltraGridColumn18.Header.Caption = "Phân loại BP"
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance16
        UltraGridColumn19.Header.Caption = "Hệ số Khuyến Mại"
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.MaskInput = ""
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn20.EditorControl = Me.dtpNgayDinhDang
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance17
        UltraGridColumn20.Header.Caption = "Từ ngày"
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.UseEditorMaskSettings = True
        UltraGridColumn21.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn21.EditorControl = Me.dtpNgayDinhDang
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance18
        UltraGridColumn21.Header.Caption = "Đến ngày"
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(91, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.UseEditorMaskSettings = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        UltraGridBand4.Header.Caption = "Khuyến mại"
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgTmp_Khuyen_Mai.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgTmp_Khuyen_Mai.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.RowAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.RowSelectorAppearance = Appearance22
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Khuyen_Mai.DisplayLayout.Override.SelectedRowAppearance = Appearance23
        Me.dgTmp_Khuyen_Mai.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Khuyen_Mai.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Khuyen_Mai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Khuyen_Mai.Location = New System.Drawing.Point(248, 360)
        Me.dgTmp_Khuyen_Mai.Name = "dgTmp_Khuyen_Mai"
        Me.dgTmp_Khuyen_Mai.Size = New System.Drawing.Size(536, 152)
        Me.dgTmp_Khuyen_Mai.TabIndex = 46
        Me.dgTmp_Khuyen_Mai.Text = "Khuyến mại"
        '
        'dgTmp_Cuoc_Vung_Xa
        '
        Me.dgTmp_Cuoc_Vung_Xa.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.AddNewBox.Prompt = " "
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Appearance = Appearance24
        UltraGridBand5.AddButtonCaption = "Cước vùng xa"
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.CellAppearance = Appearance25
        UltraGridColumn23.DefaultCellValue = ""
        UltraGridColumn23.Format = ""
        UltraGridColumn23.FormulaErrorValue = ""
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance26
        UltraGridColumn23.Header.Caption = "Mã nước"
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.MaskInput = "AA"
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance27
        UltraGridColumn24.Header.Caption = "Vùng dưới"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(92, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance28
        UltraGridColumn25.Header.Caption = "Vùng trên"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance29
        UltraGridColumn26.Header.Caption = "Cước"
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.MaskInput = ""
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(98, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn27.EditorControl = Me.dtpNgayDinhDang
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance30
        UltraGridColumn27.Header.Caption = "Từ ngày"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.UseEditorMaskSettings = True
        UltraGridColumn28.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn28.EditorControl = Me.dtpNgayDinhDang
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance31
        UltraGridColumn28.Header.Caption = "Đến ngày"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(118, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.UseEditorMaskSettings = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28})
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.CardAreaAppearance = Appearance32
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.ForeColor = System.Drawing.Color.Black
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance33.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.HeaderAppearance = Appearance33
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance34.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.RowAppearance = Appearance34
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance35.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.RowSelectorAppearance = Appearance35
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.Override.SelectedRowAppearance = Appearance36
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Vung_Xa.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Vung_Xa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Cuoc_Vung_Xa.Location = New System.Drawing.Point(248, 184)
        Me.dgTmp_Cuoc_Vung_Xa.Name = "dgTmp_Cuoc_Vung_Xa"
        Me.dgTmp_Cuoc_Vung_Xa.Size = New System.Drawing.Size(536, 176)
        Me.dgTmp_Cuoc_Vung_Xa.TabIndex = 45
        Me.dgTmp_Cuoc_Vung_Xa.Text = "Cước vùng xa"
        '
        'dgTmp_Cuoc_QT
        '
        Me.dgTmp_Cuoc_QT.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_QT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_QT.DisplayLayout.Appearance = Appearance37
        UltraGridColumn29.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn29.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(21, 0)
        UltraGridColumn29.Width = 20
        UltraGridColumn30.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.CellAppearance = Appearance38
        UltraGridColumn30.DefaultCellValue = ""
        UltraGridColumn30.Format = ""
        UltraGridColumn30.FormulaErrorValue = ""
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance39
        UltraGridColumn30.Header.Caption = "Mã nước"
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.MaskInput = "AA"
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Width = 75
        UltraGridColumn31.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.CellAppearance = Appearance40
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance41
        UltraGridColumn31.Header.Caption = "Phân loại BP"
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Width = 70
        Appearance42.Cursor = System.Windows.Forms.Cursors.Default
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.CellAppearance = Appearance42
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance43
        UltraGridColumn32.Header.Caption = "Cách tính"
        UltraGridColumn32.Header.VisiblePosition = 3
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Width = 70
        Appearance44.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn33.CellAppearance = Appearance44
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance45
        UltraGridColumn33.Header.Caption = "Khối lượng"
        UltraGridColumn33.Header.VisiblePosition = 4
        UltraGridColumn33.MaskInput = "9999999999"
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Width = 70
        Appearance46.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance46
        UltraGridColumn34.Header.Caption = "Cước"
        UltraGridColumn34.Header.VisiblePosition = 5
        UltraGridColumn34.MaskInput = ""
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Width = 70
        UltraGridColumn35.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn35.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn35.Format = ""
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance47
        UltraGridColumn35.Header.Caption = "Từ ngày"
        UltraGridColumn35.Header.VisiblePosition = 6
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.UseEditorMaskSettings = True
        UltraGridColumn35.Width = 65
        UltraGridColumn36.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn36.EditorControl = Me.dtpNgayDinhDang
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance48
        UltraGridColumn36.Header.Caption = "Đến ngày"
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.UseEditorMaskSettings = True
        UltraGridColumn36.Width = 65
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        UltraGridBand6.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand6.UseRowLayout = True
        Me.dgTmp_Cuoc_QT.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.dgTmp_Cuoc_QT.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.CardAreaAppearance = Appearance49
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.ForeColor = System.Drawing.Color.Black
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance50.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance51.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.RowAppearance = Appearance51
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance52.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.RowSelectorAppearance = Appearance52
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance53.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance53.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_QT.DisplayLayout.Override.SelectedRowAppearance = Appearance53
        Me.dgTmp_Cuoc_QT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_QT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_QT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Cuoc_QT.Location = New System.Drawing.Point(248, 8)
        Me.dgTmp_Cuoc_QT.Name = "dgTmp_Cuoc_QT"
        Me.dgTmp_Cuoc_QT.Size = New System.Drawing.Size(536, 176)
        Me.dgTmp_Cuoc_QT.TabIndex = 44
        Me.dgTmp_Cuoc_QT.Text = "Cước Quốc Tế"
        '
        'dgTmp_Nuoc
        '
        Me.dgTmp_Nuoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Nuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance54.BackColor = System.Drawing.Color.White
        Appearance54.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Nuoc.DisplayLayout.Appearance = Appearance54
        UltraGridColumn37.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.CellAppearance = Appearance55
        UltraGridColumn37.DefaultCellValue = ""
        UltraGridColumn37.Format = ""
        UltraGridColumn37.FormulaErrorValue = ""
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance56
        UltraGridColumn37.Header.Caption = "Mã nước"
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.MaskInput = "AA"
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn37.Width = 30
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance57
        UltraGridColumn38.Header.Caption = "Tên nước"
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.MaskInput = ""
        UltraGridColumn39.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.CellAppearance = Appearance58
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance59
        UltraGridColumn39.Header.Caption = "Mã khu vực"
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn39.Width = 30
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39})
        UltraGridBand7.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand7.UseRowLayout = True
        Me.dgTmp_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.dgTmp_Nuoc.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Nuoc.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Nuoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Nuoc.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Nuoc.DisplayLayout.Override.CardAreaAppearance = Appearance60
        Me.dgTmp_Nuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance61.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance61.ForeColor = System.Drawing.Color.Black
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance61.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Nuoc.DisplayLayout.Override.HeaderAppearance = Appearance61
        Me.dgTmp_Nuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance62.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Nuoc.DisplayLayout.Override.RowAppearance = Appearance62
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance63.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Nuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance63
        Me.dgTmp_Nuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Nuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance64.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance64.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Nuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance64
        Me.dgTmp_Nuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Nuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Nuoc.Location = New System.Drawing.Point(8, 8)
        Me.dgTmp_Nuoc.Name = "dgTmp_Nuoc"
        Me.dgTmp_Nuoc.Size = New System.Drawing.Size(242, 505)
        Me.dgTmp_Nuoc.TabIndex = 43
        Me.dgTmp_Nuoc.Text = "Danh mục nước"
        '
        'ddPhan_Loai_BP
        '
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhan_Loai_BP.DisplayLayout.Appearance = Appearance65
        UltraGridColumn40.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.CellAppearance = Appearance66
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance67
        UltraGridColumn40.Header.Caption = "Phân loại BP"
        UltraGridColumn40.Header.VisiblePosition = 0
        UltraGridColumn41.Header.Caption = "Tên phân loại BP"
        UltraGridColumn41.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn40, UltraGridColumn41})
        Me.ddPhan_Loai_BP.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance68.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance68.ForeColor = System.Drawing.Color.Black
        Appearance68.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhan_Loai_BP.DisplayLayout.Override.HeaderAppearance = Appearance68
        Me.ddPhan_Loai_BP.DisplayMember = ""
        Me.ddPhan_Loai_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhan_Loai_BP.Location = New System.Drawing.Point(544, 88)
        Me.ddPhan_Loai_BP.Name = "ddPhan_Loai_BP"
        Me.ddPhan_Loai_BP.Size = New System.Drawing.Size(208, 120)
        Me.ddPhan_Loai_BP.TabIndex = 42
        Me.ddPhan_Loai_BP.Text = "Phân loại Bưu phẩm"
        Me.ddPhan_Loai_BP.ValueMember = ""
        Me.ddPhan_Loai_BP.Visible = False
        '
        'dgKhuyen_Mai
        '
        Me.dgKhuyen_Mai.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgKhuyen_Mai.DisplayLayout.AddNewBox.Prompt = " "
        Appearance69.BackColor = System.Drawing.Color.White
        Appearance69.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgKhuyen_Mai.DisplayLayout.Appearance = Appearance69
        UltraGridBand9.AddButtonCaption = "Khuyến mại"
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn42.Hidden = True
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance70
        UltraGridColumn43.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.MaskInput = "999999"
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.CellAppearance = Appearance71
        UltraGridColumn44.DefaultCellValue = ""
        UltraGridColumn44.Format = ""
        UltraGridColumn44.FormulaErrorValue = ""
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance72
        UltraGridColumn44.Header.Caption = "Mã nước"
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.MaskInput = ""
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance73
        UltraGridColumn45.Header.Caption = "Mã bưu cục"
        UltraGridColumn45.Header.VisiblePosition = 3
        UltraGridColumn45.MaskInput = "999999"
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.CellAppearance = Appearance74
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance75
        UltraGridColumn46.Header.Caption = "Phân loại BP"
        UltraGridColumn46.Header.VisiblePosition = 4
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance76
        UltraGridColumn47.Header.Caption = "Hệ số Khuyến Mại"
        UltraGridColumn47.Header.VisiblePosition = 5
        UltraGridColumn47.MaskInput = ""
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn48.EditorControl = Me.dtpNgayDinhDang
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance77
        UltraGridColumn48.Header.Caption = "Từ ngày"
        UltraGridColumn48.Header.VisiblePosition = 6
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.UseEditorMaskSettings = True
        UltraGridColumn49.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn49.EditorControl = Me.dtpNgayDinhDang
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance78
        UltraGridColumn49.Header.Caption = "Đến ngày"
        UltraGridColumn49.Header.VisiblePosition = 7
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(91, 0)
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.UseEditorMaskSettings = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        UltraGridBand9.Header.Caption = "Khuyến mại"
        UltraGridBand9.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand9.UseRowLayout = True
        Me.dgKhuyen_Mai.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.dgKhuyen_Mai.DisplayLayout.InterBandSpacing = 10
        Me.dgKhuyen_Mai.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgKhuyen_Mai.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgKhuyen_Mai.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Me.dgKhuyen_Mai.DisplayLayout.Override.CardAreaAppearance = Appearance79
        Me.dgKhuyen_Mai.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance80.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance80.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance80.ForeColor = System.Drawing.Color.Black
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance80.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgKhuyen_Mai.DisplayLayout.Override.HeaderAppearance = Appearance80
        Me.dgKhuyen_Mai.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance81.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgKhuyen_Mai.DisplayLayout.Override.RowAppearance = Appearance81
        Appearance82.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance82.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance82.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgKhuyen_Mai.DisplayLayout.Override.RowSelectorAppearance = Appearance82
        Me.dgKhuyen_Mai.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgKhuyen_Mai.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance83.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance83.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.dgKhuyen_Mai.DisplayLayout.Override.SelectedRowAppearance = Appearance83
        Me.dgKhuyen_Mai.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgKhuyen_Mai.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgKhuyen_Mai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgKhuyen_Mai.Location = New System.Drawing.Point(248, 360)
        Me.dgKhuyen_Mai.Name = "dgKhuyen_Mai"
        Me.dgKhuyen_Mai.Size = New System.Drawing.Size(536, 152)
        Me.dgKhuyen_Mai.TabIndex = 41
        Me.dgKhuyen_Mai.Text = "Khuyến mại"
        '
        'dgCuoc_Vung_Xa
        '
        Me.dgCuoc_Vung_Xa.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_Vung_Xa.DisplayLayout.AddNewBox.Prompt = " "
        Appearance84.BackColor = System.Drawing.Color.White
        Appearance84.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Vung_Xa.DisplayLayout.Appearance = Appearance84
        UltraGridBand10.AddButtonCaption = "Cước vùng xa"
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance85.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.CellAppearance = Appearance85
        UltraGridColumn51.DefaultCellValue = ""
        UltraGridColumn51.Format = ""
        UltraGridColumn51.FormulaErrorValue = ""
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance86
        UltraGridColumn51.Header.Caption = "Mã nước"
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.MaskInput = "AA"
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance87
        UltraGridColumn52.Header.Caption = "Vùng dưới"
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(92, 0)
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        Appearance88.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance88
        UltraGridColumn53.Header.Caption = "Vùng trên"
        UltraGridColumn53.Header.VisiblePosition = 3
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        Appearance89.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance89
        UltraGridColumn54.Header.Caption = "Cước"
        UltraGridColumn54.Header.VisiblePosition = 4
        UltraGridColumn54.MaskInput = ""
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(98, 0)
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn55.EditorControl = Me.dtpNgayDinhDang
        Appearance90.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance90
        UltraGridColumn55.Header.Caption = "Từ ngày"
        UltraGridColumn55.Header.VisiblePosition = 5
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.UseEditorMaskSettings = True
        UltraGridColumn56.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn56.EditorControl = Me.dtpNgayDinhDang
        Appearance91.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance91
        UltraGridColumn56.Header.Caption = "Đến ngày"
        UltraGridColumn56.Header.VisiblePosition = 6
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(118, 0)
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.UseEditorMaskSettings = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56})
        UltraGridBand10.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand10.UseRowLayout = True
        Me.dgCuoc_Vung_Xa.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.dgCuoc_Vung_Xa.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.CardAreaAppearance = Appearance92
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance93.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance93.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.ForeColor = System.Drawing.Color.Black
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance93.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.HeaderAppearance = Appearance93
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance94.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowAppearance = Appearance94
        Appearance95.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance95.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSelectorAppearance = Appearance95
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance96.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance96.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Vung_Xa.DisplayLayout.Override.SelectedRowAppearance = Appearance96
        Me.dgCuoc_Vung_Xa.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Vung_Xa.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Vung_Xa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_Vung_Xa.Location = New System.Drawing.Point(248, 184)
        Me.dgCuoc_Vung_Xa.Name = "dgCuoc_Vung_Xa"
        Me.dgCuoc_Vung_Xa.Size = New System.Drawing.Size(536, 176)
        Me.dgCuoc_Vung_Xa.TabIndex = 40
        Me.dgCuoc_Vung_Xa.Text = "Cước vùng xa"
        '
        'dgCuoc_QT
        '
        Me.dgCuoc_QT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgCuoc_QT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance97.BackColor = System.Drawing.Color.White
        Appearance97.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_QT.DisplayLayout.Appearance = Appearance97
        UltraGridColumn57.AutoSizeEdit = Infragistics.Win.DefaultableBoolean.True
        UltraGridColumn57.AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(21, 0)
        UltraGridColumn57.Width = 20
        UltraGridColumn58.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.CellAppearance = Appearance98
        UltraGridColumn58.DefaultCellValue = ""
        UltraGridColumn58.Format = ""
        UltraGridColumn58.FormulaErrorValue = ""
        Appearance99.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance99
        UltraGridColumn58.Header.Caption = "Mã nước"
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.MaskInput = "AA"
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Width = 75
        UltraGridColumn59.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance100.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.CellAppearance = Appearance100
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance101
        UltraGridColumn59.Header.Caption = "Phân loại BP"
        UltraGridColumn59.Header.VisiblePosition = 2
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Width = 70
        Appearance102.Cursor = System.Windows.Forms.Cursors.Default
        Appearance102.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.CellAppearance = Appearance102
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance103
        UltraGridColumn60.Header.Caption = "Cách tính"
        UltraGridColumn60.Header.VisiblePosition = 3
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Width = 70
        Appearance104.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn61.CellAppearance = Appearance104
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn61.Header.Appearance = Appearance105
        UltraGridColumn61.Header.Caption = "Khối lượng"
        UltraGridColumn61.Header.VisiblePosition = 4
        UltraGridColumn61.MaskInput = "9999999999"
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Width = 70
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance106
        UltraGridColumn62.Header.Caption = "Cước"
        UltraGridColumn62.Header.VisiblePosition = 5
        UltraGridColumn62.MaskInput = ""
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Width = 70
        UltraGridColumn63.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn63.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn63.Format = ""
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance107
        UltraGridColumn63.Header.Caption = "Từ ngày"
        UltraGridColumn63.Header.VisiblePosition = 6
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 0)
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.UseEditorMaskSettings = True
        UltraGridColumn63.Width = 65
        UltraGridColumn64.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn64.EditorControl = Me.dtpNgayDinhDang
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance108
        UltraGridColumn64.Header.Caption = "Đến ngày"
        UltraGridColumn64.Header.VisiblePosition = 7
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.UseEditorMaskSettings = True
        UltraGridColumn64.Width = 65
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        UltraGridBand11.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand11.UseRowLayout = True
        Me.dgCuoc_QT.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.dgCuoc_QT.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_QT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_QT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_QT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_QT.DisplayLayout.Override.CardAreaAppearance = Appearance109
        Me.dgCuoc_QT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance110.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance110.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance110.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance110.ForeColor = System.Drawing.Color.Black
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance110.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_QT.DisplayLayout.Override.HeaderAppearance = Appearance110
        Me.dgCuoc_QT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance111.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_QT.DisplayLayout.Override.RowAppearance = Appearance111
        Appearance112.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance112.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_QT.DisplayLayout.Override.RowSelectorAppearance = Appearance112
        Me.dgCuoc_QT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_QT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance113.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance113.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance113.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_QT.DisplayLayout.Override.SelectedRowAppearance = Appearance113
        Me.dgCuoc_QT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_QT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_QT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_QT.Location = New System.Drawing.Point(248, 8)
        Me.dgCuoc_QT.Name = "dgCuoc_QT"
        Me.dgCuoc_QT.Size = New System.Drawing.Size(536, 176)
        Me.dgCuoc_QT.TabIndex = 39
        Me.dgCuoc_QT.Text = "Cước Quốc Tế"
        '
        'ddKhuVucQT
        '
        Appearance114.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddKhuVucQT.DisplayLayout.Appearance = Appearance114
        UltraGridColumn65.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.CellAppearance = Appearance115
        UltraGridColumn65.Header.Caption = "Mã khu vực"
        UltraGridColumn65.Header.VisiblePosition = 0
        UltraGridColumn66.Header.Caption = "Khu vực"
        UltraGridColumn66.Header.VisiblePosition = 1
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn65, UltraGridColumn66})
        Me.ddKhuVucQT.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Appearance116.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance116.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance116.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance116.ForeColor = System.Drawing.Color.Black
        Appearance116.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddKhuVucQT.DisplayLayout.Override.HeaderAppearance = Appearance116
        Me.ddKhuVucQT.DisplayMember = ""
        Me.ddKhuVucQT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddKhuVucQT.Location = New System.Drawing.Point(40, 120)
        Me.ddKhuVucQT.Name = "ddKhuVucQT"
        Me.ddKhuVucQT.Size = New System.Drawing.Size(208, 128)
        Me.ddKhuVucQT.TabIndex = 38
        Me.ddKhuVucQT.ValueMember = ""
        Me.ddKhuVucQT.Visible = False
        '
        'dgNuoc
        '
        Me.dgNuoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgNuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance117.BackColor = System.Drawing.Color.White
        Appearance117.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgNuoc.DisplayLayout.Appearance = Appearance117
        UltraGridColumn67.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn67.CellAppearance = Appearance118
        UltraGridColumn67.DefaultCellValue = ""
        UltraGridColumn67.Format = ""
        UltraGridColumn67.FormulaErrorValue = ""
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn67.Header.Appearance = Appearance119
        UltraGridColumn67.Header.Caption = "Mã nước"
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.MaskInput = "AA"
        UltraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn67.Width = 30
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn68.Header.Appearance = Appearance120
        UltraGridColumn68.Header.Caption = "Tên nước"
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.MaskInput = ""
        UltraGridColumn69.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.CellAppearance = Appearance121
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.Header.Appearance = Appearance122
        UltraGridColumn69.Header.Caption = "Mã khu vực"
        UltraGridColumn69.Header.VisiblePosition = 2
        UltraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn69.Width = 30
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69})
        UltraGridBand13.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand13.UseRowLayout = True
        Me.dgNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.dgNuoc.DisplayLayout.InterBandSpacing = 10
        Me.dgNuoc.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgNuoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgNuoc.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Me.dgNuoc.DisplayLayout.Override.CardAreaAppearance = Appearance123
        Me.dgNuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance124.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance124.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance124.ForeColor = System.Drawing.Color.Black
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance124.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgNuoc.DisplayLayout.Override.HeaderAppearance = Appearance124
        Me.dgNuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance125.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNuoc.DisplayLayout.Override.RowAppearance = Appearance125
        Appearance126.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance126.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance126.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgNuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance126
        Me.dgNuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgNuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance127.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance127.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance127.ForeColor = System.Drawing.Color.Black
        Me.dgNuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance127
        Me.dgNuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgNuoc.Location = New System.Drawing.Point(6, 7)
        Me.dgNuoc.Name = "dgNuoc"
        Me.dgNuoc.Size = New System.Drawing.Size(242, 505)
        Me.dgNuoc.TabIndex = 3
        Me.dgNuoc.Text = "Danh mục nước"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ddMa_Tinh)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTmp_Giam_Gia)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTmp_Cuoc_TN_TT)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTmp_Cuoc_TN)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTmp_Tinh)
        Me.UltraTabPageControl2.Controls.Add(Me.ddkhu_Vuc_TN)
        Me.UltraTabPageControl2.Controls.Add(Me.dgGiam_Gia)
        Me.UltraTabPageControl2.Controls.Add(Me.dgCuoc_TN_TT)
        Me.UltraTabPageControl2.Controls.Add(Me.dgCuoc_TN)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTinh)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(780, 529)
        '
        'ddMa_Tinh
        '
        Me.ddMa_Tinh.Cursor = System.Windows.Forms.Cursors.Default
        Appearance128.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Tinh.DisplayLayout.Appearance = Appearance128
        Appearance129.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance129
        UltraGridColumn70.Header.Caption = "Tên tỉnh"
        UltraGridColumn70.Header.VisiblePosition = 0
        Appearance130.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance130
        UltraGridColumn71.Header.Caption = "Mã tỉnh"
        UltraGridColumn71.Header.VisiblePosition = 3
        Appearance131.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance131
        UltraGridColumn72.Header.Caption = "Khu vực"
        UltraGridColumn72.Header.VisiblePosition = 1
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 2
        UltraGridColumn73.Hidden = True
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73})
        UltraGridBand14.Header.Caption = "Mã tỉnh"
        Me.ddMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Appearance132.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance132.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance132.ForeColor = System.Drawing.Color.Black
        Appearance132.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance132
        Me.ddMa_Tinh.DisplayMember = ""
        Me.ddMa_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Tinh.Location = New System.Drawing.Point(80, 208)
        Me.ddMa_Tinh.Name = "ddMa_Tinh"
        Me.ddMa_Tinh.Size = New System.Drawing.Size(208, 96)
        Me.ddMa_Tinh.TabIndex = 50
        Me.ddMa_Tinh.Text = "Bưu cục"
        Me.ddMa_Tinh.ValueMember = ""
        Me.ddMa_Tinh.Visible = False
        '
        'dgTmp_Giam_Gia
        '
        Me.dgTmp_Giam_Gia.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Giam_Gia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance133.BackColor = System.Drawing.Color.White
        Appearance133.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Giam_Gia.DisplayLayout.Appearance = Appearance133
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance134
        UltraGridColumn74.Header.VisiblePosition = 0
        UltraGridColumn74.Hidden = True
        Appearance135.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance135
        UltraGridColumn75.Header.Caption = "Tỉnh chấp nhận"
        UltraGridColumn75.Header.VisiblePosition = 1
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.MaskInput = "999999"
        Appearance136.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance136
        UltraGridColumn76.Header.Caption = "Tỉnh phát trả"
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.MaskInput = "999999"
        UltraGridColumn77.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance137.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.CellAppearance = Appearance137
        Appearance138.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance138
        UltraGridColumn77.Header.Caption = "Phân loại BP"
        UltraGridColumn77.Header.VisiblePosition = 3
        UltraGridColumn77.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn77.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn77.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn77.RowLayoutColumnInfo.SpanY = 2
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance139
        UltraGridColumn78.Header.Caption = "Hệ số giảm giá"
        UltraGridColumn78.Header.VisiblePosition = 4
        UltraGridColumn78.MaskInput = ""
        UltraGridColumn78.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn78.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn78.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn78.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn79.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn79.EditorControl = Me.dtpNgayDinhDang
        Appearance140.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance140
        UltraGridColumn79.Header.Caption = "Từ ngày"
        UltraGridColumn79.Header.VisiblePosition = 5
        UltraGridColumn79.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn79.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn79.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn79.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn79.UseEditorMaskSettings = True
        UltraGridColumn80.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn80.EditorControl = Me.dtpNgayDinhDang
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.Header.Appearance = Appearance141
        UltraGridColumn80.Header.Caption = "Đến ngày"
        UltraGridColumn80.Header.VisiblePosition = 6
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn80.UseEditorMaskSettings = True
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80})
        UltraGridBand15.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand15.UseRowLayout = True
        Me.dgTmp_Giam_Gia.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.dgTmp_Giam_Gia.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.CardAreaAppearance = Appearance142
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance143.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance143.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance143.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance143.ForeColor = System.Drawing.Color.Black
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance143.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.HeaderAppearance = Appearance143
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance144.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.RowAppearance = Appearance144
        Appearance145.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance145.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance145.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.RowSelectorAppearance = Appearance145
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance146.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance146.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance146.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance146.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Giam_Gia.DisplayLayout.Override.SelectedRowAppearance = Appearance146
        Me.dgTmp_Giam_Gia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Giam_Gia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Giam_Gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Giam_Gia.Location = New System.Drawing.Point(312, 312)
        Me.dgTmp_Giam_Gia.Name = "dgTmp_Giam_Gia"
        Me.dgTmp_Giam_Gia.Size = New System.Drawing.Size(464, 208)
        Me.dgTmp_Giam_Gia.TabIndex = 49
        Me.dgTmp_Giam_Gia.Text = "Giảm giá"
        '
        'dgTmp_Cuoc_TN_TT
        '
        Me.dgTmp_Cuoc_TN_TT.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance147.BackColor = System.Drawing.Color.White
        Appearance147.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Appearance = Appearance147
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.Hidden = True
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.CellAppearance = Appearance148
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.Header.Appearance = Appearance149
        UltraGridColumn82.Header.Caption = "Khu vực"
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn83.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.CellAppearance = Appearance150
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.Header.Appearance = Appearance151
        UltraGridColumn83.Header.Caption = "Phân loại BP"
        UltraGridColumn83.Header.VisiblePosition = 2
        UltraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.CellAppearance = Appearance152
        Appearance153.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.Header.Appearance = Appearance153
        UltraGridColumn84.Header.Caption = "Cách tính"
        UltraGridColumn84.Header.VisiblePosition = 3
        UltraGridColumn84.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        Appearance154.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn85.Header.Appearance = Appearance154
        UltraGridColumn85.Header.Caption = "Khối lượng"
        UltraGridColumn85.Header.VisiblePosition = 4
        UltraGridColumn85.MaskInput = "9999999999"
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn86.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn86.EditorControl = Me.txtDinhDangTien
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance155
        UltraGridColumn86.Header.Caption = "Cước"
        UltraGridColumn86.Header.VisiblePosition = 5
        UltraGridColumn86.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn86.MaskInput = "999999999999"
        UltraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn86.UseEditorMaskSettings = True
        UltraGridColumn87.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn87.EditorControl = Me.dtpNgayDinhDang
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance156
        UltraGridColumn87.Header.Caption = "Từ ngày"
        UltraGridColumn87.Header.VisiblePosition = 6
        UltraGridColumn87.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn87.UseEditorMaskSettings = True
        UltraGridColumn88.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn88.EditorControl = Me.dtpNgayDinhDang
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance157
        UltraGridColumn88.Header.Caption = "Đến ngày"
        UltraGridColumn88.Header.VisiblePosition = 7
        UltraGridColumn88.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn88.UseEditorMaskSettings = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88})
        UltraGridBand16.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand16.UseRowLayout = True
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance158.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.CardAreaAppearance = Appearance158
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance159.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance159.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance159.ForeColor = System.Drawing.Color.Black
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance159.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.HeaderAppearance = Appearance159
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance160.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.RowAppearance = Appearance160
        Appearance161.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance161.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.RowSelectorAppearance = Appearance161
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance162.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance162.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance162.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.Override.SelectedRowAppearance = Appearance162
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_TN_TT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_TN_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Cuoc_TN_TT.Location = New System.Drawing.Point(312, 8)
        Me.dgTmp_Cuoc_TN_TT.Name = "dgTmp_Cuoc_TN_TT"
        Me.dgTmp_Cuoc_TN_TT.Size = New System.Drawing.Size(464, 304)
        Me.dgTmp_Cuoc_TN_TT.TabIndex = 47
        Me.dgTmp_Cuoc_TN_TT.Text = "Cước trong nước Thoả Thuận"
        '
        'dgTmp_Cuoc_TN
        '
        Me.dgTmp_Cuoc_TN.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_TN.DisplayLayout.AddNewBox.Prompt = " "
        Appearance163.BackColor = System.Drawing.Color.White
        Appearance163.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance163.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_TN.DisplayLayout.Appearance = Appearance163
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance164
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn89.Hidden = True
        Appearance165.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.CellAppearance = Appearance165
        Appearance166.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance166
        UltraGridColumn90.Header.Caption = "Khu vực"
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn90.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn91.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.CellAppearance = Appearance167
        Appearance168.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance168
        UltraGridColumn91.Header.Caption = "Phân loại BP"
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn91.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        Appearance169.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.CellAppearance = Appearance169
        Appearance170.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance170
        UltraGridColumn92.Header.Caption = "Cách tính"
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridColumn92.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        Appearance171.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance171
        UltraGridColumn93.Header.Caption = "Khối lượng"
        UltraGridColumn93.Header.VisiblePosition = 4
        UltraGridColumn93.MaskInput = "9999999999"
        UltraGridColumn93.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn94.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn94.EditorControl = Me.txtDinhDangTien
        Appearance172.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.Header.Appearance = Appearance172
        UltraGridColumn94.Header.Caption = "Cước"
        UltraGridColumn94.Header.VisiblePosition = 5
        UltraGridColumn94.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn94.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn94.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn94.MaskInput = "999999999999"
        UltraGridColumn94.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn94.UseEditorMaskSettings = True
        UltraGridColumn95.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn95.EditorControl = Me.dtpNgayDinhDang
        Appearance173.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.Header.Appearance = Appearance173
        UltraGridColumn95.Header.Caption = "Từ ngày"
        UltraGridColumn95.Header.VisiblePosition = 6
        UltraGridColumn95.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn95.UseEditorMaskSettings = True
        UltraGridColumn96.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn96.EditorControl = Me.dtpNgayDinhDang
        Appearance174.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.Header.Appearance = Appearance174
        UltraGridColumn96.Header.Caption = "Đến ngày"
        UltraGridColumn96.Header.VisiblePosition = 7
        UltraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn96.UseEditorMaskSettings = True
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96})
        UltraGridBand17.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand17.UseRowLayout = True
        Me.dgTmp_Cuoc_TN.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Me.dgTmp_Cuoc_TN.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.CardAreaAppearance = Appearance175
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance176.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance176.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance176.ForeColor = System.Drawing.Color.Black
        Appearance176.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance176.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.HeaderAppearance = Appearance176
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance177.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.RowAppearance = Appearance177
        Appearance178.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance178.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.RowSelectorAppearance = Appearance178
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance179.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance179.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance179.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_TN.DisplayLayout.Override.SelectedRowAppearance = Appearance179
        Me.dgTmp_Cuoc_TN.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_TN.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_TN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Cuoc_TN.Location = New System.Drawing.Point(312, 8)
        Me.dgTmp_Cuoc_TN.Name = "dgTmp_Cuoc_TN"
        Me.dgTmp_Cuoc_TN.Size = New System.Drawing.Size(464, 304)
        Me.dgTmp_Cuoc_TN.TabIndex = 46
        Me.dgTmp_Cuoc_TN.Text = "Cước trong nước"
        '
        'dgTmp_Tinh
        '
        Me.dgTmp_Tinh.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgTmp_Tinh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance180.BackColor = System.Drawing.Color.White
        Appearance180.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance180.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Tinh.DisplayLayout.Appearance = Appearance180
        Appearance181.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn97.CellAppearance = Appearance181
        Appearance182.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn97.CellButtonAppearance = Appearance182
        Appearance183.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.Header.Appearance = Appearance183
        UltraGridColumn97.Header.Caption = "Mã tỉnh"
        UltraGridColumn97.Header.VisiblePosition = 0
        UltraGridColumn97.MaskInput = "999999"
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn97.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(74, 0)
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        Appearance184.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.Header.Appearance = Appearance184
        UltraGridColumn98.Header.Caption = "Tên tỉnh"
        UltraGridColumn98.Header.VisiblePosition = 1
        UltraGridColumn98.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn98.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(96, 0)
        UltraGridColumn98.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn98.RowLayoutColumnInfo.SpanY = 2
        Appearance185.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.CellAppearance = Appearance185
        Appearance186.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance186
        UltraGridColumn99.Header.Caption = "Khu vực"
        UltraGridColumn99.Header.VisiblePosition = 2
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(109, 0)
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        Appearance187.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.CellAppearance = Appearance187
        Appearance188.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance188
        UltraGridColumn100.Header.Caption = "Thoả thuận"
        UltraGridColumn100.Header.VisiblePosition = 3
        UltraGridColumn100.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn100.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn100.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn100.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn100.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn101.Header.VisiblePosition = 4
        UltraGridColumn101.MaskInput = "9999999999"
        UltraGridColumn102.Header.Caption = "Tỉnh phát trả"
        UltraGridColumn102.Header.VisiblePosition = 5
        UltraGridColumn102.Hidden = True
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102})
        Appearance189.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridBand18.Header.Appearance = Appearance189
        UltraGridBand18.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        UltraGridBand18.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Vertical
        UltraGridBand18.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand18.UseRowLayout = True
        Me.dgTmp_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Me.dgTmp_Tinh.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Tinh.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Tinh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Tinh.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance190.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Tinh.DisplayLayout.Override.CardAreaAppearance = Appearance190
        Me.dgTmp_Tinh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance191.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance191.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance191.ForeColor = System.Drawing.Color.Black
        Appearance191.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance191.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance191
        Me.dgTmp_Tinh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance192.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Tinh.DisplayLayout.Override.RowAppearance = Appearance192
        Appearance193.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance193.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance193.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Tinh.DisplayLayout.Override.RowSelectorAppearance = Appearance193
        Me.dgTmp_Tinh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Tinh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance194.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance194.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance194.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Tinh.DisplayLayout.Override.SelectedRowAppearance = Appearance194
        Me.dgTmp_Tinh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Tinh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Tinh.ExitEditModeOnLeave = False
        Me.dgTmp_Tinh.Location = New System.Drawing.Point(8, 8)
        Me.dgTmp_Tinh.Name = "dgTmp_Tinh"
        Me.dgTmp_Tinh.Size = New System.Drawing.Size(306, 505)
        Me.dgTmp_Tinh.TabIndex = 45
        Me.dgTmp_Tinh.Text = "Danh mục tỉnh"
        '
        'ddkhu_Vuc_TN
        '
        Appearance195.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddkhu_Vuc_TN.DisplayLayout.Appearance = Appearance195
        UltraGridColumn103.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance196.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance196
        UltraGridColumn103.Header.Caption = "Mã khu vực"
        UltraGridColumn103.Header.VisiblePosition = 0
        Appearance197.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance197
        UltraGridColumn104.Header.Caption = "Tên khu vực"
        UltraGridColumn104.Header.VisiblePosition = 1
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn103, UltraGridColumn104})
        Me.ddkhu_Vuc_TN.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Appearance198.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance198.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance198.ForeColor = System.Drawing.Color.Black
        Appearance198.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddkhu_Vuc_TN.DisplayLayout.Override.HeaderAppearance = Appearance198
        Me.ddkhu_Vuc_TN.DisplayMember = "Ten_Khu_Vuc"
        Me.ddkhu_Vuc_TN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddkhu_Vuc_TN.Location = New System.Drawing.Point(528, 80)
        Me.ddkhu_Vuc_TN.Name = "ddkhu_Vuc_TN"
        Me.ddkhu_Vuc_TN.Size = New System.Drawing.Size(208, 120)
        Me.ddkhu_Vuc_TN.TabIndex = 44
        Me.ddkhu_Vuc_TN.Text = "Khu vực Trong nước"
        Me.ddkhu_Vuc_TN.ValueMember = "Ma_Khu_Vuc"
        Me.ddkhu_Vuc_TN.Visible = False
        '
        'dgGiam_Gia
        '
        Me.dgGiam_Gia.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgGiam_Gia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance199.BackColor = System.Drawing.Color.White
        Appearance199.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance199.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiam_Gia.DisplayLayout.Appearance = Appearance199
        Appearance200.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance200
        UltraGridColumn105.Header.VisiblePosition = 0
        UltraGridColumn105.Hidden = True
        Appearance201.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance201
        UltraGridColumn106.Header.Caption = "Tỉnh chấp nhận"
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.MaskInput = "999999"
        Appearance202.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance202
        UltraGridColumn107.Header.Caption = "Tỉnh phát trả"
        UltraGridColumn107.Header.VisiblePosition = 2
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.MaskInput = "999999"
        UltraGridColumn108.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance203.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.CellAppearance = Appearance203
        Appearance204.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance204
        UltraGridColumn108.Header.Caption = "Phân loại BP"
        UltraGridColumn108.Header.VisiblePosition = 3
        UltraGridColumn108.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn108.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn108.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn108.RowLayoutColumnInfo.SpanY = 2
        Appearance205.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance205
        UltraGridColumn109.Header.Caption = "Hệ số giảm giá"
        UltraGridColumn109.Header.VisiblePosition = 4
        UltraGridColumn109.MaskInput = ""
        UltraGridColumn109.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn109.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn109.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn109.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn110.EditorControl = Me.dtpNgayDinhDang
        Appearance206.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance206
        UltraGridColumn110.Header.Caption = "Từ ngày"
        UltraGridColumn110.Header.VisiblePosition = 5
        UltraGridColumn110.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn110.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn110.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.UseEditorMaskSettings = True
        UltraGridColumn111.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn111.EditorControl = Me.dtpNgayDinhDang
        Appearance207.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance207
        UltraGridColumn111.Header.Caption = "Đến ngày"
        UltraGridColumn111.Header.VisiblePosition = 6
        UltraGridColumn111.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn111.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn111.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn111.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn111.UseEditorMaskSettings = True
        UltraGridBand20.Columns.AddRange(New Object() {UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111})
        UltraGridBand20.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand20.UseRowLayout = True
        Me.dgGiam_Gia.DisplayLayout.BandsSerializer.Add(UltraGridBand20)
        Me.dgGiam_Gia.DisplayLayout.InterBandSpacing = 10
        Me.dgGiam_Gia.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgGiam_Gia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgGiam_Gia.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance208.BackColor = System.Drawing.Color.Transparent
        Me.dgGiam_Gia.DisplayLayout.Override.CardAreaAppearance = Appearance208
        Me.dgGiam_Gia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance209.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance209.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance209.ForeColor = System.Drawing.Color.Black
        Appearance209.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance209.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiam_Gia.DisplayLayout.Override.HeaderAppearance = Appearance209
        Me.dgGiam_Gia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance210.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiam_Gia.DisplayLayout.Override.RowAppearance = Appearance210
        Appearance211.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance211.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance211.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgGiam_Gia.DisplayLayout.Override.RowSelectorAppearance = Appearance211
        Me.dgGiam_Gia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiam_Gia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance212.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance212.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance212.ForeColor = System.Drawing.Color.Black
        Me.dgGiam_Gia.DisplayLayout.Override.SelectedRowAppearance = Appearance212
        Me.dgGiam_Gia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiam_Gia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiam_Gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiam_Gia.Location = New System.Drawing.Point(312, 312)
        Me.dgGiam_Gia.Name = "dgGiam_Gia"
        Me.dgGiam_Gia.Size = New System.Drawing.Size(464, 208)
        Me.dgGiam_Gia.TabIndex = 8
        Me.dgGiam_Gia.Text = "Giảm giá"
        '
        'dgCuoc_TN_TT
        '
        Me.dgCuoc_TN_TT.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_TN_TT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance213.BackColor = System.Drawing.Color.White
        Appearance213.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance213.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_TN_TT.DisplayLayout.Appearance = Appearance213
        UltraGridColumn112.Header.VisiblePosition = 0
        UltraGridColumn112.Hidden = True
        Appearance214.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.CellAppearance = Appearance214
        Appearance215.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance215
        UltraGridColumn113.Header.Caption = "Khu vực"
        UltraGridColumn113.Header.VisiblePosition = 1
        UltraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn114.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance216.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.CellAppearance = Appearance216
        Appearance217.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance217
        UltraGridColumn114.Header.Caption = "Phân loại BP"
        UltraGridColumn114.Header.VisiblePosition = 2
        UltraGridColumn114.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        Appearance218.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.CellAppearance = Appearance218
        Appearance219.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.Header.Appearance = Appearance219
        UltraGridColumn115.Header.Caption = "Cách tính"
        UltraGridColumn115.Header.VisiblePosition = 3
        UltraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        Appearance220.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn116.Header.Appearance = Appearance220
        UltraGridColumn116.Header.Caption = "Khối lượng"
        UltraGridColumn116.Header.VisiblePosition = 4
        UltraGridColumn116.MaskInput = "9999999999"
        UltraGridColumn116.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn117.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn117.EditorControl = Me.txtDinhDangTien
        Appearance221.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn117.Header.Appearance = Appearance221
        UltraGridColumn117.Header.Caption = "Cước"
        UltraGridColumn117.Header.VisiblePosition = 5
        UltraGridColumn117.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn117.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn117.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn117.MaskInput = "999999999999"
        UltraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn117.UseEditorMaskSettings = True
        UltraGridColumn118.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn118.EditorControl = Me.dtpNgayDinhDang
        Appearance222.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn118.Header.Appearance = Appearance222
        UltraGridColumn118.Header.Caption = "Từ ngày"
        UltraGridColumn118.Header.VisiblePosition = 6
        UltraGridColumn118.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn118.UseEditorMaskSettings = True
        UltraGridColumn119.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn119.EditorControl = Me.dtpNgayDinhDang
        Appearance223.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn119.Header.Appearance = Appearance223
        UltraGridColumn119.Header.Caption = "Đến ngày"
        UltraGridColumn119.Header.VisiblePosition = 7
        UltraGridColumn119.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn119.UseEditorMaskSettings = True
        UltraGridBand21.Columns.AddRange(New Object() {UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119})
        UltraGridBand21.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand21.UseRowLayout = True
        Me.dgCuoc_TN_TT.DisplayLayout.BandsSerializer.Add(UltraGridBand21)
        Me.dgCuoc_TN_TT.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_TN_TT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_TN_TT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_TN_TT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance224.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_TN_TT.DisplayLayout.Override.CardAreaAppearance = Appearance224
        Me.dgCuoc_TN_TT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance225.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance225.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance225.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance225.ForeColor = System.Drawing.Color.Black
        Appearance225.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance225.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_TN_TT.DisplayLayout.Override.HeaderAppearance = Appearance225
        Me.dgCuoc_TN_TT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance226.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TN_TT.DisplayLayout.Override.RowAppearance = Appearance226
        Appearance227.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance227.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance227.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_TN_TT.DisplayLayout.Override.RowSelectorAppearance = Appearance227
        Me.dgCuoc_TN_TT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_TN_TT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance228.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance228.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance228.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance228.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_TN_TT.DisplayLayout.Override.SelectedRowAppearance = Appearance228
        Me.dgCuoc_TN_TT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TN_TT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_TN_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_TN_TT.Location = New System.Drawing.Point(312, 8)
        Me.dgCuoc_TN_TT.Name = "dgCuoc_TN_TT"
        Me.dgCuoc_TN_TT.Size = New System.Drawing.Size(464, 304)
        Me.dgCuoc_TN_TT.TabIndex = 6
        Me.dgCuoc_TN_TT.Text = "Cước trong nước Thoả Thuận"
        '
        'dgCuoc_TN
        '
        Me.dgCuoc_TN.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_TN.DisplayLayout.AddNewBox.Prompt = " "
        Appearance229.BackColor = System.Drawing.Color.White
        Appearance229.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance229.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_TN.DisplayLayout.Appearance = Appearance229
        Appearance230.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn120.Header.Appearance = Appearance230
        UltraGridColumn120.Header.VisiblePosition = 0
        UltraGridColumn120.Hidden = True
        Appearance231.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn121.CellAppearance = Appearance231
        Appearance232.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn121.Header.Appearance = Appearance232
        UltraGridColumn121.Header.Caption = "Khu vực"
        UltraGridColumn121.Header.VisiblePosition = 1
        UltraGridColumn121.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn122.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance233.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.CellAppearance = Appearance233
        Appearance234.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.Header.Appearance = Appearance234
        UltraGridColumn122.Header.Caption = "Phân loại BP"
        UltraGridColumn122.Header.VisiblePosition = 2
        UltraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        Appearance235.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.CellAppearance = Appearance235
        Appearance236.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.Header.Appearance = Appearance236
        UltraGridColumn123.Header.Caption = "Cách tính"
        UltraGridColumn123.Header.VisiblePosition = 3
        UltraGridColumn123.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        Appearance237.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn124.Header.Appearance = Appearance237
        UltraGridColumn124.Header.Caption = "Khối lượng"
        UltraGridColumn124.Header.VisiblePosition = 4
        UltraGridColumn124.MaskInput = "9999999999"
        UltraGridColumn124.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn125.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn125.EditorControl = Me.txtDinhDangTien
        Appearance238.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn125.Header.Appearance = Appearance238
        UltraGridColumn125.Header.Caption = "Cước"
        UltraGridColumn125.Header.VisiblePosition = 5
        UltraGridColumn125.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.MaskInput = "999999999999"
        UltraGridColumn125.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn125.UseEditorMaskSettings = True
        UltraGridColumn126.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn126.EditorControl = Me.dtpNgayDinhDang
        Appearance239.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn126.Header.Appearance = Appearance239
        UltraGridColumn126.Header.Caption = "Từ ngày"
        UltraGridColumn126.Header.VisiblePosition = 6
        UltraGridColumn126.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn126.UseEditorMaskSettings = True
        UltraGridColumn127.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn127.EditorControl = Me.dtpNgayDinhDang
        Appearance240.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn127.Header.Appearance = Appearance240
        UltraGridColumn127.Header.Caption = "Đến ngày"
        UltraGridColumn127.Header.VisiblePosition = 7
        UltraGridColumn127.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn127.UseEditorMaskSettings = True
        UltraGridBand22.Columns.AddRange(New Object() {UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127})
        UltraGridBand22.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand22.UseRowLayout = True
        Me.dgCuoc_TN.DisplayLayout.BandsSerializer.Add(UltraGridBand22)
        Me.dgCuoc_TN.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_TN.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_TN.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_TN.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance241.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_TN.DisplayLayout.Override.CardAreaAppearance = Appearance241
        Me.dgCuoc_TN.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance242.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance242.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance242.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance242.ForeColor = System.Drawing.Color.Black
        Appearance242.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance242.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_TN.DisplayLayout.Override.HeaderAppearance = Appearance242
        Me.dgCuoc_TN.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance243.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TN.DisplayLayout.Override.RowAppearance = Appearance243
        Appearance244.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance244.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance244.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_TN.DisplayLayout.Override.RowSelectorAppearance = Appearance244
        Me.dgCuoc_TN.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_TN.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance245.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance245.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance245.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance245.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_TN.DisplayLayout.Override.SelectedRowAppearance = Appearance245
        Me.dgCuoc_TN.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TN.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_TN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_TN.Location = New System.Drawing.Point(312, 7)
        Me.dgCuoc_TN.Name = "dgCuoc_TN"
        Me.dgCuoc_TN.Size = New System.Drawing.Size(464, 304)
        Me.dgCuoc_TN.TabIndex = 5
        Me.dgCuoc_TN.Text = "Cước trong nước"
        '
        'dgTinh
        '
        Me.dgTinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTinh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance246.BackColor = System.Drawing.Color.White
        Appearance246.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance246.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTinh.DisplayLayout.Appearance = Appearance246
        Appearance247.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn128.Header.Appearance = Appearance247
        UltraGridColumn128.Header.Caption = "Mã tỉnh"
        UltraGridColumn128.Header.VisiblePosition = 0
        UltraGridColumn128.MaskInput = "999999"
        UltraGridColumn128.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn128.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn128.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn128.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn128.RowLayoutColumnInfo.SpanY = 2
        Appearance248.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn129.Header.Appearance = Appearance248
        UltraGridColumn129.Header.Caption = "Tên tỉnh"
        UltraGridColumn129.Header.VisiblePosition = 1
        UltraGridColumn129.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn129.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn129.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn129.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn129.RowLayoutColumnInfo.SpanY = 2
        Appearance249.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn130.CellAppearance = Appearance249
        Appearance250.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn130.Header.Appearance = Appearance250
        UltraGridColumn130.Header.Caption = "Khu vực"
        UltraGridColumn130.Header.VisiblePosition = 2
        UltraGridColumn130.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn130.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn130.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(110, 0)
        UltraGridColumn130.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn130.RowLayoutColumnInfo.SpanY = 2
        Appearance251.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn131.CellAppearance = Appearance251
        Appearance252.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn131.Header.Appearance = Appearance252
        UltraGridColumn131.Header.Caption = "Thoả thuận"
        UltraGridColumn131.Header.VisiblePosition = 3
        UltraGridColumn131.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn131.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn131.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn131.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn131.RowLayoutColumnInfo.SpanY = 2
        Appearance253.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn132.Header.Appearance = Appearance253
        UltraGridColumn132.Header.Caption = "Khoảng cách"
        UltraGridColumn132.Header.VisiblePosition = 4
        UltraGridColumn132.MaskInput = "9999999999"
        UltraGridColumn132.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn132.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn132.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn132.RowLayoutColumnInfo.SpanY = 2
        Appearance254.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn133.Header.Appearance = Appearance254
        UltraGridColumn133.Header.Caption = "Tỉnh phát trả"
        UltraGridColumn133.Header.VisiblePosition = 5
        UltraGridColumn133.Hidden = True
        UltraGridBand23.Columns.AddRange(New Object() {UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133})
        UltraGridBand23.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand23.UseRowLayout = True
        Me.dgTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand23)
        Me.dgTinh.DisplayLayout.InterBandSpacing = 10
        Me.dgTinh.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTinh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTinh.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance255.BackColor = System.Drawing.Color.Transparent
        Me.dgTinh.DisplayLayout.Override.CardAreaAppearance = Appearance255
        Me.dgTinh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance256.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance256.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance256.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance256.ForeColor = System.Drawing.Color.Black
        Appearance256.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance256.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTinh.DisplayLayout.Override.HeaderAppearance = Appearance256
        Me.dgTinh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance257.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTinh.DisplayLayout.Override.RowAppearance = Appearance257
        Appearance258.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance258.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance258.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTinh.DisplayLayout.Override.RowSelectorAppearance = Appearance258
        Me.dgTinh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTinh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance259.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance259.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance259.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance259.ForeColor = System.Drawing.Color.Black
        Me.dgTinh.DisplayLayout.Override.SelectedRowAppearance = Appearance259
        Me.dgTinh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTinh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTinh.Location = New System.Drawing.Point(6, 7)
        Me.dgTinh.Name = "dgTinh"
        Me.dgTinh.Size = New System.Drawing.Size(306, 505)
        Me.dgTinh.TabIndex = 4
        Me.dgTinh.Text = "Danh mục tỉnh"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.dgTmp_Cuoc_Phat_Hanh)
        Me.UltraTabPageControl9.Controls.Add(Me.dgCuoc_Phat_Hanh)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(780, 529)
        '
        'dgTmp_Cuoc_Phat_Hanh
        '
        Me.dgTmp_Cuoc_Phat_Hanh.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance260.BackColor = System.Drawing.Color.White
        Appearance260.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance260.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Appearance = Appearance260
        Appearance261.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn134.Header.Appearance = Appearance261
        UltraGridColumn134.Header.VisiblePosition = 0
        UltraGridColumn134.Hidden = True
        UltraGridColumn134.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn134.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn134.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn134.RowLayoutColumnInfo.SpanY = 2
        Appearance262.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn135.Header.Appearance = Appearance262
        UltraGridColumn135.Header.Caption = "Mã tỉnh"
        UltraGridColumn135.Header.VisiblePosition = 1
        UltraGridColumn135.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn135.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn135.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn135.RowLayoutColumnInfo.SpanY = 2
        Appearance263.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn136.Header.Appearance = Appearance263
        UltraGridColumn136.Header.Caption = "Cước NT"
        UltraGridColumn136.Header.VisiblePosition = 2
        UltraGridColumn136.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn136.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn136.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn136.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn137.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        Appearance264.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn137.Header.Appearance = Appearance264
        UltraGridColumn137.Header.Caption = "Cước LT"
        UltraGridColumn137.Header.VisiblePosition = 3
        UltraGridColumn137.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn137.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn137.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn137.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn137.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn137.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn137.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn137.UseEditorMaskSettings = True
        UltraGridColumn138.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        Appearance265.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn138.Header.Appearance = Appearance265
        UltraGridColumn138.Header.Caption = "Cước QT"
        UltraGridColumn138.Header.VisiblePosition = 4
        UltraGridColumn138.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn138.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn138.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn138.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn138.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn138.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn138.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn138.UseEditorMaskSettings = True
        UltraGridColumn139.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn139.EditorControl = Me.dtpNgayDinhDang
        Appearance266.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn139.Header.Appearance = Appearance266
        UltraGridColumn139.Header.Caption = "Từ ngày"
        UltraGridColumn139.Header.VisiblePosition = 5
        UltraGridColumn139.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn139.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn139.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn139.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn139.UseEditorMaskSettings = True
        UltraGridColumn140.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn140.EditorControl = Me.dtpNgayDinhDang
        Appearance267.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn140.Header.Appearance = Appearance267
        UltraGridColumn140.Header.Caption = "Đến ngày"
        UltraGridColumn140.Header.VisiblePosition = 6
        UltraGridColumn140.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn140.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn140.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn140.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn140.UseEditorMaskSettings = True
        UltraGridBand24.Columns.AddRange(New Object() {UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140})
        UltraGridBand24.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand24.UseRowLayout = True
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.BandsSerializer.Add(UltraGridBand24)
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance268.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.CardAreaAppearance = Appearance268
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance269.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance269.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance269.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance269.ForeColor = System.Drawing.Color.Black
        Appearance269.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance269.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.HeaderAppearance = Appearance269
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance270.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.RowAppearance = Appearance270
        Appearance271.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance271.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance271.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.RowSelectorAppearance = Appearance271
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance272.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance272.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance272.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance272.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.Override.SelectedRowAppearance = Appearance272
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Phat_Hanh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Phat_Hanh.Location = New System.Drawing.Point(9, 8)
        Me.dgTmp_Cuoc_Phat_Hanh.Name = "dgTmp_Cuoc_Phat_Hanh"
        Me.dgTmp_Cuoc_Phat_Hanh.Size = New System.Drawing.Size(763, 497)
        Me.dgTmp_Cuoc_Phat_Hanh.TabIndex = 11
        Me.dgTmp_Cuoc_Phat_Hanh.Text = "Danh mục Cước Phát hành"
        '
        'dgCuoc_Phat_Hanh
        '
        Me.dgCuoc_Phat_Hanh.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_Phat_Hanh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance273.BackColor = System.Drawing.Color.White
        Appearance273.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance273.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Appearance = Appearance273
        Appearance274.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn141.Header.Appearance = Appearance274
        UltraGridColumn141.Header.VisiblePosition = 0
        UltraGridColumn141.Hidden = True
        UltraGridColumn141.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn141.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn141.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn141.RowLayoutColumnInfo.SpanY = 2
        Appearance275.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn142.Header.Appearance = Appearance275
        UltraGridColumn142.Header.Caption = "Mã tỉnh"
        UltraGridColumn142.Header.VisiblePosition = 1
        UltraGridColumn142.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn142.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn142.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn142.RowLayoutColumnInfo.SpanY = 2
        Appearance276.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn143.Header.Appearance = Appearance276
        UltraGridColumn143.Header.Caption = "Cước NT"
        UltraGridColumn143.Header.VisiblePosition = 2
        UltraGridColumn143.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn143.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn143.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn143.RowLayoutColumnInfo.SpanY = 2
        Appearance277.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn144.Header.Appearance = Appearance277
        UltraGridColumn144.Header.Caption = "Cước LT"
        UltraGridColumn144.Header.VisiblePosition = 3
        UltraGridColumn144.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn144.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn144.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn144.RowLayoutColumnInfo.SpanY = 2
        Appearance278.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn145.Header.Appearance = Appearance278
        UltraGridColumn145.Header.Caption = "Cước QT"
        UltraGridColumn145.Header.VisiblePosition = 4
        UltraGridColumn145.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn145.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn145.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn145.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn146.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn146.EditorControl = Me.dtpNgayDinhDang
        Appearance279.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn146.Header.Appearance = Appearance279
        UltraGridColumn146.Header.Caption = "Từ ngày"
        UltraGridColumn146.Header.VisiblePosition = 5
        UltraGridColumn146.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn146.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn146.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn146.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn146.UseEditorMaskSettings = True
        UltraGridColumn147.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn147.EditorControl = Me.dtpNgayDinhDang
        Appearance280.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn147.Header.Appearance = Appearance280
        UltraGridColumn147.Header.Caption = "Đến ngày"
        UltraGridColumn147.Header.VisiblePosition = 6
        UltraGridColumn147.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn147.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn147.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn147.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn147.UseEditorMaskSettings = True
        UltraGridBand25.Columns.AddRange(New Object() {UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147})
        UltraGridBand25.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand25.UseRowLayout = True
        Me.dgCuoc_Phat_Hanh.DisplayLayout.BandsSerializer.Add(UltraGridBand25)
        Me.dgCuoc_Phat_Hanh.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance281.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.CardAreaAppearance = Appearance281
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance282.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance282.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance282.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance282.ForeColor = System.Drawing.Color.Black
        Appearance282.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance282.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.HeaderAppearance = Appearance282
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance283.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.RowAppearance = Appearance283
        Appearance284.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance284.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance284.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.RowSelectorAppearance = Appearance284
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance285.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance285.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance285.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance285.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Phat_Hanh.DisplayLayout.Override.SelectedRowAppearance = Appearance285
        Me.dgCuoc_Phat_Hanh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Phat_Hanh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Phat_Hanh.Location = New System.Drawing.Point(8, 8)
        Me.dgCuoc_Phat_Hanh.Name = "dgCuoc_Phat_Hanh"
        Me.dgCuoc_Phat_Hanh.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_Phat_Hanh.TabIndex = 10
        Me.dgCuoc_Phat_Hanh.Text = "Danh mục Cước Phát hành"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgTmp_Cuoc_Phat)
        Me.UltraTabPageControl3.Controls.Add(Me.dgCuoc_Phat)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(780, 529)
        '
        'dgTmp_Cuoc_Phat
        '
        Me.dgTmp_Cuoc_Phat.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_Phat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance286.BackColor = System.Drawing.Color.White
        Appearance286.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance286.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Appearance = Appearance286
        UltraGridColumn148.Header.VisiblePosition = 0
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.MaskInput = ""
        UltraGridColumn149.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance287.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn149.CellAppearance = Appearance287
        Appearance288.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn149.Header.Appearance = Appearance288
        UltraGridColumn149.Header.Caption = "Phân loại BP"
        UltraGridColumn149.Header.VisiblePosition = 1
        UltraGridColumn149.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn149.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn149.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn149.RowLayoutColumnInfo.SpanY = 2
        Appearance289.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn150.CellAppearance = Appearance289
        Appearance290.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn150.Header.Appearance = Appearance290
        UltraGridColumn150.Header.Caption = "Quốc tế"
        UltraGridColumn150.Header.VisiblePosition = 2
        UltraGridColumn150.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn150.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn150.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn150.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn150.UseEditorMaskSettings = True
        Appearance291.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn151.CellAppearance = Appearance291
        Appearance292.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn151.Header.Appearance = Appearance292
        UltraGridColumn151.Header.Caption = "Thoả thuận"
        UltraGridColumn151.Header.VisiblePosition = 3
        UltraGridColumn151.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn151.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn151.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn151.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn151.UseEditorMaskSettings = True
        Appearance293.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn152.CellAppearance = Appearance293
        Appearance294.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn152.Header.Appearance = Appearance294
        UltraGridColumn152.Header.Caption = "Cách tính"
        UltraGridColumn152.Header.VisiblePosition = 4
        UltraGridColumn152.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn152.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn152.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn152.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn152.UseEditorMaskSettings = True
        Appearance295.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn153.Header.Appearance = Appearance295
        UltraGridColumn153.Header.Caption = "Khối lượng"
        UltraGridColumn153.Header.VisiblePosition = 5
        UltraGridColumn153.MaskInput = "9999999999"
        UltraGridColumn153.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn153.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn153.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn153.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn154.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn154.EditorControl = Me.txtDinhDangTien
        Appearance296.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn154.Header.Appearance = Appearance296
        UltraGridColumn154.Header.Caption = "Cước"
        UltraGridColumn154.Header.VisiblePosition = 6
        UltraGridColumn154.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.MaskInput = "999999999999"
        UltraGridColumn154.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn154.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn154.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn154.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn154.UseEditorMaskSettings = True
        UltraGridColumn155.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn155.EditorControl = Me.dtpNgayDinhDang
        Appearance297.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn155.Header.Appearance = Appearance297
        UltraGridColumn155.Header.Caption = "Từ ngày"
        UltraGridColumn155.Header.VisiblePosition = 7
        UltraGridColumn155.MaskInput = ""
        UltraGridColumn155.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn155.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn155.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn155.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn155.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn155.UseEditorMaskSettings = True
        UltraGridColumn156.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn156.EditorControl = Me.dtpNgayDinhDang
        Appearance298.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn156.Header.Appearance = Appearance298
        UltraGridColumn156.Header.Caption = "Đến ngày"
        UltraGridColumn156.Header.VisiblePosition = 8
        UltraGridColumn156.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn156.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn156.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn156.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn156.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn156.UseEditorMaskSettings = True
        UltraGridBand26.Columns.AddRange(New Object() {UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156})
        UltraGridBand26.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand26.UseRowLayout = True
        Me.dgTmp_Cuoc_Phat.DisplayLayout.BandsSerializer.Add(UltraGridBand26)
        Me.dgTmp_Cuoc_Phat.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance299.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.CardAreaAppearance = Appearance299
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance300.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance300.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance300.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance300.ForeColor = System.Drawing.Color.Black
        Appearance300.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance300.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.HeaderAppearance = Appearance300
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance301.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.RowAppearance = Appearance301
        Appearance302.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance302.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance302.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.RowSelectorAppearance = Appearance302
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance303.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance303.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance303.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance303.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Phat.DisplayLayout.Override.SelectedRowAppearance = Appearance303
        Me.dgTmp_Cuoc_Phat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Phat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Phat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTmp_Cuoc_Phat.Location = New System.Drawing.Point(6, 8)
        Me.dgTmp_Cuoc_Phat.Name = "dgTmp_Cuoc_Phat"
        Me.dgTmp_Cuoc_Phat.Size = New System.Drawing.Size(768, 504)
        Me.dgTmp_Cuoc_Phat.TabIndex = 5
        Me.dgTmp_Cuoc_Phat.Text = "Cước phát"
        '
        'dgCuoc_Phat
        '
        Me.dgCuoc_Phat.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_Phat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance304.BackColor = System.Drawing.Color.White
        Appearance304.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance304.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Phat.DisplayLayout.Appearance = Appearance304
        UltraGridColumn157.Header.VisiblePosition = 0
        UltraGridColumn157.Hidden = True
        UltraGridColumn157.MaskInput = ""
        UltraGridColumn158.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance305.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn158.CellAppearance = Appearance305
        Appearance306.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn158.Header.Appearance = Appearance306
        UltraGridColumn158.Header.Caption = "Phân loại BP"
        UltraGridColumn158.Header.VisiblePosition = 1
        UltraGridColumn158.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn158.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn158.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn158.RowLayoutColumnInfo.SpanY = 2
        Appearance307.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn159.CellAppearance = Appearance307
        Appearance308.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn159.Header.Appearance = Appearance308
        UltraGridColumn159.Header.Caption = "Quốc tế"
        UltraGridColumn159.Header.VisiblePosition = 2
        UltraGridColumn159.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn159.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn159.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn159.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn159.UseEditorMaskSettings = True
        Appearance309.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn160.CellAppearance = Appearance309
        Appearance310.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn160.Header.Appearance = Appearance310
        UltraGridColumn160.Header.Caption = "Thoả thuận"
        UltraGridColumn160.Header.VisiblePosition = 3
        UltraGridColumn160.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn160.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn160.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn160.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn160.UseEditorMaskSettings = True
        Appearance311.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn161.CellAppearance = Appearance311
        Appearance312.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn161.Header.Appearance = Appearance312
        UltraGridColumn161.Header.Caption = "Cách tính"
        UltraGridColumn161.Header.VisiblePosition = 4
        UltraGridColumn161.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn161.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn161.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn161.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn161.UseEditorMaskSettings = True
        Appearance313.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn162.Header.Appearance = Appearance313
        UltraGridColumn162.Header.Caption = "Khối lượng"
        UltraGridColumn162.Header.VisiblePosition = 5
        UltraGridColumn162.MaskInput = "9999999999"
        UltraGridColumn162.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn162.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn162.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn162.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn163.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn163.EditorControl = Me.txtDinhDangTien
        Appearance314.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn163.Header.Appearance = Appearance314
        UltraGridColumn163.Header.Caption = "Cước"
        UltraGridColumn163.Header.VisiblePosition = 6
        UltraGridColumn163.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn163.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn163.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn163.MaskInput = "999999999999"
        UltraGridColumn163.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn163.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn163.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn163.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn163.UseEditorMaskSettings = True
        UltraGridColumn164.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn164.EditorControl = Me.dtpNgayDinhDang
        Appearance315.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn164.Header.Appearance = Appearance315
        UltraGridColumn164.Header.Caption = "Từ ngày"
        UltraGridColumn164.Header.VisiblePosition = 7
        UltraGridColumn164.MaskInput = ""
        UltraGridColumn164.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn164.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn164.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn164.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn164.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn164.UseEditorMaskSettings = True
        UltraGridColumn165.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn165.EditorControl = Me.dtpNgayDinhDang
        Appearance316.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn165.Header.Appearance = Appearance316
        UltraGridColumn165.Header.Caption = "Đến ngày"
        UltraGridColumn165.Header.VisiblePosition = 8
        UltraGridColumn165.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn165.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn165.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn165.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn165.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn165.UseEditorMaskSettings = True
        UltraGridBand27.Columns.AddRange(New Object() {UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165})
        UltraGridBand27.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand27.UseRowLayout = True
        Me.dgCuoc_Phat.DisplayLayout.BandsSerializer.Add(UltraGridBand27)
        Me.dgCuoc_Phat.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_Phat.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_Phat.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_Phat.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance317.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Phat.DisplayLayout.Override.CardAreaAppearance = Appearance317
        Me.dgCuoc_Phat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance318.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance318.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance318.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance318.ForeColor = System.Drawing.Color.Black
        Appearance318.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance318.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Phat.DisplayLayout.Override.HeaderAppearance = Appearance318
        Me.dgCuoc_Phat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance319.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Phat.DisplayLayout.Override.RowAppearance = Appearance319
        Appearance320.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance320.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance320.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Phat.DisplayLayout.Override.RowSelectorAppearance = Appearance320
        Me.dgCuoc_Phat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Phat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance321.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance321.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance321.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance321.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Phat.DisplayLayout.Override.SelectedRowAppearance = Appearance321
        Me.dgCuoc_Phat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Phat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Phat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuoc_Phat.Location = New System.Drawing.Point(8, 8)
        Me.dgCuoc_Phat.Name = "dgCuoc_Phat"
        Me.dgCuoc_Phat.Size = New System.Drawing.Size(768, 504)
        Me.dgCuoc_Phat.TabIndex = 4
        Me.dgCuoc_Phat.Text = "Cước phát"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.dgdich_Vu)
        Me.UltraTabPageControl4.Controls.Add(Me.dgTmp_Cuoc_Dv_Cong_Them)
        Me.UltraTabPageControl4.Controls.Add(Me.dgCuoc_Dv_Cong_Them)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(780, 513)
        '
        'dgdich_Vu
        '
        Me.dgdich_Vu.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance322.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.dgdich_Vu.DisplayLayout.Appearance = Appearance322
        Appearance323.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn166.Header.Appearance = Appearance323
        UltraGridColumn166.Header.Caption = "Mã dịch vụ"
        UltraGridColumn166.Header.VisiblePosition = 0
        Appearance324.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn167.Header.Appearance = Appearance324
        UltraGridColumn167.Header.Caption = "Tên dịch vụ"
        UltraGridColumn167.Header.VisiblePosition = 1
        Appearance325.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn168.Header.Appearance = Appearance325
        UltraGridColumn168.Header.Caption = "Phân loại"
        UltraGridColumn168.Header.VisiblePosition = 2
        UltraGridBand28.Columns.AddRange(New Object() {UltraGridColumn166, UltraGridColumn167, UltraGridColumn168})
        Me.dgdich_Vu.DisplayLayout.BandsSerializer.Add(UltraGridBand28)
        Appearance326.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance326.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance326.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance326.ForeColor = System.Drawing.Color.Black
        Appearance326.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgdich_Vu.DisplayLayout.Override.HeaderAppearance = Appearance326
        Me.dgdich_Vu.DisplayMember = "Ten_Dich_Vu"
        Me.dgdich_Vu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdich_Vu.Location = New System.Drawing.Point(286, 203)
        Me.dgdich_Vu.Name = "dgdich_Vu"
        Me.dgdich_Vu.Size = New System.Drawing.Size(170, 101)
        Me.dgdich_Vu.TabIndex = 43
        Me.dgdich_Vu.Text = "Phân loại Bưu phẩm"
        Me.dgdich_Vu.ValueMember = "Ma_Dich_Vu"
        Me.dgdich_Vu.Visible = False
        '
        'dgTmp_Cuoc_Dv_Cong_Them
        '
        Me.dgTmp_Cuoc_Dv_Cong_Them.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.AddNewBox.Prompt = " "
        Appearance327.BackColor = System.Drawing.Color.White
        Appearance327.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance327.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Appearance = Appearance327
        UltraGridColumn169.Header.VisiblePosition = 0
        UltraGridColumn169.Hidden = True
        Appearance328.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn170.Header.Appearance = Appearance328
        UltraGridColumn170.Header.Caption = "Mã dịch vụ"
        UltraGridColumn170.Header.VisiblePosition = 1
        UltraGridColumn170.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn170.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn170.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(158, 0)
        UltraGridColumn170.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn170.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn171.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn171.EditorControl = Me.txtDinhDangTien
        Appearance329.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn171.Header.Appearance = Appearance329
        UltraGridColumn171.Header.Caption = "Cước"
        UltraGridColumn171.Header.VisiblePosition = 2
        UltraGridColumn171.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn171.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn171.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn171.MaskInput = "999999999999"
        UltraGridColumn171.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn171.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn171.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridColumn171.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn171.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn171.UseEditorMaskSettings = True
        UltraGridColumn172.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn172.EditorControl = Me.dtpNgayDinhDang
        Appearance330.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn172.Header.Appearance = Appearance330
        UltraGridColumn172.Header.Caption = "Từ ngày"
        UltraGridColumn172.Header.VisiblePosition = 3
        UltraGridColumn172.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn172.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn172.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn172.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn172.UseEditorMaskSettings = True
        UltraGridColumn173.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn173.EditorControl = Me.dtpNgayDinhDang
        Appearance331.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn173.Header.Appearance = Appearance331
        UltraGridColumn173.Header.Caption = "Đến ngày"
        UltraGridColumn173.Header.VisiblePosition = 4
        UltraGridColumn173.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn173.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn173.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn173.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn173.UseEditorMaskSettings = True
        UltraGridBand29.Columns.AddRange(New Object() {UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173})
        UltraGridBand29.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand29.UseRowLayout = True
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand29)
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance332.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.CardAreaAppearance = Appearance332
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance333.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance333.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance333.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance333.ForeColor = System.Drawing.Color.Black
        Appearance333.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance333.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance333
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance334.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.RowAppearance = Appearance334
        Appearance335.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance335.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance335.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.RowSelectorAppearance = Appearance335
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance336.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance336.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance336.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance336.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.SelectedRowAppearance = Appearance336
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Dv_Cong_Them.Location = New System.Drawing.Point(8, 8)
        Me.dgTmp_Cuoc_Dv_Cong_Them.Name = "dgTmp_Cuoc_Dv_Cong_Them"
        Me.dgTmp_Cuoc_Dv_Cong_Them.Size = New System.Drawing.Size(763, 496)
        Me.dgTmp_Cuoc_Dv_Cong_Them.TabIndex = 40
        Me.dgTmp_Cuoc_Dv_Cong_Them.Text = "Danh mục cước Dịch vụ cộng thêm"
        '
        'dgCuoc_Dv_Cong_Them
        '
        Me.dgCuoc_Dv_Cong_Them.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.AddNewBox.Prompt = " "
        Appearance337.BackColor = System.Drawing.Color.White
        Appearance337.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance337.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Appearance = Appearance337
        UltraGridColumn174.Header.VisiblePosition = 0
        UltraGridColumn174.Hidden = True
        Appearance338.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn175.Header.Appearance = Appearance338
        UltraGridColumn175.Header.Caption = "Mã dịch vụ"
        UltraGridColumn175.Header.VisiblePosition = 1
        UltraGridColumn175.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn175.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn175.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(157, 0)
        UltraGridColumn175.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn175.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn176.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn176.EditorControl = Me.txtDinhDangTien
        Appearance339.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn176.Header.Appearance = Appearance339
        UltraGridColumn176.Header.Caption = "Cước"
        UltraGridColumn176.Header.VisiblePosition = 2
        UltraGridColumn176.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn176.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn176.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn176.MaskInput = "999999999999"
        UltraGridColumn176.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn176.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn176.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn176.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn176.UseEditorMaskSettings = True
        UltraGridColumn177.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn177.EditorControl = Me.dtpNgayDinhDang
        Appearance340.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn177.Header.Appearance = Appearance340
        UltraGridColumn177.Header.Caption = "Từ ngày"
        UltraGridColumn177.Header.VisiblePosition = 3
        UltraGridColumn177.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn177.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn177.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn177.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn177.UseEditorMaskSettings = True
        UltraGridColumn178.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn178.EditorControl = Me.dtpNgayDinhDang
        Appearance341.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn178.Header.Appearance = Appearance341
        UltraGridColumn178.Header.Caption = "Đến ngày"
        UltraGridColumn178.Header.VisiblePosition = 4
        UltraGridColumn178.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn178.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn178.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn178.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn178.UseEditorMaskSettings = True
        UltraGridBand30.Columns.AddRange(New Object() {UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178})
        UltraGridBand30.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand30.UseRowLayout = True
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand30)
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance342.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.CardAreaAppearance = Appearance342
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance343.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance343.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance343.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance343.ForeColor = System.Drawing.Color.Black
        Appearance343.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance343.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance343
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance344.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.RowAppearance = Appearance344
        Appearance345.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance345.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance345.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.RowSelectorAppearance = Appearance345
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance346.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance346.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance346.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance346.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.Override.SelectedRowAppearance = Appearance346
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Dv_Cong_Them.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Dv_Cong_Them.Location = New System.Drawing.Point(8, 7)
        Me.dgCuoc_Dv_Cong_Them.Name = "dgCuoc_Dv_Cong_Them"
        Me.dgCuoc_Dv_Cong_Them.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_Dv_Cong_Them.TabIndex = 5
        Me.dgCuoc_Dv_Cong_Them.Text = "Danh mục cước Dịch vụ cộng thêm"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.dgTmp_Cuoc_Dv_Gia_Tang)
        Me.UltraTabPageControl5.Controls.Add(Me.dgCuoc_Dv_Gia_Tang)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(780, 529)
        '
        'dgTmp_Cuoc_Dv_Gia_Tang
        '
        Me.dgTmp_Cuoc_Dv_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.AddNewBox.Prompt = " "
        Appearance347.BackColor = System.Drawing.Color.White
        Appearance347.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance347.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Appearance = Appearance347
        UltraGridColumn179.Header.VisiblePosition = 0
        UltraGridColumn179.Hidden = True
        Appearance348.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn180.Header.Appearance = Appearance348
        UltraGridColumn180.Header.Caption = "Mã dịch vụ"
        UltraGridColumn180.Header.VisiblePosition = 1
        UltraGridColumn180.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn180.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn180.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(145, 0)
        UltraGridColumn180.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn180.RowLayoutColumnInfo.SpanY = 2
        Appearance349.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn181.CellAppearance = Appearance349
        Appearance350.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn181.Header.Appearance = Appearance350
        UltraGridColumn181.Header.Caption = "Cách tính"
        UltraGridColumn181.Header.VisiblePosition = 2
        UltraGridColumn181.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn181.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn181.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn181.RowLayoutColumnInfo.SpanY = 2
        Appearance351.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn182.Header.Appearance = Appearance351
        UltraGridColumn182.Header.Caption = "Khối lượng"
        UltraGridColumn182.Header.VisiblePosition = 4
        UltraGridColumn182.MaskInput = "9999999999"
        UltraGridColumn182.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn182.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn182.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn182.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn183.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn183.EditorControl = Me.txtDinhDangTien
        Appearance352.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn183.Header.Appearance = Appearance352
        UltraGridColumn183.Header.Caption = "Cước"
        UltraGridColumn183.Header.VisiblePosition = 3
        UltraGridColumn183.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn183.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn183.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn183.MaskInput = "999999999999"
        UltraGridColumn183.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn183.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn183.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn183.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn183.UseEditorMaskSettings = True
        UltraGridColumn184.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn184.EditorControl = Me.dtpNgayDinhDang
        Appearance353.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn184.Header.Appearance = Appearance353
        UltraGridColumn184.Header.Caption = "Từ ngày"
        UltraGridColumn184.Header.VisiblePosition = 5
        UltraGridColumn184.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn184.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn184.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn184.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn184.UseEditorMaskSettings = True
        UltraGridColumn185.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn185.EditorControl = Me.dtpNgayDinhDang
        Appearance354.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn185.Header.Appearance = Appearance354
        UltraGridColumn185.Header.Caption = "Đến ngày"
        UltraGridColumn185.Header.VisiblePosition = 6
        UltraGridColumn185.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn185.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn185.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn185.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn185.UseEditorMaskSettings = True
        UltraGridBand31.Columns.AddRange(New Object() {UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185})
        UltraGridBand31.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand31.UseRowLayout = True
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand31)
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance355.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.CardAreaAppearance = Appearance355
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance356.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance356.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance356.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance356.ForeColor = System.Drawing.Color.Black
        Appearance356.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance356.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance356
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance357.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.RowAppearance = Appearance357
        Appearance358.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance358.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance358.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSelectorAppearance = Appearance358
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance359.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance359.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance359.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance359.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.SelectedRowAppearance = Appearance359
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Dv_Gia_Tang.Location = New System.Drawing.Point(9, 8)
        Me.dgTmp_Cuoc_Dv_Gia_Tang.Name = "dgTmp_Cuoc_Dv_Gia_Tang"
        Me.dgTmp_Cuoc_Dv_Gia_Tang.Size = New System.Drawing.Size(763, 497)
        Me.dgTmp_Cuoc_Dv_Gia_Tang.TabIndex = 7
        Me.dgTmp_Cuoc_Dv_Gia_Tang.Text = "Danh mục cước Dịch vụ Gia tăng"
        '
        'dgCuoc_Dv_Gia_Tang
        '
        Me.dgCuoc_Dv_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.AddNewBox.Prompt = " "
        Appearance360.BackColor = System.Drawing.Color.White
        Appearance360.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance360.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Appearance = Appearance360
        UltraGridColumn186.Header.VisiblePosition = 0
        UltraGridColumn186.Hidden = True
        Appearance361.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn187.Header.Appearance = Appearance361
        UltraGridColumn187.Header.Caption = "Mã dịch vụ"
        UltraGridColumn187.Header.VisiblePosition = 1
        UltraGridColumn187.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn187.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn187.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn187.RowLayoutColumnInfo.SpanY = 2
        Appearance362.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn188.CellAppearance = Appearance362
        Appearance363.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn188.Header.Appearance = Appearance363
        UltraGridColumn188.Header.Caption = "Cách tính"
        UltraGridColumn188.Header.VisiblePosition = 2
        UltraGridColumn188.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn188.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn188.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn188.RowLayoutColumnInfo.SpanY = 2
        Appearance364.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn189.Header.Appearance = Appearance364
        UltraGridColumn189.Header.Caption = "Khối lượng"
        UltraGridColumn189.Header.VisiblePosition = 4
        UltraGridColumn189.MaskInput = "9999999999"
        UltraGridColumn189.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn189.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn189.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn189.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn190.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn190.EditorControl = Me.txtDinhDangTien
        Appearance365.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn190.Header.Appearance = Appearance365
        UltraGridColumn190.Header.Caption = "Cước"
        UltraGridColumn190.Header.VisiblePosition = 3
        UltraGridColumn190.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn190.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn190.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn190.MaskInput = "999999999999"
        UltraGridColumn190.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn190.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn190.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn190.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn190.UseEditorMaskSettings = True
        UltraGridColumn191.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn191.EditorControl = Me.dtpNgayDinhDang
        Appearance366.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn191.Header.Appearance = Appearance366
        UltraGridColumn191.Header.Caption = "Từ ngày"
        UltraGridColumn191.Header.VisiblePosition = 5
        UltraGridColumn191.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn191.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn191.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn191.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn191.UseEditorMaskSettings = True
        UltraGridColumn192.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn192.EditorControl = Me.dtpNgayDinhDang
        Appearance367.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn192.Header.Appearance = Appearance367
        UltraGridColumn192.Header.Caption = "Đến ngày"
        UltraGridColumn192.Header.VisiblePosition = 6
        UltraGridColumn192.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn192.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn192.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn192.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn192.UseEditorMaskSettings = True
        UltraGridBand32.Columns.AddRange(New Object() {UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192})
        UltraGridBand32.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand32.UseRowLayout = True
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand32)
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance368.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.CardAreaAppearance = Appearance368
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance369.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance369.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance369.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance369.ForeColor = System.Drawing.Color.Black
        Appearance369.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance369.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance369
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance370.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.RowAppearance = Appearance370
        Appearance371.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance371.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance371.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSelectorAppearance = Appearance371
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance372.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance372.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance372.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance372.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.SelectedRowAppearance = Appearance372
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_Dv_Gia_Tang.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_Dv_Gia_Tang.Location = New System.Drawing.Point(8, 7)
        Me.dgCuoc_Dv_Gia_Tang.Name = "dgCuoc_Dv_Gia_Tang"
        Me.dgCuoc_Dv_Gia_Tang.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_Dv_Gia_Tang.TabIndex = 6
        Me.dgCuoc_Dv_Gia_Tang.Text = "Danh mục cước Dịch vụ Gia tăng"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.dgTmp_Cuoc_Dv_Khai_Gia)
        Me.UltraTabPageControl6.Controls.Add(Me.dgCuoc_DV_Khai_Gia)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(780, 529)
        '
        'dgTmp_Cuoc_Dv_Khai_Gia
        '
        Me.dgTmp_Cuoc_Dv_Khai_Gia.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance373.BackColor = System.Drawing.Color.White
        Appearance373.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance373.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Appearance = Appearance373
        UltraGridColumn193.Header.VisiblePosition = 0
        UltraGridColumn193.Hidden = True
        Appearance374.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn194.Header.Appearance = Appearance374
        UltraGridColumn194.Header.Caption = "Mã dịch vụ"
        UltraGridColumn194.Header.VisiblePosition = 1
        UltraGridColumn194.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn194.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn194.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(143, 0)
        UltraGridColumn194.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn194.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn195.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn195.EditorControl = Me.txtDinhDangTien
        Appearance375.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn195.Header.Appearance = Appearance375
        UltraGridColumn195.Header.Caption = "Cước"
        UltraGridColumn195.Header.VisiblePosition = 2
        UltraGridColumn195.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn195.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn195.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn195.MaskInput = "999999999999"
        UltraGridColumn195.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn195.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn195.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn195.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn195.UseEditorMaskSettings = True
        UltraGridColumn196.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn196.EditorControl = Me.txtDinhDangTien
        Appearance376.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn196.Header.Appearance = Appearance376
        UltraGridColumn196.Header.Caption = "Cước tối thiểu"
        UltraGridColumn196.Header.VisiblePosition = 3
        UltraGridColumn196.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn196.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn196.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn196.MaskInput = "999999999999"
        UltraGridColumn196.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn196.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn196.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn196.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn196.UseEditorMaskSettings = True
        UltraGridColumn197.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn197.EditorControl = Me.dtpNgayDinhDang
        Appearance377.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn197.Header.Appearance = Appearance377
        UltraGridColumn197.Header.Caption = "Từ ngày"
        UltraGridColumn197.Header.VisiblePosition = 4
        UltraGridColumn197.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn197.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn197.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn197.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn197.UseEditorMaskSettings = True
        UltraGridColumn198.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn198.EditorControl = Me.dtpNgayDinhDang
        Appearance378.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn198.Header.Appearance = Appearance378
        UltraGridColumn198.Header.Caption = "Đến ngày"
        UltraGridColumn198.Header.VisiblePosition = 5
        UltraGridColumn198.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn198.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn198.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn198.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn198.UseEditorMaskSettings = True
        UltraGridBand33.Columns.AddRange(New Object() {UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198})
        UltraGridBand33.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand33.UseRowLayout = True
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.BandsSerializer.Add(UltraGridBand33)
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance379.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.CardAreaAppearance = Appearance379
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance380.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance380.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance380.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance380.ForeColor = System.Drawing.Color.Black
        Appearance380.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance380.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.HeaderAppearance = Appearance380
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance381.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.RowAppearance = Appearance381
        Appearance382.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance382.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance382.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.RowSelectorAppearance = Appearance382
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance383.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance383.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance383.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance383.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.SelectedRowAppearance = Appearance383
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_Dv_Khai_Gia.Location = New System.Drawing.Point(9, 8)
        Me.dgTmp_Cuoc_Dv_Khai_Gia.Name = "dgTmp_Cuoc_Dv_Khai_Gia"
        Me.dgTmp_Cuoc_Dv_Khai_Gia.Size = New System.Drawing.Size(763, 497)
        Me.dgTmp_Cuoc_Dv_Khai_Gia.TabIndex = 8
        Me.dgTmp_Cuoc_Dv_Khai_Gia.Text = "Danh mục cước Dịch vụ Khai giá"
        '
        'dgCuoc_DV_Khai_Gia
        '
        Me.dgCuoc_DV_Khai_Gia.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance384.BackColor = System.Drawing.Color.White
        Appearance384.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance384.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Appearance = Appearance384
        UltraGridColumn199.Header.VisiblePosition = 0
        UltraGridColumn199.Hidden = True
        Appearance385.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn200.Header.Appearance = Appearance385
        UltraGridColumn200.Header.Caption = "Mã dịch vụ"
        UltraGridColumn200.Header.VisiblePosition = 1
        UltraGridColumn200.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn200.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn200.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(142, 0)
        UltraGridColumn200.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn200.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn201.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn201.EditorControl = Me.txtDinhDangTien
        Appearance386.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn201.Header.Appearance = Appearance386
        UltraGridColumn201.Header.Caption = "Cước"
        UltraGridColumn201.Header.VisiblePosition = 2
        UltraGridColumn201.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskInput = "999999999999"
        UltraGridColumn201.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn201.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn201.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn201.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn201.UseEditorMaskSettings = True
        UltraGridColumn202.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn202.EditorControl = Me.txtDinhDangTien
        Appearance387.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn202.Header.Appearance = Appearance387
        UltraGridColumn202.Header.Caption = "Cước tối thiểu"
        UltraGridColumn202.Header.VisiblePosition = 3
        UltraGridColumn202.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn202.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn202.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn202.MaskInput = "999999999999"
        UltraGridColumn202.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn202.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn202.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn202.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn202.UseEditorMaskSettings = True
        UltraGridColumn203.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn203.EditorControl = Me.dtpNgayDinhDang
        Appearance388.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn203.Header.Appearance = Appearance388
        UltraGridColumn203.Header.Caption = "Từ ngày"
        UltraGridColumn203.Header.VisiblePosition = 4
        UltraGridColumn203.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn203.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn203.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn203.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn203.UseEditorMaskSettings = True
        UltraGridColumn204.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn204.EditorControl = Me.dtpNgayDinhDang
        Appearance389.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn204.Header.Appearance = Appearance389
        UltraGridColumn204.Header.Caption = "Đến ngày"
        UltraGridColumn204.Header.VisiblePosition = 5
        UltraGridColumn204.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn204.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn204.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn204.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn204.UseEditorMaskSettings = True
        UltraGridBand34.Columns.AddRange(New Object() {UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204})
        UltraGridBand34.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand34.UseRowLayout = True
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.BandsSerializer.Add(UltraGridBand34)
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance390.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.CardAreaAppearance = Appearance390
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance391.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance391.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance391.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance391.ForeColor = System.Drawing.Color.Black
        Appearance391.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance391.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.HeaderAppearance = Appearance391
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance392.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.RowAppearance = Appearance392
        Appearance393.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance393.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance393.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.RowSelectorAppearance = Appearance393
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance394.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance394.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance394.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance394.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.Override.SelectedRowAppearance = Appearance394
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_DV_Khai_Gia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_DV_Khai_Gia.Location = New System.Drawing.Point(8, 7)
        Me.dgCuoc_DV_Khai_Gia.Name = "dgCuoc_DV_Khai_Gia"
        Me.dgCuoc_DV_Khai_Gia.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_DV_Khai_Gia.TabIndex = 7
        Me.dgCuoc_DV_Khai_Gia.Text = "Danh mục cước Dịch vụ Khai giá"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.dgTmp_Cuoc_PPXD_VAT)
        Me.UltraTabPageControl7.Controls.Add(Me.dgCuoc_PPXD_VAT)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(780, 513)
        '
        'dgTmp_Cuoc_PPXD_VAT
        '
        Me.dgTmp_Cuoc_PPXD_VAT.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance395.BackColor = System.Drawing.Color.White
        Appearance395.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance395.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Appearance = Appearance395
        UltraGridColumn205.Header.VisiblePosition = 0
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn206.EditorControl = Me.dtpNgayDinhDang
        Appearance396.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn206.Header.Appearance = Appearance396
        UltraGridColumn206.Header.Caption = "Từ ngày"
        UltraGridColumn206.Header.VisiblePosition = 3
        UltraGridColumn206.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn206.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn206.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn206.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn206.UseEditorMaskSettings = True
        UltraGridColumn207.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn207.EditorControl = Me.dtpNgayDinhDang
        Appearance397.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn207.Header.Appearance = Appearance397
        UltraGridColumn207.Header.Caption = "Đến ngày"
        UltraGridColumn207.Header.VisiblePosition = 5
        UltraGridColumn207.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn207.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn207.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn207.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn207.UseEditorMaskSettings = True
        Appearance398.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn208.Header.Appearance = Appearance398
        UltraGridColumn208.Header.Caption = "Cước VAT"
        UltraGridColumn208.Header.VisiblePosition = 1
        UltraGridColumn208.MaskInput = ""
        UltraGridColumn208.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn208.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn208.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn208.RowLayoutColumnInfo.SpanY = 2
        Appearance399.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn209.Header.Appearance = Appearance399
        UltraGridColumn209.Header.Caption = "PPXD Quốc tế"
        UltraGridColumn209.Header.VisiblePosition = 2
        UltraGridColumn209.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn209.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn209.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn209.RowLayoutColumnInfo.SpanY = 2
        Appearance400.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn210.Header.Appearance = Appearance400
        UltraGridColumn210.Header.Caption = "PPXD Trong nước Liên tỉnh"
        UltraGridColumn210.Header.VisiblePosition = 4
        UltraGridColumn210.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn210.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn210.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn210.RowLayoutColumnInfo.SpanY = 2
        Appearance401.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn211.Header.Appearance = Appearance401
        UltraGridColumn211.Header.Caption = "PPXD Trong nước Nội tỉnh"
        UltraGridColumn211.Header.VisiblePosition = 6
        UltraGridColumn211.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn211.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn211.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn211.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand35.Columns.AddRange(New Object() {UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211})
        UltraGridBand35.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand35.UseRowLayout = True
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.BandsSerializer.Add(UltraGridBand35)
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.InterBandSpacing = 10
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance402.BackColor = System.Drawing.Color.Transparent
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.CardAreaAppearance = Appearance402
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance403.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance403.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance403.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance403.ForeColor = System.Drawing.Color.Black
        Appearance403.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance403.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.HeaderAppearance = Appearance403
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance404.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.RowAppearance = Appearance404
        Appearance405.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance405.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance405.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.RowSelectorAppearance = Appearance405
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance406.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance406.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance406.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance406.ForeColor = System.Drawing.Color.Black
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.Override.SelectedRowAppearance = Appearance406
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTmp_Cuoc_PPXD_VAT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTmp_Cuoc_PPXD_VAT.Location = New System.Drawing.Point(9, 8)
        Me.dgTmp_Cuoc_PPXD_VAT.Name = "dgTmp_Cuoc_PPXD_VAT"
        Me.dgTmp_Cuoc_PPXD_VAT.Size = New System.Drawing.Size(763, 497)
        Me.dgTmp_Cuoc_PPXD_VAT.TabIndex = 9
        Me.dgTmp_Cuoc_PPXD_VAT.Text = "Danh mục cước Phụ phí xăng dầu VAT"
        '
        'dgCuoc_PPXD_VAT
        '
        Me.dgCuoc_PPXD_VAT.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgCuoc_PPXD_VAT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance407.BackColor = System.Drawing.Color.White
        Appearance407.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance407.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Appearance = Appearance407
        UltraGridColumn212.Header.VisiblePosition = 0
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn213.EditorControl = Me.dtpNgayDinhDang
        Appearance408.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn213.Header.Appearance = Appearance408
        UltraGridColumn213.Header.Caption = "Từ ngày"
        UltraGridColumn213.Header.VisiblePosition = 3
        UltraGridColumn213.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn213.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn213.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn213.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn213.UseEditorMaskSettings = True
        UltraGridColumn214.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn214.EditorControl = Me.dtpNgayDinhDang
        Appearance409.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn214.Header.Appearance = Appearance409
        UltraGridColumn214.Header.Caption = "Đến ngày"
        UltraGridColumn214.Header.VisiblePosition = 5
        UltraGridColumn214.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn214.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn214.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn214.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn214.UseEditorMaskSettings = True
        Appearance410.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn215.Header.Appearance = Appearance410
        UltraGridColumn215.Header.Caption = "Cước VAT"
        UltraGridColumn215.Header.VisiblePosition = 1
        UltraGridColumn215.MaskInput = ""
        UltraGridColumn215.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn215.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn215.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn215.RowLayoutColumnInfo.SpanY = 2
        Appearance411.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn216.Header.Appearance = Appearance411
        UltraGridColumn216.Header.Caption = "PPXD Quốc tế"
        UltraGridColumn216.Header.VisiblePosition = 2
        UltraGridColumn216.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn216.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn216.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn216.RowLayoutColumnInfo.SpanY = 2
        Appearance412.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn217.Header.Appearance = Appearance412
        UltraGridColumn217.Header.Caption = "PPXD Trong nước Liên tỉnh"
        UltraGridColumn217.Header.VisiblePosition = 4
        UltraGridColumn217.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn217.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn217.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn217.RowLayoutColumnInfo.SpanY = 2
        Appearance413.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn218.Header.Appearance = Appearance413
        UltraGridColumn218.Header.Caption = "PPXD Trong nước Nội tỉnh"
        UltraGridColumn218.Header.VisiblePosition = 6
        UltraGridColumn218.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn218.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn218.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn218.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand36.Columns.AddRange(New Object() {UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218})
        UltraGridBand36.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand36.UseRowLayout = True
        Me.dgCuoc_PPXD_VAT.DisplayLayout.BandsSerializer.Add(UltraGridBand36)
        Me.dgCuoc_PPXD_VAT.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance414.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.CardAreaAppearance = Appearance414
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance415.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance415.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance415.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance415.ForeColor = System.Drawing.Color.Black
        Appearance415.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance415.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.HeaderAppearance = Appearance415
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance416.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.RowAppearance = Appearance416
        Appearance417.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance417.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance417.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.RowSelectorAppearance = Appearance417
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance418.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance418.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance418.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance418.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_PPXD_VAT.DisplayLayout.Override.SelectedRowAppearance = Appearance418
        Me.dgCuoc_PPXD_VAT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_PPXD_VAT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_PPXD_VAT.Location = New System.Drawing.Point(8, 8)
        Me.dgCuoc_PPXD_VAT.Name = "dgCuoc_PPXD_VAT"
        Me.dgCuoc_PPXD_VAT.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_PPXD_VAT.TabIndex = 8
        Me.dgCuoc_PPXD_VAT.Text = "Danh mục cước Phụ phí xăng dầu VAT"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.dgCuoc_TCT)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(780, 529)
        '
        'dgCuoc_TCT
        '
        Me.dgCuoc_TCT.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgCuoc_TCT.DisplayLayout.AddNewBox.Prompt = " "
        Appearance419.BackColor = System.Drawing.Color.White
        Appearance419.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance419.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgCuoc_TCT.DisplayLayout.Appearance = Appearance419
        UltraGridColumn219.Header.VisiblePosition = 0
        UltraGridColumn219.Hidden = True
        UltraGridColumn219.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn219.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn219.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn219.RowLayoutColumnInfo.SpanY = 2
        Appearance420.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn220.Header.Appearance = Appearance420
        UltraGridColumn220.Header.Caption = "Cách tính"
        UltraGridColumn220.Header.VisiblePosition = 1
        UltraGridColumn220.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn220.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn220.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn220.RowLayoutColumnInfo.SpanY = 2
        Appearance421.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn221.Header.Appearance = Appearance421
        UltraGridColumn221.Header.Caption = "Nấc gửi"
        UltraGridColumn221.Header.VisiblePosition = 2
        UltraGridColumn221.MaskInput = "999999999999"
        UltraGridColumn221.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn221.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn221.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn221.RowLayoutColumnInfo.SpanY = 2
        Appearance422.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn222.Header.Appearance = Appearance422
        UltraGridColumn222.Header.Caption = "Phần trăm cước"
        UltraGridColumn222.Header.VisiblePosition = 4
        UltraGridColumn222.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn222.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn222.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn222.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn223.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn223.EditorControl = Me.dtpNgayDinhDang
        Appearance423.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn223.Header.Appearance = Appearance423
        UltraGridColumn223.Header.Caption = "Từ ngày"
        UltraGridColumn223.Header.VisiblePosition = 5
        UltraGridColumn223.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn223.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn223.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn223.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn223.UseEditorMaskSettings = True
        UltraGridColumn224.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn224.EditorControl = Me.dtpNgayDinhDang
        Appearance424.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn224.Header.Appearance = Appearance424
        UltraGridColumn224.Header.Caption = "Đến ngày"
        UltraGridColumn224.Header.VisiblePosition = 7
        UltraGridColumn224.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn224.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn224.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn224.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn224.UseEditorMaskSettings = True
        UltraGridColumn225.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn225.EditorControl = Me.txtDinhDangTien
        Appearance425.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn225.Header.Appearance = Appearance425
        UltraGridColumn225.Header.Caption = "Cước tối thiểu"
        UltraGridColumn225.Header.VisiblePosition = 6
        UltraGridColumn225.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn225.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn225.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn225.MaskInput = "999999999999"
        UltraGridColumn225.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn225.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn225.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn225.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn225.UseEditorMaskSettings = True
        UltraGridColumn226.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn226.EditorControl = Me.txtDinhDangTien
        Appearance426.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn226.Header.Appearance = Appearance426
        UltraGridColumn226.Header.Caption = "Cước"
        UltraGridColumn226.Header.VisiblePosition = 3
        UltraGridColumn226.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn226.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn226.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn226.MaskInput = "999999999999"
        UltraGridColumn226.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn226.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn226.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn226.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn226.UseEditorMaskSettings = True
        UltraGridBand37.Columns.AddRange(New Object() {UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226})
        UltraGridBand37.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand37.UseRowLayout = True
        Me.dgCuoc_TCT.DisplayLayout.BandsSerializer.Add(UltraGridBand37)
        Me.dgCuoc_TCT.DisplayLayout.InterBandSpacing = 10
        Me.dgCuoc_TCT.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgCuoc_TCT.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgCuoc_TCT.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance427.BackColor = System.Drawing.Color.Transparent
        Me.dgCuoc_TCT.DisplayLayout.Override.CardAreaAppearance = Appearance427
        Me.dgCuoc_TCT.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance428.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance428.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance428.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance428.ForeColor = System.Drawing.Color.Black
        Appearance428.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance428.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgCuoc_TCT.DisplayLayout.Override.HeaderAppearance = Appearance428
        Me.dgCuoc_TCT.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance429.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TCT.DisplayLayout.Override.RowAppearance = Appearance429
        Appearance430.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance430.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance430.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgCuoc_TCT.DisplayLayout.Override.RowSelectorAppearance = Appearance430
        Me.dgCuoc_TCT.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgCuoc_TCT.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance431.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance431.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance431.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance431.ForeColor = System.Drawing.Color.Black
        Me.dgCuoc_TCT.DisplayLayout.Override.SelectedRowAppearance = Appearance431
        Me.dgCuoc_TCT.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgCuoc_TCT.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgCuoc_TCT.Location = New System.Drawing.Point(8, 8)
        Me.dgCuoc_TCT.Name = "dgCuoc_TCT"
        Me.dgCuoc_TCT.Size = New System.Drawing.Size(763, 497)
        Me.dgCuoc_TCT.TabIndex = 9
        Me.dgCuoc_TCT.Text = "Danh mục Cước dịch vụ COD"
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm kiếm"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(780, 513)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Location = New System.Drawing.Point(-8, 0)
        Me.UltraTabControl1.MultiRowSelectionStyle = Infragistics.Win.UltraWinTabs.MultiRowSelectionStyle.SwapRow
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.ScrollArrowStyle = Infragistics.Win.UltraWinTabs.ScrollArrowStyle.WindowsXP
        Me.UltraTabControl1.ScrollButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2003ToolbarButton
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(784, 536)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Quốc tế"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Trong nước"
        UltraTab3.TabPage = Me.UltraTabPageControl9
        UltraTab3.Text = "HH Phát hành"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "HH phát trả"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "Phụ phí xăng dầu VAT"
        UltraTab6.TabPage = Me.UltraTabPageControl4
        UltraTab6.Text = "Dịch vụ Cộng thêm"
        UltraTab6.Visible = False
        UltraTab7.TabPage = Me.UltraTabPageControl5
        UltraTab7.Text = "Dịch vụ Gia tăng"
        UltraTab7.Visible = False
        UltraTab8.TabPage = Me.UltraTabPageControl6
        UltraTab8.Text = "Dịch vụ Khai giá"
        UltraTab8.Visible = False
        UltraTab9.TabPage = Me.UltraTabPageControl8
        UltraTab9.Text = "Dịch vụ COD"
        UltraTab9.Visible = False
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'BtnLay_Danh_Muc
        '
        Appearance432.Image = CType(resources.GetObject("Appearance432.Image"), Object)
        Me.BtnLay_Danh_Muc.Appearance = Appearance432
        Me.BtnLay_Danh_Muc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLay_Danh_Muc.Location = New System.Drawing.Point(504, 504)
        Me.BtnLay_Danh_Muc.Name = "BtnLay_Danh_Muc"
        Me.BtnLay_Danh_Muc.Size = New System.Drawing.Size(208, 24)
        Me.BtnLay_Danh_Muc.TabIndex = 4
        Me.BtnLay_Danh_Muc.Text = "Lấy danh mục từ máy chủ"
        Me.BtnLay_Danh_Muc.Visible = False
        '
        'Gb_Cau_Hinh
        '
        Me.Gb_Cau_Hinh.Controls.Add(Me.Rd_May_Chu)
        Me.Gb_Cau_Hinh.Controls.Add(Me.Rd_Pc)
        Me.Gb_Cau_Hinh.Controls.Add(Me.dtpNgayDinhDang)
        Me.Gb_Cau_Hinh.Location = New System.Drawing.Point(144, 504)
        Me.Gb_Cau_Hinh.Name = "Gb_Cau_Hinh"
        Me.Gb_Cau_Hinh.Size = New System.Drawing.Size(352, 24)
        Me.Gb_Cau_Hinh.TabIndex = 5
        Me.Gb_Cau_Hinh.TabStop = False
        Me.Gb_Cau_Hinh.Text = "Lựa chọn"
        Me.Gb_Cau_Hinh.Visible = False
        '
        'Rd_May_Chu
        '
        Me.Rd_May_Chu.Location = New System.Drawing.Point(192, 12)
        Me.Rd_May_Chu.Name = "Rd_May_Chu"
        Me.Rd_May_Chu.Size = New System.Drawing.Size(144, 16)
        Me.Rd_May_Chu.TabIndex = 1
        Me.Rd_May_Chu.Text = "Danh mục trên máy chủ"
        '
        'Rd_Pc
        '
        Me.Rd_Pc.Location = New System.Drawing.Point(32, 16)
        Me.Rd_Pc.Name = "Rd_Pc"
        Me.Rd_Pc.Size = New System.Drawing.Size(112, 16)
        Me.Rd_Pc.TabIndex = 0
        Me.Rd_Pc.Text = "Danh mục tại PC"
        '
        'btntest
        '
        Me.btntest.Location = New System.Drawing.Point(720, 504)
        Me.btntest.Name = "btntest"
        Me.btntest.Size = New System.Drawing.Size(40, 24)
        Me.btntest.TabIndex = 6
        Me.btntest.Text = "test"
        Me.btntest.Visible = False
        '
        'FrmCacBangDanhMucCuoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(774, 531)
        Me.Controls.Add(Me.txtDinhDangTien)
        Me.Controls.Add(Me.btntest)
        Me.Controls.Add(Me.Gb_Cau_Hinh)
        Me.Controls.Add(Me.BtnLay_Danh_Muc)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCacBangDanhMucCuoc"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh mục các bảng cước"
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDinhDangTien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ddCach_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDanh_Muc_BC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Khuyen_Mai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Cuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Cuoc_QT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgKhuyen_Mai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_Vung_Xa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_QT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddKhuVucQT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ddMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Giam_Gia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Cuoc_TN_TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Cuoc_TN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddkhu_Vuc_TN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGiam_Gia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_TN_TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_TN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.dgTmp_Cuoc_Phat_Hanh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_Phat_Hanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgTmp_Cuoc_Phat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_Phat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.dgdich_Vu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTmp_Cuoc_Dv_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_Dv_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.dgTmp_Cuoc_Dv_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_Dv_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.dgTmp_Cuoc_Dv_Khai_Gia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_DV_Khai_Gia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.dgTmp_Cuoc_PPXD_VAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuoc_PPXD_VAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.dgCuoc_TCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Gb_Cau_Hinh.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến cục bộ trong bảng danh mục cước"
    Dim sysNull As System.DBNull
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myNuoc As New Ma_Nuoc(GConnectionString)
    Dim myTmp_Nuoc As New Tmp_Ma_Nuoc(GConnectionString)
    Dim myCuoc_QT As New Cuoc_QT(GConnectionString)
    Dim myTmp_Cuoc_QT As New Tmp_Cuoc_QT(GConnectionString)
    Dim myCuoc_Vung_Xa As New Cuoc_Vung_Xa(GConnectionString)
    Dim myTmp_Cuoc_Vung_Xa As New Tmp_Cuoc_Vung_Xa(GConnectionString)
    Dim myKhuyen_Mai As New Khuyen_Mai(GConnectionString)
    Dim myTmp_Khuyen_Mai As New Tmp_Khuyen_Mai(GConnectionString)
    Dim myTinh As New Ma_Tinh(GConnectionString)
    Dim myTmp_Tinh As New Tmp_Ma_Tinh(GConnectionString)
    Dim myCuoc_TN As New Cuoc_TN(GConnectionString)
    Dim myTmp_Cuoc_TN As New Tmp_Cuoc_TN(GConnectionString)
    Dim myCuoc_TN_TT As New Cuoc_TN_TT(GConnectionString)
    Dim myTmp_Cuoc_TN_TT As New Tmp_Cuoc_TN_TT(GConnectionString)
    Dim myKhuVucQT As New Khu_Vuc_QT(GConnectionString)
    Dim myDich_Vu As New Dich_Vu(GConnectionString)
    Dim myKhu_Vuc_TN As New Khu_Vuc_TN(GConnectionString)
    Dim myTmp_Khu_Vuc_TN As New Tmp_Khu_Vuc_TN(GConnectionString)
    Dim myGiam_Gia As New Giam_Gia(GConnectionString)
    Dim myTmp_Giam_Gia As New Tmp_Giam_Gia(GConnectionString)
    Dim myCuoc_Phat As New Cuoc_Phat(GConnectionString)
    Dim myCuoc_Phat_Hanh As New Cuoc_Phat_Hanh(GConnectionString)
    Dim myTmp_Cuoc_Phat_Hanh As New Tmp_Cuoc_Phat_Hanh(GConnectionString)
    Dim myTmp_Cuoc_Phat As New Tmp_Cuoc_Phat(GConnectionString)
    Dim myCuoc_Dv_Cong_Them As New Cuoc_Dv_Cong_Them(GConnectionString)
    Dim myTmp_Cuoc_Dv_Cong_Them As New Tmp_Cuoc_Dv_Cong_Them(GConnectionString)
    'Dim myCuoc_Dv_Gia_Tang As New Cuoc_Dv_Gia_Tang(GConnectionString)
    Dim myTmp_Cuoc_Dv_Gia_Tang As New Tmp_Cuoc_Dv_Gia_Tang(GConnectionString)
    Dim myCuoc_Dv_Khai_Gia As New Cuoc_Dv_Khai_Gia(GConnectionString)
    Dim myTmp_Cuoc_Dv_Khai_Gia As New Tmp_Cuoc_Dv_Khai_Gia(GConnectionString)
    Dim myCuoc_PPXD_VAT As New Cuoc_PPXD_Vat(GConnectionString)
    Dim myTmp_Cuoc_PPXD_VAT As New Tmp_Cuoc_PPXD_Vat(GConnectionString)
    'Dim myCuoc_Dv_COD As New Cuoc_Dv_COD(GConnectionString)
    Dim myCuoc_TCT As New Cuoc_TCT(GConnectionString)
    'Dim myTmp_Cuoc_Dv_COD As New Tmp_Cuoc_Dv_COD(GConnectionString)
    Dim i As Integer
    Dim myMa_BC_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    Dim myham_dung_chung As New Ham_Dung_Chung
#End Region

#Region "Tạo bảng Phân loại bưu phẩm"
    Private Sub Tao_Bang_Phan_Loai_BP()
        'Them moi mot bang
        Dim dataTable As New dataTable("Phan_Loai_BP")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Phan_Loai_BP", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai_BP", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Phan_Loai_BP") = "D"
        row("Ten_Phan_Loai_BP") = "Tài liệu"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai_BP") = "M"
        row("Ten_Phan_Loai_BP") = "Hàng hoá"
        dataTable.Rows.Add(row)

        ddPhan_Loai_BP.DataSource = dataTable
        ddPhan_Loai_BP.DataBind()
    End Sub
#End Region

#Region "Tạo bảng Cach_Tinh"
    Private Sub Tao_Bang_Cach_Tinh()
        'Them moi mot bang
        Dim dataTable As New dataTable("Cach_Tinh")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Cach_Tinh", GetType(Boolean))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Cach_Tinh", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Cach_Tinh") = False
        row("Ten_Cach_Tinh") = "Tính đến"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Cach_Tinh") = True
        row("Ten_Cach_Tinh") = "Tiếp theo"
        dataTable.Rows.Add(row)

        ddCach_Tinh.DataSource = dataTable
        ddCach_Tinh.DataBind()
    End Sub
#End Region

#Region "Tạo bảng khu vực trong nước"
    Private Sub Tao_Bang_Khu_Vuc_TN()
        'Them moi mot bang
        Dim dataTable As New dataTable("Khu_Vuc_TN")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Khu_Vuc", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Khu_Vuc", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Khu_Vuc") = 1
        row("Ten_Khu_Vuc") = "Nội tỉnh"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Khu_Vuc") = 2
        row("Ten_Khu_Vuc") = "Liên tỉnh < 300Km"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Khu_Vuc") = 3
        row("Ten_Khu_Vuc") = "Liên tỉnh > 300Km"
        dataTable.Rows.Add(row)

        ddkhu_Vuc_TN.DataSource = dataTable
        ddkhu_Vuc_TN.DataBind()
    End Sub
#End Region

#Region "Hiển thị danh sách trong DataGrid của các bảng Danh Mục Cước"
#Region "gandulieu"
    Private Sub gandulieu()
        ddKhuVucQT.DataSource = myKhuVucQT.Danh_Sach.Tables(0)
        ddKhuVucQT.DataBind()
        ddKhuVucQT.Refresh()
    End Sub
#End Region
#Region "DataGridDich_Vu"
    Private Sub DataGridDich_Vu()
        dgdich_Vu.DataSource = myDich_Vu.Danh_Sach.Tables(0)
        dgdich_Vu.DataBind()
        dgdich_Vu.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_QT"
    Private Sub DataGridCuoc_QT()
        dgCuoc_QT.DataSource = myCuoc_QT.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_QT.DataBind()
        dgCuoc_QT.Rows.Band.AddNew()
        dgCuoc_QT.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_QT"
    Private Sub DataGridTmp_Cuoc_QT()
        dgTmp_Cuoc_QT.DataSource = myTmp_Cuoc_QT.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_QT.DataBind()
        dgTmp_Cuoc_QT.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_Vung_Xa"
    Private Sub DataGridCuoc_Vung_Xa()
        dgCuoc_Vung_Xa.DataSource = myCuoc_Vung_Xa.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_Vung_Xa.DataBind()
        dgCuoc_Vung_Xa.Rows.Band.AddNew()
        dgCuoc_Vung_Xa.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_Vung_Xa"
    Private Sub DataGridTmp_Cuoc_Vung_Xa()
        dgTmp_Cuoc_Vung_Xa.DataSource = myTmp_Cuoc_Vung_Xa.Danh_Sach.Tables(0)
        dgTmp_Cuoc_Vung_Xa.DataBind()
        dgTmp_Cuoc_Vung_Xa.Refresh()
    End Sub
#End Region
#Region "DataGridKhuyen_Mai"
    Private Sub DataGridKhuyen_Mai()
        dgKhuyen_Mai.DataSource = myKhuyen_Mai.Danh_Sach_Hien_Thi.Tables(0)
        dgKhuyen_Mai.DataBind()
        dgKhuyen_Mai.Rows.Band.AddNew()
        dgKhuyen_Mai.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Khuyen_Mai"
    Private Sub DataGridTmp_Khuyen_Mai()
        dgTmp_Khuyen_Mai.DataSource = myTmp_Khuyen_Mai.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Khuyen_Mai.DataBind()
        dgTmp_Khuyen_Mai.Refresh()
    End Sub
#End Region
#Region "DataGridNuoc"
    Private Sub DataGridNuoc()
        dgNuoc.DataSource = myNuoc.Danh_Sach.Tables(0)
        dgNuoc.DataBind()
        'dgNuoc.Rows.Band.AddNew()
        'dgNuoc.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Nuoc"
    Private Sub DataGridTmp_Nuoc()
        dgTmp_Nuoc.DataSource = myTmp_Nuoc.Danh_Sach.Tables(0)
        dgTmp_Nuoc.DataBind()
        dgTmp_Nuoc.Refresh()
    End Sub
#End Region
#Region "DataGridTinh"
    Private Sub DataGridTinh()
        dgTinh.DataSource = myTinh.Danh_Sach_Ma_Tinh_Khu_Vuc_Tn(GBuu_Cuc_Khai_Thac)
        dgTinh.DataBind()
        dgTinh.Rows.Band.AddNew()
        dgTinh.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Tinh"
    Private Sub DataGridTmp_Tinh()
        dgTmp_Tinh.DataSource = myTmp_Tinh.Danh_Sach_Ma_Tinh_Khu_Vuc_TN(GBuu_Cuc_Khai_Thac)
        dgTmp_Tinh.DataBind()
        dgTmp_Tinh.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_TN"
    Private Sub DataGridCuoc_TN()
        dgCuoc_TN.DataSource = myCuoc_TN.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_TN.DataBind()
        dgCuoc_TN.Rows.Band.AddNew()
        dgCuoc_TN.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_TN"
    Private Sub DataGridTmp_Cuoc_TN()
        dgTmp_Cuoc_TN.DataSource = myTmp_Cuoc_TN.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_TN.DataBind()
        dgTmp_Cuoc_TN.Refresh()
    End Sub
#End Region
#Region "DataGridGiam_Gia"
    Private Sub DataGridGiam_Gia()
        dgGiam_Gia.DataSource = myGiam_Gia.Danh_Sach_Hien_Thi.Tables(0)
        dgGiam_Gia.DataBind()
        dgGiam_Gia.Rows.Band.AddNew()
        dgGiam_Gia.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_Phat"
    Private Sub DataGridCuoc_Phat()
        dgCuoc_Phat.DataSource = myCuoc_Phat.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_Phat.DataBind()
        dgCuoc_Phat.Rows.Band.AddNew()
        dgCuoc_Phat.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_Phat"
    Private Sub DataGridTmp_Cuoc_Phat()
        dgTmp_Cuoc_Phat.DataSource = myTmp_Cuoc_Phat.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_Phat.DataBind()
        dgTmp_Cuoc_Phat.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_Phat_Hanh"
    Private Sub DataGridCuoc_Phat_Hanh()
        dgCuoc_Phat_Hanh.DataSource = myCuoc_Phat_Hanh.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_Phat_Hanh.DataBind()
        dgCuoc_Phat_Hanh.Rows.Band.AddNew()
        dgCuoc_Phat_Hanh.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_Phat_Hanh"
    Private Sub DataGridTmp_Cuoc_Phat_Hanh()
        dgTmp_Cuoc_Phat_Hanh.DataSource = myTmp_Cuoc_Phat_Hanh.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_Phat_Hanh.DataBind()
        dgTmp_Cuoc_Phat_Hanh.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_Dv_Cong_Them"
    Private Sub DataGridCuoc_Dv_Cong_Them()
        dgCuoc_Dv_Cong_Them.DataSource = myCuoc_Dv_Cong_Them.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_Dv_Cong_Them.DataBind()
        dgCuoc_Dv_Cong_Them.Rows.Band.AddNew()
        dgCuoc_Dv_Cong_Them.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_Dv_Cong_Them"
    Private Sub DataGridTmp_Cuoc_Dv_Cong_Them()
        dgTmp_Cuoc_Dv_Cong_Them.DataSource = myTmp_Cuoc_Dv_Cong_Them.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_Dv_Cong_Them.DataBind()
        dgTmp_Cuoc_Dv_Cong_Them.Refresh()
    End Sub
#End Region
    '#Region "DataGridCuoc_Dv_Gia_Tang"
    '    Private Sub DataGridCuoc_Dv_Gia_Tang()
    '        dgCuoc_Dv_Gia_Tang.DataSource = myCuoc_Dv_Gia_Tang.Danh_Sach_Hien_Thi.Tables(0)
    '        dgCuoc_Dv_Gia_Tang.DataBind()
    '        dgCuoc_Dv_Gia_Tang.Rows.Band.AddNew()
    '        dgCuoc_Dv_Gia_Tang.Refresh()
    '    End Sub
    '#End Region
#Region "DataGridTmp_Cuoc_Dv_Gia_Tang"
    Private Sub DataGridTmp_Cuoc_Dv_Gia_Tang()
        dgTmp_Cuoc_Dv_Gia_Tang.DataSource = myTmp_Cuoc_Dv_Gia_Tang.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_Dv_Gia_Tang.DataBind()
        dgTmp_Cuoc_Dv_Gia_Tang.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_PPXD_VAT"
    Private Sub DataGridCuoc_PPXD_VAT()
        dgCuoc_PPXD_VAT.DataSource = myCuoc_PPXD_VAT.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_PPXD_VAT.DataBind()
        dgCuoc_PPXD_VAT.Rows.Band.AddNew()
        dgCuoc_PPXD_VAT.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_PPXD_VAT"
    Private Sub DataGridTmp_Cuoc_PPXD_VAT()
        dgTmp_Cuoc_PPXD_VAT.DataSource = myTmp_Cuoc_PPXD_VAT.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_PPXD_VAT.DataBind()
        dgTmp_Cuoc_PPXD_VAT.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_Dv_Khai_Gia"
    Private Sub DataGridCuoc_Dv_Khai_Gia()
        dgCuoc_DV_Khai_Gia.DataSource = myCuoc_Dv_Khai_Gia.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_DV_Khai_Gia.DataBind()
        dgCuoc_DV_Khai_Gia.Rows.Band.AddNew()
        dgCuoc_DV_Khai_Gia.Refresh()
    End Sub
#End Region
#Region "DataGridTmp_Cuoc_Dv_Khai_Gia"
    Private Sub DataGridTmp_Cuoc_Dv_Khai_Gia()
        dgTmp_Cuoc_Dv_Khai_Gia.DataSource = myTmp_Cuoc_Dv_Khai_Gia.Danh_Sach_Hien_Thi.Tables(0)
        dgTmp_Cuoc_Dv_Khai_Gia.DataBind()
        dgTmp_Cuoc_Dv_Khai_Gia.Refresh()
    End Sub
#End Region
#Region "DataGridCuoc_TCT"
    Private Sub DataGridCuoc_TCT()
        dgCuoc_TCT.DataSource = myCuoc_TCT.Danh_Sach_Hien_Thi.Tables(0)
        dgCuoc_TCT.DataBind()
        dgCuoc_TCT.Rows.Band.AddNew()
        dgCuoc_TCT.Refresh()
    End Sub
#End Region
#Region "DataGridMa_Bc_Khai_Thac"
    Private Sub DataGridMa_Bc_Khai_Thac()
        ddMa_BC_Khai_Thac.DataSource = myMa_BC_Khai_Thac.Danh_Sach.Tables(0)
        ddMa_BC_Khai_Thac.DataBind()
    End Sub
#End Region
#Region "DataGridDanh_Muc_Bc"
    Private Sub DataGridDanh_Muc_Bc()
        ddDanh_Muc_BC.DataSource = myDanh_Muc_BC.Danh_Sach.Tables(0)
        ddDanh_Muc_BC.DataBind()
    End Sub
#End Region
#Region "DataGridddMa_Tinh"
    Private Sub DataGridddMa_Tinh()
        ddMa_Tinh.DataSource = myTinh.Danh_Sach.Tables(0)
        ddMa_Tinh.DataBind()
    End Sub
#End Region
#End Region

#Region "Load dữ liệu bảng Danh Mục Cước"
    Private Sub FrmCacBangDanhMucCuoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tao_Bang_Phan_Loai_BP()
        Tao_Bang_Khu_Vuc_TN()
        Tao_Bang_Cach_Tinh()
        Rd_Pc.Checked = True
        Me.Text = Me.Text & "  ( " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac & " )"

        dgCuoc_TN.Visible = True
        dgTmp_Cuoc_TN.Visible = False
        dgCuoc_TN_TT.Visible = False
        dgTmp_Cuoc_TN_TT.Visible = False

    End Sub
#End Region

#Region "dgNuoc_InitializeLayout"
    Private Sub dgNuoc_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgNuoc.InitializeLayout
        dgNuoc.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgNuoc.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgNuoc.DisplayLayout
            .Bands(0).Columns("Ma_Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Khu_Vuc").ValueList = ddKhuVucQT
        End With
    End Sub
#End Region

#Region "Delete - Xoá dữ liệu trong các bảng danh mục cước theo khoá chính"
    '#Region "DeleteNuoc"
    '    Private Sub DeleteNuoc()
    '        If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            myNuoc.Xoa(dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text)
    '            dgNuoc.ActiveRow.Delete(False)
    '            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            DataGridNuoc()
    '        End If
    '    End Sub
    '#End Region

#Region "DeleteCuoc_QT"
    Private Sub DeleteCuoc_QT()
        Dim Id_Cuoc_QT As Integer
        Id_Cuoc_QT = IIf(dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Id_Cuoc_QT").Value Is System.DBNull.Value, 0, dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Id_Cuoc_QT").Value)
        If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_QT.Xoa(Id_Cuoc_QT)
            dgCuoc_QT.ActiveRow.Delete(False)
            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "DeleteCuoc_Vung_Xa"
    Private Sub DeleteCuoc_Vung_Xa()
        Dim Id_Cuoc_Vung_Xa As Integer
        Id_Cuoc_Vung_Xa = IIf(dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Id_Cuoc_Vung_Xa").Value Is System.DBNull.Value, 0, dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Id_Cuoc_Vung_Xa").Value)
        If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_Vung_Xa.Xoa(Id_Cuoc_Vung_Xa)
            dgCuoc_Vung_Xa.ActiveRow.Delete(False)
            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "DeleteKhuyen_Mai"
    Private Sub DeleteKhuyen_Mai()
        Dim Id_Khuyen_Mai As Integer
        Id_Khuyen_Mai = IIf(dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Id_Khuyen_Mai").Value Is System.DBNull.Value, 0, dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Id_Khuyen_Mai").Value)
        If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myKhuyen_Mai.Xoa(Id_Khuyen_Mai)
            dgKhuyen_Mai.ActiveRow.Delete(False)
            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

    '#Region "DeleteTinh"
    '    Private Sub DeleteTinh()
    '        If MessageBox.Show("Bạn có thực sự muốn xóa mã tỉnh này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            myTinh.Xoa(dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Text)
    '            dgTinh.ActiveRow.Delete(False)
    '            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            DataGridTinh()
    '        End If
    '    End Sub
    '#End Region

#Region "DeleteCuoc_TN"
    Private Sub DeleteCuoc_TN()
        Dim Id_Cuoc_TN As Integer
        Id_Cuoc_TN = IIf(dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Id_Cuoc_TN").Value Is System.DBNull.Value, 0, dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Id_Cuoc_TN").Value)
        If MessageBox.Show("Bạn có thực sự muốn xóa mã tỉnh này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_TN.Xoa(Id_Cuoc_TN)
            dgCuoc_TN.ActiveRow.Delete(False)
            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "DeleteCuoc_TN_TT"
    Private Sub DeleteCuoc_TN_TT()
        Dim Id_Cuoc_TN_TT As Integer
        Id_Cuoc_TN_TT = IIf(dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Id_Cuoc_TN_TT").Value Is System.DBNull.Value, 0, dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Id_Cuoc_TN_TT").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng khu vực cước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_TN_TT.Xoa(Id_Cuoc_TN_TT)
                dgCuoc_TN_TT.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteCuoc_Phat"
    Private Sub DeleteCuoc_Phat()
        Dim Id_Cuoc_Phat As Integer
        Id_Cuoc_Phat = IIf(dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value Is System.DBNull.Value, 0, dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_Phat.Xoa(Id_Cuoc_Phat)
                dgCuoc_Phat.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteCuoc_Phat_Hanh"
    Private Sub DeleteCuoc_Phat_Hanh()
        Dim Id_Cuoc_Phat As Integer
        Id_Cuoc_Phat = IIf(dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value Is System.DBNull.Value, 0, dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_Phat_Hanh.Xoa(Id_Cuoc_Phat)
                dgCuoc_Phat_Hanh.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteCuoc_Dv_Cong_Them"
    Private Sub DeleteCuoc_Dv_Cong_Them()
        Dim Id_Dv_Cong_Them As Integer
        Id_Dv_Cong_Them = IIf(dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Id_Dv_Cong_Them").Value Is System.DBNull.Value, 0, dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Id_Dv_Cong_Them").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_Dv_Cong_Them.Xoa(Id_Dv_Cong_Them)
                dgCuoc_Dv_Cong_Them.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteCuoc_PPXD_VAT"
    Private Sub DeleteCuoc_PPXD_VAT()
        Dim Id_Cuoc_PPXD_Vat As Integer
        Id_Cuoc_PPXD_Vat = IIf(dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Id_Cuoc_PPXD_Vat").Value Is System.DBNull.Value, 0, dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Id_Cuoc_PPXD_Vat").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_PPXD_VAT.Xoa(Id_Cuoc_PPXD_Vat)
                dgCuoc_PPXD_VAT.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

    '#Region "DeleteCuoc_Dv_Gia_Tang"
    '    Private Sub DeleteCuoc_Dv_Gia_Tang()
    '        Dim Id_Cuoc_Dv As Integer
    '        Id_Cuoc_Dv = IIf(dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Id_Cuoc_Dv").Value Is System.DBNull.Value, 0, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Id_Cuoc_Dv").Value)
    '            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            myCuoc_Dv_Gia_Tang.Xoa(Id_Cuoc_Dv)
    '                dgCuoc_Dv_Gia_Tang.ActiveRow.Delete(False)
    '                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '    End Sub
    '#End Region

#Region "DeleteCuoc_Dv_Khai_Gia"
    Private Sub DeleteCuoc_Dv_Khai_Gia()
        Dim Id_Cuoc_Khai_Gia As Integer
        Id_Cuoc_Khai_Gia = IIf(dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Id_Cuoc_Khai_Gia").Value Is System.DBNull.Value, 0, dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Id_Cuoc_Khai_Gia").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_Dv_Khai_Gia.Xoa(Id_Cuoc_Khai_Gia)
                dgCuoc_DV_Khai_Gia.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteGiam_Gia"
    Private Sub DeleteGiam_Gia()
        Dim Id_Giam_Gia As Integer
        Id_Giam_Gia = IIf(dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Id_Giam_Gia").Value Is System.DBNull.Value, 0, dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Id_Giam_Gia").Value)
            If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myGiam_Gia.Xoa(Id_Giam_Gia)
                dgGiam_Gia.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
#End Region

#Region "DeleteCuoc_TCT"
    Private Sub DeleteCuoc_TCT()
        Dim Id_Cuoc_TCT As Integer
        Id_Cuoc_TCT = IIf(dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Id_Cuoc_TCT").Value Is System.DBNull.Value, 0, dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Id_Cuoc_TCT").Value)
        If MessageBox.Show("Bạn có thực sự muốn xóa mã nước này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            myCuoc_TCT.Xoa(Id_Cuoc_TCT)
            dgCuoc_TCT.ActiveRow.Delete(False)
            CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#End Region

#Region "AddNewRow"
    Private Sub AddNewRow(ByVal sender As Object)
        'myGridKeyDown = sender
        'If myGridKeyDown.Rows.Count > 0 Then
        '    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).HasNextSibling = False And Not myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1) Is Nothing Then
        '        myGridKeyDown.Rows.Band.AddNew()
        '    End If
        'End If
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
#End Region

#Region "dgNuoc_AfterRowUpdate - Sự kiện sau khi thêm 1 dòng dữ liệu mới"
    Private Sub dgNuoc_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgNuoc.AfterRowUpdate
        If dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text <> "" And dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 Then
            myNuoc.Cap_Nhat_Them(dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value, dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Value, dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Value)
        End If
    End Sub
#End Region

#Region "dgTinh_InitializeLayout"
    Private Sub dgTinh_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTinh.InitializeLayout
        dgTinh.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTinh.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTinh.DisplayLayout
            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN
        End With
    End Sub
#End Region

#Region "Sự kiện KeyDown của các DataGrid trong bảng danh mục cước"
    Private Sub dgTinh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgKhuyen_Mai.KeyDown, dgCuoc_Vung_Xa.KeyDown, dgCuoc_QT.KeyDown, dgNuoc.KeyDown, dgGiam_Gia.KeyDown, dgCuoc_TN_TT.KeyDown, dgCuoc_TN.KeyDown, dgTinh.KeyDown, dgCuoc_Phat.KeyDown, dgCuoc_Dv_Cong_Them.KeyDown, dgCuoc_Dv_Gia_Tang.KeyDown, dgCuoc_DV_Khai_Gia.KeyDown, dgCuoc_PPXD_VAT.KeyDown, dgCuoc_TCT.KeyDown, dgCuoc_Phat_Hanh.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing And (e.KeyValue <> Keys.Escape) Then
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
                'If myGridKeyDown.Name = dgTinh.Name Then
                '    DeleteTinh()
                'End If
                If myGridKeyDown.Name = dgCuoc_TN.Name Then
                    DeleteCuoc_TN()
                End If
                If myGridKeyDown.Name = dgCuoc_TN_TT.Name Then
                    DeleteCuoc_TN_TT()
                End If
                'If myGridKeyDown.Name = dgNuoc.Name Then
                '    DeleteNuoc()
                'End If
                If myGridKeyDown.Name = dgCuoc_QT.Name Then
                    DeleteCuoc_QT()
                End If
                If myGridKeyDown.Name = dgCuoc_Vung_Xa.Name Then
                    DeleteCuoc_Vung_Xa()
                End If
                If myGridKeyDown.Name = dgKhuyen_Mai.Name Then
                    DeleteKhuyen_Mai()
                End If
                If myGridKeyDown.Name = dgCuoc_Phat.Name Then
                    DeleteCuoc_Phat()
                End If
                If myGridKeyDown.Name = dgCuoc_Phat_Hanh.Name Then
                    DeleteCuoc_Phat_Hanh()
                End If
                If myGridKeyDown.Name = dgCuoc_Dv_Cong_Them.Name Then
                    DeleteCuoc_Dv_Cong_Them()
                End If
                If myGridKeyDown.Name = dgCuoc_PPXD_VAT.Name Then
                    DeleteCuoc_PPXD_VAT()
                End If
                If myGridKeyDown.Name = dgCuoc_Dv_Gia_Tang.Name Then
                    'DeleteCuoc_Dv_Gia_Tang()
                End If
                If myGridKeyDown.Name = dgCuoc_DV_Khai_Gia.Name Then
                    DeleteCuoc_Dv_Khai_Gia()
                End If
                If myGridKeyDown.Name = dgCuoc_TCT.Name Then
                    DeleteCuoc_TCT()
                End If
                If myGridKeyDown.Name = dgGiam_Gia.Name Then
                    DeleteGiam_Gia()
                End If
                e.Handled = True
            Case Keys.F1
        End Select
    End Sub
#End Region

#Region "Match Function"
    Private Function Match(ByVal userString As String, ByVal cellValue As String) As Boolean
        If userString.Length > cellValue.Length Then
            Match = False
            Exit Function
        ElseIf userString.Length = cellValue.Length Then
            If userString.ToLower = cellValue.ToLower Then Match = True Else Match = False
            Exit Function
        Else
            Dim i As Integer
            For i = 0 To (cellValue.Length - userString.Length) - 0
                If userString.ToLower = cellValue.ToLower.Substring(i, userString.Length) Then
                    Match = True
                    Exit Function
                End If
            Next
            Match = False
            Exit Function
        End If
    End Function
#End Region

#Region "MatchText Function"
    Private Function MatchText(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow, ByVal _myString As String) As Boolean
        If oRow Is Nothing Then
            MatchText = False
            Exit Function
        End If
        Dim oCol As Infragistics.Win.UltraWinGrid.UltraGridColumn
        Dim strCellValue As String = ""
        For Each oCol In _myGrid.DisplayLayout.Bands(0).Columns
            If Not oRow.Cells(oCol.Key).Value Is System.DBNull.Value Then
                If Me.Match(_myString, oRow.Cells(oCol.Key).Value) Then
                    MatchText = True
                    Me.myColumn = oCol
                    Exit Function
                End If
            End If
        Next
    End Function
#End Region

#Region "Search - Tìm kiếm"
    Public Sub Search(ByVal _myGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal _myString As String)
        Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        oRow = _myGrid.ActiveRow
        If oRow Is Nothing Then oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)

        While Not oRow Is Nothing
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
        End While
        oRow = _myGrid.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First)
        While Not oRow Is Nothing
            If Me.MatchText(_myGrid, oRow, _myString) Then
                _myGrid.ActiveRow = oRow
                If Not Me.myColumn Is Nothing Then
                    _myGrid.ActiveCell = oRow.Cells(Me.myColumn.Key)
                    _myGrid.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell, False, False)
                End If
                Exit Sub
            End If
            oRow = oRow.GetSibling(Infragistics.Win.UltraWinGrid.SiblingRow.Next)
        End While
        MessageBox.Show("Đã tìm kiếm hết danh sách rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub
#End Region

#Region "Các sự kiện_MouseDown của các DataGrid trong bảng danh mục cước"
    Private Sub dgTinh_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgKhuyen_Mai.MouseDown, dgCuoc_Vung_Xa.MouseDown, dgCuoc_QT.MouseDown, dgNuoc.MouseDown, dgGiam_Gia.MouseDown, dgCuoc_TN_TT.MouseDown, dgCuoc_TN.MouseDown, dgTinh.MouseDown, dgCuoc_Phat.MouseDown, dgCuoc_Dv_Cong_Them.MouseDown, dgCuoc_Dv_Gia_Tang.MouseDown, dgCuoc_DV_Khai_Gia.MouseDown, dgCuoc_PPXD_VAT.MouseDown, dgCuoc_TCT.MouseDown, dgCuoc_Phat_Hanh.MouseDown
        myGridKeyDown = sender
        If e.Button = MouseButtons.Right Then

            Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
            Dim oUIElement As Infragistics.Win.UIElement
            Dim point As Point = New Point(e.X, e.Y)

            oUIElement = Me.myGridKeyDown.DisplayLayout.UIElement.ElementFromPoint(point)
            If oUIElement Is Nothing Then Exit Sub
            oUIElement = oUIElement.GetAncestor(GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement))
            If oUIElement Is Nothing Then
                Return
            End If
            If Not oUIElement.GetType() Is GetType(Infragistics.Win.UltraWinGrid.HeaderUIElement) Then Exit Sub
            oHeaderUI = oUIElement
            Dim oColHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = Nothing
            Me.myColumn = Nothing
            oColHeader = oHeaderUI.SelectableItem
            Me.myColumn = oColHeader.Column
            If Me.myColumn Is Nothing Then Exit Sub

            Me.mnuMenu.Show(Me.myGridKeyDown, point)
        End If
    End Sub
#End Region

#Region "mnuTimKiem_Click tìm kiếm trong DataGrid"
    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
        If Me.FrmTK Is Nothing Then
            Me.FrmTK = New FrmTimKiemDanhMuc
        End If

        Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
    End Sub
#End Region

#Region "UltraTabControl1_SelectedTabChanged - Sự kiện khi click vào các Tabs"
    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        If Not Me.FrmTK Is Nothing Then
            Me.FrmTK.Hide()
        End If
        If e.Tab.Index = 0 Then
            gandulieu()
            DataGridMa_Bc_Khai_Thac()
            DataGridDanh_Muc_Bc()
            DataGridNuoc()
            If Rd_May_Chu.Checked = True Then
                DataGridTmp_Nuoc()
            End If
        ElseIf e.Tab.Index = 1 Then
            DataGridddMa_Tinh()
            DataGridTinh()
            If Rd_May_Chu.Checked = True Then
                DataGridTmp_Tinh()
            End If
        ElseIf e.Tab.Index = 2 Then
            DataGridCuoc_Phat_Hanh()
            DataGridTmp_Cuoc_Phat_Hanh()
            DataGridddMa_Tinh()
        ElseIf e.Tab.Index = 3 Then
            DataGridCuoc_Phat()
            DataGridTmp_Cuoc_Phat()
            'ElseIf e.Tab.Index = 4 Then
            '    DataGridCuoc_Dv_Cong_Them()
            '    DataGridTmp_Cuoc_Dv_Cong_Them()
            '    DataGridDich_Vu()
            'ElseIf e.Tab.Index = 5 Then
            'DataGridCuoc_Dv_Gia_Tang()
            'DataGridTmp_Cuoc_Dv_Gia_Tang()
            'DataGridDich_Vu()
            'ElseIf e.Tab.Index = 6 Then
            '    DataGridCuoc_Dv_Khai_Gia()
            '    DataGridTmp_Cuoc_Dv_Khai_Gia()
            '    DataGridDich_Vu()
        ElseIf e.Tab.Index = 4 Then
            DataGridCuoc_PPXD_VAT()
            DataGridTmp_Cuoc_PPXD_VAT()
            'ElseIf e.Tab.Index = 8 Then
            '    DataGridCuoc_TCT()
        End If
    End Sub
#End Region

    '#Region "dgNuoc_AfterCellUpdate"
    '    Private Sub dgNuoc_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgNuoc.AfterCellUpdate
    '        If e.Cell.Row.Cells("Ma_Nuoc").IsActiveCell Then
    '            AddNewRow(sender)
    '        End If
    '    End Sub
    '#End Region

#Region "Các sự kiện BeforeCellDeactivate của các DataGrid trong bảng danh mục Cước"
    Private Sub dgNuoc_BeforeCellDeactivate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgKhuyen_Mai.BeforeCellDeactivate, dgCuoc_Vung_Xa.BeforeCellDeactivate, dgCuoc_QT.BeforeCellDeactivate, dgNuoc.BeforeCellDeactivate, dgGiam_Gia.BeforeCellDeactivate, dgCuoc_TN_TT.BeforeCellDeactivate, dgCuoc_TN.BeforeCellDeactivate, dgTinh.BeforeCellDeactivate, dgCuoc_Phat.BeforeCellDeactivate, dgCuoc_Dv_Cong_Them.BeforeCellDeactivate, dgCuoc_Dv_Gia_Tang.BeforeCellDeactivate, dgCuoc_DV_Khai_Gia.BeforeCellDeactivate, dgCuoc_PPXD_VAT.BeforeCellDeactivate, dgCuoc_TCT.BeforeCellDeactivate, dgCuoc_Phat_Hanh.BeforeCellDeactivate
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Cancel = True
            'myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction( _
                Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode _
              , False _
              , False)
            myCell = Nothing
        End If
    End Sub
#End Region

#Region "dgNuoc_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgNuoc"
    Private Sub dgNuoc_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgNuoc.AfterExitEditMode
        Select Case dgNuoc.ActiveCell.Column.Key
            Case "Ma_Nuoc"
                If dgNuoc.ActiveCell.Text.Length <> 2 Or dgNuoc.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Mã nước không đúng quy cách, phải nhập đúng 2 ký tự !!!", "Thông báo")
                    myCell = dgNuoc.ActiveCell
                    Exit Sub
                End If
            Case "Ten_Nuoc"
                If dgNuoc.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Phải nhập tên nước vào !!!", "Thông báo")
                    myCell = dgNuoc.ActiveCell
                    Exit Sub
                End If
            Case "Ma_Khu_Vuc"
                If dgNuoc.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Phải nhập mã khu vực vào !!!", "Thông báo")
                    myCell = dgNuoc.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgTinh_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgTinh"
    Private Sub dgTinh_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgTinh.AfterExitEditMode
        Select Case dgTinh.ActiveCell.Column.Key
            Case "Ma_Tinh"
                If dgTinh.ActiveCell.Text.Length <> 6 Or dgTinh.ActiveCell.Text.Length = 0 Or dgTinh.ActiveCell.Text Is sysNull Then
                    CMessageBox.Show("Mã tỉnh không đúng quy cách, phải nhập đúng 6 mã số !!!", "Thông báo")
                    myCell = dgTinh.ActiveCell
                    Exit Sub
                End If
            Case "Ten_tinh"
                If dgTinh.ActiveCell.Text.Length = 0 Or dgTinh.ActiveCell.Text Is sysNull Then
                    CMessageBox.Show("Phải nhập tên tỉnh vào !!!", "Thông báo")
                    myCell = dgTinh.ActiveCell
                    Exit Sub
                End If
            Case "Khu_Vuc"
                If dgTinh.ActiveCell.Text.Length = 0 Or dgTinh.ActiveCell.Text Is sysNull Then
                    CMessageBox.Show("Phải nhập mã khu vực vào !!!", "Thông báo")
                    myCell = dgTinh.ActiveCell
                    Exit Sub
                End If
            Case "Thoa_Thuan"
                If dgTinh.ActiveCell.Text.Length = 0 Or dgTinh.ActiveCell.Text Is sysNull Then
                    CMessageBox.Show("Phải nhập chọn tỉnh có Thoả Thuận hay không Thoả Thuận !!!", "Thông báo")
                    myCell = dgTinh.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

    '#Region "dgTinh_AfterCellUpdate - thêm 1 dòng dữ liệu mới trong DataGrid dgTinh"
    '    Private Sub dgTinh_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgTinh.AfterCellUpdate
    '        If e.Cell.Row.Cells("Ma_Tinh").IsActiveCell Then
    '            AddNewRow(sender)
    '            If dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value Is System.DBNull.Value Then
    '                dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value = False
    '            End If
    '        End If
    '    End Sub
    '#End Region

#Region "dgCuoc_QT_InitializeLayout"
    Private Sub dgCuoc_QT_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_QT.InitializeLayout
        dgCuoc_QT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_QT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_QT.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_QT_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_QT"
    Private Sub dgCuoc_QT_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_QT.AfterRowUpdate
        If dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Phan_Loai_BP").Text.Length <> 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Khoi_Luong").Text.Length <> 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_QT As Integer
            Id_Cuoc_QT = IIf(dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Id_Cuoc_QT").Value Is System.DBNull.Value, 0, dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Id_Cuoc_QT").Value)
            myCuoc_QT.Cap_Nhat_Them(Id_Cuoc_QT, dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value, _
            dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
            dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Cach_Tinh").Value, _
            dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Khoi_Luong").Value, _
            dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Cuoc").Value, _
            myham_dung_chung.ConvertDateToInt(dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Value), _
            myham_dung_chung.ConvertDateToInt(dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_QT_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_QT"
    Private Sub dgCuoc_QT_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_QT.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
            If dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
                dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Cach_Tinh").Value = False
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_QT_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_QT"
    Private Sub dgCuoc_QT_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_QT.AfterExitEditMode
        Select Case dgCuoc_QT.ActiveCell.Column.Key
            Case "Phan_Loai_BP"
                If dgCuoc_QT.ActiveCell.Text.Length = 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phải nhập mã phân loại bưu phẩm !!!", "Thông báo")
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong"
                If dgCuoc_QT.ActiveCell.Text.Length = 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phải nhập khối lượng bưu phẩm !!!", "Thông báo")
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Cach_Tinh"
                If dgCuoc_QT.ActiveCell.Text.Length = 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phải lựa chọn cách tính bưu phẩm !!!", "Thông báo")
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_QT.ActiveCell.Text.Length = 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phải nhập cước vào !!!", "Thông báo")
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_QT.Rows(dgCuoc_QT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgNuoc_AfterRowActivate - Sự kiện khi click chuột vào 1 dòng trong DataGrid dgNuoc"
    Private Sub dgNuoc_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgNuoc.AfterRowActivate
        If dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length <> 0 Or dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 And dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text.Length <> 0 Then
            dgCuoc_QT.DataSource = myCuoc_QT.Lay_Boi_Ma_Nuoc(dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value)
            dgCuoc_QT.DataBind()
            dgCuoc_QT.Refresh()
            dgCuoc_QT.Rows.Band.AddNew()
            dgCuoc_Vung_Xa.DataSource = myCuoc_Vung_Xa.Lay_Boi_Ma_Nuoc(dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value)
            dgCuoc_Vung_Xa.DataBind()
            dgCuoc_Vung_Xa.Refresh()
            dgCuoc_Vung_Xa.Rows.Band.AddNew()
            dgKhuyen_Mai.DataSource = myKhuyen_Mai.Lay_Boi_Ma_Nuoc(dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value, GBuu_Cuc_Khai_Thac)
            dgKhuyen_Mai.DataBind()
            dgKhuyen_Mai.Refresh()
            dgKhuyen_Mai.Rows.Band.AddNew()
        End If
    End Sub
#End Region

#Region "dgCuoc_Vung_Xa_InitializeLayout"
    Private Sub dgCuoc_Vung_Xa_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Vung_Xa.InitializeLayout
        dgCuoc_Vung_Xa.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_Vung_Xa.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub
#End Region

#Region "dgCuoc_Vung_Xa_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_Vung_Xa"
    Private Sub dgCuoc_Vung_Xa_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_Vung_Xa.AfterRowUpdate
        If dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Vung_Duoi").Text.Length <> 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Vung_Tren").Text.Length <> 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_Vung_Xa As Integer
            Id_Cuoc_Vung_Xa = IIf(dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Id_Cuoc_Vung_Xa").Value Is System.DBNull.Value, 0, dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Id_Cuoc_Vung_Xa").Value)
            myCuoc_Vung_Xa.Cap_Nhat_Them(Id_Cuoc_Vung_Xa, dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value, _
            dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Vung_Duoi").Value, _
            dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Vung_Tren").Value, _
            dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Cuoc").Value, _
            myham_dung_chung.ConvertDateToInt(dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Value), _
            myham_dung_chung.ConvertDateToInt(dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_Vung_Xa_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_Vung_Xa"
    Private Sub dgCuoc_Vung_Xa_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_Vung_Xa.AfterExitEditMode
        Select Case dgCuoc_Vung_Xa.ActiveCell.Column.Key
            Case "Vung_Duoi"
                If dgCuoc_Vung_Xa.ActiveCell.Text.Length = 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước vùng Dưới !!!", "Thông báo")
                    myCell = dgCuoc_Vung_Xa.ActiveCell
                    Exit Sub
                End If
            Case "Vung_Tren"
                If dgCuoc_Vung_Xa.ActiveCell.Text.Length = 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước vùng Trên !!!", "Thông báo")
                    myCell = dgCuoc_Vung_Xa.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_Vung_Xa.ActiveCell.Text.Length = 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước vùng xa !!!", "Thông báo")
                    myCell = dgCuoc_Vung_Xa.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Vung_Xa.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Vung_Xa.Rows(dgCuoc_Vung_Xa.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Vung_Xa.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgKhuyen_Mai_InitializeLayout"
    Private Sub dgKhuyen_Mai_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgKhuyen_Mai.InitializeLayout
        dgKhuyen_Mai.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgKhuyen_Mai.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgKhuyen_Mai.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            '.Bands(0).Columns("Ma_Bc_Khai_Thac").Style = ColumnStyle.DropDownList
            '.Bands(0).Columns("Ma_Bc_Khai_Thac").ValueList = ddMa_BC_Khai_Thac

            .Bands(0).Columns("Ma_BC").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Bc").ValueList = ddDanh_Muc_BC
        End With
    End Sub
#End Region

#Region "dgKhuyen_Mai_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgKhuyen_Mai"
    Private Sub dgKhuyen_Mai_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgKhuyen_Mai.AfterRowUpdate
        If dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Ma_BC_Khai_Thac").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Ma_BC").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Phan_Loai_BP").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("He_So_Khuyen_Mai").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Khuyen_Mai As Integer
            Id_Khuyen_Mai = IIf(dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Id_Khuyen_Mai").Value Is System.DBNull.Value, 0, dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Id_Khuyen_Mai").Value)
            myKhuyen_Mai.Cap_Nhat_Them(Id_Khuyen_Mai, GBuu_Cuc_Khai_Thac, _
                                    dgNuoc.Rows(dgNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value, _
                                    dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Ma_BC").Value, _
                                    dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
                                    dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("He_so_Khuyen_Mai").Value, _
                                    myham_dung_chung.ConvertDateToInt(dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    myham_dung_chung.ConvertDateToInt(dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_TN_InitializeLayout"
    Private Sub dgCuoc_TN_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_TN.InitializeLayout
        dgCuoc_TN.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_TN.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_TN.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTinh_AfterRowActivate - Sự kiện khi click chuột vào 1 dòng trong DataGrid dgCuoc_TN"
    Private Sub dgTinh_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgTinh.AfterRowActivate
        If dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length <> 0 Or dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length = 6 Then 'loai bo truong hop ma_tinh la null hoac khong dung dinh dang
            If dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value = False And Rd_Pc.Checked = True Then
                dgCuoc_TN.Visible = True
                dgTmp_Cuoc_TN.Visible = False
                dgCuoc_TN_TT.Visible = False
                dgTmp_Cuoc_TN_TT.Visible = False
                dgCuoc_TN.DataSource = myCuoc_TN.Lay_Boi_Khu_Vuc(dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Khu_Vuc").Value)
                dgCuoc_TN.DataBind()
                dgCuoc_TN.Refresh()
                dgCuoc_TN.Rows.Band.AddNew()
            ElseIf Rd_Pc.Checked = True Then
                dgCuoc_TN_TT.Visible = True
                dgTmp_Cuoc_TN_TT.Visible = False
                dgCuoc_TN.Visible = False
                dgTmp_Cuoc_TN.Visible = False
                dgCuoc_TN_TT.DataSource = myCuoc_TN_TT.Lay_Boi_Khu_Vuc(dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Khu_Vuc").Value)
                dgCuoc_TN_TT.DataBind()
                dgCuoc_TN_TT.Refresh()
                dgCuoc_TN_TT.Rows.Band.AddNew()
            End If
            dgGiam_Gia.DataSource = myGiam_Gia.Lay_Boi_Ma_Tinh(dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Value, GBuu_Cuc_Khai_Thac)
            dgGiam_Gia.DataBind()
            dgGiam_Gia.Refresh()
            dgGiam_Gia.Rows.Band.AddNew()
        End If
    End Sub
#End Region

#Region "dgCuoc_TN_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_TN"
    Private Sub dgCuoc_TN_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_TN.AfterCellUpdate
        If e.Cell.Row.Cells("Khu_Vuc").IsActiveCell Then
            AddNewRow(sender)
            If dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
                dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cach_Tinh").Value = False
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_TN_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_TN"
    Private Sub dgCuoc_TN_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_TN.AfterRowUpdate
        If dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Khu_Vuc").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Phan_Loai_BP").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cach_Tinh").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Khoi_Luong").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_TN As Integer
            Id_Cuoc_TN = IIf(dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Id_Cuoc_TN").Value Is System.DBNull.Value, 0, dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Id_Cuoc_TN").Value)
            myCuoc_TN.Cap_Nhat_Them(Id_Cuoc_TN, dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Khu_Vuc").Value, _
                                    dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
                                    dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cach_Tinh").Value, _
                                    dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Khoi_Luong").Value, _
                                    dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Cuoc").Value, _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_TN_TT_InitializeLayout"
    Private Sub dgCuoc_TN_TT_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_TN_TT.InitializeLayout
        dgCuoc_TN_TT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_TN_TT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_TN_TT.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_TN_TT_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_TN_TT"
    Private Sub dgCuoc_TN_TT_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_TN_TT.AfterCellUpdate
        If e.Cell.Row.Cells("Khu_Vuc").IsActiveCell Then
            AddNewRow(sender)
            If dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
                dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cach_Tinh").Value = False
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_TN_TT_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_TN_TT"
    Private Sub dgCuoc_TN_TT_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_TN_TT.AfterRowUpdate
        If dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Khu_Vuc").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Phan_Loai_BP").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cach_Tinh").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Khoi_Luong").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_TN_TT As Integer
            Id_Cuoc_TN_TT = IIf(dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Id_Cuoc_TN_TT").Value Is System.DBNull.Value, 0, dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Id_Cuoc_TN_TT").Value)
            myCuoc_TN_TT.Cap_Nhat_Them(Id_Cuoc_TN_TT, dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Khu_Vuc").Value, _
                                    dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
                                    dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cach_Tinh").Value, _
                                    dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Khoi_Luong").Value, _
                                    dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Cuoc").Value, _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgGiam_Gia_InitializeLayout"
    Private Sub dgGiam_Gia_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgGiam_Gia.InitializeLayout
        dgGiam_Gia.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgGiam_Gia.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgGiam_Gia.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Tinh_Phat_Tra").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Tinh_Phat_Tra").ValueList = ddMa_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_Phat_InitializeLayout"
    Private Sub dgCuoc_Phat_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Phat.InitializeLayout
        dgCuoc_Phat.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_Phat.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_Phat.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_Phat_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_Phat"
    Private Sub dgCuoc_Phat_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_Phat.AfterRowUpdate
        If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Khoi_Luong").Text.Length <> 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_Phat As Integer
            Id_Cuoc_Phat = IIf(dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value Is System.DBNull.Value, 0, dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value)
            myCuoc_Phat.Cap_Nhat_Them(Id_Cuoc_Phat, dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
                                    dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Quoc_Te").Value, _
                                    dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Thoa_Thuan").Value, _
                                    dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Cach_Tinh").Value, _
                                    dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Khoi_Luong").Value, _
                                    dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Cuoc").Value, _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    myham_dung_chung.ConvertDateToInt(dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

    '#Region "dgCuoc_Phat_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Phat"
    '    Private Sub dgCuoc_Phat_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_Phat.AfterCellUpdate
    '        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
    '            AddNewRow(sender)
    '            If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Quoc_Te").Value Is System.DBNull.Value Then
    '                dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Quoc_Te").Value = False
    '            End If
    '            If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Thoa_Thuan").Value Is System.DBNull.Value Then
    '                dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Thoa_Thuan").Value = False
    '            End If
    '            If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
    '                dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Cach_Tinh").Value = False
    '            End If
    '        End If
    '    End Sub
    '#End Region

#Region "dgCuoc_Phat_Hanh_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Phat_Hanh"
    Private Sub dgCuoc_Phat_Hanh_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_Phat_Hanh.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgCuoc_Dv_Cong_Them_InitializeLayout"
    Private Sub dgCuoc_Dv_Cong_Them_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Dv_Cong_Them.InitializeLayout
        dgCuoc_Dv_Cong_Them.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_Dv_Cong_Them.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_Dv_Cong_Them.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu
        End With
    End Sub
#End Region

#Region "dgCuoc_Dv_Cong_Them_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_Dv_Cong_Them"
    Private Sub dgCuoc_Dv_Cong_Them_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_Dv_Cong_Them.AfterRowUpdate
        If dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Ma_Dich_Vu").Text.Length <> 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Dv_Cong_Them As Integer
            Id_Dv_Cong_Them = IIf(dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Id_Dv_Cong_Them").Value Is System.DBNull.Value, 0, dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Id_Dv_Cong_Them").Value)
            myCuoc_Dv_Cong_Them.Cap_Nhat_Them(Id_Dv_Cong_Them, dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Ma_Dich_Vu").Value, _
                                        dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Cuoc").Value, _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_Dv_Cong_Them_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Dv_Cong_Them"
    Private Sub dgCuoc_Dv_Cong_Them_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_Dv_Cong_Them.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgCuoc_PPXD_VAT_InitializeLayout"
    Private Sub dgCuoc_PPXD_VAT_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_PPXD_VAT.InitializeLayout
        dgCuoc_PPXD_VAT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_PPXD_VAT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub
#End Region

#Region "dgCuoc_PPXD_VAT_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_PPXD_VAT"
    Private Sub dgCuoc_PPXD_VAT_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_PPXD_VAT.AfterRowUpdate
        If dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("VAT").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_QT").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_TN_LT").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_TN_NT").Text.Length <> 0 Then
            Dim Id_Cuoc_PPXD_Vat As Integer
            Id_Cuoc_PPXD_Vat = IIf(dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Id_Cuoc_PPXD_Vat").Value Is System.DBNull.Value, 0, dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Id_Cuoc_PPXD_Vat").Value)
            myCuoc_PPXD_VAT.Cap_Nhat_Them(Id_Cuoc_PPXD_Vat, _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Value), _
                                        dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("VAT").Value, _
                                        dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_QT").Value, _
                                        dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_TN_LT").Value, _
                                        dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("PPXD_TN_NT").Value)
        End If
    End Sub
#End Region

#Region "dgCuoc_PPXD_VAT_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_PPXD_VAT"
    Private Sub dgCuoc_PPXD_VAT_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_PPXD_VAT.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgCuoc_Vung_Xa_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Vung_Xa"
    Private Sub dgCuoc_Vung_Xa_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_Vung_Xa.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgKhuyen_Mai_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgKhuyen_Mai"
    Private Sub dgKhuyen_Mai_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgKhuyen_Mai.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgKhuyen_Mai_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgKhuyen_Mai"
    Private Sub dgKhuyen_Mai_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgKhuyen_Mai.AfterExitEditMode
        Select Case dgKhuyen_Mai.ActiveCell.Column.Key
            Case "Ma_BC"
                If dgKhuyen_Mai.ActiveCell.Text.Length <> 6 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Mã BC không đúng quy cách, phải nhập đúng 6 ký tự !!!", "Thông báo")
                    myCell = dgKhuyen_Mai.ActiveCell
                    Exit Sub
                End If
            Case "Phan_Loai_BP"
                If dgKhuyen_Mai.ActiveCell.Text.Length <> 1 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Mã Phân loại bưu phẩm không đúng quy cách, phải nhập 1 ký tự !!!", "Thông báo")
                    myCell = dgKhuyen_Mai.ActiveCell
                    Exit Sub
                End If
            Case "He_So_Khuyen_Mai"
                If dgKhuyen_Mai.ActiveCell.Text.Length = 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Hệ số khuyến mại không đúng quy cách !!!", "Thông báo")
                    myCell = dgKhuyen_Mai.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text > dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Text And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgKhuyen_Mai.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Tu_Ngay").Text > dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Text And dgKhuyen_Mai.Rows(dgKhuyen_Mai.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgKhuyen_Mai.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgGiam_Gia_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgGiam_Gia"
    Private Sub dgGiam_Gia_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgGiam_Gia.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgGiam_Gia_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgGiam_Gia"
    Private Sub dgGiam_Gia_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgGiam_Gia.AfterRowUpdate
        If dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Phan_Loai_BP").Text.Length <> 0 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("He_So_Giam_Gia").Text.Length <> 0 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Giam_Gia As Integer
            Id_Giam_Gia = IIf(dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Id_Giam_Gia").Value Is System.DBNull.Value, 0, dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Id_Giam_Gia").Value)
            myGiam_Gia.Cap_Nhat_Them(Id_Giam_Gia, dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Value, _
                                    GBuu_Cuc_Khai_Thac, _
                                    dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Phan_Loai_BP").Value, _
                                    dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("He_So_Giam_Gia").Value, _
                                    myham_dung_chung.ConvertDateToInt(dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    myham_dung_chung.ConvertDateToInt(dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_Dv_Gia_Tang_InitializeLayout"
    Private Sub dgCuoc_Dv_Gia_Tang_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Dv_Gia_Tang.InitializeLayout
        dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_Dv_Gia_Tang.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_Dv_Gia_Tang.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_Dv_Gia_Tang_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Dv_Gia_Tang"
    Private Sub dgCuoc_Dv_Gia_Tang_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_Dv_Gia_Tang.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
            If dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
                dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cach_Tinh").Value = False
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_Dv_Gia_Tang_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_Dv_Gia_Tang"
    Private Sub dgCuoc_Dv_Gia_Tang_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_Dv_Gia_Tang.AfterRowUpdate
        If dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Ma_Dich_Vu").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cach_Tinh").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Khoi_Luong").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_Dv As Integer
            Id_Cuoc_Dv = IIf(dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Id_Cuoc_Dv").Value Is System.DBNull.Value, 0, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Id_Cuoc_Dv").Value)

            'myCuoc_Dv_Gia_Tang.Cap_Nhat_Them(Id_Cuoc_Dv, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Ma_Dich_Vu").Value, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Ma_Tinh_Nhan").Value, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Ma_Tinh_Tra").Value, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cach_Tinh").Value, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Khoi_Luong").Value, dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Cuoc").Value, myham_dung_chung.ConvertDateToInt(dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Value), myham_dung_chung.ConvertDateToInt(dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_DV_Khai_Gia_InitializeLayout"
    Private Sub dgCuoc_DV_Khai_Gia_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_DV_Khai_Gia.InitializeLayout
        dgCuoc_DV_Khai_Gia.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_DV_Khai_Gia.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_DV_Khai_Gia.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu
        End With
    End Sub
#End Region

#Region "dgCuoc_DV_Khai_Gia_AfterCellUpdate - Cập nhật , sửa dữ liệu đã tồn tại hàng trong DataGrid dgCuoc_Dv_Khai_Gia"
    Private Sub dgCuoc_DV_Khai_Gia_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_DV_Khai_Gia.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "dgCuoc_DV_Khai_Gia_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgCuoc_Dv_Khai_Gia"
    Private Sub dgCuoc_DV_Khai_Gia_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_DV_Khai_Gia.AfterRowUpdate
        If dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Ma_Dich_Vu").Text.Length <> 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Cuoc").Text.Length <> 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Cuoc_Toi_Thieu").Text.Length <> 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_Khai_Gia As Integer
            Id_Cuoc_Khai_Gia = IIf(dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Id_Cuoc_Khai_Gia").Value Is System.DBNull.Value, 0, dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Id_Cuoc_Khai_Gia").Value)
            myCuoc_Dv_Khai_Gia.Cap_Nhat_Them(Id_Cuoc_Khai_Gia, dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Ma_Dich_Vu").Value, _
                                        dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Cuoc").Value, _
                                        dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Cuoc_Toi_Thieu").Value, _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                        myham_dung_chung.ConvertDateToInt(dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_TCT_InitializeLayout"
    Private Sub dgCuoc_TCT_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_TCT.InitializeLayout
        dgCuoc_TCT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_TCT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_TCT.DisplayLayout
            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With

    End Sub
#End Region

    '#Region "dgTinh_AfterRowUpdate - Cập nhật thêm 1 hàng trong DataGrid dgTinh"
    '    Private Sub dgTinh_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgTinh.AfterRowUpdate
    '        If dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Text <> "" And dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length = 6 Then
    '            myTinh.Cap_Nhat_Them(dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ma_Tinh").Value, dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Ten_Tinh").Value, dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Khu_Vuc").Value, dgTinh.Rows(dgTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value)
    '        End If
    '    End Sub
    '#End Region

#Region "LostFocus - Load sự kiện này cho tất cả các DataGrid trong bảng danh mục Cước"
    'Private Sub dgCuoc_QT_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddPhan_Loai_BP.LostFocus, dgKhuyen_Mai.LostFocus, dgCuoc_Vung_Xa.LostFocus, dgCuoc_QT.LostFocus, ddKhuVucQT.LostFocus, dgNuoc.LostFocus, ddkhu_Vuc_TN.LostFocus, dgGiam_Gia.LostFocus, dgCuoc_TN_TT.LostFocus, dgCuoc_TN.LostFocus, dgTinh.LostFocus, dgCuoc_Phat.LostFocus, dgCuoc_Dv_Cong_Them.LostFocus, dgCuoc_Dv_Gia_Tang.LostFocus, dgCuoc_DV_Khai_Gia.LostFocus, dgCuoc_PPXD_VAT.LostFocus, dgCuoc_Dv_COD.LostFocus
    'myCell = Nothing
    'End Sub
#End Region

#Region "dgCuoc_TN_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_TN"
    Private Sub dgCuoc_TN_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_TN.AfterExitEditMode
        Select Case dgCuoc_TN.ActiveCell.Column.Key
            Case "Khu_Vuc"
                If dgCuoc_TN.ActiveCell.Text.Length = 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Khu vực này không đúng quy cách, phải nhập đúng mã số khu vực !!!", "Thông báo")
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
            Case "Phan_Loai_BP"
                If dgCuoc_TN.ActiveCell.Text.Length <> 1 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phân loại này không đúng quy cách, phải nhập đúng mã phân loại !!!", "Thông báo")
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
            Case "Cach_Tinh"
                If dgCuoc_TN.ActiveCell.Text.Length = 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa chọn Cách Tính !!!", "Thông báo")
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong"
                If dgCuoc_TN.ActiveCell.Text.Length = 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập khối lượng !!!", "Thông báo")
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_TN.ActiveCell.Text.Length = 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước !!!", "Thông báo")
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_QT.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TN.Rows(dgCuoc_TN.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_TN.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_TN_TT_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_TN_TT"
    Private Sub dgCuoc_TN_TT_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_TN_TT.AfterExitEditMode
        Select Case dgCuoc_TN_TT.ActiveCell.Column.Key
            Case "Khu_Vuc"
                If dgCuoc_TN_TT.ActiveCell.Text.Length = 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Khu vực này không đúng quy cách, phải nhập đúng mã số khu vực !!!", "Thông báo")
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Phan_Loai_BP"
                If dgCuoc_TN_TT.ActiveCell.Text.Length <> 1 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phân loại này không đúng quy cách, phải nhập đúng mã phân loại !!!", "Thông báo")
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Cach_Tinh"
                If dgCuoc_TN_TT.ActiveCell.Text.Length = 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa chọn Cách Tính !!!", "Thông báo")
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong"
                If dgCuoc_TN_TT.ActiveCell.Text.Length = 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập khối lượng !!!", "Thông báo")
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_TN_TT.ActiveCell.Text.Length = 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước !!!", "Thông báo")
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TN_TT.Rows(dgCuoc_TN_TT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_TN_TT.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgGiam_Gia_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgGiam_Gia"
    Private Sub dgGiam_Gia_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgGiam_Gia.AfterExitEditMode
        Select Case dgGiam_Gia.ActiveCell.Column.Key
            Case "Phan_Loai_BP"
                If dgGiam_Gia.ActiveCell.Text.Length <> 1 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phân loại BP không đúng quy cách, phải nhập đúng 1 ký tự !!!", "Thông báo")
                    myCell = dgGiam_Gia.ActiveCell
                    Exit Sub
                End If
            Case "He_So_Giam_Gia"
                If dgGiam_Gia.ActiveCell.Text.Length = 0 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập hệ số giảm giá !!!", "Thông báo")
                    myCell = dgGiam_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text > dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Text And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgGiam_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text > dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Text And dgGiam_Gia.Rows(dgGiam_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgGiam_Gia.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_Phat_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_Phat"
    Private Sub dgCuoc_Phat_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_Phat.AfterExitEditMode
        Select Case dgCuoc_Phat.ActiveCell.Column.Key
            Case "Phan_Loai_BP"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Phân loại BP không đúng quy cách, phải nhập đúng 1 ký tự !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Quoc_Te"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa lựa chọn giá trị Quốc Tế hay Trong nước !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Thoa_Thuan"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa lựa chọn giá trị Thoả thuận hay không Thoả thuận !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Cach_Tinh"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa lựa chọn giá trị Cách tính !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập khối lượng !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_Phat.ActiveCell.Text.Length = 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước phát !!!", "Thông báo")
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
                'Chuyển sang dòng tiếp theo
                If dgCuoc_Phat.ActiveRow.Index >= dgCuoc_Phat.Rows.Count - 1 Then
                    dgCuoc_Phat.Rows.Band.AddNew()
                End If
            Case "Den_Ngay"
                If dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Phat.Rows(dgCuoc_Phat.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Phat.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_Dv_Cong_Them_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_Dv_Cong_Them"
    Private Sub dgCuoc_Dv_Cong_Them_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_Dv_Cong_Them.AfterExitEditMode
        Select Case dgCuoc_Dv_Cong_Them.ActiveCell.Column.Key
            Case "Ma_Dich_Vu"
                If dgCuoc_Dv_Cong_Them.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mã dịch vụ cộng thêm !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Cong_Them.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_Dv_Cong_Them.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước dịch vụ cộng thêm !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Cong_Them.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Dv_Cong_Them.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Dv_Cong_Them.Rows(dgCuoc_Dv_Cong_Them.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Dv_Cong_Them.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_Dv_Gia_Tang_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_Dv_Gia_Tang"
    Private Sub dgCuoc_Dv_Gia_Tang_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_Dv_Gia_Tang.AfterExitEditMode
        Select Case dgCuoc_Dv_Gia_Tang.ActiveCell.Column.Key
            Case "Ma_Dich_Vu"
                If dgCuoc_Dv_Gia_Tang.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mã dịch vụ Gia tăng !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
            Case "Cach_Tinh"
                If dgCuoc_Dv_Gia_Tang.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa lựa chọn Cách tính dịch vụ Gia tăng (True hoặc False) !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong"
                If dgCuoc_Dv_Gia_Tang.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập khối lượng tính cước dịch vụ Gia tăng !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_Dv_Gia_Tang.ActiveCell.Text.Length = 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước dịch vụ Gia tăng !!!", "Thông báo")
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Dv_Gia_Tang.Rows(dgCuoc_Dv_Gia_Tang.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Dv_Gia_Tang.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_DV_Khai_Gia_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_Dv_Khai_Gia"
    Private Sub dgCuoc_DV_Khai_Gia_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_DV_Khai_Gia.AfterExitEditMode
        Select Case dgCuoc_DV_Khai_Gia.ActiveCell.Column.Key
            Case "Ma_Dich_Vu"
                If dgCuoc_DV_Khai_Gia.ActiveCell.Text.Length = 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mã dịch vụ Khai giá !!!", "Thông báo")
                    myCell = dgCuoc_DV_Khai_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_DV_Khai_Gia.ActiveCell.Text.Length = 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước dịch vụ Khai giá !!!", "Thông báo")
                    myCell = dgCuoc_DV_Khai_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc_Toi_Thieu"
                If dgCuoc_DV_Khai_Gia.ActiveCell.Text.Length = 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước tối thiểu dịch vụ Khai giá !!!", "Thông báo")
                    myCell = dgCuoc_DV_Khai_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_DV_Khai_Gia.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_DV_Khai_Gia.Rows(dgCuoc_DV_Khai_Gia.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_DV_Khai_Gia.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_PPXD_VAT_AfterExitEditMode - Kiểm tra dữ liệu nhập trong DataGrid dgCuoc_PPXD_VAT"
    Private Sub dgCuoc_PPXD_VAT_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCuoc_PPXD_VAT.AfterExitEditMode
        Select Case dgCuoc_PPXD_VAT.ActiveCell.Column.Key
            Case "Tu_Ngay"
                If dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
            Case "VAT"
                If dgCuoc_PPXD_VAT.ActiveCell.Text.Length = 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mức thuế VAT tính cước Phụ phí xăng dầu !!!", "Thông báo")
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
            Case "PPXD_QT"
                If dgCuoc_PPXD_VAT.ActiveCell.Text.Length = 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập PPXD QT !!!", "Thông báo")
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
            Case "PPXD_TN_LT"
                If dgCuoc_PPXD_VAT.ActiveCell.Text.Length = 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập PPXD Trong nước Liên tỉnh !!!", "Thông báo")
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
            Case "PPXD_TN_NT"
                If dgCuoc_PPXD_VAT.ActiveCell.Text.Length = 0 And dgCuoc_PPXD_VAT.Rows(dgCuoc_PPXD_VAT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập PPXD Trong nước Nội tỉnh !!!", "Thông báo")
                    myCell = dgCuoc_PPXD_VAT.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "Rd_Pc_CheckedChanged - sự kiện khi click vao option radiobutton rd_PC"
    Private Sub Rd_Pc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rd_Pc.CheckedChanged
        If Rd_Pc.Checked = True Then
            'tab ma_nuoc ---------------
            dgTmp_Nuoc.Visible = False
            dgNuoc.Visible = True

            dgTmp_Cuoc_QT.Visible = False
            dgCuoc_QT.Visible = True

            dgTmp_Cuoc_Vung_Xa.Visible = False
            dgCuoc_Vung_Xa.Visible = True

            dgTmp_Khuyen_Mai.Visible = False
            dgKhuyen_Mai.Visible = True

            'tab ma_tinh ---------------
            dgTmp_Tinh.Visible = False
            dgTinh.Visible = True

            dgTmp_Cuoc_TN.Visible = False
            dgCuoc_TN.Visible = True

            dgTmp_Cuoc_TN_TT.Visible = False
            dgCuoc_TN_TT.Visible = False

            dgTmp_Giam_Gia.Visible = False
            dgGiam_Gia.Visible = True

            'tab Cuoc_Phat ---------------
            dgTmp_Cuoc_Phat.Visible = False
            dgCuoc_Phat.Visible = True

            'tab Cuoc_Phat ---------------
            dgTmp_Cuoc_Phat_Hanh.Visible = False
            dgCuoc_Phat_Hanh.Visible = True

            'tab Cuoc_Dv_Cong_Them ---------------
            dgTmp_Cuoc_Dv_Cong_Them.Visible = False
            dgCuoc_Dv_Cong_Them.Visible = True

            'tab Cuoc_Dv_Gia_Tang ---------------
            dgTmp_Cuoc_Dv_Gia_Tang.Visible = False
            dgCuoc_Dv_Gia_Tang.Visible = True

            'tab Cuoc_Dv_Khai_Gia ---------------
            dgTmp_Cuoc_Dv_Khai_Gia.Visible = False
            dgCuoc_DV_Khai_Gia.Visible = True

            'tab Cuoc_PPXD_VAT ---------------
            dgTmp_Cuoc_PPXD_VAT.Visible = False
            dgCuoc_PPXD_VAT.Visible = True

        ElseIf Rd_May_Chu.Checked = True Then
            'tab ma_nuoc ---------------
            dgTmp_Nuoc.Visible = True
            dgNuoc.Visible = False

            dgTmp_Cuoc_QT.Visible = True
            dgCuoc_QT.Visible = False

            dgTmp_Cuoc_Vung_Xa.Visible = True
            dgCuoc_Vung_Xa.Visible = False

            dgTmp_Khuyen_Mai.Visible = True
            dgKhuyen_Mai.Visible = False

            'tab ma_tinh ---------------
            DataGridTmp_Tinh()

            dgTmp_Tinh.Visible = True
            dgTinh.Visible = False

            dgTmp_Cuoc_TN.Visible = True
            dgCuoc_TN.Visible = False

            dgTmp_Cuoc_TN_TT.Visible = False
            dgCuoc_TN_TT.Visible = False

            dgTmp_Giam_Gia.Visible = True
            dgGiam_Gia.Visible = False

            'tab Cuoc_Phat ---------------
            dgTmp_Cuoc_Phat.Visible = True
            dgCuoc_Phat.Visible = False

            'tab Cuoc_Phat_Hanh ---------------
            dgTmp_Cuoc_Phat_Hanh.Visible = True
            dgCuoc_Phat_Hanh.Visible = False

            'tab Cuoc_Dv_Cong_Them ---------------
            dgTmp_Cuoc_Dv_Cong_Them.Visible = True
            dgCuoc_Dv_Cong_Them.Visible = False

            'tab Cuoc_Dv_Gia_Tang ---------------
            dgTmp_Cuoc_Dv_Gia_Tang.Visible = True
            dgCuoc_Dv_Gia_Tang.Visible = False

            'tab Cuoc_Dv_Khai_Gia ---------------
            dgTmp_Cuoc_Dv_Khai_Gia.Visible = True
            dgCuoc_DV_Khai_Gia.Visible = False

            'tab Cuoc_PPXD_VAT ---------------
            dgTmp_Cuoc_PPXD_VAT.Visible = True
            dgCuoc_PPXD_VAT.Visible = False
        End If
    End Sub
#End Region

#Region "dgTmp_Nuoc_InitializeLayout"
    Private Sub dgTmp_Nuoc_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Nuoc.InitializeLayout
        dgTmp_Nuoc.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Nuoc.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
    End Sub
#End Region

#Region "dgTmp_Nuoc_AfterRowActivate - Sự kiện khi click chuột vào 1 dòng trong DataGrid dgTmp_Nuoc"
    Private Sub dgTmp_Nuoc_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTmp_Nuoc.AfterRowActivate
        If dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length <> 0 Or dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.Length = 2 And dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text.Length <> 0 Then
            dgTmp_Cuoc_QT.DataSource = myTmp_Cuoc_QT.Lay_Boi_Ma_Nuoc(dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value)
            dgTmp_Cuoc_QT.DataBind()
            dgTmp_Cuoc_QT.Refresh()
            dgTmp_Cuoc_Vung_Xa.DataSource = myTmp_Cuoc_Vung_Xa.Lay_Boi_Ma_Nuoc(dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value)
            dgTmp_Cuoc_Vung_Xa.DataBind()
            dgTmp_Cuoc_Vung_Xa.Refresh()
            dgTmp_Khuyen_Mai.DataSource = myTmp_Khuyen_Mai.Lay_Boi_Ma_Nuoc(dgTmp_Nuoc.Rows(dgTmp_Nuoc.ActiveRow.Index).Cells("Ma_Nuoc").Value)
            dgTmp_Khuyen_Mai.DataBind()
            dgTmp_Khuyen_Mai.Refresh()
        End If
    End Sub
#End Region

#Region "dgTmp_Tinh_AfterRowActivate - Sự kiện khi click chuột vào 1 dòng trong DataGrid dgTmp_Tinh"
    Private Sub dgTmp_Tinh_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTmp_Tinh.AfterRowActivate
        If dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length <> 0 Or dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length = 6 Then 'loai bo truong hop ma_tinh la null hoac khong dung dinh dang
            If dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Thoa_Thuan").Value = False And Rd_May_Chu.Checked = True Then
                dgTmp_Cuoc_TN.Visible = True
                dgCuoc_TN.Visible = False
                dgTmp_Cuoc_TN_TT.Visible = False
                dgCuoc_TN_TT.Visible = False
                dgTmp_Cuoc_TN.DataSource = myTmp_Cuoc_TN.Lay_Boi_Khu_Vuc(dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Khu_Vuc").Value)
                dgTmp_Cuoc_TN.DataBind()
                dgTmp_Cuoc_TN.Refresh()
            Else
                dgTmp_Cuoc_TN_TT.Visible = True
                dgCuoc_TN_TT.Visible = False
                dgTmp_Cuoc_TN.Visible = False
                dgCuoc_TN.Visible = False
                dgTmp_Cuoc_TN_TT.DataSource = myTmp_Cuoc_TN_TT.Lay_Boi_Khu_Vuc(dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Khu_Vuc").Value)
                dgTmp_Cuoc_TN_TT.DataBind()
                dgTmp_Cuoc_TN_TT.Refresh()
            End If
            dgTmp_Giam_Gia.DataSource = myTmp_Giam_Gia.Lay_Boi_Ma_Tinh(dgTmp_Tinh.Rows(dgTmp_Tinh.ActiveRow.Index).Cells("Ma_Tinh").Value, GBuu_Cuc_Khai_Thac)
            dgTmp_Giam_Gia.DataBind()
            dgTmp_Giam_Gia.Refresh()
        End If
    End Sub
#End Region

#Region "dgTmp_Tinh_InitializeLayout"
    Private Sub dgTmp_Tinh_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Tinh.InitializeLayout
        dgTmp_Tinh.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Tinh.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Tinh.DisplayLayout
            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_TN_InitializeLayout"
    Private Sub dgTmp_Cuoc_TN_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_TN.InitializeLayout
        dgTmp_Cuoc_TN.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_TN.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_TN.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_TN_TT_InitializeLayout"
    Private Sub dgTmp_Cuoc_TN_TT_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_TN_TT.InitializeLayout
        dgTmp_Cuoc_TN_TT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_TN_TT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_TN_TT.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Khu_Vuc").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Khu_Vuc").ValueList = ddkhu_Vuc_TN

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_QT_InitializeLayout"
    Private Sub dgTmp_Cuoc_QT_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_QT.InitializeLayout
        dgTmp_Cuoc_QT.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_QT.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_QT.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTmp_Khuyen_Mai_InitializeLayout"
    Private Sub dgTmp_Khuyen_Mai_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Khuyen_Mai.InitializeLayout
        dgTmp_Khuyen_Mai.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Khuyen_Mai.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Khuyen_Mai.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP
        End With
    End Sub
#End Region

#Region "dgTmp_Giam_Gia_InitializeLayout"
    Private Sub dgTmp_Giam_Gia_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Giam_Gia.InitializeLayout
        dgTmp_Giam_Gia.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Giam_Gia.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Giam_Gia.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_Phat_InitializeLayout"
    Private Sub dgTmp_Cuoc_Phat_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_Phat.InitializeLayout
        dgTmp_Cuoc_Phat.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_Phat.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_Phat.DisplayLayout
            .Bands(0).Columns("Phan_Loai_BP").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Phan_Loai_BP").ValueList = ddPhan_Loai_BP

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_Dv_Cong_Them_InitializeLayout"
    Private Sub dgTmp_Cuoc_Dv_Cong_Them_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_Dv_Cong_Them.InitializeLayout
        dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_Dv_Cong_Them.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_Dv_Gia_Tang_InitializeLayout"
    Private Sub dgTmp_Cuoc_Dv_Gia_Tang_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_Dv_Gia_Tang.InitializeLayout
        dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_Dv_Gia_Tang.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu

            .Bands(0).Columns("Cach_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Cach_Tinh").ValueList = ddCach_Tinh
        End With
    End Sub
#End Region

#Region "dgTmp_Cuoc_Dv_Khai_Gia_InitializeLayout"
    Private Sub dgTmp_Cuoc_Dv_Khai_Gia_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTmp_Cuoc_Dv_Khai_Gia.InitializeLayout
        dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgTmp_Cuoc_Dv_Khai_Gia.DisplayLayout
            .Bands(0).Columns("Ma_Dich_Vu").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Dich_Vu").ValueList = dgdich_Vu
        End With
    End Sub
#End Region

#Region "BtnLay_Danh_Muc_Click - Sự kiện khi clịck vào button lấy danh mục máy chủ"
    Private Sub BtnLay_Danh_Muc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLay_Danh_Muc.Click
        If UltraTabPageControl1.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục các bảng Trong Tab MÃ NƯỚC từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myNuoc.Xoa_Tat_Ca()
                myNuoc.Lay_Tat_Ca_Tu_Tmp()
                dgNuoc.Refresh()
                myCuoc_QT.Xoa_Tat_Ca()
                myCuoc_QT.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_QT.Refresh()
                myCuoc_Vung_Xa.Xoa_Tat_Ca()
                myCuoc_Vung_Xa.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_Vung_Xa.Refresh()
                myKhuyen_Mai.Xoa_Tat_Ca()
                myKhuyen_Mai.Lay_Tat_Ca_Tu_Tmp()
                dgKhuyen_Mai.Refresh()
                CMessageBox.Show("Đã lấy danh mục các bảng trong Tab MÃ NƯỚC thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl2.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục các bảng Trong Tab MÃ TỈNH từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myTinh.Xoa_Tat_Ca()
                myTinh.Lay_Tat_Ca_Tu_Tmp()
                dgTinh.Refresh()
                myCuoc_TN.Xoa_Tat_Ca()
                myCuoc_TN.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_TN.Refresh()
                myCuoc_TN_TT.Xoa_Tat_Ca()
                myCuoc_TN_TT.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_TN_TT.Refresh()
                myGiam_Gia.Xoa_Tat_Ca()
                myGiam_Gia.Lay_Tat_Ca_Tu_Tmp()
                dgGiam_Gia.Refresh()
                CMessageBox.Show("Đã lấy danh mục các bảng trong Tab MÃ TỈNH thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl3.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC PHÁT HÀNH từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_Phat
                myCuoc_Phat_Hanh.Xoa_Tat_Ca()
                myCuoc_Phat_Hanh.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_Phat_Hanh.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC PHÁT Hành thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl4.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC PHÁT từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_Phat
                myCuoc_Phat.Xoa_Tat_Ca()
                myCuoc_Phat.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_Phat.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC PHÁT thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl5.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC DV CỘNG THÊM từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_Dv_Cong_Them
                myCuoc_Dv_Cong_Them.Xoa_Tat_Ca()
                myCuoc_Dv_Cong_Them.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_Dv_Cong_Them.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC DV CỘNG THÊM thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl6.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC DV GIA TĂNG từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_Dv_Gia_Tang
                'myCuoc_Dv_Gia_Tang.Xoa_Tat_Ca()
                'myCuoc_Dv_Gia_Tang.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_Dv_Gia_Tang.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC DV GIA TĂNG thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl7.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC DV KHAI GIÁ từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_Dv_Khai_Gia
                myCuoc_Dv_Khai_Gia.Xoa_Tat_Ca()
                myCuoc_Dv_Khai_Gia.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_DV_Khai_Gia.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC DV KHAI GIÁ thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If UltraTabPageControl8.Tab.Active = True Then
            If MessageBox.Show("Bạn có thực sự muốn lấy danh mục bảng CƯỚC PPXD VAT từ máy chủ xuống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'xoá và lấy dữ liệu bảng Cuoc_PPXD_VAT
                myCuoc_PPXD_VAT.Xoa_Tat_Ca()
                myCuoc_PPXD_VAT.Lay_Tat_Ca_Tu_Tmp()
                dgCuoc_PPXD_VAT.Refresh()
                CMessageBox.Show("Đã lấy danh mục CƯỚC PPXD VAT thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_TCT_AfterCellUpdate"
    Private Sub dgCuoc_TCT_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgCuoc_TCT.AfterCellUpdate
        If e.Cell.Row.Cells("Tu_Ngay").IsActiveCell Then
            AddNewRow(sender)
            If dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cach_Tinh").Value Is System.DBNull.Value Then
                dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cach_Tinh").Value = False
            End If
        End If
    End Sub
#End Region

#Region "dgCuoc_TCT_AfterRowUpdate"
    Private Sub dgCuoc_TCT_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_TCT.AfterRowUpdate
        If dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cach_Tinh").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Nac_Gui").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cuoc_Toi_Thieu").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Phan_Tram_Cuoc").Text.Length <> 0 Then
            Dim Id_Cuoc_TCT As Integer
            Id_Cuoc_TCT = IIf(dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Id_Cuoc_TCT").Value Is System.DBNull.Value, 0, dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Id_Cuoc_TCT").Value)
            myCuoc_TCT.Cap_Nhat_Them(Id_Cuoc_TCT, dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cach_Tinh").Value, _
                                    dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Nac_Gui").Value, _
                                    dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Phan_Tram_Cuoc").Value, _
                                    dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cuoc_Toi_Thieu").Value, _
                                    dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Cuoc").Value, _
                                    Ham_Dung_Chung.ConvertDateToInt(dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    Ham_Dung_Chung.ConvertDateToInt(dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_TCT_AfterExitEditMode"
    Private Sub dgCuoc_TCT_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCuoc_TCT.AfterExitEditMode
        Select Case dgCuoc_TCT.ActiveCell.Column.Key
            Case "Cach_Tinh"
                If myCuoc_TCT.Kiem_Tra_Cach_Tinh() > 0 Then
                    CMessageBox.Show("Cách tính chỉ tồn tại duy nhất 1 giá trị tính đến (True) !!!", "Thông báo")
                    Exit Sub
                End If
                If dgCuoc_TCT.ActiveCell.Text.Length = 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập cách tính cước dịch vụ COD !!!", "Thông báo")
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Nac_Gui"
                If dgCuoc_TCT.ActiveCell.Text.Length = 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Nấc gửi tính cước dịch vụ COD !!!", "Thông báo")
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Phan_Tram_Cuoc"
                If dgCuoc_TCT.ActiveCell.Text.Length = 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Phần trăm cước để tính dịch vụ COD !!!", "Thông báo")
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc"
                If dgCuoc_TCT.ActiveCell.Text.Length = 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mức cước để tính dịch vụ COD !!!", "Thông báo")
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc_Toi_Thieu"
                If dgCuoc_TCT.ActiveCell.Text.Length = 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập mức cước tối thiểu để tính dịch vụ COD !!!", "Thông báo")
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_TCT.Rows(dgCuoc_TCT.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_TCT.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_Phat_Hanh_AfterRowUpdate"
    Private Sub dgCuoc_Phat_Hanh_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgCuoc_Phat_Hanh.AfterRowUpdate
        If dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Ma_Tinh").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_NT").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_LT").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_QT").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
            Dim Id_Cuoc_Phat As Integer
            Id_Cuoc_Phat = IIf(dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value Is System.DBNull.Value, 0, dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Id_Cuoc_Phat").Value)
            myCuoc_Phat_Hanh.Cap_Nhat_Them(Id_Cuoc_Phat, _
                                    dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Ma_Tinh").Text, _
                                    dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_NT").Value, _
                                    dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_LT").Value, _
                                    dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Cuoc_QT").Value, _
                                    Ham_Dung_Chung.ConvertDateToInt(dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Value), _
                                    Ham_Dung_Chung.ConvertDateToInt(dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Value))
        End If
    End Sub
#End Region

#Region "dgCuoc_Phat_Hanh_AfterExitEditMode"
    Private Sub dgCuoc_Phat_Hanh_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCuoc_Phat_Hanh.AfterExitEditMode
        Select Case dgCuoc_Phat_Hanh.ActiveCell.Column.Key
            Case "Ma_Tinh"
                If dgCuoc_Phat_Hanh.ActiveCell.Text.Length = 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước phát !!!", "Thông báo")
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc_NT"
                If dgCuoc_Phat_Hanh.ActiveCell.Text.Length = 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước phát !!!", "Thông báo")
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc_LT"
                If dgCuoc_Phat_Hanh.ActiveCell.Text.Length = 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước phát !!!", "Thông báo")
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
            Case "Cuoc_QT"
                If dgCuoc_Phat_Hanh.ActiveCell.Text.Length = 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Bạn chưa nhập Cước phát !!!", "Thông báo")
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
            Case "Tu_Ngay"
                If dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text.Length <> 0 And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
            Case "Den_Ngay"
                If dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Tu_Ngay").Text > dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Text And dgCuoc_Phat_Hanh.Rows(dgCuoc_Phat_Hanh.ActiveRow.Index).Cells("Den_Ngay").Text.Length <> 0 Then
                    CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    myCell = dgCuoc_Phat_Hanh.ActiveCell
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

#Region "dgCuoc_Phat_Hanh_InitializeLayout"
    Private Sub dgCuoc_Phat_Hanh_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgCuoc_Phat_Hanh.InitializeLayout
        dgCuoc_Phat_Hanh.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
        dgCuoc_Phat_Hanh.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
        With dgCuoc_Phat_Hanh.DisplayLayout
            .Bands(0).Columns("Ma_Tinh").Style = ColumnStyle.DropDownList
            .Bands(0).Columns("Ma_Tinh").ValueList = ddMa_Tinh
        End With
    End Sub
#End Region

#Region "dgCuoc_TCT_BeforeCellListDropDown"
    Private Sub dgCuoc_TCT_BeforeCellListDropDown(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableCellEventArgs) Handles dgCuoc_TCT.BeforeCellListDropDown
        Select Case dgCuoc_TCT.ActiveCell.Column.Key
            Case "Cach_Tinh"
                If myCuoc_TCT.Kiem_Tra_Cach_Tinh() > 0 Then
                    CMessageBox.Show("Cách tính chỉ tồn tại duy nhất 1 giá trị tính đến (True) !!!", "Thông báo")
                    'dgCuoc_TCT.ActiveCell.Selected = True
                    Exit Sub
                End If
        End Select
    End Sub
#End Region

    Private Sub btntest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntest.Click
        Dim frm As New FrmTruyenDanhMuc
        frm.ShowDialog()
    End Sub
End Class
#End Region
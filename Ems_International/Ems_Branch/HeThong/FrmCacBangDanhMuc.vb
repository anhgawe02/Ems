Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmCacBangDanhMuc
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
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDuongthuden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgDuongthudi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgLydo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgMaca As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTygia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgXuly As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddPhanLoai As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgMabckt As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents grbLuaChon As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDmMayChu As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDmChinh As System.Windows.Forms.RadioButton
    Friend WithEvents btnLayDanhMuc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Tmp_dgTygia As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgMaca As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgLydo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgXuly As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgMabckt As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgDuongthudi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Tmp_dgDuongthuden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddMaCa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents btnTruyen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgKhachhang As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgQuay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgNoiBo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddKenhTruyen As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDmMaBC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddMaBc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDichVu As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddPhanLoaiDV As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgQuanLy As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddQuanLy As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgMaNuoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgMaTinh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents nubEditor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents dgToaDoIn As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblToaDoIn As System.Windows.Forms.Label
    Friend WithEvents cbKhoGiay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ddMaTinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMaBcKt As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMaDonVi As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDanhMucDuongBay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddDuongThu As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddDM_IPMC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource5 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource6 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource7 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource8 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddPhan_Loai_Duong_Thu_Noi_Tinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgDuongThuDiNoiTinh As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddBuuCucKhaiThac_NoiTinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents cbMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ddPhan_Loai_Ma_Bc_Khai_Thac As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl20 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddMa_Bc_Qua_Giang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource9 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource10 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraTabPageControl21 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ddSo_Chang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgDanhMucDuongBayTongHop As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgDot_Bay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents optSu_Dung As System.Windows.Forms.RadioButton
    Friend WithEvents optKhong_Su_Dung As System.Windows.Forms.RadioButton
    Friend WithEvents optTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents btnLoad As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgDanhMucChuyenBay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddSan_Bay As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Nuoc_Chuyen_Bay As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddQuy_Luat As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraTabPageControl22 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDuong_Thu_Buu_Ta_Noi_Bo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl23 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgDanhMucDuongBayDen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraDataSource11 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddDuongThu2 As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddSo_Chang2 As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Bc_Qua_Giang2 As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddDM_IPMC2 As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource12 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource13 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource14 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource15 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource16 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Den", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Dung")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Den", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Truyen")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Dung")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_Truyen")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Buu_Ta_Noi_Bo", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_Duong_Thu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai_Duong_Thu_Noi_Tinh", -1)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di_Noi_Tinh", -1)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_Duong_Thu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai_Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OutBout")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Khai_Thac", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Don_Vi", -1)
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Don_Vi")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Quan_Ly", -1)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quan_Ly")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Quan_Ly")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand20 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_BC", -1)
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Cha")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cap_Buu_Cuc")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quan_Ly")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nc")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand21 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_do", -1)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do_EN")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Xu_Ly", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand22 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_do", -1)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do_EN")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Xu_Ly")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand23 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Xu_Ly", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly_EN", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand24 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Xu_Ly", -1)
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly_EN")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand25 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kho_Giay", -1)
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kho_Giay")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand26 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Toa_Do_In", -1)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Toa_Do")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kho_Giay")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Doi_Tuong")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Doi_Tuong_VN")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Toa_Do_Top", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Toa_Do_Left")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand27 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Buc_Cuc_Khai_Thac", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand28 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand29 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Tu")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand30 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Ca", -1)
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca_Khai_Thac")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ca")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand31 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ty_Gia", -1)
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ty_Gia", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand32 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ty_Gia", -1)
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ty_Gia")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand33 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Khach_Hang", -1)
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Khach_Hang", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khoi_Tao")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Ket_Thuc")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fax")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_So_Thue")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vat")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khach_Hang_Toan_Quoc")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand34 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Quay_Giao_Dich", -1)
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Quay")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand35 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kenh_Truyen", -1)
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kenh_Truyen")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Kenh_Truyen")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand36 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thong_Tin_Noi_Bo", -1)
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Noi_Bo")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_E1_Max", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Ngay_E1_Duoc_Trung")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Ngay_Cho_Phep_Nhap_Bao_Phat")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhap_Bao_Phat_Khong_E1")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kenh_Truyen")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Tien_E1_Max")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_May_Center")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("URL_Tra_Cuu")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phien_Ban")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui_Paypost")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui_Paypost")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui_Paypost")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH_Gui_Paypost")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand37 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai", -1)
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand38 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dich_Vu", -1)
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand39 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Quan_Ly", -1)
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quan_Ly", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Quan_Ly")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand40 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand41 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCacBangDanhMuc))
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand42 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("So_Chang", -1)
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chang")
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand43 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Qua_Giang", -1)
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc")
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Bc")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand44 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Buu_Cuc")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand45 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Duong_thu", -1)
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_chu")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Duong_Thu")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Khai_Thac")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC_chu")
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand46 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Duong_Bay", -1)
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Bay")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Nhan")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_van_chuyen")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_hieu")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Noi_GUI")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Noi_NHAN", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_GUI")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_NHAN")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_KHOI_HANH")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_DEN")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("QUA_NGAY")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("QUA_GIANG")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SO_CHANG")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_DUNG")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_QUA_GIANG")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand47 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Quy_Luat", -1)
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quy_Luat")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Quy_Luat")
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand48 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand49 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("San_Bay", -1)
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_San_Bay")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand50 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Chuyen_Bay", -1)
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_So_Hieu")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Hang_Hang_Khong")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Xuat_Phat")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("San_Bay_Xuat_Phat")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Xuat_Phat")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Den")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("San_Bay_Den")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Den")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Qua_Ngay")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Quy_Luat")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_2")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_3")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_4")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_5")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_6")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_7")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chu_Nhat")
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand51 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Duong_Bay_Chi_Tiet", -1)
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Bay_Chi_Tiet")
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand52 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Duong_Bay_Chi_Tiet", -1)
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Bay_Chi_Tiet")
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand53 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("So_Chang", -1)
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chang")
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand54 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Bc_Qua_Giang", -1)
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Bc")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand55 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand56 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Duong_thu", -1)
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_chu")
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Duong_Thu")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Khai_Thac")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC_chu")
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand57 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Duong_Bay_Den", -1)
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Bay")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Gui")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_van_chuyen")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_hieu")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Noi_GUI")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Noi_NHAN", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_GUI")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC_NHAN")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_KHOI_HANH")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GIO_DEN")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("QUA_NGAY")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("QUA_GIANG")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SO_CHANG")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SU_DUNG")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MA_BC_QUA_GIANG")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IPMC")
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Gui")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SO_CHANG")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_DUNG")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_BC_QUA_GIANG")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Gui")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SO_CHANG")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_DUNG")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_BC_QUA_GIANG")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Gui")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SO_CHANG")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_DUNG")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_BC_QUA_GIANG")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Nhan")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Nhan")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Hang_van_chuyen")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Hang_van_chuyen")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab21 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab23 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Toa_Do_In")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Toa_Do")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kho_Giay")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Doi_Tuong")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Toa_Do_Top")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Toa_Do_Left")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Duong_Thu")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Khai_Thac")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Phan_Loai")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ip_Truyen")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tinh_Cong_Phat")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 8")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 9")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Buu_Cuc")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_BC_chu")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Buu_Cuc")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Bc")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Bay")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Gui")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_van_chuyen")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("So_hieu")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_GUI")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Noi_NHAN")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_GUI")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BC_NHAN")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_KHOI_HANH")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GIO_DEN")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_NGAY")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("QUA_GIANG")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SO_CHANG")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SU_DUNG")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MA_BC_QUA_GIANG")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IPMC")
        Me.nubEditor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddPhanLoai = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDuongthuden = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgDuongthuden = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnTruyen = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddMaBc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDuongthudi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgDuongthudi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl22 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddBuuCucKhaiThac_NoiTinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDuongThuDiNoiTinh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgMabckt = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgMabckt = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.ddMaDonVi = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMaTinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddQuanLy = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDmMaBC = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgLydo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgLydo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgXuly = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgXuly = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cbKhoGiay = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.lblToaDoIn = New System.Windows.Forms.Label
        Me.dgToaDoIn = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddMaBcKt = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMaCa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgMaca = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgMaca = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgTygia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Tmp_dgTygia = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgKhachhang = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgQuay = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddKenhTruyen = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgNoiBo = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddPhanLoaiDV = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDichVu = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgQuanLy = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgMaNuoc = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgMaTinh = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnLoad = New Infragistics.Win.Misc.UltraButton
        Me.optTat_Ca = New System.Windows.Forms.RadioButton
        Me.optKhong_Su_Dung = New System.Windows.Forms.RadioButton
        Me.optSu_Dung = New System.Windows.Forms.RadioButton
        Me.ddSo_Chang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_Bc_Qua_Giang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource10 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddDM_IPMC = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource6 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddDuongThu = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.dgDanhMucDuongBay = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddQuy_Luat = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_Nuoc_Chuyen_Bay = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddSan_Bay = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgDanhMucChuyenBay = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl20 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgDanhMucDuongBayTongHop = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl21 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.dgDot_Bay = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl23 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ddSo_Chang2 = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_Bc_Qua_Giang2 = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource13 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddDM_IPMC2 = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddDuongThu2 = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource14 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.dgDanhMucDuongBayDen = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource16 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource12 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource11 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource8 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource7 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraGrid = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.grbLuaChon = New System.Windows.Forms.GroupBox
        Me.rdbDmChinh = New System.Windows.Forms.RadioButton
        Me.rdbDmMayChu = New System.Windows.Forms.RadioButton
        Me.btnLayDanhMuc = New Infragistics.Win.Misc.UltraButton
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource5 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource9 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource15 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        CType(Me.nubEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDuongthuden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgDuongthuden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDuongthudi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgDuongthudi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl22.SuspendLayout()
        CType(Me.dgDuong_Thu_Buu_Ta_Noi_Bo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.ddBuuCucKhaiThac_NoiTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhan_Loai_Duong_Thu_Noi_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDuongThuDiNoiTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ddPhan_Loai_Ma_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMabckt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgMabckt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaDonVi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddQuanLy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDmMaBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.dgLydo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgLydo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.dgXuly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgXuly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.cbKhoGiay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgToaDoIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.ddMaBcKt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaCa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgMaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.dgTygia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tmp_dgTygia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.dgKhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.dgQuay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.ddKenhTruyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNoiBo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.ddPhanLoaiDV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDichVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl13.SuspendLayout()
        CType(Me.dgQuanLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl14.SuspendLayout()
        CType(Me.dgMaNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl15.SuspendLayout()
        CType(Me.dgMaTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.ddSo_Chang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Bc_Qua_Giang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDM_IPMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDuongThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanhMucDuongBay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl19.SuspendLayout()
        CType(Me.ddQuy_Luat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Nuoc_Chuyen_Bay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSan_Bay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanhMucChuyenBay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl20.SuspendLayout()
        CType(Me.dgDanhMucDuongBayTongHop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl21.SuspendLayout()
        CType(Me.dgDot_Bay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl23.SuspendLayout()
        CType(Me.ddSo_Chang2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Bc_Qua_Giang2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDM_IPMC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDuongThu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDanhMucDuongBayDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGrid.SuspendLayout()
        Me.grbLuaChon.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nubEditor
        '
        Me.nubEditor.Location = New System.Drawing.Point(496, 120)
        Me.nubEditor.MaskInput = "nnnn"
        Me.nubEditor.MinValue = 0
        Me.nubEditor.Name = "nubEditor"
        Me.nubEditor.Size = New System.Drawing.Size(100, 23)
        Me.nubEditor.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.nubEditor.TabIndex = 9
        Me.nubEditor.Visible = False
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(392, 104)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 23)
        Me.dtpNgayDinhDang.TabIndex = 55
        Me.dtpNgayDinhDang.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.ddPhanLoai)
        Me.UltraTabPageControl4.Controls.Add(Me.dgDuongthuden)
        Me.UltraTabPageControl4.Controls.Add(Me.Tmp_dgDuongthuden)
        Me.UltraTabPageControl4.Controls.Add(Me.btnTruyen)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(790, 519)
        '
        'ddPhanLoai
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhanLoai.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Tên phân loại"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ddPhanLoai.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhanLoai.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.ddPhanLoai.DisplayMember = "Ten_Phan_Loai"
        Me.ddPhanLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhanLoai.Location = New System.Drawing.Point(96, 96)
        Me.ddPhanLoai.Name = "ddPhanLoai"
        Me.ddPhanLoai.Size = New System.Drawing.Size(104, 128)
        Me.ddPhanLoai.TabIndex = 41
        Me.ddPhanLoai.ValueMember = "Id_Phan_Loai"
        Me.ddPhanLoai.Visible = False
        '
        'dgDuongthuden
        '
        Me.dgDuongthuden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgDuongthuden.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDuongthuden.DisplayLayout.Appearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn3.MaskInput = ""
        UltraGridColumn4.Header.Caption = "Mã BC"
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.MaskInput = "999999"
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(94, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Tên Đường Thư"
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Mã BC KT"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Phân Loại"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(102, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.Caption = "Tính Doanh Thu"
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(99, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Tính Công Phát"
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Được Truyền"
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Sử dụng"
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn12.Header.Caption = "Chuyển Tiếp"
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgDuongthuden.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgDuongthuden.DisplayLayout.InterBandSpacing = 10
        Me.dgDuongthuden.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.dgDuongthuden.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.dgDuongthuden.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDuongthuden.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.dgDuongthuden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongthuden.DisplayLayout.Override.RowAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDuongthuden.DisplayLayout.Override.RowSelectorAppearance = Appearance7
        Me.dgDuongthuden.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDuongthuden.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.dgDuongthuden.DisplayLayout.Override.SelectedRowAppearance = Appearance8
        Me.dgDuongthuden.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongthuden.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDuongthuden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDuongthuden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDuongthuden.Location = New System.Drawing.Point(0, 0)
        Me.dgDuongthuden.Name = "dgDuongthuden"
        Me.dgDuongthuden.Size = New System.Drawing.Size(790, 519)
        Me.dgDuongthuden.TabIndex = 4
        Me.dgDuongthuden.Text = "Đường thư đến"
        '
        'Tmp_dgDuongthuden
        '
        Me.Tmp_dgDuongthuden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tmp_dgDuongthuden.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgDuongthuden.DisplayLayout.Appearance = Appearance9
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Tên đường thư"
        UltraGridColumn14.Header.VisiblePosition = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Mã BC KT"
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Mã BC"
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "ID phân loại"
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "IP truyền"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(99, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.Tmp_dgDuongthuden.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Tmp_dgDuongthuden.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance12.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgDuongthuden.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.Tmp_dgDuongthuden.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgDuongthuden.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgDuongthuden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgDuongthuden.Location = New System.Drawing.Point(0, 64)
        Me.Tmp_dgDuongthuden.Name = "Tmp_dgDuongthuden"
        Me.Tmp_dgDuongthuden.Size = New System.Drawing.Size(784, 408)
        Me.Tmp_dgDuongthuden.TabIndex = 43
        Me.Tmp_dgDuongthuden.Text = "Đường thư đến"
        Me.Tmp_dgDuongthuden.Visible = False
        '
        'btnTruyen
        '
        Me.btnTruyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyen.Location = New System.Drawing.Point(584, 136)
        Me.btnTruyen.Name = "btnTruyen"
        Me.btnTruyen.Size = New System.Drawing.Size(153, 40)
        Me.btnTruyen.TabIndex = 8
        Me.btnTruyen.Text = "Truyền dữ liệu"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ddMaBc)
        Me.UltraTabPageControl1.Controls.Add(Me.dgDuongthudi)
        Me.UltraTabPageControl1.Controls.Add(Me.Tmp_dgDuongthudi)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(790, 519)
        '
        'ddMaBc
        '
        Me.ddMaBc.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaBc.DisplayLayout.Appearance = Appearance15
        UltraGridColumn19.Header.Caption = "Mã BC"
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn20.Header.Caption = "Tên BC"
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn21.Header.Caption = "Mã Tỉnh"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        Me.ddMaBc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.ForeColor = System.Drawing.Color.Black
        Appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaBc.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.ddMaBc.DisplayMember = ""
        Me.ddMaBc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaBc.Location = New System.Drawing.Point(80, 152)
        Me.ddMaBc.Name = "ddMaBc"
        Me.ddMaBc.Size = New System.Drawing.Size(208, 128)
        Me.ddMaBc.TabIndex = 40
        Me.ddMaBc.ValueMember = ""
        Me.ddMaBc.Visible = False
        '
        'dgDuongthudi
        '
        Me.dgDuongthudi.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDuongthudi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDuongthudi.DisplayLayout.Appearance = Appearance17
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.Caption = "Tên Đường Thư"
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "Mã BC"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.MaskInput = "999999"
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Mã BC KT"
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "Phân Loại"
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "Tính Doanh Thu"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Header.Caption = "Tính Công Phát"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(96, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.Caption = "Được Truyền"
        UltraGridColumn29.Header.VisiblePosition = 7
        UltraGridColumn30.Header.Caption = "Sử dụng"
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn31.Header.Caption = "Chuyển Tiếp"
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgDuongthudi.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgDuongthudi.DisplayLayout.InterBandSpacing = 10
        Me.dgDuongthudi.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.dgDuongthudi.DisplayLayout.Override.CardAreaAppearance = Appearance18
        Me.dgDuongthudi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.Black
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDuongthudi.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.dgDuongthudi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance20.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongthudi.DisplayLayout.Override.RowAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDuongthudi.DisplayLayout.Override.RowSelectorAppearance = Appearance21
        Me.dgDuongthudi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDuongthudi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.dgDuongthudi.DisplayLayout.Override.SelectedRowAppearance = Appearance22
        Me.dgDuongthudi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongthudi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDuongthudi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDuongthudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDuongthudi.Location = New System.Drawing.Point(0, 0)
        Me.dgDuongthudi.Name = "dgDuongthudi"
        Me.dgDuongthudi.Size = New System.Drawing.Size(790, 519)
        Me.dgDuongthudi.TabIndex = 5
        Me.dgDuongthudi.Text = "Đường Thư Đi"
        '
        'Tmp_dgDuongthudi
        '
        Me.Tmp_dgDuongthudi.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tmp_dgDuongthudi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgDuongthudi.DisplayLayout.Appearance = Appearance23
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Tên đường thư"
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn34.Header.Caption = "Mã BC KT"
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn35.Header.Caption = "Mã BC"
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn36.Header.Caption = "ID phân loại"
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn37.Header.Caption = "IP truyền"
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37})
        UltraGridBand6.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand6.UseRowLayout = True
        Me.Tmp_dgDuongthudi.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.Tmp_dgDuongthudi.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.CardAreaAppearance = Appearance24
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance25.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.ForeColor = System.Drawing.Color.Black
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance25.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance26.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.RowAppearance = Appearance26
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance27.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.RowSelectorAppearance = Appearance27
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgDuongthudi.DisplayLayout.Override.SelectedRowAppearance = Appearance28
        Me.Tmp_dgDuongthudi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgDuongthudi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgDuongthudi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgDuongthudi.Location = New System.Drawing.Point(0, 56)
        Me.Tmp_dgDuongthudi.Name = "Tmp_dgDuongthudi"
        Me.Tmp_dgDuongthudi.Size = New System.Drawing.Size(792, 448)
        Me.Tmp_dgDuongthudi.TabIndex = 41
        Me.Tmp_dgDuongthudi.Text = "Đường thư đi"
        Me.Tmp_dgDuongthudi.Visible = False
        '
        'UltraTabPageControl22
        '
        Me.UltraTabPageControl22.Controls.Add(Me.dgDuong_Thu_Buu_Ta_Noi_Bo)
        Me.UltraTabPageControl22.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl22.Name = "UltraTabPageControl22"
        Me.UltraTabPageControl22.Size = New System.Drawing.Size(790, 519)
        '
        'dgDuong_Thu_Buu_Ta_Noi_Bo
        '
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.AddNewBox.Prompt = " "
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Appearance = Appearance29
        UltraGridColumn38.Header.VisiblePosition = 3
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.Caption = "Tên Đường Thư"
        UltraGridColumn39.Header.VisiblePosition = 0
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(147, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Mã BC KT"
        UltraGridColumn40.Header.VisiblePosition = 1
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.Caption = "Mã BC"
        UltraGridColumn41.Header.VisiblePosition = 2
        UltraGridColumn41.MaskInput = "999999"
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.Caption = "Mã Tỉnh"
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.Caption = "Phân loại đường thư"
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.Caption = "Ghi chú"
        UltraGridColumn44.Header.VisiblePosition = 6
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        UltraGridBand7.Header.Caption = "Đường thư đi nội tỉnh"
        UltraGridBand7.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand7.UseRowLayout = True
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.InterBandSpacing = 10
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.CardAreaAppearance = Appearance30
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance31.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.ForeColor = System.Drawing.Color.Black
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance31.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance32.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.RowAppearance = Appearance32
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.RowSelectorAppearance = Appearance33
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance34.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.Override.SelectedRowAppearance = Appearance34
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Location = New System.Drawing.Point(0, 0)
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Name = "dgDuong_Thu_Buu_Ta_Noi_Bo"
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Size = New System.Drawing.Size(790, 519)
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.TabIndex = 7
        Me.dgDuong_Thu_Buu_Ta_Noi_Bo.Text = "Đường Thư Bưu tá nội bộ"
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.ddBuuCucKhaiThac_NoiTinh)
        Me.UltraTabPageControl18.Controls.Add(Me.ddPhan_Loai_Duong_Thu_Noi_Tinh)
        Me.UltraTabPageControl18.Controls.Add(Me.dgDuongThuDiNoiTinh)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(790, 519)
        '
        'ddBuuCucKhaiThac_NoiTinh
        '
        Me.ddBuuCucKhaiThac_NoiTinh.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddBuuCucKhaiThac_NoiTinh.DisplayLayout.Appearance = Appearance35
        UltraGridColumn45.Header.Caption = "Mã BC"
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn46.Header.Caption = "Tên Đường Thư"
        UltraGridColumn46.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46})
        Me.ddBuuCucKhaiThac_NoiTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.ForeColor = System.Drawing.Color.Black
        Appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddBuuCucKhaiThac_NoiTinh.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.ddBuuCucKhaiThac_NoiTinh.DisplayMember = ""
        Me.ddBuuCucKhaiThac_NoiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddBuuCucKhaiThac_NoiTinh.Location = New System.Drawing.Point(440, 144)
        Me.ddBuuCucKhaiThac_NoiTinh.Name = "ddBuuCucKhaiThac_NoiTinh"
        Me.ddBuuCucKhaiThac_NoiTinh.Size = New System.Drawing.Size(208, 128)
        Me.ddBuuCucKhaiThac_NoiTinh.TabIndex = 42
        Me.ddBuuCucKhaiThac_NoiTinh.ValueMember = ""
        Me.ddBuuCucKhaiThac_NoiTinh.Visible = False
        '
        'ddPhan_Loai_Duong_Thu_Noi_Tinh
        '
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Cursor = System.Windows.Forms.Cursors.Default
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.DisplayLayout.Appearance = Appearance37
        UltraGridColumn47.Header.Caption = "Phân Loại"
        UltraGridColumn47.Header.VisiblePosition = 0
        UltraGridColumn48.Header.Caption = "Tên Phân Loại"
        UltraGridColumn48.Header.VisiblePosition = 1
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn47, UltraGridColumn48})
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.ForeColor = System.Drawing.Color.Black
        Appearance38.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.DisplayMember = "Ten_Phan_Loai"
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Location = New System.Drawing.Point(176, 184)
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Name = "ddPhan_Loai_Duong_Thu_Noi_Tinh"
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Size = New System.Drawing.Size(208, 128)
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.TabIndex = 41
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.ValueMember = "Ma_Phan_Loai"
        Me.ddPhan_Loai_Duong_Thu_Noi_Tinh.Visible = False
        '
        'dgDuongThuDiNoiTinh
        '
        Me.dgDuongThuDiNoiTinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDuongThuDiNoiTinh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Appearance = Appearance39
        UltraGridColumn49.Header.VisiblePosition = 3
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.Caption = "Tên Đường Thư"
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "Mã BC KT"
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Header.Caption = "Mã BC"
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn52.MaskInput = "999999"
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.Caption = "Mã Tỉnh"
        UltraGridColumn53.Header.VisiblePosition = 4
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.Caption = "Phân loại đường thư"
        UltraGridColumn54.Header.VisiblePosition = 5
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54})
        UltraGridBand10.Header.Caption = "Đường thư đi nội tỉnh"
        UltraGridBand10.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand10.UseRowLayout = True
        Me.dgDuongThuDiNoiTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.dgDuongThuDiNoiTinh.DisplayLayout.InterBandSpacing = 10
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.CardAreaAppearance = Appearance40
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance41.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance41.ForeColor = System.Drawing.Color.Black
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance41.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance42.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.RowAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance43.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.RowSelectorAppearance = Appearance43
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance44.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.dgDuongThuDiNoiTinh.DisplayLayout.Override.SelectedRowAppearance = Appearance44
        Me.dgDuongThuDiNoiTinh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDuongThuDiNoiTinh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDuongThuDiNoiTinh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDuongThuDiNoiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDuongThuDiNoiTinh.Location = New System.Drawing.Point(0, 0)
        Me.dgDuongThuDiNoiTinh.Name = "dgDuongThuDiNoiTinh"
        Me.dgDuongThuDiNoiTinh.Size = New System.Drawing.Size(790, 519)
        Me.dgDuongThuDiNoiTinh.TabIndex = 6
        Me.dgDuongThuDiNoiTinh.Text = "Đường Thư Đi"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ddPhan_Loai_Ma_Bc_Khai_Thac)
        Me.UltraTabPageControl2.Controls.Add(Me.dgMabckt)
        Me.UltraTabPageControl2.Controls.Add(Me.Tmp_dgMabckt)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(790, 519)
        '
        'ddPhan_Loai_Ma_Bc_Khai_Thac
        '
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.DisplayLayout.Appearance = Appearance45
        UltraGridColumn55.Header.Caption = "Mã Phân Loại"
        UltraGridColumn55.Header.VisiblePosition = 0
        UltraGridColumn56.Header.Caption = "Tên phân loại"
        UltraGridColumn56.Header.VisiblePosition = 1
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn55, UltraGridColumn56})
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance46.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance46.ForeColor = System.Drawing.Color.Black
        Appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.DisplayMember = "Ten_Phan_Loai"
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.Location = New System.Drawing.Point(343, 195)
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.Name = "ddPhan_Loai_Ma_Bc_Khai_Thac"
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.Size = New System.Drawing.Size(104, 128)
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.TabIndex = 44
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.ValueMember = "Ma_Phan_Loai"
        Me.ddPhan_Loai_Ma_Bc_Khai_Thac.Visible = False
        '
        'dgMabckt
        '
        Me.dgMabckt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgMabckt.DisplayLayout.AddNewBox.Prompt = " "
        Appearance47.BackColor = System.Drawing.Color.White
        Appearance47.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMabckt.DisplayLayout.Appearance = Appearance47
        UltraGridColumn57.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn57.MaskInput = "999999"
        UltraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(99, 0)
        UltraGridColumn58.Header.Caption = "Tên BC Khai Thác"
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn58.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(106, 0)
        UltraGridColumn59.Header.Caption = "Phân Loại"
        UltraGridColumn59.Header.VisiblePosition = 2
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        UltraGridBand12.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand12.UseRowLayout = True
        Me.dgMabckt.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.dgMabckt.DisplayLayout.InterBandSpacing = 10
        Me.dgMabckt.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Me.dgMabckt.DisplayLayout.Override.CardAreaAppearance = Appearance48
        Me.dgMabckt.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance49.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.ForeColor = System.Drawing.Color.Black
        Appearance49.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance49.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMabckt.DisplayLayout.Override.HeaderAppearance = Appearance49
        Me.dgMabckt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance50.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMabckt.DisplayLayout.Override.RowAppearance = Appearance50
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance51.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMabckt.DisplayLayout.Override.RowSelectorAppearance = Appearance51
        Me.dgMabckt.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMabckt.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance52.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.dgMabckt.DisplayLayout.Override.SelectedRowAppearance = Appearance52
        Me.dgMabckt.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMabckt.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMabckt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMabckt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMabckt.Location = New System.Drawing.Point(0, 0)
        Me.dgMabckt.Name = "dgMabckt"
        Me.dgMabckt.Size = New System.Drawing.Size(790, 519)
        Me.dgMabckt.TabIndex = 6
        Me.dgMabckt.Text = "Mã bưu cục khai thác"
        '
        'Tmp_dgMabckt
        '
        Me.Tmp_dgMabckt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tmp_dgMabckt.DisplayLayout.AddNewBox.Prompt = " "
        Appearance53.BackColor = System.Drawing.Color.White
        Appearance53.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgMabckt.DisplayLayout.Appearance = Appearance53
        UltraGridColumn60.Header.Caption = "Mã BC KT"
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn61.Header.Caption = "Tên BC KT"
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61})
        UltraGridBand13.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand13.UseRowLayout = True
        Me.Tmp_dgMabckt.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.Tmp_dgMabckt.DisplayLayout.InterBandSpacing = 10
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgMabckt.DisplayLayout.Override.CardAreaAppearance = Appearance54
        Me.Tmp_dgMabckt.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance55.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance55.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance55.ForeColor = System.Drawing.Color.Black
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance55.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgMabckt.DisplayLayout.Override.HeaderAppearance = Appearance55
        Me.Tmp_dgMabckt.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance56.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgMabckt.DisplayLayout.Override.RowAppearance = Appearance56
        Appearance57.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance57.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgMabckt.DisplayLayout.Override.RowSelectorAppearance = Appearance57
        Me.Tmp_dgMabckt.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgMabckt.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance58.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgMabckt.DisplayLayout.Override.SelectedRowAppearance = Appearance58
        Me.Tmp_dgMabckt.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgMabckt.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgMabckt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgMabckt.Location = New System.Drawing.Point(0, 0)
        Me.Tmp_dgMabckt.Name = "Tmp_dgMabckt"
        Me.Tmp_dgMabckt.Size = New System.Drawing.Size(728, 481)
        Me.Tmp_dgMabckt.TabIndex = 43
        Me.Tmp_dgMabckt.Text = "Mã bưu cục khai thác"
        Me.Tmp_dgMabckt.Visible = False
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.ddMa_Nuoc)
        Me.UltraTabPageControl11.Controls.Add(Me.cbMa_Tinh)
        Me.UltraTabPageControl11.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl11.Controls.Add(Me.cbMa_Nuoc)
        Me.UltraTabPageControl11.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl11.Controls.Add(Me.ddMaDonVi)
        Me.UltraTabPageControl11.Controls.Add(Me.ddMaTinh)
        Me.UltraTabPageControl11.Controls.Add(Me.ddQuanLy)
        Me.UltraTabPageControl11.Controls.Add(Me.dgDmMaBC)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(790, 519)
        '
        'ddMa_Nuoc
        '
        Me.ddMa_Nuoc.Cursor = System.Windows.Forms.Cursors.Default
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Nuoc.DisplayLayout.Appearance = Appearance59
        UltraGridColumn62.Header.Caption = "Mã Nước"
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridColumn63.Header.Caption = "Tên Nước"
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn62, UltraGridColumn63})
        Me.ddMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.ForeColor = System.Drawing.Color.Black
        Appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Nuoc.DisplayLayout.Override.HeaderAppearance = Appearance60
        Me.ddMa_Nuoc.DisplayMember = "Ma_Nuoc"
        Me.ddMa_Nuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(408, 296)
        Me.ddMa_Nuoc.Name = "ddMa_Nuoc"
        Me.ddMa_Nuoc.Size = New System.Drawing.Size(200, 128)
        Me.ddMa_Nuoc.TabIndex = 44
        Me.ddMa_Nuoc.Text = "Mã Nước"
        Me.ddMa_Nuoc.ValueMember = "Ma_Nuoc"
        Me.ddMa_Nuoc.Visible = False
        '
        'cbMa_Tinh
        '
        Me.cbMa_Tinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn64.Header.Caption = "Mã Tỉnh"
        UltraGridColumn64.Header.VisiblePosition = 0
        UltraGridColumn65.Header.Caption = "Tên Tỉnh"
        UltraGridColumn65.Header.VisiblePosition = 1
        UltraGridColumn66.Header.VisiblePosition = 2
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 3
        UltraGridColumn67.Hidden = True
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67})
        UltraGridBand15.Header.Caption = "Mã Tỉnh"
        Me.cbMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.cbMa_Tinh.DisplayMember = ""
        Me.cbMa_Tinh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Tinh.Location = New System.Drawing.Point(440, 8)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(104, 21)
        Me.cbMa_Tinh.TabIndex = 1
        Me.cbMa_Tinh.ValueMember = ""
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(344, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel2.TabIndex = 47
        Me.UltraLabel2.Text = "Mã Tỉnh"
        '
        'cbMa_Nuoc
        '
        Me.cbMa_Nuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn68.Header.Caption = "Mã Nước"
        UltraGridColumn68.Header.VisiblePosition = 0
        UltraGridColumn69.Header.Caption = "Tên Nước"
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridColumn70.Header.VisiblePosition = 2
        UltraGridColumn70.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn68, UltraGridColumn69, UltraGridColumn70})
        UltraGridBand16.Header.Caption = "Mã Nước"
        Me.cbMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.cbMa_Nuoc.DisplayMember = ""
        Me.cbMa_Nuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Nuoc.Location = New System.Drawing.Point(200, 8)
        Me.cbMa_Nuoc.Name = "cbMa_Nuoc"
        Me.cbMa_Nuoc.Size = New System.Drawing.Size(104, 21)
        Me.cbMa_Nuoc.TabIndex = 0
        Me.cbMa_Nuoc.ValueMember = ""
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(104, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel1.TabIndex = 45
        Me.UltraLabel1.Text = "Mã Nước"
        '
        'ddMaDonVi
        '
        Me.ddMaDonVi.Cursor = System.Windows.Forms.Cursors.Default
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaDonVi.DisplayLayout.Appearance = Appearance61
        UltraGridColumn71.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn71.Header.VisiblePosition = 0
        UltraGridColumn72.Header.Caption = "Mã Tỉnh"
        UltraGridColumn72.Header.VisiblePosition = 1
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.Caption = "Tên Đơn Vị"
        UltraGridColumn73.Header.VisiblePosition = 2
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn71, UltraGridColumn72, UltraGridColumn73})
        Me.ddMaDonVi.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Appearance62.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance62.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance62.ForeColor = System.Drawing.Color.Black
        Appearance62.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaDonVi.DisplayLayout.Override.HeaderAppearance = Appearance62
        Me.ddMaDonVi.DisplayMember = "Ma_Don_Vi"
        Me.ddMaDonVi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaDonVi.Location = New System.Drawing.Point(48, 296)
        Me.ddMaDonVi.Name = "ddMaDonVi"
        Me.ddMaDonVi.Size = New System.Drawing.Size(200, 128)
        Me.ddMaDonVi.TabIndex = 43
        Me.ddMaDonVi.Text = "Mã Đơn Vị"
        Me.ddMaDonVi.ValueMember = "Ma_Don_Vi"
        Me.ddMaDonVi.Visible = False
        '
        'ddMaTinh
        '
        Me.ddMaTinh.Cursor = System.Windows.Forms.Cursors.Default
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaTinh.DisplayLayout.Appearance = Appearance63
        UltraGridColumn74.Header.Caption = "Mã Tỉnh"
        UltraGridColumn74.Header.VisiblePosition = 0
        UltraGridColumn75.Header.Caption = "Tên Tỉnh"
        UltraGridColumn75.Header.VisiblePosition = 1
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 3
        UltraGridColumn77.Hidden = True
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77})
        Me.ddMaTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Appearance64.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance64.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance64.ForeColor = System.Drawing.Color.Black
        Appearance64.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaTinh.DisplayLayout.Override.HeaderAppearance = Appearance64
        Me.ddMaTinh.DisplayMember = "Ma_Tinh"
        Me.ddMaTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaTinh.Location = New System.Drawing.Point(248, 136)
        Me.ddMaTinh.Name = "ddMaTinh"
        Me.ddMaTinh.Size = New System.Drawing.Size(200, 128)
        Me.ddMaTinh.TabIndex = 42
        Me.ddMaTinh.Text = "Mã Tỉnh"
        Me.ddMaTinh.ValueMember = "Ma_Tinh"
        Me.ddMaTinh.Visible = False
        '
        'ddQuanLy
        '
        Me.ddQuanLy.Cursor = System.Windows.Forms.Cursors.Default
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddQuanLy.DisplayLayout.Appearance = Appearance65
        UltraGridColumn78.Header.Caption = "Mã Quản Lý"
        UltraGridColumn78.Header.VisiblePosition = 0
        UltraGridColumn78.Width = 77
        UltraGridColumn79.Header.Caption = "Tên Quản Lý"
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn78, UltraGridColumn79})
        Me.ddQuanLy.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Appearance66.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance66.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance66.ForeColor = System.Drawing.Color.Black
        Appearance66.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddQuanLy.DisplayLayout.Override.HeaderAppearance = Appearance66
        Me.ddQuanLy.DisplayMember = "Ma_Quan_Ly"
        Me.ddQuanLy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddQuanLy.Location = New System.Drawing.Point(488, 112)
        Me.ddQuanLy.Name = "ddQuanLy"
        Me.ddQuanLy.Size = New System.Drawing.Size(176, 128)
        Me.ddQuanLy.TabIndex = 41
        Me.ddQuanLy.Text = "Quản Lý"
        Me.ddQuanLy.ValueMember = "Ma_Quan_Ly"
        Me.ddQuanLy.Visible = False
        '
        'dgDmMaBC
        '
        Me.dgDmMaBC.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgDmMaBC.DisplayLayout.AddNewBox.Prompt = " "
        Appearance67.BackColor = System.Drawing.Color.White
        Appearance67.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDmMaBC.DisplayLayout.Appearance = Appearance67
        UltraGridColumn80.Header.Caption = "Mã BC"
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridColumn80.MaskInput = ""
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.Header.Caption = "Mã BC Cha"
        UltraGridColumn82.Header.VisiblePosition = 2
        UltraGridColumn82.MaskInput = "999999"
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.Header.Caption = "Mã Tỉnh"
        UltraGridColumn83.Header.VisiblePosition = 3
        UltraGridColumn83.MaskInput = "999999"
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.DefaultCellValue = ""
        UltraGridColumn84.Header.Caption = "Tên BC"
        UltraGridColumn84.Header.VisiblePosition = 4
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(104, 0)
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.Header.Caption = "Cấp BC"
        UltraGridColumn85.Header.VisiblePosition = 5
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(52, 0)
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.DefaultCellValue = ""
        UltraGridColumn86.Header.Caption = "Địa Chỉ"
        UltraGridColumn86.Header.VisiblePosition = 6
        UltraGridColumn86.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn86.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(146, 0)
        UltraGridColumn86.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn86.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn87.DefaultCellValue = ""
        UltraGridColumn87.Header.Caption = "Điện Thoại"
        UltraGridColumn87.Header.VisiblePosition = 7
        UltraGridColumn87.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn87.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn87.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(94, 0)
        UltraGridColumn87.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn87.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn88.DefaultCellValue = ""
        UltraGridColumn88.Header.VisiblePosition = 8
        UltraGridColumn88.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn88.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn88.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn88.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn88.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn89.Header.Caption = "Mã Quản Lý"
        UltraGridColumn89.Header.VisiblePosition = 9
        UltraGridColumn89.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn89.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn89.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn89.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn89.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn90.Header.Caption = "Mã Nước"
        UltraGridColumn90.Header.VisiblePosition = 10
        UltraGridColumn90.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn90.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn90.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn90.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.DefaultCellValue = ""
        UltraGridColumn91.Header.VisiblePosition = 11
        UltraGridColumn91.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn91.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn91.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn91.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand20.Columns.AddRange(New Object() {UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91})
        UltraGridBand20.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand20.UseRowLayout = True
        Me.dgDmMaBC.DisplayLayout.BandsSerializer.Add(UltraGridBand20)
        Me.dgDmMaBC.DisplayLayout.InterBandSpacing = 10
        Me.dgDmMaBC.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Me.dgDmMaBC.DisplayLayout.Override.CardAreaAppearance = Appearance68
        Me.dgDmMaBC.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance69.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance69.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance69.ForeColor = System.Drawing.Color.Black
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance69.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDmMaBC.DisplayLayout.Override.HeaderAppearance = Appearance69
        Me.dgDmMaBC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance70.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDmMaBC.DisplayLayout.Override.RowAppearance = Appearance70
        Appearance71.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance71.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDmMaBC.DisplayLayout.Override.RowSelectorAppearance = Appearance71
        Me.dgDmMaBC.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDmMaBC.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance72.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance72.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.dgDmMaBC.DisplayLayout.Override.SelectedRowAppearance = Appearance72
        Me.dgDmMaBC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDmMaBC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDmMaBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDmMaBC.Location = New System.Drawing.Point(0, 40)
        Me.dgDmMaBC.Name = "dgDmMaBC"
        Me.dgDmMaBC.Size = New System.Drawing.Size(790, 472)
        Me.dgDmMaBC.TabIndex = 2
        Me.dgDmMaBC.Text = "Mã BC"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.dgLydo)
        Me.UltraTabPageControl3.Controls.Add(Me.Tmp_dgLydo)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(790, 519)
        '
        'dgLydo
        '
        Me.dgLydo.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgLydo.DisplayLayout.AddNewBox.Prompt = " "
        Appearance73.BackColor = System.Drawing.Color.White
        Appearance73.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgLydo.DisplayLayout.Appearance = Appearance73
        UltraGridColumn92.Header.Caption = "Mã Lý Do"
        UltraGridColumn92.Header.VisiblePosition = 0
        UltraGridColumn93.Header.Caption = "Tên Lý Do"
        UltraGridColumn93.Header.VisiblePosition = 1
        UltraGridColumn94.Header.Caption = "Tên Lý Do TA"
        UltraGridColumn94.Header.VisiblePosition = 2
        UltraGridColumn95.Header.Caption = "Tổ Hợp Xử Lý"
        UltraGridColumn95.Header.VisiblePosition = 3
        UltraGridBand21.Columns.AddRange(New Object() {UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95})
        UltraGridBand21.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand21.UseRowLayout = True
        Me.dgLydo.DisplayLayout.BandsSerializer.Add(UltraGridBand21)
        Me.dgLydo.DisplayLayout.InterBandSpacing = 10
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Me.dgLydo.DisplayLayout.Override.CardAreaAppearance = Appearance74
        Me.dgLydo.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance75.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance75.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance75.ForeColor = System.Drawing.Color.Black
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance75.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgLydo.DisplayLayout.Override.HeaderAppearance = Appearance75
        Me.dgLydo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance76.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgLydo.DisplayLayout.Override.RowAppearance = Appearance76
        Appearance77.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance77.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgLydo.DisplayLayout.Override.RowSelectorAppearance = Appearance77
        Me.dgLydo.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgLydo.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance78.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance78.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance78.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance78.ForeColor = System.Drawing.Color.Black
        Me.dgLydo.DisplayLayout.Override.SelectedRowAppearance = Appearance78
        Me.dgLydo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgLydo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgLydo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLydo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLydo.Location = New System.Drawing.Point(0, 0)
        Me.dgLydo.Name = "dgLydo"
        Me.dgLydo.Size = New System.Drawing.Size(790, 519)
        Me.dgLydo.TabIndex = 5
        Me.dgLydo.Text = "Lý do"
        '
        'Tmp_dgLydo
        '
        Me.Tmp_dgLydo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tmp_dgLydo.DisplayLayout.AddNewBox.Prompt = " "
        Appearance79.BackColor = System.Drawing.Color.White
        Appearance79.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgLydo.DisplayLayout.Appearance = Appearance79
        UltraGridColumn96.Header.Caption = "Mã lý do"
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn97.Header.Caption = "Tên lý do"
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn98.Header.Caption = "Tên lý do TA"
        UltraGridColumn98.Header.VisiblePosition = 2
        UltraGridColumn99.Header.Caption = "Tổ hợp xử lý"
        UltraGridColumn99.Header.VisiblePosition = 3
        UltraGridBand22.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99})
        UltraGridBand22.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand22.UseRowLayout = True
        Me.Tmp_dgLydo.DisplayLayout.BandsSerializer.Add(UltraGridBand22)
        Me.Tmp_dgLydo.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgLydo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgLydo.DisplayLayout.Override.CardAreaAppearance = Appearance80
        Me.Tmp_dgLydo.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance81.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance81.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance81.ForeColor = System.Drawing.Color.Black
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance81.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgLydo.DisplayLayout.Override.HeaderAppearance = Appearance81
        Me.Tmp_dgLydo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance82.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgLydo.DisplayLayout.Override.RowAppearance = Appearance82
        Appearance83.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance83.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgLydo.DisplayLayout.Override.RowSelectorAppearance = Appearance83
        Me.Tmp_dgLydo.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgLydo.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance84.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgLydo.DisplayLayout.Override.SelectedRowAppearance = Appearance84
        Me.Tmp_dgLydo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgLydo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgLydo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgLydo.Location = New System.Drawing.Point(0, 0)
        Me.Tmp_dgLydo.Name = "Tmp_dgLydo"
        Me.Tmp_dgLydo.Size = New System.Drawing.Size(736, 481)
        Me.Tmp_dgLydo.TabIndex = 6
        Me.Tmp_dgLydo.Text = "Lý do"
        Me.Tmp_dgLydo.Visible = False
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.dgXuly)
        Me.UltraTabPageControl7.Controls.Add(Me.Tmp_dgXuly)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(790, 519)
        '
        'dgXuly
        '
        Me.dgXuly.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgXuly.DisplayLayout.AddNewBox.Prompt = " "
        Appearance85.BackColor = System.Drawing.Color.White
        Appearance85.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgXuly.DisplayLayout.Appearance = Appearance85
        UltraGridColumn100.Header.Caption = "Mã Xử Lý"
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn101.Header.Caption = "Tên Xử Lý"
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(99, 0)
        UltraGridColumn102.Header.Caption = "Tên Xử Lý TA"
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridBand23.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101, UltraGridColumn102})
        UltraGridBand23.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand23.UseRowLayout = True
        Me.dgXuly.DisplayLayout.BandsSerializer.Add(UltraGridBand23)
        Me.dgXuly.DisplayLayout.InterBandSpacing = 10
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Me.dgXuly.DisplayLayout.Override.CardAreaAppearance = Appearance86
        Me.dgXuly.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance87.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance87.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance87.ForeColor = System.Drawing.Color.Black
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance87.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgXuly.DisplayLayout.Override.HeaderAppearance = Appearance87
        Me.dgXuly.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance88.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgXuly.DisplayLayout.Override.RowAppearance = Appearance88
        Appearance89.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance89.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgXuly.DisplayLayout.Override.RowSelectorAppearance = Appearance89
        Me.dgXuly.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgXuly.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance90.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance90.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance90.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance90.ForeColor = System.Drawing.Color.Black
        Me.dgXuly.DisplayLayout.Override.SelectedRowAppearance = Appearance90
        Me.dgXuly.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgXuly.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgXuly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgXuly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgXuly.Location = New System.Drawing.Point(0, 0)
        Me.dgXuly.Name = "dgXuly"
        Me.dgXuly.Size = New System.Drawing.Size(790, 519)
        Me.dgXuly.TabIndex = 5
        Me.dgXuly.Text = "Xử lý"
        '
        'Tmp_dgXuly
        '
        Me.Tmp_dgXuly.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tmp_dgXuly.DisplayLayout.AddNewBox.Prompt = " "
        Appearance91.BackColor = System.Drawing.Color.White
        Appearance91.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgXuly.DisplayLayout.Appearance = Appearance91
        UltraGridColumn103.Header.Caption = "Mã xử lý"
        UltraGridColumn103.Header.VisiblePosition = 0
        UltraGridColumn104.Header.Caption = "Tên xử lý"
        UltraGridColumn104.Header.VisiblePosition = 1
        UltraGridColumn105.Header.Caption = "Tên xử lý TA"
        UltraGridColumn105.Header.VisiblePosition = 2
        UltraGridBand24.Columns.AddRange(New Object() {UltraGridColumn103, UltraGridColumn104, UltraGridColumn105})
        UltraGridBand24.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand24.UseRowLayout = True
        Me.Tmp_dgXuly.DisplayLayout.BandsSerializer.Add(UltraGridBand24)
        Me.Tmp_dgXuly.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgXuly.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgXuly.DisplayLayout.Override.CardAreaAppearance = Appearance92
        Me.Tmp_dgXuly.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance93.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance93.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.ForeColor = System.Drawing.Color.Black
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance93.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgXuly.DisplayLayout.Override.HeaderAppearance = Appearance93
        Me.Tmp_dgXuly.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance94.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgXuly.DisplayLayout.Override.RowAppearance = Appearance94
        Appearance95.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance95.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgXuly.DisplayLayout.Override.RowSelectorAppearance = Appearance95
        Me.Tmp_dgXuly.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgXuly.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance96.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance96.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgXuly.DisplayLayout.Override.SelectedRowAppearance = Appearance96
        Me.Tmp_dgXuly.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgXuly.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgXuly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgXuly.Location = New System.Drawing.Point(0, 0)
        Me.Tmp_dgXuly.Name = "Tmp_dgXuly"
        Me.Tmp_dgXuly.Size = New System.Drawing.Size(736, 481)
        Me.Tmp_dgXuly.TabIndex = 6
        Me.Tmp_dgXuly.Text = "Xử lý"
        Me.Tmp_dgXuly.Visible = False
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.cbKhoGiay)
        Me.UltraTabPageControl16.Controls.Add(Me.lblToaDoIn)
        Me.UltraTabPageControl16.Controls.Add(Me.nubEditor)
        Me.UltraTabPageControl16.Controls.Add(Me.dgToaDoIn)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(790, 519)
        '
        'cbKhoGiay
        '
        Me.cbKhoGiay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn106.Header.Caption = "Khổ Giấy"
        UltraGridColumn106.Header.VisiblePosition = 0
        UltraGridColumn106.Width = 124
        UltraGridBand25.Columns.AddRange(New Object() {UltraGridColumn106})
        Me.cbKhoGiay.DisplayLayout.BandsSerializer.Add(UltraGridBand25)
        Me.cbKhoGiay.DisplayMember = "Kho_Giay"
        Me.cbKhoGiay.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKhoGiay.Location = New System.Drawing.Point(152, 0)
        Me.cbKhoGiay.Name = "cbKhoGiay"
        Me.cbKhoGiay.Size = New System.Drawing.Size(120, 21)
        Me.cbKhoGiay.TabIndex = 14
        Me.cbKhoGiay.ValueMember = "Kho_Giay"
        '
        'lblToaDoIn
        '
        Me.lblToaDoIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToaDoIn.Location = New System.Drawing.Point(0, 0)
        Me.lblToaDoIn.Name = "lblToaDoIn"
        Me.lblToaDoIn.Size = New System.Drawing.Size(152, 23)
        Me.lblToaDoIn.TabIndex = 12
        Me.lblToaDoIn.Text = "Bạn hãy chọn khổ giấy :"
        '
        'dgToaDoIn
        '
        Me.dgToaDoIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgToaDoIn.DisplayLayout.AddNewBox.Prompt = " "
        Appearance97.BackColor = System.Drawing.Color.White
        Appearance97.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgToaDoIn.DisplayLayout.Appearance = Appearance97
        UltraGridColumn107.Header.VisiblePosition = 0
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.Caption = "Khổ Giấy"
        UltraGridColumn108.Header.VisiblePosition = 1
        UltraGridColumn109.Header.Caption = "Tên Đối Tượng"
        UltraGridColumn109.Header.VisiblePosition = 2
        UltraGridColumn110.Header.Caption = "Tên Đối Tượng VN"
        UltraGridColumn110.Header.VisiblePosition = 3
        UltraGridColumn111.EditorControl = Me.nubEditor
        UltraGridColumn111.Header.Caption = "Toạ Độ Trên"
        UltraGridColumn111.Header.VisiblePosition = 4
        UltraGridColumn112.EditorControl = Me.nubEditor
        UltraGridColumn112.Header.Caption = "Tọa Độ Trái"
        UltraGridColumn112.Header.VisiblePosition = 5
        UltraGridColumn113.Header.VisiblePosition = 6
        UltraGridColumn113.Hidden = True
        UltraGridBand26.Columns.AddRange(New Object() {UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        UltraGridBand26.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand26.UseRowLayout = True
        Me.dgToaDoIn.DisplayLayout.BandsSerializer.Add(UltraGridBand26)
        Me.dgToaDoIn.DisplayLayout.InterBandSpacing = 10
        Me.dgToaDoIn.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Me.dgToaDoIn.DisplayLayout.Override.CardAreaAppearance = Appearance98
        Me.dgToaDoIn.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance99.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance99.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance99.ForeColor = System.Drawing.Color.Black
        Appearance99.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance99.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgToaDoIn.DisplayLayout.Override.HeaderAppearance = Appearance99
        Me.dgToaDoIn.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance100.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToaDoIn.DisplayLayout.Override.RowAppearance = Appearance100
        Appearance101.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance101.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgToaDoIn.DisplayLayout.Override.RowSelectorAppearance = Appearance101
        Me.dgToaDoIn.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgToaDoIn.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance102.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance102.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance102.ForeColor = System.Drawing.Color.Black
        Me.dgToaDoIn.DisplayLayout.Override.SelectedRowAppearance = Appearance102
        Me.dgToaDoIn.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToaDoIn.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgToaDoIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgToaDoIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgToaDoIn.Location = New System.Drawing.Point(0, 0)
        Me.dgToaDoIn.Name = "dgToaDoIn"
        Me.dgToaDoIn.Size = New System.Drawing.Size(790, 519)
        Me.dgToaDoIn.TabIndex = 8
        Me.dgToaDoIn.Text = "Toạ Độ In"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.ddMaBcKt)
        Me.UltraTabPageControl5.Controls.Add(Me.ddMaCa)
        Me.UltraTabPageControl5.Controls.Add(Me.dgMaca)
        Me.UltraTabPageControl5.Controls.Add(Me.Tmp_dgMaca)
        Me.UltraTabPageControl5.Controls.Add(Me.dtpNgayDinhDang)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(790, 519)
        '
        'ddMaBcKt
        '
        Me.ddMaBcKt.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance103.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaBcKt.DisplayLayout.Appearance = Appearance103
        UltraGridColumn114.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn115.Header.Caption = "Tên BC"
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridBand27.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115})
        Me.ddMaBcKt.DisplayLayout.BandsSerializer.Add(UltraGridBand27)
        Appearance104.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance104.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance104.ForeColor = System.Drawing.Color.Black
        Appearance104.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaBcKt.DisplayLayout.Override.HeaderAppearance = Appearance104
        Me.ddMaBcKt.DisplayMember = ""
        Me.ddMaBcKt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaBcKt.Location = New System.Drawing.Point(480, 128)
        Me.ddMaBcKt.Name = "ddMaBcKt"
        Me.ddMaBcKt.Size = New System.Drawing.Size(208, 128)
        Me.ddMaBcKt.TabIndex = 56
        Me.ddMaBcKt.ValueMember = ""
        Me.ddMaBcKt.Visible = False
        '
        'ddMaCa
        '
        Me.ddMaCa.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance105.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaCa.DisplayLayout.Appearance = Appearance105
        UltraGridColumn116.Header.Caption = "Ca Khai Thác"
        UltraGridColumn116.Header.VisiblePosition = 0
        UltraGridColumn117.Header.Caption = "Mã BC"
        UltraGridColumn117.Header.VisiblePosition = 1
        UltraGridColumn118.Header.VisiblePosition = 2
        UltraGridColumn119.Header.Caption = "Ca Kế Toán"
        UltraGridColumn119.Header.VisiblePosition = 3
        UltraGridBand28.Columns.AddRange(New Object() {UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119})
        Me.ddMaCa.DisplayLayout.BandsSerializer.Add(UltraGridBand28)
        Appearance106.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance106.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance106.ForeColor = System.Drawing.Color.Black
        Appearance106.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaCa.DisplayLayout.Override.HeaderAppearance = Appearance106
        Me.ddMaCa.DisplayMember = "Ca"
        Me.ddMaCa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaCa.Location = New System.Drawing.Point(104, 240)
        Me.ddMaCa.Name = "ddMaCa"
        Me.ddMaCa.Size = New System.Drawing.Size(304, 128)
        Me.ddMaCa.TabIndex = 43
        Me.ddMaCa.ValueMember = "Ca_Khai_Thac"
        Me.ddMaCa.Visible = False
        '
        'dgMaca
        '
        Me.dgMaca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgMaca.DisplayLayout.AddNewBox.Prompt = " "
        Appearance107.BackColor = System.Drawing.Color.White
        Appearance107.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance107.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMaca.DisplayLayout.Appearance = Appearance107
        UltraGridColumn120.Header.Caption = "Ca Khai Thác"
        UltraGridColumn120.Header.VisiblePosition = 0
        UltraGridColumn120.Hidden = True
        UltraGridColumn120.MaskInput = "999999"
        UltraGridColumn120.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn121.Header.Caption = "Mã BC Khai Thác"
        UltraGridColumn121.Header.VisiblePosition = 1
        UltraGridColumn121.MaskInput = "999999"
        UltraGridColumn121.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(119, 0)
        UltraGridColumn122.Header.VisiblePosition = 2
        UltraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(94, 0)
        UltraGridColumn123.Header.Caption = "Ca Kế Toán"
        UltraGridColumn123.Header.VisiblePosition = 3
        UltraGridBand29.Columns.AddRange(New Object() {UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123})
        UltraGridBand29.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand29.UseRowLayout = True
        Me.dgMaca.DisplayLayout.BandsSerializer.Add(UltraGridBand29)
        Me.dgMaca.DisplayLayout.InterBandSpacing = 10
        Me.dgMaca.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Me.dgMaca.DisplayLayout.Override.CardAreaAppearance = Appearance108
        Me.dgMaca.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance109.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance109.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance109.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance109.ForeColor = System.Drawing.Color.Black
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance109.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMaca.DisplayLayout.Override.HeaderAppearance = Appearance109
        Me.dgMaca.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance110.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaca.DisplayLayout.Override.RowAppearance = Appearance110
        Appearance111.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance111.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance111.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMaca.DisplayLayout.Override.RowSelectorAppearance = Appearance111
        Me.dgMaca.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMaca.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance112.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance112.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance112.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance112.ForeColor = System.Drawing.Color.Black
        Me.dgMaca.DisplayLayout.Override.SelectedRowAppearance = Appearance112
        Me.dgMaca.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaca.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMaca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMaca.Location = New System.Drawing.Point(0, 0)
        Me.dgMaca.Name = "dgMaca"
        Me.dgMaca.Size = New System.Drawing.Size(790, 519)
        Me.dgMaca.TabIndex = 5
        Me.dgMaca.Text = "Mã ca"
        '
        'Tmp_dgMaca
        '
        Me.Tmp_dgMaca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Tmp_dgMaca.DisplayLayout.AddNewBox.Prompt = " "
        Appearance113.BackColor = System.Drawing.Color.White
        Appearance113.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgMaca.DisplayLayout.Appearance = Appearance113
        UltraGridColumn124.Header.Caption = "Ca khai thác"
        UltraGridColumn124.Header.VisiblePosition = 0
        UltraGridColumn124.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn125.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn125.Header.VisiblePosition = 1
        UltraGridColumn125.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(121, 0)
        UltraGridColumn126.Header.VisiblePosition = 2
        UltraGridBand30.Columns.AddRange(New Object() {UltraGridColumn124, UltraGridColumn125, UltraGridColumn126})
        UltraGridBand30.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand30.UseRowLayout = True
        Me.Tmp_dgMaca.DisplayLayout.BandsSerializer.Add(UltraGridBand30)
        Me.Tmp_dgMaca.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgMaca.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgMaca.DisplayLayout.Override.CardAreaAppearance = Appearance114
        Me.Tmp_dgMaca.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance115.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance115.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance115.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance115.ForeColor = System.Drawing.Color.Black
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance115.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgMaca.DisplayLayout.Override.HeaderAppearance = Appearance115
        Me.Tmp_dgMaca.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance116.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgMaca.DisplayLayout.Override.RowAppearance = Appearance116
        Appearance117.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance117.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance117.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgMaca.DisplayLayout.Override.RowSelectorAppearance = Appearance117
        Me.Tmp_dgMaca.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgMaca.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance118.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance118.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance118.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance118.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgMaca.DisplayLayout.Override.SelectedRowAppearance = Appearance118
        Me.Tmp_dgMaca.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgMaca.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgMaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgMaca.Location = New System.Drawing.Point(0, 0)
        Me.Tmp_dgMaca.Name = "Tmp_dgMaca"
        Me.Tmp_dgMaca.Size = New System.Drawing.Size(736, 481)
        Me.Tmp_dgMaca.TabIndex = 42
        Me.Tmp_dgMaca.Text = "Mã ca"
        Me.Tmp_dgMaca.Visible = False
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.dgTygia)
        Me.UltraTabPageControl6.Controls.Add(Me.Tmp_dgTygia)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(790, 519)
        '
        'dgTygia
        '
        Me.dgTygia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTygia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance119.BackColor = System.Drawing.Color.White
        Appearance119.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance119.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTygia.DisplayLayout.Appearance = Appearance119
        UltraGridColumn127.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn127.Format = "dd/MM/yyyy"
        UltraGridColumn127.Header.Caption = "Ngày"
        UltraGridColumn127.Header.VisiblePosition = 0
        UltraGridColumn128.Header.Caption = "Tỷ Giá"
        UltraGridColumn128.Header.VisiblePosition = 1
        UltraGridColumn128.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn128.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn128.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn128.MaskInput = "n,nnn,nnn,nnn"
        UltraGridBand31.Columns.AddRange(New Object() {UltraGridColumn127, UltraGridColumn128})
        UltraGridBand31.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand31.UseRowLayout = True
        Me.dgTygia.DisplayLayout.BandsSerializer.Add(UltraGridBand31)
        Me.dgTygia.DisplayLayout.InterBandSpacing = 10
        Me.dgTygia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Me.dgTygia.DisplayLayout.Override.CardAreaAppearance = Appearance120
        Me.dgTygia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance121.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance121.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance121.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance121.ForeColor = System.Drawing.Color.Black
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance121.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTygia.DisplayLayout.Override.HeaderAppearance = Appearance121
        Me.dgTygia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance122.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTygia.DisplayLayout.Override.RowAppearance = Appearance122
        Appearance123.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance123.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance123.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgTygia.DisplayLayout.Override.RowSelectorAppearance = Appearance123
        Me.dgTygia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTygia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance124.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance124.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance124.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance124.ForeColor = System.Drawing.Color.Black
        Me.dgTygia.DisplayLayout.Override.SelectedRowAppearance = Appearance124
        Me.dgTygia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTygia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTygia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTygia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTygia.Location = New System.Drawing.Point(0, 0)
        Me.dgTygia.Name = "dgTygia"
        Me.dgTygia.Size = New System.Drawing.Size(790, 519)
        Me.dgTygia.TabIndex = 5
        Me.dgTygia.Text = "Tỷ giá"
        '
        'Tmp_dgTygia
        '
        Me.Tmp_dgTygia.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tmp_dgTygia.DisplayLayout.AddNewBox.Prompt = " "
        Appearance125.BackColor = System.Drawing.Color.White
        Appearance125.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance125.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.Tmp_dgTygia.DisplayLayout.Appearance = Appearance125
        UltraGridColumn129.Format = "dd/MM/yyyy"
        UltraGridColumn129.Header.Caption = "Ngày"
        UltraGridColumn129.Header.VisiblePosition = 0
        UltraGridColumn130.Header.Caption = "Tỷ giá"
        UltraGridColumn130.Header.VisiblePosition = 1
        UltraGridBand32.Columns.AddRange(New Object() {UltraGridColumn129, UltraGridColumn130})
        UltraGridBand32.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand32.UseRowLayout = True
        Me.Tmp_dgTygia.DisplayLayout.BandsSerializer.Add(UltraGridBand32)
        Me.Tmp_dgTygia.DisplayLayout.InterBandSpacing = 10
        Me.Tmp_dgTygia.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Me.Tmp_dgTygia.DisplayLayout.Override.CardAreaAppearance = Appearance126
        Me.Tmp_dgTygia.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance127.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance127.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance127.ForeColor = System.Drawing.Color.Black
        Appearance127.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance127.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.Tmp_dgTygia.DisplayLayout.Override.HeaderAppearance = Appearance127
        Me.Tmp_dgTygia.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance128.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgTygia.DisplayLayout.Override.RowAppearance = Appearance128
        Appearance129.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance129.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.Tmp_dgTygia.DisplayLayout.Override.RowSelectorAppearance = Appearance129
        Me.Tmp_dgTygia.DisplayLayout.Override.RowSelectorWidth = 12
        Me.Tmp_dgTygia.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance130.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance130.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance130.ForeColor = System.Drawing.Color.Black
        Me.Tmp_dgTygia.DisplayLayout.Override.SelectedRowAppearance = Appearance130
        Me.Tmp_dgTygia.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.Tmp_dgTygia.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.Tmp_dgTygia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tmp_dgTygia.Location = New System.Drawing.Point(0, 112)
        Me.Tmp_dgTygia.Name = "Tmp_dgTygia"
        Me.Tmp_dgTygia.Size = New System.Drawing.Size(790, 400)
        Me.Tmp_dgTygia.TabIndex = 6
        Me.Tmp_dgTygia.Text = "Tỷ giá"
        Me.Tmp_dgTygia.Visible = False
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.dgKhachhang)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(790, 519)
        '
        'dgKhachhang
        '
        Me.dgKhachhang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgKhachhang.DisplayLayout.AddNewBox.Prompt = " "
        Appearance131.BackColor = System.Drawing.Color.White
        Appearance131.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgKhachhang.DisplayLayout.Appearance = Appearance131
        UltraGridColumn131.Header.Caption = "Mã KH"
        UltraGridColumn131.Header.VisiblePosition = 0
        UltraGridColumn132.Header.Caption = "Tên KH"
        UltraGridColumn132.Header.VisiblePosition = 1
        UltraGridColumn132.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(124, 0)
        UltraGridColumn133.Format = "dd/MM/yyyy"
        UltraGridColumn133.Header.Caption = "Ngày Khởi Tạo"
        UltraGridColumn133.Header.VisiblePosition = 2
        UltraGridColumn134.Format = "dd/MM/yyyy"
        UltraGridColumn134.Header.Caption = "Ngày Kết Thúc"
        UltraGridColumn134.Header.VisiblePosition = 3
        UltraGridColumn135.Header.Caption = "Điện Thoại"
        UltraGridColumn135.Header.VisiblePosition = 4
        UltraGridColumn136.Header.VisiblePosition = 5
        UltraGridColumn137.Header.VisiblePosition = 6
        UltraGridColumn138.Header.Caption = "Địa Chỉ"
        UltraGridColumn138.Header.VisiblePosition = 7
        UltraGridColumn139.Header.Caption = "Mã Số Thuế"
        UltraGridColumn139.Header.VisiblePosition = 8
        UltraGridColumn140.Header.VisiblePosition = 9
        UltraGridColumn141.Header.Caption = "KH Toàn Quốc"
        UltraGridColumn141.Header.VisiblePosition = 10
        UltraGridColumn142.Header.Caption = "Truyền Khai Thác"
        UltraGridColumn142.Header.VisiblePosition = 11
        UltraGridBand33.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142})
        UltraGridBand33.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand33.UseRowLayout = True
        Me.dgKhachhang.DisplayLayout.BandsSerializer.Add(UltraGridBand33)
        Me.dgKhachhang.DisplayLayout.InterBandSpacing = 10
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Me.dgKhachhang.DisplayLayout.Override.CardAreaAppearance = Appearance132
        Me.dgKhachhang.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance133.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance133.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance133.ForeColor = System.Drawing.Color.Black
        Appearance133.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance133.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgKhachhang.DisplayLayout.Override.HeaderAppearance = Appearance133
        Me.dgKhachhang.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance134.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgKhachhang.DisplayLayout.Override.RowAppearance = Appearance134
        Appearance135.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance135.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgKhachhang.DisplayLayout.Override.RowSelectorAppearance = Appearance135
        Me.dgKhachhang.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgKhachhang.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance136.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance136.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance136.ForeColor = System.Drawing.Color.Black
        Me.dgKhachhang.DisplayLayout.Override.SelectedRowAppearance = Appearance136
        Me.dgKhachhang.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgKhachhang.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgKhachhang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgKhachhang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgKhachhang.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgKhachhang.Location = New System.Drawing.Point(0, 0)
        Me.dgKhachhang.Name = "dgKhachhang"
        Me.dgKhachhang.Size = New System.Drawing.Size(790, 519)
        Me.dgKhachhang.TabIndex = 6
        Me.dgKhachhang.Text = "Khách hàng"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.dgQuay)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(790, 519)
        '
        'dgQuay
        '
        Me.dgQuay.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgQuay.DisplayLayout.AddNewBox.Prompt = " "
        Appearance137.BackColor = System.Drawing.Color.White
        Appearance137.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgQuay.DisplayLayout.Appearance = Appearance137
        UltraGridColumn143.Header.Caption = "Mã Quầy"
        UltraGridColumn143.Header.VisiblePosition = 0
        UltraGridColumn144.Header.Caption = "Tên Quầy"
        UltraGridColumn144.Header.VisiblePosition = 1
        UltraGridColumn145.Header.Caption = "Điện Thoại"
        UltraGridColumn145.Header.VisiblePosition = 2
        UltraGridBand34.Columns.AddRange(New Object() {UltraGridColumn143, UltraGridColumn144, UltraGridColumn145})
        UltraGridBand34.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand34.UseRowLayout = True
        Me.dgQuay.DisplayLayout.BandsSerializer.Add(UltraGridBand34)
        Me.dgQuay.DisplayLayout.InterBandSpacing = 10
        Me.dgQuay.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Me.dgQuay.DisplayLayout.Override.CardAreaAppearance = Appearance138
        Me.dgQuay.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance139.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance139.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance139.ForeColor = System.Drawing.Color.Black
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance139.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgQuay.DisplayLayout.Override.HeaderAppearance = Appearance139
        Me.dgQuay.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance140.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgQuay.DisplayLayout.Override.RowAppearance = Appearance140
        Appearance141.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance141.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgQuay.DisplayLayout.Override.RowSelectorAppearance = Appearance141
        Me.dgQuay.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgQuay.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance142.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance142.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance142.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance142.ForeColor = System.Drawing.Color.Black
        Me.dgQuay.DisplayLayout.Override.SelectedRowAppearance = Appearance142
        Me.dgQuay.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgQuay.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgQuay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQuay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgQuay.Location = New System.Drawing.Point(0, 0)
        Me.dgQuay.Name = "dgQuay"
        Me.dgQuay.Size = New System.Drawing.Size(790, 519)
        Me.dgQuay.TabIndex = 6
        Me.dgQuay.Text = "Quầy"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.ddKenhTruyen)
        Me.UltraTabPageControl10.Controls.Add(Me.dgNoiBo)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(1, 64)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(790, 519)
        '
        'ddKenhTruyen
        '
        Me.ddKenhTruyen.Cursor = System.Windows.Forms.Cursors.Default
        Appearance143.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddKenhTruyen.DisplayLayout.Appearance = Appearance143
        UltraGridColumn146.Header.Caption = "Kênh Truyền"
        UltraGridColumn146.Header.VisiblePosition = 0
        UltraGridColumn147.Header.Caption = "Tên Kênh Truyền"
        UltraGridColumn147.Header.VisiblePosition = 1
        UltraGridBand35.Columns.AddRange(New Object() {UltraGridColumn146, UltraGridColumn147})
        UltraGridBand35.UseRowLayout = True
        Me.ddKenhTruyen.DisplayLayout.BandsSerializer.Add(UltraGridBand35)
        Appearance144.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance144.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance144.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance144.ForeColor = System.Drawing.Color.Black
        Appearance144.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddKenhTruyen.DisplayLayout.Override.HeaderAppearance = Appearance144
        Me.ddKenhTruyen.DisplayMember = "Ten_Kenh_Truyen"
        Me.ddKenhTruyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddKenhTruyen.Location = New System.Drawing.Point(200, 144)
        Me.ddKenhTruyen.Name = "ddKenhTruyen"
        Me.ddKenhTruyen.Size = New System.Drawing.Size(200, 128)
        Me.ddKenhTruyen.TabIndex = 43
        Me.ddKenhTruyen.ValueMember = "Kenh_Truyen"
        Me.ddKenhTruyen.Visible = False
        '
        'dgNoiBo
        '
        Me.dgNoiBo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgNoiBo.DisplayLayout.AddNewBox.Prompt = " "
        Appearance145.BackColor = System.Drawing.Color.White
        Appearance145.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance145.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgNoiBo.DisplayLayout.Appearance = Appearance145
        UltraGridColumn148.Header.VisiblePosition = 0
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.Caption = "Khối Lượng E1 Tối Đa"
        UltraGridColumn149.Header.VisiblePosition = 1
        UltraGridColumn149.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn149.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn149.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn149.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn150.Header.Caption = "Số Ngày E1 Được Phép Trùng"
        UltraGridColumn150.Header.VisiblePosition = 2
        UltraGridColumn150.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn150.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn150.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn150.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn151.Header.Caption = "Số Ngày Trễ Nhập Báo Phát"
        UltraGridColumn151.Header.VisiblePosition = 3
        UltraGridColumn151.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn151.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn151.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn151.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn152.Header.Caption = "Khối Lượng Vỏ Túi Mặc Định"
        UltraGridColumn152.Header.VisiblePosition = 4
        UltraGridColumn152.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn152.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn152.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn152.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn153.Header.Caption = "Cho Phép Nhập Báo Phát Không Có Thông Tin E1"
        UltraGridColumn153.Header.VisiblePosition = 5
        UltraGridColumn153.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn153.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn153.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn153.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn154.Header.Caption = "Sử Dụng Kênh Truyền"
        UltraGridColumn154.Header.VisiblePosition = 6
        UltraGridColumn154.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn154.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn154.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn154.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn155.Header.Caption = "Mã Tỉnh Hiện Tại"
        UltraGridColumn155.Header.VisiblePosition = 7
        UltraGridColumn155.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn155.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn155.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn155.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn156.Header.Caption = "Số Tiền E1 Không Vượt Quá"
        UltraGridColumn156.Header.VisiblePosition = 8
        UltraGridColumn156.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn156.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn156.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn156.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn157.Header.Caption = "IP Máy Center"
        UltraGridColumn157.Header.VisiblePosition = 9
        UltraGridColumn157.Hidden = True
        UltraGridColumn157.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn157.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn157.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn157.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn158.Header.VisiblePosition = 10
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.Caption = "Phiên Bản"
        UltraGridColumn159.Header.VisiblePosition = 11
        UltraGridColumn159.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn159.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn159.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn159.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn160.Header.Caption = "Tên đơn vị"
        UltraGridColumn160.Header.VisiblePosition = 12
        UltraGridColumn160.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn160.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn160.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn160.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn161.Header.Caption = "Địa chỉ đơn vị"
        UltraGridColumn161.Header.VisiblePosition = 13
        UltraGridColumn161.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn161.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn161.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn161.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn162.Header.Caption = "Điện thoại"
        UltraGridColumn162.Header.VisiblePosition = 14
        UltraGridColumn162.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn162.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn162.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn162.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn163.Header.Caption = "Mã đơn vị"
        UltraGridColumn163.Header.VisiblePosition = 15
        UltraGridColumn163.Hidden = True
        UltraGridColumn163.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn163.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn163.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn163.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand36.Columns.AddRange(New Object() {UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163})
        UltraGridBand36.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand36.UseRowLayout = True
        Me.dgNoiBo.DisplayLayout.BandsSerializer.Add(UltraGridBand36)
        Me.dgNoiBo.DisplayLayout.InterBandSpacing = 10
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Me.dgNoiBo.DisplayLayout.Override.CardAreaAppearance = Appearance146
        Me.dgNoiBo.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance147.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance147.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance147.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance147.ForeColor = System.Drawing.Color.Black
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance147.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgNoiBo.DisplayLayout.Override.HeaderAppearance = Appearance147
        Me.dgNoiBo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance148.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNoiBo.DisplayLayout.Override.RowAppearance = Appearance148
        Appearance149.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance149.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance149.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgNoiBo.DisplayLayout.Override.RowSelectorAppearance = Appearance149
        Me.dgNoiBo.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgNoiBo.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance150.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance150.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance150.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance150.ForeColor = System.Drawing.Color.Black
        Me.dgNoiBo.DisplayLayout.Override.SelectedRowAppearance = Appearance150
        Me.dgNoiBo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgNoiBo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgNoiBo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgNoiBo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgNoiBo.Location = New System.Drawing.Point(0, 0)
        Me.dgNoiBo.Name = "dgNoiBo"
        Me.dgNoiBo.Size = New System.Drawing.Size(790, 519)
        Me.dgNoiBo.TabIndex = 8
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.ddPhanLoaiDV)
        Me.UltraTabPageControl12.Controls.Add(Me.dgDichVu)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(790, 519)
        '
        'ddPhanLoaiDV
        '
        Me.ddPhanLoaiDV.Cursor = System.Windows.Forms.Cursors.Default
        Appearance151.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhanLoaiDV.DisplayLayout.Appearance = Appearance151
        UltraGridColumn164.Header.VisiblePosition = 0
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.Caption = "Phân Loại"
        UltraGridColumn165.Header.VisiblePosition = 1
        UltraGridColumn165.Width = 141
        UltraGridBand37.Columns.AddRange(New Object() {UltraGridColumn164, UltraGridColumn165})
        Me.ddPhanLoaiDV.DisplayLayout.BandsSerializer.Add(UltraGridBand37)
        Appearance152.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance152.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance152.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance152.ForeColor = System.Drawing.Color.Black
        Appearance152.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhanLoaiDV.DisplayLayout.Override.HeaderAppearance = Appearance152
        Me.ddPhanLoaiDV.DisplayMember = "Phan_Loai"
        Me.ddPhanLoaiDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhanLoaiDV.Location = New System.Drawing.Point(200, 96)
        Me.ddPhanLoaiDV.Name = "ddPhanLoaiDV"
        Me.ddPhanLoaiDV.Size = New System.Drawing.Size(144, 128)
        Me.ddPhanLoaiDV.TabIndex = 41
        Me.ddPhanLoaiDV.ValueMember = "Id"
        Me.ddPhanLoaiDV.Visible = False
        '
        'dgDichVu
        '
        Me.dgDichVu.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgDichVu.DisplayLayout.AddNewBox.Prompt = " "
        Appearance153.BackColor = System.Drawing.Color.White
        Appearance153.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance153.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDichVu.DisplayLayout.Appearance = Appearance153
        UltraGridColumn166.Header.Caption = "Mã Dịch Vụ"
        UltraGridColumn166.Header.VisiblePosition = 0
        UltraGridColumn167.Header.Caption = "Tên Dịch Vụ"
        UltraGridColumn167.Header.VisiblePosition = 1
        UltraGridColumn168.Header.Caption = "Phân Loại"
        UltraGridColumn168.Header.VisiblePosition = 2
        UltraGridColumn168.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(141, 0)
        UltraGridBand38.Columns.AddRange(New Object() {UltraGridColumn166, UltraGridColumn167, UltraGridColumn168})
        UltraGridBand38.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand38.UseRowLayout = True
        Me.dgDichVu.DisplayLayout.BandsSerializer.Add(UltraGridBand38)
        Me.dgDichVu.DisplayLayout.InterBandSpacing = 10
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Me.dgDichVu.DisplayLayout.Override.CardAreaAppearance = Appearance154
        Me.dgDichVu.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance155.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance155.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance155.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance155.ForeColor = System.Drawing.Color.Black
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance155.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDichVu.DisplayLayout.Override.HeaderAppearance = Appearance155
        Me.dgDichVu.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance156.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDichVu.DisplayLayout.Override.RowAppearance = Appearance156
        Appearance157.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance157.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance157.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDichVu.DisplayLayout.Override.RowSelectorAppearance = Appearance157
        Me.dgDichVu.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDichVu.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance158.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance158.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance158.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance158.ForeColor = System.Drawing.Color.Black
        Me.dgDichVu.DisplayLayout.Override.SelectedRowAppearance = Appearance158
        Me.dgDichVu.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDichVu.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDichVu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDichVu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDichVu.Location = New System.Drawing.Point(0, 0)
        Me.dgDichVu.Name = "dgDichVu"
        Me.dgDichVu.Size = New System.Drawing.Size(790, 519)
        Me.dgDichVu.TabIndex = 7
        Me.dgDichVu.Text = "Dịch vụ"
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.dgQuanLy)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(790, 519)
        '
        'dgQuanLy
        '
        Me.dgQuanLy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgQuanLy.DisplayLayout.AddNewBox.Prompt = " "
        Appearance159.BackColor = System.Drawing.Color.White
        Appearance159.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance159.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgQuanLy.DisplayLayout.Appearance = Appearance159
        UltraGridColumn169.Header.Caption = "Mã Quản Lý"
        UltraGridColumn169.Header.VisiblePosition = 0
        UltraGridColumn170.Header.Caption = "Tên Quản Lý"
        UltraGridColumn170.Header.VisiblePosition = 1
        UltraGridBand39.Columns.AddRange(New Object() {UltraGridColumn169, UltraGridColumn170})
        UltraGridBand39.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand39.UseRowLayout = True
        Me.dgQuanLy.DisplayLayout.BandsSerializer.Add(UltraGridBand39)
        Me.dgQuanLy.DisplayLayout.InterBandSpacing = 10
        Me.dgQuanLy.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Me.dgQuanLy.DisplayLayout.Override.CardAreaAppearance = Appearance160
        Me.dgQuanLy.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance161.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance161.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance161.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance161.ForeColor = System.Drawing.Color.Black
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance161.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgQuanLy.DisplayLayout.Override.HeaderAppearance = Appearance161
        Me.dgQuanLy.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance162.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgQuanLy.DisplayLayout.Override.RowAppearance = Appearance162
        Appearance163.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance163.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance163.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgQuanLy.DisplayLayout.Override.RowSelectorAppearance = Appearance163
        Me.dgQuanLy.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgQuanLy.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance164.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance164.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance164.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance164.ForeColor = System.Drawing.Color.Black
        Me.dgQuanLy.DisplayLayout.Override.SelectedRowAppearance = Appearance164
        Me.dgQuanLy.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgQuanLy.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgQuanLy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQuanLy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgQuanLy.Location = New System.Drawing.Point(0, 0)
        Me.dgQuanLy.Name = "dgQuanLy"
        Me.dgQuanLy.Size = New System.Drawing.Size(790, 519)
        Me.dgQuanLy.TabIndex = 7
        Me.dgQuanLy.Text = "Quản Lý"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.dgMaNuoc)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(790, 519)
        '
        'dgMaNuoc
        '
        Me.dgMaNuoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMaNuoc.DisplayLayout.AddNewBox.Prompt = " "
        Appearance165.BackColor = System.Drawing.Color.White
        Appearance165.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMaNuoc.DisplayLayout.Appearance = Appearance165
        UltraGridColumn171.Header.Caption = "Mã Nước"
        UltraGridColumn171.Header.VisiblePosition = 0
        UltraGridColumn172.Header.Caption = "Tên Nước"
        UltraGridColumn172.Header.VisiblePosition = 1
        UltraGridColumn173.DefaultCellValue = "UPU"
        UltraGridColumn173.Header.Caption = "Mã Khu Vực"
        UltraGridColumn173.Header.VisiblePosition = 2
        UltraGridBand40.Columns.AddRange(New Object() {UltraGridColumn171, UltraGridColumn172, UltraGridColumn173})
        UltraGridBand40.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand40.UseRowLayout = True
        Me.dgMaNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand40)
        Me.dgMaNuoc.DisplayLayout.InterBandSpacing = 10
        Me.dgMaNuoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance166.BackColor = System.Drawing.Color.Transparent
        Me.dgMaNuoc.DisplayLayout.Override.CardAreaAppearance = Appearance166
        Me.dgMaNuoc.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance167.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance167.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance167.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance167.ForeColor = System.Drawing.Color.Black
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance167.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMaNuoc.DisplayLayout.Override.HeaderAppearance = Appearance167
        Me.dgMaNuoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance168.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaNuoc.DisplayLayout.Override.RowAppearance = Appearance168
        Appearance169.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance169.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance169.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMaNuoc.DisplayLayout.Override.RowSelectorAppearance = Appearance169
        Me.dgMaNuoc.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMaNuoc.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance170.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance170.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance170.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance170.ForeColor = System.Drawing.Color.Black
        Me.dgMaNuoc.DisplayLayout.Override.SelectedRowAppearance = Appearance170
        Me.dgMaNuoc.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaNuoc.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMaNuoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaNuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMaNuoc.Location = New System.Drawing.Point(0, 0)
        Me.dgMaNuoc.Name = "dgMaNuoc"
        Me.dgMaNuoc.Size = New System.Drawing.Size(790, 519)
        Me.dgMaNuoc.TabIndex = 7
        Me.dgMaNuoc.Text = "Mã Nước"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.dgMaTinh)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(790, 519)
        '
        'dgMaTinh
        '
        Me.dgMaTinh.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMaTinh.DisplayLayout.AddNewBox.Prompt = " "
        Appearance171.BackColor = System.Drawing.Color.White
        Appearance171.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMaTinh.DisplayLayout.Appearance = Appearance171
        UltraGridColumn174.Header.Caption = "Mã Tỉnh"
        UltraGridColumn174.Header.VisiblePosition = 0
        UltraGridColumn174.MaskInput = "999999"
        UltraGridColumn175.Header.Caption = "Tên Tỉnh"
        UltraGridColumn175.Header.VisiblePosition = 1
        UltraGridColumn176.Header.Caption = "Khu Vực"
        UltraGridColumn176.Header.VisiblePosition = 2
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.Caption = "Thoả Thuận"
        UltraGridColumn177.Header.VisiblePosition = 3
        UltraGridBand41.Columns.AddRange(New Object() {UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177})
        UltraGridBand41.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand41.UseRowLayout = True
        Me.dgMaTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand41)
        Me.dgMaTinh.DisplayLayout.InterBandSpacing = 10
        Me.dgMaTinh.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Me.dgMaTinh.DisplayLayout.Override.CardAreaAppearance = Appearance172
        Me.dgMaTinh.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance173.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance173.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance173.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance173.ForeColor = System.Drawing.Color.Black
        Appearance173.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance173.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMaTinh.DisplayLayout.Override.HeaderAppearance = Appearance173
        Me.dgMaTinh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance174.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaTinh.DisplayLayout.Override.RowAppearance = Appearance174
        Appearance175.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance175.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance175.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMaTinh.DisplayLayout.Override.RowSelectorAppearance = Appearance175
        Me.dgMaTinh.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMaTinh.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance176.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance176.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance176.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance176.ForeColor = System.Drawing.Color.Black
        Me.dgMaTinh.DisplayLayout.Override.SelectedRowAppearance = Appearance176
        Me.dgMaTinh.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMaTinh.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMaTinh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMaTinh.Location = New System.Drawing.Point(0, 0)
        Me.dgMaTinh.Name = "dgMaTinh"
        Me.dgMaTinh.Size = New System.Drawing.Size(790, 519)
        Me.dgMaTinh.TabIndex = 7
        Me.dgMaTinh.Text = "Mã Tỉnh"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.btnLoad)
        Me.UltraTabPageControl17.Controls.Add(Me.optTat_Ca)
        Me.UltraTabPageControl17.Controls.Add(Me.optKhong_Su_Dung)
        Me.UltraTabPageControl17.Controls.Add(Me.optSu_Dung)
        Me.UltraTabPageControl17.Controls.Add(Me.ddSo_Chang)
        Me.UltraTabPageControl17.Controls.Add(Me.ddMa_Bc_Qua_Giang)
        Me.UltraTabPageControl17.Controls.Add(Me.ddDM_IPMC)
        Me.UltraTabPageControl17.Controls.Add(Me.ddDuongThu)
        Me.UltraTabPageControl17.Controls.Add(Me.dgDanhMucDuongBay)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(790, 519)
        '
        'btnLoad
        '
        Appearance177.Image = CType(resources.GetObject("Appearance177.Image"), Object)
        Me.btnLoad.Appearance = Appearance177
        Me.btnLoad.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLoad.Location = New System.Drawing.Point(664, 8)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 32)
        Me.btnLoad.TabIndex = 48
        Me.btnLoad.Text = "Reload"
        '
        'optTat_Ca
        '
        Me.optTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTat_Ca.Location = New System.Drawing.Point(456, 12)
        Me.optTat_Ca.Name = "optTat_Ca"
        Me.optTat_Ca.Size = New System.Drawing.Size(128, 24)
        Me.optTat_Ca.TabIndex = 47
        Me.optTat_Ca.Text = "Cả 2 loại "
        '
        'optKhong_Su_Dung
        '
        Me.optKhong_Su_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optKhong_Su_Dung.Location = New System.Drawing.Point(224, 12)
        Me.optKhong_Su_Dung.Name = "optKhong_Su_Dung"
        Me.optKhong_Su_Dung.Size = New System.Drawing.Size(184, 24)
        Me.optKhong_Su_Dung.TabIndex = 46
        Me.optKhong_Su_Dung.Text = "Đường bay không sử dụng"
        '
        'optSu_Dung
        '
        Me.optSu_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSu_Dung.Location = New System.Drawing.Point(8, 12)
        Me.optSu_Dung.Name = "optSu_Dung"
        Me.optSu_Dung.Size = New System.Drawing.Size(184, 24)
        Me.optSu_Dung.TabIndex = 45
        Me.optSu_Dung.Text = "Đường bay đang sử dụng"
        '
        'ddSo_Chang
        '
        Me.ddSo_Chang.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance178.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddSo_Chang.DisplayLayout.Appearance = Appearance178
        UltraGridColumn178.Header.Caption = "Số chặng"
        UltraGridColumn178.Header.VisiblePosition = 0
        UltraGridBand42.Columns.AddRange(New Object() {UltraGridColumn178})
        Me.ddSo_Chang.DisplayLayout.BandsSerializer.Add(UltraGridBand42)
        Appearance179.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance179.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance179.ForeColor = System.Drawing.Color.Black
        Appearance179.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddSo_Chang.DisplayLayout.Override.HeaderAppearance = Appearance179
        Me.ddSo_Chang.DisplayMember = ""
        Me.ddSo_Chang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddSo_Chang.Location = New System.Drawing.Point(584, 248)
        Me.ddSo_Chang.Name = "ddSo_Chang"
        Me.ddSo_Chang.Size = New System.Drawing.Size(104, 128)
        Me.ddSo_Chang.TabIndex = 44
        Me.ddSo_Chang.ValueMember = ""
        Me.ddSo_Chang.Visible = False
        '
        'ddMa_Bc_Qua_Giang
        '
        Me.ddMa_Bc_Qua_Giang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ddMa_Bc_Qua_Giang.DataSource = Me.UltraDataSource10
        Appearance180.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Bc_Qua_Giang.DisplayLayout.Appearance = Appearance180
        UltraGridColumn179.Header.Caption = "Mã BC"
        UltraGridColumn179.Header.VisiblePosition = 1
        UltraGridColumn180.Header.Caption = "Mã chữ"
        UltraGridColumn180.Header.VisiblePosition = 2
        UltraGridColumn181.Header.Caption = "Tên Bc"
        UltraGridColumn181.Header.VisiblePosition = 0
        UltraGridBand43.Columns.AddRange(New Object() {UltraGridColumn179, UltraGridColumn180, UltraGridColumn181})
        Me.ddMa_Bc_Qua_Giang.DisplayLayout.BandsSerializer.Add(UltraGridBand43)
        Appearance181.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance181.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance181.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance181.ForeColor = System.Drawing.Color.Black
        Appearance181.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Bc_Qua_Giang.DisplayLayout.Override.HeaderAppearance = Appearance181
        Me.ddMa_Bc_Qua_Giang.DisplayMember = "IPMC"
        Me.ddMa_Bc_Qua_Giang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Bc_Qua_Giang.Location = New System.Drawing.Point(291, 195)
        Me.ddMa_Bc_Qua_Giang.Name = "ddMa_Bc_Qua_Giang"
        Me.ddMa_Bc_Qua_Giang.Size = New System.Drawing.Size(208, 128)
        Me.ddMa_Bc_Qua_Giang.TabIndex = 43
        Me.ddMa_Bc_Qua_Giang.ValueMember = "Ma_Bc"
        Me.ddMa_Bc_Qua_Giang.Visible = False
        '
        'UltraDataSource10
        '
        Me.UltraDataSource10.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        Me.UltraDataSource10.Band.Key = "Ma_Bc_Qua_Giang"
        '
        'ddDM_IPMC
        '
        Me.ddDM_IPMC.Cursor = System.Windows.Forms.Cursors.Default
        Me.ddDM_IPMC.DataSource = Me.UltraDataSource6
        Appearance182.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDM_IPMC.DisplayLayout.Appearance = Appearance182
        UltraGridColumn182.Header.Caption = "Mã BC"
        UltraGridColumn182.Header.VisiblePosition = 0
        UltraGridColumn183.Header.Caption = "Mã BC chữ"
        UltraGridColumn183.Header.VisiblePosition = 1
        UltraGridColumn184.Header.Caption = "Mã Tỉnh"
        UltraGridColumn184.Header.VisiblePosition = 3
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.Caption = "Tên Bưu cục"
        UltraGridColumn185.Header.VisiblePosition = 2
        UltraGridBand44.Columns.AddRange(New Object() {UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185})
        Me.ddDM_IPMC.DisplayLayout.BandsSerializer.Add(UltraGridBand44)
        Appearance183.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance183.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance183.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance183.ForeColor = System.Drawing.Color.Black
        Appearance183.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDM_IPMC.DisplayLayout.Override.HeaderAppearance = Appearance183
        Me.ddDM_IPMC.DisplayMember = ""
        Me.ddDM_IPMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDM_IPMC.Location = New System.Drawing.Point(368, 128)
        Me.ddDM_IPMC.Name = "ddDM_IPMC"
        Me.ddDM_IPMC.Size = New System.Drawing.Size(208, 128)
        Me.ddDM_IPMC.TabIndex = 42
        Me.ddDM_IPMC.ValueMember = "IPMC"
        Me.ddDM_IPMC.Visible = False
        '
        'UltraDataSource6
        '
        Me.UltraDataSource6.Band.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
        Me.UltraDataSource6.Band.Key = "Dm_Bc"
        '
        'ddDuongThu
        '
        Me.ddDuongThu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ddDuongThu.DataSource = Me.UltraDataSource4
        Appearance184.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDuongThu.DisplayLayout.Appearance = Appearance184
        UltraGridColumn186.Header.Caption = "Mã đường thư"
        UltraGridColumn186.Header.VisiblePosition = 0
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.Caption = "Tên đường thư"
        UltraGridColumn187.Header.VisiblePosition = 1
        UltraGridColumn188.Header.Caption = "Mã BC khai thác"
        UltraGridColumn188.Header.VisiblePosition = 2
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.Caption = "Mã BC nhận số"
        UltraGridColumn189.Header.VisiblePosition = 3
        UltraGridColumn190.Header.Caption = "Mã bưu cục nhận"
        UltraGridColumn190.Header.VisiblePosition = 4
        UltraGridBand45.Columns.AddRange(New Object() {UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190})
        Me.ddDuongThu.DisplayLayout.BandsSerializer.Add(UltraGridBand45)
        Appearance185.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance185.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance185.ForeColor = System.Drawing.Color.Black
        Appearance185.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDuongThu.DisplayLayout.Override.HeaderAppearance = Appearance185
        Me.ddDuongThu.DisplayMember = "Ma_BC_chu"
        Me.ddDuongThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDuongThu.Location = New System.Drawing.Point(80, 112)
        Me.ddDuongThu.Name = "ddDuongThu"
        Me.ddDuongThu.Size = New System.Drawing.Size(208, 128)
        Me.ddDuongThu.TabIndex = 41
        Me.ddDuongThu.ValueMember = "Ma_Bc"
        Me.ddDuongThu.Visible = False
        '
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        Me.UltraDataSource4.Band.Key = "Dm_Duong_thu"
        '
        'dgDanhMucDuongBay
        '
        Me.dgDanhMucDuongBay.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgDanhMucDuongBay.DisplayLayout.AddNewBox.Prompt = " "
        Appearance186.BackColor = System.Drawing.Color.White
        Appearance186.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanhMucDuongBay.DisplayLayout.Appearance = Appearance186
        UltraGridColumn191.Header.Caption = "Mã đường bay"
        UltraGridColumn191.Header.VisiblePosition = 0
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.Caption = "Mã đường thư"
        UltraGridColumn192.Header.VisiblePosition = 1
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.Caption = "Mã Bưu cục nhận"
        UltraGridColumn193.Header.VisiblePosition = 2
        UltraGridColumn194.DefaultCellValue = "4"
        UltraGridColumn194.Header.Caption = "Loại vận chuyển"
        UltraGridColumn194.Header.VisiblePosition = 3
        UltraGridColumn194.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn195.Header.Caption = "Số hiệu"
        UltraGridColumn195.Header.VisiblePosition = 4
        UltraGridColumn196.DefaultCellValue = ""
        UltraGridColumn196.Header.Caption = "Sân bay chuyển tải"
        UltraGridColumn196.Header.VisiblePosition = 5
        UltraGridColumn197.Header.Caption = "Sân bay dỡ hàng"
        UltraGridColumn197.Header.VisiblePosition = 6
        UltraGridColumn198.Header.Caption = "Bưu cục gửi"
        UltraGridColumn198.Header.VisiblePosition = 7
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.Caption = "Bưu cục nhận"
        UltraGridColumn199.Header.VisiblePosition = 8
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.Caption = "Giờ khởi hành"
        UltraGridColumn200.Header.VisiblePosition = 9
        UltraGridColumn200.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn200.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn200.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn200.MaskInput = "hh:mm"
        UltraGridColumn200.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn201.Header.Caption = "Giờ đến"
        UltraGridColumn201.Header.VisiblePosition = 10
        UltraGridColumn201.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn201.MaskInput = "hh:mm"
        UltraGridColumn201.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(53, 0)
        UltraGridColumn202.DefaultCellValue = "false"
        UltraGridColumn202.Header.Caption = "Quá ngày"
        UltraGridColumn202.Header.VisiblePosition = 11
        UltraGridColumn202.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn202.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn203.DefaultCellValue = "false"
        UltraGridColumn203.Header.Caption = "Quá giang"
        UltraGridColumn203.Header.VisiblePosition = 12
        UltraGridColumn203.Hidden = True
        UltraGridColumn203.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn204.DefaultCellValue = "1"
        UltraGridColumn204.Header.Caption = "Số chặng"
        UltraGridColumn204.Header.VisiblePosition = 13
        UltraGridColumn204.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn205.DefaultCellValue = "1"
        UltraGridColumn205.Header.Caption = "Sử dụng"
        UltraGridColumn205.Header.VisiblePosition = 14
        UltraGridColumn205.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn206.DefaultCellValue = "0"
        UltraGridColumn206.Header.Caption = "Mã Bc Quá Giang"
        UltraGridColumn206.Header.VisiblePosition = 15
        UltraGridBand46.Columns.AddRange(New Object() {UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206})
        UltraGridBand46.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand46.UseRowLayout = True
        Me.dgDanhMucDuongBay.DisplayLayout.BandsSerializer.Add(UltraGridBand46)
        Me.dgDanhMucDuongBay.DisplayLayout.InterBandSpacing = 10
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Me.dgDanhMucDuongBay.DisplayLayout.Override.CardAreaAppearance = Appearance187
        Me.dgDanhMucDuongBay.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance188.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance188.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance188.ForeColor = System.Drawing.Color.Black
        Appearance188.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance188.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanhMucDuongBay.DisplayLayout.Override.HeaderAppearance = Appearance188
        Me.dgDanhMucDuongBay.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance189.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBay.DisplayLayout.Override.RowAppearance = Appearance189
        Appearance190.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance190.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanhMucDuongBay.DisplayLayout.Override.RowSelectorAppearance = Appearance190
        Me.dgDanhMucDuongBay.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanhMucDuongBay.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance191.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance191.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance191.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance191.ForeColor = System.Drawing.Color.Black
        Me.dgDanhMucDuongBay.DisplayLayout.Override.SelectedRowAppearance = Appearance191
        Me.dgDanhMucDuongBay.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBay.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanhMucDuongBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanhMucDuongBay.Location = New System.Drawing.Point(0, 48)
        Me.dgDanhMucDuongBay.Name = "dgDanhMucDuongBay"
        Me.dgDanhMucDuongBay.Size = New System.Drawing.Size(790, 472)
        Me.dgDanhMucDuongBay.TabIndex = 9
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.ddQuy_Luat)
        Me.UltraTabPageControl19.Controls.Add(Me.ddMa_Nuoc_Chuyen_Bay)
        Me.UltraTabPageControl19.Controls.Add(Me.ddSan_Bay)
        Me.UltraTabPageControl19.Controls.Add(Me.dgDanhMucChuyenBay)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(790, 519)
        '
        'ddQuy_Luat
        '
        Me.ddQuy_Luat.Cursor = System.Windows.Forms.Cursors.Default
        Appearance192.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddQuy_Luat.DisplayLayout.Appearance = Appearance192
        UltraGridColumn207.Header.VisiblePosition = 0
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.Caption = "Kiểu thứ"
        UltraGridColumn208.Header.VisiblePosition = 1
        UltraGridBand47.Columns.AddRange(New Object() {UltraGridColumn207, UltraGridColumn208})
        Me.ddQuy_Luat.DisplayLayout.BandsSerializer.Add(UltraGridBand47)
        Appearance193.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance193.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance193.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance193.ForeColor = System.Drawing.Color.Black
        Appearance193.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddQuy_Luat.DisplayLayout.Override.HeaderAppearance = Appearance193
        Me.ddQuy_Luat.DisplayMember = "Ten_Quy_Luat"
        Me.ddQuy_Luat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddQuy_Luat.Location = New System.Drawing.Point(96, 112)
        Me.ddQuy_Luat.Name = "ddQuy_Luat"
        Me.ddQuy_Luat.Size = New System.Drawing.Size(136, 128)
        Me.ddQuy_Luat.TabIndex = 46
        Me.ddQuy_Luat.ValueMember = "Ma_Quy_Luat"
        Me.ddQuy_Luat.Visible = False
        '
        'ddMa_Nuoc_Chuyen_Bay
        '
        Me.ddMa_Nuoc_Chuyen_Bay.Cursor = System.Windows.Forms.Cursors.Default
        Appearance194.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Nuoc_Chuyen_Bay.DisplayLayout.Appearance = Appearance194
        UltraGridColumn209.Header.Caption = "Mã Nước"
        UltraGridColumn209.Header.VisiblePosition = 0
        UltraGridColumn210.Header.Caption = "Tên Nước"
        UltraGridColumn210.Header.VisiblePosition = 1
        UltraGridBand48.Columns.AddRange(New Object() {UltraGridColumn209, UltraGridColumn210})
        Me.ddMa_Nuoc_Chuyen_Bay.DisplayLayout.BandsSerializer.Add(UltraGridBand48)
        Appearance195.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance195.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance195.ForeColor = System.Drawing.Color.Black
        Appearance195.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Nuoc_Chuyen_Bay.DisplayLayout.Override.HeaderAppearance = Appearance195
        Me.ddMa_Nuoc_Chuyen_Bay.DisplayMember = "Ma_Nuoc"
        Me.ddMa_Nuoc_Chuyen_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Nuoc_Chuyen_Bay.Location = New System.Drawing.Point(280, 112)
        Me.ddMa_Nuoc_Chuyen_Bay.Name = "ddMa_Nuoc_Chuyen_Bay"
        Me.ddMa_Nuoc_Chuyen_Bay.Size = New System.Drawing.Size(200, 128)
        Me.ddMa_Nuoc_Chuyen_Bay.TabIndex = 45
        Me.ddMa_Nuoc_Chuyen_Bay.Text = "Mã Nước"
        Me.ddMa_Nuoc_Chuyen_Bay.ValueMember = "Ma_Nuoc"
        Me.ddMa_Nuoc_Chuyen_Bay.Visible = False
        '
        'ddSan_Bay
        '
        Me.ddSan_Bay.Cursor = System.Windows.Forms.Cursors.Default
        Appearance196.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddSan_Bay.DisplayLayout.Appearance = Appearance196
        UltraGridColumn211.Header.Caption = "Mã sân bay"
        UltraGridColumn211.Header.VisiblePosition = 0
        UltraGridColumn212.Header.Caption = "Mã nước"
        UltraGridColumn212.Header.VisiblePosition = 1
        UltraGridBand49.Columns.AddRange(New Object() {UltraGridColumn211, UltraGridColumn212})
        Me.ddSan_Bay.DisplayLayout.BandsSerializer.Add(UltraGridBand49)
        Appearance197.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance197.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance197.ForeColor = System.Drawing.Color.Black
        Appearance197.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddSan_Bay.DisplayLayout.Override.HeaderAppearance = Appearance197
        Me.ddSan_Bay.DisplayMember = "Ma_San_Bay"
        Me.ddSan_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddSan_Bay.Location = New System.Drawing.Point(528, 112)
        Me.ddSan_Bay.Name = "ddSan_Bay"
        Me.ddSan_Bay.Size = New System.Drawing.Size(208, 128)
        Me.ddSan_Bay.TabIndex = 41
        Me.ddSan_Bay.ValueMember = "Ma_San_Bay"
        Me.ddSan_Bay.Visible = False
        '
        'dgDanhMucChuyenBay
        '
        Me.dgDanhMucChuyenBay.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgDanhMucChuyenBay.DisplayLayout.AddNewBox.Prompt = " "
        Appearance198.BackColor = System.Drawing.Color.White
        Appearance198.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance198.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanhMucChuyenBay.DisplayLayout.Appearance = Appearance198
        UltraGridColumn213.Header.VisiblePosition = 0
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.Caption = "Số hiệu"
        UltraGridColumn214.Header.VisiblePosition = 1
        UltraGridColumn214.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn214.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn214.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn214.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn214.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn215.Header.Caption = "Hãng hàng không"
        UltraGridColumn215.Header.VisiblePosition = 2
        UltraGridColumn215.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn215.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn215.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(97, 0)
        UltraGridColumn215.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn215.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn216.Header.Caption = "Nước gửi"
        UltraGridColumn216.Header.VisiblePosition = 3
        UltraGridColumn216.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn216.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn216.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn216.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn216.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn217.Header.Caption = "Sân bay gửi"
        UltraGridColumn217.Header.VisiblePosition = 4
        UltraGridColumn217.MaskInput = ""
        UltraGridColumn217.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn217.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn217.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn217.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn217.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn218.Format = "##:##"
        UltraGridColumn218.Header.Caption = "Giờ xuất phát"
        UltraGridColumn218.Header.VisiblePosition = 5
        UltraGridColumn218.MaskInput = "##:##"
        UltraGridColumn218.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn218.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn218.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn218.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn218.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn219.Header.Caption = "Nước nhận"
        UltraGridColumn219.Header.VisiblePosition = 6
        UltraGridColumn219.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn219.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn219.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn219.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn219.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn220.Format = "hh:mm"
        UltraGridColumn220.Header.Caption = "Sân bay nhận"
        UltraGridColumn220.Header.VisiblePosition = 7
        UltraGridColumn220.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn220.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn220.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn220.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn220.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn221.Format = "##:##"
        UltraGridColumn221.Header.Caption = "Giờ đến"
        UltraGridColumn221.Header.VisiblePosition = 8
        UltraGridColumn221.MaskInput = "##:##"
        UltraGridColumn221.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn221.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn221.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn221.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn221.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn222.Header.Caption = "Quá ngày"
        UltraGridColumn222.Header.VisiblePosition = 9
        UltraGridColumn222.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn222.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn222.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn222.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn222.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn223.Header.Caption = "Ghi chú"
        UltraGridColumn223.Header.VisiblePosition = 10
        UltraGridColumn223.Hidden = True
        UltraGridColumn223.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn223.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn223.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn223.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn224.Header.Caption = "Kiểu thứ"
        UltraGridColumn224.Header.VisiblePosition = 11
        UltraGridColumn224.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn224.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn224.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn224.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn224.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn225.Header.Caption = "Thứ 2"
        UltraGridColumn225.Header.VisiblePosition = 12
        UltraGridColumn225.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn225.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn225.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(43, 0)
        UltraGridColumn225.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn225.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn226.Header.Caption = "Thứ 3"
        UltraGridColumn226.Header.VisiblePosition = 13
        UltraGridColumn226.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn226.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn226.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn226.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn226.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn227.Header.Caption = "Thứ 4"
        UltraGridColumn227.Header.VisiblePosition = 14
        UltraGridColumn227.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn227.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn227.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn227.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn227.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn228.Header.Caption = "Thứ 5"
        UltraGridColumn228.Header.VisiblePosition = 15
        UltraGridColumn228.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn228.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn228.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn228.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn228.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn229.Header.Caption = "Thứ 6"
        UltraGridColumn229.Header.VisiblePosition = 16
        UltraGridColumn229.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn229.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn229.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(42, 0)
        UltraGridColumn229.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn229.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn230.Header.Caption = "Thứ 7"
        UltraGridColumn230.Header.VisiblePosition = 17
        UltraGridColumn230.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn230.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn230.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn230.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn230.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn231.Header.Caption = "Chủ nhật"
        UltraGridColumn231.Header.VisiblePosition = 18
        UltraGridColumn231.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn231.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn231.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn231.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn231.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand50.Columns.AddRange(New Object() {UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231})
        UltraGridBand50.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand50.UseRowLayout = True
        Me.dgDanhMucChuyenBay.DisplayLayout.BandsSerializer.Add(UltraGridBand50)
        Me.dgDanhMucChuyenBay.DisplayLayout.InterBandSpacing = 10
        Appearance199.BackColor = System.Drawing.Color.Transparent
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.CardAreaAppearance = Appearance199
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance200.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance200.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance200.ForeColor = System.Drawing.Color.Black
        Appearance200.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance200.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.HeaderAppearance = Appearance200
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance201.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.RowAppearance = Appearance201
        Appearance202.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance202.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.RowSelectorAppearance = Appearance202
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance203.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance203.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance203.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance203.ForeColor = System.Drawing.Color.Black
        Me.dgDanhMucChuyenBay.DisplayLayout.Override.SelectedRowAppearance = Appearance203
        Me.dgDanhMucChuyenBay.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucChuyenBay.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanhMucChuyenBay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDanhMucChuyenBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanhMucChuyenBay.Location = New System.Drawing.Point(0, 0)
        Me.dgDanhMucChuyenBay.Name = "dgDanhMucChuyenBay"
        Me.dgDanhMucChuyenBay.Size = New System.Drawing.Size(790, 519)
        Me.dgDanhMucChuyenBay.TabIndex = 10
        '
        'UltraTabPageControl20
        '
        Me.UltraTabPageControl20.Controls.Add(Me.dgDanhMucDuongBayTongHop)
        Me.UltraTabPageControl20.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl20.Name = "UltraTabPageControl20"
        Me.UltraTabPageControl20.Size = New System.Drawing.Size(790, 519)
        '
        'dgDanhMucDuongBayTongHop
        '
        Me.dgDanhMucDuongBayTongHop.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.AddNewBox.Prompt = " "
        Appearance204.BackColor = System.Drawing.Color.White
        Appearance204.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance204.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Appearance = Appearance204
        UltraGridColumn232.Header.VisiblePosition = 0
        UltraGridBand51.Columns.AddRange(New Object() {UltraGridColumn232})
        UltraGridBand51.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand51.UseRowLayout = True
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.BandsSerializer.Add(UltraGridBand51)
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.InterBandSpacing = 10
        Appearance205.BackColor = System.Drawing.Color.Transparent
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.CardAreaAppearance = Appearance205
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance206.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance206.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance206.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance206.ForeColor = System.Drawing.Color.Black
        Appearance206.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance206.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.HeaderAppearance = Appearance206
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance207.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.RowAppearance = Appearance207
        Appearance208.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance208.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance208.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.RowSelectorAppearance = Appearance208
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance209.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance209.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance209.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance209.ForeColor = System.Drawing.Color.Black
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.Override.SelectedRowAppearance = Appearance209
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBayTongHop.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanhMucDuongBayTongHop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDanhMucDuongBayTongHop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanhMucDuongBayTongHop.Location = New System.Drawing.Point(0, 0)
        Me.dgDanhMucDuongBayTongHop.Name = "dgDanhMucDuongBayTongHop"
        Me.dgDanhMucDuongBayTongHop.Size = New System.Drawing.Size(790, 519)
        Me.dgDanhMucDuongBayTongHop.TabIndex = 10
        '
        'UltraTabPageControl21
        '
        Me.UltraTabPageControl21.Controls.Add(Me.dgDot_Bay)
        Me.UltraTabPageControl21.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl21.Name = "UltraTabPageControl21"
        Me.UltraTabPageControl21.Size = New System.Drawing.Size(790, 519)
        '
        'dgDot_Bay
        '
        Me.dgDot_Bay.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgDot_Bay.DisplayLayout.AddNewBox.Prompt = " "
        Appearance210.BackColor = System.Drawing.Color.White
        Appearance210.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance210.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDot_Bay.DisplayLayout.Appearance = Appearance210
        UltraGridColumn233.Header.VisiblePosition = 0
        UltraGridBand52.Columns.AddRange(New Object() {UltraGridColumn233})
        UltraGridBand52.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand52.UseRowLayout = True
        Me.dgDot_Bay.DisplayLayout.BandsSerializer.Add(UltraGridBand52)
        Me.dgDot_Bay.DisplayLayout.InterBandSpacing = 10
        Appearance211.BackColor = System.Drawing.Color.Transparent
        Me.dgDot_Bay.DisplayLayout.Override.CardAreaAppearance = Appearance211
        Me.dgDot_Bay.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance212.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance212.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance212.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance212.ForeColor = System.Drawing.Color.Black
        Appearance212.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance212.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDot_Bay.DisplayLayout.Override.HeaderAppearance = Appearance212
        Me.dgDot_Bay.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance213.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDot_Bay.DisplayLayout.Override.RowAppearance = Appearance213
        Appearance214.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance214.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance214.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDot_Bay.DisplayLayout.Override.RowSelectorAppearance = Appearance214
        Me.dgDot_Bay.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDot_Bay.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance215.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance215.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance215.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance215.ForeColor = System.Drawing.Color.Black
        Me.dgDot_Bay.DisplayLayout.Override.SelectedRowAppearance = Appearance215
        Me.dgDot_Bay.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDot_Bay.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDot_Bay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDot_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDot_Bay.Location = New System.Drawing.Point(0, 0)
        Me.dgDot_Bay.Name = "dgDot_Bay"
        Me.dgDot_Bay.Size = New System.Drawing.Size(790, 519)
        Me.dgDot_Bay.TabIndex = 11
        '
        'UltraTabPageControl23
        '
        Me.UltraTabPageControl23.Controls.Add(Me.ddSo_Chang2)
        Me.UltraTabPageControl23.Controls.Add(Me.ddMa_Bc_Qua_Giang2)
        Me.UltraTabPageControl23.Controls.Add(Me.ddDM_IPMC2)
        Me.UltraTabPageControl23.Controls.Add(Me.ddDuongThu2)
        Me.UltraTabPageControl23.Controls.Add(Me.dgDanhMucDuongBayDen)
        Me.UltraTabPageControl23.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl23.Name = "UltraTabPageControl23"
        Me.UltraTabPageControl23.Size = New System.Drawing.Size(790, 519)
        '
        'ddSo_Chang2
        '
        Me.ddSo_Chang2.Cursor = System.Windows.Forms.Cursors.Default
        Appearance216.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddSo_Chang2.DisplayLayout.Appearance = Appearance216
        UltraGridColumn234.Header.Caption = "Số chặng"
        UltraGridColumn234.Header.VisiblePosition = 0
        UltraGridBand53.Columns.AddRange(New Object() {UltraGridColumn234})
        Me.ddSo_Chang2.DisplayLayout.BandsSerializer.Add(UltraGridBand53)
        Appearance217.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance217.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance217.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance217.ForeColor = System.Drawing.Color.Black
        Appearance217.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddSo_Chang2.DisplayLayout.Override.HeaderAppearance = Appearance217
        Me.ddSo_Chang2.DisplayMember = ""
        Me.ddSo_Chang2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddSo_Chang2.Location = New System.Drawing.Point(584, 223)
        Me.ddSo_Chang2.Name = "ddSo_Chang2"
        Me.ddSo_Chang2.Size = New System.Drawing.Size(104, 128)
        Me.ddSo_Chang2.TabIndex = 49
        Me.ddSo_Chang2.ValueMember = ""
        Me.ddSo_Chang2.Visible = False
        '
        'ddMa_Bc_Qua_Giang2
        '
        Me.ddMa_Bc_Qua_Giang2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ddMa_Bc_Qua_Giang2.DataSource = Me.UltraDataSource13
        Appearance218.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Bc_Qua_Giang2.DisplayLayout.Appearance = Appearance218
        UltraGridColumn235.Header.Caption = "Mã chữ"
        UltraGridColumn235.Header.VisiblePosition = 2
        UltraGridColumn236.Header.Caption = "Tên Bc"
        UltraGridColumn236.Header.VisiblePosition = 0
        UltraGridColumn237.Header.Caption = "Mã BC"
        UltraGridColumn237.Header.VisiblePosition = 1
        UltraGridBand54.Columns.AddRange(New Object() {UltraGridColumn235, UltraGridColumn236, UltraGridColumn237})
        Me.ddMa_Bc_Qua_Giang2.DisplayLayout.BandsSerializer.Add(UltraGridBand54)
        Appearance219.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance219.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance219.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance219.ForeColor = System.Drawing.Color.Black
        Appearance219.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Bc_Qua_Giang2.DisplayLayout.Override.HeaderAppearance = Appearance219
        Me.ddMa_Bc_Qua_Giang2.DisplayMember = "IPMC"
        Me.ddMa_Bc_Qua_Giang2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Bc_Qua_Giang2.Location = New System.Drawing.Point(144, 296)
        Me.ddMa_Bc_Qua_Giang2.Name = "ddMa_Bc_Qua_Giang2"
        Me.ddMa_Bc_Qua_Giang2.Size = New System.Drawing.Size(208, 128)
        Me.ddMa_Bc_Qua_Giang2.TabIndex = 48
        Me.ddMa_Bc_Qua_Giang2.ValueMember = "Ma_Bc"
        Me.ddMa_Bc_Qua_Giang2.Visible = False
        '
        'UltraDataSource13
        '
        Me.UltraDataSource13.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        Me.UltraDataSource13.Band.Key = "Ma_Bc_Qua_Giang"
        '
        'ddDM_IPMC2
        '
        Me.ddDM_IPMC2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ddDM_IPMC2.DataSource = Me.UltraDataSource6
        Appearance220.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDM_IPMC2.DisplayLayout.Appearance = Appearance220
        UltraGridColumn238.Header.Caption = "Mã BC"
        UltraGridColumn238.Header.VisiblePosition = 0
        UltraGridColumn239.Header.Caption = "Mã BC chữ"
        UltraGridColumn239.Header.VisiblePosition = 1
        UltraGridColumn240.Header.Caption = "Mã Tỉnh"
        UltraGridColumn240.Header.VisiblePosition = 3
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.Caption = "Tên Bưu cục"
        UltraGridColumn241.Header.VisiblePosition = 2
        UltraGridBand55.Columns.AddRange(New Object() {UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241})
        Me.ddDM_IPMC2.DisplayLayout.BandsSerializer.Add(UltraGridBand55)
        Appearance221.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance221.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance221.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance221.ForeColor = System.Drawing.Color.Black
        Appearance221.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDM_IPMC2.DisplayLayout.Override.HeaderAppearance = Appearance221
        Me.ddDM_IPMC2.DisplayMember = ""
        Me.ddDM_IPMC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDM_IPMC2.Location = New System.Drawing.Point(368, 103)
        Me.ddDM_IPMC2.Name = "ddDM_IPMC2"
        Me.ddDM_IPMC2.Size = New System.Drawing.Size(208, 128)
        Me.ddDM_IPMC2.TabIndex = 47
        Me.ddDM_IPMC2.ValueMember = "IPMC"
        Me.ddDM_IPMC2.Visible = False
        '
        'ddDuongThu2
        '
        Me.ddDuongThu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ddDuongThu2.DataSource = Me.UltraDataSource14
        Appearance222.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDuongThu2.DisplayLayout.Appearance = Appearance222
        UltraGridColumn242.Header.Caption = "Mã đường thư"
        UltraGridColumn242.Header.VisiblePosition = 0
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.Caption = "Mã BC nhận số"
        UltraGridColumn243.Header.VisiblePosition = 3
        UltraGridColumn244.Header.Caption = "Tên đường thư"
        UltraGridColumn244.Header.VisiblePosition = 1
        UltraGridColumn245.Header.Caption = "Mã BC khai thác"
        UltraGridColumn245.Header.VisiblePosition = 2
        UltraGridColumn245.Hidden = True
        UltraGridColumn246.Header.Caption = "Mã bưu cục gửi"
        UltraGridColumn246.Header.VisiblePosition = 4
        UltraGridBand56.Columns.AddRange(New Object() {UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246})
        Me.ddDuongThu2.DisplayLayout.BandsSerializer.Add(UltraGridBand56)
        Appearance223.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance223.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance223.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance223.ForeColor = System.Drawing.Color.Black
        Appearance223.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDuongThu2.DisplayLayout.Override.HeaderAppearance = Appearance223
        Me.ddDuongThu2.DisplayMember = "Ma_Bc"
        Me.ddDuongThu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDuongThu2.Location = New System.Drawing.Point(56, 144)
        Me.ddDuongThu2.Name = "ddDuongThu2"
        Me.ddDuongThu2.Size = New System.Drawing.Size(208, 128)
        Me.ddDuongThu2.TabIndex = 46
        Me.ddDuongThu2.ValueMember = "Ma_Bc"
        Me.ddDuongThu2.Visible = False
        '
        'UltraDataSource14
        '
        Me.UltraDataSource14.Band.Columns.AddRange(New Object() {UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        Me.UltraDataSource14.Band.Key = "Dm_Duong_thu"
        '
        'dgDanhMucDuongBayDen
        '
        Me.dgDanhMucDuongBayDen.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgDanhMucDuongBayDen.DataSource = Me.UltraDataSource16
        Me.dgDanhMucDuongBayDen.DisplayLayout.AddNewBox.Prompt = " "
        Appearance224.BackColor = System.Drawing.Color.White
        Appearance224.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance224.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgDanhMucDuongBayDen.DisplayLayout.Appearance = Appearance224
        UltraGridColumn247.Header.Caption = "Mã đường bay"
        UltraGridColumn247.Header.VisiblePosition = 0
        UltraGridColumn247.Hidden = True
        UltraGridColumn248.Header.Caption = "Mã đường thư"
        UltraGridColumn248.Header.VisiblePosition = 1
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.Caption = "Mã bưu cục gửi"
        UltraGridColumn249.Header.VisiblePosition = 2
        UltraGridColumn250.DefaultCellValue = "4"
        UltraGridColumn250.Header.Caption = "Loại vận chuyển"
        UltraGridColumn250.Header.VisiblePosition = 3
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.Caption = "Số hiệu"
        UltraGridColumn251.Header.VisiblePosition = 4
        UltraGridColumn252.DefaultCellValue = ""
        UltraGridColumn252.Header.Caption = "Sân bay chuyển tải"
        UltraGridColumn252.Header.VisiblePosition = 5
        UltraGridColumn252.Hidden = True
        UltraGridColumn253.Header.Caption = "Sân bay dỡ hàng"
        UltraGridColumn253.Header.VisiblePosition = 6
        UltraGridColumn253.Hidden = True
        UltraGridColumn254.Header.Caption = "Bưu cục gửi"
        UltraGridColumn254.Header.VisiblePosition = 7
        UltraGridColumn254.Hidden = True
        UltraGridColumn255.Header.Caption = "Bưu cục nhận"
        UltraGridColumn255.Header.VisiblePosition = 8
        UltraGridColumn255.Hidden = True
        UltraGridColumn256.Header.Caption = "Giờ khởi hành"
        UltraGridColumn256.Header.VisiblePosition = 9
        UltraGridColumn256.Hidden = True
        UltraGridColumn256.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn256.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn256.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn256.MaskInput = "hh:mm"
        UltraGridColumn257.Header.Caption = "Giờ đến"
        UltraGridColumn257.Header.VisiblePosition = 10
        UltraGridColumn257.Hidden = True
        UltraGridColumn257.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn257.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn257.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn257.MaskInput = "hh:mm"
        UltraGridColumn258.DefaultCellValue = "false"
        UltraGridColumn258.Header.Caption = "Quá ngày"
        UltraGridColumn258.Header.VisiblePosition = 11
        UltraGridColumn258.Hidden = True
        UltraGridColumn258.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn259.DefaultCellValue = "false"
        UltraGridColumn259.Header.Caption = "Quá giang"
        UltraGridColumn259.Header.VisiblePosition = 12
        UltraGridColumn259.Hidden = True
        UltraGridColumn259.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn260.DefaultCellValue = "1"
        UltraGridColumn260.Header.Caption = "Số chặng"
        UltraGridColumn260.Header.VisiblePosition = 13
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.DefaultCellValue = "1"
        UltraGridColumn261.Header.Caption = "Sử dụng"
        UltraGridColumn261.Header.VisiblePosition = 14
        UltraGridColumn261.Hidden = True
        UltraGridColumn262.DefaultCellValue = "0"
        UltraGridColumn262.Header.Caption = "Mã Bc Quá Giang"
        UltraGridColumn262.Header.VisiblePosition = 15
        UltraGridColumn262.Hidden = True
        UltraGridColumn263.DefaultCellValue = ""
        UltraGridColumn263.Header.VisiblePosition = 16
        UltraGridBand57.Columns.AddRange(New Object() {UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263})
        UltraGridBand57.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand57.UseRowLayout = True
        Me.dgDanhMucDuongBayDen.DisplayLayout.BandsSerializer.Add(UltraGridBand57)
        Me.dgDanhMucDuongBayDen.DisplayLayout.InterBandSpacing = 10
        Appearance225.BackColor = System.Drawing.Color.Transparent
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.CardAreaAppearance = Appearance225
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance226.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance226.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance226.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance226.ForeColor = System.Drawing.Color.Black
        Appearance226.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance226.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.HeaderAppearance = Appearance226
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance227.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.RowAppearance = Appearance227
        Appearance228.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance228.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance228.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.RowSelectorAppearance = Appearance228
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance229.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance229.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance229.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance229.ForeColor = System.Drawing.Color.Black
        Me.dgDanhMucDuongBayDen.DisplayLayout.Override.SelectedRowAppearance = Appearance229
        Me.dgDanhMucDuongBayDen.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgDanhMucDuongBayDen.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgDanhMucDuongBayDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDanhMucDuongBayDen.Location = New System.Drawing.Point(0, 23)
        Me.dgDanhMucDuongBayDen.Name = "dgDanhMucDuongBayDen"
        Me.dgDanhMucDuongBayDen.Size = New System.Drawing.Size(790, 472)
        Me.dgDanhMucDuongBayDen.TabIndex = 45
        '
        'UltraDataSource16
        '
        Me.UltraDataSource16.Band.Columns.AddRange(New Object() {UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37})
        Me.UltraDataSource16.Band.Key = "Danh_Muc_Duong_Bay_Den"
        '
        'UltraDataSource12
        '
        Me.UltraDataSource12.Band.Columns.AddRange(New Object() {UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54})
        Me.UltraDataSource12.Band.Key = "Danh_Muc_Duong_Bay_Den"
        '
        'UltraDataSource11
        '
        Me.UltraDataSource11.Band.Columns.AddRange(New Object() {UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        Me.UltraDataSource11.Band.Key = "Danh_Muc_Duong_Bay_Den"
        '
        'UltraDataSource8
        '
        Me.UltraDataSource8.Band.Columns.AddRange(New Object() {UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83})
        Me.UltraDataSource8.Band.Key = "Danh_Muc_Duong_Bay"
        '
        'UltraDataSource7
        '
        Me.UltraDataSource7.Band.Columns.AddRange(New Object() {UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97})
        Me.UltraDataSource7.Band.Key = "Danh_Muc_Duong_Bay"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110})
        Me.UltraDataSource2.Band.Key = "Danh_Muc_Duong_Bay"
        '
        'UltraGrid
        '
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraGrid.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl20)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl21)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl22)
        Me.UltraGrid.Controls.Add(Me.UltraTabPageControl23)
        Me.UltraGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid.Name = "UltraGrid"
        Me.UltraGrid.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraGrid.Size = New System.Drawing.Size(792, 584)
        Me.UltraGrid.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.UltraGrid.TabIndex = 1
        Me.UltraGrid.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowSizeToFit
        Me.UltraGrid.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        Me.UltraGrid.TabPadding = New System.Drawing.Size(10, 2)
        UltraTab1.Key = "Duong_Thu_Den"
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "Đường Thư Đến"
        UltraTab2.Key = "Duong_Thu_Di"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "ĐườngThư Đi"
        UltraTab3.Key = "Duong_Thu_Buu_Ta_Noi_Bo"
        UltraTab3.TabPage = Me.UltraTabPageControl22
        UltraTab3.Text = "Đường thư bưu tá nội bộ"
        UltraTab4.Key = "Duong_Thu_Di_Noi_Tinh"
        UltraTab4.TabPage = Me.UltraTabPageControl18
        UltraTab4.Text = "Đường Thư Đi Nội Tỉnh"
        UltraTab5.Key = "Ma_Bc_Khai_Thac"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Mã BC Khai Thác"
        UltraTab6.Key = "Ma_Bc"
        UltraTab6.TabPage = Me.UltraTabPageControl11
        UltraTab6.Text = "Mã BC"
        UltraTab7.Key = "Ly_Do"
        UltraTab7.TabPage = Me.UltraTabPageControl3
        UltraTab7.Text = "Lý Do"
        UltraTab8.Key = "Xu_Ly"
        UltraTab8.TabPage = Me.UltraTabPageControl7
        UltraTab8.Text = "Xử Lý"
        UltraTab9.Key = "Toa_Do_In"
        UltraTab9.TabPage = Me.UltraTabPageControl16
        UltraTab9.Text = "Toạ Độ In"
        UltraTab10.Key = "Ma_Ca"
        UltraTab10.TabPage = Me.UltraTabPageControl5
        UltraTab10.Text = "Mã Ca"
        UltraTab11.Key = "Ty_Gia"
        UltraTab11.TabPage = Me.UltraTabPageControl6
        UltraTab11.Text = "Tỷ Giá"
        UltraTab12.Key = "Khach_Hang"
        UltraTab12.TabPage = Me.UltraTabPageControl8
        UltraTab12.Text = "Khách Hàng"
        UltraTab12.Visible = False
        UltraTab13.Key = "Quay"
        UltraTab13.TabPage = Me.UltraTabPageControl9
        UltraTab13.Text = "Quầy"
        UltraTab13.Visible = False
        UltraTab14.Key = "Thong_Tin_Noi_Bo"
        UltraTab14.TabPage = Me.UltraTabPageControl10
        UltraTab14.Text = "Thông Tin Nội Bộ"
        UltraTab15.Key = "Dich_Vu"
        UltraTab15.TabPage = Me.UltraTabPageControl12
        UltraTab15.Text = "Dịch vụ"
        UltraTab16.Key = "Quan_Ly"
        UltraTab16.TabPage = Me.UltraTabPageControl13
        UltraTab16.Text = "Quản Lý"
        UltraTab17.Key = "Ma_Nuoc"
        UltraTab17.TabPage = Me.UltraTabPageControl14
        UltraTab17.Text = "Mã Nước"
        UltraTab18.Key = "Ma_Tinh"
        UltraTab18.TabPage = Me.UltraTabPageControl15
        UltraTab18.Text = "Mã Tỉnh"
        UltraTab19.Key = "Danh_Muc_Duong_Bay"
        UltraTab19.TabPage = Me.UltraTabPageControl17
        UltraTab19.Text = "Danh mục đường bay"
        UltraTab20.Key = "Danh_Muc_Chuyen_Bay"
        UltraTab20.TabPage = Me.UltraTabPageControl19
        UltraTab20.Text = "Danh mục chuyến bay"
        UltraTab21.Key = "Danh_Muc_Duong_Bay_Tong_Hop"
        UltraTab21.TabPage = Me.UltraTabPageControl20
        UltraTab21.Text = "Danh mục đường bay tổng hợp"
        UltraTab22.Key = "Dot_Bay"
        UltraTab22.TabPage = Me.UltraTabPageControl21
        UltraTab22.Text = "Đợt bay"
        UltraTab23.Key = "Danh_Muc_Duong_Bay_Den"
        UltraTab23.TabPage = Me.UltraTabPageControl23
        UltraTab23.Text = "Danh mục đường bay đến"
        Me.UltraGrid.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9, UltraTab10, UltraTab11, UltraTab12, UltraTab13, UltraTab14, UltraTab15, UltraTab16, UltraTab17, UltraTab18, UltraTab19, UltraTab20, UltraTab21, UltraTab22, UltraTab23})
        Me.UltraGrid.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(790, 519)
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
        'grbLuaChon
        '
        Me.grbLuaChon.Controls.Add(Me.rdbDmChinh)
        Me.grbLuaChon.Controls.Add(Me.rdbDmMayChu)
        Me.grbLuaChon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbLuaChon.Location = New System.Drawing.Point(8, 0)
        Me.grbLuaChon.Name = "grbLuaChon"
        Me.grbLuaChon.Size = New System.Drawing.Size(272, 40)
        Me.grbLuaChon.TabIndex = 6
        Me.grbLuaChon.TabStop = False
        Me.grbLuaChon.Text = "Lựa chọn"
        Me.grbLuaChon.Visible = False
        '
        'rdbDmChinh
        '
        Me.rdbDmChinh.Checked = True
        Me.rdbDmChinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDmChinh.ForeColor = System.Drawing.Color.Black
        Me.rdbDmChinh.Location = New System.Drawing.Point(7, 16)
        Me.rdbDmChinh.Name = "rdbDmChinh"
        Me.rdbDmChinh.Size = New System.Drawing.Size(112, 16)
        Me.rdbDmChinh.TabIndex = 0
        Me.rdbDmChinh.TabStop = True
        Me.rdbDmChinh.Text = "Danh mục chính"
        Me.rdbDmChinh.Visible = False
        '
        'rdbDmMayChu
        '
        Me.rdbDmMayChu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDmMayChu.Location = New System.Drawing.Point(120, 16)
        Me.rdbDmMayChu.Name = "rdbDmMayChu"
        Me.rdbDmMayChu.Size = New System.Drawing.Size(176, 16)
        Me.rdbDmMayChu.TabIndex = 1
        Me.rdbDmMayChu.Text = "Danh mục trên máy chủ"
        Me.rdbDmMayChu.Visible = False
        '
        'btnLayDanhMuc
        '
        Me.btnLayDanhMuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLayDanhMuc.Location = New System.Drawing.Point(288, 8)
        Me.btnLayDanhMuc.Name = "btnLayDanhMuc"
        Me.btnLayDanhMuc.Size = New System.Drawing.Size(189, 32)
        Me.btnLayDanhMuc.TabIndex = 7
        Me.btnLayDanhMuc.Text = "Lấy danh mục từ máy chủ"
        Me.btnLayDanhMuc.Visible = False
        '
        'UltraDataSource1
        '
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115})
        Me.UltraDataSource1.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125})
        Me.UltraDataSource1.Band.Key = "Duong_Thu_Di"
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn126, UltraDataColumn127, UltraDataColumn128})
        Me.UltraDataSource3.Band.Key = "Dm_Duong_thu"
        '
        'UltraDataSource5
        '
        Me.UltraDataSource5.Band.Columns.AddRange(New Object() {UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132})
        Me.UltraDataSource5.Band.Key = "Dm_Bc"
        '
        'UltraDataSource9
        '
        Me.UltraDataSource9.Band.Columns.AddRange(New Object() {UltraDataColumn133, UltraDataColumn134, UltraDataColumn135})
        Me.UltraDataSource9.Band.Key = "Ma_Bc_Qua_Giang"
        '
        'UltraDataSource15
        '
        UltraDataColumn138.DataType = GetType(System.Int32)
        Me.UltraDataSource15.Band.Columns.AddRange(New Object() {UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152})
        Me.UltraDataSource15.Band.Key = "Danh_Muc_Duong_Bay_Den"
        '
        'FrmCacBangDanhMuc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 589)
        Me.Controls.Add(Me.UltraGrid)
        Me.Controls.Add(Me.grbLuaChon)
        Me.Controls.Add(Me.btnLayDanhMuc)
        Me.Name = "FrmCacBangDanhMuc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bảng các danh mục"
        CType(Me.nubEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDuongthuden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgDuongthuden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ddMaBc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDuongthudi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgDuongthudi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl22.ResumeLayout(False)
        CType(Me.dgDuong_Thu_Buu_Ta_Noi_Bo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.ddBuuCucKhaiThac_NoiTinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhan_Loai_Duong_Thu_Noi_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDuongThuDiNoiTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ddPhan_Loai_Ma_Bc_Khai_Thac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMabckt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgMabckt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaDonVi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaTinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddQuanLy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDmMaBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.dgLydo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgLydo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.dgXuly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgXuly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.cbKhoGiay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgToaDoIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.ddMaBcKt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaCa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgMaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.dgTygia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tmp_dgTygia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.dgKhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.dgQuay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.ddKenhTruyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNoiBo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.ddPhanLoaiDV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDichVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl13.ResumeLayout(False)
        CType(Me.dgQuanLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl14.ResumeLayout(False)
        CType(Me.dgMaNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl15.ResumeLayout(False)
        CType(Me.dgMaTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl17.ResumeLayout(False)
        CType(Me.ddSo_Chang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Bc_Qua_Giang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDM_IPMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDuongThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanhMucDuongBay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl19.ResumeLayout(False)
        CType(Me.ddQuy_Luat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Nuoc_Chuyen_Bay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSan_Bay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanhMucChuyenBay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl20.ResumeLayout(False)
        CType(Me.dgDanhMucDuongBayTongHop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl21.ResumeLayout(False)
        CType(Me.dgDot_Bay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl23.ResumeLayout(False)
        CType(Me.ddSo_Chang2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Bc_Qua_Giang2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDM_IPMC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDuongThu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDanhMucDuongBayDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGrid.ResumeLayout(False)
        Me.grbLuaChon.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "-----------------------Khai Bao-----------------------"
    Dim myHamdungchung As New Ham_Dung_Chung
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myDuongthuden As New Duong_Thu_Den(GConnectionString)
    Dim myDuongthudi As New Duong_Thu_Di(GConnectionString)
    Dim myDuongThuDiNoiTinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
    Dim myChuyenThuDi As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyenThuDen As New Chuyen_Thu_Den(GConnectionString)
    Dim myMabckt As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myLydo As New Ly_Do(GConnectionString)
    Dim myMaDonVi As New Ma_Don_Vi(GConnectionString)
    Dim myMaca As New Ma_Ca(GConnectionString)
    Dim myXuly As New Xu_Ly(GConnectionString)
    Dim myTygia As New Ty_Gia(GConnectionString)
    Dim myDanhMuc As New Danh_Muc_BC(GConnectionString)
    Dim myQuanLy As New Danh_Muc_Quan_Ly(GConnectionString)
    Dim myBcKhaiThac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myMaNuoc As New Ma_Nuoc(GConnectionString)
    Dim myMaTinh As New Ma_Tinh(GConnectionString)
    Dim myKhachHang As New Khach_Hang(GConnectionString)
    Dim myQuay As New Quay_Giao_Dich(GConnectionString)
    Dim myDichVu As New Dich_Vu(GConnectionString)
    Dim myNoiBo As New Thong_Tin_Noi_Bo(GConnectionString)
    Dim myToaDoIn As New Toa_Do_In(GConnectionString)
    Dim Tmp_myLydoTmp As New Tmp_Ly_Do(GConnectionString)
    Dim Tmp_myXuly As New Tmp_Xu_Ly(GConnectionString)
    Dim myDanhMucDuongBay As New Danh_Muc_Duong_Bay(GConnectionString)
    Dim myDanh_Muc_Chuyen_Bay_So_Hieu As New Danh_Muc_Chuyen_Bay_So_Hieu(GConnectionString)
    Dim myDuong_Thu_Buu_Ta_Noi_Bo As New Duong_Thu_Buu_Ta_Noi_Bo(GConnectionString)
    Dim myDanhMucDuongBayDen As New Danh_Muc_Duong_Bay_Den(GConnectionString)
    Dim myDanhMucBc As New Danh_Muc_BC(GConnectionString)

#End Region

#Region "--------------------Tạo bảng--------------------"
#Region "-----------------------Tao_Bang_Id_Phan_Loai-----------------------"
    Private Sub Tao_Bang_Id_Phan_Loai()
        'Them moi mot bang
        Dim dataTable As New dataTable("Phan_Loai")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Id_Phan_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        'row("Id_Phan_Loai") = 0
        'row("Ten_Phan_Loai") = "Bưu tá"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("Id_Phan_Loai") = 1
        'row("Ten_Phan_Loai") = "Nội tỉnh"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        row("Id_Phan_Loai") = 2
        row("Ten_Phan_Loai") = "Liên tỉnh"
        dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("Id_Phan_Loai") = 3
        'row("Ten_Phan_Loai") = "Liền kề"
        'dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 4
        row("Ten_Phan_Loai") = "Quốc tế"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 5
        row("Ten_Phan_Loai") = "Lưu kho QT Đến"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 6
        row("Ten_Phan_Loai") = "Chuyển tiếp"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 7
        row("Ten_Phan_Loai") = "Lưu kho QT Đi"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id_Phan_Loai") = 8
        row("Ten_Phan_Loai") = "Kho Hải Quan"
        dataTable.Rows.Add(row)

        ddPhanLoai.DataSource = dataTable
        ddPhanLoai.DataBind()
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Phan_Loai_Ma_Bc_Khai_Thac-----------------------"
    Private Sub Tao_Bang_Phan_Loai_Ma_Bc_Khai_Thac()
        'Them moi mot bang
        Dim dataTable As New dataTable("Phan_Loai_Ma_Bc_Khai_Thac")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Phan_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Phan_Loai") = 0
        row("Ten_Phan_Loai") = "Quốc Tế Đến"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = 1
        row("Ten_Phan_Loai") = "Quốc Tế Đi"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = 2
        row("Ten_Phan_Loai") = "Kho Hải Quan"
        dataTable.Rows.Add(row)

        ddPhan_Loai_Ma_Bc_Khai_Thac.DataSource = dataTable
        ddPhan_Loai_Ma_Bc_Khai_Thac.DataBind()
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Phan_Loai_Duong_Thu_Noi_Tinh-----------------------"
    Private Sub Tao_Bang_Phan_Loai_Duong_Thu_Noi_Tinh()

        'Them moi mot bang
        Dim dataTable As New dataTable("Phan_Loai_Duong_Thu_Noi_Tinh")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Phan_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Phan_Loai") = 0
        row("Ten_Phan_Loai") = "Nội Thành"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = 1
        row("Ten_Phan_Loai") = "Ngoại Thành"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Phan_Loai") = 2
        row("Ten_Phan_Loai") = "Loại Khác"
        dataTable.Rows.Add(row)

        ddPhan_Loai_Duong_Thu_Noi_Tinh.DataSource = dataTable
        ddPhan_Loai_Duong_Thu_Noi_Tinh.DataBind()
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Kenh_Truyen-----------------------"
    Private Sub Tao_Bang_Kenh_Truyen()
        'Them moi mot bang
        Dim dataTable As New dataTable("Kenh_Truyen")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Kenh_Truyen", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Kenh_Truyen", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Kenh_Truyen") = 0
        row("Ten_Kenh_Truyen") = "ACCS"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Kenh_Truyen") = 1
        row("Ten_Kenh_Truyen") = "Truyền File"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Kenh_Truyen") = 2
        row("Ten_Kenh_Truyen") = "Webservice"
        dataTable.Rows.Add(row)

        ddKenhTruyen.DataSource = dataTable
        ddKenhTruyen.DataBind()
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Phan_Loai_Dich_Vu-----------------------"
    Private Sub Tao_Bang_Phan_Loai()

        'Them moi mot bang
        Dim dataTable As New dataTable("Phan_Loai")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Id", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Phan_Loai", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Id") = 0
        row("Phan_Loai") = "Dịch Vụ Cộng Thêm"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id") = 1
        row("Phan_Loai") = "Dịch Vụ Gia Tăng"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id") = 2
        row("Phan_Loai") = "COD"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Id") = 3
        row("Phan_Loai") = "Khai Giá"
        dataTable.Rows.Add(row)

        ddPhanLoaiDV.DataSource = dataTable
        ddPhanLoaiDV.DataBind()
    End Sub
#End Region

#Region "-----------------------Tao_Bang_So_Chang-----------------------"
    Private Sub Tao_Bang_So_Chang()

        'Them moi mot bang
        Dim dataTable As New dataTable("So_Chang")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("So_Chang", GetType(Int32))
        dataTable.Columns.Add(colWork)

        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("So_Chang") = 1
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("So_Chang") = 2
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("So_Chang") = 3
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("So_Chang") = 4
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("So_Chang") = 5
        dataTable.Rows.Add(row)

        ddSo_Chang.DataSource = dataTable
        ddSo_Chang.DataBind()
    End Sub
#End Region
#End Region

#Region "--------------------Hàm dùng chung--------------------"
#Region "-----------------------KeyDown-----------------------"
    Private Sub dgDuongthuden_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDuongthuden.KeyDown, dgDuongthudi.KeyDown, dgDuongThuDiNoiTinh.KeyDown, dgXuly.KeyDown, dgLydo.KeyDown, dgMaca.KeyDown, dgTygia.KeyDown, dgMabckt.KeyDown, dgKhachhang.KeyDown, dgQuay.KeyDown, dgNoiBo.KeyDown, dgDmMaBC.KeyDown, dgDichVu.KeyDown, dgQuanLy.KeyDown, dgMaNuoc.KeyDown, dgMaTinh.KeyDown, dgToaDoIn.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape Then Exit Sub
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
                Select Case myGridKeyDown.Name
                    Case dgDuongthuden.Name
                        Delete_Duongthuden()
                    Case dgDuongthudi.Name
                        Delete_Duongthudi()
                    Case dgDuongThuDiNoiTinh.Name
                        Delete_DuongThuDiNoiTinh()
                    Case dgMabckt.Name
                        Delete_Mabckt()
                    Case dgLydo.Name
                        Delete_LyDo()
                    Case dgMaca.Name
                        Delete_Maca()
                    Case dgTygia.Name
                        Delete_Tygia()
                    Case dgXuly.Name
                        Delete_Xuly()
                    Case dgKhachhang.Name
                        Delete_KhachHang()
                    Case dgQuay.Name
                        Delete_Quay()
                    Case dgDmMaBC.Name
                        Delete_DmMaBc()
                    Case dgDichVu.Name
                        Delete_DichVu()
                    Case dgQuanLy.Name
                        Delete_QuanLy()
                    Case dgMaNuoc.Name
                        Delete_MaNuoc()
                    Case dgMaTinh.Name
                        Delete_MaTinh()
                    Case dgToaDoIn.Name
                        Delete_ToaDoIn()
                End Select
                e.Handled = True
            Case Keys.Escape
                If Not myCell Is Nothing Then
                    myGridKeyDown.ActiveRow.Delete(False)
                    myGridKeyDown.Rows.Band.AddNew()
                End If
            Case Keys.F1
        End Select
    End Sub
#End Region

#Region "-----------------------BeforeCellDeactivate-----------------------"
    Private Sub dgDuongthuden_BeforeCellDeactivate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgDuongthuden.BeforeCellDeactivate, dgDuongthudi.BeforeCellDeactivate, dgDuongThuDiNoiTinh.BeforeCellDeactivate, dgMaca.BeforeCellDeactivate, dgMabckt.BeforeCellDeactivate, dgKhachhang.BeforeCellDeactivate, dgQuay.BeforeCellDeactivate, dgNoiBo.BeforeCellDeactivate, dgDichVu.BeforeCellDeactivate, dgDmMaBC.BeforeCellDeactivate
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
        Exit Sub
    End Sub
#End Region

#Region "-----------------------FrmLoad-----------------------"
    Private Sub FrmCacBangDanhMuc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Tạo bảng:sử dụng cho các combobox
        Tao_Bang_Id_Phan_Loai()
        Tao_Bang_Kenh_Truyen()
        Tao_Bang_Phan_Loai()
        Tao_Bang_Phan_Loai_Duong_Thu_Noi_Tinh()
        Tao_Bang_Phan_Loai_Ma_Bc_Khai_Thac()
        Tao_Bang_So_Chang()

        'Danh sách mã nước
        cbMa_Nuoc.DataSource = myMaNuoc.Danh_Sach
        cbMa_Nuoc.DataBind()
        cbMa_Nuoc.Value = "VN"
        'Danh sách mã tỉnh
        cbMa_Tinh.Enabled = True
        cbMa_Tinh.DataSource = myMaTinh.Danh_Sach
        cbMa_Tinh.DataBind()
        If cbMa_Tinh.Rows.Count > 0 Then
            cbMa_Tinh.Value = myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
            cbMa_Tinh.Text = myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
        End If

        'ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
        'ddMaBc.DataBind()
        'ddMa_Nuoc.DataSource = myMaNuoc.Danh_Sach
        'ddMa_Nuoc.DataBind()
        'ddMaTinh.DataSource = myMaTinh.Danh_Sach
        'ddMaTinh.DataBind()
        'ddMaBcKt.DataSource = myMabckt.Danh_Sach
        'ddMaBcKt.DataBind()
        'ddQuanLy.DataSource = myQuanLy.Danh_Sach()
        'ddQuanLy.DataBind()
        'ddMaDonVi.DataSource = myMaDonVi.Danh_Sach()
        'ddMaDonVi.DataBind()
        'cbKhoGiay.DataSource = myToaDoIn.Danh_Sach_Kho_Giay()
        'cbKhoGiay.DataBind()
        'Dua du lieu vao combo duong thu
        'ddDuongThu.DataSource = myDuongthudi.Duong_Thu_Di_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu(GBuu_Cuc_Khai_Thac).Tables(0)
        'ddDuongThu.DataBind()

        'Ẩn các tab không sử dụng đến
        UltraGrid.Tabs("Toa_Do_In").Visible = False
        UltraGrid.Tabs("Danh_Muc_Duong_Bay_Tong_Hop").Visible = False
        UltraGrid.Tabs("Dot_Bay").Visible = False
    End Sub
#End Region

#Region "-----------------------SelectedTabChanged-----------------------"
    Private Sub UltraTabControl1_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraGrid.SelectedTabChanged
        If Not Me.FrmTK Is Nothing Then
            Me.FrmTK.Hide()
        End If
        Select Case e.Tab.Index
            Case 0 'Đường Thư đên
                DataGrid_Duongthuden()
                ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
                ddMaBc.DataBind()
                myGridKeyDown = dgDuongthuden
            Case 1 'Đường thư đi
                DataGrid_Duongthudi()
                ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
                ddMaBc.DataBind()
                myGridKeyDown = dgDuongthudi
            Case 2 'Đường thư bưu tá nội bộ
                DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
                ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
                ddMaBc.DataBind()
                myGridKeyDown = dgDuong_Thu_Buu_Ta_Noi_Bo
            Case 3 'Đường thư đi nội tỉnh
                'Lấy bưu cục khai thác nội tỉnh:Lấy ma_bc trong đường thư đi với các đường thư nội tỉnh
                ddBuuCucKhaiThac_NoiTinh.DataSource = myDuongthudi.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Tinh(GBuu_Cuc_Khai_Thac, myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh)
                ddBuuCucKhaiThac_NoiTinh.DataBind()
                DataGrid_DuongthudiNoiTinh()
                ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
                ddMaBc.DataBind()
                myGridKeyDown = dgDuongThuDiNoiTinh
            Case 4 'Mã bưu cục khai thác
                DataGrid_Mabckt()
                ddMaBc.DataSource = myDanhMuc.Danh_Sach_Rut_Gon()
                ddMaBc.DataBind()
                myGridKeyDown = dgMabckt
            Case 5 'Danh mục bưu cục
                ddMa_Nuoc.DataSource = myMaNuoc.Danh_Sach
                ddMa_Nuoc.DataBind()
                ddMaTinh.DataSource = myMaTinh.Danh_Sach
                ddMaTinh.DataBind()
                ddQuanLy.DataSource = myQuanLy.Danh_Sach()
                ddQuanLy.DataBind()
                ddMaDonVi.DataSource = myMaDonVi.Danh_Sach()
                ddMaDonVi.DataBind()
                DataGrid_DmMaBC(cbMa_Nuoc.Text, CInt(SetNullValue(cbMa_Tinh.Text, 0)))
                cbMa_Nuoc.Focus()
            Case 6 'Lý do
                DataGrid_Lydo()
                myGridKeyDown = dgLydo
            Case 7 'Xử lý
                DataGrid_Xuly()
                myGridKeyDown = dgXuly
            Case 8 'Tọa độ in
                cbKhoGiay.DataSource = myToaDoIn.Danh_Sach_Kho_Giay()
                cbKhoGiay.DataBind()
                DataGrid_ToaDoIn()
                myGridKeyDown = dgToaDoIn
            Case 9 'Mã ca
                ddMaBcKt.DataSource = myMabckt.Danh_Sach
                ddMaBcKt.DataBind()
                DataGrid_Maca()
                myGridKeyDown = dgMaca
            Case 10 'Tỷ giá
                DataGrid_Tygia()
                myGridKeyDown = dgTygia
            Case 11 'Khách hàng
                DataGrid_Khachhang()
                myGridKeyDown = dgKhachhang
            Case 12 'Quầy
                DataGrid_Quay()
                myGridKeyDown = dgQuay
            Case 13 'Thông tin nội bộ
                DataGrid_Thongtinnoibo()
                myGridKeyDown = dgNoiBo
            Case 14 'Dịch vụ
                DataGrid_DichVu()
                myGridKeyDown = dgDichVu
            Case 15 'Quản lý
                DataGrid_QuanLy()
                myGridKeyDown = dgQuanLy
            Case 16 'Mã Nước
                DataGrid_MaNuoc()
                myGridKeyDown = dgMaNuoc
            Case 17 'Mã Tỉnh
                DataGrid_MaTinh()
                myGridKeyDown = dgMaTinh
            Case 18 'Danh Mục đường bay
                'Danh sach ma_bc_qua_giang trong tab Danh Muc Duong Bay
                ddMa_Bc_Qua_Giang.DataSource = myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Danh_Sach_Ma_Bc_Qua_Giang()
                ddMa_Bc_Qua_Giang.DataBind()
                'Danh sách đường thư
                ddDuongThu.DataSource = myDuongthudi.Duong_Thu_Di_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu(GBuu_Cuc_Khai_Thac).Tables(0)
                optSu_Dung.Checked = True
                ddDuongThu.DataBind()
                DataGrid_DuongBay()
                myGridKeyDown = dgDanhMucDuongBay
            Case 19 'Danh muc chuyen bay
                'Lay du lieu cho cac bang lien qua
                Get_Data_Ma_Nuoc()
                Get_Data_San_Bay()
                Tao_Bang_Quy_Luat()
                'Lay du lieu Danh muc chuyen bay
                DataGrid_Danh_Muc_Chuyen_Bay()
                myGridKeyDown = dgDanhMucChuyenBay
                dgDanhMucChuyenBay.Tag = True
            Case 20 'Danh mục đường bay tổng hợp

            Case 21 'Đợt bay

            Case 22 'Danh Mục đường bay den

                ddDuongThu2.DataSource = myDuongthuden.Duong_Thu_Den_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_BC_chu(GBuu_Cuc_Khai_Thac).Tables(0)
                ddDuongThu2.DataBind()

                'ddMa_Bc_Qua_Giang2.DataSource = myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_Danh_Sach_Ma_Bc_Qua_Giang()
                ddMa_Bc_Qua_Giang2.DataSource = myDanhMucBc.Danh_Sach_Rut_Gon_IPMC_Not_Null()
                ddMa_Bc_Qua_Giang2.DataBind()
                DataGrid_DuongBayDen()
                myGridKeyDown = dgDanhMucDuongBayDen

        End Select
    End Sub
#End Region

#Region "-----------------------MouseDown-----------------------"
    Private Sub dgDuongthuden_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgDuongthuden.MouseDown, dgDuongthudi.MouseDown, dgDuongThuDiNoiTinh.MouseDown, dgLydo.MouseDown, dgMaca.MouseDown, dgTygia.MouseDown, dgXuly.MouseDown, dgMabckt.MouseDown, dgKhachhang.MouseDown, dgQuay.MouseDown, dgDmMaBC.MouseDown, dgDmMaBC.MouseDown, dgDichVu.MouseDown, dgQuanLy.MouseDown, dgMaNuoc.MouseDown, dgMaTinh.MouseDown, dgToaDoIn.MouseDown, dgDanhMucDuongBay.MouseDown, dgDuong_Thu_Buu_Ta_Noi_Bo.MouseDown
        myGridKeyDown = sender
        If e.Button = MouseButtons.Right Then
            Dim oHeaderUI As Infragistics.Win.UltraWinGrid.HeaderUIElement
            Dim oUIElement As Infragistics.Win.UIElement
            Dim point As point = New point(e.X, e.Y)

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

#Region "-----------------------Lỗi-----------------------"
    Private Sub dgMaca_Error(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ErrorEventArgs) Handles dgMaca.Error, dgDuongthuden.Error, dgDuongthudi.Error, dgDichVu.Error, dgDmMaBC.Error, dgMaNuoc.Error, dgKhachhang.Error, dgLydo.Error, dgMabckt.Error, dgMaTinh.Error, dgNoiBo.Error, dgTygia.Error, dgQuanLy.Error, dgQuay.Error, dgXuly.Error, dgDuong_Thu_Buu_Ta_Noi_Bo.Error
        e.ErrorText = "Lỗi này phát sinh do một trong các nguyên nhân sau: " + vbNewLine + "- Nhập sai định dạng cho phép." + vbNewLine + "- Dữ liệu chưa có sẵn ở bảng liên kết khác" + vbNewLine + "::Bạn hãy xem lại!"
    End Sub
#End Region

#Region "-----------------------Tmp-----------------------"
    Private Sub rdbDmChinh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDmChinh.CheckedChanged
        If rdbDmChinh.Checked = True Then
            dgDuongthuden.Visible = True
            dgDuongthudi.Visible = True
            dgMabckt.Visible = True
            dgXuly.Visible = True
            dgLydo.Visible = True
            dgMaca.Visible = True
            dgTygia.Visible = True
        Else
            dgDuongthuden.Visible = False
            dgDuongthudi.Visible = False
            dgMabckt.Visible = False
            dgXuly.Visible = False
            dgLydo.Visible = False
            dgMaca.Visible = False
            dgTygia.Visible = False
        End If

    End Sub

    Private Sub rdbDmMayChu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDmMayChu.CheckedChanged
        If rdbDmMayChu.Checked = True Then
            Tmp_dgDuongthuden.Visible = True
            Tmp_dgDuongthudi.Visible = True
            Tmp_dgLydo.Visible = True
            Tmp_dgMabckt.Visible = True
            Tmp_dgMaca.Visible = True
            Tmp_dgTygia.Visible = True
            Tmp_dgXuly.Visible = True
        Else
            Tmp_dgDuongthuden.Visible = False
            Tmp_dgDuongthudi.Visible = False
            Tmp_dgLydo.Visible = False
            Tmp_dgMabckt.Visible = False
            Tmp_dgMaca.Visible = False
            Tmp_dgTygia.Visible = False
            Tmp_dgXuly.Visible = False
        End If
    End Sub
    Private Sub btnLayDanhMuc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLayDanhMuc.Click
        If UltraTabPageControl3.Tab.Active Then
            If MessageBox.Show("Không thể lấy danh mục 'LÝ DO' từ máy chủ xuống ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'myLydo.Xoa_All()
                'myLydo.Lay_All_Tu_Tmp()
                dgLydo.Refresh()
            End If
        End If

        If UltraTabPageControl7.Tab.Active Then
            If MessageBox.Show("Không thể lấy danh mục 'XỬ LÝ' từ máy chủ xuống ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'myXuly.Xoa_All()
                'myXuly.Lay_All_Tu_Tmp()
                dgLydo.Refresh()
            End If
        End If

    End Sub

    Private Sub btnTruyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen.Click
        Dim Frm As New FrmTruyenDanhMuc
        Frm.ShowDialog()
    End Sub
#End Region

#Region "-----------------------Search-----------------------"
    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTimKiem.Click
        If Me.FrmTK Is Nothing Then
            Me.FrmTK = New FrmTimKiemDanhMuc
        End If
        Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
    End Sub

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
        MessageBox.Show("Đã tìm kiếm hết danh sách rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub
#End Region
#End Region

#Region "--------------------Khác--------------------"
#Region "-----------------------AddNewRow-----------------------"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
    End Sub
#End Region

#Region "-----------------------DataGrid-----------------------"
    Private Sub DataGrid_Xuly_Tmp()
        Tmp_dgXuly.DataSource = Tmp_myXuly.Danh_Sach.Tables(0)
        Tmp_dgXuly.DataBind()
        Tmp_dgXuly.Rows.Band.AddNew()
    End Sub

    Private Sub DataGrid_Lydo_Tmp()
        Tmp_dgLydo.DataSource = Tmp_myLydoTmp.Danh_Sach.Tables(0)
        Tmp_dgLydo.DataBind()
        Tmp_dgLydo.Rows.Band.AddNew()
    End Sub
#End Region
#End Region

#Region "--------------------Tab Control--------------------"
#Region "--------------------Đường thư đên--------------------"
#Region "--------------------dgDuongthuden_InitializeLayout--------------------"
    Private Sub dgDuongthuden_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDuongthuden.InitializeLayout
        dgDuongthuden.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDuongthuden.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgDuongthuden.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgDuongthuden.DisplayLayout
            .Bands(0).Columns("Ma_Bc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc").ValueList = ddMaBc

            .Bands(0).Columns("Id_Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Id_Phan_Loai").ValueList = ddPhanLoai

            .Bands(0).Columns("Su_Dung").Style = ColumnStyle.CheckBox
        End With
    End Sub
#End Region

#Region "--------------------dgDuongthuden_InitializeTemplateAddRow--------------------"
    Private Sub dgDuongthuden_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDuongthuden.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Su_Dung").DefaultCellValue = 1
            .Columns("Chuyen_Tiep").DefaultCellValue = CBool(0)
        End With
    End Sub
#End Region

#Region "--------------------DataGrid_Duongthuden--------------------"
    Private Sub DataGrid_Duongthuden()
        dgDuongthuden.DataSource = myDuongthuden.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        dgDuongthuden.DataBind()
        dgDuongthuden.Rows.Band.AddNew()
    End Sub
#End Region

#Region "--------------------Delete_Duongthuden--------------------"
    Private Sub Delete_Duongthuden()
        If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Duong_Thu").Text <> "" Then
            '' Có xoá được hay không
            Dim Chk As Boolean
            Chk = myChuyenThuDen.Chuyen_Thu_Den_Kiem_Tra(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Duong_Thu").Text)
            If Chk = True Then
                CMessageBox.Show("Bạn không thể xoá được mã này vì ảnh hưởng đến bảng Chuyen_Thu_Den.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDuongthuden.Xoa(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Duong_Thu").Text)
                dgDuongthuden.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthuden_AfterRowUpdate--------------------"
    Private Sub dgDuongthuden_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDuongthuden.AfterRowUpdate
        If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text = "" And dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
            Exit Sub
        Else
            If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đến" & vbNewLine & "Chú ý: Mã BC không được để trống.", " Thông báo ")
                myCell = dgDuongthuden.ActiveCell
                Exit Sub
            End If

            If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đến" & vbNewLine & "Chú ý: Id Phân Loại không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text <> "" And dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Text <> "" Then
            Dim Id_Duong_Thu_Den, mabckhaithac, mabcgoc As String
            mabckhaithac = GBuu_Cuc_Khai_Thac.ToString
            mabcgoc = dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text
            If mabckhaithac.Length = 6 Then
                mabckhaithac = "0" + mabckhaithac
            End If
            If mabcgoc.Length = 6 Then
                mabcgoc = "0" + mabcgoc
            End If
            Id_Duong_Thu_Den = mabcgoc + mabckhaithac
            'myDuongthuden.Cap_Nhat_Them(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text + GBuu_Cuc_Khai_Thac.ToString, dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, GBuu_Cuc_Khai_Thac, Convert.ToInt32(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text), Convert.ToInt32(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Value), dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value, dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value, dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Duoc_Truyen").Value)
            myDuongthuden.Cap_Nhat_Them(Id_Duong_Thu_Den, _
                                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, _
                                        GBuu_Cuc_Khai_Thac, _
                                        Convert.ToInt32(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text), _
                                        Convert.ToInt32(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Value), _
                                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value, _
                                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value, _
                                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Duoc_Truyen").Value, _
                                        Convert.ToInt32(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Su_Dung").Value), _
                                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthuden_AfterCellUpdate--------------------"
    Private Sub dgDuongthuden_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDuongthuden.AfterCellUpdate
        'If e.Cell.Row.Cells("Ma_Bc").IsActiveCell Then
        '    AddNewRow(sender)
        'End If
        If e.Cell.Row.Cells("Ma_Bc").Text <> "" And e.Cell.Row.Cells("Id_Phan_Loai").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthuden_AfterExitEditMode--------------------"
    Private Sub dgDuongthuden_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDuongthuden.AfterExitEditMode
        Dim Mabc As String = dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text
        Select Case dgDuongthuden.ActiveCell.Column.Key
            Case "Ma_Bc"
                If dgDuongthuden.ActiveCell.Text <> "" Then
                    If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value Is System.DBNull.Value Then
                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = CheckState.Unchecked
                    End If
                    If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value Is System.DBNull.Value Then
                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = CheckState.Unchecked
                    End If
                    If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Duoc_Truyen").Value Is System.DBNull.Value Then
                        dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Duoc_Truyen").Value = CheckState.Unchecked
                    End If
                    If myDuongthuden.Kiem_Tra_MaBc(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Value, GBuu_Cuc_Khai_Thac) = True And dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
                        CMessageBox.Show("Mã Bưu Cục: " & Mabc & " đã tồn tại bạn không thể nhập thêm.", " Thông báo ")
                        myCell = dgDuongthuden.ActiveCell
                        Exit Sub
                    End If
                    dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ten_Duong_Thu").Value = myDanhMuc.Lay(dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text).Ten_Buu_Cuc
                End If
            Case "Tinh_Cong_Phat"
                If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text <> "" Then
                    If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = True And dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = True Then
                        CMessageBox.Show("Bạn chỉ được phép chọn 1.", " Thông báo ")
                        myCell = dgDuongthuden.ActiveCell
                        Exit Sub
                    End If
                End If
            Case "Tinh_Doanh_Thu"
                If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Ma_Bc").Text <> "" Then
                    If dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = True And dgDuongthuden.Rows(dgDuongthuden.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = True Then
                        CMessageBox.Show("Bạn chỉ được phép chọn 1 .", " Thông báo ")
                        myCell = dgDuongthuden.ActiveCell
                        Exit Sub
                    End If
                End If
        End Select
    End Sub
#End Region
#End Region

#Region "--------------------Đường thư đi--------------------"
#Region "--------------------dgDuongthudi_InitializeLayout--------------------"
    Private Sub dgDuongthudi_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDuongthudi.InitializeLayout
        dgDuongthudi.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDuongthudi.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgDuongthudi.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgDuongthudi.DisplayLayout
            .Bands(0).Columns("Ma_Bc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc").ValueList = ddMaBc

            .Bands(0).Columns("Id_Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Id_Phan_Loai").ValueList = ddPhanLoai

            .Bands(0).Columns("Su_Dung").Style = ColumnStyle.CheckBox
        End With
    End Sub
#End Region

#Region "--------------------dgDuongthudi_InitializeTemplateAddRow--------------------"
    Private Sub dgDuongthudi_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDuongthudi.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Su_Dung").DefaultCellValue = 1
            .Columns("Chuyen_Tiep").DefaultCellValue = CBool(0)
        End With
    End Sub
#End Region

#Region "--------------------DataGrid_Duongthudi--------------------"
    Private Sub DataGrid_Duongthudi()
        dgDuongthudi.DataSource = myDuongthudi.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        dgDuongthudi.DataBind()
        dgDuongthudi.Rows.Band.AddNew()
    End Sub
#End Region

#Region "--------------------Delete_Duongthudi--------------------"
    Private Sub Delete_Duongthudi()
        If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Duong_Thu").Text <> "" Then
            '' Có xoá được hay không
            Dim Chk As Boolean
            Chk = myChuyenThuDi.Chuyen_Thu_Di_Kiem_Tra(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Duong_Thu").Text)
            If Chk = True Then
                CMessageBox.Show("Bạn không thể xoá được mã này vì ảnh hưởng đến bảng Chuyen_Thu_Di.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDuongthudi.Xoa(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Duong_Thu").Text)
                dgDuongthudi.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthudi_AfterRowUpdate--------------------"
    Private Sub dgDuongthudi_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDuongthudi.AfterRowUpdate
        If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text = "" And dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
            Exit Sub
        Else
            If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đi" & vbNewLine & "Chú ý: Mã BC không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đi" & vbNewLine & "Chú ý: Id Phân Loại không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text <> "" And dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Text <> "" Then
            Dim Id_Duong_Thu_Di, mabckhaithac, mabcden As String
            mabckhaithac = GBuu_Cuc_Khai_Thac.ToString
            mabcden = dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text
            If mabckhaithac.Length = 6 Then
                mabckhaithac = "0" + mabckhaithac
            End If
            If mabcden.Length = 6 Then
                mabcden = "0" + mabcden
            End If
            Id_Duong_Thu_Di = mabckhaithac + mabcden
            'myDuongthudi.Cap_Nhat_Them(GBuu_Cuc_Khai_Thac.ToString + dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, GBuu_Cuc_Khai_Thac, Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text), Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Value), dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Duoc_Truyen").Value)
            myDuongthudi.Cap_Nhat_Them(Id_Duong_Thu_Di, _
                                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, _
                                        GBuu_Cuc_Khai_Thac, Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text), _
                                        Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Value), _
                                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value, _
                                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value, _
                                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Duoc_Truyen").Value, _
                                        Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Su_Dung").Value), _
                                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Chuyen_Tiep").Value)
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthudi_AfterCellUpdate--------------------"
    Private Sub dgDuongthudi_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDuongthudi.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Bc").Text <> "" And e.Cell.Row.Cells("Id_Phan_Loai").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "--------------------dgDuongthudi_AfterExitEditMode--------------------"
    Private Sub dgDuongthudi_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDuongthudi.AfterExitEditMode
        Dim Mabc As String = dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text
        Select Case dgDuongthudi.ActiveCell.Column.Key
            Case "Ma_Bc"
                If dgDuongthudi.ActiveCell.Text <> "" Then
                    If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value Is System.DBNull.Value Then
                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = CheckState.Unchecked
                    End If
                    If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value Is System.DBNull.Value Then
                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = CheckState.Unchecked
                    End If
                    If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Duoc_Truyen").Value Is System.DBNull.Value Then
                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Duoc_Truyen").Value = CheckState.Unchecked
                    End If
                    If myDuongthudi.Kiem_Tra_MaBc(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Value, GBuu_Cuc_Khai_Thac) = True And dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Text = "" Then
                        CMessageBox.Show("Mã Bưu Cục:" & Mabc & " đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgDuongthudi.ActiveCell
                        Exit Sub
                    End If
                    dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ten_Duong_Thu").Value = myDanhMuc.Lay(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text).Ten_Buu_Cuc
                    Try
                        dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ten_Duong_Thu").Value = myDanhMuc.Lay(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text).Ten_Buu_Cuc
                    Catch ex As Exception
                        Dim str As String = "Không tồn tại Mã Bc: " & Mabc & " Bạn phải vào bảng Mã Bc để nhập thêm !"
                        CMessageBox.Show(str, " Thông báo ")
                        Exit Sub
                    End Try
                End If
            Case "Tinh_Cong_Phat"
                If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text <> "" Then
                    If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = True And dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = True Then
                        CMessageBox.Show("Bạn chỉ được phép chọn 1.", " Thông báo ")
                        myCell = dgDuongthudi.ActiveCell
                        Exit Sub
                    End If
                End If
            Case "Tinh_Doanh_Thu"
                If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text <> "" Then
                    If dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value = True And dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value = True Then
                        CMessageBox.Show("Bạn chỉ được phép chọn 1 .", " Thông báo ")
                        myCell = dgDuongthudi.ActiveCell
                        Exit Sub
                    End If
                End If
        End Select
    End Sub
#End Region

#End Region

#Region "--------------------Đường thư đi nội tỉnh--------------------"
    Private Sub dgDuongThuDiNoiTinh_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDuongThuDiNoiTinh.InitializeLayout
        dgDuongThuDiNoiTinh.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDuongThuDiNoiTinh.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgDuongThuDiNoiTinh.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgDuongThuDiNoiTinh.DisplayLayout
            .Bands(0).Columns("Ma_Bc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc").ValueList = ddMaBc

            .Bands(0).Columns("Ma_Tinh").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Tinh").ValueList = ddMaTinh

            .Bands(0).Columns("Ma_Bc_Khai_Thac").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Khai_Thac").ValueList = ddBuuCucKhaiThac_NoiTinh

            .Bands(0).Columns("Phan_Loai_Duong_Thu").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Phan_Loai_Duong_Thu").ValueList = ddPhan_Loai_Duong_Thu_Noi_Tinh
        End With
    End Sub

    Private Sub DataGrid_DuongthudiNoiTinh()
        'Lấy đường thư đi nội tỉnh có trong danh sách đường thư đi của ma_bc_khai_thac
        dgDuongThuDiNoiTinh.DataSource = myDuongThuDiNoiTinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh(myDanhMuc.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(GBuu_Cuc_Khai_Thac).Ma_Tinh).Tables(0)
        dgDuongThuDiNoiTinh.DataBind()
        dgDuongThuDiNoiTinh.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_DuongThuDiNoiTinh()
        If dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Id_Duong_Thu").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDuongThuDiNoiTinh.Duong_Thu_Di_Noi_Tinh_Xoa(dgDuongThuDiNoiTinh.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Duong_Thu").Text)
                dgDuongThuDiNoiTinh.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgDuongThuDiNoiTinnh_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDuongThuDiNoiTinh.AfterRowUpdate
        'Chua xong
        If dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text = "" And dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Phan_Loai_Duong_Thu").Text = "" Then
            Exit Sub
        Else
            If dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đi Nội Tỉnh" & vbNewLine & "Chú ý: Mã BC không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Phan_Loai_Duong_Thu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Đi Nội Tỉnh" & vbNewLine & "Chú ý: Phân Loại Đường Thư không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text <> "" And dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Phan_Loai_Duong_Thu").Text <> "" Then
            Dim Id_Duong_Thu_Di, mabckhaithac, mabcden As String
            mabckhaithac = dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text 'GBuu_Cuc_Khai_Thac.ToString
            mabcden = dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text
            If mabckhaithac.Length = 6 Then
                mabckhaithac = "0" + mabckhaithac
            End If
            If mabcden.Length = 6 Then
                mabcden = "0" + mabcden
            End If
            Id_Duong_Thu_Di = mabckhaithac + mabcden
            'myDuongthudi.Cap_Nhat_Them(GBuu_Cuc_Khai_Thac.ToString + dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, GBuu_Cuc_Khai_Thac, Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Ma_Bc").Text), Convert.ToInt32(dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Id_Phan_Loai").Value), dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Doanh_Thu").Value, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Tinh_Cong_Phat").Value, dgDuongthudi.Rows(dgDuongthudi.ActiveRow.Index).Cells("Duoc_Truyen").Value)
            myDuongThuDiNoiTinh.Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them(Id_Duong_Thu_Di, _
                            dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ten_Duong_Thu").Text, _
                            mabckhaithac, _
                            Convert.ToInt32(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text), _
                            Convert.ToInt32(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Tinh").Value), _
                            Convert.ToInt32(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Phan_Loai_Duong_Thu").Value))
        End If
    End Sub

    Private Sub dgDuongThuDiNoiTinh_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDuongThuDiNoiTinh.AfterCellUpdate
        'If e.Cell.Row.Cells("Ma_Bc").IsActiveCell Then
        '    AddNewRow(sender)
        'End If
        If e.Cell.Row.Cells("Ma_Bc").Text <> "" And e.Cell.Row.Cells("Phan_Loai_Duong_Thu").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgDuongThuDiNoiTinh_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDuongThuDiNoiTinh.AfterExitEditMode
        Dim Mabc As String = dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text
        Select Case dgDuongThuDiNoiTinh.ActiveCell.Column.Key
            Case "Ma_Bc"
                If dgDuongThuDiNoiTinh.ActiveCell.Text <> "" Then
                    If myDuongthudi.Kiem_Tra_MaBc(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Value, GBuu_Cuc_Khai_Thac) = True And dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Phan_Loai_Duong_Thu").Text = "" Then
                        CMessageBox.Show("Mã Bưu Cục:" & Mabc & " đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgDuongThuDiNoiTinh.ActiveCell
                        Exit Sub
                    End If
                    dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ten_Duong_Thu").Value = myDanhMuc.Lay(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text).Ten_Buu_Cuc
                    Try
                        dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ten_Duong_Thu").Value = myDanhMuc.Lay(dgDuongThuDiNoiTinh.Rows(dgDuongThuDiNoiTinh.ActiveRow.Index).Cells("Ma_Bc").Text).Ten_Buu_Cuc
                    Catch ex As Exception
                        Dim str As String = "Không tồn tại Mã Bc: " & Mabc & " Bạn phải vào bảng Mã Bc để nhập thêm !"
                        CMessageBox.Show(str, " Thông báo ")
                        Exit Sub
                    End Try
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Đường thư Bưu tá Nội bộ--------------------"
#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_InitializeLayout--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With myGridKeyDown.DisplayLayout
            .Bands(0).Columns("Ma_Bc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc").ValueList = ddMaBc

            .Bands(0).Columns("Ten_Duong_Thu").CellActivation = Activation.ActivateOnly
            .Bands(0).Columns("Ma_Tinh").CellActivation = Activation.ActivateOnly
            .Bands(0).Columns("Phan_Loai").Hidden = True

            '.Bands(0).Columns("Phan_Loai").Style = ColumnStyle.DropDownValidate
            '.Bands(0).Columns("Phan_Loai").ValueList = dd_Phan_Loai_Duong_Thu_Di
        End With
    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_InitializeTemplateAddRow--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Id_Duong_Thu").DefaultCellValue = ""
            .Columns("Phan_Loai").DefaultCellValue = 0
            .Columns("Ghi_Chu").DefaultCellValue = " "
        End With
    End Sub
#End Region

#Region "--------------------DataGrid_Duong_Thu_Buu_Ta_Noi_Bo--------------------"
    Private Sub DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
        dgDuong_Thu_Buu_Ta_Noi_Bo.DataSource = myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
        dgDuong_Thu_Buu_Ta_Noi_Bo.DataBind()
        dgDuong_Thu_Buu_Ta_Noi_Bo.Rows.Band.AddNew()
    End Sub
#End Region

#Region "--------------------Delete_Duong_Thu_Buu_Ta_Noi_Bo--------------------"
    Private Sub Delete_Duong_Thu_Buu_Ta_Noi_Bo()
        If dgDuong_Thu_Buu_Ta_Noi_Bo.ActiveRow.Cells("Ma_Bc").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim mId_Duong_Thu As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, dgDuong_Thu_Buu_Ta_Noi_Bo.ActiveRow.Cells("Ma_Bc").Text)
                myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Xoa(mId_Duong_Thu)
                dgDuong_Thu_Buu_Ta_Noi_Bo.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_AfterRowUpdate--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.AfterRowUpdate
        myGridKeyDown = sender
        'Ma_Duong_Thu
        If myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text = "" Then
            CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Bưu Tá Nội Bộ" & vbNewLine & "Chú ý: Mã đường thư không được để trống.", " Thông báo ")
            DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
            Exit Sub
        End If
        ''Phan_Loai
        'If myGridKeyDown.ActiveRow.Cells("Phan_Loai").Text = "" Then
        '    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Bưu Tá Nội Bộ" & vbNewLine & "Chú ý: Phân loại đường thư không được để trống.", " Thông báo ")
        '    DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
        '    Exit Sub
        'End If
        'Ghi_Chu
        'If myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text = "" Then
        '    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Đường Thư Bưu Tá Nội Bộ" & vbNewLine & "Chú ý: Ghi chú không được để trống.", " Thông báo ")
        '    DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
        '    Exit Sub
        'End If
        'Kiem tra xem da ton tai chua
        Dim mId_Duong_Thu As String
        mId_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text)
        If myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Lay(mId_Duong_Thu).Ma_Bc <> 0 And myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text = "" Then
            CMessageBox.Show("Đường thư này đã tồn tại, bạn không thể thêm vào bảng Đường Thư Bưu Tá Nội Bộ", " Thông báo ")
            DataGrid_Duong_Thu_Buu_Ta_Noi_Bo()
            Exit Sub
        End If
        'Cap nhat
        Dim mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet As New Duong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet
        Dim mDanh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
        mDanh_Muc_Bc_Chi_Tiet = myDanhMuc.Lay(myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text)
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Id_Duong_Thu = mId_Duong_Thu
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ten_Duong_Thu = mDanh_Muc_Bc_Chi_Tiet.Ten_Buu_Cuc
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc = myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Tinh = mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Phan_Loai = myGridKeyDown.ActiveRow.Cells("Phan_Loai").Value
        mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ghi_Chu = ConvetToABC(myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text)
        myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Cap_Nhat_Them(mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Id_Duong_Thu, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ten_Duong_Thu, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Bc, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ma_Tinh, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Phan_Loai, _
                                    mDuong_Thu_Buu_Ta_Noi_Bo_Chi_Tiet.Ghi_Chu)

    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_AfterCellUpdate--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.AfterCellUpdate
        'myGridKeyDown = sender
        'If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "Ma_Bc" Then
        '    If Not myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Value Is DBNull.Value Then
        '        MessageBox.Show("Không được sửa đổi mã đường thư, nếu muốn bạn hãy tạo đường thư mới và xoá đường thư cũ đi.", "Thông báo", MessageBoxButtons.OK)
        '        DataGrid_Duongthudi()
        '        'Gan bien = False de khong cho Next Cell
        '        myGridKeyDown.Tag = False
        '        Exit Sub
        '    Else
        '        If myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Di_Kiem_Tra_Ma_Duong_Thu(myGridKeyDown.ActiveRow.Cells("Ma_Bc").Value, GMa_Kho) = True Then
        '            CMessageBox.Show("Mã đường thư này đã tồn tại bạn không thể nhập thêm.", " Thông báo ")
        '            'Gan bien = False de khong cho Next Cell
        '            myGridKeyDown.Tag = False
        '            Exit Sub
        '        End If
        '    End If
        'End If        
        If e.Cell.Row.Cells("Ma_Bc").Text <> "" And e.Cell.Row.Cells("Ten_Duong_Thu").Text <> "" Then
            AddNewRow(sender)
        End If
        ''Neu khong van de gi gan bien = True de Next Cell
        'myGridKeyDown.Tag = True
    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_BeforeCellUpdate-------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.BeforeCellUpdate
        myGridKeyDown = sender
        myGridKeyDown.Tag = True
        'Neu la tao moi thi thoat
        If myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text = "" Then
            Exit Sub
        End If
        'Neu khong thay doi thi thoat
        If myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text = myGridKeyDown.ActiveRow.Cells("Ma_Bc").Value Then
            Exit Sub
        End If
        'Chi xu ly voi column MA_DUONG_THU va nhung duong thu da duoc tao roi
        If myGridKeyDown.ActiveCell.Column.Key.ToUpper <> "MA_BC" Then
            Exit Sub
        End If
        'Doi voi duong thu da nhap roi
        If myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text.Trim <> "" Then
            Dim mId_Duong_Thu As String
            mId_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, myGridKeyDown.ActiveRow.Cells("Ma_Bc").Value)
            If myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Lay(mId_Duong_Thu).Ma_Bc <> 0 Then
                MessageBox.Show("Không được sửa đổi mã đường thư, nếu muốn bạn hãy tạo đường thư mới và xoá đường thư cũ đi.", "Thông báo", MessageBoxButtons.OK)
                'DataGrid_Duongthudi()
                'Gan bien = False de khong cho Next Cell
                myGridKeyDown.Tag = False
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_AfterExitEditMode--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.AfterExitEditMode
        myGridKeyDown = sender
        'Kiem tra neu da co van de o AfterCellUpdate ==> Thoat luon
        If myGridKeyDown.Tag = False Then Exit Sub
        Select Case myGridKeyDown.ActiveCell.Column.Key.ToUpper
            Case "MA_BC"
                If ((myGridKeyDown.ActiveCell.Text = "") Or (myGridKeyDown.ActiveCell.Value Is DBNull.Value)) Then
                    Exit Sub
                End If
                Dim mId_Duong_Thu As String
                mId_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text)
                If myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Lay(mId_Duong_Thu).Ma_Bc <> 0 And myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text = "" Then
                    CMessageBox.Show("Mã đường thư này đã tồn tại bạn không thể nhập thêm.", " Thông báo ")
                    'Gan bien = False de khong cho Next Cell
                    myGridKeyDown.Tag = False
                    Exit Sub
                End If
                Dim mDanh_Muc_Bc_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
                mDanh_Muc_Bc_Chi_Tiet = myDanhMuc.Lay(myGridKeyDown.ActiveRow.Cells("Ma_Bc").Text)
                myGridKeyDown.ActiveRow.Cells("Ten_Duong_Thu").Value = mDanh_Muc_Bc_Chi_Tiet.Ten_Buu_Cuc.ToUpper
                myGridKeyDown.ActiveRow.Cells("Ma_Tinh").Value = mDanh_Muc_Bc_Chi_Tiet.Ma_Tinh
        End Select
        'Neu khong van de gi gan bien = True de Next Cell
        myGridKeyDown.Tag = True
    End Sub
#End Region

#Region "--------------------dgDuong_Thu_Buu_Ta_Noi_Bo_KeyDown--------------------"
    Private Sub dgDuong_Thu_Buu_Ta_Noi_Bo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDuong_Thu_Buu_Ta_Noi_Bo.KeyDown
        Try
            'Kiem tra cac KeyPress khong chuan ==> Thoat 
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape And e.KeyValue <> Keys.Tab Then
                Exit Sub
            End If
            If myGridKeyDown.ActiveRow Is Nothing Then
                Exit Sub
            End If
            myGridKeyDown = sender
            'Kiem tra Cell co Value = Null, khong cho next cell
            If myGridKeyDown.ActiveCell.Text = "" And myGridKeyDown.ActiveCell.Value Is DBNull.Value And (e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab) Then
                e.Handled = True
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                myCell = Nothing
                Exit Sub
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                'Case Keys.Right
                '    myCell = Nothing
                '    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                '    e.Handled = True
                '    myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter, Keys.Tab
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If myGridKeyDown.Tag = False Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        dgDuong_Thu_Buu_Ta_Noi_Bo.Tag = True
                        'If myGridKeyDown.Name = dgNoiBo.Name Then
                        '    dgNoiBo.Tag = True
                        'End If
                        Exit Sub
                    End If
                    'Neu khong van de gi thi cho Next Cell
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.F8
                    Delete_Duong_Thu_Buu_Ta_Noi_Bo()
                    e.Handled = True
                Case Keys.Escape
                    If myGridKeyDown.ActiveRow.Cells(0).Value Is DBNull.Value And myGridKeyDown.ActiveRow.Cells(0).Text = "" Then
                        myGridKeyDown.ActiveRow.Delete(False)
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                Case Keys.F1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "--------------------Danh mục bưu cục--------------------"
#Region "--------------------dgDmMaBC_InitializeLayout--------------------"
    Private Sub dgDmMaBC_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDmMaBC.InitializeLayout
        dgDmMaBC.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDmMaBC.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgDmMaBC.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        dgDmMaBC.Tag = True
        With dgDmMaBC.DisplayLayout
            .Bands(0).Columns("Ma_Quan_Ly").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Quan_Ly").ValueList = ddQuanLy
            .Bands(0).Columns("Ma_Bc_Cha").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Cha").ValueList = ddMaBc
            .Bands(0).Columns("Ma_Tinh").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Tinh").ValueList = ddMaTinh
            .Bands(0).Columns("Ma_Don_Vi").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Don_Vi").ValueList = ddMaDonVi
            .Bands(0).Columns("Ma_Nc").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Nc").ValueList = ddMa_Nuoc

            'Ẩn các cột đi
            dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Nc").Hidden = True
            dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Tinh").Hidden = True
            If cbMa_Nuoc.Text = "VN" Then
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Nc").DefaultCellValue = "VN"
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Tinh").DefaultCellValue = CInt(cbMa_Tinh.Text)

                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Don_Vi").Hidden = False
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Bc_Cha").Hidden = False
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Cap_Buu_Cuc").Hidden = False
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Quan_Ly").Hidden = False
            Else
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Nc").DefaultCellValue = cbMa_Nuoc.Text
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Tinh").DefaultCellValue = 0
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Don_Vi").DefaultCellValue = "0"
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Bc_Cha").DefaultCellValue = 0
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Cap_Buu_Cuc").DefaultCellValue = 0
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Quan_Ly").DefaultCellValue = "0"

                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Don_Vi").Hidden = True
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Bc_Cha").Hidden = True
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Cap_Buu_Cuc").Hidden = True
                dgDmMaBC.DisplayLayout.Bands(0).Columns("Ma_Quan_Ly").Hidden = True
            End If
        End With
    End Sub
#End Region

#Region "--------------------dgDmMaBC_InitializeTemplateAddRow--------------------"
    Private Sub dgDmMaBC_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDmMaBC.InitializeTemplateAddRow
        If cbMa_Nuoc.Text = "VN" Then

        Else

        End If
    End Sub
#End Region

#Region "--------------------DataGrid_DmMaBC--------------------"
    Private Sub DataGrid_DmMaBC(ByVal Ma_Nuoc As String, ByVal Ma_Tinh As Integer)
        If Ma_Nuoc = "VN" Then 'Lấy theo mã tỉnh
            dgDmMaBC.DataSource = myDanhMuc.Danh_Sach_Lay_Theo_Ma_Tinh(Ma_Tinh).Tables(0)
        Else 'Lấy theo mã nước
            dgDmMaBC.DataSource = myDanhMuc.Danh_Sach_Lay_Theo_Ma_Nuoc(Ma_Nuoc).Tables(0)
        End If
        dgDmMaBC.DataBind()
        dgDmMaBC.Rows.Band.AddNew()
    End Sub
#End Region

#Region "--------------------Delete_DmMaBc--------------------"
    Private Sub Delete_DmMaBc()
        If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDanhMuc.Xoa(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text)
                dgDmMaBC.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDmMaBC_AfterRowUpdate--------------------"
    Private Sub dgDmMaBC_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDmMaBC.AfterRowUpdate
        'Trung ma IPMC thi thoat
        If dgDmMaBC.Tag = False Then Exit Sub

        If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc_Cha").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Tinh").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Cap_Buu_Cuc").Text = "" And _
            dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Quan_Ly").Text = "" Then
            Exit Sub
        Else
            If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Mã BC không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Tên BC không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If cbMa_Nuoc.Text = "VN" Then 'Nếu mã nước là Việt Nam
                If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc_Cha").Text = "" Then
                    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Mã BC Cha không được để trống.", " Thông báo ")
                    Exit Sub
                End If
                If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text = "" Then
                    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Mã Đơn Vị không được để trống.", " Thông báo ")
                    Exit Sub
                End If
                If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Cap_Buu_Cuc").Text = "" Then
                    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Cấp BC không được để trống.", " Thông báo ")
                    Exit Sub
                End If

                If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Quan_Ly").Text = "" Then
                    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục" & vbNewLine & " Mã Quản Lý không được để trống.", " Thông báo ")
                    Exit Sub
                End If
            Else 'Nếu không phải là việt nam
                If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("IPMC").Text = "" Then
                    If MessageBox.Show("           Bạn chưa nhập mã bưu cục chữ!!!" & vbNewLine & _
                                        "Bạn có muốn tiếp tục mà không nhập mã bưu cục chữ không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        dgDmMaBC.ActiveRow.Delete(False)
                        Exit Sub
                    End If
                Else 'Có nhập mã bưu cục chữ
                    If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("IPMC").Text.Length <> 6 Then 'Nhập sai định dạng
                        MessageBox.Show("Bạn nhập mã bưu cục chữ không đúng định dạng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            End If
        End If

        If cbMa_Nuoc.Text = "VN" Then 'Nếu là Việt Nam
            If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc_Cha").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Tinh").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Cap_Buu_Cuc").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Quan_Ly").Text <> "" Then
                'Cập nhật
                myDanhMuc.Cap_Nhat_Them(Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_BC").Text), _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text, _
                                                                Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc_Cha").Text), _
                                                                Convert.ToInt32(cbMa_Tinh.Text), _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text, _
                                                                Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Cap_Buu_Cuc").Text), _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dia_Chi").Text, _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dien_Thoai").Text, _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Fax").Text, _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Quan_Ly").Text, _
                                                                Trim(cbMa_Nuoc.Text), _
                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("IPMC").Text)

            End If

        Else 'Nếu là nước ngoài
            If dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc").Text <> "" And _
                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text <> "" Then

                myDanhMuc.Cap_Nhat_Them(Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_BC").Text), _
                                                                                0, _
                                                                                0, _
                                                                                0, _
                                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text, _
                                                                                0, _
                                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dia_Chi").Text, _
                                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dien_Thoai").Text, _
                                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Fax").Text, _
                                                                                0, _
                                                                                Trim(cbMa_Nuoc.Text), _
                                                                                dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("IPMC").Text)
            End If
        End If

        'myDanhMuc.Cap_Nhat_Them(Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_BC").Text), _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text, _
        '                        Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Bc_Cha").Text), _
        '                        Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Tinh").Text), _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ten_Buu_Cuc").Text, _
        '                        Convert.ToInt32(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Cap_Buu_Cuc").Text), _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dia_Chi").Text, _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Dien_Thoai").Text, _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Fax").Text, _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Quan_Ly").Text, _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Nc").Text, _
        '                        dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("IPMC").Text)

        Exit Sub
    End Sub
#End Region

#Region "--------------------dgDmMaBC_AfterCellUpdate--------------------"
    Private Sub dgDmMaBC_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDmMaBC.AfterCellUpdate
        'If e.Cell.Row.Cells("Ma_BC").IsActiveCell Then
        '    AddNewRow(sender)
        'End If
        'Kiem tra da ton tai ma IPMC nay chua
        If Trim(e.Cell.Row.Cells("IPMC").Text) <> "" Then
            If UCase(e.Cell.Column.Key) = "IPMC" Then
                If CheckIPMC(Trim(e.Cell.Row.Cells("IPMC").Text)) = True Then
                    MsgBox("Mã IPMC này đã tồn tại, vì vậy không thể cập nhật vào Danh mục Bưu cục!!!", MsgBoxStyle.Information, "Thông báo")
                    dgDmMaBC.Tag = False
                    myCell = dgDmMaBC.ActiveCell
                    Exit Sub
                Else
                    dgDmMaBC.Tag = True
                End If
            End If
        Else
            dgDmMaBC.Tag = True
        End If
        If e.Cell.Row.Cells("Ma_BC").Text <> "" And e.Cell.Row.Cells("Ma_Don_Vi").Text <> "" And e.Cell.Row.Cells("Ma_Bc_Cha").Text <> "" And e.Cell.Row.Cells("Ma_Tinh").Text <> "" And e.Cell.Row.Cells("Ten_Buu_Cuc").Text <> "" And e.Cell.Row.Cells("Cap_Buu_Cuc").Text <> "" And e.Cell.Row.Cells("Ma_Quan_Ly").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "--------------------dgDmMaBC_AfterExitEditMode--------------------"
    Private Sub dgDmMaBC_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDmMaBC.AfterExitEditMode
        Dim Mabc As String = dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_BC").Text
        Select Case dgDmMaBC.ActiveCell.Column.Key
            Case "Ma_BC"
                If dgDmMaBC.ActiveCell.Text <> "" Then
                    If myDanhMuc.Kiem_Tra_MaBc(dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_BC").Value) = True And dgDmMaBC.Rows(dgDmMaBC.ActiveRow.Index).Cells("Ma_Don_Vi").Text = "" Then
                        CMessageBox.Show("Mã Bưu Cục:" & Mabc & " đã tồn tại trong bảng, bạn hãy kiểm tra lại.", " Thông báo ")
                        myCell = dgDmMaBC.ActiveCell
                        Exit Sub
                    End If
                End If
            Case "IPMC"
                If dgDmMaBC.ActiveCell.Text <> "" Then
                    dgDmMaBC.ActiveCell.Text.ToUpper()
                End If
        End Select
    End Sub
#End Region

#Region "--------------------cbMa_Nuoc_KeyDown--------------------"
    Private Sub cbMa_Nuoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMa_Nuoc.KeyDown, cbMa_Tinh.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#Region "--------------------cbMa_Nuoc_RowSelected--------------------"
    Private Sub cbMa_Nuoc_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles cbMa_Nuoc.RowSelected
        Try
            If cbMa_Nuoc.Text = "VN" Then 'Nếu là bưu cục trong nước
                cbMa_Tinh.Enabled = True
                cbMa_Tinh.DataSource = myMaTinh.Danh_Sach
                cbMa_Tinh.DataBind()
                If cbMa_Tinh.Rows.Count > 0 Then
                    cbMa_Tinh.Value = myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
                    cbMa_Tinh.Text = myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
                    cbMa_Tinh_RowSelected(sender, e)
                End If
            Else
                cbMa_Tinh.Enabled = False
                cbMa_Tinh.DataSource = Nothing
                cbMa_Tinh.DataBind()
                cbMa_Tinh.Text = ""
                If (cbMa_Nuoc.Text <> "") And Not (cbMa_Nuoc.Text Is Nothing) Then
                    DataGrid_DmMaBC(cbMa_Nuoc.Text, 0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------------------cbMa_Tinh_RowSelected--------------------"
    Private Sub cbMa_Tinh_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles cbMa_Tinh.RowSelected
        Try
            If (cbMa_Tinh.Text <> "") And Not (cbMa_Tinh.Text Is Nothing) Then
                DataGrid_DmMaBC("VN", CInt(cbMa_Tinh.Text))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------------------CheckIPMC--------------------"
    'Kiem tra ma IPMC da ton tai chua khi cap nhat Danh muc BC
    'Neu tim thay thi tra ve gia tri TRUE  -  else FALSE
    Private Function CheckIPMC(ByVal IPMC_input As String) As Boolean
        Dim myDanhMucBuuCuc As New Danh_Muc_BC(GConnectionString)
        If myDanhMucBuuCuc.Lay_Boi_IPMC(IPMC_input).Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region
#End Region

#Region "--------------------Mã bưu cục khai thác--------------------"
    Private Sub dgMabckt_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMabckt.InitializeLayout
        dgMabckt.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMabckt.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMabckt.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgMabckt.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Khai_Thac").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Khai_Thac").ValueList = ddMaBc
            'Phân loại Mã Bc khai thác
            .Bands(0).Columns("OutBout").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("OutBout").ValueList = ddPhan_Loai_Ma_Bc_Khai_Thac
        End With
    End Sub

    Private Sub dgMabckt_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgMabckt.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("OutBout").DefaultCellValue = 0
        End With
    End Sub

    Private Sub DataGrid_Mabckt()
        dgMabckt.DataSource = myMabckt.Danh_Sach.Tables(0)
        dgMabckt.DataBind()
        dgMabckt.Rows.Band.AddNew()
    End Sub

    Private Sub dgMabckt_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMabckt.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Bc_Khai_Thac").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub Delete_Mabckt()
        If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myMabckt.Xoa(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text)
                dgMabckt.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgMabckt_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgMabckt.AfterRowUpdate
        If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
            Exit Sub
        Else
            If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục Khai Thác" & vbNewLine & " Mã Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục Khai Thác." & vbNewLine & " Tên Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("OutBout").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Bưu Cục Khai Thác." & vbNewLine & " Phân loại Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text <> "" Then
            myMabckt.Cap_Nhat_Them(Convert.ToInt32(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text), dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text, Convert.ToInt32(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("OutBout").Value))
        End If
    End Sub
    Private Sub dgMabckt_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMabckt.AfterExitEditMode
        Select Case dgMabckt.ActiveCell.Column.Key
            Case "Ma_Bc_Khai_Thac"
                If dgMabckt.ActiveCell.Text <> "" Then
                    If myMabckt.Chk_Ma_Bc_Khai_Thac(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text) = True And dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Text = "" Then
                        CMessageBox.Show("Mã BC Khai Thác này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgMabckt.ActiveCell
                        Exit Sub
                    End If
                    dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ten_Bc_Khai_Thac").Value = myDanhMuc.Lay(dgMabckt.Rows(dgMabckt.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text).Ten_Buu_Cuc
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Lý Do--------------------"
    Private Sub dgLydo_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgLydo.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Ly_Do").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub DataGrid_Lydo()
        dgLydo.DataSource = myLydo.Danh_Sach.Tables(0)
        dgLydo.DataBind()
        dgLydo.Rows.Band.AddNew()
    End Sub


    Private Sub dgLydo_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgLydo.InitializeLayout
        dgLydo.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgLydo.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgLydo.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub Delete_LyDo()
        If dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myLydo.Xoa(dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text)
                dgLydo.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgLydo_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgLydo.AfterRowUpdate
        If dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text = "" And dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ten_Ly_Do").Text = "" And dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ten_Ly_Do_EN").Text = "" And dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("To_Hop_Xu_Ly").Text = "" Then
            Exit Sub
        Else
            If dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Lý Do." & vbNewLine & " Tên Mã Lý Do không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("To_Hop_Xu_Ly").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Lý Do." & vbNewLine & " Tổ Hợp Xử Lý không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If

        If dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text <> "" And dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text.Length > 0 Then
            myLydo.Cap_Nhat_Them(Convert.ToInt32(dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Value), dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ten_Ly_Do").Text, dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ten_Ly_Do_EN").Text, dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("To_Hop_Xu_Ly").Text)
        End If
    End Sub

    Private Sub dgLydo_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLydo.AfterExitEditMode
        Select Case dgLydo.ActiveCell.Column.Key
            Case "Ma_Ly_Do"
                If dgLydo.ActiveCell.Text <> "" Then
                    If myLydo.Chk_Ma_Ly_Do(dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("Ma_Ly_Do").Text) = True And dgLydo.Rows(dgLydo.ActiveRow.Index).Cells("To_Hop_Xu_Ly").Text = "" Then
                        CMessageBox.Show("Mã Lý Do này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgLydo.ActiveCell
                        Exit Sub
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Xử lý--------------------"
    Private Sub dgXuly_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgXuly.InitializeLayout
        dgXuly.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgXuly.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgXuly.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_Xuly()
        dgXuly.DataSource = myXuly.Danh_Sach.Tables(0)
        dgXuly.DataBind()
        dgXuly.Rows.Band.AddNew()
    End Sub
    Private Sub Delete_Xuly()
        If dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myXuly.Xoa(dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text)
                dgXuly.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgXuly_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgXuly.AfterRowUpdate
        If dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text = "" And dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ten_Xu_Ly").Text = "" And dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ten_Xu_Ly_EN").Text = "" Then
            Exit Sub

        End If
        If dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text <> "" And dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text.Length = 1 Then
            myXuly.Cap_Nhat_Them(dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text.ToUpper, dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ten_Xu_Ly").Text, dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ten_Xu_Ly_EN").Text)
        End If
    End Sub
    Private Sub dgXuly_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgXuly.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Xu_Ly").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgXuly_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgXuly.AfterExitEditMode
        Select Case dgXuly.ActiveCell.Column.Key
            Case "Ma_Xu_Ly"
                If dgXuly.ActiveCell.Text <> "" Then
                    If myXuly.Chk_Ma_Xu_Ly(dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ma_Xu_Ly").Text.ToUpper) = True And dgXuly.Rows(dgXuly.ActiveRow.Index).Cells("Ten_Xu_Ly").Text = "" Then
                        CMessageBox.Show("Mã Xử Lý này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgXuly.ActiveCell
                    End If
                    If dgXuly.ActiveCell.Text.Length > 1 Then
                        CMessageBox.Show("'Mã Xử Lý' chỉ được phép nhập 1 ký tự.", " Thông báo ")
                        myCell = dgXuly.ActiveCell
                        Exit Sub
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Tọa độ In--------------------"
    Private Sub dgToaDoIn_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgToaDoIn.InitializeLayout
        dgToaDoIn.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgToaDoIn.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgToaDoIn.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub
    Private Sub DataGrid_ToaDoIn()
        'dgToaDoIn.DataSource = myToaDoIn.Danh_Sach.Tables(0)
        'dgToaDoIn.DataBind()
        'dgToaDoIn.Rows.Band.AddNew()
    End Sub
    Private Sub Delete_ToaDoIn()
        If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Id_Toa_Do").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myToaDoIn.Xoa(Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Id_Toa_Do").Text))
                dgToaDoIn.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub dgToaDoIn_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgToaDoIn.AfterRowUpdate
        If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text = "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text = "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text = "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text = "" Then
            Exit Sub
        Else
            If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Kho_Giay").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Toạ Độ In." & vbNewLine & "Chú ý: Khổ Giấy không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Toạ Độ In." & vbNewLine & "Chú ý: Tên Đối Tượng không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Toạ Độ In." & vbNewLine & "Chú ý: Tên Đối Tượng VN không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Toạ Độ In." & vbNewLine & "Chú ý: Toạ Độ Trên không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Toạ Độ In." & vbNewLine & "Chú ý: Toạ Độ Trái không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Id_Toa_Do").Text = "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Kho_Giay").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text <> "" Then
            myToaDoIn.Cap_Nhat_Them(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Kho_Giay").Text, dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text, dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text, Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text), Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text))
        ElseIf dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Id_Toa_Do").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Kho_Giay").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text <> "" And dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text <> "" Then
            myToaDoIn.Cap_Nhat(Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Id_Toa_Do").Text), dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Kho_Giay").Text, dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong").Text, dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Ten_Doi_Tuong_VN").Text, Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Top").Text), Convert.ToInt32(dgToaDoIn.Rows(dgToaDoIn.ActiveRow.Index).Cells("Toa_Do_Left").Text))

        End If
    End Sub
    Private Sub dgToaDoIn_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgToaDoIn.AfterCellUpdate
        If e.Cell.Row.Cells("Ten_Doi_Tuong").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
    Private Sub dgToaDoIn_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgToaDoIn.AfterExitEditMode

    End Sub

    Private Sub cbKhoGiay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbKhoGiay.Validated
        dgToaDoIn.DataSource = myToaDoIn.Danh_Sach_Lay_Boi_Kho_Giay(cbKhoGiay.Text).Tables(0)
        dgToaDoIn.DataBind()
        dgToaDoIn.Rows.Band.AddNew()
    End Sub
#End Region

#Region "--------------------Mã Ca--------------------"
    Private Sub dgMaca_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMaca.InitializeLayout
        dgMaca.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMaca.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMaca.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgMaca.DisplayLayout
            .Bands(0).Columns("Ma_Bc_Khai_Thac").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Ma_Bc_Khai_Thac").ValueList = ddMaBcKt
        End With
    End Sub
    Private Sub DataGrid_Maca()
        dgMaca.DataSource = myMaca.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        dgMaca.DataBind()
        dgMaca.Rows.Band.AddNew()
    End Sub
    Private Sub Delete_Maca()
        If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca_Khai_Thac").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myMaca.Xoa(dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca_Khai_Thac").Text)
                dgMaca.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgMaca_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgMaca.AfterRowUpdate
        If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text = "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text = "" Then
        Else
            If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Ca." & vbNewLine & " Mã Bc Khai Thác không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Ca." & vbNewLine & " Ca không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Ca." & vbNewLine & " Ca Kế Toán không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca_Khai_Thac").Text = "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text <> "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text <> "" Then
            myMaca.Cap_Nhat_Them(GBuu_Cuc_Khai_Thac, dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text, Convert.ToInt32(dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text))
        ElseIf dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca_Khai_Thac").Text <> "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text <> "" And dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text <> "" Then
            myMaca.Cap_Nhat(Convert.ToInt32(dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca_Khai_Thac").Text), GBuu_Cuc_Khai_Thac, dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ca").Text, Convert.ToInt32(dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Thu_Tu").Text))
        End If
    End Sub

    Private Sub dgMaca_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMaca.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Bc_Khai_Thac").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgMaca_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMaca.AfterExitEditMode
        Select Case dgMaca.ActiveCell.Column.Key
            Case "Thu_Tu"
                If dgMaca.Rows(dgMaca.ActiveRow.Index).Cells("Ma_Bc_Khai_Thac").Text <> "" Then
                    If dgMaca.ActiveCell.Text.Length > 1 Then
                        CMessageBox.Show("Bạn không thể nhập quá 1 ký tự vào 'Ca Kế Toán'.", " Thông báo ")
                        myCell = dgMaca.ActiveCell
                        Exit Sub
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Tỷ giá--------------------"
    Private Sub dgTygia_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTygia.InitializeLayout
        dgTygia.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgTygia.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgTygia.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_Tygia()
        dgTygia.DataSource = myTygia.Danh_Sach_Hien_Thi.Tables(0)
        dgTygia.DataBind()
        dgTygia.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_Tygia()
        If dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myTygia.Xoa(myHamdungchung.ConvertDateToInt(dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Value))
                dgTygia.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgTygia_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgTygia.AfterRowUpdate
        If dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Text = "" And dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ty_Gia").Text = "" Then
            Exit Sub
        Else
            If dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Ca." & vbNewLine & " Ngày không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ty_Gia").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Ca." & vbNewLine & " Tỷ Giá không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Text <> "" And dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ty_Gia").Text <> "" Then
            myTygia.Cap_Nhat_Them(myHamdungchung.ConvertDateToInt(dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Value), Convert.ToInt32(dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ty_Gia").Value))
        End If
    End Sub

    Private Sub dgTygia_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgTygia.AfterCellUpdate
        If e.Cell.Row.Cells("Ngay").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgTygia_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTygia.AfterExitEditMode
        Try
            Select Case dgTygia.ActiveCell.Column.Key
                Case "Ngay"
                    If dgTygia.ActiveCell.Text <> "" Then
                        If dgTygia.ActiveCell.Value > DateTime.Now.Date Then
                            CMessageBox.Show("'Ngày' không được lớn hơn Ngày hiện tại.", " Thông báo ")
                            myCell = dgTygia.ActiveCell
                            Exit Sub
                        End If
                        If myTygia.Kiem_Tra_Trung_Ngay(Ham_Dung_Chung.ConvertDateToInt(dgTygia.Rows(dgTygia.ActiveRow.Index).Cells("Ngay").Value)) = True Then
                            CMessageBox.Show("Trùng Ngày", " Thông báo ")
                            myCell = dgTygia.ActiveCell
                            Exit Sub
                        End If
                    End If
            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString(), "Thông báo")
        End Try
    End Sub
#End Region

#Region "--------------------Khách hàng--------------------"
    Private Sub dgKhachhang_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgKhachhang.InitializeLayout
        dgKhachhang.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgKhachhang.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgKhachhang.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_Khachhang()
        dgKhachhang.DataSource = myKhachHang.Danh_Sach_Hien_Thi.Tables(0)
        dgKhachhang.DataBind()
        dgKhachhang.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_KhachHang()
        If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myKhachHang.Xoa(dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text)
                dgKhachhang.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgKhachhang_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgKhachhang.AfterRowUpdate
        If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ten_Khach_Hang").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Ket_Thuc").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Fax").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Dien_Thoai").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Fax").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Email").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Dia_Chi").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_So_Thue").Text = "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Text = "" Then
            Exit Sub
        Else
            If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Khách Hàng." & vbNewLine & "Chú ý: Mã Khách Hàng không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ten_Khach_Hang").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Khách Hàng." & vbNewLine & "Chú ý: Tên Khách Hàng không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Khách Hàng." & vbNewLine & "Chú ý: Ngày Khởi Tạo không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Ket_Thuc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Khách Hàng." & vbNewLine & "Chú ý: Ngày Kết Thúc không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Khách Hàng." & vbNewLine & "Chú ý: Vat không được để trống.", " Thông báo ")
                Exit Sub
            End If

        End If
        If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text <> "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ten_Khach_Hang").Text <> "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Text <> "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Ket_Thuc").Text <> "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Dien_Thoai").Text <> "" And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Text <> "" Then
            myKhachHang.Cap_Nhat_Them(dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ten_Khach_Hang").Text, myHamdungchung.ConvertDateToInt(dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Value), myHamdungchung.ConvertDateToInt(dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Ket_Thuc").Value), dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Dien_Thoai").Text, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Fax").Text, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Email").Text, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Dia_Chi").Text, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_So_Thue").Text, Convert.ToDouble(dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Text), dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Khach_Hang_Toan_Quoc").Value, dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Truyen_Khai_Thac").Value)
        End If
    End Sub

    Private Sub dgKhachhang_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgKhachhang.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_KH").Text <> "" And e.Cell.Row.Cells("Ten_Khach_Hang").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub
    Private Sub dgKhachhang_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgKhachhang.AfterExitEditMode
        Select Case dgKhachhang.ActiveCell.Column.Key
            Case "Ma_KH"
                If dgKhachhang.ActiveCell.Text <> "" Then
                    If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Khach_Hang_Toan_Quoc").Value Is System.DBNull.Value Then
                        dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Khach_Hang_Toan_Quoc").Value = CheckState.Unchecked
                    End If
                    If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Truyen_Khai_Thac").Value Is System.DBNull.Value Then
                        dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Truyen_Khai_Thac").Value = CheckState.Unchecked
                    End If
                    If myKhachHang.Chk_Ma_KH(Convert.ToString(GBuu_Cuc_Khai_Thac) + dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ma_KH").Text) = True And dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ten_Khach_Hang").Text = "" Then
                        CMessageBox.Show("Mã Khách Hàng này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgKhachhang.ActiveCell
                    End If
                End If
            Case "Ngay_Ket_Thuc"
                If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Text <> "" Then
                    If dgKhachhang.ActiveCell.Value < dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Ngay_Khoi_Tao").Value Then
                        CMessageBox.Show("'Ngày Kết Thúc' phải lớn hơn hoặc bằng Ngày Khởi Tạo.", " Thông báo ")
                        myCell = dgKhachhang.ActiveCell
                        Exit Sub
                    End If
                End If
            Case "Vat"
                If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Text <> "" Then
                    If dgKhachhang.Rows(dgKhachhang.ActiveRow.Index).Cells("Vat").Value >= 1 Then
                        CMessageBox.Show("'Vat' phải nhỏ hơn 1.", " Thông báo ")
                        myCell = dgKhachhang.ActiveCell
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Quầy--------------------"
    Private Sub dgQuay_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgQuay.InitializeLayout
        dgQuay.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgQuay.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgQuay.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_Quay()
        dgQuay.DataSource = myQuay.Danh_Sach.Tables(0)
        dgQuay.DataBind()
        dgQuay.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_Quay()
        If dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQuay.Xoa(dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text)
                dgQuay.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgQuay_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgQuay.AfterRowUpdate
        If dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text = "" And dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ten_Quay").Text = "" And dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Dien_Thoai").Text = "" Then
            Exit Sub
        Else
            If dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Quầy." & vbNewLine & "Chú ý: Mã Quầy không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ten_Quay").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Quầy." & vbNewLine & "Chú ý: Tên Quầy không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        If dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text <> "" And dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ten_Quay").Text <> "" Then
            myQuay.Cap_Nhat_Them(Convert.ToInt32(dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Value), dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ten_Quay").Text, dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Dien_Thoai").Text)
        End If
    End Sub

    Private Sub dgQuay_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgQuay.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Quay").Text <> "" And e.Cell.Row.Cells("Ten_Quay").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgQuay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQuay.AfterExitEditMode
        Select Case dgQuay.ActiveCell.Column.Key
            Case "Ma_Quay"
                If dgQuay.ActiveCell.Text <> "" Then
                    If myQuay.Chk_Ma_Quay(dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ma_Quay").Text) = True And dgQuay.Rows(dgQuay.ActiveRow.Index).Cells("Ten_Quay").Text = "" Then
                        CMessageBox.Show("Mã Quầy này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgQuay.ActiveCell
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Thông tin nội bộ--------------------"
    Private Sub dgNoiBo_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgNoiBo.InitializeLayout
        dgNoiBo.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgNoiBo.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgNoiBo.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgNoiBo.DisplayLayout
            .Bands(0).Columns("Kenh_Truyen").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Kenh_Truyen").ValueList = ddKenhTruyen
        End With
    End Sub

    Private Sub DataGrid_Thongtinnoibo()
        dgNoiBo.DataSource = myNoiBo.Danh_Sach.Tables(0)
        dgNoiBo.DataBind()
    End Sub

    Private Sub dgNoiBo_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgNoiBo.AfterRowUpdate
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_E1_Max").Text = "" Then
            Exit Sub
        End If
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_E1_Duoc_Trung").Text = "" Then
            Exit Sub
        End If
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_Cho_Phep_Nhap_Bao_Phat").Text = "" Then
            Exit Sub
        End If
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_Vo_Tui").Text = "" Then
            Exit Sub
        End If
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ma_Tinh").Text = "" Then
            Exit Sub
        End If
        If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Tien_E1_Max").Text = "" Then
            Exit Sub
        End If
        'If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Nguoi_Gui_Paypost").Text = "" Then
        '    Exit Sub
        'End If
        'If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ma_KH_Gui_Paypost").Text = "" Then
        '    Exit Sub
        'End If

        'If dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_E1_Max").Text <> "" And dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_E1_Duoc_Trung").Text <> "" And dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_Cho_Phep_Nhap_Bao_Phat").Text <> "" And dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_Vo_Tui").Text <> "" And dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ma_Tinh").Text <> "" And dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Tien_E1_Max").Text <> "" Then
        'Cap nhat thong tin noi bo
        myNoiBo.Cap_Nhat_Them("EMS", Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_E1_Max").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_E1_Duoc_Trung").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_Cho_Phep_Nhap_Bao_Phat").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Ngay_Cho_Phep_Sua_E1").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Khoi_Luong_Vo_Tui").Text), Convert.ToBoolean(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Nhap_Bao_Phat_Khong_E1").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Kenh_Truyen").Value), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ma_Tinh").Text), Convert.ToInt32(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("So_Tien_E1_Max").Text), dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ip_May_Center").Text, dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("URL_Tra_Cuu").Text, Convert.ToDouble(dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Phien_Ban").Text), dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Nguoi_Gui_Paypost").Text, dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Dia_Chi_Gui_Paypost").Text, dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Dien_Thoai_Gui_Paypost").Text, dgNoiBo.Rows(dgNoiBo.ActiveRow.Index).Cells("Ma_KH_Gui_Paypost").Text)
        'End If
    End Sub

    Private Sub dgNoiBo_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgNoiBo.AfterExitEditMode
        Select Case dgNoiBo.ActiveCell.Column.Key
            Case "Khoi_Luong_E1_Max"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Khối lượng E1 tối đa không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
            Case "So_Ngay_E1_Duoc_Trung"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số ngày E1 được phép trùng không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
            Case "So_Ngay_Cho_Phep_Nhap_Bao_Phat"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số ngày cho phép nhập báo phát trùng không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
            Case "Khoi_Luong_Vo_Tui"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Khối lượng vỏ túi không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
            Case "Ma_Tinh"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Mã Tỉnh hiện tại không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
            Case "So_Tien_E1_Max"
                If dgNoiBo.ActiveCell.Text.Length = 0 Then
                    CMessageBox.Show("Số tiền E1 tối đa không được để trống.", "Thông báo")
                    myCell = dgNoiBo.ActiveCell
                    Exit Sub
                End If
                'Case "Nguoi_Gui_Paypost"
                '    If dgNoiBo.ActiveCell.Text.Length = 0 Then
                '        CMessageBox.Show("Tên đơn vị không được để trống.", "Thông báo")
                '        myCell = dgNoiBo.ActiveCell
                '        Exit Sub
                '    End If
                'Case "Dia_Chi_Gui_Paypost"
                '    If dgNoiBo.ActiveCell.Text.Length = 0 Then
                '        CMessageBox.Show("Địa chỉ đơn vị không được để trống.", "Thông báo")
                '        myCell = dgNoiBo.ActiveCell
                '        Exit Sub
                '    End If
                'Case "Dien_Thoai_Gui_Paypost"
                '    If dgNoiBo.ActiveCell.Text.Length = 0 Then
                '        CMessageBox.Show("Điện thoại đơn vị không được để trống.", "Thông báo")
                '        myCell = dgNoiBo.ActiveCell
                '        Exit Sub
                '    End If
                'Case "Ma_KH_Gui_Paypost"
                '    If dgNoiBo.ActiveCell.Text.Length = 0 Then
                '        CMessageBox.Show("Mã đơn vị không được để trống.", "Thông báo")
                '        myCell = dgNoiBo.ActiveCell
                '        Exit Sub
                '    End If
        End Select
    End Sub
#End Region

#Region "---------------------Dịch vụ--------------------"
    Private Sub dgDichVu_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDichVu.InitializeLayout
        dgDichVu.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgDichVu.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgDichVu.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        With dgDichVu.DisplayLayout
            .Bands(0).Columns("Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Phan_Loai").ValueList = ddPhanLoaiDV
        End With
    End Sub

    Private Sub DataGrid_DichVu()
        dgDichVu.DataSource = myDichVu.Danh_Sach.Tables(0)
        dgDichVu.DataBind()
        dgDichVu.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_DichVu()
        If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDichVu.Xoa(dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text)
                dgDichVu.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgDichVu_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDichVu.AfterRowUpdate
        If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text = "" And dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ten_Dich_Vu").Text = "" And dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Phan_Loai").Text = "" Then
            Exit Sub
        Else
            If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Dịch Vụ." & vbNewLine & "Chú ý: Mã Dịch Vụ không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ten_Dich_Vu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Dịch Vụ." & vbNewLine & "Chú ý: Tên Dịch Vụ không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Phan_Loai").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Dịch Vụ." & vbNewLine & "Chú ý: Phân Loại không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        '' Cập nhật
        If dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text <> "" And dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ten_Dich_Vu").Text <> "" And dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Phan_Loai").Text <> "" Then
            myDichVu.Cap_Nhat_Them(dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text.ToUpper, dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ten_Dich_Vu").Text, Convert.ToInt32(dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Phan_Loai").Value))
        End If
    End Sub

    Private Sub dgDichVu_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDichVu.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Dich_Vu").Text <> "" And e.Cell.Row.Cells("Ten_Dich_Vu").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgDichVu_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDichVu.AfterExitEditMode
        Select Case dgDichVu.ActiveCell.Column.Key
            Case "Ma_Dich_Vu"
                If dgDichVu.ActiveCell.Text <> "" Then
                    If myDichVu.Chk_Ma_Dich_Vu(dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ma_Dich_Vu").Text) = True And dgDichVu.Rows(dgDichVu.ActiveRow.Index).Cells("Ten_Dich_Vu").Text = "" Then
                        CMessageBox.Show("Mã Dịch Vụ này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgDichVu.ActiveCell
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Quản lý--------------------"
    Private Sub dgQuanLy_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgQuanLy.InitializeLayout
        dgQuanLy.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgQuanLy.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgQuanLy.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_QuanLy()
        dgQuanLy.DataSource = myQuanLy.Danh_Sach.Tables(0)
        dgQuanLy.DataBind()
        dgQuanLy.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_QuanLy()
        If dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQuanLy.Xoa(dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text)
                dgQuanLy.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgQuanLy_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgQuanLy.AfterRowUpdate
        If dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text = "" And dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ten_Quan_Ly").Text = "" Then
            Exit Sub
        Else
            If dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Quản Lý." & vbNewLine & "Chú ý: Mã Quản Lý không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ten_Quan_Ly").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Quản Lý." & vbNewLine & "Chú ý: Tên Quản Lý không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        '' Cập nhật
        If dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text <> "" And dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ten_Quan_Ly").Text <> "" Then
            myQuanLy.Cap_Nhat_Them(dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ma_Quan_Ly").Text, dgQuanLy.Rows(dgQuanLy.ActiveRow.Index).Cells("Ten_Quan_Ly").Text)
        End If
    End Sub
    Private Sub dgQuanLy_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgQuanLy.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Quan_Ly").IsActiveCell Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "--------------------Mã Nước--------------------"
    Private Sub dgManuoc_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMaNuoc.InitializeLayout
        dgMaNuoc.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMaNuoc.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMaNuoc.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
    End Sub

    Private Sub DataGrid_MaNuoc()
        dgMaNuoc.DataSource = myMaNuoc.Danh_Sach.Tables(0)
        dgMaNuoc.DataBind()
        dgMaNuoc.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_MaNuoc()
        If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myMaNuoc.Xoa(dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text)
                dgMaNuoc.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgMaNuoc_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgMaNuoc.AfterRowUpdate
        If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text = "" And dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Text = "" And dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text = "" Then
            Exit Sub
        Else
            If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Nước." & vbNewLine & "Chú ý: Mã Nước không được để trống.", " Thông báo ")
                Exit Sub
            End If

            If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Nước." & vbNewLine & "Chú ý: Tên Nước không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Nước." & vbNewLine & "Chú ý: Mã Khu Vực không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        '' Cập nhật
        If dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text <> "" And dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Text <> "" And dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text <> "" Then
            myMaNuoc.Cap_Nhat_Them(dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.ToUpper, dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Text, dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Khu_Vuc").Text)
        End If
    End Sub
    Private Sub dgMaNuoc_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMaNuoc.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Nuoc").Text <> "" And e.Cell.Row.Cells("Ten_Nuoc").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgMaNuoc_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMaNuoc.AfterExitEditMode
        Select Case dgMaNuoc.ActiveCell.Column.Key
            Case "Ma_Nuoc"
                If dgMaNuoc.ActiveCell.Text <> "" Then
                    If dgMaNuoc.ActiveCell.Text.Length > 2 Then
                        CMessageBox.Show("'Mã Nước' không được quá 2 ký tự.", " Thông báo ")
                        myCell = dgMaNuoc.ActiveCell
                        Exit Sub
                    End If
                    If myMaNuoc.Chk_Ma_Nuoc(dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ma_Nuoc").Text.ToUpper) = True And dgMaNuoc.Rows(dgMaNuoc.ActiveRow.Index).Cells("Ten_Nuoc").Text = "" Then
                        CMessageBox.Show("Mã Nước này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgMaNuoc.ActiveCell
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Mã Tỉnh--------------------"
    Private Sub dgMaTinh_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMaTinh.InitializeLayout
        dgMaTinh.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgMaTinh.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        dgMaTinh.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom

        dgMaTinh.DisplayLayout.Bands(0).Columns("Thoa_Thuan").Hidden = True
        'Set default Value
        dgMaTinh.DisplayLayout.Bands(0).Columns("Ten_Tinh").DefaultCellValue = ""
        dgMaTinh.DisplayLayout.Bands(0).Columns("Khu_Vuc").DefaultCellValue = 1
        dgMaTinh.DisplayLayout.Bands(0).Columns("Thoa_Thuan").DefaultCellValue = CBool(0)
    End Sub

    Private Sub DataGrid_MaTinh()
        dgMaTinh.DataSource = myMaTinh.Danh_Sach.Tables(0)
        dgMaTinh.DataBind()
        dgMaTinh.Rows.Band.AddNew()
    End Sub

    Private Sub Delete_MaTinh()
        If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myMaTinh.Xoa(dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text)
                dgMaTinh.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgMaTinh_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgMaTinh.AfterRowUpdate
        If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text = "" And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ten_Tinh").Text = "" And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Khu_Vuc").Text = "" Then
            Exit Sub
        Else
            If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Tỉnh." & vbNewLine & "Chú ý: Mã Tỉnh không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ten_Tinh").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Tỉnh." & vbNewLine & "Chú ý: Tên Tỉnh không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Khu_Vuc").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Tỉnh." & vbNewLine & "Chú ý: Khu Vực không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Thoa_Thuan").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Mã Tỉnh." & vbNewLine & "Chú ý: Thoả Thuận không được để trống.", " Thông báo ")
                Exit Sub
            End If
        End If
        '' Cập nhật
        If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text <> "" And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ten_Tinh").Text <> "" And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Khu_Vuc").Text <> "" And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Thoa_Thuan").Text <> "" Then
            myMaTinh.Cap_Nhat_Them(Convert.ToInt32(dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text), dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ten_Tinh").Text, Convert.ToInt32(dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Khu_Vuc").Text), dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value)
        End If
    End Sub

    Private Sub dgMaTinh_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgMaTinh.AfterCellUpdate
        If e.Cell.Row.Cells("Ma_Tinh").Text <> "" And e.Cell.Row.Cells("Ten_Tinh").Text <> "" And e.Cell.Row.Cells("Khu_Vuc").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub

    Private Sub dgMaTinh_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMaTinh.AfterExitEditMode
        Select Case dgMaTinh.ActiveCell.Column.Key
            Case "Ma_Tinh"
                If dgMaTinh.ActiveCell.Text <> "" Then
                    If dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value Is System.DBNull.Value Then
                        dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Thoa_Thuan").Value = CheckState.Unchecked
                    End If
                    If myMaTinh.Chk_Ma_Tinh(dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ma_Tinh").Text) = True And dgMaTinh.Rows(dgMaTinh.ActiveRow.Index).Cells("Ten_Tinh").Text = "" Then
                        CMessageBox.Show("Mã Tỉnh này đã tồn tại trong bảng.", " Thông báo ")
                        myCell = dgMaTinh.ActiveCell
                    End If
                End If
        End Select
    End Sub
#End Region

#Region "--------------------Danh mục đường bay--------------------"
#Region "--------------------DataGrid_DuongBay--------------------"
    Private Sub DataGrid_DuongBay()
        Try
            If optSu_Dung.Checked = True Then
                dgDanhMucDuongBay.DataSource = myDanhMucDuongBay.Lay_Boi_Ma_Bc(GBuu_Cuc_Khai_Thac)
            End If
            If optKhong_Su_Dung.Checked = True Then
                dgDanhMucDuongBay.DataSource = myDanhMucDuongBay.Lay_Boi_Ma_BC_Duong_Bay_Khong_Su_Dung(GBuu_Cuc_Khai_Thac)
            End If
            If optTat_Ca.Checked = True Then
                dgDanhMucDuongBay.DataSource = myDanhMucDuongBay.Lay_Boi_Ma_BC_Duong_Bay_Tat_Ca(GBuu_Cuc_Khai_Thac)
            End If
            dgDanhMucDuongBay.DataBind()
            dgDanhMucDuongBay.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_InitializeLayout--------------------"
    Private Sub dgDanhMucDuongBay_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDanhMucDuongBay.InitializeLayout
        Try
            dgDanhMucDuongBay.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            dgDanhMucDuongBay.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            dgDanhMucDuongBay.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            With dgDanhMucDuongBay.DisplayLayout
                .Bands(0).Columns("Ma_Bc_Nhan").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Ma_Bc_Nhan").ValueList = ddDuongThu

                .Bands(0).Columns("So_Chang").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("So_Chang").ValueList = ddSo_Chang

                .Bands(0).Columns("Su_Dung").Style = ColumnStyle.CheckBox

                .Bands(0).Columns("Ma_Bc_Qua_Giang").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Ma_Bc_Qua_Giang").ValueList = ddMa_Bc_Qua_Giang
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_KeyDown--------------------"
    Private Sub dgDanhMucDuongBay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDanhMucDuongBay.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape And e.KeyValue <> Keys.Tab Then
                Exit Sub
            End If
            If myGridKeyDown.ActiveCell.Text.Trim = "" And myGridKeyDown.ActiveCell.Column.Key.ToUpper <> "NOI_GUI" And e.KeyValue <> Keys.Tab And e.KeyValue <> Keys.Escape Then
                Exit Sub
            End If
            If Not myCell Is Nothing Then
                e.Handled = True
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                myCell = Nothing
            End If
            Select Case e.KeyValue
                Case Keys.Enter
                    If CheckEnter() = False Then Exit Sub
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Tab
                    If CheckEnter() = False Then
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                Case Keys.F8
                    Delete_DuongBay()
                    e.Handled = True
                Case Keys.Escape
                    If CheckEscape(myGridKeyDown) = True Then
                        myGridKeyDown.ActiveRow.Delete(False)
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                Case Keys.F1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_AfterCellUpdate--------------------"
    Private Sub dgDanhMucDuongBay_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDanhMucDuongBay.AfterCellUpdate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow Is Nothing Or myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'B1: Kiem tra da ton tai Id_Duong_Bay nay chua
            If myDanhMucDuongBay.Lay(myGridKeyDown.ActiveRow.Cells("Id_Duong_Bay").Text).Id_Duong_Thu <> "" Then
                dgDanhMucDuongBay.Tag = "UPDATE"
            Else
                dgDanhMucDuongBay.Tag = "INSERT"
            End If
            'B2: Xu ly tai 2 Cell tao khoa chinh
            If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_NHAN" Or myGridKeyDown.ActiveCell.Column.Key.ToUpper = "SO_HIEU" Then
                'Neu la Cap nhat
                If dgDanhMucDuongBay.Tag = "UPDATE" Then
                    If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_NHAN" Then
                        MsgBox("Bạn không được thay đổi Mã bưu cục nhận đối với đường bay đã tồn tại trong dữ liệu." & Chr(13) & "Nếu muốn, bạn có thể tạo đường bay mới!!!", MsgBoxStyle.Critical, "Cảnh báo")
                        DataGrid_DuongBay()
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    End If
                    If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "SO_HIEU" Then
                        MsgBox("Bạn không được thay đổi Số hiệu chuyến bay đối với đường bay đã tồn tại trong dữ liệu" & Chr(13) & "Nếu muốn, bạn có thể tạo đường bay mới!!!", MsgBoxStyle.Critical, "Cảnh báo")
                        DataGrid_DuongBay()
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    End If
                    Exit Sub
                Else   'Neu la them moi
                    'Kiem tra thong tin nhap vao
                    '----Duong_Thu
                    Dim Ma_Bc_Nhan As Integer = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, 0, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value)
                    Dim Id_Duong_Thu As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, Ma_Bc_Nhan)
                    '----So_Hieu
                    Dim So_Hieu_tmp As String = myGridKeyDown.ActiveRow.Cells("So_Hieu").Text
                    'Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
                    If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu(Id_Duong_Thu, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                        MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                        Exit Sub
                    End If
                    ''Kiem tra thong tin nhap vao
                    'Dim Bc_Nhan_tmp As String = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, "", myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Text)
                    'Dim So_Hieu_tmp As String = IIf(myGridKeyDown.ActiveRow.Cells("So_Hieu").Value Is System.DBNull.Value, "", myGridKeyDown.ActiveRow.Cells("So_Hieu").Value)
                    ''Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
                    'If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu(Bc_Nhan_tmp, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                    '    MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                    '    myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    '    Exit Sub
                    'End If
                End If
            Else  'Xu ly tai cac Cell con lai  
                'Tu dong thay doi Cell: [Qua_Giang] theo [Noi_Gui]
                If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "NOI_GUI" Then
                    If myGridKeyDown.ActiveRow.Cells("Noi_Gui").Text.Trim <> "" Then
                        myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value = True
                    Else
                        myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value = False
                    End If
                End If
                'Tu dong thay doi Cell: [Qua_Ngay] theo [Gio_Khoi_Hanh] va [Gio_Den]
                If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "GIO_DEN" Then
                    If myGridKeyDown.ActiveRow.Cells("Gio_Khoi_Hanh").Value > myGridKeyDown.ActiveRow.Cells("Gio_Den").Value Then
                        myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value = True
                    Else
                        myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value = False
                    End If
                End If
                'Cap nhat thong tin
                If dgDanhMucDuongBay.Tag = "UPDATE" Then
                    myDanhMucDuongBay.Cap_Nhat(myGridKeyDown.ActiveRow.Cells("Id_Duong_Bay").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Loai_Van_Chuyen").Text, _
                                               ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_Hieu").Text), _
                                               ConvetToABC(myGridKeyDown.ActiveRow.Cells("Noi_Gui").Text), _
                                               myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Text, _
                                               myGridKeyDown.ActiveRow.Cells("BC_GUI").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Text, _
                                               Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.ActiveRow.Cells("Gio_Khoi_Hanh").Value), _
                                               Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.ActiveRow.Cells("Gio_Den").Value), _
                                               myGridKeyDown.ActiveRow.Cells("Qua_Ngay").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Qua_Giang").Value, _
                                               myGridKeyDown.ActiveRow.Cells("SO_CHANG").Value, _
                                               myGridKeyDown.ActiveRow.Cells("SU_DUNG").Value, _
                                               myGridKeyDown.ActiveRow.Cells("MA_BC_QUA_GIANG").Value)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_AfterRowUpdate--------------------"
    Private Sub dgDanhMucDuongBay_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDanhMucDuongBay.AfterRowUpdate
        Try
            myGridKeyDown = sender
            'If myGridKeyDown.ActiveCell Is Nothing Then
            '    Exit Sub
            'End If
            'Kiem tra trang thai neu la update thi thoat
            If dgDanhMucDuongBay.Tag = "UPDATE" Then
                Exit Sub
            End If
            'Kiem tra xem da co duong bay nay trong database chua
            '----Duong_Thu
            Dim Ma_Bc_Nhan As Integer = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, 0, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value)
            Dim Id_Duong_Thu As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, Ma_Bc_Nhan)
            '----So_Hieu
            Dim So_Hieu_tmp As String = myGridKeyDown.ActiveRow.Cells("So_Hieu").Text
            'Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
            If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu(Id_Duong_Thu, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                myGridKeyDown.ActiveRow.Delete(False)
                myGridKeyDown.Rows.Band.AddNew()
                Exit Sub
            End If
            ''Kiem tra xem da co duong bay nay trong database chua
            'Dim Bc_Nhan_tmp As String = IIf(e.Row.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, "", e.Row.Cells("Ma_Bc_Nhan").Text)
            'Dim So_Hieu_tmp As String = IIf(e.Row.Cells("So_Hieu").Value Is System.DBNull.Value, "", e.Row.Cells("So_Hieu").Value)
            'If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu(Bc_Nhan_tmp, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
            '    MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
            '    myGridKeyDown.PerformAction(PrevCellByTab, True, False)
            '    'myGridKeyDown.PerformAction(FirstCellInRow, False, True)
            '    'myGridKeyDown.PerformAction(PrevRowByTab, False, False)
            '    'myGridKeyDown.PerformAction(FirstCellInRow, False, True)
            '    myGridKeyDown.ActiveRow.Delete(False)
            '    myGridKeyDown.Rows.Band.AddNew()
            '    Exit Sub
            'End If
            If myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Mã đường thư không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If myGridKeyDown.ActiveRow.Cells("Loai_van_chuyen").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Loại vận chuyển không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If myGridKeyDown.ActiveRow.Cells("So_hieu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Số hiệu chuyến bay không được để trống.", " Thông báo ")
                Exit Sub
            End If
            If Not IsDate(myGridKeyDown.ActiveRow.Cells("GIO_KHOI_HANH").Text) Then
                CMessageBox.Show("Thông tin chưa hợp lệ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Giờ khởi hành không hợp lệ.", " Thông báo ")
                Exit Sub
            End If
            If Not IsDate(myGridKeyDown.ActiveRow.Cells("GIO_DEN").Text) Then
                CMessageBox.Show("Thông tin chưa hợp lệ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Giờ đến không hợp lệ.", " Thông báo ")
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("SO_CHANG").Text) Then
                MsgBox("Số chặng nhập vào không hợp lệ!!!, số chặng phải là 1 số nguyên", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            'If Not IsNumeric(e.Row.Cells("SU_DUNG").Text) Then
            '    MsgBox("Thông tin sử dụng nhập vào không hợp lệ!!!, nếu sử dụng thì nhập: 1, không sử dụng thì nhập: 0", MsgBoxStyle.Information, "Thông báo")
            '    Exit Sub
            'End If
            ''Xu ly id_duong_thu 
            'Dim id_duong_thu_tmp As String
            'id_duong_thu_tmp = Common.Chuan_Hoa_Ma_Bc(GBuu_Cuc_Khai_Thac, 7)
            'id_duong_thu_tmp = id_duong_thu_tmp & Common.Chuan_Hoa_Ma_Bc(e.Row.Cells("Ma_Bc_Nhan").Value, 7)

            'Insert_Update into Danh_Muc_Duong_Bay
            myDanhMucDuongBay.Cap_Nhat_Them(Id_Duong_Thu & ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_hieu").Text), _
                                            Id_Duong_Thu, _
                                            myGridKeyDown.ActiveRow.Cells("Loai_van_chuyen").Text.ToUpper, _
                                            ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_hieu").Text), _
                                            ConvetToABC(myGridKeyDown.ActiveRow.Cells("Noi_GUI").Text), _
                                            myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Text, _
                                            myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).IPMC, _
                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Text, _
                                            Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.ActiveRow.Cells("GIO_KHOI_HANH").Value), _
                                            Ham_Dung_Chung.ConvertTimeToInt(myGridKeyDown.ActiveRow.Cells("GIO_DEN").Value), _
                                            myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value, _
                                            myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value, _
                                            myGridKeyDown.ActiveRow.Cells("SO_CHANG").Value, _
                                            myGridKeyDown.ActiveRow.Cells("SU_DUNG").Value, _
                                            myGridKeyDown.ActiveRow.Cells("MA_BC_QUA_GIANG").Value)
            SetDefaultValueDgDanhMucDuongBay(myGridKeyDown)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_AfterExitEditMode---------------"
    Private Sub dgDanhMucDuongBay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDanhMucDuongBay.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell.Value Is System.DBNull.Value Then
                Exit Sub
            End If
            If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_NHAN" Then
                If myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Value Is DBNull.Value Or myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Text = "" Then
                    myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Value = myGridKeyDown.ActiveCell.Text.Substring(2, 3)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBay_Error--------------------"
    Private Sub dgDanhMucDuongBay_Error(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ErrorEventArgs) Handles dgDanhMucDuongBay.Error
        e.ErrorText = "Lỗi này phát sinh do một trong các nguyên nhân sau: " + vbNewLine + "- Nhập sai định dạng cho phép." + vbNewLine + "- Dữ liệu chưa có sẵn ở bảng liên kết khác" + vbNewLine + "::Bạn hãy xem lại!"
    End Sub
#End Region

#Region "--------------------Delete_DuongBay--------------------"
    Private Sub Delete_DuongBay()
        Try
            If dgDanhMucDuongBay.ActiveRow.Cells("Id_Duong_Bay").Text <> "" Then
                If MessageBox.Show("Bạn có thực sự muốn xóa đường bay này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    myDanhMucDuongBay.Xoa(dgDanhMucDuongBay.ActiveRow.Cells("Id_Duong_Bay").Text)
                    dgDanhMucDuongBay.ActiveRow.Delete(False)
                    CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------CheckEnter--------------------"
    Private Function CheckEnter() As Boolean
        Try
            Select Case dgDanhMucDuongBay.ActiveCell.Column.Key.ToUpper
                Case "MA_BC_NHAN"
                    If dgDanhMucDuongBay.ActiveRow.Cells("Ma_Bc_Nhan").Text = "" Then
                        MsgBox("Đường thư không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "LOAI_VAN_CHUYEN"
                    If dgDanhMucDuongBay.ActiveRow.Cells("Loai_van_chuyen").Text = "" Then
                        MsgBox("Loại vận chuyển không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "SO_HIEU"
                    If dgDanhMucDuongBay.ActiveRow.Cells("So_hieu").Text = "" Then
                        MsgBox("Số hiệu chuyến bay không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "NOI_NHAN"
                    If dgDanhMucDuongBay.ActiveRow.Cells("Noi_NHAN").Text = "" Then
                        MsgBox("Nơi nhận không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "GIO_KHOI_HANH"
                    If Not IsDate(dgDanhMucDuongBay.ActiveRow.Cells("GIO_KHOI_HANH").Text) Then
                        MsgBox("Giờ khởi hành không hợp lệ!!!, nhập lại theo định dạng (hh:mm)", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "GIO_DEN"
                    If Not IsDate(dgDanhMucDuongBay.ActiveRow.Cells("GIO_DEN").Text) Then
                        MsgBox("Giờ đến không hợp lệ!!!, nhập lại theo định dạng (hh:mm)", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "SO_CHANG"
                    If Not IsNumeric(dgDanhMucDuongBay.ActiveRow.Cells("SO_CHANG").Text) Then
                        MsgBox("Số chặng nhập vào không hợp lệ!!!, số chặng phải là 1 số nguyên", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                    'Case "SU_DUNG"
                    '    If Not IsNumeric(.Rows(.ActiveRow.Index).Cells("SU_DUNG").Text) Then
                    '        MsgBox("Thông tin sử dụng nhập vào không hợp lệ!!!, nếu sử dụng thì nhập: 1, không sử dụng thì nhập: 0", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                    'Case "MA_BC_QUA_GIANG"
                    '    If .Rows(.ActiveRow.Index).Cells("MA_BC_QUA_GIANG").Text = 0 Then

                    '    End If
            End Select
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "--------------------CheckEscape--------------------"
    Private Function CheckEscape(ByVal e As UltraGrid) As Boolean
        Try
            If e.ActiveRow Is Nothing Then
                Return False
                Exit Function
            End If
            If e.ActiveRow.Cells("Id_Duong_Bay").Value Is DBNull.Value Then
                Return True
                Exit Function
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        'If e.ActiveRow.Cells("Ma_Bc_Nhan").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Loai_Van_Chuyen").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("So_Hieu").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Gio_Khoi_Hanh").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Gio_Den").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'Return False
    End Function
#End Region

#Region "--------------------SetDefaultValueDgDanhMucDuongBay--------------------"
    Private Sub SetDefaultValueDgDanhMucDuongBay(ByVal sender As Object)
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Noi_Gui").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Noi_Gui").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Khoi_Hanh").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Khoi_Hanh").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Den").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Den").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("SO_CHANG").DefaultCellValue = 1
        myGridKeyDown.DisplayLayout.Bands(0).Columns("SU_DUNG").DefaultCellValue = 1
        myGridKeyDown.DisplayLayout.Bands(0).Columns("MA_BC_QUA_GIANG").DefaultCellValue = 0
    End Sub
#End Region

#Region "--------------------btnLoad_Click-----------------"
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        DataGrid_DuongBay()
    End Sub
#End Region

#End Region

#Region "---------------- Danh mục đường bay đến-------------------------"

#Region "--------------------DataGrid_DuongBayDen--------------------"
    Private Sub DataGrid_DuongBayDen()
        Try
            dgDanhMucDuongBayDen.DataSource = myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_Boi_Ma_BC(GBuu_Cuc_Khai_Thac)
            dgDanhMucDuongBayDen.DataBind()
            dgDanhMucDuongBayDen.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBayDen_InitializeLayout--------------------"
    Private Sub dgDanhMucDuongBayDen_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDanhMucDuongBayDen.InitializeLayout
        Try
            dgDanhMucDuongBayDen.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            dgDanhMucDuongBayDen.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            dgDanhMucDuongBayDen.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            With dgDanhMucDuongBayDen.DisplayLayout
                .Bands(0).Columns("Ma_Bc_Gui").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Ma_Bc_Gui").ValueList = ddDuongThu2

                .Bands(0).Columns("So_Chang").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("So_Chang").ValueList = ddSo_Chang2

                .Bands(0).Columns("Su_Dung").Style = ColumnStyle.CheckBox

                .Bands(0).Columns("Ma_Bc_Qua_Giang").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Ma_Bc_Qua_Giang").ValueList = ddMa_Bc_Qua_Giang2

                '.Bands(0).Columns("IPMC").Style = ColumnStyle.DropDownValidate
                '.Bands(0).Columns("IPMC").ValueList = ddMa_Bc_Qua_Giang2
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBayDen_KeyDown--------------------"
    Private Sub dgDanhMucDuongBayDen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDanhMucDuongBayDen.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape And e.KeyValue <> Keys.Tab Then
                Exit Sub
            End If
            If myGridKeyDown.ActiveCell.Text.Trim = "" And myGridKeyDown.ActiveCell.Column.Key.ToUpper <> "NOI_NHAN" And e.KeyValue <> Keys.Tab And e.KeyValue <> Keys.Escape Then
                Exit Sub
            End If
            If Not myCell Is Nothing Then
                e.Handled = True
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                myCell = Nothing
            End If
            Select Case e.KeyValue
                Case Keys.Enter
                    If CheckEnter2() = False Then Exit Sub
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Tab
                    If CheckEnter2() = False Then
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                Case Keys.F8
                    Delete_DuongBayDen()
                    e.Handled = True
                Case Keys.Escape
                    If CheckEscape2(myGridKeyDown) = True Then
                        myGridKeyDown.ActiveRow.Delete(False)
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                Case Keys.F1
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBayDen_AfterCellUpdate--------------------"
    Private Sub dgDanhMucDuongBayDen_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDanhMucDuongBayDen.AfterCellUpdate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow Is Nothing Or myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'B1: Kiem tra da ton tai Id_Duong_Bay nay chua
            If myDanhMucDuongBayDen.Lay(myGridKeyDown.ActiveRow.Cells("Id_Duong_Bay").Text).Id_Duong_Thu <> "" Then
                dgDanhMucDuongBayDen.Tag = "UPDATE"
            Else
                dgDanhMucDuongBayDen.Tag = "INSERT"
            End If
            'B2: Xu ly tai 2 Cell tao khoa chinh
            If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_GUI" Or myGridKeyDown.ActiveCell.Column.Key.ToUpper = "SO_HIEU" Then
                'Neu la Cap nhat
                If dgDanhMucDuongBayDen.Tag = "UPDATE" Then
                    If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_GUI" Then
                        MsgBox("Bạn không được thay đổi Mã bưu cục nhận đối với đường bay đã tồn tại trong dữ liệu." & Chr(13) & "Nếu muốn, bạn có thể tạo đường bay mới!!!", MsgBoxStyle.Critical, "Cảnh báo")
                        DataGrid_DuongBayDen()
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    End If
                    If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "SO_HIEU" Then
                        MsgBox("Bạn không được thay đổi Số hiệu chuyến bay đối với đường bay đã tồn tại trong dữ liệu" & Chr(13) & "Nếu muốn, bạn có thể tạo đường bay mới!!!", MsgBoxStyle.Critical, "Cảnh báo")
                        DataGrid_DuongBayDen()
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    End If
                    Exit Sub
                Else   'Neu la them moi
                    'Kiem tra thong tin nhap vao
                    '----Duong_Thu
                    Dim Ma_Bc_Gui As Integer = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Value Is System.DBNull.Value, 0, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Value)
                    Dim Id_Duong_Thu As String = CreateId_Duong_Thu(Ma_Bc_Gui, GBuu_Cuc_Khai_Thac)
                    '----So_Hieu
                    Dim So_Hieu_tmp As String = myGridKeyDown.ActiveRow.Cells("So_Hieu").Text
                    'Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
                    If myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_Boi_Duong_Thu_Den_So_Hieu(Id_Duong_Thu, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                        MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                        myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                        Exit Sub
                    End If
                    ''Kiem tra thong tin nhap vao
                    'Dim Bc_Nhan_tmp As String = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, "", myGridKeyDown.ActiveRow.Cells("Ma_Bc_Nhan").Text)
                    'Dim So_Hieu_tmp As String = IIf(myGridKeyDown.ActiveRow.Cells("So_Hieu").Value Is System.DBNull.Value, "", myGridKeyDown.ActiveRow.Cells("So_Hieu").Value)
                    ''Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
                    'If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu(Bc_Nhan_tmp, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                    '    MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                    '    myGridKeyDown.PerformAction(PrevCellByTab, True, False)
                    '    Exit Sub
                    'End If
                End If
            Else  'Xu ly tai cac Cell con lai  
                'Tu dong thay doi Cell: [Qua_Giang] theo [Noi_Gui]
                'If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "NOI_NHAN" Then
                '    If myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Text.Trim <> "" Then
                '        myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value = True
                '    Else
                '        myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value = False
                '    End If
                'End If
                ''Tu dong thay doi Cell: [Qua_Ngay] theo [Gio_Khoi_Hanh] va [Gio_Den]
                'If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "GIO_DEN" Then
                '    If myGridKeyDown.ActiveRow.Cells("Gio_Khoi_Hanh").Value > myGridKeyDown.ActiveRow.Cells("Gio_Den").Value Then
                '        myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value = True
                '    Else
                '        myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value = False
                '    End If
                'End If
                'Cap nhat thong tin
                If dgDanhMucDuongBayDen.Tag = "UPDATE" Then
                    myDanhMucDuongBayDen.Cap_Nhat(myGridKeyDown.ActiveRow.Cells("Id_Duong_Bay").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Value, _
                                               myGridKeyDown.ActiveRow.Cells("Loai_Van_Chuyen").Text, _
                                               ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_Hieu").Text), _
                                               myGridKeyDown.ActiveRow.Cells("Noi_GUI").Value Is System.DBNull.Value, _
                                               myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Value Is System.DBNull.Value, _
                                               myGridKeyDown.ActiveRow.Cells("Ma_BC_Gui").Value, _
                                               myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_BC, _
                                               myGridKeyDown.ActiveRow.Cells("GIO_KHOI_HANH").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("GIO_DEN").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("SO_CHANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("SU_DUNG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("MA_BC_QUA_GIANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("IPMC").Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBayDen_AfterRowUpdate--------------------"
    Private Sub dgDanhMucDuongBayDen_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDanhMucDuongBayDen.AfterRowUpdate
        Try
            myGridKeyDown = sender
            'If myGridKeyDown.ActiveCell Is Nothing Then
            '    Exit Sub
            'End If
            'Kiem tra trang thai neu la update thi thoat
            If dgDanhMucDuongBayDen.Tag = "UPDATE" Then
                Exit Sub
            End If
            'Kiem tra xem da co duong bay nay trong database chua
            '----Duong_Thu
            Dim Ma_Bc_Gui As Integer = IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Value Is System.DBNull.Value, 0, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Value)
            Dim Id_Duong_Thu As String = CreateId_Duong_Thu(Ma_Bc_Gui, GBuu_Cuc_Khai_Thac)
            '----So_Hieu
            Dim So_Hieu_tmp As String = myGridKeyDown.ActiveRow.Cells("So_Hieu").Text
            'Neu thong tin update vao tao ra duong bay da ton tai thi bao loi
            If myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_Boi_Duong_Thu_Den_So_Hieu(Id_Duong_Thu, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
                MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
                myGridKeyDown.ActiveRow.Delete(False)
                myGridKeyDown.Rows.Band.AddNew()
                Exit Sub
            End If
            ''Kiem tra xem da co duong bay nay trong database chua
            'Dim Bc_Nhan_tmp As String = IIf(e.Row.Cells("Ma_Bc_Nhan").Value Is System.DBNull.Value, "", e.Row.Cells("Ma_Bc_Nhan").Text)
            'Dim So_Hieu_tmp As String = IIf(e.Row.Cells("So_Hieu").Value Is System.DBNull.Value, "", e.Row.Cells("So_Hieu").Value)
            'If myDanhMucDuongBay.Danh_Muc_Duong_Bay_Lay_Boi_IPMC_So_Hieu(Bc_Nhan_tmp, So_Hieu_tmp).Tables(0).Rows.Count > 0 Then
            '    MsgBox("Đã tồn tại đường bay này trong dữ liệu", MsgBoxStyle.Critical, "Thông báo")
            '    myGridKeyDown.PerformAction(PrevCellByTab, True, False)
            '    'myGridKeyDown.PerformAction(FirstCellInRow, False, True)
            '    'myGridKeyDown.PerformAction(PrevRowByTab, False, False)
            '    'myGridKeyDown.PerformAction(FirstCellInRow, False, True)
            '    myGridKeyDown.ActiveRow.Delete(False)
            '    myGridKeyDown.Rows.Band.AddNew()
            '    Exit Sub
            'End If
            If myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Mã đường thư không được để trống.", " Thông báo ")
                Exit Sub
            End If
            'If myGridKeyDown.ActiveRow.Cells("Loai_van_chuyen").Text = "" Then
            '    CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Loại vận chuyển không được để trống.", " Thông báo ")
            '    Exit Sub
            'End If
            If myGridKeyDown.ActiveRow.Cells("So_hieu").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Số hiệu chuyến bay không được để trống.", " Thông báo ")
                Exit Sub
            End If
            'If Not IsDate(myGridKeyDown.ActiveRow.Cells("GIO_KHOI_HANH").Text) Then
            '    CMessageBox.Show("Thông tin chưa hợp lệ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Giờ khởi hành không hợp lệ.", " Thông báo ")
            '    Exit Sub
            'End If
            'If Not IsDate(myGridKeyDown.ActiveRow.Cells("GIO_DEN").Text) Then
            '    CMessageBox.Show("Thông tin chưa hợp lệ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục đường bay." & vbNewLine & "Chú ý: Giờ đến không hợp lệ.", " Thông báo ")
            '    Exit Sub
            'End If
            'If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("SO_CHANG").Text) Then
            '    MsgBox("Số chặng nhập vào không hợp lệ!!!, số chặng phải là 1 số nguyên", MsgBoxStyle.Information, "Thông báo")
            '    Exit Sub
            'End If
            'If Not IsNumeric(e.Row.Cells("SU_DUNG").Text) Then
            '    MsgBox("Thông tin sử dụng nhập vào không hợp lệ!!!, nếu sử dụng thì nhập: 1, không sử dụng thì nhập: 0", MsgBoxStyle.Information, "Thông báo")
            '    Exit Sub
            'End If
            ''Xu ly id_duong_thu 
            'Dim id_duong_thu_tmp As String
            'id_duong_thu_tmp = Common.Chuan_Hoa_Ma_Bc(GBuu_Cuc_Khai_Thac, 7)
            'id_duong_thu_tmp = id_duong_thu_tmp & Common.Chuan_Hoa_Ma_Bc(e.Row.Cells("Ma_Bc_Nhan").Value, 7)

            'Insert_Update into Danh_Muc_Duong_Bay
            myDanhMucDuongBayDen.Cap_Nhat_Them(Id_Duong_Thu & ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_hieu").Text), _
                                            Id_Duong_Thu, _
                                            myGridKeyDown.ActiveRow.Cells("Loai_van_chuyen").Text.ToUpper Is System.DBNull.Value, _
                                            ConvetToABC(myGridKeyDown.ActiveRow.Cells("So_hieu").Text), _
                                            myGridKeyDown.ActiveRow.Cells("Noi_GUI").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("Noi_Nhan").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Gui").Value, _
                                            myDanhMuc.Lay(GBuu_Cuc_Khai_Thac).Ma_BC, _
                                            myGridKeyDown.ActiveRow.Cells("GIO_KHOI_HANH").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("GIO_DEN").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("QUA_NGAY").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("QUA_GIANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("SO_CHANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("SU_DUNG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("MA_BC_QUA_GIANG").Value Is System.DBNull.Value, _
                                            myGridKeyDown.ActiveRow.Cells("IPMC").Text)
            SetDefaultValueDgDanhMucDuongBayDen(myGridKeyDown)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucDuongBayDen_AfterExitEditMode---------------"
    Private Sub dgDanhMucDuongBayDen_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDanhMucDuongBayDen.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell.Value Is System.DBNull.Value Then
                Exit Sub
            End If
            'If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_GUI" Then
            '    If myGridKeyDown.ActiveRow.Cells("Noi_Gui").Value Is DBNull.Value Or myGridKeyDown.ActiveRow.Cells("Noi_Gui").Text = "" Then
            '        myGridKeyDown.ActiveRow.Cells("Noi_Gui").Value = myGridKeyDown.ActiveCell.Text.Substring(2, 3)
            '    End If
            'End If
            If myGridKeyDown.ActiveCell.Column.Key.ToUpper = "MA_BC_GUI" Then
                If myGridKeyDown.ActiveRow.Cells("IPMC").Value Is DBNull.Value Or myGridKeyDown.ActiveRow.Cells("IPMC").Text = "" Then
                    myGridKeyDown.ActiveRow.Cells("IPMC").Value = myDanhMucBc.Lay_IPMC_Theo_Ma_BC(myGridKeyDown.ActiveRow.Cells("MA_BC_GUI").Value)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------Delete_DuongBayDen--------------------"
    Private Sub Delete_DuongBayDen()
        Try
            If dgDanhMucDuongBayDen.ActiveRow.Cells("Id_Duong_Bay").Text <> "" Then
                If MessageBox.Show("Bạn có thực sự muốn xóa đường bay này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    myDanhMucDuongBayDen.Xoa(dgDanhMucDuongBayDen.ActiveRow.Cells("Id_Duong_Bay").Text)
                    dgDanhMucDuongBayDen.ActiveRow.Delete(False)
                    CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------CheckEnter2--------------------"
    Private Function CheckEnter2() As Boolean
        Try
            Select Case dgDanhMucDuongBayDen.ActiveCell.Column.Key.ToUpper
                Case "MA_BC_GUI"
                    If dgDanhMucDuongBayDen.ActiveRow.Cells("Ma_Bc_Gui").Text = "" Then
                        MsgBox("Đường thư không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                    'Case "LOAI_VAN_CHUYEN"
                    '    If dgDanhMucDuongBayDen.ActiveRow.Cells("Loai_van_chuyen").Text = "" Then
                    '        MsgBox("Loại vận chuyển không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                Case "SO_HIEU"
                    If dgDanhMucDuongBayDen.ActiveRow.Cells("So_hieu").Text = "" Then
                        MsgBox("Số hiệu chuyến bay không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                Case "NOI_GUI"
                    If dgDanhMucDuongBayDen.ActiveRow.Cells("Noi_GUI").Text = "" Then
                        MsgBox("Nơi nhận không được để trống!!!", MsgBoxStyle.Information, "Thông báo")
                        Return False
                        Exit Function
                    End If
                    'Case "GIO_KHOI_HANH"
                    '    If Not IsDate(dgDanhMucDuongBayDen.ActiveRow.Cells("GIO_KHOI_HANH").Text) Then
                    '        MsgBox("Giờ khởi hành không hợp lệ!!!, nhập lại theo định dạng (hh:mm)", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                    'Case "GIO_DEN"
                    '    If Not IsDate(dgDanhMucDuongBayDen.ActiveRow.Cells("GIO_DEN").Text) Then
                    '        MsgBox("Giờ đến không hợp lệ!!!, nhập lại theo định dạng (hh:mm)", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                    'Case "SO_CHANG"
                    '    If Not IsNumeric(dgDanhMucDuongBayDen.ActiveRow.Cells("SO_CHANG").Text) Then
                    '        MsgBox("Số chặng nhập vào không hợp lệ!!!, số chặng phải là 1 số nguyên", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                    'Case "SU_DUNG"
                    '    If Not IsNumeric(.Rows(.ActiveRow.Index).Cells("SU_DUNG").Text) Then
                    '        MsgBox("Thông tin sử dụng nhập vào không hợp lệ!!!, nếu sử dụng thì nhập: 1, không sử dụng thì nhập: 0", MsgBoxStyle.Information, "Thông báo")
                    '        Return False
                    '        Exit Function
                    '    End If
                    'Case "MA_BC_QUA_GIANG"
                    '    If .Rows(.ActiveRow.Index).Cells("MA_BC_QUA_GIANG").Text = 0 Then

                    '    End If
            End Select
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "--------------------CheckEscape2--------------------"
    Private Function CheckEscape2(ByVal e As UltraGrid) As Boolean
        Try
            If e.ActiveRow Is Nothing Then
                Return False
                Exit Function
            End If
            If e.ActiveRow.Cells("Id_Duong_Bay").Value Is DBNull.Value Then
                Return True
                Exit Function
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        'If e.ActiveRow.Cells("Ma_Bc_Nhan").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Loai_Van_Chuyen").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("So_Hieu").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Gio_Khoi_Hanh").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'If e.ActiveRow.Cells("Gio_Den").Text = "" Then
        '    Return True
        '    Exit Function
        'End If
        'Return False
    End Function
#End Region

#Region "--------------------SetDefaultValueDgDanhMucDuongBayDen--------------------"
    Private Sub SetDefaultValueDgDanhMucDuongBayDen(ByVal sender As Object)
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Noi_Nhan").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Noi_Nhan").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Khoi_Hanh").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Khoi_Hanh").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Den").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Den").Text
        myGridKeyDown.DisplayLayout.Bands(0).Columns("SO_CHANG").DefaultCellValue = 1
        myGridKeyDown.DisplayLayout.Bands(0).Columns("SU_DUNG").DefaultCellValue = 1
        myGridKeyDown.DisplayLayout.Bands(0).Columns("MA_BC_QUA_GIANG").DefaultCellValue = 0
    End Sub
#End Region

#End Region

#Region "--------------------Danh mục chuyến bay--------------------"

#Region "--------------------Tao Bang Quy Luat Nhap Kieu Thu---------------"
    Private Sub Tao_Bang_Quy_Luat()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Quy_Luat")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Ma_Quy_Luat", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Quy_Luat", GetType(String))
            dataTable.Columns.Add(colWork)


            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Ma_Quy_Luat") = 1
            row("Ten_Quy_Luat") = "Daily"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Quy_Luat") = 2
            row("Ten_Quy_Luat") = "2-4-6-CN"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Quy_Luat") = 3
            row("Ten_Quy_Luat") = "3-5-7"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Ma_Quy_Luat") = 4
            row("Ten_Quy_Luat") = "Khác"
            dataTable.Rows.Add(row)

            ddQuy_Luat.DataSource = dataTable
            ddQuy_Luat.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------Lấy dữ liệu cho dropdown sân bay--------------"
    Private Sub Get_Data_San_Bay()
        Try
            Dim mDataTable As New DataTable
            mDataTable = myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Danh_Sach_San_Bay().Tables(0)
            ddSan_Bay.DataSource = mDataTable
            ddSan_Bay.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------Lấy dữ liệu cho dropdown mã nước--------------"
    Private Sub Get_Data_Ma_Nuoc()
        Try
            Dim mDataTable As New DataTable
            mDataTable = myMaNuoc.Danh_Sach_Rut_Gon().Tables(0)
            ddMa_Nuoc_Chuyen_Bay.DataSource = mDataTable
            ddMa_Nuoc_Chuyen_Bay.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------Get_Quy_Luat_Value------------"
    Private Function Get_Quy_Luat_Value(ByVal mDataGird As Infragistics.Win.UltraWinGrid.UltraGrid) As Integer
        Dim mThu_2 As Boolean = mDataGird.ActiveRow.Cells("Thu_2").Value
        Dim mThu_3 As Boolean = mDataGird.ActiveRow.Cells("Thu_3").Value
        Dim mThu_4 As Boolean = mDataGird.ActiveRow.Cells("Thu_4").Value
        Dim mThu_5 As Boolean = mDataGird.ActiveRow.Cells("Thu_5").Value
        Dim mThu_6 As Boolean = mDataGird.ActiveRow.Cells("Thu_6").Value
        Dim mThu_7 As Boolean = mDataGird.ActiveRow.Cells("Thu_7").Value
        Dim mChu_Nhat As Boolean = mDataGird.ActiveRow.Cells("Chu_Nhat").Value
        'Daily
        If (mThu_2 = True) And (mThu_3 = True) And (mThu_4 = True) And (mThu_5 = True) And (mThu_6 = True) And (mThu_7 = True) And (mChu_Nhat = True) Then
            Return 1
            '2-4-6-CN
        ElseIf (mThu_2 = True) And (mThu_3 = False) And (mThu_4 = True) And (mThu_5 = False) And (mThu_6 = True) And (mThu_7 = False) And (mChu_Nhat = True) Then
            Return 2
            '-3-5-7
        ElseIf (mThu_2 = False) And (mThu_3 = True) And (mThu_4 = False) And (mThu_5 = True) And (mThu_6 = False) And (mThu_7 = True) And (mChu_Nhat = False) Then
            Return 3
        Else
            Return 4
        End If
    End Function
#End Region

#Region "--------------------dgDanhMucChuyenBay_KeyDown----------------"
    Private Sub dgDanhMucChuyenBay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgDanhMucChuyenBay.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    'Kiem tra Cell co Value = Null, khong cho next cell
                    If myGridKeyDown.ActiveCell.Column.Key = "Gio_Xuat_Phat" Or myGridKeyDown.ActiveCell.Column.Key = "Gio_Den" Then
                        If Not IsDate(myGridKeyDown.ActiveCell.Text) Then
                            e.Handled = True
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                            Exit Sub
                        End If
                    End If
                    If myGridKeyDown.ActiveCell.Text = "" Then
                        e.Handled = True
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        Exit Sub
                    End If
                    'Lay index cua Cell dang Active
                    Dim idx As Integer = myGridKeyDown.ActiveCell.Column.Index
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If myGridKeyDown.Tag = False Then
                        myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells(idx)
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                    'Neu da chon kieu thu thi active cell = Nuoc_Gui
                    If myGridKeyDown.ActiveCell.Column.Key = "Quy_Luat" Then
                        If myGridKeyDown.ActiveCell.Value <> 4 Then
                            myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat")
                            e.Handled = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If
                    End If
                    'Ok -> Next Cell
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.F8
                    Delete_Danh_Muc_Chuyen_Bay()
                    e.Handled = True
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.IsInEditMode = False Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text <> "" And myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(NextCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(NextCellByTab, False, True)
                    End If
                Case Keys.Left
                    If myGridKeyDown.ActiveCell.IsInEditMode = False Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text = "" Or myGridKeyDown.ActiveCell.SelStart = 0 Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    End If
                Case Keys.Up
                    If myGridKeyDown.ActiveCell.IsInEditMode = False Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveRow.Index > 0 Then
                            myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                            myGridKeyDown.ActiveCell = myCell
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        End If
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                Case Keys.Down
                    If myGridKeyDown.ActiveCell.IsInEditMode = False Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveRow.Index < myGridKeyDown.Rows.Count - 1 Then
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index + 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
            End Select
        Catch ex As Exception
            ' Call the exception handler
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_InitializeLayout--------------------"
    Private Sub dgDanhMucChuyenBay_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgDanhMucChuyenBay.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            myGridKeyDown.DisplayLayout.Bands(0).Columns("So_Hieu").SortIndicator = SortIndicator.Ascending

            'Quy luat (Kieu thu)
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Quy_Luat").Style = ColumnStyle.DropDownValidate
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Quy_Luat").ValueList = ddQuy_Luat

            'Nuoc Xuat Phat
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Xuat_Phat").Style = ColumnStyle.DropDownValidate
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Xuat_Phat").ValueList = ddMa_Nuoc_Chuyen_Bay
            'San Bay Xuat Phat
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Xuat_Phat").Style = ColumnStyle.DropDownValidate
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Xuat_Phat").ValueList = ddSan_Bay

            'Nuoc Den
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Den").Style = ColumnStyle.DropDownValidate
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Den").ValueList = ddMa_Nuoc_Chuyen_Bay
            'San Bay Den
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Den").Style = ColumnStyle.DropDownValidate
            myGridKeyDown.DisplayLayout.Bands(0).Columns("San_Bay_Den").ValueList = ddSan_Bay

            'Gio Xuat Phat
            'myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Xuat_Phat").MaskInput = "##:##"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Xuat_Phat").PromptChar = "_"
            'Gio Den
            'myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Den").MaskInput = "hh:mm"
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_Den").PromptChar = "_"
            'Qua Ngay
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Qua_Ngay").Style = ColumnStyle.CheckBox
            'Thu 2-3-4-5-6-7-CN
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_2").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_3").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_4").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_5").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_6").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_7").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chu_Nhat").Style = ColumnStyle.CheckBox
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_InitializeTemplateAddRow--------------------"
    Private Sub dgDanhMucChuyenBay_InitializeTemplateAddRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgDanhMucChuyenBay.InitializeTemplateAddRow
        Try
            myGridKeyDown = sender
            With myGridKeyDown.DisplayLayout.Bands(0)
                .Columns("Id_So_Hieu").DefaultCellValue = ""
                .Columns("Ghi_Chu").DefaultCellValue = " "
                .Columns("Quy_Luat").DefaultCellValue = 1
                .Columns("Thu_2").DefaultCellValue = CBool(0)
                .Columns("Thu_3").DefaultCellValue = CBool(0)
                .Columns("Thu_4").DefaultCellValue = CBool(0)
                .Columns("Thu_5").DefaultCellValue = CBool(0)
                .Columns("Thu_6").DefaultCellValue = CBool(0)
                .Columns("Thu_7").DefaultCellValue = CBool(0)
                .Columns("Chu_Nhat").DefaultCellValue = CBool(0)
                .Columns("Qua_Ngay").DefaultCellValue = CBool(0)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------DataGrid_Danh_Muc_Chuyen_Bay--------------------"
    Private Sub DataGrid_Danh_Muc_Chuyen_Bay()
        Try
            dgDanhMucChuyenBay.DataSource = myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Danh_Sach().Tables(0)
            dgDanhMucChuyenBay.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------Delete_Danh_Muc_Chuyen_Bay--------------------"
    Private Sub Delete_Danh_Muc_Chuyen_Bay()
        If dgDanhMucChuyenBay.ActiveRow.Cells("So_Hieu").Text <> "" Then
            If MessageBox.Show("Bạn có thực sự muốn xóa chuyến bay số hiệu: " & dgDanhMucChuyenBay.ActiveRow.Cells("So_Hieu").Text & " không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Xoa(dgDanhMucChuyenBay.ActiveRow.Cells("Id_So_Hieu").Text)
                dgDanhMucChuyenBay.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_AfterRowUpdate--------------------"
    Private Sub dgDanhMucChuyenBay_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgDanhMucChuyenBay.AfterRowUpdate
        Try
            myGridKeyDown = sender
            'So_Hieu
            If myGridKeyDown.ActiveRow.Cells("So_Hieu").Text = "" Then
                MessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục chuyến bay." & vbNewLine & "Chú ý: Số hiệu chuyến bay không được để trống.", "Lỗi cập nhật chuyến bay", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                    myGridKeyDown.Rows.Band.AddNew()
                End If
                Exit Sub
            End If
            'Hang_Hang_Khong
            If myGridKeyDown.ActiveRow.Cells("Hang_Hang_Khong").Text = "" Then
                MessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào bảng Danh mục chuyến bay." & vbNewLine & "Chú ý: Hãng vận chuyển không được để trống.", "Lỗi cập nhật chuyến bay", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                    myGridKeyDown.Rows.Band.AddNew()
                End If
                Exit Sub
            End If
            'La tao moi thi kiem tra su ton tai
            Dim mId_So_Hieu As String
            If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then   'la tao moi
                If (myGridKeyDown.ActiveRow.Cells("So_Hieu").Text <> "") And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_2").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_3").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_4").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_5").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_6").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_7").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value Is DBNull.Value) _
                Then
                    mId_So_Hieu = CreateId_So_Hieu(myGridKeyDown.ActiveRow.Cells("So_Hieu").Text, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_2").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_3").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_4").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_5").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_6").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_7").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value)
                    If myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay(mId_So_Hieu).So_Hieu <> "" Then
                        MessageBox.Show("Chuyến bay này đã tồn tại, bạn không thể nhập thêm.", "Lỗi nhập mới chuyến bay", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then
                            myGridKeyDown.ActiveRow.Delete(False)
                            myGridKeyDown.Rows.Band.AddNew()
                        End If
                        Exit Sub
                    End If
                End If
            Else  'da ton tai
                mId_So_Hieu = myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text
            End If
            'Cap nhat
            myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Cap_Nhat_Them _
                    (mId_So_Hieu, _
                     myGridKeyDown.ActiveRow.Cells("So_Hieu").Text, _
                     myGridKeyDown.ActiveRow.Cells("Hang_Hang_Khong").Text, _
                     myGridKeyDown.ActiveRow.Cells("Nuoc_Xuat_Phat").Text, _
                     myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text, _
                     myHamdungchung.Format_Text_Time(myGridKeyDown.ActiveRow.Cells("Gio_Xuat_Phat").Text), _
                     myGridKeyDown.ActiveRow.Cells("Nuoc_Den").Text, _
                     myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text, _
                     myHamdungchung.Format_Text_Time(myGridKeyDown.ActiveRow.Cells("Gio_Den").Text), _
                     myGridKeyDown.ActiveRow.Cells("Qua_Ngay").Value, _
                     myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text, _
                     Get_Quy_Luat_Value(myGridKeyDown), _
                     myGridKeyDown.ActiveRow.Cells("Thu_2").Value, _
                     myGridKeyDown.ActiveRow.Cells("Thu_3").Value, _
                     myGridKeyDown.ActiveRow.Cells("Thu_4").Value, _
                     myGridKeyDown.ActiveRow.Cells("Thu_5").Value, _
                     myGridKeyDown.ActiveRow.Cells("Thu_6").Value, _
                     myGridKeyDown.ActiveRow.Cells("Thu_7").Value, _
                     myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_AfterCellUpdate--------------------"
    Private Sub dgDanhMucChuyenBay_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgDanhMucChuyenBay.AfterCellUpdate
        If e.Cell.Row.Cells("So_Hieu").Text <> "" And e.Cell.Row.Cells("Hang_Hang_Khong").Text <> "" And e.Cell.Row.Cells("Nuoc_Xuat_Phat").Text <> "" Then
            AddNewRow(sender)
        End If
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_BeforeCellUpdate------------------"
    Private Sub dgDanhMucChuyenBay_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgDanhMucChuyenBay.BeforeCellUpdate

        myGridKeyDown = sender
        If Not (myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Value Is DBNull.Value) Then
            Dim mId_So_Hieu_Old As String = myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Value

            dgDanhMucChuyenBay.Tag = True
            Exit Sub
        End If
        If (myGridKeyDown.ActiveCell.Column.Key <> "So_Hieu") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Quy_Luat") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_2") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_3") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_4") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_5") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_6") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Thu_7") And _
            (myGridKeyDown.ActiveCell.Column.Key <> "Chu_Nhat") _
        Then
            Exit Sub
        End If
        If Not (myGridKeyDown.ActiveRow.Cells("So_Hieu").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_2").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_3").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_4").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_5").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_6").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Thu_7").Value Is DBNull.Value) And _
           Not (myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value Is DBNull.Value) _
        Then
            Dim mId_So_Hieu As String = CreateId_So_Hieu(myGridKeyDown.ActiveRow.Cells("So_Hieu").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_2").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_3").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_4").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_5").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_6").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Thu_7").Value, _
                                                         myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value)
            If myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay(mId_So_Hieu).So_Hieu <> "" Then
                MessageBox.Show("Bạn không được phép sửa đổi thông tin về số hiệu và ngày bay đối với chuyến bay đã tồn tại trong cơ sở dữ liệu." & vbNewLine & "Nếu muốn sửa thì bạn nên xoá chuyến bay cũ đi vào tạo chuyến bay mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgDanhMucChuyenBay.Tag = False
                e.Cancel = True
                Exit Sub
            End If
        End If
        dgDanhMucChuyenBay.Tag = True
    End Sub
#End Region

#Region "--------------------dgDanhMucChuyenBay_AfterExitEditMode--------------------"
    Private Sub dgDanhMucChuyenBay_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgDanhMucChuyenBay.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "So_Hieu"
                    If myGridKeyDown.ActiveCell.Text <> "" Then
                        'To Upper
                        myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.ToUpper
                        'Hang Hang Khong = Left (So_Hieu,1,2)
                        myGridKeyDown.ActiveRow.Cells("Hang_Hang_Khong").Value = myGridKeyDown.ActiveRow.Cells("So_Hieu").Text.Substring(0, 2)
                    End If
                Case "Quy_Luat"
                    'Chi tu dong thay doi khi la tao moi chuyen bay
                    If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then
                        Select Case myGridKeyDown.ActiveRow.Cells("Quy_Luat").Value
                            Case 1 'Daily
                                myGridKeyDown.ActiveRow.Cells("Thu_2").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_3").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_4").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_5").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_6").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_7").Value = True
                                myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value = True
                            Case 2 '2-4-6-CN
                                myGridKeyDown.ActiveRow.Cells("Thu_2").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_3").Value = False
                                myGridKeyDown.ActiveRow.Cells("Thu_4").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_5").Value = False
                                myGridKeyDown.ActiveRow.Cells("Thu_6").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_7").Value = False
                                myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value = True
                            Case 3 '3-5-7
                                myGridKeyDown.ActiveRow.Cells("Thu_2").Value = False
                                myGridKeyDown.ActiveRow.Cells("Thu_3").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_4").Value = False
                                myGridKeyDown.ActiveRow.Cells("Thu_5").Value = True
                                myGridKeyDown.ActiveRow.Cells("Thu_6").Value = False
                                myGridKeyDown.ActiveRow.Cells("Thu_7").Value = True
                                myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value = False
                            Case 4 'Manual
                        End Select
                    End If
                Case "Gio_Den"
                    If myGridKeyDown.ActiveRow.Cells("Gio_Xuat_Phat").Value > myGridKeyDown.ActiveRow.Cells("Gio_Den").Value Then
                        myGridKeyDown.ActiveRow.Cells("Qua_Ngay").Value = True
                    End If
                Case "Hang_Hang_Khong", "Nuoc_Xuat_Phat", "San_Bay_Xuat_Phat", "Nuoc_Den", "San_Bay_Den"
                    If myGridKeyDown.ActiveCell.Text <> "" Then
                        myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.ToUpper
                        'Lay Nuoc Xuat Phat theo San Bay Xuat Phat
                        If myGridKeyDown.ActiveCell.Column.Key = "San_Bay_Xuat_Phat" Then
                            myGridKeyDown.ActiveRow.Cells("Nuoc_Xuat_Phat").Value = myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Ma_Nuoc_Theo_Ma_San_Bay(myGridKeyDown.ActiveRow.Cells("San_Bay_Xuat_Phat").Text).Tables(0).Rows(0).Item("Ma_Nuoc")
                        End If
                        'Lay Nuoc Den theo San Bay Den
                        If myGridKeyDown.ActiveCell.Column.Key = "San_Bay_Den" Then
                            myGridKeyDown.ActiveRow.Cells("Nuoc_Den").Value = myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay_Ma_Nuoc_Theo_Ma_San_Bay(myGridKeyDown.ActiveRow.Cells("San_Bay_Den").Text).Tables(0).Rows(0).Item("Ma_Nuoc")
                        End If
                    End If
            End Select
            'La tao moi thi kiem tra su ton tai
            If myGridKeyDown.ActiveRow.Cells("Id_So_Hieu").Text = "" Then
                If (myGridKeyDown.ActiveRow.Cells("So_Hieu").Text <> "") And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_2").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_3").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_4").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_5").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_6").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Thu_7").Value Is DBNull.Value) And _
                    Not (myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value Is DBNull.Value) _
                Then
                    Dim mId_So_Hieu As String = CreateId_So_Hieu(myGridKeyDown.ActiveRow.Cells("So_Hieu").Text, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_2").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_3").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_4").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_5").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_6").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Thu_7").Value, _
                                                                 myGridKeyDown.ActiveRow.Cells("Chu_Nhat").Value)
                    If myDanh_Muc_Chuyen_Bay_So_Hieu.Danh_Muc_Chuyen_Bay_So_Hieu_Lay(mId_So_Hieu).So_Hieu <> "" Then
                        MessageBox.Show("Chuyến bay này đã tồn tại, bạn không thể nhập thêm.", "Lỗi nhập mới chuyến bay", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        dgDanhMucChuyenBay.Tag = False
                        Exit Sub
                    End If
                End If
            End If
            'Neu khong van de gi gan bien = True de Next Cell
            dgDanhMucChuyenBay.Tag = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgDanhMucChuyenBay.Tag = False
        End Try
    End Sub
#End Region

#End Region

#Region "--------------------Danh mục đường bay tổng hợp--------------------"
    Private Sub Delete_DanhMucDuongBayTongHop()
        'If dgDanhMucDuongBay.Rows(dgDanhMucDuongBay.ActiveRow.Index).Cells("Id_Duong_Bay").Text <> "" Then
        '    If MessageBox.Show("Bạn có thực sự muốn xóa đường bay này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        '        myDanhMucDuongBay.Xoa(dgDanhMucDuongBay.Rows(dgDanhMucDuongBay.ActiveRow.Index).Cells("Id_Duong_Bay").Text)
        '        dgDanhMucDuongBay.ActiveRow.Delete(False)
        '        CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub
#End Region

#Region "--------------------Đợt bay--------------------"
    Private Sub Delete_DotBay()
        'If dgDanhMucDuongBay.Rows(dgDanhMucDuongBay.ActiveRow.Index).Cells("Id_Duong_Bay").Text <> "" Then
        '    If MessageBox.Show("Bạn có thực sự muốn xóa đường bay này không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
        '        myDanhMucDuongBay.Xoa(dgDanhMucDuongBay.Rows(dgDanhMucDuongBay.ActiveRow.Index).Cells("Id_Duong_Bay").Text)
        '        dgDanhMucDuongBay.ActiveRow.Delete(False)
        '        CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub
#End Region
#End Region

End Class
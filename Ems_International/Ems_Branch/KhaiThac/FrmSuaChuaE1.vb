Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Math
Public Class FrmSuaChuaE1
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
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgE1_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbBuuCuc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnTimE1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXoaE1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtE1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ddMaNuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddBuuCuc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ddPhanLoai As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoaiHangHoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents btnSua_Chua_E1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Optdi As System.Windows.Forms.RadioButton
    Friend WithEvents OptDen As System.Windows.Forms.RadioButton
    Friend WithEvents ddLoai As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTo_Hop_DV_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTo_Hop_DV_Cong_Them As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddLy_do As Infragistics.Win.UltraWinGrid.UltraDropDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Buu_Cuc", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSuaChuaE1))
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duong_Thu")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Dv")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Thu")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_E1")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_E1")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Duong_Thu")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Goc")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Tra")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_Nhan")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_Tra")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khoi_Luong")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Phan_Loai")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_Hang_Hoa")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_Chinh")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_E1")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ghi_Chu")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay_Phat_Hanh")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gio_Phat_Hanh")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kien_So")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("STT")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khoi_Luong_QD")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Chuyen_Thu")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_E2")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Ca")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_Dv")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_COD")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HH_Phat_Hanh")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HH_Phat_Tra")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PPXD")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VAT")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PostCode")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_PPXD")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_PPVX")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dv_Cong_Them")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dv_Gia_Tang")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Chuyen_Thu")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tui_So")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_E1")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_E1")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Duong_Thu")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Goc")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Bc_Tra")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_Nhan")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nuoc_Tra")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khoi_Luong")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Phan_Loai")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai_Hang_Hoa")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_Chinh")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_E1")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ghi_Chu")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ngay_Phat_Hanh")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gio_Phat_Hanh")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kien_So")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("STT")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khoi_Luong_QD")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Duong_Thu")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Chuyen_Thu")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_E2")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Ca")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_Dv")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_COD")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HH_Phat_Hanh")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HH_Phat_Tra")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Loai")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PPXD")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VAT")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PostCode")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_PPXD")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuoc_PPVX")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dv_Cong_Them")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dv_Gia_Tang")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Bc", -1)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai", -1)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Hang_Hoa", -1)
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai", -1)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TH_Ma_Dv_Gia_Tang", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Ma")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dv_Cong_Them", -1)
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Trang_Thai", -1)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ly_Do")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbBuuCuc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.txtE1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnTimE1 = New Infragistics.Win.Misc.UltraButton
        Me.btnSua_Chua_E1 = New Infragistics.Win.Misc.UltraButton
        Me.btnXoaE1 = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.dgE1_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddMaNuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddBuuCuc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddPhanLoai = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLoaiHangHoa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.OptDen = New System.Windows.Forms.RadioButton
        Me.Optdi = New System.Windows.Forms.RadioButton
        Me.ddLoai = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTo_Hop_DV_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTo_Hop_DV_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLy_do = New Infragistics.Win.UltraWinGrid.UltraDropDown
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddBuuCuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLoaiHangHoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ddLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLy_do, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 7, 14, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(152, 0)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDinhDang.TabIndex = 54
        Me.dtpNgayDinhDang.Value = New Date(2008, 7, 14, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Nước"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(64, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Bưu cục gốc"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(144, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Số hiệu E1"
        '
        'cbNuoc
        '
        Me.cbNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã nước"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên nước"
        UltraGridColumn2.Header.VisiblePosition = 1
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance1
        UltraGridColumn3.Header.Caption = "Mã khu vực"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridBand1.Header.Caption = "Mã Đường Thư"
        Me.cbNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbNuoc.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbNuoc.DisplayMember = ""
        Me.cbNuoc.Enabled = False
        Me.cbNuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNuoc.Location = New System.Drawing.Point(8, 32)
        Me.cbNuoc.Name = "cbNuoc"
        Me.cbNuoc.Size = New System.Drawing.Size(48, 21)
        Me.cbNuoc.TabIndex = 3
        Me.cbNuoc.ValueMember = ""
        '
        'cbBuuCuc
        '
        Me.cbBuuCuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance3
        UltraGridColumn4.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn5.Header.Caption = "Tên bưu cục"
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn6.Header.Caption = "Mã tỉnh"
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbBuuCuc.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBuuCuc.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.cbBuuCuc.DisplayMember = ""
        Me.cbBuuCuc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuuCuc.Location = New System.Drawing.Point(64, 32)
        Me.cbBuuCuc.Name = "cbBuuCuc"
        Me.cbBuuCuc.Size = New System.Drawing.Size(72, 21)
        Me.cbBuuCuc.TabIndex = 4
        Me.cbBuuCuc.ValueMember = ""
        '
        'txtE1
        '
        Me.txtE1.Location = New System.Drawing.Point(144, 32)
        Me.txtE1.Name = "txtE1"
        Me.txtE1.Size = New System.Drawing.Size(112, 21)
        Me.txtE1.TabIndex = 5
        '
        'btnTimE1
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.btnTimE1.Appearance = Appearance5
        Me.btnTimE1.Location = New System.Drawing.Point(352, 24)
        Me.btnTimE1.Name = "btnTimE1"
        Me.btnTimE1.Size = New System.Drawing.Size(72, 32)
        Me.btnTimE1.TabIndex = 6
        Me.btnTimE1.Text = "Tìm E1"
        '
        'btnSua_Chua_E1
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Me.btnSua_Chua_E1.Appearance = Appearance6
        Me.btnSua_Chua_E1.Enabled = False
        Me.btnSua_Chua_E1.ImageSize = New System.Drawing.Size(18, 18)
        Me.btnSua_Chua_E1.Location = New System.Drawing.Point(432, 24)
        Me.btnSua_Chua_E1.Name = "btnSua_Chua_E1"
        Me.btnSua_Chua_E1.Size = New System.Drawing.Size(80, 32)
        Me.btnSua_Chua_E1.TabIndex = 7
        Me.btnSua_Chua_E1.Text = "Sửa E1"
        '
        'btnXoaE1
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Me.btnXoaE1.Appearance = Appearance7
        Me.btnXoaE1.Enabled = False
        Me.btnXoaE1.Location = New System.Drawing.Point(520, 24)
        Me.btnXoaE1.Name = "btnXoaE1"
        Me.btnXoaE1.Size = New System.Drawing.Size(80, 32)
        Me.btnXoaE1.TabIndex = 8
        Me.btnXoaE1.Text = "Xóa E1"
        '
        'btnThoat
        '
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.btnThoat.Appearance = Appearance8
        Me.btnThoat.ImageSize = New System.Drawing.Size(35, 25)
        Me.btnThoat.Location = New System.Drawing.Point(608, 24)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(48, 32)
        Me.btnThoat.TabIndex = 9
        '
        'dgE1_Di
        '
        Me.dgE1_Di.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Di.DisplayLayout.Appearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance10
        UltraGridColumn7.Header.Caption = "Id E1"
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance11
        UltraGridColumn8.Header.Caption = "Mã E1"
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.Caption = "Đường thư"
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance12
        UltraGridColumn10.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance13
        UltraGridColumn11.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance14
        UltraGridColumn12.Header.Caption = "Nước Nhận"
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance15
        UltraGridColumn13.Header.Caption = "Nước Trả"
        UltraGridColumn13.Header.VisiblePosition = 6
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(56, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance16
        UltraGridColumn14.Header.Caption = "Khối Lượng"
        UltraGridColumn14.Header.VisiblePosition = 7
        UltraGridColumn14.MaskInput = "9999999999"
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance17
        UltraGridColumn15.Header.Caption = "Phân Loại"
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance18
        UltraGridColumn16.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn16.Header.VisiblePosition = 9
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance19
        UltraGridColumn17.Header.Caption = "Cước Chính"
        UltraGridColumn17.Header.VisiblePosition = 10
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance20
        UltraGridColumn18.Header.Caption = "Cước E1"
        UltraGridColumn18.Header.VisiblePosition = 11
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance21
        UltraGridColumn19.Header.Caption = "Ghi Chú"
        UltraGridColumn19.Header.VisiblePosition = 12
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.CellDisplayStyle = Infragistics.Win.UltraWinGrid.CellDisplayStyle.FormattedText
        UltraGridColumn20.EditorControl = Me.dtpNgayDinhDang
        UltraGridColumn20.Format = ""
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance22
        UltraGridColumn20.Header.Caption = "Ngày phát hành"
        UltraGridColumn20.Header.VisiblePosition = 13
        UltraGridColumn20.MaskInput = ""
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.UseEditorMaskSettings = True
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance23
        UltraGridColumn21.Header.Caption = "Giờ phát hành"
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn21.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn21.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn21.MaskInput = "##:##"
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance24
        UltraGridColumn22.Header.Caption = "Kiện số"
        UltraGridColumn22.Header.VisiblePosition = 15
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance25
        UltraGridColumn23.Header.Caption = "Số TT"
        UltraGridColumn23.Header.VisiblePosition = 16
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance26
        UltraGridColumn24.Header.Caption = "Khối lượng Qui đổi"
        UltraGridColumn24.Header.VisiblePosition = 17
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance27
        UltraGridColumn25.Header.VisiblePosition = 18
        UltraGridColumn25.Hidden = True
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance28
        UltraGridColumn26.Header.VisiblePosition = 19
        UltraGridColumn26.Hidden = True
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance29
        UltraGridColumn27.Header.VisiblePosition = 20
        UltraGridColumn27.Hidden = True
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance30
        UltraGridColumn28.Header.VisiblePosition = 21
        UltraGridColumn28.Hidden = True
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance31
        UltraGridColumn29.Header.Caption = "Cước Dịch vụ"
        UltraGridColumn29.Header.VisiblePosition = 22
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance32
        UltraGridColumn30.Header.Caption = "Cước COD"
        UltraGridColumn30.Header.VisiblePosition = 23
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance33
        UltraGridColumn31.Header.Caption = "HH phát hành"
        UltraGridColumn31.Header.VisiblePosition = 24
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance34
        UltraGridColumn32.Header.Caption = "HH phát trả"
        UltraGridColumn32.Header.VisiblePosition = 25
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance35
        UltraGridColumn33.Header.Caption = "Loại"
        UltraGridColumn33.Header.VisiblePosition = 26
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance36
        UltraGridColumn34.Header.VisiblePosition = 27
        UltraGridColumn34.Hidden = True
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance37
        UltraGridColumn35.Header.VisiblePosition = 28
        UltraGridColumn35.Hidden = True
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance38
        UltraGridColumn36.Header.VisiblePosition = 29
        UltraGridColumn36.Hidden = True
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance39
        UltraGridColumn37.Header.VisiblePosition = 30
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 31
        UltraGridColumn38.Hidden = True
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance40
        UltraGridColumn39.Header.Caption = "Dv cộng thêm"
        UltraGridColumn39.Header.VisiblePosition = 32
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance41
        UltraGridColumn40.Header.Caption = "Dv gia tăng"
        UltraGridColumn40.Header.VisiblePosition = 33
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.Header.Caption = "Chuyến Thư"
        UltraGridColumn41.Header.VisiblePosition = 34
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.Caption = "Túi số"
        UltraGridColumn42.Header.VisiblePosition = 35
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(46, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.Caption = "Id Trạng Thái"
        UltraGridColumn43.Header.VisiblePosition = 36
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgE1_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgE1_Di.DisplayLayout.InterBandSpacing = 10
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Di.DisplayLayout.Override.CardAreaAppearance = Appearance42
        Me.dgE1_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance43.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance43.ForeColor = System.Drawing.Color.Black
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance43.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Di.DisplayLayout.Override.HeaderAppearance = Appearance43
        Me.dgE1_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance44.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.Override.RowAppearance = Appearance44
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance45
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance46.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance46
        Me.dgE1_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Di.Location = New System.Drawing.Point(8, 72)
        Me.dgE1_Di.Name = "dgE1_Di"
        Me.dgE1_Di.Size = New System.Drawing.Size(656, 352)
        Me.dgE1_Di.TabIndex = 10
        Me.dgE1_Di.Text = "E1 cần tìm"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        Me.UltraDataSource2.Band.Key = "E2Di"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70})
        Me.UltraDataSource1.Band.Key = "E2Di"
        '
        'ddMaNuoc
        '
        Me.ddMaNuoc.Cursor = System.Windows.Forms.Cursors.Default
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaNuoc.DisplayLayout.Appearance = Appearance47
        UltraGridColumn44.Header.Caption = "Mã nước"
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn45.Header.Caption = "Tên nước"
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridColumn46.Header.Caption = "Khu vực"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn44, UltraGridColumn45, UltraGridColumn46})
        UltraGridBand4.Header.Caption = "Mã tỉnh"
        Me.ddMaNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.ForeColor = System.Drawing.Color.Black
        Appearance48.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaNuoc.DisplayLayout.Override.HeaderAppearance = Appearance48
        Me.ddMaNuoc.DisplayMember = ""
        Me.ddMaNuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaNuoc.Location = New System.Drawing.Point(32, 272)
        Me.ddMaNuoc.Name = "ddMaNuoc"
        Me.ddMaNuoc.Size = New System.Drawing.Size(200, 96)
        Me.ddMaNuoc.TabIndex = 51
        Me.ddMaNuoc.Text = "Danh mục nước"
        Me.ddMaNuoc.ValueMember = ""
        Me.ddMaNuoc.Visible = False
        '
        'ddBuuCuc
        '
        Me.ddBuuCuc.Cursor = System.Windows.Forms.Cursors.SizeWE
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddBuuCuc.DisplayLayout.Appearance = Appearance49
        UltraGridColumn47.Header.Caption = "Mã bưu cục"
        UltraGridColumn47.Header.VisiblePosition = 0
        UltraGridColumn48.Header.Caption = "Tên bưu cục"
        UltraGridColumn48.Header.VisiblePosition = 1
        UltraGridColumn49.Header.Caption = "Mã tỉnh"
        UltraGridColumn49.Header.VisiblePosition = 2
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        Me.ddBuuCuc.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.ForeColor = System.Drawing.Color.Black
        Appearance50.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddBuuCuc.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.ddBuuCuc.DisplayMember = ""
        Me.ddBuuCuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddBuuCuc.Location = New System.Drawing.Point(40, 128)
        Me.ddBuuCuc.Name = "ddBuuCuc"
        Me.ddBuuCuc.Size = New System.Drawing.Size(168, 128)
        Me.ddBuuCuc.TabIndex = 52
        Me.ddBuuCuc.Text = "Danh mục bưu cục"
        Me.ddBuuCuc.ValueMember = ""
        Me.ddBuuCuc.Visible = False
        '
        'ddPhanLoai
        '
        Me.ddPhanLoai.Cursor = System.Windows.Forms.Cursors.Default
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddPhanLoai.DisplayLayout.Appearance = Appearance51
        UltraGridColumn50.Header.Caption = "Phân loại"
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn50.Hidden = True
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance52
        UltraGridColumn51.Header.Caption = "Phân loại"
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn50, UltraGridColumn51})
        UltraGridBand6.Header.Caption = "Mã tỉnh"
        Me.ddPhanLoai.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance53.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance53.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance53.ForeColor = System.Drawing.Color.Black
        Appearance53.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddPhanLoai.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.ddPhanLoai.DisplayMember = "Phan_Loai"
        Me.ddPhanLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddPhanLoai.Location = New System.Drawing.Point(528, 200)
        Me.ddPhanLoai.Name = "ddPhanLoai"
        Me.ddPhanLoai.Size = New System.Drawing.Size(128, 90)
        Me.ddPhanLoai.TabIndex = 55
        Me.ddPhanLoai.Text = "Phân loại hàng hóa"
        Me.ddPhanLoai.ValueMember = "Phan_Loai"
        Me.ddPhanLoai.Visible = False
        '
        'ddLoaiHangHoa
        '
        Me.ddLoaiHangHoa.Cursor = System.Windows.Forms.Cursors.Default
        Appearance54.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLoaiHangHoa.DisplayLayout.Appearance = Appearance54
        UltraGridColumn52.Header.VisiblePosition = 0
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.Caption = "Loại hàng hóa"
        UltraGridColumn53.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn52, UltraGridColumn53})
        UltraGridBand7.Header.Caption = "Mã tỉnh"
        Me.ddLoaiHangHoa.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance55.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance55.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance55.ForeColor = System.Drawing.Color.Black
        Appearance55.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLoaiHangHoa.DisplayLayout.Override.HeaderAppearance = Appearance55
        Me.ddLoaiHangHoa.DisplayMember = "Loai_Hang_Hoa"
        Me.ddLoaiHangHoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLoaiHangHoa.Location = New System.Drawing.Point(440, 296)
        Me.ddLoaiHangHoa.Name = "ddLoaiHangHoa"
        Me.ddLoaiHangHoa.Size = New System.Drawing.Size(128, 90)
        Me.ddLoaiHangHoa.TabIndex = 56
        Me.ddLoaiHangHoa.Text = "Phân loại hàng hóa"
        Me.ddLoaiHangHoa.ValueMember = "Loai_Hang_Hoa"
        Me.ddLoaiHangHoa.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.OptDen)
        Me.UltraGroupBox1.Controls.Add(Me.Optdi)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(264, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(80, 72)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 57
        '
        'OptDen
        '
        Me.OptDen.Location = New System.Drawing.Point(8, 48)
        Me.OptDen.Name = "OptDen"
        Me.OptDen.Size = New System.Drawing.Size(64, 16)
        Me.OptDen.TabIndex = 1
        Me.OptDen.Text = "XN đến"
        '
        'Optdi
        '
        Me.Optdi.Location = New System.Drawing.Point(8, 16)
        Me.Optdi.Name = "Optdi"
        Me.Optdi.Size = New System.Drawing.Size(64, 16)
        Me.Optdi.TabIndex = 0
        Me.Optdi.Text = "Đóng đi"
        '
        'ddLoai
        '
        Me.ddLoai.Cursor = System.Windows.Forms.Cursors.Default
        Appearance56.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLoai.DisplayLayout.Appearance = Appearance56
        UltraGridColumn54.Header.VisiblePosition = 0
        UltraGridColumn54.Hidden = True
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance57
        UltraGridColumn55.Header.Caption = "Tên loại BP"
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn54, UltraGridColumn55})
        UltraGridBand8.Header.Caption = "Mã tỉnh"
        Me.ddLoai.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance58.ForeColor = System.Drawing.Color.Black
        Appearance58.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLoai.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.ddLoai.DisplayMember = "Ten_Loai"
        Me.ddLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLoai.Location = New System.Drawing.Point(248, 120)
        Me.ddLoai.Name = "ddLoai"
        Me.ddLoai.Size = New System.Drawing.Size(128, 90)
        Me.ddLoai.TabIndex = 58
        Me.ddLoai.Text = "Phân loại hàng hóa"
        Me.ddLoai.ValueMember = "Loai"
        Me.ddLoai.Visible = False
        '
        'ddTo_Hop_DV_Gia_Tang
        '
        Me.ddTo_Hop_DV_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Default
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Appearance = Appearance59
        UltraGridColumn56.Header.Caption = "Tổ hợp mã dv"
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn56})
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance60
        Me.ddTo_Hop_DV_Gia_Tang.DisplayMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Location = New System.Drawing.Point(504, 104)
        Me.ddTo_Hop_DV_Gia_Tang.Name = "ddTo_Hop_DV_Gia_Tang"
        Me.ddTo_Hop_DV_Gia_Tang.Size = New System.Drawing.Size(120, 96)
        Me.ddTo_Hop_DV_Gia_Tang.TabIndex = 62
        Me.ddTo_Hop_DV_Gia_Tang.ValueMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Visible = False
        '
        'ddTo_Hop_DV_Cong_Them
        '
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Appearance = Appearance61
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance62
        UltraGridColumn57.Header.Caption = "Tổ hợp dịch vụ"
        UltraGridColumn57.Header.VisiblePosition = 0
        UltraGridColumn57.Width = 137
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn57})
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance63.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance63.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance63
        Me.ddTo_Hop_DV_Cong_Them.DisplayMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Location = New System.Drawing.Point(384, 160)
        Me.ddTo_Hop_DV_Cong_Them.Name = "ddTo_Hop_DV_Cong_Them"
        Me.ddTo_Hop_DV_Cong_Them.Size = New System.Drawing.Size(128, 112)
        Me.ddTo_Hop_DV_Cong_Them.TabIndex = 61
        Me.ddTo_Hop_DV_Cong_Them.ValueMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Visible = False
        '
        'ddLy_do
        '
        Me.ddLy_do.Cursor = System.Windows.Forms.Cursors.Default
        Appearance64.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLy_do.DisplayLayout.Appearance = Appearance64
        UltraGridColumn58.Header.Caption = "Lý Do"
        UltraGridColumn58.Header.VisiblePosition = 0
        UltraGridColumn59.Header.Caption = "Tên Lý Do"
        UltraGridColumn59.Header.VisiblePosition = 1
        UltraGridColumn60.Header.VisiblePosition = 2
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 3
        UltraGridColumn61.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61})
        UltraGridBand11.Header.Caption = "Mã tỉnh"
        Me.ddLy_do.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance65.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance65.ForeColor = System.Drawing.Color.Black
        Appearance65.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLy_do.DisplayLayout.Override.HeaderAppearance = Appearance65
        Me.ddLy_do.DisplayMember = ""
        Me.ddLy_do.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLy_do.Location = New System.Drawing.Point(272, 280)
        Me.ddLy_do.Name = "ddLy_do"
        Me.ddLy_do.Size = New System.Drawing.Size(128, 90)
        Me.ddLy_do.TabIndex = 63
        Me.ddLy_do.Text = "Id Trạng Thái"
        Me.ddLy_do.ValueMember = ""
        Me.ddLy_do.Visible = False
        '
        'FrmSuaChuaE1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 429)
        Me.Controls.Add(Me.ddLy_do)
        Me.Controls.Add(Me.ddTo_Hop_DV_Gia_Tang)
        Me.Controls.Add(Me.ddTo_Hop_DV_Cong_Them)
        Me.Controls.Add(Me.ddLoai)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ddLoaiHangHoa)
        Me.Controls.Add(Me.ddPhanLoai)
        Me.Controls.Add(Me.dtpNgayDinhDang)
        Me.Controls.Add(Me.ddBuuCuc)
        Me.Controls.Add(Me.ddMaNuoc)
        Me.Controls.Add(Me.dgE1_Di)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoaE1)
        Me.Controls.Add(Me.btnSua_Chua_E1)
        Me.Controls.Add(Me.btnTimE1)
        Me.Controls.Add(Me.txtE1)
        Me.Controls.Add(Me.cbBuuCuc)
        Me.Controls.Add(Me.cbNuoc)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.UltraLabel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSuaChuaE1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa chữa thông tin E1 theo số hiệu E1"
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbBuuCuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddBuuCuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhanLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLoaiHangHoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ddLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLy_do, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến trong Form"
    Dim myNuoc As New Ma_Nuoc(GConnectionString)
    Dim myBuuCuc As New Danh_Muc_BC(GConnectionString)
    Dim myE1Di As New E1_Di(GConnectionString)
    Dim myE1Den As New E1_Den(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim mychuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myHam_dung_chung As New Ham_Dung_Chung
    Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
    Dim myTinh_Cuoc_Chi_Tiet As Tinh_Cuoc_Chi_Tiet
    Dim myDichVu As New Dich_Vu(GConnectionString)
    Dim myDataSet As New DataSet
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
#End Region

#Region "-----------------------Tao_Bang_Id_Phan_Loai-----------------------"
    Private Sub Tao_Bang_Id_Phan_Loai()
        Try
            'Them moi mot bang
            Dim dataTable As New DataTable("Phan_Loai")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Phan_Loai", GetType(String))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Phan_Loai", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Phan_Loai") = "D"
            row("Ten_Phan_Loai") = "Tài liệu"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Phan_Loai") = "M"
            row("Ten_Phan_Loai") = "Hàng hoá"
            dataTable.Rows.Add(row)

            ddPhanLoai.DataSource = dataTable
            ddPhanLoai.DataBind()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "-----------------------Tao_Bang_Loai_Hang_Hoa-----------------------"
    Private Sub Tao_Bang_Loai_Hang_Hoa()
        Try
            'Them moi mot bang
            Dim dataTable As New DataTable("Loai_Hang_Hoa")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Loai_Hang_Hoa", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Loai", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Loai_Hang_Hoa") = 0
            row("Ten_Loai") = "Hàng bình thường"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Loai_Hang_Hoa") = 1
            row("Ten_Loai") = "Hàng nhẹ"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Loai_Hang_Hoa") = 2
            row("Ten_Loai") = "Hàng cồng kềnh"
            dataTable.Rows.Add(row)

            ddLoaiHangHoa.DataSource = dataTable
            ddLoaiHangHoa.DataBind()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Loai-----------------------"
    Private Sub Tao_Bang_Loai()
        Try
            'Them moi mot bang
            Dim dataTable As New DataTable("Loai")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Loai", GetType(Int32))
            dataTable.Columns.Add(colWork)
            colWork = New DataColumn("Ten_Loai", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Loai") = 0
            row("Ten_Loai") = "EMS"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Loai") = 1
            row("Ten_Loai") = "Sự vụ"
            dataTable.Rows.Add(row)

            ddLoai.DataSource = dataTable
            ddLoai.DataBind()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "DataBinding"
    Private Sub DataBinding()
        Try
            cbNuoc.DataSource = myNuoc.Danh_Sach
            cbNuoc.DataBind()
            If cbNuoc.Rows.Count > 0 Then
                cbNuoc.Text = "VN"
            End If

            cbBuuCuc.DataSource = myBuuCuc.Danh_Sach_Rut_Gon
            cbBuuCuc.DataBind()
            If cbBuuCuc.Rows.Count > 0 Then
                cbBuuCuc.Value = cbBuuCuc.Rows(0).Cells("Ma_BC").Value
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmSuaChuaE1_Load"
    Private Sub FrmSuaChuaE1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tao_Bang_Loai_Hang_Hoa()
            Tao_Bang_Id_Phan_Loai()
            Tao_Bang_Loai()
            To_Hop_Ma_DV_Cong_Them()
            To_Hop_Ma_DV_Gia_Tang()
            DataInit()
            DataBinding()
            txtE1.Select()
            Optdi.Checked = True
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tạo bảng To_Hop_Ma_DV_Cong_Them"
    Private Sub To_Hop_Ma_DV_Cong_Them()
        'Them moi mot bang
        'Dim dataTable As New DataTable("To_Hop_Ma_DV_Cong_Them")

        ''Tao ra cac cot cua bang nay
        'Dim colWork As DataColumn = New DataColumn("To_Hop_Ma", GetType(String))
        'dataTable.Columns.Add(colWork)

        ''Them du lieu vao
        'Dim row As DataRow = dataTable.NewRow()
        'row("To_Hop_Ma") = "ARGS"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "PTT"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "ART"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "RBG_C"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "RBG_K"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "DDC_C"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "DDC_K"
        'dataTable.Rows.Add(row)


        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "ARGS,PTT"
        'dataTable.Rows.Add(row)

        ddTo_Hop_DV_Cong_Them.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(0)
        ddTo_Hop_DV_Cong_Them.DataBind()
    End Sub
#End Region

#Region "Tạo bảng To_Hop_Ma_DV_Gia_Tang"
    Private Sub To_Hop_Ma_DV_Gia_Tang()
        'Them moi mot bang
        'Dim dataTable As New DataTable("To_Hop_Ma_DV_Gia_Tang")

        ''Tao ra cac cot cua bang nay
        'Dim colWork As DataColumn = New DataColumn("To_Hop_Ma", GetType(String))
        'dataTable.Columns.Add(colWork)

        ''Them du lieu vao
        'Dim row As DataRow = dataTable.NewRow()
        'row("To_Hop_Ma") = "PHT"
        'dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("To_Hop_Ma") = "PHG"
        'dataTable.Rows.Add(row)

        ddTo_Hop_DV_Gia_Tang.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(1)
        ddTo_Hop_DV_Gia_Tang.DataBind()
    End Sub
#End Region

#Region "Update_Cuoc"
    Private Sub Update_Cuoc(ByVal sender As Object)
        myGridKeyDown = sender
        Dim Ngay_Phat_Hanh As Integer
        Dim Cuoc_E1 As Double
        Dim Cuoc_DVCT As Double
        Dim Cuoc_DVGT As Double
        With myGridKeyDown
            If .Rows(.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text.Length = 0 Then
                Ngay_Phat_Hanh = CInt(Ham_Dung_Chung.ConvertDateToInt(CDate(Date.Now)))
            Else
                Ngay_Phat_Hanh = CInt(Ham_Dung_Chung.ConvertDateToInt(.Rows(.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value))
            End If

            .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = GVat

            Cuoc_E1 = myTinh_Cuoc.Cuoc_Chinh_E1(CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text), _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text), _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("PostCode").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Text, _
                                IIf(CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text) = 0, CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text), CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text)), _
                                Ngay_Phat_Hanh, _
                                CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value))

            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = Cuoc_E1

            'Cuoc HSXT
            If .Rows(.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value = 2 Then
                Cuoc_E1 = Cuoc_E1 * 1.5
                .Rows(.ActiveRow.Index).Cells("Cuoc_Chinh").Value = Cuoc_E1
            End If

            .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                Ngay_Phat_Hanh)
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                Ngay_Phat_Hanh) * Cuoc_E1
            Cuoc_DVCT = _
                                myTinh_Cuoc.Cuoc_DV_Cong_Them(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text, _
                                Ngay_Phat_Hanh)
            Cuoc_DVGT = myTinh_Cuoc.Cuoc_DV_Gia_Tang(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Text, _
                                IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, _
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                Ngay_Phat_Hanh)
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = Cuoc_DVCT + Cuoc_DVGT
            Cuoc_E1 = Round(Cuoc_E1 * (1 + GVat) + 0.0005)
            Cuoc_DVCT = Round(Cuoc_DVCT * (1 + GVat) + 0.0005)
            Cuoc_DVGT = Round(Cuoc_DVGT * (1 + GVat) + 0.0005)
            .Rows(.ActiveRow.Index).Cells("Cuoc_E1").Value = Cuoc_E1 + Cuoc_DVCT + Cuoc_DVGT

        End With
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Try
            Close()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "cbBuuCuc_Validated"
    Private Sub cbBuuCuc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBuuCuc.Validated
        Try
            cbBuuCuc.Text = FormatMaBc(cbBuuCuc.Text)
            If cbBuuCuc.Text = "000000" Then
                cbBuuCuc.Enabled = False
                cbNuoc.Enabled = True
                cbNuoc.Focus()
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmSuaChuaE1_KeyPress"
    Private Sub FrmSuaChuaE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "cbNuoc_Validated"
    Private Sub cbNuoc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNuoc.Validated
        Try
            If txtE1.Text.Length = 13 Then
                'txtE1.Text = Mid(txtE1.Text, 1, 11) & cbNuoc.Text
                txtE1.Text = Tim_MAE1_Tu_Nuoc_Nhan(txtE1.Text, cbNuoc.Text)
            End If
            If cbNuoc.Text = "VN" Then
                cbBuuCuc.Enabled = True
                cbNuoc.Enabled = False
                cbBuuCuc.Focus()
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnTimE1_Click"
    Private Sub btnTimE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimE1.Click
        Dim ngay_cho_phep_sua As Integer = myHam_dung_chung.ConvertDateToInt(Now().Date.AddDays(-GSo_Ngay_Cho_Phep_Sua_E1))
        Try
            If myHam_dung_chung.Check_E1(txtE1.Text) = False Then
                CMessageBox.Show("Mã E1 sai, không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnSua_Chua_E1.Enabled = False
                btnXoaE1.Enabled = False
                dgE1_Di.DataSource = myE1Den.E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1("", 0, 20990101)
                dgE1_Di.DataBind()
                Exit Sub
            End If
            If Optdi.Checked = True Then
                dgE1_Di.DataSource = myE1Di.E1_Di_Lay_Boi_Ma_E1_Sua_Chua_E1(txtE1.Text.Trim, GBuu_Cuc_Khai_Thac, ngay_cho_phep_sua)
                dgE1_Di.DataBind()
                btnSua_Chua_E1.Enabled = True
                btnXoaE1.Enabled = True
            Else

                dgE1_Di.DataSource = myE1Den.E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1(txtE1.Text.Trim, GBuu_Cuc_Khai_Thac, ngay_cho_phep_sua)
                dgE1_Di.DataBind()
                btnSua_Chua_E1.Enabled = True
                btnXoaE1.Enabled = True
            End If
            If dgE1_Di.Rows.Count = 0 Then
                CMessageBox.Show("Không có dữ liệu về mã này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgE1_Di.DataSource = myE1Den.E1_Den_Lay_Boi_Ma_E1_Sua_Chua_E1("", 0, 20990101)
                dgE1_Di.DataBind()
                Exit Sub
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "DataInit"
    Private Sub DataInit()
        Try
            ddMaNuoc.DataSource = myNuoc.Danh_Sach
            ddMaNuoc.DataBind()

            ddBuuCuc.DataSource = myBuuCuc.Danh_Sach_Rut_Gon
            ddBuuCuc.DataBind()

            ddLy_Do_Load_Data()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load data into ddLy_Do"
    Private Sub ddLy_Do_Load_Data()
        Dim myLyDo As New Ly_Do_Vao_Kho_HQ(GConnectionString)
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable
        myDataSet = myLyDo.Ly_Do_Vao_Kho_HQ_Danh_Sach
        myTable = myDataSet.Tables(0)
        ddLy_do.DataSource = myTable
        ddLy_do.DataBind()
    End Sub
#End Region

#Region "dgE1_Di_InitializeLayout"
    Private Sub dgE1_Di_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Di.InitializeLayout
        Try
            dgE1_Di.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
            dgE1_Di.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
            With dgE1_Di.DisplayLayout
                .Bands(0).Columns("Nuoc_Nhan").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Nuoc_Nhan").ValueList = ddMaNuoc
                .Bands(0).Columns("Nuoc_Tra").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Nuoc_Tra").ValueList = ddMaNuoc
                .Bands(0).Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDown
                .Bands(0).Columns("Ma_Bc_Goc").ValueList = ddBuuCuc
                .Bands(0).Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Ma_Bc_Tra").ValueList = ddBuuCuc
                .Bands(0).Columns("Phan_Loai").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Phan_Loai").ValueList = ddPhanLoai
                .Bands(0).Columns("Loai_Hang_Hoa").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Loai_Hang_Hoa").ValueList = ddLoaiHangHoa
                .Bands(0).Columns("Loai").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Loai").ValueList = ddLoai
                .Bands(0).Columns("Id_Trang_Thai").Style = ColumnStyle.DropDownValidate
                .Bands(0).Columns("Id_Trang_Thai").ValueList = ddLy_do
            End With
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgE1_Di_KeyDown"
    Private Sub dgE1_Di_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Di.KeyDown
        Try
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
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgE1_Di_BeforeCellDeactivate"
    Private Sub dgE1_Di_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Di.BeforeCellDeactivate
        Try
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
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tính Cước chính"
    Public Function Tinh_Cuoc_Chinh(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal PostCode As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai As Integer, ByVal Loai_Hang_Hoa As Integer) As Tinh_Cuoc_Chi_Tiet
        Try
            Dim myTinh_Cuoc_Chi_Tiet As New Tinh_Cuoc_Chi_Tiet
            If Loai = 1 Then 'Sự vụ
                myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh = 0
                myTinh_Cuoc_Chi_Tiet.Cong_Chap_Nhan = 0
                myTinh_Cuoc_Chi_Tiet.Cuoc_PPVX = 0
                myTinh_Cuoc_Chi_Tiet.PPXD = 0
                myTinh_Cuoc_Chi_Tiet.Cuoc_PPXD = 0
                myTinh_Cuoc_Chi_Tiet.Ty_Gia = 0
                myTinh_Cuoc_Chi_Tiet.VAT = 0
            Else 'Loại bình thường
                If Mid(MAE1, 12, 2) = "VN" Then 'Tính cước trong nước
                    myTinh_Cuoc_Chi_Tiet = myTinh_Cuoc.Tinh_Cuoc_TN(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, Ngay_Chap_Nhan, Loai_Hang_Hoa)
                Else 'Tính cước quốc tế
                    myTinh_Cuoc_Chi_Tiet = myTinh_Cuoc.Tinh_Cuoc_QT(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, PostCode, Ngay_Chap_Nhan, Loai_Hang_Hoa)
                End If
                If Loai_Hang_Hoa = 1 Then 'Hàng cồng kềnh cước bằng 1.5 lần cước chính
                    With myTinh_Cuoc_Chi_Tiet
                        .Cuoc_CS = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_CS
                        .VAT = myTinh_Cuoc_Chi_Tiet.VAT
                        .PPXD = myTinh_Cuoc_Chi_Tiet.PPXD
                        .Cuoc_PPXD = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_PPXD
                        .Cuoc_PPVX = myTinh_Cuoc_Chi_Tiet.Cuoc_PPVX
                        .Ty_Gia = myTinh_Cuoc_Chi_Tiet.Ty_Gia
                        .Cuoc_Dich_Vu = myTinh_Cuoc_Chi_Tiet.Cuoc_Dich_Vu
                        .Cuoc_Chinh = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh
                        .Cong_Chap_Nhan = 1.5 * myTinh_Cuoc_Chi_Tiet.Cong_Chap_Nhan
                        .Cuoc_Chinh = 1.5 * myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh
                    End With
                End If
            End If
            Return myTinh_Cuoc_Chi_Tiet
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "Tính công phát"
    Public Function Tinh_Cong_Phat(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai As Integer) As Integer
        Try
            If Loai = 1 Then
                Return 0
            Else
                Return myTinh_Cuoc.Tinh_Cong_Phat(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, Ngay_Chap_Nhan)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

    '#Region "Update_Cuoc"
    '    Private Sub Update_Cuoc(ByVal MAE1 As String, ByVal Ma_Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Khoi_Luong As Integer, ByVal Phan_Loai As String, ByVal PostCode As String, ByVal Ngay_Chap_Nhan As Integer, ByVal Loai As Integer, ByVal Loai_Hang_Hoa As Integer)
    '        Try
    '            Dim myTinh_Cuoc_Chi_Tiet As Tinh_Cuoc_Chi_Tiet
    '            myTinh_Cuoc_Chi_Tiet = Tinh_Cuoc_Chinh(MAE1, Ma_Nuoc_Tra, Ma_Bc_Tra, Khoi_Luong, Phan_Loai, PostCode, Ngay_Chap_Nhan, Loai, Loai_Hang_Hoa)
    '            With dgE1_Di
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("PPXD").Value = myTinh_Cuoc_Chi_Tiet.PPXD.ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPXD").Value = myTinh_Cuoc_Chi_Tiet.Cuoc_PPXD.ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPVX").Value = myTinh_Cuoc_Chi_Tiet.Cuoc_PPVX.ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("VAT").Value = myTinh_Cuoc_Chi_Tiet.VAT.ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_Chinh").Value = myTinh_Cuoc_Chi_Tiet.Cuoc_Chinh.ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Tra").Value = Tinh_Cong_Phat(MAE1, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Tra").Text, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong_QD").Text, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Phan_Loai").Text, myHam_dung_chung.ConvertDateToInt(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value), dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Loai").Value).ToString
    '                .Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc_Chi_Tiet.Cong_Chap_Nhan.ToString
    '            End With
    '        Catch ex As Exception
    '            CMessageBox.Show(ex.ToString)
    '        End Try
    '    End Sub
    '#End Region

#Region "dgE1_Di_AfterExitEditMode"
    Private Sub dgE1_Di_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di.AfterExitEditMode
        Try
            Select Case dgE1_Di.ActiveCell.Column.Key
                Case "Ngay_Phat_Hanh"
                    If dgE1_Di.ActiveCell.Text.Length = 0 Then
                        CMessageBox.Show("Ngày phát hành không được để trống !!!", " Lỗi ")
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    End If
                Case "Gio_Phat_Hanh"
                    If dgE1_Di.ActiveCell.Text.Length = 0 Then
                        CMessageBox.Show("Giờ phát hành không được để trống !!!", " Lỗi ")
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    End If
                Case "Khoi_Luong"
                    If CInt(dgE1_Di.ActiveCell.Text) > 0 Then
                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = dgE1_Di.ActiveCell.Value
                        'Tính cước chính bằng Khối lượng QD
                        'Update_Cuoc(sender)
                    Else
                        CMessageBox.Show("Chưa nhập khối lượng bưu phẩm!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        myCell = dgE1_Di.ActiveCell
                    End If
                Case "Ma_E1"
                    If dgE1_Di.ActiveCell.Text = "" Then
                        Exit Sub
                    End If
                    Dim MAE1 As String
                    Dim Nuoc_Nhan As String
                    Dim Bc_Goc As Integer
                    txtE1.Value = GetCorrectMAE1(dgE1_Di.ActiveCell.Text, IIf(cbNuoc.Value Is Nothing, "VN", cbNuoc.Value), cbBuuCuc.Text, "EE000000000VN")
                    MAE1 = dgE1_Di.ActiveCell.Value
                    If MAE1.Length > 13 Then
                        CMessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "Xin mời bạn nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    ElseIf (myHam_dung_chung.Check_E1(MAE1) = False) Then
                        CMessageBox.Show("Số hiệu E1 này không có thật !!! ", "Thông báo", MessageBoxButtons.OK)
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    End If
                    If dgE1_Di.ActiveCell.Text.Length = 0 Then
                        CMessageBox.Show("Mã E1 không được để trống !!!", " Lỗi ")
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    Else
                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Nhan").Value = TimNuocNhanTuE1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value)
                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = Tim_Danh_Muc_BC_TuE1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value).Ma_Tinh
                    End If
                    'Update_Cuoc(sender)
                Case "Ma_Bc_Goc"
                    dgE1_Di.ActiveCell.Value = FormatMaBc(dgE1_Di.ActiveCell.Text)
                    If dgE1_Di.ActiveCell.Text = "100915" Then 'Hàng quốc tế
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                        myCell = myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan")
                        dgE1_Di.ActiveCell = myCell
                        dgE1_Di.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Else
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                    End If
                    If dgE1_Di.ActiveCell.Text = "0" Then 'Hàng quốc tế
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                    Else
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                    End If
                    'Update_Cuoc(sender)
                Case "Ma_Bc_Tra"
                    If dgE1_Di.ActiveCell.Text = "0" Then 'Hàng quốc tế
                        dgE1_Di.ActiveCell.Value = 0
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                        dgE1_Di.DisplayLayout.Bands(0).Columns("PostCode").Hidden = False
                    Else
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                        dgE1_Di.DisplayLayout.Bands(0).Columns("PostCode").Hidden = True
                        dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = "VN"
                        dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("PostCode").Value = ""
                    End If
                    'Update_Cuoc(sender)
                Case "Nuoc_Tra"
                    If dgE1_Di.ActiveCell.Text.Length = 0 Then
                        CMessageBox.Show("Mã Nước trả không được để trống !!!", " Lỗi ")
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    End If
                    'Update_Cuoc(sender)
                Case "Phan_Loai"
                    If Trim(dgE1_Di.ActiveCell.Text) = "M" Then
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").Hidden = False
                    Else
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").Hidden = True
                    End If
                    'Update_Cuoc(sender)
                Case "Loai_Hang_Hoa" 'Tính lại cước bằng khối lượng quy đổi
                    If dgE1_Di.ActiveCell.Value = 1 Then 'Hàng nhẹ
                        'Xuất hiện Form nhập kích thước
                        Dim Frm As New FrmTinh_Hang_Nhe
                        Frm.ShowDialog()
                        If Frm.txtKet_Qua.Text <> 0 Then
                            dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong").Value = CInt(Frm.txtKet_Qua.Text)
                            dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong").Value
                        End If
                    End If
                    'Update_Cuoc(sender)
                Case "Cuoc_Chinh"
                    If dgE1_Di.ActiveCell.Text.Length = 0 Then
                        CMessageBox.Show("Cước chính không được để trống !!!", " Lỗi ")
                        myCell = dgE1_Di.ActiveCell
                        Exit Sub
                    End If
                Case "Cuoc_E1"
                    If dgE1_Di.ActiveCell.Value = 0 Then
                        CMessageBox.Show("Cước E1 này bằng 0, xin hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK)
                        'Exit Sub
                    End If
                Case "Nuoc_Nhan"
                    If dgE1_Di.ActiveCell.Text = "VN" Then
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                        Exit Sub
                    Else
                        dgE1_Di.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = True
                    End If
                    dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value = Tim_MAE1_Tu_Nuoc_Nhan(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Text, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Nhan").Text)
                    'Update_Cuoc(sender)
                Case "Loai"
                    'Update_Cuoc(sender)
                Case "Dv_Cong_Them"
                    'Update_Cuoc(sender)
                Case "Dv_gia_tang"
                    'Update_Cuoc(sender)
            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnXoaE1_Click"
    Private Sub btnXoaE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaE1.Click
        Try
            If CMessageBox.Show("Bạn có chắc chắn là xóa E1 này khỏi hệ thống ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Optdi.Checked = True Then ' Chiều đi
                    Dim myE1DiChiTiet As New E1_Di_Chi_Tiet
                    myE1DiChiTiet = myE1Di.Lay(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                    If myE1DiChiTiet.Id_Ca <> GId_Ca And GUserAdmin = False Then
                        CMessageBox.Show("Mã E1 này không thuộc ca hiện tại" & vbNewLine & " Bạn không có quyền chỉnh sửa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If dgE1_Di.Rows.Count > 0 Then
                        'Them phan Ghi Log (Chuan bi du lieu) ========================================
                        Dim myBo_Phan As Integer = 2  'Thiet lap di
                        Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi xoa E1
                        Dim myChi_Tiet_Sau As String     'Chi tiet sau khi xoa E1
                        'Tao chi tiet truoc
                        myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DiChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DiChiTiet.Ma_E1, myE1DiChiTiet.Khoi_Luong, myE1DiChiTiet.Phan_Loai)
                        'Tao chi tiet sau
                        myChi_Tiet_Sau = ""
                        '==============================================================================

                        'Xoá E1 trong bảng E1_Di
                        myE1Di.Xoa(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                        'Hiệu chỉnh lại thông tin trong bảng E2_Di và Chuyen_Thu_Di
                        myE1Di.Hieu_Chinh(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Text, True)

                        'Them phan Ghi Log (Ghi Du lieu Log )==========================================
                        'Ghi vao Log
                        Mdl_Event_Viewer.Event_Viewer_Delete_E1(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
                        '==============================================================================

                        dgE1_Di.ActiveRow.Delete(False)

                        CMessageBox.Show("OK ! Đã xóa E1 thành công !!!")
                        'dgE1_Di.DataSource = myE1Di.Lay_Boi_Ma_E1(0, 0, 0)
                        'dgE1_Di.DataBind()
                    End If
                Else ' Chiều đến
                    Dim myE1DenChiTiet As New E1_Den_Chi_Tiet
                    myE1DenChiTiet = myE1Den.Lay(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                    If myE1DenChiTiet.Id_Ca <> GId_Ca And GUserAdmin = False Then
                        CMessageBox.Show("Mã E1 này không thuộc ca hiện tại" & vbNewLine & " Bạn không có quyền chỉnh sửa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If dgE1_Di.Rows.Count > 0 Then
                        'Them phan Ghi Log (Chuan bi du lieu) ========================================
                        Dim myBo_Phan As Integer = 1  'Xac nhan den
                        Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi xoa E1
                        Dim myChi_Tiet_Sau As String     'Chi tiet sau khi xoa E1
                        'Tao chi tiet truoc
                        myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DenChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DenChiTiet.Ma_E1, myE1DenChiTiet.Khoi_Luong, myE1DenChiTiet.Phan_Loai)
                        'Tao chi tiet sau
                        myChi_Tiet_Sau = ""
                        '==============================================================================

                        'Xoá E1 trong bảng E1_Di
                        myE1Den.Xoa(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)

                        'Xoa trong E1 le phi di va Paypost
                        Dim myE1_Le_Phi_Di As New E1_Le_Phi_Di(GConnectionString)
                        Dim myE1_COD_Tam As New E1_COD_Tam(GConnectionString)
                        myE1_Le_Phi_Di.E1_Le_Phi_Di_Xoa(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                        myE1_COD_Tam.Xoa(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                        '-----------------------------------------------------

                        'Hiệu chỉnh lại thông tin trong bảng E2_Di và Chuyen_Thu_Di
                        myE1Di.Hieu_Chinh(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Text, False)

                        'Them phan Ghi Log (Ghi Du lieu Log )==========================================
                        'Ghi vao Log
                        Mdl_Event_Viewer.Event_Viewer_Delete_E1(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
                        '==============================================================================

                        dgE1_Di.ActiveRow.Delete(False)

                        CMessageBox.Show("OK ! Đã xóa E1 thành công !!!")
                        'dgE1_Di.DataSource = myE1Di.Lay_Boi_Ma_E1(0, 0, 0)
                        'dgE1_Di.DataBind()
                    End If
                End If
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnSua_Chua_E1_Click"
    Private Sub btnSua_Chua_E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua_Chua_E1.Click
        Try
            If dgE1_Di.Rows.Count > 0 Then
                If CMessageBox.Show("Bạn có thực sự Sửa chữa thông tin về mã E1 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If Optdi.Checked = True Then
                        Dim myE1DiChiTiet As New E1_Di_Chi_Tiet
                        myE1DiChiTiet = myE1Di.Lay(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                        If myE1DiChiTiet.Id_Ca <> GId_Ca And GUserAdmin = False Then
                            CMessageBox.Show("Mã E1 này không thuộc ca hiện tại" & vbNewLine & " Bạn không có quyền chỉnh sửa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        If dgE1_Di.Rows.Count > 0 Then
                            'Sửa Id_E1
                            Dim Id_E1_Moi As String
                            Id_E1_Moi = CreateId_E1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Value, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Kien_So").Value)
                            'Them phan Ghi Log (Chuan bi du lieu) ========================================
                            Dim myBo_Phan As Integer = 2  'Thiet lap di
                            Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi sua E1
                            Dim myChi_Tiet_Sau As String     'Chi tiet sau khi sua E1
                            'Tao chi tiet truoc
                            myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DiChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DiChiTiet.Ma_E1, myE1DiChiTiet.Khoi_Luong, myE1DiChiTiet.Phan_Loai)
                            'Tao chi tiet sau
                            myChi_Tiet_Sau = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DiChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DiChiTiet.Ma_E1, dgE1_Di.ActiveRow.Cells("Khoi_Luong").Text, dgE1_Di.ActiveRow.Cells("Phan_Loai").Value)
                            '==============================================================================                 
                            'Sửa chữa trong bảng E1_Di
                            myE1Di.Cap_Nhat_Sua_Chua_E1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Value, _
                                                        Id_E1_Moi, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                        myHam_dung_chung.ConvertDateToInt(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value), _
                                                        myHam_dung_chung.ConvertTimeToInt(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value), _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_BC_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_Bc_Goc").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Nhan").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Phan_Loai").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong_QD").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_Chinh").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_Dv").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_COD").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Hanh").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_E1").Value, _
                                                        IIf(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ghi_Chu").Value Is System.DBNull.Value, "", dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ghi_Chu").Text), _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Loai").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("PPXD").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("VAT").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPXD").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPVX").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Dv_Cong_Them").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Dv_Gia_Tang").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_Trang_Thai").Value)
                            'Hiệu chỉnh lại thông tin trong bảng E2_Di và Chuyen_Thu_Di
                            myE1Di.Hieu_Chinh(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Text, True)

                            'Them phan Ghi Log (Ghi Du lieu Log )==========================================
                            'Ghi vao Log
                            Mdl_Event_Viewer.Event_Viewer_Edit_E1(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
                            '==============================================================================

                            'Sửa chữa trong bảng E1_Le_Phi_Di

                            CMessageBox.Show("Ok ! Đã sửa chữa thành công thông tin mã E1 này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'dgE1_Di.DataSource = myE1Di.Lay_Boi_Ma_E1(0, 0, 0)
                            'dgE1_Di.DataBind()
                            btnTimE1_Click(sender, e)
                        End If
                    Else
                        Dim myE1DenChiTiet As New E1_Den_Chi_Tiet
                        myE1DenChiTiet = myE1Den.Lay(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Text)
                        If myE1DenChiTiet.Id_Ca <> GId_Ca And GUserAdmin = False Then
                            CMessageBox.Show("Mã E1 này không thuộc ca hiện tại" & vbNewLine & " Bạn không có quyền chỉnh sửa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        If dgE1_Di.Rows.Count > 0 Then
                            'Sửa Id_E1
                            Dim Id_E1_Moi As String
                            Id_E1_Moi = CreateId_E1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Value, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Kien_So").Value)

                            'Them phan Ghi Log (Chuan bi du lieu) ======================================
                            Dim myBo_Phan As Integer = 1  'Xac nhan den
                            Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi sua E1
                            Dim myChi_Tiet_Sau As String     'Chi tiet sau khi sua E1
                            'Tao chi tiet truoc
                            myChi_Tiet_Truoc = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DenChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DenChiTiet.Ma_E1, myE1DenChiTiet.Khoi_Luong, myE1DenChiTiet.Phan_Loai)
                            'Tao chi tiet sau
                            myChi_Tiet_Sau = Mdl_Event_Viewer.Event_Viewer_Create_Chi_Tiet_E1(dgE1_Di.ActiveRow.Cells("Id_Duong_Thu").Value, myE1DenChiTiet.Ngay_Dong, Mdl_Event_Viewer.Get_Loai_Chuyen_Thu_From_Id_Chuyen_Thu(dgE1_Di.ActiveRow.Cells("Id_Chuyen_Thu").Text), dgE1_Di.ActiveRow.Cells("Chuyen_Thu").Value, dgE1_Di.ActiveRow.Cells("Tui_So").Value, myE1DenChiTiet.Ma_E1, dgE1_Di.ActiveRow.Cells("Khoi_Luong").Text, dgE1_Di.ActiveRow.Cells("Phan_Loai").Value)
                            '==============================================================================

                            'Sửa chữa trong bảng E1_Di
                            myE1Den.Cap_Nhat_Sua_Chua_E1(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E1").Value, _
                                                        Id_E1_Moi, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                        myHam_dung_chung.ConvertDateToInt(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value), _
                                                        myHam_dung_chung.ConvertTimeToInt(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value), _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_BC_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_Bc_Goc").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Nhan").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Nuoc_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Phan_Loai").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Khoi_Luong_QD").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_Chinh").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_Dv").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_COD").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Hanh").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("HH_Phat_Tra").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_E1").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ghi_Chu").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Loai").Value, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("PPXD").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("VAT").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPXD").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Cuoc_PPVX").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Dv_Cong_Them").Text, _
                                                        dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Dv_Gia_Tang").Text, dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_Trang_Thai").Value)
                            'Hiệu chỉnh lại thông tin trong bảng E2_Di và Chuyen_Thu_Di
                            myE1Di.Hieu_Chinh(dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Id_E2").Text, False)

                            'Them phan Ghi Log (Ghi Du lieu Log )========================================
                            'Ghi vao Log
                            Mdl_Event_Viewer.Event_Viewer_Edit_E1(myBo_Phan, myChi_Tiet_Truoc, myChi_Tiet_Sau)
                            '============================================================================

                            'Sửa chữa trong bảng E1_Le_Phi_Den

                            CMessageBox.Show("Ok ! Đã sửa chữa thành công thông tin mã E1 này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'dgE1_Di.DataSource = myE1Di.Lay_Boi_Ma_E1(0, 0, 0)
                            'dgE1_Di.DataBind()
                            btnTimE1_Click(sender, e)
                        End If
                    End If
                Else
                    btnTimE1_Click(sender, e)
                End If
            Else
                CMessageBox.Show("Không có thông tin về mã E1 cần sửa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "txtE1_Validated"
    Private Sub txtE1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtE1.Validated
        Try
            If txtE1.Text = "" Then
                Exit Sub
            End If
            txtE1.Value = GetCorrectMAE1(txtE1.Text, IIf(cbNuoc.Value Is Nothing, "VN", cbNuoc.Value), cbBuuCuc.Text, "EE000000000VN")
            If myHam_dung_chung.Check_E1(txtE1.Text) = False Then
                CMessageBox.Show("Mã E1 sai, không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            cbBuuCuc.Text = Tim_Danh_Muc_BC_TuE1(txtE1.Text).Ma_Tinh.ToString
            'btnTimE1_Click(sender, e)
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

End Class

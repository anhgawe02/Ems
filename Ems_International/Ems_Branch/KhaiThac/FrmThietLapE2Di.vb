Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Diagnostics
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.IO.File
Imports System.Text
Public Class FrmThietLapE2Di
    Inherits System.Windows.Forms.Form
    'Sử dụng cột Cuoc_PPXD để nhập lệ phí hải quan
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
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnMoTui As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkInkhidongE2 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkTuiF As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkInE4 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkInBC37 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtThongTin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtInfor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbChuyenThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbTuiSoDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dgE1_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ddNuoc_Nhan As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_BC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddPhan_Loai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoai_Hang_Hoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ddTo_Hop_DV_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTo_Hop_DV_Cong_Them As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtDauMa As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtTrongluongTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBanE2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBanBC37 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents chk_Ngaynghi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents BtnTimE1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddLy_Do As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ddMa_BC_Tra As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents chkNhapLePhi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Kiem_Hoa As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btn_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Group_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Bo_Qua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Cap_Nhat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_Le_Phi_Khac As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_TV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_DV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_YT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_VH As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkCuocE1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkKienSo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dien_Thoai_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_VAT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_NK As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkSo_Bien_Lai As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkLe_Phi_HQ As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkSo_TKHQ As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkLoai_Hang_Hoa As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dia_Chi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dia_Chi_Gui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkBcChuyenHoan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Nguoi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Nguoi_Gui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkGhiChu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkCuocDV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkLy_Do_Hai_Quan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkNhap_Thong_Tin_Nguoi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkTong_Thue_Le_Phi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_Tieu_Thu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkE1UPUS10 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dv_Gia_Tang As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkDich_Vu_Cong_Them As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2Di", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Dv")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
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
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ChuyenThuDi", -1)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuisodi", -1)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F", 0)
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_BC", -1)
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_bc")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai_BP", -1)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai_BP")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai_BP")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai_BP")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai_BP")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Hang_Hoa", -1)
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmThietLapE2Di))
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TH_Ma_Dv_Gia_Tang", -1)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Ma")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dv_Cong_Them", -1)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Ly_Do")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Ly_Do")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Phan_Loai")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ghi_Chu")
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_Do_HQ", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ly_Do")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Ly_Do")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Ly_Do")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id_Phan_Loai")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ghi_Chu")
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.btnMoTui = New Infragistics.Win.Misc.UltraButton
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.chkInkhidongE2 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.chkTuiF = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.dgE1_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkInE4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkInBC37 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.txtThongTin = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtInfor = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbDuongThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbChuyenThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbTuiSoDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.ddMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_BC = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddPhan_Loai_BP = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLoai_BP = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLoai_Hang_Hoa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.chk_Ngaynghi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.ddTo_Hop_DV_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTo_Hop_DV_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.txtDauMa = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtTrongluongTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBanE2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBanBC37 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.BtnTimE1 = New Infragistics.Win.Misc.UltraButton
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddLy_Do = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.ddMa_BC_Tra = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.chkNhapLePhi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Kiem_Hoa = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btn_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.Group_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkTong_Thue_Le_Phi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_Tieu_Thu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLy_Do_Hai_Quan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btn_Bo_Qua = New Infragistics.Win.Misc.UltraButton
        Me.btn_Cap_Nhat = New Infragistics.Win.Misc.UltraButton
        Me.chk_Le_Phi_Khac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_TV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_DV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_YT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_VH = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkCuocE1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkKienSo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dien_Thoai_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_VAT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_NK = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkSo_Bien_Lai = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLe_Phi_HQ = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkSo_TKHQ = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLoai_Hang_Hoa = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dia_Chi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dia_Chi_Gui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkBcChuyenHoan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Nguoi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Nguoi_Gui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkGhiChu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkCuocDV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkNhap_Thong_Tin_Nguoi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkE1UPUS10 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dv_Gia_Tang = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkDich_Vu_Cong_Them = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTuiSoDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLoai_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLy_Do, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Thiet_Lap_Tham_So.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(128, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Đường T&hư"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(376, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Túi &Số"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(248, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 23)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "&Chuyến Thư"
        '
        'btnMoTui
        '
        Me.btnMoTui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoTui.Location = New System.Drawing.Point(496, 8)
        Me.btnMoTui.Name = "btnMoTui"
        Me.btnMoTui.Size = New System.Drawing.Size(72, 48)
        Me.btnMoTui.TabIndex = 8
        Me.btnMoTui.Text = "Mở E2"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(13, 32)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(99, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(13, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "&Ngày Đóng E2"
        '
        'chkInkhidongE2
        '
        Me.chkInkhidongE2.Location = New System.Drawing.Point(576, 8)
        Me.chkInkhidongE2.Name = "chkInkhidongE2"
        Me.chkInkhidongE2.Size = New System.Drawing.Size(104, 20)
        Me.chkInkhidongE2.TabIndex = 11
        Me.chkInkhidongE2.Text = "In Khi Đóng E2"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(752, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(32, 23)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Bản"
        '
        'chkTuiF
        '
        Me.chkTuiF.Location = New System.Drawing.Point(576, 56)
        Me.chkTuiF.Name = "chkTuiF"
        Me.chkTuiF.Size = New System.Drawing.Size(56, 20)
        Me.chkTuiF.TabIndex = 13
        Me.chkTuiF.Text = "Túi F"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 72)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(112, 15)
        Me.UltraLabel6.TabIndex = 9
        Me.UltraLabel6.Text = "Trọng Lượn&g Vỏ Túi"
        '
        'dgE1_Di
        '
        Me.dgE1_Di.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgE1_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Di.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 39
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Id E1"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "ID Đường Thư"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "ID_E2"
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "ID Ca"
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Caption = "Quầy"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Mã E1"
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.MaskInput = ""
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Width = 13
        UltraGridColumn10.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Caption = "Ngày Đóng"
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Giờ Đóng"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Ngày Nhận"
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Giờ Nhận"
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn17.Header.VisiblePosition = 15
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn18.Header.VisiblePosition = 16
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Nước Nhận"
        UltraGridColumn19.Header.VisiblePosition = 17
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Nước Trả"
        UltraGridColumn20.Header.VisiblePosition = 18
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Khối Lượng"
        UltraGridColumn21.Header.VisiblePosition = 19
        UltraGridColumn21.MaskInput = ""
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Width = 8
        UltraGridColumn22.Header.Caption = "Phân Loại"
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.Caption = "Khối Lượng QD"
        UltraGridColumn24.Header.VisiblePosition = 22
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.Caption = "Loại"
        UltraGridColumn25.Header.VisiblePosition = 23
        UltraGridColumn25.MaskInput = "9"
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(52, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Width = 100
        UltraGridColumn26.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn26.Header.VisiblePosition = 24
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn27.Header.VisiblePosition = 25
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn28.Header.VisiblePosition = 26
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "Cước PPXD"
        UltraGridColumn29.Header.VisiblePosition = 27
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.VisiblePosition = 28
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn31.Header.VisiblePosition = 29
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Thuế VAT"
        UltraGridColumn32.Header.VisiblePosition = 30
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Dv COD"
        UltraGridColumn33.Header.VisiblePosition = 31
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn34.Header.VisiblePosition = 32
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Cước COD"
        UltraGridColumn35.Header.VisiblePosition = 33
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.Caption = "Cước DV"
        UltraGridColumn36.Header.VisiblePosition = 34
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.Caption = "Cước Chính"
        UltraGridColumn37.Header.VisiblePosition = 35
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = "Cước Giảm"
        UltraGridColumn38.Header.VisiblePosition = 36
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.Caption = "Cước E1"
        UltraGridColumn39.Header.VisiblePosition = 37
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.DefaultCellValue = "0"
        UltraGridColumn40.Header.Caption = "Kiện Số"
        UltraGridColumn40.Header.VisiblePosition = 38
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.Caption = "Mã KH"
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.DefaultCellValue = ""
        UltraGridColumn42.Header.Caption = "Người Gửi"
        UltraGridColumn42.Header.VisiblePosition = 41
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.DefaultCellValue = ""
        UltraGridColumn43.Header.Caption = "Người Nhận"
        UltraGridColumn43.Header.VisiblePosition = 42
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.DefaultCellValue = ""
        UltraGridColumn44.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn44.Header.VisiblePosition = 43
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(314, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.DefaultCellValue = ""
        UltraGridColumn45.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(403, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.DefaultCellValue = ""
        UltraGridColumn46.Header.Caption = "ĐT Gửi"
        UltraGridColumn46.Header.VisiblePosition = 45
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.DefaultCellValue = ""
        UltraGridColumn47.Header.Caption = "ĐT Nhận"
        UltraGridColumn47.Header.VisiblePosition = 46
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Header.Caption = "HH Phát Hành"
        UltraGridColumn48.Header.VisiblePosition = 47
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "HH Phát Trả"
        UltraGridColumn49.Header.VisiblePosition = 48
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn50.Header.VisiblePosition = 49
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "ID Người Dùng"
        UltraGridColumn51.Header.VisiblePosition = 50
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "Lý do vào kho HQ"
        UltraGridColumn52.Header.VisiblePosition = 51
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.DefaultCellValue = ""
        UltraGridColumn53.Header.Caption = "Ghi Chú"
        UltraGridColumn53.Header.VisiblePosition = 52
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.DefaultCellValue = "0"
        UltraGridColumn54.Header.VisiblePosition = 53
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 54
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 55
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 56
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.Caption = "Lệ Phí HQ"
        UltraGridColumn58.Header.VisiblePosition = 57
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.Caption = "Thuế Nhập khẩu"
        UltraGridColumn59.Header.VisiblePosition = 58
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Header.Caption = "Thuế VAT"
        UltraGridColumn60.Header.VisiblePosition = 60
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Thuế NK+VAT"
        UltraGridColumn61.Header.VisiblePosition = 59
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.Caption = "Số TKHQ"
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.Caption = "Số Biên Lai"
        UltraGridColumn63.Header.VisiblePosition = 62
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.Caption = "Lệ Phí Văn Hóa"
        UltraGridColumn64.Header.VisiblePosition = 63
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.Caption = "Lệ Phí Y Tế"
        UltraGridColumn65.Header.VisiblePosition = 64
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.Caption = "Lệ Phí Dịch Vụ"
        UltraGridColumn66.Header.VisiblePosition = 65
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.Caption = "Lệ Phí Thực Vật"
        UltraGridColumn67.Header.VisiblePosition = 66
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.Caption = "Lệ Phí Khác"
        UltraGridColumn68.Header.VisiblePosition = 67
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.Header.Caption = "Tổng Thuế Lệ Phí"
        UltraGridColumn69.Header.VisiblePosition = 68
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgE1_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1_Di.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Di.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE1_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Di.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgE1_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE1_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Di.Location = New System.Drawing.Point(8, 208)
        Me.dgE1_Di.Name = "dgE1_Di"
        Me.dgE1_Di.Size = New System.Drawing.Size(856, 336)
        Me.dgE1_Di.TabIndex = 5
        Me.dgE1_Di.Text = "Danh sách E1 trong bản kê E2"
        '
        'chkInE4
        '
        Me.chkInE4.Location = New System.Drawing.Point(576, 32)
        Me.chkInE4.Name = "chkInE4"
        Me.chkInE4.Size = New System.Drawing.Size(96, 20)
        Me.chkInE4.TabIndex = 18
        Me.chkInE4.Text = "In E4"
        '
        'chkInBC37
        '
        Me.chkInBC37.Location = New System.Drawing.Point(640, 56)
        Me.chkInBC37.Name = "chkInBC37"
        Me.chkInBC37.Size = New System.Drawing.Size(64, 20)
        Me.chkInBC37.TabIndex = 19
        Me.chkInBC37.Text = "In BC37"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(752, 56)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(32, 23)
        Me.UltraLabel7.TabIndex = 21
        Me.UltraLabel7.Text = "Bản"
        '
        'txtThongTin
        '
        Me.txtThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThongTin.Location = New System.Drawing.Point(8, 128)
        Me.txtThongTin.Multiline = True
        Me.txtThongTin.Name = "txtThongTin"
        Me.txtThongTin.Size = New System.Drawing.Size(392, 72)
        Me.txtThongTin.TabIndex = 22
        '
        'txtInfor
        '
        Me.txtInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfor.Location = New System.Drawing.Point(528, 128)
        Me.txtInfor.Multiline = True
        Me.txtInfor.Name = "txtInfor"
        Me.txtInfor.Size = New System.Drawing.Size(192, 72)
        Me.txtInfor.TabIndex = 23
        '
        'cbDuongThuDi
        '
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn70.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn70.Header.VisiblePosition = 0
        UltraGridColumn71.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn71.Header.VisiblePosition = 1
        UltraGridColumn72.Header.VisiblePosition = 2
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn73.Header.VisiblePosition = 3
        UltraGridColumn73.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbDuongThuDi.DisplayMember = ""
        Me.cbDuongThuDi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi.Location = New System.Drawing.Point(128, 32)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(104, 21)
        Me.cbDuongThuDi.TabIndex = 3
        Me.cbDuongThuDi.ValueMember = ""
        '
        'cbChuyenThuDi
        '
        Me.cbChuyenThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn74.Header.Caption = "Số Chuyến Thư"
        UltraGridColumn74.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn74})
        UltraGridBand3.Header.Caption = "Chuyến Thư Đi"
        Me.cbChuyenThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbChuyenThuDi.DisplayMember = ""
        Me.cbChuyenThuDi.Location = New System.Drawing.Point(248, 32)
        Me.cbChuyenThuDi.Name = "cbChuyenThuDi"
        Me.cbChuyenThuDi.Size = New System.Drawing.Size(104, 21)
        Me.cbChuyenThuDi.TabIndex = 5
        Me.cbChuyenThuDi.ValueMember = ""
        '
        'cbTuiSoDi
        '
        Me.cbTuiSoDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn75.Header.Caption = "Túi Số"
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn76.Header.Caption = "Túi F"
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn76.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn75, UltraGridColumn76})
        Me.cbTuiSoDi.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cbTuiSoDi.DisplayMember = ""
        Me.cbTuiSoDi.Location = New System.Drawing.Point(376, 32)
        Me.cbTuiSoDi.Name = "cbTuiSoDi"
        Me.cbTuiSoDi.Size = New System.Drawing.Size(96, 21)
        Me.cbTuiSoDi.TabIndex = 7
        Me.cbTuiSoDi.ValueMember = ""
        '
        'ddMa_Nuoc
        '
        Me.ddMa_Nuoc.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridColumn77.Header.Caption = "Mã Nước"
        UltraGridColumn77.Header.VisiblePosition = 0
        UltraGridColumn78.Header.Caption = "Tên Nước"
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn77, UltraGridColumn78})
        Me.ddMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ddMa_Nuoc.DisplayMember = ""
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(56, 376)
        Me.ddMa_Nuoc.Name = "ddMa_Nuoc"
        Me.ddMa_Nuoc.Size = New System.Drawing.Size(224, 96)
        Me.ddMa_Nuoc.TabIndex = 26
        Me.ddMa_Nuoc.Text = "TenBc"
        Me.ddMa_Nuoc.ValueMember = ""
        Me.ddMa_Nuoc.Visible = False
        '
        'ddMa_BC
        '
        Me.ddMa_BC.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn79.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn79.Header.VisiblePosition = 0
        UltraGridColumn80.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80})
        Me.ddMa_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ddMa_BC.DisplayMember = ""
        Me.ddMa_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC.Location = New System.Drawing.Point(304, 360)
        Me.ddMa_BC.Name = "ddMa_BC"
        Me.ddMa_BC.Size = New System.Drawing.Size(208, 112)
        Me.ddMa_BC.TabIndex = 29
        Me.ddMa_BC.Text = "MaBc"
        Me.ddMa_BC.ValueMember = ""
        Me.ddMa_BC.Visible = False
        '
        'ddPhan_Loai_BP
        '
        UltraGridColumn81.Header.Caption = "Mã Loại BP"
        UltraGridColumn81.Header.VisiblePosition = 0
        UltraGridColumn82.Header.Caption = "Tên Loại BP"
        UltraGridColumn82.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn81, UltraGridColumn82})
        Me.ddPhan_Loai_BP.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.ddPhan_Loai_BP.DisplayMember = ""
        Me.ddPhan_Loai_BP.Location = New System.Drawing.Point(304, 248)
        Me.ddPhan_Loai_BP.Name = "ddPhan_Loai_BP"
        Me.ddPhan_Loai_BP.Size = New System.Drawing.Size(208, 112)
        Me.ddPhan_Loai_BP.TabIndex = 30
        Me.ddPhan_Loai_BP.Text = "UltraDropDown1"
        Me.ddPhan_Loai_BP.ValueMember = ""
        Me.ddPhan_Loai_BP.Visible = False
        '
        'ddLoai_BP
        '
        UltraGridColumn83.Header.VisiblePosition = 0
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn83, UltraGridColumn84})
        Me.ddLoai_BP.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.ddLoai_BP.DisplayMember = ""
        Me.ddLoai_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLoai_BP.Location = New System.Drawing.Point(560, 248)
        Me.ddLoai_BP.Name = "ddLoai_BP"
        Me.ddLoai_BP.Size = New System.Drawing.Size(112, 112)
        Me.ddLoai_BP.TabIndex = 32
        Me.ddLoai_BP.Text = "UltraDropDown1"
        Me.ddLoai_BP.ValueMember = ""
        Me.ddLoai_BP.Visible = False
        '
        'ddLoai_Hang_Hoa
        '
        UltraGridColumn85.Header.VisiblePosition = 0
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn86.Header.VisiblePosition = 1
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn85, UltraGridColumn86})
        Me.ddLoai_Hang_Hoa.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.ddLoai_Hang_Hoa.DisplayMember = ""
        Me.ddLoai_Hang_Hoa.Location = New System.Drawing.Point(56, 240)
        Me.ddLoai_Hang_Hoa.Name = "ddLoai_Hang_Hoa"
        Me.ddLoai_Hang_Hoa.Size = New System.Drawing.Size(120, 112)
        Me.ddLoai_Hang_Hoa.TabIndex = 33
        Me.ddLoai_Hang_Hoa.Text = "UltraDropDown1"
        Me.ddLoai_Hang_Hoa.ValueMember = ""
        Me.ddLoai_Hang_Hoa.Visible = False
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(200, 185)
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(880, 72)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(184, 185)
        Me.UltraExpandableGroupBox1.SupportThemes = False
        Me.UltraExpandableGroupBox1.TabIndex = 34
        Me.UltraExpandableGroupBox1.Text = "UltraExpandableGroupBox1"
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(178, 163)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'chk_Ngaynghi
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.chk_Ngaynghi.Appearance = Appearance7
        Me.chk_Ngaynghi.Location = New System.Drawing.Point(192, 96)
        Me.chk_Ngaynghi.Name = "chk_Ngaynghi"
        Me.chk_Ngaynghi.Size = New System.Drawing.Size(88, 16)
        Me.chk_Ngaynghi.TabIndex = 14
        Me.chk_Ngaynghi.Text = "Ngày nghỉ"
        Me.chk_Ngaynghi.Visible = False
        '
        'BtnExit
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.BtnExit.Appearance = Appearance8
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnExit.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExit.Location = New System.Drawing.Point(728, 128)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 72)
        Me.BtnExit.TabIndex = 86
        '
        'btnPrint
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.Image = CType(resources.GetObject("Appearance9.Image"), Object)
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnPrint.Appearance = Appearance9
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPrint.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(408, 168)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 32)
        Me.btnPrint.TabIndex = 85
        '
        'btnPreview
        '
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnPreview.Appearance = Appearance10
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(408, 128)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(48, 32)
        Me.btnPreview.TabIndex = 84
        '
        'mnuMenu
        '
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTimKiem})
        '
        'mnuTimKiem
        '
        Me.mnuTimKiem.Index = 0
        Me.mnuTimKiem.Text = "Tìm Kiếm"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 96)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel8.TabIndex = 12
        Me.UltraLabel8.Text = "Đầu m&ã"
        '
        'ddTo_Hop_DV_Gia_Tang
        '
        Me.ddTo_Hop_DV_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Default
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Appearance = Appearance11
        UltraGridColumn87.Header.Caption = "Tổ hợp mã dv"
        UltraGridColumn87.Header.VisiblePosition = 0
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn87})
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.ddTo_Hop_DV_Gia_Tang.DisplayMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Location = New System.Drawing.Point(336, 264)
        Me.ddTo_Hop_DV_Gia_Tang.Name = "ddTo_Hop_DV_Gia_Tang"
        Me.ddTo_Hop_DV_Gia_Tang.Size = New System.Drawing.Size(120, 96)
        Me.ddTo_Hop_DV_Gia_Tang.TabIndex = 89
        Me.ddTo_Hop_DV_Gia_Tang.ValueMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Visible = False
        '
        'ddTo_Hop_DV_Cong_Them
        '
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Appearance = Appearance13
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance14
        UltraGridColumn88.Header.Caption = "Mã dịch vụ"
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Width = 350
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn88})
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.ddTo_Hop_DV_Cong_Them.DisplayMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Location = New System.Drawing.Point(200, 256)
        Me.ddTo_Hop_DV_Cong_Them.Name = "ddTo_Hop_DV_Cong_Them"
        Me.ddTo_Hop_DV_Cong_Them.Size = New System.Drawing.Size(128, 112)
        Me.ddTo_Hop_DV_Cong_Them.TabIndex = 90
        Me.ddTo_Hop_DV_Cong_Them.ValueMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Visible = False
        '
        'txtDauMa
        '
        Me.txtDauMa.CausesValidation = False
        Me.txtDauMa.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtDauMa.InputMask = "EA"
        Me.txtDauMa.Location = New System.Drawing.Point(88, 96)
        Me.txtDauMa.Name = "txtDauMa"
        Me.txtDauMa.Size = New System.Drawing.Size(56, 20)
        Me.txtDauMa.TabIndex = 13
        Me.txtDauMa.Text = "EA"
        '
        'txtTrongluongTui
        '
        Me.txtTrongluongTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTrongluongTui.InputMask = "999"
        Me.txtTrongluongTui.Location = New System.Drawing.Point(128, 64)
        Me.txtTrongluongTui.Name = "txtTrongluongTui"
        Me.txtTrongluongTui.Size = New System.Drawing.Size(48, 20)
        Me.txtTrongluongTui.TabIndex = 10
        '
        'txtBanE2
        '
        Me.txtBanE2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBanE2.InputMask = "9"
        Me.txtBanE2.Location = New System.Drawing.Point(704, 8)
        Me.txtBanE2.Name = "txtBanE2"
        Me.txtBanE2.Size = New System.Drawing.Size(40, 20)
        Me.txtBanE2.TabIndex = 93
        '
        'txtBanBC37
        '
        Me.txtBanBC37.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBanBC37.InputMask = "9"
        Me.txtBanBC37.Location = New System.Drawing.Point(704, 56)
        Me.txtBanBC37.Name = "txtBanBC37"
        Me.txtBanBC37.Size = New System.Drawing.Size(40, 20)
        Me.txtBanBC37.TabIndex = 94
        '
        'BtnTimE1
        '
        Me.BtnTimE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTimE1.Location = New System.Drawing.Point(464, 128)
        Me.BtnTimE1.Name = "BtnTimE1"
        Me.BtnTimE1.Size = New System.Drawing.Size(56, 72)
        Me.BtnTimE1.TabIndex = 106
        Me.BtnTimE1.Text = "Tra &cứu"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        Me.UltraDataSource1.Band.Key = "LyDoHaiQuan"
        '
        'ddLy_Do
        '
        UltraGridColumn89.Header.Caption = "Mã"
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn90.Header.Caption = "Tên lý do"
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridColumn92.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92})
        Me.ddLy_Do.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.ddLy_Do.DisplayMember = "Id_Ly_Do"
        Me.ddLy_Do.Location = New System.Drawing.Point(536, 336)
        Me.ddLy_Do.Name = "ddLy_Do"
        Me.ddLy_Do.Size = New System.Drawing.Size(208, 112)
        Me.ddLy_Do.TabIndex = 108
        Me.ddLy_Do.Text = "Lý Do vào HQ"
        Me.ddLy_Do.ValueMember = "Id_Ly_Do"
        Me.ddLy_Do.Visible = False
        '
        'UltraDataSource2
        '
        UltraDataColumn5.DefaultValue = "0"
        UltraDataColumn6.DefaultValue = ""
        UltraDataColumn7.DefaultValue = "0"
        UltraDataColumn8.DefaultValue = ""
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        Me.UltraDataSource2.Band.Key = "Ly_Do_HQ"
        '
        'ddMa_BC_Tra
        '
        Me.ddMa_BC_Tra.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn93.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn93.Header.VisiblePosition = 0
        UltraGridColumn94.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn94.Header.VisiblePosition = 1
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn93, UltraGridColumn94})
        Me.ddMa_BC_Tra.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.ddMa_BC_Tra.DisplayMember = ""
        Me.ddMa_BC_Tra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC_Tra.Location = New System.Drawing.Point(291, 230)
        Me.ddMa_BC_Tra.Name = "ddMa_BC_Tra"
        Me.ddMa_BC_Tra.Size = New System.Drawing.Size(208, 112)
        Me.ddMa_BC_Tra.TabIndex = 109
        Me.ddMa_BC_Tra.Text = "MaBc"
        Me.ddMa_BC_Tra.ValueMember = ""
        Me.ddMa_BC_Tra.Visible = False
        '
        'chkNhapLePhi
        '
        Me.chkNhapLePhi.Location = New System.Drawing.Point(192, 72)
        Me.chkNhapLePhi.Name = "chkNhapLePhi"
        Me.chkNhapLePhi.Size = New System.Drawing.Size(112, 16)
        Me.chkNhapLePhi.TabIndex = 110
        Me.chkNhapLePhi.Text = "Nhập Lệ Phí HQ"
        '
        'chk_Kiem_Hoa
        '
        Me.chk_Kiem_Hoa.Location = New System.Drawing.Point(320, 96)
        Me.chk_Kiem_Hoa.Name = "chk_Kiem_Hoa"
        Me.chk_Kiem_Hoa.Size = New System.Drawing.Size(112, 16)
        Me.chk_Kiem_Hoa.TabIndex = 111
        Me.chk_Kiem_Hoa.Text = "Kiểm Hóa"
        Me.chk_Kiem_Hoa.Visible = False
        '
        'btn_Thiet_Lap_Tham_So
        '
        Me.btn_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(640, 95)
        Me.btn_Thiet_Lap_Tham_So.Name = "btn_Thiet_Lap_Tham_So"
        Me.btn_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(140, 25)
        Me.btn_Thiet_Lap_Tham_So.TabIndex = 127
        Me.btn_Thiet_Lap_Tham_So.Text = "Thiết Lập Tham Số"
        '
        'Group_Thiet_Lap_Tham_So
        '
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Dv_Gia_Tang)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkDich_Vu_Cong_Them)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkTong_Thue_Le_Phi)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkThue_Tieu_Thu)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkLy_Do_Hai_Quan)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Bo_Qua)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Cap_Nhat)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_Khac)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_YT)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_VH)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkCuocE1)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkKienSo)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Dien_Thoai_Nhan)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkThue_VAT)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkThue_NK)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkSo_Bien_Lai)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkLe_Phi_HQ)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkSo_TKHQ)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkLoai_Hang_Hoa)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Dia_Chi_Nhan)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Dia_Chi_Gui)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkBcChuyenHoan)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Nguoi_Nhan)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Nguoi_Gui)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkGhiChu)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkCuocDV)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_TV)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_DV)
        Me.Group_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(350, 120)
        Me.Group_Thiet_Lap_Tham_So.Name = "Group_Thiet_Lap_Tham_So"
        Me.Group_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(430, 300)
        Me.Group_Thiet_Lap_Tham_So.SupportThemes = False
        Me.Group_Thiet_Lap_Tham_So.TabIndex = 126
        Me.Group_Thiet_Lap_Tham_So.Text = "Thiết Lập Tham Số"
        '
        'chkTong_Thue_Le_Phi
        '
        Me.chkTong_Thue_Le_Phi.Location = New System.Drawing.Point(300, 232)
        Me.chkTong_Thue_Le_Phi.Name = "chkTong_Thue_Le_Phi"
        Me.chkTong_Thue_Le_Phi.TabIndex = 42
        Me.chkTong_Thue_Le_Phi.Text = "Tổng Thuế Lệ Phí"
        '
        'chkThue_Tieu_Thu
        '
        Me.chkThue_Tieu_Thu.Location = New System.Drawing.Point(300, 200)
        Me.chkThue_Tieu_Thu.Name = "chkThue_Tieu_Thu"
        Me.chkThue_Tieu_Thu.TabIndex = 41
        Me.chkThue_Tieu_Thu.Text = "Thuế Tiêu Thụ ĐB"
        '
        'chkLy_Do_Hai_Quan
        '
        Me.chkLy_Do_Hai_Quan.Location = New System.Drawing.Point(300, 170)
        Me.chkLy_Do_Hai_Quan.Name = "chkLy_Do_Hai_Quan"
        Me.chkLy_Do_Hai_Quan.TabIndex = 38
        Me.chkLy_Do_Hai_Quan.Text = "Lý Do Vào Kho HQ"
        '
        'btn_Bo_Qua
        '
        Me.btn_Bo_Qua.Location = New System.Drawing.Point(216, 264)
        Me.btn_Bo_Qua.Name = "btn_Bo_Qua"
        Me.btn_Bo_Qua.Size = New System.Drawing.Size(64, 32)
        Me.btn_Bo_Qua.TabIndex = 37
        Me.btn_Bo_Qua.Text = "Bỏ Qua"
        '
        'btn_Cap_Nhat
        '
        Me.btn_Cap_Nhat.Location = New System.Drawing.Point(104, 264)
        Me.btn_Cap_Nhat.Name = "btn_Cap_Nhat"
        Me.btn_Cap_Nhat.Size = New System.Drawing.Size(64, 32)
        Me.btn_Cap_Nhat.TabIndex = 36
        Me.btn_Cap_Nhat.Text = "Cập Nhật"
        '
        'chk_Le_Phi_Khac
        '
        Me.chk_Le_Phi_Khac.Location = New System.Drawing.Point(300, 140)
        Me.chk_Le_Phi_Khac.Name = "chk_Le_Phi_Khac"
        Me.chk_Le_Phi_Khac.TabIndex = 35
        Me.chk_Le_Phi_Khac.Text = "Lệ Phí Khác"
        '
        'chk_Le_Phi_TV
        '
        Me.chk_Le_Phi_TV.Location = New System.Drawing.Point(300, 110)
        Me.chk_Le_Phi_TV.Name = "chk_Le_Phi_TV"
        Me.chk_Le_Phi_TV.TabIndex = 34
        Me.chk_Le_Phi_TV.Text = "Lệ Phí Thực Vật"
        Me.chk_Le_Phi_TV.Visible = False
        '
        'chk_Le_Phi_DV
        '
        Me.chk_Le_Phi_DV.Location = New System.Drawing.Point(300, 80)
        Me.chk_Le_Phi_DV.Name = "chk_Le_Phi_DV"
        Me.chk_Le_Phi_DV.TabIndex = 33
        Me.chk_Le_Phi_DV.Text = "Lệ Phí Động Vật"
        Me.chk_Le_Phi_DV.Visible = False
        '
        'chk_Le_Phi_YT
        '
        Me.chk_Le_Phi_YT.Location = New System.Drawing.Point(300, 112)
        Me.chk_Le_Phi_YT.Name = "chk_Le_Phi_YT"
        Me.chk_Le_Phi_YT.TabIndex = 32
        Me.chk_Le_Phi_YT.Text = "Lệ Phí Y Tế"
        '
        'chk_Le_Phi_VH
        '
        Me.chk_Le_Phi_VH.Location = New System.Drawing.Point(300, 80)
        Me.chk_Le_Phi_VH.Name = "chk_Le_Phi_VH"
        Me.chk_Le_Phi_VH.TabIndex = 31
        Me.chk_Le_Phi_VH.Text = "Lệ Phí Văn Hóa"
        '
        'chkCuocE1
        '
        Me.chkCuocE1.Location = New System.Drawing.Point(20, 20)
        Me.chkCuocE1.Name = "chkCuocE1"
        Me.chkCuocE1.TabIndex = 2
        Me.chkCuocE1.Text = "Cước E1"
        '
        'chkKienSo
        '
        Me.chkKienSo.Location = New System.Drawing.Point(160, 200)
        Me.chkKienSo.Name = "chkKienSo"
        Me.chkKienSo.Size = New System.Drawing.Size(112, 20)
        Me.chkKienSo.TabIndex = 1
        Me.chkKienSo.Text = "Kiện số"
        '
        'chk_Dien_Thoai_Nhan
        '
        Me.chk_Dien_Thoai_Nhan.Location = New System.Drawing.Point(20, 110)
        Me.chk_Dien_Thoai_Nhan.Name = "chk_Dien_Thoai_Nhan"
        Me.chk_Dien_Thoai_Nhan.TabIndex = 30
        Me.chk_Dien_Thoai_Nhan.Text = "Điện Thoại Nhận"
        '
        'chkThue_VAT
        '
        Me.chkThue_VAT.Location = New System.Drawing.Point(160, 50)
        Me.chkThue_VAT.Name = "chkThue_VAT"
        Me.chkThue_VAT.TabIndex = 29
        Me.chkThue_VAT.Text = "Thuế  VAT"
        '
        'chkThue_NK
        '
        Me.chkThue_NK.Location = New System.Drawing.Point(160, 20)
        Me.chkThue_NK.Name = "chkThue_NK"
        Me.chkThue_NK.TabIndex = 28
        Me.chkThue_NK.Text = "Thuế NK"
        '
        'chkSo_Bien_Lai
        '
        Me.chkSo_Bien_Lai.Location = New System.Drawing.Point(160, 140)
        Me.chkSo_Bien_Lai.Name = "chkSo_Bien_Lai"
        Me.chkSo_Bien_Lai.TabIndex = 27
        Me.chkSo_Bien_Lai.Text = "Số Biên Lai"
        '
        'chkLe_Phi_HQ
        '
        Me.chkLe_Phi_HQ.Location = New System.Drawing.Point(20, 230)
        Me.chkLe_Phi_HQ.Name = "chkLe_Phi_HQ"
        Me.chkLe_Phi_HQ.TabIndex = 26
        Me.chkLe_Phi_HQ.Text = "Lệ Phí HQ"
        '
        'chkSo_TKHQ
        '
        Me.chkSo_TKHQ.Location = New System.Drawing.Point(160, 80)
        Me.chkSo_TKHQ.Name = "chkSo_TKHQ"
        Me.chkSo_TKHQ.TabIndex = 25
        Me.chkSo_TKHQ.Text = "Số TKHQ"
        '
        'chkLoai_Hang_Hoa
        '
        Me.chkLoai_Hang_Hoa.Location = New System.Drawing.Point(160, 170)
        Me.chkLoai_Hang_Hoa.Name = "chkLoai_Hang_Hoa"
        Me.chkLoai_Hang_Hoa.TabIndex = 18
        Me.chkLoai_Hang_Hoa.Text = "Loại Hàng Hóa"
        '
        'chk_Dia_Chi_Nhan
        '
        Me.chk_Dia_Chi_Nhan.Location = New System.Drawing.Point(20, 80)
        Me.chk_Dia_Chi_Nhan.Name = "chk_Dia_Chi_Nhan"
        Me.chk_Dia_Chi_Nhan.TabIndex = 17
        Me.chk_Dia_Chi_Nhan.Text = "Địa Chỉ Nhận"
        '
        'chk_Dia_Chi_Gui
        '
        Me.chk_Dia_Chi_Gui.Location = New System.Drawing.Point(20, 170)
        Me.chk_Dia_Chi_Gui.Name = "chk_Dia_Chi_Gui"
        Me.chk_Dia_Chi_Gui.TabIndex = 16
        Me.chk_Dia_Chi_Gui.Text = "Địa Chỉ Gửi"
        '
        'chkBcChuyenHoan
        '
        Me.chkBcChuyenHoan.Location = New System.Drawing.Point(160, 110)
        Me.chkBcChuyenHoan.Name = "chkBcChuyenHoan"
        Me.chkBcChuyenHoan.Size = New System.Drawing.Size(128, 20)
        Me.chkBcChuyenHoan.TabIndex = 0
        Me.chkBcChuyenHoan.Text = "BC Chuyển Hoàn"
        '
        'chk_Nguoi_Nhan
        '
        Me.chk_Nguoi_Nhan.Location = New System.Drawing.Point(20, 50)
        Me.chk_Nguoi_Nhan.Name = "chk_Nguoi_Nhan"
        Me.chk_Nguoi_Nhan.TabIndex = 15
        Me.chk_Nguoi_Nhan.Text = "Người Nhận"
        '
        'chk_Nguoi_Gui
        '
        Me.chk_Nguoi_Gui.Location = New System.Drawing.Point(20, 140)
        Me.chk_Nguoi_Gui.Name = "chk_Nguoi_Gui"
        Me.chk_Nguoi_Gui.TabIndex = 14
        Me.chk_Nguoi_Gui.Text = "Người Gửi"
        '
        'chkGhiChu
        '
        Me.chkGhiChu.Location = New System.Drawing.Point(20, 200)
        Me.chkGhiChu.Name = "chkGhiChu"
        Me.chkGhiChu.Size = New System.Drawing.Size(112, 20)
        Me.chkGhiChu.TabIndex = 6
        Me.chkGhiChu.Text = "Ghi Chú"
        '
        'chkCuocDV
        '
        Me.chkCuocDV.Location = New System.Drawing.Point(160, 230)
        Me.chkCuocDV.Name = "chkCuocDV"
        Me.chkCuocDV.Size = New System.Drawing.Size(112, 20)
        Me.chkCuocDV.TabIndex = 5
        Me.chkCuocDV.Text = "Cước DV"
        '
        'chkNhap_Thong_Tin_Nguoi_Nhan
        '
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Location = New System.Drawing.Point(320, 72)
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Name = "chkNhap_Thong_Tin_Nguoi_Nhan"
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Size = New System.Drawing.Size(168, 16)
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.TabIndex = 128
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Text = "Nhập thông tin người nhận"
        '
        'chkE1UPUS10
        '
        Me.chkE1UPUS10.Checked = True
        Me.chkE1UPUS10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkE1UPUS10.Location = New System.Drawing.Point(672, 32)
        Me.chkE1UPUS10.Name = "chkE1UPUS10"
        Me.chkE1UPUS10.Size = New System.Drawing.Size(72, 20)
        Me.chkE1UPUS10.TabIndex = 138
        Me.chkE1UPUS10.Text = "Check E1"
        '
        'chk_Dv_Gia_Tang
        '
        Me.chk_Dv_Gia_Tang.Location = New System.Drawing.Point(304, 56)
        Me.chk_Dv_Gia_Tang.Name = "chk_Dv_Gia_Tang"
        Me.chk_Dv_Gia_Tang.TabIndex = 44
        Me.chk_Dv_Gia_Tang.Text = "Dịch vụ đặc biệt"
        '
        'chkDich_Vu_Cong_Them
        '
        Me.chkDich_Vu_Cong_Them.Location = New System.Drawing.Point(304, 24)
        Me.chkDich_Vu_Cong_Them.Name = "chkDich_Vu_Cong_Them"
        Me.chkDich_Vu_Cong_Them.TabIndex = 43
        Me.chkDich_Vu_Cong_Them.Text = "Dịch vụ cộng thêm"
        '
        'FrmThietLapE2Di
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 566)
        Me.Controls.Add(Me.chkE1UPUS10)
        Me.Controls.Add(Me.chkNhap_Thong_Tin_Nguoi_Nhan)
        Me.Controls.Add(Me.btn_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.Group_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.chk_Kiem_Hoa)
        Me.Controls.Add(Me.chkNhapLePhi)
        Me.Controls.Add(Me.ddMa_BC_Tra)
        Me.Controls.Add(Me.ddLy_Do)
        Me.Controls.Add(Me.BtnTimE1)
        Me.Controls.Add(Me.txtBanBC37)
        Me.Controls.Add(Me.txtBanE2)
        Me.Controls.Add(Me.txtTrongluongTui)
        Me.Controls.Add(Me.txtDauMa)
        Me.Controls.Add(Me.ddTo_Hop_DV_Cong_Them)
        Me.Controls.Add(Me.ddTo_Hop_DV_Gia_Tang)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.ddLoai_Hang_Hoa)
        Me.Controls.Add(Me.ddLoai_BP)
        Me.Controls.Add(Me.ddPhan_Loai_BP)
        Me.Controls.Add(Me.ddMa_BC)
        Me.Controls.Add(Me.ddMa_Nuoc)
        Me.Controls.Add(Me.cbTuiSoDi)
        Me.Controls.Add(Me.cbChuyenThuDi)
        Me.Controls.Add(Me.cbDuongThuDi)
        Me.Controls.Add(Me.txtInfor)
        Me.Controls.Add(Me.txtThongTin)
        Me.Controls.Add(Me.dgE1_Di)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.chkTuiF)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cbNgayDong)
        Me.Controls.Add(Me.btnMoTui)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.chkInE4)
        Me.Controls.Add(Me.chkInkhidongE2)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.chkInBC37)
        Me.Controls.Add(Me.chk_Ngaynghi)
        Me.Name = "FrmThietLapE2Di"
        Me.Text = "Thiết Lập bản kê E2 đóng đi"
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTuiSoDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLoai_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLy_Do, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Thiet_Lap_Tham_So.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "====================Khai báo biến===================="
    'Thong so chung
    Dim IsOpenBag As Boolean 'Xác định túi có được mở ra không
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim FrmSearch As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myKeys As New ModifyRegistry

    Dim myDichVu As New Dich_Vu(GConnectionString)
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    Dim myMaNuoc As New Ma_Nuoc(GConnectionString)
    Dim myMaBc As New Danh_Muc_BC(GConnectionString)
    Dim myMaTinh As New Ma_Tinh(GConnectionString)
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
    Dim myTrang_Thai_Chi_Tiet As New Trang_Thai_Chi_Tiet
    Dim myTrang_Thai As New Trang_Thai(GConnectionString)
    Dim myCODDi As New COD_Di(GConnectionString)

    Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
    Dim myTinh_Cuoc_Chi_Tiet As Tinh_Cuoc_Chi_Tiet
    Dim myId_Nguoi_Dung As Integer
    Dim myId_Ca As String
    Dim myId_Trang_Thai As String
    
    Dim myE1_Le_Phi_Den As New E1_Le_Phi_Den(GConnectionString)
    Dim myE1_Le_Phi_Di As New E1_Le_Phi_Di(GConnectionString)
    Dim myE1_Le_Phi_Den_Tam As New E1_Le_Phi_Den_Tam(GConnectionString)

    Dim myIn_E2_TEXT As New In_E2_TEXT
    Dim myIn_BC37_To_Text As New In_BC37_To_Text

    'Dim myDuLieuTam As DataTable
    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myPredes As New Predes(GConnectionString)
    Dim myEDI_mailbox As New EDI_mailbox(GConnectionString)
    'Tìm kiếm dữ liệu xác nhận
    Dim myE1_Den As New E1_Den(GConnectionString)

    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet

    Dim myMa_Nuoc_Di As String
    Dim myId_Duong_Thu As String
    Dim myLoai_Chuyen_Thu As String
    Dim myId_Chuyen_Thu As String
    Dim myId_E2 As String

    Dim myMa_Bc As Integer
    Dim mySo_Chuyen_Thu_Di As Integer
    Dim myTui_So_Di As Integer

    Dim mySo_Chuyen_Thu_Di_Lon_Nhat As Integer
    Dim myTui_So_Di_Lon_Nhat As Integer
    Dim myMax_DongF As Boolean
    Dim myTongso As Integer
    Dim myTongKhoiLuongBP As Integer

    Dim myE2_Date As Integer
    Dim myE2_Time As Integer
    Dim myStart_Date As Integer
    Dim myEnd_Date As Integer

    'Sử dụng trong đường thư lưu kho
    Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)
    Dim myE2_Den_Tam As New E2_Den_Tam(GConnectionString)
    Dim myChuyen_Thu_Den_Tam As New Chuyen_Thu_Den_Tam(GConnectionString)
    Dim myId_Duong_Thu_Luu_Kho As String
    Dim myId_Chuyen_Thu_Luu_Kho As String
    Dim myId_E2_Luu_Kho As String
    Dim myId_E1_Luu_Kho As String

    'Lấy thông tin trùng số liệu, số liệu truyền đến
    Dim myE1_Di_Chi_Tiet_Trung As New E1_Di_Chi_Tiet
    Dim myE1_Le_Phi_Di_Chi_Tiet_Trung As New E1_Le_Phi_Di_Chi_Tiet
    Dim myE1_Den_Chi_Tiet_XN As New E1_Den_Chi_Tiet 'Dữ liệu xác nhận đến
    Dim myE1_Den_Chi_Tiet_XN_Trung As New E1_Den_Chi_Tiet 'Dữ liệu xác nhận đến

    'Biến kiểm tra trùng số liệu, số liệu xác nhận đến
    Dim myIsTrungSoLieu As Boolean
    Dim myIsChoPhepTrung As Boolean
    Dim myMAE1Thoat As Boolean
    Dim myIsXacNhanDen As Boolean
    Dim myIsDaKiemTraTrung As Boolean

    'Kiểm tra lạc hướng
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myMa_Nuoc_Theo_Duong_Thu As String
    Dim myMa_Tinh_Theo_Duong_Thu As String

    'Quản lý xuất nhập kho D
    Dim myE1_Nhap_Kho_D As New E1_Nhap_Kho_D(GConnectionString)
    Dim myE1_Nhap_Kho_D_Chi_Tiet As New E1_Nhap_Kho_D_Chi_Tiet

    Dim myLastColumnKey As String 'AddNewTemplateRow
    Dim myColumnInputData As String
    'Ghi Log_Event
    Dim myLog_Id As Integer
#End Region

#Region "====================Control Form===================="
#Region "--------------------FrmThietLapE2Di_Load--------------------"
    Private Sub FrmThietLapE2Di_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DesignForm()
        If GUserAdmin = True Then
            chkE1UPUS10.Visible = True
        Else
            chkE1UPUS10.Visible = False
        End If
        GetKeys()

        Thiet_Lap_Tham_So()

        Load_Data()

        Init_Form()

        Validate_Commbo()

        SetLastColumnVisibleKey(dgE1_Di)

        DataGrid_Nhap_E1_Di(0) 'Lấy dữ liệu trống

        cbNgayDong.Select()
    End Sub
#End Region

#Region "--------------------DesignForm--------------------"
    Private Sub DesignForm()
        txtThongTin.Enabled = True
        txtThongTin.ReadOnly = True
        txtThongTin.FlatMode = True
        txtThongTin.BackColor = Color.White
        txtThongTin.ForeColor = Color.Black
        'txtInfor
        txtInfor.Enabled = True
        txtInfor.ReadOnly = True
        txtInfor.FlatMode = True
        txtInfor.BackColor = Color.White
        txtInfor.ForeColor = Color.Black
    End Sub
#End Region

#Region "--------------------GetKeys--------------------"
    Private Sub GetKeys()
        GMa_Dau_So = SetNullValue(myKeys.Doc("DauMa"), "EE")
        txtDauMa.Text = SetNullValue(myKeys.Doc("DauMa"), "EE")

        txtBanE2.Text = CInt(SetNullValue(myKeys.Doc("SoBanE2Di"), "0"))
        txtBanBC37.Text = CInt(SetNullValue(myKeys.Doc("SoBanBC37Di"), "0"))
        txtTrongluongTui.Text = CInt(SetNullValue(myKeys.Doc("TrongLuongTuiDi"), "0"))
        chkInkhidongE2.Checked = CBool(SetNullValue(myKeys.Doc("InKhiDongE2Di"), "False"))
        chkInE4.Checked = CBool(SetNullValue(myKeys.Doc("InE4"), "False"))
        chkInBC37.Checked = CBool(SetNullValue(myKeys.Doc("InBC37DiKhiDongF"), "False"))
    End Sub
#End Region

#Region "--------------------Thiet_Lap_Tham_So-----------------------"
    Private Sub Thiet_Lap_Tham_So()
        dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_E1").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Cuoc_E1"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Nguoi_Nhan"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dia_Chi_Nhan"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dien_Thoai_Nhan"), "False"))
        'dgE1_Di.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = True
        dgE1_Di.DisplayLayout.Bands(0).Columns("Nguoi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Nguoi_Gui"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dia_Chi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dia_Chi_Gui"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Ghi_Chu").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ghi_Chu"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_HQ"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_NK"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_VAT"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_So_TKHQ"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_So_Bien_Lai"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Loai_Hang_Hoa"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ma_Bc_CH"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_Dv").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Cuoc_Dv"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Kien_So").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Kien_So"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_VH").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_VH"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_YT").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_YT"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_DV").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_DV"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_TV").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_TV"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Le_Phi_Khac").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_Khac"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Id_Trang_Thai").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ly_Do_Vao_Kho_HQ"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dv_Cong_Them").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dv_Cong_Them"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dv_Gia_Tang").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dv_Gia_Tang"), "False"))
        'dgE1_Den.DisplayLayout.Bands(0).Columns("Thue_Tieu_Thu").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_Tieu_Thu"), "False"))
        dgE1_Di.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Tong_Thue_Le_Phi"), "False"))
    End Sub
#End Region

#Region "--------------------Load_Data--------------------"
    Private Sub Load_Data()
        Tao_Bang_Phan_Loai_BP()
        Tao_Bang_Loai_Hang_Hoa()
        Tao_Bang_Loai_BP()
        To_Hop_Ma_DV_Cong_Them()
        'To_Hop_Ma_DV_Gia_Tang()
        ddMa_Nuoc.DataSource = myMaNuoc.Danh_Sach_Rut_Gon()
        ddMa_Nuoc.DataBind()
        ddMa_BC.DataSource = myMaBc.Danh_Sach_Rut_Gon.Tables(0)
        ddMa_BC.DataBind()
        ddMa_BC_Tra.DataSource = myMaTinh.Danh_Sach_Rut_Gon.Tables(0) 'myMaBc.Danh_Sach_Rut_Gon_KT.Tables(0)
        ddMa_BC_Tra.DataBind()
        'Them phan xu ly trang thai khi dong vao kho hai Quan - Id_Phan_Loai = 8
        'Load du lieu cho ddLy_Do
        ddLy_Do_Load_Data()
    End Sub

#Region "-----------------------Tạo bảng Phân loại bưu phẩm-----------------------"
    Private Sub Tao_Bang_Phan_Loai_BP()
        Dim dataTable As New dataTable("Phan_Loai_BP")

        Dim colWork As DataColumn = New DataColumn("Ma_Phan_Loai_BP", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Phan_Loai_BP", GetType(String))
        dataTable.Columns.Add(colWork)

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

#Region "-----------------------Tạo bảng Loại bưu phẩm-----------------------"
    Private Sub Tao_Bang_Loai_BP()
        Dim dataTable As New dataTable("Loai_BP")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai_BP", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai_BP", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai_BP") = 0
        row("Ten_Loai_BP") = "EMS"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai_BP") = 1
        row("Ten_Loai_BP") = "Sự vụ"
        dataTable.Rows.Add(row)

        'row = dataTable.NewRow
        'row("Ma_Loai_BP") = 2
        'row("Ten_Loai_BP") = "Thỏa Thuận"
        'dataTable.Rows.Add(row)

        ddLoai_BP.DataSource = dataTable
        ddLoai_BP.DataBind()
        ddLoai_BP.DisplayMember = "Ten_Loai_BP"
        ddLoai_BP.ValueMember = "Ma_Loai_BP"
    End Sub
#End Region

#Region "-----------------------Tạo bảng Loại Hàng Hóa-----------------------"
    Private Sub Tao_Bang_Loai_Hang_Hoa()
        Dim dataTable As New dataTable("Loai_Hang_Hoa")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai") = 0
        row("Ten_Loai") = "EMS"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = 1
        row("Ten_Loai") = "Hàng Nhẹ"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = 2
        row("Ten_Loai") = "Hàng cồng kềnh"
        dataTable.Rows.Add(row)

        ddLoai_Hang_Hoa.DataSource = dataTable
        ddLoai_Hang_Hoa.DataBind()
    End Sub
#End Region

#Region "-----------------------Tạo bảng To_Hop_Ma_DV_Cong_Them-----------------------"
    Private Sub To_Hop_Ma_DV_Cong_Them()
        ddTo_Hop_DV_Cong_Them.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(0)
        ddTo_Hop_DV_Cong_Them.DataBind()
    End Sub
#End Region

#Region "-----------------------Tạo bảng To_Hop_Ma_DV_Gia_Tang-----------------------"
    Private Sub To_Hop_Ma_DV_Gia_Tang()
        ddTo_Hop_DV_Gia_Tang.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(1)
        ddTo_Hop_DV_Gia_Tang.DataBind()
    End Sub
#End Region

#Region "-----------------------Load data into ddLy_Do-----------------------"
    Private Sub ddLy_Do_Load_Data()
        Dim myLyDo As New Ly_Do_Vao_Kho_HQ(GConnectionString)
        ddLy_Do.DataSource = myLyDo.Ly_Do_Vao_Kho_HQ_Danh_Sach.Tables(0)
        ddLy_Do.DataBind()
    End Sub
#End Region
#End Region

#Region "---------------------Init_Form------------------------"
    Private Function Init_Form() As Boolean
        Group_Thiet_Lap_Tham_So.Visible = False

        Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
        myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Ca_Hien_Tai(GBuu_Cuc_Khai_Thac)
        Text = "Thiết Lập Bản Kê E2 đóng đi. Bưu cục khai thác:" & GBuu_Cuc_Khai_Thac & "-" & GTen_Buu_Cuc_Khai_Thac & "-Ca hiện tại là ca: " & myCa_San_Xuat_Chi_Tiet.Thu_Tu & "- " & myHam_Dung_Chung.ConvertIntToDate_VN(CInt(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac))

        txtThongTin.Text = "Thiết lập bản kê E2 đóng đi tại: " & GBuu_Cuc_Khai_Thac & "(" & GTen_Buu_Cuc_Khai_Thac & ")"
        txtInfor.Text = "Tổng số     : 0" & vbNewLine & "Khối lượng : 0"

        chkTuiF.Checked = False
        chkInBC37.Enabled = False

        chkNhapLePhi.Checked = False
        chk_Kiem_Hoa.Checked = False

        dgE1_Di.DisplayLayout.Bands(0).Columns("Id_Trang_Thai").Hidden = True
        chk_Ngaynghi.Checked = False

        chkCuocDV.Visible = False

        cbNgayDong.DateTime = Today

        'Danh sách đường thư
        cbDuongThuDi.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_KT(GBuu_Cuc_Khai_Thac)
        If cbDuongThuDi.Rows.Count > 0 Then
            cbDuongThuDi.Value = cbDuongThuDi.Rows(0).Cells("Ma_Bc").Value
        Else
            MessageBox.Show("Không tồn tại đường thư nào trong bưu cục khai thác này!!!" & vbNewLine & _
                            "     Bạn hãy liên hệ với người quản trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Dispose()
            Exit Function
        End If
        cbDuongThuDi.DataBind()
        cbDuongThuDi.LimitToList = True

        IsOpenBag = False
        Enable_Control(False)

        SetColumnInputData(dgE1_Di)
    End Function
#End Region

#Region "--------------------Enable_Control--------------------"
    Private Sub Enable_Control(ByVal OpenBag As Boolean)
        'txtInfor.Enabled = False
        'txtThongTin.Enabled = False
        cbNgayDong.Enabled = Not OpenBag
        cbDuongThuDi.Enabled = Not OpenBag
        cbChuyenThuDi.Enabled = Not OpenBag
        cbTuiSoDi.Enabled = Not OpenBag
        txtBanE2.Enabled = chkInkhidongE2.Checked
        txtBanBC37.Enabled = chkInBC37.Checked
        btnPreview.Enabled = Not OpenBag
        btnPrint.Enabled = Not OpenBag
        If OpenBag = True Then
            dgE1_Di.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            dgE1_Di.DisplayLayout.Override.BorderStyleTemplateAddRow = UIElementBorderStyle.Inset
        Else
            dgE1_Di.DisplayLayout.Override.ResetAllowAddNew()
        End If

        btnMoTui.Text = IIf(Not OpenBag, "Mở &Túi", "Đóng &Túi")
        dgE1_Di.Enabled = OpenBag

        If GUserAdmin Then 'Nếu là quản trị tuyệt đối
            dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
        Else
            If gSua_Cuoc_Chinh = True Then
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            Else
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_DV = True Then
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            Else
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_E1 = True Then
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
            Else
                dgE1_Di.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.NoEdit
            End If
        End If
        'Không cho phép chỉnh sửa cột tổng thuế lệ phí
        dgE1_Di.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").CellActivation = Activation.NoEdit
        'Không cho phép tự động điền thêm ký tự phía sau nếu có
        cbChuyenThuDi.AutoEdit = False
        cbTuiSoDi.AutoEdit = False
    End Sub
#End Region

#Region "---------------------Validate_Commbo------------------------"
    Private Sub Validate_Commbo()
        myTongso = 0
        myTongKhoiLuongBP = 0

        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Today)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)

        Dim myDataTable As DataTable
        'Lấy thông tin đường thư chi tiết
        myDataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value))
        myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
        myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
        myDuong_Thu_Di_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
        myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
        myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
        myId_Duong_Thu = myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
        myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = myDataTable.Rows(0)("Duoc_Truyen")
        myDuong_Thu_Di_Chi_Tiet.Su_Dung = myDataTable.Rows(0)("Su_Dung")
        myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = myDataTable.Rows(0)("Chuyen_Tiep")

        Select Case myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai
            Case 0, 1
                'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                myStart_Date = (myE2_Date \ 100) * 100
                myEnd_Date = (myE2_Date \ 100) * 100 + 99
            Case 2, 3, 4, 5, 6, 7, 8
                'Đường Thư Liên Tỉnh,Liền kề, Quốc tê, Lưu kho(QT Đến, QT Đi), Chuyển tiếp: Chuyến Thư tăng theo Năm
                myStart_Date = (myE2_Date \ 10000) * 10000
                myEnd_Date = (myE2_Date \ 10000) * 10000 + 9999
            Case Else
                MessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        myLoai_Chuyen_Thu = "EN"
        mySo_Chuyen_Thu_Di_Lon_Nhat = myChuyen_Thu_Di.Tim_So_Chuyen_Thu_Di_Lon_Nhat(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)

        'Xu ly tang chuyen thu khi het 1 ca khai thac ma nguoi dung khong dong F
        'Sang ca khai thac tiep theo tu dong tang chuyen thu - tranh dong 1 chuyen thu nhieu ngay khac nhau
        Dim Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Dim isQuaNgay As Boolean
        Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu)
        If Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet.Id_Ca <> GId_Ca Then
            isQuaNgay = True
        Else
            isQuaNgay = False
        End If

        'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi, Loại chuyến thư
        cbChuyenThuDi.DataSource = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Boi_Duong_Thu_Di_Ngay_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
        If mySo_Chuyen_Thu_Di_Lon_Nhat > 0 Then
            If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False And isQuaNgay = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                cbChuyenThuDi.Value = mySo_Chuyen_Thu_Di_Lon_Nhat
            Else
                cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
            End If
        Else
            cbChuyenThuDi.Text = 1
        End If

        'Them phan xu ly vao kho hai quan 100907
        If myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8 Then   'La kho hai quan
            Hide_Cotrol_LyDo(False)
            cbDuongThuDi.Tag = True    'Luu gia tri de can cu SetDefaultValue cho Id_Trang_Thai
        Else   'Cac truong hop con lai
            Hide_Cotrol_LyDo(True)
            cbDuongThuDi.Tag = False   'Luu gia tri de can cu SetDefaultValue cho Id_Trang_Thai
        End If

        myMa_Nuoc_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Nc
        myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Tinh

        mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
        cbTuiSoDi.Text = ""
        cbTuiSoDi.LimitToList = False
        myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di, myLoai_Chuyen_Thu)
        If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then  'Nếu tồn tại chuyến thư
            myId_Chuyen_Thu = myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
            myTui_So_Di_Lon_Nhat = myE2_Di.Tim_So_Tui_Di_Lon_Nhat(myId_Chuyen_Thu)
            cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(myId_Chuyen_Thu)
            If myE2_Di.IsExist_E2_Di(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = True Then   'Kiểm tra xem túi 1 có tồn tại không
                If myE2_Di.Xac_dinh_Tui_Di_F(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = False Then 'Kiểm tra túi max đã đóng F chưa
                    cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat + 1
                Else
                    MessageBox.Show("Chuyến thư này đã đóng túi F", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat
                    cbTuiSoDi.Value = cbTuiSoDi.Rows(0).Cells("Tui_So").Value
                    cbTuiSoDi.LimitToList = True
                End If
            Else
                myTui_So_Di_Lon_Nhat = 0
                cbTuiSoDi.Text = 1
            End If
        Else
            cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(0)
            cbTuiSoDi.Text = 1
        End If

        myTui_So_Di = CInt(cbTuiSoDi.Text)

        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) _
                            & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                            & "Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di) & " - Túi Số: " & myTui_So_Di
    End Sub
#End Region

#Region "--------------------FrmThietLapE2Di_Closing--------------------"
    Private Sub FrmThietLapE2Di_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        chk_Ngaynghi.Checked = False
        SetKeys()
        If IsOpenBag Then
            DongTui()
        End If
    End Sub
#End Region

#Region "--------------------SetKeys--------------------"
    Private Sub SetKeys()
        myKeys.Ghi("SoBanE2Di", txtBanE2.Text)
        myKeys.Ghi("SoBanBC37Di", txtBanBC37.Text)
        myKeys.Ghi("DauMa", txtDauMa.Text)
        myKeys.Ghi("TrongLuongTuiDi", IIf(txtTrongluongTui.Text <> "", txtTrongluongTui.Text, 0))
        myKeys.Ghi("InKhiDongE2Di", chkInkhidongE2.Checked)
        myKeys.Ghi("InE4", chkInE4.Checked)
        myKeys.Ghi("InBC37DiKhiDongF", chkInBC37.Checked)
    End Sub
#End Region

#Region "--------------------txtDauMa_Leave--------------------"
    Private Sub txtDauMa_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDauMa.Leave
        If (txtDauMa.Text = "") Or (txtDauMa.Text = "E") Then
            txtDauMa.Text = "EE"
        End If
        If IsNumeric(txtDauMa.Text.Substring(1, 1)) Then
            txtDauMa.Text = "EE"
        End If
        txtDauMa.Text = txtDauMa.Text.ToUpper
        GMa_Dau_So = txtDauMa.Text
    End Sub
#End Region

#Region "--------------------FrmThietLapE2Di_KeyPress--------------------"
    Private Sub FrmThietLapE2Di_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "--------------------Check Box--------------------"
#Region "--------------------chkInkhidongE2_CheckedChanged--------------------"
    Private Sub chkInkhidongE2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInkhidongE2.CheckedChanged
        txtBanE2.Enabled = chkInkhidongE2.Checked
    End Sub
#End Region

#Region "--------------------chkInBC37_CheckedValueChanged--------------------"
    Private Sub chkInBC37_CheckedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInBC37.CheckedValueChanged
        txtBanBC37.Enabled = chkInBC37.Checked
    End Sub
#End Region

#Region "--------------------chkTuiF_CheckedChanged--------------------"
    Private Sub chkTuiF_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTuiF.CheckedChanged
        chkInBC37.Enabled = chkTuiF.Checked
    End Sub
#End Region
#End Region

#Region "--------------------Button--------------------"
#Region "--------------------btnMoTui_Click--------------------"
    Private Sub btnMoTui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoTui.Click
        Try
            If IsOpenBag = False Then
                MoTui()
            Else
                DongTui()
            End If
            If IsOpenBag = False Then
                myTongso = 0
                myTongKhoiLuongBP = 0
                If chkInkhidongE2.Checked Then
                    Open_Report(Not chkInkhidongE2.Checked, chkTuiF.Checked, chkInkhidongE2.Checked, chkInE4.Checked, chkInBC37.Checked, CInt(SetNullValue(txtBanE2.Text, "0")), CInt(SetNullValue(txtBanBC37.Text, "0")))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "-----------------------Đóng Mở E2-----------------------"
#Region "-----------------------Mở Túi-----------------------"
    Private Sub MoTui() 'Mở tờ E2
        Try
            'Thông tin nhập không đầy đủ     
            If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value), CInt(cbDuongThuDi.Text), CInt(cbChuyenThuDi.Text), CInt(cbTuiSoDi.Text)) = False Then Exit Sub

            'Kiểm tra ngày ca kế toán
            If GId_Ca = "" Then
                If CMessageBox.Show("Hiện tại bạn không làm việc trong bất cứ ca làm việc nào!!!" & vbNewLine _
                                  & "   Bạn phải thoát khỏi chương trình rồi vào lại     ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Exit Sub
                Else
                    Dispose()
                    Close()
                    Dim Frm As New FrmLogin
                    Frm.ShowDialog()
                End If
            End If
            'Kiểm tra ngày ca kế toán có đúng với ngày ca kế toán hiện tại không
            Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Ca_Hien_Tai(GBuu_Cuc_Khai_Thac)
            'Kiểm tra xem ngày đóng có lớn hơn ngày kế toán
            Dim NgaySanXuat As Integer = Convert.ToInt32(Mid(GId_Ca, 7, 8)) 'Lấy ngày sản xuất
            If (NgaySanXuat < myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)) Then
                MessageBox.Show("Ngày đóng không thể lớn hơn ngày kế toán,Bạn cần kiểm tra lại", " Ngày khai thác" & myHam_Dung_Chung.ConvertIntToDate_VN(NgaySanXuat))
                Exit Sub
            End If

            'Kiểm tra quyền sửa số liệu
            If GUserAdmin = False Then
                If GId_Ca <> myCa_San_Xuat_Chi_Tiet.Id_Ca Then
                    CMessageBox.Show("Bạn đang làm việc tại ca: " & Mid(GId_Ca, 14, 1) & ", Ngày" & myHam_Dung_Chung.ConvertIntToDate(CInt(Mid(GId_Ca, 7, 8))).ToString("dd/MM/yyyy") & vbNewLine _
                            & "Ca hiện tại là ca: " & myCa_San_Xuat_Chi_Tiet.Thu_Tu & ", Ngày : " & myHam_Dung_Chung.ConvertIntToDate(CInt(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac)).ToString("dd/MM/yyyy") _
                            & vbNewLine & "Bạn phải thoát khỏi chương trình rồi vào lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                'Kiểm tra ngày đóng chuyến thư có đúng với ngày hiện tại không: nếu không thì không được phép nhập tiếp
                If myHam_Dung_Chung.ConvertDateToInt(Now) <> myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value) Then
                    CMessageBox.Show("Ngày đóng chuyến thư không đúng với ngày hệ thống!!!" & vbNewLine _
                                  & "      Bạn hãy chỉnh lại ngày đóng chuyến thư      " _
                                    , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbNgayDong.Focus()
                    Exit Sub
                End If

                'Kiểm tra khóa số liệu tại ca đó
                Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
                If myKe_Toan_Ca.Lay(GId_Ca).Chot_Sl = True Then
                    CMessageBox.Show("Số liệu ca này đã bị khóa bạn không có quyến sửa đổi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                'Kiểm tra khóa số liệu tại ca đó
                Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
                If myKe_Toan_Ca.Lay(GId_Ca).Chot_Sl = True Then
                    If CMessageBox.Show("Số liệu ca này đã bị khóa!" & vbNewLine & "Bạn có muốn mở không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            'Sau khi nhập đầy thủ thông tin
            If LayThongSo() = False Then Exit Sub
            myLog_Id = 0 'Gán giá trị Default=0 cho Log_Id
            myTongso = 0
            myTongKhoiLuongBP = 0
            myId_Nguoi_Dung = Gid_Nguoi_Dung
            'Lay_Chi_Tiet_Chuyen_Thu_Di_tu_Duong_Thu_Di(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di)
            Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet

            myId_Ca = GId_Ca
            myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di, myLoai_Chuyen_Thu)
            If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then 'Nếu tồn tại chuyến thư
                myId_Chuyen_Thu = myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
                If myChuyen_Thu_Di_Chi_Tiet.Chot_Sl Then
                    If GUserAdmin = False Then 'Nếu không phải là quyền quản trị
                        MessageBox.Show("Số liệu về chuyến thư này đã bị khóa, bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbChuyenThuDi.Focus()
                    Else 'Nếu là quyền quản trị
                        If MessageBox.Show("Số liệu về chuyến thư này đã bị khóa!!!" & vbNewLine & "Bạn có muốn mở không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                            cbChuyenThuDi.Focus()
                            Exit Sub
                        End If
                    End If
                End If

                'Lay_Chi_Tiet_E2_Di_tu_Id_Chuyen_Thu_So_Tui(myId_Chuyen_Thu, myTui_So_Di)
                myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Chuyen_Thu_Di_Tui_So_KT(myId_Chuyen_Thu, myTui_So_Di)
                If myE2_Di_Chi_Tiet.Id_E2 <> "" Then 'Nếu tồn tại tờ E2
                    myId_E2 = myE2_Di_Chi_Tiet.Id_E2
                    If myE2_Di_Chi_Tiet.Chot_SL Then
                        If GUserAdmin = False Then 'Nếu không phải là quyền quản trị
                            MessageBox.Show("Số liệu về bản kê E2 này đã bị khóa, bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cbTuiSoDi.Focus()
                        Else 'Nếu là quyền quản trị
                            If MessageBox.Show("Số liệu về bản kê E2 này đã bị khóa!!!" & vbNewLine & "Bạn có muốn mở không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                                cbTuiSoDi.Focus()
                                Exit Sub
                            End If
                        End If
                    End If

                    If myE2_Di_Chi_Tiet.Id_Ca <> GId_Ca Then
                        If GUserAdmin = False Then 'Không được phép sửa đổi
                            MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(myE2_Di_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(myE2_Di_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & "Bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        Else
                            If MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(myE2_Di_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(myE2_Di_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & "Bạn có muốn mở không!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                myId_Ca = myE2_Di_Chi_Tiet.Id_Ca
                            Else
                                Exit Sub
                            End If
                        End If
                    End If

                    If myE2_Di_Chi_Tiet.Tong_So_BP = 0 And myE2_Di_Chi_Tiet.Khoi_Luong_BP = 0 Then 'Nếu tờ E2 đang được người khác cập nhật
                        MessageBox.Show("Tờ E2 này đang được người khác cập nhật!!!" & vbNewLine & "Bạn hãy chọn tờ E2 khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbTuiSoDi.Focus()
                        Exit Sub
                    End If
                    'Gán các thông số có trong chi tiết bản kê E2 được mở
                    chkTuiF.CheckedValue = myE2_Di_Chi_Tiet.Tui_F
                    chk_Kiem_Hoa.CheckedValue = myE2_Di_Chi_Tiet.Truyen_Doi_Soat
                    txtTrongluongTui.Value = myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui
                    myE2_Date = myE2_Di_Chi_Tiet.Ngay_Dong
                    myE2_Time = myE2_Di_Chi_Tiet.Gio_Dong
                    myTongso = myE2_Di_Chi_Tiet.Tong_So_BP
                    myTongKhoiLuongBP = myE2_Di_Chi_Tiet.Khoi_Luong_BP
                    myId_Ca = myE2_Di_Chi_Tiet.Id_Ca

                    If MessageBox.Show("Tờ E2 này có tổng số: " & myTongso & " Bưu phẩm" & vbNewLine _
                                & "Bạn có muốn mở tờ E2 này không", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.No Then
                        Exit Sub
                    End If

                    'Ghi Event trước: Mở lại E2
                    myLog_Id = Event_Viewer_Open_E2(1, Event_Viewer_Create_Chi_Tiet_E2(myE2_Di_Chi_Tiet.Id_Duong_Thu, myE2_Di_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myTongso, myTongKhoiLuongBP + myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui), "")

                    cbNgayDong.Value = myHam_Dung_Chung.ConvertIntToDate(myE2_Date)

                    'Cập nhật lại thông tin E2: Tong_So_BP=0, Khoi_Luong_BP=0
                    myE2_Di_Chi_Tiet.Tong_So_BP = 0
                    myE2_Di_Chi_Tiet.Khoi_Luong_BP = 0
                    myE2_Di_Chi_Tiet.Tui_F = False
                    myE2_Di.E2_Di_Cap_Nhat_Them_KT(myE2_Di_Chi_Tiet.Id_E2, _
                                                    myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                                                    myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                    myE2_Di_Chi_Tiet.Id_Ca, _
                                                    myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                    myE2_Di_Chi_Tiet.Ngay_Dong, _
                                                    myE2_Di_Chi_Tiet.Gio_Dong, _
                                                    myE2_Di_Chi_Tiet.Ngay_Nhan, _
                                                    myE2_Di_Chi_Tiet.Gio_Nhan, _
                                                    myE2_Di_Chi_Tiet.Tui_So, _
                                                    myE2_Di_Chi_Tiet.Tui_F, _
                                                    myE2_Di_Chi_Tiet.Tong_So_BP, _
                                                    myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                    myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                                                    myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                    myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                    myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                    myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                    myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                                                    myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                    myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                    myE2_Di_Chi_Tiet.Chot_SL)
                Else 'Nếu chưa tồn tại E2: Tạo E2 Mới
                    AddNew_E2_Di(myId_Duong_Thu, _
                                mySo_Chuyen_Thu_Di, _
                                myTui_So_Di, _
                                myE2_Date, _
                                myE2_Time, _
                                myStart_Date, _
                                myEnd_Date, _
                                myLoai_Chuyen_Thu, _
                                myId_Ca)
                End If
                'Cập nhật lại thông tin chuyến thư
                myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui = 0
                'myChuyen_Thu_Di_Chi_Tiet.Dong_F = False

                myChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, _
                                                                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                                myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Dong_F, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                                myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            Else 'Nếu chưa tồn tại chuyến thư
                AddNew_E2_Di(myId_Duong_Thu, _
                            mySo_Chuyen_Thu_Di, _
                            myTui_So_Di, _
                            myE2_Date, _
                            myE2_Time, _
                            myStart_Date, _
                            myEnd_Date, _
                            myLoai_Chuyen_Thu, _
                            myId_Ca)
            End If

            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)
                myId_Duong_Thu_Luu_Kho = CreateId_Duong_Thu(myDuong_Thu_Di_Chi_Tiet.Ma_Bc, myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac)  'myDuong_Thu_Di_Chi_Tiet.Ma_Bc.ToString & myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac.ToString
                myId_Chuyen_Thu_Luu_Kho = CreateId_Chuyen_Thu(myId_Duong_Thu_Luu_Kho, mySo_Chuyen_Thu_Di, myE2_Date, myLoai_Chuyen_Thu)
                myId_E2_Luu_Kho = CreateId_E2(myId_Chuyen_Thu_Luu_Kho, myTui_So_Di)
            Else 'Không phải là đường thư lưu kho
                myId_Duong_Thu_Luu_Kho = ""
                myId_Chuyen_Thu_Luu_Kho = ""
                myId_E2_Luu_Kho = ""
            End If

            'Hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1_Di(myId_E2)
            txtInfor.Text = "Tổng Số    : " & myTongso & vbNewLine & "Khối lượng : " & (myTongKhoiLuongBP / 1000) & "  KG"

            IsOpenBag = True
            Enable_Control(IsOpenBag)
            dgE1_Di.Focus()
            myCell = dgE1_Di.Rows(IIf(dgE1_Di.Rows.Count > 0, dgE1_Di.Rows.Count - 1, 0)).Cells("Ma_E1")
            dgE1_Di.ActiveCell = myCell
            dgE1_Di.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
        Catch ex As Exception
            IsOpenBag = False
            Enable_Control(IsOpenBag)
            cbDuongThuDi.Focus()
        End Try
    End Sub

#Region "--------------------Kiểm tra thông tin--------------------"
    Private Function IsCorrectInfor(Optional ByVal Ngay_Dong As Integer = 0, Optional ByVal Duong_Thu As Integer = 0, Optional ByVal So_Chuyen_Thu As Integer = 0, Optional ByVal Tui_So As Integer = 0) As Boolean
        'Kiểm tra thông tin về ngày
        If Ngay_Dong = 0 Then
            MessageBox.Show("Ngày đóng E2 chưa được xác định, xin mời nhập thông tin về ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbNgayDong.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về đường thư
        If Duong_Thu = 0 Then
            MessageBox.Show("Thông tin về đường thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbDuongThuDi.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về chuyến thư
        If So_Chuyen_Thu = 0 Then
            MessageBox.Show("Thông tin về chuyến thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbChuyenThuDi.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về túi thư
        If Tui_So = 0 Then
            MessageBox.Show("Thông tin về túi thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbTuiSoDi.Focus()
            Return False
            Exit Function
        End If
        'Thông tin được xác nhận dúng
        Return True
    End Function
#End Region

#Region "-----------------------AddNew_Chuyen_Thu_Di-----------------------"
    Private Sub AddNew_Chuyen_Thu_Di(ByVal Id_Duong_Thu As String, ByVal So_chuyen_thu As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        Id_Chuyen_Thu = CreateId_Chuyen_Thu(Id_Duong_Thu, So_chuyen_thu, Date_Create, Loai_Chuyen_Thu)
        myChuyen_Thu_Di.Cap_Nhat_Them(Id_Chuyen_Thu, Id_Duong_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, So_chuyen_thu, Date_Create, Time_Create, Date_Create, Time_Create, _
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False, 0, False)
        myId_Chuyen_Thu = Id_Chuyen_Thu
    End Sub
#End Region

#Region "-----------------------AddNew_E2_Di-----------------------"
    Private Sub AddNew_E2_Di(ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Start_Date As Integer, ByVal End_Date As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        If myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu, Loai_Chuyen_Thu).Id_Chuyen_Thu = "" Then 'Nếu chưa tồn tại chuyến thư
            AddNew_Chuyen_Thu_Di(Id_Duong_Thu, So_Chuyen_Thu, Date_Create, Time_Create, Loai_Chuyen_Thu, Id_Ca)
        End If
        myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = myChuyen_Thu_Di.Tim_Id_Chuyen_Thu_Di(Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu)
        myId_E2 = CreateId_E2(myId_Chuyen_Thu, Tui_So)
        myE2_Di.Cap_Nhat_Them(myId_E2, Id_Duong_Thu, myId_Chuyen_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, Date_Create, Time_Create, Date_Create, Time_Create, Tui_So, False, 0, 0, 0, 0, 0, 0, 0, 0, False, False, 0, False)
    End Sub
#End Region

#Region "-----------------------DataGrid_Nhap_E1_Di-----------------------"
    Private Sub DataGrid_Nhap_E1_Di(ByVal Id_E2 As String)
        dgE1_Di.DataSource = myE1_Di.E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT(Id_E2) 'myE1_Di.E1_Di_Lay_Boi_E2_Di_KT(Id_E2)
        dgE1_Di.DataBind()
        dgE1_Di.Rows.Band.AddNew()
    End Sub
#End Region
#End Region

#Region "-----------------------Đóng Túi-----------------------"
    Private Sub DongTui() 'Đóng tờ E2
        Try
            'Tổng hợp E2 Đi từ E1 Đi
            Tong_Hop_E2_Di_tu_E1_Di(myId_E2)
            'Tổng hợp Chuyến thư đi từ E2 Đi
            Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(myId_Chuyen_Thu)

            'Truyền dữ liệu báo phát
            If (chk_Ngaynghi.Checked = True) Then
                Truyen_Bao_Phat()
            End If

            If chkTuiF.Checked = True Then
                Truyen_Du_Lieu_Khai_Thac()
                'Truyen_Le_Phi_HQ()
            End If
            
            'Bỏ hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1_Di(0)

            'Sau khi đóng chuyến thư: enable tất cả các control
            IsOpenBag = False
            chkTuiF.Checked = False
            chkInBC37.Checked = False
            Enable_Control(IsOpenBag)
            cbDuongThuDi.Focus()
            cbNgayDong.Value = Today
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "-----------------------Tổng hợp E2_Di từ E1_Di-----------------------"
    Private Sub Tong_Hop_E2_Di_tu_E1_Di(ByVal Id_E2 As String)
        'Lay_Chi_Tiet_E2_Di_tu_Id_E2(Id_E2)
        Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        Dim myE2_Di_TH_E1_Di As New E2_Di_Chi_Tiet

        'Lấy dữ liệu chi tiết về bản kê E2
        myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        'Lấy dữ liệu tổng hợp về bản kê E2 từ các E1
        myE2_Di_TH_E1_Di = myE2_Di.E2_Di_Tong_Hop_Tu_E1_Di_KT(myE2_Di_Chi_Tiet.Id_E2)

        'Kiểm tra xem nếu không có thông tin về E2 này thì phải tạo mới
        If myE2_Di_Chi_Tiet.Id_E2 <> Id_E2 Then  'Nếu không tồn tại
            AddNew_E2_Di(myId_Duong_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myE2_Date, myE2_Time, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu, myId_Ca)
            myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        End If

        myE2_Di_Chi_Tiet.Tong_So_BP = myE2_Di_TH_E1_Di.Tong_So_BP

        'Ghi Event: Đóng Tờ E2
        'Event_Viewer_Close_E2(2, Event_Viewer_Create_Chi_Tiet_E2(myE2_Di_Chi_Tiet.Id_Duong_Thu, myE2_Di_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myE2_Di_Chi_Tiet.Tong_So_BP, myE2_Di_TH_E1_Di.Khoi_Luong_BP + CInt(Trim(txtTrongluongTui.Value))), "")

        If myE2_Di_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
            myE2_Di_Chi_Tiet.Tui_F = CBool(chkTuiF.Checked)
            If chk_Kiem_Hoa.Checked = True Then
                myE2_Di_Chi_Tiet.Truyen_Doi_Soat = True
            Else
                myE2_Di_Chi_Tiet.Truyen_Doi_Soat = False
            End If
            'myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = CInt(SetNullValue(Trim(txtTrongluongTui.Value), 0))
            If txtTrongluongTui.Text <> "" Then
                myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = CInt(Trim(txtTrongluongTui.Value))
            Else
                myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = GKhoi_Luong_Vo_Tui
            End If
            myE2_Di_Chi_Tiet.Khoi_Luong_BP = myE2_Di_TH_E1_Di.Khoi_Luong_BP
            myE2_Di_Chi_Tiet.Tong_Cuoc_COD = myE2_Di_TH_E1_Di.Tong_Cuoc_COD
            myE2_Di_Chi_Tiet.Tong_Cuoc_DV = myE2_Di_TH_E1_Di.Tong_Cuoc_DV
            myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh = myE2_Di_TH_E1_Di.Tong_Cuoc_Chinh
            myE2_Di_Chi_Tiet.HH_Phat_Hanh = myE2_Di_TH_E1_Di.HH_Phat_Hanh
            myE2_Di_Chi_Tiet.HH_Phat_Tra = myE2_Di_TH_E1_Di.HH_Phat_Tra
            'Cập nhật dữ liệu vào bảng E2_Di
            myE2_Di.E2_Di_Cap_Nhat_Them_KT(myE2_Di_Chi_Tiet.Id_E2, _
                                            myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                                            myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                            myE2_Di_Chi_Tiet.Id_Ca, _
                                            myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                            myE2_Di_Chi_Tiet.Ngay_Dong, _
                                            myE2_Di_Chi_Tiet.Gio_Dong, _
                                            myE2_Di_Chi_Tiet.Ngay_Nhan, _
                                            myE2_Di_Chi_Tiet.Gio_Nhan, _
                                            myE2_Di_Chi_Tiet.Tui_So, _
                                            myE2_Di_Chi_Tiet.Tui_F, _
                                            myE2_Di_Chi_Tiet.Tong_So_BP, _
                                            myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                            myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                                            myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                            myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                            myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                                            myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                                            myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                                            myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                            myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                            myE2_Di_Chi_Tiet.Chot_SL)

            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi):Thêm túi số
                myE2_Den_Tam.E2_Den_Tam_Cap_Nhat_Them_KT(myId_E2_Luu_Kho, _
                                                        myId_Duong_Thu_Luu_Kho, _
                                                        myId_Chuyen_Thu_Luu_Kho, _
                                                        myE2_Di_Chi_Tiet.Id_Ca, _
                                                        myDuong_Thu_Di_Chi_Tiet.Ma_Bc, _
                                                        myE2_Di_Chi_Tiet.Ngay_Dong, _
                                                        myE2_Di_Chi_Tiet.Gio_Dong, _
                                                        myE2_Di_Chi_Tiet.Ngay_Nhan, _
                                                        myE2_Di_Chi_Tiet.Gio_Nhan, _
                                                        myE2_Di_Chi_Tiet.Tui_So, _
                                                        myE2_Di_Chi_Tiet.Tui_F, _
                                                        myE2_Di_Chi_Tiet.Tong_So_BP, _
                                                        myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                        myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                        myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                        myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                                                        myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                        myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                        myE2_Di_Chi_Tiet.Chot_SL)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp
                myE2_Den_Tam.E2_Den_Tam_Cap_Nhat_Them_KT(myE2_Di_Chi_Tiet.Id_E2, _
                                                        myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                                                        myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                        myE2_Di_Chi_Tiet.Id_Ca, _
                                                        myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                        myE2_Di_Chi_Tiet.Ngay_Dong, _
                                                        myE2_Di_Chi_Tiet.Gio_Dong, _
                                                        myE2_Di_Chi_Tiet.Ngay_Nhan, _
                                                        myE2_Di_Chi_Tiet.Gio_Nhan, _
                                                        myE2_Di_Chi_Tiet.Tui_So, _
                                                        myE2_Di_Chi_Tiet.Tui_F, _
                                                        myE2_Di_Chi_Tiet.Tong_So_BP, _
                                                        myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                        myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                        myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                        myE2_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                        myE2_Di_Chi_Tiet.HH_Phat_Tra, _
                                                        myE2_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                        myE2_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                        myE2_Di_Chi_Tiet.Chot_SL)
            End If
        Else 'Nếu không tồn tại E1-> Xóa
            myE2_Di.Xoa(Id_E2)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)-> xóa túi
                myE2_Den_Tam.Xoa(myId_E2_Luu_Kho)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp-> xóa túi
                myE2_Den_Tam.Xoa(myE2_Di_Chi_Tiet.Id_E2)
            End If
        End If

        'Ghi Event: Đóng Tờ E2
        If myLog_Id <> 0 Then 'Nếu đã có sự kiện mở thì ghi sự kiện đóng
            Event_Viewer_Close_E2(myLog_Id, 2, Event_Viewer_Create_Chi_Tiet_E2(myE2_Di_Chi_Tiet.Id_Duong_Thu, myE2_Di_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myE2_Di_Chi_Tiet.Tong_So_BP, myE2_Di_TH_E1_Di.Khoi_Luong_BP + CInt(Trim(txtTrongluongTui.Value))))
        End If
    End Sub
#End Region

#Region "-----------------------Tổng hợp Chuyen_Thu_Di từ E2_Di-----------------------"
    Private Sub Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(ByVal Id_Chuyen_Thu As String)
        Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Dim myChuyen_Thu_Di_TH_tu_E2_Di As New Chuyen_Thu_Di_Chi_Tiet

        'Lấy dữ liệu chi tiết về chuyến thư
        myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
        'Lấy dữ liệu tổng hợp chuyến thư từ các chi tiết E2
        myChuyen_Thu_Di_TH_tu_E2_Di = myChuyen_Thu_Di.Chuyen_Thu_Di_Tong_Hop_Tu_E2_Di_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)

        myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_Tui

        If myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui > 0 Then 'Nếu tồn tại it nhất 1 bản kê E2 Update lại thông tin trên Chuyến thư
            myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_So_BP
            myChuyen_Thu_Di_Chi_Tiet.Tong_KL = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KL
            myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_KLBP
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_COD
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc_DV
            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc = myChuyen_Thu_Di_TH_tu_E2_Di.Tong_Cuoc
            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Hanh
            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra = myChuyen_Thu_Di_TH_tu_E2_Di.HH_Phat_Tra
            myChuyen_Thu_Di_Chi_Tiet.Dong_F = myChuyen_Thu_Di_TH_tu_E2_Di.Dong_F
            myChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                            myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, _
                                                            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                            myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Dong_F, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                            myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then  'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)-> Tạo thêm chuyến thư
                myChuyen_Thu_Den_Tam.Chuyen_Thu_Den_Tam_Cap_Nhat_Them_KT(myId_Chuyen_Thu_Luu_Kho, _
                                                                        myId_Duong_Thu_Luu_Kho, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                                                                        myDuong_Thu_Di_Chi_Tiet.Ma_Bc, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Dong_F, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then
                myChuyen_Thu_Den_Tam.Chuyen_Thu_Den_Tam_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Id_Ca, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_KL, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Dong_F, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                                        myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            End If
        Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
            myChuyen_Thu_Di.Xoa(Id_Chuyen_Thu)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then  'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)-> xóa chuyến thư
                myChuyen_Thu_Den_Tam.Xoa(myId_Chuyen_Thu_Luu_Kho)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp-> xóa chuyến thư
                myChuyen_Thu_Den_Tam.Xoa(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Lấy Thông Tin chi tiết E2_Di, Chuyen_Thu_Di"
    '#Region "Lấy Thông Tin chi tiết E2_Di từ Id_E2"
    '    Private Sub Lay_Chi_Tiet_E2_Di_tu_Id_E2(ByVal Id_E2 As String)
    '        Dim myDataTable As New DataTable
    '        Dim myConnection As New SqlConnection
    '        Dim myCommand As New SqlCommand
    '        Dim myAdapter As New SqlDataAdapter

    '        myConnection.ConnectionString = GConnectionString
    '        myCommand.Connection = myConnection
    '        myCommand.CommandText = "SELECT Id_E2,Id_Duong_Thu,Id_Chuyen_Thu,Id_Ca,Ma_Bc_Khai_Thac,Ngay_Dong,Gio_Dong,Ngay_Nhan,Gio_Nhan,Tui_So,Tui_F," & _
    '                                        "Tong_So_BP,Khoi_Luong_Vo_Tui,Khoi_Luong_BP,Tong_Cuoc_COD,Tong_Cuoc_DV,Tong_Cuoc_Chinh,HH_Phat_Hanh,HH_Phat_Tra," & _
    '                                        "Truyen_Khai_Thac,Truyen_Doi_Soat,Ngay_He_Thong,Chot_SL " & _
    '                                        " FROM E2_Di where Id_E2='" & Id_E2 & "'"
    '        Try
    '            myConnection.Open()
    '            myCommand.ExecuteNonQuery()
    '            myAdapter.SelectCommand = myCommand
    '            myAdapter.Fill(myDataTable)
    '        Catch er As SqlException
    '            MessageBox.Show("Lỗi xảy ra trong quá trình kết nối với CSDL " & er.Message, "Thông Báo", MessageBoxButtons.OK)
    '        Finally
    '            myConnection.Dispose()
    '        End Try
    '        If myDataTable.Rows.Count > 0 Then
    '            With myE2_Di_Chi_Tiet
    '                .Id_E2 = myDataTable.Rows(0)("Id_E2")
    '                .Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
    '                .Id_Chuyen_Thu = myDataTable.Rows(0)("Id_Chuyen_Thu")
    '                .Id_Ca = myDataTable.Rows(0)("Id_Ca")
    '                .Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
    '                .Ngay_Dong = myDataTable.Rows(0)("Ngay_Dong")
    '                .Gio_Dong = myDataTable.Rows(0)("Gio_Dong")
    '                .Ngay_Nhan = myDataTable.Rows(0)("Ngay_Nhan")
    '                .Gio_Nhan = myDataTable.Rows(0)("Gio_Nhan")
    '                .Tui_So = myDataTable.Rows(0)("Tui_So")
    '                .Tui_F = myDataTable.Rows(0)("Tui_F")
    '                .Tong_So_BP = myDataTable.Rows(0)("Tong_So_BP")
    '                .Khoi_Luong_Vo_Tui = myDataTable.Rows(0)("Khoi_Luong_Vo_Tui")
    '                .Khoi_Luong_BP = myDataTable.Rows(0)("Khoi_Luong_BP")
    '                .Tong_Cuoc_COD = myDataTable.Rows(0)("Tong_Cuoc_COD")
    '                .Tong_Cuoc_DV = myDataTable.Rows(0)("Tong_Cuoc_DV")
    '                .Tong_Cuoc_Chinh = myDataTable.Rows(0)("Tong_Cuoc_Chinh")
    '                .HH_Phat_Hanh = myDataTable.Rows(0)("HH_Phat_Hanh")
    '                .HH_Phat_Tra = myDataTable.Rows(0)("HH_Phat_Tra")
    '                .Truyen_Khai_Thac = myDataTable.Rows(0)("Truyen_Khai_Thac")
    '                .Truyen_Doi_Soat = myDataTable.Rows(0)("Truyen_Doi_Soat")
    '                .Ngay_He_Thong = myDataTable.Rows(0)("Ngay_He_Thong")
    '                .Chot_SL = myDataTable.Rows(0)("Chot_SL")
    '            End With
    '        Else
    '            myE2_Di_Chi_Tiet.Id_E2 = ""
    '        End If
    '    End Sub
    '#End Region

    '#Region "Lấy Thông Tin chi tiết E2_Di từ Id_Chuyen_Thu, So_Tui"
    '    Private Sub Lay_Chi_Tiet_E2_Di_tu_Id_Chuyen_Thu_So_Tui(ByVal myId_Chuyen_Thu As String, ByVal myTui_So As Integer)
    '        Dim myDataTable As New DataTable
    '        Dim myConnection As New SqlConnection
    '        Dim myCommand As New SqlCommand
    '        Dim myAdapter As New SqlDataAdapter

    '        myConnection.ConnectionString = GConnectionString
    '        myCommand.Connection = myConnection
    '        myCommand.CommandText = "SELECT Id_E2,Id_Duong_Thu,Id_Chuyen_Thu,Id_Ca,Ma_Bc_Khai_Thac,Ngay_Dong,Gio_Dong,Ngay_Nhan,Gio_Nhan,Tui_So,Tui_F," & _
    '                                        "Tong_So_BP,Khoi_Luong_Vo_Tui,Khoi_Luong_BP,Tong_Cuoc_COD,Tong_Cuoc_DV,Tong_Cuoc_Chinh,HH_Phat_Hanh,HH_Phat_Tra," & _
    '                                        "Truyen_Khai_Thac,Truyen_Doi_Soat,Ngay_He_Thong,Chot_SL " & _
    '                                        " FROM E2_Di where (Id_Chuyen_Thu= '" & myId_Chuyen_Thu & "') and (Tui_So = " & myTui_So & ")"
    '        Try
    '            myConnection.Open()
    '            myCommand.ExecuteNonQuery()
    '            myAdapter.SelectCommand = myCommand
    '            myAdapter.Fill(myDataTable)
    '        Catch er As SqlException
    '            MessageBox.Show("Lỗi xảy ra trong quá trình kết nối với CSDL " & er.Message, "Thông Báo", MessageBoxButtons.OK)
    '        Finally
    '            myConnection.Dispose()
    '        End Try
    '        If myDataTable.Rows.Count > 0 Then
    '            myE2_Di_Chi_Tiet.Id_E2 = myDataTable.Rows(0)("Id_E2")
    '            myE2_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
    '            myE2_Di_Chi_Tiet.Id_Chuyen_Thu = myDataTable.Rows(0)("Id_Chuyen_Thu")
    '            myE2_Di_Chi_Tiet.Id_Ca = myDataTable.Rows(0)("Id_Ca")
    '            myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
    '            myE2_Di_Chi_Tiet.Ngay_Dong = myDataTable.Rows(0)("Ngay_Dong")
    '            myE2_Di_Chi_Tiet.Gio_Dong = myDataTable.Rows(0)("Gio_Dong")
    '            myE2_Di_Chi_Tiet.Ngay_Nhan = myDataTable.Rows(0)("Ngay_Nhan")
    '            myE2_Di_Chi_Tiet.Gio_Nhan = myDataTable.Rows(0)("Gio_Nhan")
    '            myE2_Di_Chi_Tiet.Tui_So = myDataTable.Rows(0)("Tui_So")
    '            myE2_Di_Chi_Tiet.Tui_F = myDataTable.Rows(0)("Tui_F")
    '            myE2_Di_Chi_Tiet.Tong_So_BP = myDataTable.Rows(0)("Tong_So_BP")
    '            myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui = myDataTable.Rows(0)("Khoi_Luong_Vo_Tui")
    '            myE2_Di_Chi_Tiet.Khoi_Luong_BP = myDataTable.Rows(0)("Khoi_Luong_BP")
    '            myE2_Di_Chi_Tiet.Tong_Cuoc_COD = myDataTable.Rows(0)("Tong_Cuoc_COD")
    '            myE2_Di_Chi_Tiet.Tong_Cuoc_DV = myDataTable.Rows(0)("Tong_Cuoc_DV")
    '            myE2_Di_Chi_Tiet.Tong_Cuoc_Chinh = myDataTable.Rows(0)("Tong_Cuoc_Chinh")
    '            myE2_Di_Chi_Tiet.HH_Phat_Hanh = myDataTable.Rows(0)("HH_Phat_Hanh")
    '            myE2_Di_Chi_Tiet.HH_Phat_Tra = myDataTable.Rows(0)("HH_Phat_Tra")
    '            myE2_Di_Chi_Tiet.Truyen_Khai_Thac = myDataTable.Rows(0)("Truyen_Khai_Thac")
    '            myE2_Di_Chi_Tiet.Truyen_Doi_Soat = myDataTable.Rows(0)("Truyen_Doi_Soat")
    '            myE2_Di_Chi_Tiet.Ngay_He_Thong = myDataTable.Rows(0)("Ngay_He_Thong")
    '            myE2_Di_Chi_Tiet.Chot_SL = myDataTable.Rows(0)("Chot_SL")
    '        Else
    '            myE2_Di_Chi_Tiet.Id_E2 = ""
    '        End If
    '    End Sub
    '#End Region

    '#Region "Lấy Thông Tin chi tiết Chuyen_Thu_Di từ Id_Chuyen_Thu"
    '    Private Sub Lay_Chi_Tiet_Chuyen_Thu_Di_tu_Id_Chuyen_Thu(ByVal Id_Chuyen_Thu As String)
    '        Dim myConnection As New SqlConnection
    '        Dim myCommand As New SqlCommand
    '        Dim myAdapter As New SqlDataAdapter
    '        Dim myDataTable As DataTable = New DataTable

    '        myConnection.ConnectionString = GConnectionString
    '        myCommand.Connection = myConnection
    '        myCommand.CommandText = "SELECT Id_Chuyen_Thu,Id_Duong_Thu,Id_Ca,Ma_Bc_Khai_Thac,So_Chuyen_Thu,Ngay_Dong,Gio_Dong,Ngay_Nhan,Gio_Nhan," & _
    '                                        "Tong_So_Tui,Tong_So_BP,Tong_KL,Tong_KLBP,Tong_Cuoc_COD,Tong_Cuoc_DV,Tong_Cuoc,HH_Phat_Hanh,HH_Phat_Tra," & _
    '                                        "Dong_F,Truyen_Khai_Thac,Truyen_Doi_Soat,Ngay_He_Thong,Chot_Sl" & _
    '                                        " FROM Chuyen_Thu_Di where Id_Chuyen_Thu='" & Id_Chuyen_Thu & "'"
    '        Try
    '            myConnection.Open()
    '            myCommand.ExecuteNonQuery()
    '            myAdapter.SelectCommand = myCommand
    '            myAdapter.Fill(myDataTable)
    '        Catch er As SqlException
    '            MessageBox.Show("Lỗi xảy ra trong quá trình kết nối với CSDL " & er.Message, "Thông Báo", MessageBoxButtons.OK)
    '        Finally
    '            myConnection.Dispose()
    '        End Try
    '        'Lấy thông tin chi tiết chuyến thư đi
    '        If myDataTable.Rows.Count > 0 Then
    '            With myChuyen_Thu_Di_Chi_Tiet
    '                .Id_Chuyen_Thu = myDataTable.Rows(0)("Id_Chuyen_Thu")
    '                .Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
    '                .Id_Ca = myDataTable.Rows(0)("Id_Ca")
    '                .Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
    '                .So_Chuyen_Thu = myDataTable.Rows(0)("So_Chuyen_Thu")
    '                .Ngay_Dong = myDataTable.Rows(0)("Ngay_Dong")
    '                .Gio_Dong = myDataTable.Rows(0)("Gio_Dong")
    '                .Ngay_Nhan = myDataTable.Rows(0)("Ngay_Nhan")
    '                .Gio_Nhan = myDataTable.Rows(0)("Gio_Nhan")
    '                .Tong_So_Tui = myDataTable.Rows(0)("Tong_So_Tui")
    '                .Tong_So_BP = myDataTable.Rows(0)("Tong_So_BP")
    '                .Tong_KL = myDataTable.Rows(0)("Tong_KL")
    '                .Tong_KLBP = myDataTable.Rows(0)("Tong_KLBP")
    '                .Tong_Cuoc_COD = myDataTable.Rows(0)("Tong_Cuoc_COD")
    '                .Tong_Cuoc_DV = myDataTable.Rows(0)("Tong_Cuoc_DV")
    '                .Tong_Cuoc = myDataTable.Rows(0)("Tong_Cuoc")
    '                .HH_Phat_Hanh = myDataTable.Rows(0)("HH_Phat_Hanh")
    '                .HH_Phat_Tra = myDataTable.Rows(0)("HH_Phat_Tra")
    '                .Dong_F = myDataTable.Rows(0)("Dong_F")
    '                .Truyen_Khai_Thac = myDataTable.Rows(0)("Truyen_Khai_Thac")
    '                .Truyen_Doi_Soat = myDataTable.Rows(0)("Truyen_Doi_Soat")
    '                .Ngay_He_Thong = myDataTable.Rows(0)("Ngay_He_Thong")
    '                .Chot_Sl = myDataTable.Rows(0)("Chot_SL")
    '            End With
    '        Else
    '            myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = ""
    '        End If
    '    End Sub
    '#End Region

    '#Region "Lấy Thông Tin chi tiết Chuyen_Thu_Di từ: Duong_Thu_Di,Ngày E2 "
    '    Private Sub Lay_Chi_Tiet_Chuyen_Thu_Di_tu_Duong_Thu_Di(ByVal Id_Duong_Thu As String, ByVal Start_Date As Integer, ByVal End_Date As Integer, ByVal Sochuyenthu As Integer)
    '        Dim myConnection As New SqlConnection
    '        Dim myCommand As New SqlCommand
    '        Dim myAdapter As New SqlDataAdapter
    '        Dim myDataTable As DataTable = New DataTable

    '        myConnection.ConnectionString = GConnectionString
    '        myCommand.Connection = myConnection
    '        myCommand.CommandText = "SELECT Id_Chuyen_Thu,Id_Duong_Thu,Id_Ca,Ma_Bc_Khai_Thac,So_Chuyen_Thu,Ngay_Dong,Gio_Dong,Ngay_Nhan,Gio_Nhan," & _
    '                                        "Tong_So_Tui,Tong_So_BP,Tong_KL,Tong_KLBP,Tong_Cuoc_COD,Tong_Cuoc_DV,Tong_Cuoc,HH_Phat_Hanh,HH_Phat_Tra," & _
    '                                        "Dong_F,Truyen_Khai_Thac,Truyen_Doi_Soat,Ngay_He_Thong,Chot_Sl" & _
    '                                        " FROM Chuyen_Thu_Di where (Id_Duong_Thu= '" & Id_Duong_Thu & "') and (Ngay_Dong between " & Start_Date & " and " & End_Date & ") and (So_Chuyen_Thu=" & Sochuyenthu & ")"
    '        Try
    '            myConnection.Open()
    '            myCommand.ExecuteNonQuery()
    '            myAdapter.SelectCommand = myCommand
    '            myAdapter.Fill(myDataTable)
    '        Catch er As SqlException
    '            MessageBox.Show("Lỗi xảy ra trong quá trình kết nối với CSDL " & er.Message, "Thông Báo", MessageBoxButtons.OK)
    '        Finally
    '            myConnection.Dispose()
    '        End Try
    '        'Lấy thông tin chi tiết chuyến thư đi
    '        If myDataTable.Rows.Count > 0 Then
    '            With myChuyen_Thu_Di_Chi_Tiet
    '                .Id_Chuyen_Thu = myDataTable.Rows(0)("Id_Chuyen_Thu")
    '                .Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
    '                .Id_Ca = myDataTable.Rows(0)("Id_Ca")
    '                .Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
    '                .So_Chuyen_Thu = myDataTable.Rows(0)("So_Chuyen_Thu")
    '                .Ngay_Dong = myDataTable.Rows(0)("Ngay_Dong")
    '                .Gio_Dong = myDataTable.Rows(0)("Gio_Dong")
    '                .Ngay_Nhan = myDataTable.Rows(0)("Ngay_Nhan")
    '                .Gio_Nhan = myDataTable.Rows(0)("Gio_Nhan")
    '                .Tong_So_Tui = myDataTable.Rows(0)("Tong_So_Tui")
    '                .Tong_So_BP = myDataTable.Rows(0)("Tong_So_BP")
    '                .Tong_KL = myDataTable.Rows(0)("Tong_KL")
    '                .Tong_KLBP = myDataTable.Rows(0)("Tong_KLBP")
    '                .Tong_Cuoc_COD = myDataTable.Rows(0)("Tong_Cuoc_COD")
    '                .Tong_Cuoc_DV = myDataTable.Rows(0)("Tong_Cuoc_DV")
    '                .Tong_Cuoc = myDataTable.Rows(0)("Tong_Cuoc")
    '                .HH_Phat_Hanh = myDataTable.Rows(0)("HH_Phat_Hanh")
    '                .HH_Phat_Tra = myDataTable.Rows(0)("HH_Phat_Tra")
    '                .Dong_F = myDataTable.Rows(0)("Dong_F")
    '                .Truyen_Khai_Thac = myDataTable.Rows(0)("Truyen_Khai_Thac")
    '                .Truyen_Doi_Soat = myDataTable.Rows(0)("Truyen_Doi_Soat")
    '                .Ngay_He_Thong = myDataTable.Rows(0)("Ngay_He_Thong")
    '                .Chot_Sl = myDataTable.Rows(0)("Chot_SL")
    '            End With
    '        Else
    '            myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = ""
    '        End If
    '    End Sub
    '#End Region

#End Region
#End Region
#End Region

#Region "--------------------BtnTimE1_Click--------------------"
    Private Sub BtnTimE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTimE1.Click
        Dim frm As New FrmTimKiemE1
        frm.ShowDialog()
    End Sub
#End Region

#Region "--------------------btnPreview_Click--------------------"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            Open_Report(True, chkTuiF.Checked, chkInkhidongE2.Checked, chkInE4.Checked, chkInBC37.Checked, CInt(SetNullValue(txtBanE2.Text, "0")), CInt(SetNullValue(txtBanBC37.Text, "0")))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------------------btnPrint_Click--------------------"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Open_Report(False, chkTuiF.Checked, chkInkhidongE2.Checked, chkInE4.Checked, chkInBC37.Checked, CInt(SetNullValue(txtBanE2.Text, "0")), CInt(SetNullValue(txtBanBC37.Text, "0")))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "--------------------Open_Report--------------------"
    Private Sub Open_Report(ByVal Preview As Boolean, ByVal Tui_F As Boolean, ByVal In_E2 As Boolean, ByVal In_E4 As Boolean, ByVal In_Bc37 As Boolean, ByVal So_Ban_E2 As Integer, ByVal So_Ban_Bc37 As Integer)
        'Lấy thông tin về bản kê E2
        Dim Ngay_Dong As Integer
        Dim Duong_Thu As Integer
        Dim Loai_Chuyen_Thu As String
        Dim So_Chuyen_Thu As Integer
        Dim Tui_So As Integer
        Dim Duong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
        Dim Start_Date As Integer
        Dim End_Date As Integer
        Dim DataTable As New DataTable

        'Lấy thông tin tại combobox

        If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(cbDuongThuDi.Text), CInt(cbChuyenThuDi.Text), CInt(cbTuiSoDi.Text)) = False Then Exit Sub 'Thông tin nhập không đầy đủ

        Ngay_Dong = myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
        Duong_Thu = CInt(cbDuongThuDi.Text)
        So_Chuyen_Thu = CInt(cbChuyenThuDi.Text)
        Tui_So = CInt(cbTuiSoDi.Text)
        Loai_Chuyen_Thu = "EN"
        'Lấy thông tin về đường thư đi
        DataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, Duong_Thu)
        Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu = DataTable.Rows(0)("Id_Duong_Thu")
        Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai = DataTable.Rows(0)("Id_Phan_Loai")
        Select Case Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai
            Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                Start_Date = (Ngay_Dong \ 100) * 100
                End_Date = (Ngay_Dong \ 100) * 100 + 99
            Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê,Lưu kho QT Đến, Lưu kho QT Đi, Chuyển Tiếp: Chuyến Thư tăng theo Năm
                Start_Date = (Ngay_Dong \ 10000) * 10000
                End_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            Case Else
                MessageBox.Show("Không tồn tại phân loại đường thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        'Lấy thông tin về chuyến thư đi
        'Kiểm tra xem chuyến thư đấy có tồn tại không, Nếu không tồn tại thì báo lỗi
        Dim Chuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Chuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu, Loai_Chuyen_Thu)
        If Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = "" Then Exit Sub

        'Lấy thông tin về bản kê E2
        'Nếu tồn tại bản kê E2 thì tiếp tục và lấy Id_E2, nếu không tồn tại thì báo lỗi
        Dim E2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        E2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Chuyen_Thu_Di_Tui_So_KT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Tui_So)
        If E2_Di_Chi_Tiet.Id_E2 = "" Then Exit Sub 'Nếu không tồn tại tờ E2
        'GIn_Kim_QT_Den = True
        If GIn_Kim_QT_Den = True Then
            If Preview Then 'Nếu nhấn Preview thì chỉ xem được 1 bản kê
                If Not In_Bc37 And Not In_E4 Then
                    If GIn_Ban_Ke_E2_To_Text_Second = True Then
                        myIn_E2_TEXT.Ban_Ke_E2_Di_To_Text_Second(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                    Else
                        myIn_E2_TEXT.Ban_Ke_E2_Di_To_Text(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                    End If
                ElseIf In_Bc37 Then
                    If Tui_F Then
                        If GIn_Ban_Ke_BC37_To_Text_Second = True Then
                            myIn_BC37_To_Text.WriteBC37TEXT_Second(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        Else
                            myIn_BC37_To_Text.WriteBC37TEXT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        End If
                        'BC_37report(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)  'In Bc37
                    End If
                ElseIf In_E4 Then
                    WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1)
                End If
            Else 'Nếu nhấn Print: in tất cả các bản kê được chọn
                If In_E2 Then
                    If GIn_Ban_Ke_E2_To_Text_Second = True Then
                        myIn_E2_TEXT.Ban_Ke_E2_Di_To_Text_Second(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                    Else
                        myIn_E2_TEXT.Ban_Ke_E2_Di_To_Text(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                    End If
                    'In E4
                    If In_E4 Then
                        WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1)
                    End If
                    'In Bc37
                    If In_Bc37 Then
                        If Tui_F Then
                            If GIn_Ban_Ke_BC37_To_Text_Second = True Then
                                myIn_BC37_To_Text.WriteBC37TEXT_Second(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                            Else
                                myIn_BC37_To_Text.WriteBC37TEXT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            If Preview Then 'Nếu nhấn Preview thì chỉ xem được 1 bản kê
                If Not In_Bc37 And Not In_E4 Then
                    Ban_Ke_E2_Di_KhaiThac(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                ElseIf In_Bc37 Then
                    If Tui_F Then
                        BC_37report(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)  'In Bc37
                    End If
                ElseIf In_E4 Then
                    WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1)
                End If
            Else 'Nếu nhấn Print: in tất cả các bản kê được chọn
                If In_E2 Then
                    Ban_Ke_E2_Di_KhaiThac(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_E2)
                    'In E4
                    If In_E4 Then
                        WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1)
                    End If
                    'In Bc37
                    If In_Bc37 Then
                        If Tui_F Then
                            'In BC 37
                            BC_37report(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                            'Tao PREDES - DO TIEN VIET.
                            'Lay nước đóng chuyến thư và IPMC theo id_duong_thu
                        End If
                        'Can cu theo id_chuyen_thu de xac dinh duoc id_duong_thu
                        'Kiem tra duong thu di theo id_duong_thu, neu id_phan_loai=4 => Di quoc te, thi se duoc tao ra PREDES.
                        '
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "--------------------BtnExit_Click--------------------"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
#End Region
#End Region

#Region "--------------------Commbo Box--------------------"
#Region "--------------------Combo_KeyDown--------------------"
    Private Sub Combo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbNgayDong.KeyDown, cbDuongThuDi.KeyDown, cbChuyenThuDi.KeyDown, cbTuiSoDi.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#Region "--------------------Ngày Đóng--------------------"
#Region "--------------------cbNgayDong_GotFocus--------------------"
    Private Sub cbNgayDong_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.GotFocus
        Dim m_Object As Object
        m_Object = sender
        m_Object.SelectionStart = 0
        m_Object.SelectionLength = m_Object.Text.Length
    End Sub
#End Region

#Region "--------------------cbNgayDong_AfterExitEditMode--------------------"
    Private Sub cbNgayDong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.AfterExitEditMode
        Lay_TT_Ngay_E2()
        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date)
    End Sub
#End Region
#End Region

#Region "--------------------Đường Thư--------------------"
#Region "--------------------cbDuongThuDi_Validated--------------------"
    Private Sub cbDuongThuDi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuDi.Validated
        If IsNumeric(cbDuongThuDi.Text) = False And cbDuongThuDi.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbDuongThuDi.Focus()
            Exit Sub
        Else
            Lay_TT_Duong_Thu()
            Lay_TT_Ngay_Thang(myE2_Date)
            myLoai_Chuyen_Thu = "EN"
            mySo_Chuyen_Thu_Di_Lon_Nhat = myChuyen_Thu_Di.Tim_So_Chuyen_Thu_Di_Lon_Nhat(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)

            'Xu ly tang chuyen thu khi het 1 ca khai thac ma nguoi dung khong dong F
            'Sang ca khai thac tiep theo tu dong tang chuyen thu - tranh dong 1 chuyen thu nhieu ngay khac nhau
            Dim Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Dim isQuaNgay As Boolean
            Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu)
            If Chuyen_Thu_Di_Qua_Ngay_Chi_Tiet.Id_Ca <> GId_Ca Then
                isQuaNgay = True
            Else
                isQuaNgay = False
            End If

            'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi, Loại chuyến thư
            cbChuyenThuDi.DataSource = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Boi_Duong_Thu_Di_Ngay_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
            If mySo_Chuyen_Thu_Di_Lon_Nhat > 0 Then
                If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False And isQuaNgay = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDi.Value = mySo_Chuyen_Thu_Di_Lon_Nhat
                Else
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                End If
            Else
                cbChuyenThuDi.Text = 1
            End If
            Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")"
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")"

        'Them phan xu ly vao kho hai quan 100907
        If myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8 Then   'La kho hai quan
            Hide_Cotrol_LyDo(False)
            cbDuongThuDi.Tag = True    'Luu gia tri de can cu SetDefaultValue cho Id_Trang_Thai
        Else   'Cac truong hop con lai
            Hide_Cotrol_LyDo(True)
            cbDuongThuDi.Tag = False   'Luu gia tri de can cu SetDefaultValue cho Id_Trang_Thai
        End If
        '--------------------------------------
        'Thêm phần kiểm tra thêm thông tin của đường thư đi: Nước đến, Tỉnh đến
        myMa_Nuoc_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Nc
        myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Tinh
    End Sub
#End Region
#End Region

#Region "--------------------Chuyến Thư--------------------"
#Region "--------------------cbChuyenThuDi_BeforeDropDown--------------------"
    Private Sub cbChuyenThuDi_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbChuyenThuDi.BeforeDropDown
        If cbDuongThuDi.Text <> "" Then
            cbChuyenThuDi.Text = ""
            mySo_Chuyen_Thu_Di_Lon_Nhat = myChuyen_Thu_Di.Tim_So_Chuyen_Thu_Di_Lon_Nhat(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
            'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
            cbChuyenThuDi.DataSource = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Boi_Duong_Thu_Di_Ngay_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
            If mySo_Chuyen_Thu_Di_Lon_Nhat > 0 Then
                If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                    If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                        cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat
                        'cbChuyenThuDi.Value = cbChuyenThuDi.Rows(0).Cells("So_Chuyen_Thu").Value
                    Else
                        cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                    End If
                End If
            Else
                If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                    cbChuyenThuDi.Text = 1
                End If
            End If
            'DanhsachChuyenThu(myId_Duong_Thu, myStart_Date, myEnd_Date)
        End If
    End Sub
#End Region

#Region "--------------------cbChuyenThuDi_Validated--------------------"
    Private Sub cbChuyenThuDi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChuyenThuDi.Validated
        If IsNumeric(cbChuyenThuDi.Text) = False And cbChuyenThuDi.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbChuyenThuDi.Focus()
            Exit Sub
        Else
            Lay_TT_Chuyen_Thu()
            cbTuiSoDi.Text = ""
            cbTuiSoDi.LimitToList = False
            myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di, myLoai_Chuyen_Thu)
            If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then  'Nếu tồn tại chuyến thư
                myId_Chuyen_Thu = myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
                myTui_So_Di_Lon_Nhat = myE2_Di.Tim_So_Tui_Di_Lon_Nhat(myId_Chuyen_Thu)
                Me.cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(myId_Chuyen_Thu)
                If myE2_Di.IsExist_E2_Di(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = True Then   'Kiểm tra xem túi 1 có tồn tại không
                    If myE2_Di.Xac_dinh_Tui_Di_F(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = False Then 'Kiểm tra túi max đã đóng F chưa
                        cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat + 1
                    Else
                        MessageBox.Show("Chuyến thư này đã đóng túi F", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat
                        cbTuiSoDi.Value = cbTuiSoDi.Rows(0).Cells("Tui_So").Value
                        cbTuiSoDi.LimitToList = True
                    End If
                Else
                    myTui_So_Di_Lon_Nhat = 0
                    cbTuiSoDi.Text = 1
                End If
            Else
                cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(0)
                cbTuiSoDi.Text = 1
            End If
        End If
        'Kiểm tra chuyến thư nhập vào: Không được nhập số chuyến thư lung tung
        If (mySo_Chuyen_Thu_Di > mySo_Chuyen_Thu_Di_Lon_Nhat + 1) Then
            If GUserAdmin = False Then
                CMessageBox.Show("Số chuyến thư được quản lý tự động, bạn không được phép nhập!!!", _
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbChuyenThuDi.Focus()
                Exit Sub
            Else
                If CMessageBox.Show("Số chuyến thư được quản lý tự động!!!" & vbNewLine & "Bạn có muốn tiếp tục không???", _
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    cbChuyenThuDi.Focus()
                    Exit Sub
                End If
            End If
        End If
        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine _
                            & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                            & "Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di)

    End Sub
#End Region
#End Region

#Region "--------------------Túi Số--------------------"
#Region "--------------------cbTuiSoDi_BeforeDropDown--------------------"
    Private Sub cbTuiSoDi_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTuiSoDi.BeforeDropDown
        cbTuiSoDi.Text = ""
        If cbTuiSoDi.Text <> "" Then
            Lay_TT_Chuyen_Thu()
            'cbTuiSoDi.Text = ""
            cbTuiSoDi.LimitToList = False
            myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di, myLoai_Chuyen_Thu)
            If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then 'Nếu tồn tại 1 chuyến thư
                myId_Chuyen_Thu = myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
                myTui_So_Di_Lon_Nhat = myE2_Di.Tim_So_Tui_Di_Lon_Nhat(myId_Chuyen_Thu)
                Me.cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(myId_Chuyen_Thu)
                If myE2_Di.IsExist_E2_Di(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = True Then   'Kiểm tra xem túi 1 có tồn tại không
                    If myE2_Di.Xac_dinh_Tui_Di_F(myId_Chuyen_Thu, myTui_So_Di_Lon_Nhat) = False Then 'Kiểm tra túi max đã đóng F chưa
                        cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat + 1
                    Else
                        cbTuiSoDi.Text = myTui_So_Di_Lon_Nhat
                        cbTuiSoDi.Value = cbTuiSoDi.Rows(0).Cells("Tui_So").Value
                        cbTuiSoDi.LimitToList = True
                    End If
                Else
                    myTui_So_Di_Lon_Nhat = 0
                    cbTuiSoDi.Text = 1
                End If
            Else
                cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(0)
                cbTuiSoDi.Text = 1
            End If
        End If
    End Sub
#End Region

#Region "--------------------cbTuiSoDi_Validated--------------------"
    Private Sub cbTuiSoDi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTuiSoDi.Validated
        If IsNumeric(cbTuiSoDi.Text) = False And cbTuiSoDi.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbTuiSoDi.Focus()
            Exit Sub
        Else
            Lay_TT_E2()
        End If
        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) _
                            & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                            & "Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di) & " - Túi Số: " & myTui_So_Di
    End Sub
#End Region
#End Region
#End Region

#Region "--------------------Lấy Thông Số--------------------"
#Region "--------------------LayThongSo--------------------"
    Private Function LayThongSo() As Boolean
        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        'Lấy Ngày giờ hiện tại
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
        If myE2_Date <> 0 Then
            'Lấy thông tin đường thư chi tiết
            Dim myDataTable As DataTable
            myDataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value))
            If myDataTable.Rows.Count > 0 And cbDuongThuDi.IsItemInList = True Then
                myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
                myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
                myDuong_Thu_Di_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
                myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
                myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
                myId_Duong_Thu = myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
                myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = myDataTable.Rows(0)("Duoc_Truyen")
                myDuong_Thu_Di_Chi_Tiet.Su_Dung = myDataTable.Rows(0)("Su_Dung")
                myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = myDataTable.Rows(0)("Chuyen_Tiep")
            Else
                cbDuongThuDi.Focus()
                Return False
                Exit Function
            End If

            Select Case myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai
                Case 0 'Đường Thư Bưu Tá: Chuyến Thư tăng theo Ngày
                    myStart_Date = myE2_Date
                    myEnd_Date = myE2_Date
                Case 1 'Đường Thư Nội Tỉnh: Chuyến Thư tăng theo Tháng
                    myStart_Date = (myE2_Date \ 100) * 100
                    myEnd_Date = (myE2_Date \ 100) * 100 + 99
                Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê,Lưu kho(QT Đến, QT Đi), Chuyển tiếp: Chuyến Thư tăng theo Năm
                    myStart_Date = (myE2_Date \ 10000) * 10000
                    myEnd_Date = (myE2_Date \ 10000) * 10000 + 9999
                Case Else
                    MessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                    Exit Function
            End Select

            'Loại Chuyến Thư
            myLoai_Chuyen_Thu = "EN"
            'Lấy thông tin chuyến thư
            If cbChuyenThuDi.Text = "" Then
                mySo_Chuyen_Thu_Di = 0
                Return False
                Exit Function
            Else
                mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
            End If
            'Lấy thông tin túi số
            If cbTuiSoDi.Text = "" Then
                myTui_So_Di = 0
                Return False
                Exit Function
            Else
                myTui_So_Di = CInt(cbTuiSoDi.Text)
            End If
            Return True
        Else
            MessageBox.Show("Ngày E2 chưa được xác định!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
#End Region

#Region "--------------------Lay_TT_Ngay_E2--------------------"
    Private Sub Lay_TT_Ngay_E2()
        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
    End Sub
#End Region

#Region "--------------------Lay_TT_Duong_Thu--------------------"
    Private Sub Lay_TT_Duong_Thu()
        Dim myDataTable As DataTable
        'Lấy thông tin đường thư chi tiết
        myDataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value))
        If myDataTable.Rows.Count > 0 And cbDuongThuDi.IsItemInList = True Then
            myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
            myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
            myDuong_Thu_Di_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
            myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
            myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
            myId_Duong_Thu = myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
            myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = myDataTable.Rows(0)("Duoc_Truyen")
            myDuong_Thu_Di_Chi_Tiet.Su_Dung = myDataTable.Rows(0)("Su_Dung")
            myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = myDataTable.Rows(0)("Chuyen_Tiep")
        Else
            cbDuongThuDi.Focus()
        End If
    End Sub
#End Region

#Region "--------------------Lay_TT_Ngay_Thang--------------------"
    Private Sub Lay_TT_Ngay_Thang(ByVal E2_Date As Integer)
        If E2_Date <> 0 Then
            Select Case myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai
                Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                    myStart_Date = (E2_Date \ 100) * 100
                    myEnd_Date = (E2_Date \ 100) * 100 + 99
                Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê, Lưu kho(QT Đến, QT Đi), Chuyển tiếp: Chuyến Thư tăng theo Năm
                    myStart_Date = (E2_Date \ 10000) * 10000
                    myEnd_Date = (E2_Date \ 10000) * 10000 + 9999
                Case Else
                    MessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Else
            MessageBox.Show("Ngày E2 chưa được xác định!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "--------------------Lay_TT_Chuyen_Thu--------------------"
    Private Sub Lay_TT_Chuyen_Thu()
        If cbChuyenThuDi.Text = "" Then
            mySo_Chuyen_Thu_Di = 0
        Else
            mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
        End If
    End Sub
#End Region

#Region "--------------------Lay_TT_E2--------------------"
    Private Sub Lay_TT_E2()
        Lay_TT_Chuyen_Thu()
        If cbTuiSoDi.Text = "" Then
            myTui_So_Di = 0
        Else
            myTui_So_Di = CInt(cbTuiSoDi.Text)
        End If
    End Sub
#End Region
#End Region

#Region "-----------------------Thiết lập tham số-----------------------"
#Region "-----------------------btn_Thiet_Lap_Tham_So_Click-----------------------"
    Private Sub btn_Thiet_Lap_Tham_So_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thiet_Lap_Tham_So.Click
        Group_Thiet_Lap_Tham_So.Visible = True
        Load_Thiet_Lap_Tham_So()
    End Sub
#End Region

#Region "-----------------------Load_Thiet_Lap_Tham_So-----------------------"
    Private Sub Load_Thiet_Lap_Tham_So()
        chkCuocE1.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Cuoc_E1"), "False"))
        chk_Nguoi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Nguoi_Nhan"), "False"))
        chk_Dia_Chi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dia_Chi_Nhan"), "False"))
        chk_Dien_Thoai_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dien_Thoai_Nhan"), "False"))
        chk_Nguoi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Nguoi_Gui"), "False"))
        chk_Dia_Chi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Dia_Chi_Gui"), "False"))
        chkGhiChu.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ghi_Chu"), "False"))
        chkLe_Phi_HQ.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_HQ"), "False"))
        chkThue_NK.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_NK"), "False"))
        chkThue_VAT.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_VAT"), "False"))
        chkSo_TKHQ.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_So_TKHQ"), "False"))
        chkSo_Bien_Lai.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_So_Bien_Lai"), "False"))
        chkLoai_Hang_Hoa.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Loai_Hang_Hoa"), "False"))
        chkBcChuyenHoan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ma_Bc_CH"), "False"))
        chkCuocDV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Cuoc_Dv"), "False"))
        chkKienSo.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Kien_So"), "False"))
        chk_Le_Phi_VH.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_VH"), "False"))
        chk_Le_Phi_YT.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_YT"), "False"))
        chk_Le_Phi_DV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_DV"), "False"))
        chk_Le_Phi_TV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_TV"), "False"))
        chk_Le_Phi_Khac.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Le_Phi_Khac"), "False"))
        chkLy_Do_Hai_Quan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Ly_Do_Vao_Kho_HQ"), "False"))

        chkThue_Tieu_Thu.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Thue_Tieu_Thu"), "False"))
        chkThue_Tieu_Thu.Enabled = False
        chkTong_Thue_Le_Phi.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Di_Tong_Thue_Le_Phi"), "False"))
    End Sub
#End Region

#Region "-----------------------btn_Bo_Qua_Click-----------------------"
    Private Sub btn_Bo_Qua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Bo_Qua.Click
        Group_Thiet_Lap_Tham_So.Visible = False
    End Sub
#End Region

#Region "-----------------------btn_Cap_Nhat_Click-----------------------"
    Private Sub btn_Cap_Nhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cap_Nhat.Click
        Cap_Nhat_Tham_So()
        Thiet_Lap_Tham_So()
        Group_Thiet_Lap_Tham_So.Visible = False
        SetLastColumnVisibleKey(dgE1_Di)
        SetColumnInputData(dgE1_Di)
    End Sub
#End Region

#Region "-----------------------Cap_Nhat_Tham_So-----------------------"
    Private Sub Cap_Nhat_Tham_So()
        myKeys.Ghi("IB_Grid_Di_Cuoc_E1", chkCuocE1.Checked)
        myKeys.Ghi("IB_Grid_Di_Nguoi_Nhan", chk_Nguoi_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Di_Dia_Chi_Nhan", chk_Dia_Chi_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Di_Dien_Thoai_Nhan", chk_Dien_Thoai_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Di_Nguoi_Gui", chk_Nguoi_Gui.Checked)
        myKeys.Ghi("IB_Grid_Di_Dia_Chi_Gui", chk_Dia_Chi_Gui.Checked)
        myKeys.Ghi("IB_Grid_Di_Ghi_Chu", chkGhiChu.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_HQ", chkLe_Phi_HQ.Checked)
        myKeys.Ghi("IB_Grid_Di_Thue_NK", chkThue_NK.Checked)
        myKeys.Ghi("IB_Grid_Di_Thue_VAT", chkThue_VAT.Checked)
        myKeys.Ghi("IB_Grid_Di_So_TKHQ", chkSo_TKHQ.Checked)
        myKeys.Ghi("IB_Grid_Di_So_Bien_Lai", chkSo_Bien_Lai.Checked)
        myKeys.Ghi("IB_Grid_Di_Loai_Hang_Hoa", chkLoai_Hang_Hoa.Checked)
        myKeys.Ghi("IB_Grid_Di_Bc_CH", chkBcChuyenHoan.Checked)
        myKeys.Ghi("IB_Grid_Di_Cuoc_Dv", chkCuocDV.Checked)
        myKeys.Ghi("IB_Grid_Di_Kien_So", chkKienSo.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_VH", chk_Le_Phi_VH.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_YT", chk_Le_Phi_YT.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_DV", chk_Le_Phi_DV.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_TV", chk_Le_Phi_TV.Checked)
        myKeys.Ghi("IB_Grid_Di_Le_Phi_Khac", chk_Le_Phi_Khac.Checked)
        myKeys.Ghi("IB_Grid_Di_Ly_Do_Vao_Kho_HQ", chkLy_Do_Hai_Quan.Checked)

        myKeys.Ghi("IB_Grid_Di_Dv_Cong_Them", chkDich_Vu_Cong_Them.Checked)
        myKeys.Ghi("IB_Grid_Di_Dv_Gia_Tang", chk_Dv_Gia_Tang.Checked)

        myKeys.Ghi("IB_Grid_Di_Thue_Tieu_Thu", chkThue_Tieu_Thu.Checked)
        myKeys.Ghi("IB_Grid_Di_Tong_Thue_Le_Phi", chkTong_Thue_Le_Phi.Checked)
    End Sub
#End Region
    Private Sub chk_Dv_Gia_Tang_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Dv_Gia_Tang.CheckedChanged
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dv_Gia_Tang").Hidden = Not chk_Dv_Gia_Tang.Checked
    End Sub

    Private Sub chkDich_Vu_Cong_Them_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDich_Vu_Cong_Them.CheckedChanged
        dgE1_Di.DisplayLayout.Bands(0).Columns("Dv_Cong_Them").Hidden = Not chkDich_Vu_Cong_Them.Checked
    End Sub
#Region "--------------------SetColumnInputData--------------------"
    Private Sub SetColumnInputData(ByVal sender As Object)
        myGridKeyDown = sender
        myColumnInputData = ""

        If chkNhapLePhi.Checked = True Then
            If myGridKeyDown.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = False Then
                myColumnInputData = "So_TKHQ"
            Else
                If myGridKeyDown.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = False Then
                    myColumnInputData = "So_Bien_Lai"
                Else
                    If myGridKeyDown.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden = False Then
                        myColumnInputData = "Le_Phi_HQ"
                    Else
                        If myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = False Then
                            myColumnInputData = "Thue_NK"
                        Else
                            If myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = False Then
                                myColumnInputData = "Thue_VAT"
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If chkNhap_Thong_Tin_Nguoi_Nhan.Checked = True Then
            If myGridKeyDown.DisplayLayout.Bands(0).Columns("Nguoi_Gui").Hidden = False Then
                myColumnInputData = "Nguoi_Gui"
            Else
                If myGridKeyDown.DisplayLayout.Bands(0).Columns("Dia_Chi_Gui").Hidden = False Then
                    myColumnInputData = "Dia_Chi_Gui"
                Else
                    If myGridKeyDown.DisplayLayout.Bands(0).Columns("Dien_Thoai_Gui").Hidden = False Then
                        myColumnInputData = "Dien_Thoai_Gui"
                    Else
                        If myGridKeyDown.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = False Then
                            myColumnInputData = "Nguoi_Nhan"
                        Else
                            If myGridKeyDown.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = False Then
                                myColumnInputData = "Dia_Chi_Nhan"
                            Else
                                If myGridKeyDown.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = False Then
                                    myColumnInputData = "Dien_Thoai_Nhan"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub
#End Region
#End Region

#Region "--------------------Check Box--------------------"
#Region "--------------------chkNhapLePhi_CheckedChanged--------------------"
    Private Sub chkNhapLePhi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNhapLePhi.CheckedChanged
        SetColumnInputData(dgE1_Di)
    End Sub
#End Region

#Region "--------------------chkNhap_Thong_Tin_Nguoi_Nhan_CheckedChanged--------------------"
    Private Sub chkNhap_Thong_Tin_Nguoi_Nhan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNhap_Thong_Tin_Nguoi_Nhan.CheckedChanged
        SetColumnInputData(dgE1_Di)
    End Sub
#End Region
#End Region
#End Region

#Region "=======================Control Grid======================="
#Region "------------------------SetLastColumnVisibleKey------------------------"
    Private Sub SetLastColumnVisibleKey(ByVal sender As Object)
        myGridKeyDown = sender
        Dim i As Integer
        For i = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            If myGridKeyDown.DisplayLayout.Bands(0).Columns(i).Hidden = False Then
                myLastColumnKey = myGridKeyDown.DisplayLayout.Bands(0).Columns(i).Key
            End If
        Next
    End Sub
#End Region

#Region "-----------------------Thêm dòng mới-----------------------"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                myGridKeyDown.Rows.Band.AddNew()
            End If
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "-----------------------Xóa dòng-----------------------"
    Private Sub Delete_E1(ByVal sender As Object, ByVal ActiveRowIndex As Integer) ', ByVal Khoi_Luong_BP As Integer)
        myGridKeyDown = sender
        Dim myRowIndex As Integer
        myRowIndex = myGridKeyDown.ActiveRow.Index
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã E1 trong bản kê E2 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Ghi Event: Xóa E1
                Event_Viewer_Delete_E1(2, Event_Viewer_Create_Chi_Tiet_E1(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_Duong_Thu").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Ngay_Dong").Text), myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myGridKeyDown.Rows(ActiveRowIndex).Cells("Ma_E1").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Khoi_Luong").Text), myGridKeyDown.Rows(ActiveRowIndex).Cells("Phan_Loai").Text), "")

                myE1_Di.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myE1_Le_Phi_Di.E1_Le_Phi_Di_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp và kho hải quan
                    myE1_Den_Tam.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)
                    'Tính lại Id_E1, Id_Duong_Thu,Id_E2,Id_Chuyen_Thu
                    myId_E1_Luu_Kho = CreateId_E1(myGridKeyDown.Rows(ActiveRowIndex).Cells("Ma_E1").Text, myId_E2_Luu_Kho, myGridKeyDown.Rows(ActiveRowIndex).Cells("Kien_So").Text) 'Tạo Id E1 mới
                    myE1_Den_Tam.Xoa(myId_E1_Luu_Kho)
                End If
                If chk_Kiem_Hoa.Checked = True Then 'Nếu đưa vào kiểm hóa
                    If myGridKeyDown.Rows(ActiveRowIndex).Cells("Phan_Loai").Text = "D" Then
                        myE1_Nhap_Kho_D.E1_Nhap_Kho_D_Xoa(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text)
                    End If
                End If

                myTrang_Thai.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myGridKeyDown.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If myGridKeyDown.Rows.Count = 0 Then
                    myGridKeyDown.Rows.Band.AddNew()
                    myCell = myGridKeyDown.Rows(0).Cells("Ma_E1")
                Else
                    myCell = myGridKeyDown.Rows(IIf(myRowIndex > 0, myRowIndex - 1, 0)).Cells("Ma_E1")
                End If
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        Else
            If (myGridKeyDown.ActiveRow.HasNextSibling = True) Then
                myGridKeyDown.ActiveRow.Delete(False)
                If myGridKeyDown.Rows.Count = 0 Then
                    myGridKeyDown.Rows.Band.AddNew()
                    myCell = myGridKeyDown.Rows(0).Cells("Ma_E1")
                Else
                    myCell = myGridKeyDown.Rows(IIf(myRowIndex > 0, myRowIndex - 1, 0)).Cells("Ma_E1")
                End If
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "-----------------------ReCalculate_Summary-----------------------"
    Private Sub ReCalculate_Summary(ByVal Sender As Object)
        myGridKeyDown = Sender
        Dim i As Integer
        Dim Tong_so As Integer
        Dim Tong_Khoi_Luong As Integer
        Tong_so = 0
        Tong_Khoi_Luong = 0
        For i = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(i).Cells("Ma_E1").Text <> "" Then
                Tong_so += 1
                Tong_Khoi_Luong += CInt(myGridKeyDown.Rows(i).Cells("Khoi_Luong").Text)
            End If
        Next
        txtInfor.Text = "Tổng Số    : " & Tong_so & vbNewLine & "Khối lượng : " & (Tong_Khoi_Luong / 1000) & "  KG"
    End Sub
#End Region

#Region "-----------------------dgE1_Di_InitializeLayout-----------------------"
    Private Sub dgE1_Di_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Di.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        With myGridKeyDown.DisplayLayout.Bands(0)
            'Sắp xếp theo STT
            .Columns("Ma_Bc_Goc").SortIndicator = SortIndicator.None
            .Columns("Nuoc_Nhan").SortIndicator = SortIndicator.None
            .Columns("Ma_E1").SortIndicator = SortIndicator.None
            .Columns("Nuoc_Tra").SortIndicator = SortIndicator.None
            .Columns("Ma_Bc_Tra").SortIndicator = SortIndicator.None
            .Columns("Khoi_Luong").SortIndicator = SortIndicator.None
            .Columns("Phan_Loai").SortIndicator = SortIndicator.None
            .Columns("Loai_Hang_Hoa").SortIndicator = SortIndicator.None
            .Columns("Ghi_Chu").SortIndicator = SortIndicator.None

            .Columns("STT").SortIndicator = SortIndicator.Ascending
            .HeaderVisible = False

            'Nuoc_Nhan
            .Columns("Nuoc_Nhan").Style = ColumnStyle.DropDownValidate
            .Columns("Nuoc_Nhan").ValueList = ddMa_Nuoc
            .Columns("Nuoc_Nhan").Hidden = False
            .Columns("Nuoc_Nhan").DefaultCellValue = "VN"
            'Nuoc_Tra
            .Columns("Nuoc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Nuoc_Tra").ValueList = ddMa_Nuoc
            .Columns("Nuoc_Tra").Hidden = True
            .Columns("Nuoc_Tra").DefaultCellValue = myMa_Nuoc_Di

            'Ma_Bc_Goc
            .Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Goc").ValueList = ddMa_BC
            .Columns("Ma_Bc_Goc").DefaultCellValue = 0
            .Columns("Ma_Bc_Goc").Hidden = True
            'Select Case myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
            '    Case 3 'Liên tỉnh liền kề
            '.Columns("Ma_Bc_Goc").DefaultCellValue = myDuong_Thu_Di_Chi_Tiet.Ma_Bc
            '    Case Else
            '.Columns("Ma_Bc_Goc").DefaultCellValue = 100000
            'End Select
            'Ma_Bc_Tra
            .Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Tra").ValueList = ddMa_BC_Tra
            .Columns("Ma_Bc_Tra").Hidden = False
            .Columns("Ma_Bc_Tra").DefaultCellValue = 100000 'myDuong_Thu_Di_Chi_Tiet.Ma_Bc
            'Ma_Bc_CH
            .Columns("Ma_Bc_CH").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_CH").ValueList = ddMa_BC_Tra
            'Phan_loai
            .Columns("Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Columns("Phan_Loai").ValueList = ddPhan_Loai_BP
            .Columns("Phan_Loai").DefaultCellValue = "D"
            '.Columns("Loai_Hang_Hoa").Hidden = True
            .Columns("Phan_Loai").Hidden = False

            'Loai
            .Columns("Loai").Style = ColumnStyle.DropDownValidate
            .Columns("Loai").ValueList = ddLoai_BP
            'Loai_Hang_Hoa
            .Columns("Loai_Hang_Hoa").Style = ColumnStyle.DropDownValidate
            .Columns("Loai_Hang_Hoa").ValueList = ddLoai_Hang_Hoa
            .Columns("Loai_Hang_Hoa").DefaultCellValue = 0

            'Loai
            .Columns("Loai").Hidden = True
            .Columns("Loai").DefaultCellValue = 0

            'Dv Cong them
            .Columns("Dv_Cong_Them").Style = ColumnStyle.DropDown
            .Columns("Dv_Cong_Them").ValueList = ddTo_Hop_DV_Cong_Them

            'Dv Gia Tang
            .Columns("Dv_Gia_Tang").Style = ColumnStyle.DropDown
            .Columns("Dv_Gia_Tang").ValueList = ddTo_Hop_DV_Gia_Tang

            'Id_Trang_Thai - Dung cho Phan loai ly do vao kho Hai quan
            .Columns("Id_Trang_Thai").Style = ColumnStyle.DropDownValidate
            .Columns("Id_Trang_Thai").ValueList = ddLy_Do
            'Thay doi gia tri theo loai duong thu
            If cbDuongThuDi.Tag = True Then 'Neu la luu kho Hai quan
                .Columns("Id_Trang_Thai").DefaultCellValue = 58
            Else 'Cac truong hop con lai
                .Columns("Id_Trang_Thai").DefaultCellValue = 0
            End If

            'Set DefaultValue
            'Các giá trị không thay đổi
            .Columns("Ngay_Dong").DefaultCellValue = myE2_Date
            .Columns("Gio_Dong").DefaultCellValue = myE2_Time
            .Columns("Ngay_Phat_Hanh").DefaultCellValue = myE2_Date
            .Columns("Gio_Phat_Hanh").DefaultCellValue = myE2_Time
            .Columns("Ngay_Nhan").DefaultCellValue = myE2_Date
            .Columns("Gio_Nhan").DefaultCellValue = myE2_Time

            .Columns("Id_Ca").DefaultCellValue = myId_Ca
            .Columns("Ma_Bc_Khai_Thac").DefaultCellValue = GBuu_Cuc_Khai_Thac
            .Columns("Id_Chuyen_Thu").DefaultCellValue = myId_Chuyen_Thu
            .Columns("Id_E2").DefaultCellValue = myId_E2
            .Columns("Id_Duong_Thu").DefaultCellValue = myId_Duong_Thu
            .Columns("Id_Nguoi_Dung").DefaultCellValue = myId_Nguoi_Dung
            .Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
            .Columns("Truyen_Khai_Thac").DefaultCellValue = CBool(0)
            .Columns("Chot_SL").DefaultCellValue = CBool(0)

            .Columns("Khoi_Luong").DefaultCellValue = 0
            .Columns("Khoi_Luong_QD").DefaultCellValue = 0
        End With
    End Sub
#End Region

#Region "-----------------------dgE1_Di_InitializeTemplateAddRow-----------------------"
    Private Sub dgE1_Di_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgE1_Di.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("COD").DefaultCellValue = CBool(0)
            .Columns("Gia_Tri_Hang").DefaultCellValue = 0
            .Columns("Cuoc_Giam").DefaultCellValue = 0
            .Columns("Cuoc_E1").DefaultCellValue = 0
            .Columns("Cuoc_COD").DefaultCellValue = 0
            .Columns("PPXD").DefaultCellValue = 0.0
            .Columns("Cuoc_PPXD").DefaultCellValue = 0
            .Columns("Cuoc_PPVX").DefaultCellValue = 0
            .Columns("VAT").DefaultCellValue = 0.0
            .Columns("Cuoc_Chinh").DefaultCellValue = 0
            .Columns("HH_Phat_Tra").DefaultCellValue = 0
            .Columns("HH_Phat_Hanh").DefaultCellValue = 0
            .Columns("Dv_Cong_Them").DefaultCellValue = ""
            .Columns("Dv_Gia_Tang").DefaultCellValue = ""
            .Columns("Cuoc_Dv").DefaultCellValue = 0
            .Columns("Ma_Bc_Ch").DefaultCellValue = 0

            '.Columns("Id_Trang_Thai").DefaultCellValue = 0
            'Thay doi gia tri theo loai duong thu
            If cbDuongThuDi.Tag = True Then  'Neu la luu kho Hai quan
                .Columns("Id_Trang_Thai").DefaultCellValue = 58
            Else    'Cac truong hop con lai
                .Columns("Id_Trang_Thai").DefaultCellValue = 0
            End If
            .Columns("Kien_So").DefaultCellValue = 0
            'Lệ phí hải quan
            .Columns("Le_Phi_HQ").DefaultCellValue = 0
            .Columns("Thue_NK_VAT").DefaultCellValue = 0
            .Columns("So_TKHQ").DefaultCellValue = ""
            .Columns("So_Bien_Lai").DefaultCellValue = ""
            'Thông tin người nhận
            .Columns("Nguoi_Gui").DefaultCellValue = ""
            .Columns("Dia_Chi_Gui").DefaultCellValue = ""
            .Columns("Dien_Thoai_Gui").DefaultCellValue = ""
            'Thông tin người trả
            .Columns("Nguoi_Nhan").DefaultCellValue = ""
            .Columns("Dia_Chi_Nhan").DefaultCellValue = ""
            .Columns("Dien_Thoai_Nhan").DefaultCellValue = ""

            .Columns("Ghi_Chu").DefaultCellValue = ""
            'Thông tin truyền
            .Columns("Truyen_Khai_Thac").DefaultCellValue = CBool(0)
            .Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
            .Columns("Chot_SL").DefaultCellValue = CBool(0)

            .Columns("Le_Phi_VH").DefaultCellValue = 0
            .Columns("Le_Phi_YT").DefaultCellValue = 0
            .Columns("Le_Phi_DV").DefaultCellValue = 0
            .Columns("Le_Phi_TV").DefaultCellValue = 0
            .Columns("Le_Phi_Khac").DefaultCellValue = 0
        End With
    End Sub
#End Region

#Region "-----------------------dgE1_Di_AfterCellActivate-----------------------"
    Private Sub dgE1_Di_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di.AfterCellActivate
        myGridKeyDown = sender
        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ma_E1"
                'Nếu chưa có dữ liệu thì myIsDaKiemTraTrung = False
                If (myGridKeyDown.ActiveCell.Text = "") Or (myGridKeyDown.ActiveCell.Text Is Nothing) Then
                    myIsDaKiemTraTrung = False
                Else
                    myIsDaKiemTraTrung = True
                End If
        End Select
    End Sub
#End Region

#Region "-----------------------dgE1_Di_KeyDown-----------------------"
    Private Sub dgE1_Di_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Di.KeyDown
        Try
            If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And Keys.Escape <> Keys.Escape And myCell Is Nothing Then Exit Sub
            myGridKeyDown = sender
            If (Not myCell Is Nothing) And (e.KeyValue <> Keys.Escape) Then
                e.Handled = True
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                myCell = Nothing
            End If
            Select Case e.KeyValue
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text <> "" And myGridKeyDown.ActiveCell.SelLength > 0 Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(NextCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(NextCellByTab, False, True)
                    End If
                Case Keys.Enter, Keys.Tab
                    Keys_Enter(sender, e)
                Case Keys.F8
                    Delete_E1(sender, myGridKeyDown.ActiveRow.Index)
                    e.Handled = True
                Case Keys.F1

                Case Keys.Left
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
                Case Keys.Escape
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    If myGridKeyDown.ActiveRow.Activated = True Then
                        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text = "" Then
                            Delete_E1(sender, myGridKeyDown.ActiveRow.Index)
                        End If
                    End If
                    e.Handled = True
                Case Keys.Up
                    If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
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
                    Select Case myGridKeyDown.ActiveCell.Column.Key
                        Case "Ma_Bc_Goc", "Nuoc_Nhan", "Nuoc_Tra", "Ma_Bc_Tra", "Phan_Loai", "Loai_Hang_Hoa", "Loai"
                            myGridKeyDown.ActiveCell.DroppedDown() = True
                        Case Else
                            If myGridKeyDown.ActiveRow.Index < myGridKeyDown.Rows.Count - 1 Then
                                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index + 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                                myGridKeyDown.ActiveCell = myCell
                                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                            End If
                    End Select
                Case Keys.Home
                    If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(FirstCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Case Keys.End
                    If myGridKeyDown.ActiveCell.Activation.NoEdit = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Selected = True Or myGridKeyDown.ActiveCell.Text = "" Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(LastCellInRow, False, True)
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(LastCellInRow, False, True)
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
            End Select
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Keys_Enter-----------------------"
    Private Sub Keys_Enter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        myGridKeyDown = sender
        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ma_Bc_Goc"
                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                End If
            Case "Nuoc_Nhan"
                If myGridKeyDown.ActiveCell.Text = "VN" Then
                    If myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text = 0 Then
                        e.Handled = False
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                        Exit Sub
                    End If
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = True
                End If
            Case "Ma_Bc_Tra"
                If Kiem_Tra_Lac_Huong(sender, myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)) = True Then  'Lạc hướng
                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    myCell = myGridKeyDown.ActiveCell
                    myCell.SelStart = 0
                    myCell.SelLength = myCell.Text.Length
                    Exit Sub
                End If
                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                End If
            Case "Nuoc_Tra"
                If Kiem_Tra_Lac_Huong(sender, myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)) = True Then  'Lạc hướng
                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    myCell = myGridKeyDown.ActiveCell
                    myCell.SelStart = 0
                    myCell.SelLength = myCell.Text.Length
                    Exit Sub
                    'If MessageBox.Show("    Bưu phẩm lạc hướng!!!" & vbNewLine & _
                    '                    "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    '    myCell = myGridKeyDown.ActiveCell
                    '    myCell.SelStart = 0
                    '    myCell.SelLength = myCell.Text.Length
                    '    Exit Sub
                    'End If
                End If
                If myGridKeyDown.ActiveCell.Text = "VN" Then 'Hàng quốc tế
                    e.Handled = False
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                    Exit Sub
                End If
            Case "Ma_E1"
                myIsTrungSoLieu = False
                myIsChoPhepTrung = False
                myMAE1Thoat = False
                'Kiểm tra nếu Ma_E1 không có thì không cho phép đi qua
                If (myGridKeyDown.ActiveCell.Text = "") Or (myGridKeyDown.ActiveCell.Text Is Nothing) Then
                    myCell = myGridKeyDown.ActiveCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
                'Kiểm tra sự thay đổi của mã e1
                If (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text <> "") And _
                            (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text = _
                                CreateId_E1(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text, _
                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E2").Text, _
                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Text)) Then
                    Exit Select
                End If
                Dim MAE1 As String
                'Kiểm tra định dạng 13 ký tự của Ma_E1
                If myGridKeyDown.ActiveCell.Text.Length > 13 Then
                    MessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    GoTo StopHere
                    Exit Sub
                End If
                'Kiểm tra điều kiện: đúng với code 39 của Ma_E1
                MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                If (myHam_Dung_Chung.Check_E1(MAE1, chkE1UPUS10.Checked) = False) Then
                    MessageBox.Show("Số hiệu E1 này không có thật !!! ", "Thông báo", MessageBoxButtons.OK)
                    GoTo StopHere
                    Exit Sub
                End If

                'Kiểm tra mã nước có trong danh mục các mã nước không
                If myMaNuoc.Lay(MAE1.Substring(11, 2)).Ten_Nuoc = "" Then
                    If MessageBox.Show("Mã nước nhận không tồn tại trong bảng danh mục mã nước!!!" & vbNewLine & _
                                        "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        GoTo StopHere
                        Exit Sub
                    End If
                End If

                'Gán biến kiểm tra trùng
                myIsDaKiemTraTrung = True

                'Kiểm tra dữ liệu trùng
                Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                'Kiểm tra trùng dữ liệu trong cùng bản kê E2
                myE1_Di_Chi_Tiet = Nothing
                myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT(MAE1, myId_E2)
                If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveCell.Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                    txtThongTin.ForeColor = Color.Red
                    GoTo StopHere
                Else
                    txtThongTin.ForeColor = Color.Black
                End If

                'Kiểm tra trùng số hiệu bưu phẩm trong cùng chuyến thư: không cho phép trùng
                myE1_Di_Chi_Tiet = Nothing
                myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(MAE1, myId_Chuyen_Thu)
                If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveCell.Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                    MessageBox.Show("Trùng dữ liệu trong cùng chuyến thư, bạn không được phép nhập tiếp!!!", "Thông báo", MessageBoxButtons.OK)
                    GoTo StopHere
                End If
                'Kiểm tra trùng trong cùng 1 ca làm việc của bưu cục khai thác đó -> có thể trùng
                myE1_Di_Chi_Tiet = Nothing
                'Clear giá trị trước đó

                myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong ca khai thác
                    myIsTrungSoLieu = True
                    If MessageBox.Show("Số hiệu E1 này đã được đóng đi trong ca khai thác này!!!" & vbNewLine & _
                                            "        Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        myIsChoPhepTrung = False
                        myIsDaKiemTraTrung = False
                        GoTo StopHere
                    Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                        'Kiểm tra lạc hướng
                        If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                            MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            myIsDaKiemTraTrung = False
                            myIsChoPhepTrung = False
                            GoTo StopHere
                        End If
                        myIsDaKiemTraTrung = True
                        myIsChoPhepTrung = True
                        Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                    End If
                Else 'Nếu không có dữ liệu trùng trong ca
                    'Kiểm tra dữ liệu xác nhận đến
                    Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                    'Kiểm tra dữ liệu xác nhận đến trong cùng ca
                    myE1_Den_Chi_Tiet = Nothing
                    myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT(MAE1, myId_Ca)
                    If myE1_Den_Chi_Tiet.Id_E1 = "" Then 'Không có dữ liệu xác nhận đến
                        If Not (GOutBout = 2) Then 'Nếu không phải là lưu kho hải quan
                            'Không cho phép tiếp tục nếu không phải là quản trị tuyệt đối
                            If GUserAdmin Then 'Nếu là quyền quản trị tuyệt đối
                                If MessageBox.Show("Dữ liệu chưa được xác nhận đến trong ca này!!!" & vbNewLine & _
                                                    "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                    myIsDaKiemTraTrung = False
                                    GoTo StopHere
                                Else
                                    'Nếu các ngày trước đó không có dữ liệu xác nhận đến
                                    myIsXacNhanDen = False
                                    myIsDaKiemTraTrung = True
                                    'Kiểm tra trùng trong khoảng thời gian
                                    myE1_Di_Chi_Tiet = Nothing
                                    myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                    If myE1_Di_Chi_Tiet.Id_E1 <> "" Then 'Nếu trùng dữ liệu
                                        If MessageBox.Show("Trùng dữ liệu,bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            myIsDaKiemTraTrung = False
                                            GoTo StopHere
                                        Else 'Lấy dữ liệu trùng vào biến
                                            'Kiểm tra lạc hướng
                                            If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                myIsDaKiemTraTrung = False
                                                myIsChoPhepTrung = False
                                                GoTo StopHere
                                                'If MessageBox.Show("    Bưu phẩm lạc hướng!!!" & vbNewLine & _
                                                '                    "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                                '    myIsDaKiemTraTrung = False
                                                '    myIsChoPhepTrung = False
                                                '    GoTo StopHere
                                                'End If
                                            End If
                                            myIsDaKiemTraTrung = True
                                            myIsTrungSoLieu = True
                                            myIsChoPhepTrung = True
                                            Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                                        End If
                                    Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                        myIsTrungSoLieu = False
                                        myIsDaKiemTraTrung = False
                                    End If
                                End If
                            Else
                                MessageBox.Show("Dữ liệu chưa được xác nhận đến trong ca này!!!" & vbNewLine _
                                                & "Bạn hãy xác nhận đến trước khi đóng đi.", "Thông báo", MessageBoxButtons.OK)
                                myIsDaKiemTraTrung = False
                                GoTo StopHere
                            End If
                        Else 'Lưu kho hải quan
                            'Nếu muốn tiếp tục -> kiểm tra dữ liệu xác nhận đến trong các ngày trước đó
                            myE1_Den_Chi_Tiet = Nothing
                            myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                            If myE1_Den_Chi_Tiet.Id_E1 = "" Then
                                'Neu chua co du lieu xac nhan den thi khong cho dong di (tru quyen quan tri tuyet doi)
                                If GUserAdmin Then
                                    If MessageBox.Show("Dữ liệu chưa được xác nhận đến !!!" & vbNewLine & _
                                                     "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                        myIsDaKiemTraTrung = False
                                        GoTo StopHere
                                    End If
                                Else
                                    MessageBox.Show("Dữ liệu chưa được xác nhận đến !!!" & vbNewLine _
                                                & "Bạn hãy xác nhận đến trước khi đóng đi.", "Thông báo", MessageBoxButtons.OK)
                                    myIsDaKiemTraTrung = False
                                    GoTo StopHere
                                End If

                                'Nếu không có dữ liệu xác nhận đến trong các ca trước đó
                                'Kiểm tra dữ liệu trùng -> lấy ra giá trị trùng nếu muốn
                                'Kiểm tra trùng trong khoảng thời gian
                                myE1_Di_Chi_Tiet = Nothing
                                myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                If myE1_Di_Chi_Tiet.Id_E1 <> "" Then 'Nếu trùng dữ liệu
                                    If MessageBox.Show("Trùng dữ liệu,bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                        myIsDaKiemTraTrung = False
                                        GoTo StopHere
                                    Else 'Lấy dữ liệu trùng vào biến
                                        'Kiểm tra lạc hướng
                                        If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                            MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            myIsDaKiemTraTrung = False
                                            myIsChoPhepTrung = False
                                            GoTo StopHere
                                        End If
                                        myIsDaKiemTraTrung = True
                                        myIsTrungSoLieu = True
                                        myIsChoPhepTrung = True
                                        Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                                    End If
                                Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                    myIsTrungSoLieu = False
                                    myIsDaKiemTraTrung = False
                                End If
                            Else
                                'Lấy dữ liệu xác nhận đến trong các ca trước
                                'Kiểm tra lạc hướng
                                If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    myIsDaKiemTraTrung = False
                                    myIsChoPhepTrung = False
                                    GoTo StopHere
                                End If
                                myIsXacNhanDen = True
                                myIsDaKiemTraTrung = True
                                Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet)
                            End If
                        End If
                    Else 'Có dữ liệu xác nhận đến-> lấy dữ liệu xác nhận đến trong ca
                        'Kiểm tra lạc hướng
                        If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                            MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            myIsDaKiemTraTrung = False
                            myIsChoPhepTrung = False
                            GoTo StopHere
                            'If MessageBox.Show("    Bưu phẩm lạc hướng!!!" & vbNewLine & _
                            '                    "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            '    myIsDaKiemTraTrung = False
                            '    myIsXacNhanDen = False
                            '    GoTo StopHere
                            'End If
                        End If
                        myIsDaKiemTraTrung = True
                        myIsXacNhanDen = True
                        Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet)
                    End If
                End If

                myMAE1Thoat = True
                e.Handled = False
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                If myIsTrungSoLieu = True Or myIsXacNhanDen = True Then 'Nếu trùng số liệu thì cho phép nhảy xuống dòng tiếp theo
                    If myColumnInputData = "" Then 'Nhảy xuống dòng tiếp theo
                        If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                            myGridKeyDown.Rows.Band.AddNew()
                        End If
                        myCell = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1")
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Else
                        myCell = myGridKeyDown.ActiveRow.Cells(myColumnInputData)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                Else
                    myGridKeyDown.PerformAction(NextCellByTab, False, True)
                End If
                Exit Sub

StopHere:       'Không cho phép thoát khỏi cell hiện tại
                myCell = myGridKeyDown.ActiveCell
                myCell.SelStart = 0
                myCell.SelLength = myCell.Text.Length
                Exit Sub
            Case "Khoi_Luong"
                If myGridKeyDown.ActiveCell.Text = "" Then
                    MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                    Exit Sub
                Else
                    If IsNumeric(Trim(myGridKeyDown.ActiveCell.Text)) = False Then 'Kiểm tra định dạng
                        MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK)
                        Exit Sub
                    Else
                        If CInt(myGridKeyDown.ActiveCell.Text) = 0 Then
                            MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                            Exit Sub
                        End If
                    End If
                End If
        End Select
        'Sang cột tiếp theo
        If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            AddNewRow(sender)
        End If
        e.Handled = False
        myGridKeyDown.PerformAction(EnterEditMode, False, False)
        myGridKeyDown.PerformAction(NextCellByTab, False, True)
    End Sub
#End Region

#Region "-----------------------dgE1_Di_BeforeCellDeactivate-----------------------"
    Private Sub dgE1_Di_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Di.BeforeCellDeactivate
        Try
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.ActiveCell.Text = "" Then
                        Exit Sub
                    End If
                    Dim MAE1 As String
                    If myGridKeyDown.ActiveCell.Text.Length > 13 Then
                        MessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                    MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                    If (myHam_Dung_Chung.Check_E1(MAE1, chkE1UPUS10.Checked) = False) Then
                        MessageBox.Show("Số hiệu E1 này không có thật !!! ", "Thông báo", MessageBoxButtons.OK)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                    'Nếu chưa được kiểm tra trùng trong sự kiện Keys_Enter thì kiểm tra trùng
                    If myIsDaKiemTraTrung = False Then
                        'Kiểm tra mã nước có trong danh mục các mã nước không
                        If myMaNuoc.Lay(MAE1.Substring(11, 2)).Ten_Nuoc = "" Then
                            If MessageBox.Show("Mã nước nhận không tồn tại trong bảng danh mục mã nước!!!" & vbNewLine & _
                                                "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                Exit Sub
                            End If
                        End If
                        'Kiểm tra điều kiện trùng trong lưới: chưa kiểm tra điều kiện với trường hợp là hàng 1 vận đơn

                        Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
                        'Kiểm tra trùng dữ liệu trong cùng bản kê E2
                        myE1_Di_Chi_Tiet = Nothing
                        myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_E2_KT(MAE1, myId_E2)
                        If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveCell.Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If

                        'Kiểm tra trùng số hiệu bưu phẩm trong cùng chuyến thư: không cho phép trùng
                        myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(MAE1, myId_Chuyen_Thu)
                        If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            MessageBox.Show("Trùng dữ liệu trong cùng chuyến thư, bạn không được phép nhập tiếp", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If

                        'Kiểm tra trùng trong cùng 1 ca làm việc của bưu cục khai thác đó -> có thể trùng
                        myE1_Di_Chi_Tiet = Nothing
                        'Clear giá trị trước đó
                        'myE1_Di_Chi_Tiet_Trung = Nothing
                        'myE1_Den_Chi_Tiet_XN_Trung = Nothing

                        myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                        If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong ca khai thác
                            myIsTrungSoLieu = True
                            If MessageBox.Show("Số hiệu E1 này đã được đóng đi trong ca khai thác này!!!" & vbNewLine & _
                                                    "        Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                myIsChoPhepTrung = False
                                Exit Sub
                            Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                                'Kiểm tra lạc hướng
                                If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    myIsChoPhepTrung = False
                                    e.Cancel = True
                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    Exit Sub
                                End If
                                myIsChoPhepTrung = True
                                Me.Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                            End If
                        Else 'Nếu không có dữ liệu trùng trong ca
                            'Kiểm tra dữ liệu xác nhận đến
                            Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                            'Kiểm tra dữ liệu xác nhận đến trong cùng ca
                            myE1_Den_Chi_Tiet = Nothing
                            myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Du_Lieu_Xac_Nhan_Den_KT(MAE1, myId_Ca)
                            If myE1_Den_Chi_Tiet.Id_E1 = "" Then 'Không có dữ liệu xác nhận đến
                                If Not (GOutBout = 2) Then 'Nếu không phải là lưu kho hải quan
                                    'Không cho phép tiếp tục nếu không phải là quản trị tuyệt đối
                                    If GUserAdmin Then 'Nếu là quyền quản trị tuyệt đối
                                        If MessageBox.Show("Dữ liệu chưa được xác nhận đến trong ca này!!!" & vbNewLine & _
                                                            "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                            myIsChoPhepTrung = False
                                            Exit Sub
                                        Else
                                            myIsXacNhanDen = False
                                            'Kiểm tra trùng trong khoảng thời gian
                                            myE1_Di_Chi_Tiet = Nothing
                                            myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                            If myE1_Di_Chi_Tiet.Id_E1 <> "" Then 'Nếu trùng dữ liệu
                                                If MessageBox.Show("Trùng dữ liệu,bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                                    myIsDaKiemTraTrung = False
                                                    e.Cancel = True
                                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                    Exit Sub
                                                Else 'Lấy dữ liệu trùng vào biến
                                                    'Kiểm tra lạc hướng
                                                    If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                        MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                        myIsChoPhepTrung = False
                                                        e.Cancel = True
                                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                        Exit Sub
                                                    End If
                                                    myIsDaKiemTraTrung = True
                                                    myIsTrungSoLieu = True
                                                    myIsChoPhepTrung = True
                                                    Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                                                End If
                                            Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                                myIsTrungSoLieu = False
                                                myIsDaKiemTraTrung = False
                                            End If
                                        End If
                                    Else
                                        MessageBox.Show("Dữ liệu chưa được xác nhận đến trong ca này!!!" & vbNewLine _
                                                        & "Bạn hãy xác nhận đến trước khi đóng đi.", "Thông báo", MessageBoxButtons.OK)
                                        e.Cancel = True
                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                        myIsChoPhepTrung = False
                                        Exit Sub
                                    End If
                                Else 'Lưu kho hải quan
                                    'Nếu muốn tiếp tục -> kiểm tra dữ liệu xác nhận đến trong các ngày trước đó
                                    myE1_Den_Chi_Tiet = Nothing
                                    myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                    If myE1_Den_Chi_Tiet.Id_E1 = "" Then
                                        'Neu chua co du lieu xac nhan den thi khong cho dong di (tru quyen quan tri tuyet doi)
                                        If GUserAdmin Then
                                            If MessageBox.Show("Dữ liệu chưa được xác nhận đến !!!" & vbNewLine & _
                                                             "      Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                                e.Cancel = True
                                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                Exit Sub
                                            End If
                                        Else
                                            MessageBox.Show("Dữ liệu chưa được xác nhận đến !!!" & vbNewLine _
                                                        & "Bạn hãy xác nhận đến trước khi đóng đi.", "Thông báo", MessageBoxButtons.OK)
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                            Exit Sub
                                        End If
                                        'Nếu không có dữ liệu xác nhận đến trong các ca trước đó
                                        'Kiểm tra trùng trong khoảng thời gian
                                        myE1_Di_Chi_Tiet = Nothing
                                        myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                        If myE1_Di_Chi_Tiet.Id_E1 <> "" Then 'Nếu trùng dữ liệu
                                            If MessageBox.Show("Trùng dữ liệu,bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                                myIsDaKiemTraTrung = False
                                                e.Cancel = True
                                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                Exit Sub
                                            Else 'Lấy dữ liệu trùng vào biến
                                                'Kiểm tra lạc hướng
                                                If Kiem_Tra_Lac_Huong(sender, myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    myIsChoPhepTrung = False
                                                    e.Cancel = True
                                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                    Exit Sub
                                                End If
                                                myIsDaKiemTraTrung = True
                                                myIsTrungSoLieu = True
                                                myIsChoPhepTrung = True
                                                Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet) 'Gán giá trị trùng vào biến
                                            End If
                                        Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                            myIsTrungSoLieu = False
                                            myIsDaKiemTraTrung = False
                                        End If
                                    Else
                                        'Lấy dữ liệu xác nhận đến trong các ca trước
                                        'Kiểm tra lạc hướng
                                        If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                            MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            myIsChoPhepTrung = False
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                            Exit Sub
                                        End If
                                        myIsXacNhanDen = True
                                        Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet)
                                    End If
                                End If
                            Else 'Có dữ liệu xác nhận đến-> lấy dữ liệu xác nhận đến trong ca
                                'Kiểm tra lạc hướng
                                If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    myIsChoPhepTrung = False
                                    e.Cancel = True
                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    Exit Sub
                                End If
                                myIsXacNhanDen = True
                                Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet)
                            End If
                        End If
                    End If
                Case "Ma_Bc_Tra"
                    'Kiểm tra lạc hướng
                    If Kiem_Tra_Lac_Huong(sender, _
                                         myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                         myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text) = True Then 'Lạc hướng
                        MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Case "Nuoc_Tra"
                    'Kiểm tra lạc hướng
                    If Kiem_Tra_Lac_Huong(sender, _
                                         myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                         myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text) = True Then 'Lạc hướng
                        MessageBox.Show("Bưu phẩm lạc hướng!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Case "Khoi_Luong"
                    If myGridKeyDown.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                        If myGridKeyDown.ActiveCell.Text = "" Then
                            MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        ElseIf IsNumeric(myGridKeyDown.ActiveCell.Text) = False Then                          'Kiểm tra định dạng
                            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        ElseIf CInt(myGridKeyDown.ActiveCell.Text) = 0 Then
                            MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        ElseIf CInt(myGridKeyDown.ActiveCell.Text) > GTrong_Luong_E1_Max Then
                            MessageBox.Show("Khối lượng không được vượt quá " & GTrong_Luong_E1_Max.ToString & " g", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        End If
                    End If
                Case Else
            End Select
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Kiểm tra lạc hướng-----------------------"
    'Kiểm tra bưu phẩm lạc hướng
    'Nếu Mã nước theo đường thư là quốc tế: Kiểm tra nước trả
    'Nếu Mã nước theo đường thư là VN: Kiểm tra mã tỉnh theo đường thư với Mã bưu cục trả
    Private Function Kiem_Tra_Lac_Huong(ByVal sender As Object, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer) As Boolean
        Try
            myGridKeyDown = sender
            If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text <> "" Then 'Chỉ kiểm tra điều kiện trong lần đầu tiên
                Return False
                Exit Function
            End If
            If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then 'Chỉ kiểm tra điều kiện trong lần đầu tiên
                Return False
                Exit Function
            End If
            If myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = False Then 'Kiểm tra lạc hướng nếu đường thư không phải là chuyển tiếp
                'Kiểm tra thông tin đường thư: nước đến, tỉnh đến
                'Kiểm tra lạc hướng với các đường thư trong nước
                If myMa_Nuoc_Theo_Duong_Thu.ToUpper = "VN" Then
                    'Kiểm tra lạc hướng theo từng mã tỉnh
                    If myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(Ma_Bc_Tra).Ma_Tinh Then
                        'Không lạc hướng
                        Return False
                    Else 'Lạc hướng
                        Return True
                    End If
                Else 'Nếu là đường thư nước ngoài
                    If myMa_Nuoc_Theo_Duong_Thu.ToUpper = Nuoc_Tra.ToUpper Then
                        Return False 'Không lạc hướng
                    Else 'Lạc hướng
                        Return True
                    End If
                End If
            Else 'Không kiểm tra lạc hướng
                Return False
            End If
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "-----------------------Gán giá trị trùng vào biến-----------------------"
    Private Function Gan_Gia_Tri_Trung_Vao_Bien(ByVal m_E1_Di_Chi_Tiet As E1_Di_Chi_Tiet) As Boolean
        Try
            If m_E1_Di_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Di_Chi_Tiet_Trung 'Lấy giá trị chi tiết vào biến
                    .Id_E1 = m_E1_Di_Chi_Tiet.Id_E1
                    .Ngay_Phat_Hanh = m_E1_Di_Chi_Tiet.Ngay_Phat_Hanh
                    .Gio_Phat_Hanh = m_E1_Di_Chi_Tiet.Gio_Phat_Hanh
                    .Ma_Bc_Goc = m_E1_Di_Chi_Tiet.Ma_Bc_Goc
                    .Ma_Don_Vi = m_E1_Di_Chi_Tiet.Ma_Don_Vi
                    .Ma_Bc_Tra = m_E1_Di_Chi_Tiet.Ma_Bc_Tra
                    .Nuoc_Nhan = m_E1_Di_Chi_Tiet.Nuoc_Nhan
                    .Nuoc_Tra = m_E1_Di_Chi_Tiet.Nuoc_Tra
                    .Khoi_Luong = m_E1_Di_Chi_Tiet.Khoi_Luong
                    .Phan_Loai = m_E1_Di_Chi_Tiet.Phan_Loai
                    .Loai_Hang_Hoa = m_E1_Di_Chi_Tiet.Loai_Hang_Hoa
                    .Khoi_Luong_QD = IIf(m_E1_Di_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Di_Chi_Tiet.Khoi_Luong, m_E1_Di_Chi_Tiet.Khoi_Luong_QD)
                    .Loai = m_E1_Di_Chi_Tiet.Loai
                    .PPXD = m_E1_Di_Chi_Tiet.PPXD
                    .Cuoc_PPXD = m_E1_Di_Chi_Tiet.Cuoc_PPXD
                    .PostCode = m_E1_Di_Chi_Tiet.PostCode
                    .Cuoc_PPVX = m_E1_Di_Chi_Tiet.Cuoc_PPVX
                    .VAT = m_E1_Di_Chi_Tiet.VAT
                    .COD = m_E1_Di_Chi_Tiet.COD
                    .Gia_Tri_Hang = m_E1_Di_Chi_Tiet.Gia_Tri_Hang
                    .Cuoc_Giam = m_E1_Di_Chi_Tiet.Cuoc_Giam
                    .Ghi_Chu = m_E1_Di_Chi_Tiet.Ghi_Chu
                    .Nguoi_Gui = m_E1_Di_Chi_Tiet.Nguoi_Gui
                    .Nguoi_Nhan = m_E1_Di_Chi_Tiet.Nguoi_Nhan
                    .Dia_Chi_Gui = m_E1_Di_Chi_Tiet.Dia_Chi_Gui
                    .Dia_Chi_Nhan = m_E1_Di_Chi_Tiet.Dia_Chi_Nhan
                    .Dien_Thoai_Nhan = m_E1_Di_Chi_Tiet.Dien_Thoai_Nhan
                    .Kien_So = m_E1_Di_Chi_Tiet.Kien_So
                    .Ma_Bc_CH = m_E1_Di_Chi_Tiet.Ma_Bc_CH
                    .Cuoc_Chinh = m_E1_Di_Chi_Tiet.Cuoc_Chinh
                    .Cuoc_E1 = m_E1_Di_Chi_Tiet.Cuoc_E1
                    .Cuoc_COD = m_E1_Di_Chi_Tiet.Cuoc_COD
                    .Dv_Cong_Them = m_E1_Di_Chi_Tiet.Dv_Cong_Them
                    .Dv_Gia_Tang = m_E1_Di_Chi_Tiet.Dv_Gia_Tang
                    .Cuoc_DV = m_E1_Di_Chi_Tiet.Cuoc_DV
                    .Ma_Bc_CH = m_E1_Di_Chi_Tiet.Ma_Bc_CH
                    .HH_Phat_Tra = m_E1_Di_Chi_Tiet.HH_Phat_Tra
                    .HH_Phat_Hanh = m_E1_Di_Chi_Tiet.HH_Phat_Hanh
                End With
                Return True
            Else
                myE1_Di_Chi_Tiet_Trung = Nothing
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------------Gán giá xác nhận đến vào biến-----------------------"
    Private Function Gan_Gia_Tri_Xac_Nhan_Vao_Bien(ByVal m_E1_Den_Chi_Tiet As E1_Den_Chi_Tiet) As Boolean
        Try
            If m_E1_Den_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Den_Chi_Tiet_XN_Trung 'Lấy giá trị xác nhận đến chi tiết vào biến
                    .Id_E1 = m_E1_Den_Chi_Tiet.Id_E1
                    .Ngay_Phat_Hanh = m_E1_Den_Chi_Tiet.Ngay_Phat_Hanh
                    .Gio_Phat_Hanh = m_E1_Den_Chi_Tiet.Gio_Phat_Hanh
                    .Ma_Bc_Goc = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                    .Ma_Don_Vi = m_E1_Den_Chi_Tiet.Ma_Don_Vi
                    .Ma_Bc_Tra = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                    .Nuoc_Nhan = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                    .Nuoc_Tra = m_E1_Den_Chi_Tiet.Nuoc_Tra
                    .Khoi_Luong = m_E1_Den_Chi_Tiet.Khoi_Luong
                    .Phan_Loai = m_E1_Den_Chi_Tiet.Phan_Loai
                    .Loai_Hang_Hoa = m_E1_Den_Chi_Tiet.Loai_Hang_Hoa
                    .Khoi_Luong_QD = IIf(m_E1_Den_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Den_Chi_Tiet.Khoi_Luong, m_E1_Den_Chi_Tiet.Khoi_Luong_QD)
                    .Loai = m_E1_Den_Chi_Tiet.Loai
                    .PPXD = m_E1_Den_Chi_Tiet.PPXD
                    .Cuoc_PPXD = m_E1_Den_Chi_Tiet.Cuoc_PPXD
                    .PostCode = m_E1_Den_Chi_Tiet.PostCode
                    .Cuoc_PPVX = m_E1_Den_Chi_Tiet.Cuoc_PPVX
                    .VAT = m_E1_Den_Chi_Tiet.VAT
                    .COD = m_E1_Den_Chi_Tiet.COD
                    .Gia_Tri_Hang = m_E1_Den_Chi_Tiet.Gia_Tri_Hang
                    .Cuoc_Giam = m_E1_Den_Chi_Tiet.Cuoc_Giam
                    .Ghi_Chu = m_E1_Den_Chi_Tiet.Ghi_Chu
                    .Nguoi_Gui = m_E1_Den_Chi_Tiet.Nguoi_Gui
                    .Nguoi_Nhan = m_E1_Den_Chi_Tiet.Nguoi_Nhan
                    .Dia_Chi_Gui = m_E1_Den_Chi_Tiet.Dia_Chi_Gui
                    .Dia_Chi_Nhan = m_E1_Den_Chi_Tiet.Dia_Chi_Nhan
                    .Dien_Thoai_Nhan = m_E1_Den_Chi_Tiet.Dien_Thoai_Nhan
                    .Kien_So = m_E1_Den_Chi_Tiet.Kien_So
                    .Ma_Bc_CH = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                    .Cuoc_Chinh = m_E1_Den_Chi_Tiet.Cuoc_Chinh
                    .Cuoc_E1 = m_E1_Den_Chi_Tiet.Cuoc_E1
                    .Cuoc_COD = m_E1_Den_Chi_Tiet.Cuoc_COD
                    .Dv_Cong_Them = m_E1_Den_Chi_Tiet.Dv_Cong_Them
                    .Dv_Gia_Tang = m_E1_Den_Chi_Tiet.Dv_Gia_Tang
                    .Cuoc_DV = m_E1_Den_Chi_Tiet.Cuoc_DV
                    .Ma_Bc_CH = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                    .HH_Phat_Tra = m_E1_Den_Chi_Tiet.HH_Phat_Tra
                    .HH_Phat_Hanh = m_E1_Den_Chi_Tiet.HH_Phat_Hanh
                End With
                Return True
            Else
                myE1_Den_Chi_Tiet_XN_Trung = Nothing
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------------dgE1_Di_AfterExitEditMode-----------------------"
    Private Sub dgE1_Di_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If Not myGridKeyDown.ActiveCell.Text Is Nothing Then
                Select Case myGridKeyDown.ActiveCell.Column.Key
                    Case "Ma_E1"
                        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
                            Exit Sub
                        End If
                        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" And _
                            myGridKeyDown.ActiveRow.Cells("Id_E1").Text = _
                            CreateId_E1(GetCorrectMAE1(myGridKeyDown.ActiveRow.Cells("Ma_E1").Text, _
                                        myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                        myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text), _
                                        myGridKeyDown.ActiveRow.Cells("Id_E2").Text, _
                                        myGridKeyDown.ActiveRow.Cells("Kien_So").Text) Then
                            'Nếu không có sự thay đổi mã e1
                            GoTo Thoat
                        End If

                        Dim MAE1 As String
                        If E1_AfterUpdate(myGridKeyDown) = True Then
                            Update_Cuoc(sender)
                        End If
                        MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Value, myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
                        myGridKeyDown.ActiveCell.Value = MAE1

                        If myIsXacNhanDen Then 'Nếu đã xác nhận đến
                            Gan_Gia_Tri_Xac_Nhan_Den_Vao_Luoi(sender, myE1_Den_Chi_Tiet_XN_Trung)
                        Else 'Nếu chưa xác nhận đến
                            'Nếu cho phép trùng thì mới tiếp tục
                            If myIsTrungSoLieu = True And myIsChoPhepTrung = True Then
                                Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi(myE1_Di_Chi_Tiet_Trung)
                            End If
                        End If
Thoat:
                        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "" Then
                            If myIsXacNhanDen Then
                                myGridKeyDown.Rows.Band.AddNew()
                            End If
                        End If
                    Case "Ma_Bc_Goc"
                        If myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text = 0 Then
                            myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Value = "0"
                        Else
                            myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Value = Tim_Danh_Muc_BC_Tu_Ma_Bc(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text).Ma_Don_Vi
                            myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Value = "VN"
                        End If
                        Update_Cuoc(sender)
                    Case "Nuoc_Nhan"
                        If myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text <> "VN" Then
                            myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Value = "0"
                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Value = "0"
                        Else
                            myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Value = Tim_Danh_Muc_BC_Tu_Ma_Bc(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text).Ma_Don_Vi
                        End If
                        Nuoc_Nhan_AfterUpdate(sender)
                    Case "Ma_Bc_Tra"
                        If myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text <> 0 Then
                            myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Value = "VN"
                            ''Tim Ma_Tinh_Tra
                            'Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                            'myGridKeyDown.ActiveRow.Cells("Ma_Tinh_Tra").Value = myDanh_Muc_Bc.Lay(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text).Ma_Tinh
                        End If
                        Update_Cuoc(sender)
                    Case "Nuoc_Tra"
                        If myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text <> "VN" Then
                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Value = "0"
                            'myGridKeyDown.ActiveRow.Cells("Ma_Tinh_Tra").Value = "0"
                        End If
                        If (myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text) _
                              And (myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text <> "VN") Then
                            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = False
                        End If
                        'Case "Ma_Bc_CH"
                        '    Update_Cuoc(sender)
                        '    myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Value = _
                        '                        IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text & ",") & _
                        '                        IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Gia_Tang").Text & ",") & _
                        '                        IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                        '                        IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 0, "", IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 1, "Su Vu", "TT"))
                    Case "Phan_Loai"
                        Update_Cuoc(sender)
                    Case "Khoi_Luong"
                        If CInt(myGridKeyDown.ActiveCell.Text) > 0 Then
                            If (myGridKeyDown.ActiveRow.Cells("Loai_Hang_Hoa").Value <> 1) Then 'Nếu không phải là hàng nhẹ
                                myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Value = myGridKeyDown.ActiveCell.Value
                            End If
                            'Tính cước chính bằng Khối lượng QD
                            Update_Cuoc(sender)
                        End If
                    Case "Loai_Hang_Hoa" 'Tính lại cước bằng khối lượng quy đổi
                        If myGridKeyDown.ActiveCell.Text = 1 Then 'Hàng nhẹ
                            If myGridKeyDown.ActiveCell.Value = 1 Then 'Hàng nhẹ
                                'Xuất hiện Form nhập kích thước
                                Dim Frm As New FrmTinh_Hang_Nhe
                                Frm.ShowDialog()
                                If Frm.txtKet_Qua.Text <> 0 Then
                                    myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Value = CInt(Frm.txtKet_Qua.Text)
                                End If
                            End If
                        Else
                            myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Value = myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Value
                        End If
                        Update_Cuoc(sender)
                    Case "Dv_Cong_Them"
                        Update_Cuoc(sender)
                        myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Value = _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Gia_Tang").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 0, "", IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 1, "Su Vu", "TT"))
                    Case "Dv_Gia_Tang"
                        Update_Cuoc(sender)
                        myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Value = _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Gia_Tang").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 0, "", IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 1, "Su Vu", "TT"))
                    Case "Loai"
                        Update_Cuoc(sender)
                        myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Value = _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.ActiveRow.Cells("Dv_Gia_Tang").Text & ",") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                            IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 0, "", IIf(myGridKeyDown.ActiveRow.Cells("Loai").Value = 1, "Su Vu", "TT"))
                    Case "Le_Phi_HQ", "Thue_NK", "Thue_VAT", "Le_Phi_VH", "Le_Phi_YT", "Le_Phi_DV", "Le_Phi_TV", "Le_Phi_Khac"
                        Tinh_Tong_Thue_Le_Phi()
                    Case Else
                End Select
            End If
            ReCalculate_Summary(sender)
            SetDefaultValueToCell(sender)
            ThongTinE1()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Gán giá trị cho phép trùng vào lưới E1_Di-----------------------"
    Private Sub Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi(ByVal m_E1_Di_Chi_Tiet As E1_Di_Chi_Tiet)
        Try
            With myGridKeyDown
                .ActiveRow.Cells("Ngay_Phat_Hanh").Value = m_E1_Di_Chi_Tiet.Ngay_Phat_Hanh
                .ActiveRow.Cells("Gio_Phat_Hanh").Value = m_E1_Di_Chi_Tiet.Gio_Phat_Hanh
                .ActiveRow.Cells("Ma_Bc_Goc").Value = m_E1_Di_Chi_Tiet.Ma_Bc_Goc
                .ActiveRow.Cells("Ma_Don_Vi").Value = m_E1_Di_Chi_Tiet.Ma_Don_Vi
                .ActiveRow.Cells("Ma_Bc_Tra").Value = m_E1_Di_Chi_Tiet.Ma_Bc_Tra
                .ActiveRow.Cells("Nuoc_Nhan").Value = m_E1_Di_Chi_Tiet.Nuoc_Nhan
                .ActiveRow.Cells("Nuoc_Tra").Value = m_E1_Di_Chi_Tiet.Nuoc_Tra
                .ActiveRow.Cells("Khoi_Luong").Value = m_E1_Di_Chi_Tiet.Khoi_Luong
                .ActiveRow.Cells("Phan_Loai").Value = m_E1_Di_Chi_Tiet.Phan_Loai
                .ActiveRow.Cells("Loai_Hang_Hoa").Value = m_E1_Di_Chi_Tiet.Loai_Hang_Hoa
                .ActiveRow.Cells("Khoi_Luong_QD").Value = IIf(m_E1_Di_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Di_Chi_Tiet.Khoi_Luong, m_E1_Di_Chi_Tiet.Khoi_Luong_QD)
                .ActiveRow.Cells("Loai").Value = m_E1_Di_Chi_Tiet.Loai
                .ActiveRow.Cells("PPXD").Value = m_E1_Di_Chi_Tiet.PPXD
                .ActiveRow.Cells("Cuoc_PPXD").Value = m_E1_Di_Chi_Tiet.Cuoc_PPXD
                .ActiveRow.Cells("Postcode").Value = m_E1_Di_Chi_Tiet.PostCode
                .ActiveRow.Cells("Cuoc_PPVX").Value = m_E1_Di_Chi_Tiet.Cuoc_PPVX
                .ActiveRow.Cells("VAT").Value = m_E1_Di_Chi_Tiet.VAT
                .ActiveRow.Cells("COD").Value = m_E1_Di_Chi_Tiet.COD
                .ActiveRow.Cells("Gia_Tri_Hang").Value = m_E1_Di_Chi_Tiet.Gia_Tri_Hang
                .ActiveRow.Cells("Cuoc_Giam").Value = m_E1_Di_Chi_Tiet.Cuoc_Giam
                .ActiveRow.Cells("Ghi_Chu").Value = m_E1_Di_Chi_Tiet.Ghi_Chu
                .ActiveRow.Cells("Nguoi_Gui").Value = m_E1_Di_Chi_Tiet.Nguoi_Gui
                .ActiveRow.Cells("Nguoi_Nhan").Value = m_E1_Di_Chi_Tiet.Nguoi_Nhan
                .ActiveRow.Cells("Dia_Chi_Gui").Value = m_E1_Di_Chi_Tiet.Dia_Chi_Gui
                .ActiveRow.Cells("Dia_Chi_Nhan").Value = m_E1_Di_Chi_Tiet.Dia_Chi_Nhan
                .ActiveRow.Cells("Dien_Thoai_Nhan").Value = m_E1_Di_Chi_Tiet.Dien_Thoai_Nhan
                .ActiveRow.Cells("Kien_So").Value = m_E1_Di_Chi_Tiet.Kien_So
                .ActiveRow.Cells("Ma_Bc_CH").Value = m_E1_Di_Chi_Tiet.Ma_Bc_CH
                .ActiveRow.Cells("Cuoc_Chinh").Value = m_E1_Di_Chi_Tiet.Cuoc_Chinh
                .ActiveRow.Cells("Cuoc_E1").Value = m_E1_Di_Chi_Tiet.Cuoc_E1
                .ActiveRow.Cells("Cuoc_COD").Value = m_E1_Di_Chi_Tiet.Cuoc_COD
                .ActiveRow.Cells("Dv_Cong_Them").Value = m_E1_Di_Chi_Tiet.Dv_Cong_Them
                .ActiveRow.Cells("Dv_Gia_Tang").Value = m_E1_Di_Chi_Tiet.Dv_Gia_Tang
                .ActiveRow.Cells("Cuoc_Dv").Value = m_E1_Di_Chi_Tiet.Cuoc_DV
                .ActiveRow.Cells("Ma_Bc_Ch").Value = m_E1_Di_Chi_Tiet.Ma_Bc_CH
                'Tính hoa hồng phát trả
                If m_E1_Di_Chi_Tiet.HH_Phat_Tra <> 0 Then
                    .ActiveRow.Cells("HH_Phat_Tra").Value = m_E1_Di_Chi_Tiet.HH_Phat_Tra
                Else
                    .ActiveRow.Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text, myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text)
                End If
                'Tính hoa hồng phát hành
                If m_E1_Di_Chi_Tiet.HH_Phat_Hanh <> 0 Then
                    .ActiveRow.Cells("HH_Phat_Hanh").Value = m_E1_Di_Chi_Tiet.HH_Phat_Hanh
                Else
                    .ActiveRow.Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim myE1_Le_Phi_Di_Chi_Tiet As New E1_Le_Phi_Di_Chi_Tiet
                myE1_Le_Phi_Di_Chi_Tiet = myE1_Le_Phi_Di.Lay(m_E1_Di_Chi_Tiet.Id_E1)
                .ActiveRow.Cells("Le_Phi_HQ").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ
                .ActiveRow.Cells("Thue_NK").Value = myE1_Le_Phi_Di_Chi_Tiet.Thue_NK
                .ActiveRow.Cells("Thue_VAT").Value = myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT
                .ActiveRow.Cells("Thue_NK_VAT").Value = CInt(SetNullValue(myE1_Le_Phi_Di_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT, 0))
                .ActiveRow.Cells("So_TKHQ").Value = myE1_Le_Phi_Di_Chi_Tiet.So_TKHQ
                .ActiveRow.Cells("So_Bien_Lai").Value = myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai
                .ActiveRow.Cells("Le_Phi_VH").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH
                .ActiveRow.Cells("Le_Phi_YT").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT
                .ActiveRow.Cells("Le_Phi_DV").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV
                .ActiveRow.Cells("Le_Phi_TV").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV
                .ActiveRow.Cells("Le_Phi_Khac").Value = myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac
            End With
            Tinh_Tong_Thue_Le_Phi()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Gán giá trị xác nhận đến vào lưới-----------------------"
    Private Sub Gan_Gia_Tri_Xac_Nhan_Den_Vao_Luoi(ByVal Sender As Object, ByVal m_E1_Den_Chi_Tiet As E1_Den_Chi_Tiet)
        myGridKeyDown = Sender
        Try
            With myGridKeyDown
                .ActiveRow.Cells("Ngay_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.Ngay_Phat_Hanh
                .ActiveRow.Cells("Gio_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.Gio_Phat_Hanh
                .ActiveRow.Cells("Ma_Bc_Goc").Value = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                .ActiveRow.Cells("Ma_Don_Vi").Value = m_E1_Den_Chi_Tiet.Ma_Don_Vi
                .ActiveRow.Cells("Ma_Bc_Tra").Value = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                .ActiveRow.Cells("Nuoc_Nhan").Value = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                .ActiveRow.Cells("Nuoc_Tra").Value = m_E1_Den_Chi_Tiet.Nuoc_Tra
                .ActiveRow.Cells("Khoi_Luong").Value = m_E1_Den_Chi_Tiet.Khoi_Luong
                .ActiveRow.Cells("Phan_Loai").Value = m_E1_Den_Chi_Tiet.Phan_Loai
                .ActiveRow.Cells("Loai_Hang_Hoa").Value = m_E1_Den_Chi_Tiet.Loai_Hang_Hoa
                .ActiveRow.Cells("Khoi_Luong_QD").Value = IIf(m_E1_Den_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Den_Chi_Tiet.Khoi_Luong, m_E1_Den_Chi_Tiet.Khoi_Luong_QD)
                .ActiveRow.Cells("Loai").Value = m_E1_Den_Chi_Tiet.Loai
                .ActiveRow.Cells("PPXD").Value = m_E1_Den_Chi_Tiet.PPXD
                .ActiveRow.Cells("Cuoc_PPXD").Value = m_E1_Den_Chi_Tiet.Cuoc_PPXD
                .ActiveRow.Cells("Postcode").Value = m_E1_Den_Chi_Tiet.PostCode
                .ActiveRow.Cells("Cuoc_PPVX").Value = m_E1_Den_Chi_Tiet.Cuoc_PPVX
                .ActiveRow.Cells("VAT").Value = m_E1_Den_Chi_Tiet.VAT
                .ActiveRow.Cells("COD").Value = m_E1_Den_Chi_Tiet.COD
                .ActiveRow.Cells("Gia_Tri_Hang").Value = m_E1_Den_Chi_Tiet.Gia_Tri_Hang
                .ActiveRow.Cells("Cuoc_Giam").Value = m_E1_Den_Chi_Tiet.Cuoc_Giam
                .ActiveRow.Cells("Ghi_Chu").Value = m_E1_Den_Chi_Tiet.Ghi_Chu
                .ActiveRow.Cells("Nguoi_Gui").Value = m_E1_Den_Chi_Tiet.Nguoi_Gui
                .ActiveRow.Cells("Nguoi_Nhan").Value = m_E1_Den_Chi_Tiet.Nguoi_Nhan
                .ActiveRow.Cells("Dia_Chi_Gui").Value = m_E1_Den_Chi_Tiet.Dia_Chi_Gui
                .ActiveRow.Cells("Dia_Chi_Nhan").Value = m_E1_Den_Chi_Tiet.Dia_Chi_Nhan
                .ActiveRow.Cells("Dien_Thoai_Nhan").Value = m_E1_Den_Chi_Tiet.Dien_Thoai_Nhan
                .ActiveRow.Cells("Kien_So").Value = m_E1_Den_Chi_Tiet.Kien_So
                .ActiveRow.Cells("Ma_Bc_CH").Value = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                .ActiveRow.Cells("Cuoc_Chinh").Value = m_E1_Den_Chi_Tiet.Cuoc_Chinh
                .ActiveRow.Cells("Cuoc_E1").Value = m_E1_Den_Chi_Tiet.Cuoc_E1
                .ActiveRow.Cells("Cuoc_COD").Value = m_E1_Den_Chi_Tiet.Cuoc_COD
                .ActiveRow.Cells("Dv_Cong_Them").Value = m_E1_Den_Chi_Tiet.Dv_Cong_Them
                .ActiveRow.Cells("Dv_Gia_Tang").Value = m_E1_Den_Chi_Tiet.Dv_Gia_Tang
                .ActiveRow.Cells("Cuoc_Dv").Value = m_E1_Den_Chi_Tiet.Cuoc_DV
                .ActiveRow.Cells("Ma_Bc_Ch").Value = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                'Tính hoa hồng phát trả
                If m_E1_Den_Chi_Tiet.HH_Phat_Tra <> 0 Then
                    .ActiveRow.Cells("HH_Phat_Tra").Value = m_E1_Den_Chi_Tiet.HH_Phat_Tra
                Else
                    .ActiveRow.Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text, myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text)
                End If
                'Tính hoa hồng phát hành
                If m_E1_Den_Chi_Tiet.HH_Phat_Hanh <> 0 Then
                    .ActiveRow.Cells("HH_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.HH_Phat_Hanh
                Else
                    .ActiveRow.Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim m_E1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
                m_E1_Le_Phi_Den_Chi_Tiet = myE1_Le_Phi_Den.Lay(m_E1_Den_Chi_Tiet.Id_E1)
                .ActiveRow.Cells("Le_Phi_HQ").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ
                .ActiveRow.Cells("Thue_NK").Value = m_E1_Le_Phi_Den_Chi_Tiet.Thue_NK
                .ActiveRow.Cells("Thue_VAT").Value = m_E1_Le_Phi_Den_Chi_Tiet.Thue_VAT
                .ActiveRow.Cells("Thue_NK_VAT").Value = CInt(SetNullValue(m_E1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(m_E1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0))
                .ActiveRow.Cells("So_TKHQ").Value = m_E1_Le_Phi_Den_Chi_Tiet.So_TKHQ
                .ActiveRow.Cells("So_Bien_Lai").Value = m_E1_Le_Phi_Den_Chi_Tiet.So_Bien_Lai
                .ActiveRow.Cells("Le_Phi_VH").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH
                .ActiveRow.Cells("Le_Phi_YT").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT
                .ActiveRow.Cells("Le_Phi_DV").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV
                .ActiveRow.Cells("Le_Phi_TV").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV
                .ActiveRow.Cells("Le_Phi_Khac").Value = m_E1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac
            End With
            Tinh_Tong_Thue_Le_Phi()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Update_Cuoc-----------------------"
    Private Sub Update_Cuoc(ByVal sender As Object)
        myGridKeyDown = sender
        With myGridKeyDown
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = 0
            '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = GVat
            'Tính cước dịch vụ cộng thêm và dịch vụ gia tăng
            If (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "0") And (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "") Then
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = 0
            Else
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text <> "VN" Then 'Quốc tế về
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = 0
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = 0
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = myTinh_Cuoc.Cuoc_Chinh_E1(CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text), _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                                        CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text), _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("PostCode").Text, _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Text, _
                                                        IIf(CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text) = 0, CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text), CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text)), _
                                                        CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text), _
                                                        CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value))
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text) * _
                                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value
                End If

                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text <> "VN" Then 'Quốc tế đi
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = 0
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = myTinh_Cuoc.Cuoc_DV_Cong_Them(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text, _
                                                                    IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text = "", _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Dong").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text)) _
                                                                    + myTinh_Cuoc.Cuoc_DV_Gia_Tang(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Text, _
                                                                    IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                                                    IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text = "", _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Dong").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text))
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                                                    IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text)
                End If
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = (.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value + .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value) * (1 + GVat)
            End If
        End With
    End Sub
#End Region

#Region "-----------------------E1_AfterUpdate-----------------------"
    Public Function E1_AfterUpdate(ByRef Sender As Object, Optional ByVal MAE1_ERROR As String = "EE000000000VN") As Boolean
        Dim S As String
        Dim i As Long
        Dim bbc As Long
        Dim bdv As Long
        Dim myGrid As Infragistics.Win.UltraWinGrid.UltraGrid
        myGrid = Sender

        S = GetCorrectMAE1(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text, IIf(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text = "", "VN", myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text), myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
        i = myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text.Length
        If i = 13 Then
            S = S.ToUpper
            myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Value = S
            myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Value = Mid(S, 12, 2)
            If myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text = "VN" Then
                Dim myDanh_Muc_Bc_TuE1 As New Danh_Muc_BC_Chi_Tiet
                Dim myDanh_Muc_Bc_Tu_Ma_Bc As New Danh_Muc_BC_Chi_Tiet
                myDanh_Muc_Bc_TuE1 = Tim_Danh_Muc_BC_TuE1(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text)
                myDanh_Muc_Bc_Tu_Ma_Bc = Tim_Danh_Muc_BC_Tu_Ma_Bc(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                If myDanh_Muc_Bc_TuE1.Ma_Don_Vi = 0 Then 'Không tìm thấy mã đơn vị
                    myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Don_Vi").Value = myDanh_Muc_Bc_Tu_Ma_Bc.Ma_Don_Vi
                Else
                    'Tính mã bưu cục gốc nêu khác mã đơn vị
                    If (myDanh_Muc_Bc_TuE1.Ma_Don_Vi <> myDanh_Muc_Bc_Tu_Ma_Bc.Ma_Don_Vi) Or (myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Text = Nothing) Then
                        myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Don_Vi").Value = myDanh_Muc_Bc_TuE1.Ma_Don_Vi
                        myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myDanh_Muc_Bc_TuE1.Ma_BC
                    End If
                End If
            Else
                myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = 0
                myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Don_Vi").Value = 0
            End If
            E1_AfterUpdate = True
        Else
            myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Value = GetCorrectMAE1(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text, IIf(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text = "", "VN", myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text), myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
        End If
    End Function
#End Region

#Region "-----------------------Nuoc_Nhan_AfterUpdate-----------------------"
    Private Sub Nuoc_Nhan_AfterUpdate(ByRef Sender As Object)
        Dim myGrid As Infragistics.Win.UltraWinGrid.UltraGrid
        myGrid = Sender
        Dim S As String
        S = IIf(myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text Is Nothing, "", myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Text)
        If S <> "" Then 'Nếu đã có số hiệu E1
            If myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text <> Mid(S, 12, 2) Then
                MessageBox.Show("Bạn không được thay đổi mã nước nhận!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Value = Mid(S, 12, 2)
            End If
            'myGrid.Rows(myGrid.ActiveRow.Index).Cells("Ma_E1").Value = S.ToUpper.Substring(0, 11) & myGrid.Rows(myGrid.ActiveRow.Index).Cells("Nuoc_Nhan").Text
        End If
    End Sub
#End Region

#Region "-----------------------SetDefaultValueToCell-----------------------"
    Private Sub SetDefaultValueToCell(ByVal sender As Object)
        myGridKeyDown = sender
        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ma_E1"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text
            Case "Ma_Bc_Goc"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
            Case "Ma_Bc_Tra"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text)
            Case "Nuoc_Nhan"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text
            Case "Nuoc_Tra"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text
            Case "Phan_Loai"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Phan_Loai").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Text
            Case "Id_Trang_Thai"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Trang_Thai").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Trang_Thai").Text)
        End Select
    End Sub
#End Region

#Region "-----------------------Tinh_Tong_Thue_Le_Phi-----------------------"
    Private Sub Tinh_Tong_Thue_Le_Phi()
        Try
            Dim Le_Phi_HQ As Integer
            Dim Thue_NK As Integer
            Dim Thue_VAT As Integer
            Dim Le_Phi_VH As Integer
            Dim Le_Phi_YT As Integer
            Dim Le_Phi_TV As Integer
            Dim Le_Phi_DV As Integer
            Dim Le_Phi_Khac As Integer

            Dim Thue_NK_VAT As Integer
            Dim Tong_Thue_Le_Phi As Integer = 0
            Le_Phi_HQ = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_HQ").Text, 0))
            Thue_NK = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Thue_NK").Text, 0))
            Thue_VAT = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Thue_VAT").Text, 0))
            Le_Phi_VH = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_VH").Text, 0))
            Le_Phi_YT = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_YT").Text, 0))
            Le_Phi_TV = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_TV").Text, 0))
            Le_Phi_DV = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_DV").Text, 0))
            Le_Phi_Khac = CInt(SetNullValue(dgE1_Di.ActiveRow.Cells("Le_Phi_Khac").Text, 0))

            Thue_NK_VAT = Thue_NK + Thue_VAT
            Tong_Thue_Le_Phi = Le_Phi_HQ + Le_Phi_VH + Le_Phi_YT + Le_Phi_TV + Le_Phi_DV + Le_Phi_Khac + Thue_NK + Thue_VAT
            myGridKeyDown.ActiveRow.Cells("Thue_NK_VAT").Value = Thue_NK_VAT
            myGridKeyDown.ActiveRow.Cells("Tong_Thue_Le_Phi").Value = Tong_Thue_Le_Phi
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------dgE1_Di_AfterRowActivate-----------------------"
    Private Sub dgE1_Di_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di.AfterRowActivate
        ThongTinE1()
    End Sub
#End Region

#Region "-----------------------ThongTinE1-----------------------"
    Private Sub ThongTinE1()
        If dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            Dim Danh_Muc_Bc_Goc As Danh_Muc_BC_Chi_Tiet
            Dim Danh_Muc_Bc_Tra As Danh_Muc_BC_Chi_Tiet
            Danh_Muc_Bc_Goc = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text))
            Danh_Muc_Bc_Tra = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text))
            Me.txtThongTin.Text = "Số hiệu E1   :" & dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text & vbNewLine _
                                        & "Bưu phẩm từ: " & IIf(Danh_Muc_Bc_Goc.Ma_BC = 0, dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text & " - " & myMaNuoc.Lay(dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text).Ten_Nuoc, Danh_Muc_Bc_Goc.Ma_BC & " - " & Danh_Muc_Bc_Goc.Ten_Buu_Cuc) & vbNewLine _
                                        & "Đóng đến   : " & IIf(Danh_Muc_Bc_Tra.Ma_BC = 0, dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text & " - " & myMaNuoc.Lay(dgE1_Di.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text).Ten_Nuoc, Danh_Muc_Bc_Tra.Ma_BC & " - " & Danh_Muc_Bc_Tra.Ten_Buu_Cuc)
        Else
            Me.txtThongTin.Text() = ""
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Di_BeforeRowDeactivate-----------------------"
    Private Sub dgE1_Di_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Di.BeforeRowDeactivate
        myGridKeyDown = sender
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Bạn chưa nhập số hiệu E1" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Nước nhận không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Nước trả không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Mã Bưu cục trả không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Mã Bưu cục gốc không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Di_BeforeRowInsert-----------------------"
    Private Sub dgE1_Di_BeforeRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowInsertEventArgs) Handles dgE1_Di.BeforeRowInsert
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.ActiveRow.Cells("STT").Text = "" And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("STT").Value = myGridKeyDown.ActiveRow.Index + 1
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Di_BeforeRowUpdate-----------------------"
    Private Sub dgE1_Di_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles dgE1_Di.BeforeRowUpdate
        myGridKeyDown = sender
        If (Not CInt(IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text = "", 0, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text)) > 0) And ((myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "")) Then
            MessageBox.Show("Chưa nhập khối lượng bưu phẩm!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Di_AfterRowUpdate-----------------------"
    Private Sub dgE1_Di_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1_Di.AfterRowUpdate
        Dim myBaophat As New Bao_Phat(GConnectionString)
        Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
        Dim myE1_Le_Phi_Di_Chi_Tiet As New E1_Le_Phi_Di_Chi_Tiet
        'myGridKeyDown = sender
        If dgE1_Di.Rows(dgE1_Di.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then  'Nếu dòng có dữ liệu, và đã nhập khối lượng
            With myE1_Di_Chi_Tiet
                .Ma_E1 = Trim(myGridKeyDown.ActiveRow.Cells("Ma_E1").Text).ToUpper
                .Id_Duong_Thu = Trim(myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text)
                .Id_Chuyen_Thu = Trim(myGridKeyDown.ActiveRow.Cells("Id_Chuyen_Thu").Text)
                .Id_E2 = Trim(myGridKeyDown.ActiveRow.Cells("Id_E2").Text)
                .Id_Ca = Trim(myGridKeyDown.ActiveRow.Cells("Id_Ca").Text)
                .Ma_Bc_Khai_Thac = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text
                .Ma_Quay = 0 'myGridKeyDown.ActiveRow.Cells("Ma_Quay").Text()
                .Ngay_Phat_Hanh = myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text() 'myE2_Date
                .Gio_Phat_Hanh = myGridKeyDown.ActiveRow.Cells("Gio_Phat_Hanh").Text()
                .Ngay_Dong = myGridKeyDown.ActiveRow.Cells("Ngay_Dong").Text()
                .Gio_Dong = myGridKeyDown.ActiveRow.Cells("Gio_Dong").Text()
                .Ngay_Nhan = myGridKeyDown.ActiveRow.Cells("Ngay_Nhan").Text()
                .Gio_Nhan = myGridKeyDown.ActiveRow.Cells("Gio_Nhan").Text()
                .Ma_Don_Vi = myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Text()
                .Id_Nguoi_Dung = CInt(Trim(myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Text))
                .Nuoc_Nhan = myGridKeyDown.ActiveRow.Cells("Ma_E1").Text().Substring(11, 2).ToUpper
                If .Nuoc_Nhan.ToUpper = "VN" Then
                    .Ma_Bc_Goc = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text())
                    .Ma_Don_Vi = myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Text()
                Else
                    .Ma_Bc_Goc = 0
                    .Ma_Don_Vi = "0"
                End If
                'Tìm nước trả
                .Nuoc_Tra = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text().ToUpper
                If .Nuoc_Tra.ToUpper = "VN" Then
                    .Ma_Bc_Tra = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text())
                Else
                    .Ma_Bc_Tra = 0
                End If
                .Khoi_Luong = CInt(myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text)
                .Phan_Loai = Trim(myGridKeyDown.ActiveRow.Cells("Phan_Loai").Text())
                .Loai_Hang_Hoa = CInt(myGridKeyDown.ActiveRow.Cells("Loai_Hang_Hoa").Text())
                .Khoi_Luong_QD = CInt(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text())
                .Loai = CInt(myGridKeyDown.ActiveRow.Cells("Loai").Value())
                .Dv_Cong_Them = Trim(myGridKeyDown.ActiveRow.Cells("Dv_Cong_Them").Text())
                .Dv_Gia_Tang = Trim(myGridKeyDown.ActiveRow.Cells("Dv_Gia_Tang").Text())
                .PPXD = CDec(myGridKeyDown.ActiveRow.Cells("PPXD").Text())
                .Cuoc_PPXD = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_PPXD").Text())
                .PostCode = Trim(myGridKeyDown.ActiveRow.Cells("PostCode").Text())
                .Cuoc_PPVX = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_PPVX").Text())
                .VAT = CDec(myGridKeyDown.ActiveRow.Cells("VAT").Text())
                .COD = CBool(myGridKeyDown.ActiveRow.Cells("COD").Text())
                .Gia_Tri_Hang = CInt(myGridKeyDown.ActiveRow.Cells("Gia_Tri_Hang").Text())
                .Cuoc_COD = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_COD").Text())
                .Cuoc_DV = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_DV").Text())
                .Cuoc_Chinh = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_Chinh").Text())
                .Cuoc_Giam = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_Giam").Text())
                .Cuoc_E1 = CInt(myGridKeyDown.ActiveRow.Cells("Cuoc_E1").Text())
                .Kien_So = CInt(myGridKeyDown.ActiveRow.Cells("Kien_So").Text())
                If myGridKeyDown.ActiveRow.Cells("STT").Text = "" Then
                    myGridKeyDown.ActiveRow.Cells("STT").Value = myGridKeyDown.ActiveRow.Index + 1
                End If
                .STT = CInt(myGridKeyDown.ActiveRow.Cells("STT").Text)
                .Ma_KH = myGridKeyDown.ActiveRow.Cells("Ma_KH").Text
                .Nguoi_Gui = Trim(myGridKeyDown.ActiveRow.Cells("Nguoi_Gui").Text)
                .Nguoi_Nhan = Trim(myGridKeyDown.ActiveRow.Cells("Nguoi_Nhan").Text())
                .Dia_Chi_Gui = Trim(myGridKeyDown.ActiveRow.Cells("Dia_Chi_Gui").Text())
                .Dia_Chi_Nhan = Trim(myGridKeyDown.ActiveRow.Cells("Dia_Chi_Nhan").Text())
                .Dien_Thoai_Gui = Trim(myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Gui").Text())
                .Dien_Thoai_Nhan = Trim(myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Nhan").Text())
                .HH_Phat_Hanh = CInt(myGridKeyDown.ActiveRow.Cells("HH_Phat_Hanh").Text())
                .HH_Phat_Tra = CInt(myGridKeyDown.ActiveRow.Cells("HH_Phat_Tra").Text())
                .Ma_Bc_CH = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text())
                .Id_Trang_Thai = myGridKeyDown.ActiveRow.Cells("Id_Trang_Thai").Text()
                .Ghi_Chu = Trim(myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text())
                .Truyen_Khai_Thac = CBool(myGridKeyDown.ActiveRow.Cells("Truyen_Khai_Thac").Text())
                .Truyen_Doi_Soat = CBool(myGridKeyDown.ActiveRow.Cells("Truyen_Doi_Soat").Text())
                .Chot_SL = CBool(myGridKeyDown.ActiveRow.Cells("Chot_SL").Text())
            End With
            'Lấy dữ liệu về lệ phí hải quan
            With myE1_Le_Phi_Di_Chi_Tiet
                .Le_Phi_HQ = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_HQ").Text(), 0))
                .Thue_NK = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_NK").Text(), 0))
                .Thue_VAT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_VAT").Text(), 0))
                .Thue_NK_VAT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_NK").Text(), 0)) + CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_VAT").Text(), 0))
                .So_TKHQ = SetNullValue(myGridKeyDown.ActiveRow.Cells("So_TKHQ").Text(), "")
                .So_Bien_Lai = SetNullValue(myGridKeyDown.ActiveRow.Cells("So_Bien_Lai").Text(), "")
            End With
            If (myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "") Then 'Nếu thêm 1 dòng mới
                myE1_Di_Chi_Tiet.Id_E1 = CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Kien_So) 'Tạo Id E1 mới
                myGridKeyDown.ActiveRow.Cells("Id_E1").Value = myE1_Di_Chi_Tiet.Id_E1
            Else
                'Nếu đánh Ma_E1 khác
                'Xóa mã cũ đi, chèn mã mới vào
                If Trim(myGridKeyDown.ActiveRow.Cells("Id_E1").Text) = CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Kien_So) Then
                    myE1_Di_Chi_Tiet.Id_E1 = CStr(myGridKeyDown.ActiveRow.Cells("Id_E1").Text())
                Else
                    If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then   'Xóa dữ liệu nếu đây là đường thư đường thư lưu kho
                        myE1_Den_Tam.Xoa(CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myId_E2_Luu_Kho, myE1_Di_Chi_Tiet.Kien_So))
                    ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then  'Nếu là đường thư chuyển tiếp->xóa dữ liệu để thêm mới vào sau
                        myE1_Den_Tam.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    End If
                    If (chk_Ngaynghi.Checked = True) Then 'Trạng thái là ngày nghỉ, ngày lễ
                        myBaophat.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    End If
                    myE1_Di.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    myE1_Le_Phi_Di.E1_Le_Phi_Di_Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text) 'Xóa dữ liệu trong bảng lệ phí
                    myE1_Di_Chi_Tiet.Id_E1 = CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Kien_So) 'Tạo Id E1 mới
                End If
            End If
            'Cập nhật lên máy chủ: E1_Di
            myE1_Di.E1_Di_Cap_Nhat_Them_KT(myE1_Di_Chi_Tiet.Id_E1, myE1_Di_Chi_Tiet.Id_Duong_Thu, myE1_Di_Chi_Tiet.Id_Chuyen_Thu, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Id_Ca, myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Di_Chi_Tiet.Ma_Quay, myE1_Di_Chi_Tiet.Ma_E1, _
                                    myE1_Di_Chi_Tiet.Ngay_Phat_Hanh, myE1_Di_Chi_Tiet.Gio_Phat_Hanh, myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ngay_Nhan, myE1_Di_Chi_Tiet.Gio_Nhan, _
                                    myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                    myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Di_Chi_Tiet.Phan_Loai, myE1_Di_Chi_Tiet.Loai_Hang_Hoa, myE1_Di_Chi_Tiet.Khoi_Luong_QD, myE1_Di_Chi_Tiet.Loai, myE1_Di_Chi_Tiet.Dv_Cong_Them, myE1_Di_Chi_Tiet.Dv_Gia_Tang, _
                                    myE1_Di_Chi_Tiet.PPXD, myE1_Di_Chi_Tiet.Cuoc_PPXD, myE1_Di_Chi_Tiet.PostCode, myE1_Di_Chi_Tiet.Cuoc_PPVX, myE1_Di_Chi_Tiet.VAT, myE1_Di_Chi_Tiet.COD, myE1_Di_Chi_Tiet.Gia_Tri_Hang, myE1_Di_Chi_Tiet.Cuoc_COD, myE1_Di_Chi_Tiet.Cuoc_DV, myE1_Di_Chi_Tiet.Cuoc_Chinh, myE1_Di_Chi_Tiet.Cuoc_Giam, myE1_Di_Chi_Tiet.Cuoc_E1, _
                                    myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Ma_KH, myE1_Di_Chi_Tiet.Nguoi_Gui, myE1_Di_Chi_Tiet.Nguoi_Nhan, myE1_Di_Chi_Tiet.Dia_Chi_Gui, myE1_Di_Chi_Tiet.Dia_Chi_Nhan, myE1_Di_Chi_Tiet.Dien_Thoai_Gui, myE1_Di_Chi_Tiet.Dien_Thoai_Nhan, _
                                    myE1_Di_Chi_Tiet.HH_Phat_Hanh, myE1_Di_Chi_Tiet.HH_Phat_Tra, myE1_Di_Chi_Tiet.Ma_Bc_CH, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Id_Trang_Thai, myE1_Di_Chi_Tiet.Ghi_Chu, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL)

            'Cập nhật dữ liệu vào bảng E1_Le_Phi_Di
            myE1_Le_Phi_Di.E1_Le_Phi_Di_Cap_Nhat_Them_KT(myE1_Di_Chi_Tiet.Id_E1, myE1_Di_Chi_Tiet.Id_Duong_Thu, myE1_Di_Chi_Tiet.Id_Chuyen_Thu, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Id_Ca, myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Di_Chi_Tiet.Ma_E1, _
                                               myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                               myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Le_Phi_Di_Chi_Tiet.So_TKHQ, myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK, myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK_VAT, _
                                               myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL, _
                                               myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac)

            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (5: QT Đến,7:QT Đi)
                'Tính lại Id_E1, Id_Duong_Thu,Id_E2,Id_Chuyen_Thu
                myId_E1_Luu_Kho = CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myId_E2_Luu_Kho, myE1_Di_Chi_Tiet.Kien_So) 'Tạo Id E1 mới
                myE1_Den_Tam.E1_Den_Tam_Cap_Nhat_Them_KT(myId_E1_Luu_Kho, myId_Duong_Thu_Luu_Kho, myId_Chuyen_Thu_Luu_Kho, myId_E2_Luu_Kho, myE1_Di_Chi_Tiet.Id_Ca, myDuong_Thu_Di_Chi_Tiet.Ma_Bc, myE1_Di_Chi_Tiet.Ma_Quay, myE1_Di_Chi_Tiet.Ma_E1, _
                                                    myE1_Di_Chi_Tiet.Ngay_Phat_Hanh, myE1_Di_Chi_Tiet.Gio_Phat_Hanh, myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ngay_Nhan, myE1_Di_Chi_Tiet.Gio_Nhan, _
                                                    myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                                    myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Di_Chi_Tiet.Phan_Loai, myE1_Di_Chi_Tiet.Loai_Hang_Hoa, myE1_Di_Chi_Tiet.Khoi_Luong_QD, myE1_Di_Chi_Tiet.Loai, myE1_Di_Chi_Tiet.Dv_Cong_Them, myE1_Di_Chi_Tiet.Dv_Gia_Tang, _
                                                    myE1_Di_Chi_Tiet.PPXD, myE1_Di_Chi_Tiet.Cuoc_PPXD, myE1_Di_Chi_Tiet.PostCode, myE1_Di_Chi_Tiet.Cuoc_PPVX, myE1_Di_Chi_Tiet.VAT, myE1_Di_Chi_Tiet.COD, myE1_Di_Chi_Tiet.Gia_Tri_Hang, myE1_Di_Chi_Tiet.Cuoc_COD, myE1_Di_Chi_Tiet.Cuoc_DV, myE1_Di_Chi_Tiet.Cuoc_Chinh, myE1_Di_Chi_Tiet.Cuoc_Giam, myE1_Di_Chi_Tiet.Cuoc_E1, _
                                                    myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Ma_KH, myE1_Di_Chi_Tiet.Nguoi_Gui, myE1_Di_Chi_Tiet.Nguoi_Nhan, myE1_Di_Chi_Tiet.Dia_Chi_Gui, myE1_Di_Chi_Tiet.Dia_Chi_Nhan, myE1_Di_Chi_Tiet.Dien_Thoai_Gui, myE1_Di_Chi_Tiet.Dien_Thoai_Nhan, _
                                                    myE1_Di_Chi_Tiet.HH_Phat_Hanh, myE1_Di_Chi_Tiet.HH_Phat_Tra, myE1_Di_Chi_Tiet.Ma_Bc_CH, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Id_Trang_Thai, myE1_Di_Chi_Tiet.Ghi_Chu, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL)
                'Cập nhật dữ liệu vào bảng E1_Le_Phi_Den_Tam
                myE1_Le_Phi_Den_Tam.E1_Le_Phi_Den_Tam_Cap_Nhat_Them_KT(myId_E1_Luu_Kho, myId_Duong_Thu_Luu_Kho, myId_Chuyen_Thu_Luu_Kho, myId_E2_Luu_Kho, myE1_Di_Chi_Tiet.Id_Ca, myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Di_Chi_Tiet.Ma_E1, _
                                                               myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                                               myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Le_Phi_Di_Chi_Tiet.So_TKHQ, myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK, myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK_VAT, _
                                                               myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL, _
                                               myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac)

                'Trạng thái lưu kho
                myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EML" 'Đang được lưu kho tại bưu cục khai thác
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then  'Chuyển tiếp, kho hải quan
                myE1_Den_Tam.E1_Den_Tam_Cap_Nhat_Them_KT(myE1_Di_Chi_Tiet.Id_E1, myE1_Di_Chi_Tiet.Id_Duong_Thu, myE1_Di_Chi_Tiet.Id_Chuyen_Thu, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Id_Ca, myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Di_Chi_Tiet.Ma_Quay, myE1_Di_Chi_Tiet.Ma_E1, _
                                    myE1_Di_Chi_Tiet.Ngay_Phat_Hanh, myE1_Di_Chi_Tiet.Gio_Phat_Hanh, myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ngay_Nhan, myE1_Di_Chi_Tiet.Gio_Nhan, _
                                    myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                    myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Di_Chi_Tiet.Phan_Loai, myE1_Di_Chi_Tiet.Loai_Hang_Hoa, myE1_Di_Chi_Tiet.Khoi_Luong_QD, myE1_Di_Chi_Tiet.Loai, myE1_Di_Chi_Tiet.Dv_Cong_Them, myE1_Di_Chi_Tiet.Dv_Gia_Tang, _
                                    myE1_Di_Chi_Tiet.PPXD, myE1_Di_Chi_Tiet.Cuoc_PPXD, myE1_Di_Chi_Tiet.PostCode, myE1_Di_Chi_Tiet.Cuoc_PPVX, myE1_Di_Chi_Tiet.VAT, myE1_Di_Chi_Tiet.COD, myE1_Di_Chi_Tiet.Gia_Tri_Hang, myE1_Di_Chi_Tiet.Cuoc_COD, myE1_Di_Chi_Tiet.Cuoc_DV, myE1_Di_Chi_Tiet.Cuoc_Chinh, myE1_Di_Chi_Tiet.Cuoc_Giam, myE1_Di_Chi_Tiet.Cuoc_E1, _
                                    myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Ma_KH, myE1_Di_Chi_Tiet.Nguoi_Gui, myE1_Di_Chi_Tiet.Nguoi_Nhan, myE1_Di_Chi_Tiet.Dia_Chi_Gui, myE1_Di_Chi_Tiet.Dia_Chi_Nhan, myE1_Di_Chi_Tiet.Dien_Thoai_Gui, myE1_Di_Chi_Tiet.Dien_Thoai_Nhan, _
                                    myE1_Di_Chi_Tiet.HH_Phat_Hanh, myE1_Di_Chi_Tiet.HH_Phat_Tra, myE1_Di_Chi_Tiet.Ma_Bc_CH, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Id_Trang_Thai, myE1_Di_Chi_Tiet.Ghi_Chu, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL)
                'Cập nhật dữ liệu vào bảng E1_Le_Phi_Den_Tam
                myE1_Le_Phi_Den_Tam.E1_Le_Phi_Den_Tam_Cap_Nhat_Them_KT(myE1_Di_Chi_Tiet.Id_E1, myE1_Di_Chi_Tiet.Id_Duong_Thu, myE1_Di_Chi_Tiet.Id_Chuyen_Thu, myE1_Di_Chi_Tiet.Id_E2, myE1_Di_Chi_Tiet.Id_Ca, myE1_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Di_Chi_Tiet.Ma_E1, _
                                                               myE1_Di_Chi_Tiet.Ngay_Dong, myE1_Di_Chi_Tiet.Gio_Dong, myE1_Di_Chi_Tiet.Ma_Don_Vi, myE1_Di_Chi_Tiet.Ma_Bc_Goc, myE1_Di_Chi_Tiet.Ma_Bc_Tra, myE1_Di_Chi_Tiet.Nuoc_Nhan, myE1_Di_Chi_Tiet.Nuoc_Tra, _
                                                               myE1_Di_Chi_Tiet.Khoi_Luong, myE1_Le_Phi_Di_Chi_Tiet.So_TKHQ, myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK, myE1_Le_Phi_Di_Chi_Tiet.Thue_VAT, myE1_Le_Phi_Di_Chi_Tiet.Thue_NK_VAT, _
                                                               myE1_Di_Chi_Tiet.Kien_So, myE1_Di_Chi_Tiet.STT, myE1_Di_Chi_Tiet.Id_Nguoi_Dung, myE1_Di_Chi_Tiet.Truyen_Khai_Thac, myE1_Di_Chi_Tiet.Truyen_Doi_Soat, myE1_Di_Chi_Tiet.Chot_SL, _
                                               myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV, myE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac)

            Else
                If myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh = myDanh_Muc_Bc.Lay(myE1_Di_Chi_Tiet.Ma_Bc_Tra).Ma_Tinh Then
                    myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EMF" 'Đi khỏi trung tâm khai thác tỉnh phát
                Else
                    myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EMC" 'Đi khỏi trung tâm khai thác tỉnh chấp nhận
                End If
            End If
            If (chk_Ngaynghi.Checked = True) Then 'Trạng thái là ngày nghỉ, ngày lễ cập nhật vào báo phát
                'cap nhat vao bang bao phat
                Dim id_bao_phat As String = ""
                Dim Ma_E1 As String = ""
                Dim Nuoc_Nhan As String = ""
                Dim Ma_Bc_Phat As Integer
                Dim Ngay_Phat As Integer
                Dim Gio_Phat As Integer
                Dim Ngay_Nhap As Integer
                Dim Gio_Nhap As Integer
                Dim Nguoi_Phat As String = ""
                Dim Nguoi_Nhan As String = ""
                Dim Khoi_Luong As Integer
                Dim Ma_Ly_Do As Integer
                Dim Ma_Xu_Ly As String
                Dim Phat_Duoc As Boolean
                Dim Id_Nguoi_Dung As String
                Dim Ngay_He_Thong As Integer
                Dim Truyen_Khai_Thac As Boolean
                id_bao_phat = myE1_Di_Chi_Tiet.Id_E1
                Ma_E1 = myE1_Di_Chi_Tiet.Ma_E1
                Nuoc_Nhan = myE1_Di_Chi_Tiet.Nuoc_Nhan
                Ma_Bc_Phat = cbDuongThuDi.Value
                Ngay_Phat = myE1_Di_Chi_Tiet.Ngay_Dong
                Gio_Phat = myE1_Di_Chi_Tiet.Gio_Dong + 100
                Ngay_Nhap = myE1_Di_Chi_Tiet.Ngay_Dong
                Gio_Nhap = myE1_Di_Chi_Tiet.Gio_Dong + 100
                Nguoi_Phat = "26B"
                Nguoi_Nhan = ""
                Khoi_Luong = myE1_Di_Chi_Tiet.Khoi_Luong
                Ma_Ly_Do = 26
                Ma_Xu_Ly = "B"
                Phat_Duoc = False
                Id_Nguoi_Dung = Gid_Nguoi_Dung
                Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Now)
                Truyen_Khai_Thac = False
                myBaophat.Bao_Phat_Cap_Nhat_Them_Tu_E1_Di(id_bao_phat, Ma_E1, Nuoc_Nhan, Ma_Bc_Phat, Ngay_Phat, _
                            Gio_Phat, Ngay_Nhap, Gio_Nhap, Nguoi_Phat, Nguoi_Nhan, Khoi_Luong, Ma_Ly_Do, Ma_Xu_Ly, Phat_Duoc, _
                        Id_Nguoi_Dung, Ngay_He_Thong, Truyen_Khai_Thac)
                'cap nhat vao bang noi dung phat
                Dim myNoiDungChiTiet As New Noi_Dung_Phat_Chi_Tiet
                Dim myNoiDung As New Noi_Dung_Phat(GConnectionString)
                With myNoiDungChiTiet
                    .Id_Noi_Dung = 0
                    .Id_Bao_Phat = id_bao_phat
                    .Nguoi_Phat = "26B"
                    .Ngay_Phat = Ngay_Phat
                    .Gio_Phat = Gio_Phat
                    .Ma_Xu_Ly = "B"
                    .Ma_Ly_Do = 26
                    .Phat_Duoc = False
                    .Ghi_Chu = ""
                    .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Now)
                    .Truyen_Bao_Phat = False
                End With
                myNoiDung.Them(myNoiDungChiTiet)

                myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EMH"
            End If
            'Trạng thái
            myTrang_Thai_Chi_Tiet.Id_E1 = myE1_Di_Chi_Tiet.Id_E1
            myTrang_Thai_Chi_Tiet.Ma_Bc = GBuu_Cuc_Khai_Thac
            myTrang_Thai_Chi_Tiet.Ma_E1 = myE1_Di_Chi_Tiet.Ma_E1
            myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai = myE2_Date
            myTrang_Thai_Chi_Tiet.Gio_Trang_Thai = myE2_Time
            myTrang_Thai_Chi_Tiet.Truyen_Khai_Thac = False
            myTrang_Thai.Cap_Nhat_Them_KT(myTrang_Thai_Chi_Tiet.Id_E1, myTrang_Thai_Chi_Tiet.Ma_E1, myTrang_Thai_Chi_Tiet.Id_Trang_Thai, myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai, myTrang_Thai_Chi_Tiet.Gio_Trang_Thai, myTrang_Thai_Chi_Tiet.Ma_Bc, False)
            'Quản lý xuất nhập kho D
            If chk_Kiem_Hoa.Checked = True Then 'Nếu đưa vào kiểm hóa
                If myE1_Di_Chi_Tiet.Phan_Loai = "D" Then
                    If Cap_Nhat_Bang_E1_Nhap_Kho_D(myE1_Di_Chi_Tiet) = False Then
                        MessageBox.Show("Cập nhật lỗi!!!")
                    End If
                End If
            End If
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "-----------------------Cap_Nhat_Bang_E1_Nhap_Kho_D-----------------------"
    Private Function Cap_Nhat_Bang_E1_Nhap_Kho_D(ByVal m_E1_Di_Chi_Tiet As E1_Di_Chi_Tiet) As Boolean
        Try
            myE1_Nhap_Kho_D.E1_Nhap_Kho_D_Cap_Nhat_Them(m_E1_Di_Chi_Tiet.Id_E1, _
                                                        "", _
                                                        m_E1_Di_Chi_Tiet.Id_Duong_Thu, _
                                                        m_E1_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                        m_E1_Di_Chi_Tiet.Id_E2, _
                                                        0, _
                                                        m_E1_Di_Chi_Tiet.Ma_E1, _
                                                        m_E1_Di_Chi_Tiet.Ngay_Dong, _
                                                        m_E1_Di_Chi_Tiet.Gio_Dong, _
                                                        m_E1_Di_Chi_Tiet.Nuoc_Nhan, _
                                                        m_E1_Di_Chi_Tiet.Nuoc_Tra, _
                                                        m_E1_Di_Chi_Tiet.Ma_Bc_Goc, _
                                                        m_E1_Di_Chi_Tiet.Ma_Bc_Tra, _
                                                        m_E1_Di_Chi_Tiet.Khoi_Luong, _
                                                        m_E1_Di_Chi_Tiet.Phan_Loai, _
                                                        m_E1_Di_Chi_Tiet.Gia_Tri_Hang, _
                                                        m_E1_Di_Chi_Tiet.STT, _
                                                        m_E1_Di_Chi_Tiet.Ngay_Nhan, _
                                                        m_E1_Di_Chi_Tiet.Gio_Nhan, _
                                                        m_E1_Di_Chi_Tiet.Ma_KH, _
                                                        m_E1_Di_Chi_Tiet.Nguoi_Gui, _
                                                        m_E1_Di_Chi_Tiet.Nguoi_Nhan, _
                                                        m_E1_Di_Chi_Tiet.Dia_Chi_Gui, _
                                                        m_E1_Di_Chi_Tiet.Dia_Chi_Nhan, _
                                                        m_E1_Di_Chi_Tiet.Dien_Thoai_Gui, _
                                                        m_E1_Di_Chi_Tiet.Dien_Thoai_Nhan, _
                                                        "", _
                                                        "", _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        0, _
                                                        m_E1_Di_Chi_Tiet.Id_Nguoi_Dung, _
                                                        m_E1_Di_Chi_Tiet.Ghi_Chu, _
                                                        0, _
                                                        0, _
                                                        m_E1_Di_Chi_Tiet.Id_Ca, _
                                                        False, _
                                                        False, _
                                                        "")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "-----------------------dgE1_Di_LostFocus-----------------------"
    Private Sub dgE1_Di_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di.LostFocus
        myCell = Nothing
    End Sub
#End Region
#End Region

#Region "=======================Truyền dữ liệu======================="
#Region "-----------------------Truyen_Bao_Phat-----------------------"
    Private Sub Truyen_Bao_Phat()
        Try
            Dim myBaoPhat As New Bao_Phat(GConnectionString)
            Dim myNoiDung As New Noi_Dung_Phat(GConnectionString)
            Dim myDataSet As New DataSet
            Dim myDatatable As New DataTable
            Dim Ngay_Nghi As Integer
            Dim Bc_Phat As Integer
            Ngay_Nghi = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
            Bc_Phat = Convert.ToInt32(cbDuongThuDi.Value)

            'Neu chon thi moi cho truyen
            myDatatable = myBaoPhat.Danh_Sach_Chua_Truyen_Ngay_Nghi(Ngay_Nghi, Bc_Phat).Tables(0)
            'myDatatable = myBaoPhat.Danh_Sach.Tables(0)
            myDatatable.TableName = "Bao_Phat"
            myDataSet.Tables.Add(myDatatable.Copy)

            myDatatable = myNoiDung.Danh_Sach_Chua_Truyen_Ngay_Nghi(Ngay_Nghi).Tables(0)
            myDatatable.TableName = "Noi_Dung_Phat"
            myDataSet.Tables.Add(myDatatable.Copy)
            myUtility.Dang_Ky_Truyen("Ems_Bao_Phat", "International", "Center", cbDuongThuDi.Value, 0, _
                                     Ham_Dung_Chung.ConvertDateToInt(Now), _
                                     Ham_Dung_Chung.ConvertTimeToInt(Now), "", myDataSet)
            myBaoPhat.Bao_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi(Ngay_Nghi, Bc_Phat)
            myNoiDung.Noi_Dung_Phat_Cap_Nhat_Danh_Sach_Da_Truyen_Ngay_Nghi(Ngay_Nghi)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Truyen_Du_Lieu_Khai_Thac-----------------------"
    Private Sub Truyen_Du_Lieu_Khai_Thac()
        Dim mydataset As New DataSet
        Dim mytable As New DataTable

        myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(myId_Duong_Thu)
        If myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = False Then
            Exit Sub
        End If

        'Chuyen_Thu_Di
        mytable = myChuyen_Thu_Di.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Chuyen_Thu"
        mydataset.Tables.Add(mytable.Copy)

        'E2_Di
        mytable = myE2_Di.Danh_Sach_E2_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E2"
        mydataset.Tables.Add(mytable.Copy)

        'E1_Di
        mytable = myE1_Di.Danh_Sach_E1_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E1"
        mydataset.Tables.Add(mytable.Copy)

        'COD_Di
        mytable = myCODDi.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "COD"
        mydataset.Tables.Add(mytable.Copy)

        mytable = myTrang_Thai.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Trang_Thai"
        mydataset.Tables.Add(mytable.Copy)

        myUtility.Dang_Ky_Truyen("Ems_E2", "Branch", "PO", GBuu_Cuc_Khai_Thac, myDuong_Thu_Di_Chi_Tiet.Ma_Bc, Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)

        'Cập nhật lại thông tin đã truyền
        myChuyen_Thu_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE2_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE1_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myTrang_Thai.Cap_Nhat_Truyen(myId_Chuyen_Thu)
    End Sub
#End Region

#Region "-----------------------Truyen_Le_Phi_HQ-----------------------"
    Private Sub Truyen_Le_Phi_HQ()
        Dim mydataset As New DataSet
        Dim mytable As New DataTable

        myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(myId_Duong_Thu)
        If myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = False Then
            Exit Sub
        End If

        'E1_Le_Phi_HQ
        mytable = myE1_Le_Phi_Di.Danh_Sach_E1_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Ems_E1_Le_Phi"
        mydataset.Tables.Add(mytable.Copy)

        myUtility.Dang_Ky_Truyen("Ems_E1_Le_Phi", "Branch", "PO", GBuu_Cuc_Khai_Thac, myDuong_Thu_Di_Chi_Tiet.Ma_Bc, Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset)

        'Cập nhật lại thông tin đã truyền
        'myChuyen_Thu_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        'myE2_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        'myE1_Di.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        'myTrang_Thai.Cap_Nhat_Truyen(myId_Chuyen_Thu)
    End Sub
#End Region
#End Region

#Region "-----------------------Dung cho phan ly do vao Hai quan - Id_Phan_Loai = 8-----------------------"
#Region "-----------------------Enable Colunm Ly do When Id_Phan_Loai = 8-----------------------"
    Private Sub Hide_Cotrol_LyDo(ByVal isEnable As Boolean)
        chkLy_Do_Hai_Quan.Checked = Not isEnable
        dgE1_Di.DisplayLayout.Bands(0).Columns("Id_Trang_Thai").Hidden = isEnable
    End Sub
#End Region
#End Region

#Region "=======================Search Grid======================="
#Region "dgE1_Di_MouseDown"
    Private Sub dgE1_Di_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1_Di.MouseDown
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


End Class

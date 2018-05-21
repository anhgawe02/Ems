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

Public Class FrmXacNhanE2Den
    Inherits System.Windows.Forms.Form
    'Implements ICustomSummaryCalculator

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
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ddNuoc_Nhan As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_BC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddPhan_Loai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgE1_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbDuongThuDen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbChuyenThuDen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbTuiSoDen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ddLoai_Hang_Hoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ddTo_Hop_DV_Cong_Them As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTo_Hop_DV_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtDauMa As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBanBC37 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBanE2 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtTrongluongTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cbLoai_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMaNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMaSoTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents BtnTimE1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents ddMa_BC_Tra As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents btn_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Group_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkLy_Do_Hai_Quan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
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
    Friend WithEvents chkNhap_Thong_Tin_Nguoi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkNhapLePhi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkTong_Thue_Le_Phi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_Tieu_Thu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbChuyenBayDen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbNgayBay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnTaoChuyenBay As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkE1UPUS10 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dv_Gia_Tang As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkDich_Vu_Cong_Them As Infragistics.Win.UltraWinEditors.UltraCheckEditor
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
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ChuyenThuDi", -1)
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuisodi", -1)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F", 0)
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_BC", -1)
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_bc")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Phan_Loai_BP", -1)
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Phan_Loai_BP")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Phan_Loai_BP")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_Hang_Hoa", -1)
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Loai_BP", -1)
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai_BP")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai_BP")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmXacNhanE2Den))
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dv_Cong_Them", -1)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TH_Ma_Dv_Gia_Tang", -1)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Ma")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LoaiChuyenThuDi", -1)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("MaNuoc", -1)
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("MaNuoc", -1)
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
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
        Me.dgE1_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkInE4 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkInBC37 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.txtThongTin = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtInfor = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbDuongThuDen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbChuyenThuDen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbTuiSoDen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.ddMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_BC = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddPhan_Loai_BP = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLoai_Hang_Hoa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddLoai_BP = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.ddTo_Hop_DV_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTo_Hop_DV_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.txtDauMa = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBanBC37 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBanE2 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtTrongluongTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.cbLoai_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.cbMaNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.txtMaSoTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.BtnTimE1 = New Infragistics.Win.Misc.UltraButton
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.ddMa_BC_Tra = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.btn_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.Group_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraGroupBox
        Me.chk_Dv_Gia_Tang = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkDich_Vu_Cong_Them = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkTong_Thue_Le_Phi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_Tieu_Thu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLy_Do_Hai_Quan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btn_Bo_Qua = New Infragistics.Win.Misc.UltraButton
        Me.btn_Cap_Nhat = New Infragistics.Win.Misc.UltraButton
        Me.chk_Le_Phi_Khac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
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
        Me.chk_Le_Phi_TV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_DV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkNhap_Thong_Tin_Nguoi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkNhapLePhi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.cbChuyenBayDen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbNgayBay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnTaoChuyenBay = New Infragistics.Win.Misc.UltraButton
        Me.chkE1UPUS10 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbChuyenThuDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTuiSoDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddLoai_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Thiet_Lap_Tham_So.SuspendLayout()
        CType(Me.cbChuyenBayDen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayBay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(152, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Đường T&hư"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(456, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 23)
        Me.UltraLabel2.TabIndex = 12
        Me.UltraLabel2.Text = "Túi &Số"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(384, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel3.TabIndex = 10
        Me.UltraLabel3.Text = "&Chuyến Thư"
        '
        'btnMoTui
        '
        Me.btnMoTui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoTui.Location = New System.Drawing.Point(520, 16)
        Me.btnMoTui.Name = "btnMoTui"
        Me.btnMoTui.Size = New System.Drawing.Size(72, 48)
        Me.btnMoTui.TabIndex = 16
        Me.btnMoTui.Text = "&Mở E2"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 16, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(8, 24)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(88, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 16, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(100, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "&Ngày Đóng E2"
        '
        'chkInkhidongE2
        '
        Me.chkInkhidongE2.Location = New System.Drawing.Point(600, 16)
        Me.chkInkhidongE2.Name = "chkInkhidongE2"
        Me.chkInkhidongE2.Size = New System.Drawing.Size(104, 20)
        Me.chkInkhidongE2.TabIndex = 23
        Me.chkInkhidongE2.Text = "In Khi Đóng E2"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(712, 16)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(40, 23)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Bản"
        '
        'chkTuiF
        '
        Me.chkTuiF.Location = New System.Drawing.Point(304, 96)
        Me.chkTuiF.Name = "chkTuiF"
        Me.chkTuiF.Size = New System.Drawing.Size(56, 20)
        Me.chkTuiF.TabIndex = 21
        Me.chkTuiF.Text = "Túi F"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(16, 96)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(88, 23)
        Me.UltraLabel6.TabIndex = 14
        Me.UltraLabel6.Text = "Trọng Lượn&g Túi"
        '
        'dgE1_Den
        '
        Me.dgE1_Den.Cursor = System.Windows.Forms.Cursors.Hand
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
        UltraGridColumn8.Header.Caption = "Mã E1"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.Caption = "Ngày Đóng"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Caption = "Giờ Đóng"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Ngày Nhận"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.Caption = "Giờ Nhận"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Nước Nhận"
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Nước Trả"
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Khối Lượng"
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Phân Loại"
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Khối Lượng QD"
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "Loại"
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(57, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.Caption = "Thuế VAT"
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Dv COD"
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Cước COD"
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.Header.Caption = "Cước DV"
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.Caption = "Cước Chính"
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.Caption = "Cước Giảm"
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = "Cước E1"
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.DefaultCellValue = "0"
        UltraGridColumn39.Header.Caption = "Kiện Số"
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn40.Hidden = True
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
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(285, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.DefaultCellValue = ""
        UltraGridColumn45.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(359, 0)
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
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "ID Người Dùng"
        UltraGridColumn51.Header.VisiblePosition = 50
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "ID Trạng Thái"
        UltraGridColumn52.Header.VisiblePosition = 51
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.DefaultCellValue = ""
        UltraGridColumn53.Header.Caption = "Ghi Chú"
        UltraGridColumn53.Header.VisiblePosition = 52
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(138, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.DefaultCellValue = "0"
        UltraGridColumn54.Header.VisiblePosition = 53
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 54
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 55
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.Caption = "Lệ Phí HQ"
        UltraGridColumn57.Header.VisiblePosition = 56
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Header.Caption = "Thuế Nhập khẩu"
        UltraGridColumn58.Header.VisiblePosition = 57
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.Caption = "Thuế VAT"
        UltraGridColumn59.Header.VisiblePosition = 59
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Header.Caption = "Thuế NK + VAT"
        UltraGridColumn60.Header.VisiblePosition = 58
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Số TKHQ"
        UltraGridColumn61.Header.VisiblePosition = 60
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.Caption = "Số Biên Lai"
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.Caption = "Lệ Phí Văn Hóa"
        UltraGridColumn63.Header.VisiblePosition = 62
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.Caption = "Lệ Phí Y Tế"
        UltraGridColumn64.Header.VisiblePosition = 63
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.Caption = "Lệ Phí Dịch Vụ"
        UltraGridColumn65.Header.VisiblePosition = 64
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.Caption = "Lệ Phí Thực Vật"
        UltraGridColumn66.Header.VisiblePosition = 65
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.Caption = "Lệ Phí Khác"
        UltraGridColumn67.Header.VisiblePosition = 66
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.Caption = "Tổng Thuế Lệ Phí"
        UltraGridColumn68.Header.VisiblePosition = 67
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance2
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgE1_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1_Den.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Den.DisplayLayout.Override.CardAreaAppearance = Appearance3
        Me.dgE1_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Den.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.dgE1_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance5.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Me.dgE1_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.dgE1_Den.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgE1_Den.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgE1_Den.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgE1_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Den.Location = New System.Drawing.Point(8, 224)
        Me.dgE1_Den.Name = "dgE1_Den"
        Me.dgE1_Den.Size = New System.Drawing.Size(824, 328)
        Me.dgE1_Den.TabIndex = 26
        Me.dgE1_Den.Text = "Danh sách E1 trong bản kê E2"
        '
        'chkInE4
        '
        Me.chkInE4.Location = New System.Drawing.Point(600, 40)
        Me.chkInE4.Name = "chkInE4"
        Me.chkInE4.Size = New System.Drawing.Size(104, 20)
        Me.chkInE4.TabIndex = 18
        Me.chkInE4.Text = "In E4"
        '
        'chkInBC37
        '
        Me.chkInBC37.Location = New System.Drawing.Point(512, 120)
        Me.chkInBC37.Name = "chkInBC37"
        Me.chkInBC37.Size = New System.Drawing.Size(64, 20)
        Me.chkInBC37.TabIndex = 20
        Me.chkInBC37.Text = "In BC37"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(472, 120)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(40, 23)
        Me.UltraLabel7.TabIndex = 22
        Me.UltraLabel7.Text = "Bản"
        '
        'txtThongTin
        '
        Me.txtThongTin.FlatMode = True
        Me.txtThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThongTin.Location = New System.Drawing.Point(8, 128)
        Me.txtThongTin.Multiline = True
        Me.txtThongTin.Name = "txtThongTin"
        Me.txtThongTin.Size = New System.Drawing.Size(376, 88)
        Me.txtThongTin.TabIndex = 25
        '
        'txtInfor
        '
        Me.txtInfor.FlatMode = True
        Me.txtInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfor.Location = New System.Drawing.Point(512, 144)
        Me.txtInfor.Multiline = True
        Me.txtInfor.Name = "txtInfor"
        Me.txtInfor.Size = New System.Drawing.Size(208, 72)
        Me.txtInfor.TabIndex = 24
        '
        'cbDuongThuDen
        '
        Me.cbDuongThuDen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn69.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn69.Header.VisiblePosition = 0
        UltraGridColumn70.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn70.Header.VisiblePosition = 1
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn72.Header.VisiblePosition = 3
        UltraGridColumn72.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDen.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbDuongThuDen.DisplayMember = ""
        Me.cbDuongThuDen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDen.Location = New System.Drawing.Point(144, 24)
        Me.cbDuongThuDen.Name = "cbDuongThuDen"
        Me.cbDuongThuDen.Size = New System.Drawing.Size(80, 21)
        Me.cbDuongThuDen.TabIndex = 5
        Me.cbDuongThuDen.ValueMember = ""
        '
        'cbChuyenThuDen
        '
        Me.cbChuyenThuDen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn73.Header.Caption = "Chuyến Thư"
        UltraGridColumn73.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn73})
        UltraGridBand3.Header.Caption = "Chuyến Thư Đi"
        Me.cbChuyenThuDen.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbChuyenThuDen.DisplayMember = ""
        Me.cbChuyenThuDen.Location = New System.Drawing.Point(392, 24)
        Me.cbChuyenThuDen.Name = "cbChuyenThuDen"
        Me.cbChuyenThuDen.Size = New System.Drawing.Size(53, 21)
        Me.cbChuyenThuDen.TabIndex = 11
        Me.cbChuyenThuDen.ValueMember = ""
        '
        'cbTuiSoDen
        '
        Me.cbTuiSoDen.AccessibleName = ""
        Me.cbTuiSoDen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn74.Header.Caption = "Túi Số"
        UltraGridColumn74.Header.VisiblePosition = 0
        UltraGridColumn75.Header.Caption = "Túi F"
        UltraGridColumn75.Header.VisiblePosition = 1
        UltraGridColumn75.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn74, UltraGridColumn75})
        Me.cbTuiSoDen.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cbTuiSoDen.DisplayMember = ""
        Me.cbTuiSoDen.Location = New System.Drawing.Point(448, 24)
        Me.cbTuiSoDen.Name = "cbTuiSoDen"
        Me.cbTuiSoDen.Size = New System.Drawing.Size(53, 21)
        Me.cbTuiSoDen.TabIndex = 13
        Me.cbTuiSoDen.ValueMember = ""
        '
        'ddMa_Nuoc
        '
        Me.ddMa_Nuoc.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridColumn76.Header.Caption = "Mã Nước"
        UltraGridColumn76.Header.VisiblePosition = 0
        UltraGridColumn77.Header.Caption = "Tên Nước"
        UltraGridColumn77.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn76, UltraGridColumn77})
        Me.ddMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ddMa_Nuoc.DisplayMember = ""
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(40, 408)
        Me.ddMa_Nuoc.Name = "ddMa_Nuoc"
        Me.ddMa_Nuoc.Size = New System.Drawing.Size(224, 96)
        Me.ddMa_Nuoc.TabIndex = 26
        Me.ddMa_Nuoc.Text = "TenBc"
        Me.ddMa_Nuoc.ValueMember = ""
        Me.ddMa_Nuoc.Visible = False
        '
        'ddMa_BC
        '
        Me.ddMa_BC.Cursor = System.Windows.Forms.Cursors.Hand
        UltraGridColumn78.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn78.Header.VisiblePosition = 0
        UltraGridColumn79.Header.Caption = "Tên Bưu cục"
        UltraGridColumn79.Header.VisiblePosition = 1
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn78, UltraGridColumn79})
        Me.ddMa_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ddMa_BC.DisplayMember = ""
        Me.ddMa_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC.Location = New System.Drawing.Point(392, 400)
        Me.ddMa_BC.Name = "ddMa_BC"
        Me.ddMa_BC.Size = New System.Drawing.Size(208, 112)
        Me.ddMa_BC.TabIndex = 29
        Me.ddMa_BC.Text = "MaBc"
        Me.ddMa_BC.ValueMember = ""
        Me.ddMa_BC.Visible = False
        '
        'ddPhan_Loai_BP
        '
        UltraGridColumn80.Header.VisiblePosition = 0
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.Caption = "Phân Loại BP"
        UltraGridColumn81.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn80, UltraGridColumn81})
        Me.ddPhan_Loai_BP.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.ddPhan_Loai_BP.DisplayMember = ""
        Me.ddPhan_Loai_BP.Location = New System.Drawing.Point(512, 264)
        Me.ddPhan_Loai_BP.Name = "ddPhan_Loai_BP"
        Me.ddPhan_Loai_BP.Size = New System.Drawing.Size(112, 112)
        Me.ddPhan_Loai_BP.TabIndex = 30
        Me.ddPhan_Loai_BP.Text = "UltraDropDown1"
        Me.ddPhan_Loai_BP.ValueMember = ""
        Me.ddPhan_Loai_BP.Visible = False
        '
        'ddLoai_Hang_Hoa
        '
        UltraGridColumn82.Header.VisiblePosition = 0
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn83.Header.VisiblePosition = 1
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn82, UltraGridColumn83})
        Me.ddLoai_Hang_Hoa.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.ddLoai_Hang_Hoa.DisplayMember = ""
        Me.ddLoai_Hang_Hoa.Location = New System.Drawing.Point(48, 264)
        Me.ddLoai_Hang_Hoa.Name = "ddLoai_Hang_Hoa"
        Me.ddLoai_Hang_Hoa.Size = New System.Drawing.Size(104, 112)
        Me.ddLoai_Hang_Hoa.TabIndex = 32
        Me.ddLoai_Hang_Hoa.Text = "UltraDropDown1"
        Me.ddLoai_Hang_Hoa.ValueMember = ""
        Me.ddLoai_Hang_Hoa.Visible = False
        '
        'ddLoai_BP
        '
        UltraGridColumn84.Header.Caption = "Mã Loại BP"
        UltraGridColumn84.Header.VisiblePosition = 0
        UltraGridColumn85.Header.Caption = "Loại BP"
        UltraGridColumn85.Header.VisiblePosition = 1
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn84, UltraGridColumn85})
        Me.ddLoai_BP.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.ddLoai_BP.DisplayMember = ""
        Me.ddLoai_BP.Location = New System.Drawing.Point(272, 264)
        Me.ddLoai_BP.Name = "ddLoai_BP"
        Me.ddLoai_BP.Size = New System.Drawing.Size(208, 112)
        Me.ddLoai_BP.TabIndex = 33
        Me.ddLoai_BP.Text = "UltraDropDown1"
        Me.ddLoai_BP.ValueMember = ""
        Me.ddLoai_BP.Visible = False
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Location = New System.Drawing.Point(168, 96)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel8.TabIndex = 19
        Me.UltraLabel8.Text = "Đầ&u mã"
        '
        'BtnExit
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.Image = CType(resources.GetObject("Appearance8.Image"), Object)
        Me.BtnExit.Appearance = Appearance8
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnExit.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExit.Location = New System.Drawing.Point(728, 144)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 72)
        Me.BtnExit.TabIndex = 93
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
        Me.btnPrint.Location = New System.Drawing.Point(392, 184)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 32)
        Me.btnPrint.TabIndex = 92
        '
        'btnPreview
        '
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.Image = CType(resources.GetObject("Appearance10.Image"), Object)
        Me.btnPreview.Appearance = Appearance10
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(392, 144)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(48, 32)
        Me.btnPreview.TabIndex = 91
        '
        'ddTo_Hop_DV_Cong_Them
        '
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Appearance = Appearance11
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance12
        UltraGridColumn86.Header.Caption = "Tổ hợp dịch vụ"
        UltraGridColumn86.Header.VisiblePosition = 0
        UltraGridColumn86.Width = 350
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn86})
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.ddTo_Hop_DV_Cong_Them.DisplayMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Location = New System.Drawing.Point(184, 288)
        Me.ddTo_Hop_DV_Cong_Them.Name = "ddTo_Hop_DV_Cong_Them"
        Me.ddTo_Hop_DV_Cong_Them.Size = New System.Drawing.Size(128, 112)
        Me.ddTo_Hop_DV_Cong_Them.TabIndex = 95
        Me.ddTo_Hop_DV_Cong_Them.ValueMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Visible = False
        '
        'ddTo_Hop_DV_Gia_Tang
        '
        Me.ddTo_Hop_DV_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Appearance = Appearance14
        UltraGridColumn87.Header.Caption = "Tổ hợp mã dv"
        UltraGridColumn87.Header.VisiblePosition = 0
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn87})
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance15.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.ddTo_Hop_DV_Gia_Tang.DisplayMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Location = New System.Drawing.Point(344, 280)
        Me.ddTo_Hop_DV_Gia_Tang.Name = "ddTo_Hop_DV_Gia_Tang"
        Me.ddTo_Hop_DV_Gia_Tang.Size = New System.Drawing.Size(120, 96)
        Me.ddTo_Hop_DV_Gia_Tang.TabIndex = 94
        Me.ddTo_Hop_DV_Gia_Tang.ValueMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Visible = False
        '
        'txtDauMa
        '
        Me.txtDauMa.CausesValidation = False
        Me.txtDauMa.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtDauMa.InputMask = "EA"
        Me.txtDauMa.Location = New System.Drawing.Point(232, 96)
        Me.txtDauMa.Name = "txtDauMa"
        Me.txtDauMa.Size = New System.Drawing.Size(40, 20)
        Me.txtDauMa.TabIndex = 20
        Me.txtDauMa.Text = "EA"
        '
        'txtBanBC37
        '
        Me.txtBanBC37.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBanBC37.InputMask = "9"
        Me.txtBanBC37.Location = New System.Drawing.Point(576, 120)
        Me.txtBanBC37.Name = "txtBanBC37"
        Me.txtBanBC37.Size = New System.Drawing.Size(40, 20)
        Me.txtBanBC37.TabIndex = 21
        '
        'txtBanE2
        '
        Me.txtBanE2.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBanE2.InputMask = "9"
        Me.txtBanE2.Location = New System.Drawing.Point(712, 16)
        Me.txtBanE2.Name = "txtBanE2"
        Me.txtBanE2.Size = New System.Drawing.Size(40, 20)
        Me.txtBanE2.TabIndex = 98
        '
        'txtTrongluongTui
        '
        Me.txtTrongluongTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTrongluongTui.InputMask = "99999"
        Me.txtTrongluongTui.Location = New System.Drawing.Point(112, 96)
        Me.txtTrongluongTui.Name = "txtTrongluongTui"
        Me.txtTrongluongTui.Size = New System.Drawing.Size(40, 20)
        Me.txtTrongluongTui.TabIndex = 15
        '
        'cbLoai_Chuyen_Thu
        '
        Me.cbLoai_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn88.Header.Caption = "Mã Loại"
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Width = 55
        UltraGridColumn89.Header.Caption = "Tên Loại"
        UltraGridColumn89.Header.VisiblePosition = 1
        UltraGridColumn89.Width = 83
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89})
        UltraGridBand12.Header.Caption = "Chuyến Thư Đi"
        Me.cbLoai_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.cbLoai_Chuyen_Thu.DisplayMember = ""
        Me.cbLoai_Chuyen_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Chuyen_Thu.Location = New System.Drawing.Point(336, 24)
        Me.cbLoai_Chuyen_Thu.Name = "cbLoai_Chuyen_Thu"
        Me.cbLoai_Chuyen_Thu.Size = New System.Drawing.Size(53, 21)
        Me.cbLoai_Chuyen_Thu.TabIndex = 9
        Me.cbLoai_Chuyen_Thu.ValueMember = ""
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(336, 8)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel9.TabIndex = 8
        Me.UltraLabel9.Text = "&Loại CT"
        '
        'cbMaNuoc
        '
        Me.cbMaNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn90.Header.Caption = "Mã Nước"
        UltraGridColumn90.Header.VisiblePosition = 0
        UltraGridColumn90.Width = 59
        UltraGridColumn91.Header.Caption = "Tên Nước"
        UltraGridColumn91.Header.VisiblePosition = 1
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn90, UltraGridColumn91})
        UltraGridBand13.Header.Caption = "Mã Đường Thư"
        Me.cbMaNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.cbMaNuoc.DisplayMember = ""
        Me.cbMaNuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaNuoc.Location = New System.Drawing.Point(96, 24)
        Me.cbMaNuoc.Name = "cbMaNuoc"
        Me.cbMaNuoc.Size = New System.Drawing.Size(48, 21)
        Me.cbMaNuoc.TabIndex = 3
        Me.cbMaNuoc.ValueMember = ""
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(96, 8)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel10.TabIndex = 2
        Me.UltraLabel10.Text = "&Mã Nước"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(16, 56)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(80, 23)
        Me.UltraLabel11.TabIndex = 17
        Me.UltraLabel11.Text = "Mã Số Tú&i"
        '
        'txtMaSoTui
        '
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.SizeInPoints = 12.0!
        Me.txtMaSoTui.Appearance = Appearance16
        Me.txtMaSoTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaSoTui.Location = New System.Drawing.Point(96, 56)
        Me.txtMaSoTui.Name = "txtMaSoTui"
        Me.txtMaSoTui.Size = New System.Drawing.Size(400, 26)
        Me.txtMaSoTui.TabIndex = 18
        '
        'BtnTimE1
        '
        Me.BtnTimE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTimE1.Location = New System.Drawing.Point(448, 144)
        Me.BtnTimE1.Name = "BtnTimE1"
        Me.BtnTimE1.Size = New System.Drawing.Size(56, 72)
        Me.BtnTimE1.TabIndex = 105
        Me.BtnTimE1.Text = "Tra &cứu"
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
        'ddMa_BC_Tra
        '
        Me.ddMa_BC_Tra.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn92.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn92.Header.VisiblePosition = 0
        UltraGridColumn93.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn93.Header.VisiblePosition = 1
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn92, UltraGridColumn93})
        Me.ddMa_BC_Tra.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.ddMa_BC_Tra.DisplayMember = ""
        Me.ddMa_BC_Tra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC_Tra.Location = New System.Drawing.Point(536, 280)
        Me.ddMa_BC_Tra.Name = "ddMa_BC_Tra"
        Me.ddMa_BC_Tra.Size = New System.Drawing.Size(208, 112)
        Me.ddMa_BC_Tra.TabIndex = 106
        Me.ddMa_BC_Tra.Text = "MaBc"
        Me.ddMa_BC_Tra.ValueMember = ""
        Me.ddMa_BC_Tra.Visible = False
        '
        'btn_Thiet_Lap_Tham_So
        '
        Me.btn_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(645, 95)
        Me.btn_Thiet_Lap_Tham_So.Name = "btn_Thiet_Lap_Tham_So"
        Me.btn_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(140, 25)
        Me.btn_Thiet_Lap_Tham_So.TabIndex = 129
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
        Me.Group_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(360, 130)
        Me.Group_Thiet_Lap_Tham_So.Name = "Group_Thiet_Lap_Tham_So"
        Me.Group_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(430, 300)
        Me.Group_Thiet_Lap_Tham_So.SupportThemes = False
        Me.Group_Thiet_Lap_Tham_So.TabIndex = 128
        Me.Group_Thiet_Lap_Tham_So.Text = "Thiết Lập Tham Số"
        '
        'chk_Dv_Gia_Tang
        '
        Me.chk_Dv_Gia_Tang.Location = New System.Drawing.Point(304, 48)
        Me.chk_Dv_Gia_Tang.Name = "chk_Dv_Gia_Tang"
        Me.chk_Dv_Gia_Tang.TabIndex = 46
        Me.chk_Dv_Gia_Tang.Text = "Dịch vụ đặc biệt"
        '
        'chkDich_Vu_Cong_Them
        '
        Me.chkDich_Vu_Cong_Them.Location = New System.Drawing.Point(304, 16)
        Me.chkDich_Vu_Cong_Them.Name = "chkDich_Vu_Cong_Them"
        Me.chkDich_Vu_Cong_Them.TabIndex = 45
        Me.chkDich_Vu_Cong_Them.Text = "Dịch vụ cộng thêm"
        '
        'chkTong_Thue_Le_Phi
        '
        Me.chkTong_Thue_Le_Phi.Location = New System.Drawing.Point(300, 230)
        Me.chkTong_Thue_Le_Phi.Name = "chkTong_Thue_Le_Phi"
        Me.chkTong_Thue_Le_Phi.TabIndex = 40
        Me.chkTong_Thue_Le_Phi.Text = "Tổng Thuế Lệ Phí"
        '
        'chkThue_Tieu_Thu
        '
        Me.chkThue_Tieu_Thu.Location = New System.Drawing.Point(300, 200)
        Me.chkThue_Tieu_Thu.Name = "chkThue_Tieu_Thu"
        Me.chkThue_Tieu_Thu.TabIndex = 39
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
        Me.chkKienSo.Location = New System.Drawing.Point(160, 20)
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
        Me.chkThue_VAT.Location = New System.Drawing.Point(160, 170)
        Me.chkThue_VAT.Name = "chkThue_VAT"
        Me.chkThue_VAT.TabIndex = 29
        Me.chkThue_VAT.Text = "Thuế  VAT"
        '
        'chkThue_NK
        '
        Me.chkThue_NK.Location = New System.Drawing.Point(160, 140)
        Me.chkThue_NK.Name = "chkThue_NK"
        Me.chkThue_NK.TabIndex = 28
        Me.chkThue_NK.Text = "Thuế NK"
        '
        'chkSo_Bien_Lai
        '
        Me.chkSo_Bien_Lai.Location = New System.Drawing.Point(160, 230)
        Me.chkSo_Bien_Lai.Name = "chkSo_Bien_Lai"
        Me.chkSo_Bien_Lai.TabIndex = 27
        Me.chkSo_Bien_Lai.Text = "Số Biên Lai"
        '
        'chkLe_Phi_HQ
        '
        Me.chkLe_Phi_HQ.Location = New System.Drawing.Point(160, 110)
        Me.chkLe_Phi_HQ.Name = "chkLe_Phi_HQ"
        Me.chkLe_Phi_HQ.TabIndex = 26
        Me.chkLe_Phi_HQ.Text = "Lệ Phí HQ"
        '
        'chkSo_TKHQ
        '
        Me.chkSo_TKHQ.Location = New System.Drawing.Point(160, 200)
        Me.chkSo_TKHQ.Name = "chkSo_TKHQ"
        Me.chkSo_TKHQ.TabIndex = 25
        Me.chkSo_TKHQ.Text = "Số TKHQ"
        '
        'chkLoai_Hang_Hoa
        '
        Me.chkLoai_Hang_Hoa.Location = New System.Drawing.Point(20, 232)
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
        Me.chkBcChuyenHoan.Location = New System.Drawing.Point(160, 80)
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
        Me.chkCuocDV.Location = New System.Drawing.Point(160, 50)
        Me.chkCuocDV.Name = "chkCuocDV"
        Me.chkCuocDV.Size = New System.Drawing.Size(112, 20)
        Me.chkCuocDV.TabIndex = 5
        Me.chkCuocDV.Text = "Cước DV"
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
        'chkNhap_Thong_Tin_Nguoi_Nhan
        '
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Location = New System.Drawing.Point(512, 72)
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Name = "chkNhap_Thong_Tin_Nguoi_Nhan"
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Size = New System.Drawing.Size(168, 16)
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.TabIndex = 131
        Me.chkNhap_Thong_Tin_Nguoi_Nhan.Text = "Nhập thông tin người nhận"
        '
        'chkNhapLePhi
        '
        Me.chkNhapLePhi.Location = New System.Drawing.Point(512, 96)
        Me.chkNhapLePhi.Name = "chkNhapLePhi"
        Me.chkNhapLePhi.Size = New System.Drawing.Size(112, 16)
        Me.chkNhapLePhi.TabIndex = 130
        Me.chkNhapLePhi.Text = "Nhập Lệ Phí HQ"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Location = New System.Drawing.Point(224, 8)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel12.TabIndex = 6
        Me.UltraLabel12.Text = "Chuyến bay"
        '
        'cbChuyenBayDen
        '
        Me.cbChuyenBayDen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn94.Header.Caption = "Mã Nước"
        UltraGridColumn94.Header.VisiblePosition = 0
        UltraGridColumn94.Width = 59
        UltraGridColumn95.Header.Caption = "Tên Nước"
        UltraGridColumn95.Header.VisiblePosition = 1
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn94, UltraGridColumn95})
        UltraGridBand15.Header.Caption = "Mã Đường Thư"
        Me.cbChuyenBayDen.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.cbChuyenBayDen.DisplayMember = ""
        Me.cbChuyenBayDen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChuyenBayDen.Location = New System.Drawing.Point(224, 24)
        Me.cbChuyenBayDen.Name = "cbChuyenBayDen"
        Me.cbChuyenBayDen.Size = New System.Drawing.Size(80, 21)
        Me.cbChuyenBayDen.TabIndex = 7
        Me.cbChuyenBayDen.ValueMember = ""
        '
        'cbNgayBay
        '
        Me.cbNgayBay.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayBay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayBay.Location = New System.Drawing.Point(16, 152)
        Me.cbNgayBay.Name = "cbNgayBay"
        Me.cbNgayBay.Size = New System.Drawing.Size(96, 21)
        Me.cbNgayBay.TabIndex = 135
        Me.cbNgayBay.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayBay.Visible = False
        '
        'btnTaoChuyenBay
        '
        Me.btnTaoChuyenBay.Location = New System.Drawing.Point(304, 24)
        Me.btnTaoChuyenBay.Name = "btnTaoChuyenBay"
        Me.btnTaoChuyenBay.Size = New System.Drawing.Size(24, 21)
        Me.btnTaoChuyenBay.TabIndex = 136
        Me.btnTaoChuyenBay.Tag = "......."
        Me.btnTaoChuyenBay.Text = "......."
        '
        'chkE1UPUS10
        '
        Me.chkE1UPUS10.Checked = True
        Me.chkE1UPUS10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkE1UPUS10.Location = New System.Drawing.Point(712, 48)
        Me.chkE1UPUS10.Name = "chkE1UPUS10"
        Me.chkE1UPUS10.Size = New System.Drawing.Size(72, 20)
        Me.chkE1UPUS10.TabIndex = 137
        Me.chkE1UPUS10.Text = "Check E1"
        '
        'FrmXacNhanE2Den
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 573)
        Me.Controls.Add(Me.chkE1UPUS10)
        Me.Controls.Add(Me.Group_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.btnTaoChuyenBay)
        Me.Controls.Add(Me.cbChuyenBayDen)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.chkNhap_Thong_Tin_Nguoi_Nhan)
        Me.Controls.Add(Me.chkNhapLePhi)
        Me.Controls.Add(Me.btn_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.ddMa_BC_Tra)
        Me.Controls.Add(Me.BtnTimE1)
        Me.Controls.Add(Me.txtMaSoTui)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.cbMaNuoc)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.cbLoai_Chuyen_Thu)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.txtBanBC37)
        Me.Controls.Add(Me.txtBanE2)
        Me.Controls.Add(Me.txtTrongluongTui)
        Me.Controls.Add(Me.txtDauMa)
        Me.Controls.Add(Me.ddTo_Hop_DV_Cong_Them)
        Me.Controls.Add(Me.ddTo_Hop_DV_Gia_Tang)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.ddLoai_BP)
        Me.Controls.Add(Me.ddLoai_Hang_Hoa)
        Me.Controls.Add(Me.ddPhan_Loai_BP)
        Me.Controls.Add(Me.ddMa_BC)
        Me.Controls.Add(Me.ddMa_Nuoc)
        Me.Controls.Add(Me.cbTuiSoDen)
        Me.Controls.Add(Me.cbChuyenThuDen)
        Me.Controls.Add(Me.cbDuongThuDen)
        Me.Controls.Add(Me.txtInfor)
        Me.Controls.Add(Me.txtThongTin)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.chkInBC37)
        Me.Controls.Add(Me.chkInE4)
        Me.Controls.Add(Me.dgE1_Den)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.chkTuiF)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.chkInkhidongE2)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cbNgayDong)
        Me.Controls.Add(Me.btnMoTui)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cbNgayBay)
        Me.Name = "FrmXacNhanE2Den"
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbChuyenThuDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTuiSoDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddPhan_Loai_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLoai_Hang_Hoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddLoai_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTo_Hop_DV_Cong_Them, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTo_Hop_DV_Gia_Tang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Thiet_Lap_Tham_So.ResumeLayout(False)
        CType(Me.cbChuyenBayDen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayBay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "=======================Khai báo biến======================="
    'Thong so chung
    Dim myBand As UltraGridBand
    Dim mySummary As SummarySettings
    Dim myKeys As New ModifyRegistry
    Dim FrmSearch As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myDichVu As New Dich_Vu(GConnectionString)
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing
    Dim IsOpenBag As Boolean 'Xác định túi có được mở ra không
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myComboKeyDown As Infragistics.Win.UltraWinGrid.UltraCombo

    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myMaNuoc As New Ma_Nuoc(GConnectionString)
    Dim myMaTinh As New Ma_Tinh(GConnectionString)
    Dim myMaBc As New Danh_Muc_BC(GConnectionString)
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)
    Dim myTrang_Thai_Chi_Tiet As New Trang_Thai_Chi_Tiet
    Dim myTrang_Thai As New Trang_Thai(GConnectionString)
    Dim myCODDen As New COD_Den(GConnectionString)
    Dim myDanhMucDuongBayDen As New Danh_Muc_Duong_Bay_Den(GConnectionString)
    Dim myCN38Den As New CN38Den(GConnectionString)

    Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
    Dim myTinh_Cuoc_Chi_Tiet As Tinh_Cuoc_Chi_Tiet
    Dim myId_Nguoi_Dung As Integer
    Dim myId_Ca As String

    Dim myMa_Nuoc_Hien_Tai As String 'Để cho không bị nhảy mã đường thư

    Dim myDuLieuTam As DataTable
    Dim myHam_Dung_Chung As Ham_Dung_Chung

    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myE2_Den As New E2_Den(GConnectionString)
    Dim myTmp_E2_Den As New Tmp_E2_Den(GConnectionString)
    Dim myE2_Den_Ma_Vach_Tui As New E2_Den_Ma_Vach_Tui(GConnectionString)

    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)

    Dim myE1_Le_Phi_Den As New E1_Le_Phi_Den(GConnectionString)
    Dim myE1_Le_Phi_Den_Tam As New E1_Le_Phi_Den_Tam(GConnectionString)

    Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
    Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
    Dim myE2_Den_Chi_Tiet1 As New E2_Den_Chi_Tiet

    Dim myMa_Nuoc_Den As String
    Dim myId_Duong_Thu As String
    Dim myLoai_Chuyen_Thu As String
    Dim myId_Chuyen_Thu As String
    Dim myId_E2 As String
    Dim myChuyenBayDen As String


    Dim myMa_Bc As Integer
    Dim mySo_Chuyen_Thu_Den As Integer
    Dim myTui_So_Den As Integer

    Dim mySo_Chuyen_Thu_Den_Lon_Nhat As Integer
    Dim myTui_So_Den_LonNhat As Integer
    Dim myMax_DongF As Boolean
    Dim myTongso As Integer
    Dim myTongKhoiLuongBP As Integer

    Dim myE2_Date As Integer
    Dim myE2_Time As Integer
    Dim myE2_Date_Receiver As Integer
    Dim myE2_Time_Receiver As Integer

    'Lấy thông tin trùng số liệu, số liệu truyền đến
    Dim myE1_Den_Tam_Chi_Tiet_Trung As New E1_Den_Tam_Chi_Tiet 'Giá trị truyền đến
    Dim myE1_Den_Chi_Tiet_Trung As New E1_Den_Chi_Tiet
    Dim myE1_Le_Phi_Den_Chi_Tiet_Trung As New E1_Le_Phi_Den_Chi_Tiet
    'Điều kiện xác định trùng số liệu
    Dim myIsTrungSoLieu As Boolean
    Dim myIsChoPhepTrung As Boolean
    Dim myMAE1Thoat As Boolean
    Dim myIsDaKiemTraTrung As Boolean
    Dim myIsDaTruyenDen As Boolean

    'Kiểm tra lạc hướng
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myMa_Nuoc_Theo_Duong_Thu As String
    Dim myMa_Tinh_Theo_Duong_Thu As String

    ' Kiem tra lac huong
    Dim myMaNuocTheoDuongThu As String = "VN"
    Dim myMaTinhTheoDuongThu As Integer = 0
    Dim myChoPhepLacHuong As Boolean = False

    Dim myLastColumnKey As String
    Dim myColumnInputData As String
    'Ghi Log_Event
    Dim myLog_Id As Integer
#End Region

#Region "=======================Control Form======================="
#Region "-----------------------FrmThietLapE2Den_Load-----------------------"
    Private Sub FrmThietLapE2Den_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GUserAdmin = True Then
            chkE1UPUS10.Visible = True
        Else
            chkE1UPUS10.Visible = False
        End If
        DesignForm()

        GetKeys()

        Thiet_Lap_Tham_So()

        Load_Data()

        Init_Form()

        Validate_Commbo()

        DataGrid_Nhap_E1_Den(0)

        dgE1_Den.DisplayLayout.Override.ResetAllowAddNew()

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
        txtDauMa.Text = GMa_Dau_So

        txtBanE2.Text = CInt(SetNullValue(myKeys.Doc("SoBanE2Den"), "0"))
        txtBanBC37.Text = CInt(SetNullValue(myKeys.Doc("SoBanBC37Den"), "0"))
        txtTrongluongTui.Text = CInt(SetNullValue(myKeys.Doc("TrongLuongTuiDen"), "0"))
        chkInkhidongE2.Checked = CBool(SetNullValue(myKeys.Doc("InKhiDongE2Den"), "0"))
        chkInE4.Checked = CBool(SetNullValue(myKeys.Doc("InE4"), "0"))
        chkInBC37.Checked = False
    End Sub
#End Region

#Region "--------------------Thiet_Lap_Tham_So-----------------------"
    Private Sub Thiet_Lap_Tham_So()
        dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_E1").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Cuoc_E1"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Nguoi_Nhan"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dia_Chi_Nhan"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dien_Thoai_Nhan"), "False"))
        'dgE1_Den.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = True
        dgE1_Den.DisplayLayout.Bands(0).Columns("Nguoi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Nguoi_Gui"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dia_Chi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dia_Chi_Gui"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Ghi_Chu").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ghi_Chu"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_HQ"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_NK"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_VAT"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_So_TKHQ"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_So_Bien_Lai"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Loai_Hang_Hoa"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ma_Bc_CH"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_Dv").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Cuoc_Dv"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Kien_So").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Kien_So"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_VH").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_VH"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_YT").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_YT"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_DV").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_DV"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_TV").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_TV"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Le_Phi_Khac").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_Khac"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Id_Trang_Thai").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ly_Do_Vao_Kho_HQ"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dv_Cong_Them").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dv_Cong_Them"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dv_Gia_Tang").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dv_Gia_Tang"), "False"))
        'dgE1_Den.DisplayLayout.Bands(0).Columns("Thue_Tieu_Thu").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_Tieu_Thu"), "False"))
        dgE1_Den.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").Hidden = Not CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Tong_Thue_Le_Phi"), "False"))
    End Sub
#End Region

#Region "-----------------------Load_Data-----------------------"
    Private Sub Load_Data()
        Tao_Bang_Phan_Loai_BP()
        Tao_Bang_Loai_Hang_Hoa()
        Tao_Bang_Loai_BP()
        To_Hop_Ma_DV_Cong_Them()
        'To_Hop_Ma_DV_Gia_Tang()
        ddMa_Nuoc.DataSource = myMaNuoc.Danh_Sach_Rut_Gon()
        ddMa_Nuoc.DataBind()
        ddMa_BC.DataSource = myMaBc.Danh_Sach_Rut_Gon_KT.Tables(0)
        ddMa_BC.DataBind()
        ddMa_BC_Tra.DataSource = myMaTinh.Danh_Sach_Rut_Gon.Tables(0) 'myMaBc.Danh_Sach_Rut_Gon_KT.Tables(0)
        ddMa_BC_Tra.DataBind()
        Tao_Bang_Phan_Loai_Chuyen_Thu()
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

#Region "-----------------------Tạo bảng Phân loại chuyến thư-----------------------"
    Private Sub Tao_Bang_Phan_Loai_Chuyen_Thu()
        Dim dataTable As New dataTable("Phan_Loai_Chuyen_Thu")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai") = "EA"
        row("Ten_Loai") = "Mix A"
        dataTable.Rows.Add(row)

        'Dim row As DataRow = dataTable.NewRow()
        'row("Ma_Loai") = "ED"
        'row("Ten_Loai") = "Document"
        'dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "ED"
        row("Ten_Loai") = "Document"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "EM"
        row("Ten_Loai") = "Machasnim"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "EN"
        row("Ten_Loai") = "Mix"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Loai") = "CN"
        row("Ten_Loai") = "USPS"
        dataTable.Rows.Add(row)

        cbLoai_Chuyen_Thu.DataSource = dataTable
        cbLoai_Chuyen_Thu.DataBind()
    End Sub
#End Region
#End Region

#Region "---------------------Init_Form------------------------"
    Private Function Init_Form() As Boolean
        Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
        myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Ca_Hien_Tai(GBuu_Cuc_Khai_Thac)
        Text = "Xác nhận bản kê E2 đến :Bưu cục khai thác:" & GBuu_Cuc_Khai_Thac & "-" & GTen_Buu_Cuc_Khai_Thac & "-Ca hiện tại là ca: " & myCa_San_Xuat_Chi_Tiet.Thu_Tu & "- " & myHam_Dung_Chung.ConvertIntToDate_VN(CInt(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac))
        txtInfor.Text = "Tổng số     : 0" & vbNewLine & "Khối lượng : 0"
        txtMaSoTui.Text = ""
        txtMaSoTui.InputMask = "AAAAAAAAAAAAAAA99999999999999"

        chkTuiF.Checked = False
        chkInBC37.Enabled = False
        txtBanBC37.Enabled = False
        txtBanE2.Enabled = chkInkhidongE2.Checked

        cbNgayDong.DateTime = Today

        Group_Thiet_Lap_Tham_So.Visible = False

        'Ma nuoc
        cbMaNuoc.DataSource = myMaNuoc.Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_Den_KT(GBuu_Cuc_Khai_Thac)
        If cbMaNuoc.Rows.Count > 0 Then
            cbMaNuoc.Value = cbMaNuoc.Rows(0).Cells("Ma_Nuoc").Value
        Else
            MessageBox.Show("Không tồn tại đường thư nào thuộc bưu cục khai thác này!!!" & vbNewLine & _
                            "       Bạn hãy liên hệ với người quản trị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Dispose()
        End If
        cbMaNuoc.LimitToList = True

        cbLoai_Chuyen_Thu.Value = cbLoai_Chuyen_Thu.Rows(0).Cells("Ma_Loai").Value
        cbLoai_Chuyen_Thu.LimitToList = True
    End Function
#End Region

#Region "-----------------------Enable_Control-----------------------"
    Private Sub Enable_Control(ByVal OpenBag As Boolean)

        cbNgayDong.Enabled = Not OpenBag
        cbMaNuoc.Enabled = Not OpenBag
        cbDuongThuDen.Enabled = Not OpenBag
        cbLoai_Chuyen_Thu.Enabled = Not OpenBag
        cbChuyenThuDen.Enabled = Not OpenBag
        cbTuiSoDen.Enabled = Not OpenBag
        txtBanE2.Enabled = chkInkhidongE2.Checked
        txtBanBC37.Enabled = chkInBC37.Checked
        btnPreview.Enabled = Not OpenBag
        btnPrint.Enabled = Not OpenBag
        dgE1_Den.Enabled = OpenBag
        cbChuyenBayDen.Enabled = Not OpenBag
        btnTaoChuyenBay.Enabled = Not OpenBag
        If OpenBag = True Then
            dgE1_Den.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            dgE1_Den.DisplayLayout.Override.BorderStyleTemplateAddRow = UIElementBorderStyle.Inset
        Else
            dgE1_Den.DisplayLayout.Override.ResetAllowAddNew()
        End If

        btnMoTui.Text = IIf(Not OpenBag, "Mở &Túi", "Đóng &Túi")
        dgE1_Den.Enabled = OpenBag

        If GUserAdmin Then 'Nếu là quản trị tuyệt đối
            dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
        Else
            If gSua_Cuoc_Chinh = True Then
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            Else
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_DV = True Then
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            Else
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_E1 = True Then
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
            Else
                dgE1_Den.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.NoEdit
            End If
        End If
        'Không cho phép chỉnh sửa cột tổng thuế lệ phí
        dgE1_Den.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").CellActivation = Activation.NoEdit
    End Sub
#End Region

#Region "---------------------Validate_Commbo------------------------"
    Private Function Validate_Commbo() As Boolean
        myMa_Nuoc_Den = cbMaNuoc.Value
        cbDuongThuDen.DataSource = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT(GBuu_Cuc_Khai_Thac, IIf(myMa_Nuoc_Den = "", "VN", myMa_Nuoc_Den))
        cbDuongThuDen.Value = cbDuongThuDen.Rows(0).Cells("Ma_Bc").Value
        cbDuongThuDen.DataBind()
        cbDuongThuDen.LimitToList = True
        'Kiểm tra đường thư trong nước
        If cbMaNuoc.Text = "VN" Then
            cbLoai_Chuyen_Thu.Text = "EN"
            cbLoai_Chuyen_Thu.Enabled = False
        Else
            cbLoai_Chuyen_Thu.Enabled = True
        End If

        IsOpenBag = False
        Enable_Control(False)

        myTongso = 0
        myTongKhoiLuongBP = 0

        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Today)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
        myE2_Date_Receiver = myHam_Dung_Chung.ConvertDateToInt(Today)
        myE2_Time_Receiver = myHam_Dung_Chung.ConvertTimeToInt(Now)

        Dim myDataTable As DataTable
        'Lấy thông tin đường thư chi tiết
        myDataTable = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDen.Value))
        myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
        myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
        myDuong_Thu_Den_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
        myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
        myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
        myId_Duong_Thu = myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu
        myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = myDataTable.Rows(0)("Duoc_Truyen")
        myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep = myDataTable.Rows(0)("Chuyen_Tiep")

        myMa_Nuoc_Hien_Tai = myMa_Nuoc_Den
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        mySo_Chuyen_Thu_Den_Lon_Nhat = myChuyen_Thu_Den.Tim_So_Chuyen_Thu_Den_Lon_Nhat(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
        cbChuyenThuDen.DataSource = myChuyen_Thu_Den.Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        If mySo_Chuyen_Thu_Den_Lon_Nhat > 0 Then
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDen.Value = mySo_Chuyen_Thu_Den_Lon_Nhat
                Else
                    cbChuyenThuDen.Text = mySo_Chuyen_Thu_Den_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                cbChuyenThuDen.Text = 1
            End If
        End If
        'Thêm phần kiểm tra thêm thông tin của đường thư đi: Nước đến, Tỉnh đến
        myMa_Nuoc_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Den_Chi_Tiet.Ma_Bc).Ma_Nc
        If myMa_Nuoc_Theo_Duong_Thu = "VN" Then
            myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Den_Chi_Tiet.Ma_Bc).Ma_Tinh
        Else
            myMa_Tinh_Theo_Duong_Thu = 0
        End If

        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        mySo_Chuyen_Thu_Den_Lon_Nhat = myChuyen_Thu_Den.Tim_So_Chuyen_Thu_Den_Lon_Nhat(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
        cbChuyenThuDen.DataSource = myChuyen_Thu_Den.Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        If mySo_Chuyen_Thu_Den_Lon_Nhat > 0 Then
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDen.Value = mySo_Chuyen_Thu_Den_Lon_Nhat
                Else
                    cbChuyenThuDen.Text = mySo_Chuyen_Thu_Den_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                cbChuyenThuDen.Text = 1
            End If
        End If

        Lay_TT_Chuyen_Thu()

        cbTuiSoDen.LimitToList = False
        If (cbTuiSoDen.Text = "") Or (cbTuiSoDen.Text = "0") Then
            myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu)
            If myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu <> "" Then
                myId_Chuyen_Thu = myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                myTui_So_Den_LonNhat = myE2_Den.Tim_So_Tui_Den_Lon_Nhat(myId_Chuyen_Thu)
                cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(myId_Chuyen_Thu)
                If cbTuiSoDen.Rows.Count > 0 Then 'Nếu tồn tại ít nhất 1 bản kê
                    If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư đã đóng F chưa
                        cbTuiSoDen.Text = myTui_So_Den_LonNhat + 1
                    Else
                        cbTuiSoDen.Text = myTui_So_Den_LonNhat
                    End If
                Else
                    myTui_So_Den_LonNhat = 0
                    cbTuiSoDen.Text = 1
                End If
            Else 'Nếu chưa tồn tại chuyến thư
                If cbTuiSoDen.Text = "" Then
                    Me.cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(0)
                    cbTuiSoDen.Text = 1
                End If
            End If
        End If
        myTui_So_Den = CInt(cbTuiSoDen.Text)

        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(Me.cbDuongThuDen.Value) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")" & _
                                vbNewLine & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "- Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Den) & " - Túi Số: " & myTui_So_Den
    End Function
#End Region

#Region "-----------------------FrmThietLapE2Den_Closing-----------------------"
    Private Sub FrmThietLapE2Den_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        SetKeys()
        If IsOpenBag Then
            DongTui()
        End If
    End Sub
#End Region

#Region "-----------------------SetKeys-----------------------"
    Private Sub SetKeys()
        myKeys.Ghi("SoBanE2Den", txtBanE2.Text)
        myKeys.Ghi("SoBanBC37Den", txtBanBC37.Text)
        myKeys.Ghi("DauMa", txtDauMa.Text)
        myKeys.Ghi("TrongLuongTuiDen", IIf(txtTrongluongTui.Text <> "", txtTrongluongTui.Text, 0))
        myKeys.Ghi("InKhiDongE2Den", chkInkhidongE2.Checked)
        myKeys.Ghi("InE4", chkInE4.Checked)
        myKeys.Ghi("InBC37DenKhiDongF", chkInBC37.Checked)
    End Sub
#End Region

#Region "-----------------------FrmThietLapE2Den_KeyPress-----------------------"
    Private Sub FrmThietLapE2Den_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "-----------------------CheckBox-----------------------"
#Region "chkInkhidongE2_CheckedChanged"
    Private Sub chkInkhidongE2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInkhidongE2.CheckedChanged
        txtBanE2.Enabled = chkInkhidongE2.Checked
    End Sub
#End Region

#Region "chkInBC37_CheckedValueChanged"
    Private Sub chkInBC37_CheckedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInBC37.CheckedValueChanged
        txtBanBC37.Enabled = chkInBC37.Checked
    End Sub
#End Region

#Region "chkTuiF_CheckedChanged"
    Private Sub chkTuiF_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTuiF.CheckedChanged
        chkInBC37.Enabled = chkTuiF.Checked
    End Sub
#End Region

#Region "--------------------chkNhapLePhi_CheckedChanged--------------------"
    Private Sub chkNhapLePhi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNhapLePhi.CheckedChanged
        SetColumnInputData(dgE1_Den)
    End Sub
#End Region

#Region "--------------------chkNhap_Thong_Tin_Nguoi_Nhan_CheckedChanged--------------------"
    Private Sub chkNhap_Thong_Tin_Nguoi_Nhan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNhap_Thong_Tin_Nguoi_Nhan.CheckedChanged
        SetColumnInputData(dgE1_Den)
    End Sub
#End Region
#End Region

#Region "-----------------------Button-----------------------"
#Region "-----------------------btnMoTui_Click-----------------------"
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

#Region "Mở Túi"
    Private Sub MoTui() 'Mở tờ E2
        Try
            IsOpenBag = False
            'Thông tin nhập không đầy đủ   
            If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(cbDuongThuDen.Text), CInt(cbChuyenThuDen.Text), CInt(cbTuiSoDen.Text), cbChuyenBayDen.Text) = False Then Exit Sub
            'Kiểm tra ngày ca kế toán
            If GId_Ca = "" Then
                If CMessageBox.Show("Hiện tại bạn không làm việc trong bất cứ ca làm việc nào!!!" & vbNewLine _
                                  & "   Bạn phải thoát khỏi chương trình rồi vào lại     ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Exit Sub
                Else
                    Me.Dispose()
                    Me.Close()
                    Dim frm As New FrmLogin
                    frm.ShowDialog()
                End If
            End If
            'Kiểm tra ngày ca kế toán có đúng với ngày ca kế toán hiện tại không
            Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
            Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
            myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Ca_Hien_Tai(GBuu_Cuc_Khai_Thac)

            ' Kiểm tra thông tin chuyến bay
            myId_Chuyen_Thu = (cbDuongThuDen.Text & "0" & GBuu_Cuc_Khai_Thac & Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.DateTime) & cbChuyenThuDen.Text & cbLoai_Chuyen_Thu.Text)
            myId_E2 = myId_Chuyen_Thu & cbTuiSoDen.Text
            If Tim_Duong_Bay_Theo_Id_E2(myId_E2) <> cbChuyenBayDen.Value And Tim_Duong_Bay_Theo_Id_E2(myId_E2) <> "" Then
                If GUserAdmin = False Then
                    CMessageBox.Show("Đã xác nhận đường bay cho chuyến thư và túi số này, bạn không có quyến sửa đổi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
                Else
                    If CMessageBox.Show("Đã xác nhận đường bay cho chuyến thư và túi số này, bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
                    Else
                        cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
                    End If
                End If
            End If

            'Kiểm tra quyền sửa số liệu
            If GUserAdmin = False Then 'Không phải là quản trị tuyệt đối
                If GId_Ca <> myCa_San_Xuat_Chi_Tiet.Id_Ca Then
                    CMessageBox.Show("Bạn đang làm việc tại ca:" & Mid(GId_Ca, 14, 1) & ", Ngày" & myHam_Dung_Chung.ConvertIntToDate(CInt(Mid(GId_Ca, 7, 8))) & vbNewLine _
                            & "Ca hiện tại là ca: " & myCa_San_Xuat_Chi_Tiet.Thu_Tu & ", Ngày : " & myHam_Dung_Chung.ConvertIntToDate(CInt(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac)) _
                            & vbNewLine & "Bạn phải thoát khỏi chương trình rồi vào lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value) < myHam_Dung_Chung.MinusIntDate(CInt(Mid(GId_Ca, 7, 8)), 15) Then
                    CMessageBox.Show("Ngày đóng chuyến thư vượt quá xa so với ngày kế toán!!!" & vbNewLine _
                                  & "         Bạn hãy chỉnh lại ngày đóng chuyến thư        " _
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
            Else 'Là quản trị tuyệt đối
                'Kiểm tra khóa số liệu tại ca đó
                Dim myKe_Toan_Ca As New Ke_Toan_Ca(GConnectionString)
                If myKe_Toan_Ca.Lay(GId_Ca).Chot_Sl = True Then
                    If CMessageBox.Show("Số liệu ca này đã bị khóa!" & vbNewLine & "Bạn có muốn mở không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            'Kiểm tra xem ngày đóng có lớn hơn ngày kế toán
            Dim NgaySanXuat As Integer = Convert.ToInt32(Mid(GId_Ca, 7, 8))
            If (NgaySanXuat < myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)) Then
                MessageBox.Show("Ngày đóng không thể lớn hơn ngày kế toán,Bạn cần kiểm tra lại", " Ngày khai thác" & myHam_Dung_Chung.ConvertIntToDate_VN(NgaySanXuat))
                Exit Sub
            End If

            LayThongSo()
            myLog_Id = 0 'Gán giá trị Default=0 cho Log_Id
            myTongso = 0
            myTongKhoiLuongBP = 0
            myId_Nguoi_Dung = Gid_Nguoi_Dung
            myId_Ca = GId_Ca

            'Lay_Chi_Tiet_Chuyen_Thu_Den_tu_Duong_Thu_Den(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den)
            Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
            Dim m_E2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
            myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu)
            Dim myE2DenTam As New E2_Den_Tam(GConnectionString)
            Dim a As String
            Dim myTmp_E2_Den_Chi_Tiet As New Tmp_E2_Den_Chi_Tiet
            Dim myTmp_E2_Den As New Tmp_E2_Den(GConnectionString)

            'myE2DenTam.ConvertE2Tam(CreateId_E2_Convert(myId_Duong_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, myE2_Date))
            If myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu <> "" Then 'Nếu tồn tại chuyến thư
                myId_Chuyen_Thu = myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                'Lay_Chi_Tiet_E2_Den_tu_Id_Chuyen_Thu_So_Tui(myId_Chuyen_Thu, myTui_So_Den)
                m_E2_Den_Chi_Tiet = myE2_Den.E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT(myId_Chuyen_Thu, myTui_So_Den)
                If m_E2_Den_Chi_Tiet.Id_E2 <> "" Then 'Nếu tồn tại tờ E2

                    'Lấy thông tin E2 trong Tmp_E2_Den
                    myTmp_E2_Den_Chi_Tiet = myTmp_E2_Den.Tmp_E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT(myId_Chuyen_Thu, myTui_So_Den)
                    If myTmp_E2_Den_Chi_Tiet.Id_E2 <> "" Then
                        myId_E2 = myTmp_E2_Den_Chi_Tiet.Id_E2
                        If myTmp_E2_Den_Chi_Tiet.Tong_So_BP = 0 And myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP = 0 Then 'Nếu tờ E2 đang được người khác cập nhật
                            MessageBox.Show("Tờ E2 này đang được người khác cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        If myTmp_E2_Den_Chi_Tiet.Id_Ca <> GId_Ca Then
                            If GUserAdmin = False Then 'Được phép sửa đổi
                                MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(myTmp_E2_Den_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(myTmp_E2_Den_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & _
                                                "Bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                If MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(myTmp_E2_Den_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(myTmp_E2_Den_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & _
                                                "Bạn có muốn mở không!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    myId_Ca = myTmp_E2_Den_Chi_Tiet.Id_Ca
                                Else
                                    Exit Sub
                                End If

                            End If
                        End If

                        'Gán các thông số có trong chi tiết bản kê E2 được mở
                        chkTuiF.CheckedValue = myTmp_E2_Den_Chi_Tiet.Tui_F
                        txtTrongluongTui.Value = myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui + m_E2_Den_Chi_Tiet.Khoi_Luong_BP
                        myE2_Date = myTmp_E2_Den_Chi_Tiet.Ngay_Dong
                        myE2_Time = myTmp_E2_Den_Chi_Tiet.Gio_Dong
                        myTongso = myTmp_E2_Den_Chi_Tiet.Tong_So_BP
                        myE2_Date_Receiver = myTmp_E2_Den_Chi_Tiet.Ngay_Nhan
                        myE2_Time_Receiver = myTmp_E2_Den_Chi_Tiet.Gio_Nhan
                        myTongKhoiLuongBP = myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP
                        'cbChuyenBayDen.Value = Mid(myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay, 15, 50)
                        myId_Ca = myTmp_E2_Den_Chi_Tiet.Id_Ca
                        'Thông báo thông tin về tờ E2
                        If MessageBox.Show("Tờ E2 này có tổng số: " & myTongso & " Bưu phẩm" & vbNewLine & "Bạn có muốn mở tờ E2 này không", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.No Then
                            Exit Sub
                        End If

                        'Ghi Event trước: Mở lại E2
                        Event_Viewer_Open_E2(1, Event_Viewer_Create_Chi_Tiet_E2(myTmp_E2_Den_Chi_Tiet.Id_Duong_Thu, myTmp_E2_Den_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, myTongso, myTongKhoiLuongBP + myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui), "")

                        'Cập nhật lại thông tin E2: Tong_So_BP=0, Khoi_Luong_BP=0
                        myTmp_E2_Den_Chi_Tiet.Tong_So_BP = 0
                        myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP = 0
                        m_E2_Den_Chi_Tiet.Tui_F = False
                        myTmp_E2_Den.Tmp_E2_Den_Cap_Nhat_Them_KT(myTmp_E2_Den_Chi_Tiet.Id_E2, _
                                                        myTmp_E2_Den_Chi_Tiet.Id_Duong_Thu, _
                                                        myTmp_E2_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                        myTmp_E2_Den_Chi_Tiet.Id_Ca, _
                                                        myTmp_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                        myTmp_E2_Den_Chi_Tiet.Ngay_Dong, _
                                                        myTmp_E2_Den_Chi_Tiet.Gio_Dong, _
                                                        myTmp_E2_Den_Chi_Tiet.Ngay_Nhan, _
                                                        myTmp_E2_Den_Chi_Tiet.Gio_Nhan, _
                                                        myTmp_E2_Den_Chi_Tiet.Tui_So, _
                                                        myTmp_E2_Den_Chi_Tiet.Tui_F, _
                                                        myTmp_E2_Den_Chi_Tiet.Tong_So_BP, _
                                                        myTmp_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                        myTmp_E2_Den_Chi_Tiet.Khoi_Luong_BP, _
                                                        myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_COD, _
                                                        myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_DV, _
                                                        myTmp_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                        myTmp_E2_Den_Chi_Tiet.HH_Phat_Hanh, _
                                                        myTmp_E2_Den_Chi_Tiet.HH_Phat_Tra, _
                                                        myTmp_E2_Den_Chi_Tiet.Truyen_Khai_Thac, _
                                                        myTmp_E2_Den_Chi_Tiet.Truyen_Doi_Soat, _
                                                        myTmp_E2_Den_Chi_Tiet.Chot_SL, _
                                                        myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay)


                    Else

                        myId_E2 = m_E2_Den_Chi_Tiet.Id_E2
                        If m_E2_Den_Chi_Tiet.Tong_So_BP = 0 And m_E2_Den_Chi_Tiet.Khoi_Luong_BP = 0 Then 'Nếu tờ E2 đang được người khác cập nhật
                            MessageBox.Show("Tờ E2 này đang được người khác cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        If m_E2_Den_Chi_Tiet.Id_Ca <> GId_Ca Then
                            If GUserAdmin = False Then 'Được phép sửa đổi
                                MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(m_E2_Den_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(m_E2_Den_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & _
                                                "Bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                If MessageBox.Show("Bản kê E2 này đã được nhập vào ca: " & Mid(m_E2_Den_Chi_Tiet.Id_Ca, 15, 1) & " Ngày: " & myHam_Dung_Chung.ConvertIntToDate_VN(Mid(m_E2_Den_Chi_Tiet.Id_Ca, 7, 8)) & vbNewLine & _
                                                "Bạn có muốn mở không!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    myId_Ca = m_E2_Den_Chi_Tiet.Id_Ca
                                Else
                                    Exit Sub
                                End If

                            End If
                        End If

                        'Gán các thông số có trong chi tiết bản kê E2 được mở
                        chkTuiF.CheckedValue = m_E2_Den_Chi_Tiet.Tui_F
                        txtTrongluongTui.Value = m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui + m_E2_Den_Chi_Tiet.Khoi_Luong_BP
                        myE2_Date = m_E2_Den_Chi_Tiet.Ngay_Dong
                        myE2_Time = m_E2_Den_Chi_Tiet.Gio_Dong
                        myTongso = m_E2_Den_Chi_Tiet.Tong_So_BP
                        myE2_Date_Receiver = m_E2_Den_Chi_Tiet.Ngay_Nhan
                        myE2_Time_Receiver = m_E2_Den_Chi_Tiet.Gio_Nhan
                        myTongKhoiLuongBP = m_E2_Den_Chi_Tiet.Khoi_Luong_BP
                        myId_Ca = m_E2_Den_Chi_Tiet.Id_Ca
                        'Thông báo thông tin về tờ E2
                        If MessageBox.Show("Tờ E2 này có tổng số: " & myTongso & " Bưu phẩm" & vbNewLine & "Bạn có muốn mở tờ E2 này không", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.No Then
                            Exit Sub
                        End If

                        'Ghi Event trước: Mở lại E2
                        Event_Viewer_Open_E2(1, Event_Viewer_Create_Chi_Tiet_E2(m_E2_Den_Chi_Tiet.Id_Duong_Thu, m_E2_Den_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, myTongso, myTongKhoiLuongBP + m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui), "")

                        'Cập nhật lại thông tin E2: Tong_So_BP=0, Khoi_Luong_BP=0
                        m_E2_Den_Chi_Tiet.Tong_So_BP = 0
                        m_E2_Den_Chi_Tiet.Khoi_Luong_BP = 0
                        m_E2_Den_Chi_Tiet.Tui_F = False
                        myE2_Den.E2_Den_Cap_Nhat_Them_KT(m_E2_Den_Chi_Tiet.Id_E2, _
                                                        m_E2_Den_Chi_Tiet.Id_Duong_Thu, _
                                                        m_E2_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                        m_E2_Den_Chi_Tiet.Id_Ca, _
                                                        m_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                        m_E2_Den_Chi_Tiet.Ngay_Dong, _
                                                        m_E2_Den_Chi_Tiet.Gio_Dong, _
                                                        m_E2_Den_Chi_Tiet.Ngay_Nhan, _
                                                        m_E2_Den_Chi_Tiet.Gio_Nhan, _
                                                        m_E2_Den_Chi_Tiet.Tui_So, _
                                                        m_E2_Den_Chi_Tiet.Tui_F, _
                                                        m_E2_Den_Chi_Tiet.Tong_So_BP, _
                                                        m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                        m_E2_Den_Chi_Tiet.Khoi_Luong_BP, _
                                                        m_E2_Den_Chi_Tiet.Tong_Cuoc_COD, _
                                                        m_E2_Den_Chi_Tiet.Tong_Cuoc_DV, _
                                                        m_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                        m_E2_Den_Chi_Tiet.HH_Phat_Hanh, _
                                                        m_E2_Den_Chi_Tiet.HH_Phat_Tra, _
                                                        m_E2_Den_Chi_Tiet.Truyen_Khai_Thac, _
                                                        m_E2_Den_Chi_Tiet.Truyen_Doi_Soat, _
                                                        m_E2_Den_Chi_Tiet.Chot_SL)
                    End If
                Else 'Nếu chưa tồn tại E2

                    'Kiểm tra trong bảng E2_Den_Tam có dữ liệu về tờ E2 này không
                    Dim myChuyen_Thu_Den_Tam As New Chuyen_Thu_Den_Tam(GConnectionString)
                    Dim myE2_Den_Tam As New E2_Den_Tam(GConnectionString)

                    Dim myChuyen_Thu_Den_Tam_Chi_Tiet As New Chuyen_Thu_Den_Tam_Chi_Tiet
                    Dim myE2_Den_Tam_Chi_Tiet As New E2_Den_Tam_Chi_Tiet

                    'Tạo E2 Mới
                    Me.AddNew_E2_Den(myId_Duong_Thu, _
                                    mySo_Chuyen_Thu_Den, _
                                    myTui_So_Den, _
                                    myE2_Date, _
                                    myE2_Time, _
                                    myE2_Date_Receiver, _
                                    myE2_Time_Receiver, _
                                    myLoai_Chuyen_Thu, _
                                    myId_Ca)

                    'Nếu có thì lấy dữ liệu xuống, thay hàm này để lấy dữ liệu quốc tế truyền về từ IPS
                    'myE2_Den_Tam_Chi_Tiet = myE2_Den_Tam.E2_Den_Tam_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Tui_So_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu, myTui_So_Den)
                    myE2_Den_Tam_Chi_Tiet = myE2_Den_Tam.E2_Quoc_Te_Den_Tam_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_KT_So_Chuyen_Thu_Tui_So_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu, myTui_So_Den, myId_Ca)
                    If (myE2_Den_Tam_Chi_Tiet.Id_E2 <> "") And (Not myE2_Den_Tam_Chi_Tiet.Id_E2 Is Nothing) Then 'Có dữ liệu truyền về
                        If MessageBox.Show("Có dữ liệu truyền về gồm " & myE2_Den_Tam_Chi_Tiet.Tong_So_BP.ToString() & " bưu phẩm, Bạn có muốn lấy không", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Lấy dữ liệu truyền về
                            Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)
                            Dim myId_E2_Truyen As String
                            myId_Chuyen_Thu = CreateId_Chuyen_Thu(myId_Duong_Thu, mySo_Chuyen_Thu_Den, myE2_Date, myLoai_Chuyen_Thu)
                            myId_E2 = CreateId_E2(myId_Chuyen_Thu, myTui_So_Den)
                            myId_E2_Truyen = myE2_Den_Tam_Chi_Tiet.Id_E2
                            myE1_Den_Tam.E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT(myId_Chuyen_Thu, myId_E2, GId_Ca, GBuu_Cuc_Khai_Thac, Gid_Nguoi_Dung, myId_E2_Truyen)
                        End If
                    End If
                End If
                'Cập nhật lại thông tin chuyến thư
                myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = 0
                myChuyen_Thu_Den_Chi_Tiet.Dong_F = False

                myChuyen_Thu_Den.Chuyen_Thu_Den_Cap_Nhat_Them_KT(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Ca, myChuyen_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Den_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Den_Chi_Tiet.Dong_F, myChuyen_Thu_Den_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Den_Chi_Tiet.Chot_Sl)
            Else 'Nếu chưa tồn tại chuyến thư
                'Kiểm tra trong bảng E2_Den_Tam có dữ liệu về tờ E2 này không
                Dim myChuyen_Thu_Den_Tam As New Chuyen_Thu_Den_Tam(GConnectionString)
                Dim myE2_Den_Tam As New E2_Den_Tam(GConnectionString)

                Dim myChuyen_Thu_Den_Tam_Chi_Tiet As New Chuyen_Thu_Den_Tam_Chi_Tiet
                Dim myE2_Den_Tam_Chi_Tiet As New E2_Den_Tam_Chi_Tiet

                'Tạo chuyến thư và túi mới
                Me.AddNew_E2_Den(myId_Duong_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, myE2_Date, myE2_Time, myE2_Date_Receiver, myE2_Time_Receiver, myLoai_Chuyen_Thu, myId_Ca)

                'Nếu có thì lấy dữ liệu xuống
                'myE2_Den_Tam_Chi_Tiet = myE2_Den_Tam.E2_Den_Tam_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Tui_So_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu, myTui_So_Den)
                myE2_Den_Tam_Chi_Tiet = myE2_Den_Tam.E2_Quoc_Te_Den_Tam_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_KT_So_Chuyen_Thu_Tui_So_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu, myTui_So_Den, myId_Ca)
                If (myE2_Den_Tam_Chi_Tiet.Id_E2 <> "") And (Not myE2_Den_Tam_Chi_Tiet.Id_E2 Is Nothing) Then 'Có dữ liệu nội địa truyền về
                    If MessageBox.Show("Có dữ liệu truyền về gồm " & myE2_Den_Tam_Chi_Tiet.Tong_So_BP & " bưu phẩm, Bạn có muốn lấy không", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        'Lấy dữ liệu truyền về
                        Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)
                        Dim myId_E2_Truyen As String
                        myId_Chuyen_Thu = CreateId_Chuyen_Thu(myId_Duong_Thu, mySo_Chuyen_Thu_Den, myE2_Date, myLoai_Chuyen_Thu)
                        myId_E2 = CreateId_E2(myId_Chuyen_Thu, myTui_So_Den)
                        myId_E2_Truyen = myE2_Den_Tam_Chi_Tiet.Id_E2
                        myE1_Den_Tam.E1_Den_Tam_Insert_To_E1_Den_Le_Phi_HQ_KT(myId_Chuyen_Thu, myId_E2, GId_Ca, GBuu_Cuc_Khai_Thac, Gid_Nguoi_Dung, myId_E2_Truyen)
                    End If
                Else 'kiểm tra xem có dữ liệu quốc tế truyền về.
                    'dim myE2_Inbound as new E1_Den_Inbound()=
                End If
            End If

            'Hiển thị mã số túi nếu có vào textbox
            Dim strMaSoTui As String = myE2_Den_Ma_Vach_Tui.E2_Den_Ma_Vach_Tui_Lay(myId_E2).Ma_Vach_Tui
            If strMaSoTui <> "" Then
                txtMaSoTui.Text = strMaSoTui
            End If
            '----------------------------------------------------------------------------------------

            'Hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1_Den(myId_E2)
            'Gán thông tin E2 vào txtinfor
            txtInfor.Text = "Tổng Số    : " & myTongso & vbNewLine & "Khối lượng : " & (myTongKhoiLuongBP / 1000) & "  KG"

            IsOpenBag = True
            Enable_Control(IsOpenBag)
            dgE1_Den.Focus()
            myCell = dgE1_Den.Rows(IIf(dgE1_Den.Rows.Count > 0, dgE1_Den.Rows.Count - 1, 0)).Cells("Ma_E1")
            dgE1_Den.ActiveCell = myCell
            dgE1_Den.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)

            'Lấy mã nước hiện tại
            myMa_Nuoc_Hien_Tai = myMa_Nuoc_Den
            Exit Sub
        Catch ex As Exception
            IsOpenBag = False
            MessageBox.Show("Có lỗi trong quá trình mở túi." & vbNewLine & "Bạn hãy khởi động lại chương trình và thực hiện lại chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Enable_Control(IsOpenBag)
        End Try
    End Sub

#Region "-----------------------AddNew_Chuyen_Thu_Den-----------------------"
    Private Sub AddNew_Chuyen_Thu_Den(ByVal Id_Duong_Thu As String, ByVal So_chuyen_thu As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        Id_Chuyen_Thu = CreateId_Chuyen_Thu(Id_Duong_Thu, So_chuyen_thu, Date_Create, Loai_Chuyen_Thu)
        myChuyen_Thu_Den.Chuyen_Thu_Den_Cap_Nhat_Them_KT(Id_Chuyen_Thu, Id_Duong_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, So_chuyen_thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, _
                                                            0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False, False)
        myId_Chuyen_Thu = Id_Chuyen_Thu
    End Sub
#End Region

#Region "-----------------------AddNew_E2_Den-----------------------"
    Private Sub AddNew_E2_Den(ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Date_Receiver As Integer, ByVal Time_Receiver As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        If myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, Date_Create, So_Chuyen_Thu, Loai_Chuyen_Thu).Id_Chuyen_Thu = "" Then
            AddNew_Chuyen_Thu_Den(Id_Duong_Thu, So_Chuyen_Thu, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Loai_Chuyen_Thu, Id_Ca)
        End If
        '        myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = myChuyen_Thu_Den.Tim_Id_Chuyen_Thu_Den(Id_Duong_Thu, Date_Create, So_Chuyen_Thu, Loai_Chuyen_Thu)
        myId_E2 = CreateId_E2(myId_Chuyen_Thu, Tui_So)
        myE2_Den.E2_Den_Cap_Nhat_Them_KT(myId_E2, Id_Duong_Thu, myId_Chuyen_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, Date_Create, Time_Create, Date_Receiver, Time_Receiver, Tui_So, _
                                            False, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False)
    End Sub
#End Region

#Region "-----------------------DataGrid_Nhap_E1_Den-----------------------"
    Private Sub DataGrid_Nhap_E1_Den(ByVal Id_E2 As String)
        'dgE1_Den.DataSource = myE1_Den.E1_Den_Lay_Boi_Id_E2_KT(Id_E2)
        dgE1_Den.DataSource = myE1_Den.E1_Den_Lay_Boi_Id_E2_Le_Phi_HQ_KT(Id_E2) 'Thêm cột nhập lệ phí hải quan và thuế nhập khẩu
        dgE1_Den.DataBind()
        dgE1_Den.Rows.Band.AddNew()
    End Sub
#End Region
#End Region

#Region "Đóng Túi"
    Private Sub DongTui() 'Đóng tờ E2
        Try
            Dim i As Integer
            Dim Tong_Khoi_Luong As Integer
            If dgE1_Den.Rows.Count > 0 Then 'Nếu tồn tại ít nhất 1 dòng
                'Tính tổng trọng lượng bưu phẩm
                Tong_Khoi_Luong = 0
                For i = 0 To dgE1_Den.Rows.Count - 1
                    If dgE1_Den.Rows(i).Cells("Ma_E1").Text <> "" Then
                        Tong_Khoi_Luong += CInt(dgE1_Den.Rows(i).Cells("Khoi_Luong").Text)
                    End If
                Next

                If GOutBout = 0 Then 'Nếu là quốc tế đến thì kiểm tra trọng lượng vỏ túi
                    If dgE1_Den.Rows.Count > 0 Then 'nếu tồn tại ít nhất 1 dòng
                        'Kiểm tra lại thông tin về trọng lượng túi: trọng lượng cái + trọng lượng vỏ túi
                        Dim mTrongLuongTui As Integer
                        mTrongLuongTui = CInt(SetNullValue(txtTrongluongTui.Text, 0))
                        If mTrongLuongTui = 0 Then
                            If MessageBox.Show("             Bạn chưa nhập thông tin về Trọng lượng túi!!!" & vbNewLine & _
                                                "Chọn Yes nếu bạn muốn lấy Trọng lượng túi = Tổng trọng lượng bưu phẩm" & vbNewLine & _
                                                "            Chọn No nếu bạn muốn nhập Trọng lượng túi", _
                                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                txtTrongluongTui.Focus()
                                Exit Sub
                            End If
                            txtTrongluongTui.Text = Tong_Khoi_Luong
                            'myE2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = CInt(Trim(txtTrongluongTui.Value))
                        ElseIf mTrongLuongTui < Tong_Khoi_Luong Then 'Nếu khối lượng túi < tổng khối lượng bưu phẩm
                            MessageBox.Show("Tổng trọng lượng bưu phẩm > Trọng lượng túi!!!" & vbNewLine & _
                                            "Bạn hãy nhập lại thông tin về trọng lượng túi", _
                                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtTrongluongTui.SelectAll()
                            txtTrongluongTui.Focus()
                            Exit Sub
                        End If
                    End If
                Else 'Nếu không phải là quốc tế đến thì cập nhật lại thông tin về tổng trọng lượng túi = tổng trọng lượng bưu phẩm
                    txtTrongluongTui.Text = Tong_Khoi_Luong
                End If
            End If

            'Tổng hợp E2 Đi từ E1 Đi
            Me.Tong_Hop_E2_Den_tu_E1_Den(myId_E2)
            'Tổng hợp Chuyến thư đi từ E2 Đi
            Me.Tong_Hop_Chuyen_Thu_Den_tu_E2_Den(myId_Chuyen_Thu)

            Truyen_Du_Lieu_Khai_Thac()

            'Bỏ hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1_Den(0)
            'Sau khi đóng chuyến thư: enable tất cả các control 


            IsOpenBag = False
            chkTuiF.Checked = False
            'chkInkhidongE2.Checked = False
            chkInE4.Checked = False
            chkInBC37.Checked = False
            cbChuyenBayDen.Enabled = False
            txtTrongluongTui.Text = "0" 'Cho trọng lượng túi trở về 0
            txtInfor.Text = "Tổng Số    : 0 " & vbNewLine & "Khối lượng : 0" & "  KG"
            Enable_Control(IsOpenBag)
            txtMaSoTui.Text = ""
            cbMaNuoc.Focus()
        Catch ex As Exception
            Enable_Control(IsOpenBag)
            txtMaSoTui.Text = ""
            cbMaNuoc.Focus()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "-----------------------Tổng hợp E2_Den từ E1_Den-----------------------"
    Private Sub Tong_Hop_E2_Den_tu_E1_Den(ByVal Id_E2 As String)
        Dim m_E2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
        Dim m_E2_Den_TH_E1_Den As New E2_Den_Chi_Tiet
        Dim m_Tmp_E2_Den_Chi_Tiet As New Tmp_E2_Den_Chi_Tiet

        m_E2_Den_Chi_Tiet = myE2_Den.E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        m_E2_Den_TH_E1_Den = myE2_Den.E2_Den_Tong_Hop_Tu_E1_Den_KT(m_E2_Den_Chi_Tiet.Id_E2)

        m_Tmp_E2_Den_Chi_Tiet = myTmp_E2_Den.Tmp_E2_Den_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        Dim myId_Duong_Bay As String = m_E2_Den_Chi_Tiet.Id_Duong_Thu + cbChuyenBayDen.Text

        m_E2_Den_Chi_Tiet.Tong_So_BP = m_E2_Den_TH_E1_Den.Tong_So_BP

        If m_E2_Den_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
            m_E2_Den_Chi_Tiet.Tui_F = CBool(chkTuiF.Checked)
            'Tìm khối lượng vỏ túi = Tổng trọng lượng túi - Tổng trọng lượng bưu phẩm
            Dim Trong_Luong_Tui As Integer
            Trong_Luong_Tui = CInt(SetNullValue(Trim(txtTrongluongTui.Value), 0))
            m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui = Trong_Luong_Tui - m_E2_Den_TH_E1_Den.Khoi_Luong_BP
            m_E2_Den_Chi_Tiet.Khoi_Luong_BP = m_E2_Den_TH_E1_Den.Khoi_Luong_BP
            m_E2_Den_Chi_Tiet.Tong_Cuoc_COD = m_E2_Den_TH_E1_Den.Tong_Cuoc_COD
            m_E2_Den_Chi_Tiet.Tong_Cuoc_DV = m_E2_Den_TH_E1_Den.Tong_Cuoc_DV
            m_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh = m_E2_Den_TH_E1_Den.Tong_Cuoc_Chinh
            m_E2_Den_Chi_Tiet.HH_Phat_Hanh = m_E2_Den_TH_E1_Den.HH_Phat_Hanh
            m_E2_Den_Chi_Tiet.HH_Phat_Tra = m_E2_Den_TH_E1_Den.HH_Phat_Tra
            myE2_Den.E2_Den_Cap_Nhat_Them_KT(m_E2_Den_Chi_Tiet.Id_E2, _
                                                m_E2_Den_Chi_Tiet.Id_Duong_Thu, _
                                                m_E2_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                m_E2_Den_Chi_Tiet.Id_Ca, _
                                                m_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                m_E2_Den_Chi_Tiet.Ngay_Dong, _
                                                m_E2_Den_Chi_Tiet.Gio_Dong, _
                                                m_E2_Den_Chi_Tiet.Ngay_Nhan, _
                                                m_E2_Den_Chi_Tiet.Gio_Nhan, _
                                                m_E2_Den_Chi_Tiet.Tui_So, _
                                                m_E2_Den_Chi_Tiet.Tui_F, _
                                                m_E2_Den_Chi_Tiet.Tong_So_BP, _
                                                m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                m_E2_Den_Chi_Tiet.Khoi_Luong_BP, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_COD, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_DV, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                m_E2_Den_Chi_Tiet.HH_Phat_Hanh, _
                                                m_E2_Den_Chi_Tiet.HH_Phat_Tra, _
                                                m_E2_Den_Chi_Tiet.Truyen_Khai_Thac, _
                                                m_E2_Den_Chi_Tiet.Truyen_Doi_Soat, _
                                                m_E2_Den_Chi_Tiet.Chot_SL)

            'Them phần cập nhật vào bảng E2_Den_Ma_Vach_Tui để lưu mã số túi truyền RESDES
            myE2_Den_Ma_Vach_Tui.E2_Den_Ma_Vach_Tui_Cap_Nhat_Them(Id_E2, txtMaSoTui.Text, 0, 0)
            '------------------------------------------------------------------------------------------------------

            'Cập nhật vào bảng Tmp_E2_Den thêm trường Id_Duong_Bay
            myTmp_E2_Den.Tmp_E2_Den_Cap_Nhat_Them_KT(m_E2_Den_Chi_Tiet.Id_E2, _
                                                m_E2_Den_Chi_Tiet.Id_Duong_Thu, _
                                                m_E2_Den_Chi_Tiet.Id_Chuyen_Thu, _
                                                m_E2_Den_Chi_Tiet.Id_Ca, _
                                                m_E2_Den_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                m_E2_Den_Chi_Tiet.Ngay_Dong, _
                                                m_E2_Den_Chi_Tiet.Gio_Dong, _
                                                m_E2_Den_Chi_Tiet.Ngay_Nhan, _
                                                m_E2_Den_Chi_Tiet.Gio_Nhan, _
                                                m_E2_Den_Chi_Tiet.Tui_So, _
                                                m_E2_Den_Chi_Tiet.Tui_F, _
                                                m_E2_Den_Chi_Tiet.Tong_So_BP, _
                                                m_E2_Den_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                                                m_E2_Den_Chi_Tiet.Khoi_Luong_BP, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_COD, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_DV, _
                                                m_E2_Den_Chi_Tiet.Tong_Cuoc_Chinh, _
                                                m_E2_Den_Chi_Tiet.HH_Phat_Hanh, _
                                                m_E2_Den_Chi_Tiet.HH_Phat_Tra, _
                                                m_E2_Den_Chi_Tiet.Truyen_Khai_Thac, _
                                                m_E2_Den_Chi_Tiet.Truyen_Doi_Soat, _
                                                m_E2_Den_Chi_Tiet.Chot_SL, _
                                                myId_Duong_Bay)

        Else 'Nếu không tồn tại E1-> Xóa
            myE2_Den.Xoa(Id_E2)
            myTmp_E2_Den.Xoa(Id_E2)
            myE2_Den_Ma_Vach_Tui.E2_Den_Ma_Vach_Tui_Xoa(Id_E2)
        End If


        'Ghi Event: Đóng Tờ E2
        If myLog_Id <> 0 Then 'Nếu đã có sự kiện mở thì ghi sự kiện đóng
            Event_Viewer_Close_E2(myLog_Id, 1, Event_Viewer_Create_Chi_Tiet_E2(m_E2_Den_Chi_Tiet.Id_Duong_Thu, m_E2_Den_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, m_E2_Den_Chi_Tiet.Tong_So_BP, m_E2_Den_Chi_Tiet.Khoi_Luong_BP + CInt(Trim(txtTrongluongTui.Value))))
        End If
    End Sub
#End Region

#Region "-----------------------Tổng hợp Chuyen_Thu_Den từ E2_Den-----------------------"
    Private Sub Tong_Hop_Chuyen_Thu_Den_tu_E2_Den(ByVal Id_Chuyen_Thu As String)
        Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
        Dim myChuyen_Thu_Den_TH_tu_E2_Den As New Chuyen_Thu_Den_Chi_Tiet

        myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
        myChuyen_Thu_Den_TH_tu_E2_Den = myChuyen_Thu_Den.Chuyen_Thu_Den_Tong_Hop_Tu_E2_Den_KT(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu)

        myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_So_Tui

        If myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui > 0 Then 'Nếu tồn tại it nhất 1 bản kê E2 Update lại thông tin trên Chuyến thư
            myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_So_BP
            myChuyen_Thu_Den_Chi_Tiet.Tong_KL = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_KL
            myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_KLBP
            myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc_COD
            myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc_DV
            myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc = myChuyen_Thu_Den_TH_tu_E2_Den.Tong_Cuoc
            myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh = myChuyen_Thu_Den_TH_tu_E2_Den.HH_Phat_Hanh
            myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra = myChuyen_Thu_Den_TH_tu_E2_Den.HH_Phat_Tra
            myChuyen_Thu_Den_Chi_Tiet.Dong_F = myChuyen_Thu_Den_TH_tu_E2_Den.Dong_F
            myChuyen_Thu_Den.Chuyen_Thu_Den_Cap_Nhat_Them_KT(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Id_Ca, myChuyen_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Den_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Den_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Den_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Den_Chi_Tiet.Dong_F, myChuyen_Thu_Den_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Den_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Den_Chi_Tiet.Chot_Sl)
            'Lấy dữ liệu vào bản kê CN38Den
            Dim myFlight_Date As Integer = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
            Dim myId_Duong_Bay As String = (myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu & cbChuyenBayDen.Text)
            Dim myDate As Date = Date.Now
            If cbChuyenBayDen.Rows.Count <> 0 Then 'Nếu không tồn tại đường bay
                If Tim_Duong_Bay(Id_Chuyen_Thu) <> "" Then
                    If Tim_Duong_Bay(Id_Chuyen_Thu) <> cbChuyenBayDen.Value Then
                        myCN38Den.Cap_Nhat_Them(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myId_Duong_Bay, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, Ham_Dung_Chung.ConvertDateToInt(myDate), myFlight_Date, myE2_Time)
                    End If
                    If myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui <> myCN38Den.CN38Den_lay_Tong_So_Tui_Theo_Id_Chuyen_Thu(Id_Chuyen_Thu) Then
                        myCN38Den.Cap_Nhat_Them(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myId_Duong_Bay, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, Ham_Dung_Chung.ConvertDateToInt(myDate), myFlight_Date, myE2_Time)
                    End If
                Else
                        myCN38Den.Them(myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, myId_Duong_Bay, myChuyen_Thu_Den_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Den_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Den_Chi_Tiet.Gio_Dong, myChuyen_Thu_Den_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Den_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Den_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Den_Chi_Tiet.Tong_KL, myChuyen_Thu_Den_Chi_Tiet.Tong_KLBP, Ham_Dung_Chung.ConvertDateToInt(myDate), myFlight_Date, myE2_Time)

                    End If
                End If
            Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
                myChuyen_Thu_Den.Xoa(Id_Chuyen_Thu)
                myCN38Den.Xoa(Id_Chuyen_Thu)
        End If
    End Sub
#End Region
#End Region
#End Region

#Region "-----------------------btnPreview_Click-----------------------"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            Open_Report(True, chkTuiF.Checked, chkInkhidongE2.Checked, chkInE4.Checked, chkInBC37.Checked, CInt(SetNullValue(txtBanE2.Text, "0")), CInt(SetNullValue(txtBanBC37.Text, "0")))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------btnPrint_Click-----------------------"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Open_Report(False, chkTuiF.Checked, chkInkhidongE2.Checked, chkInE4.Checked, chkInBC37.Checked, CInt(SetNullValue(txtBanE2.Text, "0")), CInt(SetNullValue(txtBanBC37.Text, "0")))
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Open_Report-----------------------"
    Private Sub Open_Report(ByVal Preview As Boolean, ByVal Tui_F As Boolean, ByVal In_E2 As Boolean, ByVal In_E4 As Boolean, ByVal In_Bc37 As Boolean, ByVal So_Ban_E2 As Integer, ByVal So_Ban_Bc37 As Integer)
        'Lấy thông tin về bản kê E2
        Dim Ngay_Dong As Integer
        Dim Duong_Thu As Integer
        Dim Loai_Chuyen_Thu As String
        Dim So_Chuyen_Thu As Integer
        Dim Tui_So As Integer
        Dim Duong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
        Dim Start_Date As Integer
        Dim End_Date As Integer

        'Lấy thông tin tại combobox
        If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(cbDuongThuDen.Text), CInt(cbChuyenThuDen.Text), CInt(cbTuiSoDen.Text), cbChuyenBayDen.Text) = False Then Exit Sub 'Thông tin nhập không đầy đủ

        Ngay_Dong = myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
        Duong_Thu = CInt(cbDuongThuDen.Text)
        So_Chuyen_Thu = CInt(cbChuyenThuDen.Text)
        Tui_So = CInt(cbTuiSoDen.Text)
        Loai_Chuyen_Thu = Trim(cbLoai_Chuyen_Thu.Text)
        'Lấy thông tin về đường thư đi
        Duong_Thu_Den_Chi_Tiet.Id_Duong_Thu = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, Duong_Thu).Rows(0)("Id_Duong_Thu")

        'Lấy thông tin về chuyến thư đi
        Dim Chuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
        Chuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Duong_Thu_Den_Chi_Tiet.Id_Duong_Thu, Ngay_Dong, So_Chuyen_Thu, Loai_Chuyen_Thu)
        If Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu = "" Then Exit Sub

        'Lấy thông tin về bản kê E2
        Dim E2_Den_Chi_Tiet As New E2_Den_Chi_Tiet
        E2_Den_Chi_Tiet = myE2_Den.E2_Den_Chi_Tiet_Lay_Boi_Chuyen_Thu_Den_Tui_So_KT(Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, Tui_So)
        If E2_Den_Chi_Tiet.Id_E2 = "" Then Exit Sub

        If Preview Then 'Nếu nhấn Preview thì chỉ xem được 1 bản kê
            If Not In_Bc37 And Not In_E4 Then
                If GIn_Kim_QT_Den Then
                    'Dim In_E2_TEXT As New In_E2_TEXT
                    'In_E2_TEXT.Ban_Ke_E2_Di_To_Text(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)   'In E2\
                    Ban_Ke_E2_Den_KhaiThac(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)  'In E2
                Else
                    Ban_Ke_E2_Den_KhaiThac(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)  'In E2
                End If
            ElseIf In_Bc37 Then
                'PrintBC37(Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37) 'In Bc37
            ElseIf In_E4 Then
                'PrintE4(Preview, E2_Den_Chi_Tiet.Id_E2) 'In E4
            End If
        Else 'Nếu nhấn Print: in tất cả các bản kê được chọn
            If In_E2 Then
                If GIn_Kim_QT_Den Then
                    'Dim In_E2_TEXT As New In_E2_TEXT
                    'In_E2_TEXT.Ban_Ke_E2_Di_To_Text(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)   'In E2
                    Ban_Ke_E2_Den_KhaiThac(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)  'In E2
                Else
                    Ban_Ke_E2_Den_KhaiThac(E2_Den_Chi_Tiet.Id_E2, Preview, So_Ban_E2)  'In E2
                End If
            End If
            'In E4
            If In_E4 Then
                'PrintE4(Preview, E2_Den_Chi_Tiet.Id_E2) 'In E4
            End If
            'In Bc37
            If In_Bc37 Then
                'PrintBC37(Preview, Chuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu, So_Ban_Bc37) 'In Bc37
            End If
        End If
    End Sub
#End Region

#Region "-----------------------BtnTimE1_Click-----------------------"
    Private Sub BtnTimE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTimE1.Click
        Dim frm As New FrmTimKiemE1
        frm.ShowDialog()
    End Sub
#End Region

#Region "-----------------------btnClose_Click-----------------------"
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
#End Region

#Region "Truyen_Du_Lieu_Khai_Thac_tuyennv"
    Private Sub Truyen_Du_Lieu_Khai_Thac_tuyennv(ByVal myId_Chuyen_Thu As String)
        Dim mydataset As New DataSet
        Dim mytable As New DataTable

        'myDuong_Thu_Den_Chi_Tiet = myDuong_Thu_Den.Lay(myId_Duong_Thu)
        'If myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = False Then
        '    Exit Sub
        'End If

        'Chuyen_Thu_Di
        mytable = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Chuyen_Thu"
        mydataset.Tables.Add(mytable.Copy)

        'E2_Di
        mytable = myE2_Den.Danh_Sach_E2_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E2"
        mydataset.Tables.Add(mytable.Copy)

        'E1_Di
        mytable = myE1_Den.Danh_Sach_E1_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E1"
        mydataset.Tables.Add(mytable.Copy)

        'COD_Di
        mytable = myCODDen.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "COD"
        mydataset.Tables.Add(mytable.Copy)

        mytable = myTrang_Thai.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Trang_Thai"
        mydataset.Tables.Add(mytable.Copy)

        If myUtility.Dang_Ky_Truyen("Ems_E2_Den", "Branch", "PO", GBuu_Cuc_Khai_Thac, myDuong_Thu_Den_Chi_Tiet.Ma_Bc, Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset) <> 0 Then
            MessageBox.Show("Dang ky truyen Ems_E2_Den Loi", "Thong bao")
        End If

        'Cập nhật lại thông tin đã truyền
        myChuyen_Thu_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE2_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE1_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myTrang_Thai.Cap_Nhat_Truyen(myId_Chuyen_Thu)
    End Sub
#End Region
#End Region

#Region "-----------------------Commbo Box-----------------------"
#Region "Combobox KeyDown"
#Region "Handles cbNgayDong.KeyDown"
    Private Sub cbNgayDong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbNgayDong.KeyDown
        Select Case e.KeyValue
            Case 13 'Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 40 'Down

            Case Else
        End Select
    End Sub
#End Region

#Region "Handles cbMaNuoc.KeyDown, cbDuongThuDen.KeyDown,cbChuyenBayDen.KeyDown,cbLoai_Chuyen_Thu.KeyDown, cbChuyenThuDen.KeyDown, cbTuiSoDen.KeyDown"
    Private Sub Combobox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
                    Handles cbMaNuoc.KeyDown, cbDuongThuDen.KeyDown, cbChuyenBayDen.KeyDown, cbLoai_Chuyen_Thu.KeyDown, cbChuyenThuDen.KeyDown, cbTuiSoDen.KeyDown
        myComboKeyDown = sender
        Select Case e.KeyValue
            Case 13 'Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Right

            Case 38 'Up

            Case 40 'Down
                If myComboKeyDown.IsDroppedDown = False Then
                    myComboKeyDown.ToggleDropdown()
                End If
            Case Else
        End Select
    End Sub
#End Region
#End Region

#Region "Ngày Đóng"
    Private Sub cbNgayDong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.AfterExitEditMode
        Lay_TT_Ngay_E2()
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date)
    End Sub
#End Region

#Region "Mã Nước"
#Region "cbMaNuoc_Validated"
    Private Sub cbMaNuoc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMaNuoc.Validated
        myMa_Nuoc_Den = cbMaNuoc.Value
        Me.cbDuongThuDen.DataSource = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT(GBuu_Cuc_Khai_Thac, IIf(myMa_Nuoc_Den = "", "VN", myMa_Nuoc_Den))
        If cbDuongThuDen.Rows.Count > 0 Then
            If myMa_Nuoc_Hien_Tai <> myMa_Nuoc_Den Then
                cbDuongThuDen.Value = cbDuongThuDen.Rows(0).Cells("Ma_Bc").Value
            End If
        Else
            MessageBox.Show("Không tồn tại đường thư nào thuộc nước này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbMaNuoc.Focus()
            Exit Sub
        End If
        cbDuongThuDen.DataBind()
        cbDuongThuDen.LimitToList = True
        'Kiểm tra đường thư trong nước
        If cbMaNuoc.Text = "VN" Then
            cbLoai_Chuyen_Thu.Text = "EN"
            cbLoai_Chuyen_Thu.Enabled = False
            cbChuyenBayDen.Text = ""
            cbChuyenBayDen.Enabled = False
        Else
            cbLoai_Chuyen_Thu.Enabled = True
            cbChuyenBayDen.Enabled = True
        End If
    End Sub
#End Region
#End Region

#Region "Đường Thư"
#Region "cbDuongThuDen_Validated"
    Private Sub cbDuongThuDen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuDen.Validated
        If IsNumeric(cbDuongThuDen.Text) = False And cbDuongThuDen.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbDuongThuDen.Focus()
            Exit Sub
        End If
        If cbMaNuoc.Value <> "VN" Then
            ChuyenBayDen()
        Else
        End If
        Lay_TT_Duong_Thu()
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Den_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")"
        'Lấy mã nước hiện tại
        myMa_Nuoc_Hien_Tai = myMa_Nuoc_Den
        'Them
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        Lay_TT_Duong_Thu()
        mySo_Chuyen_Thu_Den_Lon_Nhat = myChuyen_Thu_Den.Tim_So_Chuyen_Thu_Den_Lon_Nhat(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
        cbChuyenThuDen.DataSource = myChuyen_Thu_Den.Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        If mySo_Chuyen_Thu_Den_Lon_Nhat > 0 Then
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDen.Value = mySo_Chuyen_Thu_Den_Lon_Nhat
                Else
                    cbChuyenThuDen.Text = mySo_Chuyen_Thu_Den_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                cbChuyenThuDen.Text = 1
            End If
        End If
        'Thêm phần kiểm tra thêm thông tin của đường thư đi: Nước đến, Tỉnh đến
        myMa_Nuoc_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Den_Chi_Tiet.Ma_Bc).Ma_Nc
        If myMa_Nuoc_Theo_Duong_Thu = "VN" Then
            myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Den_Chi_Tiet.Ma_Bc).Ma_Tinh
        Else
            myMa_Tinh_Theo_Duong_Thu = 0
        End If
    End Sub
#End Region
#End Region

#Region "Loại Chuyến Thư"
#Region "cbLoai_Chuyen_Thu_Validated"
    Private Sub cbLoai_Chuyen_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoai_Chuyen_Thu.Validated
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        Lay_TT_Duong_Thu()
        mySo_Chuyen_Thu_Den_Lon_Nhat = myChuyen_Thu_Den.Tim_So_Chuyen_Thu_Den_Lon_Nhat(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
        cbChuyenThuDen.DataSource = myChuyen_Thu_Den.Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
        If mySo_Chuyen_Thu_Den_Lon_Nhat > 0 Then
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDen.Value = mySo_Chuyen_Thu_Den_Lon_Nhat
                Else
                    cbChuyenThuDen.Text = mySo_Chuyen_Thu_Den_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                cbChuyenThuDen.Text = 1
            End If
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine _
                                & "Đường Thư:" & CStr(myDuong_Thu_Den_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                                & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text
    End Sub
#End Region
#End Region

#Region "Chuyến Thư"
#Region "cbChuyenThuDen_BeforeDropDown"
    Private Sub cbChuyenThuDen_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbChuyenThuDen.BeforeDropDown
        If cbDuongThuDen.Text <> "" Then
            cbChuyenThuDen.Text = ""
            mySo_Chuyen_Thu_Den_Lon_Nhat = myChuyen_Thu_Den.Tim_So_Chuyen_Thu_Den_Lon_Nhat(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
            'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
            cbChuyenThuDen.DataSource = myChuyen_Thu_Den.Chuyen_Thu_Den_Lay_Boi_Duong_Thu_Den_Loai_Chuyen_Thu_Ngay_KT(myId_Duong_Thu, myE2_Date, myLoai_Chuyen_Thu)
            If mySo_Chuyen_Thu_Den_Lon_Nhat > 0 Then
                If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                    If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                        cbChuyenThuDen.Value = mySo_Chuyen_Thu_Den_Lon_Nhat
                    Else
                        cbChuyenThuDen.Text = mySo_Chuyen_Thu_Den_Lon_Nhat + 1
                    End If
                End If
            Else
                If (cbChuyenThuDen.Text = "") Or (cbChuyenThuDen.Text = "0") Then
                    cbChuyenThuDen.Text = 1
                End If
            End If
        End If
    End Sub
#End Region

#Region "cbChuyenThuDen_Validated"
    Private Sub cbChuyenThuDen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChuyenThuDen.Validated
        If IsNumeric(cbChuyenThuDen.Text) = False And cbChuyenThuDen.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbChuyenThuDen.Focus()
            Exit Sub
        Else
            Lay_TT_Chuyen_Thu()

            cbTuiSoDen.LimitToList = False
            If (cbTuiSoDen.Text = "") Or (cbTuiSoDen.Text = "0") Then
                myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu)
                If myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu <> "" Then
                    myId_Chuyen_Thu = myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                    myTui_So_Den_LonNhat = myE2_Den.Tim_So_Tui_Den_Lon_Nhat(myId_Chuyen_Thu)
                    cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(myId_Chuyen_Thu)
                    If cbTuiSoDen.Rows.Count > 0 Then 'Nếu tồn tại ít nhất 1 bản kê
                        If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư đã đóng F chưa
                            cbTuiSoDen.Text = myTui_So_Den_LonNhat + 1
                        Else
                            cbTuiSoDen.Text = myTui_So_Den_LonNhat
                        End If
                    Else
                        myTui_So_Den_LonNhat = 0
                        cbTuiSoDen.Text = 1
                    End If
                Else 'Nếu chưa tồn tại chuyến thư
                    If cbTuiSoDen.Text = "" Then
                        Me.cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(0)
                        cbTuiSoDen.Text = 1
                    End If
                End If
            End If
        End If
        'If cbChuyenBayDen.Value <> Tim_Duong_Bay(myId_Chuyen_Thu) Then
        '    If MessageBox.Show("Đã xác nhận chuyến bay đến cho chuyến thư này, bạn có muốn thêm chuyến bay khác ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
        '        cbChuyenBayDen.Value = Tim_Duong_Bay(myId_Chuyen_Thu)
        '    Else
        '        cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
        '    End If
        'End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Den_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")" & _
                                    vbNewLine & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "- Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Den)
    End Sub
#End Region
#End Region

#Region "Túi Số"
#Region "cbTuiSoDen_BeforeDropDown"
    Private Sub cbTuiSoDen_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTuiSoDen.BeforeDropDown
        If cbChuyenThuDen.Text <> "" Then
            Lay_TT_Chuyen_Thu()
            cbTuiSoDen.LimitToList = False
            myChuyen_Thu_Den_Chi_Tiet = myChuyen_Thu_Den.Chuyen_Thu_Den_Chi_Tiet_Lay_Boi_Duong_Thu_Den_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den, myLoai_Chuyen_Thu)
            If myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu <> "" Then
                myId_Chuyen_Thu = myChuyen_Thu_Den_Chi_Tiet.Id_Chuyen_Thu
                myTui_So_Den_LonNhat = myE2_Den.Tim_So_Tui_Den_Lon_Nhat(myId_Chuyen_Thu)
                cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(myId_Chuyen_Thu)
                If cbTuiSoDen.Rows.Count > 0 Then 'Nếu tồn tại ít nhất 1 bản kê
                    If myChuyen_Thu_Den.Chuyen_Thu_Den_Dong_F(myId_Duong_Thu, myE2_Date, mySo_Chuyen_Thu_Den_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư đã đóng F chưa
                        cbTuiSoDen.Text = myTui_So_Den_LonNhat + 1
                    Else
                        cbTuiSoDen.Text = myTui_So_Den_LonNhat
                    End If
                Else
                    myTui_So_Den_LonNhat = 0
                    cbTuiSoDen.Text = 1
                End If
            Else 'Nếu chưa tồn tại chuyến thư
                If cbTuiSoDen.Text = "" Then
                    Me.cbTuiSoDen.DataSource = myE2_Den.E2_Den_Lay_Boi_Chuyen_Thu_Den_KT(0)
                    cbTuiSoDen.Text = 1
                End If
            End If
        End If
    End Sub
#End Region

#Region "cbTuiSoDen_Validated"
    Private Sub cbTuiSoDen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTuiSoDen.Validated
        If IsNumeric(cbTuiSoDen.Text) = False And cbTuiSoDen.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbTuiSoDen.Focus()
            Exit Sub
        Else
            Lay_TT_E2()
            'If cbChuyenThuDen.Value <> 0 Then
            '    myId_Chuyen_Thu = (cbDuongThuDen.Text & "0" & GBuu_Cuc_Khai_Thac & Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.DateTime) & cbChuyenThuDen.Text & cbLoai_Chuyen_Thu.Text)
            '    myId_E2 = myId_Chuyen_Thu & cbTuiSoDen.Text
            '    If Tim_Duong_Bay_Theo_Id_E2(myId_E2) <> "" Then
            '        If cbChuyenBayDen.Value <> Tim_Duong_Bay_Theo_Id_E2(myId_E2) Then
            '            If GUserAdmin = True Then 'là quản trị tuyệt đối
            '                If MessageBox.Show("Đã xác nhận chuyến bay đến cho chuyến thư túi số này, bạn có muốn thêm chuyến bay khác ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            '                    cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
            '                Else
            '                    cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
            '                End If
            '            Else
            '                MessageBox.Show("Đã xác nhận chuyến bay đến cho chuyến thư túi số này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
            '            End If
            '        End If
            '    End If
            'End If
            Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(Me.cbDuongThuDen.Value) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")" & _
                                    vbNewLine & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "- Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Den) & " - Túi Số: " & myTui_So_Den
            End If
    End Sub
#End Region
#End Region

#Region "Chuyến Bay"
#Region "ChuyenBayDen_Validate"
    'Private Sub ChuyenBayDen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChuyenBayDen.Validated
    '    If txtMaSoTui.Value <> "" Then
    '        If Tim_Duong_Bay(myId_Chuyen_Thu) <> "" Then
    '            If GUserAdmin = True Then 'là quản trị tuyệt đối
    '                If MessageBox.Show("Đã xác nhận chuyến bay đến cho chuyến thư túi số này, bạn có muốn thêm chuyến bay khác ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
    '                    cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
    '                Else
    '                    cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
    '                End If
    '            Else
    '                MessageBox.Show("Đã xác nhận chuyến bay đến cho chuyến thư túi số này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
    '            End If
    '        End If
    '        btnMoTui.Focus()
    '    Else
    '    Exit Sub
    '    End If
    'End Sub
#End Region
#Region " ChuyenBayDen"
    Private Sub ChuyenBayDen()
        Try
            Dim myData As DataTable
            Dim mMa_Bc As Integer
            Dim mId_Duong_Thu As String
            If IsNumeric(cbDuongThuDen.Value) Then
                mMa_Bc = cbDuongThuDen.Value
            Else
                mMa_Bc = 0
            End If
            'myData = myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_So_Hieu_Boi_Ma_Bc_Gui(cbDuongThuDen.Value, GBuu_Cuc_Khai_Thac).Tables(0)
            mId_Duong_Thu = CreateId_Duong_Thu(mMa_Bc, GBuu_Cuc_Khai_Thac)
            myData = myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_So_Hieu_Boi_Id_Duong_Thu(mId_Duong_Thu).Tables(0)
            If myData.Rows.Count > 0 Then
                cbChuyenBayDen.DataSource = myData
                cbChuyenBayDen.DataBind()
                cbChuyenBayDen.LimitToList = True
                If cbChuyenBayDen.Value <> "" Then
                    cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
                    'Dim myId_Duong_Bay = (cbDuongThuDen.Text & GBuu_Cuc_Khai_Thac & cbChuyenBayDen.Text)
                    'myData = myCN38Den.CN38Den_lay_Id_Duong_Bay(myId_Duong_Bay).Tables(0)
                    'If myData.Rows.Count > 0 Then
                Else
                    cbChuyenBayDen.Value = ""
                End If
            Else
                MessageBox.Show("Bạn phải nhập chuyến bay đến cho đường thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbChuyenBayDen.Text = ""
                Dim myFrm As New FrmCacBangDanhMuc
                myFrm.ShowDialog()
                cbDuongThuDen.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region
#End Region

#End Region

#Region "-----------------------Text Box-----------------------"
#Region "txtTrongluongTui_KeyDown"
    Private Sub txtTrongluongTui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTrongluongTui.KeyDown
        Select Case e.KeyValue
            Case 13 'Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 40 'Down

            Case Else
        End Select
    End Sub
#End Region

#Region "txtDauMa_Leave"
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

#Region "Nhập thông tin từ mã số túi"

#Region "txtMaSoTui_Validated"
    Private Sub txtMaSoTui_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaSoTui.Validated
        Try
            If txtMaSoTui.Text <> "" Then
                txtMaSoTui.Text = txtMaSoTui.Text.ToUpper()
                Dim myMa_So_Tui As String
                myMa_So_Tui = txtMaSoTui.Text.ToUpper
                If myMa_So_Tui.Length = 29 Then 'Đầy đủ dữ liệu

                    'Tìm mã nước, mã đường thư, loại chuyến thư, số chuyến thư, túi sô
                    Dim c1 As String
                    Dim i As String
                    i = 0
                    While i <= 14
                        c1 = myMa_So_Tui.Substring(i, 1) 'Mid(txtMaSoTui.Text, i, 1)
                        If (Val(c1) > 0 And Val(c1) < 9) Then
                            MessageBox.Show("Mã số túi sai, xin mời bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtMaSoTui.Select()
                            Exit Sub
                        End If
                        i = i + 1
                    End While
                    'Nhập các thông tin theo mã số túi
                    'Tìm nước đến
                    Dim myMa_Bc_Chu As String
                    myMa_Bc_Chu = myMa_So_Tui.Substring(0, 6)
                    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                    If Not myDanh_Muc_Bc.Lay_Boi_IPMC(myMa_Bc_Chu).Tables(0).Rows.Count > 0 Then 'Nếu không có dữ liệu thì thoát
                        MessageBox.Show("Không tìm thấy đường thư này" & vbNewLine & "Bạn hãy kiểm tra lại các bảng danh mục!!!", _
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtMaSoTui.Select()
                        Exit Sub
                    End If
                    cbMaNuoc.Value = myDanh_Muc_Bc.Lay_Boi_IPMC(myMa_Bc_Chu).Tables(0).Rows(0).Item("Ma_Nc")
                    cbMaNuoc_Validated(sender, e)
                    'Tìm đường thư đến
                    If Tim_Duong_Thu(myMa_Bc_Chu) = "" Then 'Nếu không tìm thấy đường thư thì thoát
                        MessageBox.Show("Không tìm thấy đường thư này" & vbNewLine & "Bạn hãy kiểm tra lại các bảng danh mục!!!", _
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtMaSoTui.Select()
                        Exit Sub
                    End If
                    cbDuongThuDen.Value = Tim_Duong_Thu(myMa_Bc_Chu)
                End If
                'Tìm loại chuyến thư đến: Kiểm tra xem có trong danh sách không
                If cbLoai_Chuyen_Thu.IsItemInList(myMa_So_Tui.Substring(13, 2)) = False Then
                    MessageBox.Show("Không tìm thấy phân loại chuyến thư này" & vbNewLine & "Bạn hãy kiểm tra lại thông tin!!!", _
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtMaSoTui.Select()
                    Exit Sub
                End If
                cbLoai_Chuyen_Thu.Text = myMa_So_Tui.Substring(13, 2)
                'Tìm chuyến thư đến
                cbChuyenThuDen.Text = CInt(SetNullValue(myMa_So_Tui.Substring(16, 4), 0))
                'Tìm túi số đến
                cbTuiSoDen.Text = CInt(SetNullValue(myMa_So_Tui.Substring(20, 3), 0))
                'Túi F
                Dim str_Tui_F As String = "00"
                str_Tui_F = SetNullValue(myMa_So_Tui.Substring(23, 2), "00")
                If str_Tui_F = "10" Then
                    chkTuiF.Checked = True
                Else
                    chkTuiF.Checked = False
                End If
                'Tìm tổng trọng lượng túi
                txtTrongluongTui.Text = CInt(SetNullValue(myMa_So_Tui.Substring(25, 4), 0)) * 100
                txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(Me.cbDuongThuDen.Value) & " (" & myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu & ")" & _
                                                    vbNewLine & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "- Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Den) & " - Túi Số: " & myTui_So_Den
                'Tìm chuyến bay đến               
                myId_Chuyen_Thu = (cbDuongThuDen.Text & "0" & GBuu_Cuc_Khai_Thac & Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.DateTime) & cbChuyenThuDen.Text & cbLoai_Chuyen_Thu.Text)
                myId_E2 = myId_Chuyen_Thu & cbTuiSoDen.Text
                cbChuyenBayDen.DataSource = myDanhMucDuongBayDen.Danh_Muc_Duong_Bay_Den_Lay_So_Hieu_Boi_Ma_Bc_Gui(cbDuongThuDen.Value, GBuu_Cuc_Khai_Thac)
                cbChuyenBayDen.DataBind()
                cbChuyenBayDen.LimitToList = True
                If Tim_Duong_Bay_Theo_Id_E2(myId_E2) = "" Then ' Nếu không tìm thấy chuyến bay đến
                    If Tim_Duong_Bay(myId_Chuyen_Thu) <> "" Then
                        cbChuyenBayDen.Value = cbChuyenBayDen.SelectedRow.Cells("So_Hieu").Value
                    Else
                        cbChuyenBayDen.Value = ""
                        cbDuongThuDen.Focus()
                    End If
                Else
                    cbChuyenBayDen.Value = Tim_Duong_Bay_Theo_Id_E2(myId_E2)
                    btnMoTui.Focus()
                End If

            Else
                Exit Sub
            'MessageBox.Show("Không đầy đủ thông tin về túi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "txtMaSoTui_KeyDown"
    Private Sub txtMaSoTui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaSoTui.KeyDown
        Select Case e.KeyValue
            Case 13 'Enter
                btnMoTui.Focus()
            Case 27 'ESC
                txtMaSoTui.Text = ""
                txtMaSoTui.SelectionStart = 0
        End Select
    End Sub
#End Region

#Region "txtMaSoTui_MouseDown"
    Private Sub txtMaSoTui_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMaSoTui.MouseDown
        txtMaSoTui.SelectionStart = 0
        txtMaSoTui.SelectionLength = IIf(txtMaSoTui.Text.Length = 0, 0, txtMaSoTui.Text.Length)
    End Sub
#End Region

#Region " Tìm thông tin về chuyến bay theo Id_E2"
    Private Function Tim_Duong_Bay_Theo_Id_E2(ByVal Id_E2 As String) As String
        Dim myTmp_E2_Den As New Tmp_E2_Den(GConnectionString)
        Dim myTmp_E2_Den_Chi_Tiet As New Tmp_E2_Den_Chi_Tiet
        myTmp_E2_Den_Chi_Tiet = myTmp_E2_Den.Tmp_E2_Den_Lay_Id_Duong_Bay_Theo_Id_E2(Id_E2)
        If myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay.Length > 0 Then
            Return myTmp_E2_Den_Chi_Tiet.Id_Duong_Bay
        Else
            Return ""
        End If
    End Function
#End Region
#Region "Tìm thông tin về chuyến bay theo Id_Chuyen_Thu"
    Private Function Tim_Duong_Bay(ByVal Id_Chuyen_Thu As String) As String
        Dim myCn38Den As New CN38Den(GConnectionString)
        Dim myCN38Den_Chi_Tiet As New CN38Den_Chi_Tiet
        myCN38Den_Chi_Tiet = myCn38Den.CN38Den_lay_Id_Duong_Bay_Theo_Id_Chuyen_Thu(Id_Chuyen_Thu)
        If myCN38Den_Chi_Tiet.Id_Chuyen_Thu.Length > 0 Then
            Return myCN38Den_Chi_Tiet.Id_Duong_Bay
        Else
            Return ""
        End If
    End Function
#End Region

#Region "Tìm thông tin về đường thư"
    Private Function Tim_Duong_Thu(ByVal Ma_Bc_Chu As String) As String
        'Kiểm tra mã bưu cục chữ ->mã bưu cục số
        Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
        'Lấy Id_Duong_Thu của bưu cục đó theo bưu cục khai thác
        Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
        myDuong_Thu_Den_Chi_Tiet = myDuong_Thu_Den.Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_Chu(Ma_Bc_Chu, GBuu_Cuc_Khai_Thac)
        If myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu.Length > 0 Then
            Return myDuong_Thu_Den_Chi_Tiet.Ma_Bc
        Else
            Return ""
        End If
    End Function
#End Region
#End Region
#End Region

#Region "-----------------------Lấy Thông Số-----------------------"
#Region "LayThongSo"
    Private Function LayThongSo() As Boolean
        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        'Lấy Ngày giờ hiện tại
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
        myE2_Date_Receiver = myHam_Dung_Chung.ConvertDateToInt(Now)
        myE2_Time_Receiver = myHam_Dung_Chung.ConvertTimeToInt(Now)
        If myE2_Date <> 0 Then
            Dim myDataTable As DataTable
            'Lấy thông tin đường thư chi tiết
            myDataTable = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDen.Value))
            If myDataTable.Rows.Count > 0 And cbDuongThuDen.IsItemInList = True Then
                myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
                myDuong_Thu_Den_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
                myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
                myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
                myId_Duong_Thu = myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu
            Else
                cbDuongThuDen.Focus()
                Return False
                Exit Function
            End If

            'Lấy thông tin loại chuyến thư
            If cbLoai_Chuyen_Thu.Text = "" Then
                myLoai_Chuyen_Thu = ""
                Return False
                Exit Function
            Else
                myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
            End If

            'Lấy thông tin chuyến thư
            If cbChuyenThuDen.Text = "" Then
                mySo_Chuyen_Thu_Den = 0
                Return False
                Exit Function
            Else
                mySo_Chuyen_Thu_Den = CInt(cbChuyenThuDen.Text)
            End If
            'Lấy thông tin E2
            If cbTuiSoDen.Text = "" Then
                myTui_So_Den = 0
                Return False
                Exit Function
            Else
                myTui_So_Den = CInt(cbTuiSoDen.Text)
            End If
            Return True

        Else
            MessageBox.Show("Ngày E2 chưa được xác định!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
#End Region

#Region "Lay_TT_Ngay_E2"
    Private Sub Lay_TT_Ngay_E2()
        'Tìm Ngày Đóng E2, Giờ đóng E2
        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
        'Ngày nhận E2, Giờ nhận E2: Mặc định là ngày giờ hiện tại
        myE2_Date_Receiver = myHam_Dung_Chung.ConvertDateToInt(Now)
        myE2_Time_Receiver = myHam_Dung_Chung.ConvertTimeToInt(Now)
    End Sub
#End Region

#Region "Lay_TT_Duong_Thu"
    Private Sub Lay_TT_Duong_Thu()
        Dim myDataTable As DataTable
        'Lấy thông tin đường thư chi tiết
        myDataTable = myDuong_Thu_Den.Duong_Thu_Den_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDen.Value))
        If myDataTable.Rows.Count > 0 And cbDuongThuDen.IsItemInList = True Then
            myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
            myDuong_Thu_Den_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
            myDuong_Thu_Den_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
            myDuong_Thu_Den_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
            myDuong_Thu_Den_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
            myId_Duong_Thu = myDuong_Thu_Den_Chi_Tiet.Id_Duong_Thu
            myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = myDataTable.Rows(0)("Duoc_Truyen")
            myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep = myDataTable.Rows(0)("Chuyen_Tiep")
        Else
            cbDuongThuDen.Focus()
        End If
    End Sub
#End Region

#Region "Lay_TT_Loai_Chuyen_Thu"
    Private Sub Lay_TT_Loai_Chuyen_Thu()
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
    End Sub
#End Region

#Region "Lay_TT_Chuyen_Thu"
    Private Sub Lay_TT_Chuyen_Thu()
        If Not IsNumeric(cbChuyenThuDen.Text) Then
            cbChuyenThuDen.Text = 0
        Else
            If cbChuyenThuDen.Text = "" Then
                mySo_Chuyen_Thu_Den = 0
            Else
                mySo_Chuyen_Thu_Den = CInt(cbChuyenThuDen.Text)
            End If
        End If
    End Sub
#End Region

#Region "Lay_TT_E2"
    Private Sub Lay_TT_E2()
        Lay_TT_Chuyen_Thu()
        If cbTuiSoDen.Text = "" Then
            myTui_So_Den = 0
        Else
            myTui_So_Den = CInt(cbTuiSoDen.Text)
        End If
    End Sub
#End Region

#Region "Kiểm tra thông tin"
    Private Function IsCorrectInfor(Optional ByVal Ngay_Dong As Integer = 0, Optional ByVal Duong_Thu As Integer = 0, Optional ByVal So_Chuyen_Thu As Integer = 0, Optional ByVal Tui_So As Integer = 0, Optional ByVal Chuyen_Bay_Den As String = "") As Boolean
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
            cbDuongThuDen.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về chuyến thư
        If So_Chuyen_Thu = 0 Then
            MessageBox.Show("Thông tin về chuyến thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbChuyenThuDen.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về túi thư
        If Tui_So = 0 Then
            MessageBox.Show("Thông tin về túi thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbTuiSoDen.Focus()
            Return False
            Exit Function
        End If
        If Chuyen_Bay_Den = "" And cbMaNuoc.Text <> "VN" Then
            MessageBox.Show("Thông tin về chuyến bay không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbChuyenBayDen.Focus()
            Return False
            Exit Function
        End If

        'Thông tin được xác nhận dúng
        Return True
    End Function
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
                Event_Viewer_Delete_E1(1, Event_Viewer_Create_Chi_Tiet_E1(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_Duong_Thu").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Ngay_Dong").Text), myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Den, myTui_So_Den, myGridKeyDown.Rows(ActiveRowIndex).Cells("Ma_E1").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Khoi_Luong").Text), myGridKeyDown.Rows(ActiveRowIndex).Cells("Phan_Loai").Text), "")

                myE1_Den.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myE1_Le_Phi_Den.E1_Le_Phi_Den_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myTrang_Thai.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myGridKeyDown.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If myGridKeyDown.Rows.Count = 0 Then
                    myGridKeyDown.Rows.Band.AddNew()
                    myCell = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1")
                Else
                    myCell = myGridKeyDown.Rows(IIf(myRowIndex > 0, myRowIndex - 1, 0)).Cells("Ma_E1")
                End If
                dgE1_Den.ActiveCell = myCell
                dgE1_Den.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        Else
            If (myGridKeyDown.ActiveRow.HasNextSibling = True) Then
                myGridKeyDown.ActiveRow.Delete(False)
                If myGridKeyDown.Rows.Count = 0 Then
                    myGridKeyDown.Rows.Band.AddNew()
                    myCell = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1")
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

#Region "-----------------------dgE1_Den_InitializeLayout-----------------------"
    Private Sub dgE1_Den_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Den.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.WithinBand
        'Infragistics.Win.UltraWinGrid.GridItemBase.Selected()

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
            .Columns("Nuoc_Nhan").DefaultCellValue = myMa_Nuoc_Den
            'Nuoc_Tra
            .Columns("Nuoc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Nuoc_Tra").ValueList = ddMa_Nuoc
            .Columns("Nuoc_Tra").Hidden = True
            .Columns("Nuoc_Tra").DefaultCellValue = "VN"

            'Ma_Bc_Goc
            .Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Goc").ValueList = ddMa_BC
            .Columns("Ma_Bc_Goc").Hidden = True
            .Columns("Ma_Bc_Goc").DefaultCellValue = 0
            'Ma_Bc_Tra
            .Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Tra").ValueList = ddMa_BC_Tra
            .Columns("Ma_Bc_Tra").Hidden = False
            .Columns("Ma_Bc_Tra").DefaultCellValue = 100000

            'Ma_Bc_CH
            .Columns("Ma_Bc_CH").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_CH").ValueList = ddMa_BC_Tra
            'Phan_loai
            .Columns("Phan_Loai").Style = ColumnStyle.DropDownValidate
            .Columns("Phan_Loai").ValueList = ddPhan_Loai_BP
            Select Case myLoai_Chuyen_Thu
                Case "EA" 'Hàng hóa + Tài liệu
                    .Columns("Phan_Loai").DefaultCellValue = "D"
                    '.Columns("Loai_Hang_Hoa").Hidden = True
                    .Columns("Phan_Loai").Hidden = False
                Case "EM" 'Hàng hóa
                    .Columns("Phan_Loai").DefaultCellValue = "M"
                    '.Columns("Loai_Hang_Hoa").Hidden = False
                    .Columns("Phan_Loai").Hidden = True
                Case "ED" 'Tài liệu
                    .Columns("Phan_Loai").DefaultCellValue = "D"
                    '.Columns("Loai_Hang_Hoa").Hidden = True
                    .Columns("Phan_Loai").Hidden = True
                Case "EN" 'Hàng hóa + Tài liệu
                    .Columns("Phan_Loai").DefaultCellValue = "D"
                    '.Columns("Loai_Hang_Hoa").Hidden = True
                    .Columns("Phan_Loai").Hidden = False
                Case "CN" 'Hàng hóa + Tài liệu
                    .Columns("Phan_Loai").DefaultCellValue = "D"
                    '.Columns("Loai_Hang_Hoa").Hidden = True
                    .Columns("Phan_Loai").Hidden = False
            End Select

            'Loai
            .Columns("Loai").Style = ColumnStyle.DropDownValidate
            .Columns("Loai").ValueList = ddLoai_BP
            .Columns("Loai").Hidden = True
            .Columns("Loai").DefaultCellValue = 0

            'Loai_Hang_Hoa
            .Columns("Loai_Hang_Hoa").Style = ColumnStyle.DropDownValidate
            .Columns("Loai_Hang_Hoa").ValueList = ddLoai_Hang_Hoa
            .Columns("Loai_Hang_Hoa").DefaultCellValue = 0

            'Dv Cong them
            .Columns("Dv_Cong_Them").Style = ColumnStyle.DropDown
            .Columns("Dv_Cong_Them").ValueList = ddTo_Hop_DV_Cong_Them

            'Dv Gia Tang
            .Columns("Dv_Gia_Tang").Style = ColumnStyle.DropDown
            .Columns("Dv_Gia_Tang").ValueList = ddTo_Hop_DV_Gia_Tang

            'Set DefaultValue
            'Các giá trị không thay đổi
            .Columns("Ngay_Dong").DefaultCellValue = myE2_Date
            .Columns("Gio_Dong").DefaultCellValue = myE2_Time
            .Columns("Ngay_Phat_Hanh").DefaultCellValue = myE2_Date
            .Columns("Gio_Phat_Hanh").DefaultCellValue = myE2_Time
            .Columns("Ngay_Nhan").DefaultCellValue = myE2_Date_Receiver
            .Columns("Gio_Nhan").DefaultCellValue = myE2_Time_Receiver

            .Columns("Id_Ca").DefaultCellValue = myId_Ca
            .Columns("Ma_Bc_Khai_Thac").DefaultCellValue = GBuu_Cuc_Khai_Thac
            .Columns("Id_Chuyen_Thu").DefaultCellValue = myId_Chuyen_Thu
            .Columns("Id_E2").DefaultCellValue = myId_E2
            .Columns("Id_Duong_Thu").DefaultCellValue = myId_Duong_Thu
            .Columns("Id_Nguoi_Dung").DefaultCellValue = myId_Nguoi_Dung
            .Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
            .Columns("Truyen_Khai_Thac").DefaultCellValue = CBool(0)
            .Columns("Chot_SL").DefaultCellValue = CBool(0)
        End With
    End Sub
#End Region

#Region "-----------------------dgE1_Den_InitializeTemplateAddRow-----------------------"
    Private Sub dgE1_Den_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgE1_Den.InitializeTemplateAddRow
        myGridKeyDown = sender
        With myGridKeyDown.DisplayLayout.Bands(0)
            .Columns("Khoi_Luong").DefaultCellValue = 0
            .Columns("Khoi_Luong_QD").DefaultCellValue = 0
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
            .Columns("Id_Trang_Thai").DefaultCellValue = 0
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

#Region "-----------------------dgE1_Den_AfterCellActivate-----------------------"
    Private Sub dgE1_Den_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Den.AfterCellActivate
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

#Region "-----------------------dgE1_Den_KeyDown-----------------------"
    Private Sub dgE1_Den_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Den.KeyDown
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
                'Kiểm tra lạc hướng
                If Kiem_Tra_Lac_Huong(sender, _
                                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text) = True Then
                    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                Else
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = "VN"
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                End If
                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Value = Tim_MAE1_Tu_Nuoc_Nhan(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text.Trim, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text.Trim)
                If Trim(myGridKeyDown.ActiveCell.Text).Length > 6 Then 'Kiểm tra độ dài
                    CMessageBox.Show("Dữ liệu nhập không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
            Case "Nuoc_Nhan"
                'Kiểm tra lạc hướng
                If Kiem_Tra_Lac_Huong(sender, _
                                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text) = True Then
                    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
                Dim MAE1 As String
                MAE1 = GetCorrectMAE1(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text, myGridKeyDown.ActiveCell.Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                If myGridKeyDown.ActiveCell.Text = "VN" Then
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                    e.Handled = False
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                    Exit Sub
                Else
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = True
                End If
                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Value = Tim_MAE1_Tu_Nuoc_Nhan(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text.Trim, myGridKeyDown.ActiveCell.Text)
                If Trim(myGridKeyDown.ActiveCell.Text).Length > 2 Then 'Kiểm tra độ dài
                    CMessageBox.Show("Dữ liệu nhập không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
            Case "Ma_Bc_Tra"
                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("PostCode").Hidden = False
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("PostCode").Hidden = True
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = "VN"
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("PostCode").Value = ""
                End If
                If Trim(myGridKeyDown.ActiveCell.Text).Length > 6 Then 'Kiểm tra độ dài
                    CMessageBox.Show("Dữ liệu nhập không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
            Case "Nuoc_Tra"
                If myGridKeyDown.ActiveCell.Text = "VN" Then 'Hàng TN
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                    e.Handled = False
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("PostCode").Hidden = True
                    Exit Sub
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = True
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = 0
                End If
                If Trim(myGridKeyDown.ActiveCell.Text).Length > 2 Then 'Kiểm tra độ dài
                    CMessageBox.Show("Dữ liệu nhập không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
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
                'Kiểm tra điều kiện: đúng với code 39 của Ma_E1 Nếu chk True sẽ kiểm tra, chk false không kiểm tra
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
                myIsDaTruyenDen = False

                'Kiểm tra các điều kiện trùng
                Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                myE1_Den_Chi_Tiet = Nothing
                myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT(MAE1, myId_E2)
                If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                    GoTo StopHere
                End If

                'Kiểm tra trùng số hiệu bưu phẩm trong cùng chuyến thư: không cho phép trùng
                myE1_Den_Chi_Tiet = Nothing
                myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(MAE1, myId_Chuyen_Thu)
                If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                    MessageBox.Show("Trùng dữ liệu trong cùng chuyến thư, bạn không được phép nhập tiếp", "Thông báo", MessageBoxButtons.OK)
                    GoTo StopHere
                End If

                'Kiểm tra điều kiện trùng dữ liệu trong 1 ca: thông báo
                myE1_Den_Chi_Tiet = Nothing
                myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then
                    myIsTrungSoLieu = True
                    If MessageBox.Show("Số hiệu E1 này đã được xác nhận đến trong ca này!!!" & vbNewLine & _
                                        "      Bạn có muốn tiếp tục không???", "Thông báo", _
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then 'Nếu không muốn tiếp tục
                        myIsChoPhepTrung = False
                        myIsDaKiemTraTrung = False
                        GoTo StopHere
                    Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                        'If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                        '    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        '        myIsDaKiemTraTrung = False
                        '        myIsChoPhepTrung = False
                        '        GoTo StopHere
                        '    End If
                        'End If
                        If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                            If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                myIsDaKiemTraTrung = False
                                myIsChoPhepTrung = False
                                GoTo StopHere
                            Else
                                myChoPhepLacHuong = True
                            End If
                        End If
                        myIsDaKiemTraTrung = True
                        myIsChoPhepTrung = True
                        Me.Gan_Gia_Tri_Trung_Vao_Bien(myE1_Den_Chi_Tiet) 'Gán giá trị trùng vào lưới
                    End If
                Else 'Không trùng dữ liệu trong ca khai thác
                    'Kiểm tra dữ liệu trùng trong bảng xác nhận đến theo khoảng thời gian trở về trước: có thể cho phép trùng
                    myE1_Den_Chi_Tiet = Nothing 'Reset giá trị trở về null
                    myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                    If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng
                        myIsTrungSoLieu = True
                        If MessageBox.Show("Trùng dữ liệu, bạn có muốn nhập tiếp không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            myIsChoPhepTrung = False
                            myIsDaKiemTraTrung = False
                            GoTo StopHere
                        Else
                            'If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                            '    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            '        myIsDaKiemTraTrung = False
                            '        myIsChoPhepTrung = False
                            '        GoTo StopHere
                            '    End If
                            'End If
                            If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                                If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                    myIsDaKiemTraTrung = False
                                    myIsChoPhepTrung = False
                                    GoTo StopHere
                                Else
                                    myChoPhepLacHuong = True
                                End If
                            End If
                            myIsChoPhepTrung = True
                            myIsDaKiemTraTrung = True
                            Me.Gan_Gia_Tri_Trung_Vao_Bien(myE1_Den_Chi_Tiet) 'Gán giá trị trùng vào lưới
                        End If
                    Else 'Không có dữ liệu trùng
                        'Kiểm tra dữ liệu truyền đến nếu có thì cho phép lấy giá trị
                        Dim myE1_Den_Tam_Chi_Tiet As New E1_Den_Tam_Chi_Tiet
                        myE1_Den_Tam_Chi_Tiet = Nothing
                        myE1_Den_Tam_Chi_Tiet = myE1_Den_Tam.E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myHam_Dung_Chung.ConvertDateToInt(Today))
                        If myE1_Den_Tam_Chi_Tiet.Id_E1 <> "" Then 'Nếu có dữ liệu
                            'If Kiem_Tra_Lac_Huong(sender, myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan, myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc) = True Then
                            '    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            '        myIsDaKiemTraTrung = False
                            '        myIsDaTruyenDen = False
                            '        GoTo StopHere
                            '    End If
                            'End If
                            If LacHuong(myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan, myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc) = True Then
                                If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                    myIsDaKiemTraTrung = False
                                    myIsDaTruyenDen = False
                                    GoTo StopHere
                                Else
                                    myChoPhepLacHuong = True
                                End If
                            End If
                            myIsDaKiemTraTrung = True
                            myIsDaTruyenDen = True
                            Gan_Gia_Tri_Truyen_Den_Vao_Bien(myE1_Den_Tam_Chi_Tiet)
                        Else
                            myIsDaKiemTraTrung = True
                            myIsDaTruyenDen = False
                        End If
                    End If
                End If

                'Nhảy xuống dòng tiếp theo
                myMAE1Thoat = True
                e.Handled = False
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                If myIsTrungSoLieu = True Or myIsDaTruyenDen = True Or myIsChoPhepTrung = True Then
                    myCell = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1")
                    myGridKeyDown.ActiveCell = myCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
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
        If (myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1) And _
                (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "") Then
            AddNewRow(sender)
        End If
        e.Handled = False
        myGridKeyDown.PerformAction(EnterEditMode, False, False)
        myGridKeyDown.PerformAction(NextCellByTab, False, True)
    End Sub
#End Region

#Region "-----------------------dgE1_Den_BeforeCellDeactivate-----------------------"
    Private Sub dgE1_Den_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Den.BeforeCellDeactivate
        Try
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.ActiveCell.Text = "" Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Text.Length > 13 Then
                        MessageBox.Show("Mã E1 không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                    Dim MAE1 As String
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

                        'Kiểm tra các điều kiện trùng
                        'Kiểm tra trùng
                        Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
                        'Trùng dữ liệu trong cùng bản kê E2
                        myE1_Den_Chi_Tiet = Nothing
                        myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_E2_KT(MAE1, myId_E2)
                        If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If

                        'Kiểm tra trùng số hiệu bưu phẩm trong cùng chuyến thư: không cho phép trùng
                        myE1_Den_Chi_Tiet = Nothing
                        myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_Chuyen_Thu_KT(MAE1, myId_Chuyen_Thu)
                        If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            MessageBox.Show("Trùng dữ liệu trong cùng chuyến thư, bạn không được phép nhập tiếp", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If

                        'Kiểm tra điều kiện trùng dữ liệu trong 1 ca: thông báo
                        myE1_Den_Chi_Tiet = Nothing
                        myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                        If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            myIsTrungSoLieu = True
                            If MessageBox.Show("Số hiệu E1 này đã được xác nhận đến trong ca này!!!" & vbNewLine & _
                                                "      Bạn có muốn tiếp tục không???", "Thông báo", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then                     'Nếu không muốn tiếp tục
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                myIsChoPhepTrung = False
                                Exit Sub
                            Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                                'Kiểm tra lạc hướng
                                'If Kiem_Tra_Lac_Huong(sender, myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                                '    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                '        myIsDaKiemTraTrung = False
                                '        myIsChoPhepTrung = False
                                '        e.Cancel = True
                                '        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                '    End If
                                'End If
                                If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                                    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                        myIsDaKiemTraTrung = False
                                        myIsChoPhepTrung = False
                                        e.Cancel = True
                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    Else
                                        myChoPhepLacHuong = True
                                    End If
                                End If
                                myIsChoPhepTrung = True
                                Me.Gan_Gia_Tri_Trung_Vao_Bien(myE1_Den_Chi_Tiet) 'Gán giá trị trùng vào lưới
                            End If
                        Else
                            'Kiểm tra dữ liệu trùng trong bảng xác nhận đến theo khoảng thời gian trở về trước: có thể cho phép trùng
                            myE1_Den_Chi_Tiet = Nothing 'Reset giá trị trở về null
                            myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                            If (myE1_Den_Chi_Tiet.Id_E1 <> "") And (myE1_Den_Chi_Tiet.Id_E1 <> myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng
                                myIsTrungSoLieu = True
                                If MessageBox.Show("Trùng dữ liệu, bạn có muốn nhập tiếp không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                    myIsChoPhepTrung = False
                                    e.Cancel = True
                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    Exit Sub
                                Else 'Nếu tiếp tục thì kiểm tra lạc hướng

                                    If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Ma_Bc_Goc) = True Then
                                        If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            myIsDaKiemTraTrung = False
                                            myIsChoPhepTrung = False
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                        Else
                                            myChoPhepLacHuong = True
                                        End If
                                    End If
                                    myIsChoPhepTrung = True
                                    Me.Gan_Gia_Tri_Trung_Vao_Bien(myE1_Den_Chi_Tiet) 'Gán giá trị trùng vào lưới
                                End If
                            Else 'Nếu không trùng dữ liệu
                                'Kiểm tra dữ liệu truyền đến nếu có thì cho phép lấy giá trị
                                Dim myE1_Den_Tam_Chi_Tiet As New E1_Den_Tam_Chi_Tiet
                                myE1_Den_Tam_Chi_Tiet = Nothing
                                myE1_Den_Tam_Chi_Tiet = myE1_Den_Tam.E1_Den_Tam_Kiem_Tra_Trung_MA_E1_Ngay(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date)
                                If myE1_Den_Tam_Chi_Tiet.Id_E1 <> "" Then 'Nếu có giá trị truyền đến

                                    If LacHuong(myE1_Den_Tam_Chi_Tiet.Nuoc_Nhan, myE1_Den_Tam_Chi_Tiet.Ma_Bc_Goc) = True Then
                                        If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            myIsDaTruyenDen = False
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                        Else
                                            myChoPhepLacHuong = True
                                        End If

                                    End If
                                    myIsDaTruyenDen = True
                                    Gan_Gia_Tri_Truyen_Den_Vao_Bien(myE1_Den_Tam_Chi_Tiet)
                                Else
                                    myIsDaTruyenDen = False
                                End If
                            End If
                        End If
                    End If
                Case "Ma_Bc_Goc"
                        
                        If LacHuong() Then
                            If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", _
                                                MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Warning, _
                                                MessageBoxDefaultButton.Button2) = _
                                        DialogResult.No Then
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Else
                                myChoPhepLacHuong = True
                            End If
                        End If
                Case "Nuoc_Nhan"
                        'Kiểm tra lạc hướng
                        'If Kiem_Tra_Lac_Huong(sender, _
                        '                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                        '                     myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text) = True Then
                        '    If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        '        e.Cancel = True
                        '        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        '    End If
                        'End If
                        If LacHuong() Then
                            If MessageBox.Show("Bưu phẩm lạc hướng, Bạn có muốn tiếp tục không???", "Thông báo", _
                                                MessageBoxButtons.YesNo, _
                                                MessageBoxIcon.Warning, _
                                                MessageBoxDefaultButton.Button2) = _
                                        DialogResult.No Then
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Else
                                myChoPhepLacHuong = True
                            End If
                        End If
                Case "Khoi_Luong"
                        If myGridKeyDown.Rows(dgE1_Den.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
                            If (myGridKeyDown.ActiveCell.Text = "") Then
                                MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            ElseIf IsNumeric(myGridKeyDown.ActiveCell.Text) = False Then                          'Kiểm tra định dạng
                                MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK)
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            ElseIf (CInt(myGridKeyDown.ActiveCell.Text) = 0) Then
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
    'Nếu là đường thư quốc tế: Kiểm tra nước nhận
    'Nếu là đường thư trong nước: Kiểm tra Mã tỉnh của bưu cục gốc
    Private Function Kiem_Tra_Lac_Huong(ByVal sender As Object, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Goc As Integer) As Boolean
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
            If myDuong_Thu_Den_Chi_Tiet.Chuyen_Tiep = False Then 'Kiểm tra lạc hướng nếu đường thư không phải là chuyển tiếp
                'Kiểm tra thông tin đường thư: nước đến, tỉnh đến
                If myMa_Nuoc_Theo_Duong_Thu.ToUpper = "VN" Then
                    'Kiểm tra lạc hướng theo từng mã tỉnh
                    If myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(Ma_Bc_Goc).Ma_Tinh Then
                        'Không lạc hướng
                        Return False
                    Else 'Lạc hướng
                        Return True
                    End If
                Else 'Nếu là đường thư nước ngoài
                    If myMa_Nuoc_Theo_Duong_Thu.ToUpper = Nuoc_Nhan.ToUpper Then
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

#Region " ------------------Kiem tra buu pham lac huong theo danh muc huong chuyen-------------"
    ''' Kiem tra buu pham lac huong theo danh muc huong chuyen
    Private Function LacHuong(Optional ByVal Nuoc_Nhan As String = "", _
                                Optional ByVal Ma_Bc_Goc As Integer = 0) As Boolean
        Dim mIsLacHuong As Boolean = False
        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
            Return False
        End If

        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" Then
            ' Kiem tra viec thay doi nuoc tra va buu cuc tra
            Dim mId_E1_Cu As String
            Dim mNuoc_Nhan_Moi As String
            Dim mMa_Bc_Nhan_Moi As Integer
            mId_E1_Cu = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
            Dim mE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
            mE1_Den_Chi_Tiet = myE1_Den.Lay(mId_E1_Cu)
            mNuoc_Nhan_Moi = myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text
            mMa_Bc_Nhan_Moi = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
            If (mNuoc_Nhan_Moi = mE1_Den_Chi_Tiet.Nuoc_Tra) And (mMa_Bc_Nhan_Moi = mE1_Den_Chi_Tiet.Ma_Bc_Tra) Then
                Return False
            End If
        End If

        If myChoPhepLacHuong Then
            Return False
        End If
        ' Lay thong tin de kiem tra
        Dim _Nuoc_Nhan As String
        Dim _Ma_Bc_Nhan As Integer
        If Nuoc_Nhan = "" Then
            _Nuoc_Nhan = myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text
            _Ma_Bc_Nhan = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
        Else
            _Nuoc_Nhan = Nuoc_Nhan
            _Ma_Bc_Nhan = Ma_Bc_Goc
        End If

        ' Lay ma nuoc
        ' Kiem tra ma tinh nhan
        Dim mDanh_Muc_Huong_Den As New Danh_Muc_Huong_Den(GConnectionString)
        ' Kiem tra dieu kien ve duong thu trong nuoc, quoc te trong danh muc huong den
        Dim mKiemTraMaNuoc As Boolean = False
        Dim mKiemTraMaTinh As Boolean = False
        If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Danh_Sach_Ma_Nuoc_Lay_Boi_ID_Duong_Thu(myId_Duong_Thu).Tables(0).Rows.Count > 0 Then
            mKiemTraMaNuoc = True
        End If

        If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Danh_Sach_Ma_Tinh_Lay_Boi_ID_Duong_Thu(myId_Duong_Thu).Tables(0).Rows.Count > 0 Then
            mKiemTraMaTinh = True
        End If

        If (mKiemTraMaNuoc = False) And (mKiemTraMaTinh = False) Then ' Khong kiem tra khi khong ton tai danh muc
            Return False
        End If


        ' Lay ma Tinh
        Dim _Ma_Tinh As Integer
        Dim _Ma_Nuoc As String
        Dim _Id_Huong_Chuyen As String

        If mKiemTraMaNuoc And mKiemTraMaTinh Then ' Kiem tra ca 2
            ' Kiem tra ma nuoc
            _Ma_Tinh = 0
            _Ma_Nuoc = _Nuoc_Nhan

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                Return False ' Đúng hướng
            End If

            ' Kiem tra ma tinh
            _Ma_Tinh = myDanh_Muc_Bc.Lay(_Ma_Bc_Nhan).Ma_Tinh
            _Ma_Nuoc = "VN"

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        ElseIf mKiemTraMaTinh Then ' Kiem tra ma tinh
            _Ma_Tinh = myDanh_Muc_Bc.Lay(_Ma_Bc_Nhan).Ma_Tinh
            _Ma_Nuoc = "VN"

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        Else ' Kiem tra ma nuoc
            _Ma_Tinh = 0
            _Ma_Nuoc = _Nuoc_Nhan

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Den.Danh_Muc_Huong_Den_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        End If

        Return mIsLacHuong
    End Function
#End Region

#Region "-----------------------Gán giá trị trùng vào biến-----------------------"
    'Sau khi kiểm tra giá trị trùng, giá trị truyền đến thì truyền giá trị vào trong lưới
    Private Function Gan_Gia_Tri_Trung_Vao_Bien(ByVal m_E1_Den_Chi_Tiet As E1_Den_Chi_Tiet) As Boolean
        Try
            'myE1_Den_Chi_Tiet_Trung = Nothing 'Reset giá trị về null
            If m_E1_Den_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Den_Chi_Tiet_Trung 'Lấy giá trị chi tiết vào biến
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
                myE1_Den_Chi_Tiet_Trung = Nothing
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------------Gán giá trị truyền đến vào biến-----------------------"
    'Sau khi kiểm tra giá trị trùng, giá trị truyền đến thì truyền giá trị vào trong lưới
    Private Function Gan_Gia_Tri_Truyen_Den_Vao_Bien(ByVal m_E1_Den_Tam_Chi_Tiet As E1_Den_Tam_Chi_Tiet) As Boolean
        Try
            If m_E1_Den_Tam_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Den_Tam_Chi_Tiet_Trung 'Lấy giá trị chi tiết vào biến
                    .Id_E1 = m_E1_Den_Tam_Chi_Tiet.Id_E1
                    .Ngay_Phat_Hanh = m_E1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh
                    .Gio_Phat_Hanh = m_E1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh
                    .Ma_Bc_Goc = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_Goc
                    .Ma_Don_Vi = m_E1_Den_Tam_Chi_Tiet.Ma_Don_Vi
                    .Ma_Bc_Tra = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_Tra
                    .Nuoc_Nhan = m_E1_Den_Tam_Chi_Tiet.Nuoc_Nhan
                    .Nuoc_Tra = m_E1_Den_Tam_Chi_Tiet.Nuoc_Tra
                    .Khoi_Luong = m_E1_Den_Tam_Chi_Tiet.Khoi_Luong
                    .Phan_Loai = m_E1_Den_Tam_Chi_Tiet.Phan_Loai
                    .Loai_Hang_Hoa = m_E1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa
                    .Khoi_Luong_QD = IIf(m_E1_Den_Tam_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Den_Tam_Chi_Tiet.Khoi_Luong, m_E1_Den_Tam_Chi_Tiet.Khoi_Luong_QD)
                    .Loai = m_E1_Den_Tam_Chi_Tiet.Loai
                    .PPXD = m_E1_Den_Tam_Chi_Tiet.PPXD
                    .Cuoc_PPXD = m_E1_Den_Tam_Chi_Tiet.Cuoc_PPXD
                    .PostCode = m_E1_Den_Tam_Chi_Tiet.PostCode
                    .Cuoc_PPVX = m_E1_Den_Tam_Chi_Tiet.Cuoc_PPVX
                    .VAT = m_E1_Den_Tam_Chi_Tiet.VAT
                    .COD = m_E1_Den_Tam_Chi_Tiet.COD
                    .Gia_Tri_Hang = m_E1_Den_Tam_Chi_Tiet.Gia_Tri_Hang
                    .Cuoc_Giam = m_E1_Den_Tam_Chi_Tiet.Cuoc_Giam
                    .Ghi_Chu = m_E1_Den_Tam_Chi_Tiet.Ghi_Chu
                    .Nguoi_Gui = m_E1_Den_Tam_Chi_Tiet.Nguoi_Gui
                    .Nguoi_Nhan = m_E1_Den_Tam_Chi_Tiet.Nguoi_Nhan
                    .Dia_Chi_Gui = m_E1_Den_Tam_Chi_Tiet.Dia_Chi_Gui
                    .Dia_Chi_Nhan = m_E1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan
                    .Dien_Thoai_Nhan = m_E1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan
                    .Kien_So = m_E1_Den_Tam_Chi_Tiet.Kien_So
                    .Ma_Bc_CH = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_CH
                    .Cuoc_Chinh = m_E1_Den_Tam_Chi_Tiet.Cuoc_Chinh
                    .Cuoc_E1 = m_E1_Den_Tam_Chi_Tiet.Cuoc_E1
                    .Cuoc_COD = m_E1_Den_Tam_Chi_Tiet.Cuoc_COD
                    .Dv_Cong_Them = m_E1_Den_Tam_Chi_Tiet.Dv_Cong_Them
                    .Dv_Gia_Tang = m_E1_Den_Tam_Chi_Tiet.Dv_Gia_Tang
                    .Cuoc_DV = m_E1_Den_Tam_Chi_Tiet.Cuoc_DV
                    .Ma_Bc_CH = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_CH
                    .HH_Phat_Tra = m_E1_Den_Tam_Chi_Tiet.HH_Phat_Tra
                    .HH_Phat_Hanh = m_E1_Den_Tam_Chi_Tiet.HH_Phat_Hanh
                End With
                Return True
            Else
                myE1_Den_Tam_Chi_Tiet_Trung = Nothing
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------------dgE1_Den_AfterExitEditMode-----------------------"
    Private Sub dgE1_Den_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Den.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell.Text = Nothing Then
                Exit Sub
            End If
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text = "" Then
                        Exit Sub
                    End If

                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text <> "" And _
                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text = _
                            CreateId_E1(GetCorrectMAE1(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text, _
                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text), _
                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E2").Text, _
                                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Text) Then
                        'Nếu không có sự thay đổi mã e1
                        GoTo Thoat
                    End If

                    Dim MAE1 As String
                    If E1_AfterUpdate(myGridKeyDown) = True Then
                        Update_Cuoc(sender)
                    End If
                    MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Value, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text)
                    myGridKeyDown.ActiveCell.Value = MAE1

                    If myIsTrungSoLieu = True Then 'Nếu trùng số liệu
                        If myIsChoPhepTrung = True Then
                            Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi()
                        End If
                    Else 'Kiểm tra dữ liệu truyền đến cho mã bưu cục khai thác đó
                        If myIsDaTruyenDen = True Then
                            Gan_Gia_Tri_Truyen_Den_Vao_Luoi(sender, myE1_Den_Tam_Chi_Tiet_Trung)
                        End If
                    End If
Thoat:
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E1").Text = "" Then
                        If myIsTrungSoLieu = True Or myIsDaTruyenDen = True Then
                            myGridKeyDown.Rows.Band.AddNew()
                        End If
                        'AddNewRow(sender)
                    End If
                    'Phan_Loai_EMS_EMSTT(sender, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text)
                Case "Ma_Bc_Goc"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text = 0 Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = "0"
                    Else
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = Tim_Danh_Muc_BC_Tu_Ma_Bc(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text).Ma_Don_Vi
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = "VN"
                    End If
                    Update_Cuoc(sender)
                Case "Nuoc_Nhan"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text <> "VN" Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = "0"
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = "0"
                    Else
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = Tim_Danh_Muc_BC_Tu_Ma_Bc(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text).Ma_Don_Vi
                    End If
                    Nuoc_Nhan_AfterUpdate(sender)
                Case "Ma_Bc_Tra"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text <> 0 Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = "VN"
                        'Tim Ma_Tinh_Tra
                        'Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                        'myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Tinh_Tra").Value = myDanh_Muc_Bc.Lay(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text).Ma_Tinh
                    End If
                    'Phan_Loai_EMS_EMSTT(sender, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text)
                    Update_Cuoc(sender)
                Case "Nuoc_Tra"
                    If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text <> "VN" Then
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = "0"
                        'myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Tinh_Tra").Value = "0"
                    End If
                    If (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text) _
                          And (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text <> "VN") Then
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = False
                    End If
                Case "Phan_Loai"
                    Update_Cuoc(sender)
                Case "Khoi_Luong"
                    If CInt(myGridKeyDown.ActiveCell.Text) > 0 Then
                        If (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value <> 1) Then  'Nếu không phải là hàng nhẹ
                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = myGridKeyDown.ActiveCell.Value
                        End If
                        Update_Cuoc(sender)
                    End If
                Case "Loai_Hang_Hoa" 'Tính lại cước bằng khối lượng quy đổi
                    If myGridKeyDown.ActiveCell.Text = 1 Then 'Hàng nhẹ
                        If myGridKeyDown.ActiveCell.Value = 1 Then 'Hàng nhẹ
                            'Xuất hiện Form nhập kích thước
                            Dim Frm As New FrmTinh_Hang_Nhe
                            Frm.ShowDialog()
                            If Frm.txtKet_Qua.Text <> 0 Then
                                myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = CInt(Frm.txtKet_Qua.Text)
                            End If
                        End If
                    Else
                        myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Value
                    End If
                    Update_Cuoc(sender)
                Case "Dv_Cong_Them"
                    Update_Cuoc(sender)
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 0, "", IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 1, "Su Vu", "TT"))
                Case "Dv_Gia_Tang"
                    Update_Cuoc(sender)
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 0, "", IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 1, "Su Vu", "TT"))
                Case "Loai"
                    Update_Cuoc(sender)
                    myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Text = "", "", myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Text & ",") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "" And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "0", "CH,", "") & _
                                        IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 0, "", IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = 1, "Su Vu", "TT"))
                Case "Le_Phi_HQ", "Thue_NK", "Thue_VAT", "Le_Phi_VH", "Le_Phi_YT", "Le_Phi_DV", "Le_Phi_TV", "Le_Phi_Khac"
                    Tinh_Tong_Thue_Le_Phi()
                Case Else
            End Select
            ReCalculate_Summary(sender)
            SetDefaultValueToCell(sender)
            ThongTinE1()
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Gán giá trị cho phép trùng vào lưới E1_Den-----------------------"
    Private Sub Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi()
        Try
            With myGridKeyDown
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value = myE1_Den_Chi_Tiet_Trung.Ngay_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value = myE1_Den_Chi_Tiet_Trung.Gio_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myE1_Den_Chi_Tiet_Trung.Ma_Bc_Goc
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = myE1_Den_Chi_Tiet_Trung.Ma_Don_Vi
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = myE1_Den_Chi_Tiet_Trung.Ma_Bc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = myE1_Den_Chi_Tiet_Trung.Nuoc_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = myE1_Den_Chi_Tiet_Trung.Nuoc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Value = myE1_Den_Chi_Tiet_Trung.Khoi_Luong
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Value = myE1_Den_Chi_Tiet_Trung.Phan_Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value = myE1_Den_Chi_Tiet_Trung.Loai_Hang_Hoa
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = IIf(myE1_Den_Chi_Tiet_Trung.Khoi_Luong_QD = 0, myE1_Den_Chi_Tiet_Trung.Khoi_Luong, myE1_Den_Chi_Tiet_Trung.Khoi_Luong_QD)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = myE1_Den_Chi_Tiet_Trung.Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = myE1_Den_Chi_Tiet_Trung.PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Postcode").Value = myE1_Den_Chi_Tiet_Trung.PostCode
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_PPVX
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = myE1_Den_Chi_Tiet_Trung.VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("COD").Value = myE1_Den_Chi_Tiet_Trung.COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gia_Tri_Hang").Value = myE1_Den_Chi_Tiet_Trung.Gia_Tri_Hang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Giam").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_Giam
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = myE1_Den_Chi_Tiet_Trung.Ghi_Chu
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Gui").Value = myE1_Den_Chi_Tiet_Trung.Nguoi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Value = myE1_Den_Chi_Tiet_Trung.Nguoi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Gui").Value = myE1_Den_Chi_Tiet_Trung.Dia_Chi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Nhan").Value = myE1_Den_Chi_Tiet_Trung.Dia_Chi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Value = myE1_Den_Chi_Tiet_Trung.Dien_Thoai_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Value = myE1_Den_Chi_Tiet_Trung.Kien_So
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Value = myE1_Den_Chi_Tiet_Trung.Ma_Bc_CH
                If myE1_Den_Chi_Tiet_Trung.Cuoc_Chinh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_Chinh
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
                End If
                If myE1_Den_Chi_Tiet_Trung.Cuoc_E1 <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_E1
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = (.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value + .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value) * (1 + GVat)
                End If
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_COD").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Value = myE1_Den_Chi_Tiet_Trung.Dv_Cong_Them
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Value = myE1_Den_Chi_Tiet_Trung.Dv_Gia_Tang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Dv").Value = myE1_Den_Chi_Tiet_Trung.Cuoc_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Ch").Value = myE1_Den_Chi_Tiet_Trung.Ma_Bc_CH
                If myE1_Den_Chi_Tiet_Trung.HH_Phat_Tra <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myE1_Den_Chi_Tiet_Trung.HH_Phat_Tra
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text)
                End If
                If myE1_Den_Chi_Tiet_Trung.HH_Phat_Hanh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myE1_Den_Chi_Tiet_Trung.HH_Phat_Hanh
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim myE1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
                myE1_Le_Phi_Den_Chi_Tiet = myE1_Le_Phi_Den.Lay(myE1_Den_Chi_Tiet_Trung.Id_E1)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_HQ").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK").Value = myE1_Le_Phi_Den_Chi_Tiet.Thue_NK
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_VAT").Value = myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK_VAT").Value = CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0))
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_TKHQ").Value = myE1_Le_Phi_Den_Chi_Tiet.So_TKHQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_Bien_Lai").Value = myE1_Le_Phi_Den_Chi_Tiet.So_Bien_Lai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_VH").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_YT").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_DV").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_TV").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_Khac").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------Gán giá trị truyền đến vào lưới-----------------------"
    'Sau khi kiểm tra giá trị trùng, giá trị truyền đến thì truyền giá trị vào trong lưới
    Private Sub Gan_Gia_Tri_Truyen_Den_Vao_Luoi(ByVal Sender As Object, ByVal m_E1_Den_Tam_Chi_Tiet As E1_Den_Tam_Chi_Tiet)
        myGridKeyDown = Sender
        Try
            With myGridKeyDown
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value = m_E1_Den_Tam_Chi_Tiet.Ngay_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value = m_E1_Den_Tam_Chi_Tiet.Gio_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_Goc
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = m_E1_Den_Tam_Chi_Tiet.Ma_Don_Vi
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = m_E1_Den_Tam_Chi_Tiet.Nuoc_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = m_E1_Den_Tam_Chi_Tiet.Nuoc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Value = m_E1_Den_Tam_Chi_Tiet.Khoi_Luong
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Value = m_E1_Den_Tam_Chi_Tiet.Phan_Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value = m_E1_Den_Tam_Chi_Tiet.Loai_Hang_Hoa
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = IIf(m_E1_Den_Tam_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Den_Tam_Chi_Tiet.Khoi_Luong, m_E1_Den_Tam_Chi_Tiet.Khoi_Luong_QD)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = m_E1_Den_Tam_Chi_Tiet.Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = m_E1_Den_Tam_Chi_Tiet.PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Postcode").Value = m_E1_Den_Tam_Chi_Tiet.PostCode
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_PPVX
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = m_E1_Den_Tam_Chi_Tiet.VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("COD").Value = m_E1_Den_Tam_Chi_Tiet.COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gia_Tri_Hang").Value = m_E1_Den_Tam_Chi_Tiet.Gia_Tri_Hang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Giam").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_Giam
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = m_E1_Den_Tam_Chi_Tiet.Ghi_Chu
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Gui").Value = m_E1_Den_Tam_Chi_Tiet.Nguoi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Value = m_E1_Den_Tam_Chi_Tiet.Nguoi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Gui").Value = m_E1_Den_Tam_Chi_Tiet.Dia_Chi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Nhan").Value = m_E1_Den_Tam_Chi_Tiet.Dia_Chi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Value = m_E1_Den_Tam_Chi_Tiet.Dien_Thoai_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Value = m_E1_Den_Tam_Chi_Tiet.Kien_So
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Value = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_CH
                If m_E1_Den_Tam_Chi_Tiet.Cuoc_Chinh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_Chinh
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
                End If
                If m_E1_Den_Tam_Chi_Tiet.Cuoc_E1 <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_E1
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = (.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value + .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value) * (1 + GVat)
                End If
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_COD").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Value = m_E1_Den_Tam_Chi_Tiet.Dv_Cong_Them
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Value = m_E1_Den_Tam_Chi_Tiet.Dv_Gia_Tang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Dv").Value = m_E1_Den_Tam_Chi_Tiet.Cuoc_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Ch").Value = m_E1_Den_Tam_Chi_Tiet.Ma_Bc_CH
                If m_E1_Den_Tam_Chi_Tiet.HH_Phat_Tra <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = m_E1_Den_Tam_Chi_Tiet.HH_Phat_Tra
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text, myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text)
                End If
                If m_E1_Den_Tam_Chi_Tiet.HH_Phat_Hanh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = m_E1_Den_Tam_Chi_Tiet.HH_Phat_Hanh
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value, _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim myE1_Le_Phi_Den_Tam_Chi_Tiet As New E1_Le_Phi_Den_Tam_Chi_Tiet
                myE1_Le_Phi_Den_Tam_Chi_Tiet = myE1_Le_Phi_Den_Tam.Lay(m_E1_Den_Tam_Chi_Tiet.Id_E1)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_HQ").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_HQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Thue_NK
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_VAT").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Thue_VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK_VAT").Value = CInt(SetNullValue(myE1_Le_Phi_Den_Tam_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(myE1_Le_Phi_Den_Tam_Chi_Tiet.Thue_VAT, 0))
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_TKHQ").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.So_TKHQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_Bien_Lai").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.So_Bien_Lai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_VH").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_VH
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_YT").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_YT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_DV").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_TV").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_TV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_Khac").Value = myE1_Le_Phi_Den_Tam_Chi_Tiet.Le_Phi_Khac
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
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = GVat
            'Tính cước dịch vụ cộng thêm và dịch vụ gia tăng
            If (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "0") And (myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Text <> "") Then
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
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
            Case "Loai_Hang_Hoa"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Text)
            Case "Khoi_Luong"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Text)
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong_QD").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Text)
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
            Le_Phi_HQ = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_HQ").Text, 0))
            Thue_NK = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Thue_NK").Text, 0))
            Thue_VAT = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Thue_VAT").Text, 0))
            Le_Phi_VH = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_VH").Text, 0))
            Le_Phi_YT = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_YT").Text, 0))
            Le_Phi_TV = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_TV").Text, 0))
            Le_Phi_DV = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_DV").Text, 0))
            Le_Phi_Khac = CInt(SetNullValue(dgE1_Den.ActiveRow.Cells("Le_Phi_Khac").Text, 0))

            Thue_NK_VAT = Thue_NK + Thue_VAT
            Tong_Thue_Le_Phi = Le_Phi_HQ + Le_Phi_VH + Le_Phi_YT + Le_Phi_TV + Le_Phi_DV + Le_Phi_Khac + Thue_NK + Thue_VAT
            myGridKeyDown.ActiveRow.Cells("Thue_NK_VAT").Value = Thue_NK_VAT
            myGridKeyDown.ActiveRow.Cells("Tong_Thue_Le_Phi").Value = Tong_Thue_Le_Phi
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-----------------------dgE1_Den_AfterRowActivate-----------------------"
    Private Sub dgE1_Den_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Den.AfterRowActivate
        myChoPhepLacHuong = False
        ThongTinE1()
    End Sub
#End Region

#Region "-----------------------ThongTinE1-----------------------"
    Private Sub ThongTinE1()
        If dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            Dim Danh_Muc_Bc_Goc As Danh_Muc_BC_Chi_Tiet
            Dim Danh_Muc_Bc_Tra As Danh_Muc_BC_Chi_Tiet
            Danh_Muc_Bc_Goc = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text))
            Danh_Muc_Bc_Tra = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text))
            Me.txtThongTin.Text = "Số hiệu E1   :" & dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text & vbNewLine _
                                        & "Bưu phẩm từ: " & IIf(Danh_Muc_Bc_Goc.Ma_BC = 0, dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text & " - " & myMaNuoc.Lay(dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text).Ten_Nuoc, Danh_Muc_Bc_Goc.Ma_BC & " - " & Danh_Muc_Bc_Goc.Ten_Buu_Cuc) & vbNewLine _
                                        & "Đóng đến   : " & IIf(Danh_Muc_Bc_Tra.Ma_BC = 0, dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text & " - " & myMaNuoc.Lay(dgE1_Den.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text).Ten_Nuoc, Danh_Muc_Bc_Tra.Ma_BC & " - " & Danh_Muc_Bc_Tra.Ten_Buu_Cuc)
        Else
            Me.txtThongTin.Text() = ""
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Den_BeforeRowDeactivate-----------------------"
    Private Sub dgE1_Den_BeforeRowDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1_Den.BeforeRowDeactivate
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
        Else 'Nếu thỏa mãn tất cả các điều kiện trên
            'Kiểm tra các điều kiện đầu vào trước khi cập nhật dữ liệu

            'Kiểm tra điều kiện về nước nhận và bưu cục gốc
            If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text = "VN" Then 'Nếu nước nhận là Việt Nam
                If SetNullValue(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text, 0) = "0" Then
                    MessageBox.Show("Mã nước nhận là Việt Nam, Bạn không được nhập bưu cục gốc = 0" & vbNewLine & "Xin mơi bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    e.Cancel = True
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                    myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc")
                    myGridKeyDown.ActiveCell = myCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                End If
            Else
                'Kiểm tra mã nước nhận có trong bảng mã nước không
                If myMaNuoc.Chk_Ma_Nuoc(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text) = False Then
                    If MessageBox.Show("Mã nước nhận không tìm thấy trong danh mục nước!!!" & vbNewLine & _
                                        "Bạn hãy liên hệ với người quản trị" & vbNewLine & _
                                        "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        e.Cancel = True
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan")
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        Exit Sub
                    End If
                End If

                'Kiểm tra điều kiện về nước trả, bưu cục trả
                If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text = "VN" Then 'Nếu nước nhận là Việt Nam
                    'Ứng dụng IPS nhập địa chỉ, bưu cục phát trong khâu xuất đi các kho nên chỗ này tạm thời comment lại
                    'If SetNullValue(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, 0) = "0" Then
                    '    MessageBox.Show("Mã nước trả là Việt Nam, Bạn không được nhập bưu cục trả = 0" & vbNewLine & "Xin mơi bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '    e.Cancel = True
                    '    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                    '    myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra")
                    '    myGridKeyDown.ActiveCell = myCell
                    '    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    '    Exit Sub
                    'End If
                Else
                    If SetNullValue(myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text, 0) <> "0" Then
                        MessageBox.Show("Mã nước trả không phải là Việt Nam, Bạn không được nhập bưu cục trả <> 0" & vbNewLine & "Xin mơi bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra")
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        Exit Sub
                    End If
                End If
            End If
            ' Kiem tra lac huong
            If LacHuong() Then
                If MessageBox.Show("Bưu phẩm lạc hướng!!! Bạn có muốn tiếp tục không???", _
                                    "Thông báo", _
                                    MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Warning, _
                                    MessageBoxDefaultButton.Button2) = _
                        DialogResult.No Then
                    e.Cancel = True
                    If myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text = "VN" Then
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                    Else
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = True
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                    End If

                    myCell = myGridKeyDown.ActiveRow.Cells("Ma_E1")
                    myGridKeyDown.ActiveCell = myCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    Exit Sub
                Else
                    myChoPhepLacHuong = True
                End If
            End If
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Den_BeforeRowInsert-----------------------"
    Private Sub dgE1_Den_BeforeRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowInsertEventArgs) Handles dgE1_Den.BeforeRowInsert
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("STT").Text = "" And myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("STT").Value = myGridKeyDown.ActiveRow.Index + 1
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Den_BeforeRowUpdate-----------------------"
    Private Sub dgE1_Den_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles dgE1_Den.BeforeRowUpdate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.Rows(dgE1_Den.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            If (Not CInt(IIf(myGridKeyDown.Rows(dgE1_Den.ActiveRow.Index).Cells("Khoi_Luong").Text = "", 0, dgE1_Den.Rows(dgE1_Den.ActiveRow.Index).Cells("Khoi_Luong").Text)) > 0) And ((dgE1_Den.Rows(dgE1_Den.ActiveRow.Index).Cells("Ma_E1").Text <> "")) Then
                MessageBox.Show("Chưa nhập khối lượng bưu phẩm!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                e.Cancel = True
            End If
        End If
    End Sub
#End Region

#Region "-----------------------dgE1_Den_AfterRowUpdate-----------------------"
    Private Sub dgE1_Den_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1_Den.AfterRowUpdate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow Is Nothing Then
            Exit Sub
        End If
        Dim myE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
        Dim myE1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" Then  'Nếu dòng có dữ liệu, và đã nhập khối lượng
            With myE1_Den_Chi_Tiet
                .Ma_E1 = Trim(myGridKeyDown.ActiveRow.Cells("Ma_E1").Text).ToUpper
                .Id_Duong_Thu = Trim(myGridKeyDown.ActiveRow.Cells("Id_Duong_Thu").Text)
                .Id_Chuyen_Thu = Trim(myGridKeyDown.ActiveRow.Cells("Id_Chuyen_Thu").Text)
                .Id_E2 = Trim(myGridKeyDown.ActiveRow.Cells("Id_E2").Text)
                .Id_Ca = Trim(myGridKeyDown.ActiveRow.Cells("Id_Ca").Text)
                .Ma_Bc_Khai_Thac = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text)
                .Ma_Quay = 0
                .Ngay_Phat_Hanh = myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text()
                .Gio_Phat_Hanh = myGridKeyDown.ActiveRow.Cells("Gio_Phat_Hanh").Text()
                .Ngay_Dong = myGridKeyDown.ActiveRow.Cells("Ngay_Dong").Text()
                .Gio_Dong = myGridKeyDown.ActiveRow.Cells("Gio_Dong").Text()
                .Ngay_Nhan = myGridKeyDown.ActiveRow.Cells("Ngay_Nhan").Text()
                .Gio_Nhan = myGridKeyDown.ActiveRow.Cells("Gio_Nhan").Text()
                .Ma_Don_Vi = IIf(Trim(myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Text()) <> "", Trim(myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Text()), GMa_Don_Vi)
                .Id_Nguoi_Dung = CInt(Trim(myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Text))
                .Nuoc_Nhan = myGridKeyDown.ActiveRow.Cells("Ma_E1").Text().Substring(11, 2).ToUpper
                If .Nuoc_Nhan.ToUpper = "VN" Then
                    .Ma_Bc_Goc = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text())
                    .Ma_Don_Vi = myGridKeyDown.ActiveRow.Cells("Ma_Don_Vi").Text()
                Else
                    .Ma_Bc_Goc = 0
                    .Ma_Don_Vi = "0"
                End If
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
                .STT = CInt(myGridKeyDown.ActiveRow.Cells("STT").Text())
                .Ma_KH = myGridKeyDown.ActiveRow.Cells("Ma_KH").Text()
                .Nguoi_Gui = Trim(myGridKeyDown.ActiveRow.Cells("Nguoi_Gui").Text())
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
            With myE1_Le_Phi_Den_Chi_Tiet
                .Le_Phi_HQ = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_HQ").Text(), 0))
                .Thue_NK = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_NK").Text(), 0))
                .Thue_VAT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_VAT").Text(), 0))
                .Thue_NK_VAT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_NK").Text(), 0)) + CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Thue_VAT").Text(), 0))
                .So_TKHQ = SetNullValue(myGridKeyDown.ActiveRow.Cells("So_TKHQ").Text(), "")
                .So_Bien_Lai = SetNullValue(myGridKeyDown.ActiveRow.Cells("So_Bien_Lai").Text(), "")
                .Le_Phi_VH = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_VH").Text(), 0))
                .Le_Phi_YT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_YT").Text(), 0))
                .Le_Phi_DV = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_DV").Text(), 0))
                .Le_Phi_TV = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_TV").Text(), 0))
                .Le_Phi_Khac = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_Khac").Text(), 0))
            End With

            If (myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "") Then 'Nếu thêm 1 dòng mới
                myE1_Den_Chi_Tiet.Id_E1 = CreateId_E1(myE1_Den_Chi_Tiet.Ma_E1, myE1_Den_Chi_Tiet.Id_E2, myE1_Den_Chi_Tiet.Kien_So) 'Tạo Id E1 mới
                myGridKeyDown.ActiveRow.Cells("Id_E1").Value = myE1_Den_Chi_Tiet.Id_E1
            Else 'Nếu đã tồn tại rồi
                'Nếu đánh Ma_E1 khác
                'Xóa mã cũ đi, chèn mã mới vào
                If Trim(myGridKeyDown.ActiveRow.Cells("Id_E1").Text) = CreateId_E1(myE1_Den_Chi_Tiet.Ma_E1, myE1_Den_Chi_Tiet.Id_E2, myE1_Den_Chi_Tiet.Kien_So) Then
                    myE1_Den_Chi_Tiet.Id_E1 = CStr(myGridKeyDown.ActiveRow.Cells("Id_E1").Text())
                Else
                    'Xoa trong bang e1_den
                    myE1_Den.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    'Xóa trong bảng E1_Le_Phi_Den
                    myE1_Le_Phi_Den.E1_Le_Phi_Den_Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    myE1_Den_Chi_Tiet.Id_E1 = CreateId_E1(myE1_Den_Chi_Tiet.Ma_E1, myE1_Den_Chi_Tiet.Id_E2, myE1_Den_Chi_Tiet.Kien_So)

                    '==============Ghi log==========================================================
                    Dim myBo_Phan As Integer = 1  'xac nhan den
                    Dim myChi_Tiet_Truoc As String   'Chi tiet truoc khi sua E1
                    Dim myChi_Tiet_Sau As String     'Chi tiet sau khi sua E1
                    'Tao chi tiet truoc
                    myChi_Tiet_Truoc = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
                    'Tao chi tiet sau
                    myChi_Tiet_Sau = myE1_Den_Chi_Tiet.Id_E1
                    Mdl_Event_Viewer.Event_Viewer_Edit_E1(myBo_Phan, "", "")
                    '==============End Ghi log==========================================================

                End If
            End If
            'Cập nhật lên máy chủ
            myE1_Den.E1_Den_Cap_Nhat_Them_KT(myE1_Den_Chi_Tiet.Id_E1, myE1_Den_Chi_Tiet.Id_Duong_Thu, myE1_Den_Chi_Tiet.Id_Chuyen_Thu, myE1_Den_Chi_Tiet.Id_E2, myE1_Den_Chi_Tiet.Id_Ca, myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Den_Chi_Tiet.Ma_Quay, myE1_Den_Chi_Tiet.Ma_E1, _
                                    myE1_Den_Chi_Tiet.Ngay_Phat_Hanh, myE1_Den_Chi_Tiet.Gio_Phat_Hanh, myE1_Den_Chi_Tiet.Ngay_Dong, myE1_Den_Chi_Tiet.Gio_Dong, myE1_Den_Chi_Tiet.Ngay_Nhan, myE1_Den_Chi_Tiet.Gio_Nhan, _
                                    myE1_Den_Chi_Tiet.Ma_Don_Vi, myE1_Den_Chi_Tiet.Ma_Bc_Goc, myE1_Den_Chi_Tiet.Ma_Bc_Tra, myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Nuoc_Tra, _
                                    myE1_Den_Chi_Tiet.Khoi_Luong, myE1_Den_Chi_Tiet.Phan_Loai, myE1_Den_Chi_Tiet.Loai_Hang_Hoa, myE1_Den_Chi_Tiet.Khoi_Luong_QD, myE1_Den_Chi_Tiet.Loai, myE1_Den_Chi_Tiet.Dv_Cong_Them, myE1_Den_Chi_Tiet.Dv_Gia_Tang, _
                                    myE1_Den_Chi_Tiet.PPXD, myE1_Den_Chi_Tiet.Cuoc_PPXD, myE1_Den_Chi_Tiet.PostCode, myE1_Den_Chi_Tiet.Cuoc_PPVX, myE1_Den_Chi_Tiet.VAT, myE1_Den_Chi_Tiet.COD, myE1_Den_Chi_Tiet.Gia_Tri_Hang, myE1_Den_Chi_Tiet.Cuoc_COD, myE1_Den_Chi_Tiet.Cuoc_DV, myE1_Den_Chi_Tiet.Cuoc_Chinh, myE1_Den_Chi_Tiet.Cuoc_Giam, myE1_Den_Chi_Tiet.Cuoc_E1, _
                                    myE1_Den_Chi_Tiet.Kien_So, myE1_Den_Chi_Tiet.STT, myE1_Den_Chi_Tiet.Ma_KH, myE1_Den_Chi_Tiet.Nguoi_Gui, myE1_Den_Chi_Tiet.Nguoi_Nhan, myE1_Den_Chi_Tiet.Dia_Chi_Gui, myE1_Den_Chi_Tiet.Dia_Chi_Nhan, myE1_Den_Chi_Tiet.Dien_Thoai_Gui, myE1_Den_Chi_Tiet.Dien_Thoai_Nhan, _
                                    myE1_Den_Chi_Tiet.HH_Phat_Hanh, myE1_Den_Chi_Tiet.HH_Phat_Tra, myE1_Den_Chi_Tiet.Ma_Bc_CH, myE1_Den_Chi_Tiet.Id_Nguoi_Dung, myE1_Den_Chi_Tiet.Id_Trang_Thai, myE1_Den_Chi_Tiet.Ghi_Chu, myE1_Den_Chi_Tiet.Truyen_Khai_Thac, myE1_Den_Chi_Tiet.Truyen_Doi_Soat, myE1_Den_Chi_Tiet.Chot_SL)
            'Cập nhật dữ liệu vào bảng E1_Le_Phi_Den
            myE1_Le_Phi_Den.E1_Le_Phi_Den_Cap_Nhat_Them_KT(myE1_Den_Chi_Tiet.Id_E1, myE1_Den_Chi_Tiet.Id_Duong_Thu, myE1_Den_Chi_Tiet.Id_Chuyen_Thu, myE1_Den_Chi_Tiet.Id_E2, myE1_Den_Chi_Tiet.Id_Ca, myE1_Den_Chi_Tiet.Ma_Bc_Khai_Thac, myE1_Den_Chi_Tiet.Ma_E1, _
                                               myE1_Den_Chi_Tiet.Ngay_Dong, myE1_Den_Chi_Tiet.Gio_Dong, myE1_Den_Chi_Tiet.Ma_Don_Vi, myE1_Den_Chi_Tiet.Ma_Bc_Goc, myE1_Den_Chi_Tiet.Ma_Bc_Tra, myE1_Den_Chi_Tiet.Nuoc_Nhan, myE1_Den_Chi_Tiet.Nuoc_Tra, _
                                               myE1_Den_Chi_Tiet.Khoi_Luong, myE1_Le_Phi_Den_Chi_Tiet.So_TKHQ, myE1_Le_Phi_Den_Chi_Tiet.So_Bien_Lai, myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ, myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, myE1_Le_Phi_Den_Chi_Tiet.Thue_NK_VAT, _
                                               myE1_Den_Chi_Tiet.Kien_So, myE1_Den_Chi_Tiet.STT, myE1_Den_Chi_Tiet.Id_Nguoi_Dung, myE1_Den_Chi_Tiet.Truyen_Khai_Thac, myE1_Den_Chi_Tiet.Truyen_Doi_Soat, myE1_Den_Chi_Tiet.Chot_SL, _
                                               myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH, myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT, myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV, myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV, myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac)
            myTrang_Thai_Chi_Tiet.Id_E1 = myE1_Den_Chi_Tiet.Id_E1
            If myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh = myDanh_Muc_Bc.Lay(myE1_Den_Chi_Tiet.Ma_Bc_Tra).Ma_Tinh Then
                myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EMD" 'Đến trung tâm khai thác tỉnh phát
            Else
                myTrang_Thai_Chi_Tiet.Id_Trang_Thai = "EMB" 'Đến trung tâm khai thác tỉnh chấp nhận
            End If
            myTrang_Thai_Chi_Tiet.Ma_Bc = GBuu_Cuc_Khai_Thac
            myTrang_Thai_Chi_Tiet.Ma_E1 = myE1_Den_Chi_Tiet.Ma_E1
            myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai = myE2_Date_Receiver
            myTrang_Thai_Chi_Tiet.Gio_Trang_Thai = myE2_Time_Receiver
            myTrang_Thai_Chi_Tiet.Truyen_Khai_Thac = False
            myTrang_Thai.Cap_Nhat_Them_KT(myTrang_Thai_Chi_Tiet.Id_E1, myTrang_Thai_Chi_Tiet.Ma_E1, myTrang_Thai_Chi_Tiet.Id_Trang_Thai, myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai, myTrang_Thai_Chi_Tiet.Gio_Trang_Thai, myTrang_Thai_Chi_Tiet.Ma_Bc, False)
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "-----------------------Kiểm tra chuyển hoàn-----------------------"
    Private Function Kiem_Tra_Chuyen_Hoan() As Boolean
        Try

        Catch ex As Exception
            Return False
            MessageBox.Show(ex.ToString)
        End Try
    End Function
#End Region

#Region "-----------------------dgE1_Den_LostFocus-----------------------"
    Private Sub dgE1_Den_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Den.LostFocus
        myCell = Nothing
    End Sub
#End Region
#End Region

#Region "=======================Search======================="
#Region "-----------------------dgE1_Den_MouseDown-----------------------"
    Private Sub dgE1_Den_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1_Den.MouseDown
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

    Private Sub mnuTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

#Region "-----------------------Truyen_Du_Lieu_Khai_Thac-----------------------"
    Private Sub Truyen_Du_Lieu_Khai_Thac()
        Dim mydataset As New DataSet
        Dim mytable As New DataTable

        myDuong_Thu_Den_Chi_Tiet = myDuong_Thu_Den.Lay(myId_Duong_Thu)
        If myDuong_Thu_Den_Chi_Tiet.Duoc_Truyen = False Then
            Exit Sub
        End If

        'Chuyen_Thu_Di
        mytable = myChuyen_Thu_Den.Danh_Sach_Chuyen_Thu_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Chuyen_Thu"
        mydataset.Tables.Add(mytable.Copy)

        'E2_Di
        mytable = myE2_Den.Danh_Sach_E2_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E2"
        mydataset.Tables.Add(mytable.Copy)

        'E1_Di
        mytable = myE1_Den.Danh_Sach_E1_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "E1"
        mydataset.Tables.Add(mytable.Copy)

        'COD_Di
        mytable = myCODDen.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "COD"
        mydataset.Tables.Add(mytable.Copy)

        mytable = myTrang_Thai.Danh_Sach_Lay_Boi_Id_Chuyen_Thu_Truyen_Den(myId_Chuyen_Thu).Tables(0)
        mytable.TableName = "Trang_Thai"
        mydataset.Tables.Add(mytable.Copy)

        If myUtility.Dang_Ky_Truyen("Ems_E2_Den", "Branch", "PO", GBuu_Cuc_Khai_Thac, myDuong_Thu_Den_Chi_Tiet.Ma_Bc, Ham_Dung_Chung.ConvertDateToInt(Now), Ham_Dung_Chung.ConvertTimeToInt(Now), "", mydataset) <> 0 Then
            MessageBox.Show("Dang ky truyen Ems_E2_Den Loi", "Thong bao")
        End If

        'Cập nhật lại thông tin đã truyền
        myChuyen_Thu_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE2_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myE1_Den.Cap_Nhat_Truyen_Khai_Thac(myId_Chuyen_Thu)
        myTrang_Thai.Cap_Nhat_Truyen(myId_Chuyen_Thu)
    End Sub
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
        chkCuocE1.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Cuoc_E1"), "False"))
        chk_Nguoi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Nguoi_Nhan"), "False"))
        chk_Dia_Chi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dia_Chi_Nhan"), "False"))
        chk_Dien_Thoai_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dien_Thoai_Nhan"), "False"))
        chk_Nguoi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Nguoi_Gui"), "False"))
        chk_Dia_Chi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Dia_Chi_Gui"), "False"))
        chkGhiChu.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ghi_Chu"), "False"))
        chkLe_Phi_HQ.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_HQ"), "False"))
        chkThue_NK.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_NK"), "False"))
        chkThue_VAT.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_VAT"), "False"))
        chkSo_TKHQ.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_So_TKHQ"), "False"))
        chkSo_Bien_Lai.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_So_Bien_Lai"), "False"))
        chkLoai_Hang_Hoa.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Loai_Hang_Hoa"), "False"))
        chkBcChuyenHoan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ma_Bc_CH"), "False"))
        chkCuocDV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Cuoc_Dv"), "False"))
        chkKienSo.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Kien_So"), "False"))
        chk_Le_Phi_VH.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_VH"), "False"))
        chk_Le_Phi_YT.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_YT"), "False"))
        chk_Le_Phi_DV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_DV"), "False"))
        chk_Le_Phi_TV.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_TV"), "False"))
        chk_Le_Phi_Khac.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Le_Phi_Khac"), "False"))
        chkLy_Do_Hai_Quan.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Ly_Do_Vao_Kho_HQ"), "False"))

        chkThue_Tieu_Thu.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Thue_Tieu_Thu"), "False"))
        chkThue_Tieu_Thu.Enabled = False
        chkTong_Thue_Le_Phi.Checked = CBool(SetNullValue(myKeys.Doc("IB_Grid_Den_Tong_Thue_Le_Phi"), "False"))
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
        SetLastColumnVisibleKey(dgE1_Den)
        SetColumnInputData(dgE1_Den)
    End Sub
#End Region

#Region "-----------------------Cap_Nhat_Tham_So-----------------------"
    Private Sub Cap_Nhat_Tham_So()
        myKeys.Ghi("IB_Grid_Den_Cuoc_E1", chkCuocE1.Checked)
        myKeys.Ghi("IB_Grid_Den_Nguoi_Nhan", chk_Nguoi_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Den_Dia_Chi_Nhan", chk_Dia_Chi_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Den_Dien_Thoai_Nhan", chk_Dien_Thoai_Nhan.Checked)
        myKeys.Ghi("IB_Grid_Den_Nguoi_Gui", chk_Nguoi_Gui.Checked)
        myKeys.Ghi("IB_Grid_Den_Dia_Chi_Gui", chk_Dia_Chi_Gui.Checked)
        myKeys.Ghi("IB_Grid_Den_Ghi_Chu", chkGhiChu.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_HQ", chkLe_Phi_HQ.Checked)
        myKeys.Ghi("IB_Grid_Den_Thue_NK", chkThue_NK.Checked)
        myKeys.Ghi("IB_Grid_Den_Thue_VAT", chkThue_VAT.Checked)
        myKeys.Ghi("IB_Grid_Den_So_TKHQ", chkSo_TKHQ.Checked)
        myKeys.Ghi("IB_Grid_Den_So_Bien_Lai", chkSo_Bien_Lai.Checked)
        myKeys.Ghi("IB_Grid_Den_Loai_Hang_Hoa", chkLoai_Hang_Hoa.Checked)
        myKeys.Ghi("IB_Grid_Den_Bc_CH", chkBcChuyenHoan.Checked)
        myKeys.Ghi("IB_Grid_Den_Cuoc_Dv", chkCuocDV.Checked)
        myKeys.Ghi("IB_Grid_Den_Kien_So", chkKienSo.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_VH", chk_Le_Phi_VH.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_YT", chk_Le_Phi_YT.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_DV", chk_Le_Phi_DV.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_TV", chk_Le_Phi_TV.Checked)
        myKeys.Ghi("IB_Grid_Den_Le_Phi_Khac", chk_Le_Phi_Khac.Checked)
        myKeys.Ghi("IB_Grid_Den_Ly_Do_Vao_Kho_HQ", chkLy_Do_Hai_Quan.Checked)
        myKeys.Ghi("IB_Grid_Den_Dv_Cong_Them", chkDich_Vu_Cong_Them.Checked)
        myKeys.Ghi("IB_Grid_Den_Dv_Gia_Tang", chk_Dv_Gia_Tang.Checked)
        myKeys.Ghi("IB_Grid_Den_Thue_Tieu_Thu", chkThue_Tieu_Thu.Checked)
        myKeys.Ghi("IB_Grid_Den_Tong_Thue_Le_Phi", chkTong_Thue_Le_Phi.Checked)
    End Sub
#End Region
    Private Sub chk_Dv_Gia_Tang_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Dv_Gia_Tang.CheckedChanged
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dv_Gia_Tang").Hidden = Not chk_Dv_Gia_Tang.Checked
    End Sub

    Private Sub chkDich_Vu_Cong_Them_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDich_Vu_Cong_Them.CheckedChanged
        dgE1_Den.DisplayLayout.Bands(0).Columns("Dv_Cong_Them").Hidden = Not chkDich_Vu_Cong_Them.Checked
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

#Region " btn..."
    Private Sub btnTaoChuyenBay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaoChuyenBay.Click
        Dim myFrm As New FrmCacBangDanhMuc
        myFrm.ShowDialog()
        cbMaNuoc.Focus()
    End Sub
#End Region


    Private Sub txtMaSoTui_MaskChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles txtMaSoTui.MaskChanged

    End Sub

    Private Sub chk_Dien_Thoai_Nhan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Dien_Thoai_Nhan.CheckedChanged

    End Sub

    Private Sub chk_Dia_Chi_Nhan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Dia_Chi_Nhan.CheckedChanged

    End Sub
End Class

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
Imports FTP

'Imports System.Text.Encoding
Public Class FrmThietLapDi_Out001
    Inherits System.Windows.Forms.Form
    Private Tong_So_BP_Tren_Luoi_E1 As Integer

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
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkTuiF As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtThongTin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtInfor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbChuyenThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbTuiSoDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ddNuoc_Nhan As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_BC As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddPhan_Loai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoai_BP As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddLoai_Hang_Hoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents chkBcChuyenHoan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkKienSo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ddTo_Hop_DV_Gia_Tang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTo_Hop_DV_Cong_Them As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtDauMa As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtTrongluongTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents chkCuocDV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkCuocE1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkGhiChu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents cbMaNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbLoai_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_Dia_Chi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dia_Chi_Gui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Nguoi_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Nguoi_Gui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbDuongBay As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dgE1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtBan_DesManifest As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNgayBay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkIn_Despatch_Manifest As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIn_Receptacle_Manifest As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIn_CN35 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkIn_CN38 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtBan_CN38 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBan_RecManifest As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkIn_BV10 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtBan_BV10 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtBan_CN37 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkIn_CN37 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Ngaynghi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents BtnTimE1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ddMa_BC_Tra As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents chkLoai_Hang_Hoa As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkSo_Bien_Lai As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkLe_Phi_HQ As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkSo_TKHQ As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_NK As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_VAT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Dien_Thoai_Nhan As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Group_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chk_Le_Phi_VH As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_YT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_DV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_TV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Le_Phi_Khac As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btn_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Cap_Nhat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Bo_Qua As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Export_To_Excel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkTong_Thue_Le_Phi As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkThue_Tieu_Thu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents grbTruyen_Du_Lieu As System.Windows.Forms.Panel
    Friend WithEvents PrbCommunication As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents lblCommunication As System.Windows.Forms.Label
    Friend WithEvents chkTrangThaiThuThue As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtMaSoTui As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
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
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
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
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TH_Ma_Dv_Gia_Tang", -1)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Ma")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dv_Cong_Them", -1)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("MaNuoc", -1)
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("LoaiChuyenThuDi", -1)
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Bay")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Hieu")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmThietLapDi_Out001))
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.btnMoTui = New Infragistics.Win.Misc.UltraButton
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.chkIn_Despatch_Manifest = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.chkTuiF = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.dgE1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.chkIn_CN35 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkIn_CN38 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
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
        Me.chk_Dien_Thoai_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_VAT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_NK = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkSo_Bien_Lai = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLe_Phi_HQ = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkSo_TKHQ = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkLoai_Hang_Hoa = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dia_Chi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Dia_Chi_Gui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Nguoi_Nhan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Nguoi_Gui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkGhiChu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkCuocDV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkCuocE1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkKienSo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkBcChuyenHoan = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Ngaynghi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.ddTo_Hop_DV_Gia_Tang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTo_Hop_DV_Cong_Them = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.txtDauMa = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtTrongluongTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBan_DesManifest = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtBan_CN38 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.cbMaNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.cbLoai_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDuongBay = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.txtBan_RecManifest = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.chkIn_Receptacle_Manifest = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.cbNgayBay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.btnPrint = New Infragistics.Win.Misc.UltraButton
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.txtBan_BV10 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.chkIn_BV10 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txtBan_CN37 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.chkIn_CN37 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.BtnTimE1 = New Infragistics.Win.Misc.UltraButton
        Me.ddMa_BC_Tra = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.Group_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkTrangThaiThuThue = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkTong_Thue_Le_Phi = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chkThue_Tieu_Thu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btn_Bo_Qua = New Infragistics.Win.Misc.UltraButton
        Me.btn_Cap_Nhat = New Infragistics.Win.Misc.UltraButton
        Me.chk_Le_Phi_Khac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_TV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_DV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_YT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.chk_Le_Phi_VH = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btn_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.btn_Export_To_Excel = New Infragistics.Win.Misc.UltraButton
        Me.grbTruyen_Du_Lieu = New System.Windows.Forms.Panel
        Me.PrbCommunication = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.lblCommunication = New System.Windows.Forms.Label
        Me.txtMaSoTui = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.cbMaNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongBay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayBay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Thiet_Lap_Tham_So.SuspendLayout()
        Me.grbTruyen_Du_Lieu.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(200, 48)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Đường T&hư"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Location = New System.Drawing.Point(368, 96)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(56, 16)
        Me.UltraLabel2.TabIndex = 14
        Me.UltraLabel2.Text = "Túi &Số"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(368, 48)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(72, 23)
        Me.UltraLabel3.TabIndex = 8
        Me.UltraLabel3.Text = "&Chuyến Thư"
        '
        'btnMoTui
        '
        Me.btnMoTui.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoTui.Location = New System.Drawing.Point(440, 10)
        Me.btnMoTui.Name = "btnMoTui"
        Me.btnMoTui.Size = New System.Drawing.Size(64, 48)
        Me.btnMoTui.TabIndex = 16
        Me.btnMoTui.Text = "Mở &Túi"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(13, 72)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(99, 21)
        Me.cbNgayDong.TabIndex = 1
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Location = New System.Drawing.Point(13, 48)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(83, 23)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "&Ngày Đóng E2"
        '
        'chkIn_Despatch_Manifest
        '
        Me.chkIn_Despatch_Manifest.Location = New System.Drawing.Point(584, 72)
        Me.chkIn_Despatch_Manifest.Name = "chkIn_Despatch_Manifest"
        Me.chkIn_Despatch_Manifest.Size = New System.Drawing.Size(136, 20)
        Me.chkIn_Despatch_Manifest.TabIndex = 24
        Me.chkIn_Despatch_Manifest.Text = "In DesPatch Manifest"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Location = New System.Drawing.Point(760, 72)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(24, 23)
        Me.UltraLabel5.TabIndex = 25
        Me.UltraLabel5.Text = "Bản"
        '
        'chkTuiF
        '
        Me.chkTuiF.Location = New System.Drawing.Point(376, 152)
        Me.chkTuiF.Name = "chkTuiF"
        Me.chkTuiF.Size = New System.Drawing.Size(56, 16)
        Me.chkTuiF.TabIndex = 21
        Me.chkTuiF.Text = "Túi F"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(216, 152)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel6.TabIndex = 22
        Me.UltraLabel6.Text = "Trọng Lượn&g Vỏ Túi"
        '
        'dgE1
        '
        Me.dgE1.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.dgE1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1.DisplayLayout.Appearance = Appearance1
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
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Nước Nhận"
        UltraGridColumn19.Header.VisiblePosition = 17
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Nước Trả"
        UltraGridColumn20.Header.VisiblePosition = 18
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
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
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
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
        UltraGridColumn29.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn29.Header.VisiblePosition = 27
        UltraGridColumn29.Hidden = True
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
        UltraGridColumn36.Header.Caption = "Cước Dịch Vụ"
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
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 44
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
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(366, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.DefaultCellValue = ""
        UltraGridColumn45.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(332, 0)
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
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "ID Người Dùng"
        UltraGridColumn51.Header.VisiblePosition = 50
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "ID Trạng Thái"
        UltraGridColumn52.Header.VisiblePosition = 51
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.DefaultCellValue = ""
        UltraGridColumn53.Header.Caption = "Ghi Chú"
        UltraGridColumn53.Header.VisiblePosition = 52
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.DefaultCellValue = "0"
        UltraGridColumn54.Header.VisiblePosition = 53
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 54
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
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
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgE1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1.DisplayLayout.InterBandSpacing = 10
        Me.dgE1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE1.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgE1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.dgE1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE1.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.dgE1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1.Location = New System.Drawing.Point(8, 184)
        Me.dgE1.Name = "dgE1"
        Me.dgE1.Size = New System.Drawing.Size(768, 376)
        Me.dgE1.TabIndex = 28
        Me.dgE1.Text = "Danh sách E1 trong bản kê E2"
        '
        'chkIn_CN35
        '
        Me.chkIn_CN35.Location = New System.Drawing.Point(584, 24)
        Me.chkIn_CN35.Name = "chkIn_CN35"
        Me.chkIn_CN35.TabIndex = 18
        Me.chkIn_CN35.Text = "CN35"
        '
        'chkIn_CN38
        '
        Me.chkIn_CN38.Location = New System.Drawing.Point(584, 48)
        Me.chkIn_CN38.Name = "chkIn_CN38"
        Me.chkIn_CN38.TabIndex = 19
        Me.chkIn_CN38.Text = "CN38"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Location = New System.Drawing.Point(760, 48)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(24, 23)
        Me.UltraLabel7.TabIndex = 21
        Me.UltraLabel7.Text = "Bản"
        '
        'txtThongTin
        '
        Me.txtThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThongTin.Location = New System.Drawing.Point(8, 144)
        Me.txtThongTin.Multiline = True
        Me.txtThongTin.Name = "txtThongTin"
        Me.txtThongTin.Size = New System.Drawing.Size(432, 72)
        Me.txtThongTin.TabIndex = 27
        Me.txtThongTin.Visible = False
        '
        'txtInfor
        '
        Me.txtInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfor.Location = New System.Drawing.Point(504, 144)
        Me.txtInfor.Multiline = True
        Me.txtInfor.Name = "txtInfor"
        Me.txtInfor.Size = New System.Drawing.Size(208, 72)
        Me.txtInfor.TabIndex = 26
        Me.txtInfor.Visible = False
        '
        'cbDuongThuDi
        '
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbDuongThuDi.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.cbDuongThuDi.Location = New System.Drawing.Point(200, 72)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(104, 21)
        Me.cbDuongThuDi.TabIndex = 5
        Me.cbDuongThuDi.ValueMember = ""
        '
        'cbChuyenThuDi
        '
        Me.cbChuyenThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn74.Header.Caption = "Chuyến Thư"
        UltraGridColumn74.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn74})
        UltraGridBand3.Header.Caption = "Chuyến Thư Đi"
        Me.cbChuyenThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cbChuyenThuDi.DisplayMember = ""
        Me.cbChuyenThuDi.Location = New System.Drawing.Point(368, 72)
        Me.cbChuyenThuDi.Name = "cbChuyenThuDi"
        Me.cbChuyenThuDi.Size = New System.Drawing.Size(64, 21)
        Me.cbChuyenThuDi.TabIndex = 9
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
        Me.cbTuiSoDi.Location = New System.Drawing.Point(368, 120)
        Me.cbTuiSoDi.Name = "cbTuiSoDi"
        Me.cbTuiSoDi.Size = New System.Drawing.Size(64, 21)
        Me.cbTuiSoDi.TabIndex = 15
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
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(56, 336)
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
        UltraGridColumn79.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn79.Header.VisiblePosition = 0
        UltraGridColumn80.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn80.Header.VisiblePosition = 1
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn79, UltraGridColumn80})
        Me.ddMa_BC.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ddMa_BC.DisplayMember = ""
        Me.ddMa_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC.Location = New System.Drawing.Point(304, 336)
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
        Me.ddPhan_Loai_BP.Location = New System.Drawing.Point(304, 320)
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
        Me.ddLoai_BP.Location = New System.Drawing.Point(568, 328)
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
        Me.ddLoai_Hang_Hoa.Location = New System.Drawing.Point(56, 312)
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
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(800, 72)
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
        'chkBcChuyenHoan
        '
        Me.chkBcChuyenHoan.Location = New System.Drawing.Point(160, 110)
        Me.chkBcChuyenHoan.Name = "chkBcChuyenHoan"
        Me.chkBcChuyenHoan.Size = New System.Drawing.Size(128, 20)
        Me.chkBcChuyenHoan.TabIndex = 0
        Me.chkBcChuyenHoan.Text = "BC Chuyển Hoàn"
        '
        'chk_Ngaynghi
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.chk_Ngaynghi.Appearance = Appearance7
        Me.chk_Ngaynghi.Location = New System.Drawing.Point(448, 64)
        Me.chk_Ngaynghi.Name = "chk_Ngaynghi"
        Me.chk_Ngaynghi.Size = New System.Drawing.Size(80, 18)
        Me.chk_Ngaynghi.TabIndex = 18
        Me.chk_Ngaynghi.Text = "Ngày Nghỉ"
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
        Me.UltraLabel8.Location = New System.Drawing.Point(10, 96)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel8.TabIndex = 20
        Me.UltraLabel8.Text = "Đầ&u mã"
        '
        'ddTo_Hop_DV_Gia_Tang
        '
        Me.ddTo_Hop_DV_Gia_Tang.Cursor = System.Windows.Forms.Cursors.Default
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Appearance = Appearance8
        UltraGridColumn87.Header.Caption = "Tổ hợp mã dv"
        UltraGridColumn87.Header.VisiblePosition = 0
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn87})
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Gia_Tang.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.ddTo_Hop_DV_Gia_Tang.DisplayMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Location = New System.Drawing.Point(424, 424)
        Me.ddTo_Hop_DV_Gia_Tang.Name = "ddTo_Hop_DV_Gia_Tang"
        Me.ddTo_Hop_DV_Gia_Tang.Size = New System.Drawing.Size(120, 96)
        Me.ddTo_Hop_DV_Gia_Tang.TabIndex = 89
        Me.ddTo_Hop_DV_Gia_Tang.ValueMember = ""
        Me.ddTo_Hop_DV_Gia_Tang.Visible = False
        '
        'ddTo_Hop_DV_Cong_Them
        '
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Appearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance11
        UltraGridColumn88.Header.Caption = "Tổ hợp dịch vụ"
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Width = 350
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn88})
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance12.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTo_Hop_DV_Cong_Them.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.ddTo_Hop_DV_Cong_Them.DisplayMember = ""
        Me.ddTo_Hop_DV_Cong_Them.Location = New System.Drawing.Point(88, 368)
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
        Me.txtDauMa.Location = New System.Drawing.Point(10, 128)
        Me.txtDauMa.Name = "txtDauMa"
        Me.txtDauMa.Size = New System.Drawing.Size(40, 20)
        Me.txtDauMa.TabIndex = 21
        Me.txtDauMa.Text = "EA"
        '
        'txtTrongluongTui
        '
        Me.txtTrongluongTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTrongluongTui.InputMask = "999"
        Me.txtTrongluongTui.Location = New System.Drawing.Point(320, 152)
        Me.txtTrongluongTui.Name = "txtTrongluongTui"
        Me.txtTrongluongTui.Size = New System.Drawing.Size(40, 20)
        Me.txtTrongluongTui.TabIndex = 23
        '
        'txtBan_DesManifest
        '
        Me.txtBan_DesManifest.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBan_DesManifest.InputMask = "9"
        Me.txtBan_DesManifest.Location = New System.Drawing.Point(728, 72)
        Me.txtBan_DesManifest.Name = "txtBan_DesManifest"
        Me.txtBan_DesManifest.Size = New System.Drawing.Size(24, 20)
        Me.txtBan_DesManifest.TabIndex = 93
        '
        'txtBan_CN38
        '
        Me.txtBan_CN38.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBan_CN38.InputMask = "99"
        Me.txtBan_CN38.Location = New System.Drawing.Point(728, 48)
        Me.txtBan_CN38.Name = "txtBan_CN38"
        Me.txtBan_CN38.Size = New System.Drawing.Size(24, 20)
        Me.txtBan_CN38.TabIndex = 94
        '
        'cbMaNuoc
        '
        Me.cbMaNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMaNuoc.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90})
        Me.cbMaNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.cbMaNuoc.DisplayMember = ""
        Me.cbMaNuoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaNuoc.Location = New System.Drawing.Point(128, 72)
        Me.cbMaNuoc.Name = "cbMaNuoc"
        Me.cbMaNuoc.Size = New System.Drawing.Size(64, 21)
        Me.cbMaNuoc.TabIndex = 3
        Me.cbMaNuoc.ValueMember = ""
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Location = New System.Drawing.Point(128, 48)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(56, 23)
        Me.UltraLabel10.TabIndex = 2
        Me.UltraLabel10.Text = "&Mã Nước"
        '
        'cbLoai_Chuyen_Thu
        '
        Me.cbLoai_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbLoai_Chuyen_Thu.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn91.Header.Caption = "Mã Loại"
        UltraGridColumn91.Header.VisiblePosition = 0
        UltraGridColumn91.Width = 55
        UltraGridColumn92.Header.Caption = "Tên Loại"
        UltraGridColumn92.Header.VisiblePosition = 1
        UltraGridColumn92.Width = 83
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn91, UltraGridColumn92})
        UltraGridBand13.Header.Caption = "Chuyến Thư Đi"
        Me.cbLoai_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.cbLoai_Chuyen_Thu.DisplayMember = ""
        Me.cbLoai_Chuyen_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Chuyen_Thu.Location = New System.Drawing.Point(312, 72)
        Me.cbLoai_Chuyen_Thu.Name = "cbLoai_Chuyen_Thu"
        Me.cbLoai_Chuyen_Thu.Size = New System.Drawing.Size(48, 21)
        Me.cbLoai_Chuyen_Thu.TabIndex = 7
        Me.cbLoai_Chuyen_Thu.ValueMember = ""
        '
        'UltraLabel9
        '
        Me.UltraLabel9.Location = New System.Drawing.Point(312, 48)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 23)
        Me.UltraLabel9.TabIndex = 6
        Me.UltraLabel9.Text = "&Loại CT"
        '
        'cbDuongBay
        '
        Me.cbDuongBay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn93.Header.VisiblePosition = 0
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.Caption = "Số hiệu chuyến bay"
        UltraGridColumn94.Header.VisiblePosition = 1
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn93, UltraGridColumn94})
        Me.cbDuongBay.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.cbDuongBay.DisplayMember = "So_Hieu"
        Me.cbDuongBay.Location = New System.Drawing.Point(240, 120)
        Me.cbDuongBay.Name = "cbDuongBay"
        Me.cbDuongBay.Size = New System.Drawing.Size(112, 21)
        Me.cbDuongBay.TabIndex = 13
        Me.cbDuongBay.ValueMember = "Id_Duong_Bay"
        '
        'txtBan_RecManifest
        '
        Me.txtBan_RecManifest.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBan_RecManifest.InputMask = "9"
        Me.txtBan_RecManifest.Location = New System.Drawing.Point(728, 0)
        Me.txtBan_RecManifest.Name = "txtBan_RecManifest"
        Me.txtBan_RecManifest.Size = New System.Drawing.Size(24, 20)
        Me.txtBan_RecManifest.TabIndex = 109
        '
        'chkIn_Receptacle_Manifest
        '
        Me.chkIn_Receptacle_Manifest.Location = New System.Drawing.Point(584, 0)
        Me.chkIn_Receptacle_Manifest.Name = "chkIn_Receptacle_Manifest"
        Me.chkIn_Receptacle_Manifest.Size = New System.Drawing.Size(136, 20)
        Me.chkIn_Receptacle_Manifest.TabIndex = 107
        Me.chkIn_Receptacle_Manifest.Text = "In Receptacle Manifest"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Location = New System.Drawing.Point(760, 0)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(24, 23)
        Me.UltraLabel11.TabIndex = 108
        Me.UltraLabel11.Text = "Bản"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Location = New System.Drawing.Point(128, 96)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel12.TabIndex = 10
        Me.UltraLabel12.Text = "Ngày Ba&y"
        '
        'cbNgayBay
        '
        Me.cbNgayBay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayBay.Location = New System.Drawing.Point(128, 120)
        Me.cbNgayBay.Name = "cbNgayBay"
        Me.cbNgayBay.Size = New System.Drawing.Size(96, 21)
        Me.cbNgayBay.TabIndex = 11
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Location = New System.Drawing.Point(240, 96)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel13.TabIndex = 12
        Me.UltraLabel13.Text = "Chuyến &Bay"
        '
        'BtnExit
        '
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.Image = CType(resources.GetObject("Appearance13.Image"), Object)
        Me.BtnExit.Appearance = Appearance13
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.BtnExit.ImageSize = New System.Drawing.Size(40, 25)
        Me.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnExit.Location = New System.Drawing.Point(720, 144)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(56, 32)
        Me.BtnExit.TabIndex = 115
        '
        'btnPrint
        '
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnPrint.Appearance = Appearance14
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPrint.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrint.Location = New System.Drawing.Point(560, 144)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(48, 32)
        Me.btnPrint.TabIndex = 114
        '
        'btnPreview
        '
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.btnPreview.Appearance = Appearance15
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(504, 144)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(48, 32)
        Me.btnPreview.TabIndex = 113
        '
        'txtBan_BV10
        '
        Me.txtBan_BV10.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBan_BV10.InputMask = "9"
        Me.txtBan_BV10.Location = New System.Drawing.Point(728, 96)
        Me.txtBan_BV10.Name = "txtBan_BV10"
        Me.txtBan_BV10.Size = New System.Drawing.Size(24, 20)
        Me.txtBan_BV10.TabIndex = 118
        '
        'UltraLabel14
        '
        Me.UltraLabel14.Location = New System.Drawing.Point(760, 96)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(24, 23)
        Me.UltraLabel14.TabIndex = 117
        Me.UltraLabel14.Text = "Bản"
        '
        'chkIn_BV10
        '
        Me.chkIn_BV10.Location = New System.Drawing.Point(584, 96)
        Me.chkIn_BV10.Name = "chkIn_BV10"
        Me.chkIn_BV10.TabIndex = 116
        Me.chkIn_BV10.Text = "In BV10"
        '
        'txtBan_CN37
        '
        Me.txtBan_CN37.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtBan_CN37.InputMask = "99"
        Me.txtBan_CN37.Location = New System.Drawing.Point(728, 120)
        Me.txtBan_CN37.Name = "txtBan_CN37"
        Me.txtBan_CN37.Size = New System.Drawing.Size(24, 20)
        Me.txtBan_CN37.TabIndex = 121
        '
        'UltraLabel15
        '
        Me.UltraLabel15.Location = New System.Drawing.Point(760, 120)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(24, 23)
        Me.UltraLabel15.TabIndex = 120
        Me.UltraLabel15.Text = "Bản"
        '
        'chkIn_CN37
        '
        Me.chkIn_CN37.Location = New System.Drawing.Point(584, 120)
        Me.chkIn_CN37.Name = "chkIn_CN37"
        Me.chkIn_CN37.TabIndex = 119
        Me.chkIn_CN37.Text = "In CN37"
        '
        'BtnTimE1
        '
        Me.BtnTimE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTimE1.Location = New System.Drawing.Point(510, 10)
        Me.BtnTimE1.Name = "BtnTimE1"
        Me.BtnTimE1.Size = New System.Drawing.Size(64, 48)
        Me.BtnTimE1.TabIndex = 122
        Me.BtnTimE1.Text = "Tra &cứu"
        '
        'ddMa_BC_Tra
        '
        Me.ddMa_BC_Tra.Cursor = System.Windows.Forms.Cursors.Default
        UltraGridColumn95.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn95.Header.VisiblePosition = 0
        UltraGridColumn96.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn96.Header.VisiblePosition = 1
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn95, UltraGridColumn96})
        Me.ddMa_BC_Tra.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.ddMa_BC_Tra.DisplayMember = ""
        Me.ddMa_BC_Tra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_BC_Tra.Location = New System.Drawing.Point(291, 230)
        Me.ddMa_BC_Tra.Name = "ddMa_BC_Tra"
        Me.ddMa_BC_Tra.Size = New System.Drawing.Size(208, 112)
        Me.ddMa_BC_Tra.TabIndex = 123
        Me.ddMa_BC_Tra.Text = "MaBc"
        Me.ddMa_BC_Tra.ValueMember = ""
        Me.ddMa_BC_Tra.Visible = False
        '
        'Group_Thiet_Lap_Tham_So
        '
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkTrangThaiThuThue)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkTong_Thue_Le_Phi)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chkThue_Tieu_Thu)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Bo_Qua)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Cap_Nhat)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_Khac)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_TV)
        Me.Group_Thiet_Lap_Tham_So.Controls.Add(Me.chk_Le_Phi_DV)
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
        Me.Group_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(10, 150)
        Me.Group_Thiet_Lap_Tham_So.Name = "Group_Thiet_Lap_Tham_So"
        Me.Group_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(430, 300)
        Me.Group_Thiet_Lap_Tham_So.SupportThemes = False
        Me.Group_Thiet_Lap_Tham_So.TabIndex = 124
        Me.Group_Thiet_Lap_Tham_So.Text = "Thiết Lập Tham Số"
        '
        'chkTrangThaiThuThue
        '
        Me.chkTrangThaiThuThue.Location = New System.Drawing.Point(300, 230)
        Me.chkTrangThaiThuThue.Name = "chkTrangThaiThuThue"
        Me.chkTrangThaiThuThue.TabIndex = 45
        Me.chkTrangThaiThuThue.Text = "Trạng thái thu thuế"
        '
        'chkTong_Thue_Le_Phi
        '
        Me.chkTong_Thue_Le_Phi.Location = New System.Drawing.Point(300, 200)
        Me.chkTong_Thue_Le_Phi.Name = "chkTong_Thue_Le_Phi"
        Me.chkTong_Thue_Le_Phi.TabIndex = 44
        Me.chkTong_Thue_Le_Phi.Text = "Tổng Thuế Lệ Phí"
        '
        'chkThue_Tieu_Thu
        '
        Me.chkThue_Tieu_Thu.Location = New System.Drawing.Point(300, 170)
        Me.chkThue_Tieu_Thu.Name = "chkThue_Tieu_Thu"
        Me.chkThue_Tieu_Thu.TabIndex = 43
        Me.chkThue_Tieu_Thu.Text = "Thuế Tiêu Thụ ĐB"
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
        '
        'chk_Le_Phi_DV
        '
        Me.chk_Le_Phi_DV.Location = New System.Drawing.Point(300, 80)
        Me.chk_Le_Phi_DV.Name = "chk_Le_Phi_DV"
        Me.chk_Le_Phi_DV.TabIndex = 33
        Me.chk_Le_Phi_DV.Text = "Lệ Phí Động Vật"
        '
        'chk_Le_Phi_YT
        '
        Me.chk_Le_Phi_YT.Location = New System.Drawing.Point(300, 50)
        Me.chk_Le_Phi_YT.Name = "chk_Le_Phi_YT"
        Me.chk_Le_Phi_YT.TabIndex = 32
        Me.chk_Le_Phi_YT.Text = "Lệ Phí Y Tế"
        '
        'chk_Le_Phi_VH
        '
        Me.chk_Le_Phi_VH.Location = New System.Drawing.Point(300, 20)
        Me.chk_Le_Phi_VH.Name = "chk_Le_Phi_VH"
        Me.chk_Le_Phi_VH.TabIndex = 31
        Me.chk_Le_Phi_VH.Text = "Lệ Phí Văn Hóa"
        '
        'btn_Thiet_Lap_Tham_So
        '
        Me.btn_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(10, 152)
        Me.btn_Thiet_Lap_Tham_So.Name = "btn_Thiet_Lap_Tham_So"
        Me.btn_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(100, 25)
        Me.btn_Thiet_Lap_Tham_So.TabIndex = 125
        Me.btn_Thiet_Lap_Tham_So.Text = "Thiết Lập Tham Số"
        '
        'btn_Export_To_Excel
        '
        Me.btn_Export_To_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Export_To_Excel.Location = New System.Drawing.Point(440, 96)
        Me.btn_Export_To_Excel.Name = "btn_Export_To_Excel"
        Me.btn_Export_To_Excel.Size = New System.Drawing.Size(120, 40)
        Me.btn_Export_To_Excel.TabIndex = 126
        Me.btn_Export_To_Excel.Text = "Export To Excel DesPatch Manifest"
        '
        'grbTruyen_Du_Lieu
        '
        Me.grbTruyen_Du_Lieu.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.grbTruyen_Du_Lieu.Controls.Add(Me.PrbCommunication)
        Me.grbTruyen_Du_Lieu.Controls.Add(Me.lblCommunication)
        Me.grbTruyen_Du_Lieu.Location = New System.Drawing.Point(208, 192)
        Me.grbTruyen_Du_Lieu.Name = "grbTruyen_Du_Lieu"
        Me.grbTruyen_Du_Lieu.Size = New System.Drawing.Size(448, 72)
        Me.grbTruyen_Du_Lieu.TabIndex = 45
        Me.grbTruyen_Du_Lieu.Visible = False
        '
        'PrbCommunication
        '
        Me.PrbCommunication.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbCommunication.Location = New System.Drawing.Point(16, 32)
        Me.PrbCommunication.Maximum = 10000
        Me.PrbCommunication.Name = "PrbCommunication"
        Me.PrbCommunication.Size = New System.Drawing.Size(416, 28)
        Me.PrbCommunication.Step = 1
        Me.PrbCommunication.TabIndex = 69
        Me.PrbCommunication.Text = "[Formatted]"
        '
        'lblCommunication
        '
        Me.lblCommunication.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.lblCommunication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommunication.Location = New System.Drawing.Point(16, 8)
        Me.lblCommunication.Name = "lblCommunication"
        Me.lblCommunication.Size = New System.Drawing.Size(400, 16)
        Me.lblCommunication.TabIndex = 68
        Me.lblCommunication.Text = "Tiến trình thực hiện"
        '
        'txtMaSoTui
        '
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.FontData.SizeInPoints = 12.0!
        Me.txtMaSoTui.Appearance = Appearance16
        Me.txtMaSoTui.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaSoTui.Location = New System.Drawing.Point(80, 16)
        Me.txtMaSoTui.Name = "txtMaSoTui"
        Me.txtMaSoTui.Size = New System.Drawing.Size(352, 26)
        Me.txtMaSoTui.TabIndex = 128
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 16)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(72, 23)
        Me.UltraLabel16.TabIndex = 127
        Me.UltraLabel16.Text = "Mã Số Tú&i"
        '
        'FrmThietLapDi_Out001
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(791, 572)
        Me.Controls.Add(Me.txtMaSoTui)
        Me.Controls.Add(Me.UltraLabel16)
        Me.Controls.Add(Me.grbTruyen_Du_Lieu)
        Me.Controls.Add(Me.btn_Export_To_Excel)
        Me.Controls.Add(Me.btn_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.Group_Thiet_Lap_Tham_So)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.ddMa_BC_Tra)
        Me.Controls.Add(Me.BtnTimE1)
        Me.Controls.Add(Me.txtBan_CN37)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.chkIn_CN37)
        Me.Controls.Add(Me.txtBan_BV10)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.chkIn_BV10)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.cbNgayBay)
        Me.Controls.Add(Me.txtBan_RecManifest)
        Me.Controls.Add(Me.chkIn_Receptacle_Manifest)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.cbDuongBay)
        Me.Controls.Add(Me.cbMaNuoc)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.cbLoai_Chuyen_Thu)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.txtBan_CN38)
        Me.Controls.Add(Me.txtBan_DesManifest)
        Me.Controls.Add(Me.txtTrongluongTui)
        Me.Controls.Add(Me.txtDauMa)
        Me.Controls.Add(Me.ddTo_Hop_DV_Cong_Them)
        Me.Controls.Add(Me.ddTo_Hop_DV_Gia_Tang)
        Me.Controls.Add(Me.UltraLabel8)
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
        Me.Controls.Add(Me.dgE1)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.chkTuiF)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cbNgayDong)
        Me.Controls.Add(Me.btnMoTui)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.chkIn_CN35)
        Me.Controls.Add(Me.chkIn_Despatch_Manifest)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.chkIn_CN38)
        Me.Controls.Add(Me.chk_Ngaynghi)
        Me.Name = "FrmThietLapDi_Out001"
        Me.Text = "Thiết Lập bản kê E2 đóng đi"
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cbMaNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongBay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayBay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_BC_Tra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Thiet_Lap_Tham_So, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Thiet_Lap_Tham_So.ResumeLayout(False)
        Me.grbTruyen_Du_Lieu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "=======================Khai báo biến======================="
    '------------------------------
    'Search Grid
    Dim FrmSearch As FrmTimKiemDanhMuc = Nothing
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim FrmTK As FrmTimKiemDanhMuc = Nothing

    'Grid
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    Dim myTinh_Cuoc As New Tinh_Cuoc(GConnectionString)
    Dim myTinh_Cuoc_Chi_Tiet As Tinh_Cuoc_Chi_Tiet

    'Chuyến thư
    Dim myCN38 As New CN38(GConnectionString)
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)

    'E2
    Dim myE2_Date As Integer
    Dim myFlight_Date As Integer
    Dim myE2_Time As Integer
    Dim myStart_Date As Integer
    Dim myEnd_Date As Integer

    Dim myMa_Nuoc_Di As String
    Dim myId_Duong_Thu As String
    Dim myLoai_Chuyen_Thu As String
    Dim myId_Chuyen_Thu As String
    Dim myId_Duong_Bay As String
    Dim myId_E2 As String

    Dim mySo_Chuyen_Thu_Di_Lon_Nhat As Integer
    Dim myTui_So_Di_Lon_Nhat As Integer
    Dim myMax_DongF As Boolean
    Dim myTongso As Integer
    Dim myTongKhoiLuongBP As Integer

    Dim myE2_Di As New E2_Di(GConnectionString)

    'E1
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myId_Nguoi_Dung As Integer
    Dim myId_Ca As String
    Dim myId_Trang_Thai As String
    Dim myE1_Di As New E1_Di(GConnectionString)

    'Sử dụng trong đường thư lưu kho
    Dim myE1_Den_Tam As New E1_Den_Tam(GConnectionString)
    Dim myE2_Den_Tam As New E2_Den_Tam(GConnectionString)
    Dim myChuyen_Thu_Den_Tam As New Chuyen_Thu_Den_Tam(GConnectionString)

    'Đối với đường thư lưu kho
    Dim myId_Duong_Thu_Luu_Kho As String
    Dim myId_Chuyen_Thu_Luu_Kho As String
    Dim myId_E2_Luu_Kho As String
    Dim myId_E1_Luu_Kho As String

    'Lệ phí hải quan
    Dim myE1_Le_Phi_Den As New E1_Le_Phi_Den(GConnectionString)
    Dim myE1_Le_Phi_Di As New E1_Le_Phi_Di(GConnectionString)
    Dim myE1_Le_Phi_Den_Tam As New E1_Le_Phi_Den_Tam(GConnectionString)

    'PayPost
    Dim myE1_COD_Tam As New E1_COD_Tam(GConnectionString)

    'Trạng thái
    Dim myTrang_Thai_Chi_Tiet As New Trang_Thai_Chi_Tiet
    Dim myTrang_Thai As New Trang_Thai(GConnectionString)
    Dim myCODDi As New COD_Di(GConnectionString)

    'Registry + truyền nhận
    Dim myKeys As New ModifyRegistry
    Dim myUtility As New Ems_Utility.Ems_Utility.Ems_MSMQ(GConnectionString)

    'Commbo
    'Dim myMaBc As New Danh_Muc_BC(GConnectionString)
    Dim myMaTinh As New Ma_Tinh(GConnectionString)
    Dim myMa_Nuoc_Hien_Tai As String 'Để cho không bị nhảy mã đường thư
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)

    Dim myMaNuoc As New Ma_Nuoc(GConnectionString)
    Dim myDanh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
    Dim myDanh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet

    Dim myMa_Bc As Integer
    Dim mySo_Chuyen_Thu_Di As Integer
    Dim myTui_So_Di As Integer

    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myCN38_Chi_Tiet As New CN38_Chi_Tiet
    Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet

    'Control Form
    Dim IsOpenBag As Boolean 'Xác định túi có được mở ra không

    'Dùng chung
    Dim myDichVu As New Dich_Vu(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    'In ấn
    Dim myIn_BV10_To_Text As New In_BV10_To_Text
    Dim myIn_BC37_To_Text As New In_BC37_To_Text

    'Biến nội bộ cho khai báo các nút checkbox
    'Dim LSo_Ban_DesManifest As Integer
    'Dim LSo_Ban_RecManifest As Integer
    'Dim LSo_Ban_CN38 As Integer
    'Dim LSo_Ban_BV10 As Integer
    'Dim LSo_Ban_CN37 As Integer
    'Dim LIn_RecManifest As Boolean
    'Dim LIn_DesManifest As Boolean
    'Dim LIn_CN35 As Boolean
    'Dim LIn_CN38 As Boolean
    'Dim LIn_BV10 As Boolean
    'Dim LIn_CN37 As Boolean
    'Dim LKhoi_Luong_Vo_Tui As Integer

    'Lấy thông tin trùng số liệu, số liệu truyền đến
    Dim myE1_Di_Chi_Tiet_Trung As New E1_Di_Chi_Tiet
    Dim myE1_Le_Phi_Di_Chi_Tiet_Trung As New E1_Le_Phi_Di_Chi_Tiet
    Dim myE1_Den_Chi_Tiet_XN As New E1_Den_Chi_Tiet 'Dữ liệu xác nhận đến
    Dim myE1_Den_Chi_Tiet_XN_Trung As New E1_Den_Chi_Tiet 'Dữ liệu xác nhận đến

    'Biến kiểm tra trùng số liệu, số liệu xác nhận đến
    Dim myIsTrungSoLieu As Boolean
    Dim myIsChoPhepTrung As Boolean
    Dim myMAE1Thoat As Boolean
    Dim myIsXacNhanDen As Boolean 'Số hiệu E1 đã được xác nhận đến trong ca chưa
    Dim myIsDaKiemTraTrung As Boolean 'Đã được kiểm tra trùng dữ liệu chưa
    Dim myIsChoPhepKoXacNhanDen As Boolean 'Cho phép nhập dữ liệu mà không cần xác nhận đến

    'Kiểm tra chuyển hoàn
    Dim myIsChuyenHoan As Boolean 'Xác định bưu gửi là chuyển hoàn
    Dim myIsNhapChuyenHoan As Boolean 'Xác định việc nhập thông tin chuyển hoàn hay không (nếu là bưu gửi chuyển hoàn)

    'Kiểm tra lạc hướng
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myMa_Nuoc_Theo_Duong_Thu As String
    Dim myMa_Tinh_Theo_Duong_Thu As String

    Dim myLastColumnKey As String 'AddNewTemplateRow


    Dim myPredes As New Predes(GConnectionString)
    Dim myEdi_MailBox As New EDI_mailbox(GConnectionString)

    'Ghi Log_Event
    Dim myLog_Id As Integer

    Dim myMaNuocTheoDuongThu As String = "VN"
    Dim myChoPhepLacHuong As Boolean = False
#End Region

#Region "========================Control Form========================"
#Region "------------------------FrmThietLapE2Di_Load------------------------"
    Private Sub FrmThietLapE2Di_Out001_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DesignForm()

        GetKeys()

        Thiet_Lap_Tham_So()

        Load_Data()

        Init_Form()

        Validate_Commbo()

        SetLastColumnVisibleKey(dgE1)

        dgE1.DataSource = myE1_Di.E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT(0).Tables(0)
        dgE1.DisplayLayout.Override.ResetAllowAddNew()

        cbNgayDong.Select()
    End Sub
#End Region

#Region "------------------------DesignForm------------------------"
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

#Region "------------------------GetKeys------------------------"
    Private Sub GetKeys()
        chkIn_Receptacle_Manifest.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_RecManifest"), "False"))
        chkIn_Despatch_Manifest.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_DesManifest"), "False"))
        chkIn_CN35.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_CN35"), "False"))
        chkIn_CN38.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_CN38"), "False"))
        chkIn_BV10.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_BV10"), "False"))
        chkIn_CN37.Checked = CBool(SetNullValue(myKeys.Doc("OB_In_CN37"), "False"))

        txtBan_DesManifest.Text = CInt(SetNullValue(myKeys.Doc("OB_So_Ban_DesManifest"), "0"))
        txtBan_RecManifest.Text = CInt(SetNullValue(myKeys.Doc("OB_So_Ban_RecManifest"), "0"))
        txtBan_CN38.Text = CInt(SetNullValue(myKeys.Doc("OB_So_Ban_CN38"), "0"))
        txtBan_BV10.Text = CInt(SetNullValue(myKeys.Doc("OB_So_Ban_BV10"), "0"))
        txtBan_CN37.Text = CInt(SetNullValue(myKeys.Doc("OB_So_Ban_CN37"), "0"))

        GMa_Dau_So = SetNullValue(myKeys.Doc("DauMa"), "EE")
        txtDauMa.Text = SetNullValue(myKeys.Doc("DauMa"), "EE")
        txtTrongluongTui.Text = CInt(SetNullValue(myKeys.Doc("OB_TrongLuong_VoTui_Di"), "0"))

        'Cho phép sửa cước
        gSua_Cuoc_Chinh = CBool(SetNullValue(myKeys.Doc("GSua_Cuoc_Chinh"), "False"))
        gSua_Cuoc_DV = CBool(SetNullValue(myKeys.Doc("GSua_Cuoc_DV"), "False"))
        gSua_Cuoc_E1 = CBool(SetNullValue(myKeys.Doc("GSua_Cuoc_E1"), "False"))

        'In bản kê Hải quan bưu điện
        GIn_Ban_Ke_HQ_Buu_Dien = CBool(SetNullValue(myKeys.Doc("GIn_Ban_Ke_HQ_Buu_Dien"), "False"))
        'In E4
        GKieu_In_E4_New = IIf(myKeys.Doc("KieuInE4New") Is Nothing Or myKeys.Doc("KieuInE4New") = "", False, IIf(myKeys.Doc("KieuInE4New") = "1", True, False))
        GTen_May_In_E4_New = IIf(myKeys.Doc("TenMayInE4New") Is Nothing Or myKeys.Doc("TenMayInE4New") = "", "", myKeys.Doc("TenMayInE4New"))

    End Sub
#End Region

#Region "-----------------------Load_Data-----------------------"
    Private Sub Load_Data()
        Tao_Bang_Phan_Loai_BP()
        Tao_Bang_Loai_Hang_Hoa()
        Tao_Bang_Loai_BP()
        'To_Hop_Ma_DV_Cong_Them()
        'To_Hop_Ma_DV_Gia_Tang()
        ddMa_Nuoc.DataSource = myMaNuoc.Danh_Sach_Rut_Gon()
        ddMa_Nuoc.DataBind()
        ddMa_BC.DataSource = myDanh_Muc_Bc.Danh_Sach_Rut_Gon.Tables(0)
        ddMa_BC.DataBind()
        ddMa_BC_Tra.DataSource = myMaTinh.Danh_Sach_Rut_Gon.Tables(0) 'myMaBc.Danh_Sach_Rut_Gon_KT.Tables(0)
        ddMa_BC_Tra.DataBind()
        Tao_Bang_Phan_Loai_Chuyen_Thu()
    End Sub

#Region "------------------------Tạo bảng Phân loại bưu phẩm------------------------"
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

#Region "------------------------Tạo bảng Loại bưu phẩm------------------------"
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

#Region "------------------------Tạo bảng Loại Hàng Hóa------------------------"
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

#Region "------------------------Tạo bảng To_Hop_Ma_DV_Cong_Them------------------------"
    Private Sub To_Hop_Ma_DV_Cong_Them()
        ddTo_Hop_DV_Cong_Them.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(0)
        ddTo_Hop_DV_Cong_Them.DataBind()
    End Sub
#End Region

#Region "------------------------Tạo bảng To_Hop_Ma_DV_Gia_Tang------------------------"
    Private Sub To_Hop_Ma_DV_Gia_Tang()
        ddTo_Hop_DV_Gia_Tang.DataSource = myDichVu.Danh_Sach_Dich_Vu_Phan_Loai(1)
        ddTo_Hop_DV_Gia_Tang.DataBind()
    End Sub
#End Region

#Region "------------------------Tạo bảng Phân loại chuyến thư------------------------"
    Private Sub Tao_Bang_Phan_Loai_Chuyen_Thu()
        Dim dataTable As New DataTable("Phan_Loai_Chuyen_Thu")

        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(String))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Loai") = "EA"
        row("Ten_Loai") = "Mix A"
        dataTable.Rows.Add(row)

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

        cbLoai_Chuyen_Thu.DataSource = dataTable
        cbLoai_Chuyen_Thu.DataBind()
        cbLoai_Chuyen_Thu.LimitToList() = True
    End Sub
#End Region
#End Region

#Region "------------------------Init_Form------------------------"
    Private Function Init_Form() As Boolean
        'Them dong canh bao ngay nghi 
        Dim Ngay_Hien_Tai As Date = Now()
        If Kiem_Tra_Ngay_Nghi(Ngay_Hien_Tai) Then
            If MessageBox.Show("Chú ý, hôm nay ngày: " & Ngay_Hien_Tai.Day & " Tháng " & Ngay_Hien_Tai.Month & " Năm " & Ngay_Hien_Tai.Year & ", là ngày nghỉ!!!" & vbNewLine & "Bạn có muốn đánh dấu vào trạng thái ngày nghỉ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                chk_Ngaynghi.Checked = True
            Else
                chk_Ngaynghi.Checked = False
            End If
        Else
            chk_Ngaynghi.Checked = False
        End If

        'Thông tin trên Form
        Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
        Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
        myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay_Ca_Hien_Tai(GBuu_Cuc_Khai_Thac)
        Text = "Thiết Lập Bản Kê E2 đóng đi. Bưu cục khai thác:" & GBuu_Cuc_Khai_Thac & "-" & GTen_Buu_Cuc_Khai_Thac & "-Ca hiện tại là ca: " & myCa_San_Xuat_Chi_Tiet.Thu_Tu & "- " & myHam_Dung_Chung.ConvertIntToDate_VN(CInt(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac))

        txtThongTin.Text = "Thiết lập bản kê E2 đóng đi tại: " & GBuu_Cuc_Khai_Thac & "(" & GTen_Buu_Cuc_Khai_Thac & ")"
        txtInfor.Text = "Tổng số     : 0" & vbNewLine & "Khối lượng : 0"

        chkTuiF.Checked = False
        chkIn_CN38.Enabled = False
        chkIn_BV10.Enabled = False
        chkIn_CN37.Enabled = False
        chkIn_Despatch_Manifest.Enabled = False
        chkIn_CN38.Checked = False
        chkIn_BV10.Checked = False
        chkIn_CN37.Checked = False
        chkIn_Despatch_Manifest.Checked = False
        Group_Thiet_Lap_Tham_So.Visible = False

        cbNgayDong.DateTime = Today
        cbLoai_Chuyen_Thu.Value = cbLoai_Chuyen_Thu.Rows(0).Cells("Ma_Loai").Value
        
        'Ma nuoc
        cbMaNuoc.DataSource = myMaNuoc.Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac_KT(GBuu_Cuc_Khai_Thac)
        cbMaNuoc.DataBind()
        If cbMaNuoc.Rows.Count > 0 Then
            cbMaNuoc.Value = cbMaNuoc.Rows(0).Cells("Ma_Nuoc").Value
        Else
            MessageBox.Show("Không tồn tại đường thư nào trong bưu cục khai thác này!!!" & vbNewLine & _
                            "          Bạn hãy liên hệ với người quản trị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Dispose()
        End If
        cbMaNuoc.LimitToList = True
        myMa_Nuoc_Di = cbMaNuoc.Value

        If Trim(cbMaNuoc.Text) = "VN" Then
            If cbDuongBay.Value <> "" And Not cbDuongBay.Value Is Nothing Then
                chkIn_CN35.Text = "In CN35"
            Else
                chkIn_CN35.Text = "In E4"
            End If
            chkIn_Despatch_Manifest.Enabled = False
            chkIn_Despatch_Manifest.Checked = False
            chkIn_BV10.Enabled = False
            chkIn_BV10.Checked = False

            cbLoai_Chuyen_Thu.Text = "EN"
            cbLoai_Chuyen_Thu.Enabled = False
            'Thiết Lập In
            chkIn_CN38.Text = "In BC37"
            chkIn_CN35.Text = "In E4"
            chkIn_Receptacle_Manifest.Text = "In E2"
            chkIn_CN35.Enabled = True
            chkIn_CN38.Enabled = True
        Else
            chkIn_CN35.Text = "In CN35"
            cbLoai_Chuyen_Thu.Enabled = True
            chkIn_CN38.Text = "In CN38"
            chkIn_CN35.Text = "In CN35"
            chkIn_Receptacle_Manifest.Text = "In Receptacle Manifest"
        End If

        'Danh sách đường thư
        cbDuongThuDi.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT(GBuu_Cuc_Khai_Thac, IIf(myMa_Nuoc_Di = "", "VN", myMa_Nuoc_Di))
        cbDuongThuDi.DataBind()
        cbDuongThuDi.Value = cbDuongThuDi.Rows(0).Cells("Ma_Bc").Value
        cbDuongThuDi.LimitToList = True

        IsOpenBag = False
        Enable_Control(False)

    End Function
#End Region

#Region "-----------------------Thiet_Lap_Tham_So-----------------------"
    Private Sub Thiet_Lap_Tham_So()
        dgE1.DisplayLayout.Bands(0).Columns("Cuoc_E1").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Cuoc_E1"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Nguoi_Nhan"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dia_Chi_Nhan"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dien_Thoai_Nhan"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Dien_Thoai_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dien_Thoai_Gui"), "False"))
        'dgE1.DisplayLayout.Bands(0).Columns("Dien_Thoai_Nhan").Hidden = True
        dgE1.DisplayLayout.Bands(0).Columns("Nguoi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Nguoi_Gui"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Dia_Chi_Gui").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dia_Chi_Gui"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Ghi_Chu").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Ghi_Chu"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_HQ"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_NK"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_VAT"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_So_TKHQ"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_So_Bien_Lai"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Loai_Hang_Hoa").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Loai_Hang_Hoa"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Ma_Bc_CH"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Cuoc_Dv").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Cuoc_Dv"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Kien_So").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Kien_So"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_VH").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_VH"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_YT").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_YT"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_DV").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_DV"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_TV").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_TV"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Le_Phi_Khac").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_Khac"), "False"))

        'dgE1.DisplayLayout.Bands(0).Columns("Thue_Tieu_Thu").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_Tieu_Thu"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Tong_Thue_Le_Phi"), "False"))
        dgE1.DisplayLayout.Bands(0).Columns("Truyen_Doi_Soat").Hidden = Not CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Trang_Thai_Thu_Thue"), "False"))
    End Sub
#End Region

#Region "------------------------Enable_Control------------------------"
    Private Sub Enable_Control(ByVal OpenBag As Boolean)
        cbNgayDong.Enabled = Not OpenBag
        cbMaNuoc.Enabled = Not OpenBag
        cbDuongThuDi.Enabled = Not OpenBag
        cbLoai_Chuyen_Thu.Enabled = Not OpenBag
        cbChuyenThuDi.Enabled = Not OpenBag
        cbNgayBay.Enabled = Not OpenBag
        cbDuongBay.Enabled = Not OpenBag
        cbTuiSoDi.Enabled = Not OpenBag
        txtBan_DesManifest.Enabled = chkIn_Despatch_Manifest.Checked
        txtBan_RecManifest.Enabled = chkIn_Receptacle_Manifest.Checked
        txtBan_CN38.Enabled = chkIn_CN38.Checked
        btnPreview.Enabled = Not OpenBag
        btnPrint.Enabled = Not OpenBag
        If OpenBag = True Then
            dgE1.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            dgE1.DisplayLayout.Override.BorderStyleTemplateAddRow = UIElementBorderStyle.Inset
        Else
            dgE1.DisplayLayout.Override.ResetAllowAddNew()
        End If
        btnMoTui.Text = IIf(Not OpenBag, "Mở &Túi", "Đóng &Túi")
        dgE1.Enabled = OpenBag
        'Cho phép sửa cước
        If GUserAdmin Then
            dgE1.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            dgE1.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            dgE1.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
        Else
            If gSua_Cuoc_Chinh = True Then
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.AllowEdit
            Else
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_Chinh").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_DV = True Then
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.AllowEdit
            Else
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_DV").CellActivation = Activation.NoEdit
            End If
            If gSua_Cuoc_E1 = True Then
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.AllowEdit
            Else
                dgE1.DisplayLayout.Bands(0).Columns("Cuoc_E1").CellActivation = Activation.NoEdit
            End If
        End If
        'Không cho phép chỉnh sửa cột tổng thuế lệ phí
        dgE1.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").CellActivation = Activation.NoEdit
    End Sub
#End Region

#Region "------------------------Validate_Commbo------------------------"
    Private Sub Validate_Commbo()
        myTongso = 0
        myTongKhoiLuongBP = 0

        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Today)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
        cbNgayBay.DateTime = Today
        myFlight_Date = myHam_Dung_Chung.ConvertDateToInt(Today)

        myMa_Nuoc_Di = cbMaNuoc.Value
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
            Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                myStart_Date = (myE2_Date \ 100) * 100
                myEnd_Date = (myE2_Date \ 100) * 100 + 99
            Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê, Lưu kho (5:quốc tế đến, 7:quốc tế đi), Chuyển tiếp giữa các tổ: Chuyến Thư tăng theo Năm
                myStart_Date = (myE2_Date \ 10000) * 10000
                myEnd_Date = (myE2_Date \ 10000) * 10000 + 9999
            Case Else
                MessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        cbDuongBay.DataSource = myDanh_Muc_Duong_Bay.Lay_Boi_Duong_Thu_Di_KT(myId_Duong_Thu)
        cbDuongBay.DataBind()
        If cbDuongBay.Rows.Count > 0 Then
            cbDuongBay.Enabled = True
            cbNgayBay.Enabled = True
            cbDuongBay.Value = cbDuongBay.Rows(0).Cells("So_Hieu").Value
            cbDuongBay.Text = cbDuongBay.Rows(0).Cells("So_Hieu").Value
            myId_Duong_Bay = cbDuongBay.Rows(0).Cells("Id_Duong_Bay").Value
        Else
            cbDuongBay.Enabled = False
            cbNgayBay.Enabled = False
            cbDuongBay.Text = ""
        End If

        myMa_Nuoc_Hien_Tai = myMa_Nuoc_Di
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        cbChuyenThuDi.Text = ""
        cbChuyenThuDi.LimitToList = False
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
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False And isQuaNgay = False Then  'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDi.Value = mySo_Chuyen_Thu_Di_Lon_Nhat
                Else
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                cbChuyenThuDi.Text = 1
            End If
        End If

        mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
        cbTuiSoDi.Text = ""
        cbTuiSoDi.LimitToList = False
        myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di, myLoai_Chuyen_Thu)
        If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then 'Nếu tồn tại chuyến thư
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
            'Tìm trong dữ liệu bảng CN38 có dữ liệu về chuyến bay thì lấy dữ liệu về chuyến bay, ngày bay ra
            Dim m_CN38 As New CN38(GConnectionString)
            Dim m_CN38_Chi_Tiet As New CN38_Chi_Tiet
            m_CN38_Chi_Tiet = m_CN38.Lay(myId_Chuyen_Thu)
            If m_CN38_Chi_Tiet.Id_Duong_Bay <> "" Then
                cbNgayBay.Value = myHam_Dung_Chung.ConvertIntToDate(m_CN38_Chi_Tiet.Ngay_Bay)
                'Tìm đường bay
                Dim m_Danh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
                Dim m_Danh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
                m_Danh_Muc_Duong_Bay_Chi_Tiet = m_Danh_Muc_Duong_Bay.Lay(m_CN38_Chi_Tiet.Id_Duong_Bay)
                cbDuongBay.Value = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
                cbDuongBay.Text = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
            End If
        Else
            cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(0)
            cbTuiSoDi.Text = 1
        End If

        mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
        myTui_So_Di = CInt(cbTuiSoDi.Text)
        txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) _
                    & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                    & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "-Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di) & " - Túi Số: " & myTui_So_Di
    End Sub
#End Region

#Region "------------------------FrmThietLapE2Di_Closing------------------------"
    Private Sub FrmThietLapE2Di_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        chk_Ngaynghi.Checked = False
        SetKeys()
        If IsOpenBag Then
            DongTui()
        End If
    End Sub
#End Region

#Region "------------------------SetKeys------------------------"
    Private Sub SetKeys()
        myKeys.Ghi("OB_So_Ban_DesManifest", txtBan_DesManifest.Text)
        myKeys.Ghi("OB_So_Ban_RecManifest", txtBan_RecManifest.Text)
        myKeys.Ghi("OB_So_Ban_CN38", txtBan_CN38.Text)
        myKeys.Ghi("OB_So_Ban_CN37", txtBan_CN37.Text)
        myKeys.Ghi("OB_So_Ban_BV10", txtBan_BV10.Text)
        myKeys.Ghi("DauMa", txtDauMa.Text)
        myKeys.Ghi("OB_TrongLuong_VoTui_Di", IIf(txtTrongluongTui.Text <> "", txtTrongluongTui.Text, 0))
        myKeys.Ghi("OB_In_Despatch_Manifest", chkIn_Despatch_Manifest.Checked)
        myKeys.Ghi("OB_In_Receptacle_Manifest", chkIn_Receptacle_Manifest.Checked)
        myKeys.Ghi("OB_In_RecManifest", chkIn_Receptacle_Manifest.Checked)
        myKeys.Ghi("OB_In_CN35", chkIn_CN35.Checked)
        myKeys.Ghi("OB_In_CN38", chkIn_CN38.Checked)
        myKeys.Ghi("OB_In_CN37", chkIn_CN37.Checked)
        myKeys.Ghi("OB_In_BV10", chkIn_BV10.Checked)
    End Sub
#End Region

#Region "------------------------txtDauMa_Leave------------------------"
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

#Region "------------------------FrmThietLapE2Di_KeyPress------------------------"
    Private Sub FrmThietLapE2Di_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case Else
        End Select
    End Sub
#End Region

#Region "------------------------Check Box------------------------"
#Region "------------------------chkIn_Despatch_Manifest_CheckedChanged------------------------"
    Private Sub chkIn_Despatch_Manifest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_Despatch_Manifest.CheckedChanged
        txtBan_DesManifest.Enabled = chkIn_Despatch_Manifest.Checked
    End Sub
#End Region

#Region "------------------------chkIn_Receptacle_Manifest_CheckedChanged------------------------"
    Private Sub chkIn_Receptacle_Manifest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_Receptacle_Manifest.CheckedChanged
        txtBan_RecManifest.Enabled = chkIn_Receptacle_Manifest.Checked
    End Sub
#End Region

#Region "------------------------chkIn_CN38_CheckedValueChanged------------------------"
    Private Sub chkIn_CN38_CheckedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_CN38.CheckedValueChanged
        txtBan_CN38.Enabled = chkIn_CN38.Checked
    End Sub
#End Region

#Region "------------------------chkIn_Receptacle_Manifest_CheckedValueChanged------------------------"
    Private Sub chkIn_Receptacle_Manifest_CheckedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_Receptacle_Manifest.CheckedValueChanged
        txtBan_RecManifest.Enabled = chkIn_Receptacle_Manifest.Checked
    End Sub
#End Region

#Region "------------------------chkTuiF_CheckedChanged------------------------"
    Private Sub chkTuiF_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTuiF.CheckedChanged
        chkIn_CN38.Enabled = chkTuiF.Checked
        chkIn_BV10.Enabled = chkTuiF.Checked
        chkIn_CN37.Enabled = chkTuiF.Checked

        chkIn_Despatch_Manifest.Enabled = chkTuiF.Checked
        If chkTuiF.Checked = False Then
            chkIn_CN38.Checked = False
            '  chkIn_CN35.Checked = False
            chkIn_BV10.Checked = False
            chkIn_CN37.Checked = False
            chkIn_Despatch_Manifest.Checked = False
        Else
            chkIn_CN38.Checked = True
            chkIn_CN35.Checked = True
            'chkIn_BV10.Checked = False
            chkIn_Despatch_Manifest.Checked = True
        End If
        If Trim(cbMaNuoc.Text) = "VN" Then
            If cbDuongBay.Value <> "" And Not cbDuongBay.Value Is Nothing Then
                chkIn_CN35.Text = "In CN35"
            Else
                chkIn_CN35.Text = "In E4"
            End If
            chkIn_Despatch_Manifest.Enabled = False
            chkIn_Despatch_Manifest.Checked = False
            chkIn_BV10.Enabled = False
            chkIn_BV10.Checked = False
        Else
            chkIn_CN35.Text = "In CN35"
        End If
    End Sub
#End Region

#Region "------------------------chkIn_BV10_CheckedValueChanged------------------------"
    Private Sub chkIn_BV10_CheckedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_BV10.CheckedValueChanged
        txtBan_BV10.Enabled = chkIn_BV10.Checked
    End Sub
#End Region

#Region "------------------------chkIn_CN37_CheckedValueChanged------------------------"
    Private Sub chkIn_CN37_CheckedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIn_CN37.CheckedValueChanged
        txtBan_CN37.Enabled = chkIn_CN37.Checked
    End Sub
#End Region
#End Region

#Region "------------------------Button------------------------"
#Region "------------------------btnMoTui_Click------------------------"
    Private Sub btnMoTui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoTui.Click
        Tong_So_BP_Tren_Luoi_E1 = 0
        Try
            If IsOpenBag = False Then
                MoTui()
            Else
                DongTui()
            End If
            If IsOpenBag = False Then
                myTongso = 0
                myTongKhoiLuongBP = 0
                'If chkInkhidongE2.Checked Then
                If Tong_So_BP_Tren_Luoi_E1 <> 0 And (chkIn_Receptacle_Manifest.Checked = True Or chkIn_CN35.Checked = True Or chkIn_CN38.Checked = True Or chkIn_Despatch_Manifest.Checked = True Or chkIn_BV10.Checked = True Or chkIn_CN37.Checked = True) Then
                    If MessageBox.Show("Bạn có muốn in ấn phẩm không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        'Open_Report(False, chkTuiF.Checked, chkIn_Despatch_Manifest.Checked, chkIn_CN35.Checked, chkIn_CN38.Checked, CInt(SetNullValue(txtBan_DesManifest.Text, "0")), IIf(txtBan_CN38.Text <> "", CInt(txtBan_CN38.Text), LSo_Ban_CN38), chkIn_Receptacle_Manifest.Checked, IIf(txtBan_RecManifest.Text <> "", CInt(SetNullValue(txtBan_RecManifest.Text, "0")), CInt(SetNullValue(txtBan_DesManifest.Text, "0"))), chkIn_BV10.Checked, IIf(txtBan_BV10.Text <> "", CInt(txtBan_BV10.Text), CInt(SetNullValue(txtBan_BV10.Text, "0"))), chkIn_CN37.Checked, IIf(txtBan_CN37.Text <> "", CInt(txtBan_CN37.Text), CInt(SetNullValue(txtBan_CN37.Text, "0"))), GId_Ca)
                        Open_Report(False, chkTuiF.Checked, chkIn_Despatch_Manifest.Checked, chkIn_CN35.Checked, chkIn_CN38.Checked, CInt(SetNullValue(txtBan_DesManifest.Text, "0")), CInt(SetNullValue(txtBan_CN38.Text, "0")), chkIn_Receptacle_Manifest.Checked, CInt(SetNullValue(txtBan_RecManifest.Text, "0")), chkIn_BV10.Checked, CInt(SetNullValue(txtBan_BV10.Text, "0")), chkIn_CN37.Checked, CInt(SetNullValue(txtBan_CN37.Text, "0")), GId_Ca)
                    End If
                End If
                chkTuiF.Checked = False
                chkIn_CN38.Checked = False
                'chkIn_Receptacle_Manifest.Checked = False
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#Region "------------------------Đóng Mở E2------------------------"
#Region "------------------------Mở Túi------------------------"
    Private Sub MoTui() 'Mở tờ E2
        Try
            'Thông tin nhập không đầy đủ     
            If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), IIf(cbDuongThuDi.Text = "", 0, CInt(cbDuongThuDi.Text)), IIf(cbChuyenThuDi.Text = "", 0, CInt(cbChuyenThuDi.Text)), IIf(cbTuiSoDi.Text = "", 0, CInt(cbTuiSoDi.Text)), Trim(cbLoai_Chuyen_Thu.Text), myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value), Trim(cbDuongBay.Text)) = False Then Exit Sub

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
            'Kiểm tra xem ngày đóng có lớn hơn ngày kế toán
            Dim NgaySanXuat As Integer = Convert.ToInt32(Mid(GId_Ca, 7, 8))
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
                'Tìm trong dữ liệu bảng CN38 có dữ liệu về chuyến bay thì lấy dữ liệu về chuyến bay, ngày bay ra
                Dim m_CN38 As New CN38(GConnectionString)
                Dim m_CN38_Chi_Tiet As New CN38_Chi_Tiet
                m_CN38_Chi_Tiet = m_CN38.Lay(myId_Chuyen_Thu)
                If m_CN38_Chi_Tiet.Id_Chuyen_Thu <> "" Then
                    'Tìm ngày bay
                    cbNgayBay.Value = myHam_Dung_Chung.ConvertIntToDate(m_CN38_Chi_Tiet.Ngay_Bay)
                    'Tìm đường bay
                    Dim m_Danh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
                    Dim m_Danh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
                    m_Danh_Muc_Duong_Bay_Chi_Tiet = m_Danh_Muc_Duong_Bay.Lay(m_CN38_Chi_Tiet.Id_Duong_Bay)
                    cbDuongBay.Value = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
                    cbDuongBay.Text = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
                End If

                myId_Chuyen_Thu = myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
                If myChuyen_Thu_Di_Chi_Tiet.Chot_Sl Then
                    If GUserAdmin = False Then 'Không phải là quyền quản trị
                        MessageBox.Show("Số liệu về chuyến thư này đã bị khóa, bạn không thể mở được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbChuyenThuDi.Focus()
                    Else 'Có quyền quản trị
                        If MessageBox.Show("Số liệu về chuyến thư này đã bị khóa!!!" & vbNewLine & "Bạn có muốn mở không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
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
                            Exit Sub
                        Else 'Nếu có quyền quản trị
                            If MessageBox.Show("Số liệu về bản kê E2 này đã bị khóa!!!" & vbNewLine & "Bạn có muốn mở không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
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
                        MessageBox.Show("Bản kê E2 này đang được người khác cập nhật!!!" & vbNewLine & "Bạn hãy chọn bản kê E2 khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cbTuiSoDi.Focus()
                        Exit Sub
                    End If
                    'Gán các thông số có trong chi tiết bản kê E2 được mở
                    chkTuiF.CheckedValue = myE2_Di_Chi_Tiet.Tui_F
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
                    'Lay thong tin to E2 trong bang den tamj kiem tra chua tung lay thi moi cho import
                    'Thong bao so luong Total_Item cho nguoi dung

                    'Gọi thủ tục import dữ liệu vào Ems_Int
                    Dim myOUT_Recptcl_EMC_Imported01 As New OUT_Recptcl_EMC_Imported(GConnectionString)
                    myOUT_Recptcl_EMC_Imported01.OUT_E1_Di_Tam_Insert_To_E1_Di_IPS(myId_Chuyen_Thu, myId_E2, myId_Ca, GPost_Office, Gid_Nguoi_Dung, txtMaSoTui.Text.Trim(), myE2_Date)
                    'Cap nhat da lay du lieu thanh cong
                    myOUT_Recptcl_EMC_Imported01.OUT_Recptcl_EMC_Imported_Cap_Nhat_Da_Xac_Nhan(myId_E2, cbNgayDong.Value, myE2_Date, cbDuongBay.Text, txtMaSoTui.Text.Trim(), cbNgayBay.Value, Ham_Dung_Chung.ConvertDateToInt(cbNgayBay.Value), myId_Ca, myId_Chuyen_Thu)
                End If

                'Lấy thông tin về CN38
                If myCN38.Danh_Sach_Lay_Boi_Chuyen_Thu_Di(myId_Chuyen_Thu).Tables(0).Rows.Count > 0 Then
                    cbDuongBay.Value = myCN38.Danh_Sach_Lay_Boi_Chuyen_Thu_Di(myId_Chuyen_Thu).Tables(0).Rows(0)("Id_Duong_Bay")
                End If
                'Cập nhật lại thông tin chuyến thư
                myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui = 0

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
                'Gọi thủ tục import dữ liệu vào Ems_Int
                Dim myOUT_Recptcl_EMC_Imported02 As New OUT_Recptcl_EMC_Imported(GConnectionString)
                myOUT_Recptcl_EMC_Imported02.OUT_E1_Di_Tam_Insert_To_E1_Di_IPS(myId_Chuyen_Thu, myId_E2, myId_Ca, GPost_Office, Gid_Nguoi_Dung, txtMaSoTui.Text.Trim(), myE2_Date)
                'Cap nhat lay du lieu thanh cong
                myOUT_Recptcl_EMC_Imported02.OUT_Recptcl_EMC_Imported_Cap_Nhat_Da_Xac_Nhan(myId_E2, cbNgayDong.Value, myE2_Date, cbDuongBay.Text, txtMaSoTui.Text.Trim(), cbNgayBay.Value, Ham_Dung_Chung.ConvertDateToInt(cbNgayBay.Value), myId_Ca, myId_Chuyen_Thu)

            End If

            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Phân loại đường thư lưu kho (quốc tế đến, quốc tế đi)
                'myId_Duong_Thu_Luu_Kho = myDuong_Thu_Di_Chi_Tiet.Ma_Bc.ToString("0000000") & myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac.ToString("0000000")
                myId_Duong_Thu_Luu_Kho = CreateId_Duong_Thu(myDuong_Thu_Di_Chi_Tiet.Ma_Bc, myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac)  'myDuong_Thu_Di_Chi_Tiet.Ma_Bc.ToString & myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac.ToString
                myId_Chuyen_Thu_Luu_Kho = CreateId_Chuyen_Thu(myId_Duong_Thu_Luu_Kho, mySo_Chuyen_Thu_Di, myE2_Date, myLoai_Chuyen_Thu)
                myId_E2_Luu_Kho = CreateId_E2(myId_Chuyen_Thu_Luu_Kho, myTui_So_Di)
            End If
            'Hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1(myId_E2)

            txtInfor.Text = "Tổng Số    : " & myTongso & vbNewLine & "Khối lượng : " & (myTongKhoiLuongBP / 1000) & "  KG"

            IsOpenBag = True
            Enable_Control(IsOpenBag)
            dgE1.Focus()
            myCell = dgE1.Rows(IIf(dgE1.Rows.Count > 0, dgE1.Rows.Count - 1, 0)).Cells("Ma_E1")
            dgE1.ActiveCell = myCell
            dgE1.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)

            'Lấy mã nước hiện tại
            myMa_Nuoc_Hien_Tai = myMa_Nuoc_Di
            myMaNuocTheoDuongThu = myMa_Nuoc_Hien_Tai
        Catch ex As Exception
            IsOpenBag = False
            MessageBox.Show("Có lỗi trong quá trình lấy dữ liệu từ IPS." & vbNewLine & "Bạn hãy khởi động lại chương trình và thực hiện lại chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Enable_Control(IsOpenBag)
            txtMaSoTui.Focus()
        End Try
    End Sub

#Region "Tạo Chuyến thư mới(Dựa vào Ngày, Đường Thư)"
    Private Sub AddNew_Chuyen_Thu_Di(ByVal Id_Duong_Thu As String, ByVal So_chuyen_thu As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        Id_Chuyen_Thu = CreateId_Chuyen_Thu(Id_Duong_Thu, So_chuyen_thu, Date_Create, Loai_Chuyen_Thu)
        myChuyen_Thu_Di.Cap_Nhat_Them(Id_Chuyen_Thu, Id_Duong_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, So_chuyen_thu, Date_Create, Time_Create, Date_Create, Time_Create, _
                                        0, 0, 0, 0, 0, 0, 0, 0, 0, False, False, False, 0, False)
        myId_Chuyen_Thu = Id_Chuyen_Thu
    End Sub
#End Region

#Region "Tạo bản kê E2 mới cho chuyến thư (Dựa vào Ngày,Giờ , Đường thư, Chuyến thư)"
    Private Sub AddNew_E2_Di(ByVal Id_Duong_Thu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Date_Create As Integer, ByVal Time_Create As Integer, ByVal Start_Date As Integer, ByVal End_Date As Integer, ByVal Loai_Chuyen_Thu As String, ByVal Id_Ca As String)
        Dim Id_Chuyen_Thu As String
        If myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu, Loai_Chuyen_Thu).Id_Chuyen_Thu = "" Then 'Nếu chưa tồn tại chuyến thư
            AddNew_Chuyen_Thu_Di(Id_Duong_Thu, So_Chuyen_Thu, Date_Create, Time_Create, Loai_Chuyen_Thu, Id_Ca)
        End If
        myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = myChuyen_Thu_Di.Tim_Id_Chuyen_Thu_Di(Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu)
        myId_E2 = CreateId_E2(myId_Chuyen_Thu, Tui_So)
        myE2_Di.Cap_Nhat_Them(myId_E2, Id_Duong_Thu, myId_Chuyen_Thu, Id_Ca, GBuu_Cuc_Khai_Thac, Date_Create, Time_Create, Date_Create, Time_Create, Tui_So, _
                                False, 0, 0, 0, 0, 0, 0, 0, 0, False, False, 0, False)
    End Sub
#End Region

#Region "------------------------DataGrid_Nhap_E1------------------------"
    Private Sub DataGrid_Nhap_E1(ByVal Id_E2 As String)
        dgE1.DataSource = myE1_Di.E1_Di_Lay_Boi_E2_Di_Le_Phi_HQ_KT(Id_E2)
        dgE1.DataBind()
        dgE1.Rows.Band.AddNew()
    End Sub
#End Region
#End Region

#Region "------------------------Đóng Túi------------------------"
    Private Sub DongTui() 'Đóng tờ E2
        Try
            'Tổng hợp E2 Đi từ E1 Đi
            Tong_Hop_E2_Di_tu_E1_Di(myId_E2)
            'Tổng hợp Chuyến thư đi từ E2 Đi
            Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(myId_Chuyen_Thu)
            'Cap nhat lai ma vach E4
            Cap_Nhat_E2_Da_In_Nhan_E4_Ma_Vach(myId_E2)
            '----------------------
            If chkTuiF.Checked = True Then 'Truyền dữ liệu khi đóng túi F
                'Predes(myId_Chuyen_Thu)
                Truyen_Du_Lieu_Khai_Thac()

                'Truyen du lieu tu Logitic -> Khai thac QT ------------------
                Dim mDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
                Dim mIp_Duong_Thu_Logitic As New Ip_Duong_Thu_Logitic(GConnectionString)
                Dim mIp_Duong_Thu_Logitic_Chi_Tiet As New Ip_Duong_Thu_Logitic_Chi_Tiet
                mDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(myId_Duong_Thu)
                mIp_Duong_Thu_Logitic_Chi_Tiet = mIp_Duong_Thu_Logitic.Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc_Ma_Bc_Dich(mDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, mDuong_Thu_Di_Chi_Tiet.Ma_Bc)
                If mIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich <> "" Then
                    Truyen_Du_Lieu_Logitic_Sang_Khai_Thac_Quoc_Te()
                End If
                '----------------------------------------------------------------
            End If

            'Truyền dữ liệu báo phát
            If (chk_Ngaynghi.Checked = True) Then
                Truyen_Bao_Phat()
            End If
            If (myChuyen_Thu_Di.Lay(myId_Chuyen_Thu).Dong_F) Then
                If (myKeys.Doc("CauHinhLapBC37") Is Nothing) Then
                    If (MessageBox.Show("Bạn có muốn lập BC37 khi đóng chuyến thư không?" & vbNewLine & "Chọn YES để đồng ý NO để lập sau" & vbNewLine & "Lựa chọn này của bạn sẽ được dùng làm cấu hình mặc định cho lần sau" & vbNewLine & "Bạn có thể vào thiết lập in BC37 để thay đổi lại cấu hình này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                        myKeys.Ghi("CauHinhLapBC37", "1")
                    Else
                        myKeys.Ghi("CauHinhLapBC37", "0")
                    End If
                End If
                If myKeys.Doc("CauHinhLapBC37") = "1" Then
                    'Tạo BC37 chuyến thư đi khi đóng túi F
                    Tao_BC37_Thiet_Lap_E2_Di(myId_Chuyen_Thu)
                End If
            End If
            'Bỏ hiển thị dữ liệu trên lưới
            DataGrid_Nhap_E1(0)

            'Sau khi đóng chuyến thư: enable tất cả các control
            IsOpenBag = False

            Enable_Control(IsOpenBag)
            cbMaNuoc.Focus()
            cbNgayDong.Value = Today

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "------------------------Tổng hợp E2_Di từ E1_Di------------------------"
    Private Sub Tong_Hop_E2_Di_tu_E1_Di(ByVal Id_E2 As String)
        'Lay_Chi_Tiet_E2_Di_tu_Id_E2(Id_E2)
        Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
        Dim myE2_Di_TH_E1_Di As New E2_Di_Chi_Tiet

        myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        myE2_Di_TH_E1_Di = myE2_Di.E2_Di_Tong_Hop_Tu_E1_Di_KT(myE2_Di_Chi_Tiet.Id_E2)
        'Kiểm tra xem nếu không có thông tin về E2 này thì phải tạo mới
        If myE2_Di_Chi_Tiet.Id_E2 <> Id_E2 Then 'Nếu không tồn tại
            AddNew_E2_Di(myId_Duong_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myE2_Date, myE2_Time, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu, myId_Ca)
            myE2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Id_E2_KT(Id_E2)
        End If

        myE2_Di_Chi_Tiet.Tong_So_BP = myE2_Di_TH_E1_Di.Tong_So_BP

        If myE2_Di_Chi_Tiet.Tong_So_BP > 0 Then 'Cập nhật lại thông tin trên E2 nếu tổng số BP>0
            'Gan vao bien nay de kiem tra khi dong tui co in AF hay khong
            Tong_So_BP_Tren_Luoi_E1 = myE2_Di_Chi_Tiet.Tong_So_BP

            myE2_Di_Chi_Tiet.Tui_F = CBool(chkTuiF.Checked)
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
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Lưu kho (quốc tế đến, quốc tế đi) thì tạo thêm túi số
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
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp, lưu kho hải quan
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
            'Gan vao bien nay de kiem tra khi dong tui co in ấn phẩm hay khong
            Tong_So_BP_Tren_Luoi_E1 = 0

            myE2_Di.Xoa(Id_E2)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Lưu kho thì xóa túi số
                myE2_Den_Tam.Xoa(myId_E2_Luu_Kho)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp-> xóa túi trong bảng đến tạm
                myE2_Den_Tam.Xoa(myE2_Di_Chi_Tiet.Id_E2)
            End If
        End If

        'Ghi Event: Đóng Tờ E2
        If myLog_Id <> 0 Then 'Nếu đã có sự kiện mở thì ghi sự kiện đóng
            Event_Viewer_Close_E2(myLog_Id, 2, Event_Viewer_Create_Chi_Tiet_E2(myE2_Di_Chi_Tiet.Id_Duong_Thu, myE2_Di_Chi_Tiet.Ngay_Dong, myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myE2_Di_Chi_Tiet.Tong_So_BP, myE2_Di_TH_E1_Di.Khoi_Luong_BP + CInt(Trim(txtTrongluongTui.Value))))
        End If
    End Sub
#End Region

#Region "------------------------Tổng hợp Chuyen_Thu_Di từ E2_Di------------------------"
    Private Sub Tong_Hop_Chuyen_Thu_Di_tu_E2_Di(ByVal Id_Chuyen_Thu As String)
        Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
        Dim myChuyen_Thu_Di_TH_tu_E2_Di As New Chuyen_Thu_Di_Chi_Tiet


        myChuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Id_Chuyen_Thu_KT(Id_Chuyen_Thu)
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
            myChuyen_Thu_Di.Chuyen_Thu_Di_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Ca, myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Di_Chi_Tiet.Dong_F, myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Lưu kho (quốc tế đến, quốc tế đi) thì tạo thêm chuyến thư
                myChuyen_Thu_Den_Tam.Chuyen_Thu_Den_Tam_Cap_Nhat_Them_KT(myId_Chuyen_Thu_Luu_Kho, myId_Duong_Thu_Luu_Kho, myChuyen_Thu_Di_Chi_Tiet.Id_Ca, myDuong_Thu_Di_Chi_Tiet.Ma_Bc, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Di_Chi_Tiet.Dong_F, myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp, kho hải quan
                myChuyen_Thu_Den_Tam.Chuyen_Thu_Den_Tam_Cap_Nhat_Them_KT(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.Id_Ca, myChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, myChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, myChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, myChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, myChuyen_Thu_Di_Chi_Tiet.Dong_F, myChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, myChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, myChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            End If
            'Lấy dữ liệu vào bản kê CN38
            myFlight_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value)
            If cbDuongBay.Rows.Count <> 0 Then 'Nếu không tồn tại đường bay
                myCN38.Cap_Nhat_Them(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myId_Duong_Bay, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myFlight_Date, myE2_Time)
            End If

            'If chkTuiF.Checked = True Then
            '    If Not cbDuongBay.Value Is Nothing Then
            '        'myId_Duong_Bay = myDanh_Muc_Duong_Bay.Danh_Muc_Duong_Bay_Lay_Boi_Duong_Thu_Di_So_Hieu(myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, cbDuongBay.Text).Tables(0).Rows(0)("Id_Duong_Bay")
            '        myFlight_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value)
            '        myCN38.Cap_Nhat_Them(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myId_Duong_Bay, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myFlight_Date, myE2_Time)
            '    End If
            'End If
            'myCN38.Cap_Nhat_Them(myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, myDanh_Muc_Duong_Bay_Chi_Tiet.Id_Duong_Bay, myChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, myChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, myChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, myChuyen_Thu_Di_Chi_Tiet.Gio_Dong, myChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, myChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, myChuyen_Thu_Di_Chi_Tiet.Tong_KL, myChuyen_Thu_Di_Chi_Tiet.Tong_KLBP)
        Else 'Nếu không tồn tại bản kê E2 nào -> Xóa chuyến thư
            myChuyen_Thu_Di.Xoa(Id_Chuyen_Thu)
            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Lưu kho (5:quốc tế đến, 7:quốc tế đi) thì xóa chuyến thư
                myChuyen_Thu_Den_Tam.Xoa(myId_Chuyen_Thu_Luu_Kho)
            ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp, kho hải quan
                myChuyen_Thu_Den_Tam.Xoa(Id_Chuyen_Thu)
            End If
            'Xóa dữ liệu trong bản kê CN38
            myCN38.Xoa(Id_Chuyen_Thu)
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

#Region "------------------------BtnTimE1_Click------------------------"
    Private Sub BtnTimE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTimE1.Click
        Dim Frm As New FrmTimKiemE1
        Frm.ShowDialog()
    End Sub
#End Region

#Region "------------------------btnPreview_Click------------------------"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            Open_Report(True, chkTuiF.Checked, chkIn_Despatch_Manifest.Checked, chkIn_CN35.Checked, chkIn_CN38.Checked, CInt(SetNullValue(txtBan_DesManifest.Text, "0")), CInt(SetNullValue(txtBan_CN38.Text, "0")), chkIn_Receptacle_Manifest.Checked, CInt(SetNullValue(txtBan_RecManifest.Text, "0")), chkIn_BV10.Checked, CInt(SetNullValue(txtBan_BV10.Text, "0")), chkIn_CN37.Checked, CInt(SetNullValue(txtBan_CN37.Text, "0")), GId_Ca)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "------------------------btnPrint_Click------------------------"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Open_Report(False, chkTuiF.Checked, chkIn_Despatch_Manifest.Checked, chkIn_CN35.Checked, chkIn_CN38.Checked, CInt(SetNullValue(txtBan_DesManifest.Text, "0")), CInt(SetNullValue(txtBan_CN38.Text, "0")), chkIn_Receptacle_Manifest.Checked, CInt(SetNullValue(txtBan_RecManifest.Text, "0")), chkIn_BV10.Checked, CInt(SetNullValue(txtBan_BV10.Text, "0")), chkIn_CN37.Checked, CInt(SetNullValue(txtBan_CN37.Text, "0")), GId_Ca)
    End Sub
#End Region

#Region "------------------------Open_Report------------------------"
    Private Sub Open_Report(ByVal Preview As Boolean, ByVal Tui_F As Boolean, ByVal In_DesManifest As Boolean, _
                            ByVal In_E4 As Boolean, ByVal In_Bc37 As Boolean, ByVal So_Ban_DesManifest As Integer, _
                            ByVal So_Ban_Bc37 As Integer, _
                            ByVal In_RecManifest As Boolean, ByVal So_Ban_RecManifest As Integer, _
                            ByVal In_BV10 As Boolean, ByVal So_Ban_BV10 As Integer, _
                            ByVal In_CN37 As Boolean, ByVal So_Ban_CN37 As Integer, _
                            ByVal Id_Ca As String)
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
        If In_Bc37 = False And In_BV10 = False And In_E4 = False And In_DesManifest = False And In_RecManifest = False And In_CN37 = False Then
            Exit Sub
        End If
        If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(cbDuongThuDi.Text), CInt(cbChuyenThuDi.Text), CInt(cbTuiSoDi.Text), Trim(cbLoai_Chuyen_Thu.Text), myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value), "Duong_Bay") = False Then Exit Sub 'Thông tin nhập không đầy đủ

        Ngay_Dong = myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
        Duong_Thu = CInt(cbDuongThuDi.Text)
        So_Chuyen_Thu = CInt(cbChuyenThuDi.Text)
        Tui_So = CInt(cbTuiSoDi.Text)
        Loai_Chuyen_Thu = Trim(cbLoai_Chuyen_Thu.Text)
        'Lấy thông tin về đường thư đi
        DataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, Duong_Thu)
        Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu = DataTable.Rows(0)("Id_Duong_Thu")
        Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai = DataTable.Rows(0)("Id_Phan_Loai")
        Select Case Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai
            Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                Start_Date = (Ngay_Dong \ 100) * 100
                End_Date = (Ngay_Dong \ 100) * 100 + 99
            Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
                Start_Date = (Ngay_Dong \ 10000) * 10000
                End_Date = (Ngay_Dong \ 10000) * 10000 + 9999
            Case Else
                MessageBox.Show("Không tồn tại phân loại đường thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select
        Dim IsNDD_EMS As Boolean 'Xác định đường thư là NDD
        IsNDD_EMS = IIf(Duong_Thu_Di_Chi_Tiet.Ma_Bc = 2160020 Or Duong_Thu_Di_Chi_Tiet.Ma_Bc = 2160010, True, False)

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

        '====================================================================
        If cbMaNuoc.Text = "VN" Then 'Duong Thu Di trong nuoc thi in ban ke E2, E4, BC37
            Dim myDanh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
            Dim myDanh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
            Dim myIsDuong_Bay As Integer 'Kiểm tra xem có đường bay không
            Dim myDataSet As New DataSet
            Dim mySo_Hieu As String
            Dim CN38 As New CN38(GConnectionString)
            Dim CN38_Chi_Tiet As New CN38_Chi_Tiet

            myDataSet = myDanh_Muc_Duong_Bay.Lay_Boi_Duong_Thu_Di_KT(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu)
            myIsDuong_Bay = myDataSet.Tables(0).Rows.Count
            If myIsDuong_Bay <> 0 Then mySo_Hieu = myDataSet.Tables(0).Rows(0).Item("So_Hieu")
            If myIsDuong_Bay <> 0 Then
                CN38_Chi_Tiet = CN38.Lay(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)
                If CN38_Chi_Tiet.Id_Duong_Bay = "" And In_BV10 = True Then
                    MessageBox.Show("Bạn chưa thể in bản kê BV10 được" & "Vì bạn chưa chọn chuyến bay cho chuyến thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            '-------------------------------------------------------------------
            If Preview Then 'Nếu nhấn Preview thì chỉ xem được 1 bản kê
                If Not In_Bc37 And Not In_E4 And Not In_BV10 And Not In_CN37 Then
                    If GIn_Kim_QT_Den = True Then
                        Dim myIn_E2_Text As New In_E2_TEXT
                        If GIn_Ban_Ke_E2_To_Text_Second = True Then ' In bản kê mới
                            myIn_E2_Text.Ban_Ke_E2_Di_To_Text_Second(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest) 'In E2   
                        Else 'Bản kê cũ
                            myIn_E2_Text.Ban_Ke_E2_Di_To_Text(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest) 'In E2   
                        End If
                    Else
                        Ban_Ke_E2_Di_KhaiThac(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest)
                    End If
                ElseIf In_Bc37 Then
                    If GIn_Kim_QT_Den Then
                        If GIn_Ban_Ke_BC37_To_Text_Second = True Then 'In bản kê mới
                            myIn_BC37_To_Text.WriteBC37TEXT_Second(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        Else
                            myIn_BC37_To_Text.WriteBC37TEXT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        End If
                    Else
                        'BC_37report(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        Dim myBC37_ID As String
                        Dim myQLTGND_BC37_Di As New QLTGND_BC37_DI(GConnectionString)
                        myBC37_ID = myQLTGND_BC37_Di.Lay_Id_Bc37_Theo_Ngay_Id_Duong_Thu_So_Chuyen_Thu(Chuyen_Thu_Di_Chi_Tiet.Ngay_Dong, Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, Chuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu)
                        Ban_Ke_BC37_Di_Tong_Hop(myBC37_ID, Preview, So_Ban_Bc37)
                    End If
                ElseIf In_E4 Then
                    If myIsDuong_Bay = 0 Then 'Không có thông tin về chuyến bay
                        If GKieu_In_E4_New Then
                            In_Nhan_E4_New(E2_Di_Chi_Tiet.Id_E2, Preview, "Ems_E4")
                        Else
                            WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1) 'In CN35
                        End If
                    Else 'Có Thông tin về đường bay
                        WriteCN35TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1, IsNDD_EMS) 'In E4
                    End If
                ElseIf In_BV10 Then 'In bản kê BV10
                    If myIsDuong_Bay <> 0 Then 'có thông tin về chuyến bay
                        If GIn_Kim_BV10_Trong_Nuoc = True Then
                            'Lấy thông tin đường bay
                            If GIn_Ban_Ke_BV10_To_Text_Second = True Then 'In bản kê mới
                                myIn_BV10_To_Text.WriteBV10TEXT_Second(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            Else
                                myIn_BV10_To_Text.WriteBV10TEXT(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            End If
                        Else
                            Ban_Ke_BV10_Trong_Nuoc(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                        End If
                    End If
                End If
            Else 'Nếu nhấn Print: in tất cả các bản kê được chọn
                '-------------------------------------------------------------------
                If In_RecManifest Then
                    If GIn_Kim_QT_Den = True Then
                        Dim myIn_E2_Text As New In_E2_TEXT
                        If GIn_Ban_Ke_E2_To_Text_Second = True Then ' In bản kê mới
                            myIn_E2_Text.Ban_Ke_E2_Di_To_Text_Second(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest) 'In E2   
                        Else 'Bản kê cũ
                            myIn_E2_Text.Ban_Ke_E2_Di_To_Text(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest) 'In E2   
                        End If
                    Else
                        Ban_Ke_E2_Di_KhaiThac(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest) 'In E2   
                    End If
                End If
                'In E4
                If In_E4 Then
                    If myIsDuong_Bay = 0 Then 'Không có thông tin về chuyến bay
                        If GKieu_In_E4_New Then
                            In_Nhan_E4_New(E2_Di_Chi_Tiet.Id_E2, Preview, "Ems_E4")
                        Else
                            WriteE4TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1) 'In CN35
                        End If
                    Else 'Có Thông tin về đường bay
                        WriteCN35TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1, IsNDD_EMS)
                    End If
                End If
                'In Bc37
                If In_Bc37 Then
                    If GIn_Kim_QT_Den Then
                        If GIn_Ban_Ke_BC37_To_Text_Second = True Then 'In bản kê mới
                            myIn_BC37_To_Text.WriteBC37TEXT_Second(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        Else
                            myIn_BC37_To_Text.WriteBC37TEXT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                        End If
                    Else
                        Dim myBC37_ID As String
                        Dim myQLTGND_BC37_Di As New QLTGND_BC37_DI(GConnectionString)
                        myBC37_ID = myQLTGND_BC37_Di.Lay_Id_Bc37_Theo_Ngay_Id_Duong_Thu_So_Chuyen_Thu(Chuyen_Thu_Di_Chi_Tiet.Ngay_Dong, Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, Chuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu)
                        Ban_Ke_BC37_Di_Tong_Hop(myBC37_ID, Preview, So_Ban_Bc37)
                        'BC_37report(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37)
                    End If
                End If
                'In bản kê BV10
                If In_BV10 Then
                    If myIsDuong_Bay <> 0 Then 'có thông tin về chuyến bay
                        Dim GIn_Kim_BV10_QT_Di As Boolean
                        If GIn_Kim_BV10_Trong_Nuoc = True Then 'Bản kê BV10 Laser
                            If GIn_Ban_Ke_BV10_To_Text_Second = True Then 'In bản kê mới
                                myIn_BV10_To_Text.WriteBV10TEXT_Second(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            Else
                                myIn_BV10_To_Text.WriteBV10TEXT(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            End If
                        Else 'Bản kê BV10 In Laser
                            Ban_Ke_BV10_Trong_Nuoc(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                        End If
                    End If
                End If
            End If
        Else 'Duong Thu Di quoc te thi in ban ke Manifest, CN35, CN38
            '====================================================================
            Dim myDanh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
            Dim myDanh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
            Dim myIsDuong_Bay As Integer 'Kiểm tra xem có đường bay không
            Dim myDataSet As New DataSet
            Dim mySo_Hieu As String
            Dim CN38 As New CN38(GConnectionString)
            Dim CN38_Chi_Tiet As New CN38_Chi_Tiet

            myDataSet = myDanh_Muc_Duong_Bay.Lay_Boi_Duong_Thu_Di_KT(Chuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu)
            myIsDuong_Bay = myDataSet.Tables(0).Rows.Count
            'If myIsDuong_Bay <> 0 Then mySo_Hieu = myDataSet.Tables(0).Rows(0).Item("So_Hieu")
            If myIsDuong_Bay <> 0 Then
                CN38_Chi_Tiet = CN38.Lay(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)
                Dim idx As Integer
                For idx = 0 To myDataSet.Tables(0).Rows.Count - 1
                    If myDataSet.Tables(0).Rows(idx).Item("id_Duong_Bay") = CN38_Chi_Tiet.Id_Duong_Bay Then
                        mySo_Hieu = myDataSet.Tables(0).Rows(idx).Item("So_Hieu")
                    End If
                Next
                If CN38_Chi_Tiet.Id_Duong_Bay = "" And In_BV10 = True Then
                    MessageBox.Show("Bạn chưa thể in bản kê BV10 được" & "Vì bạn chưa chọn chuyến bay cho chuyến thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If

            'Kiểm tra thông tin về CN38: nếu chưa có thì thông báo phải chọn để in số hiệu chuyến bay
            'Dim CN38 As New CN38(GConnectionString)
            'Dim CN38_Chi_Tiet As New CN38_Chi_Tiet
            CN38_Chi_Tiet = CN38.Lay(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)
            If CN38_Chi_Tiet.Id_Duong_Bay = "" Then
                MessageBox.Show("Bạn chưa thể in bản kê được." & " Vì bạn chưa chọn chuyến bay cho chuyến thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            '-------------------------------------------------------------------
            If Preview Then 'Nếu nhấn Preview thì chỉ xem được 1 bản kê
                If Not In_Bc37 And Not In_E4 And Not In_DesManifest And Not In_BV10 And Not In_CN37 Then
                    'Ban_Ke_E2_Di(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest, 1)
                    Ban_Ke_E2_Di_Receptacle(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest, 1, IsNDD_EMS)
                ElseIf In_Bc37 Then
                    Ban_Ke_CN38(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37, IsNDD_EMS) 'In CN38
                ElseIf In_CN37 Then
                    Ban_Ke_CN37(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_CN37)  'In CN37
                ElseIf In_E4 Then
                    WriteCN35TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1, IsNDD_EMS)
                ElseIf In_DesManifest Then
                    Ban_Ke_E2_Di_Despatch(E2_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_DesManifest, IsNDD_EMS)
                ElseIf In_BV10 Then 'In_BV10
                    If myIsDuong_Bay <> 0 Then 'có thông tin về chuyến bay
                        If GIn_Kim_BV10_QT_Di = True Then
                            'Lấy thông tin đường bay
                            myIn_BV10_To_Text.WriteBV10TEXT(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            If GIn_Ban_Ke_HQ_Buu_Dien Then
                                If MessageBox.Show("Bạn có muốn xem bản kê hải quan bưu điện", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    'In bản kê hải quan bưu điện
                                    Ban_Ke_Bao_Cao_Hai_Quan(Id_Ca, Preview)
                                End If
                            End If
                        Else
                            Ban_Ke_BV10_QT_Di(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                        End If
                    End If
                End If
            Else 'Nếu nhấn Print: in tất cả các bản kê được chọn
                '-------------------------------------------------------------------
                If In_RecManifest Then
                    Ban_Ke_E2_Di_Receptacle(E2_Di_Chi_Tiet.Id_E2, Preview, So_Ban_RecManifest, 1, IsNDD_EMS) 'In E2   
                End If
                'In E4
                If In_E4 Then
                    WriteCN35TEXT(E2_Di_Chi_Tiet.Id_E2, Preview, 1, IsNDD_EMS)
                End If
                'In Bc37
                If In_Bc37 Then
                    Ban_Ke_CN38(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_Bc37, IsNDD_EMS) 'In CN38
                    'Chay thu Predes
                    'Predes(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu)
                End If
                If In_DesManifest Then
                    Ban_Ke_E2_Di_Despatch(E2_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_DesManifest, IsNDD_EMS)
                End If
                If In_BV10 Then
                    If myIsDuong_Bay <> 0 Then 'có thông tin về chuyến bay
                        If GIn_Kim_BV10_QT_Di = True Then
                            'Lấy thông tin đường bay
                            myIn_BV10_To_Text.WriteBV10TEXT(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                            'In bản kê hải quan bưu điện
                            If GIn_Ban_Ke_HQ_Buu_Dien Then
                                Ban_Ke_Bao_Cao_Hai_Quan(Id_Ca, Preview)
                            End If
                        Else
                            Ban_Ke_BV10_QT_Di(CN38_Chi_Tiet.Ngay_Bay, CN38_Chi_Tiet.Ngay_Dong, mySo_Hieu, CN38_Chi_Tiet.Id_Chuyen_Thu, CN38_Chi_Tiet.Id_Duong_Thu, Preview, So_Ban_BV10)
                        End If
                    End If
                End If
                If In_CN37 Then
                    Ban_Ke_CN37(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Preview, So_Ban_CN37) 'In CN38
                End If
            End If
        End If
    End Sub
#End Region

#Region "------------------------BtnExit_Click------------------------"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "-----------------------btn_Export_To_Excel_Click-----------------------"
    Private Sub btn_Export_To_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export_To_Excel.Click
        Try
            'Export to excel Despatch Manifest
            If cbMaNuoc.Text = "VN" Then
                MessageBox.Show("Không thể lấy bản kê Despatch Manifest với đường thư trong nước!!!", "Thông Báo", MessageBoxButtons.OK)
                Exit Sub
            End If

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

            If IsCorrectInfor(myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(cbDuongThuDi.Text), CInt(cbChuyenThuDi.Text), CInt(cbTuiSoDi.Text), Trim(cbLoai_Chuyen_Thu.Text), myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value), "Duong_Bay") = False Then Exit Sub 'Thông tin nhập không đầy đủ

            Ngay_Dong = myHam_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
            Duong_Thu = CInt(cbDuongThuDi.Text)
            So_Chuyen_Thu = CInt(cbChuyenThuDi.Text)
            Tui_So = CInt(cbTuiSoDi.Text)
            Loai_Chuyen_Thu = Trim(cbLoai_Chuyen_Thu.Text)
            'Lấy thông tin về đường thư đi
            DataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, Duong_Thu)
            Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu = DataTable.Rows(0)("Id_Duong_Thu")
            Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai = DataTable.Rows(0)("Id_Phan_Loai")
            Select Case Duong_Thu_Di_Chi_Tiet.Id_Phan_Loai
                Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                    Start_Date = (Ngay_Dong \ 100) * 100
                    End_Date = (Ngay_Dong \ 100) * 100 + 99
                Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê: Chuyến Thư tăng theo Năm
                    Start_Date = (Ngay_Dong \ 10000) * 10000
                    End_Date = (Ngay_Dong \ 10000) * 10000 + 9999
                Case Else
                    MessageBox.Show("Không tồn tại phân loại đường thư này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select
            Dim IsNDD_EMS As Boolean 'Xác định đường thư là NDD
            IsNDD_EMS = IIf(Duong_Thu_Di_Chi_Tiet.Ma_Bc = 2160020 Or Duong_Thu_Di_Chi_Tiet.Ma_Bc = 2160010, True, False)

            'Lấy thông tin về chuyến thư đi
            'Kiểm tra xem chuyến thư đấy có tồn tại không, Nếu không tồn tại thì báo lỗi
            Dim Chuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Chuyen_Thu_Di_Chi_Tiet = myChuyen_Thu_Di.Chuyen_Thu_Di_Chi_Tiet_Lay_Boi_Duong_Thu_Di_Ngay_So_Chuyen_Thu_Loai_Chuyen_Thu_KT(Duong_Thu_Di_Chi_Tiet.Id_Duong_Thu, Start_Date, End_Date, So_Chuyen_Thu, Loai_Chuyen_Thu)
            If Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu = "" Then Exit Sub

            'Lấy thông tin về bản kê E2
            'Nếu tồn tại bản kê E2 thì tiếp tục và lấy Id_E2, nếu không tồn tại thì báo lỗi
            Dim E2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
            E2_Di_Chi_Tiet = myE2_Di.E2_Di_Chi_Tiet_Lay_Boi_Chuyen_Thu_Di_Tui_So_KT(Chuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, Tui_So)

            Dim m_Dataset As New DataSet
            m_Dataset = myChuyen_Thu_Di.Chuyen_Thu_Di_Export_To_Excel(E2_Di_Chi_Tiet.Id_Chuyen_Thu)

            If m_Dataset.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu về chuyến thư này!!!", "Thông Báo", MessageBoxButtons.OK)
                Exit Sub
            End If
            Dim m_Path As String
            Dim m_File As String
            Dim Ma_Nuoc As String
            Dim IPMC As String
            m_Path = "C:\EMS_INTERNATIONAL\Despatch_Manifest\"
            If Not Directory.Exists(m_Path) Then
                Directory.CreateDirectory(m_Path)
            End If

            Ma_Nuoc = myDanh_Muc_Bc.Lay(Duong_Thu).Ma_Nc
            IPMC = myDanh_Muc_Bc.Lay(Duong_Thu).IPMC

            m_File = Ma_Nuoc & "_" & IPMC & "_" & Ngay_Dong.ToString & "_" & Loai_Chuyen_Thu & "_" & So_Chuyen_Thu & "_" & Tui_So & ".xls"

            If File.Exists(m_Path & m_File) Then
                If MessageBox.Show("Chuyến thư này đã được tạo dữ liệu" & vbNewLine & "  Bạn có muốn xóa đi để tạo lại không???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                File.Delete(m_Path & m_File)
            End If

            Export_Despatch_Manifest_To_Excel(m_Dataset, m_Path & m_File)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Export_Despatch_Manifest_To_Excel(ByVal mDataSet As DataSet, ByVal mFilePath As String)
        'Extracting from database
        Dim col, row As Integer

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MsgBox("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", MsgBoxStyle.Critical)
            Return
        End If

        'Export to Excel process
        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    .cells(1, i).value = mDataSet.Tables(0).Columns(col).ColumnName
                    .cells(1, i).EntireRow.Font.Bold = True
                    i += 1
                Next
                i = 2
                Dim k As Integer = 1
                For col = 0 To mDataSet.Tables(0).Columns.Count - 1
                    i = 2
                    For row = 0 To mDataSet.Tables(0).Rows.Count - 1
                        .Cells(i, k).Value = mDataSet.Tables(0).Rows(row).ItemArray(col)
                        i += 1
                    Next
                    k += 1
                Next
                .ActiveCell.Worksheet.SaveAs(mFilePath)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            MsgBox("Dữ liệu đã được xuất ra thành công trong file", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' The excel is created and opened for insert value. We most close this excel using this system
        Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each i As Process In pro
            i.Kill()
        Next
    End Sub
#End Region
#End Region

#Region "------------------------Commbo Box------------------------"
#Region "Combo_KeyDown"
    Private Sub Combo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) _
                Handles cbNgayDong.KeyDown, cbDuongThuDi.KeyDown, cbChuyenThuDi.KeyDown, cbTuiSoDi.KeyDown, _
                        cbMaNuoc.KeyDown, cbLoai_Chuyen_Thu.KeyDown, cbNgayBay.KeyDown, cbDuongBay.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#Region "Ngày Đóng"
    Private Sub cbNgayDong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.AfterExitEditMode
        Lay_TT_Ngay_E2()
        cbNgayBay.DateTime = cbNgayDong.DateTime
        Lay_TT_Ngay_Bay()
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date)
    End Sub
#End Region

#Region "Mã Nước"
#Region "cbMaNuoc_Validated"
    Private Sub cbMaNuoc_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMaNuoc.Validated
        myMa_Nuoc_Di = cbMaNuoc.Value
        Me.cbDuongThuDi.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Nuoc_KT(GBuu_Cuc_Khai_Thac, IIf(myMa_Nuoc_Di = "", "VN", myMa_Nuoc_Di))
        If cbDuongThuDi.Rows.Count > 0 Then
            If myMa_Nuoc_Hien_Tai <> myMa_Nuoc_Di Then
                cbDuongThuDi.Value = cbDuongThuDi.Rows(0).Cells("Ma_Bc").Value
            End If
        Else
            MessageBox.Show("Không tồn tại đường thư nào thuộc nước này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbMaNuoc.Focus()
            Exit Sub
        End If
        cbDuongThuDi.DataBind()
        cbDuongThuDi.LimitToList = True

        If cbMaNuoc.Text = "VN" Then
            cbLoai_Chuyen_Thu.Text = "EN"
            cbLoai_Chuyen_Thu.Enabled = False
            'Thiết Lập In
            chkIn_CN38.Text = "In BC37"
            chkIn_CN35.Text = "In E4"
            chkIn_Receptacle_Manifest.Text = "In E2"
        Else
            cbLoai_Chuyen_Thu.Enabled = True
            chkIn_CN38.Text = "In CN38"
            chkIn_CN35.Text = "In CN35"
            chkIn_Receptacle_Manifest.Text = "In Receptacle Manifest"
        End If
        If cbMaNuoc.Value = "VN" Then
            chkIn_CN35.Enabled = True
            chkIn_CN38.Enabled = True
        End If
    End Sub
#End Region
#End Region

#Region "Đường Thư"
#Region "cbDuongThuDi_Validated"
    Private Sub cbDuongThuDi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuDi.Validated
        If IsNumeric(cbDuongThuDi.Text) = False And cbDuongThuDi.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbDuongThuDi.Focus()
            Exit Sub
        End If
        Lay_TT_Duong_Thu()
        Lay_TT_Ngay_Thang(myE2_Date)
        If cbDuongThuDi.Text <> "" Then 'Lấy danh mục đường bay
            cbDuongBay.DataSource = myDanh_Muc_Duong_Bay.Lay_Boi_Duong_Thu_Di_KT(myId_Duong_Thu)
            If cbDuongBay.Rows.Count > 0 Then
                cbDuongBay.Enabled = True
                cbNgayBay.Enabled = True
                cbDuongBay.Value = cbDuongBay.Rows(0).Cells("So_Hieu").Value
                cbDuongBay.Text = cbDuongBay.Rows(0).Cells("So_Hieu").Value
                myId_Duong_Bay = cbDuongBay.Rows(0).Cells("Id_Duong_Bay").Value
            Else
                cbDuongBay.Enabled = False
                cbNgayBay.Enabled = False
                cbDuongBay.Text = ""
            End If
            'Me.cbDuongBay.LimitToList = True
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")"
        'Lấy mã nước hiện tại
        myMa_Nuoc_Hien_Tai = myMa_Nuoc_Di
        'them
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        'Khoi Tao cbCHUYENTHUDI
        cbChuyenThuDi.Text = ""
        cbChuyenThuDi.LimitToList = False
        '-----------------
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
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False And isQuaNgay = False Then  'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDi.Value = mySo_Chuyen_Thu_Di_Lon_Nhat
                Else
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                cbChuyenThuDi.Text = 1
            End If
        End If

        'Kiểm tra check ngày nghỉ
        '--------------------------------------
        'Thêm phần kiểm tra thêm thông tin của đường thư đi: Nước đến, Tỉnh đến
        myMa_Nuoc_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Nc
        myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(myDuong_Thu_Di_Chi_Tiet.Ma_Bc).Ma_Tinh
    End Sub
#End Region
#End Region

#Region "Loại Chuyến Thư"
#Region "cbLoai_Chuyen_Thu_Validated"
    Private Sub cbLoai_Chuyen_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoai_Chuyen_Thu.Validated
        myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
        'Khoi Tao cbCHUYENTHUDI
        cbChuyenThuDi.Text = ""
        cbChuyenThuDi.LimitToList = False
        '-----------------
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
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False And isQuaNgay = False Then  'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDi.Value = mySo_Chuyen_Thu_Di_Lon_Nhat
                Else
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                End If
            End If
        Else
            If (cbChuyenThuDi.Text = "") Or (cbChuyenThuDi.Text = "0") Then
                cbChuyenThuDi.Text = 1
            End If
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text
    End Sub
#End Region
#End Region

#Region "Chuyến Thư"
#Region "cbChuyenThuDi_BeforeDropDown"
    Private Sub cbChuyenThuDi_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbChuyenThuDi.BeforeDropDown
        If cbDuongThuDi.Text <> "" Then
            cbChuyenThuDi.Text = ""
            mySo_Chuyen_Thu_Di_Lon_Nhat = myChuyen_Thu_Di.Tim_So_Chuyen_Thu_Di_Lon_Nhat(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
            'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
            cbChuyenThuDi.DataSource = myChuyen_Thu_Di.Chuyen_Thu_Di_Lay_Boi_Duong_Thu_Di_Ngay_Loai_Chuyen_Thu_KT(myId_Duong_Thu, myStart_Date, myEnd_Date, myLoai_Chuyen_Thu)
            If mySo_Chuyen_Thu_Di_Lon_Nhat > 0 Then
                If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_Lon_Nhat, myLoai_Chuyen_Thu) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat
                Else
                    cbChuyenThuDi.Text = mySo_Chuyen_Thu_Di_Lon_Nhat + 1
                End If
            Else
                cbChuyenThuDi.Text = 1
            End If
            'DanhsachChuyenThu(myId_Duong_Thu, myStart_Date, myEnd_Date)
        End If
    End Sub
#End Region

#Region "cbChuyenThuDi_Validated"
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
            If myChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu <> "" Then 'Nếu tồn tại chuyến thư
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
                'Tìm trong dữ liệu bảng CN38 có dữ liệu về chuyến bay thì lấy dữ liệu về chuyến bay, ngày bay ra
                Dim m_CN38 As New CN38(GConnectionString)
                Dim m_CN38_Chi_Tiet As New CN38_Chi_Tiet
                m_CN38_Chi_Tiet = m_CN38.Lay(myId_Chuyen_Thu)
                If m_CN38_Chi_Tiet.Id_Duong_Bay <> "" Then
                    cbNgayBay.Value = myHam_Dung_Chung.ConvertIntToDate(m_CN38_Chi_Tiet.Ngay_Bay)
                    'Tìm đường bay
                    Dim m_Danh_Muc_Duong_Bay As New Danh_Muc_Duong_Bay(GConnectionString)
                    Dim m_Danh_Muc_Duong_Bay_Chi_Tiet As New Danh_Muc_Duong_Bay_Chi_Tiet
                    m_Danh_Muc_Duong_Bay_Chi_Tiet = m_Danh_Muc_Duong_Bay.Lay(m_CN38_Chi_Tiet.Id_Duong_Bay)
                    cbDuongBay.Value = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
                    cbDuongBay.Text = m_Danh_Muc_Duong_Bay_Chi_Tiet.So_hieu
                End If
            Else
                cbTuiSoDi.DataSource = myE2_Di.E2_Di_Lay_Boi_Chuyen_Thu_Di_KT(0)
                cbTuiSoDi.Text = 1
            End If
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) & vbNewLine _
                            & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                            & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "-Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di)
    End Sub
#End Region
#End Region

#Region "Túi Số"
#Region "cbTuiSoDi_BeforeDropDown"
    Private Sub cbTuiSoDi_BeforeDropDown(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbTuiSoDi.BeforeDropDown
        If cbTuiSoDi.Text <> "" Then
            Lay_TT_Chuyen_Thu()
            cbTuiSoDi.Text = ""
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

#Region "cbTuiSoDi_Validated"
    Private Sub cbTuiSoDi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTuiSoDi.Validated
        If IsNumeric(cbTuiSoDi.Text) = False And cbTuiSoDi.Text <> "" Then
            MessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbTuiSoDi.Focus()
            Exit Sub
        Else
            Lay_TT_E2()
        End If
        Me.txtThongTin.Text = "Ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myE2_Date) _
                            & vbNewLine & "Đường Thư:" & CStr(myDuong_Thu_Di_Chi_Tiet.Ma_Bc) & " (" & myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & ")" & vbNewLine _
                            & "Loại chuyến thư:" & cbLoai_Chuyen_Thu.Text & "-Chuyến Thư:" & CStr(mySo_Chuyen_Thu_Di) & " - Túi Số: " & myTui_So_Di
    End Sub
#End Region
#End Region

#Region "Ngày Bay"
    Private Sub cbNgayBay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayBay.AfterExitEditMode
        Lay_TT_Ngay_Bay()
    End Sub
#End Region

#Region "Đường Bay"
#Region "cbDuongBay_Validated"
    Private Sub cbDuongBay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongBay.Validated
        'Lấy thông tin chi tiết về đường bay
        If cbDuongBay.Text <> "" Then
            If Not cbDuongBay.ActiveRow Is Nothing Then
                myId_Duong_Bay = cbDuongBay.ActiveRow.Cells("Id_Duong_Bay").Value
            End If
        Else
            If cbDuongBay.Rows.Count <> 0 Then
                MessageBox.Show("Bạn chưa chọn chuyến bay nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If Trim(cbMaNuoc.Text) = "VN" And cbDuongBay.Text = "" Then
            chkIn_CN35.Text = "In E4"
        Else
            chkIn_CN35.Text = "In CN35"
        End If
    End Sub
#End Region
#End Region
#End Region

#Region "------------------------Lấy Thông Số------------------------"
#Region "------------------------LayThongSo------------------------"
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
                Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê,Lưu kho: Chuyến Thư tăng theo Năm
                    myStart_Date = (myE2_Date \ 10000) * 10000
                    myEnd_Date = (myE2_Date \ 10000) * 10000 + 9999
                Case Else
                    MessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                    Exit Function
            End Select

            'Lấy thông tin loại chuyến thư
            If cbLoai_Chuyen_Thu.Text = "" Then
                myLoai_Chuyen_Thu = ""
                Return False
                Exit Function
            Else
                myLoai_Chuyen_Thu = cbLoai_Chuyen_Thu.Text
            End If

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

            'Lấy thông tin ngày bay
            myFlight_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value)

            'Lấy thông tin đường bay
            If cbDuongBay.Rows.Count > 0 Then
                If cbDuongBay.Text = "" Then
                    myId_Duong_Bay = ""
                    Return False
                    Exit Function
                Else
                    myId_Duong_Bay = cbDuongBay.ActiveRow.Cells("Id_Duong_Bay").Value
                End If
            Else
                myId_Duong_Bay = ""
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
        myE2_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        myE2_Time = myHam_Dung_Chung.ConvertTimeToInt(Now)
    End Sub
#End Region

#Region "Lay_TT_Ngay_Bay"
    Private Sub Lay_TT_Ngay_Bay()
        myFlight_Date = myHam_Dung_Chung.ConvertDateToInt(Me.cbNgayBay.Value)
    End Sub
#End Region

#Region "Lay_TT_Duong_Thu"
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

#Region "Lay_TT_Ngay_Thang"
    Private Sub Lay_TT_Ngay_Thang(ByVal E2_Date As Integer)
        If E2_Date <> 0 Then
            Select Case myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai
                Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                    myStart_Date = (E2_Date \ 100) * 100
                    myEnd_Date = (E2_Date \ 100) * 100 + 99
                Case 2, 3, 4, 5, 6, 7, 8 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê, Lưu kho (5:quốc tế đến, 7:quốc tế đi), Chuyển tiếp giữa các tổ: Chuyến Thư tăng theo Năm
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

#Region "Lay_TT_Chuyen_Thu"
    Private Sub Lay_TT_Chuyen_Thu()
        If cbChuyenThuDi.Text = "" Then
            mySo_Chuyen_Thu_Di = 0
        Else
            mySo_Chuyen_Thu_Di = CInt(cbChuyenThuDi.Text)
        End If
    End Sub
#End Region

#Region "Lay_TT_E2"
    Private Sub Lay_TT_E2()
        Lay_TT_Chuyen_Thu()
        If cbTuiSoDi.Text = "" Then
            myTui_So_Di = 0
        Else
            myTui_So_Di = CInt(cbTuiSoDi.Text)
        End If
    End Sub
#End Region

#Region "Kiểm tra thông tin"
    Private Function IsCorrectInfor(Optional ByVal Ngay_Dong As Integer = 0, Optional ByVal Duong_Thu As Integer = 0, Optional ByVal So_Chuyen_Thu As Integer = 0, Optional ByVal Tui_So As Integer = 0, Optional ByVal Loai_Chuyen_Thu As String = "", Optional ByVal Ngay_Bay As Integer = 0, Optional ByVal Chuyen_Bay As String = "") As Boolean
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
        'Kiểm tra thông tin về loại chuyến thư
        If Loai_Chuyen_Thu = "" Then
            MessageBox.Show("Thông tin về loại chuyến thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbLoai_Chuyen_Thu.Focus()
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
        If cbDuongBay.Rows.Count > 0 Then
            'Kiểm tra thông tin về ngày bay
            If Ngay_Bay = 0 Then
                MessageBox.Show("Ngày đóng bay chưa được xác định, xin mời nhập thông tin về ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbNgayBay.Focus()
                Return False
                Exit Function
            End If
            'Kiểm tra thông tin về Chuyến bay
            If Chuyen_Bay = "" Then
                MessageBox.Show("Thông tin về chuyến bay không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbDuongBay.Focus()
                Return False
                Exit Function
            End If
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

#Region "------------------------Thêm dòng mới------------------------"
    Private Sub AddNewRow(ByVal sender As Object)
        myGridKeyDown = sender
        If Not myGridKeyDown.ActiveCell Is Nothing Then
            If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                If myGridKeyDown.ActiveCell.Column.Key = myLastColumnKey Then
                    myGridKeyDown.Rows.Band.AddNew()
                End If
            End If
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "------------------------Xóa dòng------------------------"
    Private Sub Delete_E1(ByVal sender As Object, ByVal ActiveRowIndex As Integer) ', ByVal Khoi_Luong_BP As Integer)
        myGridKeyDown = sender
        Dim myRowIndex As Integer
        myRowIndex = myGridKeyDown.ActiveRow.Index
        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text.Length <> 0 Then
            If MessageBox.Show("Bạn có thực sự muốn xóa mã E1 trong bản kê E2 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Ghi Event: Xóa E1
                Event_Viewer_Delete_E1(2, Event_Viewer_Create_Chi_Tiet_E1(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_Duong_Thu").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Ngay_Dong").Text), myLoai_Chuyen_Thu, mySo_Chuyen_Thu_Di, myTui_So_Di, myGridKeyDown.Rows(ActiveRowIndex).Cells("Ma_E1").Text, CInt(myGridKeyDown.Rows(ActiveRowIndex).Cells("Khoi_Luong").Text), myGridKeyDown.Rows(ActiveRowIndex).Cells("Phan_Loai").Text), "")

                myE1_Di.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                myE1_Le_Phi_Di.E1_Le_Phi_Di_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                'Xoa trong du lieu Paypost
                myE1_COD_Tam.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
                '----------------------------
                If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Nếu là đường thư lưu kho (5:quốc tế đến, 7:quốc tế đi)
                    'Tính lại Id_E1, Id_Duong_Thu,Id_E2,Id_Chuyen_Thu
                    myId_E1_Luu_Kho = CreateId_E1(myGridKeyDown.Rows(ActiveRowIndex).Cells("Ma_E1").Text, myId_E2_Luu_Kho, myGridKeyDown.Rows(ActiveRowIndex).Cells("Kien_So").Text) 'Tạo Id E1 mới
                    myE1_Den_Tam.Xoa(myId_E1_Luu_Kho)
                ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Chuyển tiếp,kho hải quan
                    myE1_Den_Tam.Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E1").Text)
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

#Region "------------------------ReCalculate_Summary------------------------"
    Private Sub ReCalculate_Summary(ByVal Sender As Object)
        myGridKeyDown = Sender
        Dim i As Integer
        Dim Tong_so As Integer
        Dim Tong_Khoi_Luong As Integer
        Dim Tong_Cuoc As Long
        Tong_so = 0
        Tong_Khoi_Luong = 0
        Tong_Cuoc = 0
        For i = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(i).Cells("Ma_E1").Text <> "" Then
                Tong_so += 1
                Tong_Khoi_Luong += CInt(myGridKeyDown.Rows(i).Cells("Khoi_Luong").Text)
                Tong_Cuoc += CInt(myGridKeyDown.Rows(i).Cells("Cuoc_E1").Text)
            End If
        Next
        txtInfor.Text = "Tổng Số    : " & Tong_so & vbNewLine & _
                        "Khối lượng : " & (Tong_Khoi_Luong / 1000) & "  KG" & vbNewLine & _
                        "Cước       : " & Tong_Cuoc
    End Sub
#End Region

#Region "------------------------dgE1_InitializeLayout------------------------"
    Private Sub dgE1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1.InitializeLayout
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
            .Columns("Nuoc_Nhan").Hidden = True
            .Columns("Nuoc_Nhan").DefaultCellValue = "VN"
            'Nuoc_Tra
            .Columns("Nuoc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Nuoc_Tra").ValueList = ddMa_Nuoc
            .Columns("Nuoc_Tra").Hidden = False
            .Columns("Nuoc_Tra").DefaultCellValue = myMa_Nuoc_Di

            'Ma_Bc_Goc
            .Columns("Ma_Bc_Goc").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Goc").ValueList = ddMa_BC
            Select Case myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
                Case 3 'Liên tỉnh liền kề
                    .Columns("Ma_Bc_Goc").DefaultCellValue = myDuong_Thu_Di_Chi_Tiet.Ma_Bc
                Case Else
                    .Columns("Ma_Bc_Goc").DefaultCellValue = 100000
            End Select
            'Ma_Bc_Tra
            .Columns("Ma_Bc_Tra").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_Tra").ValueList = ddMa_BC_Tra
            .Columns("Ma_Bc_Tra").Hidden = True
            .Columns("Ma_Bc_Tra").DefaultCellValue = 0
            'Ma_Bc_CH
            .Columns("Ma_Bc_CH").Style = ColumnStyle.DropDownValidate
            .Columns("Ma_Bc_CH").ValueList = ddMa_BC_Tra 'Tính theo mã tỉnh
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
            End Select

            'Loai
            .Columns("Loai").Style = ColumnStyle.DropDownValidate
            .Columns("Loai").ValueList = ddLoai_BP
            .Columns("Loai").Hidden = False
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
            .Columns("Truyen_Doi_Soat").Header.Caption = "Đã thu thuế"
            .Columns("Truyen_Doi_Soat").Style = ColumnStyle.CheckBox
            .Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
        End With
    End Sub
#End Region

#Region "------------------------dgE1_InitializeTemplateAddRow------------------------"
    Private Sub dgE1_InitializeTemplateAddRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgE1.InitializeTemplateAddRow
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
            .Columns("Id_Trang_Thai").DefaultCellValue = 0
            .Columns("Kien_So").DefaultCellValue = 0
            'Lệ phí hải quan
            .Columns("Le_Phi_HQ").DefaultCellValue = 0
            .Columns("Thue_NK").DefaultCellValue = 0
            .Columns("Thue_VAT").DefaultCellValue = 0
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
            .Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
        End With
    End Sub
#End Region

#Region "------------------------dgE1_AfterCellActivate------------------------"
    Private Sub dgE1_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1.AfterCellActivate
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

#Region "------------------------dgE1_KeyDown------------------------"
    Private Sub dgE1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1.KeyDown
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
                Case Keys.Enter
                    If myGridKeyDown.ActiveCell.Column.Key = myLastColumnKey Then
                        AddNewRow(sender)
                    End If
                    Keys_Enter(sender, e)
                    'Sang cột tiếp theo

                Case Keys.Tab
                    If myGridKeyDown.ActiveCell.Column.Key = myLastColumnKey Then
                        AddNewRow(sender)
                    End If
                    Keys_Enter(sender, e)
                    Exit Sub
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
                        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "" Then
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

#Region "------------------------Kiểm tra sự kiện Keys_Enter------------------------"
    Private Sub Keys_Enter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        myGridKeyDown = sender
        Select Case myGridKeyDown.ActiveCell.Column.Key
            Case "Ma_Bc_Goc"
                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                Else
                    myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Value = "VN"
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                End If
                myGridKeyDown.ActiveRow.Cells("Ma_E1").Value = Tim_MAE1_Tu_Nuoc_Nhan(myGridKeyDown.ActiveRow.Cells("Ma_E1").Text.Trim, myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text.Trim)
                If Trim(myGridKeyDown.ActiveCell.Text).Length > 8 Then 'Kiểm tra độ dài
                    CMessageBox.Show("Dữ liệu nhập không đúng định dạng !!! " & vbNewLine & "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub
                End If
            Case "Nuoc_Nhan"
                If myGridKeyDown.ActiveCell.Text = "VN" Then
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                    e.Handled = False
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = True
                    Exit Sub
                Else
                    myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = True
                End If
            Case "Ma_Bc_Tra"
                'Kiểm tra lạc hướng
                If LacHuong() = True Then 'Lạc hướng
                    MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    myCell = myGridKeyDown.ActiveCell
                    myCell.SelStart = 0
                    myCell.SelLength = myCell.Text.Length
                    Exit Sub
                End If

                If myGridKeyDown.ActiveCell.Text = "0" Then 'Hàng quốc tế
                    myGridKeyDown.ActiveCell.Value = 0
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("PostCode").Hidden = False
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("PostCode").Hidden = True
                    myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Value = "VN"
                    myGridKeyDown.ActiveRow.Cells("PostCode").Value = ""
                End If
            Case "Nuoc_Tra"
                'Kiểm tra lạc hướng
                If LacHuong() = True Then 'Lạc hướng
                    MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    myCell = myGridKeyDown.ActiveCell
                    myCell.SelStart = 0
                    myCell.SelLength = myCell.Text.Length
                    Exit Sub
                End If
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
                    myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Value = 0
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
                If (myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "") And _
                            (myGridKeyDown.ActiveRow.Cells("Id_E1").Text = _
                                CreateId_E1(myGridKeyDown.ActiveRow.Cells("Ma_E1").Text, _
                                            myGridKeyDown.ActiveRow.Cells("Id_E2").Text, _
                                            myGridKeyDown.ActiveRow.Cells("Kien_So").Text)) Then
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
                MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Text, myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
                If (myHam_Dung_Chung.Check_E1(MAE1) = False) Then
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
                myIsChuyenHoan = False
                myIsNhapChuyenHoan = False
                'Kiểm tra điều kiện trùng trong lưới: chưa kiểm tra điều kiện với trường hợp là hàng 1 vận đơn

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

                myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveRow.Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong ca khai thác
                    myIsTrungSoLieu = True
                    If MessageBox.Show("Số hiệu E1 này đã được đóng đi trong ca khai thác này!!!" & vbNewLine & _
                                            "        Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        myIsChoPhepTrung = False
                        myIsDaKiemTraTrung = False
                        GoTo StopHere
                    Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                        'Kiểm tra chuyển hoàn, Kiểm tra lạc hướng
                        If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then   'Lạc hướng
                            MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            myIsDaKiemTraTrung = False
                            myIsChoPhepTrung = False
                            GoTo StopHere
                        End If
                        myIsDaKiemTraTrung = True
                        myIsChoPhepTrung = True
                        Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
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
                                    myIsXacNhanDen = False
                                    myIsDaKiemTraTrung = True 'Cho phép qua
                                    'Kiểm tra trùng trong khoảng thời gian
                                    myE1_Di_Chi_Tiet = Nothing
                                    myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                    If myE1_Di_Chi_Tiet.Id_E1 <> "" Then 'Nếu trùng dữ liệu
                                        If MessageBox.Show("Trùng dữ liệu,bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            myIsDaKiemTraTrung = False
                                            GoTo StopHere
                                        Else 'Lấy dữ liệu trùng vào biến
                                            'Kiểm tra lạc hướng
                                            If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                myIsDaKiemTraTrung = False
                                                myIsChoPhepTrung = False
                                                GoTo StopHere
                                            End If
                                            myIsDaKiemTraTrung = True
                                            myIsTrungSoLieu = True
                                            myIsChoPhepTrung = True
                                            Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
                                        End If
                                    Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                        myIsTrungSoLieu = False
                                        myIsDaKiemTraTrung = True
                                    End If
                                End If
                            Else
                                MessageBox.Show("Dữ liệu chưa được xác nhận đến trong ca này!!!" & vbNewLine _
                                                & "Bạn hãy xác nhận đến trước khi đóng đi.", "Thông báo", MessageBoxButtons.OK)
                                myIsDaKiemTraTrung = False 'Không cho phép qua, phải tiếp tục kiểm tra
                                GoTo StopHere
                            End If
                        Else 'Lưu kho hải quan
                            'Nếu muốn tiếp tục -> kiểm tra dữ liệu xác nhận đến trong các ngày trước đó
                            myE1_Den_Chi_Tiet = Nothing
                            myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                            If myE1_Den_Chi_Tiet.Id_E1 = "" Then 'Ko có giá trị xác nhận đến trong các ca trước
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
                                        'Kiểm Tra chuyển hoàn, Kiểm tra lạc hướng
                                        If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                            MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            myIsDaKiemTraTrung = False
                                            myIsChoPhepTrung = False
                                            GoTo StopHere
                                        End If
                                        myIsDaKiemTraTrung = True
                                        myIsTrungSoLieu = True
                                        myIsChoPhepTrung = True
                                        Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
                                    End If
                                Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                    myIsTrungSoLieu = False
                                    myIsDaKiemTraTrung = False
                                End If
                            Else
                                'Lấy dữ liệu xác nhận đến trong các ca trước
                                'Kiểm tra lạc hướng
                                If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    myIsDaKiemTraTrung = False
                                    myIsChoPhepTrung = False
                                    GoTo StopHere
                                End If
                                myIsXacNhanDen = True
                                myIsDaKiemTraTrung = True
                                Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet, myIsNhapChuyenHoan)
                            End If
                        End If
                    Else 'Có dữ liệu xác nhận đến-> lấy dữ liệu xác nhận đến trong ca
                        'Kiểm tra lạc hướng
                        If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                            MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            myIsDaKiemTraTrung = False
                            myIsChoPhepTrung = False
                            GoTo StopHere
                        End If
                        myIsDaKiemTraTrung = True
                        myIsXacNhanDen = True
                        'Lấy dữ liệu xác nhận đến vào biến
                        Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet, myIsNhapChuyenHoan)
                    End If
                End If
                'Kiểm tra lạc hướng
                'Kiểm tra chuyển hoàn

                'Nhảy xuống dòng tiếp theo
                myMAE1Thoat = True
                e.Handled = False
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                If myIsTrungSoLieu = True Or myIsXacNhanDen = True Then
                    If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                    If myGridKeyDown.DisplayLayout.Bands(0).Columns("Truyen_Doi_Soat").Hidden = False Then
                        'Nếu nhập trang thai thu thue
                        SetLastColumnVisibleKey(sender)
                        myCell = myGridKeyDown.ActiveRow.Cells("Truyen_Doi_Soat")
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        Exit Sub
                    End If
                    If myIsChuyenHoan = True And myIsNhapChuyenHoan = True Then
                        'Nếu nhập thông tin chuyển hoàn
                        SetLastColumnVisibleKey(sender)
                        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = False
                        myCell = myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH")
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1")
                    End If
                    myGridKeyDown.ActiveCell = myCell
                    myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                Else 'Nhảy sang cột tiếp theo
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
        If e.KeyValue = Keys.Enter Then
            If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 And myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" Then
                AddNewRow(sender)
            End If
            e.Handled = True
            myGridKeyDown.PerformAction(EnterEditMode, False, False)
            myGridKeyDown.PerformAction(NextCellByTab, False, True)
        End If
    End Sub
#End Region

#Region "------------------------dgE1_BeforeCellDeactivate------------------------"
    Private Sub dgE1_BeforeCellDeactivate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1.BeforeCellDeactivate
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
                    MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Text, myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
                    If (myHam_Dung_Chung.Check_E1(MAE1) = False) Then
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
                        If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveRow.Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong bản kê E2
                            MessageBox.Show("Trùng dữ liệu trong cùng chuyến thư, bạn không được phép nhập tiếp", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            Exit Sub
                        End If

                        'Kiểm tra trùng trong cùng 1 ca làm việc của bưu cục khai thác đó -> có thể trùng
                        myE1_Di_Chi_Tiet = Nothing
                        myE1_Di_Chi_Tiet = myE1_Di.E1_Di_Kiem_Tra_Trung_MA_E1_Id_Ca_KT(MAE1, myId_Ca)
                        If (myE1_Di_Chi_Tiet.Id_E1 <> "") And (myE1_Di_Chi_Tiet.Id_E1 <> myGridKeyDown.ActiveRow.Cells("Id_E1").Text) Then 'Nếu có dữ liệu trùng trong ca khai thác
                            myIsTrungSoLieu = True
                            If MessageBox.Show("Số hiệu E1 này đã được đóng đi trong ca khai thác này!!!" & vbNewLine & _
                                                    "        Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                e.Cancel = True
                                myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                myIsChoPhepTrung = False
                                Exit Sub
                            Else 'Nếu cho phép trùng thì gán biến cho phép trùng, cho phép nhảy sang ô tiếp theo
                                'Kiểm tra lạc hướng
                                If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    If MessageBox.Show("    Bưu phẩm lạc hướng!!!" & vbNewLine & _
                                                        "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                        myIsChoPhepTrung = False
                                        e.Cancel = True
                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                        Exit Sub
                                    End If
                                End If
                                myIsChoPhepTrung = True
                                Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
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
                                            myIsChoPhepTrung = False
                                            myIsXacNhanDen = False
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
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
                                                    If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                        MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                        myIsDaKiemTraTrung = False
                                                        myIsChoPhepTrung = False
                                                        e.Cancel = True
                                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                        Exit Sub
                                                    End If
                                                    myIsDaKiemTraTrung = True
                                                    myIsTrungSoLieu = True
                                                    myIsChoPhepTrung = True
                                                    Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
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
                                        myIsChoPhepTrung = False
                                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                        Exit Sub
                                    End If
                                Else 'Lưu kho hải quan
                                    'Nếu muốn tiếp tục -> kiểm tra dữ liệu xác nhận đến trong các ngày trước đó
                                    myE1_Den_Chi_Tiet = Nothing
                                    myE1_Den_Chi_Tiet = myE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Ma_Bc_Khai_Thac(MAE1, myHam_Dung_Chung.MinusIntDate(myE2_Date, GSo_Ngay_E1_Duoc_Trung), myE2_Date, GBuu_Cuc_Khai_Thac)
                                    If myE1_Den_Chi_Tiet.Id_E1 = "" Then
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
                                                If LacHuong(myE1_Di_Chi_Tiet.Nuoc_Tra, myE1_Di_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                                    MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    myIsDaKiemTraTrung = False
                                                    myIsChoPhepTrung = False
                                                    e.Cancel = True
                                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                                    Exit Sub
                                                End If
                                                myIsDaKiemTraTrung = True
                                                myIsTrungSoLieu = True
                                                myIsChoPhepTrung = True
                                                Gan_Gia_Tri_Trung_Vao_Bien(myE1_Di_Chi_Tiet, myIsNhapChuyenHoan) 'Gán giá trị trùng vào biến
                                            End If
                                        Else 'Nếu không trùng dữ liệu trong 1 khoảng thời gian
                                            myIsTrungSoLieu = False
                                            myIsDaKiemTraTrung = False
                                        End If
                                    Else
                                        'Lấy dữ liệu xác nhận đến trong các ca trước
                                        'Kiểm tra lạc hướng
                                        If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                            MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            myIsDaKiemTraTrung = False
                                            myIsChoPhepTrung = False
                                            e.Cancel = True
                                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                            Exit Sub
                                        End If
                                        myIsXacNhanDen = True
                                        Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet, myIsNhapChuyenHoan)
                                    End If
                                End If
                            Else 'Có dữ liệu xác nhận đến-> lấy dữ liệu xác nhận đến trong ca
                                'Kiểm tra lạc hướng
                                If LacHuong(myE1_Den_Chi_Tiet.Nuoc_Tra, myE1_Den_Chi_Tiet.Ma_Bc_Tra) = True Then  'Lạc hướng
                                    MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    myIsDaKiemTraTrung = False
                                    myIsChoPhepTrung = False
                                    e.Cancel = True
                                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    Exit Sub
                                    'If MessageBox.Show("    Bưu phẩm lạc hướng!!!" & vbNewLine & _
                                    '                    "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                    '    myIsDaKiemTraTrung = False
                                    '    myIsXacNhanDen = False
                                    '    e.Cancel = True
                                    '    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                                    '    Exit Sub
                                    'End If
                                End If
                                myIsXacNhanDen = True
                                Gan_Gia_Tri_Xac_Nhan_Vao_Bien(myE1_Den_Chi_Tiet, myIsNhapChuyenHoan)
                            End If
                        End If
                    End If
                Case "Ma_Bc_Tra"
                    'Kiểm tra lạc hướng
                    If LacHuong(myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                         myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text) = True Then 'Lạc hướng
                        MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc " & " danh mục hướng chuyển đi" & "đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                Case "Nuoc_Tra"
                    'Kiểm tra lạc hướng
                    If LacHuong(myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                         myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text) = True Then 'Lạc hướng
                        MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc danh mục hướng chuyển đi đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        e.Cancel = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Exit Sub
                    End If
                Case "Khoi_Luong"
                    If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" Then
                        If myGridKeyDown.ActiveCell.Text = "" Then
                            MessageBox.Show("Chưa nhập khối lượng bưu phẩm", "Thông báo", MessageBoxButtons.OK)
                            e.Cancel = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        ElseIf IsNumeric(myGridKeyDown.ActiveCell.Text) = False Then 'Kiểm tra định dạng
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

#Region "------------------------Kiểm tra lạc hướng, Kiểm tra chuyển hoàn------------------------"
    'Kiểm tra bưu gửi chuyển hoàn
    'Kiểm tra bưu phẩm lạc hướng
    'Nếu Mã nước theo đường thư là quốc tế: Kiểm tra nước trả
    'Nếu Mã nước theo đường thư là VN: Kiểm tra mã tỉnh theo đường thư với Mã bưu cục trả
    Private Function Kiem_Tra_Lac_Huong1(ByVal sender As Object, ByVal Nuoc_Tra As String, ByVal Ma_Bc_Tra As Integer, ByVal Nuoc_Nhan As String, ByVal Ma_Bc_Nhan As Integer) As Boolean
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" Then 'Chỉ kiểm tra điều kiện trong lần đầu tiên
                Return False
                Exit Function
            End If
            If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then 'Chỉ kiểm tra điều kiện trong lần đầu tiên
                Return False
                Exit Function
            End If

            'Kiểm tra trường hợp chuyển tiếp bưu phẩm lạc hướng quốc tế
            If Nuoc_Tra.ToUpper <> "VN" And Nuoc_Nhan.ToUpper <> "VN" And Nuoc_Tra.ToUpper <> Nuoc_Nhan.ToUpper Then 'Kiểm tra trường hợp chuyển tiếp bưu phẩm lạc hướng
                Return False
            End If

            'Kiểm tra chuyển hoàn trước
            If myMa_Nuoc_Theo_Duong_Thu.ToUpper = "VN" Then 'Đường thư trong nước
                myIsChuyenHoan = False 'Không phải là chuyển hoàn
            Else
                'Chỉ kiểm tra đối với đường thư là quốc tế
                If Nuoc_Nhan <> "VN" Then 'Chuyển hoàn
                    myIsChuyenHoan = True
                Else 'Không chuyển hoàn
                    myIsChuyenHoan = False
                End If
            End If

            If myIsChuyenHoan = True Then
                Select Case MessageBox.Show("       Đây có thể là bưu gửi chuyển hoàn!!!" & vbNewLine & _
                                            "Chọn Yes nếu xác định bưu gửi chuyển hoàn và nhập Chuyển Hoàn" & vbNewLine & _
                                            "Chọn No nếu xác định bưu gửi không phải là chuyển hoàn." & vbNewLine, _
                                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case DialogResult.Yes 'Nhập Thông tin chuyển hoàn
                        myIsNhapChuyenHoan = True
                    Case DialogResult.No 'Không nhập thông tin chuyển hoàn
                        myIsNhapChuyenHoan = False
                End Select
            End If

            'Sau đó kiểm tra thông tin lạc hướng
            If (myIsChuyenHoan = False) Or (myIsChuyenHoan = True And myIsNhapChuyenHoan = False) Then
                'Nếu không phải là chuyển hoàn -> kiểm tra lạc hướng bình thường
                'Nếu là chuyển hoàn nhưng không lấy thông tin
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
            Else 'Chuyển hoàn
                'Nếu nhập thông tin chuyển hoàn -> kiểm tra lạc hướng theo thông tin chuyển hoàn
                If myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = False Then 'Kiểm tra lạc hướng nếu đường thư không phải là chuyển tiếp
                    'Kiểm tra thông tin đường thư: nước đến, tỉnh đến
                    'Kiểm tra lạc hướng với các đường thư trong nước
                    If myMa_Nuoc_Theo_Duong_Thu.ToUpper = "VN" Then
                        'Kiểm tra lạc hướng theo từng mã tỉnh
                        If myMa_Tinh_Theo_Duong_Thu = myDanh_Muc_Bc.Lay(Ma_Bc_Nhan).Ma_Tinh Then
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
            End If
        Catch ex As Exception
            myIsChuyenHoan = False
            myIsNhapChuyenHoan = False
            Return False
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    ''' Kiem tra buu pham lac huong theo danh muc huong chuyen
    Private Function LacHuong(Optional ByVal Nuoc_Tra As String = "", _
                                Optional ByVal Ma_Bc_Tra As Integer = 0) As Boolean

        ' kiem tra duong thu den 
        ' neu la kho kiem hoa, hay kho hai quan thi khong kiem tra lac huong
        Dim _Id_Duong_Thu As String
        Dim DuongThuDi As New Duong_Thu_Di(GConnectionString)
        Dim DuongThuDiChiTiet As Duong_Thu_Di_Chi_Tiet
        _Id_Duong_Thu = myId_Duong_Thu
        DuongThuDiChiTiet = DuongThuDi.Lay(_Id_Duong_Thu)
        If DuongThuDiChiTiet.Id_Phan_Loai > 4 Then
            Exit Function
        End If

        Dim mIsLacHuong As Boolean = False
        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" Then
            ' Kiem tra viec thay doi nuoc tra va buu cuc tra
            Dim mId_E1_Cu As String
            Dim mNuoc_Tra_Moi As String
            Dim mMa_Bc_Tra_Moi As Integer
            mId_E1_Cu = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
            Dim mE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
            mE1_Di_Chi_Tiet = myE1_Di.Lay(mId_E1_Cu)
            mNuoc_Tra_Moi = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text
            mMa_Bc_Tra_Moi = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)
            If (mNuoc_Tra_Moi = mE1_Di_Chi_Tiet.Nuoc_Tra) And (mMa_Bc_Tra_Moi = mE1_Di_Chi_Tiet.Ma_Bc_Tra) Then
                Return False
            End If
        End If

        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
            Return False
        End If
        If myChoPhepLacHuong Then
            Return False
        End If
        ' Lay thong tin de kiem tra
        Dim _Nuoc_Tra As String
        Dim _Ma_Bc_Tra As Integer
        If Nuoc_Tra = "" Then
            _Nuoc_Tra = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text
            _Ma_Bc_Tra = CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)
        Else
            _Nuoc_Tra = Nuoc_Tra
            _Ma_Bc_Tra = Ma_Bc_Tra
        End If

        ' Lay ma nuoc
        ' Kiem tra ma tinh nhan
        Dim mDanh_Muc_Huong_Di As New Danh_Muc_Huong_Di(GConnectionString)

        ' Kiem tra dieu kien ve duong thu trong nuoc, quoc te trong danh muc huong den
        Dim mKiemTraMaNuoc As Boolean = False
        Dim mKiemTraMaTinh As Boolean = False
        If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Danh_Sach_Ma_Nuoc_Lay_Boi_ID_Duong_Thu(myId_Duong_Thu).Tables(0).Rows.Count > 0 Then
            mKiemTraMaNuoc = True
        End If

        If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Danh_Sach_Ma_Tinh_Lay_Boi_ID_Duong_Thu(myId_Duong_Thu).Tables(0).Rows.Count > 0 Then
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
            _Ma_Nuoc = _Nuoc_Tra

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                Return False ' Đúng hướng
            End If

            ' Kiem tra ma tinh
            _Ma_Tinh = myDanh_Muc_Bc.Lay(_Ma_Bc_Tra).Ma_Tinh
            _Ma_Nuoc = "VN"

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        ElseIf mKiemTraMaTinh Then ' Kiem tra ma tinh
            _Ma_Tinh = myDanh_Muc_Bc.Lay(_Ma_Bc_Tra).Ma_Tinh
            _Ma_Nuoc = "VN"

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        Else ' Kiem tra ma nuoc
            _Ma_Tinh = 0
            _Ma_Nuoc = _Nuoc_Tra

            _Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
            If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
                mIsLacHuong = False
            Else
                mIsLacHuong = True
            End If
        End If

        Return mIsLacHuong




        '' Lay ma Tinh
        'Dim _Ma_Tinh As Integer
        'Dim _Ma_Nuoc As String
        'If myMaNuocTheoDuongThu.ToUpper = "VN" Then
        '    _Ma_Tinh = myDanh_Muc_Bc.Lay(_Ma_Bc_Tra).Ma_Tinh
        '    _Ma_Nuoc = "VN"
        'Else
        '    _Ma_Tinh = 0
        '    _Ma_Nuoc = _Nuoc_Tra
        'End If

        '' Kiem tra trong danh muc huong
        'Dim _Id_Huong_Chuyen As String
        '_Id_Huong_Chuyen = CreateIdHuongChuyen(myId_Duong_Thu, _Ma_Nuoc, _Ma_Tinh)
        'If mDanh_Muc_Huong_Di.Danh_Muc_Huong_Di_Lay(_Id_Huong_Chuyen).Dung_Huong = True Then
        '    Return False
        'Else
        '    Return True
        'End If
    End Function
#End Region

#Region "------------------------Gán giá trị trùng vào biến------------------------"
    Private Function Gan_Gia_Tri_Trung_Vao_Bien(ByVal m_E1_Di_Chi_Tiet As E1_Di_Chi_Tiet, ByVal IsNhapChuyenHoan As Boolean) As Boolean
        Try
            If m_E1_Di_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Di_Chi_Tiet_Trung 'Lấy giá trị chi tiết vào biến
                    .Id_E1 = m_E1_Di_Chi_Tiet.Id_E1
                    .Ngay_Phat_Hanh = m_E1_Di_Chi_Tiet.Ngay_Phat_Hanh
                    .Gio_Phat_Hanh = m_E1_Di_Chi_Tiet.Gio_Phat_Hanh
                    .Ma_Bc_Goc = m_E1_Di_Chi_Tiet.Ma_Bc_Goc
                    .Ma_Don_Vi = m_E1_Di_Chi_Tiet.Ma_Don_Vi
                    .Nuoc_Nhan = m_E1_Di_Chi_Tiet.Nuoc_Nhan
                    If IsNhapChuyenHoan = True Then 'Nhập thông tin chuyển hoàn
                        .Ma_Bc_Tra = m_E1_Di_Chi_Tiet.Ma_Bc_Goc
                        .Nuoc_Tra = m_E1_Di_Chi_Tiet.Nuoc_Nhan
                        .Ma_Bc_CH = m_E1_Di_Chi_Tiet.Ma_Bc_Tra
                    Else 'Không nhập chuyển hoàn
                        .Ma_Bc_Tra = m_E1_Di_Chi_Tiet.Ma_Bc_Tra
                        .Nuoc_Tra = m_E1_Di_Chi_Tiet.Nuoc_Tra
                        .Ma_Bc_CH = m_E1_Di_Chi_Tiet.Ma_Bc_CH
                    End If
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

#Region "------------------------Gán giá trị xác nhận đến vào biến------------------------"
    Private Function Gan_Gia_Tri_Xac_Nhan_Vao_Bien(ByVal m_E1_Den_Chi_Tiet As E1_Den_Chi_Tiet, ByVal IsNhapChuyenHoan As Boolean) As Boolean
        Try
            If m_E1_Den_Chi_Tiet.Id_E1 <> "" Then
                With myE1_Den_Chi_Tiet_XN_Trung 'Lấy giá trị xác nhận đến chi tiết vào biến
                    .Id_E1 = m_E1_Den_Chi_Tiet.Id_E1
                    .Ngay_Phat_Hanh = m_E1_Den_Chi_Tiet.Ngay_Phat_Hanh
                    .Gio_Phat_Hanh = m_E1_Den_Chi_Tiet.Gio_Phat_Hanh
                    .Ma_Bc_Goc = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                    .Ma_Don_Vi = m_E1_Den_Chi_Tiet.Ma_Don_Vi
                    .Nuoc_Nhan = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                    If IsNhapChuyenHoan = True Then 'Nhập thông tin chuyển hoàn
                        .Ma_Bc_Tra = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                        .Nuoc_Tra = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                        .Ma_Bc_CH = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                    Else 'Không nhập chuyển hoàn
                        .Ma_Bc_Tra = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                        .Nuoc_Tra = m_E1_Den_Chi_Tiet.Nuoc_Tra
                        .Ma_Bc_CH = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                    End If
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

#Region "------------------------dgE1_AfterExitEditMode------------------------"
    Private Sub dgE1_AfterExitEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgE1.AfterExitEditMode
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
                            Me.Update_Cuoc(sender)
                        End If
                        MAE1 = GetCorrectMAE1(myGridKeyDown.ActiveCell.Value, myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text)
                        myGridKeyDown.ActiveCell.Value = MAE1

                        If myIsXacNhanDen Then 'Nếu đã xác nhận đến
                            Gan_Gia_Tri_Xac_Nhan_Den_Vao_Luoi(sender, myE1_Den_Chi_Tiet_XN_Trung)
                        Else 'Nếu chưa xác nhận đến
                            If myIsTrungSoLieu = True And myIsChoPhepTrung = True Then
                                Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi()
                            End If
                        End If
Thoat:
                        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "" Then
                            If myIsXacNhanDen Then
                                myGridKeyDown.Rows.Band.AddNew()
                            End If
                            'addNewRow(sender)
                        End If
                        'Phan_Loai_EMS_EMSTT(sender, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)
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
                            'Tim Ma_Tinh_Tra
                            'Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                            'myGridKeyDown.ActiveRow.Cells("Ma_Tinh_Tra").Value = myDanh_Muc_Bc.Lay(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text).Ma_Tinh
                        End If
                        'Phan_Loai_EMS_EMSTT(sender, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text, myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text)
                        Update_Cuoc(sender)
                    Case "Nuoc_Tra"
                        If myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text <> "VN" Then
                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Value = "0"
                            'myGridKeyDown.ActiveRow.Cells("Ma_Tinh_Tra").Value = 0
                        End If
                        If (myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text) _
                              And (myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text <> "VN") Then
                            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_CH").Hidden = False
                        End If
                    Case "Phan_Loai"
                        Update_Cuoc(sender)
                    Case "Khoi_Luong"
                        If CInt(myGridKeyDown.ActiveCell.Text) > 0 Then
                            If (myGridKeyDown.ActiveRow.Cells("Loai_Hang_Hoa").Value <> 1) Then 'Nếu không phải là hàng nhẹ
                                myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Value = myGridKeyDown.ActiveCell.Value
                            End If
                            'Tính cước chính bằng Khối lượng QD
                            Me.Update_Cuoc(sender)
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
            ThongTinE1()
            SetDefaultValueToCell(sender)
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "------------------------Gán giá trị cho phép trùng vào lưới E1_Di------------------------"
    Private Sub Gan_Gia_Tri_Cho_Phep_Trung_Vao_Luoi()
        Try
            With myGridKeyDown
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value = myE1_Di_Chi_Tiet_Trung.Ngay_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value = myE1_Di_Chi_Tiet_Trung.Gio_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = myE1_Di_Chi_Tiet_Trung.Ma_Bc_Goc
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = myE1_Di_Chi_Tiet_Trung.Ma_Don_Vi
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = myE1_Di_Chi_Tiet_Trung.Ma_Bc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = myE1_Di_Chi_Tiet_Trung.Nuoc_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = myE1_Di_Chi_Tiet_Trung.Nuoc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Value = myE1_Di_Chi_Tiet_Trung.Khoi_Luong
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Value = myE1_Di_Chi_Tiet_Trung.Phan_Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value = myE1_Di_Chi_Tiet_Trung.Loai_Hang_Hoa
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = IIf(myE1_Di_Chi_Tiet_Trung.Khoi_Luong_QD = 0, myE1_Di_Chi_Tiet_Trung.Khoi_Luong, myE1_Di_Chi_Tiet_Trung.Khoi_Luong_QD)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = myE1_Di_Chi_Tiet_Trung.Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = myE1_Di_Chi_Tiet_Trung.PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Postcode").Value = myE1_Di_Chi_Tiet_Trung.PostCode
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_PPVX
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = myE1_Di_Chi_Tiet_Trung.VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("COD").Value = myE1_Di_Chi_Tiet_Trung.COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gia_Tri_Hang").Value = myE1_Di_Chi_Tiet_Trung.Gia_Tri_Hang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Giam").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_Giam
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = myE1_Di_Chi_Tiet_Trung.Ghi_Chu
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Gui").Value = myE1_Di_Chi_Tiet_Trung.Nguoi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Value = myE1_Di_Chi_Tiet_Trung.Nguoi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Gui").Value = myE1_Di_Chi_Tiet_Trung.Dia_Chi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Nhan").Value = myE1_Di_Chi_Tiet_Trung.Dia_Chi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Value = myE1_Di_Chi_Tiet_Trung.Dien_Thoai_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Value = myE1_Di_Chi_Tiet_Trung.Kien_So
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Value = myE1_Di_Chi_Tiet_Trung.Ma_Bc_CH
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_Chinh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_E1
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_COD").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Value = myE1_Di_Chi_Tiet_Trung.Dv_Cong_Them
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Value = myE1_Di_Chi_Tiet_Trung.Dv_Gia_Tang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Dv").Value = myE1_Di_Chi_Tiet_Trung.Cuoc_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Ch").Value = myE1_Di_Chi_Tiet_Trung.Ma_Bc_CH
                'Tính hoa hồng phát trả
                If myE1_Di_Chi_Tiet_Trung.HH_Phat_Tra <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myE1_Di_Chi_Tiet_Trung.HH_Phat_Tra
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text, myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text)
                End If
                'Tính hoa hồng phát hành
                If myE1_Di_Chi_Tiet_Trung.HH_Phat_Hanh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myE1_Di_Chi_Tiet_Trung.HH_Phat_Hanh
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim myE1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
                myE1_Le_Phi_Den_Chi_Tiet = myE1_Le_Phi_Den.Lay(myE1_Di_Chi_Tiet_Trung.Id_E1)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_HQ").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_VAT").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK_VAT").Value = CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0))
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_TKHQ").Value = myE1_Le_Phi_Den_Chi_Tiet.So_TKHQ
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_Bien_Lai").Value = myE1_Le_Phi_Den_Chi_Tiet.So_Bien_Lai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_VH").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_YT").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_DV").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_TV").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_Khac").Value = myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac
            End With
            Tinh_Tong_Thue_Le_Phi()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "------------------------Gán giá trị xác nhận đến vào lưới------------------------"
    Private Sub Gan_Gia_Tri_Xac_Nhan_Den_Vao_Luoi(ByVal Sender As Object, ByVal m_E1_Den_Chi_Tiet As E1_Den_Chi_Tiet)
        myGridKeyDown = Sender
        Try
            With myGridKeyDown
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ngay_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.Ngay_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gio_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.Gio_Phat_Hanh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Value = m_E1_Den_Chi_Tiet.Ma_Bc_Goc
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Don_Vi").Value = m_E1_Den_Chi_Tiet.Ma_Don_Vi
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Value = m_E1_Den_Chi_Tiet.Ma_Bc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Value = m_E1_Den_Chi_Tiet.Nuoc_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Value = m_E1_Den_Chi_Tiet.Nuoc_Tra
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong").Value = m_E1_Den_Chi_Tiet.Khoi_Luong
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Phan_Loai").Value = m_E1_Den_Chi_Tiet.Phan_Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai_Hang_Hoa").Value = m_E1_Den_Chi_Tiet.Loai_Hang_Hoa
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Khoi_Luong_QD").Value = IIf(m_E1_Den_Chi_Tiet.Khoi_Luong_QD = 0, m_E1_Den_Chi_Tiet.Khoi_Luong, m_E1_Den_Chi_Tiet.Khoi_Luong_QD)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Loai").Value = m_E1_Den_Chi_Tiet.Loai
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = m_E1_Den_Chi_Tiet.PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = m_E1_Den_Chi_Tiet.Cuoc_PPXD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Postcode").Value = m_E1_Den_Chi_Tiet.PostCode
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = m_E1_Den_Chi_Tiet.Cuoc_PPVX
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = m_E1_Den_Chi_Tiet.VAT
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("COD").Value = m_E1_Den_Chi_Tiet.COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Gia_Tri_Hang").Value = m_E1_Den_Chi_Tiet.Gia_Tri_Hang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Giam").Value = m_E1_Den_Chi_Tiet.Cuoc_Giam
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ghi_Chu").Value = m_E1_Den_Chi_Tiet.Ghi_Chu
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Gui").Value = m_E1_Den_Chi_Tiet.Nguoi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Nguoi_Nhan").Value = m_E1_Den_Chi_Tiet.Nguoi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Gui").Value = m_E1_Den_Chi_Tiet.Dia_Chi_Gui
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dia_Chi_Nhan").Value = m_E1_Den_Chi_Tiet.Dia_Chi_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Value = m_E1_Den_Chi_Tiet.Dien_Thoai_Nhan
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Kien_So").Value = m_E1_Den_Chi_Tiet.Kien_So
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_CH").Value = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = m_E1_Den_Chi_Tiet.Cuoc_Chinh
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = m_E1_Den_Chi_Tiet.Cuoc_E1
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_COD").Value = m_E1_Den_Chi_Tiet.Cuoc_COD
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Cong_Them").Value = m_E1_Den_Chi_Tiet.Dv_Cong_Them
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Dv_Gia_Tang").Value = m_E1_Den_Chi_Tiet.Dv_Gia_Tang
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Dv").Value = m_E1_Den_Chi_Tiet.Cuoc_DV
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Ch").Value = m_E1_Den_Chi_Tiet.Ma_Bc_CH
                'Tính hoa hồng phát trả
                If m_E1_Den_Chi_Tiet.HH_Phat_Tra <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = m_E1_Den_Chi_Tiet.HH_Phat_Tra
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                                                                            IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text = 0, _
                                                                                                myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text, _
                                                                                                myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text), _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text)
                End If
                'Tính hoa hồng phát hành
                If m_E1_Den_Chi_Tiet.HH_Phat_Hanh <> 0 Then
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = m_E1_Den_Chi_Tiet.HH_Phat_Hanh
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                                            myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text) * _
                                                                                            myGridKeyDown.ActiveRow.Cells("Cuoc_Chinh").Value
                End If
                'Lệ phí hải quan
                'Gán giá trị trong bảng E1_Den_Le_Phi
                Dim myE1_Le_Phi_Den_Chi_Tiet As New E1_Le_Phi_Den_Chi_Tiet
                myE1_Le_Phi_Den_Chi_Tiet = myE1_Le_Phi_Den.Lay(m_E1_Den_Chi_Tiet.Id_E1)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_HQ").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_HQ, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_VAT").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Thue_NK_VAT").Value = CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_NK, 0)) + CInt(SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Thue_VAT, 0))
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_TKHQ").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.So_TKHQ, "")
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("So_Bien_Lai").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.So_Bien_Lai, "")
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_VH").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_VH, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_YT").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_YT, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_DV").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_DV, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_TV").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_TV, 0)
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("Le_Phi_Khac").Value = SetNullValue(myE1_Le_Phi_Den_Chi_Tiet.Le_Phi_Khac, 0)
            End With
            Tinh_Tong_Thue_Le_Phi()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "------------------------Update_Cuoc------------------------"
    Private Sub Update_Cuoc(ByVal sender As Object)
        myGridKeyDown = sender
        Exit Sub
        With myGridKeyDown
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("PPXD").Value = 0
            '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPXD").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_PPVX").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("VAT").Value = GVat
            'Không tính cước chính và cước dịch vụ
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = 0
            .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
            'Tính cước dịch vụ cộng thêm và dịch vụ gia tăng
            If (myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "0") And (myGridKeyDown.ActiveRow.Cells("Ma_Bc_CH").Text <> "") Then
                '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
                '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = 0
                .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = 0
                '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value = 0
                '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = 0
            Else
                If myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text <> "VN" Then 'Quốc tế về:không tính cước chính
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = 0
                Else
                    '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value = myTinh_Cuoc.Cuoc_Chinh_E1(CInt(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text), _
                    '                                    myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                    '                                    CInt(myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text), _
                    '                                    myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                    '                                    myGridKeyDown.ActiveRow.Cells("PostCode").Text, _
                    '                                    myGridKeyDown.ActiveRow.Cells("Phan_Loai").Text, _
                    '                                    IIf(CInt(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text) = 0, CInt(myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text), CInt(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text)), _
                    '                                    CInt(myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text), _
                    '                                    CInt(myGridKeyDown.ActiveRow.Cells("Loai").Value))
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Hanh").Value = myTinh_Cuoc.HH_Phat_Hanh(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                        myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                        myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                        myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text) * _
                                                        myGridKeyDown.ActiveRow.Cells("Cuoc_E1").Value
                End If

                If myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text <> "VN" Then 'Quốc tế đi:không tính hoa hồng công phát
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = 0
                Else
                    .Rows(myGridKeyDown.ActiveRow.Index).Cells("HH_Phat_Tra").Value = myTinh_Cuoc.HH_Phat_Tra(myGridKeyDown.ActiveRow.Cells("Ma_BC_Goc").Text, _
                                                                    myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, _
                                                                    myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text, _
                                                                    myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text, _
                                                                    IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text = 0, myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text, myGridKeyDown.ActiveRow.Cells("Khoi_Luong_QD").Text), _
                                                                    myGridKeyDown.ActiveRow.Cells("Loai").Value, _
                                                                    myGridKeyDown.ActiveRow.Cells("Ngay_Phat_Hanh").Text)
                End If
                'Cước E1 tự nhập
                '.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_E1").Value = (.Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_Chinh").Value + .Rows(myGridKeyDown.ActiveRow.Index).Cells("Cuoc_DV").Value) * (1 + GVat)
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
            Le_Phi_HQ = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_HQ").Text, 0))
            Thue_NK = CInt(SetNullValue(dgE1.ActiveRow.Cells("Thue_NK").Text, 0))
            Thue_VAT = CInt(SetNullValue(dgE1.ActiveRow.Cells("Thue_VAT").Text, 0))
            Le_Phi_VH = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_VH").Text, 0))
            Le_Phi_YT = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_YT").Text, 0))
            Le_Phi_TV = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_TV").Text, 0))
            Le_Phi_DV = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_DV").Text, 0))
            Le_Phi_Khac = CInt(SetNullValue(dgE1.ActiveRow.Cells("Le_Phi_Khac").Text, 0))

            Thue_NK_VAT = Thue_NK + Thue_VAT
            Tong_Thue_Le_Phi = Le_Phi_HQ + Le_Phi_VH + Le_Phi_YT + Le_Phi_TV + Le_Phi_DV + Le_Phi_Khac + Thue_NK + Thue_VAT
            myGridKeyDown.ActiveRow.Cells("Thue_NK_VAT").Value = Thue_NK_VAT
            myGridKeyDown.ActiveRow.Cells("Tong_Thue_Le_Phi").Value = Tong_Thue_Le_Phi
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "------------------------SetDefaultValueToCell------------------------"
    Private Sub SetDefaultValueToCell(ByVal sender As Object)
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "" Then 'Chưa nhập số liệu
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_Bc_Goc").Text)
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Nuoc_Nhan").Text
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Nuoc_Tra").Text
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_Bc_Tra").Text)
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Phan_Loai").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Phan_Loai").Text
        Else
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_Bc_Goc").Text)
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Nuoc_Nhan").Text
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Nuoc_Tra").Text
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").DefaultCellValue = CInt(myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_Bc_Tra").Text)
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Phan_Loai").DefaultCellValue = myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Phan_Loai").Text
        End If
    End Sub
#End Region

#Region "------------------------dgE1_AfterRowActivate------------------------"
    Private Sub dgE1_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgE1.AfterRowActivate
        myChoPhepLacHuong = False
        ThongTinE1()
    End Sub
#End Region

#Region "------------------------ThongTinE1------------------------"
    Private Sub ThongTinE1()
        If dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then
            Dim Danh_Muc_Bc_Goc As Danh_Muc_BC_Chi_Tiet
            Dim Danh_Muc_Bc_Tra As Danh_Muc_BC_Chi_Tiet
            Danh_Muc_Bc_Goc = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Goc").Text))
            Danh_Muc_Bc_Tra = Tim_Danh_Muc_BC_Tu_Ma_Bc(CInt(dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_Bc_Tra").Text))
            Me.txtThongTin.Text = "Số hiệu E1   :" & dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Ma_E1").Text & vbNewLine _
                                        & "Bưu phẩm từ: " & IIf(Danh_Muc_Bc_Goc.Ma_BC = 0, dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text & " - " & myMaNuoc.Lay(dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Nhan").Text).Ten_Nuoc, Danh_Muc_Bc_Goc.Ma_BC & " - " & Danh_Muc_Bc_Goc.Ten_Buu_Cuc) & vbNewLine _
                                        & "Đóng đến   : " & IIf(Danh_Muc_Bc_Tra.Ma_BC = 0, dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text & " - " & myMaNuoc.Lay(dgE1.Rows(myGridKeyDown.ActiveRow.Index).Cells("Nuoc_Tra").Text).Ten_Nuoc, Danh_Muc_Bc_Tra.Ma_BC & " - " & Danh_Muc_Bc_Tra.Ten_Buu_Cuc)
        End If
    End Sub
#End Region

#Region "------------------------dgE1_BeforeRowDeactivate------------------------"
    Private Sub dgE1_BeforeRowDeactivate(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgE1.BeforeRowDeactivate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Bạn chưa nhập số hiệu E1" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myCell = myGridKeyDown.ActiveRow.Cells("Ma_E1")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Nước nhận không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = False
                myCell = myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Nước trả không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                myCell = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Mã Bưu cục trả không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                myCell = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Tra")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        ElseIf myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc").Text = "" Then
            If myGridKeyDown.ActiveRow.HasNextSibling = True Then
                MessageBox.Show("Mã Bưu cục gốc không được phép bỏ trống" & vbNewLine & "Xin mơi bạn nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Goc").Hidden = False
                myCell = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Goc")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            End If
        Else
            ' Kiem tra lac huong
            If LacHuong() Then
                 MessageBox.Show("Bưu phẩm lạc hướng!!! Đề nghị kiểm tra lại thông tin E1 hoặc " & " danh mục hướng chuyển đi" & "đối với đường thư hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
                If myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text = "VN" Then
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = False
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = True
                Else
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Bc_Tra").Hidden = True
                    myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").Hidden = False
                End If

                myCell = myGridKeyDown.ActiveRow.Cells("Ma_E1")
                myGridKeyDown.ActiveCell = myCell
                myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                Exit Sub
            End If
        End If



    End Sub
#End Region

#Region "------------------------dgE1_BeforeRowInsert------------------------"
    Private Sub dgE1_BeforeRowInsert(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowInsertEventArgs) Handles dgE1.BeforeRowInsert
        myGridKeyDown = sender
        If myGridKeyDown.ActiveRow Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.ActiveRow.Cells("STT").Text = "" And myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" Then
            myGridKeyDown.ActiveRow.Cells("STT").Value = myGridKeyDown.ActiveRow.Index + 1
        End If
    End Sub
#End Region

#Region "------------------------dgE1_AfterRowUpdate------------------------"
    Private Sub dgE1_AfterRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1.AfterRowUpdate
        Dim myBaophat As New Bao_Phat(GConnectionString)
        Dim myE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
        Dim myE1_Le_Phi_Di_Chi_Tiet As New E1_Le_Phi_Di_Chi_Tiet
        'myGridKeyDown = sender
        If dgE1.Rows(dgE1.ActiveRow.Index).Cells("Ma_E1").Text <> "" Then  'Nếu dòng có dữ liệu, và đã nhập khối lượng
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
                .Truyen_Doi_Soat = CBool(myGridKeyDown.ActiveRow.Cells("Truyen_Doi_Soat").Value())
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
                .Le_Phi_VH = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_VH").Text(), 0))
                .Le_Phi_YT = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_YT").Text(), 0))
                .Le_Phi_DV = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_DV").Text(), 0))
                .Le_Phi_TV = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_TV").Text(), 0))
                .Le_Phi_Khac = CInt(SetNullValue(myGridKeyDown.ActiveRow.Cells("Le_Phi_Khac").Text(), 0))
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
                    If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Xóa dữ liệu nếu đây là đường thư đường thư lưu kho
                        myE1_Den_Tam.Xoa(CreateId_E1(myE1_Di_Chi_Tiet.Ma_E1, myId_E2_Luu_Kho, myE1_Di_Chi_Tiet.Kien_So))
                    ElseIf (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 6) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 8) Then 'Nếu là đường thư chuyển tiếp hoặc vào kho hải quan
                        myE1_Den_Tam.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    End If
                    If (chk_Ngaynghi.Checked = True) Then 'Trạng thái là ngày nghỉ, ngày lễ
                        myBaophat.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    End If
                    myE1_Di.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    myE1_Le_Phi_Di.E1_Le_Phi_Di_Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text) 'Xóa dữ liệu trong bảng lệ phí
                    'Xoa trong Paypost
                    myE1_COD_Tam.Xoa(myGridKeyDown.ActiveRow.Cells("Id_E1").Text)
                    '------------
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

            'Cap nhat vao PayPost
            With myE1_Le_Phi_Di_Chi_Tiet
                Dim mGia_Tri_Hang As Integer
                mGia_Tri_Hang = Kiem_Tra_So_Tien_Phai_Thu_Qua_Paypost(.Thue_NK_VAT, .Le_Phi_HQ, .Le_Phi_VH, .Le_Phi_YT, .Le_Phi_DV, .Le_Phi_TV, .Le_Phi_Khac)
                If mGia_Tri_Hang > 0 And myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 2 Then
                    'Đã thu thuế
                    If CBool(myE1_Di_Chi_Tiet.Truyen_Doi_Soat) = True Then
                        'Xoa trong PayPost
                        myE1_COD_Tam.Xoa(myE1_Di_Chi_Tiet.Id_E1)
                    Else  'Chưa thu thuế thì ghi vào PayPost
                        With myE1_Di_Chi_Tiet
                            .Cuoc_COD = Tinh_Cuoc_COD_Di(mGia_Tri_Hang, myE1_Di_Chi_Tiet.Ngay_Dong)

                            myE1_COD_Tam.Cap_Nhat_Them(.Id_E1, .Ma_Bc_Khai_Thac, .Ma_Quay, .Ma_E1, .Ngay_Dong, .Gio_Dong, .Ma_Don_Vi, .Ma_Bc_Goc, .Ma_Bc_Tra, GDich_Vu_Thu_Ho, mGia_Tri_Hang, .Cuoc_COD, 0, GMa_KH_Gui_Paypost, Chuan_Hoa_Thong_Tin_PayPost(GNguoi_Gui_Paypost), Chuan_Hoa_Thong_Tin_PayPost(.Nguoi_Nhan), Chuan_Hoa_Thong_Tin_PayPost(GDia_Chi_Gui_Paypost), Chuan_Hoa_Thong_Tin_PayPost(.Dia_Chi_Nhan), Chuan_Hoa_Thong_Tin_PayPost(.Dien_Thoai_Gui), Chuan_Hoa_Thong_Tin_PayPost(.Dien_Thoai_Nhan), .Ghi_Chu & " SBL: " & myE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai, .Ngay_He_Thong, "", GNguoi_Gui_Paypost, GDia_Chi_Gui_Paypost, GDien_Thoai_Gui_Paypost, False, True, True, 0, 0, True, 0, .Id_Ca)
                        End With
                    End If
                Else
                    If myE1_COD_Tam.Lay(myE1_Di_Chi_Tiet.Id_E1).Ma_E1 <> "" Then
                        'Xoa trong PayPost
                        myE1_COD_Tam.Xoa(myE1_Di_Chi_Tiet.Id_E1)
                    End If
                End If
            End With
            '-------------------------------------------

            If (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 5) Or (myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 7) Then 'Nếu là đường thư lưu kho (5:quốc tế đến, 7:quốc tế đi)
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

            'Bỏ kiểm tra trạng thái ngày nghỉ nếu là đường thư chuyển tiếp
            'Khong ghi vao bang Bao phat neu loai duong thu khong phai la lien tinh (=2)
            If myDuong_Thu_Di_Chi_Tiet.Chuyen_Tiep = False And myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = 2 Then
                If (chk_Ngaynghi.Checked = True) Then 'Trạng thái là ngày nghỉ, ngày lễ cập nhật vào báo phát
                    'cap nhat vao bang bao phat
                    Dim Id_bao_phat As String = ""
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
                    Id_bao_phat = myE1_Di_Chi_Tiet.Id_E1
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
                    myBaophat.Bao_Phat_Cap_Nhat_Them_Tu_E1_Di(Id_bao_phat, Ma_E1, Nuoc_Nhan, Ma_Bc_Phat, Ngay_Phat, _
                                Gio_Phat, Ngay_Nhap, Gio_Nhap, Nguoi_Phat, Nguoi_Nhan, Khoi_Luong, Ma_Ly_Do, Ma_Xu_Ly, Phat_Duoc, _
                            Id_Nguoi_Dung, Ngay_He_Thong, Truyen_Khai_Thac)
                    'cap nhat vao bang noi dung phat
                    Dim myNoiDungChiTiet As New Noi_Dung_Phat_Chi_Tiet
                    Dim myNoiDung As New Noi_Dung_Phat(GConnectionString)
                    With myNoiDungChiTiet
                        .Id_Noi_Dung = 0
                        .Id_Bao_Phat = Id_bao_phat
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
            End If

            'Trạng thái
            myTrang_Thai_Chi_Tiet.Id_E1 = myE1_Di_Chi_Tiet.Id_E1
            myTrang_Thai_Chi_Tiet.Ma_Bc = GBuu_Cuc_Khai_Thac
            myTrang_Thai_Chi_Tiet.Ma_E1 = myE1_Di_Chi_Tiet.Ma_E1
            myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai = myE2_Date
            myTrang_Thai_Chi_Tiet.Gio_Trang_Thai = myE2_Time
            myTrang_Thai_Chi_Tiet.Truyen_Khai_Thac = False
            myTrang_Thai.Cap_Nhat_Them_KT(myTrang_Thai_Chi_Tiet.Id_E1, myTrang_Thai_Chi_Tiet.Ma_E1, myTrang_Thai_Chi_Tiet.Id_Trang_Thai, myTrang_Thai_Chi_Tiet.Ngay_Trang_Thai, myTrang_Thai_Chi_Tiet.Gio_Trang_Thai, myTrang_Thai_Chi_Tiet.Ma_Bc, False)
        End If
        ReCalculate_Summary(sender)
    End Sub
#End Region

#Region "------------------------dgE1_BeforeCellUpdate------------------------"
    Private Sub dgE1_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgE1.BeforeCellUpdate
        myGridKeyDown = sender
        Select Case e.Cell.Column.Key 'myGridKeyDown.ActiveCell.Column.Key
            Case "Ma_Bc_Goc"

            Case "Nuoc_Nhan"
                'Kiểm tra xem nước nhận bị thay đổi so với mã E1 thì cảnh báo
                'Nếu đồng ý thì sẽ cho phép thay đổi
                If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" Then
                    If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> Mid(myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text, 11, 2) Then  'Nếu thay đổi mã nước
                        'If MessageBox.Show("Bạn có thực sự muốn thay đổi mã nước nhận không???", "Thông báo", MessageBoxButtons.YesNo) = DialogResult.No Then
                        '    'Nếu không thì trả lại giá trị cũ và thoát khỏi cell
                        '    e.Cancel = True
                        '    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        'End If
                    End If
                End If
        End Select

    End Sub
#End Region

#Region "------------------------dgE1_BeforeRowUpdate------------------------"
    Private Sub dgE1_BeforeRowUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles dgE1.BeforeRowUpdate
        myGridKeyDown = sender
        If (Not CInt(IIf(myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text = "", 0, myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text)) > 0) And ((myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "")) Then
            MessageBox.Show("Chưa nhập khối lượng bưu phẩm!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "------------------------dgE1_LostFocus------------------------"
    Private Sub dgE1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgE1.LostFocus
        myCell = Nothing
    End Sub
#End Region
#End Region

#Region "-----------------------Search-----------------------"
#Region "dgE1_MouseDown"
    Private Sub dgE1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1.MouseDown
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

#Region "-----------------------Truyền dữ liệu-----------------------"
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

#Region "-----------------------Truyen_Du_Lieu_Logitic_Sang_Khai_Thac_Quoc_Te-----------------------"
    Private Function Truyen_Du_Lieu_Logitic_Sang_Khai_Thac_Quoc_Te() As Boolean
        Try
            'Khai bao bien
            Dim mChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
            Dim mE2_Di As New E2_Di(GConnectionString)
            Dim mE1_Di As New E1_Di(GConnectionString)
            Dim mE1_Le_Phi_Di As New E1_Le_Phi_Di(GConnectionString)
            Dim mThong_Tin_Truyen_Logitic As New Thong_Tin_Truyen_Logitic(GConnectionString)

            Dim mChuyen_Thu_Den_Tam_KTQT As New Chuyen_Thu_Den_Tam(GConnectionString_International_From_Logitic)
            Dim mE2_Den_Tam_KTQT As New E2_Den_Tam(GConnectionString_International_From_Logitic)
            Dim mE1_Den_Tam_KTQT As New E1_Den_Tam(GConnectionString_International_From_Logitic)
            Dim mE1_Le_Phi_Den_Tam_KTQT As New E1_Le_Phi_Den_Tam(GConnectionString_International_From_Logitic)


            Dim mChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
            Dim mE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
            Dim mE1_Di_Chi_Tiet As New E1_Di_Chi_Tiet
            Dim mE1_Le_Phi_Di_Chi_Tiet As New E1_Le_Phi_Di_Chi_Tiet
            Dim mThong_Tin_Truyen_Logitic_Chi_Tiet As New Thong_Tin_Truyen_Logitic_Chi_Tiet

            Dim mData As New DataTable

            'Lay thong tin truyen de kiem tra xem da truyen hay chua
            mThong_Tin_Truyen_Logitic_Chi_Tiet = mThong_Tin_Truyen_Logitic.Thong_Tin_Truyen_Logitic_Lay(myId_Chuyen_Thu)
            If mThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Dich <> "" Then   'Da truyen roi
                'Không truyền lại thì thoát luôn
                If MessageBox.Show("Chuyến thư này đã được truyền một lần rồi, bạn có muốn truyền lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                    Return True
                    Exit Function
                End If
            End If
            'Truyền dữ liệu
            'Đặt lại trạng thái của Mouse - Đồng hồ cát
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            Dim i As Integer
            Dim Tong_So_E1 As Integer
            'Lay thong tin chuyen thu vao bien
            mChuyen_Thu_Di_Chi_Tiet = mChuyen_Thu_Di.Lay(myId_Chuyen_Thu)
            'Lay danh sách E1_Di của chuyến thư cần truyền
            mData = mE1_Di.E1_Di_Danh_Sach_E1_Lay_Boi_Id_Chuyen_Thu(myId_Chuyen_Thu).Tables(0)
            Tong_So_E1 = mData.Rows.Count
            'Hiện lại process truyền dữ liệu
            grbTruyen_Du_Lieu.Left = dgE1.Left + (dgE1.Width - grbTruyen_Du_Lieu.Width) / 2
            grbTruyen_Du_Lieu.Top = dgE1.Top + (dgE1.Height - grbTruyen_Du_Lieu.Height) / 2
            grbTruyen_Du_Lieu.Visible = True
            Me.Refresh()
            'Refresh thông tin 
            lblCommunication.Text = "Tổng số E1 :    " & Tong_So_E1.ToString
            'Refresh Process
            PrbCommunication.Maximum = Tong_So_E1
            PrbCommunication.Step = 1
            PrbCommunication.Value = 0
            '1.====================Truyền dữ liệu E1
            'Duyệt từng E1_Di, E1_Le_Phi_Di và ghi vào E1_Den_Tam, E1_Le_Phi_Den_Tam của KTQT
            For i = 0 To Tong_So_E1 - 1
                'E1_Di
                mE1_Den_Tam_KTQT.E1_Den_Tam_Cap_Nhat_Them_KT(mData.Rows(i).Item("Id_E1"), _
                                                mData.Rows(i).Item("Id_Duong_Thu"), _
                                                mData.Rows(i).Item("Id_Chuyen_Thu"), _
                                                mData.Rows(i).Item("Id_E2"), _
                                                mData.Rows(i).Item("Id_Ca"), _
                                                mData.Rows(i).Item("Ma_Bc_Khai_Thac"), _
                                                mData.Rows(i).Item("Ma_Quay"), _
                                                mData.Rows(i).Item("Ma_E1"), _
                                                mData.Rows(i).Item("Ngay_Phat_Hanh"), _
                                                mData.Rows(i).Item("Gio_Phat_Hanh"), _
                                                mData.Rows(i).Item("Ngay_Dong"), _
                                                mData.Rows(i).Item("Gio_Dong"), _
                                                mData.Rows(i).Item("Ngay_Nhan"), _
                                                mData.Rows(i).Item("Gio_Nhan"), _
                                                mData.Rows(i).Item("Ma_Don_Vi"), _
                                                mData.Rows(i).Item("Ma_Bc_Goc"), _
                                                mData.Rows(i).Item("Ma_Bc_Tra"), _
                                                mData.Rows(i).Item("Nuoc_Nhan"), _
                                                mData.Rows(i).Item("Nuoc_Tra"), _
                                                mData.Rows(i).Item("Khoi_Luong"), _
                                                mData.Rows(i).Item("Phan_Loai"), _
                                                mData.Rows(i).Item("Loai_Hang_Hoa"), _
                                                mData.Rows(i).Item("Khoi_Luong_QD"), _
                                                mData.Rows(i).Item("Loai"), _
                                                mData.Rows(i).Item("Dv_Cong_Them"), _
                                                mData.Rows(i).Item("Dv_Gia_Tang"), _
                                                mData.Rows(i).Item("PPXD"), _
                                                mData.Rows(i).Item("Cuoc_PPXD"), _
                                                mData.Rows(i).Item("PostCode"), _
                                                mData.Rows(i).Item("Cuoc_PPVX"), _
                                                mData.Rows(i).Item("VAT"), _
                                                mData.Rows(i).Item("COD"), _
                                                mData.Rows(i).Item("Gia_Tri_Hang"), _
                                                mData.Rows(i).Item("Cuoc_COD"), _
                                                mData.Rows(i).Item("Cuoc_DV"), _
                                                mData.Rows(i).Item("Cuoc_Chinh"), _
                                                mData.Rows(i).Item("Cuoc_Giam"), _
                                                mData.Rows(i).Item("Cuoc_E1"), _
                                                mData.Rows(i).Item("Kien_So"), _
                                                mData.Rows(i).Item("STT"), _
                                                mData.Rows(i).Item("Ma_KH"), _
                                                mData.Rows(i).Item("Nguoi_Gui"), _
                                                mData.Rows(i).Item("Nguoi_Nhan"), _
                                                mData.Rows(i).Item("Dia_Chi_Gui"), _
                                                mData.Rows(i).Item("Dia_Chi_Nhan"), _
                                                mData.Rows(i).Item("Dien_Thoai_Gui"), _
                                                mData.Rows(i).Item("Dien_Thoai_Nhan"), _
                                                mData.Rows(i).Item("HH_Phat_Hanh"), _
                                                mData.Rows(i).Item("HH_Phat_Tra"), _
                                                mData.Rows(i).Item("Ma_Bc_CH"), _
                                                mData.Rows(i).Item("Id_Nguoi_Dung"), _
                                                mData.Rows(i).Item("Id_Trang_Thai"), _
                                                mData.Rows(i).Item("Ghi_Chu"), _
                                                mData.Rows(i).Item("Truyen_Khai_Thac"), _
                                                mData.Rows(i).Item("Truyen_Doi_Soat"), _
                                                mData.Rows(i).Item("Chot_SL"))
                'Lay thong tin E1_Le_Phi_Di
                mE1_Le_Phi_Di_Chi_Tiet = mE1_Le_Phi_Di.Lay(mData.Rows(i).Item("Id_E1"))
                mE1_Le_Phi_Den_Tam_KTQT.E1_Le_Phi_Den_Tam_Cap_Nhat_Them_KT(mE1_Le_Phi_Di_Chi_Tiet.Id_E1, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Id_Duong_Thu, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Id_Chuyen_Thu, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Id_E2, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Id_Ca, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ma_E1, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ngay_Dong, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Gio_Dong, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ma_Don_Vi, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Goc, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Ma_Bc_Tra, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Nuoc_Nhan, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Nuoc_Tra, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Khoi_Luong, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.So_TKHQ, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.So_Bien_Lai, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_HQ, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Thue_NK, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Thue_VAT, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Thue_NK_VAT, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Kien_So, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.STT, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Id_Nguoi_Dung, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Truyen_Khai_Thac, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Truyen_Doi_Soat, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Chot_SL, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_VH, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_YT, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_DV, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_TV, _
                                                                            mE1_Le_Phi_Di_Chi_Tiet.Le_Phi_Khac)

                PrbCommunication.PerformStep()
                lblCommunication.Text = "Đang truyền dữ liệu E1.....  ( " & PrbCommunication.Value & " / " & PrbCommunication.Maximum & " )"
                lblCommunication.Refresh()
            Next i
            '2. Truyền dữ liệu E2
            mData = mE2_Di.Danh_Sach_E2_Truyen(myId_Chuyen_Thu).Tables(0)
            'Refresh Process
            PrbCommunication.Maximum = mData.Rows.Count
            PrbCommunication.Step = 1
            PrbCommunication.Value = 0
            For i = 0 To mData.Rows.Count - 1
                mE2_Den_Tam_KTQT.E2_Den_Tam_Cap_Nhat_Them_KT(mData.Rows(i).Item("Id_E2"), _
                                                mData.Rows(i).Item("Id_Duong_Thu"), _
                                                mData.Rows(i).Item("Id_Chuyen_Thu"), _
                                                mData.Rows(i).Item("Id_Ca"), _
                                                mData.Rows(i).Item("Ma_Bc_Khai_Thac"), _
                                                mData.Rows(i).Item("Ngay_Dong"), _
                                                mData.Rows(i).Item("Gio_Dong"), _
                                                mData.Rows(i).Item("Ngay_Nhan"), _
                                                mData.Rows(i).Item("Gio_Nhan"), _
                                                mData.Rows(i).Item("Tui_So"), _
                                                mData.Rows(i).Item("Tui_F"), _
                                                mData.Rows(i).Item("Tong_So_BP"), _
                                                mData.Rows(i).Item("Khoi_Luong_Vo_Tui"), _
                                                mData.Rows(i).Item("Khoi_Luong_BP"), _
                                                mData.Rows(i).Item("Tong_Cuoc_COD"), _
                                                mData.Rows(i).Item("Tong_Cuoc_DV"), _
                                                mData.Rows(i).Item("Tong_Cuoc_Chinh"), _
                                                mData.Rows(i).Item("HH_Phat_Hanh"), _
                                                mData.Rows(i).Item("HH_Phat_Tra"), _
                                                mData.Rows(i).Item("Truyen_Khai_Thac"), _
                                                mData.Rows(i).Item("Truyen_Doi_Soat"), _
                                                mData.Rows(i).Item("Chot_SL"))
                PrbCommunication.PerformStep()
                lblCommunication.Text = "Đang truyền dữ liệu E2.....  ( " & PrbCommunication.Value & " / " & PrbCommunication.Maximum & " )"
                lblCommunication.Refresh()
            Next i
            '3. Truyền dữ liệu Chuyến thư
            mChuyen_Thu_Den_Tam_KTQT.Chuyen_Thu_Den_Tam_Cap_Nhat_Them_KT(mChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu, mChuyen_Thu_Di_Chi_Tiet.Id_Duong_Thu, mChuyen_Thu_Di_Chi_Tiet.Id_Ca, mChuyen_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, mChuyen_Thu_Di_Chi_Tiet.So_Chuyen_Thu, mChuyen_Thu_Di_Chi_Tiet.Ngay_Dong, mChuyen_Thu_Di_Chi_Tiet.Gio_Dong, mChuyen_Thu_Di_Chi_Tiet.Ngay_Nhan, mChuyen_Thu_Di_Chi_Tiet.Gio_Nhan, mChuyen_Thu_Di_Chi_Tiet.Tong_So_Tui, mChuyen_Thu_Di_Chi_Tiet.Tong_So_BP, mChuyen_Thu_Di_Chi_Tiet.Tong_KL, mChuyen_Thu_Di_Chi_Tiet.Tong_KLBP, mChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_COD, mChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc_DV, mChuyen_Thu_Di_Chi_Tiet.Tong_Cuoc, mChuyen_Thu_Di_Chi_Tiet.HH_Phat_Hanh, mChuyen_Thu_Di_Chi_Tiet.HH_Phat_Tra, mChuyen_Thu_Di_Chi_Tiet.Dong_F, mChuyen_Thu_Di_Chi_Tiet.Truyen_Khai_Thac, mChuyen_Thu_Di_Chi_Tiet.Truyen_Doi_Soat, mChuyen_Thu_Di_Chi_Tiet.Chot_Sl)
            'Cập nhật thông tin truyền 
            Dim mIp_Duong_Thu_Logitic As New Ip_Duong_Thu_Logitic(GConnectionString)
            Dim mIp_Duong_Thu_Logitic_Chi_Tiet As New Ip_Duong_Thu_Logitic_Chi_Tiet
            Dim mMa_Bc As Integer = myDuong_Thu_Di.Lay(myId_Duong_Thu).Ma_Bc
            'Lay thong tin vao bien
            mIp_Duong_Thu_Logitic_Chi_Tiet = mIp_Duong_Thu_Logitic.Ip_Duong_Thu_Logitic_Lay_Boi_Ma_Bc_Goc_Ma_Bc_Dich(GBuu_Cuc_Khai_Thac, mMa_Bc)
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Id_Chuyen_Thu = mChuyen_Thu_Di_Chi_Tiet.Id_Chuyen_Thu
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Goc = mIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Goc
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Dich = mIp_Duong_Thu_Logitic_Chi_Tiet.Ip_Dich
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Goc = GBuu_Cuc_Khai_Thac
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Dich = mMa_Bc
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_Gui = myHam_Dung_Chung.ConvertDateToInt(Now())
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_Gui = myHam_Dung_Chung.ConvertTimeToInt(Now())
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_He_Thong = 0  'Lay ngay tren server
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_He_Thong = 0   'Lay gio tren server
            mThong_Tin_Truyen_Logitic_Chi_Tiet.Da_Gui = True
            'Cap nhat 
            mThong_Tin_Truyen_Logitic.Thong_Tin_Truyen_Logitic_Cap_Nhat_Them(mThong_Tin_Truyen_Logitic_Chi_Tiet.Id_Chuyen_Thu, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Goc, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ma_Bc_Dich, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Goc, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ip_Dich, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_Gui, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_Gui, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Ngay_He_Thong, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Gio_He_Thong, _
                                                                            mThong_Tin_Truyen_Logitic_Chi_Tiet.Da_Gui)
            'Tra lai trang thái của Mouse - Default
            Me.ActiveForm.Cursor.Current = Cursors.Default
            'Ẩn Process truyền dữ liệu sau khi hoàn tất
            grbTruyen_Du_Lieu.Visible = False
            'Trả về True
            Return True
        Catch ex As Exception
            MessageBox.Show("Xả ra lỗi truyền dữ liệu từ Logitic sang Khai thác quốc tế!!!" & vbNewLine & "Hãy thông báo ngay lỗi này cho người quản trị, nếu không Trung tâm KTQT sẽ không xác nhận được dữ liệu đóng từ Logitic sang.", "Lỗi truyền dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Ẩn Process truyền dữ liệu
            If grbTruyen_Du_Lieu.Visible Then
                grbTruyen_Du_Lieu.Visible = False
            End If
            'Trả về False
            Return False
        End Try
    End Function
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
        chkCuocE1.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Cuoc_E1"), "False"))
        chk_Nguoi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Nguoi_Nhan"), "False"))
        chk_Dia_Chi_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dia_Chi_Nhan"), "False"))
        chk_Dien_Thoai_Nhan.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dien_Thoai_Nhan"), "False"))
        chk_Nguoi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Nguoi_Gui"), "False"))
        chk_Dia_Chi_Gui.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Dia_Chi_Gui"), "False"))
        chkGhiChu.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Ghi_Chu"), "False"))
        chkLe_Phi_HQ.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_HQ"), "False"))
        chkThue_NK.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_NK"), "False"))
        chkThue_VAT.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_VAT"), "False"))
        chkSo_TKHQ.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_So_TKHQ"), "False"))
        chkSo_Bien_Lai.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_So_Bien_Lai"), "False"))
        chkLoai_Hang_Hoa.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Loai_Hang_Hoa"), "False"))
        chkBcChuyenHoan.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Ma_Bc_CH"), "False"))
        chkCuocDV.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Cuoc_Dv"), "False"))
        chkKienSo.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Kien_So"), "False"))
        chk_Le_Phi_VH.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_VH"), "False"))
        chk_Le_Phi_YT.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_YT"), "False"))
        chk_Le_Phi_DV.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_DV"), "False"))
        chk_Le_Phi_TV.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_TV"), "False"))
        chk_Le_Phi_Khac.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Le_Phi_Khac"), "False"))

        chkThue_Tieu_Thu.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Thue_Tieu_Thu"), "False"))
        chkThue_Tieu_Thu.Enabled = False
        chkTong_Thue_Le_Phi.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Tong_Thue_Le_Phi"), "False"))
        chkTrangThaiThuThue.Checked = CBool(SetNullValue(myKeys.Doc("OB_Grid_Di_Trang_Thai_Thu_Thue"), "False"))
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
        SetLastColumnVisibleKey(dgE1)
    End Sub
#End Region

#Region "-----------------------Cap_Nhat_Tham_So-----------------------"
    Private Sub Cap_Nhat_Tham_So()
        myKeys.Ghi("OB_Grid_Di_Cuoc_E1", chkCuocE1.Checked)
        myKeys.Ghi("OB_Grid_Di_Nguoi_Nhan", chk_Nguoi_Nhan.Checked)
        myKeys.Ghi("OB_Grid_Di_Dia_Chi_Nhan", chk_Dia_Chi_Nhan.Checked)
        myKeys.Ghi("OB_Grid_Di_Dien_Thoai_Nhan", chk_Dien_Thoai_Nhan.Checked)
        myKeys.Ghi("OB_Grid_Di_Nguoi_Gui", chk_Nguoi_Gui.Checked)
        myKeys.Ghi("OB_Grid_Di_Dia_Chi_Gui", chk_Dia_Chi_Gui.Checked)
        myKeys.Ghi("OB_Grid_Di_Ghi_Chu", chkGhiChu.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_HQ", chkLe_Phi_HQ.Checked)
        myKeys.Ghi("OB_Grid_Di_Thue_NK", chkThue_NK.Checked)
        myKeys.Ghi("OB_Grid_Di_Thue_VAT", chkThue_VAT.Checked)
        myKeys.Ghi("OB_Grid_Di_So_TKHQ", chkSo_TKHQ.Checked)
        myKeys.Ghi("OB_Grid_Di_So_Bien_Lai", chkSo_Bien_Lai.Checked)
        myKeys.Ghi("OB_Grid_Di_Loai_Hang_Hoa", chkLoai_Hang_Hoa.Checked)
        myKeys.Ghi("OB_Grid_Di_Bc_CH", chkBcChuyenHoan.Checked)
        myKeys.Ghi("OB_Grid_Di_Cuoc_Dv", chkCuocDV.Checked)
        myKeys.Ghi("OB_Grid_Di_Kien_So", chkKienSo.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_VH", chk_Le_Phi_VH.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_YT", chk_Le_Phi_YT.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_DV", chk_Le_Phi_DV.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_TV", chk_Le_Phi_TV.Checked)
        myKeys.Ghi("OB_Grid_Di_Le_Phi_Khac", chk_Le_Phi_Khac.Checked)

        myKeys.Ghi("OB_Grid_Di_Thue_Tieu_Thu", chkThue_Tieu_Thu.Checked)
        myKeys.Ghi("OB_Grid_Di_Tong_Thue_Le_Phi", chkTong_Thue_Le_Phi.Checked)
        myKeys.Ghi("OB_Grid_Di_Trang_Thai_Thu_Thue", chkTrangThaiThuThue.Checked)
    End Sub
#End Region
#End Region

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
                    myMa_Bc_Chu = myMa_So_Tui.Substring(6, 6)
                    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
                    If Not myDanh_Muc_Bc.Lay_Boi_IPMC(myMa_Bc_Chu).Tables(0).Rows.Count > 0 Then 'Nếu không có dữ liệu thì thoát
                        MessageBox.Show("Không tìm thấy đường thư này" & vbNewLine & "Bạn hãy kiểm tra lại các bảng danh mục!!!", _
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtMaSoTui.Select()
                        Exit Sub
                    End If

                    cbMaNuoc.Value = myDanh_Muc_Bc.Lay_Boi_IPMC(myMa_Bc_Chu).Tables(0).Rows(0).Item("Ma_Nc")
                    cbMaNuoc_Validated(sender, e)
                    cbDuongThuDi.Value = myDanh_Muc_Bc.Lay_Boi_IPMC(myMa_Bc_Chu).Tables(0).Rows(0).Item("Ma_bc")
                    myId_Duong_Thu = "0" & GBuu_Cuc_Khai_Thac.ToString() & cbDuongThuDi.Value.ToString()
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
                cbChuyenThuDi.Text = CInt(SetNullValue(myMa_So_Tui.Substring(16, 4), 0))
                'Tìm túi số đến
                cbTuiSoDi.Text = CInt(SetNullValue(myMa_So_Tui.Substring(20, 3), 0))
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
                cbDuongBay.DataSource = myDanh_Muc_Duong_Bay.Lay_Boi_Duong_Thu_Di_KT(myId_Duong_Thu)
                If cbDuongBay.Rows.Count > 0 Then
                    cbDuongBay.Enabled = True
                    cbNgayBay.Enabled = True
                    cbDuongBay.Value = cbDuongBay.Rows(0).Cells("So_Hieu").Value
                    cbDuongBay.Text = cbDuongBay.Rows(0).Cells("So_Hieu").Value
                    myId_Duong_Bay = cbDuongBay.Rows(0).Cells("Id_Duong_Bay").Value
                Else
                    cbDuongBay.Enabled = False
                    cbNgayBay.Enabled = False
                    cbDuongBay.Text = ""
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
End Class

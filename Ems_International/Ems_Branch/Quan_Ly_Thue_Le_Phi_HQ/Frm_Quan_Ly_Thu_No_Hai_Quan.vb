Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class Frm_Quan_Ly_Thu_No_Hai_Quan
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
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkThu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents lblThong_Tin_Thu_No As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblThong_Tin_No As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgE1_No As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpNgay_Thu As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnTham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grbThong_Tin As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grbChi_Tiet As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grbTham_So As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents chkNgay_Dong_No As System.Windows.Forms.CheckBox
    Friend WithEvents lblTham_So_Thu_No As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblTham_So_No As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkDia_Chi_Nhan_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkNguoi_Nhan_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkTui_So_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkChuyen_Thu_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuong_Thu_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkNgay_Dong_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkDia_Chi_Nhan_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkNguoi_Nhan_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkTui_So_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkChuyen_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkDuong_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkThue_NK_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkThue_VAT_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkLe_Phi_HQ_No As System.Windows.Forms.CheckBox
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dtpDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents optBuu_Ta_Noi_Bo As System.Windows.Forms.RadioButton
    Friend WithEvents cbMa_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents optCac_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents btnNhap_Moi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThu_Tien As Infragistics.Win.Misc.UltraButton
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents chkNgay_Thu_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkThu_Lan_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNgay_Thu_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkKhoi_Luong_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkKhoi_Luong_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkThu_Lan_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSo_TKHQ_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkSo_Bien_Lai_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkNuoc_Nhan_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkSo_Bien_Lai_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents chkSo_TKHQ_Thu_No As System.Windows.Forms.CheckBox
    Friend WithEvents btnTim_Theo_Ngay_Dong As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTim_Theo_Ngay_Thu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgE1_Thu_No As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnXoa_E1_Thu_No As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ddDuong_Thu_Di As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents Kieu_Nhap_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents chkTong_Tien_Can_Phai_Thu_No As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Quan_Ly_Thu_No_Hai_Quan))
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh_Theo_Duong_Thu", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Duong_Thu", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Thu_No", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Vi")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Nhan")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Den_VN")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Dac_Biet")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Tieu_Thu")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Qua_Tang")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Han_Ngach")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Uu_Dai")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Le_Phi")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_Truyen")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Thu_1")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Lan_1")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Thu_2")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_Lan_2")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ly_Do_CH")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Co_Thu")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien_Thu")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_No", -1)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Vi")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Nhan")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Den_VN")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Dac_Biet")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Tieu_Thu")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Qua_Tang")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Han_Ngach")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Uu_Dai")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Le_Phi")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_Truyen")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di", -1)
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Dung")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grbThong_Tin = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.optBuu_Ta_Noi_Bo = New System.Windows.Forms.RadioButton
        Me.cbMa_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.optCac_Tinh = New System.Windows.Forms.RadioButton
        Me.btnNhap_Moi = New Infragistics.Win.Misc.UltraButton
        Me.btnTham_So = New Infragistics.Win.Misc.UltraButton
        Me.btnTim_Theo_Ngay_Dong = New Infragistics.Win.Misc.UltraButton
        Me.grbChi_Tiet = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnXoa_E1_Thu_No = New Infragistics.Win.Misc.UltraButton
        Me.dgE1_Thu_No = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnTim_Theo_Ngay_Thu = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpNgay_Thu = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.chkThu_No = New System.Windows.Forms.CheckBox
        Me.chkNo = New System.Windows.Forms.CheckBox
        Me.lblThong_Tin_Thu_No = New Infragistics.Win.Misc.UltraLabel
        Me.lblThong_Tin_No = New Infragistics.Win.Misc.UltraLabel
        Me.dgE1_No = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnThu_Tien = New Infragistics.Win.Misc.UltraButton
        Me.grbTham_So = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkTong_Tien_Can_Phai_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkSo_Bien_Lai_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkSo_TKHQ_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkNuoc_Nhan_No = New System.Windows.Forms.CheckBox
        Me.chkSo_Bien_Lai_No = New System.Windows.Forms.CheckBox
        Me.chkSo_TKHQ_No = New System.Windows.Forms.CheckBox
        Me.chkThu_Lan_2 = New System.Windows.Forms.CheckBox
        Me.chkKhoi_Luong_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkKhoi_Luong_No = New System.Windows.Forms.CheckBox
        Me.chkNgay_Thu_2 = New System.Windows.Forms.CheckBox
        Me.chkThu_Lan_1 = New System.Windows.Forms.CheckBox
        Me.chkNgay_Thu_1 = New System.Windows.Forms.CheckBox
        Me.chkLe_Phi_HQ_No = New System.Windows.Forms.CheckBox
        Me.chkThue_VAT_No = New System.Windows.Forms.CheckBox
        Me.chkThue_NK_No = New System.Windows.Forms.CheckBox
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox
        Me.chkDia_Chi_Nhan_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkNguoi_Nhan_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkTui_So_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkChuyen_Thu_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkDuong_Thu_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkNgay_Dong_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkDia_Chi_Nhan_No = New System.Windows.Forms.CheckBox
        Me.chkNguoi_Nhan_No = New System.Windows.Forms.CheckBox
        Me.chkTui_So_No = New System.Windows.Forms.CheckBox
        Me.chkChuyen_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkDuong_Thu_No = New System.Windows.Forms.CheckBox
        Me.chkNgay_Dong_No = New System.Windows.Forms.CheckBox
        Me.lblTham_So_Thu_No = New Infragistics.Win.Misc.UltraLabel
        Me.lblTham_So_No = New Infragistics.Win.Misc.UltraLabel
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.ddDuong_Thu_Di = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.Kieu_Nhap_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        CType(Me.grbThong_Tin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbThong_Tin.SuspendLayout()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbChi_Tiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbChi_Tiet.SuspendLayout()
        CType(Me.dgE1_Thu_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbTham_So, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTham_So.SuspendLayout()
        CType(Me.ddDuong_Thu_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kieu_Nhap_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbThong_Tin
        '
        Me.grbThong_Tin.Controls.Add(Me.btnThoat)
        Me.grbThong_Tin.Controls.Add(Me.cbMa_Tinh)
        Me.grbThong_Tin.Controls.Add(Me.UltraLabel5)
        Me.grbThong_Tin.Controls.Add(Me.dtpDen_Ngay)
        Me.grbThong_Tin.Controls.Add(Me.UltraLabel6)
        Me.grbThong_Tin.Controls.Add(Me.dtpTu_Ngay)
        Me.grbThong_Tin.Controls.Add(Me.optBuu_Ta_Noi_Bo)
        Me.grbThong_Tin.Controls.Add(Me.cbMa_Duong_Thu)
        Me.grbThong_Tin.Controls.Add(Me.optCac_Tinh)
        Me.grbThong_Tin.Controls.Add(Me.btnNhap_Moi)
        Me.grbThong_Tin.Controls.Add(Me.btnTham_So)
        Me.grbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThong_Tin.Location = New System.Drawing.Point(0, 8)
        Me.grbThong_Tin.Name = "grbThong_Tin"
        Me.grbThong_Tin.Size = New System.Drawing.Size(792, 80)
        Me.grbThong_Tin.SupportThemes = False
        Me.grbThong_Tin.TabIndex = 0
        Me.grbThong_Tin.Text = "Thông tin tìm kiếm (Click chuột phải vào tiêu đề cột để tìm kiếm trong danh sách " & _
        "   ;     Ấn F3 để tìm theo mã E1)"
        '
        'btnThoat
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnThoat.Appearance = Appearance1
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThoat.Location = New System.Drawing.Point(680, 24)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(104, 48)
        Me.btnThoat.TabIndex = 10
        Me.btnThoat.Text = "Th&oát"
        '
        'cbMa_Tinh
        '
        Me.cbMa_Tinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn1.Header.Caption = "Mã tỉnh"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên tỉnh"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.Caption = "Khu vực"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Thoả thuận"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.cbMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.cbMa_Tinh.DisplayMember = "Ten_Tinh"
        Me.cbMa_Tinh.Location = New System.Drawing.Point(296, 24)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(168, 24)
        Me.cbMa_Tinh.TabIndex = 5
        Me.cbMa_Tinh.ValueMember = "Ma_Tinh"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(8, 53)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel5.TabIndex = 2
        Me.UltraLabel5.Text = "Ðến ngày"
        '
        'dtpDen_Ngay
        '
        Me.dtpDen_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtpDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDen_Ngay.Location = New System.Drawing.Point(80, 51)
        Me.dtpDen_Ngay.Name = "dtpDen_Ngay"
        Me.dtpDen_Ngay.Size = New System.Drawing.Size(104, 24)
        Me.dtpDen_Ngay.TabIndex = 3
        Me.dtpDen_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 26)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel6.TabIndex = 0
        Me.UltraLabel6.Text = "Ngày đóng"
        '
        'dtpTu_Ngay
        '
        Me.dtpTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTu_Ngay.Location = New System.Drawing.Point(80, 24)
        Me.dtpTu_Ngay.Name = "dtpTu_Ngay"
        Me.dtpTu_Ngay.Size = New System.Drawing.Size(104, 24)
        Me.dtpTu_Ngay.TabIndex = 1
        Me.dtpTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'optBuu_Ta_Noi_Bo
        '
        Me.optBuu_Ta_Noi_Bo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBuu_Ta_Noi_Bo.Location = New System.Drawing.Point(198, 52)
        Me.optBuu_Ta_Noi_Bo.Name = "optBuu_Ta_Noi_Bo"
        Me.optBuu_Ta_Noi_Bo.Size = New System.Drawing.Size(96, 24)
        Me.optBuu_Ta_Noi_Bo.TabIndex = 6
        Me.optBuu_Ta_Noi_Bo.Text = "Bưu tá nội bộ"
        '
        'cbMa_Duong_Thu
        '
        Me.cbMa_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Đường thư"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(226, 0)
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridBand2.UseRowLayout = True
        Me.cbMa_Duong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Duong_Thu.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.cbMa_Duong_Thu.DisplayMember = "Ten_Duong_Thu"
        Me.cbMa_Duong_Thu.Location = New System.Drawing.Point(296, 51)
        Me.cbMa_Duong_Thu.Name = "cbMa_Duong_Thu"
        Me.cbMa_Duong_Thu.Size = New System.Drawing.Size(168, 24)
        Me.cbMa_Duong_Thu.TabIndex = 7
        Me.cbMa_Duong_Thu.ValueMember = "Id_Duong_Thu"
        '
        'optCac_Tinh
        '
        Me.optCac_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCac_Tinh.Location = New System.Drawing.Point(198, 25)
        Me.optCac_Tinh.Name = "optCac_Tinh"
        Me.optCac_Tinh.Size = New System.Drawing.Size(80, 24)
        Me.optCac_Tinh.TabIndex = 4
        Me.optCac_Tinh.Text = "Các tỉnh"
        '
        'btnNhap_Moi
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnNhap_Moi.Appearance = Appearance4
        Me.btnNhap_Moi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap_Moi.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNhap_Moi.Location = New System.Drawing.Point(472, 24)
        Me.btnNhap_Moi.Name = "btnNhap_Moi"
        Me.btnNhap_Moi.Size = New System.Drawing.Size(96, 48)
        Me.btnNhap_Moi.TabIndex = 8
        Me.btnNhap_Moi.Text = "Thông Tin &Nhập mới"
        '
        'btnTham_So
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnTham_So.Appearance = Appearance5
        Me.btnTham_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTham_So.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnTham_So.Location = New System.Drawing.Point(572, 24)
        Me.btnTham_So.Name = "btnTham_So"
        Me.btnTham_So.Size = New System.Drawing.Size(104, 48)
        Me.btnTham_So.TabIndex = 9
        Me.btnTham_So.Text = "&Thiết Lập Tham Số"
        '
        'btnTim_Theo_Ngay_Dong
        '
        Appearance6.Image = CType(resources.GetObject("Appearance6.Image"), Object)
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance6.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnTim_Theo_Ngay_Dong.Appearance = Appearance6
        Me.btnTim_Theo_Ngay_Dong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim_Theo_Ngay_Dong.ImageSize = New System.Drawing.Size(26, 26)
        Me.btnTim_Theo_Ngay_Dong.Location = New System.Drawing.Point(349, 8)
        Me.btnTim_Theo_Ngay_Dong.Name = "btnTim_Theo_Ngay_Dong"
        Me.btnTim_Theo_Ngay_Dong.Size = New System.Drawing.Size(96, 64)
        Me.btnTim_Theo_Ngay_Dong.TabIndex = 1
        Me.btnTim_Theo_Ngay_Dong.Text = "Tìm theo ==> ngày đóng"
        '
        'grbChi_Tiet
        '
        Me.grbChi_Tiet.Controls.Add(Me.btnXoa_E1_Thu_No)
        Me.grbChi_Tiet.Controls.Add(Me.dgE1_Thu_No)
        Me.grbChi_Tiet.Controls.Add(Me.btnTim_Theo_Ngay_Thu)
        Me.grbChi_Tiet.Controls.Add(Me.btnTim_Theo_Ngay_Dong)
        Me.grbChi_Tiet.Controls.Add(Me.UltraLabel1)
        Me.grbChi_Tiet.Controls.Add(Me.dtpNgay_Thu)
        Me.grbChi_Tiet.Controls.Add(Me.chkThu_No)
        Me.grbChi_Tiet.Controls.Add(Me.chkNo)
        Me.grbChi_Tiet.Controls.Add(Me.lblThong_Tin_Thu_No)
        Me.grbChi_Tiet.Controls.Add(Me.lblThong_Tin_No)
        Me.grbChi_Tiet.Controls.Add(Me.dgE1_No)
        Me.grbChi_Tiet.Controls.Add(Me.btnThu_Tien)
        Me.grbChi_Tiet.Location = New System.Drawing.Point(0, 88)
        Me.grbChi_Tiet.Name = "grbChi_Tiet"
        Me.grbChi_Tiet.Size = New System.Drawing.Size(792, 472)
        Me.grbChi_Tiet.SupportThemes = False
        Me.grbChi_Tiet.TabIndex = 1
        '
        'btnXoa_E1_Thu_No
        '
        Appearance7.Image = CType(resources.GetObject("Appearance7.Image"), Object)
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnXoa_E1_Thu_No.Appearance = Appearance7
        Me.btnXoa_E1_Thu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa_E1_Thu_No.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnXoa_E1_Thu_No.Location = New System.Drawing.Point(348, 368)
        Me.btnXoa_E1_Thu_No.Name = "btnXoa_E1_Thu_No"
        Me.btnXoa_E1_Thu_No.Size = New System.Drawing.Size(96, 64)
        Me.btnXoa_E1_Thu_No.TabIndex = 14
        Me.btnXoa_E1_Thu_No.Text = "Xoá chi tiết   thu nợ ==>"
        '
        'dgE1_Thu_No
        '
        Me.dgE1_Thu_No.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_Thu_No.DisplayLayout.AddNewBox.Prompt = " "
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Thu_No.DisplayLayout.Appearance = Appearance8
        UltraGridColumn9.Header.Caption = "Chọn"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(37, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Đường thư"
        UltraGridColumn13.Header.VisiblePosition = 6
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.VisiblePosition = 8
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Format = "dd/MM/yyyy"
        UltraGridColumn15.Header.Caption = "Ngày đóng"
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.MaskInput = ""
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Format = "hh:mm"
        UltraGridColumn16.Header.Caption = "Giờ đóng"
        UltraGridColumn16.Header.VisiblePosition = 7
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Mã Tỉnh"
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.MaskInput = ""
        UltraGridColumn17.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.VisiblePosition = 10
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.VisiblePosition = 12
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Nước nhận"
        UltraGridColumn20.Header.VisiblePosition = 13
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Mã E1"
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 15
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 16
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Khối lượng"
        UltraGridColumn25.Header.VisiblePosition = 11
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Phân loại"
        UltraGridColumn26.Header.VisiblePosition = 17
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.VisiblePosition = 18
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Header.VisiblePosition = 19
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.Caption = "Người gửi"
        UltraGridColumn29.Header.VisiblePosition = 20
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.Caption = "Người nhận"
        UltraGridColumn30.Header.VisiblePosition = 21
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn31.Header.VisiblePosition = 22
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn32.Header.VisiblePosition = 23
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Header.VisiblePosition = 24
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.VisiblePosition = 25
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.VisiblePosition = 26
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.VisiblePosition = 27
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.VisiblePosition = 28
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = "Số TKHQ"
        UltraGridColumn38.Header.VisiblePosition = 29
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.Caption = "Số biên lai"
        UltraGridColumn39.Header.VisiblePosition = 30
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Thuế NK"
        UltraGridColumn40.Header.VisiblePosition = 31
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.Caption = "Thuế VAT"
        UltraGridColumn41.Header.VisiblePosition = 32
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.VisiblePosition = 33
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 66
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.VisiblePosition = 34
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 68
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.VisiblePosition = 35
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 70
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Header.VisiblePosition = 36
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.VisiblePosition = 37
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Header.VisiblePosition = 38
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Header.Caption = "Lệ phí HQ"
        UltraGridColumn48.Header.VisiblePosition = 39
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.VisiblePosition = 40
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 80
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.VisiblePosition = 41
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 82
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.VisiblePosition = 42
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 84
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Header.VisiblePosition = 43
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 86
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.VisiblePosition = 44
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 88
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.VisiblePosition = 45
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 90
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.Caption = "Tổng phải thu"
        UltraGridColumn55.Header.VisiblePosition = 46
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 47
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 94
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Header.VisiblePosition = 48
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 96
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Header.VisiblePosition = 49
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 98
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.VisiblePosition = 50
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 100
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Format = "dd/MM/yyyy"
        UltraGridColumn60.Header.Caption = "Ngày thu 1"
        UltraGridColumn60.Header.VisiblePosition = 51
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.MaskInput = ""
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.Caption = "Số tiền 1"
        UltraGridColumn61.Header.VisiblePosition = 53
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Format = "dd/MM/yyyy"
        UltraGridColumn62.Header.Caption = "Ngày thu 2"
        UltraGridColumn62.Header.VisiblePosition = 55
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.MaskInput = ""
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.Caption = "Số tiền 2"
        UltraGridColumn63.Header.VisiblePosition = 56
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.VisiblePosition = 57
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.VisiblePosition = 58
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.Caption = "Số CT"
        UltraGridColumn66.Header.VisiblePosition = 52
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(49, 0)
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.Caption = "Túi số"
        UltraGridColumn67.Header.VisiblePosition = 54
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(46, 0)
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.Caption = "Tổng tiền thu"
        UltraGridColumn68.Header.VisiblePosition = 59
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68})
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgE1_Thu_No.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgE1_Thu_No.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Thu_No.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Thu_No.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Me.dgE1_Thu_No.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.ForeColor = System.Drawing.Color.Black
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Thu_No.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.dgE1_Thu_No.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance11.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Thu_No.DisplayLayout.Override.RowAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Thu_No.DisplayLayout.Override.RowSelectorAppearance = Appearance12
        Me.dgE1_Thu_No.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Thu_No.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Thu_No.DisplayLayout.Override.SelectedRowAppearance = Appearance13
        Me.dgE1_Thu_No.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Thu_No.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Thu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Thu_No.Location = New System.Drawing.Point(448, 8)
        Me.dgE1_Thu_No.Name = "dgE1_Thu_No"
        Me.dgE1_Thu_No.Size = New System.Drawing.Size(341, 424)
        Me.dgE1_Thu_No.TabIndex = 13
        Me.dgE1_Thu_No.Text = "Danh sách bưu phẩm đã thu nợ"
        '
        'btnTim_Theo_Ngay_Thu
        '
        Appearance14.Image = CType(resources.GetObject("Appearance14.Image"), Object)
        Appearance14.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance14.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnTim_Theo_Ngay_Thu.Appearance = Appearance14
        Me.btnTim_Theo_Ngay_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTim_Theo_Ngay_Thu.ImageSize = New System.Drawing.Size(24, 24)
        Me.btnTim_Theo_Ngay_Thu.Location = New System.Drawing.Point(349, 80)
        Me.btnTim_Theo_Ngay_Thu.Name = "btnTim_Theo_Ngay_Thu"
        Me.btnTim_Theo_Ngay_Thu.Size = New System.Drawing.Size(96, 64)
        Me.btnTim_Theo_Ngay_Thu.TabIndex = 2
        Me.btnTim_Theo_Ngay_Thu.Text = "Tìm theo ==> ngày thu nợ"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(348, 160)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "Ngày thu"
        '
        'dtpNgay_Thu
        '
        Me.dtpNgay_Thu.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpNgay_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_Thu.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_Thu.Location = New System.Drawing.Point(348, 184)
        Me.dtpNgay_Thu.Name = "dtpNgay_Thu"
        Me.dtpNgay_Thu.Size = New System.Drawing.Size(96, 23)
        Me.dtpNgay_Thu.TabIndex = 4
        Me.dtpNgay_Thu.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'chkThu_No
        '
        Me.chkThu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkThu_No.Location = New System.Drawing.Point(456, 440)
        Me.chkThu_No.Name = "chkThu_No"
        Me.chkThu_No.TabIndex = 11
        Me.chkThu_No.Text = "Chọn tất cả"
        '
        'chkNo
        '
        Me.chkNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNo.Location = New System.Drawing.Point(8, 440)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.TabIndex = 9
        Me.chkNo.Text = "Chọn tất cả"
        '
        'lblThong_Tin_Thu_No
        '
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Right
        Me.lblThong_Tin_Thu_No.Appearance = Appearance15
        Me.lblThong_Tin_Thu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin_Thu_No.Location = New System.Drawing.Point(576, 441)
        Me.lblThong_Tin_Thu_No.Name = "lblThong_Tin_Thu_No"
        Me.lblThong_Tin_Thu_No.Size = New System.Drawing.Size(208, 23)
        Me.lblThong_Tin_Thu_No.TabIndex = 12
        Me.lblThong_Tin_Thu_No.Text = "Tong_So / Tong_Tien"
        '
        'lblThong_Tin_No
        '
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Right
        Me.lblThong_Tin_No.Appearance = Appearance16
        Me.lblThong_Tin_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin_No.Location = New System.Drawing.Point(128, 441)
        Me.lblThong_Tin_No.Name = "lblThong_Tin_No"
        Me.lblThong_Tin_No.Size = New System.Drawing.Size(208, 23)
        Me.lblThong_Tin_No.TabIndex = 10
        Me.lblThong_Tin_No.Text = "Tong_So / Tong_Tien"
        '
        'dgE1_No
        '
        Me.dgE1_No.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_No.DisplayLayout.AddNewBox.Prompt = " "
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_No.DisplayLayout.Appearance = Appearance17
        UltraGridColumn69.Header.Caption = "Chọn"
        UltraGridColumn69.Header.VisiblePosition = 1
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(37, 0)
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn70.Header.VisiblePosition = 0
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn72.Header.VisiblePosition = 4
        UltraGridColumn72.Hidden = True
        UltraGridColumn72.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn72.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn72.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn72.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn73.Header.Caption = "Đường thư"
        UltraGridColumn73.Header.VisiblePosition = 6
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn73.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn73.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn73.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn74.Header.VisiblePosition = 8
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn74.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn74.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn74.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn75.Format = "dd/MM/yyyy"
        UltraGridColumn75.Header.Caption = "Ngày đóng"
        UltraGridColumn75.Header.VisiblePosition = 5
        UltraGridColumn75.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn75.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn75.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn75.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn76.Format = "hh:mm"
        UltraGridColumn76.Header.Caption = "Giờ đóng"
        UltraGridColumn76.Header.VisiblePosition = 7
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn76.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn76.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn76.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn76.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn77.Header.Caption = "Mã Tỉnh"
        UltraGridColumn77.Header.VisiblePosition = 9
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.MaskInput = ""
        UltraGridColumn77.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn77.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn77.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn77.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn77.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn77.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn78.Header.VisiblePosition = 10
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn78.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn78.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn78.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn79.Header.VisiblePosition = 12
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn79.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn79.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn79.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn80.Header.Caption = "Nước nhận"
        UltraGridColumn80.Header.VisiblePosition = 13
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.Header.VisiblePosition = 14
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.Header.Caption = "Mã E1"
        UltraGridColumn82.Header.VisiblePosition = 3
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(114, 0)
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.Header.VisiblePosition = 15
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.Header.VisiblePosition = 16
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.Header.Caption = "Khối lượng"
        UltraGridColumn85.Header.VisiblePosition = 11
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.Header.Caption = "Phân loại"
        UltraGridColumn86.Header.VisiblePosition = 17
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn86.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn86.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn86.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn87.Header.VisiblePosition = 18
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn87.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn87.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn87.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn88.Header.VisiblePosition = 19
        UltraGridColumn88.Hidden = True
        UltraGridColumn88.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn88.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn88.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn88.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn89.Header.Caption = "Người gửi"
        UltraGridColumn89.Header.VisiblePosition = 20
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn89.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn89.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn89.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn90.Header.Caption = "Người nhận"
        UltraGridColumn90.Header.VisiblePosition = 21
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn90.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn90.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn90.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn91.Header.VisiblePosition = 22
        UltraGridColumn91.Hidden = True
        UltraGridColumn91.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn91.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn91.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn91.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn92.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn92.Header.VisiblePosition = 23
        UltraGridColumn92.Hidden = True
        UltraGridColumn92.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn92.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn92.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn92.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn93.Header.VisiblePosition = 24
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn93.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn93.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn93.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn94.Header.VisiblePosition = 25
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn94.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn94.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn94.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn95.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn95.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn95.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn96.Header.VisiblePosition = 27
        UltraGridColumn96.Hidden = True
        UltraGridColumn96.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn96.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn96.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn96.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.Header.VisiblePosition = 28
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn98.Header.Caption = "Số TKHQ"
        UltraGridColumn98.Header.VisiblePosition = 29
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn98.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn98.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn98.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn99.Header.Caption = "Số biên lai"
        UltraGridColumn99.Header.VisiblePosition = 30
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn100.Header.Caption = "Thuế NK"
        UltraGridColumn100.Header.VisiblePosition = 31
        UltraGridColumn100.Hidden = True
        UltraGridColumn100.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn100.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn100.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn100.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn101.Header.Caption = "Thuế VAT"
        UltraGridColumn101.Header.VisiblePosition = 32
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn101.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn101.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn101.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn102.Header.VisiblePosition = 33
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.RowLayoutColumnInfo.OriginX = 66
        UltraGridColumn102.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn102.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn102.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn103.Header.VisiblePosition = 34
        UltraGridColumn103.Hidden = True
        UltraGridColumn103.RowLayoutColumnInfo.OriginX = 68
        UltraGridColumn103.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn103.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn103.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn104.Header.VisiblePosition = 35
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.RowLayoutColumnInfo.OriginX = 70
        UltraGridColumn104.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn104.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn104.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn105.Header.VisiblePosition = 36
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn105.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn105.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn105.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn106.Header.VisiblePosition = 37
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn106.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn106.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn106.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn107.Header.VisiblePosition = 38
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn107.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn107.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn107.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn108.Header.Caption = "Lệ phí HQ"
        UltraGridColumn108.Header.VisiblePosition = 39
        UltraGridColumn108.Hidden = True
        UltraGridColumn108.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn108.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn108.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn108.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn109.Header.VisiblePosition = 40
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.RowLayoutColumnInfo.OriginX = 80
        UltraGridColumn109.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn109.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn109.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.Header.VisiblePosition = 41
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.RowLayoutColumnInfo.OriginX = 82
        UltraGridColumn110.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn110.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn111.Header.VisiblePosition = 42
        UltraGridColumn111.Hidden = True
        UltraGridColumn111.RowLayoutColumnInfo.OriginX = 84
        UltraGridColumn111.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn111.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn111.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn112.Header.VisiblePosition = 43
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.RowLayoutColumnInfo.OriginX = 86
        UltraGridColumn112.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn112.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn112.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn113.Header.VisiblePosition = 44
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 88
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn114.Header.VisiblePosition = 45
        UltraGridColumn114.Hidden = True
        UltraGridColumn114.RowLayoutColumnInfo.OriginX = 90
        UltraGridColumn114.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn114.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn114.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn115.Header.Caption = "Tổng tiền"
        UltraGridColumn115.Header.VisiblePosition = 46
        UltraGridColumn115.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn115.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn115.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn115.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn116.Header.VisiblePosition = 47
        UltraGridColumn116.Hidden = True
        UltraGridColumn116.RowLayoutColumnInfo.OriginX = 94
        UltraGridColumn116.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn116.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn116.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn117.Header.VisiblePosition = 48
        UltraGridColumn117.Hidden = True
        UltraGridColumn117.RowLayoutColumnInfo.OriginX = 96
        UltraGridColumn117.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn117.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn117.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn118.Header.VisiblePosition = 49
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.RowLayoutColumnInfo.OriginX = 98
        UltraGridColumn118.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn118.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn118.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn119.Header.VisiblePosition = 50
        UltraGridColumn119.Hidden = True
        UltraGridColumn119.RowLayoutColumnInfo.OriginX = 100
        UltraGridColumn119.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn119.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn119.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn120.Header.Caption = "Số CT"
        UltraGridColumn120.Header.VisiblePosition = 51
        UltraGridColumn120.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn120.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn120.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(49, 0)
        UltraGridColumn120.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn120.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn121.Header.Caption = "Túi số"
        UltraGridColumn121.Header.VisiblePosition = 52
        UltraGridColumn121.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn121.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn121.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(46, 0)
        UltraGridColumn121.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn121.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgE1_No.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgE1_No.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_No.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_No.DisplayLayout.Override.CardAreaAppearance = Appearance18
        Me.dgE1_No.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.ForeColor = System.Drawing.Color.Black
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance19.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_No.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.dgE1_No.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance20.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_No.DisplayLayout.Override.RowAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance21.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_No.DisplayLayout.Override.RowSelectorAppearance = Appearance21
        Me.dgE1_No.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_No.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.dgE1_No.DisplayLayout.Override.SelectedRowAppearance = Appearance22
        Me.dgE1_No.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_No.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_No.Location = New System.Drawing.Point(3, 8)
        Me.dgE1_No.Name = "dgE1_No"
        Me.dgE1_No.Size = New System.Drawing.Size(341, 424)
        Me.dgE1_No.TabIndex = 0
        Me.dgE1_No.Text = "Danh sách bưu phẩm cần thu nợ"
        '
        'btnThu_Tien
        '
        Appearance23.ForeColor = System.Drawing.Color.Red
        Appearance23.Image = CType(resources.GetObject("Appearance23.Image"), Object)
        Appearance23.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance23.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnThu_Tien.Appearance = Appearance23
        Me.btnThu_Tien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThu_Tien.ImageSize = New System.Drawing.Size(60, 80)
        Me.btnThu_Tien.Location = New System.Drawing.Point(348, 216)
        Me.btnThu_Tien.Name = "btnThu_Tien"
        Me.btnThu_Tien.Size = New System.Drawing.Size(96, 128)
        Me.btnThu_Tien.TabIndex = 7
        Me.btnThu_Tien.Text = "Th&u Tiền"
        '
        'grbTham_So
        '
        Me.grbTham_So.Controls.Add(Me.chkTong_Tien_Can_Phai_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkSo_Bien_Lai_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkSo_TKHQ_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkNuoc_Nhan_No)
        Me.grbTham_So.Controls.Add(Me.chkSo_Bien_Lai_No)
        Me.grbTham_So.Controls.Add(Me.chkSo_TKHQ_No)
        Me.grbTham_So.Controls.Add(Me.chkThu_Lan_2)
        Me.grbTham_So.Controls.Add(Me.chkKhoi_Luong_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkKhoi_Luong_No)
        Me.grbTham_So.Controls.Add(Me.chkNgay_Thu_2)
        Me.grbTham_So.Controls.Add(Me.chkThu_Lan_1)
        Me.grbTham_So.Controls.Add(Me.chkNgay_Thu_1)
        Me.grbTham_So.Controls.Add(Me.chkLe_Phi_HQ_No)
        Me.grbTham_So.Controls.Add(Me.chkThue_VAT_No)
        Me.grbTham_So.Controls.Add(Me.chkThue_NK_No)
        Me.grbTham_So.Controls.Add(Me.UltraPictureBox1)
        Me.grbTham_So.Controls.Add(Me.chkDia_Chi_Nhan_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkNguoi_Nhan_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkTui_So_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkChuyen_Thu_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkDuong_Thu_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkNgay_Dong_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkDia_Chi_Nhan_No)
        Me.grbTham_So.Controls.Add(Me.chkNguoi_Nhan_No)
        Me.grbTham_So.Controls.Add(Me.chkTui_So_No)
        Me.grbTham_So.Controls.Add(Me.chkChuyen_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkDuong_Thu_No)
        Me.grbTham_So.Controls.Add(Me.chkNgay_Dong_No)
        Me.grbTham_So.Controls.Add(Me.lblTham_So_Thu_No)
        Me.grbTham_So.Controls.Add(Me.lblTham_So_No)
        Me.grbTham_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grbTham_So.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbTham_So.Location = New System.Drawing.Point(800, 136)
        Me.grbTham_So.Name = "grbTham_So"
        Me.grbTham_So.Size = New System.Drawing.Size(400, 432)
        Me.grbTham_So.SupportThemes = False
        Me.grbTham_So.TabIndex = 2
        Me.grbTham_So.Text = "Danh Sách Tham số"
        Me.grbTham_So.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'chkTong_Tien_Can_Phai_Thu_No
        '
        Me.chkTong_Tien_Can_Phai_Thu_No.Location = New System.Drawing.Point(224, 384)
        Me.chkTong_Tien_Can_Phai_Thu_No.Name = "chkTong_Tien_Can_Phai_Thu_No"
        Me.chkTong_Tien_Can_Phai_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkTong_Tien_Can_Phai_Thu_No.TabIndex = 28
        Me.chkTong_Tien_Can_Phai_Thu_No.Text = "Tổng tiền phải thu"
        '
        'chkSo_Bien_Lai_Thu_No
        '
        Me.chkSo_Bien_Lai_Thu_No.Location = New System.Drawing.Point(224, 264)
        Me.chkSo_Bien_Lai_Thu_No.Name = "chkSo_Bien_Lai_Thu_No"
        Me.chkSo_Bien_Lai_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkSo_Bien_Lai_Thu_No.TabIndex = 23
        Me.chkSo_Bien_Lai_Thu_No.Text = "Số biên lai"
        '
        'chkSo_TKHQ_Thu_No
        '
        Me.chkSo_TKHQ_Thu_No.Location = New System.Drawing.Point(224, 240)
        Me.chkSo_TKHQ_Thu_No.Name = "chkSo_TKHQ_Thu_No"
        Me.chkSo_TKHQ_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkSo_TKHQ_Thu_No.TabIndex = 22
        Me.chkSo_TKHQ_Thu_No.Text = "Số tờ khai HQ"
        '
        'chkNuoc_Nhan_No
        '
        Me.chkNuoc_Nhan_No.Location = New System.Drawing.Point(24, 240)
        Me.chkNuoc_Nhan_No.Name = "chkNuoc_Nhan_No"
        Me.chkNuoc_Nhan_No.Size = New System.Drawing.Size(152, 24)
        Me.chkNuoc_Nhan_No.TabIndex = 8
        Me.chkNuoc_Nhan_No.Text = "Nước gửi"
        '
        'chkSo_Bien_Lai_No
        '
        Me.chkSo_Bien_Lai_No.Location = New System.Drawing.Point(24, 288)
        Me.chkSo_Bien_Lai_No.Name = "chkSo_Bien_Lai_No"
        Me.chkSo_Bien_Lai_No.Size = New System.Drawing.Size(152, 24)
        Me.chkSo_Bien_Lai_No.TabIndex = 10
        Me.chkSo_Bien_Lai_No.Text = "Số biên lai"
        '
        'chkSo_TKHQ_No
        '
        Me.chkSo_TKHQ_No.Location = New System.Drawing.Point(24, 264)
        Me.chkSo_TKHQ_No.Name = "chkSo_TKHQ_No"
        Me.chkSo_TKHQ_No.Size = New System.Drawing.Size(152, 24)
        Me.chkSo_TKHQ_No.TabIndex = 9
        Me.chkSo_TKHQ_No.Text = "Số tờ khai HQ"
        '
        'chkThu_Lan_2
        '
        Me.chkThu_Lan_2.Location = New System.Drawing.Point(224, 360)
        Me.chkThu_Lan_2.Name = "chkThu_Lan_2"
        Me.chkThu_Lan_2.Size = New System.Drawing.Size(152, 24)
        Me.chkThu_Lan_2.TabIndex = 27
        Me.chkThu_Lan_2.Text = "Số tiền thu lần 2"
        '
        'chkKhoi_Luong_Thu_No
        '
        Me.chkKhoi_Luong_Thu_No.Location = New System.Drawing.Point(224, 216)
        Me.chkKhoi_Luong_Thu_No.Name = "chkKhoi_Luong_Thu_No"
        Me.chkKhoi_Luong_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkKhoi_Luong_Thu_No.TabIndex = 21
        Me.chkKhoi_Luong_Thu_No.Text = "Khối lượng"
        '
        'chkKhoi_Luong_No
        '
        Me.chkKhoi_Luong_No.Location = New System.Drawing.Point(24, 216)
        Me.chkKhoi_Luong_No.Name = "chkKhoi_Luong_No"
        Me.chkKhoi_Luong_No.Size = New System.Drawing.Size(152, 24)
        Me.chkKhoi_Luong_No.TabIndex = 7
        Me.chkKhoi_Luong_No.Text = "Khối lượng"
        '
        'chkNgay_Thu_2
        '
        Me.chkNgay_Thu_2.Location = New System.Drawing.Point(224, 336)
        Me.chkNgay_Thu_2.Name = "chkNgay_Thu_2"
        Me.chkNgay_Thu_2.Size = New System.Drawing.Size(152, 24)
        Me.chkNgay_Thu_2.TabIndex = 26
        Me.chkNgay_Thu_2.Text = "Ngày thu lần 2"
        '
        'chkThu_Lan_1
        '
        Me.chkThu_Lan_1.Location = New System.Drawing.Point(224, 312)
        Me.chkThu_Lan_1.Name = "chkThu_Lan_1"
        Me.chkThu_Lan_1.Size = New System.Drawing.Size(152, 24)
        Me.chkThu_Lan_1.TabIndex = 25
        Me.chkThu_Lan_1.Text = "Số tiền thu lần 1"
        '
        'chkNgay_Thu_1
        '
        Me.chkNgay_Thu_1.Location = New System.Drawing.Point(224, 288)
        Me.chkNgay_Thu_1.Name = "chkNgay_Thu_1"
        Me.chkNgay_Thu_1.Size = New System.Drawing.Size(152, 24)
        Me.chkNgay_Thu_1.TabIndex = 24
        Me.chkNgay_Thu_1.Text = "Ngày thu lần 1"
        '
        'chkLe_Phi_HQ_No
        '
        Me.chkLe_Phi_HQ_No.Location = New System.Drawing.Point(24, 360)
        Me.chkLe_Phi_HQ_No.Name = "chkLe_Phi_HQ_No"
        Me.chkLe_Phi_HQ_No.Size = New System.Drawing.Size(152, 24)
        Me.chkLe_Phi_HQ_No.TabIndex = 13
        Me.chkLe_Phi_HQ_No.Text = "Lệ phí HQ"
        '
        'chkThue_VAT_No
        '
        Me.chkThue_VAT_No.Location = New System.Drawing.Point(24, 336)
        Me.chkThue_VAT_No.Name = "chkThue_VAT_No"
        Me.chkThue_VAT_No.Size = New System.Drawing.Size(152, 24)
        Me.chkThue_VAT_No.TabIndex = 12
        Me.chkThue_VAT_No.Text = "Thuế VAT"
        '
        'chkThue_NK_No
        '
        Me.chkThue_NK_No.Location = New System.Drawing.Point(24, 312)
        Me.chkThue_NK_No.Name = "chkThue_NK_No"
        Me.chkThue_NK_No.Size = New System.Drawing.Size(152, 24)
        Me.chkThue_NK_No.TabIndex = 11
        Me.chkThue_NK_No.Text = "Thuế NK"
        '
        'UltraPictureBox1
        '
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.Empty
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(368, 2)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(32, 16)
        Me.UltraPictureBox1.TabIndex = 14
        '
        'chkDia_Chi_Nhan_Thu_No
        '
        Me.chkDia_Chi_Nhan_Thu_No.Location = New System.Drawing.Point(224, 192)
        Me.chkDia_Chi_Nhan_Thu_No.Name = "chkDia_Chi_Nhan_Thu_No"
        Me.chkDia_Chi_Nhan_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkDia_Chi_Nhan_Thu_No.TabIndex = 20
        Me.chkDia_Chi_Nhan_Thu_No.Text = "Địa chỉ nhận"
        '
        'chkNguoi_Nhan_Thu_No
        '
        Me.chkNguoi_Nhan_Thu_No.Location = New System.Drawing.Point(224, 168)
        Me.chkNguoi_Nhan_Thu_No.Name = "chkNguoi_Nhan_Thu_No"
        Me.chkNguoi_Nhan_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkNguoi_Nhan_Thu_No.TabIndex = 19
        Me.chkNguoi_Nhan_Thu_No.Text = "Người nhận"
        '
        'chkTui_So_Thu_No
        '
        Me.chkTui_So_Thu_No.Location = New System.Drawing.Point(224, 144)
        Me.chkTui_So_Thu_No.Name = "chkTui_So_Thu_No"
        Me.chkTui_So_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkTui_So_Thu_No.TabIndex = 18
        Me.chkTui_So_Thu_No.Text = "Túi số"
        '
        'chkChuyen_Thu_Thu_No
        '
        Me.chkChuyen_Thu_Thu_No.Location = New System.Drawing.Point(224, 120)
        Me.chkChuyen_Thu_Thu_No.Name = "chkChuyen_Thu_Thu_No"
        Me.chkChuyen_Thu_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkChuyen_Thu_Thu_No.TabIndex = 17
        Me.chkChuyen_Thu_Thu_No.Text = "Chuyến thư"
        '
        'chkDuong_Thu_Thu_No
        '
        Me.chkDuong_Thu_Thu_No.Location = New System.Drawing.Point(224, 96)
        Me.chkDuong_Thu_Thu_No.Name = "chkDuong_Thu_Thu_No"
        Me.chkDuong_Thu_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkDuong_Thu_Thu_No.TabIndex = 16
        Me.chkDuong_Thu_Thu_No.Text = "Đường thư"
        '
        'chkNgay_Dong_Thu_No
        '
        Me.chkNgay_Dong_Thu_No.Location = New System.Drawing.Point(224, 72)
        Me.chkNgay_Dong_Thu_No.Name = "chkNgay_Dong_Thu_No"
        Me.chkNgay_Dong_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkNgay_Dong_Thu_No.TabIndex = 15
        Me.chkNgay_Dong_Thu_No.Text = "Ngày đóng"
        '
        'chkDia_Chi_Nhan_No
        '
        Me.chkDia_Chi_Nhan_No.Location = New System.Drawing.Point(24, 192)
        Me.chkDia_Chi_Nhan_No.Name = "chkDia_Chi_Nhan_No"
        Me.chkDia_Chi_Nhan_No.Size = New System.Drawing.Size(152, 24)
        Me.chkDia_Chi_Nhan_No.TabIndex = 6
        Me.chkDia_Chi_Nhan_No.Text = "Địa chỉ nhận"
        '
        'chkNguoi_Nhan_No
        '
        Me.chkNguoi_Nhan_No.Location = New System.Drawing.Point(24, 168)
        Me.chkNguoi_Nhan_No.Name = "chkNguoi_Nhan_No"
        Me.chkNguoi_Nhan_No.Size = New System.Drawing.Size(152, 24)
        Me.chkNguoi_Nhan_No.TabIndex = 5
        Me.chkNguoi_Nhan_No.Text = "Người nhận"
        '
        'chkTui_So_No
        '
        Me.chkTui_So_No.Location = New System.Drawing.Point(24, 144)
        Me.chkTui_So_No.Name = "chkTui_So_No"
        Me.chkTui_So_No.Size = New System.Drawing.Size(152, 24)
        Me.chkTui_So_No.TabIndex = 4
        Me.chkTui_So_No.Text = "Túi số"
        '
        'chkChuyen_Thu_No
        '
        Me.chkChuyen_Thu_No.Location = New System.Drawing.Point(24, 120)
        Me.chkChuyen_Thu_No.Name = "chkChuyen_Thu_No"
        Me.chkChuyen_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkChuyen_Thu_No.TabIndex = 3
        Me.chkChuyen_Thu_No.Text = "Chuyến thư"
        '
        'chkDuong_Thu_No
        '
        Me.chkDuong_Thu_No.Location = New System.Drawing.Point(24, 96)
        Me.chkDuong_Thu_No.Name = "chkDuong_Thu_No"
        Me.chkDuong_Thu_No.Size = New System.Drawing.Size(152, 24)
        Me.chkDuong_Thu_No.TabIndex = 2
        Me.chkDuong_Thu_No.Text = "Đường thư"
        '
        'chkNgay_Dong_No
        '
        Me.chkNgay_Dong_No.Location = New System.Drawing.Point(24, 72)
        Me.chkNgay_Dong_No.Name = "chkNgay_Dong_No"
        Me.chkNgay_Dong_No.Size = New System.Drawing.Size(152, 24)
        Me.chkNgay_Dong_No.TabIndex = 1
        Me.chkNgay_Dong_No.Text = "Ngày đóng"
        '
        'lblTham_So_Thu_No
        '
        Appearance24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTham_So_Thu_No.Appearance = Appearance24
        Me.lblTham_So_Thu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTham_So_Thu_No.Location = New System.Drawing.Point(224, 40)
        Me.lblTham_So_Thu_No.Name = "lblTham_So_Thu_No"
        Me.lblTham_So_Thu_No.Size = New System.Drawing.Size(152, 23)
        Me.lblTham_So_Thu_No.TabIndex = 14
        Me.lblTham_So_Thu_No.Text = "Tham số E1 Thu Nợ"
        '
        'lblTham_So_No
        '
        Appearance25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTham_So_No.Appearance = Appearance25
        Me.lblTham_So_No.BackColor = System.Drawing.SystemColors.Control
        Me.lblTham_So_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTham_So_No.Location = New System.Drawing.Point(24, 40)
        Me.lblTham_So_No.Name = "lblTham_So_No"
        Me.lblTham_So_No.Size = New System.Drawing.Size(152, 23)
        Me.lblTham_So_No.TabIndex = 0
        Me.lblTham_So_No.Text = "Tham số E1 Nợ"
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
        'ddDuong_Thu_Di
        '
        Me.ddDuong_Thu_Di.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDuong_Thu_Di.DisplayLayout.Appearance = Appearance26
        UltraGridColumn122.Header.VisiblePosition = 0
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 2
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.Caption = "Mã BC"
        UltraGridColumn124.Header.VisiblePosition = 1
        UltraGridColumn124.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn125.Header.Caption = "Tên Đường Thư"
        UltraGridColumn125.Header.VisiblePosition = 3
        UltraGridColumn125.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(149, 0)
        UltraGridColumn126.Header.VisiblePosition = 4
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 5
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 6
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 7
        UltraGridColumn129.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129})
        UltraGridBand5.UseRowLayout = True
        Me.ddDuong_Thu_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance27.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.ForeColor = System.Drawing.Color.Black
        Appearance27.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDuong_Thu_Di.DisplayLayout.Override.HeaderAppearance = Appearance27
        Me.ddDuong_Thu_Di.DisplayMember = "Ma_Bc"
        Me.ddDuong_Thu_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDuong_Thu_Di.Location = New System.Drawing.Point(848, 16)
        Me.ddDuong_Thu_Di.Name = "ddDuong_Thu_Di"
        Me.ddDuong_Thu_Di.Size = New System.Drawing.Size(208, 128)
        Me.ddDuong_Thu_Di.TabIndex = 43
        Me.ddDuong_Thu_Di.ValueMember = "Id_Duong_Thu"
        Me.ddDuong_Thu_Di.Visible = False
        '
        'Kieu_Nhap_Ngay
        '
        Me.Kieu_Nhap_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.Kieu_Nhap_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.Kieu_Nhap_Ngay.Location = New System.Drawing.Point(1072, 56)
        Me.Kieu_Nhap_Ngay.Name = "Kieu_Nhap_Ngay"
        Me.Kieu_Nhap_Ngay.Size = New System.Drawing.Size(104, 21)
        Me.Kieu_Nhap_Ngay.TabIndex = 44
        Me.Kieu_Nhap_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.Kieu_Nhap_Ngay.Visible = False
        '
        'Frm_Quan_Ly_Thu_No_Hai_Quan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1224, 725)
        Me.Controls.Add(Me.grbThong_Tin)
        Me.Controls.Add(Me.grbChi_Tiet)
        Me.Controls.Add(Me.grbTham_So)
        Me.Controls.Add(Me.ddDuong_Thu_Di)
        Me.Controls.Add(Me.Kieu_Nhap_Ngay)
        Me.KeyPreview = True
        Me.Name = "Frm_Quan_Ly_Thu_No_Hai_Quan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý thu nợ thuế và lệ phí Hải quan"
        CType(Me.grbThong_Tin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbThong_Tin.ResumeLayout(False)
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbChi_Tiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbChi_Tiet.ResumeLayout(False)
        CType(Me.dgE1_Thu_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbTham_So, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTham_So.ResumeLayout(False)
        CType(Me.ddDuong_Thu_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kieu_Nhap_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai_Báo_Biến_Toàn_Form"
    Private myE1_No_Le_Phi_HQ As New E1_No_Le_Phi_HQ(GConnectionString)
    Private myE1_Thu_No_Le_Phi_HQ As New E1_Thu_No_Le_Phi_HQ(GConnectionString)
    Private myMa_Tinh As New Ma_Tinh(GConnectionString)
    Private myDuong_Thu_Buu_Ta_Noi_Bo As New Duong_Thu_Buu_Ta_Noi_Bo(GConnectionString)
    Private myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Private myHam_Dung_Chung As New Ham_Dung_Chung

    Private myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private FrmTK As FrmTimKiemDanhMuc = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    Private idx As Integer
    Private myCho_Phep_Update As Boolean
    Private myDong_Update As Integer
    Private myColumne_Active As String
#End Region

#Region "Frm_Quan_Ly_Thu_No_Hai_Quan_Load"
    Private Sub Frm_Quan_Ly_Thu_No_Hai_Quan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 600
        Me.Width = 800
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        myCho_Phep_Update = False
        Init_Form()
        Transparent_Control()
        grbTham_So.BringToFront()
        grbTham_So.Visible = False
        'Ẩn chức năng
        btnThu_Tien.Enabled = False
        '-----------------------------------
        optCac_Tinh.Checked = False
        cbMa_Tinh.Enabled = False
        optBuu_Ta_Noi_Bo.Checked = True
        cbMa_Duong_Thu.Enabled = True
        dtpTu_Ngay.Select()
    End Sub
#End Region

#Region "Frm_Quan_Ly_Thu_No_Hai_Quan_KeyDown"
    Private Sub Frm_Quan_Ly_Thu_No_Hai_Quan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim mMa_E1 As String
        Dim mXpos As Integer
        Dim mYpos As Integer
        If e.KeyValue = Keys.F3 Then
            'btnThu_Tien.Enabled = False
            mXpos = Me.Left + 200
            mYpos = Me.Top + 200
            mMa_E1 = InputBox("Nhập mã E1 (Tối thiểu 6 ký tự, tối đa 13 ký tự):  ", "Thông tin E1 cần tìm kiếm", "", mXpos, mYpos)
            ''Cho câu lệnh này vào vì chưa dùng chức năng này
            'MessageBox.Show("Chức năng này chưa hoàn thiện, mời bạn quay lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
            '-----------------------------------------------------------------
            If mMa_E1.Length = 0 Then
                MessageBox.Show("Tìm kiếm đã bị huỷ bỏ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'btnThu_Tien.Enabled = True
            ElseIf mMa_E1.Length < 6 Or mMa_E1.Length > 13 Then
                MessageBox.Show("Mã E1 nhập vào không hợp lệ, tối thiểu 6 ký tự , tối đa 13 ký tự!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'btnThu_Tien.Enabled = True
            Else
                DataGrid_E1_No_Theo_Ma_E1(False, mMa_E1)
                DataGrid_E1_Thu_No_Theo_Ma_E1(False, mMa_E1)
                If dgE1_No.Rows.Count > 0 Then
                    btnThu_Tien.Enabled = True
                Else
                    If dgE1_Thu_No.Rows.Count = 0 Then
                        MessageBox.Show("Không tìm thấy thông tin về bưu phẩm này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    '  btnThu_Tien.Enabled = True
                End If
            End If
        End If
    End Sub
#End Region

#Region "Tab_Control"

#Region "Open_Tham_So"
    Private Sub btnTham_So_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTham_So.Click
        Enable_Visble_Tham_So(True)
    End Sub
#End Region

#Region "Close_Tham_So"
    Private Sub UltraPictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraPictureBox1.Click
        Enable_Visble_Tham_So(False)
    End Sub
#End Region

#Region "optCac_Tinh_CheckedChanged"
    Private Sub optCac_Tinh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCac_Tinh.CheckedChanged
        cbMa_Tinh.Enabled = optCac_Tinh.Checked
        If optCac_Tinh.Checked Then
            If cbMa_Tinh.Rows.Count > 0 Then
                cbMa_Tinh.Value = cbMa_Tinh.Rows(0).Cells("Ma_Tinh").Value
            End If
            cbMa_Tinh.PerformAction(UltraComboAction.ToggleDropdown)
        End If
    End Sub
#End Region

#Region "optBuu_Ta_Noi_Bo_CheckedChanged"
    Private Sub optBuu_Ta_Noi_Bo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBuu_Ta_Noi_Bo.CheckedChanged
        cbMa_Duong_Thu.Enabled = optBuu_Ta_Noi_Bo.Checked
        If optBuu_Ta_Noi_Bo.Checked Then
            If cbMa_Duong_Thu.Rows.Count > 0 Then
                cbMa_Duong_Thu.Value = cbMa_Duong_Thu.Rows(0).Cells("Id_Duong_Thu").Value
            End If
            cbMa_Duong_Thu.PerformAction(UltraComboAction.ToggleDropdown)
        End If
    End Sub
#End Region

#Region "dtpTu_Ngay_GotFocus"
    Private Sub dtpTu_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTu_Ngay.GotFocus
        dtpTu_Ngay.SelectionStart = 0
        dtpTu_Ngay.SelectionLength = dtpTu_Ngay.Text.Length
    End Sub
#End Region

#Region "dtpDen_Ngay_GotFocus"
    Private Sub dtpDen_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDen_Ngay.GotFocus
        dtpDen_Ngay.SelectionStart = 0
        dtpDen_Ngay.SelectionLength = dtpDen_Ngay.Text.Length
    End Sub
#End Region

#Region "dtpNgay_Thu_GotFocus"
    Private Sub dtpNgay_Thu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgay_Thu.GotFocus
        dtpNgay_Thu.SelectionStart = 0
        dtpNgay_Thu.SelectionLength = dtpNgay_Thu.Text.Length
    End Sub
#End Region

#Region "btnNhap_Moi_Click"
    Private Sub btnNhap_Moi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Moi.Click
        'Kiem tra thong tin tim kiem
        If dtpTu_Ngay.Value > dtpDen_Ngay.Value Then
            MessageBox.Show("Thông tin ngày đóng không hợp lệ, từ ngày không được lớn hơn đến ngày.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTu_Ngay.Select()
            Exit Sub
        End If
        If optCac_Tinh.Checked Then
            If cbMa_Tinh.Value = Nothing Or cbMa_Tinh.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn mã tỉnh cần nhập thông tin thu nợ. Mời bạn chọn 1 tỉnh trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Tinh.Select()
                If Not cbMa_Tinh.IsDroppedDown Then
                    cbMa_Tinh.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        If optBuu_Ta_Noi_Bo.Checked Then
            If cbMa_Duong_Thu.Value = Nothing Or cbMa_Duong_Thu.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn đường thư bưu tá nội bộ cần nhập thông tin thu nợ. Mời bạn chọn 1 đường thư trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Duong_Thu.Select()
                If Not cbMa_Duong_Thu.IsDroppedDown Then
                    cbMa_Duong_Thu.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        'Lấy dữ liệu và load lên lưới E1_No, Xoá trống lưới E1_Thu_No
        DataGrid_E1_No(False)
        DataGrid_E1_Thu_No(False, True)
        'Lấy lại giá trị default cho ngày thu = ngày hiện tại
        dtpNgay_Thu.Value = Now.Date()
        'Kiem tra nếu có dữ liệu thì cho hiện các chức năng
        If dgE1_No.Rows.Count > 0 Then
            btnThu_Tien.Enabled = True
        Else
            MessageBox.Show("Không có dữ liệu theo yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnThu_Tien.Enabled = False
        End If
    End Sub
#End Region

#Region "btnTim_Theo_Ngay_Dong_Click"
    Private Sub btnTim_Theo_Ngay_Dong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim_Theo_Ngay_Dong.Click
        'Kiem tra thong tin tim kiem
        If dtpTu_Ngay.Value > dtpDen_Ngay.Value Then
            MessageBox.Show("Thông tin ngày đóng không hợp lệ, từ ngày không được lớn hơn đến ngày.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpTu_Ngay.Select()
            Exit Sub
        End If
        If optCac_Tinh.Checked Then
            If cbMa_Tinh.Value = Nothing Or cbMa_Tinh.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn mã tỉnh cần nhập thông tin thu nợ. Mời bạn chọn 1 tỉnh trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Tinh.Select()
                If Not cbMa_Tinh.IsDroppedDown Then
                    cbMa_Tinh.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        If optBuu_Ta_Noi_Bo.Checked Then
            If cbMa_Duong_Thu.Value = Nothing Or cbMa_Duong_Thu.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn đường thư bưu tá nội bộ cần nhập thông tin thu nợ. Mời bạn chọn 1 đường thư trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Duong_Thu.Select()
                If Not cbMa_Duong_Thu.IsDroppedDown Then
                    cbMa_Duong_Thu.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        'Lấy dữ liệu và load lên 2 lưới
        'DataGrid_E1_No(False)
        DataGrid_E1_Thu_No(False, False)
        'Kiem tra nếu có dữ liệu thì cho hiện các chức năng
        If dgE1_Thu_No.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu theo yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Ẩn nút thu nợ đối với chức năng tìm kiếm
        btnThu_Tien.Enabled = False
        'Bỏ tích chkALL        
        If chkThu_No.Checked Then
            chkThu_No.Checked = False
        End If
    End Sub
#End Region

#Region "btnTim_Theo_Ngay_Thu_Click"
    Private Sub btnTim_Theo_Ngay_Thu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTim_Theo_Ngay_Thu.Click
        'Kiem tra thong tin tim kiem
        If Not IsDate(dtpNgay_Thu.Value) Then
            MessageBox.Show("Thông tin ngày thu không hợp lệ. Mời bạn nhập lại thông tin ngày thu cần tìm kiếm.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpNgay_Thu.Select()
            Exit Sub
        End If
        If optCac_Tinh.Checked Then
            If cbMa_Tinh.Value = Nothing Or cbMa_Tinh.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn mã tỉnh cần nhập thông tin thu nợ. Mời bạn chọn 1 tỉnh trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Tinh.Select()
                If Not cbMa_Tinh.IsDroppedDown Then
                    cbMa_Tinh.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        If optBuu_Ta_Noi_Bo.Checked Then
            If cbMa_Duong_Thu.Value = Nothing Or cbMa_Duong_Thu.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn đường thư bưu tá nội bộ cần nhập thông tin thu nợ. Mời bạn chọn 1 đường thư trong danh sách.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbMa_Duong_Thu.Select()
                If Not cbMa_Duong_Thu.IsDroppedDown Then
                    cbMa_Duong_Thu.PerformAction(UltraComboAction.ToggleDropdown)
                End If
                Exit Sub
            End If
        End If
        'Lấy dữ liệu và load lên lưới E1_Thu_No, xoá trắng lưới E1_No
        'DataGrid_E1_No(True)
        DataGrid_E1_Thu_No(True, False)
        'Kiem tra nếu có dữ liệu thì cho hiện các chức năng
        If dgE1_Thu_No.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu theo yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Ẩn nút thu nợ đối với chức năng tìm kiếm
        btnThu_Tien.Enabled = False
        'Bỏ tích chkALL        
        If chkThu_No.Checked Then
            chkThu_No.Checked = False
        End If
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnThu_Tien_Click"
    Private Sub btnThu_Tien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThu_Tien.Click
        Try
            Dim mSo_Dong_Thu_No As Integer
            Dim mSo_Dong_Chon As Integer
            Dim mId_E1 As String
            Dim mE1_Thu_No_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet
            Dim mE1_No_Chi_Tiet As New E1_No_Le_Phi_HQ_Chi_Tiet
            mSo_Dong_Thu_No = 0
            mSo_Dong_Chon = 0
            'Kiem tra
            If Not IsDate(dtpNgay_Thu.Value) Then
                MessageBox.Show("Ngày thu không đúng định dạng. Mời bạn nhập thông tin ngày thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpNgay_Thu.Select()
                Exit Sub
            End If
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Thu.Value) < myHam_Dung_Chung.ConvertDateToInt(Now.Date) Then
                If Not MessageBox.Show("Ngày thu nhỏ hơn ngày hiện tại. Bạn có chắc chắn muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    dtpNgay_Thu.Select()
                    Exit Sub
                End If
            End If
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Thu.Value) > myHam_Dung_Chung.ConvertDateToInt(Now.Date) Then
                If Not MessageBox.Show("Ngày thu lớn hơn ngày hiện tại. Bạn có chắc chắn muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    dtpNgay_Thu.Select()
                    Exit Sub
                End If
            End If
            'Bat dau thu no
            'Xu_Ly_Thu_No:
            For idx = 0 To dgE1_No.Rows.Count - 1
                If idx = dgE1_No.Rows.Count Then
                    Exit For
                End If
                If dgE1_No.Rows(idx).Cells("Chon").Value Then
                    'Chuyen den row xu ly
                    dgE1_No.ActiveRow = dgE1_No.Rows(idx)
                    'Khoi tao bien
                    mSo_Dong_Chon = mSo_Dong_Chon + 1
                    mId_E1 = dgE1_No.Rows(idx).Cells("Id_E1").Value
                    'Lay thong tin kiem tra trong E1_Thu_No
                    mE1_Thu_No_Chi_Tiet = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Lay(mId_E1)
                    'Da ton tai chi tiet thu no
                    If mE1_Thu_No_Chi_Tiet.Ma_E1 <> "" Then
                        'Chi tiet co thu
                        If mE1_Thu_No_Chi_Tiet.Co_Thu Then
                            MessageBox.Show("Bưu phẩm  : ===" & dgE1_No.Rows(idx).Cells("Ma_E1").Value & "=== đã tồn tại chi tiết thu nợ rồi. Bạn không thể thêm vào nữa." & vbNewLine & "Hãy kiểm tra thật kỹ và xử lý theo những trường hợp sau:" & vbNewLine & _
                                                "- Nếu bưu phẩm này là thu tiền lần 2 thì bạn hãy tìm trong danh sách đã thu nợ, sau đó nhập ngày thu và số tiền thu lần 2." & vbNewLine & "- Nếu bạn muốn cập nhật lại chi tiết thu nợ này thì bạn phải tìm trong danh sách đã thu nợ và xoá chi tiết đã thu nợ đó đi, sau đó tiến hành thu nợ bình thường.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else    'Chi tiet chuyen hoan
                            MessageBox.Show("Bưu phẩm này đã tồn tại chi tiết chuyển hoàn. Đây là lỗi phát sinh do nhiều lý do!!!" & "Đề nghị bạn ghi lại số hiệu E1 này vào thông báo cho người quản trị hệ thống biết, nếu không rất có thể sẽ phát sinh các lỗi về sau.", "Cảnh báo cao nhất", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        dgE1_No.Rows(idx).Cells("Chon").Value = False
                    Else  'Chua ton tai chi tiet thu no
                        mSo_Dong_Thu_No = mSo_Dong_Thu_No + 1
                        'Cap nhat thu no
                        'Them 1 dong moi vao luoi
                        AddNewRow(dgE1_Thu_No, False)
                        'Lay thong tin chi tiet trong E1_No
                        mE1_No_Chi_Tiet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Lay(mId_E1)
                        'Gan thong tin vao luoi E1_Thu_No
                        Gan_Thong_Tin_Vao_Luoi_E1_Thu_No(dgE1_Thu_No.Rows.Count - 1, mE1_No_Chi_Tiet, dgE1_No.Rows(idx).Cells("So_Chuyen_Thu").Text, dgE1_No.Rows(idx).Cells("Tui_So").Text)
                        'AddNewRow(dgE1_Thu_No, True)
                        'Them vao Database
                        Them_Vao_E1_Thu_No_Lay_Thong_Tin_Tu_E1_No(mE1_No_Chi_Tiet)
                        'Xoá trên lưới E1 nợ
                        dgE1_No.Rows(idx).Delete(False)
                        'Refresh thong tin
                        Calculate_E1_No_Le_Phi_HQ()
                        Calculate_E1_Thu_No_Le_Phi_HQ()
                        'dgE1_No.Refresh()
                        Application.DoEvents()
                        'Quay lai vong for (vì xoá dòng trên lưới sẽ làm thay đổi index)
                        idx = idx - 1
                        'GoTo Xu_Ly_Thu_No
                    End If
                End If
                Application.DoEvents()
            Next
            'Thông báo kết quả
            'Nếu không dòng nào được chọn
            If mSo_Dong_Chon = 0 Then
                MessageBox.Show("Bạn chưa chọn bưu phẩm nào trong danh sách cần thu nợ. Mời bạn chọn bằng cách tích vào ô chọn tương ứng trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else    'Thông báo số dòng chi tiết đã cập nhật thành công
                MessageBox.Show("Đã cập nhật thành công ===" & mSo_Dong_Thu_No.ToString & " === chi tiết thu nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'Refresh thong tin
            Calculate_E1_No_Le_Phi_HQ()
            Calculate_E1_Thu_No_Le_Phi_HQ()
            'Bỏ tích chkALL
            If chkNo.Checked Then
                chkNo.Checked = False
            End If
            If chkThu_No.Checked Then
                chkThu_No.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(idx.ToString & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnXoa_E1_Thu_No_Click"
    Private Sub btnXoa_E1_Thu_No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa_E1_Thu_No.Click
        Dim mSo_Dong_Chon As Integer
        Dim mSo_Dong_Xoa As Integer
        Dim mId_E1_Thu_No As String
        mSo_Dong_Chon = 0
        For idx = 0 To dgE1_Thu_No.Rows.Count - 1
            If dgE1_Thu_No.Rows(idx).Cells("Chon").Value Then
                mSo_Dong_Chon = mSo_Dong_Chon + 1
            End If
        Next
        If mSo_Dong_Chon = 0 Then
            MessageBox.Show("Bạn chưa chọn chi tiết thu nợ cần xoá. Mời bạn chọn bằng cách tích vào ô chọn tương ứng cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            mSo_Dong_Xoa = 0
            If MessageBox.Show("Bạn có chắc chắn muốn xoá === " & mSo_Dong_Chon.ToString & " === dòng dữ liệu không ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                'Xoa_Tung_Dong_Chi_Tiet_Thu_No:
                For idx = 0 To dgE1_Thu_No.Rows.Count - 1
                    If idx = dgE1_Thu_No.Rows.Count Then
                        Exit For
                    End If
                    If dgE1_Thu_No.Rows(idx).Cells("Chon").Value Then
                        'Lấy Id_E1 cần xoá
                        mId_E1_Thu_No = dgE1_Thu_No.Rows(idx).Cells("Id_E1").Value
                        'Xoá trong Database
                        myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Xoa(mId_E1_Thu_No)
                        'Xoá trên lưới
                        dgE1_Thu_No.Rows(idx).Delete(False)
                        'Tính toán lại thong tin sau khi xoá
                        Calculate_E1_Thu_No_Le_Phi_HQ()
                        'Tăng thêm 1
                        mSo_Dong_Xoa = mSo_Dong_Xoa + 1
                        'Quay lai idx 1 don vi
                        idx = idx - 1
                        Application.DoEvents()
                        'Quay lại từ đầu
                        'GoTo Xoa_Tung_Dong_Chi_Tiet_Thu_No
                    End If
                    Application.DoEvents()
                Next
                If mSo_Dong_Xoa = mSo_Dong_Chon Then
                    MessageBox.Show("Đã xoá thành công === " & mSo_Dong_Xoa.ToString & " === dòng dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Đã xoá thành công === " & mSo_Dong_Xoa.ToString & " === dòng dữ liệu!!!" & vbNewLine & (mSo_Dong_Chon - mSo_Dong_Xoa).ToString & " không xoá được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Tính toán lại thong tin sau khi xoá
                Calculate_E1_Thu_No_Le_Phi_HQ()
            Else
                MessageBox.Show("Delete Not Complete!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Bỏ tích chkALL
        If chkThu_No.Checked Then
            chkThu_No.Checked = False
        End If
    End Sub
#End Region

#Region "chkNo_CheckedChanged"
    Private Sub chkNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNo.CheckedChanged
        For idx = 0 To dgE1_No.Rows.Count - 1
            dgE1_No.Rows(idx).Cells("Chon").Value = chkNo.Checked
        Next
    End Sub
#End Region

#Region "chkThu_No_CheckedChanged"
    Private Sub chkThu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThu_No.CheckedChanged
        For idx = 0 To dgE1_Thu_No.Rows.Count - 1
            dgE1_Thu_No.Rows(idx).Cells("Chon").Value = chkThu_No.Checked
        Next
    End Sub
#End Region

#Region "==================dgE1_No================"

#Region "dgE1_No_InitializeLayout"
    Private Sub dgE1_No_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_No.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
        Next
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Style = ColumnStyle.DropDownValidate
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").ValueList = ddDuong_Thu_Di
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
        Calculate_E1_No_Le_Phi_HQ()
    End Sub
#End Region

#End Region

#Region "=================dgE1_Thu_No==================="
#Region "dgE1_Thu_No_InitializeLayout"
    Private Sub dgE1_Thu_No_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Thu_No.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        'myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom

        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
        Next
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Style = ColumnStyle.DropDownValidate
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").ValueList = ddDuong_Thu_Di
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Thu_1").EditorControl = Kieu_Nhap_Ngay
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Thu_2").EditorControl = Kieu_Nhap_Ngay

        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Thu_1").CellActivation = Activation.AllowEdit
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_Lan_1").CellActivation = Activation.AllowEdit
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_Thu_2").CellActivation = Activation.AllowEdit
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thu_Lan_2").CellActivation = Activation.AllowEdit

        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
        Calculate_E1_Thu_No_Le_Phi_HQ()
    End Sub
#End Region

#Region "dgE1_Thu_No_AfterRowUpdate"
    Private Sub dgE1_Thu_No_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1_Thu_No.AfterRowUpdate
        Try
            myDong_Update = dgE1_Thu_No.ActiveRow.Index
            If myCho_Phep_Update Then
                'Kiem tra tinh hop le
                If Kiem_Tra_Thong_Tin_Cap_Nhat_Chi_Tiet_Thu_No() Then
                    Dim So_Tien_1 As Integer
                    Dim So_Tien_2 As Integer
                    Dim Ngay_Thu_1 As Integer
                    Dim Ngay_Thu_2 As Integer
                    Dim mId_E1 As String
                    'Id_E1
                    mId_E1 = dgE1_Thu_No.ActiveRow.Cells("Id_E1").Value
                    'Tien
                    If IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value) Then
                        So_Tien_1 = dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value
                    Else
                        So_Tien_1 = 0
                    End If
                    If IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value) Then
                        So_Tien_2 = dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value
                    Else
                        So_Tien_2 = 0
                    End If
                    'Ngay thu
                    If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) Then
                        Ngay_Thu_1 = myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value)
                    Else
                        Ngay_Thu_1 = 0
                    End If
                    If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) Then
                        Ngay_Thu_2 = myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value)
                    Else
                        Ngay_Thu_2 = 0
                    End If
                    'Cap nhat
                    myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Ngay_Thu_So_Tien_Thu(mId_E1, So_Tien_1, Ngay_Thu_1, So_Tien_2, Ngay_Thu_2)
                    'Gán lại tổng tiền thu được                    
                    dgE1_Thu_No.ActiveRow.Cells("Tong_Tien_Thu").Value = So_Tien_1 + So_Tien_2
                    'Refresh lại thông tin
                    Calculate_E1_Thu_No_Le_Phi_HQ()
                End If
                myCho_Phep_Update = False
            End If
        Catch ex As Exception
            myCho_Phep_Update = False
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Thu_No_BeforeRowUpdate"
    Private Sub dgE1_Thu_No_BeforeRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableRowEventArgs) Handles dgE1_Thu_No.BeforeRowUpdate
        Try
            Dim mE1_Thu_No_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet
            Dim mNgay_Thu_1 As Integer
            Dim mNgay_Thu_2 As Integer
            Dim mThu_Lan_1 As Integer
            Dim mThu_Lan_2 As Integer
            'Lay thong tin trong database
            mE1_Thu_No_Chi_Tiet = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Lay(dgE1_Thu_No.ActiveRow.Cells("Id_E1").Value)
            'Lay thong tin tren luoi
            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) Then
                mNgay_Thu_1 = myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value)
            Else
                mNgay_Thu_1 = 0
            End If
            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) Then
                mNgay_Thu_2 = myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value)
            Else
                mNgay_Thu_2 = 0
            End If
            If IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value) Then
                mThu_Lan_1 = dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value
            Else
                mThu_Lan_1 = 0
            End If
            If IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value) Then
                mThu_Lan_2 = dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value
            Else
                mThu_Lan_2 = 0
            End If
            'So sanh 2 thong tin co thay doi khong, neu khong thi thoat
            With mE1_Thu_No_Chi_Tiet
                If mNgay_Thu_1 = .Ngay_Thu_1 And mNgay_Thu_2 = .Ngay_Thu_2 And mThu_Lan_1 = .Thu_Lan_1 And mThu_Lan_2 = .Thu_Lan_2 Then
                    myCho_Phep_Update = False
                    Exit Sub
                End If
            End With
            'Neu co thay doi thi hoi
            If MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin ngày thu và số tiền thu cho chi tiết thu nợ này không?", "Cập nhật thông tin thu nợ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                myCho_Phep_Update = True
            Else
                myCho_Phep_Update = False
                e.Cancel = True
            End If
        Catch ex As Exception
            myCho_Phep_Update = False
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Thiết_Lập_Tham_Số"
    'Tham số bảng nợ
#Region "chkNgay_Dong_No_CheckedChanged"
    Private Sub chkNgay_Dong_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNgay_Dong_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Ngay_Dong").Hidden = Not chkNgay_Dong_No.Checked
    End Sub
#End Region

#Region "chkDuong_Thu_No_CheckedChanged"
    Private Sub chkDuong_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDuong_Thu_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden = Not chkDuong_Thu_No.Checked
    End Sub
#End Region

    Private Sub chkChuyen_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChuyen_Thu_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("So_Chuyen_Thu").Hidden = Not chkChuyen_Thu_No.Checked
    End Sub

    Private Sub chkTui_So_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTui_So_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Tui_So").Hidden = Not chkTui_So_No.Checked
    End Sub

    Private Sub chkNguoi_Nhan_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNguoi_Nhan_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = Not chkNguoi_Nhan_No.Checked
    End Sub

    Private Sub chkDia_Chi_Nhan_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia_Chi_Nhan_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = Not chkDia_Chi_Nhan_No.Checked
    End Sub

    Private Sub chkKhoi_Luong_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKhoi_Luong_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Khoi_Luong").Hidden = Not chkKhoi_Luong_No.Checked
    End Sub

    Private Sub chkNuoc_Nhan_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNuoc_Nhan_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden = Not chkNuoc_Nhan_No.Checked
    End Sub

    Private Sub chkSo_TKHQ_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSo_TKHQ_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = Not chkSo_TKHQ_No.Checked
    End Sub

    Private Sub chkSo_Bien_Lai_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSo_Bien_Lai_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = Not chkSo_Bien_Lai_No.Checked
    End Sub

    Private Sub chkThue_NK_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThue_NK_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = Not chkThue_NK_No.Checked
    End Sub

    Private Sub chkThue_VAT_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThue_VAT_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = Not chkThue_VAT_No.Checked
    End Sub

    Private Sub chkLe_Phi_HQ_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLe_Phi_HQ_No.CheckedChanged
        dgE1_No.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden = Not chkLe_Phi_HQ_No.Checked
    End Sub

    'Tham số bảng thu nợ
    Private Sub chkNgay_Dong_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNgay_Dong_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Dong").Hidden = Not chkNgay_Dong_Thu_No.Checked
    End Sub

    Private Sub chkDuong_Thu_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDuong_Thu_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden = Not chkDuong_Thu_Thu_No.Checked
    End Sub

    Private Sub chkChuyen_Thu_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChuyen_Thu_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_Chuyen_Thu").Hidden = Not chkChuyen_Thu_Thu_No.Checked
    End Sub

    Private Sub chkTui_So_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTui_So_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Tui_So").Hidden = Not chkTui_So_Thu_No.Checked
    End Sub

    Private Sub chkNguoi_Nhan_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNguoi_Nhan_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden = Not chkNguoi_Nhan_Thu_No.Checked
    End Sub

    Private Sub chkDia_Chi_Nhan_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDia_Chi_Nhan_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden = Not chkDia_Chi_Nhan_Thu_No.Checked
    End Sub

    Private Sub chkKhoi_Luong_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKhoi_Luong_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Khoi_Luong").Hidden = Not chkKhoi_Luong_Thu_No.Checked
    End Sub

    Private Sub chkSo_TKHQ_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSo_TKHQ_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden = Not chkSo_TKHQ_Thu_No.Checked
    End Sub

    Private Sub chkSo_Bien_Lai_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSo_Bien_Lai_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden = Not chkSo_Bien_Lai_Thu_No.Checked
    End Sub

    Private Sub chkNgay_Thu_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNgay_Thu_1.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Thu_1").Hidden = Not chkNgay_Thu_1.Checked
    End Sub

    Private Sub chkThu_Lan_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThu_Lan_1.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Thu_Lan_1").Hidden = Not chkThu_Lan_1.Checked
    End Sub

    Private Sub chkNgay_Thu_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNgay_Thu_2.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Thu_2").Hidden = Not chkNgay_Thu_2.Checked
    End Sub

    Private Sub chkThu_Lan_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkThu_Lan_2.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Thu_Lan_2").Hidden = Not chkThu_Lan_2.Checked
    End Sub

    Private Sub chkTong_Tien_Can_Phai_Thu_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTong_Tien_Can_Phai_Thu_No.CheckedChanged
        dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").Hidden = Not chkTong_Tien_Can_Phai_Thu_No.Checked
    End Sub

#End Region

#End Region

#Region "Hàm_Dùng_Chung"

#Region "KeyEnter"
    Private Sub dtpTu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTu_Ngay.KeyDown, dtpDen_Ngay.KeyDown, optCac_Tinh.KeyDown, optBuu_Ta_Noi_Bo.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub

#Region "cbMa_Tinh_KeyDown"
    Private Sub cbMa_Tinh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMa_Tinh.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnNhap_Moi.Select()
        End If
    End Sub
#End Region

#Region "cbMa_Duong_Thu_KeyDown"
    Private Sub cbMa_Duong_Thu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMa_Duong_Thu.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnNhap_Moi.Select()
        End If
    End Sub
#End Region

#End Region

#Region "Search"

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

#Region "Datagrid_MouseDown"
    Private Sub dgE1_No_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1_No.MouseDown, dgE1_Thu_No.MouseDown
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

#Region "DataGrid_Key_F3"
    Private Sub dgE1_No_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_No.KeyDown, dgE1_Thu_No.KeyDown
        'If e.KeyValue = Keys.F3 Then
        '    myGridKeyDown = sender
        '    If Me.FrmTK Is Nothing Then
        '        Me.FrmTK = New FrmTimKiemDanhMuc
        '    End If
        '    Me.FrmTK.ShowMe(Me, myGridKeyDown, "")
        'End If
        If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
            myGridKeyDown.PerformAction(ExitEditMode, False, False)
            myGridKeyDown.PerformAction(NextCellByTab, False, False)
            myGridKeyDown.PerformAction(EnterEditMode, False, False)
            If myGridKeyDown.Name = "dgE1_Thu_No" Then
                If myColumne_Active <> "" Then
                    Select Case myColumne_Active
                        Case "Ngay_Thu_1"
                            myGridKeyDown.ActiveCell = myGridKeyDown.Rows(myDong_Update).Cells("Ngay_Thu_1")
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Case "Ngay_Thu_2"
                            myGridKeyDown.ActiveCell = myGridKeyDown.Rows(myDong_Update).Cells("Ngay_Thu_2")
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Case "Thu_Lan_1"
                            myGridKeyDown.ActiveCell = myGridKeyDown.Rows(myDong_Update).Cells("Thu_Lan_1")
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        Case "Thu_Lan_2"
                            myGridKeyDown.ActiveCell = myGridKeyDown.Rows(myDong_Update).Cells("Thu_Lan_2")
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End Select
                    myColumne_Active = ""
                End If
            End If
        End If
    End Sub
#End Region

#Region "-----------------AddNewRow (Loai = True: nhap tren luoi ; Loai = false: insert vao luoi----------------"
    Private Sub AddNewRow(ByVal sender As Object, ByVal Loai As Boolean)
        Try
            myGridKeyDown = sender
            If Not Loai Then  'Loai insert vao luoi
                If myGridKeyDown.Rows.Count = 0 Then  'Dong dau tien
                    myGridKeyDown.Rows.Band.AddNew()
                Else
                    If myGridKeyDown.Rows(myGridKeyDown.Rows.Count - 1).Cells("Ma_E1").Text <> "" Then
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                End If
            Else 'loai nhap tren luoi
                If Not myGridKeyDown.ActiveCell Is Nothing Then
                    If myGridKeyDown.ActiveCell.Row.HasNextSibling = False Then
                        myGridKeyDown.Rows.Band.AddNew()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Hàm_Người_Dùng_Viết"

#Region "Transparent_Control"
    Private Sub Transparent_Control()
        'Tham So No
        lblTham_So_No.BackColor = Color.Transparent
        chkNgay_Dong_No.BackColor = Color.Transparent
        chkDuong_Thu_No.BackColor = Color.Transparent
        chkChuyen_Thu_No.BackColor = Color.Transparent
        chkTui_So_No.BackColor = Color.Transparent
        chkNguoi_Nhan_No.BackColor = Color.Transparent
        chkDia_Chi_Nhan_No.BackColor = Color.Transparent
        chkKhoi_Luong_No.BackColor = Color.Transparent
        chkNuoc_Nhan_No.BackColor = Color.Transparent
        chkSo_TKHQ_No.BackColor = Color.Transparent
        chkSo_Bien_Lai_No.BackColor = Color.Transparent
        chkThue_NK_No.BackColor = Color.Transparent
        chkThue_VAT_No.BackColor = Color.Transparent
        chkLe_Phi_HQ_No.BackColor = Color.Transparent
        'Tham So Thu No
        lblTham_So_Thu_No.BackColor = Color.Transparent
        chkNgay_Dong_Thu_No.BackColor = Color.Transparent
        chkDuong_Thu_Thu_No.BackColor = Color.Transparent
        chkChuyen_Thu_Thu_No.BackColor = Color.Transparent
        chkTui_So_Thu_No.BackColor = Color.Transparent
        chkNguoi_Nhan_Thu_No.BackColor = Color.Transparent
        chkDia_Chi_Nhan_Thu_No.BackColor = Color.Transparent
        chkKhoi_Luong_Thu_No.BackColor = Color.Transparent
        chkSo_TKHQ_Thu_No.BackColor = Color.Transparent
        chkSo_Bien_Lai_Thu_No.BackColor = Color.Transparent
        chkNgay_Thu_1.BackColor = Color.Transparent
        chkThu_Lan_1.BackColor = Color.Transparent
        chkNgay_Thu_2.BackColor = Color.Transparent
        chkThu_Lan_2.BackColor = Color.Transparent
        chkTong_Tien_Can_Phai_Thu_No.BackColor = Color.Transparent
    End Sub
#End Region

#Region "Enable_Visble_Tham_So"
    Private Sub Enable_Visble_Tham_So(ByVal bolEdit As Boolean)
        grbTham_So.Top = (Me.Height - grbTham_So.Height) / 2
        grbTham_So.Left = (Me.Width - grbTham_So.Width) / 2
        grbTham_So.Visible = bolEdit
        grbChi_Tiet.Enabled = Not bolEdit
        grbThong_Tin.Enabled = Not bolEdit
        'Tham số nợ
        chkNgay_Dong_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Ngay_Dong").Hidden
        chkDuong_Thu_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden
        chkChuyen_Thu_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("So_Chuyen_Thu").Hidden
        chkTui_So_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Tui_So").Hidden
        chkNguoi_Nhan_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden
        chkDia_Chi_Nhan_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden
        chkKhoi_Luong_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Khoi_Luong").Hidden
        chkNuoc_Nhan_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Nuoc_Nhan").Hidden
        chkSo_TKHQ_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden
        chkSo_Bien_Lai_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden
        chkThue_NK_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden
        chkThue_VAT_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden
        chkLe_Phi_HQ_No.Checked = Not dgE1_No.DisplayLayout.Bands(0).Columns("Le_Phi_HQ").Hidden

        'Tham số thu nợ
        chkNgay_Dong_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Dong").Hidden
        chkDuong_Thu_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden
        chkChuyen_Thu_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_Chuyen_Thu").Hidden
        chkTui_So_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Tui_So").Hidden
        chkNguoi_Nhan_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").Hidden
        chkDia_Chi_Nhan_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").Hidden
        chkKhoi_Luong_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Khoi_Luong").Hidden
        chkSo_TKHQ_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_TKHQ").Hidden
        chkSo_Bien_Lai_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("So_Bien_Lai").Hidden
        chkNgay_Thu_1.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Thu_1").Hidden
        chkThu_Lan_1.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Thu_Lan_1").Hidden
        chkNgay_Thu_2.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Ngay_Thu_2").Hidden
        chkThu_Lan_2.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Thu_Lan_2").Hidden
        chkTong_Tien_Can_Phai_Thu_No.Checked = Not dgE1_Thu_No.DisplayLayout.Bands(0).Columns("Tong_Thue_Le_Phi").Hidden
    End Sub

#End Region

#Region "Init_Form"
    Private Sub Init_Form()
        dtpTu_Ngay.Value = myHam_Dung_Chung.dBeginMonth(Now.Date)
        dtpDen_Ngay.Value = Now.Date()
        dtpNgay_Thu.Value = Now.Date()
        Kieu_Nhap_Ngay.Value = Now.Date()
        GetMaTinh()
        GetMaDuongThu()
        GetDuong_Thu_Di()
        Calculate_E1_No_Le_Phi_HQ()
        Calculate_E1_Thu_No_Le_Phi_HQ()
    End Sub
#End Region

#Region "GetMaTinh"
    Private Sub GetMaTinh()
        Dim TblDanh_Sach_Tinh As New DataTable
        TblDanh_Sach_Tinh = myMa_Tinh.Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbMa_Tinh.DataSource = TblDanh_Sach_Tinh
        cbMa_Tinh.DataBind()
        'cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
        cbMa_Tinh.LimitToList = True
    End Sub
#End Region

#Region "GetMaDuongThu"
    Private Sub GetMaDuongThu()
        Dim TblDuong_Thu_Buu_Ta_Noi_Bo As New DataTable
        TblDuong_Thu_Buu_Ta_Noi_Bo = myDuong_Thu_Buu_Ta_Noi_Bo.Duong_Thu_Buu_Ta_Noi_Bo_Danh_Sach_Rut_Gon_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbMa_Duong_Thu.DataSource = TblDuong_Thu_Buu_Ta_Noi_Bo
        cbMa_Duong_Thu.DataBind()
        'cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
        cbMa_Duong_Thu.LimitToList = True
    End Sub
#End Region

#Region "GetDuong_Thu_Di"
    Private Sub GetDuong_Thu_Di()
        Dim TblDuong_Thu_Di As New DataTable
        TblDuong_Thu_Di = myDuong_Thu_Di.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        ddDuong_Thu_Di.DataSource = TblDuong_Thu_Di
        ddDuong_Thu_Di.DataBind()
    End Sub
#End Region

#Region "Calculate_E1_No_Le_Phi_HQ"
    Private Sub Calculate_E1_No_Le_Phi_HQ()
        Dim mTong_So As Integer
        Dim mTong_Tien As Integer
        Dim idx As Integer
        mTong_So = 0
        mTong_Tien = 0
        For idx = 0 To dgE1_No.Rows.Count - 1
            mTong_So = mTong_So + 1
            mTong_Tien = mTong_Tien + dgE1_No.Rows(idx).Cells("Tong_Thue_Le_Phi").Value
        Next
        lblThong_Tin_No.Text = mTong_So.ToString("# ##0") & " bưu phẩm  /  " & mTong_Tien.ToString("### ### ##0") & " VNĐ"
    End Sub
#End Region

#Region "Calculate_E1_Thu_No_Le_Phi_HQ"
    Private Sub Calculate_E1_Thu_No_Le_Phi_HQ()
        Dim mTong_So As Integer
        Dim mTong_Tien As Integer
        Dim mThu_Lan_1 As Integer
        Dim mThu_Lan_2 As Integer
        Dim idx As Integer
        mTong_So = 0
        mTong_Tien = 0
        For idx = 0 To dgE1_Thu_No.Rows.Count - 1
            mTong_So = mTong_So + 1
            mThu_Lan_1 = IIf(IsNumeric(dgE1_Thu_No.Rows(idx).Cells("Thu_Lan_1").Value), dgE1_Thu_No.Rows(idx).Cells("Thu_Lan_1").Value, 0)
            mThu_Lan_2 = IIf(IsNumeric(dgE1_Thu_No.Rows(idx).Cells("Thu_Lan_2").Value), dgE1_Thu_No.Rows(idx).Cells("Thu_Lan_2").Value, 0)
            mTong_Tien = mTong_Tien + mThu_Lan_1 + mThu_Lan_2
        Next
        lblThong_Tin_Thu_No.Text = mTong_So.ToString("# ##0") & " bưu phẩm  /  " & mTong_Tien.ToString("### ### ##0") & " VNĐ"
    End Sub
#End Region

#Region "DataGrid_E1_No"
    Private Sub DataGrid_E1_No(ByVal mIs_Empty As Boolean)
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mData As DataTable
        Dim mId_Duong_Thu As String
        Dim mMa_Tinh As Integer
        Try
            If mIs_Empty Then   'xoa trang luoi
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
            Else
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value)
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)
            End If
            'Lay du lieu 
            If optCac_Tinh.Checked Then   'theo tinh
                If mIs_Empty Then
                    mMa_Tinh = 0
                Else
                    mMa_Tinh = cbMa_Tinh.Value
                End If
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Chua_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh(mTu_Ngay, mDen_Ngay, mMa_Tinh).Tables(0)
            Else  'theo duogn thu buu ta noi bo
                If mIs_Empty Then
                    mId_Duong_Thu = ""
                Else
                    mId_Duong_Thu = cbMa_Duong_Thu.Value
                End If
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Chua_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo(mTu_Ngay, mDen_Ngay, mId_Duong_Thu).Tables(0)
            End If
            '-------------------
            dgE1_No.DataSource = mData
            dgE1_No.DataBind()
        Catch ex As Exception
            MessageBox.Show("Error at: =========DataGrid_E1_No=========" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid_E1_Thu_No"
    Private Sub DataGrid_E1_Thu_No(ByVal mTheo_Ngay_Thu As Boolean, ByVal mIs_Empty As Boolean)
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mNgay_Thu As Integer
        Dim mId_Duong_Thu As String
        Dim mMa_Tinh As Integer
        Dim mData As DataTable
        Try
            If mIs_Empty Then   'xoa trang luoi
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
            Else
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value)
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)
            End If
            mNgay_Thu = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Thu.Value)

            If optCac_Tinh.Checked Then   'theo tinh
                If mIs_Empty Then
                    mMa_Tinh = 0
                Else
                    mMa_Tinh = cbMa_Tinh.Value
                End If
            Else  'theo duogn thu buu ta noi bo
                If mIs_Empty Then
                    mId_Duong_Thu = ""
                Else
                    mId_Duong_Thu = cbMa_Duong_Thu.Value
                End If
            End If

            'Lay du lieu 
            If mTheo_Ngay_Thu Then   'Theo ngay thu
                If optCac_Tinh.Checked Then   'theo tinh
                    mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Ma_Tinh(mNgay_Thu, mMa_Tinh).Tables(0)
                Else
                    mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Theo_Ngay_Thu_Duong_Thu_Buu_Ta_Noi_Bo(mNgay_Thu, mId_Duong_Thu).Tables(0)
                End If
            Else   'theo ngay dong
                If optCac_Tinh.Checked Then   'theo tinh
                    mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh(mTu_Ngay, mDen_Ngay, mMa_Tinh).Tables(0)
                Else
                    mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo(mTu_Ngay, mDen_Ngay, mId_Duong_Thu).Tables(0)
                End If
            End If
            '-------------------
            dgE1_Thu_No.DataSource = mData
            dgE1_Thu_No.DataBind()
        Catch ex As Exception
            MessageBox.Show("Error at: =========DataGrid_E1_Thu_No=========" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid_E1_No_Theo_Ma_E1"
    Private Sub DataGrid_E1_No_Theo_Ma_E1(ByVal mIs_Empty As Boolean, ByVal mMa_E1 As String)
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mData As DataTable
        Dim mId_Duong_Thu As String
        Dim mMa_Tinh As Integer
        Try
            If mIs_Empty Then   'xoa trang luoi
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
            Else
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value)
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)
            End If
            'Lay du lieu 
            If optCac_Tinh.Checked Then   'theo tinh
                If mIs_Empty Then
                    mMa_Tinh = 0
                Else
                    mMa_Tinh = cbMa_Tinh.Value
                End If
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh_Ma_E1(mTu_Ngay, mDen_Ngay, mMa_Tinh, mMa_E1).Tables(0)
            Else  'theo duogn thu buu ta noi bo
                If mIs_Empty Then
                    mId_Duong_Thu = ""
                Else
                    mId_Duong_Thu = cbMa_Duong_Thu.Value
                End If
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Ma_E1(mTu_Ngay, mDen_Ngay, mId_Duong_Thu, mMa_E1).Tables(0)
            End If
            '-------------------
            dgE1_No.DataSource = mData
            dgE1_No.DataBind()
        Catch ex As Exception
            MessageBox.Show("Error at: =========DataGrid_E1_No_Theo_Ma_E1=========" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid_E1_Thu_No_Theo_Ma_E1"
    Private Sub DataGrid_E1_Thu_No_Theo_Ma_E1(ByVal mIs_Empty As Boolean, ByVal mMa_E1 As String)
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mId_Duong_Thu As String
        Dim mMa_Tinh As Integer
        Dim mData As DataTable
        Try
            If mIs_Empty Then   'xoa trang luoi
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now.Date())
            Else
                mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTu_Ngay.Value)
                mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDen_Ngay.Value)
            End If

            If optCac_Tinh.Checked Then   'theo tinh
                If mIs_Empty Then
                    mMa_Tinh = 0
                Else
                    mMa_Tinh = cbMa_Tinh.Value
                End If
            Else  'theo duogn thu buu ta noi bo
                If mIs_Empty Then
                    mId_Duong_Thu = ""
                Else
                    mId_Duong_Thu = cbMa_Duong_Thu.Value
                End If
            End If

            'Lay du lieu 
            If optCac_Tinh.Checked Then   'theo tinh
                mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Ma_Tinh_Ma_E1(mTu_Ngay, mDen_Ngay, mMa_Tinh, mMa_E1).Tables(0)
            Else
                mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Thu_No_Tu_Ngay_Den_Ngay_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Ma_E1(mTu_Ngay, mDen_Ngay, mId_Duong_Thu, mMa_E1).Tables(0)
            End If

            '-------------------
            dgE1_Thu_No.DataSource = mData
            dgE1_Thu_No.DataBind()
        Catch ex As Exception
            MessageBox.Show("Error at: =========DataGrid_E1_Thu_No_Theo_Ma_E1=========" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Gan_Thong_Tin_Vao_Luoi_E1_Thu_No"
    Private Sub Gan_Thong_Tin_Vao_Luoi_E1_Thu_No(ByVal RowIndex As Integer, ByVal mChiTiet As E1_No_Le_Phi_HQ_Chi_Tiet, ByVal mSo_Chuyen_Thu As String, ByVal mTui_So As String)
        Try
            'Dua thong tin len luoi
            dgE1_Thu_No.Rows(RowIndex).Cells("Chon").Value = False
            dgE1_Thu_No.Rows(RowIndex).Cells("Id_E1").Value = mChiTiet.Id_E1
            dgE1_Thu_No.Rows(RowIndex).Cells("Id_E2").Value = mChiTiet.Id_E2
            dgE1_Thu_No.Rows(RowIndex).Cells("Id_Chuyen_Thu").Value = mChiTiet.Id_Chuyen_Thu
            dgE1_Thu_No.Rows(RowIndex).Cells("Id_Duong_Thu").Value = mChiTiet.Id_Duong_Thu
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_Bc_Khai_Thac").Value = mChiTiet.Ma_Bc_Khai_Thac
            dgE1_Thu_No.Rows(RowIndex).Cells("Ngay_Dong").Value = myHam_Dung_Chung.ConvertIntToDate(mChiTiet.Ngay_Dong)
            dgE1_Thu_No.Rows(RowIndex).Cells("Gio_Dong").Value = mChiTiet.Gio_Dong
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_Tinh").Value = mChiTiet.Ma_Tinh
            dgE1_Thu_No.Rows(RowIndex).Cells("Don_Vi").Value = mChiTiet.Don_Vi
            dgE1_Thu_No.Rows(RowIndex).Cells("STT").Value = mChiTiet.STT
            dgE1_Thu_No.Rows(RowIndex).Cells("Nuoc_Nhan").Value = mChiTiet.Nuoc_Nhan
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_Bc_Nhan").Value = mChiTiet.Ma_Bc_Nhan
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_E1").Value = mChiTiet.Ma_E1
            dgE1_Thu_No.Rows(RowIndex).Cells("Nuoc_Tra").Value = mChiTiet.Nuoc_Tra
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_Bc_Tra").Value = mChiTiet.Ma_Bc_Tra
            dgE1_Thu_No.Rows(RowIndex).Cells("Khoi_Luong").Value = mChiTiet.Khoi_Luong
            dgE1_Thu_No.Rows(RowIndex).Cells("Phan_Loai").Value = mChiTiet.Phan_Loai
            dgE1_Thu_No.Rows(RowIndex).Cells("Gia_Tri_Hang").Value = mChiTiet.Gia_Tri_Hang
            dgE1_Thu_No.Rows(RowIndex).Cells("Ma_KH").Value = mChiTiet.Ma_KH
            dgE1_Thu_No.Rows(RowIndex).Cells("Nguoi_Gui").Value = mChiTiet.Nguoi_Gui
            dgE1_Thu_No.Rows(RowIndex).Cells("Nguoi_Nhan").Value = mChiTiet.Nguoi_Nhan
            dgE1_Thu_No.Rows(RowIndex).Cells("Dia_Chi_Gui").Value = mChiTiet.Dia_Chi_Gui
            dgE1_Thu_No.Rows(RowIndex).Cells("Dia_Chi_Nhan").Value = mChiTiet.Dia_Chi_Nhan
            dgE1_Thu_No.Rows(RowIndex).Cells("Dien_Thoai_Gui").Value = mChiTiet.Dien_Thoai_Gui
            dgE1_Thu_No.Rows(RowIndex).Cells("Dien_Thoai_Nhan").Value = mChiTiet.Dien_Thoai_Nhan
            dgE1_Thu_No.Rows(RowIndex).Cells("Ghi_Chu").Value = mChiTiet.Ghi_Chu
            dgE1_Thu_No.Rows(RowIndex).Cells("Ngay_Den_VN").Value = mChiTiet.Ngay_Den_VN
            dgE1_Thu_No.Rows(RowIndex).Cells("Id_Nguoi_Dung").Value = mChiTiet.Id_Nguoi_Dung
            dgE1_Thu_No.Rows(RowIndex).Cells("So_TKHQ").Value = mChiTiet.So_TKHQ
            dgE1_Thu_No.Rows(RowIndex).Cells("So_Bien_Lai").Value = mChiTiet.So_Bien_Lai
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_NK").Value = mChiTiet.Thue_NK
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_VAT").Value = mChiTiet.Thue_VAT
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_Dac_Biet").Value = mChiTiet.Thue_Dac_Biet
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_Tieu_Thu").Value = mChiTiet.Thue_Tieu_Thu
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_Qua_Tang").Value = mChiTiet.Thue_Qua_Tang
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_Han_Ngach").Value = mChiTiet.Thue_Han_Ngach
            dgE1_Thu_No.Rows(RowIndex).Cells("Thue_Uu_Dai").Value = mChiTiet.Thue_Uu_Dai
            dgE1_Thu_No.Rows(RowIndex).Cells("Tong_Thue").Value = mChiTiet.Tong_Thue
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_HQ").Value = mChiTiet.Le_Phi_HQ
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_VH").Value = mChiTiet.Le_Phi_VH
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_YT").Value = mChiTiet.Le_Phi_YT
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_DV").Value = mChiTiet.Le_Phi_DV
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_TV").Value = mChiTiet.Le_Phi_TV
            dgE1_Thu_No.Rows(RowIndex).Cells("Le_Phi_Khac").Value = mChiTiet.Le_Phi_Khac
            dgE1_Thu_No.Rows(RowIndex).Cells("Tong_Le_Phi").Value = mChiTiet.Tong_Le_Phi
            dgE1_Thu_No.Rows(RowIndex).Cells("Tong_Thue_Le_Phi").Value = mChiTiet.Tong_Thue_Le_Phi
            dgE1_Thu_No.Rows(RowIndex).Cells("Chot_SL").Value = mChiTiet.Chot_SL
            dgE1_Thu_No.Rows(RowIndex).Cells("Da_Truyen").Value = mChiTiet.Da_Truyen
            dgE1_Thu_No.Rows(RowIndex).Cells("Ngay_He_Thong").Value = mChiTiet.Ngay_He_Thong
            dgE1_Thu_No.Rows(RowIndex).Cells("Gio_He_Thong").Value = mChiTiet.Gio_He_Thong
            dgE1_Thu_No.Rows(RowIndex).Cells("Thu_Lan_1").Value = mChiTiet.Tong_Thue_Le_Phi
            dgE1_Thu_No.Rows(RowIndex).Cells("Ngay_Thu_1").Value = dtpNgay_Thu.Value
            dgE1_Thu_No.Rows(RowIndex).Cells("Thu_Lan_2").Value = 0
            'dgE1_Thu_No.Rows(RowIndex).Cells("Ngay_Thu_2").Value = mChiTiet.Ngay_Thu_2
            dgE1_Thu_No.Rows(RowIndex).Cells("Ly_Do_CH").Value = 0
            dgE1_Thu_No.Rows(RowIndex).Cells("Co_Thu").Value = 1
            dgE1_Thu_No.Rows(RowIndex).Cells("So_Chuyen_Thu").Value = mSo_Chuyen_Thu
            dgE1_Thu_No.Rows(RowIndex).Cells("Tui_So").Value = mTui_So
            dgE1_Thu_No.Rows(RowIndex).Cells("Tong_Tien_Thu").Value = mChiTiet.Tong_Thue_Le_Phi

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Cap_Nhat_Vao_Bang_E1_Thu_No_Trong_Database"
    Private Sub Them_Vao_E1_Thu_No_Lay_Thong_Tin_Tu_E1_No(ByVal mE1_No_Chi_Tiet As E1_No_Le_Phi_HQ_Chi_Tiet)
        Try
            Dim mE1_Thu_No_Chi_Tiet As New E1_Thu_No_Le_Phi_HQ_Chi_Tiet
            'Lay gia tri
            mE1_Thu_No_Chi_Tiet.Id_E1 = mE1_No_Chi_Tiet.Id_E1
            mE1_Thu_No_Chi_Tiet.Id_E2 = mE1_No_Chi_Tiet.Id_E2
            mE1_Thu_No_Chi_Tiet.Id_Chuyen_Thu = mE1_No_Chi_Tiet.Id_Chuyen_Thu
            mE1_Thu_No_Chi_Tiet.Id_Duong_Thu = mE1_No_Chi_Tiet.Id_Duong_Thu
            mE1_Thu_No_Chi_Tiet.Ma_Bc_Khai_Thac = mE1_No_Chi_Tiet.Ma_Bc_Khai_Thac
            mE1_Thu_No_Chi_Tiet.Ngay_Dong = mE1_No_Chi_Tiet.Ngay_Dong
            mE1_Thu_No_Chi_Tiet.Gio_Dong = mE1_No_Chi_Tiet.Gio_Dong
            mE1_Thu_No_Chi_Tiet.Ma_Tinh = mE1_No_Chi_Tiet.Ma_Tinh
            mE1_Thu_No_Chi_Tiet.Don_Vi = mE1_No_Chi_Tiet.Don_Vi
            mE1_Thu_No_Chi_Tiet.STT = mE1_No_Chi_Tiet.STT
            mE1_Thu_No_Chi_Tiet.Nuoc_Nhan = mE1_No_Chi_Tiet.Nuoc_Nhan
            mE1_Thu_No_Chi_Tiet.Ma_Bc_Nhan = mE1_No_Chi_Tiet.Ma_Bc_Nhan
            mE1_Thu_No_Chi_Tiet.Ma_E1 = mE1_No_Chi_Tiet.Ma_E1
            mE1_Thu_No_Chi_Tiet.Nuoc_Tra = mE1_No_Chi_Tiet.Nuoc_Tra
            mE1_Thu_No_Chi_Tiet.Ma_Bc_Tra = mE1_No_Chi_Tiet.Ma_Bc_Tra
            mE1_Thu_No_Chi_Tiet.Khoi_Luong = mE1_No_Chi_Tiet.Khoi_Luong
            mE1_Thu_No_Chi_Tiet.Phan_Loai = mE1_No_Chi_Tiet.Phan_Loai
            mE1_Thu_No_Chi_Tiet.Gia_Tri_Hang = mE1_No_Chi_Tiet.Gia_Tri_Hang
            mE1_Thu_No_Chi_Tiet.Ma_KH = mE1_No_Chi_Tiet.Ma_KH
            mE1_Thu_No_Chi_Tiet.Nguoi_Gui = mE1_No_Chi_Tiet.Nguoi_Gui
            mE1_Thu_No_Chi_Tiet.Nguoi_Nhan = mE1_No_Chi_Tiet.Nguoi_Nhan
            mE1_Thu_No_Chi_Tiet.Dia_Chi_Gui = mE1_No_Chi_Tiet.Dia_Chi_Gui
            mE1_Thu_No_Chi_Tiet.Dia_Chi_Nhan = mE1_No_Chi_Tiet.Dia_Chi_Nhan
            mE1_Thu_No_Chi_Tiet.Dien_Thoai_Gui = mE1_No_Chi_Tiet.Dien_Thoai_Gui
            mE1_Thu_No_Chi_Tiet.Dien_Thoai_Nhan = mE1_No_Chi_Tiet.Dien_Thoai_Nhan
            mE1_Thu_No_Chi_Tiet.Ghi_Chu = mE1_No_Chi_Tiet.Ghi_Chu
            mE1_Thu_No_Chi_Tiet.Ngay_Den_VN = mE1_No_Chi_Tiet.Ngay_Den_VN
            mE1_Thu_No_Chi_Tiet.Id_Nguoi_Dung = mE1_No_Chi_Tiet.Id_Nguoi_Dung
            mE1_Thu_No_Chi_Tiet.So_TKHQ = mE1_No_Chi_Tiet.So_TKHQ
            mE1_Thu_No_Chi_Tiet.So_Bien_Lai = mE1_No_Chi_Tiet.So_Bien_Lai
            mE1_Thu_No_Chi_Tiet.Thue_NK = mE1_No_Chi_Tiet.Thue_NK
            mE1_Thu_No_Chi_Tiet.Thue_VAT = mE1_No_Chi_Tiet.Thue_VAT
            mE1_Thu_No_Chi_Tiet.Thue_Dac_Biet = mE1_No_Chi_Tiet.Thue_Dac_Biet
            mE1_Thu_No_Chi_Tiet.Thue_Tieu_Thu = mE1_No_Chi_Tiet.Thue_Tieu_Thu
            mE1_Thu_No_Chi_Tiet.Thue_Qua_Tang = mE1_No_Chi_Tiet.Thue_Qua_Tang
            mE1_Thu_No_Chi_Tiet.Thue_Han_Ngach = mE1_No_Chi_Tiet.Thue_Han_Ngach
            mE1_Thu_No_Chi_Tiet.Thue_Uu_Dai = mE1_No_Chi_Tiet.Thue_Uu_Dai
            mE1_Thu_No_Chi_Tiet.Tong_Thue = mE1_No_Chi_Tiet.Tong_Thue
            mE1_Thu_No_Chi_Tiet.Le_Phi_HQ = mE1_No_Chi_Tiet.Le_Phi_HQ
            mE1_Thu_No_Chi_Tiet.Le_Phi_VH = mE1_No_Chi_Tiet.Le_Phi_VH
            mE1_Thu_No_Chi_Tiet.Le_Phi_YT = mE1_No_Chi_Tiet.Le_Phi_YT
            mE1_Thu_No_Chi_Tiet.Le_Phi_DV = mE1_No_Chi_Tiet.Le_Phi_DV
            mE1_Thu_No_Chi_Tiet.Le_Phi_TV = mE1_No_Chi_Tiet.Le_Phi_TV
            mE1_Thu_No_Chi_Tiet.Le_Phi_Khac = mE1_No_Chi_Tiet.Le_Phi_Khac
            mE1_Thu_No_Chi_Tiet.Tong_Le_Phi = mE1_No_Chi_Tiet.Tong_Le_Phi
            mE1_Thu_No_Chi_Tiet.Tong_Thue_Le_Phi = mE1_No_Chi_Tiet.Tong_Thue_Le_Phi
            mE1_Thu_No_Chi_Tiet.Chot_SL = mE1_No_Chi_Tiet.Chot_SL
            mE1_Thu_No_Chi_Tiet.Da_Truyen = mE1_No_Chi_Tiet.Da_Truyen
            mE1_Thu_No_Chi_Tiet.Ngay_He_Thong = mE1_No_Chi_Tiet.Ngay_He_Thong
            mE1_Thu_No_Chi_Tiet.Gio_He_Thong = mE1_No_Chi_Tiet.Gio_He_Thong
            mE1_Thu_No_Chi_Tiet.Thu_Lan_1 = mE1_No_Chi_Tiet.Tong_Thue_Le_Phi
            mE1_Thu_No_Chi_Tiet.Ngay_Thu_1 = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Thu.Value)
            mE1_Thu_No_Chi_Tiet.Thu_Lan_2 = 0
            mE1_Thu_No_Chi_Tiet.Ngay_Thu_2 = 0
            mE1_Thu_No_Chi_Tiet.Ly_Do_CH = 0
            mE1_Thu_No_Chi_Tiet.Co_Thu = 1
            'Them vao bang
            myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them(mE1_Thu_No_Chi_Tiet.Id_E1, _
                                                                    mE1_Thu_No_Chi_Tiet.Id_E2, _
                                                                    mE1_Thu_No_Chi_Tiet.Id_Chuyen_Thu, _
                                                                    mE1_Thu_No_Chi_Tiet.Id_Duong_Thu, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                    mE1_Thu_No_Chi_Tiet.Ngay_Dong, _
                                                                    mE1_Thu_No_Chi_Tiet.Gio_Dong, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_Tinh, _
                                                                    mE1_Thu_No_Chi_Tiet.Don_Vi, _
                                                                    mE1_Thu_No_Chi_Tiet.STT, _
                                                                    mE1_Thu_No_Chi_Tiet.Nuoc_Nhan, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_Bc_Nhan, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_E1, _
                                                                    mE1_Thu_No_Chi_Tiet.Nuoc_Tra, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_Bc_Tra, _
                                                                    mE1_Thu_No_Chi_Tiet.Khoi_Luong, _
                                                                    mE1_Thu_No_Chi_Tiet.Phan_Loai, _
                                                                    mE1_Thu_No_Chi_Tiet.Gia_Tri_Hang, _
                                                                    mE1_Thu_No_Chi_Tiet.Ma_KH, _
                                                                    mE1_Thu_No_Chi_Tiet.Nguoi_Gui, _
                                                                    mE1_Thu_No_Chi_Tiet.Nguoi_Nhan, _
                                                                    mE1_Thu_No_Chi_Tiet.Dia_Chi_Gui, _
                                                                    mE1_Thu_No_Chi_Tiet.Dia_Chi_Nhan, _
                                                                    mE1_Thu_No_Chi_Tiet.Dien_Thoai_Gui, _
                                                                    mE1_Thu_No_Chi_Tiet.Dien_Thoai_Nhan, _
                                                                    mE1_Thu_No_Chi_Tiet.Ghi_Chu, _
                                                                    mE1_Thu_No_Chi_Tiet.Ngay_Den_VN, _
                                                                    mE1_Thu_No_Chi_Tiet.Id_Nguoi_Dung, _
                                                                    mE1_Thu_No_Chi_Tiet.So_TKHQ, _
                                                                    mE1_Thu_No_Chi_Tiet.So_Bien_Lai, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_NK, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_VAT, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_Dac_Biet, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_Tieu_Thu, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_Qua_Tang, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_Han_Ngach, _
                                                                    mE1_Thu_No_Chi_Tiet.Thue_Uu_Dai, _
                                                                    mE1_Thu_No_Chi_Tiet.Tong_Thue, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_HQ, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_VH, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_YT, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_DV, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_TV, _
                                                                    mE1_Thu_No_Chi_Tiet.Le_Phi_Khac, _
                                                                    mE1_Thu_No_Chi_Tiet.Tong_Le_Phi, _
                                                                    mE1_Thu_No_Chi_Tiet.Tong_Thue_Le_Phi, _
                                                                    mE1_Thu_No_Chi_Tiet.Chot_SL, _
                                                                    mE1_Thu_No_Chi_Tiet.Da_Truyen, _
                                                                    mE1_Thu_No_Chi_Tiet.Ngay_He_Thong, _
                                                                    mE1_Thu_No_Chi_Tiet.Gio_He_Thong, _
                                                                    mE1_Thu_No_Chi_Tiet.Thu_Lan_1, _
                                                                    mE1_Thu_No_Chi_Tiet.Ngay_Thu_1, _
                                                                    mE1_Thu_No_Chi_Tiet.Thu_Lan_2, _
                                                                    mE1_Thu_No_Chi_Tiet.Ngay_Thu_2, _
                                                                    mE1_Thu_No_Chi_Tiet.Ly_Do_CH, _
                                                                    mE1_Thu_No_Chi_Tiet.Co_Thu)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Kiem_Tra_Thong_Tin_Cap_Nhat_Chi_Tiet_Thu_No"
    Private Function Kiem_Tra_Thong_Tin_Cap_Nhat_Chi_Tiet_Thu_No() As Boolean
        Try
            '==========Có nhập số tiền thu nhưng không nhập ngày thu===========
            'Thu lần 1
            If Not IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) And dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Text <> "0" And dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Text <> "" Then
                MessageBox.Show("Ngày thu nhập vào không hợp lệ.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not chkNgay_Thu_1.Checked Then
                    chkNgay_Thu_1.Checked = True
                End If
                myColumne_Active = "Ngay_Thu_1"
                Return False
            End If
            'Thu lần 2
            If Not IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) And dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Text <> "0" And dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Text <> "" Then
                MessageBox.Show("Ngày thu nhập vào không hợp lệ.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not chkNgay_Thu_2.Checked Then
                    chkNgay_Thu_2.Checked = True
                End If
                myColumne_Active = "Ngay_Thu_2"
                Return False
            End If

            'Lấy thông tin phục vụ kiểm tra
            Dim mE1_No_Chi_Tiet As New E1_No_Le_Phi_HQ_Chi_Tiet
            Dim mId_E1 As String
            mId_E1 = dgE1_Thu_No.ActiveRow.Cells("Id_E1").Value
            mE1_No_Chi_Tiet = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Lay(mId_E1)

            '==========Ngày thu nhỏ hơn ngày đóng===========
            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) Then
                If myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) < mE1_No_Chi_Tiet.Ngay_Dong Then
                    MessageBox.Show("Ngày thu nhập vào không hợp lệ. Ngày thu không được phép nhỏ hơn ngày đóng.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkNgay_Thu_1.Checked Then
                        chkNgay_Thu_1.Checked = True
                    End If
                    myColumne_Active = "Ngay_Thu_1"
                    Return False
                End If
            End If

            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) Then
                If myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) < mE1_No_Chi_Tiet.Ngay_Dong Then
                    MessageBox.Show("Ngày thu nhập vào không hợp lệ. Ngày thu không được phép nhỏ hơn ngày đóng.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkNgay_Thu_2.Checked Then
                        chkNgay_Thu_2.Checked = True
                    End If
                    myColumne_Active = "Ngay_Thu_2"
                    Return False
                Else   '==========Ngày thu 2 nhỏ hơn hoặc bằng ngày thu 1===========
                    If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) Then
                        If dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value >= dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value Then
                            MessageBox.Show("Ngày thu nhập vào không hợp lệ. Ngày thu 2 không được phép nhỏ hơn hoặc bằng ngày thu 1.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            If Not chkNgay_Thu_2.Checked Then
                                chkNgay_Thu_2.Checked = True
                            End If
                            myColumne_Active = "Ngay_Thu_2"
                            Return False
                        End If
                    End If
                End If
            End If
            '==========Ngày thu lớn hơn ngày hiện tại===========
            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) Then
                If myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_1").Value) > myHam_Dung_Chung.ConvertDateToInt(Now.Date()) Then
                    MessageBox.Show("Ngày thu nhập vào không hợp lệ. Ngày thu không được phép lớn hơn ngày hiện tại.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkNgay_Thu_1.Checked Then
                        chkNgay_Thu_1.Checked = True
                    End If
                    myColumne_Active = "Ngay_Thu_1"
                    Return False
                End If
            End If
            If IsDate(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) Then
                If myHam_Dung_Chung.ConvertDateToInt(dgE1_Thu_No.ActiveRow.Cells("Ngay_Thu_2").Value) > myHam_Dung_Chung.ConvertDateToInt(Now.Date()) Then
                    MessageBox.Show("Ngày thu nhập vào không hợp lệ. Ngày thu không được phép lớn hơn ngày hiện tại.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkNgay_Thu_2.Checked Then
                        chkNgay_Thu_2.Checked = True
                    End If
                    myColumne_Active = "Ngay_Thu_2"
                    Return False
                End If
            End If

            '==========Số tiền nhập vào không hợp lệ ===========
            If dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Text <> "" Then
                If Not IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Text) Then
                    MessageBox.Show("Số tiền thu nhập vào không hợp lệ. Số tiền thu phải là 1 số.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkThu_Lan_1.Checked Then
                        chkThu_Lan_1.Checked = True
                    End If
                    myColumne_Active = "Thu_Lan_1"
                    Return False
                End If
            End If
            If dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Text <> "" Then
                If Not IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Text) Then
                    MessageBox.Show("Số tiền thu nhập vào không hợp lệ. Số tiền thu phải là 1 số.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Not chkThu_Lan_2.Checked Then
                        chkThu_Lan_2.Checked = True
                    End If
                    myColumne_Active = "Thu_Lan_2"
                    Return False
                End If
            End If

            '==========Số tiền thu 1 + Số tiền thu 2 Không bằng Tổng tiền cần phải thu ===========
            Dim So_Tien_1 As Integer = IIf(IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value), dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_1").Value, 0)
            Dim So_Tien_2 As Integer = IIf(IsNumeric(dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value), dgE1_Thu_No.ActiveRow.Cells("Thu_Lan_2").Value, 0)
            If mE1_No_Chi_Tiet.Tong_Thue_Le_Phi - So_Tien_1 - So_Tien_2 < 0 Then
                MessageBox.Show("Số tiền thu nhập vào không hợp lệ. Tổng số tiền 2 lần thu không được vượt quá số tiền nợ.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not chkThu_Lan_1.Checked Then
                    chkThu_Lan_1.Checked = True
                End If
                If Not chkThu_Lan_2.Checked Then
                    chkThu_Lan_2.Checked = True
                End If
                myColumne_Active = "Thu_Lan_1"
                Return False
            End If
            If (mE1_No_Chi_Tiet.Tong_Thue_Le_Phi - So_Tien_1 - So_Tien_2 > 0) And So_Tien_1 > 0 And So_Tien_2 > 0 Then
                MessageBox.Show("Số tiền thu nhập vào không hợp lệ. Tổng số tiền 2 lần thu không được nhỏ hơn số tiền nợ." & vbNewLine & "Hệ thống không cho phép được thu quá 2 lần, nghĩa là sau 2 lần thu phải thu hết số tiền nợ.", "Lỗi cập nhật thông tin thu nợ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not chkThu_Lan_1.Checked Then
                    chkThu_Lan_1.Checked = True
                End If
                If Not chkThu_Lan_2.Checked Then
                    chkThu_Lan_2.Checked = True
                End If
                myColumne_Active = "Thu_Lan_1"
                Return False
            End If
            'Kiểm tra hợp lệ thì trả về TRUE
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#End Region

End Class

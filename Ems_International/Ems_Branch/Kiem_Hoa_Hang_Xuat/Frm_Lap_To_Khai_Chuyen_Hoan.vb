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
Public Class Frm_Lap_To_Khai_Chuyen_Hoan
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
    Friend WithEvents Panel_Thong_Tin_To_Khai As System.Windows.Forms.Panel
    Friend WithEvents Panel_Chi_Tiet_Hang_Hoa As System.Windows.Forms.Panel
    Friend WithEvents txtSo_TKHQ As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents S As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents cbSoToKhai As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpNgayDangKy As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnClose_Chi_Tiet As System.Windows.Forms.Button
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents GrbChi_Tiet As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkTai_Lieu As System.Windows.Forms.CheckBox
    Friend WithEvents lblThong_Tin As System.Windows.Forms.Label
    Friend WithEvents dgE1_Kiem_Hoa_Xuat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtTong_Trong_Luong As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_Tui As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents dtpNgay_CN38 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtChuyen_Bay As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents GrbTong_Hop As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtNguoi_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnTraCuu As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents chkIn_Phu_Luc As System.Windows.Forms.CheckBox
    Friend WithEvents txtNguoi_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNguoi_Duoc_Uy_Quyen As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgE1HangKiemHoaXuat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Ban_In As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtThong_Tin_So_Luong_Hang As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtThong_Tin_Buu_Pham_E1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnuMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuTimKiem As System.Windows.Forms.MenuItem
    Friend WithEvents txtTong_So_Muc_Hang As System.Windows.Forms.TextBox
    Friend WithEvents txtIndex_E1_Kiem_Hoa As System.Windows.Forms.TextBox
    Friend WithEvents Nhap_So As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ddMaHang As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents chk_In_KQ_KT As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Lap_To_Khai_Chuyen_Hoan))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Kiem_Hoa_Xuat", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_To_Khai")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_May_Tinh")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ban_So")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nhap_Chi_Tiet_Hang_Hoa")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Muc_Hang")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tri_Gia")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("So_To_Khai", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_To_Khai")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Hang", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Hang_Hoa")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Hang_Hoa")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Hang_Hoa")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Hang_Kiem_Hoa_Xuat", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chi_Tiet")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_To_Khai")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT_Hang_Hoa")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Hang_Hoa")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Hang_Hoa")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Xuat_Xu")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Vi_Tinh")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Luong_Hang", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Gia")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang_VN")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_NK")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_VAT")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Dac_Biet")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_Dac_Biet")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Tieu_Thu")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_Tieu_Thu")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Qua_Tang")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_Qua_Tang")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Han_Ngach")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_Han_Ngach")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Uu_Dai")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Thue_Uu_Dai")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_Truyen")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Panel_Thong_Tin_To_Khai = New System.Windows.Forms.Panel
        Me.txtSo_Ban_In = New System.Windows.Forms.NumericUpDown
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.btnThoat = New System.Windows.Forms.Button
        Me.GrbChi_Tiet = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkTai_Lieu = New System.Windows.Forms.CheckBox
        Me.lblThong_Tin = New System.Windows.Forms.Label
        Me.dgE1_Kiem_Hoa_Xuat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GrbTong_Hop = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtTong_So_Tui = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txtTong_Trong_Luong = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txtChuyen_Bay = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.txtNguoi_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtNguoi_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtNguoi_Duoc_Uy_Quyen = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpNgay_CN38 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.btnTraCuu = New System.Windows.Forms.Button
        Me.txtSo_TKHQ = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.S = New Infragistics.Win.Misc.UltraLabel
        Me.btnOpen = New System.Windows.Forms.Button
        Me.cbSoToKhai = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.dtpNgayDangKy = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.chkIn_Phu_Luc = New System.Windows.Forms.CheckBox
        Me.Panel_Chi_Tiet_Hang_Hoa = New System.Windows.Forms.Panel
        Me.ddMaHang = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.Nhap_So = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.txtIndex_E1_Kiem_Hoa = New System.Windows.Forms.TextBox
        Me.txtTong_So_Muc_Hang = New System.Windows.Forms.TextBox
        Me.txtThong_Tin_So_Luong_Hang = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtThong_Tin_Buu_Pham_E1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnClose_Chi_Tiet = New System.Windows.Forms.Button
        Me.dgE1HangKiemHoaXuat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.mnuMenu = New System.Windows.Forms.ContextMenu
        Me.mnuTimKiem = New System.Windows.Forms.MenuItem
        Me.chk_In_KQ_KT = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.Panel_Thong_Tin_To_Khai.SuspendLayout()
        CType(Me.txtSo_Ban_In, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrbChi_Tiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbChi_Tiet.SuspendLayout()
        CType(Me.dgE1_Kiem_Hoa_Xuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrbTong_Hop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbTong_Hop.SuspendLayout()
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_Trong_Luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChuyen_Bay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNguoi_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNguoi_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNguoi_Duoc_Uy_Quyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgay_CN38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_TKHQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSoToKhai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpNgayDangKy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Chi_Tiet_Hang_Hoa.SuspendLayout()
        CType(Me.ddMaHang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nhap_So, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThong_Tin_So_Luong_Hang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThong_Tin_Buu_Pham_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1HangKiemHoaXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Thong_Tin_To_Khai
        '
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.chk_In_KQ_KT)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.txtSo_Ban_In)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.UltraLabel10)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.btnThoat)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.GrbChi_Tiet)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.GrbTong_Hop)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.btnTraCuu)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.txtSo_TKHQ)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.S)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.btnOpen)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.cbSoToKhai)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.UltraLabel3)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.dtpNgayDangKy)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.UltraLabel1)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.btnPreview)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.btnPrint)
        Me.Panel_Thong_Tin_To_Khai.Controls.Add(Me.chkIn_Phu_Luc)
        Me.Panel_Thong_Tin_To_Khai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Thong_Tin_To_Khai.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Thong_Tin_To_Khai.Name = "Panel_Thong_Tin_To_Khai"
        Me.Panel_Thong_Tin_To_Khai.Size = New System.Drawing.Size(792, 565)
        Me.Panel_Thong_Tin_To_Khai.TabIndex = 0
        '
        'txtSo_Ban_In
        '
        Me.txtSo_Ban_In.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Ban_In.ForeColor = System.Drawing.Color.Blue
        Me.txtSo_Ban_In.Location = New System.Drawing.Point(312, 520)
        Me.txtSo_Ban_In.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.txtSo_Ban_In.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtSo_Ban_In.Name = "txtSo_Ban_In"
        Me.txtSo_Ban_In.Size = New System.Drawing.Size(88, 21)
        Me.txtSo_Ban_In.TabIndex = 13
        Me.txtSo_Ban_In.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSo_Ban_In.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'UltraLabel10
        '
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(240, 520)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel10.TabIndex = 12
        Me.UltraLabel10.Text = "Số bản in"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnThoat.Location = New System.Drawing.Point(680, 8)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(104, 40)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "Th&oát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GrbChi_Tiet
        '
        Me.GrbChi_Tiet.Controls.Add(Me.Label2)
        Me.GrbChi_Tiet.Controls.Add(Me.Label1)
        Me.GrbChi_Tiet.Controls.Add(Me.chkTai_Lieu)
        Me.GrbChi_Tiet.Controls.Add(Me.lblThong_Tin)
        Me.GrbChi_Tiet.Controls.Add(Me.dgE1_Kiem_Hoa_Xuat)
        Me.GrbChi_Tiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbChi_Tiet.Location = New System.Drawing.Point(8, 152)
        Me.GrbChi_Tiet.Name = "GrbChi_Tiet"
        Me.GrbChi_Tiet.Size = New System.Drawing.Size(776, 360)
        Me.GrbChi_Tiet.SupportThemes = False
        Me.GrbChi_Tiet.TabIndex = 10
        Me.GrbChi_Tiet.Text = "Danh sách E1 trong tờ khai"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(696, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "(bưu phẩm)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(592, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tổng số :   "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkTai_Lieu
        '
        Me.chkTai_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTai_Lieu.ForeColor = System.Drawing.Color.Red
        Me.chkTai_Lieu.Location = New System.Drawing.Point(16, 329)
        Me.chkTai_Lieu.Name = "chkTai_Lieu"
        Me.chkTai_Lieu.Size = New System.Drawing.Size(288, 24)
        Me.chkTai_Lieu.TabIndex = 1
        Me.chkTai_Lieu.Text = "Có bao gồm: Thư, chứng từ, tài liệu"
        '
        'lblThong_Tin
        '
        Me.lblThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin.ForeColor = System.Drawing.Color.Blue
        Me.lblThong_Tin.Location = New System.Drawing.Point(656, 336)
        Me.lblThong_Tin.Name = "lblThong_Tin"
        Me.lblThong_Tin.Size = New System.Drawing.Size(40, 16)
        Me.lblThong_Tin.TabIndex = 2
        Me.lblThong_Tin.Text = "10"
        Me.lblThong_Tin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgE1_Kiem_Hoa_Xuat
        '
        Me.dgE1_Kiem_Hoa_Xuat.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Appearance = Appearance1
        UltraGridBand1.CardSettings.ShowCaption = False
        UltraGridColumn1.Header.Caption = "Id E1"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "ID_E2"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "ID Ca"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Mã E1"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(104, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Nước Nhận"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Nước Trả"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Width = 57
        UltraGridColumn8.Header.Caption = "Khối Lượng"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Phân Loại"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.DefaultCellValue = ""
        UltraGridColumn11.Header.Caption = "Người Gửi"
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(140, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.DefaultCellValue = ""
        UltraGridColumn12.Header.Caption = "Người Nhận"
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(108, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.DefaultCellValue = ""
        UltraGridColumn13.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(151, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.DefaultCellValue = ""
        UltraGridColumn14.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(141, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.DefaultCellValue = ""
        UltraGridColumn15.Header.Caption = "ĐT Gửi"
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.DefaultCellValue = ""
        UltraGridColumn16.Header.Caption = "ĐT Nhận"
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.Caption = "ID Người Dùng"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.Caption = "ID Trạng Thái"
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.DefaultCellValue = ""
        UltraGridColumn19.Header.Caption = "Ghi Chú"
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(138, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.DefaultCellValue = "0"
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 9
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 10
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn28.Header.Caption = "Nhập chi tiết"
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn29.Header.Caption = "Tổng số HH"
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Width = 64
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand1.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.InterBandSpacing = 20
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.HeaderAppearance = Appearance3
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Kiem_Hoa_Xuat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Kiem_Hoa_Xuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Kiem_Hoa_Xuat.Location = New System.Drawing.Point(3, 24)
        Me.dgE1_Kiem_Hoa_Xuat.Name = "dgE1_Kiem_Hoa_Xuat"
        Me.dgE1_Kiem_Hoa_Xuat.Size = New System.Drawing.Size(770, 304)
        Me.dgE1_Kiem_Hoa_Xuat.TabIndex = 0
        '
        'GrbTong_Hop
        '
        Me.GrbTong_Hop.Controls.Add(Me.txtTong_So_Tui)
        Me.GrbTong_Hop.Controls.Add(Me.txtTong_Trong_Luong)
        Me.GrbTong_Hop.Controls.Add(Me.txtChuyen_Bay)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel5)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel4)
        Me.GrbTong_Hop.Controls.Add(Me.txtNguoi_Gui)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel2)
        Me.GrbTong_Hop.Controls.Add(Me.txtNguoi_Nhan)
        Me.GrbTong_Hop.Controls.Add(Me.txtNguoi_Duoc_Uy_Quyen)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel6)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel7)
        Me.GrbTong_Hop.Controls.Add(Me.dtpNgay_CN38)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel8)
        Me.GrbTong_Hop.Controls.Add(Me.UltraLabel9)
        Me.GrbTong_Hop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbTong_Hop.Location = New System.Drawing.Point(8, 56)
        Me.GrbTong_Hop.Name = "GrbTong_Hop"
        Me.GrbTong_Hop.Size = New System.Drawing.Size(776, 96)
        Me.GrbTong_Hop.SupportThemes = False
        Me.GrbTong_Hop.TabIndex = 9
        Me.GrbTong_Hop.Text = "Thông tin tổng hợp của tờ khai"
        '
        'txtTong_So_Tui
        '
        Appearance7.ForeColor = System.Drawing.Color.Blue
        Me.txtTong_So_Tui.Appearance = Appearance7
        Me.txtTong_So_Tui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong_So_Tui.Location = New System.Drawing.Point(517, 56)
        Me.txtTong_So_Tui.MaxValue = 50
        Me.txtTong_So_Tui.MinValue = 0
        Me.txtTong_So_Tui.Name = "txtTong_So_Tui"
        Me.txtTong_So_Tui.Size = New System.Drawing.Size(88, 23)
        Me.txtTong_So_Tui.TabIndex = 11
        '
        'txtTong_Trong_Luong
        '
        Appearance8.ForeColor = System.Drawing.Color.Blue
        Me.txtTong_Trong_Luong.Appearance = Appearance8
        Me.txtTong_Trong_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong_Trong_Luong.Location = New System.Drawing.Point(672, 56)
        Me.txtTong_Trong_Luong.MaxValue = 5000
        Me.txtTong_Trong_Luong.MinValue = 0
        Me.txtTong_Trong_Luong.Name = "txtTong_Trong_Luong"
        Me.txtTong_Trong_Luong.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.txtTong_Trong_Luong.Size = New System.Drawing.Size(96, 23)
        Me.txtTong_Trong_Luong.TabIndex = 13
        '
        'txtChuyen_Bay
        '
        Appearance9.ForeColor = System.Drawing.Color.Blue
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance9.TextVAlign = Infragistics.Win.VAlign.Bottom
        Me.txtChuyen_Bay.Appearance = Appearance9
        Me.txtChuyen_Bay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChuyen_Bay.Location = New System.Drawing.Point(88, 56)
        Me.txtChuyen_Bay.Name = "txtChuyen_Bay"
        Me.txtChuyen_Bay.Size = New System.Drawing.Size(160, 23)
        Me.txtChuyen_Bay.TabIndex = 7
        Me.txtChuyen_Bay.Text = "TG565 (HAN - LON)"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(464, 31)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(136, 16)
        Me.UltraLabel5.TabIndex = 4
        Me.UltraLabel5.Text = "Người được ủy quyền"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(224, 31)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Người nhận"
        '
        'txtNguoi_Gui
        '
        Appearance10.ForeColor = System.Drawing.Color.Blue
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance10.TextVAlign = Infragistics.Win.VAlign.Bottom
        Me.txtNguoi_Gui.Appearance = Appearance10
        Me.txtNguoi_Gui.AutoSize = False
        Me.txtNguoi_Gui.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNguoi_Gui.Location = New System.Drawing.Point(80, 24)
        Me.txtNguoi_Gui.Name = "txtNguoi_Gui"
        Me.txtNguoi_Gui.Size = New System.Drawing.Size(128, 24)
        Me.txtNguoi_Gui.TabIndex = 1
        Me.txtNguoi_Gui.Text = "EMS Quốc tế"
        Me.txtNguoi_Gui.WordWrap = False
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 31)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Người gửi"
        '
        'txtNguoi_Nhan
        '
        Appearance11.ForeColor = System.Drawing.Color.Blue
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance11.TextVAlign = Infragistics.Win.VAlign.Bottom
        Me.txtNguoi_Nhan.Appearance = Appearance11
        Me.txtNguoi_Nhan.AutoSize = False
        Me.txtNguoi_Nhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNguoi_Nhan.Location = New System.Drawing.Point(304, 24)
        Me.txtNguoi_Nhan.Name = "txtNguoi_Nhan"
        Me.txtNguoi_Nhan.Size = New System.Drawing.Size(144, 24)
        Me.txtNguoi_Nhan.TabIndex = 3
        Me.txtNguoi_Nhan.Text = "EMS Australia"
        Me.txtNguoi_Nhan.WordWrap = False
        '
        'txtNguoi_Duoc_Uy_Quyen
        '
        Appearance12.ForeColor = System.Drawing.Color.Blue
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance12.TextVAlign = Infragistics.Win.VAlign.Bottom
        Me.txtNguoi_Duoc_Uy_Quyen.Appearance = Appearance12
        Me.txtNguoi_Duoc_Uy_Quyen.AutoSize = False
        Me.txtNguoi_Duoc_Uy_Quyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNguoi_Duoc_Uy_Quyen.Location = New System.Drawing.Point(600, 24)
        Me.txtNguoi_Duoc_Uy_Quyen.Name = "txtNguoi_Duoc_Uy_Quyen"
        Me.txtNguoi_Duoc_Uy_Quyen.Size = New System.Drawing.Size(168, 24)
        Me.txtNguoi_Duoc_Uy_Quyen.TabIndex = 5
        Me.txtNguoi_Duoc_Uy_Quyen.Text = "Nguyễn Thị Mộng Dung"
        Me.txtNguoi_Duoc_Uy_Quyen.WordWrap = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 62)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel6.TabIndex = 6
        Me.UltraLabel6.Text = "Chuyến bay"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(261, 62)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel7.TabIndex = 8
        Me.UltraLabel7.Text = "Ngày CN38"
        '
        'dtpNgay_CN38
        '
        Me.dtpNgay_CN38.DateTime = New Date(2009, 7, 23, 0, 0, 0, 0)
        Me.dtpNgay_CN38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_CN38.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_CN38.FormatString = "dd/MM/yyyy"
        Me.dtpNgay_CN38.Location = New System.Drawing.Point(341, 56)
        Me.dtpNgay_CN38.Name = "dtpNgay_CN38"
        Me.dtpNgay_CN38.Size = New System.Drawing.Size(104, 24)
        Me.dtpNgay_CN38.TabIndex = 9
        Me.dtpNgay_CN38.Value = New Date(2009, 7, 23, 0, 0, 0, 0)
        '
        'UltraLabel8
        '
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraLabel8.Appearance = Appearance13
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(453, 62)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel8.TabIndex = 10
        Me.UltraLabel8.Text = "Tổng (túi)"
        '
        'UltraLabel9
        '
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Left
        Me.UltraLabel9.Appearance = Appearance14
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(608, 62)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel9.TabIndex = 12
        Me.UltraLabel9.Text = "Tổng (Kg)"
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraCuu.Image = CType(resources.GetObject("btnTraCuu.Image"), System.Drawing.Image)
        Me.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTraCuu.Location = New System.Drawing.Point(536, 8)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Size = New System.Drawing.Size(104, 40)
        Me.btnTraCuu.TabIndex = 7
        Me.btnTraCuu.Text = "T&ra cứu"
        Me.btnTraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtSo_TKHQ
        '
        Appearance15.ForeColor = System.Drawing.Color.Blue
        Me.txtSo_TKHQ.Appearance = Appearance15
        Me.txtSo_TKHQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_TKHQ.Location = New System.Drawing.Point(256, 24)
        Me.txtSo_TKHQ.Name = "txtSo_TKHQ"
        Me.txtSo_TKHQ.Size = New System.Drawing.Size(96, 24)
        Me.txtSo_TKHQ.TabIndex = 5
        Me.txtSo_TKHQ.Text = "567894"
        '
        'S
        '
        Me.S.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.Location = New System.Drawing.Point(256, 5)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(96, 16)
        Me.S.TabIndex = 4
        Me.S.Text = "Số TK HQ cấp"
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOpen.Location = New System.Drawing.Point(384, 8)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(112, 40)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "&Mở tờ khai"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbSoToKhai
        '
        Appearance16.ForeColor = System.Drawing.Color.Red
        Me.cbSoToKhai.Appearance = Appearance16
        Me.cbSoToKhai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn31.Header.Caption = "Số TK"
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn31})
        Me.cbSoToKhai.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbSoToKhai.DisplayMember = ""
        Me.cbSoToKhai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSoToKhai.Location = New System.Drawing.Point(144, 24)
        Me.cbSoToKhai.Name = "cbSoToKhai"
        Me.cbSoToKhai.Size = New System.Drawing.Size(96, 24)
        Me.cbSoToKhai.TabIndex = 3
        Me.cbSoToKhai.Text = "0"
        Me.cbSoToKhai.ValueMember = ""
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(144, 5)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Số TK EMS"
        '
        'dtpNgayDangKy
        '
        Appearance17.ForeColor = System.Drawing.Color.Red
        Me.dtpNgayDangKy.Appearance = Appearance17
        Me.dtpNgayDangKy.DateTime = New Date(2009, 7, 23, 0, 0, 0, 0)
        Me.dtpNgayDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgayDangKy.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDangKy.FormatString = "dd/MM/yyyy"
        Me.dtpNgayDangKy.Location = New System.Drawing.Point(8, 24)
        Me.dtpNgayDangKy.Name = "dtpNgayDangKy"
        Me.dtpNgayDangKy.Size = New System.Drawing.Size(120, 24)
        Me.dtpNgayDangKy.TabIndex = 1
        Me.dtpNgayDangKy.Value = New Date(2009, 7, 23, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 5)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Ngày đăng ký"
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.Location = New System.Drawing.Point(464, 519)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(112, 40)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "&Xem màn hình"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(608, 519)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 40)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "&In tờ khai"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'chkIn_Phu_Luc
        '
        Me.chkIn_Phu_Luc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIn_Phu_Luc.Location = New System.Drawing.Point(24, 520)
        Me.chkIn_Phu_Luc.Name = "chkIn_Phu_Luc"
        Me.chkIn_Phu_Luc.Size = New System.Drawing.Size(184, 24)
        Me.chkIn_Phu_Luc.TabIndex = 11
        Me.chkIn_Phu_Luc.Text = "In theo kiểu bản kê phụ lục"
        '
        'Panel_Chi_Tiet_Hang_Hoa
        '
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.ddMaHang)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.Nhap_So)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.txtIndex_E1_Kiem_Hoa)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.txtTong_So_Muc_Hang)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.txtThong_Tin_So_Luong_Hang)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.txtThong_Tin_Buu_Pham_E1)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.btnClose_Chi_Tiet)
        Me.Panel_Chi_Tiet_Hang_Hoa.Controls.Add(Me.dgE1HangKiemHoaXuat)
        Me.Panel_Chi_Tiet_Hang_Hoa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Chi_Tiet_Hang_Hoa.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Chi_Tiet_Hang_Hoa.Name = "Panel_Chi_Tiet_Hang_Hoa"
        Me.Panel_Chi_Tiet_Hang_Hoa.Size = New System.Drawing.Size(792, 565)
        Me.Panel_Chi_Tiet_Hang_Hoa.TabIndex = 1
        '
        'ddMaHang
        '
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaHang.DisplayLayout.Appearance = Appearance18
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Header.Caption = "Mã hàng"
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(119, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.Caption = "Tên hàng"
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(230, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn35.CellAppearance = Appearance19
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn35.Header.Appearance = Appearance20
        UltraGridColumn35.Header.Caption = "Thuế NK"
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(55, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn36.CellAppearance = Appearance21
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn36.Header.Appearance = Appearance22
        UltraGridColumn36.Header.Caption = "Thuế VAT"
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        UltraGridBand3.UseRowLayout = True
        Me.ddMaHang.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ddMaHang.DisplayLayout.LoadStyle = Infragistics.Win.UltraWinGrid.LoadStyle.LoadOnDemand
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Appearance23.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaHang.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.ddMaHang.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ddMaHang.DisplayMember = "Ten_Hang_Hoa"
        Me.ddMaHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaHang.ImeMode = System.Windows.Forms.ImeMode.On
        Me.ddMaHang.Location = New System.Drawing.Point(144, 312)
        Me.ddMaHang.Name = "ddMaHang"
        Me.ddMaHang.Size = New System.Drawing.Size(368, 192)
        Me.ddMaHang.TabIndex = 33
        Me.ddMaHang.Text = "Danh mục hàng"
        Me.ddMaHang.ValueMember = "Ten_Hang_Hoa"
        Me.ddMaHang.Visible = False
        '
        'Nhap_So
        '
        Me.Nhap_So.Location = New System.Drawing.Point(496, 240)
        Me.Nhap_So.Name = "Nhap_So"
        Me.Nhap_So.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.Nhap_So.Size = New System.Drawing.Size(100, 21)
        Me.Nhap_So.TabIndex = 32
        Me.Nhap_So.Visible = False
        '
        'txtIndex_E1_Kiem_Hoa
        '
        Me.txtIndex_E1_Kiem_Hoa.Location = New System.Drawing.Point(344, 216)
        Me.txtIndex_E1_Kiem_Hoa.Name = "txtIndex_E1_Kiem_Hoa"
        Me.txtIndex_E1_Kiem_Hoa.TabIndex = 31
        Me.txtIndex_E1_Kiem_Hoa.Text = "Index_E1_Kiem_Hoa"
        Me.txtIndex_E1_Kiem_Hoa.Visible = False
        '
        'txtTong_So_Muc_Hang
        '
        Me.txtTong_So_Muc_Hang.Location = New System.Drawing.Point(376, 272)
        Me.txtTong_So_Muc_Hang.Name = "txtTong_So_Muc_Hang"
        Me.txtTong_So_Muc_Hang.TabIndex = 30
        Me.txtTong_So_Muc_Hang.Text = "Tong_So_Muc_Hang"
        Me.txtTong_So_Muc_Hang.Visible = False
        '
        'txtThong_Tin_So_Luong_Hang
        '
        Appearance24.BackColor = System.Drawing.Color.Black
        Appearance24.ForeColor = System.Drawing.Color.White
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        Me.txtThong_Tin_So_Luong_Hang.Appearance = Appearance24
        Me.txtThong_Tin_So_Luong_Hang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThong_Tin_So_Luong_Hang.Location = New System.Drawing.Point(644, 8)
        Me.txtThong_Tin_So_Luong_Hang.Multiline = True
        Me.txtThong_Tin_So_Luong_Hang.Name = "txtThong_Tin_So_Luong_Hang"
        Me.txtThong_Tin_So_Luong_Hang.Size = New System.Drawing.Size(144, 56)
        Me.txtThong_Tin_So_Luong_Hang.TabIndex = 29
        Me.txtThong_Tin_So_Luong_Hang.Text = "Mục hàng:           1 / 10"
        '
        'txtThong_Tin_Buu_Pham_E1
        '
        Appearance25.BackColor = System.Drawing.Color.Black
        Appearance25.ForeColor = System.Drawing.Color.White
        Me.txtThong_Tin_Buu_Pham_E1.Appearance = Appearance25
        Me.txtThong_Tin_Buu_Pham_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThong_Tin_Buu_Pham_E1.Location = New System.Drawing.Point(4, 8)
        Me.txtThong_Tin_Buu_Pham_E1.Multiline = True
        Me.txtThong_Tin_Buu_Pham_E1.Name = "txtThong_Tin_Buu_Pham_E1"
        Me.txtThong_Tin_Buu_Pham_E1.Size = New System.Drawing.Size(508, 56)
        Me.txtThong_Tin_Buu_Pham_E1.TabIndex = 28
        Me.txtThong_Tin_Buu_Pham_E1.Text = "EE22000007VN"
        '
        'btnClose_Chi_Tiet
        '
        Me.btnClose_Chi_Tiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose_Chi_Tiet.Image = CType(resources.GetObject("btnClose_Chi_Tiet.Image"), System.Drawing.Image)
        Me.btnClose_Chi_Tiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose_Chi_Tiet.Location = New System.Drawing.Point(518, 8)
        Me.btnClose_Chi_Tiet.Name = "btnClose_Chi_Tiet"
        Me.btnClose_Chi_Tiet.Size = New System.Drawing.Size(120, 56)
        Me.btnClose_Chi_Tiet.TabIndex = 22
        Me.btnClose_Chi_Tiet.Text = "    &Quay lại tờ khai"
        '
        'dgE1HangKiemHoaXuat
        '
        Me.dgE1HangKiemHoaXuat.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.dgE1HangKiemHoaXuat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance26.BackColor = System.Drawing.Color.White
        Appearance26.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Appearance = Appearance26
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 82
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.Caption = "Mã hàng"
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(93, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.AutoEdit = False
        UltraGridColumn43.Header.Caption = "Tên hàng"
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(291, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.Caption = "Xuất xứ"
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Header.Caption = "Đơn vị tính"
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.Caption = "Lượng hàng"
        UltraGridColumn46.Header.VisiblePosition = 5
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(91, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Header.Caption = "Đơn giá"
        UltraGridColumn47.Header.VisiblePosition = 10
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Header.Caption = "Mã tiền tệ"
        UltraGridColumn48.Header.VisiblePosition = 11
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.Caption = "Trị giá"
        UltraGridColumn49.Header.VisiblePosition = 12
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.VisiblePosition = 13
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.Caption = "Thuế suất"
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Header.VisiblePosition = 15
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.Caption = "Thuế VAT"
        UltraGridColumn53.Header.VisiblePosition = 16
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.VisiblePosition = 17
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.VisiblePosition = 18
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 19
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Header.VisiblePosition = 20
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Header.VisiblePosition = 22
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.VisiblePosition = 23
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.Header.VisiblePosition = 24
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.Header.VisiblePosition = 25
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.VisiblePosition = 26
        UltraGridColumn62.Hidden = True
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Header.VisiblePosition = 27
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Header.VisiblePosition = 28
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 62
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.Header.VisiblePosition = 29
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 64
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.Header.VisiblePosition = 30
        UltraGridColumn66.Hidden = True
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 66
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.Header.VisiblePosition = 21
        UltraGridColumn67.Hidden = True
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.Header.VisiblePosition = 31
        UltraGridColumn68.Hidden = True
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 68
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.Header.VisiblePosition = 32
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 70
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn70.Header.VisiblePosition = 33
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn71.Header.VisiblePosition = 34
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgE1HangKiemHoaXuat.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgE1HangKiemHoaXuat.DisplayLayout.InterBandSpacing = 10
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.CardAreaAppearance = Appearance27
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance28.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance28.ForeColor = System.Drawing.Color.Black
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance29.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.RowAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.RowSelectorAppearance = Appearance30
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance31.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.dgE1HangKiemHoaXuat.DisplayLayout.Override.SelectedRowAppearance = Appearance31
        Me.dgE1HangKiemHoaXuat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1HangKiemHoaXuat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1HangKiemHoaXuat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1HangKiemHoaXuat.Location = New System.Drawing.Point(4, 72)
        Me.dgE1HangKiemHoaXuat.Name = "dgE1HangKiemHoaXuat"
        Me.dgE1HangKiemHoaXuat.Size = New System.Drawing.Size(784, 496)
        Me.dgE1HangKiemHoaXuat.TabIndex = 23
        Me.dgE1HangKiemHoaXuat.Text = "Danh sách hàng hóa khai hải quan"
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
        'chk_In_KQ_KT
        '
        Me.chk_In_KQ_KT.Checked = True
        Me.chk_In_KQ_KT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_In_KQ_KT.Location = New System.Drawing.Point(312, 544)
        Me.chk_In_KQ_KT.Name = "chk_In_KQ_KT"
        Me.chk_In_KQ_KT.Size = New System.Drawing.Size(88, 16)
        Me.chk_In_KQ_KT.TabIndex = 34
        Me.chk_In_KQ_KT.Text = "In kết quả KT"
        '
        'Frm_Lap_To_Khai_Chuyen_Hoan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_Thong_Tin_To_Khai)
        Me.Controls.Add(Me.Panel_Chi_Tiet_Hang_Hoa)
        Me.Name = "Frm_Lap_To_Khai_Chuyen_Hoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kê khai hàng hóa xuất khẩu"
        Me.Panel_Thong_Tin_To_Khai.ResumeLayout(False)
        CType(Me.txtSo_Ban_In, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrbChi_Tiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbChi_Tiet.ResumeLayout(False)
        CType(Me.dgE1_Kiem_Hoa_Xuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrbTong_Hop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbTong_Hop.ResumeLayout(False)
        CType(Me.txtTong_So_Tui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_Trong_Luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChuyen_Bay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNguoi_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNguoi_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNguoi_Duoc_Uy_Quyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgay_CN38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_TKHQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSoToKhai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpNgayDangKy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Chi_Tiet_Hang_Hoa.ResumeLayout(False)
        CType(Me.ddMaHang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nhap_So, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThong_Tin_So_Luong_Hang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThong_Tin_Buu_Pham_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1HangKiemHoaXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien dung de truyen sang cac Form khac"
    Public GFrm_Is_Tim_Kiem As Boolean
    Public GFrm_Ma_To_Khai As String
    Public GFrm_Ngay_Dang_Ky As Date
    Public GFrm_Kieu_Kiem_Hoa As Integer
    Public GFrm_So_To_Khai As Integer
#End Region

#Region "Khai báo biến toàn Form"
    Private Const myNguoi_Gui As String = "EMS Quốc tế"
    Private Const myThong_Tin_Tai_Lieu As String = "Thư, chứng từ, tài liệu đã giao dịch"
    Private myTo_Khai_Hai_Quan_Xuat As New To_Khai_Hai_Quan_Xuat(GConnectionString)
    Private myE1_Kiem_Hoa_Xuat As New E1_Kiem_Hoa_Xuat(GConnectionString)
    Private myE1_Hang_Kiem_Hoa_Xuat As New E1_Hang_Kiem_Hoa_Xuat(GConnectionString)
    Private myNguoi_Dung As New Nguoi_Dung(GConnectionString)
    Private myTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet
    Private myE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet
    Private myHam_Dung_Chung As New Ham_Dung_Chung
    'Private mySender As Object
    Private Const myKieu_Kiem_Hoa As Integer = 9
    Private Const mySo_Ban_In_To_Khai_Xuat As Integer = 2
    Private isTaoMoi As Boolean   'Xac dinh la tao to khai moi hay mo to khai da ton tai
    Private isOpen As Boolean  'Bien dieu khien dong mo to khai
    Private myMa_To_Khai_Thuc_Cap As String
    Private mySo_To_Khai_Thuc_Cap As Integer
    Private FrmTK As FrmTimKiemDanhMuc = Nothing
    Private myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myDa_Lay_Thong_Tin As Boolean = False
    Private isCloseForm As Boolean

    'Danh muc hang hoa lay tu Custom
    Dim myData As New DataTable
    Dim myDataView As New DataView
    Dim m_is_select As Boolean
    'Bien dieu khien viec co quay lai o nhap ten hang hay khong
    Dim IsQuay_Lai_Ten_Hang As Boolean = False
    Dim IsDa_Kiem_Tra_Hang_Cam_Nhap As Boolean = False

    Dim myDanhMucHang As New Danh_Muc_Hang(GConnectionString)
    Dim myId_Hang_Hoa As String

#End Region

#Region "Hàm dùng chung"
#Region "KeyEnter"
    Private Sub txtNguoi_Gui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNguoi_Gui.KeyDown, txtNguoi_Nhan.KeyDown, txtNguoi_Duoc_Uy_Quyen.KeyDown, txtChuyen_Bay.KeyDown
        Dim mSender As Infragistics.Win.UltraWinEditors.UltraTextEditor
        mSender = sender
        If e.KeyValue = Keys.Enter Then
            If mSender.Text.Trim = "" Then
                Exit Sub
            End If
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
    Private Sub dtpNgayDangKy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpNgayDangKy.KeyDown, cbSoToKhai.KeyDown, txtSo_TKHQ.KeyDown, dtpNgay_CN38.KeyDown, chkTai_Lieu.KeyDown, chkIn_Phu_Luc.KeyDown, txtSo_Ban_In.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#Region "txtTong_Trong_Luong_KeyDown"
    Private Sub txtTong_Trong_Luong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTong_Trong_Luong.KeyDown
        If e.KeyValue = Keys.Enter Then
            If txtTong_Trong_Luong.Value = 0 Then
                Exit Sub
            End If
            dgE1_Kiem_Hoa_Xuat.Select()
            'If dgE1_Kiem_Hoa_Xuat.Rows.Count > 0 Then
            '    AddNewRow(dgE1_Kiem_Hoa_Xuat, True)
            'Else
            '    AddNewRow(dgE1_Kiem_Hoa_Xuat, False)
            'End If
            If dgE1_Kiem_Hoa_Xuat.Rows.Count = 0 Then
                AddNewRow(dgE1_Kiem_Hoa_Xuat, False)
            End If
            dgE1_Kiem_Hoa_Xuat.ActiveCell = dgE1_Kiem_Hoa_Xuat.Rows(dgE1_Kiem_Hoa_Xuat.Rows.Count - 1).Cells("Ma_E1")
            dgE1_Kiem_Hoa_Xuat.PerformAction(EnterEditMode, False, False)
        End If
    End Sub
#End Region
#Region "txtTong_So_Tui_KeyDown"
    Private Sub txtTong_So_Tui_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTong_So_Tui.KeyDown
        If e.KeyValue = Keys.Enter Then
            If txtTong_So_Tui.Value = 0 Then
                Exit Sub
            End If
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region
#End Region
#Region "txtGotFocus"
    Private Sub txtNguoi_Gui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNguoi_Gui.GotFocus, txtNguoi_Nhan.GotFocus, txtNguoi_Duoc_Uy_Quyen.GotFocus, txtChuyen_Bay.GotFocus, txtSo_TKHQ.GotFocus
        Dim mySender As Infragistics.Win.UltraWinEditors.UltraTextEditor
        mySender = sender
        If mySender.IsInEditMode = True Then
            mySender.SelectionStart = 0
            mySender.SelectionLength = mySender.Text.Length
        End If
    End Sub

    Private Sub txtTong_So_Tui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_So_Tui.GotFocus, txtTong_Trong_Luong.GotFocus
        Dim mySender As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        mySender = sender
        If mySender.IsInEditMode = True Then
            mySender.SelectionStart = 0
            mySender.SelectionLength = mySender.Text.Length
        End If
    End Sub
#End Region

#End Region

#Region "TabControl"
#Region "Form_Load"
    Private Sub Frm_Lap_To_Khai_Chuyen_Hoan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Đặt tên form theo sự kiện
            Me.Text = "Kê khai hàng hóa xuất khẩu (----- Thông tin tờ khai -----)"
            'Khởi tạo các biến điều khiển với giá trị mặc định ban đầu
            isOpen = False
            isTaoMoi = False
            isCloseForm = False
            'Lay Thong Tin Ip May Tinh va Ban So
            GIp_May_Tinh = Get_Ip_MyComputer()
            GBan_So = 0

            'Load danh muc hang
            GetDanhMucHang()

            'Hiện Panel Tổng hợp, ẩn panel chi tiết hàng hóa
            Panel_Thong_Tin_To_Khai.Visible = True
            Panel_Chi_Tiet_Hang_Hoa.Visible = False
            'Gán thông tin mặc định ban đầu
            Gan_Thong_Tin_Mac_Dinh_Tren_Form_Khi_Load_Form()
            'Điều chỉnh mờ / rõ các control trên form
            EnableControl(isOpen)
            'Nếu được mở từ Form Tìm Kiếm Tờ Khai
            If GFrm_Is_Tim_Kiem Then
                'Truyen gia tri tu form tim kiem vao form kiem hoa de mo to khai
                dtpNgayDangKy.Value = GFrm_Ngay_Dang_Ky
                GFrm_Kieu_Kiem_Hoa = myKieu_Kiem_Hoa
                'cbKieuKiemHoa_Validated(cbKieuKiemHoa, e)
                cbSoToKhai.Select()
                cbSoToKhai.Value = GFrm_So_To_Khai
                cbSoToKhai.Text = GFrm_So_To_Khai
                'cbSoToKhai_Validated(cbSoToKhai, e)
                btnOpen.Select()
                'btnOpen_Click(btnOpen, e)
                GFrm_Is_Tim_Kiem = False
                If isCloseForm Then
                    isCloseForm = False
                    Me.Close()
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Panel Thông tin tổng hợp của tờ khai"
#Region "btnOpen_Click"
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Try
            If dtpNgayDangKy.Text = "" Then
                Exit Sub
            End If
            '----------------------------------------------------------------------------------
            Dim tmp_Ma_To_Khai As String
            'Tao Ma_To_Khai
            If cbSoToKhai.Text = "0" Or cbSoToKhai.Text = "" Then
                tmp_Ma_To_Khai = GIp_May_Tinh
            Else
                tmp_Ma_To_Khai = Create_Ma_To_Khai(myKieu_Kiem_Hoa, myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), cbSoToKhai.Text)
            End If
            'Bat dau xu ly
            isTaoMoi = False   'Khoi tao trang thai tao moi to khai
            If Not isOpen Then  ' Mo to khai            
                If Mo_To_Khai_Hai_Quan_Xuat(tmp_Ma_To_Khai) Then  'Neu mo thanh cong
                    'Chuyen sang trang thai dong
                    isOpen = Not isOpen
                    'Set lai Enable Control ung voi trang thai Mo to khai
                    EnableControl(isOpen)
                    txtNguoi_Gui.Select()
                    'Enable_Before_Open_To_Khai(isOpen)
                Else  'Mo to khai that bai
                    'Gan lai thong tin so to khai = 0 => tao moi-----------------------
                    cbSoToKhai.Value = 0
                    cbSoToKhai.Text = 0
                    myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = GIp_May_Tinh
                    myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = "0"
                    myMa_To_Khai_Thuc_Cap = ""
                    mySo_To_Khai_Thuc_Cap = 0
                    'Nếu mở từ chức năng tìm kiếm thì đóng form kiem hoa lại
                    If GFrm_Is_Tim_Kiem Then
                        isCloseForm = True
                        Exit Sub
                    End If
                    cbSoToKhai.Select()
                End If
            Else    ' Dong to khai 
                'Neu to khai da ton tai thi hoi co ghi lai hay khong
                '====chu y to khai da ton tai, sau khi mở thông tin sẽ được gán lên Form
                '====vì vậy, sử dụng thông tin trên form để kiểm tra
                If cbSoToKhai.Value <> 0 Then
                    tmp_Ma_To_Khai = Create_Ma_To_Khai(myKieu_Kiem_Hoa, myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), cbSoToKhai.Text)
                    If myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay(tmp_Ma_To_Khai).Ngay_Khai <> 0 Then
                        Dim mLua_Chon As Integer
                        mLua_Chon = MessageBox.Show("Bạn có chắc chắn muốn ghi lại thông tin tờ khai này lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                        Select Case mLua_Chon
                            Case 2   'Cancel
                                Exit Sub
                            Case 6   'Yes
                                If Kiem_Tra_To_Khai_Trong() = 0 Then
                                    If chkTai_Lieu.Checked Then
                                        If Not MessageBox.Show("Tờ khai này chỉ có tài liệu, không có bưu kiện và hàng hóa!!!" & vbNewLine & "Bạn có chắc chắn muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                                            Dong_To_Khai_Hai_Quan(tmp_Ma_To_Khai)
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("Tờ khai này không có thông tin về bưu phẩm cần kiểm hóa, vì vậy không thể cập nhật tờ khai.", "Lỗi cập nhật tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                End If
                                Dim mThong_Bao_OutPut As String
                                If Cap_Nhat_To_Khai_Hang_Xuat(tmp_Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao_OutPut) = True Then
                                    MessageBox.Show("Đã cập nhật thành công tờ khai số:  " & Format_So_TKHQ(cbSoToKhai.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Dong_To_Khai_Hai_Quan(tmp_Ma_To_Khai)
                                End If
                            Case 7   'No
                                Dong_To_Khai_Hai_Quan(tmp_Ma_To_Khai)
                        End Select
                    End If
                Else     'to khai tao moi thi cap nhat va dong
                    If Kiem_Tra_To_Khai_Trong() = 0 Then
                        If Not chkTai_Lieu.Checked Then
                            Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                            Exit Sub
                        Else
                            If txtNguoi_Nhan.Text <> "" And txtChuyen_Bay.Text <> "" Then
                                If MessageBox.Show("Tờ khai này chưa có thông tin bưu kiện và hàng hóa, bạn có muốn cập nhật tờ khai không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                                    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                                    Exit Sub
                                End If
                            Else
                                Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                                Exit Sub
                            End If
                        End If
                    End If
                    Dim mThong_Bao_OutPut As String
                    If Cap_Nhat_To_Khai_Hang_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao_OutPut) = True Then
                        MessageBox.Show("Đã cập nhật thành công tờ khai số:  " & myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnTraCuu_Click"
    Private Sub btnTraCuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraCuu.Click
        Dim frmTraCuu As New FrmTimKiemE1
        frmTraCuu.ShowDialog()
    End Sub
#End Region
#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Dim tmp_Ma_To_Khai As String
        If isOpen Then    'Chi xu ly voi truong hop dang mo 1 to khai (bao gom ca: tao moi & cap nhat)
            'Neu to khai da ton tai thi hoi co ghi lai hay khong
            '====chu y to khai da ton tai, sau khi mở thông tin sẽ được gán lên Form
            '====vì vậy, sử dụng thông tin trên form để kiểm tra
            If cbSoToKhai.Value <> 0 Then
                tmp_Ma_To_Khai = Create_Ma_To_Khai(myKieu_Kiem_Hoa, myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), cbSoToKhai.Text)
                If myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay(tmp_Ma_To_Khai).Ngay_Khai <> 0 Then
                    Dim mLua_Chon As Integer
                    mLua_Chon = MessageBox.Show("Bạn có chắc chắn muốn ghi lại thông tin tờ khai này lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    Select Case mLua_Chon
                        Case 2   'Cancel
                            Exit Sub
                        Case 6   'Yes
                            If Kiem_Tra_To_Khai_Trong() = 0 Then
                                MessageBox.Show("Tờ khai này không có thông tin về bưu phẩm cần kiểm hóa, vì vậy không thể cập nhật tờ khai.", "Lỗi cập nhật tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            Dim mThong_Bao_OutPut As String
                            If Cap_Nhat_To_Khai_Hang_Xuat(tmp_Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao_OutPut) = True Then
                                MessageBox.Show("Đã cập nhật thành công tờ khai số:  " & Format_So_TKHQ(cbSoToKhai.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Dong_To_Khai_Hai_Quan(tmp_Ma_To_Khai)
                                Me.Close()
                                Me.Dispose()
                            End If
                        Case 7   'No
                            Dong_To_Khai_Hai_Quan(tmp_Ma_To_Khai)
                            Me.Close()
                            Me.Dispose()
                    End Select
                End If
            Else     'to khai tao moi thi cap nhat va dong
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                    Me.Close()
                    Me.Dispose()
                    Exit Sub
                End If
                Dim mThong_Bao_OutPut As String
                If Cap_Nhat_To_Khai_Hang_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao_OutPut) = True Then
                    MessageBox.Show("Đã cập nhật thành công tờ khai số:  " & myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                    Me.Close()
                    Me.Dispose()
                End If
            End If
        Else
            Me.Close()
            Me.Dispose()
        End If
    End Sub
#End Region
#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If Not chkTai_Lieu.Checked Then
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    MessageBox.Show("Tờ khai này không có thông tin về bưu phẩm cần kiểm hóa, vì vậy không thể cập nhật tờ khai.", "Lỗi cập nhật tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                'Preview To Khai
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    chkIn_Phu_Luc.Checked = False
                End If
            End If

            Dim mThong_Bao As String
            If Cap_Nhat_To_Khai_Hang_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao) Then
                'If In_To_Khai_Hai_Quan_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, chkIn_Phu_Luc.Checked, True, txtSo_Ban_In.Value) Then
                If In_To_Khai_Hai_Quan_Xuat_HQ2015XK(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, chkIn_Phu_Luc.Checked, True, txtSo_Ban_In.Value) Then
                    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                Else
                    MessageBox.Show("Xảy ra lỗi trong quá trình in tờ khai!!! Hãy báo với người quản trị về lỗi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật tờ khai!!! Hãy báo cho người quản trị về lỗi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "btnPrint_Click"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If Not chkTai_Lieu.Checked Then
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    MessageBox.Show("Tờ khai này không có thông tin về bưu phẩm cần kiểm hóa, vì vậy không thể cập nhật tờ khai.", "Lỗi cập nhật tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                'Preview To Khai
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    chkIn_Phu_Luc.Checked = False
                End If
            End If

            Dim mThong_Bao As String
            If Cap_Nhat_To_Khai_Hang_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, myKieu_Kiem_Hoa, mThong_Bao) Then
                If Kiem_Tra_To_Khai_Trong() = 0 Then
                    chkIn_Phu_Luc.Checked = False
                End If
                'In To Khai cũ
                'If In_To_Khai_Hai_Quan_Xuat(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, chkIn_Phu_Luc.Checked, False, txtSo_Ban_In.Value) Then
                '    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                'Else
                '    MessageBox.Show("Xảy ra lỗi trong quá trình in tờ khai!!! Hãy báo với người quản trị về lỗi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
                'In to khai HQ2015XK
                If In_To_Khai_Hai_Quan_Xuat_HQ2015XK(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, chkIn_Phu_Luc.Checked, False, txtSo_Ban_In.Value) Then
                    Dong_To_Khai_Hai_Quan(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                Else
                    MessageBox.Show("Xảy ra lỗi trong quá trình in tờ khai!!! Hãy báo với người quản trị về lỗi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật tờ khai!!! Hãy báo cho người quản trị về lỗi này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dtpNgayDangKy_Validated"
    Private Sub dtpNgayDangKy_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgayDangKy.Validated
        Try
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value) > myHam_Dung_Chung.ConvertDateToInt(Now().Date) Then
                If MessageBox.Show("Ngày khai lớn hơn ngày hiện tại, Bạn có muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dtpNgayDangKy.Select()
                    Exit Sub
                End If
            End If
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value) < myHam_Dung_Chung.ConvertDateToInt(Now().Date) Then
                If MessageBox.Show("Ngày khai nhỏ hơn ngày hiện tại, Bạn có muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dtpNgayDangKy.Select()
                    Exit Sub
                End If
            End If
            'Lay danh sach so to khai hang xuat
            GetDanhSachSoToKhai(myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), myKieu_Kiem_Hoa)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dtpNgay_CN38_Validated"
    Private Sub dtpNgay_CN38_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNgay_CN38.Validated
        Try
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgay_CN38.Value) > myHam_Dung_Chung.ConvertDateToInt(Now().Date) Then
                If MessageBox.Show("Ngày CN38 lớn hơn ngày hiện tại, Bạn có muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dtpNgay_CN38.Select()
                    Exit Sub
                End If
            End If
            If myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value) <> myHam_Dung_Chung.ConvertDateToInt(dtpNgay_CN38.Value) Then
                If MessageBox.Show("Ngày CN38 sai khác so với ngày mở tờ khai, Bạn có muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dtpNgay_CN38.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "cbSoToKhai_Validated"
    Private Sub cbSoToKhai_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSoToKhai.Validated
        Try
            'La tao moi thi khong kiem tra
            If cbSoToKhai.Text = "" Or cbSoToKhai.Text = "0" Then
                Exit Sub
            End If
            'Kiểm tra so to khai: Không được nhập số to khai lung tung
            If Not IsNumeric(cbSoToKhai.Text) Then
                MessageBox.Show("Số tờ khai phải là dạng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbSoToKhai.Select()
                Exit Sub
            End If
            Dim mTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay(Create_Ma_To_Khai(myKieu_Kiem_Hoa, myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), CInt(cbSoToKhai.Text)))
            If mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ <> "" Then
                If mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa <> myKieu_Kiem_Hoa Then
                    MessageBox.Show("Số tờ khai này không dùng cho tờ khai hàng xuất, vì vậy bạn không thể mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbSoToKhai.Select()
                    Exit Sub
                Else
                    btnOpen_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "txtChuyen_Bay_Validated"
    Private Sub txtChuyen_Bay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChuyen_Bay.Validated
        txtChuyen_Bay.Value = txtChuyen_Bay.Text.ToUpper
        'txtChuyen_Bay.Text = txtChuyen_Bay.Text.ToUpper
    End Sub
#End Region
#Region "=================dgE1_Kiem_Hoa_Xuat=============="
#Region "dgE1_Kiem_Hoa_Xuat_InitializeLayout"
    Private Sub dgE1_Kiem_Hoa_Xuat_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Kiem_Hoa_Xuat.InitializeLayout
        Try
            Dim i As Integer
            myGridKeyDown = sender
            dgE1_Kiem_Hoa_Xuat.Tag = True
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom

            'Cho phep & Khong cho phep sua
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_E1").CellActivation = Activation.AllowEdit
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nuoc_Tra").CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Khoi_Luong").CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Phan_Loai").CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nguoi_Gui").CellActivation = Activation.AllowEdit
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Dia_Chi_Gui").CellActivation = Activation.AllowEdit
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").CellActivation = Activation.AllowEdit
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Dia_Chi_Nhan").CellActivation = Activation.AllowEdit
            'myGridKeyDown.DisplayLayout.Bands(0).Columns("Nhap_Chi_Tiet").CellActivation = Activation.AllowEdit
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_Muc_Hang").CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_Tri_Gia").CellActivation = Activation.ActivateOnly
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_InitializeTemplateAddRow"
    Private Sub dgE1_Kiem_Hoa_Xuat_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgE1_Kiem_Hoa_Xuat.InitializeTemplateAddRow
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Bands(0).Columns("STT").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_Muc_Hang").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_Tri_Gia").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Nhap_Chi_Tiet_Hang_Hoa").DefaultCellValue = "Chi tiet"
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Truyen_Khai_Thac").DefaultCellValue = CBool(0)
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Truyen_Doi_Soat").DefaultCellValue = CBool(0)
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chot_SL").DefaultCellValue = CBool(0)
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_AfterExitEditMode"
    Private Sub dgE1_Kiem_Hoa_Xuat_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Kiem_Hoa_Xuat.AfterExitEditMode
        Try
            Dim mE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Or dgE1_Kiem_Hoa_Xuat.Tag = False Then
                Exit Sub
            End If
            'Luu gia tri de cho phep Next Cell
            myDa_Lay_Thong_Tin = False
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ma_E1"
                    If myGridKeyDown.ActiveRow.Cells("Id_E1").Text.Trim <> "" Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        Exit Sub
                    End If
                    'Kiem tra & load du lieu
                    If Not Lay_Thong_Tin_E1_Den(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, myGridKeyDown.ActiveRow.Cells("Ma_E1").Text, mE1_Kiem_Hoa_Xuat_Chi_Tiet) Then
                        'Khong cho Next Cell
                        myDa_Lay_Thong_Tin = False
                        dgE1_Kiem_Hoa_Xuat.Tag = False
                        Exit Sub
                    Else
                        'Gan du lieu load duoc vao luoi
                        myGridKeyDown.ActiveRow.Cells("Id_E1").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1
                        myGridKeyDown.ActiveRow.Cells("Id_E2").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E2
                        myGridKeyDown.ActiveRow.Cells("Id_Ca").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca
                        myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac
                        'myGridKeyDown.ActiveRow.Cells("Ma_E1").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_E1
                        myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Nhan
                        myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Tra
                        myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Khoi_Luong
                        myGridKeyDown.ActiveRow.Cells("Phan_Loai").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Phan_Loai
                        If myGridKeyDown.ActiveRow.Cells("STT").Value = 0 Or myGridKeyDown.ActiveRow.Cells("STT").Text = "" Then
                            myGridKeyDown.ActiveRow.Cells("STT").Value = myGridKeyDown.ActiveRow.Index + 1
                        End If
                        myGridKeyDown.ActiveRow.Cells("Nguoi_Gui").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Gui
                        myGridKeyDown.ActiveRow.Cells("Nguoi_Nhan").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Nhan
                        myGridKeyDown.ActiveRow.Cells("Dia_Chi_Gui").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Gui
                        myGridKeyDown.ActiveRow.Cells("Dia_Chi_Nhan").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Nhan
                        myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Gui").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Gui
                        myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Nhan").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Nhan
                        myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung
                        myGridKeyDown.ActiveRow.Cells("Id_Trang_Thai").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Trang_Thai
                        myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ghi_Chu
                        myGridKeyDown.ActiveRow.Cells("Truyen_Khai_Thac").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Khai_Thac
                        myGridKeyDown.ActiveRow.Cells("Truyen_Doi_Soat").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Doi_Soat
                        myGridKeyDown.ActiveRow.Cells("Ngay_He_Thong").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong
                        myGridKeyDown.ActiveRow.Cells("Gio_He_Thong").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong
                        myGridKeyDown.ActiveRow.Cells("Chot_SL").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL
                        myGridKeyDown.ActiveRow.Cells("Ma_To_Khai").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai
                        myGridKeyDown.ActiveRow.Cells("Ip_May_Tinh").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ip_May_Tinh
                        myGridKeyDown.ActiveRow.Cells("Ban_So").Value = mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ban_So
                        myDa_Lay_Thong_Tin = True
                        'Them dong moi chuan bị nhập tiếp theo
                        'AddNewRow(myGridKeyDown, True)
                    End If
                    myGridKeyDown.ActiveCell.Value = myGridKeyDown.ActiveCell.Text.Trim.ToUpper
                Case Else
                    myDa_Lay_Thong_Tin = False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_AfterRowUpdate"
    Private Sub dgE1_Kiem_Hoa_Xuat_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1_Kiem_Hoa_Xuat.AfterRowUpdate
        Try
            myGridKeyDown = sender
            'Ma_E1  (bat loi nguoi dung co tinh lam loi)
            If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
                CMessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào tờ khai" & vbNewLine & "Mã E1 không được để trống.", " Thông báo ")
                myGridKeyDown.ActiveRow.Delete(False)
                Exit Sub
                'If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
                '    myGridKeyDown.ActiveRow.Delete(False)
                '    Exit Sub
                'End If
            End If
            If myGridKeyDown.ActiveRow.Cells("Id_E1").Text = "" Then
                MessageBox.Show("Thông tin chưa đầy đủ vì vậy không thể cập nhật dữ liệu vào tờ khai" & vbNewLine & "Bưu phẩm đang kiểm hóa không có thông tin xác nhận đến tại khai thác QT đi.", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                myGridKeyDown.ActiveRow.Delete(False)
                Exit Sub
                'If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text = "" Then
                '    myGridKeyDown.ActiveRow.Delete(False)
                '    Exit Sub
                'End If
            End If
            'Cap nhat vao E1_Kiem_Hoa_Xuat
            Insert_Into_E1_Kiem_Hoa_Xuat()
            Gan_Thong_Tin_Cho_Label_Thong_Tin(Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_AfterCellUpdate"
    Private Sub dgE1_Kiem_Hoa_Xuat_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE1_Kiem_Hoa_Xuat.AfterCellUpdate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.ActiveRow.Cells("Ma_E1").Text <> "" And myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text <> "" Then
            AddNewRow(myGridKeyDown, True)
        End If
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_KeyDown"
    Private Sub dgE1_Kiem_Hoa_Xuat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Kiem_Hoa_Xuat.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    If e.KeyValue = Keys.Enter And myGridKeyDown.ActiveCell.Column.Key = "Nhap_Chi_Tiet_Hang_Hoa" Then
                        dgE1_Kiem_Hoa_Xuat_ClickCellButton(dgE1_Kiem_Hoa_Xuat, Nothing)
                        Exit Sub
                    End If
                    'Lay index cua Cell dang Active
                    myCell = myGridKeyDown.ActiveCell
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra Cell co Value = Null, khong cho next cell
                    If myGridKeyDown.ActiveCell.Column.Key = "Ma_E1" Then
                        If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                            myGridKeyDown.ActiveCell = myCell
                            e.Handled = True
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myCell = Nothing
                            Exit Sub
                        End If
                    End If
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If myGridKeyDown.Tag = False Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        dgE1_Kiem_Hoa_Xuat.Tag = True
                        myCell = Nothing
                        Exit Sub
                    End If
                    'Next cell hoac di chuyen den cot Nguoi_Gui
                    If myGridKeyDown.ActiveCell.Column.Key = "Ma_E1" And myDa_Lay_Thong_Tin = True Then
                        myGridKeyDown.ActiveCell = myGridKeyDown.ActiveRow.Cells("Nguoi_Gui")
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    Else
                        myGridKeyDown.PerformAction(NextCellByTab, False, False)
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Case Keys.F8
                    Delete_Row_E1_Kiem_Hoa_Xuat()
                    Gan_Thong_Tin_Cho_Label_Thong_Tin(Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa)
                    e.Handled = True
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length Then
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
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.SelStart = 0 Then
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
#Region "dgE1_Kiem_Hoa_Xuat_MouseDown"
    Private Sub dgE1_Kiem_Hoa_Xuat_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgE1_Kiem_Hoa_Xuat.MouseDown
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
#Region "dgE1_Kiem_Hoa_Xuat_ClickCellButton"
    Private Sub dgE1_Kiem_Hoa_Xuat_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE1_Kiem_Hoa_Xuat.ClickCellButton
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" Then
                'Gan thong tin E1 kiểm hóa xuất vào biến
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1 = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E2 = myGridKeyDown.ActiveRow.Cells("Id_E2").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca = myGridKeyDown.ActiveRow.Cells("Id_Ca").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_E1 = myGridKeyDown.ActiveRow.Cells("Ma_E1").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Nhan = myGridKeyDown.ActiveRow.Cells("Nuoc_Nhan").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Tra = myGridKeyDown.ActiveRow.Cells("Nuoc_Tra").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Khoi_Luong = myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Phan_Loai = myGridKeyDown.ActiveRow.Cells("Phan_Loai").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.STT = myGridKeyDown.ActiveRow.Cells("STT").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Gui = myGridKeyDown.ActiveRow.Cells("Nguoi_Gui").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Nhan = myGridKeyDown.ActiveRow.Cells("Nguoi_Nhan").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Gui = myGridKeyDown.ActiveRow.Cells("Dia_Chi_Gui").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Nhan = myGridKeyDown.ActiveRow.Cells("Dia_Chi_Nhan").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Gui = myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Gui").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Nhan = myGridKeyDown.ActiveRow.Cells("Dien_Thoai_Nhan").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung = myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Trang_Thai = myGridKeyDown.ActiveRow.Cells("Id_Trang_Thai").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ghi_Chu = myGridKeyDown.ActiveRow.Cells("Ghi_Chu").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Khai_Thac = myGridKeyDown.ActiveRow.Cells("Truyen_Khai_Thac").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Doi_Soat = myGridKeyDown.ActiveRow.Cells("Truyen_Doi_Soat").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong = myGridKeyDown.ActiveRow.Cells("Ngay_He_Thong").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong = myGridKeyDown.ActiveRow.Cells("Gio_He_Thong").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL = myGridKeyDown.ActiveRow.Cells("Chot_SL").Value
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = myGridKeyDown.ActiveRow.Cells("Ma_To_Khai").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ip_May_Tinh = myGridKeyDown.ActiveRow.Cells("Ip_May_Tinh").Text
                myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ban_So = myGridKeyDown.ActiveRow.Cells("Ban_So").Value
                'Ghi lại index của dòng đang active trên dgE1_Kiem_Hoa_Xuat
                txtIndex_E1_Kiem_Hoa.Text = myGridKeyDown.ActiveRow.Index
                'Load du lieu hang hoa theo E1_Kiem_Hoa
                DataGrid_E1_Hang_Kiem_Hoa(myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1)
                'Hiện Panel chi tiết
                Panel_Thong_Tin_To_Khai.Visible = False
                Panel_Chi_Tiet_Hang_Hoa.Visible = True
                'Thay đổi Caption của Form
                Me.Text = "Kê khai hàng hóa xuất khẩu (----- Thông tin chi tiết hàng hóa -----)"
                'Hiện lại thông tin trên label của Panel chi tiết
                Gan_Thong_Tin_Tren_TextBox_Buu_Pham_E1()
                Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
                'Active vào lưới để nhập chi tiết
                dgE1HangKiemHoaXuat.Select()
                'If dgE1HangKiemHoaXuat.Rows.Count > 0 Then
                '    AddNewRow(dgE1HangKiemHoaXuat, True)
                'Else
                '    AddNewRow(dgE1HangKiemHoaXuat, False)
                'End If
                If dgE1HangKiemHoaXuat.Rows.Count = 0 Then
                    AddNewRow(dgE1HangKiemHoaXuat, False)
                End If
                dgE1HangKiemHoaXuat.ActiveCell = dgE1HangKiemHoaXuat.Rows(dgE1HangKiemHoaXuat.Rows.Count - 1).Cells("Ten_Hang_Hoa")
                dgE1HangKiemHoaXuat.PerformAction(EnterEditMode, False, False)
            Else
                MessageBox.Show("Thông tin về bưu phẩm không có, vì vậy bạn không thể nhập chi tiết hàng hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1_Kiem_Hoa_Xuat_BeforeCellUpdate"
    Private Sub dgE1_Kiem_Hoa_Xuat_BeforeCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles dgE1_Kiem_Hoa_Xuat.BeforeCellUpdate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell.Column.Key = "Ma_E1" And myGridKeyDown.ActiveRow.Cells("Id_E1").Text <> "" Then
            If myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Lay(myGridKeyDown.ActiveRow.Cells("Id_E1").Text).Ma_E1 <> "" Then
                MessageBox.Show("Mã E1 này đã được ghi vào tờ khai, bạn không thể thay đổi thông tin mã E1." & vbNewLine & "Nếu muốn thay đổi bạn có thể xoá E1 này đi và thêm E1 mới vào.", "Thông báo", MessageBoxButtons.OK)
                'DataGrid_Don_Vinh_Tinh()
                'Gan bien = False de khong cho Next Cell
                dgE1_Kiem_Hoa_Xuat.Tag = False
                e.Cancel = True
                Exit Sub
            End If
        End If
        dgE1_Kiem_Hoa_Xuat.Tag = True
    End Sub
#End Region

    '#Region "dgE1_Kiem_Hoa_Xuat_AfterRowInsert"
    '    Private Sub dgE1_Kiem_Hoa_Xuat_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1_Kiem_Hoa_Xuat.AfterRowInsert
    '        'Gan_Thong_Tin_Cho_Label_Thong_Tin(Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa)
    '    End Sub
    '#End Region
    '#Region "dgE1_Kiem_Hoa_Xuat_AfterRowsDeleted"
    '    Private Sub dgE1_Kiem_Hoa_Xuat_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Kiem_Hoa_Xuat.AfterRowsDeleted
    '        'Gan_Thong_Tin_Cho_Label_Thong_Tin(Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa)
    '    End Sub
    '#End Region
#End Region
#End Region
#Region "Panel chi tiết hàng hóa"
#Region "btnClose_Chi_Tiet_Click"
    Private Sub btnClose_Chi_Tiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose_Chi_Tiet.Click
        Ket_Thuc_Nhap_Chi_Tiet_Hang_Hoa(CInt(txtIndex_E1_Kiem_Hoa.Text))
    End Sub
#End Region
#Region "==============Grid Chi tiết hàng hóa================="
#Region "dgE1HangKiemHoaXuat_InitializeLayout"
    Private Sub dgE1HangKiemHoaXuat_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1HangKiemHoaXuat.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
            dgE1HangKiemHoaXuat.Tag = True
            Dim idx As Integer
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Luong_Hang").EditorControl = Nhap_So
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Gia_Tri_Hang").EditorControl = Nhap_So

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Hang_Hoa").Style = ColumnStyle.DropDown
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Hang_Hoa").ValueList = ddMaHang
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Hang_Hoa").AutoEdit = False

            Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1HangKiemHoaXuat_InitializeTemplateAddRow"
    Private Sub dgE1HangKiemHoaXuat_InitializeTemplateAddRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs) Handles dgE1HangKiemHoaXuat.InitializeTemplateAddRow
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Hang_Hoa").DefaultCellValue = ""
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Xuat_Xu").DefaultCellValue = "VN"
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Don_Gia").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tien_Te").DefaultCellValue = "VND"
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gia_Tri_Hang").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gia_Tri_Hang_VN").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("STT_Hang_Hoa").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_NK").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_NK").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_VAT").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_VAT").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_Dac_Biet").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_Dac_Biet").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_Tieu_Thu").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_Tieu_Thu").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_Qua_Tang").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_Qua_Tang").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_Han_Ngach").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_Han_Ngach").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Thue_Uu_Dai").DefaultCellValue = 0.0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tien_Thue_Uu_Dai").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Tong_Thue").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Ngay_He_Thong").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Gio_He_Thong").DefaultCellValue = 0
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Da_Truyen").DefaultCellValue = CBool(0)
        myGridKeyDown.DisplayLayout.Bands(0).Columns("Chot_SL").DefaultCellValue = CBool(0)
    End Sub
#End Region
#Region "dgE1HangKiemHoaXuat_AfterExitEditMode"
    Private Sub dgE1HangKiemHoaXuat_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1HangKiemHoaXuat.AfterExitEditMode
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Or dgE1HangKiemHoaXuat.Tag = False Then
                Exit Sub
            End If
            'Luu gia tri de cho phep Next Cell
            Select Case myGridKeyDown.ActiveCell.Column.Key
                Case "Ten_Hang_Hoa"
                    If myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Text.Trim <> "" Then
                        Exit Sub
                    End If
                    If myGridKeyDown.ActiveCell.Text.Trim <> "" Then
                        'Gan du lieu vao luoi
                        Dim mSTT_Hang_Hoa As Integer
                        mSTT_Hang_Hoa = myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Lay_STT_Max_Theo_Id_E1(myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1)

                        'Lay thong tin ma hang hóa
                        If Not IsNumeric(myId_Hang_Hoa) Or myId_Hang_Hoa.Trim.Length <> 14 Then
                            myId_Hang_Hoa = ""
                        End If
                        Dim myDanhMucHangChiTiet As New Danh_Muc_Hang_Chi_Tiet
                        myDanhMucHangChiTiet = myDanhMucHang.Danh_Muc_Hang_Lay(myId_Hang_Hoa)
                        '--------------------------------------

                        'Có nhảy sang cột tiếp theo không hay là đặt con trỏ ở cuối cột tên hàng
                        If myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Text.Trim = "" And myId_Hang_Hoa <> "" Then
                            IsQuay_Lai_Ten_Hang = True
                            IsDa_Kiem_Tra_Hang_Cam_Nhap = True
                        Else
                            IsQuay_Lai_Ten_Hang = False
                            IsDa_Kiem_Tra_Hang_Cam_Nhap = False
                        End If
                        '-----------------------------------------------------

                        myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Value = CreateId_Chi_Tiet_E1_Hang_Kiem_Hoa_Xuat(myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1, mSTT_Hang_Hoa)
                        myGridKeyDown.ActiveRow.Cells("Id_E1").Value = myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1
                        myGridKeyDown.ActiveRow.Cells("Ma_To_Khai").Value = myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai
                        myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Value = myE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac
                        If myGridKeyDown.ActiveRow.Cells("STT_Hang_Hoa").Value = 0 Or myGridKeyDown.ActiveRow.Cells("STT_Hang_Hoa").Text = "" Then
                            myGridKeyDown.ActiveRow.Cells("STT_Hang_Hoa").Value = mSTT_Hang_Hoa
                        End If
                        myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value = myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung
                        myGridKeyDown.ActiveRow.Cells("Id_Ca").Value = myE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca
                        myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa").Value = myDanhMucHangChiTiet.Ma_Hang_Hoa
                        'If myGridKeyDown.ActiveRow.Index = 0 Then
                        '    myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa").Value = ""
                        '    '---myGridKeyDown.ActiveRow.Cells("Ten_Hang_Hoa").Value = 
                        '    myGridKeyDown.ActiveRow.Cells("Xuat_Xu").Value = "VN"
                        '    '---myGridKeyDown.ActiveRow.Cells("Don_Vi_Tinh").Value = 
                        '    '---myGridKeyDown.ActiveRow.Cells("Luong_Hang").Value = 
                        '    myGridKeyDown.ActiveRow.Cells("Don_Gia").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Value = "VNĐ"
                        '    myGridKeyDown.ActiveRow.Cells("Gia_Tri_Hang").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Gia_Tri_Hang_VN").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_NK").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_NK").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_VAT").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_VAT").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_Dac_Biet").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_Dac_Biet").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_Tieu_Thu").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_Tieu_Thu").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_Qua_Tang").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_Qua_Tang").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_Han_Ngach").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_Han_Ngach").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Thue_Uu_Dai").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tien_Thue_Uu_Dai").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Tong_Thue").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Ngay_He_Thong").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Gio_He_Thong").Value = 0
                        '    myGridKeyDown.ActiveRow.Cells("Da_Truyen").Value = CBool(0)
                        '    myGridKeyDown.ActiveRow.Cells("Chot_SL").Value = CBool(0)
                        'End If
                        'Neu la co thue thi khong next cell (tai cell Ten_Hang_Hoa)                       
                    End If
                Case Else
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1HangKiemHoaXuat_AfterRowUpdate"
    Private Sub dgE1HangKiemHoaXuat_AfterRowUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1HangKiemHoaXuat.AfterRowUpdate
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveRow.Cells("Ten_Hang_Hoa").Text.Trim = "" Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ!!! Tên hàng hóa không được để trống.", "Lỗi cập nhật thông tin hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            If Not IsNumeric(myGridKeyDown.ActiveRow.Cells("Luong_Hang").Value) Then
                MessageBox.Show("Thông tin nhập vào không hợp lệ!!! Lượng hàng phải là 1 số.", "Lỗi cập nhật thông tin hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Text = "" Then
                    myGridKeyDown.ActiveRow.Delete(False)
                End If
                Exit Sub
            End If
            Dim mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Hang_Kiem_Hoa_Xuat_Chi_Tiet
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Chi_Tiet = myGridKeyDown.ActiveRow.Cells("Id_Chi_Tiet").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1 = myGridKeyDown.ActiveRow.Cells("Id_E1").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = myGridKeyDown.ActiveRow.Cells("Ma_To_Khai").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = myGridKeyDown.ActiveRow.Cells("Ma_Bc_Khai_Thac").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.STT_Hang_Hoa = myGridKeyDown.ActiveRow.Cells("STT_Hang_Hoa").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Hang_Hoa = myGridKeyDown.ActiveRow.Cells("Ma_Hang_Hoa").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ten_Hang_Hoa = myGridKeyDown.ActiveRow.Cells("Ten_Hang_Hoa").Text
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Xuat_Xu = myGridKeyDown.ActiveRow.Cells("Xuat_Xu").Text
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Vi_Tinh = myGridKeyDown.ActiveRow.Cells("Don_Vi_Tinh").Text
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Luong_Hang = myGridKeyDown.ActiveRow.Cells("Luong_Hang").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Gia = myGridKeyDown.ActiveRow.Cells("Don_Gia").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Tien_Te = myGridKeyDown.ActiveRow.Cells("Ma_Tien_Te").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang = myGridKeyDown.ActiveRow.Cells("Gia_Tri_Hang").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang_VN = myGridKeyDown.ActiveRow.Cells("Gia_Tri_Hang_VN").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_NK = myGridKeyDown.ActiveRow.Cells("Thue_NK").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_NK = myGridKeyDown.ActiveRow.Cells("Tien_Thue_NK").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_VAT = myGridKeyDown.ActiveRow.Cells("Thue_VAT").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_VAT = myGridKeyDown.ActiveRow.Cells("Tien_Thue_VAT").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Dac_Biet = myGridKeyDown.ActiveRow.Cells("Thue_Dac_Biet").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Dac_Biet = myGridKeyDown.ActiveRow.Cells("Tien_Thue_Dac_Biet").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Tieu_Thu = myGridKeyDown.ActiveRow.Cells("Thue_Tieu_Thu").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Tieu_Thu = myGridKeyDown.ActiveRow.Cells("Tien_Thue_Tieu_Thu").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Qua_Tang = myGridKeyDown.ActiveRow.Cells("Thue_Qua_Tang").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Qua_Tang = myGridKeyDown.ActiveRow.Cells("Tien_Thue_Qua_Tang").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Han_Ngach = myGridKeyDown.ActiveRow.Cells("Thue_Han_Ngach").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Han_Ngach = myGridKeyDown.ActiveRow.Cells("Tien_Thue_Han_Ngach").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Uu_Dai = myGridKeyDown.ActiveRow.Cells("Thue_Uu_Dai").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Uu_Dai = myGridKeyDown.ActiveRow.Cells("Tien_Thue_Uu_Dai").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Thue = myGridKeyDown.ActiveRow.Cells("Tong_Thue").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung = myGridKeyDown.ActiveRow.Cells("Id_Nguoi_Dung").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca = myGridKeyDown.ActiveRow.Cells("Id_Ca").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong = myGridKeyDown.ActiveRow.Cells("Ngay_He_Thong").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong = myGridKeyDown.ActiveRow.Cells("Gio_He_Thong").Value
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Da_Truyen = CBool(myGridKeyDown.ActiveRow.Cells("Da_Truyen").Value)
            mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL = CBool(myGridKeyDown.ActiveRow.Cells("Chot_SL").Value)

            'myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Them(mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Chi_Tiet, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.STT_Hang_Hoa, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Hang_Hoa, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ten_Hang_Hoa, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Xuat_Xu, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Vi_Tinh, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Luong_Hang, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Gia, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Tien_Te, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang_VN, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_NK, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_NK, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_VAT, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_VAT, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Dac_Biet, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Dac_Biet, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Tieu_Thu, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Tieu_Thu, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Qua_Tang, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Qua_Tang, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Han_Ngach, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Han_Ngach, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Uu_Dai, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Uu_Dai, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Thue, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Da_Truyen, mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL)

            myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Them(mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Chi_Tiet, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.STT_Hang_Hoa, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Hang_Hoa, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ten_Hang_Hoa, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Xuat_Xu, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Vi_Tinh, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Luong_Hang, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Don_Gia, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Tien_Te, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gia_Tri_Hang_VN, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_NK, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_NK, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_VAT, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_VAT, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Dac_Biet, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Dac_Biet, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Tieu_Thu, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Tieu_Thu, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Qua_Tang, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Qua_Tang, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Han_Ngach, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Han_Ngach, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Thue_Uu_Dai, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tien_Thue_Uu_Dai, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Thue, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Da_Truyen, _
                                                                    mE1_Hang_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL)
            Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgE1HangKiemHoaXuat_AfterCellUpdate"
    Private Sub dgE1HangKiemHoaXuat_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE1HangKiemHoaXuat.AfterCellUpdate
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell Is Nothing Then
            Exit Sub
        End If
        If myGridKeyDown.ActiveRow.Cells("Ten_Hang_Hoa").Text <> "" Then
            AddNewRow(myGridKeyDown, True)
        End If
    End Sub
#End Region
#Region "dgE1HangKiemHoaXuat_KeyDown"
    Private Sub dgE1HangKiemHoaXuat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1HangKiemHoaXuat.KeyDown
        Try
            myGridKeyDown = sender
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            If (e.KeyValue = Keys.Down Or e.KeyValue = Keys.Up) And myGridKeyDown.ActiveCell.Column.Key = "Ten_Hang_Hoa" Then
                m_is_select = True
                Exit Sub
            Else
                m_is_select = False
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    'Lay index cua Cell dang Active
                    myCell = myGridKeyDown.ActiveCell
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    'Kiem tra Cell co Value = Null, khong cho next cell
                    If myGridKeyDown.ActiveCell.Text.Trim = "" Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myCell = Nothing
                        Exit Sub
                    End If
                    'Kiem tra neu co van de thi khong cho Next Cell
                    If myGridKeyDown.Tag = False Then
                        myGridKeyDown.ActiveCell = myCell
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        dgE1HangKiemHoaXuat.Tag = True
                        myCell = Nothing
                        Exit Sub
                    End If
                    'Dung con tro lại ở vị trí cuối cùng ở cột tên hàng để người dùng nhập bổ xung
                    If myGridKeyDown.ActiveCell.Column.Key = "Ten_Hang_Hoa" And IsQuay_Lai_Ten_Hang Then
                        IsQuay_Lai_Ten_Hang = False
                        e.Handled = True
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.ActiveCell.SelLength = 0
                        myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length
                        Exit Sub
                    End If
                    'Ok => Next cell 
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.F8
                    Delete_Row_E1_Hang_Kiem_Hoa_Xuat()
                    Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
                    e.Handled = True
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length Then
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
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.SelStart = 0 Then
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
#Region "dgE1HangKiemHoaXuat_AfterRowActivate"
    Private Sub dgE1HangKiemHoaXuat_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1HangKiemHoaXuat.AfterRowActivate
        Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(False)
    End Sub
#End Region

#Region "dgE1HangKiemHoaXuat_CellChange"
    Private Sub dgE1HangKiemHoaXuat_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE1HangKiemHoaXuat.CellChange
        Try
            Dim mVi_Tri_Con_Tro As Integer
            'If dgE1HangKiemHoa.ActiveRow.Cells("Ma_Hang_Hoa").Text.Trim <> "" Then
            '    Exit Sub
            'End If
            If dgE1HangKiemHoaXuat.ActiveCell Is Nothing Then
                Exit Sub
            End If
            mVi_Tri_Con_Tro = dgE1HangKiemHoaXuat.ActiveCell.SelStart
            'Danh muc hang
            If dgE1HangKiemHoaXuat.ActiveCell.Column.Key = "Ten_Hang_Hoa" Then
                If m_is_select = True Then
                    Exit Sub
                End If
                myDataView.Sort = "Ten_Hang_Hoa"
                myDataView.RowFilter = "Ten_Hang_Hoa like '" + dgE1HangKiemHoaXuat.ActiveCell.Text + "%'"
                If ddMaHang.IsDroppedDown = False Then
                    'dgE1HangKiemHoa.PerformAction(ToggleDropdown, False, False)
                    dgE1HangKiemHoaXuat.ActiveCell.DroppedDown = True
                End If
            End If
            'Xu ly khong boi den ky tu dau tien
            If dgE1HangKiemHoaXuat.ActiveCell.SelLength = 1 Then
                dgE1HangKiemHoaXuat.ActiveCell.SelLength = 0
                dgE1HangKiemHoaXuat.ActiveCell.SelStart = mVi_Tri_Con_Tro
            End If
            'Xu ly khong boi den 
            If dgE1HangKiemHoaXuat.ActiveCell.SelLength > 1 Then
                dgE1HangKiemHoaXuat.ActiveCell.SelLength = 0
                dgE1HangKiemHoaXuat.ActiveCell.SelStart = mVi_Tri_Con_Tro
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    '#Region "dgE1HangKiemHoaXuat_AfterRowInsert"
    '    Private Sub dgE1HangKiemHoaXuat_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles dgE1HangKiemHoaXuat.AfterRowInsert
    '        'Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
    '    End Sub
    '#End Region
    '#Region "dgE1HangKiemHoaXuat_AfterRowsDeleted"
    '    Private Sub dgE1HangKiemHoaXuat_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1HangKiemHoaXuat.AfterRowsDeleted
    '        'Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(True)
    '    End Sub
    '#End Region
#End Region
#Region "-----------------dropdownMa_Hang----------------"
#Region "------------------ddMaHang_InitializeLayout------------------"
    Private Sub ddMaHang_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ddMaHang.InitializeLayout
        'Hien lai cac cot can thiet
        ddMaHang.DisplayLayout.Bands(0).Columns("Ten_Hang_Hoa").Hidden = False
        ddMaHang.DisplayLayout.Bands(0).Columns("Ma_Hang_Hoa").Hidden = False
        ddMaHang.DisplayLayout.Bands(0).Columns("Thue_NK").Hidden = False
        ddMaHang.DisplayLayout.Bands(0).Columns("Thue_VAT").Hidden = False
        ddMaHang.DisplayLayout.Bands(0).Columns("Id_Hang_Hoa").Hidden = True
    End Sub
#End Region

#Region "------------------ddMaHang_AfterCloseUp---------------------"
    Private Sub ddMaHang_AfterCloseUp(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.DropDownEventArgs) Handles ddMaHang.AfterCloseUp
        Try
            myId_Hang_Hoa = ddMaHang.SelectedRow.Cells("Id_Hang_Hoa").Text
        Catch
            myId_Hang_Hoa = ""
        End Try

    End Sub
#End Region

#End Region
#End Region
#End Region

#Region "Hàm người dùng viết"
#Region "Thông tin tổng hợp của tờ khai"
#Region "-----------------GetDanhSachSoToKhai---------------"
    Private Sub GetDanhSachSoToKhai(ByVal Ngay_Dang_Ky As Integer, ByVal Loai_Kiem_Hoa As Integer)
        Try
            Dim myStartDate, myEndDate As Integer
            myStartDate = myHam_Dung_Chung.CreateStartDate(Ngay_Dang_Ky)
            myEndDate = myHam_Dung_Chung.CreateEndDate(Ngay_Dang_Ky)
            cbSoToKhai.DataSource = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay_Danh_Sach_So_TK(myStartDate, myEndDate, Loai_Kiem_Hoa).Tables(0)
            cbSoToKhai.DataBind()
            cbSoToKhai.Value = 0
            cbSoToKhai.Text = 0
            'mySoToKhaiLonNhat = myToKhaiHaiQuan.To_Khai_Hai_Quan_Tao_So_TK_Moi(myStartDate, myEndDate, Loai_Kiem_Hoa)
            'cbSoToKhai.Value = mySoToKhaiLonNhat
            'cbSoToKhai.Text = mySoToKhaiLonNhat
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------EnableControl-----------------"
    Private Sub EnableControl(ByVal isOpen As Boolean)
        If isOpen Then
            btnOpen.Text = "Đón&g tờ khai"
        Else
            btnOpen.Text = "&Mở tờ khai"
        End If
        dtpNgayDangKy.Enabled = Not isOpen
        cbSoToKhai.Enabled = Not isOpen

        GrbTong_Hop.Enabled = isOpen
        GrbChi_Tiet.Enabled = isOpen
        chkIn_Phu_Luc.Enabled = isOpen
        txtSo_Ban_In.Enabled = isOpen
        btnPrint.Enabled = isOpen
        btnPreview.Enabled = isOpen
    End Sub
#End Region
#Region "-----------------Mo_To_Khai_Hai_Quan_Xuat-----------------"
    Private Function Mo_To_Khai_Hai_Quan_Xuat(ByVal Ma_To_Khai As String) As Boolean
        Try
            'Lay thong tin to khai gan vao bien myToKhaiHaiQuanChiTiet
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay(Ma_To_Khai)
            If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ <> "" Then   'Da ton tai to khai
                'To khai o trang thai Open
                If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen = True Then
                    MessageBox.Show("Tờ khai này đang được người khác cập nhật. Bạn không thể mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                    Exit Function
                End If
                'To khai Da Chot So Lieu
                If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL = True Then
                    MessageBox.Show("Tờ khai này đang được chốt số liệu. Bạn không thể mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                    Exit Function
                End If
                'Kiem tra neu la soi may thi khong cho mo - soi may dung form rieng
                If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa <> 9 Then
                    MessageBox.Show("Tờ khai có số tờ khai này không phải là tờ khai hàng xuất!!!" & vbNewLine & ". Vì vậy, bạn không thể mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                    Exit Function
                End If
                'Thoa man dieu kien => cho phep mo to khai
                If MessageBox.Show("Số tờ khai này đã được dùng cho tờ khai xuất khẩu." & Chr(13) & "Tờ khai này đã được tạo vào " & myHam_Dung_Chung.ConvertIntToDate_VN(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai) & ". Bạn có muốn mở không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then   'Dong y mo
                    ''Cap nhat Ip_May_Tinh va Ban_So doi voi to khai duoc chen them tu chuc nang QL Sổ tờ khai
                    'If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = "" Then
                    '    myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = GIp_May_Tinh
                    'End If
                    'If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = 0 Then
                    '    myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = GBan_So
                    'End If
                    'Cap nhat trang thai mo to khai
                    myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, True)
                    'Dua thong tin len Form
                    'Ngay kiem hoa
                    dtpNgayDangKy.Value = myHam_Dung_Chung.ConvertIntToDate(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai)

                    '---So To Khai Hai Quan Tu Dong Sinh (Khong dua vao Form vi nguoi dung da nhap vao roi)
                    'cbSoToKhai.Value = myToKhaiHaiQuanChiTiet.So_TKHQ
                    'cbSoToKhai.Text = myToKhaiHaiQuanChiTiet.So_TKHQ

                    '---So To Khai Hai Quan cap
                    txtSo_TKHQ.Text = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap
                    'Thông tin tổng hợp của tờ khai trên Form
                    txtNguoi_Gui.Text = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui
                    txtNguoi_Nhan.Text = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan
                    txtNguoi_Duoc_Uy_Quyen.Text = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen
                    txtChuyen_Bay.Text = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo
                    dtpNgay_CN38.Value = myHam_Dung_Chung.ConvertIntToDate(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38)
                    txtTong_So_Tui.Value = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui
                    txtTong_Trong_Luong.Value = myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong
                    chkTai_Lieu.Checked = IIf(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu.Trim <> "", True, False)
                    chkIn_Phu_Luc.Checked = CBool(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc)
                    '------Load du lieu len luoi
                    DataGrid_E1_Kiem_Hoa(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                    DataGrid_E1_Hang_Kiem_Hoa("0")
                    btnPreview.Select()
                    '--------------------------------------------------------------
                Else  'Khong dong y mo
                    cbSoToKhai.Select()
                    Return False
                    Exit Function
                End If
            Else  'Chua ton tai To khai => Tao moi - gan thong tin vao myToKhaiHaiQuanChiTiet
                'Neu khong phai la tao moi thi khong cho phep mo
                If cbSoToKhai.Text <> "0" And cbSoToKhai.Text <> "" Then
                    MessageBox.Show("Tờ khai này không tồn tại, bạn không được phép mở!!!" & vbNewLine & "Nếu bạn muốn tạo mới thì nhập số TT bằng 0 hoặc bằng rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbSoToKhai.Select()
                    Return False
                    Exit Function
                End If

                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = GIp_May_Tinh
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = "0"
                'So to khai Hai quan cap - nguoi dung nhap tay vao
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap = txtSo_TKHQ.Text
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai = myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value)
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai = myHam_Dung_Chung.ConvertTimeToInt(Now())
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui = "VN"
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen = 1
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa = myKieu_Kiem_Hoa
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38 = myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value)
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te = "VN"
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu = ""
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = GIp_May_Tinh
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = GBan_So
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong = 0
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL = 0

                '------Load du lieu len luoi
                DataGrid_E1_Kiem_Hoa(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
                DataGrid_E1_Hang_Kiem_Hoa("0")
                'Trang thai tao moi To Khai
                isTaoMoi = True
                txtNguoi_Gui.Select()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region
#Region "-----------------Dong_To_Khai_Hai_Quan-----------------"
    Private Sub Dong_To_Khai_Hai_Quan(ByVal Ma_To_Khai As String)
        Try
            'Cap nhat lai trang thai dong to khai
            myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(Ma_To_Khai, False)
            'Refresh datagrid
            DataGrid_E1_Kiem_Hoa("0")
            DataGrid_E1_Hang_Kiem_Hoa("0")
            'Chuyen trang thai Dong to khai
            isOpen = Not isOpen
            EnableControl(isOpen)
            'Enable_Before_Open_To_Khai(isOpen)
            'Gan lai thong tin to khai tren form
            dtpNgayDangKy.Value = Now().Date
            txtSo_TKHQ.Text = ""
            'Gan lai thong tin so to khai = 0 => tao moi
            cbSoToKhai.Value = 0
            cbSoToKhai.Text = 0
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = ""
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = "0"
            myMa_To_Khai_Thuc_Cap = ""
            mySo_To_Khai_Thuc_Cap = 0
            '------------------------------------------------
            cbSoToKhai.Select()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------DataGrid_E1_Kiem_Hoa---------------"
    Private Sub DataGrid_E1_Kiem_Hoa(ByVal Ma_To_Khai As String)
        Try
            dgE1_Kiem_Hoa_Xuat.DataSource = myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(Ma_To_Khai).Tables(0)
            dgE1_Kiem_Hoa_Xuat.DataBind()
            dgE1_Kiem_Hoa_Xuat.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------DataGrid_E1_Hang_Kiem_Hoa---------------"
    Private Sub DataGrid_E1_Hang_Kiem_Hoa(ByVal mId_E1 As String)
        Try
            dgE1HangKiemHoaXuat.DataSource = myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Id_E1(mId_E1).Tables(0)
            dgE1HangKiemHoaXuat.DataBind()
            dgE1HangKiemHoaXuat.Rows.Band.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------Gan_Thong_Tin_Mac_Dinh_Tren_Form_Khi_Load_Form-----------------"
    Private Sub Gan_Thong_Tin_Mac_Dinh_Tren_Form_Khi_Load_Form()
        dtpNgayDangKy.Value = Now().Date
        cbSoToKhai.Value = 0
        cbSoToKhai.Text = 0
        txtSo_TKHQ.Text = ""
        txtNguoi_Gui.Text = myNguoi_Gui
        txtNguoi_Nhan.Text = ""
        txtNguoi_Duoc_Uy_Quyen.Text = GHo_Ten
        txtChuyen_Bay.Text = ""
        dtpNgay_CN38.Value = dtpNgayDangKy.Value
        txtTong_So_Tui.Value = 0
        txtTong_Trong_Luong.Value = 0.0
        chkTai_Lieu.Checked = True
        Gan_Thong_Tin_Cho_Label_Thong_Tin(0)
        chkIn_Phu_Luc.Checked = False
        txtSo_Ban_In.Value = mySo_Ban_In_To_Khai_Xuat
    End Sub
#End Region
#Region "-----------------Gan_Thong_Tin_Mac_Dinh_Tren_Form_Khi_Ket_Thuc_Tac_Vu-----------------"
    Private Sub Gan_Thong_Tin_Mac_Dinh_Tren_Form_Khi_Ket_Thuc_Tac_Vu()
        dtpNgayDangKy.Value = Now().Date
        cbSoToKhai.Value = 0
        cbSoToKhai.Text = 0
        txtSo_TKHQ.Text = ""
        txtNguoi_Gui.Text = myNguoi_Gui
        txtNguoi_Nhan.Text = ""
        'txtNguoi_Duoc_Uy_Quyen.Text = GHo_Ten
        txtChuyen_Bay.Text = ""
        'dtpNgay_CN38.Value = dtpNgayDangKy.Value
        txtTong_So_Tui.Value = 0
        txtTong_Trong_Luong.Value = 0.0
        chkTai_Lieu.Checked = True
        Gan_Thong_Tin_Cho_Label_Thong_Tin(0)
        chkIn_Phu_Luc.Checked = False
        'txtSo_Ban_In.Value = mySo_Ban_In_To_Khai_Xuat
    End Sub
#End Region
#Region "-----------------Gan_Thong_Tin_Cho_Label_Thong_Tin-----------------"
    Private Sub Gan_Thong_Tin_Cho_Label_Thong_Tin(ByVal mSo_Luong As Integer)
        lblThong_Tin.Text = mSo_Luong.ToString
    End Sub
#End Region
#Region "Cap_Nhat_To_Khai_Hang_Xuat"
    Private Function Cap_Nhat_To_Khai_Hang_Xuat(ByVal mMa_To_Khai As String, ByVal mKieu_Kiem_Hoa As Integer, ByRef mThong_Bao_OutPut As String) As Boolean
        Try
            If Not Kiem_Tra_Thong_Tin_Hop_Le() Then
                Return False
                Exit Function
            End If
            '================= To_Khai_Hai_Quan_Xuat ======================
            If mMa_To_Khai = GIp_May_Tinh Then  'Tao moi + lan dau tien cap nhat
                'Lay so to khai va ma to khai thuc cap
                mySo_To_Khai_Thuc_Cap = So_To_Khai_Lon_Nhat(myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), mKieu_Kiem_Hoa)
                'Gan lai (Ma To Khai, So_TKHQ) thuc cap cho bien myToKhaiHaiQuanChiTiet - de dung cho lan sau
                mMa_To_Khai = Create_Ma_To_Khai(mKieu_Kiem_Hoa, myHam_Dung_Chung.ConvertDateToInt(dtpNgayDangKy.Value), mySo_To_Khai_Thuc_Cap)
                'Gan vao bien
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = mMa_To_Khai
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = Format_So_TKHQ(mySo_To_Khai_Thuc_Cap)
            Else    'To khai da ton tai, không cần lấy số tờ khai và mã tờ khai
            End If
            'lay thong tin tren Form dua vao bien
            Gan_Thong_Tin_To_Khai_Hai_Quan_Xuat_Tren_Form_Vao_Bien()
            'Cap nhat vao bang
            myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Them(myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong, _
                                                                        myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL)

            '=================Cap nhat lai Ma_To_Khai vào E1_Kiem_Hoa_Xuat va E1_Hang_Kiem_Hoa_Xuat
            myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap(GIp_May_Tinh, myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
            myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Cap_Nhat_Ma_To_Khai_Thuc_Cap(GIp_May_Tinh, myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai)
            mThong_Bao_OutPut = "Đã cập nhật thành công tờ khai hàng xuất số :   " & myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ
            Return True
        Catch ex As Exception
            MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật thông tin tờ khai. Hãy thông báo cho người quản trị về lỗi này." & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region
#Region "===================Hàm lấy lại số tờ khai thực cấp======================="
    Private Function So_To_Khai_Lon_Nhat(ByVal Ngay_Dang_Ky As Integer, ByVal Loai_Kiem_Hoa As Integer) As Integer
        Try
            Dim myStartDate, myEndDate As Integer
            myStartDate = myHam_Dung_Chung.CreateStartDate(Ngay_Dang_Ky)
            myEndDate = myHam_Dung_Chung.CreateEndDate(Ngay_Dang_Ky)
            Return myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Tao_So_TK_Moi(myStartDate, myEndDate, Loai_Kiem_Hoa)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region
#Region "Gan_Thong_Tin_To_Khai_Hai_Quan_Xuat_Tren_Form_Vao_Bien"
    Private Sub Gan_Thong_Tin_To_Khai_Hai_Quan_Xuat_Tren_Form_Vao_Bien()
        Try
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai = dtpNgayDangKy.Value
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap = txtSo_TKHQ.Text
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen = txtNguoi_Duoc_Uy_Quyen.Text
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui = txtNguoi_Gui.Text
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan = txtNguoi_Nhan.Text
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc = chkIn_Phu_Luc.Checked
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa = 
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo = txtChuyen_Bay.Text
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui = txtTong_So_Tui.Value
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong = txtTong_Trong_Luong.Value
            If IsNumeric(lblThong_Tin.Text) Then
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien = lblThong_Tin.Text
            Else
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien = 0
            End If
            myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38 = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_CN38.Value)
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu = 
            If chkTai_Lieu.Checked Then
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = myThong_Tin_Tai_Lieu
            Else
                myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = ""
            End If
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong = 
            'myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL = 
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Insert_Into_E1_Kiem_Hoa_Xuat"
    Private Sub Insert_Into_E1_Kiem_Hoa_Xuat()
        Try
            Dim mE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1 = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_E1").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E2 = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_E2").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_Ca").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ma_Bc_Khai_Thac").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_E1 = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ma_E1").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Nhan = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Nuoc_Nhan").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Tra = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Nuoc_Tra").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Khoi_Luong = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Khoi_Luong").Value
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Phan_Loai = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Phan_Loai").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.STT = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("STT").Value
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Gui = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Nguoi_Gui").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Nhan = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Nguoi_Nhan").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Gui = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Dia_Chi_Gui").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Nhan = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Dia_Chi_Nhan").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Gui = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Dien_Thoai_Gui").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Nhan = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Dien_Thoai_Nhan").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_Nguoi_Dung").Value
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Trang_Thai = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_Trang_Thai").Value
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ghi_Chu = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ghi_Chu").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Khai_Thac = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Doi_Soat = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ma_To_Khai").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ip_May_Tinh = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ip_May_Tinh").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ban_So = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ban_So").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Muc_Hang = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Tong_Muc_Hang").Text
            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Tri_Gia = dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Tong_Tri_Gia").Text

            myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Cap_Nhat_Them(mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E1, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_E2, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Ca, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_E1, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Nhan, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nuoc_Tra, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Khoi_Luong, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Phan_Loai, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.STT, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Gui, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Nguoi_Nhan, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Gui, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dia_Chi_Nhan, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Gui, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Dien_Thoai_Nhan, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Nguoi_Dung, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Id_Trang_Thai, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ghi_Chu, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Khai_Thac, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Truyen_Doi_Soat, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ngay_He_Thong, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Gio_He_Thong, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Chot_SL, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ip_May_Tinh, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ban_So, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Muc_Hang, _
                                                            mE1_Kiem_Hoa_Xuat_Chi_Tiet.Tong_Tri_Gia)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "--------------Kiểm tra trùng dữ liệu hoặc đã kiểm hoá trong tờ khai khác và lấy thông tin vào biến--------------"
    Private Function Lay_Thong_Tin_E1_Den(ByVal mMa_To_Khai As String, ByVal mMa_E1 As String, ByRef mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output As E1_Kiem_Hoa_Xuat_Chi_Tiet) As Boolean
        Dim mE1_Den_Chi_Tiet As New E1_Den_Chi_Tiet
        Dim mE1_Kiem_Hoa_Xuat_Chi_Tiet As New E1_Kiem_Hoa_Xuat_Chi_Tiet
        Dim mE1_Den As New E1_Den(GConnectionString)
        Dim mTu_Ngay, mDen_Ngay As Integer
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(Now().Date)
        mTu_Ngay = myHam_Dung_Chung.MinusIntDate(mDen_Ngay, GSo_Ngay_E1_Duoc_Trung)
        mE1_Den_Chi_Tiet = mE1_Den.E1_Den_Kiem_Tra_Trung_MA_E1_Ngay_Dung_Trong_Kiem_Hoa(mMa_E1, mTu_Ngay, mDen_Ngay)

        'Kiem tra xem co chi tiet xac nhan den chua
        If mE1_Den_Chi_Tiet.Id_E1.Trim = "" Then
            MessageBox.Show("Chưa có thông tin xác nhận đến của bưu phẩm này tại bộ phận khai thác QT đi!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Exit Function
        End If
        'Kiem tra trang thai kiem hoa
        mE1_Kiem_Hoa_Xuat_Chi_Tiet = myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Lay(mE1_Den_Chi_Tiet.Id_E1)
        If mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = "" Then    'OK
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Id_E1 = mE1_Den_Chi_Tiet.Id_E1
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Id_E2 = mE1_Den_Chi_Tiet.Id_E2
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Id_Ca = GId_Ca
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ma_E1 = mE1_Den_Chi_Tiet.Ma_E1
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Nuoc_Nhan = mE1_Den_Chi_Tiet.Nuoc_Nhan
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Nuoc_Tra = mE1_Den_Chi_Tiet.Nuoc_Tra
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Khoi_Luong = mE1_Den_Chi_Tiet.Khoi_Luong
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Phan_Loai = mE1_Den_Chi_Tiet.Phan_Loai
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.STT = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Nguoi_Gui = mE1_Den_Chi_Tiet.Nguoi_Gui
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Nguoi_Nhan = mE1_Den_Chi_Tiet.Nguoi_Nhan
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Dia_Chi_Gui = mE1_Den_Chi_Tiet.Dia_Chi_Gui
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Dia_Chi_Nhan = mE1_Den_Chi_Tiet.Dia_Chi_Nhan
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Dien_Thoai_Gui = mE1_Den_Chi_Tiet.Dien_Thoai_Gui
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Dien_Thoai_Nhan = mE1_Den_Chi_Tiet.Dien_Thoai_Nhan
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Id_Nguoi_Dung = Gid_Nguoi_Dung
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Id_Trang_Thai = mE1_Den_Chi_Tiet.Id_Trang_Thai
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ghi_Chu = mE1_Den_Chi_Tiet.Ghi_Chu
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Truyen_Khai_Thac = mE1_Den_Chi_Tiet.Truyen_Khai_Thac
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Truyen_Doi_Soat = mE1_Den_Chi_Tiet.Truyen_Doi_Soat
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ngay_He_Thong = mE1_Den_Chi_Tiet.Ngay_He_Thong
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Gio_He_Thong = 0
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Chot_SL = mE1_Den_Chi_Tiet.Chot_SL
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ma_To_Khai = mMa_To_Khai
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ip_May_Tinh = GIp_May_Tinh
            mE1_Kiem_Hoa_Xuat_Chi_Tiet_Output.Ban_So = GBan_So
            Return True
        ElseIf mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai = mMa_To_Khai Then  'Trung trong to khai
            MessageBox.Show("Trùng dữ liệu trong tờ khai này!!! Mời bạn nhập bưu phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Exit Function
        Else   'Da khai o to khai khac
            Dim mSo_TKHQ_Khac As Integer
            mSo_TKHQ_Khac = CInt(myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay(mE1_Kiem_Hoa_Xuat_Chi_Tiet.Ma_To_Khai).So_TKHQ)
            MessageBox.Show("Bưu phẩm này đã được kiểm hóa trong tờ khai hàng xuất số: === " & mSo_TKHQ_Khac.ToString & " ===" & vbNewLine & "Vì vậy bạn không thể khai hải quan cho bưu phẩm này nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Exit Function
        End If
    End Function
#End Region
#Region "-----------------Delete_Row_E1_Kiem_Hoa-------------"
    Private Sub Delete_Row_E1_Kiem_Hoa_Xuat()
        Try
            'Kiem tra khoa so lieu
            If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL Then
                MessageBox.Show("Tờ khai này đã được khóa số liệu!!! Bạn không thể xóa bưu phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Ma_E1").Text <> "" Then
                If MessageBox.Show("Bạn có thực sự muốn xóa dòng này không ???" & vbNewLine & "Chú ý, tất cả thông tin hàng hóa của bưu phẩm này cũng sẽ bị xóa bỏ.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    'Xoa tren E1_Kiem_Hoa
                    myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Xoa(dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_E1").Text)
                    'Xoa tren E1_Hang_Kiem_Hoa
                    myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Id_E1(dgE1_Kiem_Hoa_Xuat.ActiveRow.Cells("Id_E1").Text)
                    'Xoa tren lưới
                    dgE1_Kiem_Hoa_Xuat.ActiveRow.Delete(False)
                    CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa"
    Private Function Lay_Tong_So_Buu_Pham_E1_Kiem_Hoa() As Integer
        Dim idx, mTong As Integer
        mTong = 0
        For idx = 0 To dgE1_Kiem_Hoa_Xuat.Rows.Count - 1
            If dgE1_Kiem_Hoa_Xuat.Rows(idx).Cells("Id_E1").Text <> "" Then
                mTong = mTong + 1
            End If
        Next
        Return mTong
    End Function
#End Region
#Region "In_To_Khai_Hai_Quan_Xuat_HQ2015XK"
    Private Function In_To_Khai_Hai_Quan_Xuat_HQ2015XK(ByVal mMa_To_Khai As String, ByVal mIn_Phu_Luc As Boolean, ByVal mPreview As Boolean, ByVal mSo_Ban As Integer) As Boolean
        Try
            'Khai bao bien
            Dim myData1, myData2, myData2B, mayData_Hang_Xuat As DataTable
            Dim idx As Integer
            Dim myReport_To_Khai As New rptTo_Khai_Hang_Hoa_Xuat_Khau_HQ2015XK
            'Dim myReport_To_Khai_Chi_Tiet As New rpt_To_Khai_Hang_Xuat_Chi_Tiet
            Dim myReport_To_Khai_Chi_Tiet As New rptBang_Ke_Bui_Gui_Xuat_Nhap_Khau_Soi_May_Chi_Tiet
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim pMenu_Cuc_Hai_Quan As String
            Dim pMenu_Chi_Cuc_Hai_Quan As String
            Dim pMenu_Ngay_Thang_Nam As String
            Dim pMenu_So_TKHQ As String
            Dim pMenu_Thong_Tin_Dinh_Kem As String
            Dim pMenu_Tieu_De As String
            Dim pMenu_Ghi_Chu As String
            Dim pMenu_Co_Quan_Hai_Quan As String
            Dim pMenu_Dia_Diem_Kiem_Tra As String
            Dim pMenu_Ket_Qua_Kiem_Tra As String

            'Lay du lieu to khai cho dataset
            myData1 = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay_Boi_Ma_To_Khai_In_To_Khai(mMa_To_Khai).Tables(0)
            myData1.TableName = "To_Khai_Hai_Quan_Xuat"
            'Kiem tra co to khai trong database khong
            mayData_Hang_Xuat = myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai(mMa_To_Khai).Tables(0)
            
            If myData1.Rows.Count = 0 Then
                MessageBox.Show("Không có thông tin tờ khai!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            End If
            'Kiem tra xem da in to khai nay chua 
            If myData1.Rows(0).Item("IsPrint") Then
                If MessageBox.Show("Tờ khai này đã được in rồi. Bạn có chắc chắn muốn in lại không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then  'Neu khong dong y in thi thoat
                    Return True
                    Exit Function
                End If
            End If
            'Dat trang thai wait cho Mouse
            Frm_Lap_To_Khai_Chuyen_Hoan.ActiveForm.Cursor.Current = Cursors.WaitCursor

            'Lay du lieu cho Paramete
            pMenu_Cuc_Hai_Quan = "Hà Nội"
            'pMenu_Chi_Cuc_Hai_Quan = "Nội Bài" 'Trước dùng mẫu này
            pMenu_Chi_Cuc_Hai_Quan = "Chi cục Hải Quan Nội Bài"
            Dim pNam_Khai, pThang_Khai, pNgay_Khai As String
            Dim dTemp As Date
            dTemp = myData1.Rows(0).Item("Ngay_Khai")
            pMenu_Ngay_Thang_Nam = dTemp.Day.ToString("00") & "   " & dTemp.Month.ToString("00") & "   " & dTemp.Year.ToString("0000")
            pNam_Khai = dTemp.Year.ToString("0000")
            pThang_Khai = dTemp.Month.ToString("00")
            pNgay_Khai = dTemp.Day.ToString("00")
            Dim iTemp As Integer
            iTemp = myData1.Rows(0).Item("So_TKHQ")
            pMenu_So_TKHQ = iTemp.ToString("000000")

            'Lay du lieu chi tiet cua to khai cho dataset
            myData2 = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay_Thong_Tin_Chi_Tiet_In_To_Khai(mMa_To_Khai).Tables(0)
            myData2.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"

            'Tính toán tổng số dòng và tổng số trang cần in
            Dim mTong_So_Dong, mTong_So_Trang, mTong_So_BP As Integer
            Dim mTong_So_Dong_Tren_Trang_Phu_Luc As Integer = 30
            Dim mCur_Ma_E1, mPre_Ma_E1 As String
            'Lay tong so bưu phẩm
            mTong_So_BP = myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(mMa_To_Khai).Tables(0).Rows.Count
            Dim mTong_Gia_Tri_Hang As Integer
            If Not mIn_Phu_Luc Then   'người dùng không check chọn in kiểu phụ lục                
                mTong_So_Dong = 0
                mTong_So_Trang = 0
                '======Dòng ("Thư chứng từ tài liệu đã giao dịch"
                If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) <> "" Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                '======Dòng ("Xuất N bưu phẩm")
                If myData2.Rows.Count > 0 Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                'Bắt đầu phần chi tiết hàng hóa, tính tổng giá trị hàng
                mCur_Ma_E1 = ""
                mPre_Ma_E1 = ""
                For idx = 0 To myData2.Rows.Count - 1
                    mCur_Ma_E1 = myData2.Rows(idx).Item("Ma_E1")
                    'Dong tieu de cho moi buu pham
                    If mPre_Ma_E1 <> mCur_Ma_E1 Then
                        mTong_So_Dong = mTong_So_Dong + 1
                    End If
                    mPre_Ma_E1 = mCur_Ma_E1
                    'Dong hang hoa
                    mTong_So_Dong = mTong_So_Dong + 1
                    mTong_Gia_Tri_Hang = mTong_Gia_Tri_Hang + myData2.Rows(idx).Item("Gia_Tri_Hang")
                Next
                'Nếu tổng số dòng lớn hơn 5 thì vẫn phải chuyển sang in kiểu phụ lục
                If mTong_So_Dong > 5 Then
                    mIn_Phu_Luc = True
                End If
            End If
            'Xác định In phu lục
            If (mayData_Hang_Xuat.Rows.Count > 1) Then
                mIn_Phu_Luc = True
            Else
                mIn_Phu_Luc = False
            End If
            ''''Tính toán trang in theo kiểu phụ lục
            '''If mIn_Phu_Luc Then   'in kieu phu luc
            '''    mTong_So_Dong = 0
            '''    mTong_So_Trang = 0
            '''    For idx = 0 To myData2.Rows.Count - 1
            '''        mTong_So_Dong = mTong_So_Dong + 1
            '''    Next
            '''    If mTong_So_Dong Mod mTong_So_Dong_Tren_Trang_Phu_Luc = 0 Then
            '''        mTong_So_Trang = mTong_So_Dong \ mTong_So_Dong_Tren_Trang_Phu_Luc
            '''    Else
            '''        mTong_So_Trang = mTong_So_Dong \ mTong_So_Dong_Tren_Trang_Phu_Luc + 1
            '''    End If
            '''End If

            'bắt đầu in   
            'Tạo bảng Data3 giống Data2 để đưa dữ liệu vào tờ phụ lục 
            Dim myData3 As New DataTable
            Dim colSTT, colMa_E1, colKhoi_Luong, colNguoi_Gui, colDia_Chi_Gui, colNguoi_Nhan As DataColumn
            Dim colDia_Chi_Nhan, colTen_Hang_Hoa, colXuat_Xu, colLuong_Hang, colMa_Hang_Hoa As DataColumn
            Dim colDon_Vi_Tinh, colNuoc_Tra, colGia_Tri_Hang, colMa_Tien_Te As DataColumn
            Dim myRow As DataRow
            colSTT = New DataColumn("STT", GetType(Integer))
            myData3.Columns.Add(colSTT)

            colMa_E1 = New DataColumn("Ma_E1", GetType(String))
            myData3.Columns.Add(colMa_E1)

            colKhoi_Luong = New DataColumn("Khoi_Luong", GetType(Integer))
            myData3.Columns.Add(colKhoi_Luong)

            colNguoi_Gui = New DataColumn("Nguoi_Gui", GetType(String))
            myData3.Columns.Add(colNguoi_Gui)

            colDia_Chi_Gui = New DataColumn("Dia_Chi_Gui", GetType(String))
            myData3.Columns.Add(colDia_Chi_Gui)

            colNguoi_Nhan = New DataColumn("Nguoi_Nhan", GetType(String))
            myData3.Columns.Add(colNguoi_Nhan)

            colDia_Chi_Nhan = New DataColumn("Dia_Chi_Nhan", GetType(String))
            myData3.Columns.Add(colDia_Chi_Nhan)

            colMa_Hang_Hoa = New DataColumn("Ma_Hang_Hoa", GetType(String))
            myData3.Columns.Add(colMa_Hang_Hoa)

            colTen_Hang_Hoa = New DataColumn("Ten_Hang_Hoa", GetType(String))
            myData3.Columns.Add(colTen_Hang_Hoa)

            colXuat_Xu = New DataColumn("Xuat_Xu", GetType(String))
            myData3.Columns.Add(colXuat_Xu)

            colLuong_Hang = New DataColumn("Luong_Hang", GetType(Decimal))
            myData3.Columns.Add(colLuong_Hang)

            colDon_Vi_Tinh = New DataColumn("Don_Vi_Tinh", GetType(String))
            myData3.Columns.Add(colDon_Vi_Tinh)

            colNuoc_Tra = New DataColumn("Nuoc_Tra", GetType(String))
            myData3.Columns.Add(colNuoc_Tra)

            colGia_Tri_Hang = New DataColumn("Gia_Tri_Hang", GetType(Decimal))
            myData3.Columns.Add(colGia_Tri_Hang)

            colMa_Tien_Te = New DataColumn("Ma_Tien_Te", GetType(String))
            myData3.Columns.Add(colMa_Tien_Te)


            'lấy số trang báo cáo
            Dim intPageCount As Integer
            Dim pTong_Khoi_Luong_Hang As Integer
            'Tinh tong gia tri Hang

            'Add parameter cho tờ khai HQ2015XK
            'Cuc Hai Quan
            _pThamSo.Value = pMenu_Cuc_Hai_Quan
            pvCollection.Add(_pThamSo)
            myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Chi Cuc Hai Quan
            _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
            pvCollection.Add(_pThamSo)
            myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Chi_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'So_TKHQ
            _pThamSo.Value = pMenu_So_TKHQ
            pvCollection.Add(_pThamSo)
            myReport_To_Khai.DataDefinition.ParameterFields("pMenu_So_TKHQ").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            _pThamSo.Value = "Chi cục HQCKQT Nội Bài"
            pvCollection.Add(_pThamSo)
            myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Chi_Cuc_HQ_Cua_Khau").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            If mIn_Phu_Luc Then    'In theo phu lục , parameter riêng cho tơ khai có phụ lục

                'Kết quả kiểm tra
                pMenu_Ket_Qua_Kiem_Tra = "Kiểm tra " & myData1.Rows(0).Item("Tong_So_Tui") & " túi  =  " & myData1.Rows(0).Item("Tong_Khoi_Luong") & " Kgs"
                pMenu_Ket_Qua_Kiem_Tra = pMenu_Ket_Qua_Kiem_Tra & vbNewLine & "Hàng xuất đúng theo khai của người khai hải quan."
                pMenu_Ket_Qua_Kiem_Tra = pMenu_Ket_Qua_Kiem_Tra & vbNewLine & "(Có bản kê chi tiết kèm theo tờ khai Hải quan)"


                'p15_Mo_Ta_Hang_Hoa
                _pThamSo.Value = ""
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p15_Mo_Ta_Hang_Hoa").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p16_Ma_so_hang_hoa dang lam cho nay
                _pThamSo.Value = ""
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p16_Ma_so_hang_hoa").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p17_Xuat_xu
                _pThamSo.Value = ""
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p17_Xuat_xu").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p18_Luong_hang
                _pThamSo.Value = ""
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p18_Luong_hang").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p19_Don_Vi_Tinh
                _pThamSo.Value = ""
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p19_Don_Vi_Tinh").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p20_Don_Gia
                _pThamSo.Value = 0
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p20_Don_Gia").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'p21_Tri_Gia
                _pThamSo.Value = mTong_Gia_Tri_Hang
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("p21_Tri_Gia").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                '-----Tờ phục lục
                'If myData2.Rows.Count > 1 Then 'Mới comment lại chỗ này
                    Dim myData2_tmp As New DataTable
                    myData2B = myData2.Copy
                    myData2B.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"
                    mCur_Ma_E1 = ""
                    mPre_Ma_E1 = ""
                    Dim iSTT As Integer
                    iSTT = 0

                    For idx = 0 To myData2B.Rows.Count - 1
                        mCur_Ma_E1 = myData2B.Rows(idx).Item("Ma_E1")

                        Dim myMa_Nuoc As New Ma_Nuoc(GConnectionString)
                        If mPre_Ma_E1 <> mCur_Ma_E1 Then
                            iSTT = iSTT + 1
                            myData2B.Rows(idx).Item("STT") = iSTT
                            myData2B.Rows(idx).Item("Ma_E1") = myData2B.Rows(idx).Item("Ma_E1") & vbNewLine & myData2B.Rows(idx).Item("Khoi_Luong") & " grs/ " & myData2B.Rows(idx).Item("Nuoc_Tra")
                            myData2B.Rows(idx).Item("Nguoi_Gui") = myData2B.Rows(idx).Item("Nguoi_Gui") & vbNewLine & myData2B.Rows(idx).Item("Dia_Chi_Gui")
                            myData2B.Rows(idx).Item("Nguoi_Nhan") = myData2B.Rows(idx).Item("Nguoi_Nhan") & "," & myMa_Nuoc.Lay(myData2.Rows(idx).Item("Nuoc_Tra")).Ten_Nuoc
                            pTong_Khoi_Luong_Hang = pTong_Khoi_Luong_Hang + myData2B.Rows(idx).Item("Khoi_Luong")
                        Else
                            myData2B.Rows(idx).Item("STT") = 0
                            myData2B.Rows(idx).Item("Ma_E1") = ""
                            myData2B.Rows(idx).Item("Nguoi_Gui") = ""
                            myData2B.Rows(idx).Item("Dia_Chi_Gui") = ""
                            myData2B.Rows(idx).Item("Nguoi_Nhan") = ""
                            myData2B.Rows(idx).Item("Dia_Chi_Nhan") = ""
                            myData2B.Rows(idx).Item("Nuoc_Tra") = ""
                        End If
                        mPre_Ma_E1 = mCur_Ma_E1
                        'End If

                    Next

                    'Tiêu đề
                    pMenu_Tieu_De = "PHỤ LỤC TỜ KHAI HÀNG HÓA XUẤT KHẨU PHI MẬU DỊCH"
                    _pThamSo.Value = pMenu_Tieu_De
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Tieu_De").ApplyCurrentValues(pvCollection)
                    'Cuc HQ
                    _pThamSo.Value = pMenu_Cuc_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Chi Cuc HQ
                    _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Chi_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'Ghi chú
                    Dim dTemp1 As Date
                    dTemp1 = myData1.Rows(0).Item("Ngay_Khai")
                    pMenu_Ghi_Chu = "(Kèm theo tờ khai hải quan số : " & IIf(Trim(myData1.Rows(0).Item("So_To_Khai_HQ_Cap")) <> "", myData1.Rows(0).Item("So_To_Khai_HQ_Cap"), ".................") & " ngày " & dTemp1.ToString("dd/MM/yyyy") & ") tỷ giá (VND/USD)................. ngày......../......../20"
                    _pThamSo.Value = pMenu_Ghi_Chu
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Ghi_Chu").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    pMenu_Ngay_Thang_Nam = "Hà Nội, ngày  " & dTemp1.Day.ToString("00") & "  tháng  " & dTemp1.Month.ToString("00") & "  năm  " & dTemp1.Year.ToString("0000")
                    _pThamSo.Value = pMenu_Ngay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    pMenu_Co_Quan_Hai_Quan = "Cơ quan Hải quan............................."
                    _pThamSo.Value = pMenu_Co_Quan_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Co_Quan_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'pTong_So_tui
                    'pTong_So_Kien
                    _pThamSo.Value = mTong_So_BP
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pTong_So_tui").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'pTong_Trong_Luong

                    _pThamSo.Value = System.Math.Round(pTong_Khoi_Luong_Hang / 1000, 3)
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pTong_Trong_Luong").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    _pThamSo.Value = pMenu_So_TKHQ
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_So_To_Khai").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    myReport_To_Khai_Chi_Tiet.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                    myReport_To_Khai_Chi_Tiet.SetDataSource(myData2B)
                    'lấy số trang báo cáo
                    intPageCount = myReport_To_Khai_Chi_Tiet.FormatEngine.GetLastPageNumber(New CrystalDecisions.Shared.ReportPageRequestContext)

                    'Thêm parameter tờ khai chính
                    'Thông tin đính kèm
                    pMenu_Thong_Tin_Dinh_Kem = myData1.Rows(0).Item("Thong_Tin_Tai_Lieu") & vbNewLine & "Đính kèm 0" & CStr(intPageCount) & " bản kê hàng hóa gồm " & CStr(mTong_So_BP) & " bưu phẩm"

                    'End If 'mới comment lại chỗ này
                'In tờ khai
                'Số phụ lục tờ khai
                _pThamSo.Value = pMenu_Thong_Tin_Dinh_Kem
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Thong_Tin_Dinh_Kem").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                _pThamSo.Value = intPageCount
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pTong_So_To_Phu_Luc").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()


                myReport_To_Khai.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                myReport_To_Khai.SetDataSource(myData1)
                If mPreview Then
                    Dim frmView As New FrmPrint_Kiem_Hoa
                    frmView.GSo_Ban_In_To_Khai = mSo_Ban
                    frmView.rptViewer.ReportSource = myReport_To_Khai
                    frmView.ShowDialog()
                Else
                    myReport_To_Khai.PrintToPrinter(mSo_Ban, True, 0, 0)
                End If
                'In phụ lục
                If mPreview Then
                    Dim frmViewChiTiet As New FrmViewReports
                    frmViewChiTiet.CrystalReportViewer1.ReportSource = myReport_To_Khai_Chi_Tiet
                    frmViewChiTiet.ShowDialog()
                Else
                    myReport_To_Khai_Chi_Tiet.PrintToPrinter(mSo_Ban, True, 0, 0)
                End If

            Else    'In tờ khai 1 tờ

                    'myReport_To_Khai = New rptTo_Khai_Hang_Xuat
                    'Dong tai lieu
                pMenu_Thong_Tin_Dinh_Kem = myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")
                    If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) <> "" Then
                        myRow = myData3.NewRow()
                        myRow("STT") = 0
                        myRow("Ma_E1") = ""
                        myRow("Khoi_Luong") = 0
                        myRow("Nguoi_Gui") = ""
                        myRow("Dia_Chi_Gui") = ""
                        myRow("Nguoi_Nhan") = ""
                        myRow("Dia_Chi_Nhan") = ""
                    myRow("Ten_Hang_Hoa") = "" 'Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu"))
                        myRow("Xuat_Xu") = ""
                        myRow("Luong_Hang") = 0
                        myRow("Don_Vi_Tinh") = ""
                        myRow("Gia_Tri_Hang") = 0
                        myRow("Ma_Tien_Te") = ""
                        myData3.Rows.Add(myRow)
                    End If
                    'Kiem tra
                    If myData2.Rows.Count = 0 Then
                        If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) = "" Then
                            MessageBox.Show("Tờ khai này không có thông tin chi tiết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                            Exit Function
                        End If
                    Else
                        'Dong xuat N buu pham
                        myRow = myData3.NewRow()
                        myRow("STT") = 0
                        myRow("Ma_E1") = ""
                        myRow("Khoi_Luong") = 0
                        myRow("Nguoi_Gui") = ""
                        myRow("Dia_Chi_Gui") = ""
                        myRow("Nguoi_Nhan") = ""
                        myRow("Dia_Chi_Nhan") = ""
                        myRow("Ten_Hang_Hoa") = "Xuất " & mTong_So_BP.ToString & " bưu phẩm :"
                        myRow("Xuat_Xu") = ""
                        myRow("Luong_Hang") = 0
                        myRow("Don_Vi_Tinh") = ""
                        myRow("Gia_Tri_Hang") = 0
                        myRow("Ma_Tien_Te") = ""
                        myData3.Rows.Add(myRow)
                        'Duyet chi tiet
                        mCur_Ma_E1 = ""
                        mPre_Ma_E1 = ""
                        For idx = 0 To myData2.Rows.Count - 1
                            'Dong số hiệu và khối lượng bưu phẩm
                            mCur_Ma_E1 = myData2.Rows(idx).Item("Ma_E1")
                            If mPre_Ma_E1 <> mCur_Ma_E1 Then
                                myRow = myData3.NewRow()
                                myRow("STT") = 0
                                myRow("Ma_E1") = ""
                                myRow("Khoi_Luong") = 0
                                myRow("Nguoi_Gui") = ""
                                myRow("Dia_Chi_Gui") = ""
                                myRow("Nguoi_Nhan") = ""
                                myRow("Dia_Chi_Nhan") = ""
                                myRow("Ten_Hang_Hoa") = myData2.Rows(idx).Item("Ma_E1") & " / " & myData2.Rows(idx).Item("Khoi_Luong") & " grs"
                                myRow("Xuat_Xu") = myData2.Rows(idx).Item("Xuat_xu")
                                myRow("Luong_Hang") = 0
                                myRow("Don_Vi_Tinh") = ""
                                myRow("Gia_Tri_Hang") = 0
                                myRow("Ma_Tien_Te") = ""
                                myData3.Rows.Add(myRow)
                            End If
                            mPre_Ma_E1 = mCur_Ma_E1
                            'Dòng hàng hóa
                            myRow = myData3.NewRow()
                            myRow("STT") = 0
                            myRow("Ma_E1") = ""
                            myRow("Khoi_Luong") = 0
                            myRow("Nguoi_Gui") = ""
                            myRow("Dia_Chi_Gui") = ""
                            myRow("Nguoi_Nhan") = ""
                            myRow("Dia_Chi_Nhan") = ""
                            myRow("Ma_Hang_Hoa") = " " & myData2.Rows(idx).Item("Ma_Hang_Hoa")
                            myRow("Ten_Hang_Hoa") = "    " & myData2.Rows(idx).Item("Ten_Hang_Hoa")
                            myRow("Xuat_Xu") = ""
                            myRow("Luong_Hang") = myData2.Rows(idx).Item("Luong_Hang")
                            myRow("Don_Vi_Tinh") = myData2.Rows(idx).Item("Don_Vi_Tinh")
                            myRow("Gia_Tri_Hang") = myData2.Rows(idx).Item("Gia_Tri_Hang")
                            myRow("Ma_Tien_Te") = myData2.Rows(idx).Item("Ma_Tien_Te")
                            myData3.Rows.Add(myRow)
                        Next
                    End If
                    'Trường hợp có 1 mặt hàng. Thêm parameter tờ khai chính
                    If (mayData_Hang_Xuat.Rows.Count = 1) Then
                        'Có 1 mặt hàng
                        'Thông tin đính kèm

                        _pThamSo.Value = pMenu_Thong_Tin_Dinh_Kem
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Thong_Tin_Dinh_Kem").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()

                        'p15_Mo_Ta_Hang_Hoa
                        _pThamSo.Value = CStr(myData2.Rows(0).Item("Ma_E1")) & ", " & CStr(mayData_Hang_Xuat.Rows(0).Item("Ten_Hang_Hoa"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p15_Mo_Ta_Hang_Hoa").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p16_Ma_so_hang_hoa dang lam cho nay
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Ma_Hang_Hoa"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p16_Ma_so_hang_hoa").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p17_Xuat_xu
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Xuat_Xu"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p17_Xuat_xu").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p18_Luong_hang
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Luong_Hang"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p18_Luong_hang").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p19_Don_Vi_Tinh
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Don_Vi_Tinh"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p19_Don_Vi_Tinh").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p20_Don_Gia
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Don_Gia"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p20_Don_Gia").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                        'p21_Tri_Gia
                        _pThamSo.Value = CStr(mayData_Hang_Xuat.Rows(0).Item("Gia_Tri_Hang"))
                        pvCollection.Add(_pThamSo)
                        myReport_To_Khai.DataDefinition.ParameterFields("p21_Tri_Gia").ApplyCurrentValues(pvCollection)
                        pvCollection.Clear()
                Else 'Hang xuat la tai lieu, Khong co mat hang chi tiet.


                    _pThamSo.Value = pMenu_Thong_Tin_Dinh_Kem
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Thong_Tin_Dinh_Kem").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    'p15_Mo_Ta_Hang_Hoa
                    _pThamSo.Value = ""
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p15_Mo_Ta_Hang_Hoa").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p16_Ma_so_hang_hoa dang lam cho nay
                    _pThamSo.Value = ""
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p16_Ma_so_hang_hoa").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p17_Xuat_xu
                    _pThamSo.Value = ""
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p17_Xuat_xu").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p18_Luong_hang
                    _pThamSo.Value = ""
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p18_Luong_hang").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p19_Don_Vi_Tinh
                    _pThamSo.Value = ""
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p19_Don_Vi_Tinh").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p20_Don_Gia
                    _pThamSo.Value = 0
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p20_Don_Gia").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'p21_Tri_Gia
                    _pThamSo.Value = 0
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai.DataDefinition.ParameterFields("p21_Tri_Gia").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                End If
                _pThamSo.Value = 0
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pTong_So_To_Phu_Luc").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                myData3.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"
                'Dat trang thai wait cho Mouse
                Frm_Lap_To_Khai_Chuyen_Hoan.ActiveForm.Cursor.Current = Cursors.Default

                'In
                '-----To khai tong hop
                Dim dsSoLieu As New DataSet
                dsSoLieu.Tables.Add(myData1.Copy)
                dsSoLieu.Tables.Add(myData3.Copy)
                dsSoLieu.AcceptChanges()
                myReport_To_Khai.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                myReport_To_Khai.SetDataSource(dsSoLieu)
                If mPreview Then
                    Dim frmView As New FrmPrint_Kiem_Hoa
                    frmView.GSo_Ban_In_To_Khai = mSo_Ban
                    frmView.rptViewer.ReportSource = myReport_To_Khai
                    frmView.ShowDialog()
                Else
                    myReport_To_Khai.PrintToPrinter(mSo_Ban, True, 0, 0)
                End If
            End If
            'In tờ kết quả kiểm hóa
            If chk_In_KQ_KT.Checked = True Then
                Dim mTong_Khoi_Luong_Mat_Sau As Double
                Dim mSo_Kien_Mat_Sau As Integer
                mTong_Khoi_Luong_Mat_Sau = System.Math.Round(pTong_Khoi_Luong_Hang / 1000, 3)
                Dim pKet_Qua_KT_1, pKet_Qua_KT_2 As String

                pKet_Qua_KT_1 = "Lô hàng gồm " & myData1.Rows(0).Item("Tong_So_Tui") & "  túi = " & myData1.Rows(0).Item("Tong_Khoi_Luong") & " kgs, kiểm tra qua máy soi"


                If (intPageCount = 0) Then
                    pKet_Qua_KT_2 = ""
                Else
                    pKet_Qua_KT_2 = "Hàng xuất đúng như kê khai (gồm có " & intPageCount.ToString & " tờ phụ lục kèm theo)"
                End If


                Dim myReport_rpt06_PGKQKT_GSQL As New rpt06_PGKQKT_GSQL_HAN_Soi_May
                _pThamSo.Value = pKet_Qua_KT_1
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pKet_Qua_KT1").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                _pThamSo.Value = pKet_Qua_KT_2
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pKet_Qua_KT2").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'kiem tra chi tiet
                Dim ptest1 As String = "False"
                _pThamSo.Value = ptest1
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pKiem_tra_chi_tiet").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'kiem tra qua may soi
                Dim ptest2 As String = "True"
                _pThamSo.Value = ptest2
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pKiem_tra_qua_may").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'kiem tra thu cong
                Dim ptest3 As String = "False"
                _pThamSo.Value = ptest3
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pKiem_tra_thu_cong").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'don vi hai quan
                _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pChi_cuc_hai_quan").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'chi cuc hải quan cửa khẩu
                _pThamSo.Value = "Chi cục HQCKQT Nội Bài"
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pChi_cuc_hai_quan_cua_khau").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()
                'Số tờ khai mã vạch
                _pThamSo.Value = myData1.Rows(0).Item("So_TKHQ")
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pSo_to_khai").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Số tờ khai mã vạch
                _pThamSo.Value = myData1.Rows(0).Item("So_To_Khai_HQ_Cap")
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pSo_to_khai_HQ_cap").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Số tờ khai
                _pThamSo.Value = myData1.Rows(0).Item("Ngay_khai")
                pvCollection.Add(_pThamSo)
                myReport_rpt06_PGKQKT_GSQL.DataDefinition.ParameterFields("pNgay_gio_dang_ky").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'In 
                If mPreview Then
                    Dim frmViewKQKT As New FrmPrint_Kiem_Hoa
                    frmViewKQKT.rptViewer.ReportSource = myReport_rpt06_PGKQKT_GSQL
                    frmViewKQKT.ShowDialog()
                Else
                    myReport_rpt06_PGKQKT_GSQL.PrintToPrinter(1, True, 0, 0)
                End If
            End If
            'Kết thúc in kết quả kiểm hóa
            myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsPrint(mMa_To_Khai, True)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return False
    End Function
#End Region
#Region "In_To_Khai_Hai_Quan_Xuat"
    Private Function In_To_Khai_Hai_Quan_Xuat(ByVal mMa_To_Khai As String, ByVal mIn_Phu_Luc As Boolean, ByVal mPreview As Boolean, ByVal mSo_Ban As Integer) As Boolean
        Try
            'Khai bao bien
            Dim myData1, myData2, myData2B As DataTable
            Dim idx As Integer
            Dim myReport_To_Khai As ReportClass
            Dim myReport_To_Khai_Chi_Tiet As New rpt_To_Khai_Hang_Xuat_Chi_Tiet
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim pMenu_Cuc_Hai_Quan As String
            Dim pMenu_Chi_Cuc_Hai_Quan As String
            Dim pMenu_Ngay_Thang_Nam As String
            Dim pMenu_So_TKHQ As String
            Dim pMenu_Thong_Tin_Dinh_Kem As String
            Dim pMenu_Tieu_De As String
            Dim pMenu_Ghi_Chu As String
            Dim pMenu_Co_Quan_Hai_Quan As String
            Dim pMenu_Dia_Diem_Kiem_Tra As String
            Dim pMenu_Ket_Qua_Kiem_Tra As String

            'Lay du lieu to khai cho dataset
            myData1 = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay_Boi_Ma_To_Khai_In_To_Khai(mMa_To_Khai).Tables(0)
            myData1.TableName = "To_Khai_Hai_Quan_Xuat"
            'Kiem tra co to khai trong database khong
            If myData1.Rows.Count = 0 Then
                MessageBox.Show("Không có thông tin tờ khai!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
                Exit Function
            End If
            'Kiem tra xem da in to khai nay chua 
            If myData1.Rows(0).Item("IsPrint") Then
                If MessageBox.Show("Tờ khai này đã được in rồi. Bạn có chắc chắn muốn in lại không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then  'Neu khong dong y in thi thoat
                    Return True
                    Exit Function
                End If
            End If
            'Dat trang thai wait cho Mouse
            Frm_Lap_To_Khai_Chuyen_Hoan.ActiveForm.Cursor.Current = Cursors.WaitCursor

            'Lay du lieu cho Paramete
            pMenu_Cuc_Hai_Quan = "Hà Nội"
            pMenu_Chi_Cuc_Hai_Quan = "Nội Bài"
            Dim dTemp As Date
            dTemp = myData1.Rows(0).Item("Ngay_Khai")
            pMenu_Ngay_Thang_Nam = dTemp.Day.ToString("00") & "   " & dTemp.Month.ToString("00") & "   " & dTemp.Year.ToString("0000")
            Dim iTemp As Integer
            iTemp = myData1.Rows(0).Item("So_TKHQ")
            pMenu_So_TKHQ = iTemp.ToString("000000")

            'Lay du lieu chi tiet cua to khai cho dataset
            myData2 = myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Lay_Thong_Tin_Chi_Tiet_In_To_Khai(mMa_To_Khai).Tables(0)
            myData2.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"

            'Tính toán tổng số dòng và tổng số trang cần in
            Dim mTong_So_Dong, mTong_So_Trang, mTong_So_BP As Integer
            Dim mTong_So_Dong_Tren_Trang_Phu_Luc As Integer = 30
            Dim mCur_Ma_E1, mPre_Ma_E1 As String
            'Lay tong so bưu phẩm
            mTong_So_BP = myE1_Kiem_Hoa_Xuat.E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(mMa_To_Khai).Tables(0).Rows.Count

            If Not mIn_Phu_Luc Then   'người dùng không check chọn in kiểu phụ lục                
                mTong_So_Dong = 0
                mTong_So_Trang = 0
                '======Dòng ("Thư chứng từ tài liệu đã giao dịch"
                If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) <> "" Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                '======Dòng ("Xuất N bưu phẩm")
                If myData2.Rows.Count > 0 Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                'Bắt đầu phần chi tiết hàng hóa
                mCur_Ma_E1 = ""
                mPre_Ma_E1 = ""
                For idx = 0 To myData2.Rows.Count - 1
                    mCur_Ma_E1 = myData2.Rows(idx).Item("Ma_E1")
                    'Dong tieu de cho moi buu pham
                    If mPre_Ma_E1 <> mCur_Ma_E1 Then
                        mTong_So_Dong = mTong_So_Dong + 1
                    End If
                    mPre_Ma_E1 = mCur_Ma_E1
                    'Dong hang hoa
                    mTong_So_Dong = mTong_So_Dong + 1
                Next
                'Nếu tổng số dòng lớn hơn 5 thì vẫn phải chuyển sang in kiểu phụ lục
                If mTong_So_Dong > 5 Then
                    'mIn_Phu_Luc = True cũ dang như vậy
                End If
            End If

            

            'Tính toán trang in theo kiểu phụ lục
            If mIn_Phu_Luc Then   'in kieu phu luc
                mTong_So_Dong = 0
                mTong_So_Trang = 0
                For idx = 0 To myData2.Rows.Count - 1
                    mTong_So_Dong = mTong_So_Dong + 1
                Next
                If mTong_So_Dong Mod mTong_So_Dong_Tren_Trang_Phu_Luc = 0 Then
                    mTong_So_Trang = mTong_So_Dong \ mTong_So_Dong_Tren_Trang_Phu_Luc
                Else
                    mTong_So_Trang = mTong_So_Dong \ mTong_So_Dong_Tren_Trang_Phu_Luc + 1
                End If
            End If

            'bắt đầu in   
            'Tạo bảng Data3 giống Data2 để đưa dữ liệu vào
            Dim myData3 As New DataTable
            Dim colSTT, colMa_E1, colKhoi_Luong, colNguoi_Gui, colDia_Chi_Gui, colNguoi_Nhan As DataColumn
            Dim colDia_Chi_Nhan, colTen_Hang_Hoa, colXuat_Xu, colLuong_Hang, colMa_Hang_Hoa As DataColumn
            Dim colDon_Vi_Tinh, colNuoc_Tra, colGia_Tri_Hang, colMa_Tien_Te As DataColumn
            Dim myRow As DataRow
            colSTT = New DataColumn("STT", GetType(Integer))
            myData3.Columns.Add(colSTT)

            colMa_E1 = New DataColumn("Ma_E1", GetType(String))
            myData3.Columns.Add(colMa_E1)

            colKhoi_Luong = New DataColumn("Khoi_Luong", GetType(Integer))
            myData3.Columns.Add(colKhoi_Luong)

            colNguoi_Gui = New DataColumn("Nguoi_Gui", GetType(String))
            myData3.Columns.Add(colNguoi_Gui)

            colDia_Chi_Gui = New DataColumn("Dia_Chi_Gui", GetType(String))
            myData3.Columns.Add(colDia_Chi_Gui)

            colNguoi_Nhan = New DataColumn("Nguoi_Nhan", GetType(String))
            myData3.Columns.Add(colNguoi_Nhan)

            colDia_Chi_Nhan = New DataColumn("Dia_Chi_Nhan", GetType(String))
            myData3.Columns.Add(colDia_Chi_Nhan)

            colMa_Hang_Hoa = New DataColumn("Ma_Hang_Hoa", GetType(String))
            myData3.Columns.Add(colMa_Hang_Hoa)

            colTen_Hang_Hoa = New DataColumn("Ten_Hang_Hoa", GetType(String))
            myData3.Columns.Add(colTen_Hang_Hoa)

            colXuat_Xu = New DataColumn("Xuat_Xu", GetType(String))
            myData3.Columns.Add(colXuat_Xu)

            colLuong_Hang = New DataColumn("Luong_Hang", GetType(Decimal))
            myData3.Columns.Add(colLuong_Hang)

            colDon_Vi_Tinh = New DataColumn("Don_Vi_Tinh", GetType(String))
            myData3.Columns.Add(colDon_Vi_Tinh)

            colNuoc_Tra = New DataColumn("Nuoc_Tra", GetType(String))
            myData3.Columns.Add(colNuoc_Tra)

            colGia_Tri_Hang = New DataColumn("Gia_Tri_Hang", GetType(Decimal))
            myData3.Columns.Add(colGia_Tri_Hang)

            colMa_Tien_Te = New DataColumn("Ma_Tien_Te", GetType(String))
            myData3.Columns.Add(colMa_Tien_Te)

            If mIn_Phu_Luc Then    'In theo phu lục 
                myReport_To_Khai = New rptTo_Khai_Hang_Xuat_Phu_Luc
                'Cuc Hai Quan
                _pThamSo.Value = pMenu_Cuc_Hai_Quan
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Chi Cuc Hai Quan
                _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Chi_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'So_TKHQ
                _pThamSo.Value = pMenu_So_TKHQ
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_So_TKHQ").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Ngay_Thang_Nam
                _pThamSo.Value = pMenu_Ngay_Thang_Nam
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Thông tin đính kèm
                pMenu_Thong_Tin_Dinh_Kem = "Đính kèm " & mTong_So_Trang.ToString("#00") & " bản kê hàng hóa gồm " & mTong_So_BP.ToString & " bưu phẩm"
                _pThamSo.Value = pMenu_Thong_Tin_Dinh_Kem
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Thong_Tin_Dinh_Kem").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Địa điểm kiểm tra
                pMenu_Dia_Diem_Kiem_Tra = "Đội TTCPN - EMS"
                _pThamSo.Value = pMenu_Dia_Diem_Kiem_Tra
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Dia_Diem_Kiem_Tra").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Kết quả kiểm tra
                pMenu_Ket_Qua_Kiem_Tra = "Kiểm tra " & myData1.Rows(0).Item("Tong_So_Tui") & " túi  =  " & myData1.Rows(0).Item("Tong_Khoi_Luong") & " Kgs"
                pMenu_Ket_Qua_Kiem_Tra = pMenu_Ket_Qua_Kiem_Tra & vbNewLine & "Hàng xuất đúng theo khai của người khai hải quan."
                pMenu_Ket_Qua_Kiem_Tra = pMenu_Ket_Qua_Kiem_Tra & vbNewLine & "(Có bản kê chi tiết kèm theo tờ khai Hải quan)"
                _pThamSo.Value = pMenu_Ket_Qua_Kiem_Tra
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Ket_Qua_Kiem_Tra").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Dat trang thai wait cho Mouse
                Frm_Lap_To_Khai_Chuyen_Hoan.ActiveForm.Cursor.Current = Cursors.Default

                'In
                '-----To khai tong hop
                myReport_To_Khai.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                myReport_To_Khai.SetDataSource(myData1)
                If mPreview Then
                    Dim frmView As New FrmPrint_Kiem_Hoa
                    frmView.GSo_Ban_In_To_Khai = mSo_Ban
                    frmView.rptViewer.ReportSource = myReport_To_Khai
                    frmView.ShowDialog()
                Else
                    myReport_To_Khai.PrintToPrinter(mSo_Ban, True, 0, 0)
                End If

                '-----Tờ phục lục
                If myData2.Rows.Count > 0 Then
                    myData2B = myData2.Copy
                    myData2B.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"
                    mCur_Ma_E1 = ""
                    mPre_Ma_E1 = ""
                    Dim iSTT As Integer
                    iSTT = 0
                    For idx = 0 To myData2B.Rows.Count - 1
                        mCur_Ma_E1 = myData2B.Rows(idx).Item("Ma_E1")
                        If mPre_Ma_E1 <> mCur_Ma_E1 Then
                            iSTT = iSTT + 1
                            myData2B.Rows(idx).Item("STT") = iSTT
                            myData2B.Rows(idx).Item("Ma_E1") = myData2B.Rows(idx).Item("Ma_E1") & vbNewLine & myData2B.Rows(idx).Item("Khoi_Luong") & " grs/ " & myData2B.Rows(idx).Item("Nuoc_Tra")
                            myData2B.Rows(idx).Item("Nguoi_Gui") = myData2B.Rows(idx).Item("Nguoi_Gui") & vbNewLine & myData2B.Rows(idx).Item("Dia_Chi_Gui")
                        Else
                            myData2B.Rows(idx).Item("STT") = 0
                            myData2B.Rows(idx).Item("Ma_E1") = ""
                            myData2B.Rows(idx).Item("Nguoi_Gui") = ""
                            myData2B.Rows(idx).Item("Dia_Chi_Gui") = ""
                            myData2B.Rows(idx).Item("Nguoi_Nhan") = ""
                            myData2B.Rows(idx).Item("Dia_Chi_Nhan") = ""
                            myData2B.Rows(idx).Item("Nuoc_Tra") = ""
                        End If
                        mPre_Ma_E1 = mCur_Ma_E1
                    Next

                    'Cuc HQ
                    _pThamSo.Value = pMenu_Cuc_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'Chi Cuc HQ
                    _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Chi_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()
                    'Tiêu đề
                    pMenu_Tieu_De = "PHỤ LỤC TỜ KHAI HÀNG HÓA XUẤT KHẨU PHI MẬU DỊCH"
                    _pThamSo.Value = pMenu_Tieu_De
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Tieu_De").ApplyCurrentValues(pvCollection)
                    'Ghi chú
                    Dim dTemp1 As Date
                    dTemp1 = myData1.Rows(0).Item("Ngay_Khai")
                    pMenu_Ghi_Chu = "(Kèm theo tờ khai hải quan số : " & IIf(Trim(myData1.Rows(0).Item("So_To_Khai_HQ_Cap")) <> "", myData1.Rows(0).Item("So_To_Khai_HQ_Cap"), ".................") & " ngày " & dTemp1.ToString("dd/MM/yyyy") & ") tỷ giá (VND/USD)................. ngày......../......../20"
                    _pThamSo.Value = pMenu_Ghi_Chu
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Ghi_Chu").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    pMenu_Ngay_Thang_Nam = "Hà Nội, ngày  " & dTemp1.Day.ToString("00") & "  tháng  " & dTemp1.Month.ToString("00") & "  năm  " & dTemp1.Year.ToString("0000")
                    _pThamSo.Value = pMenu_Ngay_Thang_Nam
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    pMenu_Co_Quan_Hai_Quan = "Cơ quan Hải quan............................."
                    _pThamSo.Value = pMenu_Co_Quan_Hai_Quan
                    pvCollection.Add(_pThamSo)
                    myReport_To_Khai_Chi_Tiet.DataDefinition.ParameterFields("pMenu_Co_Quan_Hai_Quan").ApplyCurrentValues(pvCollection)
                    pvCollection.Clear()

                    myReport_To_Khai_Chi_Tiet.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                    myReport_To_Khai_Chi_Tiet.SetDataSource(myData2B)
                    Dim frmViewChiTiet As New FrmViewReports
                    frmViewChiTiet.CrystalReportViewer1.ReportSource = myReport_To_Khai_Chi_Tiet
                    frmViewChiTiet.ShowDialog()
                End If
            Else    'In tờ khai 1 tờ
                myReport_To_Khai = New rptTo_Khai_Hang_Xuat_Phu_Luc
                'Dong tai lieu
                If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) <> "" Then
                    myRow = myData3.NewRow()
                    myRow("STT") = 0
                    myRow("Ma_E1") = ""
                    myRow("Khoi_Luong") = 0
                    myRow("Nguoi_Gui") = ""
                    myRow("Dia_Chi_Gui") = ""
                    myRow("Nguoi_Nhan") = ""
                    myRow("Dia_Chi_Nhan") = ""
                    myRow("Ten_Hang_Hoa") = Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu"))
                    myRow("Xuat_Xu") = ""
                    myRow("Luong_Hang") = 0
                    myRow("Don_Vi_Tinh") = ""
                    myRow("Gia_Tri_Hang") = 0
                    myRow("Ma_Tien_Te") = ""
                    myData3.Rows.Add(myRow)
                End If
                'Kiem tra
                If myData2.Rows.Count = 0 Then
                    If Trim(myData1.Rows(0).Item("Thong_Tin_Tai_Lieu")) = "" Then
                        MessageBox.Show("Tờ khai này không có thông tin chi tiết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                        Exit Function
                    End If
                Else
                    'Dong xuat N buu pham
                    myRow = myData3.NewRow()
                    myRow("STT") = 0
                    myRow("Ma_E1") = ""
                    myRow("Khoi_Luong") = 0
                    myRow("Nguoi_Gui") = ""
                    myRow("Dia_Chi_Gui") = ""
                    myRow("Nguoi_Nhan") = ""
                    myRow("Dia_Chi_Nhan") = ""
                    myRow("Ten_Hang_Hoa") = "Xuất " & mTong_So_BP.ToString & " bưu phẩm :"
                    myRow("Xuat_Xu") = ""
                    myRow("Luong_Hang") = 0
                    myRow("Don_Vi_Tinh") = ""
                    myRow("Gia_Tri_Hang") = 0
                    myRow("Ma_Tien_Te") = ""
                    myData3.Rows.Add(myRow)
                    'Duyet chi tiet
                    mCur_Ma_E1 = ""
                    mPre_Ma_E1 = ""
                    For idx = 0 To myData2.Rows.Count - 1
                        'Dong số hiệu và khối lượng bưu phẩm
                        mCur_Ma_E1 = myData2.Rows(idx).Item("Ma_E1")
                        If mPre_Ma_E1 <> mCur_Ma_E1 Then
                            myRow = myData3.NewRow()
                            myRow("STT") = 0
                            myRow("Ma_E1") = ""
                            myRow("Khoi_Luong") = 0
                            myRow("Nguoi_Gui") = ""
                            myRow("Dia_Chi_Gui") = ""
                            myRow("Nguoi_Nhan") = ""
                            myRow("Dia_Chi_Nhan") = ""
                            myRow("Ten_Hang_Hoa") = myData2.Rows(idx).Item("Ma_E1") & " / " & myData2.Rows(idx).Item("Khoi_Luong") & " grs"
                            myRow("Xuat_Xu") = myData2.Rows(idx).Item("Xuat_xu")
                            myRow("Luong_Hang") = 0
                            myRow("Don_Vi_Tinh") = ""
                            myRow("Gia_Tri_Hang") = 0
                            myRow("Ma_Tien_Te") = ""
                            myData3.Rows.Add(myRow)
                        End If
                        mPre_Ma_E1 = mCur_Ma_E1
                        'Dòng hàng hóa
                        myRow = myData3.NewRow()
                        myRow("STT") = 0
                        myRow("Ma_E1") = ""
                        myRow("Khoi_Luong") = 0
                        myRow("Nguoi_Gui") = ""
                        myRow("Dia_Chi_Gui") = ""
                        myRow("Nguoi_Nhan") = ""
                        myRow("Dia_Chi_Nhan") = ""
                        myRow("Ma_Hang_Hoa") = " " & myData2.Rows(idx).Item("Ma_Hang_Hoa")
                        myRow("Ten_Hang_Hoa") = "    " & myData2.Rows(idx).Item("Ten_Hang_Hoa")
                        myRow("Xuat_Xu") = ""
                        myRow("Luong_Hang") = myData2.Rows(idx).Item("Luong_Hang")
                        myRow("Don_Vi_Tinh") = myData2.Rows(idx).Item("Don_Vi_Tinh")
                        myRow("Gia_Tri_Hang") = myData2.Rows(idx).Item("Gia_Tri_Hang")
                        myRow("Ma_Tien_Te") = myData2.Rows(idx).Item("Ma_Tien_Te")
                        myData3.Rows.Add(myRow)
                    Next
                End If
                myData3.TableName = "Chi_Tiet_To_Khai_Hai_Quan_Xuat"

                'Cuc Hai Quan
                _pThamSo.Value = pMenu_Cuc_Hai_Quan
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Chi Cuc Hai Quan
                _pThamSo.Value = pMenu_Chi_Cuc_Hai_Quan
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Chi_Cuc_Hai_Quan").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'So_TKHQ
                _pThamSo.Value = pMenu_So_TKHQ
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_So_TKHQ").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Ngay_Thang_Nam
                _pThamSo.Value = pMenu_Ngay_Thang_Nam
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Địa điểm kiểm tra
                pMenu_Dia_Diem_Kiem_Tra = "Đội TTCPN - EMS"
                _pThamSo.Value = pMenu_Dia_Diem_Kiem_Tra
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Dia_Diem_Kiem_Tra").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Kết quả kiểm tra
                pMenu_Ket_Qua_Kiem_Tra = "Kiểm tra " & myData1.Rows(0).Item("Tong_So_Tui") & " túi  =  " & myData1.Rows(0).Item("Tong_Khoi_Luong") & " Kgs"
                pMenu_Ket_Qua_Kiem_Tra = pMenu_Ket_Qua_Kiem_Tra & vbNewLine & "Hàng xuất đúng theo khai của người khai Hải quan."
                _pThamSo.Value = pMenu_Ket_Qua_Kiem_Tra
                pvCollection.Add(_pThamSo)
                myReport_To_Khai.DataDefinition.ParameterFields("pMenu_Ket_Qua_Kiem_Tra").ApplyCurrentValues(pvCollection)
                pvCollection.Clear()

                'Dat trang thai wait cho Mouse
                Frm_Lap_To_Khai_Chuyen_Hoan.ActiveForm.Cursor.Current = Cursors.Default

                'In
                '-----To khai tong hop
                Dim dsSoLieu As New DataSet
                dsSoLieu.Tables.Add(myData1.Copy)
                dsSoLieu.Tables.Add(myData3.Copy)
                dsSoLieu.AcceptChanges()
                myReport_To_Khai.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
                myReport_To_Khai.SetDataSource(dsSoLieu)
                If mPreview Then
                    Dim frmView As New FrmPrint_Kiem_Hoa
                    frmView.GSo_Ban_In_To_Khai = mSo_Ban
                    frmView.rptViewer.ReportSource = myReport_To_Khai
                    frmView.ShowDialog()
                Else
                    myReport_To_Khai.PrintToPrinter(mSo_Ban, True, 0, 0)
                End If
            End If
            myTo_Khai_Hai_Quan_Xuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsPrint(mMa_To_Khai, True)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return False
    End Function
#End Region
#Region "Kiem_Tra_To_Khai_Trong"
    Private Function Kiem_Tra_To_Khai_Trong() As Integer
        Dim idx As Integer
        Dim mTong As Integer = 0
        For idx = 0 To dgE1_Kiem_Hoa_Xuat.Rows.Count - 1
            If dgE1_Kiem_Hoa_Xuat.Rows(idx).Cells("Ma_E1").Text <> "" Then
                mTong = mTong + 1
            End If
        Next
        Return mTong
        'If mTong = 0 Then
        '    If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai <> "" And myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai <> GIp_May_Tinh Then
        '        MessageBox.Show("Tờ khai này không có thông tin về bưu phẩm cần kiểm hóa, vì vậy không thể cập nhật tờ khai.", "Lỗi cập nhật tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Me.Close()
        '        Me.Dispose()
        '        Exit Function
        '    Else
        '        Me.Close()
        '        Me.Dispose()
        '        Exit Function
        '    End If
        'End If
    End Function
#End Region
#Region "Kiem_Tra_Thong_Tin_Hop_Le"
    Private Function Kiem_Tra_Thong_Tin_Hop_Le() As Boolean
        If txtNguoi_Gui.Text.Trim = "" Then
            MessageBox.Show("Thông tin người gửi không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNguoi_Gui.Select()
            Return False
        End If
        If txtNguoi_Nhan.Text.Trim = "" Then
            MessageBox.Show("Thông tin người nhận không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNguoi_Nhan.Select()
            Return False
        End If
        If txtNguoi_Duoc_Uy_Quyen.Text.Trim = "" Then
            MessageBox.Show("Thông tin người được ủy quyền không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNguoi_Duoc_Uy_Quyen.Select()
            Return False
        End If
        If txtChuyen_Bay.Text.Trim = "" Then
            MessageBox.Show("Thông tin chuyến bay không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtChuyen_Bay.Select()
            Return False
        End If
        'If txtTong_So_Tui.Value = 0 Then
        '    MessageBox.Show("Bạn chưa nhập thông tin tổng số túi!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtTong_So_Tui.Select()
        '    Return False
        'End If
        'If txtTong_Trong_Luong.Value = 0 Then
        '    MessageBox.Show("Bạn chưa nhập thông tin tổng trọng lượng!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtTong_Trong_Luong.Select()
        '    Return False
        'End If
        Return True
    End Function
#End Region
#End Region
#Region "Chi tiết hàng hóa"
#Region "-----------------Gan_Thong_Tin_Tren_Panel_Chi_Tiet_Hang_Hoa-----------------"
    Private Sub Gan_Thong_Tin_Tren_TextBox_Buu_Pham_E1()
        myGridKeyDown = dgE1_Kiem_Hoa_Xuat
        txtThong_Tin_Buu_Pham_E1.Text = myGridKeyDown.ActiveRow.Cells("Ma_E1").Text & "                            " & IIf(myGridKeyDown.ActiveRow.Cells("Phan_Loai").Text = "D", "Tài liệu", "Hàng hóa") & "                            " & myGridKeyDown.ActiveRow.Cells("Khoi_Luong").Text & " grs" & vbNewLine & _
                                        "Thông tin gửi: " & myGridKeyDown.ActiveRow.Cells("Nguoi_Gui").Text & " - " & _
                                            myGridKeyDown.ActiveRow.Cells("Dia_Chi_Gui").Text & vbNewLine & _
                                        "Thông tin nhận: " & myGridKeyDown.ActiveRow.Cells("Nguoi_Nhan").Text & " - " & _
                                            myGridKeyDown.ActiveRow.Cells("Dia_Chi_Nhan").Text

    End Sub

    Private Sub Gan_Thong_Tin_Tren_TextBox_So_Luong_Hang_Hoa(ByVal mKieu As Boolean)
        Dim idx As Integer
        Dim mDong_Hien_Tai As Integer
        Dim mTong_So_Hang_Hoa As Integer
        Dim str As String
        myGridKeyDown = dgE1HangKiemHoaXuat
        mTong_So_Hang_Hoa = 0
        mDong_Hien_Tai = 0
        For idx = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(idx).Cells("Id_Chi_Tiet").Text <> "" Then
                mTong_So_Hang_Hoa = mTong_So_Hang_Hoa + 1
            End If
        Next
        txtTong_So_Muc_Hang.Text = mTong_So_Hang_Hoa
        If mKieu Then       'Tong so
            str = "Tổng số:"
            str = str & vbNewLine & mTong_So_Hang_Hoa.ToString & "(mục hàng)"
        Else   'hien tai / tong so
            str = "Mục hàng:"
            mDong_Hien_Tai = myGridKeyDown.ActiveRow.Index + 1
            str = str & vbNewLine & mDong_Hien_Tai.ToString & " / " & mTong_So_Hang_Hoa.ToString
        End If
        txtThong_Tin_So_Luong_Hang.Text = str
    End Sub
#End Region
#Region "-----------------Ket_Thuc_Nhap_Chi_Tiet_Hang_Hoa-----------------"
    Private Sub Ket_Thuc_Nhap_Chi_Tiet_Hang_Hoa(ByVal mRowIndexOfE1KiemHoa As Integer)
        Try
            If CInt(txtTong_So_Muc_Hang.Text) = 0 Then
                If Not MessageBox.Show("Bạn chưa khai hàng hoá cho bưu phẩm này!!!" & vbNewLine & "Nếu bạn vẫn muốn kê khai hàng hóa cho bưu phẩm này, bạn phải khai ít nhất 1 mục hàng. Nếu không sẽ phát sinh các lỗi về sau." & vbNewLine & "Chọn No hoặc Cancel để tiếp tục nhập hàng hoá, chọn Yes để thoát khỏi chức năng nhập hàng hoá.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    dgE1HangKiemHoaXuat.Select()
                    If dgE1HangKiemHoaXuat.Rows.Count > 0 Then
                        AddNewRow(dgE1HangKiemHoaXuat, True)
                    Else
                        AddNewRow(dgE1HangKiemHoaXuat, False)
                    End If
                    dgE1HangKiemHoaXuat.ActiveCell = dgE1HangKiemHoaXuat.Rows(dgE1HangKiemHoaXuat.Rows.Count - 1).Cells("Ten_Hang_Hoa")
                    dgE1HangKiemHoaXuat.PerformAction(EnterEditMode, False, False)
                    Exit Sub
                End If
            End If
            'Hiện Panel Tờ khai
            Panel_Thong_Tin_To_Khai.Visible = True
            Panel_Chi_Tiet_Hang_Hoa.Visible = False
            'Gán thông tin tổng số mục hàng vào E1_Kiem_Hoa_Xuat              
            dgE1_Kiem_Hoa_Xuat.ActiveCell = dgE1_Kiem_Hoa_Xuat.Rows(mRowIndexOfE1KiemHoa).Cells("Tong_Muc_Hang")
            dgE1_Kiem_Hoa_Xuat.PerformAction(EnterEditMode, False, False)
            dgE1_Kiem_Hoa_Xuat.Rows(mRowIndexOfE1KiemHoa).Cells("Tong_Muc_Hang").Value = CInt(txtTong_So_Muc_Hang.Text)
            dgE1_Kiem_Hoa_Xuat.PerformAction(NextCellByTab, False, False)
            dgE1_Kiem_Hoa_Xuat.PerformAction(EnterEditMode, False, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "-----------------Delete_Row_E1_Hang_Kiem_Hoa_Xuat-------------"
    Private Sub Delete_Row_E1_Hang_Kiem_Hoa_Xuat()
        Try
            'Kiem tra khoa so lieu
            If myTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL Then
                MessageBox.Show("Tờ khai này đã được khóa số liệu!!! Bạn không thể xóa mục hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If dgE1HangKiemHoaXuat.ActiveRow.Cells("Ten_Hang_Hoa").Text <> "" Then
                If MessageBox.Show("Bạn có thực sự muốn xóa mục hàng này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    'Xoa tren E1_Hang_Kiem_Hoa
                    myE1_Hang_Kiem_Hoa_Xuat.E1_Hang_Kiem_Hoa_Xuat_Xoa(dgE1HangKiemHoaXuat.ActiveRow.Cells("Id_Chi_Tiet").Text)
                    'Xoa tren lưới
                    dgE1HangKiemHoaXuat.ActiveRow.Delete(False)
                    CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region
#Region "Dùng chung cho cả 2 Panel"
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
#Region "-----------------AddNewRow-----------"
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
            MessageBox.Show(ex.ToString, "Lỗi thêm dòng mới", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region
#End Region

#Region "Hàm liên quan đến danh mục hàng hóa bổ xung cho phần hàng đi QT"
#Region "-----------------GetDanhMucHang--------------------"
    Private Sub GetDanhMucHang()
        Try
            myData = myDanhMucHang.Danh_Muc_Hang_Danh_Sach_Rut_Gon.Tables(0)
            myDataView = myData.DefaultView
            ddMaHang.DataSource = myDataView
            ddMaHang.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

    '#Region "txtChuyen_Bay_Validated"
    '    Private Sub txtChuyen_Bay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChuyen_Bay.Validated
    '        If txtChuyen_Bay.Text.Trim = "" Then
    '            MessageBox.Show("Thông tin chuyến bay không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            txtChuyen_Bay.Select()
    '        End If
    '    End Sub
    '#End Region

    'Private Sub txtNguoi_Gui_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNguoi_Gui.Validated
    '    If txtNguoi_Gui.Text.Trim = "" Then
    '        MessageBox.Show("Thông tin người gửi không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtNguoi_Gui.Select()
    '    End If
    'End Sub

    'Private Sub txtNguoi_Nhan_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNguoi_Nhan.Validated
    '    If txtNguoi_Nhan.Text.Trim = "" Then
    '        MessageBox.Show("Thông tin người nhận không được để trống!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtNguoi_Nhan.Select()
    '    End If
    'End Sub

    'Private Sub txtTong_So_Tui_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_So_Tui.Validated
    '    If txtTong_So_Tui.Value = 0 Then
    '        MessageBox.Show("Bạn chưa nhập thông tin tổng số túi!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtTong_So_Tui.Select()
    '    End If
    'End Sub

    'Private Sub txtTong_Trong_Luong_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_Trong_Luong.Validated
    '    If txtTong_Trong_Luong.Value = 0 Then
    '        MessageBox.Show("Bạn chưa nhập thông tin tổng trọng lượng!!!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtTong_Trong_Luong.Select()
    '    End If
    'End Sub

    'Private Sub ddMaHang_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ddMaHang.RowSelected
    '    Try
    '        myId_Hang_Hoa = ddMaHang.SelectedRow.Cells("Id_Hang_Hoa").Text
    '    Catch
    '        myId_Hang_Hoa = ""
    '    End Try
    'End Sub
End Class

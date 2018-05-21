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

Public Class FrmNhap_Thay_The_E2
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
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbMa_Bc_Nhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbMa_Bc_Gui As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThem_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_So_BP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTong_Khoi_Luong As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTui_So As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Hieu_Tui_Goi As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtKhoi_Luong_Vo_Tui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgGiaoTuiDi1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkChuyen_Tiep As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSo_Chuyen_Thu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbLoai_Chuyen_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbMa_Dich_Vu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkTui_F As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbLoai_Tui As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_BC37 As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("band0", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Tui")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai_Tui")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Dich_Vu")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Dich_Vu")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_CT")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_CT")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPO")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Buu_Cuc")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNhap_Thay_The_E2))
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.dgGiaoTuiDi1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.cb_BC37 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.cbLoai_Tui = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.chkTui_F = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.cbMa_Dich_Vu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.cbLoai_Chuyen_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.chkChuyen_Tiep = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.txtKhoi_Luong_Vo_Tui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtSo_Hieu_Tui_Goi = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_Khoi_Luong = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So_BP = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtTui_So = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txtSo_Chuyen_Thu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.cbMa_Bc_Nhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Bc_Gui = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnThem_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cb_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_Tui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Dich_Vu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKhoi_Luong_Vo_Tui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Hieu_Tui_Goi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTui_So, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.dgGiaoTuiDi1)
        Me.UltraGroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Black
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox2.HeaderAppearance = Appearance1
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 200)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(288, 352)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.Text = "Thông tin túi gói"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.UltraGroupBox2.Visible = False
        '
        'dgGiaoTuiDi1
        '
        Me.dgGiaoTuiDi1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi1.DisplayLayout.Appearance = Appearance2
        UltraGridBand1.CardSettings.ShowCaption = False
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn1.CellAppearance = Appearance3
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance4
        UltraGridColumn1.Header.Caption = ""
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(25, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance5
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance6
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance7
        UltraGridColumn3.Header.Caption = "Mã bưu cục"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn4.CellAppearance = Appearance8
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance9
        UltraGridColumn4.Header.Caption = "Số chuyến thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance10
        UltraGridColumn5.Header.Caption = "Id ca"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance11
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance12
        UltraGridColumn6.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance13
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance14
        UltraGridColumn7.Header.Caption = "Ngày đóng"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn7.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn7.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.UseEditorMaskSettings = True
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance15
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance16
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance17
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn11.CellAppearance = Appearance18
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance19
        UltraGridColumn11.Header.Caption = "Túi số"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance20
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn13.CellAppearance = Appearance21
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance22
        UltraGridColumn13.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellAppearance = Appearance23
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance24
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance25
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance26
        UltraGridColumn15.Header.Caption = "Tổng khối lượng"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance27
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance28
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance29
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.Hidden = True
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance30
        UltraGridColumn19.Header.VisiblePosition = 21
        UltraGridColumn19.Hidden = True
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance31
        UltraGridColumn20.Header.VisiblePosition = 22
        UltraGridColumn20.Hidden = True
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance32
        UltraGridColumn21.Header.Caption = "Truyền khai thác"
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Hidden = True
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance33
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance34
        UltraGridColumn23.Header.Caption = "Ngày hệ thống"
        UltraGridColumn23.Header.VisiblePosition = 12
        UltraGridColumn23.Hidden = True
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance35
        UltraGridColumn24.Header.Caption = "Chốt số liệu"
        UltraGridColumn24.Header.VisiblePosition = 16
        UltraGridColumn24.Hidden = True
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance36
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance37
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance38
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance39
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance40
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance41.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance41
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgGiaoTuiDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgGiaoTuiDi1.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.CardAreaAppearance = Appearance42
        Me.dgGiaoTuiDi1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance43.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance43.ForeColor = System.Drawing.Color.Black
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance43.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderAppearance = Appearance43
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance44.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowAppearance = Appearance44
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorAppearance = Appearance45
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance46.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectedRowAppearance = Appearance46
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGiaoTuiDi1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi1.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi1.Name = "dgGiaoTuiDi1"
        Me.dgGiaoTuiDi1.Size = New System.Drawing.Size(284, 332)
        Me.dgGiaoTuiDi1.TabIndex = 18
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cb_BC37)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox4.Controls.Add(Me.cbLoai_Tui)
        Me.UltraGroupBox4.Controls.Add(Me.chkTui_F)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Dich_Vu)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox4.Controls.Add(Me.cbLoai_Chuyen_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.chkChuyen_Tiep)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox4.Controls.Add(Me.txtKhoi_Luong_Vo_Tui)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Hieu_Tui_Goi)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_Khoi_Luong)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.txtTong_So_BP)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.txtTui_So)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.txtSo_Chuyen_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.cbNgayDong)
        Me.UltraGroupBox4.Controls.Add(Me.btnThem_Du_Lieu)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance47.FontData.BoldAsString = "True"
        Appearance47.ForeColor = System.Drawing.Color.Black
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox4.HeaderAppearance = Appearance47
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(322, 456)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.Text = "Thông tin túi gói - Nhập thay thế"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cb_BC37
        '
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cb_BC37.Appearance = Appearance48
        Me.cb_BC37.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cb_BC37.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cb_BC37.DisplayLayout.Appearance = Appearance49
        UltraGridColumn30.Header.Caption = "Mã BC37"
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn31.Header.Caption = "BC gốc"
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn32.Header.Caption = "BC đích"
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn33.Header.Caption = "Ngày lập"
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cb_BC37.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance50.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cb_BC37.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.cb_BC37.DisplayMember = "Bc37_id"
        Me.cb_BC37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_BC37.LimitToList = True
        Me.cb_BC37.Location = New System.Drawing.Point(104, 112)
        Me.cb_BC37.Name = "cb_BC37"
        Me.cb_BC37.Size = New System.Drawing.Size(208, 21)
        Me.cb_BC37.TabIndex = 1
        Me.cb_BC37.ValueMember = "Bc37_Id"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.BackColor = System.Drawing.Color.White
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel13.Location = New System.Drawing.Point(8, 112)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel13.TabIndex = 45
        Me.UltraLabel13.Text = "BC37"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.BackColor = System.Drawing.Color.White
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel12.Location = New System.Drawing.Point(200, 240)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel12.TabIndex = 43
        Me.UltraLabel12.Text = "Loại túi"
        Me.UltraLabel12.Visible = False
        '
        'cbLoai_Tui
        '
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbLoai_Tui.Appearance = Appearance51
        Me.cbLoai_Tui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbLoai_Tui.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance52.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbLoai_Tui.DisplayLayout.Appearance = Appearance52
        UltraGridColumn36.Header.Caption = "Loại túi"
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37})
        UltraGridBand3.Header.Caption = "Mã Đường Thư"
        Me.cbLoai_Tui.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance53.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance53.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance53.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLoai_Tui.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.cbLoai_Tui.DisplayMember = ""
        Me.cbLoai_Tui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Tui.Location = New System.Drawing.Point(200, 216)
        Me.cbLoai_Tui.Name = "cbLoai_Tui"
        Me.cbLoai_Tui.Size = New System.Drawing.Size(64, 21)
        Me.cbLoai_Tui.TabIndex = 9
        Me.cbLoai_Tui.Text = "0"
        Me.cbLoai_Tui.ValueMember = ""
        Me.cbLoai_Tui.Visible = False
        '
        'chkTui_F
        '
        Appearance54.FontData.BoldAsString = "True"
        Me.chkTui_F.Appearance = Appearance54
        Me.chkTui_F.BackColor = System.Drawing.Color.White
        Me.chkTui_F.Location = New System.Drawing.Point(200, 280)
        Me.chkTui_F.Name = "chkTui_F"
        Me.chkTui_F.Size = New System.Drawing.Size(48, 16)
        Me.chkTui_F.TabIndex = 9
        Me.chkTui_F.Text = "Túi F"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.BackColor = System.Drawing.Color.White
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel11.Location = New System.Drawing.Point(8, 232)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel11.TabIndex = 38
        Me.UltraLabel11.Text = "Mã dv"
        '
        'cbMa_Dich_Vu
        '
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Dich_Vu.Appearance = Appearance55
        Me.cbMa_Dich_Vu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Dich_Vu.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance56.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Dich_Vu.DisplayLayout.Appearance = Appearance56
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn39.Header.VisiblePosition = 1
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn39})
        UltraGridBand4.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Dich_Vu.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance57.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance57.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance57.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Dich_Vu.DisplayLayout.Override.HeaderAppearance = Appearance57
        Me.cbMa_Dich_Vu.DisplayMember = ""
        Me.cbMa_Dich_Vu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Dich_Vu.LimitToList = True
        Me.cbMa_Dich_Vu.Location = New System.Drawing.Point(104, 232)
        Me.cbMa_Dich_Vu.Name = "cbMa_Dich_Vu"
        Me.cbMa_Dich_Vu.Size = New System.Drawing.Size(88, 21)
        Me.cbMa_Dich_Vu.TabIndex = 6
        Me.cbMa_Dich_Vu.Text = "EA"
        Me.cbMa_Dich_Vu.ValueMember = ""
        '
        'UltraLabel10
        '
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.BackColor = System.Drawing.Color.White
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel10.Location = New System.Drawing.Point(8, 208)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel10.TabIndex = 36
        Me.UltraLabel10.Text = "Loại C.Thư"
        '
        'cbLoai_Chuyen_Thu
        '
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbLoai_Chuyen_Thu.Appearance = Appearance58
        Me.cbLoai_Chuyen_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbLoai_Chuyen_Thu.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance59.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbLoai_Chuyen_Thu.DisplayLayout.Appearance = Appearance59
        UltraGridColumn40.Header.VisiblePosition = 0
        UltraGridColumn41.Header.VisiblePosition = 1
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn40, UltraGridColumn41})
        UltraGridBand5.Header.Caption = "Mã Đường Thư"
        Me.cbLoai_Chuyen_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbLoai_Chuyen_Thu.DisplayLayout.Override.HeaderAppearance = Appearance60
        Me.cbLoai_Chuyen_Thu.DisplayMember = ""
        Me.cbLoai_Chuyen_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_Chuyen_Thu.LimitToList = True
        Me.cbLoai_Chuyen_Thu.Location = New System.Drawing.Point(104, 208)
        Me.cbLoai_Chuyen_Thu.Name = "cbLoai_Chuyen_Thu"
        Me.cbLoai_Chuyen_Thu.Size = New System.Drawing.Size(88, 21)
        Me.cbLoai_Chuyen_Thu.TabIndex = 5
        Me.cbLoai_Chuyen_Thu.Text = "A"
        Me.cbLoai_Chuyen_Thu.ValueMember = ""
        '
        'chkChuyen_Tiep
        '
        Appearance61.FontData.BoldAsString = "True"
        Me.chkChuyen_Tiep.Appearance = Appearance61
        Me.chkChuyen_Tiep.BackColor = System.Drawing.Color.White
        Me.chkChuyen_Tiep.Location = New System.Drawing.Point(104, 88)
        Me.chkChuyen_Tiep.Name = "chkChuyen_Tiep"
        Me.chkChuyen_Tiep.Size = New System.Drawing.Size(176, 16)
        Me.chkChuyen_Tiep.TabIndex = 34
        Me.chkChuyen_Tiep.Text = "Là chuyển tiếp"
        Me.chkChuyen_Tiep.Visible = False
        '
        'UltraLabel8
        '
        Appearance62.FontData.BoldAsString = "True"
        Me.UltraLabel8.Appearance = Appearance62
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.BackColor = System.Drawing.Color.White
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel8.Location = New System.Drawing.Point(24, 24)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(181, 21)
        Me.UltraLabel8.TabIndex = 31
        Me.UltraLabel8.Text = "Mã vạch số hiệu túi gói"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.BackColor = System.Drawing.Color.White
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel7.Location = New System.Drawing.Point(8, 352)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel7.TabIndex = 30
        Me.UltraLabel7.Text = "K.Lượng vỏ túi"
        '
        'txtKhoi_Luong_Vo_Tui
        '
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtKhoi_Luong_Vo_Tui.Appearance = Appearance63
        Me.txtKhoi_Luong_Vo_Tui.Location = New System.Drawing.Point(104, 352)
        Me.txtKhoi_Luong_Vo_Tui.Name = "txtKhoi_Luong_Vo_Tui"
        Me.txtKhoi_Luong_Vo_Tui.Size = New System.Drawing.Size(88, 21)
        Me.txtKhoi_Luong_Vo_Tui.TabIndex = 12
        Me.txtKhoi_Luong_Vo_Tui.Text = "0"
        '
        'txtSo_Hieu_Tui_Goi
        '
        Appearance64.BackColor = System.Drawing.Color.White
        Appearance64.ForeColor = System.Drawing.Color.Green
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance64.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtSo_Hieu_Tui_Goi.Appearance = Appearance64
        Me.txtSo_Hieu_Tui_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Hieu_Tui_Goi.Location = New System.Drawing.Point(8, 48)
        Me.txtSo_Hieu_Tui_Goi.Multiline = True
        Me.txtSo_Hieu_Tui_Goi.Name = "txtSo_Hieu_Tui_Goi"
        Me.txtSo_Hieu_Tui_Goi.Size = New System.Drawing.Size(304, 40)
        Me.txtSo_Hieu_Tui_Goi.TabIndex = 0
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.BackColor = System.Drawing.Color.White
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel6.Location = New System.Drawing.Point(8, 184)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel6.TabIndex = 28
        Me.UltraLabel6.Text = "Bưu cục nhận"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.BackColor = System.Drawing.Color.White
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel5.Location = New System.Drawing.Point(8, 160)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel5.TabIndex = 27
        Me.UltraLabel5.Text = "Bưu cục gửi"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.BackColor = System.Drawing.Color.White
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 328)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel4.TabIndex = 26
        Me.UltraLabel4.Text = "Tổng KL(gram)"
        '
        'txtTong_Khoi_Luong
        '
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_Khoi_Luong.Appearance = Appearance65
        Me.txtTong_Khoi_Luong.Location = New System.Drawing.Point(104, 328)
        Me.txtTong_Khoi_Luong.Name = "txtTong_Khoi_Luong"
        Me.txtTong_Khoi_Luong.Size = New System.Drawing.Size(88, 21)
        Me.txtTong_Khoi_Luong.TabIndex = 11
        Me.txtTong_Khoi_Luong.Text = "0"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.BackColor = System.Drawing.Color.White
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 304)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel3.TabIndex = 24
        Me.UltraLabel3.Text = "Tổng số BP"
        '
        'txtTong_So_BP
        '
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So_BP.Appearance = Appearance66
        Me.txtTong_So_BP.Location = New System.Drawing.Point(104, 304)
        Me.txtTong_So_BP.Name = "txtTong_So_BP"
        Me.txtTong_So_BP.Size = New System.Drawing.Size(88, 21)
        Me.txtTong_So_BP.TabIndex = 10
        Me.txtTong_So_BP.Text = "0"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.BackColor = System.Drawing.Color.White
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel2.Location = New System.Drawing.Point(8, 280)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel2.TabIndex = 22
        Me.UltraLabel2.Text = "Túi số"
        '
        'txtTui_So
        '
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTui_So.Appearance = Appearance67
        Me.txtTui_So.Location = New System.Drawing.Point(104, 280)
        Me.txtTui_So.Name = "txtTui_So"
        Me.txtTui_So.Size = New System.Drawing.Size(88, 21)
        Me.txtTui_So.TabIndex = 8
        Me.txtTui_So.Text = "0"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel1.Location = New System.Drawing.Point(8, 256)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel1.TabIndex = 20
        Me.UltraLabel1.Text = "Số chuyến thư"
        '
        'txtSo_Chuyen_Thu
        '
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtSo_Chuyen_Thu.Appearance = Appearance68
        Me.txtSo_Chuyen_Thu.Location = New System.Drawing.Point(104, 256)
        Me.txtSo_Chuyen_Thu.Name = "txtSo_Chuyen_Thu"
        Me.txtSo_Chuyen_Thu.Size = New System.Drawing.Size(88, 21)
        Me.txtSo_Chuyen_Thu.TabIndex = 7
        Me.txtSo_Chuyen_Thu.Text = "0"
        '
        'cbMa_Bc_Nhan
        '
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Nhan.Appearance = Appearance69
        Me.cbMa_Bc_Nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance70.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Nhan.DisplayLayout.Appearance = Appearance70
        UltraGridColumn42.Header.Caption = "Mã BC"
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn43.Header.Caption = "Tên BC"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        UltraGridBand6.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Nhan.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance71.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance71.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance71.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Nhan.DisplayLayout.Override.HeaderAppearance = Appearance71
        Me.cbMa_Bc_Nhan.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Nhan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Nhan.Location = New System.Drawing.Point(104, 184)
        Me.cbMa_Bc_Nhan.Name = "cbMa_Bc_Nhan"
        Me.cbMa_Bc_Nhan.Size = New System.Drawing.Size(88, 21)
        Me.cbMa_Bc_Nhan.TabIndex = 4
        Me.cbMa_Bc_Nhan.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'cbMa_Bc_Gui
        '
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Gui.Appearance = Appearance72
        Me.cbMa_Bc_Gui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Bc_Gui.Cursor = System.Windows.Forms.Cursors.IBeam
        Appearance73.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Gui.DisplayLayout.Appearance = Appearance73
        UltraGridColumn45.Header.Caption = "Mã BC"
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn46.Header.Caption = "Mã tỉnh"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn47.Header.Caption = "Tên BC"
        UltraGridColumn47.Header.VisiblePosition = 1
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46, UltraGridColumn47})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Gui.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance74.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance74.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance74.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Gui.DisplayLayout.Override.HeaderAppearance = Appearance74
        Me.cbMa_Bc_Gui.DisplayMember = "Ma_Bc"
        Me.cbMa_Bc_Gui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Gui.Location = New System.Drawing.Point(104, 160)
        Me.cbMa_Bc_Gui.Name = "cbMa_Bc_Gui"
        Me.cbMa_Bc_Gui.Size = New System.Drawing.Size(88, 21)
        Me.cbMa_Bc_Gui.TabIndex = 3
        Me.cbMa_Bc_Gui.ValueMember = "Ma_Bc"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(104, 136)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(88, 21)
        Me.cbNgayDong.TabIndex = 2
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'btnThem_Du_Lieu
        '
        Me.btnThem_Du_Lieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem_Du_Lieu.Location = New System.Drawing.Point(24, 400)
        Me.btnThem_Du_Lieu.Name = "btnThem_Du_Lieu"
        Me.btnThem_Du_Lieu.Size = New System.Drawing.Size(272, 40)
        Me.btnThem_Du_Lieu.TabIndex = 13
        Me.btnThem_Du_Lieu.Text = "Chấp nhận"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.BackColor = System.Drawing.Color.White
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel9.Location = New System.Drawing.Point(8, 136)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel9.TabIndex = 16
        Me.UltraLabel9.Text = "Ngày nhận"
        '
        'FrmNhap_Thay_The_E2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(322, 456)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmNhap_Thay_The_E2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận đến - Nhập thay thế túi gói"
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.cb_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_Tui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Dich_Vu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKhoi_Luong_Vo_Tui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Hieu_Tui_Goi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_Khoi_Luong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So_BP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTui_So, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Chuyen_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myMa_Bc_Khai_Thac_Chi_Tiet As New Ma_Bc_Khai_Thac_Chi_Tiet
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
    Dim myQLTGND_CHANG_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet
    'các biến chứa thông tin tồn tại sẵn có của túi gói được tìm thấy
    'Dim myId_Tuyen_VC As Integer
    'Dim myMa_Bc_Gui As Integer
    'Dim myMa_Bc_Nhan As Integer
    'Dim myBC37_ID As String
    'Dim myId_Duong_Thu As String
    'Dim myId_Chuyen_Thu As String
    'Dim mySo_Chuyen_Thu As Integer
    'Dim myNgay_Dong As Integer
    'biến public
    Dim isFind As Boolean = False
    Public chuoi_bc37_id As String
    Public id_tui_thu As String
#End Region
    Private Sub Load_Loai_Chuyen_Thu()
        Dim myLoaiChuyenThu As New DataTable("tblLoaiChuyenThu")
        Dim mycolwork As DataColumn = New DataColumn("Loai_CT", GetType(String))
        myLoaiChuyenThu.Columns.Add(mycolwork)
        mycolwork = New DataColumn("Ten_CT", GetType(String))
        myLoaiChuyenThu.Columns.Add(mycolwork)
        Dim myRow = myLoaiChuyenThu.NewRow()
        myRow("Loai_CT") = "A"
        myRow("Ten_CT") = "Đường bộ"
        myLoaiChuyenThu.Rows.Add(myRow)
        myRow = myLoaiChuyenThu.NewRow()
        myRow("Loai_CT") = "B"
        myRow("Ten_CT") = "Đường bay"
        myLoaiChuyenThu.Rows.Add(myRow)
        myRow = myLoaiChuyenThu.NewRow()
        myRow("Loai_CT") = "C"
        myRow("Ten_CT") = "SAL"
        myLoaiChuyenThu.Rows.Add(myRow)
        cbLoai_Chuyen_Thu.DataSource = myLoaiChuyenThu
        cbLoai_Chuyen_Thu.ValueMember = "Loai_CT"
        cbLoai_Chuyen_Thu.DisplayMember = "Loai_CT"
        cbLoai_Chuyen_Thu.DisplayLayout.Bands(0).Columns("Loai_CT").Header.Caption = "Mã"
        cbLoai_Chuyen_Thu.DisplayLayout.Bands(0).Columns("Ten_CT").Header.Caption = "Tên"
        cbLoai_Chuyen_Thu.DataBind()
    End Sub
    Private Sub Load_Loai_Tui()
        Dim myLoaiTui As New DataTable("tblLoaiTuiThu")
        Dim mycolwork As DataColumn = New DataColumn("Loai_Tui", GetType(String))
        myLoaiTui.Columns.Add(mycolwork)
        mycolwork = New DataColumn("Ten_Loai_Tui", GetType(String))
        myLoaiTui.Columns.Add(mycolwork)
        Dim myRow = myLoaiTui.NewRow()
        myRow("Loai_Tui") = "0"
        myRow("Ten_Loai_Tui") = "Túi thường"
        myLoaiTui.Rows.Add(myRow)
        myRow = myLoaiTui.NewRow()
        myRow("Loai_Tui") = "1"
        myRow("Ten_Loai_Tui") = "Túi đảm bảo hay ghi số"
        myLoaiTui.Rows.Add(myRow)
        
        cbLoai_Tui.DataSource = myLoaiTui
        cbLoai_Tui.ValueMember = "Loai_Tui"
        cbLoai_Tui.DisplayMember = "Loai_Tui"
        cbLoai_Tui.DisplayLayout.Bands(0).Columns("Loai_Tui").Header.Caption = "Mã"
        cbLoai_Tui.DisplayLayout.Bands(0).Columns("Ten_Loai_Tui").Header.Caption = "Tên"
        cbLoai_Tui.DataBind()
    End Sub
    Private Sub Ma_Dich_Vu()
        Dim myMaDichVu As New DataTable("tblMaDichVu")
        Dim mycolwork As DataColumn = New DataColumn("Ma_Dich_Vu", GetType(String))
        myMaDichVu.Columns.Add(mycolwork)
        mycolwork = New DataColumn("Ten_Dich_Vu", GetType(String))
        myMaDichVu.Columns.Add(mycolwork)
        Dim myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "CA"
        myRow("Ten_Dich_Vu") = "Túi bưu kiện"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "CB"
        myRow("Ten_Dich_Vu") = "Túi bưu kiện đi ngoài"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UA"
        myRow("Ten_Dich_Vu") = "Túi ghi số"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UB"
        myRow("Ten_Dich_Vu") = "Túi thường"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UC"
        myRow("Ten_Dich_Vu") = "Túi ghi số COD"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UD"
        myRow("Ten_Dich_Vu") = "Túi ghi số khai giá"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UE"
        myRow("Ten_Dich_Vu") = "Túi CMND"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UF"
        myRow("Ten_Dich_Vu") = "Túi cấp đổi hộ chiếu"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UG"
        myRow("Ten_Dich_Vu") = "Túi WMG"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "UH"
        myRow("Ten_Dich_Vu") = "Túi HSXT"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "EA"
        myRow("Ten_Dich_Vu") = "Túi EMS"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "KA"
        myRow("Ten_Dich_Vu") = "Túi KT1"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "PA"
        myRow("Ten_Dich_Vu") = "Túi phát hành báo chí"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "BA"
        myRow("Ten_Dich_Vu") = "Túi bưu chính ủy thác"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "BB"
        myRow("Ten_Dich_Vu") = "Túi bưu chính ủy thác đi ngoài"
        myMaDichVu.Rows.Add(myRow)

        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "VA"
        myRow("Ten_Dich_Vu") = "Túi VNQuickpost"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "DA"
        myRow("Ten_Dich_Vu") = "Túi DHL"
        myMaDichVu.Rows.Add(myRow)
        myRow = myMaDichVu.NewRow()
        myRow("Ma_Dich_Vu") = "SA"
        myRow("Ten_Dich_Vu") = "Túi UPS"
        myMaDichVu.Rows.Add(myRow)

        cbMa_Dich_Vu.DataSource = myMaDichVu
        cbMa_Dich_Vu.ValueMember = "Ma_Dich_Vu"
        cbMa_Dich_Vu.DisplayMember = "Ma_Dich_Vu"
        cbMa_Dich_Vu.DisplayLayout.Bands(0).Columns("Ma_Dich_Vu").Header.Caption = "Mã"
        cbMa_Dich_Vu.DisplayLayout.Bands(0).Columns("Ten_Dich_Vu").Header.Caption = "Tên"
        cbMa_Dich_Vu.DataBind()
    End Sub
    Private Sub FrmNhap_Thay_The_E2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Loai_Chuyen_Thu()
        Load_Loai_Tui()
        Ma_Dich_Vu()
        Load_BC37()
        cbLoai_Tui.Value = GLoai_Tui
        cbNgayDong.Value = Today
        Load_Ma_Buu_Cuc()
        txtSo_Hieu_Tui_Goi.Text = id_tui_thu
        txtSo_Hieu_Tui_Goi_Validated(txtSo_Hieu_Tui_Goi, Nothing)

        Me.ActiveControl = Me.txtSo_Hieu_Tui_Goi
        txtSo_Hieu_Tui_Goi.Focus()
        'load combo bc37
    End Sub
    Private Sub Load_BC37()
        Dim myBC37Data As DataTable
        myBC37Data = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Danh_Sach_Theo_Danh_Sach_BC37_ID_DEN(chuoi_bc37_id, GBuu_Cuc_Khai_Thac).Tables(0)
        If (Not myBC37Data Is Nothing And myBC37Data.Rows.Count > 0) Then
            cb_BC37.DataSource = myBC37Data
            cb_BC37.DisplayMember = "BC37_ID"
            cb_BC37.ValueMember = "BC37_ID"
            cb_BC37.DataBind()
            If myBC37Data.Rows.Count = 1 Then
                cb_BC37.SelectedRow = cb_BC37.Rows(0)
            End If
        End If
    End Sub
    Private Sub GanGiaTriControls(ByVal BC37_ID As String, ByVal Ngay_Dong As Integer, ByVal Ma_BC_Gui As String, ByVal Ma_BC_Nhan As String, ByVal Loai_Chuyen_Thu As String, ByVal Ma_Dich_Vu As String, ByVal So_Chuyen_Thu As Integer, ByVal Tui_So As Integer, ByVal Tui_F As Boolean, ByVal Loai_Tui As Integer, ByVal Tong_So_BP As Integer, ByVal Tong_Khoi_Luong As Integer, ByVal Khoi_Luong_Vo_Tui As Integer)
        cb_BC37.Value = BC37_ID
        cbNgayDong.Value = Ham_Dung_Chung.ConvertIntToDate(Ngay_Dong)
        cbMa_Bc_Gui.Value = Ma_BC_Gui
        cbMa_Bc_Nhan.Value = Ma_BC_Nhan
        cbLoai_Chuyen_Thu.Value = Loai_Chuyen_Thu
        cbMa_Dich_Vu.Value = Ma_Dich_Vu
        txtSo_Chuyen_Thu.Text = So_Chuyen_Thu.ToString()
        txtTui_So.Text = Tui_So.ToString()
        chkTui_F.Checked = Tui_F
        txtTong_So_BP.Text = Tong_So_BP.ToString()
        txtTong_Khoi_Luong.Text = Tong_Khoi_Luong.ToString()
        txtKhoi_Luong_Vo_Tui.Text = Khoi_Luong_Vo_Tui.ToString()
        cbLoai_Tui.Value = Loai_Tui
    End Sub
    Private Sub Load_GiaoTuiDi(ByVal BC37_ID As String)
        dgGiaoTuiDi1.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den(BC37_ID, GBuu_Cuc_Khai_Thac).Tables(0)
        dgGiaoTuiDi1.DataBind()
    End Sub

    Private Sub Load_Ma_Buu_Cuc()
        Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
        Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
        'cbMa_Bc_Gui.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen(cb_BC37.SelectedRow.Cells("MAIL_ROUTE_ID").Value.ToString()).Tables(0)
        Dim myDataBC As DataTable
        myDataBC = myDanh_Muc_BC.Danh_Sach_Rut_Gon().Tables(0)
        cbMa_Bc_Gui.DataSource = myDataBC
        cbMa_Bc_Gui.DataBind()
        'If cbMa_Bc_Gui.Rows.Count > 0 Then
        'cbMa_Bc_Gui.Value = myMa_Bc_Gui.ToString
        'End If
        cbMa_Bc_Nhan.DataSource = myMa_Bc_Khai_Thac.Danh_Sach.Tables(0)
        cbMa_Bc_Nhan.DataBind()
    End Sub

    Private Sub FrmNhap_Thay_The_E2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
                Case Keys.F1

                Case Keys.F2

                Case Keys.Escape

            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtSo_Chuyen_Thu_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Chuyen_Thu.Validated
        If IsNumeric(txtSo_Chuyen_Thu.Text) = False Then
            txtSo_Chuyen_Thu.Text = 0
        End If
    End Sub

    Private Sub txtTui_So_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTui_So.Validated
        If IsNumeric(txtTui_So.Text) = False Then
            txtTui_So.Text = 0
        End If
    End Sub

    Private Sub txtTong_So_BP_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTong_So_BP.ValueChanged
        If IsNumeric(txtTong_So_BP.Text) = False Then
            txtTong_So_BP.Text = 0
        End If
    End Sub

    Private Sub txtTong_Khoi_Luong_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTong_Khoi_Luong.Validated
        If IsNumeric(txtTong_Khoi_Luong.Text) = False Then
            txtTong_Khoi_Luong.Text = 0
        End If
    End Sub

    Private Sub btnThem_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem_Du_Lieu.Click

        'Kiểm tra thông tin nhập vào
        If cbMa_Bc_Gui.Value Is Nothing Then
            If (cbMa_Bc_Gui.Text <> "") Then
                If (MessageBox.Show("Mã BC bạn chọn không có trong danh mục mã bưu cục bạn có muốn chọn mã này?" & vbNewLine & " Chọn YES để đồng ý hoặc NO để chọn lại mã BC khác", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                    cbMa_Bc_Gui.Value = cbMa_Bc_Gui.Text
                Else
                    cbMa_Bc_Gui.Focus()
                    Exit Sub
                End If
            Else
                CMessageBox.Show("Bạn chưa chọn bưu cục nhận")
                cbMa_Bc_Gui.Focus()
                Exit Sub
            End If
        End If
        If Not IsNumeric(cbMa_Bc_Gui.Value) Then
            MessageBox.Show("Mã bưu cục phải là một số gồm 6 chữ số dạng XXXXXX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If cbMa_Bc_Gui.Value.ToString.Trim.Length <> 6 Then
            MessageBox.Show("Mã bưu cục phải là một số gồm 6 chữ số dạng XXXXXX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Exit Sub
        End If
        If cbMa_Bc_Nhan.Value Is Nothing Then
            If (cbMa_Bc_Nhan.Text <> "") Then
                If (MessageBox.Show("Mã BC bạn chọn không có trong danh mục mã bưu cục bạn có muốn chọn mã này?" & vbNewLine & "Chọn YES để đồng ý hoặc NO để chọn lại mã BC khác", "Canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                    cbMa_Bc_Nhan.Value = cbMa_Bc_Nhan.Text
                Else
                    cbMa_Bc_Nhan.Focus()
                    Exit Sub
                End If
            Else
                CMessageBox.Show("Bạn chưa chọn bưu cục nhận")
                cbMa_Bc_Nhan.Focus()
                Exit Sub
            End If
        End If
        If Not IsNumeric(cbMa_Bc_Nhan.Value) Then
            MessageBox.Show("Mã bưu cục phải là một số gồm 6 chữ số dạng XXXXXX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbMa_Bc_Nhan.Focus()
            Exit Sub
        End If
        If cbMa_Bc_Nhan.Value.ToString.Trim.Length <> 6 Then
            MessageBox.Show("Mã bưu cục phải là một số gồm 6 chữ số dạng XXXXXX", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbMa_Bc_Nhan.Focus()
            Exit Sub
        End If
        If (cbMa_Bc_Nhan.Value.ToString.Trim = cbMa_Bc_Gui.Value.ToString.Trim) Then
            MessageBox.Show("Mã bưu cục gửi không được bằng mã bưu cục nhận", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cb_BC37.Value Is Nothing Then
            CMessageBox.Show("Bạn chưa chọn BC 37 chứa túi gói")
            cb_BC37.Focus()
            Exit Sub
        End If
        If cbMa_Dich_Vu.Value Is Nothing Then
            If (cbMa_Dich_Vu.Text <> "") Then
                cbMa_Dich_Vu.Value = cbMa_Dich_Vu.Text
            Else
                CMessageBox.Show("Bạn chưa chọn bưu cục nhận")
                cbMa_Dich_Vu.Focus()
                Exit Sub
            End If
        End If
        If txtSo_Chuyen_Thu.Text.Length = 0 Or txtSo_Chuyen_Thu.Text = "0" Then
            CMessageBox.Show("Bạn chưa nhập số chuyến thư")
            txtSo_Chuyen_Thu.Focus()
            Exit Sub
        ElseIf IsNumeric(txtSo_Chuyen_Thu.Text) = False Then
            CMessageBox.Show("Số chuyến thư phải là kiểu số nguyên, xin hãy kiểm tra lại")
            txtSo_Chuyen_Thu.Focus()
            Exit Sub
        End If
        If txtTui_So.Text.Length = 0 Or txtTui_So.Text = "0" Then
            CMessageBox.Show("Bạn chưa nhập tổng số túi")
            txtTui_So.Focus()
            Exit Sub
        ElseIf IsNumeric(txtTui_So.Text) = False Then
            CMessageBox.Show("Túi số phải là kiểu số nguyên, xin hãy kiểm tra lại")
            txtTui_So.Focus()
            Exit Sub
        End If
        If txtTong_So_BP.Text.Length = 0 Or txtTong_So_BP.Text = "0" Then
            CMessageBox.Show("Bạn chưa nhập tổng số bưu phẩm")
            txtTong_So_BP.Focus()
            Exit Sub
        ElseIf IsNumeric(txtTong_So_BP.Text) = False Then
            CMessageBox.Show("Tổng số bưu phẩm phải là kiểu số nguyên, xin hãy kiểm tra lại")
            txtTong_So_BP.Focus()
            Exit Sub
        End If
        If txtTong_Khoi_Luong.Text.Length = 0 Or txtTong_Khoi_Luong.Text = "0" Then
            CMessageBox.Show("Bạn chưa nhập tổng khối lượng bưu phẩm")
            txtTong_Khoi_Luong.Focus()
            Exit Sub
        ElseIf IsNumeric(txtTong_Khoi_Luong.Text) = False Then
            CMessageBox.Show("Tổng khối lượng phải là kiểu số nguyên, xin hãy kiểm tra lại")
            txtTong_Khoi_Luong.Focus()
            Exit Sub
        End If
        If txtKhoi_Luong_Vo_Tui.Text.Length = 0 Then
            CMessageBox.Show("Bạn chưa nhập tổng khối lượng bưu phẩm")
            txtKhoi_Luong_Vo_Tui.Focus()
            Exit Sub
        ElseIf IsNumeric(txtKhoi_Luong_Vo_Tui.Text) = False Then
            CMessageBox.Show("Khối lượng vỏ túi phải là kiểu số nguyên, xin hãy kiểm tra lại")
            txtKhoi_Luong_Vo_Tui.Focus()
            Exit Sub
        End If

        Dim mySo_Chuyen_Thu As Integer = CInt(txtSo_Chuyen_Thu.Text)

        Dim myNgay_Dong As Integer = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)

        Dim myMa_Bc_Nhan As Integer = CInt(cbMa_Bc_Nhan.Value)

        Dim myMa_Bc As Integer = CInt(cbMa_Bc_Gui.Value)
        Dim myId_Duong_Thu As String = CreateId_Duong_Thu(myMa_Bc, myMa_Bc_Nhan)
        Dim myTui_So As Integer = CInt(txtTui_So.Text)
        Dim myTui_F As Boolean = chkTui_F.Checked
        Dim myKhoi_Luong_BP As Integer = CInt(txtTong_Khoi_Luong.Text)
        Dim myKhoi_Luong_Vo_Tui As Integer = CInt(txtKhoi_Luong_Vo_Tui.Text)
        Dim myTong_So_BP As Integer = CInt(txtTong_So_BP.Text)
        Dim myLoai_Chuyen_Thu As String = CStr(IIf(Not cbLoai_Chuyen_Thu.Value Is Nothing, cbLoai_Chuyen_Thu.Value, ""))
        Dim myId_Chuyen_Thu As String = CreateId_Chuyen_Thu(myId_Duong_Thu, mySo_Chuyen_Thu, myNgay_Dong, GLoai_Chuyen_Thu_Trong_Nuoc)

        Dim myId_E2 As String = CreateId_E2(myId_Chuyen_Thu, myTui_So)
        Dim myNam_Chuyen_Thu As String = myNgay_Dong.ToString().Substring(3, 1)
        Dim my_Ma_Dich_Vu As String = CStr(IIf(Not cbMa_Dich_Vu.Value Is Nothing, cbMa_Dich_Vu.Value, cbMa_Dich_Vu.Text.Trim()))
        Dim strBC37 As String() = {cb_BC37.Value.ToString()}
        Dim strKQ As String = CheckBC37PostBag(strBC37, myMa_Bc_Nhan)
        Dim myLoai_Tui As Boolean = CBool(IIf(Not cbLoai_Tui.Value Is Nothing, cbLoai_Tui.Value, cbLoai_Tui.Text))
        If (strKQ = "") Then
            If (MessageBox.Show("Mã bưu cục nhận trong mã E4 không khớp với mã bưu cục nhận trong BC37" & vbNewLine & "Bạn có đồng ý nhập thay thế không?" & vbNewLine & "Chọn YES để đồng ý hoặc NO để sửa lại", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                Exit Sub
            End If
        End If

        If (my_Ma_Dich_Vu.Length <> 2) Then
            MessageBox.Show("Mã dịch vụ không hợp lệ bạn hãy nhập lại mã dịch vụ", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbMa_Dich_Vu.Focus()
            Exit Sub
        End If
        If (myLoai_Chuyen_Thu.Length <> 1) Then
            MessageBox.Show("Loại chuyến thư không hợp lệ bạn hãy nhập lại mã dịch vụ", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'Nếu không bắn mã vạch thì tự sinh ID BC37
        'If txtSo_Hieu_Tui_Goi.Text.Length = 0 Then

        Dim myBarcode As New DycryptBarCode.e4code(myMa_Bc, myMa_Bc_Nhan, myLoai_Chuyen_Thu, my_Ma_Dich_Vu, myNam_Chuyen_Thu, mySo_Chuyen_Thu.ToString("0000"), myTui_So.ToString("000"), myTui_F, myLoai_Tui, myKhoi_Luong_BP)
        txtSo_Hieu_Tui_Goi.Text = myBarcode.GeneralE4Code()

        'txtSo_Hieu_Tui_Goi.Text = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2_New(myId_E2, myMa_Bc, myMa_Bc_Khai_Thac, myNgay_Dong, mySo_Chuyen_Thu, myTui_So, myTui_F, myKhoi_Luong_BP, myKhoi_Luong_Vo_Tui)
        'End If
        With myQLTGND_POSTBAG_DEN_Chi_Tiet
            .Chot_SL = False
            .Gio_Dong = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
            .Gio_Nhan = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
            .HH_Phat_Hanh = 0
            .HH_Phat_Tra = 0
            .Id_BC37 = cb_BC37.Value
            .Id_Ca = GId_Ca
            .Id_Duong_Thu = myId_Duong_Thu
            .Id_Tui_Thu = txtSo_Hieu_Tui_Goi.Text.Trim
            .Khoi_Luong_BP = myKhoi_Luong_BP
            .Khoi_Luong_Vo_Tui = myKhoi_Luong_Vo_Tui
            .Ma_Bc_Khai_Thac = myMa_Bc_Nhan
            .Ma_Bc = myMa_Bc
            .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
            .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
            .Ngay_Nhan = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
            .So_Chuyen_Thu = mySo_Chuyen_Thu
            .Tong_Cuoc_Chinh = 0
            .Tong_Cuoc_COD = 0
            .Tong_Cuoc_DV = 0
            .Tong_So_BP = myTong_So_BP
            .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
            .Truyen_Doi_Soat = False
            .Truyen_Khai_Thac = False
            .Tui_F = myTui_F
            .Tui_So = myTui_So
            .Id_Chuyen_Thu = myId_Chuyen_Thu
            .Id_E2 = myId_E2
            .IS_TRANSITION = Kiem_Tra_Qua_Giang(CInt(cbMa_Bc_Nhan.Value), CInt(cbMa_Bc_Gui.Value))
        End With

        myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Them(myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_E2, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Duong_Thu, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Chuyen_Thu, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Ca, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Dong, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Nhan, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.So_Chuyen_Thu, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_So, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_F, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_So_BP, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_Vo_Tui, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_BP, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_COD, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_DV, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_Chinh, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Hanh, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Tra, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Khai_Thac, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Doi_Soat, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_He_Thong, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Chot_SL, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Tui_Thu, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_BC37, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.Trang_Thai, _
            myQLTGND_POSTBAG_DEN_Chi_Tiet.IS_TRANSITION)

        'Load data
        'Load_GiaoTuiDi(cb_BC37.Value)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub EnableControls(ByVal misbool As Boolean)
        cb_BC37.Enabled = misbool
        cbMa_Bc_Gui.Enabled = misbool
        cbMa_Bc_Nhan.Value = misbool
        cbMa_Dich_Vu.Value = misbool
        cbLoai_Chuyen_Thu.Enabled = misbool
        txtTui_So.Enabled = misbool
        txtSo_Chuyen_Thu.Enabled = misbool
        chkTui_F.Enabled = misbool
    End Sub
    Private Sub txtSo_Hieu_Tui_Goi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_Tui_Goi.Validated
        'Co ma e4 de nhap thay the
        If (txtSo_Hieu_Tui_Goi.Text.Trim() <> "") Then
            Dim myE4Code As New DycryptBarCode.e4code(txtSo_Hieu_Tui_Goi.Text.Trim())
            If (myE4Code.MaBuuCucGui = "") Then 'mã e4 không hợp lệ
                MessageBox.Show("Mã vạch túi không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cbLoai_Chuyen_Thu.Value = GLoai_Chuyen_Thu
                cbMa_Dich_Vu.Value = GLoai_Dich_Vu
                txtSo_Hieu_Tui_Goi.Focus()
                txtSo_Hieu_Tui_Goi.SelectAll()
                Exit Sub
            Else
                'mã e4 hợp lệ, tim trong QLTGND_POSTBAG_DEN
                Dim myData As DataTable = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu(txtSo_Hieu_Tui_Goi.Text.Trim(), GBuu_Cuc_Khai_Thac).Tables(0)
                If (myData.Rows.Count > 0) Then 'tìm thấy mã e4 tồn tại trong database
                    'mã e4 tìm thấy phù hợp với 1 bc37 trong số bc37 đang chọn 
                    If (chuoi_bc37_id.IndexOf(myData.Rows(0)("Id_BC37").ToString()) >= 0) Then
                        'Lay thong tin tui tim duoc vao bien
                        Dim mQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
                        mQLTGND_POSTBAG_DEN_Chi_Tiet = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Lay(myData.Rows(0).Item("Id_E2"))
                        'Doi trang thai
                        mQLTGND_POSTBAG_DEN_Chi_Tiet.Trang_Thai = gTrang_Thai_1
                        'Cap nhat lai trang thai vao bang
                        myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Them( _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_E2, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Duong_Thu, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Chuyen_Thu, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Ca, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Dong, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Nhan, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.So_Chuyen_Thu, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_So, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_F, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_So_BP, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_Vo_Tui, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_BP, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_COD, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_DV, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_Cuoc_Chinh, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Hanh, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.HH_Phat_Tra, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Khai_Thac, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Truyen_Doi_Soat, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_He_Thong, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Chot_SL, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Tui_Thu, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Id_BC37, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.Trang_Thai, _
               mQLTGND_POSTBAG_DEN_Chi_Tiet.IS_TRANSITION)


                        'btnThem_Du_Lieu_Click(btnThem_Du_Lieu, Nothing)
                        Me.Close()
                        Me.Dispose()
                        Exit Sub
                    Else ' không phù hợp với danh sách bc37 đang chọn
                        MessageBox.Show("Túi này không thuộc những BC37 đang chọn xác nhận đến" & vbNewLine & "Bạn hãy nhập lại chính xác mã E4", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtSo_Hieu_Tui_Goi.Focus()
                        txtSo_Hieu_Tui_Goi.SelectAll()
                        Exit Sub
                    End If
                Else
                    'Xac nhan tui va bc37 tuong doi hop li voi nhau
                    Dim strBC37(cb_BC37.Rows.Count - 1) As String
                    For i As Integer = 0 To cb_BC37.Rows.Count - 1
                        strBC37(i) = cb_BC37.Rows(i).Cells("BC37_ID").Value.ToString()
                    Next
                    Dim strKQ = CheckBC37PostBag(strBC37, myE4Code.MaBuuCucNhan)

                    'khong tim thay 
                    Dim intLoaiTui As Integer = CInt(IIf(myE4Code.LoaiTui = True, 1, 0))
                    GanGiaTriControls(strKQ, Ham_Dung_Chung.ConvertDateToInt(Date.Now), myE4Code.MaBuuCucGui, myE4Code.MaBuuCucNhan, myE4Code.LoaiChuyenThu, myE4Code.MaDichVu, CInt(myE4Code.SoHieuChuyenThu), CInt(myE4Code.TuiSo), myE4Code.TuiF, intLoaiTui, 0, 0, 0)
                End If
            End If
        Else 'không truyền mã e4 sang nhập thay thế
            cbLoai_Chuyen_Thu.Value = GLoai_Chuyen_Thu
            cbMa_Dich_Vu.Value = GLoai_Dich_Vu
            cbNgayDong.Focus()
        End If
    End Sub

    Private Sub txtSo_Hieu_Tui_Goi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_Tui_Goi.ValueChanged

    End Sub

    Private Sub FrmNhap_Thay_The_E2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub

    Private Sub cb_BC37_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_BC37.ValueChanged
        If Not (cb_BC37.SelectedRow Is Nothing) Then
            Dim myHamDungChung As New Ham_Dung_Chung
            cbNgayDong.Value = myHamDungChung.ConvertIntToDate(Integer.Parse(cb_BC37.SelectedRow.Cells("Ngay_Lap").Value.ToString()))
            If cbMa_Bc_Gui.Value Is Nothing Then
                cbMa_Bc_Gui.Value = cb_BC37.SelectedRow.Cells("BC37_ID").Value.ToString().Substring(0, 6)
            End If
            If cbMa_Bc_Nhan.Value Is Nothing Then
                cbMa_Bc_Nhan.Value = cb_BC37.SelectedRow.Cells("BC37_ID").Value.ToString().Substring(6, 6)
            End If
        Else
            cbNgayDong.Value = Nothing
        End If
    End Sub

    'Private Function Cap_Nhat_Tui_Tim_Thay(ByVal mQLTGND_POSTBAG_DEN_Chi_Tiet As QLTGND_POSTBAG_DEN_Chi_Tiet) As Boolean
    '    Try
    '        QLTGND()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function



End Class

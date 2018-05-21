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
Public Class FrmIn_BC37_Tap_Trung
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
    Friend WithEvents chkALL As System.Windows.Forms.CheckBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cbDot_Giao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CbTruc_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgGiaoTuiDi1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkChon_Tat1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chkChon_Tat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents gbQua_Giang As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnDong_Lai As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dgGiaoTuiDi_QuaGiang As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtSo_Hieu_Tui_Goi As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optLua_Chon_Code As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents dgGiaoTuiDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblSo_Hieu_BC37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents gbGhep_Tui_Goi As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbChuyenThuDi1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDuongThuDi1 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbNgayDong1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnMo_Chuyen_Thu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMo_BC37 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gbTui_Goi_BC37 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents gbSo_Hieu_BC37 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkInkhidong As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtSo_Ban As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLay_Qua_Giang As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIn_Nhan_E4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThem_Tui_Goi_QG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkChon_Tat_QG As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbROAD_MAP As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblThong_Tin_Tui_Goi As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opt_Filter As Infragistics.Win.UltraWinEditors.UltraOptionSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmIn_BC37_Tap_Trung))
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Road_Map", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_1")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_2")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_1")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_2")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_EAST")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_WEST")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_NORTH")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_SOUTH")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMMENTS")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dot_Giao", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROUD_MAP_ID")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROVINCE")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Dong")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Nhan")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ChuyenThuDi", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Dong")
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Buu_Cuc_Nhan")
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.chkALL = New System.Windows.Forms.CheckBox
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnPreview = New Infragistics.Win.Misc.UltraButton
        Me.cbROAD_MAP = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtSo_Ban = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkInkhidong = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbDuongThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.btnMo_BC37 = New Infragistics.Win.Misc.UltraButton
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.cbDot_Giao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CbTruc_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.opt_Filter = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.gbTui_Goi_BC37 = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnLay_Qua_Giang = New Infragistics.Win.Misc.UltraButton
        Me.btnIn_Nhan_E4 = New Infragistics.Win.Misc.UltraButton
        Me.chkChon_Tat1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgGiaoTuiDi1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gbGhep_Tui_Goi = New Infragistics.Win.Misc.UltraGroupBox
        Me.btnMo_Chuyen_Thu = New Infragistics.Win.Misc.UltraButton
        Me.cbChuyenThuDi1 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDuongThuDi1 = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.cbNgayDong1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.chkChon_Tat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.dgGiaoTuiDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gbQua_Giang = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.optLua_Chon_Code = New Infragistics.Win.UltraWinEditors.UltraOptionSet
        Me.txtSo_Hieu_Tui_Goi = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnDong_Lai = New Infragistics.Win.Misc.UltraButton
        Me.chkChon_Tat_QG = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnThem_Tui_Goi_QG = New Infragistics.Win.Misc.UltraButton
        Me.dgGiaoTuiDi_QuaGiang = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.gbSo_Hieu_BC37 = New Infragistics.Win.Misc.UltraGroupBox
        Me.lblThong_Tin_Tui_Goi = New Infragistics.Win.Misc.UltraLabel
        Me.lblSo_Hieu_BC37 = New Infragistics.Win.Misc.UltraLabel
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.cbROAD_MAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDot_Giao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTruc_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opt_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbTui_Goi_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTui_Goi_BC37.SuspendLayout()
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbGhep_Tui_Goi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGhep_Tui_Goi.SuspendLayout()
        CType(Me.cbChuyenThuDi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuongThuDi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbQua_Giang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbQua_Giang.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.optLua_Chon_Code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Hieu_Tui_Goi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgGiaoTuiDi_QuaGiang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSo_Hieu_BC37.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkALL
        '
        Me.chkALL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkALL.Location = New System.Drawing.Point(16, 60)
        Me.chkALL.Name = "chkALL"
        Me.chkALL.Size = New System.Drawing.Size(32, 16)
        Me.chkALL.TabIndex = 23
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.btnPreview)
        Me.UltraGroupBox6.Controls.Add(Me.cbROAD_MAP)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox6.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox6.Controls.Add(Me.cbDuongThuDi)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox6.Controls.Add(Me.btnMo_BC37)
        Me.UltraGroupBox6.Controls.Add(Me.cbNgayDong)
        Me.UltraGroupBox6.Controls.Add(Me.cbDot_Giao)
        Me.UltraGroupBox6.Controls.Add(Me.CbTruc_Duong_Thu)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox6.Controls.Add(Me.opt_Filter)
        Me.UltraGroupBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.ForeColor = System.Drawing.Color.Black
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox6.HeaderAppearance = Appearance1
        Me.UltraGroupBox6.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(752, 80)
        Me.UltraGroupBox6.SupportThemes = False
        Me.UltraGroupBox6.TabIndex = 0
        Me.UltraGroupBox6.Text = "Thông tin lập số hiệu BC37"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnPreview
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Me.btnPreview.Appearance = Appearance2
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnPreview.ImageSize = New System.Drawing.Size(40, 25)
        Me.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPreview.Location = New System.Drawing.Point(592, 32)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(48, 32)
        Me.btnPreview.TabIndex = 8
        '
        'cbROAD_MAP
        '
        Me.cbROAD_MAP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbROAD_MAP.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 50
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 80
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 80
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 150
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 150
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        UltraGridBand1.Header.Caption = "Mã Đường Thư"
        Me.cbROAD_MAP.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbROAD_MAP.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.cbROAD_MAP.DisplayMember = "Id"
        Me.cbROAD_MAP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbROAD_MAP.Location = New System.Drawing.Point(336, 104)
        Me.cbROAD_MAP.Name = "cbROAD_MAP"
        Me.cbROAD_MAP.Size = New System.Drawing.Size(96, 21)
        Me.cbROAD_MAP.TabIndex = 97
        Me.cbROAD_MAP.ValueMember = "Id"
        Me.cbROAD_MAP.Visible = False
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(336, 88)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(77, 16)
        Me.UltraLabel9.TabIndex = 98
        Me.UltraLabel9.Text = "Bản đồ tuyến"
        Me.UltraLabel9.Visible = False
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraGroupBox2.Controls.Add(Me.txtSo_Ban)
        Me.UltraGroupBox2.Controls.Add(Me.Label8)
        Me.UltraGroupBox2.Controls.Add(Me.chkInkhidong)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(648, 20)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(96, 54)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 96
        '
        'txtSo_Ban
        '
        Me.txtSo_Ban.Location = New System.Drawing.Point(8, 29)
        Me.txtSo_Ban.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtSo_Ban.Name = "txtSo_Ban"
        Me.txtSo_Ban.Size = New System.Drawing.Size(40, 20)
        Me.txtSo_Ban.TabIndex = 7
        Me.txtSo_Ban.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 19)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "bản"
        '
        'chkInkhidong
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.chkInkhidong.Appearance = Appearance5
        Me.chkInkhidong.Checked = True
        Me.chkInkhidong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInkhidong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkInkhidong.Location = New System.Drawing.Point(8, 7)
        Me.chkInkhidong.Name = "chkInkhidong"
        Me.chkInkhidong.Size = New System.Drawing.Size(80, 20)
        Me.chkInkhidong.TabIndex = 6
        Me.chkInkhidong.Text = "In khi đóng"
        '
        'cbDuongThuDi
        '
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDuongThuDi.Appearance = Appearance6
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn13.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn14.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn14.Header.VisiblePosition = 1
        UltraGridColumn14.Width = 250
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn16.Header.VisiblePosition = 3
        UltraGridColumn16.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance7.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuongThuDi.DisplayLayout.Override.HeaderAppearance = Appearance7
        Me.cbDuongThuDi.DisplayMember = ""
        Me.cbDuongThuDi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi.LimitToList = True
        Me.cbDuongThuDi.Location = New System.Drawing.Point(200, 40)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(80, 21)
        Me.cbDuongThuDi.TabIndex = 1
        Me.cbDuongThuDi.ValueMember = ""
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(200, 24)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(77, 16)
        Me.UltraLabel5.TabIndex = 43
        Me.UltraLabel5.Text = "Đường thư đi"
        '
        'btnMo_BC37
        '
        Me.btnMo_BC37.Location = New System.Drawing.Point(504, 32)
        Me.btnMo_BC37.Name = "btnMo_BC37"
        Me.btnMo_BC37.Size = New System.Drawing.Size(80, 32)
        Me.btnMo_BC37.TabIndex = 4
        Me.btnMo_BC37.Text = "Tạo BC37"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(104, 40)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(88, 21)
        Me.cbNgayDong.TabIndex = 0
        Me.cbNgayDong.Value = Nothing
        '
        'cbDot_Giao
        '
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDot_Giao.Appearance = Appearance8
        Me.cbDot_Giao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDot_Giao.DisplayLayout.Appearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn17.CellAppearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance11
        UltraGridColumn17.Header.Caption = "Mã đợt giao"
        UltraGridColumn17.Header.VisiblePosition = 0
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance12
        UltraGridColumn18.Header.Caption = "Tên đợt giao"
        UltraGridColumn18.Header.VisiblePosition = 1
        UltraGridColumn18.Width = 250
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18})
        UltraGridBand3.Header.Caption = "Mã Đường Thư"
        Me.cbDot_Giao.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDot_Giao.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.cbDot_Giao.DisplayMember = ""
        Me.cbDot_Giao.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cbDot_Giao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDot_Giao.Location = New System.Drawing.Point(440, 40)
        Me.cbDot_Giao.Name = "cbDot_Giao"
        Me.cbDot_Giao.Size = New System.Drawing.Size(56, 21)
        Me.cbDot_Giao.TabIndex = 3
        Me.cbDot_Giao.ValueMember = ""
        '
        'CbTruc_Duong_Thu
        '
        Me.CbTruc_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.CbTruc_Duong_Thu.DisplayLayout.Appearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance15
        UltraGridColumn19.Header.Caption = "Mã"
        UltraGridColumn19.Header.VisiblePosition = 0
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.CellAppearance = Appearance16
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance17
        UltraGridColumn20.Header.Caption = "Mã tuyến"
        UltraGridColumn20.Header.VisiblePosition = 1
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance18
        UltraGridColumn21.Header.Caption = "Tên tuyến"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Width = 250
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance19
        UltraGridColumn22.Header.Caption = "Đợt vận chuyển"
        UltraGridColumn22.Header.VisiblePosition = 3
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance20
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Hidden = True
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance21
        UltraGridColumn24.Header.VisiblePosition = 5
        UltraGridColumn24.Hidden = True
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance22
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Hidden = True
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance23
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 12
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 13
        UltraGridColumn32.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        UltraGridBand4.Header.Caption = "Mã Đường Thư"
        Me.CbTruc_Duong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance24.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance24.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance24.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTruc_Duong_Thu.DisplayLayout.Override.HeaderAppearance = Appearance24
        Me.CbTruc_Duong_Thu.DisplayMember = "Ten_Tuyen"
        Me.CbTruc_Duong_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTruc_Duong_Thu.Location = New System.Drawing.Point(288, 40)
        Me.CbTruc_Duong_Thu.Name = "CbTruc_Duong_Thu"
        Me.CbTruc_Duong_Thu.Size = New System.Drawing.Size(144, 21)
        Me.CbTruc_Duong_Thu.TabIndex = 2
        Me.CbTruc_Duong_Thu.ValueMember = "Id_Tuyen"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(288, 24)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 16)
        Me.UltraLabel2.TabIndex = 41
        Me.UltraLabel2.Text = "Tuyến vận chuyển"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(440, 24)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 16)
        Me.UltraLabel1.TabIndex = 40
        Me.UltraLabel1.Text = "Đợt giao"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(112, 24)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel4.TabIndex = 34
        Me.UltraLabel4.Text = "Ngày đóng"
        '
        'opt_Filter
        '
        Me.opt_Filter.ItemAppearance = Appearance25
        ValueListItem1.DataValue = CType(0, Short)
        ValueListItem1.DisplayText = "Tất cả"
        ValueListItem2.DataValue = CType(1, Short)
        ValueListItem2.DisplayText = "Chưa lập"
        ValueListItem3.DataValue = CType(2, Short)
        ValueListItem3.DisplayText = "Đã lập"
        Me.opt_Filter.Items.Add(ValueListItem1)
        Me.opt_Filter.Items.Add(ValueListItem2)
        Me.opt_Filter.Items.Add(ValueListItem3)
        Me.opt_Filter.Location = New System.Drawing.Point(8, 24)
        Me.opt_Filter.Name = "opt_Filter"
        Me.opt_Filter.Size = New System.Drawing.Size(88, 48)
        Me.opt_Filter.TabIndex = 0
        '
        'gbTui_Goi_BC37
        '
        Me.gbTui_Goi_BC37.BackColor = System.Drawing.SystemColors.Control
        Me.gbTui_Goi_BC37.Controls.Add(Me.btnLay_Qua_Giang)
        Me.gbTui_Goi_BC37.Controls.Add(Me.btnIn_Nhan_E4)
        Me.gbTui_Goi_BC37.Controls.Add(Me.chkChon_Tat1)
        Me.gbTui_Goi_BC37.Controls.Add(Me.dgGiaoTuiDi1)
        Me.gbTui_Goi_BC37.ForeColor = System.Drawing.SystemColors.Control
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.ForeColor = System.Drawing.Color.Black
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        Me.gbTui_Goi_BC37.HeaderAppearance = Appearance26
        Me.gbTui_Goi_BC37.Location = New System.Drawing.Point(400, 144)
        Me.gbTui_Goi_BC37.Name = "gbTui_Goi_BC37"
        Me.gbTui_Goi_BC37.Size = New System.Drawing.Size(360, 440)
        Me.gbTui_Goi_BC37.SupportThemes = False
        Me.gbTui_Goi_BC37.TabIndex = 3
        Me.gbTui_Goi_BC37.Text = "Chi tiết túi gói trong BC37 đi"
        Me.gbTui_Goi_BC37.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnLay_Qua_Giang
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.btnLay_Qua_Giang.Appearance = Appearance27
        Me.btnLay_Qua_Giang.Location = New System.Drawing.Point(96, 21)
        Me.btnLay_Qua_Giang.Name = "btnLay_Qua_Giang"
        Me.btnLay_Qua_Giang.Size = New System.Drawing.Size(256, 40)
        Me.btnLay_Qua_Giang.TabIndex = 1
        Me.btnLay_Qua_Giang.Text = "Lấy dữ liệu quá giang túi gói"
        '
        'btnIn_Nhan_E4
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.btnIn_Nhan_E4.Appearance = Appearance28
        Me.btnIn_Nhan_E4.Location = New System.Drawing.Point(8, 21)
        Me.btnIn_Nhan_E4.Name = "btnIn_Nhan_E4"
        Me.btnIn_Nhan_E4.Size = New System.Drawing.Size(80, 40)
        Me.btnIn_Nhan_E4.TabIndex = 0
        Me.btnIn_Nhan_E4.Text = "In nhãn E4"
        '
        'chkChon_Tat1
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.chkChon_Tat1.Appearance = Appearance29
        Me.chkChon_Tat1.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat1.Checked = True
        Me.chkChon_Tat1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat1.Location = New System.Drawing.Point(6, 92)
        Me.chkChon_Tat1.Name = "chkChon_Tat1"
        Me.chkChon_Tat1.Size = New System.Drawing.Size(13, 13)
        Me.chkChon_Tat1.TabIndex = 19
        '
        'dgGiaoTuiDi1
        '
        Me.dgGiaoTuiDi1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi1.DisplayLayout.Appearance = Appearance30
        UltraGridBand5.CardSettings.ShowCaption = False
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.CellAppearance = Appearance31
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance32
        UltraGridColumn33.Header.Caption = ""
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(21, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance33
        UltraGridColumn34.Header.Caption = "Id E2"
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance34
        UltraGridColumn35.Header.Caption = "Id Đường Thư"
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance35
        UltraGridColumn36.Header.Caption = "Id Chuyến thư"
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance36
        UltraGridColumn37.Header.Caption = "Id ca"
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.CellAppearance = Appearance37
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance38
        UltraGridColumn38.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn38.Header.VisiblePosition = 5
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.CellAppearance = Appearance39
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance40
        UltraGridColumn39.Header.Caption = "Mã bưu cục"
        UltraGridColumn39.Header.VisiblePosition = 6
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance41
        UltraGridColumn40.Header.Caption = "Ngày đóng"
        UltraGridColumn40.Header.VisiblePosition = 7
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn41.Header.Appearance = Appearance42
        UltraGridColumn41.Header.VisiblePosition = 8
        UltraGridColumn41.Hidden = True
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance43
        UltraGridColumn42.Header.VisiblePosition = 9
        UltraGridColumn42.Hidden = True
        Appearance44.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance44
        UltraGridColumn43.Header.VisiblePosition = 10
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn44.CellAppearance = Appearance45
        Appearance46.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance46
        UltraGridColumn44.Header.Caption = "Túi số"
        UltraGridColumn44.Header.VisiblePosition = 11
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance47
        UltraGridColumn45.Header.VisiblePosition = 12
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn46.CellAppearance = Appearance48
        Appearance49.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance49
        UltraGridColumn46.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn46.Header.VisiblePosition = 13
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn47.CellAppearance = Appearance50
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance51
        UltraGridColumn47.Header.VisiblePosition = 14
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn48.CellAppearance = Appearance52
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance53
        UltraGridColumn48.Header.Caption = "Tổng khối lượng"
        UltraGridColumn48.Header.VisiblePosition = 16
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance54
        UltraGridColumn49.Header.VisiblePosition = 17
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance55
        UltraGridColumn50.Header.VisiblePosition = 18
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance56
        UltraGridColumn51.Header.VisiblePosition = 19
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance57
        UltraGridColumn52.Header.VisiblePosition = 21
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance58
        UltraGridColumn53.Header.VisiblePosition = 23
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance59
        UltraGridColumn54.Header.Caption = "Truyền khai thác"
        UltraGridColumn54.Header.VisiblePosition = 22
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance60
        UltraGridColumn55.Header.VisiblePosition = 24
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance61
        UltraGridColumn56.Header.Caption = "Ngày hệ thống"
        UltraGridColumn56.Header.VisiblePosition = 15
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance62
        UltraGridColumn57.Header.Caption = "Chốt số liệu"
        UltraGridColumn57.Header.VisiblePosition = 20
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance63
        UltraGridColumn58.Header.VisiblePosition = 25
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance64
        UltraGridColumn59.Header.Caption = "Số hiệu BC37"
        UltraGridColumn59.Header.VisiblePosition = 26
        UltraGridColumn59.Hidden = True
        UltraGridColumn59.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn59.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(162, 0)
        UltraGridColumn59.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn59.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.CellAppearance = Appearance65
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance66
        UltraGridColumn60.Header.VisiblePosition = 27
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn61.CellAppearance = Appearance67
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn61.Header.Appearance = Appearance68
        UltraGridColumn61.Header.Caption = "Số chuyến thư"
        UltraGridColumn61.Header.VisiblePosition = 28
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.CellAppearance = Appearance69
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance70
        UltraGridColumn62.Header.Caption = "Chuyển tiếp"
        UltraGridColumn62.Header.VisiblePosition = 29
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.CellAppearance = Appearance71
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance72
        UltraGridColumn63.Header.Caption = "Bưu cục đóng"
        UltraGridColumn63.Header.VisiblePosition = 30
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn63.Width = 90
        UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.CellAppearance = Appearance73
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance74
        UltraGridColumn64.Header.Caption = "Bưu cục nhận"
        UltraGridColumn64.Header.VisiblePosition = 31
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.Width = 90
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        UltraGridBand5.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance75.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand5.Override.RowSelectorAppearance = Appearance75
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgGiaoTuiDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgGiaoTuiDi1.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.CardAreaAppearance = Appearance76
        Me.dgGiaoTuiDi1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance77.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance77.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance77.ForeColor = System.Drawing.Color.Black
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance77.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderAppearance = Appearance77
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance78.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowAppearance = Appearance78
        Appearance79.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance79.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance79.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorAppearance = Appearance79
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance80.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance80.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectedRowAppearance = Appearance80
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi1.Location = New System.Drawing.Point(2, 64)
        Me.dgGiaoTuiDi1.Name = "dgGiaoTuiDi1"
        Me.dgGiaoTuiDi1.Size = New System.Drawing.Size(356, 376)
        Me.dgGiaoTuiDi1.TabIndex = 18
        Me.dgGiaoTuiDi1.Text = "Danh sách giao túi gói đi"
        '
        'gbGhep_Tui_Goi
        '
        Me.gbGhep_Tui_Goi.Controls.Add(Me.btnMo_Chuyen_Thu)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.cbChuyenThuDi1)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.UltraLabel6)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.cbDuongThuDi1)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.UltraLabel7)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.cbNgayDong1)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.UltraLabel8)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.chkChon_Tat)
        Me.gbGhep_Tui_Goi.Controls.Add(Me.dgGiaoTuiDi)
        Me.gbGhep_Tui_Goi.ForeColor = System.Drawing.SystemColors.Control
        Appearance81.FontData.BoldAsString = "True"
        Appearance81.ForeColor = System.Drawing.Color.Black
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Center
        Me.gbGhep_Tui_Goi.HeaderAppearance = Appearance81
        Me.gbGhep_Tui_Goi.Location = New System.Drawing.Point(7, 144)
        Me.gbGhep_Tui_Goi.Name = "gbGhep_Tui_Goi"
        Me.gbGhep_Tui_Goi.Size = New System.Drawing.Size(361, 440)
        Me.gbGhep_Tui_Goi.SupportThemes = False
        Me.gbGhep_Tui_Goi.TabIndex = 1
        Me.gbGhep_Tui_Goi.Text = "Ghép túi gói BC37"
        Me.gbGhep_Tui_Goi.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnMo_Chuyen_Thu
        '
        Appearance82.ForeColor = System.Drawing.Color.Black
        Me.btnMo_Chuyen_Thu.Appearance = Appearance82
        Me.btnMo_Chuyen_Thu.Location = New System.Drawing.Point(263, 21)
        Me.btnMo_Chuyen_Thu.Name = "btnMo_Chuyen_Thu"
        Me.btnMo_Chuyen_Thu.Size = New System.Drawing.Size(92, 40)
        Me.btnMo_Chuyen_Thu.TabIndex = 3
        Me.btnMo_Chuyen_Thu.Text = "Mở chuyến"
        '
        'cbChuyenThuDi1
        '
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbChuyenThuDi1.Appearance = Appearance83
        Me.cbChuyenThuDi1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn65.Header.Caption = "Chuyến Thư"
        UltraGridColumn65.Header.VisiblePosition = 0
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn65})
        UltraGridBand6.Header.Caption = "Chuyến Thư Đi"
        Me.cbChuyenThuDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance84.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance84.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance84.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance84.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbChuyenThuDi1.DisplayLayout.Override.HeaderAppearance = Appearance84
        Me.cbChuyenThuDi1.DisplayMember = ""
        Me.cbChuyenThuDi1.Location = New System.Drawing.Point(191, 38)
        Me.cbChuyenThuDi1.Name = "cbChuyenThuDi1"
        Me.cbChuyenThuDi1.Size = New System.Drawing.Size(65, 21)
        Me.cbChuyenThuDi1.TabIndex = 2
        Me.cbChuyenThuDi1.Text = "1"
        Me.cbChuyenThuDi1.ValueMember = ""
        '
        'UltraLabel6
        '
        Appearance85.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel6.Appearance = Appearance85
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(192, 22)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel6.TabIndex = 51
        Me.UltraLabel6.Text = "Chu&yến Thư"
        '
        'cbDuongThuDi1
        '
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDuongThuDi1.Appearance = Appearance86
        Me.cbDuongThuDi1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn66.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn66.Header.VisiblePosition = 0
        UltraGridColumn67.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn67.Header.VisiblePosition = 1
        UltraGridColumn67.Width = 250
        UltraGridColumn68.Header.VisiblePosition = 2
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn69.Header.VisiblePosition = 3
        UltraGridColumn69.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance87.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance87.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance87.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuongThuDi1.DisplayLayout.Override.HeaderAppearance = Appearance87
        Me.cbDuongThuDi1.DisplayMember = ""
        Me.cbDuongThuDi1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi1.Location = New System.Drawing.Point(98, 38)
        Me.cbDuongThuDi1.Name = "cbDuongThuDi1"
        Me.cbDuongThuDi1.Size = New System.Drawing.Size(88, 21)
        Me.cbDuongThuDi1.TabIndex = 1
        Me.cbDuongThuDi1.Text = "0"
        Me.cbDuongThuDi1.ValueMember = ""
        '
        'UltraLabel7
        '
        Appearance88.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel7.Appearance = Appearance88
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(98, 22)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(77, 16)
        Me.UltraLabel7.TabIndex = 49
        Me.UltraLabel7.Text = "Đường thư đi"
        '
        'cbNgayDong1
        '
        Me.cbNgayDong1.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.cbNgayDong1.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong1.Location = New System.Drawing.Point(5, 38)
        Me.cbNgayDong1.Name = "cbNgayDong1"
        Me.cbNgayDong1.Size = New System.Drawing.Size(88, 21)
        Me.cbNgayDong1.TabIndex = 0
        Me.cbNgayDong1.Value = Nothing
        '
        'UltraLabel8
        '
        Appearance89.ForeColor = System.Drawing.Color.Black
        Me.UltraLabel8.Appearance = Appearance89
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(8, 22)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel8.TabIndex = 48
        Me.UltraLabel8.Text = "Ngày đóng"
        '
        'chkChon_Tat
        '
        Appearance90.ForeColor = System.Drawing.Color.Blue
        Me.chkChon_Tat.Appearance = Appearance90
        Me.chkChon_Tat.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button3DOldStyle
        Me.chkChon_Tat.Checked = True
        Me.chkChon_Tat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat.Location = New System.Drawing.Point(4, 92)
        Me.chkChon_Tat.Name = "chkChon_Tat"
        Me.chkChon_Tat.Size = New System.Drawing.Size(13, 13)
        Me.chkChon_Tat.TabIndex = 25
        '
        'dgGiaoTuiDi
        '
        Me.dgGiaoTuiDi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance91.BackColor = System.Drawing.Color.White
        Appearance91.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi.DisplayLayout.Appearance = Appearance91
        UltraGridBand8.CardSettings.ShowCaption = False
        Appearance92.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.CellAppearance = Appearance92
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance93
        UltraGridColumn70.Header.Caption = ""
        UltraGridColumn70.Header.VisiblePosition = 0
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(21, 0)
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance94.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance94
        UltraGridColumn71.Header.Caption = "Id E2"
        UltraGridColumn71.Header.VisiblePosition = 1
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance95.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance95
        UltraGridColumn72.Header.Caption = "Id Đường Thư"
        UltraGridColumn72.Header.VisiblePosition = 3
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance96.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.Header.Appearance = Appearance96
        UltraGridColumn73.Header.Caption = "Id Chuyến thư"
        UltraGridColumn73.Header.VisiblePosition = 2
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn73.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn73.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn73.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn74.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance97.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance97
        UltraGridColumn74.Header.Caption = "Id ca"
        UltraGridColumn74.Header.VisiblePosition = 4
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.CellAppearance = Appearance98
        Appearance99.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance99
        UltraGridColumn75.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn75.Header.VisiblePosition = 5
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn75.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn75.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn75.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn76.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance100.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.CellAppearance = Appearance100
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance101
        UltraGridColumn76.Header.Caption = "Mã bưu cục"
        UltraGridColumn76.Header.VisiblePosition = 6
        UltraGridColumn76.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn76.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn76.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn76.RowLayoutColumnInfo.SpanY = 2
        Appearance102.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance102
        UltraGridColumn77.Header.Caption = "Ngày đóng"
        UltraGridColumn77.Header.VisiblePosition = 7
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn77.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn77.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn77.RowLayoutColumnInfo.SpanY = 2
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance103
        UltraGridColumn78.Header.VisiblePosition = 8
        UltraGridColumn78.Hidden = True
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance104
        UltraGridColumn79.Header.VisiblePosition = 9
        UltraGridColumn79.Hidden = True
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.Header.Appearance = Appearance105
        UltraGridColumn80.Header.VisiblePosition = 10
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn81.CellAppearance = Appearance106
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn81.Header.Appearance = Appearance107
        UltraGridColumn81.Header.Caption = "Túi số"
        UltraGridColumn81.Header.VisiblePosition = 11
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.Header.Appearance = Appearance108
        UltraGridColumn82.Header.VisiblePosition = 12
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn83.CellAppearance = Appearance109
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.Header.Appearance = Appearance110
        UltraGridColumn83.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn83.Header.VisiblePosition = 13
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance111.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn84.CellAppearance = Appearance111
        Appearance112.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.Header.Appearance = Appearance112
        UltraGridColumn84.Header.VisiblePosition = 14
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance113.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn85.CellAppearance = Appearance113
        Appearance114.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn85.Header.Appearance = Appearance114
        UltraGridColumn85.Header.Caption = "Tổng khối lượng"
        UltraGridColumn85.Header.VisiblePosition = 16
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance115
        UltraGridColumn86.Header.VisiblePosition = 17
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance116.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance116
        UltraGridColumn87.Header.VisiblePosition = 18
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance117.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance117
        UltraGridColumn88.Header.VisiblePosition = 19
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance118
        UltraGridColumn89.Header.VisiblePosition = 21
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance119
        UltraGridColumn90.Header.VisiblePosition = 23
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance120
        UltraGridColumn91.Header.Caption = "Truyền khai thác"
        UltraGridColumn91.Header.VisiblePosition = 22
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance121
        UltraGridColumn92.Header.VisiblePosition = 24
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance122
        UltraGridColumn93.Header.Caption = "Ngày hệ thống"
        UltraGridColumn93.Header.VisiblePosition = 15
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance123.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.Header.Appearance = Appearance123
        UltraGridColumn94.Header.Caption = "Chốt số liệu"
        UltraGridColumn94.Header.VisiblePosition = 20
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn95.CellAppearance = Appearance124
        Appearance125.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.Header.Appearance = Appearance125
        UltraGridColumn95.Header.Caption = "Số chuyến thư"
        UltraGridColumn95.Header.VisiblePosition = 25
        UltraGridColumn95.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn95.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn95.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn95.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95})
        UltraGridBand8.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance126.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand8.Override.RowSelectorAppearance = Appearance126
        UltraGridBand8.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand8.UseRowLayout = True
        Me.dgGiaoTuiDi.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.dgGiaoTuiDi.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.CardAreaAppearance = Appearance127
        Me.dgGiaoTuiDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance128.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance128.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance128.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance128.ForeColor = System.Drawing.Color.Black
        Appearance128.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance128.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderAppearance = Appearance128
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance129.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowAppearance = Appearance129
        Appearance130.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance130.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorAppearance = Appearance130
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance131.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance131.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance131.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectedRowAppearance = Appearance131
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi.Location = New System.Drawing.Point(-2, 64)
        Me.dgGiaoTuiDi.Name = "dgGiaoTuiDi"
        Me.dgGiaoTuiDi.Size = New System.Drawing.Size(360, 376)
        Me.dgGiaoTuiDi.TabIndex = 26
        Me.dgGiaoTuiDi.Text = "Danh sách giao túi gói đi"
        '
        'gbQua_Giang
        '
        Me.gbQua_Giang.Controls.Add(Me.UltraGroupBox1)
        Me.gbQua_Giang.Controls.Add(Me.txtSo_Hieu_Tui_Goi)
        Me.gbQua_Giang.Controls.Add(Me.btnDong_Lai)
        Me.gbQua_Giang.Controls.Add(Me.chkChon_Tat_QG)
        Me.gbQua_Giang.Controls.Add(Me.btnThem_Tui_Goi_QG)
        Me.gbQua_Giang.Controls.Add(Me.dgGiaoTuiDi_QuaGiang)
        Me.gbQua_Giang.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance132.FontData.BoldAsString = "True"
        Appearance132.ForeColor = System.Drawing.Color.Black
        Appearance132.TextHAlign = Infragistics.Win.HAlign.Center
        Me.gbQua_Giang.HeaderAppearance = Appearance132
        Me.gbQua_Giang.Location = New System.Drawing.Point(8, 32)
        Me.gbQua_Giang.Name = "gbQua_Giang"
        Me.gbQua_Giang.Size = New System.Drawing.Size(752, 552)
        Me.gbQua_Giang.SupportThemes = False
        Me.gbQua_Giang.TabIndex = 108
        Me.gbQua_Giang.Text = "Túi gói quá giang : Lấy dữ liệu từ Xác nhận túi gói đến"
        Me.gbQua_Giang.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UltraGroupBox1.Controls.Add(Me.optLua_Chon_Code)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(184, 40)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 23
        '
        'optLua_Chon_Code
        '
        Me.optLua_Chon_Code.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optLua_Chon_Code.ItemAppearance = Appearance133
        ValueListItem4.DataValue = "BC37_ID"
        ValueListItem4.DisplayText = "Mã BC37"
        ValueListItem5.DataValue = "Id_Tui_Thu"
        ValueListItem5.DisplayText = "Mã vạch E4"
        Me.optLua_Chon_Code.Items.Add(ValueListItem4)
        Me.optLua_Chon_Code.Items.Add(ValueListItem5)
        Me.optLua_Chon_Code.Location = New System.Drawing.Point(16, 16)
        Me.optLua_Chon_Code.Name = "optLua_Chon_Code"
        Me.optLua_Chon_Code.Size = New System.Drawing.Size(160, 16)
        Me.optLua_Chon_Code.TabIndex = 0
        '
        'txtSo_Hieu_Tui_Goi
        '
        Appearance134.BackColor = System.Drawing.Color.White
        Appearance134.ForeColor = System.Drawing.Color.Green
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Center
        Me.txtSo_Hieu_Tui_Goi.Appearance = Appearance134
        Me.txtSo_Hieu_Tui_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Hieu_Tui_Goi.Location = New System.Drawing.Point(200, 24)
        Me.txtSo_Hieu_Tui_Goi.Multiline = True
        Me.txtSo_Hieu_Tui_Goi.Name = "txtSo_Hieu_Tui_Goi"
        Me.txtSo_Hieu_Tui_Goi.Size = New System.Drawing.Size(296, 40)
        Me.txtSo_Hieu_Tui_Goi.TabIndex = 1
        '
        'btnDong_Lai
        '
        Me.btnDong_Lai.Location = New System.Drawing.Point(664, 24)
        Me.btnDong_Lai.Name = "btnDong_Lai"
        Me.btnDong_Lai.Size = New System.Drawing.Size(80, 40)
        Me.btnDong_Lai.TabIndex = 4
        Me.btnDong_Lai.Text = "Hủy thao tác"
        '
        'chkChon_Tat_QG
        '
        Appearance135.ForeColor = System.Drawing.Color.Black
        Me.chkChon_Tat_QG.Appearance = Appearance135
        Me.chkChon_Tat_QG.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat_QG.Location = New System.Drawing.Point(12, 100)
        Me.chkChon_Tat_QG.Name = "chkChon_Tat_QG"
        Me.chkChon_Tat_QG.Size = New System.Drawing.Size(13, 13)
        Me.chkChon_Tat_QG.TabIndex = 20
        '
        'btnThem_Tui_Goi_QG
        '
        Me.btnThem_Tui_Goi_QG.Location = New System.Drawing.Point(504, 24)
        Me.btnThem_Tui_Goi_QG.Name = "btnThem_Tui_Goi_QG"
        Me.btnThem_Tui_Goi_QG.Size = New System.Drawing.Size(152, 40)
        Me.btnThem_Tui_Goi_QG.TabIndex = 2
        Me.btnThem_Tui_Goi_QG.Text = "Thêm túi gói cho BC37"
        '
        'dgGiaoTuiDi_QuaGiang
        '
        Me.dgGiaoTuiDi_QuaGiang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.AddNewBox.Prompt = " "
        Appearance136.BackColor = System.Drawing.Color.White
        Appearance136.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Appearance = Appearance136
        UltraGridBand9.CardSettings.ShowCaption = False
        Appearance137.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.CellAppearance = Appearance137
        Appearance138.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.Header.Appearance = Appearance138
        UltraGridColumn96.Header.Caption = ""
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn96.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn96.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(21, 0)
        UltraGridColumn96.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn96.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.Header.Appearance = Appearance139
        UltraGridColumn97.Header.Caption = "Id E2"
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance140.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.Header.Appearance = Appearance140
        UltraGridColumn98.Header.Caption = "Id Đường Thư"
        UltraGridColumn98.Header.VisiblePosition = 3
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance141
        UltraGridColumn99.Header.Caption = "Id Chuyến thư"
        UltraGridColumn99.Header.VisiblePosition = 2
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(183, 0)
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance142.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance142
        UltraGridColumn100.Header.Caption = "Id ca"
        UltraGridColumn100.Header.VisiblePosition = 4
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.CellAppearance = Appearance143
        Appearance144.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.Header.Appearance = Appearance144
        UltraGridColumn101.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn101.Header.VisiblePosition = 5
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn101.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn101.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn101.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn101.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance145.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.CellAppearance = Appearance145
        Appearance146.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.Header.Appearance = Appearance146
        UltraGridColumn102.Header.Caption = "Mã bưu cục"
        UltraGridColumn102.Header.VisiblePosition = 6
        UltraGridColumn102.Hidden = True
        UltraGridColumn102.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn102.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn102.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn102.RowLayoutColumnInfo.SpanY = 2
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance147
        UltraGridColumn103.Header.Caption = "Ngày đóng"
        UltraGridColumn103.Header.VisiblePosition = 7
        UltraGridColumn103.Hidden = True
        UltraGridColumn103.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn103.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn103.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn103.RowLayoutColumnInfo.SpanY = 2
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance148
        UltraGridColumn104.Header.VisiblePosition = 8
        UltraGridColumn104.Hidden = True
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance149
        UltraGridColumn105.Header.VisiblePosition = 9
        UltraGridColumn105.Hidden = True
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance150
        UltraGridColumn106.Header.VisiblePosition = 10
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn107.CellAppearance = Appearance151
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance152
        UltraGridColumn107.Header.Caption = "Túi số"
        UltraGridColumn107.Header.VisiblePosition = 11
        UltraGridColumn107.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn107.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn107.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn107.RowLayoutColumnInfo.SpanY = 2
        Appearance153.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance153
        UltraGridColumn108.Header.VisiblePosition = 12
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance154.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn109.CellAppearance = Appearance154
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance155
        UltraGridColumn109.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn109.Header.VisiblePosition = 13
        UltraGridColumn109.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn109.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn109.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn109.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn110.CellAppearance = Appearance156
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance157
        UltraGridColumn110.Header.VisiblePosition = 14
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn110.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn110.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance158.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn111.CellAppearance = Appearance158
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance159
        UltraGridColumn111.Header.Caption = "Tổng khối lượng"
        UltraGridColumn111.Header.VisiblePosition = 16
        UltraGridColumn111.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn111.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn111.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn111.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance160.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.Header.Appearance = Appearance160
        UltraGridColumn112.Header.VisiblePosition = 17
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance161
        UltraGridColumn113.Header.VisiblePosition = 18
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance162.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance162
        UltraGridColumn114.Header.VisiblePosition = 19
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance163.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.Header.Appearance = Appearance163
        UltraGridColumn115.Header.VisiblePosition = 21
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn116.Header.Appearance = Appearance164
        UltraGridColumn116.Header.VisiblePosition = 23
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance165.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn117.Header.Appearance = Appearance165
        UltraGridColumn117.Header.Caption = "Truyền khai thác"
        UltraGridColumn117.Header.VisiblePosition = 22
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance166.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn118.Header.Appearance = Appearance166
        UltraGridColumn118.Header.VisiblePosition = 24
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn119.Header.Appearance = Appearance167
        UltraGridColumn119.Header.Caption = "Ngày hệ thống"
        UltraGridColumn119.Header.VisiblePosition = 15
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance168.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn120.Header.Appearance = Appearance168
        UltraGridColumn120.Header.Caption = "Chốt số liệu"
        UltraGridColumn120.Header.VisiblePosition = 20
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance169.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn121.Header.Appearance = Appearance169
        UltraGridColumn121.Header.VisiblePosition = 25
        UltraGridColumn121.Hidden = True
        UltraGridColumn121.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn121.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn121.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn121.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance170.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.Header.Appearance = Appearance170
        UltraGridColumn122.Header.Caption = "Số hiệu BC37"
        UltraGridColumn122.Header.VisiblePosition = 26
        UltraGridColumn122.Hidden = True
        UltraGridColumn122.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn122.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(162, 0)
        UltraGridColumn122.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn122.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance171.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.CellAppearance = Appearance171
        Appearance172.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.Header.Appearance = Appearance172
        UltraGridColumn123.Header.VisiblePosition = 27
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance173.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn124.CellAppearance = Appearance173
        Appearance174.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn124.Header.Appearance = Appearance174
        UltraGridColumn124.Header.Caption = "Số chuyến thư"
        UltraGridColumn124.Header.VisiblePosition = 28
        UltraGridColumn124.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn124.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn124.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn124.RowLayoutColumnInfo.SpanY = 2
        Appearance175.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn125.CellAppearance = Appearance175
        Appearance176.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn125.Header.Appearance = Appearance176
        UltraGridColumn125.Header.Caption = "Chuyển tiếp"
        UltraGridColumn125.Header.VisiblePosition = 29
        UltraGridColumn125.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn125.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn125.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn125.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn126.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance177.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn126.CellAppearance = Appearance177
        Appearance178.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn126.Header.Appearance = Appearance178
        UltraGridColumn126.Header.Caption = "Bưu cục đóng"
        UltraGridColumn126.Header.VisiblePosition = 30
        UltraGridColumn126.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn126.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn126.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn126.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn126.Width = 90
        UltraGridColumn127.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance179.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn127.CellAppearance = Appearance179
        Appearance180.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn127.Header.Appearance = Appearance180
        UltraGridColumn127.Header.Caption = "Bưu cục nhận"
        UltraGridColumn127.Header.VisiblePosition = 31
        UltraGridColumn127.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn127.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn127.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn127.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn127.Width = 90
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127})
        UltraGridBand9.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance181.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand9.Override.RowSelectorAppearance = Appearance181
        UltraGridBand9.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand9.UseRowLayout = True
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.CardAreaAppearance = Appearance182
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance183.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance183.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance183.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance183.ForeColor = System.Drawing.Color.Black
        Appearance183.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance183.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.HeaderAppearance = Appearance183
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance184.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.RowAppearance = Appearance184
        Appearance185.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance185.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.RowSelectorAppearance = Appearance185
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance186.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance186.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance186.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.SelectedRowAppearance = Appearance186
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi_QuaGiang.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi_QuaGiang.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi_QuaGiang.Location = New System.Drawing.Point(7, 72)
        Me.dgGiaoTuiDi_QuaGiang.Name = "dgGiaoTuiDi_QuaGiang"
        Me.dgGiaoTuiDi_QuaGiang.Size = New System.Drawing.Size(737, 480)
        Me.dgGiaoTuiDi_QuaGiang.TabIndex = 3
        Me.dgGiaoTuiDi_QuaGiang.Text = "Danh sách giao túi gói đi"
        '
        'gbSo_Hieu_BC37
        '
        Me.gbSo_Hieu_BC37.Controls.Add(Me.lblThong_Tin_Tui_Goi)
        Me.gbSo_Hieu_BC37.Controls.Add(Me.lblSo_Hieu_BC37)
        Me.gbSo_Hieu_BC37.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance187.FontData.BoldAsString = "True"
        Appearance187.ForeColor = System.Drawing.Color.Black
        Appearance187.TextHAlign = Infragistics.Win.HAlign.Center
        Me.gbSo_Hieu_BC37.HeaderAppearance = Appearance187
        Me.gbSo_Hieu_BC37.Location = New System.Drawing.Point(7, 88)
        Me.gbSo_Hieu_BC37.Name = "gbSo_Hieu_BC37"
        Me.gbSo_Hieu_BC37.Size = New System.Drawing.Size(753, 56)
        Me.gbSo_Hieu_BC37.SupportThemes = False
        Me.gbSo_Hieu_BC37.TabIndex = 109
        Me.gbSo_Hieu_BC37.Text = "Số hiệu BC37                                                                     " & _
        "                              Thông tin túi gói"
        Me.gbSo_Hieu_BC37.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblThong_Tin_Tui_Goi
        '
        Appearance188.BackColor = System.Drawing.Color.Black
        Appearance188.FontData.BoldAsString = "True"
        Appearance188.ForeColor = System.Drawing.Color.White
        Appearance188.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance188.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.lblThong_Tin_Tui_Goi.Appearance = Appearance188
        Me.lblThong_Tin_Tui_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin_Tui_Goi.Location = New System.Drawing.Point(392, 18)
        Me.lblThong_Tin_Tui_Goi.Name = "lblThong_Tin_Tui_Goi"
        Me.lblThong_Tin_Tui_Goi.Size = New System.Drawing.Size(360, 36)
        Me.lblThong_Tin_Tui_Goi.TabIndex = 3
        '
        'lblSo_Hieu_BC37
        '
        Appearance189.BackColor = System.Drawing.Color.Black
        Appearance189.FontData.BoldAsString = "True"
        Appearance189.ForeColor = System.Drawing.Color.White
        Appearance189.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance189.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.lblSo_Hieu_BC37.Appearance = Appearance189
        Me.lblSo_Hieu_BC37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_Hieu_BC37.Location = New System.Drawing.Point(2, 18)
        Me.lblSo_Hieu_BC37.Name = "lblSo_Hieu_BC37"
        Me.lblSo_Hieu_BC37.Size = New System.Drawing.Size(382, 36)
        Me.lblSo_Hieu_BC37.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(367, 296)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(35, 40)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = ">>"
        '
        'FrmIn_BC37_Tap_Trung
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(766, 584)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gbSo_Hieu_BC37)
        Me.Controls.Add(Me.gbTui_Goi_BC37)
        Me.Controls.Add(Me.gbGhep_Tui_Goi)
        Me.Controls.Add(Me.UltraGroupBox6)
        Me.Controls.Add(Me.gbQua_Giang)
        Me.Controls.Add(Me.chkALL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmIn_BC37_Tap_Trung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý In BC37 tập chung giao đi"
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.cbROAD_MAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDot_Giao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTruc_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opt_Filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbTui_Goi_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTui_Goi_BC37.ResumeLayout(False)
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbGhep_Tui_Goi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGhep_Tui_Goi.ResumeLayout(False)
        CType(Me.cbChuyenThuDi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuongThuDi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbQua_Giang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbQua_Giang.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.optLua_Chon_Code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Hieu_Tui_Goi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgGiaoTuiDi_QuaGiang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSo_Hieu_BC37.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myChuyen_Thu_Di As New Chuyen_Thu_Di(GConnectionString)
    Dim myChuyen_Thu_Di_Chi_Tiet As New Chuyen_Thu_Di_Chi_Tiet
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet
    Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    Dim myDanh_Muc_BC_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet

    Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet

    Dim myQLTGND_CHANG_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet

    Dim myQLTGND_BC37_DI As New QLTGND_BC37_DI(GConnectionString)
    Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet
    Dim myQLTGND_POSTBAG_DI As New QLTGND_POSTBAG_DI(GConnectionString)
    Dim myQLTGND_POSTBAG_DI_Chi_Tiet As New QLTGND_POSTBAG_DI_Chi_Tiet

    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet
    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

    Dim myQLTGND_TRANSPORT_TYPE As New QLTGND_TRANSPORT_TYPE(GConnectionString)
    Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

    Dim myData_Chuyen_Thu As New DataTable
    Dim myData_E2 As New DataTable
    Dim BC37_ID As String = ""

    Dim IsOpenBag As Boolean 'Xác định BC37 có được mở ra không
    Dim IsOpenBag1 As Boolean 'Xác định chuyến thư có được mở ra không
    Dim myId_Duong_Thu As String
    Dim myE2_Date As Integer
    Dim myE2_Time As Integer
    Dim myStart_Date As Integer
    Dim myEnd_Date As Integer
    'Dim mySo_Chuyen_Thu_Di_LonNhat As Integer
    Dim myId_Chuyen_Thu_Ghep_Tui As String
#End Region

#Region "FrmIn_BC37_Tap_Trung_Load"
    Private Sub FrmIn_BC37_Tap_Trung_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbNgayDong.DateTime = Today
        cbNgayDong1.DateTime = Today

        Load_Danh_Muc()
        If (cbDuongThuDi.DataSource Is Nothing Or cbDuongThuDi.Rows.Count = 0) Then
            If (MessageBox.Show("Chưa có chuyến thư nào được đóng túi F bạn có muốn tiếp tục vào lập BC37 giao đi không?" & vbNewLine & "Chọn YES để tiếp tục, hoặc NO để quay lại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No) Then
                Me.Close()
                Me.Dispose()
            End If
        End If
        IsOpenBag = False
        Enable_Control(IsOpenBag)
        Enable_Control1(IsOpenBag1)
        gbQua_Giang.Visible = False

        Lay_TT_Ngay_E2()
        Lay_TT_Ngay_E21()
        'cbDuongThuDi.LimitToList = True
        'cbDuongThuDi1.LimitToList = True
        cbNgayDong.Focus()
        cbNgayDong_AfterExitEditMode(sender, e)
        cbNgayDong1_AfterExitEditMode(sender, e)
        'cbDuongThuDi1_Validated(sender, e)
        Me.ActiveControl = Me.cbDuongThuDi
        cbDuongThuDi.Focus()
    End Sub
#End Region

#Region "FrmIn_BC37_Tap_Trung_Closing"
    Private Sub FrmIn_BC37_Tap_Trung_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If IsOpenBag Then
            DongBC37()
        End If
    End Sub
#End Region
#Region "Load_Danh_Muc_Duong_Thu_Di"
    Private Sub Load_Danh_Muc_Duong_Thu_Di(ByVal intLoai As Integer)
        If (cbNgayDong.Value = New Date(1753, 1, 1, 0, 0, 0, 0)) Then
            Exit Sub
        End If
        Dim intNgay_Dong = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value)
        cbDuongThuDi.DataSource = myDuong_Thu_Di.QLTGND_Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_KT_Loai(GBuu_Cuc_Khai_Thac, intLoai, intNgay_Dong)
        cbDuongThuDi.DataBind()
        If cbDuongThuDi.Rows.Count > 0 Then
            cbDuongThuDi.Value = cbDuongThuDi.Rows(0).Cells("Ma_Bc").Value
        End If
    End Sub
#End Region
#Region "Load_Danh_Muc_Chuyen_Thu_Di_Chua_Lap"
    Private Sub Load_Danh_Muc_Chuyen_Thu_Di(ByVal intLoai As Integer)
        If (cbNgayDong1.Value = New Date(1753, 1, 1, 0, 0, 0, 0)) Then
            Exit Sub
        End If
        Dim intNgay_Dong = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong1.Value)
        cbDuongThuDi1.DataSource = myDuong_Thu_Di.QLTGND_Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_KT(GBuu_Cuc_Khai_Thac, intNgay_Dong, intLoai)
        cbDuongThuDi1.DataBind()
        If cbDuongThuDi1.Rows.Count > 0 Then
            cbDuongThuDi1.Value = cbDuongThuDi1.Rows(0).Cells("Ma_Bc").Value
        End If
    End Sub
#End Region
#Region "Load_Danh_Muc"
    Private Sub Load_Danh_Muc()
        CbTruc_Duong_Thu.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc(GBuu_Cuc_Khai_Thac) 'myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Danh_Sach.Tables(0)
        CbTruc_Duong_Thu.DataBind()
        If CbTruc_Duong_Thu.Rows.Count > 0 Then
            CbTruc_Duong_Thu.Value = CbTruc_Duong_Thu.Rows(0).Cells("Id_Tuyen").Value
        End If
        'cbDuongThuDi.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_KT(GBuu_Cuc_Khai_Thac)
        'cbDuongThuDi.DataBind()
        'If cbDuongThuDi.Rows.Count > 0 Then
        '    cbDuongThuDi.Value = cbDuongThuDi.Rows(0).Cells("Ma_Bc").Value
        'End If

        'cbDuongThuDi1.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_KT(GBuu_Cuc_Khai_Thac)
        'cbDuongThuDi1.DataBind()
        'If cbDuongThuDi1.Rows.Count > 0 Then
        '    cbDuongThuDi1.Value = cbDuongThuDi1.Rows(0).Cells("Ma_Bc").Value
        'End If
        Dim intLoai = CInt(opt_Filter.Value)
        Load_Danh_Muc_Duong_Thu_Di(intLoai)
        Load_Danh_Muc_Chuyen_Thu_Di(intLoai)
        Tao_Bang_Dot_Giao()
    End Sub
#End Region

#Region "Tạo bảng Đợt giao"
    Private Sub Tao_Bang_Dot_Giao()
        Dim dataTable As New dataTable("Dot_Giao")
        Dim i As Integer
        Dim colWork As DataColumn = New DataColumn("Ma", GetType(Integer))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten", GetType(String))
        dataTable.Columns.Add(colWork)

        Dim row As DataRow = dataTable.NewRow()
        For i = 1 To 20
            row = dataTable.NewRow
            row("Ma") = i
            row("Ten") = "Đợt " + i.ToString()
            dataTable.Rows.Add(row)
        Next

        cbDot_Giao.DataSource = dataTable
        cbDot_Giao.DataBind()
        cbDot_Giao.Value = 1
    End Sub
#End Region

#Region "FrmIn_BC37_Tap_Trung_KeyDown"
    Private Sub FrmIn_BC37_Tap_Trung_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
                Case Keys.F1

                Case Keys.F2

                Case Keys.F4

                Case Keys.Escape

            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load_GiaoTuiDi"
    Private Sub Load_GiaoTuiDi(ByVal Id_Chuyen_Thu As String)
        dgGiaoTuiDi.DataSource = myChuyen_Thu_Di.QLTGND_Danh_Sach_Theo_Id_Chuyen_Thu(Id_Chuyen_Thu).Tables(0)
        dgGiaoTuiDi.DataBind()
    End Sub
#End Region

#Region "Load_GiaoTuiDi1"
    Private Sub Load_GiaoTuiDi1(ByVal BC37_ID As String)
        dgGiaoTuiDi1.DataSource = myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Danh_Sach_Theo_BC37_ID_Di(BC37_ID, GBuu_Cuc_Khai_Thac).Tables(0)
        dgGiaoTuiDi1.DataBind()
        dgGiaoTuiDi1.Refresh()
        Refresh_Thong_Tin_Tui_Goi()
    End Sub
#End Region

#Region "Enable_Control"
    Private Sub Enable_Control(ByVal OpenBag As Boolean)
        cbNgayDong.Enabled = Not OpenBag
        cbDuongThuDi.Enabled = Not OpenBag
        cbDot_Giao.Enabled = Not OpenBag
        cbROAD_MAP.Enabled = Not OpenBag
        CbTruc_Duong_Thu.Enabled = Not OpenBag
        opt_Filter.Enabled = Not OpenBag
        btnPreview.Enabled = OpenBag
        'cbNgayDong1.Enabled = OpenBag
        'cbDuongThuDi1.Enabled = OpenBag
        'cbChuyenThuDi1.Enabled = OpenBag
        'btnMo_Chuyen_Thu.Enabled = OpenBag
        btnIn_Nhan_E4.Enabled = OpenBag
        btnLay_Qua_Giang.Enabled = OpenBag
        btnAdd.Enabled = OpenBag
        chkChon_Tat1.Enabled = OpenBag
        dgGiaoTuiDi1.Enabled = OpenBag
        btnMo_BC37.Text = IIf(Not OpenBag, "Mở &BC37", "Đóng &BC37 ")
    End Sub
#End Region

#Region "Enable_Control1"
    Private Sub Enable_Control1(ByVal OpenBag As Boolean)
        cbNgayDong1.Enabled = OpenBag
        cbDuongThuDi1.Enabled = OpenBag
        cbChuyenThuDi1.Enabled = OpenBag
        btnMo_Chuyen_Thu.Enabled = OpenBag

        chkChon_Tat.Enabled = OpenBag
        dgGiaoTuiDi.Enabled = OpenBag
        btnMo_Chuyen_Thu.Text = IIf(OpenBag, "Mở &chuyến", "Đóng &chuyến ")
    End Sub
#End Region

#Region "chkChon_Tat_CheckedChanged"
    Private Sub chkChon_Tat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChon_Tat.CheckedChanged
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            dgGiaoTuiDi.Rows(i).Cells("Chon").Value = chkChon_Tat.Checked
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            'CMessageBox.Show("Hiện tại chưa chọn dữ liệu để in BC37 !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "chkChon_Tat1_CheckedChanged"
    Private Sub chkChon_Tat1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChon_Tat1.CheckedChanged
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = chkChon_Tat1.Checked
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            'CMessageBox.Show("Hiện tại chưa chọn túi nào để in E4 !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "btnMo_BC37_Click"
    Private Sub btnMo_BC37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMo_BC37.Click
        If IsOpenBag = False Then
            Me.MoBC37()
        Else
            Me.DongBC37()
        End If
        cbDuongThuDi.Focus()
    End Sub
#End Region

#Region "MoBC37"
    Private Sub MoBC37()
        Try
            cbNgayDong1.Value = cbNgayDong.Value
            cbDuongThuDi1.Value = cbDuongThuDi.Value
            cbDuongThuDi1_Validated(cbDuongThuDi1, Nothing)
            BC37_ID = QLTGND_Common.Create_BC37_ID(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value), Ham_Dung_Chung.ConvertDateToInt(CDate(cbNgayDong.Value)), CInt(cbDot_Giao.Value))
            lblSo_Hieu_BC37.Text = BC37_ID
            Dim mQLTGND_BC37_Di_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet
            mQLTGND_BC37_Di_Chi_Tiet = myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac)
            If mQLTGND_BC37_Di_Chi_Tiet.Tong_So_Tui > 0 Then
                If CbTruc_Duong_Thu.Value <> mQLTGND_BC37_Di_Chi_Tiet.MAIL_ROUTE_ID Then
                    Dim mTen_Tuyen_VC As String
                    mTen_Tuyen_VC = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(mQLTGND_BC37_Di_Chi_Tiet.MAIL_ROUTE_ID).Ten_Tuyen
                    MessageBox.Show("Đợt giao số " & cbDot_Giao.Value & " của đường thư: " & GBuu_Cuc_Khai_Thac & " - " & cbDuongThuDi.Text & " đã giao vào tuyến vận chuyển <" & mTen_Tuyen_VC & ">. Vì vậy bạn không thể chuyển sang tuyến vận chuyển <" & CbTruc_Duong_Thu.Text & "> được. Chú ý !!! Nếu bạn muốn thay đổi tuyến vận chuyển thì bạn phải xóa BC37 này đi và lập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Load_GiaoTuiDi1(BC37_ID)
                CbTruc_Duong_Thu.Value = mQLTGND_BC37_Di_Chi_Tiet.MAIL_ROUTE_ID
            Else
                myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(CInt(CbTruc_Duong_Thu.Value))
                If CMessageBox.Show("Bạn có muốn tạo BC37 cho tuyến đường thư : ( " & CStr(CbTruc_Duong_Thu.Value) & " - " & myQLTGND_TUYEN_VC_Chi_Tiet.Ten_Tuyen & " ) này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value)))
                    myQLTGND_BC37_DI.QLTGND_BC37_DI_Cap_Nhat_Them(BC37_ID, _
                        CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value)), _
                        GId_Ca, _
                        GBuu_Cuc_Khai_Thac, _
                        CInt(cbDuongThuDi.Value), _
                        Ham_Dung_Chung.ConvertDateToInt(CDate(cbNgayDong.Value)), _
                        Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                        CInt(cbDot_Giao.Value), _
                        Ham_Dung_Chung.ConvertDateToInt(Date.Now), _
                        Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                        CInt(cbDot_Giao.Value), _
                        0, _
                        0, _
                        0, _
                        0, _
                        Gid_Nguoi_Dung, _
                        Ham_Dung_Chung.ConvertDateToInt(Date.Now), _
                        Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                        False, _
                        False, _
                        0, _
                        0, _
                        myQLTGND_TUYEN_VC_Chi_Tiet.TRANSPORT_TYPE_ID.ToString, _
                        "", _
                        myQLTGND_TUYEN_VC_Chi_Tiet.PARTNER_ID.ToString, _
                        CInt(CbTruc_Duong_Thu.Value), _
                        False)
                    Load_GiaoTuiDi1(BC37_ID)
                    Load_GiaoTuiDi("0")
                Else
                    Exit Sub
                End If
            End If
            IsOpenBag = True
            Enable_Control(IsOpenBag)

            IsOpenBag1 = True
            Enable_Control1(IsOpenBag1)
            Me.ActiveControl = Me.cbDuongThuDi1
            cbDuongThuDi1.Focus()
        Catch ex As Exception
            IsOpenBag = False
            Enable_Control(IsOpenBag)
            IsOpenBag1 = False
            Enable_Control1(IsOpenBag1)
        End Try
    End Sub
#End Region

#Region "DongBC37"
    Private Sub DongBC37()
        Try
            myQLTGND_POSTBAG_DI.QLTGND_BC37_DI_Hieu_Chinh(BC37_ID, GBuu_Cuc_Khai_Thac)
            If myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac).Tong_So_Tui > 0 Then
                If chkInkhidong.Checked Then
                    Ban_Ke_BC37_Di_Tong_Hop(BC37_ID, Not chkInkhidong.Checked, CInt(IIf(IsNumeric(txtSo_Ban.Value), txtSo_Ban.Value, 1)))
                End If
            Else
                Ban_Ke_BC37_Di_Tong_Hop(BC37_ID, Not chkInkhidong.Checked, CInt(IIf(IsNumeric(txtSo_Ban.Value), txtSo_Ban.Value, 1)))
            End If
            Load_GiaoTuiDi("0")
            Load_GiaoTuiDi1("0")
            IsOpenBag = False
            Enable_Control(IsOpenBag)
            IsOpenBag1 = False
            Enable_Control1(IsOpenBag1)
            Load_Danh_Muc_Duong_Thu_Di(CInt(opt_Filter.Value))
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgGiaoTuiDi_KeyDown"
    Private Sub dgGiaoTuiDi_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And Keys.Escape <> Keys.Escape And myCell Is Nothing Then Exit Sub
        myGridKeyDown = sender
        If (Not myCell Is Nothing) And (e.KeyValue <> Keys.Escape) Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.F8
                Delete_Row(sender, myGridKeyDown.ActiveRow.Index)
                e.Handled = True
        End Select
    End Sub
#End Region

#Region "Xóa dòng"
    Private Sub Delete_Row(ByVal sender As Object, ByVal ActiveRowIndex As Integer)
        myGridKeyDown = sender
        Dim myRowIndex As Integer
        myRowIndex = myGridKeyDown.ActiveRow.Index
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_Chuyen_Thu").Text.Length <> 0 Then
            If CMessageBox.Show("Bạn có thực sự muốn xóa BC37 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQLTGND_BC37_DI.QLTGND_BC37_DI_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
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
        End If
    End Sub
#End Region

#Region "btnDong_Lai_Click"
    Private Sub btnDong_Lai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong_Lai.Click
        gbQua_Giang.Visible = False
        'Load_GiaoTuiDi("0")
        Load_GiaoTuiDi1(BC37_ID)
        cbDuongThuDi1.Focus()
    End Sub
#End Region

#Region "txtSo_Hieu_Tui_Goi_Validated"
    Private Sub txtSo_Hieu_Tui_Goi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_Tui_Goi.Validated
        Dim myCode As String = ""
        myCode = txtSo_Hieu_Tui_Goi.Text.Trim
        If myCode.Length = 0 Then
            Exit Sub
        End If
        If optLua_Chon_Code.CheckedIndex = 0 Then  'BC37
            Dim myBC37Code As New DycryptBarCode.bc37code
            If (myBC37Code.check(myCode) = True) Then 'Mã vạch hợp lệ
                'lấy dữ liệu túi quá giang theo BC37 quá giang
                dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang(myCode, GBuu_Cuc_Khai_Thac, True).Tables(0)
                dgGiaoTuiDi_QuaGiang.DataBind()
                'khong có dữ liệu  --> thông báo
                If dgGiaoTuiDi_QuaGiang.Rows.Count <= 0 Then
                    MessageBox.Show("Không có dữ liệu quá giang theo BC37 nhập vào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSo_Hieu_Tui_Goi.SelectAll()
                    txtSo_Hieu_Tui_Goi.Focus()
                End If
            Else   'sai định dạng
                MessageBox.Show("Bạn phải nhập đúng định dạng mã BC37", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Hieu_Tui_Goi.SelectAll()
                txtSo_Hieu_Tui_Goi.Focus()
            End If
        Else  'E4
            Dim myE4Code As New DycryptBarCode.e4code
            If (myE4Code.check(myCode) = True) Then 'Mã vạch hợp lệ
                'lấy dữ liệu E4 quá giang theo mã vạch túi
                dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang(myCode, GBuu_Cuc_Khai_Thac, True).Tables(0)
                dgGiaoTuiDi_QuaGiang.DataBind()
                'khong có dữ liệu  --> thông báo
                If dgGiaoTuiDi_QuaGiang.Rows.Count <= 0 Then
                    MessageBox.Show("Không có dữ liệu quá giang theo túi thư nhập vào!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSo_Hieu_Tui_Goi.SelectAll()
                    txtSo_Hieu_Tui_Goi.Focus()
                End If
            Else  'sai định dạng
                MessageBox.Show("Bạn phải nhập đúng định dạng mã E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Hieu_Tui_Goi.SelectAll()
                txtSo_Hieu_Tui_Goi.Focus()
            End If
        End If
    End Sub
#End Region

#Region "Lay_TT_Ngay_E2"
    Private Sub Lay_TT_Ngay_E2()
        myE2_Date = Ham_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value)
        myE2_Time = Ham_Dung_Chung.ConvertTimeToInt(Now)
    End Sub

    Private Sub Lay_TT_Ngay_E21()
        myE2_Date = Ham_Dung_Chung.ConvertDateToInt(Me.cbNgayDong1.Value)
        myE2_Time = Ham_Dung_Chung.ConvertTimeToInt(Now)
    End Sub
#End Region

#Region "Ngày Đóng"
    Private Sub cbNgayDong_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.AfterExitEditMode
        If Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value) > Ham_Dung_Chung.ConvertDateToInt(Now) Then
            cbNgayDong.Select()
        End If
        Lay_TT_Ngay_E2()
    End Sub

    Private Sub cbNgayDong1_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong1.AfterExitEditMode
        If Ham_Dung_Chung.ConvertDateToInt(cbNgayDong1.Value) > Ham_Dung_Chung.ConvertDateToInt(Now) Then
            cbNgayDong1.Select()
        End If
        Lay_TT_Ngay_E21()
    End Sub
#End Region

#Region "Lay_TT_Ngay_Thang"
    Private Sub Lay_TT_Ngay_Thang(ByVal E2_Date As Integer)
        If E2_Date <> 0 Then
            Select Case myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai
                Case 0, 1 'Đường Thư Nội Tỉnh,Bưu Tá: Chuyến Thư tăng theo Tháng
                    myStart_Date = (E2_Date \ 10000) * 10000
                    myEnd_Date = (E2_Date \ 10000) * 10000 + 9999
                Case 2, 3, 4, 5, 6 'Đường Thư Liên Tỉnh,Liền kề, Quốc tê,Lưu kho,Vô thừa nhận: Chuyến Thư tăng theo Năm
                    myStart_Date = (E2_Date \ 10000) * 10000
                    myEnd_Date = (E2_Date \ 10000) * 10000 + 9999
                Case Else
                    CMessageBox.Show("Không tồn tại phân loại đường thư này!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Else
            CMessageBox.Show("Ngày E2 chưa được xác định!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
#End Region

#Region "Đường Thư"
#Region "cbDuongThuDi1_Validated"
    Private Sub cbDuongThuDi1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuDi1.Validated
        If IsNumeric(cbDuongThuDi1.Value) = False And cbDuongThuDi1.Text <> "" Then
            CMessageBox.Show("Chỉ được phép nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbDuongThuDi1.Focus()
            Exit Sub
        Else
            Lay_TT_Duong_Thu1()
            Lay_TT_Ngay_Thang(myE2_Date)
            cbChuyenThuDi1.Text = ""
            'mySo_Chuyen_Thu_Di_LonNhat = myChuyen_Thu_Di.Tim_So_Chuyen_Thu_Di_Lon_Nhat(myId_Duong_Thu, myStart_Date, myEnd_Date)
            'Danh Sách Chuyến thư đi tương ứng với Ngày và Đường Thư Đi
            '''Dim myId_Duong_Thu As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi1.Value))'''moi them vao do
            Dim Ngay_Dong As Integer
            Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(cbNgayDong1.Value)
            cbChuyenThuDi1.DataSource = myChuyen_Thu_Di.QLTGND_Chuyen_Thu_Di_Lay_Boi_Duong_Thu_Di_Ngay_KT(myId_Duong_Thu, Ngay_Dong, CInt(opt_Filter.Value))
            'If mySo_Chuyen_Thu_Di_LonNhat > 0 Then
            'If myChuyen_Thu_Di.Chuyen_Thu_Di_Dong_F(myId_Duong_Thu, myStart_Date, myEnd_Date, mySo_Chuyen_Thu_Di_LonNhat) = False Then 'Kiểm tra xem chuyến thư Max đã đóng F chưa
            If Not (cbChuyenThuDi1.Rows Is Nothing) And cbChuyenThuDi1.Rows.Count > 0 Then
                btnMo_Chuyen_Thu.Enabled = True
                cbChuyenThuDi1.Text = cbChuyenThuDi1.Rows(0).Cells("So_Chuyen_Thu").Value
                cbChuyenThuDi1.Value = cbChuyenThuDi1.Rows(0).Cells("So_Chuyen_Thu").Value
                cbChuyenThuDi1.Focus()
            Else
                btnMo_Chuyen_Thu.Enabled = False
            End If

            'Else
            '  cbChuyenThuDi1.Text = mySo_Chuyen_Thu_Di_LonNhat
            ' End If
            'Else
            '    cbChuyenThuDi1.Text = 1
            'End If
        End If
    End Sub
#End Region
#End Region

#Region "Lay_TT_Duong_Thu"
    Private Sub Lay_TT_Duong_Thu1()
        Dim myDataTable As DataTable
        'Lấy thông tin đường thư chi tiết
        If IsNumeric(cbDuongThuDi1.Value) = False Then
            Exit Sub
        End If
        myDataTable = myDuong_Thu_Di.Duong_Thu_Di_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Bc_KT(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi1.Value))
        If myDataTable.Rows.Count > 0 Then
            myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu = myDataTable.Rows(0)("Id_Duong_Thu")
            myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac = myDataTable.Rows(0)("Ma_Bc_Khai_Thac")
            myDuong_Thu_Di_Chi_Tiet.Ma_Bc = myDataTable.Rows(0)("Ma_Bc")
            myDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu = myDataTable.Rows(0)("Ten_Duong_Thu")
            myDuong_Thu_Di_Chi_Tiet.Id_Phan_Loai = myDataTable.Rows(0)("Id_Phan_Loai")
            myId_Duong_Thu = myDuong_Thu_Di_Chi_Tiet.Id_Duong_Thu
            myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen = myDuong_Thu_Di_Chi_Tiet.Duoc_Truyen
        Else
            cbDuongThuDi1.Focus()
        End If
    End Sub
#End Region

#Region "btnIn_Nhan_E4_Click"
    Private Sub btnIn_Nhan_E4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_Nhan_E4.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                In_Nhan_E4_New(dgGiaoTuiDi1.Rows(i).Cells("Id_E2").Text, False, "Ems_E4")
            End If
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Hiện tại chưa chọn Túi để in nhãn E4 !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "btnLay_Qua_Giang_Click"
    Private Sub btnLay_Qua_Giang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLay_Qua_Giang.Click
        If CMessageBox.Show("Lấy dữ liệu quá giang cho vào BC37 có mã là : " & BC37_ID, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            If myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac).Trang_Thai = 2 Then
                CMessageBox.Show("Số hiệu BC37 đã được tạo trước đó và đã truyền lên HOST, bạn không được phép ghép túi nữa...", "Thông báo")
                Exit Sub
            End If
            'Clear lưới quá giang vaf textbox
            txtSo_Hieu_Tui_Goi.Clear()
            dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang("", GBuu_Cuc_Khai_Thac, True).Tables(0)
            dgGiaoTuiDi_QuaGiang.DataBind()
            'HIện panel
            gbQua_Giang.Visible = True
            gbQua_Giang.BringToFront()
            optLua_Chon_Code.CheckedIndex = 0
            gbQua_Giang.Text = "Thêm túi quá gian cho BC37 : " & BC37_ID
            Me.ActiveControl = Me.txtSo_Hieu_Tui_Goi
            txtSo_Hieu_Tui_Goi.Focus()
        End If
    End Sub
#End Region

#Region "btnMo_Chuyen_Thu_Click"
    Private Sub btnMo_Chuyen_Thu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMo_Chuyen_Thu.Click
        If IsOpenBag1 = True Then
            Me.Mo_Chuyen_Thu()
        Else
            Me.Dong_Chuyen_Thu()
        End If
        cbDuongThuDi1.Focus()
    End Sub
#End Region

#Region "Mo_Chuyen_Thu"
    Private Sub Mo_Chuyen_Thu()
        Try
            If CMessageBox.Show("Bạn có chắc chắn muốn mở chuyến thư này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim myNgay_Dong As Integer = Ham_Dung_Chung.ConvertDateToInt(CDate(cbNgayDong1.Value))
                Dim myId_Duong_Thu As String = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi1.Value))
                Dim mySo_Chuyen_Thu As Integer = CInt(cbChuyenThuDi1.Value)
                myId_Chuyen_Thu_Ghep_Tui = CreateId_Chuyen_Thu(myId_Duong_Thu.ToString, mySo_Chuyen_Thu, myNgay_Dong, GLoai_Chuyen_Thu_Trong_Nuoc)
                'Neu Chuyen thu chua F, thi khong cho mo
                If myChuyen_Thu_Di.Lay(myId_Chuyen_Thu_Ghep_Tui).Dong_F = False Then
                    CMessageBox.Show("Chuyến thư này chưa đóng F, Xin mời quay lại phần thiết lập bản kê E2 đi để đóng F chuyến thư này")
                    Exit Sub
                End If
                Load_GiaoTuiDi(myId_Chuyen_Thu_Ghep_Tui)
                IsOpenBag1 = True
                Enable_Control1(IsOpenBag)
            End If
        Catch ex As Exception
            IsOpenBag1 = False
            Enable_Control1(IsOpenBag1)
        End Try
    End Sub
#End Region

#Region "Dong_Chuyen_Thu"
    Private Sub Dong_Chuyen_Thu()
        Try
            Load_GiaoTuiDi("0")
            IsOpenBag1 = False
            Enable_Control1(IsOpenBag1)
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnAdd_Click"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If myQLTGND_BC37_DI.QLTGND_BC37_DI_Lay(BC37_ID, GBuu_Cuc_Khai_Thac).Trang_Thai = 2 Then
            CMessageBox.Show("Số hiệu BC37 đã được tạo trước đó và đã truyền lên HOST, bạn không được phép ghép túi nữa...", "Thông báo")
            Exit Sub
        End If
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            If dgGiaoTuiDi.Rows(i).Cells("Chon").Value = True Then
                With myE2_Di_Chi_Tiet
                    .Chot_SL = CBool(dgGiaoTuiDi.Rows(i).Cells("Chot_SL").Value)
                    .Gio_Dong = CInt(dgGiaoTuiDi.Rows(i).Cells("Gio_Dong").Value)
                    .Gio_Nhan = CInt(dgGiaoTuiDi.Rows(i).Cells("Gio_Nhan").Value)
                    .HH_Phat_Hanh = CInt(dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Hanh").Value)
                    .HH_Phat_Tra = CInt(dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Tra").Value)
                    .Id_Ca = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_Ca").Value)
                    .Id_Chuyen_Thu = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_Chuyen_Thu").Value)
                    .Id_Duong_Thu = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_Duong_Thu").Value)
                    .Id_E2 = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_E2").Value)
                    .Khoi_Luong_BP = CInt(dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_BP").Value)
                    .Khoi_Luong_Vo_Tui = CInt(dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value)
                    .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                    .Ngay_Dong = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Dong").Value)
                    .Ngay_He_Thong = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_He_Thong").Value)
                    .Ngay_Nhan = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Nhan").Value)
                    .Tong_Cuoc_Chinh = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_Chinh").Value)
                    .Tong_Cuoc_COD = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_COD").Value)
                    .Tong_Cuoc_DV = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_DV").Value)
                    .Tong_So_BP = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_So_BP").Value)
                    .Truyen_Doi_Soat = CBool(dgGiaoTuiDi.Rows(i).Cells("Truyen_Doi_Soat").Value)
                    .Truyen_Khai_Thac = CBool(dgGiaoTuiDi.Rows(i).Cells("Truyen_Khai_Thac").Value)
                    .Tui_F = CBool(dgGiaoTuiDi.Rows(i).Cells("Tui_F").Value)
                    .Tui_So = CInt(dgGiaoTuiDi.Rows(i).Cells("Tui_So").Value)
                End With
                'cẬP NHẬT THÊM
                myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(CInt(CbTruc_Duong_Thu.Value))
                myDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbDuongThuDi.Value)))
                myQLTGND_CHANG_VC_Chi_Tiet = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Lay_Theo_BC_Goc_Dich(myDuong_Thu_Di_Chi_Tiet.Ma_Bc_Khai_Thac, myDuong_Thu_Di_Chi_Tiet.Ma_Bc, CInt(CbTruc_Duong_Thu.Value))
                Dim mySo_Chuyen_Thu As Integer = CInt(dgGiaoTuiDi.Rows(i).Cells("So_Chuyen_Thu").Value)
                Dim myId_Tui_Thu As String

                'myId_Tui_Thu = myE2_Di.QLTGND_Tao_Id_Tui_Thu_Theo_Id_E2_New(myE2_Di_Chi_Tiet.Id_E2, _
                '    myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu).Ma_Bc, _
                '    myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                '    myE2_Di_Chi_Tiet.Ngay_Dong, _
                '    mySo_Chuyen_Thu, _
                '    myE2_Di_Chi_Tiet.Tui_So, _
                '    myE2_Di_Chi_Tiet.Tui_So, _
                '    myE2_Di_Chi_Tiet.Khoi_Luong_BP, _
                '    myE2_Di_Chi_Tiet.Khoi_Luong_Vo_Tui)
                Dim myqltgnd_E2_Di As New QLTGND_E2_Di(GConnectionString)
                myId_Tui_Thu = myqltgnd_E2_Di.QLTGND_E2_Di_Lay(myE2_Di_Chi_Tiet.Id_E2).Id_Tui_Thu
                If myE2_Di_Chi_Tiet.Tong_So_BP <> 0 Then
                    Dim myMa_Bc As Integer = myDuong_Thu_Di.Lay(myE2_Di_Chi_Tiet.Id_Duong_Thu).Ma_Bc
                    myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Them(myE2_Di_Chi_Tiet.Id_E2, _
                        myE2_Di_Chi_Tiet.Id_Duong_Thu, _
                        myE2_Di_Chi_Tiet.Id_Chuyen_Thu, _
                        myE2_Di_Chi_Tiet.Id_Ca, _
                        myE2_Di_Chi_Tiet.Ma_Bc_Khai_Thac, _
                        myMa_Bc, _
                        myE2_Di_Chi_Tiet.Ngay_Dong, _
                        myE2_Di_Chi_Tiet.Gio_Dong, _
                        myE2_Di_Chi_Tiet.Ngay_Nhan, _
                        myE2_Di_Chi_Tiet.Gio_Nhan, _
                        mySo_Chuyen_Thu, _
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
                        myE2_Di_Chi_Tiet.Ngay_He_Thong, _
                        myE2_Di_Chi_Tiet.Chot_SL, _
                        myId_Tui_Thu, _
                        BC37_ID, _
                        0, _
                        False)
                Else
                    CMessageBox.Show("Túi số : " & myE2_Di_Chi_Tiet.Tui_So.ToString & _
                                    " có người khác đang mở, hoặc túi này đang bị lỗi, vì tổng số bưu phẩm = 0" & vbNewLine & _
                                    "Cách khắc phục : Mở túi đó ra xem, nếu túi lỗi, vào chức năng sửa chữa E2 đi để sửa bản kê E2 lỗi nhé." & vbNewLine & _
                                    "xin hãy kiểm tra lại", "Thông báo")
                End If
                kiem_tra_chon = True
            End If
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Bạn chưa chọn mã E1 nào xác nhận giao túi gói !!!", "Thông báo")
            Exit Sub
        Else
            Load_GiaoTuiDi(myId_Chuyen_Thu_Ghep_Tui)
            Load_GiaoTuiDi1(BC37_ID)
        End If
    End Sub
#End Region

#Region "btnThem_Tui_Goi_QG_Click"
    Private Sub btnThem_Tui_Goi_QG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem_Tui_Goi_QG.Click
        If dgGiaoTuiDi_QuaGiang.Rows.Count <= 0 Then
            Exit Sub
        End If
        'If txtSo_Hieu_Tui_Goi.Text.Length = 0 Then
        '    Exit Sub
        'End If
        Dim kiem_tra_chon As Boolean = False
        Dim Tong_So As Integer = 0
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi_QuaGiang.Rows.Count - 1
            If dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_POSTBAG_DEN_Chi_Tiet
                    .Chot_SL = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Chot_SL").Value
                    .Gio_Dong = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Gio_Dong").Value
                    .Gio_Nhan = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Gio_Nhan").Value
                    .HH_Phat_Hanh = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("HH_Phat_Hanh").Value
                    .HH_Phat_Tra = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("HH_Phat_Tra").Value
                    .Id_BC37 = BC37_ID
                    .Id_Ca = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Id_Ca").Value
                    .Ma_Bc = CInt(cbDuongThuDi.Value)
                    .Id_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, .Ma_Bc)
                    .So_Chuyen_Thu = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("So_Chuyen_Thu").Value
                    .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Ngay_Dong").Value)
                    .Id_Chuyen_Thu = CreateId_Chuyen_Thu(.Id_Duong_Thu, .So_Chuyen_Thu, .Ngay_Dong, GLoai_Chuyen_Thu_Trong_Nuoc)
                    .Tui_So = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tui_So").Value
                    .Id_E2 = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Id_E2").Value
                    .Id_Tui_Thu = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Id_Tui_Thu").Value
                    .Khoi_Luong_BP = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Khoi_Luong_BP").Value
                    .Khoi_Luong_Vo_Tui = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value
                    .Ma_Bc_Khai_Thac = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Ma_Bc_Khai_Thac").Value
                    .Ngay_He_Thong = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Ngay_He_Thong").Value
                    .Ngay_Nhan = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Ngay_Nhan").Value
                    .Tong_Cuoc_Chinh = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tong_Cuoc_Chinh").Value
                    .Tong_Cuoc_COD = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tong_Cuoc_COD").Value
                    .Tong_Cuoc_DV = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tong_Cuoc_DV").Value
                    .Tong_So_BP = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tong_So_BP").Value
                    .Trang_Thai = Trang_Thai_Chua_Xac_Nhan
                    .Truyen_Doi_Soat = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Truyen_Doi_Soat").Value
                    .Truyen_Khai_Thac = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Truyen_Khai_Thac").Value
                    .Tui_F = dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Tui_F").Value
                    .IS_TRANSITION = True
                End With
                'cẬP NHẬT THÊM
                myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Cap_Nhat_Them(myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_E2, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Duong_Thu, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Chuyen_Thu, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Ca, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Dong, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Gio_Dong, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ngay_Nhan, _
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
                kiem_tra_chon = True
            End If
            Tong_So = Tong_So + 1
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Bạn chưa chọn túi gói nào, xin hãy kiểm tra lại thông tin !!!", "Thông báo")
            Exit Sub
        Else
            If CMessageBox.Show("Đã thêm thành công tổng số " & Tong_So.ToString & " túi quá giang, bạn có muốn tiếp tục nhập quá giang tiếp không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                'Clear lưới
                If optLua_Chon_Code.CheckedIndex = 0 Then   'BC37
                    dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang("", GBuu_Cuc_Khai_Thac, True).Tables(0)
                    dgGiaoTuiDi_QuaGiang.DataBind()
                Else    'E4
                    dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang("", GBuu_Cuc_Khai_Thac, True).Tables(0)
                    dgGiaoTuiDi_QuaGiang.DataBind()
                End If
                'Clear textbox và focus vào textbox
                txtSo_Hieu_Tui_Goi.Clear()
                txtSo_Hieu_Tui_Goi.Focus()

                'txtSo_Hieu_Tui_Goi_Validated(txtSo_Hieu_Tui_Goi, Nothing)
                'If optLua_Chon_Code.CheckedIndex = 0 Then   'BC37
                '    dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Den_Qua_Giang("", GBuu_Cuc_Khai_Thac, True).Tables(0)
                '    dgGiaoTuiDi_QuaGiang.DataBind()
                '    txtSo_Hieu_Tui_Goi.SelectAll()
                '    txtSo_Hieu_Tui_Goi.Focus()
                'Else    'E4
                '    dgGiaoTuiDi_QuaGiang.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Id_Tui_Thu_Qua_Giang("", GBuu_Cuc_Khai_Thac, True).Tables(0)
                '    dgGiaoTuiDi_QuaGiang.DataBind()
                '    txtSo_Hieu_Tui_Goi.SelectAll()
                '    txtSo_Hieu_Tui_Goi.Focus()
                'End If
            Else
                btnMo_BC37.Focus()
                gbQua_Giang.Visible = False
                'Load_GiaoTuiDi("0")
                Load_GiaoTuiDi1(BC37_ID)
            End If
        End If
    End Sub
#End Region

#Region "chkChon_Tat_QG_CheckedChanged"
    Private Sub chkChon_Tat_QG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChon_Tat_QG.CheckedChanged
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi_QuaGiang.Rows.Count - 1
            dgGiaoTuiDi_QuaGiang.Rows(i).Cells("Chon").Value = chkChon_Tat_QG.Checked
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Hiện tại chưa có dữ liệu !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "btnPreview_Click"
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim myBC37_ID As String = Create_BC37_ID(GBuu_Cuc_Khai_Thac, cbDuongThuDi.Value, Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value), CInt(cbDot_Giao.Value))
        Ban_Ke_BC37_Di_Tong_Hop(myBC37_ID, True, CInt(txtSo_Ban.Value))
    End Sub
#End Region

#Region "dgGiaoTuiDi1_KeyDown"
    Private Sub dgGiaoTuiDi1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGiaoTuiDi1.KeyDown
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
                Case Keys.F8
                    Delete_Tui_Goi(sender, myGridKeyDown.ActiveRow.Index)
                    e.Handled = True
            End Select
        Catch ex As Exception
            Console.Write(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Xóa dòng"
    Private Sub Delete_Tui_Goi(ByVal sender As Object, ByVal ActiveRowIndex As Integer) ', ByVal Khoi_Luong_BP As Integer)
        myGridKeyDown = sender
        Dim myRowIndex As Integer
        myRowIndex = myGridKeyDown.ActiveRow.Index
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E2").Text.Length <> 0 Then
            If CMessageBox.Show("Bạn có thực sự muốn xóa túi gói trong BC37 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E2").Text)
                myGridKeyDown.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myQLTGND_POSTBAG_DI.QLTGND_BC37_DI_Hieu_Chinh_Thong_So(BC37_ID, GBuu_Cuc_Khai_Thac)
            End If
        End If
    End Sub
#End Region

#Region "CbTruc_Duong_Thu_Validated"
    Private Sub CbTruc_Duong_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTruc_Duong_Thu.Validated
        cbDot_Giao.Value = IIf(CbTruc_Duong_Thu.SelectedRow.Cells("Id_Dot").Value = 0, 1, CbTruc_Duong_Thu.SelectedRow.Cells("Id_Dot").Value) 'myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(CInt(CbTruc_Duong_Thu.Value)).Id_Dot
    End Sub
#End Region

    Private Sub txtSo_Hieu_Tui_Goi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_Tui_Goi.ValueChanged

    End Sub

    Private Sub optLua_Chon_Code_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLua_Chon_Code.ValueChanged
        txtSo_Hieu_Tui_Goi.SelectAll()
        txtSo_Hieu_Tui_Goi.Focus()
    End Sub

    Private Sub CbTruc_Duong_Thu_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles CbTruc_Duong_Thu.InitializeLayout

    End Sub

#Region "Refresh_Thong_Tin_Tui_Goi"
    Private Sub Refresh_Thong_Tin_Tui_Goi()
        Try
            Dim mTong_So_Tui As Integer = 0
            Dim mTong_Khoi_Luong As Double = 0
            Dim mKhoi_Luong_Vo_Tui As Double = 0
            If dgGiaoTuiDi1.Rows.Count > 0 Then
                For idx As Integer = 0 To dgGiaoTuiDi1.Rows.Count - 1
                    mTong_So_Tui = mTong_So_Tui + 1
                    mTong_Khoi_Luong = mTong_Khoi_Luong + dgGiaoTuiDi1.Rows(idx).Cells("Khoi_Luong_BP").Value + dgGiaoTuiDi1.Rows(idx).Cells("Khoi_Luong_Vo_Tui").Value
                    mKhoi_Luong_Vo_Tui = mKhoi_Luong_Vo_Tui + dgGiaoTuiDi1.Rows(idx).Cells("Khoi_Luong_Vo_Tui").Value
                Next
            End If
            mTong_Khoi_Luong = Round(mTong_Khoi_Luong / 1000, 2)
            mKhoi_Luong_Vo_Tui = Round(mKhoi_Luong_Vo_Tui / 1000, 2)
            lblThong_Tin_Tui_Goi.Text = "Tổng số :  " & mTong_So_Tui.ToString & " túi / " & mTong_Khoi_Luong.ToString & " kgs (" & mKhoi_Luong_Vo_Tui.ToString & " kgs vỏ túi)"
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblThong_Tin_Tui_Goi.Text = ""
        End Try
    End Sub
#End Region

    Private Sub opt_Filter_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_Filter.ValueChanged
        Dim intLoai = CInt(opt_Filter.Value)
        Load_Danh_Muc_Duong_Thu_Di(intLoai)
    End Sub

    Private Sub cbNgayDong_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong.ValueChanged
        If Not (cbNgayDong.Value Is Nothing) Then
            Load_Danh_Muc_Duong_Thu_Di(CInt(opt_Filter.Value))
            'if(cbDuongThuDi.DataSource is nothing or cbDuongThuDi.Rows.Count
        End If
    End Sub

    Private Sub cbNgayDong1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbNgayDong1.ValueChanged
        If Not (cbNgayDong1.Value Is Nothing) Then
            Load_Danh_Muc_Chuyen_Thu_Di(CInt(opt_Filter.Value))
        End If
    End Sub

    'Private Sub cbDuongThuDi_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDuongThuDi.ValueChanged
        'If Not (cbDuongThuDi.Value Is Nothing) Then
        '    Dim intBuu_Cuc_Dich As Integer
        '    intBuu_Cuc_Dich = CInt(cbDuongThuDi.Value)
        '    CbTruc_Duong_Thu.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Goc_Ma_Bc_Dich(GBuu_Cuc_Khai_Thac, intBuu_Cuc_Dich) 'myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Danh_Sach.Tables(0)
        '    CbTruc_Duong_Thu.DataBind()
        '    If CbTruc_Duong_Thu.Rows.Count > 0 Then
        '        CbTruc_Duong_Thu.Value = CbTruc_Duong_Thu.Rows(0).Cells("Id_Tuyen").Value
        '    End If
        'End If
    'End Sub
End Class

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
Public Class frmXacNhanBC37Den
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
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkChon_Tat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXac_Nhan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtNguoi_Ky_Nhan As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnLay_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnXac_Nhan_Tui As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtMa_Hieu_Phuong_Tien As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSo_Hieu_BC37 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dgGiaoTuiDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cbNgayDong As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGio_Dinh_Dang As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents dgGiaoTuiDi1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents CbTruc_Duong_Thu As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbMa_Bc_Gui As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbMa_Bc_Nhan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbPhuong_Tien_Van_Chuyen As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbThoi_Gian_Giao_Nhan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents chkChon_Tat1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cbDoi_Tac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnIn_Bc37 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSo_Ban As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkLua_Chon_Truyen As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuu_Cuc_Gui As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGio_Gui As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TimeClock As System.Windows.Forms.Timer
    Friend WithEvents CbTruc_Duong_Thu_Giao As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblSo_Hieu_BC37 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkTuyen_Duong_Thu As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnNhap_Moi_Bc37 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnNhap_Moi_E2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblGiaoTuiDi As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblGiaoTuiDi1 As Infragistics.Win.Misc.UltraLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_NUMBER")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_NUMBER")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Khai_Thac")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPO")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chang")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Goc")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Dich")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Bc_Dich")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cap_Bc_Dich")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Di")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Den")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROUD_MAP_ID")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROVINCE")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROUD_MAP_ID")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROVINCE")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_CODE")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ADDRESS")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PHONE_NUMBER")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TAX")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ACCOUNT_NUMBER")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BANK_NAME")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_OF_PC")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTACT_PHONE_NUMBER")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_NUMBER")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WHERE")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DATE")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_ID_CONTACT")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_PARTNER")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_LOCK")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmXacNhanBC37Den))
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txtGio_Dinh_Dang = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.chkChon_Tat1 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnDel = New Infragistics.Win.Misc.UltraButton
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton
        Me.chkChon_Tat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.lblGiaoTuiDi1 = New Infragistics.Win.Misc.UltraLabel
        Me.dgGiaoTuiDi1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.lblGiaoTuiDi = New Infragistics.Win.Misc.UltraLabel
        Me.dgGiaoTuiDi = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.chkTuyen_Duong_Thu = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.chkBuu_Cuc_Gui = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.cbMa_Bc_Nhan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbMa_Bc_Gui = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CbTruc_Duong_Thu = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbNgayDong = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnLay_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.txtGio_Gui = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.CbTruc_Duong_Thu_Giao = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.cbDoi_Tac = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.cbThoi_Gian_Giao_Nhan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.cbPhuong_Tien_Van_Chuyen = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtMa_Hieu_Phuong_Tien = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.txtNguoi_Ky_Nhan = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnXac_Nhan = New Infragistics.Win.Misc.UltraButton
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox
        Me.lblSo_Hieu_BC37 = New Infragistics.Win.Misc.UltraLabel
        Me.btnNhap_Moi_E2 = New Infragistics.Win.Misc.UltraButton
        Me.btnNhap_Moi_Bc37 = New Infragistics.Win.Misc.UltraButton
        Me.txtSo_Hieu_BC37 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnXac_Nhan_Tui = New Infragistics.Win.Misc.UltraButton
        Me.btnIn_Bc37 = New Infragistics.Win.Misc.UltraButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSo_Ban = New System.Windows.Forms.NumericUpDown
        Me.chkLua_Chon_Truyen = New System.Windows.Forms.CheckBox
        Me.TimeClock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTruc_Duong_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.txtGio_Gui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTruc_Duong_Thu_Giao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDoi_Tac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbThoi_Gian_Giao_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPhuong_Tien_Van_Chuyen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_Hieu_Phuong_Tien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNguoi_Ky_Nhan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(340, 278)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDinhDang.TabIndex = 18
        Me.dtpNgayDinhDang.Value = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'txtGio_Dinh_Dang
        '
        Me.txtGio_Dinh_Dang.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtGio_Dinh_Dang.DisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        Me.txtGio_Dinh_Dang.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtGio_Dinh_Dang.InputMask = "##:##"
        Me.txtGio_Dinh_Dang.Location = New System.Drawing.Point(340, 278)
        Me.txtGio_Dinh_Dang.Name = "txtGio_Dinh_Dang"
        Me.txtGio_Dinh_Dang.Size = New System.Drawing.Size(88, 20)
        Me.txtGio_Dinh_Dang.TabIndex = 19
        Me.txtGio_Dinh_Dang.Text = ":"
        Me.txtGio_Dinh_Dang.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.chkChon_Tat1)
        Me.UltraGroupBox1.Controls.Add(Me.btnDel)
        Me.UltraGroupBox1.Controls.Add(Me.btnAdd)
        Me.UltraGroupBox1.Controls.Add(Me.chkChon_Tat)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 80)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(768, 320)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 2
        '
        'chkChon_Tat1
        '
        Appearance1.ForeColor = System.Drawing.Color.Black
        Me.chkChon_Tat1.Appearance = Appearance1
        Me.chkChon_Tat1.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat1.Checked = True
        Me.chkChon_Tat1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat1.Location = New System.Drawing.Point(407, 30)
        Me.chkChon_Tat1.Name = "chkChon_Tat1"
        Me.chkChon_Tat1.Size = New System.Drawing.Size(13, 13)
        Me.chkChon_Tat1.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(368, 152)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 24)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "<<"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(368, 120)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 24)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = ">>"
        '
        'chkChon_Tat
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.chkChon_Tat.Appearance = Appearance2
        Me.chkChon_Tat.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat.Checked = True
        Me.chkChon_Tat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat.Location = New System.Drawing.Point(16, 30)
        Me.chkChon_Tat.Name = "chkChon_Tat"
        Me.chkChon_Tat.Size = New System.Drawing.Size(13, 13)
        Me.chkChon_Tat.TabIndex = 2
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.lblGiaoTuiDi1)
        Me.UltraGroupBox3.Controls.Add(Me.dgGiaoTuiDi1)
        Me.UltraGroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Appearance3.FontData.BoldAsString = "True"
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox3.HeaderAppearance = Appearance3
        Me.UltraGroupBox3.Location = New System.Drawing.Point(400, 8)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(360, 312)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 3
        Me.UltraGroupBox3.Text = "Danh sách BC37 xác nhận đến"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblGiaoTuiDi1
        '
        Appearance4.BackColor = System.Drawing.Color.Black
        Appearance4.ForeColor = System.Drawing.Color.White
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance4.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.lblGiaoTuiDi1.Appearance = Appearance4
        Me.lblGiaoTuiDi1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGiaoTuiDi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiaoTuiDi1.Location = New System.Drawing.Point(2, 294)
        Me.lblGiaoTuiDi1.Name = "lblGiaoTuiDi1"
        Me.lblGiaoTuiDi1.Size = New System.Drawing.Size(356, 16)
        Me.lblGiaoTuiDi1.TabIndex = 20
        '
        'dgGiaoTuiDi1
        '
        Me.dgGiaoTuiDi1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi1.DisplayLayout.Appearance = Appearance5
        UltraGridBand1.CardSettings.ShowCaption = False
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn1.CellAppearance = Appearance6
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance7
        UltraGridColumn1.Header.Caption = ""
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(22, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance8
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance9
        UltraGridColumn3.Header.Caption = "Số hiệu BC37"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance10
        UltraGridColumn4.Header.Caption = "Id Đường Thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance11
        UltraGridColumn5.Header.Caption = "Id ca"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance12
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance13
        UltraGridColumn6.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance15
        UltraGridColumn7.Header.Caption = "Mã bưu cục"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.CellAppearance = Appearance16
        UltraGridColumn8.EditorControl = Me.dtpNgayDinhDang
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance17
        UltraGridColumn8.Header.Caption = "Ngày lập"
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn8.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn8.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.UseEditorMaskSettings = True
        UltraGridColumn9.EditorControl = Me.txtGio_Dinh_Dang
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance18
        UltraGridColumn9.Header.Caption = "Giờ lập"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.UseEditorMaskSettings = True
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn10.CellAppearance = Appearance19
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance20
        UltraGridColumn10.Header.Caption = "Đợt giao"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance21
        UltraGridColumn11.Header.Caption = "Ngày giao"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance22
        UltraGridColumn12.Header.Caption = "Giờ giao"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn13.CellAppearance = Appearance23
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance24
        UltraGridColumn13.Header.Caption = "Chuyến thư"
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance25
        UltraGridColumn14.Header.Caption = "Id người dùng"
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance26
        UltraGridColumn15.Header.Caption = "Ngày hệ thống"
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance27
        UltraGridColumn16.Header.Caption = "Giờ hệ thống"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance28
        UltraGridColumn17.Header.Caption = "Đã in"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance29
        UltraGridColumn18.Header.Caption = "Chốt số liệu"
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance30
        UltraGridColumn19.Header.Caption = "Truyền khai thác"
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance31
        UltraGridColumn20.Header.VisiblePosition = 22
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance32
        UltraGridColumn21.Header.VisiblePosition = 19
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance33
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn24.CellAppearance = Appearance34
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance35
        UltraGridColumn24.Header.Caption = "Khối lượng"
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn25.CellAppearance = Appearance36
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance37
        UltraGridColumn25.Header.Caption = "Tổng số BP"
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn27.CellAppearance = Appearance38
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance39
        UltraGridColumn27.Header.Caption = "Tổng số túi"
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.CellAppearance = Appearance40
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance41
        UltraGridColumn28.Header.Caption = "Chuyển tiếp"
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn29.CellAppearance = Appearance42
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance43
        UltraGridColumn29.Header.Caption = "Tổng khối lượng"
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance44.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance44
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgGiaoTuiDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgGiaoTuiDi1.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.CardAreaAppearance = Appearance45
        Me.dgGiaoTuiDi1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance46.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance46.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance46.ForeColor = System.Drawing.Color.Black
        Appearance46.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance46.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance47.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowAppearance = Appearance47
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorAppearance = Appearance48
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance49.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance49.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectedRowAppearance = Appearance49
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi1.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi1.Name = "dgGiaoTuiDi1"
        Me.dgGiaoTuiDi1.Size = New System.Drawing.Size(356, 278)
        Me.dgGiaoTuiDi1.TabIndex = 18
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.lblGiaoTuiDi)
        Me.UltraGroupBox2.Controls.Add(Me.dgGiaoTuiDi)
        Me.UltraGroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Appearance50.FontData.BoldAsString = "True"
        Appearance50.ForeColor = System.Drawing.Color.Black
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox2.HeaderAppearance = Appearance50
        Me.UltraGroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(360, 312)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.Text = "Danh sách BC37 đến"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblGiaoTuiDi
        '
        Appearance51.BackColor = System.Drawing.Color.Black
        Appearance51.ForeColor = System.Drawing.Color.White
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance51.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.lblGiaoTuiDi.Appearance = Appearance51
        Me.lblGiaoTuiDi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGiaoTuiDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiaoTuiDi.Location = New System.Drawing.Point(2, 294)
        Me.lblGiaoTuiDi.Name = "lblGiaoTuiDi"
        Me.lblGiaoTuiDi.Size = New System.Drawing.Size(356, 16)
        Me.lblGiaoTuiDi.TabIndex = 19
        '
        'dgGiaoTuiDi
        '
        Me.dgGiaoTuiDi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance52.BackColor = System.Drawing.Color.White
        Appearance52.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi.DisplayLayout.Appearance = Appearance52
        UltraGridBand2.CardSettings.ShowCaption = False
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn30.CellAppearance = Appearance53
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance54
        UltraGridColumn30.Header.Caption = ""
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(23, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance55
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance56
        UltraGridColumn32.Header.Caption = "Số hiệu BC37"
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance57
        UltraGridColumn33.Header.Caption = "Id Đường Thư"
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance58
        UltraGridColumn34.Header.Caption = "Id ca"
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.CellAppearance = Appearance59
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance60
        UltraGridColumn35.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.CellAppearance = Appearance61
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance62
        UltraGridColumn36.Header.Caption = "Mã bưu cục"
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.CellAppearance = Appearance63
        UltraGridColumn37.EditorControl = Me.dtpNgayDinhDang
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance64
        UltraGridColumn37.Header.Caption = "Ngày lập"
        UltraGridColumn37.Header.VisiblePosition = 6
        UltraGridColumn37.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.UseEditorMaskSettings = True
        UltraGridColumn38.EditorControl = Me.txtGio_Dinh_Dang
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance65
        UltraGridColumn38.Header.Caption = "Giờ lập"
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.UseEditorMaskSettings = True
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn39.CellAppearance = Appearance66
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance67
        UltraGridColumn39.Header.Caption = "Đợt giao"
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance68
        UltraGridColumn40.Header.Caption = "Ngày giao"
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn41.Header.Appearance = Appearance69
        UltraGridColumn41.Header.Caption = "Giờ giao"
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn42.CellAppearance = Appearance70
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance71
        UltraGridColumn42.Header.Caption = "Chuyến thư"
        UltraGridColumn42.Header.VisiblePosition = 14
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance72
        UltraGridColumn43.Header.Caption = "Id người dùng"
        UltraGridColumn43.Header.VisiblePosition = 12
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance73
        UltraGridColumn44.Header.Caption = "Ngày hệ thống"
        UltraGridColumn44.Header.VisiblePosition = 13
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance74
        UltraGridColumn45.Header.Caption = "Giờ hệ thống"
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance75
        UltraGridColumn46.Header.Caption = "Đã in"
        UltraGridColumn46.Header.VisiblePosition = 16
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance76
        UltraGridColumn47.Header.Caption = "Chốt số liệu"
        UltraGridColumn47.Header.VisiblePosition = 17
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance77
        UltraGridColumn48.Header.Caption = "Truyền khai thác"
        UltraGridColumn48.Header.VisiblePosition = 18
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance78
        UltraGridColumn49.Header.VisiblePosition = 22
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance79.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance79
        UltraGridColumn50.Header.VisiblePosition = 19
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 20
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance80
        UltraGridColumn52.Header.VisiblePosition = 21
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn53.CellAppearance = Appearance81
        Appearance82.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance82
        UltraGridColumn53.Header.Caption = "Tổng số BP"
        UltraGridColumn53.Header.VisiblePosition = 24
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn54.CellAppearance = Appearance83
        Appearance84.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance84
        UltraGridColumn54.Header.Caption = "Khối lượng"
        UltraGridColumn54.Header.VisiblePosition = 23
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn55.Header.VisiblePosition = 25
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance85.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn56.CellAppearance = Appearance85
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance86
        UltraGridColumn56.Header.Caption = "Tổng số túi"
        UltraGridColumn56.Header.VisiblePosition = 26
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.CellAppearance = Appearance87
        Appearance88.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance88
        UltraGridColumn57.Header.Caption = "Chuyển tiếp"
        UltraGridColumn57.Header.VisiblePosition = 27
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance89.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn58.CellAppearance = Appearance89
        Appearance90.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance90
        UltraGridColumn58.Header.Caption = "Tổng khối lượng"
        UltraGridColumn58.Header.VisiblePosition = 28
        UltraGridColumn58.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance91.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand2.Override.RowSelectorAppearance = Appearance91
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgGiaoTuiDi.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgGiaoTuiDi.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.dgGiaoTuiDi.DisplayLayout.Override.BorderStyleSummaryFooter = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.CardAreaAppearance = Appearance92
        Me.dgGiaoTuiDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance93.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance93.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance93.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance93.ForeColor = System.Drawing.Color.Black
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance93.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderAppearance = Appearance93
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance94.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowAppearance = Appearance94
        Appearance95.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance95.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance95.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorAppearance = Appearance95
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance96.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance96.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance96.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectedRowAppearance = Appearance96
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi.Name = "dgGiaoTuiDi"
        Me.dgGiaoTuiDi.Size = New System.Drawing.Size(356, 278)
        Me.dgGiaoTuiDi.TabIndex = 17
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.chkTuyen_Duong_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.btnThoat)
        Me.UltraGroupBox4.Controls.Add(Me.chkBuu_Cuc_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Nhan)
        Me.UltraGroupBox4.Controls.Add(Me.cbMa_Bc_Gui)
        Me.UltraGroupBox4.Controls.Add(Me.CbTruc_Duong_Thu)
        Me.UltraGroupBox4.Controls.Add(Me.cbNgayDong)
        Me.UltraGroupBox4.Controls.Add(Me.btnLay_Du_Lieu)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance97.FontData.BoldAsString = "True"
        Appearance97.ForeColor = System.Drawing.Color.Black
        Appearance97.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox4.HeaderAppearance = Appearance97
        Me.UltraGroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(752, 72)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.Text = "Thông tin tìm kiếm"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.BackColor = System.Drawing.Color.White
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel6.Location = New System.Drawing.Point(368, 24)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Bưu cục nhận"
        '
        'chkTuyen_Duong_Thu
        '
        Me.chkTuyen_Duong_Thu.BackColor = System.Drawing.Color.White
        Me.chkTuyen_Duong_Thu.Location = New System.Drawing.Point(112, 24)
        Me.chkTuyen_Duong_Thu.Name = "chkTuyen_Duong_Thu"
        Me.chkTuyen_Duong_Thu.Size = New System.Drawing.Size(112, 16)
        Me.chkTuyen_Duong_Thu.TabIndex = 18
        Me.chkTuyen_Duong_Thu.Text = "Tuyến đường thư"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(600, 32)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(112, 32)
        Me.btnThoat.TabIndex = 17
        Me.btnThoat.Text = "Thoát (ESC)"
        '
        'chkBuu_Cuc_Gui
        '
        Me.chkBuu_Cuc_Gui.BackColor = System.Drawing.Color.White
        Me.chkBuu_Cuc_Gui.Location = New System.Drawing.Point(248, 24)
        Me.chkBuu_Cuc_Gui.Name = "chkBuu_Cuc_Gui"
        Me.chkBuu_Cuc_Gui.Size = New System.Drawing.Size(112, 16)
        Me.chkBuu_Cuc_Gui.TabIndex = 5
        Me.chkBuu_Cuc_Gui.Text = "Bưu cục gửi"
        '
        'cbMa_Bc_Nhan
        '
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Nhan.Appearance = Appearance98
        Me.cbMa_Bc_Nhan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance99.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Nhan.DisplayLayout.Appearance = Appearance99
        UltraGridColumn59.Header.Caption = "Mã bưu cục"
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn60.Header.Caption = "Tên bưu cục"
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridColumn60.Width = 250
        UltraGridColumn61.Header.VisiblePosition = 2
        UltraGridColumn61.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn60, UltraGridColumn61})
        UltraGridBand3.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Nhan.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance100.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance100.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance100.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance100.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Nhan.DisplayLayout.Override.HeaderAppearance = Appearance100
        Me.cbMa_Bc_Nhan.DisplayMember = "Ma_Bc_Khai_Thac"
        Me.cbMa_Bc_Nhan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Nhan.LimitToList = True
        Me.cbMa_Bc_Nhan.Location = New System.Drawing.Point(368, 40)
        Me.cbMa_Bc_Nhan.Name = "cbMa_Bc_Nhan"
        Me.cbMa_Bc_Nhan.Size = New System.Drawing.Size(104, 21)
        Me.cbMa_Bc_Nhan.TabIndex = 3
        Me.cbMa_Bc_Nhan.Text = "0"
        Me.cbMa_Bc_Nhan.ValueMember = "Ma_Bc_Khai_Thac"
        '
        'cbMa_Bc_Gui
        '
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbMa_Bc_Gui.Appearance = Appearance101
        Me.cbMa_Bc_Gui.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance102.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbMa_Bc_Gui.DisplayLayout.Appearance = Appearance102
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance103
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridColumn62.Hidden = True
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance104
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridColumn63.Hidden = True
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance105
        UltraGridColumn64.Header.Caption = "Mã bưu cục"
        UltraGridColumn64.Header.VisiblePosition = 2
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.Header.Appearance = Appearance106
        UltraGridColumn65.Header.Caption = "Tên bưu cục"
        UltraGridColumn65.Header.VisiblePosition = 3
        UltraGridColumn65.Width = 250
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn66.Header.Appearance = Appearance107
        UltraGridColumn66.Header.VisiblePosition = 4
        UltraGridColumn66.Hidden = True
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn67.Header.Appearance = Appearance108
        UltraGridColumn67.Header.VisiblePosition = 5
        UltraGridColumn67.Hidden = True
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn68.Header.Appearance = Appearance109
        UltraGridColumn68.Header.VisiblePosition = 6
        UltraGridColumn68.Hidden = True
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.Header.Appearance = Appearance110
        UltraGridColumn69.Header.VisiblePosition = 7
        UltraGridColumn69.Hidden = True
        Appearance111.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance111
        UltraGridColumn70.Header.VisiblePosition = 8
        UltraGridColumn70.Hidden = True
        Appearance112.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance112
        UltraGridColumn71.Header.VisiblePosition = 9
        UltraGridColumn71.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71})
        UltraGridBand4.Header.Caption = "Mã Đường Thư"
        Me.cbMa_Bc_Gui.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance113.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance113.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance113.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance113.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance113.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Bc_Gui.DisplayLayout.Override.HeaderAppearance = Appearance113
        Me.cbMa_Bc_Gui.DisplayMember = "Ma_Bc_Goc"
        Me.cbMa_Bc_Gui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMa_Bc_Gui.LimitToList = True
        Me.cbMa_Bc_Gui.Location = New System.Drawing.Point(248, 40)
        Me.cbMa_Bc_Gui.Name = "cbMa_Bc_Gui"
        Me.cbMa_Bc_Gui.Size = New System.Drawing.Size(112, 21)
        Me.cbMa_Bc_Gui.TabIndex = 2
        Me.cbMa_Bc_Gui.Text = "0"
        Me.cbMa_Bc_Gui.ValueMember = "Ma_Bc_Goc"
        '
        'CbTruc_Duong_Thu
        '
        Appearance114.TextHAlign = Infragistics.Win.HAlign.Right
        Me.CbTruc_Duong_Thu.Appearance = Appearance114
        Me.CbTruc_Duong_Thu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance115.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.CbTruc_Duong_Thu.DisplayLayout.Appearance = Appearance115
        Appearance116.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance116
        UltraGridColumn72.Header.VisiblePosition = 0
        UltraGridColumn72.Hidden = True
        Appearance117.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.CellAppearance = Appearance117
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.Header.Appearance = Appearance118
        UltraGridColumn73.Header.Caption = "Mã tuyến"
        UltraGridColumn73.Header.VisiblePosition = 1
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance119
        UltraGridColumn74.Header.Caption = "Tên tuyến"
        UltraGridColumn74.Header.VisiblePosition = 2
        UltraGridColumn74.Width = 250
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance120
        UltraGridColumn75.Header.VisiblePosition = 3
        UltraGridColumn75.Hidden = True
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance121
        UltraGridColumn76.Header.VisiblePosition = 4
        UltraGridColumn76.Hidden = True
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance122
        UltraGridColumn77.Header.VisiblePosition = 5
        UltraGridColumn77.Hidden = True
        Appearance123.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance123
        UltraGridColumn78.Header.VisiblePosition = 6
        UltraGridColumn78.Hidden = True
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance124
        UltraGridColumn79.Header.VisiblePosition = 7
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 8
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 9
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 10
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 11
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 12
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 13
        UltraGridColumn85.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85})
        UltraGridBand5.Header.Caption = "Mã Đường Thư"
        Me.CbTruc_Duong_Thu.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance125.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance125.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance125.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance125.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance125.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTruc_Duong_Thu.DisplayLayout.Override.HeaderAppearance = Appearance125
        Me.CbTruc_Duong_Thu.DisplayMember = "Id_Tuyen_Char"
        Me.CbTruc_Duong_Thu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTruc_Duong_Thu.LimitToList = True
        Me.CbTruc_Duong_Thu.Location = New System.Drawing.Point(112, 40)
        Me.CbTruc_Duong_Thu.Name = "CbTruc_Duong_Thu"
        Me.CbTruc_Duong_Thu.Size = New System.Drawing.Size(128, 21)
        Me.CbTruc_Duong_Thu.TabIndex = 1
        Me.CbTruc_Duong_Thu.ValueMember = "Id_Tuyen"
        '
        'cbNgayDong
        '
        Me.cbNgayDong.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbNgayDong.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbNgayDong.Location = New System.Drawing.Point(8, 40)
        Me.cbNgayDong.Name = "cbNgayDong"
        Me.cbNgayDong.Size = New System.Drawing.Size(99, 21)
        Me.cbNgayDong.TabIndex = 0
        Me.cbNgayDong.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'btnLay_Du_Lieu
        '
        Me.btnLay_Du_Lieu.Location = New System.Drawing.Point(480, 32)
        Me.btnLay_Du_Lieu.Name = "btnLay_Du_Lieu"
        Me.btnLay_Du_Lieu.Size = New System.Drawing.Size(112, 32)
        Me.btnLay_Du_Lieu.TabIndex = 4
        Me.btnLay_Du_Lieu.Text = "Lấy dữ liệu (F1)"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.BackColor = System.Drawing.Color.White
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel9.Location = New System.Drawing.Point(8, 24)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel9.TabIndex = 16
        Me.UltraLabel9.Text = "Ngày giao :"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.txtGio_Gui)
        Me.UltraGroupBox5.Controls.Add(Me.CbTruc_Duong_Thu_Giao)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox5.Controls.Add(Me.cbDoi_Tac)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox5.Controls.Add(Me.cbThoi_Gian_Giao_Nhan)
        Me.UltraGroupBox5.Controls.Add(Me.cbPhuong_Tien_Van_Chuyen)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox5.Controls.Add(Me.txtMa_Hieu_Phuong_Tien)
        Me.UltraGroupBox5.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox5.Controls.Add(Me.txtNguoi_Ky_Nhan)
        Me.UltraGroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance126.FontData.BoldAsString = "True"
        Appearance126.ForeColor = System.Drawing.Color.Black
        Appearance126.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox5.HeaderAppearance = Appearance126
        Me.UltraGroupBox5.Location = New System.Drawing.Point(8, 456)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(752, 88)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 5
        Me.UltraGroupBox5.Text = "Thông tin giao nhận"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtGio_Gui
        '
        Me.txtGio_Gui.Location = New System.Drawing.Point(352, 24)
        Me.txtGio_Gui.Name = "txtGio_Gui"
        Me.txtGio_Gui.Size = New System.Drawing.Size(40, 21)
        Me.txtGio_Gui.TabIndex = 1
        '
        'CbTruc_Duong_Thu_Giao
        '
        Appearance127.TextHAlign = Infragistics.Win.HAlign.Right
        Me.CbTruc_Duong_Thu_Giao.Appearance = Appearance127
        Me.CbTruc_Duong_Thu_Giao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance128.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.CbTruc_Duong_Thu_Giao.DisplayLayout.Appearance = Appearance128
        Appearance129.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance129
        UltraGridColumn86.Header.VisiblePosition = 0
        UltraGridColumn86.Hidden = True
        Appearance130.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.CellAppearance = Appearance130
        Appearance131.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance131
        UltraGridColumn87.Header.Caption = "Mã tuyến"
        UltraGridColumn87.Header.VisiblePosition = 1
        Appearance132.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance132
        UltraGridColumn88.Header.Caption = "Tên tuyến"
        UltraGridColumn88.Header.VisiblePosition = 2
        UltraGridColumn88.Width = 250
        Appearance133.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance133
        UltraGridColumn89.Header.VisiblePosition = 3
        UltraGridColumn89.Hidden = True
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance134
        UltraGridColumn90.Header.VisiblePosition = 4
        UltraGridColumn90.Hidden = True
        Appearance135.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance135
        UltraGridColumn91.Header.VisiblePosition = 5
        UltraGridColumn91.Hidden = True
        Appearance136.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance136
        UltraGridColumn92.Header.VisiblePosition = 6
        UltraGridColumn92.Hidden = True
        Appearance137.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance137
        UltraGridColumn93.Header.VisiblePosition = 7
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 8
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 9
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 10
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 11
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 12
        UltraGridColumn98.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98})
        UltraGridBand6.Header.Caption = "Mã Đường Thư"
        Me.CbTruc_Duong_Thu_Giao.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance138.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance138.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance138.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance138.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbTruc_Duong_Thu_Giao.DisplayLayout.Override.HeaderAppearance = Appearance138
        Me.CbTruc_Duong_Thu_Giao.DisplayMember = "Id_Tuyen_Char"
        Me.CbTruc_Duong_Thu_Giao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTruc_Duong_Thu_Giao.Location = New System.Drawing.Point(112, 56)
        Me.CbTruc_Duong_Thu_Giao.Name = "CbTruc_Duong_Thu_Giao"
        Me.CbTruc_Duong_Thu_Giao.Size = New System.Drawing.Size(128, 21)
        Me.CbTruc_Duong_Thu_Giao.TabIndex = 13
        Me.CbTruc_Duong_Thu_Giao.ValueMember = "Id_Tuyen"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.BackColor = System.Drawing.Color.White
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel5.Location = New System.Drawing.Point(8, 56)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(99, 14)
        Me.UltraLabel5.TabIndex = 12
        Me.UltraLabel5.Text = "Tuyến đường thư :"
        '
        'cbDoi_Tac
        '
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDoi_Tac.Appearance = Appearance139
        Me.cbDoi_Tac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance140.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDoi_Tac.DisplayLayout.Appearance = Appearance140
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance141
        UltraGridColumn99.Header.VisiblePosition = 5
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn99.Width = 50
        Appearance142.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance142
        UltraGridColumn100.Header.Caption = "Mã"
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn100.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn100.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn100.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn100.Width = 80
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.Header.Appearance = Appearance143
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.Hidden = True
        Appearance144.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.Header.Appearance = Appearance144
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridColumn102.Hidden = True
        Appearance145.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance145
        UltraGridColumn103.Header.VisiblePosition = 3
        UltraGridColumn103.Hidden = True
        Appearance146.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance146
        UltraGridColumn104.Header.VisiblePosition = 4
        UltraGridColumn104.Hidden = True
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance147
        UltraGridColumn105.Header.VisiblePosition = 6
        UltraGridColumn105.Hidden = True
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance148
        UltraGridColumn106.Header.Caption = "Đối tác"
        UltraGridColumn106.Header.VisiblePosition = 7
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn106.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn106.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn106.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn106.Width = 200
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance149
        UltraGridColumn107.Header.VisiblePosition = 8
        UltraGridColumn107.Hidden = True
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance150
        UltraGridColumn108.Header.VisiblePosition = 9
        UltraGridColumn108.Hidden = True
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance151
        UltraGridColumn109.Header.VisiblePosition = 10
        UltraGridColumn109.Hidden = True
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance152
        UltraGridColumn110.Header.VisiblePosition = 11
        UltraGridColumn110.Hidden = True
        Appearance153.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance153
        UltraGridColumn111.Header.VisiblePosition = 12
        UltraGridColumn111.Hidden = True
        Appearance154.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.Header.Appearance = Appearance154
        UltraGridColumn112.Header.Caption = "Tên"
        UltraGridColumn112.Header.VisiblePosition = 13
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.Width = 250
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance155
        UltraGridColumn113.Header.Caption = "Tên đối tác"
        UltraGridColumn113.Header.VisiblePosition = 14
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(143, 0)
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        UltraGridBand7.Header.Caption = "Mã Đường Thư"
        UltraGridBand7.UseRowLayout = True
        Me.cbDoi_Tac.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance156.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance156.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance156.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance156.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDoi_Tac.DisplayLayout.Override.HeaderAppearance = Appearance156
        Me.cbDoi_Tac.DisplayMember = "PARTNER_CODE"
        Me.cbDoi_Tac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoi_Tac.Location = New System.Drawing.Point(616, 24)
        Me.cbDoi_Tac.Name = "cbDoi_Tac"
        Me.cbDoi_Tac.Size = New System.Drawing.Size(128, 21)
        Me.cbDoi_Tac.TabIndex = 3
        Me.cbDoi_Tac.ValueMember = "ID"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.BackColor = System.Drawing.Color.White
        Me.UltraLabel10.Location = New System.Drawing.Point(544, 26)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel10.TabIndex = 11
        Me.UltraLabel10.Text = "Đối tác VC :"
        '
        'cbThoi_Gian_Giao_Nhan
        '
        Me.cbThoi_Gian_Giao_Nhan.DateTime = New Date(2008, 9, 9, 0, 0, 0, 0)
        Me.cbThoi_Gian_Giao_Nhan.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbThoi_Gian_Giao_Nhan.Location = New System.Drawing.Point(400, 24)
        Me.cbThoi_Gian_Giao_Nhan.Name = "cbThoi_Gian_Giao_Nhan"
        Me.cbThoi_Gian_Giao_Nhan.Size = New System.Drawing.Size(96, 21)
        Me.cbThoi_Gian_Giao_Nhan.TabIndex = 2
        Me.cbThoi_Gian_Giao_Nhan.Value = New Date(2008, 9, 9, 0, 0, 0, 0)
        '
        'cbPhuong_Tien_Van_Chuyen
        '
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbPhuong_Tien_Van_Chuyen.Appearance = Appearance157
        Me.cbPhuong_Tien_Van_Chuyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance158.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbPhuong_Tien_Van_Chuyen.DisplayLayout.Appearance = Appearance158
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn114.CellAppearance = Appearance159
        Appearance160.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance160
        UltraGridColumn114.Header.Caption = "Mã"
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn114.Width = 80
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.Header.Appearance = Appearance161
        UltraGridColumn115.Header.Caption = "Tên phương tiện"
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn115.Width = 250
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn116.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115, UltraGridColumn116})
        UltraGridBand8.Header.Caption = "Mã Đường Thư"
        Me.cbPhuong_Tien_Van_Chuyen.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance162.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance162.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance162.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance162.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance162.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbPhuong_Tien_Van_Chuyen.DisplayLayout.Override.HeaderAppearance = Appearance162
        Me.cbPhuong_Tien_Van_Chuyen.DisplayMember = "NAME"
        Me.cbPhuong_Tien_Van_Chuyen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhuong_Tien_Van_Chuyen.Location = New System.Drawing.Point(352, 56)
        Me.cbPhuong_Tien_Van_Chuyen.Name = "cbPhuong_Tien_Van_Chuyen"
        Me.cbPhuong_Tien_Van_Chuyen.Size = New System.Drawing.Size(144, 21)
        Me.cbPhuong_Tien_Van_Chuyen.TabIndex = 4
        Me.cbPhuong_Tien_Van_Chuyen.ValueMember = "ID"
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.BackColor = System.Drawing.Color.White
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UltraLabel4.Location = New System.Drawing.Point(264, 28)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "Thời gian giao :"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.BackColor = System.Drawing.Color.White
        Me.UltraLabel3.Location = New System.Drawing.Point(256, 56)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(89, 14)
        Me.UltraLabel3.TabIndex = 7
        Me.UltraLabel3.Text = "Phương tiện VC :"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.BackColor = System.Drawing.Color.White
        Me.UltraLabel2.Location = New System.Drawing.Point(512, 60)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Mã phương tiện :"
        '
        'txtMa_Hieu_Phuong_Tien
        '
        Me.txtMa_Hieu_Phuong_Tien.Location = New System.Drawing.Point(616, 56)
        Me.txtMa_Hieu_Phuong_Tien.Name = "txtMa_Hieu_Phuong_Tien"
        Me.txtMa_Hieu_Phuong_Tien.Size = New System.Drawing.Size(128, 21)
        Me.txtMa_Hieu_Phuong_Tien.TabIndex = 5
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Location = New System.Drawing.Point(16, 28)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Người ký nhận :"
        '
        'txtNguoi_Ky_Nhan
        '
        Me.txtNguoi_Ky_Nhan.Location = New System.Drawing.Point(112, 24)
        Me.txtNguoi_Ky_Nhan.Name = "txtNguoi_Ky_Nhan"
        Me.txtNguoi_Ky_Nhan.Size = New System.Drawing.Size(128, 21)
        Me.txtNguoi_Ky_Nhan.TabIndex = 0
        '
        'btnXac_Nhan
        '
        Me.btnXac_Nhan.Location = New System.Drawing.Point(456, 546)
        Me.btnXac_Nhan.Name = "btnXac_Nhan"
        Me.btnXac_Nhan.Size = New System.Drawing.Size(112, 32)
        Me.btnXac_Nhan.TabIndex = 8
        Me.btnXac_Nhan.Text = "Xác nhận (F2)"
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.lblSo_Hieu_BC37)
        Me.UltraGroupBox6.Controls.Add(Me.btnNhap_Moi_E2)
        Me.UltraGroupBox6.Controls.Add(Me.btnNhap_Moi_Bc37)
        Me.UltraGroupBox6.Controls.Add(Me.txtSo_Hieu_BC37)
        Me.UltraGroupBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance163.FontData.BoldAsString = "True"
        Appearance163.ForeColor = System.Drawing.Color.Black
        Appearance163.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox6.HeaderAppearance = Appearance163
        Me.UltraGroupBox6.Location = New System.Drawing.Point(8, 400)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(752, 56)
        Me.UltraGroupBox6.SupportThemes = False
        Me.UltraGroupBox6.TabIndex = 4
        Me.UltraGroupBox6.Text = "Số hiệu BC37"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblSo_Hieu_BC37
        '
        Me.lblSo_Hieu_BC37.BackColor = System.Drawing.Color.White
        Me.lblSo_Hieu_BC37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_Hieu_BC37.Location = New System.Drawing.Point(400, 24)
        Me.lblSo_Hieu_BC37.Name = "lblSo_Hieu_BC37"
        Me.lblSo_Hieu_BC37.Size = New System.Drawing.Size(344, 24)
        Me.lblSo_Hieu_BC37.TabIndex = 2
        '
        'btnNhap_Moi_E2
        '
        Me.btnNhap_Moi_E2.Location = New System.Drawing.Point(648, 18)
        Me.btnNhap_Moi_E2.Name = "btnNhap_Moi_E2"
        Me.btnNhap_Moi_E2.Size = New System.Drawing.Size(104, 36)
        Me.btnNhap_Moi_E2.TabIndex = 19
        Me.btnNhap_Moi_E2.Text = "Nhập mới túi gói"
        Me.btnNhap_Moi_E2.Visible = False
        '
        'btnNhap_Moi_Bc37
        '
        Me.btnNhap_Moi_Bc37.Location = New System.Drawing.Point(256, 18)
        Me.btnNhap_Moi_Bc37.Name = "btnNhap_Moi_Bc37"
        Me.btnNhap_Moi_Bc37.Size = New System.Drawing.Size(104, 36)
        Me.btnNhap_Moi_Bc37.TabIndex = 1
        Me.btnNhap_Moi_Bc37.Text = "Nhập mới BC37"
        '
        'txtSo_Hieu_BC37
        '
        Appearance164.BackColor = System.Drawing.Color.White
        Appearance164.ForeColor = System.Drawing.Color.Green
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance164.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtSo_Hieu_BC37.Appearance = Appearance164
        Me.txtSo_Hieu_BC37.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_Hieu_BC37.Location = New System.Drawing.Point(8, 20)
        Me.txtSo_Hieu_BC37.Multiline = True
        Me.txtSo_Hieu_BC37.Name = "txtSo_Hieu_BC37"
        Me.txtSo_Hieu_BC37.Size = New System.Drawing.Size(248, 30)
        Me.txtSo_Hieu_BC37.TabIndex = 0
        '
        'btnXac_Nhan_Tui
        '
        Me.btnXac_Nhan_Tui.Location = New System.Drawing.Point(336, 546)
        Me.btnXac_Nhan_Tui.Name = "btnXac_Nhan_Tui"
        Me.btnXac_Nhan_Tui.Size = New System.Drawing.Size(112, 32)
        Me.btnXac_Nhan_Tui.TabIndex = 7
        Me.btnXac_Nhan_Tui.Text = "Xác nhận túi (F4)"
        '
        'btnIn_Bc37
        '
        Me.btnIn_Bc37.Location = New System.Drawing.Point(680, 546)
        Me.btnIn_Bc37.Name = "btnIn_Bc37"
        Me.btnIn_Bc37.Size = New System.Drawing.Size(80, 32)
        Me.btnIn_Bc37.TabIndex = 10
        Me.btnIn_Bc37.Text = "In BC37"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(576, 554)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Số bản"
        '
        'txtSo_Ban
        '
        Me.txtSo_Ban.Location = New System.Drawing.Point(632, 554)
        Me.txtSo_Ban.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtSo_Ban.Name = "txtSo_Ban"
        Me.txtSo_Ban.Size = New System.Drawing.Size(40, 20)
        Me.txtSo_Ban.TabIndex = 9
        Me.txtSo_Ban.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkLua_Chon_Truyen
        '
        Me.chkLua_Chon_Truyen.Checked = True
        Me.chkLua_Chon_Truyen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLua_Chon_Truyen.Location = New System.Drawing.Point(8, 552)
        Me.chkLua_Chon_Truyen.Name = "chkLua_Chon_Truyen"
        Me.chkLua_Chon_Truyen.Size = New System.Drawing.Size(136, 24)
        Me.chkLua_Chon_Truyen.TabIndex = 6
        Me.chkLua_Chon_Truyen.Text = "Xác nhận và truyền"
        '
        'TimeClock
        '
        Me.TimeClock.Enabled = True
        Me.TimeClock.Interval = 1000
        '
        'frmXacNhanBC37Den
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(768, 584)
        Me.Controls.Add(Me.chkLua_Chon_Truyen)
        Me.Controls.Add(Me.txtSo_Ban)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UltraGroupBox6)
        Me.Controls.Add(Me.UltraGroupBox5)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnIn_Bc37)
        Me.Controls.Add(Me.btnXac_Nhan_Tui)
        Me.Controls.Add(Me.btnXac_Nhan)
        Me.Controls.Add(Me.txtGio_Dinh_Dang)
        Me.Controls.Add(Me.dtpNgayDinhDang)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmXacNhanBC37Den"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác nhận BC37 đến"
        CType(Me.dtpNgayDinhDang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.dgGiaoTuiDi1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.dgGiaoTuiDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.cbMa_Bc_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Bc_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTruc_Duong_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNgayDong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.txtGio_Gui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTruc_Duong_Thu_Giao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDoi_Tac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbThoi_Gian_Giao_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPhuong_Tien_Van_Chuyen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_Hieu_Phuong_Tien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNguoi_Ky_Nhan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.txtSo_Hieu_BC37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSo_Ban, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myMa_Bc_Khai_Thac_Chi_Tiet As New Ma_Bc_Khai_Thac_Chi_Tiet
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
    Dim myChuyen_Thu_Den As New Chuyen_Thu_Den(GConnectionString)
    Dim myChuyen_Thu_Den_Chi_Tiet As New Chuyen_Thu_Den_Chi_Tiet
    Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    Dim myDanh_Muc_BC_Chi_Tiet As New Danh_Muc_BC_Chi_Tiet
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE2_Di_Chi_Tiet As New E2_Di_Chi_Tiet

    Dim myHam_Dung_Chung As New Ham_Dung_Chung

    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet
    Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
    Dim myQLTGND_CHANG_VC As New QLTGND_CHANG_VC(GConnectionString)
    Dim myQLTGND_CHANG_VC_Chi_Tiet As New QLTGND_CHANG_VC_Chi_Tiet
    Dim myQLTGND_PARTNER As New QLTGND_PARTNER(GConnectionString)
    Dim myQLTGND_PARTNER_Chi_Tiet As New QLTGND_PARTNER_Chi_Tiet
    Dim myQLTGND_TRANSPORT_TYPE As New QLTGND_TRANSPORT_TYPE(GConnectionString)
    Dim myQLTGND_TRANSPORT_TYPE_Chi_Tiet As New QLTGND_TRANSPORT_TYPE_Chi_Tiet

    Dim myQLTGND_BC37 As New QLTGND_BC37(GConnectionString)
    Dim myQLTGND_BC37_Chi_Tiet As New QLTGND_BC37_Chi_Tiet

    Dim myQLTGND_POSTBAG As New QLTGND_POSTBAG(GConnectionString)
    Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG(GConnectionString)
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

    Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
    Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

    Dim myQLTGND_MAIL_TRIP_TRANSPORT_BC37 As New QLTGND_MAIL_TRIP_TRANSPORT_BC37(GConnectionString)
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet
    Public myId_Tuyen_VC As Integer
    Public myTuyen_Van_Chuyen_Truyen_Form_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
#End Region

#Region "btnXac_Nhan_Tui_Click"
    Private Sub btnXac_Nhan_Tui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXac_Nhan_Tui.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        Dim mData As DataTable
        Dim frm As New frmXacNhanTuiDen
        If (dgGiaoTuiDi1.Rows.Count = 0) Then
            MessageBox.Show("Không có BC37 trong danh sách bạn không thể xác nhận túi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        mData = Tao_Bang_Chua_BC37_Da_Chon()
        frm.myTRANSPORT_TYPE = IIf(cbPhuong_Tien_Van_Chuyen.Value Is Nothing, "", CStr(cbPhuong_Tien_Van_Chuyen.Value))
        frm.myMAIL_ROUTE_ID = IIf(CbTruc_Duong_Thu_Giao.Value Is Nothing, 0, CInt(CbTruc_Duong_Thu_Giao.Value))
        frm.myPARTNER_ID = IIf(cbDoi_Tac.Value Is Nothing, 0, CInt(cbDoi_Tac.Value))
        frm.myDot_Giao = CInt(dgGiaoTuiDi1.Rows(0).Cells("Dot_Giao").Text)
        frm.myTRANSPORT_NUMBER = CStr(dgGiaoTuiDi1.Rows(0).Cells("TRANSPORT_NUMBER").Text)
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                'frm.myId_BC37 = dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Text
                Dim row As DataRow
                row = mData.NewRow()
                row("BC37_ID") = dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Text
                row("TRANSPORT_TYPE") = IIf(cbPhuong_Tien_Van_Chuyen.Value Is Nothing, "", CStr(cbPhuong_Tien_Van_Chuyen.Value))
                row("MAIL_ROUTE_ID") = IIf(CbTruc_Duong_Thu_Giao.Value Is Nothing, 0, CInt(CbTruc_Duong_Thu_Giao.Value))
                row("PARTNER_ID") = IIf(cbDoi_Tac.Value Is Nothing, 0, CInt(cbDoi_Tac.Value))
                row("Dot_Giao") = CInt(dgGiaoTuiDi1.Rows(i).Cells("Dot_Giao").Text)
                row("TRANSPORT_NUMBER") = CStr(dgGiaoTuiDi1.Rows(i).Cells("TRANSPORT_NUMBER").Text)
                mData.Rows.Add(row)
            End If
        Next
        If (mData.Rows.Count > 0) Then
            frm.myDataBC37Select = mData
            frm.ShowDialog()
        Else
            MessageBox.Show("Bạn chưa chọn BC37 để xác nhận túi gói", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub
#End Region

#Region "btnLay_Du_Lieu_Click"
    Private Sub btnLay_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLay_Du_Lieu.Click
        'Thông tin nhập không đầy đủ     
        If IsCorrectInfor(Ham_Dung_Chung.ConvertDateToInt(Me.cbNgayDong.Value), CInt(CbTruc_Duong_Thu.Value), CInt(cbMa_Bc_Gui.Text), CInt(cbMa_Bc_Nhan.Text)) = False Then Exit Sub
        'Hiển thị dữ liệu trên lưới
        Load_GiaoTuiDi()
        Load_GiaoTuiDi1()
        Enable_Control(True)
        ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
    End Sub
#End Region

#Region "Kiểm tra thông tin"
    Private Function IsCorrectInfor(Optional ByVal Ngay_Dong As Integer = 0, Optional ByVal Truc_Duong_Thu As Integer = 0, Optional ByVal Buu_Cuc_Gui As Integer = 0, Optional ByVal Buu_Cuc_Nhan As Integer = 0) As Boolean
        'Kiểm tra thông tin về ngày
        If (Ngay_Dong.ToString.Length = 0) Then
            CMessageBox.Show("Ngày đóng E2 chưa được xác định, xin mời nhập thông tin về ngày ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbNgayDong.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về trục đường thư
        If (Truc_Duong_Thu.ToString.Length = 0) Then
            CMessageBox.Show("Thông tin về trục đường thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CbTruc_Duong_Thu.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về bưu cục gửi
        If (Buu_Cuc_Gui.ToString.Length = 0) Then
            CMessageBox.Show("Thông tin về chuyến thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbMa_Bc_Gui.Focus()
            Return False
            Exit Function
        End If
        'Kiểm tra thông tin về bưu cục nhận
        If (Buu_Cuc_Nhan.ToString.Length = 0) Then
            CMessageBox.Show("Thông tin về túi thư không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbMa_Bc_Nhan.Focus()
            Return False
            Exit Function
        End If
        'Thông tin được xác nhận dúng
        Return True
    End Function
#End Region

#Region "Enable_Control"
    Private Sub Enable_Control(ByVal gia_tri As Boolean)
        btnXac_Nhan_Tui.Enabled = gia_tri
        btnXac_Nhan.Enabled = gia_tri
        'UltraGroupBox5.Enabled = gia_tri
        btnAdd.Enabled = gia_tri
        btnDel.Enabled = gia_tri
        chkChon_Tat.Enabled = gia_tri
        chkChon_Tat1.Enabled = gia_tri
        chkLua_Chon_Truyen.Enabled = gia_tri
    End Sub
#End Region

#Region "Load_GiaoTuiDi"
    Private Sub Load_GiaoTuiDi()
        dgGiaoTuiDi.DataSource = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Danh_Sach_Theo_Truc_Duong_Thu(CInt(CbTruc_Duong_Thu.Value), CInt(cbMa_Bc_Nhan.Value), CInt(cbMa_Bc_Gui.Value), Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value), 0).Tables(0)
        dgGiaoTuiDi.DataBind()
    End Sub
#End Region

#Region "Load_GiaoTuiDi1"
    Private Sub Load_GiaoTuiDi1()
        dgGiaoTuiDi1.DataSource = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Danh_Sach_Theo_Truc_Duong_Thu(CInt(CbTruc_Duong_Thu.Value), CInt(cbMa_Bc_Nhan.Value), CInt(cbMa_Bc_Gui.Value), Ham_Dung_Chung.ConvertDateToInt(cbNgayDong.Value), 1).Tables(0)
        dgGiaoTuiDi1.DataBind()
    End Sub
#End Region

#Region "Load_Danh_Muc"
    Private Sub Load_Danh_Muc()
        CbTruc_Duong_Thu.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Ma_Bc_Dich(GBuu_Cuc_Khai_Thac) 'myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Danh_Sach.Tables(0)
        CbTruc_Duong_Thu.DataBind()
        If CbTruc_Duong_Thu.Rows.Count > 0 Then
            If myId_Tuyen_VC = 0 Then
                CbTruc_Duong_Thu.Value = CbTruc_Duong_Thu.Rows(0).Cells("Id_Tuyen").Value
            Else
                CbTruc_Duong_Thu.Value = myId_Tuyen_VC
            End If
        Else
            CMessageBox.Show("Chưa khai báo chặng vận chuyển thuộc tuyến vận chuyển : " & myId_Tuyen_VC.ToString & " cho mã bưu cục khai thác " & GBuu_Cuc_Khai_Thac.ToString)
        End If
        CbTruc_Duong_Thu_Giao.DataSource = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Danh_Sach.Tables(0)
        CbTruc_Duong_Thu_Giao.DataBind()
        If CbTruc_Duong_Thu_Giao.Rows.Count > 0 Then
            If myId_Tuyen_VC = 0 Then
                CbTruc_Duong_Thu_Giao.Value = CbTruc_Duong_Thu_Giao.Rows(0).Cells("Id_Tuyen").Value
            Else
                CbTruc_Duong_Thu_Giao.Value = myId_Tuyen_VC
            End If
        End If
        Load_Ma_Buu_Cuc()
        Load_Doi_Tac(IIf(CbTruc_Duong_Thu_Giao.Value Is Nothing, 0, CInt(CbTruc_Duong_Thu_Giao.Value)))
    End Sub
#End Region

#Region "Load_Doi_Tac"
    Private Sub Load_Doi_Tac(ByVal Id_Tuyen As Integer)
        myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(Id_Tuyen)
        cbDoi_Tac.DataSource = myQLTGND_PARTNER.QLTGND_PARTNER_Danh_Sach.Tables(0)
        cbDoi_Tac.DataBind()
        If cbDoi_Tac.Rows.Count > 0 Then
            cbDoi_Tac.Value = myQLTGND_TUYEN_VC_Chi_Tiet.PARTNER_ID
        End If

        cbPhuong_Tien_Van_Chuyen.DataSource = myQLTGND_TRANSPORT_TYPE.QLTGND_TRANSPORT_TYPE_Danh_Sach.Tables(0)
        cbPhuong_Tien_Van_Chuyen.DataBind()
        If cbPhuong_Tien_Van_Chuyen.Rows.Count > 0 Then
            cbPhuong_Tien_Van_Chuyen.Value = myQLTGND_TUYEN_VC_Chi_Tiet.TRANSPORT_TYPE_ID
        End If
    End Sub
#End Region

#Region "Load_Ma_Buu_Cuc"
    Private Sub Load_Ma_Buu_Cuc()
        cbMa_Bc_Gui.DataSource = myQLTGND_CHANG_VC.QLTGND_CHANG_VC_Danh_Sach_Theo_Tuyen(CInt(CbTruc_Duong_Thu.Value)).Tables(0)
        cbMa_Bc_Gui.DataBind()
        If cbMa_Bc_Gui.Rows.Count > 0 Then
            cbMa_Bc_Gui.Value = cbMa_Bc_Gui.Rows(0).Cells("Ma_Bc_Goc").Value
        End If
        cbMa_Bc_Nhan.DataSource = myMa_Bc_Khai_Thac.Danh_Sach.Tables(0)
        cbMa_Bc_Nhan.DataBind()
        If cbMa_Bc_Nhan.Rows.Count > 0 Then
            cbMa_Bc_Nhan.Value = GBuu_Cuc_Khai_Thac
        End If
    End Sub
#End Region

#Region "frmXacNhanBC37Den_Load"
    Private Sub frmXacNhanBC37Den_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myTuyen_Van_Chuyen_Truyen_Form_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(myId_Tuyen_VC)
        Me.Text = "Xác nhận BC37 đến tuyến " & myTuyen_Van_Chuyen_Truyen_Form_Chi_Tiet.Ten_Tuyen
        cbNgayDong.DateTime = Today
        cbThoi_Gian_Giao_Nhan.DateTime = Today
        txtGio_Gui.Text = IIf(Now.Hour.ToString.Length = 1, "0" & Now.Hour.ToString, Now.Hour.ToString) & ":" & IIf(Now.Minute.ToString.Length = 1, "0" & Now.Minute.ToString, Now.Minute.ToString)
        Enable_Control(False)
        txtSo_Ban.Text = 1
        cbMa_Bc_Gui.Enabled = chkBuu_Cuc_Gui.Checked
        cbMa_Bc_Nhan.Enabled = chkBuu_Cuc_Gui.Checked
        CbTruc_Duong_Thu.Enabled = chkTuyen_Duong_Thu.Checked
        Load_Danh_Muc()
        btnLay_Du_Lieu_Click(sender, e)
        Me.ActiveControl = Me.txtSo_Hieu_BC37
        txtSo_Hieu_BC37.Focus()
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
            'CMessageBox.Show("Hiện tại chưa có dữ liệu BC37 này !!!", "Thông báo")
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
            'CMessageBox.Show("Hiện tại chưa có dữ liệu BC37 này !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "btnAdd_Click"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            If dgGiaoTuiDi.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_BC37_DEN_Chi_Tiet
                    .BC37_ID = CStr(dgGiaoTuiDi.Rows(i).Cells("BC37_ID").Text)
                    .Chot_SL = CBool(dgGiaoTuiDi.Rows(i).Cells("Chot_SL").Value)
                    .Da_In = CBool(dgGiaoTuiDi.Rows(i).Cells("Da_In").Value)
                    .Dot_Giao = CInt(dgGiaoTuiDi.Rows(i).Cells("Dot_Giao").Value)
                    .Gio_Giao = CInt(dgGiaoTuiDi.Rows(i).Cells("Gio_Giao").Value)
                    .Gio_He_Thong = CInt(dgGiaoTuiDi.Rows(i).Cells("Gio_He_Thong").Value)
                    .Gio_Lap = Ham_Dung_Chung.ConvertTimeToInt(dgGiaoTuiDi.Rows(i).Cells("Gio_Lap").Value)
                    .Id_Ca = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_Ca").Text)
                    .Id_Duong_Thu = CStr(dgGiaoTuiDi.Rows(i).Cells("Id_Duong_Thu").Text)
                    .Id_Nguoi_Dung = CInt(dgGiaoTuiDi.Rows(i).Cells("Id_Nguoi_Dung").Value)
                    .Ma_Bc = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc").Value)
                    .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                    .Ngay_Giao = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Giao").Value)
                    .Ngay_He_Thong = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_He_Thong").Value)
                    .Ngay_Lap = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Lap").Value)
                    .PARTNER_ID = CStr(dgGiaoTuiDi.Rows(i).Cells("PARTNER_ID").Text)
                    .So_Chuyen_Thu = CInt(dgGiaoTuiDi.Rows(i).Cells("So_Chuyen_Thu").Value)
                    .Tong_So_Tui = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_So_Tui").Value)
                    .Tong_So_BP = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_So_BP").Value)
                    .Tong_KL = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_KL").Value)
                    .Tong_KLBP = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_KLBP").Value)
                    .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
                    .TRANSPORT_TYPE_ID = CStr(dgGiaoTuiDi.Rows(i).Cells("TRANSPORT_TYPE_ID").Text)
                    .TRANSPORT_NUMBER = CStr(dgGiaoTuiDi.Rows(i).Cells("TRANSPORT_NUMBER").Text)
                    .Truyen_Khai_Thac = CInt(dgGiaoTuiDi.Rows(i).Cells("Truyen_Khai_Thac").Value)
                    .MAIL_ROUTE_ID = CInt(dgGiaoTuiDi.Rows(i).Cells("MAIL_ROUTE_ID").Text)
                    .IS_TRANSITION = CBool(dgGiaoTuiDi.Rows(i).Cells("IS_TRANSITION").Value)
                End With
                myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_Lap, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_BP, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_KLBP, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_He_Thong, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_He_Thong, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Da_In, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Chot_SL, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Truyen_Khai_Thac, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Trang_Thai, _
                    myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_NUMBER, _
                    myQLTGND_BC37_DEN_Chi_Tiet.PARTNER_ID.ToString, _
                    myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.IS_TRANSITION)
                kiem_tra_chon = True
            End If
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Bạn chưa chọn mã E1 nào xác nhận giao túi gói !!!", "Thông báo")
            Exit Sub
        Else
            Load_GiaoTuiDi()
            Load_GiaoTuiDi1()
            ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
        End If
    End Sub
#End Region

#Region "frmXacNhanBC37Den_KeyDown"
    Private Sub frmXacNhanBC37Den_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
                Case Keys.F1
                    btnLay_Du_Lieu_Click(sender, e)
                Case Keys.F2
                    btnXac_Nhan_Click(sender, e)
                Case Keys.F4
                    btnXac_Nhan_Tui_Click(sender, e)
                Case Keys.F10
                    chkChon_Tat_CheckedChanged(sender, e)
                Case Keys.F11
                    chkChon_Tat1_CheckedChanged(sender, e)
                Case Keys.Escape
                    btnThoat_Click(sender, e)
            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnXac_Nhan_Click"
    Private Sub btnXac_Nhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXac_Nhan.Click
        'Kiem tra online
        If (Ham_Dung_Chung.UrlIsValid(myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1))) Then
            chkLua_Chon_Truyen.Checked = True
        Else
            chkLua_Chon_Truyen.Checked = False
        End If
        'Kiểm tra điều kiện
        If CbTruc_Duong_Thu_Giao.Value Is System.DBNull.Value Then
            CMessageBox.Show("Bạn chưa chọn Tuyến đường thư, xin hãy kiểm tra lại thông tin", "Thông báo")
            CbTruc_Duong_Thu_Giao.Focus()
            Exit Sub
        End If
        If cbDoi_Tac.Value Is System.DBNull.Value Then
            CMessageBox.Show("Bạn chưa nhập chọn đối tác vận chuyển, xin hãy kiểm tra lại thông tin", "Thông báo")
            cbDoi_Tac.Focus()
            Exit Sub
        End If
        If cbPhuong_Tien_Van_Chuyen.Value Is System.DBNull.Value Then
            CMessageBox.Show("Bạn chưa nhập chọn phương tiện vận chuyển, xin hãy kiểm tra lại thông tin", "Thông báo")
            cbPhuong_Tien_Van_Chuyen.Focus()
            Exit Sub
        End If
        If txtNguoi_Ky_Nhan.Text.Length = 0 Then
            CMessageBox.Show("Bạn chưa nhập tên người ký nhận, xin hãy kiểm tra lại thông tin người nhận", "Thông báo")
            txtNguoi_Ky_Nhan.Focus()
            Exit Sub
        End If
        If txtMa_Hieu_Phuong_Tien.Text.Length = 0 Then
            CMessageBox.Show("Bạn chưa nhập mã hiệu phương tiện vận chuyển, xin hãy kiểm tra lại thông tin", "Thông báo")
            txtMa_Hieu_Phuong_Tien.Focus()
            Exit Sub
        End If

        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_BC37_DEN_Chi_Tiet
                    .BC37_ID = CStr(dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Text)
                    .Chot_SL = CBool(dgGiaoTuiDi1.Rows(i).Cells("Chot_SL").Value)
                    .Da_In = CBool(dgGiaoTuiDi1.Rows(i).Cells("Da_In").Value)
                    .Dot_Giao = CInt(dgGiaoTuiDi1.Rows(i).Cells("Dot_Giao").Value)
                    .Gio_Giao = Ham_Dung_Chung.ConvertDateToInt(txtGio_Gui.Value)
                    .Gio_He_Thong = CInt(dgGiaoTuiDi1.Rows(i).Cells("Gio_He_Thong").Value)
                    .Gio_Lap = Ham_Dung_Chung.ConvertTimeToInt(dgGiaoTuiDi1.Rows(i).Cells("Gio_Lap").Value)
                    .Id_Ca = CStr(dgGiaoTuiDi1.Rows(i).Cells("Id_Ca").Text)
                    .Id_Duong_Thu = CStr(dgGiaoTuiDi1.Rows(i).Cells("Id_Duong_Thu").Text)
                    .Id_Nguoi_Dung = CInt(dgGiaoTuiDi1.Rows(i).Cells("Id_Nguoi_Dung").Value)
                    .Ma_Bc = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc").Value)
                    .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                    .Ngay_Giao = Ham_Dung_Chung.ConvertDateToInt(cbThoi_Gian_Giao_Nhan.Value)
                    .Ngay_He_Thong = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_He_Thong").Value)
                    .Ngay_Lap = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Lap").Value)
                    .PARTNER_ID = IIf(cbDoi_Tac.Value Is Nothing, "", CStr(cbDoi_Tac.Value))
                    .So_Chuyen_Thu = CInt(dgGiaoTuiDi1.Rows(i).Cells("So_Chuyen_Thu").Value)
                    .Tong_So_Tui = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_So_Tui").Value)
                    .Tong_So_BP = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_So_BP").Value)
                    .Tong_KL = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_KL").Value)
                    .Tong_KLBP = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_KLBP").Value)
                    .Trang_Thai = Trang_Thai_Da_Hoan_Tat
                    .TRANSPORT_TYPE_ID = IIf(cbPhuong_Tien_Van_Chuyen.Value Is Nothing, "", CStr(cbPhuong_Tien_Van_Chuyen.Value))
                    .TRANSPORT_NUMBER = txtMa_Hieu_Phuong_Tien.Text.Trim
                    .Truyen_Khai_Thac = CInt(dgGiaoTuiDi1.Rows(i).Cells("Truyen_Khai_Thac").Value)
                    .MAIL_ROUTE_ID = CInt(CbTruc_Duong_Thu_Giao.Value)
                    .IS_TRANSITION = CBool(dgGiaoTuiDi1.Rows(i).Cells("IS_TRANSITION").Value)
                End With
                If myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, gTrang_Thai_2, GBuu_Cuc_Khai_Thac).Tables(0).Rows.Count > 0 Then
                    myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Gio_Lap, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Gio_Giao, _
                        myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_BP, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_KLBP, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ngay_He_Thong, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Gio_He_Thong, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Da_In, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Chot_SL, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Truyen_Khai_Thac, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Trang_Thai, _
                        myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_NUMBER, _
                        myQLTGND_BC37_DEN_Chi_Tiet.PARTNER_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.IS_TRANSITION)
                    myQLTGND_POSTBAG_DEN.QLTGND_BC37_DEN_Hieu_Chinh(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, GBuu_Cuc_Khai_Thac)
                    myQLTGND_BC37.QLTGND_BC37_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID.ToString, _
                        Date.Now, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc.ToString, _
                        gStatus_BC37_2.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu.ToString, _
                        i + 1, _
                        GTen_Dang_Nhap, Date.Now, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        IIf(chkLua_Chon_Truyen.Checked, 1, 0), _
                        myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                        dgGiaoTuiDi1.Rows(i).Cells("Dot_Giao").Text, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        0, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui)
                    myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.TRANSPORT_POSTBAG_Hieu_Chinh(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, 0, GBuu_Cuc_Khai_Thac)
                    myQLTGND_BC37.QLTGND_BC37_Hieu_Chinh(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, 0, GBuu_Cuc_Khai_Thac)
                    myQLTGND_BC37_Chi_Tiet = myQLTGND_BC37.QLTGND_BC37_Lay(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID.ToString)
                    myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay(myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca)
                    Dim Id_Mail_Trip_Transport_BC37 As Integer = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Cap_Nhat_Them(0, _
                        Date.Now, _
                        myQLTGND_BC37_Chi_Tiet.DELIVERY, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc.ToString, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        IIf(cbPhuong_Tien_Van_Chuyen.Value Is DBNull.Value, "", CStr(cbPhuong_Tien_Van_Chuyen.Value)), _
                        myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        Date.Now, _
                        IIf(cbPhuong_Tien_Van_Chuyen.Value Is DBNull.Value, "", CStr(cbPhuong_Tien_Van_Chuyen.Value)), _
                        txtNguoi_Ky_Nhan.Text.Trim, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                        GTen_Dang_Nhap, _
                        myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc.ToString, _
                        Date.Now, _
                        txtMa_Hieu_Phuong_Tien.Text, _
                        myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID.ToString, _
                        IIf(chkLua_Chon_Truyen.Checked, 1, 0), _
                        gWAY_TYPE_1, _
                        IIf(CbTruc_Duong_Thu_Giao.Value Is DBNull.Value, 0, CbTruc_Duong_Thu_Giao.Value), _
                        IIf(cbDoi_Tac.Value Is DBNull.Value, 0, cbDoi_Tac.Value), _
                        myCa_San_Xuat_Chi_Tiet.Thu_Tu, _
                        Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac))

                    'Truyền qua service
                    If chkLua_Chon_Truyen.Checked = True Then
                        'Truyền QLTGND_BC37
                        myQLTGND_BC37_Chi_Tiet = myQLTGND_BC37.QLTGND_BC37_Lay(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID)
                        Dim Thong_Bao_BC37 As String = Them_Thong_Tin_BC37(myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                        myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE.ToString, _
                        myQLTGND_BC37_Chi_Tiet.TO_PO_CODE.ToString, _
                        myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE.ToString, _
                        gStatus_BC37_2.ToString, _
                        Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_BC37_Chi_Tiet.BC37_DATE).ToString, _
                        myQLTGND_BC37_Chi_Tiet.CREATE_USER, _
                        myQLTGND_BC37_Chi_Tiet.CONFIRM_PO_CODE.ToString, _
                        myQLTGND_BC37_Chi_Tiet.CREATE_USER, _
                        myQLTGND_BC37_Chi_Tiet.CREATE_PO_CODE.ToString, _
                        myQLTGND_BC37_Chi_Tiet.BC37_ID, _
                        Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_BC37_Chi_Tiet.CONFIRM_DATE).ToString, _
                        myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT, _
                        myQLTGND_BC37_Chi_Tiet.TOTAL_QUANTITY, _
                        myQLTGND_BC37_Chi_Tiet.DELIVERY.ToString, _
                        myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID, _
                        myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_1, _
                        myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_2)
                        CMessageBox.Show("Thông báo BC37: " & Thong_Bao_BC37, "Thông báo")
                        'Truyền QLTGND_MAIL_TRIP_TRANSPORT_BC37
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Lay(Id_Mail_Trip_Transport_BC37)
                        Dim Thong_Bao_TranSport_BC37 As String = Them_Thong_Tin_Mail_Trip_Transport_BC37(Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.BC37_DATE).ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.BC37_FROM_PO_ID.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.BC37_TO_PO_ID.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.TRANSPORT_TYPE_ID.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.BC37_ORDER, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.MAIL_TRIP_TRANSPORT_FROM_PO_ID.ToString, _
                        Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.TRANSPORT_DATE).ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.CONFIRM_USER.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.CONFIRM_POS_ID.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.CREATE_USER.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.CREATE_PO_ID.ToString, _
                        Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.CONFIRM_DATE).ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.TRANSPORT_NUMBER.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.BC37_ID.ToString, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.WAY_TYPE, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.PARTNER_ID, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.MAIL_ROUTE_ID, _
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.ID_CA, _
                        Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet.DATE_CA).ToString)
                        CMessageBox.Show("Thông báo Transport BC37 : " & Thong_Bao_TranSport_BC37, "Thông báo")

                        'Truyền QLTGND_POSTBAG
                        Dim myData_Postbag As New DataTable
                        Dim c As Integer
                        myData_Postbag = myQLTGND_POSTBAG.QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID).Tables(0)
                        If myData_Postbag.Rows.Count > 0 Then
                            For c = 0 To myData_Postbag.Rows.Count - 1
                                myQLTGND_POSTBAG_Chi_Tiet = myQLTGND_POSTBAG.QLTGND_POSTBAG_Lay(myData_Postbag.Rows(c).Item("POST_BAG_ID"))
                                Dim Thong_Bao_Postbag As String = Them_Thong_Tin_Tui_Goi(myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_INDEX, _
                                myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_TYPE, _
                                myQLTGND_POSTBAG_Chi_Tiet.POST_BAG_ID.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.FROM_PO_CODE.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.TO_PO_CODE.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.YEAR.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.MAIL_TRIP_NUMBER, _
                                myQLTGND_POSTBAG_Chi_Tiet.MAIL_TRIP_TYPE.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.SERVICE_CODE.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.F.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.WEIGHT, _
                                myQLTGND_POSTBAG_Chi_Tiet.STATUS.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.QUANTITY, _
                                myQLTGND_POSTBAG_Chi_Tiet.IS_PRINTER, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_POSTBAG_Chi_Tiet.BC37_DATE).ToString, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_TIME).ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_USER.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.PACKAGING_MACHINE.ToString, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_POSTBAG_Chi_Tiet.OPENING_TIME).ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.OPENING_USER.ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.OPENING_MACHINE.ToString, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_POSTBAG_Chi_Tiet.INCOMING_DATE).ToString, _
                                myQLTGND_POSTBAG_Chi_Tiet.CASE_WEIGHT, _
                                myQLTGND_POSTBAG_Chi_Tiet.IS_DISCRETE, _
                                myQLTGND_POSTBAG_Chi_Tiet.IS_DELIVERY_ROUTE, _
                                myQLTGND_POSTBAG_Chi_Tiet.BC37_ID.ToString)
                                CMessageBox.Show("Thông báo : " & Thong_Bao_Postbag, "Thông báo")
                            Next
                        End If

                        'Truyền QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG
                        Dim myData_Transport_Postbag As New DataTable
                        Dim d As Integer
                        myData_Transport_Postbag = myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, gWAY_TYPE_1).Tables(0)
                        If myData_Transport_Postbag.Rows.Count > 0 Then
                            For d = 0 To myData_Transport_Postbag.Rows.Count - 1
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet = myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Lay(myData_Transport_Postbag.Rows(d).Item("ID"))
                                Dim Thong_Bao_Transport_Postbag As String = Them_Thong_Tin_Mail_Trip_Transport_PostBag(myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.POST_BAG_INDEX, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.FROM_PO_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TO_PO_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_TRIP_TYPE.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.SERVICE_ID.ToString, _
                                Ham_Dung_Chung.ConvertDateToInt(myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_DATE).ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_TRIP_NUMBER.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.STATUS.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_INDEX, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_FROM_PO_ID.ToString, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_DATE).ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_TO_PO_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TRANSPORT_TYPE_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_ORDER.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_USER.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_PO_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CREATE_USER.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.FROM_PO_ID.ToString, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.CONFIRM_DATE).ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.POST_BAG_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.BC37_ID.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.TRANSPORT_NUMBER.ToString, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.WAY_TYPE, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.PARTNER_ID, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.MAIL_ROUTE_ID, _
                                myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.ID_CA, _
                                Ham_Dung_Chung.ConvertIntToDateTimeVNDateType(myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet.DATE_CA).ToString)
                                CMessageBox.Show("Thông báo Transport Postbag : " & Thong_Bao_Transport_Postbag, "Thông báo")
                            Next
                        End If
                    End If
                Else
                    CMessageBox.Show("Số hiệu " & myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID & " không có dữ liệu túi postbag, xin hãy kiểm tra lại", "Thông báo")
                    Exit Sub
                End If
                kiem_tra_chon = True
            End If
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Bạn chưa chọn mã E1 nào xác nhận giao túi gói !!!", "Thông báo")
            Exit Sub
        Else
            Load_GiaoTuiDi()
            Load_GiaoTuiDi1()
            ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
        End If
    End Sub
#End Region

#Region "txtSo_Hieu_BC37_Validated"
    Private Sub txtSo_Hieu_BC37_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_BC37.Validated
        Try
            If txtSo_Hieu_BC37.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            Dim myCode As String = txtSo_Hieu_BC37.Text.Trim.ToUpper
            Dim myBC37Code As New DycryptBarCode.bc37code
            If (myBC37Code.check(myCode) = True) Then
                txtSo_Hieu_BC37.Text = myCode
                '1. Kiem tra trong du lieu Local
                Dim myData_BC37 As New DataTable
                Dim a As Integer
                myData_BC37 = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai(myCode, 0, GBuu_Cuc_Khai_Thac).Tables(0)
                If myData_BC37.Rows.Count > 0 Then   'Co du lieu truyen ve tren luoi trai
                    For a = 0 To myData_BC37.Rows.Count - 1
                        With myQLTGND_BC37_DEN_Chi_Tiet
                            .BC37_ID = myData_BC37.Rows(a).Item("BC37_ID")
                            .Chot_SL = myData_BC37.Rows(a).Item("Chot_SL")
                            .Da_In = myData_BC37.Rows(a).Item("Da_In")
                            .Dot_Giao = myData_BC37.Rows(a).Item("Dot_Giao")
                            .Gio_Giao = myData_BC37.Rows(a).Item("Gio_Giao")
                            .Gio_He_Thong = myData_BC37.Rows(a).Item("Gio_He_Thong")
                            .Gio_Lap = myData_BC37.Rows(a).Item("Gio_Lap")
                            .Id_Ca = myData_BC37.Rows(a).Item("Id_Ca")
                            .Id_Duong_Thu = myData_BC37.Rows(a).Item("Id_Duong_Thu")
                            .Id_Nguoi_Dung = myData_BC37.Rows(a).Item("Id_Nguoi_Dung")
                            .Ma_Bc = myData_BC37.Rows(a).Item("Ma_Bc")
                            .Ma_Bc_Khai_Thac = myData_BC37.Rows(a).Item("Ma_Bc_Khai_Thac")
                            .Ngay_Giao = myData_BC37.Rows(a).Item("Ngay_Giao")
                            .Ngay_He_Thong = myData_BC37.Rows(a).Item("Ngay_He_Thong")
                            .Ngay_Lap = myData_BC37.Rows(a).Item("Ngay_Lap")
                            .PARTNER_ID = myData_BC37.Rows(a).Item("PARTNER_ID")
                            .So_Chuyen_Thu = myData_BC37.Rows(a).Item("So_Chuyen_Thu")
                            .Tong_So_Tui = myData_BC37.Rows(a).Item("Tong_So_Tui")
                            .Tong_So_BP = myData_BC37.Rows(a).Item("Tong_So_BP")
                            .Tong_KL = myData_BC37.Rows(a).Item("Tong_KL")
                            .Tong_KLBP = myData_BC37.Rows(a).Item("Tong_KLBP")
                            .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
                            .TRANSPORT_TYPE_ID = myData_BC37.Rows(a).Item("TRANSPORT_TYPE_ID")
                            .TRANSPORT_NUMBER = myData_BC37.Rows(a).Item("TRANSPORT_NUMBER")
                            .Truyen_Khai_Thac = myData_BC37.Rows(a).Item("Truyen_Khai_Thac")
                            .MAIL_ROUTE_ID = myData_BC37.Rows(a).Item("MAIL_ROUTE_ID")
                            .IS_TRANSITION = myData_BC37.Rows(a).Item("IS_TRANSITION")
                        End With
                        myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Gio_Lap, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Gio_Giao, _
                                myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_BP, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Tong_KLBP, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Ngay_He_Thong, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Gio_He_Thong, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Da_In, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Chot_SL, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Truyen_Khai_Thac, _
                                myQLTGND_BC37_DEN_Chi_Tiet.Trang_Thai, _
                                myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID, _
                                myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_NUMBER, _
                                myQLTGND_BC37_DEN_Chi_Tiet.PARTNER_ID, _
                                myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                                myQLTGND_BC37_DEN_Chi_Tiet.IS_TRANSITION)
                    Next
                    'Hiển thị dữ liệu
                    Load_GiaoTuiDi()
                    Load_GiaoTuiDi1()
                    Enable_Control(True)
                    'Ket thuc 
                    txtSo_Hieu_BC37.Focus()
                    lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                    txtSo_Hieu_BC37.Clear()
                Else
                    'Kiểm tra bên lưới phải
                    If myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Lay(txtSo_Hieu_BC37.Text, GBuu_Cuc_Khai_Thac).Trang_Thai > 0 Then
                        MessageBox.Show("BC37 này đã giao đi rồi, bạn không được phép giao nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'Ket thuc 
                        txtSo_Hieu_BC37.Focus()
                        lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                        txtSo_Hieu_BC37.Clear()
                        Exit Sub
                    End If

                    '2. Kiểm tra dữ liệu trên HOST
                    Dim mDatatable As New DataTable
                    Try
                        MessageBox.Show("Chờ một vài phút chương trình kết nối lên máy chủ HOST để lấy dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                        mDatatable = Liet_Ke_Thong_Tin_BC37_Theo_So_Hieu_BC37(txtSo_Hieu_BC37.Text, 0, 0, 0)
                        Me.ActiveForm.Cursor.Current = Cursors.Default
                    Catch ex As Exception
                        Me.ActiveForm.Cursor.Current = Cursors.Default
                    End Try
                    If mDatatable.Rows.Count > 0 Then
                        'Gán Mail_Route_Id mới , nếu khác với tuyến vận chuyển.
                        Dim myTuyen_Duong_Thu As Integer = 0
                        myTuyen_Duong_Thu = IIf(CbTruc_Duong_Thu.Value Is System.DBNull.Value, 0, CInt(CbTruc_Duong_Thu.Value))
                        If mDatatable.Rows(0).Item("MAIL_ROUTE_ID") <> myTuyen_Duong_Thu Then
                            If CMessageBox.Show("Tuyến đường thư trên host của BC37 này là : " & CStr(mDatatable.Rows(0).Item("MAIL_ROUTE_ID")) & vbNewLine & "Tuyến đường thư bạn đang xác nhận là : " & myTuyen_Duong_Thu.ToString & vbNewLine & "Tuyến vận chuyển trên host và tuyến vận chuyển xác nhận đến khác nhau, bạn có chắc chắn muốn lấy BC37 này về không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                                mDatatable.Rows(0).Item("MAIL_ROUTE_ID") = myTuyen_Duong_Thu
                            Else
                                Exit Sub
                            End If
                        End If
                        'Lay BC37
                        myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them( _
                                    txtSo_Hieu_BC37.Text, _
                                    CreateId_Duong_Thu(Convert.ToInt32(mDatatable.Rows(0).Item("FROM_PO_CODE")), Convert.ToInt32(mDatatable.Rows(0).Item("TO_PO_CODE"))), _
                                    GId_Ca, _
                                    GBuu_Cuc_Khai_Thac, _
                                    Convert.ToInt32(mDatatable.Rows(0).Item("FROM_PO_CODE")), _
                                    myHam_Dung_Chung.ConvertDateToInt(myHam_Dung_Chung.ConvertStringToDateTime(mDatatable.Rows(0).Item("BC37_DATE"))), _
                                    myHam_Dung_Chung.ConvertTimeToInt(myHam_Dung_Chung.ConvertStringToDateTime(mDatatable.Rows(0).Item("BC37_DATE"))), _
                                    IIf(IsNumeric(mDatatable.Rows(0).Item("DENIVERY")), Convert.ToInt32(mDatatable.Rows(0).Item("DENIVERY")), 1), _
                                    myHam_Dung_Chung.ConvertDateToInt(Now.Date), _
                                    myHam_Dung_Chung.ConvertTimeToInt(Now.Date), _
                                    IIf(IsNumeric(mDatatable.Rows(0).Item("DENIVERY")), Convert.ToInt32(mDatatable.Rows(0).Item("DENIVERY")), 1), _
                                    mDatatable.Rows(0).Item("TOTAL_QUANTITY"), _
                                    0, _
                                    mDatatable.Rows(0).Item("TOTAL_WEIGHT"), _
                                    mDatatable.Rows(0).Item("TOTAL_WEIGHT"), _
                                    Gid_Nguoi_Dung, _
                                    myHam_Dung_Chung.ConvertDateToInt(Now.Date), _
                                    myHam_Dung_Chung.ConvertTimeToInt(Now.Date), _
                                    False, _
                                    False, _
                                    0, _
                                    Trang_Thai_Dang_Xac_Nhan, _
                                    mDatatable.Rows(0).Item("TRANSPORT_TYPE_CODE"), _
                                    0, _
                                    myTuyen_Van_Chuyen_Truyen_Form_Chi_Tiet.PARTNER_ID, _
                                    mDatatable.Rows(0).Item("MAIL_ROUTE_ID"), _
                                    Kiem_Tra_Qua_Giang(Convert.ToInt32(mDatatable.Rows(0).Item("TO_PO_CODE")), GBuu_Cuc_Khai_Thac))
                        'Lấy thông tin túi
                        Dim myData_Postbag_Den As New DataTable
                        Dim l As Integer
                        myData_Postbag_Den = Liet_Ke_Thong_Tin_Tui_Goi_Theo_So_Hieu_BC37(txtSo_Hieu_BC37.Text)
                        For l = 0 To myData_Postbag_Den.Rows.Count - 1
                            With myQLTGND_POSTBAG_DEN_Chi_Tiet
                                .Id_Duong_Thu = CreateId_Duong_Thu(Convert.ToInt32(mDatatable.Rows(0).Item("FROM_PO_CODE")), Convert.ToInt32(mDatatable.Rows(0).Item("TO_PO_CODE")))
                                .Id_Chuyen_Thu = ""
                                .Id_Ca = GId_Ca
                                .Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
                                .Ma_Bc = CInt(myData_Postbag_Den.Rows(l).Item("FROM_PO_CODE"))
                                .Ngay_Dong = myHam_Dung_Chung.ConvertDateToInt(myHam_Dung_Chung.ConvertStringToDateTime(mDatatable.Rows(0).Item("BC37_DATE")))
                                .Gio_Dong = myHam_Dung_Chung.ConvertTimeToInt(myHam_Dung_Chung.ConvertStringToDateTime(mDatatable.Rows(0).Item("BC37_DATE")))
                                .Ngay_Nhan = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
                                .Gio_Nhan = Ham_Dung_Chung.ConvertTimeToInt(Date.Now)
                                .So_Chuyen_Thu = CInt(myData_Postbag_Den.Rows(l).Item("MAIL_TRIP_NUMBER"))
                                .Tui_So = l + 1
                                .Tui_F = True
                                .Tong_So_BP = CInt(myData_Postbag_Den.Rows(l).Item("QUANTITY"))
                                .Khoi_Luong_Vo_Tui = CInt(myData_Postbag_Den.Rows(l).Item("CASE_WEIGHT"))
                                .Khoi_Luong_BP = CInt(myData_Postbag_Den.Rows(l).Item("WEIGHT"))
                                .Tong_Cuoc_COD = 0
                                .Tong_Cuoc_DV = 0
                                .Tong_Cuoc_Chinh = 0
                                .HH_Phat_Hanh = 0
                                .HH_Phat_Tra = 0
                                .Truyen_Khai_Thac = False
                                .Ngay_He_Thong = Ham_Dung_Chung.ConvertDateToInt(Date.Now)
                                .Chot_SL = False
                                .Id_Tui_Thu = myData_Postbag_Den.Rows(l).Item("POST_BAG_NUMBER")
                                .Id_BC37 = myData_Postbag_Den.Rows(l).Item("BC37_CODE")
                                .Trang_Thai = 0
                                .IS_TRANSITION = Kiem_Tra_Qua_Giang(Convert.ToInt32(mDatatable.Rows(0).Item("TO_PO_CODE")), GBuu_Cuc_Khai_Thac)
                                .Id_E2 = CreateId_E2(.Id_Chuyen_Thu, .Tui_So)
                            End With

                            myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Cap_Nhat_Them(myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_E2, _
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
                        Next
                        'Hiển thị dữ liệu
                        Load_GiaoTuiDi()
                        Load_GiaoTuiDi1()
                        Enable_Control(True)

                        'Ket thuc 
                        txtSo_Hieu_BC37.Focus()
                        lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                        txtSo_Hieu_BC37.Clear()
                    Else   'Nhập thay thế
                        If MessageBox.Show("Không có dữ liệu về BC37 này, bạn có muốn nhập thay thế không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                            btnNhap_Moi_Bc37_Click(btnNhap_Moi_Bc37, Nothing)
                            ''Hiển thị dữ liệu
                            'Load_GiaoTuiDi()
                            'Load_GiaoTuiDi1()
                            'Enable_Control(True)
                        Else
                            txtSo_Hieu_BC37.Focus()
                            lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                            txtSo_Hieu_BC37.Clear()
                            Exit Sub
                        End If
                    End If
                End If
            Else  'sai dinh dạng
                MessageBox.Show("Bạn phải nhập đúng định dạng mã BC37", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSo_Hieu_BC37.Focus()
                lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
                txtSo_Hieu_BC37.Clear()
                Exit Sub
            End If
            ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
            'Tích chọn những BC37
            'Dim kiem_tra_chon As Boolean = False
            'Dim i As Integer
            'For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            '    If dgGiaoTuiDi.Rows(i).Cells("BC37_ID").Value = txtSo_Hieu_BC37.Text.Trim Then
            '        dgGiaoTuiDi.Rows(i).Cells("Chon").Value = True
            '        kiem_tra_chon = True
            '    End If
            'Next
            'If kiem_tra_chon = True Then
            '    btnAdd_Click(sender, e)
            '    txtSo_Hieu_BC37.Focus()
            '    txtSo_Hieu_BC37.SelectionStart = 0
            '    txtSo_Hieu_BC37.SelectionLength = txtSo_Hieu_BC37.TextLength
            '    Exit Sub
            'Else
            '    'CMessageBox.Show("Hiện tại chưa có dữ liệu BC37 này !!!", "Thông báo")
            '    txtSo_Hieu_BC37.Focus()
            '    txtSo_Hieu_BC37.SelectionStart = 0
            '    txtSo_Hieu_BC37.SelectionLength = txtSo_Hieu_BC37.TextLength
            '    Exit Sub
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnDel_Click"
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_BC37_DEN_Chi_Tiet
                    .BC37_ID = CStr(dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Text)
                    .Chot_SL = CBool(dgGiaoTuiDi1.Rows(i).Cells("Chot_SL").Value)
                    .Da_In = CBool(dgGiaoTuiDi1.Rows(i).Cells("Da_In").Value)
                    .Dot_Giao = CInt(dgGiaoTuiDi1.Rows(i).Cells("Dot_Giao").Value)
                    .Gio_Giao = CInt(dgGiaoTuiDi1.Rows(i).Cells("Gio_Giao").Value)
                    .Gio_He_Thong = CInt(dgGiaoTuiDi1.Rows(i).Cells("Gio_He_Thong").Value)
                    .Gio_Lap = Ham_Dung_Chung.ConvertTimeToInt(dgGiaoTuiDi1.Rows(i).Cells("Gio_Lap").Value)
                    .Id_Ca = CStr(dgGiaoTuiDi1.Rows(i).Cells("Id_Ca").Text)
                    .Id_Duong_Thu = CStr(dgGiaoTuiDi1.Rows(i).Cells("Id_Duong_Thu").Text)
                    .Id_Nguoi_Dung = CInt(dgGiaoTuiDi1.Rows(i).Cells("Id_Nguoi_Dung").Value)
                    .Ma_Bc = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc").Value)
                    .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                    .Ngay_Giao = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Giao").Value)
                    .Ngay_He_Thong = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_He_Thong").Value)
                    .Ngay_Lap = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Lap").Value)
                    .PARTNER_ID = CStr(dgGiaoTuiDi1.Rows(i).Cells("PARTNER_ID").Text)
                    .So_Chuyen_Thu = CInt(dgGiaoTuiDi1.Rows(i).Cells("So_Chuyen_Thu").Value)
                    .Tong_So_Tui = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_So_Tui").Value)
                    .Tong_So_BP = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_So_BP").Value)
                    .Tong_KL = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_KL").Value)
                    .Tong_KLBP = CInt(dgGiaoTuiDi1.Rows(i).Cells("Tong_KLBP").Value)
                    .Trang_Thai = Trang_Thai_Chua_Xac_Nhan
                    .TRANSPORT_TYPE_ID = CStr(dgGiaoTuiDi1.Rows(i).Cells("TRANSPORT_TYPE_ID").Text)
                    .TRANSPORT_NUMBER = CStr(dgGiaoTuiDi1.Rows(i).Cells("TRANSPORT_NUMBER").Value)
                    .Truyen_Khai_Thac = CInt(dgGiaoTuiDi1.Rows(i).Cells("Truyen_Khai_Thac").Value)
                    .MAIL_ROUTE_ID = CInt(dgGiaoTuiDi1.Rows(i).Cells("MAIL_ROUTE_ID").Text)
                    .IS_TRANSITION = CBool(dgGiaoTuiDi1.Rows(i).Cells("IS_TRANSITION").Value)
                End With
                myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_DEN_Chi_Tiet.BC37_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Duong_Thu, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Ca, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc_Khai_Thac, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ma_Bc, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Lap, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_Lap, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Dot_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_Giao, _
                    myQLTGND_BC37_DEN_Chi_Tiet.So_Chuyen_Thu, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_Tui, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_So_BP, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_KL, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Tong_KLBP, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Id_Nguoi_Dung, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Ngay_He_Thong, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Gio_He_Thong, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Da_In, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Chot_SL, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Truyen_Khai_Thac, _
                    myQLTGND_BC37_DEN_Chi_Tiet.Trang_Thai, _
                    myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_TYPE_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.TRANSPORT_NUMBER, _
                    myQLTGND_BC37_DEN_Chi_Tiet.PARTNER_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.MAIL_ROUTE_ID, _
                    myQLTGND_BC37_DEN_Chi_Tiet.IS_TRANSITION)
                kiem_tra_chon = True
            End If
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Bạn chưa chọn mã E1 nào xác nhận giao túi gói !!!", "Thông báo")
            Exit Sub
        Else
            Load_GiaoTuiDi()
            Load_GiaoTuiDi1()
            ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
        End If
    End Sub
#End Region

#Region "btnIn_Bc37_Click"
    Private Sub btnIn_Bc37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIn_Bc37.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                Ban_Ke_BC37_Den_Tong_Hop(dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Value, True, CInt(txtSo_Ban.Value))
            End If
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            CMessageBox.Show("Hiện tại chưa có dữ liệu BC37 này !!!", "Thông báo")
            Exit Sub
        End If
    End Sub
#End Region

#Region "CbTruc_Duong_Thu_Validated"
    Private Sub CbTruc_Duong_Thu_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTruc_Duong_Thu.Validated
        Load_Ma_Buu_Cuc()
        CbTruc_Duong_Thu_Giao.Value = CbTruc_Duong_Thu.Value
    End Sub
#End Region

#Region "chkBuu_Cuc_Gui_CheckedChanged"
    Private Sub chkBuu_Cuc_Gui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBuu_Cuc_Gui.CheckedChanged
        cbMa_Bc_Gui.Enabled = chkBuu_Cuc_Gui.Checked
        cbMa_Bc_Nhan.Enabled = chkBuu_Cuc_Gui.Checked
    End Sub
#End Region

#Region "chkTuyen_Duong_Thu_CheckedChanged"
    Private Sub chkTuyen_Duong_Thu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTuyen_Duong_Thu.CheckedChanged
        CbTruc_Duong_Thu.Enabled = chkTuyen_Duong_Thu.Checked
    End Sub
#End Region

#Region "TimeClock_Tick"
    Private Sub TimeClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeClock.Tick
        If Now.Hour >= 13 Then
            txtGio_Gui.Text = (Now.Hour - 12).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString())
        Else
            txtGio_Gui.Text = (Now.Hour).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString())
        End If
    End Sub
#End Region

#Region "txtGio_Gui_ValueChanged"
    Private Sub txtGio_Gui_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGio_Gui.ValueChanged
        If txtGio_Gui.Text.Length = 0 Then
            If Now.Hour >= 13 Then
                txtGio_Gui.Text = (Now.Hour - 12).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString())
            Else
                txtGio_Gui.Text = (Now.Hour).ToString & ":" & IIf(Now.Minute.ToString().Length = 1, "0" & Now.Minute.ToString(), Now.Minute.ToString())
            End If
        End If
    End Sub
#End Region

#Region "btnNhap_Moi_Bc37_Click"
    Private Sub btnNhap_Moi_Bc37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Moi_Bc37.Click
        Dim frm As New FrmNhap_Thay_The_BC37
        frm.myBC37_ID = lblSo_Hieu_BC37.Text
        frm.myId_Tuyen_VC = CInt(CbTruc_Duong_Thu.Value)
        frm.myMa_Bc_Gui = CInt(cbMa_Bc_Gui.Value)
        frm.myMa_Bc_Nhan = CInt(cbMa_Bc_Nhan.Value)
        frm.ShowDialog()
        'Load_GiaoTuiDi1()
        If frm.myIsOK Then
            'Hiển thị dữ liệu
            Load_GiaoTuiDi()
            Load_GiaoTuiDi1()
            Enable_Control(True)
            'Ket thuc 
            txtSo_Hieu_BC37.Focus()
            lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
            txtSo_Hieu_BC37.Clear()
        Else
            'Ket thuc 
            txtSo_Hieu_BC37.Focus()
            lblSo_Hieu_BC37.Text = txtSo_Hieu_BC37.Text
            txtSo_Hieu_BC37.Clear()
        End If
    End Sub
#End Region

#Region "btnNhap_Moi_E2_Click"
    Private Sub btnNhap_Moi_E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Moi_E2.Click
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                Dim frm As New FrmNhap_Thay_The_E2
                'frm.myBC37_ID = dgGiaoTuiDi1.Rows(i).Cells("BC37_ID").Text
                'frm.myId_Tuyen_VC = CInt(dgGiaoTuiDi1.Rows(i).Cells("MAIL_ROUTE_ID").Text)
                'frm.myNgay_Dong = Ham_Dung_Chung.ConvertDateToInt(CDate(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Lap").Value))
                'frm.myId_Duong_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Duong_Thu").Text
                'frm.myId_Chuyen_Thu = ""
                'frm.mySo_Chuyen_Thu = CInt(dgGiaoTuiDi1.Rows(i).Cells("So_Chuyen_Thu").Text)
                'frm.myMa_Bc_Gui = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc").Text)
                'frm.myMa_Bc_Nhan = CInt(dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc_Khai_Thac").Text)
                frm.ShowDialog()
            End If
        Next
    End Sub
#End Region

#Region "ReCalculate_Summary"
    Private Sub ReCalculate_Summary(ByVal Sender As Object, ByVal Sender1 As Object)
        Dim myGridKeyDown1 As Infragistics.Win.UltraWinGrid.UltraGrid
        myGridKeyDown = Sender
        myGridKeyDown1 = Sender1
        Dim i As Integer
        Dim Tong_So As Integer = 0
        Dim Tong_So_Tui As Integer = 0
        For i = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(i).Cells("BC37_ID").Text <> "" Then
                Tong_So += 1
                Tong_So_Tui += CInt(myGridKeyDown.Rows(i).Cells("Tong_So_Tui").Text)
            End If
        Next
        lblGiaoTuiDi.Text = "Tổng Số : " & Tong_So.ToString & "    " & "Tổng số túi : " & Tong_So_Tui.ToString

        Dim i1 As Integer
        Dim Tong_So1 As Integer = 0
        Dim Tong_So_Tui1 As Integer = 0
        For i1 = 0 To myGridKeyDown1.Rows.Count - 1
            If myGridKeyDown1.Rows(i1).Cells("BC37_ID").Text <> "" Then
                Tong_So1 += 1
                Tong_So_Tui1 += CInt(myGridKeyDown1.Rows(i1).Cells("Tong_So_Tui").Text)
            End If
        Next
        lblGiaoTuiDi1.Text = "Tổng Số : " & Tong_So1.ToString & "    " & "Tổng số túi : " & Tong_So_Tui1.ToString
    End Sub
#End Region

#Region "dgGiaoTuiDi_KeyDown"
    Private Sub dgGiaoTuiDi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGiaoTuiDi.KeyDown
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
    Private Sub Delete_Tui_Goi(ByVal sender As Object, ByVal ActiveRowIndex As Integer)
        myGridKeyDown = sender
        Dim myRowIndex As Integer
        myRowIndex = myGridKeyDown.ActiveRow.Index
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("BC37_ID").Text.Length <> 0 Then
            If CMessageBox.Show("Bạn có thực sự muốn xóa số hiệu BC37 này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
                myGridKeyDown.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

#Region "txtMa_Hieu_Phuong_Tien_Validated"
    Private Sub txtMa_Hieu_Phuong_Tien_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_Hieu_Phuong_Tien.Validated
        txtMa_Hieu_Phuong_Tien.Text = txtMa_Hieu_Phuong_Tien.Text.ToUpper.Trim
    End Sub
#End Region

    Private Sub txtSo_Hieu_BC37_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_Hieu_BC37.ValueChanged

    End Sub
End Class

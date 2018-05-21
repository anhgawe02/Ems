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
Public Class frmXacNhanTuiDen
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
    Friend WithEvents dgGiaoTuiDi As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtThong_Tin_Tui_Goi As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblGhi_Chu As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnXac_Nhan_Tui As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chkChon_Tat1 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dtpNgayDinhDang As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGio_Dinh_Dang As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents dgGiaoTuiDi1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblThong_Tin_Tui_Goi As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblGiaoTuiDi As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblGiaoTuiDi1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnNhap_Moi_E2 As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmXacNhanTuiDen))
        Me.dtpNgayDinhDang = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
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
        Me.btnNhap_Moi_E2 = New Infragistics.Win.Misc.UltraButton
        Me.lblThong_Tin_Tui_Goi = New Infragistics.Win.Misc.UltraLabel
        Me.txtThong_Tin_Tui_Goi = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox
        Me.lblGhi_Chu = New Infragistics.Win.Misc.UltraLabel
        Me.btnXac_Nhan_Tui = New Infragistics.Win.Misc.UltraButton
        Me.txtGio_Dinh_Dang = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
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
        CType(Me.txtThong_Tin_Tui_Goi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpNgayDinhDang
        '
        Me.dtpNgayDinhDang.DateTime = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgayDinhDang.Location = New System.Drawing.Point(340, 278)
        Me.dtpNgayDinhDang.Name = "dtpNgayDinhDang"
        Me.dtpNgayDinhDang.Size = New System.Drawing.Size(88, 21)
        Me.dtpNgayDinhDang.TabIndex = 19
        Me.dtpNgayDinhDang.Value = New Date(2008, 8, 24, 0, 0, 0, 0)
        Me.dtpNgayDinhDang.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.chkChon_Tat1)
        Me.UltraGroupBox1.Controls.Add(Me.btnDel)
        Me.UltraGroupBox1.Controls.Add(Me.btnAdd)
        Me.UltraGroupBox1.Controls.Add(Me.chkChon_Tat)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(768, 400)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        '
        'chkChon_Tat1
        '
        Appearance1.ForeColor = System.Drawing.Color.Blue
        Me.chkChon_Tat1.Appearance = Appearance1
        Me.chkChon_Tat1.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat1.Checked = True
        Me.chkChon_Tat1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat1.Location = New System.Drawing.Point(408, 30)
        Me.chkChon_Tat1.Name = "chkChon_Tat1"
        Me.chkChon_Tat1.Size = New System.Drawing.Size(16, 16)
        Me.chkChon_Tat1.TabIndex = 7
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(368, 160)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 24)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "<<"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(368, 128)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 24)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = ">>"
        '
        'chkChon_Tat
        '
        Appearance2.ForeColor = System.Drawing.Color.Blue
        Me.chkChon_Tat.Appearance = Appearance2
        Me.chkChon_Tat.BackColor = System.Drawing.SystemColors.Control
        Me.chkChon_Tat.Checked = True
        Me.chkChon_Tat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChon_Tat.Location = New System.Drawing.Point(16, 30)
        Me.chkChon_Tat.Name = "chkChon_Tat"
        Me.chkChon_Tat.Size = New System.Drawing.Size(16, 16)
        Me.chkChon_Tat.TabIndex = 2
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.lblGiaoTuiDi1)
        Me.UltraGroupBox3.Controls.Add(Me.dgGiaoTuiDi1)
        Me.UltraGroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox3.HeaderAppearance = Appearance3
        Me.UltraGroupBox3.Location = New System.Drawing.Point(400, 8)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(360, 392)
        Me.UltraGroupBox3.SupportThemes = False
        Me.UltraGroupBox3.TabIndex = 1
        Me.UltraGroupBox3.Text = "Thông tin túi gói chờ xác nhận đến"
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
        Me.lblGiaoTuiDi1.Location = New System.Drawing.Point(2, 374)
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
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(25, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1.Width = 28
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance8
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance10
        UltraGridColumn3.Header.Caption = "Mã BC"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Width = 70
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn4.CellAppearance = Appearance11
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance12
        UltraGridColumn4.Header.Caption = "SCT"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 33
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance13
        UltraGridColumn5.Header.Caption = "Id ca"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance15
        UltraGridColumn6.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance16
        UltraGridColumn7.EditorControl = Me.dtpNgayDinhDang
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance17
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
        UltraGridColumn7.Width = 74
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance18
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance19
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance20
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn11.CellAppearance = Appearance21
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance22
        UltraGridColumn11.Header.Caption = "Túi số"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Width = 40
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance23
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn13.CellAppearance = Appearance24
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance25
        UltraGridColumn13.Header.Caption = "Tổng số BP"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Width = 51
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellAppearance = Appearance26
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance27
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance28
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance29
        UltraGridColumn15.Header.Caption = "Tổng KL"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 47
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance30
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance31
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance32
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance33
        UltraGridColumn19.Header.VisiblePosition = 21
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance34
        UltraGridColumn20.Header.VisiblePosition = 22
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance35
        UltraGridColumn21.Header.Caption = "Truyền khai thác"
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance36
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance37
        UltraGridColumn23.Header.Caption = "Ngày hệ thống"
        UltraGridColumn23.Header.VisiblePosition = 12
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance38
        UltraGridColumn24.Header.Caption = "Chốt số liệu"
        UltraGridColumn24.Header.VisiblePosition = 16
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance39
        UltraGridColumn25.Header.Caption = "Mã E4"
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance40
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance41
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance42
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance43
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        Appearance44.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.CellAppearance = Appearance44
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance45
        UltraGridColumn30.Header.Caption = "Chuyển tiếp"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance46.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance46
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgGiaoTuiDi1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgGiaoTuiDi1.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.CardAreaAppearance = Appearance47
        Me.dgGiaoTuiDi1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.ForeColor = System.Drawing.Color.Black
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance48.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderAppearance = Appearance48
        Me.dgGiaoTuiDi1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance49.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowAppearance = Appearance49
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorAppearance = Appearance50
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance51.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectedRowAppearance = Appearance51
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi1.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi1.Name = "dgGiaoTuiDi1"
        Me.dgGiaoTuiDi1.Size = New System.Drawing.Size(356, 358)
        Me.dgGiaoTuiDi1.TabIndex = 17
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.lblGiaoTuiDi)
        Me.UltraGroupBox2.Controls.Add(Me.dgGiaoTuiDi)
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Appearance52.FontData.BoldAsString = "True"
        Appearance52.ForeColor = System.Drawing.Color.Black
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox2.HeaderAppearance = Appearance52
        Me.UltraGroupBox2.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.UltraGroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(360, 392)
        Me.UltraGroupBox2.SupportThemes = False
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "Thông tin túi gói đến"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblGiaoTuiDi
        '
        Appearance53.BackColor = System.Drawing.Color.Black
        Appearance53.ForeColor = System.Drawing.Color.White
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance53.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.lblGiaoTuiDi.Appearance = Appearance53
        Me.lblGiaoTuiDi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblGiaoTuiDi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiaoTuiDi.Location = New System.Drawing.Point(2, 374)
        Me.lblGiaoTuiDi.Name = "lblGiaoTuiDi"
        Me.lblGiaoTuiDi.Size = New System.Drawing.Size(356, 16)
        Me.lblGiaoTuiDi.TabIndex = 19
        '
        'dgGiaoTuiDi
        '
        Me.dgGiaoTuiDi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgGiaoTuiDi.DisplayLayout.AddNewBox.Prompt = " "
        Appearance54.BackColor = System.Drawing.Color.White
        Appearance54.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgGiaoTuiDi.DisplayLayout.Appearance = Appearance54
        UltraGridBand2.CardSettings.ShowCaption = False
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn31.CellAppearance = Appearance55
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance56
        UltraGridColumn31.Header.Caption = ""
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(25, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Width = 28
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance57
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.CellAppearance = Appearance58
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance59
        UltraGridColumn33.Header.Caption = "Mã BC"
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Width = 72
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn34.CellAppearance = Appearance60
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance61
        UltraGridColumn34.Header.Caption = "SCT"
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Width = 33
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance62
        UltraGridColumn35.Header.Caption = "Id ca"
        UltraGridColumn35.Header.VisiblePosition = 4
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.CellAppearance = Appearance63
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance64
        UltraGridColumn36.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.CellAppearance = Appearance65
        UltraGridColumn37.EditorControl = Me.dtpNgayDinhDang
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance66
        UltraGridColumn37.Header.Caption = "Ngày đóng"
        UltraGridColumn37.Header.VisiblePosition = 6
        UltraGridColumn37.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.UseEditorMaskSettings = True
        UltraGridColumn37.Width = 78
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance67
        UltraGridColumn38.Header.VisiblePosition = 7
        UltraGridColumn38.Hidden = True
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance68
        UltraGridColumn39.Header.VisiblePosition = 8
        UltraGridColumn39.Hidden = True
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance69
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn41.CellAppearance = Appearance70
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn41.Header.Appearance = Appearance71
        UltraGridColumn41.Header.Caption = "Túi số"
        UltraGridColumn41.Header.VisiblePosition = 10
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Width = 43
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance72
        UltraGridColumn42.Header.VisiblePosition = 11
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn43.CellAppearance = Appearance73
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance74
        UltraGridColumn43.Header.Caption = "Tổng số BP"
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Width = 59
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn44.CellAppearance = Appearance75
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance76
        UltraGridColumn44.Header.VisiblePosition = 14
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn45.CellAppearance = Appearance77
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance78
        UltraGridColumn45.Header.Caption = "Tổng KL"
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Width = 54
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance79.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance79
        UltraGridColumn46.Header.VisiblePosition = 17
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance80
        UltraGridColumn47.Header.VisiblePosition = 19
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance81
        UltraGridColumn48.Header.VisiblePosition = 20
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance82.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance82
        UltraGridColumn49.Header.VisiblePosition = 21
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance83
        UltraGridColumn50.Header.VisiblePosition = 22
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance84.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance84
        UltraGridColumn51.Header.Caption = "Truyền khai thác"
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance85.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance85
        UltraGridColumn52.Header.VisiblePosition = 23
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance86
        UltraGridColumn53.Header.Caption = "Ngày hệ thống"
        UltraGridColumn53.Header.VisiblePosition = 12
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance87.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance87
        UltraGridColumn54.Header.Caption = "Chốt số liệu"
        UltraGridColumn54.Header.VisiblePosition = 16
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance88.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance88
        UltraGridColumn55.Header.Caption = "Mã số E4"
        UltraGridColumn55.Header.VisiblePosition = 24
        UltraGridColumn55.Width = 177
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance89.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance89
        UltraGridColumn56.Header.VisiblePosition = 25
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance90.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance90
        UltraGridColumn57.Header.VisiblePosition = 26
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance91.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance91
        UltraGridColumn58.Header.VisiblePosition = 27
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance92.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance92
        UltraGridColumn59.Header.VisiblePosition = 28
        UltraGridColumn59.Hidden = True
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.CellAppearance = Appearance93
        Appearance94.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance94
        UltraGridColumn60.Header.Caption = "Chuyển tiếp"
        UltraGridColumn60.Header.VisiblePosition = 29
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance95.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand2.Override.RowSelectorAppearance = Appearance95
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        Me.dgGiaoTuiDi.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgGiaoTuiDi.DisplayLayout.InterBandSpacing = 10
        Me.dgGiaoTuiDi.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.CardAreaAppearance = Appearance96
        Me.dgGiaoTuiDi.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance97.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance97.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance97.ForeColor = System.Drawing.Color.Black
        Appearance97.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance97.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderAppearance = Appearance97
        Me.dgGiaoTuiDi.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance98.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowAppearance = Appearance98
        Appearance99.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance99.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance99.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorAppearance = Appearance99
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgGiaoTuiDi.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance100.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance100.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.ForeColor = System.Drawing.Color.Black
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectedRowAppearance = Appearance100
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgGiaoTuiDi.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgGiaoTuiDi.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgGiaoTuiDi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGiaoTuiDi.Location = New System.Drawing.Point(2, 18)
        Me.dgGiaoTuiDi.Name = "dgGiaoTuiDi"
        Me.dgGiaoTuiDi.Size = New System.Drawing.Size(356, 358)
        Me.dgGiaoTuiDi.TabIndex = 16
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.btnNhap_Moi_E2)
        Me.UltraGroupBox4.Controls.Add(Me.lblThong_Tin_Tui_Goi)
        Me.UltraGroupBox4.Controls.Add(Me.txtThong_Tin_Tui_Goi)
        Me.UltraGroupBox4.ForeColor = System.Drawing.SystemColors.Control
        Appearance101.FontData.BoldAsString = "True"
        Appearance101.ForeColor = System.Drawing.Color.Black
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox4.HeaderAppearance = Appearance101
        Me.UltraGroupBox4.Location = New System.Drawing.Point(8, 400)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(752, 56)
        Me.UltraGroupBox4.SupportThemes = False
        Me.UltraGroupBox4.TabIndex = 2
        Me.UltraGroupBox4.Text = "Số hiệu túi gói"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnNhap_Moi_E2
        '
        Appearance102.ForeColor = System.Drawing.Color.Black
        Me.btnNhap_Moi_E2.Appearance = Appearance102
        Me.btnNhap_Moi_E2.Location = New System.Drawing.Point(333, 18)
        Me.btnNhap_Moi_E2.Name = "btnNhap_Moi_E2"
        Me.btnNhap_Moi_E2.Size = New System.Drawing.Size(92, 34)
        Me.btnNhap_Moi_E2.TabIndex = 20
        Me.btnNhap_Moi_E2.Text = "Nhập thay thế"
        '
        'lblThong_Tin_Tui_Goi
        '
        Appearance103.ForeColor = System.Drawing.Color.Black
        Me.lblThong_Tin_Tui_Goi.Appearance = Appearance103
        Me.lblThong_Tin_Tui_Goi.BackColor = System.Drawing.Color.White
        Me.lblThong_Tin_Tui_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin_Tui_Goi.Location = New System.Drawing.Point(432, 24)
        Me.lblThong_Tin_Tui_Goi.Name = "lblThong_Tin_Tui_Goi"
        Me.lblThong_Tin_Tui_Goi.Size = New System.Drawing.Size(312, 24)
        Me.lblThong_Tin_Tui_Goi.TabIndex = 1
        '
        'txtThong_Tin_Tui_Goi
        '
        Appearance104.BackColor = System.Drawing.Color.White
        Appearance104.ForeColor = System.Drawing.Color.Green
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance104.TextVAlign = Infragistics.Win.VAlign.Middle
        Me.txtThong_Tin_Tui_Goi.Appearance = Appearance104
        Me.txtThong_Tin_Tui_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThong_Tin_Tui_Goi.Location = New System.Drawing.Point(8, 20)
        Me.txtThong_Tin_Tui_Goi.Multiline = True
        Me.txtThong_Tin_Tui_Goi.Name = "txtThong_Tin_Tui_Goi"
        Me.txtThong_Tin_Tui_Goi.Size = New System.Drawing.Size(320, 30)
        Me.txtThong_Tin_Tui_Goi.TabIndex = 0
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.lblGhi_Chu)
        Me.UltraGroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Appearance105.FontData.BoldAsString = "True"
        Appearance105.ForeColor = System.Drawing.Color.Black
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        Me.UltraGroupBox5.HeaderAppearance = Appearance105
        Me.UltraGroupBox5.Location = New System.Drawing.Point(8, 456)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(752, 80)
        Me.UltraGroupBox5.SupportThemes = False
        Me.UltraGroupBox5.TabIndex = 3
        Me.UltraGroupBox5.Text = "Thông tin túi gói"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblGhi_Chu
        '
        Appearance106.BackColor = System.Drawing.Color.Black
        Appearance106.ForeColor = System.Drawing.Color.Green
        Me.lblGhi_Chu.Appearance = Appearance106
        Me.lblGhi_Chu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGhi_Chu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGhi_Chu.Location = New System.Drawing.Point(2, 18)
        Me.lblGhi_Chu.Name = "lblGhi_Chu"
        Me.lblGhi_Chu.Size = New System.Drawing.Size(748, 60)
        Me.lblGhi_Chu.TabIndex = 0
        '
        'btnXac_Nhan_Tui
        '
        Me.btnXac_Nhan_Tui.Location = New System.Drawing.Point(8, 540)
        Me.btnXac_Nhan_Tui.Name = "btnXac_Nhan_Tui"
        Me.btnXac_Nhan_Tui.Size = New System.Drawing.Size(752, 32)
        Me.btnXac_Nhan_Tui.TabIndex = 4
        Me.btnXac_Nhan_Tui.Text = "Xác nhận túi gói đến (F2)"
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
        Me.txtGio_Dinh_Dang.TabIndex = 20
        Me.txtGio_Dinh_Dang.Text = ":"
        Me.txtGio_Dinh_Dang.Visible = False
        '
        'frmXacNhanTuiDen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(768, 576)
        Me.Controls.Add(Me.btnXac_Nhan_Tui)
        Me.Controls.Add(Me.UltraGroupBox5)
        Me.Controls.Add(Me.UltraGroupBox4)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.dtpNgayDinhDang)
        Me.Controls.Add(Me.txtGio_Dinh_Dang)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmXacNhanTuiDen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách xác nhận túi gói đến"
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
        CType(Me.txtThong_Tin_Tui_Goi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien trong Form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim myDuong_Thu_Den_Chi_Tiet As New Duong_Thu_Den_Chi_Tiet
    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
    Dim myQLTGND_POSTBAG As New QLTGND_POSTBAG(GConnectionString)
    Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG(GConnectionString)
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet
    Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
    Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet
    'Public myId_BC37 As String
    Public myTRANSPORT_TYPE As String
    Public myMAIL_ROUTE_ID As Integer
    Public myPARTNER_ID As Integer
    Public myDot_Giao As Integer
    Public myTRANSPORT_NUMBER As String
    Public myDataBC37Select As DataTable
    Dim chuoi_bc37_id As String
#End Region

    Private Sub frmXacNhanTuiDen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lay chuoi bc37_id
        chuoi_bc37_id = "('"
        For Each mrow As DataRow In myDataBC37Select.Rows
            chuoi_bc37_id = chuoi_bc37_id & mrow.Item("BC37_ID") & "','"
        Next
        chuoi_bc37_id = chuoi_bc37_id.Substring(0, chuoi_bc37_id.Length - 2) & ")"
        Load_GiaoTuiDi()
        Load_GiaoTuiDi1()
        Noi_Dung_Ghi_Chu()
        Me.ActiveControl = Me.txtThong_Tin_Tui_Goi
        txtThong_Tin_Tui_Goi.Focus()
    End Sub

    Private Sub Load_GiaoTuiDi()
        'dgGiaoTuiDi.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai(myId_BC37, 0).Tables(0)
        dgGiaoTuiDi.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Danh_Sach_BC37_ID_Trang_Thai(chuoi_bc37_id, gTrang_Thai_0, GBuu_Cuc_Khai_Thac)
        dgGiaoTuiDi.DataBind()
    End Sub

    Private Sub Load_GiaoTuiDi1()
        'dgGiaoTuiDi1.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID_Trang_Thai(myId_BC37, 1).Tables(0)
        dgGiaoTuiDi1.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_Danh_Sach_BC37_ID_Trang_Thai(chuoi_bc37_id, gTrang_Thai_1, GBuu_Cuc_Khai_Thac)
        dgGiaoTuiDi1.DataBind()
    End Sub

    Private Sub Noi_Dung_Ghi_Chu()
        lblGhi_Chu.Text = "- Số hiệu Bc 37 : " & chuoi_bc37_id
    End Sub

    Private Sub chkChon_Tat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChon_Tat.CheckedChanged
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            dgGiaoTuiDi.Rows(i).Cells("Chon").Value = chkChon_Tat.Checked
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            'CMessageBox.Show("Hiện tại chưa có dữ liệu !!!", "Thông báo")
            Exit Sub
        End If
    End Sub

    Private Sub chkChon_Tat1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChon_Tat1.CheckedChanged
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = chkChon_Tat1.Checked
            kiem_tra_chon = True
        Next
        If kiem_tra_chon = False Then
            'CMessageBox.Show("Hiện tại chưa có dữ liệu !!!", "Thông báo")
            Exit Sub
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
            If dgGiaoTuiDi.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_POSTBAG_DEN_Chi_Tiet
                    .Chot_SL = dgGiaoTuiDi.Rows(i).Cells("Chot_SL").Value
                    .Gio_Dong = dgGiaoTuiDi.Rows(i).Cells("Gio_Dong").Value
                    .Gio_Nhan = dgGiaoTuiDi.Rows(i).Cells("Gio_Nhan").Value
                    .HH_Phat_Hanh = dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Hanh").Value
                    .HH_Phat_Tra = dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Tra").Value
                    .Id_BC37 = dgGiaoTuiDi.Rows(i).Cells("Id_BC37").Value
                    .Id_Ca = dgGiaoTuiDi.Rows(i).Cells("Id_Ca").Value
                    .Id_Chuyen_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Chuyen_Thu").Value
                    .Id_Duong_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Duong_Thu").Value
                    .Id_E2 = dgGiaoTuiDi.Rows(i).Cells("Id_E2").Value
                    .Id_Tui_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Tui_Thu").Value
                    .Khoi_Luong_BP = dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_BP").Value
                    .Khoi_Luong_Vo_Tui = dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value
                    .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                    .Ma_Bc = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc").Value)
                    .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Dong").Value)
                    .Ngay_He_Thong = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_He_Thong").Value)
                    .Ngay_Nhan = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Nhan").Value)
                    .Tong_Cuoc_Chinh = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_Chinh").Value)
                    .Tong_Cuoc_COD = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_COD").Value)
                    .Tong_Cuoc_DV = dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_DV").Value
                    .Tong_So_BP = dgGiaoTuiDi.Rows(i).Cells("Tong_So_BP").Value
                    .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
                    .Truyen_Doi_Soat = dgGiaoTuiDi.Rows(i).Cells("Truyen_Doi_Soat").Value
                    .Truyen_Khai_Thac = dgGiaoTuiDi.Rows(i).Cells("Truyen_Khai_Thac").Value
                    .Tui_F = dgGiaoTuiDi.Rows(i).Cells("Tui_F").Value
                    .Tui_So = dgGiaoTuiDi.Rows(i).Cells("Tui_So").Value
                    .So_Chuyen_Thu = dgGiaoTuiDi.Rows(i).Cells("So_Chuyen_Thu").Value
                    .IS_TRANSITION = CBool(dgGiaoTuiDi.Rows(i).Cells("IS_TRANSITION").Value)
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

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim kiem_tra_chon As Boolean = False
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                With myQLTGND_POSTBAG_DEN_Chi_Tiet
                    .Chot_SL = dgGiaoTuiDi1.Rows(i).Cells("Chot_SL").Value
                    .Gio_Dong = dgGiaoTuiDi1.Rows(i).Cells("Gio_Dong").Value
                    .Gio_Nhan = dgGiaoTuiDi1.Rows(i).Cells("Gio_Nhan").Value
                    .HH_Phat_Hanh = dgGiaoTuiDi1.Rows(i).Cells("HH_Phat_Hanh").Value
                    .HH_Phat_Tra = dgGiaoTuiDi1.Rows(i).Cells("HH_Phat_Tra").Value
                    .Id_BC37 = dgGiaoTuiDi1.Rows(i).Cells("Id_BC37").Value
                    .Id_Ca = dgGiaoTuiDi1.Rows(i).Cells("Id_Ca").Value
                    .Id_Chuyen_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Chuyen_Thu").Value
                    .Id_Duong_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Duong_Thu").Value
                    .Id_E2 = dgGiaoTuiDi1.Rows(i).Cells("Id_E2").Value
                    .Id_Tui_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Tui_Thu").Value
                    .Khoi_Luong_BP = dgGiaoTuiDi1.Rows(i).Cells("Khoi_Luong_BP").Value
                    .Khoi_Luong_Vo_Tui = dgGiaoTuiDi1.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value
                    .Ma_Bc_Khai_Thac = dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc_Khai_Thac").Value
                    .Ma_Bc = dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc").Value
                    .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Dong").Value)
                    .Ngay_He_Thong = dgGiaoTuiDi1.Rows(i).Cells("Ngay_He_Thong").Value
                    .Ngay_Nhan = dgGiaoTuiDi1.Rows(i).Cells("Ngay_Nhan").Value
                    .Tong_Cuoc_Chinh = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_Chinh").Value
                    .Tong_Cuoc_COD = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_COD").Value
                    .Tong_Cuoc_DV = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_DV").Value
                    .Tong_So_BP = dgGiaoTuiDi1.Rows(i).Cells("Tong_So_BP").Value
                    .Trang_Thai = Trang_Thai_Chua_Xac_Nhan
                    .Truyen_Doi_Soat = dgGiaoTuiDi1.Rows(i).Cells("Truyen_Doi_Soat").Value
                    .Truyen_Khai_Thac = dgGiaoTuiDi1.Rows(i).Cells("Truyen_Khai_Thac").Value
                    .Tui_F = dgGiaoTuiDi1.Rows(i).Cells("Tui_F").Value
                    .Tui_So = dgGiaoTuiDi1.Rows(i).Cells("Tui_So").Value
                    .So_Chuyen_Thu = dgGiaoTuiDi1.Rows(i).Cells("So_Chuyen_Thu").Value
                    .IS_TRANSITION = CBool(dgGiaoTuiDi1.Rows(i).Cells("IS_TRANSITION").Value)
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

    Private Sub txtThong_Tin_Tui_Goi_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtThong_Tin_Tui_Goi.Validated
        Try
            If txtThong_Tin_Tui_Goi.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            Dim myCode As String = txtThong_Tin_Tui_Goi.Text.ToUpper
            txtThong_Tin_Tui_Goi.Text = txtThong_Tin_Tui_Goi.Text.ToUpper
            'Tích chọn những BC37
            Dim myE4Code As New DycryptBarCode.e4code
            If (myE4Code.check(myCode) = True) Then
                Dim kiem_tra_chon As Boolean = False
                Dim i As Integer
                For i = 0 To dgGiaoTuiDi.Rows.Count - 1
                    If dgGiaoTuiDi.Rows(i).Cells("Id_Tui_Thu").Value = myCode Then
                        With myQLTGND_POSTBAG_DEN_Chi_Tiet
                            .Chot_SL = dgGiaoTuiDi.Rows(i).Cells("Chot_SL").Value
                            .Gio_Dong = dgGiaoTuiDi.Rows(i).Cells("Gio_Dong").Value
                            .Gio_Nhan = dgGiaoTuiDi.Rows(i).Cells("Gio_Nhan").Value
                            .HH_Phat_Hanh = dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Hanh").Value
                            .HH_Phat_Tra = dgGiaoTuiDi.Rows(i).Cells("HH_Phat_Tra").Value
                            .Id_BC37 = dgGiaoTuiDi.Rows(i).Cells("Id_BC37").Value
                            .Id_Ca = dgGiaoTuiDi.Rows(i).Cells("Id_Ca").Value
                            .Id_Chuyen_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Chuyen_Thu").Value
                            .Id_Duong_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Duong_Thu").Value
                            .Id_E2 = dgGiaoTuiDi.Rows(i).Cells("Id_E2").Value
                            .Id_Tui_Thu = dgGiaoTuiDi.Rows(i).Cells("Id_Tui_Thu").Value
                            .Khoi_Luong_BP = dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_BP").Value
                            .Khoi_Luong_Vo_Tui = dgGiaoTuiDi.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value
                            .Ma_Bc_Khai_Thac = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc_Khai_Thac").Value)
                            .Ma_Bc = CInt(dgGiaoTuiDi.Rows(i).Cells("Ma_Bc").Value)
                            .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Dong").Value)
                            .Ngay_He_Thong = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_He_Thong").Value)
                            .Ngay_Nhan = CInt(dgGiaoTuiDi.Rows(i).Cells("Ngay_Nhan").Value)
                            .Tong_Cuoc_Chinh = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_Chinh").Value)
                            .Tong_Cuoc_COD = CInt(dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_COD").Value)
                            .Tong_Cuoc_DV = dgGiaoTuiDi.Rows(i).Cells("Tong_Cuoc_DV").Value
                            .Tong_So_BP = dgGiaoTuiDi.Rows(i).Cells("Tong_So_BP").Value
                            .Trang_Thai = Trang_Thai_Dang_Xac_Nhan
                            .Truyen_Doi_Soat = dgGiaoTuiDi.Rows(i).Cells("Truyen_Doi_Soat").Value
                            .Truyen_Khai_Thac = dgGiaoTuiDi.Rows(i).Cells("Truyen_Khai_Thac").Value
                            .Tui_F = dgGiaoTuiDi.Rows(i).Cells("Tui_F").Value
                            .Tui_So = dgGiaoTuiDi.Rows(i).Cells("Tui_So").Value
                            .So_Chuyen_Thu = dgGiaoTuiDi.Rows(i).Cells("So_Chuyen_Thu").Value
                            .IS_TRANSITION = CBool(dgGiaoTuiDi.Rows(i).Cells("IS_TRANSITION").Value)
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
                        kiem_tra_chon = True
                    End If
                Next
                Load_GiaoTuiDi()
                Load_GiaoTuiDi1()
                ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
                If kiem_tra_chon = True Then
                    lblThong_Tin_Tui_Goi.Text = txtThong_Tin_Tui_Goi.Text
                    txtThong_Tin_Tui_Goi.Focus()
                    txtThong_Tin_Tui_Goi.Clear()
                    Exit Sub
                Else
                    If MessageBox.Show("Túi này không có dữ liệu truyền về hoặc không thuộc những BC37 mà bạn đang chọn!!!" & vbNewLine & "Bạn có muốn nhâp thay thế không (lưu ý chỉ có thể nhập thay thế đối với những túi thuộc BC37 mà bạn đã chọn trước đó.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                        btnNhap_Moi_E2_Click(btnNhap_Moi_E2, Nothing)
                    Else
                        txtThong_Tin_Tui_Goi.SelectAll()
                        txtThong_Tin_Tui_Goi.Focus()
                        Exit Sub
                    End If
                End If
            Else
                MessageBox.Show("Bạn phải nhập chính xác định dạng mã E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtThong_Tin_Tui_Goi.SelectAll()
                txtThong_Tin_Tui_Goi.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnXac_Nhan_Tui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXac_Nhan_Tui.Click
        Dim kiem_tra_chon As Boolean = False
        Dim Tong_So As Integer = 1
        Dim i As Integer
        For i = 0 To dgGiaoTuiDi1.Rows.Count - 1
            If dgGiaoTuiDi1.Rows(i).Cells("Chon").Value = True Then
                Tong_So = Tong_So + i
                With myQLTGND_POSTBAG_DEN_Chi_Tiet
                    .Chot_SL = dgGiaoTuiDi1.Rows(i).Cells("Chot_SL").Value
                    .Gio_Dong = dgGiaoTuiDi1.Rows(i).Cells("Gio_Dong").Value
                    .Gio_Nhan = dgGiaoTuiDi1.Rows(i).Cells("Gio_Nhan").Value
                    .HH_Phat_Hanh = dgGiaoTuiDi1.Rows(i).Cells("HH_Phat_Hanh").Value
                    .HH_Phat_Tra = dgGiaoTuiDi1.Rows(i).Cells("HH_Phat_Tra").Value
                    .Id_BC37 = dgGiaoTuiDi1.Rows(i).Cells("Id_BC37").Value
                    .Id_Ca = dgGiaoTuiDi1.Rows(i).Cells("Id_Ca").Value
                    .Id_Chuyen_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Chuyen_Thu").Value
                    .Id_Duong_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Duong_Thu").Value
                    .Id_E2 = dgGiaoTuiDi1.Rows(i).Cells("Id_E2").Value
                    .Id_Tui_Thu = dgGiaoTuiDi1.Rows(i).Cells("Id_Tui_Thu").Value
                    .Khoi_Luong_BP = dgGiaoTuiDi1.Rows(i).Cells("Khoi_Luong_BP").Value
                    .Khoi_Luong_Vo_Tui = dgGiaoTuiDi1.Rows(i).Cells("Khoi_Luong_Vo_Tui").Value
                    .Ma_Bc_Khai_Thac = dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc_Khai_Thac").Value
                    .Ma_Bc = dgGiaoTuiDi1.Rows(i).Cells("Ma_Bc").Value
                    .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(dgGiaoTuiDi1.Rows(i).Cells("Ngay_Dong").Value)
                    .Ngay_He_Thong = dgGiaoTuiDi1.Rows(i).Cells("Ngay_He_Thong").Value
                    .Ngay_Nhan = dgGiaoTuiDi1.Rows(i).Cells("Ngay_Nhan").Value
                    .Tong_Cuoc_Chinh = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_Chinh").Value
                    .Tong_Cuoc_COD = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_COD").Value
                    .Tong_Cuoc_DV = dgGiaoTuiDi1.Rows(i).Cells("Tong_Cuoc_DV").Value
                    .Tong_So_BP = dgGiaoTuiDi1.Rows(i).Cells("Tong_So_BP").Value
                    .Trang_Thai = Trang_Thai_Da_Hoan_Tat
                    .Truyen_Doi_Soat = dgGiaoTuiDi1.Rows(i).Cells("Truyen_Doi_Soat").Value
                    .Truyen_Khai_Thac = dgGiaoTuiDi1.Rows(i).Cells("Truyen_Khai_Thac").Value
                    .Tui_F = dgGiaoTuiDi1.Rows(i).Cells("Tui_F").Value
                    .Tui_So = dgGiaoTuiDi1.Rows(i).Cells("Tui_So").Value
                    .So_Chuyen_Thu = dgGiaoTuiDi1.Rows(i).Cells("So_Chuyen_Thu").Value
                    .IS_TRANSITION = CBool(dgGiaoTuiDi1.Rows(i).Cells("IS_TRANSITION").Value)
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

                myQLTGND_POSTBAG.QLTGND_POSTBAG_Cap_Nhat_Them(myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Tui_Thu, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_So, _
                    0, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc.ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.So_Chuyen_Thu, _
                    "A", _
                    "E", _
                    IIf(myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_F = True, 1, 0), _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_BP, _
                    IIf(myQLTGND_POSTBAG_DEN_Chi_Tiet.IS_TRANSITION = True, gStatus_Postbag_2, gStatus_Postbag_3.ToString), _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Tong_So_BP, _
                    myTRANSPORT_TYPE, _
                    Date.Now, _
                    Gid_Nguoi_Dung, _
                    GetMacAddress(), _
                    "", _
                    Date.Now, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Khoi_Luong_Vo_Tui, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_BC37.ToString, _
                    gIS_PRINTER_1, _
                    Date.Now, _
                    GTen_Dang_Nhap, _
                    gIS_DISCRETE_1, _
                    gIS_DELIVERY_ROUTE_1, _
                    Ham_Dung_Chung.ConvertDateToInt(Date.Now).ToString, _
                    Date.Now, _
                    0, _
                    myDot_Giao.ToString)
                myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay(GId_Ca)
                Dim Id_Mail_Trip_Transport_Postbag As Integer = myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Cap_Nhat_Them(0, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Tui_So.ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc.ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                    "A", _
                    "E", _
                    Ham_Dung_Chung.ConvertDateToInt(Date.Now).ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.So_Chuyen_Thu.ToString, _
                    gStatus_Postbag_2.ToString, _
                    (i + 1).ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc.ToString, _
                    Date.Now, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                    myTRANSPORT_TYPE.ToString, _
                    (i + 1).ToString, _
                    GTen_Dang_Nhap, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc_Khai_Thac.ToString, _
                    GTen_Dang_Nhap, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Ma_Bc.ToString, _
                    Date.Now, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_Tui_Thu.ToString, _
                    myQLTGND_POSTBAG_DEN_Chi_Tiet.Id_BC37.ToString, _
                    myTRANSPORT_NUMBER, _
                    gWAY_TYPE_1, _
                    myMAIL_ROUTE_ID, _
                    myPARTNER_ID, _
                    myCa_San_Xuat_Chi_Tiet.Thu_Tu, _
                    Ham_Dung_Chung.ConvertIntToDate(myCa_San_Xuat_Chi_Tiet.Ngay_Khai_Thac))
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

        CMessageBox.Show("Đã xác nhận xong túi gói trong các BC37 " & chuoi_bc37_id, "Thông báo", MessageBoxButtons.OK)
        Close()
    End Sub

    Private Sub frmXacNhanTuiDen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End Select
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "ReCalculate_Summary"
    Private Sub ReCalculate_Summary(ByVal Sender As Object, ByVal Sender1 As Object)
        Dim myGridKeyDown1 As Infragistics.Win.UltraWinGrid.UltraGrid
        myGridKeyDown = Sender
        myGridKeyDown1 = Sender1
        Dim i As Integer
        Dim Tong_So As Integer = 0
        Dim Tong_So_BP As Integer = 0
        For i = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(i).Cells("Id_E2").Text <> "" Then
                Tong_So += 1
                Tong_So_BP += CInt(myGridKeyDown.Rows(i).Cells("Tong_So_BP").Text)
            End If
        Next
        lblGiaoTuiDi.Text = "Tổng Số : " & Tong_So.ToString & "    " & "Tổng số bưu phẩm : " & Tong_So_BP.ToString

        Dim i1 As Integer
        Dim Tong_So1 As Integer = 0
        Dim Tong_So_BP1 As Integer = 0
        For i1 = 0 To myGridKeyDown1.Rows.Count - 1
            If myGridKeyDown1.Rows(i1).Cells("Id_E2").Text <> "" Then
                Tong_So1 += 1
                Tong_So_BP1 += CInt(myGridKeyDown1.Rows(i1).Cells("Tong_So_BP").Text)
            End If
        Next
        lblGiaoTuiDi1.Text = "Tổng Số : " & Tong_So1.ToString & "    " & "Tổng số bưu phẩm : " & Tong_So_BP1.ToString
    End Sub
#End Region

#Region "KeyDown"
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
        If myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index).Cells("Id_E2").Text.Length <> 0 Then
            If CMessageBox.Show("Bạn có thực sự muốn xóa túi gói này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Xoa(myGridKeyDown.Rows(ActiveRowIndex).Cells("Id_E2").Text)
                myGridKeyDown.ActiveRow.Delete(False)
                CMessageBox.Show("Đã xóa thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
#End Region

    Private Sub txtThong_Tin_Tui_Goi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtThong_Tin_Tui_Goi.KeyDown
        'If (e.KeyCode = Keys.Enter) Then


        'Try
        '    If txtThong_Tin_Tui_Goi.Text.Trim.Length = 0 Then
        '        Exit Sub
        '    End If
        '    txtThong_Tin_Tui_Goi.Text = txtThong_Tin_Tui_Goi.Text.ToUpper
        '    'Tích chọn những BC37
        '    Dim myE4Code As New DycryptBarCode.e4code
        '    If (myE4Code.check(txtThong_Tin_Tui_Goi.Text.Trim) = True) Then
        '        Dim kiem_tra_chon As Boolean = False
        '        Dim i As Integer
        '        For i = 0 To dgGiaoTuiDi.Rows.Count - 1
        '            If dgGiaoTuiDi.Rows(i).Cells("Id_Tui_Thu").Value = txtThong_Tin_Tui_Goi.Text.Trim Then
        '                dgGiaoTuiDi.Rows(i).Cells("Chon").Value = True
        '                kiem_tra_chon = True
        '            End If
        '        Next
        '        If kiem_tra_chon = True Then
        '            btnAdd_Click(sender, e)
        '            lblThong_Tin_Tui_Goi.Text = txtThong_Tin_Tui_Goi.Text
        '            txtThong_Tin_Tui_Goi.Focus()
        '            txtThong_Tin_Tui_Goi.Clear()
        '            Exit Sub
        '        Else
        '            If MessageBox.Show("Túi này không có dữ liệu truyền về hoặc không thuộc những BC37 mà bạn đang chọn!!!" & vbNewLine & "Bạn có muốn nhâp thay thế không (lưu ý chỉ có thể nhập thay thế đối với những túi thuộc BC37 mà bạn đã chọn trước đó.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
        '                btnNhap_Moi_E2_Click(btnNhap_Moi_E2, Nothing)
        '            Else
        '                txtThong_Tin_Tui_Goi.SelectAll()
        '                txtThong_Tin_Tui_Goi.Focus()
        '                Exit Sub
        '            End If
        '        End If
        '        ReCalculate_Summary(dgGiaoTuiDi, dgGiaoTuiDi1)
        '    Else
        '        MessageBox.Show("Bạn phải nhập chính xác định dạng mã E4", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        txtThong_Tin_Tui_Goi.SelectAll()
        '        txtThong_Tin_Tui_Goi.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
    End Sub

#Region "btnNhap_Moi_E2_Click"
    Private Sub btnNhap_Moi_E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Moi_E2.Click
        Try
            Dim Frm As New FrmNhap_Thay_The_E2
            'Truyen bien cho form Nhap thay the
            Frm.chuoi_bc37_id = chuoi_bc37_id
            Frm.id_tui_thu = txtThong_Tin_Tui_Goi.Text
            Frm.ShowDialog()
            If Frm.DialogResult = DialogResult.OK Then
                Load_GiaoTuiDi1()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub txtThong_Tin_Tui_Goi_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtThong_Tin_Tui_Goi.ValueChanged

    End Sub
End Class

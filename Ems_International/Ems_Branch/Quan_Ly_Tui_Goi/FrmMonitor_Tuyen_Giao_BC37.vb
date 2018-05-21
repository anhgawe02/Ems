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

Public Class FrmMonitor_Tuyen_Giao_BC37
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
    Friend WithEvents TabBC37 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dgBC37_Den_Waiting As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTuyen_VC_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTuyen_VC_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblINFO_Den As System.Windows.Forms.Label
    Friend WithEvents lblINFO_Di As System.Windows.Forms.Label
    Friend WithEvents dgBc37_Den_Processed As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgBc37_Di_Processed As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgBC37_Di_Waiting As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtId_Tuyen_Di As System.Windows.Forms.TextBox
    Friend WithEvents txtId_Tuyen_Den As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_Tuyen_Den As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_Tuyen_Di As System.Windows.Forms.TextBox
    Friend WithEvents chkALL As System.Windows.Forms.CheckBox
    Friend WithEvents btnLay_Du_Lieu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTruyen_Du_Lieu_Len As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTruyen_Du_Lieu_XN_Len As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnTat_Ca_Tuyen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbRoad_Map As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDoi_Tac_Den As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbDoi_Tac_Di As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ddDoi_Tac As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTRANSPORT_TYPE As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddTrang_Thai As Infragistics.Win.UltraWinGrid.UltraDropDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_CODE")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ADDRESS")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PHONE_NUMBER")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TAX")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ACCOUNT_NUMBER")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BANK_NAME")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_OF_PC")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTACT_PHONE_NUMBER")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_NUMBER")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WHERE")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DATE")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_ID_CONTACT")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_PARTNER")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Road_Map", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_1")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_CODE_2")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_1")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_2")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_EAST")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LONGITUDE_WEST")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_NORTH")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LATITUDE_SOUTH")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COMMENTS")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMonitor_Tuyen_Giao_BC37))
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("XN_BC37_Den")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROUD_MAP_ID")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROVINCE")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_CODE")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ADDRESS")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PHONE_NUMBER")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TAX")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ACCOUNT_NUMBER")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BANK_NAME")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_OF_PC")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTACT_PHONE_NUMBER")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_NUMBER")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WHERE")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DATE")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_ID_CONTACT")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_PARTNER")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao")
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance234 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance235 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance236 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance237 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance238 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance239 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance240 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance241 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Tuyen_VC", -1)
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("XN_BC37_Di")
        Dim Appearance242 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen")
        Dim Appearance243 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tuyen_Char")
        Dim Appearance244 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tuyen")
        Dim Appearance245 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Dot")
        Dim Appearance246 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc_Char", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance247 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance248 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich_Char")
        Dim Appearance249 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance250 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Goc")
        Dim Appearance251 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance252 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh_Dich")
        Dim Appearance253 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance254 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Huong")
        Dim Appearance255 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ROUD_MAP_ID")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TYPE")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PROVINCE")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance256 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance257 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance258 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance259 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance260 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance261 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance262 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance263 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Parner", -1)
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance264 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_CODE")
        Dim Appearance265 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ADDRESS")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PHONE_NUMBER")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TAX")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ACCOUNT_NUMBER")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BANK_NAME")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_OF_PC")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CONTACT_PHONE_NUMBER")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_NUMBER")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_WHERE")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID_DATE")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PO_ID_CONTACT")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME_PARTNER")
        Dim Appearance266 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance267 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance268 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("TRANSPORT_TYPE", -1)
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim Appearance269 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NAME")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_LOCK")
        Dim Appearance270 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance271 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Trang_Thai", -1)
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma")
        Dim Appearance272 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten")
        Dim Appearance273 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance274 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cbDoi_Tac_Den = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.cbRoad_Map = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.btnTruyen_Du_Lieu_XN_Len = New Infragistics.Win.Misc.UltraButton
        Me.btnLay_Du_Lieu = New Infragistics.Win.Misc.UltraButton
        Me.chkALL = New System.Windows.Forms.CheckBox
        Me.dgTuyen_VC_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lblINFO_Den = New System.Windows.Forms.Label
        Me.dgBC37_Den_Waiting = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgBc37_Den_Processed = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtTen_Tuyen_Den = New System.Windows.Forms.TextBox
        Me.txtId_Tuyen_Den = New System.Windows.Forms.TextBox
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.cbDoi_Tac_Di = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.btnTat_Ca_Tuyen = New Infragistics.Win.Misc.UltraButton
        Me.btnTruyen_Du_Lieu_Len = New Infragistics.Win.Misc.UltraButton
        Me.dgBc37_Di_Processed = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgBC37_Di_Waiting = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.lblINFO_Di = New System.Windows.Forms.Label
        Me.dgTuyen_VC_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.txtTen_Tuyen_Di = New System.Windows.Forms.TextBox
        Me.txtId_Tuyen_Di = New System.Windows.Forms.TextBox
        Me.TabBC37 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ddDoi_Tac = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTRANSPORT_TYPE = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddTrang_Thai = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cbDoi_Tac_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRoad_Map, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTuyen_VC_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBC37_Den_Waiting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBc37_Den_Processed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cbDoi_Tac_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBc37_Di_Processed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBC37_Di_Waiting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTuyen_VC_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabBC37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBC37.SuspendLayout()
        CType(Me.ddDoi_Tac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTRANSPORT_TYPE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddTrang_Thai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.cbDoi_Tac_Den)
        Me.UltraTabPageControl1.Controls.Add(Me.cbRoad_Map)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl1.Controls.Add(Me.btnTruyen_Du_Lieu_XN_Len)
        Me.UltraTabPageControl1.Controls.Add(Me.btnLay_Du_Lieu)
        Me.UltraTabPageControl1.Controls.Add(Me.chkALL)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTuyen_VC_Den)
        Me.UltraTabPageControl1.Controls.Add(Me.lblINFO_Den)
        Me.UltraTabPageControl1.Controls.Add(Me.dgBC37_Den_Waiting)
        Me.UltraTabPageControl1.Controls.Add(Me.dgBc37_Den_Processed)
        Me.UltraTabPageControl1.Controls.Add(Me.txtTen_Tuyen_Den)
        Me.UltraTabPageControl1.Controls.Add(Me.txtId_Tuyen_Den)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(790, 552)
        '
        'cbDoi_Tac_Den
        '
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDoi_Tac_Den.Appearance = Appearance1
        Me.cbDoi_Tac_Den.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDoi_Tac_Den.DisplayLayout.Appearance = Appearance2
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 5
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn1.Width = 50
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance4
        UltraGridColumn2.Header.Caption = "Mã"
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance5
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Hidden = True
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance6
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance7
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Hidden = True
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance8
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Hidden = True
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance9
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance10
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 200
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance11
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance12
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance13
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance14
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance15
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance16
        UltraGridColumn14.Header.Caption = "Tên"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 250
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance17
        UltraGridColumn15.Header.Caption = "Tên đối tác"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(164, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand1.Header.Caption = "Mã Đường Thư"
        UltraGridBand1.UseRowLayout = True
        Me.cbDoi_Tac_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance18.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance18.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDoi_Tac_Den.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.cbDoi_Tac_Den.DisplayMember = "PARTNER_CODE"
        Me.cbDoi_Tac_Den.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoi_Tac_Den.Location = New System.Drawing.Point(384, 1)
        Me.cbDoi_Tac_Den.Name = "cbDoi_Tac_Den"
        Me.cbDoi_Tac_Den.Size = New System.Drawing.Size(248, 21)
        Me.cbDoi_Tac_Den.TabIndex = 44
        Me.cbDoi_Tac_Den.ValueMember = "ID"
        '
        'cbRoad_Map
        '
        Me.cbRoad_Map.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbRoad_Map.DisplayLayout.Appearance = Appearance19
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn21.Header.VisiblePosition = 5
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn25.Header.VisiblePosition = 9
        UltraGridColumn26.Header.VisiblePosition = 10
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        UltraGridBand2.Header.Caption = "Mã Đường Thư"
        Me.cbRoad_Map.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbRoad_Map.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.cbRoad_Map.DisplayMember = ""
        Me.cbRoad_Map.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoad_Map.Location = New System.Drawing.Point(216, 208)
        Me.cbRoad_Map.Name = "cbRoad_Map"
        Me.cbRoad_Map.Size = New System.Drawing.Size(144, 21)
        Me.cbRoad_Map.TabIndex = 42
        Me.cbRoad_Map.ValueMember = ""
        Me.cbRoad_Map.Visible = False
        '
        'UltraLabel2
        '
        Me.UltraLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(288, 5)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 15)
        Me.UltraLabel2.TabIndex = 43
        Me.UltraLabel2.Text = "Lọc theo đối tác"
        '
        'btnTruyen_Du_Lieu_XN_Len
        '
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance21.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnTruyen_Du_Lieu_XN_Len.Appearance = Appearance21
        Me.btnTruyen_Du_Lieu_XN_Len.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyen_Du_Lieu_XN_Len.Location = New System.Drawing.Point(688, 288)
        Me.btnTruyen_Du_Lieu_XN_Len.Name = "btnTruyen_Du_Lieu_XN_Len"
        Me.btnTruyen_Du_Lieu_XN_Len.Size = New System.Drawing.Size(101, 59)
        Me.btnTruyen_Du_Lieu_XN_Len.TabIndex = 29
        Me.btnTruyen_Du_Lieu_XN_Len.Text = "Truyền dữ liệu BC37 lên Host"
        '
        'btnLay_Du_Lieu
        '
        Appearance22.Image = CType(resources.GetObject("Appearance22.Image"), Object)
        Appearance22.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance22.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnLay_Du_Lieu.Appearance = Appearance22
        Me.btnLay_Du_Lieu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLay_Du_Lieu.Location = New System.Drawing.Point(584, 288)
        Me.btnLay_Du_Lieu.Name = "btnLay_Du_Lieu"
        Me.btnLay_Du_Lieu.Size = New System.Drawing.Size(101, 59)
        Me.btnLay_Du_Lieu.TabIndex = 26
        Me.btnLay_Du_Lieu.Text = "Lấy dữ liệu truyền về"
        '
        'chkALL
        '
        Me.chkALL.Checked = True
        Me.chkALL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkALL.Location = New System.Drawing.Point(728, 4)
        Me.chkALL.Name = "chkALL"
        Me.chkALL.Size = New System.Drawing.Size(16, 14)
        Me.chkALL.TabIndex = 25
        '
        'dgTuyen_VC_Den
        '
        Me.dgTuyen_VC_Den.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTuyen_VC_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance23.BackColor = System.Drawing.Color.White
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTuyen_VC_Den.DisplayLayout.Appearance = Appearance23
        UltraGridBand3.CardSettings.ShowCaption = False
        UltraGridColumn28.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        UltraGridColumn28.Header.Caption = ""
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance24
        UltraGridColumn31.Header.Caption = "Tên tuyến"
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(189, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn32.Header.VisiblePosition = 3
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.CellAppearance = Appearance25
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance26
        UltraGridColumn33.Header.Caption = "Mã tỉnh gốc"
        UltraGridColumn33.Header.VisiblePosition = 4
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.CellAppearance = Appearance27
        UltraGridColumn34.Header.VisiblePosition = 5
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.CellAppearance = Appearance28
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance29
        UltraGridColumn35.Header.Caption = "Mã tỉnh gốc"
        UltraGridColumn35.Header.VisiblePosition = 6
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.CellAppearance = Appearance30
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance31
        UltraGridColumn36.Header.Caption = "Mã tỉnh đích"
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance32
        UltraGridColumn37.Header.Caption = "Hướng"
        UltraGridColumn37.Header.VisiblePosition = 8
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = ""
        UltraGridColumn38.Header.VisiblePosition = 10
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn39.Header.VisiblePosition = 11
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 12
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 13
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.Caption = "Đối tác"
        UltraGridColumn42.Header.VisiblePosition = 14
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(108, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.Caption = "Phương tiện"
        UltraGridColumn43.Header.VisiblePosition = 15
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(145, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand3.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance33.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand3.Override.RowSelectorAppearance = Appearance33
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        UltraGridBand3.Override.RowSelectorWidth = 20
        UltraGridBand3.UseRowLayout = True
        Me.dgTuyen_VC_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Left
        Me.dgTuyen_VC_Den.DisplayLayout.CaptionAppearance = Appearance34
        Me.dgTuyen_VC_Den.DisplayLayout.InterBandSpacing = 10
        Me.dgTuyen_VC_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.dgTuyen_VC_Den.DisplayLayout.Override.CardAreaAppearance = Appearance35
        Me.dgTuyen_VC_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance36.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance36.ForeColor = System.Drawing.Color.Black
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance36.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTuyen_VC_Den.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.dgTuyen_VC_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance37.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyen_VC_Den.DisplayLayout.Override.RowAppearance = Appearance37
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgTuyen_VC_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance38
        Me.dgTuyen_VC_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTuyen_VC_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance39.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.dgTuyen_VC_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance39
        Me.dgTuyen_VC_Den.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyen_VC_Den.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyen_VC_Den.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgTuyen_VC_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyen_VC_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTuyen_VC_Den.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTuyen_VC_Den.Location = New System.Drawing.Point(-1, 0)
        Me.dgTuyen_VC_Den.Name = "dgTuyen_VC_Den"
        Me.dgTuyen_VC_Den.Size = New System.Drawing.Size(792, 288)
        Me.dgTuyen_VC_Den.TabIndex = 18
        Me.dgTuyen_VC_Den.Text = "Danh sách tuyến vận chuyển"
        '
        'lblINFO_Den
        '
        Me.lblINFO_Den.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblINFO_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFO_Den.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblINFO_Den.Location = New System.Drawing.Point(3, 289)
        Me.lblINFO_Den.Name = "lblINFO_Den"
        Me.lblINFO_Den.Size = New System.Drawing.Size(577, 59)
        Me.lblINFO_Den.TabIndex = 21
        Me.lblINFO_Den.Text = "Thông tin tuyến vận chuyển"
        Me.lblINFO_Den.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgBC37_Den_Waiting
        '
        Me.dgBC37_Den_Waiting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBC37_Den_Waiting.DisplayLayout.AddNewBox.Prompt = " "
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBC37_Den_Waiting.DisplayLayout.Appearance = Appearance40
        UltraGridBand4.CardSettings.ShowCaption = False
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.CellAppearance = Appearance41
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance42
        UltraGridColumn44.Header.Caption = "Chọn"
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(39, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance43.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance43
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance44.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance44
        UltraGridColumn46.Header.Caption = "Số hiệu BC37"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance45
        UltraGridColumn47.Header.Caption = "Id Đường Thư"
        UltraGridColumn47.Header.VisiblePosition = 3
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance46.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance46
        UltraGridColumn48.Header.Caption = "Id ca"
        UltraGridColumn48.Header.VisiblePosition = 4
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance47.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.CellAppearance = Appearance47
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance48
        UltraGridColumn49.Header.Caption = "BC gửi"
        UltraGridColumn49.Header.VisiblePosition = 5
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance49.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.CellAppearance = Appearance49
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance50
        UltraGridColumn50.Header.Caption = "BC nhận"
        UltraGridColumn50.Header.VisiblePosition = 7
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.CellAppearance = Appearance51
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance52
        UltraGridColumn51.Header.Caption = "Ngày lập"
        UltraGridColumn51.Header.VisiblePosition = 6
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn51.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn51.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.UseEditorMaskSettings = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance53
        UltraGridColumn52.Header.Caption = "Giờ lập"
        UltraGridColumn52.Header.VisiblePosition = 8
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn52.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn52.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.UseEditorMaskSettings = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn53.CellAppearance = Appearance54
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance55
        UltraGridColumn53.Header.Caption = "Đợt giao"
        UltraGridColumn53.Header.VisiblePosition = 9
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance56
        UltraGridColumn54.Header.Caption = "Ngày giao"
        UltraGridColumn54.Header.VisiblePosition = 10
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance57
        UltraGridColumn55.Header.Caption = "Giờ giao"
        UltraGridColumn55.Header.VisiblePosition = 11
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn56.CellAppearance = Appearance58
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn56.Header.Appearance = Appearance59
        UltraGridColumn56.Header.Caption = "SCT"
        UltraGridColumn56.Header.VisiblePosition = 14
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn57.Header.Appearance = Appearance60
        UltraGridColumn57.Header.Caption = "Id người dùng"
        UltraGridColumn57.Header.VisiblePosition = 12
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn58.Header.Appearance = Appearance61
        UltraGridColumn58.Header.Caption = "Ngày hệ thống"
        UltraGridColumn58.Header.VisiblePosition = 13
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance62
        UltraGridColumn59.Header.Caption = "Giờ hệ thống"
        UltraGridColumn59.Header.VisiblePosition = 15
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance63
        UltraGridColumn60.Header.Caption = "Đã in"
        UltraGridColumn60.Header.VisiblePosition = 16
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn61.Header.Appearance = Appearance64
        UltraGridColumn61.Header.Caption = "Chốt số liệu"
        UltraGridColumn61.Header.VisiblePosition = 17
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance65
        UltraGridColumn62.Header.Caption = "Truyền khai thác"
        UltraGridColumn62.Header.VisiblePosition = 18
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.CellAppearance = Appearance66
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance67
        UltraGridColumn63.Header.Caption = "Trạng thái"
        UltraGridColumn63.Header.VisiblePosition = 22
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance68
        UltraGridColumn64.Header.VisiblePosition = 19
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.Header.Appearance = Appearance69
        UltraGridColumn65.Header.VisiblePosition = 20
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn66.Header.Appearance = Appearance70
        UltraGridColumn66.Header.VisiblePosition = 21
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn67.CellAppearance = Appearance71
        UltraGridColumn67.Header.Caption = "Tổng số túi"
        UltraGridColumn67.Header.VisiblePosition = 23
        UltraGridColumn67.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn67.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn67.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn67.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn67.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn68.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn68.CellAppearance = Appearance72
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn68.Header.Appearance = Appearance73
        UltraGridColumn68.Header.Caption = "Khối lượng"
        UltraGridColumn68.Header.VisiblePosition = 24
        UltraGridColumn68.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn68.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn68.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn68.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn68.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn69.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn69.CellAppearance = Appearance74
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.Header.Appearance = Appearance75
        UltraGridColumn69.Header.Caption = "Tổng số BP"
        UltraGridColumn69.Header.VisiblePosition = 25
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn69.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn69.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn69.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn69.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn70.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance76
        UltraGridColumn70.Header.VisiblePosition = 26
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn71.CellAppearance = Appearance77
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance78
        UltraGridColumn71.Header.Caption = "Tổng khối lượng"
        UltraGridColumn71.Header.VisiblePosition = 27
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance79.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.CellAppearance = Appearance79
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance80
        UltraGridColumn72.Header.Caption = "Chuyển tiếp"
        UltraGridColumn72.Header.VisiblePosition = 28
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72})
        UltraGridBand4.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance81.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand4.Override.RowSelectorAppearance = Appearance81
        UltraGridBand4.Override.RowSelectorWidth = 20
        UltraGridBand4.UseRowLayout = True
        Me.dgBC37_Den_Waiting.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgBC37_Den_Waiting.DisplayLayout.InterBandSpacing = 10
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.CardAreaAppearance = Appearance82
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance83.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance83.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance83.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance83.ForeColor = System.Drawing.Color.Black
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance83.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.HeaderAppearance = Appearance83
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance84.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.RowAppearance = Appearance84
        Appearance85.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance85.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance85.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.RowSelectorAppearance = Appearance85
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance86.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance86.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance86.ForeColor = System.Drawing.Color.Black
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.SelectedRowAppearance = Appearance86
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Den_Waiting.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBC37_Den_Waiting.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Den_Waiting.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBC37_Den_Waiting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBC37_Den_Waiting.Location = New System.Drawing.Point(0, 352)
        Me.dgBC37_Den_Waiting.Name = "dgBC37_Den_Waiting"
        Me.dgBC37_Den_Waiting.Size = New System.Drawing.Size(392, 200)
        Me.dgBC37_Den_Waiting.TabIndex = 21
        Me.dgBC37_Den_Waiting.Text = "Danh sách BC37 chưa xác nhận đến"
        '
        'dgBc37_Den_Processed
        '
        Me.dgBc37_Den_Processed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBc37_Den_Processed.DisplayLayout.AddNewBox.Prompt = " "
        Appearance87.BackColor = System.Drawing.Color.White
        Appearance87.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance87.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBc37_Den_Processed.DisplayLayout.Appearance = Appearance87
        UltraGridBand5.CardSettings.ShowCaption = False
        Appearance88.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.CellAppearance = Appearance88
        Appearance89.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.Header.Appearance = Appearance89
        UltraGridColumn73.Header.Caption = "Chọn"
        UltraGridColumn73.Header.VisiblePosition = 0
        UltraGridColumn73.Hidden = True
        UltraGridColumn73.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn73.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn73.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(39, 0)
        UltraGridColumn73.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn73.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn74.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance90.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance90
        UltraGridColumn74.Header.VisiblePosition = 1
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn74.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn74.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn74.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn75.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance91.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance91
        UltraGridColumn75.Header.Caption = "Số hiệu BC37"
        UltraGridColumn75.Header.VisiblePosition = 2
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn75.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn75.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn75.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn75.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn76.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance92.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance92
        UltraGridColumn76.Header.Caption = "Id Đường Thư"
        UltraGridColumn76.Header.VisiblePosition = 3
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance93
        UltraGridColumn77.Header.Caption = "Id ca"
        UltraGridColumn77.Header.VisiblePosition = 4
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance94.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.CellAppearance = Appearance94
        Appearance95.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance95
        UltraGridColumn78.Header.Caption = "BC gửi"
        UltraGridColumn78.Header.VisiblePosition = 5
        UltraGridColumn78.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn78.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn78.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn78.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn78.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn79.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance96.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.CellAppearance = Appearance96
        Appearance97.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance97
        UltraGridColumn79.Header.Caption = "BC nhận"
        UltraGridColumn79.Header.VisiblePosition = 7
        UltraGridColumn79.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn79.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn79.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn79.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn79.RowLayoutColumnInfo.SpanY = 2
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.CellAppearance = Appearance98
        Appearance99.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.Header.Appearance = Appearance99
        UltraGridColumn80.Header.Caption = "Ngày lập"
        UltraGridColumn80.Header.VisiblePosition = 6
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn80.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn80.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn80.UseEditorMaskSettings = True
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance100.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn81.Header.Appearance = Appearance100
        UltraGridColumn81.Header.Caption = "Giờ lập"
        UltraGridColumn81.Header.VisiblePosition = 8
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.UseEditorMaskSettings = True
        UltraGridColumn82.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn82.CellAppearance = Appearance101
        Appearance102.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.Header.Appearance = Appearance102
        UltraGridColumn82.Header.Caption = "Đợt giao"
        UltraGridColumn82.Header.VisiblePosition = 9
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.Header.Appearance = Appearance103
        UltraGridColumn83.Header.Caption = "Ngày giao"
        UltraGridColumn83.Header.VisiblePosition = 10
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.Header.Appearance = Appearance104
        UltraGridColumn84.Header.Caption = "Giờ giao"
        UltraGridColumn84.Header.VisiblePosition = 11
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn85.CellAppearance = Appearance105
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn85.Header.Appearance = Appearance106
        UltraGridColumn85.Header.Caption = "SCT"
        UltraGridColumn85.Header.VisiblePosition = 14
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(43, 0)
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance107
        UltraGridColumn86.Header.Caption = "Id người dùng"
        UltraGridColumn86.Header.VisiblePosition = 12
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance108
        UltraGridColumn87.Header.Caption = "Ngày hệ thống"
        UltraGridColumn87.Header.VisiblePosition = 13
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance109
        UltraGridColumn88.Header.Caption = "Giờ hệ thống"
        UltraGridColumn88.Header.VisiblePosition = 15
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance110
        UltraGridColumn89.Header.Caption = "Đã in"
        UltraGridColumn89.Header.VisiblePosition = 16
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance111.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance111
        UltraGridColumn90.Header.Caption = "Chốt số liệu"
        UltraGridColumn90.Header.VisiblePosition = 17
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance112.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance112
        UltraGridColumn91.Header.Caption = "Truyền khai thác"
        UltraGridColumn91.Header.VisiblePosition = 18
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance113.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.CellAppearance = Appearance113
        Appearance114.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance114
        UltraGridColumn92.Header.Caption = "Trạng thái"
        UltraGridColumn92.Header.VisiblePosition = 22
        UltraGridColumn92.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn92.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn92.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn92.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn92.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance115
        UltraGridColumn93.Header.VisiblePosition = 19
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance116.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.Header.Appearance = Appearance116
        UltraGridColumn94.Header.VisiblePosition = 20
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance117.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.Header.Appearance = Appearance117
        UltraGridColumn95.Header.VisiblePosition = 21
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn96.CellAppearance = Appearance118
        UltraGridColumn96.Header.Caption = "Tổng số túi"
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn96.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn96.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn96.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn97.CellAppearance = Appearance119
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.Header.Appearance = Appearance120
        UltraGridColumn97.Header.Caption = "Khối lượng"
        UltraGridColumn97.Header.VisiblePosition = 24
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn98.CellAppearance = Appearance121
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.Header.Appearance = Appearance122
        UltraGridColumn98.Header.Caption = "Tổng số BP"
        UltraGridColumn98.Header.VisiblePosition = 25
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn98.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn98.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn98.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance123.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance123
        UltraGridColumn99.Header.VisiblePosition = 26
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn100.CellAppearance = Appearance124
        Appearance125.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance125
        UltraGridColumn100.Header.Caption = "Tổng khối lượng"
        UltraGridColumn100.Header.VisiblePosition = 27
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance126.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.CellAppearance = Appearance126
        Appearance127.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.Header.Appearance = Appearance127
        UltraGridColumn101.Header.Caption = "Chuyển tiếp"
        UltraGridColumn101.Header.VisiblePosition = 28
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101})
        UltraGridBand5.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance128.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand5.Override.RowSelectorAppearance = Appearance128
        UltraGridBand5.Override.RowSelectorWidth = 20
        UltraGridBand5.UseRowLayout = True
        Me.dgBc37_Den_Processed.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgBc37_Den_Processed.DisplayLayout.InterBandSpacing = 10
        Me.dgBc37_Den_Processed.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Me.dgBc37_Den_Processed.DisplayLayout.Override.CardAreaAppearance = Appearance129
        Me.dgBc37_Den_Processed.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance130.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance130.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance130.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance130.ForeColor = System.Drawing.Color.Black
        Appearance130.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance130.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBc37_Den_Processed.DisplayLayout.Override.HeaderAppearance = Appearance130
        Me.dgBc37_Den_Processed.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance131.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBc37_Den_Processed.DisplayLayout.Override.RowAppearance = Appearance131
        Appearance132.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance132.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance132.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBc37_Den_Processed.DisplayLayout.Override.RowSelectorAppearance = Appearance132
        Me.dgBc37_Den_Processed.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBc37_Den_Processed.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance133.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance133.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance133.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance133.ForeColor = System.Drawing.Color.Black
        Me.dgBc37_Den_Processed.DisplayLayout.Override.SelectedRowAppearance = Appearance133
        Me.dgBc37_Den_Processed.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBc37_Den_Processed.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBc37_Den_Processed.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBc37_Den_Processed.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBc37_Den_Processed.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBc37_Den_Processed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBc37_Den_Processed.Location = New System.Drawing.Point(394, 352)
        Me.dgBc37_Den_Processed.Name = "dgBc37_Den_Processed"
        Me.dgBc37_Den_Processed.Size = New System.Drawing.Size(392, 200)
        Me.dgBc37_Den_Processed.TabIndex = 22
        Me.dgBc37_Den_Processed.Text = "Danh sách BC37 đã xác nhận đến"
        '
        'txtTen_Tuyen_Den
        '
        Me.txtTen_Tuyen_Den.Location = New System.Drawing.Point(256, 160)
        Me.txtTen_Tuyen_Den.Name = "txtTen_Tuyen_Den"
        Me.txtTen_Tuyen_Den.Size = New System.Drawing.Size(224, 20)
        Me.txtTen_Tuyen_Den.TabIndex = 24
        Me.txtTen_Tuyen_Den.Text = ""
        Me.txtTen_Tuyen_Den.Visible = False
        '
        'txtId_Tuyen_Den
        '
        Me.txtId_Tuyen_Den.Location = New System.Drawing.Point(256, 192)
        Me.txtId_Tuyen_Den.Name = "txtId_Tuyen_Den"
        Me.txtId_Tuyen_Den.Size = New System.Drawing.Size(224, 20)
        Me.txtId_Tuyen_Den.TabIndex = 23
        Me.txtId_Tuyen_Den.Text = ""
        Me.txtId_Tuyen_Den.Visible = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.cbDoi_Tac_Di)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl2.Controls.Add(Me.btnTat_Ca_Tuyen)
        Me.UltraTabPageControl2.Controls.Add(Me.btnTruyen_Du_Lieu_Len)
        Me.UltraTabPageControl2.Controls.Add(Me.dgBc37_Di_Processed)
        Me.UltraTabPageControl2.Controls.Add(Me.dgBC37_Di_Waiting)
        Me.UltraTabPageControl2.Controls.Add(Me.lblINFO_Di)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTuyen_VC_Di)
        Me.UltraTabPageControl2.Controls.Add(Me.txtTen_Tuyen_Di)
        Me.UltraTabPageControl2.Controls.Add(Me.txtId_Tuyen_Di)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(790, 552)
        '
        'cbDoi_Tac_Di
        '
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Right
        Me.cbDoi_Tac_Di.Appearance = Appearance134
        Me.cbDoi_Tac_Di.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance135.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.cbDoi_Tac_Di.DisplayLayout.Appearance = Appearance135
        Appearance136.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.Header.Appearance = Appearance136
        UltraGridColumn102.Header.VisiblePosition = 5
        UltraGridColumn102.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn102.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn102.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn102.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn102.Width = 50
        Appearance137.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance137
        UltraGridColumn103.Header.Caption = "Mã"
        UltraGridColumn103.Header.VisiblePosition = 0
        UltraGridColumn103.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn103.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn103.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn103.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn103.RowLayoutColumnInfo.SpanY = 2
        Appearance138.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance138
        UltraGridColumn104.Header.VisiblePosition = 1
        UltraGridColumn104.Hidden = True
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance139
        UltraGridColumn105.Header.VisiblePosition = 2
        UltraGridColumn105.Hidden = True
        Appearance140.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance140
        UltraGridColumn106.Header.VisiblePosition = 3
        UltraGridColumn106.Hidden = True
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance141
        UltraGridColumn107.Header.VisiblePosition = 4
        UltraGridColumn107.Hidden = True
        Appearance142.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance142
        UltraGridColumn108.Header.VisiblePosition = 6
        UltraGridColumn108.Hidden = True
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance143
        UltraGridColumn109.Header.VisiblePosition = 7
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn109.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn109.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn109.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn109.Width = 200
        Appearance144.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance144
        UltraGridColumn110.Header.VisiblePosition = 8
        UltraGridColumn110.Hidden = True
        Appearance145.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance145
        UltraGridColumn111.Header.VisiblePosition = 9
        UltraGridColumn111.Hidden = True
        Appearance146.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.Header.Appearance = Appearance146
        UltraGridColumn112.Header.VisiblePosition = 10
        UltraGridColumn112.Hidden = True
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance147
        UltraGridColumn113.Header.VisiblePosition = 11
        UltraGridColumn113.Hidden = True
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance148
        UltraGridColumn114.Header.VisiblePosition = 12
        UltraGridColumn114.Hidden = True
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn115.Header.Appearance = Appearance149
        UltraGridColumn115.Header.Caption = "Tên"
        UltraGridColumn115.Header.VisiblePosition = 13
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.Width = 250
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn116.Header.Appearance = Appearance150
        UltraGridColumn116.Header.Caption = "Tên đối tác"
        UltraGridColumn116.Header.VisiblePosition = 14
        UltraGridColumn116.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn116.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn116.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(164, 0)
        UltraGridColumn116.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn116.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116})
        UltraGridBand6.Header.Caption = "Mã Đường Thư"
        UltraGridBand6.UseRowLayout = True
        Me.cbDoi_Tac_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance151.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance151.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance151.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance151.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDoi_Tac_Di.DisplayLayout.Override.HeaderAppearance = Appearance151
        Me.cbDoi_Tac_Di.DisplayMember = "PARTNER_CODE"
        Me.cbDoi_Tac_Di.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoi_Tac_Di.Location = New System.Drawing.Point(456, 41)
        Me.cbDoi_Tac_Di.Name = "cbDoi_Tac_Di"
        Me.cbDoi_Tac_Di.Size = New System.Drawing.Size(224, 21)
        Me.cbDoi_Tac_Di.TabIndex = 46
        Me.cbDoi_Tac_Di.ValueMember = "ID"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(352, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 15)
        Me.UltraLabel1.TabIndex = 45
        Me.UltraLabel1.Text = "Lọc theo đối tác"
        '
        'btnTat_Ca_Tuyen
        '
        Appearance152.Image = CType(resources.GetObject("Appearance152.Image"), Object)
        Appearance152.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance152.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Right
        Me.btnTat_Ca_Tuyen.Appearance = Appearance152
        Me.btnTat_Ca_Tuyen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTat_Ca_Tuyen.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnTat_Ca_Tuyen.Location = New System.Drawing.Point(0, 0)
        Me.btnTat_Ca_Tuyen.Name = "btnTat_Ca_Tuyen"
        Me.btnTat_Ca_Tuyen.Size = New System.Drawing.Size(96, 40)
        Me.btnTat_Ca_Tuyen.TabIndex = 29
        Me.btnTat_Ca_Tuyen.Text = "Giao tất cả BC37 "
        '
        'btnTruyen_Du_Lieu_Len
        '
        Appearance153.Image = CType(resources.GetObject("Appearance153.Image"), Object)
        Appearance153.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance153.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnTruyen_Du_Lieu_Len.Appearance = Appearance153
        Me.btnTruyen_Du_Lieu_Len.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTruyen_Du_Lieu_Len.Location = New System.Drawing.Point(688, 288)
        Me.btnTruyen_Du_Lieu_Len.Name = "btnTruyen_Du_Lieu_Len"
        Me.btnTruyen_Du_Lieu_Len.Size = New System.Drawing.Size(101, 59)
        Me.btnTruyen_Du_Lieu_Len.TabIndex = 28
        Me.btnTruyen_Du_Lieu_Len.Text = "Truyền dữ liệu BC37 lên Host"
        '
        'dgBc37_Di_Processed
        '
        Me.dgBc37_Di_Processed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBc37_Di_Processed.DisplayLayout.AddNewBox.Prompt = " "
        Appearance154.BackColor = System.Drawing.Color.White
        Appearance154.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance154.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBc37_Di_Processed.DisplayLayout.Appearance = Appearance154
        UltraGridBand7.CardSettings.ShowCaption = False
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn117.CellAppearance = Appearance155
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn117.Header.Appearance = Appearance156
        UltraGridColumn117.Header.Caption = "Chọn"
        UltraGridColumn117.Header.VisiblePosition = 0
        UltraGridColumn117.Hidden = True
        UltraGridColumn117.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn117.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(39, 0)
        UltraGridColumn117.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn117.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn118.Header.Appearance = Appearance157
        UltraGridColumn118.Header.VisiblePosition = 1
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn118.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn118.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn118.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance158.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn119.Header.Appearance = Appearance158
        UltraGridColumn119.Header.Caption = "Số hiệu BC37"
        UltraGridColumn119.Header.VisiblePosition = 2
        UltraGridColumn119.Hidden = True
        UltraGridColumn119.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn119.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn119.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn119.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn119.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn120.Header.Appearance = Appearance159
        UltraGridColumn120.Header.Caption = "Id Đường Thư"
        UltraGridColumn120.Header.VisiblePosition = 3
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance160.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn121.Header.Appearance = Appearance160
        UltraGridColumn121.Header.Caption = "Id ca"
        UltraGridColumn121.Header.VisiblePosition = 4
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.CellAppearance = Appearance161
        Appearance162.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn122.Header.Appearance = Appearance162
        UltraGridColumn122.Header.Caption = "BC gửi"
        UltraGridColumn122.Header.VisiblePosition = 5
        UltraGridColumn122.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn122.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn122.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn122.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn122.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance163.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.CellAppearance = Appearance163
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn123.Header.Appearance = Appearance164
        UltraGridColumn123.Header.Caption = "BC nhận"
        UltraGridColumn123.Header.VisiblePosition = 7
        UltraGridColumn123.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn123.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn123.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn123.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn123.RowLayoutColumnInfo.SpanY = 2
        Appearance165.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn124.CellAppearance = Appearance165
        Appearance166.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn124.Header.Appearance = Appearance166
        UltraGridColumn124.Header.Caption = "Ngày lập"
        UltraGridColumn124.Header.VisiblePosition = 6
        UltraGridColumn124.Hidden = True
        UltraGridColumn124.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn124.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn124.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn124.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn124.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn124.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn124.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn124.UseEditorMaskSettings = True
        UltraGridColumn125.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn125.Header.Appearance = Appearance167
        UltraGridColumn125.Header.Caption = "Giờ lập"
        UltraGridColumn125.Header.VisiblePosition = 8
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn125.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn125.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn125.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn125.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn125.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn125.UseEditorMaskSettings = True
        UltraGridColumn126.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance168.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn126.CellAppearance = Appearance168
        Appearance169.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn126.Header.Appearance = Appearance169
        UltraGridColumn126.Header.Caption = "Đợt giao"
        UltraGridColumn126.Header.VisiblePosition = 9
        UltraGridColumn126.Hidden = True
        UltraGridColumn126.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn126.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn126.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn126.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn127.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance170.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn127.Header.Appearance = Appearance170
        UltraGridColumn127.Header.Caption = "Ngày giao"
        UltraGridColumn127.Header.VisiblePosition = 10
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance171.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn128.Header.Appearance = Appearance171
        UltraGridColumn128.Header.Caption = "Giờ giao"
        UltraGridColumn128.Header.VisiblePosition = 11
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance172.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn129.CellAppearance = Appearance172
        Appearance173.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn129.Header.Appearance = Appearance173
        UltraGridColumn129.Header.Caption = "SCT"
        UltraGridColumn129.Header.VisiblePosition = 14
        UltraGridColumn129.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn129.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn129.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn129.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn129.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn130.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance174.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn130.Header.Appearance = Appearance174
        UltraGridColumn130.Header.Caption = "Id người dùng"
        UltraGridColumn130.Header.VisiblePosition = 12
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance175.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn131.Header.Appearance = Appearance175
        UltraGridColumn131.Header.Caption = "Ngày hệ thống"
        UltraGridColumn131.Header.VisiblePosition = 13
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance176.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn132.Header.Appearance = Appearance176
        UltraGridColumn132.Header.Caption = "Giờ hệ thống"
        UltraGridColumn132.Header.VisiblePosition = 15
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance177.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn133.Header.Appearance = Appearance177
        UltraGridColumn133.Header.Caption = "Đã in"
        UltraGridColumn133.Header.VisiblePosition = 16
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance178.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn134.Header.Appearance = Appearance178
        UltraGridColumn134.Header.Caption = "Chốt số liệu"
        UltraGridColumn134.Header.VisiblePosition = 17
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance179.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn135.Header.Appearance = Appearance179
        UltraGridColumn135.Header.Caption = "Truyền khai thác"
        UltraGridColumn135.Header.VisiblePosition = 18
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance180.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn136.CellAppearance = Appearance180
        Appearance181.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn136.Header.Appearance = Appearance181
        UltraGridColumn136.Header.Caption = "Trạng thái"
        UltraGridColumn136.Header.VisiblePosition = 22
        UltraGridColumn136.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn136.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn136.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn136.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn136.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn137.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance182.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn137.Header.Appearance = Appearance182
        UltraGridColumn137.Header.VisiblePosition = 19
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance183.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn138.Header.Appearance = Appearance183
        UltraGridColumn138.Header.VisiblePosition = 20
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance184.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn139.Header.Appearance = Appearance184
        UltraGridColumn139.Header.VisiblePosition = 21
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn140.Header.Caption = "Tổng số túi"
        UltraGridColumn140.Header.VisiblePosition = 23
        UltraGridColumn140.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn140.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn140.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn140.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn140.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance185.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn141.CellAppearance = Appearance185
        Appearance186.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn141.Header.Appearance = Appearance186
        UltraGridColumn141.Header.Caption = "Khối lượng"
        UltraGridColumn141.Header.VisiblePosition = 24
        UltraGridColumn141.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn141.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn141.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn141.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn141.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance187.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn142.Header.Appearance = Appearance187
        UltraGridColumn142.Header.Caption = "Tổng số BP"
        UltraGridColumn142.Header.VisiblePosition = 25
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn142.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn142.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn142.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn142.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn143.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance188.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn143.Header.Appearance = Appearance188
        UltraGridColumn143.Header.VisiblePosition = 26
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn144.Header.VisiblePosition = 27
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance189.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn145.CellAppearance = Appearance189
        Appearance190.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn145.Header.Appearance = Appearance190
        UltraGridColumn145.Header.Caption = "Chuyển tiếp"
        UltraGridColumn145.Header.VisiblePosition = 28
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145})
        UltraGridBand7.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance191.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand7.Override.RowSelectorAppearance = Appearance191
        UltraGridBand7.Override.RowSelectorWidth = 20
        UltraGridBand7.UseRowLayout = True
        Me.dgBc37_Di_Processed.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.dgBc37_Di_Processed.DisplayLayout.InterBandSpacing = 10
        Me.dgBc37_Di_Processed.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance192.BackColor = System.Drawing.Color.Transparent
        Me.dgBc37_Di_Processed.DisplayLayout.Override.CardAreaAppearance = Appearance192
        Me.dgBc37_Di_Processed.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance193.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance193.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance193.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance193.ForeColor = System.Drawing.Color.Black
        Appearance193.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance193.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBc37_Di_Processed.DisplayLayout.Override.HeaderAppearance = Appearance193
        Me.dgBc37_Di_Processed.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance194.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBc37_Di_Processed.DisplayLayout.Override.RowAppearance = Appearance194
        Appearance195.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance195.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBc37_Di_Processed.DisplayLayout.Override.RowSelectorAppearance = Appearance195
        Me.dgBc37_Di_Processed.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBc37_Di_Processed.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance196.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance196.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance196.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance196.ForeColor = System.Drawing.Color.Black
        Me.dgBc37_Di_Processed.DisplayLayout.Override.SelectedRowAppearance = Appearance196
        Me.dgBc37_Di_Processed.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBc37_Di_Processed.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBc37_Di_Processed.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBc37_Di_Processed.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBc37_Di_Processed.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBc37_Di_Processed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBc37_Di_Processed.Location = New System.Drawing.Point(395, 352)
        Me.dgBc37_Di_Processed.Name = "dgBc37_Di_Processed"
        Me.dgBc37_Di_Processed.Size = New System.Drawing.Size(392, 200)
        Me.dgBc37_Di_Processed.TabIndex = 25
        Me.dgBc37_Di_Processed.Text = "Danh sách BC37 đã đóng đi"
        '
        'dgBC37_Di_Waiting
        '
        Me.dgBC37_Di_Waiting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBC37_Di_Waiting.DisplayLayout.AddNewBox.Prompt = " "
        Appearance197.BackColor = System.Drawing.Color.White
        Appearance197.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBC37_Di_Waiting.DisplayLayout.Appearance = Appearance197
        UltraGridBand8.CardSettings.ShowCaption = False
        Appearance198.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn146.CellAppearance = Appearance198
        Appearance199.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn146.Header.Appearance = Appearance199
        UltraGridColumn146.Header.Caption = "Chọn"
        UltraGridColumn146.Header.VisiblePosition = 0
        UltraGridColumn146.Hidden = True
        UltraGridColumn146.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn146.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn146.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(39, 0)
        UltraGridColumn146.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn146.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn147.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance200.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn147.Header.Appearance = Appearance200
        UltraGridColumn147.Header.VisiblePosition = 1
        UltraGridColumn147.Hidden = True
        UltraGridColumn147.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn147.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn147.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn147.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn148.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance201.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn148.Header.Appearance = Appearance201
        UltraGridColumn148.Header.Caption = "Số hiệu BC37"
        UltraGridColumn148.Header.VisiblePosition = 2
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn148.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn148.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn148.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn148.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn149.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance202.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn149.Header.Appearance = Appearance202
        UltraGridColumn149.Header.Caption = "Id Đường Thư"
        UltraGridColumn149.Header.VisiblePosition = 3
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance203.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn150.Header.Appearance = Appearance203
        UltraGridColumn150.Header.Caption = "Id ca"
        UltraGridColumn150.Header.VisiblePosition = 4
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance204.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn151.CellAppearance = Appearance204
        Appearance205.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn151.Header.Appearance = Appearance205
        UltraGridColumn151.Header.Caption = "BC gửi"
        UltraGridColumn151.Header.VisiblePosition = 5
        UltraGridColumn151.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn151.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn151.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn151.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn151.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn152.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance206.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn152.CellAppearance = Appearance206
        Appearance207.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn152.Header.Appearance = Appearance207
        UltraGridColumn152.Header.Caption = "BC nhận"
        UltraGridColumn152.Header.VisiblePosition = 7
        UltraGridColumn152.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn152.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn152.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn152.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn152.RowLayoutColumnInfo.SpanY = 2
        Appearance208.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn153.CellAppearance = Appearance208
        Appearance209.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn153.Header.Appearance = Appearance209
        UltraGridColumn153.Header.Caption = "Ngày lập"
        UltraGridColumn153.Header.VisiblePosition = 6
        UltraGridColumn153.Hidden = True
        UltraGridColumn153.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn153.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn153.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn153.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn153.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn153.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn153.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn153.UseEditorMaskSettings = True
        UltraGridColumn154.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance210.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn154.Header.Appearance = Appearance210
        UltraGridColumn154.Header.Caption = "Giờ lập"
        UltraGridColumn154.Header.VisiblePosition = 8
        UltraGridColumn154.Hidden = True
        UltraGridColumn154.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn154.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn154.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn154.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn154.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn154.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn154.UseEditorMaskSettings = True
        UltraGridColumn155.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance211.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn155.CellAppearance = Appearance211
        Appearance212.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn155.Header.Appearance = Appearance212
        UltraGridColumn155.Header.Caption = "Đợt giao"
        UltraGridColumn155.Header.VisiblePosition = 9
        UltraGridColumn155.Hidden = True
        UltraGridColumn155.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn155.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn155.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn155.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn156.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance213.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn156.Header.Appearance = Appearance213
        UltraGridColumn156.Header.Caption = "Ngày giao"
        UltraGridColumn156.Header.VisiblePosition = 10
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance214.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn157.Header.Appearance = Appearance214
        UltraGridColumn157.Header.Caption = "Giờ giao"
        UltraGridColumn157.Header.VisiblePosition = 11
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance215.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn158.CellAppearance = Appearance215
        Appearance216.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn158.Header.Appearance = Appearance216
        UltraGridColumn158.Header.Caption = "SCT"
        UltraGridColumn158.Header.VisiblePosition = 14
        UltraGridColumn158.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn158.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn158.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn158.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn158.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn159.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance217.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn159.Header.Appearance = Appearance217
        UltraGridColumn159.Header.Caption = "Id người dùng"
        UltraGridColumn159.Header.VisiblePosition = 12
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance218.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn160.Header.Appearance = Appearance218
        UltraGridColumn160.Header.Caption = "Ngày hệ thống"
        UltraGridColumn160.Header.VisiblePosition = 13
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance219.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn161.Header.Appearance = Appearance219
        UltraGridColumn161.Header.Caption = "Giờ hệ thống"
        UltraGridColumn161.Header.VisiblePosition = 15
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance220.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn162.Header.Appearance = Appearance220
        UltraGridColumn162.Header.Caption = "Đã in"
        UltraGridColumn162.Header.VisiblePosition = 16
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance221.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn163.Header.Appearance = Appearance221
        UltraGridColumn163.Header.Caption = "Chốt số liệu"
        UltraGridColumn163.Header.VisiblePosition = 17
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance222.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn164.Header.Appearance = Appearance222
        UltraGridColumn164.Header.Caption = "Truyền khai thác"
        UltraGridColumn164.Header.VisiblePosition = 18
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance223.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn165.CellAppearance = Appearance223
        Appearance224.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn165.Header.Appearance = Appearance224
        UltraGridColumn165.Header.Caption = "Trạng thái"
        UltraGridColumn165.Header.VisiblePosition = 22
        UltraGridColumn165.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn165.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn165.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn165.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn165.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn166.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance225.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn166.Header.Appearance = Appearance225
        UltraGridColumn166.Header.VisiblePosition = 19
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance226.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn167.Header.Appearance = Appearance226
        UltraGridColumn167.Header.VisiblePosition = 20
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance227.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn168.Header.Appearance = Appearance227
        UltraGridColumn168.Header.VisiblePosition = 21
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance228.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn169.CellAppearance = Appearance228
        UltraGridColumn169.Header.Caption = "Tổng số túi"
        UltraGridColumn169.Header.VisiblePosition = 23
        UltraGridColumn169.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn169.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn169.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn169.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn169.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn170.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance229.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn170.CellAppearance = Appearance229
        Appearance230.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn170.Header.Appearance = Appearance230
        UltraGridColumn170.Header.Caption = "Khối lượng"
        UltraGridColumn170.Header.VisiblePosition = 24
        UltraGridColumn170.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn170.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn170.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn170.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn170.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn171.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance231.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn171.Header.Appearance = Appearance231
        UltraGridColumn171.Header.Caption = "Tổng số BP"
        UltraGridColumn171.Header.VisiblePosition = 25
        UltraGridColumn171.Hidden = True
        UltraGridColumn171.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn171.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn171.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn171.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn171.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn172.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance232.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn172.Header.Appearance = Appearance232
        UltraGridColumn172.Header.VisiblePosition = 26
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        UltraGridColumn173.Header.VisiblePosition = 27
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance233.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn174.CellAppearance = Appearance233
        Appearance234.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn174.Header.Appearance = Appearance234
        UltraGridColumn174.Header.Caption = "Chuyển tiếp"
        UltraGridColumn174.Header.VisiblePosition = 28
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174})
        UltraGridBand8.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance235.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand8.Override.RowSelectorAppearance = Appearance235
        UltraGridBand8.Override.RowSelectorWidth = 20
        UltraGridBand8.UseRowLayout = True
        Me.dgBC37_Di_Waiting.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.dgBC37_Di_Waiting.DisplayLayout.InterBandSpacing = 10
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance236.BackColor = System.Drawing.Color.Transparent
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.CardAreaAppearance = Appearance236
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance237.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance237.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance237.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance237.ForeColor = System.Drawing.Color.Black
        Appearance237.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance237.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.HeaderAppearance = Appearance237
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance238.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.RowAppearance = Appearance238
        Appearance239.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance239.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance239.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.RowSelectorAppearance = Appearance239
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance240.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance240.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance240.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance240.ForeColor = System.Drawing.Color.Black
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.SelectedRowAppearance = Appearance240
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Di_Waiting.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBC37_Di_Waiting.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Di_Waiting.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBC37_Di_Waiting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBC37_Di_Waiting.Location = New System.Drawing.Point(1, 352)
        Me.dgBC37_Di_Waiting.Name = "dgBC37_Di_Waiting"
        Me.dgBC37_Di_Waiting.Size = New System.Drawing.Size(392, 200)
        Me.dgBC37_Di_Waiting.TabIndex = 24
        Me.dgBC37_Di_Waiting.Text = "Danh sách BC37 chưa đóng đi"
        '
        'lblINFO_Di
        '
        Me.lblINFO_Di.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblINFO_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblINFO_Di.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblINFO_Di.Location = New System.Drawing.Point(1, 288)
        Me.lblINFO_Di.Name = "lblINFO_Di"
        Me.lblINFO_Di.Size = New System.Drawing.Size(682, 59)
        Me.lblINFO_Di.TabIndex = 22
        Me.lblINFO_Di.Text = "Thông tin tuyến vận chuyển"
        Me.lblINFO_Di.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgTuyen_VC_Di
        '
        Me.dgTuyen_VC_Di.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTuyen_VC_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance241.BackColor = System.Drawing.Color.White
        Appearance241.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance241.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTuyen_VC_Di.DisplayLayout.Appearance = Appearance241
        UltraGridBand9.CardSettings.ShowCaption = False
        UltraGridColumn175.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        Appearance242.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn175.Header.Appearance = Appearance242
        UltraGridColumn175.Header.Caption = ""
        UltraGridColumn175.Header.VisiblePosition = 9
        UltraGridColumn175.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn175.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn175.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn175.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn175.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn175.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn176.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance243.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn176.Header.Appearance = Appearance243
        UltraGridColumn176.Header.VisiblePosition = 0
        UltraGridColumn176.Hidden = True
        UltraGridColumn176.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn176.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn176.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn176.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn177.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance244.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn177.Header.Appearance = Appearance244
        UltraGridColumn177.Header.VisiblePosition = 1
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn177.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn177.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn177.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn178.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance245.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn178.Header.Appearance = Appearance245
        UltraGridColumn178.Header.Caption = "Tên tuyến"
        UltraGridColumn178.Header.VisiblePosition = 2
        UltraGridColumn178.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn178.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn178.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(182, 0)
        UltraGridColumn178.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn178.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn179.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance246.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn179.Header.Appearance = Appearance246
        UltraGridColumn179.Header.VisiblePosition = 3
        UltraGridColumn179.Hidden = True
        UltraGridColumn179.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn179.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn179.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(79, 0)
        UltraGridColumn179.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn179.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn180.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance247.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn180.CellAppearance = Appearance247
        Appearance248.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn180.Header.Appearance = Appearance248
        UltraGridColumn180.Header.VisiblePosition = 4
        UltraGridColumn180.Hidden = True
        UltraGridColumn180.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn180.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn180.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn180.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn180.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn181.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance249.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn181.CellAppearance = Appearance249
        Appearance250.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn181.Header.Appearance = Appearance250
        UltraGridColumn181.Header.VisiblePosition = 5
        UltraGridColumn181.Hidden = True
        UltraGridColumn181.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn181.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn181.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(88, 0)
        UltraGridColumn181.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn181.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance251.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn182.CellAppearance = Appearance251
        Appearance252.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn182.Header.Appearance = Appearance252
        UltraGridColumn182.Header.Caption = "Mã tỉnh gốc"
        UltraGridColumn182.Header.VisiblePosition = 6
        UltraGridColumn182.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn182.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn182.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn182.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn182.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn183.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance253.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn183.CellAppearance = Appearance253
        Appearance254.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn183.Header.Appearance = Appearance254
        UltraGridColumn183.Header.Caption = "Mã tỉnh đích"
        UltraGridColumn183.Header.VisiblePosition = 7
        UltraGridColumn183.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn183.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn183.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn183.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn183.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn184.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance255.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn184.Header.Appearance = Appearance255
        UltraGridColumn184.Header.Caption = "Hướng"
        UltraGridColumn184.Header.VisiblePosition = 8
        UltraGridColumn184.Hidden = True
        UltraGridColumn184.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn184.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn184.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(142, 0)
        UltraGridColumn184.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn184.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn185.Header.Caption = ""
        UltraGridColumn185.Header.VisiblePosition = 10
        UltraGridColumn185.Hidden = True
        UltraGridColumn185.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn185.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn185.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn185.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn186.Header.VisiblePosition = 11
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 12
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 13
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.Caption = "Đối tác"
        UltraGridColumn189.Header.VisiblePosition = 14
        UltraGridColumn189.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn189.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn189.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn189.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn189.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn190.Header.Caption = "Phương tiện"
        UltraGridColumn190.Header.VisiblePosition = 15
        UltraGridColumn190.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn190.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn190.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(164, 0)
        UltraGridColumn190.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn190.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190})
        UltraGridBand9.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand9.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance256.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand9.Override.RowSelectorAppearance = Appearance256
        UltraGridBand9.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        UltraGridBand9.Override.RowSelectorWidth = 20
        UltraGridBand9.UseRowLayout = True
        Me.dgTuyen_VC_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance257.FontData.BoldAsString = "True"
        Appearance257.TextHAlign = Infragistics.Win.HAlign.Left
        Me.dgTuyen_VC_Di.DisplayLayout.CaptionAppearance = Appearance257
        Me.dgTuyen_VC_Di.DisplayLayout.InterBandSpacing = 10
        Me.dgTuyen_VC_Di.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance258.BackColor = System.Drawing.Color.Transparent
        Me.dgTuyen_VC_Di.DisplayLayout.Override.CardAreaAppearance = Appearance258
        Me.dgTuyen_VC_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance259.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance259.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance259.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance259.ForeColor = System.Drawing.Color.Black
        Appearance259.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance259.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTuyen_VC_Di.DisplayLayout.Override.HeaderAppearance = Appearance259
        Me.dgTuyen_VC_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance260.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyen_VC_Di.DisplayLayout.Override.RowAppearance = Appearance260
        Appearance261.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance261.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance261.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgTuyen_VC_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance261
        Me.dgTuyen_VC_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTuyen_VC_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance262.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance262.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance262.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance262.ForeColor = System.Drawing.Color.Black
        Me.dgTuyen_VC_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance262
        Me.dgTuyen_VC_Di.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyen_VC_Di.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTuyen_VC_Di.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgTuyen_VC_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTuyen_VC_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTuyen_VC_Di.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTuyen_VC_Di.Location = New System.Drawing.Point(-2, 40)
        Me.dgTuyen_VC_Di.Name = "dgTuyen_VC_Di"
        Me.dgTuyen_VC_Di.Size = New System.Drawing.Size(792, 248)
        Me.dgTuyen_VC_Di.TabIndex = 21
        Me.dgTuyen_VC_Di.Text = "Danh sách tuyến vận chuyển"
        '
        'txtTen_Tuyen_Di
        '
        Me.txtTen_Tuyen_Di.Location = New System.Drawing.Point(296, 144)
        Me.txtTen_Tuyen_Di.Name = "txtTen_Tuyen_Di"
        Me.txtTen_Tuyen_Di.Size = New System.Drawing.Size(224, 20)
        Me.txtTen_Tuyen_Di.TabIndex = 27
        Me.txtTen_Tuyen_Di.Text = ""
        Me.txtTen_Tuyen_Di.Visible = False
        '
        'txtId_Tuyen_Di
        '
        Me.txtId_Tuyen_Di.Location = New System.Drawing.Point(296, 184)
        Me.txtId_Tuyen_Di.Name = "txtId_Tuyen_Di"
        Me.txtId_Tuyen_Di.Size = New System.Drawing.Size(216, 20)
        Me.txtId_Tuyen_Di.TabIndex = 26
        Me.txtId_Tuyen_Di.Text = ""
        Me.txtId_Tuyen_Di.Visible = False
        '
        'TabBC37
        '
        Me.TabBC37.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabBC37.Controls.Add(Me.UltraTabPageControl1)
        Me.TabBC37.Controls.Add(Me.UltraTabPageControl2)
        Me.TabBC37.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabBC37.Location = New System.Drawing.Point(0, 0)
        Me.TabBC37.Name = "TabBC37"
        Me.TabBC37.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabBC37.Size = New System.Drawing.Size(794, 575)
        Me.TabBC37.TabIndex = 22
        UltraTab1.Key = "Tab_Child_BC37_Den"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "BC37 xác nhận đến"
        UltraTab2.Key = "Tab_Child_BC37_Di"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "BC37 xác nhận đi"
        Me.TabBC37.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.TabBC37.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(790, 552)
        '
        'ddDoi_Tac
        '
        Me.ddDoi_Tac.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance263.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDoi_Tac.DisplayLayout.Appearance = Appearance263
        Appearance264.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn191.Header.Appearance = Appearance264
        UltraGridColumn191.Header.Caption = "Mã"
        UltraGridColumn191.Header.VisiblePosition = 0
        UltraGridColumn191.Width = 60
        Appearance265.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn192.Header.Appearance = Appearance265
        UltraGridColumn192.Header.Caption = "Mã đối tác"
        UltraGridColumn192.Header.VisiblePosition = 1
        UltraGridColumn192.Width = 150
        UltraGridColumn193.Header.VisiblePosition = 2
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 3
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 4
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 5
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 6
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 7
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 8
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 9
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 10
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 11
        UltraGridColumn202.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 12
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 13
        UltraGridColumn204.Hidden = True
        Appearance266.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn205.Header.Appearance = Appearance266
        UltraGridColumn205.Header.Caption = "Tên đối tác"
        UltraGridColumn205.Header.VisiblePosition = 14
        UltraGridColumn205.Width = 250
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205})
        Me.ddDoi_Tac.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Appearance267.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance267.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance267.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance267.ForeColor = System.Drawing.Color.Black
        Appearance267.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDoi_Tac.DisplayLayout.Override.HeaderAppearance = Appearance267
        Me.ddDoi_Tac.DisplayMember = "PARTNER_CODE"
        Me.ddDoi_Tac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDoi_Tac.Location = New System.Drawing.Point(345, 223)
        Me.ddDoi_Tac.Name = "ddDoi_Tac"
        Me.ddDoi_Tac.Size = New System.Drawing.Size(104, 128)
        Me.ddDoi_Tac.TabIndex = 59
        Me.ddDoi_Tac.ValueMember = "ID"
        Me.ddDoi_Tac.Visible = False
        '
        'ddTRANSPORT_TYPE
        '
        Me.ddTRANSPORT_TYPE.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance268.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTRANSPORT_TYPE.DisplayLayout.Appearance = Appearance268
        Appearance269.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn206.Header.Appearance = Appearance269
        UltraGridColumn206.Header.Caption = "Mã"
        UltraGridColumn206.Header.VisiblePosition = 0
        UltraGridColumn206.Width = 60
        UltraGridColumn207.Header.Caption = "Tên phương tiện"
        UltraGridColumn207.Header.VisiblePosition = 1
        UltraGridColumn207.Width = 250
        UltraGridColumn208.Header.VisiblePosition = 2
        UltraGridColumn208.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn206, UltraGridColumn207, UltraGridColumn208})
        Me.ddTRANSPORT_TYPE.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Appearance270.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance270.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance270.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance270.ForeColor = System.Drawing.Color.Black
        Appearance270.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTRANSPORT_TYPE.DisplayLayout.Override.HeaderAppearance = Appearance270
        Me.ddTRANSPORT_TYPE.DisplayMember = "NAME"
        Me.ddTRANSPORT_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddTRANSPORT_TYPE.Location = New System.Drawing.Point(353, 231)
        Me.ddTRANSPORT_TYPE.Name = "ddTRANSPORT_TYPE"
        Me.ddTRANSPORT_TYPE.Size = New System.Drawing.Size(104, 128)
        Me.ddTRANSPORT_TYPE.TabIndex = 60
        Me.ddTRANSPORT_TYPE.ValueMember = "ID"
        Me.ddTRANSPORT_TYPE.Visible = False
        '
        'ddTrang_Thai
        '
        Me.ddTrang_Thai.Cursor = System.Windows.Forms.Cursors.Hand
        Appearance271.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddTrang_Thai.DisplayLayout.Appearance = Appearance271
        Appearance272.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn209.Header.Appearance = Appearance272
        UltraGridColumn209.Header.Caption = "Mã"
        UltraGridColumn209.Header.VisiblePosition = 0
        Appearance273.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn210.Header.Appearance = Appearance273
        UltraGridColumn210.Header.Caption = "Trạng thái"
        UltraGridColumn210.Header.VisiblePosition = 1
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn209, UltraGridColumn210})
        Me.ddTrang_Thai.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Appearance274.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance274.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance274.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance274.ForeColor = System.Drawing.Color.Black
        Appearance274.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddTrang_Thai.DisplayLayout.Override.HeaderAppearance = Appearance274
        Me.ddTrang_Thai.DisplayMember = "Ten"
        Me.ddTrang_Thai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddTrang_Thai.Location = New System.Drawing.Point(361, 239)
        Me.ddTrang_Thai.Name = "ddTrang_Thai"
        Me.ddTrang_Thai.Size = New System.Drawing.Size(104, 128)
        Me.ddTrang_Thai.TabIndex = 61
        Me.ddTrang_Thai.ValueMember = "Ma"
        Me.ddTrang_Thai.Visible = False
        '
        'FrmMonitor_Tuyen_Giao_BC37
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.TabBC37)
        Me.Controls.Add(Me.ddTRANSPORT_TYPE)
        Me.Controls.Add(Me.ddDoi_Tac)
        Me.Controls.Add(Me.ddTrang_Thai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmMonitor_Tuyen_Giao_BC37"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý xác nhận BC37 đến và BC37 đi theo tuyến vận chuyển"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.cbDoi_Tac_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRoad_Map, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTuyen_VC_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBC37_Den_Waiting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBc37_Den_Processed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.cbDoi_Tac_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBc37_Di_Processed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBC37_Di_Waiting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTuyen_VC_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabBC37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBC37.ResumeLayout(False)
        CType(Me.ddDoi_Tac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTRANSPORT_TYPE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddTrang_Thai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai bao bien toan Form"
    Private myTuyen_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Private myBC37_Den As New QLTGND_BC37_DEN(GConnectionString)
    Private myBC37_Di As New QLTGND_BC37_DI(GConnectionString)
    Dim myQLTGND_APILink As New QLTGND_APILink(GConnectionString)
    Dim myQLTGND_TUYEN_VC As New QLTGND_TUYEN_VC(GConnectionString)
    Dim myQLTGND_TUYEN_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet

    Dim myQLTGND_BC37 As New QLTGND_BC37(GConnectionString)
    Dim myQLTGND_BC37_Chi_Tiet As New QLTGND_BC37_Chi_Tiet

    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet

    Dim myQLTGND_BC37_DI As New QLTGND_BC37_DI(GConnectionString)
    Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet

    Dim myQLTGND_MAIL_TRIP_TRANSPORT_BC37 As New QLTGND_MAIL_TRIP_TRANSPORT_BC37(GConnectionString)
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet

    Dim myQLTGND_POSTBAG As New QLTGND_POSTBAG(GConnectionString)
    Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet

    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet

    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG(GConnectionString)
    Dim myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet As New QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Chi_Tiet

    Dim myCa_San_Xuat As New Ca_San_Xuat(GConnectionString)
    Dim myCa_San_Xuat_Chi_Tiet As New Ca_San_Xuat_Chi_Tiet

    Dim myQLTGND_PARTNER As New QLTGND_PARTNER(GConnectionString)

    Dim myQLTGND_TRANSPORT_TYPE As New QLTGND_TRANSPORT_TYPE(GConnectionString)

    Private myHam_Dung_Chung As New Ham_Dung_Chung
    Private myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myGridKeyDown1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Private myRow As Infragistics.Win.UltraWinGrid.UltraGridRow
    Private idx As Integer
    Private Const myIsBC37DEN As Integer = 0
    Private Const myIsBC37DI As Integer = 1
#End Region

#Region "Form_Load"
    Private Sub FrmMonitor_Tuyen_Giao_BC37_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtId_Tuyen_Den.Text = ""
        txtId_Tuyen_Di.Text = ""
        txtTen_Tuyen_Den.Text = ""
        txtTen_Tuyen_Di.Text = ""
        txtId_Tuyen_Di.Visible = False
        txtId_Tuyen_Den.Visible = False
        txtTen_Tuyen_Den.Visible = False
        txtTen_Tuyen_Di.Visible = False
        DataGrid_Tuyen_VC_Di()
        DataGrid_Tuyen_VC_Den()
        DataGrid_Doi_Tac_VC_Den()
        DataGrid_Doi_Tac_VC_Di()
        Tao_Bang_Trang_Thai()
        Load_Doi_Tac_Phuong_Tien()
        chkALL.Checked = False
        chkALL_CheckedChanged(chkALL, Nothing)
        Load_Thong_So(dgTuyen_VC_Den, dgTuyen_VC_Di)
    End Sub
#End Region

#Region "-----------------------Tao_Bang_Trang_Thai-----------------------"
    Private Sub Tao_Bang_Trang_Thai()

        'Them moi mot bang
        Dim dataTable As New dataTable("Trang_Thai")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow

        row = dataTable.NewRow()
        row("Ma") = 0
        row("Ten") = "Chưa xác nhận"
        dataTable.Rows.Add(row)


        row = dataTable.NewRow
        row("Ma") = 1
        row("Ten") = "Đã xác nhận"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma") = 2
        row("Ten") = "Đã truyền"
        dataTable.Rows.Add(row)

        ddTrang_Thai.DataSource = dataTable
        ddTrang_Thai.DataBind()
    End Sub
#End Region

    Private Sub Load_Thong_So(ByVal sender As Object, ByVal sender1 As Object)
        myGridKeyDown = sender
        Dim i As Integer
        Dim Tong_So As Integer = 0
        For i = 0 To myGridKeyDown.Rows.Count - 1
            If myGridKeyDown.Rows(i).Cells("Id_Tuyen").Text <> "" Then
                Tong_So += 1
            End If
        Next
        myGridKeyDown.Text = "Danh sách : " & Tong_So.ToString & " tuyến vận chuyển đến"

        myGridKeyDown1 = sender1
        Dim i1 As Integer
        Dim Tong_So1 As Integer = 0
        For i1 = 0 To myGridKeyDown1.Rows.Count - 1
            If myGridKeyDown1.Rows(i1).Cells("Id_Tuyen").Text <> "" Then
                Tong_So1 += 1
            End If
        Next
        myGridKeyDown1.Text = "Danh sách : " & Tong_So1.ToString & " tuyến vận chuyển đi"
    End Sub

#Region "chkALL_CheckedChanged"
    Private Sub chkALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkALL.CheckedChanged
        Try
            For Each mRow As UltraGridRow In dgTuyen_VC_Den.Rows
                mRow.Cells("Chon").Value = chkALL.Checked
            Next
            Dim chk As Boolean = True
            For Each mRow As UltraGridRow In dgTuyen_VC_Den.Rows
                If mRow.Cells("Chon").Value = True Then
                    chk = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgTuyen_VC_Di"
#Region "dgTuyen_VC_Di_InitializeLayout"
    Private Sub dgTuyen_VC_Di_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgTuyen_VC_Di.InitializeLayout, dgTuyen_VC_Den.InitializeLayout
        myGridKeyDown = sender
        'myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
        Next
        If myGridKeyDown.Name = "dgTuyen_VC_Den" Then
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
        End If
        With myGridKeyDown.DisplayLayout
            .Bands(0).Columns("PARTNER_ID").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("PARTNER_ID").ValueList = ddDoi_Tac

            .Bands(0).Columns("TRANSPORT_TYPE_ID").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("TRANSPORT_TYPE_ID").ValueList = ddTRANSPORT_TYPE
        End With
    End Sub

    Private Sub dgBC37_Den_Waiting_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgBC37_Den_Waiting.InitializeLayout, dgBc37_Den_Processed.InitializeLayout, dgBC37_Di_Waiting.InitializeLayout, dgBc37_Di_Processed.InitializeLayout
        myGridKeyDown = sender
        'myGridKeyDown.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
        For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
        Next
        With myGridKeyDown.DisplayLayout
            .Bands(0).Columns("PARTNER_ID").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("PARTNER_ID").ValueList = ddDoi_Tac

            .Bands(0).Columns("TRANSPORT_TYPE_ID").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("TRANSPORT_TYPE_ID").ValueList = ddTRANSPORT_TYPE

            .Bands(0).Columns("Trang_Thai").Style = ColumnStyle.DropDownValidate
            .Bands(0).Columns("Trang_Thai").ValueList = ddTrang_Thai
        End With
    End Sub
#End Region
#Region "dgTuyen_VC_Di_KeyDown"
    Private Sub dgTuyen_VC_Di_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgTuyen_VC_Di.KeyDown

    End Sub

#End Region
#Region "dgTuyen_VC_Di_AfterCellActivate"
    Private Sub dgTuyen_VC_Di_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgTuyen_VC_Di.AfterCellActivate
        Try
            txtId_Tuyen_Di.Text = dgTuyen_VC_Di.ActiveRow.Cells("Id_Tuyen").Text
            txtTen_Tuyen_Di.Text = dgTuyen_VC_Di.ActiveRow.Cells("Ten_Tuyen").Text
        Catch ex As Exception
            txtId_Tuyen_Di.Text = ""
            txtTen_Tuyen_Di.Text = ""
        End Try
        Refresh_Thong_Tin_Tuyen_VC_Di()
    End Sub
#End Region
#Region "dgTuyen_VC_Di_AfterRowActivate"
    Private Sub dgTuyen_VC_Di_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgTuyen_VC_Di.AfterRowActivate
        Try
            txtId_Tuyen_Di.Text = dgTuyen_VC_Di.ActiveRow.Cells("Id_Tuyen").Text
            txtTen_Tuyen_Di.Text = dgTuyen_VC_Di.ActiveRow.Cells("Ten_Tuyen").Text
        Catch ex As Exception
            txtId_Tuyen_Di.Text = ""
            txtTen_Tuyen_Di.Text = ""
        End Try
        Refresh_Thong_Tin_Tuyen_VC_Di()
    End Sub
#End Region
#Region "dgTuyen_VC_Di_ClickCellButton"
    Private Sub dgTuyen_VC_Di_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgTuyen_VC_Di.ClickCellButton
        Try
            If dgTuyen_VC_Di.ActiveRow.Cells("Id_Tuyen").Text <> "" Then
                Dim frm As New frmXacNhanBC37Di
                Dim idx As Integer
                idx = dgTuyen_VC_Di.ActiveRow.Index
                frm.myId_Tuyen_VC = CInt(dgTuyen_VC_Di.ActiveRow.Cells("Id_Tuyen").Text)
                frm.ShowDialog()
                dgTuyen_VC_Di.ActiveRow = dgTuyen_VC_Di.Rows(idx)
                dgTuyen_VC_Di_AfterRowActivate(dgTuyen_VC_Di, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region
#Region "dgTuyen_VC_Den"
#Region "dgTuyen_VC_Den_ClickCellButton"
    Private Sub dgTuyen_VC_Den_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgTuyen_VC_Den.ClickCellButton
        Try
            If dgTuyen_VC_Den.ActiveRow.Cells("Id_Tuyen").Text <> "" Then
                Dim frm As New frmXacNhanBC37Den
                Dim idx As Integer
                idx = dgTuyen_VC_Den.ActiveRow.Index
                frm.myId_Tuyen_VC = CInt(dgTuyen_VC_Den.ActiveRow.Cells("Id_Tuyen").Text)
                frm.ShowDialog()
                dgTuyen_VC_Den.ActiveRow = dgTuyen_VC_Den.Rows(idx)
                dgTuyen_VC_Den_AfterRowActivate(dgTuyen_VC_Den, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "dgTuyen_VC_Den_AfterCellActivate"
    Private Sub dgTuyen_VC_Den_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTuyen_VC_Den.AfterCellActivate
        Try
            txtId_Tuyen_Den.Text = dgTuyen_VC_Den.ActiveRow.Cells("Id_Tuyen").Text
            txtTen_Tuyen_Den.Text = dgTuyen_VC_Den.ActiveRow.Cells("Ten_Tuyen").Text
        Catch ex As Exception
            txtId_Tuyen_Den.Text = ""
            txtTen_Tuyen_Den.Text = ""
        End Try
        Refresh_Thong_Tin_Tuyen_VC_Den()
    End Sub
#End Region
#Region "dgTuyen_VC_Den_AfterRowActivate"
    Private Sub dgTuyen_VC_Den_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTuyen_VC_Den.AfterRowActivate
        Try
            txtId_Tuyen_Den.Text = dgTuyen_VC_Den.ActiveRow.Cells("Id_Tuyen").Text
            txtTen_Tuyen_Den.Text = dgTuyen_VC_Den.ActiveRow.Cells("Ten_Tuyen").Text
        Catch ex As Exception
            txtId_Tuyen_Den.Text = ""
            txtTen_Tuyen_Den.Text = ""
        End Try
        Refresh_Thong_Tin_Tuyen_VC_Den()
    End Sub
#End Region
#End Region

#Region "Ham nguoi dung"
#Region "DataGrid_Tuyen_VC_Di"
    Private Sub DataGrid_Tuyen_VC_Di()
        Try
            Dim mPartnerID As Integer
            If cbDoi_Tac_Di.Value Is DBNull.Value Or cbDoi_Tac_Di.Value Is Nothing Then
                mPartnerID = 0
            Else
                mPartnerID = cbDoi_Tac_Di.Value
            End If
            dgTuyen_VC_Di.DataSource = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach_Monitor(GBuu_Cuc_Khai_Thac, myIsBC37DI, mPartnerID)
            dgTuyen_VC_Di.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "DataGrid_Tuyen_VC_Den"
    Private Sub DataGrid_Tuyen_VC_Den()
        Try
            Dim mPartnerID As Integer
            If cbDoi_Tac_Den.Value Is DBNull.Value Or cbDoi_Tac_Den.Value Is Nothing Then
                mPartnerID = 0
            Else
                mPartnerID = cbDoi_Tac_Den.Value
            End If
            dgTuyen_VC_Den.DataSource = myTuyen_VC.QLTGND_TUYEN_VC_Danh_Sach_Monitor(GBuu_Cuc_Khai_Thac, myIsBC37DEN, mPartnerID)
            dgTuyen_VC_Den.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Refresh_Thong_Tin_Tuyen_VC_Den"
    Private Sub Refresh_Thong_Tin_Tuyen_VC_Den()
        Try
            Dim mTuyen_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
            Dim str As String = ""
            mTuyen_VC_Chi_Tiet = myTuyen_VC.QLTGND_TUYEN_VC_Lay(txtId_Tuyen_Den.Text)
            If mTuyen_VC_Chi_Tiet.Ten_Tuyen <> "" Then
                str = "=============== QUẢN LÝ NHẬN TÚI GÓI ĐẾN ==============="
                str = str & vbNewLine & "Tuyến : " & txtTen_Tuyen_Den.Text & "                      " & mTuyen_VC_Chi_Tiet.Ma_Tinh_Goc_Char & " (" & mTuyen_VC_Chi_Tiet.Ma_Tinh_Goc & ")  --->  " & mTuyen_VC_Chi_Tiet.Ma_Tinh_Dich_Char & " (" & mTuyen_VC_Chi_Tiet.Ma_Tinh_Dich & ")"
            Else
                str = ""
            End If
            lblINFO_Den.Text = str
            DataGrid_BC37_Den_Waiting(txtId_Tuyen_Den.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
            DataGrid_BC37_Den_Processed(txtId_Tuyen_Den.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblINFO_Den.Text = "#ERROR#"
            DataGrid_BC37_Den_Waiting(txtId_Tuyen_Den.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
            DataGrid_BC37_Den_Processed(txtId_Tuyen_Den.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
        End Try
    End Sub
#End Region
#Region "Refresh_Thong_Tin_Tuyen_VC_Di"
    Private Sub Refresh_Thong_Tin_Tuyen_VC_Di()
        Try
            Dim mTuyen_VC_Chi_Tiet As New QLTGND_TUYEN_VC_Chi_Tiet
            Dim str As String = ""
            mTuyen_VC_Chi_Tiet = myTuyen_VC.QLTGND_TUYEN_VC_Lay(txtId_Tuyen_Di.Text)
            If mTuyen_VC_Chi_Tiet.Ten_Tuyen <> "" Then
                str = "=============== QUẢN LÝ GIAO TÚI GÓI ĐI ==============="
                str = str & vbNewLine & "Tuyến : " & txtTen_Tuyen_Di.Text & "                      " & mTuyen_VC_Chi_Tiet.Ma_Tinh_Goc_Char & " (" & mTuyen_VC_Chi_Tiet.Ma_Tinh_Goc & ")  --->  " & mTuyen_VC_Chi_Tiet.Ma_Tinh_Dich_Char & " (" & mTuyen_VC_Chi_Tiet.Ma_Tinh_Dich & ")"
            Else
                str = ""
            End If
            lblINFO_Di.Text = str
            DataGrid_BC37_Di_Waiting(txtId_Tuyen_Di.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
            DataGrid_BC37_Di_Processed(txtId_Tuyen_Di.Text, GBuu_Cuc_Khai_Thac, 0, myHam_Dung_Chung.ConvertDateToInt(Now.Date))
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblINFO_Di.Text = "#ERROR#"
            DataGrid_BC37_Di_Waiting(txtId_Tuyen_Di.Text, GBuu_Cuc_Khai_Thac, 0, 0)
            DataGrid_BC37_Di_Processed(txtId_Tuyen_Di.Text, GBuu_Cuc_Khai_Thac, 0, 0)
        End Try
    End Sub
#End Region

#Region "DataGrid_BC37_Den_Waiting"
    Private Sub DataGrid_BC37_Den_Waiting(ByVal mId_Tuyen As Integer, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mMa_Bc As Integer, ByVal mNgay_Lap As Integer)
        Try
            dgBC37_Den_Waiting.DataSource = myBC37_Den.QLTGND_BC37_DEN_Danh_Sach_Theo_Truc_Duong_Thu(mId_Tuyen, mMa_Bc_Khai_Thac, mMa_Bc, mNgay_Lap, Trang_Thai_Chua_Xac_Nhan)
            dgBC37_Den_Waiting.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "DataGrid_BC37_Den_Processed"
    Private Sub DataGrid_BC37_Den_Processed(ByVal mId_Tuyen As Integer, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mMa_Bc As Integer, ByVal mNgay_Lap As Integer)
        Try
            dgBc37_Den_Processed.DataSource = myBC37_Den.QLTGND_BC37_DEN_Danh_Sach_Da_Xu_Ly_Theo_Truc_Duong_Thu(mId_Tuyen, mMa_Bc_Khai_Thac, mMa_Bc, mNgay_Lap, Trang_Thai_Chua_Xac_Nhan)
            dgBc37_Den_Processed.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "DataGrid_BC37_Di_Waiting"
    Private Sub DataGrid_BC37_Di_Waiting(ByVal mId_Tuyen As Integer, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mMa_Bc As Integer, ByVal mNgay_Lap As Integer)
        Try
            dgBC37_Di_Waiting.DataSource = myBC37_Di.QLTGND_BC37_DI_Danh_Sach_Theo_Truc_Duong_Thu(mId_Tuyen, mMa_Bc_Khai_Thac, mMa_Bc, mNgay_Lap, Trang_Thai_Chua_Xac_Nhan)
            dgBC37_Di_Waiting.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "DataGrid_BC37_Di_Processed"
    Private Sub DataGrid_BC37_Di_Processed(ByVal mId_Tuyen As Integer, ByVal mMa_Bc_Khai_Thac As Integer, ByVal mMa_Bc As Integer, ByVal mNgay_Lap As Integer)
        Try
            dgBc37_Di_Processed.DataSource = myBC37_Di.QLTGND_BC37_DI_Danh_Sach_Da_Xu_Ly_Theo_Truc_Duong_Thu(mId_Tuyen, mMa_Bc_Khai_Thac, mMa_Bc, mNgay_Lap, Trang_Thai_Chua_Xac_Nhan)
            dgBc37_Di_Processed.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid_Doi_Tac_VC_Den"
    Private Sub DataGrid_Doi_Tac_VC_Den()
        Try
            cbDoi_Tac_Den.DataSource = myQLTGND_PARTNER.QLTGND_PARTNER_Danh_Sach()
            cbDoi_Tac_Den.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "DataGrid_Doi_Tac_VC_Di"
    Private Sub DataGrid_Doi_Tac_VC_Di()
        Try
            cbDoi_Tac_Di.DataSource = myQLTGND_PARTNER.QLTGND_PARTNER_Danh_Sach()
            cbDoi_Tac_Di.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "Load_Doi_Tac_Phuong_Tien"
    Private Sub Load_Doi_Tac_Phuong_Tien()
        Try
            ddDoi_Tac.DataSource = myQLTGND_PARTNER.QLTGND_PARTNER_Danh_Sach()
            ddDoi_Tac.DataBind()

            ddTRANSPORT_TYPE.DataSource = myQLTGND_TRANSPORT_TYPE.QLTGND_TRANSPORT_TYPE_Danh_Sach()
            ddTRANSPORT_TYPE.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgTuyen_VC_Den_CellChange"
    Private Sub dgTuyen_VC_Den_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgTuyen_VC_Den.CellChange
        myGridKeyDown = sender
        If myGridKeyDown.ActiveCell.Column.Key = "Chon" Then
            Dim chk As Boolean = False
            For Each mRow As UltraGridRow In myGridKeyDown.Rows
                If mRow.Cells("Chon").Value = True Then
                    chk = True
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "btnTruyen_Du_Lieu_Len_Click"
    Private Sub btnTruyen_Du_Lieu_Len_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen_Du_Lieu_Len.Click
        'Kiem tra online
        If Not (Ham_Dung_Chung.UrlIsValid(myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1))) Then
            Exit Sub
        End If
        ' 1 : Truyền BC37
        Dim myData_BC37 As New DataTable
        Dim a As Integer
        myData_BC37 = myQLTGND_BC37.QLTGND_BC37_Danh_Sach_BC37_Theo_Trang_Thai_Truyen(gTruyen_Du_Lieu_0).Tables(0)
        If myData_BC37.Rows.Count > 0 Then
            For a = 0 To myData_BC37.Rows.Count - 1
                myQLTGND_BC37_Chi_Tiet = myQLTGND_BC37.QLTGND_BC37_Lay(myData_BC37.Rows(a).Item("BC37_ID"))
                'Truyền BC37
                Dim Thong_Bao_BC37 As String = Them_Thong_Tin_BC37(myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                    myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE.ToString, _
                    myQLTGND_BC37_Chi_Tiet.TO_PO_CODE.ToString, _
                    myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE.ToString, _
                    gStatus_BC37_1.ToString, _
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
                'CMessageBox.Show("Thông báo BC37: " & Thong_Bao_BC37, "Thông báo")

                ' 2 Truyền mail trip transport BC37
                Dim myData_Transport_BC37 As New DataTable
                Dim b As Integer
                myData_Transport_BC37 = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID, gWAY_TYPE_0).Tables(0)
                If myData_Transport_BC37.Rows.Count > 0 Then
                    For b = 0 To myData_Transport_BC37.Rows.Count - 1
                        myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Lay(myData_Transport_BC37.Rows(b).Item("ID"))
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
                        'CMessageBox.Show("Thông báo Transport BC37 : " & Thong_Bao_TranSport_BC37, "Thông báo")
                    Next
                End If

                ' 3 : Truyền Túi gói postbag
                Dim myData_Postbag As New DataTable
                Dim c As Integer
                myData_Postbag = myQLTGND_POSTBAG.QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID).Tables(0)
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

                        'CMessageBox.Show("Thông báo Postbag : " & Thong_Bao_Postbag, "Thông báo")
                    Next
                End If

                ' 4 : truyền chi tiết túi gói : mail trip transport postbag
                Dim myData_Transport_Postbag As New DataTable
                Dim d As Integer
                myData_Transport_Postbag = myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID, gWAY_TYPE_0).Tables(0)
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
                        'CMessageBox.Show("Thông báo Transport Postbag : " & Thong_Bao_Transport_Postbag, "Thông báo")
                    Next
                End If
                'Cập nhật trạng thái đã truyền cho BC37
                myQLTGND_BC37_Chi_Tiet.TRUYEN_DU_LIEU = gTruyen_Du_Lieu_1
                myQLTGND_BC37.QLTGND_BC37_Cap_Nhat_Them(myQLTGND_BC37_Chi_Tiet.BC37_ID, _
                myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.TO_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE, _
                myQLTGND_BC37_Chi_Tiet.BC37_DATE, _
                myQLTGND_BC37_Chi_Tiet.CREATE_USER, _
                myQLTGND_BC37_Chi_Tiet.CREATE_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.STATUS, _
                myQLTGND_BC37_Chi_Tiet.MAILTRIP_NUMBER, _
                myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                myQLTGND_BC37_Chi_Tiet.CONFIRM_USER, _
                myQLTGND_BC37_Chi_Tiet.CONFIRM_DATE, _
                myQLTGND_BC37_Chi_Tiet.CONFIRM_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.TRUYEN_DU_LIEU, _
                myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID, _
                myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT, _
                myQLTGND_BC37_Chi_Tiet.TOTAL_QUANTITY, _
                myQLTGND_BC37_Chi_Tiet.DELIVERY, _
                myQLTGND_BC37_Chi_Tiet.LAST_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.NEXT_PO_CODE, _
                myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_1, _
                myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_2)
                CMessageBox.Show("Truyền dữ liệu thành công BC37 : " & myQLTGND_BC37_Chi_Tiet.BC37_ID, "Thông báo")
            Next
        End If
    End Sub
#End Region

#Region "btnLay_Du_Lieu_Click"
    Private Sub btnLay_Du_Lieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLay_Du_Lieu.Click
        'Kiem tra online
        If Not (Ham_Dung_Chung.UrlIsValid(myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1))) Then
            Exit Sub
        End If
        Dim myData_BC37_Den As New DataTable
        Dim i As Integer
        Dim j As Integer
        For i = 0 To dgTuyen_VC_Den.Rows.Count - 1
            If dgTuyen_VC_Den.Rows(i).Cells("Chon").Value = True Then
                Dim myId_Tuyen As Integer = CInt(dgTuyen_VC_Den.Rows(i).Cells("Id_Tuyen").Text)
                myData_BC37_Den = Liet_Ke_Thong_Tin_BC37_Theo_So_Hieu_BC37("", myId_Tuyen, 0, 0)
                If Not myData_BC37_Den Is Nothing Then
                    If myData_BC37_Den.Rows.Count > 0 Then
                        For j = 0 To myData_BC37_Den.Rows.Count - 1
                            With myQLTGND_BC37_Chi_Tiet
                                .BC37_ID = myData_BC37_Den.Rows(j).Item("BC37_NUMBER")
                                .FROM_PO_CODE = myData_BC37_Den.Rows(j).Item("FROM_PO_CODE")
                                .TO_PO_CODE = myData_BC37_Den.Rows(j).Item("TO_PO_CODE")
                                .TRANSPORT_TYPE = myData_BC37_Den.Rows(j).Item("TRANSPORT_TYPE_CODE")
                                .BC37_DATE = myHam_Dung_Chung.ConvertStringToDateTime(myData_BC37_Den.Rows(j).Item("BC37_DATE"))
                                .CREATE_USER = myData_BC37_Den.Rows(j).Item("CREATE_USER")
                                .CREATE_PO_CODE = myData_BC37_Den.Rows(j).Item("CREATE_PO_CODE")
                                .STATUS = myData_BC37_Den.Rows(j).Item("STATUS")
                                .MAILTRIP_NUMBER = ""
                                .BC37_INDEX = j + 1
                                .CONFIRM_USER = myData_BC37_Den.Rows(j).Item("CONFIRM_USER")
                                .CONFIRM_DATE = myHam_Dung_Chung.ConvertStringToDateTime(myData_BC37_Den.Rows(j).Item("CONFIRM_DATE"))
                                .CONFIRM_PO_CODE = myData_BC37_Den.Rows(j).Item("CONFIRM_PO_CODE")
                                .TRUYEN_DU_LIEU = 0
                                .MAIL_ROUTE_ID = myData_BC37_Den.Rows(j).Item("MAIL_ROUTE_ID")
                                .TOTAL_WEIGHT = myData_BC37_Den.Rows(j).Item("TOTAL_WEIGHT")
                                .TOTAL_QUANTITY = myData_BC37_Den.Rows(j).Item("TOTAL_QUANTITY")
                                .DELIVERY = myData_BC37_Den.Rows(j).Item("DENIVERY")
                                .LAST_PO_CODE = ""
                                .NEXT_PO_CODE = ""
                                .NUMBER_OF_BAGS_1 = myData_BC37_Den.Rows(j).Item("TOTAL_QUANTITY")
                                .NUMBER_OF_BAGS_2 = myData_BC37_Den.Rows(j).Item("TOTAL_QUANTITY")
                            End With
                            myCa_San_Xuat_Chi_Tiet = myCa_San_Xuat.Lay(GId_Ca)
                            Dim myId_Duong_Thu As String = CreateId_Duong_Thu(CInt(myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE), CInt(myQLTGND_BC37_Chi_Tiet.TO_PO_CODE))
                            Dim myId_Chuyen_Thu As String = CreateId_Chuyen_Thu(myId_Duong_Thu, j, Ham_Dung_Chung.ConvertDateToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE), GLoai_Chuyen_Thu_Trong_Nuoc)
                            Dim myId_Ca As String = GId_Ca
                            myQLTGND_TUYEN_VC_Chi_Tiet = myQLTGND_TUYEN_VC.QLTGND_TUYEN_VC_Lay(myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID)
                            myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Cap_Nhat_Them(myQLTGND_BC37_Chi_Tiet.BC37_ID.ToString, _
                                myId_Duong_Thu.ToString, _
                                myId_Ca.ToString, _
                                GBuu_Cuc_Khai_Thac, _
                                CInt(myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE), _
                                Ham_Dung_Chung.ConvertDateToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE), _
                                IIf(Ham_Dung_Chung.ConvertTimeToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE) = 0, Ham_Dung_Chung.ConvertTimeToInt(Date.Now), Ham_Dung_Chung.ConvertTimeToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE)), _
                                CInt(myQLTGND_BC37_Chi_Tiet.DELIVERY), _
                                Ham_Dung_Chung.ConvertDateToInt(Date.Now), _
                                CInt(myQLTGND_BC37_Chi_Tiet.DELIVERY), _
                                0, myQLTGND_BC37_Chi_Tiet.TOTAL_QUANTITY, _
                                0, _
                                myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT, _
                                myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT, _
                                Gid_Nguoi_Dung, _
                                Ham_Dung_Chung.ConvertDateToInt(Date.Now), _
                                Ham_Dung_Chung.ConvertTimeToInt(Date.Now), _
                                False, _
                                False, _
                                0, _
                                0, _
                                myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE.ToString, _
                                0, _
                                myQLTGND_TUYEN_VC_Chi_Tiet.PARTNER_ID.ToString, _
                                myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID, _
                                Kiem_Tra_Qua_Giang(Convert.ToInt32(myQLTGND_BC37_Chi_Tiet.TO_PO_CODE), GBuu_Cuc_Khai_Thac))


                            Dim myData_Postbag_Den As New DataTable
                            Dim l As Integer
                            myData_Postbag_Den = Liet_Ke_Thong_Tin_Tui_Goi_Theo_So_Hieu_BC37(myQLTGND_BC37_Chi_Tiet.BC37_ID)
                            For l = 0 To myData_Postbag_Den.Rows.Count - 1
                                With myQLTGND_POSTBAG_DEN_Chi_Tiet
                                    .Id_Duong_Thu = myId_Duong_Thu
                                    .Id_Chuyen_Thu = myId_Chuyen_Thu
                                    .Id_Ca = myId_Ca
                                    .Ma_Bc_Khai_Thac = GBuu_Cuc_Khai_Thac
                                    .Ma_Bc = CInt(myData_Postbag_Den.Rows(l).Item("FROM_PO_CODE"))
                                    .Ngay_Dong = Ham_Dung_Chung.ConvertDateToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE)
                                    .Gio_Dong = IIf(Ham_Dung_Chung.ConvertTimeToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE) = 0, Ham_Dung_Chung.ConvertTimeToInt(Date.Now), Ham_Dung_Chung.ConvertTimeToInt(myQLTGND_BC37_Chi_Tiet.BC37_DATE))
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
                                    .IS_TRANSITION = Kiem_Tra_Qua_Giang(Convert.ToInt32(myQLTGND_BC37_Chi_Tiet.TO_PO_CODE), GBuu_Cuc_Khai_Thac)
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
                        Next
                    End If
                End If
            End If
        Next
    End Sub
#End Region

#Region "btnTruyen_Du_Lieu_XN_Len_Click"
    Private Sub btnTruyen_Du_Lieu_XN_Len_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruyen_Du_Lieu_XN_Len.Click
        'Kiem tra online
        If Not (Ham_Dung_Chung.UrlIsValid(myQLTGND_APILink.QLTGND_APILink_Danh_Sach().Tables(0).Rows(0)(1))) Then
            Exit Sub
        End If
        ' 1 : Truyền BC37
        Dim myData_BC37 As New DataTable
        Dim a As Integer
        Dim a1 As Integer
        For a1 = 0 To dgTuyen_VC_Den.Rows.Count - 1
            If dgTuyen_VC_Den.Rows(a1).Cells("Chon").Value = True Then
                Dim myId_Tuyen As Integer = CInt(dgTuyen_VC_Den.Rows(a1).Cells("Id_Tuyen").Text)
                myData_BC37 = myQLTGND_BC37.QLTGND_BC37_Danh_Sach_BC37_Theo_Trang_Thai_Truyen(gTruyen_Du_Lieu_0).Tables(0)
                If myData_BC37.Rows.Count > 0 Then
                    For a = 0 To myData_BC37.Rows.Count - 1
                        myQLTGND_BC37_Chi_Tiet = myQLTGND_BC37.QLTGND_BC37_Lay(myData_BC37.Rows(a).Item("BC37_ID"))
                        'Truyền BC37
                        Dim Thong_Bao_BC37 As String = Them_Thong_Tin_BC37(myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                            myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE.ToString, _
                            myQLTGND_BC37_Chi_Tiet.TO_PO_CODE.ToString, _
                            myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE.ToString, _
                            gStatus_BC37_1.ToString, _
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

                        ' 2 Truyền mail trip transport BC37
                        Dim myData_Transport_BC37 As New DataTable
                        Dim b As Integer
                        myData_Transport_BC37 = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID, gWAY_TYPE_1).Tables(0)
                        If myData_Transport_BC37.Rows.Count > 0 Then
                            For b = 0 To myData_Transport_BC37.Rows.Count - 1
                                myQLTGND_MAIL_TRIP_TRANSPORT_BC37_Chi_Tiet = myQLTGND_MAIL_TRIP_TRANSPORT_BC37.QLTGND_MAIL_TRIP_TRANSPORT_BC37_Lay(myData_Transport_BC37.Rows(b).Item("ID"))
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
                            Next
                        End If

                        ' 3 : Truyền Túi gói postbag
                        Dim myData_Postbag As New DataTable
                        Dim c As Integer
                        myData_Postbag = myQLTGND_POSTBAG.QLTGND_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID).Tables(0)
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

                                CMessageBox.Show("Thông báo Postbag : " & Thong_Bao_Postbag, "Thông báo")
                            Next
                        End If

                        ' 4 : truyền chi tiết túi gói : mail trip transport postbag
                        Dim myData_Transport_Postbag As New DataTable
                        Dim d As Integer
                        myData_Transport_Postbag = myQLTGND_MAIL_TRIP_TRANSPORT_POSTBAG.QLTGND_MAIL_TRIP_TRANSPORT_POSTBAG_Danh_Sach_Theo_BC37_ID_Truyen(myQLTGND_BC37_Chi_Tiet.BC37_ID, gWAY_TYPE_1).Tables(0)
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
                        'Cập nhật trạng thái đã truyền cho BC37
                        myQLTGND_BC37_Chi_Tiet.TRUYEN_DU_LIEU = gTruyen_Du_Lieu_1
                        myQLTGND_BC37.QLTGND_BC37_Cap_Nhat_Them(myQLTGND_BC37_Chi_Tiet.BC37_ID, _
                        myQLTGND_BC37_Chi_Tiet.FROM_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.TO_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.TRANSPORT_TYPE, _
                        myQLTGND_BC37_Chi_Tiet.BC37_DATE, _
                        myQLTGND_BC37_Chi_Tiet.CREATE_USER, _
                        myQLTGND_BC37_Chi_Tiet.CREATE_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.STATUS, _
                        myQLTGND_BC37_Chi_Tiet.MAILTRIP_NUMBER, _
                        myQLTGND_BC37_Chi_Tiet.BC37_INDEX, _
                        myQLTGND_BC37_Chi_Tiet.CONFIRM_USER, _
                        myQLTGND_BC37_Chi_Tiet.CONFIRM_DATE, _
                        myQLTGND_BC37_Chi_Tiet.CONFIRM_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.TRUYEN_DU_LIEU, _
                        myQLTGND_BC37_Chi_Tiet.MAIL_ROUTE_ID, _
                        myQLTGND_BC37_Chi_Tiet.TOTAL_WEIGHT, _
                        myQLTGND_BC37_Chi_Tiet.TOTAL_QUANTITY, _
                        myQLTGND_BC37_Chi_Tiet.DELIVERY, _
                        myQLTGND_BC37_Chi_Tiet.LAST_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.NEXT_PO_CODE, _
                        myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_1, _
                        myQLTGND_BC37_Chi_Tiet.NUMBER_OF_BAGS_2)
                    Next
                End If
            End If
        Next
    End Sub
#End Region

#Region "btnTat_Ca_Tuyen_Click"
    Private Sub btnTat_Ca_Tuyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTat_Ca_Tuyen.Click
        Dim frm As New frmXacNhanBC37Di
        frm.myId_Tuyen_VC = 0
        frm.ShowDialog()
    End Sub
#End Region

#Region "cbDoi_Tac_Den_ValueChanged"
    Private Sub cbDoi_Tac_Den_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDoi_Tac_Den.ValueChanged
        DataGrid_Tuyen_VC_Den()
    End Sub
#End Region

#Region "cbDoi_Tac_Di_ValueChanged"
    Private Sub cbDoi_Tac_Di_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDoi_Tac_Di.ValueChanged
        DataGrid_Tuyen_VC_Di()
    End Sub
#End Region
End Class

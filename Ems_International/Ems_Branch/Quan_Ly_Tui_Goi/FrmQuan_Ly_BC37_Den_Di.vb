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
Public Class FrmQuan_Ly_BC37_Den_Di
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
    Friend WithEvents dgBC37_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTui_Goi_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgBC37_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgTui_Goi_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblDen As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTruyenDen As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTruyenDi As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_Vo_Tui")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_BP")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_COD")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_DV")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Cuoc_Chinh")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Tui_Thu")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_BC37")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BC37", -1)
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BC37_ID")
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Lap")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Lap")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dot_Giao", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Giao")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Giao")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_In")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trang_Thai")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRANSPORT_TYPE_ID")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TRIP_ID")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PARTNER_ID")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KLBP")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MAIL_ROUTE_ID")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IS_TRANSITION")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmQuan_Ly_BC37_Den_Di))
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.lblDen = New Infragistics.Win.Misc.UltraLabel
        Me.btnTruyenDen = New Infragistics.Win.Misc.UltraButton
        Me.dgTui_Goi_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgBC37_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnTruyenDi = New Infragistics.Win.Misc.UltraButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.dgTui_Goi_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgBC37_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.TabBC37 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.dgTui_Goi_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBC37_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.dgTui_Goi_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBC37_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabBC37, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBC37.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.lblDen)
        Me.UltraTabPageControl1.Controls.Add(Me.btnTruyenDen)
        Me.UltraTabPageControl1.Controls.Add(Me.dgTui_Goi_Den)
        Me.UltraTabPageControl1.Controls.Add(Me.dgBC37_Den)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(788, 545)
        '
        'lblDen
        '
        Appearance1.ForeColor = System.Drawing.Color.IndianRed
        Me.lblDen.Appearance = Appearance1
        Me.lblDen.BackColor = System.Drawing.Color.Black
        Me.lblDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance2.ForeColor = System.Drawing.Color.IndianRed
        Me.lblDen.HotTrackAppearance = Appearance2
        Me.lblDen.Location = New System.Drawing.Point(608, 0)
        Me.lblDen.Name = "lblDen"
        Me.lblDen.Size = New System.Drawing.Size(184, 192)
        Me.lblDen.TabIndex = 22
        Me.lblDen.Text = "."
        '
        'btnTruyenDen
        '
        Me.btnTruyenDen.Location = New System.Drawing.Point(608, 192)
        Me.btnTruyenDen.Name = "btnTruyenDen"
        Me.btnTruyenDen.Size = New System.Drawing.Size(180, 48)
        Me.btnTruyenDen.TabIndex = 21
        Me.btnTruyenDen.Text = "Truyền lại"
        '
        'dgTui_Goi_Den
        '
        Me.dgTui_Goi_Den.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTui_Goi_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTui_Goi_Den.DisplayLayout.Appearance = Appearance3
        UltraGridBand1.CardSettings.ShowCaption = False
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn1.CellAppearance = Appearance4
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance5
        UltraGridColumn1.Header.Caption = ""
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(35, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance6
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.CellAppearance = Appearance7
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn3.Header.Appearance = Appearance8
        UltraGridColumn3.Header.Caption = "Mã bưu cục"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn4.CellAppearance = Appearance9
        Appearance10.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn4.Header.Appearance = Appearance10
        UltraGridColumn4.Header.Caption = "Số chuyến thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance11
        UltraGridColumn5.Header.Caption = "Id ca"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.CellAppearance = Appearance12
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance13
        UltraGridColumn6.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.CellAppearance = Appearance14
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn7.Header.Appearance = Appearance15
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
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.Header.Appearance = Appearance16
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance17
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance18
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        Appearance19.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn11.CellAppearance = Appearance19
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance20
        UltraGridColumn11.Header.Caption = "Túi số"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance21
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Hidden = True
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn13.CellAppearance = Appearance22
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance23
        UltraGridColumn13.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellAppearance = Appearance24
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance25
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance26
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance27
        UltraGridColumn15.Header.Caption = "Tổng khối lượng"
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance28
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance29
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance30
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.Hidden = True
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance31
        UltraGridColumn19.Header.VisiblePosition = 21
        UltraGridColumn19.Hidden = True
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance32
        UltraGridColumn20.Header.VisiblePosition = 22
        UltraGridColumn20.Hidden = True
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn21.Header.Appearance = Appearance33
        UltraGridColumn21.Header.Caption = "Truyền khai thác"
        UltraGridColumn21.Header.VisiblePosition = 18
        UltraGridColumn21.Hidden = True
        Appearance34.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance34
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance35
        UltraGridColumn23.Header.Caption = "Ngày hệ thống"
        UltraGridColumn23.Header.VisiblePosition = 12
        UltraGridColumn23.Hidden = True
        Appearance36.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance36
        UltraGridColumn24.Header.Caption = "Chốt số liệu"
        UltraGridColumn24.Header.VisiblePosition = 16
        UltraGridColumn24.Hidden = True
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn25.Header.Appearance = Appearance37
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn26.Header.Appearance = Appearance38
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        Appearance39.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn27.Header.Appearance = Appearance39
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn27.Hidden = True
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn28.Header.Appearance = Appearance40
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn28.Hidden = True
        Appearance41.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn29.Header.Appearance = Appearance41
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.Hidden = True
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn30.Header.Appearance = Appearance42
        UltraGridColumn30.Header.Caption = "Chuyển tiếp"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridBand1.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance43.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand1.Override.RowSelectorAppearance = Appearance43
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgTui_Goi_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgTui_Goi_Den.DisplayLayout.InterBandSpacing = 10
        Me.dgTui_Goi_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.dgTui_Goi_Den.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Me.dgTui_Goi_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.ForeColor = System.Drawing.Color.Black
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance45.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTui_Goi_Den.DisplayLayout.Override.HeaderAppearance = Appearance45
        Me.dgTui_Goi_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance46.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTui_Goi_Den.DisplayLayout.Override.RowAppearance = Appearance46
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance47.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgTui_Goi_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance47
        Me.dgTui_Goi_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTui_Goi_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.dgTui_Goi_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance48
        Me.dgTui_Goi_Den.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTui_Goi_Den.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTui_Goi_Den.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgTui_Goi_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTui_Goi_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTui_Goi_Den.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTui_Goi_Den.Location = New System.Drawing.Point(0, 240)
        Me.dgTui_Goi_Den.Name = "dgTui_Goi_Den"
        Me.dgTui_Goi_Den.Size = New System.Drawing.Size(792, 304)
        Me.dgTui_Goi_Den.TabIndex = 20
        '
        'dgBC37_Den
        '
        Me.dgBC37_Den.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBC37_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance49.BackColor = System.Drawing.Color.White
        Appearance49.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBC37_Den.DisplayLayout.Appearance = Appearance49
        UltraGridBand2.CardSettings.ShowCaption = False
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn31.CellAppearance = Appearance50
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn31.Header.Appearance = Appearance51
        UltraGridColumn31.Header.Caption = ""
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(33, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn32.Header.Appearance = Appearance52
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn33.Header.Appearance = Appearance53
        UltraGridColumn33.Header.Caption = "Số hiệu BC37"
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn34.Header.Appearance = Appearance54
        UltraGridColumn34.Header.Caption = "Id Đường Thư"
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance55
        UltraGridColumn35.Header.Caption = "Id ca"
        UltraGridColumn35.Header.VisiblePosition = 4
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.CellAppearance = Appearance56
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance57
        UltraGridColumn36.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.CellAppearance = Appearance58
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance59
        UltraGridColumn37.Header.Caption = "Mã bưu cục"
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.CellAppearance = Appearance60
        Appearance61.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance61
        UltraGridColumn38.Header.Caption = "Ngày lập"
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.UseEditorMaskSettings = True
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance62
        UltraGridColumn39.Header.Caption = "Giờ lập"
        UltraGridColumn39.Header.VisiblePosition = 8
        UltraGridColumn39.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.UseEditorMaskSettings = True
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance63.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn40.CellAppearance = Appearance63
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance64
        UltraGridColumn40.Header.Caption = "Đợt giao"
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn41.Header.Appearance = Appearance65
        UltraGridColumn41.Header.Caption = "Ngày giao"
        UltraGridColumn41.Header.VisiblePosition = 10
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance66.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance66
        UltraGridColumn42.Header.Caption = "Giờ giao"
        UltraGridColumn42.Header.VisiblePosition = 11
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance67.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn43.CellAppearance = Appearance67
        Appearance68.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance68
        UltraGridColumn43.Header.Caption = "Chuyến thư"
        UltraGridColumn43.Header.VisiblePosition = 14
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance69.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance69
        UltraGridColumn44.Header.Caption = "Id người dùng"
        UltraGridColumn44.Header.VisiblePosition = 12
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance70.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance70
        UltraGridColumn45.Header.Caption = "Ngày hệ thống"
        UltraGridColumn45.Header.VisiblePosition = 13
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance71.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance71
        UltraGridColumn46.Header.Caption = "Giờ hệ thống"
        UltraGridColumn46.Header.VisiblePosition = 15
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance72.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn47.Header.Appearance = Appearance72
        UltraGridColumn47.Header.Caption = "Đã in"
        UltraGridColumn47.Header.VisiblePosition = 16
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance73.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn48.Header.Appearance = Appearance73
        UltraGridColumn48.Header.Caption = "Chốt số liệu"
        UltraGridColumn48.Header.VisiblePosition = 17
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance74.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn49.Header.Appearance = Appearance74
        UltraGridColumn49.Header.Caption = "Truyền khai thác"
        UltraGridColumn49.Header.VisiblePosition = 18
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance75.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.Header.Appearance = Appearance75
        UltraGridColumn50.Header.VisiblePosition = 22
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance76.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn51.Header.Appearance = Appearance76
        UltraGridColumn51.Header.VisiblePosition = 19
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance77.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.Header.Appearance = Appearance77
        UltraGridColumn52.Header.VisiblePosition = 20
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance78.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn53.Header.Appearance = Appearance78
        UltraGridColumn53.Header.VisiblePosition = 21
        UltraGridColumn53.Hidden = True
        Appearance79.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn54.CellAppearance = Appearance79
        Appearance80.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn54.Header.Appearance = Appearance80
        UltraGridColumn54.Header.Caption = "Tổng số BP"
        UltraGridColumn54.Header.VisiblePosition = 24
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance81.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn55.CellAppearance = Appearance81
        Appearance82.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn55.Header.Appearance = Appearance82
        UltraGridColumn55.Header.Caption = "Khối lượng"
        UltraGridColumn55.Header.VisiblePosition = 23
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 25
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.Caption = "Tổng Túi"
        UltraGridColumn57.Header.VisiblePosition = 26
        UltraGridColumn58.Header.Caption = "Tổng KL"
        UltraGridColumn58.Header.VisiblePosition = 27
        Appearance83.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn59.Header.Appearance = Appearance83
        UltraGridColumn59.Header.Caption = "Chuyển tiếp"
        UltraGridColumn59.Header.VisiblePosition = 28
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        UltraGridBand2.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance84.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand2.Override.RowSelectorAppearance = Appearance84
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgBC37_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgBC37_Den.DisplayLayout.InterBandSpacing = 10
        Me.dgBC37_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.dgBC37_Den.DisplayLayout.Override.BorderStyleSummaryFooter = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Me.dgBC37_Den.DisplayLayout.Override.CardAreaAppearance = Appearance85
        Me.dgBC37_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance86.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance86.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance86.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance86.ForeColor = System.Drawing.Color.Black
        Appearance86.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance86.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBC37_Den.DisplayLayout.Override.HeaderAppearance = Appearance86
        Me.dgBC37_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance87.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Den.DisplayLayout.Override.RowAppearance = Appearance87
        Appearance88.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance88.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance88.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBC37_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance88
        Me.dgBC37_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBC37_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance89.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance89.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance89.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance89.ForeColor = System.Drawing.Color.Black
        Me.dgBC37_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance89
        Me.dgBC37_Den.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Den.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Den.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBC37_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBC37_Den.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBC37_Den.Location = New System.Drawing.Point(0, 0)
        Me.dgBC37_Den.Name = "dgBC37_Den"
        Me.dgBC37_Den.Size = New System.Drawing.Size(608, 240)
        Me.dgBC37_Den.TabIndex = 18
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.btnTruyenDi)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl2.Controls.Add(Me.dgTui_Goi_Di)
        Me.UltraTabPageControl2.Controls.Add(Me.dgBC37_Di)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(788, 545)
        '
        'btnTruyenDi
        '
        Me.btnTruyenDi.Location = New System.Drawing.Point(608, 192)
        Me.btnTruyenDi.Name = "btnTruyenDi"
        Me.btnTruyenDi.Size = New System.Drawing.Size(180, 48)
        Me.btnTruyenDi.TabIndex = 24
        Me.btnTruyenDi.Text = "Truyền lại"
        '
        'UltraLabel1
        '
        Appearance90.ForeColor = System.Drawing.Color.IndianRed
        Me.UltraLabel1.Appearance = Appearance90
        Me.UltraLabel1.BackColor = System.Drawing.Color.Black
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance91.ForeColor = System.Drawing.Color.IndianRed
        Me.UltraLabel1.HotTrackAppearance = Appearance91
        Me.UltraLabel1.Location = New System.Drawing.Point(608, 0)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(184, 192)
        Me.UltraLabel1.TabIndex = 23
        Me.UltraLabel1.Text = "."
        '
        'dgTui_Goi_Di
        '
        Me.dgTui_Goi_Di.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTui_Goi_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance92.BackColor = System.Drawing.Color.White
        Appearance92.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgTui_Goi_Di.DisplayLayout.Appearance = Appearance92
        UltraGridBand3.CardSettings.ShowCaption = False
        Appearance93.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn60.CellAppearance = Appearance93
        Appearance94.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn60.Header.Appearance = Appearance94
        UltraGridColumn60.Header.Caption = ""
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(25, 0)
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        Appearance95.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn61.Header.Appearance = Appearance95
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn61.Hidden = True
        Appearance96.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.CellAppearance = Appearance96
        Appearance97.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn62.Header.Appearance = Appearance97
        UltraGridColumn62.Header.Caption = "Mã bưu cục"
        UltraGridColumn62.Header.VisiblePosition = 2
        UltraGridColumn62.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn62.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn62.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn62.RowLayoutColumnInfo.SpanY = 2
        Appearance98.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn63.CellAppearance = Appearance98
        Appearance99.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn63.Header.Appearance = Appearance99
        UltraGridColumn63.Header.Caption = "Số chuyến thư"
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        Appearance100.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn64.Header.Appearance = Appearance100
        UltraGridColumn64.Header.Caption = "Id ca"
        UltraGridColumn64.Header.VisiblePosition = 4
        UltraGridColumn64.Hidden = True
        Appearance101.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.CellAppearance = Appearance101
        Appearance102.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn65.Header.Appearance = Appearance102
        UltraGridColumn65.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn65.Header.VisiblePosition = 5
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        Appearance103.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn66.CellAppearance = Appearance103
        Appearance104.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn66.Header.Appearance = Appearance104
        UltraGridColumn66.Header.Caption = "Ngày đóng"
        UltraGridColumn66.Header.VisiblePosition = 6
        UltraGridColumn66.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn66.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn66.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.UseEditorMaskSettings = True
        Appearance105.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn67.Header.Appearance = Appearance105
        UltraGridColumn67.Header.VisiblePosition = 7
        UltraGridColumn67.Hidden = True
        Appearance106.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn68.Header.Appearance = Appearance106
        UltraGridColumn68.Header.VisiblePosition = 8
        UltraGridColumn68.Hidden = True
        Appearance107.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn69.Header.Appearance = Appearance107
        UltraGridColumn69.Header.VisiblePosition = 9
        UltraGridColumn69.Hidden = True
        Appearance108.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn70.CellAppearance = Appearance108
        Appearance109.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn70.Header.Appearance = Appearance109
        UltraGridColumn70.Header.Caption = "Túi số"
        UltraGridColumn70.Header.VisiblePosition = 10
        UltraGridColumn70.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn70.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn70.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn70.RowLayoutColumnInfo.SpanY = 2
        Appearance110.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn71.Header.Appearance = Appearance110
        UltraGridColumn71.Header.VisiblePosition = 11
        UltraGridColumn71.Hidden = True
        Appearance111.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn72.CellAppearance = Appearance111
        Appearance112.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn72.Header.Appearance = Appearance112
        UltraGridColumn72.Header.Caption = "Tổng số bưu phẩm"
        UltraGridColumn72.Header.VisiblePosition = 13
        UltraGridColumn72.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn72.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn72.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn72.RowLayoutColumnInfo.SpanY = 2
        Appearance113.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn73.CellAppearance = Appearance113
        Appearance114.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn73.Header.Appearance = Appearance114
        UltraGridColumn73.Header.VisiblePosition = 14
        UltraGridColumn73.Hidden = True
        Appearance115.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn74.CellAppearance = Appearance115
        Appearance116.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn74.Header.Appearance = Appearance116
        UltraGridColumn74.Header.Caption = "Tổng khối lượng"
        UltraGridColumn74.Header.VisiblePosition = 15
        UltraGridColumn74.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn74.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn74.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn74.RowLayoutColumnInfo.SpanY = 2
        Appearance117.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn75.Header.Appearance = Appearance117
        UltraGridColumn75.Header.VisiblePosition = 17
        UltraGridColumn75.Hidden = True
        Appearance118.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn76.Header.Appearance = Appearance118
        UltraGridColumn76.Header.VisiblePosition = 19
        UltraGridColumn76.Hidden = True
        Appearance119.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn77.Header.Appearance = Appearance119
        UltraGridColumn77.Header.VisiblePosition = 20
        UltraGridColumn77.Hidden = True
        Appearance120.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn78.Header.Appearance = Appearance120
        UltraGridColumn78.Header.VisiblePosition = 21
        UltraGridColumn78.Hidden = True
        Appearance121.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn79.Header.Appearance = Appearance121
        UltraGridColumn79.Header.VisiblePosition = 22
        UltraGridColumn79.Hidden = True
        Appearance122.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn80.Header.Appearance = Appearance122
        UltraGridColumn80.Header.Caption = "Truyền khai thác"
        UltraGridColumn80.Header.VisiblePosition = 18
        UltraGridColumn80.Hidden = True
        Appearance123.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn81.Header.Appearance = Appearance123
        UltraGridColumn81.Header.VisiblePosition = 23
        UltraGridColumn81.Hidden = True
        Appearance124.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn82.Header.Appearance = Appearance124
        UltraGridColumn82.Header.Caption = "Ngày hệ thống"
        UltraGridColumn82.Header.VisiblePosition = 12
        UltraGridColumn82.Hidden = True
        Appearance125.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn83.Header.Appearance = Appearance125
        UltraGridColumn83.Header.Caption = "Chốt số liệu"
        UltraGridColumn83.Header.VisiblePosition = 16
        UltraGridColumn83.Hidden = True
        Appearance126.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn84.Header.Appearance = Appearance126
        UltraGridColumn84.Header.VisiblePosition = 24
        UltraGridColumn84.Hidden = True
        Appearance127.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn85.Header.Appearance = Appearance127
        UltraGridColumn85.Header.VisiblePosition = 25
        UltraGridColumn85.Hidden = True
        Appearance128.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn86.Header.Appearance = Appearance128
        UltraGridColumn86.Header.VisiblePosition = 26
        UltraGridColumn86.Hidden = True
        Appearance129.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn87.Header.Appearance = Appearance129
        UltraGridColumn87.Header.VisiblePosition = 27
        UltraGridColumn87.Hidden = True
        Appearance130.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn88.Header.Appearance = Appearance130
        UltraGridColumn88.Header.VisiblePosition = 28
        UltraGridColumn88.Hidden = True
        Appearance131.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn89.Header.Appearance = Appearance131
        UltraGridColumn89.Header.Caption = "Chuyển tiếp"
        UltraGridColumn89.Header.VisiblePosition = 29
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance132.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand3.Override.RowSelectorAppearance = Appearance132
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgTui_Goi_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgTui_Goi_Di.DisplayLayout.InterBandSpacing = 10
        Me.dgTui_Goi_Di.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Me.dgTui_Goi_Di.DisplayLayout.Override.CardAreaAppearance = Appearance133
        Me.dgTui_Goi_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance134.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance134.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance134.ForeColor = System.Drawing.Color.Black
        Appearance134.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance134.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgTui_Goi_Di.DisplayLayout.Override.HeaderAppearance = Appearance134
        Me.dgTui_Goi_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance135.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTui_Goi_Di.DisplayLayout.Override.RowAppearance = Appearance135
        Appearance136.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance136.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance136.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgTui_Goi_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance136
        Me.dgTui_Goi_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgTui_Goi_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance137.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance137.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance137.ForeColor = System.Drawing.Color.Black
        Me.dgTui_Goi_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance137
        Me.dgTui_Goi_Di.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTui_Goi_Di.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgTui_Goi_Di.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgTui_Goi_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgTui_Goi_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgTui_Goi_Di.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTui_Goi_Di.Location = New System.Drawing.Point(0, 240)
        Me.dgTui_Goi_Di.Name = "dgTui_Goi_Di"
        Me.dgTui_Goi_Di.Size = New System.Drawing.Size(792, 304)
        Me.dgTui_Goi_Di.TabIndex = 21
        '
        'dgBC37_Di
        '
        Me.dgBC37_Di.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgBC37_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance138.BackColor = System.Drawing.Color.White
        Appearance138.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance138.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgBC37_Di.DisplayLayout.Appearance = Appearance138
        UltraGridBand4.CardSettings.ShowCaption = False
        Appearance139.TextHAlign = Infragistics.Win.HAlign.Left
        UltraGridColumn90.CellAppearance = Appearance139
        Appearance140.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn90.Header.Appearance = Appearance140
        UltraGridColumn90.Header.Caption = ""
        UltraGridColumn90.Header.VisiblePosition = 0
        UltraGridColumn90.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn90.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn90.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(23, 0)
        UltraGridColumn90.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn90.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance141.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn91.Header.Appearance = Appearance141
        UltraGridColumn91.Header.VisiblePosition = 1
        UltraGridColumn91.Hidden = True
        UltraGridColumn91.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn91.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn91.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn91.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance142.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn92.Header.Appearance = Appearance142
        UltraGridColumn92.Header.Caption = "Số hiệu BC37"
        UltraGridColumn92.Header.VisiblePosition = 2
        UltraGridColumn92.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn92.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn92.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn92.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn92.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance143.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn93.Header.Appearance = Appearance143
        UltraGridColumn93.Header.Caption = "Id Đường Thư"
        UltraGridColumn93.Header.VisiblePosition = 3
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance144.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.Header.Appearance = Appearance144
        UltraGridColumn94.Header.Caption = "Id ca"
        UltraGridColumn94.Header.VisiblePosition = 4
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance145.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.CellAppearance = Appearance145
        Appearance146.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn95.Header.Appearance = Appearance146
        UltraGridColumn95.Header.Caption = "Mã bưu cục khai thác"
        UltraGridColumn95.Header.VisiblePosition = 5
        UltraGridColumn95.Hidden = True
        UltraGridColumn95.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn95.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn95.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(128, 0)
        UltraGridColumn95.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn95.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance147.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.CellAppearance = Appearance147
        Appearance148.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn96.Header.Appearance = Appearance148
        UltraGridColumn96.Header.Caption = "Mã bưu cục"
        UltraGridColumn96.Header.VisiblePosition = 7
        UltraGridColumn96.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn96.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn96.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn96.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn96.RowLayoutColumnInfo.SpanY = 2
        Appearance149.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.CellAppearance = Appearance149
        Appearance150.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn97.Header.Appearance = Appearance150
        UltraGridColumn97.Header.Caption = "Ngày lập"
        UltraGridColumn97.Header.VisiblePosition = 6
        UltraGridColumn97.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn97.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn97.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn97.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn97.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn97.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn97.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn97.UseEditorMaskSettings = True
        Appearance151.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.Header.Appearance = Appearance151
        UltraGridColumn98.Header.Caption = "Giờ lập"
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridColumn98.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn98.MaskDataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn98.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiteralsWithPadding
        UltraGridColumn98.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn98.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn98.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(45, 0)
        UltraGridColumn98.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn98.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn98.UseEditorMaskSettings = True
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance152.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn99.CellAppearance = Appearance152
        Appearance153.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn99.Header.Appearance = Appearance153
        UltraGridColumn99.Header.Caption = "Đợt giao"
        UltraGridColumn99.Header.VisiblePosition = 9
        UltraGridColumn99.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn99.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn99.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn99.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance154.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn100.Header.Appearance = Appearance154
        UltraGridColumn100.Header.Caption = "Ngày giao"
        UltraGridColumn100.Header.VisiblePosition = 10
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance155.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn101.Header.Appearance = Appearance155
        UltraGridColumn101.Header.Caption = "Giờ giao"
        UltraGridColumn101.Header.VisiblePosition = 11
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance156.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn102.CellAppearance = Appearance156
        Appearance157.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn102.Header.Appearance = Appearance157
        UltraGridColumn102.Header.Caption = "Chuyến thư"
        UltraGridColumn102.Header.VisiblePosition = 14
        UltraGridColumn102.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn102.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn102.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn102.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance158.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn103.Header.Appearance = Appearance158
        UltraGridColumn103.Header.Caption = "Id người dùng"
        UltraGridColumn103.Header.VisiblePosition = 12
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance159.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn104.Header.Appearance = Appearance159
        UltraGridColumn104.Header.Caption = "Ngày hệ thống"
        UltraGridColumn104.Header.VisiblePosition = 13
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance160.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn105.Header.Appearance = Appearance160
        UltraGridColumn105.Header.Caption = "Giờ hệ thống"
        UltraGridColumn105.Header.VisiblePosition = 15
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance161.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn106.Header.Appearance = Appearance161
        UltraGridColumn106.Header.Caption = "Đã in"
        UltraGridColumn106.Header.VisiblePosition = 16
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance162.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn107.Header.Appearance = Appearance162
        UltraGridColumn107.Header.Caption = "Chốt số liệu"
        UltraGridColumn107.Header.VisiblePosition = 17
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance163.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn108.Header.Appearance = Appearance163
        UltraGridColumn108.Header.Caption = "Truyền khai thác"
        UltraGridColumn108.Header.VisiblePosition = 18
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance164.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn109.Header.Appearance = Appearance164
        UltraGridColumn109.Header.VisiblePosition = 22
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance165.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn110.Header.Appearance = Appearance165
        UltraGridColumn110.Header.VisiblePosition = 19
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance166.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn111.Header.Appearance = Appearance166
        UltraGridColumn111.Header.VisiblePosition = 20
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance167.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn112.Header.Appearance = Appearance167
        UltraGridColumn112.Header.VisiblePosition = 21
        UltraGridColumn112.Hidden = True
        Appearance168.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn113.CellAppearance = Appearance168
        Appearance169.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn113.Header.Appearance = Appearance169
        UltraGridColumn113.Header.Caption = "Tổng BP"
        UltraGridColumn113.Header.VisiblePosition = 24
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance170.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn114.CellAppearance = Appearance170
        Appearance171.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn114.Header.Appearance = Appearance171
        UltraGridColumn114.Header.Caption = "Khối lượng"
        UltraGridColumn114.Header.VisiblePosition = 23
        UltraGridColumn114.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn114.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn114.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn114.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn115.Header.VisiblePosition = 25
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.Caption = "Tổng Túi"
        UltraGridColumn116.Header.VisiblePosition = 26
        UltraGridColumn117.Header.Caption = "Tổng KL"
        UltraGridColumn117.Header.VisiblePosition = 27
        Appearance172.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn118.Header.Appearance = Appearance172
        UltraGridColumn118.Header.Caption = "Chuyển tiếp"
        UltraGridColumn118.Header.VisiblePosition = 28
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118})
        UltraGridBand4.Header.Caption = "Danh sách E1 trong bản kê E2"
        Appearance173.ImageVAlign = Infragistics.Win.VAlign.Bottom
        UltraGridBand4.Override.RowSelectorAppearance = Appearance173
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgBC37_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgBC37_Di.DisplayLayout.InterBandSpacing = 10
        Me.dgBC37_Di.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.dgBC37_Di.DisplayLayout.Override.BorderStyleSummaryFooter = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance174.BackColor = System.Drawing.Color.Transparent
        Me.dgBC37_Di.DisplayLayout.Override.CardAreaAppearance = Appearance174
        Me.dgBC37_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance175.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance175.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance175.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance175.ForeColor = System.Drawing.Color.Black
        Appearance175.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance175.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgBC37_Di.DisplayLayout.Override.HeaderAppearance = Appearance175
        Me.dgBC37_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Appearance176.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Di.DisplayLayout.Override.RowAppearance = Appearance176
        Appearance177.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance177.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance177.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.dgBC37_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance177
        Me.dgBC37_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgBC37_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance178.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance178.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance178.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance178.ForeColor = System.Drawing.Color.Black
        Me.dgBC37_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance178
        Me.dgBC37_Di.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Di.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.Single
        Me.dgBC37_Di.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.ExtendedAutoDrag
        Me.dgBC37_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgBC37_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgBC37_Di.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBC37_Di.Location = New System.Drawing.Point(0, 0)
        Me.dgBC37_Di.Name = "dgBC37_Di"
        Me.dgBC37_Di.Size = New System.Drawing.Size(608, 240)
        Me.dgBC37_Di.TabIndex = 19
        '
        'TabBC37
        '
        Me.TabBC37.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabBC37.Controls.Add(Me.UltraTabPageControl1)
        Me.TabBC37.Controls.Add(Me.UltraTabPageControl2)
        Me.TabBC37.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabBC37.Location = New System.Drawing.Point(0, -3)
        Me.TabBC37.Name = "TabBC37"
        Me.TabBC37.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabBC37.Size = New System.Drawing.Size(792, 568)
        Me.TabBC37.TabIndex = 0
        UltraTab1.Key = "0"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "BC37 xác nhận đến"
        UltraTab2.Key = "1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "BC37 xác nhận đi"
        Me.TabBC37.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.TabBC37.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(788, 545)
        '
        'FrmQuan_Ly_BC37_Den_Di
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 565)
        Me.Controls.Add(Me.TabBC37)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmQuan_Ly_BC37_Den_Di"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý BC37"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.dgTui_Goi_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBC37_Den, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.dgTui_Goi_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBC37_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabBC37, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBC37.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDuong_Thu_Di_Chi_Tiet As New Duong_Thu_Di_Chi_Tiet
    Dim myQLTGND_BC37_DI As New QLTGND_BC37_DI(GConnectionString)
    Dim myQLTGND_BC37_DI_Chi_Tiet As New QLTGND_BC37_DI_Chi_Tiet
    Dim myQLTGND_BC37_DEN As New QLTGND_BC37_DEN(GConnectionString)
    Dim myQLTGND_BC37_DEN_Chi_Tiet As New QLTGND_BC37_DEN_Chi_Tiet
    Dim myQLTGND_POSTBAG_DI As New QLTGND_POSTBAG_DI(GConnectionString)
    Dim myQLTGND_POSTBAG_DI_Chi_Tiet As New QLTGND_POSTBAG_DI_Chi_Tiet
    Dim myQLTGND_POSTBAG_DEN As New QLTGND_POSTBAG_DEN(GConnectionString)
    Dim myQLTGND_POSTBAG_DEN_Chi_Tiet As New QLTGND_POSTBAG_DEN_Chi_Tiet
    Dim myQLTGND_POSTBAG As New QLTGND_POSTBAG(GConnectionString)
    Dim myQLTGND_POSTBAG_Chi_Tiet As New QLTGND_POSTBAG_Chi_Tiet
    Public myId_Chuyen_Thu As String
    Public myId_BC37 As String
    Private Sub Bind_BC37_Di()
        dgBC37_Di.DataSource = myQLTGND_BC37_DI.QLTGND_BC37_DI_Danh_Sach(GBuu_Cuc_Khai_Thac)
        dgBC37_Di.DataBind()
    End Sub
    Private Sub Bind_BC37_Den()
        dgBC37_Den.DataSource = myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Danh_Sach(GBuu_Cuc_Khai_Thac)
        dgBC37_Den.DataBind()
    End Sub
    Private Sub TabBC37_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles TabBC37.SelectedTabChanged
        Dim i As Integer
        If e.Tab.Index = 0 Then
            Bind_BC37_Den()
        End If
        If e.Tab.Index = 1 Then
            Bind_BC37_Di()
        End If
    End Sub
    Private Sub dgBC37_Di_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBC37_Di.AfterCellActivate
        Dim Id_BC37 As String = dgBC37_Di.Rows(dgBC37_Di.ActiveRow.Index).Cells("BC37_ID").Text
        dgTui_Goi_Di.DataSource = myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Danh_Sach_Theo_BC37_ID(Id_BC37, GBuu_Cuc_Khai_Thac)
        dgTui_Goi_Di.DataBind()
    End Sub
    Private Sub dgBC37_Den_AfterCellActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgBC37_Den.AfterCellActivate
        Dim Id_BC37 As String = dgBC37_Den.Rows(dgBC37_Den.ActiveRow.Index).Cells("BC37_ID").Text
        dgTui_Goi_Den.DataSource = myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Danh_Sach_Theo_BC37_ID(Id_BC37, GBuu_Cuc_Khai_Thac)
        dgTui_Goi_Den.DataBind()
    End Sub
    Private Sub dgBC37_Den_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgBC37_Den.KeyDown, dgBC37_Di.KeyDown, dgTui_Goi_Den.KeyDown, dgTui_Goi_Di.KeyDown
        If e.KeyValue < Keys.Space And e.KeyValue <> Keys.Enter And e.KeyValue <> Keys.Escape Then Exit Sub
        myGridKeyDown = sender
        If Not myCell Is Nothing Then
            e.Handled = True
            myGridKeyDown.ActiveCell = myCell
            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
            myCell = Nothing
        End If
        Select Case e.KeyValue
            Case Keys.Right
                myCell = Nothing
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditModeAndDropdown, False, False)
            Case Keys.Enter
                myGridKeyDown.PerformAction(ExitEditMode, False, False)
                myGridKeyDown.PerformAction(NextCellByTab, False, False)
                e.Handled = True
                myGridKeyDown.PerformAction(EnterEditMode, False, False)
            Case Keys.F8
                Select Case myGridKeyDown.Name
                    Case dgTui_Goi_Den.Name
                        If dgTui_Goi_Den.Rows(dgTui_Goi_Den.ActiveRow.Index).Cells("Id_E2").Text <> "" Then
                            '' Có xoá được hay không
                        
                            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                myQLTGND_POSTBAG_DEN.QLTGND_POSTBAG_DEN_Xoa(dgTui_Goi_Den.Rows(dgTui_Goi_Den.ActiveRow.Index).Cells("Id_E2").Text)
                                dgTui_Goi_Den.ActiveRow.Delete(False)
                                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Case dgTui_Goi_Di.Name
                        If dgTui_Goi_Di.Rows(dgTui_Goi_Di.ActiveRow.Index).Cells("Id_E2").Text <> "" Then

                            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                myQLTGND_POSTBAG_DI.QLTGND_POSTBAG_DI_Xoa(dgTui_Goi_Di.Rows(dgTui_Goi_Di.ActiveRow.Index).Cells("Id_E2").Text)
                                dgTui_Goi_Di.ActiveRow.Delete(False)
                                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Case dgBC37_Den.Name
                        If dgBC37_Den.Rows(dgBC37_Den.ActiveRow.Index).Cells("BC37_ID").Text <> "" Then
                            ' Có xoá được hay không
                            Dim Chk As Boolean
                            Chk = myQLTGND_BC37_DEN.BC_37_Den_Kiem_Tra_Tui(dgBC37_Den.Rows(dgBC37_Den.ActiveRow.Index).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
                            If Chk = True Then
                                CMessageBox.Show("Bạn không thể xoá được mã này, kiểm tra lại túi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                myQLTGND_BC37_DEN.QLTGND_BC37_DEN_Xoa(dgBC37_Den.Rows(dgBC37_Den.ActiveRow.Index).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
                                dgBC37_Den.ActiveRow.Delete(False)
                                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Case dgBC37_Di.Name
                        If dgBC37_Di.Rows(dgBC37_Di.ActiveRow.Index).Cells("BC37_ID").Text <> "" Then
                            ' Có xoá được hay không
                            Dim Chk As Boolean
                            Chk = myQLTGND_BC37_DI.BC_37_Di_Kiem_Tra_Tui(dgBC37_Di.Rows(dgBC37_Di.ActiveRow.Index).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
                            If Chk = True Then
                                CMessageBox.Show("Bạn không thể xoá được mã này, kiểm tra lại túi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            If MessageBox.Show("Bạn có thực sự muốn xóa mã này không ???", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
                                myQLTGND_BC37_DI.QLTGND_BC37_DI_Xoa(dgBC37_Di.Rows(dgBC37_Di.ActiveRow.Index).Cells("BC37_ID").Text, GBuu_Cuc_Khai_Thac)
                                dgBC37_Di.ActiveRow.Delete(False)
                                CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                End Select
        End Select


    End Sub
End Class

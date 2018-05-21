Imports System
Imports ADODB
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS

Public Class frmBaoCaoHaiQuan
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
    Friend WithEvents BtnPreview As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents BtnExit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents OptTheo_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbDuongThuNoiTinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents optNoiThanh As System.Windows.Forms.RadioButton
    Friend WithEvents optNgoaiThanh As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_DuongThuNoiTinh As System.Windows.Forms.GroupBox
    Friend WithEvents TabHaiQuan As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnLayDuLieuTrenOracle As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cbDen_Ngay_Lay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cbTu_Ngay_Lay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDongBoDuongThu As Infragistics.Win.Misc.UltraButton
    Friend WithEvents prgRead As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents txtThongTin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents optNoiNgoaiThanh As System.Windows.Forms.RadioButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbBuuCuc_NoiTinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents sFileDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkChuyen_Hoan As System.Windows.Forms.CheckBox
    Friend WithEvents btnExport_Excel As System.Windows.Forms.Button
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnDong As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnKhoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnKetXuat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThongTin As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents optBuuTa As System.Windows.Forms.RadioButton
    Friend WithEvents optCacTinh As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grbTienTrinh As System.Windows.Forms.GroupBox
    Friend WithEvents PrbTienTrinh As Infragistics.Win.UltraWinProgressBar.UltraProgressBar
    Friend WithEvents dgMa_Tinh_E1_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents GrbDon_Vi As System.Windows.Forms.GroupBox
    Friend WithEvents GrbNgay_Dong As System.Windows.Forms.GroupBox
    Friend WithEvents dgMa_Tinh_E1_No As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chkE1_Di As System.Windows.Forms.CheckBox
    Friend WithEvents txtNhan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTruyen As System.Windows.Forms.TextBox
    Friend WithEvents lblTruyen As System.Windows.Forms.Label
    Friend WithEvents chkE1_No As System.Windows.Forms.CheckBox
    Friend WithEvents btnMo_Khoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OptBuu_Ta_Noi_Bo As System.Windows.Forms.RadioButton
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDuong_Thu_Chuyen_Hoan As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnThong_Tin_Chuyen_Hoan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat_Chuyen_Hoan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtpNgay_Chuyen_Hoan As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dgE1_Nhap_Chuyen_Hoan As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgE1_Di_Chuyen_Hoan As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgE1_Thu_No_Chuyen_Hoan As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnNhap_Chuyen_Hoan As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents chkDuong_Thu_Cap_2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnXoa As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Ban_Ke_Doi_Soat_HQ As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBaoCaoHaiQuan))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Vi")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Le_Phi")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien_No")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Don_Vi")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Le_Phi")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien_No")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Di_Noi_Thanh", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh_Theo_Duong_Thu", -1)
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ma_Tinh")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ten_Tinh")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Khu_Vuc")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Thoa_Thuan")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Duong_Thu_Chuyen_Hoan", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Thu_No_Chuyen_Hoan", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Co_Thu")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Duong_Thu")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Nhap_Chuyen_Hoan", -1)
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Duong_Thu")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Di_Chuyen_Hoan", -1)
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Duong_Thu")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("BuuCuc_NoiTinh", -1)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.btnXoa = New Infragistics.Win.Misc.UltraButton
        Me.grbTienTrinh = New System.Windows.Forms.GroupBox
        Me.PrbTienTrinh = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnMo_Khoa = New Infragistics.Win.Misc.UltraButton
        Me.chkE1_No = New System.Windows.Forms.CheckBox
        Me.txtNhan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTruyen = New System.Windows.Forms.TextBox
        Me.lblTruyen = New System.Windows.Forms.Label
        Me.chkE1_Di = New System.Windows.Forms.CheckBox
        Me.dgMa_Tinh_E1_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.GrbDon_Vi = New System.Windows.Forms.GroupBox
        Me.optBuuTa = New System.Windows.Forms.RadioButton
        Me.optCacTinh = New System.Windows.Forms.RadioButton
        Me.GrbNgay_Dong = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnThongTin = New Infragistics.Win.Misc.UltraButton
        Me.btnDong = New Infragistics.Win.Misc.UltraButton
        Me.btnKhoa = New Infragistics.Win.Misc.UltraButton
        Me.btnKetXuat = New Infragistics.Win.Misc.UltraButton
        Me.dgMa_Tinh_E1_No = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.chkDuong_Thu_Cap_2 = New System.Windows.Forms.CheckBox
        Me.GroupBox_DuongThuNoiTinh = New System.Windows.Forms.GroupBox
        Me.optNoiNgoaiThanh = New System.Windows.Forms.RadioButton
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.optNgoaiThanh = New System.Windows.Forms.RadioButton
        Me.cbDuongThuNoiTinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.optNoiThanh = New System.Windows.Forms.RadioButton
        Me.btnFile = New System.Windows.Forms.Button
        Me.BtnExit = New Infragistics.Win.Misc.UltraButton
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OptBuu_Ta_Noi_Bo = New System.Windows.Forms.RadioButton
        Me.chkChuyen_Hoan = New System.Windows.Forms.CheckBox
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.OptTat_Ca = New System.Windows.Forms.RadioButton
        Me.OptTheo_Tinh = New System.Windows.Forms.RadioButton
        Me.BtnPreview = New Infragistics.Win.Misc.UltraButton
        Me.btnExport_Excel = New System.Windows.Forms.Button
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpNgay_Chuyen_Hoan = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbDuong_Thu_Chuyen_Hoan = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnThong_Tin_Chuyen_Hoan = New Infragistics.Win.Misc.UltraButton
        Me.btnNhap_Chuyen_Hoan = New Infragistics.Win.Misc.UltraButton
        Me.dgE1_Thu_No_Chuyen_Hoan = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgE1_Nhap_Chuyen_Hoan = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnThoat_Chuyen_Hoan = New Infragistics.Win.Misc.UltraButton
        Me.dgE1_Di_Chuyen_Hoan = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.cbBuuCuc_NoiTinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbDen_Ngay_Lay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.cbTu_Ngay_Lay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.txtThongTin = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.prgRead = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        Me.btnDongBoDuongThu = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.btnLayDuLieuTrenOracle = New Infragistics.Win.Misc.UltraButton
        Me.TabHaiQuan = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.sFileDlg = New System.Windows.Forms.SaveFileDialog
        Me.btn_Ban_Ke_Doi_Soat_HQ = New System.Windows.Forms.Button
        Me.UltraTabPageControl3.SuspendLayout()
        Me.grbTienTrinh.SuspendLayout()
        CType(Me.dgMa_Tinh_E1_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbDon_Vi.SuspendLayout()
        Me.GrbNgay_Dong.SuspendLayout()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMa_Tinh_E1_No, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.GroupBox_DuongThuNoiTinh.SuspendLayout()
        CType(Me.cbDuongThuNoiTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.dtpNgay_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDuong_Thu_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Thu_No_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Nhap_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Di_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cbBuuCuc_NoiTinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cbDen_Ngay_Lay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTu_Ngay_Lay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabHaiQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHaiQuan.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.btnXoa)
        Me.UltraTabPageControl3.Controls.Add(Me.grbTienTrinh)
        Me.UltraTabPageControl3.Controls.Add(Me.btnMo_Khoa)
        Me.UltraTabPageControl3.Controls.Add(Me.chkE1_No)
        Me.UltraTabPageControl3.Controls.Add(Me.txtNhan)
        Me.UltraTabPageControl3.Controls.Add(Me.Label4)
        Me.UltraTabPageControl3.Controls.Add(Me.txtTruyen)
        Me.UltraTabPageControl3.Controls.Add(Me.lblTruyen)
        Me.UltraTabPageControl3.Controls.Add(Me.chkE1_Di)
        Me.UltraTabPageControl3.Controls.Add(Me.dgMa_Tinh_E1_Di)
        Me.UltraTabPageControl3.Controls.Add(Me.GrbDon_Vi)
        Me.UltraTabPageControl3.Controls.Add(Me.GrbNgay_Dong)
        Me.UltraTabPageControl3.Controls.Add(Me.btnThongTin)
        Me.UltraTabPageControl3.Controls.Add(Me.btnDong)
        Me.UltraTabPageControl3.Controls.Add(Me.btnKhoa)
        Me.UltraTabPageControl3.Controls.Add(Me.btnKetXuat)
        Me.UltraTabPageControl3.Controls.Add(Me.dgMa_Tinh_E1_No)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(772, 510)
        '
        'btnXoa
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnXoa.Appearance = Appearance1
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnXoa.Location = New System.Drawing.Point(560, 470)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(104, 34)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "&Xoá thông tin kế toán"
        '
        'grbTienTrinh
        '
        Me.grbTienTrinh.Controls.Add(Me.PrbTienTrinh)
        Me.grbTienTrinh.Location = New System.Drawing.Point(120, 264)
        Me.grbTienTrinh.Name = "grbTienTrinh"
        Me.grbTienTrinh.Size = New System.Drawing.Size(528, 72)
        Me.grbTienTrinh.TabIndex = 15
        Me.grbTienTrinh.TabStop = False
        Me.grbTienTrinh.Text = "Tiến trình"
        '
        'PrbTienTrinh
        '
        Me.PrbTienTrinh.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.PrbTienTrinh.Location = New System.Drawing.Point(8, 24)
        Me.PrbTienTrinh.Maximum = 10000
        Me.PrbTienTrinh.Name = "PrbTienTrinh"
        Me.PrbTienTrinh.Size = New System.Drawing.Size(512, 32)
        Me.PrbTienTrinh.Step = 1
        Me.PrbTienTrinh.TabIndex = 0
        Me.PrbTienTrinh.Text = "[Formatted]"
        '
        'btnMo_Khoa
        '
        Appearance2.Image = CType(resources.GetObject("Appearance2.Image"), Object)
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnMo_Khoa.Appearance = Appearance2
        Me.btnMo_Khoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMo_Khoa.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnMo_Khoa.Location = New System.Drawing.Point(328, 344)
        Me.btnMo_Khoa.Name = "btnMo_Khoa"
        Me.btnMo_Khoa.Size = New System.Drawing.Size(64, 80)
        Me.btnMo_Khoa.TabIndex = 5
        Me.btnMo_Khoa.Text = "&Mở    Khoá SL"
        '
        'chkE1_No
        '
        Me.chkE1_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkE1_No.Location = New System.Drawing.Point(680, 472)
        Me.chkE1_No.Name = "chkE1_No"
        Me.chkE1_No.Size = New System.Drawing.Size(88, 24)
        Me.chkE1_No.TabIndex = 8
        Me.chkE1_No.Text = "Chọn tất cả"
        '
        'txtNhan
        '
        Me.txtNhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNhan.Location = New System.Drawing.Point(472, 474)
        Me.txtNhan.Name = "txtNhan"
        Me.txtNhan.Size = New System.Drawing.Size(72, 20)
        Me.txtNhan.TabIndex = 14
        Me.txtNhan.Text = "0"
        Me.txtNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Số bản ghi : "
        '
        'txtTruyen
        '
        Me.txtTruyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTruyen.Location = New System.Drawing.Point(72, 474)
        Me.txtTruyen.Name = "txtTruyen"
        Me.txtTruyen.Size = New System.Drawing.Size(72, 20)
        Me.txtTruyen.TabIndex = 12
        Me.txtTruyen.Text = "0"
        Me.txtTruyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTruyen
        '
        Me.lblTruyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTruyen.Location = New System.Drawing.Point(0, 476)
        Me.lblTruyen.Name = "lblTruyen"
        Me.lblTruyen.Size = New System.Drawing.Size(72, 16)
        Me.lblTruyen.TabIndex = 11
        Me.lblTruyen.Text = "Số bản ghi : "
        '
        'chkE1_Di
        '
        Me.chkE1_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkE1_Di.Location = New System.Drawing.Point(224, 472)
        Me.chkE1_Di.Name = "chkE1_Di"
        Me.chkE1_Di.Size = New System.Drawing.Size(88, 24)
        Me.chkE1_Di.TabIndex = 7
        Me.chkE1_Di.Text = "Chọn tất cả"
        '
        'dgMa_Tinh_E1_Di
        '
        Me.dgMa_Tinh_E1_Di.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMa_Tinh_E1_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.Header.Caption = "Chọn"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(37, 0)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Mã Tỉnh"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaskInput = ""
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Tên Tỉnh"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(116, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Đơn vị"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn5.CellAppearance = Appearance4
        UltraGridColumn5.Header.Caption = "Số lượng"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(53, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        Appearance5.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn6.CellAppearance = Appearance5
        Appearance6.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn6.CellButtonAppearance = Appearance6
        UltraGridColumn6.Format = "###,##0.###"
        UltraGridColumn6.Header.Caption = "Khối lượng"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn7.CellAppearance = Appearance7
        UltraGridColumn7.Format = "###,###,###"
        UltraGridColumn7.Header.Caption = "Tổng thuế"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn8.CellAppearance = Appearance8
        UltraGridColumn8.Format = "###,###,###"
        UltraGridColumn8.Header.Caption = "Lệ phí"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn9.CellAppearance = Appearance9
        UltraGridColumn9.Format = "###,###,###"
        UltraGridColumn9.Header.Caption = "Tổng tiền"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(84, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgMa_Tinh_E1_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgMa_Tinh_E1_Di.DisplayLayout.InterBandSpacing = 10
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance12.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance13.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.dgMa_Tinh_E1_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance14
        Me.dgMa_Tinh_E1_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Tinh_E1_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMa_Tinh_E1_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMa_Tinh_E1_Di.Location = New System.Drawing.Point(0, 64)
        Me.dgMa_Tinh_E1_Di.Name = "dgMa_Tinh_E1_Di"
        Me.dgMa_Tinh_E1_Di.Size = New System.Drawing.Size(320, 400)
        Me.dgMa_Tinh_E1_Di.TabIndex = 9
        Me.dgMa_Tinh_E1_Di.Text = "Thông tin Khai thác Quốc tế"
        '
        'GrbDon_Vi
        '
        Me.GrbDon_Vi.Controls.Add(Me.optBuuTa)
        Me.GrbDon_Vi.Controls.Add(Me.optCacTinh)
        Me.GrbDon_Vi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbDon_Vi.Location = New System.Drawing.Point(360, 8)
        Me.GrbDon_Vi.Name = "GrbDon_Vi"
        Me.GrbDon_Vi.Size = New System.Drawing.Size(200, 48)
        Me.GrbDon_Vi.TabIndex = 1
        Me.GrbDon_Vi.TabStop = False
        Me.GrbDon_Vi.Text = "Thông tin đơn vị"
        '
        'optBuuTa
        '
        Me.optBuuTa.Location = New System.Drawing.Point(8, 18)
        Me.optBuuTa.Name = "optBuuTa"
        Me.optBuuTa.Size = New System.Drawing.Size(96, 24)
        Me.optBuuTa.TabIndex = 0
        Me.optBuuTa.Text = "Bưu tá nội bộ"
        '
        'optCacTinh
        '
        Me.optCacTinh.Location = New System.Drawing.Point(120, 18)
        Me.optCacTinh.Name = "optCacTinh"
        Me.optCacTinh.Size = New System.Drawing.Size(72, 24)
        Me.optCacTinh.TabIndex = 1
        Me.optCacTinh.Text = "Các tỉnh"
        '
        'GrbNgay_Dong
        '
        Me.GrbNgay_Dong.Controls.Add(Me.Label2)
        Me.GrbNgay_Dong.Controls.Add(Me.Label1)
        Me.GrbNgay_Dong.Controls.Add(Me.dtpDenNgay)
        Me.GrbNgay_Dong.Controls.Add(Me.dtpTuNgay)
        Me.GrbNgay_Dong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbNgay_Dong.Location = New System.Drawing.Point(0, 8)
        Me.GrbNgay_Dong.Name = "GrbNgay_Dong"
        Me.GrbNgay_Dong.Size = New System.Drawing.Size(352, 48)
        Me.GrbNgay_Dong.TabIndex = 0
        Me.GrbNgay_Dong.TabStop = False
        Me.GrbNgay_Dong.Text = "Thông tin Ngày đóng"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Từ ngày"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Đến ngày"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(245, 19)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpDenNgay.TabIndex = 3
        Me.dtpDenNgay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(64, 19)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpTuNgay.TabIndex = 1
        Me.dtpTuNgay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'btnThongTin
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.btnThongTin.Appearance = Appearance15
        Me.btnThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThongTin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThongTin.Location = New System.Drawing.Point(568, 14)
        Me.btnThongTin.Name = "btnThongTin"
        Me.btnThongTin.Size = New System.Drawing.Size(104, 41)
        Me.btnThongTin.TabIndex = 2
        Me.btnThongTin.Text = "&Lấy thông tin"
        '
        'btnDong
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.btnDong.Appearance = Appearance16
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDong.Location = New System.Drawing.Point(680, 14)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(88, 40)
        Me.btnDong.TabIndex = 6
        Me.btnDong.Text = "&Thoát"
        '
        'btnKhoa
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Appearance17.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance17.ImageVAlign = Infragistics.Win.VAlign.Top
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        Me.btnKhoa.Appearance = Appearance17
        Me.btnKhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhoa.ImageSize = New System.Drawing.Size(17, 17)
        Me.btnKhoa.Location = New System.Drawing.Point(328, 224)
        Me.btnKhoa.Name = "btnKhoa"
        Me.btnKhoa.Size = New System.Drawing.Size(64, 80)
        Me.btnKhoa.TabIndex = 4
        Me.btnKhoa.Text = "&Khoá SL"
        '
        'btnKetXuat
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Appearance18.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance18.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnKetXuat.Appearance = Appearance18
        Me.btnKetXuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKetXuat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnKetXuat.Location = New System.Drawing.Point(328, 104)
        Me.btnKetXuat.Name = "btnKetXuat"
        Me.btnKetXuat.Size = New System.Drawing.Size(64, 80)
        Me.btnKetXuat.TabIndex = 3
        Me.btnKetXuat.Text = "Kết &xuất "
        '
        'dgMa_Tinh_E1_No
        '
        Me.dgMa_Tinh_E1_No.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMa_Tinh_E1_No.DisplayLayout.AddNewBox.Prompt = " "
        Appearance19.BackColor = System.Drawing.Color.White
        Appearance19.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMa_Tinh_E1_No.DisplayLayout.Appearance = Appearance19
        UltraGridColumn10.Header.Caption = "Chọn"
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(38, 0)
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Mã Tỉnh"
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.MaskInput = ""
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Tên Tỉnh"
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(116, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Đơn vị"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellAppearance = Appearance20
        Appearance21.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn14.CellButtonAppearance = Appearance21
        UltraGridColumn14.Header.Caption = "Số lượng"
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        Appearance22.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellAppearance = Appearance22
        Appearance23.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn15.CellButtonAppearance = Appearance23
        UltraGridColumn15.Format = "###,##0.###"
        UltraGridColumn15.Header.Caption = "Khối lượng"
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        Appearance24.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn16.CellAppearance = Appearance24
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn16.CellButtonAppearance = Appearance25
        UltraGridColumn16.Format = "###,###,###"
        UltraGridColumn16.Header.Caption = "Tổng thuế"
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn17.CellAppearance = Appearance26
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn17.CellButtonAppearance = Appearance27
        UltraGridColumn17.Format = "###,###,###"
        UltraGridColumn17.Header.Caption = "Lệ phí"
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn18.CellAppearance = Appearance28
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn18.CellButtonAppearance = Appearance29
        UltraGridColumn18.Format = "###,###,###"
        UltraGridColumn18.Header.Caption = "Tổng tiền"
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(81, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Khoá SL"
        UltraGridColumn19.Header.VisiblePosition = 9
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgMa_Tinh_E1_No.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgMa_Tinh_E1_No.DisplayLayout.InterBandSpacing = 10
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.CardAreaAppearance = Appearance30
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance31.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance31.ForeColor = System.Drawing.Color.Black
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance31.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance32.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.RowAppearance = Appearance32
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance33.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.RowSelectorAppearance = Appearance33
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance34.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.dgMa_Tinh_E1_No.DisplayLayout.Override.SelectedRowAppearance = Appearance34
        Me.dgMa_Tinh_E1_No.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_Tinh_E1_No.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMa_Tinh_E1_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMa_Tinh_E1_No.Location = New System.Drawing.Point(400, 64)
        Me.dgMa_Tinh_E1_No.Name = "dgMa_Tinh_E1_No"
        Me.dgMa_Tinh_E1_No.Size = New System.Drawing.Size(368, 400)
        Me.dgMa_Tinh_E1_No.TabIndex = 10
        Me.dgMa_Tinh_E1_No.Text = "Thông tin Kế toán"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.btn_Ban_Ke_Doi_Soat_HQ)
        Me.UltraTabPageControl1.Controls.Add(Me.chkDuong_Thu_Cap_2)
        Me.UltraTabPageControl1.Controls.Add(Me.GroupBox_DuongThuNoiTinh)
        Me.UltraTabPageControl1.Controls.Add(Me.BtnExit)
        Me.UltraTabPageControl1.Controls.Add(Me.BtnPrint)
        Me.UltraTabPageControl1.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl1.Controls.Add(Me.BtnPreview)
        Me.UltraTabPageControl1.Controls.Add(Me.btnExport_Excel)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(772, 510)
        '
        'chkDuong_Thu_Cap_2
        '
        Me.chkDuong_Thu_Cap_2.Location = New System.Drawing.Point(152, 240)
        Me.chkDuong_Thu_Cap_2.Name = "chkDuong_Thu_Cap_2"
        Me.chkDuong_Thu_Cap_2.Size = New System.Drawing.Size(152, 24)
        Me.chkDuong_Thu_Cap_2.TabIndex = 74
        Me.chkDuong_Thu_Cap_2.Text = "Đường thư cấp 2"
        '
        'GroupBox_DuongThuNoiTinh
        '
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.optNoiNgoaiThanh)
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.UltraLabel1)
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.optNgoaiThanh)
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.cbDuongThuNoiTinh)
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.optNoiThanh)
        Me.GroupBox_DuongThuNoiTinh.Controls.Add(Me.btnFile)
        Me.GroupBox_DuongThuNoiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_DuongThuNoiTinh.Location = New System.Drawing.Point(152, 264)
        Me.GroupBox_DuongThuNoiTinh.Name = "GroupBox_DuongThuNoiTinh"
        Me.GroupBox_DuongThuNoiTinh.Size = New System.Drawing.Size(448, 136)
        Me.GroupBox_DuongThuNoiTinh.TabIndex = 71
        Me.GroupBox_DuongThuNoiTinh.TabStop = False
        '
        'optNoiNgoaiThanh
        '
        Me.optNoiNgoaiThanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNoiNgoaiThanh.Location = New System.Drawing.Point(24, 96)
        Me.optNoiNgoaiThanh.Name = "optNoiNgoaiThanh"
        Me.optNoiNgoaiThanh.TabIndex = 72
        Me.optNoiNgoaiThanh.Text = "Tất cả"
        Me.optNoiNgoaiThanh.Visible = False
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(32, 48)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel1.TabIndex = 71
        Me.UltraLabel1.Text = "Đường Thư"
        '
        'optNgoaiThanh
        '
        Me.optNgoaiThanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNgoaiThanh.Location = New System.Drawing.Point(328, 96)
        Me.optNgoaiThanh.Name = "optNgoaiThanh"
        Me.optNgoaiThanh.TabIndex = 70
        Me.optNgoaiThanh.Text = "Ngoại Thành"
        Me.optNgoaiThanh.Visible = False
        '
        'cbDuongThuNoiTinh
        '
        Me.cbDuongThuNoiTinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Đường Thư"
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Tên Đường Thư"
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(253, 0)
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        UltraGridBand3.UseRowLayout = True
        Me.cbDuongThuNoiTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance35.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance35.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuongThuNoiTinh.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.cbDuongThuNoiTinh.DisplayMember = "Ten_Duong_Thu"
        Me.cbDuongThuNoiTinh.Location = New System.Drawing.Point(120, 48)
        Me.cbDuongThuNoiTinh.Name = "cbDuongThuNoiTinh"
        Me.cbDuongThuNoiTinh.Size = New System.Drawing.Size(288, 24)
        Me.cbDuongThuNoiTinh.TabIndex = 69
        Me.cbDuongThuNoiTinh.ValueMember = "Id_Duong_Thu"
        '
        'optNoiThanh
        '
        Me.optNoiThanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optNoiThanh.Location = New System.Drawing.Point(176, 96)
        Me.optNoiThanh.Name = "optNoiThanh"
        Me.optNoiThanh.TabIndex = 67
        Me.optNoiThanh.Text = "Nội Thành"
        Me.optNoiThanh.Visible = False
        '
        'btnFile
        '
        Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Image = CType(resources.GetObject("btnFile.Image"), System.Drawing.Image)
        Me.btnFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFile.Location = New System.Drawing.Point(352, 24)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(88, 32)
        Me.btnFile.TabIndex = 72
        Me.btnFile.Visible = False
        '
        'BtnExit
        '
        Appearance36.FontData.BoldAsString = "True"
        Appearance36.Image = CType(resources.GetObject("Appearance36.Image"), Object)
        Me.BtnExit.Appearance = Appearance36
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(560, 424)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 32)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        '
        'BtnPrint
        '
        Appearance37.FontData.BoldAsString = "True"
        Appearance37.Image = CType(resources.GetObject("Appearance37.Image"), Object)
        Appearance37.TextHAlign = Infragistics.Win.HAlign.Center
        Me.BtnPrint.Appearance = Appearance37
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(336, 424)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(96, 32)
        Me.BtnPrint.TabIndex = 6
        Me.BtnPrint.Text = "Printer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptBuu_Ta_Noi_Bo)
        Me.GroupBox1.Controls.Add(Me.chkChuyen_Hoan)
        Me.GroupBox1.Controls.Add(Me.cbMa_Tinh)
        Me.GroupBox1.Controls.Add(Me.UltraLabel3)
        Me.GroupBox1.Controls.Add(Me.CbDen_Ngay)
        Me.GroupBox1.Controls.Add(Me.UltraLabel4)
        Me.GroupBox1.Controls.Add(Me.CbTu_Ngay)
        Me.GroupBox1.Controls.Add(Me.OptTat_Ca)
        Me.GroupBox1.Controls.Add(Me.OptTheo_Tinh)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(152, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 192)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập thông tin cần in thuế và lệ phí HQ"
        '
        'OptBuu_Ta_Noi_Bo
        '
        Me.OptBuu_Ta_Noi_Bo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBuu_Ta_Noi_Bo.Location = New System.Drawing.Point(32, 152)
        Me.OptBuu_Ta_Noi_Bo.Name = "OptBuu_Ta_Noi_Bo"
        Me.OptBuu_Ta_Noi_Bo.Size = New System.Drawing.Size(160, 24)
        Me.OptBuu_Ta_Noi_Bo.TabIndex = 68
        Me.OptBuu_Ta_Noi_Bo.Text = "Theo bưu tá nội bộ"
        '
        'chkChuyen_Hoan
        '
        Me.chkChuyen_Hoan.Location = New System.Drawing.Point(136, 80)
        Me.chkChuyen_Hoan.Name = "chkChuyen_Hoan"
        Me.chkChuyen_Hoan.Size = New System.Drawing.Size(160, 24)
        Me.chkChuyen_Hoan.TabIndex = 67
        Me.chkChuyen_Hoan.Text = "Báo cáo chuyển hoàn"
        '
        'cbMa_Tinh
        '
        Me.cbMa_Tinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbMa_Tinh.DataSource = Me.UltraDataSource4
        UltraGridColumn23.Header.Caption = "Mã tỉnh"
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn24.Header.Caption = "Tên tỉnh"
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn25.Header.Caption = "Khu vực"
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "Thoả thuận"
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn26.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        Me.cbMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance38.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.cbMa_Tinh.DisplayMember = "Ten_Tinh"
        Me.cbMa_Tinh.Location = New System.Drawing.Point(224, 120)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(176, 24)
        Me.cbMa_Tinh.TabIndex = 4
        Me.cbMa_Tinh.ValueMember = "Ma_Tinh"
        '
        'UltraDataSource4
        '
        UltraDataColumn1.DataType = GetType(System.Int16)
        UltraDataColumn3.DataType = GetType(System.Int16)
        UltraDataColumn4.DataType = GetType(System.Boolean)
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4})
        Me.UltraDataSource4.Band.Key = "Ma_Tinh_Theo_Duong_Thu"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(224, 36)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel3.TabIndex = 66
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(304, 32)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbDen_Ngay.TabIndex = 1
        Me.CbDen_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(32, 36)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel4.TabIndex = 65
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(104, 32)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(96, 24)
        Me.CbTu_Ngay.TabIndex = 0
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'OptTat_Ca
        '
        Me.OptTat_Ca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTat_Ca.Location = New System.Drawing.Point(32, 120)
        Me.OptTat_Ca.Name = "OptTat_Ca"
        Me.OptTat_Ca.Size = New System.Drawing.Size(88, 24)
        Me.OptTat_Ca.TabIndex = 2
        Me.OptTat_Ca.Text = "Tất cả"
        '
        'OptTheo_Tinh
        '
        Me.OptTheo_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptTheo_Tinh.Location = New System.Drawing.Point(144, 120)
        Me.OptTheo_Tinh.Name = "OptTheo_Tinh"
        Me.OptTheo_Tinh.Size = New System.Drawing.Size(80, 24)
        Me.OptTheo_Tinh.TabIndex = 3
        Me.OptTheo_Tinh.Text = "Theo tỉnh"
        '
        'BtnPreview
        '
        Appearance39.FontData.BoldAsString = "True"
        Appearance39.Image = CType(resources.GetObject("Appearance39.Image"), Object)
        Me.BtnPreview.Appearance = Appearance39
        Me.BtnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.Location = New System.Drawing.Point(224, 424)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(104, 32)
        Me.BtnPreview.TabIndex = 5
        Me.BtnPreview.Text = "Preview"
        '
        'btnExport_Excel
        '
        Me.btnExport_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport_Excel.Image = CType(resources.GetObject("btnExport_Excel.Image"), System.Drawing.Image)
        Me.btnExport_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport_Excel.Location = New System.Drawing.Point(104, 424)
        Me.btnExport_Excel.Name = "btnExport_Excel"
        Me.btnExport_Excel.Size = New System.Drawing.Size(112, 32)
        Me.btnExport_Excel.TabIndex = 73
        Me.btnExport_Excel.Text = "  Ghi ra Excel"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl4.Controls.Add(Me.btnNhap_Chuyen_Hoan)
        Me.UltraTabPageControl4.Controls.Add(Me.dgE1_Thu_No_Chuyen_Hoan)
        Me.UltraTabPageControl4.Controls.Add(Me.dgE1_Nhap_Chuyen_Hoan)
        Me.UltraTabPageControl4.Controls.Add(Me.btnThoat_Chuyen_Hoan)
        Me.UltraTabPageControl4.Controls.Add(Me.dgE1_Di_Chuyen_Hoan)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(772, 510)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.dtpNgay_Chuyen_Hoan)
        Me.UltraGroupBox1.Controls.Add(Me.Label5)
        Me.UltraGroupBox1.Controls.Add(Me.cbDuong_Thu_Chuyen_Hoan)
        Me.UltraGroupBox1.Controls.Add(Me.btnThong_Tin_Chuyen_Hoan)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(664, 48)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Ngày khai thác"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpNgay_Chuyen_Hoan
        '
        Me.dtpNgay_Chuyen_Hoan.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtpNgay_Chuyen_Hoan.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpNgay_Chuyen_Hoan.Location = New System.Drawing.Point(104, 16)
        Me.dtpNgay_Chuyen_Hoan.Name = "dtpNgay_Chuyen_Hoan"
        Me.dtpNgay_Chuyen_Hoan.Size = New System.Drawing.Size(112, 23)
        Me.dtpNgay_Chuyen_Hoan.TabIndex = 1
        Me.dtpNgay_Chuyen_Hoan.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(232, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Đường thư &Chuyển hoàn"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDuong_Thu_Chuyen_Hoan
        '
        Me.cbDuong_Thu_Chuyen_Hoan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Đường Thư"
        UltraGridColumn28.Header.VisiblePosition = 2
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "Tên Đường Thư"
        UltraGridColumn29.Header.VisiblePosition = 1
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(253, 0)
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        UltraGridBand5.UseRowLayout = True
        Me.cbDuong_Thu_Chuyen_Hoan.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance40.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance40.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbDuong_Thu_Chuyen_Hoan.DisplayLayout.Override.HeaderAppearance = Appearance40
        Me.cbDuong_Thu_Chuyen_Hoan.DisplayMember = "Ten_Duong_Thu"
        Me.cbDuong_Thu_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuong_Thu_Chuyen_Hoan.Location = New System.Drawing.Point(312, 16)
        Me.cbDuong_Thu_Chuyen_Hoan.Name = "cbDuong_Thu_Chuyen_Hoan"
        Me.cbDuong_Thu_Chuyen_Hoan.Size = New System.Drawing.Size(216, 23)
        Me.cbDuong_Thu_Chuyen_Hoan.TabIndex = 3
        Me.cbDuong_Thu_Chuyen_Hoan.ValueMember = "Id_Duong_Thu"
        '
        'btnThong_Tin_Chuyen_Hoan
        '
        Appearance41.Image = CType(resources.GetObject("Appearance41.Image"), Object)
        Me.btnThong_Tin_Chuyen_Hoan.Appearance = Appearance41
        Me.btnThong_Tin_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThong_Tin_Chuyen_Hoan.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThong_Tin_Chuyen_Hoan.Location = New System.Drawing.Point(544, 8)
        Me.btnThong_Tin_Chuyen_Hoan.Name = "btnThong_Tin_Chuyen_Hoan"
        Me.btnThong_Tin_Chuyen_Hoan.Size = New System.Drawing.Size(112, 32)
        Me.btnThong_Tin_Chuyen_Hoan.TabIndex = 4
        Me.btnThong_Tin_Chuyen_Hoan.Text = "&Lấy thông tin"
        '
        'btnNhap_Chuyen_Hoan
        '
        Appearance42.Image = CType(resources.GetObject("Appearance42.Image"), Object)
        Appearance42.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnNhap_Chuyen_Hoan.Appearance = Appearance42
        Me.btnNhap_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap_Chuyen_Hoan.ImageSize = New System.Drawing.Size(50, 25)
        Me.btnNhap_Chuyen_Hoan.Location = New System.Drawing.Point(352, 256)
        Me.btnNhap_Chuyen_Hoan.Name = "btnNhap_Chuyen_Hoan"
        Me.btnNhap_Chuyen_Hoan.Size = New System.Drawing.Size(416, 40)
        Me.btnNhap_Chuyen_Hoan.TabIndex = 4
        '
        'dgE1_Thu_No_Chuyen_Hoan
        '
        Me.dgE1_Thu_No_Chuyen_Hoan.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.AddNewBox.Prompt = " "
        Appearance43.BackColor = System.Drawing.Color.White
        Appearance43.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Appearance = Appearance43
        UltraGridColumn30.Header.Caption = "Thu nợ"
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(42, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Header.Caption = "Mã E1"
        UltraGridColumn32.Header.VisiblePosition = 3
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Format = "dd/MM/yyyy"
        UltraGridColumn33.Header.Caption = "Ngày đóng"
        UltraGridColumn33.Header.VisiblePosition = 4
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Format = "hh:mm"
        UltraGridColumn34.Header.Caption = "Giờ đóng"
        UltraGridColumn34.Header.VisiblePosition = 5
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.Caption = "Đường thư"
        UltraGridColumn35.Header.VisiblePosition = 6
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.Caption = "Mã Tỉnh"
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn36.MaskInput = ""
        UltraGridColumn36.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.Caption = "Số CT"
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(65, 0)
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.Caption = "Túi số"
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.Caption = "Khối lượng"
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Tổng tiền"
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        UltraGridBand6.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand6.UseRowLayout = True
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.ForeColor = System.Drawing.Color.Black
        Appearance45.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance45.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.HeaderAppearance = Appearance45
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance46.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.RowAppearance = Appearance46
        Appearance47.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance47.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.RowSelectorAppearance = Appearance47
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance48.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance48.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.Override.SelectedRowAppearance = Appearance48
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Thu_No_Chuyen_Hoan.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Thu_No_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Thu_No_Chuyen_Hoan.Location = New System.Drawing.Point(352, 304)
        Me.dgE1_Thu_No_Chuyen_Hoan.Name = "dgE1_Thu_No_Chuyen_Hoan"
        Me.dgE1_Thu_No_Chuyen_Hoan.Size = New System.Drawing.Size(416, 200)
        Me.dgE1_Thu_No_Chuyen_Hoan.TabIndex = 5
        Me.dgE1_Thu_No_Chuyen_Hoan.Text = "Thông tin trạng thái chuyển hoàn"
        '
        'dgE1_Nhap_Chuyen_Hoan
        '
        Me.dgE1_Nhap_Chuyen_Hoan.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.AddNewBox.Prompt = " "
        Appearance49.BackColor = System.Drawing.Color.White
        Appearance49.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Appearance = Appearance49
        UltraGridColumn41.Header.Caption = "Mã E1"
        UltraGridColumn41.Header.VisiblePosition = 0
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Format = "dd/MM/yyyy"
        UltraGridColumn42.Header.Caption = "Ngày đóng"
        UltraGridColumn42.Header.VisiblePosition = 1
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.Caption = "Đường thư"
        UltraGridColumn43.Header.VisiblePosition = 3
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.Caption = "Số CT"
        UltraGridColumn44.Header.VisiblePosition = 4
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Header.Caption = "Túi số"
        UltraGridColumn45.Header.VisiblePosition = 5
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(54, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.Caption = "Mã Tỉnh"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn46.MaskInput = ""
        UltraGridColumn46.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Header.Caption = "Khối lượng"
        UltraGridColumn47.Header.VisiblePosition = 6
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47})
        UltraGridBand7.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand7.UseRowLayout = True
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.CardAreaAppearance = Appearance50
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance51.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance51.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance51.ForeColor = System.Drawing.Color.Black
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance51.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.HeaderAppearance = Appearance51
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance52.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.RowAppearance = Appearance52
        Appearance53.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance53.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.RowSelectorAppearance = Appearance53
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance54.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance54.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.Override.SelectedRowAppearance = Appearance54
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Nhap_Chuyen_Hoan.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Nhap_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Nhap_Chuyen_Hoan.Location = New System.Drawing.Point(0, 56)
        Me.dgE1_Nhap_Chuyen_Hoan.Name = "dgE1_Nhap_Chuyen_Hoan"
        Me.dgE1_Nhap_Chuyen_Hoan.Size = New System.Drawing.Size(344, 448)
        Me.dgE1_Nhap_Chuyen_Hoan.TabIndex = 2
        Me.dgE1_Nhap_Chuyen_Hoan.Text = "Danh sách E1 chuyển hoàn"
        '
        'btnThoat_Chuyen_Hoan
        '
        Appearance55.Image = CType(resources.GetObject("Appearance55.Image"), Object)
        Me.btnThoat_Chuyen_Hoan.Appearance = Appearance55
        Me.btnThoat_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat_Chuyen_Hoan.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThoat_Chuyen_Hoan.Location = New System.Drawing.Point(672, 10)
        Me.btnThoat_Chuyen_Hoan.Name = "btnThoat_Chuyen_Hoan"
        Me.btnThoat_Chuyen_Hoan.Size = New System.Drawing.Size(96, 40)
        Me.btnThoat_Chuyen_Hoan.TabIndex = 1
        Me.btnThoat_Chuyen_Hoan.Text = "&Thoát"
        '
        'dgE1_Di_Chuyen_Hoan
        '
        Me.dgE1_Di_Chuyen_Hoan.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.AddNewBox.Prompt = " "
        Appearance56.BackColor = System.Drawing.Color.White
        Appearance56.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Appearance = Appearance56
        UltraGridColumn48.Header.VisiblePosition = 0
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.Caption = "Chọn"
        UltraGridColumn49.Header.VisiblePosition = 1
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(41, 0)
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.Caption = "Mã E1"
        UltraGridColumn50.Header.VisiblePosition = 2
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(103, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Format = "dd/MM/yyyy"
        UltraGridColumn51.Header.Caption = "Ngày đóng"
        UltraGridColumn51.Header.VisiblePosition = 3
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(87, 0)
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Format = "hh:mm"
        UltraGridColumn52.Header.Caption = "Giờ đóng"
        UltraGridColumn52.Header.VisiblePosition = 4
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.Caption = "Đường thư"
        UltraGridColumn53.Header.VisiblePosition = 6
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(64, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.Caption = "Mã Tỉnh"
        UltraGridColumn54.Header.VisiblePosition = 5
        UltraGridColumn54.MaskInput = ""
        UltraGridColumn54.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.Caption = "Số CT"
        UltraGridColumn55.Header.VisiblePosition = 7
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(50, 0)
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.Caption = "Túi số"
        UltraGridColumn56.Header.VisiblePosition = 8
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Header.Caption = "Khối lượng"
        UltraGridColumn57.Header.VisiblePosition = 9
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.Header.Caption = "Tổng tiền"
        UltraGridColumn58.Header.VisiblePosition = 10
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
        UltraGridBand8.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand8.UseRowLayout = True
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.CardAreaAppearance = Appearance57
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance58.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance58.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance58.ForeColor = System.Drawing.Color.Black
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance58.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance59.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.RowAppearance = Appearance59
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.RowSelectorAppearance = Appearance60
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance61.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.Override.SelectedRowAppearance = Appearance61
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di_Chuyen_Hoan.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Di_Chuyen_Hoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Di_Chuyen_Hoan.Location = New System.Drawing.Point(352, 56)
        Me.dgE1_Di_Chuyen_Hoan.Name = "dgE1_Di_Chuyen_Hoan"
        Me.dgE1_Di_Chuyen_Hoan.Size = New System.Drawing.Size(416, 192)
        Me.dgE1_Di_Chuyen_Hoan.TabIndex = 3
        Me.dgE1_Di_Chuyen_Hoan.Text = "Thông tin chi tiết đóng đi"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox3)
        Me.UltraTabPageControl2.Controls.Add(Me.GroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.txtThongTin)
        Me.UltraTabPageControl2.Controls.Add(Me.prgRead)
        Me.UltraTabPageControl2.Controls.Add(Me.btnDongBoDuongThu)
        Me.UltraTabPageControl2.Controls.Add(Me.btnThoat)
        Me.UltraTabPageControl2.Controls.Add(Me.btnLayDuLieuTrenOracle)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(772, 510)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UltraLabel6)
        Me.GroupBox3.Controls.Add(Me.cbBuuCuc_NoiTinh)
        Me.GroupBox3.Location = New System.Drawing.Point(136, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 72)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(24, 34)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(136, 16)
        Me.UltraLabel6.TabIndex = 77
        Me.UltraLabel6.Text = "Đường thư đi nội tỉnh"
        '
        'cbBuuCuc_NoiTinh
        '
        Me.cbBuuCuc_NoiTinh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn59.Header.Caption = "Đường Thư"
        UltraGridColumn59.Header.VisiblePosition = 0
        UltraGridColumn60.Header.Caption = "Tên Đường Thư"
        UltraGridColumn60.Header.VisiblePosition = 1
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn60})
        Me.cbBuuCuc_NoiTinh.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance62.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance62.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance62.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance62.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbBuuCuc_NoiTinh.DisplayLayout.Override.HeaderAppearance = Appearance62
        Me.cbBuuCuc_NoiTinh.DisplayMember = "Ten_Duong_Thu"
        Me.cbBuuCuc_NoiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuuCuc_NoiTinh.Location = New System.Drawing.Point(192, 32)
        Me.cbBuuCuc_NoiTinh.Name = "cbBuuCuc_NoiTinh"
        Me.cbBuuCuc_NoiTinh.Size = New System.Drawing.Size(160, 24)
        Me.cbBuuCuc_NoiTinh.TabIndex = 76
        Me.cbBuuCuc_NoiTinh.ValueMember = "Ma_Bc"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbDen_Ngay_Lay)
        Me.GroupBox2.Controls.Add(Me.UltraLabel5)
        Me.GroupBox2.Controls.Add(Me.cbTu_Ngay_Lay)
        Me.GroupBox2.Controls.Add(Me.UltraLabel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(136, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 88)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thời gian"
        '
        'cbDen_Ngay_Lay
        '
        Me.cbDen_Ngay_Lay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.cbDen_Ngay_Lay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDen_Ngay_Lay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbDen_Ngay_Lay.Location = New System.Drawing.Point(344, 40)
        Me.cbDen_Ngay_Lay.Name = "cbDen_Ngay_Lay"
        Me.cbDen_Ngay_Lay.Size = New System.Drawing.Size(96, 24)
        Me.cbDen_Ngay_Lay.TabIndex = 68
        Me.cbDen_Ngay_Lay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(24, 40)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel5.TabIndex = 69
        Me.UltraLabel5.Text = "Từ ngày"
        '
        'cbTu_Ngay_Lay
        '
        Me.cbTu_Ngay_Lay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.cbTu_Ngay_Lay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTu_Ngay_Lay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.cbTu_Ngay_Lay.Location = New System.Drawing.Point(112, 40)
        Me.cbTu_Ngay_Lay.Name = "cbTu_Ngay_Lay"
        Me.cbTu_Ngay_Lay.Size = New System.Drawing.Size(96, 24)
        Me.cbTu_Ngay_Lay.TabIndex = 67
        Me.cbTu_Ngay_Lay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(248, 40)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel2.TabIndex = 70
        Me.UltraLabel2.Text = "Ðến ngày"
        '
        'txtThongTin
        '
        Me.txtThongTin.FlatMode = True
        Me.txtThongTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThongTin.Location = New System.Drawing.Point(136, 352)
        Me.txtThongTin.Name = "txtThongTin"
        Me.txtThongTin.ReadOnly = True
        Me.txtThongTin.Size = New System.Drawing.Size(480, 29)
        Me.txtThongTin.TabIndex = 75
        '
        'prgRead
        '
        Me.prgRead.Location = New System.Drawing.Point(144, 392)
        Me.prgRead.Name = "prgRead"
        Me.prgRead.Size = New System.Drawing.Size(472, 31)
        Me.prgRead.TabIndex = 74
        Me.prgRead.Text = "[Formatted]"
        '
        'btnDongBoDuongThu
        '
        Appearance63.FontData.BoldAsString = "True"
        Me.btnDongBoDuongThu.Appearance = Appearance63
        Me.btnDongBoDuongThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDongBoDuongThu.Location = New System.Drawing.Point(312, 256)
        Me.btnDongBoDuongThu.Name = "btnDongBoDuongThu"
        Me.btnDongBoDuongThu.Size = New System.Drawing.Size(128, 48)
        Me.btnDongBoDuongThu.TabIndex = 73
        Me.btnDongBoDuongThu.Text = "Đồng bộ đường thư nội tỉnh"
        '
        'btnThoat
        '
        Appearance64.FontData.BoldAsString = "True"
        Me.btnThoat.Appearance = Appearance64
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(488, 256)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(128, 48)
        Me.btnThoat.TabIndex = 72
        Me.btnThoat.Text = "Thoát"
        '
        'btnLayDuLieuTrenOracle
        '
        Appearance65.FontData.BoldAsString = "True"
        Me.btnLayDuLieuTrenOracle.Appearance = Appearance65
        Me.btnLayDuLieuTrenOracle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLayDuLieuTrenOracle.Location = New System.Drawing.Point(136, 256)
        Me.btnLayDuLieuTrenOracle.Name = "btnLayDuLieuTrenOracle"
        Me.btnLayDuLieuTrenOracle.Size = New System.Drawing.Size(128, 48)
        Me.btnLayDuLieuTrenOracle.TabIndex = 71
        Me.btnLayDuLieuTrenOracle.Text = "Chi tiết đóng đi"
        '
        'TabHaiQuan
        '
        Appearance66.BackColor = System.Drawing.SystemColors.Control
        Appearance66.BackColor2 = System.Drawing.Color.White
        Appearance66.BackColorDisabled = System.Drawing.Color.White
        Appearance66.BackColorDisabled2 = System.Drawing.Color.White
        Me.TabHaiQuan.Appearance = Appearance66
        Me.TabHaiQuan.BackColor = System.Drawing.SystemColors.Control
        Me.TabHaiQuan.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabHaiQuan.Controls.Add(Me.UltraTabPageControl1)
        Me.TabHaiQuan.Controls.Add(Me.UltraTabPageControl2)
        Me.TabHaiQuan.Controls.Add(Me.UltraTabPageControl3)
        Me.TabHaiQuan.Controls.Add(Me.UltraTabPageControl4)
        Me.TabHaiQuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabHaiQuan.Location = New System.Drawing.Point(8, 8)
        Me.TabHaiQuan.Name = "TabHaiQuan"
        Me.TabHaiQuan.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabHaiQuan.Size = New System.Drawing.Size(776, 536)
        Me.TabHaiQuan.TabIndex = 72
        Me.TabHaiQuan.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowSizeToFit
        UltraTab1.Key = "tabKetXuatKeToan"
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Kết xuất thông tin cho Kế toán"
        UltraTab2.Key = "tabBaocao"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Thống kê báo cáo"
        UltraTab3.Key = "tabNhapChuyenHoan"
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "Nhập trạng thái chuyển hoàn"
        UltraTab4.Key = "tabLayDuLieu"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Lấy dữ liệu trên Oracle"
        UltraTab4.Visible = False
        Me.TabHaiQuan.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(772, 510)
        '
        'btn_Ban_Ke_Doi_Soat_HQ
        '
        Me.btn_Ban_Ke_Doi_Soat_HQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ban_Ke_Doi_Soat_HQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Ban_Ke_Doi_Soat_HQ.Location = New System.Drawing.Point(440, 424)
        Me.btn_Ban_Ke_Doi_Soat_HQ.Name = "btn_Ban_Ke_Doi_Soat_HQ"
        Me.btn_Ban_Ke_Doi_Soat_HQ.Size = New System.Drawing.Size(112, 32)
        Me.btn_Ban_Ke_Doi_Soat_HQ.TabIndex = 75
        Me.btn_Ban_Ke_Doi_Soat_HQ.Text = "In Bản kê đối soát HQ"
        '
        'frmBaoCaoHaiQuan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 549)
        Me.Controls.Add(Me.TabHaiQuan)
        Me.Name = "frmBaoCaoHaiQuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thuế và lệ phí Hải quan"
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.grbTienTrinh.ResumeLayout(False)
        CType(Me.dgMa_Tinh_E1_Di, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbDon_Vi.ResumeLayout(False)
        Me.GrbNgay_Dong.ResumeLayout(False)
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMa_Tinh_E1_No, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.GroupBox_DuongThuNoiTinh.ResumeLayout(False)
        CType(Me.cbDuongThuNoiTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.dtpNgay_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDuong_Thu_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Thu_No_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Nhap_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Di_Chuyen_Hoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.cbBuuCuc_NoiTinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.cbDen_Ngay_Lay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTu_Ngay_Lay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThongTin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabHaiQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHaiQuan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "==============Khai bao bien cuc bo dung trong Form=============="
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myMa_Tinh As New Ma_Tinh(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDuong_Thu_Den As New Duong_Thu_Den(GConnectionString)
    Dim isEmptyALL As Boolean = True
    Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
    Dim myE1I1 As New E1I1(GConnectionString)
    Dim myDuong_Thu_Di_Noi_Tinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myE1_Den As New E1_Den(GConnectionString)
    Dim myE1_No_Le_Phi_HQ As New E1_No_Le_Phi_HQ(GConnectionString)
    Dim myE1_Thu_No_Le_Phi_HQ As New E1_Thu_No_Le_Phi_HQ(GConnectionString)

    Dim myMaTinhTra As Integer
    Dim myMa_Bc_Noi_Tinh As Integer
    Dim myDuong_Thu_Noi_Thanh As String

    'Dữ liệu trên Oracle
    Dim myE1I1_Oracle As New E1I1_Oracle(GOracleConnectionString)
    Dim myNtinh_Oracle As New Ntinh_Oracle(GOracleConnectionString)

    Private myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid

#End Region

#Region "==============FrmBaoCaoHaiQuan_Load=============="
    Private Sub frmBaoCaoHaiQuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " ( " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac & " )"
        TabHaiQuan.BackColor = Color.Transparent
        'Khoi tao trang thai ban dau khi load Form
        'Tab Thống kê báo cáo
        OptTat_Ca.Checked = True
        btnExport_Excel.Enabled = True
        BtnPreview.Enabled = False
        OptTheo_Tinh.Checked = False
        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
        CbTu_Ngay.Value = myHam_Dung_Chung.dBeginMonth(Date.Now) 'Tu ngay = Ngay dau tien cua thang hien tai
        CbDen_Ngay.Value = Now().Date 'Den ngay = ngay hien tai
        'Load du lieu cho cbMa_Tinh
        GetMaTinh()

        'Tab Kết Xuất Thông Tin Kế Toán
        dtpTuNgay.Value = myHam_Dung_Chung.dBeginMonth(Date.Now) 'Tu ngay = Ngay dau tien cua thang hien tai
        dtpDenNgay.Value = Now().Date 'Den ngay = ngay hien tai
        optCacTinh.Checked = True
        grbTienTrinh.Visible = False

        'Tab Nhập Trạng Thái Chuyển Hoàn
        dtpNgay_Chuyen_Hoan.Value = Now().Date
        GetDuong_Thu_Chuyen_Hoan()

        'Tab Lấy dữ liệu trên Oracle
        cbTu_Ngay_Lay.Value = myHam_Dung_Chung.dBeginMonth(Date.Now) 'Tu ngay = Ngay dau tien cua thang hien tai
        cbDen_Ngay_Lay.Value = Now().Date 'Den ngay = ngay hien tai

        'TabHaiQuan.Select = 1
        'Chỉ có Admin mới được phép lấy dữ liệu về đường thư
        If GTen_Dang_Nhap.ToUpper = "ADMIN" Then
            btnDongBoDuongThu.Enabled = True
        Else
            btnDongBoDuongThu.Enabled = False
        End If

        'Tab Thống Kê Báo Cáo
        'Dat focus vao Tu_Ngay
        CbTu_Ngay.Select()
        chkDuong_Thu_Cap_2.Checked = False
        GroupBox_DuongThuNoiTinh.Enabled = False
        cbMa_Tinh_Validated(sender, e)
    End Sub
#End Region

#Region "==============TabHaiQuan_SelectedTabChanged=============="
    Private Sub TabHaiQuan_SelectedTabChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles TabHaiQuan.SelectedTabChanged
        Try
            Select Case e.Tab.Key
                Case "tabBaocao" 'Thống kê báo cáo
                    dtpTuNgay.Select()
                Case "tabLayDuLieu" 'Lấy dữ liệu nội tỉnh
                    Tao_Bang_Buu_Cuc_Noi_Tinh()
                    cbTu_Ngay_Lay.Select()
                    'Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
                    'cbBuuCuc_NoiTinh.DataSource = myDuong_Thu_Di.Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Tinh(GBuu_Cuc_Khai_Thac, myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh)
                    'cbBuuCuc_NoiTinh.DataBind()
                    'If cbBuuCuc_NoiTinh.Rows.Count > 0 Then
                    '    cbBuuCuc_NoiTinh.Value = cbBuuCuc_NoiTinh.Rows(0).Cells("Ma_Bc").Value
                    '    cbBuuCuc_NoiTinh.Text = cbBuuCuc_NoiTinh.Rows(0).Cells("Ten_Duong_Thu").Value
                    'End If
                Case "tabKetXuatKeToan"   'Ket xuat ke toan
                    dtpTuNgay.Select()
                    If grbTienTrinh.Visible = True Then
                        grbTienTrinh.Visible = False
                    End If
                Case "tabNhapChuyenHoan"
                    dtpNgay_Chuyen_Hoan.Select()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "==============Tab Lấy dữ liệu trên Oracle=============="
#Region "btnDongBoDuongThu_Click"
    Private Sub btnDongBoDuongThu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongBoDuongThu.Click
        If TestOracle(GOracleConnectionString) = True Then
            LayDuLieuDuongThuNoiTinh()
        Else
            MessageBox.Show("Không thể kết nối được với CSDL Oracle" & vbNewLine & "Bạn hãy thiết lập lại tham số", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "LayDuLieuDuongThuNoiTinh: Đồng bộ dữ liệu về đường thư đi nội tỉnh"
    Private Sub LayDuLieuDuongThuNoiTinh()
        'Lấy dữ liệu về đường thư nội tỉnh trên Oracle vào bảng đường thư đi nội tỉnh
        'Nếu không thì thông báo
        Try
            Dim myNtinh_Oracle As New Ntinh_Oracle(GOracleConnectionString)
            Dim myNtinh_Oracle_Chi_Tiet As New Ntinh_Oracle_Chi_Tiet

            Dim myDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
            'Lấy dữ liệu từ Oracle
            Dim myDataSet As New DataSet
            Dim mySoDuongThu As Integer

            'Kiểm tra mã tỉnh của đường thư đi nếu trùng với mã tỉnh của mã bưu cục khai thác thì mới tiếp tục được
            If myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh <> myDanh_Muc_Bc.Lay(cbBuuCuc_NoiTinh.Value).Ma_Tinh Then
                MessageBox.Show("Mã bưu cục đóng đi nội tỉnh" & vbNewLine & "Không thể đồng bộ về đường thư nội tỉnh cho mã đường thư này")
                Exit Sub
            End If

            txtThongTin.Text = "Lấy dữ liệu về đường thư đi nội tỉnh"
            myDataSet = myNtinh_Oracle.Ntinh_Danh_Sach
            mySoDuongThu = myDataSet.Tables(0).Rows.Count
            prgRead.Minimum = 1
            prgRead.Maximum = mySoDuongThu
            prgRead.Step = 1
            prgRead.Value = 1

            prgRead.PerformStep()

            If mySoDuongThu > 0 Then
                Dim myDuong_Thu_Di_Noi_Tinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
                Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet
                Dim myMa_Quan_Ly As Integer
                myMa_Quan_Ly = myDanh_Muc_Bc.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(GBuu_Cuc_Khai_Thac).Ma_Quan_Ly
                Dim i As Integer
                For i = 0 To mySoDuongThu - 1
                    With myNtinh_Oracle_Chi_Tiet ' Chi tiết về đường thư nội tỉnh
                        .Mabc = myDataSet.Tables(0).Rows(i).Item("Mabc")
                        .Madv = myDataSet.Tables(0).Rows(i).Item("Madv")
                        .Tenbc = myDataSet.Tables(0).Rows(i).Item("Tenbc")
                        .Bta = myDataSet.Tables(0).Rows(i).Item("Bta")
                        .Huong = myDataSet.Tables(0).Rows(i).Item("Huong")
                    End With
                    With myDuong_Thu_Di_Noi_Tinh_Chi_Tiet
                        .Ma_Bc = myNtinh_Oracle_Chi_Tiet.Mabc
                        .Ma_Bc_Khai_Thac = cbBuuCuc_NoiTinh.Value ' GBuu_Cuc_Khai_Thac
                        'Tìm mã tỉnh từ Ma_bc
                        'Cập nhật dữ liệu vào bảng Danh_Muc_Bc nếu trường hợp không có dữ liệu về đường thư này
                        If myDanh_Muc_Bc.Lay(.Ma_Bc).Ma_Nc = "" Then 'không có trong bảng danh mục bưu cục
                            .Ma_Tinh = myDanh_Muc_Bc.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(GBuu_Cuc_Khai_Thac).Ma_Tinh
                            myDanh_Muc_Bc.Cap_Nhat_Them(.Ma_Bc, myNtinh_Oracle_Chi_Tiet.Madv, .Ma_Tinh, .Ma_Tinh, myNtinh_Oracle_Chi_Tiet.Tenbc, 2, "", "", "", myMa_Quan_Ly, "VN", "")
                        Else
                            .Ma_Tinh = myDanh_Muc_Bc.Danh_Muc_BC_Nhan_Lay_Boi_Ma_Bc_KT(.Ma_Bc).Ma_Tinh
                        End If
                        'Tìm phân loại đường thư
                        If myNtinh_Oracle_Chi_Tiet.Bta = 1 Then 'Đường thư bưu tá: nội thành
                            .Phan_Loai_Duong_Thu = 0
                        ElseIf myNtinh_Oracle_Chi_Tiet.Huong > 0 Then 'Đường thư ngoại thành
                            .Phan_Loai_Duong_Thu = 1
                        Else 'Phân Loại Đường thư khác
                            .Phan_Loai_Duong_Thu = 2
                        End If
                        .Ten_Duong_Thu = myNtinh_Oracle_Chi_Tiet.Tenbc
                        .Id_Duong_Thu = CreateId_Duong_Thu(.Ma_Bc_Khai_Thac, .Ma_Bc) '.Ma_Bc_Khai_Thac.ToString("000000") + .Ma_Bc.ToString("0000000")
                    End With
                    'Đẩy dữ liệu vào bảng Duong_Thu_Di_Noi_Tinh
                    myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Cap_Nhat_Them(myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Id_Duong_Thu, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ten_Duong_Thu, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc_Khai_Thac, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Tinh, myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Phan_Loai_Duong_Thu)
                    prgRead.PerformStep()
                Next
                MessageBox.Show("Đã đồng bộ xong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Không tìm thấy đường thư nội tỉnh nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            txtThongTin.Text = ""
            Cursor.Current = Cursors.Default
            prgRead.Value = 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnLayDuLieuTrenOracle_Click"
    Private Sub btnLayDuLieuTrenOracle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLayDuLieuTrenOracle.Click
        If TestOracle(GOracleConnectionString) = True Then
            Lay_Du_Lieu_Tu_Oracle_New()
        Else
            MessageBox.Show("Không thể kết nối được với CSDL Oracle" & vbNewLine & "Bạn hãy thiết lập lại tham số", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "Lay_Du_Lieu_Tu_Oracle: Lấy dữ liệu đóng đi nội tỉnh từ CSDL Oracle: Khong Dung"
    'Private Sub Lay_Du_Lieu_Tu_Oracle()
    '    Dim myTu_Ngay As Integer
    '    Dim myDen_Ngay As Integer
    '    Try
    '        'Lấy dữ liệu về ngày tháng
    '        myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(cbTu_Ngay_Lay.Value)
    '        myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(cbDen_Ngay_Lay.Value)
    '        'Lấy dữ liệu về tỉnh cần so sánh số liệu
    '        Dim myDataSet As New DataSet
    '        Dim myE1I1_Oracle As New E1I1_Oracle(GOracleConnectionString) 'Kết nối với Oracle

    '        'myDataSet = myE1I1_Oracle.E1I1_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac)
    '        'Tìm Ma_bc đóng về thuộc tỉnh đó
    '        txtThongTin.Text = "Đang chờ lấy dữ liệu trên Oracle"
    '        Dim myMa_Bc As Integer 'Lấy Ma_Bc khai thác dành cho nội tỉnh

    '        myMa_Bc = 101000
    '        myDataSet = myE1I1_Oracle.E1I1_DS_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, GBuu_Cuc_Khai_Thac, myMa_Bc)
    '        Dim myTong_So_Dong As Integer
    '        myTong_So_Dong = CInt(SetNullValue(myDataSet.Tables(0).Rows.Count, 0))
    '        If myTong_So_Dong > 0 Then
    '            prgRead.Minimum = 1
    '            prgRead.Maximum = myTong_So_Dong
    '            prgRead.Step = 1
    '            prgRead.Value = 1

    '            txtThongTin.Text = "Đang đẩy dữ liệu vào máy chủ SQL"
    '            Dim i As Integer
    '            For i = 0 To myTong_So_Dong - 1
    '                'Lấy dữ liệu chi tiết
    '                Dim myE1I1_Chi_Tiet As New E1I1_Chi_Tiet
    '                Dim myE1I1 As New E1I1(GConnectionString)
    '                With myE1I1_Chi_Tiet
    '                    .Ma_E1 = myDataSet.Tables(0).Rows(i).Item("Ma_E1")
    '                    .Ngay_Dong = myDataSet.Tables(0).Rows(i).Item("Ngay_Dong")
    '                    .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Khai_Thac")
    '                    .Ma_Bc = myDataSet.Tables(0).Rows(i).Item("Ma_Bc")
    '                    .Ma_Bc_Noi_Tinh = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Noi_Tinh")
    '                    'Tìm phân loại đường thư cho bưu cục này
    '                    Dim myDuong_Thu_Di_Noi_Tinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
    '                    Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet
    '                    myDuong_Thu_Di_Noi_Tinh_Chi_Tiet = myDuong_Thu_Di_Noi_Tinh.Lay(CreateId_Duong_Thu(.Ma_Bc.ToString, .Ma_Bc_Noi_Tinh))
    '                    If myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc > 0 Then
    '                        .Phan_Loai_Duong_Thu = myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Phan_Loai_Duong_Thu
    '                    Else
    '                        .Phan_Loai_Duong_Thu = 2
    '                        If MessageBox.Show("Không tìm thấy đường thư nội tỉnh này" & vbNewLine & "Bạn hãy cập nhật lại bảng danh mục đường thư nội tỉnh", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '                            Exit For
    '                        End If
    '                    End If
    '                    .So_Chuyen_Thu = myDataSet.Tables(0).Rows(i).Item("So_Chuyen_Thu")
    '                    .Loai_Chuyen_Thu = "EN" 'myDataSet.Tables(0).Rows(i).Item("Loai_Chuyen_Thu")
    '                    .Tui_So = myDataSet.Tables(0).Rows(i).Item("Tui_So")
    '                    .Nuoc_Nhan = myDataSet.Tables(0).Rows(i).Item("Nuoc_Nhan")
    '                    .Nuoc_Tra = myDataSet.Tables(0).Rows(i).Item("Nuoc_Tra")
    '                    .Ma_Bc_Goc = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Goc")
    '                    .Ma_Bc_Tra = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Tra")
    '                    .Khoi_Luong = myDataSet.Tables(0).Rows(i).Item("Khoi_Luong")
    '                    'Tìm phân loại bưu phẩm: D/M
    '                    Select Case myDataSet.Tables(0).Rows(i).Item("Phan_Loai")
    '                        Case 1, 31
    '                            .Phan_Loai = "D"
    '                        Case Else
    '                            .Phan_Loai = "M"
    '                    End Select
    '                    'Tạo Id_E1
    '                    .Id_E1 = .Ma_Bc_Khai_Thac.ToString("0000000") + _
    '                                .Ma_Bc.ToString("0000000") + _
    '                                .Ngay_Dong.ToString + _
    '                                .So_Chuyen_Thu.ToString + _
    '                                .Loai_Chuyen_Thu.ToString + _
    '                                .Tui_So.ToString + _
    '                                .Ma_E1.ToString + _
    '                                "0000" 'Kiện số
    '                End With
    '                'Insert dữ liệu vào bảng tạm trong SQL
    '                If myE1I1_Chi_Tiet.Id_E1 <> "" Then
    '                    myE1I1.Cap_Nhat_Them_E1I1(myE1I1_Chi_Tiet.Id_E1, _
    '                                                myE1I1_Chi_Tiet.Ma_E1, _
    '                                                myE1I1_Chi_Tiet.Ngay_Dong, _
    '                                                myE1I1_Chi_Tiet.Ma_Bc_Khai_Thac, _
    '                                                myE1I1_Chi_Tiet.Ma_Bc, _
    '                                                myE1I1_Chi_Tiet.Ma_Bc_Noi_Tinh, _
    '                                                myE1I1_Chi_Tiet.Phan_Loai_Duong_Thu, _
    '                                                myE1I1_Chi_Tiet.So_Chuyen_Thu, _
    '                                                myE1I1_Chi_Tiet.Loai_Chuyen_Thu, _
    '                                                myE1I1_Chi_Tiet.Tui_So, _
    '                                                myE1I1_Chi_Tiet.Nuoc_Nhan, _
    '                                                myE1I1_Chi_Tiet.Nuoc_Tra, _
    '                                                myE1I1_Chi_Tiet.Ma_Bc_Goc, _
    '                                                myE1I1_Chi_Tiet.Ma_Bc_Tra, _
    '                                                myE1I1_Chi_Tiet.Khoi_Luong, _
    '                                                myE1I1_Chi_Tiet.Phan_Loai)
    '                End If
    '                prgRead.PerformStep()
    '            Next i
    '            txtThongTin.Text = "Đã lấy xong dữ liệu"
    '            MessageBox.Show("Đã lấy xong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            txtThongTin.Text = ""
    '            MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '        Cursor.Current = Cursors.Default
    '        prgRead.Value = 1
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
#End Region

#Region "Lay_Du_Lieu_Tu_Oracle_New: Lấy dữ liệu đóng đi nội tỉnh từ CSDL Oracle"
    Private Sub Lay_Du_Lieu_Tu_Oracle_New()
        Dim myE1I1_Chi_Tiet As New E1I1_Chi_Tiet
        Dim myE1I1 As New E1I1(GConnectionString)
        Dim myTu_Ngay As Integer
        Dim myDen_Ngay As Integer

        Try
            'Lấy dữ liệu về ngày tháng
            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(cbTu_Ngay_Lay.Value)
            myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(cbDen_Ngay_Lay.Value)
            'Kiểm tra xem dữ liệu từ ngày đến ngày đã có dữ liệu chưa

            'Nếu đã có đủ số liệu rồi thì thông báo

            'Lấy dữ liệu về tỉnh cần so sánh số liệu
            Dim myDataSet As New DataSet
            Dim myE1I1_Oracle As New E1I1_Oracle(GOracleConnectionString) 'Kết nối với Oracle

            'Kiểm tra kết nối với Oracle
            If TestOracle(GOracleConnectionString) = False Then
                MessageBox.Show("Không thể kết nối được với CSDL Oracle" & vbNewLine & "Bạn hãy kiểm tra lại cấu hình CSDL", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            End If
            'Kiểm tra trong danh sách đường thư đi nội tỉnh có tồn tại đường thư nào không
            If Not myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Bc_Khai_Thac(cbBuuCuc_NoiTinh.Value).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("Không tồn tại đường thư nội tỉnh nào thuộc mã bưu cục này" & vbNewLine & "Bạn hãy kiểm tra lại dữ liệu hoặc thông tin đường thư!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbBuuCuc_NoiTinh.Select()
            Else 'Nếu có tồn tại thì tiếp tục kiểm tra dữ liệu
                'Lấy dữ liệu từ ngày đến ngày trên máy chủ SQL
                Dim myE1_Di As New E1_Di(GConnectionString)
                Dim myId_Duong_Thu As String
                txtThongTin.Text = "Lấy dữ liệu đóng đi nội tỉnh của bưu phẩm quốc tế"
                myId_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, CInt(cbBuuCuc_NoiTinh.Value))
                myDataSet = myE1_Di.Danh_Sach_E1_Di_Theo_Duong_Thu_Di_Noi_Tinh(myTu_Ngay, myDen_Ngay, myId_Duong_Thu)
                Dim myTong_So_Dong As Long
                myTong_So_Dong = CInt(SetNullValue(myDataSet.Tables(0).Rows.Count, 0))
                If myTong_So_Dong > 0 Then
                    Dim i As Long
                    If MessageBox.Show("Có tổng số " & myTong_So_Dong & " bưu phẩm." & vbNewLine & "Bạn có muốn tiếp tục không???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                        Exit Sub
                    End If
                    prgRead.Minimum = 1
                    prgRead.Maximum = myTong_So_Dong
                    prgRead.Step = 1
                    prgRead.Value = 1
                    For i = 0 To myTong_So_Dong - 1
                        With myE1I1_Chi_Tiet
                            .Id_E1 = myDataSet.Tables(0).Rows(i).Item("Id_E1")
                            .Ma_E1 = myDataSet.Tables(0).Rows(i).Item("Ma_E1")
                            .Ngay_Dong = myDataSet.Tables(0).Rows(i).Item("Ngay_Dong")
                            .Ma_Bc_Khai_Thac = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Khai_Thac")
                            'Tìm mã bưu cục đóng đi theo đường thư đó
                            .Ma_Bc = CInt(SetNullValue(cbBuuCuc_NoiTinh.Value, 0))
                            .Nuoc_Nhan = myDataSet.Tables(0).Rows(i).Item("Nuoc_Nhan")
                            .Nuoc_Tra = myDataSet.Tables(0).Rows(i).Item("Nuoc_Tra")
                            .Ma_Bc_Goc = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Goc")
                            .Ma_Bc_Tra = myDataSet.Tables(0).Rows(i).Item("Ma_Bc_Tra")
                            .Khoi_Luong = myDataSet.Tables(0).Rows(i).Item("Khoi_Luong")
                            .Phan_Loai = myDataSet.Tables(0).Rows(i).Item("Phan_Loai")
                            .Loai_Chuyen_Thu = "EN"
                            'Tìm Ma_Bc_Noi_Tinh trong CSDS Oracle
                            Dim myHam_Dung_Chung As New Ham_Dung_Chung
                            Dim myTu_Ngay_Oracle As Integer
                            Dim myDen_Ngay_Oracle As Integer
                            myTu_Ngay_Oracle = .Ngay_Dong
                            myDen_Ngay_Oracle = myHam_Dung_Chung.AddIntDate(myTu_Ngay_Oracle, 10)
                            Dim myDataSetOracle As New DataSet
                            myDataSetOracle = myE1I1_Oracle.E1I1_Oracle_EMS_QT_Tu_Ngay_Den_Ngay(myTu_Ngay_Oracle, myDen_Ngay_Oracle, .Ma_Bc, .Ma_E1)
                            If myDataSetOracle.Tables(0).Rows.Count > 0 Then
                                .Ma_Bc_Noi_Tinh = myDataSetOracle.Tables(0).Rows(0).Item("Ma_Bc_Noi_Tinh")
                                .So_Chuyen_Thu = myDataSetOracle.Tables(0).Rows(0).Item("So_Chuyen_Thu")
                                .Tui_So = myDataSetOracle.Tables(0).Rows(0).Item("Tui_So")
                                'Tìm phân loại đường thư cho bưu cục này
                                Dim myDuong_Thu_Di_Noi_Tinh As New Duong_Thu_Di_Noi_Tinh(GConnectionString)
                                Dim myDuong_Thu_Di_Noi_Tinh_Chi_Tiet As New Duong_Thu_Di_Noi_Tinh_Chi_Tiet
                                myDuong_Thu_Di_Noi_Tinh_Chi_Tiet = myDuong_Thu_Di_Noi_Tinh.Lay(CreateId_Duong_Thu(.Ma_Bc.ToString, .Ma_Bc_Noi_Tinh))
                                If myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Ma_Bc > 0 Then
                                    .Phan_Loai_Duong_Thu = myDuong_Thu_Di_Noi_Tinh_Chi_Tiet.Phan_Loai_Duong_Thu
                                Else
                                    .Phan_Loai_Duong_Thu = 3
                                    'If MessageBox.Show("Không tìm thấy bưu cục " & .Ma_Bc_Noi_Tinh & " trong danh mục đường thư nội tỉnh." & vbNewLine & "Bạn hãy cập nhật lại bảng danh mục đường thư nội tỉnh", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    '    Exit For
                                    'End If
                                End If
                            Else
                                'MessageBox.Show("Không tìm thấy dữ liệu đóng đi của bưu phẩm này: " & .Ma_E1, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                .Ma_Bc_Noi_Tinh = 0
                                .So_Chuyen_Thu = 0
                                .Tui_So = 0
                                .Phan_Loai_Duong_Thu = 4
                            End If
                        End With
                        'Đẩy dữ liệu vào bảng E1I1
                        'Insert dữ liệu vào bảng tạm trong SQL
                        If myE1I1_Chi_Tiet.Id_E1 <> "" Then
                            myE1I1.Cap_Nhat_Them_E1I1(myE1I1_Chi_Tiet.Id_E1, _
                                                        myE1I1_Chi_Tiet.Ma_E1, _
                                                        myE1I1_Chi_Tiet.Ngay_Dong, _
                                                        myE1I1_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                        myE1I1_Chi_Tiet.Ma_Bc, _
                                                        myE1I1_Chi_Tiet.Ma_Bc_Noi_Tinh, _
                                                        myE1I1_Chi_Tiet.Phan_Loai_Duong_Thu, _
                                                        myE1I1_Chi_Tiet.So_Chuyen_Thu, _
                                                        myE1I1_Chi_Tiet.Loai_Chuyen_Thu, _
                                                        myE1I1_Chi_Tiet.Tui_So, _
                                                        myE1I1_Chi_Tiet.Nuoc_Nhan, _
                                                        myE1I1_Chi_Tiet.Nuoc_Tra, _
                                                        myE1I1_Chi_Tiet.Ma_Bc_Goc, _
                                                        myE1I1_Chi_Tiet.Ma_Bc_Tra, _
                                                        myE1I1_Chi_Tiet.Khoi_Luong, _
                                                        myE1I1_Chi_Tiet.Phan_Loai)
                        End If
                        prgRead.PerformStep()
                    Next i
                    MessageBox.Show("Đã cập nhật xong dữ liệu đóng đi nội tỉnh từ ngày:" & myHam_Dung_Chung.ConvertIntToVNDateType(myTu_Ngay) & " -Đến ngày: " & myHam_Dung_Chung.ConvertIntToVNDateType(myDen_Ngay), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Không có dữ liệu đóng đi trong khoảng thời gian của đường thư này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            Cursor.Current = Cursors.Default
            prgRead.Value = 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Close()
    End Sub
#End Region

#End Region

#Region "==============Tab Thống kê báo cáo=============="
#Region "OptTheo_Tinh_Validated"
    Private Sub OptTheo_Tinh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTheo_Tinh.Validated
        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
        If OptTheo_Tinh.Checked Or OptTat_Ca.Checked Then
            btnExport_Excel.Enabled = True
        Else
            btnExport_Excel.Enabled = False
        End If

    End Sub
#End Region

#Region "OptTheo_Tinh_CheckedChanged"
    Private Sub OptTheo_Tinh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTheo_Tinh.CheckedChanged
        If OptTheo_Tinh.Checked Then
            BtnPreview.Enabled = True
            BtnPrint.Enabled = True
            btnExport_Excel.Enabled = True
        End If
        cbMa_Tinh.Enabled = OptTheo_Tinh.Checked
        If OptTheo_Tinh.Checked = True Then
            cbMa_Tinh.Select()
        End If
    End Sub
#End Region

#Region "OptTat_Ca_CheckedChanged"
    Private Sub OptTat_Ca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTat_Ca.CheckedChanged
        BtnPreview.Enabled = Not OptTat_Ca.Checked
        BtnPrint.Enabled = OptTat_Ca.Checked
        btnExport_Excel.Enabled = OptTat_Ca.Checked
        If OptTat_Ca.Checked = True Then
            GroupBox_DuongThuNoiTinh.Enabled = False
        End If

    End Sub
#End Region

#Region "OptBuu_Ta_Noi_Bo_CheckedChanged"
    Private Sub OptBuu_Ta_Noi_Bo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptBuu_Ta_Noi_Bo.CheckedChanged
        BtnPreview.Enabled = Not OptBuu_Ta_Noi_Bo.Checked
        BtnPrint.Enabled = Not OptBuu_Ta_Noi_Bo.Checked
        btnExport_Excel.Enabled = OptBuu_Ta_Noi_Bo.Checked
    End Sub
#End Region

#Region "GetMaTinh"
    Private Sub GetMaTinh()
        Dim TblDanh_Sach_Tinh As New DataTable
        TblDanh_Sach_Tinh = myMa_Tinh.Hai_Quan_Ma_Tinh_Lay_Theo_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac).Tables(0)
        cbMa_Tinh.DataSource = TblDanh_Sach_Tinh
        cbMa_Tinh.DataBind()
        cbMa_Tinh.Value = TblDanh_Sach_Tinh.Rows(0).Item("Ma_Tinh")
        cbMa_Tinh.LimitToList = True
    End Sub
#End Region

#Region "CbTu_Ngay_KeyDown"
    Private Sub CbTu_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbTu_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            CbDen_Ngay.Select()
        End If
    End Sub
#End Region

#Region "CbDen_Ngay_KeyDown"
    Private Sub CbDen_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbDen_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            OptTat_Ca.Select()
        End If
    End Sub
#End Region

#Region "BtnPreview_Click"
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Try
            'Nếu tích vào chuyển hoàn
            If chkChuyen_Hoan.Checked Then
                Ban_Ke_Hai_Quan_Chuyen_Hoan(True)
                Exit Sub
            End If

            If OptTheo_Tinh.Checked = True Then
                myMaTinhTra = cbMa_Tinh.Value
                'If cbDuongThuNoiTinh.Text <> "" Then
                '    myMa_Bc_Noi_Tinh = cbDuongThuNoiTinh.ActiveRow.Cells("Ma_Bc").Value
                'Else
                '    myMa_Bc_Noi_Tinh = 0
                'End If
                If cbDuongThuNoiTinh.Text <> "" Then
                    myDuong_Thu_Noi_Thanh = cbDuongThuNoiTinh.Value
                Else
                    myDuong_Thu_Noi_Thanh = ""
                End If
                If GroupBox_DuongThuNoiTinh.Enabled = True And myDuong_Thu_Noi_Thanh <> "" Then
                    Ban_Ke_Hai_Quan_Noi_Thanh(True, myMaTinhTra, myDuong_Thu_Noi_Thanh)
                    'If optNoiNgoaiThanh.Checked = True Then
                    '    Ban_Ke_Hai_Quan(True, cbMa_Tinh.Value, False)
                    'ElseIf optNgoaiThanh.Checked = True Then
                    '    Ban_Ke_Hai_Quan_Noi_Tinh(True, myMaTinhTra, True, myMa_Bc_Noi_Tinh)
                    'Else
                    '    Ban_Ke_Hai_Quan_Noi_Tinh(True, myMaTinhTra, False, myMa_Bc_Noi_Tinh)
                    'End If
                Else
                    'Nếu in tất cả thì bỏ qua đường thư nội thành, chỉ in đường thư ngoại thành
                    Ban_Ke_Hai_Quan(True, cbMa_Tinh.Value, False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnPrint_Click"
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim idx As Integer
        Dim mCur_Ma_Tinh As Integer
        Try
            'Chuyen hoan
            If chkChuyen_Hoan.Checked Then
                Ban_Ke_Hai_Quan_Chuyen_Hoan(False)
                Exit Sub
            End If

            'Truong hop in theo tinh
            If OptTheo_Tinh.Checked = True Then
                myMaTinhTra = cbMa_Tinh.Value
                If cbDuongThuNoiTinh.Text <> "" Then
                    myMa_Bc_Noi_Tinh = cbDuongThuNoiTinh.ActiveRow.Cells("Ma_Bc").Value 'myMa_Bc_Noi_Tinh = cbDuongThuNoiTinh.Value
                Else
                    myMa_Bc_Noi_Tinh = 0
                End If
                If GroupBox_DuongThuNoiTinh.Enabled = True Then
                    If optNoiNgoaiThanh.Checked = True Then
                        Ban_Ke_Hai_Quan(True, cbMa_Tinh.Value, False)
                    ElseIf optNgoaiThanh.Checked = True Then
                        Ban_Ke_Hai_Quan_Noi_Tinh(False, myMaTinhTra, True, myMa_Bc_Noi_Tinh)
                    Else
                        Ban_Ke_Hai_Quan_Noi_Tinh(False, myMaTinhTra, False, myMa_Bc_Noi_Tinh)
                    End If
                Else
                    'Nếu in tất cả thì bỏ qua đường thư nội thành, chỉ in đường thư ngoại thành
                    Ban_Ke_Hai_Quan(False, cbMa_Tinh.Value, False)
                End If
                'Ban_Ke_Hai_Quan(False, cbMa_Tinh.Value, False, False)
                Exit Sub
            End If

            'Truong hop in tat ca
            If OptTat_Ca.Checked = True Then
                'Khoi Tao bien isEmptyALL - Ban dau luon = true
                isEmptyALL = True
                'Lay ma tinh hien tai
                mCur_Ma_Tinh = myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
                'Duyet tung tinh tren cbMa_Tinh va in ra may in
                If MessageBox.Show("Bạn có thực sự muốn in thông tin của tất cả các tỉnh không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For idx = 0 To cbMa_Tinh.Rows.Count - 1
                        Dim myMa_Tinh_idx As Integer
                        myMa_Tinh_idx = cbMa_Tinh.Rows(idx).Cells("Ma_Tinh").Value
                        'Khong in du lieu cua buu dien TP, trong truong hop in Tat ca
                        If mCur_Ma_Tinh <> myMa_Tinh_idx Then
                            Ban_Ke_Hai_Quan(False, myMa_Tinh_idx, True)
                        End If
                        ''Kiểm tra xem tỉnh đó có dữ liệu nội tỉnh không nếu có thì chỉ in ngoại thành thôi
                        'Dim myDataSet As New DataSet
                        'myDataSet = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh(myMa_Tinh_idx)
                        'If myDataSet.Tables(0).Rows.Count > 0 Then
                        '    'myMaTinhTra = cbMa_Tinh.Value
                        '    If cbDuongThuNoiTinh.Text <> "" Then
                        '        myMa_Bc_Noi_Tinh = cbDuongThuNoiTinh.Value
                        '    Else
                        '        myMa_Bc_Noi_Tinh = 0
                        '    End If
                        '    Ban_Ke_Hai_Quan_Noi_Tinh(False, myMa_Tinh_idx, True, myMa_Bc_Noi_Tinh)
                        'Else
                        '    'In dữ liệu của cả tỉnh
                        '    Ban_Ke_Hai_Quan(False, myMa_Tinh_idx, True)
                        'End If
                    Next idx
                Else
                    Exit Sub
                End If
                'Ket thuc neu khong tinh nao co du lieu thi ra thong bao
                If isEmptyALL = True Then
                    CMessageBox.Show("Không có tỉnh nào có dữ liệu về loại bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Ban_Ke_Hai_Quan: Lấy báo cáo về bản kê hải quan từ mã tỉnh"
    Private Sub Ban_Ke_Hai_Quan(ByVal isPreview As Boolean, ByVal Ma_Tinh As Integer, ByVal isTatCa As Boolean)
        'Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
        Dim myTable As New DataTable
        Dim RptBang_Ke_Thue_Hai_Quan As New RptBang_Ke_Thue_Hai_Quan
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim Menu_Trai As String
        Dim Menu_Tieu_De As String
        Dim Menu_Thoi_Gian As String
        Dim Menu_Ten_Dang_Nhap As String
        'Dim Menu_Ngay_Thang_Nam As String
        Dim Menu_Tien_Chu As String
        Dim myNumber As New ConvertNumberToString
        Dim Menu_Dien_Thoai As String

        'Lay du lieu chi tiet cho bao cao
        'myTable = myE1_Di.Hai_Quan_Danh_Sach_E1_Di(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0)
        myTable = myE1_No_Le_Phi_HQ.Hai_Quan_Danh_Sach_E1_No_Le_Phi_HQ(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0)
        'Kiem tra neu khong co ban ghi thi thoat
        If isTatCa = False Then   'Truong hop in theo tin thi ra thong bao va thoat
            If myTable.Rows.Count = 0 Then
                CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else    'Truong hop in theo tat ca cac tinh 
            If myTable.Rows.Count = 0 Then
                Exit Sub   'neu khong co ban ghi nao thi thoat 
            Else
                isEmptyALL = False   'neu co ban ghi thi gan lai biet isEmptyALL
            End If
        End If
        'Tiep tuc thuc hien neu co du lieu
        'Thong tin chi tiet
        myTable.TableName = "E1_Di_Bang_Ke_Hai_Quan"
        'Thong tin header va footer dua vao thong qua Paramete
        'Menu Trai - Ma theo doi don vi
        Menu_Trai = "KTN " & myMa_Don_Vi.Lay_Boi_Ma_Tinh(Ma_Tinh).Tables(0).Rows(0).Item("Ma_Don_Vi")
        _pThamSo.Value = Menu_Trai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tieu De - "Nho Tinh Thu ho"
        Menu_Tieu_De = "Nhờ bưu điện " & myMa_Tinh.Lay(Ma_Tinh).Ten_Tinh & " thu hộ"
        _pThamSo.Value = Menu_Tieu_De
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Thoi Gian - "Tu ngay Den ngay"
        Menu_Thoi_Gian = "Từ ngày   " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = Menu_Thoi_Gian
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ten Dang Nhap
        Menu_Ten_Dang_Nhap = GHo_Ten
        _pThamSo.Value = Menu_Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Dien Thoai
        Menu_Dien_Thoai = IIf(GDien_Thoai.Trim <> "", " Tel : " & GDien_Thoai, GDien_Thoai)
        _pThamSo.Value = Menu_Dien_Thoai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Dien_Thoai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ngay_Thang_Nam
        _pThamSo.Value = GrptNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tien Chu - So tien bang chu
        'Lay tong tien vi khong truyen duoc gia tri tu report vao
        'myNumber.Number = myE1_Di.Hai_Quan_Tong_Tien_Theo_Ma_Tinh(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0).Rows(0).Item("Tong_Tien")
        myNumber.Number = myE1_No_Le_Phi_HQ.Hai_Quan_Tong_Tien_Theo_Ma_Tinh_E1_No_Le_Phi_HQ(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0).Rows(0).Item("Tong_Tien")
        'Truyen vao Menu_Tien_Chu
        Menu_Tien_Chu = myNumber.StringNumber & " đồng chẵn./."
        _pThamSo.Value = Menu_Tien_Chu
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tien_Chu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBang_Ke_Thue_Hai_Quan.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBang_Ke_Thue_Hai_Quan
        Cursor.Current = Cursors.Default
        'Bat dau in
        If isPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBang_Ke_Thue_Hai_Quan.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region

#Region "Ban_Ke_Hai_Quan_Chuyen_Hoan: Lấy báo cáo E1 chuyển hoàn về bản kê hải quan"
    Private Sub Ban_Ke_Hai_Quan_Chuyen_Hoan(ByVal isPreview As Boolean)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
        Dim myTable As New DataTable
        Dim RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan As New RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim Menu_Trai As String
        Dim Menu_Tieu_De As String
        Dim Menu_Thoi_Gian As String
        Dim Menu_Ten_Dang_Nhap As String
        'Dim Menu_Ngay_Thang_Nam As String
        Dim Menu_Tien_Chu As String
        Dim myNumber As New ConvertNumberToString
        Dim Menu_Dien_Thoai As String

        'Lay du lieu chi tiet cho bao cao
        myTable = myE1_Di.Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac).Tables(0)
        'Kiem tra neu khong co ban ghi thi thoat
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Tiep tuc thuc hien neu co du lieu
        'Thong tin chi tiet
        myTable.TableName = "E1_Di_Bang_Ke_Hai_Quan_Chuyen_Hoan"

        'Thong tin header va footer dua vao thong qua Paramete 
        'Menu Thoi Gian - "Tu ngay Den ngay"
        Menu_Thoi_Gian = "Từ ngày   " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = Menu_Thoi_Gian
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ten Dang Nhap
        Menu_Ten_Dang_Nhap = GHo_Ten
        _pThamSo.Value = Menu_Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ngay_Thang_Nam
        _pThamSo.Value = GrptNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan
        Cursor.Current = Cursors.Default
        'Bat dau in
        If isPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBang_Ke_Thue_Hai_Quan_Chuyen_Hoan.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region

#Region "Ban_Ke_Hai_Quan_Noi_Tinh: Lấy báo cáo về bản kê hải quan từ mã tỉnh có đường thư nội tỉnh (ngoại thành, nội thành: theo đường thư nội tỉnh)"
    Private Sub Ban_Ke_Hai_Quan_Noi_Tinh(ByVal isPreview As Boolean, ByVal Ma_Tinh As Integer, ByVal isNgoaiThanh As Boolean, ByVal Ma_Bc_Noi_Tinh As Integer)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
        Dim myTable As New DataTable
        Dim RptBang_Ke_Thue_Hai_Quan As New RptBang_Ke_Thue_Hai_Quan
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim Menu_Trai As String
        Dim Menu_Tieu_De As String
        Dim Menu_Thoi_Gian As String
        Dim Menu_Ten_Dang_Nhap As String
        'Dim Menu_Ngay_Thang_Nam As String
        Dim Menu_Tien_Chu As String
        Dim myNumber As New ConvertNumberToString
        Dim Menu_Dien_Thoai As String

        'Lay du lieu chi tiet cho bao cao
        If Ma_Bc_Noi_Tinh > 0 Then
            myTable = myE1_Di.Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, Ma_Bc_Noi_Tinh).Tables(0)
        Else
            If isNgoaiThanh = True Then
                myTable = myE1_Di.Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, 1).Tables(0)
            Else
                myTable = myE1_Di.Hai_Quan_Danh_Sach_E1_Di_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, 0).Tables(0)
            End If
        End If

        'Kiem tra neu khong co ban ghi thi thoat
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Tiep tuc thuc hien neu co du lieu
        'Thong tin chi tiet
        myTable.TableName = "E1_Di_Bang_Ke_Hai_Quan_Noi_Tinh"
        'Thong tin header va footer dua vao thong qua Paramete
        'Menu Trai - Ma theo doi don vi
        Menu_Trai = "KTN " & myMa_Don_Vi.Lay_Boi_Ma_Tinh(Ma_Tinh).Tables(0).Rows(0).Item("Ma_Don_Vi")
        _pThamSo.Value = Menu_Trai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tieu De - "Nho Tinh Thu ho"
        If Ma_Bc_Noi_Tinh > 0 Then  'neu in theo tung duong thu noi tinh
            Menu_Tieu_De = "Nhờ bưu cục " & Ma_Bc_Noi_Tinh.ToString & " thu hộ"
        Else    'Neu in tat ca theo tinh
            If isNgoaiThanh Then 'Nếu là đường thư ngoại thành
                Menu_Tieu_De = "Nhờ bưu điện " & myMa_Tinh.Lay(Ma_Tinh).Ten_Tinh & " thu hộ"
            Else 'Nếu là đường thư nội thành
                Menu_Tieu_De = "Chi nhánh Công ty cổ phần chuyển phát nhanh tại " & myMa_Tinh.Lay(Ma_Tinh).Ten_Tinh
            End If
        End If
        _pThamSo.Value = Menu_Tieu_De
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Thoi Gian - "Tu ngay Den ngay"
        Menu_Thoi_Gian = "Từ ngày   " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = Menu_Thoi_Gian
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ten Dang Nhap
        Menu_Ten_Dang_Nhap = GHo_Ten
        _pThamSo.Value = Menu_Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Dien Thoai
        Menu_Dien_Thoai = IIf(GDien_Thoai.Trim <> "", " Tel : " & GDien_Thoai, GDien_Thoai)
        _pThamSo.Value = Menu_Dien_Thoai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Dien_Thoai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ngay_Thang_Nam
        _pThamSo.Value = GrptNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tien Chu - So tien bang chu
        'Lay tong tien vi khong truyen duoc gia tri tu report vao
        If Ma_Bc_Noi_Tinh > 0 Then  'neu in theo tung duong thu noi tinh
            myNumber.Number = myE1_Di.Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Ma_Bc_Noi_Tinh(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, Ma_Bc_Noi_Tinh).Tables(0).Rows(0).Item("Tong_Tien")
        Else
            If Not isNgoaiThanh Then 'Đường thư nội thành
                myNumber.Number = myE1_Di.Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, 0).Tables(0).Rows(0).Item("Tong_Tien")
            Else 'Đường thư ngoại thành
                myNumber.Number = myE1_Di.Hai_Quan_Tong_Tien_Noi_Tinh_Theo_Phan_Loai_Duong_Thu(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, 1).Tables(0).Rows(0).Item("Tong_Tien")
            End If
        End If
        'Truyen vao Menu_Tien_Chu
        Menu_Tien_Chu = myNumber.StringNumber & " đồng chẵn./."
        _pThamSo.Value = Menu_Tien_Chu
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tien_Chu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBang_Ke_Thue_Hai_Quan.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBang_Ke_Thue_Hai_Quan
        Cursor.Current = Cursors.Default
        'Bat dau in
        If isPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBang_Ke_Thue_Hai_Quan.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region

#Region "Ban_Ke_Hai_Quan_Noi_Thanh: Lấy báo cáo về bản kê hải quan từ mã tỉnh có đường thư nội thành thuộc bưu điện thành phố"
    Private Sub Ban_Ke_Hai_Quan_Noi_Thanh(ByVal isPreview As Boolean, ByVal Ma_Tinh As Integer, ByVal Duong_Thu_Noi_Thanh As String)
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
        Dim myTable As New DataTable
        Dim RptBang_Ke_Thue_Hai_Quan As New RptBang_Ke_Thue_Hai_Quan
        Dim pvCollection As New ParameterValues
        Dim _pThamSo As New ParameterDiscreteValue
        Dim FrmView As New FrmViewReports
        Dim Menu_Trai As String
        Dim Menu_Tieu_De As String
        Dim Menu_Thoi_Gian As String
        Dim Menu_Ten_Dang_Nhap As String
        'Dim Menu_Ngay_Thang_Nam As String
        Dim Menu_Tien_Chu As String
        Dim myNumber As New ConvertNumberToString
        Dim Menu_Dien_Thoai As String

        'Lay du lieu
        myTable = myE1_No_Le_Phi_HQ.Hai_Quan_Danh_Sach_E1_No_Le_Phi_HQ_Lay_Theo_Duong_Thu_Noi_Thanh(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, Duong_Thu_Noi_Thanh).Tables(0)

        'Kiem tra neu khong co ban ghi thi thoat
        If myTable.Rows.Count = 0 Then
            CMessageBox.Show("Không có thông tin dữ liệu về bản kê này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'Tiep tuc thuc hien neu co du lieu
        'Thong tin chi tiet
        myTable.TableName = "E1_Di_Bang_Ke_Hai_Quan"
        'Thong tin header va footer dua vao thong qua Paramete
        'Menu Trai - Ma theo doi don vi
        Menu_Trai = "KTN " & myMa_Don_Vi.Lay_Boi_Ma_Tinh(Ma_Tinh).Tables(0).Rows(0).Item("Ma_Don_Vi")
        _pThamSo.Value = Menu_Trai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tieu De 
        Dim mDuong_Thu_Di_Chi_Tiet As Duong_Thu_Di_Chi_Tiet
        mDuong_Thu_Di_Chi_Tiet = myDuong_Thu_Di.Lay(Duong_Thu_Noi_Thanh)
        Menu_Tieu_De = "Nhờ bưu cục " & mDuong_Thu_Di_Chi_Tiet.Ma_Bc & " - " & mDuong_Thu_Di_Chi_Tiet.Ten_Duong_Thu & " thu hộ"
        _pThamSo.Value = Menu_Tieu_De
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Thoi Gian - "Tu ngay Den ngay"
        Menu_Thoi_Gian = "Từ ngày   " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy") & "   đến ngày   " & DateTime.Parse(CbDen_Ngay.Value).ToString("dd/MM/yyyy")
        _pThamSo.Value = Menu_Thoi_Gian
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ten Dang Nhap
        Menu_Ten_Dang_Nhap = GHo_Ten
        _pThamSo.Value = Menu_Ten_Dang_Nhap
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Dien Thoai
        Menu_Dien_Thoai = IIf(GDien_Thoai.Trim <> "", " Tel : " & GDien_Thoai, GDien_Thoai)
        _pThamSo.Value = Menu_Dien_Thoai
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Dien_Thoai").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Ngay_Thang_Nam
        _pThamSo.Value = GrptNgay_Thang_Nam
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        'Menu Tien Chu - So tien bang chu
        'Lay tong tien vi khong truyen duoc gia tri tu report vao
        myNumber.Number = myE1_No_Le_Phi_HQ.Hai_Quan_Tong_Tien_Theo_Duong_Thu_Noi_Thanh_E1_No_Le_Phi_HQ(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh, Duong_Thu_Noi_Thanh).Tables(0).Rows(0).Item("Tong_Tien")

        'Truyen vao Menu_Tien_Chu
        Menu_Tien_Chu = myNumber.StringNumber & " đồng chẵn./."
        _pThamSo.Value = Menu_Tien_Chu
        pvCollection.Add(_pThamSo)
        RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tien_Chu").ApplyCurrentValues(pvCollection)
        pvCollection.Clear()

        RptBang_Ke_Thue_Hai_Quan.SetDataSource(myTable)
        FrmView.CrystalReportViewer1.ReportSource = RptBang_Ke_Thue_Hai_Quan
        Cursor.Current = Cursors.Default
        'Bat dau in
        If isPreview = True Then
            FrmView.ShowDialog()
        Else
            RptBang_Ke_Thue_Hai_Quan.PrintToPrinter(1, True, 0, 0)
        End If

    End Sub
#End Region

#Region "cbMa_Tinh_KeyDown"
    Private Sub cbMa_Tinh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMa_Tinh.KeyDown
        If e.KeyValue = Keys.Enter Then
            BtnPreview.Select()
        End If
    End Sub

#End Region

#Region "OptTat_Ca_KeyDown"
    Private Sub OptTat_Ca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles OptTat_Ca.KeyDown
        If e.KeyValue = Keys.Enter Then
            BtnPrint.Select()
        End If
    End Sub
#End Region

#Region "-----------OptTat_Ca_Validated---------------"
    Private Sub OptTat_Ca_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptTat_Ca.Validated
        If OptTheo_Tinh.Checked Or OptTat_Ca.Checked Then
            btnExport_Excel.Enabled = True
        Else
            btnExport_Excel.Enabled = False
        End If
    End Sub
#End Region

#Region "cbMa_Tinh_Validated"
    Private Sub cbMa_Tinh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMa_Tinh.Validated
        Dim mCur_Ma_Tinh As Integer
        myMaTinhTra = cbMa_Tinh.Value
        mCur_Ma_Tinh = myDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh
        'Neu la noi thanh thi hien duong thu noi thanh
        If mCur_Ma_Tinh = myMaTinhTra Then
            chkDuong_Thu_Cap_2.Checked = True
        Else
            chkDuong_Thu_Cap_2.Checked = False
        End If

        ''Neu la noi thanh thi hien duong thu noi thanh
        'If mCur_Ma_Tinh = myMaTinhTra Then
        '    Dim myDataSet As New DataSet
        '    'Hien danh sach duong thu di cac huyen cua BD Thanh pho (Duong Thu Noi Thanh)
        '    myDataSet = myDuong_Thu_Di.Duong_Thu_Di_Danh_Sach_Duong_Thu_Noi_Thanh_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Tinh(GBuu_Cuc_Khai_Thac, myMaTinhTra)
        '    cbDuongThuNoiTinh.DataSource = myDataSet
        '    cbDuongThuNoiTinh.DataBind()
        '    Dim mySoDuongThu As Integer
        '    mySoDuongThu = CInt(SetNullValue(myDataSet.Tables(0).Rows.Count, 0))
        '    If mySoDuongThu > 0 Then
        '        GroupBox_DuongThuNoiTinh.Enabled = True
        '        '            optNgoaiThanh.Select()
        '        '           optNgoaiThanh_CheckedChanged(sender, e)
        '    Else
        '        GroupBox_DuongThuNoiTinh.Enabled = False
        '    End If
        'Else
        '    GroupBox_DuongThuNoiTinh.Enabled = False
        'End If
    End Sub
#End Region

#Region "optNoiNgoaiThanh_CheckedChanged"
    Private Sub optNoiNgoaiThanh_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optNoiNgoaiThanh.CheckedChanged
        If optNoiNgoaiThanh.Checked Then
            cbDuongThuNoiTinh.DataSource = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu(myMaTinhTra, 0).Tables(0)
        End If
    End Sub
#End Region

#Region "optNoiThanh_CheckedChanged"
    Private Sub optNoiThanh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNoiThanh.CheckedChanged
        If optNoiThanh.Checked Then
            '    cbDuongThuNoiTinh.DataSource = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu(0, 0).Tables(0)
            'Else
            'Lấy dữ liệu về đường thư ngoại thành
            cbDuongThuNoiTinh.DataSource = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Noi_Ngoai_Thanh(myMaTinhTra).Tables(0)
        End If
    End Sub
#End Region

#Region "optNgoaiThanh_CheckedChanged"
    Private Sub optNgoaiThanh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNgoaiThanh.CheckedChanged
        If optNgoaiThanh.Checked Then
            '    cbDuongThuNoiTinh.DataSource = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu(0, 1).Tables(0)
            'Else
            'Lấy dữ liệu về đường thư ngoại thành
            cbDuongThuNoiTinh.DataSource = myDuong_Thu_Di_Noi_Tinh.Duong_Thu_Di_Noi_Tinh_Danh_Sach_Lay_Boi_Ma_Tinh_Phan_Loai_Duong_Thu(myMaTinhTra, 1).Tables(0)
        End If
    End Sub
#End Region

#Region "BtnExit_Click"
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Close()
    End Sub
#End Region

#Region "chkChuyen_Hoan_CheckedChanged"
    Private Sub chkChuyen_Hoan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChuyen_Hoan.CheckedChanged
        OptTat_Ca.Enabled = Not chkChuyen_Hoan.Checked
        OptTheo_Tinh.Enabled = Not chkChuyen_Hoan.Checked
        OptBuu_Ta_Noi_Bo.Enabled = Not chkChuyen_Hoan.Checked
        cbMa_Tinh.Enabled = Not chkChuyen_Hoan.Checked
        BtnPreview.Enabled = chkChuyen_Hoan.Checked
        BtnPrint.Enabled = chkChuyen_Hoan.Checked
        btnExport_Excel.Enabled = chkChuyen_Hoan.Checked
    End Sub
#End Region

#Region "Combo: Đường thư đóng đi"
    Private Sub Tao_Bang_Buu_Cuc_Noi_Tinh()
        Dim dataTable As New dataTable("Buu_Cuc_Noi_Tinh")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Bc", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Duong_Thu", GetType(String))
        dataTable.Columns.Add(colWork)


        'Them du lieu vao
        Dim row As DataRow = dataTable.NewRow()
        row("Ma_Bc") = 101000
        row("Ten_Duong_Thu") = "HN EMS NT"
        dataTable.Rows.Add(row)

        row = dataTable.NewRow
        row("Ma_Bc") = 701000
        row("Ten_Duong_Thu") = "HCM EMS NT"
        dataTable.Rows.Add(row)

        cbBuuCuc_NoiTinh.DataSource = dataTable
        cbBuuCuc_NoiTinh.DataBind()
    End Sub
#End Region

#Region "chkDuong_Thu_Cap_2_CheckedChanged"
    Private Sub chkDuong_Thu_Cap_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDuong_Thu_Cap_2.CheckedChanged
        'Neu la noi thanh thi hien duong thu noi thanh
        If chkDuong_Thu_Cap_2.Checked Then
            Dim myDataSet As New DataSet
            'Hien danh sach duong thu di cac huyen cua BD Thanh pho (Duong Thu Noi Thanh)
            myDataSet = myDuong_Thu_Di.Duong_Thu_Di_Danh_Sach_Duong_Thu_Noi_Thanh_Lay_Boi_Ma_Bc_Khai_Thac_Ma_Tinh(GBuu_Cuc_Khai_Thac, myMaTinhTra)
            cbDuongThuNoiTinh.DataSource = myDataSet
            cbDuongThuNoiTinh.DataBind()
            GroupBox_DuongThuNoiTinh.Enabled = True
            If cbDuongThuNoiTinh.Rows.Count > 0 Then
                cbDuongThuNoiTinh.Value = cbDuongThuNoiTinh.Rows(0).Cells("Id_Duong_Thu").Value
            Else
                cbDuongThuNoiTinh.Value = DBNull.Value
            End If
            'If Not cbDuongThuNoiTinh.IsDroppedDown Then
            '    cbDuongThuNoiTinh.PerformAction(UltraComboAction.ToggleDropdown)
            'End If
            'Dim mySoDuongThu As Integer
            'mySoDuongThu = CInt(SetNullValue(myDataSet.Tables(0).Rows.Count, 0))
            'If mySoDuongThu > 0 Then
            '    GroupBox_DuongThuNoiTinh.Enabled = True

            'Else
            '    GroupBox_DuongThuNoiTinh.Enabled = False
            'End If
        Else
            cbDuongThuNoiTinh.Value = DBNull.Value
            'If cbDuongThuNoiTinh.IsDroppedDown Then
            '    cbDuongThuNoiTinh.PerformAction(UltraComboAction.CloseDropdown)
            'End If
            GroupBox_DuongThuNoiTinh.Enabled = False
        End If
    End Sub
#End Region

#Region "Ghi dữ liệu ra file Access"
    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Try
            If Not OptTheo_Tinh.Checked Then
                MessageBox.Show("Bạn chỉ có thể xuất dữ liệu ra file Access cho từng tỉnh")
                Exit Sub
            Else
                If MessageBox.Show("Bạn đang chọn kết xuất dữ liệu thuế và lệ phí hải quan cho tỉnh: " & cbMa_Tinh.Value & "?", "Xác nhận thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                    Exit Sub
                End If
                Dim inFileName As String
                'Duong dan file MDB mau
                Const inPathFile As String = "C:\Ems_International\LePhiHQ\"
                'Ten file MDB mau
                Dim sFileName As String
                inFileName = sFileName & "_" & CbTu_Ngay.DateTime.Month.ToString("00") & "_" & CbTu_Ngay.DateTime.Year

                'Open SaveDialog
                With sFileDlg
                    .InitialDirectory = inPathFile
                    .FileName = inFileName
                    .Title = "Chon ten File"
                    .DefaultExt = "*.mdb"
                    .Filter = "Mdb (*.mdb)|*.mdb"
                    .ShowDialog()
                End With

                'Thực hiện
                Dim strPath As String    'Luu thu muc chua file dich
                strPath = Directory.GetParent(inPathFile).ToString
                'Kiem tra xem thu muc co ton tai khong
                If Directory.Exists(strPath) = False Then
                    MsgBox("Không tồn tại thư mục này trên máy tính của bạn, Mời bạn chọn lại", MsgBoxStyle.Information, "Thông báo")
                    btnFile.Select()
                    Exit Sub
                End If
                'Kiem tra ngay nhap vao co hop le khong
                If CbTu_Ngay.Value > CbDen_Ngay.Value Then
                    MsgBox("Từ ngày không được lớn hơn đến ngày, mời nhập lại thông tin ngày tháng", MsgBoxStyle.Information, "Thông báo")
                    CbTu_Ngay.Select()
                    Exit Sub
                End If
                'Neu da ton tai File dich roi thi xoa
                If File.Exists(inPathFile) = True Then
                    File.Delete(inPathFile)
                End If
                'Ket noi MDB, lay du lieu tu SQL va insert vao MDB
                'If GetData() = False Then Exit Sub
                'Khong cho Active btnTHUC_HIEN sau khi da click
                'GrBox2.Enabled = False
                'btnThuc_Hien.Enabled = False
                'Chuyen File mau thanh file dich
                File.Copy(inPathFile & sFileName & ".MDB", inPathFile)
                'Focus vao cbTu_Ngay sau khi da hoan tat cong viec
                CbTu_Ngay.Select()
                'Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "-------------btnExport_Excel_Click------------"
    Private Sub btnExport_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport_Excel.Click
        Dim strFilePath As String
        Dim mDataSet As New DataSet
        'Open SaveDialog
        With sFileDlg
            .Title = "Chon ten File"
            .DefaultExt = "*.xls"
            .Filter = "Xls (*.xls)|*.xls"
            .ShowDialog()
        End With
        If sFileDlg.FileName <> "" Then
            strFilePath = sFileDlg.FileName
            mDataSet = Get_Data_Export()
            If mDataSet.Tables(0).Rows.Count <= 0 Then  'khong co du lieu
                MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else  'co du lieu
                Export_To_Excel_From_DataSet(mDataSet, strFilePath)
            End If
        End If
    End Sub
#End Region

#Region "-------------Get_Data_Export-------------"
    Private Function Get_Data_Export() As DataSet
        Dim myE1_Di As New E1_Di(GConnectionString)
        Dim myMa_Don_Vi As New Ma_Don_Vi(GConnectionString)
        Dim myDataSet As New DataSet
        Dim myTable As New DataTable

        If chkChuyen_Hoan.Checked Then
            myDataSet = myE1_Di.Hai_Quan_Danh_Sach_E1_Di_Chuyen_Hoan_Xuat_Ra_Excel(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac)
        Else
            'Lay du lieu chi tiet cho bao cao
            If OptTheo_Tinh.Checked Then  'theo tung tinh
                myDataSet = myE1_No_Le_Phi_HQ.Hai_Quan_Danh_Sach_E1_No_Le_Phi_HQ_Theo_Tinh_Xuat_Ra_Excel(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, cbMa_Tinh.Value)
            ElseIf OptTat_Ca.Checked Then
                myDataSet = myE1_No_Le_Phi_HQ.Hai_Quan_Danh_Sach_E1_No_Le_Phi_HQ_Cac_Tinh_Xuat_Ra_Excel(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac)
            Else
                myDataSet = myE1_No_Le_Phi_HQ.Hai_Quan_Danh_Sach_E1_No_Le_Phi_HQ_Theo_Buu_Ta_Noi_Bo_Xuat_Ra_Excel(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac)
            End If
        End If
        Return myDataSet
    End Function

#End Region

#Region "btn_Ban_Ke_Doi_Soat_HQ_Click"
    Private Sub btn_Ban_Ke_Doi_Soat_HQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ban_Ke_Doi_Soat_HQ.Click
        Dim mTu_Ngay, mDen_Ngay As Integer
        mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value)
        mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value)
        If (mTu_Ngay <> mDen_Ngay) Then
            MessageBox.Show("Báo cáo này chỉ in theo từng ngày!!! Bạn phải nhập từ ngày và đến ngày bằng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbDen_Ngay.Select()
        Else
            In_Ban_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan_Theo_Ngay(mTu_Ngay, mDen_Ngay)
        End If
    End Sub
#End Region

#Region "--------------In_Ban_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan_Theo_Ngay-------------"
    Private Sub In_Ban_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan_Theo_Ngay(ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer)
        Try
            Dim myTable As New DataTable
            Dim RptBang_Ke_Thue_Hai_Quan As New RptBang_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim FrmView As New FrmViewReports
            Dim Menu_Don_Vi As String
            Dim Menu_Trai As String
            Dim Menu_Tieu_De As String
            Dim Menu_Thoi_Gian As String
            Dim Menu_Ten_Dang_Nhap As String
            Dim mDanh_Muc_Bc As New Danh_Muc_BC(GConnectionString)
            'Dim Menu_Ngay_Thang_Nam As String
            Dim Menu_Tien_Chu As String
            Dim myNumber As New ConvertNumberToString

            Cursor.Current = Cursors.WaitCursor
            'Lay du lieu chi tiet cho bao cao
            myTable = myE1_No_Le_Phi_HQ.Hai_Quan_Ban_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan_Theo_Ngay(mTu_Ngay, mDen_Ngay, GBuu_Cuc_Khai_Thac).Tables(0)
            If myTable.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu cho báo cáo này!!! Hãy kiểm tra lại ngày in báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Tiep tuc thuc hien neu co du lieu
            'Thong tin chi tiet
            myTable.TableName = "Bang_Ke_Theo_Doi_Thue_Le_Phi_Hai_Quan"
            'Thong tin header va footer dua vao thong qua Paramete
            'Menu Trai - Ma theo doi don vi
            Menu_Trai = GBuu_Cuc_Khai_Thac & " - " & mDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ten_Buu_Cuc
            _pThamSo.Value = Menu_Trai
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Trai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Tieu De 
            Menu_Tieu_De = ""
            _pThamSo.Value = Menu_Tieu_De
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tieu_De").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Thoi Gian - "Tu ngay Den ngay"
            Menu_Thoi_Gian = "Ngày khai thác:   " & DateTime.Parse(CbTu_Ngay.Value).ToString("dd/MM/yyyy")
            _pThamSo.Value = Menu_Thoi_Gian
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Thoi_Gian").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Ten Dang Nhap
            Menu_Ten_Dang_Nhap = GHo_Ten
            _pThamSo.Value = Menu_Ten_Dang_Nhap
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Dien Thoai
            If mDanh_Muc_Bc.Lay(GBuu_Cuc_Khai_Thac).Ma_Tinh > 600000 Then
                Menu_Don_Vi = "CHI NHÁNH TẠI TP HỒ CHÍ MINH"
            Else
                Menu_Don_Vi = "PHÒNG TÀI CHÍNH KẾ TOÁN"
            End If
            _pThamSo.Value = Menu_Don_Vi
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Don_Vi").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Ngay_Thang_Nam
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Menu Tien Chu - So tien bang chu
            'Lay tong tien vi khong truyen duoc gia tri tu report vao
            'myNumber.Number = myE1_Di.Hai_Quan_Tong_Tien_Theo_Ma_Tinh(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0).Rows(0).Item("Tong_Tien")
            'myNumber.Number = myE1_No_Le_Phi_HQ.Hai_Quan_Tong_Tien_Theo_Ma_Tinh_E1_No_Le_Phi_HQ(Ham_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), Ham_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), GBuu_Cuc_Khai_Thac, Ma_Tinh).Tables(0).Rows(0).Item("Tong_Tien")
            'Truyen vao Menu_Tien_Chu
            Menu_Tien_Chu = ""
            _pThamSo.Value = Menu_Tien_Chu
            pvCollection.Add(_pThamSo)
            RptBang_Ke_Thue_Hai_Quan.DataDefinition.ParameterFields("Menu_Tien_Chu").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptBang_Ke_Thue_Hai_Quan.SetDataSource(myTable)
            FrmView.CrystalReportViewer1.ReportSource = RptBang_Ke_Thue_Hai_Quan
            Cursor.Current = Cursors.Default

            'Bat dau in
            FrmView.ShowDialog()
        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "==============Tab kết xuất dữ liệu cho kế toán=============="

#Region "TabControl"
#Region "btnThongTin_Click"
    Private Sub btnThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThongTin.Click
        Try
            If dtpTuNgay.Value > dtpDenNgay.Value Then
                MessageBox.Show("Từ ngày không được phép lớn hơn đến ngày!!! Mời bạn kiểm tra lại thông tin ngày đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpTuNgay.Select()
                Exit Sub
            End If
            MessageBox.Show("Dữ liệu này được tổng hợp từ nhiều bảng khác nhau nên sẽ mất một khoảng thời gian nhất định." & vbNewLine & "Mong bạn đừng sốt ruột và hãy chờ trong một vài phút.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim mData As DataTable
            'Thong tin E1_Di (Khai thác Quốc Tế)
            mData = Load_Data_E1_Di(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), optCacTinh.Checked)
            DataGrid_Ma_Tinh_E1_Di(mData)
            If mData.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu theo yêu cầu!!! Mời bạn kiểm tra lại thông tin ngày đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtpTuNgay.Select()
                Exit Sub
            End If
            'Thông tin E1_No (Kế toán)
            mData = Load_Data_E1_No(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), optCacTinh.Checked)
            DataGrid_Ma_Tinh_E1_No(mData)
        Catch ex As Exception
            MessageBox.Show("Error at: ------btnThongTin_Click------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnKetXuat_Click"
    Private Sub btnKetXuat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKetXuat.Click
        Try
            Dim idx As Integer
            Dim i As Integer
            Dim mTong_So_E1_Di As Integer
            'Kiem tra xem da check chưa
            If Grid_Ma_Tinh_E1_Di_Row_Check() = 0 Then
                MessageBox.Show("Bạn chưa chọn thông tin cần kết xuất!!!" & vbNewLine & "Mời bạn chọn bằng cách tích vào ô Chọn trong danh sách Thông tin Khai thác Quốc tế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Hỏi lại trước khi thực hiện
            If Not MessageBox.Show("Bạn có chắc chắn muốn kết xuất thông tin kế toán không?" & vbNewLine & "Hãy chắc chắn vì thông tin kế toán cũ sẽ bị xoá hết và thay bằng thông tin mới." & vbNewLine & "Thông tin kết xuất được lấy từ nhiều bảng dữ liệu khác nhau nên sẽ mất một khoảng thời gian nhất định." & vbNewLine & "Mong bạn đừng sốt ruột và hãy chờ trong một vài phút", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Exit Sub
            End If

            'Căn vào giữa Form và hiện lại
            grbTienTrinh.Visible = True
            grbTienTrinh.Left = (Me.Width - grbTienTrinh.Width) / 2
            grbTienTrinh.Top = (Me.Height - grbTienTrinh.Height) / 2

            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            Dim mSo_Dong_Duoc_Ket_Xuat As Integer
            mSo_Dong_Duoc_Ket_Xuat = 0
            For idx = 0 To dgMa_Tinh_E1_Di.Rows.Count - 1
                If dgMa_Tinh_E1_Di.Rows(idx).Cells("Chon").Value = True Then
                    dgMa_Tinh_E1_Di.ActiveRow = dgMa_Tinh_E1_Di.Rows(idx)
                    'Kiem tra Khoa So Lieu 
                    If Kiem_Tra_Khoa_So_Lieu(dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value) Then
                        Me.ActiveForm.Cursor.Current = Cursors.Default
                        If optCacTinh.Checked Then
                            MessageBox.Show("Mã tỉnh : " & dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value & ", đã khoá số liệu nên không kết xuất thông tin cho mã tỉnh này được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Bưu tá nội bộ mã : " & dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value & ", đã khoá số liệu nên không kết xuất thông tin cho đường thư này được!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
                        'Lay thong tin tong so E1_No theo Ma_Tinh
                        Dim mDataKetXuat As DataTable
                        mDataKetXuat = myE1_Di.E1_Di_Danh_Sach_Ket_Xuat_Ke_Toan_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), dgMa_Tinh_E1_Di.Rows(idx).Cells("Don_Vi").Value, dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value).Tables(0)
                        mTong_So_E1_Di = mDataKetXuat.Rows.Count
                        'Thay doi thong tin GroupBox Proccess
                        If optCacTinh.Checked Then
                            grbTienTrinh.Text = "Đang kết xuất mã tỉnh:  " & dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value & "  (Tổng số: " & mTong_So_E1_Di.ToString & ") ......"
                        Else
                            grbTienTrinh.Text = "Đang kết xuất bưu tá nội bộ mã:  " & dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Value & "  (Tổng số: " & mTong_So_E1_Di.ToString & ") ......"
                        End If
                        PrbTienTrinh.Maximum = mTong_So_E1_Di
                        PrbTienTrinh.Step = 1
                        PrbTienTrinh.Value = 1
                        For i = 0 To mDataKetXuat.Rows.Count - 1
                            PrbTienTrinh.PerformStep()
                            'cap nhat tu E1_Di vao E1_No
                            Cap_Nhat_E1_No_Le_Phi_HQ_Tu_E1_Di(mDataKetXuat.Rows(i))
                            PrbTienTrinh.Text = "( " & PrbTienTrinh.Value & "  /  " & PrbTienTrinh.Maximum & " )"
                            Application.DoEvents()
                        Next i
                        mSo_Dong_Duoc_Ket_Xuat = mSo_Dong_Duoc_Ket_Xuat + 1
                    End If
                    dgMa_Tinh_E1_Di.Rows(idx).Cells("Chon").Value = False
                End If
            Next
            Me.ActiveForm.Cursor.Current = Cursors.Default
            grbTienTrinh.Visible = False
            If mSo_Dong_Duoc_Ket_Xuat > 0 Then
                MessageBox.Show("Complete !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'refresh form
            'Thông tin E1_No (Kế toán)
            Dim mData As DataTable
            mData = Load_Data_E1_No(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), optCacTinh.Checked)
            DataGrid_Ma_Tinh_E1_No(mData)
            'Uncheck
            chkE1_Di.Checked = False
            chkE1_No.Checked = False
        Catch ex As Exception
            MessageBox.Show("Error at: ------btnKetXuat_Click------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnKhoa_Click"
    Private Sub btnKhoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhoa.Click
        Try
            Dim idx As Integer
            'Kiem tra đã check chọn chưa
            If Grid_Ma_Tinh_E1_No_Row_Check() = 0 Then
                If optCacTinh.Checked Then
                    MessageBox.Show("Bạn chưa chọn Tỉnh nào cần khoá số liệu!!!" & vbNewLine & "Mời bạn chọn bằng cách tích vào ô Chọn trong danh sách Thông tin Kế toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    MessageBox.Show("Bạn chưa chọn Đường thư bưu tá nào cần khoá số liệu!!!" & vbNewLine & "Mời bạn chọn bằng cách tích vào ô Chọn trong danh sách Thông tin Kế toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            'Hỏi lại trước khi thực hiện
            If Not MessageBox.Show("Bạn có chắc chắn muốn chốt số liệu kế toán không?" & vbNewLine & "Vui lòng chờ trong giây lát để chương trình khoá số liệu Kế toán. Xin cảm ơn !!!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Exit Sub
            End If
            'Thực hiện
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
                If dgMa_Tinh_E1_No.Rows(idx).Cells("Chon").Value Then
                    'Khoa so lieu trong database
                    Chot_So_Lieu(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), optCacTinh.Checked, dgMa_Tinh_E1_No.Rows(idx).Cells("Ma_Tinh").Value)
                    'refresh tren luoi
                    dgMa_Tinh_E1_No.Rows(idx).Cells("Chot_SL").Value = True
                End If
            Next
            Me.ActiveForm.Cursor.Current = Cursors.Default
            MessageBox.Show("Đã khoá số liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error at: ------btnKhoa_Click------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnMo_Khoa_Click"
    Private Sub btnMo_Khoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMo_Khoa.Click
        Try
            Dim idx As Integer
            'Kiem tra đã check chọn chưa
            If Grid_Ma_Tinh_E1_No_Row_Check() = 0 Then
                If optCacTinh.Checked Then
                    MessageBox.Show("Bạn chưa chọn Tỉnh nào cần mở khoá số liệu!!!" & vbNewLine & "Mời bạn chọn bằng cách tích vào ô Chọn trong danh sách Thông tin Kế toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    MessageBox.Show("Bạn chưa chọn Đường thư bưu tá nào cần mở khoá số liệu!!!" & vbNewLine & "Mời bạn chọn bằng cách tích vào ô Chọn trong danh sách Thông tin Kế toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            'Hỏi lại trước khi thực hiện
            If Not MessageBox.Show("Bạn có chắc chắn muốn mở khoá số liệu kế toán không?" & vbNewLine & "Vui lòng chờ trong giây lát để chương trình mở khoá số liệu Kế toán. Xin cảm ơn !!!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Exit Sub
            End If
            'Thực hiện
            Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
            For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
                If dgMa_Tinh_E1_No.Rows(idx).Cells("Chon").Value Then
                    'Khoa so lieu trong database
                    Bo_Chot_So_Lieu(GBuu_Cuc_Khai_Thac, myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value), myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value), optCacTinh.Checked, dgMa_Tinh_E1_No.Rows(idx).Cells("Ma_Tinh").Value)
                    'refresh tren luoi
                    dgMa_Tinh_E1_No.Rows(idx).Cells("Chot_SL").Value = False
                End If
            Next
            Me.ActiveForm.Cursor.Current = Cursors.Default
            MessageBox.Show("Đã mở khoá số liệu thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error at: ------btnMo_Khoa_Click------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnDong_Click"
    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnXoa_Click"
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim mSo_Dong_Chon As Integer
        Dim mSo_Dong_Xoa As Integer
        Dim mIndex_Row_Select As Integer
        Dim i As Integer
        mSo_Dong_Chon = 0
        mSo_Dong_Xoa = 0
        For i = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
            If dgMa_Tinh_E1_No.Rows(i).Cells("Chon").Value Then
                mSo_Dong_Chon = mSo_Dong_Chon + 1
                mIndex_Row_Select = i
            End If
        Next
        If mSo_Dong_Chon = 0 Then
            MessageBox.Show("Bạn chưa chọn dòng dữ liệu trong danh sách kế toán cần xoá. Mời bạn chọn bằng cách tích vào ô chọn tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mSo_Dong_Xoa = 0
        ElseIf mSo_Dong_Chon = 1 Then
            If MessageBox.Show("Bạn có chắc chắn muốn xoá thông tin kế toán của mã ===" & dgMa_Tinh_E1_No.Rows(mIndex_Row_Select).Cells("Ma_Tinh").Value & "=== không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                'Xoa trong databse
                If Xoa_Thong_Tin_Ke_Toan(dgMa_Tinh_E1_No.Rows(mIndex_Row_Select).Cells("Ma_Tinh").Value) Then
                    'Xoa tren luoi
                    dgMa_Tinh_E1_No.Rows(mIndex_Row_Select).Delete(False)
                    'Tang them 1 dong duoc xoa
                    mSo_Dong_Xoa = mSo_Dong_Xoa + 1
                End If
            End If
        Else
            If MessageBox.Show("Bạn có chắc chắn muốn xoá " & mSo_Dong_Chon & " dòng thông tin kế toán không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                For i = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
                    If i = dgMa_Tinh_E1_No.Rows.Count Then
                        Exit For
                    End If
                    If dgMa_Tinh_E1_No.Rows(i).Cells("Chon").Value Then
                        'Xoa trong database
                        If Xoa_Thong_Tin_Ke_Toan(dgMa_Tinh_E1_No.Rows(i).Cells("Ma_Tinh").Value) Then
                            'Xoa tren luoi
                            dgMa_Tinh_E1_No.Rows(i).Delete(False)
                            'Tang them 1 dong duoc xoa
                            mSo_Dong_Xoa = mSo_Dong_Xoa + 1
                            'Lui lai index : 1 đơn vị
                            i = i - 1
                        End If
                    End If
                Next
            End If
        End If
        Calculate_Ma_Tinh_E1_No()
        If mSo_Dong_Xoa > 0 Then
            MessageBox.Show("Đã xoá thành công ===" & mSo_Dong_Xoa & "=== dòng dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "dtpTuNgay_GotFocus"
    Private Sub dtpTuNgay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTuNgay.GotFocus
        dtpTuNgay.SelectionStart = 0
        dtpTuNgay.SelectionLength = dtpTuNgay.Text.Length
    End Sub
#End Region

#Region "dtpDenNgay_GotFocus"
    Private Sub dtpDenNgay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDenNgay.GotFocus
        dtpDenNgay.SelectionStart = 0
        dtpDenNgay.SelectionLength = dtpDenNgay.Text.Length
    End Sub
#End Region

#Region "==========dgMa_Tinh_E1_No=========="
#Region "dgMa_Tinh_E1_No_InitializeLayout"
    Private Sub dgMa_Tinh_E1_No_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMa_Tinh_E1_No.InitializeLayout
        Try
            Dim idx As Integer
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chot_SL").Style = ColumnStyle.CheckBox
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
            If optCacTinh.Checked Then
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tinh").Header.Caption = "Mã tỉnh"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Tinh").Header.Caption = "Tên tỉnh"
            Else
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tinh").Header.Caption = "Đ.Thư"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Tinh").Header.Caption = "Tên đường thư"
            End If
            Calculate_Ma_Tinh_E1_No()
        Catch ex As Exception
            MessageBox.Show("Error at: ------dgMa_Tinh_E1_No_InitializeLayout------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#Region "==========dgMa_Tinh_E1_Di=========="
#Region "dgMa_Tinh_E1_Di_InitializeLayout"
    Private Sub dgMa_Tinh_E1_Di_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMa_Tinh_E1_Di.InitializeLayout
        Try
            Dim idx As Integer
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
            If optCacTinh.Checked Then
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tinh").Header.Caption = "Mã tỉnh"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Tinh").Header.Caption = "Tên tỉnh"
            Else
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ma_Tinh").Header.Caption = "Đ.Thư"
                myGridKeyDown.DisplayLayout.Bands(0).Columns("Ten_Tinh").Header.Caption = "Tên đường thư"
            End If
            Calculate_Ma_Tinh_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ------dgMa_Tinh_E1_Di_InitializeLayout------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#Region "chkE1_Di_CheckedChanged"
    Private Sub chkE1_Di_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkE1_Di.CheckedChanged
        Dim idx As Integer
        For idx = 0 To dgMa_Tinh_E1_Di.Rows.Count - 1
            dgMa_Tinh_E1_Di.Rows(idx).Cells("Chon").Value = chkE1_Di.Checked
        Next
    End Sub
#End Region

#Region "chkE1_No_CheckedChanged"
    Private Sub chkE1_No_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkE1_No.CheckedChanged
        Dim idx As Integer
        For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
            dgMa_Tinh_E1_No.Rows(idx).Cells("Chon").Value = chkE1_No.Checked
        Next
    End Sub
#End Region

#Region "==========TabControl_KeyDown=========="
    Private Sub dtpTuNgay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTuNgay.KeyDown, dtpDenNgay.KeyDown, optCacTinh.KeyDown, optBuuTa.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#End Region

#Region "Hàm người dùng"

#Region "DataGrid_Ma_Tinh_E1_Di"
    Private Sub DataGrid_Ma_Tinh_E1_Di(ByVal mData As DataTable)
        dgMa_Tinh_E1_Di.DataSource = mData
        dgMa_Tinh_E1_Di.DataBind()
    End Sub
#End Region

#Region "Load_Data_E1_Di"
    Private Function Load_Data_E1_Di(ByVal mMa_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mIs_Cac_Tinh As Boolean) As DataTable
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
        Try
            Dim mData As DataTable
            If mIs_Cac_Tinh Then  'cac tinh
                mData = myE1_Di.E1_Di_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 2).Tables(0)
            Else  'buu ta noi bo
                mData = myE1_Di.E1_Di_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 1).Tables(0)
            End If
            Me.ActiveForm.Cursor.Current = Cursors.Default
            Return mData
        Catch ex As Exception
            Me.ActiveForm.Cursor.Current = Cursors.Default
            MessageBox.Show("Error at: ------Load_Data_E1_Di------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#Region "DataGrid_Ma_Tinh_E1_No"
    Private Sub DataGrid_Ma_Tinh_E1_No(ByVal mData As DataTable)
        dgMa_Tinh_E1_No.DataSource = mData
        dgMa_Tinh_E1_No.DataBind()
    End Sub
#End Region

#Region "Load_Data_E1_No"
    Private Function Load_Data_E1_No(ByVal Ma_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mIs_Cac_Tinh As Boolean) As DataTable
        Me.ActiveForm.Cursor.Current = Cursors.WaitCursor
        Try
            Dim mData As DataTable
            If mIs_Cac_Tinh Then  'Theo tinh
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, mTu_Ngay, mDen_Ngay, 2).Tables(0)
            Else   'Buu ta noi bo (theo duong thu)
                mData = myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Danh_Sach_Theo_Ma_Tinh_Tien_Thue_Le_Phi_HQ_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, mTu_Ngay, mDen_Ngay, 1).Tables(0)
            End If
            Me.ActiveForm.Cursor.Current = Cursors.Default
            Return mData
        Catch ex As Exception
            Me.ActiveForm.Cursor.Current = Cursors.Default
            MessageBox.Show("Error at: ------Load_Data_E1_No------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Grid_Ma_Tinh_E1_Di_Row_Check"
    Private Function Grid_Ma_Tinh_E1_Di_Row_Check() As Integer
        Try
            Dim idx As Integer
            Dim mRow_Check As Integer
            For idx = 0 To dgMa_Tinh_E1_Di.Rows.Count - 1
                If dgMa_Tinh_E1_Di.Rows(idx).Cells("Chon").Value Then
                    mRow_Check = mRow_Check + 1
                End If
            Next
            Return mRow_Check
        Catch ex As Exception
            MessageBox.Show("Error at: ------Grid_Ma_Tinh_E1_Di_Row_Check------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region

#Region "Grid_Ma_Tinh_E1_No_Row_Check"
    Private Function Grid_Ma_Tinh_E1_No_Row_Check() As Integer
        Try
            Dim idx As Integer
            Dim mRow_Check As Integer
            For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
                If dgMa_Tinh_E1_No.Rows(idx).Cells("Chon").Value Then
                    mRow_Check = mRow_Check + 1
                End If
            Next
            Return mRow_Check
        Catch ex As Exception
            MessageBox.Show("Error at: ------Grid_Ma_Tinh_E1_No_Row_Check------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region

#Region "Kiem_Tra_Khoa_So_Lieu_Theo_Tinh"
    Private Function Kiem_Tra_Khoa_So_Lieu(ByVal mMa_Tinh As Integer) As Boolean
        Try
            Dim idx As Integer
            For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
                If dgMa_Tinh_E1_No.Rows(idx).Cells("Ma_Tinh").Value = mMa_Tinh Then
                    If dgMa_Tinh_E1_No.Rows(idx).Cells("Chot_SL").Value = 1 Then
                        Return True
                        Exit For
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            MessageBox.Show("Error at: ------Kiem_Tra_Khoa_So_Lieu------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Lay_Tong_So_E1_Di"
    Private Function Lay_Tong_So_E1_Di(ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mIs_Cac_Tinh As Boolean, ByVal mMa_Tinh As Integer) As Integer
        Try
            Dim mTong_So As Integer
            If mIs_Cac_Tinh Then  'lay tong so theo tinh

            Else  'lay tong so theo duong thu buu ta noi bo

            End If
            Return mTong_So
        Catch ex As Exception
            MessageBox.Show("Error at: ------Lay_Tong_So_E1_Di------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
#End Region

#Region "Chot_So_Lieu"
    Private Sub Chot_So_Lieu(ByVal mMa_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mIs_Cac_Tinh As Boolean, ByVal mMa_Tinh As Integer)
        Try
            If mIs_Cac_Tinh Then 'Khoa so lieu E1_No Theo Ma_Tinh
                myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Cap_Nhat_Chot_SL_Theo_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 2, mMa_Tinh, True)
            Else 'Khoa so lieu E1_No Theo Đường thư bưu tá nội bộ
                myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Cap_Nhat_Chot_SL_Theo_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 1, mMa_Tinh, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Error at: ------Chot_So_Lieu------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Bo_Chot_So_Lieu"
    Private Sub Bo_Chot_So_Lieu(ByVal mMa_Bc_Khai_Thac As Integer, ByVal mTu_Ngay As Integer, ByVal mDen_Ngay As Integer, ByVal mIs_Cac_Tinh As Boolean, ByVal mMa_Tinh As Integer)
        Try
            If mIs_Cac_Tinh Then 'Khoa so lieu E1_No Theo Ma_Tinh
                myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Cap_Nhat_Chot_SL_Theo_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 2, mMa_Tinh, False)
            Else 'Khoa so lieu E1_No Theo Đường thư bưu tá nội bộ
                myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Cap_Nhat_Chot_SL_Theo_Tu_Ngay_Den_Ngay(mMa_Bc_Khai_Thac, mTu_Ngay, mDen_Ngay, 1, mMa_Tinh, False)
            End If
        Catch ex As Exception
            MessageBox.Show("Error at: ------Bo_Chot_So_Lieu------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Calculate_Ma_Tinh_E1_Di"
    Private Sub Calculate_Ma_Tinh_E1_Di()
        Dim idx As Integer
        Dim mSo_Luong As Integer
        For idx = 0 To dgMa_Tinh_E1_Di.Rows.Count - 1
            If dgMa_Tinh_E1_Di.Rows(idx).Cells("Ma_Tinh").Text <> "" Then
                mSo_Luong = mSo_Luong + 1
            End If
        Next
        txtTruyen.Text = mSo_Luong.ToString
    End Sub
#End Region

#Region "Calculate_Ma_Tinh_E1_No"
    Private Sub Calculate_Ma_Tinh_E1_No()
        Dim idx As Integer
        Dim mSo_Luong As Integer
        For idx = 0 To dgMa_Tinh_E1_No.Rows.Count - 1
            If dgMa_Tinh_E1_No.Rows(idx).Cells("Ma_Tinh").Text <> "" Then
                mSo_Luong = mSo_Luong + 1
            End If
        Next
        txtNhan.Text = mSo_Luong.ToString
    End Sub
#End Region

#Region "Cap_Nhat_E1_No_Le_Phi_HQ_Tu_E1_Di"
    Private Sub Cap_Nhat_E1_No_Le_Phi_HQ_Tu_E1_Di(ByVal mRow As DataRow)
        Try
            Dim mE1_No_Le_Phi_HQ_Chi_Tiet As New E1_No_Le_Phi_HQ_Chi_Tiet
            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_E1 = mRow.Item("Id_E1")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_E2 = mRow.Item("Id_E2")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Chuyen_Thu = mRow.Item("Id_Chuyen_Thu")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Duong_Thu = mRow.Item("Id_Duong_Thu")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Khai_Thac = mRow.Item("Ma_Bc_Khai_Thac")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_Dong = mRow.Item("Ngay_Dong")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Gio_Dong = mRow.Item("Gio_Dong")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Tinh = mRow.Item("Ma_Tinh")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Don_Vi = mRow.Item("Don_Vi")
            mE1_No_Le_Phi_HQ_Chi_Tiet.STT = mRow.Item("STT")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Nhan = mRow.Item("Nuoc_Nhan")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Nhan = mRow.Item("Ma_Bc_Nhan")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_E1 = mRow.Item("Ma_E1")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Tra = mRow.Item("Nuoc_Tra")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Tra = mRow.Item("Ma_Bc_Tra")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Khoi_Luong = mRow.Item("Khoi_Luong")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Phan_Loai = mRow.Item("Phan_Loai")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Gia_Tri_Hang = mRow.Item("Gia_Tri_Hang")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_KH = mRow.Item("Ma_KH")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Gui = mRow.Item("Nguoi_Gui")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Nhan = mRow.Item("Nguoi_Nhan")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Gui = mRow.Item("Dia_Chi_Gui")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Nhan = mRow.Item("Dia_Chi_Nhan")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Gui = mRow.Item("Dien_Thoai_Gui")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Nhan = mRow.Item("Dien_Thoai_Nhan")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ghi_Chu = mRow.Item("Ghi_Chu")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_Den_VN = mRow.Item("Ngay_Den_VN")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Nguoi_Dung = mRow.Item("Id_Nguoi_Dung")
            mE1_No_Le_Phi_HQ_Chi_Tiet.So_TKHQ = mRow.Item("So_TKHQ")
            mE1_No_Le_Phi_HQ_Chi_Tiet.So_Bien_Lai = mRow.Item("So_Bien_Lai")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_NK = mRow.Item("Thue_NK")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_VAT = mRow.Item("Thue_VAT")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Dac_Biet = mRow.Item("Thue_Dac_Biet")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Tieu_Thu = mRow.Item("Thue_Tieu_Thu")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Qua_Tang = mRow.Item("Thue_Qua_Tang")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Han_Ngach = mRow.Item("Thue_Han_Ngach")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Uu_Dai = mRow.Item("Thue_Uu_Dai")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue = mRow.Item("Tong_Thue")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_HQ = mRow.Item("Le_Phi_HQ")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_VH = mRow.Item("Le_Phi_VH")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_YT = mRow.Item("Le_Phi_YT")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_DV = mRow.Item("Le_Phi_DV")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_TV = mRow.Item("Le_Phi_TV")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_Khac = mRow.Item("Le_Phi_Khac")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Le_Phi = mRow.Item("Tong_Le_Phi")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue_Le_Phi = mRow.Item("Tong_Thue_Le_Phi")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Chot_SL = mRow.Item("Chot_SL")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Da_Truyen = mRow.Item("Da_Truyen")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_He_Thong = mRow.Item("Ngay_He_Thong")
            mE1_No_Le_Phi_HQ_Chi_Tiet.Gio_He_Thong = mRow.Item("Gio_He_Thong")


            myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Cap_Nhat_Them(mE1_No_Le_Phi_HQ_Chi_Tiet.Id_E1, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_E2, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Chuyen_Thu, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Duong_Thu, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Khai_Thac, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_Dong, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Gio_Dong, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Tinh, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Don_Vi, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.STT, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Nhan, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Nhan, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_E1, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Nuoc_Tra, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_Bc_Tra, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Khoi_Luong, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Phan_Loai, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Gia_Tri_Hang, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ma_KH, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Gui, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Nguoi_Nhan, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Gui, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Dia_Chi_Nhan, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Gui, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Dien_Thoai_Nhan, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ghi_Chu, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_Den_VN, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Id_Nguoi_Dung, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.So_TKHQ, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.So_Bien_Lai, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_NK, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_VAT, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Dac_Biet, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Tieu_Thu, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Qua_Tang, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Han_Ngach, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Thue_Uu_Dai, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_HQ, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_VH, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_YT, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_DV, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_TV, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Le_Phi_Khac, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Le_Phi, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Tong_Thue_Le_Phi, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Chot_SL, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Da_Truyen, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Ngay_He_Thong, _
                                                            mE1_No_Le_Phi_HQ_Chi_Tiet.Gio_He_Thong)

        Catch ex As Exception
            MessageBox.Show("Error at: ------Cap_Nhat_E1_No_Le_Phi_HQ_Tu_E1_Di------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Xoa_Thong_Tin_Ke_Toan"
    Private Function Xoa_Thong_Tin_Ke_Toan(ByVal mMa_Don_Vi As Integer) As Boolean
        Dim mTu_Ngay As Integer
        Dim mDen_Ngay As Integer
        Dim mId_Duong_Thu As String
        Dim mMa_Tinh As Integer
        Dim mLoai As Integer
        Try
            mTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value)
            mDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            If optCacTinh.Checked Then   'Theo tinh
                mLoai = 2
                mMa_Tinh = mMa_Don_Vi
                mId_Duong_Thu = ""
            Else    'Theo duong thu buu ta noi bo
                mLoai = 1
                mMa_Tinh = 0
                mId_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, mMa_Don_Vi)
            End If
            myE1_No_Le_Phi_HQ.E1_No_Le_Phi_HQ_Xoa_Theo_Ma_Don_Vi_Tu_Ngay_Den_Ngay(mLoai, GBuu_Cuc_Khai_Thac, mTu_Ngay, mDen_Ngay, mMa_Tinh, mId_Duong_Thu)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#End Region

#End Region

#Region "==============Tab nhập trạng thái chuyển hoàn=============="
#Region "TabControl"
#Region "btnThong_Tin_Chuyen_Hoan_Click"
    Private Sub btnThong_Tin_Chuyen_Hoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThong_Tin_Chuyen_Hoan.Click
        Try
            If cbDuong_Thu_Chuyen_Hoan.Value = Nothing Or cbDuong_Thu_Chuyen_Hoan.Value Is DBNull.Value Then
                MessageBox.Show("Bạn chưa chọn đường thư chuyển hoàn! Mời bạn chọn 1 trong danh sách đường thư chuyển hoàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            DataGrid_E1_Nhap_Chuyen_Hoan()
            If dgE1_Nhap_Chuyen_Hoan.Rows.Count > 0 Then
                Dim mMa_E1 As String
                mMa_E1 = dgE1_Nhap_Chuyen_Hoan.Rows(0).Cells("Ma_E1").Text
                If mMa_E1 <> "" Then
                    DataGrid_E1_Di_Chuyen_Hoan(mMa_E1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error At : --------btnThong_Tin_Chuyen_Hoan_Click----------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "btnThoat_Chuyen_Hoan_Click"
    Private Sub btnThoat_Chuyen_Hoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat_Chuyen_Hoan.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnNhap_Chuyen_Hoan_Click"
    Private Sub btnNhap_Chuyen_Hoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhap_Chuyen_Hoan.Click
        Try
            'Khai bao bien
            Dim mCheck As Integer = 0
            Dim idx As Integer
            Dim i As Integer
            Dim mRow_Check As Integer
            Dim mId_E1 As String
            'Kiem tra truoc khi ghi vao E1_Thu_No_Hai_Quan
            For idx = 0 To dgE1_Di_Chuyen_Hoan.Rows.Count - 1
                If dgE1_Di_Chuyen_Hoan.Rows(idx).Cells("Chon").Value Then
                    mCheck = mCheck + 1
                    mRow_Check = idx
                End If
            Next
            Select Case mCheck
                Case 0
                    MessageBox.Show("Bạn chưa chọn dòng nào trong danh sách E1 đóng đi cần nhập trạng thái chuyển hoàn." & vbNewLine & "Mời bạn chọn 1 dòng trong danh sách bằng cách tích vào ô chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Case 1
                    If mRow_Check > 0 Then
                        For i = 0 To mRow_Check - 1
                            If Not myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Kiem_Tra_Trang_Thai_Chuyen_Hoan_Theo_Id_E1(dgE1_Di_Chuyen_Hoan.Rows(i).Cells("Id_E1").Value) Then
                                MessageBox.Show("Bạn phải nhập trạng thái cho chi tiết đóng đi phát sinh trước." & vbNewLine & "Mời bạn chọn chi tiết đóng đi chưa tồn tại trạngt thái chuyển hoàn và có ngày đóng nhỏ nhất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        Next
                    End If
                Case Else
                    MessageBox.Show("Mỗi lần nhập trạng thái chỉ được phép nhập cho 1 chi tiết đóng đi trong danh sách." & vbNewLine & "Mời bạn chọn 1 dòng và cập nhật lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
            End Select
            'Ghi vao E1_Thu_No_Hai_Quan
            If dgE1_Di_Chuyen_Hoan.Rows(0).Cells("Chon").Value Then
                mId_E1 = dgE1_Di_Chuyen_Hoan.Rows(0).Cells("Id_E1").Value
                If dgE1_Thu_No_Chuyen_Hoan.Rows.Count > 0 Then
                    For idx = 0 To dgE1_Thu_No_Chuyen_Hoan.Rows.Count - 1
                        If mId_E1 = dgE1_Thu_No_Chuyen_Hoan.Rows(idx).Cells("Id_E1").Value Then
                            If dgE1_Thu_No_Chuyen_Hoan.Rows(idx).Cells("Co_Thu").Value Then
                                MessageBox.Show("Chi tiết đóng đi này đã được cập nhật thông tin thu nợ." & vbNewLine & "Vì vậy bạn không được phép cập nhật trạng thái chuyển hoàn cho chi tiết này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            Else
                                If Not MessageBox.Show("Chi tiết đóng đi này đã được cập nhật trạng thái chuyển hoàn. Bạn có chắc chắn muốn tiếp tục không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                                    Exit Sub
                                End If
                            End If
                        End If
                    Next
                End If
                'Cap nhat vao E1_Thu_No
                myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Cap_Nhat_Them_Trang_Thai_Chuyen_Hoan_Tu_E1_Di_Chuyen_Hoan(mId_E1)
                'Load lai luoi
                DataGrid_E1_Thu_No_Chuyen_Hoan(mId_E1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error At : --------btnNhap_Chuyen_Hoan_Click----------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Di_Chuyen_Hoan_InitializeLayout"
    Private Sub dgE1_Di_Chuyen_Hoan_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Di_Chuyen_Hoan.InitializeLayout
        Try
            Dim idx As Integer
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
        Catch ex As Exception
            MessageBox.Show("Error at: ------dgE1_Di_Chuyen_Hoan_InitializeLayout------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Di_Chuyen_Hoan_AfterRowActivate"
    Private Sub dgE1_Di_Chuyen_Hoan_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Di_Chuyen_Hoan.AfterRowActivate
        Try
            Dim mId_E1 As String
            myGridKeyDown = sender
            mId_E1 = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
            If mId_E1 <> "" Then
                DataGrid_E1_Thu_No_Chuyen_Hoan(mId_E1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error at: --------dgE1_Di_Chuyen_Hoan_AfterRowActivate----------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Nhap_Chuyen_Hoan_InitializeLayout"
    Private Sub dgE1_Nhap_Chuyen_Hoan_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Nhap_Chuyen_Hoan.InitializeLayout
        Try
            Dim idx As Integer
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
            Next
        Catch ex As Exception
            MessageBox.Show("Error at: ------dgE1_Nhap_Chuyen_Hoan_InitializeLayout------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Nhap_Chuyen_Hoan_AfterRowActivate"
    Private Sub dgE1_Nhap_Chuyen_Hoan_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE1_Nhap_Chuyen_Hoan.AfterRowActivate
        Dim mMa_E1 As String
        myGridKeyDown = sender
        mMa_E1 = myGridKeyDown.ActiveRow.Cells("Ma_E1").Text
        If mMa_E1 <> "" Then
            DataGrid_E1_Di_Chuyen_Hoan(mMa_E1)
        End If
    End Sub
#End Region

#Region "dgE1_Thu_No_Chuyen_Hoan_InitializeLayout"
    Private Sub dgE1_Thu_No_Chuyen_Hoan_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Thu_No_Chuyen_Hoan.InitializeLayout
        Try
            Dim idx As Integer
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Co_Thu").Style = ColumnStyle.CheckBox
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).SortIndicator = SortIndicator.Disabled
            Next
        Catch ex As Exception
            MessageBox.Show("Error at: ------dgE1_Thu_No_Chuyen_Hoan_InitializeLayout------" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE1_Thu_No_Chuyen_Hoan_KeyDown"
    Private Sub dgE1_Thu_No_Chuyen_Hoan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE1_Thu_No_Chuyen_Hoan.KeyDown
        myGridKeyDown = sender
        If e.KeyValue = Keys.F8 Then
            If MessageBox.Show("Bạn có chắc chắn muốn xóa trạng thái chuyển hoàn cho bưu phẩm này không?" & vbNewLine & "Hãy chú ý, nếu xóa thực sự thì bạn cũng phải xóa trong chi tiết xác nhận đến từ đường thư chuyển hoàn cho bưu phẩm này.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Dim mId_E1 As String
                mId_E1 = myGridKeyDown.ActiveRow.Cells("Id_E1").Text
                myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Xoa_Bo_Trang_Thai_Chuyen_Hoan_Tu_E1_Xuat_Chuyen_Hoan(mId_E1)
                MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myGridKeyDown.ActiveRow.Delete(False)
            End If
        End If
    End Sub
#End Region

#Region "TabControl_KeyDown"
    Private Sub dtpNgay_Chuyen_Hoan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpNgay_Chuyen_Hoan.KeyDown, cbDuong_Thu_Chuyen_Hoan.KeyDown
        Select Case e.KeyValue
            Case 13 'Key Enter
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            Case 37 'Key Left

            Case Else
        End Select
    End Sub
#End Region

#End Region

#Region "Hàm người dùng"
#Region "GetDuong_Thu_Chuyen_Hoan"
    Private Sub GetDuong_Thu_Chuyen_Hoan()
        cbDuong_Thu_Chuyen_Hoan.DataSource = myDuong_Thu_Den.Duong_Thu_Den_Danh_Sach_Duong_Thu_Chuyen_Hoan_Lay_Boi_Ma_Bc_Khai_Thac(GBuu_Cuc_Khai_Thac)
        cbDuong_Thu_Chuyen_Hoan.DataBind()
        cbDuong_Thu_Chuyen_Hoan.LimitToList = True
    End Sub
#End Region

#Region "DataGrid_E1_Nhap_Chuyen_Hoan"
    Private Sub DataGrid_E1_Nhap_Chuyen_Hoan()
        Dim mData As DataTable
        Dim mNgay_Khai_Thac As Integer
        Dim mId_Duong_Thu As String
        mNgay_Khai_Thac = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Chuyen_Hoan.Value)
        If cbDuong_Thu_Chuyen_Hoan.Value Is DBNull.Value Or cbDuong_Thu_Chuyen_Hoan.Value = Nothing Then
            If cbDuong_Thu_Chuyen_Hoan.Text <> "" Then
                mId_Duong_Thu = cbDuong_Thu_Chuyen_Hoan.Text
            Else
                mId_Duong_Thu = ""
            End If
        Else
            mId_Duong_Thu = cbDuong_Thu_Chuyen_Hoan.Value
        End If
        'Query Lay Du Lieu                
        If mId_Duong_Thu = "" Then  'Tat ca cac duong thu
            mData = myE1_Den.E1_Den_Danh_Sach_Chuyen_Hoan_Theo_Ngay_Ma_Bc_Khai_Thac(True, mNgay_Khai_Thac, GBuu_Cuc_Khai_Thac, mId_Duong_Thu).Tables(0)
        Else  'Theo tung duong thu
            mData = myE1_Den.E1_Den_Danh_Sach_Chuyen_Hoan_Theo_Ngay_Ma_Bc_Khai_Thac(False, mNgay_Khai_Thac, GBuu_Cuc_Khai_Thac, mId_Duong_Thu).Tables(0)
        End If
        If mData.Rows.Count = 0 Then
            MessageBox.Show("Không có dữ liệu theo yêu cầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGrid_E1_Di_Chuyen_Hoan("0")
            DataGrid_E1_Thu_No_Chuyen_Hoan("0")
        End If
        '-------------------------------------------
        dgE1_Nhap_Chuyen_Hoan.DataSource = mData
        dgE1_Nhap_Chuyen_Hoan.DataBind()
    End Sub
#End Region

#Region "DataGrid_E1_Di_Chuyen_Hoan"
    Private Sub DataGrid_E1_Di_Chuyen_Hoan(ByVal mMa_E1 As String)
        Dim mData As DataTable
        Dim mNgay_Bat_Dau As Integer
        Dim mNgay_Khai_Thac As Integer
        mNgay_Khai_Thac = myHam_Dung_Chung.ConvertDateToInt(dtpNgay_Chuyen_Hoan.Value)
        mNgay_Bat_Dau = myHam_Dung_Chung.MinusIntDate(mNgay_Khai_Thac, GSo_Ngay_E1_Duoc_Trung)
        'Query Lay Du Lieu
        mData = myE1_Di.E1_Di_Danh_Sach_Theo_Ma_E1_Den_Chuyen_Hoan_Tu_Ngay_Den_Ngay(GBuu_Cuc_Khai_Thac, mNgay_Bat_Dau, mNgay_Khai_Thac, mMa_E1).Tables(0)
        '-------------------------------------------
        dgE1_Di_Chuyen_Hoan.DataSource = mData
        dgE1_Di_Chuyen_Hoan.DataBind()
    End Sub
#End Region

#Region "DataGrid_E1_Thu_No_Chuyen_Hoan"
    Private Sub DataGrid_E1_Thu_No_Chuyen_Hoan(ByVal mId_E1 As String)
        Dim mData As DataTable
        'Query Lay Du Lieu
        mData = myE1_Thu_No_Le_Phi_HQ.E1_Thu_No_Le_Phi_HQ_Danh_Sach_Theo_Id_E1_Chuyen_Hoan(mId_E1).Tables(0)
        '-------------------------------------------
        dgE1_Thu_No_Chuyen_Hoan.DataSource = mData
        dgE1_Thu_No_Chuyen_Hoan.DataBind()
    End Sub
#End Region

#End Region

#End Region


    
End Class

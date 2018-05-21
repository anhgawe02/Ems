Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Ems_International_Logic.EMS
Imports Ems_International_Logic
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
Imports System.Drawing.Printing

Public Class FrmInGiayBienNhan
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
    Friend WithEvents btnThongTin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTuNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dtpDenNgay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents cbDuongThuDi As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents optTat_Ca As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgE2_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnPrint_E2 As System.Windows.Forms.Button
    Friend WithEvents BtnPreview_E2 As System.Windows.Forms.Button
    Friend WithEvents btnPreview_E1 As System.Windows.Forms.Button
    Friend WithEvents btnPrint_E1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtE2 As System.Windows.Forms.TextBox
    Friend WithEvents txtE1 As System.Windows.Forms.TextBox
    Friend WithEvents optDuong_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents dgE1_Di As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chk_E2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_E1 As System.Windows.Forms.CheckBox
    Friend WithEvents ddDuongThu As Infragistics.Win.UltraWinGrid.UltraDropDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInGiayBienNhan))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E2_Di", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_So")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tui_F")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_BP")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_KL")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Chuyen_Thu")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Chuyen_Thu")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Di", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chon")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Ca")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Quay")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Phat_Hanh")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Phat_Hanh")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Nhan")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Nhan")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Goc")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai_Hang_Hoa")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong_QD")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Cong_Them")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dv_Gia_Tang")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PPXD")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPXD")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PostCode")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_PPVX")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VAT")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("COD")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_COD")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Dv")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Chinh")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Giam")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_E1")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kien_So")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Hanh")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HH_Phat_Tra")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_CH")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Trang_Thai")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Khai_Thac")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_Doi_Soat")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Tien")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dm_Duong_thu", -1)
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Doanh_Thu")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tinh_Cong_Phat")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Duoc_Truyen")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Su_Dung")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chuyen_Tiep")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.optDuong_Thu = New System.Windows.Forms.RadioButton
        Me.optTat_Ca = New System.Windows.Forms.RadioButton
        Me.cbDuongThuDi = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.btnThongTin = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTuNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dtpDenNgay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnThoat = New System.Windows.Forms.Button
        Me.dgE2_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgE1_Di = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.btnPrint_E2 = New System.Windows.Forms.Button
        Me.BtnPreview_E2 = New System.Windows.Forms.Button
        Me.btnPreview_E1 = New System.Windows.Forms.Button
        Me.btnPrint_E1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtE2 = New System.Windows.Forms.TextBox
        Me.txtE1 = New System.Windows.Forms.TextBox
        Me.chk_E2 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk_E1 = New System.Windows.Forms.CheckBox
        Me.ddDuongThu = New Infragistics.Win.UltraWinGrid.UltraDropDown
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE2_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddDuongThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label3)
        Me.UltraGroupBox1.Controls.Add(Me.optDuong_Thu)
        Me.UltraGroupBox1.Controls.Add(Me.optTat_Ca)
        Me.UltraGroupBox1.Controls.Add(Me.cbDuongThuDi)
        Me.UltraGroupBox1.Controls.Add(Me.btnThongTin)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.UltraGroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.btnThoat)
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(776, 96)
        Me.UltraGroupBox1.SupportThemes = False
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Thông tin lấy dữ liệu in giấy biên nhận"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(392, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tên đường thư"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optDuong_Thu
        '
        Me.optDuong_Thu.Location = New System.Drawing.Point(224, 55)
        Me.optDuong_Thu.Name = "optDuong_Thu"
        Me.optDuong_Thu.Size = New System.Drawing.Size(168, 24)
        Me.optDuong_Thu.TabIndex = 5
        Me.optDuong_Thu.Text = "Theo từng đường thư"
        '
        'optTat_Ca
        '
        Me.optTat_Ca.Location = New System.Drawing.Point(224, 24)
        Me.optTat_Ca.Name = "optTat_Ca"
        Me.optTat_Ca.Size = New System.Drawing.Size(144, 24)
        Me.optTat_Ca.TabIndex = 4
        Me.optTat_Ca.Text = "Tất cả các đường thư"
        '
        'cbDuongThuDi
        '
        Me.cbDuongThuDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbDuongThuDi.Cursor = System.Windows.Forms.Cursors.IBeam
        UltraGridColumn1.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        UltraGridBand1.Header.Caption = "Mã Đường Thư"
        Me.cbDuongThuDi.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbDuongThuDi.DisplayMember = "Ten_Duong_Thu"
        Me.cbDuongThuDi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDuongThuDi.Location = New System.Drawing.Point(392, 55)
        Me.cbDuongThuDi.Name = "cbDuongThuDi"
        Me.cbDuongThuDi.Size = New System.Drawing.Size(136, 21)
        Me.cbDuongThuDi.TabIndex = 7
        Me.cbDuongThuDi.ValueMember = "Id_Duong_Thu"
        '
        'btnThongTin
        '
        Me.btnThongTin.Image = CType(resources.GetObject("btnThongTin.Image"), System.Drawing.Image)
        Me.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnThongTin.Location = New System.Drawing.Point(544, 29)
        Me.btnThongTin.Name = "btnThongTin"
        Me.btnThongTin.Size = New System.Drawing.Size(104, 48)
        Me.btnThongTin.TabIndex = 8
        Me.btnThongTin.Text = "&Lấy thông tin"
        Me.btnThongTin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(112, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Đến ngày"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpTuNgay.Location = New System.Drawing.Point(8, 53)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpTuNgay.TabIndex = 1
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtpDenNgay.Location = New System.Drawing.Point(112, 53)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(96, 23)
        Me.dtpDenNgay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Từ ngày"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnThoat.Location = New System.Drawing.Point(664, 29)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(104, 48)
        Me.btnThoat.TabIndex = 9
        Me.btnThoat.Text = "&Thoát"
        Me.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'dgE2_Di
        '
        Me.dgE2_Di.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgE2_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE2_Di.DisplayLayout.Appearance = Appearance1
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Caption = "Đường thư"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(69, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "Ngày đóng"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Túi số"
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.Caption = "Túi F"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(41, 0)
        UltraGridColumn15.Header.Caption = "Số BP"
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(62, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Khối lượng"
        UltraGridColumn16.Header.VisiblePosition = 12
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(73, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.Caption = "Số CT"
        UltraGridColumn18.Header.VisiblePosition = 4
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Loại CT"
        UltraGridColumn19.Header.VisiblePosition = 5
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(55, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Chọn"
        UltraGridColumn20.Header.VisiblePosition = 15
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(36, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        UltraGridBand2.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.AllowRowLayoutLabelSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Both
        UltraGridBand2.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand2.UseRowLayout = True
        Me.dgE2_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.dgE2_Di.DisplayLayout.InterBandSpacing = 10
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.dgE2_Di.DisplayLayout.Override.CardAreaAppearance = Appearance2
        Me.dgE2_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.ForeColor = System.Drawing.Color.Black
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE2_Di.DisplayLayout.Override.HeaderAppearance = Appearance3
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2_Di.DisplayLayout.Override.RowAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE2_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance5
        Me.dgE2_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE2_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.dgE2_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance6
        Me.dgE2_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE2_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE2_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE2_Di.Location = New System.Drawing.Point(8, 112)
        Me.dgE2_Di.Name = "dgE2_Di"
        Me.dgE2_Di.Size = New System.Drawing.Size(384, 384)
        Me.dgE2_Di.TabIndex = 0
        Me.dgE2_Di.Text = "Danh sách E2"
        '
        'dgE1_Di
        '
        Me.dgE1_Di.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.dgE1_Di.DataMember = Nothing
        Me.dgE1_Di.DisplayLayout.AddNewBox.Prompt = " "
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgE1_Di.DisplayLayout.Appearance = Appearance7
        UltraGridColumn21.Header.Caption = "Chọn"
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(37, 0)
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.VisiblePosition = 40
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.Caption = "Id E1"
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "ID Đường Thư"
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.Caption = "ID Chuyến Thư"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "ID_E2"
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.Caption = "ID Ca"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Bưu Cục Khai Thác"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "Quầy"
        UltraGridColumn29.Header.VisiblePosition = 7
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.Caption = "Mã E1"
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn30.MaskInput = ""
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(85, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Width = 13
        UltraGridColumn31.Header.Caption = "Ngày Phát Hành"
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.Caption = "Giờ Phát Hành"
        UltraGridColumn32.Header.VisiblePosition = 10
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.Caption = "Ngày Đóng"
        UltraGridColumn33.Header.VisiblePosition = 11
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(90, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.Caption = "Giờ Đóng"
        UltraGridColumn34.Header.VisiblePosition = 12
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Ngày Nhận"
        UltraGridColumn35.Header.VisiblePosition = 13
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.Caption = "Giờ Nhận"
        UltraGridColumn36.Header.VisiblePosition = 14
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.Caption = "Mã Đơn Vị"
        UltraGridColumn37.Header.VisiblePosition = 15
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "Bưu Cục Gốc"
        UltraGridColumn38.Header.VisiblePosition = 16
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(75, 0)
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.Caption = "Bưu Cục Trả"
        UltraGridColumn39.Header.VisiblePosition = 17
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.Caption = "Nước Nhận"
        UltraGridColumn40.Header.VisiblePosition = 18
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(68, 0)
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.Caption = "Nước Trả"
        UltraGridColumn41.Header.VisiblePosition = 19
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.Caption = "Khối Lượng"
        UltraGridColumn42.Header.VisiblePosition = 20
        UltraGridColumn42.MaskInput = ""
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(71, 0)
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Width = 8
        UltraGridColumn43.Header.Caption = "Phân Loại"
        UltraGridColumn43.Header.VisiblePosition = 21
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.Caption = "Loại Hàng Hóa"
        UltraGridColumn44.Header.VisiblePosition = 22
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Header.Caption = "Khối Lượng QD"
        UltraGridColumn45.Header.VisiblePosition = 23
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.Caption = "Loại"
        UltraGridColumn46.Header.VisiblePosition = 24
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.MaskInput = "9"
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(52, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Width = 100
        UltraGridColumn47.Header.Caption = "Dv Cộng Thêm"
        UltraGridColumn47.Header.VisiblePosition = 25
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.Caption = "Dv Gia Tăng"
        UltraGridColumn48.Header.VisiblePosition = 26
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.Caption = "PP Xăng Dầu"
        UltraGridColumn49.Header.VisiblePosition = 27
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.Caption = "Cước PP Xăng Dầu"
        UltraGridColumn50.Header.VisiblePosition = 28
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 29
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.Caption = "Cước PP Vùng Xa"
        UltraGridColumn52.Header.VisiblePosition = 30
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.Caption = "Thuế VAT"
        UltraGridColumn53.Header.VisiblePosition = 31
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.Caption = "Dv COD"
        UltraGridColumn54.Header.VisiblePosition = 32
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.Caption = "Giá Trị Hàng"
        UltraGridColumn55.Header.VisiblePosition = 33
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.Caption = "Cước COD"
        UltraGridColumn56.Header.VisiblePosition = 34
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn57.Header.Caption = "Cước Dịch Vụ"
        UltraGridColumn57.Header.VisiblePosition = 35
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn58.Header.Caption = "Cước Chính"
        UltraGridColumn58.Header.VisiblePosition = 36
        UltraGridColumn58.Hidden = True
        UltraGridColumn58.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn58.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn58.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn58.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn59.Header.Caption = "Cước Giảm"
        UltraGridColumn59.Header.VisiblePosition = 37
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.Caption = "Cước E1"
        UltraGridColumn60.Header.VisiblePosition = 38
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn60.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn60.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn60.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn61.DefaultCellValue = "0"
        UltraGridColumn61.Header.Caption = "Kiện Số"
        UltraGridColumn61.Header.VisiblePosition = 39
        UltraGridColumn61.Hidden = True
        UltraGridColumn61.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn61.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn61.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn61.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn62.Header.Caption = "Mã KH"
        UltraGridColumn62.Header.VisiblePosition = 41
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.DefaultCellValue = ""
        UltraGridColumn63.Header.Caption = "Người Gửi"
        UltraGridColumn63.Header.VisiblePosition = 42
        UltraGridColumn63.Hidden = True
        UltraGridColumn63.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn63.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn63.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn63.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn64.DefaultCellValue = ""
        UltraGridColumn64.Header.Caption = "Người Nhận"
        UltraGridColumn64.Header.VisiblePosition = 43
        UltraGridColumn64.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn64.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn64.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn64.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn65.DefaultCellValue = ""
        UltraGridColumn65.Header.Caption = "Địa Chỉ Gửi"
        UltraGridColumn65.Header.VisiblePosition = 44
        UltraGridColumn65.Hidden = True
        UltraGridColumn65.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn65.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn65.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn65.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn66.DefaultCellValue = ""
        UltraGridColumn66.Header.Caption = "Địa Chỉ Nhận"
        UltraGridColumn66.Header.VisiblePosition = 45
        UltraGridColumn66.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn66.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn66.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn66.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn67.DefaultCellValue = ""
        UltraGridColumn67.Header.Caption = "ĐT Gửi"
        UltraGridColumn67.Header.VisiblePosition = 46
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.DefaultCellValue = ""
        UltraGridColumn68.Header.Caption = "ĐT Nhận"
        UltraGridColumn68.Header.VisiblePosition = 47
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.Caption = "HH Phát Hành"
        UltraGridColumn69.Header.VisiblePosition = 48
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.Caption = "HH Phát Trả"
        UltraGridColumn70.Header.VisiblePosition = 49
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.Caption = "BC Chuyển hoàn"
        UltraGridColumn71.Header.VisiblePosition = 50
        UltraGridColumn71.Hidden = True
        UltraGridColumn71.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn71.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn71.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn71.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn72.Header.Caption = "ID Người Dùng"
        UltraGridColumn72.Header.VisiblePosition = 51
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.Caption = "ID Trạng Thái"
        UltraGridColumn73.Header.VisiblePosition = 52
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.DefaultCellValue = ""
        UltraGridColumn74.Header.Caption = "Ghi Chú"
        UltraGridColumn74.Header.VisiblePosition = 53
        UltraGridColumn74.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn74.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn74.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn74.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn75.DefaultCellValue = "0"
        UltraGridColumn75.Header.VisiblePosition = 54
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 55
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 56
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 57
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Format = "###,###"
        UltraGridColumn79.Header.Caption = "Lệ Phí HQ"
        UltraGridColumn79.Header.VisiblePosition = 58
        UltraGridColumn79.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn79.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn79.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(59, 0)
        UltraGridColumn79.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn79.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn80.Format = "#,###,###"
        UltraGridColumn80.Header.Caption = "Thuế NK"
        UltraGridColumn80.Header.VisiblePosition = 59
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn80.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn80.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(60, 0)
        UltraGridColumn80.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn80.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn81.Format = "#,###,###"
        UltraGridColumn81.Header.Caption = "Thuế VAT"
        UltraGridColumn81.Header.VisiblePosition = 61
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn81.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn81.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn81.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn81.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn82.Format = "#,###,###"
        UltraGridColumn82.Header.Caption = "Tổng thuế"
        UltraGridColumn82.Header.VisiblePosition = 60
        UltraGridColumn82.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn82.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn82.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn82.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn82.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn83.Header.Caption = "Số TKHQ"
        UltraGridColumn83.Header.VisiblePosition = 62
        UltraGridColumn83.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn83.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn83.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn83.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn83.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn84.Header.Caption = "Số Biên Lai"
        UltraGridColumn84.Header.VisiblePosition = 63
        UltraGridColumn84.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn84.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn84.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn84.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn84.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn85.Format = "###,###"
        UltraGridColumn85.Header.Caption = "LP Khác"
        UltraGridColumn85.Header.VisiblePosition = 64
        UltraGridColumn85.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn85.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn85.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(53, 0)
        UltraGridColumn85.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn85.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn86.Format = "#,###,###"
        UltraGridColumn86.Header.Caption = "Tổng tiền"
        UltraGridColumn86.Header.VisiblePosition = 65
        UltraGridColumn86.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn86.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn86.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(89, 0)
        UltraGridColumn86.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn86.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86})
        UltraGridBand3.Header.Caption = "Danh sách E1 trong bản kê E2"
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgE1_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgE1_Di.DisplayLayout.InterBandSpacing = 10
        Me.dgE1_Di.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.dgE1_Di.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Me.dgE1_Di.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgE1_Di.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.dgE1_Di.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance10.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.Override.RowAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance11.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorAppearance = Appearance11
        Me.dgE1_Di.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Me.dgE1_Di.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgE1_Di.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance12.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.dgE1_Di.DisplayLayout.Override.SelectedRowAppearance = Appearance12
        Me.dgE1_Di.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.dgE1_Di.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgE1_Di.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgE1_Di.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgE1_Di.Location = New System.Drawing.Point(400, 112)
        Me.dgE1_Di.Name = "dgE1_Di"
        Me.dgE1_Di.Size = New System.Drawing.Size(384, 384)
        Me.dgE1_Di.TabIndex = 1
        Me.dgE1_Di.Text = "Danh sách E1 trong bản kê E2"
        '
        'btnPrint_E2
        '
        Me.btnPrint_E2.Image = CType(resources.GetObject("btnPrint_E2.Image"), System.Drawing.Image)
        Me.btnPrint_E2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint_E2.Location = New System.Drawing.Point(176, 504)
        Me.btnPrint_E2.Name = "btnPrint_E2"
        Me.btnPrint_E2.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint_E2.TabIndex = 5
        Me.btnPrint_E2.Text = "Print Theo E2"
        Me.btnPrint_E2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnPreview_E2
        '
        Me.BtnPreview_E2.Image = CType(resources.GetObject("BtnPreview_E2.Image"), System.Drawing.Image)
        Me.BtnPreview_E2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPreview_E2.Location = New System.Drawing.Point(288, 504)
        Me.BtnPreview_E2.Name = "BtnPreview_E2"
        Me.BtnPreview_E2.Size = New System.Drawing.Size(104, 40)
        Me.BtnPreview_E2.TabIndex = 6
        Me.BtnPreview_E2.Text = "Preview Theo E2"
        Me.BtnPreview_E2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnPreview_E1
        '
        Me.btnPreview_E1.Image = CType(resources.GetObject("btnPreview_E1.Image"), System.Drawing.Image)
        Me.btnPreview_E1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview_E1.Location = New System.Drawing.Point(680, 504)
        Me.btnPreview_E1.Name = "btnPreview_E1"
        Me.btnPreview_E1.Size = New System.Drawing.Size(104, 40)
        Me.btnPreview_E1.TabIndex = 11
        Me.btnPreview_E1.Text = "Preview Theo E1"
        Me.btnPreview_E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnPrint_E1
        '
        Me.btnPrint_E1.Image = CType(resources.GetObject("btnPrint_E1.Image"), System.Drawing.Image)
        Me.btnPrint_E1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint_E1.Location = New System.Drawing.Point(568, 504)
        Me.btnPrint_E1.Name = "btnPrint_E1"
        Me.btnPrint_E1.Size = New System.Drawing.Size(104, 40)
        Me.btnPrint_E1.TabIndex = 10
        Me.btnPrint_E1.Text = "Print Theo E1"
        Me.btnPrint_E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 520)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dòng chọn"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtE2
        '
        Me.txtE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE2.Location = New System.Drawing.Point(80, 520)
        Me.txtE2.Name = "txtE2"
        Me.txtE2.ReadOnly = True
        Me.txtE2.Size = New System.Drawing.Size(80, 22)
        Me.txtE2.TabIndex = 4
        Me.txtE2.Text = ""
        Me.txtE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtE1
        '
        Me.txtE1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtE1.Location = New System.Drawing.Point(472, 520)
        Me.txtE1.Name = "txtE1"
        Me.txtE1.ReadOnly = True
        Me.txtE1.Size = New System.Drawing.Size(80, 22)
        Me.txtE1.TabIndex = 9
        Me.txtE1.Text = ""
        Me.txtE1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chk_E2
        '
        Me.chk_E2.Location = New System.Drawing.Point(8, 496)
        Me.chk_E2.Name = "chk_E2"
        Me.chk_E2.TabIndex = 2
        Me.chk_E2.Text = "Chọn tất cả"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dòng chọn"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_E1
        '
        Me.chk_E1.Location = New System.Drawing.Point(400, 496)
        Me.chk_E1.Name = "chk_E1"
        Me.chk_E1.TabIndex = 7
        Me.chk_E1.Text = "Chọn tất cả"
        '
        'ddDuongThu
        '
        Me.ddDuongThu.Cursor = System.Windows.Forms.Cursors.Default
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddDuongThu.DisplayLayout.Appearance = Appearance13
        UltraGridColumn87.Header.Caption = "Mã đường thư"
        UltraGridColumn87.Header.VisiblePosition = 0
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.Caption = "Tên đường thư"
        UltraGridColumn88.Header.VisiblePosition = 1
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.Caption = "Mã BC khai thác"
        UltraGridColumn89.Header.VisiblePosition = 2
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.Caption = "Đường thư"
        UltraGridColumn90.Header.VisiblePosition = 3
        UltraGridColumn91.Header.VisiblePosition = 4
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 5
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 6
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 7
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 8
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 9
        UltraGridColumn96.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96})
        UltraGridBand4.UseRowLayout = True
        Me.ddDuongThu.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddDuongThu.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.ddDuongThu.DisplayMember = "Ma_Bc"
        Me.ddDuongThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddDuongThu.Location = New System.Drawing.Point(292, 214)
        Me.ddDuongThu.Name = "ddDuongThu"
        Me.ddDuongThu.Size = New System.Drawing.Size(140, 128)
        Me.ddDuongThu.TabIndex = 42
        Me.ddDuongThu.ValueMember = "Id_Duong_Thu"
        Me.ddDuongThu.Visible = False
        '
        'FrmInGiayBienNhan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 557)
        Me.Controls.Add(Me.ddDuongThu)
        Me.Controls.Add(Me.chk_E1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_E2)
        Me.Controls.Add(Me.txtE1)
        Me.Controls.Add(Me.txtE2)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPreview_E1)
        Me.Controls.Add(Me.btnPrint_E1)
        Me.Controls.Add(Me.BtnPreview_E2)
        Me.Controls.Add(Me.btnPrint_E2)
        Me.Controls.Add(Me.dgE1_Di)
        Me.Controls.Add(Me.dgE2_Di)
        Me.Name = "FrmInGiayBienNhan"
        Me.Text = "FrmInGiayBienNhan"
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.cbDuongThuDi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTuNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDenNgay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE2_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgE1_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddDuongThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến toàn Form"
    Dim myE2_Di As New E2_Di(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myDuong_Thu_Di As New Duong_Thu_Di(GConnectionString)
    Dim myDuong_Thu_Buu_Ta_Noi_Bo As New Duong_Thu_Buu_Ta_Noi_Bo(GConnectionString)
    Dim myTu_Ngay As Integer
    Dim myDen_Ngay As Integer
    Dim myId_Duong_Thu As String
    Dim myDataE2 As DataTable
    Dim myDataE1 As DataTable
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myPrint As New Ems_Printer
#End Region

#Region "Form_Load"
    Private Sub FrmInGiayBienNhan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "In giấy biên nhận đối với đường thư bưu tá nội bộ của công ty. Bưu cục khai thác: " & GBuu_Cuc_Khai_Thac & " - " & GTen_Buu_Cuc_Khai_Thac
        dtpTuNgay.Value = Today.Date
        dtpDenNgay.Value = Today.Date

        cbDuongThuDi.DataSource = myDuong_Thu_Di.Duong_Thu_Di_Danh_Sach_Duong_Thu_Buu_Ta_Noi_Bo(GBuu_Cuc_Khai_Thac)
        cbDuongThuDi.DataBind()
        cbDuongThuDi.LimitToList = True

        ddDuongThu.DataSource = myDuong_Thu_Di.Danh_Sach
        ddDuongThu.DataBind()

        optTat_Ca.Checked = True
        optDuong_Thu.Checked = False
        cbDuongThuDi.Enabled = False
        cbDuongThuDi.Text = ""
    End Sub
#End Region

#Region "Hàm dùng chung"
#Region "TabControl_KeyEnter"
    Private Sub dtpTuNgay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTuNgay.KeyDown, dtpDenNgay.KeyDown, optTat_Ca.KeyDown, optDuong_Thu.KeyDown
        If e.KeyValue = 13 Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub
#End Region

#Region "Grid_Key_Enter"
    Private Sub dgE2_Di_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgE2_Di.KeyDown, dgE1_Di.KeyDown
        myGridKeyDown = sender
        Try
            If myGridKeyDown.ActiveCell Is Nothing Then
                Exit Sub
            End If
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Right
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Left
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(PrevCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Up
                    If myGridKeyDown.ActiveRow.Index = 0 Then
                        Exit Sub
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.PerformAction(ExitEditMode, False, False)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
                Case Keys.Down
                    If myGridKeyDown.ActiveRow.Index = myGridKeyDown.Rows.Count - 1 Then
                        Exit Sub
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index + 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.PerformAction(ExitEditMode, False, False)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                    End If
            End Select
        Catch ex As Exception
            ' Call the exception handler
            MessageBox.Show("Error at: ====dgE2_Di_KeyDown====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#Region "Tab Control"

#Region "btnThoat_Click"
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "btnPrint_E2_Click"
    Private Sub btnPrint_E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint_E2.Click
        Dim idx As Integer
        For idx = 0 To dgE2_Di.Rows.Count - 1
            If dgE2_Di.Rows(idx).Cells("Chon").Value = True Then
                Print_Bien_Nhan_Theo_E2(False, dgE2_Di.Rows(idx).Cells("Id_E2").Text)
            End If
        Next
        MessageBox.Show("Đã in thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "BtnPreview_E2_Click"
    Private Sub BtnPreview_E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview_E2.Click
        Dim idx As Integer
        For idx = 0 To dgE2_Di.Rows.Count - 1
            If dgE2_Di.Rows(idx).Cells("Chon").Value = True Then
                Print_Bien_Nhan_Theo_E2(True, dgE2_Di.Rows(idx).Cells("Id_E2").Text)
            End If
        Next
        MessageBox.Show("Đã in thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "btnPrint_E1_Click"
    Private Sub btnPrint_E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint_E1.Click
        Print_Bien_Nhan_Theo_E1(False)
    End Sub
#End Region

#Region "btnPreview_E1_Click"
    Private Sub btnPreview_E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview_E1.Click
        Print_Bien_Nhan_Theo_E1(True)
    End Sub
#End Region

#Region "btnThongTin_Click"
    Private Sub btnThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThongTin.Click
        Try
            If dtpTuNgay.Value > dtpDenNgay.Value Then
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày." & vbNewLine & "Mời bạn nhập lại thông tin ngày đóng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtpTuNgay.Select()
                Exit Sub
            End If
            If optDuong_Thu.Checked Then
                If cbDuongThuDi.Value Is DBNull.Value Or cbDuongThuDi.Text = "" Then
                    MessageBox.Show("Bạn chưa chọn đường thư bưu tá nội bộ cần lấy thông tin." & vbNewLine & "Mời bạn chọn 1 đường thư trong danh sách đường thư bưu tá nội bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbDuongThuDi.Select()
                    Exit Sub
                End If
            End If
            myTu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpTuNgay.Value)
            myDen_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtpDenNgay.Value)
            If optDuong_Thu.Checked Then
                myId_Duong_Thu = cbDuongThuDi.Value
            Else
                myId_Duong_Thu = ""
            End If
            If optTat_Ca.Checked Then
                myDataE2 = myE2_Di.E2_Di_Danh_Sach_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Tu_Ngay_Den_Ngay(True, myId_Duong_Thu, myTu_Ngay, myDen_Ngay).Tables(0)
            Else
                myDataE2 = myE2_Di.E2_Di_Danh_Sach_Theo_Duong_Thu_Buu_Ta_Noi_Bo_Tu_Ngay_Den_Ngay(False, myId_Duong_Thu, myTu_Ngay, myDen_Ngay).Tables(0)
            End If
            Grid_E2_Di(myDataE2)
        Catch ex As Exception
            MessageBox.Show("Error at: ====btnThongTin_Click====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "optDuong_Thu_CheckedChanged"
    Private Sub optDuong_Thu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDuong_Thu.CheckedChanged
        cbDuongThuDi.Enabled = optDuong_Thu.Checked
        If optDuong_Thu.Checked Then
            If cbDuongThuDi.IsDroppedDown = False Then
                cbDuongThuDi.PerformAction(UltraComboAction.Dropdown)
            End If
        End If
    End Sub
#End Region

#Region "chk_E2_CheckedChanged"
    Private Sub chk_E2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_E2.CheckedChanged
        Try
            Dim idx As Integer
            For idx = 0 To dgE2_Di.Rows.Count - 1
                dgE2_Di.Rows(idx).Cells("Chon").Value = chk_E2.Checked
            Next
            Caculate_E2_Di()
            Caculate_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ====chk_E2_CheckedChanged====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "chk_E1_CheckedChanged"
    Private Sub chk_E1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_E1.CheckedChanged
        Try
            Dim idx As Integer
            For idx = 0 To dgE1_Di.Rows.Count - 1
                dgE1_Di.Rows(idx).Cells("Chon").Value = chk_E1.Checked
            Next
            Caculate_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ====chk_E1_CheckedChanged====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "--------------dgE2_Di---------------"
#Region "dgE2_Di_InitializeLayout"
    Private Sub dgE2_Di_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE2_Di.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").ValueList = ddDuongThu

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Id_Duong_Thu").Hidden = Not optTat_Ca.Checked
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox



            Dim idx As Integer
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
            Caculate_E2_Di()
            Caculate_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ====dgE2_Di_InitializeLayout====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE2_Di_AfterRowActivate"
    Private Sub dgE2_Di_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgE2_Di.AfterRowActivate
        Lay_Danh_Sach_E1_Theo_E2_Duoc_Chon(dgE2_Di.ActiveRow.Cells("Id_E2").Text)

        Dim idx As Integer
        For idx = 0 To dgE1_Di.Rows.Count - 1
            dgE1_Di.Rows(idx).Cells("Chon").Value = dgE2_Di.ActiveRow.Cells("Chon").Value
        Next
        Caculate_E1_Di()
    End Sub
#End Region

#Region "dgE2_Di_AfterCellUpdate"
    Private Sub dgE2_Di_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE2_Di.AfterCellUpdate
        Try
            'Dim idx As Integer
            'For idx = 0 To dgE1_Di.Rows.Count - 1
            '    dgE1_Di.Rows(idx).Cells("Chon").Value = dgE2_Di.ActiveCell.Value
            'Next
            Caculate_E2_Di()
            Caculate_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ====dgE2_Di_AfterCellUpdate====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "dgE2_Di_CellChange"
    Private Sub dgE2_Di_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles dgE2_Di.CellChange
        Try

        Catch ex As Exception
            MessageBox.Show("Error at: ====dgE2_Di_CellChange====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim idx As Integer
        If dgE2_Di.ActiveCell.Column.Key = "Chon" Then
            For idx = 0 To dgE1_Di.Rows.Count - 1
                dgE1_Di.Rows(idx).Cells("Chon").Value = Not dgE2_Di.ActiveCell.Value
            Next
        End If
        Caculate_E1_Di()
    End Sub
#End Region

#End Region

#Region "-------------------dgE1_Di--------------------"
#Region "dgE1_Di_InitializeLayout"
    Private Sub dgE1_Di_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgE1_Di.InitializeLayout
        Try
            myGridKeyDown = sender
            myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
            myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue

            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").Style = ColumnStyle.CheckBox
            Dim idx As Integer
            For idx = 0 To myGridKeyDown.DisplayLayout.Bands(0).Columns.Count - 1
                myGridKeyDown.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
            Next
            myGridKeyDown.DisplayLayout.Bands(0).Columns("Chon").CellActivation = Activation.AllowEdit
            Caculate_E1_Di()
        Catch ex As Exception
            MessageBox.Show("Error at: ====dgE1_Di_InitializeLayout====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#End Region

#End Region

#Region "Hàm người dùng viết"

#Region "Grid_E2_Di"
    Private Sub Grid_E2_Di(ByVal mData As DataTable)
        dgE2_Di.DataSource = mData
        dgE2_Di.DataBind()
    End Sub
#End Region

#Region "Grid_E1_Di"
    Private Sub Grid_E1_Di(ByVal mData As DataTable)
        dgE1_Di.DataSource = mData
        dgE1_Di.DataBind()
    End Sub
#End Region

#Region "Caculate_E2_Di"
    Private Function Caculate_E2_Di() As Integer
        Try
            Dim idx As Integer
            Dim mSo_Dong As Integer
            Dim mTong_So_Dong As Integer
            For idx = 0 To dgE2_Di.Rows.Count - 1
                If dgE2_Di.Rows(idx).Cells("Id_E2").Text <> "" Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                If dgE2_Di.Rows(idx).Cells("Chon").Value = True Then
                    mSo_Dong = mSo_Dong + 1
                End If
            Next
            txtE2.Text = mSo_Dong.ToString & " / " & mTong_So_Dong.ToString
            Return mSo_Dong
        Catch ex As Exception
            MessageBox.Show("Error at: ====Caculate_E2_Di====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

#End Region

#Region "Caculate_E1_Di"
    Private Function Caculate_E1_Di() As Integer
        Try
            Dim idx As Integer
            Dim mSo_Dong As Integer
            Dim mTong_So_Dong As Integer
            For idx = 0 To dgE1_Di.Rows.Count - 1
                If dgE1_Di.Rows(idx).Cells("Id_E1").Text <> "" Then
                    mTong_So_Dong = mTong_So_Dong + 1
                End If
                If dgE1_Di.Rows(idx).Cells("Chon").Value = True Then
                    mSo_Dong = mSo_Dong + 1
                End If
            Next
            txtE1.Text = mSo_Dong.ToString & " / " & mTong_So_Dong.ToString
            Return mSo_Dong
        Catch ex As Exception
            MessageBox.Show("Error at: ====Caculate_E1_Di====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

#End Region

#Region "Print_Bien_Nhan_Theo_E2"
    Private Sub Print_Bien_Nhan_Theo_E2(ByVal mPreview As Boolean, ByVal mId_E2 As String)
        Try
            Dim myE1_Di As New E1_Di(GConnectionString)
            Dim myTable As New DataTable
            Dim RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo As New RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim FrmView As New FrmPrintManual
            Dim pDien_Thoai As String
            Dim pNgay_Thang_Nam As String

            'Lay du lieu chi tiet cho bao cao
            myTable = myE1_Di.E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E2_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, mId_E2, GBuu_Cuc_Khai_Thac).Tables(0)

            'Kiem tra neu khong co ban ghi thi thoat
            If myTable.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Tiep tuc thuc hien neu co du lieu
            'Thong tin chi tiet
            myTable.TableName = "E1_Di_Giay_Bien_Nhan_Buu_Ta_Noi_Bo"
            'Paramete
            If GBuu_Cuc_Khai_Thac > 700000 Then
                pDien_Thoai = "9480632"
                pNgay_Thang_Nam = "Tp. HCM, ngày " & Today.Day.ToString("00") & " tháng " & Today.Month.ToString("00") & " năm " & Today.Year.ToString("00")
            Else
                pDien_Thoai = ""
                pNgay_Thang_Nam = "Hà Nội, ngày " & Today.Day.ToString("00") & " tháng " & Today.Month.ToString("00") & " năm " & Today.Year.ToString("00")
            End If
            'Dien thoai
            _pThamSo.Value = pDien_Thoai
            pvCollection.Add(_pThamSo)
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.DataDefinition.ParameterFields("pDien_Thoai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Ngay_Thang_Nam
            _pThamSo.Value = pNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.SetDataSource(myTable)
            FrmView.rptViewer.ReportSource = RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo
            'Kiem tra xem co kho giay chua
            Dim i As Integer
            Dim rawKind As Integer = 0
            Dim printDoc As New System.Drawing.Printing.PrintDocument
            Dim mDefaulPrinterName As String
            mDefaulPrinterName = RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PrinterName
            printDoc.PrinterSettings.PrinterName = mDefaulPrinterName
Duyet_Tim_Kho_Giay:
            For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = "Giay_Bien_Nhan" Then
                    rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
                End If
            Next
            If rawkind = 0 Then
                myPrint.AddCustomPaperSize(mDefaulPrinterName, "Giay_Bien_Nhan", 190.0F, 140.0F)
                GoTo Duyet_Tim_Kho_Giay
            End If
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            Cursor.Current = Cursors.Default
            'Bat dau in
            If mPreview Then
                FrmView.ShowDialog()
            Else
                RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintToPrinter(1, True, 0, 0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error at: ====Print_Bien_Nhan_Theo_E2====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Print_Bien_Nhan_Theo_E1"
    Private Sub Print_Bien_Nhan_Theo_E1(ByVal mPreview As Boolean)
        Try
            Dim myE1_Di As New E1_Di(GConnectionString)
            Dim myTable As New DataTable
            Dim myTableAppend As New DataTable
            Dim myRow As DataRow
            Dim RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo As New RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo
            Dim pvCollection As New ParameterValues
            Dim _pThamSo As New ParameterDiscreteValue
            Dim FrmView As New FrmPrintManual
            Dim pDien_Thoai As String
            Dim pNgay_Thang_Nam As String
            Dim mId_E1 As String
            Dim idx As Integer

            'Tao bang
            mId_E1 = ""
            myTable = myE1_Di.E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E1_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, mId_E1, GBuu_Cuc_Khai_Thac).Tables(0)
            'Lay du lieu chi tiet cho bao cao
            For idx = 0 To dgE1_Di.Rows.Count - 1
                'Neu dong duoc check
                If dgE1_Di.Rows(idx).Cells("Chon").Value = True Then
                    'Lay Id_E1 vao bien
                    mId_E1 = dgE1_Di.Rows(idx).Cells("Id_E1").Text
                    'Lay du lieu theo Id_E1
                    myTableAppend = myE1_Di.E1_Di_In_Giay_Bien_Nhan_Buu_Ta_Noi_Bo_Theo_Id_E1_Tu_Ngay_Den_Ngay(myTu_Ngay, myDen_Ngay, mId_E1, GBuu_Cuc_Khai_Thac).Tables(0)
                    'Them vao bang du lieu cua Report
                    myRow = myTable.NewRow()
                    myRow("Ma_E1") = myTableAppend.Rows(0).Item("Ma_E1")
                    myRow("So_TKHQ") = myTableAppend.Rows(0).Item("So_TKHQ")
                    myRow("So_Bien_Lai") = myTableAppend.Rows(0).Item("So_Bien_Lai")
                    myRow("So_Kho") = myTableAppend.Rows(0).Item("So_Kho")
                    myRow("Nguoi_Nhan") = myTableAppend.Rows(0).Item("Nguoi_Nhan")
                    myRow("Dia_Chi_Nhan") = myTableAppend.Rows(0).Item("Dia_Chi_Nhan")
                    myRow("Khoi_Luong") = myTableAppend.Rows(0).Item("Khoi_Luong")
                    myRow("Tong_Tien") = myTableAppend.Rows(0).Item("Tong_Tien")
                    myRow("Id_Duong_Thu") = myTableAppend.Rows(0).Item("Id_Duong_Thu")
                    myRow("Ten_Duong_Thu") = myTableAppend.Rows(0).Item("Ten_Duong_Thu")
                    myRow("Id_Chuyen_Thu") = myTableAppend.Rows(0).Item("Id_Chuyen_Thu")
                    myRow("So_Chuyen_Thu") = myTableAppend.Rows(0).Item("So_Chuyen_Thu")
                    myRow("Id_E2") = myTableAppend.Rows(0).Item("Id_E2")
                    myRow("Tui_So") = myTableAppend.Rows(0).Item("Tui_So")
                    myRow("Ma_Bc_Khai_Thac") = myTableAppend.Rows(0).Item("Ma_Bc_Khai_Thac")
                    myTable.Rows.Add(myRow)
                End If
            Next

            'Kiem tra neu khong co ban ghi thi thoat
            If myTable.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'Tiep tuc thuc hien neu co du lieu
            'Thong tin chi tiet
            myTable.TableName = "E1_Di_Giay_Bien_Nhan_Buu_Ta_Noi_Bo"
            'Paramete
            If GBuu_Cuc_Khai_Thac > 700000 Then
                pDien_Thoai = "9480632"
                pNgay_Thang_Nam = "Tp. HCM, ngày " & Today.Day.ToString("00") & " tháng " & Today.Month.ToString("00") & " năm " & Today.Year.ToString("00")
            Else
                pDien_Thoai = ""
                pNgay_Thang_Nam = "Hà Nội, ngày " & Today.Day.ToString("00") & " tháng " & Today.Month.ToString("00") & " năm " & Today.Year.ToString("00")
            End If
            'Dien thoai
            _pThamSo.Value = pDien_Thoai
            pvCollection.Add(_pThamSo)
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.DataDefinition.ParameterFields("pDien_Thoai").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            'Ngay_Thang_Nam
            _pThamSo.Value = pNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.DataDefinition.ParameterFields("pNgay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()

            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.SetDataSource(myTable)
            FrmView.rptViewer.ReportSource = RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo
            'Kiem tra xem co kho giay chua
            Dim i As Integer
            Dim rawKind As Integer = 0
            Dim printDoc As New System.Drawing.Printing.PrintDocument
            Dim mDefaulPrinterName As String
            mDefaulPrinterName = RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PrinterName
            printDoc.PrinterSettings.PrinterName = mDefaulPrinterName
Duyet_Tim_Kho_Giay:
            For i = 0 To printDoc.PrinterSettings.PaperSizes.Count - 1
                If printDoc.PrinterSettings.PaperSizes(i).PaperName = "Giay_Bien_Nhan" Then
                    rawKind = Convert.ToInt32(GetField(printDoc.PrinterSettings.PaperSizes(i), "kind"))
                End If
            Next
            If rawKind = 0 Then
                myPrint.AddCustomPaperSize(mDefaulPrinterName, "Giay_Bien_Nhan", 190.0F, 140.0F)
                GoTo Duyet_Tim_Kho_Giay
            End If
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PrinterDuplex = PrinterDuplex.Simplex
            RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize)
            Cursor.Current = Cursors.Default
            'Bat dau in
            If mPreview Then
                FrmView.ShowDialog()
            Else
                RptGiay_Bien_Nhan_Duong_Thu_Buu_Ta_Noi_Bo.PrintToPrinter(1, True, 0, 0)
            End If
            MessageBox.Show("Đã in thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error at: ====Print_Bien_Nhan_Theo_E1====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Lay_Danh_Sach_E1_Theo_E2_Duoc_Chon"
    Private Sub Lay_Danh_Sach_E1_Theo_E2_Duoc_Chon(ByVal mId_E2 As String)
        Try
            Dim mData As New DataTable
            mData = myE1_Di.E1_Di_Danh_Sach_Lay_Boi_Id_E2_Duong_Thu_Buu_Ta_Noi_Bo(mId_E2).Tables(0)
            Grid_E1_Di(mData)
        Catch ex As Exception
            MessageBox.Show("Error at: ====Lay_Danh_Sach_E1_Theo_E2_Duoc_Chon====" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

End Class

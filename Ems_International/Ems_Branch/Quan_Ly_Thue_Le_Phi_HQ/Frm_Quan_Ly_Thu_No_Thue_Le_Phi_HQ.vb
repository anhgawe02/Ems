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

Public Class Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ
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
    Friend WithEvents Panel_Main As System.Windows.Forms.Panel
    Friend WithEvents Panel_Thiet_Lap_Tham_So As System.Windows.Forms.Panel
    Friend WithEvents Group_No As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Cap_Nhat_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Thoat_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Thiet_Lap_Tham_So As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_Thoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents opt_Nhap_Theo_Ngay As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Nhap_Theo_Thang As System.Windows.Forms.RadioButton
    Friend WithEvents Group_Lua_Chon_Thoi_Gian As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Nhap_Theo_Khoang_Thoi_Gian As System.Windows.Forms.RadioButton
    Friend WithEvents Group_Duong_Thu As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Nhap_Theo_Tinh As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Nhap_Theo_Duong_Thu As System.Windows.Forms.RadioButton
    Friend WithEvents Group_Nhap_Chi_Tiet_Thu_No As System.Windows.Forms.GroupBox
    Friend WithEvents opt_Nhap_Theo_Tung_Ma_E1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Nhap_Lua_Chon_Tren_Luoi As System.Windows.Forms.RadioButton
    Friend WithEvents btnThong_Tin_No As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dtp_Tu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_Den_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMa_Tinh As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Ma_E1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel_Chua_Su_Dung_Den As System.Windows.Forms.Panel
    Friend WithEvents dtp_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Duong_Thu_Di As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cb_Thang As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_Nam As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Grid_Danh_Sach_Thu_No As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Grid_Danh_Sach_No_Theo_E1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btn_Tim As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Tong_Tien_Thu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtp_Ngay_Thu As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh_Theo_Duong_Thu", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("No_HQ", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E1")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_E2")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Chuyen_Thu")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Dong")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Dong")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Don_Vi")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("STT")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Nhan")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Tra")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khoi_Luong")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gia_Tri_Hang")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_KH")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Den_VN")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Nguoi_Dung")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Dac_Biet")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Tieu_Thu")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Qua_Tang")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Han_Ngach")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_Uu_Dai")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_VH")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_YT")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_DV")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_TV")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_Khac")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Le_Phi")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Le_Phi")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Da_Truyen")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thu_No")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ))
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("DuongThuDi", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Duong_Thu")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Thang", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thang")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Thang")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Nam", -1)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nam")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Panel_Main = New System.Windows.Forms.Panel
        Me.Grid_Danh_Sach_Thu_No = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.cbMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.dtp_Den_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_Tu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.Group_No = New Infragistics.Win.Misc.UltraGroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_Tim = New Infragistics.Win.Misc.UltraButton
        Me.Grid_Danh_Sach_No_Theo_E1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Tong_Tien_Thu = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.dtp_Ngay_Thu = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Ma_E1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btn_Thoat = New Infragistics.Win.Misc.UltraButton
        Me.btnThong_Tin_No = New Infragistics.Win.Misc.UltraButton
        Me.btn_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.Panel_Thiet_Lap_Tham_So = New System.Windows.Forms.Panel
        Me.Panel_Chua_Su_Dung_Den = New System.Windows.Forms.Panel
        Me.dtp_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.cb_Duong_Thu_Di = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.cb_Thang = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.cb_Nam = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.Group_Nhap_Chi_Tiet_Thu_No = New System.Windows.Forms.GroupBox
        Me.opt_Nhap_Theo_Tung_Ma_E1 = New System.Windows.Forms.RadioButton
        Me.opt_Nhap_Lua_Chon_Tren_Luoi = New System.Windows.Forms.RadioButton
        Me.Group_Duong_Thu = New System.Windows.Forms.GroupBox
        Me.opt_Nhap_Theo_Tinh = New System.Windows.Forms.RadioButton
        Me.opt_Nhap_Theo_Duong_Thu = New System.Windows.Forms.RadioButton
        Me.Group_Lua_Chon_Thoi_Gian = New System.Windows.Forms.GroupBox
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian = New System.Windows.Forms.RadioButton
        Me.opt_Nhap_Theo_Ngay = New System.Windows.Forms.RadioButton
        Me.opt_Nhap_Theo_Thang = New System.Windows.Forms.RadioButton
        Me.btn_Thoat_Thiet_Lap_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.btn_Cap_Nhat_Tham_So = New Infragistics.Win.Misc.UltraButton
        Me.Panel_Main.SuspendLayout()
        CType(Me.Grid_Danh_Sach_Thu_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Den_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Tu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_No, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_No.SuspendLayout()
        CType(Me.Grid_Danh_Sach_No_Theo_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Tong_Tien_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Ngay_Thu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ma_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Thiet_Lap_Tham_So.SuspendLayout()
        Me.Panel_Chua_Su_Dung_Den.SuspendLayout()
        CType(Me.dtp_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Duong_Thu_Di, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Nhap_Chi_Tiet_Thu_No.SuspendLayout()
        Me.Group_Duong_Thu.SuspendLayout()
        Me.Group_Lua_Chon_Thoi_Gian.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Main
        '
        Me.Panel_Main.Controls.Add(Me.Grid_Danh_Sach_Thu_No)
        Me.Panel_Main.Controls.Add(Me.UltraLabel2)
        Me.Panel_Main.Controls.Add(Me.cbMa_Tinh)
        Me.Panel_Main.Controls.Add(Me.dtp_Den_Ngay)
        Me.Panel_Main.Controls.Add(Me.Label2)
        Me.Panel_Main.Controls.Add(Me.dtp_Tu_Ngay)
        Me.Panel_Main.Controls.Add(Me.Label1)
        Me.Panel_Main.Controls.Add(Me.Group_No)
        Me.Panel_Main.Controls.Add(Me.btn_Thoat)
        Me.Panel_Main.Controls.Add(Me.btnThong_Tin_No)
        Me.Panel_Main.Controls.Add(Me.btn_Thiet_Lap_Tham_So)
        Me.Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Size = New System.Drawing.Size(800, 600)
        Me.Panel_Main.TabIndex = 3
        '
        'Grid_Danh_Sach_Thu_No
        '
        Me.Grid_Danh_Sach_Thu_No.Location = New System.Drawing.Point(8, 296)
        Me.Grid_Danh_Sach_Thu_No.Name = "Grid_Danh_Sach_Thu_No"
        Me.Grid_Danh_Sach_Thu_No.Size = New System.Drawing.Size(768, 256)
        Me.Grid_Danh_Sach_Thu_No.TabIndex = 28
        Me.Grid_Danh_Sach_Thu_No.Text = "Danh sách thu nợ"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(16, 48)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel2.TabIndex = 15
        Me.UltraLabel2.Text = "Mã Tỉnh"
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
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance1.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance1.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.cbMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance1
        Me.cbMa_Tinh.DisplayMember = "Ten_Tinh"
        Me.cbMa_Tinh.Location = New System.Drawing.Point(88, 48)
        Me.cbMa_Tinh.Name = "cbMa_Tinh"
        Me.cbMa_Tinh.Size = New System.Drawing.Size(96, 21)
        Me.cbMa_Tinh.TabIndex = 14
        Me.cbMa_Tinh.ValueMember = "Ma_Tinh"
        '
        'dtp_Den_Ngay
        '
        Me.dtp_Den_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtp_Den_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Den_Ngay.Location = New System.Drawing.Point(280, 16)
        Me.dtp_Den_Ngay.Name = "dtp_Den_Ngay"
        Me.dtp_Den_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.dtp_Den_Ngay.TabIndex = 11
        Me.dtp_Den_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "&Đến Ngày"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_Tu_Ngay
        '
        Me.dtp_Tu_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtp_Tu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Tu_Ngay.Location = New System.Drawing.Point(88, 16)
        Me.dtp_Tu_Ngay.Name = "dtp_Tu_Ngay"
        Me.dtp_Tu_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.dtp_Tu_Ngay.TabIndex = 9
        Me.dtp_Tu_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "&Từ Ngày"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Group_No
        '
        Me.Group_No.Controls.Add(Me.Label4)
        Me.Group_No.Controls.Add(Me.btn_Tim)
        Me.Group_No.Controls.Add(Me.Grid_Danh_Sach_No_Theo_E1)
        Me.Group_No.Controls.Add(Me.UltraLabel11)
        Me.Group_No.Controls.Add(Me.txt_Tong_Tien_Thu)
        Me.Group_No.Controls.Add(Me.UltraLabel5)
        Me.Group_No.Controls.Add(Me.dtp_Ngay_Thu)
        Me.Group_No.Controls.Add(Me.UltraLabel6)
        Me.Group_No.Controls.Add(Me.txt_Ma_E1)
        Me.Group_No.Location = New System.Drawing.Point(8, 80)
        Me.Group_No.Name = "Group_No"
        Me.Group_No.Size = New System.Drawing.Size(776, 200)
        Me.Group_No.SupportThemes = False
        Me.Group_No.TabIndex = 3
        Me.Group_No.Text = "Thu Nợ"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 8)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "------------------------------------------------------------------------------"
        '
        'btn_Tim
        '
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance2.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance2.TextVAlign = Infragistics.Win.VAlign.Bottom
        Me.btn_Tim.Appearance = Appearance2
        Me.btn_Tim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tim.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_Tim.Location = New System.Drawing.Point(232, 32)
        Me.btn_Tim.Name = "btn_Tim"
        Me.btn_Tim.Size = New System.Drawing.Size(56, 40)
        Me.btn_Tim.TabIndex = 28
        Me.btn_Tim.Text = "Tìm"
        '
        'Grid_Danh_Sach_No_Theo_E1
        '
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Caption = "Mã Tỉnh"
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.VisiblePosition = 9
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.VisiblePosition = 10
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Nước Nhận"
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.VisiblePosition = 12
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Mã E1"
        UltraGridColumn17.Header.VisiblePosition = 13
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Mã Bc Trả"
        UltraGridColumn19.Header.VisiblePosition = 15
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Khối Lượng"
        UltraGridColumn20.Header.VisiblePosition = 16
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Phân Loại"
        UltraGridColumn21.Header.VisiblePosition = 17
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.VisiblePosition = 18
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 19
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 20
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.VisiblePosition = 21
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.VisiblePosition = 22
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.VisiblePosition = 23
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Header.VisiblePosition = 24
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.VisiblePosition = 25
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.Caption = "Ghi Chú"
        UltraGridColumn30.Header.VisiblePosition = 26
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Header.Caption = "Ngày Đến VN"
        UltraGridColumn31.Header.VisiblePosition = 27
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 40
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Header.VisiblePosition = 28
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Header.Caption = "Số TKHQ"
        UltraGridColumn33.Header.VisiblePosition = 29
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 44
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.Caption = "Số Biên Lai"
        UltraGridColumn34.Header.VisiblePosition = 30
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.VisiblePosition = 31
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 48
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.VisiblePosition = 32
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.VisiblePosition = 33
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.VisiblePosition = 34
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.VisiblePosition = 35
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 56
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.VisiblePosition = 36
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Header.VisiblePosition = 37
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.Caption = "Tổng Thuế"
        UltraGridColumn42.Header.VisiblePosition = 38
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 62
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.VisiblePosition = 39
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 64
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Header.VisiblePosition = 40
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 66
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Header.VisiblePosition = 41
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 68
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Header.VisiblePosition = 42
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 70
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Header.VisiblePosition = 43
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Header.VisiblePosition = 44
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.Caption = "Tổng Lệ Phí"
        UltraGridColumn49.Header.VisiblePosition = 45
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.Caption = "Tổng Thuế Lệ Phí"
        UltraGridColumn50.Header.VisiblePosition = 46
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 78
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.VisiblePosition = 47
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 80
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Header.VisiblePosition = 48
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 82
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.VisiblePosition = 49
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 84
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.VisiblePosition = 50
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 86
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.Caption = "Thu Nợ"
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55})
        UltraGridBand2.UseRowLayout = True
        Me.Grid_Danh_Sach_No_Theo_E1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid_Danh_Sach_No_Theo_E1.Location = New System.Drawing.Point(296, 16)
        Me.Grid_Danh_Sach_No_Theo_E1.Name = "Grid_Danh_Sach_No_Theo_E1"
        Me.Grid_Danh_Sach_No_Theo_E1.Size = New System.Drawing.Size(472, 176)
        Me.Grid_Danh_Sach_No_Theo_E1.TabIndex = 27
        Me.Grid_Danh_Sach_No_Theo_E1.Text = "Danh sách nợ theo E1"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Location = New System.Drawing.Point(32, 152)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(80, 25)
        Me.UltraLabel11.TabIndex = 20
        Me.UltraLabel11.Text = "&Tổng Tiền"
        '
        'txt_Tong_Tien_Thu
        '
        Me.txt_Tong_Tien_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tong_Tien_Thu.Location = New System.Drawing.Point(120, 152)
        Me.txt_Tong_Tien_Thu.Name = "txt_Tong_Tien_Thu"
        Me.txt_Tong_Tien_Thu.Size = New System.Drawing.Size(120, 24)
        Me.txt_Tong_Tien_Thu.TabIndex = 21
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(16, 40)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(70, 25)
        Me.UltraLabel5.TabIndex = 14
        Me.UltraLabel5.Text = "Số Hiệu &E1"
        '
        'dtp_Ngay_Thu
        '
        Me.dtp_Ngay_Thu.DateTime = New Date(2008, 9, 16, 0, 0, 0, 0)
        Me.dtp_Ngay_Thu.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Ngay_Thu.Location = New System.Drawing.Point(120, 120)
        Me.dtp_Ngay_Thu.Name = "dtp_Ngay_Thu"
        Me.dtp_Ngay_Thu.Size = New System.Drawing.Size(120, 21)
        Me.dtp_Ngay_Thu.TabIndex = 17
        Me.dtp_Ngay_Thu.Value = New Date(2008, 9, 16, 0, 0, 0, 0)
        '
        'UltraLabel6
        '
        Me.UltraLabel6.Location = New System.Drawing.Point(32, 120)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(84, 25)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "N&gày Thu"
        '
        'txt_Ma_E1
        '
        Me.txt_Ma_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ma_E1.Location = New System.Drawing.Point(96, 40)
        Me.txt_Ma_E1.Name = "txt_Ma_E1"
        Me.txt_Ma_E1.Size = New System.Drawing.Size(128, 24)
        Me.txt_Ma_E1.TabIndex = 15
        '
        'btn_Thoat
        '
        Appearance3.Image = CType(resources.GetObject("Appearance3.Image"), Object)
        Me.btn_Thoat.Appearance = Appearance3
        Me.btn_Thoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Thoat.Location = New System.Drawing.Point(664, 8)
        Me.btn_Thoat.Name = "btn_Thoat"
        Me.btn_Thoat.Size = New System.Drawing.Size(88, 32)
        Me.btn_Thoat.TabIndex = 5
        Me.btn_Thoat.Text = "&Thoát"
        '
        'btnThong_Tin_No
        '
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Me.btnThong_Tin_No.Appearance = Appearance4
        Me.btnThong_Tin_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThong_Tin_No.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnThong_Tin_No.Location = New System.Drawing.Point(400, 8)
        Me.btnThong_Tin_No.Name = "btnThong_Tin_No"
        Me.btnThong_Tin_No.Size = New System.Drawing.Size(112, 32)
        Me.btnThong_Tin_No.TabIndex = 6
        Me.btnThong_Tin_No.Text = "&Lấy thông tin"
        '
        'btn_Thiet_Lap_Tham_So
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Me.btn_Thiet_Lap_Tham_So.Appearance = Appearance5
        Me.btn_Thiet_Lap_Tham_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thiet_Lap_Tham_So.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(520, 8)
        Me.btn_Thiet_Lap_Tham_So.Name = "btn_Thiet_Lap_Tham_So"
        Me.btn_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(132, 32)
        Me.btn_Thiet_Lap_Tham_So.TabIndex = 7
        Me.btn_Thiet_Lap_Tham_So.Text = "&Thiết lập tham số"
        '
        'Panel_Thiet_Lap_Tham_So
        '
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.Panel_Chua_Su_Dung_Den)
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.Group_Nhap_Chi_Tiet_Thu_No)
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.Group_Duong_Thu)
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.Group_Lua_Chon_Thoi_Gian)
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Thoat_Thiet_Lap_Tham_So)
        Me.Panel_Thiet_Lap_Tham_So.Controls.Add(Me.btn_Cap_Nhat_Tham_So)
        Me.Panel_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Thiet_Lap_Tham_So.Name = "Panel_Thiet_Lap_Tham_So"
        Me.Panel_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(800, 600)
        Me.Panel_Thiet_Lap_Tham_So.TabIndex = 4
        '
        'Panel_Chua_Su_Dung_Den
        '
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.dtp_Ngay)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.Label3)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.cb_Duong_Thu_Di)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.UltraLabel1)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.cb_Thang)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.Label8)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.cb_Nam)
        Me.Panel_Chua_Su_Dung_Den.Controls.Add(Me.Label6)
        Me.Panel_Chua_Su_Dung_Den.Location = New System.Drawing.Point(8, 280)
        Me.Panel_Chua_Su_Dung_Den.Name = "Panel_Chua_Su_Dung_Den"
        Me.Panel_Chua_Su_Dung_Den.Size = New System.Drawing.Size(424, 120)
        Me.Panel_Chua_Su_Dung_Den.TabIndex = 80
        '
        'dtp_Ngay
        '
        Me.dtp_Ngay.DateTime = New Date(2009, 2, 9, 0, 0, 0, 0)
        Me.dtp_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.dtp_Ngay.Location = New System.Drawing.Point(88, 32)
        Me.dtp_Ngay.Name = "dtp_Ngay"
        Me.dtp_Ngay.Size = New System.Drawing.Size(112, 21)
        Me.dtp_Ngay.TabIndex = 3
        Me.dtp_Ngay.Value = New Date(2009, 2, 9, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Ngày khai thác"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_Duong_Thu_Di
        '
        Me.cb_Duong_Thu_Di.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn56.Header.Caption = "Mã Bưu Cục"
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn57.Header.Caption = "Tên Bưu Cục"
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn58.Header.VisiblePosition = 2
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.Caption = "Phân Loại Đường Thư"
        UltraGridColumn59.Header.VisiblePosition = 3
        UltraGridColumn59.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        UltraGridBand3.Header.Caption = "Mã Đường Thư"
        Me.cb_Duong_Thu_Di.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.cb_Duong_Thu_Di.DisplayMember = ""
        Me.cb_Duong_Thu_Di.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Duong_Thu_Di.Location = New System.Drawing.Point(152, 8)
        Me.cb_Duong_Thu_Di.Name = "cb_Duong_Thu_Di"
        Me.cb_Duong_Thu_Di.Size = New System.Drawing.Size(104, 21)
        Me.cb_Duong_Thu_Di.TabIndex = 13
        Me.cb_Duong_Thu_Di.ValueMember = ""
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(56, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(89, 23)
        Me.UltraLabel1.TabIndex = 12
        Me.UltraLabel1.Text = "Đường T&hư"
        '
        'cb_Thang
        '
        Me.cb_Thang.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn60.Header.Caption = "Tháng"
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn61.Header.Caption = "Tên Tháng"
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61})
        Me.cb_Thang.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cb_Thang.DisplayMember = "Thang"
        Me.cb_Thang.Location = New System.Drawing.Point(192, 72)
        Me.cb_Thang.Name = "cb_Thang"
        Me.cb_Thang.Size = New System.Drawing.Size(64, 21)
        Me.cb_Thang.TabIndex = 51
        Me.cb_Thang.ValueMember = "Thang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(144, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "&Tháng"
        '
        'cb_Nam
        '
        Me.cb_Nam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn62.Header.Caption = "Năm"
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn62})
        Me.cb_Nam.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.cb_Nam.DisplayMember = "Nam"
        Me.cb_Nam.Location = New System.Drawing.Point(64, 72)
        Me.cb_Nam.Name = "cb_Nam"
        Me.cb_Nam.Size = New System.Drawing.Size(72, 21)
        Me.cb_Nam.TabIndex = 50
        Me.cb_Nam.ValueMember = "Nam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-96, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 18)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Năm"
        '
        'Group_Nhap_Chi_Tiet_Thu_No
        '
        Me.Group_Nhap_Chi_Tiet_Thu_No.Controls.Add(Me.opt_Nhap_Theo_Tung_Ma_E1)
        Me.Group_Nhap_Chi_Tiet_Thu_No.Controls.Add(Me.opt_Nhap_Lua_Chon_Tren_Luoi)
        Me.Group_Nhap_Chi_Tiet_Thu_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Nhap_Chi_Tiet_Thu_No.Location = New System.Drawing.Point(8, 160)
        Me.Group_Nhap_Chi_Tiet_Thu_No.Name = "Group_Nhap_Chi_Tiet_Thu_No"
        Me.Group_Nhap_Chi_Tiet_Thu_No.Size = New System.Drawing.Size(472, 112)
        Me.Group_Nhap_Chi_Tiet_Thu_No.TabIndex = 79
        Me.Group_Nhap_Chi_Tiet_Thu_No.TabStop = False
        Me.Group_Nhap_Chi_Tiet_Thu_No.Text = "Nhập Chi Tiết Thu Nợ"
        '
        'opt_Nhap_Theo_Tung_Ma_E1
        '
        Me.opt_Nhap_Theo_Tung_Ma_E1.Location = New System.Drawing.Point(24, 32)
        Me.opt_Nhap_Theo_Tung_Ma_E1.Name = "opt_Nhap_Theo_Tung_Ma_E1"
        Me.opt_Nhap_Theo_Tung_Ma_E1.Size = New System.Drawing.Size(160, 24)
        Me.opt_Nhap_Theo_Tung_Ma_E1.TabIndex = 2
        Me.opt_Nhap_Theo_Tung_Ma_E1.Text = "Nhập Theo Từng Mã E1"
        '
        'opt_Nhap_Lua_Chon_Tren_Luoi
        '
        Me.opt_Nhap_Lua_Chon_Tren_Luoi.Location = New System.Drawing.Point(24, 64)
        Me.opt_Nhap_Lua_Chon_Tren_Luoi.Name = "opt_Nhap_Lua_Chon_Tren_Luoi"
        Me.opt_Nhap_Lua_Chon_Tren_Luoi.Size = New System.Drawing.Size(184, 24)
        Me.opt_Nhap_Lua_Chon_Tren_Luoi.TabIndex = 3
        Me.opt_Nhap_Lua_Chon_Tren_Luoi.Text = "Nhập Lựa Chọn Trên Lưới"
        '
        'Group_Duong_Thu
        '
        Me.Group_Duong_Thu.Controls.Add(Me.opt_Nhap_Theo_Tinh)
        Me.Group_Duong_Thu.Controls.Add(Me.opt_Nhap_Theo_Duong_Thu)
        Me.Group_Duong_Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Duong_Thu.Location = New System.Drawing.Point(248, 10)
        Me.Group_Duong_Thu.Name = "Group_Duong_Thu"
        Me.Group_Duong_Thu.Size = New System.Drawing.Size(224, 128)
        Me.Group_Duong_Thu.TabIndex = 78
        Me.Group_Duong_Thu.TabStop = False
        Me.Group_Duong_Thu.Text = "Thông tin đơn vị"
        '
        'opt_Nhap_Theo_Tinh
        '
        Me.opt_Nhap_Theo_Tinh.Location = New System.Drawing.Point(8, 18)
        Me.opt_Nhap_Theo_Tinh.Name = "opt_Nhap_Theo_Tinh"
        Me.opt_Nhap_Theo_Tinh.Size = New System.Drawing.Size(160, 24)
        Me.opt_Nhap_Theo_Tinh.TabIndex = 0
        Me.opt_Nhap_Theo_Tinh.Text = "Nhập Theo Từng Tỉnh"
        '
        'opt_Nhap_Theo_Duong_Thu
        '
        Me.opt_Nhap_Theo_Duong_Thu.Location = New System.Drawing.Point(8, 56)
        Me.opt_Nhap_Theo_Duong_Thu.Name = "opt_Nhap_Theo_Duong_Thu"
        Me.opt_Nhap_Theo_Duong_Thu.Size = New System.Drawing.Size(152, 24)
        Me.opt_Nhap_Theo_Duong_Thu.TabIndex = 1
        Me.opt_Nhap_Theo_Duong_Thu.Text = "Nhập Theo Đường Thư"
        '
        'Group_Lua_Chon_Thoi_Gian
        '
        Me.Group_Lua_Chon_Thoi_Gian.Controls.Add(Me.opt_Nhap_Theo_Khoang_Thoi_Gian)
        Me.Group_Lua_Chon_Thoi_Gian.Controls.Add(Me.opt_Nhap_Theo_Ngay)
        Me.Group_Lua_Chon_Thoi_Gian.Controls.Add(Me.opt_Nhap_Theo_Thang)
        Me.Group_Lua_Chon_Thoi_Gian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Lua_Chon_Thoi_Gian.Location = New System.Drawing.Point(10, 10)
        Me.Group_Lua_Chon_Thoi_Gian.Name = "Group_Lua_Chon_Thoi_Gian"
        Me.Group_Lua_Chon_Thoi_Gian.Size = New System.Drawing.Size(222, 134)
        Me.Group_Lua_Chon_Thoi_Gian.TabIndex = 77
        Me.Group_Lua_Chon_Thoi_Gian.TabStop = False
        Me.Group_Lua_Chon_Thoi_Gian.Text = "Lựa chọn về thời gian"
        '
        'opt_Nhap_Theo_Khoang_Thoi_Gian
        '
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian.Location = New System.Drawing.Point(8, 56)
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian.Name = "opt_Nhap_Theo_Khoang_Thoi_Gian"
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian.Size = New System.Drawing.Size(208, 24)
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian.TabIndex = 2
        Me.opt_Nhap_Theo_Khoang_Thoi_Gian.Text = "Nhập Theo Khoảng Thời Gian"
        '
        'opt_Nhap_Theo_Ngay
        '
        Me.opt_Nhap_Theo_Ngay.Location = New System.Drawing.Point(8, 18)
        Me.opt_Nhap_Theo_Ngay.Name = "opt_Nhap_Theo_Ngay"
        Me.opt_Nhap_Theo_Ngay.Size = New System.Drawing.Size(152, 24)
        Me.opt_Nhap_Theo_Ngay.TabIndex = 0
        Me.opt_Nhap_Theo_Ngay.Text = "Nhập Theo Từng Ngày"
        '
        'opt_Nhap_Theo_Thang
        '
        Me.opt_Nhap_Theo_Thang.Location = New System.Drawing.Point(8, 96)
        Me.opt_Nhap_Theo_Thang.Name = "opt_Nhap_Theo_Thang"
        Me.opt_Nhap_Theo_Thang.Size = New System.Drawing.Size(144, 24)
        Me.opt_Nhap_Theo_Thang.TabIndex = 1
        Me.opt_Nhap_Theo_Thang.Text = "Nhập Theo Tháng"
        '
        'btn_Thoat_Thiet_Lap_Tham_So
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btn_Thoat_Thiet_Lap_Tham_So.Appearance = Appearance6
        Me.btn_Thoat_Thiet_Lap_Tham_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Thoat_Thiet_Lap_Tham_So.Location = New System.Drawing.Point(200, 424)
        Me.btn_Thoat_Thiet_Lap_Tham_So.Name = "btn_Thoat_Thiet_Lap_Tham_So"
        Me.btn_Thoat_Thiet_Lap_Tham_So.Size = New System.Drawing.Size(128, 48)
        Me.btn_Thoat_Thiet_Lap_Tham_So.TabIndex = 73
        Me.btn_Thoat_Thiet_Lap_Tham_So.Text = "Thoát"
        '
        'btn_Cap_Nhat_Tham_So
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btn_Cap_Nhat_Tham_So.Appearance = Appearance7
        Me.btn_Cap_Nhat_Tham_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cap_Nhat_Tham_So.Location = New System.Drawing.Point(48, 424)
        Me.btn_Cap_Nhat_Tham_So.Name = "btn_Cap_Nhat_Tham_So"
        Me.btn_Cap_Nhat_Tham_So.Size = New System.Drawing.Size(128, 48)
        Me.btn_Cap_Nhat_Tham_So.TabIndex = 72
        Me.btn_Cap_Nhat_Tham_So.Text = "Cập Nhật"
        '
        'Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Panel_Main)
        Me.Controls.Add(Me.Panel_Thiet_Lap_Tham_So)
        Me.Name = "Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ"
        Me.Text = "Quản lý thu nợ thuế và lệ phí hải quan"
        Me.Panel_Main.ResumeLayout(False)
        CType(Me.Grid_Danh_Sach_Thu_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Den_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Tu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_No, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_No.ResumeLayout(False)
        CType(Me.Grid_Danh_Sach_No_Theo_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Tong_Tien_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Ngay_Thu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ma_E1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Thiet_Lap_Tham_So.ResumeLayout(False)
        Me.Panel_Chua_Su_Dung_Den.ResumeLayout(False)
        CType(Me.dtp_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Duong_Thu_Di, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Thang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Nam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Nhap_Chi_Tiet_Thu_No.ResumeLayout(False)
        Me.Group_Duong_Thu.ResumeLayout(False)
        Me.Group_Lua_Chon_Thoi_Gian.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo biến"
    Dim myHam_Dung_Chung As New Ham_Dung_Chung

#End Region

    '-------------------------------------------------------------------------------------

#Region "----------------Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ_Load----------------"
    Private Sub Frm_Quan_Ly_Thu_No_Thue_Le_Phi_HQ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Design_Form()

        Init_Form()
    End Sub
#End Region

#Region "----------------Design_Form----------------"
    Private Sub Design_Form()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "----------------Init_Form----------------"
    Private Sub Init_Form()
        Try
            Text = "Thu Nợ Thuế và Lệ Phí Hải Quan Lần 1"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "================Thiết lập tham số ================"
#Region "----------------btn_Thiet_Lap_Tham_So_Click----------------"
    Private Sub btn_Thiet_Lap_Tham_So_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thiet_Lap_Tham_So.Click
        Panel_Main.Visible = False
        Panel_Thiet_Lap_Tham_So.Visible = True

        Load_Panel_Thiet_Lap_Tham_So()
    End Sub
#End Region

#Region "----------------Load_Panel_Thiet_Lap_Tham_So----------------"
    Private Sub Load_Panel_Thiet_Lap_Tham_So()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "----------------btn_Cap_Nhat_Tham_So_Click----------------"
    Private Sub btn_Cap_Nhat_Tham_So_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cap_Nhat_Tham_So.Click
        Try




            If MessageBox.Show("Cập Nhật Tham Số Thành Công!!!" & vbNewLine & "Bạn có muốn thoát không???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Panel_Main.Visible = True
                Panel_Thiet_Lap_Tham_So.Visible = False

                Load_Tham_So()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "----------------Load_Tham_So----------------"
    Private Sub Load_Tham_So()
        Try

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "----------------btn_Thoat_Thiet_Lap_Tham_So_Click----------------"
    Private Sub btn_Thoat_Thiet_Lap_Tham_So_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thoat_Thiet_Lap_Tham_So.Click
        Panel_Main.Visible = True
        Panel_Thiet_Lap_Tham_So.Visible = False

        Load_Tham_So()
    End Sub
#End Region
#End Region

#Region "----------------btn_Thoat_Click----------------"
    Private Sub btn_Thoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Thoat.Click
        Close()
        Dispose()
    End Sub
#End Region

#Region "----------------btnThong_Tin_No_Click----------------"
    Private Sub btnThong_Tin_No_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThong_Tin_No.Click
        Try
            Dim Dataset_Danh_Sach_No As New DataSet
            'Lấy khoảng thời gian
            Dim Lua_Chon_Thoi_Gian As Integer = 1
            Dim Tu_Ngay As Integer
            Dim Den_Ngay As Integer
            Select Case Lua_Chon_Thoi_Gian
                Case 1 'Nhập Theo Tháng
                    Dim Nam As Integer
                    Dim Thang As Integer
                    Dim Ngay_Dau_Thang As Integer
                    Nam = CInt(cb_Nam.Text)
                    Thang = CInt(cb_Thang.Text)
                    Ngay_Dau_Thang = Nam * 10000 + Thang * 100 + 1

                    Tu_Ngay = Ngay_Dau_Thang
                    Den_Ngay = myHam_Dung_Chung.ConvertDateToInt(myHam_Dung_Chung.dEndMonth(myHam_Dung_Chung.ConvertIntToDate(Ngay_Dau_Thang)))
                Case 2 'Nhập Theo Khoảng Thời Gian
                    Tu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtp_Tu_Ngay.DateTime)
                    Den_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtp_Den_Ngay.DateTime)
                Case 3 'Nhập Theo Ngày
                    Tu_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtp_Ngay.DateTime)
                    Den_Ngay = myHam_Dung_Chung.ConvertDateToInt(dtp_Ngay.DateTime)
            End Select
            'Lấy đường thư
            Dim Lua_Chon_Duong_Thu As Integer = 1
            Dim Id_Duong_Thu As String
            Dim Ma_Duong_Thu As Integer
            Dim Ma_Tinh As Integer
            Select Case Lua_Chon_Duong_Thu
                Case 1 ' Theo Tỉnh
                    Ma_Tinh = CInt(cbMa_Tinh.Text)
                    Dataset_Danh_Sach_No = Danh_Sach_No_Theo_Tinh(GBuu_Cuc_Khai_Thac, Ma_Tinh, Tu_Ngay, Den_Ngay)
                Case 2 ' Theo Đường Thư
                    Ma_Duong_Thu = CInt(cb_Duong_Thu_Di.Text)
                    'Lấy đường thư
                    Id_Duong_Thu = CreateId_Duong_Thu(GBuu_Cuc_Khai_Thac, Ma_Duong_Thu)
                    Dataset_Danh_Sach_No = Danh_Sach_No_Theo_Duong_Thu(Id_Duong_Thu, Tu_Ngay, Den_Ngay)
            End Select

            If Dataset_Danh_Sach_No.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu cần tìm!!!", "Thông báo", MessageBoxButtons.OK)
                Exit Sub
            End If

            'Lấy dữ liệu nợ
            Load_Grid_Danh_Sach_No(Dataset_Danh_Sach_No)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "----------------Danh_Sach_No_Theo_Tinh----------------"
    Private Function Danh_Sach_No_Theo_Tinh(ByVal Ma_Bc_Khai_Thac As Integer, ByVal Ma_Tinh As Integer, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

    End Function
#End Region

#Region "----------------Danh_Sach_No_Theo_Duong_Thu----------------"
    Private Function Danh_Sach_No_Theo_Duong_Thu(ByVal Id_Duong_Thu As String, ByVal Tu_Ngay As Integer, ByVal Den_Ngay As Integer) As DataSet

    End Function
#End Region

#Region "----------------Load_Grid_Danh_Sach_No----------------"
    Private Sub Load_Grid_Danh_Sach_No(ByVal Dataset_Danh_Sach_No As DataSet)

    End Sub
#End Region
#End Region
    

    Private Sub Grid_Danh_Sach_No_Theo_E1_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid_Danh_Sach_No_Theo_E1.InitializeLayout

    End Sub

    Private Sub Grid_Danh_Sach_Thu_No_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles Grid_Danh_Sach_Thu_No.InitializeLayout

    End Sub

    Private Sub btn_Tim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tim.Click
        If Grid_Danh_Sach_No_Theo_E1.Rows.Count > 0 Then
            dtp_Ngay_Thu.Enabled = True
            txt_Tong_Tien_Thu.Enabled = True
        Else
            dtp_Ngay_Thu.Enabled = False
            txt_Tong_Tien_Thu.Enabled = False
        End If
    End Sub

End Class

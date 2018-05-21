Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Ems_International_Logic.EMS

Public Class FrmTimKiemE1
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
    Friend WithEvents CbTu_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents TxSo_Hieu_E1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents LbTu_Ngay As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents LbDen_Ngay As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents LbSo_Hieu_E1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnTim As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OptTim_Gan_Dung As System.Windows.Forms.RadioButton
    Friend WithEvents LbThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ddLy_Do As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMa_Tinh As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents dgChi_Tiet_Phat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgChi_Tiet_Di_Den As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dgMa_E1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents optTimTheoDiaChi As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_ChinhXacE1 As System.Windows.Forms.RadioButton
    Friend WithEvents LbBuu_Cuc As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents LbNuoc As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDau_Ma As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CbBuu_Cuc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CbNuoc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents LbDau_Ma As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnBao_Phat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Group_LuaChon As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Group_ThoiGian As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Group_ThongTinTim As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ddXu_Ly As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents OptTat_Ca_Dau_Ma As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ly_Do", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Ly_Do_EN")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("To_Hop_Xu_Ly")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bao_Phat", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_BC_Phat")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Gio_Phat")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phat_Duoc")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Ly_Do")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("E1_Di_Den", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Khai_Thac")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Huong")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Gio")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chi_Tiet")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Bc_Tra")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NgayCakt")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Dung")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Phan_Loai_BP")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_Bien_Lai")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_VAT")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thue_NK_VAT")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Bao_Phat", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_E1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Dau_Ma", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dau_Ma")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Tinh", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tinh")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Tinh")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thoa_Thuan")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loai")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Khu_Vuc")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Xu_Ly", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Xu_Ly")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Xu_Ly_EN")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTimKiemE1))
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.TxSo_Hieu_E1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.BtnTim = New Infragistics.Win.Misc.UltraButton
        Me.LbTu_Ngay = New Infragistics.Win.Misc.UltraLabel
        Me.LbDen_Ngay = New Infragistics.Win.Misc.UltraLabel
        Me.LbSo_Hieu_E1 = New Infragistics.Win.Misc.UltraLabel
        Me.Group_LuaChon = New Infragistics.Win.Misc.UltraGroupBox
        Me.Opt_ChinhXacE1 = New System.Windows.Forms.RadioButton
        Me.optTimTheoDiaChi = New System.Windows.Forms.RadioButton
        Me.OptTim_Gan_Dung = New System.Windows.Forms.RadioButton
        Me.OptTat_Ca_Dau_Ma = New System.Windows.Forms.RadioButton
        Me.LbThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.ddLy_Do = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.ddMa_Tinh = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.dgChi_Tiet_Phat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgChi_Tiet_Di_Den = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.dgMa_E1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Group_ThoiGian = New Infragistics.Win.Misc.UltraGroupBox
        Me.LbBuu_Cuc = New Infragistics.Win.Misc.UltraLabel
        Me.LbNuoc = New Infragistics.Win.Misc.UltraLabel
        Me.CbDau_Ma = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CbBuu_Cuc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.CbNuoc = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.LbDau_Ma = New Infragistics.Win.Misc.UltraLabel
        Me.Group_ThongTinTim = New Infragistics.Win.Misc.UltraGroupBox
        Me.BtnBao_Phat = New Infragistics.Win.Misc.UltraButton
        Me.ddXu_Ly = New Infragistics.Win.UltraWinGrid.UltraDropDown
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxSo_Hieu_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_LuaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_LuaChon.SuspendLayout()
        CType(Me.ddLy_Do, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Tinh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChi_Tiet_Phat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgChi_Tiet_Di_Den, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMa_E1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_ThoiGian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_ThoiGian.SuspendLayout()
        CType(Me.CbDau_Ma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbBuu_Cuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbNuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_ThongTinTim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_ThongTinTim.SuspendLayout()
        CType(Me.ddXu_Ly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2009, 5, 13, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(8, 32)
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(104, 21)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2009, 5, 13, 0, 0, 0, 0)
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 5, 13, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(160, 32)
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(96, 21)
        Me.CbDen_Ngay.TabIndex = 3
        Me.CbDen_Ngay.Value = New Date(2009, 5, 13, 0, 0, 0, 0)
        '
        'TxSo_Hieu_E1
        '
        Me.TxSo_Hieu_E1.Location = New System.Drawing.Point(208, 24)
        Me.TxSo_Hieu_E1.Name = "TxSo_Hieu_E1"
        Me.TxSo_Hieu_E1.Size = New System.Drawing.Size(240, 21)
        Me.TxSo_Hieu_E1.TabIndex = 1
        '
        'BtnTim
        '
        Me.BtnTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTim.Location = New System.Drawing.Point(536, 72)
        Me.BtnTim.Name = "BtnTim"
        Me.BtnTim.Size = New System.Drawing.Size(64, 48)
        Me.BtnTim.TabIndex = 1
        Me.BtnTim.Text = "Tìm"
        '
        'LbTu_Ngay
        '
        Me.LbTu_Ngay.Location = New System.Drawing.Point(16, 8)
        Me.LbTu_Ngay.Name = "LbTu_Ngay"
        Me.LbTu_Ngay.Size = New System.Drawing.Size(88, 16)
        Me.LbTu_Ngay.TabIndex = 0
        Me.LbTu_Ngay.Text = "Từ ngày"
        '
        'LbDen_Ngay
        '
        Me.LbDen_Ngay.Location = New System.Drawing.Point(160, 8)
        Me.LbDen_Ngay.Name = "LbDen_Ngay"
        Me.LbDen_Ngay.Size = New System.Drawing.Size(96, 16)
        Me.LbDen_Ngay.TabIndex = 2
        Me.LbDen_Ngay.Text = "Đến ngày"
        '
        'LbSo_Hieu_E1
        '
        Me.LbSo_Hieu_E1.Location = New System.Drawing.Point(208, 8)
        Me.LbSo_Hieu_E1.Name = "LbSo_Hieu_E1"
        Me.LbSo_Hieu_E1.Size = New System.Drawing.Size(104, 16)
        Me.LbSo_Hieu_E1.TabIndex = 0
        Me.LbSo_Hieu_E1.Text = "Số hiệu E1"
        '
        'Group_LuaChon
        '
        Me.Group_LuaChon.Controls.Add(Me.Opt_ChinhXacE1)
        Me.Group_LuaChon.Controls.Add(Me.optTimTheoDiaChi)
        Me.Group_LuaChon.Controls.Add(Me.OptTim_Gan_Dung)
        Me.Group_LuaChon.Controls.Add(Me.OptTat_Ca_Dau_Ma)
        Me.Group_LuaChon.Location = New System.Drawing.Point(336, 0)
        Me.Group_LuaChon.Name = "Group_LuaChon"
        Me.Group_LuaChon.Size = New System.Drawing.Size(384, 64)
        Me.Group_LuaChon.SupportThemes = False
        Me.Group_LuaChon.TabIndex = 3
        '
        'Opt_ChinhXacE1
        '
        Me.Opt_ChinhXacE1.Location = New System.Drawing.Point(32, 8)
        Me.Opt_ChinhXacE1.Name = "Opt_ChinhXacE1"
        Me.Opt_ChinhXacE1.Size = New System.Drawing.Size(120, 16)
        Me.Opt_ChinhXacE1.TabIndex = 0
        Me.Opt_ChinhXacE1.Text = "Theo chính xác E1"
        '
        'optTimTheoDiaChi
        '
        Me.optTimTheoDiaChi.Location = New System.Drawing.Point(232, 32)
        Me.optTimTheoDiaChi.Name = "optTimTheoDiaChi"
        Me.optTimTheoDiaChi.Size = New System.Drawing.Size(120, 16)
        Me.optTimTheoDiaChi.TabIndex = 3
        Me.optTimTheoDiaChi.Text = "Theo Địa chỉ nhận"
        '
        'OptTim_Gan_Dung
        '
        Me.OptTim_Gan_Dung.Location = New System.Drawing.Point(232, 8)
        Me.OptTim_Gan_Dung.Name = "OptTim_Gan_Dung"
        Me.OptTim_Gan_Dung.Size = New System.Drawing.Size(120, 16)
        Me.OptTim_Gan_Dung.TabIndex = 2
        Me.OptTim_Gan_Dung.Text = "Theo E1 gần đúng"
        '
        'OptTat_Ca_Dau_Ma
        '
        Me.OptTat_Ca_Dau_Ma.Location = New System.Drawing.Point(32, 32)
        Me.OptTat_Ca_Dau_Ma.Name = "OptTat_Ca_Dau_Ma"
        Me.OptTat_Ca_Dau_Ma.Size = New System.Drawing.Size(120, 16)
        Me.OptTat_Ca_Dau_Ma.TabIndex = 1
        Me.OptTat_Ca_Dau_Ma.Text = "Theo  tất các đầu E"
        '
        'LbThong_Tin
        '
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.LbThong_Tin.Appearance = Appearance1
        Me.LbThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbThong_Tin.Location = New System.Drawing.Point(136, 320)
        Me.LbThong_Tin.Name = "LbThong_Tin"
        Me.LbThong_Tin.Size = New System.Drawing.Size(600, 168)
        Me.LbThong_Tin.TabIndex = 7
        '
        'ddLy_Do
        '
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddLy_Do.DisplayLayout.Appearance = Appearance2
        Appearance3.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn1.Header.Appearance = Appearance3
        UltraGridColumn1.Header.Caption = "Mã LD"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 40
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn2.Header.Appearance = Appearance4
        UltraGridColumn2.Header.Caption = "Tên lý do"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 200
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ddLy_Do.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddLy_Do.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.ddLy_Do.DisplayMember = "Ten_Ly_Do"
        Me.ddLy_Do.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddLy_Do.Location = New System.Drawing.Point(440, 296)
        Me.ddLy_Do.Name = "ddLy_Do"
        Me.ddLy_Do.Size = New System.Drawing.Size(264, 100)
        Me.ddLy_Do.TabIndex = 28
        Me.ddLy_Do.ValueMember = "Ma_Ly_Do"
        Me.ddLy_Do.Visible = False
        '
        'ddMa_Tinh
        '
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Tinh.DisplayLayout.Appearance = Appearance6
        Appearance7.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn5.Header.Appearance = Appearance7
        UltraGridColumn5.Header.Caption = "Mã tỉnh"
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Width = 80
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn6.Header.Appearance = Appearance8
        UltraGridColumn6.Header.Caption = "Tên tỉnh"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 120
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.ddMa_Tinh.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance9.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.ForeColor = System.Drawing.Color.Black
        Appearance9.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Tinh.DisplayLayout.Override.HeaderAppearance = Appearance9
        Me.ddMa_Tinh.DisplayMember = ""
        Me.ddMa_Tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Tinh.Location = New System.Drawing.Point(88, 312)
        Me.ddMa_Tinh.Name = "ddMa_Tinh"
        Me.ddMa_Tinh.Size = New System.Drawing.Size(204, 100)
        Me.ddMa_Tinh.TabIndex = 26
        Me.ddMa_Tinh.ValueMember = ""
        Me.ddMa_Tinh.Visible = False
        '
        'dgChi_Tiet_Phat
        '
        Me.dgChi_Tiet_Phat.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgChi_Tiet_Phat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChi_Tiet_Phat.DisplayLayout.Appearance = Appearance10
        Appearance11.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn9.Header.Appearance = Appearance11
        UltraGridColumn9.Header.Caption = "Mã E1"
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        Appearance12.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn10.Header.Appearance = Appearance12
        UltraGridColumn10.Header.Caption = "Bưu cục phát"
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        Appearance13.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn11.Header.Appearance = Appearance13
        UltraGridColumn11.Header.Caption = "Ngày - giờ"
        UltraGridColumn11.Header.VisiblePosition = 2
        Appearance14.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn12.Header.Appearance = Appearance14
        UltraGridColumn12.Header.Caption = "Người nhận"
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(132, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.CellAppearance = Appearance15
        Appearance16.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn13.Header.Appearance = Appearance16
        UltraGridColumn13.Header.Caption = "Trạng thái"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance17.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn14.Header.Appearance = Appearance17
        UltraGridColumn14.Header.Caption = "Lý do chưa phát"
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(203, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        Appearance18.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn15.Header.Appearance = Appearance18
        UltraGridColumn15.Header.Caption = "Xử lý tiếp theo"
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(208, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand3.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand3.UseRowLayout = True
        Me.dgChi_Tiet_Phat.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.dgChi_Tiet_Phat.DisplayLayout.InterBandSpacing = 10
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Appearance20.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance21.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.RowAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.RowSelectorAppearance = Appearance22
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance23.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.dgChi_Tiet_Phat.DisplayLayout.Override.SelectedRowAppearance = Appearance23
        Me.dgChi_Tiet_Phat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet_Phat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChi_Tiet_Phat.Location = New System.Drawing.Point(136, 488)
        Me.dgChi_Tiet_Phat.Name = "dgChi_Tiet_Phat"
        Me.dgChi_Tiet_Phat.Size = New System.Drawing.Size(600, 88)
        Me.dgChi_Tiet_Phat.TabIndex = 7
        Me.dgChi_Tiet_Phat.Text = "Chi tiết phát"
        '
        'dgChi_Tiet_Di_Den
        '
        Me.dgChi_Tiet_Di_Den.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgChi_Tiet_Di_Den.DisplayLayout.AddNewBox.Prompt = " "
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Appearance = Appearance24
        Appearance25.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn16.Header.Appearance = Appearance25
        UltraGridColumn16.Header.Caption = "Mã E1"
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Hidden = True
        Appearance26.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn17.Header.Appearance = Appearance26
        UltraGridColumn17.Header.Caption = "Bưu cục khai thác"
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(101, 0)
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.CellAppearance = Appearance27
        Appearance28.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn18.Header.Appearance = Appearance28
        UltraGridColumn18.Header.Caption = "Hướng"
        UltraGridColumn18.Header.VisiblePosition = 2
        Appearance29.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn19.Header.Appearance = Appearance29
        UltraGridColumn19.Header.Caption = "Ngày giờ"
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(115, 0)
        Appearance30.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.Header.Appearance = Appearance30
        UltraGridColumn20.Header.Caption = "Chi tiết"
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(284, 0)
        UltraGridColumn21.Header.Caption = "Nơi trả"
        UltraGridColumn21.Header.VisiblePosition = 5
        Appearance31.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn22.Header.Appearance = Appearance31
        UltraGridColumn22.Header.Caption = "Địa chỉ"
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(228, 0)
        Appearance32.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn23.Header.Appearance = Appearance32
        UltraGridColumn23.Header.Caption = "Ghi chú"
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(196, 0)
        Appearance33.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn24.Header.Appearance = Appearance33
        UltraGridColumn24.Header.Caption = "Ngày - Ca khai thác"
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(106, 0)
        UltraGridColumn25.Header.VisiblePosition = 9
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "NV Khai Thác"
        UltraGridColumn26.Header.VisiblePosition = 10
        UltraGridColumn27.Header.Caption = "Phân Loại BP"
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn28.Header.Caption = "Số biên lai"
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn29.Header.Caption = "Số TKHQ"
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn30.Header.Caption = "Lệ phí HQ"
        UltraGridColumn30.Header.VisiblePosition = 14
        UltraGridColumn31.Header.Caption = "Thuế NK"
        UltraGridColumn31.Header.VisiblePosition = 15
        UltraGridColumn32.Header.Caption = "Thuế VAT"
        UltraGridColumn32.Header.VisiblePosition = 16
        UltraGridColumn33.Header.Caption = "Thuế NK + VAT"
        UltraGridColumn33.Header.VisiblePosition = 17
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Điện Thoại Nhận"
        UltraGridColumn34.Header.VisiblePosition = 18
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34})
        UltraGridBand4.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand4.UseRowLayout = True
        Me.dgChi_Tiet_Di_Den.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.dgChi_Tiet_Di_Den.DisplayLayout.InterBandSpacing = 10
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.CardAreaAppearance = Appearance34
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance35.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.ForeColor = System.Drawing.Color.Black
        Appearance35.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance35.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance36.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.RowAppearance = Appearance36
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance37.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.RowSelectorAppearance = Appearance37
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance38.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.dgChi_Tiet_Di_Den.DisplayLayout.Override.SelectedRowAppearance = Appearance38
        Me.dgChi_Tiet_Di_Den.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgChi_Tiet_Di_Den.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgChi_Tiet_Di_Den.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChi_Tiet_Di_Den.Location = New System.Drawing.Point(136, 128)
        Me.dgChi_Tiet_Di_Den.Name = "dgChi_Tiet_Di_Den"
        Me.dgChi_Tiet_Di_Den.Size = New System.Drawing.Size(600, 192)
        Me.dgChi_Tiet_Di_Den.TabIndex = 6
        Me.dgChi_Tiet_Di_Den.Text = "Chi tiết hướng Bưu phẩm xác nhận đến và đóng đi"
        '
        'dgMa_E1
        '
        Me.dgMa_E1.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgMa_E1.DisplayLayout.AddNewBox.Prompt = " "
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgMa_E1.DisplayLayout.Appearance = Appearance39
        Appearance40.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn35.Header.Appearance = Appearance40
        UltraGridColumn35.Header.Caption = "Mã E1"
        UltraGridColumn35.Header.VisiblePosition = 0
        UltraGridColumn35.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(131, 0)
        UltraGridColumn35.Width = 150
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn35})
        UltraGridBand5.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand5.UseRowLayout = True
        Me.dgMa_E1.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.dgMa_E1.DisplayLayout.InterBandSpacing = 10
        Me.dgMa_E1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.dgMa_E1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None
        Me.dgMa_E1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.dgMa_E1.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Me.dgMa_E1.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance42.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance42.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.ForeColor = System.Drawing.Color.Black
        Appearance42.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance42.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgMa_E1.DisplayLayout.Override.HeaderAppearance = Appearance42
        Me.dgMa_E1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance43.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_E1.DisplayLayout.Override.RowAppearance = Appearance43
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance44.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgMa_E1.DisplayLayout.Override.RowSelectorAppearance = Appearance44
        Me.dgMa_E1.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgMa_E1.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance45.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance45.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.dgMa_E1.DisplayLayout.Override.SelectedRowAppearance = Appearance45
        Me.dgMa_E1.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgMa_E1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgMa_E1.Location = New System.Drawing.Point(0, 128)
        Me.dgMa_E1.Name = "dgMa_E1"
        Me.dgMa_E1.Size = New System.Drawing.Size(136, 448)
        Me.dgMa_E1.TabIndex = 5
        Me.dgMa_E1.Text = "Danh sách Số hiệu E1"
        '
        'Group_ThoiGian
        '
        Me.Group_ThoiGian.Controls.Add(Me.CbDen_Ngay)
        Me.Group_ThoiGian.Controls.Add(Me.LbTu_Ngay)
        Me.Group_ThoiGian.Controls.Add(Me.LbDen_Ngay)
        Me.Group_ThoiGian.Controls.Add(Me.CbTu_Ngay)
        Me.Group_ThoiGian.Location = New System.Drawing.Point(32, 0)
        Me.Group_ThoiGian.Name = "Group_ThoiGian"
        Me.Group_ThoiGian.Size = New System.Drawing.Size(288, 64)
        Me.Group_ThoiGian.SupportThemes = False
        Me.Group_ThoiGian.TabIndex = 2
        '
        'LbBuu_Cuc
        '
        Appearance46.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbBuu_Cuc.Appearance = Appearance46
        Me.LbBuu_Cuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBuu_Cuc.ImageTransparentColor = System.Drawing.Color.Empty
        Me.LbBuu_Cuc.Location = New System.Drawing.Point(72, 8)
        Me.LbBuu_Cuc.Name = "LbBuu_Cuc"
        Me.LbBuu_Cuc.Size = New System.Drawing.Size(56, 16)
        Me.LbBuu_Cuc.TabIndex = 4
        Me.LbBuu_Cuc.Text = "Bưu cục"
        '
        'LbNuoc
        '
        Appearance47.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbNuoc.Appearance = Appearance47
        Me.LbNuoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNuoc.ImageTransparentColor = System.Drawing.Color.Empty
        Me.LbNuoc.Location = New System.Drawing.Point(16, 8)
        Me.LbNuoc.Name = "LbNuoc"
        Me.LbNuoc.Size = New System.Drawing.Size(40, 16)
        Me.LbNuoc.TabIndex = 2
        Me.LbNuoc.Text = "Nước"
        '
        'CbDau_Ma
        '
        Me.CbDau_Ma.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance48.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.CellAppearance = Appearance48
        Appearance49.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn36.Header.Appearance = Appearance49
        UltraGridColumn36.Header.Caption = "Đầu mã"
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Width = 60
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn36})
        Me.CbDau_Ma.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Appearance50.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance50.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance50.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbDau_Ma.DisplayLayout.Override.HeaderAppearance = Appearance50
        Me.CbDau_Ma.DisplayMember = ""
        Me.CbDau_Ma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDau_Ma.LimitToList = True
        Me.CbDau_Ma.Location = New System.Drawing.Point(144, 24)
        Me.CbDau_Ma.Name = "CbDau_Ma"
        Me.CbDau_Ma.Size = New System.Drawing.Size(48, 21)
        Me.CbDau_Ma.TabIndex = 7
        Me.CbDau_Ma.Text = "EA"
        Me.CbDau_Ma.ValueMember = ""
        '
        'CbBuu_Cuc
        '
        Me.CbBuu_Cuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance51.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn37.Header.Appearance = Appearance51
        UltraGridColumn37.Header.Caption = "Mã tỉnh"
        UltraGridColumn37.Header.VisiblePosition = 0
        Appearance52.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn38.Header.Appearance = Appearance52
        UltraGridColumn38.Header.Caption = "Tên tỉnh"
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Width = 150
        Appearance53.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn39.Header.Appearance = Appearance53
        UltraGridColumn39.Header.Caption = "Khu vực"
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Hidden = True
        Appearance54.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn40.Header.Appearance = Appearance54
        UltraGridColumn40.Header.Caption = "Thoả thuận"
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41})
        Me.CbBuu_Cuc.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Appearance55.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance55.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance55.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance55.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbBuu_Cuc.DisplayLayout.Override.HeaderAppearance = Appearance55
        Me.CbBuu_Cuc.DisplayMember = ""
        Me.CbBuu_Cuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBuu_Cuc.Location = New System.Drawing.Point(72, 24)
        Me.CbBuu_Cuc.Name = "CbBuu_Cuc"
        Me.CbBuu_Cuc.Size = New System.Drawing.Size(64, 21)
        Me.CbBuu_Cuc.TabIndex = 5
        Me.CbBuu_Cuc.ValueMember = ""
        '
        'CbNuoc
        '
        Me.CbNuoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn42.Case = Infragistics.Win.UltraWinGrid.Case.Upper
        Appearance56.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.CellAppearance = Appearance56
        Appearance57.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn42.Header.Appearance = Appearance57
        UltraGridColumn42.Header.Caption = "Mã nước"
        UltraGridColumn42.Header.VisiblePosition = 0
        UltraGridColumn42.Width = 80
        Appearance58.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn43.Header.Appearance = Appearance58
        UltraGridColumn43.Header.Caption = "Tên nước"
        UltraGridColumn43.Header.VisiblePosition = 1
        UltraGridColumn43.Width = 120
        Appearance59.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn44.Header.Appearance = Appearance59
        UltraGridColumn44.Header.Caption = "Mã khu vực"
        UltraGridColumn44.Header.VisiblePosition = 2
        UltraGridColumn44.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        Me.CbNuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance60.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance60.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance60.ForeColor = System.Drawing.Color.Black
        Appearance60.TextHAlign = Infragistics.Win.HAlign.Center
        Appearance60.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.CbNuoc.DisplayLayout.Override.HeaderAppearance = Appearance60
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(255, Byte))
        Me.CbNuoc.DisplayLayout.Override.SelectedCellAppearance = Appearance61
        Me.CbNuoc.DisplayMember = ""
        Me.CbNuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNuoc.LimitToList = True
        Me.CbNuoc.Location = New System.Drawing.Point(16, 24)
        Me.CbNuoc.Name = "CbNuoc"
        Me.CbNuoc.Size = New System.Drawing.Size(48, 21)
        Me.CbNuoc.TabIndex = 3
        Me.CbNuoc.Text = "VN"
        Me.CbNuoc.ValueMember = ""
        '
        'LbDau_Ma
        '
        Appearance62.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LbDau_Ma.Appearance = Appearance62
        Me.LbDau_Ma.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDau_Ma.Location = New System.Drawing.Point(144, 8)
        Me.LbDau_Ma.Name = "LbDau_Ma"
        Me.LbDau_Ma.Size = New System.Drawing.Size(48, 16)
        Me.LbDau_Ma.TabIndex = 6
        Me.LbDau_Ma.Text = "Đầu mã"
        '
        'Group_ThongTinTim
        '
        Me.Group_ThongTinTim.Controls.Add(Me.LbSo_Hieu_E1)
        Me.Group_ThongTinTim.Controls.Add(Me.TxSo_Hieu_E1)
        Me.Group_ThongTinTim.Controls.Add(Me.LbBuu_Cuc)
        Me.Group_ThongTinTim.Controls.Add(Me.LbNuoc)
        Me.Group_ThongTinTim.Controls.Add(Me.CbDau_Ma)
        Me.Group_ThongTinTim.Controls.Add(Me.CbBuu_Cuc)
        Me.Group_ThongTinTim.Controls.Add(Me.CbNuoc)
        Me.Group_ThongTinTim.Controls.Add(Me.LbDau_Ma)
        Me.Group_ThongTinTim.Location = New System.Drawing.Point(32, 64)
        Me.Group_ThongTinTim.Name = "Group_ThongTinTim"
        Me.Group_ThongTinTim.Size = New System.Drawing.Size(472, 56)
        Me.Group_ThongTinTim.SupportThemes = False
        Me.Group_ThongTinTim.TabIndex = 0
        '
        'BtnBao_Phat
        '
        Me.BtnBao_Phat.Location = New System.Drawing.Point(624, 72)
        Me.BtnBao_Phat.Name = "BtnBao_Phat"
        Me.BtnBao_Phat.Size = New System.Drawing.Size(64, 48)
        Me.BtnBao_Phat.TabIndex = 8
        Me.BtnBao_Phat.Text = "In báo phát"
        Me.BtnBao_Phat.Visible = False
        '
        'ddXu_Ly
        '
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddXu_Ly.DisplayLayout.Appearance = Appearance63
        Appearance64.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn45.Header.Appearance = Appearance64
        UltraGridColumn45.Header.Caption = "Mã XL"
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn45.Width = 40
        Appearance65.TextHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn46.Header.Appearance = Appearance65
        UltraGridColumn46.Header.Caption = "Tên xử lý"
        UltraGridColumn46.Header.VisiblePosition = 1
        UltraGridColumn46.Width = 200
        UltraGridColumn47.Header.VisiblePosition = 2
        UltraGridColumn47.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46, UltraGridColumn47})
        Me.ddXu_Ly.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Appearance66.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance66.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance66.ForeColor = System.Drawing.Color.Black
        Appearance66.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddXu_Ly.DisplayLayout.Override.HeaderAppearance = Appearance66
        Me.ddXu_Ly.DisplayMember = "Ten_Xu_Ly"
        Me.ddXu_Ly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddXu_Ly.Location = New System.Drawing.Point(112, 232)
        Me.ddXu_Ly.Name = "ddXu_Ly"
        Me.ddXu_Ly.Size = New System.Drawing.Size(262, 100)
        Me.ddXu_Ly.TabIndex = 44
        Me.ddXu_Ly.ValueMember = "Ma_Xu_Ly"
        Me.ddXu_Ly.Visible = False
        '
        'FrmTimKiemE1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(738, 575)
        Me.Controls.Add(Me.Group_ThongTinTim)
        Me.Controls.Add(Me.Group_ThoiGian)
        Me.Controls.Add(Me.Group_LuaChon)
        Me.Controls.Add(Me.BtnTim)
        Me.Controls.Add(Me.dgChi_Tiet_Phat)
        Me.Controls.Add(Me.LbThong_Tin)
        Me.Controls.Add(Me.dgMa_E1)
        Me.Controls.Add(Me.dgChi_Tiet_Di_Den)
        Me.Controls.Add(Me.ddLy_Do)
        Me.Controls.Add(Me.ddMa_Tinh)
        Me.Controls.Add(Me.ddXu_Ly)
        Me.Controls.Add(Me.BtnBao_Phat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTimKiemE1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tra cứu bưu phẩm"
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxSo_Hieu_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_LuaChon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_LuaChon.ResumeLayout(False)
        CType(Me.ddLy_Do, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Tinh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChi_Tiet_Phat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgChi_Tiet_Di_Den, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMa_E1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_ThoiGian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_ThoiGian.ResumeLayout(False)
        CType(Me.CbDau_Ma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbBuu_Cuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbNuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_ThongTinTim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_ThongTinTim.ResumeLayout(False)
        CType(Me.ddXu_Ly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Khai báo các biến trong form"
    Dim myColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn = Nothing
    Private myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myNuoc As New Ma_Nuoc(GConnectionString)
    Dim myMa_Tinh As New Ma_Tinh(GConnectionString)
    Dim myMa_Bc_Khai_Thac As New Ma_Bc_Khai_Thac(GConnectionString)
    Dim myLy_Do As New Ly_Do(GConnectionString)
    Dim myXu_Ly As New Xu_Ly(GConnectionString)
    Dim myDanh_Muc_BC As New Danh_Muc_BC(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myBao_Phat As New Bao_Phat(GConnectionString)
    Dim So_Hieu_E1_Thieu As String

#End Region

#Region "Load Data"
#Region "Hien_Thi_Ma_Cac_Nuoc"
    Private Sub Hien_Thi_Ma_Cac_Nuoc()
        Try
            CbNuoc.DataSource = myNuoc.Danh_Sach.Tables(0)
            CbNuoc.DataBind()
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Hien_Thi_Ma_Cac_Buu_Cuc"
    Private Sub Hien_Thi_Ma_Cac_Buu_Cuc()
        Try
            CbBuu_Cuc.DataSource = myMa_Tinh.Danh_Sach.Tables(0)
            CbBuu_Cuc.DataBind()
            If CbBuu_Cuc.Rows.Count > 0 Then
                CbBuu_Cuc.Value = CbBuu_Cuc.Rows(0).Cells("Ma_Tinh").Value
            End If
        Catch ex As Exception
            CMessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tao_Bang_Dau_Ma"
    Private Sub Tao_Bang_Dau_Ma()
        Try
            'Them moi mot bang
            Dim dataTable As New dataTable("Dau_Ma")

            'Tao ra cac cot cua bang nay
            Dim colWork As DataColumn = New DataColumn("Dau_Ma", GetType(String))
            dataTable.Columns.Add(colWork)

            'Them du lieu vao
            Dim row As DataRow = dataTable.NewRow()
            row("Dau_Ma") = "EA"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EB"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EC"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "ED"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EE"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EF"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EG"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EH"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EI"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EJ"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EK"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EL"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EM"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EN"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EO"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EQ"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EP"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "ER"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "ES"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "ET"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EU"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EV"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EW"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EX"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EY"
            dataTable.Rows.Add(row)

            row = dataTable.NewRow
            row("Dau_Ma") = "EZ"
            dataTable.Rows.Add(row)

            CbDau_Ma.DataSource = dataTable
            CbDau_Ma.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "DataDropMa_Tinh"
    Private Sub DataDropMa_Tinh()
        Try
            ddMa_Tinh.DataSource = myMa_Tinh.Danh_Sach.Tables(0)
            ddMa_Tinh.DataBind()
            ddMa_Tinh.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "DataDropLy_Do"
    Private Sub DataDropLy_Do()
        Try
            ddLy_Do.DataSource = myLy_Do.Danh_Sach.Tables(0)
            ddLy_Do.DataBind()
            ddLy_Do.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "DataDropXu_Ly"
    Private Sub DataDropXu_Ly()
        Try
            ddXu_Ly.DataSource = myXu_Ly.Danh_Sach.Tables(0)
            ddXu_Ly.DataBind()
            ddXu_Ly.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#End Region

#Region "Function"
#Region "Enable_Control"
    Private Sub Enable_Control()
        'Không hiển thị nút in báo phát
        BtnBao_Phat.Visible = False
    End Sub
#End Region
#End Region

#Region "FrmTimKiemE1_Load - Load dữ liệu Form"
    Private Sub FrmTimKiemE1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If GUserAdmin = True Then
                optTimTheoDiaChi.Enabled = True
            Else
                optTimTheoDiaChi.Enabled = False
            End If
            'Lấy dữ liệu vào các commbo 
            Hien_Thi_Ma_Cac_Nuoc()
            Hien_Thi_Ma_Cac_Buu_Cuc()
            Tao_Bang_Dau_Ma()
            DataDropMa_Tinh()
            DataDropLy_Do()
            DataDropXu_Ly()

            'Xử lý các control Group Box
            'Group_ThoiGian
            CbTu_Ngay.Value = myHam_Dung_Chung.ConvertIntToDate(myHam_Dung_Chung.MinusIntDate(myHam_Dung_Chung.ConvertDateToInt(Now.Date), 60))
            CbDen_Ngay.Value = myHam_Dung_Chung.ConvertIntToDate(myHam_Dung_Chung.ConvertDateToInt(Now.Date))
            'Group_LuaChon
            Opt_ChinhXacE1.Checked = True
            Group_LuaChon_Value_Changed()
            'Group_HienThi

            CbNuoc.Enabled = False
            Enable_Control()
            BtnBao_Phat.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "FrmTimKiemE1_KeyPress - Sự kiện KeyPress của Form"
    Private Sub FrmTimKiemE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnTim_Click - Sự kiện Click vào Tìm kiếm của BtnTim trong Form"
    Private Sub BtnTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTim.Click, BtnTim.Enter
        Try
            If TxSo_Hieu_E1.Text.Trim.Length = 0 Then 'Không làm gì nếu chưa nhập số hiệu E1
                Exit Sub
            End If
            'Kiểm tra điều kiện lựa chọn
            If optTimTheoDiaChi.Checked = True Then 'Tìm kiếm theo địa chỉ
                TimKiemTheoDiaChi("%" & TxSo_Hieu_E1.Text.Trim.ToUpper & "%")
            ElseIf Opt_ChinhXacE1.Checked = True Then 'Tìm kiếm chính xác Ma_E1
                If TxSo_Hieu_E1.Text.Trim.Length = 13 Then
                    If myHam_Dung_Chung.Check_E1(TxSo_Hieu_E1.Text.Trim) = False Then
                        CMessageBox.Show("Số hiệu này không có thực, xin mời nhập mã khác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'dgMa_E1.Height = 464
                        BtnBao_Phat.Visible = False
                        LbThong_Tin.Text = "     + Số hiệu này không có thực, xin mời nhập mã khác !!!"
                        TxSo_Hieu_E1.Select()
                        Exit Sub
                    End If
                    TimKiemChinhXacE1(TxSo_Hieu_E1.Text.Trim) 'Tìm kiếm chính xác Ma_E1
                End If
            ElseIf OptTat_Ca_Dau_Ma.Checked = True Then 'Tìm kiếm theo tất cả đầu mã
                If TxSo_Hieu_E1.Text.Trim.Length = 13 Then
                    If myHam_Dung_Chung.Check_E1(TxSo_Hieu_E1.Text.Trim) = False Then
                        CMessageBox.Show("Số hiệu này không có thực, xin mời nhập mã khác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'dgMa_E1.Height = 464
                        BtnBao_Phat.Visible = False
                        LbThong_Tin.Text = "     + Số hiệu này không có thực, xin mời nhập mã khác !!!"
                        TxSo_Hieu_E1.Select()
                        Exit Sub
                    End If
                    So_Hieu_E1_Thieu = "%" & Mid(TxSo_Hieu_E1.Text.Trim, 3, 12) ' Tìm tất cả các đầu mã
                    TimKiemE1Thieu(So_Hieu_E1_Thieu)
                End If
            ElseIf OptTim_Gan_Dung.Checked = True Then 'Tìm kiếm E1 gần đúng
                If TxSo_Hieu_E1.Text.Trim.Length < 6 Then
                    CMessageBox.Show("Nếu tìm E1 gần đúng, bạn phải nhập tối thiểu 6 ký tự !!!", "Thông báo")
                    LbThong_Tin.Text = "     + Nếu tìm E1 gần đúng, bạn phải nhập tối thiểu 6 ký tự !!!"
                    TxSo_Hieu_E1.Undo()
                    'dgMa_E1.Height = 464
                    BtnBao_Phat.Visible = False
                    TxSo_Hieu_E1.Select()
                    Exit Sub
                End If
                If TxSo_Hieu_E1.Text.Trim.Length = 13 Then 'Mã E1 đầy đủ
                    TimKiemChinhXacE1(TxSo_Hieu_E1.Text.Trim)
                Else
                    So_Hieu_E1_Thieu = "%" & TxSo_Hieu_E1.Text.Trim & "%" ' Tìm kiếm E1 gần đúng
                    TimKiemE1Thieu(So_Hieu_E1_Thieu)
                End If
            End If

            If dgMa_E1.Rows.Count = 0 Then
                CMessageBox.Show("Không tìm thấy Mã Bưu phẩm này trong dữ liệu !!!", "Thông báo")
                LbThong_Tin.Text = "     + Không tìm thấy Mã Bưu phẩm này trong dữ liệu !!!"
                TxSo_Hieu_E1.Undo()
                'dgMa_E1.Height = 464
                BtnBao_Phat.Visible = False
                TxSo_Hieu_E1.Select()
                Exit Sub
            End If
            So_Hieu_E1_Thieu = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            Me.TxSo_Hieu_E1.Focus()
            Me.TxSo_Hieu_E1.SelectionStart = 0
            Me.TxSo_Hieu_E1.SelectionLength = Len(TxSo_Hieu_E1.Text)
        End Try
    End Sub
#End Region

#Region "Tìm kiếm chính xác Mã E1"
    Private Sub TimKiemChinhXacE1(ByVal Ma_E1 As String)
        Try
            'Hiển thị danh sách mã e1 bên trái
            dgMa_E1.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Trai(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                        myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                        Ma_E1, _
                                                                        0)
            dgMa_E1.DataBind()
            dgMa_E1.Refresh()
            If dgMa_E1.Rows.Count > 0 Then
                'Hiển thị chi tiết phát ở dưới
                dgChi_Tiet_Phat.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Duoi(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, 0)
                dgChi_Tiet_Phat.DataBind()
                dgChi_Tiet_Phat.Refresh()

                dgChi_Tiet_Di_Den.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Tren(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, 0)
                dgChi_Tiet_Di_Den.DataBind()
                dgChi_Tiet_Di_Den.Refresh()

                BtnBao_Phat.Visible = False
                'dgMa_E1.Height = 400
            End If
            'Hiển thị chi tiết hướng đi đến ở trên
            Me.Text = Nothing
            Me.Text = "Tra cứu bưu phẩm chính xác với: " & Ma_E1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tìm kiếm Mã E1 thiếu"
    Private Sub TimKiemE1Thieu(ByVal Ma_E1_Thieu As String)
        Try
            'Hiển thị danh sách mã e1 bên trái
            dgMa_E1.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Trai(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                        myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                        Ma_E1_Thieu, _
                                                                        0)
            dgMa_E1.DataBind()
            dgMa_E1.Refresh()
            If dgMa_E1.Rows.Count > 0 Then
                'Hiển thị chi tiết phát ở dưới
                dgChi_Tiet_Phat.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Duoi(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                                    myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                                    dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                                                    0)
                dgChi_Tiet_Phat.DataBind()
                dgChi_Tiet_Phat.Refresh()

                dgChi_Tiet_Di_Den.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Tren(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                                    myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                                    dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                                                    0)
                dgChi_Tiet_Di_Den.DataBind()
                dgChi_Tiet_Di_Den.Refresh()

                BtnBao_Phat.Visible = False
                'dgMa_E1.Height = 400
            End If
            'Hiển thị chi tiết hướng đi đến ở trên
            Me.Text = Nothing
            If OptTat_Ca_Dau_Ma.Checked = True Then
                Me.Text = "Tra cứu bưu phẩm theo tất cả đầu mã với " & Ma_E1_Thieu
            ElseIf OptTim_Gan_Dung.Checked = True Then
                Me.Text = "Tra cứu bưu phẩm gần đúng với " & Ma_E1_Thieu
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Tìm kiếm theo địa chỉ"
    Private Sub TimKiemTheoDiaChi(ByVal Dia_Chi As String)
        Try
            'Hiển thị danh sách mã e1 bên trái
            dgMa_E1.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Trai_Theo_Dia_Chi(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                        myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                        Dia_Chi)
            dgMa_E1.DataBind()
            dgMa_E1.Refresh()
            If dgMa_E1.Rows.Count > 0 Then
                'Hiển thị chi tiết phát ở dưới
                dgChi_Tiet_Phat.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Duoi(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                                    myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                                    dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                                                    0)
                dgChi_Tiet_Phat.DataBind()
                dgChi_Tiet_Phat.Refresh()

                dgChi_Tiet_Di_Den.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Tren(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), _
                                                                                    myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), _
                                                                                    dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, _
                                                                                    0)
                dgChi_Tiet_Di_Den.DataBind()
                dgChi_Tiet_Di_Den.Refresh()

                BtnBao_Phat.Visible = False
                'dgMa_E1.Height = 400
            End If
            'Hiển thị chi tiết hướng đi đến ở trên
            Me.Text = Nothing
            Me.Text = "Tra cứu bưu phẩm theo địa chỉ với: " & Dia_Chi
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgChi_Tiet_Phat_InitializeLayout"
    Private Sub dgChi_Tiet_Phat_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgChi_Tiet_Phat.InitializeLayout
        Try
            dgChi_Tiet_Phat.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
            dgChi_Tiet_Phat.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
            With dgChi_Tiet_Phat.DisplayLayout
                .Bands(0).Columns("Ma_BC_Phat").Style = ColumnStyle.DropDownList
                .Bands(0).Columns("Ma_BC_Phat").ValueList = ddMa_Tinh

                .Bands(0).Columns("Ma_Ly_Do").Style = ColumnStyle.DropDownList
                .Bands(0).Columns("Ma_Ly_Do").ValueList = ddLy_Do

                .Bands(0).Columns("Ma_Xu_Ly").Style = ColumnStyle.DropDownList
                .Bands(0).Columns("Ma_Xu_Ly").ValueList = ddXu_Ly
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgMa_E1_AfterCellActivate - Sự kiện AfterCellActivate"
    Private Sub dgMa_E1_AfterCellActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgMa_E1.AfterCellActivate
        Try
            If dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Text.Trim.Length = 13 Then
                dgChi_Tiet_Phat.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Duoi(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, 0)
                dgChi_Tiet_Phat.DataBind()
                dgChi_Tiet_Phat.Refresh()

                dgChi_Tiet_Di_Den.DataSource = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Tren(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Value, 0)
                dgChi_Tiet_Di_Den.DataBind()
                dgChi_Tiet_Di_Den.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "BtnBao_Phat_Click - Sự kiện click của Form"
    Private Sub BtnBao_Phat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBao_Phat.Click
        Dim _pThamSo As New ParameterDiscreteValue
        Dim mydata As DataTable
        Dim rptbaophatchitietphat As New RptBao_Phat_Chi_Tiet_Phat
        Dim pvCollection As New ParameterValues
        Dim FrmView As New FrmViewReports
        Try
            If OptTat_Ca_Dau_Ma.Checked = True Then
                mydata = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Report(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), TxSo_Hieu_E1.Value, 0)
            Else
                mydata = myBao_Phat.Bao_Phat_Tim_Kiem_E1_Report(myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), dgMa_E1.Rows(dgMa_E1.ActiveRow.Index).Cells("Ma_E1").Text, 0)
            End If
            _pThamSo.Value = GTen_Dang_Nhap
            pvCollection.Add(_pThamSo)
            rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Ten_Dang_Nhap").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            _pThamSo.Value = GrptNgay_Thang_Nam
            pvCollection.Add(_pThamSo)
            rptbaophatchitietphat.DataDefinition.ParameterFields("Menu_Ngay_Thang_Nam").ApplyCurrentValues(pvCollection)
            pvCollection.Clear()
            If mydata.Rows.Count > 0 Then
                rptbaophatchitietphat.SetDataSource(mydata)
                FrmView.CrystalReportViewer1.ReportSource = rptbaophatchitietphat
                Cursor.Current = Cursors.Default
                FrmView.ShowDialog()
            Else
                CMessageBox.Show("Không có thông tin dữ liệu về mã bưu phẩm này !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgChi_Tiet_Di_Den_InitializeLayout"
    Private Sub dgChi_Tiet_Di_Den_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgChi_Tiet_Di_Den.InitializeLayout
        Try
            dgChi_Tiet_Di_Den.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.LightCyan
            dgChi_Tiet_Di_Den.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.AliceBlue
            With dgChi_Tiet_Di_Den.DisplayLayout
                '.Bands(0).Columns("Ma_BC_Khai_Thac").Style = ColumnStyle.DropDownList
                '.Bands(0).Columns("Ma_BC_Khai_Thac").ValueList = ddMa_Tinh

                '.Bands(0).Columns("Ma_BC_Tra").Style = ColumnStyle.DropDownList
                '.Bands(0).Columns("Ma_BC_Tra").ValueList = ddMa_Tinh
                'Sắp xếp theo ngày giờ
                '.Bands(0).Columns("Ma_Bc_Khai_Thac").SortIndicator = SortIndicator.None

                '.Bands(0).Columns("Ngay_Gio").SortIndicator = SortIndicator.Ascending
                '.Bands(0).Columns("NgayCaKt").SortIndicator = SortIndicator.Ascending
                '.Bands(0).Columns("Huong").SortIndicator = SortIndicator.Ascending
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "dgChi_Tiet_Di_Den_AfterRowActivate"
    Private Sub dgChi_Tiet_Di_Den_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgChi_Tiet_Di_Den.AfterRowActivate
        Try
            Dim Noi_Tra As String
            If IsNumeric(dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Tra").Text) = True Then
                Noi_Tra = " + Mã bưu cục trả : " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Tra").Text & " - " & myDanh_Muc_BC.Lay(dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Tra").Text).Ten_Buu_Cuc
            Else
                Noi_Tra = " + Nước trả : " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Tra").Text & " - " & myNuoc.Lay(dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Tra").Text).Ten_Nuoc
            End If
            LbThong_Tin.Text = "                                           THÔNG TIN CHI TIẾT ĐỊNH VỊ BƯU PHẨM" & vbNewLine _
            & " + Ngày E2: " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ngay_Gio").Value & " phút" & vbNewLine _
            & " + Bưu cục khai thác : " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Khai_Thac").Value & " - " & myDanh_Muc_BC.Lay(dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ma_BC_Khai_Thac").Value).Ten_Buu_Cuc & vbNewLine _
            & " + Chi tiết đường thư : " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Chi_tiet").Value & vbNewLine _
            & " + Hướng : " & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Huong").Value & vbNewLine _
            & Noi_Tra & vbNewLine _
            & " + Người nhận:" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Nguoi_Nhan").Value & IIf(dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Text.Length = 0, "", "- Điện Thoại Nhận:" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Dien_Thoai_Nhan").Value) & vbNewLine _
            & " + Địa chỉ người nhận :" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Dia_Chi").Value & vbNewLine _
            & " + Ghi chú :" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Ghi_Chu").Value & vbNewLine _
            & " + Ngày - ca kế toán :" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("ngaycakt").Value & vbNewLine _
            & " + Nhân viên Khai Thác :" & dgChi_Tiet_Di_Den.Rows(dgChi_Tiet_Di_Den.ActiveRow.Index).Cells("Nguoi_Dung").Value
        Catch ex As Exception
            LbThong_Tin.Text = "Thông tin bị lỗi"
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "TxSo_Hieu_E1_KeyDown"
    Private Sub TxSo_Hieu_E1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxSo_Hieu_E1.KeyDown
        Select Case e.KeyValue
            Case 13
                BtnTim.Focus()
            Case Else
        End Select
    End Sub
#End Region

#Region "TxSo_Hieu_E1_AfterExitEditMode"
    Private Sub TxSo_Hieu_E1_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxSo_Hieu_E1.AfterExitEditMode
        Try
            If TxSo_Hieu_E1.Text.Length = 0 Then 'Không làm gì nếu TxtSo_Hieu_E1 = ""
                Exit Sub
            End If
            'Kiểm tra xem có phải là tìm kiếm theo địa chỉ không
            TxSo_Hieu_E1.Text = TxSo_Hieu_E1.Text.ToUpper
            If optTimTheoDiaChi.Checked = True Then 'Tìm kiếm theo địa chỉ

            ElseIf Opt_ChinhXacE1.Checked = True Then 'Tìm kiếm chính xác Ma_E1
                If TxSo_Hieu_E1.Text.Length <> 13 Then
                    TxSo_Hieu_E1.Value = GetCorrectMAE1(TxSo_Hieu_E1.Text, IIf(CbNuoc.Value Is Nothing, "VN", CbNuoc.Value), CbBuu_Cuc.Text, "EE000000000VN")
                End If
                CbDau_Ma_Validated(sender, e)
                CbDau_Ma.Text = Mid(TxSo_Hieu_E1.Text, 1, 2)
                CbNuoc.Value = TimNuocNhanTuE1(TxSo_Hieu_E1.Text)
            ElseIf OptTat_Ca_Dau_Ma.Checked = True Then 'Tìm kiếm theo tất cả đầu mã
                If TxSo_Hieu_E1.Text.Length <> 13 Then
                    TxSo_Hieu_E1.Value = GetCorrectMAE1(TxSo_Hieu_E1.Text, IIf(CbNuoc.Value Is Nothing, "VN", CbNuoc.Value), CbBuu_Cuc.Text, "EE000000000VN")
                End If
                CbDau_Ma_Validated(sender, e)
                CbDau_Ma.Text = Mid(TxSo_Hieu_E1.Text, 1, 2)
                CbNuoc.Value = TimNuocNhanTuE1(TxSo_Hieu_E1.Text)
            ElseIf OptTim_Gan_Dung.Checked = True Then 'Tìm kiếm E1 gần đúng
                'Kiểm tra điều kiện

            End If


            'If OptTat_Ca_Dau_Ma.Checked = True Then
            '    TxSo_Hieu_E1.Value = GetCorrectMAE1(TxSo_Hieu_E1.Text, IIf(CbNuoc.Value Is Nothing, "VN", CbNuoc.Value), CbBuu_Cuc.Text, "EE000000000VN")
            '    CbDau_Ma_Validated(sender, e)
            '    CbDau_Ma.Text = Mid(TxSo_Hieu_E1.Text, 1, 2)
            '    CbNuoc.Value = TimNuocNhanTuE1(TxSo_Hieu_E1.Text)
            'End If
            'BtnTim_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbTu_Ngay_AfterExitEditMode"
    Private Sub CbTu_Ngay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTu_Ngay.AfterExitEditMode
        Try
            If CbTu_Ngay.Value > CbDen_Ngay.Value Then
                CMessageBox.Show("Giá trị Từ ngày phải luôn nhỏ hơn giá trị Đến ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbTu_Ngay.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbDen_Ngay_AfterExitEditMode"
    Private Sub CbDen_Ngay_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbDen_Ngay.AfterExitEditMode
        Try
            If CbTu_Ngay.Value > CbDen_Ngay.Value Then
                CMessageBox.Show("Giá trị Đến ngày phải luôn lớn hơn giá trị từ ngày !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CbDen_Ngay.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbBuu_Cuc_Validated"
    Private Sub CbBuu_Cuc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            CbBuu_Cuc.Text = FormatMaBc(CbBuu_Cuc.Text)
            If CbBuu_Cuc.Text = "000000" Then
                CbNuoc.Enabled = True
                CbBuu_Cuc.Enabled = False
                CbNuoc.Select()
            ElseIf TxSo_Hieu_E1.Text.Trim.Length = 13 Then
                CbNuoc.Enabled = False
                TxSo_Hieu_E1.Text = CbDau_Ma.Text & Mid(CbBuu_Cuc.Text, 1, 2) & Mid(TxSo_Hieu_E1.Text, 5, 7) & "VN"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbNuoc_Validated"
    Private Sub CbNuoc_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If TxSo_Hieu_E1.Text.Trim.Length = 13 Then
                TxSo_Hieu_E1.Text = Mid(TxSo_Hieu_E1.Text, 1, 11) & CbNuoc.Text
            End If
            If CbNuoc.Value = "VN" Then
                CbBuu_Cuc.Enabled = True
                CbBuu_Cuc.Focus()
            Else
                CbBuu_Cuc.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "CbDau_Ma_Validated"
    Private Sub CbDau_Ma_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If TxSo_Hieu_E1.Text.Length = 13 Then
                If Mid(TxSo_Hieu_E1.Text, 1, 1) = "E" Then
                    TxSo_Hieu_E1.Text = CbDau_Ma.Text & Mid(TxSo_Hieu_E1.Text, 3, 12)
                End If
                'TxSo_Hieu_E1.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Group_Luachon"
#Region "Group_LuaChon_Value_Changed"
    Private Sub Group_LuaChon_Value_Changed()
        If optTimTheoDiaChi.Checked = True Then 'Tìm theo địa chỉ
            CbBuu_Cuc.Enabled = False
            CbNuoc.Enabled = False
            CbDau_Ma.Enabled = False
        Else 'Tìm theo mã E1
            CbBuu_Cuc.Enabled = True
            CbNuoc.Enabled = True
            CbDau_Ma.Enabled = True
        End If
    End Sub
#End Region

#Region "optTimTheoDiaChi_CheckedChanged"
    Private Sub optTimTheoDiaChi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optTimTheoDiaChi.CheckedChanged
        Group_LuaChon_Value_Changed()
    End Sub
#End Region
#End Region

#Region "dgMa_E1_InitializeLayout"
    Private Sub dgMa_E1_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgMa_E1.InitializeLayout
        myGridKeyDown = sender
        myGridKeyDown.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        myGridKeyDown.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue
    End Sub
#End Region

#Region "TxSo_Hieu_E1_BeforeExitEditMode"
    Private Sub TxSo_Hieu_E1_BeforeExitEditMode(ByVal sender As Object, ByVal e As Infragistics.Win.BeforeExitEditModeEventArgs) Handles TxSo_Hieu_E1.BeforeExitEditMode
        If (Opt_ChinhXacE1.Checked = True) Or (OptTat_Ca_Dau_Ma.Checked = True) Then
            If TxSo_Hieu_E1.Text.Length = 13 Then
                If Mid(TxSo_Hieu_E1.Text, 1, 1) = "E" Then
                    CbDau_Ma.Value = TxSo_Hieu_E1.Text.Substring(0, 2).ToUpper
                    CbDau_Ma.Text = TxSo_Hieu_E1.Text.Substring(0, 2).ToUpper
                End If
            End If
        End If
    End Sub
#End Region
    
End Class

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

Public Class Frm_Sua_Chua_To_Khai
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
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CbDen_Ngay As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTimToKhai As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dgToKhaiHaiQuanXuat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtMaE1 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSo_To_Khai As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents cbLoai_To_Khai As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ddKieu_Kiem_Hoa As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents txtTong_So As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnXoaToKhai As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSuaToKhaiLoi As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSuaToKhai As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnThoat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Nhap_So As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ddMa_Nuoc As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents ddMaTienTe As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents lblThong_Tin As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Nhap_So_Thap_Phan As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Sua_Chua_To_Khai))
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("To_Khai_Hai_Quan_Xuat", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_To_Khai")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_TKHQ")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_Khai")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_Khai")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("So_To_Khai_HQ_Cap")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Luong")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Duoc_Uy_Quyen")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Can_Bo_Kiem_Tra")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Can_Bo_Tinh_Thue")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Can_Bo_Xac_Nhan")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Gui")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Gui")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Gui")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CMT_Gui")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CMT_Ngay_Gui")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Gui")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nguoi_Nhan")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Chi_Nhan")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dien_Thoai_Nhan")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CMT_Nhan")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CMT_Ngay_Nhan")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nuoc_Nhan")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPrint")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPhuLuc")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsOpen")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kieu_Kiem_Hoa")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Giay_To_Kem_Theo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Tui")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Khoi_Luong")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_So_Kien")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_CN38")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Thong_Tin_Tai_Lieu")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsQua_Tang")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsHang_Mau")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPay")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsPayTax")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Van_Chuyen")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ty_Gia")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuoc_Van_Chuyen_VN")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tri_So_Van_Chuyen")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Qua_Tang")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Le_Phi_HQ")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tri_Gia_Nguyen_Te")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Suat")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tong_Thue_Vat")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ty_Gia_USD")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Phan_Loai")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te_HQ")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id_Duong_Thu")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ip_May_Tinh")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ban_So")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Truyen_So_Lieu")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ngay_He_Thong")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gio_He_Thong")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Chot_SL")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kieu_Kiem_Hoa", -1)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Kieu_Kiem_Hoa", -1)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Loai")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Loai")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Ma_Nuoc", -1)
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ten_Nuoc")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Khu_Vuc")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Danh_Muc_Tien_Te", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Tien_Te")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tien_Te")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ma_Nuoc")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ghi_Chu")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnTimToKhai = New Infragistics.Win.Misc.UltraButton
        Me.dgToKhaiHaiQuanXuat = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.CbTu_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.CbDen_Ngay = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.lblThong_Tin = New Infragistics.Win.Misc.UltraLabel
        Me.txtTong_So = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtMaE1 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txtSo_To_Khai = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.cbLoai_To_Khai = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.ddKieu_Kiem_Hoa = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.btnXoaToKhai = New Infragistics.Win.Misc.UltraButton
        Me.btnSuaToKhaiLoi = New Infragistics.Win.Misc.UltraButton
        Me.btnSuaToKhai = New Infragistics.Win.Misc.UltraButton
        Me.btnThoat = New Infragistics.Win.Misc.UltraButton
        Me.ddMa_Nuoc = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.Nhap_So = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ddMaTienTe = New Infragistics.Win.UltraWinGrid.UltraDropDown
        Me.Nhap_So_Thap_Phan = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        CType(Me.dgToKhaiHaiQuanXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTong_So, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoai_To_Khai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddKieu_Kiem_Hoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nhap_So, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddMaTienTe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nhap_So_Thap_Phan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTimToKhai
        '
        Appearance1.Image = CType(resources.GetObject("Appearance1.Image"), Object)
        Me.btnTimToKhai.Appearance = Appearance1
        Me.btnTimToKhai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimToKhai.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnTimToKhai.Location = New System.Drawing.Point(672, 8)
        Me.btnTimToKhai.Name = "btnTimToKhai"
        Me.btnTimToKhai.Size = New System.Drawing.Size(112, 40)
        Me.btnTimToKhai.TabIndex = 10
        Me.btnTimToKhai.Text = "&Tìm kiếm"
        '
        'dgToKhaiHaiQuanXuat
        '
        Me.dgToKhaiHaiQuanXuat.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.AddNewBox.Prompt = " "
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.ForwardDiagonal
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Header.Caption = "Số tờ khai"
        UltraGridColumn2.Header.VisiblePosition = 6
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Ngày khai"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.MaskInput = "dd/mm/yyyy"
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Giờ khai"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaskInput = "hh:mm"
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Số TKHQ cấp"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(77, 0)
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(44, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Người khai"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(111, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Người gửi"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Địa chỉ gửi"
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.VisiblePosition = 17
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Nước gửi"
        UltraGridColumn16.Header.VisiblePosition = 20
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(55, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Người nhận"
        UltraGridColumn17.Header.VisiblePosition = 21
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Địa chỉ nhận"
        UltraGridColumn18.Header.VisiblePosition = 22
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.VisiblePosition = 23
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.VisiblePosition = 24
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 52
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.VisiblePosition = 25
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 54
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Nước nhận"
        UltraGridColumn22.Header.VisiblePosition = 27
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(66, 0)
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 34
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 64
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 36
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 66
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.VisiblePosition = 53
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 102
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Header.Caption = "Loại tờ khai"
        UltraGridColumn26.Header.VisiblePosition = 5
        UltraGridColumn26.Hidden = True
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(67, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Header.Caption = "Chuyến bay"
        UltraGridColumn27.Header.VisiblePosition = 37
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Header.Caption = "SL túi"
        UltraGridColumn28.Header.VisiblePosition = 26
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(43, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Header.Caption = "Khối lượng"
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(70, 0)
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Header.Caption = "Số kiện"
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(50, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Header.Caption = "Ngày CN38"
        UltraGridColumn31.Header.VisiblePosition = 31
        UltraGridColumn31.MaskInput = "dd/mm/yyyy"
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Header.Caption = "Ghi chú"
        UltraGridColumn32.Header.VisiblePosition = 46
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 42
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn33.Header.Caption = "Kèm tài liệu"
        UltraGridColumn33.Header.VisiblePosition = 35
        UltraGridColumn33.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn33.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn33.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn33.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn33.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn34.Header.Caption = "Quà biếu"
        UltraGridColumn34.Header.VisiblePosition = 18
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.RowLayoutColumnInfo.OriginX = 34
        UltraGridColumn34.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn34.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(53, 0)
        UltraGridColumn34.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn34.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn35.Header.VisiblePosition = 30
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.RowLayoutColumnInfo.OriginX = 58
        UltraGridColumn35.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn35.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn35.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn36.Header.VisiblePosition = 32
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.RowLayoutColumnInfo.OriginX = 60
        UltraGridColumn36.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn36.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn36.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn37.Header.VisiblePosition = 33
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.RowLayoutColumnInfo.OriginX = 62
        UltraGridColumn37.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn37.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn37.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn38.Header.VisiblePosition = 38
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.RowLayoutColumnInfo.OriginX = 72
        UltraGridColumn38.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn38.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn38.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn39.Header.VisiblePosition = 39
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.RowLayoutColumnInfo.OriginX = 74
        UltraGridColumn39.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn39.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn39.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn40.Header.VisiblePosition = 40
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.RowLayoutColumnInfo.OriginX = 76
        UltraGridColumn40.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn40.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn40.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn41.Format = "##,###,##0"
        UltraGridColumn41.Header.Caption = "Cước F (VNĐ)"
        UltraGridColumn41.Header.VisiblePosition = 41
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.RowLayoutColumnInfo.OriginX = 36
        UltraGridColumn41.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn41.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn41.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn41.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn42.Header.VisiblePosition = 42
        UltraGridColumn42.Hidden = True
        UltraGridColumn42.RowLayoutColumnInfo.OriginX = 80
        UltraGridColumn42.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn42.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn42.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn43.Header.VisiblePosition = 43
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.RowLayoutColumnInfo.OriginX = 82
        UltraGridColumn43.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn43.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn43.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn44.Format = "##,###,##0"
        UltraGridColumn44.Header.Caption = "Lệ phí HQ"
        UltraGridColumn44.Header.VisiblePosition = 44
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.RowLayoutColumnInfo.OriginX = 38
        UltraGridColumn44.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn44.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(63, 0)
        UltraGridColumn44.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn44.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn45.Format = "##,###,##0"
        UltraGridColumn45.Header.Caption = "Trị giá VNĐ"
        UltraGridColumn45.Header.VisiblePosition = 12
        UltraGridColumn45.Hidden = True
        UltraGridColumn45.RowLayoutColumnInfo.OriginX = 28
        UltraGridColumn45.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn45.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(83, 0)
        UltraGridColumn45.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn45.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn46.Format = "##,###,##0"
        UltraGridColumn46.Header.Caption = "Thuế NK"
        UltraGridColumn46.Header.VisiblePosition = 14
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.RowLayoutColumnInfo.OriginX = 30
        UltraGridColumn46.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn46.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn46.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn46.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn47.Format = "##,###,##0"
        UltraGridColumn47.Header.Caption = "Thuế VAT"
        UltraGridColumn47.Header.VisiblePosition = 16
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.RowLayoutColumnInfo.OriginX = 32
        UltraGridColumn47.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn47.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(78, 0)
        UltraGridColumn47.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn47.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn48.Header.VisiblePosition = 45
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.RowLayoutColumnInfo.OriginX = 86
        UltraGridColumn48.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn48.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn48.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn49.Header.VisiblePosition = 51
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.RowLayoutColumnInfo.OriginX = 98
        UltraGridColumn49.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn49.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn49.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn50.Header.Caption = "Mã tiền tệ"
        UltraGridColumn50.Header.VisiblePosition = 52
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn50.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn50.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn50.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn50.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn51.Header.VisiblePosition = 54
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.RowLayoutColumnInfo.OriginX = 104
        UltraGridColumn51.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn51.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn51.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn52.Header.VisiblePosition = 55
        UltraGridColumn52.Hidden = True
        UltraGridColumn52.RowLayoutColumnInfo.OriginX = 106
        UltraGridColumn52.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn52.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn52.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn53.Header.Caption = "Bàn số"
        UltraGridColumn53.Header.VisiblePosition = 56
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.RowLayoutColumnInfo.OriginX = 46
        UltraGridColumn53.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn53.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(49, 0)
        UltraGridColumn53.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn53.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn54.Header.VisiblePosition = 49
        UltraGridColumn54.Hidden = True
        UltraGridColumn54.RowLayoutColumnInfo.OriginX = 94
        UltraGridColumn54.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn54.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn54.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn55.Header.VisiblePosition = 47
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.RowLayoutColumnInfo.OriginX = 90
        UltraGridColumn55.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn55.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn55.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn56.Header.VisiblePosition = 48
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.RowLayoutColumnInfo.OriginX = 92
        UltraGridColumn56.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn56.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn56.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn57.Header.Caption = "Chốt SL"
        UltraGridColumn57.Header.VisiblePosition = 50
        UltraGridColumn57.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn57.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn57.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(48, 0)
        UltraGridColumn57.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn57.RowLayoutColumnInfo.SpanY = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57})
        UltraGridBand1.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False
        UltraGridBand1.UseRowLayout = True
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.InterBandSpacing = 10
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.CardAreaAppearance = Appearance3
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.DefaultRowHeight = 25
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextHAlign = Infragistics.Win.HAlign.Left
        Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.HeaderAppearance = Appearance4
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance5.BorderColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSelectorWidth = 12
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.RowSpacingBefore = 0
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Me.dgToKhaiHaiQuanXuat.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.dgToKhaiHaiQuanXuat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgToKhaiHaiQuanXuat.Location = New System.Drawing.Point(4, 56)
        Me.dgToKhaiHaiQuanXuat.Name = "dgToKhaiHaiQuanXuat"
        Me.dgToKhaiHaiQuanXuat.Size = New System.Drawing.Size(784, 400)
        Me.dgToKhaiHaiQuanXuat.TabIndex = 11
        Me.dgToKhaiHaiQuanXuat.Text = "Danh sách tờ khai hải quan"
        '
        'CbTu_Ngay
        '
        Me.CbTu_Ngay.DateTime = New Date(2008, 7, 3, 0, 0, 0, 0)
        Me.CbTu_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbTu_Ngay.Location = New System.Drawing.Point(8, 27)
        Me.CbTu_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbTu_Ngay.Name = "CbTu_Ngay"
        Me.CbTu_Ngay.Size = New System.Drawing.Size(104, 21)
        Me.CbTu_Ngay.TabIndex = 1
        Me.CbTu_Ngay.Value = New Date(2008, 7, 3, 0, 0, 0, 0)
        '
        'UltraLabel4
        '
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(8, 8)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 16)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Từ ngày"
        '
        'CbDen_Ngay
        '
        Me.CbDen_Ngay.DateTime = New Date(2009, 6, 23, 0, 0, 0, 0)
        Me.CbDen_Ngay.FormatProvider = New System.Globalization.CultureInfo("vi-VN")
        Me.CbDen_Ngay.Location = New System.Drawing.Point(120, 27)
        Me.CbDen_Ngay.MaskInput = "dd/mm/yyyy"
        Me.CbDen_Ngay.Name = "CbDen_Ngay"
        Me.CbDen_Ngay.Size = New System.Drawing.Size(104, 21)
        Me.CbDen_Ngay.TabIndex = 3
        Me.CbDen_Ngay.Value = New Date(2009, 6, 23, 0, 0, 0, 0)
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(120, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Ðến ngày"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(240, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Mã &E1"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Enabled = False
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(488, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel2.TabIndex = 8
        Me.UltraLabel2.Text = "Loại tờ khai"
        '
        'UltraLabel5
        '
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(384, 8)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "&Số tờ khai"
        '
        'lblThong_Tin
        '
        Me.lblThong_Tin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThong_Tin.Location = New System.Drawing.Point(8, 468)
        Me.lblThong_Tin.Name = "lblThong_Tin"
        Me.lblThong_Tin.Size = New System.Drawing.Size(72, 16)
        Me.lblThong_Tin.TabIndex = 16
        Me.lblThong_Tin.Text = "Bản ghi"
        '
        'txtTong_So
        '
        Appearance8.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So.Appearance = Appearance8
        Me.txtTong_So.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTong_So.Location = New System.Drawing.Point(80, 464)
        Me.txtTong_So.Name = "txtTong_So"
        Appearance9.TextHAlign = Infragistics.Win.HAlign.Right
        Me.txtTong_So.NullTextAppearance = Appearance9
        Me.txtTong_So.ReadOnly = True
        Me.txtTong_So.Size = New System.Drawing.Size(88, 24)
        Me.txtTong_So.TabIndex = 17
        Me.txtTong_So.Text = "0"
        '
        'txtMaE1
        '
        Appearance10.BackColor = System.Drawing.Color.Red
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.ForeColor = System.Drawing.Color.White
        Me.txtMaE1.Appearance = Appearance10
        Me.txtMaE1.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtMaE1.InputMask = "aaaaaaaaaaaaa"
        Me.txtMaE1.Location = New System.Drawing.Point(240, 28)
        Appearance11.FontData.BoldAsString = "True"
        Me.txtMaE1.MaskLiteralsAppearance = Appearance11
        Me.txtMaE1.Name = "txtMaE1"
        Me.txtMaE1.Size = New System.Drawing.Size(120, 20)
        Me.txtMaE1.TabIndex = 5
        '
        'txtSo_To_Khai
        '
        Appearance12.BackColor = System.Drawing.Color.Red
        Appearance12.FontData.BoldAsString = "True"
        Appearance12.ForeColor = System.Drawing.Color.White
        Me.txtSo_To_Khai.Appearance = Appearance12
        Me.txtSo_To_Khai.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtSo_To_Khai.InputMask = "999999"
        Me.txtSo_To_Khai.Location = New System.Drawing.Point(384, 28)
        Me.txtSo_To_Khai.Name = "txtSo_To_Khai"
        Me.txtSo_To_Khai.Size = New System.Drawing.Size(80, 20)
        Me.txtSo_To_Khai.TabIndex = 7
        '
        'cbLoai_To_Khai
        '
        Me.cbLoai_To_Khai.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        UltraGridColumn58.Header.Caption = "Mã loại"
        UltraGridColumn58.Header.VisiblePosition = 0
        UltraGridColumn58.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(47, 0)
        UltraGridColumn59.Header.Caption = "Loại kiểm hoá"
        UltraGridColumn59.Header.VisiblePosition = 1
        UltraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(157, 0)
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn58, UltraGridColumn59})
        UltraGridBand2.UseRowLayout = True
        Me.cbLoai_To_Khai.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cbLoai_To_Khai.DisplayMember = "Ten_Loai"
        Me.cbLoai_To_Khai.Enabled = False
        Me.cbLoai_To_Khai.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoai_To_Khai.Location = New System.Drawing.Point(488, 27)
        Me.cbLoai_To_Khai.Name = "cbLoai_To_Khai"
        Me.cbLoai_To_Khai.Size = New System.Drawing.Size(152, 21)
        Me.cbLoai_To_Khai.TabIndex = 9
        Me.cbLoai_To_Khai.ValueMember = "Ma_Loai"
        '
        'ddKieu_Kiem_Hoa
        '
        Me.ddKieu_Kiem_Hoa.Cursor = System.Windows.Forms.Cursors.Default
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddKieu_Kiem_Hoa.DisplayLayout.Appearance = Appearance13
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn61.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(175, 0)
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61})
        UltraGridBand3.UseRowLayout = True
        Me.ddKieu_Kiem_Hoa.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.ForeColor = System.Drawing.Color.Black
        Appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddKieu_Kiem_Hoa.DisplayLayout.Override.HeaderAppearance = Appearance14
        Me.ddKieu_Kiem_Hoa.DisplayMember = "Ten_Loai"
        Me.ddKieu_Kiem_Hoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddKieu_Kiem_Hoa.Location = New System.Drawing.Point(136, 160)
        Me.ddKieu_Kiem_Hoa.Name = "ddKieu_Kiem_Hoa"
        Me.ddKieu_Kiem_Hoa.Size = New System.Drawing.Size(208, 96)
        Me.ddKieu_Kiem_Hoa.TabIndex = 18
        Me.ddKieu_Kiem_Hoa.Text = "Tiền tệ"
        Me.ddKieu_Kiem_Hoa.ValueMember = "Ma_Loai"
        Me.ddKieu_Kiem_Hoa.Visible = False
        '
        'btnXoaToKhai
        '
        Appearance15.Image = CType(resources.GetObject("Appearance15.Image"), Object)
        Me.btnXoaToKhai.Appearance = Appearance15
        Me.btnXoaToKhai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaToKhai.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnXoaToKhai.Location = New System.Drawing.Point(208, 464)
        Me.btnXoaToKhai.Name = "btnXoaToKhai"
        Me.btnXoaToKhai.Size = New System.Drawing.Size(120, 40)
        Me.btnXoaToKhai.TabIndex = 12
        Me.btnXoaToKhai.Text = "&Xóa tờ khai"
        '
        'btnSuaToKhaiLoi
        '
        Appearance16.Image = CType(resources.GetObject("Appearance16.Image"), Object)
        Me.btnSuaToKhaiLoi.Appearance = Appearance16
        Me.btnSuaToKhaiLoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaToKhaiLoi.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSuaToKhaiLoi.Location = New System.Drawing.Point(496, 464)
        Me.btnSuaToKhaiLoi.Name = "btnSuaToKhaiLoi"
        Me.btnSuaToKhaiLoi.Size = New System.Drawing.Size(128, 40)
        Me.btnSuaToKhaiLoi.TabIndex = 14
        Me.btnSuaToKhaiLoi.Text = "Sửa tờ khai &lỗi"
        '
        'btnSuaToKhai
        '
        Appearance17.Image = CType(resources.GetObject("Appearance17.Image"), Object)
        Me.btnSuaToKhai.Appearance = Appearance17
        Me.btnSuaToKhai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaToKhai.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSuaToKhai.Location = New System.Drawing.Point(352, 464)
        Me.btnSuaToKhai.Name = "btnSuaToKhai"
        Me.btnSuaToKhai.Size = New System.Drawing.Size(120, 40)
        Me.btnSuaToKhai.TabIndex = 13
        Me.btnSuaToKhai.Text = "&Sửa tờ khai"
        '
        'btnThoat
        '
        Appearance18.Image = CType(resources.GetObject("Appearance18.Image"), Object)
        Appearance18.ImageAlpha = Infragistics.Win.Alpha.UseAlphaLevel
        Me.btnThoat.Appearance = Appearance18
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnThoat.Location = New System.Drawing.Point(664, 464)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(120, 40)
        Me.btnThoat.TabIndex = 15
        Me.btnThoat.Text = "&Thoát"
        '
        'ddMa_Nuoc
        '
        Me.ddMa_Nuoc.Cursor = System.Windows.Forms.Cursors.Default
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMa_Nuoc.DisplayLayout.Appearance = Appearance19
        UltraGridColumn62.Header.Caption = "Mã nước"
        UltraGridColumn62.Header.VisiblePosition = 0
        UltraGridColumn63.Header.Caption = "Tên nước"
        UltraGridColumn63.Header.VisiblePosition = 1
        UltraGridColumn64.Header.VisiblePosition = 2
        UltraGridColumn64.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn62, UltraGridColumn63, UltraGridColumn64})
        UltraGridBand4.UseRowLayout = True
        Me.ddMa_Nuoc.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance20.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.ForeColor = System.Drawing.Color.Black
        Appearance20.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMa_Nuoc.DisplayLayout.Override.HeaderAppearance = Appearance20
        Me.ddMa_Nuoc.DisplayMember = "Ma_Nuoc"
        Me.ddMa_Nuoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMa_Nuoc.Location = New System.Drawing.Point(292, 210)
        Me.ddMa_Nuoc.Name = "ddMa_Nuoc"
        Me.ddMa_Nuoc.Size = New System.Drawing.Size(208, 96)
        Me.ddMa_Nuoc.TabIndex = 19
        Me.ddMa_Nuoc.Text = "Mã nước"
        Me.ddMa_Nuoc.ValueMember = "Ma_Nuoc"
        Me.ddMa_Nuoc.Visible = False
        '
        'Nhap_So
        '
        Me.Nhap_So.Location = New System.Drawing.Point(560, 256)
        Me.Nhap_So.Name = "Nhap_So"
        Me.Nhap_So.Size = New System.Drawing.Size(100, 21)
        Me.Nhap_So.TabIndex = 20
        Me.Nhap_So.Visible = False
        '
        'ddMaTienTe
        '
        Me.ddMaTienTe.Cursor = System.Windows.Forms.Cursors.Default
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Me.ddMaTienTe.DisplayLayout.Appearance = Appearance21
        UltraGridColumn65.Header.Caption = "Mã tiền tệ"
        UltraGridColumn65.Header.VisiblePosition = 0
        UltraGridColumn66.Header.Caption = "Tên tiền tệ"
        UltraGridColumn66.Header.VisiblePosition = 1
        UltraGridColumn67.Header.VisiblePosition = 2
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 3
        UltraGridColumn68.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68})
        Me.ddMaTienTe.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(233, Byte), CType(242, Byte), CType(199, Byte))
        Appearance22.BackColor2 = System.Drawing.Color.FromArgb(CType(170, Byte), CType(184, Byte), CType(131, Byte))
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.ForeColor = System.Drawing.Color.Black
        Appearance22.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.ddMaTienTe.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ddMaTienTe.DisplayMember = ""
        Me.ddMaTienTe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddMaTienTe.Location = New System.Drawing.Point(64, 272)
        Me.ddMaTienTe.Name = "ddMaTienTe"
        Me.ddMaTienTe.Size = New System.Drawing.Size(208, 96)
        Me.ddMaTienTe.TabIndex = 24
        Me.ddMaTienTe.Text = "Tiền tệ"
        Me.ddMaTienTe.ValueMember = ""
        Me.ddMaTienTe.Visible = False
        '
        'Nhap_So_Thap_Phan
        '
        Me.Nhap_So_Thap_Phan.Location = New System.Drawing.Point(488, 344)
        Me.Nhap_So_Thap_Phan.Name = "Nhap_So_Thap_Phan"
        Me.Nhap_So_Thap_Phan.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double
        Me.Nhap_So_Thap_Phan.Size = New System.Drawing.Size(104, 21)
        Me.Nhap_So_Thap_Phan.TabIndex = 25
        Me.Nhap_So_Thap_Phan.Visible = False
        '
        'Frm_Sua_Chua_To_Khai
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 517)
        Me.Controls.Add(Me.Nhap_So_Thap_Phan)
        Me.Controls.Add(Me.ddMaTienTe)
        Me.Controls.Add(Me.Nhap_So)
        Me.Controls.Add(Me.ddMa_Nuoc)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoaToKhai)
        Me.Controls.Add(Me.btnSuaToKhaiLoi)
        Me.Controls.Add(Me.btnSuaToKhai)
        Me.Controls.Add(Me.ddKieu_Kiem_Hoa)
        Me.Controls.Add(Me.cbLoai_To_Khai)
        Me.Controls.Add(Me.txtSo_To_Khai)
        Me.Controls.Add(Me.txtMaE1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.CbTu_Ngay)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.CbDen_Ngay)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.btnTimToKhai)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.lblThong_Tin)
        Me.Controls.Add(Me.txtTong_So)
        Me.Controls.Add(Me.dgToKhaiHaiQuanXuat)
        Me.Name = "Frm_Sua_Chua_To_Khai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sửa chữa tờ khai Hải quan"
        CType(Me.dgToKhaiHaiQuanXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTu_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbDen_Ngay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTong_So, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoai_To_Khai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddKieu_Kiem_Hoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMa_Nuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nhap_So, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddMaTienTe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nhap_So_Thap_Phan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "------------Khai bao bien cho Form---------"
    Dim myToKhaiHaiQuanXuat As New To_Khai_Hai_Quan_Xuat(GConnectionString)
    Dim myToKhaiHaiQuanXuatChiTiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet
    Dim myE1KiemHoaXuat As New E1_Kiem_Hoa_Xuat(GConnectionString)
    Dim myE1HangKiemHoaXuat As New E1_Hang_Kiem_Hoa_Xuat(GConnectionString)
    Dim myE1_Di As New E1_Di(GConnectionString)
    Dim myHam_Dung_Chung As New Ham_Dung_Chung
    Dim myGridKeyDown As Infragistics.Win.UltraWinGrid.UltraGrid
    Dim myCell As Infragistics.Win.UltraWinGrid.UltraGridCell
    Dim myDa_Kiem_Hoa As Boolean
    Private Const myThong_Tin_Tai_Lieu As String = "Thư, chứng từ, tài liệu đã giao dịch"
#End Region

#Region "-------------Form Load--------------"
    Private Sub Frm_Sua_Chua_To_Khai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mDataTmp As New DataTable
        CbTu_Ngay.Value = myHam_Dung_Chung.ConvertIntToDate(myHam_Dung_Chung.MinusIntDate(myHam_Dung_Chung.ConvertDateToInt(Now.Date), GSo_Ngay_E1_Duoc_Trung))
        CbDen_Ngay.Value = Now.Date
        myDa_Kiem_Hoa = True
        Tao_Bang_Phan_Loai_Kiem_Hoa()
        mDataTmp = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Danh_Sach_Sua_Chua_To_Khai(1, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), "", 0, "").Tables(0)
        DataGrid_To_Khai(mDataTmp)
        txtMaE1.Select()
    End Sub
#End Region

#Region "-----------Tab Control Got_Focus-----------"
    Private Sub CbTu_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTu_Ngay.GotFocus
        CbTu_Ngay.SelectionStart = 0
        CbTu_Ngay.SelectionLength = CbTu_Ngay.Text.Length
    End Sub

    Private Sub CbDen_Ngay_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbDen_Ngay.GotFocus
        CbDen_Ngay.SelectionStart = 0
        CbDen_Ngay.SelectionLength = CbDen_Ngay.Text.Length
    End Sub

    Private Sub txtMaE1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.GotFocus
        txtMaE1.SelectionStart = 0
        txtMaE1.SelectionLength = txtMaE1.Text.Length
    End Sub

    Private Sub txtSo_To_Khai_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_To_Khai.GotFocus
        txtSo_To_Khai.SelectionStart = 0
        txtSo_To_Khai.SelectionLength = txtSo_To_Khai.Text.Length
    End Sub
#End Region

#Region "-------------Tab Control KeyDown-------------"
    Private Sub CbDen_Ngay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbDen_Ngay.KeyDown, cbLoai_To_Khai.KeyDown, CbTu_Ngay.KeyDown
        If e.KeyValue = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, forward:=True, tabStopOnly:=True, nested:=True, wrap:=False)
        End If
    End Sub

#Region "------------txtMaE1_KeyDown--------"
    Private Sub txtMaE1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMaE1.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnTimToKhai.Select()
        End If
    End Sub
#End Region
#End Region

#Region "-------------Tab Control ---------------"
#Region "------------btnTimToKhai_Click--------"
    Private Sub btnTimToKhai_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTimToKhai.Click
        Dim mDataTmp As New DataTable
        Dim iKieu As Integer
        Dim iMa_E1 As Byte
        Dim iLoai_To_Khai As Byte
        Dim iSo_To_Khai As Byte
        'txtMa_E1
        If txtMaE1.Text <> "" Then
            iMa_E1 = 1
        Else
            iMa_E1 = 0
        End If
        'cbLoai_To_Khai
        If cbLoai_To_Khai.Text <> "" Then
            iLoai_To_Khai = 1
        Else
            iLoai_To_Khai = 0
        End If
        'txtSo_To_Khai
        If txtSo_To_Khai.Text <> "" Then
            iSo_To_Khai = 1
        Else
            iSo_To_Khai = 0
        End If
        iKieu = iSo_To_Khai * 1 + iLoai_To_Khai * 2 + iMa_E1 * 4
        If iKieu = 0 Then
            MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMaE1.Select()
            Exit Sub
        End If
        mDataTmp = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Danh_Sach_Sua_Chua_To_Khai(iKieu, myHam_Dung_Chung.ConvertDateToInt(CbTu_Ngay.Value), myHam_Dung_Chung.ConvertDateToInt(CbDen_Ngay.Value), txtMaE1.Text, IIf(cbLoai_To_Khai.Value Is DBNull.Value, 0, cbLoai_To_Khai.Value), txtSo_To_Khai.Text).Tables(0)
        DataGrid_To_Khai(mDataTmp)
        If dgToKhaiHaiQuanXuat.Rows.Count > 0 Then
            'dgToKhaiHaiQuanXuat.Select()
            'dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.Rows(0).Cells("Mo_To_Khai")
            'dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
        Else
            MessageBox.Show("Không tìm thấy tờ khai nào thoả mãn điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK)
            txtMaE1.Select()
        End If
    End Sub
#End Region

#Region "-----------txtSo_To_Khai_Validated------------"
    Private Sub txtSo_To_Khai_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_To_Khai.Validated
        If txtSo_To_Khai.Text <> "" Then
            txtSo_To_Khai.Text = Format_So_TKHQ(CInt(txtSo_To_Khai.Text))
        End If
    End Sub
#End Region

#Region "-------------dgToKhaiHaiQuanXuat----------"
#Region "--------------dgToKhaiHaiQuanXuat_InitializeLayout------------"
    Private Sub dgToKhaiHaiQuanXuat_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles dgToKhaiHaiQuanXuat.InitializeLayout
        Dim i As Integer
        dgToKhaiHaiQuanXuat.DisplayLayout.Override.ActiveCellAppearance.BackColor = Color.PowderBlue
        dgToKhaiHaiQuanXuat.DisplayLayout.Override.ActiveRowAppearance.BackColor = Color.PowderBlue

        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Kieu_Kiem_Hoa").Style = ColumnStyle.DropDownValidate
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Kieu_Kiem_Hoa").ValueList = ddKieu_Kiem_Hoa

        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Thong_Tin_Tai_Lieu").Style = ColumnStyle.CheckBox
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Chot_SL").Style = ColumnStyle.CheckBox

        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Tong_So_Tui").EditorControl = Nhap_So
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Tong_Khoi_Luong").EditorControl = Nhap_So_Thap_Phan

        'Set lai cac cot cho phep duoc sua thong tin
        'Allow Edit
        Dim idx As Integer
        For idx = 0 To dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns.Count - 1
            dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns(idx).CellActivation = Activation.ActivateOnly
        Next
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Ngay_Khai").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Gio_Khai").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("So_To_Khai_HQ_Cap").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Giay_To_Kem_Theo").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Ngay_CN38").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Nguoi_Duoc_Uy_Quyen").CellActivation = Activation.AllowEdit
        'dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Nguoi_Gui").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Nguoi_Nhan").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Tong_So_Tui").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Tong_Khoi_Luong").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Thong_Tin_Tai_Lieu").CellActivation = Activation.AllowEdit
        dgToKhaiHaiQuanXuat.DisplayLayout.Bands(0).Columns("Chot_SL").CellActivation = Activation.AllowEdit

        'Hien thong tin tong so ban ghi
        Refresh_Information()

    End Sub
#End Region

#Region "--------------dgToKhaiHaiQuanXuat_AfterRowActivate--------------"
    Private Sub dgToKhaiHaiQuanXuat_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgToKhaiHaiQuanXuat.AfterRowActivate
        Refresh_Information()
    End Sub
#End Region

#Region "------------------dgToKhaiHaiQuanXuat_KeyDown-------------------"
    Private Sub dgToKhaiHaiQuanXuat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgToKhaiHaiQuanXuat.KeyDown
        Try
            If dgToKhaiHaiQuanXuat.ActiveCell Is Nothing Then
                Exit Sub
            End If
            myGridKeyDown = sender
            'Kiem tra cac loai Keys
            Select Case e.KeyValue
                Case Keys.Enter, Keys.Tab
                    'Thoat khoi Cell
                    myGridKeyDown.PerformAction(ExitEditMode, False, False)
                    myGridKeyDown.PerformAction(NextCellByTab, False, False)
                    e.Handled = True
                    myGridKeyDown.PerformAction(EnterEditMode, False, False)
                Case Keys.Right
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.Text <> "" And myGridKeyDown.ActiveCell.SelStart = myGridKeyDown.ActiveCell.Text.Length Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(NextCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(NextCellByTab, False, True)
                    End If
                Case Keys.Left
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveCell.SelStart = 0 Then
                            e.Handled = False
                            myGridKeyDown.PerformAction(EnterEditMode, False, False)
                            myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                        End If
                    Else
                        e.Handled = False
                        myGridKeyDown.PerformAction(EnterEditMode, False, False)
                        myGridKeyDown.PerformAction(PrevCellByTab, False, True)
                    End If
                Case Keys.Up
                    If myGridKeyDown.ActiveCell.Activation = Activation.AllowEdit Then
                        If myGridKeyDown.ActiveRow.Index > 0 Then
                            myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                            myGridKeyDown.ActiveCell = myCell
                            myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                        End If
                    Else
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index - 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
                Case Keys.Down
                    If myGridKeyDown.ActiveRow.Index < myGridKeyDown.Rows.Count - 1 Then
                        myCell = myGridKeyDown.Rows(myGridKeyDown.ActiveRow.Index + 1).Cells(myGridKeyDown.ActiveCell.Column.Key)
                        myGridKeyDown.ActiveCell = myCell
                        myGridKeyDown.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                    End If
            End Select
        Catch ex As Exception
            ' Call the exception handler
            MessageBox.Show("Thao tác không hợp lệ!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "------------txtMaE1_LostFocus--------------"
    Private Sub txtMaE1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.LostFocus
        txtMaE1.Text = txtMaE1.Text.ToUpper
    End Sub
#End Region

#Region "--------------txtMaE1_Validated--------------"
    Private Sub txtMaE1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaE1.Validated
        If txtMaE1.Text.Trim <> "" Then
            If txtMaE1.Text.Trim.Length < 6 Then
                MessageBox.Show("Thông tin mã E1 không hợp lệ, phải nhập tối thiểu là 6 ký tự!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMaE1.Select()
            End If
        End If
    End Sub
#End Region

#Region "------------txtSo_To_Khai_KeyDown-------------"
    Private Sub txtSo_To_Khai_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSo_To_Khai.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnTimToKhai.Select()
        End If
    End Sub
#End Region

#Region "---------------btnThoat_Click-----------------"
    Private Sub btnThoat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
        Me.Dispose()
    End Sub
#End Region

#Region "---------------btnXoaToKhai_Click----------------"
    Private Sub btnXoaToKhai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaToKhai.Click
        Try
            'Kiem tra nguoi dung chua chon to khai nao tron DS
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text = "" Then
                MessageBox.Show("Bạn chưa chọn tờ khai nào trong danh sách!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            '================================================
            Dim m_Id_E1 As String
            Dim m_E1_Kiem_Hoa_Xuat_Table As New DataTable
            Dim i As Integer
            myToKhaiHaiQuanXuatChiTiet = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Lay(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text)
            If myToKhaiHaiQuanXuatChiTiet.Chot_SL = True Then
                MessageBox.Show("Tờ khai này đã được chốt số liệu. Bạn không được phép xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If myToKhaiHaiQuanXuatChiTiet.IsPrint Then
                If Not MessageBox.Show("Tờ khai này đã được in rồi. Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question + MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    Exit Sub
                End If
            End If
            'Lay thong tin E1 Kiem Hoa thuoc Ma_To_Khai
            m_E1_Kiem_Hoa_Xuat_Table = myE1KiemHoaXuat.E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(myToKhaiHaiQuanXuatChiTiet.Ma_To_Khai).Tables(0)
            If m_E1_Kiem_Hoa_Xuat_Table.Rows.Count > 0 Then
                'Lay Id_E1
                m_Id_E1 = m_E1_Kiem_Hoa_Xuat_Table.Rows(0).Item("Id_E1")
                'Kiem tra trong E1_Di
                If Not myE1_Di.Lay(m_Id_E1).Ma_E1 <> "" Then   'Neu co trong to khai 
                    If MessageBox.Show("Các bưu phẩm E1 thuộc tờ khai này đã được đóng đi, bạn có chắc chắn muốn xoá tờ khai này không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question + MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                        Exit Sub
                    End If
                End If
            End If
            'OK ==> Tiep tuc
            If MessageBox.Show("Bạn có thật sự muốn xoá tờ khai số: [" & myToKhaiHaiQuanXuatChiTiet.So_TKHQ & "] không???" & Chr(13) & "Nếu đồng ý thì tất cả thông tin về tờ khai này sẽ bị xoá hết", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                'Xoa to khai
                If Xoa_To_Khai(myToKhaiHaiQuanXuatChiTiet.Ma_To_Khai) Then
                    dgToKhaiHaiQuanXuat.ActiveRow.Delete(False)
                    If dgToKhaiHaiQuanXuat.Rows.Count > 0 Then
                        dgToKhaiHaiQuanXuat.ActiveRow = dgToKhaiHaiQuanXuat.Rows(0)
                    End If
                    'Refresh_Form
                    Refresh_Information()
                    'Thong bao thanh cong
                    CMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Lỗi xoá tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "-----------------btnSuaToKhai_Click-------------------"
    Private Sub btnSuaToKhai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuaToKhai.Click
        Try
            'Kiem tra nguoi dung chua chon to khai nao tron DS
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text = "" Then
                MessageBox.Show("Bạn chưa chọn tờ khai nào trong danh sách!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            myToKhaiHaiQuanXuatChiTiet = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Lay(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text)

            If myToKhaiHaiQuanXuatChiTiet.Chot_SL = True Then
                MessageBox.Show("Tờ khai này đã được chốt số liệu. Bạn không được phép sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btnTimToKhai_Click(Nothing, Nothing)
                Exit Sub
            End If

            If MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin của tờ khai số: [" & myToKhaiHaiQuanXuatChiTiet.So_TKHQ & "] không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
            'Kiem tra 
            If Test_Before_Update() Then
                'Cap nhat
                If Cap_Nhat_To_Khai() Then  'Thanh cong
                    MessageBox.Show("Đã sửa tờ khai thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else   'That bai
                    MessageBox.Show("Sửa tờ khai thất bại", "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "------------------btnSuaToKhaiLoi_Click--------------------"
    Private Sub btnSuaToKhaiLoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuaToKhaiLoi.Click
        Try
            'Kiem tra nguoi dung chua chon to khai nao tron DS
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text = "" Then
                MessageBox.Show("Bạn chưa chọn tờ khai nào trong danh sách!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            '==============================================================
            myToKhaiHaiQuanXuatChiTiet = myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Lay(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text)
            Select Case Sua_To_Khai_Loi(myToKhaiHaiQuanXuatChiTiet)
                Case 0  '  Tờ khai không lỗi
                    MessageBox.Show("Tờ khai này không bị lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 1  '  Tờ khai rỗng
                    MessageBox.Show("Sửa tờ khai thành công !!!" & vbNewLine & "Đây là tờ khai rỗng, chương trình đã tự động xoá tờ khai này.", "Thông báo", MessageBoxButtons.OK)
                Case 2  '  Tờ khai co chi tiết nhưng tổng khối lượng = 0
                    MessageBox.Show("Tờ khai đã được đóng lại, nhưng chương trình không sửa được lỗi của tờ khai." & vbNewLine & "Bạn phải vào chức năng kiểm hoá để mở tờ khai này và cập nhật lại thông tin.", "Thông báo", MessageBoxButtons.OK)
                Case 3  '  Tờ khai không lỗi nhưng đang được mở
                    MessageBox.Show("Tờ khai đã được đóng lại, nhưng chương trình không tự động sửa thông tin của tờ khai." & vbNewLine & "Bạn nên vào chức năng kiểm hoá để mở tờ khai này và cập nhật lại thông tin.", "Thông báo", MessageBoxButtons.OK)
                Case 4  '  Tờ khai có E1 nhưng không có E1_Hang
                    MessageBox.Show("Tờ khai đã được đóng lại, nhưng chương trình không tự động sửa lỗi cho tờ khai." & vbNewLine & "Bạn phải vào chức năng kiểm hoá để mở tờ khai này và cập nhật lại thông tin.", "Thông báo", MessageBoxButtons.OK)
                Case 5  '  Tờ khai không có E1 nhưng lại có E1_Hang
                    MessageBox.Show("Tờ khai đã được đóng lại, nhưng chương trình không tự động sửa lỗi cho tờ khai." & vbNewLine & "Bạn phải vào chức năng kiểm hoá để mở tờ khai này và cập nhật lại thông tin.", "Thông báo", MessageBoxButtons.OK)
                Case 9  '  Nguoi dung chon No => không làm gì
                Case 10 '  Không tồn tại tờ khai
                    MessageBox.Show("Tờ khai này không tồn tại, vì vậy bạn không thể sữa lỗi tờ khai.", "Thông báo", MessageBoxButtons.OK)
                Case Else
                    MessageBox.Show("Lỗi chương trình, sửa tờ khai thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#End Region

#Region "-------------Ham nguoi dung-------------"
#Region "-----------------Tạo bảng phân loại kiểm hoá-------------------"
    Private Sub Tao_Bang_Phan_Loai_Kiem_Hoa()
        'Co 3 he thong to khai tuong ung voi 3 loai sau
        '---1. Loai = 5: So to khai hang vien tro
        '---2. Loai = 9: So to khai hang xuat khau
        '---3. Loai = con lai: So to khai hang nhap khau

        'Them moi mot bang
        Dim dataTable As New dataTable("Loai_Kiem_Hoa")

        'Tao ra cac cot cua bang nay
        Dim colWork As DataColumn = New DataColumn("Ma_Loai", GetType(Int32))
        dataTable.Columns.Add(colWork)
        colWork = New DataColumn("Ten_Loai", GetType(String))
        dataTable.Columns.Add(colWork)

        'A. ------------- SO TO KHAI HANG NHAP KHAU
        'Them du lieu vao
        Dim row As DataRow
        '0.--------Tai lieu (D)                 ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 0
        row("Ten_Loai") = "Tài liệu"
        dataTable.Rows.Add(row)

        '1.--------Hang Hoa (M) soi may         ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 1
        row("Ten_Loai") = "Soi máy"
        dataTable.Rows.Add(row)

        '2.--------Hang PMD co thue (M)         ---- To khai HQ02    
        row = dataTable.NewRow
        row("Ma_Loai") = 2
        row("Ten_Loai") = "Có thuế"
        dataTable.Rows.Add(row)

        '3.--------Hang chuyen hoan             ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 3
        row("Ten_Loai") = "Chuyển hoàn"
        dataTable.Rows.Add(row)

        '----------Hang mien kiem (Dai su quan, Lanh su quan)
        '4.--------Hang mien kiem (M)           ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 4
        row("Ten_Loai") = "Miễn kiểm"
        dataTable.Rows.Add(row)

        'B. ------------- SO TO KHAI HANG VIEN TRO
        '5.--------Hàng viện trợ                ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 5
        row("Ten_Loai") = "Viện trợ"
        dataTable.Rows.Add(row)

        ''Hang mo kiem tinh thue = 0(chuyen loai)        
        '6.--------Hang mau dich (M)            ---- Inlist (HQ01 + HQ02)
        row = dataTable.NewRow
        row("Ma_Loai") = 6
        row("Ten_Loai") = "Mở kiểm không thuế"
        dataTable.Rows.Add(row)

        '7.--------Hang hanh ly & mien thue (mo kiem nhung khong khai thue)
        row = dataTable.NewRow
        row("Ma_Loai") = 7
        row("Ten_Loai") = "Hành lý & miễn thuế"
        dataTable.Rows.Add(row)

        'C. ------------- SO TO KHAI HANG XUAT KHAU
        '9.--------Hang QT chuyen hoan và hàng VN xuất đi QT
        row = dataTable.NewRow
        row("Ma_Loai") = 9
        row("Ten_Loai") = "Hàng xuất đi QT"
        dataTable.Rows.Add(row)
        '10. ------Hang chuyen hoan di QTe
        row = dataTable.NewRow
        row("Ma_Loai") = 10
        row("Ten_Loai") = "Chuyển hoàn đi Q.Tế"
        dataTable.Rows.Add(row)

        'Load Data
        cbLoai_To_Khai.DataSource = dataTable
        cbLoai_To_Khai.DataBind()
        cbLoai_To_Khai.Value = 9
        'cbLoai_To_Khai.LimitToList = True
        ddKieu_Kiem_Hoa.DataSource = dataTable
        ddKieu_Kiem_Hoa.DataBind()
    End Sub
#End Region

#Region "---------------DataGrid_To_Khai--------------"
    Private Sub DataGrid_To_Khai(ByVal mData As DataTable)
        dgToKhaiHaiQuanXuat.DataSource = mData
        dgToKhaiHaiQuanXuat.DataBind()
    End Sub
#End Region

#Region "--------------Refresh_Information----------------"
    Private Sub Refresh_Information()
        Try
            If dgToKhaiHaiQuanXuat.Rows.Count = 0 Then
                lblThong_Tin.Text = "Tổng số"
                txtTong_So.Text = "0"
            Else
                If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Text <> "" Then
                    Dim Dong_Hien_Tai As Integer
                    Dim Tong_So_Dong As Integer
                    Dong_Hien_Tai = dgToKhaiHaiQuanXuat.ActiveRow.Index + 1
                    Tong_So_Dong = dgToKhaiHaiQuanXuat.Rows.Count
                    lblThong_Tin.Text = "Bản ghi"
                    txtTong_So.Text = Dong_Hien_Tai.ToString & " / " & Tong_So_Dong.ToString
                Else
                    lblThong_Tin.Text = "Tổng số"
                    txtTong_So.Text = dgToKhaiHaiQuanXuat.Rows.Count.ToString
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "-----------------Xoa_To_Khai----------------"
    Private Function Xoa_To_Khai(ByVal Ma_To_Khai As String) As Boolean
        Try
            'Xóa dữ liệu trong bảng E1_Hang_Kiem_Hoa_Xuat
            myE1HangKiemHoaXuat.E1_Hang_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai(Ma_To_Khai)
            'Xóa dữ liệu trong bảng E1_Kiem_Hoa_Xuat
            myE1KiemHoaXuat.E1_Kiem_Hoa_Xuat_Xoa_Boi_Ma_To_Khai(Ma_To_Khai)
            'Xóa dữ liệu trong bảng To_Khai_Hai_Quan_Xuat
            myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Xoa(Ma_To_Khai)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------Test_Before_Update-------------------"
    Private Function Test_Before_Update() As Boolean
        Try
            'Ngay Khai
            If Abs(myToKhaiHaiQuanXuatChiTiet.Ngay_Khai - myHam_Dung_Chung.ConvertDateToInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_Khai").Value)) > 5 Then
                If MessageBox.Show("Thông tin ngày khai mới sai khác với ngày khai cũ hơn 5 ngày!!!" & vbNewLine & "Bạn có chắc chắn muốn sửa tờ khai này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dgToKhaiHaiQuanXuat.Focus()
                    dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_Khai")
                    dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
                    Return False
                    Exit Function
                End If
            End If
            ''So To Khai Hai Quan cap nhap tay vao
            'If dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_To_Khai").Text.Trim <> "" Then
            '    If Not IsNumeric(dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_To_Khai").Text) Then
            '        MessageBox.Show("Số tờ khai Hải quan cấp phải là số!!!. Mời bạn nhập lại Số tờ khai nhập tay", "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '        dgToKhaiHaiQuanXuat.Focus()
            '        dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_To_Khai")
            '        dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
            '        Return False
            '        Exit Function
            '    End If
            'End If
            'Tong So Tui
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_So_Tui").Value > 50 Then
                If MessageBox.Show("Tổng số túi > 50 !!!" & "Bạn có chắc chắn muốn sửa tờ khai này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dgToKhaiHaiQuanXuat.Focus()
                    dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_So_Tui")
                    dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
                    Return False
                    Exit Function
                End If
            End If
            'Tong Khoi Luong
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_Khoi_Luong").Value > 50 Then
                If MessageBox.Show("Tổng khối lượng hàng hoá > 50 Kg!!!" & "Bạn có chắc chắn muốn sửa tờ khai này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    dgToKhaiHaiQuanXuat.Focus()
                    dgToKhaiHaiQuanXuat.ActiveCell = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_Khoi_Luong")
                    dgToKhaiHaiQuanXuat.PerformAction(EnterEditMode, False, False)
                    Return False
                    Exit Function
                End If
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------Cap_Nhat_To_Khai-------------------"
    Private Function Cap_Nhat_To_Khai() As Boolean
        Try
            'lay du lieu
            Dim mTo_Khai_Hai_Quan_Xuat_Chi_Tiet As New To_Khai_Hai_Quan_Xuat_Chi_Tiet
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_To_Khai").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ = dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_TKHQ").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai = myHam_Dung_Chung.ConvertDateToInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_Khai").Value)
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai = myHam_Dung_Chung.ConvertTimeToInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Gio_Khai").Value)
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap = Format_So_To_Khai(dgToKhaiHaiQuanXuat.ActiveRow.Cells("So_To_Khai_HQ_Cap").Text)
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Luong").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Nguoi_Duoc_Uy_Quyen").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Can_Bo_Kiem_Tra").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Can_Bo_Tinh_Thue").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Can_Bo_Xac_Nhan").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Nguoi_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Dia_Chi_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Dien_Thoai_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("CMT_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("CMT_Ngay_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Nuoc_Gui").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Nguoi_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Dia_Chi_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Dien_Thoai_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("CMT_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("CMT_Ngay_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Nuoc_Nhan").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsPrint").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsPhuLuc").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsOpen").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Kieu_Kiem_Hoa").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Giay_To_Kem_Theo").Text
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_So_Tui").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_Khoi_Luong").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_So_Kien").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38 = myHam_Dung_Chung.ConvertDateToInt(dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_CN38").Value)
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ghi_Chu").Text
            If dgToKhaiHaiQuanXuat.ActiveRow.Cells("Thong_Tin_Tai_Lieu").Value Then
                mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = myThong_Tin_Tai_Lieu
            Else
                mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu = ""
            End If
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsQua_Tang").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsHang_Mau").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsPay").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax = dgToKhaiHaiQuanXuat.ActiveRow.Cells("IsPayTax").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Cuoc_Van_Chuyen").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_Tien_Te").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ty_Gia").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Cuoc_Van_Chuyen_VN").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tri_So_Van_Chuyen").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tien_Qua_Tang").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Le_Phi_HQ").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tri_Gia_Nguyen_Te").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_Thue_Suat").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Tong_Thue_Vat").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ty_Gia_USD").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Id_Phan_Loai").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ma_Tien_Te_HQ").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Id_Duong_Thu").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ip_May_Tinh").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ban_So").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Truyen_So_Lieu").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Ngay_He_Thong").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Gio_He_Thong").Value
            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL = dgToKhaiHaiQuanXuat.ActiveRow.Cells("Chot_SL").Value

            'Cap nhat
            myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Them(mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_To_Khai, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_TKHQ, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_Khai, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_Khai, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.So_To_Khai_HQ_Cap, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Luong, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Duoc_Uy_Quyen, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Kiem_Tra, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Tinh_Thue, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Can_Bo_Xac_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Gui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nguoi_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dia_Chi_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Dien_Thoai_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.CMT_Ngay_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Nuoc_Nhan, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPrint, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPhuLuc, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsOpen, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Kieu_Kiem_Hoa, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Giay_To_Kem_Theo, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Tui, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Khoi_Luong, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_So_Kien, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_CN38, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ghi_Chu, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Thong_Tin_Tai_Lieu, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsQua_Tang, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsHang_Mau, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPay, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.IsPayTax, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Cuoc_Van_Chuyen_VN, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_So_Van_Chuyen, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tien_Qua_Tang, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Le_Phi_HQ, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tri_Gia_Nguyen_Te, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Suat, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Tong_Thue_Vat, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ty_Gia_USD, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Phan_Loai, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ma_Tien_Te_HQ, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Id_Duong_Thu, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ip_May_Tinh, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ban_So, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Truyen_So_Lieu, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Ngay_He_Thong, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Gio_He_Thong, _
                                                            mTo_Khai_Hai_Quan_Xuat_Chi_Tiet.Chot_SL)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "-----------------Format_So_To_Khai----------------"
    Private Function Format_So_To_Khai(ByVal So_To_Khai As String) As String
        If IsNumeric(So_To_Khai) Then
            Return CInt(So_To_Khai).ToString("000000")
        Else
            Return IIf(So_To_Khai.Trim = "", "", So_To_Khai)
        End If
    End Function
#End Region

#Region "------------Sua_To_Khai_Loi----------------"
    Private Function Sua_To_Khai_Loi(ByVal mToKhaiHaiQuanXuatChiTiet As To_Khai_Hai_Quan_Xuat_Chi_Tiet) As Integer
        Try
            'Kiểm tra tờ khai có tồn tại không
            If mToKhaiHaiQuanXuatChiTiet.So_TKHQ = "" Or mToKhaiHaiQuanXuatChiTiet.So_TKHQ Is DBNull.Value Then
                'Không tồn tại
                Return 10
                Exit Function
            End If
            'Có tồn tại => phân loại sửa lỗi
            Dim mE1_Kiem_Hoa_Xuat As New DataTable
            Dim mE1_Hang_Kiem_Hoa_Xuat As New DataTable
            mE1_Kiem_Hoa_Xuat = myE1KiemHoaXuat.E1_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai_Hang_Xuat(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai).Tables(0)
            mE1_Hang_Kiem_Hoa_Xuat = myE1HangKiemHoaXuat.E1_Hang_Kiem_Hoa_Xuat_Danh_Sach_Lay_Boi_Ma_To_Khai(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai).Tables(0)
            '3 truong hop
            '----1.Tờ khai rỗng (không có E1_Kiem_Hoa_Xuat và E1_Hang_Kiem_Hoa_Xuat) => Xoá
            If mE1_Kiem_Hoa_Xuat.Rows.Count <= 0 And mE1_Hang_Kiem_Hoa_Xuat.Rows.Count <= 0 And mToKhaiHaiQuanXuatChiTiet.Thong_Tin_Tai_Lieu = "" Then
                myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Xoa(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai)
                Return 1
                Exit Function
            End If
            '----2.Tờ khai không rỗng nhưng tổng = 0 => Tổng hợp lại
            If (mE1_Kiem_Hoa_Xuat.Rows.Count > 0 And mE1_Hang_Kiem_Hoa_Xuat.Rows.Count > 0 And mToKhaiHaiQuanXuatChiTiet.Tong_So_Kien = 0) Then
                If MessageBox.Show("Tờ khai này có vấn đề ! Có thông tin chi tiết trong tờ khai, nhưng không có thông tin tổng cho tờ khai." & vbNewLine & "Bạn phải chắc chắn rằng không có người dùng khác nào đang mở và cập nhật tờ khai này." & vbNewLine & "Nếu bạn đồng ý thì chương trình sẽ đóng tờ khai này lại, sau đó bạn có thể truy cập vào tờ khai này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Return 9
                    Exit Function
                End If
                'Tong hop lai to khai
                myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai, False)
                '-------------------------------------------
                Return 2
                Exit Function
            End If
            '----3.Tờ khai không rỗng, IsOpen = True (Đang mở) => cập nhật lại isOpen = False
            If (mToKhaiHaiQuanXuatChiTiet.IsOpen = True) Then
                If MessageBox.Show("Tờ khai này đang ở trạng thái mở !" & vbNewLine & "Bạn phải chắc chắn rằng không có người dùng khác nào đang mở và cập nhật tờ khai này." & vbNewLine & "Nếu bạn đồng ý thì chương trình sẽ đóng tờ khai này lại, sau đó bạn có thể truy cập vào tờ khai này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Return 9
                    Exit Function
                End If
                'Cap nhat to khai IsOpen = False
                myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai, False)
                Return 3
                Exit Function
            End If
            '----4.Tờ khai có E1_Kiem_Hoa_Xuat nhưng không có E1_Hang_Kiem_Hoa_Xuat => ra thông báo, cập nhật IsOpen = False
            If (mE1_Kiem_Hoa_Xuat.Rows.Count > 0 And mE1_Hang_Kiem_Hoa_Xuat.Rows.Count <= 0) Then
                If MessageBox.Show("Tờ khai này có vấn đề ! Có thông tin E1 nhưng không có thông tin về hàng hoá khai hải quan." & vbNewLine & "Bạn phải chắc chắn rằng không có người dùng khác nào đang mở và cập nhật tờ khai này." & vbNewLine & "Nếu bạn đồng ý thì chương trình sẽ đóng tờ khai này lại, sau đó bạn có thể truy cập vào tờ khai này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Return 9
                    Exit Function
                End If
                'Cap nhat to khai IsOpen = False
                myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai, False)
                Return 4
                Exit Function
            End If
            '----5.Tờ khai không có E1_Kiem_Hoa_Xuat nhưng có E1_Hang_Kiem_Hoa_Xuat => ra thông báo, cập nhật IsOpen = False
            If (mE1_Kiem_Hoa_Xuat.Rows.Count <= 0 And mE1_Hang_Kiem_Hoa_Xuat.Rows.Count > 0) Then
                If MessageBox.Show("Tờ khai này có vấn đề ! Không có thông tin E1 nhưng lại có thông tin về hàng hoá khai hải quan." & vbNewLine & "Bạn phải chắc chắn rằng không có người dùng khác nào đang mở và cập nhật tờ khai này." & vbNewLine & "Nếu bạn đồng ý thì chương trình sẽ đóng tờ khai này lại, sau đó bạn có thể truy cập vào tờ khai này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Return 9
                    Exit Function
                End If
                'Cap nhat to khai IsOpen = False
                myToKhaiHaiQuanXuat.To_Khai_Hai_Quan_Xuat_Cap_Nhat_Trang_Thai_IsOpen(mToKhaiHaiQuanXuatChiTiet.Ma_To_Khai, False)
                Return 5
                Exit Function
            End If
            'Tờ khai không bị lỗi
            Return 0
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Lỗi sửa tờ khai", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region

#End Region

End Class
